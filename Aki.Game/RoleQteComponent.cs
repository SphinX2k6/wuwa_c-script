using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using AkiClient.Game.Aki.Data.Fight.Struct;
using CSharpScript.Game;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.CombatMessage;
using CSharpScript.Game.NewWorld.Character.Common.Component;
using UnrealEngine;

// Token: 0x020027C1 RID: 10177
[NullableContext(1)]
[Nullable(0)]
public class RoleQteComponent : EntityComponent
{
	// Token: 0x0601984E RID: 104526 RVA: 0x007D2CD0 File Offset: 0x007D0ED0
	protected override bool OnStart()
	{
		this.ActorComponent = base.Entity.GetComponent<CharacterActorComponent>();
		this.AbilityComponent = base.Entity.CheckGetComponent<CharacterAbilityComponent>();
		this.TagComponent = base.Entity.CheckGetComponent<BaseTagComponent>();
		this.BuffComponent = base.Entity.CheckGetComponent<CharacterBuffComponent>();
		this.TeamComponent = base.Entity.CheckGetComponent<RoleTeamComponent>();
		this.SkillComponent = base.Entity.CheckGetComponent<CharacterSkillComponent>();
		this.ElementComponent = base.Entity.CheckGetComponent<RoleElementComponent>();
		this.QteTagListeners.Add(this.TagComponent.ListenForTagAddOrRemove(new int?(GameplayTagDefine.EGameplayTagId["功能.功能制作.QTE.激活QTE"]), new BaseTagComponent.TTagSwitchedCallback(this.OnActiveQteTagChange), null));
		this.QteTagListeners.Add(this.TagComponent.ListenForTagAddOrRemove(new int?(GameplayTagDefine.EGameplayTagId["角色.Common.技能通用标识.QTE"]), new BaseTagComponent.TTagSwitchedCallback(this.OnQteSkillTagChange), null));
		EventSystem.Instance.Add(EEventName.OnEnterOnlineWorld, new Action(this.OnEnterOnlineWorld));
		EventSystem.Instance.Add<int>(EEventName.CharQteConsume, new Action<int>(this.QteConsume));
		this.InitTriggerTags();
		return true;
	}

	// Token: 0x0601984F RID: 104527 RVA: 0x007D2E00 File Offset: 0x007D1000
	protected override bool OnEnd()
	{
		foreach (ITagTask tagTask in this.QteTagListeners)
		{
			tagTask.EndTask();
		}
		EventSystem.Instance.Remove(EEventName.OnEnterOnlineWorld, new Action(this.OnEnterOnlineWorld));
		EventSystem.Instance.Remove(EEventName.CharQteConsume, new Action<int>(this.QteConsume));
		return true;
	}

	// Token: 0x06019850 RID: 104528 RVA: 0x007D2E88 File Offset: 0x007D1088
	private void InitTriggerTags()
	{
		this.TagComponent.AddTag(new int?(this.normalQteTag));
		Dictionary<int, string>.ValueCollection values = WorldConfig.Instance.GetQteTagDataMap().Values;
		UDataTable qteTagDataTable = WorldConfig.Instance.GetQteTagDataTable();
		foreach (string text in values)
		{
			int num = DataTableUtil.GetDataTableRow<SQteTag>(qteTagDataTable, text).QteTag.TagId();
			this.QteTagListeners.Add(this.TagComponent.ListenForTagAddOrRemove(new int?(num), new BaseTagComponent.TTagSwitchedCallback(this.OnQteTagTriggerChange), null));
			if (this.TagComponent.HasTag(num))
			{
				this.QteTagMap[num] = text;
			}
		}
		this.RefreshQteTagRowName();
	}

	// Token: 0x06019851 RID: 104529 RVA: 0x007D2F5C File Offset: 0x007D115C
	private void OnActiveQteTagChange(int tagId, bool bTagExists)
	{
		EventSystem.Instance.Emit<int>(bTagExists ? EEventName.CharQteActive : EEventName.CharQteConsume, base.Entity.Id);
	}

	// Token: 0x06019852 RID: 104530 RVA: 0x007D2F7D File Offset: 0x007D117D
	private void QteConsume(int charId)
	{
		if (base.Entity.Id == charId)
		{
			return;
		}
		this.ConsumedQteEntitySet.Remove(charId);
	}

	// Token: 0x06019853 RID: 104531 RVA: 0x007D2F9B File Offset: 0x007D119B
	private void OnEnterOnlineWorld()
	{
		this.ConsumedQteEntitySet.Clear();
	}

	// Token: 0x06019854 RID: 104532 RVA: 0x007D2FA8 File Offset: 0x007D11A8
	private void OnQteSkillTagChange(int tagId, bool bTagExists)
	{
		if (!bTagExists)
		{
			this.IsInQte = false;
			this.BuffComponent.RemoveBuffByTag(new int?(GameplayTagDefine.EGameplayTagId["功能.逻辑状态标识.无敌.QTE无敌"]), "QTE结束移除", null);
			SceneTeamItem teamItem = SceneTeamModel.Instance.GetTeamItem((long)base.Entity.Id, new GetTeamItemOptions
			{
				ParamType = ETeamParamType.EntityId
			});
			if (teamItem != null && teamItem.IsMyRole() && !teamItem.IsControl())
			{
				this.TeamComponent.DisableRoleWithEffect();
			}
		}
		else
		{
			this.IsInQte = true;
		}
		EventSystem.Instance.Emit<int, bool>(EEventName.CharInQteChanged, base.Entity.Id, this.IsInQte);
	}

	// Token: 0x06019855 RID: 104533 RVA: 0x007D3054 File Offset: 0x007D1254
	public bool IsQteReady(EntityHandle goDownPlayerHandle)
	{
		if (this.IsInQte)
		{
			return false;
		}
		if (!FormationDataController.Instance.GlobalIsInFight)
		{
			return false;
		}
		if (this.TagComponent.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.濒死"]))
		{
			return false;
		}
		if (this.TagComponent.HasTag(GameplayTagDefine.EGameplayTagId["战斗状态.技能限制.禁止QTE"]))
		{
			return false;
		}
		SQteTag qteTagData = this.GetQteTagData();
		if (qteTagData == null)
		{
			return false;
		}
		if (this.TagComponent.HasTag(qteTagData.NoTag.TagId()))
		{
			return false;
		}
		BaseTagComponent component = goDownPlayerHandle.Entity.GetComponent<BaseTagComponent>();
		if (!component.HasTag(GameplayTagDefine.EGameplayTagId["功能.功能制作.QTE.激活QTE"]) || component.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.濒死"]))
		{
			return false;
		}
		if (!component.HasTag(GameplayTagDefine.EGameplayTagId["功能.功能制作.QTE.激活QTE.不消耗能量"]) && this.ConsumedQteEntitySet.Contains(goDownPlayerHandle.Id))
		{
			return false;
		}
		CharacterActorComponent component2 = goDownPlayerHandle.Entity.GetComponent<CharacterActorComponent>();
		if (FormationDataController.Instance.IsBattleMulti())
		{
			if (component2.IsAutonomousProxy)
			{
				return false;
			}
			List<SceneTeamItem> teamItemsInRange = SceneTeamModel.Instance.GetTeamItemsInRange(this.ActorComponent.ActorLocationProxy, 5000f);
			bool flag = false;
			using (List<SceneTeamItem>.Enumerator enumerator = teamItemsInRange.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.EntityHandle == goDownPlayerHandle)
					{
						flag = true;
						break;
					}
				}
			}
			if (!flag)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06019856 RID: 104534 RVA: 0x007D31D4 File Offset: 0x007D13D4
	public void UseExitSkill(EntityHandle goBattlePlayerHandle)
	{
		SQteTag qteTagData = goBattlePlayerHandle.Entity.GetComponent<RoleQteComponent>().GetQteTagData();
		if (qteTagData == null || qteTagData.ExitSkillTrigger.TagName == FName.NAME_None)
		{
			return;
		}
		this.GoBattleActor = goBattlePlayerHandle.Entity.GetComponent<CharacterActorComponent>().Actor;
		FGameplayEventData fgameplayEventData = new FGameplayEventData();
		fgameplayEventData.Instigator = this.ActorComponent.Actor;
		fgameplayEventData.Target = this.GoBattleActor;
		this.AbilityComponent.SendGameplayEventToActor(qteTagData.ExitSkillTrigger, fgameplayEventData);
		this.GoBattleActor = null;
	}

	// Token: 0x06019857 RID: 104535 RVA: 0x007D3268 File Offset: 0x007D1468
	public ERoleQteType GetRoleQteType(EntityHandle goDownPlayerHandle)
	{
		if (goDownPlayerHandle.Entity.GetComponent<BaseTagComponent>().HasTag(GameplayTagDefine.EGameplayTagId["功能.功能制作.QTE.激活QTE.不消耗能量"]) && this.TagComponent.HasTag(GameplayTagDefine.EGameplayTagId["角色.Common.角色标识.同奏体系.同奏体系角色"]))
		{
			return ERoleQteType.TongZou;
		}
		return ERoleQteType.Normal;
	}

	// Token: 0x06019858 RID: 104536 RVA: 0x007D32B8 File Offset: 0x007D14B8
	public bool ExecuteQte(EntityHandle goDownPlayerHandle)
	{
		SQteTag qteTagData = this.GetQteTagData();
		if (qteTagData == null || qteTagData.QteTrigger.TagName == FName.NAME_None)
		{
			return false;
		}
		long value = this.ExecuteQte2Server(goDownPlayerHandle);
		ERoleQteType roleQteType = this.GetRoleQteType(goDownPlayerHandle);
		this.SelectTarget(goDownPlayerHandle);
		this.TeamComponent.InterruptDisableWithEffect();
		this.TeamComponent.SetTeamTag(ETeamState.OnStage);
		base.Entity.EnableByKey(EEntityDisableKey.GoDown, true);
		this.AbilityComponent.SendGameplayEventToActor(qteTagData.QteTrigger, null);
		for (int i = 0; i < qteTagData.QteBuffs.Num(); i++)
		{
			this.BuffComponent.AddBuff(qteTagData.QteBuffs.Get(i), new AddBuffParam
			{
				InstigatorId = this.BuffComponent.CreatureDataId,
				PreMessageId = new long?(value),
				Reason = "ExecuteQte"
			});
		}
		RoleElementComponent component = goDownPlayerHandle.Entity.GetComponent<RoleElementComponent>();
		BaseTagComponent component2 = goDownPlayerHandle.Entity.GetComponent<BaseTagComponent>();
		component.TriggerEvents(base.Entity);
		if (!component2.HasTag(GameplayTagDefine.EGameplayTagId["功能.功能制作.QTE.激活QTE.不消耗能量"]))
		{
			for (int j = 0; j < qteTagData.ConsumeBuffs.Num(); j++)
			{
				component.ClearElementEnergy(base.Entity, qteTagData.ConsumeBuffs.Get(j));
			}
		}
		EventSystem.Instance.Emit<int, int, int>(EEventName.CharExecuteQte, base.Entity.Id, goDownPlayerHandle.Id, (int)roleQteType);
		return true;
	}

	// Token: 0x06019859 RID: 104537 RVA: 0x007D3426 File Offset: 0x007D1626
	public ERoleQteType GetMultiRoleQteType()
	{
		return ERoleQteType.Normal;
	}

	// Token: 0x0601985A RID: 104538 RVA: 0x007D342C File Offset: 0x007D162C
	public bool ExecuteMultiQte(EntityHandle goDownPlayerHandle)
	{
		SQteTag qteTagData = this.GetQteTagData();
		if (qteTagData == null || qteTagData.QteTrigger.TagName == FName.NAME_None)
		{
			return false;
		}
		long value = this.ExecuteQte2Server(goDownPlayerHandle);
		ERoleQteType multiRoleQteType = this.GetMultiRoleQteType();
		this.AbilityComponent.SendGameplayEventToActor(qteTagData.QteTrigger, null);
		for (int i = 0; i < qteTagData.QteBuffs.Num(); i++)
		{
			this.BuffComponent.AddBuff(qteTagData.QteBuffs.Get(i), new AddBuffParam
			{
				InstigatorId = this.BuffComponent.CreatureDataId,
				PreMessageId = new long?(value),
				Reason = "ExecuteQte"
			});
		}
		RoleElementComponent component = goDownPlayerHandle.Entity.GetComponent<RoleElementComponent>();
		BaseTagComponent component2 = goDownPlayerHandle.Entity.GetComponent<BaseTagComponent>();
		component.TriggerEvents(base.Entity);
		if (!component2.HasTag(GameplayTagDefine.EGameplayTagId["功能.功能制作.QTE.激活QTE.不消耗能量"]))
		{
			if (SceneTeamModel.Instance.GetTeamPlayerSize() > 2)
			{
				component.ClearElementEnergy(base.Entity, 3026L);
			}
			else
			{
				for (int j = 0; j < qteTagData.ConsumeBuffs.Num(); j++)
				{
					component.ClearElementEnergy(base.Entity, qteTagData.ConsumeBuffs.Get(j));
				}
			}
			this.ConsumedQteEntitySet.Add(goDownPlayerHandle.Id);
		}
		EventSystem.Instance.Emit<int, int, int>(EEventName.CharExecuteMultiQte, base.Entity.Id, goDownPlayerHandle.Id, (int)multiRoleQteType);
		return true;
	}

	// Token: 0x0601985B RID: 104539 RVA: 0x007D35A4 File Offset: 0x007D17A4
	private void CreateSphereElement()
	{
		if (this.SphereElement == null)
		{
			this.SphereElement = new UTraceSphereElement();
			this.SphereElement.WorldContextObject = GlobalData.World;
			this.SphereElement.Radius = this.ActorComponent.ScaledRadius;
			this.SphereElement.bIsSingle = true;
			this.SphereElement.bIgnoreSelf = true;
			this.SphereElement.SetTraceTypeQuery(KuroTraceTypeQuery.IkGround);
		}
	}

	// Token: 0x0601985C RID: 104540 RVA: 0x007D3614 File Offset: 0x007D1814
	private void CreateLineElement()
	{
		if (this.LineElement == null)
		{
			this.LineElement = new UTraceLineElement();
			this.LineElement.WorldContextObject = GlobalData.World;
			this.LineElement.bIsSingle = true;
			this.LineElement.bIgnoreSelf = true;
			this.LineElement.AddObjectTypeQuery(KuroObjectTypeQuery.WorldStatic);
			this.LineElement.AddObjectTypeQuery(KuroObjectTypeQuery.WorldStaticIgnoreBullet);
		}
	}

	// Token: 0x0601985D RID: 104541 RVA: 0x007D367C File Offset: 0x007D187C
	private void InitTrack(UTraceBaseElement traceElement, BaseActorComponent selectTarget, CharacterActorComponent currentRole)
	{
		UKuroHitResult hitResult = traceElement.HitResult;
		if (hitResult != null)
		{
			hitResult.Clear();
		}
		traceElement.ActorsToIgnore.Empty(true);
		traceElement.ActorsToIgnore.Add(selectTarget.Owner);
		traceElement.ActorsToIgnore.Add(currentRole.Actor);
		CharacterFollowComponent component = currentRole.Entity.GetComponent<CharacterFollowComponent>();
		TArray<AActor> tarray = (component != null) ? component.GetAttributeSharerActors() : null;
		if (tarray != null)
		{
			for (int i = 0; i < tarray.Num(); i++)
			{
				traceElement.ActorsToIgnore.Add(tarray.Get(i));
			}
		}
	}

	// Token: 0x0601985E RID: 104542 RVA: 0x007D3708 File Offset: 0x007D1908
	public unsafe void SetQtePosition(IOffsetParam offsetParam)
	{
		TsBaseCharacter baseCharacter = Global.BaseCharacter;
		CharacterActorComponent characterActorComponent = (baseCharacter != null) ? baseCharacter.CharacterActorComponent : null;
		if (characterActorComponent == null)
		{
			Log.Instance.Error(ELogModule.Character, ELogAuthor.ZQ, "GetQtePosition error, currentRole not found", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		BaseActorComponent baseActorComponent = characterActorComponent;
		global::Vector vector = global::Vector.Create();
		vector.DeepCopy(baseActorComponent.ActorLocationProxy);
		if (offsetParam.ReferenceTarget)
		{
			EntityHandle skillTarget = this.SkillComponent.SkillTarget;
			if (skillTarget != null && skillTarget.Valid)
			{
				baseActorComponent = skillTarget.Entity.GetComponent<BaseActorComponent>();
				FTransformDouble targetTransform = this.SkillComponent.GetTargetTransform();
				global::Vector vector2 = vector;
				FVectorDouble location = targetTransform.GetLocation();
				vector2.DeepCopy(location);
			}
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Character;
		ELogAuthor author = ELogAuthor.LYY;
		string message = "Qte设置位置开始";
		<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("targetName", baseActorComponent.Owner);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("currentLocation", this.ActorComponent.ActorLocationProxy);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("targetLocation", vector);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
		this.CreateSphereElement();
		this.InitTrack(this.SphereElement, baseActorComponent, characterActorComponent);
		this.CreateLineElement();
		this.InitTrack(this.LineElement, baseActorComponent, characterActorComponent);
		float radius = 0f;
		float halfHeight = 0f;
		CharacterActorComponent characterActorComponent2 = baseActorComponent as CharacterActorComponent;
		if (characterActorComponent2 != null)
		{
			radius = characterActorComponent2.ScaledRadius;
			halfHeight = characterActorComponent2.HalfHeight;
		}
		else
		{
			SceneItemActorComponent sceneItemActorComponent = baseActorComponent as SceneItemActorComponent;
			if (sceneItemActorComponent != null)
			{
				radius = (halfHeight = sceneItemActorComponent.GetRadius());
			}
		}
		ITargetParam targetParam = new ITargetParam
		{
			Location = vector,
			Radius = radius,
			HalfHeight = halfHeight
		};
		global::Vector vector3;
		string context;
		if (offsetParam.QteType == EQteType.InAir)
		{
			vector3 = this.GetQteLocationAir(characterActorComponent, offsetParam, targetParam);
			context = "Qte.设置空中位置";
		}
		else
		{
			vector3 = this.GetQteLocationLand(characterActorComponent, offsetParam, targetParam);
			context = "Qte.设置地面位置";
		}
		CharacterActorComponent actorComponent = this.ActorComponent;
		global::Vector actorLocationProxy = actorComponent.ActorLocationProxy;
		UTraceLineElement lineElement = this.LineElement;
		TraceElementCommon.Instance.SetStartLocation(lineElement, characterActorComponent.ActorLocationProxy);
		TraceElementCommon.Instance.SetEndLocation(lineElement, vector3);
		bool flag = TraceElementCommon.Instance.LineTrace(lineElement, "RoleQteComponent_SetQtePosition");
		UKuroHitResult hitResult = lineElement.HitResult;
		if (flag && hitResult.bBlockingHit)
		{
			TraceElementCommon.Instance.GetHitLocation(hitResult, 0, vector3);
			global::Vector tempVector = this.TempVector;
			vector3.Subtraction(actorLocationProxy, tempVector);
			tempVector.Normalize(9.99999993922529E-09);
			tempVector.Multiply((double)actorComponent.ScaledRadius, tempVector);
			vector3.Subtraction(tempVector, vector3);
		}
		float scaledHalfHeight = actorComponent.ScaledHalfHeight;
		global::Vector vector4 = global::Vector.Create(vector3);
		global::Vector vector5 = global::Vector.Create(vector3);
		GravityUtils.Instance.AddZnInGravityForActor(actorComponent, vector4, (double)scaledHalfHeight);
		GravityUtils.Instance.AddZnInGravityForActor(actorComponent, vector5, (double)(-(double)scaledHalfHeight));
		this.SphereElement.Radius = actorComponent.ScaledRadius;
		TraceElementCommon.Instance.SetStartLocation(this.SphereElement, vector4);
		TraceElementCommon.Instance.SetEndLocation(this.SphereElement, vector5);
		bool flag2 = TraceElementCommon.Instance.SphereTrace(this.SphereElement, "RoleQteComponent_SetQtePosition");
		UKuroHitResult hitResult2 = this.SphereElement.HitResult;
		if (flag2 && hitResult2.bBlockingHit)
		{
			global::Vector commonHitLocation = TraceElementModel.Instance.CommonHitLocation;
			TraceElementCommon.Instance.GetHitLocation(hitResult2, 0, commonHitLocation);
			GravityUtils.Instance.AddZnInGravityForActor(actorComponent, commonHitLocation, (double)scaledHalfHeight);
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Character;
			ELogAuthor author2 = ELogAuthor.LYY;
			string message2 = "Qte设置位置，地面检测修正位置";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("fixedLocation", commonHitLocation);
			instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			actorComponent.SetActorLocation(commonHitLocation.ToUeVector(false), "Qte.修正位置", false);
			return;
		}
		Log instance3 = Log.Instance;
		ELogModule module3 = ELogModule.Character;
		ELogAuthor author3 = ELogAuthor.LYY;
		string message3 = "Qte设置位置";
		ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("location", vector3);
		instance3.Info(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
		actorComponent.SetActorLocation(vector3.ToUeVector(false), context, false);
	}

	// Token: 0x0601985F RID: 104543 RVA: 0x007D3ADC File Offset: 0x007D1CDC
	private global::Vector GetQteLocationAir(CharacterActorComponent currentRole, IOffsetParam offsetParam, ITargetParam targetParam)
	{
		float num = offsetParam.Length;
		global::Vector vector = global::Vector.Create();
		currentRole.ActorLocationProxy.Subtraction(targetParam.Location, vector);
		if (vector.IsNearlyZero(9.999999747378752E-05))
		{
			vector.DeepCopy(currentRole.ActorForwardProxy);
		}
		else
		{
			num += targetParam.Radius;
		}
		GravityUtils.Instance.SetZnInGravityForActor(currentRole, vector, 0.0);
		vector.RotateAngleAxis((double)offsetParam.Rotate, currentRole.MoveComp.GravityUp, vector);
		vector.Normalize(9.99999993922529E-09);
		vector.Multiply((double)num, vector);
		global::Vector vector2 = global::Vector.Create();
		vector2.DeepCopy(targetParam.Location);
		vector2.Addition(vector, vector2);
		GravityUtils.Instance.AddZnInGravityForActor(currentRole, vector2, (double)offsetParam.Height);
		global::Vector actorLocationProxy = currentRole.ActorLocationProxy;
		TraceElementCommon.Instance.SetStartLocation(this.SphereElement, actorLocationProxy);
		GravityUtils.Instance.AddZnInGravityForActor(currentRole, vector2, (double)(targetParam.HalfHeight / 2f));
		TraceElementCommon.Instance.SetEndLocation(this.SphereElement, vector2);
		bool flag = TraceElementCommon.Instance.ShapeTrace(currentRole.Actor.CapsuleComponent, this.SphereElement, "RoleQteComponent_SetQtePosition", "RoleQteComponent_SetQtePosition");
		UKuroHitResult hitResult = this.SphereElement.HitResult;
		GravityUtils.Instance.AddZnInGravityForActor(currentRole, vector2, (double)(-(double)targetParam.HalfHeight / 2f));
		if (flag && hitResult.bBlockingHit)
		{
			global::Vector vector3 = global::Vector.Create();
			TraceElementCommon.Instance.GetHitLocation(this.SphereElement.HitResult, 0, vector3);
			global::Vector tempVector = this.TempVector;
			currentRole.ActorLocationProxy.Subtraction(vector3, tempVector);
			GravityUtils.Instance.SetZnInGravityForActor(currentRole, tempVector, 0.0);
			tempVector.Normalize(9.99999993922529E-09);
			float num2 = targetParam.Radius + currentRole.GetRadius();
			tempVector.Multiply((double)num2, tempVector);
			vector2.DeepCopy(vector3);
			vector2.Addition(tempVector, vector2);
			GravityUtils.Instance.AddZnInGravityForActor(currentRole, vector2, (double)offsetParam.Height);
		}
		return vector2;
	}

	// Token: 0x06019860 RID: 104544 RVA: 0x007D3CE8 File Offset: 0x007D1EE8
	private global::Vector GetQteLocationLand(CharacterActorComponent currentRole, IOffsetParam offsetParam, ITargetParam targetParam)
	{
		global::Vector vector = global::Vector.Create();
		vector.DeepCopy(targetParam.Location);
		float num = targetParam.HalfHeight - 5f;
		GravityUtils.Instance.AddZnInGravityForActor(currentRole, vector, (double)num);
		global::Vector vector2 = global::Vector.Create();
		currentRole.ActorLocationProxy.Subtraction(targetParam.Location, vector2);
		if (vector2.IsNearlyZero(9.999999747378752E-05))
		{
			vector2.DeepCopy(currentRole.ActorForwardProxy);
		}
		GravityUtils.Instance.SetZnInGravityForActor(currentRole, vector2, 0.0);
		vector2.RotateAngleAxis((double)offsetParam.Rotate, currentRole.MoveComp.GravityUp, vector2);
		vector2.Normalize(9.99999993922529E-09);
		float addHeight = num + offsetParam.Height - -1000f;
		float walkableFloorAngle = currentRole.Actor.CharacterMovement.K2_GetWalkableFloorAngle();
		float length = offsetParam.Length + targetParam.Radius;
		global::Vector vector3 = this.GetValidLocation(vector, vector2, length, addHeight, walkableFloorAngle);
		if (vector3 == null)
		{
			vector2.Normalize(9.99999993922529E-09);
			vector2.Multiply(-1.0, vector2);
			vector3 = this.GetValidLocation(vector, vector2, length, addHeight, walkableFloorAngle);
			if (vector3 == null)
			{
				vector3 = global::Vector.Create(currentRole.ActorLocationProxy);
			}
		}
		GravityUtils.Instance.AddZnInGravityForActor(currentRole, vector3, (double)offsetParam.Height);
		return vector3;
	}

	// Token: 0x06019861 RID: 104545 RVA: 0x007D3E30 File Offset: 0x007D2030
	[return: Nullable(2)]
	private global::Vector GetValidLocation(global::Vector startLocation, global::Vector direction, float length, float addHeight, float walkableFloorAngle)
	{
		UCapsuleComponent capsuleComponent = this.ActorComponent.Actor.CapsuleComponent;
		direction.Multiply((double)length, direction);
		global::Vector vector = global::Vector.Create();
		vector.DeepCopy(startLocation);
		global::Vector vector2 = global::Vector.Create();
		vector2.DeepCopy(vector);
		vector2.Addition(direction, vector2);
		UKuroHitResult hitResult = this.SphereElement.HitResult;
		if (hitResult != null)
		{
			hitResult.Clear();
		}
		TraceElementCommon.Instance.SetStartLocation(this.SphereElement, vector);
		TraceElementCommon.Instance.SetEndLocation(this.SphereElement, vector2);
		bool flag = TraceElementCommon.Instance.ShapeTrace(capsuleComponent, this.SphereElement, "RoleQteComponent_SetQtePosition", "RoleQteComponent_SetQtePosition");
		UKuroHitResult hitResult2 = this.SphereElement.HitResult;
		global::Vector vector3 = global::Vector.Create();
		global::Vector vector4 = global::Vector.Create();
		vector.DeepCopy(vector2);
		if (flag && hitResult2.bBlockingHit)
		{
			TraceElementCommon.Instance.GetHitLocation(hitResult2, 0, vector3);
			TraceElementCommon.Instance.GetImpactNormal(hitResult2, 0, vector4);
			if (MathUtils.Instance.GetAngleByVectorDot(vector4, this.ActorComponent.MoveComp.GravityUp) > (double)walkableFloorAngle)
			{
				return null;
			}
			vector.DeepCopy(vector3);
		}
		double num = (double)length / Math.Tan((double)(walkableFloorAngle * 0.017453292f)) + (double)addHeight;
		vector2.DeepCopy(vector);
		GravityUtils.Instance.AddZnInGravityForActor(this.ActorComponent, vector2, -num);
		UKuroHitResult hitResult3 = this.SphereElement.HitResult;
		if (hitResult3 != null)
		{
			hitResult3.Clear();
		}
		TraceElementCommon.Instance.SetStartLocation(this.SphereElement, vector);
		TraceElementCommon.Instance.SetEndLocation(this.SphereElement, vector2);
		bool flag2 = TraceElementCommon.Instance.ShapeTrace(capsuleComponent, this.SphereElement, "RoleQteComponent_SetQtePosition", "RoleQteComponent_SetQtePosition");
		hitResult2 = this.SphereElement.HitResult;
		vector3.Reset();
		vector4.Reset();
		if (!flag2 || !hitResult2.bBlockingHit)
		{
			return null;
		}
		TraceElementCommon.Instance.GetHitLocation(hitResult2, 0, vector3);
		TraceElementCommon.Instance.GetImpactNormal(hitResult2, 0, vector4);
		if (MathUtils.Instance.GetAngleByVectorDot(vector4, this.ActorComponent.MoveComp.GravityUp) > (double)walkableFloorAngle)
		{
			return null;
		}
		return vector3;
	}

	// Token: 0x06019862 RID: 104546 RVA: 0x007D4040 File Offset: 0x007D2240
	private void SelectTarget(EntityHandle goDownPlayerHandle)
	{
		WorldEntity entity = goDownPlayerHandle.Entity;
		CharacterManipulateComponent component = entity.GetComponent<CharacterManipulateComponent>();
		bool flag = component != null && component.IsManipulating();
		CharacterSkillComponent component2 = entity.GetComponent<CharacterSkillComponent>();
		EntityHandle skillTarget = component2.SkillTarget;
		if (!flag && skillTarget != null && skillTarget.Valid)
		{
			WorldEntity entity2 = skillTarget.Entity;
			if (entity2 != null && entity2.Active)
			{
				BaseTagComponent component3 = skillTarget.Entity.GetComponent<BaseTagComponent>();
				if (component3 == null || !component3.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.濒死"]))
				{
					this.SkillComponent.SkillTarget = skillTarget;
					this.SkillComponent.SkillTargetSocket = component2.SkillTargetSocket;
					return;
				}
			}
		}
		CharacterLockOnComponent component4 = entity.GetComponent<CharacterLockOnComponent>();
		component4.DetectSoftLockTarget(new SkillTargetImpl
		{
			LockOnConfigId = new int?(4)
		}, true);
		this.SkillComponent.SkillTarget = component4.GetCurrentTarget();
		this.SkillComponent.SkillTargetSocket = component4.GetCurrentTargetSocketName();
	}

	// Token: 0x06019863 RID: 104547 RVA: 0x007D4128 File Offset: 0x007D2328
	private void OnQteTagTriggerChange(int tagId, bool bTagExists)
	{
		if (bTagExists)
		{
			this.QteTagMap[tagId] = WorldConfig.Instance.GetQteTagDataMap()[tagId];
			this.RefreshQteTagRowName();
			return;
		}
		string valueOrDefault = this.QteTagMap.GetValueOrDefault(tagId);
		this.QteTagMap.Remove(tagId);
		if (this.QteTagRowName == valueOrDefault)
		{
			this.RefreshQteTagRowName();
		}
	}

	// Token: 0x06019864 RID: 104548 RVA: 0x007D418C File Offset: 0x007D238C
	private void RefreshQteTagRowName()
	{
		UDataTable qteTagDataTable = WorldConfig.Instance.GetQteTagDataTable();
		int num = 0;
		foreach (string text in this.QteTagMap.Values)
		{
			SQteTag dataTableRow = DataTableUtil.GetDataTableRow<SQteTag>(qteTagDataTable, text);
			if ((int)dataTableRow.Priority >= num)
			{
				this.QteTagRowName = text;
				this.ElementComponent.TriggerEnergy = (float)dataTableRow.Energy;
				num = (int)dataTableRow.Priority;
			}
		}
		EventSystem.Instance.EmitWithTarget(base.Entity, EEventName.CharQteTagRowNameChanged);
	}

	// Token: 0x06019865 RID: 104549 RVA: 0x007D4234 File Offset: 0x007D2434
	[NullableContext(2)]
	public SQteTag GetQteTagData()
	{
		if (!string.IsNullOrEmpty(this.QteTagRowName))
		{
			return DataTableUtil.GetDataTableRow<SQteTag>(WorldConfig.Instance.GetQteTagDataTable(), this.QteTagRowName);
		}
		return null;
	}

	// Token: 0x06019866 RID: 104550 RVA: 0x007D425C File Offset: 0x007D245C
	private long ExecuteQte2Server(EntityHandle goDownPlayerHandle)
	{
		ExecuteQtePush executeQtePush = ExecuteQtePush.Create();
		executeQtePush.DownEntityId = CreatureModel.Instance.GetCreatureDataId(goDownPlayerHandle.Entity.Id);
		executeQtePush.UpEntityId = CreatureModel.Instance.GetCreatureDataId(base.Entity.Id);
		executeQtePush.QteId = UGASBPLibrary.FnvHash(this.QteTagRowName);
		long num = CombatMessageModel.Instance.GenMessageId();
		CombatNet.Instance.Send(EPushMessageId.ExecuteQtePush, base.Entity, executeQtePush, null, new long?(num), null);
		return num;
	}

	// Token: 0x06019867 RID: 104551 RVA: 0x007D42F4 File Offset: 0x007D24F4
	[NullableContext(2)]
	[CombatListen(ENotifyMessageId.ExecuteQteNotify, true, false)]
	public static void ExecuteQteNotify(Entity entity, [Nullable(1)] ExecuteQteNotify data, CombatCommon combatCommon = null)
	{
		int entityId = CreatureModel.Instance.GetEntityId(MathUtils.Instance.LongToNumber(data.UpEntityId));
		int entityId2 = CreatureModel.Instance.GetEntityId(MathUtils.Instance.LongToNumber(data.DownEntityId));
		EventSystem.Instance.Emit<int, int, int>(EEventName.CharExecuteMultiQte, entityId, entityId2, 0);
	}

	// Token: 0x06019868 RID: 104552 RVA: 0x007D4348 File Offset: 0x007D2548
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		RoleQteComponent roleQteComponent = (RoleQteComponent)componentTemplate;
		if (roleQteComponent.ActorComponent == null)
		{
			this.ActorComponent = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ActorComponent), "ActorComponent"))
		{
			return false;
		}
		if (roleQteComponent.AbilityComponent == null)
		{
			this.AbilityComponent = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.AbilityComponent), "AbilityComponent"))
		{
			return false;
		}
		if (roleQteComponent.TagComponent == null)
		{
			this.TagComponent = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TagComponent), "TagComponent"))
		{
			return false;
		}
		if (roleQteComponent.BuffComponent == null)
		{
			this.BuffComponent = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.BuffComponent), "BuffComponent"))
		{
			return false;
		}
		if (roleQteComponent.TeamComponent == null)
		{
			this.TeamComponent = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TeamComponent), "TeamComponent"))
		{
			return false;
		}
		if (roleQteComponent.SkillComponent == null)
		{
			this.SkillComponent = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.SkillComponent), "SkillComponent"))
		{
			return false;
		}
		if (roleQteComponent.ElementComponent == null)
		{
			this.ElementComponent = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ElementComponent), "ElementComponent"))
		{
			return false;
		}
		if (roleQteComponent.SphereElement == null)
		{
			this.SphereElement = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.SphereElement), "SphereElement"))
		{
			return false;
		}
		if (roleQteComponent.LineElement == null)
		{
			this.LineElement = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.LineElement), "LineElement"))
		{
			return false;
		}
		if (roleQteComponent.TempVector != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.TempVector), "TempVector"))
		{
			return false;
		}
		if (roleQteComponent.ConsumedQteEntitySet != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<int>(this.ConsumedQteEntitySet), "ConsumedQteEntitySet"))
		{
			return false;
		}
		this.IsInQte = roleQteComponent.IsInQte;
		if (roleQteComponent.QteTagListeners != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.QteTagListeners), "QteTagListeners"))
		{
			return false;
		}
		if (roleQteComponent.QteTagMap != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.QteTagMap), "QteTagMap"))
		{
			return false;
		}
		this.QteTagRowName = roleQteComponent.QteTagRowName;
		if (roleQteComponent.GoBattleActor == null)
		{
			this.GoBattleActor = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.GoBattleActor), "GoBattleActor"))
		{
			return false;
		}
		return true;
	}

	// Token: 0x170028BC RID: 10428
	// (get) Token: 0x06019869 RID: 104553 RVA: 0x007D45B6 File Offset: 0x007D27B6
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170028BD RID: 10429
	// (get) Token: 0x0601986A RID: 104554 RVA: 0x007D45B9 File Offset: 0x007D27B9
	public override bool NeedEndInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400DFB0 RID: 57264
	private const string PROFILE_KEY = "RoleQteComponent_SetQtePosition";

	// Token: 0x0400DFB1 RID: 57265
	private const float DEFAULT_ADD_HEIGHT = -1000f;

	// Token: 0x0400DFB2 RID: 57266
	private const float SUB_SIZE = 5f;

	// Token: 0x0400DFB3 RID: 57267
	private const int QTE_LOCKON_CONFIG_ID = 4;

	// Token: 0x0400DFB4 RID: 57268
	private readonly int normalQteTag = GameplayTagDefine.EGameplayTagId["功能.功能制作.QTE.普通QTE"];

	// Token: 0x0400DFB5 RID: 57269
	public const float MAX_MULTI_QTE_DISTANCE = 5000f;

	// Token: 0x0400DFB6 RID: 57270
	[Nullable(2)]
	private CharacterActorComponent ActorComponent;

	// Token: 0x0400DFB7 RID: 57271
	[Nullable(2)]
	private CharacterAbilityComponent AbilityComponent;

	// Token: 0x0400DFB8 RID: 57272
	[Nullable(2)]
	private BaseTagComponent TagComponent;

	// Token: 0x0400DFB9 RID: 57273
	[Nullable(2)]
	private CharacterBuffComponent BuffComponent;

	// Token: 0x0400DFBA RID: 57274
	[Nullable(2)]
	private RoleTeamComponent TeamComponent;

	// Token: 0x0400DFBB RID: 57275
	[Nullable(2)]
	private CharacterSkillComponent SkillComponent;

	// Token: 0x0400DFBC RID: 57276
	[Nullable(2)]
	private RoleElementComponent ElementComponent;

	// Token: 0x0400DFBD RID: 57277
	[Nullable(2)]
	private UTraceSphereElement SphereElement;

	// Token: 0x0400DFBE RID: 57278
	[Nullable(2)]
	private UTraceLineElement LineElement;

	// Token: 0x0400DFBF RID: 57279
	private readonly global::Vector TempVector = global::Vector.Create();

	// Token: 0x0400DFC0 RID: 57280
	private readonly HashSet<int> ConsumedQteEntitySet = new HashSet<int>();

	// Token: 0x0400DFC1 RID: 57281
	public bool IsInQte;

	// Token: 0x0400DFC2 RID: 57282
	private readonly List<ITagTask> QteTagListeners = new List<ITagTask>();

	// Token: 0x0400DFC3 RID: 57283
	private readonly Dictionary<int, string> QteTagMap = new Dictionary<int, string>();

	// Token: 0x0400DFC4 RID: 57284
	private string QteTagRowName = "";

	// Token: 0x0400DFC5 RID: 57285
	[Nullable(2)]
	public TsBaseCharacter GoBattleActor;
}

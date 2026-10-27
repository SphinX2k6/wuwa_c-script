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

// Token: 0x02003252 RID: 12882
[NullableContext(1)]
[Nullable(0)]
public class RoleQteComponent : EntityComponent
{
	// Token: 0x0601BC93 RID: 113811 RVA: 0x007AA708 File Offset: 0x007A8908
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

	// Token: 0x0601BC94 RID: 113812 RVA: 0x007AA838 File Offset: 0x007A8A38
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

	// Token: 0x0601BC95 RID: 113813 RVA: 0x007AA8C0 File Offset: 0x007A8AC0
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

	// Token: 0x0601BC96 RID: 113814 RVA: 0x007AA994 File Offset: 0x007A8B94
	private void OnActiveQteTagChange(int tagId, bool bTagExists)
	{
		EventSystem.Instance.Emit<int>(bTagExists ? EEventName.CharQteActive : EEventName.CharQteConsume, base.Entity.Id);
	}

	// Token: 0x0601BC97 RID: 113815 RVA: 0x007AA9B5 File Offset: 0x007A8BB5
	private void QteConsume(int charId)
	{
		if (base.Entity.Id == charId)
		{
			return;
		}
		this.ConsumedQteEntitySet.Remove(charId);
	}

	// Token: 0x0601BC98 RID: 113816 RVA: 0x007AA9D3 File Offset: 0x007A8BD3
	private void OnEnterOnlineWorld()
	{
		this.ConsumedQteEntitySet.Clear();
	}

	// Token: 0x0601BC99 RID: 113817 RVA: 0x007AA9E0 File Offset: 0x007A8BE0
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

	// Token: 0x0601BC9A RID: 113818 RVA: 0x007AAA8C File Offset: 0x007A8C8C
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

	// Token: 0x0601BC9B RID: 113819 RVA: 0x007AAC0C File Offset: 0x007A8E0C
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

	// Token: 0x0601BC9C RID: 113820 RVA: 0x007AACA0 File Offset: 0x007A8EA0
	public ERoleQteType GetRoleQteType(EntityHandle goDownPlayerHandle)
	{
		if (goDownPlayerHandle.Entity.GetComponent<BaseTagComponent>().HasTag(GameplayTagDefine.EGameplayTagId["功能.功能制作.QTE.激活QTE.不消耗能量"]) && this.TagComponent.HasTag(GameplayTagDefine.EGameplayTagId["角色.Common.角色标识.同奏体系.同奏体系角色"]))
		{
			return ERoleQteType.TongZou;
		}
		return ERoleQteType.Normal;
	}

	// Token: 0x0601BC9D RID: 113821 RVA: 0x007AACF0 File Offset: 0x007A8EF0
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

	// Token: 0x0601BC9E RID: 113822 RVA: 0x007AAE5E File Offset: 0x007A905E
	public ERoleQteType GetMultiRoleQteType()
	{
		return ERoleQteType.Normal;
	}

	// Token: 0x0601BC9F RID: 113823 RVA: 0x007AAE64 File Offset: 0x007A9064
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

	// Token: 0x0601BCA0 RID: 113824 RVA: 0x007AAFDC File Offset: 0x007A91DC
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

	// Token: 0x0601BCA1 RID: 113825 RVA: 0x007AB04C File Offset: 0x007A924C
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

	// Token: 0x0601BCA2 RID: 113826 RVA: 0x007AB0B4 File Offset: 0x007A92B4
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

	// Token: 0x0601BCA3 RID: 113827 RVA: 0x007AB140 File Offset: 0x007A9340
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

	// Token: 0x0601BCA4 RID: 113828 RVA: 0x007AB514 File Offset: 0x007A9714
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

	// Token: 0x0601BCA5 RID: 113829 RVA: 0x007AB720 File Offset: 0x007A9920
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

	// Token: 0x0601BCA6 RID: 113830 RVA: 0x007AB868 File Offset: 0x007A9A68
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

	// Token: 0x0601BCA7 RID: 113831 RVA: 0x007ABA64 File Offset: 0x007A9C64
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

	// Token: 0x0601BCA8 RID: 113832 RVA: 0x007ABB4C File Offset: 0x007A9D4C
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

	// Token: 0x0601BCA9 RID: 113833 RVA: 0x007ABBB0 File Offset: 0x007A9DB0
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

	// Token: 0x0601BCAA RID: 113834 RVA: 0x007ABC58 File Offset: 0x007A9E58
	[NullableContext(2)]
	public SQteTag GetQteTagData()
	{
		if (!string.IsNullOrEmpty(this.QteTagRowName))
		{
			return DataTableUtil.GetDataTableRow<SQteTag>(WorldConfig.Instance.GetQteTagDataTable(), this.QteTagRowName);
		}
		return null;
	}

	// Token: 0x0601BCAB RID: 113835 RVA: 0x007ABC80 File Offset: 0x007A9E80
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

	// Token: 0x0601BCAC RID: 113836 RVA: 0x007ABD18 File Offset: 0x007A9F18
	[NullableContext(2)]
	[CombatListen(ENotifyMessageId.ExecuteQteNotify, true, false)]
	public static void ExecuteQteNotify(Entity entity, [Nullable(1)] ExecuteQteNotify data, CombatCommon combatCommon = null)
	{
		int entityId = CreatureModel.Instance.GetEntityId(MathUtils.Instance.LongToNumber(data.UpEntityId));
		int entityId2 = CreatureModel.Instance.GetEntityId(MathUtils.Instance.LongToNumber(data.DownEntityId));
		EventSystem.Instance.Emit<int, int, int>(EEventName.CharExecuteMultiQte, entityId, entityId2, 0);
	}

	// Token: 0x0601BCAD RID: 113837 RVA: 0x007ABD6C File Offset: 0x007A9F6C
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		RoleQteComponent roleQteComponent = (RoleQteComponent)componentTemplate;
		if (base.CanResetComponentProperty("ActorComponent"))
		{
			if (roleQteComponent.ActorComponent == null)
			{
				this.ActorComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterActorComponent>(this.ActorComponent), "ActorComponent"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("AbilityComponent"))
		{
			if (roleQteComponent.AbilityComponent == null)
			{
				this.AbilityComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterAbilityComponent>(this.AbilityComponent), "AbilityComponent"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("TagComponent"))
		{
			if (roleQteComponent.TagComponent == null)
			{
				this.TagComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BaseTagComponent>(this.TagComponent), "TagComponent"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("BuffComponent"))
		{
			if (roleQteComponent.BuffComponent == null)
			{
				this.BuffComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterBuffComponent>(this.BuffComponent), "BuffComponent"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("TeamComponent"))
		{
			if (roleQteComponent.TeamComponent == null)
			{
				this.TeamComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<RoleTeamComponent>(this.TeamComponent), "TeamComponent"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("SkillComponent"))
		{
			if (roleQteComponent.SkillComponent == null)
			{
				this.SkillComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterSkillComponent>(this.SkillComponent), "SkillComponent"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("ElementComponent"))
		{
			if (roleQteComponent.ElementComponent == null)
			{
				this.ElementComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<RoleElementComponent>(this.ElementComponent), "ElementComponent"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("SphereElement"))
		{
			if (roleQteComponent.SphereElement == null)
			{
				this.SphereElement = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<UTraceSphereElement>(this.SphereElement), "SphereElement"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("LineElement"))
		{
			if (roleQteComponent.LineElement == null)
			{
				this.LineElement = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<UTraceLineElement>(this.LineElement), "LineElement"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("TempVector") && roleQteComponent.TempVector != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.TempVector), "TempVector"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("ConsumedQteEntitySet") && roleQteComponent.ConsumedQteEntitySet != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<int>(this.ConsumedQteEntitySet), "ConsumedQteEntitySet"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("IsInQte"))
		{
			this.IsInQte = roleQteComponent.IsInQte;
		}
		if (base.CanResetComponentProperty("QteTagListeners") && roleQteComponent.QteTagListeners != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<List<ITagTask>>(this.QteTagListeners), "QteTagListeners"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("QteTagMap") && roleQteComponent.QteTagMap != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Dictionary<int, string>>(this.QteTagMap), "QteTagMap"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("QteTagRowName"))
		{
			this.QteTagRowName = roleQteComponent.QteTagRowName;
		}
		if (base.CanResetComponentProperty("GoBattleActor"))
		{
			if (roleQteComponent.GoBattleActor == null)
			{
				this.GoBattleActor = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<TsBaseCharacter>(this.GoBattleActor), "GoBattleActor"))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0400DB11 RID: 56081
	private const string PROFILE_KEY = "RoleQteComponent_SetQtePosition";

	// Token: 0x0400DB12 RID: 56082
	private const float DEFAULT_ADD_HEIGHT = -1000f;

	// Token: 0x0400DB13 RID: 56083
	private const float SUB_SIZE = 5f;

	// Token: 0x0400DB14 RID: 56084
	private const int QTE_LOCKON_CONFIG_ID = 4;

	// Token: 0x0400DB15 RID: 56085
	private readonly int normalQteTag = GameplayTagDefine.EGameplayTagId["功能.功能制作.QTE.普通QTE"];

	// Token: 0x0400DB16 RID: 56086
	public const float MAX_MULTI_QTE_DISTANCE = 5000f;

	// Token: 0x0400DB17 RID: 56087
	[Nullable(2)]
	private CharacterActorComponent ActorComponent;

	// Token: 0x0400DB18 RID: 56088
	[Nullable(2)]
	private CharacterAbilityComponent AbilityComponent;

	// Token: 0x0400DB19 RID: 56089
	[Nullable(2)]
	private BaseTagComponent TagComponent;

	// Token: 0x0400DB1A RID: 56090
	[Nullable(2)]
	private CharacterBuffComponent BuffComponent;

	// Token: 0x0400DB1B RID: 56091
	[Nullable(2)]
	private RoleTeamComponent TeamComponent;

	// Token: 0x0400DB1C RID: 56092
	[Nullable(2)]
	private CharacterSkillComponent SkillComponent;

	// Token: 0x0400DB1D RID: 56093
	[Nullable(2)]
	private RoleElementComponent ElementComponent;

	// Token: 0x0400DB1E RID: 56094
	[Nullable(2)]
	private UTraceSphereElement SphereElement;

	// Token: 0x0400DB1F RID: 56095
	[Nullable(2)]
	private UTraceLineElement LineElement;

	// Token: 0x0400DB20 RID: 56096
	private readonly global::Vector TempVector = global::Vector.Create();

	// Token: 0x0400DB21 RID: 56097
	private readonly HashSet<int> ConsumedQteEntitySet = new HashSet<int>();

	// Token: 0x0400DB22 RID: 56098
	public bool IsInQte;

	// Token: 0x0400DB23 RID: 56099
	private readonly List<ITagTask> QteTagListeners = new List<ITagTask>();

	// Token: 0x0400DB24 RID: 56100
	private readonly Dictionary<int, string> QteTagMap = new Dictionary<int, string>();

	// Token: 0x0400DB25 RID: 56101
	private string QteTagRowName = "";

	// Token: 0x0400DB26 RID: 56102
	[Nullable(2)]
	public TsBaseCharacter GoBattleActor;
}

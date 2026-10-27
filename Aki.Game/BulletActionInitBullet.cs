using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.Module.CombatMessage;
using UnrealEngine;

// Token: 0x02002D8F RID: 11663
[NullableContext(1)]
[Nullable(0)]
public class BulletActionInitBullet : BulletActionBase
{
	// Token: 0x060187FB RID: 100347 RVA: 0x0063C9CE File Offset: 0x0063ABCE
	public BulletActionInitBullet(EBulletAction type) : base(type)
	{
	}

	// Token: 0x060187FC RID: 100348 RVA: 0x0063C9D8 File Offset: 0x0063ABD8
	protected override void OnExecute()
	{
		BulletInfo bulletInfo = this.BulletInfo;
		BulletInitParams bulletInitParams = bulletInfo.BulletInitParams;
		BulletDataMain bulletDataMain = bulletInfo.BulletDataMain;
		bulletInfo.GenerateTime = (float)Time.Instance.WorldTime;
		long? num = bulletInitParams.FromRemote ? bulletInitParams.ContextId : new long?(CombatMessageModel.Instance.GenMessageId());
		bulletInfo.PreContextId = (bulletInitParams.FromRemote ? new long?(0L) : bulletInitParams.ContextId);
		bulletInfo.ContextId = num;
		CombatMessageModel.Instance.OnBulletAdded(bulletInitParams.SkillContextId, num, bulletInfo.BulletRowName);
		int targetId = bulletInitParams.TargetId;
		bulletInfo.SetTargetById(targetId);
		CreatureDataComponent attackerCreatureDataComp = bulletInfo.AttackerCreatureDataComp;
		if (attackerCreatureDataComp == null)
		{
			BulletController.Instance.DestroyBullet(bulletInfo.BulletEntityId, false, EBulletDestroyReason.Normal, false);
			return;
		}
		if (attackerCreatureDataComp.GetEntityType() != EEntityType.Player)
		{
			bulletInfo.AttackerCamp = attackerCreatureDataComp.GetEntityCamp();
		}
		else
		{
			bulletInfo.AttackerCamp = ECamp.Player;
		}
		bulletInfo.IsAutonomousProxy = bulletInfo.AttackerActorComp.IsAutonomousProxy;
		bulletInfo.AttackerPlayerId = attackerCreatureDataComp.GetPlayerId();
		BulletInfo bulletInfo2 = bulletInfo;
		BaseSkillComponent attackerSkillComp = bulletInfo.AttackerSkillComp;
		bulletInfo2.SkillLevel = ((attackerSkillComp != null) ? attackerSkillComp.GetSkillLevelBySkillInfoId((long)bulletInitParams.SkillId) : 0);
		BulletDataMove move = bulletDataMain.Move;
		if (move.UpDownAngleLimit > 0f)
		{
			FVectorDouble? targetLocation = BulletUtil.GetTargetLocation(bulletInfo.TargetActorComp, FNameUtil.GetDynamicFName(move.InitVelocityDirParam) ?? FName.NAME_None, bulletInfo);
			if (targetLocation != null)
			{
				global::Vector vector = BulletPool.CreateVector(false);
				global::Vector vector2 = vector;
				FVectorDouble value = targetLocation.Value;
				vector2.FromUeVector(value);
				BaseActorComponent attackerActorComp = bulletInfo.AttackerActorComp;
				global::Vector vector3 = BulletPool.CreateVector(false);
				vector3.FromUeVector(attackerActorComp.ActorLocationProxy);
				vector3.SubtractionEqual(vector);
				double num2 = vector3.Size();
				if (num2 > 0.0)
				{
					bool flag = false;
					CharacterMoveComponent attackerMoveComp = bulletInfo.AttackerMoveComp;
					if (attackerMoveComp == null || attackerMoveComp.IsStandardGravity)
					{
						double num3 = vector3.Z;
						num3 = ((num3 > 0.0) ? num3 : (num3 * -1.0));
						if ((double)move.UpDownAngleLimit < MathUtils.Instance.ClampedAsin(num3 / num2) * 57.295780181884766)
						{
							flag = true;
						}
					}
					else
					{
						global::Vector vector4 = vector3;
						CharacterMoveComponent attackerMoveComp2 = bulletInfo.AttackerMoveComp;
						double num4 = vector4.DotProduct(((attackerMoveComp2 != null) ? attackerMoveComp2.GravityUp : null) ?? global::Vector.UpVectorProxy);
						if ((double)move.UpDownAngleLimit < MathUtils.Instance.ClampedAsin(num4 / num2) * 57.295780181884766)
						{
							flag = true;
						}
					}
					if (flag)
					{
						bulletInfo.SetTargetById(0);
					}
				}
				BulletPool.RecycleVector(vector3);
				BulletPool.RecycleVector(vector);
			}
		}
		int tagId = bulletDataMain.Base.TagId;
		if (tagId > 0)
		{
			bulletInfo.AddTagId(tagId);
		}
		int[] presentTagIds = bulletDataMain.Logic.PresentTagIds;
		foreach (int tagId2 in presentTagIds)
		{
			bulletInfo.AddTagId(tagId2);
		}
		if (GlobalData.IsPlayInEditor)
		{
			if (tagId > 0)
			{
				this.CheckBulletTag(tagId, bulletInitParams.BulletRowName, "子弹的'基础设置.子弹标签'中的值必须是以[子弹.]开头的");
			}
			foreach (int num5 in presentTagIds)
			{
				if (num5 > 0)
				{
					this.CheckBulletTag(num5, bulletInitParams.BulletRowName, "子弹的'逻辑设置.预设.预设标签'中的值必须是以[子弹.]开头的");
				}
			}
		}
		global::EBulletShape shape = bulletDataMain.Base.Shape;
		global::Vector size = bulletInfo.Size;
		global::Vector size2 = bulletInitParams.Size;
		if (size2 != null)
		{
			if (shape == global::EBulletShape.Cylinder)
			{
				size.Set(size2.X, 0.0, size2.Z);
			}
			else
			{
				size.FromUeVector(size2);
			}
		}
		else
		{
			size.FromUeVector(bulletDataMain.Base.Size);
		}
		bulletInfo.Duration = bulletDataMain.Base.Duration;
		BulletAdditionInfo additionInfo = bulletInfo.AdditionInfo;
		if (additionInfo != null && additionInfo.Valid)
		{
			global::Vector sizeScale = additionInfo.SizeScale;
			if (!sizeScale.IsZero())
			{
				size.MultiplyEqual(sizeScale);
			}
			bulletInfo.Duration += additionInfo.DurationAddition;
		}
		bulletInfo.BaseSize.FromUeVector(size);
		if (bulletDataMain.Children.Length != 0)
		{
			BulletController.Instance.AddSimpleAction(bulletInfo, EBulletAction.Child);
		}
		BulletController.Instance.AddSimpleAction(bulletInfo, EBulletAction.InitHit);
		BulletController.Instance.AddSimpleAction(bulletInfo, EBulletAction.InitMove);
		BulletController.Instance.AddSimpleAction(bulletInfo, EBulletAction.InitCollision);
		if (bulletDataMain.Summon.EntityId > 0)
		{
			BulletController.Instance.AddSimpleAction(bulletInfo, EBulletAction.SummonEntity);
		}
		BulletController.Instance.AddSimpleAction(bulletInfo, EBulletAction.InitRender);
		if (bulletDataMain.Logic.DestroyOnFrozen)
		{
			BulletController.Instance.AddSimpleAction(bulletInfo, EBulletAction.UpdateAttackerFrozen);
		}
		BulletController.Instance.AddSimpleAction(bulletInfo, EBulletAction.UpdateEffect);
		if (bulletDataMain.Interact.IsSceneInteract)
		{
			BulletController.Instance.AddSimpleAction(bulletInfo, EBulletAction.SceneInteract);
		}
		BulletController.Instance.AddSimpleAction(bulletInfo, EBulletAction.UpdateLiveTime);
		BulletController.Instance.AddSimpleAction(bulletInfo, EBulletAction.TimeScale);
		BulletController.Instance.AddSimpleAction(bulletInfo, EBulletAction.AfterInit);
	}

	// Token: 0x060187FD RID: 100349 RVA: 0x0063CEA0 File Offset: 0x0063B0A0
	private unsafe void CheckBulletTag(int tagId, string bulletConfigId, string msg)
	{
		string nameByTagId = GameplayTagUtils.GetNameByTagId(tagId);
		if (nameByTagId == null || !nameByTagId.StartsWith("子弹."))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Bullet;
			ELogAuthor author = ELogAuthor.CFT;
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("BulletId", bulletConfigId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Tag", nameByTagId);
			instance.Error(module, author, msg, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}
	}

	// Token: 0x0400B5BC RID: 46524
	private const string BULLET_TAG_PREFIX = "子弹.";
}

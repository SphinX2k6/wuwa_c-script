using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using UnrealEngine;

// Token: 0x020022D8 RID: 8920
public class BulletActionAfterInit : BulletActionBase
{
	// Token: 0x06016056 RID: 90198 RVA: 0x00660C5B File Offset: 0x0065EE5B
	public BulletActionAfterInit(EBulletAction type) : base(type)
	{
	}

	// Token: 0x06016057 RID: 90199 RVA: 0x00660C64 File Offset: 0x0065EE64
	protected unsafe override void OnExecute()
	{
		BulletInfo bulletInfo = this.BulletInfo;
		BulletDataMain bulletDataMain = bulletInfo.BulletDataMain;
		Entity attacker = bulletInfo.Attacker;
		FGameplayTag sendGameplayEventTagToAttackerOnStart = bulletDataMain.Execution.SendGameplayEventTagToAttackerOnStart;
		if (!sendGameplayEventTagToAttackerOnStart.TagName.IsNone())
		{
			BaseActorComponent attackerActorComp = bulletInfo.AttackerActorComp;
			AActor aactor = (attackerActorComp != null) ? attackerActorComp.Owner : null;
			if (aactor != null && aactor.IsValid())
			{
				FGameplayEventData fgameplayEventData = new FGameplayEventData();
				fgameplayEventData.OptionalObject = bulletInfo.Actor;
				UAbilitySystemBlueprintLibrary.SendGameplayEventToActor(aactor, sendGameplayEventTagToAttackerOnStart, fgameplayEventData);
			}
		}
		bulletInfo.IsInit = true;
		if (!bulletInfo.BulletInitParams.FromRemote)
		{
			ActiveBulletHandle activeBulletHandle = ActiveBulletHandle.Create();
			activeBulletHandle.HandleId = bulletInfo.BulletEntityId;
			activeBulletHandle.PlayerId = CreatureModel.Instance.GetPlayerId();
			BulletModel.Instance.RegisterBullet(activeBulletHandle, bulletInfo.BulletEntityId);
			bool flag = bulletInfo.BulletInitParams.SyncType != EBulletSyncType.SyncCreate;
			long? creatureDataId = BulletActionAfterInit.GetCreatureDataId(bulletInfo.TargetId);
			global::Vector actorLocation = bulletInfo.GetActorLocation();
			global::Rotator beginSpeedRotator = bulletInfo.MoveInfo.BeginSpeedRotator;
			CreateBulletPush createBulletPush = new CreateBulletPush();
			createBulletPush.Handle = activeBulletHandle;
			createBulletPush.BulletId = MathUtils.Instance.NumberToLong(long.Parse(bulletInfo.BulletRowName));
			createBulletPush.SkillId = (long)bulletInfo.BulletInitParams.SkillId;
			createBulletPush.Location = actorLocation.ToProtocolVector();
			createBulletPush.Rotation = beginSpeedRotator.ToProtocolRotator();
			createBulletPush.ParentHandle = BulletModel.Instance.GetBulletHandleById(bulletInfo.BulletInitParams.ParentId);
			long? creatureDataId2 = BulletActionAfterInit.GetCreatureDataId(bulletInfo.BulletInitParams.BaseTransformId);
			if (creatureDataId2 != null)
			{
				createBulletPush.SpawnEntityId = MathUtils.Instance.NumberToLong(creatureDataId2.Value);
			}
			long? creatureDataId3 = BulletActionAfterInit.GetCreatureDataId(bulletInfo.BulletInitParams.BaseVelocityId);
			if (creatureDataId3 != null)
			{
				createBulletPush.SpawnVelocityEntityId = MathUtils.Instance.NumberToLong(creatureDataId3.Value);
			}
			if (creatureDataId != null)
			{
				createBulletPush.TargetId = MathUtils.Instance.NumberToLong(creatureDataId.Value);
			}
			createBulletPush.IsLocal = flag;
			createBulletPush.RandomInitPosOffset = bulletInfo.RandomPosOffset.ToProtocolVector();
			createBulletPush.RandomInitSpeed = bulletInfo.RandomInitSpeedOffset.ToProtocolVector();
			this.CompressData(createBulletPush);
			bulletInfo.ContextIdSubmitted = true;
			CombatNet.Instance.Send(EPushMessageId.CreateBulletPush, attacker, createBulletPush, bulletInfo.PreContextId, bulletInfo.ContextId, null);
			if (BulletConstant.Instance.OpenCreateLog)
			{
				if (!flag)
				{
					bool gasDebug = true;
					ELogAuthor author = ELogAuthor.HCW;
					Entity owner = attacker;
					string message = "创建同步子弹";
					BulletInfo bulletInfo2 = bulletInfo;
					<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("skillId", bulletInfo.BulletInitParams.SkillId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Location", actorLocation);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Rotation", beginSpeedRotator);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("TargetId", creatureDataId);
					BulletLog.Debug(gasDebug, author, owner, message, bulletInfo2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
				}
				else
				{
					BulletLog.Debug(true, ELogAuthor.HCW, attacker, "创建本地子弹", bulletInfo, default(ReadOnlySpan<ValueTuple<string, object>>));
				}
			}
		}
		else
		{
			bulletInfo.ContextIdSubmitted = true;
			if (BulletConstant.Instance.OpenCreateLog)
			{
				BulletLog.Debug(true, ELogAuthor.HCW, attacker, "创建被同步子弹", bulletInfo, default(ReadOnlySpan<ValueTuple<string, object>>));
			}
		}
		bulletInfo.ActionLogicComponent.OnAfterInit();
	}

	// Token: 0x06016058 RID: 90200 RVA: 0x00660FC4 File Offset: 0x0065F1C4
	private static long? GetCreatureDataId(int entityId)
	{
		CreatureDataComponent component = EntitySystem.Instance.GetComponent<CreatureDataComponent>(entityId);
		if (component == null)
		{
			return null;
		}
		return new long?(component.GetCreatureDataId());
	}

	// Token: 0x06016059 RID: 90201 RVA: 0x00660FF4 File Offset: 0x0065F1F4
	[NullableContext(1)]
	private void CompressData(CreateBulletPush data)
	{
		if (!GameModeModel.Instance.IsMulti)
		{
			data.Location = null;
			data.Rotation = null;
			data.ParentHandle = null;
			data.SpawnVelocityEntityId = 0L;
			data.RandomInitPosOffset = null;
			data.RandomInitSpeed = null;
		}
	}
}

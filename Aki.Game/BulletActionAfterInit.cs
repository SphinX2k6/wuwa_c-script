using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x02002D7E RID: 11646
public class BulletActionAfterInit : BulletActionBase
{
	// Token: 0x060187B4 RID: 100276 RVA: 0x0063AC2B File Offset: 0x00638E2B
	public BulletActionAfterInit(EBulletAction type) : base(type)
	{
	}

	// Token: 0x060187B5 RID: 100277 RVA: 0x0063AC34 File Offset: 0x00638E34
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
		if (Info.Instance.IsBuildDevelopmentOrDebug)
		{
			EventSystem.Instance.EmitWithTarget<BulletInfo>(attacker, EEventName.BulletCreate, bulletInfo);
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

	// Token: 0x060187B6 RID: 100278 RVA: 0x0063AFB4 File Offset: 0x006391B4
	private static long? GetCreatureDataId(int entityId)
	{
		CreatureDataComponent component = EntitySystem.Instance.GetComponent<CreatureDataComponent>(entityId);
		if (component == null)
		{
			return null;
		}
		return new long?(component.GetCreatureDataId());
	}

	// Token: 0x060187B7 RID: 100279 RVA: 0x0063AFE4 File Offset: 0x006391E4
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

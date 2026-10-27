using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.NewWorld.Common.Component;
using CSharpScript.Game.NewWorld.SceneItem.Common.Component;
using CSharpScript.Game.Render;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem
{
	// Token: 0x02007160 RID: 29024
	public class SceneItemTreasureBoxComponent : EntityComponent
	{
		// Token: 0x06046D9C RID: 290204 RVA: 0x011DDC68 File Offset: 0x011DBE68
		[NullableContext(2)]
		protected override bool OnInitData(IEntityArgs args = null)
		{
			TreasureBoxComponent treasureBoxComponent = args.GetP1<CreateEntityData>().GetParam<SceneItemTreasureBoxComponent>() as TreasureBoxComponent;
			int? num = (treasureBoxComponent != null) ? new int?(treasureBoxComponent.TypeId) : null;
			this.TreasureBoxType = ((num != null) ? new SceneItemTreasureBoxComponent.ETreasureBoxType?((SceneItemTreasureBoxComponent.ETreasureBoxType)num.GetValueOrDefault()) : null);
			return true;
		}

		// Token: 0x06046D9D RID: 290205 RVA: 0x011DDCC8 File Offset: 0x011DBEC8
		protected unsafe override bool OnStart()
		{
			CreatureDataComponent component = base.Entity.GetComponent<CreatureDataComponent>();
			BaseInfoComponent baseInfoComponent = (component != null) ? component.GetBaseInfo() : null;
			if (baseInfoComponent == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Level;
				ELogAuthor author = ELogAuthor.YZH;
				string message = "[SceneItemTreasureBoxComponent.OnStart] 宝箱组件初始化失败,没有基础信息配置(baseInfo)";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("CreatureGenID:", (component != null) ? new long?(component.GetOwnerId()) : null);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("PbDataId:", (component != null) ? new int?(component.GetPbDataId()) : null);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return false;
			}
			this.EntityOnlineType = new EOnlineInteractType?(baseInfoComponent.OnlineInteractType);
			return true;
		}

		// Token: 0x06046D9E RID: 290206 RVA: 0x011DDD98 File Offset: 0x011DBF98
		protected override void OnActivate()
		{
			if (EventSystem.Instance.HasWithTarget<int, bool>(base.Entity, EEventName.OnSceneItemStateChange, new Action<int, bool>(this.OnSceneItemStateChange)))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Temp;
				ELogAuthor author = ELogAuthor.CH;
				string message = "SceneItemTreasureBoxComponent.OnActivate: 重复添加事件";
				string item = "PbDataId";
				CreatureDataComponent component = base.Entity.GetComponent<CreatureDataComponent>();
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>(item, (component != null) ? new int?(component.GetPbDataId()) : null);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			else
			{
				EventSystem.Instance.AddWithTarget<int, bool>(base.Entity, EEventName.OnSceneItemStateChange, new Action<int, bool>(this.OnSceneItemStateChange));
			}
			if (this.TreasureBoxType.GetValueOrDefault() == SceneItemTreasureBoxComponent.ETreasureBoxType.Phantom)
			{
				EventSystem.Instance.AddWithTarget<bool>(base.Entity, EEventName.OnSceneItemLockPropChange, new Action<bool>(this.HandleLockPropChange));
				EventSystem.Instance.AddWithTarget<int>(base.Entity, EEventName.OnSceneItemStatePreChange, new Action<int>(this.HandlePreUpdateState));
			}
			this.CurPhantomPerformTag = null;
			if (!base.Entity.CheckGetComponent<SceneItemStateComponent>().IsInState(SceneItemStateComponent.ESceneItemState.Born))
			{
				this.HandleUpdateState();
			}
		}

		// Token: 0x06046D9F RID: 290207 RVA: 0x011DDEB4 File Offset: 0x011DC0B4
		protected override bool OnEnd()
		{
			EventSystem.Instance.RemoveWithTarget<int, bool>(base.Entity, EEventName.OnSceneItemStateChange, new Action<int, bool>(this.OnSceneItemStateChange));
			if (this.TreasureBoxType.GetValueOrDefault() == SceneItemTreasureBoxComponent.ETreasureBoxType.Phantom)
			{
				EventSystem.Instance.RemoveWithTarget<bool>(base.Entity, EEventName.OnSceneItemLockPropChange, new Action<bool>(this.HandleLockPropChange));
				EventSystem.Instance.RemoveWithTarget<int>(base.Entity, EEventName.OnSceneItemStatePreChange, new Action<int>(this.HandlePreUpdateState));
			}
			return true;
		}

		// Token: 0x06046DA0 RID: 290208 RVA: 0x011DDF38 File Offset: 0x011DC138
		private void UpdatePhantomBoxPerform()
		{
			SceneItemStateComponent sceneItemStateComponent = base.Entity.CheckGetComponent<SceneItemStateComponent>();
			LevelTagComponent levelTagComponent = base.Entity.CheckGetComponent<LevelTagComponent>();
			int? num = null;
			int? num2 = null;
			SceneItemStateComponent.ESceneItemState state = sceneItemStateComponent.State;
			if (state != SceneItemStateComponent.ESceneItemState.Normal)
			{
				if (state == SceneItemStateComponent.ESceneItemState.Active)
				{
					num2 = new int?(GameplayTagDefine.EGameplayTagId["关卡.Common.表现.幻象宝箱.解锁"]);
					num = new int?(GameplayTagDefine.EGameplayTagId["关卡.Common.表现.幻象宝箱.开启"]);
				}
			}
			else if (base.Entity.CheckGetComponent<SceneItemPropertyComponent>().IsLocked)
			{
				num2 = new int?(GameplayTagDefine.EGameplayTagId["关卡.Common.表现.幻象宝箱.解锁"]);
				num = new int?(GameplayTagDefine.EGameplayTagId["关卡.Common.表现.幻象宝箱.封锁"]);
			}
			else
			{
				num2 = new int?(GameplayTagDefine.EGameplayTagId["关卡.Common.表现.幻象宝箱.封锁"]);
				num = new int?(GameplayTagDefine.EGameplayTagId["关卡.Common.表现.幻象宝箱.解锁"]);
			}
			if (num != null)
			{
				int? num3 = this.CurPhantomPerformTag;
				int? num4 = num;
				if (num3.GetValueOrDefault() == num4.GetValueOrDefault() & num3 != null == (num4 != null))
				{
					return;
				}
				LevelTagComponent levelTagComponent2 = levelTagComponent;
				long notifyLock = levelTagComponent2.NotifyLock;
				levelTagComponent2.NotifyLock = notifyLock + 1L;
				if (num2 != null)
				{
					num4 = this.CurPhantomPerformTag;
					num3 = num2;
					if (num4.GetValueOrDefault() == num3.GetValueOrDefault() & num4 != null == (num3 != null))
					{
						levelTagComponent.RemoveTag(num2);
					}
				}
				this.CurPhantomPerformTag = num;
				levelTagComponent.AddTag(num);
				LevelTagComponent levelTagComponent3 = levelTagComponent;
				notifyLock = levelTagComponent3.NotifyLock;
				levelTagComponent3.NotifyLock = notifyLock - 1L;
			}
		}

		// Token: 0x06046DA1 RID: 290209 RVA: 0x011DE0C7 File Offset: 0x011DC2C7
		private void OnSceneItemStateChange(int stateId, bool isReady)
		{
			this.HandleUpdateState();
		}

		// Token: 0x06046DA2 RID: 290210 RVA: 0x011DE0CF File Offset: 0x011DC2CF
		private void HandleUpdateState()
		{
			this.UpdatePhantomBoxPerform();
			if (base.Entity.CheckGetComponent<SceneItemStateComponent>().IsInState(SceneItemStateComponent.ESceneItemState.Active))
			{
				this.DeathProcess();
			}
		}

		// Token: 0x06046DA3 RID: 290211 RVA: 0x011DE0F0 File Offset: 0x011DC2F0
		private void HandlePreUpdateState(int stateId)
		{
			this.UpdatePhantomBoxPerform();
		}

		// Token: 0x06046DA4 RID: 290212 RVA: 0x011DE0F8 File Offset: 0x011DC2F8
		private void HandleLockPropChange(bool lockValue)
		{
			this.UpdatePhantomBoxPerform();
		}

		// Token: 0x06046DA5 RID: 290213 RVA: 0x011DE100 File Offset: 0x011DC300
		private void DeathProcess()
		{
			int? id = PlayerInfoModel.Instance.GetId();
			int worldOwner = CreatureModel.Instance.GetWorldOwner();
			if (!(id.GetValueOrDefault() == worldOwner & id != null))
			{
				return;
			}
			if (!LevelGamePlayController.Instance.MultiplayerLimitTypeCheck(this.EntityOnlineType.Value, true))
			{
				return;
			}
			LevelGamePlayController.Instance.GetRewardTreasureBoxRequest(base.Entity.Id);
		}

		// Token: 0x06046DA6 RID: 290214 RVA: 0x011DE168 File Offset: 0x011DC368
		public void CloseAllCollisions()
		{
			SceneItemActorComponent component = base.Entity.GetComponent<SceneItemActorComponent>();
			SceneItemTreasureBoxComponent.CloseCollisionsByParentActor(component.Owner);
			TArray<AActor> sceneInteractionAllActorsInLevel = SceneInteractionManager.Get().GetSceneInteractionAllActorsInLevel(component.GetSceneInteractionLevelHandleId());
			if (sceneInteractionAllActorsInLevel != null)
			{
				int i = 0;
				int num = sceneInteractionAllActorsInLevel.Num();
				while (i < num)
				{
					SceneItemTreasureBoxComponent.CloseCollisionsByParentActor(sceneInteractionAllActorsInLevel.Get(i));
					i++;
				}
			}
		}

		// Token: 0x06046DA7 RID: 290215 RVA: 0x011DE1C0 File Offset: 0x011DC3C0
		[NullableContext(1)]
		private static void CloseCollisionsByParentActor(AActor parentActor)
		{
			TArray<UActorComponent> tarray = parentActor.K2_GetComponentsByClass(UPrimitiveComponent.StaticClass());
			if (tarray != null)
			{
				int i = 0;
				int num = tarray.Num();
				while (i < num)
				{
					UPrimitiveComponent uprimitiveComponent = tarray.Get(i) as UPrimitiveComponent;
					uprimitiveComponent.CanCharacterStepUpOn = ECanBeCharacterBase.ECB_No;
					uprimitiveComponent.SetCollisionResponseToAllChannels(ECollisionResponse.ECR_Ignore);
					uprimitiveComponent.SetCollisionResponseToChannel(KuroCollisionChannel.Pawn, ECollisionResponse.ECR_Block);
					uprimitiveComponent.SetCollisionResponseToChannel(KuroCollisionChannel.PawnPlayer, ECollisionResponse.ECR_Block);
					uprimitiveComponent.SetCollisionResponseToChannel(KuroCollisionChannel.PawnMonster, ECollisionResponse.ECR_Block);
					i++;
				}
			}
		}

		// Token: 0x06046DA8 RID: 290216 RVA: 0x011DE238 File Offset: 0x011DC438
		[NullableContext(1)]
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			SceneItemTreasureBoxComponent sceneItemTreasureBoxComponent = (SceneItemTreasureBoxComponent)componentTemplate;
			if (base.CanResetComponentProperty("EntityOnlineType"))
			{
				this.EntityOnlineType = sceneItemTreasureBoxComponent.EntityOnlineType;
			}
			if (base.CanResetComponentProperty("TreasureBoxType"))
			{
				this.TreasureBoxType = sceneItemTreasureBoxComponent.TreasureBoxType;
			}
			if (base.CanResetComponentProperty("CurPhantomPerformTag"))
			{
				this.CurPhantomPerformTag = sceneItemTreasureBoxComponent.CurPhantomPerformTag;
			}
			return true;
		}

		// Token: 0x040252FE RID: 152318
		private EOnlineInteractType? EntityOnlineType;

		// Token: 0x040252FF RID: 152319
		private SceneItemTreasureBoxComponent.ETreasureBoxType? TreasureBoxType;

		// Token: 0x04025300 RID: 152320
		private int? CurPhantomPerformTag;

		// Token: 0x0200CEA5 RID: 52901
		private enum ETreasureBoxType
		{
			// Token: 0x0403E2F3 RID: 254707
			Common = 1,
			// Token: 0x0403E2F4 RID: 254708
			Phantom,
			// Token: 0x0403E2F5 RID: 254709
			LevelPlayRefresh
		}
	}
}

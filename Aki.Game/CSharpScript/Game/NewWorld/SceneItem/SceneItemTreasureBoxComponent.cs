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
	// Token: 0x02006214 RID: 25108
	public class SceneItemTreasureBoxComponent : EntityComponent
	{
		// Token: 0x0603C5E2 RID: 247266 RVA: 0x0113987C File Offset: 0x01137A7C
		[NullableContext(2)]
		protected override bool OnInitData(IEntityArgs args = null)
		{
			TreasureBoxComponent treasureBoxComponent = args.GetP1<CreateEntityData>().GetParam<SceneItemTreasureBoxComponent>() as TreasureBoxComponent;
			int? num = (treasureBoxComponent != null) ? new int?(treasureBoxComponent.TypeId) : null;
			this.TreasureBoxType = ((num != null) ? new SceneItemTreasureBoxComponent.ETreasureBoxType?((SceneItemTreasureBoxComponent.ETreasureBoxType)num.GetValueOrDefault()) : null);
			return true;
		}

		// Token: 0x0603C5E3 RID: 247267 RVA: 0x011398DC File Offset: 0x01137ADC
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

		// Token: 0x0603C5E4 RID: 247268 RVA: 0x011399AC File Offset: 0x01137BAC
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

		// Token: 0x0603C5E5 RID: 247269 RVA: 0x01139AC8 File Offset: 0x01137CC8
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

		// Token: 0x0603C5E6 RID: 247270 RVA: 0x01139B4C File Offset: 0x01137D4C
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

		// Token: 0x0603C5E7 RID: 247271 RVA: 0x01139CDB File Offset: 0x01137EDB
		private void OnSceneItemStateChange(int stateId, bool isReady)
		{
			this.HandleUpdateState();
		}

		// Token: 0x0603C5E8 RID: 247272 RVA: 0x01139CE3 File Offset: 0x01137EE3
		private void HandleUpdateState()
		{
			this.UpdatePhantomBoxPerform();
			if (base.Entity.CheckGetComponent<SceneItemStateComponent>().IsInState(SceneItemStateComponent.ESceneItemState.Active))
			{
				this.DeathProcess();
			}
		}

		// Token: 0x0603C5E9 RID: 247273 RVA: 0x01139D04 File Offset: 0x01137F04
		private void HandlePreUpdateState(int stateId)
		{
			this.UpdatePhantomBoxPerform();
		}

		// Token: 0x0603C5EA RID: 247274 RVA: 0x01139D0C File Offset: 0x01137F0C
		private void HandleLockPropChange(bool lockValue)
		{
			this.UpdatePhantomBoxPerform();
		}

		// Token: 0x0603C5EB RID: 247275 RVA: 0x01139D14 File Offset: 0x01137F14
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

		// Token: 0x0603C5EC RID: 247276 RVA: 0x01139D7C File Offset: 0x01137F7C
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

		// Token: 0x0603C5ED RID: 247277 RVA: 0x01139DD4 File Offset: 0x01137FD4
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

		// Token: 0x0603C5EE RID: 247278 RVA: 0x01139E4C File Offset: 0x0113804C
		[NullableContext(1)]
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			SceneItemTreasureBoxComponent sceneItemTreasureBoxComponent = (SceneItemTreasureBoxComponent)componentTemplate;
			this.EntityOnlineType = sceneItemTreasureBoxComponent.EntityOnlineType;
			this.TreasureBoxType = sceneItemTreasureBoxComponent.TreasureBoxType;
			this.CurPhantomPerformTag = sceneItemTreasureBoxComponent.CurPhantomPerformTag;
			return true;
		}

		// Token: 0x170071F8 RID: 29176
		// (get) Token: 0x0603C5EF RID: 247279 RVA: 0x01139E90 File Offset: 0x01138090
		public override bool NeedStartInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170071F9 RID: 29177
		// (get) Token: 0x0603C5F0 RID: 247280 RVA: 0x01139E93 File Offset: 0x01138093
		public override bool NeedActivateInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170071FA RID: 29178
		// (get) Token: 0x0603C5F1 RID: 247281 RVA: 0x01139E96 File Offset: 0x01138096
		public override bool NeedEndInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0401FF65 RID: 130917
		private EOnlineInteractType? EntityOnlineType;

		// Token: 0x0401FF66 RID: 130918
		private SceneItemTreasureBoxComponent.ETreasureBoxType? TreasureBoxType;

		// Token: 0x0401FF67 RID: 130919
		private int? CurPhantomPerformTag;

		// Token: 0x0200BA3B RID: 47675
		private enum ETreasureBoxType
		{
			// Token: 0x04039619 RID: 235033
			Common = 1,
			// Token: 0x0403961A RID: 235034
			Phantom,
			// Token: 0x0403961B RID: 235035
			LevelPlayRefresh
		}
	}
}

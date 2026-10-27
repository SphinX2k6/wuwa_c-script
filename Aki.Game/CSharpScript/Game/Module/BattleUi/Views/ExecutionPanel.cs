using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.NewWorld.Pawn.Component;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005D20 RID: 23840
	[NullableContext(2)]
	[Nullable(0)]
	public class ExecutionPanel : UiPanelBase
	{
		// Token: 0x0603C6FC RID: 247548 RVA: 0x00E7E10C File Offset: 0x00E7C30C
		[NullableContext(1)]
		public void Init(UUIItem parentItem)
		{
			this.ChildViewData = BattleUiModel.Instance.ChildViewData;
			this.ChildVisible = this.ChildViewData.GetChildVisible(EBattleUiChild.BattleHud);
			this.Initialize(parentItem).Forget();
		}

		// Token: 0x0603C6FD RID: 247549 RVA: 0x00E7E140 File Offset: 0x00E7C340
		[NullableContext(1)]
		public UniTask Initialize(UUIItem parentItem)
		{
			ExecutionPanel.<Initialize>d__12 <Initialize>d__;
			<Initialize>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Initialize>d__.<>4__this = this;
			<Initialize>d__.parentItem = parentItem;
			<Initialize>d__.<>1__state = -1;
			<Initialize>d__.<>t__builder.Start<ExecutionPanel.<Initialize>d__12>(ref <Initialize>d__);
			return <Initialize>d__.<>t__builder.Task;
		}

		// Token: 0x0603C6FE RID: 247550 RVA: 0x00E7E18C File Offset: 0x00E7C38C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603C6FF RID: 247551 RVA: 0x00E7E216 File Offset: 0x00E7C416
		public UUIItem GetExecutionItem()
		{
			if (!base.IsShowOrShowing)
			{
				return null;
			}
			return base.GetItem(0);
		}

		// Token: 0x0603C700 RID: 247552 RVA: 0x00E7E22C File Offset: 0x00E7C42C
		protected override UniTask OnBeforeStartAsync()
		{
			ExecutionPanel.<OnBeforeStartAsync>d__15 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ExecutionPanel.<OnBeforeStartAsync>d__15>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603C701 RID: 247553 RVA: 0x00E7E270 File Offset: 0x00E7C470
		[NullableContext(0)]
		private UniTask<bool> NewSkillItem()
		{
			ExecutionPanel.<NewSkillItem>d__16 <NewSkillItem>d__;
			<NewSkillItem>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<NewSkillItem>d__.<>4__this = this;
			<NewSkillItem>d__.<>1__state = -1;
			<NewSkillItem>d__.<>t__builder.Start<ExecutionPanel.<NewSkillItem>d__16>(ref <NewSkillItem>d__);
			return <NewSkillItem>d__.<>t__builder.Task;
		}

		// Token: 0x0603C702 RID: 247554 RVA: 0x00E7E2B3 File Offset: 0x00E7C4B3
		protected override void OnStart()
		{
			this.InitTweenAnim(1);
			this.InitTweenAnim(2);
		}

		// Token: 0x0603C703 RID: 247555 RVA: 0x00E7E2C3 File Offset: 0x00E7C4C3
		protected override void OnAfterShow()
		{
			this.StopTweenAnim(2);
			this.PlayTweenAnim(1);
		}

		// Token: 0x0603C704 RID: 247556 RVA: 0x00E7E2D4 File Offset: 0x00E7C4D4
		protected override UniTask OnBeforeHideAsync()
		{
			ExecutionPanel.<OnBeforeHideAsync>d__19 <OnBeforeHideAsync>d__;
			<OnBeforeHideAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeHideAsync>d__.<>4__this = this;
			<OnBeforeHideAsync>d__.<>1__state = -1;
			<OnBeforeHideAsync>d__.<>t__builder.Start<ExecutionPanel.<OnBeforeHideAsync>d__19>(ref <OnBeforeHideAsync>d__);
			return <OnBeforeHideAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603C705 RID: 247557 RVA: 0x00E7E317 File Offset: 0x00E7C517
		private void OnCloseAnimTimerEnd(float _)
		{
			this.CloseTimer = null;
			this.Promise.SetResult();
			this.Promise = null;
		}

		// Token: 0x0603C706 RID: 247558 RVA: 0x00E7E334 File Offset: 0x00E7C534
		protected override void OnBeforeDestroy()
		{
			if (this.CloseTimer != null)
			{
				TimerSystem.Instance.Remove(this.CloseTimer);
				this.CloseTimer = null;
				this.Promise.SetResult();
			}
			ExecutionItem skillItem = this.SkillItem;
			if (skillItem != null)
			{
				skillItem.Destroy(null);
			}
			this.SkillItem = null;
			this.RemoveEvents();
		}

		// Token: 0x0603C707 RID: 247559 RVA: 0x00E7E38C File Offset: 0x00E7C58C
		private void AddEvents()
		{
			if (!Info.Instance.IsInTouch())
			{
				InputDistributeController.Instance.BindAction("通用交互", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputAction));
			}
			this.ChildViewData.AddCallback(EBattleUiChild.BattleHud, new Action(this.OnBattleChildVisibleChanged));
		}

		// Token: 0x0603C708 RID: 247560 RVA: 0x00E7E3DC File Offset: 0x00E7C5DC
		private void RemoveEvents()
		{
			if (!Info.Instance.IsInTouch())
			{
				InputDistributeController.Instance.UnBindAction("通用交互", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputAction));
			}
			this.ChildViewData.RemoveCallback(EBattleUiChild.BattleHud, new Action(this.OnBattleChildVisibleChanged));
		}

		// Token: 0x0603C709 RID: 247561 RVA: 0x00E7E429 File Offset: 0x00E7C629
		[NullableContext(1)]
		private void OnInputAction(string actionName, InputDistributeDefine.EActionType actionType, InputIdentification inputIdentification)
		{
			if (actionType == InputDistributeDefine.EActionType.Release)
			{
				this.OnInteract();
			}
		}

		// Token: 0x0603C70A RID: 247562 RVA: 0x00E7E438 File Offset: 0x00E7C638
		private void OnInteract()
		{
			EntityHandle entityHandle = this.EntityHandle;
			if (entityHandle == null || !entityHandle.Valid)
			{
				this.RemoveEntityEvents();
				this.EntityHandle = null;
				base.Hide(null);
				return;
			}
			ExecutionItem skillItem = this.SkillItem;
			if (skillItem != null)
			{
				skillItem.OnInputAction(false);
			}
			PawnInteractBaseComponent component = this.EntityHandle.Entity.GetComponent<PawnInteractBaseComponent>();
			if (component == null || !component.IsPawnInteractive())
			{
				return;
			}
			component.InteractPawn(-1, null);
		}

		// Token: 0x0603C70B RID: 247563 RVA: 0x00E7E4B0 File Offset: 0x00E7C6B0
		private void OnBattleChildVisibleChanged()
		{
			this.ChildVisible = this.ChildViewData.GetChildVisible(EBattleUiChild.BattleHud);
			if (this.ChildVisible)
			{
				EntityHandle entityHandle = this.EntityHandle;
				if (entityHandle != null && entityHandle.Valid && !base.IsShowOrShowing)
				{
					base.Show(null);
					return;
				}
			}
			else if (!base.IsHideOrHiding)
			{
				base.Hide(null);
			}
		}

		// Token: 0x0603C70C RID: 247564 RVA: 0x00E7E50C File Offset: 0x00E7C70C
		private void InitTweenAnim(int componentType)
		{
			TArray<UActorComponent> tarray = base.GetItem(componentType).GetOwner().K2_GetComponentsByClass(ULGUIPlayTweenComponent.StaticClass());
			List<ULGUIPlayTweenComponent> list = new List<ULGUIPlayTweenComponent>(tarray.Count);
			foreach (UActorComponent uactorComponent in tarray)
			{
				list.Add((ULGUIPlayTweenComponent)uactorComponent);
			}
			if (this.TweenAnimMap == null)
			{
				this.TweenAnimMap = new Dictionary<int, List<ULGUIPlayTweenComponent>>();
			}
			this.TweenAnimMap[componentType] = list;
		}

		// Token: 0x0603C70D RID: 247565 RVA: 0x00E7E5A0 File Offset: 0x00E7C7A0
		private void PlayTweenAnim(int componentType)
		{
			List<ULGUIPlayTweenComponent> list;
			if (this.TweenAnimMap != null && this.TweenAnimMap.TryGetValue(componentType, out list))
			{
				foreach (ULGUIPlayTweenComponent ulguiplayTweenComponent in list)
				{
					ulguiplayTweenComponent.Play();
				}
			}
		}

		// Token: 0x0603C70E RID: 247566 RVA: 0x00E7E604 File Offset: 0x00E7C804
		private void StopTweenAnim(int componentType)
		{
			List<ULGUIPlayTweenComponent> list;
			if (this.TweenAnimMap != null && this.TweenAnimMap.TryGetValue(componentType, out list))
			{
				foreach (ULGUIPlayTweenComponent ulguiplayTweenComponent in list)
				{
					ulguiplayTweenComponent.Stop();
				}
			}
		}

		// Token: 0x0603C70F RID: 247567 RVA: 0x00E7E668 File Offset: 0x00E7C868
		public void ShowByEntity(int entityId, ECustomOptionType? optionType)
		{
			ECustomOptionType? optionType2 = this.OptionType;
			ECustomOptionType? ecustomOptionType = optionType;
			if (!(optionType2.GetValueOrDefault() == ecustomOptionType.GetValueOrDefault() & optionType2 != null == (ecustomOptionType != null)))
			{
				this.OptionType = optionType;
				if (this.OptionType.GetValueOrDefault() == ECustomOptionType.Execution)
				{
					ExecutionItem skillItem = this.SkillItem;
					if (skillItem != null)
					{
						skillItem.RefreshSkillIconByResId("SP_IconPutDeath");
					}
				}
				else if (this.OptionType.GetValueOrDefault() == ECustomOptionType.BreakWeakness)
				{
					ExecutionItem skillItem2 = this.SkillItem;
					if (skillItem2 != null)
					{
						skillItem2.RefreshSkillIconByResId("T_MstSkil_1002_UI");
					}
				}
			}
			EntityHandle entityHandle = this.EntityHandle;
			if (entityHandle != null && entityHandle.Id == entityId)
			{
				return;
			}
			EntityHandle entityById = CreatureModel.Instance.GetEntityById(entityId);
			if (entityById == null)
			{
				this.OnRemove();
				return;
			}
			this.RemoveEntityEvents();
			this.EntityHandle = entityById;
			this.OnAdd();
		}

		// Token: 0x0603C710 RID: 247568 RVA: 0x00E7E733 File Offset: 0x00E7C933
		public void HideByEntity(int entityId)
		{
			EntityHandle entityHandle = this.EntityHandle;
			if (entityHandle == null || entityHandle.Id != entityId)
			{
				return;
			}
			this.OnRemove();
		}

		// Token: 0x0603C711 RID: 247569 RVA: 0x00E7E756 File Offset: 0x00E7C956
		private void OnAdd()
		{
			this.AddEntityEvents();
			if (!base.IsShowOrShowing && this.ChildVisible)
			{
				base.Show(null);
			}
			BattleUiModel.Instance.SetExecutionInteractEnable(true);
			BattleUiModel.Instance.ChildViewData.SetChildVisible(EBattleUiVisibleReason.Custom, EBattleUiChild.InteractionHint, false, true, 0);
		}

		// Token: 0x0603C712 RID: 247570 RVA: 0x00E7E796 File Offset: 0x00E7C996
		private void OnRemove()
		{
			this.RemoveEntityEvents();
			this.EntityHandle = null;
			if (!base.IsHideOrHiding)
			{
				base.Hide(null);
			}
			BattleUiModel.Instance.SetExecutionInteractEnable(false);
			BattleUiModel.Instance.ChildViewData.SetChildVisible(EBattleUiVisibleReason.Custom, EBattleUiChild.InteractionHint, true, true, 0);
		}

		// Token: 0x0603C713 RID: 247571 RVA: 0x00E7E7D5 File Offset: 0x00E7C9D5
		private void AddEntityEvents()
		{
			if (this.EntityHandle == null)
			{
				return;
			}
			EventSystem.Instance.AddWithTarget<ERemoveEntityType, EntityHandle>(this.EntityHandle, EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnRemoveEntity));
		}

		// Token: 0x0603C714 RID: 247572 RVA: 0x00E7E802 File Offset: 0x00E7CA02
		private void RemoveEntityEvents()
		{
			if (this.EntityHandle == null)
			{
				return;
			}
			EventSystem.Instance.RemoveWithTarget(this.EntityHandle, EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnRemoveEntity));
		}

		// Token: 0x0603C715 RID: 247573 RVA: 0x00E7E82F File Offset: 0x00E7CA2F
		[NullableContext(1)]
		private void OnRemoveEntity(ERemoveEntityType eRemoveEntityType, EntityHandle entityHandle)
		{
			this.OnRemove();
		}

		// Token: 0x0401F7EC RID: 129004
		private const float CLOSE_ANIM_TIME = 300f;

		// Token: 0x0401F7ED RID: 129005
		private const EBattleUiChild ChildType = EBattleUiChild.BattleHud;

		// Token: 0x0401F7EE RID: 129006
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private Dictionary<int, List<ULGUIPlayTweenComponent>> TweenAnimMap;

		// Token: 0x0401F7EF RID: 129007
		private EntityHandle EntityHandle;

		// Token: 0x0401F7F0 RID: 129008
		private ExecutionItem SkillItem;

		// Token: 0x0401F7F1 RID: 129009
		private TimerHandle CloseTimer;

		// Token: 0x0401F7F2 RID: 129010
		private CustomPromise Promise;

		// Token: 0x0401F7F3 RID: 129011
		private BattleUiChildViewData ChildViewData;

		// Token: 0x0401F7F4 RID: 129012
		private bool ChildVisible = true;

		// Token: 0x0401F7F5 RID: 129013
		private ECustomOptionType? OptionType = new ECustomOptionType?(ECustomOptionType.Execution);

		// Token: 0x0200BFA2 RID: 49058
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x04039D08 RID: 236808
			SkillItem,
			// Token: 0x04039D09 RID: 236809
			AnimStart,
			// Token: 0x04039D0A RID: 236810
			AnimClose
		}
	}
}

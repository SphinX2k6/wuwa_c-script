using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004A92 RID: 19090
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseBuildingDevelopBottomInfoItem : UiPanelBase
	{
		// Token: 0x060317B0 RID: 202672 RVA: 0x00B77F1C File Offset: 0x00B7611C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060317B1 RID: 202673 RVA: 0x00B77FE8 File Offset: 0x00B761E8
		protected override UniTask OnBeforeStartAsync()
		{
			TrapDefenseBuildingDevelopBottomInfoItem.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TrapDefenseBuildingDevelopBottomInfoItem.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060317B2 RID: 202674 RVA: 0x00B7802B File Offset: 0x00B7622B
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(base.GetExtendToggle(0).RootUIComp);
			this.BindEvent();
		}

		// Token: 0x060317B3 RID: 202675 RVA: 0x00B7804F File Offset: 0x00B7624F
		protected override void OnBeforeDestroy()
		{
			this.UnbindEvent();
		}

		// Token: 0x060317B4 RID: 202676 RVA: 0x00B78057 File Offset: 0x00B76257
		protected void BindEvent()
		{
			base.GetExtendToggle(0).CanExecuteChange.Bind(new Func<bool>(this.CanExecuteChange));
		}

		// Token: 0x060317B5 RID: 202677 RVA: 0x00B78076 File Offset: 0x00B76276
		protected void UnbindEvent()
		{
			base.GetExtendToggle(0).CanExecuteChange.Unbind();
		}

		// Token: 0x060317B6 RID: 202678 RVA: 0x00B7808C File Offset: 0x00B7628C
		public void Refresh(TrapDefenseBuildingSlotData data)
		{
			this.SlotData = data;
			TrapDefenseBuildingDevelopItemData slotData = data.GetSlotData();
			this.DragItem.Refresh(slotData);
			this.DragItem.SetUiActive(true);
			base.GetSprite(2).SetUIActive(slotData == null);
			bool uiactive = data.GetSlotData() != null && data.GetSlotData().GetLockInBattle();
			UUIItem item = base.GetItem(4);
			if (item != null)
			{
				item.SetUIActive(uiactive);
			}
			UUIItem item2 = base.GetItem(1);
			if (item2 != null)
			{
				item2.SetUIActive(false);
			}
			CommonDragItemLogic<TrapDefenseBuildingDevelopDragDataItem, TrapDefenseBuildingDevelopItemData> dragLogic = this.DragLogic;
			if (dragLogic == null)
			{
				return;
			}
			dragLogic.Refresh(slotData);
		}

		// Token: 0x060317B7 RID: 202679 RVA: 0x00B7811D File Offset: 0x00B7631D
		private bool CanExecuteChange()
		{
			return false;
		}

		// Token: 0x060317B8 RID: 202680 RVA: 0x00B78120 File Offset: 0x00B76320
		public void OnClickedItem()
		{
			if (this.OnClickCb != null)
			{
				this.OnClickCb(this.SlotData);
			}
		}

		// Token: 0x060317B9 RID: 202681 RVA: 0x00B7813C File Offset: 0x00B7633C
		public void SetSelected(bool isSelected)
		{
			EToggleState state = isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleStateForce(state, false, false, false);
		}

		// Token: 0x060317BA RID: 202682 RVA: 0x00B78166 File Offset: 0x00B76366
		public UUIDraggableComponent GetDragComp()
		{
			return this.DragItem.GetDraggableComp();
		}

		// Token: 0x060317BB RID: 202683 RVA: 0x00B78174 File Offset: 0x00B76374
		public void ResetPosition()
		{
			UUIItem item = base.GetItem(1);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			TrapDefenseBuildingSlotData slotData = this.SlotData;
			TrapDefenseBuildingDevelopItemData trapDefenseBuildingDevelopItemData = (slotData != null) ? slotData.GetSlotData() : null;
			bool uiactive = trapDefenseBuildingDevelopItemData != null && trapDefenseBuildingDevelopItemData.GetLockInBattle();
			base.GetItem(4).SetUIActive(uiactive);
			base.GetSprite(2).SetUIActive(this.SlotData.GetSlotData() == null);
			this.DragItem.OnEndDrag();
			if (this.IsOverlaying)
			{
				this.IsOverlaying = false;
				this.LevelSequencePlayer.StopPlayingSequence(false, true);
				this.LevelSequencePlayer.PlaySequencePurely("Normal", false, false, null, null, false);
			}
		}

		// Token: 0x060317BC RID: 202684 RVA: 0x00B78220 File Offset: 0x00B76420
		public void OnItemOverlay(int _)
		{
			this.LevelSequencePlayer.StopPlayingSequence(false, true);
			this.LevelSequencePlayer.PlayLevelSequenceByName("HighLight", false, null, false);
			this.IsOverlaying = true;
		}

		// Token: 0x060317BD RID: 202685 RVA: 0x00B7825C File Offset: 0x00B7645C
		public void OnItemUnOverlay(int _)
		{
			this.IsOverlaying = false;
			this.LevelSequencePlayer.StopPlayingSequence(false, true);
			this.LevelSequencePlayer.PlayLevelSequenceByName("Normal", false, null, false);
		}

		// Token: 0x060317BE RID: 202686 RVA: 0x00B78298 File Offset: 0x00B76498
		public void OnScrollToScrollViewEvent(int _)
		{
			UUIItem item = base.GetItem(1);
			if (item != null)
			{
				item.SetUIActive(true);
			}
			base.GetSprite(2).SetUIActive(false);
		}

		// Token: 0x060317BF RID: 202687 RVA: 0x00B782BA File Offset: 0x00B764BA
		public void OnRemoveFromScrollViewEvent(int _)
		{
			UUIItem item = base.GetItem(1);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			base.GetSprite(2).SetUIActive(true);
		}

		// Token: 0x060317C0 RID: 202688 RVA: 0x00B782DC File Offset: 0x00B764DC
		public void OnDragBegin(int _)
		{
			base.GetSprite(2).SetUIActive(true);
			base.GetItem(4).SetUIActive(false);
			this.DragItem.OnStartDrag();
		}

		// Token: 0x060317C1 RID: 202689 RVA: 0x00B78304 File Offset: 0x00B76504
		public void OnDragEnd(int _)
		{
			TrapDefenseBuildingDevelopItemData slotData = this.SlotData.GetSlotData();
			this.DragItem.OnEndDrag();
			base.GetSprite(2).SetUIActive(slotData == null);
		}

		// Token: 0x060317C2 RID: 202690 RVA: 0x00B78338 File Offset: 0x00B76538
		public void SetDragLogic(CommonDragItemLogic<TrapDefenseBuildingDevelopDragDataItem, TrapDefenseBuildingDevelopItemData> logic)
		{
			this.DragLogic = logic;
			CommonDragItemLogic<TrapDefenseBuildingDevelopDragDataItem, TrapDefenseBuildingDevelopItemData> dragLogic = this.DragLogic;
			TrapDefenseBuildingSlotData slotData = this.SlotData;
			dragLogic.Refresh((slotData != null) ? slotData.GetSlotData() : null);
		}

		// Token: 0x0401A745 RID: 108357
		protected TrapDefenseBuildingDevelopBottomDragItem DragItem;

		// Token: 0x0401A746 RID: 108358
		protected TrapDefenseBuildingSlotData SlotData;

		// Token: 0x0401A747 RID: 108359
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401A748 RID: 108360
		public Action<TrapDefenseBuildingSlotData> OnClickCb;

		// Token: 0x0401A749 RID: 108361
		public Func<TrapDefenseBuildingSlotData, bool> CanExecuteChangeCb;

		// Token: 0x0401A74A RID: 108362
		private bool IsOverlaying;

		// Token: 0x0401A74B RID: 108363
		protected CommonDragItemLogic<TrapDefenseBuildingDevelopDragDataItem, TrapDefenseBuildingDevelopItemData> DragLogic;

		// Token: 0x0200ABE4 RID: 44004
		[NullableContext(0)]
		private class EDefine
		{
			// Token: 0x040343C4 RID: 213956
			public const int Toggle = 0;

			// Token: 0x040343C5 RID: 213957
			public const int PanelMove = 1;

			// Token: 0x040343C6 RID: 213958
			public const int SpriteEmpty = 2;

			// Token: 0x040343C7 RID: 213959
			public const int DragItem = 3;

			// Token: 0x040343C8 RID: 213960
			public const int PanelLockState = 4;
		}
	}
}

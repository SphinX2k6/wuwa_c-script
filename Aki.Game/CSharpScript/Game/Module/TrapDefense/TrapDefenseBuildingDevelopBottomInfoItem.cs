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
	// Token: 0x02003A3A RID: 14906
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseBuildingDevelopBottomInfoItem : UiPanelBase
	{
		// Token: 0x06026540 RID: 156992 RVA: 0x00ABBED0 File Offset: 0x00ABA0D0
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

		// Token: 0x06026541 RID: 156993 RVA: 0x00ABBF9C File Offset: 0x00ABA19C
		protected override UniTask OnBeforeStartAsync()
		{
			TrapDefenseBuildingDevelopBottomInfoItem.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TrapDefenseBuildingDevelopBottomInfoItem.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06026542 RID: 156994 RVA: 0x00ABBFDF File Offset: 0x00ABA1DF
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(base.GetExtendToggle(0).RootUIComp);
			this.BindEvent();
		}

		// Token: 0x06026543 RID: 156995 RVA: 0x00ABC003 File Offset: 0x00ABA203
		protected override void OnBeforeDestroy()
		{
			this.UnbindEvent();
		}

		// Token: 0x06026544 RID: 156996 RVA: 0x00ABC00B File Offset: 0x00ABA20B
		protected void BindEvent()
		{
			base.GetExtendToggle(0).CanExecuteChange.Bind(new Func<bool>(this.CanExecuteChange));
		}

		// Token: 0x06026545 RID: 156997 RVA: 0x00ABC02A File Offset: 0x00ABA22A
		protected void UnbindEvent()
		{
			base.GetExtendToggle(0).CanExecuteChange.Unbind();
		}

		// Token: 0x06026546 RID: 156998 RVA: 0x00ABC040 File Offset: 0x00ABA240
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

		// Token: 0x06026547 RID: 156999 RVA: 0x00ABC0D1 File Offset: 0x00ABA2D1
		private bool CanExecuteChange()
		{
			return false;
		}

		// Token: 0x06026548 RID: 157000 RVA: 0x00ABC0D4 File Offset: 0x00ABA2D4
		public void OnClickedItem()
		{
			if (this.OnClickCb != null)
			{
				this.OnClickCb(this.SlotData);
			}
		}

		// Token: 0x06026549 RID: 157001 RVA: 0x00ABC0F0 File Offset: 0x00ABA2F0
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

		// Token: 0x0602654A RID: 157002 RVA: 0x00ABC11A File Offset: 0x00ABA31A
		public UUIDraggableComponent GetDragComp()
		{
			return this.DragItem.GetDraggableComp();
		}

		// Token: 0x0602654B RID: 157003 RVA: 0x00ABC128 File Offset: 0x00ABA328
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

		// Token: 0x0602654C RID: 157004 RVA: 0x00ABC1D4 File Offset: 0x00ABA3D4
		public void OnItemOverlay(int _)
		{
			this.LevelSequencePlayer.StopPlayingSequence(false, true);
			this.LevelSequencePlayer.PlayLevelSequenceByName("HighLight", false, null, false);
			this.IsOverlaying = true;
		}

		// Token: 0x0602654D RID: 157005 RVA: 0x00ABC210 File Offset: 0x00ABA410
		public void OnItemUnOverlay(int _)
		{
			this.IsOverlaying = false;
			this.LevelSequencePlayer.StopPlayingSequence(false, true);
			this.LevelSequencePlayer.PlayLevelSequenceByName("Normal", false, null, false);
		}

		// Token: 0x0602654E RID: 157006 RVA: 0x00ABC24C File Offset: 0x00ABA44C
		public void OnScrollToScrollViewEvent(int _)
		{
			UUIItem item = base.GetItem(1);
			if (item != null)
			{
				item.SetUIActive(true);
			}
			base.GetSprite(2).SetUIActive(false);
		}

		// Token: 0x0602654F RID: 157007 RVA: 0x00ABC26E File Offset: 0x00ABA46E
		public void OnRemoveFromScrollViewEvent(int _)
		{
			UUIItem item = base.GetItem(1);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			base.GetSprite(2).SetUIActive(true);
		}

		// Token: 0x06026550 RID: 157008 RVA: 0x00ABC290 File Offset: 0x00ABA490
		public void OnDragBegin(int _)
		{
			base.GetSprite(2).SetUIActive(true);
			base.GetItem(4).SetUIActive(false);
			this.DragItem.OnStartDrag();
		}

		// Token: 0x06026551 RID: 157009 RVA: 0x00ABC2B8 File Offset: 0x00ABA4B8
		public void OnDragEnd(int _)
		{
			TrapDefenseBuildingDevelopItemData slotData = this.SlotData.GetSlotData();
			this.DragItem.OnEndDrag();
			base.GetSprite(2).SetUIActive(slotData == null);
		}

		// Token: 0x06026552 RID: 157010 RVA: 0x00ABC2EC File Offset: 0x00ABA4EC
		public void SetDragLogic(CommonDragItemLogic<TrapDefenseBuildingDevelopDragDataItem, TrapDefenseBuildingDevelopItemData> logic)
		{
			this.DragLogic = logic;
			CommonDragItemLogic<TrapDefenseBuildingDevelopDragDataItem, TrapDefenseBuildingDevelopItemData> dragLogic = this.DragLogic;
			TrapDefenseBuildingSlotData slotData = this.SlotData;
			dragLogic.Refresh((slotData != null) ? slotData.GetSlotData() : null);
		}

		// Token: 0x04015097 RID: 86167
		protected TrapDefenseBuildingDevelopBottomDragItem DragItem;

		// Token: 0x04015098 RID: 86168
		protected TrapDefenseBuildingSlotData SlotData;

		// Token: 0x04015099 RID: 86169
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401509A RID: 86170
		public Action<TrapDefenseBuildingSlotData> OnClickCb;

		// Token: 0x0401509B RID: 86171
		public Func<TrapDefenseBuildingSlotData, bool> CanExecuteChangeCb;

		// Token: 0x0401509C RID: 86172
		private bool IsOverlaying;

		// Token: 0x0401509D RID: 86173
		protected CommonDragItemLogic<TrapDefenseBuildingDevelopDragDataItem, TrapDefenseBuildingDevelopItemData> DragLogic;

		// Token: 0x02009604 RID: 38404
		[NullableContext(0)]
		private class EDefine
		{
			// Token: 0x0402ED75 RID: 191861
			public const int Toggle = 0;

			// Token: 0x0402ED76 RID: 191862
			public const int PanelMove = 1;

			// Token: 0x0402ED77 RID: 191863
			public const int SpriteEmpty = 2;

			// Token: 0x0402ED78 RID: 191864
			public const int DragItem = 3;

			// Token: 0x0402ED79 RID: 191865
			public const int PanelLockState = 4;
		}
	}
}

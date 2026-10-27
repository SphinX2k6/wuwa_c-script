using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004DBA RID: 19898
	[NullableContext(2)]
	[Nullable(0)]
	public class RoguelikeAchieveView : UiViewBase
	{
		// Token: 0x060335EF RID: 210415 RVA: 0x00BFEB4D File Offset: 0x00BFCD4D
		[NullableContext(1)]
		public RoguelikeAchieveView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x060335F0 RID: 210416 RVA: 0x00BFEB58 File Offset: 0x00BFCD58
		protected unsafe override void OnRegisterComponent()
		{
			int num = 11;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060335F1 RID: 210417 RVA: 0x00BFECF0 File Offset: 0x00BFCEF0
		protected override UniTask OnBeforeStartAsync()
		{
			RoguelikeAchieveView.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoguelikeAchieveView.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060335F2 RID: 210418 RVA: 0x00BFED33 File Offset: 0x00BFCF33
		protected override void OnStart()
		{
			this.RefreshByViewModel();
		}

		// Token: 0x060335F3 RID: 210419 RVA: 0x00BFED3B File Offset: 0x00BFCF3B
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int>(EEventName.RoguelikeArchiveSaved, new Action<int>(this.OnArchiveSaved));
		}

		// Token: 0x060335F4 RID: 210420 RVA: 0x00BFED59 File Offset: 0x00BFCF59
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<int>(EEventName.RoguelikeArchiveSaved, new Action<int>(this.OnArchiveSaved));
		}

		// Token: 0x060335F5 RID: 210421 RVA: 0x00BFED77 File Offset: 0x00BFCF77
		protected override void OnBeforeShow()
		{
			this.RefreshByViewModel();
		}

		// Token: 0x060335F6 RID: 210422 RVA: 0x00BFED80 File Offset: 0x00BFCF80
		private void OnBtnRecordSaveClick(int _)
		{
			RoguelikeAchieveSlotData selectedSlotData = this.Vm.SelectedSlotData;
			if (!this.Vm.IsArchiveMode || selectedSlotData == null)
			{
				return;
			}
			RoguelikeController.Instance.RoguelikeAchieveSaveRecordRequest(selectedSlotData.SlotIndex).ContinueWith(delegate(bool isSuccess)
			{
				if (!isSuccess)
				{
					return;
				}
				ScrollingTipsController.Instance.ShowTipsByTextId("Rogue_HintText_SaveRecord", Array.Empty<object>());
			});
		}

		// Token: 0x060335F7 RID: 210423 RVA: 0x00BFEDE0 File Offset: 0x00BFCFE0
		private void OnBtnOverwriteRecordSaveClick(int _)
		{
			RoguelikeAchieveView.<>c__DisplayClass19_0 CS$<>8__locals1 = new RoguelikeAchieveView.<>c__DisplayClass19_0();
			CS$<>8__locals1.selectedSlot = this.Vm.SelectedSlotData;
			if (!this.Vm.IsArchiveMode || CS$<>8__locals1.selectedSlot == null)
			{
				return;
			}
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.RoguelikeOverwriteArchiveConfirm);
			confirmBoxDataNew.FunctionMap[2] = new Action(CS$<>8__locals1.<OnBtnOverwriteRecordSaveClick>g__overwrite|0);
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}

		// Token: 0x060335F8 RID: 210424 RVA: 0x00BFEE4C File Offset: 0x00BFD04C
		private void OnBtnConfirmLeaveClick(int _)
		{
			RoguelikeModel instance = RoguelikeModel.Instance;
			if (instance != null && instance.CheckInRoguelike())
			{
				InstanceDungeonEntranceController.Instance.LeaveInstanceDungeon().ContinueWith(delegate(bool _)
				{
					if (UiManager.Instance.IsViewShow(this.ViewInfo.Name))
					{
						base.CloseMe(null);
					}
				});
				return;
			}
			if (UiManager.Instance.GetViewByName(EUiViewName.RoguelikeSettleView) != null)
			{
				UiManager.Instance.CloseView(EUiViewName.RoguelikeSettleView, null);
			}
			base.CloseMe(null);
		}

		// Token: 0x060335F9 RID: 210425 RVA: 0x00BFEEB1 File Offset: 0x00BFD0B1
		private void OnArchiveSaved(int slotId)
		{
			this.Vm.TempArchiveSaved(slotId);
			this.RefreshByViewModel();
			this.RefreshSelectedRoguelikeInfo();
		}

		// Token: 0x060335FA RID: 210426 RVA: 0x00BFEECC File Offset: 0x00BFD0CC
		private void RefreshViewModel()
		{
			RoguelikeAchieveViewModel roguelikeAchieveViewModel = this.OpenParam as RoguelikeAchieveViewModel;
			if (roguelikeAchieveViewModel == null)
			{
				return;
			}
			this.Vm = roguelikeAchieveViewModel;
		}

		// Token: 0x060335FB RID: 210427 RVA: 0x00BFEEF0 File Offset: 0x00BFD0F0
		private void RefreshByViewModel()
		{
			RoguelikeAchieveLeftItem leftPanel = this.LeftPanel;
			if (leftPanel != null)
			{
				leftPanel.RefreshByViewModel();
			}
			this.RefreshModeState();
		}

		// Token: 0x060335FC RID: 210428 RVA: 0x00BFEF0C File Offset: 0x00BFD10C
		private void RefreshSelectedRoguelikeInfo()
		{
			RogueArchiveInfoData selectedArchiveInfoData = this.Vm.SelectedArchiveInfoData;
			bool isTempRecordSelected = this.Vm.IsTempRecordSelected;
			RoguelikeAchieveTotalPanel totalPanel = this.TotalPanel;
			if (totalPanel != null)
			{
				totalPanel.Refresh(selectedArchiveInfoData);
			}
			RoguelikeAchieveTokenPanel tokenPanel = this.TokenPanel;
			if (tokenPanel != null)
			{
				tokenPanel.Refresh(selectedArchiveInfoData);
			}
			RoguelikeAchieveSpecialPanel specialPanel = this.SpecialPanel;
			if (specialPanel != null)
			{
				specialPanel.Refresh(selectedArchiveInfoData);
			}
			RoguelikeAchieveEntryPanel entryPanel = this.EntryPanel;
			if (entryPanel != null)
			{
				entryPanel.Refresh(selectedArchiveInfoData, isTempRecordSelected);
			}
			this.RefreshModeState();
		}

		// Token: 0x060335FD RID: 210429 RVA: 0x00BFEF80 File Offset: 0x00BFD180
		private void RefreshModeState()
		{
			bool isArchiveMode = this.Vm.IsArchiveMode;
			bool isTempRecordSelected = this.Vm.IsTempRecordSelected;
			RoguelikeAchieveSlotData selectedSlotData = this.Vm.SelectedSlotData;
			bool flag;
			if (isArchiveMode && !isTempRecordSelected)
			{
				if (selectedSlotData == null)
				{
					flag = true;
				}
				else
				{
					RogueArchiveInfoData archiveInfoData = selectedSlotData.ArchiveInfoData;
					flag = !((archiveInfoData != null) ? new bool?(archiveInfoData.HasData) : null).GetValueOrDefault();
				}
			}
			else
			{
				flag = false;
			}
			bool uiactive = flag;
			bool flag2;
			if (isArchiveMode && !isTempRecordSelected)
			{
				if (selectedSlotData == null)
				{
					flag2 = false;
				}
				else
				{
					RogueArchiveInfoData archiveInfoData2 = selectedSlotData.ArchiveInfoData;
					flag2 = ((archiveInfoData2 != null) ? new bool?(archiveInfoData2.HasData) : null).GetValueOrDefault();
				}
			}
			else
			{
				flag2 = false;
			}
			bool uiactive2 = flag2;
			bool isTempRecordSaved = this.Vm.IsTempRecordSaved;
			bool flag3 = isArchiveMode && !isTempRecordSaved;
			string textId = flag3 ? "Rogue_Record_CanSave" : "Rogue_Record_Saved";
			UUIItem item = base.GetItem(2);
			if (item != null)
			{
				item.SetUIActive(uiactive);
			}
			UUIItem item2 = base.GetItem(9);
			if (item2 != null)
			{
				item2.SetUIActive(uiactive2);
			}
			ButtonItem btnConfirmLeaveItem = this.BtnConfirmLeaveItem;
			if (btnConfirmLeaveItem != null)
			{
				btnConfirmLeaveItem.SetUiActive(isArchiveMode && isTempRecordSaved);
			}
			ButtonItem btnRecordSaveItem = this.BtnRecordSaveItem;
			if (btnRecordSaveItem != null)
			{
				btnRecordSaveItem.SetUiActive(isArchiveMode);
			}
			ButtonItem btnRecordSaveItem2 = this.BtnRecordSaveItem;
			if (btnRecordSaveItem2 != null)
			{
				btnRecordSaveItem2.SetEnableClick(flag3);
			}
			ButtonItem btnRecordSaveItem3 = this.BtnRecordSaveItem;
			if (btnRecordSaveItem3 != null)
			{
				btnRecordSaveItem3.SetLocalTextNew(textId, Array.Empty<object>());
			}
			ButtonItem btnConfirmSaveItem = this.BtnConfirmSaveItem;
			if (btnConfirmSaveItem != null)
			{
				btnConfirmSaveItem.SetUiActive(isArchiveMode);
			}
			ButtonItem btnConfirmSaveItem2 = this.BtnConfirmSaveItem;
			if (btnConfirmSaveItem2 != null)
			{
				btnConfirmSaveItem2.SetEnableClick(flag3);
			}
			ButtonItem btnConfirmSaveItem3 = this.BtnConfirmSaveItem;
			if (btnConfirmSaveItem3 == null)
			{
				return;
			}
			btnConfirmSaveItem3.SetLocalTextNew(textId, Array.Empty<object>());
		}

		// Token: 0x0401B47F RID: 111743
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401B480 RID: 111744
		private RoguelikeAchieveLeftItem LeftPanel;

		// Token: 0x0401B481 RID: 111745
		private ButtonItem BtnRecordSaveItem;

		// Token: 0x0401B482 RID: 111746
		private RoguelikeAchieveTotalPanel TotalPanel;

		// Token: 0x0401B483 RID: 111747
		private RoguelikeAchieveTokenPanel TokenPanel;

		// Token: 0x0401B484 RID: 111748
		private RoguelikeAchieveSpecialPanel SpecialPanel;

		// Token: 0x0401B485 RID: 111749
		private ButtonItem BtnConfirmLeaveItem;

		// Token: 0x0401B486 RID: 111750
		private ButtonItem BtnConfirmSaveItem;

		// Token: 0x0401B487 RID: 111751
		private RoguelikeAchieveEntryPanel EntryPanel;

		// Token: 0x0401B488 RID: 111752
		[Nullable(1)]
		private RoguelikeAchieveViewModel Vm;

		// Token: 0x0200AF31 RID: 44849
		[NullableContext(0)]
		private class ERoguelikeAchieveViewComponents
		{
			// Token: 0x04035339 RID: 217913
			public const int CaptionItem = 0;

			// Token: 0x0403533A RID: 217914
			public const int LeftItem = 1;

			// Token: 0x0403533B RID: 217915
			public const int PnlEmpty = 2;

			// Token: 0x0403533C RID: 217916
			public const int BtnRecordSave = 3;

			// Token: 0x0403533D RID: 217917
			public const int TotalPanel = 4;

			// Token: 0x0403533E RID: 217918
			public const int TokenPanel = 5;

			// Token: 0x0403533F RID: 217919
			public const int SpecialPanel = 6;

			// Token: 0x04035340 RID: 217920
			public const int BtnConfirmLeave = 7;

			// Token: 0x04035341 RID: 217921
			public const int BtnConfirmSave = 8;

			// Token: 0x04035342 RID: 217922
			public const int PnlBottomBtn = 9;

			// Token: 0x04035343 RID: 217923
			public const int EntryPanel = 10;
		}
	}
}

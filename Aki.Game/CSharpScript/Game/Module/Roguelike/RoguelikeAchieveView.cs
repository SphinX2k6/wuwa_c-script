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
	// Token: 0x02003D83 RID: 15747
	[NullableContext(2)]
	[Nullable(0)]
	public class RoguelikeAchieveView : UiViewBase
	{
		// Token: 0x0602845C RID: 164956 RVA: 0x00B4808D File Offset: 0x00B4628D
		[NullableContext(1)]
		public RoguelikeAchieveView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0602845D RID: 164957 RVA: 0x00B48098 File Offset: 0x00B46298
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

		// Token: 0x0602845E RID: 164958 RVA: 0x00B48230 File Offset: 0x00B46430
		protected override UniTask OnBeforeStartAsync()
		{
			RoguelikeAchieveView.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoguelikeAchieveView.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602845F RID: 164959 RVA: 0x00B48273 File Offset: 0x00B46473
		protected override void OnStart()
		{
			this.RefreshByViewModel();
		}

		// Token: 0x06028460 RID: 164960 RVA: 0x00B4827B File Offset: 0x00B4647B
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int>(EEventName.RoguelikeArchiveSaved, new Action<int>(this.OnArchiveSaved));
		}

		// Token: 0x06028461 RID: 164961 RVA: 0x00B48299 File Offset: 0x00B46499
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<int>(EEventName.RoguelikeArchiveSaved, new Action<int>(this.OnArchiveSaved));
		}

		// Token: 0x06028462 RID: 164962 RVA: 0x00B482B7 File Offset: 0x00B464B7
		protected override void OnBeforeShow()
		{
			this.RefreshByViewModel();
		}

		// Token: 0x06028463 RID: 164963 RVA: 0x00B482C0 File Offset: 0x00B464C0
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

		// Token: 0x06028464 RID: 164964 RVA: 0x00B48320 File Offset: 0x00B46520
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

		// Token: 0x06028465 RID: 164965 RVA: 0x00B4838C File Offset: 0x00B4658C
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

		// Token: 0x06028466 RID: 164966 RVA: 0x00B483F1 File Offset: 0x00B465F1
		private void OnArchiveSaved(int slotId)
		{
			this.Vm.TempArchiveSaved(slotId);
			this.RefreshByViewModel();
			this.RefreshSelectedRoguelikeInfo();
		}

		// Token: 0x06028467 RID: 164967 RVA: 0x00B4840C File Offset: 0x00B4660C
		private void RefreshViewModel()
		{
			RoguelikeAchieveViewModel roguelikeAchieveViewModel = this.OpenParam as RoguelikeAchieveViewModel;
			if (roguelikeAchieveViewModel == null)
			{
				return;
			}
			this.Vm = roguelikeAchieveViewModel;
		}

		// Token: 0x06028468 RID: 164968 RVA: 0x00B48430 File Offset: 0x00B46630
		private void RefreshByViewModel()
		{
			RoguelikeAchieveLeftItem leftPanel = this.LeftPanel;
			if (leftPanel != null)
			{
				leftPanel.RefreshByViewModel();
			}
			this.RefreshModeState();
		}

		// Token: 0x06028469 RID: 164969 RVA: 0x00B4844C File Offset: 0x00B4664C
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

		// Token: 0x0602846A RID: 164970 RVA: 0x00B484C0 File Offset: 0x00B466C0
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

		// Token: 0x04015E52 RID: 89682
		private PopupCaptionItem CaptionItem;

		// Token: 0x04015E53 RID: 89683
		private RoguelikeAchieveLeftItem LeftPanel;

		// Token: 0x04015E54 RID: 89684
		private ButtonItem BtnRecordSaveItem;

		// Token: 0x04015E55 RID: 89685
		private RoguelikeAchieveTotalPanel TotalPanel;

		// Token: 0x04015E56 RID: 89686
		private RoguelikeAchieveTokenPanel TokenPanel;

		// Token: 0x04015E57 RID: 89687
		private RoguelikeAchieveSpecialPanel SpecialPanel;

		// Token: 0x04015E58 RID: 89688
		private ButtonItem BtnConfirmLeaveItem;

		// Token: 0x04015E59 RID: 89689
		private ButtonItem BtnConfirmSaveItem;

		// Token: 0x04015E5A RID: 89690
		private RoguelikeAchieveEntryPanel EntryPanel;

		// Token: 0x04015E5B RID: 89691
		[Nullable(1)]
		private RoguelikeAchieveViewModel Vm;

		// Token: 0x02009966 RID: 39270
		[NullableContext(0)]
		private class ERoguelikeAchieveViewComponents
		{
			// Token: 0x0402FD6E RID: 195950
			public const int CaptionItem = 0;

			// Token: 0x0402FD6F RID: 195951
			public const int LeftItem = 1;

			// Token: 0x0402FD70 RID: 195952
			public const int PnlEmpty = 2;

			// Token: 0x0402FD71 RID: 195953
			public const int BtnRecordSave = 3;

			// Token: 0x0402FD72 RID: 195954
			public const int TotalPanel = 4;

			// Token: 0x0402FD73 RID: 195955
			public const int TokenPanel = 5;

			// Token: 0x0402FD74 RID: 195956
			public const int SpecialPanel = 6;

			// Token: 0x0402FD75 RID: 195957
			public const int BtnConfirmLeave = 7;

			// Token: 0x0402FD76 RID: 195958
			public const int BtnConfirmSave = 8;

			// Token: 0x0402FD77 RID: 195959
			public const int PnlBottomBtn = 9;

			// Token: 0x0402FD78 RID: 195960
			public const int EntryPanel = 10;
		}
	}
}

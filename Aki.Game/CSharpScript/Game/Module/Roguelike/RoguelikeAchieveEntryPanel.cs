using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004DAF RID: 19887
	[NullableContext(2)]
	[Nullable(0)]
	public class RoguelikeAchieveEntryPanel : UiPanelBase
	{
		// Token: 0x0603358A RID: 210314 RVA: 0x00BFCD5C File Offset: 0x00BFAF5C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603358B RID: 210315 RVA: 0x00BFCDC5 File Offset: 0x00BFAFC5
		protected override void OnStart()
		{
			this.StartButton = new ButtonItem(base.GetItem(1));
			this.StartButton.SetFunction(new Action<int>(this.OnBtnStartInstanceClick));
		}

		// Token: 0x0603358C RID: 210316 RVA: 0x00BFCDF0 File Offset: 0x00BFAFF0
		protected override void OnBeforeDestroy()
		{
			this.StartButton = null;
			this.Vm = null;
			this.CurrentArchiveInfoData = null;
		}

		// Token: 0x0603358D RID: 210317 RVA: 0x00BFCE07 File Offset: 0x00BFB007
		[NullableContext(1)]
		public void SetViewModel(RoguelikeAchieveViewModel vm)
		{
			this.Vm = vm;
		}

		// Token: 0x0603358E RID: 210318 RVA: 0x00BFCE10 File Offset: 0x00BFB010
		public void Refresh(RogueArchiveInfoData archiveInfoData, bool isTempRecord)
		{
			this.CurrentArchiveInfoData = archiveInfoData;
			RoguelikeAchieveViewModel vm = this.Vm;
			bool flag = vm != null && vm.IsUseArchiveMode && archiveInfoData != null && !isTempRecord;
			base.SetUiActive(flag);
			if (!flag)
			{
				return;
			}
			this.RefreshEntryName();
		}

		// Token: 0x0603358F RID: 210319 RVA: 0x00BFCE54 File Offset: 0x00BFB054
		private void OnBtnStartInstanceClick(int _)
		{
			if (this.CurrentArchiveInfoData == null || this.Vm == null)
			{
				return;
			}
			RoguelikeController.Instance.RoguelikeBossChallengeStartRequest(this.Vm.InstId, this.CurrentArchiveInfoData.SlotId, null);
		}

		// Token: 0x06033590 RID: 210320 RVA: 0x00BFCE88 File Offset: 0x00BFB088
		private void RefreshEntryName()
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "Rogue_Record_Name", new <>z__ReadOnlySingleElementList<object>(this.CurrentArchiveInfoData.ShowIndex.ToString().PadLeft(2, '0')));
		}

		// Token: 0x0401B468 RID: 111720
		private ButtonItem StartButton;

		// Token: 0x0401B469 RID: 111721
		private RoguelikeAchieveViewModel Vm;

		// Token: 0x0401B46A RID: 111722
		private RogueArchiveInfoData CurrentArchiveInfoData;

		// Token: 0x0200AF24 RID: 44836
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x04035301 RID: 217857
			public const int EntryNameText = 0;

			// Token: 0x04035302 RID: 217858
			public const int StartBattleButton = 1;
		}
	}
}

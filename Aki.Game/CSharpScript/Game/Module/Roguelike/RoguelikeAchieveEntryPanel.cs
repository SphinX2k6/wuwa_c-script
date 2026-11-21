using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003D78 RID: 15736
	[NullableContext(2)]
	[Nullable(0)]
	public class RoguelikeAchieveEntryPanel : UiPanelBase
	{
		// Token: 0x060283F7 RID: 164855 RVA: 0x00B4628C File Offset: 0x00B4448C
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

		// Token: 0x060283F8 RID: 164856 RVA: 0x00B462F5 File Offset: 0x00B444F5
		protected override void OnStart()
		{
			this.StartButton = new ButtonItem(base.GetItem(1));
			this.StartButton.SetFunction(new Action<int>(this.OnBtnStartInstanceClick));
		}

		// Token: 0x060283F9 RID: 164857 RVA: 0x00B46320 File Offset: 0x00B44520
		protected override void OnBeforeDestroy()
		{
			this.StartButton = null;
			this.Vm = null;
			this.CurrentArchiveInfoData = null;
		}

		// Token: 0x060283FA RID: 164858 RVA: 0x00B46337 File Offset: 0x00B44537
		[NullableContext(1)]
		public void SetViewModel(RoguelikeAchieveViewModel vm)
		{
			this.Vm = vm;
		}

		// Token: 0x060283FB RID: 164859 RVA: 0x00B46340 File Offset: 0x00B44540
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

		// Token: 0x060283FC RID: 164860 RVA: 0x00B46384 File Offset: 0x00B44584
		private void OnBtnStartInstanceClick(int _)
		{
			if (this.CurrentArchiveInfoData == null || this.Vm == null)
			{
				return;
			}
			RoguelikeController.Instance.RoguelikeBossChallengeStartRequest(this.Vm.InstId, this.CurrentArchiveInfoData.SlotId, null);
		}

		// Token: 0x060283FD RID: 164861 RVA: 0x00B463B8 File Offset: 0x00B445B8
		private void RefreshEntryName()
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "Rogue_Record_Name", new <>z__ReadOnlySingleElementList<object>(this.CurrentArchiveInfoData.ShowIndex.ToString().PadLeft(2, '0')));
		}

		// Token: 0x04015E3B RID: 89659
		private ButtonItem StartButton;

		// Token: 0x04015E3C RID: 89660
		private RoguelikeAchieveViewModel Vm;

		// Token: 0x04015E3D RID: 89661
		private RogueArchiveInfoData CurrentArchiveInfoData;

		// Token: 0x02009959 RID: 39257
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0402FD36 RID: 195894
			public const int EntryNameText = 0;

			// Token: 0x0402FD37 RID: 195895
			public const int StartBattleButton = 1;
		}
	}
}

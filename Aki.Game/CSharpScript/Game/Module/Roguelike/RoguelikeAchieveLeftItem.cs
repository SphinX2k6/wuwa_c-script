using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003D79 RID: 15737
	[NullableContext(1)]
	[Nullable(0)]
	public class RoguelikeAchieveLeftItem : UiPanelBase
	{
		// Token: 0x060283FF RID: 164863 RVA: 0x00B46404 File Offset: 0x00B44604
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06028400 RID: 164864 RVA: 0x00B464B0 File Offset: 0x00B446B0
		protected override UniTask OnBeforeStartAsync()
		{
			RoguelikeAchieveLeftItem.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoguelikeAchieveLeftItem.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06028401 RID: 164865 RVA: 0x00B464F3 File Offset: 0x00B446F3
		protected override void OnStart()
		{
			this.RefreshByViewModel();
		}

		// Token: 0x06028402 RID: 164866 RVA: 0x00B464FB File Offset: 0x00B446FB
		protected override void OnBeforeDestroy()
		{
			this.TogTempRecordPanel = null;
			this.RecordItemScroll = null;
			this.Vm = null;
			this.OnSelectedRoguelikeInfoChanged = null;
		}

		// Token: 0x06028403 RID: 164867 RVA: 0x00B46519 File Offset: 0x00B44719
		public void SetViewModel(RoguelikeAchieveViewModel vm)
		{
			this.Vm = vm;
		}

		// Token: 0x06028404 RID: 164868 RVA: 0x00B46522 File Offset: 0x00B44722
		public void BindOnSelectedRoguelikeInfoChanged(Action callback)
		{
			this.OnSelectedRoguelikeInfoChanged = callback;
		}

		// Token: 0x06028405 RID: 164869 RVA: 0x00B4652C File Offset: 0x00B4472C
		public void RefreshByViewModel()
		{
			this.RefreshStateIcon();
			this.RefreshRoleRecordList();
			RoguelikeAchieveViewModel vm = this.Vm;
			if (vm == null || !vm.ShouldShowTempRecord)
			{
				this.Vm.IsTempRecordSelected = false;
				RoguelikeAchieveTogTempRecordItem togTempRecordPanel = this.TogTempRecordPanel;
				if (togTempRecordPanel == null)
				{
					return;
				}
				togTempRecordPanel.Refresh(null, false);
				return;
			}
			else
			{
				RoguelikeAchieveTogTempRecordItem togTempRecordPanel2 = this.TogTempRecordPanel;
				if (togTempRecordPanel2 == null)
				{
					return;
				}
				togTempRecordPanel2.Refresh(this.Vm.TempRecordInfo, this.Vm.IsTempRecordSaved);
				return;
			}
		}

		// Token: 0x06028406 RID: 164870 RVA: 0x00B465A1 File Offset: 0x00B447A1
		private RoguelikeAchieveTogRoleRecordItem CreateRoleRecordItem()
		{
			RoguelikeAchieveTogRoleRecordItem roguelikeAchieveTogRoleRecordItem = new RoguelikeAchieveTogRoleRecordItem();
			roguelikeAchieveTogRoleRecordItem.BindOnToggleStateChanged(new Action<RoguelikeAchieveSlotData, int, EToggleState>(this.OnRoleRecordToggleStateChanged));
			return roguelikeAchieveTogRoleRecordItem;
		}

		// Token: 0x06028407 RID: 164871 RVA: 0x00B465BC File Offset: 0x00B447BC
		private void RefreshRoleRecordList()
		{
			List<RoguelikeAchieveSlotData> roleRecordDataList = this.GetRoleRecordDataList();
			if (this.Vm.SelectedRecordGridIndex >= roleRecordDataList.Count)
			{
				this.Vm.SelectedRecordGridIndex = -1;
			}
			if (!this.Vm.IsTempRecordSelected && this.Vm.SelectedRecordGridIndex < 0)
			{
				this.Vm.SelectedRecordGridIndex = this.GetDefaultSelectedRecordGridIndex(roleRecordDataList);
			}
			GenericScrollViewNew<RoguelikeAchieveTogRoleRecordItem, RoguelikeAchieveSlotData> recordItemScroll = this.RecordItemScroll;
			if (recordItemScroll == null)
			{
				return;
			}
			recordItemScroll.RefreshByData(roleRecordDataList, new Action(this.RefreshSelectedRecord), true);
		}

		// Token: 0x06028408 RID: 164872 RVA: 0x00B4663C File Offset: 0x00B4483C
		private void RefreshSelectedRecord()
		{
			if (this.Vm.IsTempRecordSelected || this.Vm.SelectedRecordGridIndex < 0)
			{
				GenericScrollViewNew<RoguelikeAchieveTogRoleRecordItem, RoguelikeAchieveSlotData> recordItemScroll = this.RecordItemScroll;
				if (recordItemScroll != null)
				{
					GenericLayout<RoguelikeAchieveTogRoleRecordItem, RoguelikeAchieveSlotData> genericLayout = recordItemScroll.GetGenericLayout();
					if (genericLayout != null)
					{
						genericLayout.DeselectCurrentGridProxy();
					}
				}
				if (this.Vm.SelectedRecordGridIndex < 0)
				{
					Action onSelectedRoguelikeInfoChanged = this.OnSelectedRoguelikeInfoChanged;
					if (onSelectedRoguelikeInfoChanged == null)
					{
						return;
					}
					onSelectedRoguelikeInfoChanged();
				}
				return;
			}
			GenericScrollViewNew<RoguelikeAchieveTogRoleRecordItem, RoguelikeAchieveSlotData> recordItemScroll2 = this.RecordItemScroll;
			if (recordItemScroll2 == null)
			{
				return;
			}
			recordItemScroll2.SelectGridProxy(this.Vm.SelectedRecordGridIndex, true);
		}

		// Token: 0x06028409 RID: 164873 RVA: 0x00B466BC File Offset: 0x00B448BC
		private void OnTempRecordToggleStateChanged(EToggleState state)
		{
			if (state != EToggleState.ETT_Checked)
			{
				if (this.Vm.SelectedRecordGridIndex < 0)
				{
					RoguelikeAchieveTogTempRecordItem togTempRecordPanel = this.TogTempRecordPanel;
					if (togTempRecordPanel == null)
					{
						return;
					}
					togTempRecordPanel.SetToggleState(true, false);
				}
				return;
			}
			this.Vm.IsTempRecordSelected = true;
			this.Vm.SelectedRecordGridIndex = -1;
			GenericScrollViewNew<RoguelikeAchieveTogRoleRecordItem, RoguelikeAchieveSlotData> recordItemScroll = this.RecordItemScroll;
			if (recordItemScroll != null)
			{
				GenericLayout<RoguelikeAchieveTogRoleRecordItem, RoguelikeAchieveSlotData> genericLayout = recordItemScroll.GetGenericLayout();
				if (genericLayout != null)
				{
					genericLayout.DeselectCurrentGridProxy();
				}
			}
			Action onSelectedRoguelikeInfoChanged = this.OnSelectedRoguelikeInfoChanged;
			if (onSelectedRoguelikeInfoChanged == null)
			{
				return;
			}
			onSelectedRoguelikeInfoChanged();
		}

		// Token: 0x0602840A RID: 164874 RVA: 0x00B46734 File Offset: 0x00B44934
		private void OnRoleRecordToggleStateChanged(RoguelikeAchieveSlotData slotData, int gridIndex, EToggleState state)
		{
			if (state != EToggleState.ETT_Checked)
			{
				if (!this.Vm.IsTempRecordSelected)
				{
					GenericScrollViewNew<RoguelikeAchieveTogRoleRecordItem, RoguelikeAchieveSlotData> recordItemScroll = this.RecordItemScroll;
					if (recordItemScroll == null)
					{
						return;
					}
					recordItemScroll.SelectGridProxy(gridIndex, false);
				}
				return;
			}
			if (slotData.SlotIndex < 0)
			{
				return;
			}
			this.Vm.IsTempRecordSelected = false;
			RoguelikeAchieveTogTempRecordItem togTempRecordPanel = this.TogTempRecordPanel;
			if (togTempRecordPanel != null)
			{
				togTempRecordPanel.SetToggleState(false, false);
			}
			this.Vm.SelectedRecordGridIndex = gridIndex;
			GenericScrollViewNew<RoguelikeAchieveTogRoleRecordItem, RoguelikeAchieveSlotData> recordItemScroll2 = this.RecordItemScroll;
			if (recordItemScroll2 != null)
			{
				recordItemScroll2.SelectGridProxy(gridIndex, false);
			}
			Action onSelectedRoguelikeInfoChanged = this.OnSelectedRoguelikeInfoChanged;
			if (onSelectedRoguelikeInfoChanged == null)
			{
				return;
			}
			onSelectedRoguelikeInfoChanged();
		}

		// Token: 0x0602840B RID: 164875 RVA: 0x00B467C0 File Offset: 0x00B449C0
		private void RefreshStateIcon()
		{
			RoguelikeAchieveViewModel vm = this.Vm;
			if (vm != null)
			{
				string path = (vm.IsUseArchiveMode || vm.IsTempRecordSaved) ? RoguelikeAchieveDefine.RoguelikeAchieveSavedStateIconPath : RoguelikeAchieveDefine.RoguelikeAchieveUnSavedStateIconPath;
				UUISprite sprite = base.GetSprite(1);
				sprite.SetUIActive(true);
				this.SetSpriteByPath(path, sprite, false, null, null);
				return;
			}
			UUISprite sprite2 = base.GetSprite(1);
			if (sprite2 == null)
			{
				return;
			}
			sprite2.SetUIActive(false);
		}

		// Token: 0x0602840C RID: 164876 RVA: 0x00B4682C File Offset: 0x00B44A2C
		private List<RoguelikeAchieveSlotData> GetRoleRecordDataList()
		{
			RoguelikeAchieveViewModel vm = this.Vm;
			if (vm == null)
			{
				return new List<RoguelikeAchieveSlotData>();
			}
			if (vm.IsUseArchiveMode)
			{
				return vm.ArchiveSlotList.FindAll((RoguelikeAchieveSlotData slotData) => slotData.ArchiveInfoData != null);
			}
			return new List<RoguelikeAchieveSlotData>(vm.ArchiveSlotList);
		}

		// Token: 0x0602840D RID: 164877 RVA: 0x00B46888 File Offset: 0x00B44A88
		private int GetDefaultSelectedRecordGridIndex(List<RoguelikeAchieveSlotData> dataList)
		{
			if (dataList.Count <= 0)
			{
				return -1;
			}
			RoguelikeAchieveViewModel vm = this.Vm;
			if (vm != null && vm.IsUseArchiveMode)
			{
				return 0;
			}
			int num = dataList.FindIndex((RoguelikeAchieveSlotData slotData) => !slotData.ArchiveInfoData.HasData);
			if (num < 0)
			{
				return 0;
			}
			return num;
		}

		// Token: 0x04015E3E RID: 89662
		[Nullable(2)]
		private RoguelikeAchieveTogTempRecordItem TogTempRecordPanel;

		// Token: 0x04015E3F RID: 89663
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<RoguelikeAchieveTogRoleRecordItem, RoguelikeAchieveSlotData> RecordItemScroll;

		// Token: 0x04015E40 RID: 89664
		[Nullable(2)]
		private RoguelikeAchieveViewModel Vm;

		// Token: 0x04015E41 RID: 89665
		[Nullable(2)]
		private Action OnSelectedRoguelikeInfoChanged;

		// Token: 0x0200995A RID: 39258
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0402FD38 RID: 195896
			public const int TempRecordItem = 0;

			// Token: 0x0402FD39 RID: 195897
			public const int SprStateIcon = 1;

			// Token: 0x0402FD3A RID: 195898
			public const int RecordItemScroll = 2;

			// Token: 0x0402FD3B RID: 195899
			public const int RoleRecordItem = 3;
		}
	}
}

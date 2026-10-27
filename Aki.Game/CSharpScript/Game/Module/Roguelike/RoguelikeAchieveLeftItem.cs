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
	// Token: 0x02004DB0 RID: 19888
	[NullableContext(1)]
	[Nullable(0)]
	public class RoguelikeAchieveLeftItem : UiPanelBase
	{
		// Token: 0x06033592 RID: 210322 RVA: 0x00BFCED4 File Offset: 0x00BFB0D4
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

		// Token: 0x06033593 RID: 210323 RVA: 0x00BFCF80 File Offset: 0x00BFB180
		protected override UniTask OnBeforeStartAsync()
		{
			RoguelikeAchieveLeftItem.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoguelikeAchieveLeftItem.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06033594 RID: 210324 RVA: 0x00BFCFC3 File Offset: 0x00BFB1C3
		protected override void OnStart()
		{
			this.RefreshByViewModel();
		}

		// Token: 0x06033595 RID: 210325 RVA: 0x00BFCFCB File Offset: 0x00BFB1CB
		protected override void OnBeforeDestroy()
		{
			this.TogTempRecordPanel = null;
			this.RecordItemScroll = null;
			this.Vm = null;
			this.OnSelectedRoguelikeInfoChanged = null;
		}

		// Token: 0x06033596 RID: 210326 RVA: 0x00BFCFE9 File Offset: 0x00BFB1E9
		public void SetViewModel(RoguelikeAchieveViewModel vm)
		{
			this.Vm = vm;
		}

		// Token: 0x06033597 RID: 210327 RVA: 0x00BFCFF2 File Offset: 0x00BFB1F2
		public void BindOnSelectedRoguelikeInfoChanged(Action callback)
		{
			this.OnSelectedRoguelikeInfoChanged = callback;
		}

		// Token: 0x06033598 RID: 210328 RVA: 0x00BFCFFC File Offset: 0x00BFB1FC
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

		// Token: 0x06033599 RID: 210329 RVA: 0x00BFD071 File Offset: 0x00BFB271
		private RoguelikeAchieveTogRoleRecordItem CreateRoleRecordItem()
		{
			RoguelikeAchieveTogRoleRecordItem roguelikeAchieveTogRoleRecordItem = new RoguelikeAchieveTogRoleRecordItem();
			roguelikeAchieveTogRoleRecordItem.BindOnToggleStateChanged(new Action<RoguelikeAchieveSlotData, int, EToggleState>(this.OnRoleRecordToggleStateChanged));
			return roguelikeAchieveTogRoleRecordItem;
		}

		// Token: 0x0603359A RID: 210330 RVA: 0x00BFD08C File Offset: 0x00BFB28C
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

		// Token: 0x0603359B RID: 210331 RVA: 0x00BFD10C File Offset: 0x00BFB30C
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

		// Token: 0x0603359C RID: 210332 RVA: 0x00BFD18C File Offset: 0x00BFB38C
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

		// Token: 0x0603359D RID: 210333 RVA: 0x00BFD204 File Offset: 0x00BFB404
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

		// Token: 0x0603359E RID: 210334 RVA: 0x00BFD290 File Offset: 0x00BFB490
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

		// Token: 0x0603359F RID: 210335 RVA: 0x00BFD2FC File Offset: 0x00BFB4FC
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

		// Token: 0x060335A0 RID: 210336 RVA: 0x00BFD358 File Offset: 0x00BFB558
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

		// Token: 0x0401B46B RID: 111723
		[Nullable(2)]
		private RoguelikeAchieveTogTempRecordItem TogTempRecordPanel;

		// Token: 0x0401B46C RID: 111724
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<RoguelikeAchieveTogRoleRecordItem, RoguelikeAchieveSlotData> RecordItemScroll;

		// Token: 0x0401B46D RID: 111725
		[Nullable(2)]
		private RoguelikeAchieveViewModel Vm;

		// Token: 0x0401B46E RID: 111726
		[Nullable(2)]
		private Action OnSelectedRoguelikeInfoChanged;

		// Token: 0x0200AF25 RID: 44837
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x04035303 RID: 217859
			public const int TempRecordItem = 0;

			// Token: 0x04035304 RID: 217860
			public const int SprStateIcon = 1;

			// Token: 0x04035305 RID: 217861
			public const int RecordItemScroll = 2;

			// Token: 0x04035306 RID: 217862
			public const int RoleRecordItem = 3;
		}
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Menu.KeySettingsView
{
	// Token: 0x02004442 RID: 17474
	[NullableContext(1)]
	[Nullable(0)]
	public class ChangeModeTipsView : UiViewBase
	{
		// Token: 0x0602C15A RID: 180570 RVA: 0x00C6083E File Offset: 0x00C5EA3E
		public ChangeModeTipsView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602C15B RID: 180571 RVA: 0x00C60860 File Offset: 0x00C5EA60
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(3, typeof(UUIInteractionGroup)),
				new ValueTuple<int, Type>(4, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(5, typeof(UUIInteractionGroup)),
				new ValueTuple<int, Type>(6, typeof(UUIItem)),
				new ValueTuple<int, Type>(7, typeof(UUIItem)),
				new ValueTuple<int, Type>(8, typeof(UUIButtonComponent))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(8, new Action(this.OnConfirmButtonClicked)),
				new ValueTuple<int, Delegate>(2, new Action(this.OnLeftButtonClicked)),
				new ValueTuple<int, Delegate>(4, new Action(this.OnRightButtonClicked))
			};
		}

		// Token: 0x0602C15C RID: 180572 RVA: 0x00C60994 File Offset: 0x00C5EB94
		protected override UniTask OnBeforeStartAsync()
		{
			ChangeModeTipsView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ChangeModeTipsView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602C15D RID: 180573 RVA: 0x00C609D7 File Offset: 0x00C5EBD7
		protected override void OnStart()
		{
			this.Refresh();
		}

		// Token: 0x0602C15E RID: 180574 RVA: 0x00C609DF File Offset: 0x00C5EBDF
		protected override void OnBeforeDestroy()
		{
			this.CaptionItem = null;
			this.SelectedRowView = null;
			this.ChangeModeRowViewList.Clear();
		}

		// Token: 0x0602C15F RID: 180575 RVA: 0x00C609FA File Offset: 0x00C5EBFA
		private void Refresh()
		{
			this.RefreshGroupName();
			this.RefreshDefaultSelected();
			this.RefreshLeftAndRightButtonEnable();
			this.RefreshRowView();
		}

		// Token: 0x0602C160 RID: 180576 RVA: 0x00C60A14 File Offset: 0x00C5EC14
		private void RefreshGroupName()
		{
			if (this.ChangeKeyModeData == null)
			{
				return;
			}
			ChangeKeyModeGroupData changeKeyModeGroupData = this.ChangeKeyModeData.GetChangeKeyModeGroupDataList()[this.GroupIndex];
			if (changeKeyModeGroupData == null)
			{
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), changeKeyModeGroupData.GroupName, Array.Empty<object>());
		}

		// Token: 0x0602C161 RID: 180577 RVA: 0x00C60A64 File Offset: 0x00C5EC64
		private void RefreshDefaultSelected()
		{
			ChangeModeRowView selectedRowView = this.SelectedRowView;
			if (selectedRowView != null)
			{
				selectedRowView.SetSelected(false);
			}
			if (this.ChangeKeyModeData == null)
			{
				return;
			}
			if (this.ChangeKeyModeData.GetChangeKeyModeGroupDataList()[this.GroupIndex] == null)
			{
				return;
			}
			int valueOrDefault = this.EditRowIndexMap.GetValueOrDefault(this.GroupIndex, 0);
			ChangeModeRowView changeModeRowView = this.ChangeModeRowViewList[valueOrDefault];
			this.SelectedRowView = changeModeRowView;
			if (changeModeRowView != null)
			{
				changeModeRowView.SetSelected(true);
			}
		}

		// Token: 0x0602C162 RID: 180578 RVA: 0x00C60AD8 File Offset: 0x00C5ECD8
		public void RefreshLeftAndRightButtonEnable()
		{
			if (this.ChangeKeyModeData == null)
			{
				return;
			}
			int maxGroupIndex = this.ChangeKeyModeData.GetMaxGroupIndex();
			UUIInteractionGroup interactionGroup = base.GetInteractionGroup(3);
			UUIInteractionGroup interactionGroup2 = base.GetInteractionGroup(5);
			bool flag = this.GroupIndex > 0;
			bool flag2 = this.GroupIndex < maxGroupIndex;
			if (interactionGroup.GetInteractable() != flag)
			{
				interactionGroup.SetInteractable(flag);
			}
			if (interactionGroup2.GetInteractable() != flag2)
			{
				interactionGroup2.SetInteractable(flag2);
			}
		}

		// Token: 0x0602C163 RID: 180579 RVA: 0x00C60B44 File Offset: 0x00C5ED44
		public void RefreshRowView()
		{
			if (this.ChangeKeyModeData == null)
			{
				return;
			}
			ChangeKeyModeGroupData changeKeyModeGroupData = this.ChangeKeyModeData.GetChangeKeyModeGroupDataList()[this.GroupIndex];
			if (changeKeyModeGroupData == null)
			{
				return;
			}
			IReadOnlyList<ChangeKeyModeRowData> changeKeyModeRowDataList = changeKeyModeGroupData.GetChangeKeyModeRowDataList();
			for (int i = 0; i < this.ChangeModeRowViewList.Count; i++)
			{
				ChangeModeRowView changeModeRowView = this.ChangeModeRowViewList[i];
				ChangeKeyModeRowData changeKeyModeRowData = changeKeyModeRowDataList[i];
				changeModeRowView.Refresh(changeKeyModeRowData);
			}
		}

		// Token: 0x0602C164 RID: 180580 RVA: 0x00C60BAC File Offset: 0x00C5EDAC
		private void OnCloseButtonClicked()
		{
			base.CloseMe(null);
		}

		// Token: 0x0602C165 RID: 180581 RVA: 0x00C60BB5 File Offset: 0x00C5EDB5
		private void OnConfirmButtonClicked()
		{
			ChangeModeRowView selectedRowView = this.SelectedRowView;
			if (((selectedRowView != null) ? selectedRowView.ChangeKeyModeRowData : null) == null)
			{
				base.CloseMe(null);
				return;
			}
			if (this.OnConfirmCallback != null)
			{
				this.OnConfirmCallback(this.EditRowIndexMap);
			}
			base.CloseMe(null);
		}

		// Token: 0x0602C166 RID: 180582 RVA: 0x00C60BF4 File Offset: 0x00C5EDF4
		private void OnLeftButtonClicked()
		{
			int num = Math.Max(this.GroupIndex - 1, 0);
			if (num == this.GroupIndex)
			{
				return;
			}
			this.GroupIndex = num;
			this.Refresh();
		}

		// Token: 0x0602C167 RID: 180583 RVA: 0x00C60C28 File Offset: 0x00C5EE28
		private void OnRightButtonClicked()
		{
			int maxGroupIndex = this.ChangeKeyModeData.GetMaxGroupIndex();
			int num = Math.Min(this.GroupIndex + 1, maxGroupIndex);
			if (num == this.GroupIndex)
			{
				return;
			}
			this.GroupIndex = num;
			this.Refresh();
		}

		// Token: 0x0602C168 RID: 180584 RVA: 0x00C60C68 File Offset: 0x00C5EE68
		private void OnSelectedRowView(ChangeModeRowView changeModeRowView)
		{
			ChangeKeyModeRowData changeKeyModeRowData = changeModeRowView.ChangeKeyModeRowData;
			if (changeKeyModeRowData == null)
			{
				return;
			}
			ChangeModeRowView selectedRowView = this.SelectedRowView;
			if (selectedRowView != null)
			{
				selectedRowView.SetSelected(false);
			}
			this.SelectedRowView = changeModeRowView;
			this.EditRowIndexMap[this.GroupIndex] = changeKeyModeRowData.Index;
		}

		// Token: 0x04017BFC RID: 97276
		[Nullable(2)]
		private ChangeKeyModeData ChangeKeyModeData;

		// Token: 0x04017BFD RID: 97277
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x04017BFE RID: 97278
		private int GroupIndex;

		// Token: 0x04017BFF RID: 97279
		private readonly Dictionary<int, int> EditRowIndexMap = new Dictionary<int, int>();

		// Token: 0x04017C00 RID: 97280
		private readonly List<ChangeModeRowView> ChangeModeRowViewList = new List<ChangeModeRowView>();

		// Token: 0x04017C01 RID: 97281
		[Nullable(2)]
		private ChangeModeRowView SelectedRowView;

		// Token: 0x04017C02 RID: 97282
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<Dictionary<int, int>> OnConfirmCallback;

		// Token: 0x0200A10C RID: 41228
		[NullableContext(0)]
		public class EChildType
		{
			// Token: 0x0403208B RID: 204939
			public const int CaptionItem = 0;

			// Token: 0x0403208C RID: 204940
			public const int GroupNameText = 1;

			// Token: 0x0403208D RID: 204941
			public const int LeftButton = 2;

			// Token: 0x0403208E RID: 204942
			public const int LeftButtonInteractionGroup = 3;

			// Token: 0x0403208F RID: 204943
			public const int RightButton = 4;

			// Token: 0x04032090 RID: 204944
			public const int RightButtonInteractionGroup = 5;

			// Token: 0x04032091 RID: 204945
			public const int RowVerticalItem = 6;

			// Token: 0x04032092 RID: 204946
			public const int ChangeModeRowItem = 7;

			// Token: 0x04032093 RID: 204947
			public const int ConfirmButton = 8;
		}
	}
}

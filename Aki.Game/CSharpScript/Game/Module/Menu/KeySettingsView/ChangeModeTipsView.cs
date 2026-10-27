using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Menu.KeySettingsView
{
	// Token: 0x0200545F RID: 21599
	[NullableContext(1)]
	[Nullable(0)]
	public class ChangeModeTipsView : UiViewBase
	{
		// Token: 0x06037211 RID: 225809 RVA: 0x00D11426 File Offset: 0x00D0F626
		public ChangeModeTipsView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06037212 RID: 225810 RVA: 0x00D11448 File Offset: 0x00D0F648
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

		// Token: 0x06037213 RID: 225811 RVA: 0x00D1157C File Offset: 0x00D0F77C
		protected override UniTask OnBeforeStartAsync()
		{
			ChangeModeTipsView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ChangeModeTipsView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06037214 RID: 225812 RVA: 0x00D115BF File Offset: 0x00D0F7BF
		protected override void OnStart()
		{
			this.Refresh();
		}

		// Token: 0x06037215 RID: 225813 RVA: 0x00D115C7 File Offset: 0x00D0F7C7
		protected override void OnBeforeDestroy()
		{
			this.CaptionItem = null;
			this.SelectedRowView = null;
			this.ChangeModeRowViewList.Clear();
		}

		// Token: 0x06037216 RID: 225814 RVA: 0x00D115E2 File Offset: 0x00D0F7E2
		private void Refresh()
		{
			this.RefreshGroupName();
			this.RefreshDefaultSelected();
			this.RefreshLeftAndRightButtonEnable();
			this.RefreshRowView();
		}

		// Token: 0x06037217 RID: 225815 RVA: 0x00D115FC File Offset: 0x00D0F7FC
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

		// Token: 0x06037218 RID: 225816 RVA: 0x00D1164C File Offset: 0x00D0F84C
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

		// Token: 0x06037219 RID: 225817 RVA: 0x00D116C0 File Offset: 0x00D0F8C0
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

		// Token: 0x0603721A RID: 225818 RVA: 0x00D1172C File Offset: 0x00D0F92C
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

		// Token: 0x0603721B RID: 225819 RVA: 0x00D11794 File Offset: 0x00D0F994
		private void OnCloseButtonClicked()
		{
			base.CloseMe(null);
		}

		// Token: 0x0603721C RID: 225820 RVA: 0x00D1179D File Offset: 0x00D0F99D
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

		// Token: 0x0603721D RID: 225821 RVA: 0x00D117DC File Offset: 0x00D0F9DC
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

		// Token: 0x0603721E RID: 225822 RVA: 0x00D11810 File Offset: 0x00D0FA10
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

		// Token: 0x0603721F RID: 225823 RVA: 0x00D11850 File Offset: 0x00D0FA50
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

		// Token: 0x0401D163 RID: 119139
		[Nullable(2)]
		private ChangeKeyModeData ChangeKeyModeData;

		// Token: 0x0401D164 RID: 119140
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401D165 RID: 119141
		private int GroupIndex;

		// Token: 0x0401D166 RID: 119142
		private readonly Dictionary<int, int> EditRowIndexMap = new Dictionary<int, int>();

		// Token: 0x0401D167 RID: 119143
		private readonly List<ChangeModeRowView> ChangeModeRowViewList = new List<ChangeModeRowView>();

		// Token: 0x0401D168 RID: 119144
		[Nullable(2)]
		private ChangeModeRowView SelectedRowView;

		// Token: 0x0401D169 RID: 119145
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<Dictionary<int, int>> OnConfirmCallback;

		// Token: 0x0200B6D4 RID: 46804
		[NullableContext(0)]
		public class EChildType
		{
			// Token: 0x04037636 RID: 226870
			public const int CaptionItem = 0;

			// Token: 0x04037637 RID: 226871
			public const int GroupNameText = 1;

			// Token: 0x04037638 RID: 226872
			public const int LeftButton = 2;

			// Token: 0x04037639 RID: 226873
			public const int LeftButtonInteractionGroup = 3;

			// Token: 0x0403763A RID: 226874
			public const int RightButton = 4;

			// Token: 0x0403763B RID: 226875
			public const int RightButtonInteractionGroup = 5;

			// Token: 0x0403763C RID: 226876
			public const int RowVerticalItem = 6;

			// Token: 0x0403763D RID: 226877
			public const int ChangeModeRowItem = 7;

			// Token: 0x0403763E RID: 226878
			public const int ConfirmButton = 8;
		}
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.BaseConfig;
using CSharpScript.Launcher.PlayerInput;
using UnrealEngine;

namespace CSharpScript.Launcher.Ui.HotFix.NetWorkDetection.SelectServer
{
	// Token: 0x020000FC RID: 252
	[NullableContext(1)]
	[Nullable(0)]
	public class HotFixNetworkDetectSelectView : LaunchComponentsAction
	{
		// Token: 0x06000851 RID: 2129 RVA: 0x0003DDF0 File Offset: 0x0003BFF0
		protected override void OnStart()
		{
			base.GetButton(1).OnClickCallBack.Bind(new Action(this.OnBackBtnClick));
			HotFixManager.SetLocalText(base.GetText(2), "NetworkDetection_Select", Array.Empty<string>());
			base.AttachElement<HotFixButtonItem>(6).BindClickCallback(new Action(this.OnRightBtnClick));
			HotFixButtonItem hotFixButtonItem = base.AttachElement<HotFixButtonItem>(5);
			hotFixButtonItem.BindClickCallback(new Action(this.OnLeftBtnClick));
			hotFixButtonItem.SetLocalText("NetworkDetection_Cancel");
			UUILayoutBase layout = base.GetLayout(7);
			AUIBaseActor gridActor = base.GetItem(4).GetOwner() as AUIBaseActor;
			this.HotFixNetworkDetectSelectLayout = new HotFixLayout<HotFixNetworkDetectSelectItem, IHotFixNetworkDetectSelectData>(layout, () => new HotFixNetworkDetectSelectItem(), gridActor);
			HotPatchInputManager.Instance.RegisterInputAxis("手柄右摇杆垂直方向", new TInputAxis(this.InputAxis));
			HotPatchInputManager.Instance.RegisterInputAction("手柄左摇杆上", new TInputAction(this.InputAction));
			HotPatchInputManager.Instance.RegisterInputAction("手柄左摇杆下", new TInputAction(this.InputAction));
			HotPatchInputManager.Instance.RegisterInputAction("手柄左边上键", new TInputAction(this.InputAction));
			HotPatchInputManager.Instance.RegisterInputAction("手柄左边下键", new TInputAction(this.InputAction));
			this.RegisteredInput = true;
		}

		// Token: 0x06000852 RID: 2130 RVA: 0x0003DF40 File Offset: 0x0003C140
		protected override void OnShow()
		{
			List<IHotFixNetworkDetectSelectData> loginServersLayoutItemData = HotFixNetworkDetectionModel.Instance.GetLoginServersLayoutItemData();
			HotFixNetworkDetectionModel.Instance.CurrentUiSelectSeverData = HotFixNetworkDetectionModel.Instance.CurrentSelectServerData;
			int recommendedServerIndex = this.GetRecommendedServerIndex(loginServersLayoutItemData);
			this.CurrentSelectIndex = ((HotFixNetworkDetectionModel.Instance.CurrentUiSelectSeverData != null) ? recommendedServerIndex : -1);
			this.HotFixNetworkDetectSelectLayout.RefreshByData(loginServersLayoutItemData);
			this.BindToggleGroupChanged();
			this.TryMoveToItem(loginServersLayoutItemData);
		}

		// Token: 0x06000853 RID: 2131 RVA: 0x0003DFA4 File Offset: 0x0003C1A4
		private void BindToggleGroupChanged()
		{
			IReadOnlyList<IHotFixLayoutItem> layoutItemList = this.HotFixNetworkDetectSelectLayout.GetLayoutItemList();
			for (int i = 0; i < layoutItemList.Count; i++)
			{
				((HotFixNetworkDetectSelectItem)layoutItemList[i]).OnToggleStateChange = new Action(this.RefreshToggleGroupState);
			}
		}

		// Token: 0x06000854 RID: 2132 RVA: 0x0003DFEC File Offset: 0x0003C1EC
		private void RefreshToggleGroupState()
		{
			IReadOnlyList<IHotFixLayoutItem> layoutItemList = this.HotFixNetworkDetectSelectLayout.GetLayoutItemList();
			for (int i = 0; i < layoutItemList.Count; i++)
			{
				((HotFixNetworkDetectSelectItem)layoutItemList[i]).RefreshToggleState();
			}
		}

		// Token: 0x06000855 RID: 2133 RVA: 0x0003E028 File Offset: 0x0003C228
		protected override void OnBeforeDestroy()
		{
			this.HotFixNetworkDetectSelectLayout.ClearChildren();
			if (this.RegisteredInput)
			{
				HotPatchInputManager.Instance.UnRegisterInputAxis("手柄右摇杆垂直方向", new TInputAxis(this.InputAxis));
				HotPatchInputManager.Instance.UnRegisterInputAction("手柄左摇杆上", new TInputAction(this.InputAction));
				HotPatchInputManager.Instance.UnRegisterInputAction("手柄左摇杆下", new TInputAction(this.InputAction));
				HotPatchInputManager.Instance.UnRegisterInputAction("手柄左边上键", new TInputAction(this.InputAction));
				HotPatchInputManager.Instance.UnRegisterInputAction("手柄左边下键", new TInputAction(this.InputAction));
				this.RegisteredInput = false;
			}
		}

		// Token: 0x06000856 RID: 2134 RVA: 0x0003E0D9 File Offset: 0x0003C2D9
		private void OnBackBtnClick()
		{
			this.CloseMe();
		}

		// Token: 0x06000857 RID: 2135 RVA: 0x0003E0E1 File Offset: 0x0003C2E1
		private void OnLeftBtnClick()
		{
			this.CloseMe();
		}

		// Token: 0x06000858 RID: 2136 RVA: 0x0003E0EC File Offset: 0x0003C2EC
		private void OnRightBtnClick()
		{
			ILoginServersData currentUiSelectSeverData = HotFixNetworkDetectionModel.Instance.CurrentUiSelectSeverData;
			HotFixNetworkDetectionModel.Instance.CurrentSelectServerData = currentUiSelectSeverData;
			TOnSelectServerCallback onSelectServerCallBack = this.OnSelectServerCallBack;
			if (onSelectServerCallBack != null)
			{
				onSelectServerCallBack();
			}
			this.CloseMe();
		}

		// Token: 0x06000859 RID: 2137 RVA: 0x0003E126 File Offset: 0x0003C326
		private void CloseMe()
		{
			base.SetActive(false);
		}

		// Token: 0x0600085A RID: 2138 RVA: 0x0003E130 File Offset: 0x0003C330
		private void TryMoveToItem(IReadOnlyList<IHotFixNetworkDetectSelectData> dataList)
		{
			int recommendedServerIndex = this.GetRecommendedServerIndex(dataList);
			UUIItem gridItemByIndex = this.HotFixNetworkDetectSelectLayout.GetGridItemByIndex(recommendedServerIndex);
			base.GetUiScrollViewWithScrollBar(3).ScrollTo(gridItemByIndex, false);
		}

		// Token: 0x0600085B RID: 2139 RVA: 0x0003E160 File Offset: 0x0003C360
		private int GetRecommendedServerIndex(IReadOnlyList<IHotFixNetworkDetectSelectData> dataList)
		{
			int result = 0;
			int count = dataList.Count;
			for (int i = 0; i < count; i++)
			{
				if (HotFixNetworkDetectionModel.Instance.CurrentUiSelectSeverData == dataList[i].LoginServersData)
				{
					result = i;
					break;
				}
			}
			return result;
		}

		// Token: 0x0600085C RID: 2140 RVA: 0x0003E1A0 File Offset: 0x0003C3A0
		private void InputAxis(float value, string axisName)
		{
			if (value == 0f)
			{
				return;
			}
			if ("手柄右摇杆垂直方向" == axisName)
			{
				base.GetUiScrollViewWithScrollBar(3).SetVelocity(value * 800f);
			}
			if ("手柄左摇杆垂直方向" == axisName)
			{
				if (value < 0f)
				{
					this.FocusNext();
				}
				if (value > 0f)
				{
					this.FocusPrev();
				}
			}
		}

		// Token: 0x0600085D RID: 2141 RVA: 0x0003E200 File Offset: 0x0003C400
		private void InputAction(bool bPress, string actionName)
		{
			if (!bPress)
			{
				return;
			}
			if ("手柄左边上键" == actionName || "手柄左摇杆上" == actionName)
			{
				this.FocusPrev();
			}
			if ("手柄左边下键" == actionName || "手柄左摇杆下" == actionName)
			{
				this.FocusNext();
			}
		}

		// Token: 0x0600085E RID: 2142 RVA: 0x0003E254 File Offset: 0x0003C454
		private void FocusPrev()
		{
			int val = 0;
			int num = this.CurrentSelectIndex - 1;
			this.CurrentSelectIndex = num;
			this.CurrentSelectIndex = Math.Max(val, num);
			this.HandleFocusScrollItem();
		}

		// Token: 0x0600085F RID: 2143 RVA: 0x0003E284 File Offset: 0x0003C484
		private void FocusNext()
		{
			int val = this.HotFixNetworkDetectSelectLayout.GetDataList().Count - 1;
			int num = this.CurrentSelectIndex + 1;
			this.CurrentSelectIndex = num;
			this.CurrentSelectIndex = Math.Min(val, num);
			this.HandleFocusScrollItem();
		}

		// Token: 0x06000860 RID: 2144 RVA: 0x0003E2C8 File Offset: 0x0003C4C8
		private void HandleFocusScrollItem()
		{
			HotFixNetworkDetectSelectItem hotFixNetworkDetectSelectItem = this.HotFixNetworkDetectSelectLayout.GetLayoutItemByIndex(this.CurrentSelectIndex) as HotFixNetworkDetectSelectItem;
			if (hotFixNetworkDetectSelectItem != null)
			{
				HotFixNetworkDetectionModel instance = HotFixNetworkDetectionModel.Instance;
				IHotFixNetworkDetectSelectData data = hotFixNetworkDetectSelectItem.Data;
				instance.CurrentUiSelectSeverData = ((data != null) ? data.LoginServersData : null);
				base.GetUiScrollViewWithScrollBar(3).ScrollToSelectableComponent(hotFixNetworkDetectSelectItem.GetToggle());
				this.RefreshToggleGroupState();
			}
		}

		// Token: 0x040004B5 RID: 1205
		private HotFixLayout<HotFixNetworkDetectSelectItem, IHotFixNetworkDetectSelectData> HotFixNetworkDetectSelectLayout;

		// Token: 0x040004B6 RID: 1206
		[Nullable(2)]
		public TOnSelectServerCallback OnSelectServerCallBack;

		// Token: 0x040004B7 RID: 1207
		private int CurrentSelectIndex = -1;

		// Token: 0x040004B8 RID: 1208
		private bool RegisteredInput;

		// Token: 0x02000395 RID: 917
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x0400127C RID: 4732
			public const int BtnMask = 0;

			// Token: 0x0400127D RID: 4733
			public const int BtnBack = 1;

			// Token: 0x0400127E RID: 4734
			public const int TxtTitle = 2;

			// Token: 0x0400127F RID: 4735
			public const int ScrollView = 3;

			// Token: 0x04001280 RID: 4736
			public const int ServerItem = 4;

			// Token: 0x04001281 RID: 4737
			public const int LeftBtn = 5;

			// Token: 0x04001282 RID: 4738
			public const int RightBtn = 6;

			// Token: 0x04001283 RID: 4739
			public const int Content = 7;
		}
	}
}

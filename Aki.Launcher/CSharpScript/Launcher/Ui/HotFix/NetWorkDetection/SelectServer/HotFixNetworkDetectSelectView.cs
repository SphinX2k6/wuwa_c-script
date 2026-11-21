using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.BaseConfig;
using CSharpScript.Launcher.PlayerInput;
using UnrealEngine;

namespace CSharpScript.Launcher.Ui.HotFix.NetWorkDetection.SelectServer
{
	// Token: 0x02000100 RID: 256
	[NullableContext(1)]
	[Nullable(0)]
	public class HotFixNetworkDetectSelectView : LaunchComponentsAction
	{
		// Token: 0x06000885 RID: 2181 RVA: 0x00040190 File Offset: 0x0003E390
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

		// Token: 0x06000886 RID: 2182 RVA: 0x000402E0 File Offset: 0x0003E4E0
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

		// Token: 0x06000887 RID: 2183 RVA: 0x00040344 File Offset: 0x0003E544
		private void BindToggleGroupChanged()
		{
			IReadOnlyList<IHotFixLayoutItem> layoutItemList = this.HotFixNetworkDetectSelectLayout.GetLayoutItemList();
			for (int i = 0; i < layoutItemList.Count; i++)
			{
				((HotFixNetworkDetectSelectItem)layoutItemList[i]).OnToggleStateChange = new Action(this.RefreshToggleGroupState);
			}
		}

		// Token: 0x06000888 RID: 2184 RVA: 0x0004038C File Offset: 0x0003E58C
		private void RefreshToggleGroupState()
		{
			IReadOnlyList<IHotFixLayoutItem> layoutItemList = this.HotFixNetworkDetectSelectLayout.GetLayoutItemList();
			for (int i = 0; i < layoutItemList.Count; i++)
			{
				((HotFixNetworkDetectSelectItem)layoutItemList[i]).RefreshToggleState();
			}
		}

		// Token: 0x06000889 RID: 2185 RVA: 0x000403C8 File Offset: 0x0003E5C8
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

		// Token: 0x0600088A RID: 2186 RVA: 0x00040479 File Offset: 0x0003E679
		private void OnBackBtnClick()
		{
			this.CloseMe();
		}

		// Token: 0x0600088B RID: 2187 RVA: 0x00040481 File Offset: 0x0003E681
		private void OnLeftBtnClick()
		{
			this.CloseMe();
		}

		// Token: 0x0600088C RID: 2188 RVA: 0x0004048C File Offset: 0x0003E68C
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

		// Token: 0x0600088D RID: 2189 RVA: 0x000404C6 File Offset: 0x0003E6C6
		private void CloseMe()
		{
			base.SetActive(false);
		}

		// Token: 0x0600088E RID: 2190 RVA: 0x000404D0 File Offset: 0x0003E6D0
		private void TryMoveToItem(IReadOnlyList<IHotFixNetworkDetectSelectData> dataList)
		{
			int recommendedServerIndex = this.GetRecommendedServerIndex(dataList);
			UUIItem gridItemByIndex = this.HotFixNetworkDetectSelectLayout.GetGridItemByIndex(recommendedServerIndex);
			base.GetUiScrollViewWithScrollBar(3).ScrollTo(gridItemByIndex, false);
		}

		// Token: 0x0600088F RID: 2191 RVA: 0x00040500 File Offset: 0x0003E700
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

		// Token: 0x06000890 RID: 2192 RVA: 0x00040540 File Offset: 0x0003E740
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

		// Token: 0x06000891 RID: 2193 RVA: 0x000405A0 File Offset: 0x0003E7A0
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

		// Token: 0x06000892 RID: 2194 RVA: 0x000405F4 File Offset: 0x0003E7F4
		private void FocusPrev()
		{
			int val = 0;
			int num = this.CurrentSelectIndex - 1;
			this.CurrentSelectIndex = num;
			this.CurrentSelectIndex = Math.Max(val, num);
			this.HandleFocusScrollItem();
		}

		// Token: 0x06000893 RID: 2195 RVA: 0x00040624 File Offset: 0x0003E824
		private void FocusNext()
		{
			int val = this.HotFixNetworkDetectSelectLayout.GetDataList().Count - 1;
			int num = this.CurrentSelectIndex + 1;
			this.CurrentSelectIndex = num;
			this.CurrentSelectIndex = Math.Min(val, num);
			this.HandleFocusScrollItem();
		}

		// Token: 0x06000894 RID: 2196 RVA: 0x00040668 File Offset: 0x0003E868
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

		// Token: 0x040004F0 RID: 1264
		private HotFixLayout<HotFixNetworkDetectSelectItem, IHotFixNetworkDetectSelectData> HotFixNetworkDetectSelectLayout;

		// Token: 0x040004F1 RID: 1265
		[Nullable(2)]
		public TOnSelectServerCallback OnSelectServerCallBack;

		// Token: 0x040004F2 RID: 1266
		private int CurrentSelectIndex = -1;

		// Token: 0x040004F3 RID: 1267
		private bool RegisteredInput;

		// Token: 0x020003A2 RID: 930
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x040012F2 RID: 4850
			public const int BtnMask = 0;

			// Token: 0x040012F3 RID: 4851
			public const int BtnBack = 1;

			// Token: 0x040012F4 RID: 4852
			public const int TxtTitle = 2;

			// Token: 0x040012F5 RID: 4853
			public const int ScrollView = 3;

			// Token: 0x040012F6 RID: 4854
			public const int ServerItem = 4;

			// Token: 0x040012F7 RID: 4855
			public const int LeftBtn = 5;

			// Token: 0x040012F8 RID: 4856
			public const int RightBtn = 6;

			// Token: 0x040012F9 RID: 4857
			public const int Content = 7;
		}
	}
}

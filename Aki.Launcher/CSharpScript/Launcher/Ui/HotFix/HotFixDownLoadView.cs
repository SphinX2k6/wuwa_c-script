using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Define;
using CSharpScript.Launcher.DiffPatch.Update;
using CSharpScript.Launcher.Platform;
using CSharpScript.Launcher.PlayerInput;
using CSharpScript.Launcher.Update.ResourceDiffUpdate;
using CSharpScript.Launcher.Util;
using UnrealEngine;

namespace CSharpScript.Launcher.Ui.HotFix
{
	// Token: 0x020000CE RID: 206
	[NullableContext(1)]
	[Nullable(0)]
	public class HotFixDownLoadView : LaunchComponentsAction
	{
		// Token: 0x060006BD RID: 1725 RVA: 0x000389E8 File Offset: 0x00036BE8
		protected override void OnStart()
		{
			HotFixBtnUiItem hotFixBtnUiItem = base.AttachElement<HotFixBtnUiItem>(8);
			hotFixBtnUiItem.BindClickCallback(delegate
			{
				LauncherLog instance = LauncherLog.Instance;
				string message = "HotFixDownLoadView ClickBtnCallback";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("this.SelectTabIndex", this.SelectTabIndex);
				instance.Info(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				ETier localResourceQualityTier = HotFixManager.GetLocalResourceQualityTier();
				ETier selectResourceQualityTier = HotFixManager.SelectResourceQualityTier;
				if (HotFixManager.IsTierEnabled() && localResourceQualityTier != ETier.None && selectResourceQualityTier != localResourceQualityTier)
				{
					Action<EResUpdateType, ETier, ETier> showChangeTierPopupCallBack = this.ShowChangeTierPopupCallBack;
					if (showChangeTierPopupCallBack != null)
					{
						showChangeTierPopupCallBack((EResUpdateType)this.SelectTabIndex, localResourceQualityTier, selectResourceQualityTier);
					}
					base.SetActive(false);
					return;
				}
				HotFixManager.ResDownLoadType = (EResUpdateType)this.SelectTabIndex;
				long resSize = ResourceDiffUpdaterManager.Instance.GetResSize((EResUpdateType)this.SelectTabIndex, HotFixDownLoadView.GetSelectTier());
				HotFixManager.NeedDownLoadByte = resSize;
				if (VideoResUpdate.Instance.GetFreeSpace() >= resSize)
				{
					Action downLoadViewChoseDoneCallBack = HotFixManager.DownLoadViewChoseDoneCallBack;
					if (downLoadViewChoseDoneCallBack != null)
					{
						downLoadViewChoseDoneCallBack();
					}
					Action freeSpaceCheckDoneCallBack = HotFixManager.FreeSpaceCheckDoneCallBack;
					if (freeSpaceCheckDoneCallBack != null)
					{
						freeSpaceCheckDoneCallBack();
					}
				}
				else
				{
					this.SetFreeSpaceTipsPopActive(true);
				}
				base.SetActive(false);
			});
			hotFixBtnUiItem.SetText("Download_DownLoadBtnText", Array.Empty<string>());
			base.AttachElement<HotFixBtnUiItem>(9).BindClickCallback(delegate
			{
				if (this.SetClearSubPackagePopActiveCallBack != null)
				{
					this.SetClearSubPackagePopActiveCallBack(true, delegate
					{
						base.SetActive(true);
					});
				}
				int canCleanUpSpace = (int)(HotFixManager.GetAllCanClearSpace() / 1048576L);
				FLoginStruct loginData = HotFixManager.LoginData;
				new InitialMobileResCleanUpViewStateLog(canCleanUpSpace, ((loginData != null) ? loginData.Uid : null) ?? "", ResourceDiffUpdaterManager.Instance.TraceId.ToString(), 1, null).Report();
				base.SetActive(false);
			});
			UUILayoutBase layout = base.GetLayout(1);
			AUIBaseActor gridActor = base.GetItem(0).GetOwner() as AUIBaseActor;
			this.HotFixTabLayout = new HotFixLayout<HotFixDownLoadTabItem, IHotFixDownLoadTabItemData>(layout, () => new HotFixDownLoadTabItem
			{
				OnClickExtendToggleCallBack = new Action<int, UUIExtendToggle>(this.OnClickToggle)
			}, gridActor);
			HotFixManager.SetLocalText(base.GetText(11), "PrefabTextItem_1851234659_Text", Array.Empty<string>());
			this.InitResTierItems();
		}

		// Token: 0x060006BE RID: 1726 RVA: 0x00038A88 File Offset: 0x00036C88
		private void InitResTierItems()
		{
			int[] array = new int[]
			{
				13,
				14
			};
			if (!HotFixManager.IsTierEnabled() || !Platform.Instance.IsMobilePlatform() || !HotFixManager.IsMobileHighEndDevice())
			{
				foreach (int index in array)
				{
					UUIItem item = base.GetItem(index);
					if (item != null)
					{
						item.SetUIActive(false);
					}
				}
				return;
			}
			ETier localResourceQualityTier = HotFixManager.GetLocalResourceQualityTier();
			ETier recommendTier = HotFixManager.GetRecommendTier();
			List<ETier> list = new List<ETier>(HotFixManager.GetSupportedResourceQualityTiers());
			list.Reverse();
			for (int j = 0; j < array.Length; j++)
			{
				UUIItem item2 = base.GetItem(array[j]);
				if (j >= list.Count)
				{
					if (item2 != null)
					{
						item2.SetUIActive(false);
					}
				}
				else
				{
					ETier etier = list[j];
					if (item2 != null)
					{
						item2.SetUIActive(true);
					}
					HotFixResTierItem hotFixResTierItem = base.AttachElement<HotFixResTierItem>(array[j]);
					hotFixResTierItem.RefreshItem(etier);
					bool flag = localResourceQualityTier == ETier.None && etier == recommendTier;
					bool showTag = (localResourceQualityTier == ETier.None) ? flag : (etier == localResourceQualityTier);
					hotFixResTierItem.SetCurrentTag(showTag, flag);
					hotFixResTierItem.BindClickCallback(delegate(ETier clickedTier, UUIExtendToggle toggle)
					{
						this.OnClickResTierItemToggle(clickedTier, toggle);
					});
					this.ResTierItems.Add(hotFixResTierItem);
				}
			}
		}

		// Token: 0x060006BF RID: 1727 RVA: 0x00038BC0 File Offset: 0x00036DC0
		private int GetDefaultSelectedIndex()
		{
			List<ETier> list = new List<ETier>(HotFixManager.GetSupportedResourceQualityTiers());
			list.Reverse();
			ETier? targetResourceQualityTier = HotFixManager.GetTargetResourceQualityTier();
			if (targetResourceQualityTier != null)
			{
				int num = list.IndexOf(targetResourceQualityTier.Value);
				if (num >= 0)
				{
					return num;
				}
			}
			ETier localResourceQualityTier = HotFixManager.GetLocalResourceQualityTier();
			if (localResourceQualityTier != ETier.None)
			{
				int num2 = list.IndexOf(localResourceQualityTier);
				if (num2 >= 0)
				{
					return num2;
				}
			}
			int num3 = list.IndexOf(HotFixManager.GetRecommendTier());
			if (num3 < 0)
			{
				return 0;
			}
			return num3;
		}

		// Token: 0x060006C0 RID: 1728 RVA: 0x00038C34 File Offset: 0x00036E34
		private void OnClickResTierItemToggle(ETier tier, UUIExtendToggle toggle)
		{
			UUIExtendToggle currentSelectResTierToggle = this.CurrentSelectResTierToggle;
			if (currentSelectResTierToggle != null)
			{
				currentSelectResTierToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
			}
			this.CurrentSelectResTierToggle = toggle;
			HotFixManager.SelectResourceQualityTier = tier;
			this.RefreshRightBtnText();
			ResourceDiffUpdaterManager.Instance.SwitchResTier(new ETier?(tier));
			if (this.SelectTabIndex < 0)
			{
				return;
			}
			this.RefreshTabContent(this.SelectTabIndex);
			for (int i = 0; i < 2; i++)
			{
				((HotFixDownLoadTabItem)this.HotFixTabLayout.GetLayoutItemByIndex(i)).RefreshSpace();
			}
		}

		// Token: 0x060006C1 RID: 1729 RVA: 0x00038CB4 File Offset: 0x00036EB4
		protected override void OnHide()
		{
			HotPatchInputManager.Instance.UnRegisterInputAxis("手柄右摇杆垂直方向", new TInputAxis(this.InputAxis));
			HotPatchInputManager.Instance.UnRegisterInputAction("手柄左摇杆上", new TInputAction(this.InputAction));
			HotPatchInputManager.Instance.UnRegisterInputAction("手柄左摇杆下", new TInputAction(this.InputAction));
			HotPatchInputManager.Instance.UnRegisterInputAction("手柄左边上键", new TInputAction(this.InputAction));
			HotPatchInputManager.Instance.UnRegisterInputAction("手柄左边下键", new TInputAction(this.InputAction));
		}

		// Token: 0x060006C2 RID: 1730 RVA: 0x00038D48 File Offset: 0x00036F48
		protected override void OnShow()
		{
			if (!this.HasCapturedClearResourceQualityTier)
			{
				ETier localResourceQualityTier = HotFixManager.LocalResourceQualityTier;
				this.ClearResourceQualityTier = ((HotFixManager.IsTierEnabled() && localResourceQualityTier != ETier.None) ? new ETier?(localResourceQualityTier) : null);
				this.HasCapturedClearResourceQualityTier = true;
			}
			if (this.ResTierItems.Count > 0)
			{
				this.ResTierItems[this.GetDefaultSelectedIndex()].SetToggleState(true);
			}
			else
			{
				ResourceDiffUpdaterManager.Instance.SwitchResTier(HotFixDownLoadView.GetSelectTier());
			}
			List<IHotFixDownLoadTabItemData> list = new List<IHotFixDownLoadTabItemData>();
			for (int i = 1; i <= 2; i++)
			{
				HotFixDownLoadTabItemData item = new HotFixDownLoadTabItemData
				{
					TabId = i
				};
				list.Add(item);
			}
			this.HotFixTabLayout.RefreshByData(list);
			((HotFixDownLoadTabItem)this.HotFixTabLayout.GetLayoutItemByIndex(0)).Select();
			long clearSpaceByCapturedTier = this.GetClearSpaceByCapturedTier();
			base.GetButton(9).SetSelfInteractive(clearSpaceByCapturedTier > 0L);
			HotFixBtnUiItem element = base.GetElement<HotFixBtnUiItem>(9);
			if (clearSpaceByCapturedTier > 0L)
			{
				element.SetText("HotFixSubPackageClearButton_Out", new string[]
				{
					HotFixManager.ByteConverter(clearSpaceByCapturedTier)
				});
			}
			else
			{
				element.SetText("HotFixSubPackageHaveNoSpaceClear", Array.Empty<string>());
			}
			HotPatchInputManager.Instance.RegisterInputAxis("手柄右摇杆垂直方向", new TInputAxis(this.InputAxis));
			HotPatchInputManager.Instance.RegisterInputAction("手柄左摇杆上", new TInputAction(this.InputAction));
			HotPatchInputManager.Instance.RegisterInputAction("手柄左摇杆下", new TInputAction(this.InputAction));
			HotPatchInputManager.Instance.RegisterInputAction("手柄左边上键", new TInputAction(this.InputAction));
			HotPatchInputManager.Instance.RegisterInputAction("手柄左边下键", new TInputAction(this.InputAction));
			LauncherStorageLib.Instance.DeleteDeviceSaved(ELauncherStorageDeviceKey.TargetResourceQualityTier);
		}

		// Token: 0x060006C3 RID: 1731 RVA: 0x00038EF8 File Offset: 0x000370F8
		private void OnClickToggle(int tabIndex, UUIExtendToggle toggle)
		{
			UUIExtendToggle currentSelectToggle = this.CurrentSelectToggle;
			if (currentSelectToggle != null)
			{
				currentSelectToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
			}
			this.CurrentSelectToggle = toggle;
			this.RefreshTabContent(tabIndex);
		}

		// Token: 0x060006C4 RID: 1732 RVA: 0x00038F20 File Offset: 0x00037120
		private void RefreshTabContent(int tabIndex)
		{
			this.SelectTabIndex = tabIndex;
			LauncherDownLoadConfig downLoadTabConfig = LauncherConfigLib.Instance.GetDownLoadTabConfig(tabIndex.ToString());
			ETier? selectTier = HotFixDownLoadView.GetSelectTier();
			if (selectTier != null)
			{
				ETier valueOrDefault = selectTier.GetValueOrDefault();
				if (valueOrDefault == ETier.SD)
				{
					HotFixManager.SetLocalText(base.GetText(2), downLoadTabConfig.ContentTitleSd, Array.Empty<string>());
					HotFixManager.SetLocalText(base.GetText(3), downLoadTabConfig.ContentSd, Array.Empty<string>());
					goto IL_C6;
				}
				if (valueOrDefault == ETier.HD)
				{
					HotFixManager.SetLocalText(base.GetText(2), downLoadTabConfig.ContentTitleHd, Array.Empty<string>());
					HotFixManager.SetLocalText(base.GetText(3), downLoadTabConfig.ContentHd, Array.Empty<string>());
					goto IL_C6;
				}
			}
			HotFixManager.SetLocalText(base.GetText(2), downLoadTabConfig.ContentTitle, Array.Empty<string>());
			HotFixManager.SetLocalText(base.GetText(3), downLoadTabConfig.Content, Array.Empty<string>());
			IL_C6:
			long freeSpace = VideoResUpdate.Instance.GetFreeSpace();
			if (freeSpace > ResourceDiffUpdaterManager.Instance.GetResSize((EResUpdateType)this.SelectTabIndex, HotFixDownLoadView.GetSelectTier()))
			{
				HotFixManager.SetLocalText(base.GetText(4), "DownLoadText_LeftSpace", new string[]
				{
					"<color=#36cd33>" + HotFixManager.ByteConverter(freeSpace) + "</color>"
				});
			}
			else
			{
				HotFixManager.SetLocalText(base.GetText(4), "DownLoadText_LeftSpace", new string[]
				{
					"<color=#c25757>" + HotFixManager.ByteConverter(freeSpace) + "</color>"
				});
			}
			this.RefreshRightBtnText();
		}

		// Token: 0x060006C5 RID: 1733 RVA: 0x0003907C File Offset: 0x0003727C
		public void SetFreeSpaceTipsPopActive(bool value)
		{
			Action<bool> setFreeSpaceTipsPopActiveCallBack = this.SetFreeSpaceTipsPopActiveCallBack;
			if (setFreeSpaceTipsPopActiveCallBack != null)
			{
				setFreeSpaceTipsPopActiveCallBack(value);
			}
			LauncherLog instance = LauncherLog.Instance;
			string message = "SetHotFixDownLoadFreeSpaceTipsViewActive";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("value", value);
			instance.Info(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}

		// Token: 0x060006C6 RID: 1734 RVA: 0x000390C3 File Offset: 0x000372C3
		private void InputAxis(float value, string axisName)
		{
			if (value == 0f)
			{
				return;
			}
			if ("手柄右摇杆垂直方向" == axisName)
			{
				base.GetUiScrollViewWithScrollBar(12).SetVelocity(value * 800f);
			}
		}

		// Token: 0x060006C7 RID: 1735 RVA: 0x000390F0 File Offset: 0x000372F0
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

		// Token: 0x060006C8 RID: 1736 RVA: 0x00039141 File Offset: 0x00037341
		private void FocusPrev()
		{
			this.SelectTabIndexToggle(Math.Max(0, this.SelectTabIndex - 1 - 1));
		}

		// Token: 0x060006C9 RID: 1737 RVA: 0x00039159 File Offset: 0x00037359
		private void FocusNext()
		{
			this.SelectTabIndexToggle(Math.Min(1, this.SelectTabIndex - 1 + 1));
		}

		// Token: 0x060006CA RID: 1738 RVA: 0x00039171 File Offset: 0x00037371
		private void SelectTabIndexToggle(int index)
		{
			((HotFixDownLoadTabItem)this.HotFixTabLayout.GetLayoutItemByIndex(index)).Select();
		}

		// Token: 0x060006CB RID: 1739 RVA: 0x0003918C File Offset: 0x0003738C
		private static ETier? GetSelectTier()
		{
			if (HotFixManager.SelectResourceQualityTier == ETier.None)
			{
				return null;
			}
			return new ETier?(HotFixManager.SelectResourceQualityTier);
		}

		// Token: 0x060006CC RID: 1740 RVA: 0x000391B4 File Offset: 0x000373B4
		public ETier? GetClearResourceQualityTier()
		{
			return this.ClearResourceQualityTier;
		}

		// Token: 0x060006CD RID: 1741 RVA: 0x000391BC File Offset: 0x000373BC
		private long GetClearSpaceByCapturedTier()
		{
			if (this.ClearResourceQualityTier != null)
			{
				ETier? clearResourceQualityTier = this.ClearResourceQualityTier;
				ETier localResourceQualityTier = HotFixManager.LocalResourceQualityTier;
				if (!(clearResourceQualityTier.GetValueOrDefault() == localResourceQualityTier & clearResourceQualityTier != null))
				{
					ETier localResourceQualityTier2 = HotFixManager.LocalResourceQualityTier;
					ResourceDiffUpdaterManager.Instance.SwitchResTier(this.ClearResourceQualityTier);
					long allCanClearSpace = HotFixManager.GetAllCanClearSpace();
					ResourceDiffUpdaterManager.Instance.SwitchResTier(new ETier?(localResourceQualityTier2));
					return allCanClearSpace;
				}
			}
			return HotFixManager.GetAllCanClearSpace();
		}

		// Token: 0x060006CE RID: 1742 RVA: 0x00039228 File Offset: 0x00037428
		private void RefreshRightBtnText()
		{
			HotFixBtnUiItem element = base.GetElement<HotFixBtnUiItem>(8);
			ETier localResourceQualityTier = HotFixManager.GetLocalResourceQualityTier();
			ETier selectResourceQualityTier = HotFixManager.SelectResourceQualityTier;
			long num = (this.SelectTabIndex >= 0) ? ResourceDiffUpdaterManager.Instance.GetResSize((EResUpdateType)this.SelectTabIndex, HotFixDownLoadView.GetSelectTier()) : 0L;
			if (HotFixManager.IsTierEnabled() && localResourceQualityTier != ETier.None && selectResourceQualityTier == localResourceQualityTier && num <= 0L)
			{
				element.SetText("ResourceQualityTier", Array.Empty<string>());
				return;
			}
			element.SetText("Download_DownLoadBtnText", Array.Empty<string>());
		}

		// Token: 0x0400040F RID: 1039
		private const long MB_SIZE = 1048576L;

		// Token: 0x04000410 RID: 1040
		private int SelectTabIndex = -1;

		// Token: 0x04000411 RID: 1041
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private HotFixLayout<HotFixDownLoadTabItem, IHotFixDownLoadTabItemData> HotFixTabLayout;

		// Token: 0x04000412 RID: 1042
		[Nullable(2)]
		private UUIExtendToggle CurrentSelectToggle;

		// Token: 0x04000413 RID: 1043
		[Nullable(2)]
		private UUIExtendToggle CurrentSelectResTierToggle;

		// Token: 0x04000414 RID: 1044
		private bool HasCapturedClearResourceQualityTier;

		// Token: 0x04000415 RID: 1045
		private ETier? ClearResourceQualityTier;

		// Token: 0x04000416 RID: 1046
		private readonly List<HotFixResTierItem> ResTierItems = new List<HotFixResTierItem>();

		// Token: 0x04000417 RID: 1047
		[Nullable(2)]
		public Action<bool> SetFreeSpaceTipsPopActiveCallBack;

		// Token: 0x04000418 RID: 1048
		[Nullable(2)]
		public Action<bool, Action> SetClearSubPackagePopActiveCallBack;

		// Token: 0x04000419 RID: 1049
		[Nullable(2)]
		public Action<EResUpdateType, ETier, ETier> ShowChangeTierPopupCallBack;

		// Token: 0x02000366 RID: 870
		[NullableContext(0)]
		private static class EComponentDefine
		{
			// Token: 0x04001176 RID: 4470
			public const int LayoutItem = 0;

			// Token: 0x04001177 RID: 4471
			public const int TabLayout = 1;

			// Token: 0x04001178 RID: 4472
			public const int TitleText = 2;

			// Token: 0x04001179 RID: 4473
			public const int DesText = 3;

			// Token: 0x0400117A RID: 4474
			public const int MemoryText = 4;

			// Token: 0x0400117B RID: 4475
			public const int DownLoadBar = 5;

			// Token: 0x0400117C RID: 4476
			public const int DownLoadBarTexture = 6;

			// Token: 0x0400117D RID: 4477
			public const int SpeedText = 7;

			// Token: 0x0400117E RID: 4478
			public const int RightBtnItem = 8;

			// Token: 0x0400117F RID: 4479
			public const int LeftBtnItem = 9;

			// Token: 0x04001180 RID: 4480
			public const int MainTitleText = 11;

			// Token: 0x04001181 RID: 4481
			public const int ScrollView = 12;

			// Token: 0x04001182 RID: 4482
			public const int ResTierItem0 = 13;

			// Token: 0x04001183 RID: 4483
			public const int ResTierItem1 = 14;
		}
	}
}

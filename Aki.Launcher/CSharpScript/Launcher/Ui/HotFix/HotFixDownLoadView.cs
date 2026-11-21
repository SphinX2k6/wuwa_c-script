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
	// Token: 0x020000D1 RID: 209
	[NullableContext(1)]
	[Nullable(0)]
	public class HotFixDownLoadView : LaunchComponentsAction
	{
		// Token: 0x060006D9 RID: 1753 RVA: 0x0003A518 File Offset: 0x00038718
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

		// Token: 0x060006DA RID: 1754 RVA: 0x0003A5B8 File Offset: 0x000387B8
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

		// Token: 0x060006DB RID: 1755 RVA: 0x0003A6F0 File Offset: 0x000388F0
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

		// Token: 0x060006DC RID: 1756 RVA: 0x0003A764 File Offset: 0x00038964
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

		// Token: 0x060006DD RID: 1757 RVA: 0x0003A7E4 File Offset: 0x000389E4
		protected override void OnHide()
		{
			HotPatchInputManager.Instance.UnRegisterInputAxis("手柄右摇杆垂直方向", new TInputAxis(this.InputAxis));
			HotPatchInputManager.Instance.UnRegisterInputAction("手柄左摇杆上", new TInputAction(this.InputAction));
			HotPatchInputManager.Instance.UnRegisterInputAction("手柄左摇杆下", new TInputAction(this.InputAction));
			HotPatchInputManager.Instance.UnRegisterInputAction("手柄左边上键", new TInputAction(this.InputAction));
			HotPatchInputManager.Instance.UnRegisterInputAction("手柄左边下键", new TInputAction(this.InputAction));
		}

		// Token: 0x060006DE RID: 1758 RVA: 0x0003A878 File Offset: 0x00038A78
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

		// Token: 0x060006DF RID: 1759 RVA: 0x0003AA28 File Offset: 0x00038C28
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

		// Token: 0x060006E0 RID: 1760 RVA: 0x0003AA50 File Offset: 0x00038C50
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

		// Token: 0x060006E1 RID: 1761 RVA: 0x0003ABAC File Offset: 0x00038DAC
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

		// Token: 0x060006E2 RID: 1762 RVA: 0x0003ABF3 File Offset: 0x00038DF3
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

		// Token: 0x060006E3 RID: 1763 RVA: 0x0003AC20 File Offset: 0x00038E20
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

		// Token: 0x060006E4 RID: 1764 RVA: 0x0003AC71 File Offset: 0x00038E71
		private void FocusPrev()
		{
			this.SelectTabIndexToggle(Math.Max(0, this.SelectTabIndex - 1 - 1));
		}

		// Token: 0x060006E5 RID: 1765 RVA: 0x0003AC89 File Offset: 0x00038E89
		private void FocusNext()
		{
			this.SelectTabIndexToggle(Math.Min(1, this.SelectTabIndex - 1 + 1));
		}

		// Token: 0x060006E6 RID: 1766 RVA: 0x0003ACA1 File Offset: 0x00038EA1
		private void SelectTabIndexToggle(int index)
		{
			((HotFixDownLoadTabItem)this.HotFixTabLayout.GetLayoutItemByIndex(index)).Select();
		}

		// Token: 0x060006E7 RID: 1767 RVA: 0x0003ACBC File Offset: 0x00038EBC
		private static ETier? GetSelectTier()
		{
			if (HotFixManager.SelectResourceQualityTier == ETier.None)
			{
				return null;
			}
			return new ETier?(HotFixManager.SelectResourceQualityTier);
		}

		// Token: 0x060006E8 RID: 1768 RVA: 0x0003ACE4 File Offset: 0x00038EE4
		public ETier? GetClearResourceQualityTier()
		{
			return this.ClearResourceQualityTier;
		}

		// Token: 0x060006E9 RID: 1769 RVA: 0x0003ACEC File Offset: 0x00038EEC
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

		// Token: 0x060006EA RID: 1770 RVA: 0x0003AD58 File Offset: 0x00038F58
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

		// Token: 0x0400043E RID: 1086
		private const long MB_SIZE = 1048576L;

		// Token: 0x0400043F RID: 1087
		private int SelectTabIndex = -1;

		// Token: 0x04000440 RID: 1088
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private HotFixLayout<HotFixDownLoadTabItem, IHotFixDownLoadTabItemData> HotFixTabLayout;

		// Token: 0x04000441 RID: 1089
		[Nullable(2)]
		private UUIExtendToggle CurrentSelectToggle;

		// Token: 0x04000442 RID: 1090
		[Nullable(2)]
		private UUIExtendToggle CurrentSelectResTierToggle;

		// Token: 0x04000443 RID: 1091
		private bool HasCapturedClearResourceQualityTier;

		// Token: 0x04000444 RID: 1092
		private ETier? ClearResourceQualityTier;

		// Token: 0x04000445 RID: 1093
		private readonly List<HotFixResTierItem> ResTierItems = new List<HotFixResTierItem>();

		// Token: 0x04000446 RID: 1094
		[Nullable(2)]
		public Action<bool> SetFreeSpaceTipsPopActiveCallBack;

		// Token: 0x04000447 RID: 1095
		[Nullable(2)]
		public Action<bool, Action> SetClearSubPackagePopActiveCallBack;

		// Token: 0x04000448 RID: 1096
		[Nullable(2)]
		public Action<EResUpdateType, ETier, ETier> ShowChangeTierPopupCallBack;

		// Token: 0x02000371 RID: 881
		[NullableContext(0)]
		private static class EComponentDefine
		{
			// Token: 0x040011D8 RID: 4568
			public const int LayoutItem = 0;

			// Token: 0x040011D9 RID: 4569
			public const int TabLayout = 1;

			// Token: 0x040011DA RID: 4570
			public const int TitleText = 2;

			// Token: 0x040011DB RID: 4571
			public const int DesText = 3;

			// Token: 0x040011DC RID: 4572
			public const int MemoryText = 4;

			// Token: 0x040011DD RID: 4573
			public const int DownLoadBar = 5;

			// Token: 0x040011DE RID: 4574
			public const int DownLoadBarTexture = 6;

			// Token: 0x040011DF RID: 4575
			public const int SpeedText = 7;

			// Token: 0x040011E0 RID: 4576
			public const int RightBtnItem = 8;

			// Token: 0x040011E1 RID: 4577
			public const int LeftBtnItem = 9;

			// Token: 0x040011E2 RID: 4578
			public const int MainTitleText = 11;

			// Token: 0x040011E3 RID: 4579
			public const int ScrollView = 12;

			// Token: 0x040011E4 RID: 4580
			public const int ResTierItem0 = 13;

			// Token: 0x040011E5 RID: 4581
			public const int ResTierItem1 = 14;
		}
	}
}

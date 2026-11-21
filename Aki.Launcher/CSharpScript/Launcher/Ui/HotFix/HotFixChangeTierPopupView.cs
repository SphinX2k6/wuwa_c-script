using System;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.DiffPatch.Update;
using CSharpScript.Launcher.Platform;
using CSharpScript.Launcher.Update.ResourceDiffUpdate;
using CSharpScript.Launcher.Util;

namespace CSharpScript.Launcher.Ui.HotFix
{
	// Token: 0x020000CF RID: 207
	public class HotFixChangeTierPopupView : HotFixPopupUiView
	{
		// Token: 0x060006CE RID: 1742 RVA: 0x00039FF8 File Offset: 0x000381F8
		public void ShowChangeTier(EResUpdateType resDownLoadType, ETier oldTier, ETier newTier)
		{
			if (this.IsCalculatingSize)
			{
				return;
			}
			this.IsCalculatingSize = true;
			try
			{
				this.DoShowChangeTier(resDownLoadType, oldTier, newTier);
			}
			catch (Exception ex)
			{
				LauncherLog instance = LauncherLog.Instance;
				string message = "切档弹窗计算/刷新异常，返回下载界面";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("err", ex.ToString());
				instance.Error(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				this.CloseAndBackToDownLoad();
			}
			finally
			{
				this.IsCalculatingSize = false;
			}
		}

		// Token: 0x060006CF RID: 1743 RVA: 0x0003A074 File Offset: 0x00038274
		private unsafe void DoShowChangeTier(EResUpdateType resDownLoadType, ETier oldTier, ETier newTier)
		{
			string resourceQualityTierName = HotFixManager.GetResourceQualityTierName(oldTier);
			string resourceQualityTierName2 = HotFixManager.GetResourceQualityTierName(newTier);
			long resourceQualityTierInstalledSize = HotFixManager.GetResourceQualityTierInstalledSize(oldTier);
			long resSize = ResourceDiffUpdaterManager.Instance.GetResSize(resDownLoadType, new ETier?(newTier));
			long num = VideoResUpdate.Instance.GetFreeSpace() + resourceQualityTierInstalledSize;
			base.SetConfirmationTitle(EHotFixTextId.HotFixTipsTitle.ToString());
			base.SetConfirmationCloseButtonActive(true);
			base.SetConfirmationCloseButtonCallBack(delegate
			{
				this.CloseAndBackToDownLoad();
			});
			if (num < resSize)
			{
				string text = HotFixManager.ByteToGbNumber(resSize - resourceQualityTierInstalledSize);
				base.SetConfirmationContent("ResourceQualityTier_ChangeTierSpaceTips", new string[]
				{
					resourceQualityTierName,
					resourceQualityTierName2,
					text
				});
				base.SetConfirmationLeftButtonActive(false);
				base.SetConfirmationRightButtonActive(false);
				base.SetConfirmationMiddleButtonActive(true);
				base.SetConfirmationMiddleButtonText("ConfirmText");
				base.SetConfirmationMiddleButtonCallBack(delegate
				{
					this.CloseAndBackToDownLoad();
				});
			}
			else
			{
				string text2 = HotFixManager.ByteToGbNumber(resourceQualityTierInstalledSize);
				string text3 = HotFixManager.ByteToGbNumber(resSize);
				base.SetConfirmationContent("ResourceQualityTier_ChangeTierSpaceTips2", new string[]
				{
					resourceQualityTierName,
					resourceQualityTierName2,
					text2,
					text3
				});
				base.SetConfirmationMiddleButtonActive(false);
				base.SetConfirmationLeftButtonActive(true);
				base.SetConfirmationRightButtonActive(true);
				base.SetConfirmationLeftButtonText(EHotFixTextId.HotFixCancel.ToString());
				base.SetConfirmationRightButtonText("ConfirmText");
				base.SetConfirmationLeftButtonCallBack(delegate
				{
					this.CloseAndBackToDownLoad();
				});
				base.SetConfirmationRightButtonCallBack(delegate
				{
					LauncherLog instance = LauncherLog.Instance;
					string message = "HotFixChangeTierPopupView-确定切换档位";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("oldTier", oldTier);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("newTier", newTier);
					instance.Info(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
					if (Platform.Instance.IsWindowsOnlyPlatform())
					{
						LauncherLog.Instance.Error("HotFixChangeTierPopupView-Windows不应在游戏内切换资源档位或包体类型", default(ReadOnlySpan<ValueTuple<string, object>>));
					}
					LauncherPackageStateLib.SetSavedPackageType(newTier, resDownLoadType);
					LauncherStorageLib.Instance.SetDeviceSaved<ETier>(ELauncherStorageDeviceKey.ResourceQualityTier, newTier);
					this.SetActive(false);
					Action<ETier, ETier> applyTierChangeHandler = HotFixManager.ApplyTierChangeHandler;
					if (applyTierChangeHandler == null)
					{
						return;
					}
					applyTierChangeHandler(oldTier, newTier);
				});
			}
			base.SetActive(true);
		}

		// Token: 0x060006D0 RID: 1744 RVA: 0x0003A218 File Offset: 0x00038418
		private void CloseAndBackToDownLoad()
		{
			base.SetActive(false);
			Action<bool> setDownLoadActiveCallBack = this.SetDownLoadActiveCallBack;
			if (setDownLoadActiveCallBack == null)
			{
				return;
			}
			setDownLoadActiveCallBack(true);
		}

		// Token: 0x04000438 RID: 1080
		[Nullable(2)]
		public Action<bool> SetDownLoadActiveCallBack;

		// Token: 0x04000439 RID: 1081
		private bool IsCalculatingSize;
	}
}

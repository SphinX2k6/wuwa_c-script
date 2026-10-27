using System;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.DiffPatch.Update;
using CSharpScript.Launcher.Update.ResourceDiffUpdate;
using CSharpScript.Launcher.Util;

namespace CSharpScript.Launcher.Ui.HotFix
{
	// Token: 0x020000CC RID: 204
	public class HotFixChangeTierPopupView : HotFixPopupUiView
	{
		// Token: 0x060006B2 RID: 1714 RVA: 0x000384C8 File Offset: 0x000366C8
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

		// Token: 0x060006B3 RID: 1715 RVA: 0x00038544 File Offset: 0x00036744
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
					LauncherStorageLib.Instance.SetDeviceSaved<EResUpdateType>(ELauncherStorageDeviceKey.SelectedMaxOrMinPackType, resDownLoadType);
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

		// Token: 0x060006B4 RID: 1716 RVA: 0x000386E8 File Offset: 0x000368E8
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

		// Token: 0x04000409 RID: 1033
		[Nullable(2)]
		public Action<bool> SetDownLoadActiveCallBack;

		// Token: 0x0400040A RID: 1034
		private bool IsCalculatingSize;
	}
}

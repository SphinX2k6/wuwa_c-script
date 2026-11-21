using System;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.DiffPatch.Update;
using CSharpScript.Launcher.Update.ResourceDiffUpdate;
using UnrealEngine;

namespace CSharpScript.Launcher.Ui.HotFix
{
	// Token: 0x020000D0 RID: 208
	public class HotFixDownLoadFreeSpaceTipsView : LaunchComponentsAction
	{
		// Token: 0x060006D2 RID: 1746 RVA: 0x0003A23C File Offset: 0x0003843C
		protected override void OnStart()
		{
			base.AttachElement<HotFixBtnUiItem>(2).BindClickCallback(new Action(this.OnCancelBtnClick));
			base.AttachElement<HotFixBtnUiItem>(3).BindClickCallback(new Action(this.OnConfirmBtnClick));
			HotFixManager.SetLocalText(base.GetText(5), "Download_NoSpace", Array.Empty<string>());
			HotFixManager.SetLocalText(base.GetText(6), "Download_Retry", Array.Empty<string>());
			HotFixManager.SetLocalText(base.GetText(8), "Download_DownLoadBtnRetry", Array.Empty<string>());
		}

		// Token: 0x060006D3 RID: 1747 RVA: 0x0003A2BC File Offset: 0x000384BC
		private void OnCancelBtnClick()
		{
			base.SetActive(false);
			LauncherLog.Instance.Info("HotFixDownLoadFreeSpaceTipsView CancelBtn", default(ReadOnlySpan<ValueTuple<string, object>>));
			if (this.CanClearSpaceSize > 0L && ResourceDiffUpdaterManager.Instance.IsGrayBoxHit())
			{
				if (this.SetClearSubPackagePopActiveCallBack != null)
				{
					this.SetClearSubPackagePopActiveCallBack(true, delegate
					{
						base.SetActive(true);
					});
				}
				int canCleanUpSpace = (int)(this.CanClearSpaceSize / 1048576L);
				FLoginStruct loginData = HotFixManager.LoginData;
				new InitialMobileResCleanUpViewStateLog(canCleanUpSpace, ((loginData != null) ? loginData.Uid : null) ?? "", ResourceDiffUpdaterManager.Instance.TraceId.ToString(), 2, null).Report();
				return;
			}
			if (this.SetDownLoadActiveCallBack != null)
			{
				this.SetDownLoadActiveCallBack(true);
			}
		}

		// Token: 0x060006D4 RID: 1748 RVA: 0x0003A378 File Offset: 0x00038578
		private void OnConfirmBtnClick()
		{
			LauncherLog.Instance.Info("HotFixDownLoadFreeSpaceTipsView ConfirmBtn", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.RefreshView();
			long freeSpace = VideoResUpdate.Instance.GetFreeSpace();
			long needDownLoadByte = HotFixManager.NeedDownLoadByte;
			if (freeSpace > needDownLoadByte)
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
				base.SetActive(false);
				return;
			}
			this.RefreshView();
		}

		// Token: 0x060006D5 RID: 1749 RVA: 0x0003A3E4 File Offset: 0x000385E4
		protected override void OnShow()
		{
			this.RefreshView();
			this.CanClearSpaceSize = HotFixManager.GetAllCanClearSpace();
			HotFixBtnUiItem element = base.GetElement<HotFixBtnUiItem>(2);
			base.GetButton(2).SetSelfInteractive(this.CanClearSpaceSize > 0L);
			if (this.CanClearSpaceSize > 0L && ResourceDiffUpdaterManager.Instance.IsGrayBoxHit())
			{
				element.SetText("HotFixSubPackageClearButton_Out", new string[]
				{
					HotFixManager.ByteConverter(this.CanClearSpaceSize)
				});
				int remainingSpace = (int)(this.CanClearSpaceSize / 1048576L);
				FLoginStruct loginData = HotFixManager.LoginData;
				new StorageAlertLog(remainingSpace, ((loginData != null) ? loginData.Uid : null) ?? "", null).Report();
				return;
			}
			element.SetText("HotFixSubPackageHaveNoSpaceClear", Array.Empty<string>());
		}

		// Token: 0x060006D6 RID: 1750 RVA: 0x0003A49C File Offset: 0x0003869C
		private void RefreshView()
		{
			HotFixManager.SetLocalText(base.GetText(0), "DownLoadText_NeedSpace", new string[]
			{
				HotFixManager.ByteConverter(HotFixManager.NeedDownLoadByte)
			});
			long freeSpace = VideoResUpdate.Instance.GetFreeSpace();
			HotFixManager.SetLocalText(base.GetText(1), "DownLoadText_LeftSpace", new string[]
			{
				"<color=#c25757>" + HotFixManager.ByteConverter(freeSpace) + "</color>"
			});
		}

		// Token: 0x0400043A RID: 1082
		private const long MB_SIZE = 1048576L;

		// Token: 0x0400043B RID: 1083
		[Nullable(2)]
		public Action<bool> SetDownLoadActiveCallBack;

		// Token: 0x0400043C RID: 1084
		[Nullable(2)]
		public Action<bool, Action> SetClearSubPackagePopActiveCallBack;

		// Token: 0x0400043D RID: 1085
		private long CanClearSpaceSize;

		// Token: 0x02000370 RID: 880
		private static class EComponentDefine
		{
			// Token: 0x040011CF RID: 4559
			public const int NeedSpaceText = 0;

			// Token: 0x040011D0 RID: 4560
			public const int LeftSpaceText = 1;

			// Token: 0x040011D1 RID: 4561
			public const int CancelBtn = 2;

			// Token: 0x040011D2 RID: 4562
			public const int ConfirmBtn = 3;

			// Token: 0x040011D3 RID: 4563
			public const int BackBtn = 4;

			// Token: 0x040011D4 RID: 4564
			public const int TitleText = 5;

			// Token: 0x040011D5 RID: 4565
			public const int DesText = 6;

			// Token: 0x040011D6 RID: 4566
			public const int CancelText = 7;

			// Token: 0x040011D7 RID: 4567
			public const int ConfirmText = 8;
		}
	}
}

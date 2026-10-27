using System;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.DiffPatch.Update;
using CSharpScript.Launcher.Update.ResourceDiffUpdate;
using UnrealEngine;

namespace CSharpScript.Launcher.Ui.HotFix
{
	// Token: 0x020000CD RID: 205
	public class HotFixDownLoadFreeSpaceTipsView : LaunchComponentsAction
	{
		// Token: 0x060006B6 RID: 1718 RVA: 0x0003870C File Offset: 0x0003690C
		protected override void OnStart()
		{
			base.AttachElement<HotFixBtnUiItem>(2).BindClickCallback(new Action(this.OnCancelBtnClick));
			base.AttachElement<HotFixBtnUiItem>(3).BindClickCallback(new Action(this.OnConfirmBtnClick));
			HotFixManager.SetLocalText(base.GetText(5), "Download_NoSpace", Array.Empty<string>());
			HotFixManager.SetLocalText(base.GetText(6), "Download_Retry", Array.Empty<string>());
			HotFixManager.SetLocalText(base.GetText(8), "Download_DownLoadBtnRetry", Array.Empty<string>());
		}

		// Token: 0x060006B7 RID: 1719 RVA: 0x0003878C File Offset: 0x0003698C
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

		// Token: 0x060006B8 RID: 1720 RVA: 0x00038848 File Offset: 0x00036A48
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

		// Token: 0x060006B9 RID: 1721 RVA: 0x000388B4 File Offset: 0x00036AB4
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

		// Token: 0x060006BA RID: 1722 RVA: 0x0003896C File Offset: 0x00036B6C
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

		// Token: 0x0400040B RID: 1035
		private const long MB_SIZE = 1048576L;

		// Token: 0x0400040C RID: 1036
		[Nullable(2)]
		public Action<bool> SetDownLoadActiveCallBack;

		// Token: 0x0400040D RID: 1037
		[Nullable(2)]
		public Action<bool, Action> SetClearSubPackagePopActiveCallBack;

		// Token: 0x0400040E RID: 1038
		private long CanClearSpaceSize;

		// Token: 0x02000365 RID: 869
		private static class EComponentDefine
		{
			// Token: 0x0400116D RID: 4461
			public const int NeedSpaceText = 0;

			// Token: 0x0400116E RID: 4462
			public const int LeftSpaceText = 1;

			// Token: 0x0400116F RID: 4463
			public const int CancelBtn = 2;

			// Token: 0x04001170 RID: 4464
			public const int ConfirmBtn = 3;

			// Token: 0x04001171 RID: 4465
			public const int BackBtn = 4;

			// Token: 0x04001172 RID: 4466
			public const int TitleText = 5;

			// Token: 0x04001173 RID: 4467
			public const int DesText = 6;

			// Token: 0x04001174 RID: 4468
			public const int CancelText = 7;

			// Token: 0x04001175 RID: 4469
			public const int ConfirmText = 8;
		}
	}
}

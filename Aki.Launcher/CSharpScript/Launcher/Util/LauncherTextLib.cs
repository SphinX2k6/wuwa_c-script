using System;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Define;
using CSharpScript.Launcher.Download;

namespace CSharpScript.Launcher.Util
{
	// Token: 0x02000075 RID: 117
	[NullableContext(1)]
	[Nullable(0)]
	public static class LauncherTextLib
	{
		// Token: 0x0600031F RID: 799 RVA: 0x00010DE0 File Offset: 0x0000EFE0
		public static string DownloadSpeedFormat(long speedBps)
		{
			if (speedBps < 1024L)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 1);
				defaultInterpolatedStringHandler.AppendFormatted<long>(speedBps);
				defaultInterpolatedStringHandler.AppendLiteral("B/s");
				return defaultInterpolatedStringHandler.ToStringAndClear();
			}
			if (speedBps < 1048576L)
			{
				return ((double)speedBps / 1024.0).ToString("F1") + "KB/s";
			}
			return ((double)speedBps / 1024.0 / 1024.0).ToString("F1") + "MB/s";
		}

		// Token: 0x06000320 RID: 800 RVA: 0x00010E78 File Offset: 0x0000F078
		public static string SpaceSizeFormat(long size)
		{
			if (size < 1024L)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
				defaultInterpolatedStringHandler.AppendFormatted<long>(size);
				defaultInterpolatedStringHandler.AppendLiteral("B");
				return defaultInterpolatedStringHandler.ToStringAndClear();
			}
			if (size < 1048576L)
			{
				return ((double)size / 1024.0).ToString("F2") + "K";
			}
			if (size < 1073741824L)
			{
				return ((double)size / 1048576.0).ToString("F2") + "M";
			}
			return ((double)size / 1073741824.0).ToString("F2") + "G";
		}

		// Token: 0x06000321 RID: 801 RVA: 0x00010F30 File Offset: 0x0000F130
		public static string DownloadStateFormat(EDownloadState state)
		{
			switch (state)
			{
			case EDownloadState.None:
				return LauncherConfigLib.Instance.GetHotPatchText("DownloadStateNone");
			case EDownloadState.HttpError:
				return LauncherConfigLib.Instance.GetHotPatchText("DownloadStateHttpError");
			case EDownloadState.FileRenameError:
				return LauncherConfigLib.Instance.GetHotPatchText("DownloadStateFileRenameError");
			case EDownloadState.ValidateError:
				return LauncherConfigLib.Instance.GetHotPatchText("DownloadStateValidateError");
			case EDownloadState.OpenToWriteError:
				return LauncherConfigLib.Instance.GetHotPatchText("DownloadStateOpenToWriteError");
			case EDownloadState.NotEnoughSpace:
				return LauncherConfigLib.Instance.GetHotPatchText("DownloadStateNotEnoughSpace");
			case EDownloadState.DownloadCanceled:
				return LauncherConfigLib.Instance.GetHotPatchText("DownloadStateDownloadCanceled");
			case EDownloadState.Success:
				return LauncherConfigLib.Instance.GetHotPatchText("DownloadStateSuccess");
			default:
				return "";
			}
		}

		// Token: 0x04000240 RID: 576
		public const long BigIntKb = 1024L;

		// Token: 0x04000241 RID: 577
		public const long BigIntMb = 1048576L;

		// Token: 0x04000242 RID: 578
		public const long BigIntGb = 1073741824L;

		// Token: 0x04000243 RID: 579
		public const int NUMBER_KB = 1024;

		// Token: 0x04000244 RID: 580
		public const int NUMBER_MB = 1048576;

		// Token: 0x04000245 RID: 581
		public const int NUMBER_GB = 1073741824;
	}
}

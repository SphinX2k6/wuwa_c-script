using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.IO
{
	// Token: 0x02000853 RID: 2131
	internal static class Win32Marshal
	{
		// Token: 0x0600878C RID: 34700 RVA: 0x00148130 File Offset: 0x00146330
		internal static Exception GetExceptionForLastWin32Error(string path = "")
		{
			return Win32Marshal.GetExceptionForWin32Error(Marshal.GetLastPInvokeError(), path, null);
		}

		// Token: 0x0600878D RID: 34701 RVA: 0x00148140 File Offset: 0x00146340
		internal static Exception GetExceptionForWin32Error(int errorCode, string path = "", string errorDetails = null)
		{
			if (errorCode <= 80)
			{
				switch (errorCode)
				{
				case 2:
					return new FileNotFoundException(string.IsNullOrEmpty(path) ? SR.IO_FileNotFound : SR.Format(SR.IO_FileNotFound_FileName, path), path);
				case 3:
					return new DirectoryNotFoundException(string.IsNullOrEmpty(path) ? SR.IO_PathNotFound_NoPathName : SR.Format(SR.IO_PathNotFound_Path, path));
				case 4:
					break;
				case 5:
					return new UnauthorizedAccessException(string.IsNullOrEmpty(path) ? SR.UnauthorizedAccess_IODenied_NoPathName : SR.Format(SR.UnauthorizedAccess_IODenied_Path, path));
				default:
					if (errorCode == 32)
					{
						return new IOException(string.IsNullOrEmpty(path) ? SR.IO_SharingViolation_NoFileName : SR.Format(SR.IO_SharingViolation_File, path), Win32Marshal.MakeHRFromErrorCode(errorCode));
					}
					if (errorCode == 80)
					{
						if (!string.IsNullOrEmpty(path))
						{
							return new IOException(SR.Format(SR.IO_FileExists_Name, path), Win32Marshal.MakeHRFromErrorCode(errorCode));
						}
					}
					break;
				}
			}
			else if (errorCode <= 183)
			{
				if (errorCode != 87)
				{
					if (errorCode == 183)
					{
						if (!string.IsNullOrEmpty(path))
						{
							return new IOException(SR.Format(SR.IO_AlreadyExists_Name, path), Win32Marshal.MakeHRFromErrorCode(errorCode));
						}
					}
				}
			}
			else
			{
				if (errorCode == 206)
				{
					return new PathTooLongException(string.IsNullOrEmpty(path) ? SR.IO_PathTooLong : SR.Format(SR.IO_PathTooLong_Path, path));
				}
				if (errorCode == 995)
				{
					return new OperationCanceledException();
				}
			}
			string text = Win32Marshal.<GetExceptionForWin32Error>g__GetPInvokeErrorMessage|1_0(errorCode);
			if (!string.IsNullOrEmpty(path))
			{
				text = text + " : '" + path + "'.";
			}
			if (!string.IsNullOrEmpty(errorDetails))
			{
				text = text + " " + errorDetails;
			}
			return new IOException(text, Win32Marshal.MakeHRFromErrorCode(errorCode));
		}

		// Token: 0x0600878E RID: 34702 RVA: 0x001482EA File Offset: 0x001464EA
		internal static int MakeHRFromErrorCode(int errorCode)
		{
			if (((ulong)-65536 & (ulong)((long)errorCode)) != 0UL)
			{
				return errorCode;
			}
			return -2147024896 | errorCode;
		}

		// Token: 0x0600878F RID: 34703 RVA: 0x00148300 File Offset: 0x00146500
		internal static int TryMakeWin32ErrorCodeFromHR(int hr)
		{
			if (((ulong)-65536 & (ulong)((long)hr)) == (ulong)-2147024896)
			{
				hr &= 65535;
			}
			return hr;
		}

		// Token: 0x06008790 RID: 34704 RVA: 0x0010C43D File Offset: 0x0010A63D
		[CompilerGenerated]
		internal static string <GetExceptionForWin32Error>g__GetPInvokeErrorMessage|1_0(int errorCode)
		{
			return Interop.Kernel32.GetMessage(errorCode);
		}
	}
}

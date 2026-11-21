using System;
using System.Buffers;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace System.IO
{
	// Token: 0x020007FB RID: 2043
	internal static class FileSystem
	{
		// Token: 0x060082CC RID: 33484 RVA: 0x0013763E File Offset: 0x0013583E
		internal static void VerifyValidPath(string path, string argName)
		{
			ArgumentException.ThrowIfNullOrEmpty(path, argName);
			if (path.Contains('\0'))
			{
				throw new ArgumentException(SR.Argument_NullCharInPath, argName);
			}
		}

		// Token: 0x060082CD RID: 33485 RVA: 0x0013765C File Offset: 0x0013585C
		internal static void MoveDirectory(string sourceFullPath, string destFullPath)
		{
			ReadOnlySpan<char> readOnlySpan = Path.TrimEndingDirectorySeparator(sourceFullPath.AsSpan());
			ReadOnlySpan<char> readOnlySpan2 = Path.TrimEndingDirectorySeparator(destFullPath.AsSpan());
			bool _ = false;
			if (readOnlySpan.Equals(readOnlySpan2, StringComparison.OrdinalIgnoreCase))
			{
				if (Path.GetFileName(readOnlySpan).SequenceEqual(Path.GetFileName(readOnlySpan2)))
				{
					throw new IOException(SR.IO_SourceDestMustBeDifferent);
				}
				_ = true;
			}
			FileSystem.MoveDirectory(sourceFullPath, destFullPath, _);
		}

		// Token: 0x060082CE RID: 33486 RVA: 0x001376B8 File Offset: 0x001358B8
		public static bool DirectoryExists(string fullPath)
		{
			int num;
			return FileSystem.DirectoryExists(fullPath, out num);
		}

		// Token: 0x060082CF RID: 33487 RVA: 0x001376D0 File Offset: 0x001358D0
		private static bool DirectoryExists(string path, out int lastError)
		{
			Interop.Kernel32.WIN32_FILE_ATTRIBUTE_DATA win32_FILE_ATTRIBUTE_DATA = default(Interop.Kernel32.WIN32_FILE_ATTRIBUTE_DATA);
			lastError = FileSystem.FillAttributeInfo(path, ref win32_FILE_ATTRIBUTE_DATA, true);
			return lastError == 0 && win32_FILE_ATTRIBUTE_DATA.dwFileAttributes != -1 && (win32_FILE_ATTRIBUTE_DATA.dwFileAttributes & 16) != 0;
		}

		// Token: 0x060082D0 RID: 33488 RVA: 0x0013770C File Offset: 0x0013590C
		public static bool FileExists(string fullPath)
		{
			Interop.Kernel32.WIN32_FILE_ATTRIBUTE_DATA win32_FILE_ATTRIBUTE_DATA = default(Interop.Kernel32.WIN32_FILE_ATTRIBUTE_DATA);
			return FileSystem.FillAttributeInfo(fullPath, ref win32_FILE_ATTRIBUTE_DATA, true) == 0 && win32_FILE_ATTRIBUTE_DATA.dwFileAttributes != -1 && (win32_FILE_ATTRIBUTE_DATA.dwFileAttributes & 16) == 0;
		}

		// Token: 0x060082D1 RID: 33489 RVA: 0x00137744 File Offset: 0x00135944
		internal static int FillAttributeInfo(string path, ref Interop.Kernel32.WIN32_FILE_ATTRIBUTE_DATA data, bool returnErrorOnNotFound)
		{
			int num = 0;
			path = PathInternal.TrimEndingDirectorySeparator(path);
			using (DisableMediaInsertionPrompt.Create())
			{
				if (!Interop.Kernel32.GetFileAttributesEx(path, Interop.Kernel32.GET_FILEEX_INFO_LEVELS.GetFileExInfoStandard, ref data))
				{
					num = Marshal.GetLastPInvokeError();
					if (!FileSystem.IsPathUnreachableError(num))
					{
						Interop.Kernel32.WIN32_FIND_DATA win32_FIND_DATA = default(Interop.Kernel32.WIN32_FIND_DATA);
						using (SafeFindHandle safeFindHandle = Interop.Kernel32.FindFirstFile(path, ref win32_FIND_DATA))
						{
							if (safeFindHandle.IsInvalid)
							{
								num = Marshal.GetLastPInvokeError();
							}
							else
							{
								num = 0;
								data.PopulateFrom(ref win32_FIND_DATA);
							}
						}
					}
				}
			}
			if (num != 0 && !returnErrorOnNotFound && (num - 2 <= 1 || num == 21))
			{
				data.dwFileAttributes = -1;
				return 0;
			}
			return num;
		}

		// Token: 0x060082D2 RID: 33490 RVA: 0x001377F8 File Offset: 0x001359F8
		internal static bool IsPathUnreachableError(int errorCode)
		{
			if (errorCode <= 65)
			{
				if (errorCode <= 6)
				{
					if (errorCode - 2 > 1 && errorCode != 6)
					{
						goto IL_58;
					}
				}
				else if (errorCode != 21 && errorCode != 53 && errorCode != 65)
				{
					goto IL_58;
				}
			}
			else if (errorCode <= 123)
			{
				if (errorCode != 67 && errorCode != 87 && errorCode != 123)
				{
					goto IL_58;
				}
			}
			else if (errorCode != 161 && errorCode != 206 && errorCode != 1231)
			{
				goto IL_58;
			}
			return true;
			IL_58:
			return false;
		}

		// Token: 0x060082D3 RID: 33491 RVA: 0x00137860 File Offset: 0x00135A60
		public unsafe static void CreateDirectory(string fullPath, byte[] securityDescriptor = null)
		{
			if (FileSystem.DirectoryExists(fullPath))
			{
				return;
			}
			List<string> list = new List<string>();
			bool flag = false;
			int num = fullPath.Length;
			if (num >= 2 && PathInternal.EndsInDirectorySeparator(fullPath.AsSpan()))
			{
				num--;
			}
			int rootLength = PathInternal.GetRootLength(fullPath.AsSpan());
			if (num > rootLength)
			{
				int num2 = num - 1;
				while (num2 >= rootLength && !flag)
				{
					string text = fullPath.Substring(0, num2 + 1);
					if (!FileSystem.DirectoryExists(text))
					{
						list.Add(text);
					}
					else
					{
						flag = true;
					}
					while (num2 > rootLength && !PathInternal.IsDirectorySeparator(fullPath[num2]))
					{
						num2--;
					}
					num2--;
				}
			}
			int count = list.Count;
			bool flag2 = true;
			int num3 = 0;
			string path = fullPath;
			fixed (byte[] array = securityDescriptor)
			{
				byte* lpSecurityDescriptor;
				if (securityDescriptor == null || array.Length == 0)
				{
					lpSecurityDescriptor = null;
				}
				else
				{
					lpSecurityDescriptor = &array[0];
				}
				Interop.Kernel32.SECURITY_ATTRIBUTES security_ATTRIBUTES = new Interop.Kernel32.SECURITY_ATTRIBUTES
				{
					nLength = (uint)sizeof(Interop.Kernel32.SECURITY_ATTRIBUTES),
					lpSecurityDescriptor = (void*)lpSecurityDescriptor
				};
				while (list.Count > 0)
				{
					List<string> list2 = list;
					string text2 = list2[list2.Count - 1];
					list.RemoveAt(list.Count - 1);
					flag2 = Interop.Kernel32.CreateDirectory(text2, &security_ATTRIBUTES);
					if (!flag2 && num3 == 0)
					{
						int lastPInvokeError = Marshal.GetLastPInvokeError();
						if (lastPInvokeError != 183)
						{
							num3 = lastPInvokeError;
						}
						else if (FileSystem.FileExists(text2) || (!FileSystem.DirectoryExists(text2, out lastPInvokeError) && lastPInvokeError == 5))
						{
							num3 = lastPInvokeError;
							path = text2;
						}
					}
				}
			}
			if (count == 0 && !flag)
			{
				string pathRoot = Path.GetPathRoot(fullPath);
				if (!FileSystem.DirectoryExists(pathRoot))
				{
					throw Win32Marshal.GetExceptionForWin32Error(3, pathRoot, null);
				}
				return;
			}
			else
			{
				if (!flag2 && num3 != 0)
				{
					throw Win32Marshal.GetExceptionForWin32Error(num3, path, null);
				}
				return;
			}
		}

		// Token: 0x060082D4 RID: 33492 RVA: 0x001379FC File Offset: 0x00135BFC
		public static void Encrypt(string path)
		{
			string fullPath = Path.GetFullPath(path);
			if (!Interop.Advapi32.EncryptFile(fullPath))
			{
				FileSystem.ThrowExceptionEncryptDecryptFail(fullPath);
			}
		}

		// Token: 0x060082D5 RID: 33493 RVA: 0x00137A20 File Offset: 0x00135C20
		public static void Decrypt(string path)
		{
			string fullPath = Path.GetFullPath(path);
			if (!Interop.Advapi32.DecryptFile(fullPath))
			{
				FileSystem.ThrowExceptionEncryptDecryptFail(fullPath);
			}
		}

		// Token: 0x060082D6 RID: 33494 RVA: 0x00137A44 File Offset: 0x00135C44
		private static void ThrowExceptionEncryptDecryptFail(string fullPath)
		{
			int lastPInvokeError = Marshal.GetLastPInvokeError();
			if (lastPInvokeError == 5)
			{
				string text = DriveInfoInternal.NormalizeDriveName(Path.GetPathRoot(fullPath));
				using (DisableMediaInsertionPrompt.Create())
				{
					int num;
					if (!Interop.Kernel32.GetVolumeInformation(text, null, 0, null, null, out num, null, 0))
					{
						lastPInvokeError = Marshal.GetLastPInvokeError();
						throw Win32Marshal.GetExceptionForWin32Error(lastPInvokeError, text, null);
					}
					if (((long)num & 131072L) == 0L)
					{
						throw new NotSupportedException(SR.PlatformNotSupported_FileEncryption);
					}
				}
			}
			throw Win32Marshal.GetExceptionForWin32Error(lastPInvokeError, fullPath, null);
		}

		// Token: 0x060082D7 RID: 33495 RVA: 0x00137AD0 File Offset: 0x00135CD0
		public static void CopyFile(string sourceFullPath, string destFullPath, bool overwrite)
		{
			int num = Interop.Kernel32.CopyFile(sourceFullPath, destFullPath, !overwrite);
			if (num != 0)
			{
				string path = destFullPath;
				if (num != 80)
				{
					using (SafeFileHandle safeFileHandle = Interop.Kernel32.CreateFile(sourceFullPath, int.MinValue, FileShare.Read, FileMode.Open, 0))
					{
						if (safeFileHandle.IsInvalid)
						{
							path = sourceFullPath;
						}
					}
					if (num == 5 && FileSystem.DirectoryExists(destFullPath))
					{
						throw new IOException(SR.Format(SR.Arg_FileIsDirectory_Name, destFullPath), 5);
					}
				}
				throw Win32Marshal.GetExceptionForWin32Error(num, path, null);
			}
		}

		// Token: 0x060082D8 RID: 33496 RVA: 0x00137B50 File Offset: 0x00135D50
		public static void ReplaceFile(string sourceFullPath, string destFullPath, string destBackupFullPath, bool ignoreMetadataErrors)
		{
			int dwReplaceFlags = ignoreMetadataErrors ? 2 : 0;
			if (!Interop.Kernel32.ReplaceFile(destFullPath, sourceFullPath, destBackupFullPath, dwReplaceFlags, IntPtr.Zero, IntPtr.Zero))
			{
				throw Win32Marshal.GetExceptionForWin32Error(Marshal.GetLastPInvokeError(), "", null);
			}
		}

		// Token: 0x060082D9 RID: 33497 RVA: 0x00137B8C File Offset: 0x00135D8C
		public static void DeleteFile(string fullPath)
		{
			if (Interop.Kernel32.DeleteFile(fullPath))
			{
				return;
			}
			int lastPInvokeError = Marshal.GetLastPInvokeError();
			if (lastPInvokeError == 2)
			{
				return;
			}
			throw Win32Marshal.GetExceptionForWin32Error(lastPInvokeError, fullPath, null);
		}

		// Token: 0x060082DA RID: 33498 RVA: 0x00137BB5 File Offset: 0x00135DB5
		public static FileAttributes GetAttributes(string fullPath)
		{
			return (FileAttributes)FileSystem.GetAttributeData(fullPath, true).dwFileAttributes;
		}

		// Token: 0x060082DB RID: 33499 RVA: 0x00137BC3 File Offset: 0x00135DC3
		public static FileAttributes GetAttributes(SafeFileHandle fileHandle)
		{
			return (FileAttributes)FileSystem.GetAttributeData(fileHandle).dwFileAttributes;
		}

		// Token: 0x060082DC RID: 33500 RVA: 0x00137BD0 File Offset: 0x00135DD0
		public static DateTimeOffset GetCreationTime(string fullPath)
		{
			return FileSystem.GetAttributeData(fullPath, false).ftCreationTime.ToDateTimeOffset();
		}

		// Token: 0x060082DD RID: 33501 RVA: 0x00137BF4 File Offset: 0x00135DF4
		public static DateTimeOffset GetCreationTime(SafeFileHandle fileHandle)
		{
			return FileSystem.GetAttributeData(fileHandle).ftCreationTime.ToDateTimeOffset();
		}

		// Token: 0x060082DE RID: 33502 RVA: 0x00137C14 File Offset: 0x00135E14
		public static DateTimeOffset GetLastAccessTime(string fullPath)
		{
			return FileSystem.GetAttributeData(fullPath, false).ftLastAccessTime.ToDateTimeOffset();
		}

		// Token: 0x060082DF RID: 33503 RVA: 0x00137C38 File Offset: 0x00135E38
		public static DateTimeOffset GetLastAccessTime(SafeFileHandle fileHandle)
		{
			return FileSystem.GetAttributeData(fileHandle).ftLastAccessTime.ToDateTimeOffset();
		}

		// Token: 0x060082E0 RID: 33504 RVA: 0x00137C58 File Offset: 0x00135E58
		public static DateTimeOffset GetLastWriteTime(string fullPath)
		{
			return FileSystem.GetAttributeData(fullPath, false).ftLastWriteTime.ToDateTimeOffset();
		}

		// Token: 0x060082E1 RID: 33505 RVA: 0x00137C7C File Offset: 0x00135E7C
		public static DateTimeOffset GetLastWriteTime(SafeFileHandle fileHandle)
		{
			return FileSystem.GetAttributeData(fileHandle).ftLastWriteTime.ToDateTimeOffset();
		}

		// Token: 0x060082E2 RID: 33506 RVA: 0x00137C9C File Offset: 0x00135E9C
		internal static Interop.Kernel32.WIN32_FILE_ATTRIBUTE_DATA GetAttributeData(string fullPath, bool returnErrorOnNotFound = false)
		{
			Interop.Kernel32.WIN32_FILE_ATTRIBUTE_DATA result = default(Interop.Kernel32.WIN32_FILE_ATTRIBUTE_DATA);
			int num = FileSystem.FillAttributeInfo(fullPath, ref result, returnErrorOnNotFound);
			if (num == 0)
			{
				return result;
			}
			throw Win32Marshal.GetExceptionForWin32Error(num, fullPath, null);
		}

		// Token: 0x060082E3 RID: 33507 RVA: 0x00137CC8 File Offset: 0x00135EC8
		internal static Interop.Kernel32.WIN32_FILE_ATTRIBUTE_DATA GetAttributeData(SafeFileHandle fileHandle)
		{
			Interop.Kernel32.WIN32_FILE_ATTRIBUTE_DATA result = default(Interop.Kernel32.WIN32_FILE_ATTRIBUTE_DATA);
			int num = FileSystem.FillAttributeInfo(fileHandle, ref result);
			if (num == 0)
			{
				return result;
			}
			throw Win32Marshal.GetExceptionForWin32Error(num, fileHandle.Path, null);
		}

		// Token: 0x060082E4 RID: 33508 RVA: 0x00137CF8 File Offset: 0x00135EF8
		private static int FillAttributeInfo(SafeFileHandle fileHandle, ref Interop.Kernel32.WIN32_FILE_ATTRIBUTE_DATA data)
		{
			Interop.Kernel32.BY_HANDLE_FILE_INFORMATION by_HANDLE_FILE_INFORMATION;
			if (!Interop.Kernel32.GetFileInformationByHandle(fileHandle, out by_HANDLE_FILE_INFORMATION))
			{
				return Marshal.GetLastPInvokeError();
			}
			FileSystem.PopulateAttributeData(ref data, by_HANDLE_FILE_INFORMATION);
			return 0;
		}

		// Token: 0x060082E5 RID: 33509 RVA: 0x00137D20 File Offset: 0x00135F20
		private static void PopulateAttributeData(ref Interop.Kernel32.WIN32_FILE_ATTRIBUTE_DATA data, in Interop.Kernel32.BY_HANDLE_FILE_INFORMATION fileInformationData)
		{
			data.dwFileAttributes = (int)fileInformationData.dwFileAttributes;
			data.ftCreationTime = fileInformationData.ftCreationTime;
			data.ftLastAccessTime = fileInformationData.ftLastAccessTime;
			data.ftLastWriteTime = fileInformationData.ftLastWriteTime;
			data.nFileSizeHigh = fileInformationData.nFileSizeHigh;
			data.nFileSizeLow = fileInformationData.nFileSizeLow;
		}

		// Token: 0x060082E6 RID: 33510 RVA: 0x00137D78 File Offset: 0x00135F78
		private static void MoveDirectory(string sourceFullPath, string destFullPath, bool _)
		{
			ReadOnlySpan<char> span = Path.GetPathRoot(sourceFullPath);
			ReadOnlySpan<char> other = Path.GetPathRoot(destFullPath);
			if (!span.Equals(other, StringComparison.OrdinalIgnoreCase))
			{
				throw new IOException(SR.IO_SourceDestMustHaveSameRoot);
			}
			if (Interop.Kernel32.MoveFile(sourceFullPath, destFullPath, false))
			{
				return;
			}
			int lastPInvokeError = Marshal.GetLastPInvokeError();
			if (lastPInvokeError == 2)
			{
				throw Win32Marshal.GetExceptionForWin32Error(3, sourceFullPath, null);
			}
			if (lastPInvokeError == 183)
			{
				throw Win32Marshal.GetExceptionForWin32Error(183, destFullPath, null);
			}
			if (lastPInvokeError == 5)
			{
				throw new IOException(SR.Format(SR.UnauthorizedAccess_IODenied_Path, sourceFullPath), Win32Marshal.MakeHRFromErrorCode(lastPInvokeError));
			}
			throw Win32Marshal.GetExceptionForWin32Error(lastPInvokeError, "", null);
		}

		// Token: 0x060082E7 RID: 33511 RVA: 0x00137E0A File Offset: 0x0013600A
		public static void MoveFile(string sourceFullPath, string destFullPath, bool overwrite)
		{
			if (!Interop.Kernel32.MoveFile(sourceFullPath, destFullPath, overwrite))
			{
				throw Win32Marshal.GetExceptionForLastWin32Error("");
			}
		}

		// Token: 0x060082E8 RID: 33512 RVA: 0x00137E24 File Offset: 0x00136024
		private static SafeFileHandle OpenHandleToWriteAttributes(string fullPath, bool asDirectory)
		{
			if (fullPath.Length == PathInternal.GetRootLength(fullPath) && fullPath[1] == Path.VolumeSeparatorChar)
			{
				throw new ArgumentException(SR.Arg_PathIsVolume, "path");
			}
			int num = 2097152;
			if (asDirectory)
			{
				num |= 33554432;
			}
			SafeFileHandle safeFileHandle = Interop.Kernel32.CreateFile(fullPath, 256, FileShare.Read | FileShare.Write | FileShare.Delete, FileMode.Open, num);
			if (safeFileHandle.IsInvalid)
			{
				int num2 = Marshal.GetLastPInvokeError();
				if (!asDirectory && num2 == 3 && fullPath.Equals(Directory.GetDirectoryRoot(fullPath)))
				{
					num2 = 5;
				}
				safeFileHandle.Dispose();
				throw Win32Marshal.GetExceptionForWin32Error(num2, fullPath, null);
			}
			return safeFileHandle;
		}

		// Token: 0x060082E9 RID: 33513 RVA: 0x00137EB8 File Offset: 0x001360B8
		public static void RemoveDirectory(string fullPath, bool recursive)
		{
			if (!recursive)
			{
				FileSystem.RemoveDirectoryInternal(fullPath, true, false);
				return;
			}
			Interop.Kernel32.WIN32_FIND_DATA win32_FIND_DATA = default(Interop.Kernel32.WIN32_FIND_DATA);
			FileSystem.GetFindData(fullPath, true, true, ref win32_FIND_DATA);
			if (FileSystem.IsNameSurrogateReparsePoint(ref win32_FIND_DATA))
			{
				FileSystem.RemoveDirectoryInternal(fullPath, true, false);
				return;
			}
			fullPath = PathInternal.EnsureExtendedPrefix(fullPath);
			FileSystem.RemoveDirectoryRecursive(fullPath, ref win32_FIND_DATA, true);
		}

		// Token: 0x060082EA RID: 33514 RVA: 0x00137F08 File Offset: 0x00136108
		private static void GetFindData(string fullPath, bool isDirectory, bool ignoreAccessDenied, ref Interop.Kernel32.WIN32_FIND_DATA findData)
		{
			using (SafeFindHandle safeFindHandle = Interop.Kernel32.FindFirstFile(Path.TrimEndingDirectorySeparator(fullPath), ref findData))
			{
				if (safeFindHandle.IsInvalid)
				{
					int num = Marshal.GetLastPInvokeError();
					if (isDirectory && num == 2)
					{
						num = 3;
					}
					if (!ignoreAccessDenied || num != 5)
					{
						throw Win32Marshal.GetExceptionForWin32Error(num, fullPath, null);
					}
				}
			}
		}

		// Token: 0x060082EB RID: 33515 RVA: 0x00137F68 File Offset: 0x00136168
		private static bool IsNameSurrogateReparsePoint(ref Interop.Kernel32.WIN32_FIND_DATA data)
		{
			return (data.dwFileAttributes & 1024U) != 0U && (data.dwReserved0 & 536870912U) > 0U;
		}

		// Token: 0x060082EC RID: 33516 RVA: 0x00137F8C File Offset: 0x0013618C
		private static void RemoveDirectoryRecursive(string fullPath, ref Interop.Kernel32.WIN32_FIND_DATA findData, bool topLevel)
		{
			Exception ex = null;
			using (SafeFindHandle safeFindHandle = Interop.Kernel32.FindFirstFile(Path.Join(fullPath, "*"), ref findData))
			{
				if (safeFindHandle.IsInvalid)
				{
					throw Win32Marshal.GetExceptionForLastWin32Error(fullPath);
				}
				int lastPInvokeError;
				do
				{
					if ((findData.dwFileAttributes & 16U) == 0U)
					{
						string stringFromFixedBuffer = findData.cFileName.GetStringFromFixedBuffer();
						if (!Interop.Kernel32.DeleteFile(Path.Combine(fullPath, stringFromFixedBuffer)) && ex == null)
						{
							lastPInvokeError = Marshal.GetLastPInvokeError();
							if (lastPInvokeError != 2)
							{
								ex = Win32Marshal.GetExceptionForWin32Error(lastPInvokeError, stringFromFixedBuffer, null);
							}
						}
					}
					else if (!findData.cFileName.FixedBufferEqualsString(".") && !findData.cFileName.FixedBufferEqualsString(".."))
					{
						string stringFromFixedBuffer2 = findData.cFileName.GetStringFromFixedBuffer();
						if (!FileSystem.IsNameSurrogateReparsePoint(ref findData))
						{
							try
							{
								FileSystem.RemoveDirectoryRecursive(Path.Combine(fullPath, stringFromFixedBuffer2), ref findData, false);
								goto IL_127;
							}
							catch (Exception ex2)
							{
								if (ex == null)
								{
									ex = ex2;
								}
								goto IL_127;
							}
						}
						if (findData.dwReserved0 == 2684354563U && !Interop.Kernel32.DeleteVolumeMountPoint(Path.Join(fullPath, stringFromFixedBuffer2, "\\")) && ex == null)
						{
							lastPInvokeError = Marshal.GetLastPInvokeError();
							if (lastPInvokeError != 0 && lastPInvokeError != 3)
							{
								ex = Win32Marshal.GetExceptionForWin32Error(lastPInvokeError, stringFromFixedBuffer2, null);
							}
						}
						if (!Interop.Kernel32.RemoveDirectory(Path.Combine(fullPath, stringFromFixedBuffer2)) && ex == null)
						{
							lastPInvokeError = Marshal.GetLastPInvokeError();
							if (lastPInvokeError != 3)
							{
								ex = Win32Marshal.GetExceptionForWin32Error(lastPInvokeError, stringFromFixedBuffer2, null);
							}
						}
					}
					IL_127:;
				}
				while (Interop.Kernel32.FindNextFile(safeFindHandle, ref findData));
				if (ex != null)
				{
					throw ex;
				}
				lastPInvokeError = Marshal.GetLastPInvokeError();
				if (lastPInvokeError != 0 && lastPInvokeError != 18)
				{
					throw Win32Marshal.GetExceptionForWin32Error(lastPInvokeError, fullPath, null);
				}
			}
			FileSystem.RemoveDirectoryInternal(fullPath, topLevel, true);
		}

		// Token: 0x060082ED RID: 33517 RVA: 0x00138130 File Offset: 0x00136330
		private static void RemoveDirectoryInternal(string fullPath, bool topLevel, bool allowDirectoryNotEmpty = false)
		{
			if (!Interop.Kernel32.RemoveDirectory(fullPath))
			{
				int num = Marshal.GetLastPInvokeError();
				switch (num)
				{
				case 2:
					num = 3;
					break;
				case 3:
					break;
				case 4:
					goto IL_4B;
				case 5:
					throw new IOException(SR.Format(SR.UnauthorizedAccess_IODenied_Path, fullPath));
				default:
					if (num != 145)
					{
						goto IL_4B;
					}
					if (allowDirectoryNotEmpty)
					{
						return;
					}
					goto IL_4B;
				}
				if (!topLevel)
				{
					return;
				}
				IL_4B:
				throw Win32Marshal.GetExceptionForWin32Error(num, fullPath, null);
			}
		}

		// Token: 0x060082EE RID: 33518 RVA: 0x00138191 File Offset: 0x00136391
		public static void SetAttributes(string fullPath, FileAttributes attributes)
		{
			if (Interop.Kernel32.SetFileAttributes(fullPath, (int)attributes))
			{
				return;
			}
			int lastPInvokeError = Marshal.GetLastPInvokeError();
			if (lastPInvokeError == 87)
			{
				throw new ArgumentException(SR.Arg_InvalidFileAttrs, "attributes");
			}
			throw Win32Marshal.GetExceptionForWin32Error(lastPInvokeError, fullPath, null);
		}

		// Token: 0x060082EF RID: 33519 RVA: 0x001381C0 File Offset: 0x001363C0
		public unsafe static void SetAttributes(SafeFileHandle fileHandle, FileAttributes attributes)
		{
			Interop.Kernel32.FILE_BASIC_INFO file_BASIC_INFO = new Interop.Kernel32.FILE_BASIC_INFO
			{
				FileAttributes = (uint)attributes
			};
			if (!Interop.Kernel32.SetFileInformationByHandle(fileHandle, 0, (void*)(&file_BASIC_INFO), (uint)sizeof(Interop.Kernel32.FILE_BASIC_INFO)))
			{
				throw Win32Marshal.GetExceptionForLastWin32Error(fileHandle.Path);
			}
		}

		// Token: 0x060082F0 RID: 33520 RVA: 0x00138200 File Offset: 0x00136400
		private static void SetFileTime(string fullPath, bool asDirectory, long creationTime = 0L, long lastAccessTime = 0L, long lastWriteTime = 0L, long changeTime = 0L, uint fileAttributes = 0U)
		{
			using (SafeFileHandle safeFileHandle = FileSystem.OpenHandleToWriteAttributes(fullPath, asDirectory))
			{
				FileSystem.SetFileTime(safeFileHandle, fullPath, creationTime, lastAccessTime, lastWriteTime, changeTime, fileAttributes);
			}
		}

		// Token: 0x060082F1 RID: 33521 RVA: 0x00138240 File Offset: 0x00136440
		private unsafe static void SetFileTime(SafeFileHandle fileHandle, string fullPath = null, long creationTime = 0L, long lastAccessTime = 0L, long lastWriteTime = 0L, long changeTime = 0L, uint fileAttributes = 0U)
		{
			Interop.Kernel32.FILE_BASIC_INFO file_BASIC_INFO = new Interop.Kernel32.FILE_BASIC_INFO
			{
				CreationTime = creationTime,
				LastAccessTime = lastAccessTime,
				LastWriteTime = lastWriteTime,
				ChangeTime = changeTime,
				FileAttributes = fileAttributes
			};
			if (!Interop.Kernel32.SetFileInformationByHandle(fileHandle, 0, (void*)(&file_BASIC_INFO), (uint)sizeof(Interop.Kernel32.FILE_BASIC_INFO)))
			{
				throw Win32Marshal.GetExceptionForLastWin32Error(fullPath ?? fileHandle.Path);
			}
		}

		// Token: 0x060082F2 RID: 33522 RVA: 0x001382A5 File Offset: 0x001364A5
		public static void SetCreationTime(string fullPath, DateTimeOffset time, bool asDirectory)
		{
			FileSystem.SetFileTime(fullPath, asDirectory, time.ToFileTime(), 0L, 0L, 0L, 0U);
		}

		// Token: 0x060082F3 RID: 33523 RVA: 0x001382BC File Offset: 0x001364BC
		public static void SetCreationTime(SafeFileHandle fileHandle, DateTimeOffset time)
		{
			FileSystem.SetFileTime(fileHandle, null, time.ToFileTime(), 0L, 0L, 0L, 0U);
		}

		// Token: 0x060082F4 RID: 33524 RVA: 0x001382D3 File Offset: 0x001364D3
		public static void SetLastAccessTime(string fullPath, DateTimeOffset time, bool asDirectory)
		{
			FileSystem.SetFileTime(fullPath, asDirectory, 0L, time.ToFileTime(), 0L, 0L, 0U);
		}

		// Token: 0x060082F5 RID: 33525 RVA: 0x001382EA File Offset: 0x001364EA
		public static void SetLastAccessTime(SafeFileHandle fileHandle, DateTimeOffset time)
		{
			FileSystem.SetFileTime(fileHandle, null, 0L, time.ToFileTime(), 0L, 0L, 0U);
		}

		// Token: 0x060082F6 RID: 33526 RVA: 0x00138301 File Offset: 0x00136501
		public static void SetLastWriteTime(string fullPath, DateTimeOffset time, bool asDirectory)
		{
			FileSystem.SetFileTime(fullPath, asDirectory, 0L, 0L, time.ToFileTime(), 0L, 0U);
		}

		// Token: 0x060082F7 RID: 33527 RVA: 0x00138318 File Offset: 0x00136518
		public static void SetLastWriteTime(SafeFileHandle fileHandle, DateTimeOffset time)
		{
			FileSystem.SetFileTime(fileHandle, null, 0L, 0L, time.ToFileTime(), 0L, 0U);
		}

		// Token: 0x060082F8 RID: 33528 RVA: 0x0000EFB7 File Offset: 0x0000D1B7
		public static string[] GetLogicalDrives()
		{
			return DriveInfoInternal.GetLogicalDrives();
		}

		// Token: 0x060082F9 RID: 33529 RVA: 0x0013832F File Offset: 0x0013652F
		internal static void CreateSymbolicLink(string path, string pathToTarget, bool isDirectory)
		{
			Interop.Kernel32.CreateSymbolicLink(path, pathToTarget, isDirectory);
		}

		// Token: 0x060082FA RID: 33530 RVA: 0x0013833C File Offset: 0x0013653C
		internal static FileSystemInfo ResolveLinkTarget(string linkPath, bool returnFinalTarget, bool isDirectory)
		{
			string text = returnFinalTarget ? FileSystem.GetFinalLinkTarget(linkPath, isDirectory) : FileSystem.GetImmediateLinkTarget(linkPath, isDirectory, true, true);
			if (text == null)
			{
				return null;
			}
			if (!isDirectory)
			{
				return new FileInfo(text);
			}
			return new DirectoryInfo(text);
		}

		// Token: 0x060082FB RID: 33531 RVA: 0x00138374 File Offset: 0x00136574
		internal static string GetLinkTarget(string linkPath, bool isDirectory)
		{
			return FileSystem.GetImmediateLinkTarget(linkPath, isDirectory, false, false);
		}

		// Token: 0x060082FC RID: 33532 RVA: 0x00138380 File Offset: 0x00136580
		internal unsafe static string GetImmediateLinkTarget(string linkPath, bool isDirectory, bool throwOnError, bool returnFullPath)
		{
			string result;
			using (SafeFileHandle safeFileHandle = FileSystem.OpenSafeFileHandle(linkPath, 35651584))
			{
				if (safeFileHandle.IsInvalid)
				{
					if (throwOnError)
					{
						int num = Marshal.GetLastPInvokeError();
						if (isDirectory && num == 2)
						{
							num = 3;
						}
						throw Win32Marshal.GetExceptionForWin32Error(num, linkPath, null);
					}
					result = null;
				}
				else
				{
					byte[] array = ArrayPool<byte>.Shared.Rent(16384);
					try
					{
						bool flag;
						try
						{
							byte[] array2;
							byte* lpOutBuffer;
							if ((array2 = array) == null || array2.Length == 0)
							{
								lpOutBuffer = null;
							}
							else
							{
								lpOutBuffer = &array2[0];
							}
							uint num2;
							flag = Interop.Kernel32.DeviceIoControl(safeFileHandle, 589992U, null, 0U, (void*)lpOutBuffer, 16384U, out num2, IntPtr.Zero);
						}
						finally
						{
							byte[] array2 = null;
						}
						if (!flag)
						{
							if (!throwOnError)
							{
								result = null;
							}
							else
							{
								int lastPInvokeError = Marshal.GetLastPInvokeError();
								if (lastPInvokeError != 4390)
								{
									throw Win32Marshal.GetExceptionForWin32Error(lastPInvokeError, linkPath, null);
								}
								result = null;
							}
						}
						else
						{
							Span<byte> span = new Span<byte>(array);
							Interop.Kernel32.SymbolicLinkReparseBuffer symbolicLinkReparseBuffer;
							flag = MemoryMarshal.TryRead<Interop.Kernel32.SymbolicLinkReparseBuffer>(span, out symbolicLinkReparseBuffer);
							if (symbolicLinkReparseBuffer.ReparseTag == 2684354572U)
							{
								int start = sizeof(Interop.Kernel32.SymbolicLinkReparseBuffer) + (int)symbolicLinkReparseBuffer.SubstituteNameOffset;
								int substituteNameLength = (int)symbolicLinkReparseBuffer.SubstituteNameLength;
								Span<char> span2 = MemoryMarshal.Cast<byte, char>(span.Slice(start, substituteNameLength));
								if ((symbolicLinkReparseBuffer.Flags & 1U) <= 0U)
								{
									if (span2.StartsWith("\\??\\UNC\\".AsSpan()))
									{
										result = Path.Join("\\\\".AsSpan(), span2.Slice("\\??\\UNC\\".Length));
									}
									else
									{
										result = FileSystem.<GetImmediateLinkTarget>g__GetTargetPathWithoutNTPrefix|49_0(span2);
									}
								}
								else if (returnFullPath)
								{
									result = Path.Join(Path.GetDirectoryName(linkPath.AsSpan()), span2);
								}
								else
								{
									result = span2.ToString();
								}
							}
							else if (symbolicLinkReparseBuffer.ReparseTag == 2684354563U)
							{
								Interop.Kernel32.MountPointReparseBuffer mountPointReparseBuffer;
								flag = MemoryMarshal.TryRead<Interop.Kernel32.MountPointReparseBuffer>(span, out mountPointReparseBuffer);
								int start2 = sizeof(Interop.Kernel32.MountPointReparseBuffer) + (int)mountPointReparseBuffer.SubstituteNameOffset;
								int substituteNameLength2 = (int)mountPointReparseBuffer.SubstituteNameLength;
								result = FileSystem.<GetImmediateLinkTarget>g__GetTargetPathWithoutNTPrefix|49_0(MemoryMarshal.Cast<byte, char>(span.Slice(start2, substituteNameLength2)));
							}
							else
							{
								result = null;
							}
						}
					}
					finally
					{
						ArrayPool<byte>.Shared.Return(array, false);
					}
				}
			}
			return result;
		}

		// Token: 0x060082FD RID: 33533 RVA: 0x001385E0 File Offset: 0x001367E0
		private static string GetFinalLinkTarget(string linkPath, bool isDirectory)
		{
			FileSystem.<>c__DisplayClass50_0 CS$<>8__locals1;
			CS$<>8__locals1.isDirectory = isDirectory;
			Interop.Kernel32.WIN32_FIND_DATA win32_FIND_DATA = default(Interop.Kernel32.WIN32_FIND_DATA);
			FileSystem.GetFindData(linkPath, CS$<>8__locals1.isDirectory, false, ref win32_FIND_DATA);
			if ((win32_FIND_DATA.dwFileAttributes & 1024U) == 0U || (win32_FIND_DATA.dwReserved0 != 2684354572U && win32_FIND_DATA.dwReserved0 != 2684354563U))
			{
				return null;
			}
			string result;
			using (SafeFileHandle safeFileHandle = FileSystem.OpenSafeFileHandle(linkPath, 33554435))
			{
				if (safeFileHandle.IsInvalid)
				{
					int lastPInvokeError = Marshal.GetLastPInvokeError();
					if (!FileSystem.IsPathUnreachableError(lastPInvokeError))
					{
						throw Win32Marshal.GetExceptionForWin32Error(lastPInvokeError, linkPath, null);
					}
					result = FileSystem.<GetFinalLinkTarget>g__GetFinalLinkTargetSlow|50_1(linkPath, ref CS$<>8__locals1);
				}
				else
				{
					char[] array = ArrayPool<char>.Shared.Rent(4096);
					try
					{
						uint num = FileSystem.<GetFinalLinkTarget>g__GetFinalPathNameByHandle|50_0(safeFileHandle, array);
						if ((ulong)num > (ulong)((long)array.Length))
						{
							char[] array2 = array;
							array = ArrayPool<char>.Shared.Rent((int)num);
							ArrayPool<char>.Shared.Return(array2, false);
							num = FileSystem.<GetFinalLinkTarget>g__GetFinalPathNameByHandle|50_0(safeFileHandle, array);
						}
						if (num == 0U)
						{
							throw Win32Marshal.GetExceptionForLastWin32Error(linkPath);
						}
						int num2 = PathInternal.IsExtended(linkPath.AsSpan()) ? 0 : 4;
						result = new string(array, num2, (int)(num - (uint)num2));
					}
					finally
					{
						ArrayPool<char>.Shared.Return(array, false);
					}
				}
			}
			return result;
		}

		// Token: 0x060082FE RID: 33534 RVA: 0x00138720 File Offset: 0x00136920
		private static SafeFileHandle OpenSafeFileHandle(string path, int flags)
		{
			return Interop.Kernel32.CreateFile(path, 0, FileShare.Read | FileShare.Write | FileShare.Delete, null, FileMode.Open, flags, IntPtr.Zero);
		}

		// Token: 0x060082FF RID: 33535 RVA: 0x00138734 File Offset: 0x00136934
		[CompilerGenerated]
		internal static string <GetImmediateLinkTarget>g__GetTargetPathWithoutNTPrefix|49_0(ReadOnlySpan<char> targetPath)
		{
			return targetPath.Slice("\\??\\".Length).ToString();
		}

		// Token: 0x06008300 RID: 33536 RVA: 0x00138760 File Offset: 0x00136960
		[CompilerGenerated]
		internal unsafe static uint <GetFinalLinkTarget>g__GetFinalPathNameByHandle|50_0(SafeFileHandle handle, char[] buffer)
		{
			char* lpszFilePath;
			if (buffer == null || buffer.Length == 0)
			{
				lpszFilePath = null;
			}
			else
			{
				lpszFilePath = &buffer[0];
			}
			return Interop.Kernel32.GetFinalPathNameByHandle(handle, lpszFilePath, (uint)buffer.Length, 0U);
		}

		// Token: 0x06008301 RID: 33537 RVA: 0x00138790 File Offset: 0x00136990
		[CompilerGenerated]
		internal static string <GetFinalLinkTarget>g__GetFinalLinkTargetSlow|50_1(string linkPath, ref FileSystem.<>c__DisplayClass50_0 A_1)
		{
			string immediateLinkTarget = FileSystem.GetImmediateLinkTarget(linkPath, A_1.isDirectory, false, true);
			string result = null;
			while (immediateLinkTarget != null)
			{
				result = immediateLinkTarget;
				immediateLinkTarget = FileSystem.GetImmediateLinkTarget(immediateLinkTarget, A_1.isDirectory, false, true);
			}
			return result;
		}
	}
}

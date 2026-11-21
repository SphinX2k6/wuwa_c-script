using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO.Enumeration;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Text;

namespace System.IO
{
	// Token: 0x020007E1 RID: 2017
	[NullableContext(1)]
	[Nullable(0)]
	public static class Directory
	{
		// Token: 0x06008139 RID: 33081 RVA: 0x001332C0 File Offset: 0x001314C0
		[return: Nullable(2)]
		public static DirectoryInfo GetParent(string path)
		{
			ArgumentException.ThrowIfNullOrEmpty(path, "path");
			string directoryName = Path.GetDirectoryName(Path.GetFullPath(path));
			if (directoryName == null)
			{
				return null;
			}
			return new DirectoryInfo(directoryName);
		}

		// Token: 0x0600813A RID: 33082 RVA: 0x001332F0 File Offset: 0x001314F0
		public static DirectoryInfo CreateDirectory(string path)
		{
			ArgumentException.ThrowIfNullOrEmpty(path, "path");
			string fullPath = Path.GetFullPath(path);
			FileSystem.CreateDirectory(fullPath, null);
			return new DirectoryInfo(path, fullPath, null, true);
		}

		// Token: 0x0600813B RID: 33083 RVA: 0x0013331F File Offset: 0x0013151F
		[UnsupportedOSPlatform("windows")]
		public static DirectoryInfo CreateDirectory(string path, UnixFileMode unixCreateMode)
		{
			return Directory.CreateDirectoryCore(path, unixCreateMode);
		}

		// Token: 0x0600813C RID: 33084 RVA: 0x00133328 File Offset: 0x00131528
		public static DirectoryInfo CreateTempSubdirectory([Nullable(2)] string prefix = null)
		{
			Directory.EnsureNoDirectorySeparators(prefix, "prefix");
			return new DirectoryInfo(Directory.CreateTempSubdirectoryCore(prefix), null, null, true);
		}

		// Token: 0x0600813D RID: 33085 RVA: 0x00133343 File Offset: 0x00131543
		private static void EnsureNoDirectorySeparators(string value, [CallerArgumentExpression("value")] string paramName = null)
		{
			if (value != null && value.AsSpan().ContainsAny("\\/"))
			{
				throw new ArgumentException(SR.Argument_DirectorySeparatorInvalid, paramName);
			}
		}

		// Token: 0x0600813E RID: 33086 RVA: 0x0013336C File Offset: 0x0013156C
		[NullableContext(2)]
		public static bool Exists([NotNullWhen(true)] string path)
		{
			try
			{
				if (path == null)
				{
					return false;
				}
				if (path.Length == 0)
				{
					return false;
				}
				return FileSystem.DirectoryExists(Path.GetFullPath(path));
			}
			catch (ArgumentException)
			{
			}
			catch (IOException)
			{
			}
			catch (UnauthorizedAccessException)
			{
			}
			return false;
		}

		// Token: 0x0600813F RID: 33087 RVA: 0x001333D0 File Offset: 0x001315D0
		public static void SetCreationTime(string path, DateTime creationTime)
		{
			FileSystem.SetCreationTime(Path.GetFullPath(path), creationTime, true);
		}

		// Token: 0x06008140 RID: 33088 RVA: 0x001333E4 File Offset: 0x001315E4
		public static void SetCreationTimeUtc(string path, DateTime creationTimeUtc)
		{
			FileSystem.SetCreationTime(Path.GetFullPath(path), File.GetUtcDateTimeOffset(creationTimeUtc), true);
		}

		// Token: 0x06008141 RID: 33089 RVA: 0x001333F8 File Offset: 0x001315F8
		public static DateTime GetCreationTime(string path)
		{
			return File.GetCreationTime(path);
		}

		// Token: 0x06008142 RID: 33090 RVA: 0x00133400 File Offset: 0x00131600
		public static DateTime GetCreationTimeUtc(string path)
		{
			return File.GetCreationTimeUtc(path);
		}

		// Token: 0x06008143 RID: 33091 RVA: 0x00133408 File Offset: 0x00131608
		public static void SetLastWriteTime(string path, DateTime lastWriteTime)
		{
			FileSystem.SetLastWriteTime(Path.GetFullPath(path), lastWriteTime, true);
		}

		// Token: 0x06008144 RID: 33092 RVA: 0x0013341C File Offset: 0x0013161C
		public static void SetLastWriteTimeUtc(string path, DateTime lastWriteTimeUtc)
		{
			FileSystem.SetLastWriteTime(Path.GetFullPath(path), File.GetUtcDateTimeOffset(lastWriteTimeUtc), true);
		}

		// Token: 0x06008145 RID: 33093 RVA: 0x00133430 File Offset: 0x00131630
		public static DateTime GetLastWriteTime(string path)
		{
			return File.GetLastWriteTime(path);
		}

		// Token: 0x06008146 RID: 33094 RVA: 0x00133438 File Offset: 0x00131638
		public static DateTime GetLastWriteTimeUtc(string path)
		{
			return File.GetLastWriteTimeUtc(path);
		}

		// Token: 0x06008147 RID: 33095 RVA: 0x00133440 File Offset: 0x00131640
		public static void SetLastAccessTime(string path, DateTime lastAccessTime)
		{
			FileSystem.SetLastAccessTime(Path.GetFullPath(path), lastAccessTime, true);
		}

		// Token: 0x06008148 RID: 33096 RVA: 0x00133454 File Offset: 0x00131654
		public static void SetLastAccessTimeUtc(string path, DateTime lastAccessTimeUtc)
		{
			FileSystem.SetLastAccessTime(Path.GetFullPath(path), File.GetUtcDateTimeOffset(lastAccessTimeUtc), true);
		}

		// Token: 0x06008149 RID: 33097 RVA: 0x00133468 File Offset: 0x00131668
		public static DateTime GetLastAccessTime(string path)
		{
			return File.GetLastAccessTime(path);
		}

		// Token: 0x0600814A RID: 33098 RVA: 0x00133470 File Offset: 0x00131670
		public static DateTime GetLastAccessTimeUtc(string path)
		{
			return File.GetLastAccessTimeUtc(path);
		}

		// Token: 0x0600814B RID: 33099 RVA: 0x00133478 File Offset: 0x00131678
		public static string[] GetFiles(string path)
		{
			return Directory.GetFiles(path, "*", EnumerationOptions.Compatible);
		}

		// Token: 0x0600814C RID: 33100 RVA: 0x0013348A File Offset: 0x0013168A
		public static string[] GetFiles(string path, string searchPattern)
		{
			return Directory.GetFiles(path, searchPattern, EnumerationOptions.Compatible);
		}

		// Token: 0x0600814D RID: 33101 RVA: 0x00133498 File Offset: 0x00131698
		public static string[] GetFiles(string path, string searchPattern, SearchOption searchOption)
		{
			return Directory.GetFiles(path, searchPattern, EnumerationOptions.FromSearchOption(searchOption));
		}

		// Token: 0x0600814E RID: 33102 RVA: 0x001334A7 File Offset: 0x001316A7
		public static string[] GetFiles(string path, string searchPattern, EnumerationOptions enumerationOptions)
		{
			return new List<string>(Directory.InternalEnumeratePaths(path, searchPattern, SearchTarget.Files, enumerationOptions)).ToArray();
		}

		// Token: 0x0600814F RID: 33103 RVA: 0x001334BC File Offset: 0x001316BC
		public static string[] GetDirectories(string path)
		{
			return Directory.GetDirectories(path, "*", EnumerationOptions.Compatible);
		}

		// Token: 0x06008150 RID: 33104 RVA: 0x001334CE File Offset: 0x001316CE
		public static string[] GetDirectories(string path, string searchPattern)
		{
			return Directory.GetDirectories(path, searchPattern, EnumerationOptions.Compatible);
		}

		// Token: 0x06008151 RID: 33105 RVA: 0x001334DC File Offset: 0x001316DC
		public static string[] GetDirectories(string path, string searchPattern, SearchOption searchOption)
		{
			return Directory.GetDirectories(path, searchPattern, EnumerationOptions.FromSearchOption(searchOption));
		}

		// Token: 0x06008152 RID: 33106 RVA: 0x001334EB File Offset: 0x001316EB
		public static string[] GetDirectories(string path, string searchPattern, EnumerationOptions enumerationOptions)
		{
			return new List<string>(Directory.InternalEnumeratePaths(path, searchPattern, SearchTarget.Directories, enumerationOptions)).ToArray();
		}

		// Token: 0x06008153 RID: 33107 RVA: 0x00133500 File Offset: 0x00131700
		public static string[] GetFileSystemEntries(string path)
		{
			return Directory.GetFileSystemEntries(path, "*", EnumerationOptions.Compatible);
		}

		// Token: 0x06008154 RID: 33108 RVA: 0x00133512 File Offset: 0x00131712
		public static string[] GetFileSystemEntries(string path, string searchPattern)
		{
			return Directory.GetFileSystemEntries(path, searchPattern, EnumerationOptions.Compatible);
		}

		// Token: 0x06008155 RID: 33109 RVA: 0x00133520 File Offset: 0x00131720
		public static string[] GetFileSystemEntries(string path, string searchPattern, SearchOption searchOption)
		{
			return Directory.GetFileSystemEntries(path, searchPattern, EnumerationOptions.FromSearchOption(searchOption));
		}

		// Token: 0x06008156 RID: 33110 RVA: 0x0013352F File Offset: 0x0013172F
		public static string[] GetFileSystemEntries(string path, string searchPattern, EnumerationOptions enumerationOptions)
		{
			return new List<string>(Directory.InternalEnumeratePaths(path, searchPattern, SearchTarget.Both, enumerationOptions)).ToArray();
		}

		// Token: 0x06008157 RID: 33111 RVA: 0x00133544 File Offset: 0x00131744
		internal static IEnumerable<string> InternalEnumeratePaths(string path, string searchPattern, SearchTarget searchTarget, EnumerationOptions options)
		{
			ArgumentNullException.ThrowIfNull(path, "path");
			ArgumentNullException.ThrowIfNull(searchPattern, "searchPattern");
			FileSystemEnumerableFactory.NormalizeInputs(ref path, ref searchPattern, options.MatchType);
			IEnumerable<string> result;
			switch (searchTarget)
			{
			case SearchTarget.Files:
				result = FileSystemEnumerableFactory.UserFiles(path, searchPattern, options);
				break;
			case SearchTarget.Directories:
				result = FileSystemEnumerableFactory.UserDirectories(path, searchPattern, options);
				break;
			case SearchTarget.Both:
				result = FileSystemEnumerableFactory.UserEntries(path, searchPattern, options);
				break;
			default:
				throw new ArgumentOutOfRangeException("searchTarget");
			}
			return result;
		}

		// Token: 0x06008158 RID: 33112 RVA: 0x001335BA File Offset: 0x001317BA
		public static IEnumerable<string> EnumerateDirectories(string path)
		{
			return Directory.EnumerateDirectories(path, "*", EnumerationOptions.Compatible);
		}

		// Token: 0x06008159 RID: 33113 RVA: 0x001335CC File Offset: 0x001317CC
		public static IEnumerable<string> EnumerateDirectories(string path, string searchPattern)
		{
			return Directory.EnumerateDirectories(path, searchPattern, EnumerationOptions.Compatible);
		}

		// Token: 0x0600815A RID: 33114 RVA: 0x001335DA File Offset: 0x001317DA
		public static IEnumerable<string> EnumerateDirectories(string path, string searchPattern, SearchOption searchOption)
		{
			return Directory.EnumerateDirectories(path, searchPattern, EnumerationOptions.FromSearchOption(searchOption));
		}

		// Token: 0x0600815B RID: 33115 RVA: 0x001335E9 File Offset: 0x001317E9
		public static IEnumerable<string> EnumerateDirectories(string path, string searchPattern, EnumerationOptions enumerationOptions)
		{
			return Directory.InternalEnumeratePaths(path, searchPattern, SearchTarget.Directories, enumerationOptions);
		}

		// Token: 0x0600815C RID: 33116 RVA: 0x001335F4 File Offset: 0x001317F4
		public static IEnumerable<string> EnumerateFiles(string path)
		{
			return Directory.EnumerateFiles(path, "*", EnumerationOptions.Compatible);
		}

		// Token: 0x0600815D RID: 33117 RVA: 0x00133606 File Offset: 0x00131806
		public static IEnumerable<string> EnumerateFiles(string path, string searchPattern)
		{
			return Directory.EnumerateFiles(path, searchPattern, EnumerationOptions.Compatible);
		}

		// Token: 0x0600815E RID: 33118 RVA: 0x00133614 File Offset: 0x00131814
		public static IEnumerable<string> EnumerateFiles(string path, string searchPattern, SearchOption searchOption)
		{
			return Directory.EnumerateFiles(path, searchPattern, EnumerationOptions.FromSearchOption(searchOption));
		}

		// Token: 0x0600815F RID: 33119 RVA: 0x00133623 File Offset: 0x00131823
		public static IEnumerable<string> EnumerateFiles(string path, string searchPattern, EnumerationOptions enumerationOptions)
		{
			return Directory.InternalEnumeratePaths(path, searchPattern, SearchTarget.Files, enumerationOptions);
		}

		// Token: 0x06008160 RID: 33120 RVA: 0x0013362E File Offset: 0x0013182E
		public static IEnumerable<string> EnumerateFileSystemEntries(string path)
		{
			return Directory.EnumerateFileSystemEntries(path, "*", EnumerationOptions.Compatible);
		}

		// Token: 0x06008161 RID: 33121 RVA: 0x00133640 File Offset: 0x00131840
		public static IEnumerable<string> EnumerateFileSystemEntries(string path, string searchPattern)
		{
			return Directory.EnumerateFileSystemEntries(path, searchPattern, EnumerationOptions.Compatible);
		}

		// Token: 0x06008162 RID: 33122 RVA: 0x0013364E File Offset: 0x0013184E
		public static IEnumerable<string> EnumerateFileSystemEntries(string path, string searchPattern, SearchOption searchOption)
		{
			return Directory.EnumerateFileSystemEntries(path, searchPattern, EnumerationOptions.FromSearchOption(searchOption));
		}

		// Token: 0x06008163 RID: 33123 RVA: 0x0013365D File Offset: 0x0013185D
		public static IEnumerable<string> EnumerateFileSystemEntries(string path, string searchPattern, EnumerationOptions enumerationOptions)
		{
			return Directory.InternalEnumeratePaths(path, searchPattern, SearchTarget.Both, enumerationOptions);
		}

		// Token: 0x06008164 RID: 33124 RVA: 0x00133668 File Offset: 0x00131868
		public static string GetDirectoryRoot(string path)
		{
			ArgumentNullException.ThrowIfNull(path, "path");
			return Path.GetPathRoot(Path.GetFullPath(path));
		}

		// Token: 0x06008165 RID: 33125 RVA: 0x00133680 File Offset: 0x00131880
		public static string GetCurrentDirectory()
		{
			return Environment.CurrentDirectory;
		}

		// Token: 0x06008166 RID: 33126 RVA: 0x00133687 File Offset: 0x00131887
		public static void SetCurrentDirectory(string path)
		{
			ArgumentException.ThrowIfNullOrEmpty(path, "path");
			Environment.CurrentDirectory = Path.GetFullPath(path);
		}

		// Token: 0x06008167 RID: 33127 RVA: 0x0013369F File Offset: 0x0013189F
		public static void Move(string sourceDirName, string destDirName)
		{
			ArgumentException.ThrowIfNullOrEmpty(sourceDirName, "sourceDirName");
			ArgumentException.ThrowIfNullOrEmpty(destDirName, "destDirName");
			FileSystem.MoveDirectory(Path.GetFullPath(sourceDirName), Path.GetFullPath(destDirName));
		}

		// Token: 0x06008168 RID: 33128 RVA: 0x001336C8 File Offset: 0x001318C8
		public static void Delete(string path)
		{
			FileSystem.RemoveDirectory(Path.GetFullPath(path), false);
		}

		// Token: 0x06008169 RID: 33129 RVA: 0x001336D6 File Offset: 0x001318D6
		public static void Delete(string path, bool recursive)
		{
			FileSystem.RemoveDirectory(Path.GetFullPath(path), recursive);
		}

		// Token: 0x0600816A RID: 33130 RVA: 0x001336E4 File Offset: 0x001318E4
		public static string[] GetLogicalDrives()
		{
			return FileSystem.GetLogicalDrives();
		}

		// Token: 0x0600816B RID: 33131 RVA: 0x001336EC File Offset: 0x001318EC
		public static FileSystemInfo CreateSymbolicLink(string path, string pathToTarget)
		{
			string fullPath = Path.GetFullPath(path);
			FileSystem.VerifyValidPath(pathToTarget, "pathToTarget");
			FileSystem.CreateSymbolicLink(path, pathToTarget, true);
			return new DirectoryInfo(path, fullPath, null, true);
		}

		// Token: 0x0600816C RID: 33132 RVA: 0x0013371C File Offset: 0x0013191C
		[return: Nullable(2)]
		public static FileSystemInfo ResolveLinkTarget(string linkPath, bool returnFinalTarget)
		{
			FileSystem.VerifyValidPath(linkPath, "linkPath");
			return FileSystem.ResolveLinkTarget(linkPath, returnFinalTarget, true);
		}

		// Token: 0x0600816D RID: 33133 RVA: 0x00133731 File Offset: 0x00131931
		private static DirectoryInfo CreateDirectoryCore(string path, UnixFileMode unixCreateMode)
		{
			throw new PlatformNotSupportedException(SR.PlatformNotSupported_UnixFileMode);
		}

		// Token: 0x0600816E RID: 33134 RVA: 0x00133740 File Offset: 0x00131940
		private unsafe static string CreateTempSubdirectoryCore(string prefix)
		{
			Span<char> initialBuffer = new Span<char>(stackalloc byte[(UIntPtr)520], 260);
			ValueStringBuilder valueStringBuilder = new ValueStringBuilder(initialBuffer);
			Path.GetTempPath(ref valueStringBuilder);
			Directory.CreateDirectory(PathHelper.Normalize(ref valueStringBuilder));
			valueStringBuilder.Append(prefix);
			int length = valueStringBuilder.Length;
			valueStringBuilder.EnsureCapacity(length + 12);
			byte* ptr = stackalloc byte[(UIntPtr)8];
			for (int i = 0; i < 65535; i++)
			{
				Interop.GetRandomBytes(ptr, 8);
				Path.Populate83FileNameFromRandomBytes(ptr, 8, valueStringBuilder.RawChars.Slice(valueStringBuilder.Length, 12));
				valueStringBuilder.Length += 12;
				string text = PathHelper.Normalize(ref valueStringBuilder);
				if (Interop.Kernel32.CreateDirectory(text, null))
				{
					valueStringBuilder.Dispose();
					return text;
				}
				int lastPInvokeError = Marshal.GetLastPInvokeError();
				if (lastPInvokeError != 183)
				{
					throw Win32Marshal.GetExceptionForWin32Error(lastPInvokeError, text, null);
				}
				valueStringBuilder.Length = length;
			}
			throw new IOException(SR.IO_MaxAttemptsReached);
		}
	}
}

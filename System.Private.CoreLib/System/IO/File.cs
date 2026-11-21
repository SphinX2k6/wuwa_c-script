using System;
using System.Buffers;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO.Strategies;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.Versioning;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;

namespace System.IO
{
	// Token: 0x020007E7 RID: 2023
	[NullableContext(1)]
	[Nullable(0)]
	public static class File
	{
		// Token: 0x1700115F RID: 4447
		// (get) Token: 0x060081B3 RID: 33203 RVA: 0x00133F0F File Offset: 0x0013210F
		private static Encoding UTF8NoBOM
		{
			get
			{
				Encoding result;
				if ((result = File.s_UTF8NoBOM) == null)
				{
					result = (File.s_UTF8NoBOM = new UTF8Encoding(false, true));
				}
				return result;
			}
		}

		// Token: 0x060081B4 RID: 33204 RVA: 0x00133F27 File Offset: 0x00132127
		public static StreamReader OpenText(string path)
		{
			return new StreamReader(path);
		}

		// Token: 0x060081B5 RID: 33205 RVA: 0x00133F2F File Offset: 0x0013212F
		public static StreamWriter CreateText(string path)
		{
			return new StreamWriter(path, false);
		}

		// Token: 0x060081B6 RID: 33206 RVA: 0x00133F38 File Offset: 0x00132138
		public static StreamWriter AppendText(string path)
		{
			return new StreamWriter(path, true);
		}

		// Token: 0x060081B7 RID: 33207 RVA: 0x00133F41 File Offset: 0x00132141
		public static void Copy(string sourceFileName, string destFileName)
		{
			File.Copy(sourceFileName, destFileName, false);
		}

		// Token: 0x060081B8 RID: 33208 RVA: 0x00133F4B File Offset: 0x0013214B
		public static void Copy(string sourceFileName, string destFileName, bool overwrite)
		{
			ArgumentException.ThrowIfNullOrEmpty(sourceFileName, "sourceFileName");
			ArgumentException.ThrowIfNullOrEmpty(destFileName, "destFileName");
			FileSystem.CopyFile(Path.GetFullPath(sourceFileName), Path.GetFullPath(destFileName), overwrite);
		}

		// Token: 0x060081B9 RID: 33209 RVA: 0x00133F75 File Offset: 0x00132175
		public static FileStream Create(string path)
		{
			return File.Create(path, 4096);
		}

		// Token: 0x060081BA RID: 33210 RVA: 0x00133F82 File Offset: 0x00132182
		public static FileStream Create(string path, int bufferSize)
		{
			return new FileStream(path, FileMode.Create, FileAccess.ReadWrite, FileShare.None, bufferSize);
		}

		// Token: 0x060081BB RID: 33211 RVA: 0x00133F8E File Offset: 0x0013218E
		public static FileStream Create(string path, int bufferSize, FileOptions options)
		{
			return new FileStream(path, FileMode.Create, FileAccess.ReadWrite, FileShare.None, bufferSize, options);
		}

		// Token: 0x060081BC RID: 33212 RVA: 0x00133F9B File Offset: 0x0013219B
		public static void Delete(string path)
		{
			ArgumentNullException.ThrowIfNull(path, "path");
			FileSystem.DeleteFile(Path.GetFullPath(path));
		}

		// Token: 0x060081BD RID: 33213 RVA: 0x00133FB4 File Offset: 0x001321B4
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
				path = Path.GetFullPath(path);
				if (path.Length > 0)
				{
					string text = path;
					if (PathInternal.IsDirectorySeparator(text[text.Length - 1]))
					{
						return false;
					}
				}
				return FileSystem.FileExists(path);
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

		// Token: 0x060081BE RID: 33214 RVA: 0x0013403C File Offset: 0x0013223C
		public static FileStream Open(string path, FileStreamOptions options)
		{
			return new FileStream(path, options);
		}

		// Token: 0x060081BF RID: 33215 RVA: 0x00134045 File Offset: 0x00132245
		public static FileStream Open(string path, FileMode mode)
		{
			return File.Open(path, mode, (mode == FileMode.Append) ? FileAccess.Write : FileAccess.ReadWrite, FileShare.None);
		}

		// Token: 0x060081C0 RID: 33216 RVA: 0x00134057 File Offset: 0x00132257
		public static FileStream Open(string path, FileMode mode, FileAccess access)
		{
			return File.Open(path, mode, access, FileShare.None);
		}

		// Token: 0x060081C1 RID: 33217 RVA: 0x00134062 File Offset: 0x00132262
		public static FileStream Open(string path, FileMode mode, FileAccess access, FileShare share)
		{
			return new FileStream(path, mode, access, share);
		}

		// Token: 0x060081C2 RID: 33218 RVA: 0x00134070 File Offset: 0x00132270
		public static SafeFileHandle OpenHandle(string path, FileMode mode = FileMode.Open, FileAccess access = FileAccess.Read, FileShare share = FileShare.Read, FileOptions options = FileOptions.None, long preallocationSize = 0L)
		{
			FileStreamHelpers.ValidateArguments(path, mode, access, share, 0, options, preallocationSize);
			return SafeFileHandle.Open(Path.GetFullPath(path), mode, access, share, options, preallocationSize, null);
		}

		// Token: 0x060081C3 RID: 33219 RVA: 0x001340A6 File Offset: 0x001322A6
		internal static DateTimeOffset GetUtcDateTimeOffset(DateTime dateTime)
		{
			return (dateTime.Kind == DateTimeKind.Unspecified) ? DateTime.SpecifyKind(dateTime, DateTimeKind.Utc) : dateTime.ToUniversalTime();
		}

		// Token: 0x060081C4 RID: 33220 RVA: 0x001340C6 File Offset: 0x001322C6
		public static void SetCreationTime(string path, DateTime creationTime)
		{
			FileSystem.SetCreationTime(Path.GetFullPath(path), creationTime, false);
		}

		// Token: 0x060081C5 RID: 33221 RVA: 0x001340DA File Offset: 0x001322DA
		public static void SetCreationTime(SafeFileHandle fileHandle, DateTime creationTime)
		{
			ArgumentNullException.ThrowIfNull(fileHandle, "fileHandle");
			FileSystem.SetCreationTime(fileHandle, creationTime);
		}

		// Token: 0x060081C6 RID: 33222 RVA: 0x001340F3 File Offset: 0x001322F3
		public static void SetCreationTimeUtc(string path, DateTime creationTimeUtc)
		{
			FileSystem.SetCreationTime(Path.GetFullPath(path), File.GetUtcDateTimeOffset(creationTimeUtc), false);
		}

		// Token: 0x060081C7 RID: 33223 RVA: 0x00134107 File Offset: 0x00132307
		public static void SetCreationTimeUtc(SafeFileHandle fileHandle, DateTime creationTimeUtc)
		{
			ArgumentNullException.ThrowIfNull(fileHandle, "fileHandle");
			FileSystem.SetCreationTime(fileHandle, File.GetUtcDateTimeOffset(creationTimeUtc));
		}

		// Token: 0x060081C8 RID: 33224 RVA: 0x00134120 File Offset: 0x00132320
		public static DateTime GetCreationTime(string path)
		{
			return FileSystem.GetCreationTime(Path.GetFullPath(path)).LocalDateTime;
		}

		// Token: 0x060081C9 RID: 33225 RVA: 0x00134140 File Offset: 0x00132340
		public static DateTime GetCreationTime(SafeFileHandle fileHandle)
		{
			ArgumentNullException.ThrowIfNull(fileHandle, "fileHandle");
			return FileSystem.GetCreationTime(fileHandle).LocalDateTime;
		}

		// Token: 0x060081CA RID: 33226 RVA: 0x00134168 File Offset: 0x00132368
		public static DateTime GetCreationTimeUtc(string path)
		{
			return FileSystem.GetCreationTime(Path.GetFullPath(path)).UtcDateTime;
		}

		// Token: 0x060081CB RID: 33227 RVA: 0x00134188 File Offset: 0x00132388
		public static DateTime GetCreationTimeUtc(SafeFileHandle fileHandle)
		{
			ArgumentNullException.ThrowIfNull(fileHandle, "fileHandle");
			return FileSystem.GetCreationTime(fileHandle).UtcDateTime;
		}

		// Token: 0x060081CC RID: 33228 RVA: 0x001341AE File Offset: 0x001323AE
		public static void SetLastAccessTime(string path, DateTime lastAccessTime)
		{
			FileSystem.SetLastAccessTime(Path.GetFullPath(path), lastAccessTime, false);
		}

		// Token: 0x060081CD RID: 33229 RVA: 0x001341C2 File Offset: 0x001323C2
		public static void SetLastAccessTime(SafeFileHandle fileHandle, DateTime lastAccessTime)
		{
			ArgumentNullException.ThrowIfNull(fileHandle, "fileHandle");
			FileSystem.SetLastAccessTime(fileHandle, lastAccessTime);
		}

		// Token: 0x060081CE RID: 33230 RVA: 0x001341DB File Offset: 0x001323DB
		public static void SetLastAccessTimeUtc(string path, DateTime lastAccessTimeUtc)
		{
			FileSystem.SetLastAccessTime(Path.GetFullPath(path), File.GetUtcDateTimeOffset(lastAccessTimeUtc), false);
		}

		// Token: 0x060081CF RID: 33231 RVA: 0x001341EF File Offset: 0x001323EF
		public static void SetLastAccessTimeUtc(SafeFileHandle fileHandle, DateTime lastAccessTimeUtc)
		{
			ArgumentNullException.ThrowIfNull(fileHandle, "fileHandle");
			FileSystem.SetLastAccessTime(fileHandle, File.GetUtcDateTimeOffset(lastAccessTimeUtc));
		}

		// Token: 0x060081D0 RID: 33232 RVA: 0x00134208 File Offset: 0x00132408
		public static DateTime GetLastAccessTime(string path)
		{
			return FileSystem.GetLastAccessTime(Path.GetFullPath(path)).LocalDateTime;
		}

		// Token: 0x060081D1 RID: 33233 RVA: 0x00134228 File Offset: 0x00132428
		public static DateTime GetLastAccessTime(SafeFileHandle fileHandle)
		{
			ArgumentNullException.ThrowIfNull(fileHandle, "fileHandle");
			return FileSystem.GetLastAccessTime(fileHandle).LocalDateTime;
		}

		// Token: 0x060081D2 RID: 33234 RVA: 0x00134250 File Offset: 0x00132450
		public static DateTime GetLastAccessTimeUtc(string path)
		{
			return FileSystem.GetLastAccessTime(Path.GetFullPath(path)).UtcDateTime;
		}

		// Token: 0x060081D3 RID: 33235 RVA: 0x00134270 File Offset: 0x00132470
		public static DateTime GetLastAccessTimeUtc(SafeFileHandle fileHandle)
		{
			ArgumentNullException.ThrowIfNull(fileHandle, "fileHandle");
			return FileSystem.GetLastAccessTime(fileHandle).UtcDateTime;
		}

		// Token: 0x060081D4 RID: 33236 RVA: 0x00134296 File Offset: 0x00132496
		public static void SetLastWriteTime(string path, DateTime lastWriteTime)
		{
			FileSystem.SetLastWriteTime(Path.GetFullPath(path), lastWriteTime, false);
		}

		// Token: 0x060081D5 RID: 33237 RVA: 0x001342AA File Offset: 0x001324AA
		public static void SetLastWriteTime(SafeFileHandle fileHandle, DateTime lastWriteTime)
		{
			ArgumentNullException.ThrowIfNull(fileHandle, "fileHandle");
			FileSystem.SetLastWriteTime(fileHandle, lastWriteTime);
		}

		// Token: 0x060081D6 RID: 33238 RVA: 0x001342C3 File Offset: 0x001324C3
		public static void SetLastWriteTimeUtc(string path, DateTime lastWriteTimeUtc)
		{
			FileSystem.SetLastWriteTime(Path.GetFullPath(path), File.GetUtcDateTimeOffset(lastWriteTimeUtc), false);
		}

		// Token: 0x060081D7 RID: 33239 RVA: 0x001342D7 File Offset: 0x001324D7
		public static void SetLastWriteTimeUtc(SafeFileHandle fileHandle, DateTime lastWriteTimeUtc)
		{
			ArgumentNullException.ThrowIfNull(fileHandle, "fileHandle");
			FileSystem.SetLastWriteTime(fileHandle, File.GetUtcDateTimeOffset(lastWriteTimeUtc));
		}

		// Token: 0x060081D8 RID: 33240 RVA: 0x001342F0 File Offset: 0x001324F0
		public static DateTime GetLastWriteTime(string path)
		{
			return FileSystem.GetLastWriteTime(Path.GetFullPath(path)).LocalDateTime;
		}

		// Token: 0x060081D9 RID: 33241 RVA: 0x00134310 File Offset: 0x00132510
		public static DateTime GetLastWriteTime(SafeFileHandle fileHandle)
		{
			ArgumentNullException.ThrowIfNull(fileHandle, "fileHandle");
			return FileSystem.GetLastWriteTime(fileHandle).LocalDateTime;
		}

		// Token: 0x060081DA RID: 33242 RVA: 0x00134338 File Offset: 0x00132538
		public static DateTime GetLastWriteTimeUtc(string path)
		{
			return FileSystem.GetLastWriteTime(Path.GetFullPath(path)).UtcDateTime;
		}

		// Token: 0x060081DB RID: 33243 RVA: 0x00134358 File Offset: 0x00132558
		public static DateTime GetLastWriteTimeUtc(SafeFileHandle fileHandle)
		{
			ArgumentNullException.ThrowIfNull(fileHandle, "fileHandle");
			return FileSystem.GetLastWriteTime(fileHandle).UtcDateTime;
		}

		// Token: 0x060081DC RID: 33244 RVA: 0x0013437E File Offset: 0x0013257E
		public static FileAttributes GetAttributes(string path)
		{
			return FileSystem.GetAttributes(Path.GetFullPath(path));
		}

		// Token: 0x060081DD RID: 33245 RVA: 0x0013438B File Offset: 0x0013258B
		public static FileAttributes GetAttributes(SafeFileHandle fileHandle)
		{
			ArgumentNullException.ThrowIfNull(fileHandle, "fileHandle");
			return FileSystem.GetAttributes(fileHandle);
		}

		// Token: 0x060081DE RID: 33246 RVA: 0x0013439E File Offset: 0x0013259E
		public static void SetAttributes(string path, FileAttributes fileAttributes)
		{
			FileSystem.SetAttributes(Path.GetFullPath(path), fileAttributes);
		}

		// Token: 0x060081DF RID: 33247 RVA: 0x001343AC File Offset: 0x001325AC
		public static void SetAttributes(SafeFileHandle fileHandle, FileAttributes fileAttributes)
		{
			ArgumentNullException.ThrowIfNull(fileHandle, "fileHandle");
			FileSystem.SetAttributes(fileHandle, fileAttributes);
		}

		// Token: 0x060081E0 RID: 33248 RVA: 0x001343C0 File Offset: 0x001325C0
		[UnsupportedOSPlatform("windows")]
		public static UnixFileMode GetUnixFileMode(string path)
		{
			return File.GetUnixFileModeCore(path);
		}

		// Token: 0x060081E1 RID: 33249 RVA: 0x001343C8 File Offset: 0x001325C8
		[UnsupportedOSPlatform("windows")]
		public static UnixFileMode GetUnixFileMode(SafeFileHandle fileHandle)
		{
			return File.GetUnixFileModeCore(fileHandle);
		}

		// Token: 0x060081E2 RID: 33250 RVA: 0x001343D0 File Offset: 0x001325D0
		[UnsupportedOSPlatform("windows")]
		public static void SetUnixFileMode(string path, UnixFileMode mode)
		{
			File.SetUnixFileModeCore(path, mode);
		}

		// Token: 0x060081E3 RID: 33251 RVA: 0x001343D9 File Offset: 0x001325D9
		[UnsupportedOSPlatform("windows")]
		public static void SetUnixFileMode(SafeFileHandle fileHandle, UnixFileMode mode)
		{
			File.SetUnixFileModeCore(fileHandle, mode);
		}

		// Token: 0x060081E4 RID: 33252 RVA: 0x001343E2 File Offset: 0x001325E2
		public static FileStream OpenRead(string path)
		{
			return new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read);
		}

		// Token: 0x060081E5 RID: 33253 RVA: 0x001343ED File Offset: 0x001325ED
		public static FileStream OpenWrite(string path)
		{
			return new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
		}

		// Token: 0x060081E6 RID: 33254 RVA: 0x001343F8 File Offset: 0x001325F8
		public static string ReadAllText(string path)
		{
			return File.ReadAllText(path, Encoding.UTF8);
		}

		// Token: 0x060081E7 RID: 33255 RVA: 0x00134408 File Offset: 0x00132608
		public static string ReadAllText(string path, Encoding encoding)
		{
			File.Validate(path, encoding);
			string result;
			using (StreamReader streamReader = new StreamReader(path, encoding, true))
			{
				result = streamReader.ReadToEnd();
			}
			return result;
		}

		// Token: 0x060081E8 RID: 33256 RVA: 0x0013444C File Offset: 0x0013264C
		public static void WriteAllText(string path, [Nullable(2)] string contents)
		{
			File.WriteAllText(path, contents, File.UTF8NoBOM);
		}

		// Token: 0x060081E9 RID: 33257 RVA: 0x0013445A File Offset: 0x0013265A
		[NullableContext(0)]
		public static void WriteAllText([Nullable(1)] string path, ReadOnlySpan<char> contents)
		{
			File.WriteAllText(path, contents, File.UTF8NoBOM);
		}

		// Token: 0x060081EA RID: 33258 RVA: 0x00134468 File Offset: 0x00132668
		public static void WriteAllText(string path, [Nullable(2)] string contents, Encoding encoding)
		{
			File.Validate(path, encoding);
			File.WriteToFile(path, FileMode.Create, contents, encoding);
		}

		// Token: 0x060081EB RID: 33259 RVA: 0x0013447F File Offset: 0x0013267F
		public static void WriteAllText(string path, [Nullable(0)] ReadOnlySpan<char> contents, Encoding encoding)
		{
			File.Validate(path, encoding);
			File.WriteToFile(path, FileMode.Create, contents, encoding);
		}

		// Token: 0x060081EC RID: 33260 RVA: 0x00134494 File Offset: 0x00132694
		public static byte[] ReadAllBytes(string path)
		{
			if (!true)
			{
			}
			FileOptions options = FileOptions.SequentialScan;
			byte[] result;
			using (SafeFileHandle safeFileHandle = File.OpenHandle(path, FileMode.Open, FileAccess.Read, FileShare.Read, options, 0L))
			{
				long num = 0L;
				if (safeFileHandle.CanSeek && (num = safeFileHandle.GetFileLength()) > 2147483591L)
				{
					throw new IOException(SR.IO_FileTooLong2GB);
				}
				if (num == 0L)
				{
					result = File.ReadAllBytesUnknownLength(safeFileHandle);
				}
				else
				{
					int num2 = 0;
					int i = (int)num;
					byte[] array = new byte[i];
					while (i > 0)
					{
						int num3 = RandomAccess.ReadAtOffset(safeFileHandle, array.AsSpan(num2, i), (long)num2);
						if (num3 == 0)
						{
							ThrowHelper.ThrowEndOfFileException();
						}
						num2 += num3;
						i -= num3;
					}
					result = array;
				}
			}
			return result;
		}

		// Token: 0x060081ED RID: 33261 RVA: 0x0013454C File Offset: 0x0013274C
		public static void WriteAllBytes(string path, byte[] bytes)
		{
			ArgumentNullException.ThrowIfNull(bytes, "bytes");
			File.WriteAllBytes(path, new ReadOnlySpan<byte>(bytes));
		}

		// Token: 0x060081EE RID: 33262 RVA: 0x00134568 File Offset: 0x00132768
		[NullableContext(0)]
		public static void WriteAllBytes([Nullable(1)] string path, ReadOnlySpan<byte> bytes)
		{
			ArgumentException.ThrowIfNullOrEmpty(path, "path");
			using (SafeFileHandle safeFileHandle = File.OpenHandle(path, FileMode.Create, FileAccess.Write, FileShare.Read, FileOptions.None, 0L))
			{
				RandomAccess.WriteAtOffset(safeFileHandle, bytes, 0L);
			}
		}

		// Token: 0x060081EF RID: 33263 RVA: 0x001345B4 File Offset: 0x001327B4
		public static void AppendAllBytes(string path, byte[] bytes)
		{
			ArgumentNullException.ThrowIfNull(bytes, "bytes");
			File.AppendAllBytes(path, new ReadOnlySpan<byte>(bytes));
		}

		// Token: 0x060081F0 RID: 33264 RVA: 0x001345D0 File Offset: 0x001327D0
		[NullableContext(0)]
		public static void AppendAllBytes([Nullable(1)] string path, ReadOnlySpan<byte> bytes)
		{
			ArgumentException.ThrowIfNullOrEmpty(path, "path");
			using (SafeFileHandle safeFileHandle = File.OpenHandle(path, FileMode.Append, FileAccess.Write, FileShare.Read, FileOptions.None, 0L))
			{
				long length = RandomAccess.GetLength(safeFileHandle);
				RandomAccess.WriteAtOffset(safeFileHandle, bytes, length);
			}
		}

		// Token: 0x060081F1 RID: 33265 RVA: 0x00134620 File Offset: 0x00132820
		public static Task AppendAllBytesAsync(string path, byte[] bytes, CancellationToken cancellationToken = default(CancellationToken))
		{
			ArgumentNullException.ThrowIfNull(bytes, "bytes");
			return File.AppendAllBytesAsync(path, new ReadOnlyMemory<byte>(bytes), cancellationToken);
		}

		// Token: 0x060081F2 RID: 33266 RVA: 0x0013463A File Offset: 0x0013283A
		public static Task AppendAllBytesAsync(string path, [Nullable(0)] ReadOnlyMemory<byte> bytes, CancellationToken cancellationToken = default(CancellationToken))
		{
			ArgumentException.ThrowIfNullOrEmpty(path, "path");
			if (!cancellationToken.IsCancellationRequested)
			{
				return File.<AppendAllBytesAsync>g__Core|67_0(path, bytes, cancellationToken);
			}
			return Task.FromCanceled(cancellationToken);
		}

		// Token: 0x060081F3 RID: 33267 RVA: 0x0013465F File Offset: 0x0013285F
		public static string[] ReadAllLines(string path)
		{
			return File.ReadAllLines(path, Encoding.UTF8);
		}

		// Token: 0x060081F4 RID: 33268 RVA: 0x0013466C File Offset: 0x0013286C
		public static string[] ReadAllLines(string path, Encoding encoding)
		{
			File.Validate(path, encoding);
			List<string> list = new List<string>();
			string[] result;
			using (StreamReader streamReader = new StreamReader(path, encoding))
			{
				string item;
				while ((item = streamReader.ReadLine()) != null)
				{
					list.Add(item);
				}
				result = list.ToArray();
			}
			return result;
		}

		// Token: 0x060081F5 RID: 33269 RVA: 0x001346C8 File Offset: 0x001328C8
		public static IEnumerable<string> ReadLines(string path)
		{
			return File.ReadLines(path, Encoding.UTF8);
		}

		// Token: 0x060081F6 RID: 33270 RVA: 0x001346D5 File Offset: 0x001328D5
		public static IEnumerable<string> ReadLines(string path, Encoding encoding)
		{
			File.Validate(path, encoding);
			return ReadLinesIterator.CreateIterator(path, encoding);
		}

		// Token: 0x060081F7 RID: 33271 RVA: 0x001346E5 File Offset: 0x001328E5
		public static IAsyncEnumerable<string> ReadLinesAsync(string path, CancellationToken cancellationToken = default(CancellationToken))
		{
			return File.ReadLinesAsync(path, Encoding.UTF8, cancellationToken);
		}

		// Token: 0x060081F8 RID: 33272 RVA: 0x001346F4 File Offset: 0x001328F4
		public static IAsyncEnumerable<string> ReadLinesAsync(string path, Encoding encoding, CancellationToken cancellationToken = default(CancellationToken))
		{
			File.Validate(path, encoding);
			return File.IterateFileLinesAsync(File.AsyncStreamReader(path, encoding), path, encoding, cancellationToken, default(CancellationToken));
		}

		// Token: 0x060081F9 RID: 33273 RVA: 0x00134720 File Offset: 0x00132920
		public static void WriteAllLines(string path, string[] contents)
		{
			File.WriteAllLines(path, contents);
		}

		// Token: 0x060081FA RID: 33274 RVA: 0x00134729 File Offset: 0x00132929
		public static void WriteAllLines(string path, IEnumerable<string> contents)
		{
			File.WriteAllLines(path, contents, File.UTF8NoBOM);
		}

		// Token: 0x060081FB RID: 33275 RVA: 0x00134737 File Offset: 0x00132937
		public static void WriteAllLines(string path, string[] contents, Encoding encoding)
		{
			File.WriteAllLines(path, contents, encoding);
		}

		// Token: 0x060081FC RID: 33276 RVA: 0x00134741 File Offset: 0x00132941
		public static void WriteAllLines(string path, IEnumerable<string> contents, Encoding encoding)
		{
			File.Validate(path, encoding);
			ArgumentNullException.ThrowIfNull(contents, "contents");
			File.InternalWriteAllLines(new StreamWriter(path, false, encoding), contents);
		}

		// Token: 0x060081FD RID: 33277 RVA: 0x00134764 File Offset: 0x00132964
		private static void InternalWriteAllLines(StreamWriter writer, IEnumerable<string> contents)
		{
			try
			{
				foreach (string value in contents)
				{
					writer.WriteLine(value);
				}
			}
			finally
			{
				if (writer != null)
				{
					((IDisposable)writer).Dispose();
				}
			}
		}

		// Token: 0x060081FE RID: 33278 RVA: 0x001347C4 File Offset: 0x001329C4
		public static void AppendAllText(string path, [Nullable(2)] string contents)
		{
			File.AppendAllText(path, contents, File.UTF8NoBOM);
		}

		// Token: 0x060081FF RID: 33279 RVA: 0x001347D2 File Offset: 0x001329D2
		[NullableContext(0)]
		public static void AppendAllText([Nullable(1)] string path, ReadOnlySpan<char> contents)
		{
			File.AppendAllText(path, contents, File.UTF8NoBOM);
		}

		// Token: 0x06008200 RID: 33280 RVA: 0x001347E0 File Offset: 0x001329E0
		public static void AppendAllText(string path, [Nullable(2)] string contents, Encoding encoding)
		{
			File.Validate(path, encoding);
			File.WriteToFile(path, FileMode.Append, contents, encoding);
		}

		// Token: 0x06008201 RID: 33281 RVA: 0x001347F7 File Offset: 0x001329F7
		public static void AppendAllText(string path, [Nullable(0)] ReadOnlySpan<char> contents, Encoding encoding)
		{
			File.Validate(path, encoding);
			File.WriteToFile(path, FileMode.Append, contents, encoding);
		}

		// Token: 0x06008202 RID: 33282 RVA: 0x00134809 File Offset: 0x00132A09
		public static void AppendAllLines(string path, IEnumerable<string> contents)
		{
			File.AppendAllLines(path, contents, File.UTF8NoBOM);
		}

		// Token: 0x06008203 RID: 33283 RVA: 0x00134817 File Offset: 0x00132A17
		public static void AppendAllLines(string path, IEnumerable<string> contents, Encoding encoding)
		{
			File.Validate(path, encoding);
			ArgumentNullException.ThrowIfNull(contents, "contents");
			File.InternalWriteAllLines(new StreamWriter(path, true, encoding), contents);
		}

		// Token: 0x06008204 RID: 33284 RVA: 0x00134839 File Offset: 0x00132A39
		public static void Replace(string sourceFileName, string destinationFileName, [Nullable(2)] string destinationBackupFileName)
		{
			File.Replace(sourceFileName, destinationFileName, destinationBackupFileName, false);
		}

		// Token: 0x06008205 RID: 33285 RVA: 0x00134844 File Offset: 0x00132A44
		public static void Replace(string sourceFileName, string destinationFileName, [Nullable(2)] string destinationBackupFileName, bool ignoreMetadataErrors)
		{
			ArgumentNullException.ThrowIfNull(sourceFileName, "sourceFileName");
			ArgumentNullException.ThrowIfNull(destinationFileName, "destinationFileName");
			FileSystem.ReplaceFile(Path.GetFullPath(sourceFileName), Path.GetFullPath(destinationFileName), (destinationBackupFileName != null) ? Path.GetFullPath(destinationBackupFileName) : null, ignoreMetadataErrors);
		}

		// Token: 0x06008206 RID: 33286 RVA: 0x0013487A File Offset: 0x00132A7A
		public static void Move(string sourceFileName, string destFileName)
		{
			File.Move(sourceFileName, destFileName, false);
		}

		// Token: 0x06008207 RID: 33287 RVA: 0x00134884 File Offset: 0x00132A84
		public static void Move(string sourceFileName, string destFileName, bool overwrite)
		{
			ArgumentException.ThrowIfNullOrEmpty(sourceFileName, "sourceFileName");
			ArgumentException.ThrowIfNullOrEmpty(destFileName, "destFileName");
			string fullPath = Path.GetFullPath(sourceFileName);
			string fullPath2 = Path.GetFullPath(destFileName);
			if (!FileSystem.FileExists(fullPath))
			{
				throw new FileNotFoundException(SR.Format(SR.IO_FileNotFound_FileName, fullPath), fullPath);
			}
			FileSystem.MoveFile(fullPath, fullPath2, overwrite);
		}

		// Token: 0x06008208 RID: 33288 RVA: 0x001348D7 File Offset: 0x00132AD7
		[SupportedOSPlatform("windows")]
		public static void Encrypt(string path)
		{
			ArgumentNullException.ThrowIfNull(path, "path");
			FileSystem.Encrypt(path);
		}

		// Token: 0x06008209 RID: 33289 RVA: 0x001348EA File Offset: 0x00132AEA
		[SupportedOSPlatform("windows")]
		public static void Decrypt(string path)
		{
			ArgumentNullException.ThrowIfNull(path, "path");
			FileSystem.Decrypt(path);
		}

		// Token: 0x0600820A RID: 33290 RVA: 0x001348FD File Offset: 0x00132AFD
		private static StreamReader AsyncStreamReader(string path, Encoding encoding)
		{
			return new StreamReader(new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read, 4096, FileOptions.Asynchronous | FileOptions.SequentialScan), encoding, true);
		}

		// Token: 0x0600820B RID: 33291 RVA: 0x00134919 File Offset: 0x00132B19
		public static Task<string> ReadAllTextAsync(string path, CancellationToken cancellationToken = default(CancellationToken))
		{
			return File.ReadAllTextAsync(path, Encoding.UTF8, cancellationToken);
		}

		// Token: 0x0600820C RID: 33292 RVA: 0x00134927 File Offset: 0x00132B27
		public static Task<string> ReadAllTextAsync(string path, Encoding encoding, CancellationToken cancellationToken = default(CancellationToken))
		{
			File.Validate(path, encoding);
			if (!cancellationToken.IsCancellationRequested)
			{
				return File.InternalReadAllTextAsync(path, encoding, cancellationToken);
			}
			return Task.FromCanceled<string>(cancellationToken);
		}

		// Token: 0x0600820D RID: 33293 RVA: 0x00134948 File Offset: 0x00132B48
		private static Task<string> InternalReadAllTextAsync(string path, Encoding encoding, CancellationToken cancellationToken)
		{
			File.<InternalReadAllTextAsync>d__94 <InternalReadAllTextAsync>d__;
			<InternalReadAllTextAsync>d__.<>t__builder = AsyncTaskMethodBuilder<string>.Create();
			<InternalReadAllTextAsync>d__.path = path;
			<InternalReadAllTextAsync>d__.encoding = encoding;
			<InternalReadAllTextAsync>d__.cancellationToken = cancellationToken;
			<InternalReadAllTextAsync>d__.<>1__state = -1;
			<InternalReadAllTextAsync>d__.<>t__builder.Start<File.<InternalReadAllTextAsync>d__94>(ref <InternalReadAllTextAsync>d__);
			return <InternalReadAllTextAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0600820E RID: 33294 RVA: 0x0013499B File Offset: 0x00132B9B
		public static Task WriteAllTextAsync(string path, [Nullable(2)] string contents, CancellationToken cancellationToken = default(CancellationToken))
		{
			return File.WriteAllTextAsync(path, contents, File.UTF8NoBOM, cancellationToken);
		}

		// Token: 0x0600820F RID: 33295 RVA: 0x001349AA File Offset: 0x00132BAA
		public static Task WriteAllTextAsync(string path, [Nullable(0)] ReadOnlyMemory<char> contents, CancellationToken cancellationToken = default(CancellationToken))
		{
			return File.WriteAllTextAsync(path, contents, File.UTF8NoBOM, cancellationToken);
		}

		// Token: 0x06008210 RID: 33296 RVA: 0x001349B9 File Offset: 0x00132BB9
		public static Task WriteAllTextAsync(string path, [Nullable(2)] string contents, Encoding encoding, CancellationToken cancellationToken = default(CancellationToken))
		{
			return File.WriteAllTextAsync(path, contents.AsMemory(), encoding, cancellationToken);
		}

		// Token: 0x06008211 RID: 33297 RVA: 0x001349C9 File Offset: 0x00132BC9
		public static Task WriteAllTextAsync(string path, [Nullable(0)] ReadOnlyMemory<char> contents, Encoding encoding, CancellationToken cancellationToken = default(CancellationToken))
		{
			File.Validate(path, encoding);
			if (cancellationToken.IsCancellationRequested)
			{
				return Task.FromCanceled(cancellationToken);
			}
			return File.WriteToFileAsync(path, FileMode.Create, contents, encoding, cancellationToken);
		}

		// Token: 0x06008212 RID: 33298 RVA: 0x001349EC File Offset: 0x00132BEC
		public static Task<byte[]> ReadAllBytesAsync(string path, CancellationToken cancellationToken = default(CancellationToken))
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return Task.FromCanceled<byte[]>(cancellationToken);
			}
			FileOptions fileOptions = FileOptions.Asynchronous;
			if (!true)
			{
			}
			FileOptions options = fileOptions | FileOptions.SequentialScan;
			SafeFileHandle safeFileHandle = File.OpenHandle(path, FileMode.Open, FileAccess.Read, FileShare.Read, options, 0L);
			long num = 0L;
			if (safeFileHandle.CanSeek && (num = safeFileHandle.GetFileLength()) > 2147483591L)
			{
				safeFileHandle.Dispose();
				return Task.FromException<byte[]>(ExceptionDispatchInfo.SetCurrentStackTrace(new IOException(SR.IO_FileTooLong2GB)));
			}
			if (num <= 0L)
			{
				return File.InternalReadAllBytesUnknownLengthAsync(safeFileHandle, cancellationToken);
			}
			return File.InternalReadAllBytesAsync(safeFileHandle, (int)num, cancellationToken);
		}

		// Token: 0x06008213 RID: 33299 RVA: 0x00134A74 File Offset: 0x00132C74
		private static Task<byte[]> InternalReadAllBytesAsync(SafeFileHandle sfh, int count, CancellationToken cancellationToken)
		{
			File.<InternalReadAllBytesAsync>d__100 <InternalReadAllBytesAsync>d__;
			<InternalReadAllBytesAsync>d__.<>t__builder = AsyncTaskMethodBuilder<byte[]>.Create();
			<InternalReadAllBytesAsync>d__.sfh = sfh;
			<InternalReadAllBytesAsync>d__.count = count;
			<InternalReadAllBytesAsync>d__.cancellationToken = cancellationToken;
			<InternalReadAllBytesAsync>d__.<>1__state = -1;
			<InternalReadAllBytesAsync>d__.<>t__builder.Start<File.<InternalReadAllBytesAsync>d__100>(ref <InternalReadAllBytesAsync>d__);
			return <InternalReadAllBytesAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06008214 RID: 33300 RVA: 0x00134AC8 File Offset: 0x00132CC8
		private static Task<byte[]> InternalReadAllBytesUnknownLengthAsync(SafeFileHandle sfh, CancellationToken cancellationToken)
		{
			File.<InternalReadAllBytesUnknownLengthAsync>d__101 <InternalReadAllBytesUnknownLengthAsync>d__;
			<InternalReadAllBytesUnknownLengthAsync>d__.<>t__builder = AsyncTaskMethodBuilder<byte[]>.Create();
			<InternalReadAllBytesUnknownLengthAsync>d__.sfh = sfh;
			<InternalReadAllBytesUnknownLengthAsync>d__.cancellationToken = cancellationToken;
			<InternalReadAllBytesUnknownLengthAsync>d__.<>1__state = -1;
			<InternalReadAllBytesUnknownLengthAsync>d__.<>t__builder.Start<File.<InternalReadAllBytesUnknownLengthAsync>d__101>(ref <InternalReadAllBytesUnknownLengthAsync>d__);
			return <InternalReadAllBytesUnknownLengthAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06008215 RID: 33301 RVA: 0x00134B13 File Offset: 0x00132D13
		public static Task WriteAllBytesAsync(string path, byte[] bytes, CancellationToken cancellationToken = default(CancellationToken))
		{
			ArgumentNullException.ThrowIfNull(bytes, "bytes");
			return File.WriteAllBytesAsync(path, new ReadOnlyMemory<byte>(bytes), cancellationToken);
		}

		// Token: 0x06008216 RID: 33302 RVA: 0x00134B2D File Offset: 0x00132D2D
		public static Task WriteAllBytesAsync(string path, [Nullable(0)] ReadOnlyMemory<byte> bytes, CancellationToken cancellationToken = default(CancellationToken))
		{
			ArgumentException.ThrowIfNullOrEmpty(path, "path");
			if (!cancellationToken.IsCancellationRequested)
			{
				return File.<WriteAllBytesAsync>g__Core|103_0(path, bytes, cancellationToken);
			}
			return Task.FromCanceled(cancellationToken);
		}

		// Token: 0x06008217 RID: 33303 RVA: 0x00134B52 File Offset: 0x00132D52
		public static Task<string[]> ReadAllLinesAsync(string path, CancellationToken cancellationToken = default(CancellationToken))
		{
			return File.ReadAllLinesAsync(path, Encoding.UTF8, cancellationToken);
		}

		// Token: 0x06008218 RID: 33304 RVA: 0x00134B60 File Offset: 0x00132D60
		public static Task<string[]> ReadAllLinesAsync(string path, Encoding encoding, CancellationToken cancellationToken = default(CancellationToken))
		{
			File.Validate(path, encoding);
			if (!cancellationToken.IsCancellationRequested)
			{
				return File.InternalReadAllLinesAsync(path, encoding, cancellationToken);
			}
			return Task.FromCanceled<string[]>(cancellationToken);
		}

		// Token: 0x06008219 RID: 33305 RVA: 0x00134B84 File Offset: 0x00132D84
		private static Task<string[]> InternalReadAllLinesAsync(string path, Encoding encoding, CancellationToken cancellationToken)
		{
			File.<InternalReadAllLinesAsync>d__106 <InternalReadAllLinesAsync>d__;
			<InternalReadAllLinesAsync>d__.<>t__builder = AsyncTaskMethodBuilder<string[]>.Create();
			<InternalReadAllLinesAsync>d__.path = path;
			<InternalReadAllLinesAsync>d__.encoding = encoding;
			<InternalReadAllLinesAsync>d__.cancellationToken = cancellationToken;
			<InternalReadAllLinesAsync>d__.<>1__state = -1;
			<InternalReadAllLinesAsync>d__.<>t__builder.Start<File.<InternalReadAllLinesAsync>d__106>(ref <InternalReadAllLinesAsync>d__);
			return <InternalReadAllLinesAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0600821A RID: 33306 RVA: 0x00134BD7 File Offset: 0x00132DD7
		public static Task WriteAllLinesAsync(string path, IEnumerable<string> contents, CancellationToken cancellationToken = default(CancellationToken))
		{
			return File.WriteAllLinesAsync(path, contents, File.UTF8NoBOM, cancellationToken);
		}

		// Token: 0x0600821B RID: 33307 RVA: 0x00134BE6 File Offset: 0x00132DE6
		public static Task WriteAllLinesAsync(string path, IEnumerable<string> contents, Encoding encoding, CancellationToken cancellationToken = default(CancellationToken))
		{
			return File.WriteAllLinesAsync(path, contents, encoding, false, cancellationToken);
		}

		// Token: 0x0600821C RID: 33308 RVA: 0x00134BF4 File Offset: 0x00132DF4
		private static Task WriteAllLinesAsync(string path, IEnumerable<string> contents, Encoding encoding, bool append, CancellationToken cancellationToken)
		{
			File.Validate(path, encoding);
			ArgumentNullException.ThrowIfNull(contents, "contents");
			if (cancellationToken.IsCancellationRequested)
			{
				return Task.FromCanceled(cancellationToken);
			}
			StreamWriter writer;
			try
			{
				writer = new StreamWriter(new FileStream(path, append ? FileMode.Append : FileMode.Create, FileAccess.Write, FileShare.Read, 4096, FileOptions.Asynchronous), encoding);
			}
			catch (Exception exception)
			{
				return Task.FromException(exception);
			}
			return File.InternalWriteAllLinesAsync(writer, contents, cancellationToken);
		}

		// Token: 0x0600821D RID: 33309 RVA: 0x00134C6C File Offset: 0x00132E6C
		private static Task InternalWriteAllLinesAsync(StreamWriter writer, IEnumerable<string> contents, CancellationToken cancellationToken)
		{
			File.<InternalWriteAllLinesAsync>d__110 <InternalWriteAllLinesAsync>d__;
			<InternalWriteAllLinesAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<InternalWriteAllLinesAsync>d__.writer = writer;
			<InternalWriteAllLinesAsync>d__.contents = contents;
			<InternalWriteAllLinesAsync>d__.cancellationToken = cancellationToken;
			<InternalWriteAllLinesAsync>d__.<>1__state = -1;
			<InternalWriteAllLinesAsync>d__.<>t__builder.Start<File.<InternalWriteAllLinesAsync>d__110>(ref <InternalWriteAllLinesAsync>d__);
			return <InternalWriteAllLinesAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0600821E RID: 33310 RVA: 0x00134CBF File Offset: 0x00132EBF
		public static Task AppendAllTextAsync(string path, [Nullable(2)] string contents, CancellationToken cancellationToken = default(CancellationToken))
		{
			return File.AppendAllTextAsync(path, contents, File.UTF8NoBOM, cancellationToken);
		}

		// Token: 0x0600821F RID: 33311 RVA: 0x00134CCE File Offset: 0x00132ECE
		public static Task AppendAllTextAsync(string path, [Nullable(0)] ReadOnlyMemory<char> contents, CancellationToken cancellationToken = default(CancellationToken))
		{
			return File.AppendAllTextAsync(path, contents, File.UTF8NoBOM, cancellationToken);
		}

		// Token: 0x06008220 RID: 33312 RVA: 0x00134CDD File Offset: 0x00132EDD
		public static Task AppendAllTextAsync(string path, [Nullable(2)] string contents, Encoding encoding, CancellationToken cancellationToken = default(CancellationToken))
		{
			return File.AppendAllTextAsync(path, contents.AsMemory(), encoding, cancellationToken);
		}

		// Token: 0x06008221 RID: 33313 RVA: 0x00134CED File Offset: 0x00132EED
		public static Task AppendAllTextAsync(string path, [Nullable(0)] ReadOnlyMemory<char> contents, Encoding encoding, CancellationToken cancellationToken = default(CancellationToken))
		{
			File.Validate(path, encoding);
			if (cancellationToken.IsCancellationRequested)
			{
				return Task.FromCanceled(cancellationToken);
			}
			return File.WriteToFileAsync(path, FileMode.Append, contents, encoding, cancellationToken);
		}

		// Token: 0x06008222 RID: 33314 RVA: 0x00134D10 File Offset: 0x00132F10
		public static Task AppendAllLinesAsync(string path, IEnumerable<string> contents, CancellationToken cancellationToken = default(CancellationToken))
		{
			return File.AppendAllLinesAsync(path, contents, File.UTF8NoBOM, cancellationToken);
		}

		// Token: 0x06008223 RID: 33315 RVA: 0x00134D1F File Offset: 0x00132F1F
		public static Task AppendAllLinesAsync(string path, IEnumerable<string> contents, Encoding encoding, CancellationToken cancellationToken = default(CancellationToken))
		{
			return File.WriteAllLinesAsync(path, contents, encoding, true, cancellationToken);
		}

		// Token: 0x06008224 RID: 33316 RVA: 0x00134D2C File Offset: 0x00132F2C
		public static FileSystemInfo CreateSymbolicLink(string path, string pathToTarget)
		{
			string fullPath = Path.GetFullPath(path);
			FileSystem.VerifyValidPath(pathToTarget, "pathToTarget");
			FileSystem.CreateSymbolicLink(path, pathToTarget, false);
			return new FileInfo(path, fullPath, null, true);
		}

		// Token: 0x06008225 RID: 33317 RVA: 0x00134D5C File Offset: 0x00132F5C
		[return: Nullable(2)]
		public static FileSystemInfo ResolveLinkTarget(string linkPath, bool returnFinalTarget)
		{
			FileSystem.VerifyValidPath(linkPath, "linkPath");
			return FileSystem.ResolveLinkTarget(linkPath, returnFinalTarget, false);
		}

		// Token: 0x06008226 RID: 33318 RVA: 0x00134D71 File Offset: 0x00132F71
		private static void Validate(string path, Encoding encoding)
		{
			ArgumentException.ThrowIfNullOrEmpty(path, "path");
			ArgumentNullException.ThrowIfNull(encoding, "encoding");
		}

		// Token: 0x06008227 RID: 33319 RVA: 0x00134D8C File Offset: 0x00132F8C
		private unsafe static byte[] ReadAllBytesUnknownLength(SafeFileHandle sfh)
		{
			byte[] array = null;
			Span<byte> span = new Span<byte>(stackalloc byte[(UIntPtr)512], 512);
			byte[] result;
			try
			{
				int num = 0;
				for (;;)
				{
					if (num == span.Length)
					{
						uint num2 = (uint)(span.Length * 2);
						if ((ulong)num2 > 2147483591UL)
						{
							num2 = (uint)Math.Max(2147483591, span.Length + 1);
						}
						byte[] array2 = ArrayPool<byte>.Shared.Rent((int)num2);
						span.CopyTo(array2);
						byte[] array3 = array;
						span = (array = array2);
						if (array3 != null)
						{
							ArrayPool<byte>.Shared.Return(array3, false);
						}
					}
					int num3 = RandomAccess.ReadAtOffset(sfh, span.Slice(num), (long)num);
					if (num3 == 0)
					{
						break;
					}
					num += num3;
				}
				result = span.Slice(0, num).ToArray();
			}
			finally
			{
				if (array != null)
				{
					ArrayPool<byte>.Shared.Return(array, false);
				}
			}
			return result;
		}

		// Token: 0x06008228 RID: 33320 RVA: 0x00134E74 File Offset: 0x00133074
		private unsafe static void WriteToFile(string path, FileMode mode, ReadOnlySpan<char> contents, Encoding encoding)
		{
			ReadOnlySpan<byte> buffer = encoding.GetPreamble();
			int num = buffer.Length;
			using (SafeFileHandle safeFileHandle = File.OpenHandle(path, mode, FileAccess.Write, FileShare.Read, FileOptions.None, File.GetPreallocationSize(mode, contents, encoding, num)))
			{
				long num2 = (mode == FileMode.Append && safeFileHandle.CanSeek) ? RandomAccess.GetLength(safeFileHandle) : 0L;
				if (contents.IsEmpty)
				{
					if (num > 0 && num2 == 0L)
					{
						RandomAccess.WriteAtOffset(safeFileHandle, buffer, num2);
					}
				}
				else
				{
					int num3 = num + encoding.GetMaxByteCount(Math.Min(contents.Length, 8192));
					byte[] array = null;
					Span<byte> span;
					if (num3 <= 1024)
					{
						span = new Span<byte>(stackalloc byte[(UIntPtr)1024], 1024);
					}
					else
					{
						span = (array = ArrayPool<byte>.Shared.Rent(num3));
					}
					Span<byte> destination = span;
					try
					{
						if (num2 == 0L)
						{
							buffer.CopyTo(destination);
						}
						else
						{
							num = 0;
						}
						Encoder encoder = encoding.GetEncoder();
						while (!contents.IsEmpty)
						{
							ReadOnlySpan<char> chars = contents.Slice(0, Math.Min(contents.Length, 8192));
							contents = contents.Slice(chars.Length);
							int bytes = encoder.GetBytes(chars, destination.Slice(num), contents.IsEmpty);
							Span<byte> span2 = destination.Slice(0, num + bytes);
							RandomAccess.WriteAtOffset(safeFileHandle, span2, num2);
							num2 += (long)span2.Length;
							num = 0;
						}
					}
					finally
					{
						if (array != null)
						{
							ArrayPool<byte>.Shared.Return(array, false);
						}
					}
				}
			}
		}

		// Token: 0x06008229 RID: 33321 RVA: 0x00135018 File Offset: 0x00133218
		private static Task WriteToFileAsync(string path, FileMode mode, ReadOnlyMemory<char> contents, Encoding encoding, CancellationToken cancellationToken)
		{
			File.<WriteToFileAsync>d__122 <WriteToFileAsync>d__;
			<WriteToFileAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<WriteToFileAsync>d__.path = path;
			<WriteToFileAsync>d__.mode = mode;
			<WriteToFileAsync>d__.contents = contents;
			<WriteToFileAsync>d__.encoding = encoding;
			<WriteToFileAsync>d__.cancellationToken = cancellationToken;
			<WriteToFileAsync>d__.<>1__state = -1;
			<WriteToFileAsync>d__.<>t__builder.Start<File.<WriteToFileAsync>d__122>(ref <WriteToFileAsync>d__);
			return <WriteToFileAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0600822A RID: 33322 RVA: 0x0013507C File Offset: 0x0013327C
		private static long GetPreallocationSize(FileMode mode, ReadOnlySpan<char> contents, Encoding encoding, int preambleSize)
		{
			if (contents.Length < 8192)
			{
				return 0L;
			}
			if (mode == FileMode.Append)
			{
				return 0L;
			}
			return (long)(preambleSize + encoding.GetByteCount(contents));
		}

		// Token: 0x0600822B RID: 33323 RVA: 0x001350A0 File Offset: 0x001332A0
		[AsyncIteratorStateMachine(typeof(File.<IterateFileLinesAsync>d__124))]
		private static IAsyncEnumerable<string> IterateFileLinesAsync(StreamReader sr, string path, Encoding encoding, CancellationToken ctEnumerable, [EnumeratorCancellation] CancellationToken ctEnumerator = default(CancellationToken))
		{
			File.<IterateFileLinesAsync>d__124 <IterateFileLinesAsync>d__ = new File.<IterateFileLinesAsync>d__124(-2);
			<IterateFileLinesAsync>d__.<>3__sr = sr;
			<IterateFileLinesAsync>d__.<>3__path = path;
			<IterateFileLinesAsync>d__.<>3__encoding = encoding;
			<IterateFileLinesAsync>d__.<>3__ctEnumerable = ctEnumerable;
			<IterateFileLinesAsync>d__.<>3__ctEnumerator = ctEnumerator;
			return <IterateFileLinesAsync>d__;
		}

		// Token: 0x0600822C RID: 33324 RVA: 0x00133731 File Offset: 0x00131931
		private static UnixFileMode GetUnixFileModeCore(string path)
		{
			throw new PlatformNotSupportedException(SR.PlatformNotSupported_UnixFileMode);
		}

		// Token: 0x0600822D RID: 33325 RVA: 0x00133731 File Offset: 0x00131931
		private static UnixFileMode GetUnixFileModeCore(SafeFileHandle fileHandle)
		{
			throw new PlatformNotSupportedException(SR.PlatformNotSupported_UnixFileMode);
		}

		// Token: 0x0600822E RID: 33326 RVA: 0x00133731 File Offset: 0x00131931
		private static void SetUnixFileModeCore(string path, UnixFileMode mode)
		{
			throw new PlatformNotSupportedException(SR.PlatformNotSupported_UnixFileMode);
		}

		// Token: 0x0600822F RID: 33327 RVA: 0x00133731 File Offset: 0x00131931
		private static void SetUnixFileModeCore(SafeFileHandle fileHandle, UnixFileMode mode)
		{
			throw new PlatformNotSupportedException(SR.PlatformNotSupported_UnixFileMode);
		}

		// Token: 0x06008230 RID: 33328 RVA: 0x001350D0 File Offset: 0x001332D0
		[CompilerGenerated]
		internal static Task <AppendAllBytesAsync>g__Core|67_0(string path, ReadOnlyMemory<byte> bytes, CancellationToken cancellationToken)
		{
			File.<<AppendAllBytesAsync>g__Core|67_0>d <<AppendAllBytesAsync>g__Core|67_0>d;
			<<AppendAllBytesAsync>g__Core|67_0>d.<>t__builder = AsyncTaskMethodBuilder.Create();
			<<AppendAllBytesAsync>g__Core|67_0>d.path = path;
			<<AppendAllBytesAsync>g__Core|67_0>d.bytes = bytes;
			<<AppendAllBytesAsync>g__Core|67_0>d.cancellationToken = cancellationToken;
			<<AppendAllBytesAsync>g__Core|67_0>d.<>1__state = -1;
			<<AppendAllBytesAsync>g__Core|67_0>d.<>t__builder.Start<File.<<AppendAllBytesAsync>g__Core|67_0>d>(ref <<AppendAllBytesAsync>g__Core|67_0>d);
			return <<AppendAllBytesAsync>g__Core|67_0>d.<>t__builder.Task;
		}

		// Token: 0x06008231 RID: 33329 RVA: 0x00135124 File Offset: 0x00133324
		[CompilerGenerated]
		internal static Task <WriteAllBytesAsync>g__Core|103_0(string path, ReadOnlyMemory<byte> bytes, CancellationToken cancellationToken)
		{
			File.<<WriteAllBytesAsync>g__Core|103_0>d <<WriteAllBytesAsync>g__Core|103_0>d;
			<<WriteAllBytesAsync>g__Core|103_0>d.<>t__builder = AsyncTaskMethodBuilder.Create();
			<<WriteAllBytesAsync>g__Core|103_0>d.path = path;
			<<WriteAllBytesAsync>g__Core|103_0>d.bytes = bytes;
			<<WriteAllBytesAsync>g__Core|103_0>d.cancellationToken = cancellationToken;
			<<WriteAllBytesAsync>g__Core|103_0>d.<>1__state = -1;
			<<WriteAllBytesAsync>g__Core|103_0>d.<>t__builder.Start<File.<<WriteAllBytesAsync>g__Core|103_0>d>(ref <<WriteAllBytesAsync>g__Core|103_0>d);
			return <<WriteAllBytesAsync>g__Core|103_0>d.<>t__builder.Task;
		}

		// Token: 0x04001B21 RID: 6945
		private static Encoding s_UTF8NoBOM;
	}
}

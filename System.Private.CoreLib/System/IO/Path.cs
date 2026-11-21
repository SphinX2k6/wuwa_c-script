using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace System.IO
{
	// Token: 0x02000805 RID: 2053
	[NullableContext(1)]
	[Nullable(0)]
	public static class Path
	{
		// Token: 0x0600836E RID: 33646 RVA: 0x00139AA0 File Offset: 0x00137CA0
		[NullableContext(2)]
		[return: NotNullIfNotNull("path")]
		public static string ChangeExtension(string path, string extension)
		{
			if (path == null)
			{
				return null;
			}
			int num = path.Length;
			if (num == 0)
			{
				return string.Empty;
			}
			for (int i = path.Length - 1; i >= 0; i--)
			{
				char c = path[i];
				if (c == '.')
				{
					num = i;
					break;
				}
				if (PathInternal.IsDirectorySeparator(c))
				{
					break;
				}
			}
			if (extension == null)
			{
				return path.Substring(0, num);
			}
			ReadOnlySpan<char> str = path.AsSpan(0, num);
			if (!extension.StartsWith('.'))
			{
				return str + "." + extension;
			}
			return str + extension;
		}

		// Token: 0x0600836F RID: 33647 RVA: 0x00139B30 File Offset: 0x00137D30
		[NullableContext(2)]
		public static bool Exists([NotNullWhen(true)] string path)
		{
			if (string.IsNullOrEmpty(path))
			{
				return false;
			}
			string fullPath;
			try
			{
				fullPath = Path.GetFullPath(path);
			}
			catch (Exception ex) when (ex is ArgumentException || ex is IOException || ex is UnauthorizedAccessException)
			{
				return false;
			}
			bool result;
			bool flag = Path.ExistsCore(fullPath, out result);
			if (flag)
			{
				string text = fullPath;
				if (PathInternal.IsDirectorySeparator(text[text.Length - 1]))
				{
					return result;
				}
			}
			return flag;
		}

		// Token: 0x06008370 RID: 33648 RVA: 0x00139BC4 File Offset: 0x00137DC4
		[NullableContext(2)]
		public static string GetDirectoryName(string path)
		{
			if (path == null || PathInternal.IsEffectivelyEmpty(path.AsSpan()))
			{
				return null;
			}
			int directoryNameOffset = Path.GetDirectoryNameOffset(path.AsSpan());
			if (directoryNameOffset < 0)
			{
				return null;
			}
			return PathInternal.NormalizeDirectorySeparators(path.Substring(0, directoryNameOffset));
		}

		// Token: 0x06008371 RID: 33649 RVA: 0x00139C04 File Offset: 0x00137E04
		[NullableContext(0)]
		public static ReadOnlySpan<char> GetDirectoryName(ReadOnlySpan<char> path)
		{
			if (PathInternal.IsEffectivelyEmpty(path))
			{
				return ReadOnlySpan<char>.Empty;
			}
			int directoryNameOffset = Path.GetDirectoryNameOffset(path);
			if (directoryNameOffset < 0)
			{
				return ReadOnlySpan<char>.Empty;
			}
			return path.Slice(0, directoryNameOffset);
		}

		// Token: 0x06008372 RID: 33650 RVA: 0x00139C3C File Offset: 0x00137E3C
		internal unsafe static int GetDirectoryNameOffset(ReadOnlySpan<char> path)
		{
			int rootLength = PathInternal.GetRootLength(path);
			int i = path.Length;
			if (i <= rootLength)
			{
				return -1;
			}
			while (i > rootLength)
			{
				if (PathInternal.IsDirectorySeparator((char)(*path[--i])))
				{
					break;
				}
			}
			while (i > rootLength && PathInternal.IsDirectorySeparator((char)(*path[i - 1])))
			{
				i--;
			}
			return i;
		}

		// Token: 0x06008373 RID: 33651 RVA: 0x00139C94 File Offset: 0x00137E94
		[NullableContext(2)]
		[return: NotNullIfNotNull("path")]
		public static string GetExtension(string path)
		{
			if (path == null)
			{
				return null;
			}
			return Path.GetExtension(path.AsSpan()).ToString();
		}

		// Token: 0x06008374 RID: 33652 RVA: 0x00139CC0 File Offset: 0x00137EC0
		[NullableContext(0)]
		public unsafe static ReadOnlySpan<char> GetExtension(ReadOnlySpan<char> path)
		{
			int length = path.Length;
			int i = length - 1;
			while (i >= 0)
			{
				char c = (char)(*path[i]);
				if (c == '.')
				{
					if (i != length - 1)
					{
						return path.Slice(i, length - i);
					}
					return ReadOnlySpan<char>.Empty;
				}
				else
				{
					if (PathInternal.IsDirectorySeparator(c))
					{
						break;
					}
					i--;
				}
			}
			return ReadOnlySpan<char>.Empty;
		}

		// Token: 0x06008375 RID: 33653 RVA: 0x00139D18 File Offset: 0x00137F18
		[NullableContext(2)]
		[return: NotNullIfNotNull("path")]
		public static string GetFileName(string path)
		{
			if (path == null)
			{
				return null;
			}
			ReadOnlySpan<char> fileName = Path.GetFileName(path.AsSpan());
			if (path.Length == fileName.Length)
			{
				return path;
			}
			return fileName.ToString();
		}

		// Token: 0x06008376 RID: 33654 RVA: 0x00139D54 File Offset: 0x00137F54
		[NullableContext(0)]
		public static ReadOnlySpan<char> GetFileName(ReadOnlySpan<char> path)
		{
			int length = Path.GetPathRoot(path).Length;
			int num = path.LastIndexOfAny('\\', '/');
			return path.Slice((num < length) ? length : (num + 1));
		}

		// Token: 0x06008377 RID: 33655 RVA: 0x00139D8C File Offset: 0x00137F8C
		[NullableContext(2)]
		[return: NotNullIfNotNull("path")]
		public static string GetFileNameWithoutExtension(string path)
		{
			if (path == null)
			{
				return null;
			}
			ReadOnlySpan<char> fileNameWithoutExtension = Path.GetFileNameWithoutExtension(path.AsSpan());
			if (path.Length == fileNameWithoutExtension.Length)
			{
				return path;
			}
			return fileNameWithoutExtension.ToString();
		}

		// Token: 0x06008378 RID: 33656 RVA: 0x00139DC8 File Offset: 0x00137FC8
		[NullableContext(0)]
		public static ReadOnlySpan<char> GetFileNameWithoutExtension(ReadOnlySpan<char> path)
		{
			ReadOnlySpan<char> fileName = Path.GetFileName(path);
			int num = fileName.LastIndexOf('.');
			if (num >= 0)
			{
				return fileName.Slice(0, num);
			}
			return fileName;
		}

		// Token: 0x06008379 RID: 33657 RVA: 0x00139DF4 File Offset: 0x00137FF4
		public unsafe static string GetRandomFileName()
		{
			byte* ptr = stackalloc byte[(UIntPtr)8];
			Interop.GetRandomBytes(ptr, 8);
			return string.Create<IntPtr>(12, ptr, delegate(Span<char> span, IntPtr key)
			{
				Path.Populate83FileNameFromRandomBytes(key, 8, span);
			});
		}

		// Token: 0x0600837A RID: 33658 RVA: 0x00139E34 File Offset: 0x00138034
		public static bool IsPathFullyQualified(string path)
		{
			ArgumentNullException.ThrowIfNull(path, "path");
			return Path.IsPathFullyQualified(path.AsSpan());
		}

		// Token: 0x0600837B RID: 33659 RVA: 0x00139E4C File Offset: 0x0013804C
		[NullableContext(0)]
		public static bool IsPathFullyQualified(ReadOnlySpan<char> path)
		{
			return !PathInternal.IsPartiallyQualified(path);
		}

		// Token: 0x0600837C RID: 33660 RVA: 0x00139E57 File Offset: 0x00138057
		[NullableContext(2)]
		public static bool HasExtension([NotNullWhen(true)] string path)
		{
			return path != null && Path.HasExtension(path.AsSpan());
		}

		// Token: 0x0600837D RID: 33661 RVA: 0x00139E6C File Offset: 0x0013806C
		[NullableContext(0)]
		public unsafe static bool HasExtension(ReadOnlySpan<char> path)
		{
			for (int i = path.Length - 1; i >= 0; i--)
			{
				char c = (char)(*path[i]);
				if (c == '.')
				{
					return i != path.Length - 1;
				}
				if (PathInternal.IsDirectorySeparator(c))
				{
					break;
				}
			}
			return false;
		}

		// Token: 0x0600837E RID: 33662 RVA: 0x00139EB5 File Offset: 0x001380B5
		public static string Combine(string path1, string path2)
		{
			ArgumentNullException.ThrowIfNull(path1, "path1");
			ArgumentNullException.ThrowIfNull(path2, "path2");
			return Path.CombineInternal(path1, path2);
		}

		// Token: 0x0600837F RID: 33663 RVA: 0x00139ED4 File Offset: 0x001380D4
		public static string Combine(string path1, string path2, string path3)
		{
			ArgumentNullException.ThrowIfNull(path1, "path1");
			ArgumentNullException.ThrowIfNull(path2, "path2");
			ArgumentNullException.ThrowIfNull(path3, "path3");
			return Path.CombineInternal(path1, path2, path3);
		}

		// Token: 0x06008380 RID: 33664 RVA: 0x00139EFF File Offset: 0x001380FF
		public static string Combine(string path1, string path2, string path3, string path4)
		{
			ArgumentNullException.ThrowIfNull(path1, "path1");
			ArgumentNullException.ThrowIfNull(path2, "path2");
			ArgumentNullException.ThrowIfNull(path3, "path3");
			ArgumentNullException.ThrowIfNull(path4, "path4");
			return Path.CombineInternal(path1, path2, path3, path4);
		}

		// Token: 0x06008381 RID: 33665 RVA: 0x00139F36 File Offset: 0x00138136
		public static string Combine(params string[] paths)
		{
			ArgumentNullException.ThrowIfNull(paths, "paths");
			return Path.Combine(paths);
		}

		// Token: 0x06008382 RID: 33666 RVA: 0x00139F50 File Offset: 0x00138150
		public unsafe static string Combine([ParamCollection] [ScopedRef] [Nullable(new byte[]
		{
			0,
			1
		})] ReadOnlySpan<string> paths)
		{
			int num = 0;
			int num2 = 0;
			for (int i = 0; i < paths.Length; i++)
			{
				ArgumentNullException.ThrowIfNull(*paths[i], "paths");
				if (paths[i]->Length != 0)
				{
					if (Path.IsPathRooted(*paths[i]))
					{
						num2 = i;
						num = paths[i]->Length;
					}
					else
					{
						num += paths[i]->Length;
					}
					object obj = *paths[i];
					if (!PathInternal.IsDirectorySeparator(obj[obj.Length - 1]))
					{
						num++;
					}
				}
			}
			Span<char> initialBuffer = new Span<char>(stackalloc byte[(UIntPtr)520], 260);
			ValueStringBuilder valueStringBuilder = new ValueStringBuilder(initialBuffer);
			valueStringBuilder.EnsureCapacity(num);
			for (int j = num2; j < paths.Length; j++)
			{
				if (paths[j]->Length != 0)
				{
					if (valueStringBuilder.Length == 0)
					{
						valueStringBuilder.Append(*paths[j]);
					}
					else
					{
						if (!PathInternal.IsDirectorySeparator(*valueStringBuilder[valueStringBuilder.Length - 1]))
						{
							valueStringBuilder.Append('\\');
						}
						valueStringBuilder.Append(*paths[j]);
					}
				}
			}
			return valueStringBuilder.ToString();
		}

		// Token: 0x06008383 RID: 33667 RVA: 0x0013A094 File Offset: 0x00138294
		[NullableContext(0)]
		[return: Nullable(1)]
		public static string Join(ReadOnlySpan<char> path1, ReadOnlySpan<char> path2)
		{
			if (path1.Length == 0)
			{
				return path2.ToString();
			}
			if (path2.Length == 0)
			{
				return path1.ToString();
			}
			return Path.JoinInternal(path1, path2);
		}

		// Token: 0x06008384 RID: 33668 RVA: 0x0013A0CB File Offset: 0x001382CB
		[NullableContext(0)]
		[return: Nullable(1)]
		public static string Join(ReadOnlySpan<char> path1, ReadOnlySpan<char> path2, ReadOnlySpan<char> path3)
		{
			if (path1.Length == 0)
			{
				return Path.Join(path2, path3);
			}
			if (path2.Length == 0)
			{
				return Path.Join(path1, path3);
			}
			if (path3.Length == 0)
			{
				return Path.Join(path1, path2);
			}
			return Path.JoinInternal(path1, path2, path3);
		}

		// Token: 0x06008385 RID: 33669 RVA: 0x0013A108 File Offset: 0x00138308
		[NullableContext(0)]
		[return: Nullable(1)]
		public static string Join(ReadOnlySpan<char> path1, ReadOnlySpan<char> path2, ReadOnlySpan<char> path3, ReadOnlySpan<char> path4)
		{
			if (path1.Length == 0)
			{
				return Path.Join(path2, path3, path4);
			}
			if (path2.Length == 0)
			{
				return Path.Join(path1, path3, path4);
			}
			if (path3.Length == 0)
			{
				return Path.Join(path1, path2, path4);
			}
			if (path4.Length == 0)
			{
				return Path.Join(path1, path2, path3);
			}
			return Path.JoinInternal(path1, path2, path3, path4);
		}

		// Token: 0x06008386 RID: 33670 RVA: 0x0013A166 File Offset: 0x00138366
		[NullableContext(2)]
		[return: Nullable(1)]
		public static string Join(string path1, string path2)
		{
			if (string.IsNullOrEmpty(path1))
			{
				return path2 ?? string.Empty;
			}
			if (string.IsNullOrEmpty(path2))
			{
				return path1;
			}
			return Path.JoinInternal(path1, path2);
		}

		// Token: 0x06008387 RID: 33671 RVA: 0x0013A198 File Offset: 0x00138398
		[NullableContext(2)]
		[return: Nullable(1)]
		public static string Join(string path1, string path2, string path3)
		{
			if (string.IsNullOrEmpty(path1))
			{
				return Path.Join(path2, path3);
			}
			if (string.IsNullOrEmpty(path2))
			{
				return Path.Join(path1, path3);
			}
			if (string.IsNullOrEmpty(path3))
			{
				return Path.Join(path1, path2);
			}
			return Path.JoinInternal(path1, path2, path3);
		}

		// Token: 0x06008388 RID: 33672 RVA: 0x0013A1EC File Offset: 0x001383EC
		[NullableContext(2)]
		[return: Nullable(1)]
		public static string Join(string path1, string path2, string path3, string path4)
		{
			if (string.IsNullOrEmpty(path1))
			{
				return Path.Join(path2, path3, path4);
			}
			if (string.IsNullOrEmpty(path2))
			{
				return Path.Join(path1, path3, path4);
			}
			if (string.IsNullOrEmpty(path3))
			{
				return Path.Join(path1, path2, path4);
			}
			if (string.IsNullOrEmpty(path4))
			{
				return Path.Join(path1, path2, path3);
			}
			return Path.JoinInternal(path1, path2, path3, path4);
		}

		// Token: 0x06008389 RID: 33673 RVA: 0x0013A25A File Offset: 0x0013845A
		public static string Join([Nullable(new byte[]
		{
			1,
			2
		})] params string[] paths)
		{
			ArgumentNullException.ThrowIfNull(paths, "paths");
			return Path.Join(paths);
		}

		// Token: 0x0600838A RID: 33674 RVA: 0x0013A274 File Offset: 0x00138474
		public unsafe static string Join([ParamCollection] [ScopedRef] [Nullable(new byte[]
		{
			0,
			2
		})] ReadOnlySpan<string> paths)
		{
			if (paths.IsEmpty)
			{
				return string.Empty;
			}
			int num = 0;
			ReadOnlySpan<string> readOnlySpan = paths;
			for (int i = 0; i < readOnlySpan.Length; i++)
			{
				string text = *readOnlySpan[i];
				num += ((text != null) ? text.Length : 0);
			}
			num += paths.Length - 1;
			Span<char> initialBuffer = new Span<char>(stackalloc byte[(UIntPtr)520], 260);
			ValueStringBuilder valueStringBuilder = new ValueStringBuilder(initialBuffer);
			valueStringBuilder.EnsureCapacity(num);
			for (int j = 0; j < paths.Length; j++)
			{
				string text2 = *paths[j];
				if (!string.IsNullOrEmpty(text2))
				{
					if (valueStringBuilder.Length == 0)
					{
						valueStringBuilder.Append(text2);
					}
					else
					{
						if (!PathInternal.IsDirectorySeparator(*valueStringBuilder[valueStringBuilder.Length - 1]) && !PathInternal.IsDirectorySeparator(text2[0]))
						{
							valueStringBuilder.Append('\\');
						}
						valueStringBuilder.Append(text2);
					}
				}
			}
			return valueStringBuilder.ToString();
		}

		// Token: 0x0600838B RID: 33675 RVA: 0x0013A378 File Offset: 0x00138578
		[NullableContext(0)]
		public unsafe static bool TryJoin(ReadOnlySpan<char> path1, ReadOnlySpan<char> path2, Span<char> destination, out int charsWritten)
		{
			charsWritten = 0;
			if (path1.Length == 0 && path2.Length == 0)
			{
				return true;
			}
			if (path1.Length == 0 || path2.Length == 0)
			{
				ref ReadOnlySpan<char> ptr = ref (path1.Length == 0) ? ref path2 : ref path1;
				if (destination.Length < ptr.Length)
				{
					return false;
				}
				ptr.CopyTo(destination);
				charsWritten = ptr.Length;
				return true;
			}
			else
			{
				bool flag = !Path.EndsInDirectorySeparator(path1) && !PathInternal.StartsWithDirectorySeparator(path2);
				int num = path1.Length + path2.Length + ((flag > false) ? 1 : 0);
				if (destination.Length < num)
				{
					return false;
				}
				path1.CopyTo(destination);
				if (flag)
				{
					*destination[path1.Length] = Path.DirectorySeparatorChar;
				}
				path2.CopyTo(destination.Slice(path1.Length + ((flag > false) ? 1 : 0)));
				charsWritten = num;
				return true;
			}
		}

		// Token: 0x0600838C RID: 33676 RVA: 0x0013A454 File Offset: 0x00138654
		[NullableContext(0)]
		public unsafe static bool TryJoin(ReadOnlySpan<char> path1, ReadOnlySpan<char> path2, ReadOnlySpan<char> path3, Span<char> destination, out int charsWritten)
		{
			charsWritten = 0;
			if (path1.Length == 0 && path2.Length == 0 && path3.Length == 0)
			{
				return true;
			}
			if (path1.Length == 0)
			{
				return Path.TryJoin(path2, path3, destination, out charsWritten);
			}
			if (path2.Length == 0)
			{
				return Path.TryJoin(path1, path3, destination, out charsWritten);
			}
			if (path3.Length == 0)
			{
				return Path.TryJoin(path1, path2, destination, out charsWritten);
			}
			int num = (Path.EndsInDirectorySeparator(path1) || PathInternal.StartsWithDirectorySeparator(path2)) ? 0 : 1;
			bool flag = !Path.EndsInDirectorySeparator(path2) && !PathInternal.StartsWithDirectorySeparator(path3);
			if (flag)
			{
				num++;
			}
			int num2 = path1.Length + path2.Length + path3.Length + num;
			if (destination.Length < num2)
			{
				return false;
			}
			Path.TryJoin(path1, path2, destination, out charsWritten);
			if (flag)
			{
				int num3 = charsWritten;
				charsWritten = num3 + 1;
				*destination[num3] = Path.DirectorySeparatorChar;
			}
			path3.CopyTo(destination.Slice(charsWritten));
			charsWritten += path3.Length;
			return true;
		}

		// Token: 0x0600838D RID: 33677 RVA: 0x0013A55B File Offset: 0x0013875B
		private static string CombineInternal(string first, string second)
		{
			if (string.IsNullOrEmpty(first))
			{
				return second;
			}
			if (string.IsNullOrEmpty(second))
			{
				return first;
			}
			if (Path.IsPathRooted(second.AsSpan()))
			{
				return second;
			}
			return Path.JoinInternal(first.AsSpan(), second.AsSpan());
		}

		// Token: 0x0600838E RID: 33678 RVA: 0x0013A594 File Offset: 0x00138794
		private static string CombineInternal(string first, string second, string third)
		{
			if (string.IsNullOrEmpty(first))
			{
				return Path.CombineInternal(second, third);
			}
			if (string.IsNullOrEmpty(second))
			{
				return Path.CombineInternal(first, third);
			}
			if (string.IsNullOrEmpty(third))
			{
				return Path.CombineInternal(first, second);
			}
			if (Path.IsPathRooted(third.AsSpan()))
			{
				return third;
			}
			if (Path.IsPathRooted(second.AsSpan()))
			{
				return Path.CombineInternal(second, third);
			}
			return Path.JoinInternal(first.AsSpan(), second.AsSpan(), third.AsSpan());
		}

		// Token: 0x0600838F RID: 33679 RVA: 0x0013A60C File Offset: 0x0013880C
		private static string CombineInternal(string first, string second, string third, string fourth)
		{
			if (string.IsNullOrEmpty(first))
			{
				return Path.CombineInternal(second, third, fourth);
			}
			if (string.IsNullOrEmpty(second))
			{
				return Path.CombineInternal(first, third, fourth);
			}
			if (string.IsNullOrEmpty(third))
			{
				return Path.CombineInternal(first, second, fourth);
			}
			if (string.IsNullOrEmpty(fourth))
			{
				return Path.CombineInternal(first, second, third);
			}
			if (Path.IsPathRooted(fourth.AsSpan()))
			{
				return fourth;
			}
			if (Path.IsPathRooted(third.AsSpan()))
			{
				return Path.CombineInternal(third, fourth);
			}
			if (Path.IsPathRooted(second.AsSpan()))
			{
				return Path.CombineInternal(second, third, fourth);
			}
			return Path.JoinInternal(first.AsSpan(), second.AsSpan(), third.AsSpan(), fourth.AsSpan());
		}

		// Token: 0x06008390 RID: 33680 RVA: 0x0013A6B4 File Offset: 0x001388B4
		private unsafe static string JoinInternal(ReadOnlySpan<char> first, ReadOnlySpan<char> second)
		{
			if (!PathInternal.IsDirectorySeparator((char)(*first[first.Length - 1])) && !PathInternal.IsDirectorySeparator((char)(*second[0])))
			{
				return first + "\\" + second;
			}
			return first + second;
		}

		// Token: 0x06008391 RID: 33681 RVA: 0x0013A704 File Offset: 0x00138904
		private unsafe static string JoinInternal(ReadOnlySpan<char> first, ReadOnlySpan<char> second, ReadOnlySpan<char> third)
		{
			bool flag = PathInternal.IsDirectorySeparator((char)(*first[first.Length - 1])) || PathInternal.IsDirectorySeparator((char)(*second[0]));
			bool flag2 = PathInternal.IsDirectorySeparator((char)(*second[second.Length - 1])) || PathInternal.IsDirectorySeparator((char)(*third[0]));
			string result;
			if (!flag)
			{
				if (flag2)
				{
					result = first + "\\" + second + third;
				}
				else
				{
					result = first + "\\" + second + "\\" + third;
				}
			}
			else if (flag2)
			{
				result = first + second + third;
			}
			else
			{
				result = first + second + "\\" + third;
			}
			return result;
		}

		// Token: 0x06008392 RID: 33682 RVA: 0x0013A7C4 File Offset: 0x001389C4
		private unsafe static string JoinInternal(ReadOnlySpan<char> first, ReadOnlySpan<char> second, ReadOnlySpan<char> third, ReadOnlySpan<char> fourth)
		{
			Path.JoinInternalState joinInternalState = new Path.JoinInternalState
			{
				ReadOnlySpanPtr1 = &first,
				ReadOnlySpanPtr2 = &second,
				ReadOnlySpanPtr3 = &third,
				ReadOnlySpanPtr4 = &fourth,
				NeedSeparator1 = ((PathInternal.IsDirectorySeparator((char)(*first[first.Length - 1])) || PathInternal.IsDirectorySeparator((char)(*second[0]))) ? 0 : 1),
				NeedSeparator2 = ((PathInternal.IsDirectorySeparator((char)(*second[second.Length - 1])) || PathInternal.IsDirectorySeparator((char)(*third[0]))) ? 0 : 1),
				NeedSeparator3 = ((PathInternal.IsDirectorySeparator((char)(*third[third.Length - 1])) || PathInternal.IsDirectorySeparator((char)(*fourth[0]))) ? 0 : 1)
			};
			return string.Create<Path.JoinInternalState>(first.Length + second.Length + third.Length + fourth.Length + (int)joinInternalState.NeedSeparator1 + (int)joinInternalState.NeedSeparator2 + (int)joinInternalState.NeedSeparator3, joinInternalState, delegate(Span<char> destination, Path.JoinInternalState state)
			{
				ReadOnlySpan<char> readOnlySpan = *state.ReadOnlySpanPtr1;
				readOnlySpan.CopyTo(destination);
				destination = destination.Slice(readOnlySpan.Length);
				if (state.NeedSeparator1 != 0)
				{
					*destination[0] = '\\';
					destination = destination.Slice(1);
				}
				ReadOnlySpan<char> readOnlySpan2 = *state.ReadOnlySpanPtr2;
				readOnlySpan2.CopyTo(destination);
				destination = destination.Slice(readOnlySpan2.Length);
				if (state.NeedSeparator2 != 0)
				{
					*destination[0] = '\\';
					destination = destination.Slice(1);
				}
				ReadOnlySpan<char> readOnlySpan3 = *state.ReadOnlySpanPtr3;
				readOnlySpan3.CopyTo(destination);
				destination = destination.Slice(readOnlySpan3.Length);
				if (state.NeedSeparator3 != 0)
				{
					*destination[0] = '\\';
					destination = destination.Slice(1);
				}
				ReadOnlySpan<char> readOnlySpan4 = *state.ReadOnlySpanPtr4;
				readOnlySpan4.CopyTo(destination);
			});
		}

		// Token: 0x17001196 RID: 4502
		// (get) Token: 0x06008393 RID: 33683 RVA: 0x0013A8F2 File Offset: 0x00138AF2
		[Nullable(0)]
		private unsafe static ReadOnlySpan<byte> Base32Char
		{
			get
			{
				return new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.E19EC872C44A1E106B1945D46593E89BE1896CAB43757023BAAD2D1D69DAC8AD), 32);
			}
		}

		// Token: 0x06008394 RID: 33684 RVA: 0x0013A900 File Offset: 0x00138B00
		internal unsafe static void Populate83FileNameFromRandomBytes(byte* bytes, int byteCount, Span<char> chars)
		{
			byte b = *bytes;
			byte b2 = bytes[1];
			byte b3 = bytes[2];
			byte b4 = bytes[3];
			byte b5 = bytes[4];
			*chars[11] = (char)(*Path.Base32Char[(int)(bytes[7] & 31)]);
			*chars[0] = (char)(*Path.Base32Char[(int)(b & 31)]);
			*chars[1] = (char)(*Path.Base32Char[(int)(b2 & 31)]);
			*chars[2] = (char)(*Path.Base32Char[(int)(b3 & 31)]);
			*chars[3] = (char)(*Path.Base32Char[(int)(b4 & 31)]);
			*chars[4] = (char)(*Path.Base32Char[(int)(b5 & 31)]);
			*chars[5] = (char)(*Path.Base32Char[(b & 224) >> 5 | (b4 & 96) >> 2]);
			*chars[6] = (char)(*Path.Base32Char[(b2 & 224) >> 5 | (b5 & 96) >> 2]);
			b3 = (byte)(b3 >> 5);
			if ((b4 & 128) != 0)
			{
				b3 |= 8;
			}
			if ((b5 & 128) != 0)
			{
				b3 |= 16;
			}
			*chars[7] = (char)(*Path.Base32Char[(int)b3]);
			*chars[8] = '.';
			*chars[9] = (char)(*Path.Base32Char[(int)(bytes[5] & 31)]);
			*chars[10] = (char)(*Path.Base32Char[(int)(bytes[6] & 31)]);
		}

		// Token: 0x06008395 RID: 33685 RVA: 0x0013AAAA File Offset: 0x00138CAA
		public static string GetRelativePath(string relativeTo, string path)
		{
			return Path.GetRelativePath(relativeTo, path, StringComparison.OrdinalIgnoreCase);
		}

		// Token: 0x06008396 RID: 33686 RVA: 0x0013AAB4 File Offset: 0x00138CB4
		private unsafe static string GetRelativePath(string relativeTo, string path, StringComparison comparisonType)
		{
			ArgumentNullException.ThrowIfNull(relativeTo, "relativeTo");
			ArgumentNullException.ThrowIfNull(path, "path");
			if (PathInternal.IsEffectivelyEmpty(relativeTo.AsSpan()))
			{
				throw new ArgumentException(SR.Arg_PathEmpty, "relativeTo");
			}
			if (PathInternal.IsEffectivelyEmpty(path.AsSpan()))
			{
				throw new ArgumentException(SR.Arg_PathEmpty, "path");
			}
			relativeTo = Path.GetFullPath(relativeTo);
			path = Path.GetFullPath(path);
			if (!PathInternal.AreRootsEqual(relativeTo, path, comparisonType))
			{
				return path;
			}
			int num = PathInternal.GetCommonPathLength(relativeTo, path, comparisonType == StringComparison.OrdinalIgnoreCase);
			if (num == 0)
			{
				return path;
			}
			int num2 = relativeTo.Length;
			if (Path.EndsInDirectorySeparator(relativeTo.AsSpan()))
			{
				num2--;
			}
			bool flag = Path.EndsInDirectorySeparator(path.AsSpan());
			int num3 = path.Length;
			if (flag)
			{
				num3--;
			}
			if (num2 == num3 && num >= num2)
			{
				return ".";
			}
			Span<char> initialBuffer = new Span<char>(stackalloc byte[(UIntPtr)520], 260);
			ValueStringBuilder valueStringBuilder = new ValueStringBuilder(initialBuffer);
			valueStringBuilder.EnsureCapacity(Math.Max(relativeTo.Length, path.Length));
			if (num < num2)
			{
				valueStringBuilder.Append("..");
				for (int i = num + 1; i < num2; i++)
				{
					if (PathInternal.IsDirectorySeparator(relativeTo[i]))
					{
						valueStringBuilder.Append(Path.DirectorySeparatorChar);
						valueStringBuilder.Append("..");
					}
				}
			}
			else if (PathInternal.IsDirectorySeparator(path[num]))
			{
				num++;
			}
			int num4 = num3 - num;
			if (flag)
			{
				num4++;
			}
			if (num4 > 0)
			{
				if (valueStringBuilder.Length > 0)
				{
					valueStringBuilder.Append(Path.DirectorySeparatorChar);
				}
				valueStringBuilder.Append(path.AsSpan(num, num4));
			}
			return valueStringBuilder.ToString();
		}

		// Token: 0x06008397 RID: 33687 RVA: 0x0013AC56 File Offset: 0x00138E56
		public static string TrimEndingDirectorySeparator(string path)
		{
			return PathInternal.TrimEndingDirectorySeparator(path);
		}

		// Token: 0x06008398 RID: 33688 RVA: 0x0013AC5E File Offset: 0x00138E5E
		[NullableContext(0)]
		public static ReadOnlySpan<char> TrimEndingDirectorySeparator(ReadOnlySpan<char> path)
		{
			return PathInternal.TrimEndingDirectorySeparator(path);
		}

		// Token: 0x06008399 RID: 33689 RVA: 0x0013AC66 File Offset: 0x00138E66
		[NullableContext(0)]
		public static bool EndsInDirectorySeparator(ReadOnlySpan<char> path)
		{
			return PathInternal.EndsInDirectorySeparator(path);
		}

		// Token: 0x0600839A RID: 33690 RVA: 0x0013AC6E File Offset: 0x00138E6E
		[NullableContext(2)]
		public static bool EndsInDirectorySeparator([NotNullWhen(true)] string path)
		{
			return PathInternal.EndsInDirectorySeparator(path);
		}

		// Token: 0x0600839B RID: 33691 RVA: 0x0013AC76 File Offset: 0x00138E76
		public static char[] GetInvalidFileNameChars()
		{
			return new char[]
			{
				'"',
				'<',
				'>',
				'|',
				'\0',
				'\u0001',
				'\u0002',
				'\u0003',
				'\u0004',
				'\u0005',
				'\u0006',
				'\a',
				'\b',
				'\t',
				'\n',
				'\v',
				'\f',
				'\r',
				'\u000e',
				'\u000f',
				'\u0010',
				'\u0011',
				'\u0012',
				'\u0013',
				'\u0014',
				'\u0015',
				'\u0016',
				'\u0017',
				'\u0018',
				'\u0019',
				'\u001a',
				'\u001b',
				'\u001c',
				'\u001d',
				'\u001e',
				'\u001f',
				':',
				'*',
				'?',
				'\\',
				'/'
			};
		}

		// Token: 0x0600839C RID: 33692 RVA: 0x0013AC8A File Offset: 0x00138E8A
		public static char[] GetInvalidPathChars()
		{
			return new char[]
			{
				'|',
				'\0',
				'\u0001',
				'\u0002',
				'\u0003',
				'\u0004',
				'\u0005',
				'\u0006',
				'\a',
				'\b',
				'\t',
				'\n',
				'\v',
				'\f',
				'\r',
				'\u000e',
				'\u000f',
				'\u0010',
				'\u0011',
				'\u0012',
				'\u0013',
				'\u0014',
				'\u0015',
				'\u0016',
				'\u0017',
				'\u0018',
				'\u0019',
				'\u001a',
				'\u001b',
				'\u001c',
				'\u001d',
				'\u001e',
				'\u001f'
			};
		}

		// Token: 0x0600839D RID: 33693 RVA: 0x0013ACA0 File Offset: 0x00138EA0
		private static bool ExistsCore(string fullPath, out bool isDirectory)
		{
			Interop.Kernel32.WIN32_FILE_ATTRIBUTE_DATA win32_FILE_ATTRIBUTE_DATA = default(Interop.Kernel32.WIN32_FILE_ATTRIBUTE_DATA);
			bool flag = FileSystem.FillAttributeInfo(fullPath, ref win32_FILE_ATTRIBUTE_DATA, true) == 0 && win32_FILE_ATTRIBUTE_DATA.dwFileAttributes != -1;
			isDirectory = (flag && (win32_FILE_ATTRIBUTE_DATA.dwFileAttributes & 16) != 0);
			return flag;
		}

		// Token: 0x0600839E RID: 33694 RVA: 0x0013ACE8 File Offset: 0x00138EE8
		public static string GetFullPath(string path)
		{
			ArgumentNullException.ThrowIfNull(path, "path");
			if (PathInternal.IsEffectivelyEmpty(path.AsSpan()))
			{
				throw new ArgumentException(SR.Arg_PathEmpty, "path");
			}
			if (path.Contains('\0'))
			{
				throw new ArgumentException(SR.Argument_NullCharInPath, "path");
			}
			return Path.GetFullPathInternal(path);
		}

		// Token: 0x0600839F RID: 33695 RVA: 0x0013AD3C File Offset: 0x00138F3C
		public static string GetFullPath(string path, string basePath)
		{
			ArgumentNullException.ThrowIfNull(path, "path");
			ArgumentNullException.ThrowIfNull(basePath, "basePath");
			if (!Path.IsPathFullyQualified(basePath))
			{
				throw new ArgumentException(SR.Arg_BasePathNotFullyQualified, "basePath");
			}
			if (basePath.Contains('\0') || path.Contains('\0'))
			{
				throw new ArgumentException(SR.Argument_NullCharInPath);
			}
			if (Path.IsPathFullyQualified(path))
			{
				return Path.GetFullPathInternal(path);
			}
			if (PathInternal.IsEffectivelyEmpty(path.AsSpan()))
			{
				return basePath;
			}
			int length = path.Length;
			string text;
			if (length >= 1 && PathInternal.IsDirectorySeparator(path[0]))
			{
				text = Path.Join(Path.GetPathRoot(basePath.AsSpan()), path.AsSpan(1));
			}
			else if (length >= 2 && PathInternal.IsValidDriveChar(path[0]) && path[1] == ':')
			{
				if (Path.GetVolumeName(path.AsSpan()).EqualsOrdinalIgnoreCase(Path.GetVolumeName(basePath.AsSpan())))
				{
					text = Path.Join(basePath.AsSpan(), path.AsSpan(2));
				}
				else
				{
					text = ((!PathInternal.IsDevice(basePath.AsSpan())) ? path.Insert(2, "\\") : ((length == 2) ? Path.JoinInternal(basePath.AsSpan(0, 4), path.AsSpan(), "\\".AsSpan()) : Path.JoinInternal(basePath.AsSpan(0, 4), path.AsSpan(0, 2), "\\".AsSpan(), path.AsSpan(2))));
				}
			}
			else
			{
				text = Path.JoinInternal(basePath.AsSpan(), path.AsSpan());
			}
			if (!PathInternal.IsDevice(text.AsSpan()))
			{
				return Path.GetFullPathInternal(text);
			}
			return PathInternal.RemoveRelativeSegments(text, PathInternal.GetRootLength(text.AsSpan()));
		}

		// Token: 0x060083A0 RID: 33696 RVA: 0x0013AEDE File Offset: 0x001390DE
		private static string GetFullPathInternal(string path)
		{
			if (PathInternal.IsExtended(path.AsSpan()))
			{
				return path;
			}
			return PathHelper.Normalize(path);
		}

		// Token: 0x060083A1 RID: 33697 RVA: 0x0013AEF8 File Offset: 0x001390F8
		public unsafe static string GetTempPath()
		{
			Span<char> initialBuffer = new Span<char>(stackalloc byte[(UIntPtr)520], 260);
			ValueStringBuilder valueStringBuilder = new ValueStringBuilder(initialBuffer);
			Path.GetTempPath(ref valueStringBuilder);
			string result = PathHelper.Normalize(ref valueStringBuilder);
			valueStringBuilder.Dispose();
			return result;
		}

		// Token: 0x060083A2 RID: 33698 RVA: 0x0013AF38 File Offset: 0x00139138
		private static method GetGetTempPathWFunc()
		{
			IntPtr handle = Interop.Kernel32.LoadLibraryEx("kernel32.dll", (IntPtr)0, 2048);
			IntPtr export;
			if (!NativeLibrary.TryGetExport(handle, "GetTempPath2W", out export))
			{
				export = NativeLibrary.GetExport(handle, "GetTempPathW");
			}
			return export;
		}

		// Token: 0x060083A3 RID: 33699 RVA: 0x0013AF74 File Offset: 0x00139174
		internal static void GetTempPath(ref ValueStringBuilder builder)
		{
			uint num;
			while ((ulong)(num = Path.<GetTempPath>g__GetTempPathW|62_0(builder.Capacity, builder.GetPinnableReference())) > (ulong)((long)builder.Capacity))
			{
				builder.EnsureCapacity(checked((int)num));
			}
			if (num == 0U)
			{
				throw Win32Marshal.GetExceptionForLastWin32Error("");
			}
			builder.Length = (int)num;
		}

		// Token: 0x060083A4 RID: 33700 RVA: 0x0013AFC0 File Offset: 0x001391C0
		public unsafe static string GetTempFileName()
		{
			byte* ptr = stackalloc byte[(UIntPtr)4];
			Span<char> span = new Span<char>(stackalloc byte[(UIntPtr)26], 13);
			*span[0] = (*span[10] = 't');
			*span[1] = (*span[11] = 'm');
			*span[2] = (*span[12] = 'p');
			*span[9] = '.';
			int num = 0;
			string text;
			for (;;)
			{
				Interop.GetRandomBytes(ptr, 4);
				byte b = *ptr;
				byte b2 = ptr[1];
				byte b3 = ptr[2];
				byte b4 = ptr[3];
				*span[3] = (char)(*Path.Base32Char[(int)(b & 31)]);
				*span[4] = (char)(*Path.Base32Char[(int)(b2 & 31)]);
				*span[5] = (char)(*Path.Base32Char[(int)(b3 & 31)]);
				*span[6] = (char)(*Path.Base32Char[(int)(b4 & 31)]);
				*span[7] = (char)(*Path.Base32Char[(b & 224) >> 5 | (b2 & 192) >> 3]);
				*span[8] = (char)(*Path.Base32Char[(b3 & 224) >> 5 | (b4 & 192) >> 3]);
				text = Path.GetTempPath() + span;
				try
				{
					File.OpenHandle(text, FileMode.CreateNew, FileAccess.Write, FileShare.Read, FileOptions.None, 0L).Dispose();
				}
				catch (IOException ex) when (num < 100 && Win32Marshal.TryMakeWin32ErrorCodeFromHR(ex.HResult) == 80)
				{
					num++;
					continue;
				}
				break;
			}
			return text;
		}

		// Token: 0x060083A5 RID: 33701 RVA: 0x0013B194 File Offset: 0x00139394
		[NullableContext(2)]
		public static bool IsPathRooted([NotNullWhen(true)] string path)
		{
			return path != null && Path.IsPathRooted(path.AsSpan());
		}

		// Token: 0x060083A6 RID: 33702 RVA: 0x0013B1A8 File Offset: 0x001393A8
		[NullableContext(0)]
		public unsafe static bool IsPathRooted(ReadOnlySpan<char> path)
		{
			int length = path.Length;
			return (length >= 1 && PathInternal.IsDirectorySeparator((char)(*path[0]))) || (length >= 2 && PathInternal.IsValidDriveChar((char)(*path[0])) && *path[1] == 58);
		}

		// Token: 0x060083A7 RID: 33703 RVA: 0x0013B1F8 File Offset: 0x001393F8
		[NullableContext(2)]
		public static string GetPathRoot(string path)
		{
			if (PathInternal.IsEffectivelyEmpty(path.AsSpan()))
			{
				return null;
			}
			ReadOnlySpan<char> pathRoot = Path.GetPathRoot(path.AsSpan());
			if (path.Length == pathRoot.Length)
			{
				return PathInternal.NormalizeDirectorySeparators(path);
			}
			return PathInternal.NormalizeDirectorySeparators(pathRoot.ToString());
		}

		// Token: 0x060083A8 RID: 33704 RVA: 0x0013B248 File Offset: 0x00139448
		[NullableContext(0)]
		public static ReadOnlySpan<char> GetPathRoot(ReadOnlySpan<char> path)
		{
			if (PathInternal.IsEffectivelyEmpty(path))
			{
				return ReadOnlySpan<char>.Empty;
			}
			int rootLength = PathInternal.GetRootLength(path);
			if (rootLength > 0)
			{
				return path.Slice(0, rootLength);
			}
			return ReadOnlySpan<char>.Empty;
		}

		// Token: 0x060083A9 RID: 33705 RVA: 0x0013B280 File Offset: 0x00139480
		internal static ReadOnlySpan<char> GetVolumeName(ReadOnlySpan<char> path)
		{
			ReadOnlySpan<char> pathRoot = Path.GetPathRoot(path);
			if (pathRoot.Length == 0)
			{
				return pathRoot;
			}
			int num = Path.GetUncRootLength(path);
			if (num == -1)
			{
				if (PathInternal.IsDevice(path))
				{
					num = 4;
				}
				else
				{
					num = 0;
				}
			}
			ReadOnlySpan<char> readOnlySpan = pathRoot.Slice(num);
			if (!Path.EndsInDirectorySeparator(readOnlySpan))
			{
				return readOnlySpan;
			}
			return readOnlySpan.Slice(0, readOnlySpan.Length - 1);
		}

		// Token: 0x060083AA RID: 33706 RVA: 0x0013B2DC File Offset: 0x001394DC
		internal static int GetUncRootLength(ReadOnlySpan<char> path)
		{
			bool flag = PathInternal.IsDevice(path);
			if (!flag && path.Slice(0, 2).EqualsOrdinal("\\\\".AsSpan()))
			{
				return 2;
			}
			if (flag && path.Length >= 8 && (path.Slice(0, 8).EqualsOrdinalIgnoreCase("\\\\?\\UNC\\".AsSpan()) || path.Slice(5, 4).EqualsOrdinalIgnoreCase("UNC\\".AsSpan())))
			{
				return 8;
			}
			return -1;
		}

		// Token: 0x060083AC RID: 33708 RVA: 0x0013B37C File Offset: 0x0013957C
		[CompilerGenerated]
		internal unsafe static uint <GetTempPath>g__GetTempPathW|62_0(int bufferLen, ref char buffer)
		{
			method <<<NULL>>> = Path.s_GetTempPathWFunc;
			if (<<<NULL>>> == (UIntPtr)0)
			{
				<<<NULL>>> = (Path.s_GetTempPathWFunc = Path.GetGetTempPathWFunc());
			}
			bool flag = &buffer != null;
			Marshal.SetLastSystemError(0);
			int num = <<<NULL>>>;
			bufferLen;
			flag;
			uint result = (uint)num;
			calli();
			int lastSystemError = Marshal.GetLastSystemError();
			uint num2 = (uint)((UIntPtr)0);
			Marshal.SetLastPInvokeError(lastSystemError);
			return result;
		}

		// Token: 0x04001BD3 RID: 7123
		public static readonly char DirectorySeparatorChar = '\\';

		// Token: 0x04001BD4 RID: 7124
		public static readonly char AltDirectorySeparatorChar = '/';

		// Token: 0x04001BD5 RID: 7125
		public static readonly char VolumeSeparatorChar = ':';

		// Token: 0x04001BD6 RID: 7126
		public static readonly char PathSeparator = ';';

		// Token: 0x04001BD7 RID: 7127
		[Obsolete("Path.InvalidPathChars has been deprecated. Use GetInvalidPathChars or GetInvalidFileNameChars instead.")]
		public static readonly char[] InvalidPathChars = Path.GetInvalidPathChars();

		// Token: 0x04001BD8 RID: 7128
		private static volatile method s_GetTempPathWFunc;

		// Token: 0x02000806 RID: 2054
		private struct JoinInternalState
		{
			// Token: 0x04001BD9 RID: 7129
			public IntPtr ReadOnlySpanPtr1;

			// Token: 0x04001BDA RID: 7130
			public IntPtr ReadOnlySpanPtr2;

			// Token: 0x04001BDB RID: 7131
			public IntPtr ReadOnlySpanPtr3;

			// Token: 0x04001BDC RID: 7132
			public IntPtr ReadOnlySpanPtr4;

			// Token: 0x04001BDD RID: 7133
			public byte NeedSeparator1;

			// Token: 0x04001BDE RID: 7134
			public byte NeedSeparator2;

			// Token: 0x04001BDF RID: 7135
			public byte NeedSeparator3;
		}
	}
}

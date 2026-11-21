using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text;

namespace System.IO
{
	// Token: 0x0200084F RID: 2127
	internal static class PathInternal
	{
		// Token: 0x0600876B RID: 34667 RVA: 0x00147353 File Offset: 0x00145553
		internal unsafe static bool StartsWithDirectorySeparator(ReadOnlySpan<char> path)
		{
			return path.Length > 0 && PathInternal.IsDirectorySeparator((char)(*path[0]));
		}

		// Token: 0x0600876C RID: 34668 RVA: 0x0014736F File Offset: 0x0014556F
		internal static string EnsureTrailingSeparator(string path)
		{
			if (!PathInternal.EndsInDirectorySeparator(path.AsSpan()))
			{
				return path + "\\";
			}
			return path;
		}

		// Token: 0x0600876D RID: 34669 RVA: 0x0014738B File Offset: 0x0014558B
		internal static bool IsRoot(ReadOnlySpan<char> path)
		{
			return path.Length == PathInternal.GetRootLength(path);
		}

		// Token: 0x0600876E RID: 34670 RVA: 0x0014739C File Offset: 0x0014559C
		internal static int GetCommonPathLength(string first, string second, bool ignoreCase)
		{
			int num = PathInternal.EqualStartingCharacterCount(first, second, ignoreCase);
			if (num == 0)
			{
				return num;
			}
			if (num == first.Length && (num == second.Length || PathInternal.IsDirectorySeparator(second[num])))
			{
				return num;
			}
			if (num == second.Length && PathInternal.IsDirectorySeparator(first[num]))
			{
				return num;
			}
			while (num > 0 && !PathInternal.IsDirectorySeparator(first[num - 1]))
			{
				num--;
			}
			return num;
		}

		// Token: 0x0600876F RID: 34671 RVA: 0x0014740C File Offset: 0x0014560C
		internal unsafe static int EqualStartingCharacterCount(string first, string second, bool ignoreCase)
		{
			if (string.IsNullOrEmpty(first) || string.IsNullOrEmpty(second))
			{
				return 0;
			}
			int num = 0;
			char* ptr;
			if (first == null)
			{
				ptr = null;
			}
			else
			{
				fixed (char* ptr2 = first.GetPinnableReference())
				{
					ptr = ptr2;
				}
			}
			char* ptr3;
			if (second == null)
			{
				ptr3 = null;
			}
			else
			{
				fixed (char* ptr4 = second.GetPinnableReference())
				{
					ptr3 = ptr4;
				}
			}
			char* ptr5 = ptr3;
			char* ptr6 = ptr;
			char* ptr7 = ptr5;
			char* ptr8 = ptr6 + first.Length;
			char* ptr9 = ptr7 + second.Length;
			while (ptr6 != ptr8 && ptr7 != ptr9 && (*ptr6 == *ptr7 || (ignoreCase && char.ToUpperInvariant(*ptr6) == char.ToUpperInvariant(*ptr7))))
			{
				num++;
				ptr6++;
				ptr7++;
			}
			char* ptr4 = null;
			char* ptr2 = null;
			return num;
		}

		// Token: 0x06008770 RID: 34672 RVA: 0x001474B4 File Offset: 0x001456B4
		internal static bool AreRootsEqual(string first, string second, StringComparison comparisonType)
		{
			int rootLength = PathInternal.GetRootLength(first.AsSpan());
			int rootLength2 = PathInternal.GetRootLength(second.AsSpan());
			return rootLength == rootLength2 && string.Compare(first, 0, second, 0, rootLength, comparisonType) == 0;
		}

		// Token: 0x06008771 RID: 34673 RVA: 0x001474F0 File Offset: 0x001456F0
		internal unsafe static string RemoveRelativeSegments(string path, int rootLength)
		{
			Span<char> initialBuffer = new Span<char>(stackalloc byte[(UIntPtr)520], 260);
			ValueStringBuilder valueStringBuilder = new ValueStringBuilder(initialBuffer);
			if (PathInternal.RemoveRelativeSegments(path.AsSpan(), rootLength, ref valueStringBuilder))
			{
				path = valueStringBuilder.ToString();
			}
			valueStringBuilder.Dispose();
			return path;
		}

		// Token: 0x06008772 RID: 34674 RVA: 0x00147540 File Offset: 0x00145740
		internal unsafe static bool RemoveRelativeSegments(ReadOnlySpan<char> path, int rootLength, ref ValueStringBuilder sb)
		{
			bool flag = false;
			int num = rootLength;
			if (PathInternal.IsDirectorySeparator((char)(*path[num - 1])))
			{
				num--;
			}
			if (num > 0)
			{
				sb.Append(path.Slice(0, num));
			}
			int i = num;
			while (i < path.Length)
			{
				char c = (char)(*path[i]);
				if (!PathInternal.IsDirectorySeparator(c) || i + 1 >= path.Length)
				{
					goto IL_148;
				}
				if (!PathInternal.IsDirectorySeparator((char)(*path[i + 1])))
				{
					if ((i + 2 == path.Length || PathInternal.IsDirectorySeparator((char)(*path[i + 2]))) && *path[i + 1] == 46)
					{
						i++;
					}
					else
					{
						if (i + 2 >= path.Length || (i + 3 != path.Length && !PathInternal.IsDirectorySeparator((char)(*path[i + 3]))) || *path[i + 1] != 46 || *path[i + 2] != 46)
						{
							goto IL_148;
						}
						int j;
						for (j = sb.Length - 1; j >= num; j--)
						{
							if (PathInternal.IsDirectorySeparator(*sb[j]))
							{
								sb.Length = ((i + 3 >= path.Length && j == num) ? (j + 1) : j);
								break;
							}
						}
						if (j < num)
						{
							sb.Length = num;
						}
						i += 2;
					}
				}
				IL_15E:
				i++;
				continue;
				IL_148:
				if (c != '\\' && c == '/')
				{
					c = '\\';
					flag = true;
				}
				sb.Append(c);
				goto IL_15E;
			}
			if (!flag && sb.Length == path.Length)
			{
				return false;
			}
			if (num != rootLength && sb.Length < rootLength)
			{
				sb.Append((char)(*path[rootLength - 1]));
			}
			return true;
		}

		// Token: 0x06008773 RID: 34675 RVA: 0x001476EF File Offset: 0x001458EF
		[return: NotNullIfNotNull("path")]
		internal static string TrimEndingDirectorySeparator(string path)
		{
			if (!PathInternal.EndsInDirectorySeparator(path) || PathInternal.IsRoot(path.AsSpan()))
			{
				return path;
			}
			return path.Substring(0, path.Length - 1);
		}

		// Token: 0x06008774 RID: 34676 RVA: 0x00147717 File Offset: 0x00145917
		internal static bool EndsInDirectorySeparator([NotNullWhen(true)] string path)
		{
			return !string.IsNullOrEmpty(path) && PathInternal.IsDirectorySeparator(path[path.Length - 1]);
		}

		// Token: 0x06008775 RID: 34677 RVA: 0x00147736 File Offset: 0x00145936
		internal static ReadOnlySpan<char> TrimEndingDirectorySeparator(ReadOnlySpan<char> path)
		{
			if (!PathInternal.EndsInDirectorySeparator(path) || PathInternal.IsRoot(path))
			{
				return path;
			}
			return path.Slice(0, path.Length - 1);
		}

		// Token: 0x06008776 RID: 34678 RVA: 0x0014775B File Offset: 0x0014595B
		internal unsafe static bool EndsInDirectorySeparator(ReadOnlySpan<char> path)
		{
			return path.Length > 0 && PathInternal.IsDirectorySeparator((char)(*path[path.Length - 1]));
		}

		// Token: 0x06008777 RID: 34679 RVA: 0x00020FCE File Offset: 0x0001F1CE
		internal static bool IsValidDriveChar(char value)
		{
			return (value | ' ') - 'a' <= '\u0019';
		}

		// Token: 0x06008778 RID: 34680 RVA: 0x00147780 File Offset: 0x00145980
		internal static bool EndsWithPeriodOrSpace(string path)
		{
			if (string.IsNullOrEmpty(path))
			{
				return false;
			}
			char c = path[path.Length - 1];
			return c == ' ' || c == '.';
		}

		// Token: 0x06008779 RID: 34681 RVA: 0x001477B2 File Offset: 0x001459B2
		[return: NotNullIfNotNull("path")]
		internal static string EnsureExtendedPrefixIfNeeded(string path)
		{
			if (path != null && (path.Length >= 260 || PathInternal.EndsWithPeriodOrSpace(path)))
			{
				return PathInternal.EnsureExtendedPrefix(path);
			}
			return path;
		}

		// Token: 0x0600877A RID: 34682 RVA: 0x001477D4 File Offset: 0x001459D4
		internal static string EnsureExtendedPrefix(string path)
		{
			if (PathInternal.IsPartiallyQualified(path.AsSpan()) || PathInternal.IsDevice(path.AsSpan()))
			{
				return path;
			}
			if (path.StartsWith("\\\\", StringComparison.OrdinalIgnoreCase))
			{
				return path.Insert(2, "?\\UNC\\");
			}
			return "\\\\?\\" + path;
		}

		// Token: 0x0600877B RID: 34683 RVA: 0x00147824 File Offset: 0x00145A24
		internal unsafe static bool IsDevice(ReadOnlySpan<char> path)
		{
			return PathInternal.IsExtended(path) || (path.Length >= 4 && PathInternal.IsDirectorySeparator((char)(*path[0])) && PathInternal.IsDirectorySeparator((char)(*path[1])) && (*path[2] == 46 || *path[2] == 63) && PathInternal.IsDirectorySeparator((char)(*path[3])));
		}

		// Token: 0x0600877C RID: 34684 RVA: 0x00147890 File Offset: 0x00145A90
		internal unsafe static bool IsDeviceUNC(ReadOnlySpan<char> path)
		{
			return path.Length >= 8 && PathInternal.IsDevice(path) && PathInternal.IsDirectorySeparator((char)(*path[7])) && *path[4] == 85 && *path[5] == 78 && *path[6] == 67;
		}

		// Token: 0x0600877D RID: 34685 RVA: 0x001478E8 File Offset: 0x00145AE8
		internal unsafe static bool IsExtended(ReadOnlySpan<char> path)
		{
			return path.Length >= 4 && *path[0] == 92 && (*path[1] == 92 || *path[1] == 63) && *path[2] == 63 && *path[3] == 92;
		}

		// Token: 0x0600877E RID: 34686 RVA: 0x00147944 File Offset: 0x00145B44
		internal unsafe static int GetRootLength(ReadOnlySpan<char> path)
		{
			int length = path.Length;
			int i = 0;
			bool flag = PathInternal.IsDevice(path);
			bool flag2 = flag && PathInternal.IsDeviceUNC(path);
			if ((!flag || flag2) && length > 0 && PathInternal.IsDirectorySeparator((char)(*path[0])))
			{
				if (flag2 || (length > 1 && PathInternal.IsDirectorySeparator((char)(*path[1]))))
				{
					i = (flag2 ? 8 : 2);
					int num = 2;
					while (i < length)
					{
						if (PathInternal.IsDirectorySeparator((char)(*path[i])) && --num <= 0)
						{
							break;
						}
						i++;
					}
				}
				else
				{
					i = 1;
				}
			}
			else if (flag)
			{
				i = 4;
				while (i < length && !PathInternal.IsDirectorySeparator((char)(*path[i])))
				{
					i++;
				}
				if (i < length && i > 4 && PathInternal.IsDirectorySeparator((char)(*path[i])))
				{
					i++;
				}
			}
			else if (length >= 2 && *path[1] == 58 && PathInternal.IsValidDriveChar((char)(*path[0])))
			{
				i = 2;
				if (length > 2 && PathInternal.IsDirectorySeparator((char)(*path[2])))
				{
					i++;
				}
			}
			return i;
		}

		// Token: 0x0600877F RID: 34687 RVA: 0x00147A54 File Offset: 0x00145C54
		internal unsafe static bool IsPartiallyQualified(ReadOnlySpan<char> path)
		{
			if (path.Length < 2)
			{
				return true;
			}
			if (PathInternal.IsDirectorySeparator((char)(*path[0])))
			{
				return *path[1] != 63 && !PathInternal.IsDirectorySeparator((char)(*path[1]));
			}
			return path.Length < 3 || *path[1] != 58 || !PathInternal.IsDirectorySeparator((char)(*path[2])) || !PathInternal.IsValidDriveChar((char)(*path[0]));
		}

		// Token: 0x06008780 RID: 34688 RVA: 0x00147AD8 File Offset: 0x00145CD8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static bool IsDirectorySeparator(char c)
		{
			return c == '\\' || c == '/';
		}

		// Token: 0x06008781 RID: 34689 RVA: 0x00147AE8 File Offset: 0x00145CE8
		[return: NotNullIfNotNull("path")]
		internal unsafe static string NormalizeDirectorySeparators(string path)
		{
			if (string.IsNullOrEmpty(path))
			{
				return path;
			}
			bool flag = true;
			for (int i = 0; i < path.Length; i++)
			{
				char c = path[i];
				if (PathInternal.IsDirectorySeparator(c) && (c != '\\' || (i > 0 && i + 1 < path.Length && PathInternal.IsDirectorySeparator(path[i + 1]))))
				{
					flag = false;
					break;
				}
			}
			if (flag)
			{
				return path;
			}
			Span<char> initialBuffer = new Span<char>(stackalloc byte[(UIntPtr)520], 260);
			ValueStringBuilder valueStringBuilder = new ValueStringBuilder(initialBuffer);
			int num = 0;
			if (PathInternal.IsDirectorySeparator(path[num]))
			{
				num++;
				valueStringBuilder.Append('\\');
			}
			int j = num;
			while (j < path.Length)
			{
				char c = path[j];
				if (!PathInternal.IsDirectorySeparator(c))
				{
					goto IL_D2;
				}
				if (j + 1 >= path.Length || !PathInternal.IsDirectorySeparator(path[j + 1]))
				{
					c = '\\';
					goto IL_D2;
				}
				IL_DA:
				j++;
				continue;
				IL_D2:
				valueStringBuilder.Append(c);
				goto IL_DA;
			}
			return valueStringBuilder.ToString();
		}

		// Token: 0x06008782 RID: 34690 RVA: 0x00147BEC File Offset: 0x00145DEC
		internal unsafe static bool IsEffectivelyEmpty(ReadOnlySpan<char> path)
		{
			if (path.IsEmpty)
			{
				return true;
			}
			ReadOnlySpan<char> readOnlySpan = path;
			for (int i = 0; i < readOnlySpan.Length; i++)
			{
				if (*readOnlySpan[i] != 32)
				{
					return false;
				}
			}
			return true;
		}
	}
}

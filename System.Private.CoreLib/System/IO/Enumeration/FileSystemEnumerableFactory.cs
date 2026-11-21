using System;
using System.Collections.Generic;

namespace System.IO.Enumeration
{
	// Token: 0x0200086D RID: 2157
	internal static class FileSystemEnumerableFactory
	{
		// Token: 0x06008898 RID: 34968 RVA: 0x0014BFEC File Offset: 0x0014A1EC
		internal static bool NormalizeInputs(ref string directory, ref string expression, MatchType matchType)
		{
			if (Path.IsPathRooted(expression))
			{
				throw new ArgumentException(SR.Arg_Path2IsRooted, "expression");
			}
			if (expression.Contains('\0'))
			{
				throw new ArgumentException(SR.Argument_NullCharInPath, expression);
			}
			if (directory.Contains('\0'))
			{
				throw new ArgumentException(SR.Argument_NullCharInPath, directory);
			}
			ReadOnlySpan<char> directoryName = Path.GetDirectoryName(expression.AsSpan());
			bool result = true;
			if (directoryName.Length != 0)
			{
				directory = Path.Join(directory.AsSpan(), directoryName);
				expression = expression.Substring(directoryName.Length + 1);
				result = false;
			}
			if (matchType != MatchType.Simple)
			{
				if (matchType != MatchType.Win32)
				{
					throw new ArgumentOutOfRangeException("matchType");
				}
				if (!(expression == "*"))
				{
					if (string.IsNullOrEmpty(expression) || expression == "." || expression == "*.*")
					{
						expression = "*";
					}
					else
					{
						if (Path.DirectorySeparatorChar != '\\' && expression.AsSpan().ContainsAny("\\\"<>"))
						{
							expression = expression.Replace("\\", "\\\\");
							expression = expression.Replace("\"", "\\\"");
							expression = expression.Replace(">", "\\>");
							expression = expression.Replace("<", "\\<");
						}
						expression = FileSystemName.TranslateWin32Expression(expression);
					}
				}
			}
			return result;
		}

		// Token: 0x06008899 RID: 34969 RVA: 0x0014C150 File Offset: 0x0014A350
		private static bool MatchesPattern(string expression, ReadOnlySpan<char> name, EnumerationOptions options)
		{
			bool ignoreCase = (options.MatchCasing == MatchCasing.PlatformDefault && !false) || options.MatchCasing == MatchCasing.CaseInsensitive;
			MatchType matchType = options.MatchType;
			bool result;
			if (matchType != MatchType.Simple)
			{
				if (matchType != MatchType.Win32)
				{
					throw new ArgumentOutOfRangeException("options");
				}
				result = FileSystemName.MatchesWin32Expression(expression.AsSpan(), name, ignoreCase);
			}
			else
			{
				result = FileSystemName.MatchesSimpleExpression(expression.AsSpan(), name, ignoreCase);
			}
			return result;
		}

		// Token: 0x0600889A RID: 34970 RVA: 0x0014C1B4 File Offset: 0x0014A3B4
		internal static IEnumerable<string> UserFiles(string directory, string expression, EnumerationOptions options)
		{
			return new FileSystemEnumerable<string>(directory, delegate(ref FileSystemEntry entry)
			{
				return entry.ToSpecifiedFullPath();
			}, options)
			{
				ShouldIncludePredicate = delegate(ref FileSystemEntry entry)
				{
					return !entry.IsDirectory && FileSystemEnumerableFactory.MatchesPattern(expression, entry.FileName, options);
				}
			};
		}

		// Token: 0x0600889B RID: 34971 RVA: 0x0014C214 File Offset: 0x0014A414
		internal static IEnumerable<string> UserDirectories(string directory, string expression, EnumerationOptions options)
		{
			return new FileSystemEnumerable<string>(directory, delegate(ref FileSystemEntry entry)
			{
				return entry.ToSpecifiedFullPath();
			}, options)
			{
				ShouldIncludePredicate = delegate(ref FileSystemEntry entry)
				{
					return entry.IsDirectory && FileSystemEnumerableFactory.MatchesPattern(expression, entry.FileName, options);
				}
			};
		}

		// Token: 0x0600889C RID: 34972 RVA: 0x0014C274 File Offset: 0x0014A474
		internal static IEnumerable<string> UserEntries(string directory, string expression, EnumerationOptions options)
		{
			return new FileSystemEnumerable<string>(directory, delegate(ref FileSystemEntry entry)
			{
				return entry.ToSpecifiedFullPath();
			}, options)
			{
				ShouldIncludePredicate = delegate(ref FileSystemEntry entry)
				{
					return FileSystemEnumerableFactory.MatchesPattern(expression, entry.FileName, options);
				}
			};
		}

		// Token: 0x0600889D RID: 34973 RVA: 0x0014C2D4 File Offset: 0x0014A4D4
		internal static IEnumerable<FileInfo> FileInfos(string directory, string expression, EnumerationOptions options, bool isNormalized)
		{
			return new FileSystemEnumerable<FileInfo>(directory, delegate(ref FileSystemEntry entry)
			{
				return (FileInfo)entry.ToFileSystemInfo();
			}, options, isNormalized)
			{
				ShouldIncludePredicate = delegate(ref FileSystemEntry entry)
				{
					return !entry.IsDirectory && FileSystemEnumerableFactory.MatchesPattern(expression, entry.FileName, options);
				}
			};
		}

		// Token: 0x0600889E RID: 34974 RVA: 0x0014C334 File Offset: 0x0014A534
		internal static IEnumerable<DirectoryInfo> DirectoryInfos(string directory, string expression, EnumerationOptions options, bool isNormalized)
		{
			return new FileSystemEnumerable<DirectoryInfo>(directory, delegate(ref FileSystemEntry entry)
			{
				return (DirectoryInfo)entry.ToFileSystemInfo();
			}, options, isNormalized)
			{
				ShouldIncludePredicate = delegate(ref FileSystemEntry entry)
				{
					return entry.IsDirectory && FileSystemEnumerableFactory.MatchesPattern(expression, entry.FileName, options);
				}
			};
		}

		// Token: 0x0600889F RID: 34975 RVA: 0x0014C394 File Offset: 0x0014A594
		internal static IEnumerable<FileSystemInfo> FileSystemInfos(string directory, string expression, EnumerationOptions options, bool isNormalized)
		{
			return new FileSystemEnumerable<FileSystemInfo>(directory, delegate(ref FileSystemEntry entry)
			{
				return entry.ToFileSystemInfo();
			}, options, isNormalized)
			{
				ShouldIncludePredicate = delegate(ref FileSystemEntry entry)
				{
					return FileSystemEnumerableFactory.MatchesPattern(expression, entry.FileName, options);
				}
			};
		}
	}
}

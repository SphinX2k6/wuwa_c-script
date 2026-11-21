using System;
using System.Numerics;

namespace System.IO
{
	// Token: 0x02000851 RID: 2129
	internal static class DriveInfoInternal
	{
		// Token: 0x06008785 RID: 34693 RVA: 0x00147C78 File Offset: 0x00145E78
		public unsafe static string[] GetLogicalDrives()
		{
			int logicalDrives = Interop.Kernel32.GetLogicalDrives();
			if (logicalDrives == 0)
			{
				throw Win32Marshal.GetExceptionForLastWin32Error("");
			}
			int num = BitOperations.PopCount((uint)logicalDrives);
			string[] array = new string[num];
			<>y__InlineArray3<char> <>y__InlineArray = default(<>y__InlineArray3<char>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<char>, char>(ref <>y__InlineArray, 0) = 'A';
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<char>, char>(ref <>y__InlineArray, 1) = ':';
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<char>, char>(ref <>y__InlineArray, 2) = '\\';
			Span<char> span = <PrivateImplementationDetails>.InlineArrayAsSpan<<>y__InlineArray3<char>, char>(ref <>y__InlineArray, 3);
			uint num2 = (uint)logicalDrives;
			num = 0;
			while (num2 != 0U)
			{
				if ((num2 & 1U) != 0U)
				{
					array[num++] = span.ToString();
				}
				num2 >>= 1;
				ref char ptr = ref span[0];
				ptr += '\u0001';
			}
			return array;
		}

		// Token: 0x06008786 RID: 34694 RVA: 0x00147D0C File Offset: 0x00145F0C
		public static string NormalizeDriveName(string driveName)
		{
			string text;
			if (driveName.Length == 1)
			{
				text = driveName + ":\\";
			}
			else
			{
				text = Path.GetPathRoot(driveName);
				if (string.IsNullOrEmpty(text) || text.StartsWith("\\\\", StringComparison.Ordinal))
				{
					throw new ArgumentException(SR.Arg_MustBeDriveLetterOrRootDir, "driveName");
				}
			}
			if (text.Length == 2 && text[1] == ':')
			{
				text += "\\";
			}
			if (!char.IsAsciiLetter(driveName[0]))
			{
				throw new ArgumentException(SR.Arg_MustBeDriveLetterOrRootDir, "driveName");
			}
			return text;
		}
	}
}

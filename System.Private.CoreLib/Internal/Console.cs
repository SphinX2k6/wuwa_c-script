using System;
using System.Runtime.CompilerServices;

namespace Internal
{
	// Token: 0x02000065 RID: 101
	public static class Console
	{
		// Token: 0x060001F1 RID: 497 RVA: 0x00005BCA File Offset: 0x00003DCA
		[NullableContext(2)]
		public static void WriteLine(string s)
		{
			Console.Write(s + "\r\n");
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x00005BDC File Offset: 0x00003DDC
		public static void WriteLine()
		{
			Console.Write("\r\n");
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x00005BE8 File Offset: 0x00003DE8
		[NullableContext(1)]
		public static void Write(string s)
		{
			Console.WriteCore(Interop.Kernel32.GetStdHandle(-11), s);
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x00005BF8 File Offset: 0x00003DF8
		private unsafe static void WriteCore(IntPtr handle, string s)
		{
			int num = s.Length * 4;
			Span<byte> span;
			if (num < 1024)
			{
				int num2 = num;
				span = new Span<byte>(stackalloc byte[(UIntPtr)num2], num2);
			}
			else
			{
				span = new byte[num];
			}
			Span<byte> span2 = span;
			char* ptr;
			if (s == null)
			{
				ptr = null;
			}
			else
			{
				fixed (char* ptr2 = s.GetPinnableReference())
				{
					ptr = ptr2;
				}
			}
			char* lpWideCharStr = ptr;
			int numBytesToWrite;
			fixed (byte* pinnableReference = span2.GetPinnableReference())
			{
				byte* lpMultiByteStr = pinnableReference;
				numBytesToWrite = Interop.Kernel32.WideCharToMultiByte(Interop.Kernel32.GetConsoleOutputCP(), 0U, lpWideCharStr, s.Length, lpMultiByteStr, span2.Length, null, null);
			}
			char* ptr2 = null;
			fixed (byte* pinnableReference = span2.GetPinnableReference())
			{
				byte* bytes = pinnableReference;
				int num2;
				Interop.Kernel32.WriteFile(handle, bytes, numBytesToWrite, out num2, IntPtr.Zero);
			}
		}

		// Token: 0x02000066 RID: 102
		public static class Error
		{
			// Token: 0x060001F5 RID: 501 RVA: 0x00005CA4 File Offset: 0x00003EA4
			public static void WriteLine()
			{
				Console.Error.Write("\r\n");
			}

			// Token: 0x060001F6 RID: 502 RVA: 0x00005CB0 File Offset: 0x00003EB0
			[NullableContext(1)]
			public static void Write(string s)
			{
				Console.WriteCore(Interop.Kernel32.GetStdHandle(-12), s);
			}
		}
	}
}

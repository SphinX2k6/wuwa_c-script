using System;
using System.Buffers;
using System.Runtime.InteropServices;
using System.Text;

namespace System.Globalization
{
	// Token: 0x02000304 RID: 772
	internal static class Normalization
	{
		// Token: 0x0600383B RID: 14395 RVA: 0x000B91C3 File Offset: 0x000B73C3
		internal static bool IsNormalized(string strInput, NormalizationForm normalizationForm)
		{
			if (GlobalizationMode.Invariant)
			{
				return true;
			}
			if (!GlobalizationMode.UseNls)
			{
				return Normalization.IcuIsNormalized(strInput, normalizationForm);
			}
			return Normalization.NlsIsNormalized(strInput, normalizationForm);
		}

		// Token: 0x0600383C RID: 14396 RVA: 0x000B91E4 File Offset: 0x000B73E4
		internal static string Normalize(string strInput, NormalizationForm normalizationForm)
		{
			if (GlobalizationMode.Invariant)
			{
				return strInput;
			}
			if (!GlobalizationMode.UseNls)
			{
				return Normalization.IcuNormalize(strInput, normalizationForm);
			}
			return Normalization.NlsNormalize(strInput, normalizationForm);
		}

		// Token: 0x0600383D RID: 14397 RVA: 0x000B9208 File Offset: 0x000B7408
		private unsafe static bool IcuIsNormalized(string strInput, NormalizationForm normalizationForm)
		{
			Normalization.ValidateArguments(strInput, normalizationForm);
			char* ptr;
			if (strInput == null)
			{
				ptr = null;
			}
			else
			{
				fixed (char* ptr2 = strInput.GetPinnableReference())
				{
					ptr = ptr2;
				}
			}
			char* src = ptr;
			int num = Interop.Globalization.IsNormalized(normalizationForm, src, strInput.Length);
			char* ptr2 = null;
			if (num == -1)
			{
				throw new ArgumentException(SR.Argument_InvalidCharSequenceNoIndex, "strInput");
			}
			return num == 1;
		}

		// Token: 0x0600383E RID: 14398 RVA: 0x000B9254 File Offset: 0x000B7454
		private unsafe static string IcuNormalize(string strInput, NormalizationForm normalizationForm)
		{
			Normalization.ValidateArguments(strInput, normalizationForm);
			char[] array = null;
			try
			{
				Span<char> span;
				if (strInput.Length <= 512)
				{
					span = new Span<char>(stackalloc byte[(UIntPtr)1024], 512);
				}
				else
				{
					span = (array = ArrayPool<char>.Shared.Rent(strInput.Length));
				}
				Span<char> span2 = span;
				for (int i = 0; i < 2; i++)
				{
					int num;
					try
					{
						char* ptr;
						if (strInput == null)
						{
							ptr = null;
						}
						else
						{
							fixed (char* ptr2 = strInput.GetPinnableReference())
							{
								ptr = ptr2;
							}
						}
						char* src = ptr;
						try
						{
							fixed (char* ptr3 = MemoryMarshal.GetReference<char>(span2))
							{
								char* dstBuffer = ptr3;
								num = Interop.Globalization.NormalizeString(normalizationForm, src, strInput.Length, dstBuffer, span2.Length);
							}
						}
						finally
						{
							char* ptr3 = null;
						}
					}
					finally
					{
						char* ptr2 = null;
					}
					if (num == -1)
					{
						throw new ArgumentException(SR.Argument_InvalidCharSequenceNoIndex, "strInput");
					}
					if (num <= span2.Length)
					{
						ReadOnlySpan<char> readOnlySpan = span2.Slice(0, num);
						return readOnlySpan.SequenceEqual(strInput) ? strInput : new string(readOnlySpan);
					}
					if (i == 0)
					{
						if (array != null)
						{
							char[] array2 = array;
							array = null;
							ArrayPool<char>.Shared.Return(array2, false);
						}
						span2 = (array = ArrayPool<char>.Shared.Rent(num));
					}
				}
				throw new ArgumentException(SR.Argument_InvalidCharSequenceNoIndex, "strInput");
			}
			finally
			{
				if (array != null)
				{
					ArrayPool<char>.Shared.Return(array, false);
				}
			}
			string result;
			return result;
		}

		// Token: 0x0600383F RID: 14399 RVA: 0x000B93E8 File Offset: 0x000B75E8
		private static void ValidateArguments(string strInput, NormalizationForm normalizationForm)
		{
			if (false)
			{
			}
			if (normalizationForm != NormalizationForm.FormC && normalizationForm != NormalizationForm.FormD && normalizationForm != NormalizationForm.FormKC && normalizationForm != NormalizationForm.FormKD)
			{
				throw new ArgumentException(SR.Argument_InvalidNormalizationForm, "normalizationForm");
			}
			if (Normalization.HasInvalidUnicodeSequence(strInput))
			{
				throw new ArgumentException(SR.Argument_InvalidCharSequenceNoIndex, "strInput");
			}
		}

		// Token: 0x06003840 RID: 14400 RVA: 0x000B9428 File Offset: 0x000B7628
		private static bool HasInvalidUnicodeSequence(string s)
		{
			for (int i = 0; i < s.Length; i++)
			{
				char c = s[i];
				if (c >= '\ud800')
				{
					if (c == '￾')
					{
						return true;
					}
					if (char.IsLowSurrogate(c))
					{
						return true;
					}
					if (char.IsHighSurrogate(c))
					{
						if (i + 1 >= s.Length || !char.IsLowSurrogate(s[i + 1]))
						{
							return true;
						}
						i++;
					}
				}
			}
			return false;
		}

		// Token: 0x06003841 RID: 14401 RVA: 0x000B9494 File Offset: 0x000B7694
		private unsafe static bool NlsIsNormalized(string strInput, NormalizationForm normalizationForm)
		{
			char* ptr;
			if (strInput == null)
			{
				ptr = null;
			}
			else
			{
				fixed (char* ptr2 = strInput.GetPinnableReference())
				{
					ptr = ptr2;
				}
			}
			char* source = ptr;
			Interop.BOOL @bool = Interop.Normaliz.IsNormalizedString(normalizationForm, source, strInput.Length);
			char* ptr2 = null;
			int lastPInvokeError = Marshal.GetLastPInvokeError();
			if (lastPInvokeError <= 8)
			{
				if (lastPInvokeError == 0)
				{
					return @bool > Interop.BOOL.FALSE;
				}
				if (lastPInvokeError == 8)
				{
					throw new OutOfMemoryException();
				}
			}
			else if (lastPInvokeError == 87 || lastPInvokeError == 1113)
			{
				if (normalizationForm != NormalizationForm.FormC && normalizationForm != NormalizationForm.FormD && normalizationForm != NormalizationForm.FormKC && normalizationForm != NormalizationForm.FormKD)
				{
					throw new ArgumentException(SR.Argument_InvalidNormalizationForm, "normalizationForm");
				}
				throw new ArgumentException(SR.Argument_InvalidCharSequenceNoIndex, "strInput");
			}
			throw new InvalidOperationException(SR.Format(SR.UnknownError_Num, lastPInvokeError));
		}

		// Token: 0x06003842 RID: 14402 RVA: 0x000B9534 File Offset: 0x000B7734
		private unsafe static string NlsNormalize(string strInput, NormalizationForm normalizationForm)
		{
			if (strInput.Length == 0)
			{
				return string.Empty;
			}
			char[] array = null;
			try
			{
				Span<char> span;
				if (strInput.Length <= 512)
				{
					span = new Span<char>(stackalloc byte[(UIntPtr)1024], 512);
				}
				else
				{
					span = (array = ArrayPool<char>.Shared.Rent(strInput.Length));
				}
				Span<char> span2 = span;
				int num;
				int lastPInvokeError;
				for (;;)
				{
					try
					{
						char* ptr;
						if (strInput == null)
						{
							ptr = null;
						}
						else
						{
							fixed (char* ptr2 = strInput.GetPinnableReference())
							{
								ptr = ptr2;
							}
						}
						char* source = ptr;
						try
						{
							fixed (char* ptr3 = MemoryMarshal.GetReference<char>(span2))
							{
								char* destination = ptr3;
								num = Interop.Normaliz.NormalizeString(normalizationForm, source, strInput.Length, destination, span2.Length);
							}
						}
						finally
						{
							char* ptr3 = null;
						}
					}
					finally
					{
						char* ptr2 = null;
					}
					lastPInvokeError = Marshal.GetLastPInvokeError();
					if (lastPInvokeError <= 8)
					{
						break;
					}
					if (lastPInvokeError == 87)
					{
						goto IL_12D;
					}
					if (lastPInvokeError != 122)
					{
						goto Block_10;
					}
					num = Math.Abs(num);
					if (array != null)
					{
						char[] array2 = array;
						array = null;
						ArrayPool<char>.Shared.Return(array2, false);
					}
					span2 = (array = ArrayPool<char>.Shared.Rent(num));
				}
				if (lastPInvokeError == 0)
				{
					ReadOnlySpan<char> readOnlySpan = span2.Slice(0, num);
					return readOnlySpan.SequenceEqual(strInput) ? strInput : new string(readOnlySpan);
				}
				if (lastPInvokeError != 8)
				{
					goto IL_163;
				}
				throw new OutOfMemoryException();
				Block_10:
				if (lastPInvokeError != 1113)
				{
					goto IL_163;
				}
				IL_12D:
				if (normalizationForm != NormalizationForm.FormC && normalizationForm != NormalizationForm.FormD && normalizationForm != NormalizationForm.FormKC && normalizationForm != NormalizationForm.FormKD)
				{
					throw new ArgumentException(SR.Argument_InvalidNormalizationForm, "normalizationForm");
				}
				throw new ArgumentException(SR.Argument_InvalidCharSequenceNoIndex, "strInput");
				IL_163:
				throw new InvalidOperationException(SR.Format(SR.UnknownError_Num, lastPInvokeError));
			}
			finally
			{
				if (array != null)
				{
					ArrayPool<char>.Shared.Return(array, false);
				}
			}
			string result;
			return result;
		}
	}
}

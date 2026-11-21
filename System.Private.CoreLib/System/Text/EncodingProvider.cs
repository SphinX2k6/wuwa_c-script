using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;

namespace System.Text
{
	// Token: 0x0200022F RID: 559
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class EncodingProvider
	{
		// Token: 0x06002AB9 RID: 10937 RVA: 0x00005ACC File Offset: 0x00003CCC
		public EncodingProvider()
		{
		}

		// Token: 0x06002ABA RID: 10938
		[return: Nullable(2)]
		public abstract Encoding GetEncoding(string name);

		// Token: 0x06002ABB RID: 10939
		[NullableContext(2)]
		public abstract Encoding GetEncoding(int codepage);

		// Token: 0x06002ABC RID: 10940 RVA: 0x0008565C File Offset: 0x0008385C
		[return: Nullable(2)]
		public virtual Encoding GetEncoding(string name, EncoderFallback encoderFallback, DecoderFallback decoderFallback)
		{
			Encoding encoding = this.GetEncoding(name);
			if (encoding != null)
			{
				encoding = (Encoding)encoding.Clone();
				encoding.EncoderFallback = encoderFallback;
				encoding.DecoderFallback = decoderFallback;
			}
			return encoding;
		}

		// Token: 0x06002ABD RID: 10941 RVA: 0x00085690 File Offset: 0x00083890
		[return: Nullable(2)]
		public virtual Encoding GetEncoding(int codepage, EncoderFallback encoderFallback, DecoderFallback decoderFallback)
		{
			Encoding encoding = this.GetEncoding(codepage);
			if (encoding != null)
			{
				encoding = (Encoding)encoding.Clone();
				encoding.EncoderFallback = encoderFallback;
				encoding.DecoderFallback = decoderFallback;
			}
			return encoding;
		}

		// Token: 0x06002ABE RID: 10942 RVA: 0x000856C3 File Offset: 0x000838C3
		public virtual IEnumerable<EncodingInfo> GetEncodings()
		{
			return Array.Empty<EncodingInfo>();
		}

		// Token: 0x06002ABF RID: 10943 RVA: 0x000856CC File Offset: 0x000838CC
		internal static void AddProvider(EncodingProvider provider)
		{
			ArgumentNullException.ThrowIfNull(provider, "provider");
			if (EncodingProvider.s_providers == null && Interlocked.CompareExchange<EncodingProvider[]>(ref EncodingProvider.s_providers, new EncodingProvider[]
			{
				provider
			}, null) == null)
			{
				return;
			}
			for (;;)
			{
				EncodingProvider[] array = EncodingProvider.s_providers;
				if (Array.IndexOf<EncodingProvider>(array, provider) >= 0)
				{
					break;
				}
				EncodingProvider[] array2 = new EncodingProvider[array.Length + 1];
				Array.Copy(array, array2, array.Length);
				EncodingProvider[] array3 = array2;
				array3[array3.Length - 1] = provider;
				if (Interlocked.CompareExchange<EncodingProvider[]>(ref EncodingProvider.s_providers, array2, array) == array)
				{
					return;
				}
			}
		}

		// Token: 0x06002AC0 RID: 10944 RVA: 0x00085744 File Offset: 0x00083944
		internal static Encoding GetEncodingFromProvider(int codepage)
		{
			EncodingProvider[] array = EncodingProvider.s_providers;
			if (array == null)
			{
				return null;
			}
			EncodingProvider[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				Encoding encoding = array2[i].GetEncoding(codepage);
				if (encoding != null)
				{
					return encoding;
				}
			}
			return null;
		}

		// Token: 0x06002AC1 RID: 10945 RVA: 0x00085780 File Offset: 0x00083980
		internal static Dictionary<int, EncodingInfo> GetEncodingListFromProviders()
		{
			EncodingProvider[] array = EncodingProvider.s_providers;
			if (array == null)
			{
				return null;
			}
			Dictionary<int, EncodingInfo> dictionary = new Dictionary<int, EncodingInfo>();
			EncodingProvider[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				IEnumerable<EncodingInfo> encodings = array2[i].GetEncodings();
				if (encodings != null)
				{
					foreach (EncodingInfo encodingInfo in encodings)
					{
						dictionary.TryAdd(encodingInfo.CodePage, encodingInfo);
					}
				}
			}
			return dictionary;
		}

		// Token: 0x06002AC2 RID: 10946 RVA: 0x0008580C File Offset: 0x00083A0C
		internal static Encoding GetEncodingFromProvider(string encodingName)
		{
			EncodingProvider[] array = EncodingProvider.s_providers;
			if (array == null)
			{
				return null;
			}
			EncodingProvider[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				Encoding encoding = array2[i].GetEncoding(encodingName);
				if (encoding != null)
				{
					return encoding;
				}
			}
			return null;
		}

		// Token: 0x06002AC3 RID: 10947 RVA: 0x00085848 File Offset: 0x00083A48
		internal static Encoding GetEncodingFromProvider(int codepage, EncoderFallback enc, DecoderFallback dec)
		{
			EncodingProvider[] array = EncodingProvider.s_providers;
			if (array == null)
			{
				return null;
			}
			EncodingProvider[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				Encoding encoding = array2[i].GetEncoding(codepage, enc, dec);
				if (encoding != null)
				{
					return encoding;
				}
			}
			return null;
		}

		// Token: 0x06002AC4 RID: 10948 RVA: 0x00085884 File Offset: 0x00083A84
		internal static Encoding GetEncodingFromProvider(string encodingName, EncoderFallback enc, DecoderFallback dec)
		{
			EncodingProvider[] array = EncodingProvider.s_providers;
			if (array == null)
			{
				return null;
			}
			EncodingProvider[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				Encoding encoding = array2[i].GetEncoding(encodingName, enc, dec);
				if (encoding != null)
				{
					return encoding;
				}
			}
			return null;
		}

		// Token: 0x0400078A RID: 1930
		private static volatile EncodingProvider[] s_providers;
	}
}

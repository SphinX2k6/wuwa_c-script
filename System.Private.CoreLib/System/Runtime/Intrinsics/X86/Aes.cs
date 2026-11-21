using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System.Runtime.Intrinsics.X86
{
	// Token: 0x02000569 RID: 1385
	[Intrinsic]
	[CLSCompliant(false)]
	public abstract class Aes : Sse2
	{
		// Token: 0x17000D76 RID: 3446
		// (get) Token: 0x060062E8 RID: 25320 RVA: 0x0010954A File Offset: 0x0010774A
		public new static bool IsSupported
		{
			get
			{
				return Aes.IsSupported;
			}
		}

		// Token: 0x060062E9 RID: 25321 RVA: 0x00109551 File Offset: 0x00107751
		public static Vector128<byte> Decrypt(Vector128<byte> value, Vector128<byte> roundKey)
		{
			return Aes.Decrypt(value, roundKey);
		}

		// Token: 0x060062EA RID: 25322 RVA: 0x0010955A File Offset: 0x0010775A
		public static Vector128<byte> DecryptLast(Vector128<byte> value, Vector128<byte> roundKey)
		{
			return Aes.DecryptLast(value, roundKey);
		}

		// Token: 0x060062EB RID: 25323 RVA: 0x00109563 File Offset: 0x00107763
		public static Vector128<byte> Encrypt(Vector128<byte> value, Vector128<byte> roundKey)
		{
			return Aes.Encrypt(value, roundKey);
		}

		// Token: 0x060062EC RID: 25324 RVA: 0x0010956C File Offset: 0x0010776C
		public static Vector128<byte> EncryptLast(Vector128<byte> value, Vector128<byte> roundKey)
		{
			return Aes.EncryptLast(value, roundKey);
		}

		// Token: 0x060062ED RID: 25325 RVA: 0x00109575 File Offset: 0x00107775
		public static Vector128<byte> InverseMixColumns(Vector128<byte> value)
		{
			return Aes.InverseMixColumns(value);
		}

		// Token: 0x060062EE RID: 25326 RVA: 0x0010957D File Offset: 0x0010777D
		public static Vector128<byte> KeygenAssist(Vector128<byte> value, [ConstantExpected] byte control)
		{
			return Aes.KeygenAssist(value, control);
		}

		// Token: 0x0200056A RID: 1386
		[Intrinsic]
		public new abstract class X64 : Sse2.X64
		{
			// Token: 0x17000D77 RID: 3447
			// (get) Token: 0x060062EF RID: 25327 RVA: 0x00109586 File Offset: 0x00107786
			public new static bool IsSupported
			{
				get
				{
					return Aes.X64.IsSupported;
				}
			}
		}
	}
}

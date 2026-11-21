using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D48 RID: 3400
	public struct FavorWord : IFlatbufferObject
	{
		// Token: 0x170010E4 RID: 4324
		// (get) Token: 0x06007344 RID: 29508 RVA: 0x0024B739 File Offset: 0x00249939
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007345 RID: 29509 RVA: 0x0024B746 File Offset: 0x00249946
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007346 RID: 29510 RVA: 0x0024B750 File Offset: 0x00249950
		public static FavorWord GetRootAsFavorWord(ByteBuffer _bb)
		{
			return FavorWord.GetRootAsFavorWord(_bb, default(FavorWord));
		}

		// Token: 0x06007347 RID: 29511 RVA: 0x0024B76C File Offset: 0x0024996C
		public static FavorWord GetRootAsFavorWord(ByteBuffer _bb, FavorWord obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007348 RID: 29512 RVA: 0x0024B789 File Offset: 0x00249989
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007349 RID: 29513 RVA: 0x0024B798 File Offset: 0x00249998
		public FavorWord __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170010E5 RID: 4325
		// (get) Token: 0x0600734A RID: 29514 RVA: 0x0024B7A8 File Offset: 0x002499A8
		public int Id
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170010E6 RID: 4326
		// (get) Token: 0x0600734B RID: 29515 RVA: 0x0024B7E4 File Offset: 0x002499E4
		public int RoleId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170010E7 RID: 4327
		// (get) Token: 0x0600734C RID: 29516 RVA: 0x0024B820 File Offset: 0x00249A20
		public int Type
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170010E8 RID: 4328
		// (get) Token: 0x0600734D RID: 29517 RVA: 0x0024B85C File Offset: 0x00249A5C
		public int Sort
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170010E9 RID: 4329
		// (get) Token: 0x0600734E RID: 29518 RVA: 0x0024B89C File Offset: 0x00249A9C
		public string Title
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600734F RID: 29519 RVA: 0x0024B8D4 File Offset: 0x00249AD4
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06007350 RID: 29520 RVA: 0x0024B8E4 File Offset: 0x00249AE4
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170010EA RID: 4330
		// (get) Token: 0x06007351 RID: 29521 RVA: 0x0024B8FC File Offset: 0x00249AFC
		public string Content
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007352 RID: 29522 RVA: 0x0024B934 File Offset: 0x00249B34
		public Span<byte> GetContentBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06007353 RID: 29523 RVA: 0x0024B944 File Offset: 0x00249B44
		public byte[] GetContentArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170010EB RID: 4331
		// (get) Token: 0x06007354 RID: 29524 RVA: 0x0024B95C File Offset: 0x00249B5C
		public string Voice
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007355 RID: 29525 RVA: 0x0024B994 File Offset: 0x00249B94
		public Span<byte> GetVoiceBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06007356 RID: 29526 RVA: 0x0024B9A4 File Offset: 0x00249BA4
		public byte[] GetVoiceArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170010EC RID: 4332
		// (get) Token: 0x06007357 RID: 29527 RVA: 0x0024B9BC File Offset: 0x00249BBC
		public string CVCn
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007358 RID: 29528 RVA: 0x0024B9F4 File Offset: 0x00249BF4
		public Span<byte> GetCVCnBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06007359 RID: 29529 RVA: 0x0024BA04 File Offset: 0x00249C04
		public byte[] GetCVCnArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x170010ED RID: 4333
		// (get) Token: 0x0600735A RID: 29530 RVA: 0x0024BA1C File Offset: 0x00249C1C
		public string CVJp
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600735B RID: 29531 RVA: 0x0024BA54 File Offset: 0x00249C54
		public Span<byte> GetCVJpBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600735C RID: 29532 RVA: 0x0024BA64 File Offset: 0x00249C64
		public byte[] GetCVJpArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x170010EE RID: 4334
		// (get) Token: 0x0600735D RID: 29533 RVA: 0x0024BA7C File Offset: 0x00249C7C
		public string CVEn
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600735E RID: 29534 RVA: 0x0024BAB4 File Offset: 0x00249CB4
		public Span<byte> GetCVEnBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600735F RID: 29535 RVA: 0x0024BAC4 File Offset: 0x00249CC4
		public byte[] GetCVEnArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x170010EF RID: 4335
		// (get) Token: 0x06007360 RID: 29536 RVA: 0x0024BADC File Offset: 0x00249CDC
		public string CVKo
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007361 RID: 29537 RVA: 0x0024BB14 File Offset: 0x00249D14
		public Span<byte> GetCVKoBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x06007362 RID: 29538 RVA: 0x0024BB24 File Offset: 0x00249D24
		public byte[] GetCVKoArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x170010F0 RID: 4336
		// (get) Token: 0x06007363 RID: 29539 RVA: 0x0024BB3C File Offset: 0x00249D3C
		public int CondGroupId
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170010F1 RID: 4337
		// (get) Token: 0x06007364 RID: 29540 RVA: 0x0024BB7C File Offset: 0x00249D7C
		public string MotionImg
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007365 RID: 29541 RVA: 0x0024BBB4 File Offset: 0x00249DB4
		public Span<byte> GetMotionImgBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x06007366 RID: 29542 RVA: 0x0024BBC4 File Offset: 0x00249DC4
		public byte[] GetMotionImgArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x170010F2 RID: 4338
		// (get) Token: 0x06007367 RID: 29543 RVA: 0x0024BBDC File Offset: 0x00249DDC
		public string AniBlueprint
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007368 RID: 29544 RVA: 0x0024BC14 File Offset: 0x00249E14
		public Span<byte> GetAniBlueprintBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x06007369 RID: 29545 RVA: 0x0024BC24 File Offset: 0x00249E24
		public byte[] GetAniBlueprintArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x170010F3 RID: 4339
		// (get) Token: 0x0600736A RID: 29546 RVA: 0x0024BC3C File Offset: 0x00249E3C
		public string AniMontage
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600736B RID: 29547 RVA: 0x0024BC74 File Offset: 0x00249E74
		public Span<byte> GetAniMontageBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x0600736C RID: 29548 RVA: 0x0024BC84 File Offset: 0x00249E84
		public byte[] GetAniMontageArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x170010F4 RID: 4340
		// (get) Token: 0x0600736D RID: 29549 RVA: 0x0024BC9C File Offset: 0x00249E9C
		public int Morph
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04005293 RID: 21139
		private Table __p;
	}
}

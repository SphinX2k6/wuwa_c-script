using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D5A RID: 3418
	public struct I18nTextures : IFlatbufferObject
	{
		// Token: 0x1700189B RID: 6299
		// (get) Token: 0x06008268 RID: 33384 RVA: 0x0025CC35 File Offset: 0x0025AE35
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008269 RID: 33385 RVA: 0x0025CC42 File Offset: 0x0025AE42
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600826A RID: 33386 RVA: 0x0025CC4C File Offset: 0x0025AE4C
		public static I18nTextures GetRootAsI18nTextures(ByteBuffer _bb)
		{
			return I18nTextures.GetRootAsI18nTextures(_bb, default(I18nTextures));
		}

		// Token: 0x0600826B RID: 33387 RVA: 0x0025CC68 File Offset: 0x0025AE68
		public static I18nTextures GetRootAsI18nTextures(ByteBuffer _bb, I18nTextures obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600826C RID: 33388 RVA: 0x0025CC85 File Offset: 0x0025AE85
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600826D RID: 33389 RVA: 0x0025CC94 File Offset: 0x0025AE94
		public I18nTextures __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700189C RID: 6300
		// (get) Token: 0x0600826E RID: 33390 RVA: 0x0025CCA4 File Offset: 0x0025AEA4
		public string Id
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600826F RID: 33391 RVA: 0x0025CCDB File Offset: 0x0025AEDB
		public Span<byte> GetIdBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06008270 RID: 33392 RVA: 0x0025CCEA File Offset: 0x0025AEEA
		public byte[] GetIdArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x1700189D RID: 6301
		// (get) Token: 0x06008271 RID: 33393 RVA: 0x0025CD04 File Offset: 0x0025AF04
		public string HandleType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008272 RID: 33394 RVA: 0x0025CD3B File Offset: 0x0025AF3B
		public Span<byte> GetHandleTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06008273 RID: 33395 RVA: 0x0025CD4A File Offset: 0x0025AF4A
		public byte[] GetHandleTypeArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700189E RID: 6302
		// (get) Token: 0x06008274 RID: 33396 RVA: 0x0025CD64 File Offset: 0x0025AF64
		public string ZhHans
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008275 RID: 33397 RVA: 0x0025CD9B File Offset: 0x0025AF9B
		public Span<byte> GetZhHansBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06008276 RID: 33398 RVA: 0x0025CDAA File Offset: 0x0025AFAA
		public byte[] GetZhHansArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700189F RID: 6303
		// (get) Token: 0x06008277 RID: 33399 RVA: 0x0025CDC4 File Offset: 0x0025AFC4
		public string En
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008278 RID: 33400 RVA: 0x0025CDFC File Offset: 0x0025AFFC
		public Span<byte> GetEnBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06008279 RID: 33401 RVA: 0x0025CE0C File Offset: 0x0025B00C
		public byte[] GetEnArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170018A0 RID: 6304
		// (get) Token: 0x0600827A RID: 33402 RVA: 0x0025CE24 File Offset: 0x0025B024
		public string Ja
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

		// Token: 0x0600827B RID: 33403 RVA: 0x0025CE5C File Offset: 0x0025B05C
		public Span<byte> GetJaBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600827C RID: 33404 RVA: 0x0025CE6C File Offset: 0x0025B06C
		public byte[] GetJaArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170018A1 RID: 6305
		// (get) Token: 0x0600827D RID: 33405 RVA: 0x0025CE84 File Offset: 0x0025B084
		public string Ko
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

		// Token: 0x0600827E RID: 33406 RVA: 0x0025CEBC File Offset: 0x0025B0BC
		public Span<byte> GetKoBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600827F RID: 33407 RVA: 0x0025CECC File Offset: 0x0025B0CC
		public byte[] GetKoArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170018A2 RID: 6306
		// (get) Token: 0x06008280 RID: 33408 RVA: 0x0025CEE4 File Offset: 0x0025B0E4
		public string Ru
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

		// Token: 0x06008281 RID: 33409 RVA: 0x0025CF1C File Offset: 0x0025B11C
		public Span<byte> GetRuBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06008282 RID: 33410 RVA: 0x0025CF2C File Offset: 0x0025B12C
		public byte[] GetRuArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170018A3 RID: 6307
		// (get) Token: 0x06008283 RID: 33411 RVA: 0x0025CF44 File Offset: 0x0025B144
		public string ZhHant
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

		// Token: 0x06008284 RID: 33412 RVA: 0x0025CF7C File Offset: 0x0025B17C
		public Span<byte> GetZhHantBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06008285 RID: 33413 RVA: 0x0025CF8C File Offset: 0x0025B18C
		public byte[] GetZhHantArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x170018A4 RID: 6308
		// (get) Token: 0x06008286 RID: 33414 RVA: 0x0025CFA4 File Offset: 0x0025B1A4
		public string De
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

		// Token: 0x06008287 RID: 33415 RVA: 0x0025CFDC File Offset: 0x0025B1DC
		public Span<byte> GetDeBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06008288 RID: 33416 RVA: 0x0025CFEC File Offset: 0x0025B1EC
		public byte[] GetDeArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x170018A5 RID: 6309
		// (get) Token: 0x06008289 RID: 33417 RVA: 0x0025D004 File Offset: 0x0025B204
		public string Es
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

		// Token: 0x0600828A RID: 33418 RVA: 0x0025D03C File Offset: 0x0025B23C
		public Span<byte> GetEsBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600828B RID: 33419 RVA: 0x0025D04C File Offset: 0x0025B24C
		public byte[] GetEsArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x170018A6 RID: 6310
		// (get) Token: 0x0600828C RID: 33420 RVA: 0x0025D064 File Offset: 0x0025B264
		public string Pt
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

		// Token: 0x0600828D RID: 33421 RVA: 0x0025D09C File Offset: 0x0025B29C
		public Span<byte> GetPtBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600828E RID: 33422 RVA: 0x0025D0AC File Offset: 0x0025B2AC
		public byte[] GetPtArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x170018A7 RID: 6311
		// (get) Token: 0x0600828F RID: 33423 RVA: 0x0025D0C4 File Offset: 0x0025B2C4
		public string Idn
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008290 RID: 33424 RVA: 0x0025D0FC File Offset: 0x0025B2FC
		public Span<byte> GetIdnBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x06008291 RID: 33425 RVA: 0x0025D10C File Offset: 0x0025B30C
		public byte[] GetIdnArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x170018A8 RID: 6312
		// (get) Token: 0x06008292 RID: 33426 RVA: 0x0025D124 File Offset: 0x0025B324
		public string Fr
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

		// Token: 0x06008293 RID: 33427 RVA: 0x0025D15C File Offset: 0x0025B35C
		public Span<byte> GetFrBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x06008294 RID: 33428 RVA: 0x0025D16C File Offset: 0x0025B36C
		public byte[] GetFrArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x170018A9 RID: 6313
		// (get) Token: 0x06008295 RID: 33429 RVA: 0x0025D184 File Offset: 0x0025B384
		public string Vi
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

		// Token: 0x06008296 RID: 33430 RVA: 0x0025D1BC File Offset: 0x0025B3BC
		public Span<byte> GetViBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x06008297 RID: 33431 RVA: 0x0025D1CC File Offset: 0x0025B3CC
		public byte[] GetViArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x170018AA RID: 6314
		// (get) Token: 0x06008298 RID: 33432 RVA: 0x0025D1E4 File Offset: 0x0025B3E4
		public string Th
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

		// Token: 0x06008299 RID: 33433 RVA: 0x0025D21C File Offset: 0x0025B41C
		public Span<byte> GetThBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x0600829A RID: 33434 RVA: 0x0025D22C File Offset: 0x0025B42C
		public byte[] GetThArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x04004DD9 RID: 19929
		private Table __p;
	}
}

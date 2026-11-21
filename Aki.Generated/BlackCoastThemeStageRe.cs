using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C17 RID: 3095
	public struct BlackCoastThemeStageRe : IFlatbufferObject
	{
		// Token: 0x17000580 RID: 1408
		// (get) Token: 0x0600534A RID: 21322 RVA: 0x002046B5 File Offset: 0x002028B5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600534B RID: 21323 RVA: 0x002046C2 File Offset: 0x002028C2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600534C RID: 21324 RVA: 0x002046CC File Offset: 0x002028CC
		public static BlackCoastThemeStageRe GetRootAsBlackCoastThemeStageRe(ByteBuffer _bb)
		{
			return BlackCoastThemeStageRe.GetRootAsBlackCoastThemeStageRe(_bb, default(BlackCoastThemeStageRe));
		}

		// Token: 0x0600534D RID: 21325 RVA: 0x002046E8 File Offset: 0x002028E8
		public static BlackCoastThemeStageRe GetRootAsBlackCoastThemeStageRe(ByteBuffer _bb, BlackCoastThemeStageRe obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600534E RID: 21326 RVA: 0x00204705 File Offset: 0x00202905
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600534F RID: 21327 RVA: 0x00204714 File Offset: 0x00202914
		public BlackCoastThemeStageRe __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000581 RID: 1409
		// (get) Token: 0x06005350 RID: 21328 RVA: 0x00204724 File Offset: 0x00202924
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

		// Token: 0x17000582 RID: 1410
		// (get) Token: 0x06005351 RID: 21329 RVA: 0x00204760 File Offset: 0x00202960
		public int ActivityId
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

		// Token: 0x17000583 RID: 1411
		// (get) Token: 0x06005352 RID: 21330 RVA: 0x0020479C File Offset: 0x0020299C
		public string Title
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

		// Token: 0x06005353 RID: 21331 RVA: 0x002047D3 File Offset: 0x002029D3
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06005354 RID: 21332 RVA: 0x002047E2 File Offset: 0x002029E2
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000584 RID: 1412
		// (get) Token: 0x06005355 RID: 21333 RVA: 0x002047FC File Offset: 0x002029FC
		public string TitleDetail
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

		// Token: 0x06005356 RID: 21334 RVA: 0x00204834 File Offset: 0x00202A34
		public Span<byte> GetTitleDetailBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06005357 RID: 21335 RVA: 0x00204844 File Offset: 0x00202A44
		public byte[] GetTitleDetailArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000585 RID: 1413
		// (get) Token: 0x06005358 RID: 21336 RVA: 0x0020485C File Offset: 0x00202A5C
		public int OpenConditionId
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000586 RID: 1414
		// (get) Token: 0x06005359 RID: 21337 RVA: 0x0020489C File Offset: 0x00202A9C
		public int QuestionId
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000587 RID: 1415
		// (get) Token: 0x0600535A RID: 21338 RVA: 0x002048DC File Offset: 0x00202ADC
		public string VideoSource
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

		// Token: 0x0600535B RID: 21339 RVA: 0x00204914 File Offset: 0x00202B14
		public Span<byte> GetVideoSourceBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600535C RID: 21340 RVA: 0x00204924 File Offset: 0x00202B24
		public byte[] GetVideoSourceArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17000588 RID: 1416
		// (get) Token: 0x0600535D RID: 21341 RVA: 0x0020493C File Offset: 0x00202B3C
		public string TextureSmall
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

		// Token: 0x0600535E RID: 21342 RVA: 0x00204974 File Offset: 0x00202B74
		public Span<byte> GetTextureSmallBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600535F RID: 21343 RVA: 0x00204984 File Offset: 0x00202B84
		public byte[] GetTextureSmallArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17000589 RID: 1417
		// (get) Token: 0x06005360 RID: 21344 RVA: 0x0020499C File Offset: 0x00202B9C
		public string TextureNormal
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

		// Token: 0x06005361 RID: 21345 RVA: 0x002049D4 File Offset: 0x00202BD4
		public Span<byte> GetTextureNormalBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06005362 RID: 21346 RVA: 0x002049E4 File Offset: 0x00202BE4
		public byte[] GetTextureNormalArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x04005112 RID: 20754
		private Table __p;
	}
}

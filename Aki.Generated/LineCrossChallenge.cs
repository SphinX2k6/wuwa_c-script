using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DCA RID: 3530
	public struct LineCrossChallenge : IFlatbufferObject
	{
		// Token: 0x17001CEA RID: 7402
		// (get) Token: 0x06008E15 RID: 36373 RVA: 0x00277B18 File Offset: 0x00275D18
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008E16 RID: 36374 RVA: 0x00277B25 File Offset: 0x00275D25
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008E17 RID: 36375 RVA: 0x00277B2C File Offset: 0x00275D2C
		public static LineCrossChallenge GetRootAsLineCrossChallenge(ByteBuffer _bb)
		{
			return LineCrossChallenge.GetRootAsLineCrossChallenge(_bb, default(LineCrossChallenge));
		}

		// Token: 0x06008E18 RID: 36376 RVA: 0x00277B48 File Offset: 0x00275D48
		public static LineCrossChallenge GetRootAsLineCrossChallenge(ByteBuffer _bb, LineCrossChallenge obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008E19 RID: 36377 RVA: 0x00277B65 File Offset: 0x00275D65
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008E1A RID: 36378 RVA: 0x00277B74 File Offset: 0x00275D74
		public LineCrossChallenge __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001CEB RID: 7403
		// (get) Token: 0x06008E1B RID: 36379 RVA: 0x00277B84 File Offset: 0x00275D84
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

		// Token: 0x17001CEC RID: 7404
		// (get) Token: 0x06008E1C RID: 36380 RVA: 0x00277BC0 File Offset: 0x00275DC0
		public int GroupId
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

		// Token: 0x17001CED RID: 7405
		// (get) Token: 0x06008E1D RID: 36381 RVA: 0x00277BFC File Offset: 0x00275DFC
		public int Difficulty
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

		// Token: 0x17001CEE RID: 7406
		// (get) Token: 0x06008E1E RID: 36382 RVA: 0x00277C38 File Offset: 0x00275E38
		public string SubTitle
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

		// Token: 0x06008E1F RID: 36383 RVA: 0x00277C70 File Offset: 0x00275E70
		public Span<byte> GetSubTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06008E20 RID: 36384 RVA: 0x00277C80 File Offset: 0x00275E80
		public byte[] GetSubTitleArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17001CEF RID: 7407
		// (get) Token: 0x06008E21 RID: 36385 RVA: 0x00277C98 File Offset: 0x00275E98
		public string DifficultTexture
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

		// Token: 0x06008E22 RID: 36386 RVA: 0x00277CD0 File Offset: 0x00275ED0
		public Span<byte> GetDifficultTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06008E23 RID: 36387 RVA: 0x00277CE0 File Offset: 0x00275EE0
		public byte[] GetDifficultTextureArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17001CF0 RID: 7408
		// (get) Token: 0x06008E24 RID: 36388 RVA: 0x00277CF8 File Offset: 0x00275EF8
		public int ActivityId
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

		// Token: 0x17001CF1 RID: 7409
		// (get) Token: 0x06008E25 RID: 36389 RVA: 0x00277D38 File Offset: 0x00275F38
		public int OpenDay
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001CF2 RID: 7410
		// (get) Token: 0x06008E26 RID: 36390 RVA: 0x00277D78 File Offset: 0x00275F78
		public int RewardId
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001CF3 RID: 7411
		// (get) Token: 0x06008E27 RID: 36391 RVA: 0x00277DB8 File Offset: 0x00275FB8
		public int EntityConfigId
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001CF4 RID: 7412
		// (get) Token: 0x06008E28 RID: 36392 RVA: 0x00277DF8 File Offset: 0x00275FF8
		public string Name
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

		// Token: 0x06008E29 RID: 36393 RVA: 0x00277E30 File Offset: 0x00276030
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06008E2A RID: 36394 RVA: 0x00277E40 File Offset: 0x00276040
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17001CF5 RID: 7413
		// (get) Token: 0x06008E2B RID: 36395 RVA: 0x00277E58 File Offset: 0x00276058
		public string DifficultDesc
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

		// Token: 0x06008E2C RID: 36396 RVA: 0x00277E90 File Offset: 0x00276090
		public Span<byte> GetDifficultDescBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x06008E2D RID: 36397 RVA: 0x00277EA0 File Offset: 0x002760A0
		public byte[] GetDifficultDescArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17001CF6 RID: 7414
		// (get) Token: 0x06008E2E RID: 36398 RVA: 0x00277EB8 File Offset: 0x002760B8
		public string Desc
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

		// Token: 0x06008E2F RID: 36399 RVA: 0x00277EF0 File Offset: 0x002760F0
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x06008E30 RID: 36400 RVA: 0x00277F00 File Offset: 0x00276100
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x04004E60 RID: 20064
		private Table __p;
	}
}

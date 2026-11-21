using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CB9 RID: 3257
	public struct DangoMonopolyBoard : IFlatbufferObject
	{
		// Token: 0x17000C29 RID: 3113
		// (get) Token: 0x06006634 RID: 26164 RVA: 0x0022ED01 File Offset: 0x0022CF01
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006635 RID: 26165 RVA: 0x0022ED0E File Offset: 0x0022CF0E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006636 RID: 26166 RVA: 0x0022ED18 File Offset: 0x0022CF18
		public static DangoMonopolyBoard GetRootAsDangoMonopolyBoard(ByteBuffer _bb)
		{
			return DangoMonopolyBoard.GetRootAsDangoMonopolyBoard(_bb, default(DangoMonopolyBoard));
		}

		// Token: 0x06006637 RID: 26167 RVA: 0x0022ED34 File Offset: 0x0022CF34
		public static DangoMonopolyBoard GetRootAsDangoMonopolyBoard(ByteBuffer _bb, DangoMonopolyBoard obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006638 RID: 26168 RVA: 0x0022ED51 File Offset: 0x0022CF51
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006639 RID: 26169 RVA: 0x0022ED60 File Offset: 0x0022CF60
		public DangoMonopolyBoard __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000C2A RID: 3114
		// (get) Token: 0x0600663A RID: 26170 RVA: 0x0022ED70 File Offset: 0x0022CF70
		public int BoardId
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

		// Token: 0x17000C2B RID: 3115
		// (get) Token: 0x0600663B RID: 26171 RVA: 0x0022EDAC File Offset: 0x0022CFAC
		public int BoardGroupId
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

		// Token: 0x17000C2C RID: 3116
		// (get) Token: 0x0600663C RID: 26172 RVA: 0x0022EDE8 File Offset: 0x0022CFE8
		public int ItemId
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

		// Token: 0x17000C2D RID: 3117
		// (get) Token: 0x0600663D RID: 26173 RVA: 0x0022EE24 File Offset: 0x0022D024
		public int ItemNum
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

		// Token: 0x17000C2E RID: 3118
		// (get) Token: 0x0600663E RID: 26174 RVA: 0x0022EE64 File Offset: 0x0022D064
		public int GridGroupId
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

		// Token: 0x17000C2F RID: 3119
		// (get) Token: 0x0600663F RID: 26175 RVA: 0x0022EEA4 File Offset: 0x0022D0A4
		public int UnlockDay
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

		// Token: 0x17000C30 RID: 3120
		// (get) Token: 0x06006640 RID: 26176 RVA: 0x0022EEE4 File Offset: 0x0022D0E4
		public string FinishTitle
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

		// Token: 0x06006641 RID: 26177 RVA: 0x0022EF1C File Offset: 0x0022D11C
		public Span<byte> GetFinishTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06006642 RID: 26178 RVA: 0x0022EF2C File Offset: 0x0022D12C
		public byte[] GetFinishTitleArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17000C31 RID: 3121
		// (get) Token: 0x06006643 RID: 26179 RVA: 0x0022EF44 File Offset: 0x0022D144
		public string FinishDesc
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

		// Token: 0x06006644 RID: 26180 RVA: 0x0022EF7C File Offset: 0x0022D17C
		public Span<byte> GetFinishDescBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06006645 RID: 26181 RVA: 0x0022EF8C File Offset: 0x0022D18C
		public byte[] GetFinishDescArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x040051E6 RID: 20966
		private Table __p;
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BD7 RID: 3031
	public struct DangoMonopolyBoard : IFlatbufferObject
	{
		// Token: 0x17000BE3 RID: 3043
		// (get) Token: 0x0600605B RID: 24667 RVA: 0x0020F67D File Offset: 0x0020D87D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600605C RID: 24668 RVA: 0x0020F68A File Offset: 0x0020D88A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600605D RID: 24669 RVA: 0x0020F694 File Offset: 0x0020D894
		public static DangoMonopolyBoard GetRootAsDangoMonopolyBoard(ByteBuffer _bb)
		{
			return DangoMonopolyBoard.GetRootAsDangoMonopolyBoard(_bb, default(DangoMonopolyBoard));
		}

		// Token: 0x0600605E RID: 24670 RVA: 0x0020F6B0 File Offset: 0x0020D8B0
		public static DangoMonopolyBoard GetRootAsDangoMonopolyBoard(ByteBuffer _bb, DangoMonopolyBoard obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600605F RID: 24671 RVA: 0x0020F6CD File Offset: 0x0020D8CD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006060 RID: 24672 RVA: 0x0020F6DC File Offset: 0x0020D8DC
		public DangoMonopolyBoard __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000BE4 RID: 3044
		// (get) Token: 0x06006061 RID: 24673 RVA: 0x0020F6EC File Offset: 0x0020D8EC
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

		// Token: 0x17000BE5 RID: 3045
		// (get) Token: 0x06006062 RID: 24674 RVA: 0x0020F728 File Offset: 0x0020D928
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

		// Token: 0x17000BE6 RID: 3046
		// (get) Token: 0x06006063 RID: 24675 RVA: 0x0020F764 File Offset: 0x0020D964
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

		// Token: 0x17000BE7 RID: 3047
		// (get) Token: 0x06006064 RID: 24676 RVA: 0x0020F7A0 File Offset: 0x0020D9A0
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

		// Token: 0x17000BE8 RID: 3048
		// (get) Token: 0x06006065 RID: 24677 RVA: 0x0020F7E0 File Offset: 0x0020D9E0
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

		// Token: 0x17000BE9 RID: 3049
		// (get) Token: 0x06006066 RID: 24678 RVA: 0x0020F820 File Offset: 0x0020DA20
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

		// Token: 0x17000BEA RID: 3050
		// (get) Token: 0x06006067 RID: 24679 RVA: 0x0020F860 File Offset: 0x0020DA60
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

		// Token: 0x06006068 RID: 24680 RVA: 0x0020F898 File Offset: 0x0020DA98
		public Span<byte> GetFinishTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06006069 RID: 24681 RVA: 0x0020F8A8 File Offset: 0x0020DAA8
		public byte[] GetFinishTitleArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17000BEB RID: 3051
		// (get) Token: 0x0600606A RID: 24682 RVA: 0x0020F8C0 File Offset: 0x0020DAC0
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

		// Token: 0x0600606B RID: 24683 RVA: 0x0020F8F8 File Offset: 0x0020DAF8
		public Span<byte> GetFinishDescBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600606C RID: 24684 RVA: 0x0020F908 File Offset: 0x0020DB08
		public byte[] GetFinishDescArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x04004C04 RID: 19460
		private Table __p;
	}
}

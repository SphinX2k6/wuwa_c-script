using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C66 RID: 3174
	public struct FeiXuePreheat : IFlatbufferObject
	{
		// Token: 0x1700109C RID: 4252
		// (get) Token: 0x06006D74 RID: 28020 RVA: 0x0022CB8D File Offset: 0x0022AD8D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006D75 RID: 28021 RVA: 0x0022CB9A File Offset: 0x0022AD9A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006D76 RID: 28022 RVA: 0x0022CBA4 File Offset: 0x0022ADA4
		public static FeiXuePreheat GetRootAsFeiXuePreheat(ByteBuffer _bb)
		{
			return FeiXuePreheat.GetRootAsFeiXuePreheat(_bb, default(FeiXuePreheat));
		}

		// Token: 0x06006D77 RID: 28023 RVA: 0x0022CBC0 File Offset: 0x0022ADC0
		public static FeiXuePreheat GetRootAsFeiXuePreheat(ByteBuffer _bb, FeiXuePreheat obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006D78 RID: 28024 RVA: 0x0022CBDD File Offset: 0x0022ADDD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006D79 RID: 28025 RVA: 0x0022CBEC File Offset: 0x0022ADEC
		public FeiXuePreheat __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700109D RID: 4253
		// (get) Token: 0x06006D7A RID: 28026 RVA: 0x0022CBFC File Offset: 0x0022ADFC
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

		// Token: 0x1700109E RID: 4254
		// (get) Token: 0x06006D7B RID: 28027 RVA: 0x0022CC38 File Offset: 0x0022AE38
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

		// Token: 0x1700109F RID: 4255
		// (get) Token: 0x06006D7C RID: 28028 RVA: 0x0022CC74 File Offset: 0x0022AE74
		public int DropId
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

		// Token: 0x170010A0 RID: 4256
		// (get) Token: 0x06006D7D RID: 28029 RVA: 0x0022CCB0 File Offset: 0x0022AEB0
		public int QuestId
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

		// Token: 0x170010A1 RID: 4257
		// (get) Token: 0x06006D7E RID: 28030 RVA: 0x0022CCF0 File Offset: 0x0022AEF0
		public string QuestName
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

		// Token: 0x06006D7F RID: 28031 RVA: 0x0022CD28 File Offset: 0x0022AF28
		public Span<byte> GetQuestNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06006D80 RID: 28032 RVA: 0x0022CD38 File Offset: 0x0022AF38
		public byte[] GetQuestNameArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170010A2 RID: 4258
		// (get) Token: 0x06006D81 RID: 28033 RVA: 0x0022CD50 File Offset: 0x0022AF50
		public string QuestDesc
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

		// Token: 0x06006D82 RID: 28034 RVA: 0x0022CD88 File Offset: 0x0022AF88
		public Span<byte> GetQuestDescBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06006D83 RID: 28035 RVA: 0x0022CD98 File Offset: 0x0022AF98
		public byte[] GetQuestDescArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x04004CB1 RID: 19633
		private Table __p;
	}
}

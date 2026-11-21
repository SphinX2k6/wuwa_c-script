using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C66 RID: 3174
	public struct ClueEntrance : IFlatbufferObject
	{
		// Token: 0x170008B6 RID: 2230
		// (get) Token: 0x06005C18 RID: 23576 RVA: 0x00217B04 File Offset: 0x00215D04
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005C19 RID: 23577 RVA: 0x00217B11 File Offset: 0x00215D11
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005C1A RID: 23578 RVA: 0x00217B18 File Offset: 0x00215D18
		public static ClueEntrance GetRootAsClueEntrance(ByteBuffer _bb)
		{
			return ClueEntrance.GetRootAsClueEntrance(_bb, default(ClueEntrance));
		}

		// Token: 0x06005C1B RID: 23579 RVA: 0x00217B34 File Offset: 0x00215D34
		public static ClueEntrance GetRootAsClueEntrance(ByteBuffer _bb, ClueEntrance obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005C1C RID: 23580 RVA: 0x00217B51 File Offset: 0x00215D51
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005C1D RID: 23581 RVA: 0x00217B60 File Offset: 0x00215D60
		public ClueEntrance __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170008B7 RID: 2231
		// (get) Token: 0x06005C1E RID: 23582 RVA: 0x00217B70 File Offset: 0x00215D70
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

		// Token: 0x170008B8 RID: 2232
		// (get) Token: 0x06005C1F RID: 23583 RVA: 0x00217BAC File Offset: 0x00215DAC
		public int ContentGroupId
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

		// Token: 0x170008B9 RID: 2233
		// (get) Token: 0x06005C20 RID: 23584 RVA: 0x00217BE8 File Offset: 0x00215DE8
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

		// Token: 0x06005C21 RID: 23585 RVA: 0x00217C1F File Offset: 0x00215E1F
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06005C22 RID: 23586 RVA: 0x00217C2E File Offset: 0x00215E2E
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x0400516A RID: 20842
		private Table __p;
	}
}

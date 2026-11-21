using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BBB RID: 3003
	public struct AdviceConjunction : IFlatbufferObject
	{
		// Token: 0x1700023E RID: 574
		// (get) Token: 0x06004B2D RID: 19245 RVA: 0x001F1141 File Offset: 0x001EF341
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004B2E RID: 19246 RVA: 0x001F114E File Offset: 0x001EF34E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004B2F RID: 19247 RVA: 0x001F1158 File Offset: 0x001EF358
		public static AdviceConjunction GetRootAsAdviceConjunction(ByteBuffer _bb)
		{
			return AdviceConjunction.GetRootAsAdviceConjunction(_bb, default(AdviceConjunction));
		}

		// Token: 0x06004B30 RID: 19248 RVA: 0x001F1174 File Offset: 0x001EF374
		public static AdviceConjunction GetRootAsAdviceConjunction(ByteBuffer _bb, AdviceConjunction obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004B31 RID: 19249 RVA: 0x001F1191 File Offset: 0x001EF391
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004B32 RID: 19250 RVA: 0x001F11A0 File Offset: 0x001EF3A0
		public AdviceConjunction __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x06004B33 RID: 19251 RVA: 0x001F11B0 File Offset: 0x001EF3B0
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

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x06004B34 RID: 19252 RVA: 0x001F11EC File Offset: 0x001EF3EC
		public string Text
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

		// Token: 0x06004B35 RID: 19253 RVA: 0x001F1223 File Offset: 0x001EF423
		public Span<byte> GetTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06004B36 RID: 19254 RVA: 0x001F1232 File Offset: 0x001EF432
		public byte[] GetTextArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x0400509B RID: 20635
		private Table __p;
	}
}

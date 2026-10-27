using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DD9 RID: 3545
	public struct LongShanActivityConfig : IFlatbufferObject
	{
		// Token: 0x17001D54 RID: 7508
		// (get) Token: 0x06008F61 RID: 36705 RVA: 0x0027AB01 File Offset: 0x00278D01
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008F62 RID: 36706 RVA: 0x0027AB0E File Offset: 0x00278D0E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008F63 RID: 36707 RVA: 0x0027AB18 File Offset: 0x00278D18
		public static LongShanActivityConfig GetRootAsLongShanActivityConfig(ByteBuffer _bb)
		{
			return LongShanActivityConfig.GetRootAsLongShanActivityConfig(_bb, default(LongShanActivityConfig));
		}

		// Token: 0x06008F64 RID: 36708 RVA: 0x0027AB34 File Offset: 0x00278D34
		public static LongShanActivityConfig GetRootAsLongShanActivityConfig(ByteBuffer _bb, LongShanActivityConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008F65 RID: 36709 RVA: 0x0027AB51 File Offset: 0x00278D51
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008F66 RID: 36710 RVA: 0x0027AB60 File Offset: 0x00278D60
		public LongShanActivityConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001D55 RID: 7509
		// (get) Token: 0x06008F67 RID: 36711 RVA: 0x0027AB70 File Offset: 0x00278D70
		public int ActivityId
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

		// Token: 0x17001D56 RID: 7510
		// (get) Token: 0x06008F68 RID: 36712 RVA: 0x0027ABAC File Offset: 0x00278DAC
		public int Type
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04004E74 RID: 20084
		private Table __p;
	}
}

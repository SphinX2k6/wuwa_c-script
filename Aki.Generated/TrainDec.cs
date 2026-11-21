using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001285 RID: 4741
	public struct TrainDec : IFlatbufferObject
	{
		// Token: 0x17003EBB RID: 16059
		// (get) Token: 0x0600EEB0 RID: 61104 RVA: 0x0035EA4B File Offset: 0x0035CC4B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600EEB1 RID: 61105 RVA: 0x0035EA58 File Offset: 0x0035CC58
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600EEB2 RID: 61106 RVA: 0x0035EA60 File Offset: 0x0035CC60
		public static TrainDec GetRootAsTrainDec(ByteBuffer _bb)
		{
			return TrainDec.GetRootAsTrainDec(_bb, default(TrainDec));
		}

		// Token: 0x0600EEB3 RID: 61107 RVA: 0x0035EA7C File Offset: 0x0035CC7C
		public static TrainDec GetRootAsTrainDec(ByteBuffer _bb, TrainDec obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600EEB4 RID: 61108 RVA: 0x0035EA99 File Offset: 0x0035CC99
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600EEB5 RID: 61109 RVA: 0x0035EAA8 File Offset: 0x0035CCA8
		public TrainDec __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003EBC RID: 16060
		// (get) Token: 0x0600EEB6 RID: 61110 RVA: 0x0035EAB8 File Offset: 0x0035CCB8
		public int RoleLevel
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

		// Token: 0x040058D7 RID: 22743
		private Table __p;
	}
}

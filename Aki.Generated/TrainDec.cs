using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200114F RID: 4431
	public struct TrainDec : IFlatbufferObject
	{
		// Token: 0x17003B57 RID: 15191
		// (get) Token: 0x0600E142 RID: 57666 RVA: 0x0033369B File Offset: 0x0033189B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E143 RID: 57667 RVA: 0x003336A8 File Offset: 0x003318A8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E144 RID: 57668 RVA: 0x003336B0 File Offset: 0x003318B0
		public static TrainDec GetRootAsTrainDec(ByteBuffer _bb)
		{
			return TrainDec.GetRootAsTrainDec(_bb, default(TrainDec));
		}

		// Token: 0x0600E145 RID: 57669 RVA: 0x003336CC File Offset: 0x003318CC
		public static TrainDec GetRootAsTrainDec(ByteBuffer _bb, TrainDec obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E146 RID: 57670 RVA: 0x003336E9 File Offset: 0x003318E9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E147 RID: 57671 RVA: 0x003336F8 File Offset: 0x003318F8
		public TrainDec __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003B58 RID: 15192
		// (get) Token: 0x0600E148 RID: 57672 RVA: 0x00333708 File Offset: 0x00331908
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

		// Token: 0x04005294 RID: 21140
		private Table __p;
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020012EF RID: 4847
	public struct DicIntIntIntMap : IFlatbufferObject
	{
		// Token: 0x1700422B RID: 16939
		// (get) Token: 0x0600F77E RID: 63358 RVA: 0x003722A1 File Offset: 0x003704A1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F77F RID: 63359 RVA: 0x003722AE File Offset: 0x003704AE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F780 RID: 63360 RVA: 0x003722B8 File Offset: 0x003704B8
		public static DicIntIntIntMap GetRootAsDicIntIntIntMap(ByteBuffer _bb)
		{
			return DicIntIntIntMap.GetRootAsDicIntIntIntMap(_bb, default(DicIntIntIntMap));
		}

		// Token: 0x0600F781 RID: 63361 RVA: 0x003722D4 File Offset: 0x003704D4
		public static DicIntIntIntMap GetRootAsDicIntIntIntMap(ByteBuffer _bb, DicIntIntIntMap obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F782 RID: 63362 RVA: 0x003722F1 File Offset: 0x003704F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F783 RID: 63363 RVA: 0x00372300 File Offset: 0x00370500
		public DicIntIntIntMap __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700422C RID: 16940
		// (get) Token: 0x0600F784 RID: 63364 RVA: 0x00372310 File Offset: 0x00370510
		public int Key
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

		// Token: 0x1700422D RID: 16941
		// (get) Token: 0x0600F785 RID: 63365 RVA: 0x0037234C File Offset: 0x0037054C
		public IntIntMap? Value
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IntIntMap?(default(IntIntMap).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0400594D RID: 22861
		private Table __p;
	}
}

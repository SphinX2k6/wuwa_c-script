using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011B9 RID: 4537
	public struct DicIntIntIntMap : IFlatbufferObject
	{
		// Token: 0x17003EC6 RID: 16070
		// (get) Token: 0x0600EA0D RID: 59917 RVA: 0x00347615 File Offset: 0x00345815
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600EA0E RID: 59918 RVA: 0x00347622 File Offset: 0x00345822
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600EA0F RID: 59919 RVA: 0x0034762C File Offset: 0x0034582C
		public static DicIntIntIntMap GetRootAsDicIntIntIntMap(ByteBuffer _bb)
		{
			return DicIntIntIntMap.GetRootAsDicIntIntIntMap(_bb, default(DicIntIntIntMap));
		}

		// Token: 0x0600EA10 RID: 59920 RVA: 0x00347648 File Offset: 0x00345848
		public static DicIntIntIntMap GetRootAsDicIntIntIntMap(ByteBuffer _bb, DicIntIntIntMap obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600EA11 RID: 59921 RVA: 0x00347665 File Offset: 0x00345865
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600EA12 RID: 59922 RVA: 0x00347674 File Offset: 0x00345874
		public DicIntIntIntMap __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003EC7 RID: 16071
		// (get) Token: 0x0600EA13 RID: 59923 RVA: 0x00347684 File Offset: 0x00345884
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

		// Token: 0x17003EC8 RID: 16072
		// (get) Token: 0x0600EA14 RID: 59924 RVA: 0x003476C0 File Offset: 0x003458C0
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

		// Token: 0x0400530A RID: 21258
		private Table __p;
	}
}

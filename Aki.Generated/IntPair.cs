using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011CE RID: 4558
	public struct IntPair : IFlatbufferObject
	{
		// Token: 0x17003EF0 RID: 16112
		// (get) Token: 0x0600EAA1 RID: 60065 RVA: 0x003486DC File Offset: 0x003468DC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600EAA2 RID: 60066 RVA: 0x003486E9 File Offset: 0x003468E9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600EAA3 RID: 60067 RVA: 0x003486F0 File Offset: 0x003468F0
		public static IntPair GetRootAsIntPair(ByteBuffer _bb)
		{
			return IntPair.GetRootAsIntPair(_bb, default(IntPair));
		}

		// Token: 0x0600EAA4 RID: 60068 RVA: 0x0034870C File Offset: 0x0034690C
		public static IntPair GetRootAsIntPair(ByteBuffer _bb, IntPair obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600EAA5 RID: 60069 RVA: 0x00348729 File Offset: 0x00346929
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600EAA6 RID: 60070 RVA: 0x00348738 File Offset: 0x00346938
		public IntPair __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003EF1 RID: 16113
		// (get) Token: 0x0600EAA7 RID: 60071 RVA: 0x00348748 File Offset: 0x00346948
		public int Item1
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

		// Token: 0x17003EF2 RID: 16114
		// (get) Token: 0x0600EAA8 RID: 60072 RVA: 0x00348784 File Offset: 0x00346984
		public int Item2
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

		// Token: 0x0400533C RID: 21308
		private Table __p;
	}
}

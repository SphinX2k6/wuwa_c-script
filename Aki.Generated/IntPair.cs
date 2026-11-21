using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001304 RID: 4868
	public struct IntPair : IFlatbufferObject
	{
		// Token: 0x17004255 RID: 16981
		// (get) Token: 0x0600F812 RID: 63506 RVA: 0x00373328 File Offset: 0x00371528
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F813 RID: 63507 RVA: 0x00373335 File Offset: 0x00371535
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F814 RID: 63508 RVA: 0x0037333C File Offset: 0x0037153C
		public static IntPair GetRootAsIntPair(ByteBuffer _bb)
		{
			return IntPair.GetRootAsIntPair(_bb, default(IntPair));
		}

		// Token: 0x0600F815 RID: 63509 RVA: 0x00373358 File Offset: 0x00371558
		public static IntPair GetRootAsIntPair(ByteBuffer _bb, IntPair obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F816 RID: 63510 RVA: 0x00373375 File Offset: 0x00371575
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F817 RID: 63511 RVA: 0x00373384 File Offset: 0x00371584
		public IntPair __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17004256 RID: 16982
		// (get) Token: 0x0600F818 RID: 63512 RVA: 0x00373394 File Offset: 0x00371594
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

		// Token: 0x17004257 RID: 16983
		// (get) Token: 0x0600F819 RID: 63513 RVA: 0x003733D0 File Offset: 0x003715D0
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

		// Token: 0x0400597F RID: 22911
		private Table __p;
	}
}

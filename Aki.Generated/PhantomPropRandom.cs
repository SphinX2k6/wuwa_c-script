using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200130D RID: 4877
	public struct PhantomPropRandom : IFlatbufferObject
	{
		// Token: 0x17004273 RID: 17011
		// (get) Token: 0x0600F867 RID: 63591 RVA: 0x00373D05 File Offset: 0x00371F05
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F868 RID: 63592 RVA: 0x00373D12 File Offset: 0x00371F12
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F869 RID: 63593 RVA: 0x00373D1C File Offset: 0x00371F1C
		public static PhantomPropRandom GetRootAsPhantomPropRandom(ByteBuffer _bb)
		{
			return PhantomPropRandom.GetRootAsPhantomPropRandom(_bb, default(PhantomPropRandom));
		}

		// Token: 0x0600F86A RID: 63594 RVA: 0x00373D38 File Offset: 0x00371F38
		public static PhantomPropRandom GetRootAsPhantomPropRandom(ByteBuffer _bb, PhantomPropRandom obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F86B RID: 63595 RVA: 0x00373D55 File Offset: 0x00371F55
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F86C RID: 63596 RVA: 0x00373D64 File Offset: 0x00371F64
		public PhantomPropRandom __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17004274 RID: 17012
		// (get) Token: 0x0600F86D RID: 63597 RVA: 0x00373D74 File Offset: 0x00371F74
		public int RandGroupId
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

		// Token: 0x17004275 RID: 17013
		// (get) Token: 0x0600F86E RID: 63598 RVA: 0x00373DB0 File Offset: 0x00371FB0
		public int RandNum
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

		// Token: 0x04005988 RID: 22920
		private Table __p;
	}
}

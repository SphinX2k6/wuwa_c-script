using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D17 RID: 3351
	public struct GuideDungeonTypeSet : IFlatbufferObject
	{
		// Token: 0x17001651 RID: 5713
		// (get) Token: 0x06007C8E RID: 31886 RVA: 0x0024FBE5 File Offset: 0x0024DDE5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007C8F RID: 31887 RVA: 0x0024FBF2 File Offset: 0x0024DDF2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007C90 RID: 31888 RVA: 0x0024FBFC File Offset: 0x0024DDFC
		public static GuideDungeonTypeSet GetRootAsGuideDungeonTypeSet(ByteBuffer _bb)
		{
			return GuideDungeonTypeSet.GetRootAsGuideDungeonTypeSet(_bb, default(GuideDungeonTypeSet));
		}

		// Token: 0x06007C91 RID: 31889 RVA: 0x0024FC18 File Offset: 0x0024DE18
		public static GuideDungeonTypeSet GetRootAsGuideDungeonTypeSet(ByteBuffer _bb, GuideDungeonTypeSet obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007C92 RID: 31890 RVA: 0x0024FC35 File Offset: 0x0024DE35
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007C93 RID: 31891 RVA: 0x0024FC44 File Offset: 0x0024DE44
		public GuideDungeonTypeSet __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001652 RID: 5714
		// (get) Token: 0x06007C94 RID: 31892 RVA: 0x0024FC54 File Offset: 0x0024DE54
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

		// Token: 0x17001653 RID: 5715
		// (get) Token: 0x06007C95 RID: 31893 RVA: 0x0024FC90 File Offset: 0x0024DE90
		public int InstType
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

		// Token: 0x17001654 RID: 5716
		// (get) Token: 0x06007C96 RID: 31894 RVA: 0x0024FCCC File Offset: 0x0024DECC
		public int InstSubType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04004D8F RID: 19855
		private Table __p;
	}
}

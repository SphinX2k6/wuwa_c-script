using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B08 RID: 2824
	public struct AreaTaskExplore : IFlatbufferObject
	{
		// Token: 0x17000350 RID: 848
		// (get) Token: 0x060048DB RID: 18651 RVA: 0x001D85B4 File Offset: 0x001D67B4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060048DC RID: 18652 RVA: 0x001D85C1 File Offset: 0x001D67C1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060048DD RID: 18653 RVA: 0x001D85C8 File Offset: 0x001D67C8
		public static AreaTaskExplore GetRootAsAreaTaskExplore(ByteBuffer _bb)
		{
			return AreaTaskExplore.GetRootAsAreaTaskExplore(_bb, default(AreaTaskExplore));
		}

		// Token: 0x060048DE RID: 18654 RVA: 0x001D85E4 File Offset: 0x001D67E4
		public static AreaTaskExplore GetRootAsAreaTaskExplore(ByteBuffer _bb, AreaTaskExplore obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060048DF RID: 18655 RVA: 0x001D8601 File Offset: 0x001D6801
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060048E0 RID: 18656 RVA: 0x001D8610 File Offset: 0x001D6810
		public AreaTaskExplore __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000351 RID: 849
		// (get) Token: 0x060048E1 RID: 18657 RVA: 0x001D8620 File Offset: 0x001D6820
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

		// Token: 0x17000352 RID: 850
		// (get) Token: 0x060048E2 RID: 18658 RVA: 0x001D865C File Offset: 0x001D685C
		public int Area
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

		// Token: 0x17000353 RID: 851
		// (get) Token: 0x060048E3 RID: 18659 RVA: 0x001D8698 File Offset: 0x001D6898
		public int SortIndex
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

		// Token: 0x04004AED RID: 19181
		private Table __p;
	}
}

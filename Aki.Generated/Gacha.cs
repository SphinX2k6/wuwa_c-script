using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CDC RID: 3292
	public struct Gacha : IFlatbufferObject
	{
		// Token: 0x17001490 RID: 5264
		// (get) Token: 0x060077E9 RID: 30697 RVA: 0x002456A4 File Offset: 0x002438A4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060077EA RID: 30698 RVA: 0x002456B1 File Offset: 0x002438B1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060077EB RID: 30699 RVA: 0x002456B8 File Offset: 0x002438B8
		public static Gacha GetRootAsGacha(ByteBuffer _bb)
		{
			return Gacha.GetRootAsGacha(_bb, default(Gacha));
		}

		// Token: 0x060077EC RID: 30700 RVA: 0x002456D4 File Offset: 0x002438D4
		public static Gacha GetRootAsGacha(ByteBuffer _bb, Gacha obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060077ED RID: 30701 RVA: 0x002456F1 File Offset: 0x002438F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060077EE RID: 30702 RVA: 0x00245700 File Offset: 0x00243900
		public Gacha __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001491 RID: 5265
		// (get) Token: 0x060077EF RID: 30703 RVA: 0x00245710 File Offset: 0x00243910
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

		// Token: 0x17001492 RID: 5266
		// (get) Token: 0x060077F0 RID: 30704 RVA: 0x0024574C File Offset: 0x0024394C
		public int RuleGroupId
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

		// Token: 0x17001493 RID: 5267
		// (get) Token: 0x060077F1 RID: 30705 RVA: 0x00245788 File Offset: 0x00243988
		public int Sort
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 10;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04004D4D RID: 19789
		private Table __p;
	}
}

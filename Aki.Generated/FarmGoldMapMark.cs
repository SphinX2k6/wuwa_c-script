using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D40 RID: 3392
	public struct FarmGoldMapMark : IFlatbufferObject
	{
		// Token: 0x170010AA RID: 4266
		// (get) Token: 0x060072AE RID: 29358 RVA: 0x0024A460 File Offset: 0x00248660
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060072AF RID: 29359 RVA: 0x0024A46D File Offset: 0x0024866D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060072B0 RID: 29360 RVA: 0x0024A474 File Offset: 0x00248674
		public static FarmGoldMapMark GetRootAsFarmGoldMapMark(ByteBuffer _bb)
		{
			return FarmGoldMapMark.GetRootAsFarmGoldMapMark(_bb, default(FarmGoldMapMark));
		}

		// Token: 0x060072B1 RID: 29361 RVA: 0x0024A490 File Offset: 0x00248690
		public static FarmGoldMapMark GetRootAsFarmGoldMapMark(ByteBuffer _bb, FarmGoldMapMark obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060072B2 RID: 29362 RVA: 0x0024A4AD File Offset: 0x002486AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060072B3 RID: 29363 RVA: 0x0024A4BC File Offset: 0x002486BC
		public FarmGoldMapMark __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170010AB RID: 4267
		// (get) Token: 0x060072B4 RID: 29364 RVA: 0x0024A4CC File Offset: 0x002486CC
		public int ActivityId
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

		// Token: 0x170010AC RID: 4268
		// (get) Token: 0x060072B5 RID: 29365 RVA: 0x0024A508 File Offset: 0x00248708
		public int MarkId
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

		// Token: 0x170010AD RID: 4269
		// (get) Token: 0x060072B6 RID: 29366 RVA: 0x0024A544 File Offset: 0x00248744
		public int EntranceId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 8720;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0400528B RID: 21131
		private Table __p;
	}
}

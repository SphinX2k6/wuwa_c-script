using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C5C RID: 3164
	public struct FarmGoldMapMark : IFlatbufferObject
	{
		// Token: 0x1700104D RID: 4173
		// (get) Token: 0x06006CA3 RID: 27811 RVA: 0x0022B110 File Offset: 0x00229310
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006CA4 RID: 27812 RVA: 0x0022B11D File Offset: 0x0022931D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006CA5 RID: 27813 RVA: 0x0022B124 File Offset: 0x00229324
		public static FarmGoldMapMark GetRootAsFarmGoldMapMark(ByteBuffer _bb)
		{
			return FarmGoldMapMark.GetRootAsFarmGoldMapMark(_bb, default(FarmGoldMapMark));
		}

		// Token: 0x06006CA6 RID: 27814 RVA: 0x0022B140 File Offset: 0x00229340
		public static FarmGoldMapMark GetRootAsFarmGoldMapMark(ByteBuffer _bb, FarmGoldMapMark obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006CA7 RID: 27815 RVA: 0x0022B15D File Offset: 0x0022935D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006CA8 RID: 27816 RVA: 0x0022B16C File Offset: 0x0022936C
		public FarmGoldMapMark __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700104E RID: 4174
		// (get) Token: 0x06006CA9 RID: 27817 RVA: 0x0022B17C File Offset: 0x0022937C
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

		// Token: 0x1700104F RID: 4175
		// (get) Token: 0x06006CAA RID: 27818 RVA: 0x0022B1B8 File Offset: 0x002293B8
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

		// Token: 0x17001050 RID: 4176
		// (get) Token: 0x06006CAB RID: 27819 RVA: 0x0022B1F4 File Offset: 0x002293F4
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

		// Token: 0x04004CA7 RID: 19623
		private Table __p;
	}
}

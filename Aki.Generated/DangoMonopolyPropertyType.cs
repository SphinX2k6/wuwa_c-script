using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BDC RID: 3036
	public struct DangoMonopolyPropertyType : IFlatbufferObject
	{
		// Token: 0x17000BFF RID: 3071
		// (get) Token: 0x060060A2 RID: 24738 RVA: 0x0020FFCD File Offset: 0x0020E1CD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060060A3 RID: 24739 RVA: 0x0020FFDA File Offset: 0x0020E1DA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060060A4 RID: 24740 RVA: 0x0020FFE4 File Offset: 0x0020E1E4
		public static DangoMonopolyPropertyType GetRootAsDangoMonopolyPropertyType(ByteBuffer _bb)
		{
			return DangoMonopolyPropertyType.GetRootAsDangoMonopolyPropertyType(_bb, default(DangoMonopolyPropertyType));
		}

		// Token: 0x060060A5 RID: 24741 RVA: 0x00210000 File Offset: 0x0020E200
		public static DangoMonopolyPropertyType GetRootAsDangoMonopolyPropertyType(ByteBuffer _bb, DangoMonopolyPropertyType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060060A6 RID: 24742 RVA: 0x0021001D File Offset: 0x0020E21D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060060A7 RID: 24743 RVA: 0x0021002C File Offset: 0x0020E22C
		public DangoMonopolyPropertyType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000C00 RID: 3072
		// (get) Token: 0x060060A8 RID: 24744 RVA: 0x0021003C File Offset: 0x0020E23C
		public int PropertyType
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

		// Token: 0x17000C01 RID: 3073
		// (get) Token: 0x060060A9 RID: 24745 RVA: 0x00210078 File Offset: 0x0020E278
		public int TriggerType
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

		// Token: 0x04004C09 RID: 19465
		private Table __p;
	}
}

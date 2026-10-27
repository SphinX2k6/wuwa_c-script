using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B1E RID: 2846
	public struct BabelTowerDeEffect : IFlatbufferObject
	{
		// Token: 0x170003F3 RID: 1011
		// (get) Token: 0x06004AB6 RID: 19126 RVA: 0x001DCC69 File Offset: 0x001DAE69
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004AB7 RID: 19127 RVA: 0x001DCC76 File Offset: 0x001DAE76
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004AB8 RID: 19128 RVA: 0x001DCC80 File Offset: 0x001DAE80
		public static BabelTowerDeEffect GetRootAsBabelTowerDeEffect(ByteBuffer _bb)
		{
			return BabelTowerDeEffect.GetRootAsBabelTowerDeEffect(_bb, default(BabelTowerDeEffect));
		}

		// Token: 0x06004AB9 RID: 19129 RVA: 0x001DCC9C File Offset: 0x001DAE9C
		public static BabelTowerDeEffect GetRootAsBabelTowerDeEffect(ByteBuffer _bb, BabelTowerDeEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004ABA RID: 19130 RVA: 0x001DCCB9 File Offset: 0x001DAEB9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004ABB RID: 19131 RVA: 0x001DCCC8 File Offset: 0x001DAEC8
		public BabelTowerDeEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170003F4 RID: 1012
		// (get) Token: 0x06004ABC RID: 19132 RVA: 0x001DCCD8 File Offset: 0x001DAED8
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

		// Token: 0x04004B0E RID: 19214
		private Table __p;
	}
}

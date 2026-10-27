using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AFE RID: 2814
	public struct AnniversaryConfig : IFlatbufferObject
	{
		// Token: 0x17000305 RID: 773
		// (get) Token: 0x06004811 RID: 18449 RVA: 0x001D6758 File Offset: 0x001D4958
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004812 RID: 18450 RVA: 0x001D6765 File Offset: 0x001D4965
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004813 RID: 18451 RVA: 0x001D676C File Offset: 0x001D496C
		public static AnniversaryConfig GetRootAsAnniversaryConfig(ByteBuffer _bb)
		{
			return AnniversaryConfig.GetRootAsAnniversaryConfig(_bb, default(AnniversaryConfig));
		}

		// Token: 0x06004814 RID: 18452 RVA: 0x001D6788 File Offset: 0x001D4988
		public static AnniversaryConfig GetRootAsAnniversaryConfig(ByteBuffer _bb, AnniversaryConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004815 RID: 18453 RVA: 0x001D67A5 File Offset: 0x001D49A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004816 RID: 18454 RVA: 0x001D67B4 File Offset: 0x001D49B4
		public AnniversaryConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x06004817 RID: 18455 RVA: 0x001D67C4 File Offset: 0x001D49C4
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

		// Token: 0x04004ADF RID: 19167
		private Table __p;
	}
}

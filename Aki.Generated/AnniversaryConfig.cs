using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BD8 RID: 3032
	public struct AnniversaryConfig : IFlatbufferObject
	{
		// Token: 0x1700031C RID: 796
		// (get) Token: 0x06004D58 RID: 19800 RVA: 0x001F5FE0 File Offset: 0x001F41E0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004D59 RID: 19801 RVA: 0x001F5FED File Offset: 0x001F41ED
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004D5A RID: 19802 RVA: 0x001F5FF4 File Offset: 0x001F41F4
		public static AnniversaryConfig GetRootAsAnniversaryConfig(ByteBuffer _bb)
		{
			return AnniversaryConfig.GetRootAsAnniversaryConfig(_bb, default(AnniversaryConfig));
		}

		// Token: 0x06004D5B RID: 19803 RVA: 0x001F6010 File Offset: 0x001F4210
		public static AnniversaryConfig GetRootAsAnniversaryConfig(ByteBuffer _bb, AnniversaryConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004D5C RID: 19804 RVA: 0x001F602D File Offset: 0x001F422D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004D5D RID: 19805 RVA: 0x001F603C File Offset: 0x001F423C
		public AnniversaryConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x06004D5E RID: 19806 RVA: 0x001F604C File Offset: 0x001F424C
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

		// Token: 0x040050B9 RID: 20665
		private Table __p;
	}
}

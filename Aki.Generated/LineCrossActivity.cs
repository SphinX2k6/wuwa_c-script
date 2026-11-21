using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EAE RID: 3758
	public struct LineCrossActivity : IFlatbufferObject
	{
		// Token: 0x17001D4B RID: 7499
		// (get) Token: 0x06009429 RID: 37929 RVA: 0x00295F7D File Offset: 0x0029417D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600942A RID: 37930 RVA: 0x00295F8A File Offset: 0x0029418A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600942B RID: 37931 RVA: 0x00295F94 File Offset: 0x00294194
		public static LineCrossActivity GetRootAsLineCrossActivity(ByteBuffer _bb)
		{
			return LineCrossActivity.GetRootAsLineCrossActivity(_bb, default(LineCrossActivity));
		}

		// Token: 0x0600942C RID: 37932 RVA: 0x00295FB0 File Offset: 0x002941B0
		public static LineCrossActivity GetRootAsLineCrossActivity(ByteBuffer _bb, LineCrossActivity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600942D RID: 37933 RVA: 0x00295FCD File Offset: 0x002941CD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600942E RID: 37934 RVA: 0x00295FDC File Offset: 0x002941DC
		public LineCrossActivity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001D4C RID: 7500
		// (get) Token: 0x0600942F RID: 37935 RVA: 0x00295FEC File Offset: 0x002941EC
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

		// Token: 0x17001D4D RID: 7501
		// (get) Token: 0x06009430 RID: 37936 RVA: 0x00296028 File Offset: 0x00294228
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

		// Token: 0x04005444 RID: 21572
		private Table __p;
	}
}

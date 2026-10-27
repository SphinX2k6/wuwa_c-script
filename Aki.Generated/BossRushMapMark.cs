using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B46 RID: 2886
	public struct BossRushMapMark : IFlatbufferObject
	{
		// Token: 0x170005D5 RID: 1493
		// (get) Token: 0x06004F37 RID: 20279 RVA: 0x001E7C80 File Offset: 0x001E5E80
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004F38 RID: 20280 RVA: 0x001E7C8D File Offset: 0x001E5E8D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004F39 RID: 20281 RVA: 0x001E7C94 File Offset: 0x001E5E94
		public static BossRushMapMark GetRootAsBossRushMapMark(ByteBuffer _bb)
		{
			return BossRushMapMark.GetRootAsBossRushMapMark(_bb, default(BossRushMapMark));
		}

		// Token: 0x06004F3A RID: 20282 RVA: 0x001E7CB0 File Offset: 0x001E5EB0
		public static BossRushMapMark GetRootAsBossRushMapMark(ByteBuffer _bb, BossRushMapMark obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004F3B RID: 20283 RVA: 0x001E7CCD File Offset: 0x001E5ECD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004F3C RID: 20284 RVA: 0x001E7CDC File Offset: 0x001E5EDC
		public BossRushMapMark __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170005D6 RID: 1494
		// (get) Token: 0x06004F3D RID: 20285 RVA: 0x001E7CEC File Offset: 0x001E5EEC
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

		// Token: 0x170005D7 RID: 1495
		// (get) Token: 0x06004F3E RID: 20286 RVA: 0x001E7D28 File Offset: 0x001E5F28
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

		// Token: 0x04004B41 RID: 19265
		private Table __p;
	}
}

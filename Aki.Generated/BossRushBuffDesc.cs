using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B45 RID: 2885
	public struct BossRushBuffDesc : IFlatbufferObject
	{
		// Token: 0x170005D2 RID: 1490
		// (get) Token: 0x06004F2F RID: 20271 RVA: 0x001E7B99 File Offset: 0x001E5D99
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004F30 RID: 20272 RVA: 0x001E7BA6 File Offset: 0x001E5DA6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004F31 RID: 20273 RVA: 0x001E7BB0 File Offset: 0x001E5DB0
		public static BossRushBuffDesc GetRootAsBossRushBuffDesc(ByteBuffer _bb)
		{
			return BossRushBuffDesc.GetRootAsBossRushBuffDesc(_bb, default(BossRushBuffDesc));
		}

		// Token: 0x06004F32 RID: 20274 RVA: 0x001E7BCC File Offset: 0x001E5DCC
		public static BossRushBuffDesc GetRootAsBossRushBuffDesc(ByteBuffer _bb, BossRushBuffDesc obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004F33 RID: 20275 RVA: 0x001E7BE9 File Offset: 0x001E5DE9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004F34 RID: 20276 RVA: 0x001E7BF8 File Offset: 0x001E5DF8
		public BossRushBuffDesc __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170005D3 RID: 1491
		// (get) Token: 0x06004F35 RID: 20277 RVA: 0x001E7C08 File Offset: 0x001E5E08
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

		// Token: 0x170005D4 RID: 1492
		// (get) Token: 0x06004F36 RID: 20278 RVA: 0x001E7C44 File Offset: 0x001E5E44
		public int SoundAreaInfoConfigId
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

		// Token: 0x04004B40 RID: 19264
		private Table __p;
	}
}

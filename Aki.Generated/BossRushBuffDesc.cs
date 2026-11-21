using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C25 RID: 3109
	public struct BossRushBuffDesc : IFlatbufferObject
	{
		// Token: 0x17000612 RID: 1554
		// (get) Token: 0x060054F1 RID: 21745 RVA: 0x00207D1B File Offset: 0x00205F1B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060054F2 RID: 21746 RVA: 0x00207D28 File Offset: 0x00205F28
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060054F3 RID: 21747 RVA: 0x00207D30 File Offset: 0x00205F30
		public static BossRushBuffDesc GetRootAsBossRushBuffDesc(ByteBuffer _bb)
		{
			return BossRushBuffDesc.GetRootAsBossRushBuffDesc(_bb, default(BossRushBuffDesc));
		}

		// Token: 0x060054F4 RID: 21748 RVA: 0x00207D4C File Offset: 0x00205F4C
		public static BossRushBuffDesc GetRootAsBossRushBuffDesc(ByteBuffer _bb, BossRushBuffDesc obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060054F5 RID: 21749 RVA: 0x00207D69 File Offset: 0x00205F69
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060054F6 RID: 21750 RVA: 0x00207D78 File Offset: 0x00205F78
		public BossRushBuffDesc __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000613 RID: 1555
		// (get) Token: 0x060054F7 RID: 21751 RVA: 0x00207D88 File Offset: 0x00205F88
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

		// Token: 0x17000614 RID: 1556
		// (get) Token: 0x060054F8 RID: 21752 RVA: 0x00207DC4 File Offset: 0x00205FC4
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

		// Token: 0x04005120 RID: 20768
		private Table __p;
	}
}

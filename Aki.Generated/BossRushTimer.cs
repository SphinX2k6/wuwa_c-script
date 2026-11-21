using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C2A RID: 3114
	public struct BossRushTimer : IFlatbufferObject
	{
		// Token: 0x17000627 RID: 1575
		// (get) Token: 0x06005525 RID: 21797 RVA: 0x00208368 File Offset: 0x00206568
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005526 RID: 21798 RVA: 0x00208375 File Offset: 0x00206575
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005527 RID: 21799 RVA: 0x0020837C File Offset: 0x0020657C
		public static BossRushTimer GetRootAsBossRushTimer(ByteBuffer _bb)
		{
			return BossRushTimer.GetRootAsBossRushTimer(_bb, default(BossRushTimer));
		}

		// Token: 0x06005528 RID: 21800 RVA: 0x00208398 File Offset: 0x00206598
		public static BossRushTimer GetRootAsBossRushTimer(ByteBuffer _bb, BossRushTimer obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005529 RID: 21801 RVA: 0x002083B5 File Offset: 0x002065B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600552A RID: 21802 RVA: 0x002083C4 File Offset: 0x002065C4
		public BossRushTimer __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000628 RID: 1576
		// (get) Token: 0x0600552B RID: 21803 RVA: 0x002083D4 File Offset: 0x002065D4
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

		// Token: 0x04005125 RID: 20773
		private Table __p;
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000ED2 RID: 3794
	public struct PhantomBattleGuide : IFlatbufferObject
	{
		// Token: 0x17002647 RID: 9799
		// (get) Token: 0x0600A73B RID: 42811 RVA: 0x002B02ED File Offset: 0x002AE4ED
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A73C RID: 42812 RVA: 0x002B02FA File Offset: 0x002AE4FA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A73D RID: 42813 RVA: 0x002B0304 File Offset: 0x002AE504
		public static PhantomBattleGuide GetRootAsPhantomBattleGuide(ByteBuffer _bb)
		{
			return PhantomBattleGuide.GetRootAsPhantomBattleGuide(_bb, default(PhantomBattleGuide));
		}

		// Token: 0x0600A73E RID: 42814 RVA: 0x002B0320 File Offset: 0x002AE520
		public static PhantomBattleGuide GetRootAsPhantomBattleGuide(ByteBuffer _bb, PhantomBattleGuide obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A73F RID: 42815 RVA: 0x002B033D File Offset: 0x002AE53D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A740 RID: 42816 RVA: 0x002B034C File Offset: 0x002AE54C
		public PhantomBattleGuide __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002648 RID: 9800
		// (get) Token: 0x0600A741 RID: 42817 RVA: 0x002B035C File Offset: 0x002AE55C
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

		// Token: 0x04004F90 RID: 20368
		private Table __p;
	}
}

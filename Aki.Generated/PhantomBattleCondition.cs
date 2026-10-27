using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000ECA RID: 3786
	public struct PhantomBattleCondition : IFlatbufferObject
	{
		// Token: 0x1700261D RID: 9757
		// (get) Token: 0x0600A6C2 RID: 42690 RVA: 0x002AF3D6 File Offset: 0x002AD5D6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A6C3 RID: 42691 RVA: 0x002AF3E3 File Offset: 0x002AD5E3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A6C4 RID: 42692 RVA: 0x002AF3EC File Offset: 0x002AD5EC
		public static PhantomBattleCondition GetRootAsPhantomBattleCondition(ByteBuffer _bb)
		{
			return PhantomBattleCondition.GetRootAsPhantomBattleCondition(_bb, default(PhantomBattleCondition));
		}

		// Token: 0x0600A6C5 RID: 42693 RVA: 0x002AF408 File Offset: 0x002AD608
		public static PhantomBattleCondition GetRootAsPhantomBattleCondition(ByteBuffer _bb, PhantomBattleCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A6C6 RID: 42694 RVA: 0x002AF425 File Offset: 0x002AD625
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A6C7 RID: 42695 RVA: 0x002AF434 File Offset: 0x002AD634
		public PhantomBattleCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700261E RID: 9758
		// (get) Token: 0x0600A6C8 RID: 42696 RVA: 0x002AF444 File Offset: 0x002AD644
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

		// Token: 0x04004F88 RID: 20360
		private Table __p;
	}
}

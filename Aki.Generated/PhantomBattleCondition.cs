using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FAF RID: 4015
	public struct PhantomBattleCondition : IFlatbufferObject
	{
		// Token: 0x17002683 RID: 9859
		// (get) Token: 0x0600ACE3 RID: 44259 RVA: 0x002CC516 File Offset: 0x002CA716
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600ACE4 RID: 44260 RVA: 0x002CC523 File Offset: 0x002CA723
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600ACE5 RID: 44261 RVA: 0x002CC52C File Offset: 0x002CA72C
		public static PhantomBattleCondition GetRootAsPhantomBattleCondition(ByteBuffer _bb)
		{
			return PhantomBattleCondition.GetRootAsPhantomBattleCondition(_bb, default(PhantomBattleCondition));
		}

		// Token: 0x0600ACE6 RID: 44262 RVA: 0x002CC548 File Offset: 0x002CA748
		public static PhantomBattleCondition GetRootAsPhantomBattleCondition(ByteBuffer _bb, PhantomBattleCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600ACE7 RID: 44263 RVA: 0x002CC565 File Offset: 0x002CA765
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600ACE8 RID: 44264 RVA: 0x002CC574 File Offset: 0x002CA774
		public PhantomBattleCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002684 RID: 9860
		// (get) Token: 0x0600ACE9 RID: 44265 RVA: 0x002CC584 File Offset: 0x002CA784
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

		// Token: 0x0400556D RID: 21869
		private Table __p;
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FBF RID: 4031
	public struct PhantomBattleRecordGroup : IFlatbufferObject
	{
		// Token: 0x170026E1 RID: 9953
		// (get) Token: 0x0600ADDE RID: 44510 RVA: 0x002CE4CC File Offset: 0x002CC6CC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600ADDF RID: 44511 RVA: 0x002CE4D9 File Offset: 0x002CC6D9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600ADE0 RID: 44512 RVA: 0x002CE4E0 File Offset: 0x002CC6E0
		public static PhantomBattleRecordGroup GetRootAsPhantomBattleRecordGroup(ByteBuffer _bb)
		{
			return PhantomBattleRecordGroup.GetRootAsPhantomBattleRecordGroup(_bb, default(PhantomBattleRecordGroup));
		}

		// Token: 0x0600ADE1 RID: 44513 RVA: 0x002CE4FC File Offset: 0x002CC6FC
		public static PhantomBattleRecordGroup GetRootAsPhantomBattleRecordGroup(ByteBuffer _bb, PhantomBattleRecordGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600ADE2 RID: 44514 RVA: 0x002CE519 File Offset: 0x002CC719
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600ADE3 RID: 44515 RVA: 0x002CE528 File Offset: 0x002CC728
		public PhantomBattleRecordGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170026E2 RID: 9954
		// (get) Token: 0x0600ADE4 RID: 44516 RVA: 0x002CE538 File Offset: 0x002CC738
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

		// Token: 0x0400557D RID: 21885
		private Table __p;
	}
}

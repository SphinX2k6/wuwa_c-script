using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EDA RID: 3802
	public struct PhantomBattleRecordGroup : IFlatbufferObject
	{
		// Token: 0x1700267B RID: 9851
		// (get) Token: 0x0600A7BD RID: 42941 RVA: 0x002B1428 File Offset: 0x002AF628
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A7BE RID: 42942 RVA: 0x002B1435 File Offset: 0x002AF635
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A7BF RID: 42943 RVA: 0x002B143C File Offset: 0x002AF63C
		public static PhantomBattleRecordGroup GetRootAsPhantomBattleRecordGroup(ByteBuffer _bb)
		{
			return PhantomBattleRecordGroup.GetRootAsPhantomBattleRecordGroup(_bb, default(PhantomBattleRecordGroup));
		}

		// Token: 0x0600A7C0 RID: 42944 RVA: 0x002B1458 File Offset: 0x002AF658
		public static PhantomBattleRecordGroup GetRootAsPhantomBattleRecordGroup(ByteBuffer _bb, PhantomBattleRecordGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A7C1 RID: 42945 RVA: 0x002B1475 File Offset: 0x002AF675
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A7C2 RID: 42946 RVA: 0x002B1484 File Offset: 0x002AF684
		public PhantomBattleRecordGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700267C RID: 9852
		// (get) Token: 0x0600A7C3 RID: 42947 RVA: 0x002B1494 File Offset: 0x002AF694
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

		// Token: 0x04004F98 RID: 20376
		private Table __p;
	}
}

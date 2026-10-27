using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000ECC RID: 3788
	public struct PhantomBattleCount : IFlatbufferObject
	{
		// Token: 0x17002622 RID: 9762
		// (get) Token: 0x0600A6D6 RID: 42710 RVA: 0x002AF5F5 File Offset: 0x002AD7F5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A6D7 RID: 42711 RVA: 0x002AF602 File Offset: 0x002AD802
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A6D8 RID: 42712 RVA: 0x002AF60C File Offset: 0x002AD80C
		public static PhantomBattleCount GetRootAsPhantomBattleCount(ByteBuffer _bb)
		{
			return PhantomBattleCount.GetRootAsPhantomBattleCount(_bb, default(PhantomBattleCount));
		}

		// Token: 0x0600A6D9 RID: 42713 RVA: 0x002AF628 File Offset: 0x002AD828
		public static PhantomBattleCount GetRootAsPhantomBattleCount(ByteBuffer _bb, PhantomBattleCount obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A6DA RID: 42714 RVA: 0x002AF645 File Offset: 0x002AD845
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A6DB RID: 42715 RVA: 0x002AF654 File Offset: 0x002AD854
		public PhantomBattleCount __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002623 RID: 9763
		// (get) Token: 0x0600A6DC RID: 42716 RVA: 0x002AF664 File Offset: 0x002AD864
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

		// Token: 0x17002624 RID: 9764
		// (get) Token: 0x0600A6DD RID: 42717 RVA: 0x002AF6A0 File Offset: 0x002AD8A0
		public int CountType
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

		// Token: 0x17002625 RID: 9765
		// (get) Token: 0x0600A6DE RID: 42718 RVA: 0x002AF6DC File Offset: 0x002AD8DC
		public int TargetType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002626 RID: 9766
		// (get) Token: 0x0600A6DF RID: 42719 RVA: 0x002AF718 File Offset: 0x002AD918
		public int UnlockCount
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002627 RID: 9767
		// (get) Token: 0x0600A6E0 RID: 42720 RVA: 0x002AF758 File Offset: 0x002AD958
		public int ReduceCount
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002628 RID: 9768
		// (get) Token: 0x0600A6E1 RID: 42721 RVA: 0x002AF798 File Offset: 0x002AD998
		public int CountSkillLimitNum
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return -1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04004F8A RID: 20362
		private Table __p;
	}
}

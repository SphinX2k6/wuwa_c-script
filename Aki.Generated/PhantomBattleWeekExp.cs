using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FC3 RID: 4035
	public struct PhantomBattleWeekExp : IFlatbufferObject
	{
		// Token: 0x170026FD RID: 9981
		// (get) Token: 0x0600AE1F RID: 44575 RVA: 0x002CEDC0 File Offset: 0x002CCFC0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600AE20 RID: 44576 RVA: 0x002CEDCD File Offset: 0x002CCFCD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600AE21 RID: 44577 RVA: 0x002CEDD4 File Offset: 0x002CCFD4
		public static PhantomBattleWeekExp GetRootAsPhantomBattleWeekExp(ByteBuffer _bb)
		{
			return PhantomBattleWeekExp.GetRootAsPhantomBattleWeekExp(_bb, default(PhantomBattleWeekExp));
		}

		// Token: 0x0600AE22 RID: 44578 RVA: 0x002CEDF0 File Offset: 0x002CCFF0
		public static PhantomBattleWeekExp GetRootAsPhantomBattleWeekExp(ByteBuffer _bb, PhantomBattleWeekExp obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600AE23 RID: 44579 RVA: 0x002CEE0D File Offset: 0x002CD00D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600AE24 RID: 44580 RVA: 0x002CEE1C File Offset: 0x002CD01C
		public PhantomBattleWeekExp __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170026FE RID: 9982
		// (get) Token: 0x0600AE25 RID: 44581 RVA: 0x002CEE2C File Offset: 0x002CD02C
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

		// Token: 0x170026FF RID: 9983
		// (get) Token: 0x0600AE26 RID: 44582 RVA: 0x002CEE68 File Offset: 0x002CD068
		public int MaxWeekExp
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

		// Token: 0x04005581 RID: 21889
		private Table __p;
	}
}

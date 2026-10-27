using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EDE RID: 3806
	public struct PhantomBattleWeekExp : IFlatbufferObject
	{
		// Token: 0x17002697 RID: 9879
		// (get) Token: 0x0600A7FE RID: 43006 RVA: 0x002B1D1C File Offset: 0x002AFF1C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A7FF RID: 43007 RVA: 0x002B1D29 File Offset: 0x002AFF29
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A800 RID: 43008 RVA: 0x002B1D30 File Offset: 0x002AFF30
		public static PhantomBattleWeekExp GetRootAsPhantomBattleWeekExp(ByteBuffer _bb)
		{
			return PhantomBattleWeekExp.GetRootAsPhantomBattleWeekExp(_bb, default(PhantomBattleWeekExp));
		}

		// Token: 0x0600A801 RID: 43009 RVA: 0x002B1D4C File Offset: 0x002AFF4C
		public static PhantomBattleWeekExp GetRootAsPhantomBattleWeekExp(ByteBuffer _bb, PhantomBattleWeekExp obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A802 RID: 43010 RVA: 0x002B1D69 File Offset: 0x002AFF69
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A803 RID: 43011 RVA: 0x002B1D78 File Offset: 0x002AFF78
		public PhantomBattleWeekExp __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002698 RID: 9880
		// (get) Token: 0x0600A804 RID: 43012 RVA: 0x002B1D88 File Offset: 0x002AFF88
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

		// Token: 0x17002699 RID: 9881
		// (get) Token: 0x0600A805 RID: 43013 RVA: 0x002B1DC4 File Offset: 0x002AFFC4
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

		// Token: 0x04004F9C RID: 20380
		private Table __p;
	}
}

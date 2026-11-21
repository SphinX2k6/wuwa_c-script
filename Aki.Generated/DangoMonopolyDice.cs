using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CBA RID: 3258
	public struct DangoMonopolyDice : IFlatbufferObject
	{
		// Token: 0x17000C32 RID: 3122
		// (get) Token: 0x06006646 RID: 26182 RVA: 0x0022EFA4 File Offset: 0x0022D1A4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006647 RID: 26183 RVA: 0x0022EFB1 File Offset: 0x0022D1B1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006648 RID: 26184 RVA: 0x0022EFB8 File Offset: 0x0022D1B8
		public static DangoMonopolyDice GetRootAsDangoMonopolyDice(ByteBuffer _bb)
		{
			return DangoMonopolyDice.GetRootAsDangoMonopolyDice(_bb, default(DangoMonopolyDice));
		}

		// Token: 0x06006649 RID: 26185 RVA: 0x0022EFD4 File Offset: 0x0022D1D4
		public static DangoMonopolyDice GetRootAsDangoMonopolyDice(ByteBuffer _bb, DangoMonopolyDice obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600664A RID: 26186 RVA: 0x0022EFF1 File Offset: 0x0022D1F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600664B RID: 26187 RVA: 0x0022F000 File Offset: 0x0022D200
		public DangoMonopolyDice __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000C33 RID: 3123
		// (get) Token: 0x0600664C RID: 26188 RVA: 0x0022F010 File Offset: 0x0022D210
		public int DiceNum
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

		// Token: 0x040051E7 RID: 20967
		private Table __p;
	}
}

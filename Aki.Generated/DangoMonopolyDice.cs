using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BD8 RID: 3032
	public struct DangoMonopolyDice : IFlatbufferObject
	{
		// Token: 0x17000BEC RID: 3052
		// (get) Token: 0x0600606D RID: 24685 RVA: 0x0020F920 File Offset: 0x0020DB20
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600606E RID: 24686 RVA: 0x0020F92D File Offset: 0x0020DB2D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600606F RID: 24687 RVA: 0x0020F934 File Offset: 0x0020DB34
		public static DangoMonopolyDice GetRootAsDangoMonopolyDice(ByteBuffer _bb)
		{
			return DangoMonopolyDice.GetRootAsDangoMonopolyDice(_bb, default(DangoMonopolyDice));
		}

		// Token: 0x06006070 RID: 24688 RVA: 0x0020F950 File Offset: 0x0020DB50
		public static DangoMonopolyDice GetRootAsDangoMonopolyDice(ByteBuffer _bb, DangoMonopolyDice obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006071 RID: 24689 RVA: 0x0020F96D File Offset: 0x0020DB6D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006072 RID: 24690 RVA: 0x0020F97C File Offset: 0x0020DB7C
		public DangoMonopolyDice __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000BED RID: 3053
		// (get) Token: 0x06006073 RID: 24691 RVA: 0x0020F98C File Offset: 0x0020DB8C
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

		// Token: 0x04004C05 RID: 19461
		private Table __p;
	}
}

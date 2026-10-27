using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200116D RID: 4461
	public struct TrapDefenseSpecialCell : IFlatbufferObject
	{
		// Token: 0x17003C77 RID: 15479
		// (get) Token: 0x0600E478 RID: 58488 RVA: 0x0033A888 File Offset: 0x00338A88
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E479 RID: 58489 RVA: 0x0033A895 File Offset: 0x00338A95
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E47A RID: 58490 RVA: 0x0033A89C File Offset: 0x00338A9C
		public static TrapDefenseSpecialCell GetRootAsTrapDefenseSpecialCell(ByteBuffer _bb)
		{
			return TrapDefenseSpecialCell.GetRootAsTrapDefenseSpecialCell(_bb, default(TrapDefenseSpecialCell));
		}

		// Token: 0x0600E47B RID: 58491 RVA: 0x0033A8B8 File Offset: 0x00338AB8
		public static TrapDefenseSpecialCell GetRootAsTrapDefenseSpecialCell(ByteBuffer _bb, TrapDefenseSpecialCell obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E47C RID: 58492 RVA: 0x0033A8D5 File Offset: 0x00338AD5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E47D RID: 58493 RVA: 0x0033A8E4 File Offset: 0x00338AE4
		public TrapDefenseSpecialCell __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003C78 RID: 15480
		// (get) Token: 0x0600E47E RID: 58494 RVA: 0x0033A8F4 File Offset: 0x00338AF4
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

		// Token: 0x17003C79 RID: 15481
		// (get) Token: 0x0600E47F RID: 58495 RVA: 0x0033A930 File Offset: 0x00338B30
		public int CellType
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

		// Token: 0x17003C7A RID: 15482
		// (get) Token: 0x0600E480 RID: 58496 RVA: 0x0033A96C File Offset: 0x00338B6C
		public int Level
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

		// Token: 0x17003C7B RID: 15483
		// (get) Token: 0x0600E481 RID: 58497 RVA: 0x0033A9A8 File Offset: 0x00338BA8
		public int SimpleCombatSubtypeId
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x040052B3 RID: 21171
		private Table __p;
	}
}

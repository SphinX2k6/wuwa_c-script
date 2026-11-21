using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020012A3 RID: 4771
	public struct TrapDefenseSpecialCell : IFlatbufferObject
	{
		// Token: 0x17003FDB RID: 16347
		// (get) Token: 0x0600F1E6 RID: 61926 RVA: 0x00365798 File Offset: 0x00363998
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F1E7 RID: 61927 RVA: 0x003657A5 File Offset: 0x003639A5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F1E8 RID: 61928 RVA: 0x003657AC File Offset: 0x003639AC
		public static TrapDefenseSpecialCell GetRootAsTrapDefenseSpecialCell(ByteBuffer _bb)
		{
			return TrapDefenseSpecialCell.GetRootAsTrapDefenseSpecialCell(_bb, default(TrapDefenseSpecialCell));
		}

		// Token: 0x0600F1E9 RID: 61929 RVA: 0x003657C8 File Offset: 0x003639C8
		public static TrapDefenseSpecialCell GetRootAsTrapDefenseSpecialCell(ByteBuffer _bb, TrapDefenseSpecialCell obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F1EA RID: 61930 RVA: 0x003657E5 File Offset: 0x003639E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F1EB RID: 61931 RVA: 0x003657F4 File Offset: 0x003639F4
		public TrapDefenseSpecialCell __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003FDC RID: 16348
		// (get) Token: 0x0600F1EC RID: 61932 RVA: 0x00365804 File Offset: 0x00363A04
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

		// Token: 0x17003FDD RID: 16349
		// (get) Token: 0x0600F1ED RID: 61933 RVA: 0x00365840 File Offset: 0x00363A40
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

		// Token: 0x17003FDE RID: 16350
		// (get) Token: 0x0600F1EE RID: 61934 RVA: 0x0036587C File Offset: 0x00363A7C
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

		// Token: 0x17003FDF RID: 16351
		// (get) Token: 0x0600F1EF RID: 61935 RVA: 0x003658B8 File Offset: 0x00363AB8
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

		// Token: 0x040058F6 RID: 22774
		private Table __p;
	}
}

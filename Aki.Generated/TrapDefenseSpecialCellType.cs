using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200116E RID: 4462
	public struct TrapDefenseSpecialCellType : IFlatbufferObject
	{
		// Token: 0x17003C7C RID: 15484
		// (get) Token: 0x0600E482 RID: 58498 RVA: 0x0033A9E5 File Offset: 0x00338BE5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E483 RID: 58499 RVA: 0x0033A9F2 File Offset: 0x00338BF2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E484 RID: 58500 RVA: 0x0033A9FC File Offset: 0x00338BFC
		public static TrapDefenseSpecialCellType GetRootAsTrapDefenseSpecialCellType(ByteBuffer _bb)
		{
			return TrapDefenseSpecialCellType.GetRootAsTrapDefenseSpecialCellType(_bb, default(TrapDefenseSpecialCellType));
		}

		// Token: 0x0600E485 RID: 58501 RVA: 0x0033AA18 File Offset: 0x00338C18
		public static TrapDefenseSpecialCellType GetRootAsTrapDefenseSpecialCellType(ByteBuffer _bb, TrapDefenseSpecialCellType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E486 RID: 58502 RVA: 0x0033AA35 File Offset: 0x00338C35
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E487 RID: 58503 RVA: 0x0033AA44 File Offset: 0x00338C44
		public TrapDefenseSpecialCellType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003C7D RID: 15485
		// (get) Token: 0x0600E488 RID: 58504 RVA: 0x0033AA54 File Offset: 0x00338C54
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

		// Token: 0x17003C7E RID: 15486
		// (get) Token: 0x0600E489 RID: 58505 RVA: 0x0033AA90 File Offset: 0x00338C90
		public int TemplateId
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

		// Token: 0x040052B4 RID: 21172
		private Table __p;
	}
}

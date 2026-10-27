using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001025 RID: 4133
	public struct RogueToken : IFlatbufferObject
	{
		// Token: 0x1700313D RID: 12605
		// (get) Token: 0x0600C552 RID: 50514 RVA: 0x002F2DB8 File Offset: 0x002F0FB8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C553 RID: 50515 RVA: 0x002F2DC5 File Offset: 0x002F0FC5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C554 RID: 50516 RVA: 0x002F2DCC File Offset: 0x002F0FCC
		public static RogueToken GetRootAsRogueToken(ByteBuffer _bb)
		{
			return RogueToken.GetRootAsRogueToken(_bb, default(RogueToken));
		}

		// Token: 0x0600C555 RID: 50517 RVA: 0x002F2DE8 File Offset: 0x002F0FE8
		public static RogueToken GetRootAsRogueToken(ByteBuffer _bb, RogueToken obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C556 RID: 50518 RVA: 0x002F2E05 File Offset: 0x002F1005
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C557 RID: 50519 RVA: 0x002F2E14 File Offset: 0x002F1014
		public RogueToken __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700313E RID: 12606
		// (get) Token: 0x0600C558 RID: 50520 RVA: 0x002F2E24 File Offset: 0x002F1024
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

		// Token: 0x1700313F RID: 12607
		// (get) Token: 0x0600C559 RID: 50521 RVA: 0x002F2E60 File Offset: 0x002F1060
		public int SeasonId
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

		// Token: 0x17003140 RID: 12608
		// (get) Token: 0x0600C55A RID: 50522 RVA: 0x002F2E9C File Offset: 0x002F109C
		public int Token
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003141 RID: 12609
		// (get) Token: 0x0600C55B RID: 50523 RVA: 0x002F2ED8 File Offset: 0x002F10D8
		public int DropId
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

		// Token: 0x04005118 RID: 20760
		private Table __p;
	}
}

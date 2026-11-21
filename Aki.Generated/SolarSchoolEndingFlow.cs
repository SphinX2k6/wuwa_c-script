using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011DD RID: 4573
	public struct SolarSchoolEndingFlow : IFlatbufferObject
	{
		// Token: 0x17003933 RID: 14643
		// (get) Token: 0x0600E089 RID: 57481 RVA: 0x0033F00C File Offset: 0x0033D20C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E08A RID: 57482 RVA: 0x0033F019 File Offset: 0x0033D219
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E08B RID: 57483 RVA: 0x0033F020 File Offset: 0x0033D220
		public static SolarSchoolEndingFlow GetRootAsSolarSchoolEndingFlow(ByteBuffer _bb)
		{
			return SolarSchoolEndingFlow.GetRootAsSolarSchoolEndingFlow(_bb, default(SolarSchoolEndingFlow));
		}

		// Token: 0x0600E08C RID: 57484 RVA: 0x0033F03C File Offset: 0x0033D23C
		public static SolarSchoolEndingFlow GetRootAsSolarSchoolEndingFlow(ByteBuffer _bb, SolarSchoolEndingFlow obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E08D RID: 57485 RVA: 0x0033F059 File Offset: 0x0033D259
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E08E RID: 57486 RVA: 0x0033F068 File Offset: 0x0033D268
		public SolarSchoolEndingFlow __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003934 RID: 14644
		// (get) Token: 0x0600E08F RID: 57487 RVA: 0x0033F078 File Offset: 0x0033D278
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

		// Token: 0x17003935 RID: 14645
		// (get) Token: 0x0600E090 RID: 57488 RVA: 0x0033F0B4 File Offset: 0x0033D2B4
		public int ActivityId
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

		// Token: 0x17003936 RID: 14646
		// (get) Token: 0x0600E091 RID: 57489 RVA: 0x0033F0F0 File Offset: 0x0033D2F0
		public bool IsStart
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17003937 RID: 14647
		// (get) Token: 0x0600E092 RID: 57490 RVA: 0x0033F130 File Offset: 0x0033D330
		public int NodeType
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

		// Token: 0x17003938 RID: 14648
		// (get) Token: 0x0600E093 RID: 57491 RVA: 0x0033F170 File Offset: 0x0033D370
		public int ActionId
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003939 RID: 14649
		// (get) Token: 0x0600E094 RID: 57492 RVA: 0x0033F1B0 File Offset: 0x0033D3B0
		public int ConditionId
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700393A RID: 14650
		// (get) Token: 0x0600E095 RID: 57493 RVA: 0x0033F1F0 File Offset: 0x0033D3F0
		public int NextId
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700393B RID: 14651
		// (get) Token: 0x0600E096 RID: 57494 RVA: 0x0033F230 File Offset: 0x0033D430
		public int TrueNextId
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700393C RID: 14652
		// (get) Token: 0x0600E097 RID: 57495 RVA: 0x0033F270 File Offset: 0x0033D470
		public int FalseNextId
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700393D RID: 14653
		// (get) Token: 0x0600E098 RID: 57496 RVA: 0x0033F2B0 File Offset: 0x0033D4B0
		public string Comments
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E099 RID: 57497 RVA: 0x0033F2E8 File Offset: 0x0033D4E8
		public Span<byte> GetCommentsBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600E09A RID: 57498 RVA: 0x0033F2F8 File Offset: 0x0033D4F8
		public byte[] GetCommentsArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x0400581A RID: 22554
		private Table __p;
	}
}

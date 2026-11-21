using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011E9 RID: 4585
	public struct SolarSchoolFunction : IFlatbufferObject
	{
		// Token: 0x1700398D RID: 14733
		// (get) Token: 0x0600E166 RID: 57702 RVA: 0x00340D94 File Offset: 0x0033EF94
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E167 RID: 57703 RVA: 0x00340DA1 File Offset: 0x0033EFA1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E168 RID: 57704 RVA: 0x00340DA8 File Offset: 0x0033EFA8
		public static SolarSchoolFunction GetRootAsSolarSchoolFunction(ByteBuffer _bb)
		{
			return SolarSchoolFunction.GetRootAsSolarSchoolFunction(_bb, default(SolarSchoolFunction));
		}

		// Token: 0x0600E169 RID: 57705 RVA: 0x00340DC4 File Offset: 0x0033EFC4
		public static SolarSchoolFunction GetRootAsSolarSchoolFunction(ByteBuffer _bb, SolarSchoolFunction obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E16A RID: 57706 RVA: 0x00340DE1 File Offset: 0x0033EFE1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E16B RID: 57707 RVA: 0x00340DF0 File Offset: 0x0033EFF0
		public SolarSchoolFunction __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700398E RID: 14734
		// (get) Token: 0x0600E16C RID: 57708 RVA: 0x00340E00 File Offset: 0x0033F000
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

		// Token: 0x1700398F RID: 14735
		// (get) Token: 0x0600E16D RID: 57709 RVA: 0x00340E3C File Offset: 0x0033F03C
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

		// Token: 0x17003990 RID: 14736
		// (get) Token: 0x0600E16E RID: 57710 RVA: 0x00340E78 File Offset: 0x0033F078
		public int FunctionType
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

		// Token: 0x17003991 RID: 14737
		// (get) Token: 0x0600E16F RID: 57711 RVA: 0x00340EB4 File Offset: 0x0033F0B4
		public int UnlockConditionGroupId
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

		// Token: 0x04005826 RID: 22566
		private Table __p;
	}
}

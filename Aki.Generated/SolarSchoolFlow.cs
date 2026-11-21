using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011E6 RID: 4582
	public struct SolarSchoolFlow : IFlatbufferObject
	{
		// Token: 0x1700397B RID: 14715
		// (get) Token: 0x0600E136 RID: 57654 RVA: 0x00340790 File Offset: 0x0033E990
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E137 RID: 57655 RVA: 0x0034079D File Offset: 0x0033E99D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E138 RID: 57656 RVA: 0x003407A4 File Offset: 0x0033E9A4
		public static SolarSchoolFlow GetRootAsSolarSchoolFlow(ByteBuffer _bb)
		{
			return SolarSchoolFlow.GetRootAsSolarSchoolFlow(_bb, default(SolarSchoolFlow));
		}

		// Token: 0x0600E139 RID: 57657 RVA: 0x003407C0 File Offset: 0x0033E9C0
		public static SolarSchoolFlow GetRootAsSolarSchoolFlow(ByteBuffer _bb, SolarSchoolFlow obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E13A RID: 57658 RVA: 0x003407DD File Offset: 0x0033E9DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E13B RID: 57659 RVA: 0x003407EC File Offset: 0x0033E9EC
		public SolarSchoolFlow __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700397C RID: 14716
		// (get) Token: 0x0600E13C RID: 57660 RVA: 0x003407FC File Offset: 0x0033E9FC
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

		// Token: 0x1700397D RID: 14717
		// (get) Token: 0x0600E13D RID: 57661 RVA: 0x00340838 File Offset: 0x0033EA38
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

		// Token: 0x1700397E RID: 14718
		// (get) Token: 0x0600E13E RID: 57662 RVA: 0x00340874 File Offset: 0x0033EA74
		public string FlowListName
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E13F RID: 57663 RVA: 0x003408AB File Offset: 0x0033EAAB
		public Span<byte> GetFlowListNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600E140 RID: 57664 RVA: 0x003408BA File Offset: 0x0033EABA
		public byte[] GetFlowListNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700397F RID: 14719
		// (get) Token: 0x0600E141 RID: 57665 RVA: 0x003408D4 File Offset: 0x0033EAD4
		public int FlowId
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

		// Token: 0x17003980 RID: 14720
		// (get) Token: 0x0600E142 RID: 57666 RVA: 0x00340914 File Offset: 0x0033EB14
		public int StateId
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

		// Token: 0x17003981 RID: 14721
		// (get) Token: 0x0600E143 RID: 57667 RVA: 0x00340954 File Offset: 0x0033EB54
		public bool NeedSave
		{
			get
			{
				int num = this.__p.__offset(14);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17003982 RID: 14722
		// (get) Token: 0x0600E144 RID: 57668 RVA: 0x00340994 File Offset: 0x0033EB94
		public int BitFlag
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

		// Token: 0x04005823 RID: 22563
		private Table __p;
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011EC RID: 4588
	public struct SolarSchoolInfluenceLevel : IFlatbufferObject
	{
		// Token: 0x170039A8 RID: 14760
		// (get) Token: 0x0600E1A2 RID: 57762 RVA: 0x003415DC File Offset: 0x0033F7DC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E1A3 RID: 57763 RVA: 0x003415E9 File Offset: 0x0033F7E9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E1A4 RID: 57764 RVA: 0x003415F0 File Offset: 0x0033F7F0
		public static SolarSchoolInfluenceLevel GetRootAsSolarSchoolInfluenceLevel(ByteBuffer _bb)
		{
			return SolarSchoolInfluenceLevel.GetRootAsSolarSchoolInfluenceLevel(_bb, default(SolarSchoolInfluenceLevel));
		}

		// Token: 0x0600E1A5 RID: 57765 RVA: 0x0034160C File Offset: 0x0033F80C
		public static SolarSchoolInfluenceLevel GetRootAsSolarSchoolInfluenceLevel(ByteBuffer _bb, SolarSchoolInfluenceLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E1A6 RID: 57766 RVA: 0x00341629 File Offset: 0x0033F829
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E1A7 RID: 57767 RVA: 0x00341638 File Offset: 0x0033F838
		public SolarSchoolInfluenceLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170039A9 RID: 14761
		// (get) Token: 0x0600E1A8 RID: 57768 RVA: 0x00341648 File Offset: 0x0033F848
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

		// Token: 0x170039AA RID: 14762
		// (get) Token: 0x0600E1A9 RID: 57769 RVA: 0x00341684 File Offset: 0x0033F884
		public int InfluenceType
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

		// Token: 0x170039AB RID: 14763
		// (get) Token: 0x0600E1AA RID: 57770 RVA: 0x003416C0 File Offset: 0x0033F8C0
		public int Level
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

		// Token: 0x170039AC RID: 14764
		// (get) Token: 0x0600E1AB RID: 57771 RVA: 0x003416FC File Offset: 0x0033F8FC
		public string Name
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E1AC RID: 57772 RVA: 0x00341734 File Offset: 0x0033F934
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600E1AD RID: 57773 RVA: 0x00341744 File Offset: 0x0033F944
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x04005829 RID: 22569
		private Table __p;
	}
}

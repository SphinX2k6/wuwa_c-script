using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001112 RID: 4370
	public struct SynthesisLevel : IFlatbufferObject
	{
		// Token: 0x1700399A RID: 14746
		// (get) Token: 0x0600DCA2 RID: 56482 RVA: 0x00328FE1 File Offset: 0x003271E1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DCA3 RID: 56483 RVA: 0x00328FEE File Offset: 0x003271EE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DCA4 RID: 56484 RVA: 0x00328FF8 File Offset: 0x003271F8
		public static SynthesisLevel GetRootAsSynthesisLevel(ByteBuffer _bb)
		{
			return SynthesisLevel.GetRootAsSynthesisLevel(_bb, default(SynthesisLevel));
		}

		// Token: 0x0600DCA5 RID: 56485 RVA: 0x00329014 File Offset: 0x00327214
		public static SynthesisLevel GetRootAsSynthesisLevel(ByteBuffer _bb, SynthesisLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DCA6 RID: 56486 RVA: 0x00329031 File Offset: 0x00327231
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DCA7 RID: 56487 RVA: 0x00329040 File Offset: 0x00327240
		public SynthesisLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700399B RID: 14747
		// (get) Token: 0x0600DCA8 RID: 56488 RVA: 0x00329050 File Offset: 0x00327250
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

		// Token: 0x1700399C RID: 14748
		// (get) Token: 0x0600DCA9 RID: 56489 RVA: 0x0032908C File Offset: 0x0032728C
		public string Name
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600DCAA RID: 56490 RVA: 0x003290C3 File Offset: 0x003272C3
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600DCAB RID: 56491 RVA: 0x003290D2 File Offset: 0x003272D2
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700399D RID: 14749
		// (get) Token: 0x0600DCAC RID: 56492 RVA: 0x003290EC File Offset: 0x003272EC
		public int Completeness
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

		// Token: 0x1700399E RID: 14750
		// (get) Token: 0x0600DCAD RID: 56493 RVA: 0x00329128 File Offset: 0x00327328
		public int Effect
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

		// Token: 0x1700399F RID: 14751
		// (get) Token: 0x0600DCAE RID: 56494 RVA: 0x00329168 File Offset: 0x00327368
		public string AttributesDescription
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600DCAF RID: 56495 RVA: 0x003291A0 File Offset: 0x003273A0
		public Span<byte> GetAttributesDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600DCB0 RID: 56496 RVA: 0x003291B0 File Offset: 0x003273B0
		public byte[] GetAttributesDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170039A0 RID: 14752
		// (get) Token: 0x0600DCB1 RID: 56497 RVA: 0x003291C8 File Offset: 0x003273C8
		public int DropIds
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

		// Token: 0x0400524F RID: 21071
		private Table __p;
	}
}

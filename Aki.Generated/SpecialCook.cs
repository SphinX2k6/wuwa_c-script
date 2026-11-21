using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001213 RID: 4627
	public struct SpecialCook : IFlatbufferObject
	{
		// Token: 0x17003B17 RID: 15127
		// (get) Token: 0x0600E508 RID: 58632 RVA: 0x003490C5 File Offset: 0x003472C5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E509 RID: 58633 RVA: 0x003490D2 File Offset: 0x003472D2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E50A RID: 58634 RVA: 0x003490DC File Offset: 0x003472DC
		public static SpecialCook GetRootAsSpecialCook(ByteBuffer _bb)
		{
			return SpecialCook.GetRootAsSpecialCook(_bb, default(SpecialCook));
		}

		// Token: 0x0600E50B RID: 58635 RVA: 0x003490F8 File Offset: 0x003472F8
		public static SpecialCook GetRootAsSpecialCook(ByteBuffer _bb, SpecialCook obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E50C RID: 58636 RVA: 0x00349115 File Offset: 0x00347315
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E50D RID: 58637 RVA: 0x00349124 File Offset: 0x00347324
		public SpecialCook __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003B18 RID: 15128
		// (get) Token: 0x0600E50E RID: 58638 RVA: 0x00349134 File Offset: 0x00347334
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

		// Token: 0x17003B19 RID: 15129
		// (get) Token: 0x0600E50F RID: 58639 RVA: 0x00349170 File Offset: 0x00347370
		public int RoleId
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

		// Token: 0x17003B1A RID: 15130
		// (get) Token: 0x0600E510 RID: 58640 RVA: 0x003491AC File Offset: 0x003473AC
		public int FormulaId
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

		// Token: 0x17003B1B RID: 15131
		// (get) Token: 0x0600E511 RID: 58641 RVA: 0x003491E8 File Offset: 0x003473E8
		public int CookProbability
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

		// Token: 0x17003B1C RID: 15132
		// (get) Token: 0x0600E512 RID: 58642 RVA: 0x00349228 File Offset: 0x00347428
		public int ItemId
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

		// Token: 0x17003B1D RID: 15133
		// (get) Token: 0x0600E513 RID: 58643 RVA: 0x00349268 File Offset: 0x00347468
		public string AttributesDescription
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E514 RID: 58644 RVA: 0x003492A0 File Offset: 0x003474A0
		public Span<byte> GetAttributesDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600E515 RID: 58645 RVA: 0x003492B0 File Offset: 0x003474B0
		public byte[] GetAttributesDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x04005853 RID: 22611
		private Table __p;
	}
}

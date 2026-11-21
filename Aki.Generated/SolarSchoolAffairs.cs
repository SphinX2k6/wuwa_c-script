using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011D2 RID: 4562
	public struct SolarSchoolAffairs : IFlatbufferObject
	{
		// Token: 0x170038A4 RID: 14500
		// (get) Token: 0x0600DF19 RID: 57113 RVA: 0x0033B87D File Offset: 0x00339A7D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DF1A RID: 57114 RVA: 0x0033B88A File Offset: 0x00339A8A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DF1B RID: 57115 RVA: 0x0033B894 File Offset: 0x00339A94
		public static SolarSchoolAffairs GetRootAsSolarSchoolAffairs(ByteBuffer _bb)
		{
			return SolarSchoolAffairs.GetRootAsSolarSchoolAffairs(_bb, default(SolarSchoolAffairs));
		}

		// Token: 0x0600DF1C RID: 57116 RVA: 0x0033B8B0 File Offset: 0x00339AB0
		public static SolarSchoolAffairs GetRootAsSolarSchoolAffairs(ByteBuffer _bb, SolarSchoolAffairs obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DF1D RID: 57117 RVA: 0x0033B8CD File Offset: 0x00339ACD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DF1E RID: 57118 RVA: 0x0033B8DC File Offset: 0x00339ADC
		public SolarSchoolAffairs __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170038A5 RID: 14501
		// (get) Token: 0x0600DF1F RID: 57119 RVA: 0x0033B8EC File Offset: 0x00339AEC
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

		// Token: 0x170038A6 RID: 14502
		// (get) Token: 0x0600DF20 RID: 57120 RVA: 0x0033B928 File Offset: 0x00339B28
		public int Type
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

		// Token: 0x170038A7 RID: 14503
		// (get) Token: 0x0600DF21 RID: 57121 RVA: 0x0033B964 File Offset: 0x00339B64
		public string Title
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

		// Token: 0x0600DF22 RID: 57122 RVA: 0x0033B99B File Offset: 0x00339B9B
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600DF23 RID: 57123 RVA: 0x0033B9AA File Offset: 0x00339BAA
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170038A8 RID: 14504
		// (get) Token: 0x0600DF24 RID: 57124 RVA: 0x0033B9C4 File Offset: 0x00339BC4
		public string Content
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

		// Token: 0x0600DF25 RID: 57125 RVA: 0x0033B9FC File Offset: 0x00339BFC
		public Span<byte> GetContentBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600DF26 RID: 57126 RVA: 0x0033BA0C File Offset: 0x00339C0C
		public byte[] GetContentArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170038A9 RID: 14505
		// (get) Token: 0x0600DF27 RID: 57127 RVA: 0x0033BA24 File Offset: 0x00339C24
		public string RoleIcon
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

		// Token: 0x0600DF28 RID: 57128 RVA: 0x0033BA5C File Offset: 0x00339C5C
		public Span<byte> GetRoleIconBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600DF29 RID: 57129 RVA: 0x0033BA6C File Offset: 0x00339C6C
		public byte[] GetRoleIconArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170038AA RID: 14506
		// (get) Token: 0x0600DF2A RID: 57130 RVA: 0x0033BA84 File Offset: 0x00339C84
		public int OptionGroupId
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

		// Token: 0x04005809 RID: 22537
		private Table __p;
	}
}

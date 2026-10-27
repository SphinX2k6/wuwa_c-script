using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010DD RID: 4317
	public struct SpecialCook : IFlatbufferObject
	{
		// Token: 0x170037C1 RID: 14273
		// (get) Token: 0x0600D7BD RID: 55229 RVA: 0x0031DA51 File Offset: 0x0031BC51
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D7BE RID: 55230 RVA: 0x0031DA5E File Offset: 0x0031BC5E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D7BF RID: 55231 RVA: 0x0031DA68 File Offset: 0x0031BC68
		public static SpecialCook GetRootAsSpecialCook(ByteBuffer _bb)
		{
			return SpecialCook.GetRootAsSpecialCook(_bb, default(SpecialCook));
		}

		// Token: 0x0600D7C0 RID: 55232 RVA: 0x0031DA84 File Offset: 0x0031BC84
		public static SpecialCook GetRootAsSpecialCook(ByteBuffer _bb, SpecialCook obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D7C1 RID: 55233 RVA: 0x0031DAA1 File Offset: 0x0031BCA1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D7C2 RID: 55234 RVA: 0x0031DAB0 File Offset: 0x0031BCB0
		public SpecialCook __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170037C2 RID: 14274
		// (get) Token: 0x0600D7C3 RID: 55235 RVA: 0x0031DAC0 File Offset: 0x0031BCC0
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

		// Token: 0x170037C3 RID: 14275
		// (get) Token: 0x0600D7C4 RID: 55236 RVA: 0x0031DAFC File Offset: 0x0031BCFC
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

		// Token: 0x170037C4 RID: 14276
		// (get) Token: 0x0600D7C5 RID: 55237 RVA: 0x0031DB38 File Offset: 0x0031BD38
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

		// Token: 0x170037C5 RID: 14277
		// (get) Token: 0x0600D7C6 RID: 55238 RVA: 0x0031DB74 File Offset: 0x0031BD74
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

		// Token: 0x170037C6 RID: 14278
		// (get) Token: 0x0600D7C7 RID: 55239 RVA: 0x0031DBB4 File Offset: 0x0031BDB4
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

		// Token: 0x170037C7 RID: 14279
		// (get) Token: 0x0600D7C8 RID: 55240 RVA: 0x0031DBF4 File Offset: 0x0031BDF4
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

		// Token: 0x0600D7C9 RID: 55241 RVA: 0x0031DC2C File Offset: 0x0031BE2C
		public Span<byte> GetAttributesDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600D7CA RID: 55242 RVA: 0x0031DC3C File Offset: 0x0031BE3C
		public byte[] GetAttributesDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x04005210 RID: 21008
		private Table __p;
	}
}

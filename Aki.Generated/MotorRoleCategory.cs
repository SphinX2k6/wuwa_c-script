using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F4B RID: 3915
	public struct MotorRoleCategory : IFlatbufferObject
	{
		// Token: 0x17002263 RID: 8803
		// (get) Token: 0x0600A1B7 RID: 41399 RVA: 0x002B3B1C File Offset: 0x002B1D1C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A1B8 RID: 41400 RVA: 0x002B3B29 File Offset: 0x002B1D29
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A1B9 RID: 41401 RVA: 0x002B3B30 File Offset: 0x002B1D30
		public static MotorRoleCategory GetRootAsMotorRoleCategory(ByteBuffer _bb)
		{
			return MotorRoleCategory.GetRootAsMotorRoleCategory(_bb, default(MotorRoleCategory));
		}

		// Token: 0x0600A1BA RID: 41402 RVA: 0x002B3B4C File Offset: 0x002B1D4C
		public static MotorRoleCategory GetRootAsMotorRoleCategory(ByteBuffer _bb, MotorRoleCategory obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A1BB RID: 41403 RVA: 0x002B3B69 File Offset: 0x002B1D69
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A1BC RID: 41404 RVA: 0x002B3B78 File Offset: 0x002B1D78
		public MotorRoleCategory __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002264 RID: 8804
		// (get) Token: 0x0600A1BD RID: 41405 RVA: 0x002B3B88 File Offset: 0x002B1D88
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

		// Token: 0x17002265 RID: 8805
		// (get) Token: 0x0600A1BE RID: 41406 RVA: 0x002B3BC4 File Offset: 0x002B1DC4
		public string RegionName
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

		// Token: 0x0600A1BF RID: 41407 RVA: 0x002B3BFB File Offset: 0x002B1DFB
		public Span<byte> GetRegionNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600A1C0 RID: 41408 RVA: 0x002B3C0A File Offset: 0x002B1E0A
		public byte[] GetRegionNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002266 RID: 8806
		// (get) Token: 0x0600A1C1 RID: 41409 RVA: 0x002B3C24 File Offset: 0x002B1E24
		public int SortId
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

		// Token: 0x17002267 RID: 8807
		// (get) Token: 0x0600A1C2 RID: 41410 RVA: 0x002B3C60 File Offset: 0x002B1E60
		public string Icon
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

		// Token: 0x0600A1C3 RID: 41411 RVA: 0x002B3C98 File Offset: 0x002B1E98
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600A1C4 RID: 41412 RVA: 0x002B3CA8 File Offset: 0x002B1EA8
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x040054F7 RID: 21751
		private Table __p;
	}
}

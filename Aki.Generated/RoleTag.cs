using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001061 RID: 4193
	public struct RoleTag : IFlatbufferObject
	{
		// Token: 0x17003373 RID: 13171
		// (get) Token: 0x0600CB5A RID: 52058 RVA: 0x00300AE0 File Offset: 0x002FECE0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CB5B RID: 52059 RVA: 0x00300AED File Offset: 0x002FECED
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CB5C RID: 52060 RVA: 0x00300AF4 File Offset: 0x002FECF4
		public static RoleTag GetRootAsRoleTag(ByteBuffer _bb)
		{
			return RoleTag.GetRootAsRoleTag(_bb, default(RoleTag));
		}

		// Token: 0x0600CB5D RID: 52061 RVA: 0x00300B10 File Offset: 0x002FED10
		public static RoleTag GetRootAsRoleTag(ByteBuffer _bb, RoleTag obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CB5E RID: 52062 RVA: 0x00300B2D File Offset: 0x002FED2D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CB5F RID: 52063 RVA: 0x00300B3C File Offset: 0x002FED3C
		public RoleTag __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003374 RID: 13172
		// (get) Token: 0x0600CB60 RID: 52064 RVA: 0x00300B4C File Offset: 0x002FED4C
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

		// Token: 0x17003375 RID: 13173
		// (get) Token: 0x0600CB61 RID: 52065 RVA: 0x00300B88 File Offset: 0x002FED88
		public int SortId
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

		// Token: 0x17003376 RID: 13174
		// (get) Token: 0x0600CB62 RID: 52066 RVA: 0x00300BC4 File Offset: 0x002FEDC4
		public string TagName
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

		// Token: 0x0600CB63 RID: 52067 RVA: 0x00300BFB File Offset: 0x002FEDFB
		public Span<byte> GetTagNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600CB64 RID: 52068 RVA: 0x00300C0A File Offset: 0x002FEE0A
		public byte[] GetTagNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17003377 RID: 13175
		// (get) Token: 0x0600CB65 RID: 52069 RVA: 0x00300C24 File Offset: 0x002FEE24
		public string TagIcon
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

		// Token: 0x0600CB66 RID: 52070 RVA: 0x00300C5C File Offset: 0x002FEE5C
		public Span<byte> GetTagIconBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600CB67 RID: 52071 RVA: 0x00300C6C File Offset: 0x002FEE6C
		public byte[] GetTagIconArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17003378 RID: 13176
		// (get) Token: 0x0600CB68 RID: 52072 RVA: 0x00300C84 File Offset: 0x002FEE84
		public string TagNameColor
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

		// Token: 0x0600CB69 RID: 52073 RVA: 0x00300CBC File Offset: 0x002FEEBC
		public Span<byte> GetTagNameColorBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600CB6A RID: 52074 RVA: 0x00300CCC File Offset: 0x002FEECC
		public byte[] GetTagNameColorArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17003379 RID: 13177
		// (get) Token: 0x0600CB6B RID: 52075 RVA: 0x00300CE4 File Offset: 0x002FEEE4
		public string TagDesc
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

		// Token: 0x0600CB6C RID: 52076 RVA: 0x00300D1C File Offset: 0x002FEF1C
		public Span<byte> GetTagDescBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600CB6D RID: 52077 RVA: 0x00300D2C File Offset: 0x002FEF2C
		public byte[] GetTagDescArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x04005165 RID: 20837
		private Table __p;
	}
}

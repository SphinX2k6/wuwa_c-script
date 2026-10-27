using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E9A RID: 3738
	public struct NounType : IFlatbufferObject
	{
		// Token: 0x170023CB RID: 9163
		// (get) Token: 0x0600A0A1 RID: 41121 RVA: 0x002A1210 File Offset: 0x0029F410
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A0A2 RID: 41122 RVA: 0x002A121D File Offset: 0x0029F41D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A0A3 RID: 41123 RVA: 0x002A1224 File Offset: 0x0029F424
		public static NounType GetRootAsNounType(ByteBuffer _bb)
		{
			return NounType.GetRootAsNounType(_bb, default(NounType));
		}

		// Token: 0x0600A0A4 RID: 41124 RVA: 0x002A1240 File Offset: 0x0029F440
		public static NounType GetRootAsNounType(ByteBuffer _bb, NounType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A0A5 RID: 41125 RVA: 0x002A125D File Offset: 0x0029F45D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A0A6 RID: 41126 RVA: 0x002A126C File Offset: 0x0029F46C
		public NounType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170023CC RID: 9164
		// (get) Token: 0x0600A0A7 RID: 41127 RVA: 0x002A127C File Offset: 0x0029F47C
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

		// Token: 0x170023CD RID: 9165
		// (get) Token: 0x0600A0A8 RID: 41128 RVA: 0x002A12B8 File Offset: 0x0029F4B8
		public string TypeDescription
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

		// Token: 0x0600A0A9 RID: 41129 RVA: 0x002A12EF File Offset: 0x0029F4EF
		public Span<byte> GetTypeDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600A0AA RID: 41130 RVA: 0x002A12FE File Offset: 0x0029F4FE
		public byte[] GetTypeDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170023CE RID: 9166
		// (get) Token: 0x0600A0AB RID: 41131 RVA: 0x002A1318 File Offset: 0x0029F518
		public string Icon
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

		// Token: 0x0600A0AC RID: 41132 RVA: 0x002A134F File Offset: 0x0029F54F
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600A0AD RID: 41133 RVA: 0x002A135E File Offset: 0x0029F55E
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x04004F4E RID: 20302
		private Table __p;
	}
}

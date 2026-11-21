using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C54 RID: 3156
	public struct ChipType : IFlatbufferObject
	{
		// Token: 0x1700081C RID: 2076
		// (get) Token: 0x06005AAF RID: 23215 RVA: 0x00214829 File Offset: 0x00212A29
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005AB0 RID: 23216 RVA: 0x00214836 File Offset: 0x00212A36
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005AB1 RID: 23217 RVA: 0x00214840 File Offset: 0x00212A40
		public static ChipType GetRootAsChipType(ByteBuffer _bb)
		{
			return ChipType.GetRootAsChipType(_bb, default(ChipType));
		}

		// Token: 0x06005AB2 RID: 23218 RVA: 0x0021485C File Offset: 0x00212A5C
		public static ChipType GetRootAsChipType(ByteBuffer _bb, ChipType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005AB3 RID: 23219 RVA: 0x00214879 File Offset: 0x00212A79
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005AB4 RID: 23220 RVA: 0x00214888 File Offset: 0x00212A88
		public ChipType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700081D RID: 2077
		// (get) Token: 0x06005AB5 RID: 23221 RVA: 0x00214898 File Offset: 0x00212A98
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

		// Token: 0x1700081E RID: 2078
		// (get) Token: 0x06005AB6 RID: 23222 RVA: 0x002148D4 File Offset: 0x00212AD4
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

		// Token: 0x06005AB7 RID: 23223 RVA: 0x0021490B File Offset: 0x00212B0B
		public Span<byte> GetTypeDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06005AB8 RID: 23224 RVA: 0x0021491A File Offset: 0x00212B1A
		public byte[] GetTypeDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700081F RID: 2079
		// (get) Token: 0x06005AB9 RID: 23225 RVA: 0x00214934 File Offset: 0x00212B34
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

		// Token: 0x06005ABA RID: 23226 RVA: 0x0021496B File Offset: 0x00212B6B
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06005ABB RID: 23227 RVA: 0x0021497A File Offset: 0x00212B7A
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x04005158 RID: 20824
		private Table __p;
	}
}

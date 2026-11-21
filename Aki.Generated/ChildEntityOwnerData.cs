using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C51 RID: 3153
	public struct ChildEntityOwnerData : IFlatbufferObject
	{
		// Token: 0x17000809 RID: 2057
		// (get) Token: 0x06005A73 RID: 23155 RVA: 0x00213F5D File Offset: 0x0021215D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005A74 RID: 23156 RVA: 0x00213F6A File Offset: 0x0021216A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005A75 RID: 23157 RVA: 0x00213F74 File Offset: 0x00212174
		public static ChildEntityOwnerData GetRootAsChildEntityOwnerData(ByteBuffer _bb)
		{
			return ChildEntityOwnerData.GetRootAsChildEntityOwnerData(_bb, default(ChildEntityOwnerData));
		}

		// Token: 0x06005A76 RID: 23158 RVA: 0x00213F90 File Offset: 0x00212190
		public static ChildEntityOwnerData GetRootAsChildEntityOwnerData(ByteBuffer _bb, ChildEntityOwnerData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005A77 RID: 23159 RVA: 0x00213FAD File Offset: 0x002121AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005A78 RID: 23160 RVA: 0x00213FBC File Offset: 0x002121BC
		public ChildEntityOwnerData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700080A RID: 2058
		// (get) Token: 0x06005A79 RID: 23161 RVA: 0x00213FCC File Offset: 0x002121CC
		public string Guid
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005A7A RID: 23162 RVA: 0x00214003 File Offset: 0x00212203
		public Span<byte> GetGuidBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06005A7B RID: 23163 RVA: 0x00214012 File Offset: 0x00212212
		public byte[] GetGuidArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x1700080B RID: 2059
		// (get) Token: 0x06005A7C RID: 23164 RVA: 0x0021402C File Offset: 0x0021222C
		public string Owner
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

		// Token: 0x06005A7D RID: 23165 RVA: 0x00214063 File Offset: 0x00212263
		public Span<byte> GetOwnerBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06005A7E RID: 23166 RVA: 0x00214072 File Offset: 0x00212272
		public byte[] GetOwnerArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x04005153 RID: 20819
		private Table __p;
	}
}

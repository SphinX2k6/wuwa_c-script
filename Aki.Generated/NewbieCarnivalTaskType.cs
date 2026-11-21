using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F64 RID: 3940
	public struct NewbieCarnivalTaskType : IFlatbufferObject
	{
		// Token: 0x17002350 RID: 9040
		// (get) Token: 0x0600A461 RID: 42081 RVA: 0x002B93CA File Offset: 0x002B75CA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A462 RID: 42082 RVA: 0x002B93D7 File Offset: 0x002B75D7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A463 RID: 42083 RVA: 0x002B93E0 File Offset: 0x002B75E0
		public static NewbieCarnivalTaskType GetRootAsNewbieCarnivalTaskType(ByteBuffer _bb)
		{
			return NewbieCarnivalTaskType.GetRootAsNewbieCarnivalTaskType(_bb, default(NewbieCarnivalTaskType));
		}

		// Token: 0x0600A464 RID: 42084 RVA: 0x002B93FC File Offset: 0x002B75FC
		public static NewbieCarnivalTaskType GetRootAsNewbieCarnivalTaskType(ByteBuffer _bb, NewbieCarnivalTaskType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A465 RID: 42085 RVA: 0x002B9419 File Offset: 0x002B7619
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A466 RID: 42086 RVA: 0x002B9428 File Offset: 0x002B7628
		public NewbieCarnivalTaskType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002351 RID: 9041
		// (get) Token: 0x0600A467 RID: 42087 RVA: 0x002B9438 File Offset: 0x002B7638
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

		// Token: 0x17002352 RID: 9042
		// (get) Token: 0x0600A468 RID: 42088 RVA: 0x002B9474 File Offset: 0x002B7674
		public string IconTexture
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

		// Token: 0x0600A469 RID: 42089 RVA: 0x002B94AB File Offset: 0x002B76AB
		public Span<byte> GetIconTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600A46A RID: 42090 RVA: 0x002B94BA File Offset: 0x002B76BA
		public byte[] GetIconTextureArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002353 RID: 9043
		// (get) Token: 0x0600A46B RID: 42091 RVA: 0x002B94D4 File Offset: 0x002B76D4
		public string LeftTexture
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

		// Token: 0x0600A46C RID: 42092 RVA: 0x002B950B File Offset: 0x002B770B
		public Span<byte> GetLeftTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600A46D RID: 42093 RVA: 0x002B951A File Offset: 0x002B771A
		public byte[] GetLeftTextureArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002354 RID: 9044
		// (get) Token: 0x0600A46E RID: 42094 RVA: 0x002B9534 File Offset: 0x002B7734
		public string Title
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

		// Token: 0x0600A46F RID: 42095 RVA: 0x002B956C File Offset: 0x002B776C
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600A470 RID: 42096 RVA: 0x002B957C File Offset: 0x002B777C
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x04005512 RID: 21778
		private Table __p;
	}
}

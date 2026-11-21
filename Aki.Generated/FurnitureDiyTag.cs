using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DBC RID: 3516
	public struct FurnitureDiyTag : IFlatbufferObject
	{
		// Token: 0x170014D9 RID: 5337
		// (get) Token: 0x06007DAF RID: 32175 RVA: 0x0026398C File Offset: 0x00261B8C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007DB0 RID: 32176 RVA: 0x00263999 File Offset: 0x00261B99
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007DB1 RID: 32177 RVA: 0x002639A0 File Offset: 0x00261BA0
		public static FurnitureDiyTag GetRootAsFurnitureDiyTag(ByteBuffer _bb)
		{
			return FurnitureDiyTag.GetRootAsFurnitureDiyTag(_bb, default(FurnitureDiyTag));
		}

		// Token: 0x06007DB2 RID: 32178 RVA: 0x002639BC File Offset: 0x00261BBC
		public static FurnitureDiyTag GetRootAsFurnitureDiyTag(ByteBuffer _bb, FurnitureDiyTag obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007DB3 RID: 32179 RVA: 0x002639D9 File Offset: 0x00261BD9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007DB4 RID: 32180 RVA: 0x002639E8 File Offset: 0x00261BE8
		public FurnitureDiyTag __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170014DA RID: 5338
		// (get) Token: 0x06007DB5 RID: 32181 RVA: 0x002639F8 File Offset: 0x00261BF8
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

		// Token: 0x170014DB RID: 5339
		// (get) Token: 0x06007DB6 RID: 32182 RVA: 0x00263A34 File Offset: 0x00261C34
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

		// Token: 0x06007DB7 RID: 32183 RVA: 0x00263A6B File Offset: 0x00261C6B
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06007DB8 RID: 32184 RVA: 0x00263A7A File Offset: 0x00261C7A
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170014DC RID: 5340
		// (get) Token: 0x06007DB9 RID: 32185 RVA: 0x00263A94 File Offset: 0x00261C94
		public string EmptyIcon
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

		// Token: 0x06007DBA RID: 32186 RVA: 0x00263ACB File Offset: 0x00261CCB
		public Span<byte> GetEmptyIconBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06007DBB RID: 32187 RVA: 0x00263ADA File Offset: 0x00261CDA
		public byte[] GetEmptyIconArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170014DD RID: 5341
		// (get) Token: 0x06007DBC RID: 32188 RVA: 0x00263AF4 File Offset: 0x00261CF4
		public string OccupiedIcon
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

		// Token: 0x06007DBD RID: 32189 RVA: 0x00263B2C File Offset: 0x00261D2C
		public Span<byte> GetOccupiedIconBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06007DBE RID: 32190 RVA: 0x00263B3C File Offset: 0x00261D3C
		public byte[] GetOccupiedIconArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170014DE RID: 5342
		// (get) Token: 0x06007DBF RID: 32191 RVA: 0x00263B54 File Offset: 0x00261D54
		public bool CanUnPlace
		{
			get
			{
				int num = this.__p.__offset(12);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0400532C RID: 21292
		private Table __p;
	}
}

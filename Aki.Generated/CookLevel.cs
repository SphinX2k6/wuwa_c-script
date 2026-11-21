using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C82 RID: 3202
	public struct CookLevel : IFlatbufferObject
	{
		// Token: 0x170009AC RID: 2476
		// (get) Token: 0x06005F41 RID: 24385 RVA: 0x0021F8AD File Offset: 0x0021DAAD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005F42 RID: 24386 RVA: 0x0021F8BA File Offset: 0x0021DABA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005F43 RID: 24387 RVA: 0x0021F8C4 File Offset: 0x0021DAC4
		public static CookLevel GetRootAsCookLevel(ByteBuffer _bb)
		{
			return CookLevel.GetRootAsCookLevel(_bb, default(CookLevel));
		}

		// Token: 0x06005F44 RID: 24388 RVA: 0x0021F8E0 File Offset: 0x0021DAE0
		public static CookLevel GetRootAsCookLevel(ByteBuffer _bb, CookLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005F45 RID: 24389 RVA: 0x0021F8FD File Offset: 0x0021DAFD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005F46 RID: 24390 RVA: 0x0021F90C File Offset: 0x0021DB0C
		public CookLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170009AD RID: 2477
		// (get) Token: 0x06005F47 RID: 24391 RVA: 0x0021F91C File Offset: 0x0021DB1C
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

		// Token: 0x170009AE RID: 2478
		// (get) Token: 0x06005F48 RID: 24392 RVA: 0x0021F958 File Offset: 0x0021DB58
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

		// Token: 0x06005F49 RID: 24393 RVA: 0x0021F98F File Offset: 0x0021DB8F
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06005F4A RID: 24394 RVA: 0x0021F99E File Offset: 0x0021DB9E
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170009AF RID: 2479
		// (get) Token: 0x06005F4B RID: 24395 RVA: 0x0021F9B8 File Offset: 0x0021DBB8
		public int Completeness
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

		// Token: 0x170009B0 RID: 2480
		// (get) Token: 0x06005F4C RID: 24396 RVA: 0x0021F9F4 File Offset: 0x0021DBF4
		public int Effect
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

		// Token: 0x170009B1 RID: 2481
		// (get) Token: 0x06005F4D RID: 24397 RVA: 0x0021FA34 File Offset: 0x0021DC34
		public string AttributesDescription
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

		// Token: 0x06005F4E RID: 24398 RVA: 0x0021FA6C File Offset: 0x0021DC6C
		public Span<byte> GetAttributesDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06005F4F RID: 24399 RVA: 0x0021FA7C File Offset: 0x0021DC7C
		public byte[] GetAttributesDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170009B2 RID: 2482
		// (get) Token: 0x06005F50 RID: 24400 RVA: 0x0021FA94 File Offset: 0x0021DC94
		public int DropIds
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

		// Token: 0x040051A4 RID: 20900
		private Table __p;
	}
}

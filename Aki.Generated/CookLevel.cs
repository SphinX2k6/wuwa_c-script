using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BA0 RID: 2976
	public struct CookLevel : IFlatbufferObject
	{
		// Token: 0x17000966 RID: 2406
		// (get) Token: 0x06005968 RID: 22888 RVA: 0x001FFB2D File Offset: 0x001FDD2D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005969 RID: 22889 RVA: 0x001FFB3A File Offset: 0x001FDD3A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600596A RID: 22890 RVA: 0x001FFB44 File Offset: 0x001FDD44
		public static CookLevel GetRootAsCookLevel(ByteBuffer _bb)
		{
			return CookLevel.GetRootAsCookLevel(_bb, default(CookLevel));
		}

		// Token: 0x0600596B RID: 22891 RVA: 0x001FFB60 File Offset: 0x001FDD60
		public static CookLevel GetRootAsCookLevel(ByteBuffer _bb, CookLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600596C RID: 22892 RVA: 0x001FFB7D File Offset: 0x001FDD7D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600596D RID: 22893 RVA: 0x001FFB8C File Offset: 0x001FDD8C
		public CookLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000967 RID: 2407
		// (get) Token: 0x0600596E RID: 22894 RVA: 0x001FFB9C File Offset: 0x001FDD9C
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

		// Token: 0x17000968 RID: 2408
		// (get) Token: 0x0600596F RID: 22895 RVA: 0x001FFBD8 File Offset: 0x001FDDD8
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

		// Token: 0x06005970 RID: 22896 RVA: 0x001FFC0F File Offset: 0x001FDE0F
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06005971 RID: 22897 RVA: 0x001FFC1E File Offset: 0x001FDE1E
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000969 RID: 2409
		// (get) Token: 0x06005972 RID: 22898 RVA: 0x001FFC38 File Offset: 0x001FDE38
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

		// Token: 0x1700096A RID: 2410
		// (get) Token: 0x06005973 RID: 22899 RVA: 0x001FFC74 File Offset: 0x001FDE74
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

		// Token: 0x1700096B RID: 2411
		// (get) Token: 0x06005974 RID: 22900 RVA: 0x001FFCB4 File Offset: 0x001FDEB4
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

		// Token: 0x06005975 RID: 22901 RVA: 0x001FFCEC File Offset: 0x001FDEEC
		public Span<byte> GetAttributesDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06005976 RID: 22902 RVA: 0x001FFCFC File Offset: 0x001FDEFC
		public byte[] GetAttributesDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x1700096C RID: 2412
		// (get) Token: 0x06005977 RID: 22903 RVA: 0x001FFD14 File Offset: 0x001FDF14
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

		// Token: 0x04004BC2 RID: 19394
		private Table __p;
	}
}

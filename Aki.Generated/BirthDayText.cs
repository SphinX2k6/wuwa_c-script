using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B33 RID: 2867
	public struct BirthDayText : IFlatbufferObject
	{
		// Token: 0x1700052F RID: 1327
		// (get) Token: 0x06004D5A RID: 19802 RVA: 0x001E3DD4 File Offset: 0x001E1FD4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004D5B RID: 19803 RVA: 0x001E3DE1 File Offset: 0x001E1FE1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004D5C RID: 19804 RVA: 0x001E3DE8 File Offset: 0x001E1FE8
		public static BirthDayText GetRootAsBirthDayText(ByteBuffer _bb)
		{
			return BirthDayText.GetRootAsBirthDayText(_bb, default(BirthDayText));
		}

		// Token: 0x06004D5D RID: 19805 RVA: 0x001E3E04 File Offset: 0x001E2004
		public static BirthDayText GetRootAsBirthDayText(ByteBuffer _bb, BirthDayText obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004D5E RID: 19806 RVA: 0x001E3E21 File Offset: 0x001E2021
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004D5F RID: 19807 RVA: 0x001E3E30 File Offset: 0x001E2030
		public BirthDayText __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x06004D60 RID: 19808 RVA: 0x001E3E40 File Offset: 0x001E2040
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

		// Token: 0x17000531 RID: 1329
		// (get) Token: 0x06004D61 RID: 19809 RVA: 0x001E3E7C File Offset: 0x001E207C
		public int Date
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

		// Token: 0x17000532 RID: 1330
		// (get) Token: 0x06004D62 RID: 19810 RVA: 0x001E3EB8 File Offset: 0x001E20B8
		public int DateType
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

		// Token: 0x17000533 RID: 1331
		// (get) Token: 0x06004D63 RID: 19811 RVA: 0x001E3EF4 File Offset: 0x001E20F4
		public string TextId
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

		// Token: 0x06004D64 RID: 19812 RVA: 0x001E3F2C File Offset: 0x001E212C
		public Span<byte> GetTextIdBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06004D65 RID: 19813 RVA: 0x001E3F3C File Offset: 0x001E213C
		public byte[] GetTextIdArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x04004B2E RID: 19246
		private Table __p;
	}
}

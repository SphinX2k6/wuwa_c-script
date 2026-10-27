using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BC6 RID: 3014
	public struct DangoBrawlLevel : IFlatbufferObject
	{
		// Token: 0x17000B24 RID: 2852
		// (get) Token: 0x06005E29 RID: 24105 RVA: 0x0020AA81 File Offset: 0x00208C81
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005E2A RID: 24106 RVA: 0x0020AA8E File Offset: 0x00208C8E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005E2B RID: 24107 RVA: 0x0020AA98 File Offset: 0x00208C98
		public static DangoBrawlLevel GetRootAsDangoBrawlLevel(ByteBuffer _bb)
		{
			return DangoBrawlLevel.GetRootAsDangoBrawlLevel(_bb, default(DangoBrawlLevel));
		}

		// Token: 0x06005E2C RID: 24108 RVA: 0x0020AAB4 File Offset: 0x00208CB4
		public static DangoBrawlLevel GetRootAsDangoBrawlLevel(ByteBuffer _bb, DangoBrawlLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005E2D RID: 24109 RVA: 0x0020AAD1 File Offset: 0x00208CD1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005E2E RID: 24110 RVA: 0x0020AAE0 File Offset: 0x00208CE0
		public DangoBrawlLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000B25 RID: 2853
		// (get) Token: 0x06005E2F RID: 24111 RVA: 0x0020AAF0 File Offset: 0x00208CF0
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

		// Token: 0x17000B26 RID: 2854
		// (get) Token: 0x06005E30 RID: 24112 RVA: 0x0020AB2C File Offset: 0x00208D2C
		public string ItemList
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

		// Token: 0x06005E31 RID: 24113 RVA: 0x0020AB63 File Offset: 0x00208D63
		public Span<byte> GetItemListBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06005E32 RID: 24114 RVA: 0x0020AB72 File Offset: 0x00208D72
		public byte[] GetItemListArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x04004BEF RID: 19439
		private Table __p;
	}
}

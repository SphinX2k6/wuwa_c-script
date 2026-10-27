using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DB5 RID: 3509
	public struct KurotatoTag : IFlatbufferObject
	{
		// Token: 0x17001C38 RID: 7224
		// (get) Token: 0x06008BD8 RID: 35800 RVA: 0x00272EDA File Offset: 0x002710DA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008BD9 RID: 35801 RVA: 0x00272EE7 File Offset: 0x002710E7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008BDA RID: 35802 RVA: 0x00272EF0 File Offset: 0x002710F0
		public static KurotatoTag GetRootAsKurotatoTag(ByteBuffer _bb)
		{
			return KurotatoTag.GetRootAsKurotatoTag(_bb, default(KurotatoTag));
		}

		// Token: 0x06008BDB RID: 35803 RVA: 0x00272F0C File Offset: 0x0027110C
		public static KurotatoTag GetRootAsKurotatoTag(ByteBuffer _bb, KurotatoTag obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008BDC RID: 35804 RVA: 0x00272F29 File Offset: 0x00271129
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008BDD RID: 35805 RVA: 0x00272F38 File Offset: 0x00271138
		public KurotatoTag __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001C39 RID: 7225
		// (get) Token: 0x06008BDE RID: 35806 RVA: 0x00272F48 File Offset: 0x00271148
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

		// Token: 0x17001C3A RID: 7226
		// (get) Token: 0x06008BDF RID: 35807 RVA: 0x00272F84 File Offset: 0x00271184
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

		// Token: 0x06008BE0 RID: 35808 RVA: 0x00272FBB File Offset: 0x002711BB
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06008BE1 RID: 35809 RVA: 0x00272FCA File Offset: 0x002711CA
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001C3B RID: 7227
		// (get) Token: 0x06008BE2 RID: 35810 RVA: 0x00272FE4 File Offset: 0x002711E4
		public string Desc
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

		// Token: 0x06008BE3 RID: 35811 RVA: 0x0027301B File Offset: 0x0027121B
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06008BE4 RID: 35812 RVA: 0x0027302A File Offset: 0x0027122A
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001C3C RID: 7228
		// (get) Token: 0x06008BE5 RID: 35813 RVA: 0x00273044 File Offset: 0x00271244
		public string Icon
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

		// Token: 0x06008BE6 RID: 35814 RVA: 0x0027307C File Offset: 0x0027127C
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06008BE7 RID: 35815 RVA: 0x0027308C File Offset: 0x0027128C
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x04004E49 RID: 20041
		private Table __p;
	}
}

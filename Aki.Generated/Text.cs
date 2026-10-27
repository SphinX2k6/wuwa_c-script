using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200112B RID: 4395
	public struct Text : IFlatbufferObject
	{
		// Token: 0x17003A63 RID: 14947
		// (get) Token: 0x0600DEA6 RID: 56998 RVA: 0x0032D6B8 File Offset: 0x0032B8B8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DEA7 RID: 56999 RVA: 0x0032D6C5 File Offset: 0x0032B8C5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DEA8 RID: 57000 RVA: 0x0032D6CC File Offset: 0x0032B8CC
		public static Text GetRootAsText(ByteBuffer _bb)
		{
			return Text.GetRootAsText(_bb, default(Text));
		}

		// Token: 0x0600DEA9 RID: 57001 RVA: 0x0032D6E8 File Offset: 0x0032B8E8
		public static Text GetRootAsText(ByteBuffer _bb, Text obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DEAA RID: 57002 RVA: 0x0032D705 File Offset: 0x0032B905
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DEAB RID: 57003 RVA: 0x0032D714 File Offset: 0x0032B914
		public Text __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003A64 RID: 14948
		// (get) Token: 0x0600DEAC RID: 57004 RVA: 0x0032D724 File Offset: 0x0032B924
		public string Id
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

		// Token: 0x0600DEAD RID: 57005 RVA: 0x0032D75B File Offset: 0x0032B95B
		public Span<byte> GetIdBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0600DEAE RID: 57006 RVA: 0x0032D76A File Offset: 0x0032B96A
		public byte[] GetIdArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x17003A65 RID: 14949
		// (get) Token: 0x0600DEAF RID: 57007 RVA: 0x0032D784 File Offset: 0x0032B984
		public string TextContent
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

		// Token: 0x0600DEB0 RID: 57008 RVA: 0x0032D7BB File Offset: 0x0032B9BB
		public Span<byte> GetTextContentBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600DEB1 RID: 57009 RVA: 0x0032D7CA File Offset: 0x0032B9CA
		public byte[] GetTextContentArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x04005269 RID: 21097
		private Table __p;
	}
}

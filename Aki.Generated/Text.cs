using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001261 RID: 4705
	public struct Text : IFlatbufferObject
	{
		// Token: 0x17003DC7 RID: 15815
		// (get) Token: 0x0600EC14 RID: 60436 RVA: 0x00358C8C File Offset: 0x00356E8C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600EC15 RID: 60437 RVA: 0x00358C99 File Offset: 0x00356E99
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600EC16 RID: 60438 RVA: 0x00358CA0 File Offset: 0x00356EA0
		public static Text GetRootAsText(ByteBuffer _bb)
		{
			return Text.GetRootAsText(_bb, default(Text));
		}

		// Token: 0x0600EC17 RID: 60439 RVA: 0x00358CBC File Offset: 0x00356EBC
		public static Text GetRootAsText(ByteBuffer _bb, Text obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600EC18 RID: 60440 RVA: 0x00358CD9 File Offset: 0x00356ED9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600EC19 RID: 60441 RVA: 0x00358CE8 File Offset: 0x00356EE8
		public Text __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003DC8 RID: 15816
		// (get) Token: 0x0600EC1A RID: 60442 RVA: 0x00358CF8 File Offset: 0x00356EF8
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

		// Token: 0x0600EC1B RID: 60443 RVA: 0x00358D2F File Offset: 0x00356F2F
		public Span<byte> GetIdBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0600EC1C RID: 60444 RVA: 0x00358D3E File Offset: 0x00356F3E
		public byte[] GetIdArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x17003DC9 RID: 15817
		// (get) Token: 0x0600EC1D RID: 60445 RVA: 0x00358D58 File Offset: 0x00356F58
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

		// Token: 0x0600EC1E RID: 60446 RVA: 0x00358D8F File Offset: 0x00356F8F
		public Span<byte> GetTextContentBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600EC1F RID: 60447 RVA: 0x00358D9E File Offset: 0x00356F9E
		public byte[] GetTextContentArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x040058AC RID: 22700
		private Table __p;
	}
}

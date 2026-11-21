using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E95 RID: 3733
	public struct KurotatoResAward : IFlatbufferObject
	{
		// Token: 0x17001C78 RID: 7288
		// (get) Token: 0x06009185 RID: 37253 RVA: 0x0029085C File Offset: 0x0028EA5C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009186 RID: 37254 RVA: 0x00290869 File Offset: 0x0028EA69
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009187 RID: 37255 RVA: 0x00290870 File Offset: 0x0028EA70
		public static KurotatoResAward GetRootAsKurotatoResAward(ByteBuffer _bb)
		{
			return KurotatoResAward.GetRootAsKurotatoResAward(_bb, default(KurotatoResAward));
		}

		// Token: 0x06009188 RID: 37256 RVA: 0x0029088C File Offset: 0x0028EA8C
		public static KurotatoResAward GetRootAsKurotatoResAward(ByteBuffer _bb, KurotatoResAward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009189 RID: 37257 RVA: 0x002908A9 File Offset: 0x0028EAA9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600918A RID: 37258 RVA: 0x002908B8 File Offset: 0x0028EAB8
		public KurotatoResAward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001C79 RID: 7289
		// (get) Token: 0x0600918B RID: 37259 RVA: 0x002908C8 File Offset: 0x0028EAC8
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

		// Token: 0x17001C7A RID: 7290
		// (get) Token: 0x0600918C RID: 37260 RVA: 0x00290904 File Offset: 0x0028EB04
		public int ActivityId
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

		// Token: 0x17001C7B RID: 7291
		// (get) Token: 0x0600918D RID: 37261 RVA: 0x00290940 File Offset: 0x0028EB40
		public int AwardType
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

		// Token: 0x17001C7C RID: 7292
		// (get) Token: 0x0600918E RID: 37262 RVA: 0x0029097C File Offset: 0x0028EB7C
		public int DropId
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

		// Token: 0x17001C7D RID: 7293
		// (get) Token: 0x0600918F RID: 37263 RVA: 0x002909BC File Offset: 0x0028EBBC
		public int TabId
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001C7E RID: 7294
		// (get) Token: 0x06009190 RID: 37264 RVA: 0x002909FC File Offset: 0x0028EBFC
		public string Desc
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009191 RID: 37265 RVA: 0x00290A34 File Offset: 0x0028EC34
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06009192 RID: 37266 RVA: 0x00290A44 File Offset: 0x0028EC44
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x04005427 RID: 21543
		private Table __p;
	}
}

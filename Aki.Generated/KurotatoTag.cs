using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E9A RID: 3738
	public struct KurotatoTag : IFlatbufferObject
	{
		// Token: 0x17001C9C RID: 7324
		// (get) Token: 0x060091F4 RID: 37364 RVA: 0x002917BE File Offset: 0x0028F9BE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060091F5 RID: 37365 RVA: 0x002917CB File Offset: 0x0028F9CB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060091F6 RID: 37366 RVA: 0x002917D4 File Offset: 0x0028F9D4
		public static KurotatoTag GetRootAsKurotatoTag(ByteBuffer _bb)
		{
			return KurotatoTag.GetRootAsKurotatoTag(_bb, default(KurotatoTag));
		}

		// Token: 0x060091F7 RID: 37367 RVA: 0x002917F0 File Offset: 0x0028F9F0
		public static KurotatoTag GetRootAsKurotatoTag(ByteBuffer _bb, KurotatoTag obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060091F8 RID: 37368 RVA: 0x0029180D File Offset: 0x0028FA0D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060091F9 RID: 37369 RVA: 0x0029181C File Offset: 0x0028FA1C
		public KurotatoTag __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001C9D RID: 7325
		// (get) Token: 0x060091FA RID: 37370 RVA: 0x0029182C File Offset: 0x0028FA2C
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

		// Token: 0x17001C9E RID: 7326
		// (get) Token: 0x060091FB RID: 37371 RVA: 0x00291868 File Offset: 0x0028FA68
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

		// Token: 0x060091FC RID: 37372 RVA: 0x0029189F File Offset: 0x0028FA9F
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060091FD RID: 37373 RVA: 0x002918AE File Offset: 0x0028FAAE
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001C9F RID: 7327
		// (get) Token: 0x060091FE RID: 37374 RVA: 0x002918C8 File Offset: 0x0028FAC8
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

		// Token: 0x060091FF RID: 37375 RVA: 0x002918FF File Offset: 0x0028FAFF
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06009200 RID: 37376 RVA: 0x0029190E File Offset: 0x0028FB0E
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001CA0 RID: 7328
		// (get) Token: 0x06009201 RID: 37377 RVA: 0x00291928 File Offset: 0x0028FB28
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

		// Token: 0x06009202 RID: 37378 RVA: 0x00291960 File Offset: 0x0028FB60
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06009203 RID: 37379 RVA: 0x00291970 File Offset: 0x0028FB70
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x0400542E RID: 21550
		private Table __p;
	}
}

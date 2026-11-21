using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E65 RID: 3685
	public struct ItemIconTag : IFlatbufferObject
	{
		// Token: 0x17001A68 RID: 6760
		// (get) Token: 0x06008C88 RID: 35976 RVA: 0x0028427D File Offset: 0x0028247D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008C89 RID: 35977 RVA: 0x0028428A File Offset: 0x0028248A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008C8A RID: 35978 RVA: 0x00284294 File Offset: 0x00282494
		public static ItemIconTag GetRootAsItemIconTag(ByteBuffer _bb)
		{
			return ItemIconTag.GetRootAsItemIconTag(_bb, default(ItemIconTag));
		}

		// Token: 0x06008C8B RID: 35979 RVA: 0x002842B0 File Offset: 0x002824B0
		public static ItemIconTag GetRootAsItemIconTag(ByteBuffer _bb, ItemIconTag obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008C8C RID: 35980 RVA: 0x002842CD File Offset: 0x002824CD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008C8D RID: 35981 RVA: 0x002842DC File Offset: 0x002824DC
		public ItemIconTag __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001A69 RID: 6761
		// (get) Token: 0x06008C8E RID: 35982 RVA: 0x002842EC File Offset: 0x002824EC
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

		// Token: 0x06008C8F RID: 35983 RVA: 0x00284323 File Offset: 0x00282523
		public Span<byte> GetIdBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06008C90 RID: 35984 RVA: 0x00284332 File Offset: 0x00282532
		public byte[] GetIdArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x17001A6A RID: 6762
		// (get) Token: 0x06008C91 RID: 35985 RVA: 0x0028434C File Offset: 0x0028254C
		public string ConfigParam
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

		// Token: 0x06008C92 RID: 35986 RVA: 0x00284383 File Offset: 0x00282583
		public Span<byte> GetConfigParamBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06008C93 RID: 35987 RVA: 0x00284392 File Offset: 0x00282592
		public byte[] GetConfigParamArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x040053EE RID: 21486
		private Table __p;
	}
}

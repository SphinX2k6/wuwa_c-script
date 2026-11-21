using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D1D RID: 3357
	public struct EntranceIconTag : IFlatbufferObject
	{
		// Token: 0x17000F9A RID: 3994
		// (get) Token: 0x06006FD5 RID: 28629 RVA: 0x00243C39 File Offset: 0x00241E39
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006FD6 RID: 28630 RVA: 0x00243C46 File Offset: 0x00241E46
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006FD7 RID: 28631 RVA: 0x00243C50 File Offset: 0x00241E50
		public static EntranceIconTag GetRootAsEntranceIconTag(ByteBuffer _bb)
		{
			return EntranceIconTag.GetRootAsEntranceIconTag(_bb, default(EntranceIconTag));
		}

		// Token: 0x06006FD8 RID: 28632 RVA: 0x00243C6C File Offset: 0x00241E6C
		public static EntranceIconTag GetRootAsEntranceIconTag(ByteBuffer _bb, EntranceIconTag obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006FD9 RID: 28633 RVA: 0x00243C89 File Offset: 0x00241E89
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006FDA RID: 28634 RVA: 0x00243C98 File Offset: 0x00241E98
		public EntranceIconTag __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000F9B RID: 3995
		// (get) Token: 0x06006FDB RID: 28635 RVA: 0x00243CA8 File Offset: 0x00241EA8
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

		// Token: 0x06006FDC RID: 28636 RVA: 0x00243CDF File Offset: 0x00241EDF
		public Span<byte> GetIdBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06006FDD RID: 28637 RVA: 0x00243CEE File Offset: 0x00241EEE
		public byte[] GetIdArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x17000F9C RID: 3996
		// (get) Token: 0x06006FDE RID: 28638 RVA: 0x00243D08 File Offset: 0x00241F08
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

		// Token: 0x06006FDF RID: 28639 RVA: 0x00243D3F File Offset: 0x00241F3F
		public Span<byte> GetConfigParamBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06006FE0 RID: 28640 RVA: 0x00243D4E File Offset: 0x00241F4E
		public byte[] GetConfigParamArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x0400525D RID: 21085
		private Table __p;
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C3A RID: 3130
	public struct EntranceIconTag : IFlatbufferObject
	{
		// Token: 0x17000F41 RID: 3905
		// (get) Token: 0x060069D3 RID: 27091 RVA: 0x002248F1 File Offset: 0x00222AF1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060069D4 RID: 27092 RVA: 0x002248FE File Offset: 0x00222AFE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060069D5 RID: 27093 RVA: 0x00224908 File Offset: 0x00222B08
		public static EntranceIconTag GetRootAsEntranceIconTag(ByteBuffer _bb)
		{
			return EntranceIconTag.GetRootAsEntranceIconTag(_bb, default(EntranceIconTag));
		}

		// Token: 0x060069D6 RID: 27094 RVA: 0x00224924 File Offset: 0x00222B24
		public static EntranceIconTag GetRootAsEntranceIconTag(ByteBuffer _bb, EntranceIconTag obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060069D7 RID: 27095 RVA: 0x00224941 File Offset: 0x00222B41
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060069D8 RID: 27096 RVA: 0x00224950 File Offset: 0x00222B50
		public EntranceIconTag __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000F42 RID: 3906
		// (get) Token: 0x060069D9 RID: 27097 RVA: 0x00224960 File Offset: 0x00222B60
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

		// Token: 0x060069DA RID: 27098 RVA: 0x00224997 File Offset: 0x00222B97
		public Span<byte> GetIdBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x060069DB RID: 27099 RVA: 0x002249A6 File Offset: 0x00222BA6
		public byte[] GetIdArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x17000F43 RID: 3907
		// (get) Token: 0x060069DC RID: 27100 RVA: 0x002249C0 File Offset: 0x00222BC0
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

		// Token: 0x060069DD RID: 27101 RVA: 0x002249F7 File Offset: 0x00222BF7
		public Span<byte> GetConfigParamBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060069DE RID: 27102 RVA: 0x00224A06 File Offset: 0x00222C06
		public byte[] GetConfigParamArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x04004C7A RID: 19578
		private Table __p;
	}
}

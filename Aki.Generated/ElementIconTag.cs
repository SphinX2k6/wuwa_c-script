using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C26 RID: 3110
	public struct ElementIconTag : IFlatbufferObject
	{
		// Token: 0x17000EAB RID: 3755
		// (get) Token: 0x060067E3 RID: 26595 RVA: 0x00220AF0 File Offset: 0x0021ECF0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060067E4 RID: 26596 RVA: 0x00220AFD File Offset: 0x0021ECFD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060067E5 RID: 26597 RVA: 0x00220B04 File Offset: 0x0021ED04
		public static ElementIconTag GetRootAsElementIconTag(ByteBuffer _bb)
		{
			return ElementIconTag.GetRootAsElementIconTag(_bb, default(ElementIconTag));
		}

		// Token: 0x060067E6 RID: 26598 RVA: 0x00220B20 File Offset: 0x0021ED20
		public static ElementIconTag GetRootAsElementIconTag(ByteBuffer _bb, ElementIconTag obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060067E7 RID: 26599 RVA: 0x00220B3D File Offset: 0x0021ED3D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060067E8 RID: 26600 RVA: 0x00220B4C File Offset: 0x0021ED4C
		public ElementIconTag __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000EAC RID: 3756
		// (get) Token: 0x060067E9 RID: 26601 RVA: 0x00220B5C File Offset: 0x0021ED5C
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

		// Token: 0x060067EA RID: 26602 RVA: 0x00220B93 File Offset: 0x0021ED93
		public Span<byte> GetIdBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x060067EB RID: 26603 RVA: 0x00220BA2 File Offset: 0x0021EDA2
		public byte[] GetIdArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x17000EAD RID: 3757
		// (get) Token: 0x060067EC RID: 26604 RVA: 0x00220BBC File Offset: 0x0021EDBC
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

		// Token: 0x060067ED RID: 26605 RVA: 0x00220BF3 File Offset: 0x0021EDF3
		public Span<byte> GetConfigParamBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060067EE RID: 26606 RVA: 0x00220C02 File Offset: 0x0021EE02
		public byte[] GetConfigParamArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x04004C66 RID: 19558
		private Table __p;
	}
}

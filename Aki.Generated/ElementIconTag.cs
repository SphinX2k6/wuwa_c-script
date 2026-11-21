using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D09 RID: 3337
	public struct ElementIconTag : IFlatbufferObject
	{
		// Token: 0x17000EFF RID: 3839
		// (get) Token: 0x06006DD6 RID: 28118 RVA: 0x0023FE94 File Offset: 0x0023E094
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006DD7 RID: 28119 RVA: 0x0023FEA1 File Offset: 0x0023E0A1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006DD8 RID: 28120 RVA: 0x0023FEA8 File Offset: 0x0023E0A8
		public static ElementIconTag GetRootAsElementIconTag(ByteBuffer _bb)
		{
			return ElementIconTag.GetRootAsElementIconTag(_bb, default(ElementIconTag));
		}

		// Token: 0x06006DD9 RID: 28121 RVA: 0x0023FEC4 File Offset: 0x0023E0C4
		public static ElementIconTag GetRootAsElementIconTag(ByteBuffer _bb, ElementIconTag obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006DDA RID: 28122 RVA: 0x0023FEE1 File Offset: 0x0023E0E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006DDB RID: 28123 RVA: 0x0023FEF0 File Offset: 0x0023E0F0
		public ElementIconTag __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000F00 RID: 3840
		// (get) Token: 0x06006DDC RID: 28124 RVA: 0x0023FF00 File Offset: 0x0023E100
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

		// Token: 0x06006DDD RID: 28125 RVA: 0x0023FF37 File Offset: 0x0023E137
		public Span<byte> GetIdBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06006DDE RID: 28126 RVA: 0x0023FF46 File Offset: 0x0023E146
		public byte[] GetIdArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x17000F01 RID: 3841
		// (get) Token: 0x06006DDF RID: 28127 RVA: 0x0023FF60 File Offset: 0x0023E160
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

		// Token: 0x06006DE0 RID: 28128 RVA: 0x0023FF97 File Offset: 0x0023E197
		public Span<byte> GetConfigParamBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06006DE1 RID: 28129 RVA: 0x0023FFA6 File Offset: 0x0023E1A6
		public byte[] GetConfigParamArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x04005249 RID: 21065
		private Table __p;
	}
}

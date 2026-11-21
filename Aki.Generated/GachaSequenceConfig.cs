using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DC6 RID: 3526
	public struct GachaSequenceConfig : IFlatbufferObject
	{
		// Token: 0x17001511 RID: 5393
		// (get) Token: 0x06007E3E RID: 32318 RVA: 0x00264CC6 File Offset: 0x00262EC6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007E3F RID: 32319 RVA: 0x00264CD3 File Offset: 0x00262ED3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007E40 RID: 32320 RVA: 0x00264CDC File Offset: 0x00262EDC
		public static GachaSequenceConfig GetRootAsGachaSequenceConfig(ByteBuffer _bb)
		{
			return GachaSequenceConfig.GetRootAsGachaSequenceConfig(_bb, default(GachaSequenceConfig));
		}

		// Token: 0x06007E41 RID: 32321 RVA: 0x00264CF8 File Offset: 0x00262EF8
		public static GachaSequenceConfig GetRootAsGachaSequenceConfig(ByteBuffer _bb, GachaSequenceConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007E42 RID: 32322 RVA: 0x00264D15 File Offset: 0x00262F15
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007E43 RID: 32323 RVA: 0x00264D24 File Offset: 0x00262F24
		public GachaSequenceConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001512 RID: 5394
		// (get) Token: 0x06007E44 RID: 32324 RVA: 0x00264D34 File Offset: 0x00262F34
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

		// Token: 0x17001513 RID: 5395
		// (get) Token: 0x06007E45 RID: 32325 RVA: 0x00264D70 File Offset: 0x00262F70
		public string SequencePath
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

		// Token: 0x06007E46 RID: 32326 RVA: 0x00264DA7 File Offset: 0x00262FA7
		public Span<byte> GetSequencePathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06007E47 RID: 32327 RVA: 0x00264DB6 File Offset: 0x00262FB6
		public byte[] GetSequencePathArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x04005337 RID: 21303
		private Table __p;
	}
}

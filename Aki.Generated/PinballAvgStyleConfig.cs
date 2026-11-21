using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001006 RID: 4102
	public struct PinballAvgStyleConfig : IFlatbufferObject
	{
		// Token: 0x17002957 RID: 10583
		// (get) Token: 0x0600B422 RID: 46114 RVA: 0x002DC71D File Offset: 0x002DA91D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B423 RID: 46115 RVA: 0x002DC72A File Offset: 0x002DA92A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B424 RID: 46116 RVA: 0x002DC734 File Offset: 0x002DA934
		public static PinballAvgStyleConfig GetRootAsPinballAvgStyleConfig(ByteBuffer _bb)
		{
			return PinballAvgStyleConfig.GetRootAsPinballAvgStyleConfig(_bb, default(PinballAvgStyleConfig));
		}

		// Token: 0x0600B425 RID: 46117 RVA: 0x002DC750 File Offset: 0x002DA950
		public static PinballAvgStyleConfig GetRootAsPinballAvgStyleConfig(ByteBuffer _bb, PinballAvgStyleConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B426 RID: 46118 RVA: 0x002DC76D File Offset: 0x002DA96D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B427 RID: 46119 RVA: 0x002DC77C File Offset: 0x002DA97C
		public PinballAvgStyleConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002958 RID: 10584
		// (get) Token: 0x0600B428 RID: 46120 RVA: 0x002DC78C File Offset: 0x002DA98C
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

		// Token: 0x17002959 RID: 10585
		// (get) Token: 0x0600B429 RID: 46121 RVA: 0x002DC7C8 File Offset: 0x002DA9C8
		public string BgTexture
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

		// Token: 0x0600B42A RID: 46122 RVA: 0x002DC7FF File Offset: 0x002DA9FF
		public Span<byte> GetBgTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600B42B RID: 46123 RVA: 0x002DC80E File Offset: 0x002DAA0E
		public byte[] GetBgTextureArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700295A RID: 10586
		// (get) Token: 0x0600B42C RID: 46124 RVA: 0x002DC828 File Offset: 0x002DAA28
		public string DecorationTexture
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

		// Token: 0x0600B42D RID: 46125 RVA: 0x002DC85F File Offset: 0x002DAA5F
		public Span<byte> GetDecorationTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600B42E RID: 46126 RVA: 0x002DC86E File Offset: 0x002DAA6E
		public byte[] GetDecorationTextureArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x040055CF RID: 21967
		private Table __p;
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D03 RID: 3331
	public struct EffectConfig : IFlatbufferObject
	{
		// Token: 0x17000EDF RID: 3807
		// (get) Token: 0x06006D7B RID: 28027 RVA: 0x0023F3BD File Offset: 0x0023D5BD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006D7C RID: 28028 RVA: 0x0023F3CA File Offset: 0x0023D5CA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006D7D RID: 28029 RVA: 0x0023F3D4 File Offset: 0x0023D5D4
		public static EffectConfig GetRootAsEffectConfig(ByteBuffer _bb)
		{
			return EffectConfig.GetRootAsEffectConfig(_bb, default(EffectConfig));
		}

		// Token: 0x06006D7E RID: 28030 RVA: 0x0023F3F0 File Offset: 0x0023D5F0
		public static EffectConfig GetRootAsEffectConfig(ByteBuffer _bb, EffectConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006D7F RID: 28031 RVA: 0x0023F40D File Offset: 0x0023D60D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006D80 RID: 28032 RVA: 0x0023F41C File Offset: 0x0023D61C
		public EffectConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000EE0 RID: 3808
		// (get) Token: 0x06006D81 RID: 28033 RVA: 0x0023F42C File Offset: 0x0023D62C
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

		// Token: 0x06006D82 RID: 28034 RVA: 0x0023F463 File Offset: 0x0023D663
		public Span<byte> GetIdBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06006D83 RID: 28035 RVA: 0x0023F472 File Offset: 0x0023D672
		public byte[] GetIdArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x17000EE1 RID: 3809
		// (get) Token: 0x06006D84 RID: 28036 RVA: 0x0023F48C File Offset: 0x0023D68C
		public string Path
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

		// Token: 0x06006D85 RID: 28037 RVA: 0x0023F4C3 File Offset: 0x0023D6C3
		public Span<byte> GetPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06006D86 RID: 28038 RVA: 0x0023F4D2 File Offset: 0x0023D6D2
		public byte[] GetPathArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x04005243 RID: 21059
		private Table __p;
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D05 RID: 3333
	public struct EffectSave : IFlatbufferObject
	{
		// Token: 0x17000EE7 RID: 3815
		// (get) Token: 0x06006D95 RID: 28053 RVA: 0x0023F690 File Offset: 0x0023D890
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006D96 RID: 28054 RVA: 0x0023F69D File Offset: 0x0023D89D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006D97 RID: 28055 RVA: 0x0023F6A4 File Offset: 0x0023D8A4
		public static EffectSave GetRootAsEffectSave(ByteBuffer _bb)
		{
			return EffectSave.GetRootAsEffectSave(_bb, default(EffectSave));
		}

		// Token: 0x06006D98 RID: 28056 RVA: 0x0023F6C0 File Offset: 0x0023D8C0
		public static EffectSave GetRootAsEffectSave(ByteBuffer _bb, EffectSave obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006D99 RID: 28057 RVA: 0x0023F6DD File Offset: 0x0023D8DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006D9A RID: 28058 RVA: 0x0023F6EC File Offset: 0x0023D8EC
		public EffectSave __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000EE8 RID: 3816
		// (get) Token: 0x06006D9B RID: 28059 RVA: 0x0023F6FC File Offset: 0x0023D8FC
		public int EffectId
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

		// Token: 0x17000EE9 RID: 3817
		// (get) Token: 0x06006D9C RID: 28060 RVA: 0x0023F738 File Offset: 0x0023D938
		public string EffectPath
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

		// Token: 0x06006D9D RID: 28061 RVA: 0x0023F76F File Offset: 0x0023D96F
		public Span<byte> GetEffectPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06006D9E RID: 28062 RVA: 0x0023F77E File Offset: 0x0023D97E
		public byte[] GetEffectPathArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x04005245 RID: 21061
		private Table __p;
	}
}

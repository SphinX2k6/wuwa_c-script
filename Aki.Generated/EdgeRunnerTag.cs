using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D00 RID: 3328
	public struct EdgeRunnerTag : IFlatbufferObject
	{
		// Token: 0x17000ED2 RID: 3794
		// (get) Token: 0x06006D58 RID: 27992 RVA: 0x0023EF81 File Offset: 0x0023D181
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006D59 RID: 27993 RVA: 0x0023EF8E File Offset: 0x0023D18E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006D5A RID: 27994 RVA: 0x0023EF98 File Offset: 0x0023D198
		public static EdgeRunnerTag GetRootAsEdgeRunnerTag(ByteBuffer _bb)
		{
			return EdgeRunnerTag.GetRootAsEdgeRunnerTag(_bb, default(EdgeRunnerTag));
		}

		// Token: 0x06006D5B RID: 27995 RVA: 0x0023EFB4 File Offset: 0x0023D1B4
		public static EdgeRunnerTag GetRootAsEdgeRunnerTag(ByteBuffer _bb, EdgeRunnerTag obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006D5C RID: 27996 RVA: 0x0023EFD1 File Offset: 0x0023D1D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006D5D RID: 27997 RVA: 0x0023EFE0 File Offset: 0x0023D1E0
		public EdgeRunnerTag __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000ED3 RID: 3795
		// (get) Token: 0x06006D5E RID: 27998 RVA: 0x0023EFF0 File Offset: 0x0023D1F0
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

		// Token: 0x17000ED4 RID: 3796
		// (get) Token: 0x06006D5F RID: 27999 RVA: 0x0023F02C File Offset: 0x0023D22C
		public string TextKey
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

		// Token: 0x06006D60 RID: 28000 RVA: 0x0023F063 File Offset: 0x0023D263
		public Span<byte> GetTextKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06006D61 RID: 28001 RVA: 0x0023F072 File Offset: 0x0023D272
		public byte[] GetTextKeyArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x04005240 RID: 21056
		private Table __p;
	}
}

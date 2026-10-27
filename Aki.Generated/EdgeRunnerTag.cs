using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C1D RID: 3101
	public struct EdgeRunnerTag : IFlatbufferObject
	{
		// Token: 0x17000E7E RID: 3710
		// (get) Token: 0x06006765 RID: 26469 RVA: 0x0021FBA5 File Offset: 0x0021DDA5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006766 RID: 26470 RVA: 0x0021FBB2 File Offset: 0x0021DDB2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006767 RID: 26471 RVA: 0x0021FBBC File Offset: 0x0021DDBC
		public static EdgeRunnerTag GetRootAsEdgeRunnerTag(ByteBuffer _bb)
		{
			return EdgeRunnerTag.GetRootAsEdgeRunnerTag(_bb, default(EdgeRunnerTag));
		}

		// Token: 0x06006768 RID: 26472 RVA: 0x0021FBD8 File Offset: 0x0021DDD8
		public static EdgeRunnerTag GetRootAsEdgeRunnerTag(ByteBuffer _bb, EdgeRunnerTag obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006769 RID: 26473 RVA: 0x0021FBF5 File Offset: 0x0021DDF5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600676A RID: 26474 RVA: 0x0021FC04 File Offset: 0x0021DE04
		public EdgeRunnerTag __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000E7F RID: 3711
		// (get) Token: 0x0600676B RID: 26475 RVA: 0x0021FC14 File Offset: 0x0021DE14
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

		// Token: 0x17000E80 RID: 3712
		// (get) Token: 0x0600676C RID: 26476 RVA: 0x0021FC50 File Offset: 0x0021DE50
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

		// Token: 0x0600676D RID: 26477 RVA: 0x0021FC87 File Offset: 0x0021DE87
		public Span<byte> GetTextKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600676E RID: 26478 RVA: 0x0021FC96 File Offset: 0x0021DE96
		public byte[] GetTextKeyArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x04004C5D RID: 19549
		private Table __p;
	}
}

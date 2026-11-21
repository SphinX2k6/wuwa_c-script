using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DAB RID: 3499
	public struct FogBlock : IFlatbufferObject
	{
		// Token: 0x17001427 RID: 5159
		// (get) Token: 0x06007BF0 RID: 31728 RVA: 0x0025FBA1 File Offset: 0x0025DDA1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007BF1 RID: 31729 RVA: 0x0025FBAE File Offset: 0x0025DDAE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007BF2 RID: 31730 RVA: 0x0025FBB8 File Offset: 0x0025DDB8
		public static FogBlock GetRootAsFogBlock(ByteBuffer _bb)
		{
			return FogBlock.GetRootAsFogBlock(_bb, default(FogBlock));
		}

		// Token: 0x06007BF3 RID: 31731 RVA: 0x0025FBD4 File Offset: 0x0025DDD4
		public static FogBlock GetRootAsFogBlock(ByteBuffer _bb, FogBlock obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007BF4 RID: 31732 RVA: 0x0025FBF1 File Offset: 0x0025DDF1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007BF5 RID: 31733 RVA: 0x0025FC00 File Offset: 0x0025DE00
		public FogBlock __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001428 RID: 5160
		// (get) Token: 0x06007BF6 RID: 31734 RVA: 0x0025FC10 File Offset: 0x0025DE10
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

		// Token: 0x06007BF7 RID: 31735 RVA: 0x0025FC47 File Offset: 0x0025DE47
		public Span<byte> GetIdBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06007BF8 RID: 31736 RVA: 0x0025FC56 File Offset: 0x0025DE56
		public byte[] GetIdArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x17001429 RID: 5161
		// (get) Token: 0x06007BF9 RID: 31737 RVA: 0x0025FC70 File Offset: 0x0025DE70
		public string Block
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

		// Token: 0x06007BFA RID: 31738 RVA: 0x0025FCA7 File Offset: 0x0025DEA7
		public Span<byte> GetBlockBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06007BFB RID: 31739 RVA: 0x0025FCB6 File Offset: 0x0025DEB6
		public byte[] GetBlockArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700142A RID: 5162
		// (get) Token: 0x06007BFC RID: 31740 RVA: 0x0025FCD0 File Offset: 0x0025DED0
		public int MapId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700142B RID: 5163
		// (get) Token: 0x06007BFD RID: 31741 RVA: 0x0025FD0C File Offset: 0x0025DF0C
		public int R
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700142C RID: 5164
		// (get) Token: 0x06007BFE RID: 31742 RVA: 0x0025FD4C File Offset: 0x0025DF4C
		public int G
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700142D RID: 5165
		// (get) Token: 0x06007BFF RID: 31743 RVA: 0x0025FD8C File Offset: 0x0025DF8C
		public int B
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700142E RID: 5166
		// (get) Token: 0x06007C00 RID: 31744 RVA: 0x0025FDCC File Offset: 0x0025DFCC
		public int Alpha
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0400531B RID: 21275
		private Table __p;
	}
}

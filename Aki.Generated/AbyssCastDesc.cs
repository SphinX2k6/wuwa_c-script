using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B81 RID: 2945
	public struct AbyssCastDesc : IFlatbufferObject
	{
		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600454A RID: 17738 RVA: 0x001E40B9 File Offset: 0x001E22B9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600454B RID: 17739 RVA: 0x001E40C6 File Offset: 0x001E22C6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600454C RID: 17740 RVA: 0x001E40D0 File Offset: 0x001E22D0
		public static AbyssCastDesc GetRootAsAbyssCastDesc(ByteBuffer _bb)
		{
			return AbyssCastDesc.GetRootAsAbyssCastDesc(_bb, default(AbyssCastDesc));
		}

		// Token: 0x0600454D RID: 17741 RVA: 0x001E40EC File Offset: 0x001E22EC
		public static AbyssCastDesc GetRootAsAbyssCastDesc(ByteBuffer _bb, AbyssCastDesc obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600454E RID: 17742 RVA: 0x001E4109 File Offset: 0x001E2309
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600454F RID: 17743 RVA: 0x001E4118 File Offset: 0x001E2318
		public AbyssCastDesc __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06004550 RID: 17744 RVA: 0x001E4128 File Offset: 0x001E2328
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

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06004551 RID: 17745 RVA: 0x001E4164 File Offset: 0x001E2364
		public string Name
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

		// Token: 0x06004552 RID: 17746 RVA: 0x001E419B File Offset: 0x001E239B
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06004553 RID: 17747 RVA: 0x001E41AA File Offset: 0x001E23AA
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06004554 RID: 17748 RVA: 0x001E41C4 File Offset: 0x001E23C4
		public string Icon
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

		// Token: 0x06004555 RID: 17749 RVA: 0x001E41FB File Offset: 0x001E23FB
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06004556 RID: 17750 RVA: 0x001E420A File Offset: 0x001E240A
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x0400504F RID: 20559
		private Table __p;
	}
}

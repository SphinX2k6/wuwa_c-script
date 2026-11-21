using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B88 RID: 2952
	public struct AbyssRewardTab : IFlatbufferObject
	{
		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x060046B8 RID: 18104 RVA: 0x001E76EC File Offset: 0x001E58EC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060046B9 RID: 18105 RVA: 0x001E76F9 File Offset: 0x001E58F9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060046BA RID: 18106 RVA: 0x001E7700 File Offset: 0x001E5900
		public static AbyssRewardTab GetRootAsAbyssRewardTab(ByteBuffer _bb)
		{
			return AbyssRewardTab.GetRootAsAbyssRewardTab(_bb, default(AbyssRewardTab));
		}

		// Token: 0x060046BB RID: 18107 RVA: 0x001E771C File Offset: 0x001E591C
		public static AbyssRewardTab GetRootAsAbyssRewardTab(ByteBuffer _bb, AbyssRewardTab obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060046BC RID: 18108 RVA: 0x001E7739 File Offset: 0x001E5939
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060046BD RID: 18109 RVA: 0x001E7748 File Offset: 0x001E5948
		public AbyssRewardTab __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x060046BE RID: 18110 RVA: 0x001E7758 File Offset: 0x001E5958
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

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060046BF RID: 18111 RVA: 0x001E7794 File Offset: 0x001E5994
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

		// Token: 0x060046C0 RID: 18112 RVA: 0x001E77CB File Offset: 0x001E59CB
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060046C1 RID: 18113 RVA: 0x001E77DA File Offset: 0x001E59DA
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060046C2 RID: 18114 RVA: 0x001E77F4 File Offset: 0x001E59F4
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

		// Token: 0x060046C3 RID: 18115 RVA: 0x001E782B File Offset: 0x001E5A2B
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060046C4 RID: 18116 RVA: 0x001E783A File Offset: 0x001E5A3A
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x0400505C RID: 20572
		private Table __p;
	}
}

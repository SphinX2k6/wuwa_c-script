using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D24 RID: 3364
	public struct HandBookQuestTab : IFlatbufferObject
	{
		// Token: 0x170016E3 RID: 5859
		// (get) Token: 0x06007E01 RID: 32257 RVA: 0x00253018 File Offset: 0x00251218
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007E02 RID: 32258 RVA: 0x00253025 File Offset: 0x00251225
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007E03 RID: 32259 RVA: 0x0025302C File Offset: 0x0025122C
		public static HandBookQuestTab GetRootAsHandBookQuestTab(ByteBuffer _bb)
		{
			return HandBookQuestTab.GetRootAsHandBookQuestTab(_bb, default(HandBookQuestTab));
		}

		// Token: 0x06007E04 RID: 32260 RVA: 0x00253048 File Offset: 0x00251248
		public static HandBookQuestTab GetRootAsHandBookQuestTab(ByteBuffer _bb, HandBookQuestTab obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007E05 RID: 32261 RVA: 0x00253065 File Offset: 0x00251265
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007E06 RID: 32262 RVA: 0x00253074 File Offset: 0x00251274
		public HandBookQuestTab __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170016E4 RID: 5860
		// (get) Token: 0x06007E07 RID: 32263 RVA: 0x00253084 File Offset: 0x00251284
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

		// Token: 0x170016E5 RID: 5861
		// (get) Token: 0x06007E08 RID: 32264 RVA: 0x002530C0 File Offset: 0x002512C0
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

		// Token: 0x06007E09 RID: 32265 RVA: 0x002530F7 File Offset: 0x002512F7
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06007E0A RID: 32266 RVA: 0x00253106 File Offset: 0x00251306
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170016E6 RID: 5862
		// (get) Token: 0x06007E0B RID: 32267 RVA: 0x00253120 File Offset: 0x00251320
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

		// Token: 0x06007E0C RID: 32268 RVA: 0x00253157 File Offset: 0x00251357
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06007E0D RID: 32269 RVA: 0x00253166 File Offset: 0x00251366
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170016E7 RID: 5863
		// (get) Token: 0x06007E0E RID: 32270 RVA: 0x00253180 File Offset: 0x00251380
		public int Type
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

		// Token: 0x04004D9C RID: 19868
		private Table __p;
	}
}

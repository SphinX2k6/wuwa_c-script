using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001121 RID: 4385
	public struct TermExplanationViewStyle : IFlatbufferObject
	{
		// Token: 0x17003A12 RID: 14866
		// (get) Token: 0x0600DDCE RID: 56782 RVA: 0x0032B88A File Offset: 0x00329A8A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DDCF RID: 56783 RVA: 0x0032B897 File Offset: 0x00329A97
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DDD0 RID: 56784 RVA: 0x0032B8A0 File Offset: 0x00329AA0
		public static TermExplanationViewStyle GetRootAsTermExplanationViewStyle(ByteBuffer _bb)
		{
			return TermExplanationViewStyle.GetRootAsTermExplanationViewStyle(_bb, default(TermExplanationViewStyle));
		}

		// Token: 0x0600DDD1 RID: 56785 RVA: 0x0032B8BC File Offset: 0x00329ABC
		public static TermExplanationViewStyle GetRootAsTermExplanationViewStyle(ByteBuffer _bb, TermExplanationViewStyle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DDD2 RID: 56786 RVA: 0x0032B8D9 File Offset: 0x00329AD9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DDD3 RID: 56787 RVA: 0x0032B8E8 File Offset: 0x00329AE8
		public TermExplanationViewStyle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003A13 RID: 14867
		// (get) Token: 0x0600DDD4 RID: 56788 RVA: 0x0032B8F8 File Offset: 0x00329AF8
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

		// Token: 0x17003A14 RID: 14868
		// (get) Token: 0x0600DDD5 RID: 56789 RVA: 0x0032B934 File Offset: 0x00329B34
		public string SideView
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

		// Token: 0x0600DDD6 RID: 56790 RVA: 0x0032B96B File Offset: 0x00329B6B
		public Span<byte> GetSideViewBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600DDD7 RID: 56791 RVA: 0x0032B97A File Offset: 0x00329B7A
		public byte[] GetSideViewArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003A15 RID: 14869
		// (get) Token: 0x0600DDD8 RID: 56792 RVA: 0x0032B994 File Offset: 0x00329B94
		public string CenterView
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

		// Token: 0x0600DDD9 RID: 56793 RVA: 0x0032B9CB File Offset: 0x00329BCB
		public Span<byte> GetCenterViewBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600DDDA RID: 56794 RVA: 0x0032B9DA File Offset: 0x00329BDA
		public byte[] GetCenterViewArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x0400525E RID: 21086
		private Table __p;
	}
}

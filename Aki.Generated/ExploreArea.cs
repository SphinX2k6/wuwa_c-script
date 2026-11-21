using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D2F RID: 3375
	public struct ExploreArea : IFlatbufferObject
	{
		// Token: 0x17001015 RID: 4117
		// (get) Token: 0x06007134 RID: 28980 RVA: 0x00246CDC File Offset: 0x00244EDC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007135 RID: 28981 RVA: 0x00246CE9 File Offset: 0x00244EE9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007136 RID: 28982 RVA: 0x00246CF0 File Offset: 0x00244EF0
		public static ExploreArea GetRootAsExploreArea(ByteBuffer _bb)
		{
			return ExploreArea.GetRootAsExploreArea(_bb, default(ExploreArea));
		}

		// Token: 0x06007137 RID: 28983 RVA: 0x00246D0C File Offset: 0x00244F0C
		public static ExploreArea GetRootAsExploreArea(ByteBuffer _bb, ExploreArea obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007138 RID: 28984 RVA: 0x00246D29 File Offset: 0x00244F29
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007139 RID: 28985 RVA: 0x00246D38 File Offset: 0x00244F38
		public ExploreArea __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001016 RID: 4118
		// (get) Token: 0x0600713A RID: 28986 RVA: 0x00246D48 File Offset: 0x00244F48
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

		// Token: 0x17001017 RID: 4119
		// (get) Token: 0x0600713B RID: 28987 RVA: 0x00246D84 File Offset: 0x00244F84
		public string Bg
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

		// Token: 0x0600713C RID: 28988 RVA: 0x00246DBB File Offset: 0x00244FBB
		public Span<byte> GetBgBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600713D RID: 28989 RVA: 0x00246DCA File Offset: 0x00244FCA
		public byte[] GetBgArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x04005274 RID: 21108
		private Table __p;
	}
}

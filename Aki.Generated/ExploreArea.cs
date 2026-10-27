using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C4C RID: 3148
	public struct ExploreArea : IFlatbufferObject
	{
		// Token: 0x17000FBC RID: 4028
		// (get) Token: 0x06006B32 RID: 27442 RVA: 0x00227A30 File Offset: 0x00225C30
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006B33 RID: 27443 RVA: 0x00227A3D File Offset: 0x00225C3D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006B34 RID: 27444 RVA: 0x00227A44 File Offset: 0x00225C44
		public static ExploreArea GetRootAsExploreArea(ByteBuffer _bb)
		{
			return ExploreArea.GetRootAsExploreArea(_bb, default(ExploreArea));
		}

		// Token: 0x06006B35 RID: 27445 RVA: 0x00227A60 File Offset: 0x00225C60
		public static ExploreArea GetRootAsExploreArea(ByteBuffer _bb, ExploreArea obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006B36 RID: 27446 RVA: 0x00227A7D File Offset: 0x00225C7D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006B37 RID: 27447 RVA: 0x00227A8C File Offset: 0x00225C8C
		public ExploreArea __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000FBD RID: 4029
		// (get) Token: 0x06006B38 RID: 27448 RVA: 0x00227A9C File Offset: 0x00225C9C
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

		// Token: 0x17000FBE RID: 4030
		// (get) Token: 0x06006B39 RID: 27449 RVA: 0x00227AD8 File Offset: 0x00225CD8
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

		// Token: 0x06006B3A RID: 27450 RVA: 0x00227B0F File Offset: 0x00225D0F
		public Span<byte> GetBgBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06006B3B RID: 27451 RVA: 0x00227B1E File Offset: 0x00225D1E
		public byte[] GetBgArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x04004C91 RID: 19601
		private Table __p;
	}
}

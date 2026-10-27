using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200109D RID: 4253
	public struct SheriffClue : IFlatbufferObject
	{
		// Token: 0x17003559 RID: 13657
		// (get) Token: 0x0600D0B5 RID: 53429 RVA: 0x0030C6CD File Offset: 0x0030A8CD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D0B6 RID: 53430 RVA: 0x0030C6DA File Offset: 0x0030A8DA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D0B7 RID: 53431 RVA: 0x0030C6E4 File Offset: 0x0030A8E4
		public static SheriffClue GetRootAsSheriffClue(ByteBuffer _bb)
		{
			return SheriffClue.GetRootAsSheriffClue(_bb, default(SheriffClue));
		}

		// Token: 0x0600D0B8 RID: 53432 RVA: 0x0030C700 File Offset: 0x0030A900
		public static SheriffClue GetRootAsSheriffClue(ByteBuffer _bb, SheriffClue obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D0B9 RID: 53433 RVA: 0x0030C71D File Offset: 0x0030A91D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D0BA RID: 53434 RVA: 0x0030C72C File Offset: 0x0030A92C
		public SheriffClue __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700355A RID: 13658
		// (get) Token: 0x0600D0BB RID: 53435 RVA: 0x0030C73C File Offset: 0x0030A93C
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

		// Token: 0x1700355B RID: 13659
		// (get) Token: 0x0600D0BC RID: 53436 RVA: 0x0030C778 File Offset: 0x0030A978
		public int SheriffAnomalyId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700355C RID: 13660
		// (get) Token: 0x0600D0BD RID: 53437 RVA: 0x0030C7B4 File Offset: 0x0030A9B4
		public string Name
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

		// Token: 0x0600D0BE RID: 53438 RVA: 0x0030C7EB File Offset: 0x0030A9EB
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600D0BF RID: 53439 RVA: 0x0030C7FA File Offset: 0x0030A9FA
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700355D RID: 13661
		// (get) Token: 0x0600D0C0 RID: 53440 RVA: 0x0030C814 File Offset: 0x0030AA14
		public string Desc
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D0C1 RID: 53441 RVA: 0x0030C84C File Offset: 0x0030AA4C
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600D0C2 RID: 53442 RVA: 0x0030C85C File Offset: 0x0030AA5C
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x1700355E RID: 13662
		// (get) Token: 0x0600D0C3 RID: 53443 RVA: 0x0030C874 File Offset: 0x0030AA74
		public string Icon
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D0C4 RID: 53444 RVA: 0x0030C8AC File Offset: 0x0030AAAC
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600D0C5 RID: 53445 RVA: 0x0030C8BC File Offset: 0x0030AABC
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x040051AB RID: 20907
		private Table __p;
	}
}

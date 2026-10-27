using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DF9 RID: 3577
	public struct MatchThreeComment : IFlatbufferObject
	{
		// Token: 0x17001E6F RID: 7791
		// (get) Token: 0x06009254 RID: 37460 RVA: 0x00281651 File Offset: 0x0027F851
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009255 RID: 37461 RVA: 0x0028165E File Offset: 0x0027F85E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009256 RID: 37462 RVA: 0x00281668 File Offset: 0x0027F868
		public static MatchThreeComment GetRootAsMatchThreeComment(ByteBuffer _bb)
		{
			return MatchThreeComment.GetRootAsMatchThreeComment(_bb, default(MatchThreeComment));
		}

		// Token: 0x06009257 RID: 37463 RVA: 0x00281684 File Offset: 0x0027F884
		public static MatchThreeComment GetRootAsMatchThreeComment(ByteBuffer _bb, MatchThreeComment obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009258 RID: 37464 RVA: 0x002816A1 File Offset: 0x0027F8A1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009259 RID: 37465 RVA: 0x002816B0 File Offset: 0x0027F8B0
		public MatchThreeComment __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001E70 RID: 7792
		// (get) Token: 0x0600925A RID: 37466 RVA: 0x002816C0 File Offset: 0x0027F8C0
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

		// Token: 0x17001E71 RID: 7793
		// (get) Token: 0x0600925B RID: 37467 RVA: 0x002816FC File Offset: 0x0027F8FC
		public int Count
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

		// Token: 0x17001E72 RID: 7794
		// (get) Token: 0x0600925C RID: 37468 RVA: 0x00281738 File Offset: 0x0027F938
		public string Color1
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

		// Token: 0x0600925D RID: 37469 RVA: 0x0028176F File Offset: 0x0027F96F
		public Span<byte> GetColor1Bytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600925E RID: 37470 RVA: 0x0028177E File Offset: 0x0027F97E
		public byte[] GetColor1Array()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001E73 RID: 7795
		// (get) Token: 0x0600925F RID: 37471 RVA: 0x00281798 File Offset: 0x0027F998
		public string Color2
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

		// Token: 0x06009260 RID: 37472 RVA: 0x002817D0 File Offset: 0x0027F9D0
		public Span<byte> GetColor2Bytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06009261 RID: 37473 RVA: 0x002817E0 File Offset: 0x0027F9E0
		public byte[] GetColor2Array()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17001E74 RID: 7796
		// (get) Token: 0x06009262 RID: 37474 RVA: 0x002817F8 File Offset: 0x0027F9F8
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

		// Token: 0x06009263 RID: 37475 RVA: 0x00281830 File Offset: 0x0027FA30
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06009264 RID: 37476 RVA: 0x00281840 File Offset: 0x0027FA40
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x04004E99 RID: 20121
		private Table __p;
	}
}

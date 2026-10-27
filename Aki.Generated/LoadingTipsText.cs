using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DD6 RID: 3542
	public struct LoadingTipsText : IFlatbufferObject
	{
		// Token: 0x17001D40 RID: 7488
		// (get) Token: 0x06008F30 RID: 36656 RVA: 0x0027A42D File Offset: 0x0027862D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008F31 RID: 36657 RVA: 0x0027A43A File Offset: 0x0027863A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008F32 RID: 36658 RVA: 0x0027A444 File Offset: 0x00278644
		public static LoadingTipsText GetRootAsLoadingTipsText(ByteBuffer _bb)
		{
			return LoadingTipsText.GetRootAsLoadingTipsText(_bb, default(LoadingTipsText));
		}

		// Token: 0x06008F33 RID: 36659 RVA: 0x0027A460 File Offset: 0x00278660
		public static LoadingTipsText GetRootAsLoadingTipsText(ByteBuffer _bb, LoadingTipsText obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008F34 RID: 36660 RVA: 0x0027A47D File Offset: 0x0027867D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008F35 RID: 36661 RVA: 0x0027A48C File Offset: 0x0027868C
		public LoadingTipsText __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001D41 RID: 7489
		// (get) Token: 0x06008F36 RID: 36662 RVA: 0x0027A49C File Offset: 0x0027869C
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

		// Token: 0x17001D42 RID: 7490
		// (get) Token: 0x06008F37 RID: 36663 RVA: 0x0027A4D8 File Offset: 0x002786D8
		public int LevelAreaId
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

		// Token: 0x17001D43 RID: 7491
		// (get) Token: 0x06008F38 RID: 36664 RVA: 0x0027A514 File Offset: 0x00278714
		public int ImageId
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

		// Token: 0x17001D44 RID: 7492
		// (get) Token: 0x06008F39 RID: 36665 RVA: 0x0027A550 File Offset: 0x00278750
		public int Weight
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

		// Token: 0x17001D45 RID: 7493
		// (get) Token: 0x06008F3A RID: 36666 RVA: 0x0027A590 File Offset: 0x00278790
		public string Title
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

		// Token: 0x06008F3B RID: 36667 RVA: 0x0027A5C8 File Offset: 0x002787C8
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06008F3C RID: 36668 RVA: 0x0027A5D8 File Offset: 0x002787D8
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17001D46 RID: 7494
		// (get) Token: 0x06008F3D RID: 36669 RVA: 0x0027A5F0 File Offset: 0x002787F0
		public string TipsText
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008F3E RID: 36670 RVA: 0x0027A628 File Offset: 0x00278828
		public Span<byte> GetTipsTextBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06008F3F RID: 36671 RVA: 0x0027A638 File Offset: 0x00278838
		public byte[] GetTipsTextArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x04004E71 RID: 20081
		private Table __p;
	}
}

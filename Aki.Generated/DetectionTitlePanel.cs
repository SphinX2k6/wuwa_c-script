using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CCC RID: 3276
	public struct DetectionTitlePanel : IFlatbufferObject
	{
		// Token: 0x17000CA4 RID: 3236
		// (get) Token: 0x0600676A RID: 26474 RVA: 0x002314F1 File Offset: 0x0022F6F1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600676B RID: 26475 RVA: 0x002314FE File Offset: 0x0022F6FE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600676C RID: 26476 RVA: 0x00231508 File Offset: 0x0022F708
		public static DetectionTitlePanel GetRootAsDetectionTitlePanel(ByteBuffer _bb)
		{
			return DetectionTitlePanel.GetRootAsDetectionTitlePanel(_bb, default(DetectionTitlePanel));
		}

		// Token: 0x0600676D RID: 26477 RVA: 0x00231524 File Offset: 0x0022F724
		public static DetectionTitlePanel GetRootAsDetectionTitlePanel(ByteBuffer _bb, DetectionTitlePanel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600676E RID: 26478 RVA: 0x00231541 File Offset: 0x0022F741
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600676F RID: 26479 RVA: 0x00231550 File Offset: 0x0022F750
		public DetectionTitlePanel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000CA5 RID: 3237
		// (get) Token: 0x06006770 RID: 26480 RVA: 0x00231560 File Offset: 0x0022F760
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

		// Token: 0x17000CA6 RID: 3238
		// (get) Token: 0x06006771 RID: 26481 RVA: 0x0023159C File Offset: 0x0022F79C
		public string TitleText
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

		// Token: 0x06006772 RID: 26482 RVA: 0x002315D3 File Offset: 0x0022F7D3
		public Span<byte> GetTitleTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06006773 RID: 26483 RVA: 0x002315E2 File Offset: 0x0022F7E2
		public byte[] GetTitleTextArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000CA7 RID: 3239
		// (get) Token: 0x06006774 RID: 26484 RVA: 0x002315FC File Offset: 0x0022F7FC
		public string SubTitleText
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

		// Token: 0x06006775 RID: 26485 RVA: 0x00231633 File Offset: 0x0022F833
		public Span<byte> GetSubTitleTextBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06006776 RID: 26486 RVA: 0x00231642 File Offset: 0x0022F842
		public byte[] GetSubTitleTextArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000CA8 RID: 3240
		// (get) Token: 0x06006777 RID: 26487 RVA: 0x0023165C File Offset: 0x0022F85C
		public string BgTexture
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

		// Token: 0x06006778 RID: 26488 RVA: 0x00231694 File Offset: 0x0022F894
		public Span<byte> GetBgTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06006779 RID: 26489 RVA: 0x002316A4 File Offset: 0x0022F8A4
		public byte[] GetBgTextureArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x040051F9 RID: 20985
		private Table __p;
	}
}

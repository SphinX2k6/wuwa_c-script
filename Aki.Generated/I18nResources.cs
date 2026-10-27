using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D59 RID: 3417
	public struct I18nResources : IFlatbufferObject
	{
		// Token: 0x17001897 RID: 6295
		// (get) Token: 0x06008259 RID: 33369 RVA: 0x0025CAA9 File Offset: 0x0025ACA9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600825A RID: 33370 RVA: 0x0025CAB6 File Offset: 0x0025ACB6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600825B RID: 33371 RVA: 0x0025CAC0 File Offset: 0x0025ACC0
		public static I18nResources GetRootAsI18nResources(ByteBuffer _bb)
		{
			return I18nResources.GetRootAsI18nResources(_bb, default(I18nResources));
		}

		// Token: 0x0600825C RID: 33372 RVA: 0x0025CADC File Offset: 0x0025ACDC
		public static I18nResources GetRootAsI18nResources(ByteBuffer _bb, I18nResources obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600825D RID: 33373 RVA: 0x0025CAF9 File Offset: 0x0025ACF9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600825E RID: 33374 RVA: 0x0025CB08 File Offset: 0x0025AD08
		public I18nResources __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001898 RID: 6296
		// (get) Token: 0x0600825F RID: 33375 RVA: 0x0025CB18 File Offset: 0x0025AD18
		public string Id
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008260 RID: 33376 RVA: 0x0025CB4F File Offset: 0x0025AD4F
		public Span<byte> GetIdBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06008261 RID: 33377 RVA: 0x0025CB5E File Offset: 0x0025AD5E
		public byte[] GetIdArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x17001899 RID: 6297
		// (get) Token: 0x06008262 RID: 33378 RVA: 0x0025CB78 File Offset: 0x0025AD78
		public string PlotAudioRef
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

		// Token: 0x06008263 RID: 33379 RVA: 0x0025CBAF File Offset: 0x0025ADAF
		public Span<byte> GetPlotAudioRefBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06008264 RID: 33380 RVA: 0x0025CBBE File Offset: 0x0025ADBE
		public byte[] GetPlotAudioRefArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700189A RID: 6298
		// (get) Token: 0x06008265 RID: 33381 RVA: 0x0025CBD8 File Offset: 0x0025ADD8
		public string TextureRef
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

		// Token: 0x06008266 RID: 33382 RVA: 0x0025CC0F File Offset: 0x0025AE0F
		public Span<byte> GetTextureRefBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06008267 RID: 33383 RVA: 0x0025CC1E File Offset: 0x0025AE1E
		public byte[] GetTextureRefArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x04004DD8 RID: 19928
		private Table __p;
	}
}

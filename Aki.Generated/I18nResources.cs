using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E3E RID: 3646
	public struct I18nResources : IFlatbufferObject
	{
		// Token: 0x170018FA RID: 6394
		// (get) Token: 0x06008873 RID: 34931 RVA: 0x0027B196 File Offset: 0x00279396
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008874 RID: 34932 RVA: 0x0027B1A3 File Offset: 0x002793A3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008875 RID: 34933 RVA: 0x0027B1AC File Offset: 0x002793AC
		public static I18nResources GetRootAsI18nResources(ByteBuffer _bb)
		{
			return I18nResources.GetRootAsI18nResources(_bb, default(I18nResources));
		}

		// Token: 0x06008876 RID: 34934 RVA: 0x0027B1C8 File Offset: 0x002793C8
		public static I18nResources GetRootAsI18nResources(ByteBuffer _bb, I18nResources obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008877 RID: 34935 RVA: 0x0027B1E5 File Offset: 0x002793E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008878 RID: 34936 RVA: 0x0027B1F4 File Offset: 0x002793F4
		public I18nResources __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170018FB RID: 6395
		// (get) Token: 0x06008879 RID: 34937 RVA: 0x0027B204 File Offset: 0x00279404
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

		// Token: 0x0600887A RID: 34938 RVA: 0x0027B23B File Offset: 0x0027943B
		public Span<byte> GetIdBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0600887B RID: 34939 RVA: 0x0027B24A File Offset: 0x0027944A
		public byte[] GetIdArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x170018FC RID: 6396
		// (get) Token: 0x0600887C RID: 34940 RVA: 0x0027B264 File Offset: 0x00279464
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

		// Token: 0x0600887D RID: 34941 RVA: 0x0027B29B File Offset: 0x0027949B
		public Span<byte> GetPlotAudioRefBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600887E RID: 34942 RVA: 0x0027B2AA File Offset: 0x002794AA
		public byte[] GetPlotAudioRefArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170018FD RID: 6397
		// (get) Token: 0x0600887F RID: 34943 RVA: 0x0027B2C4 File Offset: 0x002794C4
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

		// Token: 0x06008880 RID: 34944 RVA: 0x0027B2FB File Offset: 0x002794FB
		public Span<byte> GetTextureRefBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06008881 RID: 34945 RVA: 0x0027B30A File Offset: 0x0027950A
		public byte[] GetTextureRefArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x040053BD RID: 21437
		private Table __p;
	}
}

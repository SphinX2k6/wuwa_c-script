using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D3B RID: 3387
	public struct ExternalSourceSetting : IFlatbufferObject
	{
		// Token: 0x17001085 RID: 4229
		// (get) Token: 0x06007250 RID: 29264 RVA: 0x00249825 File Offset: 0x00247A25
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007251 RID: 29265 RVA: 0x00249832 File Offset: 0x00247A32
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007252 RID: 29266 RVA: 0x0024983C File Offset: 0x00247A3C
		public static ExternalSourceSetting GetRootAsExternalSourceSetting(ByteBuffer _bb)
		{
			return ExternalSourceSetting.GetRootAsExternalSourceSetting(_bb, default(ExternalSourceSetting));
		}

		// Token: 0x06007253 RID: 29267 RVA: 0x00249858 File Offset: 0x00247A58
		public static ExternalSourceSetting GetRootAsExternalSourceSetting(ByteBuffer _bb, ExternalSourceSetting obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007254 RID: 29268 RVA: 0x00249875 File Offset: 0x00247A75
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007255 RID: 29269 RVA: 0x00249884 File Offset: 0x00247A84
		public ExternalSourceSetting __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001086 RID: 4230
		// (get) Token: 0x06007256 RID: 29270 RVA: 0x00249894 File Offset: 0x00247A94
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

		// Token: 0x06007257 RID: 29271 RVA: 0x002498CB File Offset: 0x00247ACB
		public Span<byte> GetIdBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06007258 RID: 29272 RVA: 0x002498DA File Offset: 0x00247ADA
		public byte[] GetIdArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x17001087 RID: 4231
		// (get) Token: 0x06007259 RID: 29273 RVA: 0x002498F4 File Offset: 0x00247AF4
		public string AudioEventPath
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

		// Token: 0x0600725A RID: 29274 RVA: 0x0024992B File Offset: 0x00247B2B
		public Span<byte> GetAudioEventPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600725B RID: 29275 RVA: 0x0024993A File Offset: 0x00247B3A
		public byte[] GetAudioEventPathArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001088 RID: 4232
		// (get) Token: 0x0600725C RID: 29276 RVA: 0x00249954 File Offset: 0x00247B54
		public string ExternalSrcName
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

		// Token: 0x0600725D RID: 29277 RVA: 0x0024998B File Offset: 0x00247B8B
		public Span<byte> GetExternalSrcNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600725E RID: 29278 RVA: 0x0024999A File Offset: 0x00247B9A
		public byte[] GetExternalSrcNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001089 RID: 4233
		// (get) Token: 0x0600725F RID: 29279 RVA: 0x002499B4 File Offset: 0x00247BB4
		public string SubtitleEvent
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

		// Token: 0x06007260 RID: 29280 RVA: 0x002499EC File Offset: 0x00247BEC
		public Span<byte> GetSubtitleEventBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06007261 RID: 29281 RVA: 0x002499FC File Offset: 0x00247BFC
		public byte[] GetSubtitleEventArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x1700108A RID: 4234
		// (get) Token: 0x06007262 RID: 29282 RVA: 0x00249A14 File Offset: 0x00247C14
		public string SubtitleSrc
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

		// Token: 0x06007263 RID: 29283 RVA: 0x00249A4C File Offset: 0x00247C4C
		public Span<byte> GetSubtitleSrcBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06007264 RID: 29284 RVA: 0x00249A5C File Offset: 0x00247C5C
		public byte[] GetSubtitleSrcArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x1700108B RID: 4235
		// (get) Token: 0x06007265 RID: 29285 RVA: 0x00249A74 File Offset: 0x00247C74
		public string BubbleEvent
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

		// Token: 0x06007266 RID: 29286 RVA: 0x00249AAC File Offset: 0x00247CAC
		public Span<byte> GetBubbleEventBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06007267 RID: 29287 RVA: 0x00249ABC File Offset: 0x00247CBC
		public byte[] GetBubbleEventArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x1700108C RID: 4236
		// (get) Token: 0x06007268 RID: 29288 RVA: 0x00249AD4 File Offset: 0x00247CD4
		public string BubbleSrc
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007269 RID: 29289 RVA: 0x00249B0C File Offset: 0x00247D0C
		public Span<byte> GetBubbleSrcBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600726A RID: 29290 RVA: 0x00249B1C File Offset: 0x00247D1C
		public byte[] GetBubbleSrcArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x04005286 RID: 21126
		private Table __p;
	}
}

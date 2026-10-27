using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DF7 RID: 3575
	public struct MarkEffect : IFlatbufferObject
	{
		// Token: 0x17001E61 RID: 7777
		// (get) Token: 0x06009212 RID: 37394 RVA: 0x00280DE6 File Offset: 0x0027EFE6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009213 RID: 37395 RVA: 0x00280DF3 File Offset: 0x0027EFF3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009214 RID: 37396 RVA: 0x00280DFC File Offset: 0x0027EFFC
		public static MarkEffect GetRootAsMarkEffect(ByteBuffer _bb)
		{
			return MarkEffect.GetRootAsMarkEffect(_bb, default(MarkEffect));
		}

		// Token: 0x06009215 RID: 37397 RVA: 0x00280E18 File Offset: 0x0027F018
		public static MarkEffect GetRootAsMarkEffect(ByteBuffer _bb, MarkEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009216 RID: 37398 RVA: 0x00280E35 File Offset: 0x0027F035
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009217 RID: 37399 RVA: 0x00280E44 File Offset: 0x0027F044
		public MarkEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001E62 RID: 7778
		// (get) Token: 0x06009218 RID: 37400 RVA: 0x00280E54 File Offset: 0x0027F054
		public int MarkId
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

		// Token: 0x17001E63 RID: 7779
		// (get) Token: 0x06009219 RID: 37401 RVA: 0x00280E90 File Offset: 0x0027F090
		public string EffectResourcePath
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

		// Token: 0x0600921A RID: 37402 RVA: 0x00280EC7 File Offset: 0x0027F0C7
		public Span<byte> GetEffectResourcePathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600921B RID: 37403 RVA: 0x00280ED6 File Offset: 0x0027F0D6
		public byte[] GetEffectResourcePathArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x04004E97 RID: 20119
		private Table __p;
	}
}

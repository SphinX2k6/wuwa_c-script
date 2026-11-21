using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D0E RID: 3342
	public struct EmotionBubbleConfig : IFlatbufferObject
	{
		// Token: 0x17000F34 RID: 3892
		// (get) Token: 0x06006E84 RID: 28292 RVA: 0x0024135D File Offset: 0x0023F55D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006E85 RID: 28293 RVA: 0x0024136A File Offset: 0x0023F56A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006E86 RID: 28294 RVA: 0x00241374 File Offset: 0x0023F574
		public static EmotionBubbleConfig GetRootAsEmotionBubbleConfig(ByteBuffer _bb)
		{
			return EmotionBubbleConfig.GetRootAsEmotionBubbleConfig(_bb, default(EmotionBubbleConfig));
		}

		// Token: 0x06006E87 RID: 28295 RVA: 0x00241390 File Offset: 0x0023F590
		public static EmotionBubbleConfig GetRootAsEmotionBubbleConfig(ByteBuffer _bb, EmotionBubbleConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006E88 RID: 28296 RVA: 0x002413AD File Offset: 0x0023F5AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006E89 RID: 28297 RVA: 0x002413BC File Offset: 0x0023F5BC
		public EmotionBubbleConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000F35 RID: 3893
		// (get) Token: 0x06006E8A RID: 28298 RVA: 0x002413CC File Offset: 0x0023F5CC
		public string EmotionName
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

		// Token: 0x06006E8B RID: 28299 RVA: 0x00241403 File Offset: 0x0023F603
		public Span<byte> GetEmotionNameBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06006E8C RID: 28300 RVA: 0x00241412 File Offset: 0x0023F612
		public byte[] GetEmotionNameArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x17000F36 RID: 3894
		// (get) Token: 0x06006E8D RID: 28301 RVA: 0x0024142C File Offset: 0x0023F62C
		public string EmotionPath
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

		// Token: 0x06006E8E RID: 28302 RVA: 0x00241463 File Offset: 0x0023F663
		public Span<byte> GetEmotionPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06006E8F RID: 28303 RVA: 0x00241472 File Offset: 0x0023F672
		public byte[] GetEmotionPathArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000F37 RID: 3895
		// (get) Token: 0x06006E90 RID: 28304 RVA: 0x0024148C File Offset: 0x0023F68C
		public string EmotionDesc
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

		// Token: 0x06006E91 RID: 28305 RVA: 0x002414C3 File Offset: 0x0023F6C3
		public Span<byte> GetEmotionDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06006E92 RID: 28306 RVA: 0x002414D2 File Offset: 0x0023F6D2
		public byte[] GetEmotionDescArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x0400524E RID: 21070
		private Table __p;
	}
}

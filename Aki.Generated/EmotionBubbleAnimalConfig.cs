using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D0D RID: 3341
	public struct EmotionBubbleAnimalConfig : IFlatbufferObject
	{
		// Token: 0x17000F2C RID: 3884
		// (get) Token: 0x06006E68 RID: 28264 RVA: 0x0024101E File Offset: 0x0023F21E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006E69 RID: 28265 RVA: 0x0024102B File Offset: 0x0023F22B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006E6A RID: 28266 RVA: 0x00241034 File Offset: 0x0023F234
		public static EmotionBubbleAnimalConfig GetRootAsEmotionBubbleAnimalConfig(ByteBuffer _bb)
		{
			return EmotionBubbleAnimalConfig.GetRootAsEmotionBubbleAnimalConfig(_bb, default(EmotionBubbleAnimalConfig));
		}

		// Token: 0x06006E6B RID: 28267 RVA: 0x00241050 File Offset: 0x0023F250
		public static EmotionBubbleAnimalConfig GetRootAsEmotionBubbleAnimalConfig(ByteBuffer _bb, EmotionBubbleAnimalConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006E6C RID: 28268 RVA: 0x0024106D File Offset: 0x0023F26D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006E6D RID: 28269 RVA: 0x0024107C File Offset: 0x0023F27C
		public EmotionBubbleAnimalConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000F2D RID: 3885
		// (get) Token: 0x06006E6E RID: 28270 RVA: 0x0024108C File Offset: 0x0023F28C
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

		// Token: 0x17000F2E RID: 3886
		// (get) Token: 0x06006E6F RID: 28271 RVA: 0x002410C8 File Offset: 0x0023F2C8
		public string MonsterBp
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

		// Token: 0x06006E70 RID: 28272 RVA: 0x002410FF File Offset: 0x0023F2FF
		public Span<byte> GetMonsterBpBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06006E71 RID: 28273 RVA: 0x0024110E File Offset: 0x0023F30E
		public byte[] GetMonsterBpArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000F2F RID: 3887
		// (get) Token: 0x06006E72 RID: 28274 RVA: 0x00241128 File Offset: 0x0023F328
		public string MontagePath
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

		// Token: 0x06006E73 RID: 28275 RVA: 0x0024115F File Offset: 0x0023F35F
		public Span<byte> GetMontagePathBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06006E74 RID: 28276 RVA: 0x0024116E File Offset: 0x0023F36E
		public byte[] GetMontagePathArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000F30 RID: 3888
		// (get) Token: 0x06006E75 RID: 28277 RVA: 0x00241188 File Offset: 0x0023F388
		public string EmotionName
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

		// Token: 0x06006E76 RID: 28278 RVA: 0x002411C0 File Offset: 0x0023F3C0
		public Span<byte> GetEmotionNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06006E77 RID: 28279 RVA: 0x002411D0 File Offset: 0x0023F3D0
		public byte[] GetEmotionNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000F31 RID: 3889
		// (get) Token: 0x06006E78 RID: 28280 RVA: 0x002411E8 File Offset: 0x0023F3E8
		public string AttachPoint
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

		// Token: 0x06006E79 RID: 28281 RVA: 0x00241220 File Offset: 0x0023F420
		public Span<byte> GetAttachPointBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06006E7A RID: 28282 RVA: 0x00241230 File Offset: 0x0023F430
		public byte[] GetAttachPointArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x06006E7B RID: 28283 RVA: 0x00241248 File Offset: 0x0023F448
		public float Offset(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000F32 RID: 3890
		// (get) Token: 0x06006E7C RID: 28284 RVA: 0x0024128C File Offset: 0x0023F48C
		public int OffsetLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06006E7D RID: 28285 RVA: 0x002412B8 File Offset: 0x0023F4B8
		public Span<float> GetOffsetBytes()
		{
			return this.__p.__vector_as_span<float>(14, 4);
		}

		// Token: 0x06006E7E RID: 28286 RVA: 0x002412C8 File Offset: 0x0023F4C8
		public float[] GetOffsetArray()
		{
			return this.__p.__vector_as_array<float>(14) ?? Array.Empty<float>();
		}

		// Token: 0x17000F33 RID: 3891
		// (get) Token: 0x06006E7F RID: 28287 RVA: 0x002412E0 File Offset: 0x0023F4E0
		public string Remark
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

		// Token: 0x06006E80 RID: 28288 RVA: 0x00241318 File Offset: 0x0023F518
		public Span<byte> GetRemarkBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06006E81 RID: 28289 RVA: 0x00241328 File Offset: 0x0023F528
		public byte[] GetRemarkArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x06006E82 RID: 28290 RVA: 0x00241340 File Offset: 0x0023F540
		[NullableContext(1)]
		public float[] Offset()
		{
			return this.GetOffsetArray();
		}

		// Token: 0x06006E83 RID: 28291 RVA: 0x00241348 File Offset: 0x0023F548
		[NullableContext(1)]
		public IEnumerable<float> OffsetIter()
		{
			EmotionBubbleAnimalConfig.<OffsetIter>d__36 <OffsetIter>d__ = new EmotionBubbleAnimalConfig.<OffsetIter>d__36(-2);
			<OffsetIter>d__.<>3__<>4__this = this;
			return <OffsetIter>d__;
		}

		// Token: 0x0400524D RID: 21069
		private Table __p;
	}
}

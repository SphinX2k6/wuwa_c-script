using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C2A RID: 3114
	public struct EmotionBubbleAnimalConfig : IFlatbufferObject
	{
		// Token: 0x17000ED3 RID: 3795
		// (get) Token: 0x06006866 RID: 26726 RVA: 0x00221AD5 File Offset: 0x0021FCD5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006867 RID: 26727 RVA: 0x00221AE2 File Offset: 0x0021FCE2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006868 RID: 26728 RVA: 0x00221AEC File Offset: 0x0021FCEC
		public static EmotionBubbleAnimalConfig GetRootAsEmotionBubbleAnimalConfig(ByteBuffer _bb)
		{
			return EmotionBubbleAnimalConfig.GetRootAsEmotionBubbleAnimalConfig(_bb, default(EmotionBubbleAnimalConfig));
		}

		// Token: 0x06006869 RID: 26729 RVA: 0x00221B08 File Offset: 0x0021FD08
		public static EmotionBubbleAnimalConfig GetRootAsEmotionBubbleAnimalConfig(ByteBuffer _bb, EmotionBubbleAnimalConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600686A RID: 26730 RVA: 0x00221B25 File Offset: 0x0021FD25
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600686B RID: 26731 RVA: 0x00221B34 File Offset: 0x0021FD34
		public EmotionBubbleAnimalConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000ED4 RID: 3796
		// (get) Token: 0x0600686C RID: 26732 RVA: 0x00221B44 File Offset: 0x0021FD44
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

		// Token: 0x17000ED5 RID: 3797
		// (get) Token: 0x0600686D RID: 26733 RVA: 0x00221B80 File Offset: 0x0021FD80
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

		// Token: 0x0600686E RID: 26734 RVA: 0x00221BB7 File Offset: 0x0021FDB7
		public Span<byte> GetMonsterBpBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600686F RID: 26735 RVA: 0x00221BC6 File Offset: 0x0021FDC6
		public byte[] GetMonsterBpArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000ED6 RID: 3798
		// (get) Token: 0x06006870 RID: 26736 RVA: 0x00221BE0 File Offset: 0x0021FDE0
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

		// Token: 0x06006871 RID: 26737 RVA: 0x00221C17 File Offset: 0x0021FE17
		public Span<byte> GetMontagePathBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06006872 RID: 26738 RVA: 0x00221C26 File Offset: 0x0021FE26
		public byte[] GetMontagePathArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000ED7 RID: 3799
		// (get) Token: 0x06006873 RID: 26739 RVA: 0x00221C40 File Offset: 0x0021FE40
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

		// Token: 0x06006874 RID: 26740 RVA: 0x00221C78 File Offset: 0x0021FE78
		public Span<byte> GetEmotionNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06006875 RID: 26741 RVA: 0x00221C88 File Offset: 0x0021FE88
		public byte[] GetEmotionNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000ED8 RID: 3800
		// (get) Token: 0x06006876 RID: 26742 RVA: 0x00221CA0 File Offset: 0x0021FEA0
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

		// Token: 0x06006877 RID: 26743 RVA: 0x00221CD8 File Offset: 0x0021FED8
		public Span<byte> GetAttachPointBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06006878 RID: 26744 RVA: 0x00221CE8 File Offset: 0x0021FEE8
		public byte[] GetAttachPointArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x06006879 RID: 26745 RVA: 0x00221D00 File Offset: 0x0021FF00
		public float Offset(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000ED9 RID: 3801
		// (get) Token: 0x0600687A RID: 26746 RVA: 0x00221D44 File Offset: 0x0021FF44
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

		// Token: 0x0600687B RID: 26747 RVA: 0x00221D70 File Offset: 0x0021FF70
		public Span<float> GetOffsetBytes()
		{
			return this.__p.__vector_as_span<float>(14, 4);
		}

		// Token: 0x0600687C RID: 26748 RVA: 0x00221D80 File Offset: 0x0021FF80
		public float[] GetOffsetArray()
		{
			return this.__p.__vector_as_array<float>(14) ?? Array.Empty<float>();
		}

		// Token: 0x17000EDA RID: 3802
		// (get) Token: 0x0600687D RID: 26749 RVA: 0x00221D98 File Offset: 0x0021FF98
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

		// Token: 0x0600687E RID: 26750 RVA: 0x00221DD0 File Offset: 0x0021FFD0
		public Span<byte> GetRemarkBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600687F RID: 26751 RVA: 0x00221DE0 File Offset: 0x0021FFE0
		public byte[] GetRemarkArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x06006880 RID: 26752 RVA: 0x00221DF8 File Offset: 0x0021FFF8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用OffsetIter()或GetOffsetBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly float[] Offset()
		{
			EmotionBubbleAnimalConfig emotionBubbleAnimalConfig = this;
			return emotionBubbleAnimalConfig.GetOffsetArray() ?? Array.Empty<float>();
		}

		// Token: 0x06006881 RID: 26753 RVA: 0x00221E1C File Offset: 0x0022001C
		[NullableContext(1)]
		public readonly IEnumerable<float> OffsetIter()
		{
			EmotionBubbleAnimalConfig.<OffsetIter>d__36 <OffsetIter>d__ = new EmotionBubbleAnimalConfig.<OffsetIter>d__36(-2);
			<OffsetIter>d__.<>3__<>4__this = this;
			return <OffsetIter>d__;
		}

		// Token: 0x04004C6A RID: 19562
		private Table __p;
	}
}

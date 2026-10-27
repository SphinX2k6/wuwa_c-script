using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C2C RID: 3116
	public struct EmotionBubbleMonsterConfig : IFlatbufferObject
	{
		// Token: 0x17000EDF RID: 3807
		// (get) Token: 0x06006891 RID: 26769 RVA: 0x00221FBD File Offset: 0x002201BD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006892 RID: 26770 RVA: 0x00221FCA File Offset: 0x002201CA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006893 RID: 26771 RVA: 0x00221FD4 File Offset: 0x002201D4
		public static EmotionBubbleMonsterConfig GetRootAsEmotionBubbleMonsterConfig(ByteBuffer _bb)
		{
			return EmotionBubbleMonsterConfig.GetRootAsEmotionBubbleMonsterConfig(_bb, default(EmotionBubbleMonsterConfig));
		}

		// Token: 0x06006894 RID: 26772 RVA: 0x00221FF0 File Offset: 0x002201F0
		public static EmotionBubbleMonsterConfig GetRootAsEmotionBubbleMonsterConfig(ByteBuffer _bb, EmotionBubbleMonsterConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006895 RID: 26773 RVA: 0x0022200D File Offset: 0x0022020D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006896 RID: 26774 RVA: 0x0022201C File Offset: 0x0022021C
		public EmotionBubbleMonsterConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000EE0 RID: 3808
		// (get) Token: 0x06006897 RID: 26775 RVA: 0x0022202C File Offset: 0x0022022C
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

		// Token: 0x17000EE1 RID: 3809
		// (get) Token: 0x06006898 RID: 26776 RVA: 0x00222068 File Offset: 0x00220268
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

		// Token: 0x06006899 RID: 26777 RVA: 0x0022209F File Offset: 0x0022029F
		public Span<byte> GetMonsterBpBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600689A RID: 26778 RVA: 0x002220AE File Offset: 0x002202AE
		public byte[] GetMonsterBpArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x0600689B RID: 26779 RVA: 0x002220C8 File Offset: 0x002202C8
		public string StateTagList(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000EE2 RID: 3810
		// (get) Token: 0x0600689C RID: 26780 RVA: 0x00222104 File Offset: 0x00220304
		public int StateTagListLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17000EE3 RID: 3811
		// (get) Token: 0x0600689D RID: 26781 RVA: 0x00222130 File Offset: 0x00220330
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

		// Token: 0x0600689E RID: 26782 RVA: 0x00222168 File Offset: 0x00220368
		public Span<byte> GetEmotionNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600689F RID: 26783 RVA: 0x00222178 File Offset: 0x00220378
		public byte[] GetEmotionNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000EE4 RID: 3812
		// (get) Token: 0x060068A0 RID: 26784 RVA: 0x00222190 File Offset: 0x00220390
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

		// Token: 0x060068A1 RID: 26785 RVA: 0x002221C8 File Offset: 0x002203C8
		public Span<byte> GetAttachPointBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x060068A2 RID: 26786 RVA: 0x002221D8 File Offset: 0x002203D8
		public byte[] GetAttachPointArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x060068A3 RID: 26787 RVA: 0x002221F0 File Offset: 0x002203F0
		public float Offset(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000EE5 RID: 3813
		// (get) Token: 0x060068A4 RID: 26788 RVA: 0x00222234 File Offset: 0x00220434
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

		// Token: 0x060068A5 RID: 26789 RVA: 0x00222260 File Offset: 0x00220460
		public Span<float> GetOffsetBytes()
		{
			return this.__p.__vector_as_span<float>(14, 4);
		}

		// Token: 0x060068A6 RID: 26790 RVA: 0x00222270 File Offset: 0x00220470
		public float[] GetOffsetArray()
		{
			return this.__p.__vector_as_array<float>(14) ?? Array.Empty<float>();
		}

		// Token: 0x17000EE6 RID: 3814
		// (get) Token: 0x060068A7 RID: 26791 RVA: 0x00222288 File Offset: 0x00220488
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

		// Token: 0x060068A8 RID: 26792 RVA: 0x002222C0 File Offset: 0x002204C0
		public Span<byte> GetRemarkBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x060068A9 RID: 26793 RVA: 0x002222D0 File Offset: 0x002204D0
		public byte[] GetRemarkArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x060068AA RID: 26794 RVA: 0x002222E8 File Offset: 0x002204E8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用OffsetIter()或GetOffsetBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly float[] Offset()
		{
			EmotionBubbleMonsterConfig emotionBubbleMonsterConfig = this;
			return emotionBubbleMonsterConfig.GetOffsetArray() ?? Array.Empty<float>();
		}

		// Token: 0x060068AB RID: 26795 RVA: 0x0022230C File Offset: 0x0022050C
		[NullableContext(1)]
		public readonly IEnumerable<float> OffsetIter()
		{
			EmotionBubbleMonsterConfig.<OffsetIter>d__35 <OffsetIter>d__ = new EmotionBubbleMonsterConfig.<OffsetIter>d__35(-2);
			<OffsetIter>d__.<>3__<>4__this = this;
			return <OffsetIter>d__;
		}

		// Token: 0x060068AC RID: 26796 RVA: 0x00222321 File Offset: 0x00220521
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用StateTagListIter()或GetStateTagListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] StateTagList()
		{
			return this.StateTagListIter().ToArray<string>();
		}

		// Token: 0x060068AD RID: 26797 RVA: 0x0022232E File Offset: 0x0022052E
		[NullableContext(1)]
		public readonly IEnumerable<string> StateTagListIter()
		{
			EmotionBubbleMonsterConfig.<StateTagListIter>d__37 <StateTagListIter>d__ = new EmotionBubbleMonsterConfig.<StateTagListIter>d__37(-2);
			<StateTagListIter>d__.<>3__<>4__this = this;
			return <StateTagListIter>d__;
		}

		// Token: 0x04004C6C RID: 19564
		private Table __p;
	}
}

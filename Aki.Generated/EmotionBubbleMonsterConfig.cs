using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D0F RID: 3343
	public struct EmotionBubbleMonsterConfig : IFlatbufferObject
	{
		// Token: 0x17000F38 RID: 3896
		// (get) Token: 0x06006E93 RID: 28307 RVA: 0x002414E9 File Offset: 0x0023F6E9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006E94 RID: 28308 RVA: 0x002414F6 File Offset: 0x0023F6F6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006E95 RID: 28309 RVA: 0x00241500 File Offset: 0x0023F700
		public static EmotionBubbleMonsterConfig GetRootAsEmotionBubbleMonsterConfig(ByteBuffer _bb)
		{
			return EmotionBubbleMonsterConfig.GetRootAsEmotionBubbleMonsterConfig(_bb, default(EmotionBubbleMonsterConfig));
		}

		// Token: 0x06006E96 RID: 28310 RVA: 0x0024151C File Offset: 0x0023F71C
		public static EmotionBubbleMonsterConfig GetRootAsEmotionBubbleMonsterConfig(ByteBuffer _bb, EmotionBubbleMonsterConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006E97 RID: 28311 RVA: 0x00241539 File Offset: 0x0023F739
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006E98 RID: 28312 RVA: 0x00241548 File Offset: 0x0023F748
		public EmotionBubbleMonsterConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000F39 RID: 3897
		// (get) Token: 0x06006E99 RID: 28313 RVA: 0x00241558 File Offset: 0x0023F758
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

		// Token: 0x17000F3A RID: 3898
		// (get) Token: 0x06006E9A RID: 28314 RVA: 0x00241594 File Offset: 0x0023F794
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

		// Token: 0x06006E9B RID: 28315 RVA: 0x002415CB File Offset: 0x0023F7CB
		public Span<byte> GetMonsterBpBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06006E9C RID: 28316 RVA: 0x002415DA File Offset: 0x0023F7DA
		public byte[] GetMonsterBpArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x06006E9D RID: 28317 RVA: 0x002415F4 File Offset: 0x0023F7F4
		public string StateTagList(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000F3B RID: 3899
		// (get) Token: 0x06006E9E RID: 28318 RVA: 0x00241630 File Offset: 0x0023F830
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

		// Token: 0x17000F3C RID: 3900
		// (get) Token: 0x06006E9F RID: 28319 RVA: 0x0024165C File Offset: 0x0023F85C
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

		// Token: 0x06006EA0 RID: 28320 RVA: 0x00241694 File Offset: 0x0023F894
		public Span<byte> GetEmotionNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06006EA1 RID: 28321 RVA: 0x002416A4 File Offset: 0x0023F8A4
		public byte[] GetEmotionNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000F3D RID: 3901
		// (get) Token: 0x06006EA2 RID: 28322 RVA: 0x002416BC File Offset: 0x0023F8BC
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

		// Token: 0x06006EA3 RID: 28323 RVA: 0x002416F4 File Offset: 0x0023F8F4
		public Span<byte> GetAttachPointBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06006EA4 RID: 28324 RVA: 0x00241704 File Offset: 0x0023F904
		public byte[] GetAttachPointArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x06006EA5 RID: 28325 RVA: 0x0024171C File Offset: 0x0023F91C
		public float Offset(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000F3E RID: 3902
		// (get) Token: 0x06006EA6 RID: 28326 RVA: 0x00241760 File Offset: 0x0023F960
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

		// Token: 0x06006EA7 RID: 28327 RVA: 0x0024178C File Offset: 0x0023F98C
		public Span<float> GetOffsetBytes()
		{
			return this.__p.__vector_as_span<float>(14, 4);
		}

		// Token: 0x06006EA8 RID: 28328 RVA: 0x0024179C File Offset: 0x0023F99C
		public float[] GetOffsetArray()
		{
			return this.__p.__vector_as_array<float>(14) ?? Array.Empty<float>();
		}

		// Token: 0x17000F3F RID: 3903
		// (get) Token: 0x06006EA9 RID: 28329 RVA: 0x002417B4 File Offset: 0x0023F9B4
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

		// Token: 0x06006EAA RID: 28330 RVA: 0x002417EC File Offset: 0x0023F9EC
		public Span<byte> GetRemarkBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06006EAB RID: 28331 RVA: 0x002417FC File Offset: 0x0023F9FC
		public byte[] GetRemarkArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x06006EAC RID: 28332 RVA: 0x00241814 File Offset: 0x0023FA14
		[NullableContext(1)]
		public float[] Offset()
		{
			return this.GetOffsetArray();
		}

		// Token: 0x06006EAD RID: 28333 RVA: 0x0024181C File Offset: 0x0023FA1C
		[NullableContext(1)]
		public IEnumerable<float> OffsetIter()
		{
			EmotionBubbleMonsterConfig.<OffsetIter>d__35 <OffsetIter>d__ = new EmotionBubbleMonsterConfig.<OffsetIter>d__35(-2);
			<OffsetIter>d__.<>3__<>4__this = this;
			return <OffsetIter>d__;
		}

		// Token: 0x06006EAE RID: 28334 RVA: 0x00241831 File Offset: 0x0023FA31
		[NullableContext(1)]
		public string[] StateTagList()
		{
			return this.StateTagListIter().ToArray<string>();
		}

		// Token: 0x06006EAF RID: 28335 RVA: 0x0024183E File Offset: 0x0023FA3E
		[NullableContext(1)]
		public IEnumerable<string> StateTagListIter()
		{
			EmotionBubbleMonsterConfig.<StateTagListIter>d__37 <StateTagListIter>d__ = new EmotionBubbleMonsterConfig.<StateTagListIter>d__37(-2);
			<StateTagListIter>d__.<>3__<>4__this = this;
			return <StateTagListIter>d__;
		}

		// Token: 0x0400524F RID: 21071
		private Table __p;
	}
}

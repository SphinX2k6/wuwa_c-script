using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AF4 RID: 2804
	public struct AiTeamAreaNew : IFlatbufferObject
	{
		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x06004718 RID: 18200 RVA: 0x001D4431 File Offset: 0x001D2631
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004719 RID: 18201 RVA: 0x001D443E File Offset: 0x001D263E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600471A RID: 18202 RVA: 0x001D4448 File Offset: 0x001D2648
		public static AiTeamAreaNew GetRootAsAiTeamAreaNew(ByteBuffer _bb)
		{
			return AiTeamAreaNew.GetRootAsAiTeamAreaNew(_bb, default(AiTeamAreaNew));
		}

		// Token: 0x0600471B RID: 18203 RVA: 0x001D4464 File Offset: 0x001D2664
		public static AiTeamAreaNew GetRootAsAiTeamAreaNew(ByteBuffer _bb, AiTeamAreaNew obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600471C RID: 18204 RVA: 0x001D4481 File Offset: 0x001D2681
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600471D RID: 18205 RVA: 0x001D4490 File Offset: 0x001D2690
		public AiTeamAreaNew __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x0600471E RID: 18206 RVA: 0x001D44A0 File Offset: 0x001D26A0
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

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x0600471F RID: 18207 RVA: 0x001D44DC File Offset: 0x001D26DC
		public int MaxCharacter
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x06004720 RID: 18208 RVA: 0x001D4518 File Offset: 0x001D2718
		public FloatRange? ReactionTime
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new FloatRange?(default(FloatRange).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06004721 RID: 18209 RVA: 0x001D4578 File Offset: 0x001D2778
		public float CharTypes(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170002AA RID: 682
		// (get) Token: 0x06004722 RID: 18210 RVA: 0x001D45BC File Offset: 0x001D27BC
		public int CharTypesLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06004723 RID: 18211 RVA: 0x001D45E8 File Offset: 0x001D27E8
		public Span<float> GetCharTypesBytes()
		{
			return this.__p.__vector_as_span<float>(10, 4);
		}

		// Token: 0x06004724 RID: 18212 RVA: 0x001D45F8 File Offset: 0x001D27F8
		public float[] GetCharTypesArray()
		{
			return this.__p.__vector_as_array<float>(10) ?? Array.Empty<float>();
		}

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x06004725 RID: 18213 RVA: 0x001D4610 File Offset: 0x001D2810
		public float AreaAngle
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 75f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170002AC RID: 684
		// (get) Token: 0x06004726 RID: 18214 RVA: 0x001D4654 File Offset: 0x001D2854
		public FloatRange? AreaDistance
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return new FloatRange?(default(FloatRange).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x06004727 RID: 18215 RVA: 0x001D46B4 File Offset: 0x001D28B4
		public int AttackWeightId
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004728 RID: 18216 RVA: 0x001D46F4 File Offset: 0x001D28F4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用CharTypesIter()或GetCharTypesBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly float[] CharTypes()
		{
			AiTeamAreaNew aiTeamAreaNew = this;
			return aiTeamAreaNew.GetCharTypesArray() ?? Array.Empty<float>();
		}

		// Token: 0x06004729 RID: 18217 RVA: 0x001D4718 File Offset: 0x001D2918
		[NullableContext(1)]
		public readonly IEnumerable<float> CharTypesIter()
		{
			AiTeamAreaNew.<CharTypesIter>d__26 <CharTypesIter>d__ = new AiTeamAreaNew.<CharTypesIter>d__26(-2);
			<CharTypesIter>d__.<>3__<>4__this = this;
			return <CharTypesIter>d__;
		}

		// Token: 0x04004AD5 RID: 19157
		private Table __p;
	}
}

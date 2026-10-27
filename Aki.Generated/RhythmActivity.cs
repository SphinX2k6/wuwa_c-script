using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FBF RID: 4031
	public struct RhythmActivity : IFlatbufferObject
	{
		// Token: 0x17002E18 RID: 11800
		// (get) Token: 0x0600BC1C RID: 48156 RVA: 0x002DE648 File Offset: 0x002DC848
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BC1D RID: 48157 RVA: 0x002DE655 File Offset: 0x002DC855
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BC1E RID: 48158 RVA: 0x002DE65C File Offset: 0x002DC85C
		public static RhythmActivity GetRootAsRhythmActivity(ByteBuffer _bb)
		{
			return RhythmActivity.GetRootAsRhythmActivity(_bb, default(RhythmActivity));
		}

		// Token: 0x0600BC1F RID: 48159 RVA: 0x002DE678 File Offset: 0x002DC878
		public static RhythmActivity GetRootAsRhythmActivity(ByteBuffer _bb, RhythmActivity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BC20 RID: 48160 RVA: 0x002DE695 File Offset: 0x002DC895
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BC21 RID: 48161 RVA: 0x002DE6A4 File Offset: 0x002DC8A4
		public RhythmActivity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002E19 RID: 11801
		// (get) Token: 0x0600BC22 RID: 48162 RVA: 0x002DE6B4 File Offset: 0x002DC8B4
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

		// Token: 0x17002E1A RID: 11802
		// (get) Token: 0x0600BC23 RID: 48163 RVA: 0x002DE6F0 File Offset: 0x002DC8F0
		public int ActivityId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600BC24 RID: 48164 RVA: 0x002DE72C File Offset: 0x002DC92C
		public int Combo(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002E1B RID: 11803
		// (get) Token: 0x0600BC25 RID: 48165 RVA: 0x002DE76C File Offset: 0x002DC96C
		public int ComboLength
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

		// Token: 0x0600BC26 RID: 48166 RVA: 0x002DE797 File Offset: 0x002DC997
		public Span<int> GetComboBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600BC27 RID: 48167 RVA: 0x002DE7A6 File Offset: 0x002DC9A6
		public int[] GetComboArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x17002E1C RID: 11804
		// (get) Token: 0x0600BC28 RID: 48168 RVA: 0x002DE7C0 File Offset: 0x002DC9C0
		public int FeverLimit
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002E1D RID: 11805
		// (get) Token: 0x0600BC29 RID: 48169 RVA: 0x002DE800 File Offset: 0x002DCA00
		public int FeverCost
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002E1E RID: 11806
		// (get) Token: 0x0600BC2A RID: 48170 RVA: 0x002DE840 File Offset: 0x002DCA40
		public int NoteScore
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600BC2B RID: 48171 RVA: 0x002DE880 File Offset: 0x002DCA80
		public int SettleRatio(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002E1F RID: 11807
		// (get) Token: 0x0600BC2C RID: 48172 RVA: 0x002DE8C0 File Offset: 0x002DCAC0
		public int SettleRatioLength
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600BC2D RID: 48173 RVA: 0x002DE8EC File Offset: 0x002DCAEC
		public Span<int> GetSettleRatioBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x0600BC2E RID: 48174 RVA: 0x002DE8FC File Offset: 0x002DCAFC
		public int[] GetSettleRatioArray()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x17002E20 RID: 11808
		// (get) Token: 0x0600BC2F RID: 48175 RVA: 0x002DE914 File Offset: 0x002DCB14
		public int RecommendQuestId
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002E21 RID: 11809
		// (get) Token: 0x0600BC30 RID: 48176 RVA: 0x002DE954 File Offset: 0x002DCB54
		public string RecommendQuestTips
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600BC31 RID: 48177 RVA: 0x002DE98C File Offset: 0x002DCB8C
		public Span<byte> GetRecommendQuestTipsBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600BC32 RID: 48178 RVA: 0x002DE99C File Offset: 0x002DCB9C
		public byte[] GetRecommendQuestTipsArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x0600BC33 RID: 48179 RVA: 0x002DE9B4 File Offset: 0x002DCBB4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ComboIter()或GetComboBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Combo()
		{
			RhythmActivity rhythmActivity = this;
			return rhythmActivity.GetComboArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600BC34 RID: 48180 RVA: 0x002DE9D8 File Offset: 0x002DCBD8
		[NullableContext(1)]
		public readonly IEnumerable<int> ComboIter()
		{
			RhythmActivity.<ComboIter>d__35 <ComboIter>d__ = new RhythmActivity.<ComboIter>d__35(-2);
			<ComboIter>d__.<>3__<>4__this = this;
			return <ComboIter>d__;
		}

		// Token: 0x0600BC35 RID: 48181 RVA: 0x002DE9F0 File Offset: 0x002DCBF0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SettleRatioIter()或GetSettleRatioBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] SettleRatio()
		{
			RhythmActivity rhythmActivity = this;
			return rhythmActivity.GetSettleRatioArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600BC36 RID: 48182 RVA: 0x002DEA14 File Offset: 0x002DCC14
		[NullableContext(1)]
		public readonly IEnumerable<int> SettleRatioIter()
		{
			RhythmActivity.<SettleRatioIter>d__37 <SettleRatioIter>d__ = new RhythmActivity.<SettleRatioIter>d__37(-2);
			<SettleRatioIter>d__.<>3__<>4__this = this;
			return <SettleRatioIter>d__;
		}

		// Token: 0x04005099 RID: 20633
		private Table __p;
	}
}

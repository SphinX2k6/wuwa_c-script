using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D8C RID: 3468
	public struct KillMonstersScores : IFlatbufferObject
	{
		// Token: 0x17001A7D RID: 6781
		// (get) Token: 0x0600879A RID: 34714 RVA: 0x00268C35 File Offset: 0x00266E35
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600879B RID: 34715 RVA: 0x00268C42 File Offset: 0x00266E42
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600879C RID: 34716 RVA: 0x00268C4C File Offset: 0x00266E4C
		public static KillMonstersScores GetRootAsKillMonstersScores(ByteBuffer _bb)
		{
			return KillMonstersScores.GetRootAsKillMonstersScores(_bb, default(KillMonstersScores));
		}

		// Token: 0x0600879D RID: 34717 RVA: 0x00268C68 File Offset: 0x00266E68
		public static KillMonstersScores GetRootAsKillMonstersScores(ByteBuffer _bb, KillMonstersScores obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600879E RID: 34718 RVA: 0x00268C85 File Offset: 0x00266E85
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600879F RID: 34719 RVA: 0x00268C94 File Offset: 0x00266E94
		public KillMonstersScores __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001A7E RID: 6782
		// (get) Token: 0x060087A0 RID: 34720 RVA: 0x00268CA4 File Offset: 0x00266EA4
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

		// Token: 0x17001A7F RID: 6783
		// (get) Token: 0x060087A1 RID: 34721 RVA: 0x00268CE0 File Offset: 0x00266EE0
		public int InstanceID
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

		// Token: 0x17001A80 RID: 6784
		// (get) Token: 0x060087A2 RID: 34722 RVA: 0x00268D1C File Offset: 0x00266F1C
		public int ScoreMin
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001A81 RID: 6785
		// (get) Token: 0x060087A3 RID: 34723 RVA: 0x00268D58 File Offset: 0x00266F58
		public int ScoreMax
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

		// Token: 0x17001A82 RID: 6786
		// (get) Token: 0x060087A4 RID: 34724 RVA: 0x00268D98 File Offset: 0x00266F98
		public int Reward
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

		// Token: 0x060087A5 RID: 34725 RVA: 0x00268DD8 File Offset: 0x00266FD8
		public int DifficultyOptions(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001A83 RID: 6787
		// (get) Token: 0x060087A6 RID: 34726 RVA: 0x00268E18 File Offset: 0x00267018
		public int DifficultyOptionsLength
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

		// Token: 0x060087A7 RID: 34727 RVA: 0x00268E44 File Offset: 0x00267044
		public Span<int> GetDifficultyOptionsBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x060087A8 RID: 34728 RVA: 0x00268E54 File Offset: 0x00267054
		public int[] GetDifficultyOptionsArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x17001A84 RID: 6788
		// (get) Token: 0x060087A9 RID: 34729 RVA: 0x00268E6C File Offset: 0x0026706C
		public string Desc
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

		// Token: 0x060087AA RID: 34730 RVA: 0x00268EA4 File Offset: 0x002670A4
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x060087AB RID: 34731 RVA: 0x00268EB4 File Offset: 0x002670B4
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x060087AC RID: 34732 RVA: 0x00268ECC File Offset: 0x002670CC
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用DifficultyOptionsIter()或GetDifficultyOptionsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] DifficultyOptions()
		{
			KillMonstersScores killMonstersScores = this;
			return killMonstersScores.GetDifficultyOptionsArray() ?? Array.Empty<int>();
		}

		// Token: 0x060087AD RID: 34733 RVA: 0x00268EF0 File Offset: 0x002670F0
		[NullableContext(1)]
		public readonly IEnumerable<int> DifficultyOptionsIter()
		{
			KillMonstersScores.<DifficultyOptionsIter>d__28 <DifficultyOptionsIter>d__ = new KillMonstersScores.<DifficultyOptionsIter>d__28(-2);
			<DifficultyOptionsIter>d__.<>3__<>4__this = this;
			return <DifficultyOptionsIter>d__;
		}

		// Token: 0x04004E18 RID: 19992
		private Table __p;
	}
}

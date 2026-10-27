using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010CC RID: 4300
	public struct SlashAndTowerCfg : IFlatbufferObject
	{
		// Token: 0x17003737 RID: 14135
		// (get) Token: 0x0600D660 RID: 54880 RVA: 0x0031A948 File Offset: 0x00318B48
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D661 RID: 54881 RVA: 0x0031A955 File Offset: 0x00318B55
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D662 RID: 54882 RVA: 0x0031A95C File Offset: 0x00318B5C
		public static SlashAndTowerCfg GetRootAsSlashAndTowerCfg(ByteBuffer _bb)
		{
			return SlashAndTowerCfg.GetRootAsSlashAndTowerCfg(_bb, default(SlashAndTowerCfg));
		}

		// Token: 0x0600D663 RID: 54883 RVA: 0x0031A978 File Offset: 0x00318B78
		public static SlashAndTowerCfg GetRootAsSlashAndTowerCfg(ByteBuffer _bb, SlashAndTowerCfg obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D664 RID: 54884 RVA: 0x0031A995 File Offset: 0x00318B95
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D665 RID: 54885 RVA: 0x0031A9A4 File Offset: 0x00318BA4
		public SlashAndTowerCfg __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003738 RID: 14136
		// (get) Token: 0x0600D666 RID: 54886 RVA: 0x0031A9B4 File Offset: 0x00318BB4
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

		// Token: 0x17003739 RID: 14137
		// (get) Token: 0x0600D667 RID: 54887 RVA: 0x0031A9F0 File Offset: 0x00318BF0
		public int Season
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

		// Token: 0x1700373A RID: 14138
		// (get) Token: 0x0600D668 RID: 54888 RVA: 0x0031AA2C File Offset: 0x00318C2C
		public int SeasonVersion
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

		// Token: 0x1700373B RID: 14139
		// (get) Token: 0x0600D669 RID: 54889 RVA: 0x0031AA68 File Offset: 0x00318C68
		public bool EndLess
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0600D66A RID: 54890 RVA: 0x0031AAA8 File Offset: 0x00318CA8
		public int InstIds(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700373C RID: 14140
		// (get) Token: 0x0600D66B RID: 54891 RVA: 0x0031AAE8 File Offset: 0x00318CE8
		public int InstIdsLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600D66C RID: 54892 RVA: 0x0031AB14 File Offset: 0x00318D14
		public Span<int> GetInstIdsBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x0600D66D RID: 54893 RVA: 0x0031AB24 File Offset: 0x00318D24
		public int[] GetInstIdsArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x0600D66E RID: 54894 RVA: 0x0031AB3C File Offset: 0x00318D3C
		public int PreLevel(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700373D RID: 14141
		// (get) Token: 0x0600D66F RID: 54895 RVA: 0x0031AB7C File Offset: 0x00318D7C
		public int PreLevelLength
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

		// Token: 0x0600D670 RID: 54896 RVA: 0x0031ABA8 File Offset: 0x00318DA8
		public Span<int> GetPreLevelBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x0600D671 RID: 54897 RVA: 0x0031ABB8 File Offset: 0x00318DB8
		public int[] GetPreLevelArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x1700373E RID: 14142
		// (get) Token: 0x0600D672 RID: 54898 RVA: 0x0031ABD0 File Offset: 0x00318DD0
		public int PassScore
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700373F RID: 14143
		// (get) Token: 0x0600D673 RID: 54899 RVA: 0x0031AC10 File Offset: 0x00318E10
		public int LevelPassReward
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

		// Token: 0x17003740 RID: 14144
		// (get) Token: 0x0600D674 RID: 54900 RVA: 0x0031AC50 File Offset: 0x00318E50
		public string Title
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

		// Token: 0x0600D675 RID: 54901 RVA: 0x0031AC88 File Offset: 0x00318E88
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600D676 RID: 54902 RVA: 0x0031AC98 File Offset: 0x00318E98
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17003741 RID: 14145
		// (get) Token: 0x0600D677 RID: 54903 RVA: 0x0031ACB0 File Offset: 0x00318EB0
		public string Desc
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D678 RID: 54904 RVA: 0x0031ACE8 File Offset: 0x00318EE8
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600D679 RID: 54905 RVA: 0x0031ACF8 File Offset: 0x00318EF8
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x0600D67A RID: 54906 RVA: 0x0031AD10 File Offset: 0x00318F10
		public int TargetScore(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003742 RID: 14146
		// (get) Token: 0x0600D67B RID: 54907 RVA: 0x0031AD50 File Offset: 0x00318F50
		public int TargetScoreLength
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600D67C RID: 54908 RVA: 0x0031AD7C File Offset: 0x00318F7C
		public Span<int> GetTargetScoreBytes()
		{
			return this.__p.__vector_as_span<int>(24, 4);
		}

		// Token: 0x0600D67D RID: 54909 RVA: 0x0031AD8C File Offset: 0x00318F8C
		public int[] GetTargetScoreArray()
		{
			return this.__p.__vector_as_array<int>(24) ?? Array.Empty<int>();
		}

		// Token: 0x0600D67E RID: 54910 RVA: 0x0031ADA4 File Offset: 0x00318FA4
		public string ScoreStage(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003743 RID: 14147
		// (get) Token: 0x0600D67F RID: 54911 RVA: 0x0031ADE0 File Offset: 0x00318FE0
		public int ScoreStageLength
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17003744 RID: 14148
		// (get) Token: 0x0600D680 RID: 54912 RVA: 0x0031AE0C File Offset: 0x0031900C
		public bool IsHaveBattleScore
		{
			get
			{
				int num = this.__p.__offset(28);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17003745 RID: 14149
		// (get) Token: 0x0600D681 RID: 54913 RVA: 0x0031AE4C File Offset: 0x0031904C
		public int OrderIndex
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D682 RID: 54914 RVA: 0x0031AE8C File Offset: 0x0031908C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用InstIdsIter()或GetInstIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] InstIds()
		{
			SlashAndTowerCfg slashAndTowerCfg = this;
			return slashAndTowerCfg.GetInstIdsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600D683 RID: 54915 RVA: 0x0031AEB0 File Offset: 0x003190B0
		[NullableContext(1)]
		public readonly IEnumerable<int> InstIdsIter()
		{
			SlashAndTowerCfg.<InstIdsIter>d__51 <InstIdsIter>d__ = new SlashAndTowerCfg.<InstIdsIter>d__51(-2);
			<InstIdsIter>d__.<>3__<>4__this = this;
			return <InstIdsIter>d__;
		}

		// Token: 0x0600D684 RID: 54916 RVA: 0x0031AEC8 File Offset: 0x003190C8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用PreLevelIter()或GetPreLevelBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] PreLevel()
		{
			SlashAndTowerCfg slashAndTowerCfg = this;
			return slashAndTowerCfg.GetPreLevelArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600D685 RID: 54917 RVA: 0x0031AEEC File Offset: 0x003190EC
		[NullableContext(1)]
		public readonly IEnumerable<int> PreLevelIter()
		{
			SlashAndTowerCfg.<PreLevelIter>d__53 <PreLevelIter>d__ = new SlashAndTowerCfg.<PreLevelIter>d__53(-2);
			<PreLevelIter>d__.<>3__<>4__this = this;
			return <PreLevelIter>d__;
		}

		// Token: 0x0600D686 RID: 54918 RVA: 0x0031AF01 File Offset: 0x00319101
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ScoreStageIter()或GetScoreStageBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] ScoreStage()
		{
			return this.ScoreStageIter().ToArray<string>();
		}

		// Token: 0x0600D687 RID: 54919 RVA: 0x0031AF0E File Offset: 0x0031910E
		[NullableContext(1)]
		public readonly IEnumerable<string> ScoreStageIter()
		{
			SlashAndTowerCfg.<ScoreStageIter>d__55 <ScoreStageIter>d__ = new SlashAndTowerCfg.<ScoreStageIter>d__55(-2);
			<ScoreStageIter>d__.<>3__<>4__this = this;
			return <ScoreStageIter>d__;
		}

		// Token: 0x0600D688 RID: 54920 RVA: 0x0031AF24 File Offset: 0x00319124
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用TargetScoreIter()或GetTargetScoreBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] TargetScore()
		{
			SlashAndTowerCfg slashAndTowerCfg = this;
			return slashAndTowerCfg.GetTargetScoreArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600D689 RID: 54921 RVA: 0x0031AF48 File Offset: 0x00319148
		[NullableContext(1)]
		public readonly IEnumerable<int> TargetScoreIter()
		{
			SlashAndTowerCfg.<TargetScoreIter>d__57 <TargetScoreIter>d__ = new SlashAndTowerCfg.<TargetScoreIter>d__57(-2);
			<TargetScoreIter>d__.<>3__<>4__this = this;
			return <TargetScoreIter>d__;
		}

		// Token: 0x040051FE RID: 20990
		private Table __p;
	}
}

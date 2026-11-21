using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011C7 RID: 4551
	public struct SlashAndTowerCfg : IFlatbufferObject
	{
		// Token: 0x17003848 RID: 14408
		// (get) Token: 0x0600DE3D RID: 56893 RVA: 0x0033991C File Offset: 0x00337B1C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DE3E RID: 56894 RVA: 0x00339929 File Offset: 0x00337B29
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DE3F RID: 56895 RVA: 0x00339930 File Offset: 0x00337B30
		public static SlashAndTowerCfg GetRootAsSlashAndTowerCfg(ByteBuffer _bb)
		{
			return SlashAndTowerCfg.GetRootAsSlashAndTowerCfg(_bb, default(SlashAndTowerCfg));
		}

		// Token: 0x0600DE40 RID: 56896 RVA: 0x0033994C File Offset: 0x00337B4C
		public static SlashAndTowerCfg GetRootAsSlashAndTowerCfg(ByteBuffer _bb, SlashAndTowerCfg obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DE41 RID: 56897 RVA: 0x00339969 File Offset: 0x00337B69
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DE42 RID: 56898 RVA: 0x00339978 File Offset: 0x00337B78
		public SlashAndTowerCfg __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003849 RID: 14409
		// (get) Token: 0x0600DE43 RID: 56899 RVA: 0x00339988 File Offset: 0x00337B88
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

		// Token: 0x1700384A RID: 14410
		// (get) Token: 0x0600DE44 RID: 56900 RVA: 0x003399C4 File Offset: 0x00337BC4
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

		// Token: 0x1700384B RID: 14411
		// (get) Token: 0x0600DE45 RID: 56901 RVA: 0x00339A00 File Offset: 0x00337C00
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

		// Token: 0x1700384C RID: 14412
		// (get) Token: 0x0600DE46 RID: 56902 RVA: 0x00339A3C File Offset: 0x00337C3C
		public bool EndLess
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0600DE47 RID: 56903 RVA: 0x00339A7C File Offset: 0x00337C7C
		public int InstIds(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700384D RID: 14413
		// (get) Token: 0x0600DE48 RID: 56904 RVA: 0x00339ABC File Offset: 0x00337CBC
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

		// Token: 0x0600DE49 RID: 56905 RVA: 0x00339AE8 File Offset: 0x00337CE8
		public Span<int> GetInstIdsBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x0600DE4A RID: 56906 RVA: 0x00339AF8 File Offset: 0x00337CF8
		public int[] GetInstIdsArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x0600DE4B RID: 56907 RVA: 0x00339B10 File Offset: 0x00337D10
		public int PreLevel(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700384E RID: 14414
		// (get) Token: 0x0600DE4C RID: 56908 RVA: 0x00339B50 File Offset: 0x00337D50
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

		// Token: 0x0600DE4D RID: 56909 RVA: 0x00339B7C File Offset: 0x00337D7C
		public Span<int> GetPreLevelBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x0600DE4E RID: 56910 RVA: 0x00339B8C File Offset: 0x00337D8C
		public int[] GetPreLevelArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x1700384F RID: 14415
		// (get) Token: 0x0600DE4F RID: 56911 RVA: 0x00339BA4 File Offset: 0x00337DA4
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

		// Token: 0x17003850 RID: 14416
		// (get) Token: 0x0600DE50 RID: 56912 RVA: 0x00339BE4 File Offset: 0x00337DE4
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

		// Token: 0x17003851 RID: 14417
		// (get) Token: 0x0600DE51 RID: 56913 RVA: 0x00339C24 File Offset: 0x00337E24
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

		// Token: 0x0600DE52 RID: 56914 RVA: 0x00339C5C File Offset: 0x00337E5C
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600DE53 RID: 56915 RVA: 0x00339C6C File Offset: 0x00337E6C
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17003852 RID: 14418
		// (get) Token: 0x0600DE54 RID: 56916 RVA: 0x00339C84 File Offset: 0x00337E84
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

		// Token: 0x0600DE55 RID: 56917 RVA: 0x00339CBC File Offset: 0x00337EBC
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600DE56 RID: 56918 RVA: 0x00339CCC File Offset: 0x00337ECC
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x0600DE57 RID: 56919 RVA: 0x00339CE4 File Offset: 0x00337EE4
		public int TargetScore(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003853 RID: 14419
		// (get) Token: 0x0600DE58 RID: 56920 RVA: 0x00339D24 File Offset: 0x00337F24
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

		// Token: 0x0600DE59 RID: 56921 RVA: 0x00339D50 File Offset: 0x00337F50
		public Span<int> GetTargetScoreBytes()
		{
			return this.__p.__vector_as_span<int>(24, 4);
		}

		// Token: 0x0600DE5A RID: 56922 RVA: 0x00339D60 File Offset: 0x00337F60
		public int[] GetTargetScoreArray()
		{
			return this.__p.__vector_as_array<int>(24) ?? Array.Empty<int>();
		}

		// Token: 0x0600DE5B RID: 56923 RVA: 0x00339D78 File Offset: 0x00337F78
		public string ScoreStage(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003854 RID: 14420
		// (get) Token: 0x0600DE5C RID: 56924 RVA: 0x00339DB4 File Offset: 0x00337FB4
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

		// Token: 0x17003855 RID: 14421
		// (get) Token: 0x0600DE5D RID: 56925 RVA: 0x00339DE0 File Offset: 0x00337FE0
		public bool IsHaveBattleScore
		{
			get
			{
				int num = this.__p.__offset(28);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17003856 RID: 14422
		// (get) Token: 0x0600DE5E RID: 56926 RVA: 0x00339E20 File Offset: 0x00338020
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

		// Token: 0x0600DE5F RID: 56927 RVA: 0x00339E5D File Offset: 0x0033805D
		[NullableContext(1)]
		public int[] InstIds()
		{
			return this.GetInstIdsArray();
		}

		// Token: 0x0600DE60 RID: 56928 RVA: 0x00339E65 File Offset: 0x00338065
		[NullableContext(1)]
		public IEnumerable<int> InstIdsIter()
		{
			SlashAndTowerCfg.<InstIdsIter>d__51 <InstIdsIter>d__ = new SlashAndTowerCfg.<InstIdsIter>d__51(-2);
			<InstIdsIter>d__.<>3__<>4__this = this;
			return <InstIdsIter>d__;
		}

		// Token: 0x0600DE61 RID: 56929 RVA: 0x00339E7A File Offset: 0x0033807A
		[NullableContext(1)]
		public int[] PreLevel()
		{
			return this.GetPreLevelArray();
		}

		// Token: 0x0600DE62 RID: 56930 RVA: 0x00339E82 File Offset: 0x00338082
		[NullableContext(1)]
		public IEnumerable<int> PreLevelIter()
		{
			SlashAndTowerCfg.<PreLevelIter>d__53 <PreLevelIter>d__ = new SlashAndTowerCfg.<PreLevelIter>d__53(-2);
			<PreLevelIter>d__.<>3__<>4__this = this;
			return <PreLevelIter>d__;
		}

		// Token: 0x0600DE63 RID: 56931 RVA: 0x00339E97 File Offset: 0x00338097
		[NullableContext(1)]
		public string[] ScoreStage()
		{
			return this.ScoreStageIter().ToArray<string>();
		}

		// Token: 0x0600DE64 RID: 56932 RVA: 0x00339EA4 File Offset: 0x003380A4
		[NullableContext(1)]
		public IEnumerable<string> ScoreStageIter()
		{
			SlashAndTowerCfg.<ScoreStageIter>d__55 <ScoreStageIter>d__ = new SlashAndTowerCfg.<ScoreStageIter>d__55(-2);
			<ScoreStageIter>d__.<>3__<>4__this = this;
			return <ScoreStageIter>d__;
		}

		// Token: 0x0600DE65 RID: 56933 RVA: 0x00339EB9 File Offset: 0x003380B9
		[NullableContext(1)]
		public int[] TargetScore()
		{
			return this.GetTargetScoreArray();
		}

		// Token: 0x0600DE66 RID: 56934 RVA: 0x00339EC1 File Offset: 0x003380C1
		[NullableContext(1)]
		public IEnumerable<int> TargetScoreIter()
		{
			SlashAndTowerCfg.<TargetScoreIter>d__57 <TargetScoreIter>d__ = new SlashAndTowerCfg.<TargetScoreIter>d__57(-2);
			<TargetScoreIter>d__.<>3__<>4__this = this;
			return <TargetScoreIter>d__;
		}

		// Token: 0x040057FD RID: 22525
		private Table __p;
	}
}

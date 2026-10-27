using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001154 RID: 4436
	public struct TrapDefenseAuxiliary : IFlatbufferObject
	{
		// Token: 0x17003B9D RID: 15261
		// (get) Token: 0x0600E208 RID: 57864 RVA: 0x003352D8 File Offset: 0x003334D8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E209 RID: 57865 RVA: 0x003352E5 File Offset: 0x003334E5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E20A RID: 57866 RVA: 0x003352EC File Offset: 0x003334EC
		public static TrapDefenseAuxiliary GetRootAsTrapDefenseAuxiliary(ByteBuffer _bb)
		{
			return TrapDefenseAuxiliary.GetRootAsTrapDefenseAuxiliary(_bb, default(TrapDefenseAuxiliary));
		}

		// Token: 0x0600E20B RID: 57867 RVA: 0x00335308 File Offset: 0x00333508
		public static TrapDefenseAuxiliary GetRootAsTrapDefenseAuxiliary(ByteBuffer _bb, TrapDefenseAuxiliary obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E20C RID: 57868 RVA: 0x00335325 File Offset: 0x00333525
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E20D RID: 57869 RVA: 0x00335334 File Offset: 0x00333534
		public TrapDefenseAuxiliary __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003B9E RID: 15262
		// (get) Token: 0x0600E20E RID: 57870 RVA: 0x00335344 File Offset: 0x00333544
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

		// Token: 0x17003B9F RID: 15263
		// (get) Token: 0x0600E20F RID: 57871 RVA: 0x00335380 File Offset: 0x00333580
		public string Desc
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

		// Token: 0x0600E210 RID: 57872 RVA: 0x003353B7 File Offset: 0x003335B7
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600E211 RID: 57873 RVA: 0x003353C6 File Offset: 0x003335C6
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x0600E212 RID: 57874 RVA: 0x003353E0 File Offset: 0x003335E0
		public string DescArgs(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003BA0 RID: 15264
		// (get) Token: 0x0600E213 RID: 57875 RVA: 0x0033541C File Offset: 0x0033361C
		public int DescArgsLength
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

		// Token: 0x17003BA1 RID: 15265
		// (get) Token: 0x0600E214 RID: 57876 RVA: 0x00335448 File Offset: 0x00333648
		public string DescDetail
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

		// Token: 0x0600E215 RID: 57877 RVA: 0x00335480 File Offset: 0x00333680
		public Span<byte> GetDescDetailBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600E216 RID: 57878 RVA: 0x00335490 File Offset: 0x00333690
		public byte[] GetDescDetailArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x0600E217 RID: 57879 RVA: 0x003354A8 File Offset: 0x003336A8
		public string DescDetailArgs(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003BA2 RID: 15266
		// (get) Token: 0x0600E218 RID: 57880 RVA: 0x003354E4 File Offset: 0x003336E4
		public int DescDetailArgsLength
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

		// Token: 0x17003BA3 RID: 15267
		// (get) Token: 0x0600E219 RID: 57881 RVA: 0x00335510 File Offset: 0x00333710
		public int AuxiliaryType
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

		// Token: 0x17003BA4 RID: 15268
		// (get) Token: 0x0600E21A RID: 57882 RVA: 0x00335550 File Offset: 0x00333750
		public int SimpleCombatSubtypeId
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

		// Token: 0x0600E21B RID: 57883 RVA: 0x00335590 File Offset: 0x00333790
		public int InitBuffs(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003BA5 RID: 15269
		// (get) Token: 0x0600E21C RID: 57884 RVA: 0x003355D0 File Offset: 0x003337D0
		public int InitBuffsLength
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600E21D RID: 57885 RVA: 0x003355FC File Offset: 0x003337FC
		public Span<int> GetInitBuffsBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x0600E21E RID: 57886 RVA: 0x0033560C File Offset: 0x0033380C
		public int[] GetInitBuffsArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x17003BA6 RID: 15270
		// (get) Token: 0x0600E21F RID: 57887 RVA: 0x00335624 File Offset: 0x00333824
		public int Level
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003BA7 RID: 15271
		// (get) Token: 0x0600E220 RID: 57888 RVA: 0x00335664 File Offset: 0x00333864
		public int Branch
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003BA8 RID: 15272
		// (get) Token: 0x0600E221 RID: 57889 RVA: 0x003356A4 File Offset: 0x003338A4
		public string BranchDesc
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E222 RID: 57890 RVA: 0x003356DC File Offset: 0x003338DC
		public Span<byte> GetBranchDescBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600E223 RID: 57891 RVA: 0x003356EC File Offset: 0x003338EC
		public byte[] GetBranchDescArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x0600E224 RID: 57892 RVA: 0x00335704 File Offset: 0x00333904
		public string BranchDescArgs(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003BA9 RID: 15273
		// (get) Token: 0x0600E225 RID: 57893 RVA: 0x00335740 File Offset: 0x00333940
		public int BranchDescArgsLength
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

		// Token: 0x17003BAA RID: 15274
		// (get) Token: 0x0600E226 RID: 57894 RVA: 0x0033576C File Offset: 0x0033396C
		public float CoolDown
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003BAB RID: 15275
		// (get) Token: 0x0600E227 RID: 57895 RVA: 0x003357B0 File Offset: 0x003339B0
		public int UpgradeCost
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

		// Token: 0x17003BAC RID: 15276
		// (get) Token: 0x0600E228 RID: 57896 RVA: 0x003357F0 File Offset: 0x003339F0
		public int ConstructDefaultCost
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E229 RID: 57897 RVA: 0x00335830 File Offset: 0x00333A30
		public int InitSkills(int j)
		{
			int num = this.__p.__offset(34);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003BAD RID: 15277
		// (get) Token: 0x0600E22A RID: 57898 RVA: 0x00335870 File Offset: 0x00333A70
		public int InitSkillsLength
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600E22B RID: 57899 RVA: 0x0033589C File Offset: 0x00333A9C
		public Span<int> GetInitSkillsBytes()
		{
			return this.__p.__vector_as_span<int>(34, 4);
		}

		// Token: 0x0600E22C RID: 57900 RVA: 0x003358AC File Offset: 0x00333AAC
		public int[] GetInitSkillsArray()
		{
			return this.__p.__vector_as_array<int>(34) ?? Array.Empty<int>();
		}

		// Token: 0x17003BAE RID: 15278
		// (get) Token: 0x0600E22D RID: 57901 RVA: 0x003358C4 File Offset: 0x00333AC4
		public int InitProperty
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003BAF RID: 15279
		// (get) Token: 0x0600E22E RID: 57902 RVA: 0x00335904 File Offset: 0x00333B04
		public int CDSkill
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E22F RID: 57903 RVA: 0x00335944 File Offset: 0x00333B44
		public int CueIds(int j)
		{
			int num = this.__p.__offset(40);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003BB0 RID: 15280
		// (get) Token: 0x0600E230 RID: 57904 RVA: 0x00335984 File Offset: 0x00333B84
		public int CueIdsLength
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600E231 RID: 57905 RVA: 0x003359B0 File Offset: 0x00333BB0
		public Span<int> GetCueIdsBytes()
		{
			return this.__p.__vector_as_span<int>(40, 4);
		}

		// Token: 0x0600E232 RID: 57906 RVA: 0x003359C0 File Offset: 0x00333BC0
		public int[] GetCueIdsArray()
		{
			return this.__p.__vector_as_array<int>(40) ?? Array.Empty<int>();
		}

		// Token: 0x0600E233 RID: 57907 RVA: 0x003359D8 File Offset: 0x00333BD8
		public int CDCueId(int j)
		{
			int num = this.__p.__offset(42);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003BB1 RID: 15281
		// (get) Token: 0x0600E234 RID: 57908 RVA: 0x00335A18 File Offset: 0x00333C18
		public int CDCueIdLength
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600E235 RID: 57909 RVA: 0x00335A44 File Offset: 0x00333C44
		public Span<int> GetCDCueIdBytes()
		{
			return this.__p.__vector_as_span<int>(42, 4);
		}

		// Token: 0x0600E236 RID: 57910 RVA: 0x00335A54 File Offset: 0x00333C54
		public int[] GetCDCueIdArray()
		{
			return this.__p.__vector_as_array<int>(42) ?? Array.Empty<int>();
		}

		// Token: 0x0600E237 RID: 57911 RVA: 0x00335A6C File Offset: 0x00333C6C
		public int ReadyCueId(int j)
		{
			int num = this.__p.__offset(44);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003BB2 RID: 15282
		// (get) Token: 0x0600E238 RID: 57912 RVA: 0x00335AAC File Offset: 0x00333CAC
		public int ReadyCueIdLength
		{
			get
			{
				int num = this.__p.__offset(44);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600E239 RID: 57913 RVA: 0x00335AD8 File Offset: 0x00333CD8
		public Span<int> GetReadyCueIdBytes()
		{
			return this.__p.__vector_as_span<int>(44, 4);
		}

		// Token: 0x0600E23A RID: 57914 RVA: 0x00335AE8 File Offset: 0x00333CE8
		public int[] GetReadyCueIdArray()
		{
			return this.__p.__vector_as_array<int>(44) ?? Array.Empty<int>();
		}

		// Token: 0x0600E23B RID: 57915 RVA: 0x00335B00 File Offset: 0x00333D00
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BranchDescArgsIter()或GetBranchDescArgsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] BranchDescArgs()
		{
			return this.BranchDescArgsIter().ToArray<string>();
		}

		// Token: 0x0600E23C RID: 57916 RVA: 0x00335B0D File Offset: 0x00333D0D
		[NullableContext(1)]
		public readonly IEnumerable<string> BranchDescArgsIter()
		{
			TrapDefenseAuxiliary.<BranchDescArgsIter>d__75 <BranchDescArgsIter>d__ = new TrapDefenseAuxiliary.<BranchDescArgsIter>d__75(-2);
			<BranchDescArgsIter>d__.<>3__<>4__this = this;
			return <BranchDescArgsIter>d__;
		}

		// Token: 0x0600E23D RID: 57917 RVA: 0x00335B24 File Offset: 0x00333D24
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用CDCueIdIter()或GetCDCueIdBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] CDCueId()
		{
			TrapDefenseAuxiliary trapDefenseAuxiliary = this;
			return trapDefenseAuxiliary.GetCDCueIdArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600E23E RID: 57918 RVA: 0x00335B48 File Offset: 0x00333D48
		[NullableContext(1)]
		public readonly IEnumerable<int> CDCueIdIter()
		{
			TrapDefenseAuxiliary.<CDCueIdIter>d__77 <CDCueIdIter>d__ = new TrapDefenseAuxiliary.<CDCueIdIter>d__77(-2);
			<CDCueIdIter>d__.<>3__<>4__this = this;
			return <CDCueIdIter>d__;
		}

		// Token: 0x0600E23F RID: 57919 RVA: 0x00335B60 File Offset: 0x00333D60
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用CueIdsIter()或GetCueIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] CueIds()
		{
			TrapDefenseAuxiliary trapDefenseAuxiliary = this;
			return trapDefenseAuxiliary.GetCueIdsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600E240 RID: 57920 RVA: 0x00335B84 File Offset: 0x00333D84
		[NullableContext(1)]
		public readonly IEnumerable<int> CueIdsIter()
		{
			TrapDefenseAuxiliary.<CueIdsIter>d__79 <CueIdsIter>d__ = new TrapDefenseAuxiliary.<CueIdsIter>d__79(-2);
			<CueIdsIter>d__.<>3__<>4__this = this;
			return <CueIdsIter>d__;
		}

		// Token: 0x0600E241 RID: 57921 RVA: 0x00335B99 File Offset: 0x00333D99
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用DescArgsIter()或GetDescArgsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] DescArgs()
		{
			return this.DescArgsIter().ToArray<string>();
		}

		// Token: 0x0600E242 RID: 57922 RVA: 0x00335BA6 File Offset: 0x00333DA6
		[NullableContext(1)]
		public readonly IEnumerable<string> DescArgsIter()
		{
			TrapDefenseAuxiliary.<DescArgsIter>d__81 <DescArgsIter>d__ = new TrapDefenseAuxiliary.<DescArgsIter>d__81(-2);
			<DescArgsIter>d__.<>3__<>4__this = this;
			return <DescArgsIter>d__;
		}

		// Token: 0x0600E243 RID: 57923 RVA: 0x00335BBB File Offset: 0x00333DBB
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用DescDetailArgsIter()或GetDescDetailArgsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] DescDetailArgs()
		{
			return this.DescDetailArgsIter().ToArray<string>();
		}

		// Token: 0x0600E244 RID: 57924 RVA: 0x00335BC8 File Offset: 0x00333DC8
		[NullableContext(1)]
		public readonly IEnumerable<string> DescDetailArgsIter()
		{
			TrapDefenseAuxiliary.<DescDetailArgsIter>d__83 <DescDetailArgsIter>d__ = new TrapDefenseAuxiliary.<DescDetailArgsIter>d__83(-2);
			<DescDetailArgsIter>d__.<>3__<>4__this = this;
			return <DescDetailArgsIter>d__;
		}

		// Token: 0x0600E245 RID: 57925 RVA: 0x00335BE0 File Offset: 0x00333DE0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用InitBuffsIter()或GetInitBuffsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] InitBuffs()
		{
			TrapDefenseAuxiliary trapDefenseAuxiliary = this;
			return trapDefenseAuxiliary.GetInitBuffsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600E246 RID: 57926 RVA: 0x00335C04 File Offset: 0x00333E04
		[NullableContext(1)]
		public readonly IEnumerable<int> InitBuffsIter()
		{
			TrapDefenseAuxiliary.<InitBuffsIter>d__85 <InitBuffsIter>d__ = new TrapDefenseAuxiliary.<InitBuffsIter>d__85(-2);
			<InitBuffsIter>d__.<>3__<>4__this = this;
			return <InitBuffsIter>d__;
		}

		// Token: 0x0600E247 RID: 57927 RVA: 0x00335C1C File Offset: 0x00333E1C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用InitSkillsIter()或GetInitSkillsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] InitSkills()
		{
			TrapDefenseAuxiliary trapDefenseAuxiliary = this;
			return trapDefenseAuxiliary.GetInitSkillsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600E248 RID: 57928 RVA: 0x00335C40 File Offset: 0x00333E40
		[NullableContext(1)]
		public readonly IEnumerable<int> InitSkillsIter()
		{
			TrapDefenseAuxiliary.<InitSkillsIter>d__87 <InitSkillsIter>d__ = new TrapDefenseAuxiliary.<InitSkillsIter>d__87(-2);
			<InitSkillsIter>d__.<>3__<>4__this = this;
			return <InitSkillsIter>d__;
		}

		// Token: 0x0600E249 RID: 57929 RVA: 0x00335C58 File Offset: 0x00333E58
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ReadyCueIdIter()或GetReadyCueIdBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ReadyCueId()
		{
			TrapDefenseAuxiliary trapDefenseAuxiliary = this;
			return trapDefenseAuxiliary.GetReadyCueIdArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600E24A RID: 57930 RVA: 0x00335C7C File Offset: 0x00333E7C
		[NullableContext(1)]
		public readonly IEnumerable<int> ReadyCueIdIter()
		{
			TrapDefenseAuxiliary.<ReadyCueIdIter>d__89 <ReadyCueIdIter>d__ = new TrapDefenseAuxiliary.<ReadyCueIdIter>d__89(-2);
			<ReadyCueIdIter>d__.<>3__<>4__this = this;
			return <ReadyCueIdIter>d__;
		}

		// Token: 0x04005299 RID: 21145
		private Table __p;
	}
}

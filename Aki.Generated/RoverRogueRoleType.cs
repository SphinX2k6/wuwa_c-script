using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001086 RID: 4230
	public struct RoverRogueRoleType : IFlatbufferObject
	{
		// Token: 0x170034B4 RID: 13492
		// (get) Token: 0x0600CF00 RID: 52992 RVA: 0x00308B5D File Offset: 0x00306D5D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CF01 RID: 52993 RVA: 0x00308B6A File Offset: 0x00306D6A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CF02 RID: 52994 RVA: 0x00308B74 File Offset: 0x00306D74
		public static RoverRogueRoleType GetRootAsRoverRogueRoleType(ByteBuffer _bb)
		{
			return RoverRogueRoleType.GetRootAsRoverRogueRoleType(_bb, default(RoverRogueRoleType));
		}

		// Token: 0x0600CF03 RID: 52995 RVA: 0x00308B90 File Offset: 0x00306D90
		public static RoverRogueRoleType GetRootAsRoverRogueRoleType(ByteBuffer _bb, RoverRogueRoleType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CF04 RID: 52996 RVA: 0x00308BAD File Offset: 0x00306DAD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CF05 RID: 52997 RVA: 0x00308BBC File Offset: 0x00306DBC
		public RoverRogueRoleType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170034B5 RID: 13493
		// (get) Token: 0x0600CF06 RID: 52998 RVA: 0x00308BCC File Offset: 0x00306DCC
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

		// Token: 0x170034B6 RID: 13494
		// (get) Token: 0x0600CF07 RID: 52999 RVA: 0x00308C08 File Offset: 0x00306E08
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

		// Token: 0x170034B7 RID: 13495
		// (get) Token: 0x0600CF08 RID: 53000 RVA: 0x00308C44 File Offset: 0x00306E44
		public int MaleRoleId
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

		// Token: 0x170034B8 RID: 13496
		// (get) Token: 0x0600CF09 RID: 53001 RVA: 0x00308C80 File Offset: 0x00306E80
		public int FemaleRoleId
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

		// Token: 0x170034B9 RID: 13497
		// (get) Token: 0x0600CF0A RID: 53002 RVA: 0x00308CC0 File Offset: 0x00306EC0
		public int UnlockConditionGroupId
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

		// Token: 0x170034BA RID: 13498
		// (get) Token: 0x0600CF0B RID: 53003 RVA: 0x00308D00 File Offset: 0x00306F00
		public string UnlockDesc
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CF0C RID: 53004 RVA: 0x00308D38 File Offset: 0x00306F38
		public Span<byte> GetUnlockDescBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600CF0D RID: 53005 RVA: 0x00308D48 File Offset: 0x00306F48
		public byte[] GetUnlockDescArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170034BB RID: 13499
		// (get) Token: 0x0600CF0E RID: 53006 RVA: 0x00308D60 File Offset: 0x00306F60
		public string Element
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

		// Token: 0x0600CF0F RID: 53007 RVA: 0x00308D98 File Offset: 0x00306F98
		public Span<byte> GetElementBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600CF10 RID: 53008 RVA: 0x00308DA8 File Offset: 0x00306FA8
		public byte[] GetElementArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170034BC RID: 13500
		// (get) Token: 0x0600CF11 RID: 53009 RVA: 0x00308DC0 File Offset: 0x00306FC0
		public string ElementIcon
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CF12 RID: 53010 RVA: 0x00308DF8 File Offset: 0x00306FF8
		public Span<byte> GetElementIconBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600CF13 RID: 53011 RVA: 0x00308E08 File Offset: 0x00307008
		public byte[] GetElementIconArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x170034BD RID: 13501
		// (get) Token: 0x0600CF14 RID: 53012 RVA: 0x00308E20 File Offset: 0x00307020
		public string ResultElementIcon
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

		// Token: 0x0600CF15 RID: 53013 RVA: 0x00308E58 File Offset: 0x00307058
		public Span<byte> GetResultElementIconBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600CF16 RID: 53014 RVA: 0x00308E68 File Offset: 0x00307068
		public byte[] GetResultElementIconArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x0600CF17 RID: 53015 RVA: 0x00308E80 File Offset: 0x00307080
		public DicStringString? Tag(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170034BE RID: 13502
		// (get) Token: 0x0600CF18 RID: 53016 RVA: 0x00308EE4 File Offset: 0x003070E4
		public int TagLength
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600CF19 RID: 53017 RVA: 0x00308F10 File Offset: 0x00307110
		public string SkillTitleList(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170034BF RID: 13503
		// (get) Token: 0x0600CF1A RID: 53018 RVA: 0x00308F4C File Offset: 0x0030714C
		public int SkillTitleListLength
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

		// Token: 0x0600CF1B RID: 53019 RVA: 0x00308F78 File Offset: 0x00307178
		public string SkillDescList(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170034C0 RID: 13504
		// (get) Token: 0x0600CF1C RID: 53020 RVA: 0x00308FB4 File Offset: 0x003071B4
		public int SkillDescListLength
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

		// Token: 0x170034C1 RID: 13505
		// (get) Token: 0x0600CF1D RID: 53021 RVA: 0x00308FE0 File Offset: 0x003071E0
		public int ElementId
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CF1E RID: 53022 RVA: 0x0030901D File Offset: 0x0030721D
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SkillDescListIter()或GetSkillDescListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] SkillDescList()
		{
			return this.SkillDescListIter().ToArray<string>();
		}

		// Token: 0x0600CF1F RID: 53023 RVA: 0x0030902A File Offset: 0x0030722A
		[NullableContext(1)]
		public readonly IEnumerable<string> SkillDescListIter()
		{
			RoverRogueRoleType.<SkillDescListIter>d__46 <SkillDescListIter>d__ = new RoverRogueRoleType.<SkillDescListIter>d__46(-2);
			<SkillDescListIter>d__.<>3__<>4__this = this;
			return <SkillDescListIter>d__;
		}

		// Token: 0x0600CF20 RID: 53024 RVA: 0x0030903F File Offset: 0x0030723F
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SkillTitleListIter()或GetSkillTitleListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] SkillTitleList()
		{
			return this.SkillTitleListIter().ToArray<string>();
		}

		// Token: 0x0600CF21 RID: 53025 RVA: 0x0030904C File Offset: 0x0030724C
		[NullableContext(1)]
		public readonly IEnumerable<string> SkillTitleListIter()
		{
			RoverRogueRoleType.<SkillTitleListIter>d__48 <SkillTitleListIter>d__ = new RoverRogueRoleType.<SkillTitleListIter>d__48(-2);
			<SkillTitleListIter>d__.<>3__<>4__this = this;
			return <SkillTitleListIter>d__;
		}

		// Token: 0x0600CF22 RID: 53026 RVA: 0x00309064 File Offset: 0x00307264
		[NullableContext(1)]
		[Obsolete("已废弃，请使用TagFrozenDict()缓存字典，遍历请使用TagIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<string, string> Tag()
		{
			return this.TagIter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x0600CF23 RID: 53027 RVA: 0x003090BA File Offset: 0x003072BA
		[NullableContext(1)]
		public readonly IEnumerable<DicStringString> TagIter()
		{
			RoverRogueRoleType.<TagIter>d__50 <TagIter>d__ = new RoverRogueRoleType.<TagIter>d__50(-2);
			<TagIter>d__.<>3__<>4__this = this;
			return <TagIter>d__;
		}

		// Token: 0x0600CF24 RID: 53028 RVA: 0x003090D0 File Offset: 0x003072D0
		[NullableContext(1)]
		[return: Nullable(2)]
		public string GetTag(string key)
		{
			this.EnsureTagCacheIfNeeded();
			string result;
			if (!this.TagCache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x0600CF25 RID: 53029 RVA: 0x003090F8 File Offset: 0x003072F8
		private void EnsureTagCacheIfNeeded()
		{
			if (this.TagCache != null)
			{
				return;
			}
			this.TagCache = this.TagIter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x0600CF26 RID: 53030 RVA: 0x0030915E File Offset: 0x0030735E
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public FrozenDictionary<string, string> GetTagFrozenDict(string key)
		{
			this.EnsureTagCacheIfNeeded();
			return this.TagCache;
		}

		// Token: 0x04005192 RID: 20882
		private Table __p;

		// Token: 0x04005193 RID: 20883
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> TagCache;
	}
}

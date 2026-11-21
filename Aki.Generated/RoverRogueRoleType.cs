using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001181 RID: 4481
	public struct RoverRogueRoleType : IFlatbufferObject
	{
		// Token: 0x170035C1 RID: 13761
		// (get) Token: 0x0600D6D3 RID: 54995 RVA: 0x003281AF File Offset: 0x003263AF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D6D4 RID: 54996 RVA: 0x003281BC File Offset: 0x003263BC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D6D5 RID: 54997 RVA: 0x003281C4 File Offset: 0x003263C4
		public static RoverRogueRoleType GetRootAsRoverRogueRoleType(ByteBuffer _bb)
		{
			return RoverRogueRoleType.GetRootAsRoverRogueRoleType(_bb, default(RoverRogueRoleType));
		}

		// Token: 0x0600D6D6 RID: 54998 RVA: 0x003281E0 File Offset: 0x003263E0
		public static RoverRogueRoleType GetRootAsRoverRogueRoleType(ByteBuffer _bb, RoverRogueRoleType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D6D7 RID: 54999 RVA: 0x003281FD File Offset: 0x003263FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D6D8 RID: 55000 RVA: 0x0032820C File Offset: 0x0032640C
		public RoverRogueRoleType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170035C2 RID: 13762
		// (get) Token: 0x0600D6D9 RID: 55001 RVA: 0x0032821C File Offset: 0x0032641C
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

		// Token: 0x170035C3 RID: 13763
		// (get) Token: 0x0600D6DA RID: 55002 RVA: 0x00328258 File Offset: 0x00326458
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

		// Token: 0x170035C4 RID: 13764
		// (get) Token: 0x0600D6DB RID: 55003 RVA: 0x00328294 File Offset: 0x00326494
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

		// Token: 0x170035C5 RID: 13765
		// (get) Token: 0x0600D6DC RID: 55004 RVA: 0x003282D0 File Offset: 0x003264D0
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

		// Token: 0x170035C6 RID: 13766
		// (get) Token: 0x0600D6DD RID: 55005 RVA: 0x00328310 File Offset: 0x00326510
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

		// Token: 0x170035C7 RID: 13767
		// (get) Token: 0x0600D6DE RID: 55006 RVA: 0x00328350 File Offset: 0x00326550
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

		// Token: 0x0600D6DF RID: 55007 RVA: 0x00328388 File Offset: 0x00326588
		public Span<byte> GetUnlockDescBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600D6E0 RID: 55008 RVA: 0x00328398 File Offset: 0x00326598
		public byte[] GetUnlockDescArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170035C8 RID: 13768
		// (get) Token: 0x0600D6E1 RID: 55009 RVA: 0x003283B0 File Offset: 0x003265B0
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

		// Token: 0x0600D6E2 RID: 55010 RVA: 0x003283E8 File Offset: 0x003265E8
		public Span<byte> GetElementBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600D6E3 RID: 55011 RVA: 0x003283F8 File Offset: 0x003265F8
		public byte[] GetElementArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170035C9 RID: 13769
		// (get) Token: 0x0600D6E4 RID: 55012 RVA: 0x00328410 File Offset: 0x00326610
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

		// Token: 0x0600D6E5 RID: 55013 RVA: 0x00328448 File Offset: 0x00326648
		public Span<byte> GetElementIconBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600D6E6 RID: 55014 RVA: 0x00328458 File Offset: 0x00326658
		public byte[] GetElementIconArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x170035CA RID: 13770
		// (get) Token: 0x0600D6E7 RID: 55015 RVA: 0x00328470 File Offset: 0x00326670
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

		// Token: 0x0600D6E8 RID: 55016 RVA: 0x003284A8 File Offset: 0x003266A8
		public Span<byte> GetResultElementIconBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600D6E9 RID: 55017 RVA: 0x003284B8 File Offset: 0x003266B8
		public byte[] GetResultElementIconArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x0600D6EA RID: 55018 RVA: 0x003284D0 File Offset: 0x003266D0
		public DicStringString? Tag(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170035CB RID: 13771
		// (get) Token: 0x0600D6EB RID: 55019 RVA: 0x00328534 File Offset: 0x00326734
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

		// Token: 0x0600D6EC RID: 55020 RVA: 0x00328560 File Offset: 0x00326760
		public string SkillTitleList(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170035CC RID: 13772
		// (get) Token: 0x0600D6ED RID: 55021 RVA: 0x0032859C File Offset: 0x0032679C
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

		// Token: 0x0600D6EE RID: 55022 RVA: 0x003285C8 File Offset: 0x003267C8
		public string SkillDescList(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170035CD RID: 13773
		// (get) Token: 0x0600D6EF RID: 55023 RVA: 0x00328604 File Offset: 0x00326804
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

		// Token: 0x170035CE RID: 13774
		// (get) Token: 0x0600D6F0 RID: 55024 RVA: 0x00328630 File Offset: 0x00326830
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

		// Token: 0x0600D6F1 RID: 55025 RVA: 0x0032866D File Offset: 0x0032686D
		[NullableContext(1)]
		public string[] SkillDescList()
		{
			return this.SkillDescListIter().ToArray<string>();
		}

		// Token: 0x0600D6F2 RID: 55026 RVA: 0x0032867A File Offset: 0x0032687A
		[NullableContext(1)]
		public IEnumerable<string> SkillDescListIter()
		{
			RoverRogueRoleType.<SkillDescListIter>d__46 <SkillDescListIter>d__ = new RoverRogueRoleType.<SkillDescListIter>d__46(-2);
			<SkillDescListIter>d__.<>3__<>4__this = this;
			return <SkillDescListIter>d__;
		}

		// Token: 0x0600D6F3 RID: 55027 RVA: 0x0032868F File Offset: 0x0032688F
		[NullableContext(1)]
		public string[] SkillTitleList()
		{
			return this.SkillTitleListIter().ToArray<string>();
		}

		// Token: 0x0600D6F4 RID: 55028 RVA: 0x0032869C File Offset: 0x0032689C
		[NullableContext(1)]
		public IEnumerable<string> SkillTitleListIter()
		{
			RoverRogueRoleType.<SkillTitleListIter>d__48 <SkillTitleListIter>d__ = new RoverRogueRoleType.<SkillTitleListIter>d__48(-2);
			<SkillTitleListIter>d__.<>3__<>4__this = this;
			return <SkillTitleListIter>d__;
		}

		// Token: 0x0600D6F5 RID: 55029 RVA: 0x003286B4 File Offset: 0x003268B4
		[NullableContext(1)]
		public Dictionary<string, string> Tag()
		{
			return this.TagIter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x0600D6F6 RID: 55030 RVA: 0x0032870A File Offset: 0x0032690A
		[NullableContext(1)]
		public IEnumerable<DicStringString> TagIter()
		{
			RoverRogueRoleType.<TagIter>d__50 <TagIter>d__ = new RoverRogueRoleType.<TagIter>d__50(-2);
			<TagIter>d__.<>3__<>4__this = this;
			return <TagIter>d__;
		}

		// Token: 0x0600D6F7 RID: 55031 RVA: 0x00328720 File Offset: 0x00326920
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

		// Token: 0x0600D6F8 RID: 55032 RVA: 0x00328748 File Offset: 0x00326948
		private void EnsureTagCacheIfNeeded()
		{
			if (this.TagCache != null)
			{
				return;
			}
			this.TagCache = this.TagIter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x0600D6F9 RID: 55033 RVA: 0x003287AE File Offset: 0x003269AE
		[NullableContext(1)]
		public FrozenDictionary<string, string> GetTagFrozenDict()
		{
			this.EnsureTagCacheIfNeeded();
			return this.TagCache;
		}

		// Token: 0x04005791 RID: 22417
		private Table __p;

		// Token: 0x04005792 RID: 22418
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> TagCache;
	}
}

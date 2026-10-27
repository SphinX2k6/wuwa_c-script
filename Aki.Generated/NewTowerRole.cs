using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E8F RID: 3727
	public struct NewTowerRole : IFlatbufferObject
	{
		// Token: 0x17002366 RID: 9062
		// (get) Token: 0x06009F87 RID: 40839 RVA: 0x0029EAFE File Offset: 0x0029CCFE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009F88 RID: 40840 RVA: 0x0029EB0B File Offset: 0x0029CD0B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009F89 RID: 40841 RVA: 0x0029EB14 File Offset: 0x0029CD14
		public static NewTowerRole GetRootAsNewTowerRole(ByteBuffer _bb)
		{
			return NewTowerRole.GetRootAsNewTowerRole(_bb, default(NewTowerRole));
		}

		// Token: 0x06009F8A RID: 40842 RVA: 0x0029EB30 File Offset: 0x0029CD30
		public static NewTowerRole GetRootAsNewTowerRole(ByteBuffer _bb, NewTowerRole obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009F8B RID: 40843 RVA: 0x0029EB4D File Offset: 0x0029CD4D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009F8C RID: 40844 RVA: 0x0029EB5C File Offset: 0x0029CD5C
		public NewTowerRole __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002367 RID: 9063
		// (get) Token: 0x06009F8D RID: 40845 RVA: 0x0029EB6C File Offset: 0x0029CD6C
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

		// Token: 0x06009F8E RID: 40846 RVA: 0x0029EBA8 File Offset: 0x0029CDA8
		public LongArray? AddBuffs(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new LongArray?(default(LongArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17002368 RID: 9064
		// (get) Token: 0x06009F8F RID: 40847 RVA: 0x0029EC08 File Offset: 0x0029CE08
		public int AddBuffsLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17002369 RID: 9065
		// (get) Token: 0x06009F90 RID: 40848 RVA: 0x0029EC34 File Offset: 0x0029CE34
		public int TemplateRoleId
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

		// Token: 0x06009F91 RID: 40849 RVA: 0x0029EC70 File Offset: 0x0029CE70
		public DicIntString? EnhanceSkillDesc(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new DicIntString?(default(DicIntString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700236A RID: 9066
		// (get) Token: 0x06009F92 RID: 40850 RVA: 0x0029ECD4 File Offset: 0x0029CED4
		public int EnhanceSkillDescLength
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

		// Token: 0x06009F93 RID: 40851 RVA: 0x0029ED00 File Offset: 0x0029CF00
		public DicIntStringArray? EnhanceSkillDescParam(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new DicIntStringArray?(default(DicIntStringArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700236B RID: 9067
		// (get) Token: 0x06009F94 RID: 40852 RVA: 0x0029ED64 File Offset: 0x0029CF64
		public int EnhanceSkillDescParamLength
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

		// Token: 0x1700236C RID: 9068
		// (get) Token: 0x06009F95 RID: 40853 RVA: 0x0029ED90 File Offset: 0x0029CF90
		public string TemplateDesc
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

		// Token: 0x06009F96 RID: 40854 RVA: 0x0029EDC8 File Offset: 0x0029CFC8
		public Span<byte> GetTemplateDescBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06009F97 RID: 40855 RVA: 0x0029EDD8 File Offset: 0x0029CFD8
		public byte[] GetTemplateDescArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x06009F98 RID: 40856 RVA: 0x0029EDF0 File Offset: 0x0029CFF0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用AddBuffsIter()或GetAddBuffsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly LongArray[] AddBuffs()
		{
			return this.AddBuffsIter().ToArray<LongArray>();
		}

		// Token: 0x06009F99 RID: 40857 RVA: 0x0029EDFD File Offset: 0x0029CFFD
		[NullableContext(1)]
		public readonly IEnumerable<LongArray> AddBuffsIter()
		{
			NewTowerRole.<AddBuffsIter>d__26 <AddBuffsIter>d__ = new NewTowerRole.<AddBuffsIter>d__26(-2);
			<AddBuffsIter>d__.<>3__<>4__this = this;
			return <AddBuffsIter>d__;
		}

		// Token: 0x06009F9A RID: 40858 RVA: 0x0029EE14 File Offset: 0x0029D014
		[NullableContext(1)]
		[Obsolete("已废弃，请使用EnhanceSkillDescFrozenDict()缓存字典，遍历请使用EnhanceSkillDescIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, string> EnhanceSkillDesc()
		{
			return this.EnhanceSkillDescIter().ToDictionary((DicIntString element) => element.Key, (DicIntString element) => element.Value);
		}

		// Token: 0x06009F9B RID: 40859 RVA: 0x0029EE6A File Offset: 0x0029D06A
		[NullableContext(1)]
		public readonly IEnumerable<DicIntString> EnhanceSkillDescIter()
		{
			NewTowerRole.<EnhanceSkillDescIter>d__28 <EnhanceSkillDescIter>d__ = new NewTowerRole.<EnhanceSkillDescIter>d__28(-2);
			<EnhanceSkillDescIter>d__.<>3__<>4__this = this;
			return <EnhanceSkillDescIter>d__;
		}

		// Token: 0x06009F9C RID: 40860 RVA: 0x0029EE80 File Offset: 0x0029D080
		[NullableContext(1)]
		[Obsolete("已废弃，请使用EnhanceSkillDescParamFrozenDict()缓存字典，遍历请使用EnhanceSkillDescParamIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, StringArray> EnhanceSkillDescParam()
		{
			return this.EnhanceSkillDescParamIter().ToDictionary((DicIntStringArray element) => element.Key, (DicIntStringArray element) => element.Value.Value);
		}

		// Token: 0x06009F9D RID: 40861 RVA: 0x0029EED6 File Offset: 0x0029D0D6
		[NullableContext(1)]
		public readonly IEnumerable<DicIntStringArray> EnhanceSkillDescParamIter()
		{
			NewTowerRole.<EnhanceSkillDescParamIter>d__30 <EnhanceSkillDescParamIter>d__ = new NewTowerRole.<EnhanceSkillDescParamIter>d__30(-2);
			<EnhanceSkillDescParamIter>d__.<>3__<>4__this = this;
			return <EnhanceSkillDescParamIter>d__;
		}

		// Token: 0x06009F9E RID: 40862 RVA: 0x0029EEEC File Offset: 0x0029D0EC
		[NullableContext(2)]
		public string GetEnhanceSkillDesc(int key)
		{
			this.EnsureEnhanceSkillDescCacheIfNeeded();
			string result;
			if (!this.EnhanceSkillDescCache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x06009F9F RID: 40863 RVA: 0x0029EF14 File Offset: 0x0029D114
		public StringArray? GetEnhanceSkillDescParam(int key)
		{
			this.EnsureEnhanceSkillDescParamCacheIfNeeded();
			StringArray value;
			if (!this.EnhanceSkillDescParamCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new StringArray?(value);
		}

		// Token: 0x06009FA0 RID: 40864 RVA: 0x0029EF48 File Offset: 0x0029D148
		private void EnsureEnhanceSkillDescCacheIfNeeded()
		{
			if (this.EnhanceSkillDescCache != null)
			{
				return;
			}
			this.EnhanceSkillDescCache = this.EnhanceSkillDescIter().ToFrozenDictionary((DicIntString kvp) => kvp.Key, (DicIntString kvp) => kvp.Value, null);
		}

		// Token: 0x06009FA1 RID: 40865 RVA: 0x0029EFB0 File Offset: 0x0029D1B0
		private void EnsureEnhanceSkillDescParamCacheIfNeeded()
		{
			if (this.EnhanceSkillDescParamCache != null)
			{
				return;
			}
			this.EnhanceSkillDescParamCache = this.EnhanceSkillDescParamIter().ToFrozenDictionary((DicIntStringArray kvp) => kvp.Key, (DicIntStringArray kvp) => kvp.Value.Value, null);
		}

		// Token: 0x06009FA2 RID: 40866 RVA: 0x0029F016 File Offset: 0x0029D216
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public FrozenDictionary<int, string> GetEnhanceSkillDescFrozenDict(int key)
		{
			this.EnsureEnhanceSkillDescCacheIfNeeded();
			return this.EnhanceSkillDescCache;
		}

		// Token: 0x06009FA3 RID: 40867 RVA: 0x0029F024 File Offset: 0x0029D224
		[NullableContext(2)]
		public FrozenDictionary<int, StringArray> GetEnhanceSkillDescParamFrozenDict(int key)
		{
			this.EnsureEnhanceSkillDescParamCacheIfNeeded();
			return this.EnhanceSkillDescParamCache;
		}

		// Token: 0x04004F40 RID: 20288
		private Table __p;

		// Token: 0x04004F41 RID: 20289
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<int, string> EnhanceSkillDescCache;

		// Token: 0x04004F42 RID: 20290
		[Nullable(2)]
		private FrozenDictionary<int, StringArray> EnhanceSkillDescParamCache;
	}
}

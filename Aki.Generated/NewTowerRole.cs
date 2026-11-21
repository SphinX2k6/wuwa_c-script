using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F74 RID: 3956
	public struct NewTowerRole : IFlatbufferObject
	{
		// Token: 0x170023CB RID: 9163
		// (get) Token: 0x0600A5A7 RID: 42407 RVA: 0x002BC09E File Offset: 0x002BA29E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A5A8 RID: 42408 RVA: 0x002BC0AB File Offset: 0x002BA2AB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A5A9 RID: 42409 RVA: 0x002BC0B4 File Offset: 0x002BA2B4
		public static NewTowerRole GetRootAsNewTowerRole(ByteBuffer _bb)
		{
			return NewTowerRole.GetRootAsNewTowerRole(_bb, default(NewTowerRole));
		}

		// Token: 0x0600A5AA RID: 42410 RVA: 0x002BC0D0 File Offset: 0x002BA2D0
		public static NewTowerRole GetRootAsNewTowerRole(ByteBuffer _bb, NewTowerRole obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A5AB RID: 42411 RVA: 0x002BC0ED File Offset: 0x002BA2ED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A5AC RID: 42412 RVA: 0x002BC0FC File Offset: 0x002BA2FC
		public NewTowerRole __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170023CC RID: 9164
		// (get) Token: 0x0600A5AD RID: 42413 RVA: 0x002BC10C File Offset: 0x002BA30C
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

		// Token: 0x0600A5AE RID: 42414 RVA: 0x002BC148 File Offset: 0x002BA348
		public LongArray? AddBuffs(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new LongArray?(default(LongArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170023CD RID: 9165
		// (get) Token: 0x0600A5AF RID: 42415 RVA: 0x002BC1A8 File Offset: 0x002BA3A8
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

		// Token: 0x170023CE RID: 9166
		// (get) Token: 0x0600A5B0 RID: 42416 RVA: 0x002BC1D4 File Offset: 0x002BA3D4
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

		// Token: 0x0600A5B1 RID: 42417 RVA: 0x002BC210 File Offset: 0x002BA410
		public DicIntString? EnhanceSkillDesc(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new DicIntString?(default(DicIntString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170023CF RID: 9167
		// (get) Token: 0x0600A5B2 RID: 42418 RVA: 0x002BC274 File Offset: 0x002BA474
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

		// Token: 0x0600A5B3 RID: 42419 RVA: 0x002BC2A0 File Offset: 0x002BA4A0
		public DicIntStringArray? EnhanceSkillDescParam(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new DicIntStringArray?(default(DicIntStringArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170023D0 RID: 9168
		// (get) Token: 0x0600A5B4 RID: 42420 RVA: 0x002BC304 File Offset: 0x002BA504
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

		// Token: 0x170023D1 RID: 9169
		// (get) Token: 0x0600A5B5 RID: 42421 RVA: 0x002BC330 File Offset: 0x002BA530
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

		// Token: 0x0600A5B6 RID: 42422 RVA: 0x002BC368 File Offset: 0x002BA568
		public Span<byte> GetTemplateDescBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600A5B7 RID: 42423 RVA: 0x002BC378 File Offset: 0x002BA578
		public byte[] GetTemplateDescArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x0600A5B8 RID: 42424 RVA: 0x002BC390 File Offset: 0x002BA590
		[NullableContext(1)]
		public LongArray[] AddBuffs()
		{
			return this.AddBuffsIter().ToArray<LongArray>();
		}

		// Token: 0x0600A5B9 RID: 42425 RVA: 0x002BC39D File Offset: 0x002BA59D
		[NullableContext(1)]
		public IEnumerable<LongArray> AddBuffsIter()
		{
			NewTowerRole.<AddBuffsIter>d__26 <AddBuffsIter>d__ = new NewTowerRole.<AddBuffsIter>d__26(-2);
			<AddBuffsIter>d__.<>3__<>4__this = this;
			return <AddBuffsIter>d__;
		}

		// Token: 0x0600A5BA RID: 42426 RVA: 0x002BC3B4 File Offset: 0x002BA5B4
		[NullableContext(1)]
		public Dictionary<int, string> EnhanceSkillDesc()
		{
			return this.EnhanceSkillDescIter().ToDictionary((DicIntString element) => element.Key, (DicIntString element) => element.Value);
		}

		// Token: 0x0600A5BB RID: 42427 RVA: 0x002BC40A File Offset: 0x002BA60A
		[NullableContext(1)]
		public IEnumerable<DicIntString> EnhanceSkillDescIter()
		{
			NewTowerRole.<EnhanceSkillDescIter>d__28 <EnhanceSkillDescIter>d__ = new NewTowerRole.<EnhanceSkillDescIter>d__28(-2);
			<EnhanceSkillDescIter>d__.<>3__<>4__this = this;
			return <EnhanceSkillDescIter>d__;
		}

		// Token: 0x0600A5BC RID: 42428 RVA: 0x002BC420 File Offset: 0x002BA620
		[NullableContext(1)]
		public Dictionary<int, StringArray> EnhanceSkillDescParam()
		{
			return this.EnhanceSkillDescParamIter().ToDictionary((DicIntStringArray element) => element.Key, (DicIntStringArray element) => element.Value.Value);
		}

		// Token: 0x0600A5BD RID: 42429 RVA: 0x002BC476 File Offset: 0x002BA676
		[NullableContext(1)]
		public IEnumerable<DicIntStringArray> EnhanceSkillDescParamIter()
		{
			NewTowerRole.<EnhanceSkillDescParamIter>d__30 <EnhanceSkillDescParamIter>d__ = new NewTowerRole.<EnhanceSkillDescParamIter>d__30(-2);
			<EnhanceSkillDescParamIter>d__.<>3__<>4__this = this;
			return <EnhanceSkillDescParamIter>d__;
		}

		// Token: 0x0600A5BE RID: 42430 RVA: 0x002BC48C File Offset: 0x002BA68C
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

		// Token: 0x0600A5BF RID: 42431 RVA: 0x002BC4B4 File Offset: 0x002BA6B4
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

		// Token: 0x0600A5C0 RID: 42432 RVA: 0x002BC4E8 File Offset: 0x002BA6E8
		private void EnsureEnhanceSkillDescCacheIfNeeded()
		{
			if (this.EnhanceSkillDescCache != null)
			{
				return;
			}
			this.EnhanceSkillDescCache = this.EnhanceSkillDescIter().ToFrozenDictionary((DicIntString kvp) => kvp.Key, (DicIntString kvp) => kvp.Value, null);
		}

		// Token: 0x0600A5C1 RID: 42433 RVA: 0x002BC550 File Offset: 0x002BA750
		private void EnsureEnhanceSkillDescParamCacheIfNeeded()
		{
			if (this.EnhanceSkillDescParamCache != null)
			{
				return;
			}
			this.EnhanceSkillDescParamCache = this.EnhanceSkillDescParamIter().ToFrozenDictionary((DicIntStringArray kvp) => kvp.Key, (DicIntStringArray kvp) => kvp.Value.Value, null);
		}

		// Token: 0x0600A5C2 RID: 42434 RVA: 0x002BC5B6 File Offset: 0x002BA7B6
		[NullableContext(1)]
		public FrozenDictionary<int, string> GetEnhanceSkillDescFrozenDict()
		{
			this.EnsureEnhanceSkillDescCacheIfNeeded();
			return this.EnhanceSkillDescCache;
		}

		// Token: 0x0600A5C3 RID: 42435 RVA: 0x002BC5C4 File Offset: 0x002BA7C4
		[NullableContext(1)]
		public FrozenDictionary<int, StringArray> GetEnhanceSkillDescParamFrozenDict()
		{
			this.EnsureEnhanceSkillDescParamCacheIfNeeded();
			return this.EnhanceSkillDescParamCache;
		}

		// Token: 0x04005525 RID: 21797
		private Table __p;

		// Token: 0x04005526 RID: 21798
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<int, string> EnhanceSkillDescCache;

		// Token: 0x04005527 RID: 21799
		[Nullable(2)]
		private FrozenDictionary<int, StringArray> EnhanceSkillDescParamCache;
	}
}

using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011B8 RID: 4536
	public struct SkillCondition : IFlatbufferObject
	{
		// Token: 0x170037B9 RID: 14265
		// (get) Token: 0x0600DC66 RID: 56422 RVA: 0x0033516C File Offset: 0x0033336C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DC67 RID: 56423 RVA: 0x00335179 File Offset: 0x00333379
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DC68 RID: 56424 RVA: 0x00335180 File Offset: 0x00333380
		public static SkillCondition GetRootAsSkillCondition(ByteBuffer _bb)
		{
			return SkillCondition.GetRootAsSkillCondition(_bb, default(SkillCondition));
		}

		// Token: 0x0600DC69 RID: 56425 RVA: 0x0033519C File Offset: 0x0033339C
		public static SkillCondition GetRootAsSkillCondition(ByteBuffer _bb, SkillCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DC6A RID: 56426 RVA: 0x003351B9 File Offset: 0x003333B9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DC6B RID: 56427 RVA: 0x003351C8 File Offset: 0x003333C8
		public SkillCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170037BA RID: 14266
		// (get) Token: 0x0600DC6C RID: 56428 RVA: 0x003351D8 File Offset: 0x003333D8
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

		// Token: 0x170037BB RID: 14267
		// (get) Token: 0x0600DC6D RID: 56429 RVA: 0x00335214 File Offset: 0x00333414
		public int ConditionType
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

		// Token: 0x0600DC6E RID: 56430 RVA: 0x00335250 File Offset: 0x00333450
		public DicIntInt? ConditionParam(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170037BC RID: 14268
		// (get) Token: 0x0600DC6F RID: 56431 RVA: 0x003352B0 File Offset: 0x003334B0
		public int ConditionParamLength
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

		// Token: 0x170037BD RID: 14269
		// (get) Token: 0x0600DC70 RID: 56432 RVA: 0x003352DC File Offset: 0x003334DC
		public string Description
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

		// Token: 0x0600DC71 RID: 56433 RVA: 0x00335314 File Offset: 0x00333514
		public Span<byte> GetDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600DC72 RID: 56434 RVA: 0x00335324 File Offset: 0x00333524
		public byte[] GetDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x0600DC73 RID: 56435 RVA: 0x0033533C File Offset: 0x0033353C
		[NullableContext(1)]
		public Dictionary<int, int> ConditionParam()
		{
			return this.ConditionParamIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600DC74 RID: 56436 RVA: 0x00335392 File Offset: 0x00333592
		[NullableContext(1)]
		public IEnumerable<DicIntInt> ConditionParamIter()
		{
			SkillCondition.<ConditionParamIter>d__20 <ConditionParamIter>d__ = new SkillCondition.<ConditionParamIter>d__20(-2);
			<ConditionParamIter>d__.<>3__<>4__this = this;
			return <ConditionParamIter>d__;
		}

		// Token: 0x0600DC75 RID: 56437 RVA: 0x003353A8 File Offset: 0x003335A8
		public int? GetConditionParam(int key)
		{
			this.EnsureConditionParamCacheIfNeeded();
			int value;
			if (!this.ConditionParamCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600DC76 RID: 56438 RVA: 0x003353DC File Offset: 0x003335DC
		private void EnsureConditionParamCacheIfNeeded()
		{
			if (this.ConditionParamCache != null)
			{
				return;
			}
			this.ConditionParamCache = this.ConditionParamIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600DC77 RID: 56439 RVA: 0x00335442 File Offset: 0x00333642
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetConditionParamFrozenDict()
		{
			this.EnsureConditionParamCacheIfNeeded();
			return this.ConditionParamCache;
		}

		// Token: 0x040057E0 RID: 22496
		private Table __p;

		// Token: 0x040057E1 RID: 22497
		[Nullable(2)]
		private FrozenDictionary<int, int> ConditionParamCache;
	}
}

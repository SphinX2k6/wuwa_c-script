using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010BD RID: 4285
	public struct SkillCondition : IFlatbufferObject
	{
		// Token: 0x170036A8 RID: 13992
		// (get) Token: 0x0600D489 RID: 54409 RVA: 0x00315F14 File Offset: 0x00314114
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D48A RID: 54410 RVA: 0x00315F21 File Offset: 0x00314121
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D48B RID: 54411 RVA: 0x00315F28 File Offset: 0x00314128
		public static SkillCondition GetRootAsSkillCondition(ByteBuffer _bb)
		{
			return SkillCondition.GetRootAsSkillCondition(_bb, default(SkillCondition));
		}

		// Token: 0x0600D48C RID: 54412 RVA: 0x00315F44 File Offset: 0x00314144
		public static SkillCondition GetRootAsSkillCondition(ByteBuffer _bb, SkillCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D48D RID: 54413 RVA: 0x00315F61 File Offset: 0x00314161
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D48E RID: 54414 RVA: 0x00315F70 File Offset: 0x00314170
		public SkillCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170036A9 RID: 13993
		// (get) Token: 0x0600D48F RID: 54415 RVA: 0x00315F80 File Offset: 0x00314180
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

		// Token: 0x170036AA RID: 13994
		// (get) Token: 0x0600D490 RID: 54416 RVA: 0x00315FBC File Offset: 0x003141BC
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

		// Token: 0x0600D491 RID: 54417 RVA: 0x00315FF8 File Offset: 0x003141F8
		public DicIntInt? ConditionParam(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170036AB RID: 13995
		// (get) Token: 0x0600D492 RID: 54418 RVA: 0x00316058 File Offset: 0x00314258
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

		// Token: 0x170036AC RID: 13996
		// (get) Token: 0x0600D493 RID: 54419 RVA: 0x00316084 File Offset: 0x00314284
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

		// Token: 0x0600D494 RID: 54420 RVA: 0x003160BC File Offset: 0x003142BC
		public Span<byte> GetDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600D495 RID: 54421 RVA: 0x003160CC File Offset: 0x003142CC
		public byte[] GetDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x0600D496 RID: 54422 RVA: 0x003160E4 File Offset: 0x003142E4
		[NullableContext(1)]
		[Obsolete("已废弃，请使用ConditionParamFrozenDict()缓存字典，遍历请使用ConditionParamIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> ConditionParam()
		{
			return this.ConditionParamIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600D497 RID: 54423 RVA: 0x0031613A File Offset: 0x0031433A
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> ConditionParamIter()
		{
			SkillCondition.<ConditionParamIter>d__20 <ConditionParamIter>d__ = new SkillCondition.<ConditionParamIter>d__20(-2);
			<ConditionParamIter>d__.<>3__<>4__this = this;
			return <ConditionParamIter>d__;
		}

		// Token: 0x0600D498 RID: 54424 RVA: 0x00316150 File Offset: 0x00314350
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

		// Token: 0x0600D499 RID: 54425 RVA: 0x00316184 File Offset: 0x00314384
		private void EnsureConditionParamCacheIfNeeded()
		{
			if (this.ConditionParamCache != null)
			{
				return;
			}
			this.ConditionParamCache = this.ConditionParamIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600D49A RID: 54426 RVA: 0x003161EA File Offset: 0x003143EA
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetConditionParamFrozenDict(int key)
		{
			this.EnsureConditionParamCacheIfNeeded();
			return this.ConditionParamCache;
		}

		// Token: 0x040051E1 RID: 20961
		private Table __p;

		// Token: 0x040051E2 RID: 20962
		[Nullable(2)]
		private FrozenDictionary<int, int> ConditionParamCache;
	}
}

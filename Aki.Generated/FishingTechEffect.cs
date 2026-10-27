using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C8E RID: 3214
	public struct FishingTechEffect : IFlatbufferObject
	{
		// Token: 0x170011E6 RID: 4582
		// (get) Token: 0x060070AF RID: 28847 RVA: 0x0023468D File Offset: 0x0023288D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060070B0 RID: 28848 RVA: 0x0023469A File Offset: 0x0023289A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060070B1 RID: 28849 RVA: 0x002346A4 File Offset: 0x002328A4
		public static FishingTechEffect GetRootAsFishingTechEffect(ByteBuffer _bb)
		{
			return FishingTechEffect.GetRootAsFishingTechEffect(_bb, default(FishingTechEffect));
		}

		// Token: 0x060070B2 RID: 28850 RVA: 0x002346C0 File Offset: 0x002328C0
		public static FishingTechEffect GetRootAsFishingTechEffect(ByteBuffer _bb, FishingTechEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060070B3 RID: 28851 RVA: 0x002346DD File Offset: 0x002328DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060070B4 RID: 28852 RVA: 0x002346EC File Offset: 0x002328EC
		public FishingTechEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170011E7 RID: 4583
		// (get) Token: 0x060070B5 RID: 28853 RVA: 0x002346FC File Offset: 0x002328FC
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

		// Token: 0x170011E8 RID: 4584
		// (get) Token: 0x060070B6 RID: 28854 RVA: 0x00234738 File Offset: 0x00232938
		public int Type
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

		// Token: 0x060070B7 RID: 28855 RVA: 0x00234774 File Offset: 0x00232974
		public DicIntInt? Consume(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170011E9 RID: 4585
		// (get) Token: 0x060070B8 RID: 28856 RVA: 0x002347D4 File Offset: 0x002329D4
		public int ConsumeLength
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

		// Token: 0x170011EA RID: 4586
		// (get) Token: 0x060070B9 RID: 28857 RVA: 0x00234800 File Offset: 0x00232A00
		public string Desc
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

		// Token: 0x060070BA RID: 28858 RVA: 0x00234838 File Offset: 0x00232A38
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060070BB RID: 28859 RVA: 0x00234848 File Offset: 0x00232A48
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x060070BC RID: 28860 RVA: 0x00234860 File Offset: 0x00232A60
		public int Params(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170011EB RID: 4587
		// (get) Token: 0x060070BD RID: 28861 RVA: 0x002348A0 File Offset: 0x00232AA0
		public int ParamsLength
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

		// Token: 0x060070BE RID: 28862 RVA: 0x002348CC File Offset: 0x00232ACC
		public Span<int> GetParamsBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x060070BF RID: 28863 RVA: 0x002348DC File Offset: 0x00232ADC
		public int[] GetParamsArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x060070C0 RID: 28864 RVA: 0x002348F4 File Offset: 0x00232AF4
		public DicIntInt? ParamDic(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170011EC RID: 4588
		// (get) Token: 0x060070C1 RID: 28865 RVA: 0x00234958 File Offset: 0x00232B58
		public int ParamDicLength
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

		// Token: 0x060070C2 RID: 28866 RVA: 0x00234984 File Offset: 0x00232B84
		public string ShowParams(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170011ED RID: 4589
		// (get) Token: 0x060070C3 RID: 28867 RVA: 0x002349C0 File Offset: 0x00232BC0
		public int ShowParamsLength
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060070C4 RID: 28868 RVA: 0x002349EC File Offset: 0x00232BEC
		[NullableContext(1)]
		[Obsolete("已废弃，请使用ConsumeFrozenDict()缓存字典，遍历请使用ConsumeIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> Consume()
		{
			return this.ConsumeIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x060070C5 RID: 28869 RVA: 0x00234A42 File Offset: 0x00232C42
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> ConsumeIter()
		{
			FishingTechEffect.<ConsumeIter>d__31 <ConsumeIter>d__ = new FishingTechEffect.<ConsumeIter>d__31(-2);
			<ConsumeIter>d__.<>3__<>4__this = this;
			return <ConsumeIter>d__;
		}

		// Token: 0x060070C6 RID: 28870 RVA: 0x00234A58 File Offset: 0x00232C58
		[NullableContext(1)]
		[Obsolete("已废弃，请使用ParamDicFrozenDict()缓存字典，遍历请使用ParamDicIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> ParamDic()
		{
			return this.ParamDicIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x060070C7 RID: 28871 RVA: 0x00234AAE File Offset: 0x00232CAE
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> ParamDicIter()
		{
			FishingTechEffect.<ParamDicIter>d__33 <ParamDicIter>d__ = new FishingTechEffect.<ParamDicIter>d__33(-2);
			<ParamDicIter>d__.<>3__<>4__this = this;
			return <ParamDicIter>d__;
		}

		// Token: 0x060070C8 RID: 28872 RVA: 0x00234AC4 File Offset: 0x00232CC4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ParamsIter()或GetParamsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Params()
		{
			FishingTechEffect fishingTechEffect = this;
			return fishingTechEffect.GetParamsArray() ?? Array.Empty<int>();
		}

		// Token: 0x060070C9 RID: 28873 RVA: 0x00234AE8 File Offset: 0x00232CE8
		[NullableContext(1)]
		public readonly IEnumerable<int> ParamsIter()
		{
			FishingTechEffect.<ParamsIter>d__35 <ParamsIter>d__ = new FishingTechEffect.<ParamsIter>d__35(-2);
			<ParamsIter>d__.<>3__<>4__this = this;
			return <ParamsIter>d__;
		}

		// Token: 0x060070CA RID: 28874 RVA: 0x00234AFD File Offset: 0x00232CFD
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ShowParamsIter()或GetShowParamsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] ShowParams()
		{
			return this.ShowParamsIter().ToArray<string>();
		}

		// Token: 0x060070CB RID: 28875 RVA: 0x00234B0A File Offset: 0x00232D0A
		[NullableContext(1)]
		public readonly IEnumerable<string> ShowParamsIter()
		{
			FishingTechEffect.<ShowParamsIter>d__37 <ShowParamsIter>d__ = new FishingTechEffect.<ShowParamsIter>d__37(-2);
			<ShowParamsIter>d__.<>3__<>4__this = this;
			return <ShowParamsIter>d__;
		}

		// Token: 0x060070CC RID: 28876 RVA: 0x00234B20 File Offset: 0x00232D20
		public int? GetConsume(int key)
		{
			this.EnsureConsumeCacheIfNeeded();
			int value;
			if (!this.ConsumeCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x060070CD RID: 28877 RVA: 0x00234B54 File Offset: 0x00232D54
		public int? GetParamDic(int key)
		{
			this.EnsureParamDicCacheIfNeeded();
			int value;
			if (!this.ParamDicCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x060070CE RID: 28878 RVA: 0x00234B88 File Offset: 0x00232D88
		private void EnsureConsumeCacheIfNeeded()
		{
			if (this.ConsumeCache != null)
			{
				return;
			}
			this.ConsumeCache = this.ConsumeIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x060070CF RID: 28879 RVA: 0x00234BF0 File Offset: 0x00232DF0
		private void EnsureParamDicCacheIfNeeded()
		{
			if (this.ParamDicCache != null)
			{
				return;
			}
			this.ParamDicCache = this.ParamDicIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x060070D0 RID: 28880 RVA: 0x00234C56 File Offset: 0x00232E56
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetConsumeFrozenDict(int key)
		{
			this.EnsureConsumeCacheIfNeeded();
			return this.ConsumeCache;
		}

		// Token: 0x060070D1 RID: 28881 RVA: 0x00234C64 File Offset: 0x00232E64
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetParamDicFrozenDict(int key)
		{
			this.EnsureParamDicCacheIfNeeded();
			return this.ParamDicCache;
		}

		// Token: 0x04004CE3 RID: 19683
		private Table __p;

		// Token: 0x04004CE4 RID: 19684
		[Nullable(2)]
		private FrozenDictionary<int, int> ConsumeCache;

		// Token: 0x04004CE5 RID: 19685
		[Nullable(2)]
		private FrozenDictionary<int, int> ParamDicCache;
	}
}

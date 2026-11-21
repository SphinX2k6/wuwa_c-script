using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D72 RID: 3442
	public struct FishingTechEffect : IFlatbufferObject
	{
		// Token: 0x17001243 RID: 4675
		// (get) Token: 0x060076BA RID: 30394 RVA: 0x00253765 File Offset: 0x00251965
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060076BB RID: 30395 RVA: 0x00253772 File Offset: 0x00251972
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060076BC RID: 30396 RVA: 0x0025377C File Offset: 0x0025197C
		public static FishingTechEffect GetRootAsFishingTechEffect(ByteBuffer _bb)
		{
			return FishingTechEffect.GetRootAsFishingTechEffect(_bb, default(FishingTechEffect));
		}

		// Token: 0x060076BD RID: 30397 RVA: 0x00253798 File Offset: 0x00251998
		public static FishingTechEffect GetRootAsFishingTechEffect(ByteBuffer _bb, FishingTechEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060076BE RID: 30398 RVA: 0x002537B5 File Offset: 0x002519B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060076BF RID: 30399 RVA: 0x002537C4 File Offset: 0x002519C4
		public FishingTechEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001244 RID: 4676
		// (get) Token: 0x060076C0 RID: 30400 RVA: 0x002537D4 File Offset: 0x002519D4
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

		// Token: 0x17001245 RID: 4677
		// (get) Token: 0x060076C1 RID: 30401 RVA: 0x00253810 File Offset: 0x00251A10
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

		// Token: 0x060076C2 RID: 30402 RVA: 0x0025384C File Offset: 0x00251A4C
		public DicIntInt? Consume(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001246 RID: 4678
		// (get) Token: 0x060076C3 RID: 30403 RVA: 0x002538AC File Offset: 0x00251AAC
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

		// Token: 0x17001247 RID: 4679
		// (get) Token: 0x060076C4 RID: 30404 RVA: 0x002538D8 File Offset: 0x00251AD8
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

		// Token: 0x060076C5 RID: 30405 RVA: 0x00253910 File Offset: 0x00251B10
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060076C6 RID: 30406 RVA: 0x00253920 File Offset: 0x00251B20
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x060076C7 RID: 30407 RVA: 0x00253938 File Offset: 0x00251B38
		public int Params(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001248 RID: 4680
		// (get) Token: 0x060076C8 RID: 30408 RVA: 0x00253978 File Offset: 0x00251B78
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

		// Token: 0x060076C9 RID: 30409 RVA: 0x002539A4 File Offset: 0x00251BA4
		public Span<int> GetParamsBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x060076CA RID: 30410 RVA: 0x002539B4 File Offset: 0x00251BB4
		public int[] GetParamsArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x060076CB RID: 30411 RVA: 0x002539CC File Offset: 0x00251BCC
		public DicIntInt? ParamDic(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001249 RID: 4681
		// (get) Token: 0x060076CC RID: 30412 RVA: 0x00253A30 File Offset: 0x00251C30
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

		// Token: 0x060076CD RID: 30413 RVA: 0x00253A5C File Offset: 0x00251C5C
		public string ShowParams(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700124A RID: 4682
		// (get) Token: 0x060076CE RID: 30414 RVA: 0x00253A98 File Offset: 0x00251C98
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

		// Token: 0x060076CF RID: 30415 RVA: 0x00253AC4 File Offset: 0x00251CC4
		[NullableContext(1)]
		public Dictionary<int, int> Consume()
		{
			return this.ConsumeIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x060076D0 RID: 30416 RVA: 0x00253B1A File Offset: 0x00251D1A
		[NullableContext(1)]
		public IEnumerable<DicIntInt> ConsumeIter()
		{
			FishingTechEffect.<ConsumeIter>d__31 <ConsumeIter>d__ = new FishingTechEffect.<ConsumeIter>d__31(-2);
			<ConsumeIter>d__.<>3__<>4__this = this;
			return <ConsumeIter>d__;
		}

		// Token: 0x060076D1 RID: 30417 RVA: 0x00253B30 File Offset: 0x00251D30
		[NullableContext(1)]
		public Dictionary<int, int> ParamDic()
		{
			return this.ParamDicIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x060076D2 RID: 30418 RVA: 0x00253B86 File Offset: 0x00251D86
		[NullableContext(1)]
		public IEnumerable<DicIntInt> ParamDicIter()
		{
			FishingTechEffect.<ParamDicIter>d__33 <ParamDicIter>d__ = new FishingTechEffect.<ParamDicIter>d__33(-2);
			<ParamDicIter>d__.<>3__<>4__this = this;
			return <ParamDicIter>d__;
		}

		// Token: 0x060076D3 RID: 30419 RVA: 0x00253B9B File Offset: 0x00251D9B
		[NullableContext(1)]
		public int[] Params()
		{
			return this.GetParamsArray();
		}

		// Token: 0x060076D4 RID: 30420 RVA: 0x00253BA3 File Offset: 0x00251DA3
		[NullableContext(1)]
		public IEnumerable<int> ParamsIter()
		{
			FishingTechEffect.<ParamsIter>d__35 <ParamsIter>d__ = new FishingTechEffect.<ParamsIter>d__35(-2);
			<ParamsIter>d__.<>3__<>4__this = this;
			return <ParamsIter>d__;
		}

		// Token: 0x060076D5 RID: 30421 RVA: 0x00253BB8 File Offset: 0x00251DB8
		[NullableContext(1)]
		public string[] ShowParams()
		{
			return this.ShowParamsIter().ToArray<string>();
		}

		// Token: 0x060076D6 RID: 30422 RVA: 0x00253BC5 File Offset: 0x00251DC5
		[NullableContext(1)]
		public IEnumerable<string> ShowParamsIter()
		{
			FishingTechEffect.<ShowParamsIter>d__37 <ShowParamsIter>d__ = new FishingTechEffect.<ShowParamsIter>d__37(-2);
			<ShowParamsIter>d__.<>3__<>4__this = this;
			return <ShowParamsIter>d__;
		}

		// Token: 0x060076D7 RID: 30423 RVA: 0x00253BDC File Offset: 0x00251DDC
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

		// Token: 0x060076D8 RID: 30424 RVA: 0x00253C10 File Offset: 0x00251E10
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

		// Token: 0x060076D9 RID: 30425 RVA: 0x00253C44 File Offset: 0x00251E44
		private void EnsureConsumeCacheIfNeeded()
		{
			if (this.ConsumeCache != null)
			{
				return;
			}
			this.ConsumeCache = this.ConsumeIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x060076DA RID: 30426 RVA: 0x00253CAC File Offset: 0x00251EAC
		private void EnsureParamDicCacheIfNeeded()
		{
			if (this.ParamDicCache != null)
			{
				return;
			}
			this.ParamDicCache = this.ParamDicIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x060076DB RID: 30427 RVA: 0x00253D12 File Offset: 0x00251F12
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetConsumeFrozenDict()
		{
			this.EnsureConsumeCacheIfNeeded();
			return this.ConsumeCache;
		}

		// Token: 0x060076DC RID: 30428 RVA: 0x00253D20 File Offset: 0x00251F20
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetParamDicFrozenDict()
		{
			this.EnsureParamDicCacheIfNeeded();
			return this.ParamDicCache;
		}

		// Token: 0x040052C7 RID: 21191
		private Table __p;

		// Token: 0x040052C8 RID: 21192
		[Nullable(2)]
		private FrozenDictionary<int, int> ConsumeCache;

		// Token: 0x040052C9 RID: 21193
		[Nullable(2)]
		private FrozenDictionary<int, int> ParamDicCache;
	}
}

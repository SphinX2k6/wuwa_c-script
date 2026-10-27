using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001191 RID: 4497
	public struct WeaponBreach : IFlatbufferObject
	{
		// Token: 0x17003DAF RID: 15791
		// (get) Token: 0x0600E75C RID: 59228 RVA: 0x00341395 File Offset: 0x0033F595
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E75D RID: 59229 RVA: 0x003413A2 File Offset: 0x0033F5A2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E75E RID: 59230 RVA: 0x003413AC File Offset: 0x0033F5AC
		public static WeaponBreach GetRootAsWeaponBreach(ByteBuffer _bb)
		{
			return WeaponBreach.GetRootAsWeaponBreach(_bb, default(WeaponBreach));
		}

		// Token: 0x0600E75F RID: 59231 RVA: 0x003413C8 File Offset: 0x0033F5C8
		public static WeaponBreach GetRootAsWeaponBreach(ByteBuffer _bb, WeaponBreach obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E760 RID: 59232 RVA: 0x003413E5 File Offset: 0x0033F5E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E761 RID: 59233 RVA: 0x003413F4 File Offset: 0x0033F5F4
		public WeaponBreach __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003DB0 RID: 15792
		// (get) Token: 0x0600E762 RID: 59234 RVA: 0x00341404 File Offset: 0x0033F604
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

		// Token: 0x17003DB1 RID: 15793
		// (get) Token: 0x0600E763 RID: 59235 RVA: 0x00341440 File Offset: 0x0033F640
		public int BreachId
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

		// Token: 0x17003DB2 RID: 15794
		// (get) Token: 0x0600E764 RID: 59236 RVA: 0x0034147C File Offset: 0x0033F67C
		public int Level
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

		// Token: 0x17003DB3 RID: 15795
		// (get) Token: 0x0600E765 RID: 59237 RVA: 0x003414B8 File Offset: 0x0033F6B8
		public int ConditionId
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

		// Token: 0x17003DB4 RID: 15796
		// (get) Token: 0x0600E766 RID: 59238 RVA: 0x003414F8 File Offset: 0x0033F6F8
		public int LevelLimit
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

		// Token: 0x0600E767 RID: 59239 RVA: 0x00341538 File Offset: 0x0033F738
		public DicIntInt? Consume(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003DB5 RID: 15797
		// (get) Token: 0x0600E768 RID: 59240 RVA: 0x0034159C File Offset: 0x0033F79C
		public int ConsumeLength
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

		// Token: 0x17003DB6 RID: 15798
		// (get) Token: 0x0600E769 RID: 59241 RVA: 0x003415C8 File Offset: 0x0033F7C8
		public int GoldConsume
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

		// Token: 0x0600E76A RID: 59242 RVA: 0x00341608 File Offset: 0x0033F808
		[NullableContext(1)]
		[Obsolete("已废弃，请使用ConsumeFrozenDict()缓存字典，遍历请使用ConsumeIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> Consume()
		{
			return this.ConsumeIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600E76B RID: 59243 RVA: 0x0034165E File Offset: 0x0033F85E
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> ConsumeIter()
		{
			WeaponBreach.<ConsumeIter>d__24 <ConsumeIter>d__ = new WeaponBreach.<ConsumeIter>d__24(-2);
			<ConsumeIter>d__.<>3__<>4__this = this;
			return <ConsumeIter>d__;
		}

		// Token: 0x0600E76C RID: 59244 RVA: 0x00341674 File Offset: 0x0033F874
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

		// Token: 0x0600E76D RID: 59245 RVA: 0x003416A8 File Offset: 0x0033F8A8
		private void EnsureConsumeCacheIfNeeded()
		{
			if (this.ConsumeCache != null)
			{
				return;
			}
			this.ConsumeCache = this.ConsumeIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600E76E RID: 59246 RVA: 0x0034170E File Offset: 0x0033F90E
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetConsumeFrozenDict(int key)
		{
			this.EnsureConsumeCacheIfNeeded();
			return this.ConsumeCache;
		}

		// Token: 0x040052DB RID: 21211
		private Table __p;

		// Token: 0x040052DC RID: 21212
		[Nullable(2)]
		private FrozenDictionary<int, int> ConsumeCache;
	}
}

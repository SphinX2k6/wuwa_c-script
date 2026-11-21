using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E8A RID: 3722
	public struct KurotatoLevelGrowth : IFlatbufferObject
	{
		// Token: 0x17001C20 RID: 7200
		// (get) Token: 0x0600908B RID: 37003 RVA: 0x0028E82A File Offset: 0x0028CA2A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600908C RID: 37004 RVA: 0x0028E837 File Offset: 0x0028CA37
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600908D RID: 37005 RVA: 0x0028E840 File Offset: 0x0028CA40
		public static KurotatoLevelGrowth GetRootAsKurotatoLevelGrowth(ByteBuffer _bb)
		{
			return KurotatoLevelGrowth.GetRootAsKurotatoLevelGrowth(_bb, default(KurotatoLevelGrowth));
		}

		// Token: 0x0600908E RID: 37006 RVA: 0x0028E85C File Offset: 0x0028CA5C
		public static KurotatoLevelGrowth GetRootAsKurotatoLevelGrowth(ByteBuffer _bb, KurotatoLevelGrowth obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600908F RID: 37007 RVA: 0x0028E879 File Offset: 0x0028CA79
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009090 RID: 37008 RVA: 0x0028E888 File Offset: 0x0028CA88
		public KurotatoLevelGrowth __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001C21 RID: 7201
		// (get) Token: 0x06009091 RID: 37009 RVA: 0x0028E898 File Offset: 0x0028CA98
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

		// Token: 0x17001C22 RID: 7202
		// (get) Token: 0x06009092 RID: 37010 RVA: 0x0028E8D4 File Offset: 0x0028CAD4
		public int GroupId
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

		// Token: 0x17001C23 RID: 7203
		// (get) Token: 0x06009093 RID: 37011 RVA: 0x0028E910 File Offset: 0x0028CB10
		public int ActiveLeveld
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001C24 RID: 7204
		// (get) Token: 0x06009094 RID: 37012 RVA: 0x0028E94C File Offset: 0x0028CB4C
		public int ActiveWaveId
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009095 RID: 37013 RVA: 0x0028E98C File Offset: 0x0028CB8C
		public DicStringFloat? PropertyGrowth(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new DicStringFloat?(default(DicStringFloat).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001C25 RID: 7205
		// (get) Token: 0x06009096 RID: 37014 RVA: 0x0028E9F0 File Offset: 0x0028CBF0
		public int PropertyGrowthLength
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

		// Token: 0x06009097 RID: 37015 RVA: 0x0028EA1C File Offset: 0x0028CC1C
		[NullableContext(1)]
		public Dictionary<string, float> PropertyGrowth()
		{
			return this.PropertyGrowthIter().ToDictionary((DicStringFloat element) => element.Key, (DicStringFloat element) => element.Value);
		}

		// Token: 0x06009098 RID: 37016 RVA: 0x0028EA72 File Offset: 0x0028CC72
		[NullableContext(1)]
		public IEnumerable<DicStringFloat> PropertyGrowthIter()
		{
			KurotatoLevelGrowth.<PropertyGrowthIter>d__20 <PropertyGrowthIter>d__ = new KurotatoLevelGrowth.<PropertyGrowthIter>d__20(-2);
			<PropertyGrowthIter>d__.<>3__<>4__this = this;
			return <PropertyGrowthIter>d__;
		}

		// Token: 0x06009099 RID: 37017 RVA: 0x0028EA88 File Offset: 0x0028CC88
		[NullableContext(1)]
		public float? GetPropertyGrowth(string key)
		{
			this.EnsurePropertyGrowthCacheIfNeeded();
			float value;
			if (!this.PropertyGrowthCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new float?(value);
		}

		// Token: 0x0600909A RID: 37018 RVA: 0x0028EABC File Offset: 0x0028CCBC
		private void EnsurePropertyGrowthCacheIfNeeded()
		{
			if (this.PropertyGrowthCache != null)
			{
				return;
			}
			this.PropertyGrowthCache = this.PropertyGrowthIter().ToFrozenDictionary((DicStringFloat kvp) => kvp.Key, (DicStringFloat kvp) => kvp.Value, null);
		}

		// Token: 0x0600909B RID: 37019 RVA: 0x0028EB22 File Offset: 0x0028CD22
		[NullableContext(1)]
		public FrozenDictionary<string, float> GetPropertyGrowthFrozenDict()
		{
			this.EnsurePropertyGrowthCacheIfNeeded();
			return this.PropertyGrowthCache;
		}

		// Token: 0x0400541B RID: 21531
		private Table __p;

		// Token: 0x0400541C RID: 21532
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<string, float> PropertyGrowthCache;
	}
}

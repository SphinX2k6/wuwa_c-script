using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E84 RID: 3716
	public struct KurotatoGeneralGrowth : IFlatbufferObject
	{
		// Token: 0x17001BD8 RID: 7128
		// (get) Token: 0x06008FB1 RID: 36785 RVA: 0x0028CAD5 File Offset: 0x0028ACD5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008FB2 RID: 36786 RVA: 0x0028CAE2 File Offset: 0x0028ACE2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008FB3 RID: 36787 RVA: 0x0028CAEC File Offset: 0x0028ACEC
		public static KurotatoGeneralGrowth GetRootAsKurotatoGeneralGrowth(ByteBuffer _bb)
		{
			return KurotatoGeneralGrowth.GetRootAsKurotatoGeneralGrowth(_bb, default(KurotatoGeneralGrowth));
		}

		// Token: 0x06008FB4 RID: 36788 RVA: 0x0028CB08 File Offset: 0x0028AD08
		public static KurotatoGeneralGrowth GetRootAsKurotatoGeneralGrowth(ByteBuffer _bb, KurotatoGeneralGrowth obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008FB5 RID: 36789 RVA: 0x0028CB25 File Offset: 0x0028AD25
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008FB6 RID: 36790 RVA: 0x0028CB34 File Offset: 0x0028AD34
		public KurotatoGeneralGrowth __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001BD9 RID: 7129
		// (get) Token: 0x06008FB7 RID: 36791 RVA: 0x0028CB44 File Offset: 0x0028AD44
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

		// Token: 0x17001BDA RID: 7130
		// (get) Token: 0x06008FB8 RID: 36792 RVA: 0x0028CB80 File Offset: 0x0028AD80
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

		// Token: 0x17001BDB RID: 7131
		// (get) Token: 0x06008FB9 RID: 36793 RVA: 0x0028CBBC File Offset: 0x0028ADBC
		public int ActiveWaveId
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

		// Token: 0x06008FBA RID: 36794 RVA: 0x0028CBF8 File Offset: 0x0028ADF8
		public DicStringFloat? PropertyGrowth(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new DicStringFloat?(default(DicStringFloat).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001BDC RID: 7132
		// (get) Token: 0x06008FBB RID: 36795 RVA: 0x0028CC5C File Offset: 0x0028AE5C
		public int PropertyGrowthLength
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

		// Token: 0x06008FBC RID: 36796 RVA: 0x0028CC88 File Offset: 0x0028AE88
		[NullableContext(1)]
		public Dictionary<string, float> PropertyGrowth()
		{
			return this.PropertyGrowthIter().ToDictionary((DicStringFloat element) => element.Key, (DicStringFloat element) => element.Value);
		}

		// Token: 0x06008FBD RID: 36797 RVA: 0x0028CCDE File Offset: 0x0028AEDE
		[NullableContext(1)]
		public IEnumerable<DicStringFloat> PropertyGrowthIter()
		{
			KurotatoGeneralGrowth.<PropertyGrowthIter>d__18 <PropertyGrowthIter>d__ = new KurotatoGeneralGrowth.<PropertyGrowthIter>d__18(-2);
			<PropertyGrowthIter>d__.<>3__<>4__this = this;
			return <PropertyGrowthIter>d__;
		}

		// Token: 0x06008FBE RID: 36798 RVA: 0x0028CCF4 File Offset: 0x0028AEF4
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

		// Token: 0x06008FBF RID: 36799 RVA: 0x0028CD28 File Offset: 0x0028AF28
		private void EnsurePropertyGrowthCacheIfNeeded()
		{
			if (this.PropertyGrowthCache != null)
			{
				return;
			}
			this.PropertyGrowthCache = this.PropertyGrowthIter().ToFrozenDictionary((DicStringFloat kvp) => kvp.Key, (DicStringFloat kvp) => kvp.Value, null);
		}

		// Token: 0x06008FC0 RID: 36800 RVA: 0x0028CD8E File Offset: 0x0028AF8E
		[NullableContext(1)]
		public FrozenDictionary<string, float> GetPropertyGrowthFrozenDict()
		{
			this.EnsurePropertyGrowthCacheIfNeeded();
			return this.PropertyGrowthCache;
		}

		// Token: 0x04005414 RID: 21524
		private Table __p;

		// Token: 0x04005415 RID: 21525
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<string, float> PropertyGrowthCache;
	}
}

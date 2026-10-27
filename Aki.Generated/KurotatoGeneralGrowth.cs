using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D9F RID: 3487
	public struct KurotatoGeneralGrowth : IFlatbufferObject
	{
		// Token: 0x17001B74 RID: 7028
		// (get) Token: 0x06008995 RID: 35221 RVA: 0x0026DF59 File Offset: 0x0026C159
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008996 RID: 35222 RVA: 0x0026DF66 File Offset: 0x0026C166
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008997 RID: 35223 RVA: 0x0026DF70 File Offset: 0x0026C170
		public static KurotatoGeneralGrowth GetRootAsKurotatoGeneralGrowth(ByteBuffer _bb)
		{
			return KurotatoGeneralGrowth.GetRootAsKurotatoGeneralGrowth(_bb, default(KurotatoGeneralGrowth));
		}

		// Token: 0x06008998 RID: 35224 RVA: 0x0026DF8C File Offset: 0x0026C18C
		public static KurotatoGeneralGrowth GetRootAsKurotatoGeneralGrowth(ByteBuffer _bb, KurotatoGeneralGrowth obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008999 RID: 35225 RVA: 0x0026DFA9 File Offset: 0x0026C1A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600899A RID: 35226 RVA: 0x0026DFB8 File Offset: 0x0026C1B8
		public KurotatoGeneralGrowth __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001B75 RID: 7029
		// (get) Token: 0x0600899B RID: 35227 RVA: 0x0026DFC8 File Offset: 0x0026C1C8
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

		// Token: 0x17001B76 RID: 7030
		// (get) Token: 0x0600899C RID: 35228 RVA: 0x0026E004 File Offset: 0x0026C204
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

		// Token: 0x17001B77 RID: 7031
		// (get) Token: 0x0600899D RID: 35229 RVA: 0x0026E040 File Offset: 0x0026C240
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

		// Token: 0x0600899E RID: 35230 RVA: 0x0026E07C File Offset: 0x0026C27C
		public DicStringFloat? PropertyGrowth(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new DicStringFloat?(default(DicStringFloat).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001B78 RID: 7032
		// (get) Token: 0x0600899F RID: 35231 RVA: 0x0026E0E0 File Offset: 0x0026C2E0
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

		// Token: 0x060089A0 RID: 35232 RVA: 0x0026E10C File Offset: 0x0026C30C
		[NullableContext(1)]
		[Obsolete("已废弃，请使用PropertyGrowthFrozenDict()缓存字典，遍历请使用PropertyGrowthIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<string, float> PropertyGrowth()
		{
			return this.PropertyGrowthIter().ToDictionary((DicStringFloat element) => element.Key, (DicStringFloat element) => element.Value);
		}

		// Token: 0x060089A1 RID: 35233 RVA: 0x0026E162 File Offset: 0x0026C362
		[NullableContext(1)]
		public readonly IEnumerable<DicStringFloat> PropertyGrowthIter()
		{
			KurotatoGeneralGrowth.<PropertyGrowthIter>d__18 <PropertyGrowthIter>d__ = new KurotatoGeneralGrowth.<PropertyGrowthIter>d__18(-2);
			<PropertyGrowthIter>d__.<>3__<>4__this = this;
			return <PropertyGrowthIter>d__;
		}

		// Token: 0x060089A2 RID: 35234 RVA: 0x0026E178 File Offset: 0x0026C378
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

		// Token: 0x060089A3 RID: 35235 RVA: 0x0026E1AC File Offset: 0x0026C3AC
		private void EnsurePropertyGrowthCacheIfNeeded()
		{
			if (this.PropertyGrowthCache != null)
			{
				return;
			}
			this.PropertyGrowthCache = this.PropertyGrowthIter().ToFrozenDictionary((DicStringFloat kvp) => kvp.Key, (DicStringFloat kvp) => kvp.Value, null);
		}

		// Token: 0x060089A4 RID: 35236 RVA: 0x0026E212 File Offset: 0x0026C412
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public FrozenDictionary<string, float> GetPropertyGrowthFrozenDict(string key)
		{
			this.EnsurePropertyGrowthCacheIfNeeded();
			return this.PropertyGrowthCache;
		}

		// Token: 0x04004E2F RID: 20015
		private Table __p;

		// Token: 0x04004E30 RID: 20016
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<string, float> PropertyGrowthCache;
	}
}

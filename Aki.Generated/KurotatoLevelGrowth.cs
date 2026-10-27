using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DA5 RID: 3493
	public struct KurotatoLevelGrowth : IFlatbufferObject
	{
		// Token: 0x17001BBC RID: 7100
		// (get) Token: 0x06008A6F RID: 35439 RVA: 0x0026FE55 File Offset: 0x0026E055
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008A70 RID: 35440 RVA: 0x0026FE62 File Offset: 0x0026E062
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008A71 RID: 35441 RVA: 0x0026FE6C File Offset: 0x0026E06C
		public static KurotatoLevelGrowth GetRootAsKurotatoLevelGrowth(ByteBuffer _bb)
		{
			return KurotatoLevelGrowth.GetRootAsKurotatoLevelGrowth(_bb, default(KurotatoLevelGrowth));
		}

		// Token: 0x06008A72 RID: 35442 RVA: 0x0026FE88 File Offset: 0x0026E088
		public static KurotatoLevelGrowth GetRootAsKurotatoLevelGrowth(ByteBuffer _bb, KurotatoLevelGrowth obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008A73 RID: 35443 RVA: 0x0026FEA5 File Offset: 0x0026E0A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008A74 RID: 35444 RVA: 0x0026FEB4 File Offset: 0x0026E0B4
		public KurotatoLevelGrowth __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001BBD RID: 7101
		// (get) Token: 0x06008A75 RID: 35445 RVA: 0x0026FEC4 File Offset: 0x0026E0C4
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

		// Token: 0x17001BBE RID: 7102
		// (get) Token: 0x06008A76 RID: 35446 RVA: 0x0026FF00 File Offset: 0x0026E100
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

		// Token: 0x17001BBF RID: 7103
		// (get) Token: 0x06008A77 RID: 35447 RVA: 0x0026FF3C File Offset: 0x0026E13C
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

		// Token: 0x17001BC0 RID: 7104
		// (get) Token: 0x06008A78 RID: 35448 RVA: 0x0026FF78 File Offset: 0x0026E178
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

		// Token: 0x06008A79 RID: 35449 RVA: 0x0026FFB8 File Offset: 0x0026E1B8
		public DicStringFloat? PropertyGrowth(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new DicStringFloat?(default(DicStringFloat).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001BC1 RID: 7105
		// (get) Token: 0x06008A7A RID: 35450 RVA: 0x0027001C File Offset: 0x0026E21C
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

		// Token: 0x06008A7B RID: 35451 RVA: 0x00270048 File Offset: 0x0026E248
		[NullableContext(1)]
		[Obsolete("已废弃，请使用PropertyGrowthFrozenDict()缓存字典，遍历请使用PropertyGrowthIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<string, float> PropertyGrowth()
		{
			return this.PropertyGrowthIter().ToDictionary((DicStringFloat element) => element.Key, (DicStringFloat element) => element.Value);
		}

		// Token: 0x06008A7C RID: 35452 RVA: 0x0027009E File Offset: 0x0026E29E
		[NullableContext(1)]
		public readonly IEnumerable<DicStringFloat> PropertyGrowthIter()
		{
			KurotatoLevelGrowth.<PropertyGrowthIter>d__20 <PropertyGrowthIter>d__ = new KurotatoLevelGrowth.<PropertyGrowthIter>d__20(-2);
			<PropertyGrowthIter>d__.<>3__<>4__this = this;
			return <PropertyGrowthIter>d__;
		}

		// Token: 0x06008A7D RID: 35453 RVA: 0x002700B4 File Offset: 0x0026E2B4
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

		// Token: 0x06008A7E RID: 35454 RVA: 0x002700E8 File Offset: 0x0026E2E8
		private void EnsurePropertyGrowthCacheIfNeeded()
		{
			if (this.PropertyGrowthCache != null)
			{
				return;
			}
			this.PropertyGrowthCache = this.PropertyGrowthIter().ToFrozenDictionary((DicStringFloat kvp) => kvp.Key, (DicStringFloat kvp) => kvp.Value, null);
		}

		// Token: 0x06008A7F RID: 35455 RVA: 0x0027014E File Offset: 0x0026E34E
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

		// Token: 0x04004E36 RID: 20022
		private Table __p;

		// Token: 0x04004E37 RID: 20023
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<string, float> PropertyGrowthCache;
	}
}

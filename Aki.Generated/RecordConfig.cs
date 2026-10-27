using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FA4 RID: 4004
	public struct RecordConfig : IFlatbufferObject
	{
		// Token: 0x17002D68 RID: 11624
		// (get) Token: 0x0600BA59 RID: 47705 RVA: 0x002DA8F4 File Offset: 0x002D8AF4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BA5A RID: 47706 RVA: 0x002DA901 File Offset: 0x002D8B01
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BA5B RID: 47707 RVA: 0x002DA908 File Offset: 0x002D8B08
		public static RecordConfig GetRootAsRecordConfig(ByteBuffer _bb)
		{
			return RecordConfig.GetRootAsRecordConfig(_bb, default(RecordConfig));
		}

		// Token: 0x0600BA5C RID: 47708 RVA: 0x002DA924 File Offset: 0x002D8B24
		public static RecordConfig GetRootAsRecordConfig(ByteBuffer _bb, RecordConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BA5D RID: 47709 RVA: 0x002DA941 File Offset: 0x002D8B41
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BA5E RID: 47710 RVA: 0x002DA950 File Offset: 0x002D8B50
		public RecordConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002D69 RID: 11625
		// (get) Token: 0x0600BA5F RID: 47711 RVA: 0x002DA960 File Offset: 0x002D8B60
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

		// Token: 0x0600BA60 RID: 47712 RVA: 0x002DA99C File Offset: 0x002D8B9C
		public DicStringString? LimitParams(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17002D6A RID: 11626
		// (get) Token: 0x0600BA61 RID: 47713 RVA: 0x002DA9FC File Offset: 0x002D8BFC
		public int LimitParamsLength
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

		// Token: 0x17002D6B RID: 11627
		// (get) Token: 0x0600BA62 RID: 47714 RVA: 0x002DAA28 File Offset: 0x002D8C28
		public int ProgressNeed
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

		// Token: 0x17002D6C RID: 11628
		// (get) Token: 0x0600BA63 RID: 47715 RVA: 0x002DAA64 File Offset: 0x002D8C64
		public bool SaveRecord
		{
			get
			{
				int num = this.__p.__offset(10);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0600BA64 RID: 47716 RVA: 0x002DAAA4 File Offset: 0x002D8CA4
		[NullableContext(1)]
		[Obsolete("已废弃，请使用LimitParamsFrozenDict()缓存字典，遍历请使用LimitParamsIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<string, string> LimitParams()
		{
			return this.LimitParamsIter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x0600BA65 RID: 47717 RVA: 0x002DAAFA File Offset: 0x002D8CFA
		[NullableContext(1)]
		public readonly IEnumerable<DicStringString> LimitParamsIter()
		{
			RecordConfig.<LimitParamsIter>d__18 <LimitParamsIter>d__ = new RecordConfig.<LimitParamsIter>d__18(-2);
			<LimitParamsIter>d__.<>3__<>4__this = this;
			return <LimitParamsIter>d__;
		}

		// Token: 0x0600BA66 RID: 47718 RVA: 0x002DAB10 File Offset: 0x002D8D10
		[NullableContext(1)]
		[return: Nullable(2)]
		public string GetLimitParams(string key)
		{
			this.EnsureLimitParamsCacheIfNeeded();
			string result;
			if (!this.LimitParamsCache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x0600BA67 RID: 47719 RVA: 0x002DAB38 File Offset: 0x002D8D38
		private void EnsureLimitParamsCacheIfNeeded()
		{
			if (this.LimitParamsCache != null)
			{
				return;
			}
			this.LimitParamsCache = this.LimitParamsIter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x0600BA68 RID: 47720 RVA: 0x002DAB9E File Offset: 0x002D8D9E
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public FrozenDictionary<string, string> GetLimitParamsFrozenDict(string key)
		{
			this.EnsureLimitParamsCacheIfNeeded();
			return this.LimitParamsCache;
		}

		// Token: 0x0400507C RID: 20604
		private Table __p;

		// Token: 0x0400507D RID: 20605
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> LimitParamsCache;
	}
}

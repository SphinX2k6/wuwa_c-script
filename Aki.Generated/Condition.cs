using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B94 RID: 2964
	public struct Condition : IFlatbufferObject
	{
		// Token: 0x170008F6 RID: 2294
		// (get) Token: 0x060057F7 RID: 22519 RVA: 0x001FBD84 File Offset: 0x001F9F84
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060057F8 RID: 22520 RVA: 0x001FBD91 File Offset: 0x001F9F91
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060057F9 RID: 22521 RVA: 0x001FBD98 File Offset: 0x001F9F98
		public static Condition GetRootAsCondition(ByteBuffer _bb)
		{
			return Condition.GetRootAsCondition(_bb, default(Condition));
		}

		// Token: 0x060057FA RID: 22522 RVA: 0x001FBDB4 File Offset: 0x001F9FB4
		public static Condition GetRootAsCondition(ByteBuffer _bb, Condition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060057FB RID: 22523 RVA: 0x001FBDD1 File Offset: 0x001F9FD1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060057FC RID: 22524 RVA: 0x001FBDE0 File Offset: 0x001F9FE0
		public Condition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170008F7 RID: 2295
		// (get) Token: 0x060057FD RID: 22525 RVA: 0x001FBDF0 File Offset: 0x001F9FF0
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

		// Token: 0x170008F8 RID: 2296
		// (get) Token: 0x060057FE RID: 22526 RVA: 0x001FBE2C File Offset: 0x001FA02C
		public string Type
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060057FF RID: 22527 RVA: 0x001FBE63 File Offset: 0x001FA063
		public Span<byte> GetTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06005800 RID: 22528 RVA: 0x001FBE72 File Offset: 0x001FA072
		public byte[] GetTypeArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170008F9 RID: 2297
		// (get) Token: 0x06005801 RID: 22529 RVA: 0x001FBE8C File Offset: 0x001FA08C
		public int NeedNum
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

		// Token: 0x06005802 RID: 22530 RVA: 0x001FBEC8 File Offset: 0x001FA0C8
		public DicStringString? LimitParams(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170008FA RID: 2298
		// (get) Token: 0x06005803 RID: 22531 RVA: 0x001FBF2C File Offset: 0x001FA12C
		public int LimitParamsLength
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

		// Token: 0x06005804 RID: 22532 RVA: 0x001FBF58 File Offset: 0x001FA158
		public DicStringString? LimitParamsOpe(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170008FB RID: 2299
		// (get) Token: 0x06005805 RID: 22533 RVA: 0x001FBFBC File Offset: 0x001FA1BC
		public int LimitParamsOpeLength
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

		// Token: 0x170008FC RID: 2300
		// (get) Token: 0x06005806 RID: 22534 RVA: 0x001FBFE8 File Offset: 0x001FA1E8
		public bool IsClient
		{
			get
			{
				int num = this.__p.__offset(14);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170008FD RID: 2301
		// (get) Token: 0x06005807 RID: 22535 RVA: 0x001FC028 File Offset: 0x001FA228
		public string Description
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005808 RID: 22536 RVA: 0x001FC060 File Offset: 0x001FA260
		public Span<byte> GetDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06005809 RID: 22537 RVA: 0x001FC070 File Offset: 0x001FA270
		public byte[] GetDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170008FE RID: 2302
		// (get) Token: 0x0600580A RID: 22538 RVA: 0x001FC088 File Offset: 0x001FA288
		public int AccessId
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600580B RID: 22539 RVA: 0x001FC0C8 File Offset: 0x001FA2C8
		[NullableContext(1)]
		[Obsolete("已废弃，请使用LimitParamsFrozenDict()缓存字典，遍历请使用LimitParamsIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<string, string> LimitParams()
		{
			return this.LimitParamsIter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x0600580C RID: 22540 RVA: 0x001FC11E File Offset: 0x001FA31E
		[NullableContext(1)]
		public readonly IEnumerable<DicStringString> LimitParamsIter()
		{
			Condition.<LimitParamsIter>d__31 <LimitParamsIter>d__ = new Condition.<LimitParamsIter>d__31(-2);
			<LimitParamsIter>d__.<>3__<>4__this = this;
			return <LimitParamsIter>d__;
		}

		// Token: 0x0600580D RID: 22541 RVA: 0x001FC134 File Offset: 0x001FA334
		[NullableContext(1)]
		[Obsolete("已废弃，请使用LimitParamsOpeFrozenDict()缓存字典，遍历请使用LimitParamsOpeIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<string, string> LimitParamsOpe()
		{
			return this.LimitParamsOpeIter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x0600580E RID: 22542 RVA: 0x001FC18A File Offset: 0x001FA38A
		[NullableContext(1)]
		public readonly IEnumerable<DicStringString> LimitParamsOpeIter()
		{
			Condition.<LimitParamsOpeIter>d__33 <LimitParamsOpeIter>d__ = new Condition.<LimitParamsOpeIter>d__33(-2);
			<LimitParamsOpeIter>d__.<>3__<>4__this = this;
			return <LimitParamsOpeIter>d__;
		}

		// Token: 0x0600580F RID: 22543 RVA: 0x001FC1A0 File Offset: 0x001FA3A0
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

		// Token: 0x06005810 RID: 22544 RVA: 0x001FC1C8 File Offset: 0x001FA3C8
		[NullableContext(1)]
		[return: Nullable(2)]
		public string GetLimitParamsOpe(string key)
		{
			this.EnsureLimitParamsOpeCacheIfNeeded();
			string result;
			if (!this.LimitParamsOpeCache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x06005811 RID: 22545 RVA: 0x001FC1F0 File Offset: 0x001FA3F0
		private void EnsureLimitParamsCacheIfNeeded()
		{
			if (this.LimitParamsCache != null)
			{
				return;
			}
			this.LimitParamsCache = this.LimitParamsIter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x06005812 RID: 22546 RVA: 0x001FC258 File Offset: 0x001FA458
		private void EnsureLimitParamsOpeCacheIfNeeded()
		{
			if (this.LimitParamsOpeCache != null)
			{
				return;
			}
			this.LimitParamsOpeCache = this.LimitParamsOpeIter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x06005813 RID: 22547 RVA: 0x001FC2BE File Offset: 0x001FA4BE
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

		// Token: 0x06005814 RID: 22548 RVA: 0x001FC2CC File Offset: 0x001FA4CC
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public FrozenDictionary<string, string> GetLimitParamsOpeFrozenDict(string key)
		{
			this.EnsureLimitParamsOpeCacheIfNeeded();
			return this.LimitParamsOpeCache;
		}

		// Token: 0x04004BA3 RID: 19363
		private Table __p;

		// Token: 0x04004BA4 RID: 19364
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> LimitParamsCache;

		// Token: 0x04004BA5 RID: 19365
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> LimitParamsOpeCache;
	}
}

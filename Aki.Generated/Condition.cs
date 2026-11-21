using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C76 RID: 3190
	public struct Condition : IFlatbufferObject
	{
		// Token: 0x1700093C RID: 2364
		// (get) Token: 0x06005DD0 RID: 24016 RVA: 0x0021BB60 File Offset: 0x00219D60
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005DD1 RID: 24017 RVA: 0x0021BB6D File Offset: 0x00219D6D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005DD2 RID: 24018 RVA: 0x0021BB74 File Offset: 0x00219D74
		public static Condition GetRootAsCondition(ByteBuffer _bb)
		{
			return Condition.GetRootAsCondition(_bb, default(Condition));
		}

		// Token: 0x06005DD3 RID: 24019 RVA: 0x0021BB90 File Offset: 0x00219D90
		public static Condition GetRootAsCondition(ByteBuffer _bb, Condition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005DD4 RID: 24020 RVA: 0x0021BBAD File Offset: 0x00219DAD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005DD5 RID: 24021 RVA: 0x0021BBBC File Offset: 0x00219DBC
		public Condition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700093D RID: 2365
		// (get) Token: 0x06005DD6 RID: 24022 RVA: 0x0021BBCC File Offset: 0x00219DCC
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

		// Token: 0x1700093E RID: 2366
		// (get) Token: 0x06005DD7 RID: 24023 RVA: 0x0021BC08 File Offset: 0x00219E08
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

		// Token: 0x06005DD8 RID: 24024 RVA: 0x0021BC3F File Offset: 0x00219E3F
		public Span<byte> GetTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06005DD9 RID: 24025 RVA: 0x0021BC4E File Offset: 0x00219E4E
		public byte[] GetTypeArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700093F RID: 2367
		// (get) Token: 0x06005DDA RID: 24026 RVA: 0x0021BC68 File Offset: 0x00219E68
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

		// Token: 0x06005DDB RID: 24027 RVA: 0x0021BCA4 File Offset: 0x00219EA4
		public DicStringString? LimitParams(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000940 RID: 2368
		// (get) Token: 0x06005DDC RID: 24028 RVA: 0x0021BD08 File Offset: 0x00219F08
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

		// Token: 0x06005DDD RID: 24029 RVA: 0x0021BD34 File Offset: 0x00219F34
		public DicStringString? LimitParamsOpe(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000941 RID: 2369
		// (get) Token: 0x06005DDE RID: 24030 RVA: 0x0021BD98 File Offset: 0x00219F98
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

		// Token: 0x17000942 RID: 2370
		// (get) Token: 0x06005DDF RID: 24031 RVA: 0x0021BDC4 File Offset: 0x00219FC4
		public bool IsClient
		{
			get
			{
				int num = this.__p.__offset(14);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000943 RID: 2371
		// (get) Token: 0x06005DE0 RID: 24032 RVA: 0x0021BE04 File Offset: 0x0021A004
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

		// Token: 0x06005DE1 RID: 24033 RVA: 0x0021BE3C File Offset: 0x0021A03C
		public Span<byte> GetDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06005DE2 RID: 24034 RVA: 0x0021BE4C File Offset: 0x0021A04C
		public byte[] GetDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17000944 RID: 2372
		// (get) Token: 0x06005DE3 RID: 24035 RVA: 0x0021BE64 File Offset: 0x0021A064
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

		// Token: 0x06005DE4 RID: 24036 RVA: 0x0021BEA4 File Offset: 0x0021A0A4
		[NullableContext(1)]
		public Dictionary<string, string> LimitParams()
		{
			return this.LimitParamsIter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x06005DE5 RID: 24037 RVA: 0x0021BEFA File Offset: 0x0021A0FA
		[NullableContext(1)]
		public IEnumerable<DicStringString> LimitParamsIter()
		{
			Condition.<LimitParamsIter>d__31 <LimitParamsIter>d__ = new Condition.<LimitParamsIter>d__31(-2);
			<LimitParamsIter>d__.<>3__<>4__this = this;
			return <LimitParamsIter>d__;
		}

		// Token: 0x06005DE6 RID: 24038 RVA: 0x0021BF10 File Offset: 0x0021A110
		[NullableContext(1)]
		public Dictionary<string, string> LimitParamsOpe()
		{
			return this.LimitParamsOpeIter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x06005DE7 RID: 24039 RVA: 0x0021BF66 File Offset: 0x0021A166
		[NullableContext(1)]
		public IEnumerable<DicStringString> LimitParamsOpeIter()
		{
			Condition.<LimitParamsOpeIter>d__33 <LimitParamsOpeIter>d__ = new Condition.<LimitParamsOpeIter>d__33(-2);
			<LimitParamsOpeIter>d__.<>3__<>4__this = this;
			return <LimitParamsOpeIter>d__;
		}

		// Token: 0x06005DE8 RID: 24040 RVA: 0x0021BF7C File Offset: 0x0021A17C
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

		// Token: 0x06005DE9 RID: 24041 RVA: 0x0021BFA4 File Offset: 0x0021A1A4
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

		// Token: 0x06005DEA RID: 24042 RVA: 0x0021BFCC File Offset: 0x0021A1CC
		private void EnsureLimitParamsCacheIfNeeded()
		{
			if (this.LimitParamsCache != null)
			{
				return;
			}
			this.LimitParamsCache = this.LimitParamsIter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x06005DEB RID: 24043 RVA: 0x0021C034 File Offset: 0x0021A234
		private void EnsureLimitParamsOpeCacheIfNeeded()
		{
			if (this.LimitParamsOpeCache != null)
			{
				return;
			}
			this.LimitParamsOpeCache = this.LimitParamsOpeIter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x06005DEC RID: 24044 RVA: 0x0021C09A File Offset: 0x0021A29A
		[NullableContext(1)]
		public FrozenDictionary<string, string> GetLimitParamsFrozenDict()
		{
			this.EnsureLimitParamsCacheIfNeeded();
			return this.LimitParamsCache;
		}

		// Token: 0x06005DED RID: 24045 RVA: 0x0021C0A8 File Offset: 0x0021A2A8
		[NullableContext(1)]
		public FrozenDictionary<string, string> GetLimitParamsOpeFrozenDict()
		{
			this.EnsureLimitParamsOpeCacheIfNeeded();
			return this.LimitParamsOpeCache;
		}

		// Token: 0x04005185 RID: 20869
		private Table __p;

		// Token: 0x04005186 RID: 20870
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> LimitParamsCache;

		// Token: 0x04005187 RID: 20871
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> LimitParamsOpeCache;
	}
}

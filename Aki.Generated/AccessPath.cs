using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000ABB RID: 2747
	public struct AccessPath : IFlatbufferObject
	{
		// Token: 0x170000CE RID: 206
		// (get) Token: 0x06004228 RID: 16936 RVA: 0x001C9494 File Offset: 0x001C7694
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004229 RID: 16937 RVA: 0x001C94A1 File Offset: 0x001C76A1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600422A RID: 16938 RVA: 0x001C94A8 File Offset: 0x001C76A8
		public static AccessPath GetRootAsAccessPath(ByteBuffer _bb)
		{
			return AccessPath.GetRootAsAccessPath(_bb, default(AccessPath));
		}

		// Token: 0x0600422B RID: 16939 RVA: 0x001C94C4 File Offset: 0x001C76C4
		public static AccessPath GetRootAsAccessPath(ByteBuffer _bb, AccessPath obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600422C RID: 16940 RVA: 0x001C94E1 File Offset: 0x001C76E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600422D RID: 16941 RVA: 0x001C94F0 File Offset: 0x001C76F0
		public AccessPath __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x0600422E RID: 16942 RVA: 0x001C9500 File Offset: 0x001C7700
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

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x0600422F RID: 16943 RVA: 0x001C953C File Offset: 0x001C773C
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

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x06004230 RID: 16944 RVA: 0x001C9578 File Offset: 0x001C7778
		public int SkipName
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return -1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x06004231 RID: 16945 RVA: 0x001C95B4 File Offset: 0x001C77B4
		public string Val1
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

		// Token: 0x06004232 RID: 16946 RVA: 0x001C95EC File Offset: 0x001C77EC
		public Span<byte> GetVal1Bytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06004233 RID: 16947 RVA: 0x001C95FC File Offset: 0x001C77FC
		public byte[] GetVal1Array()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x06004234 RID: 16948 RVA: 0x001C9614 File Offset: 0x001C7814
		public string Val2
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004235 RID: 16949 RVA: 0x001C964C File Offset: 0x001C784C
		public Span<byte> GetVal2Bytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06004236 RID: 16950 RVA: 0x001C965C File Offset: 0x001C785C
		public byte[] GetVal2Array()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x06004237 RID: 16951 RVA: 0x001C9674 File Offset: 0x001C7874
		public string Val3
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004238 RID: 16952 RVA: 0x001C96AC File Offset: 0x001C78AC
		public Span<byte> GetVal3Bytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06004239 RID: 16953 RVA: 0x001C96BC File Offset: 0x001C78BC
		public byte[] GetVal3Array()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x0600423A RID: 16954 RVA: 0x001C96D4 File Offset: 0x001C78D4
		public DicIntString? FunctionOpenCheckMap(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new DicIntString?(default(DicIntString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x0600423B RID: 16955 RVA: 0x001C9738 File Offset: 0x001C7938
		public int FunctionOpenCheckMapLength
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

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x0600423C RID: 16956 RVA: 0x001C9764 File Offset: 0x001C7964
		public int SortIndex
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

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x0600423D RID: 16957 RVA: 0x001C97A4 File Offset: 0x001C79A4
		public string Description
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600423E RID: 16958 RVA: 0x001C97DC File Offset: 0x001C79DC
		public Span<byte> GetDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600423F RID: 16959 RVA: 0x001C97EC File Offset: 0x001C79EC
		public byte[] GetDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x06004240 RID: 16960 RVA: 0x001C9804 File Offset: 0x001C7A04
		public int ClientCondition(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x06004241 RID: 16961 RVA: 0x001C9844 File Offset: 0x001C7A44
		public int ClientConditionLength
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06004242 RID: 16962 RVA: 0x001C9870 File Offset: 0x001C7A70
		public Span<int> GetClientConditionBytes()
		{
			return this.__p.__vector_as_span<int>(22, 4);
		}

		// Token: 0x06004243 RID: 16963 RVA: 0x001C9880 File Offset: 0x001C7A80
		public int[] GetClientConditionArray()
		{
			return this.__p.__vector_as_array<int>(22) ?? Array.Empty<int>();
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x06004244 RID: 16964 RVA: 0x001C9898 File Offset: 0x001C7A98
		public string PathValue
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004245 RID: 16965 RVA: 0x001C98D0 File Offset: 0x001C7AD0
		public Span<byte> GetPathValueBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x06004246 RID: 16966 RVA: 0x001C98E0 File Offset: 0x001C7AE0
		public byte[] GetPathValueArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x06004247 RID: 16967 RVA: 0x001C98F8 File Offset: 0x001C7AF8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ClientConditionIter()或GetClientConditionBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ClientCondition()
		{
			AccessPath accessPath = this;
			return accessPath.GetClientConditionArray() ?? Array.Empty<int>();
		}

		// Token: 0x06004248 RID: 16968 RVA: 0x001C991C File Offset: 0x001C7B1C
		[NullableContext(1)]
		public readonly IEnumerable<int> ClientConditionIter()
		{
			AccessPath.<ClientConditionIter>d__45 <ClientConditionIter>d__ = new AccessPath.<ClientConditionIter>d__45(-2);
			<ClientConditionIter>d__.<>3__<>4__this = this;
			return <ClientConditionIter>d__;
		}

		// Token: 0x06004249 RID: 16969 RVA: 0x001C9934 File Offset: 0x001C7B34
		[NullableContext(1)]
		[Obsolete("已废弃，请使用FunctionOpenCheckMapFrozenDict()缓存字典，遍历请使用FunctionOpenCheckMapIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, string> FunctionOpenCheckMap()
		{
			return this.FunctionOpenCheckMapIter().ToDictionary((DicIntString element) => element.Key, (DicIntString element) => element.Value);
		}

		// Token: 0x0600424A RID: 16970 RVA: 0x001C998A File Offset: 0x001C7B8A
		[NullableContext(1)]
		public readonly IEnumerable<DicIntString> FunctionOpenCheckMapIter()
		{
			AccessPath.<FunctionOpenCheckMapIter>d__47 <FunctionOpenCheckMapIter>d__ = new AccessPath.<FunctionOpenCheckMapIter>d__47(-2);
			<FunctionOpenCheckMapIter>d__.<>3__<>4__this = this;
			return <FunctionOpenCheckMapIter>d__;
		}

		// Token: 0x0600424B RID: 16971 RVA: 0x001C99A0 File Offset: 0x001C7BA0
		[NullableContext(2)]
		public string GetFunctionOpenCheckMap(int key)
		{
			this.EnsureFunctionOpenCheckMapCacheIfNeeded();
			string result;
			if (!this.FunctionOpenCheckMapCache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x0600424C RID: 16972 RVA: 0x001C99C8 File Offset: 0x001C7BC8
		private void EnsureFunctionOpenCheckMapCacheIfNeeded()
		{
			if (this.FunctionOpenCheckMapCache != null)
			{
				return;
			}
			this.FunctionOpenCheckMapCache = this.FunctionOpenCheckMapIter().ToFrozenDictionary((DicIntString kvp) => kvp.Key, (DicIntString kvp) => kvp.Value, null);
		}

		// Token: 0x0600424D RID: 16973 RVA: 0x001C9A2E File Offset: 0x001C7C2E
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public FrozenDictionary<int, string> GetFunctionOpenCheckMapFrozenDict(int key)
		{
			this.EnsureFunctionOpenCheckMapCacheIfNeeded();
			return this.FunctionOpenCheckMapCache;
		}

		// Token: 0x04004A94 RID: 19092
		private Table __p;

		// Token: 0x04004A95 RID: 19093
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<int, string> FunctionOpenCheckMapCache;
	}
}

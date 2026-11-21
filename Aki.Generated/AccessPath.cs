using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B90 RID: 2960
	public struct AccessPath : IFlatbufferObject
	{
		// Token: 0x170000CE RID: 206
		// (get) Token: 0x06004726 RID: 18214 RVA: 0x001E86F4 File Offset: 0x001E68F4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004727 RID: 18215 RVA: 0x001E8701 File Offset: 0x001E6901
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004728 RID: 18216 RVA: 0x001E8708 File Offset: 0x001E6908
		public static AccessPath GetRootAsAccessPath(ByteBuffer _bb)
		{
			return AccessPath.GetRootAsAccessPath(_bb, default(AccessPath));
		}

		// Token: 0x06004729 RID: 18217 RVA: 0x001E8724 File Offset: 0x001E6924
		public static AccessPath GetRootAsAccessPath(ByteBuffer _bb, AccessPath obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600472A RID: 18218 RVA: 0x001E8741 File Offset: 0x001E6941
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600472B RID: 18219 RVA: 0x001E8750 File Offset: 0x001E6950
		public AccessPath __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x0600472C RID: 18220 RVA: 0x001E8760 File Offset: 0x001E6960
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
		// (get) Token: 0x0600472D RID: 18221 RVA: 0x001E879C File Offset: 0x001E699C
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
		// (get) Token: 0x0600472E RID: 18222 RVA: 0x001E87D8 File Offset: 0x001E69D8
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
		// (get) Token: 0x0600472F RID: 18223 RVA: 0x001E8814 File Offset: 0x001E6A14
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

		// Token: 0x06004730 RID: 18224 RVA: 0x001E884C File Offset: 0x001E6A4C
		public Span<byte> GetVal1Bytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06004731 RID: 18225 RVA: 0x001E885C File Offset: 0x001E6A5C
		public byte[] GetVal1Array()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x06004732 RID: 18226 RVA: 0x001E8874 File Offset: 0x001E6A74
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

		// Token: 0x06004733 RID: 18227 RVA: 0x001E88AC File Offset: 0x001E6AAC
		public Span<byte> GetVal2Bytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06004734 RID: 18228 RVA: 0x001E88BC File Offset: 0x001E6ABC
		public byte[] GetVal2Array()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x06004735 RID: 18229 RVA: 0x001E88D4 File Offset: 0x001E6AD4
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

		// Token: 0x06004736 RID: 18230 RVA: 0x001E890C File Offset: 0x001E6B0C
		public Span<byte> GetVal3Bytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06004737 RID: 18231 RVA: 0x001E891C File Offset: 0x001E6B1C
		public byte[] GetVal3Array()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x06004738 RID: 18232 RVA: 0x001E8934 File Offset: 0x001E6B34
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
		// (get) Token: 0x06004739 RID: 18233 RVA: 0x001E8998 File Offset: 0x001E6B98
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
		// (get) Token: 0x0600473A RID: 18234 RVA: 0x001E89C4 File Offset: 0x001E6BC4
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
		// (get) Token: 0x0600473B RID: 18235 RVA: 0x001E8A04 File Offset: 0x001E6C04
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

		// Token: 0x0600473C RID: 18236 RVA: 0x001E8A3C File Offset: 0x001E6C3C
		public Span<byte> GetDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600473D RID: 18237 RVA: 0x001E8A4C File Offset: 0x001E6C4C
		public byte[] GetDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x0600473E RID: 18238 RVA: 0x001E8A64 File Offset: 0x001E6C64
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
		// (get) Token: 0x0600473F RID: 18239 RVA: 0x001E8AA4 File Offset: 0x001E6CA4
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

		// Token: 0x06004740 RID: 18240 RVA: 0x001E8AD0 File Offset: 0x001E6CD0
		public Span<int> GetClientConditionBytes()
		{
			return this.__p.__vector_as_span<int>(22, 4);
		}

		// Token: 0x06004741 RID: 18241 RVA: 0x001E8AE0 File Offset: 0x001E6CE0
		public int[] GetClientConditionArray()
		{
			return this.__p.__vector_as_array<int>(22) ?? Array.Empty<int>();
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x06004742 RID: 18242 RVA: 0x001E8AF8 File Offset: 0x001E6CF8
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

		// Token: 0x06004743 RID: 18243 RVA: 0x001E8B30 File Offset: 0x001E6D30
		public Span<byte> GetPathValueBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x06004744 RID: 18244 RVA: 0x001E8B40 File Offset: 0x001E6D40
		public byte[] GetPathValueArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x06004745 RID: 18245 RVA: 0x001E8B58 File Offset: 0x001E6D58
		[NullableContext(1)]
		public int[] ClientCondition()
		{
			return this.GetClientConditionArray();
		}

		// Token: 0x06004746 RID: 18246 RVA: 0x001E8B60 File Offset: 0x001E6D60
		[NullableContext(1)]
		public IEnumerable<int> ClientConditionIter()
		{
			AccessPath.<ClientConditionIter>d__45 <ClientConditionIter>d__ = new AccessPath.<ClientConditionIter>d__45(-2);
			<ClientConditionIter>d__.<>3__<>4__this = this;
			return <ClientConditionIter>d__;
		}

		// Token: 0x06004747 RID: 18247 RVA: 0x001E8B78 File Offset: 0x001E6D78
		[NullableContext(1)]
		public Dictionary<int, string> FunctionOpenCheckMap()
		{
			return this.FunctionOpenCheckMapIter().ToDictionary((DicIntString element) => element.Key, (DicIntString element) => element.Value);
		}

		// Token: 0x06004748 RID: 18248 RVA: 0x001E8BCE File Offset: 0x001E6DCE
		[NullableContext(1)]
		public IEnumerable<DicIntString> FunctionOpenCheckMapIter()
		{
			AccessPath.<FunctionOpenCheckMapIter>d__47 <FunctionOpenCheckMapIter>d__ = new AccessPath.<FunctionOpenCheckMapIter>d__47(-2);
			<FunctionOpenCheckMapIter>d__.<>3__<>4__this = this;
			return <FunctionOpenCheckMapIter>d__;
		}

		// Token: 0x06004749 RID: 18249 RVA: 0x001E8BE4 File Offset: 0x001E6DE4
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

		// Token: 0x0600474A RID: 18250 RVA: 0x001E8C0C File Offset: 0x001E6E0C
		private void EnsureFunctionOpenCheckMapCacheIfNeeded()
		{
			if (this.FunctionOpenCheckMapCache != null)
			{
				return;
			}
			this.FunctionOpenCheckMapCache = this.FunctionOpenCheckMapIter().ToFrozenDictionary((DicIntString kvp) => kvp.Key, (DicIntString kvp) => kvp.Value, null);
		}

		// Token: 0x0600474B RID: 18251 RVA: 0x001E8C72 File Offset: 0x001E6E72
		[NullableContext(1)]
		public FrozenDictionary<int, string> GetFunctionOpenCheckMapFrozenDict()
		{
			this.EnsureFunctionOpenCheckMapCacheIfNeeded();
			return this.FunctionOpenCheckMapCache;
		}

		// Token: 0x04005067 RID: 20583
		private Table __p;

		// Token: 0x04005068 RID: 20584
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<int, string> FunctionOpenCheckMapCache;
	}
}

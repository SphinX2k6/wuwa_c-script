using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EC3 RID: 3779
	public struct PhantomBattleCardFilter : IFlatbufferObject
	{
		// Token: 0x170025AF RID: 9647
		// (get) Token: 0x0600A5A5 RID: 42405 RVA: 0x002AC968 File Offset: 0x002AAB68
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A5A6 RID: 42406 RVA: 0x002AC975 File Offset: 0x002AAB75
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A5A7 RID: 42407 RVA: 0x002AC97C File Offset: 0x002AAB7C
		public static PhantomBattleCardFilter GetRootAsPhantomBattleCardFilter(ByteBuffer _bb)
		{
			return PhantomBattleCardFilter.GetRootAsPhantomBattleCardFilter(_bb, default(PhantomBattleCardFilter));
		}

		// Token: 0x0600A5A8 RID: 42408 RVA: 0x002AC998 File Offset: 0x002AAB98
		public static PhantomBattleCardFilter GetRootAsPhantomBattleCardFilter(ByteBuffer _bb, PhantomBattleCardFilter obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A5A9 RID: 42409 RVA: 0x002AC9B5 File Offset: 0x002AABB5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A5AA RID: 42410 RVA: 0x002AC9C4 File Offset: 0x002AABC4
		public PhantomBattleCardFilter __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170025B0 RID: 9648
		// (get) Token: 0x0600A5AB RID: 42411 RVA: 0x002AC9D4 File Offset: 0x002AABD4
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

		// Token: 0x170025B1 RID: 9649
		// (get) Token: 0x0600A5AC RID: 42412 RVA: 0x002ACA10 File Offset: 0x002AAC10
		public string Name
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

		// Token: 0x0600A5AD RID: 42413 RVA: 0x002ACA47 File Offset: 0x002AAC47
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600A5AE RID: 42414 RVA: 0x002ACA56 File Offset: 0x002AAC56
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x0600A5AF RID: 42415 RVA: 0x002ACA70 File Offset: 0x002AAC70
		public int CostList(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170025B2 RID: 9650
		// (get) Token: 0x0600A5B0 RID: 42416 RVA: 0x002ACAB0 File Offset: 0x002AACB0
		public int CostListLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600A5B1 RID: 42417 RVA: 0x002ACADB File Offset: 0x002AACDB
		public Span<int> GetCostListBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600A5B2 RID: 42418 RVA: 0x002ACAEA File Offset: 0x002AACEA
		public int[] GetCostListArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x0600A5B3 RID: 42419 RVA: 0x002ACB04 File Offset: 0x002AAD04
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用CostListIter()或GetCostListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] CostList()
		{
			PhantomBattleCardFilter phantomBattleCardFilter = this;
			return phantomBattleCardFilter.GetCostListArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600A5B4 RID: 42420 RVA: 0x002ACB28 File Offset: 0x002AAD28
		[NullableContext(1)]
		public readonly IEnumerable<int> CostListIter()
		{
			PhantomBattleCardFilter.<CostListIter>d__20 <CostListIter>d__ = new PhantomBattleCardFilter.<CostListIter>d__20(-2);
			<CostListIter>d__.<>3__<>4__this = this;
			return <CostListIter>d__;
		}

		// Token: 0x04004F7F RID: 20351
		private Table __p;
	}
}

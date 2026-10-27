using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C03 RID: 3075
	public struct DrinksFlavorRange : IFlatbufferObject
	{
		// Token: 0x17000D3D RID: 3389
		// (get) Token: 0x060063FC RID: 25596 RVA: 0x00217761 File Offset: 0x00215961
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060063FD RID: 25597 RVA: 0x0021776E File Offset: 0x0021596E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060063FE RID: 25598 RVA: 0x00217778 File Offset: 0x00215978
		public static DrinksFlavorRange GetRootAsDrinksFlavorRange(ByteBuffer _bb)
		{
			return DrinksFlavorRange.GetRootAsDrinksFlavorRange(_bb, default(DrinksFlavorRange));
		}

		// Token: 0x060063FF RID: 25599 RVA: 0x00217794 File Offset: 0x00215994
		public static DrinksFlavorRange GetRootAsDrinksFlavorRange(ByteBuffer _bb, DrinksFlavorRange obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006400 RID: 25600 RVA: 0x002177B1 File Offset: 0x002159B1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006401 RID: 25601 RVA: 0x002177C0 File Offset: 0x002159C0
		public DrinksFlavorRange __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000D3E RID: 3390
		// (get) Token: 0x06006402 RID: 25602 RVA: 0x002177D0 File Offset: 0x002159D0
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

		// Token: 0x17000D3F RID: 3391
		// (get) Token: 0x06006403 RID: 25603 RVA: 0x0021780C File Offset: 0x00215A0C
		public int FlavorGroupId
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

		// Token: 0x17000D40 RID: 3392
		// (get) Token: 0x06006404 RID: 25604 RVA: 0x00217848 File Offset: 0x00215A48
		public int FlavorTypeRef
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006405 RID: 25605 RVA: 0x00217884 File Offset: 0x00215A84
		public int FlavorValues(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000D41 RID: 3393
		// (get) Token: 0x06006406 RID: 25606 RVA: 0x002178C4 File Offset: 0x00215AC4
		public int FlavorValuesLength
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

		// Token: 0x06006407 RID: 25607 RVA: 0x002178F0 File Offset: 0x00215AF0
		public Span<int> GetFlavorValuesBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x06006408 RID: 25608 RVA: 0x00217900 File Offset: 0x00215B00
		public int[] GetFlavorValuesArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x06006409 RID: 25609 RVA: 0x00217918 File Offset: 0x00215B18
		public int FlavorLikeValue(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000D42 RID: 3394
		// (get) Token: 0x0600640A RID: 25610 RVA: 0x00217958 File Offset: 0x00215B58
		public int FlavorLikeValueLength
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

		// Token: 0x0600640B RID: 25611 RVA: 0x00217984 File Offset: 0x00215B84
		public Span<int> GetFlavorLikeValueBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x0600640C RID: 25612 RVA: 0x00217994 File Offset: 0x00215B94
		public int[] GetFlavorLikeValueArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x17000D43 RID: 3395
		// (get) Token: 0x0600640D RID: 25613 RVA: 0x002179AC File Offset: 0x00215BAC
		public string Desc
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

		// Token: 0x0600640E RID: 25614 RVA: 0x002179E4 File Offset: 0x00215BE4
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600640F RID: 25615 RVA: 0x002179F4 File Offset: 0x00215BF4
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x06006410 RID: 25616 RVA: 0x00217A0C File Offset: 0x00215C0C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用FlavorLikeValueIter()或GetFlavorLikeValueBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] FlavorLikeValue()
		{
			DrinksFlavorRange drinksFlavorRange = this;
			return drinksFlavorRange.GetFlavorLikeValueArray() ?? Array.Empty<int>();
		}

		// Token: 0x06006411 RID: 25617 RVA: 0x00217A30 File Offset: 0x00215C30
		[NullableContext(1)]
		public readonly IEnumerable<int> FlavorLikeValueIter()
		{
			DrinksFlavorRange.<FlavorLikeValueIter>d__29 <FlavorLikeValueIter>d__ = new DrinksFlavorRange.<FlavorLikeValueIter>d__29(-2);
			<FlavorLikeValueIter>d__.<>3__<>4__this = this;
			return <FlavorLikeValueIter>d__;
		}

		// Token: 0x06006412 RID: 25618 RVA: 0x00217A48 File Offset: 0x00215C48
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用FlavorValuesIter()或GetFlavorValuesBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] FlavorValues()
		{
			DrinksFlavorRange drinksFlavorRange = this;
			return drinksFlavorRange.GetFlavorValuesArray() ?? Array.Empty<int>();
		}

		// Token: 0x06006413 RID: 25619 RVA: 0x00217A6C File Offset: 0x00215C6C
		[NullableContext(1)]
		public readonly IEnumerable<int> FlavorValuesIter()
		{
			DrinksFlavorRange.<FlavorValuesIter>d__31 <FlavorValuesIter>d__ = new DrinksFlavorRange.<FlavorValuesIter>d__31(-2);
			<FlavorValuesIter>d__.<>3__<>4__this = this;
			return <FlavorValuesIter>d__;
		}

		// Token: 0x04004C39 RID: 19513
		private Table __p;
	}
}

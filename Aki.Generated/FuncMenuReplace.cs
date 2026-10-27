using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CD0 RID: 3280
	public struct FuncMenuReplace : IFlatbufferObject
	{
		// Token: 0x17001432 RID: 5170
		// (get) Token: 0x060076E8 RID: 30440 RVA: 0x00243525 File Offset: 0x00241725
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060076E9 RID: 30441 RVA: 0x00243532 File Offset: 0x00241732
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060076EA RID: 30442 RVA: 0x0024353C File Offset: 0x0024173C
		public static FuncMenuReplace GetRootAsFuncMenuReplace(ByteBuffer _bb)
		{
			return FuncMenuReplace.GetRootAsFuncMenuReplace(_bb, default(FuncMenuReplace));
		}

		// Token: 0x060076EB RID: 30443 RVA: 0x00243558 File Offset: 0x00241758
		public static FuncMenuReplace GetRootAsFuncMenuReplace(ByteBuffer _bb, FuncMenuReplace obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060076EC RID: 30444 RVA: 0x00243575 File Offset: 0x00241775
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060076ED RID: 30445 RVA: 0x00243584 File Offset: 0x00241784
		public FuncMenuReplace __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001433 RID: 5171
		// (get) Token: 0x060076EE RID: 30446 RVA: 0x00243594 File Offset: 0x00241794
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

		// Token: 0x17001434 RID: 5172
		// (get) Token: 0x060076EF RID: 30447 RVA: 0x002435D0 File Offset: 0x002417D0
		public int InstSubType
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

		// Token: 0x060076F0 RID: 30448 RVA: 0x0024360C File Offset: 0x0024180C
		public int InstIdList(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001435 RID: 5173
		// (get) Token: 0x060076F1 RID: 30449 RVA: 0x0024364C File Offset: 0x0024184C
		public int InstIdListLength
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

		// Token: 0x060076F2 RID: 30450 RVA: 0x00243677 File Offset: 0x00241877
		public Span<int> GetInstIdListBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x060076F3 RID: 30451 RVA: 0x00243686 File Offset: 0x00241886
		public int[] GetInstIdListArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x060076F4 RID: 30452 RVA: 0x002436A0 File Offset: 0x002418A0
		public int FuncMenuIdList(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001436 RID: 5174
		// (get) Token: 0x060076F5 RID: 30453 RVA: 0x002436E0 File Offset: 0x002418E0
		public int FuncMenuIdListLength
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

		// Token: 0x060076F6 RID: 30454 RVA: 0x0024370C File Offset: 0x0024190C
		public Span<int> GetFuncMenuIdListBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x060076F7 RID: 30455 RVA: 0x0024371C File Offset: 0x0024191C
		public int[] GetFuncMenuIdListArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x060076F8 RID: 30456 RVA: 0x00243734 File Offset: 0x00241934
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用FuncMenuIdListIter()或GetFuncMenuIdListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] FuncMenuIdList()
		{
			FuncMenuReplace funcMenuReplace = this;
			return funcMenuReplace.GetFuncMenuIdListArray() ?? Array.Empty<int>();
		}

		// Token: 0x060076F9 RID: 30457 RVA: 0x00243758 File Offset: 0x00241958
		[NullableContext(1)]
		public readonly IEnumerable<int> FuncMenuIdListIter()
		{
			FuncMenuReplace.<FuncMenuIdListIter>d__23 <FuncMenuIdListIter>d__ = new FuncMenuReplace.<FuncMenuIdListIter>d__23(-2);
			<FuncMenuIdListIter>d__.<>3__<>4__this = this;
			return <FuncMenuIdListIter>d__;
		}

		// Token: 0x060076FA RID: 30458 RVA: 0x00243770 File Offset: 0x00241970
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用InstIdListIter()或GetInstIdListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] InstIdList()
		{
			FuncMenuReplace funcMenuReplace = this;
			return funcMenuReplace.GetInstIdListArray() ?? Array.Empty<int>();
		}

		// Token: 0x060076FB RID: 30459 RVA: 0x00243794 File Offset: 0x00241994
		[NullableContext(1)]
		public readonly IEnumerable<int> InstIdListIter()
		{
			FuncMenuReplace.<InstIdListIter>d__25 <InstIdListIter>d__ = new FuncMenuReplace.<InstIdListIter>d__25(-2);
			<InstIdListIter>d__.<>3__<>4__this = this;
			return <InstIdListIter>d__;
		}

		// Token: 0x04004D40 RID: 19776
		private Table __p;
	}
}

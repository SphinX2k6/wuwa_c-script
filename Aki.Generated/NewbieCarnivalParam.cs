using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E7C RID: 3708
	public struct NewbieCarnivalParam : IFlatbufferObject
	{
		// Token: 0x170022D1 RID: 8913
		// (get) Token: 0x06009DF6 RID: 40438 RVA: 0x0029B325 File Offset: 0x00299525
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009DF7 RID: 40439 RVA: 0x0029B332 File Offset: 0x00299532
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009DF8 RID: 40440 RVA: 0x0029B33C File Offset: 0x0029953C
		public static NewbieCarnivalParam GetRootAsNewbieCarnivalParam(ByteBuffer _bb)
		{
			return NewbieCarnivalParam.GetRootAsNewbieCarnivalParam(_bb, default(NewbieCarnivalParam));
		}

		// Token: 0x06009DF9 RID: 40441 RVA: 0x0029B358 File Offset: 0x00299558
		public static NewbieCarnivalParam GetRootAsNewbieCarnivalParam(ByteBuffer _bb, NewbieCarnivalParam obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009DFA RID: 40442 RVA: 0x0029B375 File Offset: 0x00299575
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009DFB RID: 40443 RVA: 0x0029B384 File Offset: 0x00299584
		public NewbieCarnivalParam __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170022D2 RID: 8914
		// (get) Token: 0x06009DFC RID: 40444 RVA: 0x0029B394 File Offset: 0x00299594
		public int ActivityId
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

		// Token: 0x06009DFD RID: 40445 RVA: 0x0029B3D0 File Offset: 0x002995D0
		public int Roles(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170022D3 RID: 8915
		// (get) Token: 0x06009DFE RID: 40446 RVA: 0x0029B410 File Offset: 0x00299610
		public int RolesLength
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

		// Token: 0x06009DFF RID: 40447 RVA: 0x0029B43B File Offset: 0x0029963B
		public Span<int> GetRolesBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06009E00 RID: 40448 RVA: 0x0029B44A File Offset: 0x0029964A
		public int[] GetRolesArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x06009E01 RID: 40449 RVA: 0x0029B464 File Offset: 0x00299664
		public int PayGifts(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170022D4 RID: 8916
		// (get) Token: 0x06009E02 RID: 40450 RVA: 0x0029B4A4 File Offset: 0x002996A4
		public int PayGiftsLength
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

		// Token: 0x06009E03 RID: 40451 RVA: 0x0029B4CF File Offset: 0x002996CF
		public Span<int> GetPayGiftsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06009E04 RID: 40452 RVA: 0x0029B4DE File Offset: 0x002996DE
		public int[] GetPayGiftsArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x06009E05 RID: 40453 RVA: 0x0029B4F8 File Offset: 0x002996F8
		public int GachaIds(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170022D5 RID: 8917
		// (get) Token: 0x06009E06 RID: 40454 RVA: 0x0029B538 File Offset: 0x00299738
		public int GachaIdsLength
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

		// Token: 0x06009E07 RID: 40455 RVA: 0x0029B564 File Offset: 0x00299764
		public Span<int> GetGachaIdsBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x06009E08 RID: 40456 RVA: 0x0029B574 File Offset: 0x00299774
		public int[] GetGachaIdsArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x170022D6 RID: 8918
		// (get) Token: 0x06009E09 RID: 40457 RVA: 0x0029B58C File Offset: 0x0029978C
		public int RoleTask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170022D7 RID: 8919
		// (get) Token: 0x06009E0A RID: 40458 RVA: 0x0029B5CC File Offset: 0x002997CC
		public int AllCount
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170022D8 RID: 8920
		// (get) Token: 0x06009E0B RID: 40459 RVA: 0x0029B60C File Offset: 0x0029980C
		public int ItemId
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009E0C RID: 40460 RVA: 0x0029B64C File Offset: 0x0029984C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用GachaIdsIter()或GetGachaIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] GachaIds()
		{
			NewbieCarnivalParam newbieCarnivalParam = this;
			return newbieCarnivalParam.GetGachaIdsArray() ?? Array.Empty<int>();
		}

		// Token: 0x06009E0D RID: 40461 RVA: 0x0029B670 File Offset: 0x00299870
		[NullableContext(1)]
		public readonly IEnumerable<int> GachaIdsIter()
		{
			NewbieCarnivalParam.<GachaIdsIter>d__32 <GachaIdsIter>d__ = new NewbieCarnivalParam.<GachaIdsIter>d__32(-2);
			<GachaIdsIter>d__.<>3__<>4__this = this;
			return <GachaIdsIter>d__;
		}

		// Token: 0x06009E0E RID: 40462 RVA: 0x0029B688 File Offset: 0x00299888
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用PayGiftsIter()或GetPayGiftsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] PayGifts()
		{
			NewbieCarnivalParam newbieCarnivalParam = this;
			return newbieCarnivalParam.GetPayGiftsArray() ?? Array.Empty<int>();
		}

		// Token: 0x06009E0F RID: 40463 RVA: 0x0029B6AC File Offset: 0x002998AC
		[NullableContext(1)]
		public readonly IEnumerable<int> PayGiftsIter()
		{
			NewbieCarnivalParam.<PayGiftsIter>d__34 <PayGiftsIter>d__ = new NewbieCarnivalParam.<PayGiftsIter>d__34(-2);
			<PayGiftsIter>d__.<>3__<>4__this = this;
			return <PayGiftsIter>d__;
		}

		// Token: 0x06009E10 RID: 40464 RVA: 0x0029B6C4 File Offset: 0x002998C4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RolesIter()或GetRolesBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Roles()
		{
			NewbieCarnivalParam newbieCarnivalParam = this;
			return newbieCarnivalParam.GetRolesArray() ?? Array.Empty<int>();
		}

		// Token: 0x06009E11 RID: 40465 RVA: 0x0029B6E8 File Offset: 0x002998E8
		[NullableContext(1)]
		public readonly IEnumerable<int> RolesIter()
		{
			NewbieCarnivalParam.<RolesIter>d__36 <RolesIter>d__ = new NewbieCarnivalParam.<RolesIter>d__36(-2);
			<RolesIter>d__.<>3__<>4__this = this;
			return <RolesIter>d__;
		}

		// Token: 0x04004F2A RID: 20266
		private Table __p;
	}
}

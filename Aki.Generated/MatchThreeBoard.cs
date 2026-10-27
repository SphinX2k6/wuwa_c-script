using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DF8 RID: 3576
	public struct MatchThreeBoard : IFlatbufferObject
	{
		// Token: 0x17001E64 RID: 7780
		// (get) Token: 0x0600921C RID: 37404 RVA: 0x00280EED File Offset: 0x0027F0ED
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600921D RID: 37405 RVA: 0x00280EFA File Offset: 0x0027F0FA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600921E RID: 37406 RVA: 0x00280F04 File Offset: 0x0027F104
		public static MatchThreeBoard GetRootAsMatchThreeBoard(ByteBuffer _bb)
		{
			return MatchThreeBoard.GetRootAsMatchThreeBoard(_bb, default(MatchThreeBoard));
		}

		// Token: 0x0600921F RID: 37407 RVA: 0x00280F20 File Offset: 0x0027F120
		public static MatchThreeBoard GetRootAsMatchThreeBoard(ByteBuffer _bb, MatchThreeBoard obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009220 RID: 37408 RVA: 0x00280F3D File Offset: 0x0027F13D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009221 RID: 37409 RVA: 0x00280F4C File Offset: 0x0027F14C
		public MatchThreeBoard __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001E65 RID: 7781
		// (get) Token: 0x06009222 RID: 37410 RVA: 0x00280F5C File Offset: 0x0027F15C
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

		// Token: 0x17001E66 RID: 7782
		// (get) Token: 0x06009223 RID: 37411 RVA: 0x00280F98 File Offset: 0x0027F198
		public int BoardId
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

		// Token: 0x06009224 RID: 37412 RVA: 0x00280FD4 File Offset: 0x0027F1D4
		public int Column1(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001E67 RID: 7783
		// (get) Token: 0x06009225 RID: 37413 RVA: 0x00281014 File Offset: 0x0027F214
		public int Column1Length
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

		// Token: 0x06009226 RID: 37414 RVA: 0x0028103F File Offset: 0x0027F23F
		public Span<int> GetColumn1Bytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06009227 RID: 37415 RVA: 0x0028104E File Offset: 0x0027F24E
		public int[] GetColumn1Array()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x06009228 RID: 37416 RVA: 0x00281068 File Offset: 0x0027F268
		public int Column2(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001E68 RID: 7784
		// (get) Token: 0x06009229 RID: 37417 RVA: 0x002810A8 File Offset: 0x0027F2A8
		public int Column2Length
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

		// Token: 0x0600922A RID: 37418 RVA: 0x002810D4 File Offset: 0x0027F2D4
		public Span<int> GetColumn2Bytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600922B RID: 37419 RVA: 0x002810E4 File Offset: 0x0027F2E4
		public int[] GetColumn2Array()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x0600922C RID: 37420 RVA: 0x002810FC File Offset: 0x0027F2FC
		public int Column3(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001E69 RID: 7785
		// (get) Token: 0x0600922D RID: 37421 RVA: 0x0028113C File Offset: 0x0027F33C
		public int Column3Length
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

		// Token: 0x0600922E RID: 37422 RVA: 0x00281168 File Offset: 0x0027F368
		public Span<int> GetColumn3Bytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x0600922F RID: 37423 RVA: 0x00281178 File Offset: 0x0027F378
		public int[] GetColumn3Array()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x06009230 RID: 37424 RVA: 0x00281190 File Offset: 0x0027F390
		public int Column4(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001E6A RID: 7786
		// (get) Token: 0x06009231 RID: 37425 RVA: 0x002811D0 File Offset: 0x0027F3D0
		public int Column4Length
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06009232 RID: 37426 RVA: 0x002811FC File Offset: 0x0027F3FC
		public Span<int> GetColumn4Bytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x06009233 RID: 37427 RVA: 0x0028120C File Offset: 0x0027F40C
		public int[] GetColumn4Array()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x06009234 RID: 37428 RVA: 0x00281224 File Offset: 0x0027F424
		public int Column5(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001E6B RID: 7787
		// (get) Token: 0x06009235 RID: 37429 RVA: 0x00281264 File Offset: 0x0027F464
		public int Column5Length
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

		// Token: 0x06009236 RID: 37430 RVA: 0x00281290 File Offset: 0x0027F490
		public Span<int> GetColumn5Bytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x06009237 RID: 37431 RVA: 0x002812A0 File Offset: 0x0027F4A0
		public int[] GetColumn5Array()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x06009238 RID: 37432 RVA: 0x002812B8 File Offset: 0x0027F4B8
		public int Column6(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001E6C RID: 7788
		// (get) Token: 0x06009239 RID: 37433 RVA: 0x002812F8 File Offset: 0x0027F4F8
		public int Column6Length
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600923A RID: 37434 RVA: 0x00281324 File Offset: 0x0027F524
		public Span<int> GetColumn6Bytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x0600923B RID: 37435 RVA: 0x00281334 File Offset: 0x0027F534
		public int[] GetColumn6Array()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x0600923C RID: 37436 RVA: 0x0028134C File Offset: 0x0027F54C
		public int Column7(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001E6D RID: 7789
		// (get) Token: 0x0600923D RID: 37437 RVA: 0x0028138C File Offset: 0x0027F58C
		public int Column7Length
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600923E RID: 37438 RVA: 0x002813B8 File Offset: 0x0027F5B8
		public Span<int> GetColumn7Bytes()
		{
			return this.__p.__vector_as_span<int>(20, 4);
		}

		// Token: 0x0600923F RID: 37439 RVA: 0x002813C8 File Offset: 0x0027F5C8
		public int[] GetColumn7Array()
		{
			return this.__p.__vector_as_array<int>(20) ?? Array.Empty<int>();
		}

		// Token: 0x06009240 RID: 37440 RVA: 0x002813E0 File Offset: 0x0027F5E0
		public int Column8(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001E6E RID: 7790
		// (get) Token: 0x06009241 RID: 37441 RVA: 0x00281420 File Offset: 0x0027F620
		public int Column8Length
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

		// Token: 0x06009242 RID: 37442 RVA: 0x0028144C File Offset: 0x0027F64C
		public Span<int> GetColumn8Bytes()
		{
			return this.__p.__vector_as_span<int>(22, 4);
		}

		// Token: 0x06009243 RID: 37443 RVA: 0x0028145C File Offset: 0x0027F65C
		public int[] GetColumn8Array()
		{
			return this.__p.__vector_as_array<int>(22) ?? Array.Empty<int>();
		}

		// Token: 0x06009244 RID: 37444 RVA: 0x00281474 File Offset: 0x0027F674
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用Column1Iter()或GetColumn1Bytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Column1()
		{
			MatchThreeBoard matchThreeBoard = this;
			return matchThreeBoard.GetColumn1Array() ?? Array.Empty<int>();
		}

		// Token: 0x06009245 RID: 37445 RVA: 0x00281498 File Offset: 0x0027F698
		[NullableContext(1)]
		public readonly IEnumerable<int> Column1Iter()
		{
			MatchThreeBoard.<Column1Iter>d__53 <Column1Iter>d__ = new MatchThreeBoard.<Column1Iter>d__53(-2);
			<Column1Iter>d__.<>3__<>4__this = this;
			return <Column1Iter>d__;
		}

		// Token: 0x06009246 RID: 37446 RVA: 0x002814B0 File Offset: 0x0027F6B0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用Column2Iter()或GetColumn2Bytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Column2()
		{
			MatchThreeBoard matchThreeBoard = this;
			return matchThreeBoard.GetColumn2Array() ?? Array.Empty<int>();
		}

		// Token: 0x06009247 RID: 37447 RVA: 0x002814D4 File Offset: 0x0027F6D4
		[NullableContext(1)]
		public readonly IEnumerable<int> Column2Iter()
		{
			MatchThreeBoard.<Column2Iter>d__55 <Column2Iter>d__ = new MatchThreeBoard.<Column2Iter>d__55(-2);
			<Column2Iter>d__.<>3__<>4__this = this;
			return <Column2Iter>d__;
		}

		// Token: 0x06009248 RID: 37448 RVA: 0x002814EC File Offset: 0x0027F6EC
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用Column3Iter()或GetColumn3Bytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Column3()
		{
			MatchThreeBoard matchThreeBoard = this;
			return matchThreeBoard.GetColumn3Array() ?? Array.Empty<int>();
		}

		// Token: 0x06009249 RID: 37449 RVA: 0x00281510 File Offset: 0x0027F710
		[NullableContext(1)]
		public readonly IEnumerable<int> Column3Iter()
		{
			MatchThreeBoard.<Column3Iter>d__57 <Column3Iter>d__ = new MatchThreeBoard.<Column3Iter>d__57(-2);
			<Column3Iter>d__.<>3__<>4__this = this;
			return <Column3Iter>d__;
		}

		// Token: 0x0600924A RID: 37450 RVA: 0x00281528 File Offset: 0x0027F728
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用Column4Iter()或GetColumn4Bytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Column4()
		{
			MatchThreeBoard matchThreeBoard = this;
			return matchThreeBoard.GetColumn4Array() ?? Array.Empty<int>();
		}

		// Token: 0x0600924B RID: 37451 RVA: 0x0028154C File Offset: 0x0027F74C
		[NullableContext(1)]
		public readonly IEnumerable<int> Column4Iter()
		{
			MatchThreeBoard.<Column4Iter>d__59 <Column4Iter>d__ = new MatchThreeBoard.<Column4Iter>d__59(-2);
			<Column4Iter>d__.<>3__<>4__this = this;
			return <Column4Iter>d__;
		}

		// Token: 0x0600924C RID: 37452 RVA: 0x00281564 File Offset: 0x0027F764
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用Column5Iter()或GetColumn5Bytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Column5()
		{
			MatchThreeBoard matchThreeBoard = this;
			return matchThreeBoard.GetColumn5Array() ?? Array.Empty<int>();
		}

		// Token: 0x0600924D RID: 37453 RVA: 0x00281588 File Offset: 0x0027F788
		[NullableContext(1)]
		public readonly IEnumerable<int> Column5Iter()
		{
			MatchThreeBoard.<Column5Iter>d__61 <Column5Iter>d__ = new MatchThreeBoard.<Column5Iter>d__61(-2);
			<Column5Iter>d__.<>3__<>4__this = this;
			return <Column5Iter>d__;
		}

		// Token: 0x0600924E RID: 37454 RVA: 0x002815A0 File Offset: 0x0027F7A0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用Column6Iter()或GetColumn6Bytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Column6()
		{
			MatchThreeBoard matchThreeBoard = this;
			return matchThreeBoard.GetColumn6Array() ?? Array.Empty<int>();
		}

		// Token: 0x0600924F RID: 37455 RVA: 0x002815C4 File Offset: 0x0027F7C4
		[NullableContext(1)]
		public readonly IEnumerable<int> Column6Iter()
		{
			MatchThreeBoard.<Column6Iter>d__63 <Column6Iter>d__ = new MatchThreeBoard.<Column6Iter>d__63(-2);
			<Column6Iter>d__.<>3__<>4__this = this;
			return <Column6Iter>d__;
		}

		// Token: 0x06009250 RID: 37456 RVA: 0x002815DC File Offset: 0x0027F7DC
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用Column7Iter()或GetColumn7Bytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Column7()
		{
			MatchThreeBoard matchThreeBoard = this;
			return matchThreeBoard.GetColumn7Array() ?? Array.Empty<int>();
		}

		// Token: 0x06009251 RID: 37457 RVA: 0x00281600 File Offset: 0x0027F800
		[NullableContext(1)]
		public readonly IEnumerable<int> Column7Iter()
		{
			MatchThreeBoard.<Column7Iter>d__65 <Column7Iter>d__ = new MatchThreeBoard.<Column7Iter>d__65(-2);
			<Column7Iter>d__.<>3__<>4__this = this;
			return <Column7Iter>d__;
		}

		// Token: 0x06009252 RID: 37458 RVA: 0x00281618 File Offset: 0x0027F818
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用Column8Iter()或GetColumn8Bytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Column8()
		{
			MatchThreeBoard matchThreeBoard = this;
			return matchThreeBoard.GetColumn8Array() ?? Array.Empty<int>();
		}

		// Token: 0x06009253 RID: 37459 RVA: 0x0028163C File Offset: 0x0027F83C
		[NullableContext(1)]
		public readonly IEnumerable<int> Column8Iter()
		{
			MatchThreeBoard.<Column8Iter>d__67 <Column8Iter>d__ = new MatchThreeBoard.<Column8Iter>d__67(-2);
			<Column8Iter>d__.<>3__<>4__this = this;
			return <Column8Iter>d__;
		}

		// Token: 0x04004E98 RID: 20120
		private Table __p;
	}
}

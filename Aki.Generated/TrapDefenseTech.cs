using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001170 RID: 4464
	public struct TrapDefenseTech : IFlatbufferObject
	{
		// Token: 0x17003C86 RID: 15494
		// (get) Token: 0x0600E498 RID: 58520 RVA: 0x0033ACCC File Offset: 0x00338ECC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E499 RID: 58521 RVA: 0x0033ACD9 File Offset: 0x00338ED9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E49A RID: 58522 RVA: 0x0033ACE0 File Offset: 0x00338EE0
		public static TrapDefenseTech GetRootAsTrapDefenseTech(ByteBuffer _bb)
		{
			return TrapDefenseTech.GetRootAsTrapDefenseTech(_bb, default(TrapDefenseTech));
		}

		// Token: 0x0600E49B RID: 58523 RVA: 0x0033ACFC File Offset: 0x00338EFC
		public static TrapDefenseTech GetRootAsTrapDefenseTech(ByteBuffer _bb, TrapDefenseTech obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E49C RID: 58524 RVA: 0x0033AD19 File Offset: 0x00338F19
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E49D RID: 58525 RVA: 0x0033AD28 File Offset: 0x00338F28
		public TrapDefenseTech __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003C87 RID: 15495
		// (get) Token: 0x0600E49E RID: 58526 RVA: 0x0033AD38 File Offset: 0x00338F38
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

		// Token: 0x17003C88 RID: 15496
		// (get) Token: 0x0600E49F RID: 58527 RVA: 0x0033AD74 File Offset: 0x00338F74
		public int ActivityId
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

		// Token: 0x17003C89 RID: 15497
		// (get) Token: 0x0600E4A0 RID: 58528 RVA: 0x0033ADB0 File Offset: 0x00338FB0
		public string Name
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E4A1 RID: 58529 RVA: 0x0033ADE7 File Offset: 0x00338FE7
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600E4A2 RID: 58530 RVA: 0x0033ADF6 File Offset: 0x00338FF6
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17003C8A RID: 15498
		// (get) Token: 0x0600E4A3 RID: 58531 RVA: 0x0033AE10 File Offset: 0x00339010
		public string Desc
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

		// Token: 0x0600E4A4 RID: 58532 RVA: 0x0033AE48 File Offset: 0x00339048
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600E4A5 RID: 58533 RVA: 0x0033AE58 File Offset: 0x00339058
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17003C8B RID: 15499
		// (get) Token: 0x0600E4A6 RID: 58534 RVA: 0x0033AE70 File Offset: 0x00339070
		public int Type
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

		// Token: 0x17003C8C RID: 15500
		// (get) Token: 0x0600E4A7 RID: 58535 RVA: 0x0033AEB0 File Offset: 0x003390B0
		public int FuncType
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

		// Token: 0x0600E4A8 RID: 58536 RVA: 0x0033AEF0 File Offset: 0x003390F0
		public int FuncParams(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003C8D RID: 15501
		// (get) Token: 0x0600E4A9 RID: 58537 RVA: 0x0033AF30 File Offset: 0x00339130
		public int FuncParamsLength
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

		// Token: 0x0600E4AA RID: 58538 RVA: 0x0033AF5C File Offset: 0x0033915C
		public Span<int> GetFuncParamsBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x0600E4AB RID: 58539 RVA: 0x0033AF6C File Offset: 0x0033916C
		public int[] GetFuncParamsArray()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x0600E4AC RID: 58540 RVA: 0x0033AF84 File Offset: 0x00339184
		public int Gainings(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003C8E RID: 15502
		// (get) Token: 0x0600E4AD RID: 58541 RVA: 0x0033AFC4 File Offset: 0x003391C4
		public int GainingsLength
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

		// Token: 0x0600E4AE RID: 58542 RVA: 0x0033AFF0 File Offset: 0x003391F0
		public Span<int> GetGainingsBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x0600E4AF RID: 58543 RVA: 0x0033B000 File Offset: 0x00339200
		public int[] GetGainingsArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x0600E4B0 RID: 58544 RVA: 0x0033B018 File Offset: 0x00339218
		public int PreNode(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003C8F RID: 15503
		// (get) Token: 0x0600E4B1 RID: 58545 RVA: 0x0033B058 File Offset: 0x00339258
		public int PreNodeLength
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

		// Token: 0x0600E4B2 RID: 58546 RVA: 0x0033B084 File Offset: 0x00339284
		public Span<int> GetPreNodeBytes()
		{
			return this.__p.__vector_as_span<int>(20, 4);
		}

		// Token: 0x0600E4B3 RID: 58547 RVA: 0x0033B094 File Offset: 0x00339294
		public int[] GetPreNodeArray()
		{
			return this.__p.__vector_as_array<int>(20) ?? Array.Empty<int>();
		}

		// Token: 0x17003C90 RID: 15504
		// (get) Token: 0x0600E4B4 RID: 58548 RVA: 0x0033B0AC File Offset: 0x003392AC
		public int UnlockCost
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003C91 RID: 15505
		// (get) Token: 0x0600E4B5 RID: 58549 RVA: 0x0033B0EC File Offset: 0x003392EC
		public int Row
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003C92 RID: 15506
		// (get) Token: 0x0600E4B6 RID: 58550 RVA: 0x0033B12C File Offset: 0x0033932C
		public int Col
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003C93 RID: 15507
		// (get) Token: 0x0600E4B7 RID: 58551 RVA: 0x0033B16C File Offset: 0x0033936C
		public string IconPath
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E4B8 RID: 58552 RVA: 0x0033B1A4 File Offset: 0x003393A4
		public Span<byte> GetIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x0600E4B9 RID: 58553 RVA: 0x0033B1B4 File Offset: 0x003393B4
		public byte[] GetIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x17003C94 RID: 15508
		// (get) Token: 0x0600E4BA RID: 58554 RVA: 0x0033B1CC File Offset: 0x003393CC
		public string IconPathBig
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E4BB RID: 58555 RVA: 0x0033B204 File Offset: 0x00339404
		public Span<byte> GetIconPathBigBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x0600E4BC RID: 58556 RVA: 0x0033B214 File Offset: 0x00339414
		public byte[] GetIconPathBigArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x0600E4BD RID: 58557 RVA: 0x0033B22C File Offset: 0x0033942C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用FuncParamsIter()或GetFuncParamsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] FuncParams()
		{
			TrapDefenseTech trapDefenseTech = this;
			return trapDefenseTech.GetFuncParamsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600E4BE RID: 58558 RVA: 0x0033B250 File Offset: 0x00339450
		[NullableContext(1)]
		public readonly IEnumerable<int> FuncParamsIter()
		{
			TrapDefenseTech.<FuncParamsIter>d__54 <FuncParamsIter>d__ = new TrapDefenseTech.<FuncParamsIter>d__54(-2);
			<FuncParamsIter>d__.<>3__<>4__this = this;
			return <FuncParamsIter>d__;
		}

		// Token: 0x0600E4BF RID: 58559 RVA: 0x0033B268 File Offset: 0x00339468
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用GainingsIter()或GetGainingsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Gainings()
		{
			TrapDefenseTech trapDefenseTech = this;
			return trapDefenseTech.GetGainingsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600E4C0 RID: 58560 RVA: 0x0033B28C File Offset: 0x0033948C
		[NullableContext(1)]
		public readonly IEnumerable<int> GainingsIter()
		{
			TrapDefenseTech.<GainingsIter>d__56 <GainingsIter>d__ = new TrapDefenseTech.<GainingsIter>d__56(-2);
			<GainingsIter>d__.<>3__<>4__this = this;
			return <GainingsIter>d__;
		}

		// Token: 0x0600E4C1 RID: 58561 RVA: 0x0033B2A4 File Offset: 0x003394A4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用PreNodeIter()或GetPreNodeBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] PreNode()
		{
			TrapDefenseTech trapDefenseTech = this;
			return trapDefenseTech.GetPreNodeArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600E4C2 RID: 58562 RVA: 0x0033B2C8 File Offset: 0x003394C8
		[NullableContext(1)]
		public readonly IEnumerable<int> PreNodeIter()
		{
			TrapDefenseTech.<PreNodeIter>d__58 <PreNodeIter>d__ = new TrapDefenseTech.<PreNodeIter>d__58(-2);
			<PreNodeIter>d__.<>3__<>4__this = this;
			return <PreNodeIter>d__;
		}

		// Token: 0x040052B6 RID: 21174
		private Table __p;
	}
}

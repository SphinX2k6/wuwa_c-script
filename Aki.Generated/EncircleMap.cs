using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D12 RID: 3346
	public struct EncircleMap : IFlatbufferObject
	{
		// Token: 0x17000F50 RID: 3920
		// (get) Token: 0x06006EDC RID: 28380 RVA: 0x00241DFA File Offset: 0x0023FFFA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006EDD RID: 28381 RVA: 0x00241E07 File Offset: 0x00240007
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006EDE RID: 28382 RVA: 0x00241E10 File Offset: 0x00240010
		public static EncircleMap GetRootAsEncircleMap(ByteBuffer _bb)
		{
			return EncircleMap.GetRootAsEncircleMap(_bb, default(EncircleMap));
		}

		// Token: 0x06006EDF RID: 28383 RVA: 0x00241E2C File Offset: 0x0024002C
		public static EncircleMap GetRootAsEncircleMap(ByteBuffer _bb, EncircleMap obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006EE0 RID: 28384 RVA: 0x00241E49 File Offset: 0x00240049
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006EE1 RID: 28385 RVA: 0x00241E58 File Offset: 0x00240058
		public EncircleMap __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000F51 RID: 3921
		// (get) Token: 0x06006EE2 RID: 28386 RVA: 0x00241E68 File Offset: 0x00240068
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

		// Token: 0x17000F52 RID: 3922
		// (get) Token: 0x06006EE3 RID: 28387 RVA: 0x00241EA4 File Offset: 0x002400A4
		public int MapID
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

		// Token: 0x06006EE4 RID: 28388 RVA: 0x00241EE0 File Offset: 0x002400E0
		public int Column1(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000F53 RID: 3923
		// (get) Token: 0x06006EE5 RID: 28389 RVA: 0x00241F20 File Offset: 0x00240120
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

		// Token: 0x06006EE6 RID: 28390 RVA: 0x00241F4B File Offset: 0x0024014B
		public Span<int> GetColumn1Bytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06006EE7 RID: 28391 RVA: 0x00241F5A File Offset: 0x0024015A
		public int[] GetColumn1Array()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x06006EE8 RID: 28392 RVA: 0x00241F74 File Offset: 0x00240174
		public int Column2(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000F54 RID: 3924
		// (get) Token: 0x06006EE9 RID: 28393 RVA: 0x00241FB4 File Offset: 0x002401B4
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

		// Token: 0x06006EEA RID: 28394 RVA: 0x00241FE0 File Offset: 0x002401E0
		public Span<int> GetColumn2Bytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x06006EEB RID: 28395 RVA: 0x00241FF0 File Offset: 0x002401F0
		public int[] GetColumn2Array()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x06006EEC RID: 28396 RVA: 0x00242008 File Offset: 0x00240208
		public int Column3(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000F55 RID: 3925
		// (get) Token: 0x06006EED RID: 28397 RVA: 0x00242048 File Offset: 0x00240248
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

		// Token: 0x06006EEE RID: 28398 RVA: 0x00242074 File Offset: 0x00240274
		public Span<int> GetColumn3Bytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x06006EEF RID: 28399 RVA: 0x00242084 File Offset: 0x00240284
		public int[] GetColumn3Array()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x06006EF0 RID: 28400 RVA: 0x0024209C File Offset: 0x0024029C
		public int Column4(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000F56 RID: 3926
		// (get) Token: 0x06006EF1 RID: 28401 RVA: 0x002420DC File Offset: 0x002402DC
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

		// Token: 0x06006EF2 RID: 28402 RVA: 0x00242108 File Offset: 0x00240308
		public Span<int> GetColumn4Bytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x06006EF3 RID: 28403 RVA: 0x00242118 File Offset: 0x00240318
		public int[] GetColumn4Array()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x06006EF4 RID: 28404 RVA: 0x00242130 File Offset: 0x00240330
		public int Column5(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000F57 RID: 3927
		// (get) Token: 0x06006EF5 RID: 28405 RVA: 0x00242170 File Offset: 0x00240370
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

		// Token: 0x06006EF6 RID: 28406 RVA: 0x0024219C File Offset: 0x0024039C
		public Span<int> GetColumn5Bytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x06006EF7 RID: 28407 RVA: 0x002421AC File Offset: 0x002403AC
		public int[] GetColumn5Array()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x06006EF8 RID: 28408 RVA: 0x002421C4 File Offset: 0x002403C4
		public int Column6(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000F58 RID: 3928
		// (get) Token: 0x06006EF9 RID: 28409 RVA: 0x00242204 File Offset: 0x00240404
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

		// Token: 0x06006EFA RID: 28410 RVA: 0x00242230 File Offset: 0x00240430
		public Span<int> GetColumn6Bytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x06006EFB RID: 28411 RVA: 0x00242240 File Offset: 0x00240440
		public int[] GetColumn6Array()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x06006EFC RID: 28412 RVA: 0x00242258 File Offset: 0x00240458
		public int Column7(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000F59 RID: 3929
		// (get) Token: 0x06006EFD RID: 28413 RVA: 0x00242298 File Offset: 0x00240498
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

		// Token: 0x06006EFE RID: 28414 RVA: 0x002422C4 File Offset: 0x002404C4
		public Span<int> GetColumn7Bytes()
		{
			return this.__p.__vector_as_span<int>(20, 4);
		}

		// Token: 0x06006EFF RID: 28415 RVA: 0x002422D4 File Offset: 0x002404D4
		public int[] GetColumn7Array()
		{
			return this.__p.__vector_as_array<int>(20) ?? Array.Empty<int>();
		}

		// Token: 0x06006F00 RID: 28416 RVA: 0x002422EC File Offset: 0x002404EC
		public int Column8(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000F5A RID: 3930
		// (get) Token: 0x06006F01 RID: 28417 RVA: 0x0024232C File Offset: 0x0024052C
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

		// Token: 0x06006F02 RID: 28418 RVA: 0x00242358 File Offset: 0x00240558
		public Span<int> GetColumn8Bytes()
		{
			return this.__p.__vector_as_span<int>(22, 4);
		}

		// Token: 0x06006F03 RID: 28419 RVA: 0x00242368 File Offset: 0x00240568
		public int[] GetColumn8Array()
		{
			return this.__p.__vector_as_array<int>(22) ?? Array.Empty<int>();
		}

		// Token: 0x06006F04 RID: 28420 RVA: 0x00242380 File Offset: 0x00240580
		public int Column9(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000F5B RID: 3931
		// (get) Token: 0x06006F05 RID: 28421 RVA: 0x002423C0 File Offset: 0x002405C0
		public int Column9Length
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06006F06 RID: 28422 RVA: 0x002423EC File Offset: 0x002405EC
		public Span<int> GetColumn9Bytes()
		{
			return this.__p.__vector_as_span<int>(24, 4);
		}

		// Token: 0x06006F07 RID: 28423 RVA: 0x002423FC File Offset: 0x002405FC
		public int[] GetColumn9Array()
		{
			return this.__p.__vector_as_array<int>(24) ?? Array.Empty<int>();
		}

		// Token: 0x06006F08 RID: 28424 RVA: 0x00242414 File Offset: 0x00240614
		public int Column10(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000F5C RID: 3932
		// (get) Token: 0x06006F09 RID: 28425 RVA: 0x00242454 File Offset: 0x00240654
		public int Column10Length
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06006F0A RID: 28426 RVA: 0x00242480 File Offset: 0x00240680
		public Span<int> GetColumn10Bytes()
		{
			return this.__p.__vector_as_span<int>(26, 4);
		}

		// Token: 0x06006F0B RID: 28427 RVA: 0x00242490 File Offset: 0x00240690
		public int[] GetColumn10Array()
		{
			return this.__p.__vector_as_array<int>(26) ?? Array.Empty<int>();
		}

		// Token: 0x06006F0C RID: 28428 RVA: 0x002424A8 File Offset: 0x002406A8
		public int Column11(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000F5D RID: 3933
		// (get) Token: 0x06006F0D RID: 28429 RVA: 0x002424E8 File Offset: 0x002406E8
		public int Column11Length
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06006F0E RID: 28430 RVA: 0x00242514 File Offset: 0x00240714
		public Span<int> GetColumn11Bytes()
		{
			return this.__p.__vector_as_span<int>(28, 4);
		}

		// Token: 0x06006F0F RID: 28431 RVA: 0x00242524 File Offset: 0x00240724
		public int[] GetColumn11Array()
		{
			return this.__p.__vector_as_array<int>(28) ?? Array.Empty<int>();
		}

		// Token: 0x06006F10 RID: 28432 RVA: 0x0024253C File Offset: 0x0024073C
		[NullableContext(1)]
		public int[] Column1()
		{
			return this.GetColumn1Array();
		}

		// Token: 0x06006F11 RID: 28433 RVA: 0x00242544 File Offset: 0x00240744
		[NullableContext(1)]
		public IEnumerable<int> Column1Iter()
		{
			EncircleMap.<Column1Iter>d__68 <Column1Iter>d__ = new EncircleMap.<Column1Iter>d__68(-2);
			<Column1Iter>d__.<>3__<>4__this = this;
			return <Column1Iter>d__;
		}

		// Token: 0x06006F12 RID: 28434 RVA: 0x00242559 File Offset: 0x00240759
		[NullableContext(1)]
		public int[] Column10()
		{
			return this.GetColumn10Array();
		}

		// Token: 0x06006F13 RID: 28435 RVA: 0x00242561 File Offset: 0x00240761
		[NullableContext(1)]
		public IEnumerable<int> Column10Iter()
		{
			EncircleMap.<Column10Iter>d__70 <Column10Iter>d__ = new EncircleMap.<Column10Iter>d__70(-2);
			<Column10Iter>d__.<>3__<>4__this = this;
			return <Column10Iter>d__;
		}

		// Token: 0x06006F14 RID: 28436 RVA: 0x00242576 File Offset: 0x00240776
		[NullableContext(1)]
		public int[] Column11()
		{
			return this.GetColumn11Array();
		}

		// Token: 0x06006F15 RID: 28437 RVA: 0x0024257E File Offset: 0x0024077E
		[NullableContext(1)]
		public IEnumerable<int> Column11Iter()
		{
			EncircleMap.<Column11Iter>d__72 <Column11Iter>d__ = new EncircleMap.<Column11Iter>d__72(-2);
			<Column11Iter>d__.<>3__<>4__this = this;
			return <Column11Iter>d__;
		}

		// Token: 0x06006F16 RID: 28438 RVA: 0x00242593 File Offset: 0x00240793
		[NullableContext(1)]
		public int[] Column2()
		{
			return this.GetColumn2Array();
		}

		// Token: 0x06006F17 RID: 28439 RVA: 0x0024259B File Offset: 0x0024079B
		[NullableContext(1)]
		public IEnumerable<int> Column2Iter()
		{
			EncircleMap.<Column2Iter>d__74 <Column2Iter>d__ = new EncircleMap.<Column2Iter>d__74(-2);
			<Column2Iter>d__.<>3__<>4__this = this;
			return <Column2Iter>d__;
		}

		// Token: 0x06006F18 RID: 28440 RVA: 0x002425B0 File Offset: 0x002407B0
		[NullableContext(1)]
		public int[] Column3()
		{
			return this.GetColumn3Array();
		}

		// Token: 0x06006F19 RID: 28441 RVA: 0x002425B8 File Offset: 0x002407B8
		[NullableContext(1)]
		public IEnumerable<int> Column3Iter()
		{
			EncircleMap.<Column3Iter>d__76 <Column3Iter>d__ = new EncircleMap.<Column3Iter>d__76(-2);
			<Column3Iter>d__.<>3__<>4__this = this;
			return <Column3Iter>d__;
		}

		// Token: 0x06006F1A RID: 28442 RVA: 0x002425CD File Offset: 0x002407CD
		[NullableContext(1)]
		public int[] Column4()
		{
			return this.GetColumn4Array();
		}

		// Token: 0x06006F1B RID: 28443 RVA: 0x002425D5 File Offset: 0x002407D5
		[NullableContext(1)]
		public IEnumerable<int> Column4Iter()
		{
			EncircleMap.<Column4Iter>d__78 <Column4Iter>d__ = new EncircleMap.<Column4Iter>d__78(-2);
			<Column4Iter>d__.<>3__<>4__this = this;
			return <Column4Iter>d__;
		}

		// Token: 0x06006F1C RID: 28444 RVA: 0x002425EA File Offset: 0x002407EA
		[NullableContext(1)]
		public int[] Column5()
		{
			return this.GetColumn5Array();
		}

		// Token: 0x06006F1D RID: 28445 RVA: 0x002425F2 File Offset: 0x002407F2
		[NullableContext(1)]
		public IEnumerable<int> Column5Iter()
		{
			EncircleMap.<Column5Iter>d__80 <Column5Iter>d__ = new EncircleMap.<Column5Iter>d__80(-2);
			<Column5Iter>d__.<>3__<>4__this = this;
			return <Column5Iter>d__;
		}

		// Token: 0x06006F1E RID: 28446 RVA: 0x00242607 File Offset: 0x00240807
		[NullableContext(1)]
		public int[] Column6()
		{
			return this.GetColumn6Array();
		}

		// Token: 0x06006F1F RID: 28447 RVA: 0x0024260F File Offset: 0x0024080F
		[NullableContext(1)]
		public IEnumerable<int> Column6Iter()
		{
			EncircleMap.<Column6Iter>d__82 <Column6Iter>d__ = new EncircleMap.<Column6Iter>d__82(-2);
			<Column6Iter>d__.<>3__<>4__this = this;
			return <Column6Iter>d__;
		}

		// Token: 0x06006F20 RID: 28448 RVA: 0x00242624 File Offset: 0x00240824
		[NullableContext(1)]
		public int[] Column7()
		{
			return this.GetColumn7Array();
		}

		// Token: 0x06006F21 RID: 28449 RVA: 0x0024262C File Offset: 0x0024082C
		[NullableContext(1)]
		public IEnumerable<int> Column7Iter()
		{
			EncircleMap.<Column7Iter>d__84 <Column7Iter>d__ = new EncircleMap.<Column7Iter>d__84(-2);
			<Column7Iter>d__.<>3__<>4__this = this;
			return <Column7Iter>d__;
		}

		// Token: 0x06006F22 RID: 28450 RVA: 0x00242641 File Offset: 0x00240841
		[NullableContext(1)]
		public int[] Column8()
		{
			return this.GetColumn8Array();
		}

		// Token: 0x06006F23 RID: 28451 RVA: 0x00242649 File Offset: 0x00240849
		[NullableContext(1)]
		public IEnumerable<int> Column8Iter()
		{
			EncircleMap.<Column8Iter>d__86 <Column8Iter>d__ = new EncircleMap.<Column8Iter>d__86(-2);
			<Column8Iter>d__.<>3__<>4__this = this;
			return <Column8Iter>d__;
		}

		// Token: 0x06006F24 RID: 28452 RVA: 0x0024265E File Offset: 0x0024085E
		[NullableContext(1)]
		public int[] Column9()
		{
			return this.GetColumn9Array();
		}

		// Token: 0x06006F25 RID: 28453 RVA: 0x00242666 File Offset: 0x00240866
		[NullableContext(1)]
		public IEnumerable<int> Column9Iter()
		{
			EncircleMap.<Column9Iter>d__88 <Column9Iter>d__ = new EncircleMap.<Column9Iter>d__88(-2);
			<Column9Iter>d__.<>3__<>4__this = this;
			return <Column9Iter>d__;
		}

		// Token: 0x04005252 RID: 21074
		private Table __p;
	}
}

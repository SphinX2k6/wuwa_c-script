using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EDD RID: 3805
	public struct MatchThreeBoard : IFlatbufferObject
	{
		// Token: 0x17001EC8 RID: 7880
		// (get) Token: 0x06009838 RID: 38968 RVA: 0x0029EFE1 File Offset: 0x0029D1E1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009839 RID: 38969 RVA: 0x0029EFEE File Offset: 0x0029D1EE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600983A RID: 38970 RVA: 0x0029EFF8 File Offset: 0x0029D1F8
		public static MatchThreeBoard GetRootAsMatchThreeBoard(ByteBuffer _bb)
		{
			return MatchThreeBoard.GetRootAsMatchThreeBoard(_bb, default(MatchThreeBoard));
		}

		// Token: 0x0600983B RID: 38971 RVA: 0x0029F014 File Offset: 0x0029D214
		public static MatchThreeBoard GetRootAsMatchThreeBoard(ByteBuffer _bb, MatchThreeBoard obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600983C RID: 38972 RVA: 0x0029F031 File Offset: 0x0029D231
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600983D RID: 38973 RVA: 0x0029F040 File Offset: 0x0029D240
		public MatchThreeBoard __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001EC9 RID: 7881
		// (get) Token: 0x0600983E RID: 38974 RVA: 0x0029F050 File Offset: 0x0029D250
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

		// Token: 0x17001ECA RID: 7882
		// (get) Token: 0x0600983F RID: 38975 RVA: 0x0029F08C File Offset: 0x0029D28C
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

		// Token: 0x06009840 RID: 38976 RVA: 0x0029F0C8 File Offset: 0x0029D2C8
		public int Column1(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001ECB RID: 7883
		// (get) Token: 0x06009841 RID: 38977 RVA: 0x0029F108 File Offset: 0x0029D308
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

		// Token: 0x06009842 RID: 38978 RVA: 0x0029F133 File Offset: 0x0029D333
		public Span<int> GetColumn1Bytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06009843 RID: 38979 RVA: 0x0029F142 File Offset: 0x0029D342
		public int[] GetColumn1Array()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x06009844 RID: 38980 RVA: 0x0029F15C File Offset: 0x0029D35C
		public int Column2(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001ECC RID: 7884
		// (get) Token: 0x06009845 RID: 38981 RVA: 0x0029F19C File Offset: 0x0029D39C
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

		// Token: 0x06009846 RID: 38982 RVA: 0x0029F1C8 File Offset: 0x0029D3C8
		public Span<int> GetColumn2Bytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x06009847 RID: 38983 RVA: 0x0029F1D8 File Offset: 0x0029D3D8
		public int[] GetColumn2Array()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x06009848 RID: 38984 RVA: 0x0029F1F0 File Offset: 0x0029D3F0
		public int Column3(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001ECD RID: 7885
		// (get) Token: 0x06009849 RID: 38985 RVA: 0x0029F230 File Offset: 0x0029D430
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

		// Token: 0x0600984A RID: 38986 RVA: 0x0029F25C File Offset: 0x0029D45C
		public Span<int> GetColumn3Bytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x0600984B RID: 38987 RVA: 0x0029F26C File Offset: 0x0029D46C
		public int[] GetColumn3Array()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x0600984C RID: 38988 RVA: 0x0029F284 File Offset: 0x0029D484
		public int Column4(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001ECE RID: 7886
		// (get) Token: 0x0600984D RID: 38989 RVA: 0x0029F2C4 File Offset: 0x0029D4C4
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

		// Token: 0x0600984E RID: 38990 RVA: 0x0029F2F0 File Offset: 0x0029D4F0
		public Span<int> GetColumn4Bytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x0600984F RID: 38991 RVA: 0x0029F300 File Offset: 0x0029D500
		public int[] GetColumn4Array()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x06009850 RID: 38992 RVA: 0x0029F318 File Offset: 0x0029D518
		public int Column5(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001ECF RID: 7887
		// (get) Token: 0x06009851 RID: 38993 RVA: 0x0029F358 File Offset: 0x0029D558
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

		// Token: 0x06009852 RID: 38994 RVA: 0x0029F384 File Offset: 0x0029D584
		public Span<int> GetColumn5Bytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x06009853 RID: 38995 RVA: 0x0029F394 File Offset: 0x0029D594
		public int[] GetColumn5Array()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x06009854 RID: 38996 RVA: 0x0029F3AC File Offset: 0x0029D5AC
		public int Column6(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001ED0 RID: 7888
		// (get) Token: 0x06009855 RID: 38997 RVA: 0x0029F3EC File Offset: 0x0029D5EC
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

		// Token: 0x06009856 RID: 38998 RVA: 0x0029F418 File Offset: 0x0029D618
		public Span<int> GetColumn6Bytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x06009857 RID: 38999 RVA: 0x0029F428 File Offset: 0x0029D628
		public int[] GetColumn6Array()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x06009858 RID: 39000 RVA: 0x0029F440 File Offset: 0x0029D640
		public int Column7(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001ED1 RID: 7889
		// (get) Token: 0x06009859 RID: 39001 RVA: 0x0029F480 File Offset: 0x0029D680
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

		// Token: 0x0600985A RID: 39002 RVA: 0x0029F4AC File Offset: 0x0029D6AC
		public Span<int> GetColumn7Bytes()
		{
			return this.__p.__vector_as_span<int>(20, 4);
		}

		// Token: 0x0600985B RID: 39003 RVA: 0x0029F4BC File Offset: 0x0029D6BC
		public int[] GetColumn7Array()
		{
			return this.__p.__vector_as_array<int>(20) ?? Array.Empty<int>();
		}

		// Token: 0x0600985C RID: 39004 RVA: 0x0029F4D4 File Offset: 0x0029D6D4
		public int Column8(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001ED2 RID: 7890
		// (get) Token: 0x0600985D RID: 39005 RVA: 0x0029F514 File Offset: 0x0029D714
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

		// Token: 0x0600985E RID: 39006 RVA: 0x0029F540 File Offset: 0x0029D740
		public Span<int> GetColumn8Bytes()
		{
			return this.__p.__vector_as_span<int>(22, 4);
		}

		// Token: 0x0600985F RID: 39007 RVA: 0x0029F550 File Offset: 0x0029D750
		public int[] GetColumn8Array()
		{
			return this.__p.__vector_as_array<int>(22) ?? Array.Empty<int>();
		}

		// Token: 0x06009860 RID: 39008 RVA: 0x0029F568 File Offset: 0x0029D768
		[NullableContext(1)]
		public int[] Column1()
		{
			return this.GetColumn1Array();
		}

		// Token: 0x06009861 RID: 39009 RVA: 0x0029F570 File Offset: 0x0029D770
		[NullableContext(1)]
		public IEnumerable<int> Column1Iter()
		{
			MatchThreeBoard.<Column1Iter>d__53 <Column1Iter>d__ = new MatchThreeBoard.<Column1Iter>d__53(-2);
			<Column1Iter>d__.<>3__<>4__this = this;
			return <Column1Iter>d__;
		}

		// Token: 0x06009862 RID: 39010 RVA: 0x0029F585 File Offset: 0x0029D785
		[NullableContext(1)]
		public int[] Column2()
		{
			return this.GetColumn2Array();
		}

		// Token: 0x06009863 RID: 39011 RVA: 0x0029F58D File Offset: 0x0029D78D
		[NullableContext(1)]
		public IEnumerable<int> Column2Iter()
		{
			MatchThreeBoard.<Column2Iter>d__55 <Column2Iter>d__ = new MatchThreeBoard.<Column2Iter>d__55(-2);
			<Column2Iter>d__.<>3__<>4__this = this;
			return <Column2Iter>d__;
		}

		// Token: 0x06009864 RID: 39012 RVA: 0x0029F5A2 File Offset: 0x0029D7A2
		[NullableContext(1)]
		public int[] Column3()
		{
			return this.GetColumn3Array();
		}

		// Token: 0x06009865 RID: 39013 RVA: 0x0029F5AA File Offset: 0x0029D7AA
		[NullableContext(1)]
		public IEnumerable<int> Column3Iter()
		{
			MatchThreeBoard.<Column3Iter>d__57 <Column3Iter>d__ = new MatchThreeBoard.<Column3Iter>d__57(-2);
			<Column3Iter>d__.<>3__<>4__this = this;
			return <Column3Iter>d__;
		}

		// Token: 0x06009866 RID: 39014 RVA: 0x0029F5BF File Offset: 0x0029D7BF
		[NullableContext(1)]
		public int[] Column4()
		{
			return this.GetColumn4Array();
		}

		// Token: 0x06009867 RID: 39015 RVA: 0x0029F5C7 File Offset: 0x0029D7C7
		[NullableContext(1)]
		public IEnumerable<int> Column4Iter()
		{
			MatchThreeBoard.<Column4Iter>d__59 <Column4Iter>d__ = new MatchThreeBoard.<Column4Iter>d__59(-2);
			<Column4Iter>d__.<>3__<>4__this = this;
			return <Column4Iter>d__;
		}

		// Token: 0x06009868 RID: 39016 RVA: 0x0029F5DC File Offset: 0x0029D7DC
		[NullableContext(1)]
		public int[] Column5()
		{
			return this.GetColumn5Array();
		}

		// Token: 0x06009869 RID: 39017 RVA: 0x0029F5E4 File Offset: 0x0029D7E4
		[NullableContext(1)]
		public IEnumerable<int> Column5Iter()
		{
			MatchThreeBoard.<Column5Iter>d__61 <Column5Iter>d__ = new MatchThreeBoard.<Column5Iter>d__61(-2);
			<Column5Iter>d__.<>3__<>4__this = this;
			return <Column5Iter>d__;
		}

		// Token: 0x0600986A RID: 39018 RVA: 0x0029F5F9 File Offset: 0x0029D7F9
		[NullableContext(1)]
		public int[] Column6()
		{
			return this.GetColumn6Array();
		}

		// Token: 0x0600986B RID: 39019 RVA: 0x0029F601 File Offset: 0x0029D801
		[NullableContext(1)]
		public IEnumerable<int> Column6Iter()
		{
			MatchThreeBoard.<Column6Iter>d__63 <Column6Iter>d__ = new MatchThreeBoard.<Column6Iter>d__63(-2);
			<Column6Iter>d__.<>3__<>4__this = this;
			return <Column6Iter>d__;
		}

		// Token: 0x0600986C RID: 39020 RVA: 0x0029F616 File Offset: 0x0029D816
		[NullableContext(1)]
		public int[] Column7()
		{
			return this.GetColumn7Array();
		}

		// Token: 0x0600986D RID: 39021 RVA: 0x0029F61E File Offset: 0x0029D81E
		[NullableContext(1)]
		public IEnumerable<int> Column7Iter()
		{
			MatchThreeBoard.<Column7Iter>d__65 <Column7Iter>d__ = new MatchThreeBoard.<Column7Iter>d__65(-2);
			<Column7Iter>d__.<>3__<>4__this = this;
			return <Column7Iter>d__;
		}

		// Token: 0x0600986E RID: 39022 RVA: 0x0029F633 File Offset: 0x0029D833
		[NullableContext(1)]
		public int[] Column8()
		{
			return this.GetColumn8Array();
		}

		// Token: 0x0600986F RID: 39023 RVA: 0x0029F63B File Offset: 0x0029D83B
		[NullableContext(1)]
		public IEnumerable<int> Column8Iter()
		{
			MatchThreeBoard.<Column8Iter>d__67 <Column8Iter>d__ = new MatchThreeBoard.<Column8Iter>d__67(-2);
			<Column8Iter>d__.<>3__<>4__this = this;
			return <Column8Iter>d__;
		}

		// Token: 0x0400547D RID: 21629
		private Table __p;
	}
}

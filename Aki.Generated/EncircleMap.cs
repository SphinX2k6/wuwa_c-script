using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C2F RID: 3119
	public struct EncircleMap : IFlatbufferObject
	{
		// Token: 0x17000EF7 RID: 3831
		// (get) Token: 0x060068DA RID: 26842 RVA: 0x00222925 File Offset: 0x00220B25
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060068DB RID: 26843 RVA: 0x00222932 File Offset: 0x00220B32
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060068DC RID: 26844 RVA: 0x0022293C File Offset: 0x00220B3C
		public static EncircleMap GetRootAsEncircleMap(ByteBuffer _bb)
		{
			return EncircleMap.GetRootAsEncircleMap(_bb, default(EncircleMap));
		}

		// Token: 0x060068DD RID: 26845 RVA: 0x00222958 File Offset: 0x00220B58
		public static EncircleMap GetRootAsEncircleMap(ByteBuffer _bb, EncircleMap obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060068DE RID: 26846 RVA: 0x00222975 File Offset: 0x00220B75
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060068DF RID: 26847 RVA: 0x00222984 File Offset: 0x00220B84
		public EncircleMap __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000EF8 RID: 3832
		// (get) Token: 0x060068E0 RID: 26848 RVA: 0x00222994 File Offset: 0x00220B94
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

		// Token: 0x17000EF9 RID: 3833
		// (get) Token: 0x060068E1 RID: 26849 RVA: 0x002229D0 File Offset: 0x00220BD0
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

		// Token: 0x060068E2 RID: 26850 RVA: 0x00222A0C File Offset: 0x00220C0C
		public int Column1(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000EFA RID: 3834
		// (get) Token: 0x060068E3 RID: 26851 RVA: 0x00222A4C File Offset: 0x00220C4C
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

		// Token: 0x060068E4 RID: 26852 RVA: 0x00222A77 File Offset: 0x00220C77
		public Span<int> GetColumn1Bytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x060068E5 RID: 26853 RVA: 0x00222A86 File Offset: 0x00220C86
		public int[] GetColumn1Array()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x060068E6 RID: 26854 RVA: 0x00222AA0 File Offset: 0x00220CA0
		public int Column2(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000EFB RID: 3835
		// (get) Token: 0x060068E7 RID: 26855 RVA: 0x00222AE0 File Offset: 0x00220CE0
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

		// Token: 0x060068E8 RID: 26856 RVA: 0x00222B0C File Offset: 0x00220D0C
		public Span<int> GetColumn2Bytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x060068E9 RID: 26857 RVA: 0x00222B1C File Offset: 0x00220D1C
		public int[] GetColumn2Array()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x060068EA RID: 26858 RVA: 0x00222B34 File Offset: 0x00220D34
		public int Column3(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000EFC RID: 3836
		// (get) Token: 0x060068EB RID: 26859 RVA: 0x00222B74 File Offset: 0x00220D74
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

		// Token: 0x060068EC RID: 26860 RVA: 0x00222BA0 File Offset: 0x00220DA0
		public Span<int> GetColumn3Bytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x060068ED RID: 26861 RVA: 0x00222BB0 File Offset: 0x00220DB0
		public int[] GetColumn3Array()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x060068EE RID: 26862 RVA: 0x00222BC8 File Offset: 0x00220DC8
		public int Column4(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000EFD RID: 3837
		// (get) Token: 0x060068EF RID: 26863 RVA: 0x00222C08 File Offset: 0x00220E08
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

		// Token: 0x060068F0 RID: 26864 RVA: 0x00222C34 File Offset: 0x00220E34
		public Span<int> GetColumn4Bytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x060068F1 RID: 26865 RVA: 0x00222C44 File Offset: 0x00220E44
		public int[] GetColumn4Array()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x060068F2 RID: 26866 RVA: 0x00222C5C File Offset: 0x00220E5C
		public int Column5(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000EFE RID: 3838
		// (get) Token: 0x060068F3 RID: 26867 RVA: 0x00222C9C File Offset: 0x00220E9C
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

		// Token: 0x060068F4 RID: 26868 RVA: 0x00222CC8 File Offset: 0x00220EC8
		public Span<int> GetColumn5Bytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x060068F5 RID: 26869 RVA: 0x00222CD8 File Offset: 0x00220ED8
		public int[] GetColumn5Array()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x060068F6 RID: 26870 RVA: 0x00222CF0 File Offset: 0x00220EF0
		public int Column6(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000EFF RID: 3839
		// (get) Token: 0x060068F7 RID: 26871 RVA: 0x00222D30 File Offset: 0x00220F30
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

		// Token: 0x060068F8 RID: 26872 RVA: 0x00222D5C File Offset: 0x00220F5C
		public Span<int> GetColumn6Bytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x060068F9 RID: 26873 RVA: 0x00222D6C File Offset: 0x00220F6C
		public int[] GetColumn6Array()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x060068FA RID: 26874 RVA: 0x00222D84 File Offset: 0x00220F84
		public int Column7(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000F00 RID: 3840
		// (get) Token: 0x060068FB RID: 26875 RVA: 0x00222DC4 File Offset: 0x00220FC4
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

		// Token: 0x060068FC RID: 26876 RVA: 0x00222DF0 File Offset: 0x00220FF0
		public Span<int> GetColumn7Bytes()
		{
			return this.__p.__vector_as_span<int>(20, 4);
		}

		// Token: 0x060068FD RID: 26877 RVA: 0x00222E00 File Offset: 0x00221000
		public int[] GetColumn7Array()
		{
			return this.__p.__vector_as_array<int>(20) ?? Array.Empty<int>();
		}

		// Token: 0x060068FE RID: 26878 RVA: 0x00222E18 File Offset: 0x00221018
		public int Column8(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000F01 RID: 3841
		// (get) Token: 0x060068FF RID: 26879 RVA: 0x00222E58 File Offset: 0x00221058
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

		// Token: 0x06006900 RID: 26880 RVA: 0x00222E84 File Offset: 0x00221084
		public Span<int> GetColumn8Bytes()
		{
			return this.__p.__vector_as_span<int>(22, 4);
		}

		// Token: 0x06006901 RID: 26881 RVA: 0x00222E94 File Offset: 0x00221094
		public int[] GetColumn8Array()
		{
			return this.__p.__vector_as_array<int>(22) ?? Array.Empty<int>();
		}

		// Token: 0x06006902 RID: 26882 RVA: 0x00222EAC File Offset: 0x002210AC
		public int Column9(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000F02 RID: 3842
		// (get) Token: 0x06006903 RID: 26883 RVA: 0x00222EEC File Offset: 0x002210EC
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

		// Token: 0x06006904 RID: 26884 RVA: 0x00222F18 File Offset: 0x00221118
		public Span<int> GetColumn9Bytes()
		{
			return this.__p.__vector_as_span<int>(24, 4);
		}

		// Token: 0x06006905 RID: 26885 RVA: 0x00222F28 File Offset: 0x00221128
		public int[] GetColumn9Array()
		{
			return this.__p.__vector_as_array<int>(24) ?? Array.Empty<int>();
		}

		// Token: 0x06006906 RID: 26886 RVA: 0x00222F40 File Offset: 0x00221140
		public int Column10(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000F03 RID: 3843
		// (get) Token: 0x06006907 RID: 26887 RVA: 0x00222F80 File Offset: 0x00221180
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

		// Token: 0x06006908 RID: 26888 RVA: 0x00222FAC File Offset: 0x002211AC
		public Span<int> GetColumn10Bytes()
		{
			return this.__p.__vector_as_span<int>(26, 4);
		}

		// Token: 0x06006909 RID: 26889 RVA: 0x00222FBC File Offset: 0x002211BC
		public int[] GetColumn10Array()
		{
			return this.__p.__vector_as_array<int>(26) ?? Array.Empty<int>();
		}

		// Token: 0x0600690A RID: 26890 RVA: 0x00222FD4 File Offset: 0x002211D4
		public int Column11(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000F04 RID: 3844
		// (get) Token: 0x0600690B RID: 26891 RVA: 0x00223014 File Offset: 0x00221214
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

		// Token: 0x0600690C RID: 26892 RVA: 0x00223040 File Offset: 0x00221240
		public Span<int> GetColumn11Bytes()
		{
			return this.__p.__vector_as_span<int>(28, 4);
		}

		// Token: 0x0600690D RID: 26893 RVA: 0x00223050 File Offset: 0x00221250
		public int[] GetColumn11Array()
		{
			return this.__p.__vector_as_array<int>(28) ?? Array.Empty<int>();
		}

		// Token: 0x0600690E RID: 26894 RVA: 0x00223068 File Offset: 0x00221268
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用Column1Iter()或GetColumn1Bytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Column1()
		{
			EncircleMap encircleMap = this;
			return encircleMap.GetColumn1Array() ?? Array.Empty<int>();
		}

		// Token: 0x0600690F RID: 26895 RVA: 0x0022308C File Offset: 0x0022128C
		[NullableContext(1)]
		public readonly IEnumerable<int> Column1Iter()
		{
			EncircleMap.<Column1Iter>d__68 <Column1Iter>d__ = new EncircleMap.<Column1Iter>d__68(-2);
			<Column1Iter>d__.<>3__<>4__this = this;
			return <Column1Iter>d__;
		}

		// Token: 0x06006910 RID: 26896 RVA: 0x002230A4 File Offset: 0x002212A4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用Column10Iter()或GetColumn10Bytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Column10()
		{
			EncircleMap encircleMap = this;
			return encircleMap.GetColumn10Array() ?? Array.Empty<int>();
		}

		// Token: 0x06006911 RID: 26897 RVA: 0x002230C8 File Offset: 0x002212C8
		[NullableContext(1)]
		public readonly IEnumerable<int> Column10Iter()
		{
			EncircleMap.<Column10Iter>d__70 <Column10Iter>d__ = new EncircleMap.<Column10Iter>d__70(-2);
			<Column10Iter>d__.<>3__<>4__this = this;
			return <Column10Iter>d__;
		}

		// Token: 0x06006912 RID: 26898 RVA: 0x002230E0 File Offset: 0x002212E0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用Column11Iter()或GetColumn11Bytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Column11()
		{
			EncircleMap encircleMap = this;
			return encircleMap.GetColumn11Array() ?? Array.Empty<int>();
		}

		// Token: 0x06006913 RID: 26899 RVA: 0x00223104 File Offset: 0x00221304
		[NullableContext(1)]
		public readonly IEnumerable<int> Column11Iter()
		{
			EncircleMap.<Column11Iter>d__72 <Column11Iter>d__ = new EncircleMap.<Column11Iter>d__72(-2);
			<Column11Iter>d__.<>3__<>4__this = this;
			return <Column11Iter>d__;
		}

		// Token: 0x06006914 RID: 26900 RVA: 0x0022311C File Offset: 0x0022131C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用Column2Iter()或GetColumn2Bytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Column2()
		{
			EncircleMap encircleMap = this;
			return encircleMap.GetColumn2Array() ?? Array.Empty<int>();
		}

		// Token: 0x06006915 RID: 26901 RVA: 0x00223140 File Offset: 0x00221340
		[NullableContext(1)]
		public readonly IEnumerable<int> Column2Iter()
		{
			EncircleMap.<Column2Iter>d__74 <Column2Iter>d__ = new EncircleMap.<Column2Iter>d__74(-2);
			<Column2Iter>d__.<>3__<>4__this = this;
			return <Column2Iter>d__;
		}

		// Token: 0x06006916 RID: 26902 RVA: 0x00223158 File Offset: 0x00221358
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用Column3Iter()或GetColumn3Bytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Column3()
		{
			EncircleMap encircleMap = this;
			return encircleMap.GetColumn3Array() ?? Array.Empty<int>();
		}

		// Token: 0x06006917 RID: 26903 RVA: 0x0022317C File Offset: 0x0022137C
		[NullableContext(1)]
		public readonly IEnumerable<int> Column3Iter()
		{
			EncircleMap.<Column3Iter>d__76 <Column3Iter>d__ = new EncircleMap.<Column3Iter>d__76(-2);
			<Column3Iter>d__.<>3__<>4__this = this;
			return <Column3Iter>d__;
		}

		// Token: 0x06006918 RID: 26904 RVA: 0x00223194 File Offset: 0x00221394
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用Column4Iter()或GetColumn4Bytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Column4()
		{
			EncircleMap encircleMap = this;
			return encircleMap.GetColumn4Array() ?? Array.Empty<int>();
		}

		// Token: 0x06006919 RID: 26905 RVA: 0x002231B8 File Offset: 0x002213B8
		[NullableContext(1)]
		public readonly IEnumerable<int> Column4Iter()
		{
			EncircleMap.<Column4Iter>d__78 <Column4Iter>d__ = new EncircleMap.<Column4Iter>d__78(-2);
			<Column4Iter>d__.<>3__<>4__this = this;
			return <Column4Iter>d__;
		}

		// Token: 0x0600691A RID: 26906 RVA: 0x002231D0 File Offset: 0x002213D0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用Column5Iter()或GetColumn5Bytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Column5()
		{
			EncircleMap encircleMap = this;
			return encircleMap.GetColumn5Array() ?? Array.Empty<int>();
		}

		// Token: 0x0600691B RID: 26907 RVA: 0x002231F4 File Offset: 0x002213F4
		[NullableContext(1)]
		public readonly IEnumerable<int> Column5Iter()
		{
			EncircleMap.<Column5Iter>d__80 <Column5Iter>d__ = new EncircleMap.<Column5Iter>d__80(-2);
			<Column5Iter>d__.<>3__<>4__this = this;
			return <Column5Iter>d__;
		}

		// Token: 0x0600691C RID: 26908 RVA: 0x0022320C File Offset: 0x0022140C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用Column6Iter()或GetColumn6Bytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Column6()
		{
			EncircleMap encircleMap = this;
			return encircleMap.GetColumn6Array() ?? Array.Empty<int>();
		}

		// Token: 0x0600691D RID: 26909 RVA: 0x00223230 File Offset: 0x00221430
		[NullableContext(1)]
		public readonly IEnumerable<int> Column6Iter()
		{
			EncircleMap.<Column6Iter>d__82 <Column6Iter>d__ = new EncircleMap.<Column6Iter>d__82(-2);
			<Column6Iter>d__.<>3__<>4__this = this;
			return <Column6Iter>d__;
		}

		// Token: 0x0600691E RID: 26910 RVA: 0x00223248 File Offset: 0x00221448
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用Column7Iter()或GetColumn7Bytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Column7()
		{
			EncircleMap encircleMap = this;
			return encircleMap.GetColumn7Array() ?? Array.Empty<int>();
		}

		// Token: 0x0600691F RID: 26911 RVA: 0x0022326C File Offset: 0x0022146C
		[NullableContext(1)]
		public readonly IEnumerable<int> Column7Iter()
		{
			EncircleMap.<Column7Iter>d__84 <Column7Iter>d__ = new EncircleMap.<Column7Iter>d__84(-2);
			<Column7Iter>d__.<>3__<>4__this = this;
			return <Column7Iter>d__;
		}

		// Token: 0x06006920 RID: 26912 RVA: 0x00223284 File Offset: 0x00221484
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用Column8Iter()或GetColumn8Bytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Column8()
		{
			EncircleMap encircleMap = this;
			return encircleMap.GetColumn8Array() ?? Array.Empty<int>();
		}

		// Token: 0x06006921 RID: 26913 RVA: 0x002232A8 File Offset: 0x002214A8
		[NullableContext(1)]
		public readonly IEnumerable<int> Column8Iter()
		{
			EncircleMap.<Column8Iter>d__86 <Column8Iter>d__ = new EncircleMap.<Column8Iter>d__86(-2);
			<Column8Iter>d__.<>3__<>4__this = this;
			return <Column8Iter>d__;
		}

		// Token: 0x06006922 RID: 26914 RVA: 0x002232C0 File Offset: 0x002214C0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用Column9Iter()或GetColumn9Bytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Column9()
		{
			EncircleMap encircleMap = this;
			return encircleMap.GetColumn9Array() ?? Array.Empty<int>();
		}

		// Token: 0x06006923 RID: 26915 RVA: 0x002232E4 File Offset: 0x002214E4
		[NullableContext(1)]
		public readonly IEnumerable<int> Column9Iter()
		{
			EncircleMap.<Column9Iter>d__88 <Column9Iter>d__ = new EncircleMap.<Column9Iter>d__88(-2);
			<Column9Iter>d__.<>3__<>4__this = this;
			return <Column9Iter>d__;
		}

		// Token: 0x04004C6F RID: 19567
		private Table __p;
	}
}

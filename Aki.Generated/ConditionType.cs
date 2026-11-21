using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C78 RID: 3192
	public struct ConditionType : IFlatbufferObject
	{
		// Token: 0x1700094A RID: 2378
		// (get) Token: 0x06005DFF RID: 24063 RVA: 0x0021C2AD File Offset: 0x0021A4AD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005E00 RID: 24064 RVA: 0x0021C2BA File Offset: 0x0021A4BA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005E01 RID: 24065 RVA: 0x0021C2C4 File Offset: 0x0021A4C4
		public static ConditionType GetRootAsConditionType(ByteBuffer _bb)
		{
			return ConditionType.GetRootAsConditionType(_bb, default(ConditionType));
		}

		// Token: 0x06005E02 RID: 24066 RVA: 0x0021C2E0 File Offset: 0x0021A4E0
		public static ConditionType GetRootAsConditionType(ByteBuffer _bb, ConditionType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005E03 RID: 24067 RVA: 0x0021C2FD File Offset: 0x0021A4FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005E04 RID: 24068 RVA: 0x0021C30C File Offset: 0x0021A50C
		public ConditionType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700094B RID: 2379
		// (get) Token: 0x06005E05 RID: 24069 RVA: 0x0021C31C File Offset: 0x0021A51C
		public string Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005E06 RID: 24070 RVA: 0x0021C353 File Offset: 0x0021A553
		public Span<byte> GetTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06005E07 RID: 24071 RVA: 0x0021C362 File Offset: 0x0021A562
		public byte[] GetTypeArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x1700094C RID: 2380
		// (get) Token: 0x06005E08 RID: 24072 RVA: 0x0021C37C File Offset: 0x0021A57C
		public bool IsClientTrigger
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700094D RID: 2381
		// (get) Token: 0x06005E09 RID: 24073 RVA: 0x0021C3BC File Offset: 0x0021A5BC
		public int SubType
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

		// Token: 0x06005E0A RID: 24074 RVA: 0x0021C3F8 File Offset: 0x0021A5F8
		public int RegisterPlaces(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700094E RID: 2382
		// (get) Token: 0x06005E0B RID: 24075 RVA: 0x0021C438 File Offset: 0x0021A638
		public int RegisterPlacesLength
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

		// Token: 0x06005E0C RID: 24076 RVA: 0x0021C464 File Offset: 0x0021A664
		public Span<int> GetRegisterPlacesBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x06005E0D RID: 24077 RVA: 0x0021C474 File Offset: 0x0021A674
		public int[] GetRegisterPlacesArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x06005E0E RID: 24078 RVA: 0x0021C48C File Offset: 0x0021A68C
		public DicStringString? Param1(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700094F RID: 2383
		// (get) Token: 0x06005E0F RID: 24079 RVA: 0x0021C4F0 File Offset: 0x0021A6F0
		public int Param1Length
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

		// Token: 0x17000950 RID: 2384
		// (get) Token: 0x06005E10 RID: 24080 RVA: 0x0021C51C File Offset: 0x0021A71C
		public string DefaultParam1
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

		// Token: 0x06005E11 RID: 24081 RVA: 0x0021C554 File Offset: 0x0021A754
		public Span<byte> GetDefaultParam1Bytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06005E12 RID: 24082 RVA: 0x0021C564 File Offset: 0x0021A764
		public byte[] GetDefaultParam1Array()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x06005E13 RID: 24083 RVA: 0x0021C57C File Offset: 0x0021A77C
		public DicStringString? Param2(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000951 RID: 2385
		// (get) Token: 0x06005E14 RID: 24084 RVA: 0x0021C5E0 File Offset: 0x0021A7E0
		public int Param2Length
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

		// Token: 0x17000952 RID: 2386
		// (get) Token: 0x06005E15 RID: 24085 RVA: 0x0021C60C File Offset: 0x0021A80C
		public string DefaultParam2
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005E16 RID: 24086 RVA: 0x0021C644 File Offset: 0x0021A844
		public Span<byte> GetDefaultParam2Bytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06005E17 RID: 24087 RVA: 0x0021C654 File Offset: 0x0021A854
		public byte[] GetDefaultParam2Array()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x06005E18 RID: 24088 RVA: 0x0021C66C File Offset: 0x0021A86C
		public DicStringString? Param3(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000953 RID: 2387
		// (get) Token: 0x06005E19 RID: 24089 RVA: 0x0021C6D0 File Offset: 0x0021A8D0
		public int Param3Length
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

		// Token: 0x17000954 RID: 2388
		// (get) Token: 0x06005E1A RID: 24090 RVA: 0x0021C6FC File Offset: 0x0021A8FC
		public string DefaultParam3
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005E1B RID: 24091 RVA: 0x0021C734 File Offset: 0x0021A934
		public Span<byte> GetDefaultParam3Bytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06005E1C RID: 24092 RVA: 0x0021C744 File Offset: 0x0021A944
		public byte[] GetDefaultParam3Array()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x06005E1D RID: 24093 RVA: 0x0021C75C File Offset: 0x0021A95C
		public DicStringString? Param4(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000955 RID: 2389
		// (get) Token: 0x06005E1E RID: 24094 RVA: 0x0021C7C0 File Offset: 0x0021A9C0
		public int Param4Length
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

		// Token: 0x17000956 RID: 2390
		// (get) Token: 0x06005E1F RID: 24095 RVA: 0x0021C7EC File Offset: 0x0021A9EC
		public string DefaultParam4
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005E20 RID: 24096 RVA: 0x0021C824 File Offset: 0x0021AA24
		public Span<byte> GetDefaultParam4Bytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x06005E21 RID: 24097 RVA: 0x0021C834 File Offset: 0x0021AA34
		public byte[] GetDefaultParam4Array()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x06005E22 RID: 24098 RVA: 0x0021C84C File Offset: 0x0021AA4C
		public DicStringString? Param5(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000957 RID: 2391
		// (get) Token: 0x06005E23 RID: 24099 RVA: 0x0021C8B0 File Offset: 0x0021AAB0
		public int Param5Length
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

		// Token: 0x17000958 RID: 2392
		// (get) Token: 0x06005E24 RID: 24100 RVA: 0x0021C8DC File Offset: 0x0021AADC
		public string DefaultParam5
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

		// Token: 0x06005E25 RID: 24101 RVA: 0x0021C914 File Offset: 0x0021AB14
		public Span<byte> GetDefaultParam5Bytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x06005E26 RID: 24102 RVA: 0x0021C924 File Offset: 0x0021AB24
		public byte[] GetDefaultParam5Array()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x06005E27 RID: 24103 RVA: 0x0021C93C File Offset: 0x0021AB3C
		public DicStringString? Param6(int j)
		{
			int num = this.__p.__offset(32);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000959 RID: 2393
		// (get) Token: 0x06005E28 RID: 24104 RVA: 0x0021C9A0 File Offset: 0x0021ABA0
		public int Param6Length
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700095A RID: 2394
		// (get) Token: 0x06005E29 RID: 24105 RVA: 0x0021C9CC File Offset: 0x0021ABCC
		public string DefaultParam6
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005E2A RID: 24106 RVA: 0x0021CA04 File Offset: 0x0021AC04
		public Span<byte> GetDefaultParam6Bytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x06005E2B RID: 24107 RVA: 0x0021CA14 File Offset: 0x0021AC14
		public byte[] GetDefaultParam6Array()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x06005E2C RID: 24108 RVA: 0x0021CA2C File Offset: 0x0021AC2C
		public DicStringString? Param7(int j)
		{
			int num = this.__p.__offset(36);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700095B RID: 2395
		// (get) Token: 0x06005E2D RID: 24109 RVA: 0x0021CA90 File Offset: 0x0021AC90
		public int Param7Length
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700095C RID: 2396
		// (get) Token: 0x06005E2E RID: 24110 RVA: 0x0021CABC File Offset: 0x0021ACBC
		public string DefaultParam7
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005E2F RID: 24111 RVA: 0x0021CAF4 File Offset: 0x0021ACF4
		public Span<byte> GetDefaultParam7Bytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x06005E30 RID: 24112 RVA: 0x0021CB04 File Offset: 0x0021AD04
		public byte[] GetDefaultParam7Array()
		{
			return this.__p.__vector_as_array<byte>(38) ?? Array.Empty<byte>();
		}

		// Token: 0x06005E31 RID: 24113 RVA: 0x0021CB1C File Offset: 0x0021AD1C
		public DicStringString? Param8(int j)
		{
			int num = this.__p.__offset(40);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700095D RID: 2397
		// (get) Token: 0x06005E32 RID: 24114 RVA: 0x0021CB80 File Offset: 0x0021AD80
		public int Param8Length
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700095E RID: 2398
		// (get) Token: 0x06005E33 RID: 24115 RVA: 0x0021CBAC File Offset: 0x0021ADAC
		public string DefaultParam8
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005E34 RID: 24116 RVA: 0x0021CBE4 File Offset: 0x0021ADE4
		public Span<byte> GetDefaultParam8Bytes()
		{
			return this.__p.__vector_as_span<byte>(42, 1);
		}

		// Token: 0x06005E35 RID: 24117 RVA: 0x0021CBF4 File Offset: 0x0021ADF4
		public byte[] GetDefaultParam8Array()
		{
			return this.__p.__vector_as_array<byte>(42) ?? Array.Empty<byte>();
		}

		// Token: 0x06005E36 RID: 24118 RVA: 0x0021CC0C File Offset: 0x0021AE0C
		public DicStringString? Param9(int j)
		{
			int num = this.__p.__offset(44);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700095F RID: 2399
		// (get) Token: 0x06005E37 RID: 24119 RVA: 0x0021CC70 File Offset: 0x0021AE70
		public int Param9Length
		{
			get
			{
				int num = this.__p.__offset(44);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17000960 RID: 2400
		// (get) Token: 0x06005E38 RID: 24120 RVA: 0x0021CC9C File Offset: 0x0021AE9C
		public string DefaultParam9
		{
			get
			{
				int num = this.__p.__offset(46);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005E39 RID: 24121 RVA: 0x0021CCD4 File Offset: 0x0021AED4
		public Span<byte> GetDefaultParam9Bytes()
		{
			return this.__p.__vector_as_span<byte>(46, 1);
		}

		// Token: 0x06005E3A RID: 24122 RVA: 0x0021CCE4 File Offset: 0x0021AEE4
		public byte[] GetDefaultParam9Array()
		{
			return this.__p.__vector_as_array<byte>(46) ?? Array.Empty<byte>();
		}

		// Token: 0x06005E3B RID: 24123 RVA: 0x0021CCFC File Offset: 0x0021AEFC
		public DicStringString? Param10(int j)
		{
			int num = this.__p.__offset(48);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000961 RID: 2401
		// (get) Token: 0x06005E3C RID: 24124 RVA: 0x0021CD60 File Offset: 0x0021AF60
		public int Param10Length
		{
			get
			{
				int num = this.__p.__offset(48);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17000962 RID: 2402
		// (get) Token: 0x06005E3D RID: 24125 RVA: 0x0021CD8C File Offset: 0x0021AF8C
		public string DefaultParam10
		{
			get
			{
				int num = this.__p.__offset(50);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005E3E RID: 24126 RVA: 0x0021CDC4 File Offset: 0x0021AFC4
		public Span<byte> GetDefaultParam10Bytes()
		{
			return this.__p.__vector_as_span<byte>(50, 1);
		}

		// Token: 0x06005E3F RID: 24127 RVA: 0x0021CDD4 File Offset: 0x0021AFD4
		public byte[] GetDefaultParam10Array()
		{
			return this.__p.__vector_as_array<byte>(50) ?? Array.Empty<byte>();
		}

		// Token: 0x06005E40 RID: 24128 RVA: 0x0021CDEC File Offset: 0x0021AFEC
		public DicStringString? Param11(int j)
		{
			int num = this.__p.__offset(52);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000963 RID: 2403
		// (get) Token: 0x06005E41 RID: 24129 RVA: 0x0021CE50 File Offset: 0x0021B050
		public int Param11Length
		{
			get
			{
				int num = this.__p.__offset(52);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17000964 RID: 2404
		// (get) Token: 0x06005E42 RID: 24130 RVA: 0x0021CE7C File Offset: 0x0021B07C
		public string DefaultParam11
		{
			get
			{
				int num = this.__p.__offset(54);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005E43 RID: 24131 RVA: 0x0021CEB4 File Offset: 0x0021B0B4
		public Span<byte> GetDefaultParam11Bytes()
		{
			return this.__p.__vector_as_span<byte>(54, 1);
		}

		// Token: 0x06005E44 RID: 24132 RVA: 0x0021CEC4 File Offset: 0x0021B0C4
		public byte[] GetDefaultParam11Array()
		{
			return this.__p.__vector_as_array<byte>(54) ?? Array.Empty<byte>();
		}

		// Token: 0x06005E45 RID: 24133 RVA: 0x0021CEDC File Offset: 0x0021B0DC
		public DicStringString? Param12(int j)
		{
			int num = this.__p.__offset(56);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000965 RID: 2405
		// (get) Token: 0x06005E46 RID: 24134 RVA: 0x0021CF40 File Offset: 0x0021B140
		public int Param12Length
		{
			get
			{
				int num = this.__p.__offset(56);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17000966 RID: 2406
		// (get) Token: 0x06005E47 RID: 24135 RVA: 0x0021CF6C File Offset: 0x0021B16C
		public string DefaultParam12
		{
			get
			{
				int num = this.__p.__offset(58);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005E48 RID: 24136 RVA: 0x0021CFA4 File Offset: 0x0021B1A4
		public Span<byte> GetDefaultParam12Bytes()
		{
			return this.__p.__vector_as_span<byte>(58, 1);
		}

		// Token: 0x06005E49 RID: 24137 RVA: 0x0021CFB4 File Offset: 0x0021B1B4
		public byte[] GetDefaultParam12Array()
		{
			return this.__p.__vector_as_array<byte>(58) ?? Array.Empty<byte>();
		}

		// Token: 0x06005E4A RID: 24138 RVA: 0x0021CFCC File Offset: 0x0021B1CC
		public DicStringString? Param13(int j)
		{
			int num = this.__p.__offset(60);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000967 RID: 2407
		// (get) Token: 0x06005E4B RID: 24139 RVA: 0x0021D030 File Offset: 0x0021B230
		public int Param13Length
		{
			get
			{
				int num = this.__p.__offset(60);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17000968 RID: 2408
		// (get) Token: 0x06005E4C RID: 24140 RVA: 0x0021D05C File Offset: 0x0021B25C
		public string DefaultParam13
		{
			get
			{
				int num = this.__p.__offset(62);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005E4D RID: 24141 RVA: 0x0021D094 File Offset: 0x0021B294
		public Span<byte> GetDefaultParam13Bytes()
		{
			return this.__p.__vector_as_span<byte>(62, 1);
		}

		// Token: 0x06005E4E RID: 24142 RVA: 0x0021D0A4 File Offset: 0x0021B2A4
		public byte[] GetDefaultParam13Array()
		{
			return this.__p.__vector_as_array<byte>(62) ?? Array.Empty<byte>();
		}

		// Token: 0x06005E4F RID: 24143 RVA: 0x0021D0BC File Offset: 0x0021B2BC
		public DicStringString? Param14(int j)
		{
			int num = this.__p.__offset(64);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000969 RID: 2409
		// (get) Token: 0x06005E50 RID: 24144 RVA: 0x0021D120 File Offset: 0x0021B320
		public int Param14Length
		{
			get
			{
				int num = this.__p.__offset(64);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700096A RID: 2410
		// (get) Token: 0x06005E51 RID: 24145 RVA: 0x0021D14C File Offset: 0x0021B34C
		public string DefaultParam14
		{
			get
			{
				int num = this.__p.__offset(66);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005E52 RID: 24146 RVA: 0x0021D184 File Offset: 0x0021B384
		public Span<byte> GetDefaultParam14Bytes()
		{
			return this.__p.__vector_as_span<byte>(66, 1);
		}

		// Token: 0x06005E53 RID: 24147 RVA: 0x0021D194 File Offset: 0x0021B394
		public byte[] GetDefaultParam14Array()
		{
			return this.__p.__vector_as_array<byte>(66) ?? Array.Empty<byte>();
		}

		// Token: 0x06005E54 RID: 24148 RVA: 0x0021D1AC File Offset: 0x0021B3AC
		public DicStringString? Param15(int j)
		{
			int num = this.__p.__offset(68);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700096B RID: 2411
		// (get) Token: 0x06005E55 RID: 24149 RVA: 0x0021D210 File Offset: 0x0021B410
		public int Param15Length
		{
			get
			{
				int num = this.__p.__offset(68);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700096C RID: 2412
		// (get) Token: 0x06005E56 RID: 24150 RVA: 0x0021D23C File Offset: 0x0021B43C
		public string DefaultParam15
		{
			get
			{
				int num = this.__p.__offset(70);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005E57 RID: 24151 RVA: 0x0021D274 File Offset: 0x0021B474
		public Span<byte> GetDefaultParam15Bytes()
		{
			return this.__p.__vector_as_span<byte>(70, 1);
		}

		// Token: 0x06005E58 RID: 24152 RVA: 0x0021D284 File Offset: 0x0021B484
		public byte[] GetDefaultParam15Array()
		{
			return this.__p.__vector_as_array<byte>(70) ?? Array.Empty<byte>();
		}

		// Token: 0x06005E59 RID: 24153 RVA: 0x0021D29C File Offset: 0x0021B49C
		public DicStringString? Param16(int j)
		{
			int num = this.__p.__offset(72);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700096D RID: 2413
		// (get) Token: 0x06005E5A RID: 24154 RVA: 0x0021D300 File Offset: 0x0021B500
		public int Param16Length
		{
			get
			{
				int num = this.__p.__offset(72);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700096E RID: 2414
		// (get) Token: 0x06005E5B RID: 24155 RVA: 0x0021D32C File Offset: 0x0021B52C
		public string DefaultParam16
		{
			get
			{
				int num = this.__p.__offset(74);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005E5C RID: 24156 RVA: 0x0021D364 File Offset: 0x0021B564
		public Span<byte> GetDefaultParam16Bytes()
		{
			return this.__p.__vector_as_span<byte>(74, 1);
		}

		// Token: 0x06005E5D RID: 24157 RVA: 0x0021D374 File Offset: 0x0021B574
		public byte[] GetDefaultParam16Array()
		{
			return this.__p.__vector_as_array<byte>(74) ?? Array.Empty<byte>();
		}

		// Token: 0x06005E5E RID: 24158 RVA: 0x0021D38C File Offset: 0x0021B58C
		[NullableContext(1)]
		public Dictionary<string, string> Param1()
		{
			return this.Param1Iter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x06005E5F RID: 24159 RVA: 0x0021D3E2 File Offset: 0x0021B5E2
		[NullableContext(1)]
		public IEnumerable<DicStringString> Param1Iter()
		{
			ConditionType.<Param1Iter>d__134 <Param1Iter>d__ = new ConditionType.<Param1Iter>d__134(-2);
			<Param1Iter>d__.<>3__<>4__this = this;
			return <Param1Iter>d__;
		}

		// Token: 0x06005E60 RID: 24160 RVA: 0x0021D3F8 File Offset: 0x0021B5F8
		[NullableContext(1)]
		public Dictionary<string, string> Param10()
		{
			return this.Param10Iter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x06005E61 RID: 24161 RVA: 0x0021D44E File Offset: 0x0021B64E
		[NullableContext(1)]
		public IEnumerable<DicStringString> Param10Iter()
		{
			ConditionType.<Param10Iter>d__136 <Param10Iter>d__ = new ConditionType.<Param10Iter>d__136(-2);
			<Param10Iter>d__.<>3__<>4__this = this;
			return <Param10Iter>d__;
		}

		// Token: 0x06005E62 RID: 24162 RVA: 0x0021D464 File Offset: 0x0021B664
		[NullableContext(1)]
		public Dictionary<string, string> Param11()
		{
			return this.Param11Iter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x06005E63 RID: 24163 RVA: 0x0021D4BA File Offset: 0x0021B6BA
		[NullableContext(1)]
		public IEnumerable<DicStringString> Param11Iter()
		{
			ConditionType.<Param11Iter>d__138 <Param11Iter>d__ = new ConditionType.<Param11Iter>d__138(-2);
			<Param11Iter>d__.<>3__<>4__this = this;
			return <Param11Iter>d__;
		}

		// Token: 0x06005E64 RID: 24164 RVA: 0x0021D4D0 File Offset: 0x0021B6D0
		[NullableContext(1)]
		public Dictionary<string, string> Param12()
		{
			return this.Param12Iter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x06005E65 RID: 24165 RVA: 0x0021D526 File Offset: 0x0021B726
		[NullableContext(1)]
		public IEnumerable<DicStringString> Param12Iter()
		{
			ConditionType.<Param12Iter>d__140 <Param12Iter>d__ = new ConditionType.<Param12Iter>d__140(-2);
			<Param12Iter>d__.<>3__<>4__this = this;
			return <Param12Iter>d__;
		}

		// Token: 0x06005E66 RID: 24166 RVA: 0x0021D53C File Offset: 0x0021B73C
		[NullableContext(1)]
		public Dictionary<string, string> Param13()
		{
			return this.Param13Iter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x06005E67 RID: 24167 RVA: 0x0021D592 File Offset: 0x0021B792
		[NullableContext(1)]
		public IEnumerable<DicStringString> Param13Iter()
		{
			ConditionType.<Param13Iter>d__142 <Param13Iter>d__ = new ConditionType.<Param13Iter>d__142(-2);
			<Param13Iter>d__.<>3__<>4__this = this;
			return <Param13Iter>d__;
		}

		// Token: 0x06005E68 RID: 24168 RVA: 0x0021D5A8 File Offset: 0x0021B7A8
		[NullableContext(1)]
		public Dictionary<string, string> Param14()
		{
			return this.Param14Iter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x06005E69 RID: 24169 RVA: 0x0021D5FE File Offset: 0x0021B7FE
		[NullableContext(1)]
		public IEnumerable<DicStringString> Param14Iter()
		{
			ConditionType.<Param14Iter>d__144 <Param14Iter>d__ = new ConditionType.<Param14Iter>d__144(-2);
			<Param14Iter>d__.<>3__<>4__this = this;
			return <Param14Iter>d__;
		}

		// Token: 0x06005E6A RID: 24170 RVA: 0x0021D614 File Offset: 0x0021B814
		[NullableContext(1)]
		public Dictionary<string, string> Param15()
		{
			return this.Param15Iter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x06005E6B RID: 24171 RVA: 0x0021D66A File Offset: 0x0021B86A
		[NullableContext(1)]
		public IEnumerable<DicStringString> Param15Iter()
		{
			ConditionType.<Param15Iter>d__146 <Param15Iter>d__ = new ConditionType.<Param15Iter>d__146(-2);
			<Param15Iter>d__.<>3__<>4__this = this;
			return <Param15Iter>d__;
		}

		// Token: 0x06005E6C RID: 24172 RVA: 0x0021D680 File Offset: 0x0021B880
		[NullableContext(1)]
		public Dictionary<string, string> Param16()
		{
			return this.Param16Iter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x06005E6D RID: 24173 RVA: 0x0021D6D6 File Offset: 0x0021B8D6
		[NullableContext(1)]
		public IEnumerable<DicStringString> Param16Iter()
		{
			ConditionType.<Param16Iter>d__148 <Param16Iter>d__ = new ConditionType.<Param16Iter>d__148(-2);
			<Param16Iter>d__.<>3__<>4__this = this;
			return <Param16Iter>d__;
		}

		// Token: 0x06005E6E RID: 24174 RVA: 0x0021D6EC File Offset: 0x0021B8EC
		[NullableContext(1)]
		public Dictionary<string, string> Param2()
		{
			return this.Param2Iter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x06005E6F RID: 24175 RVA: 0x0021D742 File Offset: 0x0021B942
		[NullableContext(1)]
		public IEnumerable<DicStringString> Param2Iter()
		{
			ConditionType.<Param2Iter>d__150 <Param2Iter>d__ = new ConditionType.<Param2Iter>d__150(-2);
			<Param2Iter>d__.<>3__<>4__this = this;
			return <Param2Iter>d__;
		}

		// Token: 0x06005E70 RID: 24176 RVA: 0x0021D758 File Offset: 0x0021B958
		[NullableContext(1)]
		public Dictionary<string, string> Param3()
		{
			return this.Param3Iter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x06005E71 RID: 24177 RVA: 0x0021D7AE File Offset: 0x0021B9AE
		[NullableContext(1)]
		public IEnumerable<DicStringString> Param3Iter()
		{
			ConditionType.<Param3Iter>d__152 <Param3Iter>d__ = new ConditionType.<Param3Iter>d__152(-2);
			<Param3Iter>d__.<>3__<>4__this = this;
			return <Param3Iter>d__;
		}

		// Token: 0x06005E72 RID: 24178 RVA: 0x0021D7C4 File Offset: 0x0021B9C4
		[NullableContext(1)]
		public Dictionary<string, string> Param4()
		{
			return this.Param4Iter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x06005E73 RID: 24179 RVA: 0x0021D81A File Offset: 0x0021BA1A
		[NullableContext(1)]
		public IEnumerable<DicStringString> Param4Iter()
		{
			ConditionType.<Param4Iter>d__154 <Param4Iter>d__ = new ConditionType.<Param4Iter>d__154(-2);
			<Param4Iter>d__.<>3__<>4__this = this;
			return <Param4Iter>d__;
		}

		// Token: 0x06005E74 RID: 24180 RVA: 0x0021D830 File Offset: 0x0021BA30
		[NullableContext(1)]
		public Dictionary<string, string> Param5()
		{
			return this.Param5Iter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x06005E75 RID: 24181 RVA: 0x0021D886 File Offset: 0x0021BA86
		[NullableContext(1)]
		public IEnumerable<DicStringString> Param5Iter()
		{
			ConditionType.<Param5Iter>d__156 <Param5Iter>d__ = new ConditionType.<Param5Iter>d__156(-2);
			<Param5Iter>d__.<>3__<>4__this = this;
			return <Param5Iter>d__;
		}

		// Token: 0x06005E76 RID: 24182 RVA: 0x0021D89C File Offset: 0x0021BA9C
		[NullableContext(1)]
		public Dictionary<string, string> Param6()
		{
			return this.Param6Iter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x06005E77 RID: 24183 RVA: 0x0021D8F2 File Offset: 0x0021BAF2
		[NullableContext(1)]
		public IEnumerable<DicStringString> Param6Iter()
		{
			ConditionType.<Param6Iter>d__158 <Param6Iter>d__ = new ConditionType.<Param6Iter>d__158(-2);
			<Param6Iter>d__.<>3__<>4__this = this;
			return <Param6Iter>d__;
		}

		// Token: 0x06005E78 RID: 24184 RVA: 0x0021D908 File Offset: 0x0021BB08
		[NullableContext(1)]
		public Dictionary<string, string> Param7()
		{
			return this.Param7Iter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x06005E79 RID: 24185 RVA: 0x0021D95E File Offset: 0x0021BB5E
		[NullableContext(1)]
		public IEnumerable<DicStringString> Param7Iter()
		{
			ConditionType.<Param7Iter>d__160 <Param7Iter>d__ = new ConditionType.<Param7Iter>d__160(-2);
			<Param7Iter>d__.<>3__<>4__this = this;
			return <Param7Iter>d__;
		}

		// Token: 0x06005E7A RID: 24186 RVA: 0x0021D974 File Offset: 0x0021BB74
		[NullableContext(1)]
		public Dictionary<string, string> Param8()
		{
			return this.Param8Iter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x06005E7B RID: 24187 RVA: 0x0021D9CA File Offset: 0x0021BBCA
		[NullableContext(1)]
		public IEnumerable<DicStringString> Param8Iter()
		{
			ConditionType.<Param8Iter>d__162 <Param8Iter>d__ = new ConditionType.<Param8Iter>d__162(-2);
			<Param8Iter>d__.<>3__<>4__this = this;
			return <Param8Iter>d__;
		}

		// Token: 0x06005E7C RID: 24188 RVA: 0x0021D9E0 File Offset: 0x0021BBE0
		[NullableContext(1)]
		public Dictionary<string, string> Param9()
		{
			return this.Param9Iter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x06005E7D RID: 24189 RVA: 0x0021DA36 File Offset: 0x0021BC36
		[NullableContext(1)]
		public IEnumerable<DicStringString> Param9Iter()
		{
			ConditionType.<Param9Iter>d__164 <Param9Iter>d__ = new ConditionType.<Param9Iter>d__164(-2);
			<Param9Iter>d__.<>3__<>4__this = this;
			return <Param9Iter>d__;
		}

		// Token: 0x06005E7E RID: 24190 RVA: 0x0021DA4B File Offset: 0x0021BC4B
		[NullableContext(1)]
		public int[] RegisterPlaces()
		{
			return this.GetRegisterPlacesArray();
		}

		// Token: 0x06005E7F RID: 24191 RVA: 0x0021DA53 File Offset: 0x0021BC53
		[NullableContext(1)]
		public IEnumerable<int> RegisterPlacesIter()
		{
			ConditionType.<RegisterPlacesIter>d__166 <RegisterPlacesIter>d__ = new ConditionType.<RegisterPlacesIter>d__166(-2);
			<RegisterPlacesIter>d__.<>3__<>4__this = this;
			return <RegisterPlacesIter>d__;
		}

		// Token: 0x06005E80 RID: 24192 RVA: 0x0021DA68 File Offset: 0x0021BC68
		[NullableContext(1)]
		[return: Nullable(2)]
		public string GetParam1(string key)
		{
			this.EnsureParam1CacheIfNeeded();
			string result;
			if (!this.Param1Cache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x06005E81 RID: 24193 RVA: 0x0021DA90 File Offset: 0x0021BC90
		[NullableContext(1)]
		[return: Nullable(2)]
		public string GetParam10(string key)
		{
			this.EnsureParam10CacheIfNeeded();
			string result;
			if (!this.Param10Cache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x06005E82 RID: 24194 RVA: 0x0021DAB8 File Offset: 0x0021BCB8
		[NullableContext(1)]
		[return: Nullable(2)]
		public string GetParam11(string key)
		{
			this.EnsureParam11CacheIfNeeded();
			string result;
			if (!this.Param11Cache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x06005E83 RID: 24195 RVA: 0x0021DAE0 File Offset: 0x0021BCE0
		[NullableContext(1)]
		[return: Nullable(2)]
		public string GetParam12(string key)
		{
			this.EnsureParam12CacheIfNeeded();
			string result;
			if (!this.Param12Cache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x06005E84 RID: 24196 RVA: 0x0021DB08 File Offset: 0x0021BD08
		[NullableContext(1)]
		[return: Nullable(2)]
		public string GetParam13(string key)
		{
			this.EnsureParam13CacheIfNeeded();
			string result;
			if (!this.Param13Cache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x06005E85 RID: 24197 RVA: 0x0021DB30 File Offset: 0x0021BD30
		[NullableContext(1)]
		[return: Nullable(2)]
		public string GetParam14(string key)
		{
			this.EnsureParam14CacheIfNeeded();
			string result;
			if (!this.Param14Cache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x06005E86 RID: 24198 RVA: 0x0021DB58 File Offset: 0x0021BD58
		[NullableContext(1)]
		[return: Nullable(2)]
		public string GetParam15(string key)
		{
			this.EnsureParam15CacheIfNeeded();
			string result;
			if (!this.Param15Cache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x06005E87 RID: 24199 RVA: 0x0021DB80 File Offset: 0x0021BD80
		[NullableContext(1)]
		[return: Nullable(2)]
		public string GetParam16(string key)
		{
			this.EnsureParam16CacheIfNeeded();
			string result;
			if (!this.Param16Cache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x06005E88 RID: 24200 RVA: 0x0021DBA8 File Offset: 0x0021BDA8
		[NullableContext(1)]
		[return: Nullable(2)]
		public string GetParam2(string key)
		{
			this.EnsureParam2CacheIfNeeded();
			string result;
			if (!this.Param2Cache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x06005E89 RID: 24201 RVA: 0x0021DBD0 File Offset: 0x0021BDD0
		[NullableContext(1)]
		[return: Nullable(2)]
		public string GetParam3(string key)
		{
			this.EnsureParam3CacheIfNeeded();
			string result;
			if (!this.Param3Cache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x06005E8A RID: 24202 RVA: 0x0021DBF8 File Offset: 0x0021BDF8
		[NullableContext(1)]
		[return: Nullable(2)]
		public string GetParam4(string key)
		{
			this.EnsureParam4CacheIfNeeded();
			string result;
			if (!this.Param4Cache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x06005E8B RID: 24203 RVA: 0x0021DC20 File Offset: 0x0021BE20
		[NullableContext(1)]
		[return: Nullable(2)]
		public string GetParam5(string key)
		{
			this.EnsureParam5CacheIfNeeded();
			string result;
			if (!this.Param5Cache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x06005E8C RID: 24204 RVA: 0x0021DC48 File Offset: 0x0021BE48
		[NullableContext(1)]
		[return: Nullable(2)]
		public string GetParam6(string key)
		{
			this.EnsureParam6CacheIfNeeded();
			string result;
			if (!this.Param6Cache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x06005E8D RID: 24205 RVA: 0x0021DC70 File Offset: 0x0021BE70
		[NullableContext(1)]
		[return: Nullable(2)]
		public string GetParam7(string key)
		{
			this.EnsureParam7CacheIfNeeded();
			string result;
			if (!this.Param7Cache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x06005E8E RID: 24206 RVA: 0x0021DC98 File Offset: 0x0021BE98
		[NullableContext(1)]
		[return: Nullable(2)]
		public string GetParam8(string key)
		{
			this.EnsureParam8CacheIfNeeded();
			string result;
			if (!this.Param8Cache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x06005E8F RID: 24207 RVA: 0x0021DCC0 File Offset: 0x0021BEC0
		[NullableContext(1)]
		[return: Nullable(2)]
		public string GetParam9(string key)
		{
			this.EnsureParam9CacheIfNeeded();
			string result;
			if (!this.Param9Cache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x06005E90 RID: 24208 RVA: 0x0021DCE8 File Offset: 0x0021BEE8
		private void EnsureParam1CacheIfNeeded()
		{
			if (this.Param1Cache != null)
			{
				return;
			}
			this.Param1Cache = this.Param1Iter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x06005E91 RID: 24209 RVA: 0x0021DD50 File Offset: 0x0021BF50
		private void EnsureParam10CacheIfNeeded()
		{
			if (this.Param10Cache != null)
			{
				return;
			}
			this.Param10Cache = this.Param10Iter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x06005E92 RID: 24210 RVA: 0x0021DDB8 File Offset: 0x0021BFB8
		private void EnsureParam11CacheIfNeeded()
		{
			if (this.Param11Cache != null)
			{
				return;
			}
			this.Param11Cache = this.Param11Iter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x06005E93 RID: 24211 RVA: 0x0021DE20 File Offset: 0x0021C020
		private void EnsureParam12CacheIfNeeded()
		{
			if (this.Param12Cache != null)
			{
				return;
			}
			this.Param12Cache = this.Param12Iter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x06005E94 RID: 24212 RVA: 0x0021DE88 File Offset: 0x0021C088
		private void EnsureParam13CacheIfNeeded()
		{
			if (this.Param13Cache != null)
			{
				return;
			}
			this.Param13Cache = this.Param13Iter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x06005E95 RID: 24213 RVA: 0x0021DEF0 File Offset: 0x0021C0F0
		private void EnsureParam14CacheIfNeeded()
		{
			if (this.Param14Cache != null)
			{
				return;
			}
			this.Param14Cache = this.Param14Iter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x06005E96 RID: 24214 RVA: 0x0021DF58 File Offset: 0x0021C158
		private void EnsureParam15CacheIfNeeded()
		{
			if (this.Param15Cache != null)
			{
				return;
			}
			this.Param15Cache = this.Param15Iter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x06005E97 RID: 24215 RVA: 0x0021DFC0 File Offset: 0x0021C1C0
		private void EnsureParam16CacheIfNeeded()
		{
			if (this.Param16Cache != null)
			{
				return;
			}
			this.Param16Cache = this.Param16Iter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x06005E98 RID: 24216 RVA: 0x0021E028 File Offset: 0x0021C228
		private void EnsureParam2CacheIfNeeded()
		{
			if (this.Param2Cache != null)
			{
				return;
			}
			this.Param2Cache = this.Param2Iter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x06005E99 RID: 24217 RVA: 0x0021E090 File Offset: 0x0021C290
		private void EnsureParam3CacheIfNeeded()
		{
			if (this.Param3Cache != null)
			{
				return;
			}
			this.Param3Cache = this.Param3Iter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x06005E9A RID: 24218 RVA: 0x0021E0F8 File Offset: 0x0021C2F8
		private void EnsureParam4CacheIfNeeded()
		{
			if (this.Param4Cache != null)
			{
				return;
			}
			this.Param4Cache = this.Param4Iter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x06005E9B RID: 24219 RVA: 0x0021E160 File Offset: 0x0021C360
		private void EnsureParam5CacheIfNeeded()
		{
			if (this.Param5Cache != null)
			{
				return;
			}
			this.Param5Cache = this.Param5Iter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x06005E9C RID: 24220 RVA: 0x0021E1C8 File Offset: 0x0021C3C8
		private void EnsureParam6CacheIfNeeded()
		{
			if (this.Param6Cache != null)
			{
				return;
			}
			this.Param6Cache = this.Param6Iter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x06005E9D RID: 24221 RVA: 0x0021E230 File Offset: 0x0021C430
		private void EnsureParam7CacheIfNeeded()
		{
			if (this.Param7Cache != null)
			{
				return;
			}
			this.Param7Cache = this.Param7Iter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x06005E9E RID: 24222 RVA: 0x0021E298 File Offset: 0x0021C498
		private void EnsureParam8CacheIfNeeded()
		{
			if (this.Param8Cache != null)
			{
				return;
			}
			this.Param8Cache = this.Param8Iter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x06005E9F RID: 24223 RVA: 0x0021E300 File Offset: 0x0021C500
		private void EnsureParam9CacheIfNeeded()
		{
			if (this.Param9Cache != null)
			{
				return;
			}
			this.Param9Cache = this.Param9Iter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x06005EA0 RID: 24224 RVA: 0x0021E366 File Offset: 0x0021C566
		[NullableContext(1)]
		public FrozenDictionary<string, string> GetParam1FrozenDict()
		{
			this.EnsureParam1CacheIfNeeded();
			return this.Param1Cache;
		}

		// Token: 0x06005EA1 RID: 24225 RVA: 0x0021E374 File Offset: 0x0021C574
		[NullableContext(1)]
		public FrozenDictionary<string, string> GetParam10FrozenDict()
		{
			this.EnsureParam10CacheIfNeeded();
			return this.Param10Cache;
		}

		// Token: 0x06005EA2 RID: 24226 RVA: 0x0021E382 File Offset: 0x0021C582
		[NullableContext(1)]
		public FrozenDictionary<string, string> GetParam11FrozenDict()
		{
			this.EnsureParam11CacheIfNeeded();
			return this.Param11Cache;
		}

		// Token: 0x06005EA3 RID: 24227 RVA: 0x0021E390 File Offset: 0x0021C590
		[NullableContext(1)]
		public FrozenDictionary<string, string> GetParam12FrozenDict()
		{
			this.EnsureParam12CacheIfNeeded();
			return this.Param12Cache;
		}

		// Token: 0x06005EA4 RID: 24228 RVA: 0x0021E39E File Offset: 0x0021C59E
		[NullableContext(1)]
		public FrozenDictionary<string, string> GetParam13FrozenDict()
		{
			this.EnsureParam13CacheIfNeeded();
			return this.Param13Cache;
		}

		// Token: 0x06005EA5 RID: 24229 RVA: 0x0021E3AC File Offset: 0x0021C5AC
		[NullableContext(1)]
		public FrozenDictionary<string, string> GetParam14FrozenDict()
		{
			this.EnsureParam14CacheIfNeeded();
			return this.Param14Cache;
		}

		// Token: 0x06005EA6 RID: 24230 RVA: 0x0021E3BA File Offset: 0x0021C5BA
		[NullableContext(1)]
		public FrozenDictionary<string, string> GetParam15FrozenDict()
		{
			this.EnsureParam15CacheIfNeeded();
			return this.Param15Cache;
		}

		// Token: 0x06005EA7 RID: 24231 RVA: 0x0021E3C8 File Offset: 0x0021C5C8
		[NullableContext(1)]
		public FrozenDictionary<string, string> GetParam16FrozenDict()
		{
			this.EnsureParam16CacheIfNeeded();
			return this.Param16Cache;
		}

		// Token: 0x06005EA8 RID: 24232 RVA: 0x0021E3D6 File Offset: 0x0021C5D6
		[NullableContext(1)]
		public FrozenDictionary<string, string> GetParam2FrozenDict()
		{
			this.EnsureParam2CacheIfNeeded();
			return this.Param2Cache;
		}

		// Token: 0x06005EA9 RID: 24233 RVA: 0x0021E3E4 File Offset: 0x0021C5E4
		[NullableContext(1)]
		public FrozenDictionary<string, string> GetParam3FrozenDict()
		{
			this.EnsureParam3CacheIfNeeded();
			return this.Param3Cache;
		}

		// Token: 0x06005EAA RID: 24234 RVA: 0x0021E3F2 File Offset: 0x0021C5F2
		[NullableContext(1)]
		public FrozenDictionary<string, string> GetParam4FrozenDict()
		{
			this.EnsureParam4CacheIfNeeded();
			return this.Param4Cache;
		}

		// Token: 0x06005EAB RID: 24235 RVA: 0x0021E400 File Offset: 0x0021C600
		[NullableContext(1)]
		public FrozenDictionary<string, string> GetParam5FrozenDict()
		{
			this.EnsureParam5CacheIfNeeded();
			return this.Param5Cache;
		}

		// Token: 0x06005EAC RID: 24236 RVA: 0x0021E40E File Offset: 0x0021C60E
		[NullableContext(1)]
		public FrozenDictionary<string, string> GetParam6FrozenDict()
		{
			this.EnsureParam6CacheIfNeeded();
			return this.Param6Cache;
		}

		// Token: 0x06005EAD RID: 24237 RVA: 0x0021E41C File Offset: 0x0021C61C
		[NullableContext(1)]
		public FrozenDictionary<string, string> GetParam7FrozenDict()
		{
			this.EnsureParam7CacheIfNeeded();
			return this.Param7Cache;
		}

		// Token: 0x06005EAE RID: 24238 RVA: 0x0021E42A File Offset: 0x0021C62A
		[NullableContext(1)]
		public FrozenDictionary<string, string> GetParam8FrozenDict()
		{
			this.EnsureParam8CacheIfNeeded();
			return this.Param8Cache;
		}

		// Token: 0x06005EAF RID: 24239 RVA: 0x0021E438 File Offset: 0x0021C638
		[NullableContext(1)]
		public FrozenDictionary<string, string> GetParam9FrozenDict()
		{
			this.EnsureParam9CacheIfNeeded();
			return this.Param9Cache;
		}

		// Token: 0x04005189 RID: 20873
		private Table __p;

		// Token: 0x0400518A RID: 20874
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> Param1Cache;

		// Token: 0x0400518B RID: 20875
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> Param10Cache;

		// Token: 0x0400518C RID: 20876
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> Param11Cache;

		// Token: 0x0400518D RID: 20877
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> Param12Cache;

		// Token: 0x0400518E RID: 20878
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> Param13Cache;

		// Token: 0x0400518F RID: 20879
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> Param14Cache;

		// Token: 0x04005190 RID: 20880
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> Param15Cache;

		// Token: 0x04005191 RID: 20881
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> Param16Cache;

		// Token: 0x04005192 RID: 20882
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> Param2Cache;

		// Token: 0x04005193 RID: 20883
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> Param3Cache;

		// Token: 0x04005194 RID: 20884
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> Param4Cache;

		// Token: 0x04005195 RID: 20885
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> Param5Cache;

		// Token: 0x04005196 RID: 20886
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> Param6Cache;

		// Token: 0x04005197 RID: 20887
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> Param7Cache;

		// Token: 0x04005198 RID: 20888
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> Param8Cache;

		// Token: 0x04005199 RID: 20889
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> Param9Cache;
	}
}

using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CA0 RID: 3232
	public struct DangoBrawlChallenge : IFlatbufferObject
	{
		// Token: 0x17000AF6 RID: 2806
		// (get) Token: 0x060062D3 RID: 25299 RVA: 0x00227648 File Offset: 0x00225848
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060062D4 RID: 25300 RVA: 0x00227655 File Offset: 0x00225855
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060062D5 RID: 25301 RVA: 0x0022765C File Offset: 0x0022585C
		public static DangoBrawlChallenge GetRootAsDangoBrawlChallenge(ByteBuffer _bb)
		{
			return DangoBrawlChallenge.GetRootAsDangoBrawlChallenge(_bb, default(DangoBrawlChallenge));
		}

		// Token: 0x060062D6 RID: 25302 RVA: 0x00227678 File Offset: 0x00225878
		public static DangoBrawlChallenge GetRootAsDangoBrawlChallenge(ByteBuffer _bb, DangoBrawlChallenge obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060062D7 RID: 25303 RVA: 0x00227695 File Offset: 0x00225895
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060062D8 RID: 25304 RVA: 0x002276A4 File Offset: 0x002258A4
		public DangoBrawlChallenge __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000AF7 RID: 2807
		// (get) Token: 0x060062D9 RID: 25305 RVA: 0x002276B4 File Offset: 0x002258B4
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

		// Token: 0x17000AF8 RID: 2808
		// (get) Token: 0x060062DA RID: 25306 RVA: 0x002276F0 File Offset: 0x002258F0
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

		// Token: 0x17000AF9 RID: 2809
		// (get) Token: 0x060062DB RID: 25307 RVA: 0x0022772C File Offset: 0x0022592C
		public int PreChallenge
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

		// Token: 0x17000AFA RID: 2810
		// (get) Token: 0x060062DC RID: 25308 RVA: 0x00227768 File Offset: 0x00225968
		public string SimpleName
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

		// Token: 0x060062DD RID: 25309 RVA: 0x002277A0 File Offset: 0x002259A0
		public Span<byte> GetSimpleNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060062DE RID: 25310 RVA: 0x002277B0 File Offset: 0x002259B0
		public byte[] GetSimpleNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000AFB RID: 2811
		// (get) Token: 0x060062DF RID: 25311 RVA: 0x002277C8 File Offset: 0x002259C8
		public string Name
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060062E0 RID: 25312 RVA: 0x00227800 File Offset: 0x00225A00
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x060062E1 RID: 25313 RVA: 0x00227810 File Offset: 0x00225A10
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17000AFC RID: 2812
		// (get) Token: 0x060062E2 RID: 25314 RVA: 0x00227828 File Offset: 0x00225A28
		public string Icon
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

		// Token: 0x060062E3 RID: 25315 RVA: 0x00227860 File Offset: 0x00225A60
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x060062E4 RID: 25316 RVA: 0x00227870 File Offset: 0x00225A70
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17000AFD RID: 2813
		// (get) Token: 0x060062E5 RID: 25317 RVA: 0x00227888 File Offset: 0x00225A88
		public string SelIcon
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060062E6 RID: 25318 RVA: 0x002278C0 File Offset: 0x00225AC0
		public Span<byte> GetSelIconBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x060062E7 RID: 25319 RVA: 0x002278D0 File Offset: 0x00225AD0
		public byte[] GetSelIconArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17000AFE RID: 2814
		// (get) Token: 0x060062E8 RID: 25320 RVA: 0x002278E8 File Offset: 0x00225AE8
		public string BgNumIcon
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

		// Token: 0x060062E9 RID: 25321 RVA: 0x00227920 File Offset: 0x00225B20
		public Span<byte> GetBgNumIconBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x060062EA RID: 25322 RVA: 0x00227930 File Offset: 0x00225B30
		public byte[] GetBgNumIconArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17000AFF RID: 2815
		// (get) Token: 0x060062EB RID: 25323 RVA: 0x00227948 File Offset: 0x00225B48
		public string Desc
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060062EC RID: 25324 RVA: 0x00227980 File Offset: 0x00225B80
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x060062ED RID: 25325 RVA: 0x00227990 File Offset: 0x00225B90
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17000B00 RID: 2816
		// (get) Token: 0x060062EE RID: 25326 RVA: 0x002279A8 File Offset: 0x00225BA8
		public int FirstClearDropId
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

		// Token: 0x060062EF RID: 25327 RVA: 0x002279E8 File Offset: 0x00225BE8
		public int UnlockRoleId(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000B01 RID: 2817
		// (get) Token: 0x060062F0 RID: 25328 RVA: 0x00227A28 File Offset: 0x00225C28
		public int UnlockRoleIdLength
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

		// Token: 0x060062F1 RID: 25329 RVA: 0x00227A54 File Offset: 0x00225C54
		public Span<int> GetUnlockRoleIdBytes()
		{
			return this.__p.__vector_as_span<int>(24, 4);
		}

		// Token: 0x060062F2 RID: 25330 RVA: 0x00227A64 File Offset: 0x00225C64
		public int[] GetUnlockRoleIdArray()
		{
			return this.__p.__vector_as_array<int>(24) ?? Array.Empty<int>();
		}

		// Token: 0x060062F3 RID: 25331 RVA: 0x00227A7C File Offset: 0x00225C7C
		public int RecommendRoleId(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000B02 RID: 2818
		// (get) Token: 0x060062F4 RID: 25332 RVA: 0x00227ABC File Offset: 0x00225CBC
		public int RecommendRoleIdLength
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

		// Token: 0x060062F5 RID: 25333 RVA: 0x00227AE8 File Offset: 0x00225CE8
		public Span<int> GetRecommendRoleIdBytes()
		{
			return this.__p.__vector_as_span<int>(26, 4);
		}

		// Token: 0x060062F6 RID: 25334 RVA: 0x00227AF8 File Offset: 0x00225CF8
		public int[] GetRecommendRoleIdArray()
		{
			return this.__p.__vector_as_array<int>(26) ?? Array.Empty<int>();
		}

		// Token: 0x17000B03 RID: 2819
		// (get) Token: 0x060062F7 RID: 25335 RVA: 0x00227B10 File Offset: 0x00225D10
		public int BgStyle
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000B04 RID: 2820
		// (get) Token: 0x060062F8 RID: 25336 RVA: 0x00227B50 File Offset: 0x00225D50
		public int Mode
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060062F9 RID: 25337 RVA: 0x00227B90 File Offset: 0x00225D90
		public string SpineAtlasPaths(int j)
		{
			int num = this.__p.__offset(32);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000B05 RID: 2821
		// (get) Token: 0x060062FA RID: 25338 RVA: 0x00227BCC File Offset: 0x00225DCC
		public int SpineAtlasPathsLength
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

		// Token: 0x060062FB RID: 25339 RVA: 0x00227BF8 File Offset: 0x00225DF8
		public string SpineSkeletonDataPaths(int j)
		{
			int num = this.__p.__offset(34);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000B06 RID: 2822
		// (get) Token: 0x060062FC RID: 25340 RVA: 0x00227C34 File Offset: 0x00225E34
		public int SpineSkeletonDataPathsLength
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060062FD RID: 25341 RVA: 0x00227C60 File Offset: 0x00225E60
		public string SpineNormalAnims(int j)
		{
			int num = this.__p.__offset(36);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000B07 RID: 2823
		// (get) Token: 0x060062FE RID: 25342 RVA: 0x00227C9C File Offset: 0x00225E9C
		public int SpineNormalAnimsLength
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

		// Token: 0x060062FF RID: 25343 RVA: 0x00227CC8 File Offset: 0x00225EC8
		public string SpineLoopAnims(int j)
		{
			int num = this.__p.__offset(38);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000B08 RID: 2824
		// (get) Token: 0x06006300 RID: 25344 RVA: 0x00227D04 File Offset: 0x00225F04
		public int SpineLoopAnimsLength
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17000B09 RID: 2825
		// (get) Token: 0x06006301 RID: 25345 RVA: 0x00227D30 File Offset: 0x00225F30
		public string AdventureRoleIcon1
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006302 RID: 25346 RVA: 0x00227D68 File Offset: 0x00225F68
		public Span<byte> GetAdventureRoleIcon1Bytes()
		{
			return this.__p.__vector_as_span<byte>(40, 1);
		}

		// Token: 0x06006303 RID: 25347 RVA: 0x00227D78 File Offset: 0x00225F78
		public byte[] GetAdventureRoleIcon1Array()
		{
			return this.__p.__vector_as_array<byte>(40) ?? Array.Empty<byte>();
		}

		// Token: 0x17000B0A RID: 2826
		// (get) Token: 0x06006304 RID: 25348 RVA: 0x00227D90 File Offset: 0x00225F90
		public string AdventureRoleIcon2
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

		// Token: 0x06006305 RID: 25349 RVA: 0x00227DC8 File Offset: 0x00225FC8
		public Span<byte> GetAdventureRoleIcon2Bytes()
		{
			return this.__p.__vector_as_span<byte>(42, 1);
		}

		// Token: 0x06006306 RID: 25350 RVA: 0x00227DD8 File Offset: 0x00225FD8
		public byte[] GetAdventureRoleIcon2Array()
		{
			return this.__p.__vector_as_array<byte>(42) ?? Array.Empty<byte>();
		}

		// Token: 0x17000B0B RID: 2827
		// (get) Token: 0x06006307 RID: 25351 RVA: 0x00227DF0 File Offset: 0x00225FF0
		public string EnvirDesc
		{
			get
			{
				int num = this.__p.__offset(44);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006308 RID: 25352 RVA: 0x00227E28 File Offset: 0x00226028
		public Span<byte> GetEnvirDescBytes()
		{
			return this.__p.__vector_as_span<byte>(44, 1);
		}

		// Token: 0x06006309 RID: 25353 RVA: 0x00227E38 File Offset: 0x00226038
		public byte[] GetEnvirDescArray()
		{
			return this.__p.__vector_as_array<byte>(44) ?? Array.Empty<byte>();
		}

		// Token: 0x17000B0C RID: 2828
		// (get) Token: 0x0600630A RID: 25354 RVA: 0x00227E50 File Offset: 0x00226050
		public string PassCondDesc
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

		// Token: 0x0600630B RID: 25355 RVA: 0x00227E88 File Offset: 0x00226088
		public Span<byte> GetPassCondDescBytes()
		{
			return this.__p.__vector_as_span<byte>(46, 1);
		}

		// Token: 0x0600630C RID: 25356 RVA: 0x00227E98 File Offset: 0x00226098
		public byte[] GetPassCondDescArray()
		{
			return this.__p.__vector_as_array<byte>(46) ?? Array.Empty<byte>();
		}

		// Token: 0x17000B0D RID: 2829
		// (get) Token: 0x0600630D RID: 25357 RVA: 0x00227EB0 File Offset: 0x002260B0
		public string UnlockCondDesc
		{
			get
			{
				int num = this.__p.__offset(48);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600630E RID: 25358 RVA: 0x00227EE8 File Offset: 0x002260E8
		public Span<byte> GetUnlockCondDescBytes()
		{
			return this.__p.__vector_as_span<byte>(48, 1);
		}

		// Token: 0x0600630F RID: 25359 RVA: 0x00227EF8 File Offset: 0x002260F8
		public byte[] GetUnlockCondDescArray()
		{
			return this.__p.__vector_as_array<byte>(48) ?? Array.Empty<byte>();
		}

		// Token: 0x17000B0E RID: 2830
		// (get) Token: 0x06006310 RID: 25360 RVA: 0x00227F10 File Offset: 0x00226110
		public int InstanceId
		{
			get
			{
				int num = this.__p.__offset(50);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000B0F RID: 2831
		// (get) Token: 0x06006311 RID: 25361 RVA: 0x00227F50 File Offset: 0x00226150
		public int WinCount
		{
			get
			{
				int num = this.__p.__offset(52);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000B10 RID: 2832
		// (get) Token: 0x06006312 RID: 25362 RVA: 0x00227F90 File Offset: 0x00226190
		public int HpCount
		{
			get
			{
				int num = this.__p.__offset(54);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006313 RID: 25363 RVA: 0x00227FD0 File Offset: 0x002261D0
		public int RoundList(int j)
		{
			int num = this.__p.__offset(56);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000B11 RID: 2833
		// (get) Token: 0x06006314 RID: 25364 RVA: 0x00228010 File Offset: 0x00226210
		public int RoundListLength
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

		// Token: 0x06006315 RID: 25365 RVA: 0x0022803C File Offset: 0x0022623C
		public Span<int> GetRoundListBytes()
		{
			return this.__p.__vector_as_span<int>(56, 4);
		}

		// Token: 0x06006316 RID: 25366 RVA: 0x0022804C File Offset: 0x0022624C
		public int[] GetRoundListArray()
		{
			return this.__p.__vector_as_array<int>(56) ?? Array.Empty<int>();
		}

		// Token: 0x17000B12 RID: 2834
		// (get) Token: 0x06006317 RID: 25367 RVA: 0x00228064 File Offset: 0x00226264
		public int DefaultRoleId
		{
			get
			{
				int num = this.__p.__offset(58);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000B13 RID: 2835
		// (get) Token: 0x06006318 RID: 25368 RVA: 0x002280A4 File Offset: 0x002262A4
		public int ShopRefreshCostId
		{
			get
			{
				int num = this.__p.__offset(60);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006319 RID: 25369 RVA: 0x002280E4 File Offset: 0x002262E4
		public int FatigueConfig(int j)
		{
			int num = this.__p.__offset(62);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000B14 RID: 2836
		// (get) Token: 0x0600631A RID: 25370 RVA: 0x00228124 File Offset: 0x00226324
		public int FatigueConfigLength
		{
			get
			{
				int num = this.__p.__offset(62);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600631B RID: 25371 RVA: 0x00228150 File Offset: 0x00226350
		public Span<int> GetFatigueConfigBytes()
		{
			return this.__p.__vector_as_span<int>(62, 4);
		}

		// Token: 0x0600631C RID: 25372 RVA: 0x00228160 File Offset: 0x00226360
		public int[] GetFatigueConfigArray()
		{
			return this.__p.__vector_as_array<int>(62) ?? Array.Empty<int>();
		}

		// Token: 0x17000B15 RID: 2837
		// (get) Token: 0x0600631D RID: 25373 RVA: 0x00228178 File Offset: 0x00226378
		public int AdditionRound
		{
			get
			{
				int num = this.__p.__offset(64);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600631E RID: 25374 RVA: 0x002281B8 File Offset: 0x002263B8
		public DicIntInt? ShopDiscount(int j)
		{
			int num = this.__p.__offset(66);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000B16 RID: 2838
		// (get) Token: 0x0600631F RID: 25375 RVA: 0x0022821C File Offset: 0x0022641C
		public int ShopDiscountLength
		{
			get
			{
				int num = this.__p.__offset(66);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06006320 RID: 25376 RVA: 0x00228248 File Offset: 0x00226448
		public DicIntInt? RecommendQuality(int j)
		{
			int num = this.__p.__offset(68);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000B17 RID: 2839
		// (get) Token: 0x06006321 RID: 25377 RVA: 0x002282AC File Offset: 0x002264AC
		public int RecommendQualityLength
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

		// Token: 0x06006322 RID: 25378 RVA: 0x002282D8 File Offset: 0x002264D8
		[NullableContext(1)]
		public int[] FatigueConfig()
		{
			return this.GetFatigueConfigArray();
		}

		// Token: 0x06006323 RID: 25379 RVA: 0x002282E0 File Offset: 0x002264E0
		[NullableContext(1)]
		public IEnumerable<int> FatigueConfigIter()
		{
			DangoBrawlChallenge.<FatigueConfigIter>d__115 <FatigueConfigIter>d__ = new DangoBrawlChallenge.<FatigueConfigIter>d__115(-2);
			<FatigueConfigIter>d__.<>3__<>4__this = this;
			return <FatigueConfigIter>d__;
		}

		// Token: 0x06006324 RID: 25380 RVA: 0x002282F8 File Offset: 0x002264F8
		[NullableContext(1)]
		public Dictionary<int, int> RecommendQuality()
		{
			return this.RecommendQualityIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06006325 RID: 25381 RVA: 0x0022834E File Offset: 0x0022654E
		[NullableContext(1)]
		public IEnumerable<DicIntInt> RecommendQualityIter()
		{
			DangoBrawlChallenge.<RecommendQualityIter>d__117 <RecommendQualityIter>d__ = new DangoBrawlChallenge.<RecommendQualityIter>d__117(-2);
			<RecommendQualityIter>d__.<>3__<>4__this = this;
			return <RecommendQualityIter>d__;
		}

		// Token: 0x06006326 RID: 25382 RVA: 0x00228363 File Offset: 0x00226563
		[NullableContext(1)]
		public int[] RecommendRoleId()
		{
			return this.GetRecommendRoleIdArray();
		}

		// Token: 0x06006327 RID: 25383 RVA: 0x0022836B File Offset: 0x0022656B
		[NullableContext(1)]
		public IEnumerable<int> RecommendRoleIdIter()
		{
			DangoBrawlChallenge.<RecommendRoleIdIter>d__119 <RecommendRoleIdIter>d__ = new DangoBrawlChallenge.<RecommendRoleIdIter>d__119(-2);
			<RecommendRoleIdIter>d__.<>3__<>4__this = this;
			return <RecommendRoleIdIter>d__;
		}

		// Token: 0x06006328 RID: 25384 RVA: 0x00228380 File Offset: 0x00226580
		[NullableContext(1)]
		public int[] RoundList()
		{
			return this.GetRoundListArray();
		}

		// Token: 0x06006329 RID: 25385 RVA: 0x00228388 File Offset: 0x00226588
		[NullableContext(1)]
		public IEnumerable<int> RoundListIter()
		{
			DangoBrawlChallenge.<RoundListIter>d__121 <RoundListIter>d__ = new DangoBrawlChallenge.<RoundListIter>d__121(-2);
			<RoundListIter>d__.<>3__<>4__this = this;
			return <RoundListIter>d__;
		}

		// Token: 0x0600632A RID: 25386 RVA: 0x002283A0 File Offset: 0x002265A0
		[NullableContext(1)]
		public Dictionary<int, int> ShopDiscount()
		{
			return this.ShopDiscountIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600632B RID: 25387 RVA: 0x002283F6 File Offset: 0x002265F6
		[NullableContext(1)]
		public IEnumerable<DicIntInt> ShopDiscountIter()
		{
			DangoBrawlChallenge.<ShopDiscountIter>d__123 <ShopDiscountIter>d__ = new DangoBrawlChallenge.<ShopDiscountIter>d__123(-2);
			<ShopDiscountIter>d__.<>3__<>4__this = this;
			return <ShopDiscountIter>d__;
		}

		// Token: 0x0600632C RID: 25388 RVA: 0x0022840B File Offset: 0x0022660B
		[NullableContext(1)]
		public string[] SpineAtlasPaths()
		{
			return this.SpineAtlasPathsIter().ToArray<string>();
		}

		// Token: 0x0600632D RID: 25389 RVA: 0x00228418 File Offset: 0x00226618
		[NullableContext(1)]
		public IEnumerable<string> SpineAtlasPathsIter()
		{
			DangoBrawlChallenge.<SpineAtlasPathsIter>d__125 <SpineAtlasPathsIter>d__ = new DangoBrawlChallenge.<SpineAtlasPathsIter>d__125(-2);
			<SpineAtlasPathsIter>d__.<>3__<>4__this = this;
			return <SpineAtlasPathsIter>d__;
		}

		// Token: 0x0600632E RID: 25390 RVA: 0x0022842D File Offset: 0x0022662D
		[NullableContext(1)]
		public string[] SpineLoopAnims()
		{
			return this.SpineLoopAnimsIter().ToArray<string>();
		}

		// Token: 0x0600632F RID: 25391 RVA: 0x0022843A File Offset: 0x0022663A
		[NullableContext(1)]
		public IEnumerable<string> SpineLoopAnimsIter()
		{
			DangoBrawlChallenge.<SpineLoopAnimsIter>d__127 <SpineLoopAnimsIter>d__ = new DangoBrawlChallenge.<SpineLoopAnimsIter>d__127(-2);
			<SpineLoopAnimsIter>d__.<>3__<>4__this = this;
			return <SpineLoopAnimsIter>d__;
		}

		// Token: 0x06006330 RID: 25392 RVA: 0x0022844F File Offset: 0x0022664F
		[NullableContext(1)]
		public string[] SpineNormalAnims()
		{
			return this.SpineNormalAnimsIter().ToArray<string>();
		}

		// Token: 0x06006331 RID: 25393 RVA: 0x0022845C File Offset: 0x0022665C
		[NullableContext(1)]
		public IEnumerable<string> SpineNormalAnimsIter()
		{
			DangoBrawlChallenge.<SpineNormalAnimsIter>d__129 <SpineNormalAnimsIter>d__ = new DangoBrawlChallenge.<SpineNormalAnimsIter>d__129(-2);
			<SpineNormalAnimsIter>d__.<>3__<>4__this = this;
			return <SpineNormalAnimsIter>d__;
		}

		// Token: 0x06006332 RID: 25394 RVA: 0x00228471 File Offset: 0x00226671
		[NullableContext(1)]
		public string[] SpineSkeletonDataPaths()
		{
			return this.SpineSkeletonDataPathsIter().ToArray<string>();
		}

		// Token: 0x06006333 RID: 25395 RVA: 0x0022847E File Offset: 0x0022667E
		[NullableContext(1)]
		public IEnumerable<string> SpineSkeletonDataPathsIter()
		{
			DangoBrawlChallenge.<SpineSkeletonDataPathsIter>d__131 <SpineSkeletonDataPathsIter>d__ = new DangoBrawlChallenge.<SpineSkeletonDataPathsIter>d__131(-2);
			<SpineSkeletonDataPathsIter>d__.<>3__<>4__this = this;
			return <SpineSkeletonDataPathsIter>d__;
		}

		// Token: 0x06006334 RID: 25396 RVA: 0x00228493 File Offset: 0x00226693
		[NullableContext(1)]
		public int[] UnlockRoleId()
		{
			return this.GetUnlockRoleIdArray();
		}

		// Token: 0x06006335 RID: 25397 RVA: 0x0022849B File Offset: 0x0022669B
		[NullableContext(1)]
		public IEnumerable<int> UnlockRoleIdIter()
		{
			DangoBrawlChallenge.<UnlockRoleIdIter>d__133 <UnlockRoleIdIter>d__ = new DangoBrawlChallenge.<UnlockRoleIdIter>d__133(-2);
			<UnlockRoleIdIter>d__.<>3__<>4__this = this;
			return <UnlockRoleIdIter>d__;
		}

		// Token: 0x06006336 RID: 25398 RVA: 0x002284B0 File Offset: 0x002266B0
		public int? GetRecommendQuality(int key)
		{
			this.EnsureRecommendQualityCacheIfNeeded();
			int value;
			if (!this.RecommendQualityCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x06006337 RID: 25399 RVA: 0x002284E4 File Offset: 0x002266E4
		public int? GetShopDiscount(int key)
		{
			this.EnsureShopDiscountCacheIfNeeded();
			int value;
			if (!this.ShopDiscountCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x06006338 RID: 25400 RVA: 0x00228518 File Offset: 0x00226718
		private void EnsureRecommendQualityCacheIfNeeded()
		{
			if (this.RecommendQualityCache != null)
			{
				return;
			}
			this.RecommendQualityCache = this.RecommendQualityIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06006339 RID: 25401 RVA: 0x00228580 File Offset: 0x00226780
		private void EnsureShopDiscountCacheIfNeeded()
		{
			if (this.ShopDiscountCache != null)
			{
				return;
			}
			this.ShopDiscountCache = this.ShopDiscountIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600633A RID: 25402 RVA: 0x002285E6 File Offset: 0x002267E6
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetRecommendQualityFrozenDict()
		{
			this.EnsureRecommendQualityCacheIfNeeded();
			return this.RecommendQualityCache;
		}

		// Token: 0x0600633B RID: 25403 RVA: 0x002285F4 File Offset: 0x002267F4
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetShopDiscountFrozenDict()
		{
			this.EnsureShopDiscountCacheIfNeeded();
			return this.ShopDiscountCache;
		}

		// Token: 0x040051C7 RID: 20935
		private Table __p;

		// Token: 0x040051C8 RID: 20936
		[Nullable(2)]
		private FrozenDictionary<int, int> RecommendQualityCache;

		// Token: 0x040051C9 RID: 20937
		[Nullable(2)]
		private FrozenDictionary<int, int> ShopDiscountCache;
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DA2 RID: 3490
	public struct KurotatoLevel : IFlatbufferObject
	{
		// Token: 0x17001B91 RID: 7057
		// (get) Token: 0x060089DE RID: 35294 RVA: 0x0026EA4F File Offset: 0x0026CC4F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060089DF RID: 35295 RVA: 0x0026EA5C File Offset: 0x0026CC5C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060089E0 RID: 35296 RVA: 0x0026EA64 File Offset: 0x0026CC64
		public static KurotatoLevel GetRootAsKurotatoLevel(ByteBuffer _bb)
		{
			return KurotatoLevel.GetRootAsKurotatoLevel(_bb, default(KurotatoLevel));
		}

		// Token: 0x060089E1 RID: 35297 RVA: 0x0026EA80 File Offset: 0x0026CC80
		public static KurotatoLevel GetRootAsKurotatoLevel(ByteBuffer _bb, KurotatoLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060089E2 RID: 35298 RVA: 0x0026EA9D File Offset: 0x0026CC9D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060089E3 RID: 35299 RVA: 0x0026EAAC File Offset: 0x0026CCAC
		public KurotatoLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001B92 RID: 7058
		// (get) Token: 0x060089E4 RID: 35300 RVA: 0x0026EABC File Offset: 0x0026CCBC
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

		// Token: 0x17001B93 RID: 7059
		// (get) Token: 0x060089E5 RID: 35301 RVA: 0x0026EAF8 File Offset: 0x0026CCF8
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

		// Token: 0x17001B94 RID: 7060
		// (get) Token: 0x060089E6 RID: 35302 RVA: 0x0026EB34 File Offset: 0x0026CD34
		public int Difficulty
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

		// Token: 0x17001B95 RID: 7061
		// (get) Token: 0x060089E7 RID: 35303 RVA: 0x0026EB70 File Offset: 0x0026CD70
		public int SecondGroup
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001B96 RID: 7062
		// (get) Token: 0x060089E8 RID: 35304 RVA: 0x0026EBB0 File Offset: 0x0026CDB0
		public int InstId
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

		// Token: 0x17001B97 RID: 7063
		// (get) Token: 0x060089E9 RID: 35305 RVA: 0x0026EBF0 File Offset: 0x0026CDF0
		public int LevelGroup
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

		// Token: 0x17001B98 RID: 7064
		// (get) Token: 0x060089EA RID: 35306 RVA: 0x0026EC30 File Offset: 0x0026CE30
		public int SortId
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

		// Token: 0x17001B99 RID: 7065
		// (get) Token: 0x060089EB RID: 35307 RVA: 0x0026EC70 File Offset: 0x0026CE70
		public int PerId
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060089EC RID: 35308 RVA: 0x0026ECB0 File Offset: 0x0026CEB0
		public int Characters(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001B9A RID: 7066
		// (get) Token: 0x060089ED RID: 35309 RVA: 0x0026ECF0 File Offset: 0x0026CEF0
		public int CharactersLength
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

		// Token: 0x060089EE RID: 35310 RVA: 0x0026ED1C File Offset: 0x0026CF1C
		public Span<int> GetCharactersBytes()
		{
			return this.__p.__vector_as_span<int>(20, 4);
		}

		// Token: 0x060089EF RID: 35311 RVA: 0x0026ED2C File Offset: 0x0026CF2C
		public int[] GetCharactersArray()
		{
			return this.__p.__vector_as_array<int>(20) ?? Array.Empty<int>();
		}

		// Token: 0x060089F0 RID: 35312 RVA: 0x0026ED44 File Offset: 0x0026CF44
		public int RecommendCharacters(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001B9B RID: 7067
		// (get) Token: 0x060089F1 RID: 35313 RVA: 0x0026ED84 File Offset: 0x0026CF84
		public int RecommendCharactersLength
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

		// Token: 0x060089F2 RID: 35314 RVA: 0x0026EDB0 File Offset: 0x0026CFB0
		public Span<int> GetRecommendCharactersBytes()
		{
			return this.__p.__vector_as_span<int>(22, 4);
		}

		// Token: 0x060089F3 RID: 35315 RVA: 0x0026EDC0 File Offset: 0x0026CFC0
		public int[] GetRecommendCharactersArray()
		{
			return this.__p.__vector_as_array<int>(22) ?? Array.Empty<int>();
		}

		// Token: 0x060089F4 RID: 35316 RVA: 0x0026EDD8 File Offset: 0x0026CFD8
		public int SaveWaveIds(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001B9C RID: 7068
		// (get) Token: 0x060089F5 RID: 35317 RVA: 0x0026EE18 File Offset: 0x0026D018
		public int SaveWaveIdsLength
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

		// Token: 0x060089F6 RID: 35318 RVA: 0x0026EE44 File Offset: 0x0026D044
		public Span<int> GetSaveWaveIdsBytes()
		{
			return this.__p.__vector_as_span<int>(24, 4);
		}

		// Token: 0x060089F7 RID: 35319 RVA: 0x0026EE54 File Offset: 0x0026D054
		public int[] GetSaveWaveIdsArray()
		{
			return this.__p.__vector_as_array<int>(24) ?? Array.Empty<int>();
		}

		// Token: 0x060089F8 RID: 35320 RVA: 0x0026EE6C File Offset: 0x0026D06C
		public int TargetWaveIds(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001B9D RID: 7069
		// (get) Token: 0x060089F9 RID: 35321 RVA: 0x0026EEAC File Offset: 0x0026D0AC
		public int TargetWaveIdsLength
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

		// Token: 0x060089FA RID: 35322 RVA: 0x0026EED8 File Offset: 0x0026D0D8
		public Span<int> GetTargetWaveIdsBytes()
		{
			return this.__p.__vector_as_span<int>(26, 4);
		}

		// Token: 0x060089FB RID: 35323 RVA: 0x0026EEE8 File Offset: 0x0026D0E8
		public int[] GetTargetWaveIdsArray()
		{
			return this.__p.__vector_as_array<int>(26) ?? Array.Empty<int>();
		}

		// Token: 0x060089FC RID: 35324 RVA: 0x0026EF00 File Offset: 0x0026D100
		public int UnlockCharacters(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001B9E RID: 7070
		// (get) Token: 0x060089FD RID: 35325 RVA: 0x0026EF40 File Offset: 0x0026D140
		public int UnlockCharactersLength
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

		// Token: 0x060089FE RID: 35326 RVA: 0x0026EF6C File Offset: 0x0026D16C
		public Span<int> GetUnlockCharactersBytes()
		{
			return this.__p.__vector_as_span<int>(28, 4);
		}

		// Token: 0x060089FF RID: 35327 RVA: 0x0026EF7C File Offset: 0x0026D17C
		public int[] GetUnlockCharactersArray()
		{
			return this.__p.__vector_as_array<int>(28) ?? Array.Empty<int>();
		}

		// Token: 0x06008A00 RID: 35328 RVA: 0x0026EF94 File Offset: 0x0026D194
		public int UnLockedItems(int j)
		{
			int num = this.__p.__offset(30);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001B9F RID: 7071
		// (get) Token: 0x06008A01 RID: 35329 RVA: 0x0026EFD4 File Offset: 0x0026D1D4
		public int UnLockedItemsLength
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06008A02 RID: 35330 RVA: 0x0026F000 File Offset: 0x0026D200
		public Span<int> GetUnLockedItemsBytes()
		{
			return this.__p.__vector_as_span<int>(30, 4);
		}

		// Token: 0x06008A03 RID: 35331 RVA: 0x0026F010 File Offset: 0x0026D210
		public int[] GetUnLockedItemsArray()
		{
			return this.__p.__vector_as_array<int>(30) ?? Array.Empty<int>();
		}

		// Token: 0x06008A04 RID: 35332 RVA: 0x0026F028 File Offset: 0x0026D228
		public int UnLockedWeapons(int j)
		{
			int num = this.__p.__offset(32);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001BA0 RID: 7072
		// (get) Token: 0x06008A05 RID: 35333 RVA: 0x0026F068 File Offset: 0x0026D268
		public int UnLockedWeaponsLength
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

		// Token: 0x06008A06 RID: 35334 RVA: 0x0026F094 File Offset: 0x0026D294
		public Span<int> GetUnLockedWeaponsBytes()
		{
			return this.__p.__vector_as_span<int>(32, 4);
		}

		// Token: 0x06008A07 RID: 35335 RVA: 0x0026F0A4 File Offset: 0x0026D2A4
		public int[] GetUnLockedWeaponsArray()
		{
			return this.__p.__vector_as_array<int>(32) ?? Array.Empty<int>();
		}

		// Token: 0x17001BA1 RID: 7073
		// (get) Token: 0x06008A08 RID: 35336 RVA: 0x0026F0BC File Offset: 0x0026D2BC
		public string Icon
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

		// Token: 0x06008A09 RID: 35337 RVA: 0x0026F0F4 File Offset: 0x0026D2F4
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x06008A0A RID: 35338 RVA: 0x0026F104 File Offset: 0x0026D304
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x17001BA2 RID: 7074
		// (get) Token: 0x06008A0B RID: 35339 RVA: 0x0026F11C File Offset: 0x0026D31C
		public string Name
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008A0C RID: 35340 RVA: 0x0026F154 File Offset: 0x0026D354
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x06008A0D RID: 35341 RVA: 0x0026F164 File Offset: 0x0026D364
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x17001BA3 RID: 7075
		// (get) Token: 0x06008A0E RID: 35342 RVA: 0x0026F17C File Offset: 0x0026D37C
		public string Picture
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

		// Token: 0x06008A0F RID: 35343 RVA: 0x0026F1B4 File Offset: 0x0026D3B4
		public Span<byte> GetPictureBytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x06008A10 RID: 35344 RVA: 0x0026F1C4 File Offset: 0x0026D3C4
		public byte[] GetPictureArray()
		{
			return this.__p.__vector_as_array<byte>(38) ?? Array.Empty<byte>();
		}

		// Token: 0x17001BA4 RID: 7076
		// (get) Token: 0x06008A11 RID: 35345 RVA: 0x0026F1DC File Offset: 0x0026D3DC
		public string Number
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

		// Token: 0x06008A12 RID: 35346 RVA: 0x0026F214 File Offset: 0x0026D414
		public Span<byte> GetNumberBytes()
		{
			return this.__p.__vector_as_span<byte>(40, 1);
		}

		// Token: 0x06008A13 RID: 35347 RVA: 0x0026F224 File Offset: 0x0026D424
		public byte[] GetNumberArray()
		{
			return this.__p.__vector_as_array<byte>(40) ?? Array.Empty<byte>();
		}

		// Token: 0x06008A14 RID: 35348 RVA: 0x0026F23C File Offset: 0x0026D43C
		public int SpawnPoints(int j)
		{
			int num = this.__p.__offset(42);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001BA5 RID: 7077
		// (get) Token: 0x06008A15 RID: 35349 RVA: 0x0026F27C File Offset: 0x0026D47C
		public int SpawnPointsLength
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06008A16 RID: 35350 RVA: 0x0026F2A8 File Offset: 0x0026D4A8
		public Span<int> GetSpawnPointsBytes()
		{
			return this.__p.__vector_as_span<int>(42, 4);
		}

		// Token: 0x06008A17 RID: 35351 RVA: 0x0026F2B8 File Offset: 0x0026D4B8
		public int[] GetSpawnPointsArray()
		{
			return this.__p.__vector_as_array<int>(42) ?? Array.Empty<int>();
		}

		// Token: 0x17001BA6 RID: 7078
		// (get) Token: 0x06008A18 RID: 35352 RVA: 0x0026F2D0 File Offset: 0x0026D4D0
		public string LevelRange
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

		// Token: 0x06008A19 RID: 35353 RVA: 0x0026F308 File Offset: 0x0026D508
		public Span<byte> GetLevelRangeBytes()
		{
			return this.__p.__vector_as_span<byte>(44, 1);
		}

		// Token: 0x06008A1A RID: 35354 RVA: 0x0026F318 File Offset: 0x0026D518
		public byte[] GetLevelRangeArray()
		{
			return this.__p.__vector_as_array<byte>(44) ?? Array.Empty<byte>();
		}

		// Token: 0x17001BA7 RID: 7079
		// (get) Token: 0x06008A1B RID: 35355 RVA: 0x0026F330 File Offset: 0x0026D530
		public string DetailDesc
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

		// Token: 0x06008A1C RID: 35356 RVA: 0x0026F368 File Offset: 0x0026D568
		public Span<byte> GetDetailDescBytes()
		{
			return this.__p.__vector_as_span<byte>(46, 1);
		}

		// Token: 0x06008A1D RID: 35357 RVA: 0x0026F378 File Offset: 0x0026D578
		public byte[] GetDetailDescArray()
		{
			return this.__p.__vector_as_array<byte>(46) ?? Array.Empty<byte>();
		}

		// Token: 0x06008A1E RID: 35358 RVA: 0x0026F390 File Offset: 0x0026D590
		public string DetailDescParams(int j)
		{
			int num = this.__p.__offset(48);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001BA8 RID: 7080
		// (get) Token: 0x06008A1F RID: 35359 RVA: 0x0026F3CC File Offset: 0x0026D5CC
		public int DetailDescParamsLength
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

		// Token: 0x06008A20 RID: 35360 RVA: 0x0026F3F8 File Offset: 0x0026D5F8
		public string TargetDesc(int j)
		{
			int num = this.__p.__offset(50);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001BA9 RID: 7081
		// (get) Token: 0x06008A21 RID: 35361 RVA: 0x0026F434 File Offset: 0x0026D634
		public int TargetDescLength
		{
			get
			{
				int num = this.__p.__offset(50);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17001BAA RID: 7082
		// (get) Token: 0x06008A22 RID: 35362 RVA: 0x0026F460 File Offset: 0x0026D660
		public int TotalWave
		{
			get
			{
				int num = this.__p.__offset(52);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008A23 RID: 35363 RVA: 0x0026F4A0 File Offset: 0x0026D6A0
		public float BoundCenter(int j)
		{
			int num = this.__p.__offset(54);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001BAB RID: 7083
		// (get) Token: 0x06008A24 RID: 35364 RVA: 0x0026F4E4 File Offset: 0x0026D6E4
		public int BoundCenterLength
		{
			get
			{
				int num = this.__p.__offset(54);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06008A25 RID: 35365 RVA: 0x0026F510 File Offset: 0x0026D710
		public Span<float> GetBoundCenterBytes()
		{
			return this.__p.__vector_as_span<float>(54, 4);
		}

		// Token: 0x06008A26 RID: 35366 RVA: 0x0026F520 File Offset: 0x0026D720
		public float[] GetBoundCenterArray()
		{
			return this.__p.__vector_as_array<float>(54) ?? Array.Empty<float>();
		}

		// Token: 0x17001BAC RID: 7084
		// (get) Token: 0x06008A27 RID: 35367 RVA: 0x0026F538 File Offset: 0x0026D738
		public float BoundRadius
		{
			get
			{
				int num = this.__p.__offset(56);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008A28 RID: 35368 RVA: 0x0026F57C File Offset: 0x0026D77C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BoundCenterIter()或GetBoundCenterBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly float[] BoundCenter()
		{
			KurotatoLevel kurotatoLevel = this;
			return kurotatoLevel.GetBoundCenterArray() ?? Array.Empty<float>();
		}

		// Token: 0x06008A29 RID: 35369 RVA: 0x0026F5A0 File Offset: 0x0026D7A0
		[NullableContext(1)]
		public readonly IEnumerable<float> BoundCenterIter()
		{
			KurotatoLevel.<BoundCenterIter>d__104 <BoundCenterIter>d__ = new KurotatoLevel.<BoundCenterIter>d__104(-2);
			<BoundCenterIter>d__.<>3__<>4__this = this;
			return <BoundCenterIter>d__;
		}

		// Token: 0x06008A2A RID: 35370 RVA: 0x0026F5B8 File Offset: 0x0026D7B8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用CharactersIter()或GetCharactersBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Characters()
		{
			KurotatoLevel kurotatoLevel = this;
			return kurotatoLevel.GetCharactersArray() ?? Array.Empty<int>();
		}

		// Token: 0x06008A2B RID: 35371 RVA: 0x0026F5DC File Offset: 0x0026D7DC
		[NullableContext(1)]
		public readonly IEnumerable<int> CharactersIter()
		{
			KurotatoLevel.<CharactersIter>d__106 <CharactersIter>d__ = new KurotatoLevel.<CharactersIter>d__106(-2);
			<CharactersIter>d__.<>3__<>4__this = this;
			return <CharactersIter>d__;
		}

		// Token: 0x06008A2C RID: 35372 RVA: 0x0026F5F1 File Offset: 0x0026D7F1
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用DetailDescParamsIter()或GetDetailDescParamsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] DetailDescParams()
		{
			return this.DetailDescParamsIter().ToArray<string>();
		}

		// Token: 0x06008A2D RID: 35373 RVA: 0x0026F5FE File Offset: 0x0026D7FE
		[NullableContext(1)]
		public readonly IEnumerable<string> DetailDescParamsIter()
		{
			KurotatoLevel.<DetailDescParamsIter>d__108 <DetailDescParamsIter>d__ = new KurotatoLevel.<DetailDescParamsIter>d__108(-2);
			<DetailDescParamsIter>d__.<>3__<>4__this = this;
			return <DetailDescParamsIter>d__;
		}

		// Token: 0x06008A2E RID: 35374 RVA: 0x0026F614 File Offset: 0x0026D814
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RecommendCharactersIter()或GetRecommendCharactersBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] RecommendCharacters()
		{
			KurotatoLevel kurotatoLevel = this;
			return kurotatoLevel.GetRecommendCharactersArray() ?? Array.Empty<int>();
		}

		// Token: 0x06008A2F RID: 35375 RVA: 0x0026F638 File Offset: 0x0026D838
		[NullableContext(1)]
		public readonly IEnumerable<int> RecommendCharactersIter()
		{
			KurotatoLevel.<RecommendCharactersIter>d__110 <RecommendCharactersIter>d__ = new KurotatoLevel.<RecommendCharactersIter>d__110(-2);
			<RecommendCharactersIter>d__.<>3__<>4__this = this;
			return <RecommendCharactersIter>d__;
		}

		// Token: 0x06008A30 RID: 35376 RVA: 0x0026F650 File Offset: 0x0026D850
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SaveWaveIdsIter()或GetSaveWaveIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] SaveWaveIds()
		{
			KurotatoLevel kurotatoLevel = this;
			return kurotatoLevel.GetSaveWaveIdsArray() ?? Array.Empty<int>();
		}

		// Token: 0x06008A31 RID: 35377 RVA: 0x0026F674 File Offset: 0x0026D874
		[NullableContext(1)]
		public readonly IEnumerable<int> SaveWaveIdsIter()
		{
			KurotatoLevel.<SaveWaveIdsIter>d__112 <SaveWaveIdsIter>d__ = new KurotatoLevel.<SaveWaveIdsIter>d__112(-2);
			<SaveWaveIdsIter>d__.<>3__<>4__this = this;
			return <SaveWaveIdsIter>d__;
		}

		// Token: 0x06008A32 RID: 35378 RVA: 0x0026F68C File Offset: 0x0026D88C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SpawnPointsIter()或GetSpawnPointsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] SpawnPoints()
		{
			KurotatoLevel kurotatoLevel = this;
			return kurotatoLevel.GetSpawnPointsArray() ?? Array.Empty<int>();
		}

		// Token: 0x06008A33 RID: 35379 RVA: 0x0026F6B0 File Offset: 0x0026D8B0
		[NullableContext(1)]
		public readonly IEnumerable<int> SpawnPointsIter()
		{
			KurotatoLevel.<SpawnPointsIter>d__114 <SpawnPointsIter>d__ = new KurotatoLevel.<SpawnPointsIter>d__114(-2);
			<SpawnPointsIter>d__.<>3__<>4__this = this;
			return <SpawnPointsIter>d__;
		}

		// Token: 0x06008A34 RID: 35380 RVA: 0x0026F6C5 File Offset: 0x0026D8C5
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用TargetDescIter()或GetTargetDescBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] TargetDesc()
		{
			return this.TargetDescIter().ToArray<string>();
		}

		// Token: 0x06008A35 RID: 35381 RVA: 0x0026F6D2 File Offset: 0x0026D8D2
		[NullableContext(1)]
		public readonly IEnumerable<string> TargetDescIter()
		{
			KurotatoLevel.<TargetDescIter>d__116 <TargetDescIter>d__ = new KurotatoLevel.<TargetDescIter>d__116(-2);
			<TargetDescIter>d__.<>3__<>4__this = this;
			return <TargetDescIter>d__;
		}

		// Token: 0x06008A36 RID: 35382 RVA: 0x0026F6E8 File Offset: 0x0026D8E8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用TargetWaveIdsIter()或GetTargetWaveIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] TargetWaveIds()
		{
			KurotatoLevel kurotatoLevel = this;
			return kurotatoLevel.GetTargetWaveIdsArray() ?? Array.Empty<int>();
		}

		// Token: 0x06008A37 RID: 35383 RVA: 0x0026F70C File Offset: 0x0026D90C
		[NullableContext(1)]
		public readonly IEnumerable<int> TargetWaveIdsIter()
		{
			KurotatoLevel.<TargetWaveIdsIter>d__118 <TargetWaveIdsIter>d__ = new KurotatoLevel.<TargetWaveIdsIter>d__118(-2);
			<TargetWaveIdsIter>d__.<>3__<>4__this = this;
			return <TargetWaveIdsIter>d__;
		}

		// Token: 0x06008A38 RID: 35384 RVA: 0x0026F724 File Offset: 0x0026D924
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用UnLockedItemsIter()或GetUnLockedItemsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] UnLockedItems()
		{
			KurotatoLevel kurotatoLevel = this;
			return kurotatoLevel.GetUnLockedItemsArray() ?? Array.Empty<int>();
		}

		// Token: 0x06008A39 RID: 35385 RVA: 0x0026F748 File Offset: 0x0026D948
		[NullableContext(1)]
		public readonly IEnumerable<int> UnLockedItemsIter()
		{
			KurotatoLevel.<UnLockedItemsIter>d__120 <UnLockedItemsIter>d__ = new KurotatoLevel.<UnLockedItemsIter>d__120(-2);
			<UnLockedItemsIter>d__.<>3__<>4__this = this;
			return <UnLockedItemsIter>d__;
		}

		// Token: 0x06008A3A RID: 35386 RVA: 0x0026F760 File Offset: 0x0026D960
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用UnLockedWeaponsIter()或GetUnLockedWeaponsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] UnLockedWeapons()
		{
			KurotatoLevel kurotatoLevel = this;
			return kurotatoLevel.GetUnLockedWeaponsArray() ?? Array.Empty<int>();
		}

		// Token: 0x06008A3B RID: 35387 RVA: 0x0026F784 File Offset: 0x0026D984
		[NullableContext(1)]
		public readonly IEnumerable<int> UnLockedWeaponsIter()
		{
			KurotatoLevel.<UnLockedWeaponsIter>d__122 <UnLockedWeaponsIter>d__ = new KurotatoLevel.<UnLockedWeaponsIter>d__122(-2);
			<UnLockedWeaponsIter>d__.<>3__<>4__this = this;
			return <UnLockedWeaponsIter>d__;
		}

		// Token: 0x06008A3C RID: 35388 RVA: 0x0026F79C File Offset: 0x0026D99C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用UnlockCharactersIter()或GetUnlockCharactersBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] UnlockCharacters()
		{
			KurotatoLevel kurotatoLevel = this;
			return kurotatoLevel.GetUnlockCharactersArray() ?? Array.Empty<int>();
		}

		// Token: 0x06008A3D RID: 35389 RVA: 0x0026F7C0 File Offset: 0x0026D9C0
		[NullableContext(1)]
		public readonly IEnumerable<int> UnlockCharactersIter()
		{
			KurotatoLevel.<UnlockCharactersIter>d__124 <UnlockCharactersIter>d__ = new KurotatoLevel.<UnlockCharactersIter>d__124(-2);
			<UnlockCharactersIter>d__.<>3__<>4__this = this;
			return <UnlockCharactersIter>d__;
		}

		// Token: 0x04004E33 RID: 20019
		private Table __p;
	}
}

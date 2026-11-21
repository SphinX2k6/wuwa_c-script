using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E12 RID: 3602
	public struct HonamiStoryActivity : IFlatbufferObject
	{
		// Token: 0x1700177D RID: 6013
		// (get) Token: 0x060084BB RID: 33979 RVA: 0x00272CD5 File Offset: 0x00270ED5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060084BC RID: 33980 RVA: 0x00272CE2 File Offset: 0x00270EE2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060084BD RID: 33981 RVA: 0x00272CEC File Offset: 0x00270EEC
		public static HonamiStoryActivity GetRootAsHonamiStoryActivity(ByteBuffer _bb)
		{
			return HonamiStoryActivity.GetRootAsHonamiStoryActivity(_bb, default(HonamiStoryActivity));
		}

		// Token: 0x060084BE RID: 33982 RVA: 0x00272D08 File Offset: 0x00270F08
		public static HonamiStoryActivity GetRootAsHonamiStoryActivity(ByteBuffer _bb, HonamiStoryActivity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060084BF RID: 33983 RVA: 0x00272D25 File Offset: 0x00270F25
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060084C0 RID: 33984 RVA: 0x00272D34 File Offset: 0x00270F34
		public HonamiStoryActivity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700177E RID: 6014
		// (get) Token: 0x060084C1 RID: 33985 RVA: 0x00272D44 File Offset: 0x00270F44
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

		// Token: 0x1700177F RID: 6015
		// (get) Token: 0x060084C2 RID: 33986 RVA: 0x00272D80 File Offset: 0x00270F80
		public int LimitTime
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

		// Token: 0x17001780 RID: 6016
		// (get) Token: 0x060084C3 RID: 33987 RVA: 0x00272DBC File Offset: 0x00270FBC
		public int LimitShopItemId
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

		// Token: 0x17001781 RID: 6017
		// (get) Token: 0x060084C4 RID: 33988 RVA: 0x00272DF8 File Offset: 0x00270FF8
		public int LimitShopItemMax
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

		// Token: 0x17001782 RID: 6018
		// (get) Token: 0x060084C5 RID: 33989 RVA: 0x00272E38 File Offset: 0x00271038
		public int ScoreItemId
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

		// Token: 0x17001783 RID: 6019
		// (get) Token: 0x060084C6 RID: 33990 RVA: 0x00272E78 File Offset: 0x00271078
		public int OutCoinItemId
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

		// Token: 0x17001784 RID: 6020
		// (get) Token: 0x060084C7 RID: 33991 RVA: 0x00272EB8 File Offset: 0x002710B8
		public int InnerItemId
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

		// Token: 0x17001785 RID: 6021
		// (get) Token: 0x060084C8 RID: 33992 RVA: 0x00272EF8 File Offset: 0x002710F8
		public int FailLeaveCoinRatio
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

		// Token: 0x060084C9 RID: 33993 RVA: 0x00272F38 File Offset: 0x00271138
		public int MainLineInstId(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001786 RID: 6022
		// (get) Token: 0x060084CA RID: 33994 RVA: 0x00272F78 File Offset: 0x00271178
		public int MainLineInstIdLength
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

		// Token: 0x060084CB RID: 33995 RVA: 0x00272FA4 File Offset: 0x002711A4
		public Span<int> GetMainLineInstIdBytes()
		{
			return this.__p.__vector_as_span<int>(20, 4);
		}

		// Token: 0x060084CC RID: 33996 RVA: 0x00272FB4 File Offset: 0x002711B4
		public int[] GetMainLineInstIdArray()
		{
			return this.__p.__vector_as_array<int>(20) ?? Array.Empty<int>();
		}

		// Token: 0x060084CD RID: 33997 RVA: 0x00272FCC File Offset: 0x002711CC
		public DicIntInt? MainLineInstIdUnlock(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001787 RID: 6023
		// (get) Token: 0x060084CE RID: 33998 RVA: 0x00273030 File Offset: 0x00271230
		public int MainLineInstIdUnlockLength
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

		// Token: 0x17001788 RID: 6024
		// (get) Token: 0x060084CF RID: 33999 RVA: 0x0027305C File Offset: 0x0027125C
		public int AreaInstId
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

		// Token: 0x17001789 RID: 6025
		// (get) Token: 0x060084D0 RID: 34000 RVA: 0x0027309C File Offset: 0x0027129C
		public int OriAreaDangerLevel
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

		// Token: 0x1700178A RID: 6026
		// (get) Token: 0x060084D1 RID: 34001 RVA: 0x002730DC File Offset: 0x002712DC
		public int MaxAreaDangerLevel
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

		// Token: 0x1700178B RID: 6027
		// (get) Token: 0x060084D2 RID: 34002 RVA: 0x0027311C File Offset: 0x0027131C
		public int TopTowerInstId
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

		// Token: 0x1700178C RID: 6028
		// (get) Token: 0x060084D3 RID: 34003 RVA: 0x0027315C File Offset: 0x0027135C
		public int OriTopTowerDangerLevel
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700178D RID: 6029
		// (get) Token: 0x060084D4 RID: 34004 RVA: 0x0027319C File Offset: 0x0027139C
		public int MaxTopTowerDangerLevel
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700178E RID: 6030
		// (get) Token: 0x060084D5 RID: 34005 RVA: 0x002731DC File Offset: 0x002713DC
		public string TopTowerVarName
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

		// Token: 0x060084D6 RID: 34006 RVA: 0x00273214 File Offset: 0x00271414
		public Span<byte> GetTopTowerVarNameBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x060084D7 RID: 34007 RVA: 0x00273224 File Offset: 0x00271424
		public byte[] GetTopTowerVarNameArray()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x1700178F RID: 6031
		// (get) Token: 0x060084D8 RID: 34008 RVA: 0x0027323C File Offset: 0x0027143C
		public int LimitShopId
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001790 RID: 6032
		// (get) Token: 0x060084D9 RID: 34009 RVA: 0x0027327C File Offset: 0x0027147C
		public int ShopId
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001791 RID: 6033
		// (get) Token: 0x060084DA RID: 34010 RVA: 0x002732BC File Offset: 0x002714BC
		public int BottomWeaponLevel
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001792 RID: 6034
		// (get) Token: 0x060084DB RID: 34011 RVA: 0x002732FC File Offset: 0x002714FC
		public int BottomRoleLevel
		{
			get
			{
				int num = this.__p.__offset(44);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001793 RID: 6035
		// (get) Token: 0x060084DC RID: 34012 RVA: 0x0027333C File Offset: 0x0027153C
		public int BottomSkillLevel
		{
			get
			{
				int num = this.__p.__offset(46);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001794 RID: 6036
		// (get) Token: 0x060084DD RID: 34013 RVA: 0x0027337C File Offset: 0x0027157C
		public int TalentFuncId
		{
			get
			{
				int num = this.__p.__offset(48);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001795 RID: 6037
		// (get) Token: 0x060084DE RID: 34014 RVA: 0x002733BC File Offset: 0x002715BC
		public int MascotFuncId
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

		// Token: 0x17001796 RID: 6038
		// (get) Token: 0x060084DF RID: 34015 RVA: 0x002733FC File Offset: 0x002715FC
		public int ItemCollectionFuncId
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

		// Token: 0x17001797 RID: 6039
		// (get) Token: 0x060084E0 RID: 34016 RVA: 0x0027343C File Offset: 0x0027163C
		public int SafeLeaveBuyFuncId
		{
			get
			{
				int num = this.__p.__offset(54);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001798 RID: 6040
		// (get) Token: 0x060084E1 RID: 34017 RVA: 0x0027347C File Offset: 0x0027167C
		public int LifeSupportFuncId
		{
			get
			{
				int num = this.__p.__offset(56);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001799 RID: 6041
		// (get) Token: 0x060084E2 RID: 34018 RVA: 0x002734BC File Offset: 0x002716BC
		public int LifeSupportUpFuncId
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

		// Token: 0x1700179A RID: 6042
		// (get) Token: 0x060084E3 RID: 34019 RVA: 0x002734FC File Offset: 0x002716FC
		public int EnhanceLevelFuncId
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

		// Token: 0x1700179B RID: 6043
		// (get) Token: 0x060084E4 RID: 34020 RVA: 0x0027353C File Offset: 0x0027173C
		public int AreaTaskFuncId
		{
			get
			{
				int num = this.__p.__offset(62);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700179C RID: 6044
		// (get) Token: 0x060084E5 RID: 34021 RVA: 0x0027357C File Offset: 0x0027177C
		public int EquipRoleFuncId
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

		// Token: 0x1700179D RID: 6045
		// (get) Token: 0x060084E6 RID: 34022 RVA: 0x002735BC File Offset: 0x002717BC
		public int EquipWeaponFuncId
		{
			get
			{
				int num = this.__p.__offset(66);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700179E RID: 6046
		// (get) Token: 0x060084E7 RID: 34023 RVA: 0x002735FC File Offset: 0x002717FC
		public int PreparationFuncId
		{
			get
			{
				int num = this.__p.__offset(68);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700179F RID: 6047
		// (get) Token: 0x060084E8 RID: 34024 RVA: 0x0027363C File Offset: 0x0027183C
		public int PollutionFuncId
		{
			get
			{
				int num = this.__p.__offset(70);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170017A0 RID: 6048
		// (get) Token: 0x060084E9 RID: 34025 RVA: 0x0027367C File Offset: 0x0027187C
		public int ChangeDangerFuncId
		{
			get
			{
				int num = this.__p.__offset(72);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170017A1 RID: 6049
		// (get) Token: 0x060084EA RID: 34026 RVA: 0x002736BC File Offset: 0x002718BC
		public int LvSelectOpenFuncId
		{
			get
			{
				int num = this.__p.__offset(74);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170017A2 RID: 6050
		// (get) Token: 0x060084EB RID: 34027 RVA: 0x002736FC File Offset: 0x002718FC
		public int TowerOpenFuncId
		{
			get
			{
				int num = this.__p.__offset(76);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170017A3 RID: 6051
		// (get) Token: 0x060084EC RID: 34028 RVA: 0x0027373C File Offset: 0x0027193C
		public string TowerName
		{
			get
			{
				int num = this.__p.__offset(78);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060084ED RID: 34029 RVA: 0x00273774 File Offset: 0x00271974
		public Span<byte> GetTowerNameBytes()
		{
			return this.__p.__vector_as_span<byte>(78, 1);
		}

		// Token: 0x060084EE RID: 34030 RVA: 0x00273784 File Offset: 0x00271984
		public byte[] GetTowerNameArray()
		{
			return this.__p.__vector_as_array<byte>(78) ?? Array.Empty<byte>();
		}

		// Token: 0x170017A4 RID: 6052
		// (get) Token: 0x060084EF RID: 34031 RVA: 0x0027379C File Offset: 0x0027199C
		public int ShopFuncId
		{
			get
			{
				int num = this.__p.__offset(80);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170017A5 RID: 6053
		// (get) Token: 0x060084F0 RID: 34032 RVA: 0x002737DC File Offset: 0x002719DC
		public int HelpId
		{
			get
			{
				int num = this.__p.__offset(82);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170017A6 RID: 6054
		// (get) Token: 0x060084F1 RID: 34033 RVA: 0x0027381C File Offset: 0x00271A1C
		public int MarkId
		{
			get
			{
				int num = this.__p.__offset(84);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170017A7 RID: 6055
		// (get) Token: 0x060084F2 RID: 34034 RVA: 0x0027385C File Offset: 0x00271A5C
		public int MainQuestId
		{
			get
			{
				int num = this.__p.__offset(86);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170017A8 RID: 6056
		// (get) Token: 0x060084F3 RID: 34035 RVA: 0x0027389C File Offset: 0x00271A9C
		public int MainDropQuality
		{
			get
			{
				int num = this.__p.__offset(88);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060084F4 RID: 34036 RVA: 0x002738D9 File Offset: 0x00271AD9
		[NullableContext(1)]
		public int[] MainLineInstId()
		{
			return this.GetMainLineInstIdArray();
		}

		// Token: 0x060084F5 RID: 34037 RVA: 0x002738E1 File Offset: 0x00271AE1
		[NullableContext(1)]
		public IEnumerable<int> MainLineInstIdIter()
		{
			HonamiStoryActivity.<MainLineInstIdIter>d__103 <MainLineInstIdIter>d__ = new HonamiStoryActivity.<MainLineInstIdIter>d__103(-2);
			<MainLineInstIdIter>d__.<>3__<>4__this = this;
			return <MainLineInstIdIter>d__;
		}

		// Token: 0x060084F6 RID: 34038 RVA: 0x002738F8 File Offset: 0x00271AF8
		[NullableContext(1)]
		public Dictionary<int, int> MainLineInstIdUnlock()
		{
			return this.MainLineInstIdUnlockIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x060084F7 RID: 34039 RVA: 0x0027394E File Offset: 0x00271B4E
		[NullableContext(1)]
		public IEnumerable<DicIntInt> MainLineInstIdUnlockIter()
		{
			HonamiStoryActivity.<MainLineInstIdUnlockIter>d__105 <MainLineInstIdUnlockIter>d__ = new HonamiStoryActivity.<MainLineInstIdUnlockIter>d__105(-2);
			<MainLineInstIdUnlockIter>d__.<>3__<>4__this = this;
			return <MainLineInstIdUnlockIter>d__;
		}

		// Token: 0x060084F8 RID: 34040 RVA: 0x00273964 File Offset: 0x00271B64
		public int? GetMainLineInstIdUnlock(int key)
		{
			this.EnsureMainLineInstIdUnlockCacheIfNeeded();
			int value;
			if (!this.MainLineInstIdUnlockCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x060084F9 RID: 34041 RVA: 0x00273998 File Offset: 0x00271B98
		private void EnsureMainLineInstIdUnlockCacheIfNeeded()
		{
			if (this.MainLineInstIdUnlockCache != null)
			{
				return;
			}
			this.MainLineInstIdUnlockCache = this.MainLineInstIdUnlockIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x060084FA RID: 34042 RVA: 0x002739FE File Offset: 0x00271BFE
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetMainLineInstIdUnlockFrozenDict()
		{
			this.EnsureMainLineInstIdUnlockCacheIfNeeded();
			return this.MainLineInstIdUnlockCache;
		}

		// Token: 0x0400538A RID: 21386
		private Table __p;

		// Token: 0x0400538B RID: 21387
		[Nullable(2)]
		private FrozenDictionary<int, int> MainLineInstIdUnlockCache;
	}
}

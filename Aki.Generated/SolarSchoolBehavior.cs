using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011D6 RID: 4566
	public struct SolarSchoolBehavior : IFlatbufferObject
	{
		// Token: 0x170038C4 RID: 14532
		// (get) Token: 0x0600DF69 RID: 57193 RVA: 0x0033C305 File Offset: 0x0033A505
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DF6A RID: 57194 RVA: 0x0033C312 File Offset: 0x0033A512
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DF6B RID: 57195 RVA: 0x0033C31C File Offset: 0x0033A51C
		public static SolarSchoolBehavior GetRootAsSolarSchoolBehavior(ByteBuffer _bb)
		{
			return SolarSchoolBehavior.GetRootAsSolarSchoolBehavior(_bb, default(SolarSchoolBehavior));
		}

		// Token: 0x0600DF6C RID: 57196 RVA: 0x0033C338 File Offset: 0x0033A538
		public static SolarSchoolBehavior GetRootAsSolarSchoolBehavior(ByteBuffer _bb, SolarSchoolBehavior obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DF6D RID: 57197 RVA: 0x0033C355 File Offset: 0x0033A555
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DF6E RID: 57198 RVA: 0x0033C364 File Offset: 0x0033A564
		public SolarSchoolBehavior __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170038C5 RID: 14533
		// (get) Token: 0x0600DF6F RID: 57199 RVA: 0x0033C374 File Offset: 0x0033A574
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

		// Token: 0x170038C6 RID: 14534
		// (get) Token: 0x0600DF70 RID: 57200 RVA: 0x0033C3B0 File Offset: 0x0033A5B0
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

		// Token: 0x170038C7 RID: 14535
		// (get) Token: 0x0600DF71 RID: 57201 RVA: 0x0033C3EC File Offset: 0x0033A5EC
		public int BehaviorId
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

		// Token: 0x170038C8 RID: 14536
		// (get) Token: 0x0600DF72 RID: 57202 RVA: 0x0033C428 File Offset: 0x0033A628
		public int BehaviorType
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

		// Token: 0x170038C9 RID: 14537
		// (get) Token: 0x0600DF73 RID: 57203 RVA: 0x0033C468 File Offset: 0x0033A668
		public int Category
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

		// Token: 0x170038CA RID: 14538
		// (get) Token: 0x0600DF74 RID: 57204 RVA: 0x0033C4A8 File Offset: 0x0033A6A8
		public int Level
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

		// Token: 0x170038CB RID: 14539
		// (get) Token: 0x0600DF75 RID: 57205 RVA: 0x0033C4E8 File Offset: 0x0033A6E8
		public int ShowConditionGroupId
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

		// Token: 0x170038CC RID: 14540
		// (get) Token: 0x0600DF76 RID: 57206 RVA: 0x0033C528 File Offset: 0x0033A728
		public int ExecuteConditionGroupId
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

		// Token: 0x170038CD RID: 14541
		// (get) Token: 0x0600DF77 RID: 57207 RVA: 0x0033C568 File Offset: 0x0033A768
		public int Location
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170038CE RID: 14542
		// (get) Token: 0x0600DF78 RID: 57208 RVA: 0x0033C5A8 File Offset: 0x0033A7A8
		public int RoleId
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

		// Token: 0x0600DF79 RID: 57209 RVA: 0x0033C5E8 File Offset: 0x0033A7E8
		public int AvailableTimeSlot(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170038CF RID: 14543
		// (get) Token: 0x0600DF7A RID: 57210 RVA: 0x0033C628 File Offset: 0x0033A828
		public int AvailableTimeSlotLength
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

		// Token: 0x0600DF7B RID: 57211 RVA: 0x0033C654 File Offset: 0x0033A854
		public Span<int> GetAvailableTimeSlotBytes()
		{
			return this.__p.__vector_as_span<int>(24, 4);
		}

		// Token: 0x0600DF7C RID: 57212 RVA: 0x0033C664 File Offset: 0x0033A864
		public int[] GetAvailableTimeSlotArray()
		{
			return this.__p.__vector_as_array<int>(24) ?? Array.Empty<int>();
		}

		// Token: 0x0600DF7D RID: 57213 RVA: 0x0033C67C File Offset: 0x0033A87C
		public DicIntInt? AttrLower(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170038D0 RID: 14544
		// (get) Token: 0x0600DF7E RID: 57214 RVA: 0x0033C6E0 File Offset: 0x0033A8E0
		public int AttrLowerLength
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

		// Token: 0x0600DF7F RID: 57215 RVA: 0x0033C70C File Offset: 0x0033A90C
		public DicIntInt? AttrUpper(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170038D1 RID: 14545
		// (get) Token: 0x0600DF80 RID: 57216 RVA: 0x0033C770 File Offset: 0x0033A970
		public int AttrUpperLength
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

		// Token: 0x0600DF81 RID: 57217 RVA: 0x0033C79C File Offset: 0x0033A99C
		public DicIntInt? AttrWeight(int j)
		{
			int num = this.__p.__offset(30);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170038D2 RID: 14546
		// (get) Token: 0x0600DF82 RID: 57218 RVA: 0x0033C800 File Offset: 0x0033AA00
		public int AttrWeightLength
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

		// Token: 0x0600DF83 RID: 57219 RVA: 0x0033C82C File Offset: 0x0033AA2C
		public DicIntInt? SucAttrChange(int j)
		{
			int num = this.__p.__offset(32);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170038D3 RID: 14547
		// (get) Token: 0x0600DF84 RID: 57220 RVA: 0x0033C890 File Offset: 0x0033AA90
		public int SucAttrChangeLength
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

		// Token: 0x0600DF85 RID: 57221 RVA: 0x0033C8BC File Offset: 0x0033AABC
		public DicIntInt? FailAttrChange(int j)
		{
			int num = this.__p.__offset(34);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170038D4 RID: 14548
		// (get) Token: 0x0600DF86 RID: 57222 RVA: 0x0033C920 File Offset: 0x0033AB20
		public int FailAttrChangeLength
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

		// Token: 0x170038D5 RID: 14549
		// (get) Token: 0x0600DF87 RID: 57223 RVA: 0x0033C94C File Offset: 0x0033AB4C
		public int RewardSuccess
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170038D6 RID: 14550
		// (get) Token: 0x0600DF88 RID: 57224 RVA: 0x0033C98C File Offset: 0x0033AB8C
		public int RewardFail
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

		// Token: 0x170038D7 RID: 14551
		// (get) Token: 0x0600DF89 RID: 57225 RVA: 0x0033C9CC File Offset: 0x0033ABCC
		public int RewardFinish
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

		// Token: 0x170038D8 RID: 14552
		// (get) Token: 0x0600DF8A RID: 57226 RVA: 0x0033CA0C File Offset: 0x0033AC0C
		public int RequireCount
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

		// Token: 0x170038D9 RID: 14553
		// (get) Token: 0x0600DF8B RID: 57227 RVA: 0x0033CA4C File Offset: 0x0033AC4C
		public bool IsWorkDay
		{
			get
			{
				int num = this.__p.__offset(44);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170038DA RID: 14554
		// (get) Token: 0x0600DF8C RID: 57228 RVA: 0x0033CA8C File Offset: 0x0033AC8C
		public bool IsRecommend
		{
			get
			{
				int num = this.__p.__offset(46);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170038DB RID: 14555
		// (get) Token: 0x0600DF8D RID: 57229 RVA: 0x0033CACC File Offset: 0x0033ACCC
		public int FirstAction
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

		// Token: 0x0600DF8E RID: 57230 RVA: 0x0033CB0C File Offset: 0x0033AD0C
		public int PreActionList(int j)
		{
			int num = this.__p.__offset(50);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170038DC RID: 14556
		// (get) Token: 0x0600DF8F RID: 57231 RVA: 0x0033CB4C File Offset: 0x0033AD4C
		public int PreActionListLength
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

		// Token: 0x0600DF90 RID: 57232 RVA: 0x0033CB78 File Offset: 0x0033AD78
		public Span<int> GetPreActionListBytes()
		{
			return this.__p.__vector_as_span<int>(50, 4);
		}

		// Token: 0x0600DF91 RID: 57233 RVA: 0x0033CB88 File Offset: 0x0033AD88
		public int[] GetPreActionListArray()
		{
			return this.__p.__vector_as_array<int>(50) ?? Array.Empty<int>();
		}

		// Token: 0x170038DD RID: 14557
		// (get) Token: 0x0600DF92 RID: 57234 RVA: 0x0033CBA0 File Offset: 0x0033ADA0
		public string OptionIcon
		{
			get
			{
				int num = this.__p.__offset(52);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600DF93 RID: 57235 RVA: 0x0033CBD8 File Offset: 0x0033ADD8
		public Span<byte> GetOptionIconBytes()
		{
			return this.__p.__vector_as_span<byte>(52, 1);
		}

		// Token: 0x0600DF94 RID: 57236 RVA: 0x0033CBE8 File Offset: 0x0033ADE8
		public byte[] GetOptionIconArray()
		{
			return this.__p.__vector_as_array<byte>(52) ?? Array.Empty<byte>();
		}

		// Token: 0x0600DF95 RID: 57237 RVA: 0x0033CC00 File Offset: 0x0033AE00
		public DicIntInt? AttrRequire(int j)
		{
			int num = this.__p.__offset(54);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170038DE RID: 14558
		// (get) Token: 0x0600DF96 RID: 57238 RVA: 0x0033CC64 File Offset: 0x0033AE64
		public int AttrRequireLength
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

		// Token: 0x170038DF RID: 14559
		// (get) Token: 0x0600DF97 RID: 57239 RVA: 0x0033CC90 File Offset: 0x0033AE90
		public int FinishCount
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

		// Token: 0x170038E0 RID: 14560
		// (get) Token: 0x0600DF98 RID: 57240 RVA: 0x0033CCD0 File Offset: 0x0033AED0
		public int BindRoleId
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

		// Token: 0x170038E1 RID: 14561
		// (get) Token: 0x0600DF99 RID: 57241 RVA: 0x0033CD10 File Offset: 0x0033AF10
		public int StarLevel
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

		// Token: 0x170038E2 RID: 14562
		// (get) Token: 0x0600DF9A RID: 57242 RVA: 0x0033CD50 File Offset: 0x0033AF50
		public int DeliverEntry
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

		// Token: 0x0600DF9B RID: 57243 RVA: 0x0033CD90 File Offset: 0x0033AF90
		public int OccupyDayOfWeek(int j)
		{
			int num = this.__p.__offset(64);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170038E3 RID: 14563
		// (get) Token: 0x0600DF9C RID: 57244 RVA: 0x0033CDD0 File Offset: 0x0033AFD0
		public int OccupyDayOfWeekLength
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

		// Token: 0x0600DF9D RID: 57245 RVA: 0x0033CDFC File Offset: 0x0033AFFC
		public Span<int> GetOccupyDayOfWeekBytes()
		{
			return this.__p.__vector_as_span<int>(64, 4);
		}

		// Token: 0x0600DF9E RID: 57246 RVA: 0x0033CE0C File Offset: 0x0033B00C
		public int[] GetOccupyDayOfWeekArray()
		{
			return this.__p.__vector_as_array<int>(64) ?? Array.Empty<int>();
		}

		// Token: 0x170038E4 RID: 14564
		// (get) Token: 0x0600DF9F RID: 57247 RVA: 0x0033CE24 File Offset: 0x0033B024
		public int AppearDay
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

		// Token: 0x170038E5 RID: 14565
		// (get) Token: 0x0600DFA0 RID: 57248 RVA: 0x0033CE64 File Offset: 0x0033B064
		public int AcceptDeadline
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

		// Token: 0x170038E6 RID: 14566
		// (get) Token: 0x0600DFA1 RID: 57249 RVA: 0x0033CEA4 File Offset: 0x0033B0A4
		public int FinishValidWeek
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

		// Token: 0x170038E7 RID: 14567
		// (get) Token: 0x0600DFA2 RID: 57250 RVA: 0x0033CEE4 File Offset: 0x0033B0E4
		public int FinishDeadline
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

		// Token: 0x170038E8 RID: 14568
		// (get) Token: 0x0600DFA3 RID: 57251 RVA: 0x0033CF24 File Offset: 0x0033B124
		public bool ShowInMap
		{
			get
			{
				int num = this.__p.__offset(74);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170038E9 RID: 14569
		// (get) Token: 0x0600DFA4 RID: 57252 RVA: 0x0033CF64 File Offset: 0x0033B164
		public int AcceptAction
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

		// Token: 0x170038EA RID: 14570
		// (get) Token: 0x0600DFA5 RID: 57253 RVA: 0x0033CFA4 File Offset: 0x0033B1A4
		public int FailAction
		{
			get
			{
				int num = this.__p.__offset(78);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170038EB RID: 14571
		// (get) Token: 0x0600DFA6 RID: 57254 RVA: 0x0033CFE4 File Offset: 0x0033B1E4
		public int FinishAction
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

		// Token: 0x170038EC RID: 14572
		// (get) Token: 0x0600DFA7 RID: 57255 RVA: 0x0033D024 File Offset: 0x0033B224
		public int InviteAction
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

		// Token: 0x170038ED RID: 14573
		// (get) Token: 0x0600DFA8 RID: 57256 RVA: 0x0033D064 File Offset: 0x0033B264
		public string OccupyText
		{
			get
			{
				int num = this.__p.__offset(84);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600DFA9 RID: 57257 RVA: 0x0033D09C File Offset: 0x0033B29C
		public Span<byte> GetOccupyTextBytes()
		{
			return this.__p.__vector_as_span<byte>(84, 1);
		}

		// Token: 0x0600DFAA RID: 57258 RVA: 0x0033D0AC File Offset: 0x0033B2AC
		public byte[] GetOccupyTextArray()
		{
			return this.__p.__vector_as_array<byte>(84) ?? Array.Empty<byte>();
		}

		// Token: 0x170038EE RID: 14574
		// (get) Token: 0x0600DFAB RID: 57259 RVA: 0x0033D0C4 File Offset: 0x0033B2C4
		public string Name
		{
			get
			{
				int num = this.__p.__offset(86);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600DFAC RID: 57260 RVA: 0x0033D0FC File Offset: 0x0033B2FC
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(86, 1);
		}

		// Token: 0x0600DFAD RID: 57261 RVA: 0x0033D10C File Offset: 0x0033B30C
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(86) ?? Array.Empty<byte>();
		}

		// Token: 0x170038EF RID: 14575
		// (get) Token: 0x0600DFAE RID: 57262 RVA: 0x0033D124 File Offset: 0x0033B324
		public string TargetText
		{
			get
			{
				int num = this.__p.__offset(88);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600DFAF RID: 57263 RVA: 0x0033D15C File Offset: 0x0033B35C
		public Span<byte> GetTargetTextBytes()
		{
			return this.__p.__vector_as_span<byte>(88, 1);
		}

		// Token: 0x0600DFB0 RID: 57264 RVA: 0x0033D16C File Offset: 0x0033B36C
		public byte[] GetTargetTextArray()
		{
			return this.__p.__vector_as_array<byte>(88) ?? Array.Empty<byte>();
		}

		// Token: 0x170038F0 RID: 14576
		// (get) Token: 0x0600DFB1 RID: 57265 RVA: 0x0033D184 File Offset: 0x0033B384
		public string DescText
		{
			get
			{
				int num = this.__p.__offset(90);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600DFB2 RID: 57266 RVA: 0x0033D1BC File Offset: 0x0033B3BC
		public Span<byte> GetDescTextBytes()
		{
			return this.__p.__vector_as_span<byte>(90, 1);
		}

		// Token: 0x0600DFB3 RID: 57267 RVA: 0x0033D1CC File Offset: 0x0033B3CC
		public byte[] GetDescTextArray()
		{
			return this.__p.__vector_as_array<byte>(90) ?? Array.Empty<byte>();
		}

		// Token: 0x170038F1 RID: 14577
		// (get) Token: 0x0600DFB4 RID: 57268 RVA: 0x0033D1E4 File Offset: 0x0033B3E4
		public string ShortDescText
		{
			get
			{
				int num = this.__p.__offset(92);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600DFB5 RID: 57269 RVA: 0x0033D21C File Offset: 0x0033B41C
		public Span<byte> GetShortDescTextBytes()
		{
			return this.__p.__vector_as_span<byte>(92, 1);
		}

		// Token: 0x0600DFB6 RID: 57270 RVA: 0x0033D22C File Offset: 0x0033B42C
		public byte[] GetShortDescTextArray()
		{
			return this.__p.__vector_as_array<byte>(92) ?? Array.Empty<byte>();
		}

		// Token: 0x170038F2 RID: 14578
		// (get) Token: 0x0600DFB7 RID: 57271 RVA: 0x0033D244 File Offset: 0x0033B444
		public string ExcuteDescText
		{
			get
			{
				int num = this.__p.__offset(94);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600DFB8 RID: 57272 RVA: 0x0033D27C File Offset: 0x0033B47C
		public Span<byte> GetExcuteDescTextBytes()
		{
			return this.__p.__vector_as_span<byte>(94, 1);
		}

		// Token: 0x0600DFB9 RID: 57273 RVA: 0x0033D28C File Offset: 0x0033B48C
		public byte[] GetExcuteDescTextArray()
		{
			return this.__p.__vector_as_array<byte>(94) ?? Array.Empty<byte>();
		}

		// Token: 0x170038F3 RID: 14579
		// (get) Token: 0x0600DFBA RID: 57274 RVA: 0x0033D2A4 File Offset: 0x0033B4A4
		public bool NeedSucShow
		{
			get
			{
				int num = this.__p.__offset(96);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170038F4 RID: 14580
		// (get) Token: 0x0600DFBB RID: 57275 RVA: 0x0033D2E4 File Offset: 0x0033B4E4
		public string BehaviourIcon
		{
			get
			{
				int num = this.__p.__offset(98);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600DFBC RID: 57276 RVA: 0x0033D31C File Offset: 0x0033B51C
		public Span<byte> GetBehaviourIconBytes()
		{
			return this.__p.__vector_as_span<byte>(98, 1);
		}

		// Token: 0x0600DFBD RID: 57277 RVA: 0x0033D32C File Offset: 0x0033B52C
		public byte[] GetBehaviourIconArray()
		{
			return this.__p.__vector_as_array<byte>(98) ?? Array.Empty<byte>();
		}

		// Token: 0x170038F5 RID: 14581
		// (get) Token: 0x0600DFBE RID: 57278 RVA: 0x0033D344 File Offset: 0x0033B544
		public string OccupyIcon
		{
			get
			{
				int num = this.__p.__offset(100);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600DFBF RID: 57279 RVA: 0x0033D37C File Offset: 0x0033B57C
		public Span<byte> GetOccupyIconBytes()
		{
			return this.__p.__vector_as_span<byte>(100, 1);
		}

		// Token: 0x0600DFC0 RID: 57280 RVA: 0x0033D38C File Offset: 0x0033B58C
		public byte[] GetOccupyIconArray()
		{
			return this.__p.__vector_as_array<byte>(100) ?? Array.Empty<byte>();
		}

		// Token: 0x170038F6 RID: 14582
		// (get) Token: 0x0600DFC1 RID: 57281 RVA: 0x0033D3A4 File Offset: 0x0033B5A4
		public string SpineResMale
		{
			get
			{
				int num = this.__p.__offset(102);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600DFC2 RID: 57282 RVA: 0x0033D3DC File Offset: 0x0033B5DC
		public Span<byte> GetSpineResMaleBytes()
		{
			return this.__p.__vector_as_span<byte>(102, 1);
		}

		// Token: 0x0600DFC3 RID: 57283 RVA: 0x0033D3EC File Offset: 0x0033B5EC
		public byte[] GetSpineResMaleArray()
		{
			return this.__p.__vector_as_array<byte>(102) ?? Array.Empty<byte>();
		}

		// Token: 0x170038F7 RID: 14583
		// (get) Token: 0x0600DFC4 RID: 57284 RVA: 0x0033D404 File Offset: 0x0033B604
		public string SpineResFemale
		{
			get
			{
				int num = this.__p.__offset(104);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600DFC5 RID: 57285 RVA: 0x0033D43C File Offset: 0x0033B63C
		public Span<byte> GetSpineResFemaleBytes()
		{
			return this.__p.__vector_as_span<byte>(104, 1);
		}

		// Token: 0x0600DFC6 RID: 57286 RVA: 0x0033D44C File Offset: 0x0033B64C
		public byte[] GetSpineResFemaleArray()
		{
			return this.__p.__vector_as_array<byte>(104) ?? Array.Empty<byte>();
		}

		// Token: 0x0600DFC7 RID: 57287 RVA: 0x0033D464 File Offset: 0x0033B664
		[NullableContext(1)]
		public Dictionary<int, int> AttrLower()
		{
			return this.AttrLowerIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600DFC8 RID: 57288 RVA: 0x0033D4BA File Offset: 0x0033B6BA
		[NullableContext(1)]
		public IEnumerable<DicIntInt> AttrLowerIter()
		{
			SolarSchoolBehavior.<AttrLowerIter>d__148 <AttrLowerIter>d__ = new SolarSchoolBehavior.<AttrLowerIter>d__148(-2);
			<AttrLowerIter>d__.<>3__<>4__this = this;
			return <AttrLowerIter>d__;
		}

		// Token: 0x0600DFC9 RID: 57289 RVA: 0x0033D4D0 File Offset: 0x0033B6D0
		[NullableContext(1)]
		public Dictionary<int, int> AttrRequire()
		{
			return this.AttrRequireIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600DFCA RID: 57290 RVA: 0x0033D526 File Offset: 0x0033B726
		[NullableContext(1)]
		public IEnumerable<DicIntInt> AttrRequireIter()
		{
			SolarSchoolBehavior.<AttrRequireIter>d__150 <AttrRequireIter>d__ = new SolarSchoolBehavior.<AttrRequireIter>d__150(-2);
			<AttrRequireIter>d__.<>3__<>4__this = this;
			return <AttrRequireIter>d__;
		}

		// Token: 0x0600DFCB RID: 57291 RVA: 0x0033D53C File Offset: 0x0033B73C
		[NullableContext(1)]
		public Dictionary<int, int> AttrUpper()
		{
			return this.AttrUpperIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600DFCC RID: 57292 RVA: 0x0033D592 File Offset: 0x0033B792
		[NullableContext(1)]
		public IEnumerable<DicIntInt> AttrUpperIter()
		{
			SolarSchoolBehavior.<AttrUpperIter>d__152 <AttrUpperIter>d__ = new SolarSchoolBehavior.<AttrUpperIter>d__152(-2);
			<AttrUpperIter>d__.<>3__<>4__this = this;
			return <AttrUpperIter>d__;
		}

		// Token: 0x0600DFCD RID: 57293 RVA: 0x0033D5A8 File Offset: 0x0033B7A8
		[NullableContext(1)]
		public Dictionary<int, int> AttrWeight()
		{
			return this.AttrWeightIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600DFCE RID: 57294 RVA: 0x0033D5FE File Offset: 0x0033B7FE
		[NullableContext(1)]
		public IEnumerable<DicIntInt> AttrWeightIter()
		{
			SolarSchoolBehavior.<AttrWeightIter>d__154 <AttrWeightIter>d__ = new SolarSchoolBehavior.<AttrWeightIter>d__154(-2);
			<AttrWeightIter>d__.<>3__<>4__this = this;
			return <AttrWeightIter>d__;
		}

		// Token: 0x0600DFCF RID: 57295 RVA: 0x0033D613 File Offset: 0x0033B813
		[NullableContext(1)]
		public int[] AvailableTimeSlot()
		{
			return this.GetAvailableTimeSlotArray();
		}

		// Token: 0x0600DFD0 RID: 57296 RVA: 0x0033D61B File Offset: 0x0033B81B
		[NullableContext(1)]
		public IEnumerable<int> AvailableTimeSlotIter()
		{
			SolarSchoolBehavior.<AvailableTimeSlotIter>d__156 <AvailableTimeSlotIter>d__ = new SolarSchoolBehavior.<AvailableTimeSlotIter>d__156(-2);
			<AvailableTimeSlotIter>d__.<>3__<>4__this = this;
			return <AvailableTimeSlotIter>d__;
		}

		// Token: 0x0600DFD1 RID: 57297 RVA: 0x0033D630 File Offset: 0x0033B830
		[NullableContext(1)]
		public Dictionary<int, int> FailAttrChange()
		{
			return this.FailAttrChangeIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600DFD2 RID: 57298 RVA: 0x0033D686 File Offset: 0x0033B886
		[NullableContext(1)]
		public IEnumerable<DicIntInt> FailAttrChangeIter()
		{
			SolarSchoolBehavior.<FailAttrChangeIter>d__158 <FailAttrChangeIter>d__ = new SolarSchoolBehavior.<FailAttrChangeIter>d__158(-2);
			<FailAttrChangeIter>d__.<>3__<>4__this = this;
			return <FailAttrChangeIter>d__;
		}

		// Token: 0x0600DFD3 RID: 57299 RVA: 0x0033D69B File Offset: 0x0033B89B
		[NullableContext(1)]
		public int[] OccupyDayOfWeek()
		{
			return this.GetOccupyDayOfWeekArray();
		}

		// Token: 0x0600DFD4 RID: 57300 RVA: 0x0033D6A3 File Offset: 0x0033B8A3
		[NullableContext(1)]
		public IEnumerable<int> OccupyDayOfWeekIter()
		{
			SolarSchoolBehavior.<OccupyDayOfWeekIter>d__160 <OccupyDayOfWeekIter>d__ = new SolarSchoolBehavior.<OccupyDayOfWeekIter>d__160(-2);
			<OccupyDayOfWeekIter>d__.<>3__<>4__this = this;
			return <OccupyDayOfWeekIter>d__;
		}

		// Token: 0x0600DFD5 RID: 57301 RVA: 0x0033D6B8 File Offset: 0x0033B8B8
		[NullableContext(1)]
		public int[] PreActionList()
		{
			return this.GetPreActionListArray();
		}

		// Token: 0x0600DFD6 RID: 57302 RVA: 0x0033D6C0 File Offset: 0x0033B8C0
		[NullableContext(1)]
		public IEnumerable<int> PreActionListIter()
		{
			SolarSchoolBehavior.<PreActionListIter>d__162 <PreActionListIter>d__ = new SolarSchoolBehavior.<PreActionListIter>d__162(-2);
			<PreActionListIter>d__.<>3__<>4__this = this;
			return <PreActionListIter>d__;
		}

		// Token: 0x0600DFD7 RID: 57303 RVA: 0x0033D6D8 File Offset: 0x0033B8D8
		[NullableContext(1)]
		public Dictionary<int, int> SucAttrChange()
		{
			return this.SucAttrChangeIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600DFD8 RID: 57304 RVA: 0x0033D72E File Offset: 0x0033B92E
		[NullableContext(1)]
		public IEnumerable<DicIntInt> SucAttrChangeIter()
		{
			SolarSchoolBehavior.<SucAttrChangeIter>d__164 <SucAttrChangeIter>d__ = new SolarSchoolBehavior.<SucAttrChangeIter>d__164(-2);
			<SucAttrChangeIter>d__.<>3__<>4__this = this;
			return <SucAttrChangeIter>d__;
		}

		// Token: 0x0600DFD9 RID: 57305 RVA: 0x0033D744 File Offset: 0x0033B944
		public int? GetAttrLower(int key)
		{
			this.EnsureAttrLowerCacheIfNeeded();
			int value;
			if (!this.AttrLowerCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600DFDA RID: 57306 RVA: 0x0033D778 File Offset: 0x0033B978
		public int? GetAttrRequire(int key)
		{
			this.EnsureAttrRequireCacheIfNeeded();
			int value;
			if (!this.AttrRequireCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600DFDB RID: 57307 RVA: 0x0033D7AC File Offset: 0x0033B9AC
		public int? GetAttrUpper(int key)
		{
			this.EnsureAttrUpperCacheIfNeeded();
			int value;
			if (!this.AttrUpperCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600DFDC RID: 57308 RVA: 0x0033D7E0 File Offset: 0x0033B9E0
		public int? GetAttrWeight(int key)
		{
			this.EnsureAttrWeightCacheIfNeeded();
			int value;
			if (!this.AttrWeightCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600DFDD RID: 57309 RVA: 0x0033D814 File Offset: 0x0033BA14
		public int? GetFailAttrChange(int key)
		{
			this.EnsureFailAttrChangeCacheIfNeeded();
			int value;
			if (!this.FailAttrChangeCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600DFDE RID: 57310 RVA: 0x0033D848 File Offset: 0x0033BA48
		public int? GetSucAttrChange(int key)
		{
			this.EnsureSucAttrChangeCacheIfNeeded();
			int value;
			if (!this.SucAttrChangeCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600DFDF RID: 57311 RVA: 0x0033D87C File Offset: 0x0033BA7C
		private void EnsureAttrLowerCacheIfNeeded()
		{
			if (this.AttrLowerCache != null)
			{
				return;
			}
			this.AttrLowerCache = this.AttrLowerIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600DFE0 RID: 57312 RVA: 0x0033D8E4 File Offset: 0x0033BAE4
		private void EnsureAttrRequireCacheIfNeeded()
		{
			if (this.AttrRequireCache != null)
			{
				return;
			}
			this.AttrRequireCache = this.AttrRequireIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600DFE1 RID: 57313 RVA: 0x0033D94C File Offset: 0x0033BB4C
		private void EnsureAttrUpperCacheIfNeeded()
		{
			if (this.AttrUpperCache != null)
			{
				return;
			}
			this.AttrUpperCache = this.AttrUpperIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600DFE2 RID: 57314 RVA: 0x0033D9B4 File Offset: 0x0033BBB4
		private void EnsureAttrWeightCacheIfNeeded()
		{
			if (this.AttrWeightCache != null)
			{
				return;
			}
			this.AttrWeightCache = this.AttrWeightIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600DFE3 RID: 57315 RVA: 0x0033DA1C File Offset: 0x0033BC1C
		private void EnsureFailAttrChangeCacheIfNeeded()
		{
			if (this.FailAttrChangeCache != null)
			{
				return;
			}
			this.FailAttrChangeCache = this.FailAttrChangeIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600DFE4 RID: 57316 RVA: 0x0033DA84 File Offset: 0x0033BC84
		private void EnsureSucAttrChangeCacheIfNeeded()
		{
			if (this.SucAttrChangeCache != null)
			{
				return;
			}
			this.SucAttrChangeCache = this.SucAttrChangeIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600DFE5 RID: 57317 RVA: 0x0033DAEA File Offset: 0x0033BCEA
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetAttrLowerFrozenDict()
		{
			this.EnsureAttrLowerCacheIfNeeded();
			return this.AttrLowerCache;
		}

		// Token: 0x0600DFE6 RID: 57318 RVA: 0x0033DAF8 File Offset: 0x0033BCF8
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetAttrRequireFrozenDict()
		{
			this.EnsureAttrRequireCacheIfNeeded();
			return this.AttrRequireCache;
		}

		// Token: 0x0600DFE7 RID: 57319 RVA: 0x0033DB06 File Offset: 0x0033BD06
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetAttrUpperFrozenDict()
		{
			this.EnsureAttrUpperCacheIfNeeded();
			return this.AttrUpperCache;
		}

		// Token: 0x0600DFE8 RID: 57320 RVA: 0x0033DB14 File Offset: 0x0033BD14
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetAttrWeightFrozenDict()
		{
			this.EnsureAttrWeightCacheIfNeeded();
			return this.AttrWeightCache;
		}

		// Token: 0x0600DFE9 RID: 57321 RVA: 0x0033DB22 File Offset: 0x0033BD22
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetFailAttrChangeFrozenDict()
		{
			this.EnsureFailAttrChangeCacheIfNeeded();
			return this.FailAttrChangeCache;
		}

		// Token: 0x0600DFEA RID: 57322 RVA: 0x0033DB30 File Offset: 0x0033BD30
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetSucAttrChangeFrozenDict()
		{
			this.EnsureSucAttrChangeCacheIfNeeded();
			return this.SucAttrChangeCache;
		}

		// Token: 0x0400580D RID: 22541
		private Table __p;

		// Token: 0x0400580E RID: 22542
		[Nullable(2)]
		private FrozenDictionary<int, int> AttrLowerCache;

		// Token: 0x0400580F RID: 22543
		[Nullable(2)]
		private FrozenDictionary<int, int> AttrRequireCache;

		// Token: 0x04005810 RID: 22544
		[Nullable(2)]
		private FrozenDictionary<int, int> AttrUpperCache;

		// Token: 0x04005811 RID: 22545
		[Nullable(2)]
		private FrozenDictionary<int, int> AttrWeightCache;

		// Token: 0x04005812 RID: 22546
		[Nullable(2)]
		private FrozenDictionary<int, int> FailAttrChangeCache;

		// Token: 0x04005813 RID: 22547
		[Nullable(2)]
		private FrozenDictionary<int, int> SucAttrChangeCache;
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200126D RID: 4717
	public struct TowerConfig : IFlatbufferObject
	{
		// Token: 0x17003E0E RID: 15886
		// (get) Token: 0x0600ECE6 RID: 60646 RVA: 0x0035A8D8 File Offset: 0x00358AD8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600ECE7 RID: 60647 RVA: 0x0035A8E5 File Offset: 0x00358AE5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600ECE8 RID: 60648 RVA: 0x0035A8EC File Offset: 0x00358AEC
		public static TowerConfig GetRootAsTowerConfig(ByteBuffer _bb)
		{
			return TowerConfig.GetRootAsTowerConfig(_bb, default(TowerConfig));
		}

		// Token: 0x0600ECE9 RID: 60649 RVA: 0x0035A908 File Offset: 0x00358B08
		public static TowerConfig GetRootAsTowerConfig(ByteBuffer _bb, TowerConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600ECEA RID: 60650 RVA: 0x0035A925 File Offset: 0x00358B25
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600ECEB RID: 60651 RVA: 0x0035A934 File Offset: 0x00358B34
		public TowerConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003E0F RID: 15887
		// (get) Token: 0x0600ECEC RID: 60652 RVA: 0x0035A944 File Offset: 0x00358B44
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

		// Token: 0x17003E10 RID: 15888
		// (get) Token: 0x0600ECED RID: 60653 RVA: 0x0035A980 File Offset: 0x00358B80
		public int Season
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

		// Token: 0x17003E11 RID: 15889
		// (get) Token: 0x0600ECEE RID: 60654 RVA: 0x0035A9BC File Offset: 0x00358BBC
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

		// Token: 0x17003E12 RID: 15890
		// (get) Token: 0x0600ECEF RID: 60655 RVA: 0x0035A9F8 File Offset: 0x00358BF8
		public int AreaNum
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

		// Token: 0x17003E13 RID: 15891
		// (get) Token: 0x0600ECF0 RID: 60656 RVA: 0x0035AA38 File Offset: 0x00358C38
		public int Floor
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

		// Token: 0x17003E14 RID: 15892
		// (get) Token: 0x0600ECF1 RID: 60657 RVA: 0x0035AA78 File Offset: 0x00358C78
		public int InstanceId
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

		// Token: 0x17003E15 RID: 15893
		// (get) Token: 0x0600ECF2 RID: 60658 RVA: 0x0035AAB8 File Offset: 0x00358CB8
		public string AreaName
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

		// Token: 0x0600ECF3 RID: 60659 RVA: 0x0035AAF0 File Offset: 0x00358CF0
		public Span<byte> GetAreaNameBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600ECF4 RID: 60660 RVA: 0x0035AB00 File Offset: 0x00358D00
		public byte[] GetAreaNameArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17003E16 RID: 15894
		// (get) Token: 0x0600ECF5 RID: 60661 RVA: 0x0035AB18 File Offset: 0x00358D18
		public int Cost
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

		// Token: 0x0600ECF6 RID: 60662 RVA: 0x0035AB58 File Offset: 0x00358D58
		public int RecommendElement(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003E17 RID: 15895
		// (get) Token: 0x0600ECF7 RID: 60663 RVA: 0x0035AB98 File Offset: 0x00358D98
		public int RecommendElementLength
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

		// Token: 0x0600ECF8 RID: 60664 RVA: 0x0035ABC4 File Offset: 0x00358DC4
		public Span<int> GetRecommendElementBytes()
		{
			return this.__p.__vector_as_span<int>(20, 4);
		}

		// Token: 0x0600ECF9 RID: 60665 RVA: 0x0035ABD4 File Offset: 0x00358DD4
		public int[] GetRecommendElementArray()
		{
			return this.__p.__vector_as_array<int>(20) ?? Array.Empty<int>();
		}

		// Token: 0x0600ECFA RID: 60666 RVA: 0x0035ABEC File Offset: 0x00358DEC
		public int ShowMonsters(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003E18 RID: 15896
		// (get) Token: 0x0600ECFB RID: 60667 RVA: 0x0035AC2C File Offset: 0x00358E2C
		public int ShowMonstersLength
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

		// Token: 0x0600ECFC RID: 60668 RVA: 0x0035AC58 File Offset: 0x00358E58
		public Span<int> GetShowMonstersBytes()
		{
			return this.__p.__vector_as_span<int>(22, 4);
		}

		// Token: 0x0600ECFD RID: 60669 RVA: 0x0035AC68 File Offset: 0x00358E68
		public int[] GetShowMonstersArray()
		{
			return this.__p.__vector_as_array<int>(22) ?? Array.Empty<int>();
		}

		// Token: 0x0600ECFE RID: 60670 RVA: 0x0035AC80 File Offset: 0x00358E80
		public IntPair? ShowMonstersAndLevel(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return null;
			}
			return new IntPair?(default(IntPair).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003E19 RID: 15897
		// (get) Token: 0x0600ECFF RID: 60671 RVA: 0x0035ACE4 File Offset: 0x00358EE4
		public int ShowMonstersAndLevelLength
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

		// Token: 0x0600ED00 RID: 60672 RVA: 0x0035AD10 File Offset: 0x00358F10
		public long ShowBuffs(int j)
		{
			int num = this.__p.__offset(26);
			return (long)((num != 0) ? this.__p.bb.GetDouble(this.__p.__vector(num) + j * 8) : 0.0);
		}

		// Token: 0x17003E1A RID: 15898
		// (get) Token: 0x0600ED01 RID: 60673 RVA: 0x0035AD5C File Offset: 0x00358F5C
		public int ShowBuffsLength
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

		// Token: 0x0600ED02 RID: 60674 RVA: 0x0035AD88 File Offset: 0x00358F88
		public Span<long> GetShowBuffsBytes()
		{
			return MemoryMarshal.Cast<double, long>(this.__p.__vector_as_span<double>(26, 8));
		}

		// Token: 0x0600ED03 RID: 60675 RVA: 0x0035AD9D File Offset: 0x00358F9D
		public long[] GetShowBuffsArray()
		{
			return Array.ConvertAll<double, long>(this.__p.__vector_as_array<double>(26) ?? Array.Empty<double>(), (double x) => (long)x);
		}

		// Token: 0x0600ED04 RID: 60676 RVA: 0x0035ADDC File Offset: 0x00358FDC
		public long RoleBuff(int j)
		{
			int num = this.__p.__offset(28);
			return (long)((num != 0) ? this.__p.bb.GetDouble(this.__p.__vector(num) + j * 8) : 0.0);
		}

		// Token: 0x17003E1B RID: 15899
		// (get) Token: 0x0600ED05 RID: 60677 RVA: 0x0035AE28 File Offset: 0x00359028
		public int RoleBuffLength
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

		// Token: 0x0600ED06 RID: 60678 RVA: 0x0035AE54 File Offset: 0x00359054
		public Span<long> GetRoleBuffBytes()
		{
			return MemoryMarshal.Cast<double, long>(this.__p.__vector_as_span<double>(28, 8));
		}

		// Token: 0x0600ED07 RID: 60679 RVA: 0x0035AE69 File Offset: 0x00359069
		public long[] GetRoleBuffArray()
		{
			return Array.ConvertAll<double, long>(this.__p.__vector_as_array<double>(28) ?? Array.Empty<double>(), (double x) => (long)x);
		}

		// Token: 0x0600ED08 RID: 60680 RVA: 0x0035AEA8 File Offset: 0x003590A8
		public long MonsterBuff(int j)
		{
			int num = this.__p.__offset(30);
			return (long)((num != 0) ? this.__p.bb.GetDouble(this.__p.__vector(num) + j * 8) : 0.0);
		}

		// Token: 0x17003E1C RID: 15900
		// (get) Token: 0x0600ED09 RID: 60681 RVA: 0x0035AEF4 File Offset: 0x003590F4
		public int MonsterBuffLength
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

		// Token: 0x0600ED0A RID: 60682 RVA: 0x0035AF20 File Offset: 0x00359120
		public Span<long> GetMonsterBuffBytes()
		{
			return MemoryMarshal.Cast<double, long>(this.__p.__vector_as_span<double>(30, 8));
		}

		// Token: 0x0600ED0B RID: 60683 RVA: 0x0035AF35 File Offset: 0x00359135
		public long[] GetMonsterBuffArray()
		{
			return Array.ConvertAll<double, long>(this.__p.__vector_as_array<double>(30) ?? Array.Empty<double>(), (double x) => (long)x);
		}

		// Token: 0x0600ED0C RID: 60684 RVA: 0x0035AF74 File Offset: 0x00359174
		public int Target(int j)
		{
			int num = this.__p.__offset(32);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003E1D RID: 15901
		// (get) Token: 0x0600ED0D RID: 60685 RVA: 0x0035AFB4 File Offset: 0x003591B4
		public int TargetLength
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

		// Token: 0x0600ED0E RID: 60686 RVA: 0x0035AFE0 File Offset: 0x003591E0
		public Span<int> GetTargetBytes()
		{
			return this.__p.__vector_as_span<int>(32, 4);
		}

		// Token: 0x0600ED0F RID: 60687 RVA: 0x0035AFF0 File Offset: 0x003591F0
		public int[] GetTargetArray()
		{
			return this.__p.__vector_as_array<int>(32) ?? Array.Empty<int>();
		}

		// Token: 0x0600ED10 RID: 60688 RVA: 0x0035B008 File Offset: 0x00359208
		public int TargetConfig(int j)
		{
			int num = this.__p.__offset(34);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003E1E RID: 15902
		// (get) Token: 0x0600ED11 RID: 60689 RVA: 0x0035B048 File Offset: 0x00359248
		public int TargetConfigLength
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

		// Token: 0x0600ED12 RID: 60690 RVA: 0x0035B074 File Offset: 0x00359274
		public Span<int> GetTargetConfigBytes()
		{
			return this.__p.__vector_as_span<int>(34, 4);
		}

		// Token: 0x0600ED13 RID: 60691 RVA: 0x0035B084 File Offset: 0x00359284
		public int[] GetTargetConfigArray()
		{
			return this.__p.__vector_as_array<int>(34) ?? Array.Empty<int>();
		}

		// Token: 0x17003E1F RID: 15903
		// (get) Token: 0x0600ED14 RID: 60692 RVA: 0x0035B09C File Offset: 0x0035929C
		public string BgPath
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

		// Token: 0x0600ED15 RID: 60693 RVA: 0x0035B0D4 File Offset: 0x003592D4
		public Span<byte> GetBgPathBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x0600ED16 RID: 60694 RVA: 0x0035B0E4 File Offset: 0x003592E4
		public byte[] GetBgPathArray()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x17003E20 RID: 15904
		// (get) Token: 0x0600ED17 RID: 60695 RVA: 0x0035B0FC File Offset: 0x003592FC
		public string ItemBgPath
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

		// Token: 0x0600ED18 RID: 60696 RVA: 0x0035B134 File Offset: 0x00359334
		public Span<byte> GetItemBgPathBytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x0600ED19 RID: 60697 RVA: 0x0035B144 File Offset: 0x00359344
		public byte[] GetItemBgPathArray()
		{
			return this.__p.__vector_as_array<byte>(38) ?? Array.Empty<byte>();
		}

		// Token: 0x0600ED1A RID: 60698 RVA: 0x0035B15C File Offset: 0x0035935C
		[NullableContext(1)]
		public long[] MonsterBuff()
		{
			return this.GetMonsterBuffArray();
		}

		// Token: 0x0600ED1B RID: 60699 RVA: 0x0035B164 File Offset: 0x00359364
		[NullableContext(1)]
		public IEnumerable<long> MonsterBuffIter()
		{
			TowerConfig.<MonsterBuffIter>d__73 <MonsterBuffIter>d__ = new TowerConfig.<MonsterBuffIter>d__73(-2);
			<MonsterBuffIter>d__.<>3__<>4__this = this;
			return <MonsterBuffIter>d__;
		}

		// Token: 0x0600ED1C RID: 60700 RVA: 0x0035B179 File Offset: 0x00359379
		[NullableContext(1)]
		public int[] RecommendElement()
		{
			return this.GetRecommendElementArray();
		}

		// Token: 0x0600ED1D RID: 60701 RVA: 0x0035B181 File Offset: 0x00359381
		[NullableContext(1)]
		public IEnumerable<int> RecommendElementIter()
		{
			TowerConfig.<RecommendElementIter>d__75 <RecommendElementIter>d__ = new TowerConfig.<RecommendElementIter>d__75(-2);
			<RecommendElementIter>d__.<>3__<>4__this = this;
			return <RecommendElementIter>d__;
		}

		// Token: 0x0600ED1E RID: 60702 RVA: 0x0035B196 File Offset: 0x00359396
		[NullableContext(1)]
		public long[] RoleBuff()
		{
			return this.GetRoleBuffArray();
		}

		// Token: 0x0600ED1F RID: 60703 RVA: 0x0035B19E File Offset: 0x0035939E
		[NullableContext(1)]
		public IEnumerable<long> RoleBuffIter()
		{
			TowerConfig.<RoleBuffIter>d__77 <RoleBuffIter>d__ = new TowerConfig.<RoleBuffIter>d__77(-2);
			<RoleBuffIter>d__.<>3__<>4__this = this;
			return <RoleBuffIter>d__;
		}

		// Token: 0x0600ED20 RID: 60704 RVA: 0x0035B1B3 File Offset: 0x003593B3
		[NullableContext(1)]
		public long[] ShowBuffs()
		{
			return this.GetShowBuffsArray();
		}

		// Token: 0x0600ED21 RID: 60705 RVA: 0x0035B1BB File Offset: 0x003593BB
		[NullableContext(1)]
		public IEnumerable<long> ShowBuffsIter()
		{
			TowerConfig.<ShowBuffsIter>d__79 <ShowBuffsIter>d__ = new TowerConfig.<ShowBuffsIter>d__79(-2);
			<ShowBuffsIter>d__.<>3__<>4__this = this;
			return <ShowBuffsIter>d__;
		}

		// Token: 0x0600ED22 RID: 60706 RVA: 0x0035B1D0 File Offset: 0x003593D0
		[NullableContext(1)]
		public int[] ShowMonsters()
		{
			return this.GetShowMonstersArray();
		}

		// Token: 0x0600ED23 RID: 60707 RVA: 0x0035B1D8 File Offset: 0x003593D8
		[NullableContext(1)]
		public IEnumerable<int> ShowMonstersIter()
		{
			TowerConfig.<ShowMonstersIter>d__81 <ShowMonstersIter>d__ = new TowerConfig.<ShowMonstersIter>d__81(-2);
			<ShowMonstersIter>d__.<>3__<>4__this = this;
			return <ShowMonstersIter>d__;
		}

		// Token: 0x0600ED24 RID: 60708 RVA: 0x0035B1ED File Offset: 0x003593ED
		[NullableContext(1)]
		public IntPair[] ShowMonstersAndLevel()
		{
			return this.ShowMonstersAndLevelIter().ToArray<IntPair>();
		}

		// Token: 0x0600ED25 RID: 60709 RVA: 0x0035B1FA File Offset: 0x003593FA
		[NullableContext(1)]
		public IEnumerable<IntPair> ShowMonstersAndLevelIter()
		{
			TowerConfig.<ShowMonstersAndLevelIter>d__83 <ShowMonstersAndLevelIter>d__ = new TowerConfig.<ShowMonstersAndLevelIter>d__83(-2);
			<ShowMonstersAndLevelIter>d__.<>3__<>4__this = this;
			return <ShowMonstersAndLevelIter>d__;
		}

		// Token: 0x0600ED26 RID: 60710 RVA: 0x0035B20F File Offset: 0x0035940F
		[NullableContext(1)]
		public int[] Target()
		{
			return this.GetTargetArray();
		}

		// Token: 0x0600ED27 RID: 60711 RVA: 0x0035B217 File Offset: 0x00359417
		[NullableContext(1)]
		public IEnumerable<int> TargetIter()
		{
			TowerConfig.<TargetIter>d__85 <TargetIter>d__ = new TowerConfig.<TargetIter>d__85(-2);
			<TargetIter>d__.<>3__<>4__this = this;
			return <TargetIter>d__;
		}

		// Token: 0x0600ED28 RID: 60712 RVA: 0x0035B22C File Offset: 0x0035942C
		[NullableContext(1)]
		public int[] TargetConfig()
		{
			return this.GetTargetConfigArray();
		}

		// Token: 0x0600ED29 RID: 60713 RVA: 0x0035B234 File Offset: 0x00359434
		[NullableContext(1)]
		public IEnumerable<int> TargetConfigIter()
		{
			TowerConfig.<TargetConfigIter>d__87 <TargetConfigIter>d__ = new TowerConfig.<TargetConfigIter>d__87(-2);
			<TargetConfigIter>d__.<>3__<>4__this = this;
			return <TargetConfigIter>d__;
		}

		// Token: 0x040058BB RID: 22715
		private Table __p;
	}
}

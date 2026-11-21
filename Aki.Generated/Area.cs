using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BDB RID: 3035
	public struct Area : IFlatbufferObject
	{
		// Token: 0x17000326 RID: 806
		// (get) Token: 0x06004D77 RID: 19831 RVA: 0x001F6331 File Offset: 0x001F4531
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004D78 RID: 19832 RVA: 0x001F633E File Offset: 0x001F453E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004D79 RID: 19833 RVA: 0x001F6348 File Offset: 0x001F4548
		public static Area GetRootAsArea(ByteBuffer _bb)
		{
			return Area.GetRootAsArea(_bb, default(Area));
		}

		// Token: 0x06004D7A RID: 19834 RVA: 0x001F6364 File Offset: 0x001F4564
		public static Area GetRootAsArea(ByteBuffer _bb, Area obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004D7B RID: 19835 RVA: 0x001F6381 File Offset: 0x001F4581
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004D7C RID: 19836 RVA: 0x001F6390 File Offset: 0x001F4590
		public Area __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x06004D7D RID: 19837 RVA: 0x001F63A0 File Offset: 0x001F45A0
		public int AreaId
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

		// Token: 0x17000328 RID: 808
		// (get) Token: 0x06004D7E RID: 19838 RVA: 0x001F63DC File Offset: 0x001F45DC
		public int Level
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

		// Token: 0x17000329 RID: 809
		// (get) Token: 0x06004D7F RID: 19839 RVA: 0x001F6418 File Offset: 0x001F4618
		public int CountryId
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

		// Token: 0x1700032A RID: 810
		// (get) Token: 0x06004D80 RID: 19840 RVA: 0x001F6454 File Offset: 0x001F4654
		public int DeliveryMarkId
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

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x06004D81 RID: 19841 RVA: 0x001F6494 File Offset: 0x001F4694
		public string AreaName
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

		// Token: 0x06004D82 RID: 19842 RVA: 0x001F64CC File Offset: 0x001F46CC
		public Span<byte> GetAreaNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06004D83 RID: 19843 RVA: 0x001F64DC File Offset: 0x001F46DC
		public byte[] GetAreaNameArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x1700032C RID: 812
		// (get) Token: 0x06004D84 RID: 19844 RVA: 0x001F64F4 File Offset: 0x001F46F4
		public int MapConfigId
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 8;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700032D RID: 813
		// (get) Token: 0x06004D85 RID: 19845 RVA: 0x001F6534 File Offset: 0x001F4734
		public int DungeonId
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 8;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x06004D86 RID: 19846 RVA: 0x001F6574 File Offset: 0x001F4774
		public string Title
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

		// Token: 0x06004D87 RID: 19847 RVA: 0x001F65AC File Offset: 0x001F47AC
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06004D88 RID: 19848 RVA: 0x001F65BC File Offset: 0x001F47BC
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x06004D89 RID: 19849 RVA: 0x001F65D4 File Offset: 0x001F47D4
		public int Father
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

		// Token: 0x06004D8A RID: 19850 RVA: 0x001F6614 File Offset: 0x001F4814
		public int Tag(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x06004D8B RID: 19851 RVA: 0x001F6654 File Offset: 0x001F4854
		public int TagLength
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

		// Token: 0x06004D8C RID: 19852 RVA: 0x001F6680 File Offset: 0x001F4880
		public Span<int> GetTagBytes()
		{
			return this.__p.__vector_as_span<int>(22, 4);
		}

		// Token: 0x06004D8D RID: 19853 RVA: 0x001F6690 File Offset: 0x001F4890
		public int[] GetTagArray()
		{
			return this.__p.__vector_as_array<int>(22) ?? Array.Empty<int>();
		}

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x06004D8E RID: 19854 RVA: 0x001F66A8 File Offset: 0x001F48A8
		public int Record
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

		// Token: 0x17000332 RID: 818
		// (get) Token: 0x06004D8F RID: 19855 RVA: 0x001F66E8 File Offset: 0x001F48E8
		public int Tips
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

		// Token: 0x17000333 RID: 819
		// (get) Token: 0x06004D90 RID: 19856 RVA: 0x001F6728 File Offset: 0x001F4928
		public bool IsInitActived
		{
			get
			{
				int num = this.__p.__offset(28);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06004D91 RID: 19857 RVA: 0x001F6768 File Offset: 0x001F4968
		public DicIntInt? WorldMonsterLevelMax(int j)
		{
			int num = this.__p.__offset(30);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x06004D92 RID: 19858 RVA: 0x001F67CC File Offset: 0x001F49CC
		public int WorldMonsterLevelMaxLength
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

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x06004D93 RID: 19859 RVA: 0x001F67F8 File Offset: 0x001F49F8
		public int WeatherGroupId
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000336 RID: 822
		// (get) Token: 0x06004D94 RID: 19860 RVA: 0x001F6838 File Offset: 0x001F4A38
		public int WuYinQuID
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

		// Token: 0x17000337 RID: 823
		// (get) Token: 0x06004D95 RID: 19861 RVA: 0x001F6878 File Offset: 0x001F4A78
		public int StateId
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

		// Token: 0x17000338 RID: 824
		// (get) Token: 0x06004D96 RID: 19862 RVA: 0x001F68B8 File Offset: 0x001F4AB8
		public int AtmosphereId
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

		// Token: 0x17000339 RID: 825
		// (get) Token: 0x06004D97 RID: 19863 RVA: 0x001F68F8 File Offset: 0x001F4AF8
		public string EdgeWallName
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

		// Token: 0x06004D98 RID: 19864 RVA: 0x001F6930 File Offset: 0x001F4B30
		public Span<byte> GetEdgeWallNameBytes()
		{
			return this.__p.__vector_as_span<byte>(40, 1);
		}

		// Token: 0x06004D99 RID: 19865 RVA: 0x001F6940 File Offset: 0x001F4B40
		public byte[] GetEdgeWallNameArray()
		{
			return this.__p.__vector_as_array<byte>(40) ?? Array.Empty<byte>();
		}

		// Token: 0x1700033A RID: 826
		// (get) Token: 0x06004D9A RID: 19866 RVA: 0x001F6958 File Offset: 0x001F4B58
		public int DeliveryMarkType
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

		// Token: 0x1700033B RID: 827
		// (get) Token: 0x06004D9B RID: 19867 RVA: 0x001F6998 File Offset: 0x001F4B98
		public int SortIndex
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

		// Token: 0x06004D9C RID: 19868 RVA: 0x001F69D8 File Offset: 0x001F4BD8
		public DicIntInt? EnterAreaTags(int j)
		{
			int num = this.__p.__offset(46);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x06004D9D RID: 19869 RVA: 0x001F6A3C File Offset: 0x001F4C3C
		public int EnterAreaTagsLength
		{
			get
			{
				int num = this.__p.__offset(46);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06004D9E RID: 19870 RVA: 0x001F6A68 File Offset: 0x001F4C68
		public DicIntInt? LeaveAreaTags(int j)
		{
			int num = this.__p.__offset(48);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700033D RID: 829
		// (get) Token: 0x06004D9F RID: 19871 RVA: 0x001F6ACC File Offset: 0x001F4CCC
		public int LeaveAreaTagsLength
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

		// Token: 0x1700033E RID: 830
		// (get) Token: 0x06004DA0 RID: 19872 RVA: 0x001F6AF8 File Offset: 0x001F4CF8
		public int PhantomFormationId
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

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x06004DA1 RID: 19873 RVA: 0x001F6B38 File Offset: 0x001F4D38
		public bool PhantomFormationMultiSwitch
		{
			get
			{
				int num = this.__p.__offset(52);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000340 RID: 832
		// (get) Token: 0x06004DA2 RID: 19874 RVA: 0x001F6B78 File Offset: 0x001F4D78
		public int SunSpiritAreaCollectMaxNum
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

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x06004DA3 RID: 19875 RVA: 0x001F6BB8 File Offset: 0x001F4DB8
		public bool IsDisableInExplore
		{
			get
			{
				int num = this.__p.__offset(56);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x06004DA4 RID: 19876 RVA: 0x001F6BF8 File Offset: 0x001F4DF8
		public bool IsPlayerPosNeedCheck
		{
			get
			{
				int num = this.__p.__offset(58);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x06004DA5 RID: 19877 RVA: 0x001F6C38 File Offset: 0x001F4E38
		public int IsEnableSceneInteractionEffects
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

		// Token: 0x06004DA6 RID: 19878 RVA: 0x001F6C78 File Offset: 0x001F4E78
		public DicIntInt? FunctionIDs(int j)
		{
			int num = this.__p.__offset(62);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x06004DA7 RID: 19879 RVA: 0x001F6CDC File Offset: 0x001F4EDC
		public int FunctionIDsLength
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

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x06004DA8 RID: 19880 RVA: 0x001F6D08 File Offset: 0x001F4F08
		public int OutAreaBorderConfigId
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

		// Token: 0x06004DA9 RID: 19881 RVA: 0x001F6D48 File Offset: 0x001F4F48
		public int TreasureChestStatTypes(int j)
		{
			int num = this.__p.__offset(66);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x06004DAA RID: 19882 RVA: 0x001F6D88 File Offset: 0x001F4F88
		public int TreasureChestStatTypesLength
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

		// Token: 0x06004DAB RID: 19883 RVA: 0x001F6DB4 File Offset: 0x001F4FB4
		public Span<int> GetTreasureChestStatTypesBytes()
		{
			return this.__p.__vector_as_span<int>(66, 4);
		}

		// Token: 0x06004DAC RID: 19884 RVA: 0x001F6DC4 File Offset: 0x001F4FC4
		public int[] GetTreasureChestStatTypesArray()
		{
			return this.__p.__vector_as_array<int>(66) ?? Array.Empty<int>();
		}

		// Token: 0x06004DAD RID: 19885 RVA: 0x001F6DDC File Offset: 0x001F4FDC
		[NullableContext(1)]
		public Dictionary<int, int> EnterAreaTags()
		{
			return this.EnterAreaTagsIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06004DAE RID: 19886 RVA: 0x001F6E32 File Offset: 0x001F5032
		[NullableContext(1)]
		public IEnumerable<DicIntInt> EnterAreaTagsIter()
		{
			Area.<EnterAreaTagsIter>d__89 <EnterAreaTagsIter>d__ = new Area.<EnterAreaTagsIter>d__89(-2);
			<EnterAreaTagsIter>d__.<>3__<>4__this = this;
			return <EnterAreaTagsIter>d__;
		}

		// Token: 0x06004DAF RID: 19887 RVA: 0x001F6E48 File Offset: 0x001F5048
		[NullableContext(1)]
		public Dictionary<int, int> FunctionIDs()
		{
			return this.FunctionIDsIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06004DB0 RID: 19888 RVA: 0x001F6E9E File Offset: 0x001F509E
		[NullableContext(1)]
		public IEnumerable<DicIntInt> FunctionIDsIter()
		{
			Area.<FunctionIDsIter>d__91 <FunctionIDsIter>d__ = new Area.<FunctionIDsIter>d__91(-2);
			<FunctionIDsIter>d__.<>3__<>4__this = this;
			return <FunctionIDsIter>d__;
		}

		// Token: 0x06004DB1 RID: 19889 RVA: 0x001F6EB4 File Offset: 0x001F50B4
		[NullableContext(1)]
		public Dictionary<int, int> LeaveAreaTags()
		{
			return this.LeaveAreaTagsIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06004DB2 RID: 19890 RVA: 0x001F6F0A File Offset: 0x001F510A
		[NullableContext(1)]
		public IEnumerable<DicIntInt> LeaveAreaTagsIter()
		{
			Area.<LeaveAreaTagsIter>d__93 <LeaveAreaTagsIter>d__ = new Area.<LeaveAreaTagsIter>d__93(-2);
			<LeaveAreaTagsIter>d__.<>3__<>4__this = this;
			return <LeaveAreaTagsIter>d__;
		}

		// Token: 0x06004DB3 RID: 19891 RVA: 0x001F6F1F File Offset: 0x001F511F
		[NullableContext(1)]
		public int[] Tag()
		{
			return this.GetTagArray();
		}

		// Token: 0x06004DB4 RID: 19892 RVA: 0x001F6F27 File Offset: 0x001F5127
		[NullableContext(1)]
		public IEnumerable<int> TagIter()
		{
			Area.<TagIter>d__95 <TagIter>d__ = new Area.<TagIter>d__95(-2);
			<TagIter>d__.<>3__<>4__this = this;
			return <TagIter>d__;
		}

		// Token: 0x06004DB5 RID: 19893 RVA: 0x001F6F3C File Offset: 0x001F513C
		[NullableContext(1)]
		public int[] TreasureChestStatTypes()
		{
			return this.GetTreasureChestStatTypesArray();
		}

		// Token: 0x06004DB6 RID: 19894 RVA: 0x001F6F44 File Offset: 0x001F5144
		[NullableContext(1)]
		public IEnumerable<int> TreasureChestStatTypesIter()
		{
			Area.<TreasureChestStatTypesIter>d__97 <TreasureChestStatTypesIter>d__ = new Area.<TreasureChestStatTypesIter>d__97(-2);
			<TreasureChestStatTypesIter>d__.<>3__<>4__this = this;
			return <TreasureChestStatTypesIter>d__;
		}

		// Token: 0x06004DB7 RID: 19895 RVA: 0x001F6F5C File Offset: 0x001F515C
		[NullableContext(1)]
		public Dictionary<int, int> WorldMonsterLevelMax()
		{
			return this.WorldMonsterLevelMaxIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06004DB8 RID: 19896 RVA: 0x001F6FB2 File Offset: 0x001F51B2
		[NullableContext(1)]
		public IEnumerable<DicIntInt> WorldMonsterLevelMaxIter()
		{
			Area.<WorldMonsterLevelMaxIter>d__99 <WorldMonsterLevelMaxIter>d__ = new Area.<WorldMonsterLevelMaxIter>d__99(-2);
			<WorldMonsterLevelMaxIter>d__.<>3__<>4__this = this;
			return <WorldMonsterLevelMaxIter>d__;
		}

		// Token: 0x06004DB9 RID: 19897 RVA: 0x001F6FC8 File Offset: 0x001F51C8
		public int? GetEnterAreaTags(int key)
		{
			this.EnsureEnterAreaTagsCacheIfNeeded();
			int value;
			if (!this.EnterAreaTagsCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x06004DBA RID: 19898 RVA: 0x001F6FFC File Offset: 0x001F51FC
		public int? GetFunctionIDs(int key)
		{
			this.EnsureFunctionIDsCacheIfNeeded();
			int value;
			if (!this.FunctionIDsCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x06004DBB RID: 19899 RVA: 0x001F7030 File Offset: 0x001F5230
		public int? GetLeaveAreaTags(int key)
		{
			this.EnsureLeaveAreaTagsCacheIfNeeded();
			int value;
			if (!this.LeaveAreaTagsCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x06004DBC RID: 19900 RVA: 0x001F7064 File Offset: 0x001F5264
		public int? GetWorldMonsterLevelMax(int key)
		{
			this.EnsureWorldMonsterLevelMaxCacheIfNeeded();
			int value;
			if (!this.WorldMonsterLevelMaxCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x06004DBD RID: 19901 RVA: 0x001F7098 File Offset: 0x001F5298
		private void EnsureEnterAreaTagsCacheIfNeeded()
		{
			if (this.EnterAreaTagsCache != null)
			{
				return;
			}
			this.EnterAreaTagsCache = this.EnterAreaTagsIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06004DBE RID: 19902 RVA: 0x001F7100 File Offset: 0x001F5300
		private void EnsureFunctionIDsCacheIfNeeded()
		{
			if (this.FunctionIDsCache != null)
			{
				return;
			}
			this.FunctionIDsCache = this.FunctionIDsIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06004DBF RID: 19903 RVA: 0x001F7168 File Offset: 0x001F5368
		private void EnsureLeaveAreaTagsCacheIfNeeded()
		{
			if (this.LeaveAreaTagsCache != null)
			{
				return;
			}
			this.LeaveAreaTagsCache = this.LeaveAreaTagsIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06004DC0 RID: 19904 RVA: 0x001F71D0 File Offset: 0x001F53D0
		private void EnsureWorldMonsterLevelMaxCacheIfNeeded()
		{
			if (this.WorldMonsterLevelMaxCache != null)
			{
				return;
			}
			this.WorldMonsterLevelMaxCache = this.WorldMonsterLevelMaxIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06004DC1 RID: 19905 RVA: 0x001F7236 File Offset: 0x001F5436
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetEnterAreaTagsFrozenDict()
		{
			this.EnsureEnterAreaTagsCacheIfNeeded();
			return this.EnterAreaTagsCache;
		}

		// Token: 0x06004DC2 RID: 19906 RVA: 0x001F7244 File Offset: 0x001F5444
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetFunctionIDsFrozenDict()
		{
			this.EnsureFunctionIDsCacheIfNeeded();
			return this.FunctionIDsCache;
		}

		// Token: 0x06004DC3 RID: 19907 RVA: 0x001F7252 File Offset: 0x001F5452
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetLeaveAreaTagsFrozenDict()
		{
			this.EnsureLeaveAreaTagsCacheIfNeeded();
			return this.LeaveAreaTagsCache;
		}

		// Token: 0x06004DC4 RID: 19908 RVA: 0x001F7260 File Offset: 0x001F5460
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetWorldMonsterLevelMaxFrozenDict()
		{
			this.EnsureWorldMonsterLevelMaxCacheIfNeeded();
			return this.WorldMonsterLevelMaxCache;
		}

		// Token: 0x040050BC RID: 20668
		private Table __p;

		// Token: 0x040050BD RID: 20669
		[Nullable(2)]
		private FrozenDictionary<int, int> EnterAreaTagsCache;

		// Token: 0x040050BE RID: 20670
		[Nullable(2)]
		private FrozenDictionary<int, int> FunctionIDsCache;

		// Token: 0x040050BF RID: 20671
		[Nullable(2)]
		private FrozenDictionary<int, int> LeaveAreaTagsCache;

		// Token: 0x040050C0 RID: 20672
		[Nullable(2)]
		private FrozenDictionary<int, int> WorldMonsterLevelMaxCache;
	}
}

using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B01 RID: 2817
	public struct Area : IFlatbufferObject
	{
		// Token: 0x1700030F RID: 783
		// (get) Token: 0x06004830 RID: 18480 RVA: 0x001D6AA9 File Offset: 0x001D4CA9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004831 RID: 18481 RVA: 0x001D6AB6 File Offset: 0x001D4CB6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004832 RID: 18482 RVA: 0x001D6AC0 File Offset: 0x001D4CC0
		public static Area GetRootAsArea(ByteBuffer _bb)
		{
			return Area.GetRootAsArea(_bb, default(Area));
		}

		// Token: 0x06004833 RID: 18483 RVA: 0x001D6ADC File Offset: 0x001D4CDC
		public static Area GetRootAsArea(ByteBuffer _bb, Area obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004834 RID: 18484 RVA: 0x001D6AF9 File Offset: 0x001D4CF9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004835 RID: 18485 RVA: 0x001D6B08 File Offset: 0x001D4D08
		public Area __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x06004836 RID: 18486 RVA: 0x001D6B18 File Offset: 0x001D4D18
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

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x06004837 RID: 18487 RVA: 0x001D6B54 File Offset: 0x001D4D54
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

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x06004838 RID: 18488 RVA: 0x001D6B90 File Offset: 0x001D4D90
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

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x06004839 RID: 18489 RVA: 0x001D6BCC File Offset: 0x001D4DCC
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

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x0600483A RID: 18490 RVA: 0x001D6C0C File Offset: 0x001D4E0C
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

		// Token: 0x0600483B RID: 18491 RVA: 0x001D6C44 File Offset: 0x001D4E44
		public Span<byte> GetAreaNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600483C RID: 18492 RVA: 0x001D6C54 File Offset: 0x001D4E54
		public byte[] GetAreaNameArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x0600483D RID: 18493 RVA: 0x001D6C6C File Offset: 0x001D4E6C
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

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x0600483E RID: 18494 RVA: 0x001D6CAC File Offset: 0x001D4EAC
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

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x0600483F RID: 18495 RVA: 0x001D6CEC File Offset: 0x001D4EEC
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

		// Token: 0x06004840 RID: 18496 RVA: 0x001D6D24 File Offset: 0x001D4F24
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06004841 RID: 18497 RVA: 0x001D6D34 File Offset: 0x001D4F34
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x06004842 RID: 18498 RVA: 0x001D6D4C File Offset: 0x001D4F4C
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

		// Token: 0x06004843 RID: 18499 RVA: 0x001D6D8C File Offset: 0x001D4F8C
		public int Tag(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x06004844 RID: 18500 RVA: 0x001D6DCC File Offset: 0x001D4FCC
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

		// Token: 0x06004845 RID: 18501 RVA: 0x001D6DF8 File Offset: 0x001D4FF8
		public Span<int> GetTagBytes()
		{
			return this.__p.__vector_as_span<int>(22, 4);
		}

		// Token: 0x06004846 RID: 18502 RVA: 0x001D6E08 File Offset: 0x001D5008
		public int[] GetTagArray()
		{
			return this.__p.__vector_as_array<int>(22) ?? Array.Empty<int>();
		}

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x06004847 RID: 18503 RVA: 0x001D6E20 File Offset: 0x001D5020
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

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x06004848 RID: 18504 RVA: 0x001D6E60 File Offset: 0x001D5060
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

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x06004849 RID: 18505 RVA: 0x001D6EA0 File Offset: 0x001D50A0
		public bool IsInitActived
		{
			get
			{
				int num = this.__p.__offset(28);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0600484A RID: 18506 RVA: 0x001D6EE0 File Offset: 0x001D50E0
		public DicIntInt? WorldMonsterLevelMax(int j)
		{
			int num = this.__p.__offset(30);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x0600484B RID: 18507 RVA: 0x001D6F44 File Offset: 0x001D5144
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

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x0600484C RID: 18508 RVA: 0x001D6F70 File Offset: 0x001D5170
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

		// Token: 0x1700031F RID: 799
		// (get) Token: 0x0600484D RID: 18509 RVA: 0x001D6FB0 File Offset: 0x001D51B0
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

		// Token: 0x17000320 RID: 800
		// (get) Token: 0x0600484E RID: 18510 RVA: 0x001D6FF0 File Offset: 0x001D51F0
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

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x0600484F RID: 18511 RVA: 0x001D7030 File Offset: 0x001D5230
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

		// Token: 0x17000322 RID: 802
		// (get) Token: 0x06004850 RID: 18512 RVA: 0x001D7070 File Offset: 0x001D5270
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

		// Token: 0x06004851 RID: 18513 RVA: 0x001D70A8 File Offset: 0x001D52A8
		public Span<byte> GetEdgeWallNameBytes()
		{
			return this.__p.__vector_as_span<byte>(40, 1);
		}

		// Token: 0x06004852 RID: 18514 RVA: 0x001D70B8 File Offset: 0x001D52B8
		public byte[] GetEdgeWallNameArray()
		{
			return this.__p.__vector_as_array<byte>(40) ?? Array.Empty<byte>();
		}

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x06004853 RID: 18515 RVA: 0x001D70D0 File Offset: 0x001D52D0
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

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x06004854 RID: 18516 RVA: 0x001D7110 File Offset: 0x001D5310
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

		// Token: 0x06004855 RID: 18517 RVA: 0x001D7150 File Offset: 0x001D5350
		public DicIntInt? EnterAreaTags(int j)
		{
			int num = this.__p.__offset(46);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x06004856 RID: 18518 RVA: 0x001D71B4 File Offset: 0x001D53B4
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

		// Token: 0x06004857 RID: 18519 RVA: 0x001D71E0 File Offset: 0x001D53E0
		public DicIntInt? LeaveAreaTags(int j)
		{
			int num = this.__p.__offset(48);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000326 RID: 806
		// (get) Token: 0x06004858 RID: 18520 RVA: 0x001D7244 File Offset: 0x001D5444
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

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x06004859 RID: 18521 RVA: 0x001D7270 File Offset: 0x001D5470
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

		// Token: 0x17000328 RID: 808
		// (get) Token: 0x0600485A RID: 18522 RVA: 0x001D72B0 File Offset: 0x001D54B0
		public bool PhantomFormationMultiSwitch
		{
			get
			{
				int num = this.__p.__offset(52);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000329 RID: 809
		// (get) Token: 0x0600485B RID: 18523 RVA: 0x001D72F0 File Offset: 0x001D54F0
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

		// Token: 0x1700032A RID: 810
		// (get) Token: 0x0600485C RID: 18524 RVA: 0x001D7330 File Offset: 0x001D5530
		public bool IsDisableInExplore
		{
			get
			{
				int num = this.__p.__offset(56);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x0600485D RID: 18525 RVA: 0x001D7370 File Offset: 0x001D5570
		public bool IsPlayerPosNeedCheck
		{
			get
			{
				int num = this.__p.__offset(58);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700032C RID: 812
		// (get) Token: 0x0600485E RID: 18526 RVA: 0x001D73B0 File Offset: 0x001D55B0
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

		// Token: 0x0600485F RID: 18527 RVA: 0x001D73F0 File Offset: 0x001D55F0
		public DicIntInt? FunctionIDs(int j)
		{
			int num = this.__p.__offset(62);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700032D RID: 813
		// (get) Token: 0x06004860 RID: 18528 RVA: 0x001D7454 File Offset: 0x001D5654
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

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x06004861 RID: 18529 RVA: 0x001D7480 File Offset: 0x001D5680
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

		// Token: 0x06004862 RID: 18530 RVA: 0x001D74C0 File Offset: 0x001D56C0
		public int TreasureChestStatTypes(int j)
		{
			int num = this.__p.__offset(66);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x06004863 RID: 18531 RVA: 0x001D7500 File Offset: 0x001D5700
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

		// Token: 0x06004864 RID: 18532 RVA: 0x001D752C File Offset: 0x001D572C
		public Span<int> GetTreasureChestStatTypesBytes()
		{
			return this.__p.__vector_as_span<int>(66, 4);
		}

		// Token: 0x06004865 RID: 18533 RVA: 0x001D753C File Offset: 0x001D573C
		public int[] GetTreasureChestStatTypesArray()
		{
			return this.__p.__vector_as_array<int>(66) ?? Array.Empty<int>();
		}

		// Token: 0x06004866 RID: 18534 RVA: 0x001D7554 File Offset: 0x001D5754
		[NullableContext(1)]
		[Obsolete("已废弃，请使用EnterAreaTagsFrozenDict()缓存字典，遍历请使用EnterAreaTagsIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> EnterAreaTags()
		{
			return this.EnterAreaTagsIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06004867 RID: 18535 RVA: 0x001D75AA File Offset: 0x001D57AA
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> EnterAreaTagsIter()
		{
			Area.<EnterAreaTagsIter>d__89 <EnterAreaTagsIter>d__ = new Area.<EnterAreaTagsIter>d__89(-2);
			<EnterAreaTagsIter>d__.<>3__<>4__this = this;
			return <EnterAreaTagsIter>d__;
		}

		// Token: 0x06004868 RID: 18536 RVA: 0x001D75C0 File Offset: 0x001D57C0
		[NullableContext(1)]
		[Obsolete("已废弃，请使用FunctionIDsFrozenDict()缓存字典，遍历请使用FunctionIDsIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> FunctionIDs()
		{
			return this.FunctionIDsIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06004869 RID: 18537 RVA: 0x001D7616 File Offset: 0x001D5816
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> FunctionIDsIter()
		{
			Area.<FunctionIDsIter>d__91 <FunctionIDsIter>d__ = new Area.<FunctionIDsIter>d__91(-2);
			<FunctionIDsIter>d__.<>3__<>4__this = this;
			return <FunctionIDsIter>d__;
		}

		// Token: 0x0600486A RID: 18538 RVA: 0x001D762C File Offset: 0x001D582C
		[NullableContext(1)]
		[Obsolete("已废弃，请使用LeaveAreaTagsFrozenDict()缓存字典，遍历请使用LeaveAreaTagsIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> LeaveAreaTags()
		{
			return this.LeaveAreaTagsIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600486B RID: 18539 RVA: 0x001D7682 File Offset: 0x001D5882
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> LeaveAreaTagsIter()
		{
			Area.<LeaveAreaTagsIter>d__93 <LeaveAreaTagsIter>d__ = new Area.<LeaveAreaTagsIter>d__93(-2);
			<LeaveAreaTagsIter>d__.<>3__<>4__this = this;
			return <LeaveAreaTagsIter>d__;
		}

		// Token: 0x0600486C RID: 18540 RVA: 0x001D7698 File Offset: 0x001D5898
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用TagIter()或GetTagBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Tag()
		{
			Area area = this;
			return area.GetTagArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600486D RID: 18541 RVA: 0x001D76BC File Offset: 0x001D58BC
		[NullableContext(1)]
		public readonly IEnumerable<int> TagIter()
		{
			Area.<TagIter>d__95 <TagIter>d__ = new Area.<TagIter>d__95(-2);
			<TagIter>d__.<>3__<>4__this = this;
			return <TagIter>d__;
		}

		// Token: 0x0600486E RID: 18542 RVA: 0x001D76D4 File Offset: 0x001D58D4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用TreasureChestStatTypesIter()或GetTreasureChestStatTypesBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] TreasureChestStatTypes()
		{
			Area area = this;
			return area.GetTreasureChestStatTypesArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600486F RID: 18543 RVA: 0x001D76F8 File Offset: 0x001D58F8
		[NullableContext(1)]
		public readonly IEnumerable<int> TreasureChestStatTypesIter()
		{
			Area.<TreasureChestStatTypesIter>d__97 <TreasureChestStatTypesIter>d__ = new Area.<TreasureChestStatTypesIter>d__97(-2);
			<TreasureChestStatTypesIter>d__.<>3__<>4__this = this;
			return <TreasureChestStatTypesIter>d__;
		}

		// Token: 0x06004870 RID: 18544 RVA: 0x001D7710 File Offset: 0x001D5910
		[NullableContext(1)]
		[Obsolete("已废弃，请使用WorldMonsterLevelMaxFrozenDict()缓存字典，遍历请使用WorldMonsterLevelMaxIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> WorldMonsterLevelMax()
		{
			return this.WorldMonsterLevelMaxIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06004871 RID: 18545 RVA: 0x001D7766 File Offset: 0x001D5966
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> WorldMonsterLevelMaxIter()
		{
			Area.<WorldMonsterLevelMaxIter>d__99 <WorldMonsterLevelMaxIter>d__ = new Area.<WorldMonsterLevelMaxIter>d__99(-2);
			<WorldMonsterLevelMaxIter>d__.<>3__<>4__this = this;
			return <WorldMonsterLevelMaxIter>d__;
		}

		// Token: 0x06004872 RID: 18546 RVA: 0x001D777C File Offset: 0x001D597C
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

		// Token: 0x06004873 RID: 18547 RVA: 0x001D77B0 File Offset: 0x001D59B0
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

		// Token: 0x06004874 RID: 18548 RVA: 0x001D77E4 File Offset: 0x001D59E4
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

		// Token: 0x06004875 RID: 18549 RVA: 0x001D7818 File Offset: 0x001D5A18
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

		// Token: 0x06004876 RID: 18550 RVA: 0x001D784C File Offset: 0x001D5A4C
		private void EnsureEnterAreaTagsCacheIfNeeded()
		{
			if (this.EnterAreaTagsCache != null)
			{
				return;
			}
			this.EnterAreaTagsCache = this.EnterAreaTagsIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06004877 RID: 18551 RVA: 0x001D78B4 File Offset: 0x001D5AB4
		private void EnsureFunctionIDsCacheIfNeeded()
		{
			if (this.FunctionIDsCache != null)
			{
				return;
			}
			this.FunctionIDsCache = this.FunctionIDsIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06004878 RID: 18552 RVA: 0x001D791C File Offset: 0x001D5B1C
		private void EnsureLeaveAreaTagsCacheIfNeeded()
		{
			if (this.LeaveAreaTagsCache != null)
			{
				return;
			}
			this.LeaveAreaTagsCache = this.LeaveAreaTagsIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06004879 RID: 18553 RVA: 0x001D7984 File Offset: 0x001D5B84
		private void EnsureWorldMonsterLevelMaxCacheIfNeeded()
		{
			if (this.WorldMonsterLevelMaxCache != null)
			{
				return;
			}
			this.WorldMonsterLevelMaxCache = this.WorldMonsterLevelMaxIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600487A RID: 18554 RVA: 0x001D79EA File Offset: 0x001D5BEA
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetEnterAreaTagsFrozenDict(int key)
		{
			this.EnsureEnterAreaTagsCacheIfNeeded();
			return this.EnterAreaTagsCache;
		}

		// Token: 0x0600487B RID: 18555 RVA: 0x001D79F8 File Offset: 0x001D5BF8
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetFunctionIDsFrozenDict(int key)
		{
			this.EnsureFunctionIDsCacheIfNeeded();
			return this.FunctionIDsCache;
		}

		// Token: 0x0600487C RID: 18556 RVA: 0x001D7A06 File Offset: 0x001D5C06
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetLeaveAreaTagsFrozenDict(int key)
		{
			this.EnsureLeaveAreaTagsCacheIfNeeded();
			return this.LeaveAreaTagsCache;
		}

		// Token: 0x0600487D RID: 18557 RVA: 0x001D7A14 File Offset: 0x001D5C14
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetWorldMonsterLevelMaxFrozenDict(int key)
		{
			this.EnsureWorldMonsterLevelMaxCacheIfNeeded();
			return this.WorldMonsterLevelMaxCache;
		}

		// Token: 0x04004AE2 RID: 19170
		private Table __p;

		// Token: 0x04004AE3 RID: 19171
		[Nullable(2)]
		private FrozenDictionary<int, int> EnterAreaTagsCache;

		// Token: 0x04004AE4 RID: 19172
		[Nullable(2)]
		private FrozenDictionary<int, int> FunctionIDsCache;

		// Token: 0x04004AE5 RID: 19173
		[Nullable(2)]
		private FrozenDictionary<int, int> LeaveAreaTagsCache;

		// Token: 0x04004AE6 RID: 19174
		[Nullable(2)]
		private FrozenDictionary<int, int> WorldMonsterLevelMaxCache;
	}
}

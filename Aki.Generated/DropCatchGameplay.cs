using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C0D RID: 3085
	public struct DropCatchGameplay : IFlatbufferObject
	{
		// Token: 0x17000DB7 RID: 3511
		// (get) Token: 0x06006567 RID: 25959 RVA: 0x0021AF5C File Offset: 0x0021915C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006568 RID: 25960 RVA: 0x0021AF69 File Offset: 0x00219169
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006569 RID: 25961 RVA: 0x0021AF70 File Offset: 0x00219170
		public static DropCatchGameplay GetRootAsDropCatchGameplay(ByteBuffer _bb)
		{
			return DropCatchGameplay.GetRootAsDropCatchGameplay(_bb, default(DropCatchGameplay));
		}

		// Token: 0x0600656A RID: 25962 RVA: 0x0021AF8C File Offset: 0x0021918C
		public static DropCatchGameplay GetRootAsDropCatchGameplay(ByteBuffer _bb, DropCatchGameplay obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600656B RID: 25963 RVA: 0x0021AFA9 File Offset: 0x002191A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600656C RID: 25964 RVA: 0x0021AFB8 File Offset: 0x002191B8
		public DropCatchGameplay __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000DB8 RID: 3512
		// (get) Token: 0x0600656D RID: 25965 RVA: 0x0021AFC8 File Offset: 0x002191C8
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

		// Token: 0x17000DB9 RID: 3513
		// (get) Token: 0x0600656E RID: 25966 RVA: 0x0021B004 File Offset: 0x00219204
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

		// Token: 0x17000DBA RID: 3514
		// (get) Token: 0x0600656F RID: 25967 RVA: 0x0021B040 File Offset: 0x00219240
		public int OpenDay
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

		// Token: 0x06006570 RID: 25968 RVA: 0x0021B07C File Offset: 0x0021927C
		public int RewardIds(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000DBB RID: 3515
		// (get) Token: 0x06006571 RID: 25969 RVA: 0x0021B0BC File Offset: 0x002192BC
		public int RewardIdsLength
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

		// Token: 0x06006572 RID: 25970 RVA: 0x0021B0E8 File Offset: 0x002192E8
		public Span<int> GetRewardIdsBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x06006573 RID: 25971 RVA: 0x0021B0F8 File Offset: 0x002192F8
		public int[] GetRewardIdsArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x17000DBC RID: 3516
		// (get) Token: 0x06006574 RID: 25972 RVA: 0x0021B110 File Offset: 0x00219310
		public int RoleId
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

		// Token: 0x17000DBD RID: 3517
		// (get) Token: 0x06006575 RID: 25973 RVA: 0x0021B150 File Offset: 0x00219350
		public int GameplayTime
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

		// Token: 0x06006576 RID: 25974 RVA: 0x0021B190 File Offset: 0x00219390
		public int DropPoolList(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000DBE RID: 3518
		// (get) Token: 0x06006577 RID: 25975 RVA: 0x0021B1D0 File Offset: 0x002193D0
		public int DropPoolListLength
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

		// Token: 0x06006578 RID: 25976 RVA: 0x0021B1FC File Offset: 0x002193FC
		public Span<int> GetDropPoolListBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x06006579 RID: 25977 RVA: 0x0021B20C File Offset: 0x0021940C
		public int[] GetDropPoolListArray()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x0600657A RID: 25978 RVA: 0x0021B224 File Offset: 0x00219424
		public int DropItemList(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000DBF RID: 3519
		// (get) Token: 0x0600657B RID: 25979 RVA: 0x0021B264 File Offset: 0x00219464
		public int DropItemListLength
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

		// Token: 0x0600657C RID: 25980 RVA: 0x0021B290 File Offset: 0x00219490
		public Span<int> GetDropItemListBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x0600657D RID: 25981 RVA: 0x0021B2A0 File Offset: 0x002194A0
		public int[] GetDropItemListArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x0600657E RID: 25982 RVA: 0x0021B2B8 File Offset: 0x002194B8
		public float Area(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000DC0 RID: 3520
		// (get) Token: 0x0600657F RID: 25983 RVA: 0x0021B2FC File Offset: 0x002194FC
		public int AreaLength
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

		// Token: 0x06006580 RID: 25984 RVA: 0x0021B328 File Offset: 0x00219528
		public Span<float> GetAreaBytes()
		{
			return this.__p.__vector_as_span<float>(20, 4);
		}

		// Token: 0x06006581 RID: 25985 RVA: 0x0021B338 File Offset: 0x00219538
		public float[] GetAreaArray()
		{
			return this.__p.__vector_as_array<float>(20) ?? Array.Empty<float>();
		}

		// Token: 0x06006582 RID: 25986 RVA: 0x0021B350 File Offset: 0x00219550
		public float RoleBornPos(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000DC1 RID: 3521
		// (get) Token: 0x06006583 RID: 25987 RVA: 0x0021B394 File Offset: 0x00219594
		public int RoleBornPosLength
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

		// Token: 0x06006584 RID: 25988 RVA: 0x0021B3C0 File Offset: 0x002195C0
		public Span<float> GetRoleBornPosBytes()
		{
			return this.__p.__vector_as_span<float>(22, 4);
		}

		// Token: 0x06006585 RID: 25989 RVA: 0x0021B3D0 File Offset: 0x002195D0
		public float[] GetRoleBornPosArray()
		{
			return this.__p.__vector_as_array<float>(22) ?? Array.Empty<float>();
		}

		// Token: 0x17000DC2 RID: 3522
		// (get) Token: 0x06006586 RID: 25990 RVA: 0x0021B3E8 File Offset: 0x002195E8
		public string GameplayTimeCommands
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006587 RID: 25991 RVA: 0x0021B420 File Offset: 0x00219620
		public Span<byte> GetGameplayTimeCommandsBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x06006588 RID: 25992 RVA: 0x0021B430 File Offset: 0x00219630
		public byte[] GetGameplayTimeCommandsArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17000DC3 RID: 3523
		// (get) Token: 0x06006589 RID: 25993 RVA: 0x0021B448 File Offset: 0x00219648
		public string RemainingTimeCommands
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

		// Token: 0x0600658A RID: 25994 RVA: 0x0021B480 File Offset: 0x00219680
		public Span<byte> GetRemainingTimeCommandsBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600658B RID: 25995 RVA: 0x0021B490 File Offset: 0x00219690
		public byte[] GetRemainingTimeCommandsArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x17000DC4 RID: 3524
		// (get) Token: 0x0600658C RID: 25996 RVA: 0x0021B4A8 File Offset: 0x002196A8
		public string SkillCommands
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600658D RID: 25997 RVA: 0x0021B4E0 File Offset: 0x002196E0
		public Span<byte> GetSkillCommandsBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x0600658E RID: 25998 RVA: 0x0021B4F0 File Offset: 0x002196F0
		public byte[] GetSkillCommandsArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x17000DC5 RID: 3525
		// (get) Token: 0x0600658F RID: 25999 RVA: 0x0021B508 File Offset: 0x00219708
		public int NextGameplayId
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

		// Token: 0x17000DC6 RID: 3526
		// (get) Token: 0x06006590 RID: 26000 RVA: 0x0021B548 File Offset: 0x00219748
		public string Name
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006591 RID: 26001 RVA: 0x0021B580 File Offset: 0x00219780
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x06006592 RID: 26002 RVA: 0x0021B590 File Offset: 0x00219790
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x17000DC7 RID: 3527
		// (get) Token: 0x06006593 RID: 26003 RVA: 0x0021B5A8 File Offset: 0x002197A8
		public string Desc
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

		// Token: 0x06006594 RID: 26004 RVA: 0x0021B5E0 File Offset: 0x002197E0
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x06006595 RID: 26005 RVA: 0x0021B5F0 File Offset: 0x002197F0
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x17000DC8 RID: 3528
		// (get) Token: 0x06006596 RID: 26006 RVA: 0x0021B608 File Offset: 0x00219808
		public bool IsSpecial
		{
			get
			{
				int num = this.__p.__offset(36);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000DC9 RID: 3529
		// (get) Token: 0x06006597 RID: 26007 RVA: 0x0021B648 File Offset: 0x00219848
		public bool IsNeedSettle
		{
			get
			{
				int num = this.__p.__offset(38);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000DCA RID: 3530
		// (get) Token: 0x06006598 RID: 26008 RVA: 0x0021B688 File Offset: 0x00219888
		public int BgRoleId
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

		// Token: 0x06006599 RID: 26009 RVA: 0x0021B6C8 File Offset: 0x002198C8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用AreaIter()或GetAreaBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly float[] Area()
		{
			DropCatchGameplay dropCatchGameplay = this;
			return dropCatchGameplay.GetAreaArray() ?? Array.Empty<float>();
		}

		// Token: 0x0600659A RID: 26010 RVA: 0x0021B6EC File Offset: 0x002198EC
		[NullableContext(1)]
		public readonly IEnumerable<float> AreaIter()
		{
			DropCatchGameplay.<AreaIter>d__72 <AreaIter>d__ = new DropCatchGameplay.<AreaIter>d__72(-2);
			<AreaIter>d__.<>3__<>4__this = this;
			return <AreaIter>d__;
		}

		// Token: 0x0600659B RID: 26011 RVA: 0x0021B704 File Offset: 0x00219904
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用DropItemListIter()或GetDropItemListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] DropItemList()
		{
			DropCatchGameplay dropCatchGameplay = this;
			return dropCatchGameplay.GetDropItemListArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600659C RID: 26012 RVA: 0x0021B728 File Offset: 0x00219928
		[NullableContext(1)]
		public readonly IEnumerable<int> DropItemListIter()
		{
			DropCatchGameplay.<DropItemListIter>d__74 <DropItemListIter>d__ = new DropCatchGameplay.<DropItemListIter>d__74(-2);
			<DropItemListIter>d__.<>3__<>4__this = this;
			return <DropItemListIter>d__;
		}

		// Token: 0x0600659D RID: 26013 RVA: 0x0021B740 File Offset: 0x00219940
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用DropPoolListIter()或GetDropPoolListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] DropPoolList()
		{
			DropCatchGameplay dropCatchGameplay = this;
			return dropCatchGameplay.GetDropPoolListArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600659E RID: 26014 RVA: 0x0021B764 File Offset: 0x00219964
		[NullableContext(1)]
		public readonly IEnumerable<int> DropPoolListIter()
		{
			DropCatchGameplay.<DropPoolListIter>d__76 <DropPoolListIter>d__ = new DropCatchGameplay.<DropPoolListIter>d__76(-2);
			<DropPoolListIter>d__.<>3__<>4__this = this;
			return <DropPoolListIter>d__;
		}

		// Token: 0x0600659F RID: 26015 RVA: 0x0021B77C File Offset: 0x0021997C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RewardIdsIter()或GetRewardIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] RewardIds()
		{
			DropCatchGameplay dropCatchGameplay = this;
			return dropCatchGameplay.GetRewardIdsArray() ?? Array.Empty<int>();
		}

		// Token: 0x060065A0 RID: 26016 RVA: 0x0021B7A0 File Offset: 0x002199A0
		[NullableContext(1)]
		public readonly IEnumerable<int> RewardIdsIter()
		{
			DropCatchGameplay.<RewardIdsIter>d__78 <RewardIdsIter>d__ = new DropCatchGameplay.<RewardIdsIter>d__78(-2);
			<RewardIdsIter>d__.<>3__<>4__this = this;
			return <RewardIdsIter>d__;
		}

		// Token: 0x060065A1 RID: 26017 RVA: 0x0021B7B8 File Offset: 0x002199B8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RoleBornPosIter()或GetRoleBornPosBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly float[] RoleBornPos()
		{
			DropCatchGameplay dropCatchGameplay = this;
			return dropCatchGameplay.GetRoleBornPosArray() ?? Array.Empty<float>();
		}

		// Token: 0x060065A2 RID: 26018 RVA: 0x0021B7DC File Offset: 0x002199DC
		[NullableContext(1)]
		public readonly IEnumerable<float> RoleBornPosIter()
		{
			DropCatchGameplay.<RoleBornPosIter>d__80 <RoleBornPosIter>d__ = new DropCatchGameplay.<RoleBornPosIter>d__80(-2);
			<RoleBornPosIter>d__.<>3__<>4__this = this;
			return <RoleBornPosIter>d__;
		}

		// Token: 0x04004C4A RID: 19530
		private Table __p;
	}
}

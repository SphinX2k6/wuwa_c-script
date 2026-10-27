using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200107F RID: 4223
	public struct RoverRogueLoot : IFlatbufferObject
	{
		// Token: 0x17003475 RID: 13429
		// (get) Token: 0x0600CE4D RID: 52813 RVA: 0x00307232 File Offset: 0x00305432
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CE4E RID: 52814 RVA: 0x0030723F File Offset: 0x0030543F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CE4F RID: 52815 RVA: 0x00307248 File Offset: 0x00305448
		public static RoverRogueLoot GetRootAsRoverRogueLoot(ByteBuffer _bb)
		{
			return RoverRogueLoot.GetRootAsRoverRogueLoot(_bb, default(RoverRogueLoot));
		}

		// Token: 0x0600CE50 RID: 52816 RVA: 0x00307264 File Offset: 0x00305464
		public static RoverRogueLoot GetRootAsRoverRogueLoot(ByteBuffer _bb, RoverRogueLoot obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CE51 RID: 52817 RVA: 0x00307281 File Offset: 0x00305481
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CE52 RID: 52818 RVA: 0x00307290 File Offset: 0x00305490
		public RoverRogueLoot __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003476 RID: 13430
		// (get) Token: 0x0600CE53 RID: 52819 RVA: 0x003072A0 File Offset: 0x003054A0
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

		// Token: 0x17003477 RID: 13431
		// (get) Token: 0x0600CE54 RID: 52820 RVA: 0x003072DC File Offset: 0x003054DC
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

		// Token: 0x17003478 RID: 13432
		// (get) Token: 0x0600CE55 RID: 52821 RVA: 0x00307318 File Offset: 0x00305518
		public int MaxLevel
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 2;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003479 RID: 13433
		// (get) Token: 0x0600CE56 RID: 52822 RVA: 0x00307354 File Offset: 0x00305554
		public int EffectTrigger
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

		// Token: 0x1700347A RID: 13434
		// (get) Token: 0x0600CE57 RID: 52823 RVA: 0x00307394 File Offset: 0x00305594
		public int OutGameUnlockConditionId
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

		// Token: 0x0600CE58 RID: 52824 RVA: 0x003073D4 File Offset: 0x003055D4
		public int RoomPassedRequired(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700347B RID: 13435
		// (get) Token: 0x0600CE59 RID: 52825 RVA: 0x00307414 File Offset: 0x00305614
		public int RoomPassedRequiredLength
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

		// Token: 0x0600CE5A RID: 52826 RVA: 0x00307440 File Offset: 0x00305640
		public Span<int> GetRoomPassedRequiredBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x0600CE5B RID: 52827 RVA: 0x00307450 File Offset: 0x00305650
		public int[] GetRoomPassedRequiredArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x1700347C RID: 13436
		// (get) Token: 0x0600CE5C RID: 52828 RVA: 0x00307468 File Offset: 0x00305668
		public string Name
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

		// Token: 0x0600CE5D RID: 52829 RVA: 0x003074A0 File Offset: 0x003056A0
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600CE5E RID: 52830 RVA: 0x003074B0 File Offset: 0x003056B0
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x1700347D RID: 13437
		// (get) Token: 0x0600CE5F RID: 52831 RVA: 0x003074C8 File Offset: 0x003056C8
		public string Desc
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

		// Token: 0x0600CE60 RID: 52832 RVA: 0x00307500 File Offset: 0x00305700
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600CE61 RID: 52833 RVA: 0x00307510 File Offset: 0x00305710
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x0600CE62 RID: 52834 RVA: 0x00307528 File Offset: 0x00305728
		public string DescParams(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700347E RID: 13438
		// (get) Token: 0x0600CE63 RID: 52835 RVA: 0x00307564 File Offset: 0x00305764
		public int DescParamsLength
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

		// Token: 0x0600CE64 RID: 52836 RVA: 0x00307590 File Offset: 0x00305790
		public string LevelDesc(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700347F RID: 13439
		// (get) Token: 0x0600CE65 RID: 52837 RVA: 0x003075CC File Offset: 0x003057CC
		public int LevelDescLength
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

		// Token: 0x0600CE66 RID: 52838 RVA: 0x003075F8 File Offset: 0x003057F8
		public IntArray? LevelDescParams(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return null;
			}
			return new IntArray?(default(IntArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003480 RID: 13440
		// (get) Token: 0x0600CE67 RID: 52839 RVA: 0x0030765C File Offset: 0x0030585C
		public int LevelDescParamsLength
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

		// Token: 0x17003481 RID: 13441
		// (get) Token: 0x0600CE68 RID: 52840 RVA: 0x00307688 File Offset: 0x00305888
		public string Icon
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

		// Token: 0x0600CE69 RID: 52841 RVA: 0x003076C0 File Offset: 0x003058C0
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600CE6A RID: 52842 RVA: 0x003076D0 File Offset: 0x003058D0
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x17003482 RID: 13442
		// (get) Token: 0x0600CE6B RID: 52843 RVA: 0x003076E8 File Offset: 0x003058E8
		public int RarityId
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003483 RID: 13443
		// (get) Token: 0x0600CE6C RID: 52844 RVA: 0x00307728 File Offset: 0x00305928
		public int ApplyRoleType
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

		// Token: 0x17003484 RID: 13444
		// (get) Token: 0x0600CE6D RID: 52845 RVA: 0x00307768 File Offset: 0x00305968
		public string ApplyRoleTypeLockDesc
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

		// Token: 0x0600CE6E RID: 52846 RVA: 0x003077A0 File Offset: 0x003059A0
		public Span<byte> GetApplyRoleTypeLockDescBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x0600CE6F RID: 52847 RVA: 0x003077B0 File Offset: 0x003059B0
		public byte[] GetApplyRoleTypeLockDescArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x0600CE70 RID: 52848 RVA: 0x003077C8 File Offset: 0x003059C8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用DescParamsIter()或GetDescParamsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] DescParams()
		{
			return this.DescParamsIter().ToArray<string>();
		}

		// Token: 0x0600CE71 RID: 52849 RVA: 0x003077D5 File Offset: 0x003059D5
		[NullableContext(1)]
		public readonly IEnumerable<string> DescParamsIter()
		{
			RoverRogueLoot.<DescParamsIter>d__53 <DescParamsIter>d__ = new RoverRogueLoot.<DescParamsIter>d__53(-2);
			<DescParamsIter>d__.<>3__<>4__this = this;
			return <DescParamsIter>d__;
		}

		// Token: 0x0600CE72 RID: 52850 RVA: 0x003077EA File Offset: 0x003059EA
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用LevelDescIter()或GetLevelDescBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] LevelDesc()
		{
			return this.LevelDescIter().ToArray<string>();
		}

		// Token: 0x0600CE73 RID: 52851 RVA: 0x003077F7 File Offset: 0x003059F7
		[NullableContext(1)]
		public readonly IEnumerable<string> LevelDescIter()
		{
			RoverRogueLoot.<LevelDescIter>d__55 <LevelDescIter>d__ = new RoverRogueLoot.<LevelDescIter>d__55(-2);
			<LevelDescIter>d__.<>3__<>4__this = this;
			return <LevelDescIter>d__;
		}

		// Token: 0x0600CE74 RID: 52852 RVA: 0x0030780C File Offset: 0x00305A0C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用LevelDescParamsIter()或GetLevelDescParamsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly IntArray[] LevelDescParams()
		{
			return this.LevelDescParamsIter().ToArray<IntArray>();
		}

		// Token: 0x0600CE75 RID: 52853 RVA: 0x00307819 File Offset: 0x00305A19
		[NullableContext(1)]
		public readonly IEnumerable<IntArray> LevelDescParamsIter()
		{
			RoverRogueLoot.<LevelDescParamsIter>d__57 <LevelDescParamsIter>d__ = new RoverRogueLoot.<LevelDescParamsIter>d__57(-2);
			<LevelDescParamsIter>d__.<>3__<>4__this = this;
			return <LevelDescParamsIter>d__;
		}

		// Token: 0x0600CE76 RID: 52854 RVA: 0x00307830 File Offset: 0x00305A30
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RoomPassedRequiredIter()或GetRoomPassedRequiredBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] RoomPassedRequired()
		{
			RoverRogueLoot roverRogueLoot = this;
			return roverRogueLoot.GetRoomPassedRequiredArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600CE77 RID: 52855 RVA: 0x00307854 File Offset: 0x00305A54
		[NullableContext(1)]
		public readonly IEnumerable<int> RoomPassedRequiredIter()
		{
			RoverRogueLoot.<RoomPassedRequiredIter>d__59 <RoomPassedRequiredIter>d__ = new RoverRogueLoot.<RoomPassedRequiredIter>d__59(-2);
			<RoomPassedRequiredIter>d__.<>3__<>4__this = this;
			return <RoomPassedRequiredIter>d__;
		}

		// Token: 0x04005189 RID: 20873
		private Table __p;
	}
}

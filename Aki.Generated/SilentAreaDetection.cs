using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011AD RID: 4525
	public struct SilentAreaDetection : IFlatbufferObject
	{
		// Token: 0x17003711 RID: 14097
		// (get) Token: 0x0600DA42 RID: 55874 RVA: 0x0032FAB4 File Offset: 0x0032DCB4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DA43 RID: 55875 RVA: 0x0032FAC1 File Offset: 0x0032DCC1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DA44 RID: 55876 RVA: 0x0032FAC8 File Offset: 0x0032DCC8
		public static SilentAreaDetection GetRootAsSilentAreaDetection(ByteBuffer _bb)
		{
			return SilentAreaDetection.GetRootAsSilentAreaDetection(_bb, default(SilentAreaDetection));
		}

		// Token: 0x0600DA45 RID: 55877 RVA: 0x0032FAE4 File Offset: 0x0032DCE4
		public static SilentAreaDetection GetRootAsSilentAreaDetection(ByteBuffer _bb, SilentAreaDetection obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DA46 RID: 55878 RVA: 0x0032FB01 File Offset: 0x0032DD01
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DA47 RID: 55879 RVA: 0x0032FB10 File Offset: 0x0032DD10
		public SilentAreaDetection __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003712 RID: 14098
		// (get) Token: 0x0600DA48 RID: 55880 RVA: 0x0032FB20 File Offset: 0x0032DD20
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

		// Token: 0x17003713 RID: 14099
		// (get) Token: 0x0600DA49 RID: 55881 RVA: 0x0032FB5C File Offset: 0x0032DD5C
		public string Name
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600DA4A RID: 55882 RVA: 0x0032FB93 File Offset: 0x0032DD93
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600DA4B RID: 55883 RVA: 0x0032FBA2 File Offset: 0x0032DDA2
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003714 RID: 14100
		// (get) Token: 0x0600DA4C RID: 55884 RVA: 0x0032FBBC File Offset: 0x0032DDBC
		public int GuideId
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

		// Token: 0x0600DA4D RID: 55885 RVA: 0x0032FBF8 File Offset: 0x0032DDF8
		public int LevelPlayList(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003715 RID: 14101
		// (get) Token: 0x0600DA4E RID: 55886 RVA: 0x0032FC38 File Offset: 0x0032DE38
		public int LevelPlayListLength
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

		// Token: 0x0600DA4F RID: 55887 RVA: 0x0032FC64 File Offset: 0x0032DE64
		public Span<int> GetLevelPlayListBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600DA50 RID: 55888 RVA: 0x0032FC74 File Offset: 0x0032DE74
		public int[] GetLevelPlayListArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x17003716 RID: 14102
		// (get) Token: 0x0600DA51 RID: 55889 RVA: 0x0032FC8C File Offset: 0x0032DE8C
		public string InstanceSubTypeDescription
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

		// Token: 0x0600DA52 RID: 55890 RVA: 0x0032FCC4 File Offset: 0x0032DEC4
		public Span<byte> GetInstanceSubTypeDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600DA53 RID: 55891 RVA: 0x0032FCD4 File Offset: 0x0032DED4
		public byte[] GetInstanceSubTypeDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17003717 RID: 14103
		// (get) Token: 0x0600DA54 RID: 55892 RVA: 0x0032FCEC File Offset: 0x0032DEEC
		public int DangerType
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003718 RID: 14104
		// (get) Token: 0x0600DA55 RID: 55893 RVA: 0x0032FD2C File Offset: 0x0032DF2C
		public int Secondary
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

		// Token: 0x17003719 RID: 14105
		// (get) Token: 0x0600DA56 RID: 55894 RVA: 0x0032FD6C File Offset: 0x0032DF6C
		public int TypeDescription2
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

		// Token: 0x1700371A RID: 14106
		// (get) Token: 0x0600DA57 RID: 55895 RVA: 0x0032FDAC File Offset: 0x0032DFAC
		public int MatType
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

		// Token: 0x1700371B RID: 14107
		// (get) Token: 0x0600DA58 RID: 55896 RVA: 0x0032FDEC File Offset: 0x0032DFEC
		public string AttributesDescriptionLock
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

		// Token: 0x0600DA59 RID: 55897 RVA: 0x0032FE24 File Offset: 0x0032E024
		public Span<byte> GetAttributesDescriptionLockBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600DA5A RID: 55898 RVA: 0x0032FE34 File Offset: 0x0032E034
		public byte[] GetAttributesDescriptionLockArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x1700371C RID: 14108
		// (get) Token: 0x0600DA5B RID: 55899 RVA: 0x0032FE4C File Offset: 0x0032E04C
		public string AttributesDescriptionUnlock
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

		// Token: 0x0600DA5C RID: 55900 RVA: 0x0032FE84 File Offset: 0x0032E084
		public Span<byte> GetAttributesDescriptionUnlockBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600DA5D RID: 55901 RVA: 0x0032FE94 File Offset: 0x0032E094
		public byte[] GetAttributesDescriptionUnlockArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x1700371D RID: 14109
		// (get) Token: 0x0600DA5E RID: 55902 RVA: 0x0032FEAC File Offset: 0x0032E0AC
		public string BigIcon
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

		// Token: 0x0600DA5F RID: 55903 RVA: 0x0032FEE4 File Offset: 0x0032E0E4
		public Span<byte> GetBigIconBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600DA60 RID: 55904 RVA: 0x0032FEF4 File Offset: 0x0032E0F4
		public byte[] GetBigIconArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x1700371E RID: 14110
		// (get) Token: 0x0600DA61 RID: 55905 RVA: 0x0032FF0C File Offset: 0x0032E10C
		public string Icon
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

		// Token: 0x0600DA62 RID: 55906 RVA: 0x0032FF44 File Offset: 0x0032E144
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x0600DA63 RID: 55907 RVA: 0x0032FF54 File Offset: 0x0032E154
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x1700371F RID: 14111
		// (get) Token: 0x0600DA64 RID: 55908 RVA: 0x0032FF6C File Offset: 0x0032E16C
		public string LockBigIcon
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

		// Token: 0x0600DA65 RID: 55909 RVA: 0x0032FFA4 File Offset: 0x0032E1A4
		public Span<byte> GetLockBigIconBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x0600DA66 RID: 55910 RVA: 0x0032FFB4 File Offset: 0x0032E1B4
		public byte[] GetLockBigIconArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x17003720 RID: 14112
		// (get) Token: 0x0600DA67 RID: 55911 RVA: 0x0032FFCC File Offset: 0x0032E1CC
		public string TemporaryIconUnLock
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

		// Token: 0x0600DA68 RID: 55912 RVA: 0x00330004 File Offset: 0x0032E204
		public Span<byte> GetTemporaryIconUnLockBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x0600DA69 RID: 55913 RVA: 0x00330014 File Offset: 0x0032E214
		public byte[] GetTemporaryIconUnLockArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x17003721 RID: 14113
		// (get) Token: 0x0600DA6A RID: 55914 RVA: 0x0033002C File Offset: 0x0032E22C
		public string TemporaryIconlock
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

		// Token: 0x0600DA6B RID: 55915 RVA: 0x00330064 File Offset: 0x0032E264
		public Span<byte> GetTemporaryIconlockBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x0600DA6C RID: 55916 RVA: 0x00330074 File Offset: 0x0032E274
		public byte[] GetTemporaryIconlockArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x17003722 RID: 14114
		// (get) Token: 0x0600DA6D RID: 55917 RVA: 0x0033008C File Offset: 0x0032E28C
		public int ShowReward
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

		// Token: 0x0600DA6E RID: 55918 RVA: 0x003300CC File Offset: 0x0032E2CC
		public DicIntInt? ShowRewardMap(int j)
		{
			int num = this.__p.__offset(38);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003723 RID: 14115
		// (get) Token: 0x0600DA6F RID: 55919 RVA: 0x00330130 File Offset: 0x0032E330
		public int ShowRewardMapLength
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

		// Token: 0x0600DA70 RID: 55920 RVA: 0x0033015C File Offset: 0x0032E35C
		public DicIntInt? ShowRewardMapCalabash(int j)
		{
			int num = this.__p.__offset(40);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003724 RID: 14116
		// (get) Token: 0x0600DA71 RID: 55921 RVA: 0x003301C0 File Offset: 0x0032E3C0
		public int ShowRewardMapCalabashLength
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

		// Token: 0x17003725 RID: 14117
		// (get) Token: 0x0600DA72 RID: 55922 RVA: 0x003301EC File Offset: 0x0032E3EC
		public int BeginTimeStamp
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

		// Token: 0x17003726 RID: 14118
		// (get) Token: 0x0600DA73 RID: 55923 RVA: 0x0033022C File Offset: 0x0032E42C
		public int PreOpenId
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

		// Token: 0x17003727 RID: 14119
		// (get) Token: 0x0600DA74 RID: 55924 RVA: 0x0033026C File Offset: 0x0032E46C
		public int MarkId
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

		// Token: 0x17003728 RID: 14120
		// (get) Token: 0x0600DA75 RID: 55925 RVA: 0x003302AC File Offset: 0x0032E4AC
		public int LockCon
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

		// Token: 0x17003729 RID: 14121
		// (get) Token: 0x0600DA76 RID: 55926 RVA: 0x003302EC File Offset: 0x0032E4EC
		public int MapId
		{
			get
			{
				int num = this.__p.__offset(50);
				if (num == 0)
				{
					return 8;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600DA77 RID: 55927 RVA: 0x0033032C File Offset: 0x0032E52C
		public int PhantomId(int j)
		{
			int num = this.__p.__offset(52);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700372A RID: 14122
		// (get) Token: 0x0600DA78 RID: 55928 RVA: 0x0033036C File Offset: 0x0032E56C
		public int PhantomIdLength
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

		// Token: 0x0600DA79 RID: 55929 RVA: 0x00330398 File Offset: 0x0032E598
		public Span<int> GetPhantomIdBytes()
		{
			return this.__p.__vector_as_span<int>(52, 4);
		}

		// Token: 0x0600DA7A RID: 55930 RVA: 0x003303A8 File Offset: 0x0032E5A8
		public int[] GetPhantomIdArray()
		{
			return this.__p.__vector_as_array<int>(52) ?? Array.Empty<int>();
		}

		// Token: 0x1700372B RID: 14123
		// (get) Token: 0x0600DA7B RID: 55931 RVA: 0x003303C0 File Offset: 0x0032E5C0
		public int FirstDropId
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

		// Token: 0x1700372C RID: 14124
		// (get) Token: 0x0600DA7C RID: 55932 RVA: 0x00330400 File Offset: 0x0032E600
		public int AdditionalId
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

		// Token: 0x1700372D RID: 14125
		// (get) Token: 0x0600DA7D RID: 55933 RVA: 0x00330440 File Offset: 0x0032E640
		public int SortId
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

		// Token: 0x1700372E RID: 14126
		// (get) Token: 0x0600DA7E RID: 55934 RVA: 0x00330480 File Offset: 0x0032E680
		public string NewContent
		{
			get
			{
				int num = this.__p.__offset(60);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600DA7F RID: 55935 RVA: 0x003304B8 File Offset: 0x0032E6B8
		public Span<byte> GetNewContentBytes()
		{
			return this.__p.__vector_as_span<byte>(60, 1);
		}

		// Token: 0x0600DA80 RID: 55936 RVA: 0x003304C8 File Offset: 0x0032E6C8
		public byte[] GetNewContentArray()
		{
			return this.__p.__vector_as_array<byte>(60) ?? Array.Empty<byte>();
		}

		// Token: 0x1700372F RID: 14127
		// (get) Token: 0x0600DA81 RID: 55937 RVA: 0x003304E0 File Offset: 0x0032E6E0
		public int DetectionTabType
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

		// Token: 0x0600DA82 RID: 55938 RVA: 0x00330520 File Offset: 0x0032E720
		public int PhantomFetterGroup(int j)
		{
			int num = this.__p.__offset(64);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003730 RID: 14128
		// (get) Token: 0x0600DA83 RID: 55939 RVA: 0x00330560 File Offset: 0x0032E760
		public int PhantomFetterGroupLength
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

		// Token: 0x0600DA84 RID: 55940 RVA: 0x0033058C File Offset: 0x0032E78C
		public Span<int> GetPhantomFetterGroupBytes()
		{
			return this.__p.__vector_as_span<int>(64, 4);
		}

		// Token: 0x0600DA85 RID: 55941 RVA: 0x0033059C File Offset: 0x0032E79C
		public int[] GetPhantomFetterGroupArray()
		{
			return this.__p.__vector_as_array<int>(64) ?? Array.Empty<int>();
		}

		// Token: 0x0600DA86 RID: 55942 RVA: 0x003305B4 File Offset: 0x0032E7B4
		public int WeaponFetterGroup(int j)
		{
			int num = this.__p.__offset(66);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003731 RID: 14129
		// (get) Token: 0x0600DA87 RID: 55943 RVA: 0x003305F4 File Offset: 0x0032E7F4
		public int WeaponFetterGroupLength
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

		// Token: 0x0600DA88 RID: 55944 RVA: 0x00330620 File Offset: 0x0032E820
		public Span<int> GetWeaponFetterGroupBytes()
		{
			return this.__p.__vector_as_span<int>(66, 4);
		}

		// Token: 0x0600DA89 RID: 55945 RVA: 0x00330630 File Offset: 0x0032E830
		public int[] GetWeaponFetterGroupArray()
		{
			return this.__p.__vector_as_array<int>(66) ?? Array.Empty<int>();
		}

		// Token: 0x17003732 RID: 14130
		// (get) Token: 0x0600DA8A RID: 55946 RVA: 0x00330648 File Offset: 0x0032E848
		public int PeriodicityChallengeType
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

		// Token: 0x17003733 RID: 14131
		// (get) Token: 0x0600DA8B RID: 55947 RVA: 0x00330688 File Offset: 0x0032E888
		public int DetectionTitlePanel
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

		// Token: 0x17003734 RID: 14132
		// (get) Token: 0x0600DA8C RID: 55948 RVA: 0x003306C8 File Offset: 0x0032E8C8
		public string LeftBgSprite
		{
			get
			{
				int num = this.__p.__offset(72);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600DA8D RID: 55949 RVA: 0x00330700 File Offset: 0x0032E900
		public Span<byte> GetLeftBgSpriteBytes()
		{
			return this.__p.__vector_as_span<byte>(72, 1);
		}

		// Token: 0x0600DA8E RID: 55950 RVA: 0x00330710 File Offset: 0x0032E910
		public byte[] GetLeftBgSpriteArray()
		{
			return this.__p.__vector_as_array<byte>(72) ?? Array.Empty<byte>();
		}

		// Token: 0x17003735 RID: 14133
		// (get) Token: 0x0600DA8F RID: 55951 RVA: 0x00330728 File Offset: 0x0032E928
		public string RightBgSprite
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

		// Token: 0x0600DA90 RID: 55952 RVA: 0x00330760 File Offset: 0x0032E960
		public Span<byte> GetRightBgSpriteBytes()
		{
			return this.__p.__vector_as_span<byte>(74, 1);
		}

		// Token: 0x0600DA91 RID: 55953 RVA: 0x00330770 File Offset: 0x0032E970
		public byte[] GetRightBgSpriteArray()
		{
			return this.__p.__vector_as_array<byte>(74) ?? Array.Empty<byte>();
		}

		// Token: 0x17003736 RID: 14134
		// (get) Token: 0x0600DA92 RID: 55954 RVA: 0x00330788 File Offset: 0x0032E988
		public string LeftBgTexture
		{
			get
			{
				int num = this.__p.__offset(76);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600DA93 RID: 55955 RVA: 0x003307C0 File Offset: 0x0032E9C0
		public Span<byte> GetLeftBgTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(76, 1);
		}

		// Token: 0x0600DA94 RID: 55956 RVA: 0x003307D0 File Offset: 0x0032E9D0
		public byte[] GetLeftBgTextureArray()
		{
			return this.__p.__vector_as_array<byte>(76) ?? Array.Empty<byte>();
		}

		// Token: 0x17003737 RID: 14135
		// (get) Token: 0x0600DA95 RID: 55957 RVA: 0x003307E8 File Offset: 0x0032E9E8
		public int DungeonId
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

		// Token: 0x17003738 RID: 14136
		// (get) Token: 0x0600DA96 RID: 55958 RVA: 0x00330828 File Offset: 0x0032EA28
		public int JumpType
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

		// Token: 0x17003739 RID: 14137
		// (get) Token: 0x0600DA97 RID: 55959 RVA: 0x00330868 File Offset: 0x0032EA68
		public int InstanceDungeonEntranceId
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

		// Token: 0x1700373A RID: 14138
		// (get) Token: 0x0600DA98 RID: 55960 RVA: 0x003308A8 File Offset: 0x0032EAA8
		public int JumpWithSubDungeonId
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

		// Token: 0x0600DA99 RID: 55961 RVA: 0x003308E5 File Offset: 0x0032EAE5
		[NullableContext(1)]
		public int[] LevelPlayList()
		{
			return this.GetLevelPlayListArray();
		}

		// Token: 0x0600DA9A RID: 55962 RVA: 0x003308ED File Offset: 0x0032EAED
		[NullableContext(1)]
		public IEnumerable<int> LevelPlayListIter()
		{
			SilentAreaDetection.<LevelPlayListIter>d__131 <LevelPlayListIter>d__ = new SilentAreaDetection.<LevelPlayListIter>d__131(-2);
			<LevelPlayListIter>d__.<>3__<>4__this = this;
			return <LevelPlayListIter>d__;
		}

		// Token: 0x0600DA9B RID: 55963 RVA: 0x00330902 File Offset: 0x0032EB02
		[NullableContext(1)]
		public int[] PhantomFetterGroup()
		{
			return this.GetPhantomFetterGroupArray();
		}

		// Token: 0x0600DA9C RID: 55964 RVA: 0x0033090A File Offset: 0x0032EB0A
		[NullableContext(1)]
		public IEnumerable<int> PhantomFetterGroupIter()
		{
			SilentAreaDetection.<PhantomFetterGroupIter>d__133 <PhantomFetterGroupIter>d__ = new SilentAreaDetection.<PhantomFetterGroupIter>d__133(-2);
			<PhantomFetterGroupIter>d__.<>3__<>4__this = this;
			return <PhantomFetterGroupIter>d__;
		}

		// Token: 0x0600DA9D RID: 55965 RVA: 0x0033091F File Offset: 0x0032EB1F
		[NullableContext(1)]
		public int[] PhantomId()
		{
			return this.GetPhantomIdArray();
		}

		// Token: 0x0600DA9E RID: 55966 RVA: 0x00330927 File Offset: 0x0032EB27
		[NullableContext(1)]
		public IEnumerable<int> PhantomIdIter()
		{
			SilentAreaDetection.<PhantomIdIter>d__135 <PhantomIdIter>d__ = new SilentAreaDetection.<PhantomIdIter>d__135(-2);
			<PhantomIdIter>d__.<>3__<>4__this = this;
			return <PhantomIdIter>d__;
		}

		// Token: 0x0600DA9F RID: 55967 RVA: 0x0033093C File Offset: 0x0032EB3C
		[NullableContext(1)]
		public Dictionary<int, int> ShowRewardMap()
		{
			return this.ShowRewardMapIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600DAA0 RID: 55968 RVA: 0x00330992 File Offset: 0x0032EB92
		[NullableContext(1)]
		public IEnumerable<DicIntInt> ShowRewardMapIter()
		{
			SilentAreaDetection.<ShowRewardMapIter>d__137 <ShowRewardMapIter>d__ = new SilentAreaDetection.<ShowRewardMapIter>d__137(-2);
			<ShowRewardMapIter>d__.<>3__<>4__this = this;
			return <ShowRewardMapIter>d__;
		}

		// Token: 0x0600DAA1 RID: 55969 RVA: 0x003309A8 File Offset: 0x0032EBA8
		[NullableContext(1)]
		public Dictionary<int, int> ShowRewardMapCalabash()
		{
			return this.ShowRewardMapCalabashIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600DAA2 RID: 55970 RVA: 0x003309FE File Offset: 0x0032EBFE
		[NullableContext(1)]
		public IEnumerable<DicIntInt> ShowRewardMapCalabashIter()
		{
			SilentAreaDetection.<ShowRewardMapCalabashIter>d__139 <ShowRewardMapCalabashIter>d__ = new SilentAreaDetection.<ShowRewardMapCalabashIter>d__139(-2);
			<ShowRewardMapCalabashIter>d__.<>3__<>4__this = this;
			return <ShowRewardMapCalabashIter>d__;
		}

		// Token: 0x0600DAA3 RID: 55971 RVA: 0x00330A13 File Offset: 0x0032EC13
		[NullableContext(1)]
		public int[] WeaponFetterGroup()
		{
			return this.GetWeaponFetterGroupArray();
		}

		// Token: 0x0600DAA4 RID: 55972 RVA: 0x00330A1B File Offset: 0x0032EC1B
		[NullableContext(1)]
		public IEnumerable<int> WeaponFetterGroupIter()
		{
			SilentAreaDetection.<WeaponFetterGroupIter>d__141 <WeaponFetterGroupIter>d__ = new SilentAreaDetection.<WeaponFetterGroupIter>d__141(-2);
			<WeaponFetterGroupIter>d__.<>3__<>4__this = this;
			return <WeaponFetterGroupIter>d__;
		}

		// Token: 0x0600DAA5 RID: 55973 RVA: 0x00330A30 File Offset: 0x0032EC30
		public int? GetShowRewardMap(int key)
		{
			this.EnsureShowRewardMapCacheIfNeeded();
			int value;
			if (!this.ShowRewardMapCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600DAA6 RID: 55974 RVA: 0x00330A64 File Offset: 0x0032EC64
		public int? GetShowRewardMapCalabash(int key)
		{
			this.EnsureShowRewardMapCalabashCacheIfNeeded();
			int value;
			if (!this.ShowRewardMapCalabashCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600DAA7 RID: 55975 RVA: 0x00330A98 File Offset: 0x0032EC98
		private void EnsureShowRewardMapCacheIfNeeded()
		{
			if (this.ShowRewardMapCache != null)
			{
				return;
			}
			this.ShowRewardMapCache = this.ShowRewardMapIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600DAA8 RID: 55976 RVA: 0x00330B00 File Offset: 0x0032ED00
		private void EnsureShowRewardMapCalabashCacheIfNeeded()
		{
			if (this.ShowRewardMapCalabashCache != null)
			{
				return;
			}
			this.ShowRewardMapCalabashCache = this.ShowRewardMapCalabashIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600DAA9 RID: 55977 RVA: 0x00330B66 File Offset: 0x0032ED66
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetShowRewardMapFrozenDict()
		{
			this.EnsureShowRewardMapCacheIfNeeded();
			return this.ShowRewardMapCache;
		}

		// Token: 0x0600DAAA RID: 55978 RVA: 0x00330B74 File Offset: 0x0032ED74
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetShowRewardMapCalabashFrozenDict()
		{
			this.EnsureShowRewardMapCalabashCacheIfNeeded();
			return this.ShowRewardMapCalabashCache;
		}

		// Token: 0x040057C4 RID: 22468
		private Table __p;

		// Token: 0x040057C5 RID: 22469
		[Nullable(2)]
		private FrozenDictionary<int, int> ShowRewardMapCache;

		// Token: 0x040057C6 RID: 22470
		[Nullable(2)]
		private FrozenDictionary<int, int> ShowRewardMapCalabashCache;
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011F2 RID: 4594
	public struct SolarSchoolLocation : IFlatbufferObject
	{
		// Token: 0x170039DD RID: 14813
		// (get) Token: 0x0600E22C RID: 57900 RVA: 0x00342939 File Offset: 0x00340B39
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E22D RID: 57901 RVA: 0x00342946 File Offset: 0x00340B46
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E22E RID: 57902 RVA: 0x00342950 File Offset: 0x00340B50
		public static SolarSchoolLocation GetRootAsSolarSchoolLocation(ByteBuffer _bb)
		{
			return SolarSchoolLocation.GetRootAsSolarSchoolLocation(_bb, default(SolarSchoolLocation));
		}

		// Token: 0x0600E22F RID: 57903 RVA: 0x0034296C File Offset: 0x00340B6C
		public static SolarSchoolLocation GetRootAsSolarSchoolLocation(ByteBuffer _bb, SolarSchoolLocation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E230 RID: 57904 RVA: 0x00342989 File Offset: 0x00340B89
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E231 RID: 57905 RVA: 0x00342998 File Offset: 0x00340B98
		public SolarSchoolLocation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170039DE RID: 14814
		// (get) Token: 0x0600E232 RID: 57906 RVA: 0x003429A8 File Offset: 0x00340BA8
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

		// Token: 0x170039DF RID: 14815
		// (get) Token: 0x0600E233 RID: 57907 RVA: 0x003429E4 File Offset: 0x00340BE4
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

		// Token: 0x170039E0 RID: 14816
		// (get) Token: 0x0600E234 RID: 57908 RVA: 0x00342A20 File Offset: 0x00340C20
		public int InstanceId
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

		// Token: 0x170039E1 RID: 14817
		// (get) Token: 0x0600E235 RID: 57909 RVA: 0x00342A5C File Offset: 0x00340C5C
		public int ConditionGroupId
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

		// Token: 0x170039E2 RID: 14818
		// (get) Token: 0x0600E236 RID: 57910 RVA: 0x00342A9C File Offset: 0x00340C9C
		public int ShowConditionGroupId
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

		// Token: 0x170039E3 RID: 14819
		// (get) Token: 0x0600E237 RID: 57911 RVA: 0x00342ADC File Offset: 0x00340CDC
		public string Name
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

		// Token: 0x0600E238 RID: 57912 RVA: 0x00342B14 File Offset: 0x00340D14
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600E239 RID: 57913 RVA: 0x00342B24 File Offset: 0x00340D24
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170039E4 RID: 14820
		// (get) Token: 0x0600E23A RID: 57914 RVA: 0x00342B3C File Offset: 0x00340D3C
		public string Icon
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

		// Token: 0x0600E23B RID: 57915 RVA: 0x00342B74 File Offset: 0x00340D74
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600E23C RID: 57916 RVA: 0x00342B84 File Offset: 0x00340D84
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170039E5 RID: 14821
		// (get) Token: 0x0600E23D RID: 57917 RVA: 0x00342B9C File Offset: 0x00340D9C
		public string LittleMapPath
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

		// Token: 0x0600E23E RID: 57918 RVA: 0x00342BD4 File Offset: 0x00340DD4
		public Span<byte> GetLittleMapPathBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600E23F RID: 57919 RVA: 0x00342BE4 File Offset: 0x00340DE4
		public byte[] GetLittleMapPathArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x170039E6 RID: 14822
		// (get) Token: 0x0600E240 RID: 57920 RVA: 0x00342BFC File Offset: 0x00340DFC
		public int BackgroundId
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

		// Token: 0x170039E7 RID: 14823
		// (get) Token: 0x0600E241 RID: 57921 RVA: 0x00342C3C File Offset: 0x00340E3C
		public int UiIndex
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

		// Token: 0x170039E8 RID: 14824
		// (get) Token: 0x0600E242 RID: 57922 RVA: 0x00342C7C File Offset: 0x00340E7C
		public bool IsHome
		{
			get
			{
				int num = this.__p.__offset(24);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170039E9 RID: 14825
		// (get) Token: 0x0600E243 RID: 57923 RVA: 0x00342CBC File Offset: 0x00340EBC
		public string Abient
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

		// Token: 0x0600E244 RID: 57924 RVA: 0x00342CF4 File Offset: 0x00340EF4
		public Span<byte> GetAbientBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600E245 RID: 57925 RVA: 0x00342D04 File Offset: 0x00340F04
		public byte[] GetAbientArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x0600E246 RID: 57926 RVA: 0x00342D1C File Offset: 0x00340F1C
		public int ActionIdList(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170039EA RID: 14826
		// (get) Token: 0x0600E247 RID: 57927 RVA: 0x00342D5C File Offset: 0x00340F5C
		public int ActionIdListLength
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

		// Token: 0x0600E248 RID: 57928 RVA: 0x00342D88 File Offset: 0x00340F88
		public Span<int> GetActionIdListBytes()
		{
			return this.__p.__vector_as_span<int>(28, 4);
		}

		// Token: 0x0600E249 RID: 57929 RVA: 0x00342D98 File Offset: 0x00340F98
		public int[] GetActionIdListArray()
		{
			return this.__p.__vector_as_array<int>(28) ?? Array.Empty<int>();
		}

		// Token: 0x170039EB RID: 14827
		// (get) Token: 0x0600E24A RID: 57930 RVA: 0x00342DB0 File Offset: 0x00340FB0
		public bool IsSeparate
		{
			get
			{
				int num = this.__p.__offset(30);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170039EC RID: 14828
		// (get) Token: 0x0600E24B RID: 57931 RVA: 0x00342DF0 File Offset: 0x00340FF0
		public bool ShowRoleAvatar
		{
			get
			{
				int num = this.__p.__offset(32);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0600E24C RID: 57932 RVA: 0x00342E30 File Offset: 0x00341030
		public int RoleIds(int j)
		{
			int num = this.__p.__offset(34);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170039ED RID: 14829
		// (get) Token: 0x0600E24D RID: 57933 RVA: 0x00342E70 File Offset: 0x00341070
		public int RoleIdsLength
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

		// Token: 0x0600E24E RID: 57934 RVA: 0x00342E9C File Offset: 0x0034109C
		public Span<int> GetRoleIdsBytes()
		{
			return this.__p.__vector_as_span<int>(34, 4);
		}

		// Token: 0x0600E24F RID: 57935 RVA: 0x00342EAC File Offset: 0x003410AC
		public int[] GetRoleIdsArray()
		{
			return this.__p.__vector_as_array<int>(34) ?? Array.Empty<int>();
		}

		// Token: 0x170039EE RID: 14830
		// (get) Token: 0x0600E250 RID: 57936 RVA: 0x00342EC4 File Offset: 0x003410C4
		public string FestivalName
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

		// Token: 0x0600E251 RID: 57937 RVA: 0x00342EFC File Offset: 0x003410FC
		public Span<byte> GetFestivalNameBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x0600E252 RID: 57938 RVA: 0x00342F0C File Offset: 0x0034110C
		public byte[] GetFestivalNameArray()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x170039EF RID: 14831
		// (get) Token: 0x0600E253 RID: 57939 RVA: 0x00342F24 File Offset: 0x00341124
		public bool FirstRedDot
		{
			get
			{
				int num = this.__p.__offset(38);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170039F0 RID: 14832
		// (get) Token: 0x0600E254 RID: 57940 RVA: 0x00342F64 File Offset: 0x00341164
		public bool IsEndLocation
		{
			get
			{
				int num = this.__p.__offset(40);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170039F1 RID: 14833
		// (get) Token: 0x0600E255 RID: 57941 RVA: 0x00342FA4 File Offset: 0x003411A4
		public string LockIcon
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

		// Token: 0x0600E256 RID: 57942 RVA: 0x00342FDC File Offset: 0x003411DC
		public Span<byte> GetLockIconBytes()
		{
			return this.__p.__vector_as_span<byte>(42, 1);
		}

		// Token: 0x0600E257 RID: 57943 RVA: 0x00342FEC File Offset: 0x003411EC
		public byte[] GetLockIconArray()
		{
			return this.__p.__vector_as_array<byte>(42) ?? Array.Empty<byte>();
		}

		// Token: 0x170039F2 RID: 14834
		// (get) Token: 0x0600E258 RID: 57944 RVA: 0x00343004 File Offset: 0x00341204
		public int LockParam
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

		// Token: 0x170039F3 RID: 14835
		// (get) Token: 0x0600E259 RID: 57945 RVA: 0x00343044 File Offset: 0x00341244
		public string MapIcon
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

		// Token: 0x0600E25A RID: 57946 RVA: 0x0034307C File Offset: 0x0034127C
		public Span<byte> GetMapIconBytes()
		{
			return this.__p.__vector_as_span<byte>(46, 1);
		}

		// Token: 0x0600E25B RID: 57947 RVA: 0x0034308C File Offset: 0x0034128C
		public byte[] GetMapIconArray()
		{
			return this.__p.__vector_as_array<byte>(46) ?? Array.Empty<byte>();
		}

		// Token: 0x170039F4 RID: 14836
		// (get) Token: 0x0600E25C RID: 57948 RVA: 0x003430A4 File Offset: 0x003412A4
		public int BitFlag
		{
			get
			{
				int num = this.__p.__offset(48);
				if (num == 0)
				{
					return -1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E25D RID: 57949 RVA: 0x003430E1 File Offset: 0x003412E1
		[NullableContext(1)]
		public int[] ActionIdList()
		{
			return this.GetActionIdListArray();
		}

		// Token: 0x0600E25E RID: 57950 RVA: 0x003430E9 File Offset: 0x003412E9
		[NullableContext(1)]
		public IEnumerable<int> ActionIdListIter()
		{
			SolarSchoolLocation.<ActionIdListIter>d__75 <ActionIdListIter>d__ = new SolarSchoolLocation.<ActionIdListIter>d__75(-2);
			<ActionIdListIter>d__.<>3__<>4__this = this;
			return <ActionIdListIter>d__;
		}

		// Token: 0x0600E25F RID: 57951 RVA: 0x003430FE File Offset: 0x003412FE
		[NullableContext(1)]
		public int[] RoleIds()
		{
			return this.GetRoleIdsArray();
		}

		// Token: 0x0600E260 RID: 57952 RVA: 0x00343106 File Offset: 0x00341306
		[NullableContext(1)]
		public IEnumerable<int> RoleIdsIter()
		{
			SolarSchoolLocation.<RoleIdsIter>d__77 <RoleIdsIter>d__ = new SolarSchoolLocation.<RoleIdsIter>d__77(-2);
			<RoleIdsIter>d__.<>3__<>4__this = this;
			return <RoleIdsIter>d__;
		}

		// Token: 0x04005830 RID: 22576
		private Table __p;
	}
}

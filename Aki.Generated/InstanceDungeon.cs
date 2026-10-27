using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D6F RID: 3439
	public struct InstanceDungeon : IFlatbufferObject
	{
		// Token: 0x17001953 RID: 6483
		// (get) Token: 0x06008464 RID: 33892 RVA: 0x00261422 File Offset: 0x0025F622
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008465 RID: 33893 RVA: 0x0026142F File Offset: 0x0025F62F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008466 RID: 33894 RVA: 0x00261438 File Offset: 0x0025F638
		public static InstanceDungeon GetRootAsInstanceDungeon(ByteBuffer _bb)
		{
			return InstanceDungeon.GetRootAsInstanceDungeon(_bb, default(InstanceDungeon));
		}

		// Token: 0x06008467 RID: 33895 RVA: 0x00261454 File Offset: 0x0025F654
		public static InstanceDungeon GetRootAsInstanceDungeon(ByteBuffer _bb, InstanceDungeon obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008468 RID: 33896 RVA: 0x00261471 File Offset: 0x0025F671
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008469 RID: 33897 RVA: 0x00261480 File Offset: 0x0025F680
		public InstanceDungeon __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001954 RID: 6484
		// (get) Token: 0x0600846A RID: 33898 RVA: 0x00261490 File Offset: 0x0025F690
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

		// Token: 0x17001955 RID: 6485
		// (get) Token: 0x0600846B RID: 33899 RVA: 0x002614CC File Offset: 0x0025F6CC
		public int MapConfigId
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

		// Token: 0x17001956 RID: 6486
		// (get) Token: 0x0600846C RID: 33900 RVA: 0x00261508 File Offset: 0x0025F708
		public string MapName
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600846D RID: 33901 RVA: 0x0026153F File Offset: 0x0025F73F
		public Span<byte> GetMapNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600846E RID: 33902 RVA: 0x0026154E File Offset: 0x0025F74E
		public byte[] GetMapNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001957 RID: 6487
		// (get) Token: 0x0600846F RID: 33903 RVA: 0x00261568 File Offset: 0x0025F768
		public int InstType
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

		// Token: 0x17001958 RID: 6488
		// (get) Token: 0x06008470 RID: 33904 RVA: 0x002615A8 File Offset: 0x0025F7A8
		public int InstSubType
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

		// Token: 0x17001959 RID: 6489
		// (get) Token: 0x06008471 RID: 33905 RVA: 0x002615E8 File Offset: 0x0025F7E8
		public int WorldDungeonSubType
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

		// Token: 0x1700195A RID: 6490
		// (get) Token: 0x06008472 RID: 33906 RVA: 0x00261628 File Offset: 0x0025F828
		public InstOnlineType OnlineType
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return InstOnlineType.Single;
				}
				return (InstOnlineType)this.__p.bb.GetSbyte(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700195B RID: 6491
		// (get) Token: 0x06008473 RID: 33907 RVA: 0x00261668 File Offset: 0x0025F868
		public bool EnableMulti
		{
			get
			{
				int num = this.__p.__offset(18);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06008474 RID: 33908 RVA: 0x002616A8 File Offset: 0x0025F8A8
		public int CustomTypes(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700195C RID: 6492
		// (get) Token: 0x06008475 RID: 33909 RVA: 0x002616E8 File Offset: 0x0025F8E8
		public int CustomTypesLength
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

		// Token: 0x06008476 RID: 33910 RVA: 0x00261714 File Offset: 0x0025F914
		public Span<int> GetCustomTypesBytes()
		{
			return this.__p.__vector_as_span<int>(20, 4);
		}

		// Token: 0x06008477 RID: 33911 RVA: 0x00261724 File Offset: 0x0025F924
		public int[] GetCustomTypesArray()
		{
			return this.__p.__vector_as_array<int>(20) ?? Array.Empty<int>();
		}

		// Token: 0x06008478 RID: 33912 RVA: 0x0026173C File Offset: 0x0025F93C
		public int EntityLevelIds(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700195D RID: 6493
		// (get) Token: 0x06008479 RID: 33913 RVA: 0x0026177C File Offset: 0x0025F97C
		public int EntityLevelIdsLength
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

		// Token: 0x0600847A RID: 33914 RVA: 0x002617A8 File Offset: 0x0025F9A8
		public Span<int> GetEntityLevelIdsBytes()
		{
			return this.__p.__vector_as_span<int>(22, 4);
		}

		// Token: 0x0600847B RID: 33915 RVA: 0x002617B8 File Offset: 0x0025F9B8
		public int[] GetEntityLevelIdsArray()
		{
			return this.__p.__vector_as_array<int>(22) ?? Array.Empty<int>();
		}

		// Token: 0x1700195E RID: 6494
		// (get) Token: 0x0600847C RID: 33916 RVA: 0x002617D0 File Offset: 0x0025F9D0
		public int MiniMapId
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600847D RID: 33917 RVA: 0x00261810 File Offset: 0x0025FA10
		public string SubLevels(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700195F RID: 6495
		// (get) Token: 0x0600847E RID: 33918 RVA: 0x0026184C File Offset: 0x0025FA4C
		public int SubLevelsLength
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

		// Token: 0x17001960 RID: 6496
		// (get) Token: 0x0600847F RID: 33919 RVA: 0x00261878 File Offset: 0x0025FA78
		public int FightFormationId
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 2;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008480 RID: 33920 RVA: 0x002618B8 File Offset: 0x0025FAB8
		public int RoleTypeList(int j)
		{
			int num = this.__p.__offset(30);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001961 RID: 6497
		// (get) Token: 0x06008481 RID: 33921 RVA: 0x002618F8 File Offset: 0x0025FAF8
		public int RoleTypeListLength
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

		// Token: 0x06008482 RID: 33922 RVA: 0x00261924 File Offset: 0x0025FB24
		public Span<int> GetRoleTypeListBytes()
		{
			return this.__p.__vector_as_span<int>(30, 4);
		}

		// Token: 0x06008483 RID: 33923 RVA: 0x00261934 File Offset: 0x0025FB34
		public int[] GetRoleTypeListArray()
		{
			return this.__p.__vector_as_array<int>(30) ?? Array.Empty<int>();
		}

		// Token: 0x06008484 RID: 33924 RVA: 0x0026194C File Offset: 0x0025FB4C
		public int TrialRoleInfo(int j)
		{
			int num = this.__p.__offset(32);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001962 RID: 6498
		// (get) Token: 0x06008485 RID: 33925 RVA: 0x0026198C File Offset: 0x0025FB8C
		public int TrialRoleInfoLength
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

		// Token: 0x06008486 RID: 33926 RVA: 0x002619B8 File Offset: 0x0025FBB8
		public Span<int> GetTrialRoleInfoBytes()
		{
			return this.__p.__vector_as_span<int>(32, 4);
		}

		// Token: 0x06008487 RID: 33927 RVA: 0x002619C8 File Offset: 0x0025FBC8
		public int[] GetTrialRoleInfoArray()
		{
			return this.__p.__vector_as_array<int>(32) ?? Array.Empty<int>();
		}

		// Token: 0x17001963 RID: 6499
		// (get) Token: 0x06008488 RID: 33928 RVA: 0x002619E0 File Offset: 0x0025FBE0
		public int TrialRoleFormation
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

		// Token: 0x17001964 RID: 6500
		// (get) Token: 0x06008489 RID: 33929 RVA: 0x00261A20 File Offset: 0x0025FC20
		public int ReviveId
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

		// Token: 0x0600848A RID: 33930 RVA: 0x00261A60 File Offset: 0x0025FC60
		public int BornPosition(int j)
		{
			int num = this.__p.__offset(38);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001965 RID: 6501
		// (get) Token: 0x0600848B RID: 33931 RVA: 0x00261AA0 File Offset: 0x0025FCA0
		public int BornPositionLength
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

		// Token: 0x0600848C RID: 33932 RVA: 0x00261ACC File Offset: 0x0025FCCC
		public Span<int> GetBornPositionBytes()
		{
			return this.__p.__vector_as_span<int>(38, 4);
		}

		// Token: 0x0600848D RID: 33933 RVA: 0x00261ADC File Offset: 0x0025FCDC
		public int[] GetBornPositionArray()
		{
			return this.__p.__vector_as_array<int>(38) ?? Array.Empty<int>();
		}

		// Token: 0x0600848E RID: 33934 RVA: 0x00261AF4 File Offset: 0x0025FCF4
		public int BornRotation(int j)
		{
			int num = this.__p.__offset(40);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001966 RID: 6502
		// (get) Token: 0x0600848F RID: 33935 RVA: 0x00261B34 File Offset: 0x0025FD34
		public int BornRotationLength
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

		// Token: 0x06008490 RID: 33936 RVA: 0x00261B60 File Offset: 0x0025FD60
		public Span<int> GetBornRotationBytes()
		{
			return this.__p.__vector_as_span<int>(40, 4);
		}

		// Token: 0x06008491 RID: 33937 RVA: 0x00261B70 File Offset: 0x0025FD70
		public int[] GetBornRotationArray()
		{
			return this.__p.__vector_as_array<int>(40) ?? Array.Empty<int>();
		}

		// Token: 0x06008492 RID: 33938 RVA: 0x00261B88 File Offset: 0x0025FD88
		public int RecoverWorldLocation(int j)
		{
			int num = this.__p.__offset(42);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001967 RID: 6503
		// (get) Token: 0x06008493 RID: 33939 RVA: 0x00261BC8 File Offset: 0x0025FDC8
		public int RecoverWorldLocationLength
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

		// Token: 0x06008494 RID: 33940 RVA: 0x00261BF4 File Offset: 0x0025FDF4
		public Span<int> GetRecoverWorldLocationBytes()
		{
			return this.__p.__vector_as_span<int>(42, 4);
		}

		// Token: 0x06008495 RID: 33941 RVA: 0x00261C04 File Offset: 0x0025FE04
		public int[] GetRecoverWorldLocationArray()
		{
			return this.__p.__vector_as_array<int>(42) ?? Array.Empty<int>();
		}

		// Token: 0x06008496 RID: 33942 RVA: 0x00261C1C File Offset: 0x0025FE1C
		public int ExitDungeonConfirmId(int j)
		{
			int num = this.__p.__offset(44);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001968 RID: 6504
		// (get) Token: 0x06008497 RID: 33943 RVA: 0x00261C5C File Offset: 0x0025FE5C
		public int ExitDungeonConfirmIdLength
		{
			get
			{
				int num = this.__p.__offset(44);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06008498 RID: 33944 RVA: 0x00261C88 File Offset: 0x0025FE88
		public Span<int> GetExitDungeonConfirmIdBytes()
		{
			return this.__p.__vector_as_span<int>(44, 4);
		}

		// Token: 0x06008499 RID: 33945 RVA: 0x00261C98 File Offset: 0x0025FE98
		public int[] GetExitDungeonConfirmIdArray()
		{
			return this.__p.__vector_as_array<int>(44) ?? Array.Empty<int>();
		}

		// Token: 0x0600849A RID: 33946 RVA: 0x00261CB0 File Offset: 0x0025FEB0
		public DungeonEntrance? EntranceEntities(int j)
		{
			int num = this.__p.__offset(46);
			if (num == 0)
			{
				return null;
			}
			return new DungeonEntrance?(default(DungeonEntrance).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001969 RID: 6505
		// (get) Token: 0x0600849B RID: 33947 RVA: 0x00261D14 File Offset: 0x0025FF14
		public int EntranceEntitiesLength
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

		// Token: 0x0600849C RID: 33948 RVA: 0x00261D40 File Offset: 0x0025FF40
		public int ExitEntities(int j)
		{
			int num = this.__p.__offset(48);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700196A RID: 6506
		// (get) Token: 0x0600849D RID: 33949 RVA: 0x00261D80 File Offset: 0x0025FF80
		public int ExitEntitiesLength
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

		// Token: 0x0600849E RID: 33950 RVA: 0x00261DAC File Offset: 0x0025FFAC
		public Span<int> GetExitEntitiesBytes()
		{
			return this.__p.__vector_as_span<int>(48, 4);
		}

		// Token: 0x0600849F RID: 33951 RVA: 0x00261DBC File Offset: 0x0025FFBC
		public int[] GetExitEntitiesArray()
		{
			return this.__p.__vector_as_array<int>(48) ?? Array.Empty<int>();
		}

		// Token: 0x1700196B RID: 6507
		// (get) Token: 0x060084A0 RID: 33952 RVA: 0x00261DD4 File Offset: 0x0025FFD4
		public string DungeonDesc
		{
			get
			{
				int num = this.__p.__offset(50);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060084A1 RID: 33953 RVA: 0x00261E0C File Offset: 0x0026000C
		public Span<byte> GetDungeonDescBytes()
		{
			return this.__p.__vector_as_span<byte>(50, 1);
		}

		// Token: 0x060084A2 RID: 33954 RVA: 0x00261E1C File Offset: 0x0026001C
		public byte[] GetDungeonDescArray()
		{
			return this.__p.__vector_as_array<byte>(50) ?? Array.Empty<byte>();
		}

		// Token: 0x1700196C RID: 6508
		// (get) Token: 0x060084A3 RID: 33955 RVA: 0x00261E34 File Offset: 0x00260034
		public int Title
		{
			get
			{
				int num = this.__p.__offset(52);
				if (num == 0)
				{
					return 999;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700196D RID: 6509
		// (get) Token: 0x060084A4 RID: 33956 RVA: 0x00261E78 File Offset: 0x00260078
		public string BannerPath
		{
			get
			{
				int num = this.__p.__offset(54);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060084A5 RID: 33957 RVA: 0x00261EB0 File Offset: 0x002600B0
		public Span<byte> GetBannerPathBytes()
		{
			return this.__p.__vector_as_span<byte>(54, 1);
		}

		// Token: 0x060084A6 RID: 33958 RVA: 0x00261EC0 File Offset: 0x002600C0
		public byte[] GetBannerPathArray()
		{
			return this.__p.__vector_as_array<byte>(54) ?? Array.Empty<byte>();
		}

		// Token: 0x060084A7 RID: 33959 RVA: 0x00261ED8 File Offset: 0x002600D8
		public int MonsterPreview(int j)
		{
			int num = this.__p.__offset(56);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700196E RID: 6510
		// (get) Token: 0x060084A8 RID: 33960 RVA: 0x00261F18 File Offset: 0x00260118
		public int MonsterPreviewLength
		{
			get
			{
				int num = this.__p.__offset(56);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060084A9 RID: 33961 RVA: 0x00261F44 File Offset: 0x00260144
		public Span<int> GetMonsterPreviewBytes()
		{
			return this.__p.__vector_as_span<int>(56, 4);
		}

		// Token: 0x060084AA RID: 33962 RVA: 0x00261F54 File Offset: 0x00260154
		public int[] GetMonsterPreviewArray()
		{
			return this.__p.__vector_as_array<int>(56) ?? Array.Empty<int>();
		}

		// Token: 0x1700196F RID: 6511
		// (get) Token: 0x060084AB RID: 33963 RVA: 0x00261F6C File Offset: 0x0026016C
		public string MonsterTips
		{
			get
			{
				int num = this.__p.__offset(58);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060084AC RID: 33964 RVA: 0x00261FA4 File Offset: 0x002601A4
		public Span<byte> GetMonsterTipsBytes()
		{
			return this.__p.__vector_as_span<byte>(58, 1);
		}

		// Token: 0x060084AD RID: 33965 RVA: 0x00261FB4 File Offset: 0x002601B4
		public byte[] GetMonsterTipsArray()
		{
			return this.__p.__vector_as_array<byte>(58) ?? Array.Empty<byte>();
		}

		// Token: 0x17001970 RID: 6512
		// (get) Token: 0x060084AE RID: 33966 RVA: 0x00261FCC File Offset: 0x002601CC
		public int FirstRewardId
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

		// Token: 0x17001971 RID: 6513
		// (get) Token: 0x060084AF RID: 33967 RVA: 0x0026200C File Offset: 0x0026020C
		public int RewardId
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

		// Token: 0x17001972 RID: 6514
		// (get) Token: 0x060084B0 RID: 33968 RVA: 0x0026204C File Offset: 0x0026024C
		public int RepeatRewardId
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

		// Token: 0x17001973 RID: 6515
		// (get) Token: 0x060084B1 RID: 33969 RVA: 0x0026208C File Offset: 0x0026028C
		public int ExchangeRewardId
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

		// Token: 0x17001974 RID: 6516
		// (get) Token: 0x060084B2 RID: 33970 RVA: 0x002620CC File Offset: 0x002602CC
		public int DropVisionLimit
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

		// Token: 0x060084B3 RID: 33971 RVA: 0x0026210C File Offset: 0x0026030C
		public int SharedTreasureGroup(int j)
		{
			int num = this.__p.__offset(70);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001975 RID: 6517
		// (get) Token: 0x060084B4 RID: 33972 RVA: 0x0026214C File Offset: 0x0026034C
		public int SharedTreasureGroupLength
		{
			get
			{
				int num = this.__p.__offset(70);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060084B5 RID: 33973 RVA: 0x00262178 File Offset: 0x00260378
		public Span<int> GetSharedTreasureGroupBytes()
		{
			return this.__p.__vector_as_span<int>(70, 4);
		}

		// Token: 0x060084B6 RID: 33974 RVA: 0x00262188 File Offset: 0x00260388
		public int[] GetSharedTreasureGroupArray()
		{
			return this.__p.__vector_as_array<int>(70) ?? Array.Empty<int>();
		}

		// Token: 0x17001976 RID: 6518
		// (get) Token: 0x060084B7 RID: 33975 RVA: 0x002621A0 File Offset: 0x002603A0
		public int EnterControlId
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

		// Token: 0x060084B8 RID: 33976 RVA: 0x002621E0 File Offset: 0x002603E0
		public int EnterCondition(int j)
		{
			int num = this.__p.__offset(74);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001977 RID: 6519
		// (get) Token: 0x060084B9 RID: 33977 RVA: 0x00262220 File Offset: 0x00260420
		public int EnterConditionLength
		{
			get
			{
				int num = this.__p.__offset(74);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060084BA RID: 33978 RVA: 0x0026224C File Offset: 0x0026044C
		public Span<int> GetEnterConditionBytes()
		{
			return this.__p.__vector_as_span<int>(74, 4);
		}

		// Token: 0x060084BB RID: 33979 RVA: 0x0026225C File Offset: 0x0026045C
		public int[] GetEnterConditionArray()
		{
			return this.__p.__vector_as_array<int>(74) ?? Array.Empty<int>();
		}

		// Token: 0x17001978 RID: 6520
		// (get) Token: 0x060084BC RID: 33980 RVA: 0x00262274 File Offset: 0x00260474
		public string EnterConditionText
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

		// Token: 0x060084BD RID: 33981 RVA: 0x002622AC File Offset: 0x002604AC
		public Span<byte> GetEnterConditionTextBytes()
		{
			return this.__p.__vector_as_span<byte>(76, 1);
		}

		// Token: 0x060084BE RID: 33982 RVA: 0x002622BC File Offset: 0x002604BC
		public byte[] GetEnterConditionTextArray()
		{
			return this.__p.__vector_as_array<byte>(76) ?? Array.Empty<byte>();
		}

		// Token: 0x17001979 RID: 6521
		// (get) Token: 0x060084BF RID: 33983 RVA: 0x002622D4 File Offset: 0x002604D4
		public string DifficultyIcon
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

		// Token: 0x060084C0 RID: 33984 RVA: 0x0026230C File Offset: 0x0026050C
		public Span<byte> GetDifficultyIconBytes()
		{
			return this.__p.__vector_as_span<byte>(78, 1);
		}

		// Token: 0x060084C1 RID: 33985 RVA: 0x0026231C File Offset: 0x0026051C
		public byte[] GetDifficultyIconArray()
		{
			return this.__p.__vector_as_array<byte>(78) ?? Array.Empty<byte>();
		}

		// Token: 0x1700197A RID: 6522
		// (get) Token: 0x060084C2 RID: 33986 RVA: 0x00262334 File Offset: 0x00260534
		public int EntityLevel
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

		// Token: 0x060084C3 RID: 33987 RVA: 0x00262374 File Offset: 0x00260574
		public DicIntInt? RecommendLevel(int j)
		{
			int num = this.__p.__offset(82);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700197B RID: 6523
		// (get) Token: 0x060084C4 RID: 33988 RVA: 0x002623D8 File Offset: 0x002605D8
		public int RecommendLevelLength
		{
			get
			{
				int num = this.__p.__offset(82);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060084C5 RID: 33989 RVA: 0x00262404 File Offset: 0x00260604
		public int RecommendRole(int j)
		{
			int num = this.__p.__offset(84);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700197C RID: 6524
		// (get) Token: 0x060084C6 RID: 33990 RVA: 0x00262444 File Offset: 0x00260644
		public int RecommendRoleLength
		{
			get
			{
				int num = this.__p.__offset(84);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060084C7 RID: 33991 RVA: 0x00262470 File Offset: 0x00260670
		public Span<int> GetRecommendRoleBytes()
		{
			return this.__p.__vector_as_span<int>(84, 4);
		}

		// Token: 0x060084C8 RID: 33992 RVA: 0x00262480 File Offset: 0x00260680
		public int[] GetRecommendRoleArray()
		{
			return this.__p.__vector_as_array<int>(84) ?? Array.Empty<int>();
		}

		// Token: 0x060084C9 RID: 33993 RVA: 0x00262498 File Offset: 0x00260698
		public int RecommendRoleBottom(int j)
		{
			int num = this.__p.__offset(86);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700197D RID: 6525
		// (get) Token: 0x060084CA RID: 33994 RVA: 0x002624D8 File Offset: 0x002606D8
		public int RecommendRoleBottomLength
		{
			get
			{
				int num = this.__p.__offset(86);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060084CB RID: 33995 RVA: 0x00262504 File Offset: 0x00260704
		public Span<int> GetRecommendRoleBottomBytes()
		{
			return this.__p.__vector_as_span<int>(86, 4);
		}

		// Token: 0x060084CC RID: 33996 RVA: 0x00262514 File Offset: 0x00260714
		public int[] GetRecommendRoleBottomArray()
		{
			return this.__p.__vector_as_array<int>(86) ?? Array.Empty<int>();
		}

		// Token: 0x060084CD RID: 33997 RVA: 0x0026252C File Offset: 0x0026072C
		public int RecommendElement(int j)
		{
			int num = this.__p.__offset(88);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700197E RID: 6526
		// (get) Token: 0x060084CE RID: 33998 RVA: 0x0026256C File Offset: 0x0026076C
		public int RecommendElementLength
		{
			get
			{
				int num = this.__p.__offset(88);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060084CF RID: 33999 RVA: 0x00262598 File Offset: 0x00260798
		public Span<int> GetRecommendElementBytes()
		{
			return this.__p.__vector_as_span<int>(88, 4);
		}

		// Token: 0x060084D0 RID: 34000 RVA: 0x002625A8 File Offset: 0x002607A8
		public int[] GetRecommendElementArray()
		{
			return this.__p.__vector_as_array<int>(88) ?? Array.Empty<int>();
		}

		// Token: 0x1700197F RID: 6527
		// (get) Token: 0x060084D1 RID: 34001 RVA: 0x002625C0 File Offset: 0x002607C0
		public int ShareAttri
		{
			get
			{
				int num = this.__p.__offset(90);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060084D2 RID: 34002 RVA: 0x00262600 File Offset: 0x00260800
		public int FightInfoDtType(int j)
		{
			int num = this.__p.__offset(92);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001980 RID: 6528
		// (get) Token: 0x060084D3 RID: 34003 RVA: 0x00262640 File Offset: 0x00260840
		public int FightInfoDtTypeLength
		{
			get
			{
				int num = this.__p.__offset(92);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060084D4 RID: 34004 RVA: 0x0026266C File Offset: 0x0026086C
		public Span<int> GetFightInfoDtTypeBytes()
		{
			return this.__p.__vector_as_span<int>(92, 4);
		}

		// Token: 0x060084D5 RID: 34005 RVA: 0x0026267C File Offset: 0x0026087C
		public int[] GetFightInfoDtTypeArray()
		{
			return this.__p.__vector_as_array<int>(92) ?? Array.Empty<int>();
		}

		// Token: 0x17001981 RID: 6529
		// (get) Token: 0x060084D6 RID: 34006 RVA: 0x00262694 File Offset: 0x00260894
		public int SaveDays
		{
			get
			{
				int num = this.__p.__offset(94);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060084D7 RID: 34007 RVA: 0x002626D4 File Offset: 0x002608D4
		public string LimitViewName(int j)
		{
			int num = this.__p.__offset(96);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001982 RID: 6530
		// (get) Token: 0x060084D8 RID: 34008 RVA: 0x00262710 File Offset: 0x00260910
		public int LimitViewNameLength
		{
			get
			{
				int num = this.__p.__offset(96);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060084D9 RID: 34009 RVA: 0x0026273C File Offset: 0x0026093C
		public int FuncLimit(int j)
		{
			int num = this.__p.__offset(98);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001983 RID: 6531
		// (get) Token: 0x060084DA RID: 34010 RVA: 0x0026277C File Offset: 0x0026097C
		public int FuncLimitLength
		{
			get
			{
				int num = this.__p.__offset(98);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060084DB RID: 34011 RVA: 0x002627A8 File Offset: 0x002609A8
		public Span<int> GetFuncLimitBytes()
		{
			return this.__p.__vector_as_span<int>(98, 4);
		}

		// Token: 0x060084DC RID: 34012 RVA: 0x002627B8 File Offset: 0x002609B8
		public int[] GetFuncLimitArray()
		{
			return this.__p.__vector_as_array<int>(98) ?? Array.Empty<int>();
		}

		// Token: 0x17001984 RID: 6532
		// (get) Token: 0x060084DD RID: 34013 RVA: 0x002627D0 File Offset: 0x002609D0
		public int CanUseItem
		{
			get
			{
				int num = this.__p.__offset(100);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001985 RID: 6533
		// (get) Token: 0x060084DE RID: 34014 RVA: 0x00262810 File Offset: 0x00260A10
		public int GameplayMode
		{
			get
			{
				int num = this.__p.__offset(102);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001986 RID: 6534
		// (get) Token: 0x060084DF RID: 34015 RVA: 0x00262850 File Offset: 0x00260A50
		public int GuideType
		{
			get
			{
				int num = this.__p.__offset(104);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001987 RID: 6535
		// (get) Token: 0x060084E0 RID: 34016 RVA: 0x00262890 File Offset: 0x00260A90
		public int GuideValue
		{
			get
			{
				int num = this.__p.__offset(106);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001988 RID: 6536
		// (get) Token: 0x060084E1 RID: 34017 RVA: 0x002628D0 File Offset: 0x00260AD0
		public int SettleButtonType
		{
			get
			{
				int num = this.__p.__offset(108);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060084E2 RID: 34018 RVA: 0x00262910 File Offset: 0x00260B10
		public DicIntString? SubTitle(int j)
		{
			int num = this.__p.__offset(110);
			if (num == 0)
			{
				return null;
			}
			return new DicIntString?(default(DicIntString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001989 RID: 6537
		// (get) Token: 0x060084E3 RID: 34019 RVA: 0x00262974 File Offset: 0x00260B74
		public int SubTitleLength
		{
			get
			{
				int num = this.__p.__offset(110);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700198A RID: 6538
		// (get) Token: 0x060084E4 RID: 34020 RVA: 0x002629A0 File Offset: 0x00260BA0
		public int ViewMapId
		{
			get
			{
				int num = this.__p.__offset(112);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060084E5 RID: 34021 RVA: 0x002629E0 File Offset: 0x00260BE0
		public DicIntInt? RenderSettings(int j)
		{
			int num = this.__p.__offset(114);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700198B RID: 6539
		// (get) Token: 0x060084E6 RID: 34022 RVA: 0x00262A44 File Offset: 0x00260C44
		public int RenderSettingsLength
		{
			get
			{
				int num = this.__p.__offset(114);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700198C RID: 6540
		// (get) Token: 0x060084E7 RID: 34023 RVA: 0x00262A70 File Offset: 0x00260C70
		public bool IsFogFullUnlock
		{
			get
			{
				int num = this.__p.__offset(116);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700198D RID: 6541
		// (get) Token: 0x060084E8 RID: 34024 RVA: 0x00262AB0 File Offset: 0x00260CB0
		public int MapMarkFilterRule
		{
			get
			{
				int num = this.__p.__offset(118);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700198E RID: 6542
		// (get) Token: 0x060084E9 RID: 34025 RVA: 0x00262AF0 File Offset: 0x00260CF0
		public int MapShowMode
		{
			get
			{
				int num = this.__p.__offset(120);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700198F RID: 6543
		// (get) Token: 0x060084EA RID: 34026 RVA: 0x00262B30 File Offset: 0x00260D30
		public int DungeonMapTrackSwitch
		{
			get
			{
				int num = this.__p.__offset(122);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001990 RID: 6544
		// (get) Token: 0x060084EB RID: 34027 RVA: 0x00262B70 File Offset: 0x00260D70
		public int RelatedQuestId
		{
			get
			{
				int num = this.__p.__offset(124);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001991 RID: 6545
		// (get) Token: 0x060084EC RID: 34028 RVA: 0x00262BB0 File Offset: 0x00260DB0
		public int SubPackageId
		{
			get
			{
				int num = this.__p.__offset(126);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060084ED RID: 34029 RVA: 0x00262BF0 File Offset: 0x00260DF0
		public int SubPackageIdList(int j)
		{
			int num = this.__p.__offset(128);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001992 RID: 6546
		// (get) Token: 0x060084EE RID: 34030 RVA: 0x00262C34 File Offset: 0x00260E34
		public int SubPackageIdListLength
		{
			get
			{
				int num = this.__p.__offset(128);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060084EF RID: 34031 RVA: 0x00262C63 File Offset: 0x00260E63
		public Span<int> GetSubPackageIdListBytes()
		{
			return this.__p.__vector_as_span<int>(128, 4);
		}

		// Token: 0x060084F0 RID: 34032 RVA: 0x00262C76 File Offset: 0x00260E76
		public int[] GetSubPackageIdListArray()
		{
			return this.__p.__vector_as_array<int>(128) ?? Array.Empty<int>();
		}

		// Token: 0x17001993 RID: 6547
		// (get) Token: 0x060084F1 RID: 34033 RVA: 0x00262C94 File Offset: 0x00260E94
		public bool IsExitOnlineTeam
		{
			get
			{
				int num = this.__p.__offset(130);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001994 RID: 6548
		// (get) Token: 0x060084F2 RID: 34034 RVA: 0x00262CD8 File Offset: 0x00260ED8
		public int EnterBuff
		{
			get
			{
				int num = this.__p.__offset(132);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060084F3 RID: 34035 RVA: 0x00262D18 File Offset: 0x00260F18
		public int TreasureChestStatTypes(int j)
		{
			int num = this.__p.__offset(134);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001995 RID: 6549
		// (get) Token: 0x060084F4 RID: 34036 RVA: 0x00262D5C File Offset: 0x00260F5C
		public int TreasureChestStatTypesLength
		{
			get
			{
				int num = this.__p.__offset(134);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060084F5 RID: 34037 RVA: 0x00262D8B File Offset: 0x00260F8B
		public Span<int> GetTreasureChestStatTypesBytes()
		{
			return this.__p.__vector_as_span<int>(134, 4);
		}

		// Token: 0x060084F6 RID: 34038 RVA: 0x00262D9E File Offset: 0x00260F9E
		public int[] GetTreasureChestStatTypesArray()
		{
			return this.__p.__vector_as_array<int>(134) ?? Array.Empty<int>();
		}

		// Token: 0x17001996 RID: 6550
		// (get) Token: 0x060084F7 RID: 34039 RVA: 0x00262DBC File Offset: 0x00260FBC
		public string SubInstanceTitle
		{
			get
			{
				int num = this.__p.__offset(136);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060084F8 RID: 34040 RVA: 0x00262DF7 File Offset: 0x00260FF7
		public Span<byte> GetSubInstanceTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(136, 1);
		}

		// Token: 0x060084F9 RID: 34041 RVA: 0x00262E0A File Offset: 0x0026100A
		public byte[] GetSubInstanceTitleArray()
		{
			return this.__p.__vector_as_array<byte>(136) ?? Array.Empty<byte>();
		}

		// Token: 0x17001997 RID: 6551
		// (get) Token: 0x060084FA RID: 34042 RVA: 0x00262E28 File Offset: 0x00261028
		public int AutoLeaveTime
		{
			get
			{
				int num = this.__p.__offset(138);
				if (num == 0)
				{
					return 300;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001998 RID: 6552
		// (get) Token: 0x060084FB RID: 34043 RVA: 0x00262E6C File Offset: 0x0026106C
		public int LimitTime
		{
			get
			{
				int num = this.__p.__offset(140);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001999 RID: 6553
		// (get) Token: 0x060084FC RID: 34044 RVA: 0x00262EAC File Offset: 0x002610AC
		public int LeaveWaitTime
		{
			get
			{
				int num = this.__p.__offset(142);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700199A RID: 6554
		// (get) Token: 0x060084FD RID: 34045 RVA: 0x00262EEC File Offset: 0x002610EC
		public string FailTips
		{
			get
			{
				int num = this.__p.__offset(144);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060084FE RID: 34046 RVA: 0x00262F27 File Offset: 0x00261127
		public Span<byte> GetFailTipsBytes()
		{
			return this.__p.__vector_as_span<byte>(144, 1);
		}

		// Token: 0x060084FF RID: 34047 RVA: 0x00262F3A File Offset: 0x0026113A
		public byte[] GetFailTipsArray()
		{
			return this.__p.__vector_as_array<byte>(144) ?? Array.Empty<byte>();
		}

		// Token: 0x1700199B RID: 6555
		// (get) Token: 0x06008500 RID: 34048 RVA: 0x00262F58 File Offset: 0x00261158
		public bool VerifyCreatureGen
		{
			get
			{
				int num = this.__p.__offset(146);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06008501 RID: 34049 RVA: 0x00262F9C File Offset: 0x0026119C
		public int DifficultyLevel(int j)
		{
			int num = this.__p.__offset(148);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700199C RID: 6556
		// (get) Token: 0x06008502 RID: 34050 RVA: 0x00262FE0 File Offset: 0x002611E0
		public int DifficultyLevelLength
		{
			get
			{
				int num = this.__p.__offset(148);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06008503 RID: 34051 RVA: 0x0026300F File Offset: 0x0026120F
		public Span<int> GetDifficultyLevelBytes()
		{
			return this.__p.__vector_as_span<int>(148, 4);
		}

		// Token: 0x06008504 RID: 34052 RVA: 0x00263022 File Offset: 0x00261222
		public int[] GetDifficultyLevelArray()
		{
			return this.__p.__vector_as_array<int>(148) ?? Array.Empty<int>();
		}

		// Token: 0x06008505 RID: 34053 RVA: 0x00263040 File Offset: 0x00261240
		public string DifficultyDesc(int j)
		{
			int num = this.__p.__offset(150);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700199D RID: 6557
		// (get) Token: 0x06008506 RID: 34054 RVA: 0x00263080 File Offset: 0x00261280
		public int DifficultyDescLength
		{
			get
			{
				int num = this.__p.__offset(150);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06008507 RID: 34055 RVA: 0x002630B0 File Offset: 0x002612B0
		public int Drop(int j)
		{
			int num = this.__p.__offset(152);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700199E RID: 6558
		// (get) Token: 0x06008508 RID: 34056 RVA: 0x002630F4 File Offset: 0x002612F4
		public int DropLength
		{
			get
			{
				int num = this.__p.__offset(152);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06008509 RID: 34057 RVA: 0x00263123 File Offset: 0x00261323
		public Span<int> GetDropBytes()
		{
			return this.__p.__vector_as_span<int>(152, 4);
		}

		// Token: 0x0600850A RID: 34058 RVA: 0x00263136 File Offset: 0x00261336
		public int[] GetDropArray()
		{
			return this.__p.__vector_as_array<int>(152) ?? Array.Empty<int>();
		}

		// Token: 0x1700199F RID: 6559
		// (get) Token: 0x0600850B RID: 34059 RVA: 0x00263154 File Offset: 0x00261354
		public int EnterCount
		{
			get
			{
				int num = this.__p.__offset(154);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170019A0 RID: 6560
		// (get) Token: 0x0600850C RID: 34060 RVA: 0x00263194 File Offset: 0x00261394
		public int EnterConditionGroup
		{
			get
			{
				int num = this.__p.__offset(156);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170019A1 RID: 6561
		// (get) Token: 0x0600850D RID: 34061 RVA: 0x002631D4 File Offset: 0x002613D4
		public string IconTagPath
		{
			get
			{
				int num = this.__p.__offset(158);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600850E RID: 34062 RVA: 0x0026320F File Offset: 0x0026140F
		public Span<byte> GetIconTagPathBytes()
		{
			return this.__p.__vector_as_span<byte>(158, 1);
		}

		// Token: 0x0600850F RID: 34063 RVA: 0x00263222 File Offset: 0x00261422
		public byte[] GetIconTagPathArray()
		{
			return this.__p.__vector_as_array<byte>(158) ?? Array.Empty<byte>();
		}

		// Token: 0x06008510 RID: 34064 RVA: 0x00263240 File Offset: 0x00261440
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BornPositionIter()或GetBornPositionBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] BornPosition()
		{
			InstanceDungeon instanceDungeon = this;
			return instanceDungeon.GetBornPositionArray() ?? Array.Empty<int>();
		}

		// Token: 0x06008511 RID: 34065 RVA: 0x00263264 File Offset: 0x00261464
		[NullableContext(1)]
		public readonly IEnumerable<int> BornPositionIter()
		{
			InstanceDungeon.<BornPositionIter>d__253 <BornPositionIter>d__ = new InstanceDungeon.<BornPositionIter>d__253(-2);
			<BornPositionIter>d__.<>3__<>4__this = this;
			return <BornPositionIter>d__;
		}

		// Token: 0x06008512 RID: 34066 RVA: 0x0026327C File Offset: 0x0026147C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BornRotationIter()或GetBornRotationBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] BornRotation()
		{
			InstanceDungeon instanceDungeon = this;
			return instanceDungeon.GetBornRotationArray() ?? Array.Empty<int>();
		}

		// Token: 0x06008513 RID: 34067 RVA: 0x002632A0 File Offset: 0x002614A0
		[NullableContext(1)]
		public readonly IEnumerable<int> BornRotationIter()
		{
			InstanceDungeon.<BornRotationIter>d__255 <BornRotationIter>d__ = new InstanceDungeon.<BornRotationIter>d__255(-2);
			<BornRotationIter>d__.<>3__<>4__this = this;
			return <BornRotationIter>d__;
		}

		// Token: 0x06008514 RID: 34068 RVA: 0x002632B8 File Offset: 0x002614B8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用CustomTypesIter()或GetCustomTypesBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] CustomTypes()
		{
			InstanceDungeon instanceDungeon = this;
			return instanceDungeon.GetCustomTypesArray() ?? Array.Empty<int>();
		}

		// Token: 0x06008515 RID: 34069 RVA: 0x002632DC File Offset: 0x002614DC
		[NullableContext(1)]
		public readonly IEnumerable<int> CustomTypesIter()
		{
			InstanceDungeon.<CustomTypesIter>d__257 <CustomTypesIter>d__ = new InstanceDungeon.<CustomTypesIter>d__257(-2);
			<CustomTypesIter>d__.<>3__<>4__this = this;
			return <CustomTypesIter>d__;
		}

		// Token: 0x06008516 RID: 34070 RVA: 0x002632F1 File Offset: 0x002614F1
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用DifficultyDescIter()或GetDifficultyDescBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] DifficultyDesc()
		{
			return this.DifficultyDescIter().ToArray<string>();
		}

		// Token: 0x06008517 RID: 34071 RVA: 0x002632FE File Offset: 0x002614FE
		[NullableContext(1)]
		public readonly IEnumerable<string> DifficultyDescIter()
		{
			InstanceDungeon.<DifficultyDescIter>d__259 <DifficultyDescIter>d__ = new InstanceDungeon.<DifficultyDescIter>d__259(-2);
			<DifficultyDescIter>d__.<>3__<>4__this = this;
			return <DifficultyDescIter>d__;
		}

		// Token: 0x06008518 RID: 34072 RVA: 0x00263314 File Offset: 0x00261514
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用DifficultyLevelIter()或GetDifficultyLevelBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] DifficultyLevel()
		{
			InstanceDungeon instanceDungeon = this;
			return instanceDungeon.GetDifficultyLevelArray() ?? Array.Empty<int>();
		}

		// Token: 0x06008519 RID: 34073 RVA: 0x00263338 File Offset: 0x00261538
		[NullableContext(1)]
		public readonly IEnumerable<int> DifficultyLevelIter()
		{
			InstanceDungeon.<DifficultyLevelIter>d__261 <DifficultyLevelIter>d__ = new InstanceDungeon.<DifficultyLevelIter>d__261(-2);
			<DifficultyLevelIter>d__.<>3__<>4__this = this;
			return <DifficultyLevelIter>d__;
		}

		// Token: 0x0600851A RID: 34074 RVA: 0x00263350 File Offset: 0x00261550
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用DropIter()或GetDropBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Drop()
		{
			InstanceDungeon instanceDungeon = this;
			return instanceDungeon.GetDropArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600851B RID: 34075 RVA: 0x00263374 File Offset: 0x00261574
		[NullableContext(1)]
		public readonly IEnumerable<int> DropIter()
		{
			InstanceDungeon.<DropIter>d__263 <DropIter>d__ = new InstanceDungeon.<DropIter>d__263(-2);
			<DropIter>d__.<>3__<>4__this = this;
			return <DropIter>d__;
		}

		// Token: 0x0600851C RID: 34076 RVA: 0x0026338C File Offset: 0x0026158C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用EnterConditionIter()或GetEnterConditionBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] EnterCondition()
		{
			InstanceDungeon instanceDungeon = this;
			return instanceDungeon.GetEnterConditionArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600851D RID: 34077 RVA: 0x002633B0 File Offset: 0x002615B0
		[NullableContext(1)]
		public readonly IEnumerable<int> EnterConditionIter()
		{
			InstanceDungeon.<EnterConditionIter>d__265 <EnterConditionIter>d__ = new InstanceDungeon.<EnterConditionIter>d__265(-2);
			<EnterConditionIter>d__.<>3__<>4__this = this;
			return <EnterConditionIter>d__;
		}

		// Token: 0x0600851E RID: 34078 RVA: 0x002633C8 File Offset: 0x002615C8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用EntityLevelIdsIter()或GetEntityLevelIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] EntityLevelIds()
		{
			InstanceDungeon instanceDungeon = this;
			return instanceDungeon.GetEntityLevelIdsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600851F RID: 34079 RVA: 0x002633EC File Offset: 0x002615EC
		[NullableContext(1)]
		public readonly IEnumerable<int> EntityLevelIdsIter()
		{
			InstanceDungeon.<EntityLevelIdsIter>d__267 <EntityLevelIdsIter>d__ = new InstanceDungeon.<EntityLevelIdsIter>d__267(-2);
			<EntityLevelIdsIter>d__.<>3__<>4__this = this;
			return <EntityLevelIdsIter>d__;
		}

		// Token: 0x06008520 RID: 34080 RVA: 0x00263401 File Offset: 0x00261601
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用EntranceEntitiesIter()或GetEntranceEntitiesBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly DungeonEntrance[] EntranceEntities()
		{
			return this.EntranceEntitiesIter().ToArray<DungeonEntrance>();
		}

		// Token: 0x06008521 RID: 34081 RVA: 0x0026340E File Offset: 0x0026160E
		[NullableContext(1)]
		public readonly IEnumerable<DungeonEntrance> EntranceEntitiesIter()
		{
			InstanceDungeon.<EntranceEntitiesIter>d__269 <EntranceEntitiesIter>d__ = new InstanceDungeon.<EntranceEntitiesIter>d__269(-2);
			<EntranceEntitiesIter>d__.<>3__<>4__this = this;
			return <EntranceEntitiesIter>d__;
		}

		// Token: 0x06008522 RID: 34082 RVA: 0x00263424 File Offset: 0x00261624
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ExitDungeonConfirmIdIter()或GetExitDungeonConfirmIdBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ExitDungeonConfirmId()
		{
			InstanceDungeon instanceDungeon = this;
			return instanceDungeon.GetExitDungeonConfirmIdArray() ?? Array.Empty<int>();
		}

		// Token: 0x06008523 RID: 34083 RVA: 0x00263448 File Offset: 0x00261648
		[NullableContext(1)]
		public readonly IEnumerable<int> ExitDungeonConfirmIdIter()
		{
			InstanceDungeon.<ExitDungeonConfirmIdIter>d__271 <ExitDungeonConfirmIdIter>d__ = new InstanceDungeon.<ExitDungeonConfirmIdIter>d__271(-2);
			<ExitDungeonConfirmIdIter>d__.<>3__<>4__this = this;
			return <ExitDungeonConfirmIdIter>d__;
		}

		// Token: 0x06008524 RID: 34084 RVA: 0x00263460 File Offset: 0x00261660
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ExitEntitiesIter()或GetExitEntitiesBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ExitEntities()
		{
			InstanceDungeon instanceDungeon = this;
			return instanceDungeon.GetExitEntitiesArray() ?? Array.Empty<int>();
		}

		// Token: 0x06008525 RID: 34085 RVA: 0x00263484 File Offset: 0x00261684
		[NullableContext(1)]
		public readonly IEnumerable<int> ExitEntitiesIter()
		{
			InstanceDungeon.<ExitEntitiesIter>d__273 <ExitEntitiesIter>d__ = new InstanceDungeon.<ExitEntitiesIter>d__273(-2);
			<ExitEntitiesIter>d__.<>3__<>4__this = this;
			return <ExitEntitiesIter>d__;
		}

		// Token: 0x06008526 RID: 34086 RVA: 0x0026349C File Offset: 0x0026169C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用FightInfoDtTypeIter()或GetFightInfoDtTypeBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] FightInfoDtType()
		{
			InstanceDungeon instanceDungeon = this;
			return instanceDungeon.GetFightInfoDtTypeArray() ?? Array.Empty<int>();
		}

		// Token: 0x06008527 RID: 34087 RVA: 0x002634C0 File Offset: 0x002616C0
		[NullableContext(1)]
		public readonly IEnumerable<int> FightInfoDtTypeIter()
		{
			InstanceDungeon.<FightInfoDtTypeIter>d__275 <FightInfoDtTypeIter>d__ = new InstanceDungeon.<FightInfoDtTypeIter>d__275(-2);
			<FightInfoDtTypeIter>d__.<>3__<>4__this = this;
			return <FightInfoDtTypeIter>d__;
		}

		// Token: 0x06008528 RID: 34088 RVA: 0x002634D8 File Offset: 0x002616D8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用FuncLimitIter()或GetFuncLimitBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] FuncLimit()
		{
			InstanceDungeon instanceDungeon = this;
			return instanceDungeon.GetFuncLimitArray() ?? Array.Empty<int>();
		}

		// Token: 0x06008529 RID: 34089 RVA: 0x002634FC File Offset: 0x002616FC
		[NullableContext(1)]
		public readonly IEnumerable<int> FuncLimitIter()
		{
			InstanceDungeon.<FuncLimitIter>d__277 <FuncLimitIter>d__ = new InstanceDungeon.<FuncLimitIter>d__277(-2);
			<FuncLimitIter>d__.<>3__<>4__this = this;
			return <FuncLimitIter>d__;
		}

		// Token: 0x0600852A RID: 34090 RVA: 0x00263511 File Offset: 0x00261711
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用LimitViewNameIter()或GetLimitViewNameBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] LimitViewName()
		{
			return this.LimitViewNameIter().ToArray<string>();
		}

		// Token: 0x0600852B RID: 34091 RVA: 0x0026351E File Offset: 0x0026171E
		[NullableContext(1)]
		public readonly IEnumerable<string> LimitViewNameIter()
		{
			InstanceDungeon.<LimitViewNameIter>d__279 <LimitViewNameIter>d__ = new InstanceDungeon.<LimitViewNameIter>d__279(-2);
			<LimitViewNameIter>d__.<>3__<>4__this = this;
			return <LimitViewNameIter>d__;
		}

		// Token: 0x0600852C RID: 34092 RVA: 0x00263534 File Offset: 0x00261734
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用MonsterPreviewIter()或GetMonsterPreviewBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] MonsterPreview()
		{
			InstanceDungeon instanceDungeon = this;
			return instanceDungeon.GetMonsterPreviewArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600852D RID: 34093 RVA: 0x00263558 File Offset: 0x00261758
		[NullableContext(1)]
		public readonly IEnumerable<int> MonsterPreviewIter()
		{
			InstanceDungeon.<MonsterPreviewIter>d__281 <MonsterPreviewIter>d__ = new InstanceDungeon.<MonsterPreviewIter>d__281(-2);
			<MonsterPreviewIter>d__.<>3__<>4__this = this;
			return <MonsterPreviewIter>d__;
		}

		// Token: 0x0600852E RID: 34094 RVA: 0x00263570 File Offset: 0x00261770
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RecommendElementIter()或GetRecommendElementBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] RecommendElement()
		{
			InstanceDungeon instanceDungeon = this;
			return instanceDungeon.GetRecommendElementArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600852F RID: 34095 RVA: 0x00263594 File Offset: 0x00261794
		[NullableContext(1)]
		public readonly IEnumerable<int> RecommendElementIter()
		{
			InstanceDungeon.<RecommendElementIter>d__283 <RecommendElementIter>d__ = new InstanceDungeon.<RecommendElementIter>d__283(-2);
			<RecommendElementIter>d__.<>3__<>4__this = this;
			return <RecommendElementIter>d__;
		}

		// Token: 0x06008530 RID: 34096 RVA: 0x002635AC File Offset: 0x002617AC
		[NullableContext(1)]
		[Obsolete("已废弃，请使用RecommendLevelFrozenDict()缓存字典，遍历请使用RecommendLevelIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> RecommendLevel()
		{
			return this.RecommendLevelIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06008531 RID: 34097 RVA: 0x00263602 File Offset: 0x00261802
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> RecommendLevelIter()
		{
			InstanceDungeon.<RecommendLevelIter>d__285 <RecommendLevelIter>d__ = new InstanceDungeon.<RecommendLevelIter>d__285(-2);
			<RecommendLevelIter>d__.<>3__<>4__this = this;
			return <RecommendLevelIter>d__;
		}

		// Token: 0x06008532 RID: 34098 RVA: 0x00263618 File Offset: 0x00261818
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RecommendRoleIter()或GetRecommendRoleBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] RecommendRole()
		{
			InstanceDungeon instanceDungeon = this;
			return instanceDungeon.GetRecommendRoleArray() ?? Array.Empty<int>();
		}

		// Token: 0x06008533 RID: 34099 RVA: 0x0026363C File Offset: 0x0026183C
		[NullableContext(1)]
		public readonly IEnumerable<int> RecommendRoleIter()
		{
			InstanceDungeon.<RecommendRoleIter>d__287 <RecommendRoleIter>d__ = new InstanceDungeon.<RecommendRoleIter>d__287(-2);
			<RecommendRoleIter>d__.<>3__<>4__this = this;
			return <RecommendRoleIter>d__;
		}

		// Token: 0x06008534 RID: 34100 RVA: 0x00263654 File Offset: 0x00261854
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RecommendRoleBottomIter()或GetRecommendRoleBottomBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] RecommendRoleBottom()
		{
			InstanceDungeon instanceDungeon = this;
			return instanceDungeon.GetRecommendRoleBottomArray() ?? Array.Empty<int>();
		}

		// Token: 0x06008535 RID: 34101 RVA: 0x00263678 File Offset: 0x00261878
		[NullableContext(1)]
		public readonly IEnumerable<int> RecommendRoleBottomIter()
		{
			InstanceDungeon.<RecommendRoleBottomIter>d__289 <RecommendRoleBottomIter>d__ = new InstanceDungeon.<RecommendRoleBottomIter>d__289(-2);
			<RecommendRoleBottomIter>d__.<>3__<>4__this = this;
			return <RecommendRoleBottomIter>d__;
		}

		// Token: 0x06008536 RID: 34102 RVA: 0x00263690 File Offset: 0x00261890
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RecoverWorldLocationIter()或GetRecoverWorldLocationBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] RecoverWorldLocation()
		{
			InstanceDungeon instanceDungeon = this;
			return instanceDungeon.GetRecoverWorldLocationArray() ?? Array.Empty<int>();
		}

		// Token: 0x06008537 RID: 34103 RVA: 0x002636B4 File Offset: 0x002618B4
		[NullableContext(1)]
		public readonly IEnumerable<int> RecoverWorldLocationIter()
		{
			InstanceDungeon.<RecoverWorldLocationIter>d__291 <RecoverWorldLocationIter>d__ = new InstanceDungeon.<RecoverWorldLocationIter>d__291(-2);
			<RecoverWorldLocationIter>d__.<>3__<>4__this = this;
			return <RecoverWorldLocationIter>d__;
		}

		// Token: 0x06008538 RID: 34104 RVA: 0x002636CC File Offset: 0x002618CC
		[NullableContext(1)]
		[Obsolete("已废弃，请使用RenderSettingsFrozenDict()缓存字典，遍历请使用RenderSettingsIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> RenderSettings()
		{
			return this.RenderSettingsIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06008539 RID: 34105 RVA: 0x00263722 File Offset: 0x00261922
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> RenderSettingsIter()
		{
			InstanceDungeon.<RenderSettingsIter>d__293 <RenderSettingsIter>d__ = new InstanceDungeon.<RenderSettingsIter>d__293(-2);
			<RenderSettingsIter>d__.<>3__<>4__this = this;
			return <RenderSettingsIter>d__;
		}

		// Token: 0x0600853A RID: 34106 RVA: 0x00263738 File Offset: 0x00261938
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RoleTypeListIter()或GetRoleTypeListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] RoleTypeList()
		{
			InstanceDungeon instanceDungeon = this;
			return instanceDungeon.GetRoleTypeListArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600853B RID: 34107 RVA: 0x0026375C File Offset: 0x0026195C
		[NullableContext(1)]
		public readonly IEnumerable<int> RoleTypeListIter()
		{
			InstanceDungeon.<RoleTypeListIter>d__295 <RoleTypeListIter>d__ = new InstanceDungeon.<RoleTypeListIter>d__295(-2);
			<RoleTypeListIter>d__.<>3__<>4__this = this;
			return <RoleTypeListIter>d__;
		}

		// Token: 0x0600853C RID: 34108 RVA: 0x00263774 File Offset: 0x00261974
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SharedTreasureGroupIter()或GetSharedTreasureGroupBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] SharedTreasureGroup()
		{
			InstanceDungeon instanceDungeon = this;
			return instanceDungeon.GetSharedTreasureGroupArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600853D RID: 34109 RVA: 0x00263798 File Offset: 0x00261998
		[NullableContext(1)]
		public readonly IEnumerable<int> SharedTreasureGroupIter()
		{
			InstanceDungeon.<SharedTreasureGroupIter>d__297 <SharedTreasureGroupIter>d__ = new InstanceDungeon.<SharedTreasureGroupIter>d__297(-2);
			<SharedTreasureGroupIter>d__.<>3__<>4__this = this;
			return <SharedTreasureGroupIter>d__;
		}

		// Token: 0x0600853E RID: 34110 RVA: 0x002637AD File Offset: 0x002619AD
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SubLevelsIter()或GetSubLevelsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] SubLevels()
		{
			return this.SubLevelsIter().ToArray<string>();
		}

		// Token: 0x0600853F RID: 34111 RVA: 0x002637BA File Offset: 0x002619BA
		[NullableContext(1)]
		public readonly IEnumerable<string> SubLevelsIter()
		{
			InstanceDungeon.<SubLevelsIter>d__299 <SubLevelsIter>d__ = new InstanceDungeon.<SubLevelsIter>d__299(-2);
			<SubLevelsIter>d__.<>3__<>4__this = this;
			return <SubLevelsIter>d__;
		}

		// Token: 0x06008540 RID: 34112 RVA: 0x002637D0 File Offset: 0x002619D0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SubPackageIdListIter()或GetSubPackageIdListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] SubPackageIdList()
		{
			InstanceDungeon instanceDungeon = this;
			return instanceDungeon.GetSubPackageIdListArray() ?? Array.Empty<int>();
		}

		// Token: 0x06008541 RID: 34113 RVA: 0x002637F4 File Offset: 0x002619F4
		[NullableContext(1)]
		public readonly IEnumerable<int> SubPackageIdListIter()
		{
			InstanceDungeon.<SubPackageIdListIter>d__301 <SubPackageIdListIter>d__ = new InstanceDungeon.<SubPackageIdListIter>d__301(-2);
			<SubPackageIdListIter>d__.<>3__<>4__this = this;
			return <SubPackageIdListIter>d__;
		}

		// Token: 0x06008542 RID: 34114 RVA: 0x0026380C File Offset: 0x00261A0C
		[NullableContext(1)]
		[Obsolete("已废弃，请使用SubTitleFrozenDict()缓存字典，遍历请使用SubTitleIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, string> SubTitle()
		{
			return this.SubTitleIter().ToDictionary((DicIntString element) => element.Key, (DicIntString element) => element.Value);
		}

		// Token: 0x06008543 RID: 34115 RVA: 0x00263862 File Offset: 0x00261A62
		[NullableContext(1)]
		public readonly IEnumerable<DicIntString> SubTitleIter()
		{
			InstanceDungeon.<SubTitleIter>d__303 <SubTitleIter>d__ = new InstanceDungeon.<SubTitleIter>d__303(-2);
			<SubTitleIter>d__.<>3__<>4__this = this;
			return <SubTitleIter>d__;
		}

		// Token: 0x06008544 RID: 34116 RVA: 0x00263878 File Offset: 0x00261A78
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用TreasureChestStatTypesIter()或GetTreasureChestStatTypesBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] TreasureChestStatTypes()
		{
			InstanceDungeon instanceDungeon = this;
			return instanceDungeon.GetTreasureChestStatTypesArray() ?? Array.Empty<int>();
		}

		// Token: 0x06008545 RID: 34117 RVA: 0x0026389C File Offset: 0x00261A9C
		[NullableContext(1)]
		public readonly IEnumerable<int> TreasureChestStatTypesIter()
		{
			InstanceDungeon.<TreasureChestStatTypesIter>d__305 <TreasureChestStatTypesIter>d__ = new InstanceDungeon.<TreasureChestStatTypesIter>d__305(-2);
			<TreasureChestStatTypesIter>d__.<>3__<>4__this = this;
			return <TreasureChestStatTypesIter>d__;
		}

		// Token: 0x06008546 RID: 34118 RVA: 0x002638B4 File Offset: 0x00261AB4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用TrialRoleInfoIter()或GetTrialRoleInfoBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] TrialRoleInfo()
		{
			InstanceDungeon instanceDungeon = this;
			return instanceDungeon.GetTrialRoleInfoArray() ?? Array.Empty<int>();
		}

		// Token: 0x06008547 RID: 34119 RVA: 0x002638D8 File Offset: 0x00261AD8
		[NullableContext(1)]
		public readonly IEnumerable<int> TrialRoleInfoIter()
		{
			InstanceDungeon.<TrialRoleInfoIter>d__307 <TrialRoleInfoIter>d__ = new InstanceDungeon.<TrialRoleInfoIter>d__307(-2);
			<TrialRoleInfoIter>d__.<>3__<>4__this = this;
			return <TrialRoleInfoIter>d__;
		}

		// Token: 0x06008548 RID: 34120 RVA: 0x002638F0 File Offset: 0x00261AF0
		public int? GetRecommendLevel(int key)
		{
			this.EnsureRecommendLevelCacheIfNeeded();
			int value;
			if (!this.RecommendLevelCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x06008549 RID: 34121 RVA: 0x00263924 File Offset: 0x00261B24
		public int? GetRenderSettings(int key)
		{
			this.EnsureRenderSettingsCacheIfNeeded();
			int value;
			if (!this.RenderSettingsCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600854A RID: 34122 RVA: 0x00263958 File Offset: 0x00261B58
		[NullableContext(2)]
		public string GetSubTitle(int key)
		{
			this.EnsureSubTitleCacheIfNeeded();
			string result;
			if (!this.SubTitleCache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x0600854B RID: 34123 RVA: 0x00263980 File Offset: 0x00261B80
		private void EnsureRecommendLevelCacheIfNeeded()
		{
			if (this.RecommendLevelCache != null)
			{
				return;
			}
			this.RecommendLevelCache = this.RecommendLevelIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600854C RID: 34124 RVA: 0x002639E8 File Offset: 0x00261BE8
		private void EnsureRenderSettingsCacheIfNeeded()
		{
			if (this.RenderSettingsCache != null)
			{
				return;
			}
			this.RenderSettingsCache = this.RenderSettingsIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600854D RID: 34125 RVA: 0x00263A50 File Offset: 0x00261C50
		private void EnsureSubTitleCacheIfNeeded()
		{
			if (this.SubTitleCache != null)
			{
				return;
			}
			this.SubTitleCache = this.SubTitleIter().ToFrozenDictionary((DicIntString kvp) => kvp.Key, (DicIntString kvp) => kvp.Value, null);
		}

		// Token: 0x0600854E RID: 34126 RVA: 0x00263AB6 File Offset: 0x00261CB6
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetRecommendLevelFrozenDict(int key)
		{
			this.EnsureRecommendLevelCacheIfNeeded();
			return this.RecommendLevelCache;
		}

		// Token: 0x0600854F RID: 34127 RVA: 0x00263AC4 File Offset: 0x00261CC4
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetRenderSettingsFrozenDict(int key)
		{
			this.EnsureRenderSettingsCacheIfNeeded();
			return this.RenderSettingsCache;
		}

		// Token: 0x06008550 RID: 34128 RVA: 0x00263AD2 File Offset: 0x00261CD2
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public FrozenDictionary<int, string> GetSubTitleFrozenDict(int key)
		{
			this.EnsureSubTitleCacheIfNeeded();
			return this.SubTitleCache;
		}

		// Token: 0x04004DF4 RID: 19956
		private Table __p;

		// Token: 0x04004DF5 RID: 19957
		[Nullable(2)]
		private FrozenDictionary<int, int> RecommendLevelCache;

		// Token: 0x04004DF6 RID: 19958
		[Nullable(2)]
		private FrozenDictionary<int, int> RenderSettingsCache;

		// Token: 0x04004DF7 RID: 19959
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<int, string> SubTitleCache;
	}
}

using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E54 RID: 3668
	public struct InstanceDungeon : IFlatbufferObject
	{
		// Token: 0x170019B6 RID: 6582
		// (get) Token: 0x06008A7E RID: 35454 RVA: 0x0027FA02 File Offset: 0x0027DC02
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008A7F RID: 35455 RVA: 0x0027FA0F File Offset: 0x0027DC0F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008A80 RID: 35456 RVA: 0x0027FA18 File Offset: 0x0027DC18
		public static InstanceDungeon GetRootAsInstanceDungeon(ByteBuffer _bb)
		{
			return InstanceDungeon.GetRootAsInstanceDungeon(_bb, default(InstanceDungeon));
		}

		// Token: 0x06008A81 RID: 35457 RVA: 0x0027FA34 File Offset: 0x0027DC34
		public static InstanceDungeon GetRootAsInstanceDungeon(ByteBuffer _bb, InstanceDungeon obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008A82 RID: 35458 RVA: 0x0027FA51 File Offset: 0x0027DC51
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008A83 RID: 35459 RVA: 0x0027FA60 File Offset: 0x0027DC60
		public InstanceDungeon __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170019B7 RID: 6583
		// (get) Token: 0x06008A84 RID: 35460 RVA: 0x0027FA70 File Offset: 0x0027DC70
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

		// Token: 0x170019B8 RID: 6584
		// (get) Token: 0x06008A85 RID: 35461 RVA: 0x0027FAAC File Offset: 0x0027DCAC
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

		// Token: 0x170019B9 RID: 6585
		// (get) Token: 0x06008A86 RID: 35462 RVA: 0x0027FAE8 File Offset: 0x0027DCE8
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

		// Token: 0x06008A87 RID: 35463 RVA: 0x0027FB1F File Offset: 0x0027DD1F
		public Span<byte> GetMapNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06008A88 RID: 35464 RVA: 0x0027FB2E File Offset: 0x0027DD2E
		public byte[] GetMapNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170019BA RID: 6586
		// (get) Token: 0x06008A89 RID: 35465 RVA: 0x0027FB48 File Offset: 0x0027DD48
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

		// Token: 0x170019BB RID: 6587
		// (get) Token: 0x06008A8A RID: 35466 RVA: 0x0027FB88 File Offset: 0x0027DD88
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

		// Token: 0x170019BC RID: 6588
		// (get) Token: 0x06008A8B RID: 35467 RVA: 0x0027FBC8 File Offset: 0x0027DDC8
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

		// Token: 0x170019BD RID: 6589
		// (get) Token: 0x06008A8C RID: 35468 RVA: 0x0027FC08 File Offset: 0x0027DE08
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

		// Token: 0x170019BE RID: 6590
		// (get) Token: 0x06008A8D RID: 35469 RVA: 0x0027FC48 File Offset: 0x0027DE48
		public bool EnableMulti
		{
			get
			{
				int num = this.__p.__offset(18);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06008A8E RID: 35470 RVA: 0x0027FC88 File Offset: 0x0027DE88
		public int CustomTypes(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170019BF RID: 6591
		// (get) Token: 0x06008A8F RID: 35471 RVA: 0x0027FCC8 File Offset: 0x0027DEC8
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

		// Token: 0x06008A90 RID: 35472 RVA: 0x0027FCF4 File Offset: 0x0027DEF4
		public Span<int> GetCustomTypesBytes()
		{
			return this.__p.__vector_as_span<int>(20, 4);
		}

		// Token: 0x06008A91 RID: 35473 RVA: 0x0027FD04 File Offset: 0x0027DF04
		public int[] GetCustomTypesArray()
		{
			return this.__p.__vector_as_array<int>(20) ?? Array.Empty<int>();
		}

		// Token: 0x06008A92 RID: 35474 RVA: 0x0027FD1C File Offset: 0x0027DF1C
		public int EntityLevelIds(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170019C0 RID: 6592
		// (get) Token: 0x06008A93 RID: 35475 RVA: 0x0027FD5C File Offset: 0x0027DF5C
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

		// Token: 0x06008A94 RID: 35476 RVA: 0x0027FD88 File Offset: 0x0027DF88
		public Span<int> GetEntityLevelIdsBytes()
		{
			return this.__p.__vector_as_span<int>(22, 4);
		}

		// Token: 0x06008A95 RID: 35477 RVA: 0x0027FD98 File Offset: 0x0027DF98
		public int[] GetEntityLevelIdsArray()
		{
			return this.__p.__vector_as_array<int>(22) ?? Array.Empty<int>();
		}

		// Token: 0x170019C1 RID: 6593
		// (get) Token: 0x06008A96 RID: 35478 RVA: 0x0027FDB0 File Offset: 0x0027DFB0
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

		// Token: 0x06008A97 RID: 35479 RVA: 0x0027FDF0 File Offset: 0x0027DFF0
		public string SubLevels(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170019C2 RID: 6594
		// (get) Token: 0x06008A98 RID: 35480 RVA: 0x0027FE2C File Offset: 0x0027E02C
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

		// Token: 0x170019C3 RID: 6595
		// (get) Token: 0x06008A99 RID: 35481 RVA: 0x0027FE58 File Offset: 0x0027E058
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

		// Token: 0x06008A9A RID: 35482 RVA: 0x0027FE98 File Offset: 0x0027E098
		public int RoleTypeList(int j)
		{
			int num = this.__p.__offset(30);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170019C4 RID: 6596
		// (get) Token: 0x06008A9B RID: 35483 RVA: 0x0027FED8 File Offset: 0x0027E0D8
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

		// Token: 0x06008A9C RID: 35484 RVA: 0x0027FF04 File Offset: 0x0027E104
		public Span<int> GetRoleTypeListBytes()
		{
			return this.__p.__vector_as_span<int>(30, 4);
		}

		// Token: 0x06008A9D RID: 35485 RVA: 0x0027FF14 File Offset: 0x0027E114
		public int[] GetRoleTypeListArray()
		{
			return this.__p.__vector_as_array<int>(30) ?? Array.Empty<int>();
		}

		// Token: 0x06008A9E RID: 35486 RVA: 0x0027FF2C File Offset: 0x0027E12C
		public int TrialRoleInfo(int j)
		{
			int num = this.__p.__offset(32);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170019C5 RID: 6597
		// (get) Token: 0x06008A9F RID: 35487 RVA: 0x0027FF6C File Offset: 0x0027E16C
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

		// Token: 0x06008AA0 RID: 35488 RVA: 0x0027FF98 File Offset: 0x0027E198
		public Span<int> GetTrialRoleInfoBytes()
		{
			return this.__p.__vector_as_span<int>(32, 4);
		}

		// Token: 0x06008AA1 RID: 35489 RVA: 0x0027FFA8 File Offset: 0x0027E1A8
		public int[] GetTrialRoleInfoArray()
		{
			return this.__p.__vector_as_array<int>(32) ?? Array.Empty<int>();
		}

		// Token: 0x170019C6 RID: 6598
		// (get) Token: 0x06008AA2 RID: 35490 RVA: 0x0027FFC0 File Offset: 0x0027E1C0
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

		// Token: 0x170019C7 RID: 6599
		// (get) Token: 0x06008AA3 RID: 35491 RVA: 0x00280000 File Offset: 0x0027E200
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

		// Token: 0x06008AA4 RID: 35492 RVA: 0x00280040 File Offset: 0x0027E240
		public int BornPosition(int j)
		{
			int num = this.__p.__offset(38);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170019C8 RID: 6600
		// (get) Token: 0x06008AA5 RID: 35493 RVA: 0x00280080 File Offset: 0x0027E280
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

		// Token: 0x06008AA6 RID: 35494 RVA: 0x002800AC File Offset: 0x0027E2AC
		public Span<int> GetBornPositionBytes()
		{
			return this.__p.__vector_as_span<int>(38, 4);
		}

		// Token: 0x06008AA7 RID: 35495 RVA: 0x002800BC File Offset: 0x0027E2BC
		public int[] GetBornPositionArray()
		{
			return this.__p.__vector_as_array<int>(38) ?? Array.Empty<int>();
		}

		// Token: 0x06008AA8 RID: 35496 RVA: 0x002800D4 File Offset: 0x0027E2D4
		public int BornRotation(int j)
		{
			int num = this.__p.__offset(40);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170019C9 RID: 6601
		// (get) Token: 0x06008AA9 RID: 35497 RVA: 0x00280114 File Offset: 0x0027E314
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

		// Token: 0x06008AAA RID: 35498 RVA: 0x00280140 File Offset: 0x0027E340
		public Span<int> GetBornRotationBytes()
		{
			return this.__p.__vector_as_span<int>(40, 4);
		}

		// Token: 0x06008AAB RID: 35499 RVA: 0x00280150 File Offset: 0x0027E350
		public int[] GetBornRotationArray()
		{
			return this.__p.__vector_as_array<int>(40) ?? Array.Empty<int>();
		}

		// Token: 0x06008AAC RID: 35500 RVA: 0x00280168 File Offset: 0x0027E368
		public int RecoverWorldLocation(int j)
		{
			int num = this.__p.__offset(42);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170019CA RID: 6602
		// (get) Token: 0x06008AAD RID: 35501 RVA: 0x002801A8 File Offset: 0x0027E3A8
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

		// Token: 0x06008AAE RID: 35502 RVA: 0x002801D4 File Offset: 0x0027E3D4
		public Span<int> GetRecoverWorldLocationBytes()
		{
			return this.__p.__vector_as_span<int>(42, 4);
		}

		// Token: 0x06008AAF RID: 35503 RVA: 0x002801E4 File Offset: 0x0027E3E4
		public int[] GetRecoverWorldLocationArray()
		{
			return this.__p.__vector_as_array<int>(42) ?? Array.Empty<int>();
		}

		// Token: 0x06008AB0 RID: 35504 RVA: 0x002801FC File Offset: 0x0027E3FC
		public int ExitDungeonConfirmId(int j)
		{
			int num = this.__p.__offset(44);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170019CB RID: 6603
		// (get) Token: 0x06008AB1 RID: 35505 RVA: 0x0028023C File Offset: 0x0027E43C
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

		// Token: 0x06008AB2 RID: 35506 RVA: 0x00280268 File Offset: 0x0027E468
		public Span<int> GetExitDungeonConfirmIdBytes()
		{
			return this.__p.__vector_as_span<int>(44, 4);
		}

		// Token: 0x06008AB3 RID: 35507 RVA: 0x00280278 File Offset: 0x0027E478
		public int[] GetExitDungeonConfirmIdArray()
		{
			return this.__p.__vector_as_array<int>(44) ?? Array.Empty<int>();
		}

		// Token: 0x06008AB4 RID: 35508 RVA: 0x00280290 File Offset: 0x0027E490
		public DungeonEntrance? EntranceEntities(int j)
		{
			int num = this.__p.__offset(46);
			if (num == 0)
			{
				return null;
			}
			return new DungeonEntrance?(default(DungeonEntrance).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170019CC RID: 6604
		// (get) Token: 0x06008AB5 RID: 35509 RVA: 0x002802F4 File Offset: 0x0027E4F4
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

		// Token: 0x06008AB6 RID: 35510 RVA: 0x00280320 File Offset: 0x0027E520
		public int ExitEntities(int j)
		{
			int num = this.__p.__offset(48);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170019CD RID: 6605
		// (get) Token: 0x06008AB7 RID: 35511 RVA: 0x00280360 File Offset: 0x0027E560
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

		// Token: 0x06008AB8 RID: 35512 RVA: 0x0028038C File Offset: 0x0027E58C
		public Span<int> GetExitEntitiesBytes()
		{
			return this.__p.__vector_as_span<int>(48, 4);
		}

		// Token: 0x06008AB9 RID: 35513 RVA: 0x0028039C File Offset: 0x0027E59C
		public int[] GetExitEntitiesArray()
		{
			return this.__p.__vector_as_array<int>(48) ?? Array.Empty<int>();
		}

		// Token: 0x170019CE RID: 6606
		// (get) Token: 0x06008ABA RID: 35514 RVA: 0x002803B4 File Offset: 0x0027E5B4
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

		// Token: 0x06008ABB RID: 35515 RVA: 0x002803EC File Offset: 0x0027E5EC
		public Span<byte> GetDungeonDescBytes()
		{
			return this.__p.__vector_as_span<byte>(50, 1);
		}

		// Token: 0x06008ABC RID: 35516 RVA: 0x002803FC File Offset: 0x0027E5FC
		public byte[] GetDungeonDescArray()
		{
			return this.__p.__vector_as_array<byte>(50) ?? Array.Empty<byte>();
		}

		// Token: 0x170019CF RID: 6607
		// (get) Token: 0x06008ABD RID: 35517 RVA: 0x00280414 File Offset: 0x0027E614
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

		// Token: 0x170019D0 RID: 6608
		// (get) Token: 0x06008ABE RID: 35518 RVA: 0x00280458 File Offset: 0x0027E658
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

		// Token: 0x06008ABF RID: 35519 RVA: 0x00280490 File Offset: 0x0027E690
		public Span<byte> GetBannerPathBytes()
		{
			return this.__p.__vector_as_span<byte>(54, 1);
		}

		// Token: 0x06008AC0 RID: 35520 RVA: 0x002804A0 File Offset: 0x0027E6A0
		public byte[] GetBannerPathArray()
		{
			return this.__p.__vector_as_array<byte>(54) ?? Array.Empty<byte>();
		}

		// Token: 0x06008AC1 RID: 35521 RVA: 0x002804B8 File Offset: 0x0027E6B8
		public int MonsterPreview(int j)
		{
			int num = this.__p.__offset(56);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170019D1 RID: 6609
		// (get) Token: 0x06008AC2 RID: 35522 RVA: 0x002804F8 File Offset: 0x0027E6F8
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

		// Token: 0x06008AC3 RID: 35523 RVA: 0x00280524 File Offset: 0x0027E724
		public Span<int> GetMonsterPreviewBytes()
		{
			return this.__p.__vector_as_span<int>(56, 4);
		}

		// Token: 0x06008AC4 RID: 35524 RVA: 0x00280534 File Offset: 0x0027E734
		public int[] GetMonsterPreviewArray()
		{
			return this.__p.__vector_as_array<int>(56) ?? Array.Empty<int>();
		}

		// Token: 0x170019D2 RID: 6610
		// (get) Token: 0x06008AC5 RID: 35525 RVA: 0x0028054C File Offset: 0x0027E74C
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

		// Token: 0x06008AC6 RID: 35526 RVA: 0x00280584 File Offset: 0x0027E784
		public Span<byte> GetMonsterTipsBytes()
		{
			return this.__p.__vector_as_span<byte>(58, 1);
		}

		// Token: 0x06008AC7 RID: 35527 RVA: 0x00280594 File Offset: 0x0027E794
		public byte[] GetMonsterTipsArray()
		{
			return this.__p.__vector_as_array<byte>(58) ?? Array.Empty<byte>();
		}

		// Token: 0x170019D3 RID: 6611
		// (get) Token: 0x06008AC8 RID: 35528 RVA: 0x002805AC File Offset: 0x0027E7AC
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

		// Token: 0x170019D4 RID: 6612
		// (get) Token: 0x06008AC9 RID: 35529 RVA: 0x002805EC File Offset: 0x0027E7EC
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

		// Token: 0x170019D5 RID: 6613
		// (get) Token: 0x06008ACA RID: 35530 RVA: 0x0028062C File Offset: 0x0027E82C
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

		// Token: 0x170019D6 RID: 6614
		// (get) Token: 0x06008ACB RID: 35531 RVA: 0x0028066C File Offset: 0x0027E86C
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

		// Token: 0x170019D7 RID: 6615
		// (get) Token: 0x06008ACC RID: 35532 RVA: 0x002806AC File Offset: 0x0027E8AC
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

		// Token: 0x06008ACD RID: 35533 RVA: 0x002806EC File Offset: 0x0027E8EC
		public int SharedTreasureGroup(int j)
		{
			int num = this.__p.__offset(70);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170019D8 RID: 6616
		// (get) Token: 0x06008ACE RID: 35534 RVA: 0x0028072C File Offset: 0x0027E92C
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

		// Token: 0x06008ACF RID: 35535 RVA: 0x00280758 File Offset: 0x0027E958
		public Span<int> GetSharedTreasureGroupBytes()
		{
			return this.__p.__vector_as_span<int>(70, 4);
		}

		// Token: 0x06008AD0 RID: 35536 RVA: 0x00280768 File Offset: 0x0027E968
		public int[] GetSharedTreasureGroupArray()
		{
			return this.__p.__vector_as_array<int>(70) ?? Array.Empty<int>();
		}

		// Token: 0x170019D9 RID: 6617
		// (get) Token: 0x06008AD1 RID: 35537 RVA: 0x00280780 File Offset: 0x0027E980
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

		// Token: 0x06008AD2 RID: 35538 RVA: 0x002807C0 File Offset: 0x0027E9C0
		public int EnterCondition(int j)
		{
			int num = this.__p.__offset(74);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170019DA RID: 6618
		// (get) Token: 0x06008AD3 RID: 35539 RVA: 0x00280800 File Offset: 0x0027EA00
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

		// Token: 0x06008AD4 RID: 35540 RVA: 0x0028082C File Offset: 0x0027EA2C
		public Span<int> GetEnterConditionBytes()
		{
			return this.__p.__vector_as_span<int>(74, 4);
		}

		// Token: 0x06008AD5 RID: 35541 RVA: 0x0028083C File Offset: 0x0027EA3C
		public int[] GetEnterConditionArray()
		{
			return this.__p.__vector_as_array<int>(74) ?? Array.Empty<int>();
		}

		// Token: 0x170019DB RID: 6619
		// (get) Token: 0x06008AD6 RID: 35542 RVA: 0x00280854 File Offset: 0x0027EA54
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

		// Token: 0x06008AD7 RID: 35543 RVA: 0x0028088C File Offset: 0x0027EA8C
		public Span<byte> GetEnterConditionTextBytes()
		{
			return this.__p.__vector_as_span<byte>(76, 1);
		}

		// Token: 0x06008AD8 RID: 35544 RVA: 0x0028089C File Offset: 0x0027EA9C
		public byte[] GetEnterConditionTextArray()
		{
			return this.__p.__vector_as_array<byte>(76) ?? Array.Empty<byte>();
		}

		// Token: 0x170019DC RID: 6620
		// (get) Token: 0x06008AD9 RID: 35545 RVA: 0x002808B4 File Offset: 0x0027EAB4
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

		// Token: 0x06008ADA RID: 35546 RVA: 0x002808EC File Offset: 0x0027EAEC
		public Span<byte> GetDifficultyIconBytes()
		{
			return this.__p.__vector_as_span<byte>(78, 1);
		}

		// Token: 0x06008ADB RID: 35547 RVA: 0x002808FC File Offset: 0x0027EAFC
		public byte[] GetDifficultyIconArray()
		{
			return this.__p.__vector_as_array<byte>(78) ?? Array.Empty<byte>();
		}

		// Token: 0x170019DD RID: 6621
		// (get) Token: 0x06008ADC RID: 35548 RVA: 0x00280914 File Offset: 0x0027EB14
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

		// Token: 0x06008ADD RID: 35549 RVA: 0x00280954 File Offset: 0x0027EB54
		public DicIntInt? RecommendLevel(int j)
		{
			int num = this.__p.__offset(82);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170019DE RID: 6622
		// (get) Token: 0x06008ADE RID: 35550 RVA: 0x002809B8 File Offset: 0x0027EBB8
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

		// Token: 0x06008ADF RID: 35551 RVA: 0x002809E4 File Offset: 0x0027EBE4
		public int RecommendRole(int j)
		{
			int num = this.__p.__offset(84);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170019DF RID: 6623
		// (get) Token: 0x06008AE0 RID: 35552 RVA: 0x00280A24 File Offset: 0x0027EC24
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

		// Token: 0x06008AE1 RID: 35553 RVA: 0x00280A50 File Offset: 0x0027EC50
		public Span<int> GetRecommendRoleBytes()
		{
			return this.__p.__vector_as_span<int>(84, 4);
		}

		// Token: 0x06008AE2 RID: 35554 RVA: 0x00280A60 File Offset: 0x0027EC60
		public int[] GetRecommendRoleArray()
		{
			return this.__p.__vector_as_array<int>(84) ?? Array.Empty<int>();
		}

		// Token: 0x06008AE3 RID: 35555 RVA: 0x00280A78 File Offset: 0x0027EC78
		public int RecommendRoleBottom(int j)
		{
			int num = this.__p.__offset(86);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170019E0 RID: 6624
		// (get) Token: 0x06008AE4 RID: 35556 RVA: 0x00280AB8 File Offset: 0x0027ECB8
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

		// Token: 0x06008AE5 RID: 35557 RVA: 0x00280AE4 File Offset: 0x0027ECE4
		public Span<int> GetRecommendRoleBottomBytes()
		{
			return this.__p.__vector_as_span<int>(86, 4);
		}

		// Token: 0x06008AE6 RID: 35558 RVA: 0x00280AF4 File Offset: 0x0027ECF4
		public int[] GetRecommendRoleBottomArray()
		{
			return this.__p.__vector_as_array<int>(86) ?? Array.Empty<int>();
		}

		// Token: 0x06008AE7 RID: 35559 RVA: 0x00280B0C File Offset: 0x0027ED0C
		public int RecommendElement(int j)
		{
			int num = this.__p.__offset(88);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170019E1 RID: 6625
		// (get) Token: 0x06008AE8 RID: 35560 RVA: 0x00280B4C File Offset: 0x0027ED4C
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

		// Token: 0x06008AE9 RID: 35561 RVA: 0x00280B78 File Offset: 0x0027ED78
		public Span<int> GetRecommendElementBytes()
		{
			return this.__p.__vector_as_span<int>(88, 4);
		}

		// Token: 0x06008AEA RID: 35562 RVA: 0x00280B88 File Offset: 0x0027ED88
		public int[] GetRecommendElementArray()
		{
			return this.__p.__vector_as_array<int>(88) ?? Array.Empty<int>();
		}

		// Token: 0x170019E2 RID: 6626
		// (get) Token: 0x06008AEB RID: 35563 RVA: 0x00280BA0 File Offset: 0x0027EDA0
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

		// Token: 0x06008AEC RID: 35564 RVA: 0x00280BE0 File Offset: 0x0027EDE0
		public int FightInfoDtType(int j)
		{
			int num = this.__p.__offset(92);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170019E3 RID: 6627
		// (get) Token: 0x06008AED RID: 35565 RVA: 0x00280C20 File Offset: 0x0027EE20
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

		// Token: 0x06008AEE RID: 35566 RVA: 0x00280C4C File Offset: 0x0027EE4C
		public Span<int> GetFightInfoDtTypeBytes()
		{
			return this.__p.__vector_as_span<int>(92, 4);
		}

		// Token: 0x06008AEF RID: 35567 RVA: 0x00280C5C File Offset: 0x0027EE5C
		public int[] GetFightInfoDtTypeArray()
		{
			return this.__p.__vector_as_array<int>(92) ?? Array.Empty<int>();
		}

		// Token: 0x170019E4 RID: 6628
		// (get) Token: 0x06008AF0 RID: 35568 RVA: 0x00280C74 File Offset: 0x0027EE74
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

		// Token: 0x06008AF1 RID: 35569 RVA: 0x00280CB4 File Offset: 0x0027EEB4
		public string LimitViewName(int j)
		{
			int num = this.__p.__offset(96);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170019E5 RID: 6629
		// (get) Token: 0x06008AF2 RID: 35570 RVA: 0x00280CF0 File Offset: 0x0027EEF0
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

		// Token: 0x06008AF3 RID: 35571 RVA: 0x00280D1C File Offset: 0x0027EF1C
		public int FuncLimit(int j)
		{
			int num = this.__p.__offset(98);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170019E6 RID: 6630
		// (get) Token: 0x06008AF4 RID: 35572 RVA: 0x00280D5C File Offset: 0x0027EF5C
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

		// Token: 0x06008AF5 RID: 35573 RVA: 0x00280D88 File Offset: 0x0027EF88
		public Span<int> GetFuncLimitBytes()
		{
			return this.__p.__vector_as_span<int>(98, 4);
		}

		// Token: 0x06008AF6 RID: 35574 RVA: 0x00280D98 File Offset: 0x0027EF98
		public int[] GetFuncLimitArray()
		{
			return this.__p.__vector_as_array<int>(98) ?? Array.Empty<int>();
		}

		// Token: 0x170019E7 RID: 6631
		// (get) Token: 0x06008AF7 RID: 35575 RVA: 0x00280DB0 File Offset: 0x0027EFB0
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

		// Token: 0x170019E8 RID: 6632
		// (get) Token: 0x06008AF8 RID: 35576 RVA: 0x00280DF0 File Offset: 0x0027EFF0
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

		// Token: 0x170019E9 RID: 6633
		// (get) Token: 0x06008AF9 RID: 35577 RVA: 0x00280E30 File Offset: 0x0027F030
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

		// Token: 0x170019EA RID: 6634
		// (get) Token: 0x06008AFA RID: 35578 RVA: 0x00280E70 File Offset: 0x0027F070
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

		// Token: 0x170019EB RID: 6635
		// (get) Token: 0x06008AFB RID: 35579 RVA: 0x00280EB0 File Offset: 0x0027F0B0
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

		// Token: 0x06008AFC RID: 35580 RVA: 0x00280EF0 File Offset: 0x0027F0F0
		public DicIntString? SubTitle(int j)
		{
			int num = this.__p.__offset(110);
			if (num == 0)
			{
				return null;
			}
			return new DicIntString?(default(DicIntString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170019EC RID: 6636
		// (get) Token: 0x06008AFD RID: 35581 RVA: 0x00280F54 File Offset: 0x0027F154
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

		// Token: 0x170019ED RID: 6637
		// (get) Token: 0x06008AFE RID: 35582 RVA: 0x00280F80 File Offset: 0x0027F180
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

		// Token: 0x06008AFF RID: 35583 RVA: 0x00280FC0 File Offset: 0x0027F1C0
		public DicIntInt? RenderSettings(int j)
		{
			int num = this.__p.__offset(114);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170019EE RID: 6638
		// (get) Token: 0x06008B00 RID: 35584 RVA: 0x00281024 File Offset: 0x0027F224
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

		// Token: 0x170019EF RID: 6639
		// (get) Token: 0x06008B01 RID: 35585 RVA: 0x00281050 File Offset: 0x0027F250
		public bool IsFogFullUnlock
		{
			get
			{
				int num = this.__p.__offset(116);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170019F0 RID: 6640
		// (get) Token: 0x06008B02 RID: 35586 RVA: 0x00281090 File Offset: 0x0027F290
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

		// Token: 0x170019F1 RID: 6641
		// (get) Token: 0x06008B03 RID: 35587 RVA: 0x002810D0 File Offset: 0x0027F2D0
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

		// Token: 0x170019F2 RID: 6642
		// (get) Token: 0x06008B04 RID: 35588 RVA: 0x00281110 File Offset: 0x0027F310
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

		// Token: 0x170019F3 RID: 6643
		// (get) Token: 0x06008B05 RID: 35589 RVA: 0x00281150 File Offset: 0x0027F350
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

		// Token: 0x170019F4 RID: 6644
		// (get) Token: 0x06008B06 RID: 35590 RVA: 0x00281190 File Offset: 0x0027F390
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

		// Token: 0x06008B07 RID: 35591 RVA: 0x002811D0 File Offset: 0x0027F3D0
		public int SubPackageIdList(int j)
		{
			int num = this.__p.__offset(128);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170019F5 RID: 6645
		// (get) Token: 0x06008B08 RID: 35592 RVA: 0x00281214 File Offset: 0x0027F414
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

		// Token: 0x06008B09 RID: 35593 RVA: 0x00281243 File Offset: 0x0027F443
		public Span<int> GetSubPackageIdListBytes()
		{
			return this.__p.__vector_as_span<int>(128, 4);
		}

		// Token: 0x06008B0A RID: 35594 RVA: 0x00281256 File Offset: 0x0027F456
		public int[] GetSubPackageIdListArray()
		{
			return this.__p.__vector_as_array<int>(128) ?? Array.Empty<int>();
		}

		// Token: 0x170019F6 RID: 6646
		// (get) Token: 0x06008B0B RID: 35595 RVA: 0x00281274 File Offset: 0x0027F474
		public bool IsExitOnlineTeam
		{
			get
			{
				int num = this.__p.__offset(130);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170019F7 RID: 6647
		// (get) Token: 0x06008B0C RID: 35596 RVA: 0x002812B8 File Offset: 0x0027F4B8
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

		// Token: 0x06008B0D RID: 35597 RVA: 0x002812F8 File Offset: 0x0027F4F8
		public int TreasureChestStatTypes(int j)
		{
			int num = this.__p.__offset(134);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170019F8 RID: 6648
		// (get) Token: 0x06008B0E RID: 35598 RVA: 0x0028133C File Offset: 0x0027F53C
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

		// Token: 0x06008B0F RID: 35599 RVA: 0x0028136B File Offset: 0x0027F56B
		public Span<int> GetTreasureChestStatTypesBytes()
		{
			return this.__p.__vector_as_span<int>(134, 4);
		}

		// Token: 0x06008B10 RID: 35600 RVA: 0x0028137E File Offset: 0x0027F57E
		public int[] GetTreasureChestStatTypesArray()
		{
			return this.__p.__vector_as_array<int>(134) ?? Array.Empty<int>();
		}

		// Token: 0x170019F9 RID: 6649
		// (get) Token: 0x06008B11 RID: 35601 RVA: 0x0028139C File Offset: 0x0027F59C
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

		// Token: 0x06008B12 RID: 35602 RVA: 0x002813D7 File Offset: 0x0027F5D7
		public Span<byte> GetSubInstanceTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(136, 1);
		}

		// Token: 0x06008B13 RID: 35603 RVA: 0x002813EA File Offset: 0x0027F5EA
		public byte[] GetSubInstanceTitleArray()
		{
			return this.__p.__vector_as_array<byte>(136) ?? Array.Empty<byte>();
		}

		// Token: 0x170019FA RID: 6650
		// (get) Token: 0x06008B14 RID: 35604 RVA: 0x00281408 File Offset: 0x0027F608
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

		// Token: 0x170019FB RID: 6651
		// (get) Token: 0x06008B15 RID: 35605 RVA: 0x0028144C File Offset: 0x0027F64C
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

		// Token: 0x170019FC RID: 6652
		// (get) Token: 0x06008B16 RID: 35606 RVA: 0x0028148C File Offset: 0x0027F68C
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

		// Token: 0x170019FD RID: 6653
		// (get) Token: 0x06008B17 RID: 35607 RVA: 0x002814CC File Offset: 0x0027F6CC
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

		// Token: 0x06008B18 RID: 35608 RVA: 0x00281507 File Offset: 0x0027F707
		public Span<byte> GetFailTipsBytes()
		{
			return this.__p.__vector_as_span<byte>(144, 1);
		}

		// Token: 0x06008B19 RID: 35609 RVA: 0x0028151A File Offset: 0x0027F71A
		public byte[] GetFailTipsArray()
		{
			return this.__p.__vector_as_array<byte>(144) ?? Array.Empty<byte>();
		}

		// Token: 0x170019FE RID: 6654
		// (get) Token: 0x06008B1A RID: 35610 RVA: 0x00281538 File Offset: 0x0027F738
		public bool VerifyCreatureGen
		{
			get
			{
				int num = this.__p.__offset(146);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06008B1B RID: 35611 RVA: 0x0028157C File Offset: 0x0027F77C
		public int DifficultyLevel(int j)
		{
			int num = this.__p.__offset(148);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170019FF RID: 6655
		// (get) Token: 0x06008B1C RID: 35612 RVA: 0x002815C0 File Offset: 0x0027F7C0
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

		// Token: 0x06008B1D RID: 35613 RVA: 0x002815EF File Offset: 0x0027F7EF
		public Span<int> GetDifficultyLevelBytes()
		{
			return this.__p.__vector_as_span<int>(148, 4);
		}

		// Token: 0x06008B1E RID: 35614 RVA: 0x00281602 File Offset: 0x0027F802
		public int[] GetDifficultyLevelArray()
		{
			return this.__p.__vector_as_array<int>(148) ?? Array.Empty<int>();
		}

		// Token: 0x06008B1F RID: 35615 RVA: 0x00281620 File Offset: 0x0027F820
		public string DifficultyDesc(int j)
		{
			int num = this.__p.__offset(150);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001A00 RID: 6656
		// (get) Token: 0x06008B20 RID: 35616 RVA: 0x00281660 File Offset: 0x0027F860
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

		// Token: 0x06008B21 RID: 35617 RVA: 0x00281690 File Offset: 0x0027F890
		public int Drop(int j)
		{
			int num = this.__p.__offset(152);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001A01 RID: 6657
		// (get) Token: 0x06008B22 RID: 35618 RVA: 0x002816D4 File Offset: 0x0027F8D4
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

		// Token: 0x06008B23 RID: 35619 RVA: 0x00281703 File Offset: 0x0027F903
		public Span<int> GetDropBytes()
		{
			return this.__p.__vector_as_span<int>(152, 4);
		}

		// Token: 0x06008B24 RID: 35620 RVA: 0x00281716 File Offset: 0x0027F916
		public int[] GetDropArray()
		{
			return this.__p.__vector_as_array<int>(152) ?? Array.Empty<int>();
		}

		// Token: 0x17001A02 RID: 6658
		// (get) Token: 0x06008B25 RID: 35621 RVA: 0x00281734 File Offset: 0x0027F934
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

		// Token: 0x17001A03 RID: 6659
		// (get) Token: 0x06008B26 RID: 35622 RVA: 0x00281774 File Offset: 0x0027F974
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

		// Token: 0x17001A04 RID: 6660
		// (get) Token: 0x06008B27 RID: 35623 RVA: 0x002817B4 File Offset: 0x0027F9B4
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

		// Token: 0x06008B28 RID: 35624 RVA: 0x002817EF File Offset: 0x0027F9EF
		public Span<byte> GetIconTagPathBytes()
		{
			return this.__p.__vector_as_span<byte>(158, 1);
		}

		// Token: 0x06008B29 RID: 35625 RVA: 0x00281802 File Offset: 0x0027FA02
		public byte[] GetIconTagPathArray()
		{
			return this.__p.__vector_as_array<byte>(158) ?? Array.Empty<byte>();
		}

		// Token: 0x17001A05 RID: 6661
		// (get) Token: 0x06008B2A RID: 35626 RVA: 0x00281820 File Offset: 0x0027FA20
		public bool CanRechallenge
		{
			get
			{
				int num = this.__p.__offset(160);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06008B2B RID: 35627 RVA: 0x00281863 File Offset: 0x0027FA63
		[NullableContext(1)]
		public int[] BornPosition()
		{
			return this.GetBornPositionArray();
		}

		// Token: 0x06008B2C RID: 35628 RVA: 0x0028186B File Offset: 0x0027FA6B
		[NullableContext(1)]
		public IEnumerable<int> BornPositionIter()
		{
			InstanceDungeon.<BornPositionIter>d__255 <BornPositionIter>d__ = new InstanceDungeon.<BornPositionIter>d__255(-2);
			<BornPositionIter>d__.<>3__<>4__this = this;
			return <BornPositionIter>d__;
		}

		// Token: 0x06008B2D RID: 35629 RVA: 0x00281880 File Offset: 0x0027FA80
		[NullableContext(1)]
		public int[] BornRotation()
		{
			return this.GetBornRotationArray();
		}

		// Token: 0x06008B2E RID: 35630 RVA: 0x00281888 File Offset: 0x0027FA88
		[NullableContext(1)]
		public IEnumerable<int> BornRotationIter()
		{
			InstanceDungeon.<BornRotationIter>d__257 <BornRotationIter>d__ = new InstanceDungeon.<BornRotationIter>d__257(-2);
			<BornRotationIter>d__.<>3__<>4__this = this;
			return <BornRotationIter>d__;
		}

		// Token: 0x06008B2F RID: 35631 RVA: 0x0028189D File Offset: 0x0027FA9D
		[NullableContext(1)]
		public int[] CustomTypes()
		{
			return this.GetCustomTypesArray();
		}

		// Token: 0x06008B30 RID: 35632 RVA: 0x002818A5 File Offset: 0x0027FAA5
		[NullableContext(1)]
		public IEnumerable<int> CustomTypesIter()
		{
			InstanceDungeon.<CustomTypesIter>d__259 <CustomTypesIter>d__ = new InstanceDungeon.<CustomTypesIter>d__259(-2);
			<CustomTypesIter>d__.<>3__<>4__this = this;
			return <CustomTypesIter>d__;
		}

		// Token: 0x06008B31 RID: 35633 RVA: 0x002818BA File Offset: 0x0027FABA
		[NullableContext(1)]
		public string[] DifficultyDesc()
		{
			return this.DifficultyDescIter().ToArray<string>();
		}

		// Token: 0x06008B32 RID: 35634 RVA: 0x002818C7 File Offset: 0x0027FAC7
		[NullableContext(1)]
		public IEnumerable<string> DifficultyDescIter()
		{
			InstanceDungeon.<DifficultyDescIter>d__261 <DifficultyDescIter>d__ = new InstanceDungeon.<DifficultyDescIter>d__261(-2);
			<DifficultyDescIter>d__.<>3__<>4__this = this;
			return <DifficultyDescIter>d__;
		}

		// Token: 0x06008B33 RID: 35635 RVA: 0x002818DC File Offset: 0x0027FADC
		[NullableContext(1)]
		public int[] DifficultyLevel()
		{
			return this.GetDifficultyLevelArray();
		}

		// Token: 0x06008B34 RID: 35636 RVA: 0x002818E4 File Offset: 0x0027FAE4
		[NullableContext(1)]
		public IEnumerable<int> DifficultyLevelIter()
		{
			InstanceDungeon.<DifficultyLevelIter>d__263 <DifficultyLevelIter>d__ = new InstanceDungeon.<DifficultyLevelIter>d__263(-2);
			<DifficultyLevelIter>d__.<>3__<>4__this = this;
			return <DifficultyLevelIter>d__;
		}

		// Token: 0x06008B35 RID: 35637 RVA: 0x002818F9 File Offset: 0x0027FAF9
		[NullableContext(1)]
		public int[] Drop()
		{
			return this.GetDropArray();
		}

		// Token: 0x06008B36 RID: 35638 RVA: 0x00281901 File Offset: 0x0027FB01
		[NullableContext(1)]
		public IEnumerable<int> DropIter()
		{
			InstanceDungeon.<DropIter>d__265 <DropIter>d__ = new InstanceDungeon.<DropIter>d__265(-2);
			<DropIter>d__.<>3__<>4__this = this;
			return <DropIter>d__;
		}

		// Token: 0x06008B37 RID: 35639 RVA: 0x00281916 File Offset: 0x0027FB16
		[NullableContext(1)]
		public int[] EnterCondition()
		{
			return this.GetEnterConditionArray();
		}

		// Token: 0x06008B38 RID: 35640 RVA: 0x0028191E File Offset: 0x0027FB1E
		[NullableContext(1)]
		public IEnumerable<int> EnterConditionIter()
		{
			InstanceDungeon.<EnterConditionIter>d__267 <EnterConditionIter>d__ = new InstanceDungeon.<EnterConditionIter>d__267(-2);
			<EnterConditionIter>d__.<>3__<>4__this = this;
			return <EnterConditionIter>d__;
		}

		// Token: 0x06008B39 RID: 35641 RVA: 0x00281933 File Offset: 0x0027FB33
		[NullableContext(1)]
		public int[] EntityLevelIds()
		{
			return this.GetEntityLevelIdsArray();
		}

		// Token: 0x06008B3A RID: 35642 RVA: 0x0028193B File Offset: 0x0027FB3B
		[NullableContext(1)]
		public IEnumerable<int> EntityLevelIdsIter()
		{
			InstanceDungeon.<EntityLevelIdsIter>d__269 <EntityLevelIdsIter>d__ = new InstanceDungeon.<EntityLevelIdsIter>d__269(-2);
			<EntityLevelIdsIter>d__.<>3__<>4__this = this;
			return <EntityLevelIdsIter>d__;
		}

		// Token: 0x06008B3B RID: 35643 RVA: 0x00281950 File Offset: 0x0027FB50
		[NullableContext(1)]
		public DungeonEntrance[] EntranceEntities()
		{
			return this.EntranceEntitiesIter().ToArray<DungeonEntrance>();
		}

		// Token: 0x06008B3C RID: 35644 RVA: 0x0028195D File Offset: 0x0027FB5D
		[NullableContext(1)]
		public IEnumerable<DungeonEntrance> EntranceEntitiesIter()
		{
			InstanceDungeon.<EntranceEntitiesIter>d__271 <EntranceEntitiesIter>d__ = new InstanceDungeon.<EntranceEntitiesIter>d__271(-2);
			<EntranceEntitiesIter>d__.<>3__<>4__this = this;
			return <EntranceEntitiesIter>d__;
		}

		// Token: 0x06008B3D RID: 35645 RVA: 0x00281972 File Offset: 0x0027FB72
		[NullableContext(1)]
		public int[] ExitDungeonConfirmId()
		{
			return this.GetExitDungeonConfirmIdArray();
		}

		// Token: 0x06008B3E RID: 35646 RVA: 0x0028197A File Offset: 0x0027FB7A
		[NullableContext(1)]
		public IEnumerable<int> ExitDungeonConfirmIdIter()
		{
			InstanceDungeon.<ExitDungeonConfirmIdIter>d__273 <ExitDungeonConfirmIdIter>d__ = new InstanceDungeon.<ExitDungeonConfirmIdIter>d__273(-2);
			<ExitDungeonConfirmIdIter>d__.<>3__<>4__this = this;
			return <ExitDungeonConfirmIdIter>d__;
		}

		// Token: 0x06008B3F RID: 35647 RVA: 0x0028198F File Offset: 0x0027FB8F
		[NullableContext(1)]
		public int[] ExitEntities()
		{
			return this.GetExitEntitiesArray();
		}

		// Token: 0x06008B40 RID: 35648 RVA: 0x00281997 File Offset: 0x0027FB97
		[NullableContext(1)]
		public IEnumerable<int> ExitEntitiesIter()
		{
			InstanceDungeon.<ExitEntitiesIter>d__275 <ExitEntitiesIter>d__ = new InstanceDungeon.<ExitEntitiesIter>d__275(-2);
			<ExitEntitiesIter>d__.<>3__<>4__this = this;
			return <ExitEntitiesIter>d__;
		}

		// Token: 0x06008B41 RID: 35649 RVA: 0x002819AC File Offset: 0x0027FBAC
		[NullableContext(1)]
		public int[] FightInfoDtType()
		{
			return this.GetFightInfoDtTypeArray();
		}

		// Token: 0x06008B42 RID: 35650 RVA: 0x002819B4 File Offset: 0x0027FBB4
		[NullableContext(1)]
		public IEnumerable<int> FightInfoDtTypeIter()
		{
			InstanceDungeon.<FightInfoDtTypeIter>d__277 <FightInfoDtTypeIter>d__ = new InstanceDungeon.<FightInfoDtTypeIter>d__277(-2);
			<FightInfoDtTypeIter>d__.<>3__<>4__this = this;
			return <FightInfoDtTypeIter>d__;
		}

		// Token: 0x06008B43 RID: 35651 RVA: 0x002819C9 File Offset: 0x0027FBC9
		[NullableContext(1)]
		public int[] FuncLimit()
		{
			return this.GetFuncLimitArray();
		}

		// Token: 0x06008B44 RID: 35652 RVA: 0x002819D1 File Offset: 0x0027FBD1
		[NullableContext(1)]
		public IEnumerable<int> FuncLimitIter()
		{
			InstanceDungeon.<FuncLimitIter>d__279 <FuncLimitIter>d__ = new InstanceDungeon.<FuncLimitIter>d__279(-2);
			<FuncLimitIter>d__.<>3__<>4__this = this;
			return <FuncLimitIter>d__;
		}

		// Token: 0x06008B45 RID: 35653 RVA: 0x002819E6 File Offset: 0x0027FBE6
		[NullableContext(1)]
		public string[] LimitViewName()
		{
			return this.LimitViewNameIter().ToArray<string>();
		}

		// Token: 0x06008B46 RID: 35654 RVA: 0x002819F3 File Offset: 0x0027FBF3
		[NullableContext(1)]
		public IEnumerable<string> LimitViewNameIter()
		{
			InstanceDungeon.<LimitViewNameIter>d__281 <LimitViewNameIter>d__ = new InstanceDungeon.<LimitViewNameIter>d__281(-2);
			<LimitViewNameIter>d__.<>3__<>4__this = this;
			return <LimitViewNameIter>d__;
		}

		// Token: 0x06008B47 RID: 35655 RVA: 0x00281A08 File Offset: 0x0027FC08
		[NullableContext(1)]
		public int[] MonsterPreview()
		{
			return this.GetMonsterPreviewArray();
		}

		// Token: 0x06008B48 RID: 35656 RVA: 0x00281A10 File Offset: 0x0027FC10
		[NullableContext(1)]
		public IEnumerable<int> MonsterPreviewIter()
		{
			InstanceDungeon.<MonsterPreviewIter>d__283 <MonsterPreviewIter>d__ = new InstanceDungeon.<MonsterPreviewIter>d__283(-2);
			<MonsterPreviewIter>d__.<>3__<>4__this = this;
			return <MonsterPreviewIter>d__;
		}

		// Token: 0x06008B49 RID: 35657 RVA: 0x00281A25 File Offset: 0x0027FC25
		[NullableContext(1)]
		public int[] RecommendElement()
		{
			return this.GetRecommendElementArray();
		}

		// Token: 0x06008B4A RID: 35658 RVA: 0x00281A2D File Offset: 0x0027FC2D
		[NullableContext(1)]
		public IEnumerable<int> RecommendElementIter()
		{
			InstanceDungeon.<RecommendElementIter>d__285 <RecommendElementIter>d__ = new InstanceDungeon.<RecommendElementIter>d__285(-2);
			<RecommendElementIter>d__.<>3__<>4__this = this;
			return <RecommendElementIter>d__;
		}

		// Token: 0x06008B4B RID: 35659 RVA: 0x00281A44 File Offset: 0x0027FC44
		[NullableContext(1)]
		public Dictionary<int, int> RecommendLevel()
		{
			return this.RecommendLevelIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06008B4C RID: 35660 RVA: 0x00281A9A File Offset: 0x0027FC9A
		[NullableContext(1)]
		public IEnumerable<DicIntInt> RecommendLevelIter()
		{
			InstanceDungeon.<RecommendLevelIter>d__287 <RecommendLevelIter>d__ = new InstanceDungeon.<RecommendLevelIter>d__287(-2);
			<RecommendLevelIter>d__.<>3__<>4__this = this;
			return <RecommendLevelIter>d__;
		}

		// Token: 0x06008B4D RID: 35661 RVA: 0x00281AAF File Offset: 0x0027FCAF
		[NullableContext(1)]
		public int[] RecommendRole()
		{
			return this.GetRecommendRoleArray();
		}

		// Token: 0x06008B4E RID: 35662 RVA: 0x00281AB7 File Offset: 0x0027FCB7
		[NullableContext(1)]
		public IEnumerable<int> RecommendRoleIter()
		{
			InstanceDungeon.<RecommendRoleIter>d__289 <RecommendRoleIter>d__ = new InstanceDungeon.<RecommendRoleIter>d__289(-2);
			<RecommendRoleIter>d__.<>3__<>4__this = this;
			return <RecommendRoleIter>d__;
		}

		// Token: 0x06008B4F RID: 35663 RVA: 0x00281ACC File Offset: 0x0027FCCC
		[NullableContext(1)]
		public int[] RecommendRoleBottom()
		{
			return this.GetRecommendRoleBottomArray();
		}

		// Token: 0x06008B50 RID: 35664 RVA: 0x00281AD4 File Offset: 0x0027FCD4
		[NullableContext(1)]
		public IEnumerable<int> RecommendRoleBottomIter()
		{
			InstanceDungeon.<RecommendRoleBottomIter>d__291 <RecommendRoleBottomIter>d__ = new InstanceDungeon.<RecommendRoleBottomIter>d__291(-2);
			<RecommendRoleBottomIter>d__.<>3__<>4__this = this;
			return <RecommendRoleBottomIter>d__;
		}

		// Token: 0x06008B51 RID: 35665 RVA: 0x00281AE9 File Offset: 0x0027FCE9
		[NullableContext(1)]
		public int[] RecoverWorldLocation()
		{
			return this.GetRecoverWorldLocationArray();
		}

		// Token: 0x06008B52 RID: 35666 RVA: 0x00281AF1 File Offset: 0x0027FCF1
		[NullableContext(1)]
		public IEnumerable<int> RecoverWorldLocationIter()
		{
			InstanceDungeon.<RecoverWorldLocationIter>d__293 <RecoverWorldLocationIter>d__ = new InstanceDungeon.<RecoverWorldLocationIter>d__293(-2);
			<RecoverWorldLocationIter>d__.<>3__<>4__this = this;
			return <RecoverWorldLocationIter>d__;
		}

		// Token: 0x06008B53 RID: 35667 RVA: 0x00281B08 File Offset: 0x0027FD08
		[NullableContext(1)]
		public Dictionary<int, int> RenderSettings()
		{
			return this.RenderSettingsIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06008B54 RID: 35668 RVA: 0x00281B5E File Offset: 0x0027FD5E
		[NullableContext(1)]
		public IEnumerable<DicIntInt> RenderSettingsIter()
		{
			InstanceDungeon.<RenderSettingsIter>d__295 <RenderSettingsIter>d__ = new InstanceDungeon.<RenderSettingsIter>d__295(-2);
			<RenderSettingsIter>d__.<>3__<>4__this = this;
			return <RenderSettingsIter>d__;
		}

		// Token: 0x06008B55 RID: 35669 RVA: 0x00281B73 File Offset: 0x0027FD73
		[NullableContext(1)]
		public int[] RoleTypeList()
		{
			return this.GetRoleTypeListArray();
		}

		// Token: 0x06008B56 RID: 35670 RVA: 0x00281B7B File Offset: 0x0027FD7B
		[NullableContext(1)]
		public IEnumerable<int> RoleTypeListIter()
		{
			InstanceDungeon.<RoleTypeListIter>d__297 <RoleTypeListIter>d__ = new InstanceDungeon.<RoleTypeListIter>d__297(-2);
			<RoleTypeListIter>d__.<>3__<>4__this = this;
			return <RoleTypeListIter>d__;
		}

		// Token: 0x06008B57 RID: 35671 RVA: 0x00281B90 File Offset: 0x0027FD90
		[NullableContext(1)]
		public int[] SharedTreasureGroup()
		{
			return this.GetSharedTreasureGroupArray();
		}

		// Token: 0x06008B58 RID: 35672 RVA: 0x00281B98 File Offset: 0x0027FD98
		[NullableContext(1)]
		public IEnumerable<int> SharedTreasureGroupIter()
		{
			InstanceDungeon.<SharedTreasureGroupIter>d__299 <SharedTreasureGroupIter>d__ = new InstanceDungeon.<SharedTreasureGroupIter>d__299(-2);
			<SharedTreasureGroupIter>d__.<>3__<>4__this = this;
			return <SharedTreasureGroupIter>d__;
		}

		// Token: 0x06008B59 RID: 35673 RVA: 0x00281BAD File Offset: 0x0027FDAD
		[NullableContext(1)]
		public string[] SubLevels()
		{
			return this.SubLevelsIter().ToArray<string>();
		}

		// Token: 0x06008B5A RID: 35674 RVA: 0x00281BBA File Offset: 0x0027FDBA
		[NullableContext(1)]
		public IEnumerable<string> SubLevelsIter()
		{
			InstanceDungeon.<SubLevelsIter>d__301 <SubLevelsIter>d__ = new InstanceDungeon.<SubLevelsIter>d__301(-2);
			<SubLevelsIter>d__.<>3__<>4__this = this;
			return <SubLevelsIter>d__;
		}

		// Token: 0x06008B5B RID: 35675 RVA: 0x00281BCF File Offset: 0x0027FDCF
		[NullableContext(1)]
		public int[] SubPackageIdList()
		{
			return this.GetSubPackageIdListArray();
		}

		// Token: 0x06008B5C RID: 35676 RVA: 0x00281BD7 File Offset: 0x0027FDD7
		[NullableContext(1)]
		public IEnumerable<int> SubPackageIdListIter()
		{
			InstanceDungeon.<SubPackageIdListIter>d__303 <SubPackageIdListIter>d__ = new InstanceDungeon.<SubPackageIdListIter>d__303(-2);
			<SubPackageIdListIter>d__.<>3__<>4__this = this;
			return <SubPackageIdListIter>d__;
		}

		// Token: 0x06008B5D RID: 35677 RVA: 0x00281BEC File Offset: 0x0027FDEC
		[NullableContext(1)]
		public Dictionary<int, string> SubTitle()
		{
			return this.SubTitleIter().ToDictionary((DicIntString element) => element.Key, (DicIntString element) => element.Value);
		}

		// Token: 0x06008B5E RID: 35678 RVA: 0x00281C42 File Offset: 0x0027FE42
		[NullableContext(1)]
		public IEnumerable<DicIntString> SubTitleIter()
		{
			InstanceDungeon.<SubTitleIter>d__305 <SubTitleIter>d__ = new InstanceDungeon.<SubTitleIter>d__305(-2);
			<SubTitleIter>d__.<>3__<>4__this = this;
			return <SubTitleIter>d__;
		}

		// Token: 0x06008B5F RID: 35679 RVA: 0x00281C57 File Offset: 0x0027FE57
		[NullableContext(1)]
		public int[] TreasureChestStatTypes()
		{
			return this.GetTreasureChestStatTypesArray();
		}

		// Token: 0x06008B60 RID: 35680 RVA: 0x00281C5F File Offset: 0x0027FE5F
		[NullableContext(1)]
		public IEnumerable<int> TreasureChestStatTypesIter()
		{
			InstanceDungeon.<TreasureChestStatTypesIter>d__307 <TreasureChestStatTypesIter>d__ = new InstanceDungeon.<TreasureChestStatTypesIter>d__307(-2);
			<TreasureChestStatTypesIter>d__.<>3__<>4__this = this;
			return <TreasureChestStatTypesIter>d__;
		}

		// Token: 0x06008B61 RID: 35681 RVA: 0x00281C74 File Offset: 0x0027FE74
		[NullableContext(1)]
		public int[] TrialRoleInfo()
		{
			return this.GetTrialRoleInfoArray();
		}

		// Token: 0x06008B62 RID: 35682 RVA: 0x00281C7C File Offset: 0x0027FE7C
		[NullableContext(1)]
		public IEnumerable<int> TrialRoleInfoIter()
		{
			InstanceDungeon.<TrialRoleInfoIter>d__309 <TrialRoleInfoIter>d__ = new InstanceDungeon.<TrialRoleInfoIter>d__309(-2);
			<TrialRoleInfoIter>d__.<>3__<>4__this = this;
			return <TrialRoleInfoIter>d__;
		}

		// Token: 0x06008B63 RID: 35683 RVA: 0x00281C94 File Offset: 0x0027FE94
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

		// Token: 0x06008B64 RID: 35684 RVA: 0x00281CC8 File Offset: 0x0027FEC8
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

		// Token: 0x06008B65 RID: 35685 RVA: 0x00281CFC File Offset: 0x0027FEFC
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

		// Token: 0x06008B66 RID: 35686 RVA: 0x00281D24 File Offset: 0x0027FF24
		private void EnsureRecommendLevelCacheIfNeeded()
		{
			if (this.RecommendLevelCache != null)
			{
				return;
			}
			this.RecommendLevelCache = this.RecommendLevelIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06008B67 RID: 35687 RVA: 0x00281D8C File Offset: 0x0027FF8C
		private void EnsureRenderSettingsCacheIfNeeded()
		{
			if (this.RenderSettingsCache != null)
			{
				return;
			}
			this.RenderSettingsCache = this.RenderSettingsIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06008B68 RID: 35688 RVA: 0x00281DF4 File Offset: 0x0027FFF4
		private void EnsureSubTitleCacheIfNeeded()
		{
			if (this.SubTitleCache != null)
			{
				return;
			}
			this.SubTitleCache = this.SubTitleIter().ToFrozenDictionary((DicIntString kvp) => kvp.Key, (DicIntString kvp) => kvp.Value, null);
		}

		// Token: 0x06008B69 RID: 35689 RVA: 0x00281E5A File Offset: 0x0028005A
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetRecommendLevelFrozenDict()
		{
			this.EnsureRecommendLevelCacheIfNeeded();
			return this.RecommendLevelCache;
		}

		// Token: 0x06008B6A RID: 35690 RVA: 0x00281E68 File Offset: 0x00280068
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetRenderSettingsFrozenDict()
		{
			this.EnsureRenderSettingsCacheIfNeeded();
			return this.RenderSettingsCache;
		}

		// Token: 0x06008B6B RID: 35691 RVA: 0x00281E76 File Offset: 0x00280076
		[NullableContext(1)]
		public FrozenDictionary<int, string> GetSubTitleFrozenDict()
		{
			this.EnsureSubTitleCacheIfNeeded();
			return this.SubTitleCache;
		}

		// Token: 0x040053D9 RID: 21465
		private Table __p;

		// Token: 0x040053DA RID: 21466
		[Nullable(2)]
		private FrozenDictionary<int, int> RecommendLevelCache;

		// Token: 0x040053DB RID: 21467
		[Nullable(2)]
		private FrozenDictionary<int, int> RenderSettingsCache;

		// Token: 0x040053DC RID: 21468
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<int, string> SubTitleCache;
	}
}

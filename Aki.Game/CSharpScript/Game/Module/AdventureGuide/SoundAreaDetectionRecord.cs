using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.AdventureGuide
{
	// Token: 0x02005EBE RID: 24254
	[NullableContext(1)]
	[Nullable(0)]
	public class SoundAreaDetectionRecord
	{
		// Token: 0x0603DAFF RID: 252671 RVA: 0x00EE523E File Offset: 0x00EE343E
		[NullableContext(2)]
		public SoundAreaDetectionRecord(ESoundAreaDataType type, DungeonDetectionRecord dungeonDetectionRecord = null, SilentAreaDetectionRecord silentAreaDetectionRecord = null)
		{
			this.Type = new ESoundAreaDataType?(type);
			this.DungeonDetectionRecord = dungeonDetectionRecord;
			this.SilentAreaDetectionRecord = silentAreaDetectionRecord;
		}

		// Token: 0x17008EBA RID: 36538
		// (get) Token: 0x0603DB00 RID: 252672 RVA: 0x00EE5260 File Offset: 0x00EE3460
		[Nullable(0)]
		public OneOf<DungeonDetection, SilentAreaDetection>? Conf
		{
			[NullableContext(0)]
			get
			{
				ESoundAreaDataType? type = this.Type;
				if (type != null)
				{
					ESoundAreaDataType valueOrDefault = type.GetValueOrDefault();
					if (valueOrDefault != ESoundAreaDataType.Dungeon)
					{
						if (valueOrDefault == ESoundAreaDataType.SilentArea)
						{
							SilentAreaDetectionRecord silentAreaDetectionRecord = this.SilentAreaDetectionRecord;
							SilentAreaDetection? silentAreaDetection = (silentAreaDetectionRecord != null) ? new SilentAreaDetection?(silentAreaDetectionRecord.Conf) : null;
							if (silentAreaDetection == null)
							{
								return null;
							}
							return new OneOf<DungeonDetection, SilentAreaDetection>?(silentAreaDetection.GetValueOrDefault());
						}
					}
					else
					{
						DungeonDetectionRecord dungeonDetectionRecord = this.DungeonDetectionRecord;
						DungeonDetection? dungeonDetection = (dungeonDetectionRecord != null) ? new DungeonDetection?(dungeonDetectionRecord.Conf) : null;
						if (dungeonDetection == null)
						{
							return null;
						}
						return new OneOf<DungeonDetection, SilentAreaDetection>?(dungeonDetection.GetValueOrDefault());
					}
				}
				return null;
			}
		}

		// Token: 0x17008EBB RID: 36539
		// (get) Token: 0x0603DB01 RID: 252673 RVA: 0x00EE532C File Offset: 0x00EE352C
		public string Name
		{
			get
			{
				ESoundAreaDataType? type = this.Type;
				if (type != null)
				{
					ESoundAreaDataType valueOrDefault = type.GetValueOrDefault();
					if (valueOrDefault == ESoundAreaDataType.Dungeon)
					{
						DungeonDetectionRecord dungeonDetectionRecord = this.DungeonDetectionRecord;
						return ((dungeonDetectionRecord != null) ? dungeonDetectionRecord.Conf.Name : null) ?? "";
					}
					if (valueOrDefault == ESoundAreaDataType.SilentArea)
					{
						SilentAreaDetectionRecord silentAreaDetectionRecord = this.SilentAreaDetectionRecord;
						return ((silentAreaDetectionRecord != null) ? silentAreaDetectionRecord.Conf.Name : null) ?? "";
					}
				}
				return "";
			}
		}

		// Token: 0x17008EBC RID: 36540
		// (get) Token: 0x0603DB02 RID: 252674 RVA: 0x00EE53A8 File Offset: 0x00EE35A8
		public string BigIcon
		{
			get
			{
				ESoundAreaDataType? type = this.Type;
				if (type != null)
				{
					ESoundAreaDataType valueOrDefault = type.GetValueOrDefault();
					if (valueOrDefault == ESoundAreaDataType.Dungeon)
					{
						DungeonDetectionRecord dungeonDetectionRecord = this.DungeonDetectionRecord;
						return ((dungeonDetectionRecord != null) ? dungeonDetectionRecord.Conf.BigIcon : null) ?? "";
					}
					if (valueOrDefault == ESoundAreaDataType.SilentArea)
					{
						SilentAreaDetectionRecord silentAreaDetectionRecord = this.SilentAreaDetectionRecord;
						return ((silentAreaDetectionRecord != null) ? silentAreaDetectionRecord.Conf.BigIcon : null) ?? "";
					}
				}
				return "";
			}
		}

		// Token: 0x17008EBD RID: 36541
		// (get) Token: 0x0603DB03 RID: 252675 RVA: 0x00EE5424 File Offset: 0x00EE3624
		public string LockBigIcon
		{
			get
			{
				ESoundAreaDataType? type = this.Type;
				if (type != null)
				{
					ESoundAreaDataType valueOrDefault = type.GetValueOrDefault();
					if (valueOrDefault == ESoundAreaDataType.Dungeon)
					{
						DungeonDetectionRecord dungeonDetectionRecord = this.DungeonDetectionRecord;
						return ((dungeonDetectionRecord != null) ? dungeonDetectionRecord.Conf.LockBigIcon : null) ?? "";
					}
					if (valueOrDefault == ESoundAreaDataType.SilentArea)
					{
						SilentAreaDetectionRecord silentAreaDetectionRecord = this.SilentAreaDetectionRecord;
						return ((silentAreaDetectionRecord != null) ? silentAreaDetectionRecord.Conf.LockBigIcon : null) ?? "";
					}
				}
				return "";
			}
		}

		// Token: 0x17008EBE RID: 36542
		// (get) Token: 0x0603DB04 RID: 252676 RVA: 0x00EE54A0 File Offset: 0x00EE36A0
		public string AttributesDescriptionUnlock
		{
			get
			{
				ESoundAreaDataType? type = this.Type;
				if (type != null)
				{
					ESoundAreaDataType valueOrDefault = type.GetValueOrDefault();
					if (valueOrDefault == ESoundAreaDataType.Dungeon)
					{
						DungeonDetectionRecord dungeonDetectionRecord = this.DungeonDetectionRecord;
						return ((dungeonDetectionRecord != null) ? dungeonDetectionRecord.Conf.AttributesDescriptionUnlock : null) ?? "";
					}
					if (valueOrDefault == ESoundAreaDataType.SilentArea)
					{
						SilentAreaDetectionRecord silentAreaDetectionRecord = this.SilentAreaDetectionRecord;
						return ((silentAreaDetectionRecord != null) ? silentAreaDetectionRecord.Conf.AttributesDescriptionUnlock : null) ?? "";
					}
				}
				return "";
			}
		}

		// Token: 0x17008EBF RID: 36543
		// (get) Token: 0x0603DB05 RID: 252677 RVA: 0x00EE551C File Offset: 0x00EE371C
		public string InstanceSubTypeDescription
		{
			get
			{
				ESoundAreaDataType? type = this.Type;
				if (type != null)
				{
					ESoundAreaDataType valueOrDefault = type.GetValueOrDefault();
					if (valueOrDefault == ESoundAreaDataType.Dungeon)
					{
						DungeonDetectionRecord dungeonDetectionRecord = this.DungeonDetectionRecord;
						return ((dungeonDetectionRecord != null) ? dungeonDetectionRecord.Conf.InstanceSubTypeDescription : null) ?? "";
					}
					if (valueOrDefault == ESoundAreaDataType.SilentArea)
					{
						SilentAreaDetectionRecord silentAreaDetectionRecord = this.SilentAreaDetectionRecord;
						return ((silentAreaDetectionRecord != null) ? silentAreaDetectionRecord.Conf.InstanceSubTypeDescription : null) ?? "";
					}
				}
				return "";
			}
		}

		// Token: 0x17008EC0 RID: 36544
		// (get) Token: 0x0603DB06 RID: 252678 RVA: 0x00EE5598 File Offset: 0x00EE3798
		public string LeftBgSprite
		{
			get
			{
				ESoundAreaDataType? type = this.Type;
				if (type != null)
				{
					ESoundAreaDataType valueOrDefault = type.GetValueOrDefault();
					if (valueOrDefault == ESoundAreaDataType.Dungeon)
					{
						DungeonDetectionRecord dungeonDetectionRecord = this.DungeonDetectionRecord;
						return ((dungeonDetectionRecord != null) ? dungeonDetectionRecord.Conf.LeftBgSprite : null) ?? "";
					}
					if (valueOrDefault == ESoundAreaDataType.SilentArea)
					{
						SilentAreaDetectionRecord silentAreaDetectionRecord = this.SilentAreaDetectionRecord;
						return ((silentAreaDetectionRecord != null) ? silentAreaDetectionRecord.Conf.LeftBgSprite : null) ?? "";
					}
				}
				return "";
			}
		}

		// Token: 0x17008EC1 RID: 36545
		// (get) Token: 0x0603DB07 RID: 252679 RVA: 0x00EE5614 File Offset: 0x00EE3814
		public string RightBgSprite
		{
			get
			{
				ESoundAreaDataType? type = this.Type;
				if (type != null)
				{
					ESoundAreaDataType valueOrDefault = type.GetValueOrDefault();
					if (valueOrDefault == ESoundAreaDataType.Dungeon)
					{
						DungeonDetectionRecord dungeonDetectionRecord = this.DungeonDetectionRecord;
						return ((dungeonDetectionRecord != null) ? dungeonDetectionRecord.Conf.RightBgSprite : null) ?? "";
					}
					if (valueOrDefault == ESoundAreaDataType.SilentArea)
					{
						SilentAreaDetectionRecord silentAreaDetectionRecord = this.SilentAreaDetectionRecord;
						return ((silentAreaDetectionRecord != null) ? silentAreaDetectionRecord.Conf.RightBgSprite : null) ?? "";
					}
				}
				return "";
			}
		}

		// Token: 0x17008EC2 RID: 36546
		// (get) Token: 0x0603DB08 RID: 252680 RVA: 0x00EE5690 File Offset: 0x00EE3890
		public string LeftBgTexture
		{
			get
			{
				ESoundAreaDataType? type = this.Type;
				if (type != null)
				{
					ESoundAreaDataType valueOrDefault = type.GetValueOrDefault();
					if (valueOrDefault == ESoundAreaDataType.Dungeon)
					{
						DungeonDetectionRecord dungeonDetectionRecord = this.DungeonDetectionRecord;
						return ((dungeonDetectionRecord != null) ? dungeonDetectionRecord.Conf.LeftBgTexture : null) ?? "";
					}
					if (valueOrDefault == ESoundAreaDataType.SilentArea)
					{
						SilentAreaDetectionRecord silentAreaDetectionRecord = this.SilentAreaDetectionRecord;
						return ((silentAreaDetectionRecord != null) ? silentAreaDetectionRecord.Conf.LeftBgTexture : null) ?? "";
					}
				}
				return "";
			}
		}

		// Token: 0x17008EC3 RID: 36547
		// (get) Token: 0x0603DB09 RID: 252681 RVA: 0x00EE570C File Offset: 0x00EE390C
		public int DetectionTitlePanel
		{
			get
			{
				ESoundAreaDataType? type = this.Type;
				if (type != null)
				{
					ESoundAreaDataType valueOrDefault = type.GetValueOrDefault();
					if (valueOrDefault != ESoundAreaDataType.Dungeon)
					{
						if (valueOrDefault == ESoundAreaDataType.SilentArea)
						{
							SilentAreaDetectionRecord silentAreaDetectionRecord = this.SilentAreaDetectionRecord;
							if (silentAreaDetectionRecord == null)
							{
								return 0;
							}
							return silentAreaDetectionRecord.Conf.DetectionTitlePanel;
						}
					}
					else
					{
						DungeonDetectionRecord dungeonDetectionRecord = this.DungeonDetectionRecord;
						if (dungeonDetectionRecord == null)
						{
							return 0;
						}
						return dungeonDetectionRecord.Conf.DetectionTitlePanel;
					}
				}
				return 0;
			}
		}

		// Token: 0x17008EC4 RID: 36548
		// (get) Token: 0x0603DB0A RID: 252682 RVA: 0x00EE5770 File Offset: 0x00EE3970
		public int[] PhantomId
		{
			get
			{
				ESoundAreaDataType? type = this.Type;
				if (type != null)
				{
					ESoundAreaDataType valueOrDefault = type.GetValueOrDefault();
					if (valueOrDefault == ESoundAreaDataType.Dungeon)
					{
						DungeonDetectionRecord dungeonDetectionRecord = this.DungeonDetectionRecord;
						return ((dungeonDetectionRecord != null) ? dungeonDetectionRecord.Conf.PhantomId() : null) ?? Array.Empty<int>();
					}
					if (valueOrDefault == ESoundAreaDataType.SilentArea)
					{
						SilentAreaDetectionRecord silentAreaDetectionRecord = this.SilentAreaDetectionRecord;
						return ((silentAreaDetectionRecord != null) ? silentAreaDetectionRecord.Conf.PhantomId() : null) ?? Array.Empty<int>();
					}
				}
				return Array.Empty<int>();
			}
		}

		// Token: 0x17008EC5 RID: 36549
		// (get) Token: 0x0603DB0B RID: 252683 RVA: 0x00EE57EC File Offset: 0x00EE39EC
		public int LockCon
		{
			get
			{
				ESoundAreaDataType? type = this.Type;
				if (type != null)
				{
					ESoundAreaDataType valueOrDefault = type.GetValueOrDefault();
					if (valueOrDefault != ESoundAreaDataType.Dungeon)
					{
						if (valueOrDefault == ESoundAreaDataType.SilentArea)
						{
							SilentAreaDetectionRecord silentAreaDetectionRecord = this.SilentAreaDetectionRecord;
							if (silentAreaDetectionRecord == null)
							{
								return 0;
							}
							return silentAreaDetectionRecord.Conf.LockCon;
						}
					}
					else
					{
						DungeonDetectionRecord dungeonDetectionRecord = this.DungeonDetectionRecord;
						if (dungeonDetectionRecord == null)
						{
							return 0;
						}
						return dungeonDetectionRecord.Conf.LockCon;
					}
				}
				return 0;
			}
		}

		// Token: 0x17008EC6 RID: 36550
		// (get) Token: 0x0603DB0C RID: 252684 RVA: 0x00EE5850 File Offset: 0x00EE3A50
		public int PeriodicityChallengeType
		{
			get
			{
				ESoundAreaDataType? type = this.Type;
				if (type != null)
				{
					ESoundAreaDataType valueOrDefault = type.GetValueOrDefault();
					if (valueOrDefault != ESoundAreaDataType.Dungeon)
					{
						if (valueOrDefault == ESoundAreaDataType.SilentArea)
						{
							SilentAreaDetectionRecord silentAreaDetectionRecord = this.SilentAreaDetectionRecord;
							if (silentAreaDetectionRecord == null)
							{
								return 0;
							}
							return silentAreaDetectionRecord.Conf.PeriodicityChallengeType;
						}
					}
					else
					{
						DungeonDetectionRecord dungeonDetectionRecord = this.DungeonDetectionRecord;
						if (dungeonDetectionRecord == null)
						{
							return 0;
						}
						return dungeonDetectionRecord.Conf.PeriodicityChallengeType;
					}
				}
				return 0;
			}
		}

		// Token: 0x17008EC7 RID: 36551
		// (get) Token: 0x0603DB0D RID: 252685 RVA: 0x00EE58B4 File Offset: 0x00EE3AB4
		public int Secondary
		{
			get
			{
				ESoundAreaDataType? type = this.Type;
				if (type != null)
				{
					ESoundAreaDataType valueOrDefault = type.GetValueOrDefault();
					if (valueOrDefault != ESoundAreaDataType.Dungeon)
					{
						if (valueOrDefault == ESoundAreaDataType.SilentArea)
						{
							SilentAreaDetectionRecord silentAreaDetectionRecord = this.SilentAreaDetectionRecord;
							if (silentAreaDetectionRecord == null)
							{
								return 0;
							}
							return silentAreaDetectionRecord.Conf.Secondary;
						}
					}
					else
					{
						DungeonDetectionRecord dungeonDetectionRecord = this.DungeonDetectionRecord;
						if (dungeonDetectionRecord == null)
						{
							return 0;
						}
						return dungeonDetectionRecord.Conf.Secondary;
					}
				}
				return 0;
			}
		}

		// Token: 0x17008EC8 RID: 36552
		// (get) Token: 0x0603DB0E RID: 252686 RVA: 0x00EE5918 File Offset: 0x00EE3B18
		public bool? IsLock
		{
			get
			{
				ESoundAreaDataType? type = this.Type;
				if (type != null)
				{
					ESoundAreaDataType valueOrDefault = type.GetValueOrDefault();
					if (valueOrDefault != ESoundAreaDataType.Dungeon)
					{
						if (valueOrDefault == ESoundAreaDataType.SilentArea)
						{
							SilentAreaDetectionRecord silentAreaDetectionRecord = this.SilentAreaDetectionRecord;
							if (silentAreaDetectionRecord == null)
							{
								return null;
							}
							return new bool?(silentAreaDetectionRecord.IsLock);
						}
					}
					else
					{
						DungeonDetectionRecord dungeonDetectionRecord = this.DungeonDetectionRecord;
						if (dungeonDetectionRecord == null)
						{
							return null;
						}
						return new bool?(dungeonDetectionRecord.IsLock);
					}
				}
				return new bool?(false);
			}
		}

		// Token: 0x17008EC9 RID: 36553
		// (get) Token: 0x0603DB0F RID: 252687 RVA: 0x00EE598C File Offset: 0x00EE3B8C
		public int Id
		{
			get
			{
				ESoundAreaDataType? type = this.Type;
				if (type != null)
				{
					ESoundAreaDataType valueOrDefault = type.GetValueOrDefault();
					if (valueOrDefault != ESoundAreaDataType.Dungeon)
					{
						if (valueOrDefault == ESoundAreaDataType.SilentArea)
						{
							SilentAreaDetectionRecord silentAreaDetectionRecord = this.SilentAreaDetectionRecord;
							if (silentAreaDetectionRecord == null)
							{
								return 0;
							}
							return silentAreaDetectionRecord.Conf.Id;
						}
					}
					else
					{
						DungeonDetectionRecord dungeonDetectionRecord = this.DungeonDetectionRecord;
						if (dungeonDetectionRecord == null)
						{
							return 0;
						}
						return dungeonDetectionRecord.Conf.Id;
					}
				}
				return 0;
			}
		}

		// Token: 0x17008ECA RID: 36554
		// (get) Token: 0x0603DB10 RID: 252688 RVA: 0x00EE59F0 File Offset: 0x00EE3BF0
		public int PreOpenId
		{
			get
			{
				ESoundAreaDataType? type = this.Type;
				if (type != null)
				{
					ESoundAreaDataType valueOrDefault = type.GetValueOrDefault();
					if (valueOrDefault != ESoundAreaDataType.Dungeon)
					{
						if (valueOrDefault == ESoundAreaDataType.SilentArea)
						{
							SilentAreaDetectionRecord silentAreaDetectionRecord = this.SilentAreaDetectionRecord;
							if (silentAreaDetectionRecord == null)
							{
								return 0;
							}
							return silentAreaDetectionRecord.Conf.PreOpenId;
						}
					}
					else
					{
						DungeonDetectionRecord dungeonDetectionRecord = this.DungeonDetectionRecord;
						if (dungeonDetectionRecord == null)
						{
							return 0;
						}
						return dungeonDetectionRecord.Conf.PreOpenId;
					}
				}
				return 0;
			}
		}

		// Token: 0x17008ECB RID: 36555
		// (get) Token: 0x0603DB11 RID: 252689 RVA: 0x00EE5A54 File Offset: 0x00EE3C54
		public int SortId
		{
			get
			{
				ESoundAreaDataType? type = this.Type;
				if (type != null)
				{
					ESoundAreaDataType valueOrDefault = type.GetValueOrDefault();
					if (valueOrDefault != ESoundAreaDataType.Dungeon)
					{
						if (valueOrDefault == ESoundAreaDataType.SilentArea)
						{
							SilentAreaDetectionRecord silentAreaDetectionRecord = this.SilentAreaDetectionRecord;
							if (silentAreaDetectionRecord == null)
							{
								return 0;
							}
							return silentAreaDetectionRecord.Conf.SortId;
						}
					}
					else
					{
						DungeonDetectionRecord dungeonDetectionRecord = this.DungeonDetectionRecord;
						if (dungeonDetectionRecord == null)
						{
							return 0;
						}
						return dungeonDetectionRecord.Conf.SortId;
					}
				}
				return 0;
			}
		}

		// Token: 0x17008ECC RID: 36556
		// (get) Token: 0x0603DB12 RID: 252690 RVA: 0x00EE5AB8 File Offset: 0x00EE3CB8
		public Dictionary<int, int> ShowRewardMap
		{
			get
			{
				ESoundAreaDataType? type = this.Type;
				if (type != null)
				{
					ESoundAreaDataType valueOrDefault = type.GetValueOrDefault();
					if (valueOrDefault == ESoundAreaDataType.Dungeon)
					{
						DungeonDetectionRecord dungeonDetectionRecord = this.DungeonDetectionRecord;
						return ((dungeonDetectionRecord != null) ? dungeonDetectionRecord.Conf.ShowRewardMap() : null) ?? new Dictionary<int, int>();
					}
					if (valueOrDefault == ESoundAreaDataType.SilentArea)
					{
						SilentAreaDetectionRecord silentAreaDetectionRecord = this.SilentAreaDetectionRecord;
						return ((silentAreaDetectionRecord != null) ? silentAreaDetectionRecord.Conf.ShowRewardMap() : null) ?? new Dictionary<int, int>();
					}
				}
				return new Dictionary<int, int>();
			}
		}

		// Token: 0x17008ECD RID: 36557
		// (get) Token: 0x0603DB13 RID: 252691 RVA: 0x00EE5B34 File Offset: 0x00EE3D34
		public Dictionary<int, int> ShowRewardMapCalabash
		{
			get
			{
				ESoundAreaDataType? type = this.Type;
				if (type != null)
				{
					ESoundAreaDataType valueOrDefault = type.GetValueOrDefault();
					if (valueOrDefault == ESoundAreaDataType.Dungeon)
					{
						DungeonDetectionRecord dungeonDetectionRecord = this.DungeonDetectionRecord;
						return ((dungeonDetectionRecord != null) ? dungeonDetectionRecord.Conf.ShowRewardMapCalabash() : null) ?? new Dictionary<int, int>();
					}
					if (valueOrDefault == ESoundAreaDataType.SilentArea)
					{
						SilentAreaDetectionRecord silentAreaDetectionRecord = this.SilentAreaDetectionRecord;
						return ((silentAreaDetectionRecord != null) ? silentAreaDetectionRecord.Conf.ShowRewardMapCalabash() : null) ?? new Dictionary<int, int>();
					}
				}
				return new Dictionary<int, int>();
			}
		}

		// Token: 0x17008ECE RID: 36558
		// (get) Token: 0x0603DB14 RID: 252692 RVA: 0x00EE5BB0 File Offset: 0x00EE3DB0
		public int[] PhantomFetterGroup
		{
			get
			{
				ESoundAreaDataType? type = this.Type;
				if (type != null)
				{
					ESoundAreaDataType valueOrDefault = type.GetValueOrDefault();
					if (valueOrDefault == ESoundAreaDataType.Dungeon)
					{
						DungeonDetectionRecord dungeonDetectionRecord = this.DungeonDetectionRecord;
						return ((dungeonDetectionRecord != null) ? dungeonDetectionRecord.Conf.PhantomFetterGroup() : null) ?? Array.Empty<int>();
					}
					if (valueOrDefault == ESoundAreaDataType.SilentArea)
					{
						SilentAreaDetectionRecord silentAreaDetectionRecord = this.SilentAreaDetectionRecord;
						return ((silentAreaDetectionRecord != null) ? silentAreaDetectionRecord.Conf.PhantomFetterGroup() : null) ?? Array.Empty<int>();
					}
				}
				return Array.Empty<int>();
			}
		}

		// Token: 0x17008ECF RID: 36559
		// (get) Token: 0x0603DB15 RID: 252693 RVA: 0x00EE5C2C File Offset: 0x00EE3E2C
		public int[] WeaponFetterGroup
		{
			get
			{
				ESoundAreaDataType? type = this.Type;
				if (type != null)
				{
					ESoundAreaDataType valueOrDefault = type.GetValueOrDefault();
					if (valueOrDefault == ESoundAreaDataType.Dungeon)
					{
						DungeonDetectionRecord dungeonDetectionRecord = this.DungeonDetectionRecord;
						return ((dungeonDetectionRecord != null) ? dungeonDetectionRecord.Conf.WeaponFetterGroup() : null) ?? Array.Empty<int>();
					}
					if (valueOrDefault == ESoundAreaDataType.SilentArea)
					{
						SilentAreaDetectionRecord silentAreaDetectionRecord = this.SilentAreaDetectionRecord;
						return ((silentAreaDetectionRecord != null) ? silentAreaDetectionRecord.Conf.WeaponFetterGroup() : null) ?? Array.Empty<int>();
					}
				}
				return Array.Empty<int>();
			}
		}

		// Token: 0x0603DB16 RID: 252694 RVA: 0x00EE5CA7 File Offset: 0x00EE3EA7
		public int GetTargetTowerDifficulty()
		{
			return AdventureDefine.periodicityChallengeTypeToTarget[(EPeriodicityChallengeType)this.PeriodicityChallengeType];
		}

		// Token: 0x0603DB17 RID: 252695 RVA: 0x00EE5CBC File Offset: 0x00EE3EBC
		public bool GetTargetTowerIsUnlock()
		{
			int targetTowerDifficulty = this.GetTargetTowerDifficulty();
			return targetTowerDifficulty > 0 && (targetTowerDifficulty - 1 <= 0 || TowerModel.Instance.GetDifficultyIsClear(targetTowerDifficulty - 1));
		}

		// Token: 0x0402031F RID: 131871
		public ESoundAreaDataType? Type;

		// Token: 0x04020320 RID: 131872
		[Nullable(2)]
		public DungeonDetectionRecord DungeonDetectionRecord;

		// Token: 0x04020321 RID: 131873
		[Nullable(2)]
		public SilentAreaDetectionRecord SilentAreaDetectionRecord;
	}
}

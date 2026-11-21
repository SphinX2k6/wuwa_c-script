using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.AdventureGuide
{
	// Token: 0x02004EA3 RID: 20131
	[NullableContext(1)]
	[Nullable(0)]
	public class SoundAreaDetectionRecord
	{
		// Token: 0x06032A8F RID: 207503 RVA: 0x00E3678A File Offset: 0x00E3498A
		[NullableContext(2)]
		public SoundAreaDetectionRecord(ESoundAreaDataType type, DungeonDetectionRecord dungeonDetectionRecord = null, SilentAreaDetectionRecord silentAreaDetectionRecord = null)
		{
			this.Type = new ESoundAreaDataType?(type);
			this.DungeonDetectionRecord = dungeonDetectionRecord;
			this.SilentAreaDetectionRecord = silentAreaDetectionRecord;
		}

		// Token: 0x1700628C RID: 25228
		// (get) Token: 0x06032A90 RID: 207504 RVA: 0x00E367AC File Offset: 0x00E349AC
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

		// Token: 0x1700628D RID: 25229
		// (get) Token: 0x06032A91 RID: 207505 RVA: 0x00E36878 File Offset: 0x00E34A78
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

		// Token: 0x1700628E RID: 25230
		// (get) Token: 0x06032A92 RID: 207506 RVA: 0x00E368F4 File Offset: 0x00E34AF4
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

		// Token: 0x1700628F RID: 25231
		// (get) Token: 0x06032A93 RID: 207507 RVA: 0x00E36970 File Offset: 0x00E34B70
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

		// Token: 0x17006290 RID: 25232
		// (get) Token: 0x06032A94 RID: 207508 RVA: 0x00E369EC File Offset: 0x00E34BEC
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

		// Token: 0x17006291 RID: 25233
		// (get) Token: 0x06032A95 RID: 207509 RVA: 0x00E36A68 File Offset: 0x00E34C68
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

		// Token: 0x17006292 RID: 25234
		// (get) Token: 0x06032A96 RID: 207510 RVA: 0x00E36AE4 File Offset: 0x00E34CE4
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

		// Token: 0x17006293 RID: 25235
		// (get) Token: 0x06032A97 RID: 207511 RVA: 0x00E36B60 File Offset: 0x00E34D60
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

		// Token: 0x17006294 RID: 25236
		// (get) Token: 0x06032A98 RID: 207512 RVA: 0x00E36BDC File Offset: 0x00E34DDC
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

		// Token: 0x17006295 RID: 25237
		// (get) Token: 0x06032A99 RID: 207513 RVA: 0x00E36C58 File Offset: 0x00E34E58
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

		// Token: 0x17006296 RID: 25238
		// (get) Token: 0x06032A9A RID: 207514 RVA: 0x00E36CBC File Offset: 0x00E34EBC
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

		// Token: 0x17006297 RID: 25239
		// (get) Token: 0x06032A9B RID: 207515 RVA: 0x00E36D38 File Offset: 0x00E34F38
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

		// Token: 0x17006298 RID: 25240
		// (get) Token: 0x06032A9C RID: 207516 RVA: 0x00E36D9C File Offset: 0x00E34F9C
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

		// Token: 0x17006299 RID: 25241
		// (get) Token: 0x06032A9D RID: 207517 RVA: 0x00E36E00 File Offset: 0x00E35000
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

		// Token: 0x1700629A RID: 25242
		// (get) Token: 0x06032A9E RID: 207518 RVA: 0x00E36E64 File Offset: 0x00E35064
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

		// Token: 0x1700629B RID: 25243
		// (get) Token: 0x06032A9F RID: 207519 RVA: 0x00E36ED8 File Offset: 0x00E350D8
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

		// Token: 0x1700629C RID: 25244
		// (get) Token: 0x06032AA0 RID: 207520 RVA: 0x00E36F3C File Offset: 0x00E3513C
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

		// Token: 0x1700629D RID: 25245
		// (get) Token: 0x06032AA1 RID: 207521 RVA: 0x00E36FA0 File Offset: 0x00E351A0
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

		// Token: 0x1700629E RID: 25246
		// (get) Token: 0x06032AA2 RID: 207522 RVA: 0x00E37004 File Offset: 0x00E35204
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

		// Token: 0x1700629F RID: 25247
		// (get) Token: 0x06032AA3 RID: 207523 RVA: 0x00E37080 File Offset: 0x00E35280
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

		// Token: 0x170062A0 RID: 25248
		// (get) Token: 0x06032AA4 RID: 207524 RVA: 0x00E370FC File Offset: 0x00E352FC
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

		// Token: 0x170062A1 RID: 25249
		// (get) Token: 0x06032AA5 RID: 207525 RVA: 0x00E37178 File Offset: 0x00E35378
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

		// Token: 0x06032AA6 RID: 207526 RVA: 0x00E371F3 File Offset: 0x00E353F3
		public int GetTargetTowerDifficulty()
		{
			return AdventureDefine.periodicityChallengeTypeToTarget[(EPeriodicityChallengeType)this.PeriodicityChallengeType];
		}

		// Token: 0x06032AA7 RID: 207527 RVA: 0x00E37208 File Offset: 0x00E35408
		public bool GetTargetTowerIsUnlock()
		{
			int targetTowerDifficulty = this.GetTargetTowerDifficulty();
			return targetTowerDifficulty > 0 && (targetTowerDifficulty - 1 <= 0 || TowerModel.Instance.GetDifficultyIsClear(targetTowerDifficulty - 1));
		}

		// Token: 0x0401ADE6 RID: 110054
		public ESoundAreaDataType? Type;

		// Token: 0x0401ADE7 RID: 110055
		[Nullable(2)]
		public DungeonDetectionRecord DungeonDetectionRecord;

		// Token: 0x0401ADE8 RID: 110056
		[Nullable(2)]
		public SilentAreaDetectionRecord SilentAreaDetectionRecord;
	}
}

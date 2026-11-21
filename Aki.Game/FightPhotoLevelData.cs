using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common;

// Token: 0x0200071E RID: 1822
[NullableContext(1)]
[Nullable(0)]
public class FightPhotoLevelData
{
	// Token: 0x06005409 RID: 21513 RVA: 0x001BC07D File Offset: 0x001BA27D
	public FightPhotoLevelData(PhotoFightActivity config)
	{
		this.Config = config;
	}

	// Token: 0x17000B0B RID: 2827
	// (get) Token: 0x0600540B RID: 21515 RVA: 0x001BC0A0 File Offset: 0x001BA2A0
	// (set) Token: 0x0600540A RID: 21514 RVA: 0x001BC097 File Offset: 0x001BA297
	public bool IsUnLock
	{
		get
		{
			return this.LevelGroupData.IsUnLock && this.IsUnLockInternal;
		}
		set
		{
			this.IsUnLockInternal = value;
		}
	}

	// Token: 0x17000B0C RID: 2828
	// (get) Token: 0x0600540D RID: 21517 RVA: 0x001BC0C0 File Offset: 0x001BA2C0
	// (set) Token: 0x0600540C RID: 21516 RVA: 0x001BC0B7 File Offset: 0x001BA2B7
	public bool IsFinished
	{
		get
		{
			return this.IsFinishedInternal;
		}
		set
		{
			this.IsFinishedInternal = value;
		}
	}

	// Token: 0x17000B0D RID: 2829
	// (get) Token: 0x0600540F RID: 21519 RVA: 0x001BC0D1 File Offset: 0x001BA2D1
	// (set) Token: 0x0600540E RID: 21518 RVA: 0x001BC0C8 File Offset: 0x001BA2C8
	public FightPhotoLevelGroupData LevelGroupData
	{
		get
		{
			return this.LevelGroupDataInternal;
		}
		set
		{
			this.LevelGroupDataInternal = value;
		}
	}

	// Token: 0x06005410 RID: 21520 RVA: 0x001BC0D9 File Offset: 0x001BA2D9
	public void SetRoleIdList(List<int> roleIdList)
	{
		if (roleIdList.Count == 0)
		{
			this.RoleIdList = new List<int>(this.Config.PreSelectRoleList());
			return;
		}
		this.RoleIdList = roleIdList;
	}

	// Token: 0x06005411 RID: 21521 RVA: 0x001BC101 File Offset: 0x001BA301
	public List<int> GetRoleIdList()
	{
		return this.RoleIdList;
	}

	// Token: 0x06005412 RID: 21522 RVA: 0x001BC10C File Offset: 0x001BA30C
	public List<int> GetRoleIdListIncludeZero()
	{
		List<int> list = new List<int>(this.RoleIdList);
		while (list.Count < 3)
		{
			list.Add(0);
		}
		return list;
	}

	// Token: 0x17000B0E RID: 2830
	// (get) Token: 0x06005413 RID: 21523 RVA: 0x001BC138 File Offset: 0x001BA338
	public bool HasRedDot
	{
		get
		{
			return this.IsUnLock && !this.IsFinished && !(LocalStorage.GetPlayer<HashSet<int>>(ELocalStoragePlayerKey.FightPhotoLevelRedDot, null) ?? new HashSet<int>()).Contains(this.LevelId);
		}
	}

	// Token: 0x06005414 RID: 21524 RVA: 0x001BC170 File Offset: 0x001BA370
	public void ReadRedDot()
	{
		HashSet<int> hashSet = LocalStorage.GetPlayer<HashSet<int>>(ELocalStoragePlayerKey.FightPhotoLevelRedDot, null) ?? new HashSet<int>();
		hashSet.Add(this.LevelId);
		LocalStorage.SetPlayer<HashSet<int>>(ELocalStoragePlayerKey.FightPhotoLevelRedDot, hashSet);
	}

	// Token: 0x17000B0F RID: 2831
	// (get) Token: 0x06005415 RID: 21525 RVA: 0x001BC1AB File Offset: 0x001BA3AB
	public int LevelId
	{
		get
		{
			return this.Config.Id;
		}
	}

	// Token: 0x17000B10 RID: 2832
	// (get) Token: 0x06005416 RID: 21526 RVA: 0x001BC1B8 File Offset: 0x001BA3B8
	public string Name
	{
		get
		{
			return this.Config.LevelName;
		}
	}

	// Token: 0x17000B11 RID: 2833
	// (get) Token: 0x06005417 RID: 21527 RVA: 0x001BC1C5 File Offset: 0x001BA3C5
	public string LevelSimpleName
	{
		get
		{
			return this.Config.LevelSimpleName;
		}
	}

	// Token: 0x17000B12 RID: 2834
	// (get) Token: 0x06005418 RID: 21528 RVA: 0x001BC1D4 File Offset: 0x001BA3D4
	public string PreLevelName
	{
		get
		{
			PhotoFightActivity? config = ConfigPhotoFightActivityById.GetConfig(this.Config.PreInstId, true);
			if (config != null)
			{
				return config.Value.LevelName;
			}
			return string.Empty;
		}
	}

	// Token: 0x17000B13 RID: 2835
	// (get) Token: 0x06005419 RID: 21529 RVA: 0x001BC211 File Offset: 0x001BA411
	public bool IsDifficulty
	{
		get
		{
			return this.Config.IsDifficulty;
		}
	}

	// Token: 0x17000B14 RID: 2836
	// (get) Token: 0x0600541A RID: 21530 RVA: 0x001BC21E File Offset: 0x001BA41E
	public string RoleBigTexture
	{
		get
		{
			return this.Config.RoleBigTexture;
		}
	}

	// Token: 0x17000B15 RID: 2837
	// (get) Token: 0x0600541B RID: 21531 RVA: 0x001BC22B File Offset: 0x001BA42B
	public string[] TaskTargetText
	{
		get
		{
			return this.Config.TaskDescriptionText();
		}
	}

	// Token: 0x17000B16 RID: 2838
	// (get) Token: 0x0600541C RID: 21532 RVA: 0x001BC238 File Offset: 0x001BA438
	[Nullable(0)]
	public Span<int> TrialRoleList
	{
		[NullableContext(0)]
		get
		{
			return this.Config.GetTrailRoleBytes();
		}
	}

	// Token: 0x17000B17 RID: 2839
	// (get) Token: 0x0600541D RID: 21533 RVA: 0x001BC245 File Offset: 0x001BA445
	public int InstanceId
	{
		get
		{
			return this.Config.InstId;
		}
	}

	// Token: 0x17000B18 RID: 2840
	// (get) Token: 0x0600541E RID: 21534 RVA: 0x001BC252 File Offset: 0x001BA452
	public string NpcHeadIcon
	{
		get
		{
			return this.Config.NpcHeadIcon;
		}
	}

	// Token: 0x17000B19 RID: 2841
	// (get) Token: 0x0600541F RID: 21535 RVA: 0x001BC25F File Offset: 0x001BA45F
	public string NpcDialogue
	{
		get
		{
			return this.Config.NpcDialogue;
		}
	}

	// Token: 0x17000B1A RID: 2842
	// (get) Token: 0x06005420 RID: 21536 RVA: 0x001BC26C File Offset: 0x001BA46C
	public int LoadingId
	{
		get
		{
			return this.Config.LoadingId;
		}
	}

	// Token: 0x17000B1B RID: 2843
	// (get) Token: 0x06005421 RID: 21537 RVA: 0x001BC279 File Offset: 0x001BA479
	public List<int> TargetRoles
	{
		get
		{
			return new List<int>(this.Config.TargetRoles());
		}
	}

	// Token: 0x04003ADF RID: 15071
	private PhotoFightActivity Config;

	// Token: 0x04003AE0 RID: 15072
	private List<int> RoleIdList = new List<int>();

	// Token: 0x04003AE1 RID: 15073
	private FightPhotoLevelGroupData LevelGroupDataInternal;

	// Token: 0x04003AE2 RID: 15074
	private bool IsUnLockInternal;

	// Token: 0x04003AE3 RID: 15075
	private bool IsFinishedInternal;
}

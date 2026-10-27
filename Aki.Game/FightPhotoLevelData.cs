using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common;

// Token: 0x0200126A RID: 4714
[NullableContext(1)]
[Nullable(0)]
public class FightPhotoLevelData
{
	// Token: 0x06008072 RID: 32882 RVA: 0x001B33AD File Offset: 0x001B15AD
	public FightPhotoLevelData(PhotoFightActivity config)
	{
		this.Config = config;
	}

	// Token: 0x17000AEB RID: 2795
	// (get) Token: 0x06008074 RID: 32884 RVA: 0x001B33D0 File Offset: 0x001B15D0
	// (set) Token: 0x06008073 RID: 32883 RVA: 0x001B33C7 File Offset: 0x001B15C7
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

	// Token: 0x17000AEC RID: 2796
	// (get) Token: 0x06008076 RID: 32886 RVA: 0x001B33F0 File Offset: 0x001B15F0
	// (set) Token: 0x06008075 RID: 32885 RVA: 0x001B33E7 File Offset: 0x001B15E7
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

	// Token: 0x17000AED RID: 2797
	// (get) Token: 0x06008078 RID: 32888 RVA: 0x001B3401 File Offset: 0x001B1601
	// (set) Token: 0x06008077 RID: 32887 RVA: 0x001B33F8 File Offset: 0x001B15F8
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

	// Token: 0x06008079 RID: 32889 RVA: 0x001B3409 File Offset: 0x001B1609
	public void SetRoleIdList(List<int> roleIdList)
	{
		if (roleIdList.Count == 0)
		{
			this.RoleIdList = this.Config.PreSelectRoleList().ToList<int>();
			return;
		}
		this.RoleIdList = roleIdList;
	}

	// Token: 0x0600807A RID: 32890 RVA: 0x001B3431 File Offset: 0x001B1631
	public List<int> GetRoleIdList()
	{
		return this.RoleIdList;
	}

	// Token: 0x0600807B RID: 32891 RVA: 0x001B343C File Offset: 0x001B163C
	public List<int> GetRoleIdListIncludeZero()
	{
		List<int> list = new List<int>(this.RoleIdList);
		while (list.Count < 3)
		{
			list.Add(0);
		}
		return list;
	}

	// Token: 0x17000AEE RID: 2798
	// (get) Token: 0x0600807C RID: 32892 RVA: 0x001B3468 File Offset: 0x001B1668
	public bool HasRedDot
	{
		get
		{
			return this.IsUnLock && !this.IsFinished && !(LocalStorage.GetPlayer<HashSet<int>>(ELocalStoragePlayerKey.FightPhotoLevelRedDot, null) ?? new HashSet<int>()).Contains(this.LevelId);
		}
	}

	// Token: 0x0600807D RID: 32893 RVA: 0x001B34A0 File Offset: 0x001B16A0
	public void ReadRedDot()
	{
		HashSet<int> hashSet = LocalStorage.GetPlayer<HashSet<int>>(ELocalStoragePlayerKey.FightPhotoLevelRedDot, null) ?? new HashSet<int>();
		hashSet.Add(this.LevelId);
		LocalStorage.SetPlayer<HashSet<int>>(ELocalStoragePlayerKey.FightPhotoLevelRedDot, hashSet);
	}

	// Token: 0x17000AEF RID: 2799
	// (get) Token: 0x0600807E RID: 32894 RVA: 0x001B34DB File Offset: 0x001B16DB
	public int LevelId
	{
		get
		{
			return this.Config.Id;
		}
	}

	// Token: 0x17000AF0 RID: 2800
	// (get) Token: 0x0600807F RID: 32895 RVA: 0x001B34E8 File Offset: 0x001B16E8
	public string Name
	{
		get
		{
			return this.Config.LevelName;
		}
	}

	// Token: 0x17000AF1 RID: 2801
	// (get) Token: 0x06008080 RID: 32896 RVA: 0x001B34F5 File Offset: 0x001B16F5
	public string LevelSimpleName
	{
		get
		{
			return this.Config.LevelSimpleName;
		}
	}

	// Token: 0x17000AF2 RID: 2802
	// (get) Token: 0x06008081 RID: 32897 RVA: 0x001B3504 File Offset: 0x001B1704
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

	// Token: 0x17000AF3 RID: 2803
	// (get) Token: 0x06008082 RID: 32898 RVA: 0x001B3541 File Offset: 0x001B1741
	public bool IsDifficulty
	{
		get
		{
			return this.Config.IsDifficulty;
		}
	}

	// Token: 0x17000AF4 RID: 2804
	// (get) Token: 0x06008083 RID: 32899 RVA: 0x001B354E File Offset: 0x001B174E
	public string RoleBigTexture
	{
		get
		{
			return this.Config.RoleBigTexture;
		}
	}

	// Token: 0x17000AF5 RID: 2805
	// (get) Token: 0x06008084 RID: 32900 RVA: 0x001B355B File Offset: 0x001B175B
	public string[] TaskTargetText
	{
		get
		{
			return this.Config.TaskDescriptionText();
		}
	}

	// Token: 0x17000AF6 RID: 2806
	// (get) Token: 0x06008085 RID: 32901 RVA: 0x001B3568 File Offset: 0x001B1768
	[Nullable(0)]
	public Span<int> TrialRoleList
	{
		[NullableContext(0)]
		get
		{
			return this.Config.GetTrailRoleBytes();
		}
	}

	// Token: 0x17000AF7 RID: 2807
	// (get) Token: 0x06008086 RID: 32902 RVA: 0x001B3575 File Offset: 0x001B1775
	public int InstanceId
	{
		get
		{
			return this.Config.InstId;
		}
	}

	// Token: 0x17000AF8 RID: 2808
	// (get) Token: 0x06008087 RID: 32903 RVA: 0x001B3582 File Offset: 0x001B1782
	public string NpcHeadIcon
	{
		get
		{
			return this.Config.NpcHeadIcon;
		}
	}

	// Token: 0x17000AF9 RID: 2809
	// (get) Token: 0x06008088 RID: 32904 RVA: 0x001B358F File Offset: 0x001B178F
	public string NpcDialogue
	{
		get
		{
			return this.Config.NpcDialogue;
		}
	}

	// Token: 0x17000AFA RID: 2810
	// (get) Token: 0x06008089 RID: 32905 RVA: 0x001B359C File Offset: 0x001B179C
	public int LoadingId
	{
		get
		{
			return this.Config.LoadingId;
		}
	}

	// Token: 0x17000AFB RID: 2811
	// (get) Token: 0x0600808A RID: 32906 RVA: 0x001B35A9 File Offset: 0x001B17A9
	public List<int> TargetRoles
	{
		get
		{
			return this.Config.TargetRoles().ToList<int>();
		}
	}

	// Token: 0x04003A47 RID: 14919
	private PhotoFightActivity Config;

	// Token: 0x04003A48 RID: 14920
	private List<int> RoleIdList = new List<int>();

	// Token: 0x04003A49 RID: 14921
	private FightPhotoLevelGroupData LevelGroupDataInternal;

	// Token: 0x04003A4A RID: 14922
	private bool IsUnLockInternal;

	// Token: 0x04003A4B RID: 14923
	private bool IsFinishedInternal;
}

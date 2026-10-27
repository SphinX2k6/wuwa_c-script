using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;

// Token: 0x0200126B RID: 4715
[NullableContext(1)]
[Nullable(0)]
public class FightPhotoLevelGroupData
{
	// Token: 0x0600808B RID: 32907 RVA: 0x001B35BB File Offset: 0x001B17BB
	public FightPhotoLevelGroupData(PhotoFightActivityGroup config)
	{
		this.Config = config;
	}

	// Token: 0x0600808C RID: 32908 RVA: 0x001B35E0 File Offset: 0x001B17E0
	public void PushFightPhotoLevel(FightPhotoLevelData level)
	{
		this.FightPhotoLevelList.Add(level);
		foreach (int item in level.TargetRoles)
		{
			if (!this.TargetRoleIdListInternal.Contains(item))
			{
				this.TargetRoleIdListInternal.Add(item);
			}
		}
	}

	// Token: 0x17000AFC RID: 2812
	// (get) Token: 0x0600808D RID: 32909 RVA: 0x001B3654 File Offset: 0x001B1854
	[Nullable(0)]
	public Span<int> LevelIdList
	{
		[NullableContext(0)]
		get
		{
			return this.Config.GetDifficultyBytes();
		}
	}

	// Token: 0x17000AFD RID: 2813
	// (get) Token: 0x0600808E RID: 32910 RVA: 0x001B3661 File Offset: 0x001B1861
	public List<FightPhotoLevelData> LevelDataList
	{
		get
		{
			return this.FightPhotoLevelList;
		}
	}

	// Token: 0x17000AFE RID: 2814
	// (get) Token: 0x06008090 RID: 32912 RVA: 0x001B367E File Offset: 0x001B187E
	// (set) Token: 0x0600808F RID: 32911 RVA: 0x001B3669 File Offset: 0x001B1869
	public long UnlockTime
	{
		get
		{
			return this.UnlockTimeInterval;
		}
		set
		{
			this.UnlockTimeInterval = value / (long)TimeUtil.Instance.InverseMillisecond;
		}
	}

	// Token: 0x06008091 RID: 32913 RVA: 0x001B3688 File Offset: 0x001B1888
	public bool IsReachUnlockTime()
	{
		double serverTime = TimeUtil.Instance.GetServerTime();
		return this.UnlockTimeInterval == 0L || (double)this.UnlockTime < serverTime;
	}

	// Token: 0x17000AFF RID: 2815
	// (get) Token: 0x06008092 RID: 32914 RVA: 0x001B36B4 File Offset: 0x001B18B4
	public bool IsUnLock
	{
		get
		{
			return this.IsReachUnlockTime();
		}
	}

	// Token: 0x17000B00 RID: 2816
	// (get) Token: 0x06008093 RID: 32915 RVA: 0x001B36BC File Offset: 0x001B18BC
	public bool IsFinished
	{
		get
		{
			using (List<FightPhotoLevelData>.Enumerator enumerator = this.FightPhotoLevelList.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (!enumerator.Current.IsFinished)
					{
						return false;
					}
				}
			}
			return true;
		}
	}

	// Token: 0x17000B01 RID: 2817
	// (get) Token: 0x06008094 RID: 32916 RVA: 0x001B3718 File Offset: 0x001B1918
	public FightPhotoLevelData FirstUnFinishedLevelData
	{
		get
		{
			FightPhotoLevelData fightPhotoLevelData = null;
			int i = 0;
			int count = this.FightPhotoLevelList.Count;
			while (i < count)
			{
				FightPhotoLevelData fightPhotoLevelData2 = this.FightPhotoLevelList[i];
				if (fightPhotoLevelData2.IsUnLock && !fightPhotoLevelData2.IsFinished)
				{
					fightPhotoLevelData = fightPhotoLevelData2;
					break;
				}
				i++;
			}
			if (fightPhotoLevelData == null)
			{
				int j = 0;
				int count2 = this.FightPhotoLevelList.Count;
				while (j < count2)
				{
					FightPhotoLevelData fightPhotoLevelData3 = this.FightPhotoLevelList[j];
					if (!fightPhotoLevelData3.IsUnLock)
					{
						fightPhotoLevelData = fightPhotoLevelData3;
						break;
					}
					j++;
				}
			}
			if (fightPhotoLevelData == null && this.FightPhotoLevelList.Count > 0)
			{
				fightPhotoLevelData = this.FightPhotoLevelList[this.FightPhotoLevelList.Count - 1];
			}
			return fightPhotoLevelData;
		}
	}

	// Token: 0x17000B02 RID: 2818
	// (get) Token: 0x06008095 RID: 32917 RVA: 0x001B37CC File Offset: 0x001B19CC
	public bool HasRedDot
	{
		get
		{
			using (List<FightPhotoLevelData>.Enumerator enumerator = this.FightPhotoLevelList.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.HasRedDot)
					{
						return true;
					}
				}
			}
			return false;
		}
	}

	// Token: 0x17000B03 RID: 2819
	// (get) Token: 0x06008096 RID: 32918 RVA: 0x001B3828 File Offset: 0x001B1A28
	public int Id
	{
		get
		{
			return this.Config.Id;
		}
	}

	// Token: 0x17000B04 RID: 2820
	// (get) Token: 0x06008097 RID: 32919 RVA: 0x001B3835 File Offset: 0x001B1A35
	public int SortId
	{
		get
		{
			return this.Config.SortId;
		}
	}

	// Token: 0x17000B05 RID: 2821
	// (get) Token: 0x06008098 RID: 32920 RVA: 0x001B3842 File Offset: 0x001B1A42
	public string ThemeName
	{
		get
		{
			return this.Config.ThemeName;
		}
	}

	// Token: 0x17000B06 RID: 2822
	// (get) Token: 0x06008099 RID: 32921 RVA: 0x001B384F File Offset: 0x001B1A4F
	public string RoleTextureLight
	{
		get
		{
			return this.Config.RoleTextureLight;
		}
	}

	// Token: 0x17000B07 RID: 2823
	// (get) Token: 0x0600809A RID: 32922 RVA: 0x001B385C File Offset: 0x001B1A5C
	public string RoleTextureDark
	{
		get
		{
			return this.Config.RoleTextureDark;
		}
	}

	// Token: 0x17000B08 RID: 2824
	// (get) Token: 0x0600809B RID: 32923 RVA: 0x001B3869 File Offset: 0x001B1A69
	public string NumTexture
	{
		get
		{
			return this.Config.NumSprite;
		}
	}

	// Token: 0x17000B09 RID: 2825
	// (get) Token: 0x0600809C RID: 32924 RVA: 0x001B3876 File Offset: 0x001B1A76
	public string NumTexture2
	{
		get
		{
			return this.Config.NumTextureAdd;
		}
	}

	// Token: 0x17000B0A RID: 2826
	// (get) Token: 0x0600809D RID: 32925 RVA: 0x001B3884 File Offset: 0x001B1A84
	public unsafe string TargetRoleName
	{
		get
		{
			if (this.TargetRoleIdListInternal.Count > 1)
			{
				return this.Config.TargetRoleListName;
			}
			if (this.TargetRoleIdListInternal.Count == 0)
			{
				return string.Empty;
			}
			int num = this.TargetRoleIdListInternal[0];
			RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(num);
			if (roleConfig == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.FightPhotograph;
				ELogAuthor author = ELogAuthor.CXJ;
				string message = "关卡组拍照目标不存在";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("levelGroupId", this.Config.Id);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("roleId", num);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return string.Empty;
			}
			return roleConfig.Value.Name;
		}
	}

	// Token: 0x17000B0B RID: 2827
	// (get) Token: 0x0600809E RID: 32926 RVA: 0x001B395F File Offset: 0x001B1B5F
	public List<int> TargetRoleIds
	{
		get
		{
			return this.TargetRoleIdListInternal;
		}
	}

	// Token: 0x04003A4C RID: 14924
	private PhotoFightActivityGroup Config;

	// Token: 0x04003A4D RID: 14925
	private readonly List<FightPhotoLevelData> FightPhotoLevelList = new List<FightPhotoLevelData>();

	// Token: 0x04003A4E RID: 14926
	private long UnlockTimeInterval;

	// Token: 0x04003A4F RID: 14927
	private readonly List<int> TargetRoleIdListInternal = new List<int>();
}

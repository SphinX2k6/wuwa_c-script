using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;

// Token: 0x0200071F RID: 1823
[NullableContext(1)]
[Nullable(0)]
public class FightPhotoLevelGroupData
{
	// Token: 0x06005422 RID: 21538 RVA: 0x001BC28B File Offset: 0x001BA48B
	public FightPhotoLevelGroupData(PhotoFightActivityGroup config)
	{
		this.Config = config;
	}

	// Token: 0x06005423 RID: 21539 RVA: 0x001BC2B0 File Offset: 0x001BA4B0
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

	// Token: 0x17000B1C RID: 2844
	// (get) Token: 0x06005424 RID: 21540 RVA: 0x001BC324 File Offset: 0x001BA524
	[Nullable(0)]
	public Span<int> LevelIdList
	{
		[NullableContext(0)]
		get
		{
			return this.Config.GetDifficultyBytes();
		}
	}

	// Token: 0x17000B1D RID: 2845
	// (get) Token: 0x06005425 RID: 21541 RVA: 0x001BC331 File Offset: 0x001BA531
	public List<FightPhotoLevelData> LevelDataList
	{
		get
		{
			return this.FightPhotoLevelList;
		}
	}

	// Token: 0x17000B1E RID: 2846
	// (get) Token: 0x06005427 RID: 21543 RVA: 0x001BC34E File Offset: 0x001BA54E
	// (set) Token: 0x06005426 RID: 21542 RVA: 0x001BC339 File Offset: 0x001BA539
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

	// Token: 0x06005428 RID: 21544 RVA: 0x001BC358 File Offset: 0x001BA558
	public bool IsReachUnlockTime()
	{
		double serverTime = TimeUtil.Instance.GetServerTime();
		return this.UnlockTimeInterval == 0L || (double)this.UnlockTime < serverTime;
	}

	// Token: 0x17000B1F RID: 2847
	// (get) Token: 0x06005429 RID: 21545 RVA: 0x001BC384 File Offset: 0x001BA584
	public bool IsUnLock
	{
		get
		{
			return this.IsReachUnlockTime();
		}
	}

	// Token: 0x17000B20 RID: 2848
	// (get) Token: 0x0600542A RID: 21546 RVA: 0x001BC38C File Offset: 0x001BA58C
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

	// Token: 0x17000B21 RID: 2849
	// (get) Token: 0x0600542B RID: 21547 RVA: 0x001BC3E8 File Offset: 0x001BA5E8
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

	// Token: 0x17000B22 RID: 2850
	// (get) Token: 0x0600542C RID: 21548 RVA: 0x001BC49C File Offset: 0x001BA69C
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

	// Token: 0x17000B23 RID: 2851
	// (get) Token: 0x0600542D RID: 21549 RVA: 0x001BC4F8 File Offset: 0x001BA6F8
	public int Id
	{
		get
		{
			return this.Config.Id;
		}
	}

	// Token: 0x17000B24 RID: 2852
	// (get) Token: 0x0600542E RID: 21550 RVA: 0x001BC505 File Offset: 0x001BA705
	public int SortId
	{
		get
		{
			return this.Config.SortId;
		}
	}

	// Token: 0x17000B25 RID: 2853
	// (get) Token: 0x0600542F RID: 21551 RVA: 0x001BC512 File Offset: 0x001BA712
	public string ThemeName
	{
		get
		{
			return this.Config.ThemeName;
		}
	}

	// Token: 0x17000B26 RID: 2854
	// (get) Token: 0x06005430 RID: 21552 RVA: 0x001BC51F File Offset: 0x001BA71F
	public string RoleTextureLight
	{
		get
		{
			return this.Config.RoleTextureLight;
		}
	}

	// Token: 0x17000B27 RID: 2855
	// (get) Token: 0x06005431 RID: 21553 RVA: 0x001BC52C File Offset: 0x001BA72C
	public string RoleTextureDark
	{
		get
		{
			return this.Config.RoleTextureDark;
		}
	}

	// Token: 0x17000B28 RID: 2856
	// (get) Token: 0x06005432 RID: 21554 RVA: 0x001BC539 File Offset: 0x001BA739
	public string NumTexture
	{
		get
		{
			return this.Config.NumSprite;
		}
	}

	// Token: 0x17000B29 RID: 2857
	// (get) Token: 0x06005433 RID: 21555 RVA: 0x001BC546 File Offset: 0x001BA746
	public string NumTexture2
	{
		get
		{
			return this.Config.NumTextureAdd;
		}
	}

	// Token: 0x17000B2A RID: 2858
	// (get) Token: 0x06005434 RID: 21556 RVA: 0x001BC554 File Offset: 0x001BA754
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

	// Token: 0x17000B2B RID: 2859
	// (get) Token: 0x06005435 RID: 21557 RVA: 0x001BC62F File Offset: 0x001BA82F
	public List<int> TargetRoleIds
	{
		get
		{
			return this.TargetRoleIdListInternal;
		}
	}

	// Token: 0x04003AE4 RID: 15076
	private PhotoFightActivityGroup Config;

	// Token: 0x04003AE5 RID: 15077
	private readonly List<FightPhotoLevelData> FightPhotoLevelList = new List<FightPhotoLevelData>();

	// Token: 0x04003AE6 RID: 15078
	private long UnlockTimeInterval;

	// Token: 0x04003AE7 RID: 15079
	private readonly List<int> TargetRoleIdListInternal = new List<int>();
}

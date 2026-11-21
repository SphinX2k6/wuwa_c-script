using System;
using System.Collections.Generic;
using CSharpScript.Game.Common;

// Token: 0x0200189A RID: 6298
public class PersonalPlayerTitleData
{
	// Token: 0x0600F955 RID: 63829 RVA: 0x0048E800 File Offset: 0x0048CA00
	public PersonalPlayerTitleData(int playerTitleId, bool isUnLock)
	{
		this.PlayerTitleId = playerTitleId;
		this.IsUnLock = isUnLock;
		Dictionary<int, bool> dictionary = LocalStorage.GetPlayer<Dictionary<int, bool>>(ELocalStoragePlayerKey.PlayerTitleRecord, null) ?? new Dictionary<int, bool>();
		if (this.IsUnLock)
		{
			if (!dictionary.ContainsKey(playerTitleId))
			{
				dictionary[playerTitleId] = true;
				LocalStorage.SetPlayer<Dictionary<int, bool>>(ELocalStoragePlayerKey.PlayerTitleRecord, dictionary);
				return;
			}
		}
		else if (dictionary.ContainsKey(playerTitleId))
		{
			dictionary.Remove(playerTitleId);
			LocalStorage.SetPlayer<Dictionary<int, bool>>(ELocalStoragePlayerKey.PlayerTitleRecord, dictionary);
		}
	}

	// Token: 0x0600F956 RID: 63830 RVA: 0x0048E870 File Offset: 0x0048CA70
	public void SetUnLockProgress(int curProgress, int targetProgress)
	{
		this.CurProgress = new int?(curProgress);
		this.TargetProgress = new int?(targetProgress);
	}

	// Token: 0x0600F957 RID: 63831 RVA: 0x0048E88A File Offset: 0x0048CA8A
	public void UnLock(double unlockTime)
	{
		this.IsUnLock = true;
		this.UnlockTime = new double?(unlockTime);
	}

	// Token: 0x0600F958 RID: 63832 RVA: 0x0048E89F File Offset: 0x0048CA9F
	public void SetStarLevel(int starLevel)
	{
		this.StarLevel = new int?(starLevel);
	}

	// Token: 0x0600F959 RID: 63833 RVA: 0x0048E8AD File Offset: 0x0048CAAD
	public void SetUnlockTime(double unlockTime)
	{
		this.UnlockTime = new double?(unlockTime);
	}

	// Token: 0x0600F95A RID: 63834 RVA: 0x0048E8BC File Offset: 0x0048CABC
	public bool GetIsShowRedDot()
	{
		if (!this.IsUnLock)
		{
			return false;
		}
		if (this.IsExpired())
		{
			return false;
		}
		Dictionary<int, bool> dictionary = LocalStorage.GetPlayer<Dictionary<int, bool>>(ELocalStoragePlayerKey.PlayerTitleRecord, null) ?? new Dictionary<int, bool>();
		return dictionary.ContainsKey(this.PlayerTitleId) && dictionary[this.PlayerTitleId];
	}

	// Token: 0x0600F95B RID: 63835 RVA: 0x0048E90B File Offset: 0x0048CB0B
	public bool IsTimeLimitTitle()
	{
		return this.StartTime != null && this.EndTime != null;
	}

	// Token: 0x0600F95C RID: 63836 RVA: 0x0048E927 File Offset: 0x0048CB27
	public bool IsExpired()
	{
		return this.IsTimeLimitTitle() && TimeUtil.Instance.GetServerTime() > this.EndTime.Value;
	}

	// Token: 0x0600F95D RID: 63837 RVA: 0x0048E94A File Offset: 0x0048CB4A
	public bool IsEffective()
	{
		return this.IsUnLock && !this.IsExpired();
	}

	// Token: 0x0600F95E RID: 63838 RVA: 0x0048E960 File Offset: 0x0048CB60
	public int GetRemainingDays()
	{
		if (!this.IsTimeLimitTitle())
		{
			return 0;
		}
		double serverTime = TimeUtil.Instance.GetServerTime();
		double num = this.EndTime.Value - serverTime;
		if (num <= 0.0)
		{
			return 0;
		}
		return (int)Math.Ceiling(num / (double)TimeUtil.Instance.OneDaySeconds);
	}

	// Token: 0x0600F95F RID: 63839 RVA: 0x0048E9B2 File Offset: 0x0048CBB2
	public void SetTimeLimit(double startTime, double endTime)
	{
		this.StartTime = new double?(startTime);
		this.EndTime = new double?(endTime);
	}

	// Token: 0x04008B45 RID: 35653
	public int PlayerTitleId;

	// Token: 0x04008B46 RID: 35654
	public int? StarLevel;

	// Token: 0x04008B47 RID: 35655
	public bool IsUnLock;

	// Token: 0x04008B48 RID: 35656
	public double? UnlockTime;

	// Token: 0x04008B49 RID: 35657
	public int? CurProgress;

	// Token: 0x04008B4A RID: 35658
	public int? TargetProgress;

	// Token: 0x04008B4B RID: 35659
	public double? StartTime;

	// Token: 0x04008B4C RID: 35660
	public double? EndTime;
}

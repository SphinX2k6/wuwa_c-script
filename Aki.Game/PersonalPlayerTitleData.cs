using System;
using System.Collections.Generic;
using CSharpScript.Game.Common;

// Token: 0x020023B5 RID: 9141
public class PersonalPlayerTitleData
{
	// Token: 0x060124A3 RID: 74915 RVA: 0x00481318 File Offset: 0x0047F518
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

	// Token: 0x060124A4 RID: 74916 RVA: 0x00481388 File Offset: 0x0047F588
	public void SetUnLockProgress(int curProgress, int targetProgress)
	{
		this.CurProgress = new int?(curProgress);
		this.TargetProgress = new int?(targetProgress);
	}

	// Token: 0x060124A5 RID: 74917 RVA: 0x004813A2 File Offset: 0x0047F5A2
	public void UnLock(double unlockTime)
	{
		this.IsUnLock = true;
		this.UnlockTime = new double?(unlockTime);
	}

	// Token: 0x060124A6 RID: 74918 RVA: 0x004813B7 File Offset: 0x0047F5B7
	public void SetStarLevel(int starLevel)
	{
		this.StarLevel = new int?(starLevel);
	}

	// Token: 0x060124A7 RID: 74919 RVA: 0x004813C5 File Offset: 0x0047F5C5
	public void SetUnlockTime(double unlockTime)
	{
		this.UnlockTime = new double?(unlockTime);
	}

	// Token: 0x060124A8 RID: 74920 RVA: 0x004813D4 File Offset: 0x0047F5D4
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

	// Token: 0x060124A9 RID: 74921 RVA: 0x00481423 File Offset: 0x0047F623
	public bool IsTimeLimitTitle()
	{
		return this.StartTime != null && this.EndTime != null;
	}

	// Token: 0x060124AA RID: 74922 RVA: 0x0048143F File Offset: 0x0047F63F
	public bool IsExpired()
	{
		return this.IsTimeLimitTitle() && TimeUtil.Instance.GetServerTime() > this.EndTime.Value;
	}

	// Token: 0x060124AB RID: 74923 RVA: 0x00481462 File Offset: 0x0047F662
	public bool IsEffective()
	{
		return this.IsUnLock && !this.IsExpired();
	}

	// Token: 0x060124AC RID: 74924 RVA: 0x00481478 File Offset: 0x0047F678
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

	// Token: 0x060124AD RID: 74925 RVA: 0x004814CA File Offset: 0x0047F6CA
	public void SetTimeLimit(double startTime, double endTime)
	{
		this.StartTime = new double?(startTime);
		this.EndTime = new double?(endTime);
	}

	// Token: 0x040089FE RID: 35326
	public int PlayerTitleId;

	// Token: 0x040089FF RID: 35327
	public int? StarLevel;

	// Token: 0x04008A00 RID: 35328
	public bool IsUnLock;

	// Token: 0x04008A01 RID: 35329
	public double? UnlockTime;

	// Token: 0x04008A02 RID: 35330
	public int? CurProgress;

	// Token: 0x04008A03 RID: 35331
	public int? TargetProgress;

	// Token: 0x04008A04 RID: 35332
	public double? StartTime;

	// Token: 0x04008A05 RID: 35333
	public double? EndTime;
}

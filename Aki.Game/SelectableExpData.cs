using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000E16 RID: 3606
[NullableContext(1)]
[Nullable(0)]
public class SelectableExpData
{
	// Token: 0x060091A7 RID: 37287 RVA: 0x002B9480 File Offset: 0x002B7680
	public static SelectableExpData PhraseData(CommonIntensifyPropExpData source)
	{
		SelectableExpData selectableExpData = new SelectableExpData();
		if (source.MaxExpFunction != null)
		{
			selectableExpData.SetMaxExpFunction(source.MaxExpFunction);
		}
		selectableExpData.UpdateComponent(source.CurrentLevel, source.CurrentMaxLevel, source.CurrentExp, null, false);
		selectableExpData.UpdateExp(0);
		return selectableExpData;
	}

	// Token: 0x060091A8 RID: 37288 RVA: 0x002B94D4 File Offset: 0x002B76D4
	public void UpdateComponent(int currentLevel, int currentMaxLevel, int currentExp, int? limitLevel = null, bool addUp = false)
	{
		this.ArrivedLevel = currentLevel;
		this.CurrentLevel = currentLevel;
		this.CurrentMaxLevel = currentMaxLevel;
		this.CurrentExp = currentExp;
		this.LimitLevel = limitLevel;
		this.IsAddUp = addUp;
		if (this.CurrentLevel == this.CurrentMaxLevel)
		{
			this.CurrentMaxExp = this.StageMaxExp(this.CurrentLevel - 1);
			return;
		}
		this.CurrentMaxExp = this.StageMaxExp(this.CurrentLevel);
	}

	// Token: 0x060091A9 RID: 37289 RVA: 0x002B9542 File Offset: 0x002B7742
	public bool UpdateExp(int newAddExp)
	{
		if (this.IsInMax() && newAddExp > this.FrontExp)
		{
			return false;
		}
		this.ForceUpdateExp(newAddExp);
		return true;
	}

	// Token: 0x060091AA RID: 37290 RVA: 0x002B9560 File Offset: 0x002B7760
	private void ForceUpdateExp(int newAddExp)
	{
		this.FrontExp = newAddExp;
		this.CurrentAddExp = newAddExp;
		this.IfNext = (this.CurrentExp + newAddExp >= this.CurrentMaxExp);
		if (this.IfNext)
		{
			int newAddExp2 = this.CurrentExp + newAddExp - this.CurrentMaxExp;
			this.UpdateNextExp(newAddExp2, this.CurrentLevel + 1);
			return;
		}
		float fillAmount = (float)(this.CurrentExp + newAddExp) / (float)this.CurrentMaxExp;
		this.UpdateCurrentExp(newAddExp, this.CurrentLevel, fillAmount);
	}

	// Token: 0x060091AB RID: 37291 RVA: 0x002B95DC File Offset: 0x002B77DC
	protected void UpdateNextExp(int newAddExp, int level)
	{
		if (level >= this.CurrentMaxLevel)
		{
			this.UpdateCurrentExp(newAddExp, level, 1f);
			return;
		}
		int num;
		if (!this.MaxExpCacheMap.TryGetValue(level, out num))
		{
			num = this.GetMaxExpFunction(level);
			this.MaxExpCacheMap[level] = num;
		}
		if (newAddExp >= num)
		{
			this.UpdateNextExp(newAddExp - num, level + 1);
			return;
		}
		float fillAmount = (float)newAddExp / (float)num;
		this.UpdateCurrentExp(newAddExp, level, fillAmount);
	}

	// Token: 0x060091AC RID: 37292 RVA: 0x002B964A File Offset: 0x002B784A
	protected void UpdateCurrentExp(int newAddExp, int nextLevel, float fillAmount)
	{
		this.ArrivedExp = newAddExp;
		this.ArrivedFillAmount = fillAmount;
		this.ArrivedLevel = nextLevel;
	}

	// Token: 0x060091AD RID: 37293 RVA: 0x002B9664 File Offset: 0x002B7864
	public int StageMaxExp(int level)
	{
		if (this.GetMaxExpFunction == null)
		{
			Log.Instance.Error(ELogModule.LevelExperienceComponent, ELogAuthor.XXJ, "Unregistered SetMaxExpFunction CallBack", default(ReadOnlySpan<ValueTuple<string, object>>));
			return 0;
		}
		int num;
		if (!this.MaxExpCacheMap.TryGetValue(level, out num))
		{
			num = this.GetMaxExpFunction(level);
			this.MaxExpCacheMap[level] = num;
		}
		return num;
	}

	// Token: 0x060091AE RID: 37294 RVA: 0x002B96C2 File Offset: 0x002B78C2
	public int GetMaxExp(int level)
	{
		if (this.IsAddUp)
		{
			return this.AddUpMaxExp(level);
		}
		return this.StageMaxExp(level);
	}

	// Token: 0x060091AF RID: 37295 RVA: 0x002B96DC File Offset: 0x002B78DC
	public int AddUpMaxExp(int level)
	{
		int num = 0;
		for (int i = 1; i <= level; i++)
		{
			num += this.StageMaxExp(i);
		}
		return num;
	}

	// Token: 0x060091B0 RID: 37296 RVA: 0x002B9702 File Offset: 0x002B7902
	public bool IsInMax()
	{
		return this.ArrivedLevel == this.CurrentMaxLevel;
	}

	// Token: 0x060091B1 RID: 37297 RVA: 0x002B9714 File Offset: 0x002B7914
	public int GetOverExp()
	{
		int expDistanceToMax = this.GetExpDistanceToMax();
		int num = this.CurrentAddExp - expDistanceToMax;
		if (num > 0)
		{
			return num;
		}
		return 0;
	}

	// Token: 0x060091B2 RID: 37298 RVA: 0x002B9738 File Offset: 0x002B7938
	public bool GetIsAddUp()
	{
		return this.IsAddUp;
	}

	// Token: 0x060091B3 RID: 37299 RVA: 0x002B9740 File Offset: 0x002B7940
	public void SetMaxExpFunction(Func<int, int> getMaxExpFunction)
	{
		this.GetMaxExpFunction = getMaxExpFunction;
	}

	// Token: 0x060091B4 RID: 37300 RVA: 0x002B9749 File Offset: 0x002B7949
	public int GetCurrentLevel()
	{
		return this.CurrentLevel;
	}

	// Token: 0x060091B5 RID: 37301 RVA: 0x002B9751 File Offset: 0x002B7951
	public int GetExpDistanceToMax()
	{
		return this.GetExpDistanceToLevel(this.CurrentMaxLevel);
	}

	// Token: 0x060091B6 RID: 37302 RVA: 0x002B9760 File Offset: 0x002B7960
	public int GetExpDistanceToLevel(int targetLevel)
	{
		if (targetLevel <= this.CurrentLevel)
		{
			return 0;
		}
		int num = Math.Min(targetLevel, this.CurrentMaxLevel);
		int num2 = 0;
		for (int i = 0; i <= num - 1; i++)
		{
			num2 += this.StageMaxExp(i);
		}
		int num3 = 0;
		for (int j = 0; j <= this.CurrentLevel - 1; j++)
		{
			num3 += this.StageMaxExp(j);
		}
		return num2 - num3 - this.CurrentExp;
	}

	// Token: 0x060091B7 RID: 37303 RVA: 0x002B97CD File Offset: 0x002B79CD
	public int GetCurrentExp()
	{
		return this.CurrentExp;
	}

	// Token: 0x060091B8 RID: 37304 RVA: 0x002B97D5 File Offset: 0x002B79D5
	public int GetCurrentMaxLevel()
	{
		return this.CurrentMaxLevel;
	}

	// Token: 0x060091B9 RID: 37305 RVA: 0x002B97DD File Offset: 0x002B79DD
	public int GetLimitLevel()
	{
		return this.LimitLevel.Value;
	}

	// Token: 0x060091BA RID: 37306 RVA: 0x002B97EA File Offset: 0x002B79EA
	public int GetArrivedAddExp()
	{
		return this.ArrivedExp;
	}

	// Token: 0x060091BB RID: 37307 RVA: 0x002B97F2 File Offset: 0x002B79F2
	public float GetCurrentAddExp()
	{
		return (float)this.CurrentAddExp;
	}

	// Token: 0x060091BC RID: 37308 RVA: 0x002B97FB File Offset: 0x002B79FB
	public int GetArrivedLevel()
	{
		return this.ArrivedLevel;
	}

	// Token: 0x060091BD RID: 37309 RVA: 0x002B9803 File Offset: 0x002B7A03
	public float GetArrivedFillAmount()
	{
		return this.ArrivedFillAmount;
	}

	// Token: 0x060091BE RID: 37310 RVA: 0x002B980B File Offset: 0x002B7A0B
	public bool GetIfNext()
	{
		return this.IfNext;
	}

	// Token: 0x04005637 RID: 22071
	protected int ArrivedLevel;

	// Token: 0x04005638 RID: 22072
	protected int ArrivedExp;

	// Token: 0x04005639 RID: 22073
	protected float ArrivedFillAmount;

	// Token: 0x0400563A RID: 22074
	protected int CurrentMaxExp;

	// Token: 0x0400563B RID: 22075
	protected int CurrentLevel;

	// Token: 0x0400563C RID: 22076
	protected int CurrentExp;

	// Token: 0x0400563D RID: 22077
	protected int CurrentMaxLevel;

	// Token: 0x0400563E RID: 22078
	protected int? LimitLevel = new int?(0);

	// Token: 0x0400563F RID: 22079
	protected int FrontExp;

	// Token: 0x04005640 RID: 22080
	private bool IfNext;

	// Token: 0x04005641 RID: 22081
	private int CurrentAddExp;

	// Token: 0x04005642 RID: 22082
	protected Dictionary<int, int> MaxExpCacheMap = new Dictionary<int, int>();

	// Token: 0x04005643 RID: 22083
	[Nullable(2)]
	protected Func<int, int> GetMaxExpFunction;

	// Token: 0x04005644 RID: 22084
	private bool IsAddUp;
}

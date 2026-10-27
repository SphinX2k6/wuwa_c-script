using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001959 RID: 6489
[NullableContext(1)]
[Nullable(0)]
public class SelectableExpData
{
	// Token: 0x0600BDA4 RID: 48548 RVA: 0x002AE63C File Offset: 0x002AC83C
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

	// Token: 0x0600BDA5 RID: 48549 RVA: 0x002AE690 File Offset: 0x002AC890
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

	// Token: 0x0600BDA6 RID: 48550 RVA: 0x002AE6FE File Offset: 0x002AC8FE
	public bool UpdateExp(int newAddExp)
	{
		if (this.IsInMax() && newAddExp > this.FrontExp)
		{
			return false;
		}
		this.ForceUpdateExp(newAddExp);
		return true;
	}

	// Token: 0x0600BDA7 RID: 48551 RVA: 0x002AE71C File Offset: 0x002AC91C
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

	// Token: 0x0600BDA8 RID: 48552 RVA: 0x002AE798 File Offset: 0x002AC998
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

	// Token: 0x0600BDA9 RID: 48553 RVA: 0x002AE806 File Offset: 0x002ACA06
	protected void UpdateCurrentExp(int newAddExp, int nextLevel, float fillAmount)
	{
		this.ArrivedExp = newAddExp;
		this.ArrivedFillAmount = fillAmount;
		this.ArrivedLevel = nextLevel;
	}

	// Token: 0x0600BDAA RID: 48554 RVA: 0x002AE820 File Offset: 0x002ACA20
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

	// Token: 0x0600BDAB RID: 48555 RVA: 0x002AE87E File Offset: 0x002ACA7E
	public int GetMaxExp(int level)
	{
		if (this.IsAddUp)
		{
			return this.AddUpMaxExp(level);
		}
		return this.StageMaxExp(level);
	}

	// Token: 0x0600BDAC RID: 48556 RVA: 0x002AE898 File Offset: 0x002ACA98
	public int AddUpMaxExp(int level)
	{
		int num = 0;
		for (int i = 1; i <= level; i++)
		{
			num += this.StageMaxExp(i);
		}
		return num;
	}

	// Token: 0x0600BDAD RID: 48557 RVA: 0x002AE8BE File Offset: 0x002ACABE
	public bool IsInMax()
	{
		return this.ArrivedLevel == this.CurrentMaxLevel;
	}

	// Token: 0x0600BDAE RID: 48558 RVA: 0x002AE8D0 File Offset: 0x002ACAD0
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

	// Token: 0x0600BDAF RID: 48559 RVA: 0x002AE8F4 File Offset: 0x002ACAF4
	public bool GetIsAddUp()
	{
		return this.IsAddUp;
	}

	// Token: 0x0600BDB0 RID: 48560 RVA: 0x002AE8FC File Offset: 0x002ACAFC
	public void SetMaxExpFunction(Func<int, int> getMaxExpFunction)
	{
		this.GetMaxExpFunction = getMaxExpFunction;
	}

	// Token: 0x0600BDB1 RID: 48561 RVA: 0x002AE905 File Offset: 0x002ACB05
	public int GetCurrentLevel()
	{
		return this.CurrentLevel;
	}

	// Token: 0x0600BDB2 RID: 48562 RVA: 0x002AE90D File Offset: 0x002ACB0D
	public int GetExpDistanceToMax()
	{
		return this.GetExpDistanceToLevel(this.CurrentMaxLevel);
	}

	// Token: 0x0600BDB3 RID: 48563 RVA: 0x002AE91C File Offset: 0x002ACB1C
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

	// Token: 0x0600BDB4 RID: 48564 RVA: 0x002AE989 File Offset: 0x002ACB89
	public int GetCurrentExp()
	{
		return this.CurrentExp;
	}

	// Token: 0x0600BDB5 RID: 48565 RVA: 0x002AE991 File Offset: 0x002ACB91
	public int GetCurrentMaxLevel()
	{
		return this.CurrentMaxLevel;
	}

	// Token: 0x0600BDB6 RID: 48566 RVA: 0x002AE999 File Offset: 0x002ACB99
	public int GetLimitLevel()
	{
		return this.LimitLevel.Value;
	}

	// Token: 0x0600BDB7 RID: 48567 RVA: 0x002AE9A6 File Offset: 0x002ACBA6
	public int GetArrivedAddExp()
	{
		return this.ArrivedExp;
	}

	// Token: 0x0600BDB8 RID: 48568 RVA: 0x002AE9AE File Offset: 0x002ACBAE
	public float GetCurrentAddExp()
	{
		return (float)this.CurrentAddExp;
	}

	// Token: 0x0600BDB9 RID: 48569 RVA: 0x002AE9B7 File Offset: 0x002ACBB7
	public int GetArrivedLevel()
	{
		return this.ArrivedLevel;
	}

	// Token: 0x0600BDBA RID: 48570 RVA: 0x002AE9BF File Offset: 0x002ACBBF
	public float GetArrivedFillAmount()
	{
		return this.ArrivedFillAmount;
	}

	// Token: 0x0600BDBB RID: 48571 RVA: 0x002AE9C7 File Offset: 0x002ACBC7
	public bool GetIfNext()
	{
		return this.IfNext;
	}

	// Token: 0x0400558A RID: 21898
	protected int ArrivedLevel;

	// Token: 0x0400558B RID: 21899
	protected int ArrivedExp;

	// Token: 0x0400558C RID: 21900
	protected float ArrivedFillAmount;

	// Token: 0x0400558D RID: 21901
	protected int CurrentMaxExp;

	// Token: 0x0400558E RID: 21902
	protected int CurrentLevel;

	// Token: 0x0400558F RID: 21903
	protected int CurrentExp;

	// Token: 0x04005590 RID: 21904
	protected int CurrentMaxLevel;

	// Token: 0x04005591 RID: 21905
	protected int? LimitLevel = new int?(0);

	// Token: 0x04005592 RID: 21906
	protected int FrontExp;

	// Token: 0x04005593 RID: 21907
	private bool IfNext;

	// Token: 0x04005594 RID: 21908
	private int CurrentAddExp;

	// Token: 0x04005595 RID: 21909
	protected Dictionary<int, int> MaxExpCacheMap = new Dictionary<int, int>();

	// Token: 0x04005596 RID: 21910
	[Nullable(2)]
	protected Func<int, int> GetMaxExpFunction;

	// Token: 0x04005597 RID: 21911
	private bool IsAddUp;
}

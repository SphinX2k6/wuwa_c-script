using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x02000F35 RID: 3893
[NullableContext(1)]
[Nullable(0)]
public class AchievementStarItem : UiPanelBase
{
	// Token: 0x060062D2 RID: 25298 RVA: 0x0013599C File Offset: 0x00133B9C
	public AchievementStarItem(int count, AchievementData data, UUIItem uiItem)
	{
		this.StarCount = count;
		this.Data = data;
		this.CreateAndShowTask = new UniTask?(base.CreateThenShowByResourceIdAsync(this.GetStarName(count), uiItem, false).AsAsyncUnitUniTask());
	}

	// Token: 0x060062D3 RID: 25299 RVA: 0x001359F0 File Offset: 0x00133BF0
	protected override void OnRegisterComponent()
	{
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>();
		for (int i = 0; i < this.StarCount + 1; i++)
		{
			list.Add(new ValueTuple<int, Type>(i, typeof(UUIItem)));
		}
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x060062D4 RID: 25300 RVA: 0x00135A34 File Offset: 0x00133C34
	protected override void OnStart()
	{
		for (int i = 0; i < this.StarCount; i++)
		{
			this.StarArray.Add(base.GetItem(i));
		}
		this.RefreshStar(this.Data);
	}

	// Token: 0x060062D5 RID: 25301 RVA: 0x00135A70 File Offset: 0x00133C70
	protected override void OnBeforeDestroy()
	{
		if (this.StarArray != null)
		{
			this.StarArray.Clear();
			this.StarArray = null;
		}
		if (this.Data != null)
		{
			this.Data = null;
		}
	}

	// Token: 0x060062D6 RID: 25302 RVA: 0x00135A9C File Offset: 0x00133C9C
	public void RefreshStar(AchievementData data)
	{
		this.StarArray.ForEach(delegate(UUIItem value)
		{
			value.SetUIActive(false);
		});
		if (data.IfSingleAchievement())
		{
			if (data.CanShowStarState())
			{
				for (int i = 0; i < this.StarCount; i++)
				{
					this.StarArray[i].SetUIActive(true);
				}
				return;
			}
		}
		else
		{
			int achievementShowStar = data.GetAchievementShowStar();
			for (int j = 0; j < achievementShowStar; j++)
			{
				this.StarArray[j].SetUIActive(true);
			}
		}
	}

	// Token: 0x060062D7 RID: 25303 RVA: 0x00135B2C File Offset: 0x00133D2C
	private string GetStarName(int count)
	{
		if (count == 1)
		{
			return EAchievementStarEnum.SingleStar.ToString();
		}
		if (count == 2)
		{
			return EAchievementStarEnum.DoubleStar.ToString();
		}
		return EAchievementStarEnum.TripleStar.ToString();
	}

	// Token: 0x04002CCD RID: 11469
	private readonly int StarCount;

	// Token: 0x04002CCE RID: 11470
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<UUIItem> StarArray = new List<UUIItem>();

	// Token: 0x04002CCF RID: 11471
	[Nullable(2)]
	private AchievementData Data;

	// Token: 0x04002CD0 RID: 11472
	public UniTask? CreateAndShowTask;
}

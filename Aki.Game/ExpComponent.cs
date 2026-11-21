using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000CDB RID: 3291
[NullableContext(1)]
[Nullable(0)]
public class ExpComponent : UiPanelBase
{
	// Token: 0x0600892E RID: 35118 RVA: 0x0029955B File Offset: 0x0029775B
	public ExpComponent(UUIItem uiItem, bool IsAddUp = false)
	{
		this.IsAddUp = IsAddUp;
		this.SourceItem = uiItem;
	}

	// Token: 0x0600892F RID: 35119 RVA: 0x0029957C File Offset: 0x0029777C
	public void Init()
	{
		base.CreateThenShowByActor(this.SourceItem.GetOwner(), null);
	}

	// Token: 0x06008930 RID: 35120 RVA: 0x00299590 File Offset: 0x00297790
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUISprite)),
			new ValueTuple<int, Type>(6, typeof(UUISprite)),
			new ValueTuple<int, Type>(7, typeof(UUISprite)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIItem))
		};
	}

	// Token: 0x06008931 RID: 35121 RVA: 0x00299688 File Offset: 0x00297888
	protected override void OnStart()
	{
		base.GetSprite(6).SetFillAmount(0f);
		base.GetSprite(5).SetFillAmount(0f);
		base.GetSprite(7).SetFillAmount(0f);
		this.ExpTweenComponent = new ExpTweenComponent(base.GetSprite(6), base.GetSprite(5), base.GetSprite(7), null, this.ExpTweenFinish);
	}

	// Token: 0x06008932 RID: 35122 RVA: 0x002996EF File Offset: 0x002978EF
	public void SetLevelFormatText(string levelText)
	{
		this.LevelFormatText = levelText;
	}

	// Token: 0x06008933 RID: 35123 RVA: 0x002996F8 File Offset: 0x002978F8
	public void PlayExpTween(SelectableExpData expData)
	{
		int num = 1;
		float arrivedFillAmount = expData.GetArrivedFillAmount();
		int currentLevel = expData.GetCurrentLevel();
		while (currentLevel + num < expData.GetArrivedLevel())
		{
			num++;
		}
		if (num > 2)
		{
			num = 2;
		}
		if (arrivedFillAmount >= 1f)
		{
			num = 1;
		}
		this.ExpTweenComponent.PlayExpTween(num, arrivedFillAmount, 0f, LTweenEase.Linear);
	}

	// Token: 0x06008934 RID: 35124 RVA: 0x0029974C File Offset: 0x0029794C
	public void UpdateInitState(SelectableExpData expData)
	{
		if (!StringUtils.IsEmpty(this.LevelFormatText))
		{
			LguiUtil.Instance.SetLocalText(base.GetText(0), this.LevelFormatText, new <>z__ReadOnlySingleElementList<object>(expData.GetCurrentLevel().ToString()));
		}
		else
		{
			base.GetText(0).SetText(expData.GetCurrentLevel().ToString(), true);
		}
		this.ExpTweenComponent.SetCurrentSpriteActive(true);
		this.ExpTweenComponent.SetNextSpriteActive(false);
		this.SetNextLevelActive(false);
		base.GetText(2).SetUIActive(false);
		this.SetMaxItemActive(expData.GetArrivedLevel() == expData.GetCurrentMaxLevel());
		if (expData.GetCurrentLevel() == expData.GetCurrentMaxLevel())
		{
			this.ExpTweenComponent.SetCurrentFillAmount(1f);
			this.ExpTweenComponent.SetAddFillAmount(1f);
			int maxExp = expData.GetMaxExp(expData.GetCurrentLevel() - 1);
			LguiUtil.Instance.SetLocalText(base.GetText(3), "ExpShow", new <>z__ReadOnlyArray<object>(new object[]
			{
				maxExp,
				maxExp
			}));
		}
		else
		{
			int num = expData.StageMaxExp(expData.GetCurrentLevel());
			float num2 = (float)expData.GetCurrentExp() / (float)num;
			this.ExpTweenComponent.SetCurrentFillAmount(num2);
			this.ExpTweenComponent.SetAddFillAmount(num2);
			int maxExp2 = expData.GetMaxExp(expData.GetCurrentLevel());
			int num3 = expData.GetIsAddUp() ? (expData.AddUpMaxExp(expData.GetCurrentLevel() - 1) + expData.GetCurrentExp()) : expData.GetCurrentExp();
			LguiUtil.Instance.SetLocalText(base.GetText(3), "ExpShow", new <>z__ReadOnlyArray<object>(new object[]
			{
				num3,
				maxExp2
			}));
		}
		this.LastTimePreviewLevel = expData.GetArrivedLevel();
	}

	// Token: 0x06008935 RID: 35125 RVA: 0x00299908 File Offset: 0x00297B08
	public void Update(SelectableExpData expData, bool needPreviewTween = true)
	{
		base.GetText(2).SetText("+" + Math.Floor((double)expData.GetCurrentAddExp()).ToString(), true);
		base.GetText(2).SetUIActive(expData.GetCurrentAddExp() > 0f);
		if (expData.GetIfNext())
		{
			this.UpdateExpWithLevelUp(expData, needPreviewTween);
			return;
		}
		this.UpdateCurrentExp(expData, needPreviewTween);
	}

	// Token: 0x06008936 RID: 35126 RVA: 0x00299972 File Offset: 0x00297B72
	private void UpdateExpWithLevelUp(SelectableExpData expData, bool needPreviewTween = true)
	{
		this.SetNextLevel(expData.GetArrivedLevel());
		this.SetMaxItemActive(expData.GetArrivedLevel() == expData.GetCurrentMaxLevel());
		if (needPreviewTween)
		{
			this.PlayPreviewExp(expData);
			return;
		}
		this.UpdateNextExpState(expData.GetArrivedFillAmount());
	}

	// Token: 0x06008937 RID: 35127 RVA: 0x002999AB File Offset: 0x00297BAB
	private void UpdateCurrentExp(SelectableExpData expData, bool needPreviewTween = true)
	{
		this.SetNextLevelActive(false);
		this.SetMaxItemActive(expData.GetArrivedLevel() == expData.GetCurrentMaxLevel());
		if (needPreviewTween)
		{
			this.PlayPreviewExp(expData);
			return;
		}
		this.UpdateCurrentExpState(expData.GetArrivedFillAmount());
	}

	// Token: 0x06008938 RID: 35128 RVA: 0x002999DF File Offset: 0x00297BDF
	protected void UpdateNextExpState(float fillAmount)
	{
		this.ExpTweenComponent.SetCurrentSpriteActive(false);
		this.ExpTweenComponent.SetAddFillAmount(1f);
		this.ExpTweenComponent.SetNextSpriteActive(true);
		this.ExpTweenComponent.SetNextFillAmount(fillAmount);
	}

	// Token: 0x06008939 RID: 35129 RVA: 0x00299A15 File Offset: 0x00297C15
	protected void SetMaxItemActive(bool bActive)
	{
		base.GetItem(8).SetUIActive(bActive);
	}

	// Token: 0x0600893A RID: 35130 RVA: 0x00299A24 File Offset: 0x00297C24
	private void PlayPreviewExp(SelectableExpData expData)
	{
		this.ExpTweenComponent.PlayPreviewExpTween(expData.GetCurrentLevel(), this.LastTimePreviewLevel, expData.GetArrivedLevel(), expData.GetCurrentMaxLevel(), expData.GetArrivedFillAmount());
		this.LastTimePreviewLevel = expData.GetArrivedLevel();
	}

	// Token: 0x0600893B RID: 35131 RVA: 0x00299A5B File Offset: 0x00297C5B
	public void BindPlayCompleteCallBack(Action<bool> callback)
	{
		this.ExpTweenComponent.BindPlayCompleteCallBack(callback);
	}

	// Token: 0x0600893C RID: 35132 RVA: 0x00299A69 File Offset: 0x00297C69
	protected void UpdateCurrentExpState(float fillAmount)
	{
		this.ExpTweenComponent.SetCurrentSpriteActive(true);
		this.ExpTweenComponent.SetAddFillAmount(fillAmount);
		this.ExpTweenComponent.SetNextSpriteActive(false);
	}

	// Token: 0x0600893D RID: 35133 RVA: 0x00299A8F File Offset: 0x00297C8F
	private void SetNextLevelActive(bool bActive)
	{
		if (!bActive)
		{
			base.GetText(1).SetText("", true);
		}
		base.GetItem(4).SetUIActive(bActive);
	}

	// Token: 0x0600893E RID: 35134 RVA: 0x00299AB4 File Offset: 0x00297CB4
	private void SetNextLevel(int nextLevel)
	{
		this.SetNextLevelActive(true);
		if (!StringUtils.IsEmpty(this.LevelFormatText))
		{
			LguiUtil.Instance.SetLocalText(base.GetText(1), this.LevelFormatText, new <>z__ReadOnlySingleElementList<object>(nextLevel.ToString()));
			return;
		}
		base.GetText(1).SetText(nextLevel.ToString(), true);
	}

	// Token: 0x0600893F RID: 35135 RVA: 0x00299B0D File Offset: 0x00297D0D
	public void SetLevelItemShowState(bool state)
	{
		this.SetArrowShowState(state);
		this.SetAfterTextShowState(state);
	}

	// Token: 0x06008940 RID: 35136 RVA: 0x00299B1D File Offset: 0x00297D1D
	public void SetArrowShowState(bool state)
	{
		base.GetItem(4).SetUIActive(state);
	}

	// Token: 0x06008941 RID: 35137 RVA: 0x00299B2C File Offset: 0x00297D2C
	public void SetAfterTextShowState(bool state)
	{
		base.GetText(1).SetUIActive(state);
	}

	// Token: 0x06008942 RID: 35138 RVA: 0x00299B3B File Offset: 0x00297D3B
	public void RefreshSingleText(string text)
	{
		LguiUtil.Instance.SetLocalText(base.GetText(0), text, Array.Empty<object>());
	}

	// Token: 0x06008943 RID: 35139 RVA: 0x00299B54 File Offset: 0x00297D54
	protected override void OnBeforeDestroy()
	{
		this.ExpTweenComponent.Destroy();
	}

	// Token: 0x04005282 RID: 21122
	[Nullable(2)]
	protected ExpTweenComponent ExpTweenComponent;

	// Token: 0x04005283 RID: 21123
	private string LevelFormatText = "";

	// Token: 0x04005284 RID: 21124
	[Nullable(2)]
	private readonly UUIItem SourceItem;

	// Token: 0x04005285 RID: 21125
	protected bool IsAddUp;

	// Token: 0x04005286 RID: 21126
	[Nullable(2)]
	private readonly Action ExpTweenFinish;

	// Token: 0x04005287 RID: 21127
	private int LastTimePreviewLevel;

	// Token: 0x02006F96 RID: 28566
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402473B RID: 149307
		CurrentLevelText,
		// Token: 0x0402473C RID: 149308
		NextLevelText,
		// Token: 0x0402473D RID: 149309
		AddExpText,
		// Token: 0x0402473E RID: 149310
		IncreaseExpText,
		// Token: 0x0402473F RID: 149311
		ArrowItem,
		// Token: 0x04024740 RID: 149312
		AddExpSprite,
		// Token: 0x04024741 RID: 149313
		CurrentExpSprite,
		// Token: 0x04024742 RID: 149314
		AniSprite,
		// Token: 0x04024743 RID: 149315
		MaxSprite,
		// Token: 0x04024744 RID: 149316
		LevelItem
	}
}

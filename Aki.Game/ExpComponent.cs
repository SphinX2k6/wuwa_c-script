using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001822 RID: 6178
[NullableContext(1)]
[Nullable(0)]
public class ExpComponent : UiPanelBase
{
	// Token: 0x0600B543 RID: 46403 RVA: 0x0028EE3B File Offset: 0x0028D03B
	public ExpComponent(UUIItem uiItem, bool IsAddUp = false)
	{
		this.IsAddUp = IsAddUp;
		this.SourceItem = uiItem;
	}

	// Token: 0x0600B544 RID: 46404 RVA: 0x0028EE5C File Offset: 0x0028D05C
	public void Init()
	{
		base.CreateThenShowByActor(this.SourceItem.GetOwner(), null);
	}

	// Token: 0x0600B545 RID: 46405 RVA: 0x0028EE70 File Offset: 0x0028D070
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

	// Token: 0x0600B546 RID: 46406 RVA: 0x0028EF68 File Offset: 0x0028D168
	protected override void OnStart()
	{
		base.GetSprite(6).SetFillAmount(0f);
		base.GetSprite(5).SetFillAmount(0f);
		base.GetSprite(7).SetFillAmount(0f);
		this.ExpTweenComponent = new ExpTweenComponent(base.GetSprite(6), base.GetSprite(5), base.GetSprite(7), null, this.ExpTweenFinish);
	}

	// Token: 0x0600B547 RID: 46407 RVA: 0x0028EFCF File Offset: 0x0028D1CF
	public void SetLevelFormatText(string levelText)
	{
		this.LevelFormatText = levelText;
	}

	// Token: 0x0600B548 RID: 46408 RVA: 0x0028EFD8 File Offset: 0x0028D1D8
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

	// Token: 0x0600B549 RID: 46409 RVA: 0x0028F02C File Offset: 0x0028D22C
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

	// Token: 0x0600B54A RID: 46410 RVA: 0x0028F1E8 File Offset: 0x0028D3E8
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

	// Token: 0x0600B54B RID: 46411 RVA: 0x0028F252 File Offset: 0x0028D452
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

	// Token: 0x0600B54C RID: 46412 RVA: 0x0028F28B File Offset: 0x0028D48B
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

	// Token: 0x0600B54D RID: 46413 RVA: 0x0028F2BF File Offset: 0x0028D4BF
	protected void UpdateNextExpState(float fillAmount)
	{
		this.ExpTweenComponent.SetCurrentSpriteActive(false);
		this.ExpTweenComponent.SetAddFillAmount(1f);
		this.ExpTweenComponent.SetNextSpriteActive(true);
		this.ExpTweenComponent.SetNextFillAmount(fillAmount);
	}

	// Token: 0x0600B54E RID: 46414 RVA: 0x0028F2F5 File Offset: 0x0028D4F5
	protected void SetMaxItemActive(bool bActive)
	{
		base.GetItem(8).SetUIActive(bActive);
	}

	// Token: 0x0600B54F RID: 46415 RVA: 0x0028F304 File Offset: 0x0028D504
	private void PlayPreviewExp(SelectableExpData expData)
	{
		this.ExpTweenComponent.PlayPreviewExpTween(expData.GetCurrentLevel(), this.LastTimePreviewLevel, expData.GetArrivedLevel(), expData.GetCurrentMaxLevel(), expData.GetArrivedFillAmount());
		this.LastTimePreviewLevel = expData.GetArrivedLevel();
	}

	// Token: 0x0600B550 RID: 46416 RVA: 0x0028F33B File Offset: 0x0028D53B
	public void BindPlayCompleteCallBack(Action<bool> callback)
	{
		this.ExpTweenComponent.BindPlayCompleteCallBack(callback);
	}

	// Token: 0x0600B551 RID: 46417 RVA: 0x0028F349 File Offset: 0x0028D549
	protected void UpdateCurrentExpState(float fillAmount)
	{
		this.ExpTweenComponent.SetCurrentSpriteActive(true);
		this.ExpTweenComponent.SetAddFillAmount(fillAmount);
		this.ExpTweenComponent.SetNextSpriteActive(false);
	}

	// Token: 0x0600B552 RID: 46418 RVA: 0x0028F36F File Offset: 0x0028D56F
	private void SetNextLevelActive(bool bActive)
	{
		if (!bActive)
		{
			base.GetText(1).SetText("", true);
		}
		base.GetItem(4).SetUIActive(bActive);
	}

	// Token: 0x0600B553 RID: 46419 RVA: 0x0028F394 File Offset: 0x0028D594
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

	// Token: 0x0600B554 RID: 46420 RVA: 0x0028F3ED File Offset: 0x0028D5ED
	public void SetLevelItemShowState(bool state)
	{
		this.SetArrowShowState(state);
		this.SetAfterTextShowState(state);
	}

	// Token: 0x0600B555 RID: 46421 RVA: 0x0028F3FD File Offset: 0x0028D5FD
	public void SetArrowShowState(bool state)
	{
		base.GetItem(4).SetUIActive(state);
	}

	// Token: 0x0600B556 RID: 46422 RVA: 0x0028F40C File Offset: 0x0028D60C
	public void SetAfterTextShowState(bool state)
	{
		base.GetText(1).SetUIActive(state);
	}

	// Token: 0x0600B557 RID: 46423 RVA: 0x0028F41B File Offset: 0x0028D61B
	public void RefreshSingleText(string text)
	{
		LguiUtil.Instance.SetLocalText(base.GetText(0), text, Array.Empty<object>());
	}

	// Token: 0x0600B558 RID: 46424 RVA: 0x0028F434 File Offset: 0x0028D634
	protected override void OnBeforeDestroy()
	{
		this.ExpTweenComponent.Destroy();
	}

	// Token: 0x040051D7 RID: 20951
	[Nullable(2)]
	protected ExpTweenComponent ExpTweenComponent;

	// Token: 0x040051D8 RID: 20952
	private string LevelFormatText = "";

	// Token: 0x040051D9 RID: 20953
	[Nullable(2)]
	private readonly UUIItem SourceItem;

	// Token: 0x040051DA RID: 20954
	protected bool IsAddUp;

	// Token: 0x040051DB RID: 20955
	[Nullable(2)]
	private readonly Action ExpTweenFinish;

	// Token: 0x040051DC RID: 20956
	private int LastTimePreviewLevel;

	// Token: 0x02007E10 RID: 32272
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x04029410 RID: 168976
		CurrentLevelText,
		// Token: 0x04029411 RID: 168977
		NextLevelText,
		// Token: 0x04029412 RID: 168978
		AddExpText,
		// Token: 0x04029413 RID: 168979
		IncreaseExpText,
		// Token: 0x04029414 RID: 168980
		ArrowItem,
		// Token: 0x04029415 RID: 168981
		AddExpSprite,
		// Token: 0x04029416 RID: 168982
		CurrentExpSprite,
		// Token: 0x04029417 RID: 168983
		AniSprite,
		// Token: 0x04029418 RID: 168984
		MaxSprite,
		// Token: 0x04029419 RID: 168985
		LevelItem
	}
}

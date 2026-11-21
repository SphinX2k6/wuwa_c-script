using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020003FD RID: 1021
[NullableContext(1)]
[Nullable(0)]
public class DrinksPlayProxy
{
	// Token: 0x06003748 RID: 14152 RVA: 0x001423FA File Offset: 0x001405FA
	public void RegisterMainView(DrinksGamePlayMainView view)
	{
		this.MainView = view;
	}

	// Token: 0x06003749 RID: 14153 RVA: 0x00142403 File Offset: 0x00140603
	public void UpdateGameStep(bool start)
	{
		if (start)
		{
			this.MainView.OnGameCurrentStepStart();
			return;
		}
		this.MainView.OnGameCurrentStepEnd();
	}

	// Token: 0x0600374A RID: 14154 RVA: 0x0014241F File Offset: 0x0014061F
	public void OnDrinkBaseSelected(int drinkId, bool isEnd)
	{
		this.MainView.OnDrinkBaseSelected(drinkId, isEnd);
	}

	// Token: 0x0600374B RID: 14155 RVA: 0x0014242E File Offset: 0x0014062E
	public void OnBatchingSelected(HashSet<int> batchingSet, bool isEnd)
	{
		this.MainView.OnBatchingSelected(batchingSet, isEnd);
	}

	// Token: 0x0600374C RID: 14156 RVA: 0x0014243D File Offset: 0x0014063D
	public void OnNoBatchingConfirm()
	{
		this.MainView.OnNoBatchingConfirm();
	}

	// Token: 0x0600374D RID: 14157 RVA: 0x0014244A File Offset: 0x0014064A
	public void OnOrnamentSelected(bool isEnd)
	{
		this.MainView.OnOrnamentSelected(isEnd);
	}

	// Token: 0x0600374E RID: 14158 RVA: 0x00142458 File Offset: 0x00140658
	public void OnEnterDrinkBaseQTE()
	{
		this.MainView.OnEnterDrinkBaseQTE();
	}

	// Token: 0x0600374F RID: 14159 RVA: 0x00142465 File Offset: 0x00140665
	public void OnLevelSequenceBegin()
	{
		DrinksModel.Instance.GetSceneController().OnStepSequenceStart();
		this.UpdateRoleRequire();
		this.MainView.UpdateFlavorBubble();
	}

	// Token: 0x06003750 RID: 14160 RVA: 0x00142487 File Offset: 0x00140687
	public void UpdateRoleRequire()
	{
		this.MainView.UpdateRoleRequire();
	}

	// Token: 0x06003751 RID: 14161 RVA: 0x00142494 File Offset: 0x00140694
	public void ActivateDialogBubble(string config, bool isLike)
	{
		this.MainView.ActivateDialogBubble(config, isLike);
	}

	// Token: 0x06003752 RID: 14162 RVA: 0x001424A3 File Offset: 0x001406A3
	public void DeactivateDialogBubble()
	{
		this.MainView.DeactivateDialogBubble();
	}

	// Token: 0x06003753 RID: 14163 RVA: 0x001424B0 File Offset: 0x001406B0
	public void SetNeedTick(bool value)
	{
		this.MainView.SetNeedTickQTE(value);
		this.MainView.NeedTickQTE = value;
	}

	// Token: 0x06003754 RID: 14164 RVA: 0x001424CA File Offset: 0x001406CA
	public void OnFinishMixing()
	{
		this.MainView.OnFinishMixing();
	}

	// Token: 0x06003755 RID: 14165 RVA: 0x001424D7 File Offset: 0x001406D7
	public void OnFinishMixingEnd()
	{
		this.MainView.OnFinishMixingEnd();
	}

	// Token: 0x06003756 RID: 14166 RVA: 0x001424E4 File Offset: 0x001406E4
	public int BackToPrev(EDrinksPlayStep curStep)
	{
		return this.MainView.ShowBackMask(curStep);
	}

	// Token: 0x06003757 RID: 14167 RVA: 0x001424F2 File Offset: 0x001406F2
	public void SetShakeCamera(ACameraActor camera)
	{
		this.MainView.SetShakeCamera(camera);
	}

	// Token: 0x06003758 RID: 14168 RVA: 0x00142500 File Offset: 0x00140700
	public void HideClose()
	{
		this.MainView.HideCaptionClose();
	}

	// Token: 0x04002DDD RID: 11741
	protected DrinksGamePlayMainView MainView;
}

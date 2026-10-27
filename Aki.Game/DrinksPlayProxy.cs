using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02000F48 RID: 3912
[NullableContext(1)]
[Nullable(0)]
public class DrinksPlayProxy
{
	// Token: 0x060063B0 RID: 25520 RVA: 0x00139B2E File Offset: 0x00137D2E
	public void RegisterMainView(DrinksGamePlayMainView view)
	{
		this.MainView = view;
	}

	// Token: 0x060063B1 RID: 25521 RVA: 0x00139B37 File Offset: 0x00137D37
	public void UpdateGameStep(bool start)
	{
		if (start)
		{
			this.MainView.OnGameCurrentStepStart();
			return;
		}
		this.MainView.OnGameCurrentStepEnd();
	}

	// Token: 0x060063B2 RID: 25522 RVA: 0x00139B53 File Offset: 0x00137D53
	public void OnDrinkBaseSelected(int drinkId, bool isEnd)
	{
		this.MainView.OnDrinkBaseSelected(drinkId, isEnd);
	}

	// Token: 0x060063B3 RID: 25523 RVA: 0x00139B62 File Offset: 0x00137D62
	public void OnBatchingSelected(HashSet<int> batchingSet, bool isEnd)
	{
		this.MainView.OnBatchingSelected(batchingSet, isEnd);
	}

	// Token: 0x060063B4 RID: 25524 RVA: 0x00139B71 File Offset: 0x00137D71
	public void OnNoBatchingConfirm()
	{
		this.MainView.OnNoBatchingConfirm();
	}

	// Token: 0x060063B5 RID: 25525 RVA: 0x00139B7E File Offset: 0x00137D7E
	public void OnOrnamentSelected(bool isEnd)
	{
		this.MainView.OnOrnamentSelected(isEnd);
	}

	// Token: 0x060063B6 RID: 25526 RVA: 0x00139B8C File Offset: 0x00137D8C
	public void OnEnterDrinkBaseQTE()
	{
		this.MainView.OnEnterDrinkBaseQTE();
	}

	// Token: 0x060063B7 RID: 25527 RVA: 0x00139B99 File Offset: 0x00137D99
	public void OnLevelSequenceBegin()
	{
		DrinksModel.Instance.GetSceneController().OnStepSequenceStart();
		this.UpdateRoleRequire();
		this.MainView.UpdateFlavorBubble();
	}

	// Token: 0x060063B8 RID: 25528 RVA: 0x00139BBB File Offset: 0x00137DBB
	public void UpdateRoleRequire()
	{
		this.MainView.UpdateRoleRequire();
	}

	// Token: 0x060063B9 RID: 25529 RVA: 0x00139BC8 File Offset: 0x00137DC8
	public void ActivateDialogBubble(string config, bool isLike)
	{
		this.MainView.ActivateDialogBubble(config, isLike);
	}

	// Token: 0x060063BA RID: 25530 RVA: 0x00139BD7 File Offset: 0x00137DD7
	public void DeactivateDialogBubble()
	{
		this.MainView.DeactivateDialogBubble();
	}

	// Token: 0x060063BB RID: 25531 RVA: 0x00139BE4 File Offset: 0x00137DE4
	public void SetNeedTick(bool value)
	{
		this.MainView.SetNeedTickQTE(value);
		this.MainView.NeedTickQTE = value;
	}

	// Token: 0x060063BC RID: 25532 RVA: 0x00139BFE File Offset: 0x00137DFE
	public void OnFinishMixing()
	{
		this.MainView.OnFinishMixing();
	}

	// Token: 0x060063BD RID: 25533 RVA: 0x00139C0B File Offset: 0x00137E0B
	public void OnFinishMixingEnd()
	{
		this.MainView.OnFinishMixingEnd();
	}

	// Token: 0x060063BE RID: 25534 RVA: 0x00139C18 File Offset: 0x00137E18
	public int BackToPrev(EDrinksPlayStep curStep)
	{
		return this.MainView.ShowBackMask(curStep);
	}

	// Token: 0x060063BF RID: 25535 RVA: 0x00139C26 File Offset: 0x00137E26
	public void SetShakeCamera(ACameraActor camera)
	{
		this.MainView.SetShakeCamera(camera);
	}

	// Token: 0x060063C0 RID: 25536 RVA: 0x00139C34 File Offset: 0x00137E34
	public void HideClose()
	{
		this.MainView.HideCaptionClose();
	}

	// Token: 0x04002D44 RID: 11588
	protected DrinksGamePlayMainView MainView;
}

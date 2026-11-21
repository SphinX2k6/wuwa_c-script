using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;

// Token: 0x02000FDB RID: 4059
[NullableContext(1)]
[Nullable(0)]
public abstract class FloroRanchUiItemBaseComponent : FloroRanchEntityComponentBase
{
	// Token: 0x0600A1FC RID: 41468
	public abstract FloroRanchUiItemBase GetUiItem();

	// Token: 0x0600A1FD RID: 41469
	[return: Nullable(new byte[]
	{
		0,
		2
	})]
	public abstract UniTask<FloroRanchUiItemBase> PlayShowAnim();

	// Token: 0x0600A1FE RID: 41470
	[return: Nullable(new byte[]
	{
		0,
		2
	})]
	public abstract UniTask<FloroRanchUiItemBase> CreateUiItem();

	// Token: 0x0600A1FF RID: 41471
	public abstract UniTask PlayHideAnim();

	// Token: 0x0600A200 RID: 41472
	public abstract UniTask PlayNormalAnim();

	// Token: 0x0600A201 RID: 41473 RVA: 0x002F95FD File Offset: 0x002F77FD
	public virtual UniTask ShowUiItem()
	{
		return UniTask.CompletedTask;
	}

	// Token: 0x0600A202 RID: 41474 RVA: 0x002F9604 File Offset: 0x002F7804
	public virtual UniTask HideUiItem()
	{
		return UniTask.CompletedTask;
	}

	// Token: 0x0600A203 RID: 41475 RVA: 0x002F960B File Offset: 0x002F780B
	public virtual void Pause()
	{
	}

	// Token: 0x0600A204 RID: 41476 RVA: 0x002F960D File Offset: 0x002F780D
	public virtual void Resume()
	{
	}

	// Token: 0x0600A205 RID: 41477 RVA: 0x002F960F File Offset: 0x002F780F
	public virtual void Exit()
	{
	}

	// Token: 0x0600A206 RID: 41478 RVA: 0x002F9611 File Offset: 0x002F7811
	protected virtual void OnExit()
	{
		this.IsExit = true;
	}

	// Token: 0x0600A207 RID: 41479 RVA: 0x002F961A File Offset: 0x002F781A
	public bool CheckIsExit()
	{
		return this.IsExit;
	}

	// Token: 0x0600A208 RID: 41480 RVA: 0x002F9622 File Offset: 0x002F7822
	public virtual UniTask MoveToTarget(FloroRanchUiItemBase uiItemBase)
	{
		return UniTask.CompletedTask;
	}

	// Token: 0x0600A209 RID: 41481 RVA: 0x002F9629 File Offset: 0x002F7829
	public virtual UniTask MoveToOriginalPosition()
	{
		return UniTask.CompletedTask;
	}

	// Token: 0x0600A20A RID: 41482 RVA: 0x002F9630 File Offset: 0x002F7830
	public virtual UniTask PlayEatAnim()
	{
		return UniTask.CompletedTask;
	}

	// Token: 0x0600A20B RID: 41483 RVA: 0x002F9637 File Offset: 0x002F7837
	public virtual UniTask PlayBeEatAnim()
	{
		return UniTask.CompletedTask;
	}

	// Token: 0x0600A20C RID: 41484 RVA: 0x002F963E File Offset: 0x002F783E
	public virtual UniTask PlaySacrificeAnim()
	{
		return UniTask.CompletedTask;
	}

	// Token: 0x0600A20D RID: 41485 RVA: 0x002F9645 File Offset: 0x002F7845
	public virtual UniTask PlayFusionHideAnim()
	{
		return UniTask.CompletedTask;
	}

	// Token: 0x0600A20E RID: 41486 RVA: 0x002F964C File Offset: 0x002F784C
	public virtual UniTask PlayFusionShowAnim()
	{
		return UniTask.CompletedTask;
	}

	// Token: 0x0600A20F RID: 41487 RVA: 0x002F9653 File Offset: 0x002F7853
	public virtual UniTask PlayEvolveUpAnim()
	{
		return UniTask.CompletedTask;
	}

	// Token: 0x0600A210 RID: 41488 RVA: 0x002F965A File Offset: 0x002F785A
	public virtual UniTask PlaySkillAnim()
	{
		return UniTask.CompletedTask;
	}

	// Token: 0x0600A211 RID: 41489 RVA: 0x002F9661 File Offset: 0x002F7861
	public virtual void PlayVideo()
	{
	}

	// Token: 0x04005F38 RID: 24376
	private bool IsExit;
}

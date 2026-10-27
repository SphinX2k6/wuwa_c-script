using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;

// Token: 0x02001B1C RID: 6940
[NullableContext(1)]
[Nullable(0)]
public abstract class FloroRanchUiItemBaseComponent : FloroRanchEntityComponentBase
{
	// Token: 0x0600CDEB RID: 52715
	public abstract FloroRanchUiItemBase GetUiItem();

	// Token: 0x0600CDEC RID: 52716
	[return: Nullable(new byte[]
	{
		0,
		2
	})]
	public abstract UniTask<FloroRanchUiItemBase> PlayShowAnim();

	// Token: 0x0600CDED RID: 52717
	[return: Nullable(new byte[]
	{
		0,
		2
	})]
	public abstract UniTask<FloroRanchUiItemBase> CreateUiItem();

	// Token: 0x0600CDEE RID: 52718
	public abstract UniTask PlayHideAnim();

	// Token: 0x0600CDEF RID: 52719
	public abstract UniTask PlayNormalAnim();

	// Token: 0x0600CDF0 RID: 52720 RVA: 0x002EE51D File Offset: 0x002EC71D
	public virtual UniTask ShowUiItem()
	{
		return UniTask.CompletedTask;
	}

	// Token: 0x0600CDF1 RID: 52721 RVA: 0x002EE524 File Offset: 0x002EC724
	public virtual UniTask HideUiItem()
	{
		return UniTask.CompletedTask;
	}

	// Token: 0x0600CDF2 RID: 52722 RVA: 0x002EE52B File Offset: 0x002EC72B
	public virtual void Pause()
	{
	}

	// Token: 0x0600CDF3 RID: 52723 RVA: 0x002EE52D File Offset: 0x002EC72D
	public virtual void Resume()
	{
	}

	// Token: 0x0600CDF4 RID: 52724 RVA: 0x002EE52F File Offset: 0x002EC72F
	public virtual void Exit()
	{
	}

	// Token: 0x0600CDF5 RID: 52725 RVA: 0x002EE531 File Offset: 0x002EC731
	protected virtual void OnExit()
	{
		this.IsExit = true;
	}

	// Token: 0x0600CDF6 RID: 52726 RVA: 0x002EE53A File Offset: 0x002EC73A
	public bool CheckIsExit()
	{
		return this.IsExit;
	}

	// Token: 0x0600CDF7 RID: 52727 RVA: 0x002EE542 File Offset: 0x002EC742
	public virtual UniTask MoveToTarget(FloroRanchUiItemBase uiItemBase)
	{
		return UniTask.CompletedTask;
	}

	// Token: 0x0600CDF8 RID: 52728 RVA: 0x002EE549 File Offset: 0x002EC749
	public virtual UniTask MoveToOriginalPosition()
	{
		return UniTask.CompletedTask;
	}

	// Token: 0x0600CDF9 RID: 52729 RVA: 0x002EE550 File Offset: 0x002EC750
	public virtual UniTask PlayEatAnim()
	{
		return UniTask.CompletedTask;
	}

	// Token: 0x0600CDFA RID: 52730 RVA: 0x002EE557 File Offset: 0x002EC757
	public virtual UniTask PlayBeEatAnim()
	{
		return UniTask.CompletedTask;
	}

	// Token: 0x0600CDFB RID: 52731 RVA: 0x002EE55E File Offset: 0x002EC75E
	public virtual UniTask PlaySacrificeAnim()
	{
		return UniTask.CompletedTask;
	}

	// Token: 0x0600CDFC RID: 52732 RVA: 0x002EE565 File Offset: 0x002EC765
	public virtual UniTask PlayFusionHideAnim()
	{
		return UniTask.CompletedTask;
	}

	// Token: 0x0600CDFD RID: 52733 RVA: 0x002EE56C File Offset: 0x002EC76C
	public virtual UniTask PlayFusionShowAnim()
	{
		return UniTask.CompletedTask;
	}

	// Token: 0x0600CDFE RID: 52734 RVA: 0x002EE573 File Offset: 0x002EC773
	public virtual UniTask PlayEvolveUpAnim()
	{
		return UniTask.CompletedTask;
	}

	// Token: 0x0600CDFF RID: 52735 RVA: 0x002EE57A File Offset: 0x002EC77A
	public virtual UniTask PlaySkillAnim()
	{
		return UniTask.CompletedTask;
	}

	// Token: 0x0600CE00 RID: 52736 RVA: 0x002EE581 File Offset: 0x002EC781
	public virtual void PlayVideo()
	{
	}

	// Token: 0x04005E69 RID: 24169
	private bool IsExit;
}

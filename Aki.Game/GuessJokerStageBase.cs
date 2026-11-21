using System;
using System.Runtime.CompilerServices;

// Token: 0x020004F3 RID: 1267
[NullableContext(1)]
[Nullable(0)]
public class GuessJokerStageBase
{
	// Token: 0x06003E52 RID: 15954 RVA: 0x00160472 File Offset: 0x0015E672
	public GuessJokerStageBase(GuessJokerStageFsm stageFsm)
	{
		this.StageFsm = stageFsm;
	}

	// Token: 0x06003E53 RID: 15955 RVA: 0x00160481 File Offset: 0x0015E681
	public void Create()
	{
		this.OnCreate();
	}

	// Token: 0x06003E54 RID: 15956 RVA: 0x0016048C File Offset: 0x0015E68C
	public void Enter()
	{
		this.IsActive = true;
		this.OnEnter();
		this.OnAddEventListener();
		Log.Instance.Info(ELogModule.GuessJokerCard, ELogAuthor.LRC, "Enter " + base.GetType().Name + " stage", default(ReadOnlySpan<ValueTuple<string, object>>));
	}

	// Token: 0x06003E55 RID: 15957 RVA: 0x001604E0 File Offset: 0x0015E6E0
	public void Tick(float deltaTime)
	{
		if (!this.IsActive)
		{
			return;
		}
		this.OnTick(deltaTime);
	}

	// Token: 0x06003E56 RID: 15958 RVA: 0x001604F4 File Offset: 0x0015E6F4
	public void Exit()
	{
		this.OnRemoveEventListener();
		this.OnExit();
		this.IsActive = false;
		Log.Instance.Info(ELogModule.GuessJokerCard, ELogAuthor.LRC, "Exit " + base.GetType().Name + " stage", default(ReadOnlySpan<ValueTuple<string, object>>));
	}

	// Token: 0x06003E57 RID: 15959 RVA: 0x00160548 File Offset: 0x0015E748
	protected virtual void OnCreate()
	{
	}

	// Token: 0x06003E58 RID: 15960 RVA: 0x0016054A File Offset: 0x0015E74A
	protected virtual void OnEnter()
	{
	}

	// Token: 0x06003E59 RID: 15961 RVA: 0x0016054C File Offset: 0x0015E74C
	protected virtual void OnAddEventListener()
	{
	}

	// Token: 0x06003E5A RID: 15962 RVA: 0x0016054E File Offset: 0x0015E74E
	protected virtual void OnTick(float deltaTime)
	{
	}

	// Token: 0x06003E5B RID: 15963 RVA: 0x00160550 File Offset: 0x0015E750
	protected virtual void OnRemoveEventListener()
	{
	}

	// Token: 0x06003E5C RID: 15964 RVA: 0x00160552 File Offset: 0x0015E752
	protected virtual void OnExit()
	{
	}

	// Token: 0x040031CC RID: 12748
	protected bool IsActive;

	// Token: 0x040031CD RID: 12749
	protected GuessJokerStageFsm StageFsm;
}

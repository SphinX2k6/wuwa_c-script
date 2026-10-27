using System;
using System.Runtime.CompilerServices;

// Token: 0x0200103F RID: 4159
[NullableContext(1)]
[Nullable(0)]
public class GuessJokerStageBase
{
	// Token: 0x06006ABD RID: 27325 RVA: 0x00157B4A File Offset: 0x00155D4A
	public GuessJokerStageBase(GuessJokerStageFsm stageFsm)
	{
		this.StageFsm = stageFsm;
	}

	// Token: 0x06006ABE RID: 27326 RVA: 0x00157B59 File Offset: 0x00155D59
	public void Create()
	{
		this.OnCreate();
	}

	// Token: 0x06006ABF RID: 27327 RVA: 0x00157B64 File Offset: 0x00155D64
	public void Enter()
	{
		this.IsActive = true;
		this.OnEnter();
		this.OnAddEventListener();
		Log.Instance.Info(ELogModule.GuessJokerCard, ELogAuthor.LRC, "Enter " + base.GetType().Name + " stage", default(ReadOnlySpan<ValueTuple<string, object>>));
	}

	// Token: 0x06006AC0 RID: 27328 RVA: 0x00157BB8 File Offset: 0x00155DB8
	public void Tick(float deltaTime)
	{
		if (!this.IsActive)
		{
			return;
		}
		this.OnTick(deltaTime);
	}

	// Token: 0x06006AC1 RID: 27329 RVA: 0x00157BCC File Offset: 0x00155DCC
	public void Exit()
	{
		this.OnRemoveEventListener();
		this.OnExit();
		this.IsActive = false;
		Log.Instance.Info(ELogModule.GuessJokerCard, ELogAuthor.LRC, "Exit " + base.GetType().Name + " stage", default(ReadOnlySpan<ValueTuple<string, object>>));
	}

	// Token: 0x06006AC2 RID: 27330 RVA: 0x00157C20 File Offset: 0x00155E20
	protected virtual void OnCreate()
	{
	}

	// Token: 0x06006AC3 RID: 27331 RVA: 0x00157C22 File Offset: 0x00155E22
	protected virtual void OnEnter()
	{
	}

	// Token: 0x06006AC4 RID: 27332 RVA: 0x00157C24 File Offset: 0x00155E24
	protected virtual void OnAddEventListener()
	{
	}

	// Token: 0x06006AC5 RID: 27333 RVA: 0x00157C26 File Offset: 0x00155E26
	protected virtual void OnTick(float deltaTime)
	{
	}

	// Token: 0x06006AC6 RID: 27334 RVA: 0x00157C28 File Offset: 0x00155E28
	protected virtual void OnRemoveEventListener()
	{
	}

	// Token: 0x06006AC7 RID: 27335 RVA: 0x00157C2A File Offset: 0x00155E2A
	protected virtual void OnExit()
	{
	}

	// Token: 0x04003133 RID: 12595
	protected bool IsActive;

	// Token: 0x04003134 RID: 12596
	protected GuessJokerStageFsm StageFsm;
}

using System;
using System.Runtime.CompilerServices;

// Token: 0x02001B51 RID: 6993
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchStateBase
{
	// Token: 0x0600CF76 RID: 53110 RVA: 0x002F42B7 File Offset: 0x002F24B7
	public FloroRanchStateBase(FloroRanchStageFsm stageFsm)
	{
		this.StageFsm = stageFsm;
	}

	// Token: 0x0600CF77 RID: 53111 RVA: 0x002F42C6 File Offset: 0x002F24C6
	public void Create()
	{
		this.OnCreate();
	}

	// Token: 0x0600CF78 RID: 53112 RVA: 0x002F42CE File Offset: 0x002F24CE
	public void Enter()
	{
		this.IsActive = true;
		this.OnEnter();
		this.OnAddEventListener();
	}

	// Token: 0x0600CF79 RID: 53113 RVA: 0x002F42E3 File Offset: 0x002F24E3
	public void Tick(float deltaTime)
	{
		if (!this.IsActive)
		{
			return;
		}
		this.OnTick(deltaTime);
	}

	// Token: 0x0600CF7A RID: 53114 RVA: 0x002F42F5 File Offset: 0x002F24F5
	public void Exit()
	{
		this.OnRemoveEventListener();
		this.OnExit();
		this.IsActive = false;
	}

	// Token: 0x0600CF7B RID: 53115 RVA: 0x002F430A File Offset: 0x002F250A
	protected virtual void OnCreate()
	{
	}

	// Token: 0x0600CF7C RID: 53116 RVA: 0x002F430C File Offset: 0x002F250C
	protected virtual void OnEnter()
	{
	}

	// Token: 0x0600CF7D RID: 53117 RVA: 0x002F430E File Offset: 0x002F250E
	protected virtual void OnAddEventListener()
	{
	}

	// Token: 0x0600CF7E RID: 53118 RVA: 0x002F4310 File Offset: 0x002F2510
	protected virtual void OnTick(float deltaTime)
	{
	}

	// Token: 0x0600CF7F RID: 53119 RVA: 0x002F4312 File Offset: 0x002F2512
	protected virtual void OnRemoveEventListener()
	{
	}

	// Token: 0x0600CF80 RID: 53120 RVA: 0x002F4314 File Offset: 0x002F2514
	protected virtual void OnExit()
	{
	}

	// Token: 0x0600CF81 RID: 53121 RVA: 0x002F4316 File Offset: 0x002F2516
	public void ForceExit()
	{
		this.IsForceExit = true;
		this.AutoExitAfterEnter = true;
	}

	// Token: 0x04005F6E RID: 24430
	protected bool IsActive;

	// Token: 0x04005F6F RID: 24431
	protected bool AutoExitAfterEnter;

	// Token: 0x04005F70 RID: 24432
	protected bool IsForceExit;

	// Token: 0x04005F71 RID: 24433
	protected FloroRanchStageFsm StageFsm;
}

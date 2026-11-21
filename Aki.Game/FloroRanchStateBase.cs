using System;
using System.Runtime.CompilerServices;

// Token: 0x02001010 RID: 4112
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchStateBase
{
	// Token: 0x0600A387 RID: 41863 RVA: 0x002FF38F File Offset: 0x002FD58F
	public FloroRanchStateBase(FloroRanchStageFsm stageFsm)
	{
		this.StageFsm = stageFsm;
	}

	// Token: 0x0600A388 RID: 41864 RVA: 0x002FF39E File Offset: 0x002FD59E
	public void Create()
	{
		this.OnCreate();
	}

	// Token: 0x0600A389 RID: 41865 RVA: 0x002FF3A6 File Offset: 0x002FD5A6
	public void Enter()
	{
		this.IsActive = true;
		this.OnEnter();
		this.OnAddEventListener();
	}

	// Token: 0x0600A38A RID: 41866 RVA: 0x002FF3BB File Offset: 0x002FD5BB
	public void Tick(float deltaTime)
	{
		if (!this.IsActive)
		{
			return;
		}
		this.OnTick(deltaTime);
	}

	// Token: 0x0600A38B RID: 41867 RVA: 0x002FF3CD File Offset: 0x002FD5CD
	public void Exit()
	{
		this.OnRemoveEventListener();
		this.OnExit();
		this.IsActive = false;
	}

	// Token: 0x0600A38C RID: 41868 RVA: 0x002FF3E2 File Offset: 0x002FD5E2
	protected virtual void OnCreate()
	{
	}

	// Token: 0x0600A38D RID: 41869 RVA: 0x002FF3E4 File Offset: 0x002FD5E4
	protected virtual void OnEnter()
	{
	}

	// Token: 0x0600A38E RID: 41870 RVA: 0x002FF3E6 File Offset: 0x002FD5E6
	protected virtual void OnAddEventListener()
	{
	}

	// Token: 0x0600A38F RID: 41871 RVA: 0x002FF3E8 File Offset: 0x002FD5E8
	protected virtual void OnTick(float deltaTime)
	{
	}

	// Token: 0x0600A390 RID: 41872 RVA: 0x002FF3EA File Offset: 0x002FD5EA
	protected virtual void OnRemoveEventListener()
	{
	}

	// Token: 0x0600A391 RID: 41873 RVA: 0x002FF3EC File Offset: 0x002FD5EC
	protected virtual void OnExit()
	{
	}

	// Token: 0x0600A392 RID: 41874 RVA: 0x002FF3EE File Offset: 0x002FD5EE
	public void ForceExit()
	{
		this.IsForceExit = true;
		this.AutoExitAfterEnter = true;
	}

	// Token: 0x0400603D RID: 24637
	protected bool IsActive;

	// Token: 0x0400603E RID: 24638
	protected bool AutoExitAfterEnter;

	// Token: 0x0400603F RID: 24639
	protected bool IsForceExit;

	// Token: 0x04006040 RID: 24640
	protected FloroRanchStageFsm StageFsm;
}

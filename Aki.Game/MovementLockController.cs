using System;
using System.Runtime.CompilerServices;

// Token: 0x020017B4 RID: 6068
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class MovementLockController : ControllerBase
{
	// Token: 0x0600EC8D RID: 60557 RVA: 0x004574EA File Offset: 0x004556EA
	protected override bool OnLeaveLevel()
	{
		if (this.LockMode != EMovementLockMode.None)
		{
			this.Unlock();
		}
		return true;
	}

	// Token: 0x0600EC8E RID: 60558 RVA: 0x004574FB File Offset: 0x004556FB
	public void Lock(EMovementLockMode lockMode)
	{
		if (this.LockMode != EMovementLockMode.None)
		{
			this.Unlock();
		}
		if (lockMode == EMovementLockMode.All)
		{
			UeMovementTickController.SetTickManageMode(EMovementManageMode.None);
		}
		else if (lockMode == EMovementLockMode.StreamingSource)
		{
			UeMovementTickController.SetTickManageMode(EMovementManageMode.TickWithDistance);
		}
		this.LockMode = lockMode;
	}

	// Token: 0x0600EC8F RID: 60559 RVA: 0x00457528 File Offset: 0x00455728
	public void Unlock()
	{
		if (this.LockMode == EMovementLockMode.None)
		{
			return;
		}
		UeMovementTickController.SetTickManageMode(EMovementManageMode.Default);
		this.LockMode = EMovementLockMode.None;
	}

	// Token: 0x1700167F RID: 5759
	// (get) Token: 0x0600EC90 RID: 60560 RVA: 0x00457540 File Offset: 0x00455740
	public static MovementLockController Instance
	{
		get
		{
			return MovementLockController._Instance;
		}
	}

	// Token: 0x0600EC91 RID: 60561 RVA: 0x00457547 File Offset: 0x00455747
	public static MovementLockController GetOrCreateInstance()
	{
		if (MovementLockController._Instance == null)
		{
			MovementLockController.CreateInstance();
		}
		return MovementLockController._Instance;
	}

	// Token: 0x0600EC92 RID: 60562 RVA: 0x0045755B File Offset: 0x0045575B
	public static bool CreateInstance()
	{
		if (MovementLockController._Instance != null)
		{
			return true;
		}
		MovementLockController._Instance = new MovementLockController();
		return true;
	}

	// Token: 0x0600EC93 RID: 60563 RVA: 0x00457571 File Offset: 0x00455771
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600EC94 RID: 60564 RVA: 0x00457573 File Offset: 0x00455773
	public static void ResetStaticDefaultValue()
	{
		MovementLockController._Instance = null;
	}

	// Token: 0x0600EC95 RID: 60565 RVA: 0x0045757B File Offset: 0x0045577B
	static MovementLockController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(MovementLockController.CreateStaticDefaultValue), new Action(MovementLockController.ResetStaticDefaultValue));
	}

	// Token: 0x04008616 RID: 34326
	public EMovementLockMode LockMode;

	// Token: 0x04008617 RID: 34327
	[Nullable(2)]
	private static MovementLockController _Instance;
}

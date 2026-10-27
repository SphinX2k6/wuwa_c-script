using System;
using System.Runtime.CompilerServices;

// Token: 0x020022D0 RID: 8912
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class MovementLockController : ControllerBase
{
	// Token: 0x060117F6 RID: 71670 RVA: 0x0044A7C2 File Offset: 0x004489C2
	protected override bool OnLeaveLevel()
	{
		if (this.LockMode != EMovementLockMode.None)
		{
			this.Unlock();
		}
		return true;
	}

	// Token: 0x060117F7 RID: 71671 RVA: 0x0044A7D3 File Offset: 0x004489D3
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
			GameBudgetController.Instance.OpenStreamingSourceMode();
		}
		this.LockMode = lockMode;
	}

	// Token: 0x060117F8 RID: 71672 RVA: 0x0044A80A File Offset: 0x00448A0A
	public void Unlock()
	{
		if (this.LockMode == EMovementLockMode.None)
		{
			return;
		}
		if (this.LockMode == EMovementLockMode.StreamingSource)
		{
			GameBudgetController.Instance.CloseStreamingSourceMode();
		}
		UeMovementTickController.SetTickManageMode(EMovementManageMode.Default);
		this.LockMode = EMovementLockMode.None;
	}

	// Token: 0x17001648 RID: 5704
	// (get) Token: 0x060117F9 RID: 71673 RVA: 0x0044A835 File Offset: 0x00448A35
	public static MovementLockController Instance
	{
		get
		{
			return MovementLockController._Instance;
		}
	}

	// Token: 0x060117FA RID: 71674 RVA: 0x0044A83C File Offset: 0x00448A3C
	public static MovementLockController GetOrCreateInstance()
	{
		if (MovementLockController._Instance == null)
		{
			MovementLockController.CreateInstance();
		}
		return MovementLockController._Instance;
	}

	// Token: 0x060117FB RID: 71675 RVA: 0x0044A850 File Offset: 0x00448A50
	public static bool CreateInstance()
	{
		if (MovementLockController._Instance != null)
		{
			return true;
		}
		MovementLockController._Instance = new MovementLockController();
		return true;
	}

	// Token: 0x060117FC RID: 71676 RVA: 0x0044A866 File Offset: 0x00448A66
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060117FD RID: 71677 RVA: 0x0044A868 File Offset: 0x00448A68
	public static void ResetStaticDefaultValue()
	{
		MovementLockController._Instance = null;
	}

	// Token: 0x060117FE RID: 71678 RVA: 0x0044A870 File Offset: 0x00448A70
	static MovementLockController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(MovementLockController.CreateStaticDefaultValue), new Action(MovementLockController.ResetStaticDefaultValue));
	}

	// Token: 0x040084D8 RID: 34008
	public EMovementLockMode LockMode;

	// Token: 0x040084D9 RID: 34009
	[Nullable(2)]
	private static MovementLockController _Instance;
}

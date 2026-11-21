using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02000C37 RID: 3127
[NullableContext(1)]
[Nullable(0)]
public class CdKeyInputController : UiControllerBase
{
	// Token: 0x060082BC RID: 33468 RVA: 0x002825F8 File Offset: 0x002807F8
	private void StartCdKeyUseCoolDown()
	{
		this.CdKeyCdFlag = true;
		this.CdKeyCdCountTime = 0f;
		this.CdKeyCdTimerId = TimerSystem.GameplayTimeInstance.Forever(new TTimerAction(this.OnCdKeyUseCdRefresh), (float)TimeUtil.Instance.InverseMillisecond, 1f, null, null, true);
	}

	// Token: 0x060082BD RID: 33469 RVA: 0x00282646 File Offset: 0x00280846
	private void OnCdKeyUseCdRefresh(float delta)
	{
		this.CdKeyCdCountTime += delta;
		if (this.CdKeyCdCountTime >= 5000f)
		{
			this.ResetCdKeyUseTimer();
		}
	}

	// Token: 0x060082BE RID: 33470 RVA: 0x00282669 File Offset: 0x00280869
	private void ResetCdKeyUseTimer()
	{
		if (TimerSystem.GameplayTimeInstance.Has(this.CdKeyCdTimerId))
		{
			TimerSystem.GameplayTimeInstance.Remove(this.CdKeyCdTimerId);
		}
		this.CdKeyCdFlag = false;
		this.CdKeyCdCountTime = 0f;
		this.CdKeyCdTimerId = null;
	}

	// Token: 0x060082BF RID: 33471 RVA: 0x002826A7 File Offset: 0x002808A7
	protected override bool OnClear()
	{
		this.ResetCdKeyUseTimer();
		return true;
	}

	// Token: 0x060082C0 RID: 33472 RVA: 0x002826B0 File Offset: 0x002808B0
	public bool CheckInCdKeyUseCd()
	{
		return this.CdKeyCdFlag;
	}

	// Token: 0x060082C1 RID: 33473 RVA: 0x002826B8 File Offset: 0x002808B8
	public static int GetCdKeyUseCd()
	{
		double val = Math.Ceiling((double)((5000f - CdKeyInputController.Instance.CdKeyCdCountTime) / (float)TimeUtil.Instance.InverseMillisecond));
		return (int)Math.Max(1.0, val);
	}

	// Token: 0x060082C2 RID: 33474 RVA: 0x002826FC File Offset: 0x002808FC
	[NullableContext(0)]
	public UniTask<ErrorCode?> RequestCdKey([Nullable(1)] string cdKeyString)
	{
		CdKeyInputController.<RequestCdKey>d__10 <RequestCdKey>d__;
		<RequestCdKey>d__.<>t__builder = AsyncUniTaskMethodBuilder<ErrorCode?>.Create();
		<RequestCdKey>d__.<>4__this = this;
		<RequestCdKey>d__.cdKeyString = cdKeyString;
		<RequestCdKey>d__.<>1__state = -1;
		<RequestCdKey>d__.<>t__builder.Start<CdKeyInputController.<RequestCdKey>d__10>(ref <RequestCdKey>d__);
		return <RequestCdKey>d__.<>t__builder.Task;
	}

	// Token: 0x17000EA3 RID: 3747
	// (get) Token: 0x060082C3 RID: 33475 RVA: 0x00282747 File Offset: 0x00280947
	public static CdKeyInputController Instance
	{
		get
		{
			return CdKeyInputController._Instance;
		}
	}

	// Token: 0x060082C4 RID: 33476 RVA: 0x0028274E File Offset: 0x0028094E
	public static CdKeyInputController GetOrCreateInstance()
	{
		if (CdKeyInputController._Instance == null)
		{
			CdKeyInputController.CreateInstance();
		}
		return CdKeyInputController._Instance;
	}

	// Token: 0x060082C5 RID: 33477 RVA: 0x00282762 File Offset: 0x00280962
	public static bool CreateInstance()
	{
		if (CdKeyInputController._Instance != null)
		{
			return true;
		}
		CdKeyInputController._Instance = new CdKeyInputController();
		return true;
	}

	// Token: 0x060082C6 RID: 33478 RVA: 0x00282778 File Offset: 0x00280978
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060082C7 RID: 33479 RVA: 0x0028277A File Offset: 0x0028097A
	public static void ResetStaticDefaultValue()
	{
		CdKeyInputController._Instance = null;
	}

	// Token: 0x060082C8 RID: 33480 RVA: 0x00282782 File Offset: 0x00280982
	static CdKeyInputController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(CdKeyInputController.CreateStaticDefaultValue), new Action(CdKeyInputController.ResetStaticDefaultValue));
	}

	// Token: 0x04005008 RID: 20488
	private const int CDKEY_USE_INTERVAL = 5000;

	// Token: 0x04005009 RID: 20489
	[Nullable(2)]
	private TimerHandle CdKeyCdTimerId;

	// Token: 0x0400500A RID: 20490
	private bool CdKeyCdFlag;

	// Token: 0x0400500B RID: 20491
	private float CdKeyCdCountTime;

	// Token: 0x0400500C RID: 20492
	[Nullable(2)]
	private static CdKeyInputController _Instance;
}

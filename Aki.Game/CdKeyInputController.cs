using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x0200177E RID: 6014
[NullableContext(1)]
[Nullable(0)]
public class CdKeyInputController : UiControllerBase
{
	// Token: 0x0600AED5 RID: 44757 RVA: 0x00278134 File Offset: 0x00276334
	private void StartCdKeyUseCoolDown()
	{
		this.CdKeyCdFlag = true;
		this.CdKeyCdCountTime = 0f;
		this.CdKeyCdTimerId = TimerSystem.GameplayTimeInstance.Forever(new TTimerAction(this.OnCdKeyUseCdRefresh), (float)TimeUtil.Instance.InverseMillisecond, 1f, null, null, true);
	}

	// Token: 0x0600AED6 RID: 44758 RVA: 0x00278182 File Offset: 0x00276382
	private void OnCdKeyUseCdRefresh(float delta)
	{
		this.CdKeyCdCountTime += delta;
		if (this.CdKeyCdCountTime >= 5000f)
		{
			this.ResetCdKeyUseTimer();
		}
	}

	// Token: 0x0600AED7 RID: 44759 RVA: 0x002781A5 File Offset: 0x002763A5
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

	// Token: 0x0600AED8 RID: 44760 RVA: 0x002781E3 File Offset: 0x002763E3
	protected override bool OnClear()
	{
		this.ResetCdKeyUseTimer();
		return true;
	}

	// Token: 0x0600AED9 RID: 44761 RVA: 0x002781EC File Offset: 0x002763EC
	public bool CheckInCdKeyUseCd()
	{
		return this.CdKeyCdFlag;
	}

	// Token: 0x0600AEDA RID: 44762 RVA: 0x002781F4 File Offset: 0x002763F4
	public static int GetCdKeyUseCd()
	{
		double val = Math.Ceiling((double)((5000f - CdKeyInputController.Instance.CdKeyCdCountTime) / (float)TimeUtil.Instance.InverseMillisecond));
		return (int)Math.Max(1.0, val);
	}

	// Token: 0x0600AEDB RID: 44763 RVA: 0x00278238 File Offset: 0x00276438
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

	// Token: 0x17000E80 RID: 3712
	// (get) Token: 0x0600AEDC RID: 44764 RVA: 0x00278283 File Offset: 0x00276483
	public static CdKeyInputController Instance
	{
		get
		{
			return CdKeyInputController._Instance;
		}
	}

	// Token: 0x0600AEDD RID: 44765 RVA: 0x0027828A File Offset: 0x0027648A
	public static CdKeyInputController GetOrCreateInstance()
	{
		if (CdKeyInputController._Instance == null)
		{
			CdKeyInputController.CreateInstance();
		}
		return CdKeyInputController._Instance;
	}

	// Token: 0x0600AEDE RID: 44766 RVA: 0x0027829E File Offset: 0x0027649E
	public static bool CreateInstance()
	{
		if (CdKeyInputController._Instance != null)
		{
			return true;
		}
		CdKeyInputController._Instance = new CdKeyInputController();
		return true;
	}

	// Token: 0x0600AEDF RID: 44767 RVA: 0x002782B4 File Offset: 0x002764B4
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600AEE0 RID: 44768 RVA: 0x002782B6 File Offset: 0x002764B6
	public static void ResetStaticDefaultValue()
	{
		CdKeyInputController._Instance = null;
	}

	// Token: 0x0600AEE1 RID: 44769 RVA: 0x002782BE File Offset: 0x002764BE
	static CdKeyInputController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(CdKeyInputController.CreateStaticDefaultValue), new Action(CdKeyInputController.ResetStaticDefaultValue));
	}

	// Token: 0x04004F5E RID: 20318
	private const int CDKEY_USE_INTERVAL = 5000;

	// Token: 0x04004F5F RID: 20319
	[Nullable(2)]
	private TimerHandle CdKeyCdTimerId;

	// Token: 0x04004F60 RID: 20320
	private bool CdKeyCdFlag;

	// Token: 0x04004F61 RID: 20321
	private float CdKeyCdCountTime;

	// Token: 0x04004F62 RID: 20322
	[Nullable(2)]
	private static CdKeyInputController _Instance;
}

using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x02002C4D RID: 11341
[NullableContext(1)]
[Nullable(0)]
public class UiCameraController : UiControllerBase
{
	// Token: 0x06017A84 RID: 96900 RVA: 0x00605081 File Offset: 0x00603281
	protected override bool OnInit()
	{
		UiCameraManager.Initialize();
		return true;
	}

	// Token: 0x06017A85 RID: 96901 RVA: 0x00605089 File Offset: 0x00603289
	protected override bool OnClear()
	{
		UiCameraManager.Clear();
		return true;
	}

	// Token: 0x06017A86 RID: 96902 RVA: 0x00605091 File Offset: 0x00603291
	protected override bool OnLeaveLevel()
	{
		UiCameraManager.Clear();
		return true;
	}

	// Token: 0x17001FC9 RID: 8137
	// (get) Token: 0x06017A87 RID: 96903 RVA: 0x00605099 File Offset: 0x00603299
	public static UiCameraController Instance
	{
		get
		{
			return UiCameraController._Instance;
		}
	}

	// Token: 0x06017A88 RID: 96904 RVA: 0x006050A0 File Offset: 0x006032A0
	public static UiCameraController GetOrCreateInstance()
	{
		if (UiCameraController._Instance == null)
		{
			UiCameraController.CreateInstance();
		}
		return UiCameraController._Instance;
	}

	// Token: 0x06017A89 RID: 96905 RVA: 0x006050B4 File Offset: 0x006032B4
	public static bool CreateInstance()
	{
		if (UiCameraController._Instance != null)
		{
			return true;
		}
		UiCameraController._Instance = new UiCameraController();
		return true;
	}

	// Token: 0x06017A8A RID: 96906 RVA: 0x006050CA File Offset: 0x006032CA
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06017A8B RID: 96907 RVA: 0x006050CC File Offset: 0x006032CC
	public static void ResetStaticDefaultValue()
	{
		UiCameraController._Instance = null;
	}

	// Token: 0x06017A8C RID: 96908 RVA: 0x006050D4 File Offset: 0x006032D4
	static UiCameraController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(UiCameraController.CreateStaticDefaultValue), new Action(UiCameraController.ResetStaticDefaultValue));
	}

	// Token: 0x0400B063 RID: 45155
	[Nullable(2)]
	private static UiCameraController _Instance;
}

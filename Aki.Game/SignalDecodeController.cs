using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x02002A09 RID: 10761
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class SignalDecodeController : ControllerBase
{
	// Token: 0x0601655A RID: 91482 RVA: 0x005A7050 File Offset: 0x005A5250
	public void Open(string id)
	{
		SignalDecodeModel.Instance.GameplayStart(id);
		UiManager.Instance.OpenView(EUiViewName.SignalDecodeView, null, null);
	}

	// Token: 0x17001DCF RID: 7631
	// (get) Token: 0x0601655B RID: 91483 RVA: 0x005A706E File Offset: 0x005A526E
	public static SignalDecodeController Instance
	{
		get
		{
			return SignalDecodeController._Instance;
		}
	}

	// Token: 0x0601655C RID: 91484 RVA: 0x005A7075 File Offset: 0x005A5275
	public static SignalDecodeController GetOrCreateInstance()
	{
		if (SignalDecodeController._Instance == null)
		{
			SignalDecodeController.CreateInstance();
		}
		return SignalDecodeController._Instance;
	}

	// Token: 0x0601655D RID: 91485 RVA: 0x005A7089 File Offset: 0x005A5289
	public static bool CreateInstance()
	{
		if (SignalDecodeController._Instance != null)
		{
			return true;
		}
		SignalDecodeController._Instance = new SignalDecodeController();
		return true;
	}

	// Token: 0x0601655E RID: 91486 RVA: 0x005A709F File Offset: 0x005A529F
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601655F RID: 91487 RVA: 0x005A70A1 File Offset: 0x005A52A1
	public static void ResetStaticDefaultValue()
	{
		SignalDecodeController._Instance = null;
	}

	// Token: 0x06016560 RID: 91488 RVA: 0x005A70A9 File Offset: 0x005A52A9
	static SignalDecodeController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(SignalDecodeController.CreateStaticDefaultValue), new Action(SignalDecodeController.ResetStaticDefaultValue));
	}

	// Token: 0x0400A617 RID: 42519
	[Nullable(2)]
	private static SignalDecodeController _Instance;
}

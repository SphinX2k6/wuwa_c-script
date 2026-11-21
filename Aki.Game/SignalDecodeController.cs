using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x02001F84 RID: 8068
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class SignalDecodeController : ControllerBase
{
	// Token: 0x06013F61 RID: 81761 RVA: 0x005D2028 File Offset: 0x005D0228
	public void Open(string id)
	{
		SignalDecodeModel.Instance.GameplayStart(id);
		UiManager.Instance.OpenView(EUiViewName.SignalDecodeView, null, null);
	}

	// Token: 0x17001E28 RID: 7720
	// (get) Token: 0x06013F62 RID: 81762 RVA: 0x005D2046 File Offset: 0x005D0246
	public static SignalDecodeController Instance
	{
		get
		{
			return SignalDecodeController._Instance;
		}
	}

	// Token: 0x06013F63 RID: 81763 RVA: 0x005D204D File Offset: 0x005D024D
	public static SignalDecodeController GetOrCreateInstance()
	{
		if (SignalDecodeController._Instance == null)
		{
			SignalDecodeController.CreateInstance();
		}
		return SignalDecodeController._Instance;
	}

	// Token: 0x06013F64 RID: 81764 RVA: 0x005D2061 File Offset: 0x005D0261
	public static bool CreateInstance()
	{
		if (SignalDecodeController._Instance != null)
		{
			return true;
		}
		SignalDecodeController._Instance = new SignalDecodeController();
		return true;
	}

	// Token: 0x06013F65 RID: 81765 RVA: 0x005D2077 File Offset: 0x005D0277
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06013F66 RID: 81766 RVA: 0x005D2079 File Offset: 0x005D0279
	public static void ResetStaticDefaultValue()
	{
		SignalDecodeController._Instance = null;
	}

	// Token: 0x06013F67 RID: 81767 RVA: 0x005D2081 File Offset: 0x005D0281
	static SignalDecodeController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(SignalDecodeController.CreateStaticDefaultValue), new Action(SignalDecodeController.ResetStaticDefaultValue));
	}

	// Token: 0x0400AA01 RID: 43521
	[Nullable(2)]
	private static SignalDecodeController _Instance;
}

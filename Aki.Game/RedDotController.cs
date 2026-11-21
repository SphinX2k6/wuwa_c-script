using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x0200289D RID: 10397
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class RedDotController : ControllerBase
{
	// Token: 0x0601A5EE RID: 108014 RVA: 0x008286E2 File Offset: 0x008268E2
	protected override bool OnInit()
	{
		return true;
	}

	// Token: 0x0601A5EF RID: 108015 RVA: 0x008286E8 File Offset: 0x008268E8
	[NullableContext(2)]
	public void BindRedDot(ERedDotName name, UUIItem uiItem = null, Action<bool, int> stateChangeCallback = null, int uId = 0)
	{
		RedDotBase redDot = RedDotModel.Instance.GetRedDot(name);
		if (redDot == null)
		{
			return;
		}
		redDot.BindUi(uId, uiItem, stateChangeCallback);
	}

	// Token: 0x0601A5F0 RID: 108016 RVA: 0x00828710 File Offset: 0x00826910
	public void UnBindRedDot(ERedDotName name)
	{
		RedDotBase redDot = RedDotModel.Instance.GetRedDot(name);
		if (redDot == null)
		{
			return;
		}
		redDot.UnBindUi();
	}

	// Token: 0x0601A5F1 RID: 108017 RVA: 0x00828734 File Offset: 0x00826934
	public void UnBindRedDotAndClearData(ERedDotName name)
	{
		RedDotBase redDot = RedDotModel.Instance.GetRedDot(name);
		if (redDot == null)
		{
			return;
		}
		redDot.UnBindUiAndClearData();
	}

	// Token: 0x0601A5F2 RID: 108018 RVA: 0x00828758 File Offset: 0x00826958
	public void UnBindGivenUi(ERedDotName name, UUIItem uiItem = null, int uId = 0)
	{
		RedDotBase redDot = RedDotModel.Instance.GetRedDot(name);
		if (redDot == null)
		{
			return;
		}
		redDot.UnBindGivenUi(uId, uiItem);
	}

	// Token: 0x0601A5F3 RID: 108019 RVA: 0x00828780 File Offset: 0x00826980
	public void UnBindGivenUiAndDeleteData(ERedDotName name, UUIItem uiItem = null, int uId = 0)
	{
		RedDotBase redDot = RedDotModel.Instance.GetRedDot(name);
		if (redDot == null)
		{
			return;
		}
		redDot.UnBindGivenUiAndDeleteData(uId, uiItem);
	}

	// Token: 0x17002B3C RID: 11068
	// (get) Token: 0x0601A5F4 RID: 108020 RVA: 0x008287A5 File Offset: 0x008269A5
	public static RedDotController Instance
	{
		get
		{
			return RedDotController._Instance;
		}
	}

	// Token: 0x0601A5F5 RID: 108021 RVA: 0x008287AC File Offset: 0x008269AC
	public static RedDotController GetOrCreateInstance()
	{
		if (RedDotController._Instance == null)
		{
			RedDotController.CreateInstance();
		}
		return RedDotController._Instance;
	}

	// Token: 0x0601A5F6 RID: 108022 RVA: 0x008287C0 File Offset: 0x008269C0
	public static bool CreateInstance()
	{
		if (RedDotController._Instance != null)
		{
			return true;
		}
		RedDotController._Instance = new RedDotController();
		return true;
	}

	// Token: 0x0601A5F7 RID: 108023 RVA: 0x008287D6 File Offset: 0x008269D6
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601A5F8 RID: 108024 RVA: 0x008287D8 File Offset: 0x008269D8
	public static void ResetStaticDefaultValue()
	{
		RedDotController._Instance = null;
	}

	// Token: 0x0601A5F9 RID: 108025 RVA: 0x008287E0 File Offset: 0x008269E0
	static RedDotController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(RedDotController.CreateStaticDefaultValue), new Action(RedDotController.ResetStaticDefaultValue));
	}

	// Token: 0x0400E76F RID: 59247
	[Nullable(2)]
	private static RedDotController _Instance;
}

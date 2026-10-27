using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x0200332B RID: 13099
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class RedDotController : ControllerBase
{
	// Token: 0x0601C8F6 RID: 116982 RVA: 0x0080213E File Offset: 0x0080033E
	protected override bool OnInit()
	{
		return true;
	}

	// Token: 0x0601C8F7 RID: 116983 RVA: 0x00802144 File Offset: 0x00800344
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

	// Token: 0x0601C8F8 RID: 116984 RVA: 0x0080216C File Offset: 0x0080036C
	public void UnBindRedDot(ERedDotName name)
	{
		RedDotBase redDot = RedDotModel.Instance.GetRedDot(name);
		if (redDot == null)
		{
			return;
		}
		redDot.UnBindUi();
	}

	// Token: 0x0601C8F9 RID: 116985 RVA: 0x00802190 File Offset: 0x00800390
	public void UnBindRedDotAndClearData(ERedDotName name)
	{
		RedDotBase redDot = RedDotModel.Instance.GetRedDot(name);
		if (redDot == null)
		{
			return;
		}
		redDot.UnBindUiAndClearData();
	}

	// Token: 0x0601C8FA RID: 116986 RVA: 0x008021B4 File Offset: 0x008003B4
	public void UnBindGivenUi(ERedDotName name, UUIItem uiItem = null, int uId = 0)
	{
		RedDotBase redDot = RedDotModel.Instance.GetRedDot(name);
		if (redDot == null)
		{
			return;
		}
		redDot.UnBindGivenUi(uId, uiItem);
	}

	// Token: 0x0601C8FB RID: 116987 RVA: 0x008021DC File Offset: 0x008003DC
	public void UnBindGivenUiAndDeleteData(ERedDotName name, UUIItem uiItem = null, int uId = 0)
	{
		RedDotBase redDot = RedDotModel.Instance.GetRedDot(name);
		if (redDot == null)
		{
			return;
		}
		redDot.UnBindGivenUiAndDeleteData(uId, uiItem);
	}

	// Token: 0x170027A0 RID: 10144
	// (get) Token: 0x0601C8FC RID: 116988 RVA: 0x00802201 File Offset: 0x00800401
	public static RedDotController Instance
	{
		get
		{
			return RedDotController._Instance;
		}
	}

	// Token: 0x0601C8FD RID: 116989 RVA: 0x00802208 File Offset: 0x00800408
	public static RedDotController GetOrCreateInstance()
	{
		if (RedDotController._Instance == null)
		{
			RedDotController.CreateInstance();
		}
		return RedDotController._Instance;
	}

	// Token: 0x0601C8FE RID: 116990 RVA: 0x0080221C File Offset: 0x0080041C
	public static bool CreateInstance()
	{
		if (RedDotController._Instance != null)
		{
			return true;
		}
		RedDotController._Instance = new RedDotController();
		return true;
	}

	// Token: 0x0601C8FF RID: 116991 RVA: 0x00802232 File Offset: 0x00800432
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601C900 RID: 116992 RVA: 0x00802234 File Offset: 0x00800434
	public static void ResetStaticDefaultValue()
	{
		RedDotController._Instance = null;
	}

	// Token: 0x0601C901 RID: 116993 RVA: 0x0080223C File Offset: 0x0080043C
	static RedDotController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(RedDotController.CreateStaticDefaultValue), new Action(RedDotController.ResetStaticDefaultValue));
	}

	// Token: 0x0400E2BF RID: 58047
	[Nullable(2)]
	private static RedDotController _Instance;
}

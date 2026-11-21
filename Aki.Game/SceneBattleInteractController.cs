using System;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Framework;
using CSharpScript.Game.Module;

// Token: 0x02001EBC RID: 7868
[NullableContext(1)]
[Nullable(0)]
[TickController(2)]
public class SceneBattleInteractController : ControllerBase
{
	// Token: 0x06013716 RID: 79638 RVA: 0x005AB4F4 File Offset: 0x005A96F4
	protected override void OnTick(float delta)
	{
		if (!SceneBattleInteractModel.Instance.Open)
		{
			return;
		}
		foreach (SceneBattleInteractEffect sceneBattleInteractEffect in SceneBattleInteractModel.Instance.EffectMap.Values)
		{
			sceneBattleInteractEffect.OnTick(delta * Time.Instance.TimeDilation);
		}
	}

	// Token: 0x17001DA0 RID: 7584
	// (get) Token: 0x06013717 RID: 79639 RVA: 0x005AB568 File Offset: 0x005A9768
	public static SceneBattleInteractController Instance
	{
		get
		{
			return SceneBattleInteractController._Instance;
		}
	}

	// Token: 0x06013718 RID: 79640 RVA: 0x005AB56F File Offset: 0x005A976F
	public static SceneBattleInteractController GetOrCreateInstance()
	{
		if (SceneBattleInteractController._Instance == null)
		{
			SceneBattleInteractController.CreateInstance();
		}
		return SceneBattleInteractController._Instance;
	}

	// Token: 0x06013719 RID: 79641 RVA: 0x005AB583 File Offset: 0x005A9783
	public static bool CreateInstance()
	{
		if (SceneBattleInteractController._Instance != null)
		{
			return true;
		}
		SceneBattleInteractController._Instance = new SceneBattleInteractController();
		return true;
	}

	// Token: 0x0601371A RID: 79642 RVA: 0x005AB599 File Offset: 0x005A9799
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601371B RID: 79643 RVA: 0x005AB59B File Offset: 0x005A979B
	public static void ResetStaticDefaultValue()
	{
		SceneBattleInteractController._Instance = null;
	}

	// Token: 0x0601371C RID: 79644 RVA: 0x005AB5A3 File Offset: 0x005A97A3
	static SceneBattleInteractController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(SceneBattleInteractController.CreateStaticDefaultValue), new Action(SceneBattleInteractController.ResetStaticDefaultValue));
	}

	// Token: 0x0400A64D RID: 42573
	[Nullable(2)]
	private static SceneBattleInteractController _Instance;
}

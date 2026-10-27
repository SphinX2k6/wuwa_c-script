using System;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Framework;
using CSharpScript.Game.Module;

// Token: 0x02002941 RID: 10561
[NullableContext(1)]
[Nullable(0)]
[TickController(2)]
public class SceneBattleInteractController : ControllerBase
{
	// Token: 0x06015D12 RID: 89362 RVA: 0x005804F4 File Offset: 0x0057E6F4
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

	// Token: 0x17001D47 RID: 7495
	// (get) Token: 0x06015D13 RID: 89363 RVA: 0x00580568 File Offset: 0x0057E768
	public static SceneBattleInteractController Instance
	{
		get
		{
			return SceneBattleInteractController._Instance;
		}
	}

	// Token: 0x06015D14 RID: 89364 RVA: 0x0058056F File Offset: 0x0057E76F
	public static SceneBattleInteractController GetOrCreateInstance()
	{
		if (SceneBattleInteractController._Instance == null)
		{
			SceneBattleInteractController.CreateInstance();
		}
		return SceneBattleInteractController._Instance;
	}

	// Token: 0x06015D15 RID: 89365 RVA: 0x00580583 File Offset: 0x0057E783
	public static bool CreateInstance()
	{
		if (SceneBattleInteractController._Instance != null)
		{
			return true;
		}
		SceneBattleInteractController._Instance = new SceneBattleInteractController();
		return true;
	}

	// Token: 0x06015D16 RID: 89366 RVA: 0x00580599 File Offset: 0x0057E799
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06015D17 RID: 89367 RVA: 0x0058059B File Offset: 0x0057E79B
	public static void ResetStaticDefaultValue()
	{
		SceneBattleInteractController._Instance = null;
	}

	// Token: 0x06015D18 RID: 89368 RVA: 0x005805A3 File Offset: 0x0057E7A3
	static SceneBattleInteractController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(SceneBattleInteractController.CreateStaticDefaultValue), new Action(SceneBattleInteractController.ResetStaticDefaultValue));
	}

	// Token: 0x0400A263 RID: 41571
	[Nullable(2)]
	private static SceneBattleInteractController _Instance;
}

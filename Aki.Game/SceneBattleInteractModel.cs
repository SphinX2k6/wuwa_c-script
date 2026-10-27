using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Core.Fight;
using CSharpScript.Game.Module;

// Token: 0x02002945 RID: 10565
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class SceneBattleInteractModel : ModelBase
{
	// Token: 0x06015D1A RID: 89370 RVA: 0x005805CA File Offset: 0x0057E7CA
	protected override bool OnInit()
	{
		return true;
	}

	// Token: 0x06015D1B RID: 89371 RVA: 0x005805CD File Offset: 0x0057E7CD
	protected override bool OnClear()
	{
		this.ClearAllEffect();
		this.ClearAllConfig();
		SceneBattleInteractPool.Clear();
		return true;
	}

	// Token: 0x06015D1C RID: 89372 RVA: 0x005805E1 File Offset: 0x0057E7E1
	protected override bool OnLeaveLevel()
	{
		this.ClearAllEffect();
		this.ClearAllConfig();
		SceneBattleInteractPool.Clear();
		return true;
	}

	// Token: 0x06015D1D RID: 89373 RVA: 0x005805F8 File Offset: 0x0057E7F8
	[return: Nullable(2)]
	public SceneBattleInteractEffect CreateSceneBattleInteract(BP_SceneBattleInteract_C dataAsset, float radius = 0f, float halfHeight = 0f)
	{
		if (!this.Open)
		{
			return null;
		}
		SceneBattleInteractEffect sceneBattleInteractEffect = new SceneBattleInteractEffect();
		this.GenId++;
		sceneBattleInteractEffect.Id = this.GenId;
		sceneBattleInteractEffect.Init(dataAsset, radius, halfHeight);
		this.EffectMap[sceneBattleInteractEffect.Id] = sceneBattleInteractEffect;
		return sceneBattleInteractEffect;
	}

	// Token: 0x06015D1E RID: 89374 RVA: 0x0058064C File Offset: 0x0057E84C
	public void DestroySceneBattleInteract(int handleId)
	{
		SceneBattleInteractEffect sceneBattleInteractEffect;
		if (!this.EffectMap.TryGetValue(handleId, out sceneBattleInteractEffect))
		{
			return;
		}
		sceneBattleInteractEffect.Destroy();
		this.EffectMap.Remove(handleId);
	}

	// Token: 0x06015D1F RID: 89375 RVA: 0x00580680 File Offset: 0x0057E880
	public bool SetSceneBattleInteractEnable(int handleId, bool enable, float limitTime = 0f)
	{
		SceneBattleInteractEffect sceneBattleInteractEffect;
		if (!this.EffectMap.TryGetValue(handleId, out sceneBattleInteractEffect))
		{
			return false;
		}
		sceneBattleInteractEffect.SetEnable(enable, limitTime);
		return true;
	}

	// Token: 0x06015D20 RID: 89376 RVA: 0x005806A8 File Offset: 0x0057E8A8
	[NullableContext(2)]
	public SceneBattleInteractEffect GetSceneBattleInteract(int handleId)
	{
		SceneBattleInteractEffect result;
		if (this.EffectMap.TryGetValue(handleId, out result))
		{
			return result;
		}
		return null;
	}

	// Token: 0x06015D21 RID: 89377 RVA: 0x005806C8 File Offset: 0x0057E8C8
	[NullableContext(2)]
	public BP_SceneBattleInteract_C GetDefaultWeaponInteractConfig()
	{
		if (!this.Open)
		{
			return null;
		}
		if (this.DefaultWeaponInteractConfig == null)
		{
			this.DefaultWeaponInteractConfig = ResourceSystem.Instance.Load<BP_SceneBattleInteract_C>("/Game/Aki/Data/Fight/DA_WeaponSceneInteract.DA_WeaponSceneInteract", "js_undefined");
		}
		return this.DefaultWeaponInteractConfig;
	}

	// Token: 0x06015D22 RID: 89378 RVA: 0x005806FC File Offset: 0x0057E8FC
	[NullableContext(2)]
	public BP_SceneBattleInteract_C GetWeaponInteractConfig(int weaponType)
	{
		if (!this.Open)
		{
			return null;
		}
		if (weaponType <= 0)
		{
			return null;
		}
		BP_SceneBattleInteract_C bp_SceneBattleInteract_C;
		if (this.WeaponInteractConfigMap.TryGetValue(weaponType, out bp_SceneBattleInteract_C) && bp_SceneBattleInteract_C != null)
		{
			return bp_SceneBattleInteract_C;
		}
		WeaponSceneInteract? weaponSceneInteract;
		string text = (ConfigWeaponSceneInteractById.GetConfig(weaponType, true) != null) ? weaponSceneInteract.GetValueOrDefault().Path : null;
		if (text == null)
		{
			return null;
		}
		BP_SceneBattleInteract_C bp_SceneBattleInteract_C2 = ResourceSystem.Instance.Load<BP_SceneBattleInteract_C>(text, "js_undefined");
		this.WeaponInteractConfigMap[weaponType] = bp_SceneBattleInteract_C2;
		return bp_SceneBattleInteract_C2;
	}

	// Token: 0x17001D48 RID: 7496
	// (get) Token: 0x06015D23 RID: 89379 RVA: 0x00580777 File Offset: 0x0057E977
	// (set) Token: 0x06015D24 RID: 89380 RVA: 0x0058077F File Offset: 0x0057E97F
	public bool Open
	{
		get
		{
			return this.OpenInternal;
		}
		set
		{
			if (this.OpenInternal == value)
			{
				return;
			}
			this.OpenInternal = value;
			if (!this.OpenInternal)
			{
				this.ClearAllEffect();
			}
		}
	}

	// Token: 0x17001D49 RID: 7497
	// (get) Token: 0x06015D25 RID: 89381 RVA: 0x005807A0 File Offset: 0x0057E9A0
	// (set) Token: 0x06015D26 RID: 89382 RVA: 0x005807A8 File Offset: 0x0057E9A8
	public int Debug
	{
		get
		{
			return this.DebugInternal;
		}
		set
		{
			if (this.DebugInternal == value)
			{
				return;
			}
			this.DebugInternal = value;
			foreach (SceneBattleInteractEffect sceneBattleInteractEffect in this.EffectMap.Values)
			{
				sceneBattleInteractEffect.SetDebug(this.DebugInternal);
			}
		}
	}

	// Token: 0x06015D27 RID: 89383 RVA: 0x00580814 File Offset: 0x0057EA14
	private void ClearAllEffect()
	{
		foreach (SceneBattleInteractEffect sceneBattleInteractEffect in this.EffectMap.Values)
		{
			sceneBattleInteractEffect.Destroy();
		}
		this.EffectMap.Clear();
	}

	// Token: 0x06015D28 RID: 89384 RVA: 0x00580874 File Offset: 0x0057EA74
	private void ClearAllConfig()
	{
		this.DefaultWeaponInteractConfig = null;
		this.WeaponInteractConfigMap.Clear();
	}

	// Token: 0x06015D29 RID: 89385 RVA: 0x00580888 File Offset: 0x0057EA88
	public void RefreshIgnoreCommonWeapon(bool needIgnore)
	{
		if (needIgnore)
		{
			this.IgnoreCommonWeapon = true;
			return;
		}
		using (Dictionary<int, SceneBattleInteractEffect>.ValueCollection.Enumerator enumerator = this.EffectMap.Values.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.GetIgnoreCommonWeapon())
				{
					this.IgnoreCommonWeapon = true;
					return;
				}
			}
		}
		this.IgnoreCommonWeapon = false;
	}

	// Token: 0x17001D4A RID: 7498
	// (get) Token: 0x06015D2A RID: 89386 RVA: 0x005808FC File Offset: 0x0057EAFC
	public static SceneBattleInteractModel Instance
	{
		get
		{
			return SceneBattleInteractModel._Instance;
		}
	}

	// Token: 0x06015D2B RID: 89387 RVA: 0x00580903 File Offset: 0x0057EB03
	public static SceneBattleInteractModel GetOrCreateInstance()
	{
		if (SceneBattleInteractModel._Instance == null)
		{
			SceneBattleInteractModel.CreateInstance();
		}
		return SceneBattleInteractModel._Instance;
	}

	// Token: 0x06015D2C RID: 89388 RVA: 0x00580917 File Offset: 0x0057EB17
	public static bool CreateInstance()
	{
		if (SceneBattleInteractModel._Instance != null)
		{
			return true;
		}
		SceneBattleInteractModel._Instance = new SceneBattleInteractModel();
		return true;
	}

	// Token: 0x06015D2D RID: 89389 RVA: 0x0058092D File Offset: 0x0057EB2D
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06015D2E RID: 89390 RVA: 0x0058092F File Offset: 0x0057EB2F
	public static void ResetStaticDefaultValue()
	{
		SceneBattleInteractModel._Instance = null;
	}

	// Token: 0x06015D2F RID: 89391 RVA: 0x00580937 File Offset: 0x0057EB37
	static SceneBattleInteractModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(SceneBattleInteractModel.CreateStaticDefaultValue), new Action(SceneBattleInteractModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400A26E RID: 41582
	private int GenId;

	// Token: 0x0400A26F RID: 41583
	private bool OpenInternal;

	// Token: 0x0400A270 RID: 41584
	private int DebugInternal;

	// Token: 0x0400A271 RID: 41585
	public readonly Dictionary<int, SceneBattleInteractEffect> EffectMap = new Dictionary<int, SceneBattleInteractEffect>();

	// Token: 0x0400A272 RID: 41586
	[Nullable(2)]
	public BP_SceneBattleInteract_C DefaultWeaponInteractConfig;

	// Token: 0x0400A273 RID: 41587
	[Nullable(new byte[]
	{
		1,
		2
	})]
	public readonly Dictionary<int, BP_SceneBattleInteract_C> WeaponInteractConfigMap = new Dictionary<int, BP_SceneBattleInteract_C>();

	// Token: 0x0400A274 RID: 41588
	public bool IgnoreCommonWeapon;

	// Token: 0x0400A275 RID: 41589
	[Nullable(2)]
	private static SceneBattleInteractModel _Instance;
}

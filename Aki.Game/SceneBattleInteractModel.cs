using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Core.Fight;
using CSharpScript.Game.Module;

// Token: 0x02001EC0 RID: 7872
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class SceneBattleInteractModel : ModelBase
{
	// Token: 0x0601371E RID: 79646 RVA: 0x005AB5CA File Offset: 0x005A97CA
	protected override bool OnInit()
	{
		return true;
	}

	// Token: 0x0601371F RID: 79647 RVA: 0x005AB5CD File Offset: 0x005A97CD
	protected override bool OnClear()
	{
		this.ClearAllEffect();
		this.ClearAllConfig();
		SceneBattleInteractPool.Clear();
		return true;
	}

	// Token: 0x06013720 RID: 79648 RVA: 0x005AB5E1 File Offset: 0x005A97E1
	protected override bool OnLeaveLevel()
	{
		this.ClearAllEffect();
		this.ClearAllConfig();
		SceneBattleInteractPool.Clear();
		return true;
	}

	// Token: 0x06013721 RID: 79649 RVA: 0x005AB5F8 File Offset: 0x005A97F8
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

	// Token: 0x06013722 RID: 79650 RVA: 0x005AB64C File Offset: 0x005A984C
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

	// Token: 0x06013723 RID: 79651 RVA: 0x005AB680 File Offset: 0x005A9880
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

	// Token: 0x06013724 RID: 79652 RVA: 0x005AB6A8 File Offset: 0x005A98A8
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

	// Token: 0x06013725 RID: 79653 RVA: 0x005AB6C8 File Offset: 0x005A98C8
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

	// Token: 0x06013726 RID: 79654 RVA: 0x005AB6FC File Offset: 0x005A98FC
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

	// Token: 0x17001DA1 RID: 7585
	// (get) Token: 0x06013727 RID: 79655 RVA: 0x005AB777 File Offset: 0x005A9977
	// (set) Token: 0x06013728 RID: 79656 RVA: 0x005AB77F File Offset: 0x005A997F
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

	// Token: 0x17001DA2 RID: 7586
	// (get) Token: 0x06013729 RID: 79657 RVA: 0x005AB7A0 File Offset: 0x005A99A0
	// (set) Token: 0x0601372A RID: 79658 RVA: 0x005AB7A8 File Offset: 0x005A99A8
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

	// Token: 0x0601372B RID: 79659 RVA: 0x005AB814 File Offset: 0x005A9A14
	private void ClearAllEffect()
	{
		foreach (SceneBattleInteractEffect sceneBattleInteractEffect in this.EffectMap.Values)
		{
			sceneBattleInteractEffect.Destroy();
		}
		this.EffectMap.Clear();
	}

	// Token: 0x0601372C RID: 79660 RVA: 0x005AB874 File Offset: 0x005A9A74
	private void ClearAllConfig()
	{
		this.DefaultWeaponInteractConfig = null;
		this.WeaponInteractConfigMap.Clear();
	}

	// Token: 0x0601372D RID: 79661 RVA: 0x005AB888 File Offset: 0x005A9A88
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

	// Token: 0x17001DA3 RID: 7587
	// (get) Token: 0x0601372E RID: 79662 RVA: 0x005AB8FC File Offset: 0x005A9AFC
	public static SceneBattleInteractModel Instance
	{
		get
		{
			return SceneBattleInteractModel._Instance;
		}
	}

	// Token: 0x0601372F RID: 79663 RVA: 0x005AB903 File Offset: 0x005A9B03
	public static SceneBattleInteractModel GetOrCreateInstance()
	{
		if (SceneBattleInteractModel._Instance == null)
		{
			SceneBattleInteractModel.CreateInstance();
		}
		return SceneBattleInteractModel._Instance;
	}

	// Token: 0x06013730 RID: 79664 RVA: 0x005AB917 File Offset: 0x005A9B17
	public static bool CreateInstance()
	{
		if (SceneBattleInteractModel._Instance != null)
		{
			return true;
		}
		SceneBattleInteractModel._Instance = new SceneBattleInteractModel();
		return true;
	}

	// Token: 0x06013731 RID: 79665 RVA: 0x005AB92D File Offset: 0x005A9B2D
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06013732 RID: 79666 RVA: 0x005AB92F File Offset: 0x005A9B2F
	public static void ResetStaticDefaultValue()
	{
		SceneBattleInteractModel._Instance = null;
	}

	// Token: 0x06013733 RID: 79667 RVA: 0x005AB937 File Offset: 0x005A9B37
	static SceneBattleInteractModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(SceneBattleInteractModel.CreateStaticDefaultValue), new Action(SceneBattleInteractModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400A658 RID: 42584
	private int GenId;

	// Token: 0x0400A659 RID: 42585
	private bool OpenInternal;

	// Token: 0x0400A65A RID: 42586
	private int DebugInternal;

	// Token: 0x0400A65B RID: 42587
	public readonly Dictionary<int, SceneBattleInteractEffect> EffectMap = new Dictionary<int, SceneBattleInteractEffect>();

	// Token: 0x0400A65C RID: 42588
	[Nullable(2)]
	public BP_SceneBattleInteract_C DefaultWeaponInteractConfig;

	// Token: 0x0400A65D RID: 42589
	[Nullable(new byte[]
	{
		1,
		2
	})]
	public readonly Dictionary<int, BP_SceneBattleInteract_C> WeaponInteractConfigMap = new Dictionary<int, BP_SceneBattleInteract_C>();

	// Token: 0x0400A65E RID: 42590
	public bool IgnoreCommonWeapon;

	// Token: 0x0400A65F RID: 42591
	[Nullable(2)]
	private static SceneBattleInteractModel _Instance;
}

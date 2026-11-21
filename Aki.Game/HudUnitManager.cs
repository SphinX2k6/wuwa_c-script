using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

// Token: 0x02001402 RID: 5122
[NullableContext(1)]
[Nullable(0)]
public class HudUnitManager : Singleton
{
	// Token: 0x0600CB43 RID: 52035 RVA: 0x003C7078 File Offset: 0x003C5278
	public bool GetIsInitHud()
	{
		return this.IsInitHud;
	}

	// Token: 0x0600CB44 RID: 52036 RVA: 0x003C7080 File Offset: 0x003C5280
	public HudUnitHandleBase New(Type hudUnitHandleClass)
	{
		HudUnitHandleBase hudUnitHandleBase = Activator.CreateInstance(hudUnitHandleClass) as HudUnitHandleBase;
		hudUnitHandleBase.Initialize();
		string name = hudUnitHandleClass.Name;
		this.HudUnitHandleMap[name] = hudUnitHandleBase;
		return hudUnitHandleBase;
	}

	// Token: 0x0600CB45 RID: 52037 RVA: 0x003C70B4 File Offset: 0x003C52B4
	public void TryNew(Type hudUnitHandleClass)
	{
		if (this.Get(hudUnitHandleClass) != null)
		{
			return;
		}
		this.New(hudUnitHandleClass).OnShowHud();
	}

	// Token: 0x0600CB46 RID: 52038 RVA: 0x003C70CC File Offset: 0x003C52CC
	public void Destroy(Type hudUnitHandleClass)
	{
		HudUnitHandleBase hudUnitHandleBase = this.Get(hudUnitHandleClass);
		if (hudUnitHandleBase != null)
		{
			hudUnitHandleBase.Destroy();
		}
		string name = hudUnitHandleClass.Name;
		this.HudUnitHandleMap.Remove(name);
	}

	// Token: 0x0600CB47 RID: 52039 RVA: 0x003C7100 File Offset: 0x003C5300
	public void ShowHud()
	{
		if (!this.IsInitHud)
		{
			foreach (Type hudUnitHandleClass in this.HudUnitHandleClassArray)
			{
				this.New(hudUnitHandleClass);
			}
			this.IsInitHud = true;
			EventSystem.Instance.Emit(EEventName.HudInited);
		}
		foreach (HudUnitHandleBase hudUnitHandleBase in this.HudUnitHandleMap.Values)
		{
			hudUnitHandleBase.OnShowHud();
		}
	}

	// Token: 0x0600CB48 RID: 52040 RVA: 0x003C7198 File Offset: 0x003C5398
	public void HideHud()
	{
		foreach (HudUnitHandleBase hudUnitHandleBase in this.HudUnitHandleMap.Values)
		{
			hudUnitHandleBase.OnHideHud();
		}
	}

	// Token: 0x0600CB49 RID: 52041 RVA: 0x003C71F0 File Offset: 0x003C53F0
	[return: Nullable(2)]
	public HudUnitHandleBase Get(Type hudUnitHandleClass)
	{
		string name = hudUnitHandleClass.Name;
		HudUnitHandleBase result;
		this.HudUnitHandleMap.TryGetValue(name, out result);
		return result;
	}

	// Token: 0x0600CB4A RID: 52042 RVA: 0x003C7214 File Offset: 0x003C5414
	public void Clear()
	{
		foreach (HudUnitHandleBase hudUnitHandleBase in this.HudUnitHandleMap.Values)
		{
			hudUnitHandleBase.Destroy();
		}
		this.HudUnitHandleMap.Clear();
		this.IsInitHud = false;
	}

	// Token: 0x0600CB4B RID: 52043 RVA: 0x003C727C File Offset: 0x003C547C
	public void RefreshHudOnInputControllerChanged(EInputControllerType last, EInputControllerType now)
	{
		foreach (HudUnitHandleBase hudUnitHandleBase in this.HudUnitHandleMap.Values)
		{
			hudUnitHandleBase.OnInputControllerChanged(last, now);
		}
	}

	// Token: 0x0600CB4C RID: 52044 RVA: 0x003C72D4 File Offset: 0x003C54D4
	public void Tick(float delta)
	{
		foreach (HudUnitHandleBase hudUnitHandleBase in this.HudUnitHandleMap.Values)
		{
			hudUnitHandleBase.Tick(delta);
		}
		this.TickCount++;
	}

	// Token: 0x0600CB4D RID: 52045 RVA: 0x003C7338 File Offset: 0x003C5538
	public void AfterTick(float delta)
	{
		foreach (HudUnitHandleBase hudUnitHandleBase in this.HudUnitHandleMap.Values)
		{
			hudUnitHandleBase.AfterTick(delta);
		}
	}

	// Token: 0x17001362 RID: 4962
	// (get) Token: 0x0600CB4E RID: 52046 RVA: 0x003C7390 File Offset: 0x003C5590
	public static HudUnitManager Instance
	{
		get
		{
			if (HudUnitManager._instance == null)
			{
				HudUnitManager._instance = new HudUnitManager();
				HudUnitManager._instance.OnInit();
			}
			return HudUnitManager._instance;
		}
	}

	// Token: 0x0600CB4F RID: 52047 RVA: 0x003C73B3 File Offset: 0x003C55B3
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600CB50 RID: 52048 RVA: 0x003C73B5 File Offset: 0x003C55B5
	public static void ResetStaticDefaultValue()
	{
		HudUnitManager instance = HudUnitManager._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		HudUnitManager._instance = null;
	}

	// Token: 0x0600CB51 RID: 52049 RVA: 0x003C73CE File Offset: 0x003C55CE
	static HudUnitManager()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(HudUnitManager.CreateStaticDefaultValue), new Action(HudUnitManager.ResetStaticDefaultValue));
	}

	// Token: 0x04007347 RID: 29511
	public Type[] HudUnitHandleClassArray = new Type[0];

	// Token: 0x04007348 RID: 29512
	public Dictionary<EHudUnitType, Type> HudUnitHandleClassMap = new Dictionary<EHudUnitType, Type>();

	// Token: 0x04007349 RID: 29513
	private readonly Dictionary<string, HudUnitHandleBase> HudUnitHandleMap = new Dictionary<string, HudUnitHandleBase>();

	// Token: 0x0400734A RID: 29514
	private bool IsInitHud;

	// Token: 0x0400734B RID: 29515
	public int TickCount;

	// Token: 0x0400734C RID: 29516
	[Nullable(2)]
	private static HudUnitManager _instance;
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

// Token: 0x02001F40 RID: 8000
[NullableContext(1)]
[Nullable(0)]
public class HudUnitManager : Singleton
{
	// Token: 0x0600F724 RID: 63268 RVA: 0x003BB58C File Offset: 0x003B978C
	public bool GetIsInitHud()
	{
		return this.IsInitHud;
	}

	// Token: 0x0600F725 RID: 63269 RVA: 0x003BB594 File Offset: 0x003B9794
	public HudUnitHandleBase New(Type hudUnitHandleClass)
	{
		HudUnitHandleBase hudUnitHandleBase = Activator.CreateInstance(hudUnitHandleClass) as HudUnitHandleBase;
		hudUnitHandleBase.Initialize();
		string name = hudUnitHandleClass.Name;
		this.HudUnitHandleMap[name] = hudUnitHandleBase;
		return hudUnitHandleBase;
	}

	// Token: 0x0600F726 RID: 63270 RVA: 0x003BB5C8 File Offset: 0x003B97C8
	public void TryNew(Type hudUnitHandleClass)
	{
		if (this.Get(hudUnitHandleClass) != null)
		{
			return;
		}
		this.New(hudUnitHandleClass).OnShowHud();
	}

	// Token: 0x0600F727 RID: 63271 RVA: 0x003BB5E0 File Offset: 0x003B97E0
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

	// Token: 0x0600F728 RID: 63272 RVA: 0x003BB614 File Offset: 0x003B9814
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

	// Token: 0x0600F729 RID: 63273 RVA: 0x003BB6AC File Offset: 0x003B98AC
	public void HideHud()
	{
		foreach (HudUnitHandleBase hudUnitHandleBase in this.HudUnitHandleMap.Values)
		{
			hudUnitHandleBase.OnHideHud();
		}
	}

	// Token: 0x0600F72A RID: 63274 RVA: 0x003BB704 File Offset: 0x003B9904
	[return: Nullable(2)]
	public HudUnitHandleBase Get(Type hudUnitHandleClass)
	{
		string name = hudUnitHandleClass.Name;
		HudUnitHandleBase result;
		this.HudUnitHandleMap.TryGetValue(name, out result);
		return result;
	}

	// Token: 0x0600F72B RID: 63275 RVA: 0x003BB728 File Offset: 0x003B9928
	public void Clear()
	{
		foreach (HudUnitHandleBase hudUnitHandleBase in this.HudUnitHandleMap.Values)
		{
			hudUnitHandleBase.Destroy();
		}
		this.HudUnitHandleMap.Clear();
		this.IsInitHud = false;
	}

	// Token: 0x0600F72C RID: 63276 RVA: 0x003BB790 File Offset: 0x003B9990
	public void RefreshHudOnInputControllerChanged(EInputControllerType last, EInputControllerType now)
	{
		foreach (HudUnitHandleBase hudUnitHandleBase in this.HudUnitHandleMap.Values)
		{
			hudUnitHandleBase.OnInputControllerChanged(last, now);
		}
	}

	// Token: 0x0600F72D RID: 63277 RVA: 0x003BB7E8 File Offset: 0x003B99E8
	public void Tick(float delta)
	{
		foreach (HudUnitHandleBase hudUnitHandleBase in this.HudUnitHandleMap.Values)
		{
			hudUnitHandleBase.Tick(delta);
		}
		this.TickCount++;
	}

	// Token: 0x0600F72E RID: 63278 RVA: 0x003BB84C File Offset: 0x003B9A4C
	public void AfterTick(float delta)
	{
		foreach (HudUnitHandleBase hudUnitHandleBase in this.HudUnitHandleMap.Values)
		{
			hudUnitHandleBase.AfterTick(delta);
		}
	}

	// Token: 0x17001338 RID: 4920
	// (get) Token: 0x0600F72F RID: 63279 RVA: 0x003BB8A4 File Offset: 0x003B9AA4
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

	// Token: 0x0600F730 RID: 63280 RVA: 0x003BB8C7 File Offset: 0x003B9AC7
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600F731 RID: 63281 RVA: 0x003BB8C9 File Offset: 0x003B9AC9
	public static void ResetStaticDefaultValue()
	{
		HudUnitManager instance = HudUnitManager._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		HudUnitManager._instance = null;
	}

	// Token: 0x0600F732 RID: 63282 RVA: 0x003BB8E2 File Offset: 0x003B9AE2
	static HudUnitManager()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(HudUnitManager.CreateStaticDefaultValue), new Action(HudUnitManager.ResetStaticDefaultValue));
	}

	// Token: 0x04007266 RID: 29286
	public Type[] HudUnitHandleClassArray = new Type[0];

	// Token: 0x04007267 RID: 29287
	public Dictionary<EHudUnitType, Type> HudUnitHandleClassMap = new Dictionary<EHudUnitType, Type>();

	// Token: 0x04007268 RID: 29288
	private readonly Dictionary<string, HudUnitHandleBase> HudUnitHandleMap = new Dictionary<string, HudUnitHandleBase>();

	// Token: 0x04007269 RID: 29289
	private bool IsInitHud;

	// Token: 0x0400726A RID: 29290
	public int TickCount;

	// Token: 0x0400726B RID: 29291
	[Nullable(2)]
	private static HudUnitManager _instance;
}

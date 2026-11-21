using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x0200000B RID: 11
[NullableContext(1)]
[Nullable(0)]
public class Application : Singleton
{
	// Token: 0x06000032 RID: 50 RVA: 0x0000371C File Offset: 0x0000191C
	public void Initialize()
	{
		if (this.IsInit)
		{
			return;
		}
		this.IsInit = true;
		FOnApplicationLifeTime fonApplicationLifeTime = DelegateUtils.ToManualReleaseDelegate<FOnApplicationLifeTime>(new Action<int>(this.OnApplicationLifetimeDelegate));
		UKuroApplicationLibrary.AddApplicationLifetimeDelegate(fonApplicationLifeTime);
		FOnEditorPreEndPIE fonEditorPreEndPIE = DelegateUtils.ToManualReleaseDelegate<FOnEditorPreEndPIE>(new Action<bool>(this.OnEditorPreEndPIEDelegate));
		UKuroApplicationLibrary.AddEditorPreEndPIEDelegate(fonEditorPreEndPIE);
		FWindowActivation fwindowActivation = DelegateUtils.ToManualReleaseDelegate<FWindowActivation>(new Action<bool>(this.OnWindowActivationDelegate));
		UKuroApplicationLibrary.AddWindowActivationDelegate(fwindowActivation);
	}

	// Token: 0x06000033 RID: 51 RVA: 0x00003788 File Offset: 0x00001988
	private void OnApplicationLifetimeDelegate(int type)
	{
		if (!this.HandleMap.ContainsKey((EApplicationLifetimeDelegate)type))
		{
			return;
		}
		foreach (Action action in this.HandleMap[(EApplicationLifetimeDelegate)type])
		{
			action();
		}
	}

	// Token: 0x06000034 RID: 52 RVA: 0x000037F0 File Offset: 0x000019F0
	private void OnEditorPreEndPIEDelegate(bool bSimulateInEditor)
	{
		foreach (Action action in this.EditorHandleSet)
		{
			action();
		}
	}

	// Token: 0x06000035 RID: 53 RVA: 0x00003840 File Offset: 0x00001A40
	public void Destroy()
	{
		if (!this.IsInit)
		{
			return;
		}
		this.HandleMap.Clear();
		this.EditorHandleSet.Clear();
		this.WindowActivationHandleSet.Clear();
		DelegateUtils.ReleaseManualReleaseDelegate(new Action<int>(this.OnApplicationLifetimeDelegate));
		DelegateUtils.ReleaseManualReleaseDelegate(new Action<bool>(this.OnEditorPreEndPIEDelegate));
		DelegateUtils.ReleaseManualReleaseDelegate(new Action<bool>(this.OnWindowActivationDelegate));
		UKuroApplicationLibrary.UnBind();
		this.IsInit = false;
	}

	// Token: 0x06000036 RID: 54 RVA: 0x000038B8 File Offset: 0x00001AB8
	private void OnWindowActivationDelegate(bool bIsActive)
	{
		bool? windowIsActive = this.WindowIsActive;
		if (!(bIsActive == windowIsActive.GetValueOrDefault() & windowIsActive != null))
		{
			this.WindowIsActive = new bool?(bIsActive);
			foreach (Action<bool> action in this.WindowActivationHandleSet)
			{
				action(bIsActive);
			}
		}
	}

	// Token: 0x06000037 RID: 55 RVA: 0x00003930 File Offset: 0x00001B30
	public void AddApplicationHandler(EApplicationLifetimeDelegate e, Action handler)
	{
		if (!this.HandleMap.ContainsKey(e))
		{
			this.HandleMap[e] = new HashSet<Action>();
		}
		this.HandleMap[e].Add(handler);
	}

	// Token: 0x06000038 RID: 56 RVA: 0x00003964 File Offset: 0x00001B64
	public void RemoveApplicationHandler(EApplicationLifetimeDelegate type, Action handler)
	{
		if (!this.HandleMap.ContainsKey(type))
		{
			return;
		}
		this.HandleMap[type].Remove(handler);
	}

	// Token: 0x06000039 RID: 57 RVA: 0x00003988 File Offset: 0x00001B88
	public void AddEditorPreEndPIEHandler(Action handler)
	{
		this.EditorHandleSet.Add(handler);
	}

	// Token: 0x0600003A RID: 58 RVA: 0x00003997 File Offset: 0x00001B97
	public void RemoveEditorPreEndPIEHandler(Action handler)
	{
		this.EditorHandleSet.Remove(handler);
	}

	// Token: 0x0600003B RID: 59 RVA: 0x000039A6 File Offset: 0x00001BA6
	public void AddWindowActivationHandler(Action<bool> handler)
	{
		this.WindowActivationHandleSet.Add(handler);
	}

	// Token: 0x0600003C RID: 60 RVA: 0x000039B5 File Offset: 0x00001BB5
	public void RemoveWindowActivationHandler(Action<bool> handler)
	{
		this.WindowActivationHandleSet.Remove(handler);
	}

	// Token: 0x0600003D RID: 61 RVA: 0x000039C4 File Offset: 0x00001BC4
	public bool? GetWindowActivationState()
	{
		return this.WindowIsActive;
	}

	// Token: 0x0600003E RID: 62 RVA: 0x000039CC File Offset: 0x00001BCC
	public bool IsPublicationApp()
	{
		return this.GmSimulatePublication || UKuroLauncherLibrary.GetAppInternalUseType() == "Publication";
	}

	// Token: 0x17000006 RID: 6
	// (get) Token: 0x0600003F RID: 63 RVA: 0x000039E7 File Offset: 0x00001BE7
	public static Application Instance
	{
		get
		{
			if (Application._instance == null)
			{
				Application._instance = new Application();
				Application._instance.OnInit();
			}
			return Application._instance;
		}
	}

	// Token: 0x06000040 RID: 64 RVA: 0x00003A0A File Offset: 0x00001C0A
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06000041 RID: 65 RVA: 0x00003A0C File Offset: 0x00001C0C
	public static void ResetStaticDefaultValue()
	{
		Application instance = Application._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		Application._instance = null;
	}

	// Token: 0x06000042 RID: 66 RVA: 0x00003A25 File Offset: 0x00001C25
	static Application()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(Application.CreateStaticDefaultValue), new Action(Application.ResetStaticDefaultValue));
	}

	// Token: 0x04000040 RID: 64
	private readonly Dictionary<EApplicationLifetimeDelegate, HashSet<Action>> HandleMap = new Dictionary<EApplicationLifetimeDelegate, HashSet<Action>>();

	// Token: 0x04000041 RID: 65
	private readonly HashSet<Action> EditorHandleSet = new HashSet<Action>();

	// Token: 0x04000042 RID: 66
	private readonly HashSet<Action<bool>> WindowActivationHandleSet = new HashSet<Action<bool>>();

	// Token: 0x04000043 RID: 67
	private bool IsInit;

	// Token: 0x04000044 RID: 68
	private bool? WindowIsActive;

	// Token: 0x04000045 RID: 69
	public bool GmSimulatePublication;

	// Token: 0x04000046 RID: 70
	[Nullable(2)]
	private static Application _instance;
}

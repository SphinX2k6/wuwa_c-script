using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.HotPatch;
using CSharpScript.Launcher.InputDevice;
using CSharpScript.Launcher.PlayerInput;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000007 RID: 7
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Launcher/PlayerInput/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Launcher/PlayerInput/TsHotPatchPanelConfig.TsHotPatchPanelConfig_C")]
public class TsHotPatchPanelConfig : ULGUIBehaviour, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000007 RID: 7
	// (get) Token: 0x06000056 RID: 86 RVA: 0x000060DC File Offset: 0x000042DC
	[UProperty(EPropertyFlags.CPF_None)]
	public TMap<AActor, SHotPatchGamepad> ActionMap
	{
		get
		{
			base.FastCheckIsValid();
			TMap<AActor, SHotPatchGamepad> result;
			if ((result = this._ActionMap) == null)
			{
				result = (this._ActionMap = new TMap<AActor, SHotPatchGamepad>(base.NativePtr + (IntPtr)TsHotPatchPanelConfig.__PropertyOffset_ActionMap, this));
			}
			return result;
		}
	}

	// Token: 0x17000008 RID: 8
	// (get) Token: 0x06000057 RID: 87 RVA: 0x00006118 File Offset: 0x00004318
	[UProperty(EPropertyFlags.CPF_None)]
	public TMap<AActor, string> AxisMap
	{
		get
		{
			base.FastCheckIsValid();
			TMap<AActor, string> result;
			if ((result = this._AxisMap) == null)
			{
				result = (this._AxisMap = new TMap<AActor, string>(base.NativePtr + (IntPtr)TsHotPatchPanelConfig.__PropertyOffset_AxisMap, this));
			}
			return result;
		}
	}

	// Token: 0x06000058 RID: 88 RVA: 0x00006154 File Offset: 0x00004354
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void AwakeBP()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("AwakeBP"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* dest = null;
		if (num != 0)
		{
			dest = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, null);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
	}

	// Token: 0x06000059 RID: 89 RVA: 0x000061C4 File Offset: 0x000043C4
	protected virtual void AwakeBP_Implementation()
	{
		this.InputAction = delegate(bool bPress, string actionName)
		{
			List<UUIItem> list = this.RegisterActionMap[actionName];
			for (int i = 0; i < list.Count; i++)
			{
				UUIItem uuiitem = list[i];
				if (uuiitem.IsUIActiveInHierarchy())
				{
					AActor owner = uuiitem.GetOwner();
					UUIButtonComponent uuibuttonComponent = ((owner != null) ? owner.GetComponentByClass(UUIButtonComponent.StaticClass()) : null) as UUIButtonComponent;
					if (uuibuttonComponent == null || uuibuttonComponent.GetSelfInteractive())
					{
						HotPatchEventSystem.Instance.SimulationPointerDownUp(uuiitem, bPress);
					}
				}
			}
		};
		this.InputAxis = delegate(float value, string axisName)
		{
			List<UUIScrollViewWithScrollbarComponent> list = this.RegisterAxisMap[axisName];
			for (int i = 0; i < list.Count; i++)
			{
				UUIScrollViewWithScrollbarComponent uuiscrollViewWithScrollbarComponent = list[i];
				if (uuiscrollViewWithScrollbarComponent.RootUIComp.Get().IsUIActiveInHierarchy())
				{
					uuiscrollViewWithScrollbarComponent.SetVelocity(value * 800f);
				}
			}
		};
	}

	// Token: 0x0600005A RID: 90 RVA: 0x000061EC File Offset: 0x000043EC
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void OnEnableBP()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("OnEnableBP"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* dest = null;
		if (num != 0)
		{
			dest = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, null);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
	}

	// Token: 0x0600005B RID: 91 RVA: 0x0000625C File Offset: 0x0000445C
	protected virtual void OnEnableBP_Implementation()
	{
		this.RegisterTextureMap();
		HotPatchInputManager.Instance.InsertPanelConfig(this);
	}

	// Token: 0x0600005C RID: 92 RVA: 0x00006270 File Offset: 0x00004470
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void OnDisableBP()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("OnDisableBP"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* dest = null;
		if (num != 0)
		{
			dest = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, null);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
	}

	// Token: 0x0600005D RID: 93 RVA: 0x000062E0 File Offset: 0x000044E0
	protected virtual void OnDisableBP_Implementation()
	{
		HotPatchInputManager.Instance.RemovePanelConfig(this);
		this.UnRegisterTextureMap();
	}

	// Token: 0x0600005E RID: 94 RVA: 0x000062F4 File Offset: 0x000044F4
	private void RegisterTextureMap()
	{
		this.TextureList = new List<ValueTuple<string, UUITexture>>();
		for (int i = 0; i < this.ActionMap.Num(); i++)
		{
			AActor key = this.ActionMap.GetKey(i);
			SHotPatchGamepad shotPatchGamepad = this.ActionMap.Get(key);
			if (!(shotPatchGamepad == null) && shotPatchGamepad.TextureActor != null && shotPatchGamepad.TextureActor.UITexture != null)
			{
				this.TextureList.Add(new ValueTuple<string, UUITexture>(shotPatchGamepad.ActionName, shotPatchGamepad.TextureActor.UITexture));
			}
		}
	}

	// Token: 0x0600005F RID: 95 RVA: 0x0000637B File Offset: 0x0000457B
	private void UnRegisterTextureMap()
	{
		this.TextureList = new List<ValueTuple<string, UUITexture>>();
	}

	// Token: 0x06000060 RID: 96 RVA: 0x00006388 File Offset: 0x00004588
	private void RegisterAction()
	{
		this.RegisterActionMap = new Dictionary<string, List<UUIItem>>();
		for (int i = 0; i < this.ActionMap.Num(); i++)
		{
			AActor key = this.ActionMap.GetKey(i);
			SHotPatchGamepad shotPatchGamepad = this.ActionMap.Get(key);
			if (!(shotPatchGamepad == null))
			{
				UUIItem uuiitem = key.GetComponentByClass(UUIItem.StaticClass()) as UUIItem;
				if (uuiitem != null)
				{
					List<UUIItem> list;
					if (!this.RegisterActionMap.TryGetValue(shotPatchGamepad.ActionName, out list))
					{
						list = new List<UUIItem>();
						this.RegisterActionMap[shotPatchGamepad.ActionName] = list;
						HotPatchInputManager.Instance.RegisterInputAction(shotPatchGamepad.ActionName, this.InputAction);
					}
					list.Add(uuiitem);
				}
			}
		}
	}

	// Token: 0x06000061 RID: 97 RVA: 0x00006448 File Offset: 0x00004648
	private void RegisterAxis()
	{
		this.RegisterAxisMap = new Dictionary<string, List<UUIScrollViewWithScrollbarComponent>>();
		for (int i = 0; i < this.AxisMap.Num(); i++)
		{
			AActor key = this.AxisMap.GetKey(i);
			string text = this.AxisMap.Get(key);
			if (text != null)
			{
				UUIScrollViewWithScrollbarComponent uuiscrollViewWithScrollbarComponent = key.GetComponentByClass(UUIScrollViewWithScrollbarComponent.StaticClass()) as UUIScrollViewWithScrollbarComponent;
				if (uuiscrollViewWithScrollbarComponent != null)
				{
					List<UUIScrollViewWithScrollbarComponent> list;
					if (!this.RegisterAxisMap.TryGetValue(text, out list))
					{
						list = new List<UUIScrollViewWithScrollbarComponent>();
						this.RegisterAxisMap[text] = list;
						HotPatchInputManager.Instance.RegisterInputAxis(text, this.InputAxis);
					}
					list.Add(uuiscrollViewWithScrollbarComponent);
				}
			}
		}
	}

	// Token: 0x06000062 RID: 98 RVA: 0x000064F0 File Offset: 0x000046F0
	private void UnRegisterAction()
	{
		if (this.RegisterActionMap == null)
		{
			return;
		}
		foreach (string actionName in this.RegisterActionMap.Keys)
		{
			HotPatchInputManager.Instance.UnRegisterInputAction(actionName, this.InputAction);
		}
		this.RegisterActionMap.Clear();
	}

	// Token: 0x06000063 RID: 99 RVA: 0x00006568 File Offset: 0x00004768
	private void UnRegisterAxis()
	{
		if (this.RegisterAxisMap == null)
		{
			return;
		}
		foreach (string axisName in this.RegisterAxisMap.Keys)
		{
			HotPatchInputManager.Instance.UnRegisterInputAxis(axisName, this.InputAxis);
		}
		this.RegisterAxisMap.Clear();
	}

	// Token: 0x06000064 RID: 100 RVA: 0x000065E0 File Offset: 0x000047E0
	public void RegisterActionAndAxis()
	{
		this.RegisterAction();
		this.RegisterAxis();
	}

	// Token: 0x06000065 RID: 101 RVA: 0x000065EE File Offset: 0x000047EE
	public void UnRegisterActionAndAxis()
	{
		this.UnRegisterAction();
		this.UnRegisterAxis();
	}

	// Token: 0x06000066 RID: 102 RVA: 0x000065FC File Offset: 0x000047FC
	public void RefreshTexture()
	{
		for (int i = 0; i < this.TextureList.Count; i++)
		{
			ValueTuple<string, UUITexture> valueTuple = this.TextureList[i];
			if (!InputDevice.Instance.IsInGamepad())
			{
				valueTuple.Item2.SetUIActive(false);
			}
			else
			{
				UTexture textureByActionName = HotPatchInputManager.Instance.GetTextureByActionName(valueTuple.Item1);
				if (textureByActionName != null)
				{
					valueTuple.Item2.SetUIActive(true);
					valueTuple.Item2.SetTexture(textureByActionName);
					valueTuple.Item2.SetSizeFromTexture();
				}
			}
		}
	}

	// Token: 0x06000067 RID: 103 RVA: 0x00006680 File Offset: 0x00004880
	public void HideTexture()
	{
		for (int i = 0; i < this.TextureList.Count; i++)
		{
			this.TextureList[i].Item2.SetUIActive(false);
		}
	}

	// Token: 0x06000068 RID: 104 RVA: 0x000066BA File Offset: 0x000048BA
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsHotPatchPanelConfig._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Launcher/PlayerInput/TsHotPatchPanelConfig.TsHotPatchPanelConfig_C");
		}
		return TsHotPatchPanelConfig._ClassPtr;
	}

	// Token: 0x06000069 RID: 105 RVA: 0x000066E0 File Offset: 0x000048E0
	public TsHotPatchPanelConfig() : this(BuiltinUtils.AllocNativeUObject(TsHotPatchPanelConfig.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0600006A RID: 106 RVA: 0x00006708 File Offset: 0x00004908
	public TsHotPatchPanelConfig(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsHotPatchPanelConfig.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0600006B RID: 107 RVA: 0x0000673B File Offset: 0x0000493B
	protected TsHotPatchPanelConfig(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0600006C RID: 108 RVA: 0x00006744 File Offset: 0x00004944
	protected virtual void __CPPCALL_AwakeBP_Implementation()
	{
		this.AwakeBP_Implementation();
	}

	// Token: 0x0600006D RID: 109 RVA: 0x0000674C File Offset: 0x0000494C
	protected virtual void __CPPCALL_OnEnableBP_Implementation()
	{
		this.OnEnableBP_Implementation();
	}

	// Token: 0x0600006E RID: 110 RVA: 0x00006754 File Offset: 0x00004954
	protected virtual void __CPPCALL_OnDisableBP_Implementation()
	{
		this.OnDisableBP_Implementation();
	}

	// Token: 0x04000023 RID: 35
	private TInputAction InputAction;

	// Token: 0x04000024 RID: 36
	private TInputAxis InputAxis;

	// Token: 0x04000025 RID: 37
	[Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})]
	private Dictionary<string, List<UUIItem>> RegisterActionMap;

	// Token: 0x04000026 RID: 38
	[Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})]
	private Dictionary<string, List<UUIScrollViewWithScrollbarComponent>> RegisterAxisMap;

	// Token: 0x04000027 RID: 39
	[Nullable(new byte[]
	{
		2,
		0,
		1,
		1
	})]
	private List<ValueTuple<string, UUITexture>> TextureList;

	// Token: 0x04000028 RID: 40
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Launcher/PlayerInput/TsHotPatchPanelConfig.TsHotPatchPanelConfig_C";

	// Token: 0x04000029 RID: 41
	private static IntPtr _ClassPtr;

	// Token: 0x0400002A RID: 42
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400002B RID: 43
	private static int __PropertyOffset_ActionMap;

	// Token: 0x0400002C RID: 44
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private TMap<AActor, SHotPatchGamepad> _ActionMap;

	// Token: 0x0400002D RID: 45
	private static int __PropertyOffset_AxisMap;

	// Token: 0x0400002E RID: 46
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private TMap<AActor, string> _AxisMap;
}

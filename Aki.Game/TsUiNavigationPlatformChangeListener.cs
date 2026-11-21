using System;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02002221 RID: 8737
[UClass("/Game/Aki/TypeScript/Game/Module/UiNavigation/New/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Module/UiNavigation/New/TsUiNavigationPlatformChangeListener.TsUiNavigationPlatformChangeListener_C")]
public class TsUiNavigationPlatformChangeListener : ULGUIBehaviour, IUnrealUObject, IUnrealObject
{
	// Token: 0x170020BD RID: 8381
	// (get) Token: 0x060158B2 RID: 88242 RVA: 0x0064069D File Offset: 0x0063E89D
	// (set) Token: 0x060158B3 RID: 88243 RVA: 0x006406AD File Offset: 0x0063E8AD
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool HideInKeyBoard
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsUiNavigationPlatformChangeListener.__PropertyOffset_HideInKeyBoard) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsUiNavigationPlatformChangeListener.__PropertyOffset_HideInKeyBoard) = (value ? 1 : 0);
		}
	}

	// Token: 0x170020BE RID: 8382
	// (get) Token: 0x060158B4 RID: 88244 RVA: 0x006406BE File Offset: 0x0063E8BE
	// (set) Token: 0x060158B5 RID: 88245 RVA: 0x006406CE File Offset: 0x0063E8CE
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool UseActive
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsUiNavigationPlatformChangeListener.__PropertyOffset_UseActive) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsUiNavigationPlatformChangeListener.__PropertyOffset_UseActive) = (value ? 1 : 0);
		}
	}

	// Token: 0x060158B6 RID: 88246 RVA: 0x006406E0 File Offset: 0x0063E8E0
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public override void AwakeBP()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(TsUiNavigationPlatformChangeListener) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("AwakeBP"), TsUiNavigationPlatformChangeListener.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.AwakeBP_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x060158B7 RID: 88247 RVA: 0x00640739 File Offset: 0x0063E939
	protected virtual void AwakeBP_Implementation()
	{
		if (GlobalData.GameInstance == null)
		{
			return;
		}
		this.ChangeState();
		UiNavigationModel instance = UiNavigationModel.Instance;
		if (instance == null)
		{
			return;
		}
		instance.AddPlatformListener(this);
	}

	// Token: 0x060158B8 RID: 88248 RVA: 0x0064075C File Offset: 0x0063E95C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public override void OnPreDestroyBP()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(TsUiNavigationPlatformChangeListener) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("OnPreDestroyBP"), TsUiNavigationPlatformChangeListener.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.OnPreDestroyBP_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x060158B9 RID: 88249 RVA: 0x006407B5 File Offset: 0x0063E9B5
	protected virtual void OnPreDestroyBP_Implementation()
	{
		if (GlobalData.GameInstance == null)
		{
			return;
		}
		UiNavigationModel.Instance.RemovePlatformListener(this);
	}

	// Token: 0x060158BA RID: 88250 RVA: 0x006407CC File Offset: 0x0063E9CC
	public void ChangeState()
	{
		UUIItem rootComponent = base.GetRootComponent();
		bool flag = Info.Instance.IsInGamepad() == this.HideInKeyBoard;
		if (this.UseActive)
		{
			if (rootComponent != null)
			{
				rootComponent.SetUIActive(flag);
				return;
			}
		}
		else if (rootComponent != null)
		{
			rootComponent.SetAlpha(flag > false);
		}
	}

	// Token: 0x060158BB RID: 88251 RVA: 0x00640814 File Offset: 0x0063EA14
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsUiNavigationPlatformChangeListener._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Module/UiNavigation/New/TsUiNavigationPlatformChangeListener.TsUiNavigationPlatformChangeListener_C");
		}
		return TsUiNavigationPlatformChangeListener._ClassPtr;
	}

	// Token: 0x060158BC RID: 88252 RVA: 0x00640838 File Offset: 0x0063EA38
	public TsUiNavigationPlatformChangeListener() : this(BuiltinUtils.AllocNativeUObject(TsUiNavigationPlatformChangeListener.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060158BD RID: 88253 RVA: 0x00640860 File Offset: 0x0063EA60
	[NullableContext(1)]
	public TsUiNavigationPlatformChangeListener(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsUiNavigationPlatformChangeListener.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060158BE RID: 88254 RVA: 0x00640893 File Offset: 0x0063EA93
	protected TsUiNavigationPlatformChangeListener(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060158BF RID: 88255 RVA: 0x0064089C File Offset: 0x0063EA9C
	protected virtual void __CPPCALL_AwakeBP_Implementation()
	{
		this.AwakeBP_Implementation();
	}

	// Token: 0x060158C0 RID: 88256 RVA: 0x006408A4 File Offset: 0x0063EAA4
	protected virtual void __CPPCALL_OnPreDestroyBP_Implementation()
	{
		this.OnPreDestroyBP_Implementation();
	}

	// Token: 0x0400B647 RID: 46663
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Module/UiNavigation/New/TsUiNavigationPlatformChangeListener.TsUiNavigationPlatformChangeListener_C";

	// Token: 0x0400B648 RID: 46664
	private static IntPtr _ClassPtr;

	// Token: 0x0400B649 RID: 46665
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400B64A RID: 46666
	private static int __PropertyOffset_HideInKeyBoard;

	// Token: 0x0400B64B RID: 46667
	private static int __PropertyOffset_UseActive;
}

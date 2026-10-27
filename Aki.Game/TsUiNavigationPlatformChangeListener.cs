using System;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02002CC8 RID: 11464
[UClass("/Game/Aki/TypeScript/Game/Module/UiNavigation/New/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Module/UiNavigation/New/TsUiNavigationPlatformChangeListener.TsUiNavigationPlatformChangeListener_C")]
public class TsUiNavigationPlatformChangeListener : ULGUIBehaviour, IUnrealUObject, IUnrealObject
{
	// Token: 0x06018039 RID: 98361 RVA: 0x0061AA90 File Offset: 0x00618C90
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

	// Token: 0x0601803A RID: 98362 RVA: 0x0061AB00 File Offset: 0x00618D00
	protected virtual void AwakeBP_Implementation()
	{
		if (GlobalData.GameInstance == null)
		{
			return;
		}
		this.ChangeAlpha();
		UiNavigationModel instance = UiNavigationModel.Instance;
		if (instance == null)
		{
			return;
		}
		instance.AddPlatformListener(this);
	}

	// Token: 0x0601803B RID: 98363 RVA: 0x0061AB20 File Offset: 0x00618D20
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void OnPreDestroyBP()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("OnPreDestroyBP"), out num);
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

	// Token: 0x0601803C RID: 98364 RVA: 0x0061AB90 File Offset: 0x00618D90
	protected virtual void OnPreDestroyBP_Implementation()
	{
		if (GlobalData.GameInstance == null)
		{
			return;
		}
		UiNavigationModel.Instance.RemovePlatformListener(this);
	}

	// Token: 0x0601803D RID: 98365 RVA: 0x0061ABA8 File Offset: 0x00618DA8
	public void ChangeAlpha()
	{
		if (Info.Instance.IsInGamepad())
		{
			this.IsChangeAlpha = true;
			UUIItem rootComponent = base.GetRootComponent();
			if (rootComponent == null)
			{
				return;
			}
			rootComponent.SetAlpha(0f);
			return;
		}
		else
		{
			if (!this.IsChangeAlpha)
			{
				return;
			}
			this.IsChangeAlpha = false;
			UUIItem rootComponent2 = base.GetRootComponent();
			if (rootComponent2 == null)
			{
				return;
			}
			rootComponent2.SetAlpha(1f);
			return;
		}
	}

	// Token: 0x0601803E RID: 98366 RVA: 0x0061AC03 File Offset: 0x00618E03
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsUiNavigationPlatformChangeListener._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Module/UiNavigation/New/TsUiNavigationPlatformChangeListener.TsUiNavigationPlatformChangeListener_C");
		}
		return TsUiNavigationPlatformChangeListener._ClassPtr;
	}

	// Token: 0x0601803F RID: 98367 RVA: 0x0061AC28 File Offset: 0x00618E28
	public TsUiNavigationPlatformChangeListener() : this(BuiltinUtils.AllocNativeUObject(TsUiNavigationPlatformChangeListener.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06018040 RID: 98368 RVA: 0x0061AC50 File Offset: 0x00618E50
	[NullableContext(1)]
	public TsUiNavigationPlatformChangeListener(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsUiNavigationPlatformChangeListener.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06018041 RID: 98369 RVA: 0x0061AC83 File Offset: 0x00618E83
	protected TsUiNavigationPlatformChangeListener(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06018042 RID: 98370 RVA: 0x0061AC8C File Offset: 0x00618E8C
	protected virtual void __CPPCALL_AwakeBP_Implementation()
	{
		this.AwakeBP_Implementation();
	}

	// Token: 0x06018043 RID: 98371 RVA: 0x0061AC94 File Offset: 0x00618E94
	protected virtual void __CPPCALL_OnPreDestroyBP_Implementation()
	{
		this.OnPreDestroyBP_Implementation();
	}

	// Token: 0x0400B2DC RID: 45788
	private bool IsChangeAlpha;

	// Token: 0x0400B2DD RID: 45789
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Module/UiNavigation/New/TsUiNavigationPlatformChangeListener.TsUiNavigationPlatformChangeListener_C";

	// Token: 0x0400B2DE RID: 45790
	private static IntPtr _ClassPtr;

	// Token: 0x0400B2DF RID: 45791
	private static IntPtr _ClassDefaultObjectPtr;
}

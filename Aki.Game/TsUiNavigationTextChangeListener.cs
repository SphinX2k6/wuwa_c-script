using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02002CC9 RID: 11465
[UClass("/Game/Aki/TypeScript/Game/Module/UiNavigation/New/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Module/UiNavigation/New/TsUiNavigationTextChangeListener.TsUiNavigationTextChangeListener_C")]
public class TsUiNavigationTextChangeListener : UUINavigationTextChangeListener, IUnrealUObject, IUnrealObject
{
	// Token: 0x06018044 RID: 98372 RVA: 0x0061AC9C File Offset: 0x00618E9C
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

	// Token: 0x06018045 RID: 98373 RVA: 0x0061AD0C File Offset: 0x00618F0C
	protected virtual void AwakeBP_Implementation()
	{
		if (GlobalData.GameInstance == null)
		{
			return;
		}
		this.Listener = (base.GetOwner().GetComponentByClass(TsUiNavigationBehaviorListener.StaticClass()) as TsUiNavigationBehaviorListener);
	}

	// Token: 0x06018046 RID: 98374 RVA: 0x0061AD38 File Offset: 0x00618F38
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void StartBP()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("StartBP"), out num);
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

	// Token: 0x06018047 RID: 98375 RVA: 0x0061ADA8 File Offset: 0x00618FA8
	protected virtual void StartBP_Implementation()
	{
		if (GlobalData.GameInstance == null)
		{
			return;
		}
		this.NotifyDefaultText();
	}

	// Token: 0x06018048 RID: 98376 RVA: 0x0061ADB8 File Offset: 0x00618FB8
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void OnNotifyTextChangeBP(string NotifyText)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("OnNotifyTextChangeBP"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UUINavigationTextChangeListener.__OnNotifyTextChangeBP_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UUINavigationTextChangeListener.__OnNotifyTextChangeBP_FunctionParams*)ptr + 15L / (long)sizeof(UUINavigationTextChangeListener.__OnNotifyTextChangeBP_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			FString.CopyFrom((void*)(&ptr2->NotifyText), NotifyText);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x06018049 RID: 98377 RVA: 0x0061AE34 File Offset: 0x00619034
	[NullableContext(1)]
	protected virtual void OnNotifyTextChangeBP_Implementation(string NotifyText)
	{
		if (GlobalData.GameInstance == null)
		{
			return;
		}
		if (this.Listener == null)
		{
			return;
		}
		this.Listener.NotifyTextChangeByComponent(NotifyText);
	}

	// Token: 0x0601804A RID: 98378 RVA: 0x0061AE54 File Offset: 0x00619054
	private void NotifyDefaultText()
	{
		if (this.Listener == null)
		{
			return;
		}
		if (base.TextActor == null)
		{
			return;
		}
		this.Text = (base.TextActor.GetComponentByClass(UUIText.StaticClass()) as UUIText);
		if (this.Text == null)
		{
			return;
		}
		this.Listener.NotifyTextChangeByComponent(this.Text.GetText());
	}

	// Token: 0x0601804B RID: 98379 RVA: 0x0061AEB2 File Offset: 0x006190B2
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsUiNavigationTextChangeListener._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Module/UiNavigation/New/TsUiNavigationTextChangeListener.TsUiNavigationTextChangeListener_C");
		}
		return TsUiNavigationTextChangeListener._ClassPtr;
	}

	// Token: 0x0601804C RID: 98380 RVA: 0x0061AED8 File Offset: 0x006190D8
	public TsUiNavigationTextChangeListener() : this(BuiltinUtils.AllocNativeUObject(TsUiNavigationTextChangeListener.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601804D RID: 98381 RVA: 0x0061AF00 File Offset: 0x00619100
	[NullableContext(1)]
	public TsUiNavigationTextChangeListener(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsUiNavigationTextChangeListener.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601804E RID: 98382 RVA: 0x0061AF33 File Offset: 0x00619133
	protected TsUiNavigationTextChangeListener(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601804F RID: 98383 RVA: 0x0061AF3C File Offset: 0x0061913C
	protected virtual void __CPPCALL_AwakeBP_Implementation()
	{
		this.AwakeBP_Implementation();
	}

	// Token: 0x06018050 RID: 98384 RVA: 0x0061AF44 File Offset: 0x00619144
	protected virtual void __CPPCALL_StartBP_Implementation()
	{
		this.StartBP_Implementation();
	}

	// Token: 0x06018051 RID: 98385 RVA: 0x0061AF4C File Offset: 0x0061914C
	protected unsafe virtual void __CPPCALL_OnNotifyTextChangeBP_Implementation(UUINavigationTextChangeListener.__OnNotifyTextChangeBP_FunctionParams* __Params)
	{
		string notifyText = FString.ToString((void*)(&__Params->NotifyText));
		this.OnNotifyTextChangeBP_Implementation(notifyText);
	}

	// Token: 0x0400B2E0 RID: 45792
	[Nullable(2)]
	private TsUiNavigationBehaviorListener Listener;

	// Token: 0x0400B2E1 RID: 45793
	[Nullable(2)]
	public UUIText Text;

	// Token: 0x0400B2E2 RID: 45794
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Module/UiNavigation/New/TsUiNavigationTextChangeListener.TsUiNavigationTextChangeListener_C";

	// Token: 0x0400B2E3 RID: 45795
	private static IntPtr _ClassPtr;

	// Token: 0x0400B2E4 RID: 45796
	private static IntPtr _ClassDefaultObjectPtr;
}

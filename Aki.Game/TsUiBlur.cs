using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Extension;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02002C53 RID: 11347
[NullableContext(2)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/Module/UiComponent/Effect/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Module/UiComponent/Effect/TsUiBlur.TsUiBlur_C")]
public class TsUiBlur : ULGUIBehaviour, IUnrealUObject, IUnrealObject
{
	// Token: 0x17001FCA RID: 8138
	// (get) Token: 0x06017AE7 RID: 96999 RVA: 0x00605C5F File Offset: 0x00603E5F
	// (set) Token: 0x06017AE8 RID: 97000 RVA: 0x00605C73 File Offset: 0x00603E73
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe AActor OverrideItem
	{
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + TsUiBlur.__PropertyOffset_OverrideItem);
		}
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + TsUiBlur.__PropertyOffset_OverrideItem, value);
		}
	}

	// Token: 0x17001FCB RID: 8139
	// (get) Token: 0x06017AE9 RID: 97001 RVA: 0x00605C88 File Offset: 0x00603E88
	// (set) Token: 0x06017AEA RID: 97002 RVA: 0x00605C98 File Offset: 0x00603E98
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool EnableUiBlur
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsUiBlur.__PropertyOffset_EnableUiBlur) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsUiBlur.__PropertyOffset_EnableUiBlur) = (value ? 1 : 0);
		}
	}

	// Token: 0x17001FCC RID: 8140
	// (get) Token: 0x06017AEB RID: 97003 RVA: 0x00605CA9 File Offset: 0x00603EA9
	// (set) Token: 0x06017AEC RID: 97004 RVA: 0x00605CBD File Offset: 0x00603EBD
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe UUIItem ApplyItem
	{
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<UUIItem>(base.NativePtr / (IntPtr)sizeof(void*) + TsUiBlur.__PropertyOffset_ApplyItem);
		}
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + TsUiBlur.__PropertyOffset_ApplyItem, value);
		}
	}

	// Token: 0x06017AED RID: 97005 RVA: 0x00605CD2 File Offset: 0x00603ED2
	[NullableContext(1)]
	private UUIItem GetUiBlurComponent()
	{
		if (this.OverrideItem != null)
		{
			return this.OverrideItem.RootComponent as UUIItem;
		}
		return this.ApplyItem;
	}

	// Token: 0x06017AEE RID: 97006 RVA: 0x00605CF3 File Offset: 0x00603EF3
	private void SetGlobalBlurUiItem()
	{
		if (this.ApplyItem != null)
		{
			ULGUIBPLibrary.SetGlobalBlurUIItem(this.GetUiBlurComponent(), this.ApplyItem.GetWorld());
		}
	}

	// Token: 0x06017AEF RID: 97007 RVA: 0x00605D13 File Offset: 0x00603F13
	private void ResetGlobalBlurUiItem()
	{
		ULGUIBPLibrary.ResetGlobalBlurUIItem(GlobalData.GameInstance.GetWorld());
	}

	// Token: 0x06017AF0 RID: 97008 RVA: 0x00605D24 File Offset: 0x00603F24
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void SetEnableUiBlur(bool value)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("SetEnableUiBlur"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsUiBlur.__SetEnableUiBlur_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsUiBlur.__SetEnableUiBlur_FunctionParams*)ptr + 15L / (long)sizeof(TsUiBlur.__SetEnableUiBlur_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->value = value;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x06017AF1 RID: 97009 RVA: 0x00605D9A File Offset: 0x00603F9A
	protected void SetEnableUiBlur_Implementation(bool value)
	{
		this.EnableUiBlur = value;
		if (value)
		{
			this.SetGlobalBlurUiItem();
			return;
		}
		this.ResetGlobalBlurUiItem();
	}

	// Token: 0x06017AF2 RID: 97010 RVA: 0x00605DB3 File Offset: 0x00603FB3
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsUiBlur._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Module/UiComponent/Effect/TsUiBlur.TsUiBlur_C");
		}
		return TsUiBlur._ClassPtr;
	}

	// Token: 0x06017AF3 RID: 97011 RVA: 0x00605DD8 File Offset: 0x00603FD8
	public TsUiBlur() : this(BuiltinUtils.AllocNativeUObject(TsUiBlur.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06017AF4 RID: 97012 RVA: 0x00605E00 File Offset: 0x00604000
	[NullableContext(1)]
	public TsUiBlur(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsUiBlur.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06017AF5 RID: 97013 RVA: 0x00605E33 File Offset: 0x00604033
	protected TsUiBlur(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06017AF6 RID: 97014 RVA: 0x00605E3C File Offset: 0x0060403C
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_SetEnableUiBlur_Implementation(TsUiBlur.__SetEnableUiBlur_FunctionParams* __Params)
	{
		this.SetEnableUiBlur_Implementation(__Params->value);
	}

	// Token: 0x0400B06F RID: 45167
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Module/UiComponent/Effect/TsUiBlur.TsUiBlur_C";

	// Token: 0x0400B070 RID: 45168
	private static IntPtr _ClassPtr;

	// Token: 0x0400B071 RID: 45169
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400B072 RID: 45170
	private static int __PropertyOffset_OverrideItem;

	// Token: 0x0400B073 RID: 45171
	private static int __PropertyOffset_EnableUiBlur;

	// Token: 0x0400B074 RID: 45172
	private static int __PropertyOffset_ApplyItem;

	// Token: 0x0200923B RID: 37435
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1)]
	protected ref struct __SetEnableUiBlur_FunctionParams
	{
		// Token: 0x0402F4C0 RID: 193728
		[FieldOffset(0)]
		public bool value;
	}
}

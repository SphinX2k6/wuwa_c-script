using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Extension;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020021AC RID: 8620
[NullableContext(2)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/Module/UiComponent/Effect/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Module/UiComponent/Effect/TsUiBlur.TsUiBlur_C")]
public class TsUiBlur : ULGUIBehaviour, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700201D RID: 8221
	// (get) Token: 0x0601535D RID: 86877 RVA: 0x0062B6E7 File Offset: 0x006298E7
	// (set) Token: 0x0601535E RID: 86878 RVA: 0x0062B6FB File Offset: 0x006298FB
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

	// Token: 0x1700201E RID: 8222
	// (get) Token: 0x0601535F RID: 86879 RVA: 0x0062B710 File Offset: 0x00629910
	// (set) Token: 0x06015360 RID: 86880 RVA: 0x0062B720 File Offset: 0x00629920
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

	// Token: 0x1700201F RID: 8223
	// (get) Token: 0x06015361 RID: 86881 RVA: 0x0062B731 File Offset: 0x00629931
	// (set) Token: 0x06015362 RID: 86882 RVA: 0x0062B745 File Offset: 0x00629945
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

	// Token: 0x06015363 RID: 86883 RVA: 0x0062B75A File Offset: 0x0062995A
	[NullableContext(1)]
	private UUIItem GetUiBlurComponent()
	{
		if (this.OverrideItem != null)
		{
			return this.OverrideItem.RootComponent as UUIItem;
		}
		return this.ApplyItem;
	}

	// Token: 0x06015364 RID: 86884 RVA: 0x0062B77B File Offset: 0x0062997B
	private void SetGlobalBlurUiItem()
	{
		if (this.ApplyItem != null)
		{
			ULGUIBPLibrary.SetGlobalBlurUIItem(this.GetUiBlurComponent(), this.ApplyItem.GetWorld());
		}
	}

	// Token: 0x06015365 RID: 86885 RVA: 0x0062B79B File Offset: 0x0062999B
	private void ResetGlobalBlurUiItem()
	{
		ULGUIBPLibrary.ResetGlobalBlurUIItem(GlobalData.GameInstance.GetWorld());
	}

	// Token: 0x06015366 RID: 86886 RVA: 0x0062B7AC File Offset: 0x006299AC
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void SetEnableUiBlur(bool value)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsUiBlur) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("SetEnableUiBlur"), TsUiBlur.StaticClass(), out intPtr, out num))
		{
			this.SetEnableUiBlur_Implementation(value);
			return;
		}
		TsUiBlur.__SetEnableUiBlur_FunctionParams* ptr = stackalloc TsUiBlur.__SetEnableUiBlur_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsUiBlur.__SetEnableUiBlur_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->value = value;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x06015367 RID: 86887 RVA: 0x0062B838 File Offset: 0x00629A38
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

	// Token: 0x06015368 RID: 86888 RVA: 0x0062B851 File Offset: 0x00629A51
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsUiBlur._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Module/UiComponent/Effect/TsUiBlur.TsUiBlur_C");
		}
		return TsUiBlur._ClassPtr;
	}

	// Token: 0x06015369 RID: 86889 RVA: 0x0062B878 File Offset: 0x00629A78
	public TsUiBlur() : this(BuiltinUtils.AllocNativeUObject(TsUiBlur.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601536A RID: 86890 RVA: 0x0062B8A0 File Offset: 0x00629AA0
	[NullableContext(1)]
	public TsUiBlur(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsUiBlur.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601536B RID: 86891 RVA: 0x0062B8D3 File Offset: 0x00629AD3
	protected TsUiBlur(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601536C RID: 86892 RVA: 0x0062B8DC File Offset: 0x00629ADC
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_SetEnableUiBlur_Implementation(TsUiBlur.__SetEnableUiBlur_FunctionParams* __Params)
	{
		this.SetEnableUiBlur_Implementation(__Params->value);
	}

	// Token: 0x0400B3DD RID: 46045
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Module/UiComponent/Effect/TsUiBlur.TsUiBlur_C";

	// Token: 0x0400B3DE RID: 46046
	private static IntPtr _ClassPtr;

	// Token: 0x0400B3DF RID: 46047
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400B3E0 RID: 46048
	private static int __PropertyOffset_OverrideItem;

	// Token: 0x0400B3E1 RID: 46049
	private static int __PropertyOffset_EnableUiBlur;

	// Token: 0x0400B3E2 RID: 46050
	private static int __PropertyOffset_ApplyItem;

	// Token: 0x02008465 RID: 33893
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1)]
	protected ref struct __SetEnableUiBlur_FunctionParams
	{
		// Token: 0x0402AB4C RID: 174924
		[FieldOffset(0)]
		public bool value;
	}
}

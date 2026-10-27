using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02002CCF RID: 11471
[NullableContext(2)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/Module/UiNavigation/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Module/UiNavigation/TsUiNavigationScrollControlSize.TsUiNavigationScrollControlSize_C")]
public class TsUiNavigationScrollControlSize : ULGUIBehaviour, IUnrealUObject, IUnrealObject
{
	// Token: 0x17002072 RID: 8306
	// (get) Token: 0x060180F1 RID: 98545 RVA: 0x0061E35C File Offset: 0x0061C55C
	// (set) Token: 0x060180F2 RID: 98546 RVA: 0x0061E370 File Offset: 0x0061C570
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe AActor ScrollViewActor
	{
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + TsUiNavigationScrollControlSize.__PropertyOffset_ScrollViewActor);
		}
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + TsUiNavigationScrollControlSize.__PropertyOffset_ScrollViewActor, value);
		}
	}

	// Token: 0x060180F3 RID: 98547 RVA: 0x0061E388 File Offset: 0x0061C588
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

	// Token: 0x060180F4 RID: 98548 RVA: 0x0061E3F8 File Offset: 0x0061C5F8
	protected virtual void AwakeBP_Implementation()
	{
		AActor owner = base.GetOwner();
		this.SizeController = (((owner != null) ? owner.GetComponentByClass(UUISizeControlByOther.StaticClass()) : null) as UUISizeControlByOther);
		if (this.SizeController == null)
		{
			Log.Instance.Error(ELogModule.UiNavigation, ELogAuthor.XXJ, "该组件需要放在有SizeControlByOther的Actor上", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		AActor scrollViewActor = this.ScrollViewActor;
		this.ScrollView = (((scrollViewActor != null) ? scrollViewActor.GetComponentByClass(UUIScrollViewWithScrollbarComponent.StaticClass()) : null) as UUIScrollViewWithScrollbarComponent);
		UUIScrollViewWithScrollbarComponent scrollView = this.ScrollView;
		UUIItem contentItem;
		if (scrollView == null)
		{
			contentItem = null;
		}
		else
		{
			AUIBaseActor content = scrollView.GetContent();
			contentItem = ((content != null) ? content.GetUIItem() : null);
		}
		this.ContentItem = contentItem;
		if (this.ScrollView == null || this.ContentItem == null)
		{
			return;
		}
		this.SizeController.SetTargetActor(this.ScrollViewActor as AUIBaseActor);
		this.UseScroll = true;
	}

	// Token: 0x060180F5 RID: 98549 RVA: 0x0061E4D0 File Offset: 0x0061C6D0
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void LateUpdateBP(float deltaTime)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("LateUpdateBP"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		ULGUIBehaviour.__LateUpdateBP_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((ULGUIBehaviour.__LateUpdateBP_FunctionParams*)ptr + 15L / (long)sizeof(ULGUIBehaviour.__LateUpdateBP_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->DeltaTime = deltaTime;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x060180F6 RID: 98550 RVA: 0x0061E548 File Offset: 0x0061C748
	protected virtual void LateUpdateBP_Implementation(float deltaTime)
	{
		if (this.ScrollView == null || this.SizeController == null)
		{
			return;
		}
		if (this.ScrollValue == 0f)
		{
			this.ScrollValue = (this.ScrollView.Vertical ? this.ScrollView.RootUIComp.Get().GetHeight() : this.ScrollView.RootUIComp.Get().GetWidth());
		}
		float num;
		if (!this.ScrollView.Vertical)
		{
			UUIItem contentItem = this.ContentItem;
			num = ((contentItem != null) ? contentItem.GetWidth() : 0f);
		}
		else
		{
			UUIItem contentItem2 = this.ContentItem;
			num = ((contentItem2 != null) ? contentItem2.GetHeight() : 0f);
		}
		float num2 = num;
		if (num2 <= this.ScrollValue && this.UseScroll)
		{
			this.UseScroll = false;
			this.SizeController.SetTargetActor(this.ScrollView.Content);
			return;
		}
		if (num2 > this.ScrollValue && !this.UseScroll)
		{
			this.UseScroll = true;
			this.SizeController.SetTargetActor(this.ScrollViewActor as AUIBaseActor);
		}
	}

	// Token: 0x060180F7 RID: 98551 RVA: 0x0061E658 File Offset: 0x0061C858
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

	// Token: 0x060180F8 RID: 98552 RVA: 0x0061E6C8 File Offset: 0x0061C8C8
	protected virtual void OnDisableBP_Implementation()
	{
		this.ScrollValue = 0f;
	}

	// Token: 0x060180F9 RID: 98553 RVA: 0x0061E6D5 File Offset: 0x0061C8D5
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsUiNavigationScrollControlSize._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Module/UiNavigation/TsUiNavigationScrollControlSize.TsUiNavigationScrollControlSize_C");
		}
		return TsUiNavigationScrollControlSize._ClassPtr;
	}

	// Token: 0x060180FA RID: 98554 RVA: 0x0061E6FC File Offset: 0x0061C8FC
	public TsUiNavigationScrollControlSize() : this(BuiltinUtils.AllocNativeUObject(TsUiNavigationScrollControlSize.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060180FB RID: 98555 RVA: 0x0061E724 File Offset: 0x0061C924
	[NullableContext(1)]
	public TsUiNavigationScrollControlSize(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsUiNavigationScrollControlSize.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060180FC RID: 98556 RVA: 0x0061E757 File Offset: 0x0061C957
	protected TsUiNavigationScrollControlSize(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060180FD RID: 98557 RVA: 0x0061E760 File Offset: 0x0061C960
	protected virtual void __CPPCALL_AwakeBP_Implementation()
	{
		this.AwakeBP_Implementation();
	}

	// Token: 0x060180FE RID: 98558 RVA: 0x0061E768 File Offset: 0x0061C968
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_LateUpdateBP_Implementation(ULGUIBehaviour.__LateUpdateBP_FunctionParams* __Params)
	{
		this.LateUpdateBP_Implementation(__Params->DeltaTime);
	}

	// Token: 0x060180FF RID: 98559 RVA: 0x0061E776 File Offset: 0x0061C976
	protected virtual void __CPPCALL_OnDisableBP_Implementation()
	{
		this.OnDisableBP_Implementation();
	}

	// Token: 0x0400B300 RID: 45824
	private UUIScrollViewWithScrollbarComponent ScrollView;

	// Token: 0x0400B301 RID: 45825
	private UUISizeControlByOther SizeController;

	// Token: 0x0400B302 RID: 45826
	private float ScrollValue;

	// Token: 0x0400B303 RID: 45827
	private UUIItem ContentItem;

	// Token: 0x0400B304 RID: 45828
	private bool UseScroll;

	// Token: 0x0400B305 RID: 45829
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Module/UiNavigation/TsUiNavigationScrollControlSize.TsUiNavigationScrollControlSize_C";

	// Token: 0x0400B306 RID: 45830
	private static IntPtr _ClassPtr;

	// Token: 0x0400B307 RID: 45831
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400B308 RID: 45832
	private static int __PropertyOffset_ScrollViewActor;
}

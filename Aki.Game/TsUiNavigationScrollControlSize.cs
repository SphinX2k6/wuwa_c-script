using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02002228 RID: 8744
[NullableContext(2)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/Module/UiNavigation/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Module/UiNavigation/TsUiNavigationScrollControlSize.TsUiNavigationScrollControlSize_C")]
public class TsUiNavigationScrollControlSize : ULGUIBehaviour, IUnrealUObject, IUnrealObject
{
	// Token: 0x170020C5 RID: 8389
	// (get) Token: 0x0601596E RID: 88430 RVA: 0x00643F18 File Offset: 0x00642118
	// (set) Token: 0x0601596F RID: 88431 RVA: 0x00643F2C File Offset: 0x0064212C
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

	// Token: 0x06015970 RID: 88432 RVA: 0x00643F44 File Offset: 0x00642144
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public override void AwakeBP()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(TsUiNavigationScrollControlSize) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("AwakeBP"), TsUiNavigationScrollControlSize.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.AwakeBP_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x06015971 RID: 88433 RVA: 0x00643FA0 File Offset: 0x006421A0
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

	// Token: 0x06015972 RID: 88434 RVA: 0x00644078 File Offset: 0x00642278
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void LateUpdateBP(float deltaTime)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsUiNavigationScrollControlSize) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("LateUpdateBP"), TsUiNavigationScrollControlSize.StaticClass(), out intPtr, out num))
		{
			this.LateUpdateBP_Implementation(deltaTime);
			return;
		}
		ULGUIBehaviour.__LateUpdateBP_FunctionParams* ptr = stackalloc ULGUIBehaviour.__LateUpdateBP_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(ULGUIBehaviour.__LateUpdateBP_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->DeltaTime = deltaTime;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x06015973 RID: 88435 RVA: 0x00644104 File Offset: 0x00642304
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

	// Token: 0x06015974 RID: 88436 RVA: 0x00644214 File Offset: 0x00642414
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public override void OnDisableBP()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(TsUiNavigationScrollControlSize) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("OnDisableBP"), TsUiNavigationScrollControlSize.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.OnDisableBP_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x06015975 RID: 88437 RVA: 0x0064426D File Offset: 0x0064246D
	protected virtual void OnDisableBP_Implementation()
	{
		this.ScrollValue = 0f;
	}

	// Token: 0x06015976 RID: 88438 RVA: 0x0064427A File Offset: 0x0064247A
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsUiNavigationScrollControlSize._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Module/UiNavigation/TsUiNavigationScrollControlSize.TsUiNavigationScrollControlSize_C");
		}
		return TsUiNavigationScrollControlSize._ClassPtr;
	}

	// Token: 0x06015977 RID: 88439 RVA: 0x006442A0 File Offset: 0x006424A0
	public TsUiNavigationScrollControlSize() : this(BuiltinUtils.AllocNativeUObject(TsUiNavigationScrollControlSize.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06015978 RID: 88440 RVA: 0x006442C8 File Offset: 0x006424C8
	[NullableContext(1)]
	public TsUiNavigationScrollControlSize(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsUiNavigationScrollControlSize.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06015979 RID: 88441 RVA: 0x006442FB File Offset: 0x006424FB
	protected TsUiNavigationScrollControlSize(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601597A RID: 88442 RVA: 0x00644304 File Offset: 0x00642504
	protected virtual void __CPPCALL_AwakeBP_Implementation()
	{
		this.AwakeBP_Implementation();
	}

	// Token: 0x0601597B RID: 88443 RVA: 0x0064430C File Offset: 0x0064250C
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_LateUpdateBP_Implementation(ULGUIBehaviour.__LateUpdateBP_FunctionParams* __Params)
	{
		this.LateUpdateBP_Implementation(__Params->DeltaTime);
	}

	// Token: 0x0601597C RID: 88444 RVA: 0x0064431A File Offset: 0x0064251A
	protected virtual void __CPPCALL_OnDisableBP_Implementation()
	{
		this.OnDisableBP_Implementation();
	}

	// Token: 0x0400B66C RID: 46700
	private UUIScrollViewWithScrollbarComponent ScrollView;

	// Token: 0x0400B66D RID: 46701
	private UUISizeControlByOther SizeController;

	// Token: 0x0400B66E RID: 46702
	private float ScrollValue;

	// Token: 0x0400B66F RID: 46703
	private UUIItem ContentItem;

	// Token: 0x0400B670 RID: 46704
	private bool UseScroll;

	// Token: 0x0400B671 RID: 46705
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Module/UiNavigation/TsUiNavigationScrollControlSize.TsUiNavigationScrollControlSize_C";

	// Token: 0x0400B672 RID: 46706
	private static IntPtr _ClassPtr;

	// Token: 0x0400B673 RID: 46707
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400B674 RID: 46708
	private static int __PropertyOffset_ScrollViewActor;
}

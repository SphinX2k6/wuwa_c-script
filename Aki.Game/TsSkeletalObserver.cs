using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02002A19 RID: 10777
[UClass("/Game/Aki/TypeScript/Game/Module/SkeletalObserver/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Module/SkeletalObserver/TsSkeletalObserver.TsSkeletalObserver_C")]
public class TsSkeletalObserver : AActor, IUnrealUObject, IUnrealObject
{
	// Token: 0x17001DD3 RID: 7635
	// (get) Token: 0x060165ED RID: 91629 RVA: 0x005A960B File Offset: 0x005A780B
	// (set) Token: 0x060165EE RID: 91630 RVA: 0x005A9613 File Offset: 0x005A7813
	public EUiModelUseWay UseWay { get; set; }

	// Token: 0x060165EF RID: 91631 RVA: 0x005A961C File Offset: 0x005A781C
	public void Init(EUiModelUseWay useWay)
	{
		base.SetTickableWhenPaused(true);
		base.SetActorTickEnabled(true);
		UKuroRenderingRuntimeBPPluginBPLibrary.SetActorUISceneRendering(this, true);
		this.UseWay = useWay;
		this.Model = UiModelSystem.Instance.CreateUiModelByUseWay(useWay, this);
		this.Model.Init();
		this.Model.Start();
		Log instance = Log.Instance;
		ELogModule module = ELogModule.UiCommon;
		ELogAuthor author = ELogAuthor.YZY;
		string message = "TsSkeletalObserver Init";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("UseWay", this.UseWay);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x060165F0 RID: 91632 RVA: 0x005A96A0 File Offset: 0x005A78A0
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveTick(float deltaSecond)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("ReceiveTick"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		AActor.__ReceiveTick_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((AActor.__ReceiveTick_FunctionParams*)ptr + 15L / (long)sizeof(AActor.__ReceiveTick_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->DeltaSeconds = deltaSecond;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x060165F1 RID: 91633 RVA: 0x005A9716 File Offset: 0x005A7916
	protected virtual void ReceiveTick_Implementation(float deltaSecond)
	{
		UiModelBase model = this.Model;
		if (model == null)
		{
			return;
		}
		model.Tick(deltaSecond);
	}

	// Token: 0x060165F2 RID: 91634 RVA: 0x005A972C File Offset: 0x005A792C
	public void Destroy()
	{
		UiModelBase model = this.Model;
		if (model != null)
		{
			model.End();
		}
		UiModelBase model2 = this.Model;
		if (model2 != null)
		{
			model2.Clear();
		}
		this.Model = null;
		ActorSystem.Instance.Put("TsSkeletalObserver.Destroy", this, null);
		Log instance = Log.Instance;
		ELogModule module = ELogModule.UiCommon;
		ELogAuthor author = ELogAuthor.YZY;
		string message = "TsSkeletalObserver Destroy";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("UseWay", this.UseWay);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x060165F3 RID: 91635 RVA: 0x005A97A5 File Offset: 0x005A79A5
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsSkeletalObserver._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Module/SkeletalObserver/TsSkeletalObserver.TsSkeletalObserver_C");
		}
		return TsSkeletalObserver._ClassPtr;
	}

	// Token: 0x060165F4 RID: 91636 RVA: 0x005A97CC File Offset: 0x005A79CC
	public TsSkeletalObserver() : this(BuiltinUtils.AllocNativeUObject(TsSkeletalObserver.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060165F5 RID: 91637 RVA: 0x005A97F4 File Offset: 0x005A79F4
	[NullableContext(1)]
	public TsSkeletalObserver(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsSkeletalObserver.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060165F6 RID: 91638 RVA: 0x005A9827 File Offset: 0x005A7A27
	protected TsSkeletalObserver(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x17001DD4 RID: 7636
	// (get) Token: 0x060165F7 RID: 91639 RVA: 0x005A9830 File Offset: 0x005A7A30
	[Nullable(1)]
	public unsafe FPointerToUberGraphFrame UberGraphFrame
	{
		[NullableContext(1)]
		get
		{
			return *(base.NativePtr + (IntPtr)TsSkeletalObserver.__PropertyOffset_UberGraphFrame);
		}
	}

	// Token: 0x17001DD5 RID: 7637
	// (get) Token: 0x060165F8 RID: 91640 RVA: 0x005A9840 File Offset: 0x005A7A40
	[Nullable(2)]
	public unsafe USceneComponent DefaultSceneRoot
	{
		[NullableContext(2)]
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + TsSkeletalObserver.__PropertyOffset_DefaultSceneRoot);
		}
	}

	// Token: 0x060165F9 RID: 91641 RVA: 0x005A9854 File Offset: 0x005A7A54
	protected unsafe virtual void __CPPCALL_ReceiveTick_Implementation(AActor.__ReceiveTick_FunctionParams* __Params)
	{
		this.ReceiveTick_Implementation(__Params->DeltaSeconds);
	}

	// Token: 0x0400A67A RID: 42618
	[Nullable(2)]
	public UiModelBase Model;

	// Token: 0x0400A67C RID: 42620
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Module/SkeletalObserver/TsSkeletalObserver.TsSkeletalObserver_C";

	// Token: 0x0400A67D RID: 42621
	private static IntPtr _ClassPtr;

	// Token: 0x0400A67E RID: 42622
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400A67F RID: 42623
	private static int __PropertyOffset_UberGraphFrame;

	// Token: 0x0400A680 RID: 42624
	private static int __PropertyOffset_DefaultSceneRoot;

	// Token: 0x02009056 RID: 36950
	// (Invoke) Token: 0x0604BABF RID: 309951
	public delegate void TLoadSkeletalMeshCallBack(USkeletalMesh skeletalMesh);
}

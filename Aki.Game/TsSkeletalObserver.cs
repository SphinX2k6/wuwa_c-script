using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02001F94 RID: 8084
[UClass("/Game/Aki/TypeScript/Game/Module/SkeletalObserver/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Module/SkeletalObserver/TsSkeletalObserver.TsSkeletalObserver_C")]
public class TsSkeletalObserver : AActor, IUnrealUObject, IUnrealObject
{
	// Token: 0x17001E2C RID: 7724
	// (get) Token: 0x06013FF4 RID: 81908 RVA: 0x005D45E3 File Offset: 0x005D27E3
	// (set) Token: 0x06013FF5 RID: 81909 RVA: 0x005D45EB File Offset: 0x005D27EB
	public EUiModelUseWay UseWay { get; set; }

	// Token: 0x06013FF6 RID: 81910 RVA: 0x005D45F4 File Offset: 0x005D27F4
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

	// Token: 0x06013FF7 RID: 81911 RVA: 0x005D4678 File Offset: 0x005D2878
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveTick(float deltaSecond)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsSkeletalObserver) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveTick"), TsSkeletalObserver.StaticClass(), out intPtr, out num))
		{
			this.ReceiveTick_Implementation(deltaSecond);
			return;
		}
		AActor.__ReceiveTick_FunctionParams* ptr = stackalloc AActor.__ReceiveTick_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(AActor.__ReceiveTick_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->DeltaSeconds = deltaSecond;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x06013FF8 RID: 81912 RVA: 0x005D4704 File Offset: 0x005D2904
	protected virtual void ReceiveTick_Implementation(float deltaSecond)
	{
		UiModelBase model = this.Model;
		if (model == null)
		{
			return;
		}
		model.Tick(deltaSecond);
	}

	// Token: 0x06013FF9 RID: 81913 RVA: 0x005D4718 File Offset: 0x005D2918
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

	// Token: 0x06013FFA RID: 81914 RVA: 0x005D4791 File Offset: 0x005D2991
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsSkeletalObserver._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Module/SkeletalObserver/TsSkeletalObserver.TsSkeletalObserver_C");
		}
		return TsSkeletalObserver._ClassPtr;
	}

	// Token: 0x06013FFB RID: 81915 RVA: 0x005D47B8 File Offset: 0x005D29B8
	public TsSkeletalObserver() : this(BuiltinUtils.AllocNativeUObject(TsSkeletalObserver.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06013FFC RID: 81916 RVA: 0x005D47E0 File Offset: 0x005D29E0
	[NullableContext(1)]
	public TsSkeletalObserver(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsSkeletalObserver.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06013FFD RID: 81917 RVA: 0x005D4813 File Offset: 0x005D2A13
	protected TsSkeletalObserver(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x17001E2D RID: 7725
	// (get) Token: 0x06013FFE RID: 81918 RVA: 0x005D481C File Offset: 0x005D2A1C
	[Nullable(2)]
	public unsafe USceneComponent DefaultSceneRoot
	{
		[NullableContext(2)]
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + TsSkeletalObserver.__PropertyOffset_DefaultSceneRoot);
		}
	}

	// Token: 0x06013FFF RID: 81919 RVA: 0x005D4830 File Offset: 0x005D2A30
	protected unsafe virtual void __CPPCALL_ReceiveTick_Implementation(AActor.__ReceiveTick_FunctionParams* __Params)
	{
		this.ReceiveTick_Implementation(__Params->DeltaSeconds);
	}

	// Token: 0x0400AA64 RID: 43620
	[Nullable(2)]
	public UiModelBase Model;

	// Token: 0x0400AA66 RID: 43622
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Module/SkeletalObserver/TsSkeletalObserver.TsSkeletalObserver_C";

	// Token: 0x0400AA67 RID: 43623
	private static IntPtr _ClassPtr;

	// Token: 0x0400AA68 RID: 43624
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400AA69 RID: 43625
	private static int __PropertyOffset_DefaultSceneRoot;

	// Token: 0x0200829D RID: 33437
	// (Invoke) Token: 0x06041FB6 RID: 270262
	public delegate void TLoadSkeletalMeshCallBack(USkeletalMesh skeletalMesh);
}

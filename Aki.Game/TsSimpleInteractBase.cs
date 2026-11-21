using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Core.World;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200281F RID: 10271
[NullableContext(2)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/NewWorld/SceneItem/SimpleBlueprintItem/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/SceneItem/SimpleBlueprintItem/TsSimpleInteractBase.TsSimpleInteractBase_C")]
public class TsSimpleInteractBase : AKuroEffectActor, IUnrealUObject, IUnrealObject
{
	// Token: 0x170029BD RID: 10685
	// (get) Token: 0x06019DE9 RID: 105961 RVA: 0x007F8556 File Offset: 0x007F6756
	// (set) Token: 0x06019DEA RID: 105962 RVA: 0x007F8566 File Offset: 0x007F6766
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int TypeId
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsSimpleInteractBase.__PropertyOffset_TypeId);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsSimpleInteractBase.__PropertyOffset_TypeId) = value;
		}
	}

	// Token: 0x170029BE RID: 10686
	// (get) Token: 0x06019DEB RID: 105963 RVA: 0x007F8577 File Offset: 0x007F6777
	// (set) Token: 0x06019DEC RID: 105964 RVA: 0x007F858B File Offset: 0x007F678B
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe UTextRenderComponent Text
	{
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<UTextRenderComponent>(base.NativePtr / (IntPtr)sizeof(void*) + TsSimpleInteractBase.__PropertyOffset_Text);
		}
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + TsSimpleInteractBase.__PropertyOffset_Text, value);
		}
	}

	// Token: 0x06019DED RID: 105965 RVA: 0x007F85A0 File Offset: 0x007F67A0
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public override void ReceiveBeginPlay()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(TsSimpleInteractBase) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveBeginPlay"), TsSimpleInteractBase.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.ReceiveBeginPlay_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x06019DEE RID: 105966 RVA: 0x007F85F9 File Offset: 0x007F67F9
	protected virtual void ReceiveBeginPlay_Implementation()
	{
		this.OnBeginPlay();
	}

	// Token: 0x06019DEF RID: 105967 RVA: 0x007F8604 File Offset: 0x007F6804
	protected virtual void OnBeginPlay()
	{
		WorldModel.Instance.AddTsSimpleInteractItem(this);
		this.SelfTransform = Transform.Create();
		this.SelfLocation = Vector.Create();
		this.TmpResult = default(SSimpleInteractResult);
		this.ActorLocation = Vector.Create();
		this.SelfToActor = Vector.Create();
		this.MoveOffset = Vector.Create();
		this.TmpVector1 = Vector.Create();
		this.TmpVector2 = Vector.Create();
		this.TmpVector3 = Vector.Create();
		this.TmpVector4 = Vector.Create();
		this.Text.SetHiddenInGame(true, false);
		this.Text.SetComponentTickEnabled(false);
		this.InitTraceInfo();
		this.UpdateData();
	}

	// Token: 0x06019DF0 RID: 105968 RVA: 0x007F86B0 File Offset: 0x007F68B0
	protected virtual void UpdateData()
	{
		Transform selfTransform = this.SelfTransform;
		FTransformDouble ftransformDouble = base.D_GetTransform();
		selfTransform.FromUeTransform(ftransformDouble);
		this.SelfLocation.DeepCopy(this.SelfTransform.GetLocation());
	}

	// Token: 0x06019DF1 RID: 105969 RVA: 0x007F86E7 File Offset: 0x007F68E7
	protected void InitTraceInfo()
	{
		this.LineTrace = new UTraceLineElement();
		this.LineTrace.bIsSingle = true;
		this.LineTrace.bIgnoreSelf = true;
		this.LineTrace.SetTraceTypeQuery(KuroTraceTypeQuery.Visible);
	}

	// Token: 0x06019DF2 RID: 105970 RVA: 0x007F871C File Offset: 0x007F691C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsSimpleInteractBase) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveEndPlay"), TsSimpleInteractBase.StaticClass(), out intPtr, out num))
		{
			this.ReceiveEndPlay_Implementation(EndPlayReason);
			return;
		}
		AActor.__ReceiveEndPlay_FunctionParams* ptr = stackalloc AActor.__ReceiveEndPlay_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(AActor.__ReceiveEndPlay_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(byte*)(&ptr->EndPlayReason) = (byte)EndPlayReason;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x06019DF3 RID: 105971 RVA: 0x007F87AB File Offset: 0x007F69AB
	protected virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
	{
		WorldModel.Instance.RemoveTsSimpleInteractItem(this);
	}

	// Token: 0x06019DF4 RID: 105972 RVA: 0x007F87B8 File Offset: 0x007F69B8
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public override void EditorInit()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(TsSimpleInteractBase) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("EditorInit"), TsSimpleInteractBase.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.EditorInit_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x06019DF5 RID: 105973 RVA: 0x007F8811 File Offset: 0x007F6A11
	protected virtual void EditorInit_Implementation()
	{
		base.bEditorTickBySelected = false;
	}

	// Token: 0x06019DF6 RID: 105974 RVA: 0x007F881C File Offset: 0x007F6A1C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void EditorTick(float deltaSeconds)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsSimpleInteractBase) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("EditorTick"), TsSimpleInteractBase.StaticClass(), out intPtr, out num))
		{
			this.EditorTick_Implementation(deltaSeconds);
			return;
		}
		AKuroEffectActor.__EditorTick_FunctionParams* ptr = stackalloc AKuroEffectActor.__EditorTick_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(AKuroEffectActor.__EditorTick_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->DeltaSeconds = deltaSeconds;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x06019DF7 RID: 105975 RVA: 0x007F88A8 File Offset: 0x007F6AA8
	protected virtual void EditorTick_Implementation(float deltaSeconds)
	{
		if (this.CheckDraw(deltaSeconds))
		{
			this.OnDraw();
		}
	}

	// Token: 0x06019DF8 RID: 105976 RVA: 0x007F88BC File Offset: 0x007F6ABC
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual SSimpleInteractResult GetBestTransform(AActor actor, FVector moveOffset, float halfHeight, float radius)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsSimpleInteractBase) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetBestTransform"), TsSimpleInteractBase.StaticClass(), out intPtr, out num))
		{
			return this.GetBestTransform_Implementation(actor, moveOffset, halfHeight, radius);
		}
		TsSimpleInteractBase.__GetBestTransform_FunctionParams* ptr = stackalloc TsSimpleInteractBase.__GetBestTransform_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsSimpleInteractBase.__GetBestTransform_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->actor) = ((actor != null) ? actor.NativePtr : ((IntPtr)0));
		ptr->moveOffset = moveOffset;
		ptr->halfHeight = halfHeight;
		ptr->radius = radius;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		SSimpleInteractResult _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x06019DF9 RID: 105977 RVA: 0x007F8976 File Offset: 0x007F6B76
	[NullableContext(1)]
	protected SSimpleInteractResult GetBestTransform_Implementation(AActor actor, FVector moveOffset, float halfHeight, float radius)
	{
		return this.OnGetBestTransform(actor, moveOffset, halfHeight, radius);
	}

	// Token: 0x06019DFA RID: 105978 RVA: 0x007F8983 File Offset: 0x007F6B83
	[NullableContext(1)]
	protected virtual SSimpleInteractResult OnGetBestTransform(AActor actor, FVector moveOffset, float halfHeight, float radius)
	{
		this.TmpResult.Success = false;
		return this.TmpResult;
	}

	// Token: 0x06019DFB RID: 105979 RVA: 0x007F8998 File Offset: 0x007F6B98
	private bool CheckDraw(float deltaSeconds)
	{
		if (this.CheckDrawTime == 0f)
		{
			this.CheckDrawTime = 0f;
		}
		this.CheckDrawTime -= deltaSeconds;
		if (this.CheckDrawTime < 0f)
		{
			this.CheckDrawTime = 0.45f;
			FVector fvector = new FVector();
			FRotator frotator = new FRotator();
			UKuroRenderingRuntimeBPPluginBPLibrary.GetLevelEditorCameraLocationAndForward(this, ref fvector, ref frotator);
			FVectorDouble fvectorDouble = base.D_K2_GetActorLocation();
			FVector text = fvector;
			text.X -= (float)fvectorDouble.X;
			text.Y -= (float)fvectorDouble.Y;
			text.Z -= (float)fvectorDouble.Z;
			this.LastCheckDrawResult = (text.SizeSquared() < 25000000f);
			this.IsLegal = this.CheckLegal();
			this.SetText(text);
			return this.LastCheckDrawResult;
		}
		return this.LastCheckDrawResult;
	}

	// Token: 0x06019DFC RID: 105980 RVA: 0x007F8A71 File Offset: 0x007F6C71
	protected virtual bool CheckLegal()
	{
		return false;
	}

	// Token: 0x06019DFD RID: 105981 RVA: 0x007F8A74 File Offset: 0x007F6C74
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public virtual void Draw()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(TsSimpleInteractBase) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("Draw"), TsSimpleInteractBase.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.Draw_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x06019DFE RID: 105982 RVA: 0x007F8ACD File Offset: 0x007F6CCD
	protected void Draw_Implementation()
	{
		this.OnDraw();
	}

	// Token: 0x06019DFF RID: 105983 RVA: 0x007F8AD5 File Offset: 0x007F6CD5
	protected virtual void OnDraw()
	{
	}

	// Token: 0x06019E00 RID: 105984 RVA: 0x007F8AD7 File Offset: 0x007F6CD7
	protected virtual void SetText(FVector offset)
	{
	}

	// Token: 0x06019E01 RID: 105985 RVA: 0x007F8AD9 File Offset: 0x007F6CD9
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsSimpleInteractBase._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/NewWorld/SceneItem/SimpleBlueprintItem/TsSimpleInteractBase.TsSimpleInteractBase_C");
		}
		return TsSimpleInteractBase._ClassPtr;
	}

	// Token: 0x06019E02 RID: 105986 RVA: 0x007F8B00 File Offset: 0x007F6D00
	public TsSimpleInteractBase() : this(BuiltinUtils.AllocNativeUObject(TsSimpleInteractBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06019E03 RID: 105987 RVA: 0x007F8B28 File Offset: 0x007F6D28
	[NullableContext(1)]
	public TsSimpleInteractBase(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsSimpleInteractBase.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06019E04 RID: 105988 RVA: 0x007F8B5B File Offset: 0x007F6D5B
	protected TsSimpleInteractBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06019E05 RID: 105989 RVA: 0x007F8B64 File Offset: 0x007F6D64
	protected virtual void __CPPCALL_ReceiveBeginPlay_Implementation()
	{
		this.ReceiveBeginPlay_Implementation();
	}

	// Token: 0x06019E06 RID: 105990 RVA: 0x007F8B6C File Offset: 0x007F6D6C
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveEndPlay_Implementation(AActor.__ReceiveEndPlay_FunctionParams* __Params)
	{
		EEndPlayReason endPlayReason = __Params->EndPlayReason;
		this.ReceiveEndPlay_Implementation(endPlayReason);
	}

	// Token: 0x06019E07 RID: 105991 RVA: 0x007F8B8C File Offset: 0x007F6D8C
	protected virtual void __CPPCALL_EditorInit_Implementation()
	{
		this.EditorInit_Implementation();
	}

	// Token: 0x06019E08 RID: 105992 RVA: 0x007F8B94 File Offset: 0x007F6D94
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_EditorTick_Implementation(AKuroEffectActor.__EditorTick_FunctionParams* __Params)
	{
		this.EditorTick_Implementation(__Params->DeltaSeconds);
	}

	// Token: 0x06019E09 RID: 105993 RVA: 0x007F8BA4 File Offset: 0x007F6DA4
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetBestTransform_Implementation(TsSimpleInteractBase.__GetBestTransform_FunctionParams* __Params)
	{
		AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(__Params->actor);
		__Params->__Result = this.GetBestTransform_Implementation(orCreateUObjectByNativePointer, __Params->moveOffset, __Params->halfHeight, __Params->radius);
	}

	// Token: 0x06019E0A RID: 105994 RVA: 0x007F8BDC File Offset: 0x007F6DDC
	protected virtual void __CPPCALL_Draw_Implementation()
	{
		this.Draw_Implementation();
	}

	// Token: 0x0400E2B7 RID: 58039
	private const float CHECK_DRAW_PERIODIC = 0.45f;

	// Token: 0x0400E2B8 RID: 58040
	private const float CHECK_DRAW_THREADHOLD = 25000000f;

	// Token: 0x0400E2B9 RID: 58041
	private float CheckDrawTime;

	// Token: 0x0400E2BA RID: 58042
	private bool LastCheckDrawResult;

	// Token: 0x0400E2BB RID: 58043
	protected bool IsLegal;

	// Token: 0x0400E2BC RID: 58044
	protected Transform SelfTransform;

	// Token: 0x0400E2BD RID: 58045
	protected Vector SelfLocation;

	// Token: 0x0400E2BE RID: 58046
	protected SSimpleInteractResult TmpResult;

	// Token: 0x0400E2BF RID: 58047
	protected Vector ActorLocation;

	// Token: 0x0400E2C0 RID: 58048
	protected Vector SelfToActor;

	// Token: 0x0400E2C1 RID: 58049
	protected Vector MoveOffset;

	// Token: 0x0400E2C2 RID: 58050
	protected Vector TmpVector1;

	// Token: 0x0400E2C3 RID: 58051
	protected Vector TmpVector2;

	// Token: 0x0400E2C4 RID: 58052
	protected Vector TmpVector3;

	// Token: 0x0400E2C5 RID: 58053
	protected Vector TmpVector4;

	// Token: 0x0400E2C6 RID: 58054
	protected UTraceLineElement LineTrace;

	// Token: 0x0400E2C7 RID: 58055
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/SceneItem/SimpleBlueprintItem/TsSimpleInteractBase.TsSimpleInteractBase_C";

	// Token: 0x0400E2C8 RID: 58056
	private static IntPtr _ClassPtr;

	// Token: 0x0400E2C9 RID: 58057
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400E2CA RID: 58058
	private static int __PropertyOffset_TypeId;

	// Token: 0x0400E2CB RID: 58059
	private static int __PropertyOffset_Text;

	// Token: 0x02008970 RID: 35184
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 64)]
	protected ref struct __GetBestTransform_FunctionParams
	{
		// Token: 0x0402BD06 RID: 179462
		[FieldOffset(0)]
		public IntPtr actor;

		// Token: 0x0402BD07 RID: 179463
		[FieldOffset(8)]
		public FVector moveOffset;

		// Token: 0x0402BD08 RID: 179464
		[FieldOffset(20)]
		public float halfHeight;

		// Token: 0x0402BD09 RID: 179465
		[FieldOffset(24)]
		public float radius;

		// Token: 0x0402BD0A RID: 179466
		[FieldOffset(28)]
		public SSimpleInteractResult __Result;
	}
}

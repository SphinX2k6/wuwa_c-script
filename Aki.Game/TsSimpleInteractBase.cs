using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Core.World;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020032AE RID: 12974
[NullableContext(2)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/NewWorld/SceneItem/SimpleBlueprintItem/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/SceneItem/SimpleBlueprintItem/TsSimpleInteractBase.TsSimpleInteractBase_C")]
public class TsSimpleInteractBase : AKuroEffectActor, IUnrealUObject, IUnrealObject
{
	// Token: 0x170026D0 RID: 9936
	// (get) Token: 0x0601C1A8 RID: 115112 RVA: 0x007D145B File Offset: 0x007CF65B
	// (set) Token: 0x0601C1A9 RID: 115113 RVA: 0x007D146B File Offset: 0x007CF66B
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

	// Token: 0x170026D1 RID: 9937
	// (get) Token: 0x0601C1AA RID: 115114 RVA: 0x007D147C File Offset: 0x007CF67C
	// (set) Token: 0x0601C1AB RID: 115115 RVA: 0x007D1490 File Offset: 0x007CF690
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

	// Token: 0x0601C1AC RID: 115116 RVA: 0x007D14A8 File Offset: 0x007CF6A8
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveBeginPlay()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("ReceiveBeginPlay"), out num);
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

	// Token: 0x0601C1AD RID: 115117 RVA: 0x007D1518 File Offset: 0x007CF718
	protected virtual void ReceiveBeginPlay_Implementation()
	{
		this.OnBeginPlay();
	}

	// Token: 0x0601C1AE RID: 115118 RVA: 0x007D1520 File Offset: 0x007CF720
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

	// Token: 0x0601C1AF RID: 115119 RVA: 0x007D15CC File Offset: 0x007CF7CC
	protected virtual void UpdateData()
	{
		Transform selfTransform = this.SelfTransform;
		FTransformDouble ftransformDouble = base.D_GetTransform();
		selfTransform.FromUeTransform(ftransformDouble);
		this.SelfLocation.DeepCopy(this.SelfTransform.GetLocation());
	}

	// Token: 0x0601C1B0 RID: 115120 RVA: 0x007D1603 File Offset: 0x007CF803
	protected void InitTraceInfo()
	{
		this.LineTrace = new UTraceLineElement();
		this.LineTrace.bIsSingle = true;
		this.LineTrace.bIgnoreSelf = true;
		this.LineTrace.SetTraceTypeQuery(KuroTraceTypeQuery.Visible);
	}

	// Token: 0x0601C1B1 RID: 115121 RVA: 0x007D1638 File Offset: 0x007CF838
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("ReceiveEndPlay"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		AActor.__ReceiveEndPlay_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((AActor.__ReceiveEndPlay_FunctionParams*)ptr + 15L / (long)sizeof(AActor.__ReceiveEndPlay_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(byte*)(&ptr2->EndPlayReason) = (byte)EndPlayReason;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601C1B2 RID: 115122 RVA: 0x007D16B1 File Offset: 0x007CF8B1
	protected virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
	{
		WorldModel.Instance.RemoveTsSimpleInteractItem(this);
	}

	// Token: 0x0601C1B3 RID: 115123 RVA: 0x007D16C0 File Offset: 0x007CF8C0
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void EditorInit()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("EditorInit"), out num);
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

	// Token: 0x0601C1B4 RID: 115124 RVA: 0x007D1730 File Offset: 0x007CF930
	protected virtual void EditorInit_Implementation()
	{
		base.bEditorTickBySelected = false;
	}

	// Token: 0x0601C1B5 RID: 115125 RVA: 0x007D173C File Offset: 0x007CF93C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void EditorTick(float deltaSeconds)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("EditorTick"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		AKuroEffectActor.__EditorTick_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((AKuroEffectActor.__EditorTick_FunctionParams*)ptr + 15L / (long)sizeof(AKuroEffectActor.__EditorTick_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->DeltaSeconds = deltaSeconds;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601C1B6 RID: 115126 RVA: 0x007D17B2 File Offset: 0x007CF9B2
	protected virtual void EditorTick_Implementation(float deltaSeconds)
	{
		if (this.CheckDraw(deltaSeconds))
		{
			this.OnDraw();
		}
	}

	// Token: 0x0601C1B7 RID: 115127 RVA: 0x007D17C4 File Offset: 0x007CF9C4
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual SSimpleInteractResult GetBestTransform(AActor actor, FVector moveOffset, float halfHeight, float radius)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("GetBestTransform"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsSimpleInteractBase.__GetBestTransform_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsSimpleInteractBase.__GetBestTransform_FunctionParams*)ptr + 15L / (long)sizeof(TsSimpleInteractBase.__GetBestTransform_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->actor) = ((actor != null) ? actor.NativePtr : ((IntPtr)0));
			ptr2->moveOffset = moveOffset;
			ptr2->halfHeight = halfHeight;
			ptr2->radius = radius;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		SSimpleInteractResult _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x0601C1B8 RID: 115128 RVA: 0x007D1864 File Offset: 0x007CFA64
	[NullableContext(1)]
	protected SSimpleInteractResult GetBestTransform_Implementation(AActor actor, FVector moveOffset, float halfHeight, float radius)
	{
		return this.OnGetBestTransform(actor, moveOffset, halfHeight, radius);
	}

	// Token: 0x0601C1B9 RID: 115129 RVA: 0x007D1871 File Offset: 0x007CFA71
	[NullableContext(1)]
	protected virtual SSimpleInteractResult OnGetBestTransform(AActor actor, FVector moveOffset, float halfHeight, float radius)
	{
		this.TmpResult.Success = false;
		return this.TmpResult;
	}

	// Token: 0x0601C1BA RID: 115130 RVA: 0x007D1888 File Offset: 0x007CFA88
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

	// Token: 0x0601C1BB RID: 115131 RVA: 0x007D1961 File Offset: 0x007CFB61
	protected virtual bool CheckLegal()
	{
		return false;
	}

	// Token: 0x0601C1BC RID: 115132 RVA: 0x007D1964 File Offset: 0x007CFB64
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void Draw()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("Draw"), out num);
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

	// Token: 0x0601C1BD RID: 115133 RVA: 0x007D19D4 File Offset: 0x007CFBD4
	protected void Draw_Implementation()
	{
		this.OnDraw();
	}

	// Token: 0x0601C1BE RID: 115134 RVA: 0x007D19DC File Offset: 0x007CFBDC
	protected virtual void OnDraw()
	{
	}

	// Token: 0x0601C1BF RID: 115135 RVA: 0x007D19DE File Offset: 0x007CFBDE
	protected virtual void SetText(FVector offset)
	{
	}

	// Token: 0x0601C1C0 RID: 115136 RVA: 0x007D19E0 File Offset: 0x007CFBE0
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsSimpleInteractBase._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/NewWorld/SceneItem/SimpleBlueprintItem/TsSimpleInteractBase.TsSimpleInteractBase_C");
		}
		return TsSimpleInteractBase._ClassPtr;
	}

	// Token: 0x0601C1C1 RID: 115137 RVA: 0x007D1A04 File Offset: 0x007CFC04
	public TsSimpleInteractBase() : this(BuiltinUtils.AllocNativeUObject(TsSimpleInteractBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601C1C2 RID: 115138 RVA: 0x007D1A2C File Offset: 0x007CFC2C
	[NullableContext(1)]
	public TsSimpleInteractBase(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsSimpleInteractBase.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C1C3 RID: 115139 RVA: 0x007D1A5F File Offset: 0x007CFC5F
	protected TsSimpleInteractBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601C1C4 RID: 115140 RVA: 0x007D1A68 File Offset: 0x007CFC68
	protected virtual void __CPPCALL_ReceiveBeginPlay_Implementation()
	{
		this.ReceiveBeginPlay_Implementation();
	}

	// Token: 0x0601C1C5 RID: 115141 RVA: 0x007D1A70 File Offset: 0x007CFC70
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveEndPlay_Implementation(AActor.__ReceiveEndPlay_FunctionParams* __Params)
	{
		EEndPlayReason endPlayReason = __Params->EndPlayReason;
		this.ReceiveEndPlay_Implementation(endPlayReason);
	}

	// Token: 0x0601C1C6 RID: 115142 RVA: 0x007D1A90 File Offset: 0x007CFC90
	protected virtual void __CPPCALL_EditorInit_Implementation()
	{
		this.EditorInit_Implementation();
	}

	// Token: 0x0601C1C7 RID: 115143 RVA: 0x007D1A98 File Offset: 0x007CFC98
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_EditorTick_Implementation(AKuroEffectActor.__EditorTick_FunctionParams* __Params)
	{
		this.EditorTick_Implementation(__Params->DeltaSeconds);
	}

	// Token: 0x0601C1C8 RID: 115144 RVA: 0x007D1AA8 File Offset: 0x007CFCA8
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetBestTransform_Implementation(TsSimpleInteractBase.__GetBestTransform_FunctionParams* __Params)
	{
		AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(__Params->actor);
		__Params->__Result = this.GetBestTransform_Implementation(orCreateUObjectByNativePointer, __Params->moveOffset, __Params->halfHeight, __Params->radius);
	}

	// Token: 0x0601C1C9 RID: 115145 RVA: 0x007D1AE0 File Offset: 0x007CFCE0
	protected virtual void __CPPCALL_Draw_Implementation()
	{
		this.Draw_Implementation();
	}

	// Token: 0x0400DE11 RID: 56849
	private const float CHECK_DRAW_PERIODIC = 0.45f;

	// Token: 0x0400DE12 RID: 56850
	private const float CHECK_DRAW_THREADHOLD = 25000000f;

	// Token: 0x0400DE13 RID: 56851
	private float CheckDrawTime;

	// Token: 0x0400DE14 RID: 56852
	private bool LastCheckDrawResult;

	// Token: 0x0400DE15 RID: 56853
	protected bool IsLegal;

	// Token: 0x0400DE16 RID: 56854
	protected Transform SelfTransform;

	// Token: 0x0400DE17 RID: 56855
	protected Vector SelfLocation;

	// Token: 0x0400DE18 RID: 56856
	protected SSimpleInteractResult TmpResult;

	// Token: 0x0400DE19 RID: 56857
	protected Vector ActorLocation;

	// Token: 0x0400DE1A RID: 56858
	protected Vector SelfToActor;

	// Token: 0x0400DE1B RID: 56859
	protected Vector MoveOffset;

	// Token: 0x0400DE1C RID: 56860
	protected Vector TmpVector1;

	// Token: 0x0400DE1D RID: 56861
	protected Vector TmpVector2;

	// Token: 0x0400DE1E RID: 56862
	protected Vector TmpVector3;

	// Token: 0x0400DE1F RID: 56863
	protected Vector TmpVector4;

	// Token: 0x0400DE20 RID: 56864
	protected UTraceLineElement LineTrace;

	// Token: 0x0400DE21 RID: 56865
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/SceneItem/SimpleBlueprintItem/TsSimpleInteractBase.TsSimpleInteractBase_C";

	// Token: 0x0400DE22 RID: 56866
	private static IntPtr _ClassPtr;

	// Token: 0x0400DE23 RID: 56867
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400DE24 RID: 56868
	private static int __PropertyOffset_TypeId;

	// Token: 0x0400DE25 RID: 56869
	private static int __PropertyOffset_Text;

	// Token: 0x02009749 RID: 38729
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 64)]
	protected ref struct __GetBestTransform_FunctionParams
	{
		// Token: 0x0403066F RID: 198255
		[FieldOffset(0)]
		public IntPtr actor;

		// Token: 0x04030670 RID: 198256
		[FieldOffset(8)]
		public FVector moveOffset;

		// Token: 0x04030671 RID: 198257
		[FieldOffset(20)]
		public float halfHeight;

		// Token: 0x04030672 RID: 198258
		[FieldOffset(24)]
		public float radius;

		// Token: 0x04030673 RID: 198259
		[FieldOffset(28)]
		public SSimpleInteractResult __Result;
	}
}

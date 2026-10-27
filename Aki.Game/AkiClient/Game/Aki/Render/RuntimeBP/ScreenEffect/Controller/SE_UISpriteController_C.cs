using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Render.RuntimeBP.ScreenEffect.Data;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.ScreenEffect.Controller
{
	// Token: 0x02003AF2 RID: 15090
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/ScreenEffect/Controller/SE_UISpriteController.SE_UISpriteController_C")]
	[UnrealStructLayout(256, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 256)]
	public class SE_UISpriteController_C : SE_ControllerBase_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020AEE RID: 133870 RVA: 0x008DA24F File Offset: 0x008D844F
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (SE_UISpriteController_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/ScreenEffect/Controller/SE_UISpriteController.SE_UISpriteController_C");
			}
			return SE_UISpriteController_C._ClassPtr;
		}

		// Token: 0x06020AEF RID: 133871 RVA: 0x008DA274 File Offset: 0x008D8474
		public SE_UISpriteController_C() : this(BuiltinUtils.AllocNativeUObject(SE_UISpriteController_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020AF0 RID: 133872 RVA: 0x008DA29C File Offset: 0x008D849C
		[NullableContext(1)]
		public SE_UISpriteController_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(SE_UISpriteController_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170031F1 RID: 12785
		// (get) Token: 0x06020AF1 RID: 133873 RVA: 0x008DA2CF File Offset: 0x008D84CF
		// (set) Token: 0x06020AF2 RID: 133874 RVA: 0x008DA2E3 File Offset: 0x008D84E3
		[Nullable(2)]
		public unsafe PD_SE_ControllerCommonData_C Data
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<PD_SE_ControllerCommonData_C>(base.NativePtr / (IntPtr)sizeof(void*) + SE_UISpriteController_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SE_UISpriteController_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170031F2 RID: 12786
		// (get) Token: 0x06020AF3 RID: 133875 RVA: 0x008DA2F8 File Offset: 0x008D84F8
		// (set) Token: 0x06020AF4 RID: 133876 RVA: 0x008DA331 File Offset: 0x008D8531
		[Nullable(1)]
		public TArray<UMaterialInstanceDynamic> CachedMaterial
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInstanceDynamic> result;
				if ((result = this._CachedMaterial) == null)
				{
					result = (this._CachedMaterial = new TArray<UMaterialInstanceDynamic>(base.NativePtr + (IntPtr)SE_UISpriteController_C.__PropertyOffset_2, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.CachedMaterial.CopyAssign(value);
			}
		}

		// Token: 0x06020AF5 RID: 133877 RVA: 0x008DA340 File Offset: 0x008D8540
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void UpdateComponentAlpha(float Alpha)
		{
			SE_UISpriteController_C.__UpdateComponentAlpha_FunctionParams* ptr = stackalloc SE_UISpriteController_C.__UpdateComponentAlpha_FunctionParams[(UIntPtr)71] + 15L / (long)sizeof(SE_UISpriteController_C.__UpdateComponentAlpha_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(SE_UISpriteController_C.__UpdateComponentAlpha_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Alpha = Alpha;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, SE_UISpriteController_C.__UpdateComponentAlpha_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020AF6 RID: 133878 RVA: 0x008DA388 File Offset: 0x008D8588
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void UpdateComponent(E_SE_PlayState State, float Time)
		{
			SE_UISpriteController_C.__UpdateComponent_FunctionParams* ptr = stackalloc SE_UISpriteController_C.__UpdateComponent_FunctionParams[(UIntPtr)2311] + 15L / (long)sizeof(SE_UISpriteController_C.__UpdateComponent_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(SE_UISpriteController_C.__UpdateComponent_NativeFunctionPtr, (void*)ptr, 1);
			ptr->State = State;
			ptr->Time = Time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, SE_UISpriteController_C.__UpdateComponent_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020AF7 RID: 133879 RVA: 0x008DA3DD File Offset: 0x008D85DD
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, SE_UISpriteController_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06020AF8 RID: 133880 RVA: 0x008DA3F1 File Offset: 0x008D85F1
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, SE_UISpriteController_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06020AF9 RID: 133881 RVA: 0x008DA408 File Offset: 0x008D8608
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			SE_UISpriteController_C.__ReceiveTick_FunctionParams* ptr = stackalloc SE_UISpriteController_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(SE_UISpriteController_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(SE_UISpriteController_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, SE_UISpriteController_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020AFA RID: 133882 RVA: 0x008DA450 File Offset: 0x008D8650
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void ReceiveTick_Implementation(float DeltaSeconds)
		{
			SE_UISpriteController_C.__ReceiveTick_FunctionParams* ptr = stackalloc SE_UISpriteController_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(SE_UISpriteController_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(SE_UISpriteController_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, SE_UISpriteController_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06020AFB RID: 133883 RVA: 0x008DA498 File Offset: 0x008D8698
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void Start(float time)
		{
			SE_UISpriteController_C.__Start_FunctionParams* ptr = stackalloc SE_UISpriteController_C.__Start_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(SE_UISpriteController_C.__Start_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(SE_UISpriteController_C.__Start_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, SE_UISpriteController_C.__Start_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020AFC RID: 133884 RVA: 0x008DA4E0 File Offset: 0x008D86E0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void End(float time)
		{
			SE_UISpriteController_C.__End_FunctionParams* ptr = stackalloc SE_UISpriteController_C.__End_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(SE_UISpriteController_C.__End_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(SE_UISpriteController_C.__End_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, SE_UISpriteController_C.__End_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020AFD RID: 133885 RVA: 0x008DA528 File Offset: 0x008D8728
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void Loop(float time)
		{
			SE_UISpriteController_C.__Loop_FunctionParams* ptr = stackalloc SE_UISpriteController_C.__Loop_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(SE_UISpriteController_C.__Loop_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(SE_UISpriteController_C.__Loop_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, SE_UISpriteController_C.__Loop_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020AFE RID: 133886 RVA: 0x008DA570 File Offset: 0x008D8770
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ApplyAlpha(float alpha)
		{
			SE_UISpriteController_C.__ApplyAlpha_FunctionParams* ptr = stackalloc SE_UISpriteController_C.__ApplyAlpha_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(SE_UISpriteController_C.__ApplyAlpha_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(SE_UISpriteController_C.__ApplyAlpha_NativeFunctionPtr, (void*)ptr, 1);
			ptr->alpha = alpha;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, SE_UISpriteController_C.__ApplyAlpha_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020AFF RID: 133887 RVA: 0x008DA5B8 File Offset: 0x008D87B8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
		{
			SE_UISpriteController_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc SE_UISpriteController_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(SE_UISpriteController_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(SE_UISpriteController_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, SE_UISpriteController_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020B00 RID: 133888 RVA: 0x008DA604 File Offset: 0x008D8804
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
		{
			SE_UISpriteController_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc SE_UISpriteController_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(SE_UISpriteController_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(SE_UISpriteController_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, SE_UISpriteController_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06020B01 RID: 133889 RVA: 0x008DA650 File Offset: 0x008D8850
		protected SE_UISpriteController_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FDD2 RID: 64978
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/ScreenEffect/Controller/SE_UISpriteController.SE_UISpriteController_C";

		// Token: 0x0400FDD3 RID: 64979
		private static IntPtr _ClassPtr;

		// Token: 0x0400FDD4 RID: 64980
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FDD5 RID: 64981
		internal static int __PropertyOffset_1;

		// Token: 0x0400FDD6 RID: 64982
		internal static int __PropertyOffset_2;

		// Token: 0x0400FDD7 RID: 64983
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstanceDynamic> _CachedMaterial;

		// Token: 0x0400FDD8 RID: 64984
		private static IntPtr __UpdateComponentAlpha_NativeFunctionPtr;

		// Token: 0x0400FDD9 RID: 64985
		private static IntPtr __UpdateComponent_NativeFunctionPtr;

		// Token: 0x0400FDDA RID: 64986
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0400FDDB RID: 64987
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0400FDDC RID: 64988
		private static IntPtr __Start_NativeFunctionPtr;

		// Token: 0x0400FDDD RID: 64989
		private static IntPtr __End_NativeFunctionPtr;

		// Token: 0x0400FDDE RID: 64990
		private static IntPtr __Loop_NativeFunctionPtr;

		// Token: 0x0400FDDF RID: 64991
		private static IntPtr __ApplyAlpha_NativeFunctionPtr;

		// Token: 0x0400FDE0 RID: 64992
		private static IntPtr __ReceiveEndPlay_NativeFunctionPtr;

		// Token: 0x02009C19 RID: 39961
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __UpdateComponentAlpha_FunctionParams
		{
			// Token: 0x040312BF RID: 201407
			[FieldOffset(0)]
			public float Alpha;
		}

		// Token: 0x02009C1A RID: 39962
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2296)]
		protected ref struct __UpdateComponent_FunctionParams
		{
			// Token: 0x040312C0 RID: 201408
			[FieldOffset(0)]
			public TEnumAsByte<E_SE_PlayState> State;

			// Token: 0x040312C1 RID: 201409
			[FieldOffset(4)]
			public float Time;
		}

		// Token: 0x02009C1B RID: 39963
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040312C2 RID: 201410
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009C1C RID: 39964
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __Start_FunctionParams
		{
			// Token: 0x040312C3 RID: 201411
			[FieldOffset(0)]
			public float time;
		}

		// Token: 0x02009C1D RID: 39965
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __End_FunctionParams
		{
			// Token: 0x040312C4 RID: 201412
			[FieldOffset(0)]
			public float time;
		}

		// Token: 0x02009C1E RID: 39966
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __Loop_FunctionParams
		{
			// Token: 0x040312C5 RID: 201413
			[FieldOffset(0)]
			public float time;
		}

		// Token: 0x02009C1F RID: 39967
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ApplyAlpha_FunctionParams
		{
			// Token: 0x040312C6 RID: 201414
			[FieldOffset(0)]
			public float alpha;
		}

		// Token: 0x02009C20 RID: 39968
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __ReceiveEndPlay_FunctionParams
		{
			// Token: 0x040312C7 RID: 201415
			[FieldOffset(0)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}
	}
}

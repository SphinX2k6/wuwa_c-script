using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.AutoPaving
{
	// Token: 0x02003CDB RID: 15579
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/AutoPaving/BP_PCGAutoPaving.BP_PCGAutoPaving_C")]
	[UnrealStructLayout(1664, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1656)]
	public class BP_PCGAutoPaving_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06024FA8 RID: 151464 RVA: 0x0094DB17 File Offset: 0x0094BD17
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_PCGAutoPaving_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/AutoPaving/BP_PCGAutoPaving.BP_PCGAutoPaving_C");
			}
			return BP_PCGAutoPaving_C._ClassPtr;
		}

		// Token: 0x06024FA9 RID: 151465 RVA: 0x0094DB3C File Offset: 0x0094BD3C
		public BP_PCGAutoPaving_C() : this(BuiltinUtils.AllocNativeUObject(BP_PCGAutoPaving_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06024FAA RID: 151466 RVA: 0x0094DB64 File Offset: 0x0094BD64
		[NullableContext(1)]
		public BP_PCGAutoPaving_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_PCGAutoPaving_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004A27 RID: 18983
		// (get) Token: 0x06024FAB RID: 151467 RVA: 0x0094DB97 File Offset: 0x0094BD97
		// (set) Token: 0x06024FAC RID: 151468 RVA: 0x0094DBAB File Offset: 0x0094BDAB
		public unsafe UStaticMeshComponent StaticMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PCGAutoPaving_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PCGAutoPaving_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17004A28 RID: 18984
		// (get) Token: 0x06024FAD RID: 151469 RVA: 0x0094DBC0 File Offset: 0x0094BDC0
		// (set) Token: 0x06024FAE RID: 151470 RVA: 0x0094DBD4 File Offset: 0x0094BDD4
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PCGAutoPaving_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PCGAutoPaving_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17004A29 RID: 18985
		// (get) Token: 0x06024FAF RID: 151471 RVA: 0x0094DBE9 File Offset: 0x0094BDE9
		// (set) Token: 0x06024FB0 RID: 151472 RVA: 0x0094DBF9 File Offset: 0x0094BDF9
		public unsafe bool PageTurning
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PCGAutoPaving_C.__PropertyOffset_3) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PCGAutoPaving_C.__PropertyOffset_3) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004A2A RID: 18986
		// (get) Token: 0x06024FB1 RID: 151473 RVA: 0x0094DC0A File Offset: 0x0094BE0A
		// (set) Token: 0x06024FB2 RID: 151474 RVA: 0x0094DC1A File Offset: 0x0094BE1A
		public unsafe float Speed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PCGAutoPaving_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PCGAutoPaving_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17004A2B RID: 18987
		// (get) Token: 0x06024FB3 RID: 151475 RVA: 0x0094DC2B File Offset: 0x0094BE2B
		// (set) Token: 0x06024FB4 RID: 151476 RVA: 0x0094DC3F File Offset: 0x0094BE3F
		public unsafe FTransformDouble TransformOld
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PCGAutoPaving_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PCGAutoPaving_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17004A2C RID: 18988
		// (get) Token: 0x06024FB5 RID: 151477 RVA: 0x0094DC54 File Offset: 0x0094BE54
		// (set) Token: 0x06024FB6 RID: 151478 RVA: 0x0094DC68 File Offset: 0x0094BE68
		public unsafe FTransformDouble TransformNew
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PCGAutoPaving_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PCGAutoPaving_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17004A2D RID: 18989
		// (get) Token: 0x06024FB7 RID: 151479 RVA: 0x0094DC7D File Offset: 0x0094BE7D
		// (set) Token: 0x06024FB8 RID: 151480 RVA: 0x0094DC8D File Offset: 0x0094BE8D
		public unsafe float PavingTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PCGAutoPaving_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PCGAutoPaving_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17004A2E RID: 18990
		// (get) Token: 0x06024FB9 RID: 151481 RVA: 0x0094DC9E File Offset: 0x0094BE9E
		// (set) Token: 0x06024FBA RID: 151482 RVA: 0x0094DCAE File Offset: 0x0094BEAE
		public unsafe bool PavingState
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PCGAutoPaving_C.__PropertyOffset_8) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PCGAutoPaving_C.__PropertyOffset_8) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004A2F RID: 18991
		// (get) Token: 0x06024FBB RID: 151483 RVA: 0x0094DCBF File Offset: 0x0094BEBF
		// (set) Token: 0x06024FBC RID: 151484 RVA: 0x0094DCCF File Offset: 0x0094BECF
		public unsafe bool EdirotTick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PCGAutoPaving_C.__PropertyOffset_9) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PCGAutoPaving_C.__PropertyOffset_9) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004A30 RID: 18992
		// (get) Token: 0x06024FBD RID: 151485 RVA: 0x0094DCE0 File Offset: 0x0094BEE0
		// (set) Token: 0x06024FBE RID: 151486 RVA: 0x0094DCF0 File Offset: 0x0094BEF0
		public unsafe float Delta_Seconds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PCGAutoPaving_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PCGAutoPaving_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17004A31 RID: 18993
		// (get) Token: 0x06024FBF RID: 151487 RVA: 0x0094DD04 File Offset: 0x0094BF04
		// (set) Token: 0x06024FC0 RID: 151488 RVA: 0x0094DD3D File Offset: 0x0094BF3D
		[Nullable(1)]
		public TArray<float> PageTimes
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._PageTimes) == null)
				{
					result = (this._PageTimes = new TArray<float>(base.NativePtr + (IntPtr)BP_PCGAutoPaving_C.__PropertyOffset_11, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.PageTimes.CopyAssign(value);
			}
		}

		// Token: 0x17004A32 RID: 18994
		// (get) Token: 0x06024FC1 RID: 151489 RVA: 0x0094DD4B File Offset: 0x0094BF4B
		// (set) Token: 0x06024FC2 RID: 151490 RVA: 0x0094DD5B File Offset: 0x0094BF5B
		public unsafe int Tick_Add
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PCGAutoPaving_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PCGAutoPaving_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17004A33 RID: 18995
		// (get) Token: 0x06024FC3 RID: 151491 RVA: 0x0094DD6C File Offset: 0x0094BF6C
		// (set) Token: 0x06024FC4 RID: 151492 RVA: 0x0094DD7C File Offset: 0x0094BF7C
		public unsafe float Delta_Seconds_Add
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PCGAutoPaving_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PCGAutoPaving_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x06024FC5 RID: 151493 RVA: 0x0094DD90 File Offset: 0x0094BF90
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void PageTurningTime(bool Turning)
		{
			BP_PCGAutoPaving_C.__PageTurningTime_FunctionParams* ptr = stackalloc BP_PCGAutoPaving_C.__PageTurningTime_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(BP_PCGAutoPaving_C.__PageTurningTime_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_PCGAutoPaving_C.__PageTurningTime_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Turning = Turning;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PCGAutoPaving_C.__PageTurningTime_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06024FC6 RID: 151494 RVA: 0x0094DDD6 File Offset: 0x0094BFD6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 生成静态模型_演出_()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PCGAutoPaving_C.__生成静态模型_演出__NativeFunctionPtr, null);
		}

		// Token: 0x06024FC7 RID: 151495 RVA: 0x0094DDEA File Offset: 0x0094BFEA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 返回原位()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PCGAutoPaving_C.__返回原位_NativeFunctionPtr, null);
		}

		// Token: 0x06024FC8 RID: 151496 RVA: 0x0094DDFE File Offset: 0x0094BFFE
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 预览()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PCGAutoPaving_C.__预览_NativeFunctionPtr, null);
		}

		// Token: 0x06024FC9 RID: 151497 RVA: 0x0094DE12 File Offset: 0x0094C012
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 计算位置()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PCGAutoPaving_C.__计算位置_NativeFunctionPtr, null);
		}

		// Token: 0x06024FCA RID: 151498 RVA: 0x0094DE26 File Offset: 0x0094C026
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PCGAutoPaving_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06024FCB RID: 151499 RVA: 0x0094DE3A File Offset: 0x0094C03A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_PCGAutoPaving_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06024FCC RID: 151500 RVA: 0x0094DE50 File Offset: 0x0094C050
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_PCGAutoPaving_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_PCGAutoPaving_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_PCGAutoPaving_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_PCGAutoPaving_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PCGAutoPaving_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06024FCD RID: 151501 RVA: 0x0094DE98 File Offset: 0x0094C098
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_PCGAutoPaving_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_PCGAutoPaving_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_PCGAutoPaving_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_PCGAutoPaving_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_PCGAutoPaving_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06024FCE RID: 151502 RVA: 0x0094DEE0 File Offset: 0x0094C0E0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_PCGAutoPaving_C.__EditorTick_FunctionParams* ptr = stackalloc BP_PCGAutoPaving_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_PCGAutoPaving_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_PCGAutoPaving_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PCGAutoPaving_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06024FCF RID: 151503 RVA: 0x0094DF28 File Offset: 0x0094C128
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_PCGAutoPaving_C.__EditorTick_FunctionParams* ptr = stackalloc BP_PCGAutoPaving_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_PCGAutoPaving_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_PCGAutoPaving_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_PCGAutoPaving_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06024FD0 RID: 151504 RVA: 0x0094DF6F File Offset: 0x0094C16F
		protected BP_PCGAutoPaving_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401263A RID: 75322
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/AutoPaving/BP_PCGAutoPaving.BP_PCGAutoPaving_C";

		// Token: 0x0401263B RID: 75323
		private static IntPtr _ClassPtr;

		// Token: 0x0401263C RID: 75324
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401263D RID: 75325
		internal static int __PropertyOffset_1;

		// Token: 0x0401263E RID: 75326
		internal static int __PropertyOffset_2;

		// Token: 0x0401263F RID: 75327
		internal static int __PropertyOffset_3;

		// Token: 0x04012640 RID: 75328
		internal static int __PropertyOffset_4;

		// Token: 0x04012641 RID: 75329
		internal static int __PropertyOffset_5;

		// Token: 0x04012642 RID: 75330
		internal static int __PropertyOffset_6;

		// Token: 0x04012643 RID: 75331
		internal static int __PropertyOffset_7;

		// Token: 0x04012644 RID: 75332
		internal static int __PropertyOffset_8;

		// Token: 0x04012645 RID: 75333
		internal static int __PropertyOffset_9;

		// Token: 0x04012646 RID: 75334
		internal static int __PropertyOffset_10;

		// Token: 0x04012647 RID: 75335
		internal static int __PropertyOffset_11;

		// Token: 0x04012648 RID: 75336
		private TArray<float> _PageTimes;

		// Token: 0x04012649 RID: 75337
		internal static int __PropertyOffset_12;

		// Token: 0x0401264A RID: 75338
		internal static int __PropertyOffset_13;

		// Token: 0x0401264B RID: 75339
		private static IntPtr __PageTurningTime_NativeFunctionPtr;

		// Token: 0x0401264C RID: 75340
		private static IntPtr __生成静态模型_演出__NativeFunctionPtr;

		// Token: 0x0401264D RID: 75341
		private static IntPtr __返回原位_NativeFunctionPtr;

		// Token: 0x0401264E RID: 75342
		private static IntPtr __预览_NativeFunctionPtr;

		// Token: 0x0401264F RID: 75343
		private static IntPtr __计算位置_NativeFunctionPtr;

		// Token: 0x04012650 RID: 75344
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04012651 RID: 75345
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04012652 RID: 75346
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x02009F9A RID: 40858
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __PageTurningTime_FunctionParams
		{
			// Token: 0x040319E0 RID: 203232
			[FieldOffset(0)]
			public bool Turning;
		}

		// Token: 0x02009F9B RID: 40859
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040319E1 RID: 203233
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009F9C RID: 40860
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x040319E2 RID: 203234
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}

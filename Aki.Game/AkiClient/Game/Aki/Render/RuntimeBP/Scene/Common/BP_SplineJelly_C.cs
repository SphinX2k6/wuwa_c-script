using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Common
{
	// Token: 0x02003B62 RID: 15202
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Common/BP_SplineJelly.BP_SplineJelly_C")]
	[UnrealStructLayout(1520, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1516)]
	public class BP_SplineJelly_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021BB9 RID: 138169 RVA: 0x008F4640 File Offset: 0x008F2840
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SplineJelly_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Common/BP_SplineJelly.BP_SplineJelly_C");
			}
			return BP_SplineJelly_C._ClassPtr;
		}

		// Token: 0x06021BBA RID: 138170 RVA: 0x008F4664 File Offset: 0x008F2864
		public BP_SplineJelly_C() : this(BuiltinUtils.AllocNativeUObject(BP_SplineJelly_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021BBB RID: 138171 RVA: 0x008F468C File Offset: 0x008F288C
		[NullableContext(1)]
		public BP_SplineJelly_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SplineJelly_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003802 RID: 14338
		// (get) Token: 0x06021BBC RID: 138172 RVA: 0x008F46BF File Offset: 0x008F28BF
		// (set) Token: 0x06021BBD RID: 138173 RVA: 0x008F46D3 File Offset: 0x008F28D3
		public unsafe USkeletalMeshComponent SkeletalMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplineJelly_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplineJelly_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17003803 RID: 14339
		// (get) Token: 0x06021BBE RID: 138174 RVA: 0x008F46E8 File Offset: 0x008F28E8
		// (set) Token: 0x06021BBF RID: 138175 RVA: 0x008F46FC File Offset: 0x008F28FC
		public unsafe USplineComponent Spline
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USplineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplineJelly_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplineJelly_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17003804 RID: 14340
		// (get) Token: 0x06021BC0 RID: 138176 RVA: 0x008F4711 File Offset: 0x008F2911
		// (set) Token: 0x06021BC1 RID: 138177 RVA: 0x008F4721 File Offset: 0x008F2921
		public unsafe float MoveSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplineJelly_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplineJelly_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17003805 RID: 14341
		// (get) Token: 0x06021BC2 RID: 138178 RVA: 0x008F4732 File Offset: 0x008F2932
		// (set) Token: 0x06021BC3 RID: 138179 RVA: 0x008F4742 File Offset: 0x008F2942
		public unsafe float Rotate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplineJelly_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplineJelly_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17003806 RID: 14342
		// (get) Token: 0x06021BC4 RID: 138180 RVA: 0x008F4753 File Offset: 0x008F2953
		// (set) Token: 0x06021BC5 RID: 138181 RVA: 0x008F4767 File Offset: 0x008F2967
		public unsafe FVectorDouble RelativeLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplineJelly_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplineJelly_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17003807 RID: 14343
		// (get) Token: 0x06021BC6 RID: 138182 RVA: 0x008F477C File Offset: 0x008F297C
		// (set) Token: 0x06021BC7 RID: 138183 RVA: 0x008F478C File Offset: 0x008F298C
		public unsafe float Progress
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplineJelly_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplineJelly_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17003808 RID: 14344
		// (get) Token: 0x06021BC8 RID: 138184 RVA: 0x008F479D File Offset: 0x008F299D
		// (set) Token: 0x06021BC9 RID: 138185 RVA: 0x008F47AD File Offset: 0x008F29AD
		public unsafe float SplineLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplineJelly_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplineJelly_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17003809 RID: 14345
		// (get) Token: 0x06021BCA RID: 138186 RVA: 0x008F47BE File Offset: 0x008F29BE
		// (set) Token: 0x06021BCB RID: 138187 RVA: 0x008F47CE File Offset: 0x008F29CE
		public unsafe float Delta
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplineJelly_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplineJelly_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x06021BCC RID: 138188 RVA: 0x008F47DF File Offset: 0x008F29DF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SplineJelly_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06021BCD RID: 138189 RVA: 0x008F47F3 File Offset: 0x008F29F3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SplineJelly_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06021BCE RID: 138190 RVA: 0x008F4808 File Offset: 0x008F2A08
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_SplineJelly_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_SplineJelly_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SplineJelly_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SplineJelly_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SplineJelly_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021BCF RID: 138191 RVA: 0x008F4850 File Offset: 0x008F2A50
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_SplineJelly_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_SplineJelly_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SplineJelly_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SplineJelly_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SplineJelly_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06021BD0 RID: 138192 RVA: 0x008F4898 File Offset: 0x008F2A98
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_SplineJelly_C.__EditorTick_FunctionParams* ptr = stackalloc BP_SplineJelly_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SplineJelly_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SplineJelly_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SplineJelly_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021BD1 RID: 138193 RVA: 0x008F48E0 File Offset: 0x008F2AE0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_SplineJelly_C.__EditorTick_FunctionParams* ptr = stackalloc BP_SplineJelly_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SplineJelly_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SplineJelly_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SplineJelly_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06021BD2 RID: 138194 RVA: 0x008F4927 File Offset: 0x008F2B27
		protected BP_SplineJelly_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010764 RID: 67428
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Common/BP_SplineJelly.BP_SplineJelly_C";

		// Token: 0x04010765 RID: 67429
		private static IntPtr _ClassPtr;

		// Token: 0x04010766 RID: 67430
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010767 RID: 67431
		internal static int __PropertyOffset_1;

		// Token: 0x04010768 RID: 67432
		internal static int __PropertyOffset_2;

		// Token: 0x04010769 RID: 67433
		internal static int __PropertyOffset_3;

		// Token: 0x0401076A RID: 67434
		internal static int __PropertyOffset_4;

		// Token: 0x0401076B RID: 67435
		internal static int __PropertyOffset_5;

		// Token: 0x0401076C RID: 67436
		internal static int __PropertyOffset_6;

		// Token: 0x0401076D RID: 67437
		internal static int __PropertyOffset_7;

		// Token: 0x0401076E RID: 67438
		internal static int __PropertyOffset_8;

		// Token: 0x0401076F RID: 67439
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04010770 RID: 67440
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04010771 RID: 67441
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x02009CC8 RID: 40136
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040313AD RID: 201645
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009CC9 RID: 40137
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x040313AE RID: 201646
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}

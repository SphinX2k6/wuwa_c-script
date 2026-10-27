using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.CurveTrailDecal
{
	// Token: 0x02003DEE RID: 15854
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/CurveTrailDecal/BP_CurveTrailSpawner.BP_CurveTrailSpawner_C")]
	[UnrealStructLayout(1096, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1089)]
	public class BP_CurveTrailSpawner_C : AKuroCurveTrailDecalSpawner, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060278F6 RID: 162038 RVA: 0x00994B38 File Offset: 0x00992D38
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_CurveTrailSpawner_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/CurveTrailDecal/BP_CurveTrailSpawner.BP_CurveTrailSpawner_C");
			}
			return BP_CurveTrailSpawner_C._ClassPtr;
		}

		// Token: 0x060278F7 RID: 162039 RVA: 0x00994B5C File Offset: 0x00992D5C
		public BP_CurveTrailSpawner_C() : this(BuiltinUtils.AllocNativeUObject(BP_CurveTrailSpawner_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060278F8 RID: 162040 RVA: 0x00994B84 File Offset: 0x00992D84
		[NullableContext(1)]
		public BP_CurveTrailSpawner_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_CurveTrailSpawner_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170058BF RID: 22719
		// (get) Token: 0x060278F9 RID: 162041 RVA: 0x00994BB7 File Offset: 0x00992DB7
		// (set) Token: 0x060278FA RID: 162042 RVA: 0x00994BCB File Offset: 0x00992DCB
		[Nullable(2)]
		public unsafe UBillboardComponent Billboard
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBillboardComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CurveTrailSpawner_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CurveTrailSpawner_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170058C0 RID: 22720
		// (get) Token: 0x060278FB RID: 162043 RVA: 0x00994BE0 File Offset: 0x00992DE0
		// (set) Token: 0x060278FC RID: 162044 RVA: 0x00994BF0 File Offset: 0x00992DF0
		public unsafe bool Position
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CurveTrailSpawner_C.__PropertyOffset_2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CurveTrailSpawner_C.__PropertyOffset_2) = (value ? 1 : 0);
			}
		}

		// Token: 0x060278FD RID: 162045 RVA: 0x00994C04 File Offset: 0x00992E04
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_CurveTrailSpawner_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_CurveTrailSpawner_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CurveTrailSpawner_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CurveTrailSpawner_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CurveTrailSpawner_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060278FE RID: 162046 RVA: 0x00994C4C File Offset: 0x00992E4C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_CurveTrailSpawner_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_CurveTrailSpawner_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CurveTrailSpawner_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CurveTrailSpawner_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CurveTrailSpawner_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060278FF RID: 162047 RVA: 0x00994C93 File Offset: 0x00992E93
		protected BP_CurveTrailSpawner_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401400D RID: 81933
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/CurveTrailDecal/BP_CurveTrailSpawner.BP_CurveTrailSpawner_C";

		// Token: 0x0401400E RID: 81934
		private static IntPtr _ClassPtr;

		// Token: 0x0401400F RID: 81935
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04014010 RID: 81936
		internal static int __PropertyOffset_1;

		// Token: 0x04014011 RID: 81937
		internal static int __PropertyOffset_2;

		// Token: 0x04014012 RID: 81938
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0200A24A RID: 41546
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031EDB RID: 204507
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}

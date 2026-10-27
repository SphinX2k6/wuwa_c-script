using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.SnowCoverInteraction.BluePrints
{
	// Token: 0x02003AD0 RID: 15056
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/SnowCoverInteraction/BluePrints/BP_MotorObjTrailActor.BP_MotorObjTrailActor_C")]
	[UnrealStructLayout(800, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 785)]
	public class BP_MotorObjTrailActor_C : BP_SnowTrailComponent_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020706 RID: 132870 RVA: 0x008D2B7C File Offset: 0x008D0D7C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_MotorObjTrailActor_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/SnowCoverInteraction/BluePrints/BP_MotorObjTrailActor.BP_MotorObjTrailActor_C");
			}
			return BP_MotorObjTrailActor_C._ClassPtr;
		}

		// Token: 0x06020707 RID: 132871 RVA: 0x008D2BA0 File Offset: 0x008D0DA0
		public BP_MotorObjTrailActor_C() : this(BuiltinUtils.AllocNativeUObject(BP_MotorObjTrailActor_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020708 RID: 132872 RVA: 0x008D2BC8 File Offset: 0x008D0DC8
		[NullableContext(1)]
		public BP_MotorObjTrailActor_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_MotorObjTrailActor_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170030BC RID: 12476
		// (get) Token: 0x06020709 RID: 132873 RVA: 0x008D2BFB File Offset: 0x008D0DFB
		// (set) Token: 0x0602070A RID: 132874 RVA: 0x008D2C0B File Offset: 0x008D0E0B
		public unsafe bool IsMoto
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MotorObjTrailActor_C.__PropertyOffset_1) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MotorObjTrailActor_C.__PropertyOffset_1) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602070B RID: 132875 RVA: 0x008D2C1C File Offset: 0x008D0E1C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_MotorObjTrailActor_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_MotorObjTrailActor_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_MotorObjTrailActor_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MotorObjTrailActor_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MotorObjTrailActor_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602070C RID: 132876 RVA: 0x008D2C64 File Offset: 0x008D0E64
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_MotorObjTrailActor_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_MotorObjTrailActor_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_MotorObjTrailActor_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MotorObjTrailActor_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_MotorObjTrailActor_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602070D RID: 132877 RVA: 0x008D2CAB File Offset: 0x008D0EAB
		protected BP_MotorObjTrailActor_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FB57 RID: 64343
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/SnowCoverInteraction/BluePrints/BP_MotorObjTrailActor.BP_MotorObjTrailActor_C";

		// Token: 0x0400FB58 RID: 64344
		private static IntPtr _ClassPtr;

		// Token: 0x0400FB59 RID: 64345
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FB5A RID: 64346
		internal new static int __PropertyOffset_1;

		// Token: 0x0400FB5B RID: 64347
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x02009BB6 RID: 39862
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031234 RID: 201268
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}

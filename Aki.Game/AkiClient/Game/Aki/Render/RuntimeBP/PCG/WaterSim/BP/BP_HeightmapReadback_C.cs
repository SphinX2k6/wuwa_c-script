using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.WaterSim.BP
{
	// Token: 0x02003BD3 RID: 15315
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/WaterSim/BP/BP_HeightmapReadback.BP_HeightmapReadback_C")]
	[UnrealStructLayout(1104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1104)]
	public class BP_HeightmapReadback_C : AKuroCSReadback, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060225FE RID: 140798 RVA: 0x009072F0 File Offset: 0x009054F0
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_HeightmapReadback_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/WaterSim/BP/BP_HeightmapReadback.BP_HeightmapReadback_C");
			}
			return BP_HeightmapReadback_C._ClassPtr;
		}

		// Token: 0x060225FF RID: 140799 RVA: 0x00907314 File Offset: 0x00905514
		public BP_HeightmapReadback_C() : this(BuiltinUtils.AllocNativeUObject(BP_HeightmapReadback_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022600 RID: 140800 RVA: 0x0090733C File Offset: 0x0090553C
		[NullableContext(1)]
		public BP_HeightmapReadback_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_HeightmapReadback_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06022601 RID: 140801 RVA: 0x0090736F File Offset: 0x0090556F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_HeightmapReadback_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06022602 RID: 140802 RVA: 0x00907383 File Offset: 0x00905583
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_HeightmapReadback_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06022603 RID: 140803 RVA: 0x00907398 File Offset: 0x00905598
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
		{
			BP_HeightmapReadback_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_HeightmapReadback_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_HeightmapReadback_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_HeightmapReadback_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_HeightmapReadback_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022604 RID: 140804 RVA: 0x009073E4 File Offset: 0x009055E4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
		{
			BP_HeightmapReadback_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_HeightmapReadback_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_HeightmapReadback_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_HeightmapReadback_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_HeightmapReadback_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06022605 RID: 140805 RVA: 0x00907430 File Offset: 0x00905630
		protected BP_HeightmapReadback_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010DE2 RID: 69090
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/WaterSim/BP/BP_HeightmapReadback.BP_HeightmapReadback_C";

		// Token: 0x04010DE3 RID: 69091
		private static IntPtr _ClassPtr;

		// Token: 0x04010DE4 RID: 69092
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010DE5 RID: 69093
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04010DE6 RID: 69094
		private static IntPtr __ReceiveEndPlay_NativeFunctionPtr;

		// Token: 0x02009D70 RID: 40304
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __ReceiveEndPlay_FunctionParams
		{
			// Token: 0x040314EE RID: 201966
			[FieldOffset(0)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}
	}
}

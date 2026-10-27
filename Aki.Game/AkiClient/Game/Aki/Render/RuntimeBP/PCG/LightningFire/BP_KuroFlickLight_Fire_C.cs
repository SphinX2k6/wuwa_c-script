using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.LightningFire
{
	// Token: 0x02003C73 RID: 15475
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/LightningFire/BP_KuroFlickLight_Fire.BP_KuroFlickLight_Fire_C")]
	[UnrealStructLayout(1528, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1524)]
	public class BP_KuroFlickLight_Fire_C : AKuroFlickerLightActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023E7D RID: 147069 RVA: 0x009303A9 File Offset: 0x0092E5A9
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_KuroFlickLight_Fire_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/LightningFire/BP_KuroFlickLight_Fire.BP_KuroFlickLight_Fire_C");
			}
			return BP_KuroFlickLight_Fire_C._ClassPtr;
		}

		// Token: 0x06023E7E RID: 147070 RVA: 0x009303D0 File Offset: 0x0092E5D0
		public BP_KuroFlickLight_Fire_C() : this(BuiltinUtils.AllocNativeUObject(BP_KuroFlickLight_Fire_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023E7F RID: 147071 RVA: 0x009303F8 File Offset: 0x0092E5F8
		[NullableContext(1)]
		public BP_KuroFlickLight_Fire_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_KuroFlickLight_Fire_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004411 RID: 17425
		// (get) Token: 0x06023E80 RID: 147072 RVA: 0x0093042B File Offset: 0x0092E62B
		// (set) Token: 0x06023E81 RID: 147073 RVA: 0x0093043B File Offset: 0x0092E63B
		public unsafe float Attenuation_Radius_Max
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroFlickLight_Fire_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroFlickLight_Fire_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x06023E82 RID: 147074 RVA: 0x0093044C File Offset: 0x0092E64C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void DebugRadius()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroFlickLight_Fire_C.__DebugRadius_NativeFunctionPtr, null);
		}

		// Token: 0x06023E83 RID: 147075 RVA: 0x00930460 File Offset: 0x0092E660
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Set_LightRadius()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroFlickLight_Fire_C.__Set_LightRadius_NativeFunctionPtr, null);
		}

		// Token: 0x06023E84 RID: 147076 RVA: 0x00930474 File Offset: 0x0092E674
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroFlickLight_Fire_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06023E85 RID: 147077 RVA: 0x00930488 File Offset: 0x0092E688
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroFlickLight_Fire_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06023E86 RID: 147078 RVA: 0x009304A0 File Offset: 0x0092E6A0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_KuroFlickLight_Fire_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_KuroFlickLight_Fire_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_KuroFlickLight_Fire_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroFlickLight_Fire_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroFlickLight_Fire_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06023E87 RID: 147079 RVA: 0x009304E8 File Offset: 0x0092E6E8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_KuroFlickLight_Fire_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_KuroFlickLight_Fire_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_KuroFlickLight_Fire_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroFlickLight_Fire_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroFlickLight_Fire_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06023E88 RID: 147080 RVA: 0x0093052F File Offset: 0x0092E72F
		protected BP_KuroFlickLight_Fire_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011C32 RID: 72754
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/LightningFire/BP_KuroFlickLight_Fire.BP_KuroFlickLight_Fire_C";

		// Token: 0x04011C33 RID: 72755
		private static IntPtr _ClassPtr;

		// Token: 0x04011C34 RID: 72756
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011C35 RID: 72757
		internal static int __PropertyOffset_1;

		// Token: 0x04011C36 RID: 72758
		private static IntPtr __DebugRadius_NativeFunctionPtr;

		// Token: 0x04011C37 RID: 72759
		private static IntPtr __Set_LightRadius_NativeFunctionPtr;

		// Token: 0x04011C38 RID: 72760
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04011C39 RID: 72761
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x02009EB2 RID: 40626
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0403178B RID: 202635
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}

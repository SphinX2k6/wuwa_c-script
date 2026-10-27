using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.KuroSeasonsManager
{
	// Token: 0x02003C76 RID: 15478
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/KuroSeasonsManager/BP_KuroSeasonsManager.BP_KuroSeasonsManager_C")]
	[UnrealStructLayout(1840, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1840)]
	public class BP_KuroSeasonsManager_C : AKuroSeasonsManager, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023F2E RID: 147246 RVA: 0x009314AC File Offset: 0x0092F6AC
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_KuroSeasonsManager_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/KuroSeasonsManager/BP_KuroSeasonsManager.BP_KuroSeasonsManager_C");
			}
			return BP_KuroSeasonsManager_C._ClassPtr;
		}

		// Token: 0x06023F2F RID: 147247 RVA: 0x009314D0 File Offset: 0x0092F6D0
		public BP_KuroSeasonsManager_C() : this(BuiltinUtils.AllocNativeUObject(BP_KuroSeasonsManager_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023F30 RID: 147248 RVA: 0x009314F8 File Offset: 0x0092F6F8
		[NullableContext(1)]
		public BP_KuroSeasonsManager_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_KuroSeasonsManager_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004453 RID: 17491
		// (get) Token: 0x06023F31 RID: 147249 RVA: 0x0093152B File Offset: 0x0092F72B
		// (set) Token: 0x06023F32 RID: 147250 RVA: 0x0093153B File Offset: 0x0092F73B
		public unsafe float Time
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroSeasonsManager_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroSeasonsManager_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17004454 RID: 17492
		// (get) Token: 0x06023F33 RID: 147251 RVA: 0x0093154C File Offset: 0x0092F74C
		// (set) Token: 0x06023F34 RID: 147252 RVA: 0x0093155C File Offset: 0x0092F75C
		public unsafe float SpringStartTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroSeasonsManager_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroSeasonsManager_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17004455 RID: 17493
		// (get) Token: 0x06023F35 RID: 147253 RVA: 0x0093156D File Offset: 0x0092F76D
		// (set) Token: 0x06023F36 RID: 147254 RVA: 0x0093157D File Offset: 0x0092F77D
		public unsafe float SummerStartTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroSeasonsManager_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroSeasonsManager_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17004456 RID: 17494
		// (get) Token: 0x06023F37 RID: 147255 RVA: 0x0093158E File Offset: 0x0092F78E
		// (set) Token: 0x06023F38 RID: 147256 RVA: 0x0093159E File Offset: 0x0092F79E
		public unsafe float AutumnStartTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroSeasonsManager_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroSeasonsManager_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17004457 RID: 17495
		// (get) Token: 0x06023F39 RID: 147257 RVA: 0x009315AF File Offset: 0x0092F7AF
		// (set) Token: 0x06023F3A RID: 147258 RVA: 0x009315BF File Offset: 0x0092F7BF
		public unsafe float WinterStartTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroSeasonsManager_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroSeasonsManager_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17004458 RID: 17496
		// (get) Token: 0x06023F3B RID: 147259 RVA: 0x009315D0 File Offset: 0x0092F7D0
		// (set) Token: 0x06023F3C RID: 147260 RVA: 0x009315E0 File Offset: 0x0092F7E0
		public unsafe float LastTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroSeasonsManager_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroSeasonsManager_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x06023F3D RID: 147261 RVA: 0x009315F4 File Offset: 0x0092F7F4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_KuroSeasonsManager_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_KuroSeasonsManager_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_KuroSeasonsManager_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroSeasonsManager_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroSeasonsManager_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06023F3E RID: 147262 RVA: 0x0093163C File Offset: 0x0092F83C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_KuroSeasonsManager_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_KuroSeasonsManager_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_KuroSeasonsManager_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroSeasonsManager_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroSeasonsManager_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06023F3F RID: 147263 RVA: 0x00931683 File Offset: 0x0092F883
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroSeasonsManager_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06023F40 RID: 147264 RVA: 0x00931697 File Offset: 0x0092F897
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroSeasonsManager_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06023F41 RID: 147265 RVA: 0x009316AC File Offset: 0x0092F8AC
		protected BP_KuroSeasonsManager_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011C94 RID: 72852
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/KuroSeasonsManager/BP_KuroSeasonsManager.BP_KuroSeasonsManager_C";

		// Token: 0x04011C95 RID: 72853
		private static IntPtr _ClassPtr;

		// Token: 0x04011C96 RID: 72854
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011C97 RID: 72855
		internal static int __PropertyOffset_1;

		// Token: 0x04011C98 RID: 72856
		internal static int __PropertyOffset_2;

		// Token: 0x04011C99 RID: 72857
		internal static int __PropertyOffset_3;

		// Token: 0x04011C9A RID: 72858
		internal static int __PropertyOffset_4;

		// Token: 0x04011C9B RID: 72859
		internal static int __PropertyOffset_5;

		// Token: 0x04011C9C RID: 72860
		internal static int __PropertyOffset_6;

		// Token: 0x04011C9D RID: 72861
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04011C9E RID: 72862
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x02009EBA RID: 40634
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0403179B RID: 202651
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}

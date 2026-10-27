using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.GamePlay.Portal
{
	// Token: 0x02003E58 RID: 15960
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/GamePlay/Portal/BP_KuroPortalCapture.BP_KuroPortalCapture_C")]
	[UnrealStructLayout(1128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1128)]
	public class BP_KuroPortalCapture_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060281E1 RID: 164321 RVA: 0x009A46CC File Offset: 0x009A28CC
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_KuroPortalCapture_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/GamePlay/Portal/BP_KuroPortalCapture.BP_KuroPortalCapture_C");
			}
			return BP_KuroPortalCapture_C._ClassPtr;
		}

		// Token: 0x060281E2 RID: 164322 RVA: 0x009A46F0 File Offset: 0x009A28F0
		public BP_KuroPortalCapture_C() : this(BuiltinUtils.AllocNativeUObject(BP_KuroPortalCapture_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060281E3 RID: 164323 RVA: 0x009A4718 File Offset: 0x009A2918
		[NullableContext(1)]
		public BP_KuroPortalCapture_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_KuroPortalCapture_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005BD1 RID: 23505
		// (get) Token: 0x060281E4 RID: 164324 RVA: 0x009A474B File Offset: 0x009A294B
		// (set) Token: 0x060281E5 RID: 164325 RVA: 0x009A475F File Offset: 0x009A295F
		public unsafe UArrowComponent Arrow1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UArrowComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroPortalCapture_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroPortalCapture_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17005BD2 RID: 23506
		// (get) Token: 0x060281E6 RID: 164326 RVA: 0x009A4774 File Offset: 0x009A2974
		// (set) Token: 0x060281E7 RID: 164327 RVA: 0x009A4788 File Offset: 0x009A2988
		public unsafe UArrowComponent Arrow
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UArrowComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroPortalCapture_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroPortalCapture_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17005BD3 RID: 23507
		// (get) Token: 0x060281E8 RID: 164328 RVA: 0x009A479D File Offset: 0x009A299D
		// (set) Token: 0x060281E9 RID: 164329 RVA: 0x009A47B1 File Offset: 0x009A29B1
		public unsafe UStaticMeshComponent Plane
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroPortalCapture_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroPortalCapture_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17005BD4 RID: 23508
		// (get) Token: 0x060281EA RID: 164330 RVA: 0x009A47C6 File Offset: 0x009A29C6
		// (set) Token: 0x060281EB RID: 164331 RVA: 0x009A47DA File Offset: 0x009A29DA
		public unsafe USceneComponent Scene
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroPortalCapture_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroPortalCapture_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17005BD5 RID: 23509
		// (get) Token: 0x060281EC RID: 164332 RVA: 0x009A47EF File Offset: 0x009A29EF
		// (set) Token: 0x060281ED RID: 164333 RVA: 0x009A4803 File Offset: 0x009A2A03
		public unsafe AActor Target
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroPortalCapture_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroPortalCapture_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17005BD6 RID: 23510
		// (get) Token: 0x060281EE RID: 164334 RVA: 0x009A4818 File Offset: 0x009A2A18
		// (set) Token: 0x060281EF RID: 164335 RVA: 0x009A4828 File Offset: 0x009A2A28
		public unsafe float offset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroPortalCapture_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroPortalCapture_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17005BD7 RID: 23511
		// (get) Token: 0x060281F0 RID: 164336 RVA: 0x009A4839 File Offset: 0x009A2A39
		// (set) Token: 0x060281F1 RID: 164337 RVA: 0x009A4849 File Offset: 0x009A2A49
		public unsafe bool EnableCamera
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroPortalCapture_C.__PropertyOffset_7) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroPortalCapture_C.__PropertyOffset_7) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005BD8 RID: 23512
		// (get) Token: 0x060281F2 RID: 164338 RVA: 0x009A485C File Offset: 0x009A2A5C
		// (set) Token: 0x060281F3 RID: 164339 RVA: 0x009A4895 File Offset: 0x009A2A95
		[Nullable(1)]
		public RoleTeleport RoleTeleport
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				RoleTeleport result;
				if ((result = this._RoleTeleport) == null)
				{
					result = (this._RoleTeleport = new RoleTeleport(base.NativePtr + (IntPtr)BP_KuroPortalCapture_C.__PropertyOffset_8, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_KuroPortalCapture_C.__PropertyOffset_8, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17005BD9 RID: 23513
		// (get) Token: 0x060281F4 RID: 164340 RVA: 0x009A48B6 File Offset: 0x009A2AB6
		// (set) Token: 0x060281F5 RID: 164341 RVA: 0x009A48C6 File Offset: 0x009A2AC6
		public unsafe int PbdataId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroPortalCapture_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroPortalCapture_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17005BDA RID: 23514
		// (get) Token: 0x060281F6 RID: 164342 RVA: 0x009A48D7 File Offset: 0x009A2AD7
		// (set) Token: 0x060281F7 RID: 164343 RVA: 0x009A48E7 File Offset: 0x009A2AE7
		public unsafe float Hight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroPortalCapture_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroPortalCapture_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x060281F8 RID: 164344 RVA: 0x009A48F8 File Offset: 0x009A2AF8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void ToggleDebug(bool Enable)
		{
			BP_KuroPortalCapture_C.__ToggleDebug_FunctionParams* ptr = stackalloc BP_KuroPortalCapture_C.__ToggleDebug_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_KuroPortalCapture_C.__ToggleDebug_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroPortalCapture_C.__ToggleDebug_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Enable = Enable;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroPortalCapture_C.__ToggleDebug_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060281F9 RID: 164345 RVA: 0x009A4940 File Offset: 0x009A2B40
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetPair(ref BP_KuroPortalCapture_C Target)
		{
			BP_KuroPortalCapture_C.__GetPair_FunctionParams* ptr = stackalloc BP_KuroPortalCapture_C.__GetPair_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_KuroPortalCapture_C.__GetPair_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroPortalCapture_C.__GetPair_NativeFunctionPtr, (void*)ptr, 1);
			ref BP_KuroPortalCapture_C.__GetPair_FunctionParams ptr2 = ref *ptr;
			BP_KuroPortalCapture_C bp_KuroPortalCapture_C = Target;
			ptr2.Target = ((bp_KuroPortalCapture_C != null) ? bp_KuroPortalCapture_C.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroPortalCapture_C.__GetPair_NativeFunctionPtr, (void*)ptr);
			Target = BuiltinUtils.GetOrCreateUObjectByNativePointer<BP_KuroPortalCapture_C>(ptr->Target);
		}

		// Token: 0x060281FA RID: 164346 RVA: 0x009A49A4 File Offset: 0x009A2BA4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetPortalTrans(ref FTransformDouble NewParam)
		{
			BP_KuroPortalCapture_C.__GetPortalTrans_FunctionParams* ptr = stackalloc BP_KuroPortalCapture_C.__GetPortalTrans_FunctionParams[(UIntPtr)143] + 15L / (long)sizeof(BP_KuroPortalCapture_C.__GetPortalTrans_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroPortalCapture_C.__GetPortalTrans_NativeFunctionPtr, (void*)ptr, 1);
			ptr->NewParam = NewParam;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroPortalCapture_C.__GetPortalTrans_NativeFunctionPtr, (void*)ptr);
			NewParam = ptr->NewParam;
		}

		// Token: 0x060281FB RID: 164347 RVA: 0x009A4A00 File Offset: 0x009A2C00
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetPbDataId(int PbdataId)
		{
			BP_KuroPortalCapture_C.__SetPbDataId_FunctionParams* ptr = stackalloc BP_KuroPortalCapture_C.__SetPbDataId_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_KuroPortalCapture_C.__SetPbDataId_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroPortalCapture_C.__SetPbDataId_NativeFunctionPtr, (void*)ptr, 1);
			ptr->PbdataId = PbdataId;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroPortalCapture_C.__SetPbDataId_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060281FC RID: 164348 RVA: 0x009A4A48 File Offset: 0x009A2C48
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetPair(AActor Pair)
		{
			BP_KuroPortalCapture_C.__SetPair_FunctionParams* ptr = stackalloc BP_KuroPortalCapture_C.__SetPair_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_KuroPortalCapture_C.__SetPair_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroPortalCapture_C.__SetPair_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Pair = ((Pair != null) ? Pair.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroPortalCapture_C.__SetPair_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060281FD RID: 164349 RVA: 0x009A4AA0 File Offset: 0x009A2CA0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Teleport(FTransformDouble InTrans, AActor InActor, bool IsRole)
		{
			BP_KuroPortalCapture_C.__Teleport_FunctionParams* ptr = stackalloc BP_KuroPortalCapture_C.__Teleport_FunctionParams[(UIntPtr)3135] + 15L / (long)sizeof(BP_KuroPortalCapture_C.__Teleport_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroPortalCapture_C.__Teleport_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InTrans = InTrans;
			ptr->InActor = ((InActor != null) ? InActor.NativePtr : IntPtr.Zero);
			ptr->IsRole = IsRole;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroPortalCapture_C.__Teleport_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060281FE RID: 164350 RVA: 0x009A4B06 File Offset: 0x009A2D06
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroPortalCapture_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x060281FF RID: 164351 RVA: 0x009A4B1A File Offset: 0x009A2D1A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroPortalCapture_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06028200 RID: 164352 RVA: 0x009A4B30 File Offset: 0x009A2D30
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_KuroPortalCapture_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_KuroPortalCapture_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_KuroPortalCapture_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroPortalCapture_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroPortalCapture_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06028201 RID: 164353 RVA: 0x009A4B78 File Offset: 0x009A2D78
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_KuroPortalCapture_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_KuroPortalCapture_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_KuroPortalCapture_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroPortalCapture_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroPortalCapture_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06028202 RID: 164354 RVA: 0x009A4BBF File Offset: 0x009A2DBF
		protected BP_KuroPortalCapture_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040146B1 RID: 83633
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/GamePlay/Portal/BP_KuroPortalCapture.BP_KuroPortalCapture_C";

		// Token: 0x040146B2 RID: 83634
		private static IntPtr _ClassPtr;

		// Token: 0x040146B3 RID: 83635
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040146B4 RID: 83636
		public static IntPtr __RoleTeleport__DelegateSignature_NativeFunctionPtr;

		// Token: 0x040146B5 RID: 83637
		internal static int __PropertyOffset_1;

		// Token: 0x040146B6 RID: 83638
		internal static int __PropertyOffset_2;

		// Token: 0x040146B7 RID: 83639
		internal static int __PropertyOffset_3;

		// Token: 0x040146B8 RID: 83640
		internal static int __PropertyOffset_4;

		// Token: 0x040146B9 RID: 83641
		internal static int __PropertyOffset_5;

		// Token: 0x040146BA RID: 83642
		internal static int __PropertyOffset_6;

		// Token: 0x040146BB RID: 83643
		internal static int __PropertyOffset_7;

		// Token: 0x040146BC RID: 83644
		internal static int __PropertyOffset_8;

		// Token: 0x040146BD RID: 83645
		private RoleTeleport _RoleTeleport;

		// Token: 0x040146BE RID: 83646
		internal static int __PropertyOffset_9;

		// Token: 0x040146BF RID: 83647
		internal static int __PropertyOffset_10;

		// Token: 0x040146C0 RID: 83648
		private static IntPtr __ToggleDebug_NativeFunctionPtr;

		// Token: 0x040146C1 RID: 83649
		private static IntPtr __GetPair_NativeFunctionPtr;

		// Token: 0x040146C2 RID: 83650
		private static IntPtr __GetPortalTrans_NativeFunctionPtr;

		// Token: 0x040146C3 RID: 83651
		private static IntPtr __SetPbDataId_NativeFunctionPtr;

		// Token: 0x040146C4 RID: 83652
		private static IntPtr __SetPair_NativeFunctionPtr;

		// Token: 0x040146C5 RID: 83653
		private static IntPtr __Teleport_NativeFunctionPtr;

		// Token: 0x040146C6 RID: 83654
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x040146C7 RID: 83655
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0200A2C3 RID: 41667
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __ToggleDebug_FunctionParams
		{
			// Token: 0x04032002 RID: 204802
			[FieldOffset(0)]
			public bool Enable;
		}

		// Token: 0x0200A2C4 RID: 41668
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __GetPair_FunctionParams
		{
			// Token: 0x04032003 RID: 204803
			[FieldOffset(0)]
			public IntPtr Target;
		}

		// Token: 0x0200A2C5 RID: 41669
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 128)]
		protected ref struct __GetPortalTrans_FunctionParams
		{
			// Token: 0x04032004 RID: 204804
			[FieldOffset(0)]
			public FTransformDouble NewParam;
		}

		// Token: 0x0200A2C6 RID: 41670
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __SetPbDataId_FunctionParams
		{
			// Token: 0x04032005 RID: 204805
			[FieldOffset(0)]
			public int PbdataId;
		}

		// Token: 0x0200A2C7 RID: 41671
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __SetPair_FunctionParams
		{
			// Token: 0x04032006 RID: 204806
			[FieldOffset(0)]
			public IntPtr Pair;
		}

		// Token: 0x0200A2C8 RID: 41672
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 3120)]
		protected ref struct __Teleport_FunctionParams
		{
			// Token: 0x04032007 RID: 204807
			[FieldOffset(0)]
			public FTransformDouble InTrans;

			// Token: 0x04032008 RID: 204808
			[FieldOffset(64)]
			public IntPtr InActor;

			// Token: 0x04032009 RID: 204809
			[FieldOffset(72)]
			public bool IsRole;
		}

		// Token: 0x0200A2C9 RID: 41673
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0403200A RID: 204810
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}

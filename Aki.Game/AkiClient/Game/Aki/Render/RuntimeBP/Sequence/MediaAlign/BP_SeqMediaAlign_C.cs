using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Sequence.MediaAlign
{
	// Token: 0x02003AE3 RID: 15075
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Sequence/MediaAlign/BP_SeqMediaAlign.BP_SeqMediaAlign_C")]
	[UnrealStructLayout(1088, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1081)]
	public class BP_SeqMediaAlign_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020977 RID: 133495 RVA: 0x008D73DC File Offset: 0x008D55DC
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SeqMediaAlign_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Sequence/MediaAlign/BP_SeqMediaAlign.BP_SeqMediaAlign_C");
			}
			return BP_SeqMediaAlign_C._ClassPtr;
		}

		// Token: 0x06020978 RID: 133496 RVA: 0x008D7400 File Offset: 0x008D5600
		public BP_SeqMediaAlign_C() : this(BuiltinUtils.AllocNativeUObject(BP_SeqMediaAlign_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020979 RID: 133497 RVA: 0x008D7428 File Offset: 0x008D5628
		[NullableContext(1)]
		public BP_SeqMediaAlign_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SeqMediaAlign_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003184 RID: 12676
		// (get) Token: 0x0602097A RID: 133498 RVA: 0x008D745B File Offset: 0x008D565B
		// (set) Token: 0x0602097B RID: 133499 RVA: 0x008D746F File Offset: 0x008D566F
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeqMediaAlign_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeqMediaAlign_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17003185 RID: 12677
		// (get) Token: 0x0602097C RID: 133500 RVA: 0x008D7484 File Offset: 0x008D5684
		// (set) Token: 0x0602097D RID: 133501 RVA: 0x008D7498 File Offset: 0x008D5698
		public unsafe UMediaSource MeidaSourceOnBeginPlay
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMediaSource>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeqMediaAlign_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeqMediaAlign_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17003186 RID: 12678
		// (get) Token: 0x0602097E RID: 133502 RVA: 0x008D74AD File Offset: 0x008D56AD
		// (set) Token: 0x0602097F RID: 133503 RVA: 0x008D74C1 File Offset: 0x008D56C1
		public unsafe UMediaSource MeidaSourceOnEndPlay
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMediaSource>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeqMediaAlign_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeqMediaAlign_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17003187 RID: 12679
		// (get) Token: 0x06020980 RID: 133504 RVA: 0x008D74D6 File Offset: 0x008D56D6
		// (set) Token: 0x06020981 RID: 133505 RVA: 0x008D74E6 File Offset: 0x008D56E6
		public unsafe bool CloseOnEndPlay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SeqMediaAlign_C.__PropertyOffset_4) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SeqMediaAlign_C.__PropertyOffset_4) = (value ? 1 : 0);
			}
		}

		// Token: 0x06020982 RID: 133506 RVA: 0x008D74F8 File Offset: 0x008D56F8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetMediaAlignComponent(ref UKuroMediaAlignComponent NewParam)
		{
			BP_SeqMediaAlign_C.__GetMediaAlignComponent_FunctionParams* ptr = stackalloc BP_SeqMediaAlign_C.__GetMediaAlignComponent_FunctionParams[(UIntPtr)159] + 15L / (long)sizeof(BP_SeqMediaAlign_C.__GetMediaAlignComponent_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqMediaAlign_C.__GetMediaAlignComponent_NativeFunctionPtr, (void*)ptr, 1);
			ref BP_SeqMediaAlign_C.__GetMediaAlignComponent_FunctionParams ptr2 = ref *ptr;
			UKuroMediaAlignComponent ukuroMediaAlignComponent = NewParam;
			ptr2.NewParam = ((ukuroMediaAlignComponent != null) ? ukuroMediaAlignComponent.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SeqMediaAlign_C.__GetMediaAlignComponent_NativeFunctionPtr, (void*)ptr);
			NewParam = BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroMediaAlignComponent>(ptr->NewParam);
		}

		// Token: 0x06020983 RID: 133507 RVA: 0x008D755F File Offset: 0x008D575F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SeqMediaAlign_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06020984 RID: 133508 RVA: 0x008D7573 File Offset: 0x008D5773
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SeqMediaAlign_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06020985 RID: 133509 RVA: 0x008D7588 File Offset: 0x008D5788
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
		{
			BP_SeqMediaAlign_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_SeqMediaAlign_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_SeqMediaAlign_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqMediaAlign_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SeqMediaAlign_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020986 RID: 133510 RVA: 0x008D75D4 File Offset: 0x008D57D4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
		{
			BP_SeqMediaAlign_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_SeqMediaAlign_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_SeqMediaAlign_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqMediaAlign_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SeqMediaAlign_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06020987 RID: 133511 RVA: 0x008D7620 File Offset: 0x008D5820
		protected BP_SeqMediaAlign_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FCD3 RID: 64723
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Sequence/MediaAlign/BP_SeqMediaAlign.BP_SeqMediaAlign_C";

		// Token: 0x0400FCD4 RID: 64724
		private static IntPtr _ClassPtr;

		// Token: 0x0400FCD5 RID: 64725
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FCD6 RID: 64726
		internal static int __PropertyOffset_1;

		// Token: 0x0400FCD7 RID: 64727
		internal static int __PropertyOffset_2;

		// Token: 0x0400FCD8 RID: 64728
		internal static int __PropertyOffset_3;

		// Token: 0x0400FCD9 RID: 64729
		internal static int __PropertyOffset_4;

		// Token: 0x0400FCDA RID: 64730
		private static IntPtr __GetMediaAlignComponent_NativeFunctionPtr;

		// Token: 0x0400FCDB RID: 64731
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0400FCDC RID: 64732
		private static IntPtr __ReceiveEndPlay_NativeFunctionPtr;

		// Token: 0x02009BE3 RID: 39907
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 144)]
		protected ref struct __GetMediaAlignComponent_FunctionParams
		{
			// Token: 0x04031277 RID: 201335
			[FieldOffset(0)]
			public IntPtr NewParam;
		}

		// Token: 0x02009BE4 RID: 39908
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __ReceiveEndPlay_FunctionParams
		{
			// Token: 0x04031278 RID: 201336
			[FieldOffset(0)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}
	}
}

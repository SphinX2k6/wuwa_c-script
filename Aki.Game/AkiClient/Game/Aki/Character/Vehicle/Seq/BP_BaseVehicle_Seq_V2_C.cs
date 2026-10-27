using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Sequence.Interface;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Vehicle.Seq
{
	// Token: 0x02004031 RID: 16433
	[UnrealObjectPath("/Game/Aki/Character/Vehicle/Seq/BP_BaseVehicle_Seq_V2.BP_BaseVehicle_Seq_V2_C")]
	[UnrealStructLayout(1216, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1216)]
	public class BP_BaseVehicle_Seq_V2_C : APawn, IUnrealUObject, IUnrealObject, IBPI_SeqBindingActor_C, IUnrealBlueprintInterface, IUnrealInterface
	{
		// Token: 0x0602A26D RID: 172653 RVA: 0x009D7850 File Offset: 0x009D5A50
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_BaseVehicle_Seq_V2_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Vehicle/Seq/BP_BaseVehicle_Seq_V2.BP_BaseVehicle_Seq_V2_C");
			}
			return BP_BaseVehicle_Seq_V2_C._ClassPtr;
		}

		// Token: 0x0602A26E RID: 172654 RVA: 0x009D7874 File Offset: 0x009D5A74
		public BP_BaseVehicle_Seq_V2_C() : this(BuiltinUtils.AllocNativeUObject(BP_BaseVehicle_Seq_V2_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602A26F RID: 172655 RVA: 0x009D789C File Offset: 0x009D5A9C
		[NullableContext(1)]
		public BP_BaseVehicle_Seq_V2_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_BaseVehicle_Seq_V2_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170066ED RID: 26349
		// (get) Token: 0x0602A270 RID: 172656 RVA: 0x009D78CF File Offset: 0x009D5ACF
		// (set) Token: 0x0602A271 RID: 172657 RVA: 0x009D78E3 File Offset: 0x009D5AE3
		[Nullable(2)]
		public unsafe USkeletalMeshComponent SkeletalMesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BaseVehicle_Seq_V2_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BaseVehicle_Seq_V2_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170066EE RID: 26350
		// (get) Token: 0x0602A272 RID: 172658 RVA: 0x009D78F8 File Offset: 0x009D5AF8
		// (set) Token: 0x0602A273 RID: 172659 RVA: 0x009D790C File Offset: 0x009D5B0C
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BaseVehicle_Seq_V2_C.__PropertyOffset_2);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BaseVehicle_Seq_V2_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x170066EF RID: 26351
		// (get) Token: 0x0602A274 RID: 172660 RVA: 0x009D7921 File Offset: 0x009D5B21
		// (set) Token: 0x0602A275 RID: 172661 RVA: 0x009D7935 File Offset: 0x009D5B35
		public unsafe FName BindingTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BaseVehicle_Seq_V2_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BaseVehicle_Seq_V2_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x170066F0 RID: 26352
		// (get) Token: 0x0602A276 RID: 172662 RVA: 0x009D794A File Offset: 0x009D5B4A
		// (set) Token: 0x0602A277 RID: 172663 RVA: 0x009D795E File Offset: 0x009D5B5E
		public unsafe FVector FinalSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BaseVehicle_Seq_V2_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BaseVehicle_Seq_V2_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x170066F1 RID: 26353
		// (get) Token: 0x0602A278 RID: 172664 RVA: 0x009D7973 File Offset: 0x009D5B73
		// (set) Token: 0x0602A279 RID: 172665 RVA: 0x009D7983 File Offset: 0x009D5B83
		public unsafe float velocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BaseVehicle_Seq_V2_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BaseVehicle_Seq_V2_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x170066F2 RID: 26354
		// (get) Token: 0x0602A27A RID: 172666 RVA: 0x009D7994 File Offset: 0x009D5B94
		// (set) Token: 0x0602A27B RID: 172667 RVA: 0x009D79A8 File Offset: 0x009D5BA8
		[Nullable(1)]
		public unsafe string CurrSpeed
		{
			[NullableContext(1)]
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_BaseVehicle_Seq_V2_C.__PropertyOffset_6)));
			}
			[NullableContext(1)]
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_BaseVehicle_Seq_V2_C.__PropertyOffset_6)), value);
			}
		}

		// Token: 0x0602A27C RID: 172668 RVA: 0x009D79C0 File Offset: 0x009D5BC0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetSeqBindingTag(ref FName Tag)
		{
			BP_BaseVehicle_Seq_V2_C.__GetSeqBindingTag_FunctionParams* ptr = stackalloc BP_BaseVehicle_Seq_V2_C.__GetSeqBindingTag_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(BP_BaseVehicle_Seq_V2_C.__GetSeqBindingTag_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BaseVehicle_Seq_V2_C.__GetSeqBindingTag_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BaseVehicle_Seq_V2_C.__GetSeqBindingTag_NativeFunctionPtr, (void*)ptr);
			Tag = ptr->Tag;
		}

		// Token: 0x0602A27D RID: 172669 RVA: 0x009D7A17 File Offset: 0x009D5C17
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void GetFinalSpeed()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BaseVehicle_Seq_V2_C.__GetFinalSpeed_NativeFunctionPtr, null);
		}

		// Token: 0x0602A27E RID: 172670 RVA: 0x009D7A2C File Offset: 0x009D5C2C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_BaseVehicle_Seq_V2_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_BaseVehicle_Seq_V2_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_BaseVehicle_Seq_V2_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BaseVehicle_Seq_V2_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BaseVehicle_Seq_V2_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602A27F RID: 172671 RVA: 0x009D7A74 File Offset: 0x009D5C74
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_BaseVehicle_Seq_V2_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_BaseVehicle_Seq_V2_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_BaseVehicle_Seq_V2_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BaseVehicle_Seq_V2_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_BaseVehicle_Seq_V2_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602A280 RID: 172672 RVA: 0x009D7ABB File Offset: 0x009D5CBB
		protected BP_BaseVehicle_Seq_V2_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015B9E RID: 88990
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Vehicle/Seq/BP_BaseVehicle_Seq_V2.BP_BaseVehicle_Seq_V2_C";

		// Token: 0x04015B9F RID: 88991
		private static IntPtr _ClassPtr;

		// Token: 0x04015BA0 RID: 88992
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015BA1 RID: 88993
		internal static int __PropertyOffset_1;

		// Token: 0x04015BA2 RID: 88994
		internal static int __PropertyOffset_2;

		// Token: 0x04015BA3 RID: 88995
		internal static int __PropertyOffset_3;

		// Token: 0x04015BA4 RID: 88996
		internal static int __PropertyOffset_4;

		// Token: 0x04015BA5 RID: 88997
		internal static int __PropertyOffset_5;

		// Token: 0x04015BA6 RID: 88998
		internal static int __PropertyOffset_6;

		// Token: 0x04015BA7 RID: 88999
		private static IntPtr __GetSeqBindingTag_NativeFunctionPtr;

		// Token: 0x04015BA8 RID: 89000
		private static IntPtr __GetFinalSpeed_NativeFunctionPtr;

		// Token: 0x04015BA9 RID: 89001
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0200A33F RID: 41791
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __GetSeqBindingTag_FunctionParams
		{
			// Token: 0x04032102 RID: 205058
			[FieldOffset(0)]
			public FName Tag;
		}

		// Token: 0x0200A340 RID: 41792
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04032103 RID: 205059
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}

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
	// Token: 0x0200328A RID: 12938
	[UnrealObjectPath("/Game/Aki/Character/Vehicle/Seq/BP_BaseVehicle_Seq_V2.BP_BaseVehicle_Seq_V2_C")]
	[UnrealStructLayout(1216, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1216)]
	public class BP_BaseVehicle_Seq_V2_C : APawn, IUnrealUObject, IUnrealObject, IBPI_SeqBindingActor_C, IUnrealBlueprintInterface, IUnrealInterface
	{
		// Token: 0x060205DD RID: 132573 RVA: 0x00944814 File Offset: 0x00942A14
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_BaseVehicle_Seq_V2_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Vehicle/Seq/BP_BaseVehicle_Seq_V2.BP_BaseVehicle_Seq_V2_C");
			}
			return BP_BaseVehicle_Seq_V2_C._ClassPtr;
		}

		// Token: 0x060205DE RID: 132574 RVA: 0x00944838 File Offset: 0x00942A38
		public BP_BaseVehicle_Seq_V2_C() : this(BuiltinUtils.AllocNativeUObject(BP_BaseVehicle_Seq_V2_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060205DF RID: 132575 RVA: 0x00944860 File Offset: 0x00942A60
		[NullableContext(1)]
		public BP_BaseVehicle_Seq_V2_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_BaseVehicle_Seq_V2_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003EA7 RID: 16039
		// (get) Token: 0x060205E0 RID: 132576 RVA: 0x00944893 File Offset: 0x00942A93
		// (set) Token: 0x060205E1 RID: 132577 RVA: 0x009448A7 File Offset: 0x00942AA7
		[Nullable(2)]
		public unsafe USkeletalMeshComponent SkeletalMesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BaseVehicle_Seq_V2_C.__PropertyOffset_SkeletalMesh);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BaseVehicle_Seq_V2_C.__PropertyOffset_SkeletalMesh, value);
			}
		}

		// Token: 0x17003EA8 RID: 16040
		// (get) Token: 0x060205E2 RID: 132578 RVA: 0x009448BC File Offset: 0x00942ABC
		// (set) Token: 0x060205E3 RID: 132579 RVA: 0x009448D0 File Offset: 0x00942AD0
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BaseVehicle_Seq_V2_C.__PropertyOffset_DefaultSceneRoot);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BaseVehicle_Seq_V2_C.__PropertyOffset_DefaultSceneRoot, value);
			}
		}

		// Token: 0x17003EA9 RID: 16041
		// (get) Token: 0x060205E4 RID: 132580 RVA: 0x009448E5 File Offset: 0x00942AE5
		// (set) Token: 0x060205E5 RID: 132581 RVA: 0x009448F9 File Offset: 0x00942AF9
		public unsafe FName BindingTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BaseVehicle_Seq_V2_C.__PropertyOffset_BindingTag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BaseVehicle_Seq_V2_C.__PropertyOffset_BindingTag) = value;
			}
		}

		// Token: 0x17003EAA RID: 16042
		// (get) Token: 0x060205E6 RID: 132582 RVA: 0x0094490E File Offset: 0x00942B0E
		// (set) Token: 0x060205E7 RID: 132583 RVA: 0x00944922 File Offset: 0x00942B22
		public unsafe FVector FinalSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BaseVehicle_Seq_V2_C.__PropertyOffset_FinalSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BaseVehicle_Seq_V2_C.__PropertyOffset_FinalSpeed) = value;
			}
		}

		// Token: 0x17003EAB RID: 16043
		// (get) Token: 0x060205E8 RID: 132584 RVA: 0x00944937 File Offset: 0x00942B37
		// (set) Token: 0x060205E9 RID: 132585 RVA: 0x00944947 File Offset: 0x00942B47
		public unsafe float velocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BaseVehicle_Seq_V2_C.__PropertyOffset_velocity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BaseVehicle_Seq_V2_C.__PropertyOffset_velocity) = value;
			}
		}

		// Token: 0x17003EAC RID: 16044
		// (get) Token: 0x060205EA RID: 132586 RVA: 0x00944958 File Offset: 0x00942B58
		// (set) Token: 0x060205EB RID: 132587 RVA: 0x0094496C File Offset: 0x00942B6C
		[Nullable(1)]
		public unsafe string CurrSpeed
		{
			[NullableContext(1)]
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_BaseVehicle_Seq_V2_C.__PropertyOffset_CurrSpeed)));
			}
			[NullableContext(1)]
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_BaseVehicle_Seq_V2_C.__PropertyOffset_CurrSpeed)), value);
			}
		}

		// Token: 0x060205EC RID: 132588 RVA: 0x00944984 File Offset: 0x00942B84
		[SkipLocalsInit]
		public unsafe virtual void GetSeqBindingTag(ref FName Tag)
		{
			BP_BaseVehicle_Seq_V2_C.__GetSeqBindingTag_FunctionParams* ptr = stackalloc BP_BaseVehicle_Seq_V2_C.__GetSeqBindingTag_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(BP_BaseVehicle_Seq_V2_C.__GetSeqBindingTag_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BaseVehicle_Seq_V2_C.__GetSeqBindingTag_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BaseVehicle_Seq_V2_C.__GetSeqBindingTag_NativeFunctionPtr, (void*)ptr);
			Tag = ptr->Tag;
		}

		// Token: 0x060205ED RID: 132589 RVA: 0x009449DB File Offset: 0x00942BDB
		[SkipLocalsInit]
		public virtual void GetFinalSpeed()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BaseVehicle_Seq_V2_C.__GetFinalSpeed_NativeFunctionPtr, null);
		}

		// Token: 0x060205EE RID: 132590 RVA: 0x009449F0 File Offset: 0x00942BF0
		[SkipLocalsInit]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_BaseVehicle_Seq_V2_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_BaseVehicle_Seq_V2_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_BaseVehicle_Seq_V2_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BaseVehicle_Seq_V2_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BaseVehicle_Seq_V2_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060205EF RID: 132591 RVA: 0x00944A38 File Offset: 0x00942C38
		[SkipLocalsInit]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_BaseVehicle_Seq_V2_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_BaseVehicle_Seq_V2_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_BaseVehicle_Seq_V2_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BaseVehicle_Seq_V2_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_BaseVehicle_Seq_V2_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060205F0 RID: 132592 RVA: 0x00944A7E File Offset: 0x00942C7E
		protected BP_BaseVehicle_Seq_V2_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040117AA RID: 71594
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Vehicle/Seq/BP_BaseVehicle_Seq_V2.BP_BaseVehicle_Seq_V2_C";

		// Token: 0x040117AB RID: 71595
		private static IntPtr _ClassPtr;

		// Token: 0x040117AC RID: 71596
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040117AD RID: 71597
		internal static int __PropertyOffset_SkeletalMesh;

		// Token: 0x040117AE RID: 71598
		internal static int __PropertyOffset_DefaultSceneRoot;

		// Token: 0x040117AF RID: 71599
		internal static int __PropertyOffset_BindingTag;

		// Token: 0x040117B0 RID: 71600
		internal static int __PropertyOffset_FinalSpeed;

		// Token: 0x040117B1 RID: 71601
		internal static int __PropertyOffset_velocity;

		// Token: 0x040117B2 RID: 71602
		internal static int __PropertyOffset_CurrSpeed;

		// Token: 0x040117B3 RID: 71603
		private static IntPtr __GetSeqBindingTag_NativeFunctionPtr;

		// Token: 0x040117B4 RID: 71604
		private static IntPtr __GetFinalSpeed_NativeFunctionPtr;

		// Token: 0x040117B5 RID: 71605
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x02008F57 RID: 36695
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __GetSeqBindingTag_FunctionParams
		{
			// Token: 0x0402CCCB RID: 183499
			[FieldOffset(0)]
			public FName Tag;
		}

		// Token: 0x02008F58 RID: 36696
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0402CCCC RID: 183500
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}

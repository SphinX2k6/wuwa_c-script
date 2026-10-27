using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.KuroCS
{
	// Token: 0x02003C87 RID: 15495
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/KuroCS/BP_KuroCSSkelPlant.BP_KuroCSSkelPlant_C")]
	[UnrealStructLayout(1320, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1320)]
	public class BP_KuroCSSkelPlant_C : AKuroCSSkeltalPlant, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060242C1 RID: 148161 RVA: 0x00936C95 File Offset: 0x00934E95
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_KuroCSSkelPlant_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/KuroCS/BP_KuroCSSkelPlant.BP_KuroCSSkelPlant_C");
			}
			return BP_KuroCSSkelPlant_C._ClassPtr;
		}

		// Token: 0x060242C2 RID: 148162 RVA: 0x00936CBC File Offset: 0x00934EBC
		public BP_KuroCSSkelPlant_C() : this(BuiltinUtils.AllocNativeUObject(BP_KuroCSSkelPlant_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060242C3 RID: 148163 RVA: 0x00936CE4 File Offset: 0x00934EE4
		[NullableContext(1)]
		public BP_KuroCSSkelPlant_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_KuroCSSkelPlant_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170045A6 RID: 17830
		// (get) Token: 0x060242C4 RID: 148164 RVA: 0x00936D17 File Offset: 0x00934F17
		// (set) Token: 0x060242C5 RID: 148165 RVA: 0x00936D2B File Offset: 0x00934F2B
		public unsafe UBoxComponent Box
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCSSkelPlant_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCSSkelPlant_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170045A7 RID: 17831
		// (get) Token: 0x060242C6 RID: 148166 RVA: 0x00936D40 File Offset: 0x00934F40
		// (set) Token: 0x060242C7 RID: 148167 RVA: 0x00936D54 File Offset: 0x00934F54
		public unsafe UStaticMeshComponent StaticMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCSSkelPlant_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCSSkelPlant_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x170045A8 RID: 17832
		// (get) Token: 0x060242C8 RID: 148168 RVA: 0x00936D69 File Offset: 0x00934F69
		// (set) Token: 0x060242C9 RID: 148169 RVA: 0x00936D7D File Offset: 0x00934F7D
		public unsafe USkeletalMeshComponent SkeletalMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCSSkelPlant_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCSSkelPlant_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x170045A9 RID: 17833
		// (get) Token: 0x060242CA RID: 148170 RVA: 0x00936D94 File Offset: 0x00934F94
		// (set) Token: 0x060242CB RID: 148171 RVA: 0x00936DCD File Offset: 0x00934FCD
		[Nullable(1)]
		public TArray<FTransform> Bone_List
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FTransform> result;
				if ((result = this._Bone_List) == null)
				{
					result = (this._Bone_List = new TArray<FTransform>(base.NativePtr + (IntPtr)BP_KuroCSSkelPlant_C.__PropertyOffset_4, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Bone_List.CopyAssign(value);
			}
		}

		// Token: 0x170045AA RID: 17834
		// (get) Token: 0x060242CC RID: 148172 RVA: 0x00936DDC File Offset: 0x00934FDC
		// (set) Token: 0x060242CD RID: 148173 RVA: 0x00936E15 File Offset: 0x00935015
		[Nullable(1)]
		public TArray<FName> Bone_Name_List
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._Bone_Name_List) == null)
				{
					result = (this._Bone_Name_List = new TArray<FName>(base.NativePtr + (IntPtr)BP_KuroCSSkelPlant_C.__PropertyOffset_5, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Bone_Name_List.CopyAssign(value);
			}
		}

		// Token: 0x170045AB RID: 17835
		// (get) Token: 0x060242CE RID: 148174 RVA: 0x00936E24 File Offset: 0x00935024
		// (set) Token: 0x060242CF RID: 148175 RVA: 0x00936E5D File Offset: 0x0093505D
		[Nullable(1)]
		public TArray<int> Parent_Index_List
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._Parent_Index_List) == null)
				{
					result = (this._Parent_Index_List = new TArray<int>(base.NativePtr + (IntPtr)BP_KuroCSSkelPlant_C.__PropertyOffset_6, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Parent_Index_List.CopyAssign(value);
			}
		}

		// Token: 0x170045AC RID: 17836
		// (get) Token: 0x060242D0 RID: 148176 RVA: 0x00936E6C File Offset: 0x0093506C
		// (set) Token: 0x060242D1 RID: 148177 RVA: 0x00936EA5 File Offset: 0x009350A5
		[Nullable(1)]
		public TArray<int> childIndexList
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._childIndexList) == null)
				{
					result = (this._childIndexList = new TArray<int>(base.NativePtr + (IntPtr)BP_KuroCSSkelPlant_C.__PropertyOffset_7, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.childIndexList.CopyAssign(value);
			}
		}

		// Token: 0x060242D2 RID: 148178 RVA: 0x00936EB3 File Offset: 0x009350B3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCSSkelPlant_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x060242D3 RID: 148179 RVA: 0x00936EC7 File Offset: 0x009350C7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroCSSkelPlant_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060242D4 RID: 148180 RVA: 0x00936EDC File Offset: 0x009350DC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_KuroCSSkelPlant_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_KuroCSSkelPlant_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_KuroCSSkelPlant_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroCSSkelPlant_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCSSkelPlant_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060242D5 RID: 148181 RVA: 0x00936F24 File Offset: 0x00935124
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_KuroCSSkelPlant_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_KuroCSSkelPlant_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_KuroCSSkelPlant_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroCSSkelPlant_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroCSSkelPlant_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060242D6 RID: 148182 RVA: 0x00936F6B File Offset: 0x0093516B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Set_Data()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCSSkelPlant_C.__Set_Data_NativeFunctionPtr, null);
		}

		// Token: 0x060242D7 RID: 148183 RVA: 0x00936F80 File Offset: 0x00935180
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_KuroCSSkelPlant_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, in FHitResult SweepResult)
		{
			BP_KuroCSSkelPlant_C.__BndEvt__BP_KuroCSSkelPlant_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_KuroCSSkelPlant_C.__BndEvt__BP_KuroCSSkelPlant_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(BP_KuroCSSkelPlant_C.__BndEvt__BP_KuroCSSkelPlant_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroCSSkelPlant_C.__BndEvt__BP_KuroCSSkelPlant_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			ptr->bFromSweep = bFromSweep;
			if (SweepResult != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->SweepResult, SweepResult.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCSSkelPlant_C.__BndEvt__BP_KuroCSSkelPlant_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060242D8 RID: 148184 RVA: 0x0093703C File Offset: 0x0093523C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_KuroCSSkelPlant_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex)
		{
			BP_KuroCSSkelPlant_C.__BndEvt__BP_KuroCSSkelPlant_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_KuroCSSkelPlant_C.__BndEvt__BP_KuroCSSkelPlant_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_KuroCSSkelPlant_C.__BndEvt__BP_KuroCSSkelPlant_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroCSSkelPlant_C.__BndEvt__BP_KuroCSSkelPlant_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCSSkelPlant_C.__BndEvt__BP_KuroCSSkelPlant_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060242D9 RID: 148185 RVA: 0x009370C5 File Offset: 0x009352C5
		protected BP_KuroCSSkelPlant_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011E9F RID: 73375
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/KuroCS/BP_KuroCSSkelPlant.BP_KuroCSSkelPlant_C";

		// Token: 0x04011EA0 RID: 73376
		private static IntPtr _ClassPtr;

		// Token: 0x04011EA1 RID: 73377
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011EA2 RID: 73378
		internal static int __PropertyOffset_1;

		// Token: 0x04011EA3 RID: 73379
		internal static int __PropertyOffset_2;

		// Token: 0x04011EA4 RID: 73380
		internal static int __PropertyOffset_3;

		// Token: 0x04011EA5 RID: 73381
		internal static int __PropertyOffset_4;

		// Token: 0x04011EA6 RID: 73382
		private TArray<FTransform> _Bone_List;

		// Token: 0x04011EA7 RID: 73383
		internal static int __PropertyOffset_5;

		// Token: 0x04011EA8 RID: 73384
		private TArray<FName> _Bone_Name_List;

		// Token: 0x04011EA9 RID: 73385
		internal static int __PropertyOffset_6;

		// Token: 0x04011EAA RID: 73386
		private TArray<int> _Parent_Index_List;

		// Token: 0x04011EAB RID: 73387
		internal static int __PropertyOffset_7;

		// Token: 0x04011EAC RID: 73388
		private TArray<int> _childIndexList;

		// Token: 0x04011EAD RID: 73389
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04011EAE RID: 73390
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04011EAF RID: 73391
		private static IntPtr __Set_Data_NativeFunctionPtr;

		// Token: 0x04011EB0 RID: 73392
		private static IntPtr __BndEvt__BP_KuroCSSkelPlant_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04011EB1 RID: 73393
		private static IntPtr __BndEvt__BP_KuroCSSkelPlant_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x02009EDE RID: 40670
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040317D4 RID: 202708
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009EDF RID: 40671
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __BndEvt__BP_KuroCSSkelPlant_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x040317D5 RID: 202709
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x040317D6 RID: 202710
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x040317D7 RID: 202711
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x040317D8 RID: 202712
			[FieldOffset(24)]
			public int OtherBodyIndex;

			// Token: 0x040317D9 RID: 202713
			[FieldOffset(28)]
			public bool bFromSweep;

			// Token: 0x040317DA RID: 202714
			[FieldOffset(32)]
			public byte SweepResult;
		}

		// Token: 0x02009EE0 RID: 40672
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __BndEvt__BP_KuroCSSkelPlant_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x040317DB RID: 202715
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x040317DC RID: 202716
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x040317DD RID: 202717
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x040317DE RID: 202718
			[FieldOffset(24)]
			public int OtherBodyIndex;
		}
	}
}

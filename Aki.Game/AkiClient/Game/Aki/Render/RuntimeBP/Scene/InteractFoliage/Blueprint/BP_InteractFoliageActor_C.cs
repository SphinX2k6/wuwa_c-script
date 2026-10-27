using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Scene.InteractFoliage.Blueprint.MeshActor;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.InteractFoliage.Blueprint
{
	// Token: 0x02003B55 RID: 15189
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/InteractFoliage/Blueprint/BP_InteractFoliageActor.BP_InteractFoliageActor_C")]
	[UnrealStructLayout(1584, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1584)]
	public class BP_InteractFoliageActor_C : BP_InteractFoliageActor_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021AAB RID: 137899 RVA: 0x008F27B7 File Offset: 0x008F09B7
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_InteractFoliageActor_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/InteractFoliage/Blueprint/BP_InteractFoliageActor.BP_InteractFoliageActor_C");
			}
			return BP_InteractFoliageActor_C._ClassPtr;
		}

		// Token: 0x06021AAC RID: 137900 RVA: 0x008F27DC File Offset: 0x008F09DC
		public BP_InteractFoliageActor_C() : this(BuiltinUtils.AllocNativeUObject(BP_InteractFoliageActor_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021AAD RID: 137901 RVA: 0x008F2804 File Offset: 0x008F0A04
		[NullableContext(1)]
		public BP_InteractFoliageActor_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_InteractFoliageActor_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170037B6 RID: 14262
		// (get) Token: 0x06021AAE RID: 137902 RVA: 0x008F2837 File Offset: 0x008F0A37
		// (set) Token: 0x06021AAF RID: 137903 RVA: 0x008F284B File Offset: 0x008F0A4B
		public unsafe UBoxComponent Box
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_InteractFoliageActor_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_InteractFoliageActor_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170037B7 RID: 14263
		// (get) Token: 0x06021AB0 RID: 137904 RVA: 0x008F2860 File Offset: 0x008F0A60
		// (set) Token: 0x06021AB1 RID: 137905 RVA: 0x008F2874 File Offset: 0x008F0A74
		public unsafe USkeletalMeshComponent SkeletalMeshFoliage
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_InteractFoliageActor_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_InteractFoliageActor_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x170037B8 RID: 14264
		// (get) Token: 0x06021AB2 RID: 137906 RVA: 0x008F2889 File Offset: 0x008F0A89
		// (set) Token: 0x06021AB3 RID: 137907 RVA: 0x008F289D File Offset: 0x008F0A9D
		public unsafe UStaticMeshComponent StaticMeshFoliage
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_InteractFoliageActor_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_InteractFoliageActor_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x170037B9 RID: 14265
		// (get) Token: 0x06021AB4 RID: 137908 RVA: 0x008F28B2 File Offset: 0x008F0AB2
		// (set) Token: 0x06021AB5 RID: 137909 RVA: 0x008F28C2 File Offset: 0x008F0AC2
		public unsafe bool bEnable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_InteractFoliageActor_C.__PropertyOffset_4) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_InteractFoliageActor_C.__PropertyOffset_4) = (value ? 1 : 0);
			}
		}

		// Token: 0x170037BA RID: 14266
		// (get) Token: 0x06021AB6 RID: 137910 RVA: 0x008F28D3 File Offset: 0x008F0AD3
		// (set) Token: 0x06021AB7 RID: 137911 RVA: 0x008F28E7 File Offset: 0x008F0AE7
		public unsafe KUROInteractFoliage_C FoliageType
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<KUROInteractFoliage_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_InteractFoliageActor_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_InteractFoliageActor_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x170037BB RID: 14267
		// (get) Token: 0x06021AB8 RID: 137912 RVA: 0x008F28FC File Offset: 0x008F0AFC
		// (set) Token: 0x06021AB9 RID: 137913 RVA: 0x008F290C File Offset: 0x008F0B0C
		public unsafe bool Active
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_InteractFoliageActor_C.__PropertyOffset_6) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_InteractFoliageActor_C.__PropertyOffset_6) = (value ? 1 : 0);
			}
		}

		// Token: 0x170037BC RID: 14268
		// (get) Token: 0x06021ABA RID: 137914 RVA: 0x008F291D File Offset: 0x008F0B1D
		// (set) Token: 0x06021ABB RID: 137915 RVA: 0x008F292D File Offset: 0x008F0B2D
		public unsafe float TraceRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_InteractFoliageActor_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_InteractFoliageActor_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x170037BD RID: 14269
		// (get) Token: 0x06021ABC RID: 137916 RVA: 0x008F293E File Offset: 0x008F0B3E
		// (set) Token: 0x06021ABD RID: 137917 RVA: 0x008F2952 File Offset: 0x008F0B52
		public unsafe FTransform CharacterTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_InteractFoliageActor_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_InteractFoliageActor_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x170037BE RID: 14270
		// (get) Token: 0x06021ABE RID: 137918 RVA: 0x008F2968 File Offset: 0x008F0B68
		// (set) Token: 0x06021ABF RID: 137919 RVA: 0x008F29A1 File Offset: 0x008F0BA1
		[Nullable(1)]
		public TArray<float> Primitive_Data
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._Primitive_Data) == null)
				{
					result = (this._Primitive_Data = new TArray<float>(base.NativePtr + (IntPtr)BP_InteractFoliageActor_C.__PropertyOffset_9, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Primitive_Data.CopyAssign(value);
			}
		}

		// Token: 0x170037BF RID: 14271
		// (get) Token: 0x06021AC0 RID: 137920 RVA: 0x008F29AF File Offset: 0x008F0BAF
		// (set) Token: 0x06021AC1 RID: 137921 RVA: 0x008F29BF File Offset: 0x008F0BBF
		public unsafe float MinDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_InteractFoliageActor_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_InteractFoliageActor_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x170037C0 RID: 14272
		// (get) Token: 0x06021AC2 RID: 137922 RVA: 0x008F29D0 File Offset: 0x008F0BD0
		// (set) Token: 0x06021AC3 RID: 137923 RVA: 0x008F29E0 File Offset: 0x008F0BE0
		public unsafe float MaxDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_InteractFoliageActor_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_InteractFoliageActor_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x170037C1 RID: 14273
		// (get) Token: 0x06021AC4 RID: 137924 RVA: 0x008F29F1 File Offset: 0x008F0BF1
		// (set) Token: 0x06021AC5 RID: 137925 RVA: 0x008F2A01 File Offset: 0x008F0C01
		public unsafe float TickTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_InteractFoliageActor_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_InteractFoliageActor_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x170037C2 RID: 14274
		// (get) Token: 0x06021AC6 RID: 137926 RVA: 0x008F2A12 File Offset: 0x008F0C12
		// (set) Token: 0x06021AC7 RID: 137927 RVA: 0x008F2A22 File Offset: 0x008F0C22
		public unsafe float CachedQualityLevel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_InteractFoliageActor_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_InteractFoliageActor_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x06021AC8 RID: 137928 RVA: 0x008F2A34 File Offset: 0x008F0C34
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void AdaptQualityLevel(ref bool bShouldTick)
		{
			BP_InteractFoliageActor_C.__AdaptQualityLevel_FunctionParams* ptr = stackalloc BP_InteractFoliageActor_C.__AdaptQualityLevel_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(BP_InteractFoliageActor_C.__AdaptQualityLevel_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InteractFoliageActor_C.__AdaptQualityLevel_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bShouldTick = bShouldTick;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InteractFoliageActor_C.__AdaptQualityLevel_NativeFunctionPtr, (void*)ptr);
			bShouldTick = ptr->bShouldTick;
		}

		// Token: 0x06021AC9 RID: 137929 RVA: 0x008F2A84 File Offset: 0x008F0C84
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void ChangeActiveFoliageNum(float ChangeNum)
		{
			BP_InteractFoliageActor_C.__ChangeActiveFoliageNum_FunctionParams* ptr = stackalloc BP_InteractFoliageActor_C.__ChangeActiveFoliageNum_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(BP_InteractFoliageActor_C.__ChangeActiveFoliageNum_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InteractFoliageActor_C.__ChangeActiveFoliageNum_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ChangeNum = ChangeNum;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InteractFoliageActor_C.__ChangeActiveFoliageNum_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021ACA RID: 137930 RVA: 0x008F2ACA File Offset: 0x008F0CCA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void InitialData()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InteractFoliageActor_C.__InitialData_NativeFunctionPtr, null);
		}

		// Token: 0x06021ACB RID: 137931 RVA: 0x008F2ADE File Offset: 0x008F0CDE
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InteractFoliageActor_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06021ACC RID: 137932 RVA: 0x008F2AF2 File Offset: 0x008F0CF2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_InteractFoliageActor_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06021ACD RID: 137933 RVA: 0x008F2B08 File Offset: 0x008F0D08
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_InteractFoliageActor_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_InteractFoliageActor_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_InteractFoliageActor_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InteractFoliageActor_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InteractFoliageActor_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021ACE RID: 137934 RVA: 0x008F2B50 File Offset: 0x008F0D50
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_InteractFoliageActor_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_InteractFoliageActor_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_InteractFoliageActor_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InteractFoliageActor_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_InteractFoliageActor_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06021ACF RID: 137935 RVA: 0x008F2B97 File Offset: 0x008F0D97
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void CustomTick()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InteractFoliageActor_C.__CustomTick_NativeFunctionPtr, null);
		}

		// Token: 0x06021AD0 RID: 137936 RVA: 0x008F2BAB File Offset: 0x008F0DAB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InteractFoliageActor_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06021AD1 RID: 137937 RVA: 0x008F2BBF File Offset: 0x008F0DBF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_InteractFoliageActor_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06021AD2 RID: 137938 RVA: 0x008F2BD4 File Offset: 0x008F0DD4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void CallChange(float Weight)
		{
			BP_InteractFoliageActor_C.__CallChange_FunctionParams* ptr = stackalloc BP_InteractFoliageActor_C.__CallChange_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_InteractFoliageActor_C.__CallChange_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InteractFoliageActor_C.__CallChange_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Weight = Weight;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InteractFoliageActor_C.__CallChange_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021AD3 RID: 137939 RVA: 0x008F2C1C File Offset: 0x008F0E1C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_InteractFoliageActor_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, in FHitResult SweepResult)
		{
			BP_InteractFoliageActor_C.__BndEvt__BP_InteractFoliageActor_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_InteractFoliageActor_C.__BndEvt__BP_InteractFoliageActor_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(BP_InteractFoliageActor_C.__BndEvt__BP_InteractFoliageActor_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InteractFoliageActor_C.__BndEvt__BP_InteractFoliageActor_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			ptr->bFromSweep = bFromSweep;
			if (SweepResult != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->SweepResult, SweepResult.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InteractFoliageActor_C.__BndEvt__BP_InteractFoliageActor_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021AD4 RID: 137940 RVA: 0x008F2CD8 File Offset: 0x008F0ED8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_InteractFoliageActor_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex)
		{
			BP_InteractFoliageActor_C.__BndEvt__BP_InteractFoliageActor_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_InteractFoliageActor_C.__BndEvt__BP_InteractFoliageActor_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_InteractFoliageActor_C.__BndEvt__BP_InteractFoliageActor_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InteractFoliageActor_C.__BndEvt__BP_InteractFoliageActor_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InteractFoliageActor_C.__BndEvt__BP_InteractFoliageActor_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021AD5 RID: 137941 RVA: 0x008F2D61 File Offset: 0x008F0F61
		protected BP_InteractFoliageActor_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040106BB RID: 67259
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/InteractFoliage/Blueprint/BP_InteractFoliageActor.BP_InteractFoliageActor_C";

		// Token: 0x040106BC RID: 67260
		private static IntPtr _ClassPtr;

		// Token: 0x040106BD RID: 67261
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040106BE RID: 67262
		internal static int __PropertyOffset_1;

		// Token: 0x040106BF RID: 67263
		internal static int __PropertyOffset_2;

		// Token: 0x040106C0 RID: 67264
		internal static int __PropertyOffset_3;

		// Token: 0x040106C1 RID: 67265
		internal static int __PropertyOffset_4;

		// Token: 0x040106C2 RID: 67266
		internal static int __PropertyOffset_5;

		// Token: 0x040106C3 RID: 67267
		internal static int __PropertyOffset_6;

		// Token: 0x040106C4 RID: 67268
		internal static int __PropertyOffset_7;

		// Token: 0x040106C5 RID: 67269
		internal static int __PropertyOffset_8;

		// Token: 0x040106C6 RID: 67270
		internal static int __PropertyOffset_9;

		// Token: 0x040106C7 RID: 67271
		private TArray<float> _Primitive_Data;

		// Token: 0x040106C8 RID: 67272
		internal static int __PropertyOffset_10;

		// Token: 0x040106C9 RID: 67273
		internal static int __PropertyOffset_11;

		// Token: 0x040106CA RID: 67274
		internal static int __PropertyOffset_12;

		// Token: 0x040106CB RID: 67275
		internal static int __PropertyOffset_13;

		// Token: 0x040106CC RID: 67276
		private static IntPtr __AdaptQualityLevel_NativeFunctionPtr;

		// Token: 0x040106CD RID: 67277
		private static IntPtr __ChangeActiveFoliageNum_NativeFunctionPtr;

		// Token: 0x040106CE RID: 67278
		private static IntPtr __InitialData_NativeFunctionPtr;

		// Token: 0x040106CF RID: 67279
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x040106D0 RID: 67280
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x040106D1 RID: 67281
		private static IntPtr __CustomTick_NativeFunctionPtr;

		// Token: 0x040106D2 RID: 67282
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x040106D3 RID: 67283
		private static IntPtr __CallChange_NativeFunctionPtr;

		// Token: 0x040106D4 RID: 67284
		private static IntPtr __BndEvt__BP_InteractFoliageActor_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x040106D5 RID: 67285
		private static IntPtr __BndEvt__BP_InteractFoliageActor_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x02009CB8 RID: 40120
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __AdaptQualityLevel_FunctionParams
		{
			// Token: 0x04031395 RID: 201621
			[FieldOffset(0)]
			public bool bShouldTick;
		}

		// Token: 0x02009CB9 RID: 40121
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __ChangeActiveFoliageNum_FunctionParams
		{
			// Token: 0x04031396 RID: 201622
			[FieldOffset(0)]
			public float ChangeNum;
		}

		// Token: 0x02009CBA RID: 40122
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031397 RID: 201623
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009CBB RID: 40123
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __CallChange_FunctionParams
		{
			// Token: 0x04031398 RID: 201624
			[FieldOffset(0)]
			public float Weight;
		}

		// Token: 0x02009CBC RID: 40124
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __BndEvt__BP_InteractFoliageActor_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x04031399 RID: 201625
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x0403139A RID: 201626
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x0403139B RID: 201627
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x0403139C RID: 201628
			[FieldOffset(24)]
			public int OtherBodyIndex;

			// Token: 0x0403139D RID: 201629
			[FieldOffset(28)]
			public bool bFromSweep;

			// Token: 0x0403139E RID: 201630
			[FieldOffset(32)]
			public byte SweepResult;
		}

		// Token: 0x02009CBD RID: 40125
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __BndEvt__BP_InteractFoliageActor_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x0403139F RID: 201631
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x040313A0 RID: 201632
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x040313A1 RID: 201633
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x040313A2 RID: 201634
			[FieldOffset(24)]
			public int OtherBodyIndex;
		}
	}
}

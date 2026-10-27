using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Character.BaseSeqCharacter;
using AkiClient.Game.Aki.Sequence.Interface;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Sequence.Seq_BP
{
	// Token: 0x02003A1C RID: 14876
	[UnrealObjectPath("/Game/Aki/Sequence/Seq_BP/BP_Mascot.BP_Mascot_C")]
	[UnrealStructLayout(1344, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1344)]
	public class BP_Mascot_C : AActor, IUnrealUObject, IUnrealObject, ISeqAnimDataInterface, IUnrealNativeInterface, IUnrealInterface, IABPC_Seq_MascotInterface_C, IUnrealBlueprintInterface, IBPI_SeqTalkActor_C
	{
		// Token: 0x0601F35B RID: 127835 RVA: 0x008B0480 File Offset: 0x008AE680
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_Mascot_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Sequence/Seq_BP/BP_Mascot.BP_Mascot_C");
			}
			return BP_Mascot_C._ClassPtr;
		}

		// Token: 0x0601F35C RID: 127836 RVA: 0x008B04A4 File Offset: 0x008AE6A4
		int ISeqAnimDataInterface.InterfaceOffset()
		{
			return BP_Mascot_C.__InterfaceOffset_ISeqAnimDataInterface;
		}

		// Token: 0x0601F35D RID: 127837 RVA: 0x008B04AC File Offset: 0x008AE6AC
		public BP_Mascot_C() : this(BuiltinUtils.AllocNativeUObject(BP_Mascot_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F35E RID: 127838 RVA: 0x008B04D4 File Offset: 0x008AE6D4
		[NullableContext(1)]
		public BP_Mascot_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_Mascot_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002A45 RID: 10821
		// (get) Token: 0x0601F35F RID: 127839 RVA: 0x008B0507 File Offset: 0x008AE707
		// (set) Token: 0x0601F360 RID: 127840 RVA: 0x008B051B File Offset: 0x008AE71B
		[Nullable(2)]
		public unsafe ABPC_Seq_Body_V2_C ABPC_Body_V2
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ABPC_Seq_Body_V2_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Mascot_C.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Mascot_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x17002A46 RID: 10822
		// (get) Token: 0x0601F361 RID: 127841 RVA: 0x008B0530 File Offset: 0x008AE730
		// (set) Token: 0x0601F362 RID: 127842 RVA: 0x008B0544 File Offset: 0x008AE744
		[Nullable(2)]
		public unsafe USkeletalMeshComponent SkeletalMesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Mascot_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Mascot_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17002A47 RID: 10823
		// (get) Token: 0x0601F363 RID: 127843 RVA: 0x008B0559 File Offset: 0x008AE759
		// (set) Token: 0x0601F364 RID: 127844 RVA: 0x008B056D File Offset: 0x008AE76D
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Mascot_C.__PropertyOffset_2);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Mascot_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17002A48 RID: 10824
		// (get) Token: 0x0601F365 RID: 127845 RVA: 0x008B0582 File Offset: 0x008AE782
		// (set) Token: 0x0601F366 RID: 127846 RVA: 0x008B0596 File Offset: 0x008AE796
		public unsafe FRotator Add_Spine
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Mascot_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Mascot_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17002A49 RID: 10825
		// (get) Token: 0x0601F367 RID: 127847 RVA: 0x008B05AB File Offset: 0x008AE7AB
		// (set) Token: 0x0601F368 RID: 127848 RVA: 0x008B05BF File Offset: 0x008AE7BF
		public unsafe FRotator Add_Spine_Head
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Mascot_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Mascot_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17002A4A RID: 10826
		// (get) Token: 0x0601F369 RID: 127849 RVA: 0x008B05D4 File Offset: 0x008AE7D4
		// (set) Token: 0x0601F36A RID: 127850 RVA: 0x008B05E8 File Offset: 0x008AE7E8
		[Nullable(2)]
		public unsafe USkeletalMesh Mesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMesh>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Mascot_C.__PropertyOffset_5);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Mascot_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17002A4B RID: 10827
		// (get) Token: 0x0601F36B RID: 127851 RVA: 0x008B0600 File Offset: 0x008AE800
		// (set) Token: 0x0601F36C RID: 127852 RVA: 0x008B0639 File Offset: 0x008AE839
		[Nullable(1)]
		public TArray<FNamedCurveValue> NamedCurves
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FNamedCurveValue> result;
				if ((result = this._NamedCurves) == null)
				{
					result = (this._NamedCurves = new TArray<FNamedCurveValue>(base.NativePtr + (IntPtr)BP_Mascot_C.__PropertyOffset_6, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.NamedCurves.CopyAssign(value);
			}
		}

		// Token: 0x17002A4C RID: 10828
		// (get) Token: 0x0601F36D RID: 127853 RVA: 0x008B0648 File Offset: 0x008AE848
		// (set) Token: 0x0601F36E RID: 127854 RVA: 0x008B0681 File Offset: 0x008AE881
		[Nullable(1)]
		public FKuroCurveFloat KuroFixCurve
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._KuroFixCurve) == null)
				{
					result = (this._KuroFixCurve = new FKuroCurveFloat(base.NativePtr + (IntPtr)BP_Mascot_C.__PropertyOffset_7, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)BP_Mascot_C.__PropertyOffset_7, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002A4D RID: 10829
		// (get) Token: 0x0601F36F RID: 127855 RVA: 0x008B06A2 File Offset: 0x008AE8A2
		// (set) Token: 0x0601F370 RID: 127856 RVA: 0x008B06B2 File Offset: 0x008AE8B2
		public unsafe int TalkID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Mascot_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Mascot_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17002A4E RID: 10830
		// (get) Token: 0x0601F371 RID: 127857 RVA: 0x008B06C3 File Offset: 0x008AE8C3
		// (set) Token: 0x0601F372 RID: 127858 RVA: 0x008B06D3 File Offset: 0x008AE8D3
		public unsafe int TalkID_SP
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Mascot_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Mascot_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17002A4F RID: 10831
		// (get) Token: 0x0601F373 RID: 127859 RVA: 0x008B06E4 File Offset: 0x008AE8E4
		// (set) Token: 0x0601F374 RID: 127860 RVA: 0x008B071D File Offset: 0x008AE91D
		[Nullable(1)]
		public TMap<FName, FTransform> Float_Curve_Data
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FTransform> result;
				if ((result = this._Float_Curve_Data) == null)
				{
					result = (this._Float_Curve_Data = new TMap<FName, FTransform>(base.NativePtr + (IntPtr)BP_Mascot_C.__PropertyOffset_10, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Float_Curve_Data.CopyAssign(value);
			}
		}

		// Token: 0x0601F375 RID: 127861 RVA: 0x008B072C File Offset: 0x008AE92C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetSeqTalkId(ref int TalkID, ref int TalkID_SP)
		{
			BP_Mascot_C.__GetSeqTalkId_FunctionParams* ptr = stackalloc BP_Mascot_C.__GetSeqTalkId_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_Mascot_C.__GetSeqTalkId_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Mascot_C.__GetSeqTalkId_NativeFunctionPtr, (void*)ptr, 1);
			ptr->TalkID = TalkID;
			ptr->TalkID_SP = TalkID_SP;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Mascot_C.__GetSeqTalkId_NativeFunctionPtr, (void*)ptr);
			TalkID = ptr->TalkID;
			TalkID_SP = ptr->TalkID_SP;
		}

		// Token: 0x0601F376 RID: 127862 RVA: 0x008B078C File Offset: 0x008AE98C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetSeqMouthAnimInstance(ref UAnimInstance AnimInstance)
		{
			BP_Mascot_C.__GetSeqMouthAnimInstance_FunctionParams* ptr = stackalloc BP_Mascot_C.__GetSeqMouthAnimInstance_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(BP_Mascot_C.__GetSeqMouthAnimInstance_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Mascot_C.__GetSeqMouthAnimInstance_NativeFunctionPtr, (void*)ptr, 1);
			ref BP_Mascot_C.__GetSeqMouthAnimInstance_FunctionParams ptr2 = ref *ptr;
			UAnimInstance uanimInstance = AnimInstance;
			ptr2.AnimInstance = ((uanimInstance != null) ? uanimInstance.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Mascot_C.__GetSeqMouthAnimInstance_NativeFunctionPtr, (void*)ptr);
			AnimInstance = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimInstance>(ptr->AnimInstance);
		}

		// Token: 0x0601F377 RID: 127863 RVA: 0x008B07F0 File Offset: 0x008AE9F0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetAddSpineHeadValue(ref FRotator AddSpineHead)
		{
			BP_Mascot_C.__GetAddSpineHeadValue_FunctionParams* ptr = stackalloc BP_Mascot_C.__GetAddSpineHeadValue_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_Mascot_C.__GetAddSpineHeadValue_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Mascot_C.__GetAddSpineHeadValue_NativeFunctionPtr, (void*)ptr, 1);
			ptr->AddSpineHead = AddSpineHead;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Mascot_C.__GetAddSpineHeadValue_NativeFunctionPtr, (void*)ptr);
			AddSpineHead = ptr->AddSpineHead;
		}

		// Token: 0x0601F378 RID: 127864 RVA: 0x008B0848 File Offset: 0x008AEA48
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetAddSpineValue(ref FRotator AddSpine)
		{
			BP_Mascot_C.__GetAddSpineValue_FunctionParams* ptr = stackalloc BP_Mascot_C.__GetAddSpineValue_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(BP_Mascot_C.__GetAddSpineValue_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Mascot_C.__GetAddSpineValue_NativeFunctionPtr, (void*)ptr, 1);
			ptr->AddSpine = AddSpine;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Mascot_C.__GetAddSpineValue_NativeFunctionPtr, (void*)ptr);
			AddSpine = ptr->AddSpine;
		}

		// Token: 0x0601F379 RID: 127865 RVA: 0x008B08A0 File Offset: 0x008AEAA0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual bool GetAnimDataTransform(ref TMap<FName, FTransform> FloatCurveData)
		{
			BP_Mascot_C.__GetAnimDataTransform_FunctionParams* ptr = stackalloc BP_Mascot_C.__GetAnimDataTransform_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(BP_Mascot_C.__GetAnimDataTransform_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Mascot_C.__GetAnimDataTransform_NativeFunctionPtr, (void*)ptr, 1);
			TMap<FName, FTransform> tmap = FloatCurveData;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->FloatCurveData);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Mascot_C.__GetAnimDataTransform_NativeFunctionPtr, (void*)ptr);
			TMap<FName, FTransform> tmap2 = FloatCurveData;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->FloatCurveData);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(BP_Mascot_C.__GetAnimDataTransform_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601F37A RID: 127866 RVA: 0x008B0920 File Offset: 0x008AEB20
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual bool GetAnimDataTransform_Implementation(ref TMap<FName, FTransform> FloatCurveData)
		{
			BP_Mascot_C.__GetAnimDataTransform_FunctionParams* ptr = stackalloc BP_Mascot_C.__GetAnimDataTransform_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(BP_Mascot_C.__GetAnimDataTransform_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Mascot_C.__GetAnimDataTransform_NativeFunctionPtr, (void*)ptr, 1);
			TMap<FName, FTransform> tmap = FloatCurveData;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->FloatCurveData);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Mascot_C.__GetAnimDataTransform_NativeFunctionPtr, (void*)ptr, 0);
			TMap<FName, FTransform> tmap2 = FloatCurveData;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->FloatCurveData);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(BP_Mascot_C.__GetAnimDataTransform_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601F37B RID: 127867 RVA: 0x008B09A0 File Offset: 0x008AEBA0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual bool IsCustomSupport()
		{
			BP_Mascot_C.__IsCustomSupport_FunctionParams* ptr = stackalloc BP_Mascot_C.__IsCustomSupport_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_Mascot_C.__IsCustomSupport_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Mascot_C.__IsCustomSupport_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Mascot_C.__IsCustomSupport_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0601F37C RID: 127868 RVA: 0x008B09E8 File Offset: 0x008AEBE8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual bool IsCustomSupport_Implementation()
		{
			BP_Mascot_C.__IsCustomSupport_FunctionParams* ptr = stackalloc BP_Mascot_C.__IsCustomSupport_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_Mascot_C.__IsCustomSupport_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Mascot_C.__IsCustomSupport_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Mascot_C.__IsCustomSupport_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601F37D RID: 127869 RVA: 0x008B0A30 File Offset: 0x008AEC30
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual bool SetAnimDataTransform(in TMap<FName, FTransform> FloatCurveData)
		{
			BP_Mascot_C.__SetAnimDataTransform_FunctionParams* ptr = stackalloc BP_Mascot_C.__SetAnimDataTransform_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(BP_Mascot_C.__SetAnimDataTransform_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Mascot_C.__SetAnimDataTransform_NativeFunctionPtr, (void*)ptr, 1);
			object obj = FloatCurveData;
			if (obj != null)
			{
				obj.MoveTo(&ptr->FloatCurveData);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Mascot_C.__SetAnimDataTransform_NativeFunctionPtr, (void*)ptr);
			object obj2 = FloatCurveData;
			if (obj2 != null)
			{
				obj2.MoveAssign(&ptr->FloatCurveData);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(BP_Mascot_C.__SetAnimDataTransform_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601F37E RID: 127870 RVA: 0x008B0AB0 File Offset: 0x008AECB0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual bool SetAnimDataTransform_Implementation(in TMap<FName, FTransform> FloatCurveData)
		{
			BP_Mascot_C.__SetAnimDataTransform_FunctionParams* ptr = stackalloc BP_Mascot_C.__SetAnimDataTransform_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(BP_Mascot_C.__SetAnimDataTransform_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Mascot_C.__SetAnimDataTransform_NativeFunctionPtr, (void*)ptr, 1);
			object obj = FloatCurveData;
			if (obj != null)
			{
				obj.MoveTo(&ptr->FloatCurveData);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Mascot_C.__SetAnimDataTransform_NativeFunctionPtr, (void*)ptr, 0);
			object obj2 = FloatCurveData;
			if (obj2 != null)
			{
				obj2.MoveAssign(&ptr->FloatCurveData);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(BP_Mascot_C.__SetAnimDataTransform_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601F37F RID: 127871 RVA: 0x008B0B30 File Offset: 0x008AED30
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual bool GetAnimDataFloat([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FNamedCurveValue> FloatCurveData)
		{
			BP_Mascot_C.__GetAnimDataFloat_FunctionParams* ptr = stackalloc BP_Mascot_C.__GetAnimDataFloat_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_Mascot_C.__GetAnimDataFloat_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Mascot_C.__GetAnimDataFloat_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FNamedCurveValue> tarray = FloatCurveData;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->FloatCurveData);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Mascot_C.__GetAnimDataFloat_NativeFunctionPtr, (void*)ptr);
			TArray<FNamedCurveValue> tarray2 = FloatCurveData;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->FloatCurveData);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(BP_Mascot_C.__GetAnimDataFloat_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601F380 RID: 127872 RVA: 0x008B0BB0 File Offset: 0x008AEDB0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual bool GetAnimDataFloat_Implementation([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FNamedCurveValue> FloatCurveData)
		{
			BP_Mascot_C.__GetAnimDataFloat_FunctionParams* ptr = stackalloc BP_Mascot_C.__GetAnimDataFloat_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_Mascot_C.__GetAnimDataFloat_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Mascot_C.__GetAnimDataFloat_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FNamedCurveValue> tarray = FloatCurveData;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->FloatCurveData);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Mascot_C.__GetAnimDataFloat_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FNamedCurveValue> tarray2 = FloatCurveData;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->FloatCurveData);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(BP_Mascot_C.__GetAnimDataFloat_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601F381 RID: 127873 RVA: 0x008B0C30 File Offset: 0x008AEE30
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual bool GetAnimDataVector(ref TMap<FName, FVector> VectorCurveData)
		{
			BP_Mascot_C.__GetAnimDataVector_FunctionParams* ptr = stackalloc BP_Mascot_C.__GetAnimDataVector_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(BP_Mascot_C.__GetAnimDataVector_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Mascot_C.__GetAnimDataVector_NativeFunctionPtr, (void*)ptr, 1);
			TMap<FName, FVector> tmap = VectorCurveData;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->VectorCurveData);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Mascot_C.__GetAnimDataVector_NativeFunctionPtr, (void*)ptr);
			TMap<FName, FVector> tmap2 = VectorCurveData;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->VectorCurveData);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(BP_Mascot_C.__GetAnimDataVector_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601F382 RID: 127874 RVA: 0x008B0CB0 File Offset: 0x008AEEB0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual bool GetAnimDataVector_Implementation(ref TMap<FName, FVector> VectorCurveData)
		{
			BP_Mascot_C.__GetAnimDataVector_FunctionParams* ptr = stackalloc BP_Mascot_C.__GetAnimDataVector_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(BP_Mascot_C.__GetAnimDataVector_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Mascot_C.__GetAnimDataVector_NativeFunctionPtr, (void*)ptr, 1);
			TMap<FName, FVector> tmap = VectorCurveData;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->VectorCurveData);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Mascot_C.__GetAnimDataVector_NativeFunctionPtr, (void*)ptr, 0);
			TMap<FName, FVector> tmap2 = VectorCurveData;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->VectorCurveData);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(BP_Mascot_C.__GetAnimDataVector_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601F383 RID: 127875 RVA: 0x008B0D30 File Offset: 0x008AEF30
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual TArray<FName> GetSupportGroupNames()
		{
			BP_Mascot_C.__GetSupportGroupNames_FunctionParams* ptr = stackalloc BP_Mascot_C.__GetSupportGroupNames_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_Mascot_C.__GetSupportGroupNames_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Mascot_C.__GetSupportGroupNames_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Mascot_C.__GetSupportGroupNames_NativeFunctionPtr, (void*)ptr);
			TArray<FName> result = new TArray<FName>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(BP_Mascot_C.__GetSupportGroupNames_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0601F384 RID: 127876 RVA: 0x008B0D90 File Offset: 0x008AEF90
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual TArray<FName> GetSupportGroupNames_Implementation()
		{
			BP_Mascot_C.__GetSupportGroupNames_FunctionParams* ptr = stackalloc BP_Mascot_C.__GetSupportGroupNames_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_Mascot_C.__GetSupportGroupNames_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Mascot_C.__GetSupportGroupNames_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Mascot_C.__GetSupportGroupNames_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FName> result = new TArray<FName>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(BP_Mascot_C.__GetSupportGroupNames_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0601F385 RID: 127877 RVA: 0x008B0DF0 File Offset: 0x008AEFF0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual bool SetAnimDataFloat([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FNamedCurveValue> FloatCurveData)
		{
			BP_Mascot_C.__SetAnimDataFloat_FunctionParams* ptr = stackalloc BP_Mascot_C.__SetAnimDataFloat_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(BP_Mascot_C.__SetAnimDataFloat_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Mascot_C.__SetAnimDataFloat_NativeFunctionPtr, (void*)ptr, 1);
			object obj = FloatCurveData;
			if (obj != null)
			{
				obj.MoveTo(&ptr->FloatCurveData);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Mascot_C.__SetAnimDataFloat_NativeFunctionPtr, (void*)ptr);
			object obj2 = FloatCurveData;
			if (obj2 != null)
			{
				obj2.MoveAssign(&ptr->FloatCurveData);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(BP_Mascot_C.__SetAnimDataFloat_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601F386 RID: 127878 RVA: 0x008B0E70 File Offset: 0x008AF070
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual bool SetAnimDataFloat_Implementation([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FNamedCurveValue> FloatCurveData)
		{
			BP_Mascot_C.__SetAnimDataFloat_FunctionParams* ptr = stackalloc BP_Mascot_C.__SetAnimDataFloat_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(BP_Mascot_C.__SetAnimDataFloat_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Mascot_C.__SetAnimDataFloat_NativeFunctionPtr, (void*)ptr, 1);
			object obj = FloatCurveData;
			if (obj != null)
			{
				obj.MoveTo(&ptr->FloatCurveData);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Mascot_C.__SetAnimDataFloat_NativeFunctionPtr, (void*)ptr, 0);
			object obj2 = FloatCurveData;
			if (obj2 != null)
			{
				obj2.MoveAssign(&ptr->FloatCurveData);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(BP_Mascot_C.__SetAnimDataFloat_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601F387 RID: 127879 RVA: 0x008B0EF0 File Offset: 0x008AF0F0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual bool SetAnimDataVector(in TMap<FName, FVector> VectorCurveData)
		{
			BP_Mascot_C.__SetAnimDataVector_FunctionParams* ptr = stackalloc BP_Mascot_C.__SetAnimDataVector_FunctionParams[(UIntPtr)207] + 15L / (long)sizeof(BP_Mascot_C.__SetAnimDataVector_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Mascot_C.__SetAnimDataVector_NativeFunctionPtr, (void*)ptr, 1);
			object obj = VectorCurveData;
			if (obj != null)
			{
				obj.MoveTo(&ptr->VectorCurveData);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Mascot_C.__SetAnimDataVector_NativeFunctionPtr, (void*)ptr);
			object obj2 = VectorCurveData;
			if (obj2 != null)
			{
				obj2.MoveAssign(&ptr->VectorCurveData);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(BP_Mascot_C.__SetAnimDataVector_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601F388 RID: 127880 RVA: 0x008B0F74 File Offset: 0x008AF174
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual bool SetAnimDataVector_Implementation(in TMap<FName, FVector> VectorCurveData)
		{
			BP_Mascot_C.__SetAnimDataVector_FunctionParams* ptr = stackalloc BP_Mascot_C.__SetAnimDataVector_FunctionParams[(UIntPtr)207] + 15L / (long)sizeof(BP_Mascot_C.__SetAnimDataVector_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Mascot_C.__SetAnimDataVector_NativeFunctionPtr, (void*)ptr, 1);
			object obj = VectorCurveData;
			if (obj != null)
			{
				obj.MoveTo(&ptr->VectorCurveData);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Mascot_C.__SetAnimDataVector_NativeFunctionPtr, (void*)ptr, 0);
			object obj2 = VectorCurveData;
			if (obj2 != null)
			{
				obj2.MoveAssign(&ptr->VectorCurveData);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(BP_Mascot_C.__SetAnimDataVector_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601F389 RID: 127881 RVA: 0x008B0FF8 File Offset: 0x008AF1F8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void CalcAllCurve_2([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FNamedCurveValue> Ret)
		{
			BP_Mascot_C.__CalcAllCurve_2_FunctionParams* ptr = stackalloc BP_Mascot_C.__CalcAllCurve_2_FunctionParams[(UIntPtr)263] + 15L / (long)sizeof(BP_Mascot_C.__CalcAllCurve_2_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Mascot_C.__CalcAllCurve_2_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FNamedCurveValue> tarray = Ret;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->Ret);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Mascot_C.__CalcAllCurve_2_NativeFunctionPtr, (void*)ptr);
			TArray<FNamedCurveValue> tarray2 = Ret;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->Ret);
			}
			UnrealReflectionUtils.DestroyStruct(BP_Mascot_C.__CalcAllCurve_2_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601F38A RID: 127882 RVA: 0x008B1074 File Offset: 0x008AF274
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void CalcAllCurve([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FNamedCurveValue> Ret)
		{
			BP_Mascot_C.__CalcAllCurve_FunctionParams* ptr = stackalloc BP_Mascot_C.__CalcAllCurve_FunctionParams[(UIntPtr)271] + 15L / (long)sizeof(BP_Mascot_C.__CalcAllCurve_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Mascot_C.__CalcAllCurve_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FNamedCurveValue> tarray = Ret;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->Ret);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Mascot_C.__CalcAllCurve_NativeFunctionPtr, (void*)ptr);
			TArray<FNamedCurveValue> tarray2 = Ret;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->Ret);
			}
			UnrealReflectionUtils.DestroyStruct(BP_Mascot_C.__CalcAllCurve_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601F38B RID: 127883 RVA: 0x008B10F0 File Offset: 0x008AF2F0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void HasFixCurve(FName CheckName, ref bool Ret, ref FName FixName)
		{
			BP_Mascot_C.__HasFixCurve_FunctionParams* ptr = stackalloc BP_Mascot_C.__HasFixCurve_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_Mascot_C.__HasFixCurve_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Mascot_C.__HasFixCurve_NativeFunctionPtr, (void*)ptr, 1);
			ptr->CheckName = CheckName;
			ptr->Ret = Ret;
			ptr->FixName = FixName;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Mascot_C.__HasFixCurve_NativeFunctionPtr, (void*)ptr);
			Ret = ptr->Ret;
			FixName = ptr->FixName;
		}

		// Token: 0x0601F38C RID: 127884 RVA: 0x008B1160 File Offset: 0x008AF360
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetFixValue(float inValue, ref float FixValue)
		{
			BP_Mascot_C.__GetFixValue_FunctionParams* ptr = stackalloc BP_Mascot_C.__GetFixValue_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_Mascot_C.__GetFixValue_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Mascot_C.__GetFixValue_NativeFunctionPtr, (void*)ptr, 1);
			ptr->inValue = inValue;
			ptr->FixValue = FixValue;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Mascot_C.__GetFixValue_NativeFunctionPtr, (void*)ptr);
			FixValue = ptr->FixValue;
		}

		// Token: 0x0601F38D RID: 127885 RVA: 0x008B11B6 File Offset: 0x008AF3B6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Mascot_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601F38E RID: 127886 RVA: 0x008B11CA File Offset: 0x008AF3CA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Mascot_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601F38F RID: 127887 RVA: 0x008B11DF File Offset: 0x008AF3DF
		protected BP_Mascot_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400EF58 RID: 61272
		internal static int __InterfaceOffset_ISeqAnimDataInterface;

		// Token: 0x0400EF59 RID: 61273
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Sequence/Seq_BP/BP_Mascot.BP_Mascot_C";

		// Token: 0x0400EF5A RID: 61274
		private static IntPtr _ClassPtr;

		// Token: 0x0400EF5B RID: 61275
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400EF5C RID: 61276
		internal static int __PropertyOffset_0;

		// Token: 0x0400EF5D RID: 61277
		internal static int __PropertyOffset_1;

		// Token: 0x0400EF5E RID: 61278
		internal static int __PropertyOffset_2;

		// Token: 0x0400EF5F RID: 61279
		internal static int __PropertyOffset_3;

		// Token: 0x0400EF60 RID: 61280
		internal static int __PropertyOffset_4;

		// Token: 0x0400EF61 RID: 61281
		internal static int __PropertyOffset_5;

		// Token: 0x0400EF62 RID: 61282
		internal static int __PropertyOffset_6;

		// Token: 0x0400EF63 RID: 61283
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FNamedCurveValue> _NamedCurves;

		// Token: 0x0400EF64 RID: 61284
		internal static int __PropertyOffset_7;

		// Token: 0x0400EF65 RID: 61285
		[Nullable(2)]
		private FKuroCurveFloat _KuroFixCurve;

		// Token: 0x0400EF66 RID: 61286
		internal static int __PropertyOffset_8;

		// Token: 0x0400EF67 RID: 61287
		internal static int __PropertyOffset_9;

		// Token: 0x0400EF68 RID: 61288
		internal static int __PropertyOffset_10;

		// Token: 0x0400EF69 RID: 61289
		[Nullable(2)]
		private TMap<FName, FTransform> _Float_Curve_Data;

		// Token: 0x0400EF6A RID: 61290
		private static IntPtr __GetSeqTalkId_NativeFunctionPtr;

		// Token: 0x0400EF6B RID: 61291
		private static IntPtr __GetSeqMouthAnimInstance_NativeFunctionPtr;

		// Token: 0x0400EF6C RID: 61292
		private static IntPtr __GetAddSpineHeadValue_NativeFunctionPtr;

		// Token: 0x0400EF6D RID: 61293
		private static IntPtr __GetAddSpineValue_NativeFunctionPtr;

		// Token: 0x0400EF6E RID: 61294
		private static IntPtr __GetAnimDataTransform_NativeFunctionPtr;

		// Token: 0x0400EF6F RID: 61295
		private static IntPtr __IsCustomSupport_NativeFunctionPtr;

		// Token: 0x0400EF70 RID: 61296
		private static IntPtr __SetAnimDataTransform_NativeFunctionPtr;

		// Token: 0x0400EF71 RID: 61297
		private static IntPtr __GetAnimDataFloat_NativeFunctionPtr;

		// Token: 0x0400EF72 RID: 61298
		private static IntPtr __GetAnimDataVector_NativeFunctionPtr;

		// Token: 0x0400EF73 RID: 61299
		private static IntPtr __GetSupportGroupNames_NativeFunctionPtr;

		// Token: 0x0400EF74 RID: 61300
		private static IntPtr __SetAnimDataFloat_NativeFunctionPtr;

		// Token: 0x0400EF75 RID: 61301
		private static IntPtr __SetAnimDataVector_NativeFunctionPtr;

		// Token: 0x0400EF76 RID: 61302
		private static IntPtr __CalcAllCurve_2_NativeFunctionPtr;

		// Token: 0x0400EF77 RID: 61303
		private static IntPtr __CalcAllCurve_NativeFunctionPtr;

		// Token: 0x0400EF78 RID: 61304
		private static IntPtr __HasFixCurve_NativeFunctionPtr;

		// Token: 0x0400EF79 RID: 61305
		private static IntPtr __GetFixValue_NativeFunctionPtr;

		// Token: 0x0400EF7A RID: 61306
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x02009A73 RID: 39539
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetSeqTalkId_FunctionParams
		{
			// Token: 0x04030FD6 RID: 200662
			[FieldOffset(0)]
			public int TalkID;

			// Token: 0x04030FD7 RID: 200663
			[FieldOffset(4)]
			public int TalkID_SP;
		}

		// Token: 0x02009A74 RID: 39540
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetSeqMouthAnimInstance_FunctionParams
		{
			// Token: 0x04030FD8 RID: 200664
			[FieldOffset(0)]
			public IntPtr AnimInstance;
		}

		// Token: 0x02009A75 RID: 39541
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __GetAddSpineHeadValue_FunctionParams
		{
			// Token: 0x04030FD9 RID: 200665
			[FieldOffset(0)]
			public FRotator AddSpineHead;
		}

		// Token: 0x02009A76 RID: 39542
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __GetAddSpineValue_FunctionParams
		{
			// Token: 0x04030FDA RID: 200666
			[FieldOffset(0)]
			public FRotator AddSpine;
		}

		// Token: 0x02009A77 RID: 39543
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 88)]
		protected ref struct __GetAnimDataTransform_FunctionParams
		{
			// Token: 0x04030FDB RID: 200667
			[FieldOffset(0)]
			public byte FloatCurveData;

			// Token: 0x04030FDC RID: 200668
			[FieldOffset(80)]
			public bool __Result;
		}

		// Token: 0x02009A78 RID: 39544
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsCustomSupport_FunctionParams
		{
			// Token: 0x04030FDD RID: 200669
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02009A79 RID: 39545
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 88)]
		protected ref struct __SetAnimDataTransform_FunctionParams
		{
			// Token: 0x04030FDE RID: 200670
			[FieldOffset(0)]
			public byte FloatCurveData;

			// Token: 0x04030FDF RID: 200671
			[FieldOffset(80)]
			public bool __Result;
		}

		// Token: 0x02009A7A RID: 39546
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __GetAnimDataFloat_FunctionParams
		{
			// Token: 0x04030FE0 RID: 200672
			[FieldOffset(0)]
			public byte FloatCurveData;

			// Token: 0x04030FE1 RID: 200673
			[FieldOffset(16)]
			public bool __Result;
		}

		// Token: 0x02009A7B RID: 39547
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 88)]
		protected ref struct __GetAnimDataVector_FunctionParams
		{
			// Token: 0x04030FE2 RID: 200674
			[FieldOffset(0)]
			public byte VectorCurveData;

			// Token: 0x04030FE3 RID: 200675
			[FieldOffset(80)]
			public bool __Result;
		}

		// Token: 0x02009A7C RID: 39548
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __GetSupportGroupNames_FunctionParams
		{
			// Token: 0x04030FE4 RID: 200676
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02009A7D RID: 39549
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __SetAnimDataFloat_FunctionParams
		{
			// Token: 0x04030FE5 RID: 200677
			[FieldOffset(0)]
			public byte FloatCurveData;

			// Token: 0x04030FE6 RID: 200678
			[FieldOffset(16)]
			public bool __Result;
		}

		// Token: 0x02009A7E RID: 39550
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 192)]
		protected ref struct __SetAnimDataVector_FunctionParams
		{
			// Token: 0x04030FE7 RID: 200679
			[FieldOffset(0)]
			public byte VectorCurveData;

			// Token: 0x04030FE8 RID: 200680
			[FieldOffset(80)]
			public bool __Result;
		}

		// Token: 0x02009A7F RID: 39551
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 248)]
		protected ref struct __CalcAllCurve_2_FunctionParams
		{
			// Token: 0x04030FE9 RID: 200681
			[FieldOffset(0)]
			public byte Ret;
		}

		// Token: 0x02009A80 RID: 39552
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 256)]
		protected ref struct __CalcAllCurve_FunctionParams
		{
			// Token: 0x04030FEA RID: 200682
			[FieldOffset(0)]
			public byte Ret;
		}

		// Token: 0x02009A81 RID: 39553
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __HasFixCurve_FunctionParams
		{
			// Token: 0x04030FEB RID: 200683
			[FieldOffset(0)]
			public FName CheckName;

			// Token: 0x04030FEC RID: 200684
			[FieldOffset(12)]
			public bool Ret;

			// Token: 0x04030FED RID: 200685
			[FieldOffset(16)]
			public FName FixName;
		}

		// Token: 0x02009A82 RID: 39554
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __GetFixValue_FunctionParams
		{
			// Token: 0x04030FEE RID: 200686
			[FieldOffset(0)]
			public float inValue;

			// Token: 0x04030FEF RID: 200687
			[FieldOffset(4)]
			public float FixValue;
		}
	}
}

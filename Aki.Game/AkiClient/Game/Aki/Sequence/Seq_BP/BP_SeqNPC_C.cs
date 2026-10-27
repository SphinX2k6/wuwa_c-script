using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Character.BaseSeqCharacter;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.Npc;
using AkiClient.Game.Aki.Sequence.Interface;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Sequence.Seq_BP
{
	// Token: 0x02003A1D RID: 14877
	[UnrealObjectPath("/Game/Aki/Sequence/Seq_BP/BP_SeqNPC.BP_SeqNPC_C")]
	[UnrealStructLayout(1952, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1952)]
	public class BP_SeqNPC_C : BP_NpcCombinedMesh_C, IUnrealUObject, IUnrealObject, ISeqAnimDataInterface, IUnrealNativeInterface, IUnrealInterface, IABPC_Seq_Interface_C, IUnrealBlueprintInterface, IBPI_SeqAudio_C, IBPI_SeqTalkActor_C
	{
		// Token: 0x0601F390 RID: 127888 RVA: 0x008B11E8 File Offset: 0x008AF3E8
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SeqNPC_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Sequence/Seq_BP/BP_SeqNPC.BP_SeqNPC_C");
			}
			return BP_SeqNPC_C._ClassPtr;
		}

		// Token: 0x0601F391 RID: 127889 RVA: 0x008B120C File Offset: 0x008AF40C
		int ISeqAnimDataInterface.InterfaceOffset()
		{
			return BP_SeqNPC_C.__InterfaceOffset_ISeqAnimDataInterface;
		}

		// Token: 0x0601F392 RID: 127890 RVA: 0x008B1214 File Offset: 0x008AF414
		public BP_SeqNPC_C() : this(BuiltinUtils.AllocNativeUObject(BP_SeqNPC_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F393 RID: 127891 RVA: 0x008B123C File Offset: 0x008AF43C
		[NullableContext(1)]
		public BP_SeqNPC_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SeqNPC_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002A50 RID: 10832
		// (get) Token: 0x0601F394 RID: 127892 RVA: 0x008B126F File Offset: 0x008AF46F
		// (set) Token: 0x0601F395 RID: 127893 RVA: 0x008B1283 File Offset: 0x008AF483
		[Nullable(2)]
		public unsafe SeqAudio_Seq_V2_C SeqAudio_Seq_V2
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<SeqAudio_Seq_V2_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeqNPC_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeqNPC_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17002A51 RID: 10833
		// (get) Token: 0x0601F396 RID: 127894 RVA: 0x008B1298 File Offset: 0x008AF498
		// (set) Token: 0x0601F397 RID: 127895 RVA: 0x008B12AC File Offset: 0x008AF4AC
		[Nullable(2)]
		public unsafe ABPC_Seq_Body_V2_C ABPC_Body_V2
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ABPC_Seq_Body_V2_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeqNPC_C.__PropertyOffset_2);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeqNPC_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17002A52 RID: 10834
		// (get) Token: 0x0601F398 RID: 127896 RVA: 0x008B12C1 File Offset: 0x008AF4C1
		// (set) Token: 0x0601F399 RID: 127897 RVA: 0x008B12D5 File Offset: 0x008AF4D5
		[Nullable(2)]
		public unsafe PD_NpcSetupData_C NPC_DA
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<PD_NpcSetupData_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeqNPC_C.__PropertyOffset_3);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeqNPC_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17002A53 RID: 10835
		// (get) Token: 0x0601F39A RID: 127898 RVA: 0x008B12EA File Offset: 0x008AF4EA
		// (set) Token: 0x0601F39B RID: 127899 RVA: 0x008B12FA File Offset: 0x008AF4FA
		public unsafe int MaxLod
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SeqNPC_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SeqNPC_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17002A54 RID: 10836
		// (get) Token: 0x0601F39C RID: 127900 RVA: 0x008B130B File Offset: 0x008AF50B
		// (set) Token: 0x0601F39D RID: 127901 RVA: 0x008B131B File Offset: 0x008AF51B
		public unsafe int LodBias
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SeqNPC_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SeqNPC_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17002A55 RID: 10837
		// (get) Token: 0x0601F39E RID: 127902 RVA: 0x008B132C File Offset: 0x008AF52C
		// (set) Token: 0x0601F39F RID: 127903 RVA: 0x008B133C File Offset: 0x008AF53C
		public unsafe bool IgnoreSockets
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SeqNPC_C.__PropertyOffset_6) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SeqNPC_C.__PropertyOffset_6) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002A56 RID: 10838
		// (get) Token: 0x0601F3A0 RID: 127904 RVA: 0x008B134D File Offset: 0x008AF54D
		// (set) Token: 0x0601F3A1 RID: 127905 RVA: 0x008B135D File Offset: 0x008AF55D
		public unsafe int TalkID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SeqNPC_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SeqNPC_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17002A57 RID: 10839
		// (get) Token: 0x0601F3A2 RID: 127906 RVA: 0x008B136E File Offset: 0x008AF56E
		// (set) Token: 0x0601F3A3 RID: 127907 RVA: 0x008B137E File Offset: 0x008AF57E
		public unsafe int TalkID_SP
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SeqNPC_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SeqNPC_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17002A58 RID: 10840
		// (get) Token: 0x0601F3A4 RID: 127908 RVA: 0x008B1390 File Offset: 0x008AF590
		// (set) Token: 0x0601F3A5 RID: 127909 RVA: 0x008B13C9 File Offset: 0x008AF5C9
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
					result = (this._Float_Curve_Data = new TMap<FName, FTransform>(base.NativePtr + (IntPtr)BP_SeqNPC_C.__PropertyOffset_9, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Float_Curve_Data.CopyAssign(value);
			}
		}

		// Token: 0x17002A59 RID: 10841
		// (get) Token: 0x0601F3A6 RID: 127910 RVA: 0x008B13D7 File Offset: 0x008AF5D7
		// (set) Token: 0x0601F3A7 RID: 127911 RVA: 0x008B13E7 File Offset: 0x008AF5E7
		public unsafe bool 开启阴影投射
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SeqNPC_C.__PropertyOffset_10) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SeqNPC_C.__PropertyOffset_10) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002A5A RID: 10842
		// (get) Token: 0x0601F3A8 RID: 127912 RVA: 0x008B13F8 File Offset: 0x008AF5F8
		// (set) Token: 0x0601F3A9 RID: 127913 RVA: 0x008B1408 File Offset: 0x008AF608
		public unsafe bool 开启阴影投射Cache
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SeqNPC_C.__PropertyOffset_11) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SeqNPC_C.__PropertyOffset_11) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002A5B RID: 10843
		// (get) Token: 0x0601F3AA RID: 127914 RVA: 0x008B141C File Offset: 0x008AF61C
		// (set) Token: 0x0601F3AB RID: 127915 RVA: 0x008B1455 File Offset: 0x008AF655
		[Nullable(1)]
		public TArray<UKuroNpcExtraDecorationConfig> NPC_Decoration
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UKuroNpcExtraDecorationConfig> result;
				if ((result = this._NPC_Decoration) == null)
				{
					result = (this._NPC_Decoration = new TArray<UKuroNpcExtraDecorationConfig>(base.NativePtr + (IntPtr)BP_SeqNPC_C.__PropertyOffset_12, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.NPC_Decoration.CopyAssign(value);
			}
		}

		// Token: 0x17002A5C RID: 10844
		// (get) Token: 0x0601F3AC RID: 127916 RVA: 0x008B1463 File Offset: 0x008AF663
		// (set) Token: 0x0601F3AD RID: 127917 RVA: 0x008B1473 File Offset: 0x008AF673
		public unsafe bool SetMobileCustomStencil
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SeqNPC_C.__PropertyOffset_13) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SeqNPC_C.__PropertyOffset_13) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002A5D RID: 10845
		// (get) Token: 0x0601F3AE RID: 127918 RVA: 0x008B1484 File Offset: 0x008AF684
		// (set) Token: 0x0601F3AF RID: 127919 RVA: 0x008B1494 File Offset: 0x008AF694
		public unsafe int StencilVal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SeqNPC_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SeqNPC_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x0601F3B0 RID: 127920 RVA: 0x008B14A8 File Offset: 0x008AF6A8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetSeqTalkId(ref int TalkID, ref int TalkID_SP)
		{
			BP_SeqNPC_C.__GetSeqTalkId_FunctionParams* ptr = stackalloc BP_SeqNPC_C.__GetSeqTalkId_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_SeqNPC_C.__GetSeqTalkId_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqNPC_C.__GetSeqTalkId_NativeFunctionPtr, (void*)ptr, 1);
			ptr->TalkID = TalkID;
			ptr->TalkID_SP = TalkID_SP;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SeqNPC_C.__GetSeqTalkId_NativeFunctionPtr, (void*)ptr);
			TalkID = ptr->TalkID;
			TalkID_SP = ptr->TalkID_SP;
		}

		// Token: 0x0601F3B1 RID: 127921 RVA: 0x008B1508 File Offset: 0x008AF708
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetSeqMouthAnimInstance(ref UAnimInstance AnimInstance)
		{
			BP_SeqNPC_C.__GetSeqMouthAnimInstance_FunctionParams* ptr = stackalloc BP_SeqNPC_C.__GetSeqMouthAnimInstance_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(BP_SeqNPC_C.__GetSeqMouthAnimInstance_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqNPC_C.__GetSeqMouthAnimInstance_NativeFunctionPtr, (void*)ptr, 1);
			ref BP_SeqNPC_C.__GetSeqMouthAnimInstance_FunctionParams ptr2 = ref *ptr;
			UAnimInstance uanimInstance = AnimInstance;
			ptr2.AnimInstance = ((uanimInstance != null) ? uanimInstance.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SeqNPC_C.__GetSeqMouthAnimInstance_NativeFunctionPtr, (void*)ptr);
			AnimInstance = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimInstance>(ptr->AnimInstance);
		}

		// Token: 0x0601F3B2 RID: 127922 RVA: 0x008B156C File Offset: 0x008AF76C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetSeqAudio(ref SeqAudio_Seq_V2_C SeqAudio)
		{
			BP_SeqNPC_C.__GetSeqAudio_FunctionParams* ptr = stackalloc BP_SeqNPC_C.__GetSeqAudio_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_SeqNPC_C.__GetSeqAudio_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqNPC_C.__GetSeqAudio_NativeFunctionPtr, (void*)ptr, 1);
			ref BP_SeqNPC_C.__GetSeqAudio_FunctionParams ptr2 = ref *ptr;
			SeqAudio_Seq_V2_C seqAudio_Seq_V2_C = SeqAudio;
			ptr2.SeqAudio = ((seqAudio_Seq_V2_C != null) ? seqAudio_Seq_V2_C.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SeqNPC_C.__GetSeqAudio_NativeFunctionPtr, (void*)ptr);
			SeqAudio = BuiltinUtils.GetOrCreateUObjectByNativePointer<SeqAudio_Seq_V2_C>(ptr->SeqAudio);
		}

		// Token: 0x0601F3B3 RID: 127923 RVA: 0x008B15D0 File Offset: 0x008AF7D0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetABPC_Body_V2(ref ABPC_Seq_Body_V2_C ABPC_Body_V2)
		{
			BP_SeqNPC_C.__GetABPC_Body_V2_FunctionParams* ptr = stackalloc BP_SeqNPC_C.__GetABPC_Body_V2_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_SeqNPC_C.__GetABPC_Body_V2_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqNPC_C.__GetABPC_Body_V2_NativeFunctionPtr, (void*)ptr, 1);
			ref BP_SeqNPC_C.__GetABPC_Body_V2_FunctionParams ptr2 = ref *ptr;
			ABPC_Seq_Body_V2_C abpc_Seq_Body_V2_C = ABPC_Body_V2;
			ptr2.ABPC_Body_V2 = ((abpc_Seq_Body_V2_C != null) ? abpc_Seq_Body_V2_C.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SeqNPC_C.__GetABPC_Body_V2_NativeFunctionPtr, (void*)ptr);
			ABPC_Body_V2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<ABPC_Seq_Body_V2_C>(ptr->ABPC_Body_V2);
		}

		// Token: 0x0601F3B4 RID: 127924 RVA: 0x008B1634 File Offset: 0x008AF834
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual bool GetAnimDataTransform(ref TMap<FName, FTransform> FloatCurveData)
		{
			BP_SeqNPC_C.__GetAnimDataTransform_FunctionParams* ptr = stackalloc BP_SeqNPC_C.__GetAnimDataTransform_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(BP_SeqNPC_C.__GetAnimDataTransform_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqNPC_C.__GetAnimDataTransform_NativeFunctionPtr, (void*)ptr, 1);
			TMap<FName, FTransform> tmap = FloatCurveData;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->FloatCurveData);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SeqNPC_C.__GetAnimDataTransform_NativeFunctionPtr, (void*)ptr);
			TMap<FName, FTransform> tmap2 = FloatCurveData;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->FloatCurveData);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(BP_SeqNPC_C.__GetAnimDataTransform_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601F3B5 RID: 127925 RVA: 0x008B16B4 File Offset: 0x008AF8B4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual bool GetAnimDataTransform_Implementation(ref TMap<FName, FTransform> FloatCurveData)
		{
			BP_SeqNPC_C.__GetAnimDataTransform_FunctionParams* ptr = stackalloc BP_SeqNPC_C.__GetAnimDataTransform_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(BP_SeqNPC_C.__GetAnimDataTransform_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqNPC_C.__GetAnimDataTransform_NativeFunctionPtr, (void*)ptr, 1);
			TMap<FName, FTransform> tmap = FloatCurveData;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->FloatCurveData);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SeqNPC_C.__GetAnimDataTransform_NativeFunctionPtr, (void*)ptr, 0);
			TMap<FName, FTransform> tmap2 = FloatCurveData;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->FloatCurveData);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(BP_SeqNPC_C.__GetAnimDataTransform_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601F3B6 RID: 127926 RVA: 0x008B1734 File Offset: 0x008AF934
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual bool IsCustomSupport()
		{
			BP_SeqNPC_C.__IsCustomSupport_FunctionParams* ptr = stackalloc BP_SeqNPC_C.__IsCustomSupport_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_SeqNPC_C.__IsCustomSupport_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqNPC_C.__IsCustomSupport_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SeqNPC_C.__IsCustomSupport_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0601F3B7 RID: 127927 RVA: 0x008B177C File Offset: 0x008AF97C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual bool IsCustomSupport_Implementation()
		{
			BP_SeqNPC_C.__IsCustomSupport_FunctionParams* ptr = stackalloc BP_SeqNPC_C.__IsCustomSupport_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_SeqNPC_C.__IsCustomSupport_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqNPC_C.__IsCustomSupport_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SeqNPC_C.__IsCustomSupport_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601F3B8 RID: 127928 RVA: 0x008B17C4 File Offset: 0x008AF9C4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual bool SetAnimDataTransform(in TMap<FName, FTransform> FloatCurveData)
		{
			BP_SeqNPC_C.__SetAnimDataTransform_FunctionParams* ptr = stackalloc BP_SeqNPC_C.__SetAnimDataTransform_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(BP_SeqNPC_C.__SetAnimDataTransform_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqNPC_C.__SetAnimDataTransform_NativeFunctionPtr, (void*)ptr, 1);
			object obj = FloatCurveData;
			if (obj != null)
			{
				obj.MoveTo(&ptr->FloatCurveData);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SeqNPC_C.__SetAnimDataTransform_NativeFunctionPtr, (void*)ptr);
			object obj2 = FloatCurveData;
			if (obj2 != null)
			{
				obj2.MoveAssign(&ptr->FloatCurveData);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(BP_SeqNPC_C.__SetAnimDataTransform_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601F3B9 RID: 127929 RVA: 0x008B1844 File Offset: 0x008AFA44
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual bool SetAnimDataTransform_Implementation(in TMap<FName, FTransform> FloatCurveData)
		{
			BP_SeqNPC_C.__SetAnimDataTransform_FunctionParams* ptr = stackalloc BP_SeqNPC_C.__SetAnimDataTransform_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(BP_SeqNPC_C.__SetAnimDataTransform_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqNPC_C.__SetAnimDataTransform_NativeFunctionPtr, (void*)ptr, 1);
			object obj = FloatCurveData;
			if (obj != null)
			{
				obj.MoveTo(&ptr->FloatCurveData);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SeqNPC_C.__SetAnimDataTransform_NativeFunctionPtr, (void*)ptr, 0);
			object obj2 = FloatCurveData;
			if (obj2 != null)
			{
				obj2.MoveAssign(&ptr->FloatCurveData);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(BP_SeqNPC_C.__SetAnimDataTransform_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601F3BA RID: 127930 RVA: 0x008B18C4 File Offset: 0x008AFAC4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual bool GetAnimDataFloat([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FNamedCurveValue> FloatCurveData)
		{
			BP_SeqNPC_C.__GetAnimDataFloat_FunctionParams* ptr = stackalloc BP_SeqNPC_C.__GetAnimDataFloat_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_SeqNPC_C.__GetAnimDataFloat_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqNPC_C.__GetAnimDataFloat_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FNamedCurveValue> tarray = FloatCurveData;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->FloatCurveData);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SeqNPC_C.__GetAnimDataFloat_NativeFunctionPtr, (void*)ptr);
			TArray<FNamedCurveValue> tarray2 = FloatCurveData;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->FloatCurveData);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(BP_SeqNPC_C.__GetAnimDataFloat_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601F3BB RID: 127931 RVA: 0x008B1944 File Offset: 0x008AFB44
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual bool GetAnimDataFloat_Implementation([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FNamedCurveValue> FloatCurveData)
		{
			BP_SeqNPC_C.__GetAnimDataFloat_FunctionParams* ptr = stackalloc BP_SeqNPC_C.__GetAnimDataFloat_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_SeqNPC_C.__GetAnimDataFloat_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqNPC_C.__GetAnimDataFloat_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FNamedCurveValue> tarray = FloatCurveData;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->FloatCurveData);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SeqNPC_C.__GetAnimDataFloat_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FNamedCurveValue> tarray2 = FloatCurveData;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->FloatCurveData);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(BP_SeqNPC_C.__GetAnimDataFloat_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601F3BC RID: 127932 RVA: 0x008B19C4 File Offset: 0x008AFBC4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual bool GetAnimDataVector(ref TMap<FName, FVector> VectorCurveData)
		{
			BP_SeqNPC_C.__GetAnimDataVector_FunctionParams* ptr = stackalloc BP_SeqNPC_C.__GetAnimDataVector_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(BP_SeqNPC_C.__GetAnimDataVector_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqNPC_C.__GetAnimDataVector_NativeFunctionPtr, (void*)ptr, 1);
			TMap<FName, FVector> tmap = VectorCurveData;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->VectorCurveData);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SeqNPC_C.__GetAnimDataVector_NativeFunctionPtr, (void*)ptr);
			TMap<FName, FVector> tmap2 = VectorCurveData;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->VectorCurveData);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(BP_SeqNPC_C.__GetAnimDataVector_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601F3BD RID: 127933 RVA: 0x008B1A44 File Offset: 0x008AFC44
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual bool GetAnimDataVector_Implementation(ref TMap<FName, FVector> VectorCurveData)
		{
			BP_SeqNPC_C.__GetAnimDataVector_FunctionParams* ptr = stackalloc BP_SeqNPC_C.__GetAnimDataVector_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(BP_SeqNPC_C.__GetAnimDataVector_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqNPC_C.__GetAnimDataVector_NativeFunctionPtr, (void*)ptr, 1);
			TMap<FName, FVector> tmap = VectorCurveData;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->VectorCurveData);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SeqNPC_C.__GetAnimDataVector_NativeFunctionPtr, (void*)ptr, 0);
			TMap<FName, FVector> tmap2 = VectorCurveData;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->VectorCurveData);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(BP_SeqNPC_C.__GetAnimDataVector_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601F3BE RID: 127934 RVA: 0x008B1AC4 File Offset: 0x008AFCC4
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual TArray<FName> GetSupportGroupNames()
		{
			BP_SeqNPC_C.__GetSupportGroupNames_FunctionParams* ptr = stackalloc BP_SeqNPC_C.__GetSupportGroupNames_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_SeqNPC_C.__GetSupportGroupNames_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqNPC_C.__GetSupportGroupNames_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SeqNPC_C.__GetSupportGroupNames_NativeFunctionPtr, (void*)ptr);
			TArray<FName> result = new TArray<FName>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(BP_SeqNPC_C.__GetSupportGroupNames_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0601F3BF RID: 127935 RVA: 0x008B1B24 File Offset: 0x008AFD24
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual TArray<FName> GetSupportGroupNames_Implementation()
		{
			BP_SeqNPC_C.__GetSupportGroupNames_FunctionParams* ptr = stackalloc BP_SeqNPC_C.__GetSupportGroupNames_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_SeqNPC_C.__GetSupportGroupNames_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqNPC_C.__GetSupportGroupNames_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SeqNPC_C.__GetSupportGroupNames_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FName> result = new TArray<FName>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(BP_SeqNPC_C.__GetSupportGroupNames_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0601F3C0 RID: 127936 RVA: 0x008B1B84 File Offset: 0x008AFD84
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual bool SetAnimDataFloat([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FNamedCurveValue> FloatCurveData)
		{
			BP_SeqNPC_C.__SetAnimDataFloat_FunctionParams* ptr = stackalloc BP_SeqNPC_C.__SetAnimDataFloat_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_SeqNPC_C.__SetAnimDataFloat_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqNPC_C.__SetAnimDataFloat_NativeFunctionPtr, (void*)ptr, 1);
			object obj = FloatCurveData;
			if (obj != null)
			{
				obj.MoveTo(&ptr->FloatCurveData);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SeqNPC_C.__SetAnimDataFloat_NativeFunctionPtr, (void*)ptr);
			object obj2 = FloatCurveData;
			if (obj2 != null)
			{
				obj2.MoveAssign(&ptr->FloatCurveData);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(BP_SeqNPC_C.__SetAnimDataFloat_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601F3C1 RID: 127937 RVA: 0x008B1C04 File Offset: 0x008AFE04
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual bool SetAnimDataFloat_Implementation([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FNamedCurveValue> FloatCurveData)
		{
			BP_SeqNPC_C.__SetAnimDataFloat_FunctionParams* ptr = stackalloc BP_SeqNPC_C.__SetAnimDataFloat_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_SeqNPC_C.__SetAnimDataFloat_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqNPC_C.__SetAnimDataFloat_NativeFunctionPtr, (void*)ptr, 1);
			object obj = FloatCurveData;
			if (obj != null)
			{
				obj.MoveTo(&ptr->FloatCurveData);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SeqNPC_C.__SetAnimDataFloat_NativeFunctionPtr, (void*)ptr, 0);
			object obj2 = FloatCurveData;
			if (obj2 != null)
			{
				obj2.MoveAssign(&ptr->FloatCurveData);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(BP_SeqNPC_C.__SetAnimDataFloat_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601F3C2 RID: 127938 RVA: 0x008B1C84 File Offset: 0x008AFE84
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual bool SetAnimDataVector(in TMap<FName, FVector> VectorCurveData)
		{
			BP_SeqNPC_C.__SetAnimDataVector_FunctionParams* ptr = stackalloc BP_SeqNPC_C.__SetAnimDataVector_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(BP_SeqNPC_C.__SetAnimDataVector_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqNPC_C.__SetAnimDataVector_NativeFunctionPtr, (void*)ptr, 1);
			object obj = VectorCurveData;
			if (obj != null)
			{
				obj.MoveTo(&ptr->VectorCurveData);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SeqNPC_C.__SetAnimDataVector_NativeFunctionPtr, (void*)ptr);
			object obj2 = VectorCurveData;
			if (obj2 != null)
			{
				obj2.MoveAssign(&ptr->VectorCurveData);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(BP_SeqNPC_C.__SetAnimDataVector_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601F3C3 RID: 127939 RVA: 0x008B1D04 File Offset: 0x008AFF04
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual bool SetAnimDataVector_Implementation(in TMap<FName, FVector> VectorCurveData)
		{
			BP_SeqNPC_C.__SetAnimDataVector_FunctionParams* ptr = stackalloc BP_SeqNPC_C.__SetAnimDataVector_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(BP_SeqNPC_C.__SetAnimDataVector_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqNPC_C.__SetAnimDataVector_NativeFunctionPtr, (void*)ptr, 1);
			object obj = VectorCurveData;
			if (obj != null)
			{
				obj.MoveTo(&ptr->VectorCurveData);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SeqNPC_C.__SetAnimDataVector_NativeFunctionPtr, (void*)ptr, 0);
			object obj2 = VectorCurveData;
			if (obj2 != null)
			{
				obj2.MoveAssign(&ptr->VectorCurveData);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(BP_SeqNPC_C.__SetAnimDataVector_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601F3C4 RID: 127940 RVA: 0x008B1D83 File Offset: 0x008AFF83
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateNpcByDa()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SeqNPC_C.__UpdateNpcByDa_NativeFunctionPtr, null);
		}

		// Token: 0x0601F3C5 RID: 127941 RVA: 0x008B1D97 File Offset: 0x008AFF97
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SeqNPC_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601F3C6 RID: 127942 RVA: 0x008B1DAB File Offset: 0x008AFFAB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SeqNPC_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601F3C7 RID: 127943 RVA: 0x008B1DC0 File Offset: 0x008AFFC0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_SeqNPC_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_SeqNPC_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SeqNPC_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqNPC_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SeqNPC_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601F3C8 RID: 127944 RVA: 0x008B1E08 File Offset: 0x008B0008
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_SeqNPC_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_SeqNPC_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SeqNPC_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqNPC_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SeqNPC_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601F3C9 RID: 127945 RVA: 0x008B1E50 File Offset: 0x008B0050
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_SeqNPC_C.__EditorTick_FunctionParams* ptr = stackalloc BP_SeqNPC_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SeqNPC_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqNPC_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SeqNPC_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601F3CA RID: 127946 RVA: 0x008B1E98 File Offset: 0x008B0098
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_SeqNPC_C.__EditorTick_FunctionParams* ptr = stackalloc BP_SeqNPC_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SeqNPC_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqNPC_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SeqNPC_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601F3CB RID: 127947 RVA: 0x008B1EDF File Offset: 0x008B00DF
		protected BP_SeqNPC_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400EF7B RID: 61307
		internal static int __InterfaceOffset_ISeqAnimDataInterface;

		// Token: 0x0400EF7C RID: 61308
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Sequence/Seq_BP/BP_SeqNPC.BP_SeqNPC_C";

		// Token: 0x0400EF7D RID: 61309
		private static IntPtr _ClassPtr;

		// Token: 0x0400EF7E RID: 61310
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400EF7F RID: 61311
		internal new static int __PropertyOffset_1;

		// Token: 0x0400EF80 RID: 61312
		internal new static int __PropertyOffset_2;

		// Token: 0x0400EF81 RID: 61313
		internal new static int __PropertyOffset_3;

		// Token: 0x0400EF82 RID: 61314
		internal new static int __PropertyOffset_4;

		// Token: 0x0400EF83 RID: 61315
		internal new static int __PropertyOffset_5;

		// Token: 0x0400EF84 RID: 61316
		internal new static int __PropertyOffset_6;

		// Token: 0x0400EF85 RID: 61317
		internal new static int __PropertyOffset_7;

		// Token: 0x0400EF86 RID: 61318
		internal new static int __PropertyOffset_8;

		// Token: 0x0400EF87 RID: 61319
		internal new static int __PropertyOffset_9;

		// Token: 0x0400EF88 RID: 61320
		[Nullable(2)]
		private TMap<FName, FTransform> _Float_Curve_Data;

		// Token: 0x0400EF89 RID: 61321
		internal new static int __PropertyOffset_10;

		// Token: 0x0400EF8A RID: 61322
		internal new static int __PropertyOffset_11;

		// Token: 0x0400EF8B RID: 61323
		internal new static int __PropertyOffset_12;

		// Token: 0x0400EF8C RID: 61324
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UKuroNpcExtraDecorationConfig> _NPC_Decoration;

		// Token: 0x0400EF8D RID: 61325
		internal new static int __PropertyOffset_13;

		// Token: 0x0400EF8E RID: 61326
		internal new static int __PropertyOffset_14;

		// Token: 0x0400EF8F RID: 61327
		private static IntPtr __GetSeqTalkId_NativeFunctionPtr;

		// Token: 0x0400EF90 RID: 61328
		private static IntPtr __GetSeqMouthAnimInstance_NativeFunctionPtr;

		// Token: 0x0400EF91 RID: 61329
		private static IntPtr __GetSeqAudio_NativeFunctionPtr;

		// Token: 0x0400EF92 RID: 61330
		private static IntPtr __GetABPC_Body_V2_NativeFunctionPtr;

		// Token: 0x0400EF93 RID: 61331
		private static IntPtr __GetAnimDataTransform_NativeFunctionPtr;

		// Token: 0x0400EF94 RID: 61332
		private static IntPtr __IsCustomSupport_NativeFunctionPtr;

		// Token: 0x0400EF95 RID: 61333
		private static IntPtr __SetAnimDataTransform_NativeFunctionPtr;

		// Token: 0x0400EF96 RID: 61334
		private static IntPtr __GetAnimDataFloat_NativeFunctionPtr;

		// Token: 0x0400EF97 RID: 61335
		private static IntPtr __GetAnimDataVector_NativeFunctionPtr;

		// Token: 0x0400EF98 RID: 61336
		private static IntPtr __GetSupportGroupNames_NativeFunctionPtr;

		// Token: 0x0400EF99 RID: 61337
		private static IntPtr __SetAnimDataFloat_NativeFunctionPtr;

		// Token: 0x0400EF9A RID: 61338
		private static IntPtr __SetAnimDataVector_NativeFunctionPtr;

		// Token: 0x0400EF9B RID: 61339
		private static IntPtr __UpdateNpcByDa_NativeFunctionPtr;

		// Token: 0x0400EF9C RID: 61340
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0400EF9D RID: 61341
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0400EF9E RID: 61342
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x02009A83 RID: 39555
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetSeqTalkId_FunctionParams
		{
			// Token: 0x04030FF0 RID: 200688
			[FieldOffset(0)]
			public int TalkID;

			// Token: 0x04030FF1 RID: 200689
			[FieldOffset(4)]
			public int TalkID_SP;
		}

		// Token: 0x02009A84 RID: 39556
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetSeqMouthAnimInstance_FunctionParams
		{
			// Token: 0x04030FF2 RID: 200690
			[FieldOffset(0)]
			public IntPtr AnimInstance;
		}

		// Token: 0x02009A85 RID: 39557
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetSeqAudio_FunctionParams
		{
			// Token: 0x04030FF3 RID: 200691
			[FieldOffset(0)]
			public IntPtr SeqAudio;
		}

		// Token: 0x02009A86 RID: 39558
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetABPC_Body_V2_FunctionParams
		{
			// Token: 0x04030FF4 RID: 200692
			[FieldOffset(0)]
			public IntPtr ABPC_Body_V2;
		}

		// Token: 0x02009A87 RID: 39559
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 88)]
		protected ref struct __GetAnimDataTransform_FunctionParams
		{
			// Token: 0x04030FF5 RID: 200693
			[FieldOffset(0)]
			public byte FloatCurveData;

			// Token: 0x04030FF6 RID: 200694
			[FieldOffset(80)]
			public bool __Result;
		}

		// Token: 0x02009A88 RID: 39560
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsCustomSupport_FunctionParams
		{
			// Token: 0x04030FF7 RID: 200695
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02009A89 RID: 39561
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 88)]
		protected ref struct __SetAnimDataTransform_FunctionParams
		{
			// Token: 0x04030FF8 RID: 200696
			[FieldOffset(0)]
			public byte FloatCurveData;

			// Token: 0x04030FF9 RID: 200697
			[FieldOffset(80)]
			public bool __Result;
		}

		// Token: 0x02009A8A RID: 39562
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __GetAnimDataFloat_FunctionParams
		{
			// Token: 0x04030FFA RID: 200698
			[FieldOffset(0)]
			public byte FloatCurveData;

			// Token: 0x04030FFB RID: 200699
			[FieldOffset(16)]
			public bool __Result;
		}

		// Token: 0x02009A8B RID: 39563
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 88)]
		protected ref struct __GetAnimDataVector_FunctionParams
		{
			// Token: 0x04030FFC RID: 200700
			[FieldOffset(0)]
			public byte VectorCurveData;

			// Token: 0x04030FFD RID: 200701
			[FieldOffset(80)]
			public bool __Result;
		}

		// Token: 0x02009A8C RID: 39564
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __GetSupportGroupNames_FunctionParams
		{
			// Token: 0x04030FFE RID: 200702
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02009A8D RID: 39565
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __SetAnimDataFloat_FunctionParams
		{
			// Token: 0x04030FFF RID: 200703
			[FieldOffset(0)]
			public byte FloatCurveData;

			// Token: 0x04031000 RID: 200704
			[FieldOffset(16)]
			public bool __Result;
		}

		// Token: 0x02009A8E RID: 39566
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 88)]
		protected ref struct __SetAnimDataVector_FunctionParams
		{
			// Token: 0x04031001 RID: 200705
			[FieldOffset(0)]
			public byte VectorCurveData;

			// Token: 0x04031002 RID: 200706
			[FieldOffset(80)]
			public bool __Result;
		}

		// Token: 0x02009A8F RID: 39567
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031003 RID: 200707
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009A90 RID: 39568
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x04031004 RID: 200708
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}

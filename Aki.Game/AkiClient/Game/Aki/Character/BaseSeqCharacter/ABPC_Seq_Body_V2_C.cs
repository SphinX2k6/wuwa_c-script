using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseSeqCharacter
{
	// Token: 0x0200426A RID: 17002
	[UnrealObjectPath("/Game/Aki/Character/BaseSeqCharacter/ABPC_Seq_Body_V2.ABPC_Seq_Body_V2_C")]
	[UnrealStructLayout(464, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 460)]
	public class ABPC_Seq_Body_V2_C : UActorComponent, IUnrealUObject, IUnrealObject, ICurveSourceInterface, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x0602C15C RID: 180572 RVA: 0x00A15185 File Offset: 0x00A13385
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABPC_Seq_Body_V2_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseSeqCharacter/ABPC_Seq_Body_V2.ABPC_Seq_Body_V2_C");
			}
			return ABPC_Seq_Body_V2_C._ClassPtr;
		}

		// Token: 0x0602C15D RID: 180573 RVA: 0x00A151A9 File Offset: 0x00A133A9
		int ICurveSourceInterface.InterfaceOffset()
		{
			return ABPC_Seq_Body_V2_C.__InterfaceOffset_ICurveSourceInterface;
		}

		// Token: 0x0602C15E RID: 180574 RVA: 0x00A151B0 File Offset: 0x00A133B0
		public ABPC_Seq_Body_V2_C() : this(BuiltinUtils.AllocNativeUObject(ABPC_Seq_Body_V2_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602C15F RID: 180575 RVA: 0x00A151D8 File Offset: 0x00A133D8
		[NullableContext(1)]
		public ABPC_Seq_Body_V2_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABPC_Seq_Body_V2_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006D84 RID: 28036
		// (get) Token: 0x0602C160 RID: 180576 RVA: 0x00A1520B File Offset: 0x00A1340B
		// (set) Token: 0x0602C161 RID: 180577 RVA: 0x00A1521B File Offset: 0x00A1341B
		public unsafe bool 启用物理模拟
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABPC_Seq_Body_V2_C.__PropertyOffset_0) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABPC_Seq_Body_V2_C.__PropertyOffset_0) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006D85 RID: 28037
		// (get) Token: 0x0602C162 RID: 180578 RVA: 0x00A1522C File Offset: 0x00A1342C
		// (set) Token: 0x0602C163 RID: 180579 RVA: 0x00A1523C File Offset: 0x00A1343C
		public unsafe float 物理模拟权重
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABPC_Seq_Body_V2_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABPC_Seq_Body_V2_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17006D86 RID: 28038
		// (get) Token: 0x0602C164 RID: 180580 RVA: 0x00A15250 File Offset: 0x00A13450
		// (set) Token: 0x0602C165 RID: 180581 RVA: 0x00A15289 File Offset: 0x00A13489
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
					result = (this._NamedCurves = new TArray<FNamedCurveValue>(base.NativePtr + (IntPtr)ABPC_Seq_Body_V2_C.__PropertyOffset_2, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.NamedCurves.CopyAssign(value);
			}
		}

		// Token: 0x17006D87 RID: 28039
		// (get) Token: 0x0602C166 RID: 180582 RVA: 0x00A15297 File Offset: 0x00A13497
		// (set) Token: 0x0602C167 RID: 180583 RVA: 0x00A152AB File Offset: 0x00A134AB
		public unsafe FRotator Add_LookAt
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABPC_Seq_Body_V2_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABPC_Seq_Body_V2_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17006D88 RID: 28040
		// (get) Token: 0x0602C168 RID: 180584 RVA: 0x00A152C0 File Offset: 0x00A134C0
		// (set) Token: 0x0602C169 RID: 180585 RVA: 0x00A152D4 File Offset: 0x00A134D4
		public unsafe FRotator Add_Bip001Head
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABPC_Seq_Body_V2_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABPC_Seq_Body_V2_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17006D89 RID: 28041
		// (get) Token: 0x0602C16A RID: 180586 RVA: 0x00A152E9 File Offset: 0x00A134E9
		// (set) Token: 0x0602C16B RID: 180587 RVA: 0x00A152FD File Offset: 0x00A134FD
		public unsafe FRotator Add_Bip001Neck
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABPC_Seq_Body_V2_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABPC_Seq_Body_V2_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17006D8A RID: 28042
		// (get) Token: 0x0602C16C RID: 180588 RVA: 0x00A15312 File Offset: 0x00A13512
		// (set) Token: 0x0602C16D RID: 180589 RVA: 0x00A15326 File Offset: 0x00A13526
		public unsafe FRotator Add_Bip001Spine2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABPC_Seq_Body_V2_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABPC_Seq_Body_V2_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17006D8B RID: 28043
		// (get) Token: 0x0602C16E RID: 180590 RVA: 0x00A1533B File Offset: 0x00A1353B
		// (set) Token: 0x0602C16F RID: 180591 RVA: 0x00A1534F File Offset: 0x00A1354F
		public unsafe FRotator Add_Bip001LClavicle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABPC_Seq_Body_V2_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABPC_Seq_Body_V2_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17006D8C RID: 28044
		// (get) Token: 0x0602C170 RID: 180592 RVA: 0x00A15364 File Offset: 0x00A13564
		// (set) Token: 0x0602C171 RID: 180593 RVA: 0x00A15378 File Offset: 0x00A13578
		public unsafe FRotator Add_Bip001LUpperArm
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABPC_Seq_Body_V2_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABPC_Seq_Body_V2_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17006D8D RID: 28045
		// (get) Token: 0x0602C172 RID: 180594 RVA: 0x00A1538D File Offset: 0x00A1358D
		// (set) Token: 0x0602C173 RID: 180595 RVA: 0x00A153A1 File Offset: 0x00A135A1
		public unsafe FRotator Add_Bip001LForearm
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABPC_Seq_Body_V2_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABPC_Seq_Body_V2_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17006D8E RID: 28046
		// (get) Token: 0x0602C174 RID: 180596 RVA: 0x00A153B6 File Offset: 0x00A135B6
		// (set) Token: 0x0602C175 RID: 180597 RVA: 0x00A153CA File Offset: 0x00A135CA
		public unsafe FRotator Add_Bip001RClavicle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABPC_Seq_Body_V2_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABPC_Seq_Body_V2_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17006D8F RID: 28047
		// (get) Token: 0x0602C176 RID: 180598 RVA: 0x00A153DF File Offset: 0x00A135DF
		// (set) Token: 0x0602C177 RID: 180599 RVA: 0x00A153F3 File Offset: 0x00A135F3
		public unsafe FRotator Add_Bip001RUpperArm
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABPC_Seq_Body_V2_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABPC_Seq_Body_V2_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17006D90 RID: 28048
		// (get) Token: 0x0602C178 RID: 180600 RVA: 0x00A15408 File Offset: 0x00A13608
		// (set) Token: 0x0602C179 RID: 180601 RVA: 0x00A1541C File Offset: 0x00A1361C
		public unsafe FRotator Add_Bip001RForearm
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABPC_Seq_Body_V2_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABPC_Seq_Body_V2_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17006D91 RID: 28049
		// (get) Token: 0x0602C17A RID: 180602 RVA: 0x00A15431 File Offset: 0x00A13631
		// (set) Token: 0x0602C17B RID: 180603 RVA: 0x00A15445 File Offset: 0x00A13645
		public unsafe FRotator Add_Bip001Spine1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABPC_Seq_Body_V2_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABPC_Seq_Body_V2_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17006D92 RID: 28050
		// (get) Token: 0x0602C17C RID: 180604 RVA: 0x00A1545A File Offset: 0x00A1365A
		// (set) Token: 0x0602C17D RID: 180605 RVA: 0x00A1546E File Offset: 0x00A1366E
		public unsafe FRotator Add_Bip001LHand
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABPC_Seq_Body_V2_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABPC_Seq_Body_V2_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17006D93 RID: 28051
		// (get) Token: 0x0602C17E RID: 180606 RVA: 0x00A15483 File Offset: 0x00A13683
		// (set) Token: 0x0602C17F RID: 180607 RVA: 0x00A15497 File Offset: 0x00A13697
		public unsafe FRotator Add_Bip001RHand
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABPC_Seq_Body_V2_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABPC_Seq_Body_V2_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17006D94 RID: 28052
		// (get) Token: 0x0602C180 RID: 180608 RVA: 0x00A154AC File Offset: 0x00A136AC
		// (set) Token: 0x0602C181 RID: 180609 RVA: 0x00A154BC File Offset: 0x00A136BC
		public unsafe float SeqLHandWeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABPC_Seq_Body_V2_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABPC_Seq_Body_V2_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x17006D95 RID: 28053
		// (get) Token: 0x0602C182 RID: 180610 RVA: 0x00A154CD File Offset: 0x00A136CD
		// (set) Token: 0x0602C183 RID: 180611 RVA: 0x00A154DD File Offset: 0x00A136DD
		public unsafe float SeqRHandWeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABPC_Seq_Body_V2_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABPC_Seq_Body_V2_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x17006D96 RID: 28054
		// (get) Token: 0x0602C184 RID: 180612 RVA: 0x00A154EE File Offset: 0x00A136EE
		// (set) Token: 0x0602C185 RID: 180613 RVA: 0x00A15502 File Offset: 0x00A13702
		public unsafe FRotator Add_Bip001LThigh
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABPC_Seq_Body_V2_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABPC_Seq_Body_V2_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x17006D97 RID: 28055
		// (get) Token: 0x0602C186 RID: 180614 RVA: 0x00A15517 File Offset: 0x00A13717
		// (set) Token: 0x0602C187 RID: 180615 RVA: 0x00A1552B File Offset: 0x00A1372B
		public unsafe FRotator Add_Bip001LCalf
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABPC_Seq_Body_V2_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABPC_Seq_Body_V2_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x17006D98 RID: 28056
		// (get) Token: 0x0602C188 RID: 180616 RVA: 0x00A15540 File Offset: 0x00A13740
		// (set) Token: 0x0602C189 RID: 180617 RVA: 0x00A15554 File Offset: 0x00A13754
		public unsafe FRotator Add_Bip001LFoot
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABPC_Seq_Body_V2_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABPC_Seq_Body_V2_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x17006D99 RID: 28057
		// (get) Token: 0x0602C18A RID: 180618 RVA: 0x00A15569 File Offset: 0x00A13769
		// (set) Token: 0x0602C18B RID: 180619 RVA: 0x00A1557D File Offset: 0x00A1377D
		public unsafe FRotator Add_Bip001RThigh
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABPC_Seq_Body_V2_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABPC_Seq_Body_V2_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x17006D9A RID: 28058
		// (get) Token: 0x0602C18C RID: 180620 RVA: 0x00A15592 File Offset: 0x00A13792
		// (set) Token: 0x0602C18D RID: 180621 RVA: 0x00A155A6 File Offset: 0x00A137A6
		public unsafe FRotator Add_Bip001RCalf
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABPC_Seq_Body_V2_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABPC_Seq_Body_V2_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x17006D9B RID: 28059
		// (get) Token: 0x0602C18E RID: 180622 RVA: 0x00A155BB File Offset: 0x00A137BB
		// (set) Token: 0x0602C18F RID: 180623 RVA: 0x00A155CF File Offset: 0x00A137CF
		public unsafe FRotator Add_Bip001RFoot
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABPC_Seq_Body_V2_C.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABPC_Seq_Body_V2_C.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x0602C190 RID: 180624 RVA: 0x00A155E4 File Offset: 0x00A137E4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual FName GetBindingName()
		{
			ABPC_Seq_Body_V2_C.__GetBindingName_FunctionParams* ptr = stackalloc ABPC_Seq_Body_V2_C.__GetBindingName_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(ABPC_Seq_Body_V2_C.__GetBindingName_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABPC_Seq_Body_V2_C.__GetBindingName_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABPC_Seq_Body_V2_C.__GetBindingName_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0602C191 RID: 180625 RVA: 0x00A1562C File Offset: 0x00A1382C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual FName GetBindingName_Implementation()
		{
			ABPC_Seq_Body_V2_C.__GetBindingName_FunctionParams* ptr = stackalloc ABPC_Seq_Body_V2_C.__GetBindingName_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(ABPC_Seq_Body_V2_C.__GetBindingName_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABPC_Seq_Body_V2_C.__GetBindingName_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABPC_Seq_Body_V2_C.__GetBindingName_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0602C192 RID: 180626 RVA: 0x00A15674 File Offset: 0x00A13874
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetCurves([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FNamedCurveValue> OutValues)
		{
			ABPC_Seq_Body_V2_C.__GetCurves_FunctionParams* ptr = stackalloc ABPC_Seq_Body_V2_C.__GetCurves_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(ABPC_Seq_Body_V2_C.__GetCurves_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABPC_Seq_Body_V2_C.__GetCurves_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FNamedCurveValue> tarray = OutValues;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutValues);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABPC_Seq_Body_V2_C.__GetCurves_NativeFunctionPtr, (void*)ptr);
			TArray<FNamedCurveValue> tarray2 = OutValues;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutValues);
			}
			UnrealReflectionUtils.DestroyStruct(ABPC_Seq_Body_V2_C.__GetCurves_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602C193 RID: 180627 RVA: 0x00A156EC File Offset: 0x00A138EC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void GetCurves_Implementation([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FNamedCurveValue> OutValues)
		{
			ABPC_Seq_Body_V2_C.__GetCurves_FunctionParams* ptr = stackalloc ABPC_Seq_Body_V2_C.__GetCurves_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(ABPC_Seq_Body_V2_C.__GetCurves_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABPC_Seq_Body_V2_C.__GetCurves_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FNamedCurveValue> tarray = OutValues;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutValues);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABPC_Seq_Body_V2_C.__GetCurves_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FNamedCurveValue> tarray2 = OutValues;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutValues);
			}
			UnrealReflectionUtils.DestroyStruct(ABPC_Seq_Body_V2_C.__GetCurves_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602C194 RID: 180628 RVA: 0x00A15768 File Offset: 0x00A13968
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual float GetCurveValue(FName CurveName)
		{
			ABPC_Seq_Body_V2_C.__GetCurveValue_FunctionParams* ptr = stackalloc ABPC_Seq_Body_V2_C.__GetCurveValue_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(ABPC_Seq_Body_V2_C.__GetCurveValue_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABPC_Seq_Body_V2_C.__GetCurveValue_NativeFunctionPtr, (void*)ptr, 1);
			ptr->CurveName = CurveName;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABPC_Seq_Body_V2_C.__GetCurveValue_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0602C195 RID: 180629 RVA: 0x00A157B4 File Offset: 0x00A139B4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual float GetCurveValue_Implementation(FName CurveName)
		{
			ABPC_Seq_Body_V2_C.__GetCurveValue_FunctionParams* ptr = stackalloc ABPC_Seq_Body_V2_C.__GetCurveValue_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(ABPC_Seq_Body_V2_C.__GetCurveValue_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABPC_Seq_Body_V2_C.__GetCurveValue_NativeFunctionPtr, (void*)ptr, 1);
			ptr->CurveName = CurveName;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABPC_Seq_Body_V2_C.__GetCurveValue_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0602C196 RID: 180630 RVA: 0x00A15804 File Offset: 0x00A13A04
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void ProcessEye(FVector EyeLookAt, float AngleScale)
		{
			ABPC_Seq_Body_V2_C.__ProcessEye_FunctionParams* ptr = stackalloc ABPC_Seq_Body_V2_C.__ProcessEye_FunctionParams[(UIntPtr)235] + 15L / (long)sizeof(ABPC_Seq_Body_V2_C.__ProcessEye_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABPC_Seq_Body_V2_C.__ProcessEye_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EyeLookAt = EyeLookAt;
			ptr->AngleScale = AngleScale;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABPC_Seq_Body_V2_C.__ProcessEye_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602C197 RID: 180631 RVA: 0x00A15854 File Offset: 0x00A13A54
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetAnimDataFloatByOwner([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FNamedCurveValue> InCurves)
		{
			ABPC_Seq_Body_V2_C.__SetAnimDataFloatByOwner_FunctionParams* ptr = stackalloc ABPC_Seq_Body_V2_C.__SetAnimDataFloatByOwner_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(ABPC_Seq_Body_V2_C.__SetAnimDataFloatByOwner_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABPC_Seq_Body_V2_C.__SetAnimDataFloatByOwner_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FNamedCurveValue> tarray = InCurves;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->InCurves);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABPC_Seq_Body_V2_C.__SetAnimDataFloatByOwner_NativeFunctionPtr, (void*)ptr);
			TArray<FNamedCurveValue> tarray2 = InCurves;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InCurves);
			}
			UnrealReflectionUtils.DestroyStruct(ABPC_Seq_Body_V2_C.__SetAnimDataFloatByOwner_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602C198 RID: 180632 RVA: 0x00A158CC File Offset: 0x00A13ACC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetAnimDataVectorByOwner(ref TMap<FName, FVector> VectorMap)
		{
			ABPC_Seq_Body_V2_C.__SetAnimDataVectorByOwner_FunctionParams* ptr = stackalloc ABPC_Seq_Body_V2_C.__SetAnimDataVectorByOwner_FunctionParams[(UIntPtr)1127] + 15L / (long)sizeof(ABPC_Seq_Body_V2_C.__SetAnimDataVectorByOwner_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABPC_Seq_Body_V2_C.__SetAnimDataVectorByOwner_NativeFunctionPtr, (void*)ptr, 1);
			TMap<FName, FVector> tmap = VectorMap;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->VectorMap);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABPC_Seq_Body_V2_C.__SetAnimDataVectorByOwner_NativeFunctionPtr, (void*)ptr);
			TMap<FName, FVector> tmap2 = VectorMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->VectorMap);
			}
			UnrealReflectionUtils.DestroyStruct(ABPC_Seq_Body_V2_C.__SetAnimDataVectorByOwner_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602C199 RID: 180633 RVA: 0x00A15947 File Offset: 0x00A13B47
		protected ABPC_Seq_Body_V2_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040170E9 RID: 94441
		internal static int __InterfaceOffset_ICurveSourceInterface;

		// Token: 0x040170EA RID: 94442
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseSeqCharacter/ABPC_Seq_Body_V2.ABPC_Seq_Body_V2_C";

		// Token: 0x040170EB RID: 94443
		private static IntPtr _ClassPtr;

		// Token: 0x040170EC RID: 94444
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040170ED RID: 94445
		internal static int __PropertyOffset_0;

		// Token: 0x040170EE RID: 94446
		internal static int __PropertyOffset_1;

		// Token: 0x040170EF RID: 94447
		internal static int __PropertyOffset_2;

		// Token: 0x040170F0 RID: 94448
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FNamedCurveValue> _NamedCurves;

		// Token: 0x040170F1 RID: 94449
		internal static int __PropertyOffset_3;

		// Token: 0x040170F2 RID: 94450
		internal static int __PropertyOffset_4;

		// Token: 0x040170F3 RID: 94451
		internal static int __PropertyOffset_5;

		// Token: 0x040170F4 RID: 94452
		internal static int __PropertyOffset_6;

		// Token: 0x040170F5 RID: 94453
		internal static int __PropertyOffset_7;

		// Token: 0x040170F6 RID: 94454
		internal static int __PropertyOffset_8;

		// Token: 0x040170F7 RID: 94455
		internal static int __PropertyOffset_9;

		// Token: 0x040170F8 RID: 94456
		internal static int __PropertyOffset_10;

		// Token: 0x040170F9 RID: 94457
		internal static int __PropertyOffset_11;

		// Token: 0x040170FA RID: 94458
		internal static int __PropertyOffset_12;

		// Token: 0x040170FB RID: 94459
		internal static int __PropertyOffset_13;

		// Token: 0x040170FC RID: 94460
		internal static int __PropertyOffset_14;

		// Token: 0x040170FD RID: 94461
		internal static int __PropertyOffset_15;

		// Token: 0x040170FE RID: 94462
		internal static int __PropertyOffset_16;

		// Token: 0x040170FF RID: 94463
		internal static int __PropertyOffset_17;

		// Token: 0x04017100 RID: 94464
		internal static int __PropertyOffset_18;

		// Token: 0x04017101 RID: 94465
		internal static int __PropertyOffset_19;

		// Token: 0x04017102 RID: 94466
		internal static int __PropertyOffset_20;

		// Token: 0x04017103 RID: 94467
		internal static int __PropertyOffset_21;

		// Token: 0x04017104 RID: 94468
		internal static int __PropertyOffset_22;

		// Token: 0x04017105 RID: 94469
		internal static int __PropertyOffset_23;

		// Token: 0x04017106 RID: 94470
		private static IntPtr __GetBindingName_NativeFunctionPtr;

		// Token: 0x04017107 RID: 94471
		private static IntPtr __GetCurves_NativeFunctionPtr;

		// Token: 0x04017108 RID: 94472
		private static IntPtr __GetCurveValue_NativeFunctionPtr;

		// Token: 0x04017109 RID: 94473
		private static IntPtr __ProcessEye_NativeFunctionPtr;

		// Token: 0x0401710A RID: 94474
		private static IntPtr __SetAnimDataFloatByOwner_NativeFunctionPtr;

		// Token: 0x0401710B RID: 94475
		private static IntPtr __SetAnimDataVectorByOwner_NativeFunctionPtr;

		// Token: 0x0200A623 RID: 42531
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __GetBindingName_FunctionParams
		{
			// Token: 0x0403250B RID: 206091
			[FieldOffset(0)]
			public FName __Result;
		}

		// Token: 0x0200A624 RID: 42532
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetCurves_FunctionParams
		{
			// Token: 0x0403250C RID: 206092
			[FieldOffset(0)]
			public byte OutValues;
		}

		// Token: 0x0200A625 RID: 42533
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetCurveValue_FunctionParams
		{
			// Token: 0x0403250D RID: 206093
			[FieldOffset(0)]
			public FName CurveName;

			// Token: 0x0403250E RID: 206094
			[FieldOffset(12)]
			public float __Result;
		}

		// Token: 0x0200A626 RID: 42534
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 220)]
		protected ref struct __ProcessEye_FunctionParams
		{
			// Token: 0x0403250F RID: 206095
			[FieldOffset(0)]
			public FVector EyeLookAt;

			// Token: 0x04032510 RID: 206096
			[FieldOffset(12)]
			public float AngleScale;
		}

		// Token: 0x0200A627 RID: 42535
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetAnimDataFloatByOwner_FunctionParams
		{
			// Token: 0x04032511 RID: 206097
			[FieldOffset(0)]
			public byte InCurves;
		}

		// Token: 0x0200A628 RID: 42536
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1112)]
		protected ref struct __SetAnimDataVectorByOwner_FunctionParams
		{
			// Token: 0x04032512 RID: 206098
			[FieldOffset(0)]
			public byte VectorMap;
		}
	}
}

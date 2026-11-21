using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseSeqCharacter
{
	// Token: 0x020032D9 RID: 13017
	[UnrealObjectPath("/Game/Aki/Character/BaseSeqCharacter/ABPC_Seq_Body_V2.ABPC_Seq_Body_V2_C")]
	[UnrealStructLayout(464, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 460)]
	public class ABPC_Seq_Body_V2_C : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021012 RID: 135186 RVA: 0x009561D8 File Offset: 0x009543D8
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABPC_Seq_Body_V2_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseSeqCharacter/ABPC_Seq_Body_V2.ABPC_Seq_Body_V2_C");
			}
			return ABPC_Seq_Body_V2_C._ClassPtr;
		}

		// Token: 0x06021013 RID: 135187 RVA: 0x009561FC File Offset: 0x009543FC
		public ABPC_Seq_Body_V2_C() : this(BuiltinUtils.AllocNativeUObject(ABPC_Seq_Body_V2_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021014 RID: 135188 RVA: 0x00956224 File Offset: 0x00954424
		[NullableContext(1)]
		public ABPC_Seq_Body_V2_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABPC_Seq_Body_V2_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004207 RID: 16903
		// (get) Token: 0x06021015 RID: 135189 RVA: 0x00956257 File Offset: 0x00954457
		// (set) Token: 0x06021016 RID: 135190 RVA: 0x00956267 File Offset: 0x00954467
		public unsafe bool 启用物理模拟
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABPC_Seq_Body_V2_C.__PropertyOffset_启用物理模拟) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABPC_Seq_Body_V2_C.__PropertyOffset_启用物理模拟) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004208 RID: 16904
		// (get) Token: 0x06021017 RID: 135191 RVA: 0x00956278 File Offset: 0x00954478
		// (set) Token: 0x06021018 RID: 135192 RVA: 0x00956288 File Offset: 0x00954488
		public unsafe float 物理模拟权重
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABPC_Seq_Body_V2_C.__PropertyOffset_物理模拟权重);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABPC_Seq_Body_V2_C.__PropertyOffset_物理模拟权重) = value;
			}
		}

		// Token: 0x17004209 RID: 16905
		// (get) Token: 0x06021019 RID: 135193 RVA: 0x00956299 File Offset: 0x00954499
		// (set) Token: 0x0602101A RID: 135194 RVA: 0x009562AD File Offset: 0x009544AD
		public unsafe FRotator Add_LookAt
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABPC_Seq_Body_V2_C.__PropertyOffset_Add_LookAt);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABPC_Seq_Body_V2_C.__PropertyOffset_Add_LookAt) = value;
			}
		}

		// Token: 0x1700420A RID: 16906
		// (get) Token: 0x0602101B RID: 135195 RVA: 0x009562C2 File Offset: 0x009544C2
		// (set) Token: 0x0602101C RID: 135196 RVA: 0x009562D6 File Offset: 0x009544D6
		public unsafe FRotator Add_Bip001Head
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABPC_Seq_Body_V2_C.__PropertyOffset_Add_Bip001Head);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABPC_Seq_Body_V2_C.__PropertyOffset_Add_Bip001Head) = value;
			}
		}

		// Token: 0x1700420B RID: 16907
		// (get) Token: 0x0602101D RID: 135197 RVA: 0x009562EB File Offset: 0x009544EB
		// (set) Token: 0x0602101E RID: 135198 RVA: 0x009562FF File Offset: 0x009544FF
		public unsafe FRotator Add_Bip001Neck
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABPC_Seq_Body_V2_C.__PropertyOffset_Add_Bip001Neck);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABPC_Seq_Body_V2_C.__PropertyOffset_Add_Bip001Neck) = value;
			}
		}

		// Token: 0x1700420C RID: 16908
		// (get) Token: 0x0602101F RID: 135199 RVA: 0x00956314 File Offset: 0x00954514
		// (set) Token: 0x06021020 RID: 135200 RVA: 0x00956328 File Offset: 0x00954528
		public unsafe FRotator Add_Bip001Spine2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABPC_Seq_Body_V2_C.__PropertyOffset_Add_Bip001Spine2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABPC_Seq_Body_V2_C.__PropertyOffset_Add_Bip001Spine2) = value;
			}
		}

		// Token: 0x1700420D RID: 16909
		// (get) Token: 0x06021021 RID: 135201 RVA: 0x0095633D File Offset: 0x0095453D
		// (set) Token: 0x06021022 RID: 135202 RVA: 0x00956351 File Offset: 0x00954551
		public unsafe FRotator Add_Bip001LClavicle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABPC_Seq_Body_V2_C.__PropertyOffset_Add_Bip001LClavicle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABPC_Seq_Body_V2_C.__PropertyOffset_Add_Bip001LClavicle) = value;
			}
		}

		// Token: 0x1700420E RID: 16910
		// (get) Token: 0x06021023 RID: 135203 RVA: 0x00956366 File Offset: 0x00954566
		// (set) Token: 0x06021024 RID: 135204 RVA: 0x0095637A File Offset: 0x0095457A
		public unsafe FRotator Add_Bip001LUpperArm
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABPC_Seq_Body_V2_C.__PropertyOffset_Add_Bip001LUpperArm);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABPC_Seq_Body_V2_C.__PropertyOffset_Add_Bip001LUpperArm) = value;
			}
		}

		// Token: 0x1700420F RID: 16911
		// (get) Token: 0x06021025 RID: 135205 RVA: 0x0095638F File Offset: 0x0095458F
		// (set) Token: 0x06021026 RID: 135206 RVA: 0x009563A3 File Offset: 0x009545A3
		public unsafe FRotator Add_Bip001LForearm
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABPC_Seq_Body_V2_C.__PropertyOffset_Add_Bip001LForearm);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABPC_Seq_Body_V2_C.__PropertyOffset_Add_Bip001LForearm) = value;
			}
		}

		// Token: 0x17004210 RID: 16912
		// (get) Token: 0x06021027 RID: 135207 RVA: 0x009563B8 File Offset: 0x009545B8
		// (set) Token: 0x06021028 RID: 135208 RVA: 0x009563CC File Offset: 0x009545CC
		public unsafe FRotator Add_Bip001RClavicle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABPC_Seq_Body_V2_C.__PropertyOffset_Add_Bip001RClavicle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABPC_Seq_Body_V2_C.__PropertyOffset_Add_Bip001RClavicle) = value;
			}
		}

		// Token: 0x17004211 RID: 16913
		// (get) Token: 0x06021029 RID: 135209 RVA: 0x009563E1 File Offset: 0x009545E1
		// (set) Token: 0x0602102A RID: 135210 RVA: 0x009563F5 File Offset: 0x009545F5
		public unsafe FRotator Add_Bip001RUpperArm
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABPC_Seq_Body_V2_C.__PropertyOffset_Add_Bip001RUpperArm);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABPC_Seq_Body_V2_C.__PropertyOffset_Add_Bip001RUpperArm) = value;
			}
		}

		// Token: 0x17004212 RID: 16914
		// (get) Token: 0x0602102B RID: 135211 RVA: 0x0095640A File Offset: 0x0095460A
		// (set) Token: 0x0602102C RID: 135212 RVA: 0x0095641E File Offset: 0x0095461E
		public unsafe FRotator Add_Bip001RForearm
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABPC_Seq_Body_V2_C.__PropertyOffset_Add_Bip001RForearm);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABPC_Seq_Body_V2_C.__PropertyOffset_Add_Bip001RForearm) = value;
			}
		}

		// Token: 0x17004213 RID: 16915
		// (get) Token: 0x0602102D RID: 135213 RVA: 0x00956433 File Offset: 0x00954633
		// (set) Token: 0x0602102E RID: 135214 RVA: 0x00956447 File Offset: 0x00954647
		public unsafe FRotator Add_Bip001Spine1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABPC_Seq_Body_V2_C.__PropertyOffset_Add_Bip001Spine1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABPC_Seq_Body_V2_C.__PropertyOffset_Add_Bip001Spine1) = value;
			}
		}

		// Token: 0x17004214 RID: 16916
		// (get) Token: 0x0602102F RID: 135215 RVA: 0x0095645C File Offset: 0x0095465C
		// (set) Token: 0x06021030 RID: 135216 RVA: 0x00956470 File Offset: 0x00954670
		public unsafe FRotator Add_Bip001LHand
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABPC_Seq_Body_V2_C.__PropertyOffset_Add_Bip001LHand);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABPC_Seq_Body_V2_C.__PropertyOffset_Add_Bip001LHand) = value;
			}
		}

		// Token: 0x17004215 RID: 16917
		// (get) Token: 0x06021031 RID: 135217 RVA: 0x00956485 File Offset: 0x00954685
		// (set) Token: 0x06021032 RID: 135218 RVA: 0x00956499 File Offset: 0x00954699
		public unsafe FRotator Add_Bip001RHand
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABPC_Seq_Body_V2_C.__PropertyOffset_Add_Bip001RHand);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABPC_Seq_Body_V2_C.__PropertyOffset_Add_Bip001RHand) = value;
			}
		}

		// Token: 0x17004216 RID: 16918
		// (get) Token: 0x06021033 RID: 135219 RVA: 0x009564AE File Offset: 0x009546AE
		// (set) Token: 0x06021034 RID: 135220 RVA: 0x009564BE File Offset: 0x009546BE
		public unsafe float SeqLHandWeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABPC_Seq_Body_V2_C.__PropertyOffset_SeqLHandWeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABPC_Seq_Body_V2_C.__PropertyOffset_SeqLHandWeight) = value;
			}
		}

		// Token: 0x17004217 RID: 16919
		// (get) Token: 0x06021035 RID: 135221 RVA: 0x009564CF File Offset: 0x009546CF
		// (set) Token: 0x06021036 RID: 135222 RVA: 0x009564DF File Offset: 0x009546DF
		public unsafe float SeqRHandWeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABPC_Seq_Body_V2_C.__PropertyOffset_SeqRHandWeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABPC_Seq_Body_V2_C.__PropertyOffset_SeqRHandWeight) = value;
			}
		}

		// Token: 0x17004218 RID: 16920
		// (get) Token: 0x06021037 RID: 135223 RVA: 0x009564F0 File Offset: 0x009546F0
		// (set) Token: 0x06021038 RID: 135224 RVA: 0x00956504 File Offset: 0x00954704
		public unsafe FRotator Add_Bip001LThigh
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABPC_Seq_Body_V2_C.__PropertyOffset_Add_Bip001LThigh);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABPC_Seq_Body_V2_C.__PropertyOffset_Add_Bip001LThigh) = value;
			}
		}

		// Token: 0x17004219 RID: 16921
		// (get) Token: 0x06021039 RID: 135225 RVA: 0x00956519 File Offset: 0x00954719
		// (set) Token: 0x0602103A RID: 135226 RVA: 0x0095652D File Offset: 0x0095472D
		public unsafe FRotator Add_Bip001LCalf
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABPC_Seq_Body_V2_C.__PropertyOffset_Add_Bip001LCalf);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABPC_Seq_Body_V2_C.__PropertyOffset_Add_Bip001LCalf) = value;
			}
		}

		// Token: 0x1700421A RID: 16922
		// (get) Token: 0x0602103B RID: 135227 RVA: 0x00956542 File Offset: 0x00954742
		// (set) Token: 0x0602103C RID: 135228 RVA: 0x00956556 File Offset: 0x00954756
		public unsafe FRotator Add_Bip001LFoot
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABPC_Seq_Body_V2_C.__PropertyOffset_Add_Bip001LFoot);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABPC_Seq_Body_V2_C.__PropertyOffset_Add_Bip001LFoot) = value;
			}
		}

		// Token: 0x1700421B RID: 16923
		// (get) Token: 0x0602103D RID: 135229 RVA: 0x0095656B File Offset: 0x0095476B
		// (set) Token: 0x0602103E RID: 135230 RVA: 0x0095657F File Offset: 0x0095477F
		public unsafe FRotator Add_Bip001RThigh
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABPC_Seq_Body_V2_C.__PropertyOffset_Add_Bip001RThigh);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABPC_Seq_Body_V2_C.__PropertyOffset_Add_Bip001RThigh) = value;
			}
		}

		// Token: 0x1700421C RID: 16924
		// (get) Token: 0x0602103F RID: 135231 RVA: 0x00956594 File Offset: 0x00954794
		// (set) Token: 0x06021040 RID: 135232 RVA: 0x009565A8 File Offset: 0x009547A8
		public unsafe FRotator Add_Bip001RCalf
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABPC_Seq_Body_V2_C.__PropertyOffset_Add_Bip001RCalf);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABPC_Seq_Body_V2_C.__PropertyOffset_Add_Bip001RCalf) = value;
			}
		}

		// Token: 0x1700421D RID: 16925
		// (get) Token: 0x06021041 RID: 135233 RVA: 0x009565BD File Offset: 0x009547BD
		// (set) Token: 0x06021042 RID: 135234 RVA: 0x009565D1 File Offset: 0x009547D1
		public unsafe FRotator Add_Bip001RFoot
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABPC_Seq_Body_V2_C.__PropertyOffset_Add_Bip001RFoot);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABPC_Seq_Body_V2_C.__PropertyOffset_Add_Bip001RFoot) = value;
			}
		}

		// Token: 0x06021043 RID: 135235 RVA: 0x009565E8 File Offset: 0x009547E8
		[SkipLocalsInit]
		public unsafe virtual FName GetBindingName()
		{
			ABPC_Seq_Body_V2_C.__GetBindingName_FunctionParams* ptr = stackalloc ABPC_Seq_Body_V2_C.__GetBindingName_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(ABPC_Seq_Body_V2_C.__GetBindingName_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABPC_Seq_Body_V2_C.__GetBindingName_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABPC_Seq_Body_V2_C.__GetBindingName_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06021044 RID: 135236 RVA: 0x00956630 File Offset: 0x00954830
		[SkipLocalsInit]
		protected unsafe virtual FName GetBindingName_Implementation()
		{
			ABPC_Seq_Body_V2_C.__GetBindingName_FunctionParams* ptr = stackalloc ABPC_Seq_Body_V2_C.__GetBindingName_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(ABPC_Seq_Body_V2_C.__GetBindingName_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABPC_Seq_Body_V2_C.__GetBindingName_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABPC_Seq_Body_V2_C.__GetBindingName_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06021045 RID: 135237 RVA: 0x00956678 File Offset: 0x00954878
		[SkipLocalsInit]
		public unsafe virtual float GetCurveValue(FName CurveName)
		{
			ABPC_Seq_Body_V2_C.__GetCurveValue_FunctionParams* ptr = stackalloc ABPC_Seq_Body_V2_C.__GetCurveValue_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(ABPC_Seq_Body_V2_C.__GetCurveValue_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABPC_Seq_Body_V2_C.__GetCurveValue_NativeFunctionPtr, (void*)ptr, 1);
			ptr->CurveName = CurveName;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABPC_Seq_Body_V2_C.__GetCurveValue_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06021046 RID: 135238 RVA: 0x009566C4 File Offset: 0x009548C4
		[SkipLocalsInit]
		protected unsafe virtual float GetCurveValue_Implementation(FName CurveName)
		{
			ABPC_Seq_Body_V2_C.__GetCurveValue_FunctionParams* ptr = stackalloc ABPC_Seq_Body_V2_C.__GetCurveValue_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(ABPC_Seq_Body_V2_C.__GetCurveValue_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABPC_Seq_Body_V2_C.__GetCurveValue_NativeFunctionPtr, (void*)ptr, 1);
			ptr->CurveName = CurveName;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABPC_Seq_Body_V2_C.__GetCurveValue_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06021047 RID: 135239 RVA: 0x00956710 File Offset: 0x00954910
		[SkipLocalsInit]
		public unsafe virtual void ProcessEye(FVector EyeLookAt, float AngleScale)
		{
			ABPC_Seq_Body_V2_C.__ProcessEye_FunctionParams* ptr = stackalloc ABPC_Seq_Body_V2_C.__ProcessEye_FunctionParams[(UIntPtr)235] + 15L / (long)sizeof(ABPC_Seq_Body_V2_C.__ProcessEye_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABPC_Seq_Body_V2_C.__ProcessEye_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EyeLookAt = EyeLookAt;
			ptr->AngleScale = AngleScale;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABPC_Seq_Body_V2_C.__ProcessEye_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021048 RID: 135240 RVA: 0x00956760 File Offset: 0x00954960
		[NullableContext(2)]
		[SkipLocalsInit]
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

		// Token: 0x06021049 RID: 135241 RVA: 0x009567DB File Offset: 0x009549DB
		protected ABPC_Seq_Body_V2_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011E73 RID: 73331
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseSeqCharacter/ABPC_Seq_Body_V2.ABPC_Seq_Body_V2_C";

		// Token: 0x04011E74 RID: 73332
		private static IntPtr _ClassPtr;

		// Token: 0x04011E75 RID: 73333
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011E76 RID: 73334
		internal static int __PropertyOffset_启用物理模拟;

		// Token: 0x04011E77 RID: 73335
		internal static int __PropertyOffset_物理模拟权重;

		// Token: 0x04011E78 RID: 73336
		internal static int __PropertyOffset_Add_LookAt;

		// Token: 0x04011E79 RID: 73337
		internal static int __PropertyOffset_Add_Bip001Head;

		// Token: 0x04011E7A RID: 73338
		internal static int __PropertyOffset_Add_Bip001Neck;

		// Token: 0x04011E7B RID: 73339
		internal static int __PropertyOffset_Add_Bip001Spine2;

		// Token: 0x04011E7C RID: 73340
		internal static int __PropertyOffset_Add_Bip001LClavicle;

		// Token: 0x04011E7D RID: 73341
		internal static int __PropertyOffset_Add_Bip001LUpperArm;

		// Token: 0x04011E7E RID: 73342
		internal static int __PropertyOffset_Add_Bip001LForearm;

		// Token: 0x04011E7F RID: 73343
		internal static int __PropertyOffset_Add_Bip001RClavicle;

		// Token: 0x04011E80 RID: 73344
		internal static int __PropertyOffset_Add_Bip001RUpperArm;

		// Token: 0x04011E81 RID: 73345
		internal static int __PropertyOffset_Add_Bip001RForearm;

		// Token: 0x04011E82 RID: 73346
		internal static int __PropertyOffset_Add_Bip001Spine1;

		// Token: 0x04011E83 RID: 73347
		internal static int __PropertyOffset_Add_Bip001LHand;

		// Token: 0x04011E84 RID: 73348
		internal static int __PropertyOffset_Add_Bip001RHand;

		// Token: 0x04011E85 RID: 73349
		internal static int __PropertyOffset_SeqLHandWeight;

		// Token: 0x04011E86 RID: 73350
		internal static int __PropertyOffset_SeqRHandWeight;

		// Token: 0x04011E87 RID: 73351
		internal static int __PropertyOffset_Add_Bip001LThigh;

		// Token: 0x04011E88 RID: 73352
		internal static int __PropertyOffset_Add_Bip001LCalf;

		// Token: 0x04011E89 RID: 73353
		internal static int __PropertyOffset_Add_Bip001LFoot;

		// Token: 0x04011E8A RID: 73354
		internal static int __PropertyOffset_Add_Bip001RThigh;

		// Token: 0x04011E8B RID: 73355
		internal static int __PropertyOffset_Add_Bip001RCalf;

		// Token: 0x04011E8C RID: 73356
		internal static int __PropertyOffset_Add_Bip001RFoot;

		// Token: 0x04011E8D RID: 73357
		private static IntPtr __GetBindingName_NativeFunctionPtr;

		// Token: 0x04011E8E RID: 73358
		private static IntPtr __GetCurveValue_NativeFunctionPtr;

		// Token: 0x04011E8F RID: 73359
		private static IntPtr __ProcessEye_NativeFunctionPtr;

		// Token: 0x04011E90 RID: 73360
		private static IntPtr __SetAnimDataVectorByOwner_NativeFunctionPtr;

		// Token: 0x0200905D RID: 36957
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __GetBindingName_FunctionParams
		{
			// Token: 0x0402CE5B RID: 183899
			[FieldOffset(0)]
			public FName __Result;
		}

		// Token: 0x0200905E RID: 36958
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetCurveValue_FunctionParams
		{
			// Token: 0x0402CE5C RID: 183900
			[FieldOffset(0)]
			public FName CurveName;

			// Token: 0x0402CE5D RID: 183901
			[FieldOffset(12)]
			public float __Result;
		}

		// Token: 0x0200905F RID: 36959
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 220)]
		protected ref struct __ProcessEye_FunctionParams
		{
			// Token: 0x0402CE5E RID: 183902
			[FieldOffset(0)]
			public FVector EyeLookAt;

			// Token: 0x0402CE5F RID: 183903
			[FieldOffset(12)]
			public float AngleScale;
		}

		// Token: 0x02009060 RID: 36960
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1112)]
		protected ref struct __SetAnimDataVectorByOwner_FunctionParams
		{
			// Token: 0x0402CE60 RID: 183904
			[FieldOffset(0)]
			public byte VectorMap;
		}
	}
}

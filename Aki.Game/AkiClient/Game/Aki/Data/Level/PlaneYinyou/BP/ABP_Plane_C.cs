using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Level.PlaneYinyou.BP
{
	// Token: 0x020031C7 RID: 12743
	[UnrealObjectPath("/Game/Aki/Data/Level/PlaneYinyou/BP/ABP_Plane.ABP_Plane_C")]
	[UnrealStructLayout(6608, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 6608)]
	public class ABP_Plane_C : UAnimInstance, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F8B5 RID: 129205 RVA: 0x0093014D File Offset: 0x0092E34D
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_Plane_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/Level/PlaneYinyou/BP/ABP_Plane.ABP_Plane_C");
			}
			return ABP_Plane_C._ClassPtr;
		}

		// Token: 0x0601F8B6 RID: 129206 RVA: 0x00930174 File Offset: 0x0092E374
		public ABP_Plane_C() : this(BuiltinUtils.AllocNativeUObject(ABP_Plane_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F8B7 RID: 129207 RVA: 0x0093019C File Offset: 0x0092E39C
		[NullableContext(1)]
		public ABP_Plane_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_Plane_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170039F6 RID: 14838
		// (get) Token: 0x0601F8B8 RID: 129208 RVA: 0x009301CF File Offset: 0x0092E3CF
		// (set) Token: 0x0601F8B9 RID: 129209 RVA: 0x009301DF File Offset: 0x0092E3DF
		public unsafe bool InputRollL
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_Plane_C.__PropertyOffset_InputRollL) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_Plane_C.__PropertyOffset_InputRollL) = (value ? 1 : 0);
			}
		}

		// Token: 0x170039F7 RID: 14839
		// (get) Token: 0x0601F8BA RID: 129210 RVA: 0x009301F0 File Offset: 0x0092E3F0
		// (set) Token: 0x0601F8BB RID: 129211 RVA: 0x00930200 File Offset: 0x0092E400
		public unsafe float Direction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_Plane_C.__PropertyOffset_Direction);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_Plane_C.__PropertyOffset_Direction) = value;
			}
		}

		// Token: 0x170039F8 RID: 14840
		// (get) Token: 0x0601F8BC RID: 129212 RVA: 0x00930211 File Offset: 0x0092E411
		// (set) Token: 0x0601F8BD RID: 129213 RVA: 0x00930221 File Offset: 0x0092E421
		public unsafe bool InputRollR
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_Plane_C.__PropertyOffset_InputRollR) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_Plane_C.__PropertyOffset_InputRollR) = (value ? 1 : 0);
			}
		}

		// Token: 0x170039F9 RID: 14841
		// (get) Token: 0x0601F8BE RID: 129214 RVA: 0x00930232 File Offset: 0x0092E432
		// (set) Token: 0x0601F8BF RID: 129215 RVA: 0x00930242 File Offset: 0x0092E442
		public unsafe float Horzontal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_Plane_C.__PropertyOffset_Horzontal);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_Plane_C.__PropertyOffset_Horzontal) = value;
			}
		}

		// Token: 0x170039FA RID: 14842
		// (get) Token: 0x0601F8C0 RID: 129216 RVA: 0x00930253 File Offset: 0x0092E453
		// (set) Token: 0x0601F8C1 RID: 129217 RVA: 0x00930263 File Offset: 0x0092E463
		public unsafe float Jump_0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_Plane_C.__PropertyOffset_Jump_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_Plane_C.__PropertyOffset_Jump_0) = value;
			}
		}

		// Token: 0x170039FB RID: 14843
		// (get) Token: 0x0601F8C2 RID: 129218 RVA: 0x00930274 File Offset: 0x0092E474
		// (set) Token: 0x0601F8C3 RID: 129219 RVA: 0x00930284 File Offset: 0x0092E484
		public unsafe bool InputJump
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_Plane_C.__PropertyOffset_InputJump) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_Plane_C.__PropertyOffset_InputJump) = (value ? 1 : 0);
			}
		}

		// Token: 0x170039FC RID: 14844
		// (get) Token: 0x0601F8C4 RID: 129220 RVA: 0x00930295 File Offset: 0x0092E495
		// (set) Token: 0x0601F8C5 RID: 129221 RVA: 0x009302A5 File Offset: 0x0092E4A5
		public unsafe bool InputRollL3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_Plane_C.__PropertyOffset_InputRollL3) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_Plane_C.__PropertyOffset_InputRollL3) = (value ? 1 : 0);
			}
		}

		// Token: 0x170039FD RID: 14845
		// (get) Token: 0x0601F8C6 RID: 129222 RVA: 0x009302B6 File Offset: 0x0092E4B6
		// (set) Token: 0x0601F8C7 RID: 129223 RVA: 0x009302C6 File Offset: 0x0092E4C6
		public unsafe bool InputRollR3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_Plane_C.__PropertyOffset_InputRollR3) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_Plane_C.__PropertyOffset_InputRollR3) = (value ? 1 : 0);
			}
		}

		// Token: 0x170039FE RID: 14846
		// (get) Token: 0x0601F8C8 RID: 129224 RVA: 0x009302D7 File Offset: 0x0092E4D7
		// (set) Token: 0x0601F8C9 RID: 129225 RVA: 0x009302E7 File Offset: 0x0092E4E7
		public unsafe float BlendTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_Plane_C.__PropertyOffset_BlendTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_Plane_C.__PropertyOffset_BlendTime) = value;
			}
		}

		// Token: 0x170039FF RID: 14847
		// (get) Token: 0x0601F8CA RID: 129226 RVA: 0x009302F8 File Offset: 0x0092E4F8
		// (set) Token: 0x0601F8CB RID: 129227 RVA: 0x00930308 File Offset: 0x0092E508
		public unsafe bool InputSwingL
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_Plane_C.__PropertyOffset_InputSwingL) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_Plane_C.__PropertyOffset_InputSwingL) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003A00 RID: 14848
		// (get) Token: 0x0601F8CC RID: 129228 RVA: 0x00930319 File Offset: 0x0092E519
		// (set) Token: 0x0601F8CD RID: 129229 RVA: 0x00930329 File Offset: 0x0092E529
		public unsafe bool InputSwingR
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_Plane_C.__PropertyOffset_InputSwingR) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_Plane_C.__PropertyOffset_InputSwingR) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003A01 RID: 14849
		// (get) Token: 0x0601F8CE RID: 129230 RVA: 0x0093033A File Offset: 0x0092E53A
		// (set) Token: 0x0601F8CF RID: 129231 RVA: 0x0093034A File Offset: 0x0092E54A
		public unsafe bool InputMoveL
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_Plane_C.__PropertyOffset_InputMoveL) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_Plane_C.__PropertyOffset_InputMoveL) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003A02 RID: 14850
		// (get) Token: 0x0601F8D0 RID: 129232 RVA: 0x0093035B File Offset: 0x0092E55B
		// (set) Token: 0x0601F8D1 RID: 129233 RVA: 0x0093036B File Offset: 0x0092E56B
		public unsafe bool InputMoveR
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_Plane_C.__PropertyOffset_InputMoveR) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_Plane_C.__PropertyOffset_InputMoveR) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601F8D2 RID: 129234 RVA: 0x0093037C File Offset: 0x0092E57C
		[SkipLocalsInit]
		public unsafe override void BlueprintUpdateAnimation(float DeltaTimeX)
		{
			ABP_Plane_C.__BlueprintUpdateAnimation_FunctionParams* ptr = stackalloc ABP_Plane_C.__BlueprintUpdateAnimation_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_Plane_C.__BlueprintUpdateAnimation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_Plane_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTimeX = DeltaTimeX;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_Plane_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601F8D3 RID: 129235 RVA: 0x009303C4 File Offset: 0x0092E5C4
		[SkipLocalsInit]
		protected unsafe virtual void BlueprintUpdateAnimation_Implementation(float DeltaTimeX)
		{
			ABP_Plane_C.__BlueprintUpdateAnimation_FunctionParams* ptr = stackalloc ABP_Plane_C.__BlueprintUpdateAnimation_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_Plane_C.__BlueprintUpdateAnimation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_Plane_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTimeX = DeltaTimeX;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABP_Plane_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601F8D4 RID: 129236 RVA: 0x0093040A File Offset: 0x0092E60A
		protected ABP_Plane_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010EBB RID: 69307
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Data/Level/PlaneYinyou/BP/ABP_Plane.ABP_Plane_C";

		// Token: 0x04010EBC RID: 69308
		private static IntPtr _ClassPtr;

		// Token: 0x04010EBD RID: 69309
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010EBE RID: 69310
		internal static int __PropertyOffset_InputRollL;

		// Token: 0x04010EBF RID: 69311
		internal static int __PropertyOffset_Direction;

		// Token: 0x04010EC0 RID: 69312
		internal static int __PropertyOffset_InputRollR;

		// Token: 0x04010EC1 RID: 69313
		internal static int __PropertyOffset_Horzontal;

		// Token: 0x04010EC2 RID: 69314
		internal static int __PropertyOffset_Jump_0;

		// Token: 0x04010EC3 RID: 69315
		internal static int __PropertyOffset_InputJump;

		// Token: 0x04010EC4 RID: 69316
		internal static int __PropertyOffset_InputRollL3;

		// Token: 0x04010EC5 RID: 69317
		internal static int __PropertyOffset_InputRollR3;

		// Token: 0x04010EC6 RID: 69318
		internal static int __PropertyOffset_BlendTime;

		// Token: 0x04010EC7 RID: 69319
		internal static int __PropertyOffset_InputSwingL;

		// Token: 0x04010EC8 RID: 69320
		internal static int __PropertyOffset_InputSwingR;

		// Token: 0x04010EC9 RID: 69321
		internal static int __PropertyOffset_InputMoveL;

		// Token: 0x04010ECA RID: 69322
		internal static int __PropertyOffset_InputMoveR;

		// Token: 0x04010ECB RID: 69323
		private static IntPtr __BlueprintUpdateAnimation_NativeFunctionPtr;

		// Token: 0x02008F24 RID: 36644
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __BlueprintUpdateAnimation_FunctionParams
		{
			// Token: 0x0402CC56 RID: 183382
			[FieldOffset(0)]
			public float DeltaTimeX;
		}
	}
}

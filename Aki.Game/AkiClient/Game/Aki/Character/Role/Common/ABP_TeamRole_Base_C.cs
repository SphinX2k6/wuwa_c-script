using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common
{
	// Token: 0x0200329B RID: 12955
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/ABP_TeamRole_Base.ABP_TeamRole_Base_C")]
	[UnrealStructLayout(3872, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 3868)]
	public class ABP_TeamRole_Base_C : UAnimInstance, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060208E2 RID: 133346 RVA: 0x00949A1F File Offset: 0x00947C1F
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_TeamRole_Base_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/ABP_TeamRole_Base.ABP_TeamRole_Base_C");
			}
			return ABP_TeamRole_Base_C._ClassPtr;
		}

		// Token: 0x060208E3 RID: 133347 RVA: 0x00949A44 File Offset: 0x00947C44
		public ABP_TeamRole_Base_C() : this(BuiltinUtils.AllocNativeUObject(ABP_TeamRole_Base_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060208E4 RID: 133348 RVA: 0x00949A6C File Offset: 0x00947C6C
		[NullableContext(1)]
		public ABP_TeamRole_Base_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_TeamRole_Base_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003FB7 RID: 16311
		// (get) Token: 0x060208E5 RID: 133349 RVA: 0x00949A9F File Offset: 0x00947C9F
		// (set) Token: 0x060208E6 RID: 133350 RVA: 0x00949AAF File Offset: 0x00947CAF
		public unsafe int Position
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_TeamRole_Base_C.__PropertyOffset_Position);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_TeamRole_Base_C.__PropertyOffset_Position) = value;
			}
		}

		// Token: 0x060208E7 RID: 133351 RVA: 0x00949AC0 File Offset: 0x00947CC0
		[SkipLocalsInit]
		public unsafe virtual void SetPosition(int Postion)
		{
			ABP_TeamRole_Base_C.__SetPosition_FunctionParams* ptr = stackalloc ABP_TeamRole_Base_C.__SetPosition_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_TeamRole_Base_C.__SetPosition_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_TeamRole_Base_C.__SetPosition_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Postion = Postion;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_TeamRole_Base_C.__SetPosition_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060208E8 RID: 133352 RVA: 0x00949B06 File Offset: 0x00947D06
		protected ABP_TeamRole_Base_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011990 RID: 72080
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/ABP_TeamRole_Base.ABP_TeamRole_Base_C";

		// Token: 0x04011991 RID: 72081
		private static IntPtr _ClassPtr;

		// Token: 0x04011992 RID: 72082
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011993 RID: 72083
		internal static int __PropertyOffset_Position;

		// Token: 0x04011994 RID: 72084
		private static IntPtr __SetPosition_NativeFunctionPtr;

		// Token: 0x02008F93 RID: 36755
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __SetPosition_FunctionParams
		{
			// Token: 0x0402CD32 RID: 183602
			[FieldOffset(0)]
			public int Postion;
		}
	}
}

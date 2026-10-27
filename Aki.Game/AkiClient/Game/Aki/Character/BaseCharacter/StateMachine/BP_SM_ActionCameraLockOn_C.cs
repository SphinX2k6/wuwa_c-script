using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x02004358 RID: 17240
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ActionCameraLockOn.BP_SM_ActionCameraLockOn_C")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 49)]
	public class BP_SM_ActionCameraLockOn_C : UASMAction, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602CB36 RID: 183094 RVA: 0x00A26346 File Offset: 0x00A24546
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_ActionCameraLockOn_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ActionCameraLockOn.BP_SM_ActionCameraLockOn_C");
			}
			return BP_SM_ActionCameraLockOn_C._ClassPtr;
		}

		// Token: 0x0602CB37 RID: 183095 RVA: 0x00A2636C File Offset: 0x00A2456C
		public BP_SM_ActionCameraLockOn_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_ActionCameraLockOn_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602CB38 RID: 183096 RVA: 0x00A26394 File Offset: 0x00A24594
		[NullableContext(1)]
		public BP_SM_ActionCameraLockOn_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_ActionCameraLockOn_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007083 RID: 28803
		// (get) Token: 0x0602CB39 RID: 183097 RVA: 0x00A263C7 File Offset: 0x00A245C7
		// (set) Token: 0x0602CB3A RID: 183098 RVA: 0x00A263D7 File Offset: 0x00A245D7
		public unsafe bool 是否解耦
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_ActionCameraLockOn_C.__PropertyOffset_0) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_ActionCameraLockOn_C.__PropertyOffset_0) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602CB3B RID: 183099 RVA: 0x00A263E8 File Offset: 0x00A245E8
		protected BP_SM_ActionCameraLockOn_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017918 RID: 96536
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ActionCameraLockOn.BP_SM_ActionCameraLockOn_C";

		// Token: 0x04017919 RID: 96537
		private static IntPtr _ClassPtr;

		// Token: 0x0401791A RID: 96538
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401791B RID: 96539
		internal static int __PropertyOffset_0;
	}
}

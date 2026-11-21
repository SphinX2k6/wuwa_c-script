using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x02003379 RID: 13177
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ActionCameraLockOn.BP_SM_ActionCameraLockOn_C")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 49)]
	public class BP_SM_ActionCameraLockOn_C : UASMAction, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021754 RID: 137044 RVA: 0x0096119A File Offset: 0x0095F39A
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_ActionCameraLockOn_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ActionCameraLockOn.BP_SM_ActionCameraLockOn_C");
			}
			return BP_SM_ActionCameraLockOn_C._ClassPtr;
		}

		// Token: 0x06021755 RID: 137045 RVA: 0x009611C0 File Offset: 0x0095F3C0
		public BP_SM_ActionCameraLockOn_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_ActionCameraLockOn_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021756 RID: 137046 RVA: 0x009611E8 File Offset: 0x0095F3E8
		[NullableContext(1)]
		public BP_SM_ActionCameraLockOn_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_ActionCameraLockOn_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004485 RID: 17541
		// (get) Token: 0x06021757 RID: 137047 RVA: 0x0096121B File Offset: 0x0095F41B
		// (set) Token: 0x06021758 RID: 137048 RVA: 0x0096122B File Offset: 0x0095F42B
		public unsafe bool 是否解耦
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_ActionCameraLockOn_C.__PropertyOffset_是否解耦) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_ActionCameraLockOn_C.__PropertyOffset_是否解耦) = (value ? 1 : 0);
			}
		}

		// Token: 0x06021759 RID: 137049 RVA: 0x0096123C File Offset: 0x0095F43C
		protected BP_SM_ActionCameraLockOn_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012499 RID: 74905
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ActionCameraLockOn.BP_SM_ActionCameraLockOn_C";

		// Token: 0x0401249A RID: 74906
		private static IntPtr _ClassPtr;

		// Token: 0x0401249B RID: 74907
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401249C RID: 74908
		internal static int __PropertyOffset_是否解耦;
	}
}

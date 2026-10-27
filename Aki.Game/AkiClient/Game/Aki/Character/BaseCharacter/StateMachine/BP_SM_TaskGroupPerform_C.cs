using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x02004390 RID: 17296
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_TaskGroupPerform.BP_SM_TaskGroupPerform_C")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class BP_SM_TaskGroupPerform_C : UASMTask, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602CCCC RID: 183500 RVA: 0x00A28F60 File Offset: 0x00A27160
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_TaskGroupPerform_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_TaskGroupPerform.BP_SM_TaskGroupPerform_C");
			}
			return BP_SM_TaskGroupPerform_C._ClassPtr;
		}

		// Token: 0x0602CCCD RID: 183501 RVA: 0x00A28F84 File Offset: 0x00A27184
		public BP_SM_TaskGroupPerform_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_TaskGroupPerform_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602CCCE RID: 183502 RVA: 0x00A28FAC File Offset: 0x00A271AC
		[NullableContext(1)]
		public BP_SM_TaskGroupPerform_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_TaskGroupPerform_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602CCCF RID: 183503 RVA: 0x00A28FDF File Offset: 0x00A271DF
		protected BP_SM_TaskGroupPerform_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017A23 RID: 96803
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_TaskGroupPerform.BP_SM_TaskGroupPerform_C";

		// Token: 0x04017A24 RID: 96804
		private static IntPtr _ClassPtr;

		// Token: 0x04017A25 RID: 96805
		private static IntPtr _ClassDefaultObjectPtr;
	}
}

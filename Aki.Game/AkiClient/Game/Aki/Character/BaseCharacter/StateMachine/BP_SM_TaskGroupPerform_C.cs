using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x020033B0 RID: 13232
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_TaskGroupPerform.BP_SM_TaskGroupPerform_C")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class BP_SM_TaskGroupPerform_C : UASMTask, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060218E2 RID: 137442 RVA: 0x00963CB8 File Offset: 0x00961EB8
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_TaskGroupPerform_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_TaskGroupPerform.BP_SM_TaskGroupPerform_C");
			}
			return BP_SM_TaskGroupPerform_C._ClassPtr;
		}

		// Token: 0x060218E3 RID: 137443 RVA: 0x00963CDC File Offset: 0x00961EDC
		public BP_SM_TaskGroupPerform_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_TaskGroupPerform_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060218E4 RID: 137444 RVA: 0x00963D04 File Offset: 0x00961F04
		[NullableContext(1)]
		public BP_SM_TaskGroupPerform_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_TaskGroupPerform_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060218E5 RID: 137445 RVA: 0x00963D37 File Offset: 0x00961F37
		protected BP_SM_TaskGroupPerform_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401259E RID: 75166
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_TaskGroupPerform.BP_SM_TaskGroupPerform_C";

		// Token: 0x0401259F RID: 75167
		private static IntPtr _ClassPtr;

		// Token: 0x040125A0 RID: 75168
		private static IntPtr _ClassDefaultObjectPtr;
	}
}

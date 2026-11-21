using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x02003385 RID: 13189
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ActionSetRageFullAttribute.BP_SM_ActionSetRageFullAttribute_C")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class BP_SM_ActionSetRageFullAttribute_C : UASMAction, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602179C RID: 137116 RVA: 0x009619F1 File Offset: 0x0095FBF1
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_ActionSetRageFullAttribute_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ActionSetRageFullAttribute.BP_SM_ActionSetRageFullAttribute_C");
			}
			return BP_SM_ActionSetRageFullAttribute_C._ClassPtr;
		}

		// Token: 0x0602179D RID: 137117 RVA: 0x00961A18 File Offset: 0x0095FC18
		public BP_SM_ActionSetRageFullAttribute_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_ActionSetRageFullAttribute_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602179E RID: 137118 RVA: 0x00961A40 File Offset: 0x0095FC40
		[NullableContext(1)]
		public BP_SM_ActionSetRageFullAttribute_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_ActionSetRageFullAttribute_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602179F RID: 137119 RVA: 0x00961A73 File Offset: 0x0095FC73
		protected BP_SM_ActionSetRageFullAttribute_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040124CA RID: 74954
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ActionSetRageFullAttribute.BP_SM_ActionSetRageFullAttribute_C";

		// Token: 0x040124CB RID: 74955
		private static IntPtr _ClassPtr;

		// Token: 0x040124CC RID: 74956
		private static IntPtr _ClassDefaultObjectPtr;
	}
}

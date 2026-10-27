using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x02004364 RID: 17252
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ActionSetRageFullAttribute.BP_SM_ActionSetRageFullAttribute_C")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class BP_SM_ActionSetRageFullAttribute_C : UASMAction, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602CB7E RID: 183166 RVA: 0x00A26B9D File Offset: 0x00A24D9D
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_ActionSetRageFullAttribute_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ActionSetRageFullAttribute.BP_SM_ActionSetRageFullAttribute_C");
			}
			return BP_SM_ActionSetRageFullAttribute_C._ClassPtr;
		}

		// Token: 0x0602CB7F RID: 183167 RVA: 0x00A26BC4 File Offset: 0x00A24DC4
		public BP_SM_ActionSetRageFullAttribute_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_ActionSetRageFullAttribute_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602CB80 RID: 183168 RVA: 0x00A26BEC File Offset: 0x00A24DEC
		[NullableContext(1)]
		public BP_SM_ActionSetRageFullAttribute_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_ActionSetRageFullAttribute_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602CB81 RID: 183169 RVA: 0x00A26C1F File Offset: 0x00A24E1F
		protected BP_SM_ActionSetRageFullAttribute_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017949 RID: 96585
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ActionSetRageFullAttribute.BP_SM_ActionSetRageFullAttribute_C";

		// Token: 0x0401794A RID: 96586
		private static IntPtr _ClassPtr;

		// Token: 0x0401794B RID: 96587
		private static IntPtr _ClassDefaultObjectPtr;
	}
}

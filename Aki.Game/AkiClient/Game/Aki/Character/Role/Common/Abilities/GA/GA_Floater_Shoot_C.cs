using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GA;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Abilities.GA
{
	// Token: 0x02004134 RID: 16692
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Abilities/GA/GA_Floater_Shoot.GA_Floater_Shoot_C")]
	[UnrealStructLayout(1496, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1492)]
	public class GA_Floater_Shoot_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602B062 RID: 176226 RVA: 0x009F343D File Offset: 0x009F163D
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Floater_Shoot_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Floater_Shoot.GA_Floater_Shoot_C");
			}
			return GA_Floater_Shoot_C._ClassPtr;
		}

		// Token: 0x0602B063 RID: 176227 RVA: 0x009F3464 File Offset: 0x009F1664
		public GA_Floater_Shoot_C() : this(BuiltinUtils.AllocNativeUObject(GA_Floater_Shoot_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602B064 RID: 176228 RVA: 0x009F348C File Offset: 0x009F168C
		[NullableContext(1)]
		public GA_Floater_Shoot_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Floater_Shoot_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602B065 RID: 176229 RVA: 0x009F34BF File Offset: 0x009F16BF
		protected GA_Floater_Shoot_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016510 RID: 91408
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Floater_Shoot.GA_Floater_Shoot_C";

		// Token: 0x04016511 RID: 91409
		private static IntPtr _ClassPtr;

		// Token: 0x04016512 RID: 91410
		private static IntPtr _ClassDefaultObjectPtr;
	}
}

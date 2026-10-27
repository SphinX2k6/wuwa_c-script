using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x02004371 RID: 17265
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_BindStateDisableCollision.BP_SM_BindStateDisableCollision_C")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class BP_SM_BindStateDisableCollision_C : UASMBindState, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602CBE4 RID: 183268 RVA: 0x00A2769C File Offset: 0x00A2589C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_BindStateDisableCollision_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_BindStateDisableCollision.BP_SM_BindStateDisableCollision_C");
			}
			return BP_SM_BindStateDisableCollision_C._ClassPtr;
		}

		// Token: 0x0602CBE5 RID: 183269 RVA: 0x00A276C0 File Offset: 0x00A258C0
		public BP_SM_BindStateDisableCollision_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_BindStateDisableCollision_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602CBE6 RID: 183270 RVA: 0x00A276E8 File Offset: 0x00A258E8
		[NullableContext(1)]
		public BP_SM_BindStateDisableCollision_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_BindStateDisableCollision_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602CBE7 RID: 183271 RVA: 0x00A2771B File Offset: 0x00A2591B
		protected BP_SM_BindStateDisableCollision_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401798D RID: 96653
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_BindStateDisableCollision.BP_SM_BindStateDisableCollision_C";

		// Token: 0x0401798E RID: 96654
		private static IntPtr _ClassPtr;

		// Token: 0x0401798F RID: 96655
		private static IntPtr _ClassDefaultObjectPtr;
	}
}

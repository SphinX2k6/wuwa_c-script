using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x02004359 RID: 17241
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ActionChangeInstState.BP_SM_ActionChangeInstState_C")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 60)]
	public class BP_SM_ActionChangeInstState_C : UASMAction, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602CB3C RID: 183100 RVA: 0x00A263F1 File Offset: 0x00A245F1
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_ActionChangeInstState_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ActionChangeInstState.BP_SM_ActionChangeInstState_C");
			}
			return BP_SM_ActionChangeInstState_C._ClassPtr;
		}

		// Token: 0x0602CB3D RID: 183101 RVA: 0x00A26418 File Offset: 0x00A24618
		public BP_SM_ActionChangeInstState_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_ActionChangeInstState_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602CB3E RID: 183102 RVA: 0x00A26440 File Offset: 0x00A24640
		[NullableContext(1)]
		public BP_SM_ActionChangeInstState_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_ActionChangeInstState_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007084 RID: 28804
		// (get) Token: 0x0602CB3F RID: 183103 RVA: 0x00A26473 File Offset: 0x00A24673
		// (set) Token: 0x0602CB40 RID: 183104 RVA: 0x00A26487 File Offset: 0x00A24687
		public unsafe FGameplayTag Tag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_ActionChangeInstState_C.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_ActionChangeInstState_C.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x0602CB41 RID: 183105 RVA: 0x00A2649C File Offset: 0x00A2469C
		protected BP_SM_ActionChangeInstState_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401791C RID: 96540
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ActionChangeInstState.BP_SM_ActionChangeInstState_C";

		// Token: 0x0401791D RID: 96541
		private static IntPtr _ClassPtr;

		// Token: 0x0401791E RID: 96542
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401791F RID: 96543
		internal static int __PropertyOffset_0;
	}
}

using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x0200437D RID: 17277
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionCheckInstState.BP_SM_ConditionCheckInstState_C")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 68)]
	public class BP_SM_ConditionCheckInstState_C : UASMConditionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602CC42 RID: 183362 RVA: 0x00A2808C File Offset: 0x00A2628C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_ConditionCheckInstState_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionCheckInstState.BP_SM_ConditionCheckInstState_C");
			}
			return BP_SM_ConditionCheckInstState_C._ClassPtr;
		}

		// Token: 0x0602CC43 RID: 183363 RVA: 0x00A280B0 File Offset: 0x00A262B0
		public BP_SM_ConditionCheckInstState_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_ConditionCheckInstState_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602CC44 RID: 183364 RVA: 0x00A280D8 File Offset: 0x00A262D8
		[NullableContext(1)]
		public BP_SM_ConditionCheckInstState_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_ConditionCheckInstState_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170070BF RID: 28863
		// (get) Token: 0x0602CC45 RID: 183365 RVA: 0x00A2810B File Offset: 0x00A2630B
		// (set) Token: 0x0602CC46 RID: 183366 RVA: 0x00A2811F File Offset: 0x00A2631F
		public unsafe FGameplayTag Tag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_ConditionCheckInstState_C.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_ConditionCheckInstState_C.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x0602CC47 RID: 183367 RVA: 0x00A28134 File Offset: 0x00A26334
		protected BP_SM_ConditionCheckInstState_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040179C9 RID: 96713
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionCheckInstState.BP_SM_ConditionCheckInstState_C";

		// Token: 0x040179CA RID: 96714
		private static IntPtr _ClassPtr;

		// Token: 0x040179CB RID: 96715
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040179CC RID: 96716
		internal static int __PropertyOffset_0;
	}
}

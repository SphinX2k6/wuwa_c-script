using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x0200339F RID: 13215
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionCheckLastState.BP_SM_ConditionCheckLastState_C")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class BP_SM_ConditionCheckLastState_C : UASMConditionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021866 RID: 137318 RVA: 0x00962F91 File Offset: 0x00961191
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_ConditionCheckLastState_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionCheckLastState.BP_SM_ConditionCheckLastState_C");
			}
			return BP_SM_ConditionCheckLastState_C._ClassPtr;
		}

		// Token: 0x06021867 RID: 137319 RVA: 0x00962FB8 File Offset: 0x009611B8
		public BP_SM_ConditionCheckLastState_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_ConditionCheckLastState_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021868 RID: 137320 RVA: 0x00962FE0 File Offset: 0x009611E0
		public BP_SM_ConditionCheckLastState_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_ConditionCheckLastState_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170044C2 RID: 17602
		// (get) Token: 0x06021869 RID: 137321 RVA: 0x00963013 File Offset: 0x00961213
		// (set) Token: 0x0602186A RID: 137322 RVA: 0x00963027 File Offset: 0x00961227
		public unsafe string 检查状态
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_SM_ConditionCheckLastState_C.__PropertyOffset_检查状态)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_SM_ConditionCheckLastState_C.__PropertyOffset_检查状态)), value);
			}
		}

		// Token: 0x0602186B RID: 137323 RVA: 0x0096303C File Offset: 0x0096123C
		protected BP_SM_ConditionCheckLastState_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401254E RID: 75086
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionCheckLastState.BP_SM_ConditionCheckLastState_C";

		// Token: 0x0401254F RID: 75087
		private static IntPtr _ClassPtr;

		// Token: 0x04012550 RID: 75088
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012551 RID: 75089
		internal static int __PropertyOffset_检查状态;
	}
}

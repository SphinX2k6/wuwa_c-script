using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x020033A2 RID: 13218
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionCheckState.BP_SM_ConditionCheckState_C")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class BP_SM_ConditionCheckState_C : UASMConditionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021878 RID: 137336 RVA: 0x009631AD File Offset: 0x009613AD
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_ConditionCheckState_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionCheckState.BP_SM_ConditionCheckState_C");
			}
			return BP_SM_ConditionCheckState_C._ClassPtr;
		}

		// Token: 0x06021879 RID: 137337 RVA: 0x009631D4 File Offset: 0x009613D4
		public BP_SM_ConditionCheckState_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_ConditionCheckState_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602187A RID: 137338 RVA: 0x009631FC File Offset: 0x009613FC
		public BP_SM_ConditionCheckState_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_ConditionCheckState_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170044C5 RID: 17605
		// (get) Token: 0x0602187B RID: 137339 RVA: 0x0096322F File Offset: 0x0096142F
		// (set) Token: 0x0602187C RID: 137340 RVA: 0x00963243 File Offset: 0x00961443
		public unsafe string 检查状态
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_SM_ConditionCheckState_C.__PropertyOffset_检查状态)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_SM_ConditionCheckState_C.__PropertyOffset_检查状态)), value);
			}
		}

		// Token: 0x0602187D RID: 137341 RVA: 0x00963258 File Offset: 0x00961458
		protected BP_SM_ConditionCheckState_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401255A RID: 75098
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionCheckState.BP_SM_ConditionCheckState_C";

		// Token: 0x0401255B RID: 75099
		private static IntPtr _ClassPtr;

		// Token: 0x0401255C RID: 75100
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401255D RID: 75101
		internal static int __PropertyOffset_检查状态;
	}
}

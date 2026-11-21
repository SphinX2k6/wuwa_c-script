using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x020033A6 RID: 13222
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionListenEvent.BP_SM_ConditionListenEvent_C")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class BP_SM_ConditionListenEvent_C : UASMConditionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602189A RID: 137370 RVA: 0x00963504 File Offset: 0x00961704
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_ConditionListenEvent_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionListenEvent.BP_SM_ConditionListenEvent_C");
			}
			return BP_SM_ConditionListenEvent_C._ClassPtr;
		}

		// Token: 0x0602189B RID: 137371 RVA: 0x00963528 File Offset: 0x00961728
		public BP_SM_ConditionListenEvent_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_ConditionListenEvent_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602189C RID: 137372 RVA: 0x00963550 File Offset: 0x00961750
		public BP_SM_ConditionListenEvent_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_ConditionListenEvent_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170044CE RID: 17614
		// (get) Token: 0x0602189D RID: 137373 RVA: 0x00963583 File Offset: 0x00961783
		// (set) Token: 0x0602189E RID: 137374 RVA: 0x00963597 File Offset: 0x00961797
		public unsafe string 监听事件名
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_SM_ConditionListenEvent_C.__PropertyOffset_监听事件名)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_SM_ConditionListenEvent_C.__PropertyOffset_监听事件名)), value);
			}
		}

		// Token: 0x0602189F RID: 137375 RVA: 0x009635AC File Offset: 0x009617AC
		protected BP_SM_ConditionListenEvent_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401256F RID: 75119
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionListenEvent.BP_SM_ConditionListenEvent_C";

		// Token: 0x04012570 RID: 75120
		private static IntPtr _ClassPtr;

		// Token: 0x04012571 RID: 75121
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012572 RID: 75122
		internal static int __PropertyOffset_监听事件名;
	}
}

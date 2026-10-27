using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x02004385 RID: 17285
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionListenEvent.BP_SM_ConditionListenEvent_C")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class BP_SM_ConditionListenEvent_C : UASMConditionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602CC7C RID: 183420 RVA: 0x00A286B0 File Offset: 0x00A268B0
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_ConditionListenEvent_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionListenEvent.BP_SM_ConditionListenEvent_C");
			}
			return BP_SM_ConditionListenEvent_C._ClassPtr;
		}

		// Token: 0x0602CC7D RID: 183421 RVA: 0x00A286D4 File Offset: 0x00A268D4
		public BP_SM_ConditionListenEvent_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_ConditionListenEvent_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602CC7E RID: 183422 RVA: 0x00A286FC File Offset: 0x00A268FC
		public BP_SM_ConditionListenEvent_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_ConditionListenEvent_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170070CC RID: 28876
		// (get) Token: 0x0602CC7F RID: 183423 RVA: 0x00A2872F File Offset: 0x00A2692F
		// (set) Token: 0x0602CC80 RID: 183424 RVA: 0x00A28743 File Offset: 0x00A26943
		public unsafe string 监听事件名
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_SM_ConditionListenEvent_C.__PropertyOffset_0)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_SM_ConditionListenEvent_C.__PropertyOffset_0)), value);
			}
		}

		// Token: 0x0602CC81 RID: 183425 RVA: 0x00A28758 File Offset: 0x00A26958
		protected BP_SM_ConditionListenEvent_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040179EE RID: 96750
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionListenEvent.BP_SM_ConditionListenEvent_C";

		// Token: 0x040179EF RID: 96751
		private static IntPtr _ClassPtr;

		// Token: 0x040179F0 RID: 96752
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040179F1 RID: 96753
		internal static int __PropertyOffset_0;
	}
}

using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x0200435B RID: 17243
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ActionDispatchEvent.BP_SM_ActionDispatchEvent_C")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class BP_SM_ActionDispatchEvent_C : UASMAction, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602CB4A RID: 183114 RVA: 0x00A265A1 File Offset: 0x00A247A1
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_ActionDispatchEvent_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ActionDispatchEvent.BP_SM_ActionDispatchEvent_C");
			}
			return BP_SM_ActionDispatchEvent_C._ClassPtr;
		}

		// Token: 0x0602CB4B RID: 183115 RVA: 0x00A265C8 File Offset: 0x00A247C8
		public BP_SM_ActionDispatchEvent_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_ActionDispatchEvent_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602CB4C RID: 183116 RVA: 0x00A265F0 File Offset: 0x00A247F0
		public BP_SM_ActionDispatchEvent_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_ActionDispatchEvent_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007087 RID: 28807
		// (get) Token: 0x0602CB4D RID: 183117 RVA: 0x00A26623 File Offset: 0x00A24823
		// (set) Token: 0x0602CB4E RID: 183118 RVA: 0x00A26637 File Offset: 0x00A24837
		public unsafe string 派发事件名
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_SM_ActionDispatchEvent_C.__PropertyOffset_0)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_SM_ActionDispatchEvent_C.__PropertyOffset_0)), value);
			}
		}

		// Token: 0x0602CB4F RID: 183119 RVA: 0x00A2664C File Offset: 0x00A2484C
		protected BP_SM_ActionDispatchEvent_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017926 RID: 96550
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ActionDispatchEvent.BP_SM_ActionDispatchEvent_C";

		// Token: 0x04017927 RID: 96551
		private static IntPtr _ClassPtr;

		// Token: 0x04017928 RID: 96552
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04017929 RID: 96553
		internal static int __PropertyOffset_0;
	}
}

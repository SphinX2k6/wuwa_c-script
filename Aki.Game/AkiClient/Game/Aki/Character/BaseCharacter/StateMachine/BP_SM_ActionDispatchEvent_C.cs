using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x0200337C RID: 13180
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ActionDispatchEvent.BP_SM_ActionDispatchEvent_C")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class BP_SM_ActionDispatchEvent_C : UASMAction, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021768 RID: 137064 RVA: 0x009613F5 File Offset: 0x0095F5F5
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_ActionDispatchEvent_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ActionDispatchEvent.BP_SM_ActionDispatchEvent_C");
			}
			return BP_SM_ActionDispatchEvent_C._ClassPtr;
		}

		// Token: 0x06021769 RID: 137065 RVA: 0x0096141C File Offset: 0x0095F61C
		public BP_SM_ActionDispatchEvent_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_ActionDispatchEvent_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602176A RID: 137066 RVA: 0x00961444 File Offset: 0x0095F644
		public BP_SM_ActionDispatchEvent_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_ActionDispatchEvent_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004489 RID: 17545
		// (get) Token: 0x0602176B RID: 137067 RVA: 0x00961477 File Offset: 0x0095F677
		// (set) Token: 0x0602176C RID: 137068 RVA: 0x0096148B File Offset: 0x0095F68B
		public unsafe string 派发事件名
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_SM_ActionDispatchEvent_C.__PropertyOffset_派发事件名)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_SM_ActionDispatchEvent_C.__PropertyOffset_派发事件名)), value);
			}
		}

		// Token: 0x0602176D RID: 137069 RVA: 0x009614A0 File Offset: 0x0095F6A0
		protected BP_SM_ActionDispatchEvent_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040124A7 RID: 74919
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ActionDispatchEvent.BP_SM_ActionDispatchEvent_C";

		// Token: 0x040124A8 RID: 74920
		private static IntPtr _ClassPtr;

		// Token: 0x040124A9 RID: 74921
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040124AA RID: 74922
		internal static int __PropertyOffset_派发事件名;
	}
}

using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x02003377 RID: 13175
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ActionAddBuff.BP_SM_ActionAddBuff_C")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public class BP_SM_ActionAddBuff_C : UASMAction, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021746 RID: 137030 RVA: 0x0096101A File Offset: 0x0095F21A
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_ActionAddBuff_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ActionAddBuff.BP_SM_ActionAddBuff_C");
			}
			return BP_SM_ActionAddBuff_C._ClassPtr;
		}

		// Token: 0x06021747 RID: 137031 RVA: 0x00961040 File Offset: 0x0095F240
		public BP_SM_ActionAddBuff_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_ActionAddBuff_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021748 RID: 137032 RVA: 0x00961068 File Offset: 0x0095F268
		[NullableContext(1)]
		public BP_SM_ActionAddBuff_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_ActionAddBuff_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004482 RID: 17538
		// (get) Token: 0x06021749 RID: 137033 RVA: 0x0096109B File Offset: 0x0095F29B
		// (set) Token: 0x0602174A RID: 137034 RVA: 0x009610AB File Offset: 0x0095F2AB
		public unsafe long BuffId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_ActionAddBuff_C.__PropertyOffset_BuffId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_ActionAddBuff_C.__PropertyOffset_BuffId) = value;
			}
		}

		// Token: 0x0602174B RID: 137035 RVA: 0x009610BC File Offset: 0x0095F2BC
		protected BP_SM_ActionAddBuff_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012490 RID: 74896
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ActionAddBuff.BP_SM_ActionAddBuff_C";

		// Token: 0x04012491 RID: 74897
		private static IntPtr _ClassPtr;

		// Token: 0x04012492 RID: 74898
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012493 RID: 74899
		internal static int __PropertyOffset_BuffId;
	}
}

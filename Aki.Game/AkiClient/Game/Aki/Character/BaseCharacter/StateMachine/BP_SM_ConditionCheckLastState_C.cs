using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x0200437E RID: 17278
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionCheckLastState.BP_SM_ConditionCheckLastState_C")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class BP_SM_ConditionCheckLastState_C : UASMConditionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602CC48 RID: 183368 RVA: 0x00A2813D File Offset: 0x00A2633D
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_ConditionCheckLastState_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionCheckLastState.BP_SM_ConditionCheckLastState_C");
			}
			return BP_SM_ConditionCheckLastState_C._ClassPtr;
		}

		// Token: 0x0602CC49 RID: 183369 RVA: 0x00A28164 File Offset: 0x00A26364
		public BP_SM_ConditionCheckLastState_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_ConditionCheckLastState_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602CC4A RID: 183370 RVA: 0x00A2818C File Offset: 0x00A2638C
		public BP_SM_ConditionCheckLastState_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_ConditionCheckLastState_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170070C0 RID: 28864
		// (get) Token: 0x0602CC4B RID: 183371 RVA: 0x00A281BF File Offset: 0x00A263BF
		// (set) Token: 0x0602CC4C RID: 183372 RVA: 0x00A281D3 File Offset: 0x00A263D3
		public unsafe string 检查状态
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_SM_ConditionCheckLastState_C.__PropertyOffset_0)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_SM_ConditionCheckLastState_C.__PropertyOffset_0)), value);
			}
		}

		// Token: 0x0602CC4D RID: 183373 RVA: 0x00A281E8 File Offset: 0x00A263E8
		protected BP_SM_ConditionCheckLastState_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040179CD RID: 96717
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionCheckLastState.BP_SM_ConditionCheckLastState_C";

		// Token: 0x040179CE RID: 96718
		private static IntPtr _ClassPtr;

		// Token: 0x040179CF RID: 96719
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040179D0 RID: 96720
		internal static int __PropertyOffset_0;
	}
}

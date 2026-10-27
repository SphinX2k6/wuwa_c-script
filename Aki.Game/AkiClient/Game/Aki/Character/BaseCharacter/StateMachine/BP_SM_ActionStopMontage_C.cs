using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x02004365 RID: 17253
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ActionStopMontage.BP_SM_ActionStopMontage_C")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 52)]
	public class BP_SM_ActionStopMontage_C : UASMAction, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602CB82 RID: 183170 RVA: 0x00A26C28 File Offset: 0x00A24E28
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_ActionStopMontage_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ActionStopMontage.BP_SM_ActionStopMontage_C");
			}
			return BP_SM_ActionStopMontage_C._ClassPtr;
		}

		// Token: 0x0602CB83 RID: 183171 RVA: 0x00A26C4C File Offset: 0x00A24E4C
		public BP_SM_ActionStopMontage_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_ActionStopMontage_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602CB84 RID: 183172 RVA: 0x00A26C74 File Offset: 0x00A24E74
		[NullableContext(1)]
		public BP_SM_ActionStopMontage_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_ActionStopMontage_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700708F RID: 28815
		// (get) Token: 0x0602CB85 RID: 183173 RVA: 0x00A26CA7 File Offset: 0x00A24EA7
		// (set) Token: 0x0602CB86 RID: 183174 RVA: 0x00A26CB7 File Offset: 0x00A24EB7
		public unsafe int 淡出时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_ActionStopMontage_C.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_ActionStopMontage_C.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x0602CB87 RID: 183175 RVA: 0x00A26CC8 File Offset: 0x00A24EC8
		protected BP_SM_ActionStopMontage_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401794C RID: 96588
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ActionStopMontage.BP_SM_ActionStopMontage_C";

		// Token: 0x0401794D RID: 96589
		private static IntPtr _ClassPtr;

		// Token: 0x0401794E RID: 96590
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401794F RID: 96591
		internal static int __PropertyOffset_0;
	}
}

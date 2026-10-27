using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x02004356 RID: 17238
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ActionAddBuff.BP_SM_ActionAddBuff_C")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public class BP_SM_ActionAddBuff_C : UASMAction, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602CB28 RID: 183080 RVA: 0x00A261C6 File Offset: 0x00A243C6
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_ActionAddBuff_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ActionAddBuff.BP_SM_ActionAddBuff_C");
			}
			return BP_SM_ActionAddBuff_C._ClassPtr;
		}

		// Token: 0x0602CB29 RID: 183081 RVA: 0x00A261EC File Offset: 0x00A243EC
		public BP_SM_ActionAddBuff_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_ActionAddBuff_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602CB2A RID: 183082 RVA: 0x00A26214 File Offset: 0x00A24414
		[NullableContext(1)]
		public BP_SM_ActionAddBuff_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_ActionAddBuff_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007080 RID: 28800
		// (get) Token: 0x0602CB2B RID: 183083 RVA: 0x00A26247 File Offset: 0x00A24447
		// (set) Token: 0x0602CB2C RID: 183084 RVA: 0x00A26257 File Offset: 0x00A24457
		public unsafe long BuffId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_ActionAddBuff_C.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_ActionAddBuff_C.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x0602CB2D RID: 183085 RVA: 0x00A26268 File Offset: 0x00A24468
		protected BP_SM_ActionAddBuff_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401790F RID: 96527
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ActionAddBuff.BP_SM_ActionAddBuff_C";

		// Token: 0x04017910 RID: 96528
		private static IntPtr _ClassPtr;

		// Token: 0x04017911 RID: 96529
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04017912 RID: 96530
		internal static int __PropertyOffset_0;
	}
}

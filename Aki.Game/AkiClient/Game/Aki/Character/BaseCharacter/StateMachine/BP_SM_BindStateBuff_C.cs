using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x0200436A RID: 17258
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_BindStateBuff.BP_SM_BindStateBuff_C")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public class BP_SM_BindStateBuff_C : UASMBindState, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602CBB2 RID: 183218 RVA: 0x00A270BA File Offset: 0x00A252BA
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_BindStateBuff_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_BindStateBuff.BP_SM_BindStateBuff_C");
			}
			return BP_SM_BindStateBuff_C._ClassPtr;
		}

		// Token: 0x0602CBB3 RID: 183219 RVA: 0x00A270E0 File Offset: 0x00A252E0
		public BP_SM_BindStateBuff_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_BindStateBuff_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602CBB4 RID: 183220 RVA: 0x00A27108 File Offset: 0x00A25308
		[NullableContext(1)]
		public BP_SM_BindStateBuff_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_BindStateBuff_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700709D RID: 28829
		// (get) Token: 0x0602CBB5 RID: 183221 RVA: 0x00A2713B File Offset: 0x00A2533B
		// (set) Token: 0x0602CBB6 RID: 183222 RVA: 0x00A2714B File Offset: 0x00A2534B
		public unsafe long BuffId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_BindStateBuff_C.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_BindStateBuff_C.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x0602CBB7 RID: 183223 RVA: 0x00A2715C File Offset: 0x00A2535C
		protected BP_SM_BindStateBuff_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017969 RID: 96617
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_BindStateBuff.BP_SM_BindStateBuff_C";

		// Token: 0x0401796A RID: 96618
		private static IntPtr _ClassPtr;

		// Token: 0x0401796B RID: 96619
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401796C RID: 96620
		internal static int __PropertyOffset_0;
	}
}

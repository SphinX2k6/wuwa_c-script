using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x0200338B RID: 13195
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_BindStateBuff.BP_SM_BindStateBuff_C")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public class BP_SM_BindStateBuff_C : UASMBindState, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060217D0 RID: 137168 RVA: 0x00961F0E File Offset: 0x0096010E
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_BindStateBuff_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_BindStateBuff.BP_SM_BindStateBuff_C");
			}
			return BP_SM_BindStateBuff_C._ClassPtr;
		}

		// Token: 0x060217D1 RID: 137169 RVA: 0x00961F34 File Offset: 0x00960134
		public BP_SM_BindStateBuff_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_BindStateBuff_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060217D2 RID: 137170 RVA: 0x00961F5C File Offset: 0x0096015C
		[NullableContext(1)]
		public BP_SM_BindStateBuff_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_BindStateBuff_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700449F RID: 17567
		// (get) Token: 0x060217D3 RID: 137171 RVA: 0x00961F8F File Offset: 0x0096018F
		// (set) Token: 0x060217D4 RID: 137172 RVA: 0x00961F9F File Offset: 0x0096019F
		public unsafe long BuffId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_BindStateBuff_C.__PropertyOffset_BuffId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_BindStateBuff_C.__PropertyOffset_BuffId) = value;
			}
		}

		// Token: 0x060217D5 RID: 137173 RVA: 0x00961FB0 File Offset: 0x009601B0
		protected BP_SM_BindStateBuff_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040124EA RID: 74986
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_BindStateBuff.BP_SM_BindStateBuff_C";

		// Token: 0x040124EB RID: 74987
		private static IntPtr _ClassPtr;

		// Token: 0x040124EC RID: 74988
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040124ED RID: 74989
		internal static int __PropertyOffset_BuffId;
	}
}

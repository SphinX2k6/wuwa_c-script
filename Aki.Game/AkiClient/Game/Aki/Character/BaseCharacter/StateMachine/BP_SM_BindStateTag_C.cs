using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x02004376 RID: 17270
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_BindStateTag.BP_SM_BindStateTag_C")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 60)]
	public class BP_SM_BindStateTag_C : UASMBindState, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602CC10 RID: 183312 RVA: 0x00A27B44 File Offset: 0x00A25D44
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_BindStateTag_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_BindStateTag.BP_SM_BindStateTag_C");
			}
			return BP_SM_BindStateTag_C._ClassPtr;
		}

		// Token: 0x0602CC11 RID: 183313 RVA: 0x00A27B68 File Offset: 0x00A25D68
		public BP_SM_BindStateTag_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_BindStateTag_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602CC12 RID: 183314 RVA: 0x00A27B90 File Offset: 0x00A25D90
		[NullableContext(1)]
		public BP_SM_BindStateTag_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_BindStateTag_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170070B4 RID: 28852
		// (get) Token: 0x0602CC13 RID: 183315 RVA: 0x00A27BC3 File Offset: 0x00A25DC3
		// (set) Token: 0x0602CC14 RID: 183316 RVA: 0x00A27BD7 File Offset: 0x00A25DD7
		public unsafe FGameplayTag Tag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_BindStateTag_C.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_BindStateTag_C.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x0602CC15 RID: 183317 RVA: 0x00A27BEC File Offset: 0x00A25DEC
		protected BP_SM_BindStateTag_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040179A9 RID: 96681
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_BindStateTag.BP_SM_BindStateTag_C";

		// Token: 0x040179AA RID: 96682
		private static IntPtr _ClassPtr;

		// Token: 0x040179AB RID: 96683
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040179AC RID: 96684
		internal static int __PropertyOffset_0;
	}
}

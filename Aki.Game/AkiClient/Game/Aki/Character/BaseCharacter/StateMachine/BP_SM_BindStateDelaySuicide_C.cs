using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x0200436F RID: 17263
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_BindStateDelaySuicide.BP_SM_BindStateDelaySuicide_C")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public class BP_SM_BindStateDelaySuicide_C : UASMBindState, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602CBD8 RID: 183256 RVA: 0x00A27546 File Offset: 0x00A25746
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_BindStateDelaySuicide_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_BindStateDelaySuicide.BP_SM_BindStateDelaySuicide_C");
			}
			return BP_SM_BindStateDelaySuicide_C._ClassPtr;
		}

		// Token: 0x0602CBD9 RID: 183257 RVA: 0x00A2756C File Offset: 0x00A2576C
		public BP_SM_BindStateDelaySuicide_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_BindStateDelaySuicide_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602CBDA RID: 183258 RVA: 0x00A27594 File Offset: 0x00A25794
		[NullableContext(1)]
		public BP_SM_BindStateDelaySuicide_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_BindStateDelaySuicide_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170070A6 RID: 28838
		// (get) Token: 0x0602CBDB RID: 183259 RVA: 0x00A275C7 File Offset: 0x00A257C7
		// (set) Token: 0x0602CBDC RID: 183260 RVA: 0x00A275D7 File Offset: 0x00A257D7
		public unsafe int SuicideDelay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_BindStateDelaySuicide_C.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_BindStateDelaySuicide_C.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x170070A7 RID: 28839
		// (get) Token: 0x0602CBDD RID: 183261 RVA: 0x00A275E8 File Offset: 0x00A257E8
		// (set) Token: 0x0602CBDE RID: 183262 RVA: 0x00A275F8 File Offset: 0x00A257F8
		public unsafe int DestroyDelay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_BindStateDelaySuicide_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_BindStateDelaySuicide_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x0602CBDF RID: 183263 RVA: 0x00A27609 File Offset: 0x00A25809
		protected BP_SM_BindStateDelaySuicide_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017985 RID: 96645
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_BindStateDelaySuicide.BP_SM_BindStateDelaySuicide_C";

		// Token: 0x04017986 RID: 96646
		private static IntPtr _ClassPtr;

		// Token: 0x04017987 RID: 96647
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04017988 RID: 96648
		internal static int __PropertyOffset_0;

		// Token: 0x04017989 RID: 96649
		internal static int __PropertyOffset_1;
	}
}

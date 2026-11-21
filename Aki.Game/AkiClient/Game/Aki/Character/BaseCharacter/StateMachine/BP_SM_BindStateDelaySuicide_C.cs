using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x02003390 RID: 13200
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_BindStateDelaySuicide.BP_SM_BindStateDelaySuicide_C")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public class BP_SM_BindStateDelaySuicide_C : UASMBindState, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060217F6 RID: 137206 RVA: 0x0096239A File Offset: 0x0096059A
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_BindStateDelaySuicide_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_BindStateDelaySuicide.BP_SM_BindStateDelaySuicide_C");
			}
			return BP_SM_BindStateDelaySuicide_C._ClassPtr;
		}

		// Token: 0x060217F7 RID: 137207 RVA: 0x009623C0 File Offset: 0x009605C0
		public BP_SM_BindStateDelaySuicide_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_BindStateDelaySuicide_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060217F8 RID: 137208 RVA: 0x009623E8 File Offset: 0x009605E8
		[NullableContext(1)]
		public BP_SM_BindStateDelaySuicide_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_BindStateDelaySuicide_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170044A8 RID: 17576
		// (get) Token: 0x060217F9 RID: 137209 RVA: 0x0096241B File Offset: 0x0096061B
		// (set) Token: 0x060217FA RID: 137210 RVA: 0x0096242B File Offset: 0x0096062B
		public unsafe int SuicideDelay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_BindStateDelaySuicide_C.__PropertyOffset_SuicideDelay);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_BindStateDelaySuicide_C.__PropertyOffset_SuicideDelay) = value;
			}
		}

		// Token: 0x170044A9 RID: 17577
		// (get) Token: 0x060217FB RID: 137211 RVA: 0x0096243C File Offset: 0x0096063C
		// (set) Token: 0x060217FC RID: 137212 RVA: 0x0096244C File Offset: 0x0096064C
		public unsafe int DestroyDelay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_BindStateDelaySuicide_C.__PropertyOffset_DestroyDelay);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_BindStateDelaySuicide_C.__PropertyOffset_DestroyDelay) = value;
			}
		}

		// Token: 0x060217FD RID: 137213 RVA: 0x0096245D File Offset: 0x0096065D
		protected BP_SM_BindStateDelaySuicide_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012506 RID: 75014
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_BindStateDelaySuicide.BP_SM_BindStateDelaySuicide_C";

		// Token: 0x04012507 RID: 75015
		private static IntPtr _ClassPtr;

		// Token: 0x04012508 RID: 75016
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012509 RID: 75017
		internal static int __PropertyOffset_SuicideDelay;

		// Token: 0x0401250A RID: 75018
		internal static int __PropertyOffset_DestroyDelay;
	}
}

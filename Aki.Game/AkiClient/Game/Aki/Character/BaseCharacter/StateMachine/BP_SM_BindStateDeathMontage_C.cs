using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x0200338F RID: 13199
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_BindStateDeathMontage.BP_SM_BindStateDeathMontage_C")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class BP_SM_BindStateDeathMontage_C : UASMBindState, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060217EE RID: 137198 RVA: 0x009622C0 File Offset: 0x009604C0
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_BindStateDeathMontage_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_BindStateDeathMontage.BP_SM_BindStateDeathMontage_C");
			}
			return BP_SM_BindStateDeathMontage_C._ClassPtr;
		}

		// Token: 0x060217EF RID: 137199 RVA: 0x009622E4 File Offset: 0x009604E4
		public BP_SM_BindStateDeathMontage_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_BindStateDeathMontage_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060217F0 RID: 137200 RVA: 0x0096230C File Offset: 0x0096050C
		[NullableContext(1)]
		public BP_SM_BindStateDeathMontage_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_BindStateDeathMontage_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170044A6 RID: 17574
		// (get) Token: 0x060217F1 RID: 137201 RVA: 0x0096233F File Offset: 0x0096053F
		// (set) Token: 0x060217F2 RID: 137202 RVA: 0x00962353 File Offset: 0x00960553
		public unsafe TEnumAsByte<EMonsterDeathType> 死亡种类
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_BindStateDeathMontage_C.__PropertyOffset_死亡种类);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_BindStateDeathMontage_C.__PropertyOffset_死亡种类) = value;
			}
		}

		// Token: 0x170044A7 RID: 17575
		// (get) Token: 0x060217F3 RID: 137203 RVA: 0x00962368 File Offset: 0x00960568
		// (set) Token: 0x060217F4 RID: 137204 RVA: 0x0096237C File Offset: 0x0096057C
		[Nullable(1)]
		public unsafe string MontageName
		{
			[NullableContext(1)]
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_SM_BindStateDeathMontage_C.__PropertyOffset_MontageName)));
			}
			[NullableContext(1)]
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_SM_BindStateDeathMontage_C.__PropertyOffset_MontageName)), value);
			}
		}

		// Token: 0x060217F5 RID: 137205 RVA: 0x00962391 File Offset: 0x00960591
		protected BP_SM_BindStateDeathMontage_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012501 RID: 75009
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_BindStateDeathMontage.BP_SM_BindStateDeathMontage_C";

		// Token: 0x04012502 RID: 75010
		private static IntPtr _ClassPtr;

		// Token: 0x04012503 RID: 75011
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012504 RID: 75012
		internal static int __PropertyOffset_死亡种类;

		// Token: 0x04012505 RID: 75013
		internal static int __PropertyOffset_MontageName;
	}
}

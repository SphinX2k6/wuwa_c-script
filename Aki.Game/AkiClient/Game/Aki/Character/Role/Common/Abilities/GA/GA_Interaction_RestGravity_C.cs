using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GA;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Abilities.GA
{
	// Token: 0x02004140 RID: 16704
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Abilities/GA/GA_Interaction_RestGravity.GA_Interaction_RestGravity_C")]
	[UnrealStructLayout(1520, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1520)]
	public class GA_Interaction_RestGravity_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602B0FF RID: 176383 RVA: 0x009F49A0 File Offset: 0x009F2BA0
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Interaction_RestGravity_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Interaction_RestGravity.GA_Interaction_RestGravity_C");
			}
			return GA_Interaction_RestGravity_C._ClassPtr;
		}

		// Token: 0x0602B100 RID: 176384 RVA: 0x009F49C4 File Offset: 0x009F2BC4
		public GA_Interaction_RestGravity_C() : this(BuiltinUtils.AllocNativeUObject(GA_Interaction_RestGravity_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602B101 RID: 176385 RVA: 0x009F49EC File Offset: 0x009F2BEC
		[NullableContext(1)]
		public GA_Interaction_RestGravity_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Interaction_RestGravity_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006A11 RID: 27153
		// (get) Token: 0x0602B102 RID: 176386 RVA: 0x009F4A1F File Offset: 0x009F2C1F
		// (set) Token: 0x0602B103 RID: 176387 RVA: 0x009F4A33 File Offset: 0x009F2C33
		[Nullable(2)]
		public unsafe AActor 被控物
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Interaction_RestGravity_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Interaction_RestGravity_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x0602B104 RID: 176388 RVA: 0x009F4A48 File Offset: 0x009F2C48
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Interaction_RestGravity_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602B105 RID: 176389 RVA: 0x009F4A5C File Offset: 0x009F2C5C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Interaction_RestGravity_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602B106 RID: 176390 RVA: 0x009F4A71 File Offset: 0x009F2C71
		protected GA_Interaction_RestGravity_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016583 RID: 91523
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Interaction_RestGravity.GA_Interaction_RestGravity_C";

		// Token: 0x04016584 RID: 91524
		private static IntPtr _ClassPtr;

		// Token: 0x04016585 RID: 91525
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04016586 RID: 91526
		internal new static int __PropertyOffset_1;

		// Token: 0x04016587 RID: 91527
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;
	}
}

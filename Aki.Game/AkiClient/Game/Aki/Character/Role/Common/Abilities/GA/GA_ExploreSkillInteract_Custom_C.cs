using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GA;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Abilities.GA
{
	// Token: 0x02004132 RID: 16690
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Abilities/GA/GA_ExploreSkillInteract_Custom.GA_ExploreSkillInteract_Custom_C")]
	[UnrealStructLayout(1512, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1512)]
	public class GA_ExploreSkillInteract_Custom_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602B055 RID: 176213 RVA: 0x009F3289 File Offset: 0x009F1489
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_ExploreSkillInteract_Custom_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Abilities/GA/GA_ExploreSkillInteract_Custom.GA_ExploreSkillInteract_Custom_C");
			}
			return GA_ExploreSkillInteract_Custom_C._ClassPtr;
		}

		// Token: 0x0602B056 RID: 176214 RVA: 0x009F32B0 File Offset: 0x009F14B0
		public GA_ExploreSkillInteract_Custom_C() : this(BuiltinUtils.AllocNativeUObject(GA_ExploreSkillInteract_Custom_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602B057 RID: 176215 RVA: 0x009F32D8 File Offset: 0x009F14D8
		[NullableContext(1)]
		public GA_ExploreSkillInteract_Custom_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_ExploreSkillInteract_Custom_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602B058 RID: 176216 RVA: 0x009F330B File Offset: 0x009F150B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_ExploreSkillInteract_Custom_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602B059 RID: 176217 RVA: 0x009F331F File Offset: 0x009F151F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_ExploreSkillInteract_Custom_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602B05A RID: 176218 RVA: 0x009F3334 File Offset: 0x009F1534
		protected GA_ExploreSkillInteract_Custom_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016507 RID: 91399
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Abilities/GA/GA_ExploreSkillInteract_Custom.GA_ExploreSkillInteract_Custom_C";

		// Token: 0x04016508 RID: 91400
		private static IntPtr _ClassPtr;

		// Token: 0x04016509 RID: 91401
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401650A RID: 91402
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;
	}
}

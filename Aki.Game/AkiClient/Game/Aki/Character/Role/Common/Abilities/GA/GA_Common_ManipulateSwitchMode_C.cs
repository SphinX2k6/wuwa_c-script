using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GA;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Abilities.GA
{
	// Token: 0x02004128 RID: 16680
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Abilities/GA/GA_Common_ManipulateSwitchMode.GA_Common_ManipulateSwitchMode_C")]
	[UnrealStructLayout(1512, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1512)]
	public class GA_Common_ManipulateSwitchMode_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602AFA5 RID: 176037 RVA: 0x009F1EB5 File Offset: 0x009F00B5
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Common_ManipulateSwitchMode_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Common_ManipulateSwitchMode.GA_Common_ManipulateSwitchMode_C");
			}
			return GA_Common_ManipulateSwitchMode_C._ClassPtr;
		}

		// Token: 0x0602AFA6 RID: 176038 RVA: 0x009F1EDC File Offset: 0x009F00DC
		public GA_Common_ManipulateSwitchMode_C() : this(BuiltinUtils.AllocNativeUObject(GA_Common_ManipulateSwitchMode_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602AFA7 RID: 176039 RVA: 0x009F1F04 File Offset: 0x009F0104
		[NullableContext(1)]
		public GA_Common_ManipulateSwitchMode_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Common_ManipulateSwitchMode_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602AFA8 RID: 176040 RVA: 0x009F1F37 File Offset: 0x009F0137
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Common_ManipulateSwitchMode_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602AFA9 RID: 176041 RVA: 0x009F1F4B File Offset: 0x009F014B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Common_ManipulateSwitchMode_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602AFAA RID: 176042 RVA: 0x009F1F60 File Offset: 0x009F0160
		protected GA_Common_ManipulateSwitchMode_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016492 RID: 91282
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Common_ManipulateSwitchMode.GA_Common_ManipulateSwitchMode_C";

		// Token: 0x04016493 RID: 91283
		private static IntPtr _ClassPtr;

		// Token: 0x04016494 RID: 91284
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04016495 RID: 91285
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;
	}
}

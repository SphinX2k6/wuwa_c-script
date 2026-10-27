using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GA;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Abilities.GA
{
	// Token: 0x02004168 RID: 16744
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Abilities/GA/GA_SommonSwitchRole.GA_SommonSwitchRole_C")]
	[UnrealStructLayout(1536, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1536)]
	public class GA_SommonSwitchRole_C : Ga_Passive_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602B4D1 RID: 177361 RVA: 0x009FC124 File Offset: 0x009FA324
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_SommonSwitchRole_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Abilities/GA/GA_SommonSwitchRole.GA_SommonSwitchRole_C");
			}
			return GA_SommonSwitchRole_C._ClassPtr;
		}

		// Token: 0x0602B4D2 RID: 177362 RVA: 0x009FC148 File Offset: 0x009FA348
		public GA_SommonSwitchRole_C() : this(BuiltinUtils.AllocNativeUObject(GA_SommonSwitchRole_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602B4D3 RID: 177363 RVA: 0x009FC170 File Offset: 0x009FA370
		[NullableContext(1)]
		public GA_SommonSwitchRole_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_SommonSwitchRole_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006AD1 RID: 27345
		// (get) Token: 0x0602B4D4 RID: 177364 RVA: 0x009FC1A3 File Offset: 0x009FA3A3
		// (set) Token: 0x0602B4D5 RID: 177365 RVA: 0x009FC1B7 File Offset: 0x009FA3B7
		[Nullable(2)]
		public unsafe UObject 变身开始_材质特效
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UObject>(base.NativePtr / (IntPtr)sizeof(void*) + GA_SommonSwitchRole_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_SommonSwitchRole_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x0602B4D6 RID: 177366 RVA: 0x009FC1CC File Offset: 0x009FA3CC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_SommonSwitchRole_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602B4D7 RID: 177367 RVA: 0x009FC1E0 File Offset: 0x009FA3E0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_SommonSwitchRole_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602B4D8 RID: 177368 RVA: 0x009FC1F5 File Offset: 0x009FA3F5
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void CustomEvent_0()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_SommonSwitchRole_C.__CustomEvent_0_NativeFunctionPtr, null);
		}

		// Token: 0x0602B4D9 RID: 177369 RVA: 0x009FC209 File Offset: 0x009FA409
		protected GA_SommonSwitchRole_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401682B RID: 92203
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Abilities/GA/GA_SommonSwitchRole.GA_SommonSwitchRole_C";

		// Token: 0x0401682C RID: 92204
		private static IntPtr _ClassPtr;

		// Token: 0x0401682D RID: 92205
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401682E RID: 92206
		internal new static int __PropertyOffset_1;

		// Token: 0x0401682F RID: 92207
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x04016830 RID: 92208
		private static IntPtr __CustomEvent_0_NativeFunctionPtr;
	}
}

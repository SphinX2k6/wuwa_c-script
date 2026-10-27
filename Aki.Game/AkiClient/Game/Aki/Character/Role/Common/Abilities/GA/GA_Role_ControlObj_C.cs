using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GA;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Abilities.GA
{
	// Token: 0x0200414E RID: 16718
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Abilities/GA/GA_Role_ControlObj.GA_Role_ControlObj_C")]
	[UnrealStructLayout(1520, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1520)]
	public class GA_Role_ControlObj_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602B1BC RID: 176572 RVA: 0x009F6199 File Offset: 0x009F4399
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Role_ControlObj_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Role_ControlObj.GA_Role_ControlObj_C");
			}
			return GA_Role_ControlObj_C._ClassPtr;
		}

		// Token: 0x0602B1BD RID: 176573 RVA: 0x009F61C0 File Offset: 0x009F43C0
		public GA_Role_ControlObj_C() : this(BuiltinUtils.AllocNativeUObject(GA_Role_ControlObj_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602B1BE RID: 176574 RVA: 0x009F61E8 File Offset: 0x009F43E8
		[NullableContext(1)]
		public GA_Role_ControlObj_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Role_ControlObj_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006A25 RID: 27173
		// (get) Token: 0x0602B1BF RID: 176575 RVA: 0x009F621B File Offset: 0x009F441B
		// (set) Token: 0x0602B1C0 RID: 176576 RVA: 0x009F622F File Offset: 0x009F442F
		[Nullable(2)]
		public unsafe UPhysicsHandleComponent Physics_Handle
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPhysicsHandleComponent>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Role_ControlObj_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Role_ControlObj_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x0602B1C1 RID: 176577 RVA: 0x009F6244 File Offset: 0x009F4444
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_ControlObj_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602B1C2 RID: 176578 RVA: 0x009F6258 File Offset: 0x009F4458
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Role_ControlObj_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602B1C3 RID: 176579 RVA: 0x009F626D File Offset: 0x009F446D
		protected GA_Role_ControlObj_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016606 RID: 91654
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Role_ControlObj.GA_Role_ControlObj_C";

		// Token: 0x04016607 RID: 91655
		private static IntPtr _ClassPtr;

		// Token: 0x04016608 RID: 91656
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04016609 RID: 91657
		internal new static int __PropertyOffset_1;

		// Token: 0x0401660A RID: 91658
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;
	}
}

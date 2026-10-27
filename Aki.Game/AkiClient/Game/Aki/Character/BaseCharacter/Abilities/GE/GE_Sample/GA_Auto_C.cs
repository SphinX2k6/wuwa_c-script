using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GE.GE_Sample
{
	// Token: 0x020043EC RID: 17388
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Sample/GA_Auto.GA_Auto_C")]
	[UnrealStructLayout(992, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 992)]
	public class GA_Auto_C : UBaseGameplayAbility, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602D0A6 RID: 184486 RVA: 0x00A2F2E4 File Offset: 0x00A2D4E4
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Auto_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Sample/GA_Auto.GA_Auto_C");
			}
			return GA_Auto_C._ClassPtr;
		}

		// Token: 0x0602D0A7 RID: 184487 RVA: 0x00A2F308 File Offset: 0x00A2D508
		public GA_Auto_C() : this(BuiltinUtils.AllocNativeUObject(GA_Auto_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602D0A8 RID: 184488 RVA: 0x00A2F330 File Offset: 0x00A2D530
		[NullableContext(1)]
		public GA_Auto_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Auto_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007225 RID: 29221
		// (get) Token: 0x0602D0A9 RID: 184489 RVA: 0x00A2F363 File Offset: 0x00A2D563
		// (set) Token: 0x0602D0AA RID: 184490 RVA: 0x00A2F377 File Offset: 0x00A2D577
		[Nullable(2)]
		public unsafe TsBaseCharacter 角色
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<TsBaseCharacter>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Auto_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Auto_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x0602D0AB RID: 184491 RVA: 0x00A2F38C File Offset: 0x00A2D58C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Auto_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602D0AC RID: 184492 RVA: 0x00A2F3A0 File Offset: 0x00A2D5A0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Auto_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602D0AD RID: 184493 RVA: 0x00A2F3B5 File Offset: 0x00A2D5B5
		protected GA_Auto_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017E75 RID: 97909
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Sample/GA_Auto.GA_Auto_C";

		// Token: 0x04017E76 RID: 97910
		private static IntPtr _ClassPtr;

		// Token: 0x04017E77 RID: 97911
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04017E78 RID: 97912
		internal static int __PropertyOffset_1;

		// Token: 0x04017E79 RID: 97913
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;
	}
}

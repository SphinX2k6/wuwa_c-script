using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x0200438D RID: 17293
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_InstanceBase.BP_SM_InstanceBase_C")]
	[UnrealStructLayout(1584, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1584)]
	public class BP_SM_InstanceBase_C : USMInstance, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602CCB4 RID: 183476 RVA: 0x00A28CA0 File Offset: 0x00A26EA0
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_InstanceBase_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_InstanceBase.BP_SM_InstanceBase_C");
			}
			return BP_SM_InstanceBase_C._ClassPtr;
		}

		// Token: 0x0602CCB5 RID: 183477 RVA: 0x00A28CC4 File Offset: 0x00A26EC4
		public BP_SM_InstanceBase_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_InstanceBase_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602CCB6 RID: 183478 RVA: 0x00A28CEC File Offset: 0x00A26EEC
		public BP_SM_InstanceBase_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_InstanceBase_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170070D8 RID: 28888
		// (get) Token: 0x0602CCB7 RID: 183479 RVA: 0x00A28D20 File Offset: 0x00A26F20
		// (set) Token: 0x0602CCB8 RID: 183480 RVA: 0x00A28D59 File Offset: 0x00A26F59
		public TArray<USMStateMachineInstance> Fsm
		{
			get
			{
				base.FastCheckIsValid();
				TArray<USMStateMachineInstance> result;
				if ((result = this._Fsm) == null)
				{
					result = (this._Fsm = new TArray<USMStateMachineInstance>(base.NativePtr + (IntPtr)BP_SM_InstanceBase_C.__PropertyOffset_1, this));
				}
				return result;
			}
			set
			{
				this.Fsm.CopyAssign(value);
			}
		}

		// Token: 0x0602CCB9 RID: 183481 RVA: 0x00A28D67 File Offset: 0x00A26F67
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void OnPostCompile()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SM_InstanceBase_C.__OnPostCompile_NativeFunctionPtr, null);
		}

		// Token: 0x0602CCBA RID: 183482 RVA: 0x00A28D7B File Offset: 0x00A26F7B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void OnPostCompile_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SM_InstanceBase_C.__OnPostCompile_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602CCBB RID: 183483 RVA: 0x00A28D90 File Offset: 0x00A26F90
		protected BP_SM_InstanceBase_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017A12 RID: 96786
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_InstanceBase.BP_SM_InstanceBase_C";

		// Token: 0x04017A13 RID: 96787
		private static IntPtr _ClassPtr;

		// Token: 0x04017A14 RID: 96788
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04017A15 RID: 96789
		internal static int __PropertyOffset_1;

		// Token: 0x04017A16 RID: 96790
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<USMStateMachineInstance> _Fsm;

		// Token: 0x04017A17 RID: 96791
		private static IntPtr __OnPostCompile_NativeFunctionPtr;
	}
}

using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GA;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Abilities.GA
{
	// Token: 0x0200417E RID: 16766
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Abilities/GA/GA_SwitchBlackHoleState.GA_SwitchBlackHoleState_C")]
	[UnrealStructLayout(1512, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1512)]
	public class GA_SwitchBlackHoleState_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602B6A4 RID: 177828 RVA: 0x009FFFBC File Offset: 0x009FE1BC
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_SwitchBlackHoleState_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Abilities/GA/GA_SwitchBlackHoleState.GA_SwitchBlackHoleState_C");
			}
			return GA_SwitchBlackHoleState_C._ClassPtr;
		}

		// Token: 0x0602B6A5 RID: 177829 RVA: 0x009FFFE0 File Offset: 0x009FE1E0
		public GA_SwitchBlackHoleState_C() : this(BuiltinUtils.AllocNativeUObject(GA_SwitchBlackHoleState_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602B6A6 RID: 177830 RVA: 0x00A00008 File Offset: 0x009FE208
		[NullableContext(1)]
		public GA_SwitchBlackHoleState_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_SwitchBlackHoleState_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602B6A7 RID: 177831 RVA: 0x00A0003B File Offset: 0x009FE23B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_SwitchBlackHoleState_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602B6A8 RID: 177832 RVA: 0x00A0004F File Offset: 0x009FE24F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_SwitchBlackHoleState_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602B6A9 RID: 177833 RVA: 0x00A00064 File Offset: 0x009FE264
		protected GA_SwitchBlackHoleState_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401697E RID: 92542
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Abilities/GA/GA_SwitchBlackHoleState.GA_SwitchBlackHoleState_C";

		// Token: 0x0401697F RID: 92543
		private static IntPtr _ClassPtr;

		// Token: 0x04016980 RID: 92544
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04016981 RID: 92545
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;
	}
}

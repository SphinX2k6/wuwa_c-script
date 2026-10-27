using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Monster.Common.Abilities.GA;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA058.Ability
{
	// Token: 0x020041DD RID: 16861
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA058/Ability/GA_SetHateTargetFromBB.GA_SetHateTargetFromBB_C")]
	[UnrealStructLayout(1536, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1536)]
	public class GA_SetHateTargetFromBB_C : GA_Monster_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BD28 RID: 179496 RVA: 0x00A0B8B4 File Offset: 0x00A09AB4
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_SetHateTargetFromBB_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA058/Ability/GA_SetHateTargetFromBB.GA_SetHateTargetFromBB_C");
			}
			return GA_SetHateTargetFromBB_C._ClassPtr;
		}

		// Token: 0x0602BD29 RID: 179497 RVA: 0x00A0B8D8 File Offset: 0x00A09AD8
		public GA_SetHateTargetFromBB_C() : this(BuiltinUtils.AllocNativeUObject(GA_SetHateTargetFromBB_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BD2A RID: 179498 RVA: 0x00A0B900 File Offset: 0x00A09B00
		[NullableContext(1)]
		public GA_SetHateTargetFromBB_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_SetHateTargetFromBB_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BD2B RID: 179499 RVA: 0x00A0B933 File Offset: 0x00A09B33
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_5D118C384AE61F1C80292E8186A81D26()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_SetHateTargetFromBB_C.__OnTick_5D118C384AE61F1C80292E8186A81D26_NativeFunctionPtr, null);
		}

		// Token: 0x0602BD2C RID: 179500 RVA: 0x00A0B947 File Offset: 0x00A09B47
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCancelled_5D118C384AE61F1C80292E8186A81D26()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_SetHateTargetFromBB_C.__OnCancelled_5D118C384AE61F1C80292E8186A81D26_NativeFunctionPtr, null);
		}

		// Token: 0x0602BD2D RID: 179501 RVA: 0x00A0B95B File Offset: 0x00A09B5B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnInterrupted_5D118C384AE61F1C80292E8186A81D26()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_SetHateTargetFromBB_C.__OnInterrupted_5D118C384AE61F1C80292E8186A81D26_NativeFunctionPtr, null);
		}

		// Token: 0x0602BD2E RID: 179502 RVA: 0x00A0B96F File Offset: 0x00A09B6F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnBlendOut_5D118C384AE61F1C80292E8186A81D26()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_SetHateTargetFromBB_C.__OnBlendOut_5D118C384AE61F1C80292E8186A81D26_NativeFunctionPtr, null);
		}

		// Token: 0x0602BD2F RID: 179503 RVA: 0x00A0B983 File Offset: 0x00A09B83
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCompleted_5D118C384AE61F1C80292E8186A81D26()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_SetHateTargetFromBB_C.__OnCompleted_5D118C384AE61F1C80292E8186A81D26_NativeFunctionPtr, null);
		}

		// Token: 0x0602BD30 RID: 179504 RVA: 0x00A0B997 File Offset: 0x00A09B97
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_SetHateTargetFromBB_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602BD31 RID: 179505 RVA: 0x00A0B9AB File Offset: 0x00A09BAB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_SetHateTargetFromBB_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602BD32 RID: 179506 RVA: 0x00A0B9C0 File Offset: 0x00A09BC0
		protected GA_SetHateTargetFromBB_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016DAA RID: 93610
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA058/Ability/GA_SetHateTargetFromBB.GA_SetHateTargetFromBB_C";

		// Token: 0x04016DAB RID: 93611
		private static IntPtr _ClassPtr;

		// Token: 0x04016DAC RID: 93612
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04016DAD RID: 93613
		private static IntPtr __OnTick_5D118C384AE61F1C80292E8186A81D26_NativeFunctionPtr;

		// Token: 0x04016DAE RID: 93614
		private static IntPtr __OnCancelled_5D118C384AE61F1C80292E8186A81D26_NativeFunctionPtr;

		// Token: 0x04016DAF RID: 93615
		private static IntPtr __OnInterrupted_5D118C384AE61F1C80292E8186A81D26_NativeFunctionPtr;

		// Token: 0x04016DB0 RID: 93616
		private static IntPtr __OnBlendOut_5D118C384AE61F1C80292E8186A81D26_NativeFunctionPtr;

		// Token: 0x04016DB1 RID: 93617
		private static IntPtr __OnCompleted_5D118C384AE61F1C80292E8186A81D26_NativeFunctionPtr;

		// Token: 0x04016DB2 RID: 93618
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;
	}
}

using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GA;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Abilities.GA
{
	// Token: 0x02004141 RID: 16705
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Abilities/GA/GA_Interaction_StandControl.GA_Interaction_StandControl_C")]
	[UnrealStructLayout(1520, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1520)]
	public class GA_Interaction_StandControl_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602B107 RID: 176391 RVA: 0x009F4A7A File Offset: 0x009F2C7A
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Interaction_StandControl_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Interaction_StandControl.GA_Interaction_StandControl_C");
			}
			return GA_Interaction_StandControl_C._ClassPtr;
		}

		// Token: 0x0602B108 RID: 176392 RVA: 0x009F4AA0 File Offset: 0x009F2CA0
		public GA_Interaction_StandControl_C() : this(BuiltinUtils.AllocNativeUObject(GA_Interaction_StandControl_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602B109 RID: 176393 RVA: 0x009F4AC8 File Offset: 0x009F2CC8
		[NullableContext(1)]
		public GA_Interaction_StandControl_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Interaction_StandControl_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006A12 RID: 27154
		// (get) Token: 0x0602B10A RID: 176394 RVA: 0x009F4AFB File Offset: 0x009F2CFB
		// (set) Token: 0x0602B10B RID: 176395 RVA: 0x009F4B0F File Offset: 0x009F2D0F
		[Nullable(2)]
		public unsafe AActor 被控物
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Interaction_StandControl_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Interaction_StandControl_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x0602B10C RID: 176396 RVA: 0x009F4B24 File Offset: 0x009F2D24
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_5D118C384AE61F1C80292E8166FD408C()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Interaction_StandControl_C.__OnTick_5D118C384AE61F1C80292E8166FD408C_NativeFunctionPtr, null);
		}

		// Token: 0x0602B10D RID: 176397 RVA: 0x009F4B38 File Offset: 0x009F2D38
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCancelled_5D118C384AE61F1C80292E8166FD408C()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Interaction_StandControl_C.__OnCancelled_5D118C384AE61F1C80292E8166FD408C_NativeFunctionPtr, null);
		}

		// Token: 0x0602B10E RID: 176398 RVA: 0x009F4B4C File Offset: 0x009F2D4C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnInterrupted_5D118C384AE61F1C80292E8166FD408C()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Interaction_StandControl_C.__OnInterrupted_5D118C384AE61F1C80292E8166FD408C_NativeFunctionPtr, null);
		}

		// Token: 0x0602B10F RID: 176399 RVA: 0x009F4B60 File Offset: 0x009F2D60
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnBlendOut_5D118C384AE61F1C80292E8166FD408C()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Interaction_StandControl_C.__OnBlendOut_5D118C384AE61F1C80292E8166FD408C_NativeFunctionPtr, null);
		}

		// Token: 0x0602B110 RID: 176400 RVA: 0x009F4B74 File Offset: 0x009F2D74
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCompleted_5D118C384AE61F1C80292E8166FD408C()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Interaction_StandControl_C.__OnCompleted_5D118C384AE61F1C80292E8166FD408C_NativeFunctionPtr, null);
		}

		// Token: 0x0602B111 RID: 176401 RVA: 0x009F4B88 File Offset: 0x009F2D88
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_5D118C384AE61F1C80292E81AD69BEF1()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Interaction_StandControl_C.__OnTick_5D118C384AE61F1C80292E81AD69BEF1_NativeFunctionPtr, null);
		}

		// Token: 0x0602B112 RID: 176402 RVA: 0x009F4B9C File Offset: 0x009F2D9C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCancelled_5D118C384AE61F1C80292E81AD69BEF1()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Interaction_StandControl_C.__OnCancelled_5D118C384AE61F1C80292E81AD69BEF1_NativeFunctionPtr, null);
		}

		// Token: 0x0602B113 RID: 176403 RVA: 0x009F4BB0 File Offset: 0x009F2DB0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnInterrupted_5D118C384AE61F1C80292E81AD69BEF1()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Interaction_StandControl_C.__OnInterrupted_5D118C384AE61F1C80292E81AD69BEF1_NativeFunctionPtr, null);
		}

		// Token: 0x0602B114 RID: 176404 RVA: 0x009F4BC4 File Offset: 0x009F2DC4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnBlendOut_5D118C384AE61F1C80292E81AD69BEF1()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Interaction_StandControl_C.__OnBlendOut_5D118C384AE61F1C80292E81AD69BEF1_NativeFunctionPtr, null);
		}

		// Token: 0x0602B115 RID: 176405 RVA: 0x009F4BD8 File Offset: 0x009F2DD8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCompleted_5D118C384AE61F1C80292E81AD69BEF1()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Interaction_StandControl_C.__OnCompleted_5D118C384AE61F1C80292E81AD69BEF1_NativeFunctionPtr, null);
		}

		// Token: 0x0602B116 RID: 176406 RVA: 0x009F4BEC File Offset: 0x009F2DEC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Interaction_StandControl_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602B117 RID: 176407 RVA: 0x009F4C00 File Offset: 0x009F2E00
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Interaction_StandControl_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602B118 RID: 176408 RVA: 0x009F4C15 File Offset: 0x009F2E15
		protected GA_Interaction_StandControl_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016588 RID: 91528
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Interaction_StandControl.GA_Interaction_StandControl_C";

		// Token: 0x04016589 RID: 91529
		private static IntPtr _ClassPtr;

		// Token: 0x0401658A RID: 91530
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401658B RID: 91531
		internal new static int __PropertyOffset_1;

		// Token: 0x0401658C RID: 91532
		private static IntPtr __OnTick_5D118C384AE61F1C80292E8166FD408C_NativeFunctionPtr;

		// Token: 0x0401658D RID: 91533
		private static IntPtr __OnCancelled_5D118C384AE61F1C80292E8166FD408C_NativeFunctionPtr;

		// Token: 0x0401658E RID: 91534
		private static IntPtr __OnInterrupted_5D118C384AE61F1C80292E8166FD408C_NativeFunctionPtr;

		// Token: 0x0401658F RID: 91535
		private static IntPtr __OnBlendOut_5D118C384AE61F1C80292E8166FD408C_NativeFunctionPtr;

		// Token: 0x04016590 RID: 91536
		private static IntPtr __OnCompleted_5D118C384AE61F1C80292E8166FD408C_NativeFunctionPtr;

		// Token: 0x04016591 RID: 91537
		private static IntPtr __OnTick_5D118C384AE61F1C80292E81AD69BEF1_NativeFunctionPtr;

		// Token: 0x04016592 RID: 91538
		private static IntPtr __OnCancelled_5D118C384AE61F1C80292E81AD69BEF1_NativeFunctionPtr;

		// Token: 0x04016593 RID: 91539
		private static IntPtr __OnInterrupted_5D118C384AE61F1C80292E81AD69BEF1_NativeFunctionPtr;

		// Token: 0x04016594 RID: 91540
		private static IntPtr __OnBlendOut_5D118C384AE61F1C80292E81AD69BEF1_NativeFunctionPtr;

		// Token: 0x04016595 RID: 91541
		private static IntPtr __OnCompleted_5D118C384AE61F1C80292E81AD69BEF1_NativeFunctionPtr;

		// Token: 0x04016596 RID: 91542
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;
	}
}

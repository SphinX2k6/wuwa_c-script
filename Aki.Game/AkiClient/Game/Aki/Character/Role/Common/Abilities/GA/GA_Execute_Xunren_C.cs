using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GA;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Abilities.GA
{
	// Token: 0x02004130 RID: 16688
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Abilities/GA/GA_Execute_Xunren.GA_Execute_Xunren_C")]
	[UnrealStructLayout(1536, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1536)]
	public class GA_Execute_Xunren_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602B02B RID: 176171 RVA: 0x009F2E21 File Offset: 0x009F1021
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Execute_Xunren_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Execute_Xunren.GA_Execute_Xunren_C");
			}
			return GA_Execute_Xunren_C._ClassPtr;
		}

		// Token: 0x0602B02C RID: 176172 RVA: 0x009F2E48 File Offset: 0x009F1048
		public GA_Execute_Xunren_C() : this(BuiltinUtils.AllocNativeUObject(GA_Execute_Xunren_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602B02D RID: 176173 RVA: 0x009F2E70 File Offset: 0x009F1070
		[NullableContext(1)]
		public GA_Execute_Xunren_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Execute_Xunren_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170069FD RID: 27133
		// (get) Token: 0x0602B02E RID: 176174 RVA: 0x009F2EA3 File Offset: 0x009F10A3
		// (set) Token: 0x0602B02F RID: 176175 RVA: 0x009F2EB3 File Offset: 0x009F10B3
		public unsafe bool 落地攻击
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Execute_Xunren_C.__PropertyOffset_1) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Execute_Xunren_C.__PropertyOffset_1) = (value ? 1 : 0);
			}
		}

		// Token: 0x170069FE RID: 27134
		// (get) Token: 0x0602B030 RID: 176176 RVA: 0x009F2EC4 File Offset: 0x009F10C4
		// (set) Token: 0x0602B031 RID: 176177 RVA: 0x009F2ED4 File Offset: 0x009F10D4
		public unsafe float BlockTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Execute_Xunren_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Execute_Xunren_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x170069FF RID: 27135
		// (get) Token: 0x0602B032 RID: 176178 RVA: 0x009F2EE5 File Offset: 0x009F10E5
		// (set) Token: 0x0602B033 RID: 176179 RVA: 0x009F2EF9 File Offset: 0x009F10F9
		public unsafe FName 追踪插槽
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Execute_Xunren_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Execute_Xunren_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17006A00 RID: 27136
		// (get) Token: 0x0602B034 RID: 176180 RVA: 0x009F2F0E File Offset: 0x009F110E
		// (set) Token: 0x0602B035 RID: 176181 RVA: 0x009F2F1E File Offset: 0x009F111E
		public unsafe int 特效Handle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Execute_Xunren_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Execute_Xunren_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x0602B036 RID: 176182 RVA: 0x009F2F2F File Offset: 0x009F112F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_5D118C384AE61F1C80292E81FF123CC3()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Execute_Xunren_C.__OnTick_5D118C384AE61F1C80292E81FF123CC3_NativeFunctionPtr, null);
		}

		// Token: 0x0602B037 RID: 176183 RVA: 0x009F2F43 File Offset: 0x009F1143
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCancelled_5D118C384AE61F1C80292E81FF123CC3()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Execute_Xunren_C.__OnCancelled_5D118C384AE61F1C80292E81FF123CC3_NativeFunctionPtr, null);
		}

		// Token: 0x0602B038 RID: 176184 RVA: 0x009F2F57 File Offset: 0x009F1157
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnInterrupted_5D118C384AE61F1C80292E81FF123CC3()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Execute_Xunren_C.__OnInterrupted_5D118C384AE61F1C80292E81FF123CC3_NativeFunctionPtr, null);
		}

		// Token: 0x0602B039 RID: 176185 RVA: 0x009F2F6B File Offset: 0x009F116B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnBlendOut_5D118C384AE61F1C80292E81FF123CC3()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Execute_Xunren_C.__OnBlendOut_5D118C384AE61F1C80292E81FF123CC3_NativeFunctionPtr, null);
		}

		// Token: 0x0602B03A RID: 176186 RVA: 0x009F2F7F File Offset: 0x009F117F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCompleted_5D118C384AE61F1C80292E81FF123CC3()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Execute_Xunren_C.__OnCompleted_5D118C384AE61F1C80292E81FF123CC3_NativeFunctionPtr, null);
		}

		// Token: 0x0602B03B RID: 176187 RVA: 0x009F2F94 File Offset: 0x009F1194
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_Execute_Xunren_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Execute_Xunren_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Execute_Xunren_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Execute_Xunren_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Execute_Xunren_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B03C RID: 176188 RVA: 0x009F2FDC File Offset: 0x009F11DC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_Execute_Xunren_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Execute_Xunren_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Execute_Xunren_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Execute_Xunren_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Execute_Xunren_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602B03D RID: 176189 RVA: 0x009F3023 File Offset: 0x009F1223
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Execute_Xunren_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602B03E RID: 176190 RVA: 0x009F3037 File Offset: 0x009F1237
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Execute_Xunren_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602B03F RID: 176191 RVA: 0x009F304C File Offset: 0x009F124C
		protected GA_Execute_Xunren_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040164EB RID: 91371
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Execute_Xunren.GA_Execute_Xunren_C";

		// Token: 0x040164EC RID: 91372
		private static IntPtr _ClassPtr;

		// Token: 0x040164ED RID: 91373
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040164EE RID: 91374
		internal new static int __PropertyOffset_1;

		// Token: 0x040164EF RID: 91375
		internal new static int __PropertyOffset_2;

		// Token: 0x040164F0 RID: 91376
		internal new static int __PropertyOffset_3;

		// Token: 0x040164F1 RID: 91377
		internal static int __PropertyOffset_4;

		// Token: 0x040164F2 RID: 91378
		private static IntPtr __OnTick_5D118C384AE61F1C80292E81FF123CC3_NativeFunctionPtr;

		// Token: 0x040164F3 RID: 91379
		private static IntPtr __OnCancelled_5D118C384AE61F1C80292E81FF123CC3_NativeFunctionPtr;

		// Token: 0x040164F4 RID: 91380
		private static IntPtr __OnInterrupted_5D118C384AE61F1C80292E81FF123CC3_NativeFunctionPtr;

		// Token: 0x040164F5 RID: 91381
		private static IntPtr __OnBlendOut_5D118C384AE61F1C80292E81FF123CC3_NativeFunctionPtr;

		// Token: 0x040164F6 RID: 91382
		private static IntPtr __OnCompleted_5D118C384AE61F1C80292E81FF123CC3_NativeFunctionPtr;

		// Token: 0x040164F7 RID: 91383
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x040164F8 RID: 91384
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x0200A45E RID: 42078
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x040322A2 RID: 205474
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}

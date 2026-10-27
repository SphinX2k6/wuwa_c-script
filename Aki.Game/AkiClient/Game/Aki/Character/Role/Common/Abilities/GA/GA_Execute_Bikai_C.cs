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
	// Token: 0x0200412D RID: 16685
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Abilities/GA/GA_Execute_Bikai.GA_Execute_Bikai_C")]
	[UnrealStructLayout(1536, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1536)]
	public class GA_Execute_Bikai_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602AFEC RID: 176108 RVA: 0x009F2788 File Offset: 0x009F0988
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Execute_Bikai_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Execute_Bikai.GA_Execute_Bikai_C");
			}
			return GA_Execute_Bikai_C._ClassPtr;
		}

		// Token: 0x0602AFED RID: 176109 RVA: 0x009F27AC File Offset: 0x009F09AC
		public GA_Execute_Bikai_C() : this(BuiltinUtils.AllocNativeUObject(GA_Execute_Bikai_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602AFEE RID: 176110 RVA: 0x009F27D4 File Offset: 0x009F09D4
		[NullableContext(1)]
		public GA_Execute_Bikai_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Execute_Bikai_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170069F1 RID: 27121
		// (get) Token: 0x0602AFEF RID: 176111 RVA: 0x009F2807 File Offset: 0x009F0A07
		// (set) Token: 0x0602AFF0 RID: 176112 RVA: 0x009F2817 File Offset: 0x009F0A17
		public unsafe bool 落地攻击
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Execute_Bikai_C.__PropertyOffset_1) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Execute_Bikai_C.__PropertyOffset_1) = (value ? 1 : 0);
			}
		}

		// Token: 0x170069F2 RID: 27122
		// (get) Token: 0x0602AFF1 RID: 176113 RVA: 0x009F2828 File Offset: 0x009F0A28
		// (set) Token: 0x0602AFF2 RID: 176114 RVA: 0x009F2838 File Offset: 0x009F0A38
		public unsafe float BlockTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Execute_Bikai_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Execute_Bikai_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x170069F3 RID: 27123
		// (get) Token: 0x0602AFF3 RID: 176115 RVA: 0x009F2849 File Offset: 0x009F0A49
		// (set) Token: 0x0602AFF4 RID: 176116 RVA: 0x009F285D File Offset: 0x009F0A5D
		public unsafe FName 追踪插槽
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Execute_Bikai_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Execute_Bikai_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x170069F4 RID: 27124
		// (get) Token: 0x0602AFF5 RID: 176117 RVA: 0x009F2872 File Offset: 0x009F0A72
		// (set) Token: 0x0602AFF6 RID: 176118 RVA: 0x009F2882 File Offset: 0x009F0A82
		public unsafe int 特效Handle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Execute_Bikai_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Execute_Bikai_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x0602AFF7 RID: 176119 RVA: 0x009F2893 File Offset: 0x009F0A93
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_5D118C384AE61F1C80292E81152A15CB()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Execute_Bikai_C.__OnTick_5D118C384AE61F1C80292E81152A15CB_NativeFunctionPtr, null);
		}

		// Token: 0x0602AFF8 RID: 176120 RVA: 0x009F28A7 File Offset: 0x009F0AA7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCancelled_5D118C384AE61F1C80292E81152A15CB()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Execute_Bikai_C.__OnCancelled_5D118C384AE61F1C80292E81152A15CB_NativeFunctionPtr, null);
		}

		// Token: 0x0602AFF9 RID: 176121 RVA: 0x009F28BB File Offset: 0x009F0ABB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnInterrupted_5D118C384AE61F1C80292E81152A15CB()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Execute_Bikai_C.__OnInterrupted_5D118C384AE61F1C80292E81152A15CB_NativeFunctionPtr, null);
		}

		// Token: 0x0602AFFA RID: 176122 RVA: 0x009F28CF File Offset: 0x009F0ACF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnBlendOut_5D118C384AE61F1C80292E81152A15CB()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Execute_Bikai_C.__OnBlendOut_5D118C384AE61F1C80292E81152A15CB_NativeFunctionPtr, null);
		}

		// Token: 0x0602AFFB RID: 176123 RVA: 0x009F28E3 File Offset: 0x009F0AE3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCompleted_5D118C384AE61F1C80292E81152A15CB()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Execute_Bikai_C.__OnCompleted_5D118C384AE61F1C80292E81152A15CB_NativeFunctionPtr, null);
		}

		// Token: 0x0602AFFC RID: 176124 RVA: 0x009F28F8 File Offset: 0x009F0AF8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_Execute_Bikai_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Execute_Bikai_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Execute_Bikai_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Execute_Bikai_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Execute_Bikai_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602AFFD RID: 176125 RVA: 0x009F2940 File Offset: 0x009F0B40
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_Execute_Bikai_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Execute_Bikai_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Execute_Bikai_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Execute_Bikai_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Execute_Bikai_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602AFFE RID: 176126 RVA: 0x009F2987 File Offset: 0x009F0B87
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Execute_Bikai_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602AFFF RID: 176127 RVA: 0x009F299B File Offset: 0x009F0B9B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Execute_Bikai_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602B000 RID: 176128 RVA: 0x009F29B0 File Offset: 0x009F0BB0
		protected GA_Execute_Bikai_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040164C1 RID: 91329
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Execute_Bikai.GA_Execute_Bikai_C";

		// Token: 0x040164C2 RID: 91330
		private static IntPtr _ClassPtr;

		// Token: 0x040164C3 RID: 91331
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040164C4 RID: 91332
		internal new static int __PropertyOffset_1;

		// Token: 0x040164C5 RID: 91333
		internal new static int __PropertyOffset_2;

		// Token: 0x040164C6 RID: 91334
		internal new static int __PropertyOffset_3;

		// Token: 0x040164C7 RID: 91335
		internal static int __PropertyOffset_4;

		// Token: 0x040164C8 RID: 91336
		private static IntPtr __OnTick_5D118C384AE61F1C80292E81152A15CB_NativeFunctionPtr;

		// Token: 0x040164C9 RID: 91337
		private static IntPtr __OnCancelled_5D118C384AE61F1C80292E81152A15CB_NativeFunctionPtr;

		// Token: 0x040164CA RID: 91338
		private static IntPtr __OnInterrupted_5D118C384AE61F1C80292E81152A15CB_NativeFunctionPtr;

		// Token: 0x040164CB RID: 91339
		private static IntPtr __OnBlendOut_5D118C384AE61F1C80292E81152A15CB_NativeFunctionPtr;

		// Token: 0x040164CC RID: 91340
		private static IntPtr __OnCompleted_5D118C384AE61F1C80292E81152A15CB_NativeFunctionPtr;

		// Token: 0x040164CD RID: 91341
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x040164CE RID: 91342
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x0200A45B RID: 42075
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x0403229F RID: 205471
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}

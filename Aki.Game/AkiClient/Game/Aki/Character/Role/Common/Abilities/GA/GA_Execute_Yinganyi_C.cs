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
	// Token: 0x02004131 RID: 16689
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Abilities/GA/GA_Execute_Yinganyi.GA_Execute_Yinganyi_C")]
	[UnrealStructLayout(1536, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1536)]
	public class GA_Execute_Yinganyi_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602B040 RID: 176192 RVA: 0x009F3055 File Offset: 0x009F1255
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Execute_Yinganyi_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Execute_Yinganyi.GA_Execute_Yinganyi_C");
			}
			return GA_Execute_Yinganyi_C._ClassPtr;
		}

		// Token: 0x0602B041 RID: 176193 RVA: 0x009F307C File Offset: 0x009F127C
		public GA_Execute_Yinganyi_C() : this(BuiltinUtils.AllocNativeUObject(GA_Execute_Yinganyi_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602B042 RID: 176194 RVA: 0x009F30A4 File Offset: 0x009F12A4
		[NullableContext(1)]
		public GA_Execute_Yinganyi_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Execute_Yinganyi_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006A01 RID: 27137
		// (get) Token: 0x0602B043 RID: 176195 RVA: 0x009F30D7 File Offset: 0x009F12D7
		// (set) Token: 0x0602B044 RID: 176196 RVA: 0x009F30E7 File Offset: 0x009F12E7
		public unsafe bool 落地攻击
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Execute_Yinganyi_C.__PropertyOffset_1) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Execute_Yinganyi_C.__PropertyOffset_1) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006A02 RID: 27138
		// (get) Token: 0x0602B045 RID: 176197 RVA: 0x009F30F8 File Offset: 0x009F12F8
		// (set) Token: 0x0602B046 RID: 176198 RVA: 0x009F3108 File Offset: 0x009F1308
		public unsafe float BlockTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Execute_Yinganyi_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Execute_Yinganyi_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17006A03 RID: 27139
		// (get) Token: 0x0602B047 RID: 176199 RVA: 0x009F3119 File Offset: 0x009F1319
		// (set) Token: 0x0602B048 RID: 176200 RVA: 0x009F312D File Offset: 0x009F132D
		public unsafe FName 追踪插槽
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Execute_Yinganyi_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Execute_Yinganyi_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17006A04 RID: 27140
		// (get) Token: 0x0602B049 RID: 176201 RVA: 0x009F3142 File Offset: 0x009F1342
		// (set) Token: 0x0602B04A RID: 176202 RVA: 0x009F3152 File Offset: 0x009F1352
		public unsafe int 特效Handle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Execute_Yinganyi_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Execute_Yinganyi_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x0602B04B RID: 176203 RVA: 0x009F3163 File Offset: 0x009F1363
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_5D118C384AE61F1C80292E812000D24B()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Execute_Yinganyi_C.__OnTick_5D118C384AE61F1C80292E812000D24B_NativeFunctionPtr, null);
		}

		// Token: 0x0602B04C RID: 176204 RVA: 0x009F3177 File Offset: 0x009F1377
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCancelled_5D118C384AE61F1C80292E812000D24B()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Execute_Yinganyi_C.__OnCancelled_5D118C384AE61F1C80292E812000D24B_NativeFunctionPtr, null);
		}

		// Token: 0x0602B04D RID: 176205 RVA: 0x009F318B File Offset: 0x009F138B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnInterrupted_5D118C384AE61F1C80292E812000D24B()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Execute_Yinganyi_C.__OnInterrupted_5D118C384AE61F1C80292E812000D24B_NativeFunctionPtr, null);
		}

		// Token: 0x0602B04E RID: 176206 RVA: 0x009F319F File Offset: 0x009F139F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnBlendOut_5D118C384AE61F1C80292E812000D24B()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Execute_Yinganyi_C.__OnBlendOut_5D118C384AE61F1C80292E812000D24B_NativeFunctionPtr, null);
		}

		// Token: 0x0602B04F RID: 176207 RVA: 0x009F31B3 File Offset: 0x009F13B3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCompleted_5D118C384AE61F1C80292E812000D24B()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Execute_Yinganyi_C.__OnCompleted_5D118C384AE61F1C80292E812000D24B_NativeFunctionPtr, null);
		}

		// Token: 0x0602B050 RID: 176208 RVA: 0x009F31C8 File Offset: 0x009F13C8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_Execute_Yinganyi_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Execute_Yinganyi_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Execute_Yinganyi_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Execute_Yinganyi_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Execute_Yinganyi_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B051 RID: 176209 RVA: 0x009F3210 File Offset: 0x009F1410
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_Execute_Yinganyi_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Execute_Yinganyi_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Execute_Yinganyi_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Execute_Yinganyi_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Execute_Yinganyi_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602B052 RID: 176210 RVA: 0x009F3257 File Offset: 0x009F1457
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Execute_Yinganyi_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602B053 RID: 176211 RVA: 0x009F326B File Offset: 0x009F146B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Execute_Yinganyi_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602B054 RID: 176212 RVA: 0x009F3280 File Offset: 0x009F1480
		protected GA_Execute_Yinganyi_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040164F9 RID: 91385
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Execute_Yinganyi.GA_Execute_Yinganyi_C";

		// Token: 0x040164FA RID: 91386
		private static IntPtr _ClassPtr;

		// Token: 0x040164FB RID: 91387
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040164FC RID: 91388
		internal new static int __PropertyOffset_1;

		// Token: 0x040164FD RID: 91389
		internal new static int __PropertyOffset_2;

		// Token: 0x040164FE RID: 91390
		internal new static int __PropertyOffset_3;

		// Token: 0x040164FF RID: 91391
		internal static int __PropertyOffset_4;

		// Token: 0x04016500 RID: 91392
		private static IntPtr __OnTick_5D118C384AE61F1C80292E812000D24B_NativeFunctionPtr;

		// Token: 0x04016501 RID: 91393
		private static IntPtr __OnCancelled_5D118C384AE61F1C80292E812000D24B_NativeFunctionPtr;

		// Token: 0x04016502 RID: 91394
		private static IntPtr __OnInterrupted_5D118C384AE61F1C80292E812000D24B_NativeFunctionPtr;

		// Token: 0x04016503 RID: 91395
		private static IntPtr __OnBlendOut_5D118C384AE61F1C80292E812000D24B_NativeFunctionPtr;

		// Token: 0x04016504 RID: 91396
		private static IntPtr __OnCompleted_5D118C384AE61F1C80292E812000D24B_NativeFunctionPtr;

		// Token: 0x04016505 RID: 91397
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x04016506 RID: 91398
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x0200A45F RID: 42079
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x040322A3 RID: 205475
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}

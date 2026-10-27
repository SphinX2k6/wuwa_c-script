using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GA;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Abilities.GA
{
	// Token: 0x02004136 RID: 16694
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Abilities/GA/GA_Hook_Swinging.GA_Hook_Swinging_C")]
	[UnrealStructLayout(1912, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1912)]
	public class GA_Hook_Swinging_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602B077 RID: 176247 RVA: 0x009F3759 File Offset: 0x009F1959
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Hook_Swinging_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Hook_Swinging.GA_Hook_Swinging_C");
			}
			return GA_Hook_Swinging_C._ClassPtr;
		}

		// Token: 0x0602B078 RID: 176248 RVA: 0x009F3780 File Offset: 0x009F1980
		public GA_Hook_Swinging_C() : this(BuiltinUtils.AllocNativeUObject(GA_Hook_Swinging_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602B079 RID: 176249 RVA: 0x009F37A8 File Offset: 0x009F19A8
		public GA_Hook_Swinging_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Hook_Swinging_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006A06 RID: 27142
		// (get) Token: 0x0602B07A RID: 176250 RVA: 0x009F37DB File Offset: 0x009F19DB
		// (set) Token: 0x0602B07B RID: 176251 RVA: 0x009F37EF File Offset: 0x009F19EF
		[Nullable(2)]
		public unsafe UObject Rope
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UObject>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Hook_Swinging_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Hook_Swinging_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17006A07 RID: 27143
		// (get) Token: 0x0602B07C RID: 176252 RVA: 0x009F3804 File Offset: 0x009F1A04
		// (set) Token: 0x0602B07D RID: 176253 RVA: 0x009F3814 File Offset: 0x009F1A14
		public unsafe float Distance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Hook_Swinging_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Hook_Swinging_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17006A08 RID: 27144
		// (get) Token: 0x0602B07E RID: 176254 RVA: 0x009F3828 File Offset: 0x009F1A28
		// (set) Token: 0x0602B07F RID: 176255 RVA: 0x009F3861 File Offset: 0x009F1A61
		public FTimerHandle SwingingTimer
		{
			get
			{
				base.FastCheckIsValid();
				FTimerHandle result;
				if ((result = this._SwingingTimer) == null)
				{
					result = (this._SwingingTimer = new FTimerHandle(base.NativePtr + (IntPtr)GA_Hook_Swinging_C.__PropertyOffset_3, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FTimerHandle.StaticStruct(), base.NativePtr + (IntPtr)GA_Hook_Swinging_C.__PropertyOffset_3, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006A09 RID: 27145
		// (get) Token: 0x0602B080 RID: 176256 RVA: 0x009F3882 File Offset: 0x009F1A82
		// (set) Token: 0x0602B081 RID: 176257 RVA: 0x009F3896 File Offset: 0x009F1A96
		public unsafe FVector 移动输入
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Hook_Swinging_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Hook_Swinging_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17006A0A RID: 27146
		// (get) Token: 0x0602B082 RID: 176258 RVA: 0x009F38AC File Offset: 0x009F1AAC
		// (set) Token: 0x0602B083 RID: 176259 RVA: 0x009F38E5 File Offset: 0x009F1AE5
		public SCameraModifier_Settings CameraModifySettings
		{
			get
			{
				base.FastCheckIsValid();
				SCameraModifier_Settings result;
				if ((result = this._CameraModifySettings) == null)
				{
					result = (this._CameraModifySettings = new SCameraModifier_Settings(base.NativePtr + (IntPtr)GA_Hook_Swinging_C.__PropertyOffset_5, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SCameraModifier_Settings.StaticStruct(), base.NativePtr + (IntPtr)GA_Hook_Swinging_C.__PropertyOffset_5, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0602B084 RID: 176260 RVA: 0x009F3906 File Offset: 0x009F1B06
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SwingingRotaion()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Hook_Swinging_C.__SwingingRotaion_NativeFunctionPtr, null);
		}

		// Token: 0x0602B085 RID: 176261 RVA: 0x009F391A File Offset: 0x009F1B1A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnFinish_8D96293640861CE3D30811B2BF5219AD()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Hook_Swinging_C.__OnFinish_8D96293640861CE3D30811B2BF5219AD_NativeFunctionPtr, null);
		}

		// Token: 0x0602B086 RID: 176262 RVA: 0x009F392E File Offset: 0x009F1B2E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_8D96293640861CE3D30811B2BF5219AD()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Hook_Swinging_C.__OnTick_8D96293640861CE3D30811B2BF5219AD_NativeFunctionPtr, null);
		}

		// Token: 0x0602B087 RID: 176263 RVA: 0x009F3944 File Offset: 0x009F1B44
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void EventReceived_5442B24C45E0D351ADA243874004C8BC(FGameplayEventData Payload)
		{
			GA_Hook_Swinging_C.__EventReceived_5442B24C45E0D351ADA243874004C8BC_FunctionParams* ptr = stackalloc GA_Hook_Swinging_C.__EventReceived_5442B24C45E0D351ADA243874004C8BC_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(GA_Hook_Swinging_C.__EventReceived_5442B24C45E0D351ADA243874004C8BC_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Hook_Swinging_C.__EventReceived_5442B24C45E0D351ADA243874004C8BC_NativeFunctionPtr, (void*)ptr, 1);
			if (Payload != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayEventData.StaticStruct(), &ptr->Payload, Payload.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Hook_Swinging_C.__EventReceived_5442B24C45E0D351ADA243874004C8BC_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(GA_Hook_Swinging_C.__EventReceived_5442B24C45E0D351ADA243874004C8BC_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602B088 RID: 176264 RVA: 0x009F39B9 File Offset: 0x009F1BB9
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Hook_Swinging_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602B089 RID: 176265 RVA: 0x009F39CD File Offset: 0x009F1BCD
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Hook_Swinging_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602B08A RID: 176266 RVA: 0x009F39E4 File Offset: 0x009F1BE4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_Hook_Swinging_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Hook_Swinging_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Hook_Swinging_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Hook_Swinging_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Hook_Swinging_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B08B RID: 176267 RVA: 0x009F3A2C File Offset: 0x009F1C2C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_Hook_Swinging_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Hook_Swinging_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Hook_Swinging_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Hook_Swinging_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Hook_Swinging_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602B08C RID: 176268 RVA: 0x009F3A73 File Offset: 0x009F1C73
		protected GA_Hook_Swinging_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016520 RID: 91424
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Hook_Swinging.GA_Hook_Swinging_C";

		// Token: 0x04016521 RID: 91425
		private static IntPtr _ClassPtr;

		// Token: 0x04016522 RID: 91426
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04016523 RID: 91427
		internal new static int __PropertyOffset_1;

		// Token: 0x04016524 RID: 91428
		internal new static int __PropertyOffset_2;

		// Token: 0x04016525 RID: 91429
		internal new static int __PropertyOffset_3;

		// Token: 0x04016526 RID: 91430
		[Nullable(2)]
		private FTimerHandle _SwingingTimer;

		// Token: 0x04016527 RID: 91431
		internal static int __PropertyOffset_4;

		// Token: 0x04016528 RID: 91432
		internal static int __PropertyOffset_5;

		// Token: 0x04016529 RID: 91433
		[Nullable(2)]
		private SCameraModifier_Settings _CameraModifySettings;

		// Token: 0x0401652A RID: 91434
		private static IntPtr __SwingingRotaion_NativeFunctionPtr;

		// Token: 0x0401652B RID: 91435
		private static IntPtr __OnFinish_8D96293640861CE3D30811B2BF5219AD_NativeFunctionPtr;

		// Token: 0x0401652C RID: 91436
		private static IntPtr __OnTick_8D96293640861CE3D30811B2BF5219AD_NativeFunctionPtr;

		// Token: 0x0401652D RID: 91437
		private static IntPtr __EventReceived_5442B24C45E0D351ADA243874004C8BC_NativeFunctionPtr;

		// Token: 0x0401652E RID: 91438
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x0401652F RID: 91439
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x0200A464 RID: 42084
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __EventReceived_5442B24C45E0D351ADA243874004C8BC_FunctionParams
		{
			// Token: 0x040322A8 RID: 205480
			[FieldOffset(0)]
			public byte Payload;
		}

		// Token: 0x0200A465 RID: 42085
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x040322A9 RID: 205481
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}

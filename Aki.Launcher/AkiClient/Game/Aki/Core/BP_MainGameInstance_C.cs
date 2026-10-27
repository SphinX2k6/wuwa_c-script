using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Core
{
	// Token: 0x02000028 RID: 40
	[UnrealObjectPath("/Game/Aki/Core/BP_MainGameInstance.BP_MainGameInstance_C")]
	[UnrealStructLayout(480, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 473)]
	public class BP_MainGameInstance_C : UGameInstance, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600017A RID: 378 RVA: 0x00009357 File Offset: 0x00007557
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_MainGameInstance_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Core/BP_MainGameInstance.BP_MainGameInstance_C");
			}
			return BP_MainGameInstance_C._ClassPtr;
		}

		// Token: 0x0600017B RID: 379 RVA: 0x0000937C File Offset: 0x0000757C
		public BP_MainGameInstance_C() : this(BuiltinUtils.AllocNativeUObject(BP_MainGameInstance_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600017C RID: 380 RVA: 0x000093A4 File Offset: 0x000075A4
		[NullableContext(1)]
		public BP_MainGameInstance_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_MainGameInstance_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600017D RID: 381 RVA: 0x000093D7 File Offset: 0x000075D7
		// (set) Token: 0x0600017E RID: 382 RVA: 0x000093EB File Offset: 0x000075EB
		[Nullable(2)]
		public unsafe ULoadMapNotify 场景加载通知器
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULoadMapNotify>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MainGameInstance_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MainGameInstance_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600017F RID: 383 RVA: 0x00009400 File Offset: 0x00007600
		// (set) Token: 0x06000180 RID: 384 RVA: 0x00009410 File Offset: 0x00007610
		public unsafe bool IsStartFromLaunch
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MainGameInstance_C.__PropertyOffset_2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MainGameInstance_C.__PropertyOffset_2) = (value ? 1 : 0);
			}
		}

		// Token: 0x06000181 RID: 385 RVA: 0x00009421 File Offset: 0x00007621
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void StartGame()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MainGameInstance_C.__StartGame_NativeFunctionPtr, null);
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00009435 File Offset: 0x00007635
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Reboot()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MainGameInstance_C.__Reboot_NativeFunctionPtr, null);
		}

		// Token: 0x06000183 RID: 387 RVA: 0x00009449 File Offset: 0x00007649
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void MountGamePak()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MainGameInstance_C.__MountGamePak_NativeFunctionPtr, null);
		}

		// Token: 0x06000184 RID: 388 RVA: 0x0000945D File Offset: 0x0000765D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void MountLauncherPak()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MainGameInstance_C.__MountLauncherPak_NativeFunctionPtr, null);
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00009471 File Offset: 0x00007671
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveInit()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MainGameInstance_C.__ReceiveInit_NativeFunctionPtr, null);
		}

		// Token: 0x06000186 RID: 390 RVA: 0x00009485 File Offset: 0x00007685
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveInit_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_MainGameInstance_C.__ReceiveInit_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06000187 RID: 391 RVA: 0x0000949A File Offset: 0x0000769A
		protected BP_MainGameInstance_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040000B3 RID: 179
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Core/BP_MainGameInstance.BP_MainGameInstance_C";

		// Token: 0x040000B4 RID: 180
		private static IntPtr _ClassPtr;

		// Token: 0x040000B5 RID: 181
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040000B6 RID: 182
		internal static int __PropertyOffset_1;

		// Token: 0x040000B7 RID: 183
		internal static int __PropertyOffset_2;

		// Token: 0x040000B8 RID: 184
		private static IntPtr __StartGame_NativeFunctionPtr;

		// Token: 0x040000B9 RID: 185
		private static IntPtr __Reboot_NativeFunctionPtr;

		// Token: 0x040000BA RID: 186
		private static IntPtr __MountGamePak_NativeFunctionPtr;

		// Token: 0x040000BB RID: 187
		private static IntPtr __MountLauncherPak_NativeFunctionPtr;

		// Token: 0x040000BC RID: 188
		private static IntPtr __ReceiveInit_NativeFunctionPtr;
	}
}

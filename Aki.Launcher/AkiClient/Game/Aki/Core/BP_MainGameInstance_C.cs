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
		// Token: 0x0600017A RID: 378 RVA: 0x0000938F File Offset: 0x0000758F
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_MainGameInstance_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Core/BP_MainGameInstance.BP_MainGameInstance_C");
			}
			return BP_MainGameInstance_C._ClassPtr;
		}

		// Token: 0x0600017B RID: 379 RVA: 0x000093B4 File Offset: 0x000075B4
		public BP_MainGameInstance_C() : this(BuiltinUtils.AllocNativeUObject(BP_MainGameInstance_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600017C RID: 380 RVA: 0x000093DC File Offset: 0x000075DC
		[NullableContext(1)]
		public BP_MainGameInstance_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_MainGameInstance_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600017D RID: 381 RVA: 0x0000940F File Offset: 0x0000760F
		// (set) Token: 0x0600017E RID: 382 RVA: 0x00009423 File Offset: 0x00007623
		[Nullable(2)]
		public unsafe ULoadMapNotify 场景加载通知器
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULoadMapNotify>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MainGameInstance_C.__PropertyOffset_场景加载通知器);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MainGameInstance_C.__PropertyOffset_场景加载通知器, value);
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600017F RID: 383 RVA: 0x00009438 File Offset: 0x00007638
		// (set) Token: 0x06000180 RID: 384 RVA: 0x00009448 File Offset: 0x00007648
		public unsafe bool IsStartFromLaunch
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MainGameInstance_C.__PropertyOffset_IsStartFromLaunch) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MainGameInstance_C.__PropertyOffset_IsStartFromLaunch) = (value ? 1 : 0);
			}
		}

		// Token: 0x06000181 RID: 385 RVA: 0x00009459 File Offset: 0x00007659
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void StartGame()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MainGameInstance_C.__StartGame_NativeFunctionPtr, null);
		}

		// Token: 0x06000182 RID: 386 RVA: 0x0000946D File Offset: 0x0000766D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Reboot()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MainGameInstance_C.__Reboot_NativeFunctionPtr, null);
		}

		// Token: 0x06000183 RID: 387 RVA: 0x00009481 File Offset: 0x00007681
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void MountGamePak()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MainGameInstance_C.__MountGamePak_NativeFunctionPtr, null);
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00009495 File Offset: 0x00007695
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void MountLauncherPak()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MainGameInstance_C.__MountLauncherPak_NativeFunctionPtr, null);
		}

		// Token: 0x06000185 RID: 389 RVA: 0x000094A9 File Offset: 0x000076A9
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveInit()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MainGameInstance_C.__ReceiveInit_NativeFunctionPtr, null);
		}

		// Token: 0x06000186 RID: 390 RVA: 0x000094BD File Offset: 0x000076BD
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveInit_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_MainGameInstance_C.__ReceiveInit_NativeFunctionPtr, null);
		}

		// Token: 0x06000187 RID: 391 RVA: 0x000094D1 File Offset: 0x000076D1
		protected BP_MainGameInstance_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040000B4 RID: 180
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Core/BP_MainGameInstance.BP_MainGameInstance_C";

		// Token: 0x040000B5 RID: 181
		private static IntPtr _ClassPtr;

		// Token: 0x040000B6 RID: 182
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040000B7 RID: 183
		internal static int __PropertyOffset_场景加载通知器;

		// Token: 0x040000B8 RID: 184
		internal static int __PropertyOffset_IsStartFromLaunch;

		// Token: 0x040000B9 RID: 185
		private static IntPtr __StartGame_NativeFunctionPtr;

		// Token: 0x040000BA RID: 186
		private static IntPtr __Reboot_NativeFunctionPtr;

		// Token: 0x040000BB RID: 187
		private static IntPtr __MountGamePak_NativeFunctionPtr;

		// Token: 0x040000BC RID: 188
		private static IntPtr __MountLauncherPak_NativeFunctionPtr;

		// Token: 0x040000BD RID: 189
		private static IntPtr __ReceiveInit_NativeFunctionPtr;
	}
}

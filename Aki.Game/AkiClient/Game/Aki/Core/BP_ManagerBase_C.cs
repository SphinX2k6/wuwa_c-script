using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.UI.Manager;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Core
{
	// Token: 0x02003FD9 RID: 16345
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Core/BP_ManagerBase.BP_ManagerBase_C")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class BP_ManagerBase_C : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06029DC8 RID: 171464 RVA: 0x009CE1D9 File Offset: 0x009CC3D9
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_ManagerBase_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Core/BP_ManagerBase.BP_ManagerBase_C");
			}
			return BP_ManagerBase_C._ClassPtr;
		}

		// Token: 0x06029DC9 RID: 171465 RVA: 0x009CE200 File Offset: 0x009CC400
		public BP_ManagerBase_C() : this(BuiltinUtils.AllocNativeUObject(BP_ManagerBase_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06029DCA RID: 171466 RVA: 0x009CE228 File Offset: 0x009CC428
		[NullableContext(1)]
		public BP_ManagerBase_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_ManagerBase_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006598 RID: 26008
		// (get) Token: 0x06029DCB RID: 171467 RVA: 0x009CE25B File Offset: 0x009CC45B
		// (set) Token: 0x06029DCC RID: 171468 RVA: 0x009CE26F File Offset: 0x009CC46F
		public unsafe UObject 界面管理器
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UObject>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ManagerBase_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ManagerBase_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17006599 RID: 26009
		// (get) Token: 0x06029DCD RID: 171469 RVA: 0x009CE284 File Offset: 0x009CC484
		// (set) Token: 0x06029DCE RID: 171470 RVA: 0x009CE298 File Offset: 0x009CC498
		public unsafe BP_EventManager_C 事件管理器
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_EventManager_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ManagerBase_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ManagerBase_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x06029DCF RID: 171471 RVA: 0x009CE2AD File Offset: 0x009CC4AD
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnLeaveWorld()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ManagerBase_C.__OnLeaveWorld_NativeFunctionPtr, null);
		}

		// Token: 0x06029DD0 RID: 171472 RVA: 0x009CE2C4 File Offset: 0x009CC4C4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 初始化(BP_MainGameInstance_C 游戏实例)
		{
			BP_ManagerBase_C.__初始化_FunctionParams* ptr = stackalloc BP_ManagerBase_C.__初始化_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(BP_ManagerBase_C.__初始化_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ManagerBase_C.__初始化_NativeFunctionPtr, (void*)ptr, 1);
			ptr->游戏实例 = ((游戏实例 != null) ? 游戏实例.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ManagerBase_C.__初始化_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06029DD1 RID: 171473 RVA: 0x009CE319 File Offset: 0x009CC519
		protected BP_ManagerBase_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040157F3 RID: 88051
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Core/BP_ManagerBase.BP_ManagerBase_C";

		// Token: 0x040157F4 RID: 88052
		private static IntPtr _ClassPtr;

		// Token: 0x040157F5 RID: 88053
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040157F6 RID: 88054
		internal static int __PropertyOffset_0;

		// Token: 0x040157F7 RID: 88055
		internal static int __PropertyOffset_1;

		// Token: 0x040157F8 RID: 88056
		internal static int __PropertyOffset_2;

		// Token: 0x040157F9 RID: 88057
		private static IntPtr __OnLeaveWorld_NativeFunctionPtr;

		// Token: 0x040157FA RID: 88058
		private static IntPtr __初始化_NativeFunctionPtr;

		// Token: 0x0200A2E6 RID: 41702
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __初始化_FunctionParams
		{
			// Token: 0x04032034 RID: 204852
			[FieldOffset(0)]
			public IntPtr 游戏实例;
		}
	}
}

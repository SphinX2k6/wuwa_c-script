using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.UI.Manager;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Core
{
	// Token: 0x02003251 RID: 12881
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Core/BP_ManagerBase.BP_ManagerBase_C")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class BP_ManagerBase_C : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060202E7 RID: 131815 RVA: 0x0093F269 File Offset: 0x0093D469
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_ManagerBase_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Core/BP_ManagerBase.BP_ManagerBase_C");
			}
			return BP_ManagerBase_C._ClassPtr;
		}

		// Token: 0x060202E8 RID: 131816 RVA: 0x0093F290 File Offset: 0x0093D490
		public BP_ManagerBase_C() : this(BuiltinUtils.AllocNativeUObject(BP_ManagerBase_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060202E9 RID: 131817 RVA: 0x0093F2B8 File Offset: 0x0093D4B8
		[NullableContext(1)]
		public BP_ManagerBase_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_ManagerBase_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003DB4 RID: 15796
		// (get) Token: 0x060202EA RID: 131818 RVA: 0x0093F2EB File Offset: 0x0093D4EB
		// (set) Token: 0x060202EB RID: 131819 RVA: 0x0093F2FF File Offset: 0x0093D4FF
		public unsafe UObject 界面管理器
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UObject>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ManagerBase_C.__PropertyOffset_界面管理器);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ManagerBase_C.__PropertyOffset_界面管理器, value);
			}
		}

		// Token: 0x17003DB5 RID: 15797
		// (get) Token: 0x060202EC RID: 131820 RVA: 0x0093F314 File Offset: 0x0093D514
		// (set) Token: 0x060202ED RID: 131821 RVA: 0x0093F328 File Offset: 0x0093D528
		public unsafe BP_EventManager_C 事件管理器
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_EventManager_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ManagerBase_C.__PropertyOffset_事件管理器);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ManagerBase_C.__PropertyOffset_事件管理器, value);
			}
		}

		// Token: 0x060202EE RID: 131822 RVA: 0x0093F33D File Offset: 0x0093D53D
		[SkipLocalsInit]
		public virtual void OnLeaveWorld()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ManagerBase_C.__OnLeaveWorld_NativeFunctionPtr, null);
		}

		// Token: 0x060202EF RID: 131823 RVA: 0x0093F351 File Offset: 0x0093D551
		protected BP_ManagerBase_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011524 RID: 70948
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Core/BP_ManagerBase.BP_ManagerBase_C";

		// Token: 0x04011525 RID: 70949
		private static IntPtr _ClassPtr;

		// Token: 0x04011526 RID: 70950
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011527 RID: 70951
		internal static int __PropertyOffset_界面管理器;

		// Token: 0x04011528 RID: 70952
		internal static int __PropertyOffset_事件管理器;

		// Token: 0x04011529 RID: 70953
		private static IntPtr __OnLeaveWorld_NativeFunctionPtr;
	}
}

using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Common.DollMachine
{
	// Token: 0x02003B9B RID: 15259
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_E_DollItem_BeiBi.BP_E_DollItem_BeiBi_C")]
	[UnrealStructLayout(1680, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1680)]
	public class BP_E_DollItem_BeiBi_C : BP_DollActor_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021F77 RID: 139127 RVA: 0x008FAD75 File Offset: 0x008F8F75
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_E_DollItem_BeiBi_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_E_DollItem_BeiBi.BP_E_DollItem_BeiBi_C");
			}
			return BP_E_DollItem_BeiBi_C._ClassPtr;
		}

		// Token: 0x06021F78 RID: 139128 RVA: 0x008FAD9C File Offset: 0x008F8F9C
		public BP_E_DollItem_BeiBi_C() : this(BuiltinUtils.AllocNativeUObject(BP_E_DollItem_BeiBi_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021F79 RID: 139129 RVA: 0x008FADC4 File Offset: 0x008F8FC4
		[NullableContext(1)]
		public BP_E_DollItem_BeiBi_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_E_DollItem_BeiBi_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06021F7A RID: 139130 RVA: 0x008FADF7 File Offset: 0x008F8FF7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_E_DollItem_BeiBi_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06021F7B RID: 139131 RVA: 0x008FAE0B File Offset: 0x008F900B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_E_DollItem_BeiBi_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06021F7C RID: 139132 RVA: 0x008FAE20 File Offset: 0x008F9020
		protected BP_E_DollItem_BeiBi_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040109C4 RID: 68036
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_E_DollItem_BeiBi.BP_E_DollItem_BeiBi_C";

		// Token: 0x040109C5 RID: 68037
		private static IntPtr _ClassPtr;

		// Token: 0x040109C6 RID: 68038
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040109C7 RID: 68039
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;
	}
}

using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Common.DollMachine
{
	// Token: 0x02003B6F RID: 15215
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollGrabMahcineConveyorBelt.BP_DollGrabMahcineConveyorBelt_C")]
	[UnrealStructLayout(1432, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1432)]
	public class BP_DollGrabMahcineConveyorBelt_C : AKuroSplineConveyorBelt, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021DD1 RID: 138705 RVA: 0x008F8006 File Offset: 0x008F6206
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_DollGrabMahcineConveyorBelt_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollGrabMahcineConveyorBelt.BP_DollGrabMahcineConveyorBelt_C");
			}
			return BP_DollGrabMahcineConveyorBelt_C._ClassPtr;
		}

		// Token: 0x06021DD2 RID: 138706 RVA: 0x008F802C File Offset: 0x008F622C
		public BP_DollGrabMahcineConveyorBelt_C() : this(BuiltinUtils.AllocNativeUObject(BP_DollGrabMahcineConveyorBelt_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021DD3 RID: 138707 RVA: 0x008F8054 File Offset: 0x008F6254
		[NullableContext(1)]
		public BP_DollGrabMahcineConveyorBelt_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_DollGrabMahcineConveyorBelt_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06021DD4 RID: 138708 RVA: 0x008F8087 File Offset: 0x008F6287
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Close()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DollGrabMahcineConveyorBelt_C.__Close_NativeFunctionPtr, null);
		}

		// Token: 0x06021DD5 RID: 138709 RVA: 0x008F809B File Offset: 0x008F629B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Open()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DollGrabMahcineConveyorBelt_C.__Open_NativeFunctionPtr, null);
		}

		// Token: 0x06021DD6 RID: 138710 RVA: 0x008F80AF File Offset: 0x008F62AF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void GenerateTriggerMesh()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DollGrabMahcineConveyorBelt_C.__GenerateTriggerMesh_NativeFunctionPtr, null);
		}

		// Token: 0x06021DD7 RID: 138711 RVA: 0x008F80C3 File Offset: 0x008F62C3
		protected BP_DollGrabMahcineConveyorBelt_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040108BC RID: 67772
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollGrabMahcineConveyorBelt.BP_DollGrabMahcineConveyorBelt_C";

		// Token: 0x040108BD RID: 67773
		private static IntPtr _ClassPtr;

		// Token: 0x040108BE RID: 67774
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040108BF RID: 67775
		private static IntPtr __Close_NativeFunctionPtr;

		// Token: 0x040108C0 RID: 67776
		private static IntPtr __Open_NativeFunctionPtr;

		// Token: 0x040108C1 RID: 67777
		private static IntPtr __GenerateTriggerMesh_NativeFunctionPtr;
	}
}

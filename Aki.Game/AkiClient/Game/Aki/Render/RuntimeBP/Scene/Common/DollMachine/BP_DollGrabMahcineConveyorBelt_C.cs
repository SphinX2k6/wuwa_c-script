using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Common.DollMachine
{
	// Token: 0x020030CE RID: 12494
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollGrabMahcineConveyorBelt.BP_DollGrabMahcineConveyorBelt_C")]
	[UnrealStructLayout(1432, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1432)]
	public class BP_DollGrabMahcineConveyorBelt_C : AKuroSplineConveyorBelt, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601E133 RID: 123187 RVA: 0x0090A4CE File Offset: 0x009086CE
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_DollGrabMahcineConveyorBelt_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollGrabMahcineConveyorBelt.BP_DollGrabMahcineConveyorBelt_C");
			}
			return BP_DollGrabMahcineConveyorBelt_C._ClassPtr;
		}

		// Token: 0x0601E134 RID: 123188 RVA: 0x0090A4F4 File Offset: 0x009086F4
		public BP_DollGrabMahcineConveyorBelt_C() : this(BuiltinUtils.AllocNativeUObject(BP_DollGrabMahcineConveyorBelt_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601E135 RID: 123189 RVA: 0x0090A51C File Offset: 0x0090871C
		[NullableContext(1)]
		public BP_DollGrabMahcineConveyorBelt_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_DollGrabMahcineConveyorBelt_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601E136 RID: 123190 RVA: 0x0090A54F File Offset: 0x0090874F
		[SkipLocalsInit]
		public virtual void Close()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DollGrabMahcineConveyorBelt_C.__Close_NativeFunctionPtr, null);
		}

		// Token: 0x0601E137 RID: 123191 RVA: 0x0090A563 File Offset: 0x00908763
		[SkipLocalsInit]
		public virtual void Open()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DollGrabMahcineConveyorBelt_C.__Open_NativeFunctionPtr, null);
		}

		// Token: 0x0601E138 RID: 123192 RVA: 0x0090A577 File Offset: 0x00908777
		[SkipLocalsInit]
		public virtual void GenerateTriggerMesh()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DollGrabMahcineConveyorBelt_C.__GenerateTriggerMesh_NativeFunctionPtr, null);
		}

		// Token: 0x0601E139 RID: 123193 RVA: 0x0090A58B File Offset: 0x0090878B
		protected BP_DollGrabMahcineConveyorBelt_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FE5D RID: 65117
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollGrabMahcineConveyorBelt.BP_DollGrabMahcineConveyorBelt_C";

		// Token: 0x0400FE5E RID: 65118
		private static IntPtr _ClassPtr;

		// Token: 0x0400FE5F RID: 65119
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FE60 RID: 65120
		private static IntPtr __Close_NativeFunctionPtr;

		// Token: 0x0400FE61 RID: 65121
		private static IntPtr __Open_NativeFunctionPtr;

		// Token: 0x0400FE62 RID: 65122
		private static IntPtr __GenerateTriggerMesh_NativeFunctionPtr;
	}
}

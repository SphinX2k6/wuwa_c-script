using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.PathLine.Pathline_EdgeWall
{
	// Token: 0x020031A9 RID: 12713
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/PathLine/Pathline_EdgeWall/BP_BasePathLine_Edgewall.BP_BasePathLine_Edgewall_C")]
	[UnrealStructLayout(1096, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1089)]
	public class BP_BasePathLine_Edgewall_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F643 RID: 128579 RVA: 0x0092CC34 File Offset: 0x0092AE34
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_BasePathLine_Edgewall_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/PathLine/Pathline_EdgeWall/BP_BasePathLine_Edgewall.BP_BasePathLine_Edgewall_C");
			}
			return BP_BasePathLine_Edgewall_C._ClassPtr;
		}

		// Token: 0x0601F644 RID: 128580 RVA: 0x0092CC58 File Offset: 0x0092AE58
		public BP_BasePathLine_Edgewall_C() : this(BuiltinUtils.AllocNativeUObject(BP_BasePathLine_Edgewall_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F645 RID: 128581 RVA: 0x0092CC80 File Offset: 0x0092AE80
		[NullableContext(1)]
		public BP_BasePathLine_Edgewall_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_BasePathLine_Edgewall_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003907 RID: 14599
		// (get) Token: 0x0601F646 RID: 128582 RVA: 0x0092CCB3 File Offset: 0x0092AEB3
		// (set) Token: 0x0601F647 RID: 128583 RVA: 0x0092CCC7 File Offset: 0x0092AEC7
		public unsafe USplineComponent Spline
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USplineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BasePathLine_Edgewall_C.__PropertyOffset_Spline);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BasePathLine_Edgewall_C.__PropertyOffset_Spline, value);
			}
		}

		// Token: 0x17003908 RID: 14600
		// (get) Token: 0x0601F648 RID: 128584 RVA: 0x0092CCDC File Offset: 0x0092AEDC
		// (set) Token: 0x0601F649 RID: 128585 RVA: 0x0092CCF0 File Offset: 0x0092AEF0
		public unsafe FVector OriginalLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BasePathLine_Edgewall_C.__PropertyOffset_OriginalLocation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BasePathLine_Edgewall_C.__PropertyOffset_OriginalLocation) = value;
			}
		}

		// Token: 0x17003909 RID: 14601
		// (get) Token: 0x0601F64A RID: 128586 RVA: 0x0092CD05 File Offset: 0x0092AF05
		// (set) Token: 0x0601F64B RID: 128587 RVA: 0x0092CD19 File Offset: 0x0092AF19
		public unsafe AActor DebugTarget
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BasePathLine_Edgewall_C.__PropertyOffset_DebugTarget);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BasePathLine_Edgewall_C.__PropertyOffset_DebugTarget, value);
			}
		}

		// Token: 0x1700390A RID: 14602
		// (get) Token: 0x0601F64C RID: 128588 RVA: 0x0092CD2E File Offset: 0x0092AF2E
		// (set) Token: 0x0601F64D RID: 128589 RVA: 0x0092CD3E File Offset: 0x0092AF3E
		public unsafe bool IsAttachedToEntity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BasePathLine_Edgewall_C.__PropertyOffset_IsAttachedToEntity) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BasePathLine_Edgewall_C.__PropertyOffset_IsAttachedToEntity) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601F64E RID: 128590 RVA: 0x0092CD4F File Offset: 0x0092AF4F
		[SkipLocalsInit]
		public virtual void Save()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BasePathLine_Edgewall_C.__Save_NativeFunctionPtr, null);
		}

		// Token: 0x0601F64F RID: 128591 RVA: 0x0092CD63 File Offset: 0x0092AF63
		[SkipLocalsInit]
		public virtual void 贴地处理()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BasePathLine_Edgewall_C.__贴地处理_NativeFunctionPtr, null);
		}

		// Token: 0x0601F650 RID: 128592 RVA: 0x0092CD77 File Offset: 0x0092AF77
		[SkipLocalsInit]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BasePathLine_Edgewall_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601F651 RID: 128593 RVA: 0x0092CD8B File Offset: 0x0092AF8B
		[SkipLocalsInit]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_BasePathLine_Edgewall_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601F652 RID: 128594 RVA: 0x0092CD9F File Offset: 0x0092AF9F
		protected BP_BasePathLine_Edgewall_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010D3B RID: 68923
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Data/PathLine/Pathline_EdgeWall/BP_BasePathLine_Edgewall.BP_BasePathLine_Edgewall_C";

		// Token: 0x04010D3C RID: 68924
		private static IntPtr _ClassPtr;

		// Token: 0x04010D3D RID: 68925
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010D3E RID: 68926
		internal static int __PropertyOffset_Spline;

		// Token: 0x04010D3F RID: 68927
		internal static int __PropertyOffset_OriginalLocation;

		// Token: 0x04010D40 RID: 68928
		internal static int __PropertyOffset_DebugTarget;

		// Token: 0x04010D41 RID: 68929
		internal static int __PropertyOffset_IsAttachedToEntity;

		// Token: 0x04010D42 RID: 68930
		private static IntPtr __Save_NativeFunctionPtr;

		// Token: 0x04010D43 RID: 68931
		private static IntPtr __贴地处理_NativeFunctionPtr;

		// Token: 0x04010D44 RID: 68932
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;
	}
}

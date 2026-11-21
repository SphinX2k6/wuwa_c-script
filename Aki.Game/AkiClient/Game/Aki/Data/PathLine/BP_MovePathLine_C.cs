using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.PathLine
{
	// Token: 0x020031A8 RID: 12712
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/PathLine/BP_MovePathLine.BP_MovePathLine_C")]
	[UnrealStructLayout(1088, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1085)]
	public class BP_MovePathLine_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F633 RID: 128563 RVA: 0x0092CABF File Offset: 0x0092ACBF
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_MovePathLine_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/PathLine/BP_MovePathLine.BP_MovePathLine_C");
			}
			return BP_MovePathLine_C._ClassPtr;
		}

		// Token: 0x0601F634 RID: 128564 RVA: 0x0092CAE4 File Offset: 0x0092ACE4
		public BP_MovePathLine_C() : this(BuiltinUtils.AllocNativeUObject(BP_MovePathLine_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F635 RID: 128565 RVA: 0x0092CB0C File Offset: 0x0092AD0C
		[NullableContext(1)]
		public BP_MovePathLine_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_MovePathLine_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003903 RID: 14595
		// (get) Token: 0x0601F636 RID: 128566 RVA: 0x0092CB3F File Offset: 0x0092AD3F
		// (set) Token: 0x0601F637 RID: 128567 RVA: 0x0092CB53 File Offset: 0x0092AD53
		public unsafe UKuroMoveSplineComponent Spline
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroMoveSplineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MovePathLine_C.__PropertyOffset_Spline);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MovePathLine_C.__PropertyOffset_Spline, value);
			}
		}

		// Token: 0x17003904 RID: 14596
		// (get) Token: 0x0601F638 RID: 128568 RVA: 0x0092CB68 File Offset: 0x0092AD68
		// (set) Token: 0x0601F639 RID: 128569 RVA: 0x0092CB7C File Offset: 0x0092AD7C
		public unsafe AActor DebugTarget
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MovePathLine_C.__PropertyOffset_DebugTarget);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MovePathLine_C.__PropertyOffset_DebugTarget, value);
			}
		}

		// Token: 0x17003905 RID: 14597
		// (get) Token: 0x0601F63A RID: 128570 RVA: 0x0092CB91 File Offset: 0x0092AD91
		// (set) Token: 0x0601F63B RID: 128571 RVA: 0x0092CBA5 File Offset: 0x0092ADA5
		public unsafe FVector OriginalLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MovePathLine_C.__PropertyOffset_OriginalLocation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MovePathLine_C.__PropertyOffset_OriginalLocation) = value;
			}
		}

		// Token: 0x17003906 RID: 14598
		// (get) Token: 0x0601F63C RID: 128572 RVA: 0x0092CBBA File Offset: 0x0092ADBA
		// (set) Token: 0x0601F63D RID: 128573 RVA: 0x0092CBCA File Offset: 0x0092ADCA
		public unsafe bool IsAttachedToEntity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MovePathLine_C.__PropertyOffset_IsAttachedToEntity) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MovePathLine_C.__PropertyOffset_IsAttachedToEntity) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601F63E RID: 128574 RVA: 0x0092CBDB File Offset: 0x0092ADDB
		[SkipLocalsInit]
		public virtual void 贴地处理()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MovePathLine_C.__贴地处理_NativeFunctionPtr, null);
		}

		// Token: 0x0601F63F RID: 128575 RVA: 0x0092CBEF File Offset: 0x0092ADEF
		[SkipLocalsInit]
		public virtual void Save()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MovePathLine_C.__Save_NativeFunctionPtr, null);
		}

		// Token: 0x0601F640 RID: 128576 RVA: 0x0092CC03 File Offset: 0x0092AE03
		[SkipLocalsInit]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MovePathLine_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601F641 RID: 128577 RVA: 0x0092CC17 File Offset: 0x0092AE17
		[SkipLocalsInit]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_MovePathLine_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601F642 RID: 128578 RVA: 0x0092CC2B File Offset: 0x0092AE2B
		protected BP_MovePathLine_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010D31 RID: 68913
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Data/PathLine/BP_MovePathLine.BP_MovePathLine_C";

		// Token: 0x04010D32 RID: 68914
		private static IntPtr _ClassPtr;

		// Token: 0x04010D33 RID: 68915
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010D34 RID: 68916
		internal static int __PropertyOffset_Spline;

		// Token: 0x04010D35 RID: 68917
		internal static int __PropertyOffset_DebugTarget;

		// Token: 0x04010D36 RID: 68918
		internal static int __PropertyOffset_OriginalLocation;

		// Token: 0x04010D37 RID: 68919
		internal static int __PropertyOffset_IsAttachedToEntity;

		// Token: 0x04010D38 RID: 68920
		private static IntPtr __贴地处理_NativeFunctionPtr;

		// Token: 0x04010D39 RID: 68921
		private static IntPtr __Save_NativeFunctionPtr;

		// Token: 0x04010D3A RID: 68922
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;
	}
}

using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.PathLine
{
	// Token: 0x020031A5 RID: 12709
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/PathLine/BP_BasePathLine.BP_BasePathLine_C")]
	[UnrealStructLayout(1096, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1089)]
	public class BP_BasePathLine_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F605 RID: 128517 RVA: 0x0092C601 File Offset: 0x0092A801
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_BasePathLine_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/PathLine/BP_BasePathLine.BP_BasePathLine_C");
			}
			return BP_BasePathLine_C._ClassPtr;
		}

		// Token: 0x0601F606 RID: 128518 RVA: 0x0092C628 File Offset: 0x0092A828
		public BP_BasePathLine_C() : this(BuiltinUtils.AllocNativeUObject(BP_BasePathLine_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F607 RID: 128519 RVA: 0x0092C650 File Offset: 0x0092A850
		[NullableContext(1)]
		public BP_BasePathLine_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_BasePathLine_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170038F8 RID: 14584
		// (get) Token: 0x0601F608 RID: 128520 RVA: 0x0092C683 File Offset: 0x0092A883
		// (set) Token: 0x0601F609 RID: 128521 RVA: 0x0092C697 File Offset: 0x0092A897
		public unsafe USplineComponent Spline
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USplineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BasePathLine_C.__PropertyOffset_Spline);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BasePathLine_C.__PropertyOffset_Spline, value);
			}
		}

		// Token: 0x170038F9 RID: 14585
		// (get) Token: 0x0601F60A RID: 128522 RVA: 0x0092C6AC File Offset: 0x0092A8AC
		// (set) Token: 0x0601F60B RID: 128523 RVA: 0x0092C6C0 File Offset: 0x0092A8C0
		public unsafe FVector OriginalLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BasePathLine_C.__PropertyOffset_OriginalLocation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BasePathLine_C.__PropertyOffset_OriginalLocation) = value;
			}
		}

		// Token: 0x170038FA RID: 14586
		// (get) Token: 0x0601F60C RID: 128524 RVA: 0x0092C6D5 File Offset: 0x0092A8D5
		// (set) Token: 0x0601F60D RID: 128525 RVA: 0x0092C6E9 File Offset: 0x0092A8E9
		public unsafe AActor DebugTarget
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BasePathLine_C.__PropertyOffset_DebugTarget);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BasePathLine_C.__PropertyOffset_DebugTarget, value);
			}
		}

		// Token: 0x170038FB RID: 14587
		// (get) Token: 0x0601F60E RID: 128526 RVA: 0x0092C6FE File Offset: 0x0092A8FE
		// (set) Token: 0x0601F60F RID: 128527 RVA: 0x0092C70E File Offset: 0x0092A90E
		public unsafe bool IsAttachedToEntity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BasePathLine_C.__PropertyOffset_IsAttachedToEntity) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BasePathLine_C.__PropertyOffset_IsAttachedToEntity) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601F610 RID: 128528 RVA: 0x0092C71F File Offset: 0x0092A91F
		[SkipLocalsInit]
		public virtual void Save()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BasePathLine_C.__Save_NativeFunctionPtr, null);
		}

		// Token: 0x0601F611 RID: 128529 RVA: 0x0092C733 File Offset: 0x0092A933
		[SkipLocalsInit]
		public virtual void 贴地处理()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BasePathLine_C.__贴地处理_NativeFunctionPtr, null);
		}

		// Token: 0x0601F612 RID: 128530 RVA: 0x0092C747 File Offset: 0x0092A947
		[SkipLocalsInit]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BasePathLine_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601F613 RID: 128531 RVA: 0x0092C75B File Offset: 0x0092A95B
		[SkipLocalsInit]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_BasePathLine_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601F614 RID: 128532 RVA: 0x0092C76F File Offset: 0x0092A96F
		protected BP_BasePathLine_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010D13 RID: 68883
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Data/PathLine/BP_BasePathLine.BP_BasePathLine_C";

		// Token: 0x04010D14 RID: 68884
		private static IntPtr _ClassPtr;

		// Token: 0x04010D15 RID: 68885
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010D16 RID: 68886
		internal static int __PropertyOffset_Spline;

		// Token: 0x04010D17 RID: 68887
		internal static int __PropertyOffset_OriginalLocation;

		// Token: 0x04010D18 RID: 68888
		internal static int __PropertyOffset_DebugTarget;

		// Token: 0x04010D19 RID: 68889
		internal static int __PropertyOffset_IsAttachedToEntity;

		// Token: 0x04010D1A RID: 68890
		private static IntPtr __Save_NativeFunctionPtr;

		// Token: 0x04010D1B RID: 68891
		private static IntPtr __贴地处理_NativeFunctionPtr;

		// Token: 0x04010D1C RID: 68892
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;
	}
}

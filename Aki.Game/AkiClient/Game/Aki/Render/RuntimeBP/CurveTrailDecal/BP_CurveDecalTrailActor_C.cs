using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.CurveTrailDecal
{
	// Token: 0x02003DEC RID: 15852
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/CurveTrailDecal/BP_CurveDecalTrailActor.BP_CurveDecalTrailActor_C")]
	[UnrealStructLayout(1064, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1064)]
	public class BP_CurveDecalTrailActor_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060278E7 RID: 162023 RVA: 0x00994997 File Offset: 0x00992B97
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_CurveDecalTrailActor_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/CurveTrailDecal/BP_CurveDecalTrailActor.BP_CurveDecalTrailActor_C");
			}
			return BP_CurveDecalTrailActor_C._ClassPtr;
		}

		// Token: 0x060278E8 RID: 162024 RVA: 0x009949BC File Offset: 0x00992BBC
		public BP_CurveDecalTrailActor_C() : this(BuiltinUtils.AllocNativeUObject(BP_CurveDecalTrailActor_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060278E9 RID: 162025 RVA: 0x009949E4 File Offset: 0x00992BE4
		[NullableContext(1)]
		public BP_CurveDecalTrailActor_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_CurveDecalTrailActor_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170058BC RID: 22716
		// (get) Token: 0x060278EA RID: 162026 RVA: 0x00994A17 File Offset: 0x00992C17
		// (set) Token: 0x060278EB RID: 162027 RVA: 0x00994A2B File Offset: 0x00992C2B
		public unsafe BP_CurveDecalTrailComponent_C BP_CurveDecalTrailComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_CurveDecalTrailComponent_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CurveDecalTrailActor_C.__PropertyOffset_0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CurveDecalTrailActor_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x170058BD RID: 22717
		// (get) Token: 0x060278EC RID: 162028 RVA: 0x00994A40 File Offset: 0x00992C40
		// (set) Token: 0x060278ED RID: 162029 RVA: 0x00994A54 File Offset: 0x00992C54
		public unsafe USplineComponent Spline
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USplineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CurveDecalTrailActor_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CurveDecalTrailActor_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170058BE RID: 22718
		// (get) Token: 0x060278EE RID: 162030 RVA: 0x00994A69 File Offset: 0x00992C69
		// (set) Token: 0x060278EF RID: 162031 RVA: 0x00994A7D File Offset: 0x00992C7D
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CurveDecalTrailActor_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CurveDecalTrailActor_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x060278F0 RID: 162032 RVA: 0x00994A92 File Offset: 0x00992C92
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Refresh()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CurveDecalTrailActor_C.__Refresh_NativeFunctionPtr, null);
		}

		// Token: 0x060278F1 RID: 162033 RVA: 0x00994AA6 File Offset: 0x00992CA6
		protected BP_CurveDecalTrailActor_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014003 RID: 81923
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/CurveTrailDecal/BP_CurveDecalTrailActor.BP_CurveDecalTrailActor_C";

		// Token: 0x04014004 RID: 81924
		private static IntPtr _ClassPtr;

		// Token: 0x04014005 RID: 81925
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04014006 RID: 81926
		internal static int __PropertyOffset_0;

		// Token: 0x04014007 RID: 81927
		internal static int __PropertyOffset_1;

		// Token: 0x04014008 RID: 81928
		internal static int __PropertyOffset_2;

		// Token: 0x04014009 RID: 81929
		private static IntPtr __Refresh_NativeFunctionPtr;
	}
}

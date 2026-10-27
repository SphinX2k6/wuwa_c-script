using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.CurveTrailDecal
{
	// Token: 0x02003DED RID: 15853
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/CurveTrailDecal/BP_CurveDecalTrailComponent.BP_CurveDecalTrailComponent_C")]
	[UnrealStructLayout(2336, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2336)]
	public class BP_CurveDecalTrailComponent_C : UKuroCurveTrailDecalComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060278F2 RID: 162034 RVA: 0x00994AAF File Offset: 0x00992CAF
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_CurveDecalTrailComponent_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/CurveTrailDecal/BP_CurveDecalTrailComponent.BP_CurveDecalTrailComponent_C");
			}
			return BP_CurveDecalTrailComponent_C._ClassPtr;
		}

		// Token: 0x060278F3 RID: 162035 RVA: 0x00994AD4 File Offset: 0x00992CD4
		public BP_CurveDecalTrailComponent_C() : this(BuiltinUtils.AllocNativeUObject(BP_CurveDecalTrailComponent_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060278F4 RID: 162036 RVA: 0x00994AFC File Offset: 0x00992CFC
		[NullableContext(1)]
		public BP_CurveDecalTrailComponent_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_CurveDecalTrailComponent_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060278F5 RID: 162037 RVA: 0x00994B2F File Offset: 0x00992D2F
		protected BP_CurveDecalTrailComponent_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401400A RID: 81930
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/CurveTrailDecal/BP_CurveDecalTrailComponent.BP_CurveDecalTrailComponent_C";

		// Token: 0x0401400B RID: 81931
		private static IntPtr _ClassPtr;

		// Token: 0x0401400C RID: 81932
		private static IntPtr _ClassDefaultObjectPtr;
	}
}

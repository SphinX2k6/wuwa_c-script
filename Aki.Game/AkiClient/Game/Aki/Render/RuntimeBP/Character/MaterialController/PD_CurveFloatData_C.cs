using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController
{
	// Token: 0x0200312E RID: 12590
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Character/MaterialController/PD_CurveFloatData.PD_CurveFloatData_C")]
	[UnrealStructLayout(232, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 228)]
	public class PD_CurveFloatData_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601EF86 RID: 126854 RVA: 0x009226B8 File Offset: 0x009208B8
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (PD_CurveFloatData_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Character/MaterialController/PD_CurveFloatData.PD_CurveFloatData_C");
			}
			return PD_CurveFloatData_C._ClassPtr;
		}

		// Token: 0x0601EF87 RID: 126855 RVA: 0x009226DC File Offset: 0x009208DC
		public PD_CurveFloatData_C() : this(BuiltinUtils.AllocNativeUObject(PD_CurveFloatData_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601EF88 RID: 126856 RVA: 0x00922704 File Offset: 0x00920904
		public PD_CurveFloatData_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(PD_CurveFloatData_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170036BB RID: 14011
		// (get) Token: 0x0601EF89 RID: 126857 RVA: 0x00922738 File Offset: 0x00920938
		// (set) Token: 0x0601EF8A RID: 126858 RVA: 0x00922771 File Offset: 0x00920971
		public FKuroCurveFloat FloatData
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._FloatData) == null)
				{
					result = (this._FloatData = new FKuroCurveFloat(base.NativePtr + (IntPtr)PD_CurveFloatData_C.__PropertyOffset_FloatData, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)PD_CurveFloatData_C.__PropertyOffset_FloatData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170036BC RID: 14012
		// (get) Token: 0x0601EF8B RID: 126859 RVA: 0x00922792 File Offset: 0x00920992
		// (set) Token: 0x0601EF8C RID: 126860 RVA: 0x009227A2 File Offset: 0x009209A2
		public unsafe float Time
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_CurveFloatData_C.__PropertyOffset_Time);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_CurveFloatData_C.__PropertyOffset_Time) = value;
			}
		}

		// Token: 0x0601EF8D RID: 126861 RVA: 0x009227B3 File Offset: 0x009209B3
		protected PD_CurveFloatData_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040107D1 RID: 67537
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Character/MaterialController/PD_CurveFloatData.PD_CurveFloatData_C";

		// Token: 0x040107D2 RID: 67538
		private static IntPtr _ClassPtr;

		// Token: 0x040107D3 RID: 67539
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040107D4 RID: 67540
		internal static int __PropertyOffset_FloatData;

		// Token: 0x040107D5 RID: 67541
		[Nullable(2)]
		private FKuroCurveFloat _FloatData;

		// Token: 0x040107D6 RID: 67542
		internal static int __PropertyOffset_Time;
	}
}

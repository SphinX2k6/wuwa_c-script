using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController
{
	// Token: 0x0200312F RID: 12591
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Character/MaterialController/PD_CurveLinearColorData.PD_CurveLinearColorData_C")]
	[UnrealStructLayout(632, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 628)]
	public class PD_CurveLinearColorData_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601EF8E RID: 126862 RVA: 0x009227BC File Offset: 0x009209BC
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (PD_CurveLinearColorData_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Character/MaterialController/PD_CurveLinearColorData.PD_CurveLinearColorData_C");
			}
			return PD_CurveLinearColorData_C._ClassPtr;
		}

		// Token: 0x0601EF8F RID: 126863 RVA: 0x009227E0 File Offset: 0x009209E0
		public PD_CurveLinearColorData_C() : this(BuiltinUtils.AllocNativeUObject(PD_CurveLinearColorData_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601EF90 RID: 126864 RVA: 0x00922808 File Offset: 0x00920A08
		public PD_CurveLinearColorData_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(PD_CurveLinearColorData_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170036BD RID: 14013
		// (get) Token: 0x0601EF91 RID: 126865 RVA: 0x0092283C File Offset: 0x00920A3C
		// (set) Token: 0x0601EF92 RID: 126866 RVA: 0x00922875 File Offset: 0x00920A75
		public FKuroCurveLinearColor LinearColor
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveLinearColor result;
				if ((result = this._LinearColor) == null)
				{
					result = (this._LinearColor = new FKuroCurveLinearColor(base.NativePtr + (IntPtr)PD_CurveLinearColorData_C.__PropertyOffset_LinearColor, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveLinearColor.StaticStruct(), base.NativePtr + (IntPtr)PD_CurveLinearColorData_C.__PropertyOffset_LinearColor, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170036BE RID: 14014
		// (get) Token: 0x0601EF93 RID: 126867 RVA: 0x00922896 File Offset: 0x00920A96
		// (set) Token: 0x0601EF94 RID: 126868 RVA: 0x009228A6 File Offset: 0x00920AA6
		public unsafe float Time
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_CurveLinearColorData_C.__PropertyOffset_Time);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_CurveLinearColorData_C.__PropertyOffset_Time) = value;
			}
		}

		// Token: 0x0601EF95 RID: 126869 RVA: 0x009228B7 File Offset: 0x00920AB7
		protected PD_CurveLinearColorData_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040107D7 RID: 67543
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Character/MaterialController/PD_CurveLinearColorData.PD_CurveLinearColorData_C";

		// Token: 0x040107D8 RID: 67544
		private static IntPtr _ClassPtr;

		// Token: 0x040107D9 RID: 67545
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040107DA RID: 67546
		internal static int __PropertyOffset_LinearColor;

		// Token: 0x040107DB RID: 67547
		[Nullable(2)]
		private FKuroCurveLinearColor _LinearColor;

		// Token: 0x040107DC RID: 67548
		internal static int __PropertyOffset_Time;
	}
}

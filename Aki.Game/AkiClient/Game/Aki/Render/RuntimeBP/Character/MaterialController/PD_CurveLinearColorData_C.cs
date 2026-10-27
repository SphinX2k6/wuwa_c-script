using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController
{
	// Token: 0x02003E17 RID: 15895
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Character/MaterialController/PD_CurveLinearColorData.PD_CurveLinearColorData_C")]
	[UnrealStructLayout(632, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 628)]
	public class PD_CurveLinearColorData_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06027D7F RID: 163199 RVA: 0x0099CB90 File Offset: 0x0099AD90
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (PD_CurveLinearColorData_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Character/MaterialController/PD_CurveLinearColorData.PD_CurveLinearColorData_C");
			}
			return PD_CurveLinearColorData_C._ClassPtr;
		}

		// Token: 0x06027D80 RID: 163200 RVA: 0x0099CBB4 File Offset: 0x0099ADB4
		public PD_CurveLinearColorData_C() : this(BuiltinUtils.AllocNativeUObject(PD_CurveLinearColorData_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06027D81 RID: 163201 RVA: 0x0099CBDC File Offset: 0x0099ADDC
		public PD_CurveLinearColorData_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(PD_CurveLinearColorData_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005A71 RID: 23153
		// (get) Token: 0x06027D82 RID: 163202 RVA: 0x0099CC10 File Offset: 0x0099AE10
		// (set) Token: 0x06027D83 RID: 163203 RVA: 0x0099CC49 File Offset: 0x0099AE49
		public FKuroCurveLinearColor LinearColor
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveLinearColor result;
				if ((result = this._LinearColor) == null)
				{
					result = (this._LinearColor = new FKuroCurveLinearColor(base.NativePtr + (IntPtr)PD_CurveLinearColorData_C.__PropertyOffset_0, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveLinearColor.StaticStruct(), base.NativePtr + (IntPtr)PD_CurveLinearColorData_C.__PropertyOffset_0, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005A72 RID: 23154
		// (get) Token: 0x06027D84 RID: 163204 RVA: 0x0099CC6A File Offset: 0x0099AE6A
		// (set) Token: 0x06027D85 RID: 163205 RVA: 0x0099CC7A File Offset: 0x0099AE7A
		public unsafe float Time
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_CurveLinearColorData_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_CurveLinearColorData_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x06027D86 RID: 163206 RVA: 0x0099CC8B File Offset: 0x0099AE8B
		protected PD_CurveLinearColorData_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401432C RID: 82732
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Character/MaterialController/PD_CurveLinearColorData.PD_CurveLinearColorData_C";

		// Token: 0x0401432D RID: 82733
		private static IntPtr _ClassPtr;

		// Token: 0x0401432E RID: 82734
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401432F RID: 82735
		internal static int __PropertyOffset_0;

		// Token: 0x04014330 RID: 82736
		[Nullable(2)]
		private FKuroCurveLinearColor _LinearColor;

		// Token: 0x04014331 RID: 82737
		internal static int __PropertyOffset_1;
	}
}

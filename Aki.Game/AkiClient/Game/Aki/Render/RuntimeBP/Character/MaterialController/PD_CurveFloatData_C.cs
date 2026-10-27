using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController
{
	// Token: 0x02003E16 RID: 15894
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Character/MaterialController/PD_CurveFloatData.PD_CurveFloatData_C")]
	[UnrealStructLayout(232, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 228)]
	public class PD_CurveFloatData_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06027D77 RID: 163191 RVA: 0x0099CA8C File Offset: 0x0099AC8C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (PD_CurveFloatData_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Character/MaterialController/PD_CurveFloatData.PD_CurveFloatData_C");
			}
			return PD_CurveFloatData_C._ClassPtr;
		}

		// Token: 0x06027D78 RID: 163192 RVA: 0x0099CAB0 File Offset: 0x0099ACB0
		public PD_CurveFloatData_C() : this(BuiltinUtils.AllocNativeUObject(PD_CurveFloatData_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06027D79 RID: 163193 RVA: 0x0099CAD8 File Offset: 0x0099ACD8
		public PD_CurveFloatData_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(PD_CurveFloatData_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005A6F RID: 23151
		// (get) Token: 0x06027D7A RID: 163194 RVA: 0x0099CB0C File Offset: 0x0099AD0C
		// (set) Token: 0x06027D7B RID: 163195 RVA: 0x0099CB45 File Offset: 0x0099AD45
		public FKuroCurveFloat FloatData
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._FloatData) == null)
				{
					result = (this._FloatData = new FKuroCurveFloat(base.NativePtr + (IntPtr)PD_CurveFloatData_C.__PropertyOffset_0, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)PD_CurveFloatData_C.__PropertyOffset_0, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005A70 RID: 23152
		// (get) Token: 0x06027D7C RID: 163196 RVA: 0x0099CB66 File Offset: 0x0099AD66
		// (set) Token: 0x06027D7D RID: 163197 RVA: 0x0099CB76 File Offset: 0x0099AD76
		public unsafe float Time
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_CurveFloatData_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_CurveFloatData_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x06027D7E RID: 163198 RVA: 0x0099CB87 File Offset: 0x0099AD87
		protected PD_CurveFloatData_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014326 RID: 82726
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Character/MaterialController/PD_CurveFloatData.PD_CurveFloatData_C";

		// Token: 0x04014327 RID: 82727
		private static IntPtr _ClassPtr;

		// Token: 0x04014328 RID: 82728
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04014329 RID: 82729
		internal static int __PropertyOffset_0;

		// Token: 0x0401432A RID: 82730
		[Nullable(2)]
		private FKuroCurveFloat _FloatData;

		// Token: 0x0401432B RID: 82731
		internal static int __PropertyOffset_1;
	}
}

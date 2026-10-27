using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Effect.Trailing
{
	// Token: 0x02003DBF RID: 15807
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Effect/Trailing/PDA_TrailingConfigData.PDA_TrailingConfigData_C")]
	[UnrealStructLayout(360, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 353)]
	public class PDA_TrailingConfigData_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060274C2 RID: 160962 RVA: 0x0098D930 File Offset: 0x0098BB30
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (PDA_TrailingConfigData_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Effect/Trailing/PDA_TrailingConfigData.PDA_TrailingConfigData_C");
			}
			return PDA_TrailingConfigData_C._ClassPtr;
		}

		// Token: 0x060274C3 RID: 160963 RVA: 0x0098D954 File Offset: 0x0098BB54
		public PDA_TrailingConfigData_C() : this(BuiltinUtils.AllocNativeUObject(PDA_TrailingConfigData_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060274C4 RID: 160964 RVA: 0x0098D97C File Offset: 0x0098BB7C
		public PDA_TrailingConfigData_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(PDA_TrailingConfigData_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005749 RID: 22345
		// (get) Token: 0x060274C5 RID: 160965 RVA: 0x0098D9AF File Offset: 0x0098BBAF
		// (set) Token: 0x060274C6 RID: 160966 RVA: 0x0098D9C3 File Offset: 0x0098BBC3
		[Nullable(0)]
		public unsafe TEnumAsByte<ETrailingAttachType> AttachType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_TrailingConfigData_C.__PropertyOffset_0);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)PDA_TrailingConfigData_C.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x1700574A RID: 22346
		// (get) Token: 0x060274C7 RID: 160967 RVA: 0x0098D9D8 File Offset: 0x0098BBD8
		// (set) Token: 0x060274C8 RID: 160968 RVA: 0x0098DA11 File Offset: 0x0098BC11
		public TArray<string> AttachLimbNames
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._AttachLimbNames) == null)
				{
					result = (this._AttachLimbNames = new TArray<string>(base.NativePtr + (IntPtr)PDA_TrailingConfigData_C.__PropertyOffset_1, this));
				}
				return result;
			}
			set
			{
				this.AttachLimbNames.CopyAssign(value);
			}
		}

		// Token: 0x1700574B RID: 22347
		// (get) Token: 0x060274C9 RID: 160969 RVA: 0x0098DA20 File Offset: 0x0098BC20
		// (set) Token: 0x060274CA RID: 160970 RVA: 0x0098DA59 File Offset: 0x0098BC59
		public TArray<FVector> RelativeLocations
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._RelativeLocations) == null)
				{
					result = (this._RelativeLocations = new TArray<FVector>(base.NativePtr + (IntPtr)PDA_TrailingConfigData_C.__PropertyOffset_2, this));
				}
				return result;
			}
			set
			{
				this.RelativeLocations.CopyAssign(value);
			}
		}

		// Token: 0x1700574C RID: 22348
		// (get) Token: 0x060274CB RID: 160971 RVA: 0x0098DA67 File Offset: 0x0098BC67
		// (set) Token: 0x060274CC RID: 160972 RVA: 0x0098DA7B File Offset: 0x0098BC7B
		[Nullable(2)]
		public unsafe UMaterialInterface Material
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + PDA_TrailingConfigData_C.__PropertyOffset_3);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PDA_TrailingConfigData_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x1700574D RID: 22349
		// (get) Token: 0x060274CD RID: 160973 RVA: 0x0098DA90 File Offset: 0x0098BC90
		// (set) Token: 0x060274CE RID: 160974 RVA: 0x0098DAA0 File Offset: 0x0098BCA0
		public unsafe int MaxLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_TrailingConfigData_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_TrailingConfigData_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x1700574E RID: 22350
		// (get) Token: 0x060274CF RID: 160975 RVA: 0x0098DAB1 File Offset: 0x0098BCB1
		// (set) Token: 0x060274D0 RID: 160976 RVA: 0x0098DAC1 File Offset: 0x0098BCC1
		public unsafe int MaxInterpolateCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_TrailingConfigData_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_TrailingConfigData_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x1700574F RID: 22351
		// (get) Token: 0x060274D1 RID: 160977 RVA: 0x0098DAD2 File Offset: 0x0098BCD2
		// (set) Token: 0x060274D2 RID: 160978 RVA: 0x0098DAE2 File Offset: 0x0098BCE2
		public unsafe float LengthUnit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_TrailingConfigData_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_TrailingConfigData_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17005750 RID: 22352
		// (get) Token: 0x060274D3 RID: 160979 RVA: 0x0098DAF3 File Offset: 0x0098BCF3
		// (set) Token: 0x060274D4 RID: 160980 RVA: 0x0098DB03 File Offset: 0x0098BD03
		public unsafe bool UseNormal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_TrailingConfigData_C.__PropertyOffset_7) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_TrailingConfigData_C.__PropertyOffset_7) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005751 RID: 22353
		// (get) Token: 0x060274D5 RID: 160981 RVA: 0x0098DB14 File Offset: 0x0098BD14
		// (set) Token: 0x060274D6 RID: 160982 RVA: 0x0098DB24 File Offset: 0x0098BD24
		public unsafe float AirflowHoldTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_TrailingConfigData_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_TrailingConfigData_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17005752 RID: 22354
		// (get) Token: 0x060274D7 RID: 160983 RVA: 0x0098DB35 File Offset: 0x0098BD35
		// (set) Token: 0x060274D8 RID: 160984 RVA: 0x0098DB45 File Offset: 0x0098BD45
		public unsafe float SmoothIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_TrailingConfigData_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_TrailingConfigData_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17005753 RID: 22355
		// (get) Token: 0x060274D9 RID: 160985 RVA: 0x0098DB56 File Offset: 0x0098BD56
		// (set) Token: 0x060274DA RID: 160986 RVA: 0x0098DB66 File Offset: 0x0098BD66
		public unsafe float UV2Scale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_TrailingConfigData_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_TrailingConfigData_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17005754 RID: 22356
		// (get) Token: 0x060274DB RID: 160987 RVA: 0x0098DB77 File Offset: 0x0098BD77
		// (set) Token: 0x060274DC RID: 160988 RVA: 0x0098DB87 File Offset: 0x0098BD87
		public unsafe float Start
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_TrailingConfigData_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_TrailingConfigData_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17005755 RID: 22357
		// (get) Token: 0x060274DD RID: 160989 RVA: 0x0098DB98 File Offset: 0x0098BD98
		// (set) Token: 0x060274DE RID: 160990 RVA: 0x0098DBA8 File Offset: 0x0098BDA8
		public unsafe float Loop
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_TrailingConfigData_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_TrailingConfigData_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17005756 RID: 22358
		// (get) Token: 0x060274DF RID: 160991 RVA: 0x0098DBB9 File Offset: 0x0098BDB9
		// (set) Token: 0x060274E0 RID: 160992 RVA: 0x0098DBC9 File Offset: 0x0098BDC9
		public unsafe float End
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_TrailingConfigData_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_TrailingConfigData_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17005757 RID: 22359
		// (get) Token: 0x060274E1 RID: 160993 RVA: 0x0098DBDC File Offset: 0x0098BDDC
		// (set) Token: 0x060274E2 RID: 160994 RVA: 0x0098DC15 File Offset: 0x0098BE15
		public TArray<SMaterialControllerFloatParameter> Time_FloatParameter
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SMaterialControllerFloatParameter> result;
				if ((result = this._Time_FloatParameter) == null)
				{
					result = (this._Time_FloatParameter = new TArray<SMaterialControllerFloatParameter>(base.NativePtr + (IntPtr)PDA_TrailingConfigData_C.__PropertyOffset_14, this));
				}
				return result;
			}
			set
			{
				this.Time_FloatParameter.CopyAssign(value);
			}
		}

		// Token: 0x17005758 RID: 22360
		// (get) Token: 0x060274E3 RID: 160995 RVA: 0x0098DC24 File Offset: 0x0098BE24
		// (set) Token: 0x060274E4 RID: 160996 RVA: 0x0098DC5D File Offset: 0x0098BE5D
		public TArray<SMaterialControllerColorParameter> Time_ColorParameter
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SMaterialControllerColorParameter> result;
				if ((result = this._Time_ColorParameter) == null)
				{
					result = (this._Time_ColorParameter = new TArray<SMaterialControllerColorParameter>(base.NativePtr + (IntPtr)PDA_TrailingConfigData_C.__PropertyOffset_15, this));
				}
				return result;
			}
			set
			{
				this.Time_ColorParameter.CopyAssign(value);
			}
		}

		// Token: 0x17005759 RID: 22361
		// (get) Token: 0x060274E5 RID: 160997 RVA: 0x0098DC6B File Offset: 0x0098BE6B
		// (set) Token: 0x060274E6 RID: 160998 RVA: 0x0098DC7B File Offset: 0x0098BE7B
		public unsafe float MaxDensitySpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_TrailingConfigData_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_TrailingConfigData_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x1700575A RID: 22362
		// (get) Token: 0x060274E7 RID: 160999 RVA: 0x0098DC8C File Offset: 0x0098BE8C
		// (set) Token: 0x060274E8 RID: 161000 RVA: 0x0098DCC5 File Offset: 0x0098BEC5
		public FKuroCurveFloat AirflowDensitySpeedScale
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._AirflowDensitySpeedScale) == null)
				{
					result = (this._AirflowDensitySpeedScale = new FKuroCurveFloat(base.NativePtr + (IntPtr)PDA_TrailingConfigData_C.__PropertyOffset_17, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)PDA_TrailingConfigData_C.__PropertyOffset_17, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700575B RID: 22363
		// (get) Token: 0x060274E9 RID: 161001 RVA: 0x0098DCE6 File Offset: 0x0098BEE6
		// (set) Token: 0x060274EA RID: 161002 RVA: 0x0098DCF6 File Offset: 0x0098BEF6
		public unsafe bool DestroyAtOnce
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_TrailingConfigData_C.__PropertyOffset_18) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_TrailingConfigData_C.__PropertyOffset_18) = (value ? 1 : 0);
			}
		}

		// Token: 0x060274EB RID: 161003 RVA: 0x0098DD07 File Offset: 0x0098BF07
		protected PDA_TrailingConfigData_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013D4A RID: 81226
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Effect/Trailing/PDA_TrailingConfigData.PDA_TrailingConfigData_C";

		// Token: 0x04013D4B RID: 81227
		private static IntPtr _ClassPtr;

		// Token: 0x04013D4C RID: 81228
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013D4D RID: 81229
		internal static int __PropertyOffset_0;

		// Token: 0x04013D4E RID: 81230
		internal static int __PropertyOffset_1;

		// Token: 0x04013D4F RID: 81231
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _AttachLimbNames;

		// Token: 0x04013D50 RID: 81232
		internal static int __PropertyOffset_2;

		// Token: 0x04013D51 RID: 81233
		[Nullable(2)]
		private TArray<FVector> _RelativeLocations;

		// Token: 0x04013D52 RID: 81234
		internal static int __PropertyOffset_3;

		// Token: 0x04013D53 RID: 81235
		internal static int __PropertyOffset_4;

		// Token: 0x04013D54 RID: 81236
		internal static int __PropertyOffset_5;

		// Token: 0x04013D55 RID: 81237
		internal static int __PropertyOffset_6;

		// Token: 0x04013D56 RID: 81238
		internal static int __PropertyOffset_7;

		// Token: 0x04013D57 RID: 81239
		internal static int __PropertyOffset_8;

		// Token: 0x04013D58 RID: 81240
		internal static int __PropertyOffset_9;

		// Token: 0x04013D59 RID: 81241
		internal static int __PropertyOffset_10;

		// Token: 0x04013D5A RID: 81242
		internal static int __PropertyOffset_11;

		// Token: 0x04013D5B RID: 81243
		internal static int __PropertyOffset_12;

		// Token: 0x04013D5C RID: 81244
		internal static int __PropertyOffset_13;

		// Token: 0x04013D5D RID: 81245
		internal static int __PropertyOffset_14;

		// Token: 0x04013D5E RID: 81246
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SMaterialControllerFloatParameter> _Time_FloatParameter;

		// Token: 0x04013D5F RID: 81247
		internal static int __PropertyOffset_15;

		// Token: 0x04013D60 RID: 81248
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SMaterialControllerColorParameter> _Time_ColorParameter;

		// Token: 0x04013D61 RID: 81249
		internal static int __PropertyOffset_16;

		// Token: 0x04013D62 RID: 81250
		internal static int __PropertyOffset_17;

		// Token: 0x04013D63 RID: 81251
		[Nullable(2)]
		private FKuroCurveFloat _AirflowDensitySpeedScale;

		// Token: 0x04013D64 RID: 81252
		internal static int __PropertyOffset_18;
	}
}

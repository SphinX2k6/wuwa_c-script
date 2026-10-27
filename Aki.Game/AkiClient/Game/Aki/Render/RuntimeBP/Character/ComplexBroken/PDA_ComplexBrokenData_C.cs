using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Character.ComplexBroken
{
	// Token: 0x02003E30 RID: 15920
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Character/ComplexBroken/PDA_ComplexBrokenData.PDA_ComplexBrokenData_C")]
	[UnrealStructLayout(1456, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1456)]
	public class PDA_ComplexBrokenData_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06027F00 RID: 163584 RVA: 0x0099FEB6 File Offset: 0x0099E0B6
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (PDA_ComplexBrokenData_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Character/ComplexBroken/PDA_ComplexBrokenData.PDA_ComplexBrokenData_C");
			}
			return PDA_ComplexBrokenData_C._ClassPtr;
		}

		// Token: 0x06027F01 RID: 163585 RVA: 0x0099FEDC File Offset: 0x0099E0DC
		public PDA_ComplexBrokenData_C() : this(BuiltinUtils.AllocNativeUObject(PDA_ComplexBrokenData_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06027F02 RID: 163586 RVA: 0x0099FF04 File Offset: 0x0099E104
		public PDA_ComplexBrokenData_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(PDA_ComplexBrokenData_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005AD3 RID: 23251
		// (get) Token: 0x06027F03 RID: 163587 RVA: 0x0099FF37 File Offset: 0x0099E137
		// (set) Token: 0x06027F04 RID: 163588 RVA: 0x0099FF4B File Offset: 0x0099E14B
		[Nullable(2)]
		public unsafe UMaterialInstance MaterialReplace
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + PDA_ComplexBrokenData_C.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PDA_ComplexBrokenData_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x17005AD4 RID: 23252
		// (get) Token: 0x06027F05 RID: 163589 RVA: 0x0099FF60 File Offset: 0x0099E160
		// (set) Token: 0x06027F06 RID: 163590 RVA: 0x0099FF99 File Offset: 0x0099E199
		public TArray<float> PiecesMaskThreshold
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._PiecesMaskThreshold) == null)
				{
					result = (this._PiecesMaskThreshold = new TArray<float>(base.NativePtr + (IntPtr)PDA_ComplexBrokenData_C.__PropertyOffset_1, this));
				}
				return result;
			}
			set
			{
				this.PiecesMaskThreshold.CopyAssign(value);
			}
		}

		// Token: 0x17005AD5 RID: 23253
		// (get) Token: 0x06027F07 RID: 163591 RVA: 0x0099FFA8 File Offset: 0x0099E1A8
		// (set) Token: 0x06027F08 RID: 163592 RVA: 0x0099FFE1 File Offset: 0x0099E1E1
		public SMaterialControllerFloatGroup ExtendMin
		{
			get
			{
				base.FastCheckIsValid();
				SMaterialControllerFloatGroup result;
				if ((result = this._ExtendMin) == null)
				{
					result = (this._ExtendMin = new SMaterialControllerFloatGroup(base.NativePtr + (IntPtr)PDA_ComplexBrokenData_C.__PropertyOffset_2, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SMaterialControllerFloatGroup.StaticStruct(), base.NativePtr + (IntPtr)PDA_ComplexBrokenData_C.__PropertyOffset_2, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005AD6 RID: 23254
		// (get) Token: 0x06027F09 RID: 163593 RVA: 0x009A0004 File Offset: 0x0099E204
		// (set) Token: 0x06027F0A RID: 163594 RVA: 0x009A003D File Offset: 0x0099E23D
		public SMaterialControllerFloatGroup ExtendMax
		{
			get
			{
				base.FastCheckIsValid();
				SMaterialControllerFloatGroup result;
				if ((result = this._ExtendMax) == null)
				{
					result = (this._ExtendMax = new SMaterialControllerFloatGroup(base.NativePtr + (IntPtr)PDA_ComplexBrokenData_C.__PropertyOffset_3, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SMaterialControllerFloatGroup.StaticStruct(), base.NativePtr + (IntPtr)PDA_ComplexBrokenData_C.__PropertyOffset_3, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005AD7 RID: 23255
		// (get) Token: 0x06027F0B RID: 163595 RVA: 0x009A005E File Offset: 0x0099E25E
		// (set) Token: 0x06027F0C RID: 163596 RVA: 0x009A0072 File Offset: 0x0099E272
		[Nullable(2)]
		public unsafe UTexture2D MaskTexture
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + PDA_ComplexBrokenData_C.__PropertyOffset_4);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PDA_ComplexBrokenData_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17005AD8 RID: 23256
		// (get) Token: 0x06027F0D RID: 163597 RVA: 0x009A0087 File Offset: 0x0099E287
		// (set) Token: 0x06027F0E RID: 163598 RVA: 0x009A009B File Offset: 0x0099E29B
		public unsafe FLinearColor MaskUVBiasScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_ComplexBrokenData_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_ComplexBrokenData_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17005AD9 RID: 23257
		// (get) Token: 0x06027F0F RID: 163599 RVA: 0x009A00B0 File Offset: 0x0099E2B0
		// (set) Token: 0x06027F10 RID: 163600 RVA: 0x009A00E9 File Offset: 0x0099E2E9
		public TArray<SMaterialControllerFloatParameter> CustomFloatParameters
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SMaterialControllerFloatParameter> result;
				if ((result = this._CustomFloatParameters) == null)
				{
					result = (this._CustomFloatParameters = new TArray<SMaterialControllerFloatParameter>(base.NativePtr + (IntPtr)PDA_ComplexBrokenData_C.__PropertyOffset_6, this));
				}
				return result;
			}
			set
			{
				this.CustomFloatParameters.CopyAssign(value);
			}
		}

		// Token: 0x17005ADA RID: 23258
		// (get) Token: 0x06027F11 RID: 163601 RVA: 0x009A00F8 File Offset: 0x0099E2F8
		// (set) Token: 0x06027F12 RID: 163602 RVA: 0x009A0131 File Offset: 0x0099E331
		public TArray<SMaterialControllerColorParameter> CustomColorParameters
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SMaterialControllerColorParameter> result;
				if ((result = this._CustomColorParameters) == null)
				{
					result = (this._CustomColorParameters = new TArray<SMaterialControllerColorParameter>(base.NativePtr + (IntPtr)PDA_ComplexBrokenData_C.__PropertyOffset_7, this));
				}
				return result;
			}
			set
			{
				this.CustomColorParameters.CopyAssign(value);
			}
		}

		// Token: 0x17005ADB RID: 23259
		// (get) Token: 0x06027F13 RID: 163603 RVA: 0x009A0140 File Offset: 0x0099E340
		// (set) Token: 0x06027F14 RID: 163604 RVA: 0x009A0179 File Offset: 0x0099E379
		public SMaterialControllerFloatGroup LoopTime
		{
			get
			{
				base.FastCheckIsValid();
				SMaterialControllerFloatGroup result;
				if ((result = this._LoopTime) == null)
				{
					result = (this._LoopTime = new SMaterialControllerFloatGroup(base.NativePtr + (IntPtr)PDA_ComplexBrokenData_C.__PropertyOffset_8, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SMaterialControllerFloatGroup.StaticStruct(), base.NativePtr + (IntPtr)PDA_ComplexBrokenData_C.__PropertyOffset_8, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06027F15 RID: 163605 RVA: 0x009A019A File Offset: 0x0099E39A
		protected PDA_ComplexBrokenData_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014453 RID: 83027
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Character/ComplexBroken/PDA_ComplexBrokenData.PDA_ComplexBrokenData_C";

		// Token: 0x04014454 RID: 83028
		private static IntPtr _ClassPtr;

		// Token: 0x04014455 RID: 83029
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04014456 RID: 83030
		internal static int __PropertyOffset_0;

		// Token: 0x04014457 RID: 83031
		internal static int __PropertyOffset_1;

		// Token: 0x04014458 RID: 83032
		[Nullable(2)]
		private TArray<float> _PiecesMaskThreshold;

		// Token: 0x04014459 RID: 83033
		internal static int __PropertyOffset_2;

		// Token: 0x0401445A RID: 83034
		[Nullable(2)]
		private SMaterialControllerFloatGroup _ExtendMin;

		// Token: 0x0401445B RID: 83035
		internal static int __PropertyOffset_3;

		// Token: 0x0401445C RID: 83036
		[Nullable(2)]
		private SMaterialControllerFloatGroup _ExtendMax;

		// Token: 0x0401445D RID: 83037
		internal static int __PropertyOffset_4;

		// Token: 0x0401445E RID: 83038
		internal static int __PropertyOffset_5;

		// Token: 0x0401445F RID: 83039
		internal static int __PropertyOffset_6;

		// Token: 0x04014460 RID: 83040
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SMaterialControllerFloatParameter> _CustomFloatParameters;

		// Token: 0x04014461 RID: 83041
		internal static int __PropertyOffset_7;

		// Token: 0x04014462 RID: 83042
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SMaterialControllerColorParameter> _CustomColorParameters;

		// Token: 0x04014463 RID: 83043
		internal static int __PropertyOffset_8;

		// Token: 0x04014464 RID: 83044
		[Nullable(2)]
		private SMaterialControllerFloatGroup _LoopTime;
	}
}

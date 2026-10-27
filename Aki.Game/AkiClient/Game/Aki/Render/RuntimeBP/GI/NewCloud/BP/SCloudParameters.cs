using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.GI.NewCloud.BP
{
	// Token: 0x02003D66 RID: 15718
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/GI/NewCloud/BP/SCloudParameters.SCloudParameters")]
	[UnrealStructLayout(200, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 200)]
	public class SCloudParameters : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060268EF RID: 157935 RVA: 0x00978588 File Offset: 0x00976788
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SCloudParameters._ScriptStructPtr != 0) ? SCloudParameters._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/GI/NewCloud/BP/SCloudParameters.SCloudParameters", ref SCloudParameters._ScriptStructPtr);
		}

		// Token: 0x170052F6 RID: 21238
		// (get) Token: 0x060268F0 RID: 157936 RVA: 0x009785AC File Offset: 0x009767AC
		// (set) Token: 0x060268F1 RID: 157937 RVA: 0x009785C0 File Offset: 0x009767C0
		public unsafe UTexture Mask
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + SCloudParameters.__PropertyOffset_0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SCloudParameters.__PropertyOffset_0, value);
			}
		}

		// Token: 0x170052F7 RID: 21239
		// (get) Token: 0x060268F2 RID: 157938 RVA: 0x009785D5 File Offset: 0x009767D5
		// (set) Token: 0x060268F3 RID: 157939 RVA: 0x009785E5 File Offset: 0x009767E5
		public unsafe bool YesUV1NoUV2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCloudParameters.__PropertyOffset_1) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCloudParameters.__PropertyOffset_1) = (value ? 1 : 0);
			}
		}

		// Token: 0x170052F8 RID: 21240
		// (get) Token: 0x060268F4 RID: 157940 RVA: 0x009785F6 File Offset: 0x009767F6
		// (set) Token: 0x060268F5 RID: 157941 RVA: 0x00978606 File Offset: 0x00976806
		public unsafe int UVTiling
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCloudParameters.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCloudParameters.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x170052F9 RID: 21241
		// (get) Token: 0x060268F6 RID: 157942 RVA: 0x00978617 File Offset: 0x00976817
		// (set) Token: 0x060268F7 RID: 157943 RVA: 0x00978627 File Offset: 0x00976827
		public unsafe float CloudAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCloudParameters.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCloudParameters.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x170052FA RID: 21242
		// (get) Token: 0x060268F8 RID: 157944 RVA: 0x00978638 File Offset: 0x00976838
		// (set) Token: 0x060268F9 RID: 157945 RVA: 0x00978648 File Offset: 0x00976848
		public unsafe float CloudSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCloudParameters.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCloudParameters.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x170052FB RID: 21243
		// (get) Token: 0x060268FA RID: 157946 RVA: 0x00978659 File Offset: 0x00976859
		// (set) Token: 0x060268FB RID: 157947 RVA: 0x00978669 File Offset: 0x00976869
		public unsafe bool CloudRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCloudParameters.__PropertyOffset_5) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCloudParameters.__PropertyOffset_5) = (value ? 1 : 0);
			}
		}

		// Token: 0x170052FC RID: 21244
		// (get) Token: 0x060268FC RID: 157948 RVA: 0x0097867A File Offset: 0x0097687A
		// (set) Token: 0x060268FD RID: 157949 RVA: 0x0097868E File Offset: 0x0097688E
		public unsafe UTexture NoiseMap
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + SCloudParameters.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SCloudParameters.__PropertyOffset_6, value);
			}
		}

		// Token: 0x170052FD RID: 21245
		// (get) Token: 0x060268FE RID: 157950 RVA: 0x009786A3 File Offset: 0x009768A3
		// (set) Token: 0x060268FF RID: 157951 RVA: 0x009786B3 File Offset: 0x009768B3
		public unsafe float NoiseSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCloudParameters.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCloudParameters.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x170052FE RID: 21246
		// (get) Token: 0x06026900 RID: 157952 RVA: 0x009786C4 File Offset: 0x009768C4
		// (set) Token: 0x06026901 RID: 157953 RVA: 0x009786D4 File Offset: 0x009768D4
		public unsafe float NoiseStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCloudParameters.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCloudParameters.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x170052FF RID: 21247
		// (get) Token: 0x06026902 RID: 157954 RVA: 0x009786E5 File Offset: 0x009768E5
		// (set) Token: 0x06026903 RID: 157955 RVA: 0x009786F5 File Offset: 0x009768F5
		public unsafe float NoiseTilling
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCloudParameters.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCloudParameters.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17005300 RID: 21248
		// (get) Token: 0x06026904 RID: 157956 RVA: 0x00978706 File Offset: 0x00976906
		// (set) Token: 0x06026905 RID: 157957 RVA: 0x00978716 File Offset: 0x00976916
		public unsafe bool SDF_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCloudParameters.__PropertyOffset_10) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCloudParameters.__PropertyOffset_10) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005301 RID: 21249
		// (get) Token: 0x06026906 RID: 157958 RVA: 0x00978728 File Offset: 0x00976928
		// (set) Token: 0x06026907 RID: 157959 RVA: 0x0097876B File Offset: 0x0097696B
		[Nullable(1)]
		public FKuroCurveFloat SDFTime
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._SDFTime) == null)
				{
					result = (this._SDFTime = new FKuroCurveFloat(base.NativePtr + (IntPtr)SCloudParameters.__PropertyOffset_11, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)SCloudParameters.__PropertyOffset_11, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06026908 RID: 157960 RVA: 0x0097878C File Offset: 0x0097698C
		public SCloudParameters()
		{
		}

		// Token: 0x06026909 RID: 157961 RVA: 0x00978794 File Offset: 0x00976994
		[NullableContext(1)]
		public SCloudParameters(UTexture Mask, bool YesUV1NoUV2, int UVTiling, float CloudAngle, float CloudSpeed, bool CloudRotation, UTexture NoiseMap, float NoiseSpeed, float NoiseStrength, float NoiseTilling, bool SDF_, FKuroCurveFloat SDFTime)
		{
			this.Mask = Mask;
			this.YesUV1NoUV2 = YesUV1NoUV2;
			this.UVTiling = UVTiling;
			this.CloudAngle = CloudAngle;
			this.CloudSpeed = CloudSpeed;
			this.CloudRotation = CloudRotation;
			this.NoiseMap = NoiseMap;
			this.NoiseSpeed = NoiseSpeed;
			this.NoiseStrength = NoiseStrength;
			this.NoiseTilling = NoiseTilling;
			this.SDF_ = SDF_;
			this.SDFTime = SDFTime;
		}

		// Token: 0x0602690A RID: 157962 RVA: 0x00978804 File Offset: 0x00976A04
		protected override IntPtr GetUStructPtr()
		{
			return SCloudParameters.StaticStruct();
		}

		// Token: 0x0602690B RID: 157963 RVA: 0x00978810 File Offset: 0x00976A10
		public SCloudParameters(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602690C RID: 157964 RVA: 0x0097881A File Offset: 0x00976A1A
		public SCloudParameters(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602690D RID: 157965 RVA: 0x00978825 File Offset: 0x00976A25
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SCloudParameters(Pointer, false, true);
		}

		// Token: 0x0602690E RID: 157966 RVA: 0x0097882F File Offset: 0x00976A2F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SCloudParameters(Pointer, MemoryOwner);
		}

		// Token: 0x0401360C RID: 79372
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/GI/NewCloud/BP/SCloudParameters.SCloudParameters";

		// Token: 0x0401360D RID: 79373
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401360E RID: 79374
		internal static int __PropertyOffset_0;

		// Token: 0x0401360F RID: 79375
		internal static int __PropertyOffset_1;

		// Token: 0x04013610 RID: 79376
		internal static int __PropertyOffset_2;

		// Token: 0x04013611 RID: 79377
		internal static int __PropertyOffset_3;

		// Token: 0x04013612 RID: 79378
		internal static int __PropertyOffset_4;

		// Token: 0x04013613 RID: 79379
		internal static int __PropertyOffset_5;

		// Token: 0x04013614 RID: 79380
		internal static int __PropertyOffset_6;

		// Token: 0x04013615 RID: 79381
		internal static int __PropertyOffset_7;

		// Token: 0x04013616 RID: 79382
		internal static int __PropertyOffset_8;

		// Token: 0x04013617 RID: 79383
		internal static int __PropertyOffset_9;

		// Token: 0x04013618 RID: 79384
		internal static int __PropertyOffset_10;

		// Token: 0x04013619 RID: 79385
		internal static int __PropertyOffset_11;

		// Token: 0x0401361A RID: 79386
		private FKuroCurveFloat _SDFTime;
	}
}

using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.DecalShadow;
using AkiClient.Game.Aki.Render.RuntimeBP.Scene.LensFlare;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.RenderData
{
	// Token: 0x020030D9 RID: 12505
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/RenderData/PDA_GlobalRenderDataReference.PDA_GlobalRenderDataReference_C")]
	[UnrealStructLayout(168, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 168)]
	public class PDA_GlobalRenderDataReference_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601E2BB RID: 123579 RVA: 0x0090CE78 File Offset: 0x0090B078
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (PDA_GlobalRenderDataReference_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/RenderData/PDA_GlobalRenderDataReference.PDA_GlobalRenderDataReference_C");
			}
			return PDA_GlobalRenderDataReference_C._ClassPtr;
		}

		// Token: 0x0601E2BC RID: 123580 RVA: 0x0090CE9C File Offset: 0x0090B09C
		public PDA_GlobalRenderDataReference_C() : this(BuiltinUtils.AllocNativeUObject(PDA_GlobalRenderDataReference_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601E2BD RID: 123581 RVA: 0x0090CEC4 File Offset: 0x0090B0C4
		[NullableContext(1)]
		public PDA_GlobalRenderDataReference_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(PDA_GlobalRenderDataReference_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700324B RID: 12875
		// (get) Token: 0x0601E2BE RID: 123582 RVA: 0x0090CEF7 File Offset: 0x0090B0F7
		// (set) Token: 0x0601E2BF RID: 123583 RVA: 0x0090CF0B File Offset: 0x0090B10B
		public unsafe UMaterialParameterCollection GlobalShaderParameters
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialParameterCollection>(base.NativePtr / (IntPtr)sizeof(void*) + PDA_GlobalRenderDataReference_C.__PropertyOffset_GlobalShaderParameters);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PDA_GlobalRenderDataReference_C.__PropertyOffset_GlobalShaderParameters, value);
			}
		}

		// Token: 0x1700324C RID: 12876
		// (get) Token: 0x0601E2C0 RID: 123584 RVA: 0x0090CF20 File Offset: 0x0090B120
		// (set) Token: 0x0601E2C1 RID: 123585 RVA: 0x0090CF34 File Offset: 0x0090B134
		public unsafe UMaterialParameterCollection SceneInteractionShaderParameters
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialParameterCollection>(base.NativePtr / (IntPtr)sizeof(void*) + PDA_GlobalRenderDataReference_C.__PropertyOffset_SceneInteractionShaderParameters);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PDA_GlobalRenderDataReference_C.__PropertyOffset_SceneInteractionShaderParameters, value);
			}
		}

		// Token: 0x1700324D RID: 12877
		// (get) Token: 0x0601E2C2 RID: 123586 RVA: 0x0090CF49 File Offset: 0x0090B149
		// (set) Token: 0x0601E2C3 RID: 123587 RVA: 0x0090CF5D File Offset: 0x0090B15D
		public unsafe PDA_ModelLensFlareConfig_C GlobalLensFlareConfig
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<PDA_ModelLensFlareConfig_C>(base.NativePtr / (IntPtr)sizeof(void*) + PDA_GlobalRenderDataReference_C.__PropertyOffset_GlobalLensFlareConfig);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PDA_GlobalRenderDataReference_C.__PropertyOffset_GlobalLensFlareConfig, value);
			}
		}

		// Token: 0x1700324E RID: 12878
		// (get) Token: 0x0601E2C4 RID: 123588 RVA: 0x0090CF72 File Offset: 0x0090B172
		// (set) Token: 0x0601E2C5 RID: 123589 RVA: 0x0090CF86 File Offset: 0x0090B186
		public unsafe UMaterialParameterCollection MPC_ShowBrightness
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialParameterCollection>(base.NativePtr / (IntPtr)sizeof(void*) + PDA_GlobalRenderDataReference_C.__PropertyOffset_MPC_ShowBrightness);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PDA_GlobalRenderDataReference_C.__PropertyOffset_MPC_ShowBrightness, value);
			}
		}

		// Token: 0x1700324F RID: 12879
		// (get) Token: 0x0601E2C6 RID: 123590 RVA: 0x0090CF9B File Offset: 0x0090B19B
		// (set) Token: 0x0601E2C7 RID: 123591 RVA: 0x0090CFAF File Offset: 0x0090B1AF
		public unsafe PDA_DecalShadowConfig_C DefaultDecalShadow
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<PDA_DecalShadowConfig_C>(base.NativePtr / (IntPtr)sizeof(void*) + PDA_GlobalRenderDataReference_C.__PropertyOffset_DefaultDecalShadow);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PDA_GlobalRenderDataReference_C.__PropertyOffset_DefaultDecalShadow, value);
			}
		}

		// Token: 0x17003250 RID: 12880
		// (get) Token: 0x0601E2C8 RID: 123592 RVA: 0x0090CFC4 File Offset: 0x0090B1C4
		// (set) Token: 0x0601E2C9 RID: 123593 RVA: 0x0090CFD8 File Offset: 0x0090B1D8
		public unsafe UMaterialParameterCollection EyesParameters
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialParameterCollection>(base.NativePtr / (IntPtr)sizeof(void*) + PDA_GlobalRenderDataReference_C.__PropertyOffset_EyesParameters);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PDA_GlobalRenderDataReference_C.__PropertyOffset_EyesParameters, value);
			}
		}

		// Token: 0x17003251 RID: 12881
		// (get) Token: 0x0601E2CA RID: 123594 RVA: 0x0090CFED File Offset: 0x0090B1ED
		// (set) Token: 0x0601E2CB RID: 123595 RVA: 0x0090D001 File Offset: 0x0090B201
		public unsafe UMaterialInterface EmptyMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + PDA_GlobalRenderDataReference_C.__PropertyOffset_EmptyMaterial);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PDA_GlobalRenderDataReference_C.__PropertyOffset_EmptyMaterial, value);
			}
		}

		// Token: 0x17003252 RID: 12882
		// (get) Token: 0x0601E2CC RID: 123596 RVA: 0x0090D016 File Offset: 0x0090B216
		// (set) Token: 0x0601E2CD RID: 123597 RVA: 0x0090D02A File Offset: 0x0090B22A
		public unsafe UMaterialParameterCollection MPC_ShowColorSetting
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialParameterCollection>(base.NativePtr / (IntPtr)sizeof(void*) + PDA_GlobalRenderDataReference_C.__PropertyOffset_MPC_ShowColorSetting);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PDA_GlobalRenderDataReference_C.__PropertyOffset_MPC_ShowColorSetting, value);
			}
		}

		// Token: 0x17003253 RID: 12883
		// (get) Token: 0x0601E2CE RID: 123598 RVA: 0x0090D03F File Offset: 0x0090B23F
		// (set) Token: 0x0601E2CF RID: 123599 RVA: 0x0090D053 File Offset: 0x0090B253
		public unsafe UMaterialParameterCollection MPC_GroundFogMask
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialParameterCollection>(base.NativePtr / (IntPtr)sizeof(void*) + PDA_GlobalRenderDataReference_C.__PropertyOffset_MPC_GroundFogMask);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PDA_GlobalRenderDataReference_C.__PropertyOffset_MPC_GroundFogMask, value);
			}
		}

		// Token: 0x17003254 RID: 12884
		// (get) Token: 0x0601E2D0 RID: 123600 RVA: 0x0090D068 File Offset: 0x0090B268
		// (set) Token: 0x0601E2D1 RID: 123601 RVA: 0x0090D07C File Offset: 0x0090B27C
		public unsafe UMaterialParameterCollection MPC_SceneCaptureParameter
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialParameterCollection>(base.NativePtr / (IntPtr)sizeof(void*) + PDA_GlobalRenderDataReference_C.__PropertyOffset_MPC_SceneCaptureParameter);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PDA_GlobalRenderDataReference_C.__PropertyOffset_MPC_SceneCaptureParameter, value);
			}
		}

		// Token: 0x17003255 RID: 12885
		// (get) Token: 0x0601E2D2 RID: 123602 RVA: 0x0090D091 File Offset: 0x0090B291
		// (set) Token: 0x0601E2D3 RID: 123603 RVA: 0x0090D0A5 File Offset: 0x0090B2A5
		public unsafe UMaterialParameterCollection MPC_ForGameplayParameter
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialParameterCollection>(base.NativePtr / (IntPtr)sizeof(void*) + PDA_GlobalRenderDataReference_C.__PropertyOffset_MPC_ForGameplayParameter);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PDA_GlobalRenderDataReference_C.__PropertyOffset_MPC_ForGameplayParameter, value);
			}
		}

		// Token: 0x0601E2D4 RID: 123604 RVA: 0x0090D0BA File Offset: 0x0090B2BA
		protected PDA_GlobalRenderDataReference_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FF60 RID: 65376
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/RenderData/PDA_GlobalRenderDataReference.PDA_GlobalRenderDataReference_C";

		// Token: 0x0400FF61 RID: 65377
		private static IntPtr _ClassPtr;

		// Token: 0x0400FF62 RID: 65378
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FF63 RID: 65379
		internal static int __PropertyOffset_GlobalShaderParameters;

		// Token: 0x0400FF64 RID: 65380
		internal static int __PropertyOffset_SceneInteractionShaderParameters;

		// Token: 0x0400FF65 RID: 65381
		internal static int __PropertyOffset_GlobalLensFlareConfig;

		// Token: 0x0400FF66 RID: 65382
		internal static int __PropertyOffset_MPC_ShowBrightness;

		// Token: 0x0400FF67 RID: 65383
		internal static int __PropertyOffset_DefaultDecalShadow;

		// Token: 0x0400FF68 RID: 65384
		internal static int __PropertyOffset_EyesParameters;

		// Token: 0x0400FF69 RID: 65385
		internal static int __PropertyOffset_EmptyMaterial;

		// Token: 0x0400FF6A RID: 65386
		internal static int __PropertyOffset_MPC_ShowColorSetting;

		// Token: 0x0400FF6B RID: 65387
		internal static int __PropertyOffset_MPC_GroundFogMask;

		// Token: 0x0400FF6C RID: 65388
		internal static int __PropertyOffset_MPC_SceneCaptureParameter;

		// Token: 0x0400FF6D RID: 65389
		internal static int __PropertyOffset_MPC_ForGameplayParameter;
	}
}

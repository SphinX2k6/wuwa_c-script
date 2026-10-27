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
	// Token: 0x02003BBB RID: 15291
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/RenderData/PDA_GlobalRenderDataReference.PDA_GlobalRenderDataReference_C")]
	[UnrealStructLayout(168, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 168)]
	public class PDA_GlobalRenderDataReference_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060222A5 RID: 139941 RVA: 0x00901664 File Offset: 0x008FF864
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (PDA_GlobalRenderDataReference_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/RenderData/PDA_GlobalRenderDataReference.PDA_GlobalRenderDataReference_C");
			}
			return PDA_GlobalRenderDataReference_C._ClassPtr;
		}

		// Token: 0x060222A6 RID: 139942 RVA: 0x00901688 File Offset: 0x008FF888
		public PDA_GlobalRenderDataReference_C() : this(BuiltinUtils.AllocNativeUObject(PDA_GlobalRenderDataReference_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060222A7 RID: 139943 RVA: 0x009016B0 File Offset: 0x008FF8B0
		[NullableContext(1)]
		public PDA_GlobalRenderDataReference_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(PDA_GlobalRenderDataReference_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003A0A RID: 14858
		// (get) Token: 0x060222A8 RID: 139944 RVA: 0x009016E3 File Offset: 0x008FF8E3
		// (set) Token: 0x060222A9 RID: 139945 RVA: 0x009016F7 File Offset: 0x008FF8F7
		public unsafe UMaterialParameterCollection GlobalShaderParameters
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialParameterCollection>(base.NativePtr / (IntPtr)sizeof(void*) + PDA_GlobalRenderDataReference_C.__PropertyOffset_0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PDA_GlobalRenderDataReference_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x17003A0B RID: 14859
		// (get) Token: 0x060222AA RID: 139946 RVA: 0x0090170C File Offset: 0x008FF90C
		// (set) Token: 0x060222AB RID: 139947 RVA: 0x00901720 File Offset: 0x008FF920
		public unsafe UMaterialParameterCollection SceneInteractionShaderParameters
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialParameterCollection>(base.NativePtr / (IntPtr)sizeof(void*) + PDA_GlobalRenderDataReference_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PDA_GlobalRenderDataReference_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17003A0C RID: 14860
		// (get) Token: 0x060222AC RID: 139948 RVA: 0x00901735 File Offset: 0x008FF935
		// (set) Token: 0x060222AD RID: 139949 RVA: 0x00901749 File Offset: 0x008FF949
		public unsafe PDA_ModelLensFlareConfig_C GlobalLensFlareConfig
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<PDA_ModelLensFlareConfig_C>(base.NativePtr / (IntPtr)sizeof(void*) + PDA_GlobalRenderDataReference_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PDA_GlobalRenderDataReference_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17003A0D RID: 14861
		// (get) Token: 0x060222AE RID: 139950 RVA: 0x0090175E File Offset: 0x008FF95E
		// (set) Token: 0x060222AF RID: 139951 RVA: 0x00901772 File Offset: 0x008FF972
		public unsafe UMaterialParameterCollection MPC_ShowBrightness
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialParameterCollection>(base.NativePtr / (IntPtr)sizeof(void*) + PDA_GlobalRenderDataReference_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PDA_GlobalRenderDataReference_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17003A0E RID: 14862
		// (get) Token: 0x060222B0 RID: 139952 RVA: 0x00901787 File Offset: 0x008FF987
		// (set) Token: 0x060222B1 RID: 139953 RVA: 0x0090179B File Offset: 0x008FF99B
		public unsafe PDA_DecalShadowConfig_C DefaultDecalShadow
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<PDA_DecalShadowConfig_C>(base.NativePtr / (IntPtr)sizeof(void*) + PDA_GlobalRenderDataReference_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PDA_GlobalRenderDataReference_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17003A0F RID: 14863
		// (get) Token: 0x060222B2 RID: 139954 RVA: 0x009017B0 File Offset: 0x008FF9B0
		// (set) Token: 0x060222B3 RID: 139955 RVA: 0x009017C4 File Offset: 0x008FF9C4
		public unsafe UMaterialParameterCollection EyesParameters
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialParameterCollection>(base.NativePtr / (IntPtr)sizeof(void*) + PDA_GlobalRenderDataReference_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PDA_GlobalRenderDataReference_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17003A10 RID: 14864
		// (get) Token: 0x060222B4 RID: 139956 RVA: 0x009017D9 File Offset: 0x008FF9D9
		// (set) Token: 0x060222B5 RID: 139957 RVA: 0x009017ED File Offset: 0x008FF9ED
		public unsafe UMaterialInterface EmptyMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + PDA_GlobalRenderDataReference_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PDA_GlobalRenderDataReference_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x17003A11 RID: 14865
		// (get) Token: 0x060222B6 RID: 139958 RVA: 0x00901802 File Offset: 0x008FFA02
		// (set) Token: 0x060222B7 RID: 139959 RVA: 0x00901816 File Offset: 0x008FFA16
		public unsafe UMaterialParameterCollection MPC_ShowColorSetting
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialParameterCollection>(base.NativePtr / (IntPtr)sizeof(void*) + PDA_GlobalRenderDataReference_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PDA_GlobalRenderDataReference_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x17003A12 RID: 14866
		// (get) Token: 0x060222B8 RID: 139960 RVA: 0x0090182B File Offset: 0x008FFA2B
		// (set) Token: 0x060222B9 RID: 139961 RVA: 0x0090183F File Offset: 0x008FFA3F
		public unsafe UMaterialParameterCollection MPC_GroundFogMask
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialParameterCollection>(base.NativePtr / (IntPtr)sizeof(void*) + PDA_GlobalRenderDataReference_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PDA_GlobalRenderDataReference_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x17003A13 RID: 14867
		// (get) Token: 0x060222BA RID: 139962 RVA: 0x00901854 File Offset: 0x008FFA54
		// (set) Token: 0x060222BB RID: 139963 RVA: 0x00901868 File Offset: 0x008FFA68
		public unsafe UMaterialParameterCollection MPC_SceneCaptureParameter
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialParameterCollection>(base.NativePtr / (IntPtr)sizeof(void*) + PDA_GlobalRenderDataReference_C.__PropertyOffset_9);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PDA_GlobalRenderDataReference_C.__PropertyOffset_9, value);
			}
		}

		// Token: 0x17003A14 RID: 14868
		// (get) Token: 0x060222BC RID: 139964 RVA: 0x0090187D File Offset: 0x008FFA7D
		// (set) Token: 0x060222BD RID: 139965 RVA: 0x00901891 File Offset: 0x008FFA91
		public unsafe UMaterialParameterCollection MPC_ForGameplayParameter
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialParameterCollection>(base.NativePtr / (IntPtr)sizeof(void*) + PDA_GlobalRenderDataReference_C.__PropertyOffset_10);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PDA_GlobalRenderDataReference_C.__PropertyOffset_10, value);
			}
		}

		// Token: 0x060222BE RID: 139966 RVA: 0x009018A6 File Offset: 0x008FFAA6
		protected PDA_GlobalRenderDataReference_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010BD1 RID: 68561
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/RenderData/PDA_GlobalRenderDataReference.PDA_GlobalRenderDataReference_C";

		// Token: 0x04010BD2 RID: 68562
		private static IntPtr _ClassPtr;

		// Token: 0x04010BD3 RID: 68563
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010BD4 RID: 68564
		internal static int __PropertyOffset_0;

		// Token: 0x04010BD5 RID: 68565
		internal static int __PropertyOffset_1;

		// Token: 0x04010BD6 RID: 68566
		internal static int __PropertyOffset_2;

		// Token: 0x04010BD7 RID: 68567
		internal static int __PropertyOffset_3;

		// Token: 0x04010BD8 RID: 68568
		internal static int __PropertyOffset_4;

		// Token: 0x04010BD9 RID: 68569
		internal static int __PropertyOffset_5;

		// Token: 0x04010BDA RID: 68570
		internal static int __PropertyOffset_6;

		// Token: 0x04010BDB RID: 68571
		internal static int __PropertyOffset_7;

		// Token: 0x04010BDC RID: 68572
		internal static int __PropertyOffset_8;

		// Token: 0x04010BDD RID: 68573
		internal static int __PropertyOffset_9;

		// Token: 0x04010BDE RID: 68574
		internal static int __PropertyOffset_10;
	}
}

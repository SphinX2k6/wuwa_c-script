using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.DecalShadow
{
	// Token: 0x02003117 RID: 12567
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/DecalShadow/PDA_DecalShadowConfig.PDA_DecalShadowConfig_C")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class PDA_DecalShadowConfig_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601EC90 RID: 126096 RVA: 0x0091D3E9 File Offset: 0x0091B5E9
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (PDA_DecalShadowConfig_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/DecalShadow/PDA_DecalShadowConfig.PDA_DecalShadowConfig_C");
			}
			return PDA_DecalShadowConfig_C._ClassPtr;
		}

		// Token: 0x0601EC91 RID: 126097 RVA: 0x0091D410 File Offset: 0x0091B610
		public PDA_DecalShadowConfig_C() : this(BuiltinUtils.AllocNativeUObject(PDA_DecalShadowConfig_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601EC92 RID: 126098 RVA: 0x0091D438 File Offset: 0x0091B638
		[NullableContext(1)]
		public PDA_DecalShadowConfig_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(PDA_DecalShadowConfig_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003589 RID: 13705
		// (get) Token: 0x0601EC93 RID: 126099 RVA: 0x0091D46B File Offset: 0x0091B66B
		// (set) Token: 0x0601EC94 RID: 126100 RVA: 0x0091D47F File Offset: 0x0091B67F
		[Nullable(2)]
		public unsafe UMaterialInterface DecalShadowMaterial
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + PDA_DecalShadowConfig_C.__PropertyOffset_DecalShadowMaterial);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PDA_DecalShadowConfig_C.__PropertyOffset_DecalShadowMaterial, value);
			}
		}

		// Token: 0x1700358A RID: 13706
		// (get) Token: 0x0601EC95 RID: 126101 RVA: 0x0091D494 File Offset: 0x0091B694
		// (set) Token: 0x0601EC96 RID: 126102 RVA: 0x0091D4A4 File Offset: 0x0091B6A4
		public unsafe float DecalBoxScaleHori
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_DecalShadowConfig_C.__PropertyOffset_DecalBoxScaleHori);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_DecalShadowConfig_C.__PropertyOffset_DecalBoxScaleHori) = value;
			}
		}

		// Token: 0x1700358B RID: 13707
		// (get) Token: 0x0601EC97 RID: 126103 RVA: 0x0091D4B5 File Offset: 0x0091B6B5
		// (set) Token: 0x0601EC98 RID: 126104 RVA: 0x0091D4C5 File Offset: 0x0091B6C5
		public unsafe float DecalBoxScaleVerti
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_DecalShadowConfig_C.__PropertyOffset_DecalBoxScaleVerti);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_DecalShadowConfig_C.__PropertyOffset_DecalBoxScaleVerti) = value;
			}
		}

		// Token: 0x1700358C RID: 13708
		// (get) Token: 0x0601EC99 RID: 126105 RVA: 0x0091D4D6 File Offset: 0x0091B6D6
		// (set) Token: 0x0601EC9A RID: 126106 RVA: 0x0091D4E6 File Offset: 0x0091B6E6
		public unsafe float ZDistanceFadeFactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_DecalShadowConfig_C.__PropertyOffset_ZDistanceFadeFactor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_DecalShadowConfig_C.__PropertyOffset_ZDistanceFadeFactor) = value;
			}
		}

		// Token: 0x1700358D RID: 13709
		// (get) Token: 0x0601EC9B RID: 126107 RVA: 0x0091D4F7 File Offset: 0x0091B6F7
		// (set) Token: 0x0601EC9C RID: 126108 RVA: 0x0091D507 File Offset: 0x0091B707
		public unsafe float ZDistanceFadePower
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_DecalShadowConfig_C.__PropertyOffset_ZDistanceFadePower);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_DecalShadowConfig_C.__PropertyOffset_ZDistanceFadePower) = value;
			}
		}

		// Token: 0x0601EC9D RID: 126109 RVA: 0x0091D518 File Offset: 0x0091B718
		protected PDA_DecalShadowConfig_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040105B0 RID: 66992
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/DecalShadow/PDA_DecalShadowConfig.PDA_DecalShadowConfig_C";

		// Token: 0x040105B1 RID: 66993
		private static IntPtr _ClassPtr;

		// Token: 0x040105B2 RID: 66994
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040105B3 RID: 66995
		internal static int __PropertyOffset_DecalShadowMaterial;

		// Token: 0x040105B4 RID: 66996
		internal static int __PropertyOffset_DecalBoxScaleHori;

		// Token: 0x040105B5 RID: 66997
		internal static int __PropertyOffset_DecalBoxScaleVerti;

		// Token: 0x040105B6 RID: 66998
		internal static int __PropertyOffset_ZDistanceFadeFactor;

		// Token: 0x040105B7 RID: 66999
		internal static int __PropertyOffset_ZDistanceFadePower;
	}
}

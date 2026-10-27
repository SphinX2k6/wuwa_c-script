using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.DecalShadow
{
	// Token: 0x02003DE6 RID: 15846
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/DecalShadow/PDA_DecalShadowConfig.PDA_DecalShadowConfig_C")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class PDA_DecalShadowConfig_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602786C RID: 161900 RVA: 0x00993D9C File Offset: 0x00991F9C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (PDA_DecalShadowConfig_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/DecalShadow/PDA_DecalShadowConfig.PDA_DecalShadowConfig_C");
			}
			return PDA_DecalShadowConfig_C._ClassPtr;
		}

		// Token: 0x0602786D RID: 161901 RVA: 0x00993DC0 File Offset: 0x00991FC0
		public PDA_DecalShadowConfig_C() : this(BuiltinUtils.AllocNativeUObject(PDA_DecalShadowConfig_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602786E RID: 161902 RVA: 0x00993DE8 File Offset: 0x00991FE8
		[NullableContext(1)]
		public PDA_DecalShadowConfig_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(PDA_DecalShadowConfig_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005898 RID: 22680
		// (get) Token: 0x0602786F RID: 161903 RVA: 0x00993E1B File Offset: 0x0099201B
		// (set) Token: 0x06027870 RID: 161904 RVA: 0x00993E2F File Offset: 0x0099202F
		[Nullable(2)]
		public unsafe UMaterialInterface DecalShadowMaterial
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + PDA_DecalShadowConfig_C.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PDA_DecalShadowConfig_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x17005899 RID: 22681
		// (get) Token: 0x06027871 RID: 161905 RVA: 0x00993E44 File Offset: 0x00992044
		// (set) Token: 0x06027872 RID: 161906 RVA: 0x00993E54 File Offset: 0x00992054
		public unsafe float DecalBoxScaleHori
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_DecalShadowConfig_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_DecalShadowConfig_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x1700589A RID: 22682
		// (get) Token: 0x06027873 RID: 161907 RVA: 0x00993E65 File Offset: 0x00992065
		// (set) Token: 0x06027874 RID: 161908 RVA: 0x00993E75 File Offset: 0x00992075
		public unsafe float DecalBoxScaleVerti
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_DecalShadowConfig_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_DecalShadowConfig_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x1700589B RID: 22683
		// (get) Token: 0x06027875 RID: 161909 RVA: 0x00993E86 File Offset: 0x00992086
		// (set) Token: 0x06027876 RID: 161910 RVA: 0x00993E96 File Offset: 0x00992096
		public unsafe float ZDistanceFadeFactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_DecalShadowConfig_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_DecalShadowConfig_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x1700589C RID: 22684
		// (get) Token: 0x06027877 RID: 161911 RVA: 0x00993EA7 File Offset: 0x009920A7
		// (set) Token: 0x06027878 RID: 161912 RVA: 0x00993EB7 File Offset: 0x009920B7
		public unsafe float ZDistanceFadePower
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_DecalShadowConfig_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_DecalShadowConfig_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x06027879 RID: 161913 RVA: 0x00993EC8 File Offset: 0x009920C8
		protected PDA_DecalShadowConfig_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013FBD RID: 81853
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/DecalShadow/PDA_DecalShadowConfig.PDA_DecalShadowConfig_C";

		// Token: 0x04013FBE RID: 81854
		private static IntPtr _ClassPtr;

		// Token: 0x04013FBF RID: 81855
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013FC0 RID: 81856
		internal static int __PropertyOffset_0;

		// Token: 0x04013FC1 RID: 81857
		internal static int __PropertyOffset_1;

		// Token: 0x04013FC2 RID: 81858
		internal static int __PropertyOffset_2;

		// Token: 0x04013FC3 RID: 81859
		internal static int __PropertyOffset_3;

		// Token: 0x04013FC4 RID: 81860
		internal static int __PropertyOffset_4;
	}
}

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Light
{
	// Token: 0x02003B2B RID: 15147
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Light/BP_VolumetricSphereLightSuperFar.BP_VolumetricSphereLightSuperFar_C")]
	[UnrealStructLayout(1656, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1652)]
	public class BP_VolumetricSphereLightSuperFar_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject, IInterface_KuroLightBP, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x0602165B RID: 136795 RVA: 0x008EB855 File Offset: 0x008E9A55
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_VolumetricSphereLightSuperFar_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_VolumetricSphereLightSuperFar.BP_VolumetricSphereLightSuperFar_C");
			}
			return BP_VolumetricSphereLightSuperFar_C._ClassPtr;
		}

		// Token: 0x0602165C RID: 136796 RVA: 0x008EB879 File Offset: 0x008E9A79
		int IInterface_KuroLightBP.InterfaceOffset()
		{
			return BP_VolumetricSphereLightSuperFar_C.__InterfaceOffset_IInterface_KuroLightBP;
		}

		// Token: 0x0602165D RID: 136797 RVA: 0x008EB880 File Offset: 0x008E9A80
		public BP_VolumetricSphereLightSuperFar_C() : this(BuiltinUtils.AllocNativeUObject(BP_VolumetricSphereLightSuperFar_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602165E RID: 136798 RVA: 0x008EB8A8 File Offset: 0x008E9AA8
		[NullableContext(1)]
		public BP_VolumetricSphereLightSuperFar_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_VolumetricSphereLightSuperFar_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700364B RID: 13899
		// (get) Token: 0x0602165F RID: 136799 RVA: 0x008EB8DB File Offset: 0x008E9ADB
		// (set) Token: 0x06021660 RID: 136800 RVA: 0x008EB8EF File Offset: 0x008E9AEF
		public unsafe UBillboardComponent Billboard
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBillboardComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricSphereLightSuperFar_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricSphereLightSuperFar_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x1700364C RID: 13900
		// (get) Token: 0x06021661 RID: 136801 RVA: 0x008EB904 File Offset: 0x008E9B04
		// (set) Token: 0x06021662 RID: 136802 RVA: 0x008EB918 File Offset: 0x008E9B18
		public unsafe UStaticMeshComponent StaticMeshComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricSphereLightSuperFar_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricSphereLightSuperFar_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x1700364D RID: 13901
		// (get) Token: 0x06021663 RID: 136803 RVA: 0x008EB92D File Offset: 0x008E9B2D
		// (set) Token: 0x06021664 RID: 136804 RVA: 0x008EB941 File Offset: 0x008E9B41
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricSphereLightSuperFar_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricSphereLightSuperFar_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x1700364E RID: 13902
		// (get) Token: 0x06021665 RID: 136805 RVA: 0x008EB956 File Offset: 0x008E9B56
		// (set) Token: 0x06021666 RID: 136806 RVA: 0x008EB96A File Offset: 0x008E9B6A
		public unsafe UStaticMesh SphereLightStaticMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricSphereLightSuperFar_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricSphereLightSuperFar_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x1700364F RID: 13903
		// (get) Token: 0x06021667 RID: 136807 RVA: 0x008EB97F File Offset: 0x008E9B7F
		// (set) Token: 0x06021668 RID: 136808 RVA: 0x008EB993 File Offset: 0x008E9B93
		public unsafe UMaterialInstanceDynamic MaterialInstanceDynamic
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricSphereLightSuperFar_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricSphereLightSuperFar_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17003650 RID: 13904
		// (get) Token: 0x06021669 RID: 136809 RVA: 0x008EB9A8 File Offset: 0x008E9BA8
		// (set) Token: 0x0602166A RID: 136810 RVA: 0x008EB9BC File Offset: 0x008E9BBC
		public unsafe UMaterialInstance SphereLightMat
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricSphereLightSuperFar_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricSphereLightSuperFar_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x17003651 RID: 13905
		// (get) Token: 0x0602166B RID: 136811 RVA: 0x008EB9D1 File Offset: 0x008E9BD1
		// (set) Token: 0x0602166C RID: 136812 RVA: 0x008EB9E1 File Offset: 0x008E9BE1
		public unsafe bool IsReverseCulling
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricSphereLightSuperFar_C.__PropertyOffset_7) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricSphereLightSuperFar_C.__PropertyOffset_7) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003652 RID: 13906
		// (get) Token: 0x0602166D RID: 136813 RVA: 0x008EB9F2 File Offset: 0x008E9BF2
		// (set) Token: 0x0602166E RID: 136814 RVA: 0x008EBA02 File Offset: 0x008E9C02
		public unsafe bool IsWholeDay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricSphereLightSuperFar_C.__PropertyOffset_8) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricSphereLightSuperFar_C.__PropertyOffset_8) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003653 RID: 13907
		// (get) Token: 0x0602166F RID: 136815 RVA: 0x008EBA13 File Offset: 0x008E9C13
		// (set) Token: 0x06021670 RID: 136816 RVA: 0x008EBA23 File Offset: 0x008E9C23
		public unsafe bool OutDistanceFade
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricSphereLightSuperFar_C.__PropertyOffset_9) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricSphereLightSuperFar_C.__PropertyOffset_9) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003654 RID: 13908
		// (get) Token: 0x06021671 RID: 136817 RVA: 0x008EBA34 File Offset: 0x008E9C34
		// (set) Token: 0x06021672 RID: 136818 RVA: 0x008EBA44 File Offset: 0x008E9C44
		public unsafe bool ApplyFog
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricSphereLightSuperFar_C.__PropertyOffset_10) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricSphereLightSuperFar_C.__PropertyOffset_10) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003655 RID: 13909
		// (get) Token: 0x06021673 RID: 136819 RVA: 0x008EBA55 File Offset: 0x008E9C55
		// (set) Token: 0x06021674 RID: 136820 RVA: 0x008EBA65 File Offset: 0x008E9C65
		public unsafe bool IsTickIntenisty
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricSphereLightSuperFar_C.__PropertyOffset_11) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricSphereLightSuperFar_C.__PropertyOffset_11) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003656 RID: 13910
		// (get) Token: 0x06021675 RID: 136821 RVA: 0x008EBA76 File Offset: 0x008E9C76
		// (set) Token: 0x06021676 RID: 136822 RVA: 0x008EBA86 File Offset: 0x008E9C86
		public unsafe bool ShoulderRenderInLowQuality
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricSphereLightSuperFar_C.__PropertyOffset_12) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricSphereLightSuperFar_C.__PropertyOffset_12) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003657 RID: 13911
		// (get) Token: 0x06021677 RID: 136823 RVA: 0x008EBA97 File Offset: 0x008E9C97
		// (set) Token: 0x06021678 RID: 136824 RVA: 0x008EBAA7 File Offset: 0x008E9CA7
		public unsafe float NearDestroyDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricSphereLightSuperFar_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricSphereLightSuperFar_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17003658 RID: 13912
		// (get) Token: 0x06021679 RID: 136825 RVA: 0x008EBAB8 File Offset: 0x008E9CB8
		// (set) Token: 0x0602167A RID: 136826 RVA: 0x008EBAC8 File Offset: 0x008E9CC8
		public unsafe float FogInt
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricSphereLightSuperFar_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricSphereLightSuperFar_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17003659 RID: 13913
		// (get) Token: 0x0602167B RID: 136827 RVA: 0x008EBAD9 File Offset: 0x008E9CD9
		// (set) Token: 0x0602167C RID: 136828 RVA: 0x008EBAE9 File Offset: 0x008E9CE9
		public unsafe float FogPower
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricSphereLightSuperFar_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricSphereLightSuperFar_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x1700365A RID: 13914
		// (get) Token: 0x0602167D RID: 136829 RVA: 0x008EBAFA File Offset: 0x008E9CFA
		// (set) Token: 0x0602167E RID: 136830 RVA: 0x008EBB0A File Offset: 0x008E9D0A
		public unsafe float SkyLightInt
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricSphereLightSuperFar_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricSphereLightSuperFar_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x1700365B RID: 13915
		// (get) Token: 0x0602167F RID: 136831 RVA: 0x008EBB1B File Offset: 0x008E9D1B
		// (set) Token: 0x06021680 RID: 136832 RVA: 0x008EBB2B File Offset: 0x008E9D2B
		public unsafe float SkyLightOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricSphereLightSuperFar_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricSphereLightSuperFar_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x1700365C RID: 13916
		// (get) Token: 0x06021681 RID: 136833 RVA: 0x008EBB3C File Offset: 0x008E9D3C
		// (set) Token: 0x06021682 RID: 136834 RVA: 0x008EBB50 File Offset: 0x008E9D50
		public unsafe FLinearColor InsideColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricSphereLightSuperFar_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricSphereLightSuperFar_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x1700365D RID: 13917
		// (get) Token: 0x06021683 RID: 136835 RVA: 0x008EBB65 File Offset: 0x008E9D65
		// (set) Token: 0x06021684 RID: 136836 RVA: 0x008EBB79 File Offset: 0x008E9D79
		public unsafe FLinearColor OutSideColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricSphereLightSuperFar_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricSphereLightSuperFar_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x1700365E RID: 13918
		// (get) Token: 0x06021685 RID: 136837 RVA: 0x008EBB8E File Offset: 0x008E9D8E
		// (set) Token: 0x06021686 RID: 136838 RVA: 0x008EBB9E File Offset: 0x008E9D9E
		public unsafe float SphereRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricSphereLightSuperFar_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricSphereLightSuperFar_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x1700365F RID: 13919
		// (get) Token: 0x06021687 RID: 136839 RVA: 0x008EBBAF File Offset: 0x008E9DAF
		// (set) Token: 0x06021688 RID: 136840 RVA: 0x008EBBBF File Offset: 0x008E9DBF
		public unsafe float LightStart
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricSphereLightSuperFar_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricSphereLightSuperFar_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x17003660 RID: 13920
		// (get) Token: 0x06021689 RID: 136841 RVA: 0x008EBBD0 File Offset: 0x008E9DD0
		// (set) Token: 0x0602168A RID: 136842 RVA: 0x008EBBE0 File Offset: 0x008E9DE0
		public unsafe float NearFadeStart
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricSphereLightSuperFar_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricSphereLightSuperFar_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x17003661 RID: 13921
		// (get) Token: 0x0602168B RID: 136843 RVA: 0x008EBBF1 File Offset: 0x008E9DF1
		// (set) Token: 0x0602168C RID: 136844 RVA: 0x008EBC01 File Offset: 0x008E9E01
		public unsafe float FullIntLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricSphereLightSuperFar_C.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricSphereLightSuperFar_C.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x17003662 RID: 13922
		// (get) Token: 0x0602168D RID: 136845 RVA: 0x008EBC12 File Offset: 0x008E9E12
		// (set) Token: 0x0602168E RID: 136846 RVA: 0x008EBC22 File Offset: 0x008E9E22
		public unsafe float FarFadeLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricSphereLightSuperFar_C.__PropertyOffset_24);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricSphereLightSuperFar_C.__PropertyOffset_24) = value;
			}
		}

		// Token: 0x17003663 RID: 13923
		// (get) Token: 0x0602168F RID: 136847 RVA: 0x008EBC33 File Offset: 0x008E9E33
		// (set) Token: 0x06021690 RID: 136848 RVA: 0x008EBC47 File Offset: 0x008E9E47
		public unsafe UMaterialInstance SphereLightMatWithOutDF
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricSphereLightSuperFar_C.__PropertyOffset_25);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricSphereLightSuperFar_C.__PropertyOffset_25, value);
			}
		}

		// Token: 0x17003664 RID: 13924
		// (get) Token: 0x06021691 RID: 136849 RVA: 0x008EBC5C File Offset: 0x008E9E5C
		// (set) Token: 0x06021692 RID: 136850 RVA: 0x008EBC70 File Offset: 0x008E9E70
		public unsafe UMaterialInstance SphereLightMatWithOutFog
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricSphereLightSuperFar_C.__PropertyOffset_26);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricSphereLightSuperFar_C.__PropertyOffset_26, value);
			}
		}

		// Token: 0x17003665 RID: 13925
		// (get) Token: 0x06021693 RID: 136851 RVA: 0x008EBC85 File Offset: 0x008E9E85
		// (set) Token: 0x06021694 RID: 136852 RVA: 0x008EBC99 File Offset: 0x008E9E99
		public unsafe UMaterialInstance SphereLightMatWithOutDFWithOutFog
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricSphereLightSuperFar_C.__PropertyOffset_27);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricSphereLightSuperFar_C.__PropertyOffset_27, value);
			}
		}

		// Token: 0x17003666 RID: 13926
		// (get) Token: 0x06021695 RID: 136853 RVA: 0x008EBCAE File Offset: 0x008E9EAE
		// (set) Token: 0x06021696 RID: 136854 RVA: 0x008EBCC2 File Offset: 0x008E9EC2
		public unsafe UMaterialInstance SphereLightMat_LR
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricSphereLightSuperFar_C.__PropertyOffset_28);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricSphereLightSuperFar_C.__PropertyOffset_28, value);
			}
		}

		// Token: 0x17003667 RID: 13927
		// (get) Token: 0x06021697 RID: 136855 RVA: 0x008EBCD7 File Offset: 0x008E9ED7
		// (set) Token: 0x06021698 RID: 136856 RVA: 0x008EBCEB File Offset: 0x008E9EEB
		public unsafe UMaterialInstance SphereLightMatWithOutDF_LR
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricSphereLightSuperFar_C.__PropertyOffset_29);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricSphereLightSuperFar_C.__PropertyOffset_29, value);
			}
		}

		// Token: 0x17003668 RID: 13928
		// (get) Token: 0x06021699 RID: 136857 RVA: 0x008EBD00 File Offset: 0x008E9F00
		// (set) Token: 0x0602169A RID: 136858 RVA: 0x008EBD14 File Offset: 0x008E9F14
		public unsafe UMaterialInstance SphereLightMatWithOutFog_LR
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricSphereLightSuperFar_C.__PropertyOffset_30);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricSphereLightSuperFar_C.__PropertyOffset_30, value);
			}
		}

		// Token: 0x17003669 RID: 13929
		// (get) Token: 0x0602169B RID: 136859 RVA: 0x008EBD29 File Offset: 0x008E9F29
		// (set) Token: 0x0602169C RID: 136860 RVA: 0x008EBD3D File Offset: 0x008E9F3D
		public unsafe UMaterialInstance SphereLightMatWithOutDFWithOutFog_LR
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricSphereLightSuperFar_C.__PropertyOffset_31);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricSphereLightSuperFar_C.__PropertyOffset_31, value);
			}
		}

		// Token: 0x1700366A RID: 13930
		// (get) Token: 0x0602169D RID: 136861 RVA: 0x008EBD52 File Offset: 0x008E9F52
		// (set) Token: 0x0602169E RID: 136862 RVA: 0x008EBD62 File Offset: 0x008E9F62
		public unsafe int FrameCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricSphereLightSuperFar_C.__PropertyOffset_32);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricSphereLightSuperFar_C.__PropertyOffset_32) = value;
			}
		}

		// Token: 0x1700366B RID: 13931
		// (get) Token: 0x0602169F RID: 136863 RVA: 0x008EBD73 File Offset: 0x008E9F73
		// (set) Token: 0x060216A0 RID: 136864 RVA: 0x008EBD87 File Offset: 0x008E9F87
		[Nullable(0)]
		public unsafe TEnumAsByte<ELightQualityType> Quality
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricSphereLightSuperFar_C.__PropertyOffset_33);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricSphereLightSuperFar_C.__PropertyOffset_33) = value;
			}
		}

		// Token: 0x1700366C RID: 13932
		// (get) Token: 0x060216A1 RID: 136865 RVA: 0x008EBD9C File Offset: 0x008E9F9C
		// (set) Token: 0x060216A2 RID: 136866 RVA: 0x008EBDAC File Offset: 0x008E9FAC
		public unsafe int CurrentQuality
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricSphereLightSuperFar_C.__PropertyOffset_34);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricSphereLightSuperFar_C.__PropertyOffset_34) = value;
			}
		}

		// Token: 0x060216A3 RID: 136867 RVA: 0x008EBDC0 File Offset: 0x008E9FC0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual int GetPlacementSortOrder()
		{
			BP_VolumetricSphereLightSuperFar_C.__GetPlacementSortOrder_FunctionParams* ptr = stackalloc BP_VolumetricSphereLightSuperFar_C.__GetPlacementSortOrder_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_VolumetricSphereLightSuperFar_C.__GetPlacementSortOrder_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_VolumetricSphereLightSuperFar_C.__GetPlacementSortOrder_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VolumetricSphereLightSuperFar_C.__GetPlacementSortOrder_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x060216A4 RID: 136868 RVA: 0x008EBE08 File Offset: 0x008EA008
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual int GetPlacementSortOrder_Implementation()
		{
			BP_VolumetricSphereLightSuperFar_C.__GetPlacementSortOrder_FunctionParams* ptr = stackalloc BP_VolumetricSphereLightSuperFar_C.__GetPlacementSortOrder_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_VolumetricSphereLightSuperFar_C.__GetPlacementSortOrder_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_VolumetricSphereLightSuperFar_C.__GetPlacementSortOrder_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_VolumetricSphereLightSuperFar_C.__GetPlacementSortOrder_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x060216A5 RID: 136869 RVA: 0x008EBE4E File Offset: 0x008EA04E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SetQuality()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VolumetricSphereLightSuperFar_C.__SetQuality_NativeFunctionPtr, null);
		}

		// Token: 0x060216A6 RID: 136870 RVA: 0x008EBE62 File Offset: 0x008EA062
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateFogInt()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VolumetricSphereLightSuperFar_C.__UpdateFogInt_NativeFunctionPtr, null);
		}

		// Token: 0x060216A7 RID: 136871 RVA: 0x008EBE76 File Offset: 0x008EA076
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateVolumetricSphereLight()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VolumetricSphereLightSuperFar_C.__UpdateVolumetricSphereLight_NativeFunctionPtr, null);
		}

		// Token: 0x060216A8 RID: 136872 RVA: 0x008EBE8A File Offset: 0x008EA08A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VolumetricSphereLightSuperFar_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x060216A9 RID: 136873 RVA: 0x008EBE9E File Offset: 0x008EA09E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_VolumetricSphereLightSuperFar_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060216AA RID: 136874 RVA: 0x008EBEB3 File Offset: 0x008EA0B3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VolumetricSphereLightSuperFar_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x060216AB RID: 136875 RVA: 0x008EBEC7 File Offset: 0x008EA0C7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_VolumetricSphereLightSuperFar_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060216AC RID: 136876 RVA: 0x008EBEDC File Offset: 0x008EA0DC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_VolumetricSphereLightSuperFar_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_VolumetricSphereLightSuperFar_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_VolumetricSphereLightSuperFar_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_VolumetricSphereLightSuperFar_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VolumetricSphereLightSuperFar_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060216AD RID: 136877 RVA: 0x008EBF24 File Offset: 0x008EA124
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_VolumetricSphereLightSuperFar_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_VolumetricSphereLightSuperFar_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_VolumetricSphereLightSuperFar_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_VolumetricSphereLightSuperFar_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_VolumetricSphereLightSuperFar_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060216AE RID: 136878 RVA: 0x008EBF6C File Offset: 0x008EA16C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_VolumetricSphereLightSuperFar_C.__EditorTick_FunctionParams* ptr = stackalloc BP_VolumetricSphereLightSuperFar_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_VolumetricSphereLightSuperFar_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_VolumetricSphereLightSuperFar_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VolumetricSphereLightSuperFar_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060216AF RID: 136879 RVA: 0x008EBFB4 File Offset: 0x008EA1B4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_VolumetricSphereLightSuperFar_C.__EditorTick_FunctionParams* ptr = stackalloc BP_VolumetricSphereLightSuperFar_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_VolumetricSphereLightSuperFar_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_VolumetricSphereLightSuperFar_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_VolumetricSphereLightSuperFar_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060216B0 RID: 136880 RVA: 0x008EBFFB File Offset: 0x008EA1FB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateQualitySwitch()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VolumetricSphereLightSuperFar_C.__UpdateQualitySwitch_NativeFunctionPtr, null);
		}

		// Token: 0x060216B1 RID: 136881 RVA: 0x008EC00F File Offset: 0x008EA20F
		protected BP_VolumetricSphereLightSuperFar_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010445 RID: 66629
		internal static int __InterfaceOffset_IInterface_KuroLightBP;

		// Token: 0x04010446 RID: 66630
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_VolumetricSphereLightSuperFar.BP_VolumetricSphereLightSuperFar_C";

		// Token: 0x04010447 RID: 66631
		private static IntPtr _ClassPtr;

		// Token: 0x04010448 RID: 66632
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010449 RID: 66633
		internal static int __PropertyOffset_1;

		// Token: 0x0401044A RID: 66634
		internal static int __PropertyOffset_2;

		// Token: 0x0401044B RID: 66635
		internal static int __PropertyOffset_3;

		// Token: 0x0401044C RID: 66636
		internal static int __PropertyOffset_4;

		// Token: 0x0401044D RID: 66637
		internal static int __PropertyOffset_5;

		// Token: 0x0401044E RID: 66638
		internal static int __PropertyOffset_6;

		// Token: 0x0401044F RID: 66639
		internal static int __PropertyOffset_7;

		// Token: 0x04010450 RID: 66640
		internal static int __PropertyOffset_8;

		// Token: 0x04010451 RID: 66641
		internal static int __PropertyOffset_9;

		// Token: 0x04010452 RID: 66642
		internal static int __PropertyOffset_10;

		// Token: 0x04010453 RID: 66643
		internal static int __PropertyOffset_11;

		// Token: 0x04010454 RID: 66644
		internal static int __PropertyOffset_12;

		// Token: 0x04010455 RID: 66645
		internal static int __PropertyOffset_13;

		// Token: 0x04010456 RID: 66646
		internal static int __PropertyOffset_14;

		// Token: 0x04010457 RID: 66647
		internal static int __PropertyOffset_15;

		// Token: 0x04010458 RID: 66648
		internal static int __PropertyOffset_16;

		// Token: 0x04010459 RID: 66649
		internal static int __PropertyOffset_17;

		// Token: 0x0401045A RID: 66650
		internal static int __PropertyOffset_18;

		// Token: 0x0401045B RID: 66651
		internal static int __PropertyOffset_19;

		// Token: 0x0401045C RID: 66652
		internal static int __PropertyOffset_20;

		// Token: 0x0401045D RID: 66653
		internal static int __PropertyOffset_21;

		// Token: 0x0401045E RID: 66654
		internal static int __PropertyOffset_22;

		// Token: 0x0401045F RID: 66655
		internal static int __PropertyOffset_23;

		// Token: 0x04010460 RID: 66656
		internal static int __PropertyOffset_24;

		// Token: 0x04010461 RID: 66657
		internal static int __PropertyOffset_25;

		// Token: 0x04010462 RID: 66658
		internal static int __PropertyOffset_26;

		// Token: 0x04010463 RID: 66659
		internal static int __PropertyOffset_27;

		// Token: 0x04010464 RID: 66660
		internal static int __PropertyOffset_28;

		// Token: 0x04010465 RID: 66661
		internal static int __PropertyOffset_29;

		// Token: 0x04010466 RID: 66662
		internal static int __PropertyOffset_30;

		// Token: 0x04010467 RID: 66663
		internal static int __PropertyOffset_31;

		// Token: 0x04010468 RID: 66664
		internal static int __PropertyOffset_32;

		// Token: 0x04010469 RID: 66665
		internal static int __PropertyOffset_33;

		// Token: 0x0401046A RID: 66666
		internal static int __PropertyOffset_34;

		// Token: 0x0401046B RID: 66667
		private static IntPtr __GetPlacementSortOrder_NativeFunctionPtr;

		// Token: 0x0401046C RID: 66668
		private static IntPtr __SetQuality_NativeFunctionPtr;

		// Token: 0x0401046D RID: 66669
		private static IntPtr __UpdateFogInt_NativeFunctionPtr;

		// Token: 0x0401046E RID: 66670
		private static IntPtr __UpdateVolumetricSphereLight_NativeFunctionPtr;

		// Token: 0x0401046F RID: 66671
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04010470 RID: 66672
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04010471 RID: 66673
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04010472 RID: 66674
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x04010473 RID: 66675
		private static IntPtr __UpdateQualitySwitch_NativeFunctionPtr;

		// Token: 0x02009C8C RID: 40076
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetPlacementSortOrder_FunctionParams
		{
			// Token: 0x0403134A RID: 201546
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x02009C8D RID: 40077
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0403134B RID: 201547
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009C8E RID: 40078
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x0403134C RID: 201548
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}

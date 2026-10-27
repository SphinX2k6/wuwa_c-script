using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Light
{
	// Token: 0x02003B1C RID: 15132
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Light/BP_ShadowPlane.BP_ShadowPlane_C")]
	[UnrealStructLayout(1888, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1888)]
	public class BP_ShadowPlane_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021208 RID: 135688 RVA: 0x008E5798 File Offset: 0x008E3998
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_ShadowPlane_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_ShadowPlane.BP_ShadowPlane_C");
			}
			return BP_ShadowPlane_C._ClassPtr;
		}

		// Token: 0x06021209 RID: 135689 RVA: 0x008E57BC File Offset: 0x008E39BC
		public BP_ShadowPlane_C() : this(BuiltinUtils.AllocNativeUObject(BP_ShadowPlane_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602120A RID: 135690 RVA: 0x008E57E4 File Offset: 0x008E39E4
		[NullableContext(1)]
		public BP_ShadowPlane_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_ShadowPlane_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003481 RID: 13441
		// (get) Token: 0x0602120B RID: 135691 RVA: 0x008E5817 File Offset: 0x008E3A17
		// (set) Token: 0x0602120C RID: 135692 RVA: 0x008E582B File Offset: 0x008E3A2B
		public unsafe UKuroGameBudgetComponent KuroGameBudget
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroGameBudgetComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ShadowPlane_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ShadowPlane_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17003482 RID: 13442
		// (get) Token: 0x0602120D RID: 135693 RVA: 0x008E5840 File Offset: 0x008E3A40
		// (set) Token: 0x0602120E RID: 135694 RVA: 0x008E5854 File Offset: 0x008E3A54
		public unsafe UStaticMeshComponent Plane
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ShadowPlane_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ShadowPlane_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17003483 RID: 13443
		// (get) Token: 0x0602120F RID: 135695 RVA: 0x008E5869 File Offset: 0x008E3A69
		// (set) Token: 0x06021210 RID: 135696 RVA: 0x008E587D File Offset: 0x008E3A7D
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ShadowPlane_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ShadowPlane_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17003484 RID: 13444
		// (get) Token: 0x06021211 RID: 135697 RVA: 0x008E5892 File Offset: 0x008E3A92
		// (set) Token: 0x06021212 RID: 135698 RVA: 0x008E58A6 File Offset: 0x008E3AA6
		public unsafe UMaterialInstanceDynamic DynamicMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ShadowPlane_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ShadowPlane_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17003485 RID: 13445
		// (get) Token: 0x06021213 RID: 135699 RVA: 0x008E58BC File Offset: 0x008E3ABC
		// (set) Token: 0x06021214 RID: 135700 RVA: 0x008E58F5 File Offset: 0x008E3AF5
		[Nullable(1)]
		public TMap<FName, float> Scalar_Parameters
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FName, float> result;
				if ((result = this._Scalar_Parameters) == null)
				{
					result = (this._Scalar_Parameters = new TMap<FName, float>(base.NativePtr + (IntPtr)BP_ShadowPlane_C.__PropertyOffset_5, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Scalar_Parameters.CopyAssign(value);
			}
		}

		// Token: 0x17003486 RID: 13446
		// (get) Token: 0x06021215 RID: 135701 RVA: 0x008E5904 File Offset: 0x008E3B04
		// (set) Token: 0x06021216 RID: 135702 RVA: 0x008E593D File Offset: 0x008E3B3D
		[Nullable(1)]
		public TMap<FName, FLinearColor> Vector_Parameters
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FLinearColor> result;
				if ((result = this._Vector_Parameters) == null)
				{
					result = (this._Vector_Parameters = new TMap<FName, FLinearColor>(base.NativePtr + (IntPtr)BP_ShadowPlane_C.__PropertyOffset_6, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Vector_Parameters.CopyAssign(value);
			}
		}

		// Token: 0x17003487 RID: 13447
		// (get) Token: 0x06021217 RID: 135703 RVA: 0x008E594C File Offset: 0x008E3B4C
		// (set) Token: 0x06021218 RID: 135704 RVA: 0x008E5985 File Offset: 0x008E3B85
		[Nullable(1)]
		public TMap<FName, UTexture> Texture_Parameters
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FName, UTexture> result;
				if ((result = this._Texture_Parameters) == null)
				{
					result = (this._Texture_Parameters = new TMap<FName, UTexture>(base.NativePtr + (IntPtr)BP_ShadowPlane_C.__PropertyOffset_7, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Texture_Parameters.CopyAssign(value);
			}
		}

		// Token: 0x17003488 RID: 13448
		// (get) Token: 0x06021219 RID: 135705 RVA: 0x008E5993 File Offset: 0x008E3B93
		// (set) Token: 0x0602121A RID: 135706 RVA: 0x008E59A7 File Offset: 0x008E3BA7
		public unsafe UMaterialInstance Material
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ShadowPlane_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ShadowPlane_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x17003489 RID: 13449
		// (get) Token: 0x0602121B RID: 135707 RVA: 0x008E59BC File Offset: 0x008E3BBC
		// (set) Token: 0x0602121C RID: 135708 RVA: 0x008E59CC File Offset: 0x008E3BCC
		public unsafe float BlurIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ShadowPlane_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ShadowPlane_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x1700348A RID: 13450
		// (get) Token: 0x0602121D RID: 135709 RVA: 0x008E59DD File Offset: 0x008E3BDD
		// (set) Token: 0x0602121E RID: 135710 RVA: 0x008E59ED File Offset: 0x008E3BED
		public unsafe float TranslucentIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ShadowPlane_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ShadowPlane_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x1700348B RID: 13451
		// (get) Token: 0x0602121F RID: 135711 RVA: 0x008E59FE File Offset: 0x008E3BFE
		// (set) Token: 0x06021220 RID: 135712 RVA: 0x008E5A12 File Offset: 0x008E3C12
		public unsafe UTexture2D Texture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ShadowPlane_C.__PropertyOffset_11);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ShadowPlane_C.__PropertyOffset_11, value);
			}
		}

		// Token: 0x1700348C RID: 13452
		// (get) Token: 0x06021221 RID: 135713 RVA: 0x008E5A27 File Offset: 0x008E3C27
		// (set) Token: 0x06021222 RID: 135714 RVA: 0x008E5A3B File Offset: 0x008E3C3B
		public unsafe UMaterialInstance Material_Normal
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ShadowPlane_C.__PropertyOffset_12);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ShadowPlane_C.__PropertyOffset_12, value);
			}
		}

		// Token: 0x1700348D RID: 13453
		// (get) Token: 0x06021223 RID: 135715 RVA: 0x008E5A50 File Offset: 0x008E3C50
		// (set) Token: 0x06021224 RID: 135716 RVA: 0x008E5A64 File Offset: 0x008E3C64
		public unsafe FLinearColor Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ShadowPlane_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ShadowPlane_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x1700348E RID: 13454
		// (get) Token: 0x06021225 RID: 135717 RVA: 0x008E5A79 File Offset: 0x008E3C79
		// (set) Token: 0x06021226 RID: 135718 RVA: 0x008E5A89 File Offset: 0x008E3C89
		public unsafe float Inver
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ShadowPlane_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ShadowPlane_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x1700348F RID: 13455
		// (get) Token: 0x06021227 RID: 135719 RVA: 0x008E5A9A File Offset: 0x008E3C9A
		// (set) Token: 0x06021228 RID: 135720 RVA: 0x008E5AAA File Offset: 0x008E3CAA
		public unsafe float Hard
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ShadowPlane_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ShadowPlane_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17003490 RID: 13456
		// (get) Token: 0x06021229 RID: 135721 RVA: 0x008E5ABB File Offset: 0x008E3CBB
		// (set) Token: 0x0602122A RID: 135722 RVA: 0x008E5ACB File Offset: 0x008E3CCB
		public unsafe float WindIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ShadowPlane_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ShadowPlane_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x17003491 RID: 13457
		// (get) Token: 0x0602122B RID: 135723 RVA: 0x008E5ADC File Offset: 0x008E3CDC
		// (set) Token: 0x0602122C RID: 135724 RVA: 0x008E5AEC File Offset: 0x008E3CEC
		public unsafe float WindSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ShadowPlane_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ShadowPlane_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x17003492 RID: 13458
		// (get) Token: 0x0602122D RID: 135725 RVA: 0x008E5AFD File Offset: 0x008E3CFD
		// (set) Token: 0x0602122E RID: 135726 RVA: 0x008E5B0D File Offset: 0x008E3D0D
		public unsafe float WindDir_X
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ShadowPlane_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ShadowPlane_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x17003493 RID: 13459
		// (get) Token: 0x0602122F RID: 135727 RVA: 0x008E5B1E File Offset: 0x008E3D1E
		// (set) Token: 0x06021230 RID: 135728 RVA: 0x008E5B2E File Offset: 0x008E3D2E
		public unsafe float WindDir_Y
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ShadowPlane_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ShadowPlane_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x17003494 RID: 13460
		// (get) Token: 0x06021231 RID: 135729 RVA: 0x008E5B3F File Offset: 0x008E3D3F
		// (set) Token: 0x06021232 RID: 135730 RVA: 0x008E5B4F File Offset: 0x008E3D4F
		public unsafe float StrenghtAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ShadowPlane_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ShadowPlane_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x17003495 RID: 13461
		// (get) Token: 0x06021233 RID: 135731 RVA: 0x008E5B60 File Offset: 0x008E3D60
		// (set) Token: 0x06021234 RID: 135732 RVA: 0x008E5B70 File Offset: 0x008E3D70
		public unsafe float WindRandomSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ShadowPlane_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ShadowPlane_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x17003496 RID: 13462
		// (get) Token: 0x06021235 RID: 135733 RVA: 0x008E5B81 File Offset: 0x008E3D81
		// (set) Token: 0x06021236 RID: 135734 RVA: 0x008E5B91 File Offset: 0x008E3D91
		public unsafe float WindRandomIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ShadowPlane_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ShadowPlane_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x17003497 RID: 13463
		// (get) Token: 0x06021237 RID: 135735 RVA: 0x008E5BA2 File Offset: 0x008E3DA2
		// (set) Token: 0x06021238 RID: 135736 RVA: 0x008E5BB2 File Offset: 0x008E3DB2
		public unsafe float UVPosition_X
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ShadowPlane_C.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ShadowPlane_C.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x17003498 RID: 13464
		// (get) Token: 0x06021239 RID: 135737 RVA: 0x008E5BC3 File Offset: 0x008E3DC3
		// (set) Token: 0x0602123A RID: 135738 RVA: 0x008E5BD3 File Offset: 0x008E3DD3
		public unsafe float UVPosition_Y
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ShadowPlane_C.__PropertyOffset_24);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ShadowPlane_C.__PropertyOffset_24) = value;
			}
		}

		// Token: 0x17003499 RID: 13465
		// (get) Token: 0x0602123B RID: 135739 RVA: 0x008E5BE4 File Offset: 0x008E3DE4
		// (set) Token: 0x0602123C RID: 135740 RVA: 0x008E5BF4 File Offset: 0x008E3DF4
		public unsafe float UVScale_X
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ShadowPlane_C.__PropertyOffset_25);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ShadowPlane_C.__PropertyOffset_25) = value;
			}
		}

		// Token: 0x1700349A RID: 13466
		// (get) Token: 0x0602123D RID: 135741 RVA: 0x008E5C05 File Offset: 0x008E3E05
		// (set) Token: 0x0602123E RID: 135742 RVA: 0x008E5C15 File Offset: 0x008E3E15
		public unsafe float UVScale_Y
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ShadowPlane_C.__PropertyOffset_26);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ShadowPlane_C.__PropertyOffset_26) = value;
			}
		}

		// Token: 0x1700349B RID: 13467
		// (get) Token: 0x0602123F RID: 135743 RVA: 0x008E5C26 File Offset: 0x008E3E26
		// (set) Token: 0x06021240 RID: 135744 RVA: 0x008E5C36 File Offset: 0x008E3E36
		public unsafe bool ReflectionMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ShadowPlane_C.__PropertyOffset_27) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ShadowPlane_C.__PropertyOffset_27) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700349C RID: 13468
		// (get) Token: 0x06021241 RID: 135745 RVA: 0x008E5C47 File Offset: 0x008E3E47
		// (set) Token: 0x06021242 RID: 135746 RVA: 0x008E5C57 File Offset: 0x008E3E57
		public unsafe float ReflectionIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ShadowPlane_C.__PropertyOffset_28);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ShadowPlane_C.__PropertyOffset_28) = value;
			}
		}

		// Token: 0x1700349D RID: 13469
		// (get) Token: 0x06021243 RID: 135747 RVA: 0x008E5C68 File Offset: 0x008E3E68
		// (set) Token: 0x06021244 RID: 135748 RVA: 0x008E5C78 File Offset: 0x008E3E78
		public unsafe float ReflectionFlowIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ShadowPlane_C.__PropertyOffset_29);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ShadowPlane_C.__PropertyOffset_29) = value;
			}
		}

		// Token: 0x1700349E RID: 13470
		// (get) Token: 0x06021245 RID: 135749 RVA: 0x008E5C89 File Offset: 0x008E3E89
		// (set) Token: 0x06021246 RID: 135750 RVA: 0x008E5C99 File Offset: 0x008E3E99
		public unsafe float Radius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ShadowPlane_C.__PropertyOffset_30);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ShadowPlane_C.__PropertyOffset_30) = value;
			}
		}

		// Token: 0x1700349F RID: 13471
		// (get) Token: 0x06021247 RID: 135751 RVA: 0x008E5CAA File Offset: 0x008E3EAA
		// (set) Token: 0x06021248 RID: 135752 RVA: 0x008E5CBA File Offset: 0x008E3EBA
		public unsafe float ReflectionFlowSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ShadowPlane_C.__PropertyOffset_31);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ShadowPlane_C.__PropertyOffset_31) = value;
			}
		}

		// Token: 0x170034A0 RID: 13472
		// (get) Token: 0x06021249 RID: 135753 RVA: 0x008E5CCB File Offset: 0x008E3ECB
		// (set) Token: 0x0602124A RID: 135754 RVA: 0x008E5CDF File Offset: 0x008E3EDF
		public unsafe FLinearColor ReflectionColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ShadowPlane_C.__PropertyOffset_32);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ShadowPlane_C.__PropertyOffset_32) = value;
			}
		}

		// Token: 0x170034A1 RID: 13473
		// (get) Token: 0x0602124B RID: 135755 RVA: 0x008E5CF4 File Offset: 0x008E3EF4
		// (set) Token: 0x0602124C RID: 135756 RVA: 0x008E5D04 File Offset: 0x008E3F04
		public unsafe float ReflectionFlowTile
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ShadowPlane_C.__PropertyOffset_33);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ShadowPlane_C.__PropertyOffset_33) = value;
			}
		}

		// Token: 0x170034A2 RID: 13474
		// (get) Token: 0x0602124D RID: 135757 RVA: 0x008E5D15 File Offset: 0x008E3F15
		// (set) Token: 0x0602124E RID: 135758 RVA: 0x008E5D25 File Offset: 0x008E3F25
		public unsafe bool EnableReplaceMaterial
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ShadowPlane_C.__PropertyOffset_34) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ShadowPlane_C.__PropertyOffset_34) = (value ? 1 : 0);
			}
		}

		// Token: 0x170034A3 RID: 13475
		// (get) Token: 0x0602124F RID: 135759 RVA: 0x008E5D36 File Offset: 0x008E3F36
		// (set) Token: 0x06021250 RID: 135760 RVA: 0x008E5D4A File Offset: 0x008E3F4A
		public unsafe UMaterialInstance ReplaceMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ShadowPlane_C.__PropertyOffset_35);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ShadowPlane_C.__PropertyOffset_35, value);
			}
		}

		// Token: 0x170034A4 RID: 13476
		// (get) Token: 0x06021251 RID: 135761 RVA: 0x008E5D5F File Offset: 0x008E3F5F
		// (set) Token: 0x06021252 RID: 135762 RVA: 0x008E5D73 File Offset: 0x008E3F73
		public unsafe UMaterialInstance TranslucentPlane
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ShadowPlane_C.__PropertyOffset_36);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ShadowPlane_C.__PropertyOffset_36, value);
			}
		}

		// Token: 0x06021253 RID: 135763 RVA: 0x008E5D88 File Offset: 0x008E3F88
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SetParameter()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ShadowPlane_C.__SetParameter_NativeFunctionPtr, null);
		}

		// Token: 0x06021254 RID: 135764 RVA: 0x008E5D9C File Offset: 0x008E3F9C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ShadowPlane_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06021255 RID: 135765 RVA: 0x008E5DB0 File Offset: 0x008E3FB0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_ShadowPlane_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06021256 RID: 135766 RVA: 0x008E5DC5 File Offset: 0x008E3FC5
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ShadowPlane_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06021257 RID: 135767 RVA: 0x008E5DD9 File Offset: 0x008E3FD9
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_ShadowPlane_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06021258 RID: 135768 RVA: 0x008E5DF0 File Offset: 0x008E3FF0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_ShadowPlane_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_ShadowPlane_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_ShadowPlane_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ShadowPlane_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ShadowPlane_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021259 RID: 135769 RVA: 0x008E5E38 File Offset: 0x008E4038
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_ShadowPlane_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_ShadowPlane_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_ShadowPlane_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ShadowPlane_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_ShadowPlane_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602125A RID: 135770 RVA: 0x008E5E7F File Offset: 0x008E407F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveDestroyed()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ShadowPlane_C.__ReceiveDestroyed_NativeFunctionPtr, null);
		}

		// Token: 0x0602125B RID: 135771 RVA: 0x008E5E93 File Offset: 0x008E4093
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveDestroyed_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_ShadowPlane_C.__ReceiveDestroyed_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602125C RID: 135772 RVA: 0x008E5EA8 File Offset: 0x008E40A8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_ShadowPlane_C.__EditorTick_FunctionParams* ptr = stackalloc BP_ShadowPlane_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_ShadowPlane_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ShadowPlane_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ShadowPlane_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602125D RID: 135773 RVA: 0x008E5EF0 File Offset: 0x008E40F0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_ShadowPlane_C.__EditorTick_FunctionParams* ptr = stackalloc BP_ShadowPlane_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_ShadowPlane_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ShadowPlane_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_ShadowPlane_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602125E RID: 135774 RVA: 0x008E5F37 File Offset: 0x008E4137
		protected BP_ShadowPlane_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040101EB RID: 66027
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_ShadowPlane.BP_ShadowPlane_C";

		// Token: 0x040101EC RID: 66028
		private static IntPtr _ClassPtr;

		// Token: 0x040101ED RID: 66029
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040101EE RID: 66030
		internal static int __PropertyOffset_1;

		// Token: 0x040101EF RID: 66031
		internal static int __PropertyOffset_2;

		// Token: 0x040101F0 RID: 66032
		internal static int __PropertyOffset_3;

		// Token: 0x040101F1 RID: 66033
		internal static int __PropertyOffset_4;

		// Token: 0x040101F2 RID: 66034
		internal static int __PropertyOffset_5;

		// Token: 0x040101F3 RID: 66035
		private TMap<FName, float> _Scalar_Parameters;

		// Token: 0x040101F4 RID: 66036
		internal static int __PropertyOffset_6;

		// Token: 0x040101F5 RID: 66037
		private TMap<FName, FLinearColor> _Vector_Parameters;

		// Token: 0x040101F6 RID: 66038
		internal static int __PropertyOffset_7;

		// Token: 0x040101F7 RID: 66039
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, UTexture> _Texture_Parameters;

		// Token: 0x040101F8 RID: 66040
		internal static int __PropertyOffset_8;

		// Token: 0x040101F9 RID: 66041
		internal static int __PropertyOffset_9;

		// Token: 0x040101FA RID: 66042
		internal static int __PropertyOffset_10;

		// Token: 0x040101FB RID: 66043
		internal static int __PropertyOffset_11;

		// Token: 0x040101FC RID: 66044
		internal static int __PropertyOffset_12;

		// Token: 0x040101FD RID: 66045
		internal static int __PropertyOffset_13;

		// Token: 0x040101FE RID: 66046
		internal static int __PropertyOffset_14;

		// Token: 0x040101FF RID: 66047
		internal static int __PropertyOffset_15;

		// Token: 0x04010200 RID: 66048
		internal static int __PropertyOffset_16;

		// Token: 0x04010201 RID: 66049
		internal static int __PropertyOffset_17;

		// Token: 0x04010202 RID: 66050
		internal static int __PropertyOffset_18;

		// Token: 0x04010203 RID: 66051
		internal static int __PropertyOffset_19;

		// Token: 0x04010204 RID: 66052
		internal static int __PropertyOffset_20;

		// Token: 0x04010205 RID: 66053
		internal static int __PropertyOffset_21;

		// Token: 0x04010206 RID: 66054
		internal static int __PropertyOffset_22;

		// Token: 0x04010207 RID: 66055
		internal static int __PropertyOffset_23;

		// Token: 0x04010208 RID: 66056
		internal static int __PropertyOffset_24;

		// Token: 0x04010209 RID: 66057
		internal static int __PropertyOffset_25;

		// Token: 0x0401020A RID: 66058
		internal static int __PropertyOffset_26;

		// Token: 0x0401020B RID: 66059
		internal static int __PropertyOffset_27;

		// Token: 0x0401020C RID: 66060
		internal static int __PropertyOffset_28;

		// Token: 0x0401020D RID: 66061
		internal static int __PropertyOffset_29;

		// Token: 0x0401020E RID: 66062
		internal static int __PropertyOffset_30;

		// Token: 0x0401020F RID: 66063
		internal static int __PropertyOffset_31;

		// Token: 0x04010210 RID: 66064
		internal static int __PropertyOffset_32;

		// Token: 0x04010211 RID: 66065
		internal static int __PropertyOffset_33;

		// Token: 0x04010212 RID: 66066
		internal static int __PropertyOffset_34;

		// Token: 0x04010213 RID: 66067
		internal static int __PropertyOffset_35;

		// Token: 0x04010214 RID: 66068
		internal static int __PropertyOffset_36;

		// Token: 0x04010215 RID: 66069
		private static IntPtr __SetParameter_NativeFunctionPtr;

		// Token: 0x04010216 RID: 66070
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04010217 RID: 66071
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04010218 RID: 66072
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04010219 RID: 66073
		private static IntPtr __ReceiveDestroyed_NativeFunctionPtr;

		// Token: 0x0401021A RID: 66074
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x02009C72 RID: 40050
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031330 RID: 201520
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009C73 RID: 40051
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x04031331 RID: 201521
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}

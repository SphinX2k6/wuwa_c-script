using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Light
{
	// Token: 0x02003B08 RID: 15112
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Light/BP_Kaleidoscope_Mesh.BP_Kaleidoscope_Mesh_C")]
	[UnrealStructLayout(2040, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2040)]
	public class BP_Kaleidoscope_Mesh_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020E59 RID: 134745 RVA: 0x008DFC6C File Offset: 0x008DDE6C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_Kaleidoscope_Mesh_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_Kaleidoscope_Mesh.BP_Kaleidoscope_Mesh_C");
			}
			return BP_Kaleidoscope_Mesh_C._ClassPtr;
		}

		// Token: 0x06020E5A RID: 134746 RVA: 0x008DFC90 File Offset: 0x008DDE90
		public BP_Kaleidoscope_Mesh_C() : this(BuiltinUtils.AllocNativeUObject(BP_Kaleidoscope_Mesh_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020E5B RID: 134747 RVA: 0x008DFCB8 File Offset: 0x008DDEB8
		[NullableContext(1)]
		public BP_Kaleidoscope_Mesh_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_Kaleidoscope_Mesh_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003324 RID: 13092
		// (get) Token: 0x06020E5C RID: 134748 RVA: 0x008DFCEB File Offset: 0x008DDEEB
		// (set) Token: 0x06020E5D RID: 134749 RVA: 0x008DFCFF File Offset: 0x008DDEFF
		public unsafe UStaticMeshComponent Sphere
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Kaleidoscope_Mesh_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Kaleidoscope_Mesh_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17003325 RID: 13093
		// (get) Token: 0x06020E5E RID: 134750 RVA: 0x008DFD14 File Offset: 0x008DDF14
		// (set) Token: 0x06020E5F RID: 134751 RVA: 0x008DFD28 File Offset: 0x008DDF28
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Kaleidoscope_Mesh_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Kaleidoscope_Mesh_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17003326 RID: 13094
		// (get) Token: 0x06020E60 RID: 134752 RVA: 0x008DFD3D File Offset: 0x008DDF3D
		// (set) Token: 0x06020E61 RID: 134753 RVA: 0x008DFD51 File Offset: 0x008DDF51
		public unsafe UMaterialInstanceDynamic DynamicMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Kaleidoscope_Mesh_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Kaleidoscope_Mesh_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17003327 RID: 13095
		// (get) Token: 0x06020E62 RID: 134754 RVA: 0x008DFD68 File Offset: 0x008DDF68
		// (set) Token: 0x06020E63 RID: 134755 RVA: 0x008DFDA1 File Offset: 0x008DDFA1
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
					result = (this._Scalar_Parameters = new TMap<FName, float>(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_4, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Scalar_Parameters.CopyAssign(value);
			}
		}

		// Token: 0x17003328 RID: 13096
		// (get) Token: 0x06020E64 RID: 134756 RVA: 0x008DFDB0 File Offset: 0x008DDFB0
		// (set) Token: 0x06020E65 RID: 134757 RVA: 0x008DFDE9 File Offset: 0x008DDFE9
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
					result = (this._Vector_Parameters = new TMap<FName, FLinearColor>(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_5, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Vector_Parameters.CopyAssign(value);
			}
		}

		// Token: 0x17003329 RID: 13097
		// (get) Token: 0x06020E66 RID: 134758 RVA: 0x008DFDF8 File Offset: 0x008DDFF8
		// (set) Token: 0x06020E67 RID: 134759 RVA: 0x008DFE31 File Offset: 0x008DE031
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
					result = (this._Texture_Parameters = new TMap<FName, UTexture>(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_6, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Texture_Parameters.CopyAssign(value);
			}
		}

		// Token: 0x1700332A RID: 13098
		// (get) Token: 0x06020E68 RID: 134760 RVA: 0x008DFE3F File Offset: 0x008DE03F
		// (set) Token: 0x06020E69 RID: 134761 RVA: 0x008DFE4F File Offset: 0x008DE04F
		public unsafe float Distance0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x1700332B RID: 13099
		// (get) Token: 0x06020E6A RID: 134762 RVA: 0x008DFE60 File Offset: 0x008DE060
		// (set) Token: 0x06020E6B RID: 134763 RVA: 0x008DFE74 File Offset: 0x008DE074
		public unsafe UMaterialInstance Material
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Kaleidoscope_Mesh_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Kaleidoscope_Mesh_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x1700332C RID: 13100
		// (get) Token: 0x06020E6C RID: 134764 RVA: 0x008DFE89 File Offset: 0x008DE089
		// (set) Token: 0x06020E6D RID: 134765 RVA: 0x008DFE99 File Offset: 0x008DE099
		public unsafe float HollowRadius0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x1700332D RID: 13101
		// (get) Token: 0x06020E6E RID: 134766 RVA: 0x008DFEAA File Offset: 0x008DE0AA
		// (set) Token: 0x06020E6F RID: 134767 RVA: 0x008DFEBA File Offset: 0x008DE0BA
		public unsafe float Rotation0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x1700332E RID: 13102
		// (get) Token: 0x06020E70 RID: 134768 RVA: 0x008DFECB File Offset: 0x008DE0CB
		// (set) Token: 0x06020E71 RID: 134769 RVA: 0x008DFEDB File Offset: 0x008DE0DB
		public unsafe float Segment0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x1700332F RID: 13103
		// (get) Token: 0x06020E72 RID: 134770 RVA: 0x008DFEEC File Offset: 0x008DE0EC
		// (set) Token: 0x06020E73 RID: 134771 RVA: 0x008DFF00 File Offset: 0x008DE100
		public unsafe UTexture2D Texture0
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Kaleidoscope_Mesh_C.__PropertyOffset_12);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Kaleidoscope_Mesh_C.__PropertyOffset_12, value);
			}
		}

		// Token: 0x17003330 RID: 13104
		// (get) Token: 0x06020E74 RID: 134772 RVA: 0x008DFF15 File Offset: 0x008DE115
		// (set) Token: 0x06020E75 RID: 134773 RVA: 0x008DFF25 File Offset: 0x008DE125
		public unsafe float Twist0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17003331 RID: 13105
		// (get) Token: 0x06020E76 RID: 134774 RVA: 0x008DFF36 File Offset: 0x008DE136
		// (set) Token: 0x06020E77 RID: 134775 RVA: 0x008DFF46 File Offset: 0x008DE146
		public unsafe float Distance1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17003332 RID: 13106
		// (get) Token: 0x06020E78 RID: 134776 RVA: 0x008DFF57 File Offset: 0x008DE157
		// (set) Token: 0x06020E79 RID: 134777 RVA: 0x008DFF67 File Offset: 0x008DE167
		public unsafe float HollowRadius1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17003333 RID: 13107
		// (get) Token: 0x06020E7A RID: 134778 RVA: 0x008DFF78 File Offset: 0x008DE178
		// (set) Token: 0x06020E7B RID: 134779 RVA: 0x008DFF88 File Offset: 0x008DE188
		public unsafe float Rotation1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x17003334 RID: 13108
		// (get) Token: 0x06020E7C RID: 134780 RVA: 0x008DFF99 File Offset: 0x008DE199
		// (set) Token: 0x06020E7D RID: 134781 RVA: 0x008DFFA9 File Offset: 0x008DE1A9
		public unsafe float Segment1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x17003335 RID: 13109
		// (get) Token: 0x06020E7E RID: 134782 RVA: 0x008DFFBA File Offset: 0x008DE1BA
		// (set) Token: 0x06020E7F RID: 134783 RVA: 0x008DFFCE File Offset: 0x008DE1CE
		public unsafe UTexture2D Texture1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Kaleidoscope_Mesh_C.__PropertyOffset_18);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Kaleidoscope_Mesh_C.__PropertyOffset_18, value);
			}
		}

		// Token: 0x17003336 RID: 13110
		// (get) Token: 0x06020E80 RID: 134784 RVA: 0x008DFFE3 File Offset: 0x008DE1E3
		// (set) Token: 0x06020E81 RID: 134785 RVA: 0x008DFFF3 File Offset: 0x008DE1F3
		public unsafe float Twist1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x17003337 RID: 13111
		// (get) Token: 0x06020E82 RID: 134786 RVA: 0x008E0004 File Offset: 0x008DE204
		// (set) Token: 0x06020E83 RID: 134787 RVA: 0x008E0014 File Offset: 0x008DE214
		public unsafe float Distance2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x17003338 RID: 13112
		// (get) Token: 0x06020E84 RID: 134788 RVA: 0x008E0025 File Offset: 0x008DE225
		// (set) Token: 0x06020E85 RID: 134789 RVA: 0x008E0035 File Offset: 0x008DE235
		public unsafe float HollowRadius2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x17003339 RID: 13113
		// (get) Token: 0x06020E86 RID: 134790 RVA: 0x008E0046 File Offset: 0x008DE246
		// (set) Token: 0x06020E87 RID: 134791 RVA: 0x008E0056 File Offset: 0x008DE256
		public unsafe float Rotation2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x1700333A RID: 13114
		// (get) Token: 0x06020E88 RID: 134792 RVA: 0x008E0067 File Offset: 0x008DE267
		// (set) Token: 0x06020E89 RID: 134793 RVA: 0x008E0077 File Offset: 0x008DE277
		public unsafe float Segment2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x1700333B RID: 13115
		// (get) Token: 0x06020E8A RID: 134794 RVA: 0x008E0088 File Offset: 0x008DE288
		// (set) Token: 0x06020E8B RID: 134795 RVA: 0x008E009C File Offset: 0x008DE29C
		public unsafe UTexture2D Texture2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Kaleidoscope_Mesh_C.__PropertyOffset_24);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Kaleidoscope_Mesh_C.__PropertyOffset_24, value);
			}
		}

		// Token: 0x1700333C RID: 13116
		// (get) Token: 0x06020E8C RID: 134796 RVA: 0x008E00B1 File Offset: 0x008DE2B1
		// (set) Token: 0x06020E8D RID: 134797 RVA: 0x008E00C1 File Offset: 0x008DE2C1
		public unsafe float Twist2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_25);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_25) = value;
			}
		}

		// Token: 0x1700333D RID: 13117
		// (get) Token: 0x06020E8E RID: 134798 RVA: 0x008E00D2 File Offset: 0x008DE2D2
		// (set) Token: 0x06020E8F RID: 134799 RVA: 0x008E00E2 File Offset: 0x008DE2E2
		public unsafe float CenterOffsetX0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_26);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_26) = value;
			}
		}

		// Token: 0x1700333E RID: 13118
		// (get) Token: 0x06020E90 RID: 134800 RVA: 0x008E00F3 File Offset: 0x008DE2F3
		// (set) Token: 0x06020E91 RID: 134801 RVA: 0x008E0103 File Offset: 0x008DE303
		public unsafe float CenterOffsetY0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_27);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_27) = value;
			}
		}

		// Token: 0x1700333F RID: 13119
		// (get) Token: 0x06020E92 RID: 134802 RVA: 0x008E0114 File Offset: 0x008DE314
		// (set) Token: 0x06020E93 RID: 134803 RVA: 0x008E0124 File Offset: 0x008DE324
		public unsafe float CenterOffsetX1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_28);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_28) = value;
			}
		}

		// Token: 0x17003340 RID: 13120
		// (get) Token: 0x06020E94 RID: 134804 RVA: 0x008E0135 File Offset: 0x008DE335
		// (set) Token: 0x06020E95 RID: 134805 RVA: 0x008E0145 File Offset: 0x008DE345
		public unsafe float CenterOffsetY1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_29);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_29) = value;
			}
		}

		// Token: 0x17003341 RID: 13121
		// (get) Token: 0x06020E96 RID: 134806 RVA: 0x008E0156 File Offset: 0x008DE356
		// (set) Token: 0x06020E97 RID: 134807 RVA: 0x008E0166 File Offset: 0x008DE366
		public unsafe float CenterOffsetX2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_30);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_30) = value;
			}
		}

		// Token: 0x17003342 RID: 13122
		// (get) Token: 0x06020E98 RID: 134808 RVA: 0x008E0177 File Offset: 0x008DE377
		// (set) Token: 0x06020E99 RID: 134809 RVA: 0x008E0187 File Offset: 0x008DE387
		public unsafe float CenterOffsetY2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_31);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_31) = value;
			}
		}

		// Token: 0x17003343 RID: 13123
		// (get) Token: 0x06020E9A RID: 134810 RVA: 0x008E0198 File Offset: 0x008DE398
		// (set) Token: 0x06020E9B RID: 134811 RVA: 0x008E01A8 File Offset: 0x008DE3A8
		public unsafe float BlurIntensity0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_32);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_32) = value;
			}
		}

		// Token: 0x17003344 RID: 13124
		// (get) Token: 0x06020E9C RID: 134812 RVA: 0x008E01B9 File Offset: 0x008DE3B9
		// (set) Token: 0x06020E9D RID: 134813 RVA: 0x008E01C9 File Offset: 0x008DE3C9
		public unsafe float BlurIntensity1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_33);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_33) = value;
			}
		}

		// Token: 0x17003345 RID: 13125
		// (get) Token: 0x06020E9E RID: 134814 RVA: 0x008E01DA File Offset: 0x008DE3DA
		// (set) Token: 0x06020E9F RID: 134815 RVA: 0x008E01EA File Offset: 0x008DE3EA
		public unsafe float BlurIntensity2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_34);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_34) = value;
			}
		}

		// Token: 0x17003346 RID: 13126
		// (get) Token: 0x06020EA0 RID: 134816 RVA: 0x008E01FB File Offset: 0x008DE3FB
		// (set) Token: 0x06020EA1 RID: 134817 RVA: 0x008E020B File Offset: 0x008DE40B
		public unsafe float Distance3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_35);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_35) = value;
			}
		}

		// Token: 0x17003347 RID: 13127
		// (get) Token: 0x06020EA2 RID: 134818 RVA: 0x008E021C File Offset: 0x008DE41C
		// (set) Token: 0x06020EA3 RID: 134819 RVA: 0x008E022C File Offset: 0x008DE42C
		public unsafe float HollowRadius3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_36);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_36) = value;
			}
		}

		// Token: 0x17003348 RID: 13128
		// (get) Token: 0x06020EA4 RID: 134820 RVA: 0x008E023D File Offset: 0x008DE43D
		// (set) Token: 0x06020EA5 RID: 134821 RVA: 0x008E024D File Offset: 0x008DE44D
		public unsafe float Rotation3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_37);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_37) = value;
			}
		}

		// Token: 0x17003349 RID: 13129
		// (get) Token: 0x06020EA6 RID: 134822 RVA: 0x008E025E File Offset: 0x008DE45E
		// (set) Token: 0x06020EA7 RID: 134823 RVA: 0x008E026E File Offset: 0x008DE46E
		public unsafe float Segment3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_38);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_38) = value;
			}
		}

		// Token: 0x1700334A RID: 13130
		// (get) Token: 0x06020EA8 RID: 134824 RVA: 0x008E027F File Offset: 0x008DE47F
		// (set) Token: 0x06020EA9 RID: 134825 RVA: 0x008E0293 File Offset: 0x008DE493
		public unsafe UTexture2D Texture3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Kaleidoscope_Mesh_C.__PropertyOffset_39);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Kaleidoscope_Mesh_C.__PropertyOffset_39, value);
			}
		}

		// Token: 0x1700334B RID: 13131
		// (get) Token: 0x06020EAA RID: 134826 RVA: 0x008E02A8 File Offset: 0x008DE4A8
		// (set) Token: 0x06020EAB RID: 134827 RVA: 0x008E02B8 File Offset: 0x008DE4B8
		public unsafe float Twist3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_40);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_40) = value;
			}
		}

		// Token: 0x1700334C RID: 13132
		// (get) Token: 0x06020EAC RID: 134828 RVA: 0x008E02C9 File Offset: 0x008DE4C9
		// (set) Token: 0x06020EAD RID: 134829 RVA: 0x008E02D9 File Offset: 0x008DE4D9
		public unsafe float CenterOffsetX3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_41);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_41) = value;
			}
		}

		// Token: 0x1700334D RID: 13133
		// (get) Token: 0x06020EAE RID: 134830 RVA: 0x008E02EA File Offset: 0x008DE4EA
		// (set) Token: 0x06020EAF RID: 134831 RVA: 0x008E02FA File Offset: 0x008DE4FA
		public unsafe float CenterOffsetY3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_42);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_42) = value;
			}
		}

		// Token: 0x1700334E RID: 13134
		// (get) Token: 0x06020EB0 RID: 134832 RVA: 0x008E030B File Offset: 0x008DE50B
		// (set) Token: 0x06020EB1 RID: 134833 RVA: 0x008E031B File Offset: 0x008DE51B
		public unsafe float BlurIntensity3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_43);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_43) = value;
			}
		}

		// Token: 0x1700334F RID: 13135
		// (get) Token: 0x06020EB2 RID: 134834 RVA: 0x008E032C File Offset: 0x008DE52C
		// (set) Token: 0x06020EB3 RID: 134835 RVA: 0x008E0340 File Offset: 0x008DE540
		public unsafe FLinearColor ColorAdj
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_44);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_44) = value;
			}
		}

		// Token: 0x17003350 RID: 13136
		// (get) Token: 0x06020EB4 RID: 134836 RVA: 0x008E0355 File Offset: 0x008DE555
		// (set) Token: 0x06020EB5 RID: 134837 RVA: 0x008E0365 File Offset: 0x008DE565
		public unsafe bool BottomModel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_45) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_45) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003351 RID: 13137
		// (get) Token: 0x06020EB6 RID: 134838 RVA: 0x008E0376 File Offset: 0x008DE576
		// (set) Token: 0x06020EB7 RID: 134839 RVA: 0x008E0386 File Offset: 0x008DE586
		public unsafe bool TopModel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_46) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_46) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003352 RID: 13138
		// (get) Token: 0x06020EB8 RID: 134840 RVA: 0x008E0397 File Offset: 0x008DE597
		// (set) Token: 0x06020EB9 RID: 134841 RVA: 0x008E03AB File Offset: 0x008DE5AB
		[Nullable(1)]
		public unsafe string DYName
		{
			[NullableContext(1)]
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_47)));
			}
			[NullableContext(1)]
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_47)), value);
			}
		}

		// Token: 0x17003353 RID: 13139
		// (get) Token: 0x06020EBA RID: 134842 RVA: 0x008E03C0 File Offset: 0x008DE5C0
		// (set) Token: 0x06020EBB RID: 134843 RVA: 0x008E03D0 File Offset: 0x008DE5D0
		public unsafe float EdgeSoft
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_48);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_48) = value;
			}
		}

		// Token: 0x17003354 RID: 13140
		// (get) Token: 0x06020EBC RID: 134844 RVA: 0x008E03E1 File Offset: 0x008DE5E1
		// (set) Token: 0x06020EBD RID: 134845 RVA: 0x008E03F1 File Offset: 0x008DE5F1
		public unsafe float Opacity0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_49);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_49) = value;
			}
		}

		// Token: 0x17003355 RID: 13141
		// (get) Token: 0x06020EBE RID: 134846 RVA: 0x008E0402 File Offset: 0x008DE602
		// (set) Token: 0x06020EBF RID: 134847 RVA: 0x008E0412 File Offset: 0x008DE612
		public unsafe float Opacity1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_50);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_50) = value;
			}
		}

		// Token: 0x17003356 RID: 13142
		// (get) Token: 0x06020EC0 RID: 134848 RVA: 0x008E0423 File Offset: 0x008DE623
		// (set) Token: 0x06020EC1 RID: 134849 RVA: 0x008E0433 File Offset: 0x008DE633
		public unsafe float Opacity2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_51);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_51) = value;
			}
		}

		// Token: 0x17003357 RID: 13143
		// (get) Token: 0x06020EC2 RID: 134850 RVA: 0x008E0444 File Offset: 0x008DE644
		// (set) Token: 0x06020EC3 RID: 134851 RVA: 0x008E0454 File Offset: 0x008DE654
		public unsafe float Opacity3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_52);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_52) = value;
			}
		}

		// Token: 0x17003358 RID: 13144
		// (get) Token: 0x06020EC4 RID: 134852 RVA: 0x008E0465 File Offset: 0x008DE665
		// (set) Token: 0x06020EC5 RID: 134853 RVA: 0x008E0475 File Offset: 0x008DE675
		public unsafe float FadeVal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_53);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_53) = value;
			}
		}

		// Token: 0x17003359 RID: 13145
		// (get) Token: 0x06020EC6 RID: 134854 RVA: 0x008E0486 File Offset: 0x008DE686
		// (set) Token: 0x06020EC7 RID: 134855 RVA: 0x008E0496 File Offset: 0x008DE696
		public unsafe float FadeSoft
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_54);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_54) = value;
			}
		}

		// Token: 0x1700335A RID: 13146
		// (get) Token: 0x06020EC8 RID: 134856 RVA: 0x008E04A7 File Offset: 0x008DE6A7
		// (set) Token: 0x06020EC9 RID: 134857 RVA: 0x008E04B7 File Offset: 0x008DE6B7
		public unsafe float EdgeSoft_0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_55);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_55) = value;
			}
		}

		// Token: 0x1700335B RID: 13147
		// (get) Token: 0x06020ECA RID: 134858 RVA: 0x008E04C8 File Offset: 0x008DE6C8
		// (set) Token: 0x06020ECB RID: 134859 RVA: 0x008E04D8 File Offset: 0x008DE6D8
		public unsafe float EdgeSoft_1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_56);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_56) = value;
			}
		}

		// Token: 0x1700335C RID: 13148
		// (get) Token: 0x06020ECC RID: 134860 RVA: 0x008E04E9 File Offset: 0x008DE6E9
		// (set) Token: 0x06020ECD RID: 134861 RVA: 0x008E04F9 File Offset: 0x008DE6F9
		public unsafe float EdgeSoft_2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_57);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_57) = value;
			}
		}

		// Token: 0x1700335D RID: 13149
		// (get) Token: 0x06020ECE RID: 134862 RVA: 0x008E050A File Offset: 0x008DE70A
		// (set) Token: 0x06020ECF RID: 134863 RVA: 0x008E051A File Offset: 0x008DE71A
		public unsafe float EdgeSoft_3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_58);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_58) = value;
			}
		}

		// Token: 0x1700335E RID: 13150
		// (get) Token: 0x06020ED0 RID: 134864 RVA: 0x008E052B File Offset: 0x008DE72B
		// (set) Token: 0x06020ED1 RID: 134865 RVA: 0x008E053B File Offset: 0x008DE73B
		public unsafe float Distance4
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_59);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_59) = value;
			}
		}

		// Token: 0x1700335F RID: 13151
		// (get) Token: 0x06020ED2 RID: 134866 RVA: 0x008E054C File Offset: 0x008DE74C
		// (set) Token: 0x06020ED3 RID: 134867 RVA: 0x008E055C File Offset: 0x008DE75C
		public unsafe float HollowRadius4
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_60);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_60) = value;
			}
		}

		// Token: 0x17003360 RID: 13152
		// (get) Token: 0x06020ED4 RID: 134868 RVA: 0x008E056D File Offset: 0x008DE76D
		// (set) Token: 0x06020ED5 RID: 134869 RVA: 0x008E057D File Offset: 0x008DE77D
		public unsafe float Rotation4
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_61);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_61) = value;
			}
		}

		// Token: 0x17003361 RID: 13153
		// (get) Token: 0x06020ED6 RID: 134870 RVA: 0x008E058E File Offset: 0x008DE78E
		// (set) Token: 0x06020ED7 RID: 134871 RVA: 0x008E059E File Offset: 0x008DE79E
		public unsafe float Segment4
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_62);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_62) = value;
			}
		}

		// Token: 0x17003362 RID: 13154
		// (get) Token: 0x06020ED8 RID: 134872 RVA: 0x008E05AF File Offset: 0x008DE7AF
		// (set) Token: 0x06020ED9 RID: 134873 RVA: 0x008E05C3 File Offset: 0x008DE7C3
		public unsafe UTexture2D Texture4
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Kaleidoscope_Mesh_C.__PropertyOffset_63);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Kaleidoscope_Mesh_C.__PropertyOffset_63, value);
			}
		}

		// Token: 0x17003363 RID: 13155
		// (get) Token: 0x06020EDA RID: 134874 RVA: 0x008E05D8 File Offset: 0x008DE7D8
		// (set) Token: 0x06020EDB RID: 134875 RVA: 0x008E05E8 File Offset: 0x008DE7E8
		public unsafe float Twist4
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_64);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_64) = value;
			}
		}

		// Token: 0x17003364 RID: 13156
		// (get) Token: 0x06020EDC RID: 134876 RVA: 0x008E05F9 File Offset: 0x008DE7F9
		// (set) Token: 0x06020EDD RID: 134877 RVA: 0x008E0609 File Offset: 0x008DE809
		public unsafe float CenterOffsetX4
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_65);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_65) = value;
			}
		}

		// Token: 0x17003365 RID: 13157
		// (get) Token: 0x06020EDE RID: 134878 RVA: 0x008E061A File Offset: 0x008DE81A
		// (set) Token: 0x06020EDF RID: 134879 RVA: 0x008E062A File Offset: 0x008DE82A
		public unsafe float CenterOffsetY4
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_66);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_66) = value;
			}
		}

		// Token: 0x17003366 RID: 13158
		// (get) Token: 0x06020EE0 RID: 134880 RVA: 0x008E063B File Offset: 0x008DE83B
		// (set) Token: 0x06020EE1 RID: 134881 RVA: 0x008E064B File Offset: 0x008DE84B
		public unsafe float BlurIntensity4
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_67);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_67) = value;
			}
		}

		// Token: 0x17003367 RID: 13159
		// (get) Token: 0x06020EE2 RID: 134882 RVA: 0x008E065C File Offset: 0x008DE85C
		// (set) Token: 0x06020EE3 RID: 134883 RVA: 0x008E066C File Offset: 0x008DE86C
		public unsafe float Opacity4
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_68);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_68) = value;
			}
		}

		// Token: 0x17003368 RID: 13160
		// (get) Token: 0x06020EE4 RID: 134884 RVA: 0x008E067D File Offset: 0x008DE87D
		// (set) Token: 0x06020EE5 RID: 134885 RVA: 0x008E068D File Offset: 0x008DE88D
		public unsafe float EdgeSoft4
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_69);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Kaleidoscope_Mesh_C.__PropertyOffset_69) = value;
			}
		}

		// Token: 0x06020EE6 RID: 134886 RVA: 0x008E06A0 File Offset: 0x008DE8A0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetMaterialToPost(UObject Object)
		{
			BP_Kaleidoscope_Mesh_C.__SetMaterialToPost_FunctionParams* ptr = stackalloc BP_Kaleidoscope_Mesh_C.__SetMaterialToPost_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_Kaleidoscope_Mesh_C.__SetMaterialToPost_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Kaleidoscope_Mesh_C.__SetMaterialToPost_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Object = ((Object != null) ? Object.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Kaleidoscope_Mesh_C.__SetMaterialToPost_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020EE7 RID: 134887 RVA: 0x008E06F5 File Offset: 0x008DE8F5
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Set_Parameter()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Kaleidoscope_Mesh_C.__Set_Parameter_NativeFunctionPtr, null);
		}

		// Token: 0x06020EE8 RID: 134888 RVA: 0x008E0709 File Offset: 0x008DE909
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Kaleidoscope_Mesh_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06020EE9 RID: 134889 RVA: 0x008E071D File Offset: 0x008DE91D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Kaleidoscope_Mesh_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06020EEA RID: 134890 RVA: 0x008E0732 File Offset: 0x008DE932
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Kaleidoscope_Mesh_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06020EEB RID: 134891 RVA: 0x008E0746 File Offset: 0x008DE946
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Kaleidoscope_Mesh_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06020EEC RID: 134892 RVA: 0x008E075C File Offset: 0x008DE95C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_Kaleidoscope_Mesh_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Kaleidoscope_Mesh_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Kaleidoscope_Mesh_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Kaleidoscope_Mesh_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Kaleidoscope_Mesh_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020EED RID: 134893 RVA: 0x008E07A4 File Offset: 0x008DE9A4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_Kaleidoscope_Mesh_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Kaleidoscope_Mesh_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Kaleidoscope_Mesh_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Kaleidoscope_Mesh_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Kaleidoscope_Mesh_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06020EEE RID: 134894 RVA: 0x008E07EB File Offset: 0x008DE9EB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveDestroyed()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Kaleidoscope_Mesh_C.__ReceiveDestroyed_NativeFunctionPtr, null);
		}

		// Token: 0x06020EEF RID: 134895 RVA: 0x008E07FF File Offset: 0x008DE9FF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveDestroyed_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Kaleidoscope_Mesh_C.__ReceiveDestroyed_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06020EF0 RID: 134896 RVA: 0x008E0814 File Offset: 0x008DEA14
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_Kaleidoscope_Mesh_C.__EditorTick_FunctionParams* ptr = stackalloc BP_Kaleidoscope_Mesh_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Kaleidoscope_Mesh_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Kaleidoscope_Mesh_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Kaleidoscope_Mesh_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020EF1 RID: 134897 RVA: 0x008E085C File Offset: 0x008DEA5C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_Kaleidoscope_Mesh_C.__EditorTick_FunctionParams* ptr = stackalloc BP_Kaleidoscope_Mesh_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Kaleidoscope_Mesh_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Kaleidoscope_Mesh_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Kaleidoscope_Mesh_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06020EF2 RID: 134898 RVA: 0x008E08A3 File Offset: 0x008DEAA3
		protected BP_Kaleidoscope_Mesh_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FFCC RID: 65484
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_Kaleidoscope_Mesh.BP_Kaleidoscope_Mesh_C";

		// Token: 0x0400FFCD RID: 65485
		private static IntPtr _ClassPtr;

		// Token: 0x0400FFCE RID: 65486
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FFCF RID: 65487
		internal static int __PropertyOffset_1;

		// Token: 0x0400FFD0 RID: 65488
		internal static int __PropertyOffset_2;

		// Token: 0x0400FFD1 RID: 65489
		internal static int __PropertyOffset_3;

		// Token: 0x0400FFD2 RID: 65490
		internal static int __PropertyOffset_4;

		// Token: 0x0400FFD3 RID: 65491
		private TMap<FName, float> _Scalar_Parameters;

		// Token: 0x0400FFD4 RID: 65492
		internal static int __PropertyOffset_5;

		// Token: 0x0400FFD5 RID: 65493
		private TMap<FName, FLinearColor> _Vector_Parameters;

		// Token: 0x0400FFD6 RID: 65494
		internal static int __PropertyOffset_6;

		// Token: 0x0400FFD7 RID: 65495
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, UTexture> _Texture_Parameters;

		// Token: 0x0400FFD8 RID: 65496
		internal static int __PropertyOffset_7;

		// Token: 0x0400FFD9 RID: 65497
		internal static int __PropertyOffset_8;

		// Token: 0x0400FFDA RID: 65498
		internal static int __PropertyOffset_9;

		// Token: 0x0400FFDB RID: 65499
		internal static int __PropertyOffset_10;

		// Token: 0x0400FFDC RID: 65500
		internal static int __PropertyOffset_11;

		// Token: 0x0400FFDD RID: 65501
		internal static int __PropertyOffset_12;

		// Token: 0x0400FFDE RID: 65502
		internal static int __PropertyOffset_13;

		// Token: 0x0400FFDF RID: 65503
		internal static int __PropertyOffset_14;

		// Token: 0x0400FFE0 RID: 65504
		internal static int __PropertyOffset_15;

		// Token: 0x0400FFE1 RID: 65505
		internal static int __PropertyOffset_16;

		// Token: 0x0400FFE2 RID: 65506
		internal static int __PropertyOffset_17;

		// Token: 0x0400FFE3 RID: 65507
		internal static int __PropertyOffset_18;

		// Token: 0x0400FFE4 RID: 65508
		internal static int __PropertyOffset_19;

		// Token: 0x0400FFE5 RID: 65509
		internal static int __PropertyOffset_20;

		// Token: 0x0400FFE6 RID: 65510
		internal static int __PropertyOffset_21;

		// Token: 0x0400FFE7 RID: 65511
		internal static int __PropertyOffset_22;

		// Token: 0x0400FFE8 RID: 65512
		internal static int __PropertyOffset_23;

		// Token: 0x0400FFE9 RID: 65513
		internal static int __PropertyOffset_24;

		// Token: 0x0400FFEA RID: 65514
		internal static int __PropertyOffset_25;

		// Token: 0x0400FFEB RID: 65515
		internal static int __PropertyOffset_26;

		// Token: 0x0400FFEC RID: 65516
		internal static int __PropertyOffset_27;

		// Token: 0x0400FFED RID: 65517
		internal static int __PropertyOffset_28;

		// Token: 0x0400FFEE RID: 65518
		internal static int __PropertyOffset_29;

		// Token: 0x0400FFEF RID: 65519
		internal static int __PropertyOffset_30;

		// Token: 0x0400FFF0 RID: 65520
		internal static int __PropertyOffset_31;

		// Token: 0x0400FFF1 RID: 65521
		internal static int __PropertyOffset_32;

		// Token: 0x0400FFF2 RID: 65522
		internal static int __PropertyOffset_33;

		// Token: 0x0400FFF3 RID: 65523
		internal static int __PropertyOffset_34;

		// Token: 0x0400FFF4 RID: 65524
		internal static int __PropertyOffset_35;

		// Token: 0x0400FFF5 RID: 65525
		internal static int __PropertyOffset_36;

		// Token: 0x0400FFF6 RID: 65526
		internal static int __PropertyOffset_37;

		// Token: 0x0400FFF7 RID: 65527
		internal static int __PropertyOffset_38;

		// Token: 0x0400FFF8 RID: 65528
		internal static int __PropertyOffset_39;

		// Token: 0x0400FFF9 RID: 65529
		internal static int __PropertyOffset_40;

		// Token: 0x0400FFFA RID: 65530
		internal static int __PropertyOffset_41;

		// Token: 0x0400FFFB RID: 65531
		internal static int __PropertyOffset_42;

		// Token: 0x0400FFFC RID: 65532
		internal static int __PropertyOffset_43;

		// Token: 0x0400FFFD RID: 65533
		internal static int __PropertyOffset_44;

		// Token: 0x0400FFFE RID: 65534
		internal static int __PropertyOffset_45;

		// Token: 0x0400FFFF RID: 65535
		internal static int __PropertyOffset_46;

		// Token: 0x04010000 RID: 65536
		internal static int __PropertyOffset_47;

		// Token: 0x04010001 RID: 65537
		internal static int __PropertyOffset_48;

		// Token: 0x04010002 RID: 65538
		internal static int __PropertyOffset_49;

		// Token: 0x04010003 RID: 65539
		internal static int __PropertyOffset_50;

		// Token: 0x04010004 RID: 65540
		internal static int __PropertyOffset_51;

		// Token: 0x04010005 RID: 65541
		internal static int __PropertyOffset_52;

		// Token: 0x04010006 RID: 65542
		internal static int __PropertyOffset_53;

		// Token: 0x04010007 RID: 65543
		internal static int __PropertyOffset_54;

		// Token: 0x04010008 RID: 65544
		internal static int __PropertyOffset_55;

		// Token: 0x04010009 RID: 65545
		internal static int __PropertyOffset_56;

		// Token: 0x0401000A RID: 65546
		internal static int __PropertyOffset_57;

		// Token: 0x0401000B RID: 65547
		internal static int __PropertyOffset_58;

		// Token: 0x0401000C RID: 65548
		internal static int __PropertyOffset_59;

		// Token: 0x0401000D RID: 65549
		internal static int __PropertyOffset_60;

		// Token: 0x0401000E RID: 65550
		internal static int __PropertyOffset_61;

		// Token: 0x0401000F RID: 65551
		internal static int __PropertyOffset_62;

		// Token: 0x04010010 RID: 65552
		internal static int __PropertyOffset_63;

		// Token: 0x04010011 RID: 65553
		internal static int __PropertyOffset_64;

		// Token: 0x04010012 RID: 65554
		internal static int __PropertyOffset_65;

		// Token: 0x04010013 RID: 65555
		internal static int __PropertyOffset_66;

		// Token: 0x04010014 RID: 65556
		internal static int __PropertyOffset_67;

		// Token: 0x04010015 RID: 65557
		internal static int __PropertyOffset_68;

		// Token: 0x04010016 RID: 65558
		internal static int __PropertyOffset_69;

		// Token: 0x04010017 RID: 65559
		private static IntPtr __SetMaterialToPost_NativeFunctionPtr;

		// Token: 0x04010018 RID: 65560
		private static IntPtr __Set_Parameter_NativeFunctionPtr;

		// Token: 0x04010019 RID: 65561
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0401001A RID: 65562
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0401001B RID: 65563
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0401001C RID: 65564
		private static IntPtr __ReceiveDestroyed_NativeFunctionPtr;

		// Token: 0x0401001D RID: 65565
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x02009C4B RID: 40011
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __SetMaterialToPost_FunctionParams
		{
			// Token: 0x040312FF RID: 201471
			[FieldOffset(0)]
			public IntPtr Object;
		}

		// Token: 0x02009C4C RID: 40012
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031300 RID: 201472
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009C4D RID: 40013
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x04031301 RID: 201473
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}

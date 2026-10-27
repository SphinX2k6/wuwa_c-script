using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.GI.NewCloud.BP
{
	// Token: 0x02003D58 RID: 15704
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/GI/NewCloud/BP/BP_CloudPrefab.BP_CloudPrefab_C")]
	[UnrealStructLayout(1928, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1921)]
	public class BP_CloudPrefab_C : AKuroCloudPrefabActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060264BA RID: 156858 RVA: 0x009713DC File Offset: 0x0096F5DC
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_CloudPrefab_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/GI/NewCloud/BP/BP_CloudPrefab.BP_CloudPrefab_C");
			}
			return BP_CloudPrefab_C._ClassPtr;
		}

		// Token: 0x060264BB RID: 156859 RVA: 0x00971400 File Offset: 0x0096F600
		public BP_CloudPrefab_C() : this(BuiltinUtils.AllocNativeUObject(BP_CloudPrefab_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060264BC RID: 156860 RVA: 0x00971428 File Offset: 0x0096F628
		[NullableContext(1)]
		public BP_CloudPrefab_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_CloudPrefab_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005180 RID: 20864
		// (get) Token: 0x060264BD RID: 156861 RVA: 0x0097145B File Offset: 0x0096F65B
		// (set) Token: 0x060264BE RID: 156862 RVA: 0x0097146F File Offset: 0x0096F66F
		public unsafe UStaticMeshComponent Cloud_Top
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudPrefab_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudPrefab_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17005181 RID: 20865
		// (get) Token: 0x060264BF RID: 156863 RVA: 0x00971484 File Offset: 0x0096F684
		// (set) Token: 0x060264C0 RID: 156864 RVA: 0x00971498 File Offset: 0x0096F698
		public unsafe UStaticMeshComponent Mountain
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudPrefab_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudPrefab_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17005182 RID: 20866
		// (get) Token: 0x060264C1 RID: 156865 RVA: 0x009714AD File Offset: 0x0096F6AD
		// (set) Token: 0x060264C2 RID: 156866 RVA: 0x009714C1 File Offset: 0x0096F6C1
		public unsafe UStaticMeshComponent Cloud_BigShape
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudPrefab_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudPrefab_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17005183 RID: 20867
		// (get) Token: 0x060264C3 RID: 156867 RVA: 0x009714D6 File Offset: 0x0096F6D6
		// (set) Token: 0x060264C4 RID: 156868 RVA: 0x009714EA File Offset: 0x0096F6EA
		public unsafe UStaticMeshComponent Cloud_Cover
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudPrefab_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudPrefab_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17005184 RID: 20868
		// (get) Token: 0x060264C5 RID: 156869 RVA: 0x009714FF File Offset: 0x0096F6FF
		// (set) Token: 0x060264C6 RID: 156870 RVA: 0x00971513 File Offset: 0x0096F713
		public unsafe UStaticMeshComponent Parent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudPrefab_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudPrefab_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17005185 RID: 20869
		// (get) Token: 0x060264C7 RID: 156871 RVA: 0x00971528 File Offset: 0x0096F728
		// (set) Token: 0x060264C8 RID: 156872 RVA: 0x0097153C File Offset: 0x0096F73C
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudPrefab_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudPrefab_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x17005186 RID: 20870
		// (get) Token: 0x060264C9 RID: 156873 RVA: 0x00971551 File Offset: 0x0096F751
		// (set) Token: 0x060264CA RID: 156874 RVA: 0x00971565 File Offset: 0x0096F765
		public unsafe UTexture CloudColorMap
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudPrefab_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudPrefab_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x17005187 RID: 20871
		// (get) Token: 0x060264CB RID: 156875 RVA: 0x0097157A File Offset: 0x0096F77A
		// (set) Token: 0x060264CC RID: 156876 RVA: 0x0097158E File Offset: 0x0096F78E
		public unsafe UTexture CloudMaskMap
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudPrefab_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudPrefab_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x17005188 RID: 20872
		// (get) Token: 0x060264CD RID: 156877 RVA: 0x009715A3 File Offset: 0x0096F7A3
		// (set) Token: 0x060264CE RID: 156878 RVA: 0x009715B3 File Offset: 0x0096F7B3
		public unsafe float ChangeSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudPrefab_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudPrefab_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17005189 RID: 20873
		// (get) Token: 0x060264CF RID: 156879 RVA: 0x009715C4 File Offset: 0x0096F7C4
		// (set) Token: 0x060264D0 RID: 156880 RVA: 0x009715D4 File Offset: 0x0096F7D4
		public unsafe float CloudRotateSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudPrefab_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudPrefab_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x1700518A RID: 20874
		// (get) Token: 0x060264D1 RID: 156881 RVA: 0x009715E5 File Offset: 0x0096F7E5
		// (set) Token: 0x060264D2 RID: 156882 RVA: 0x009715F5 File Offset: 0x0096F7F5
		public unsafe float Time
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudPrefab_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudPrefab_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x1700518B RID: 20875
		// (get) Token: 0x060264D3 RID: 156883 RVA: 0x00971606 File Offset: 0x0096F806
		// (set) Token: 0x060264D4 RID: 156884 RVA: 0x00971616 File Offset: 0x0096F816
		public unsafe bool change
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudPrefab_C.__PropertyOffset_12) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudPrefab_C.__PropertyOffset_12) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700518C RID: 20876
		// (get) Token: 0x060264D5 RID: 156885 RVA: 0x00971627 File Offset: 0x0096F827
		// (set) Token: 0x060264D6 RID: 156886 RVA: 0x00971637 File Offset: 0x0096F837
		public unsafe bool Stop
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudPrefab_C.__PropertyOffset_13) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudPrefab_C.__PropertyOffset_13) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700518D RID: 20877
		// (get) Token: 0x060264D7 RID: 156887 RVA: 0x00971648 File Offset: 0x0096F848
		// (set) Token: 0x060264D8 RID: 156888 RVA: 0x00971658 File Offset: 0x0096F858
		public unsafe bool Farward
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudPrefab_C.__PropertyOffset_14) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudPrefab_C.__PropertyOffset_14) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700518E RID: 20878
		// (get) Token: 0x060264D9 RID: 156889 RVA: 0x0097166C File Offset: 0x0096F86C
		// (set) Token: 0x060264DA RID: 156890 RVA: 0x009716A5 File Offset: 0x0096F8A5
		[Nullable(1)]
		public TArray<UMaterialInstanceDynamic> DMI
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInstanceDynamic> result;
				if ((result = this._DMI) == null)
				{
					result = (this._DMI = new TArray<UMaterialInstanceDynamic>(base.NativePtr + (IntPtr)BP_CloudPrefab_C.__PropertyOffset_15, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.DMI.CopyAssign(value);
			}
		}

		// Token: 0x1700518F RID: 20879
		// (get) Token: 0x060264DB RID: 156891 RVA: 0x009716B3 File Offset: 0x0096F8B3
		// (set) Token: 0x060264DC RID: 156892 RVA: 0x009716C3 File Offset: 0x0096F8C3
		public unsafe float Delta_Seconds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudPrefab_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudPrefab_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x17005190 RID: 20880
		// (get) Token: 0x060264DD RID: 156893 RVA: 0x009716D4 File Offset: 0x0096F8D4
		// (set) Token: 0x060264DE RID: 156894 RVA: 0x009716E4 File Offset: 0x0096F8E4
		public unsafe bool TimerInit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudPrefab_C.__PropertyOffset_17) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudPrefab_C.__PropertyOffset_17) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005191 RID: 20881
		// (get) Token: 0x060264DF RID: 156895 RVA: 0x009716F5 File Offset: 0x0096F8F5
		// (set) Token: 0x060264E0 RID: 156896 RVA: 0x00971705 File Offset: 0x0096F905
		public unsafe bool ColoredCloud_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudPrefab_C.__PropertyOffset_18) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudPrefab_C.__PropertyOffset_18) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005192 RID: 20882
		// (get) Token: 0x060264E1 RID: 156897 RVA: 0x00971716 File Offset: 0x0096F916
		// (set) Token: 0x060264E2 RID: 156898 RVA: 0x00971726 File Offset: 0x0096F926
		public unsafe float CloudSaturation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudPrefab_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudPrefab_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x17005193 RID: 20883
		// (get) Token: 0x060264E3 RID: 156899 RVA: 0x00971737 File Offset: 0x0096F937
		// (set) Token: 0x060264E4 RID: 156900 RVA: 0x00971747 File Offset: 0x0096F947
		public unsafe float CurrentOpacity___别改我__
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudPrefab_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudPrefab_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x17005194 RID: 20884
		// (get) Token: 0x060264E5 RID: 156901 RVA: 0x00971758 File Offset: 0x0096F958
		// (set) Token: 0x060264E6 RID: 156902 RVA: 0x0097176C File Offset: 0x0096F96C
		public unsafe UMaterialInstanceDynamic DMI_Top
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudPrefab_C.__PropertyOffset_21);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudPrefab_C.__PropertyOffset_21, value);
			}
		}

		// Token: 0x17005195 RID: 20885
		// (get) Token: 0x060264E7 RID: 156903 RVA: 0x00971781 File Offset: 0x0096F981
		// (set) Token: 0x060264E8 RID: 156904 RVA: 0x00971795 File Offset: 0x0096F995
		public unsafe UMaterialInstanceDynamic DMI_Cover
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudPrefab_C.__PropertyOffset_22);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudPrefab_C.__PropertyOffset_22, value);
			}
		}

		// Token: 0x17005196 RID: 20886
		// (get) Token: 0x060264E9 RID: 156905 RVA: 0x009717AA File Offset: 0x0096F9AA
		// (set) Token: 0x060264EA RID: 156906 RVA: 0x009717BE File Offset: 0x0096F9BE
		public unsafe UMaterialInstanceDynamic DMI_Anomalies
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudPrefab_C.__PropertyOffset_23);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudPrefab_C.__PropertyOffset_23, value);
			}
		}

		// Token: 0x17005197 RID: 20887
		// (get) Token: 0x060264EB RID: 156907 RVA: 0x009717D3 File Offset: 0x0096F9D3
		// (set) Token: 0x060264EC RID: 156908 RVA: 0x009717E7 File Offset: 0x0096F9E7
		public unsafe UMaterialInstanceDynamic DMI_BigShape
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudPrefab_C.__PropertyOffset_24);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudPrefab_C.__PropertyOffset_24, value);
			}
		}

		// Token: 0x17005198 RID: 20888
		// (get) Token: 0x060264ED RID: 156909 RVA: 0x009717FC File Offset: 0x0096F9FC
		// (set) Token: 0x060264EE RID: 156910 RVA: 0x00971810 File Offset: 0x0096FA10
		public unsafe UMaterialInstanceDynamic DMI_Mountain
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudPrefab_C.__PropertyOffset_25);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudPrefab_C.__PropertyOffset_25, value);
			}
		}

		// Token: 0x17005199 RID: 20889
		// (get) Token: 0x060264EF RID: 156911 RVA: 0x00971825 File Offset: 0x0096FA25
		// (set) Token: 0x060264F0 RID: 156912 RVA: 0x00971835 File Offset: 0x0096FA35
		public unsafe float CloudInitialZAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudPrefab_C.__PropertyOffset_26);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudPrefab_C.__PropertyOffset_26) = value;
			}
		}

		// Token: 0x1700519A RID: 20890
		// (get) Token: 0x060264F1 RID: 156913 RVA: 0x00971846 File Offset: 0x0096FA46
		// (set) Token: 0x060264F2 RID: 156914 RVA: 0x00971856 File Offset: 0x0096FA56
		public unsafe bool UpdatePerFourFrame01
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudPrefab_C.__PropertyOffset_27) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudPrefab_C.__PropertyOffset_27) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700519B RID: 20891
		// (get) Token: 0x060264F3 RID: 156915 RVA: 0x00971867 File Offset: 0x0096FA67
		// (set) Token: 0x060264F4 RID: 156916 RVA: 0x00971877 File Offset: 0x0096FA77
		public unsafe bool UpdatePerFourFrame02
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudPrefab_C.__PropertyOffset_28) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudPrefab_C.__PropertyOffset_28) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700519C RID: 20892
		// (get) Token: 0x060264F5 RID: 156917 RVA: 0x00971888 File Offset: 0x0096FA88
		// (set) Token: 0x060264F6 RID: 156918 RVA: 0x00971898 File Offset: 0x0096FA98
		public unsafe bool SetCoverMaterial
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudPrefab_C.__PropertyOffset_29) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudPrefab_C.__PropertyOffset_29) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700519D RID: 20893
		// (get) Token: 0x060264F7 RID: 156919 RVA: 0x009718A9 File Offset: 0x0096FAA9
		// (set) Token: 0x060264F8 RID: 156920 RVA: 0x009718BD File Offset: 0x0096FABD
		public unsafe UMaterialInterface Cloud_Cover_Material
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudPrefab_C.__PropertyOffset_30);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudPrefab_C.__PropertyOffset_30, value);
			}
		}

		// Token: 0x1700519E RID: 20894
		// (get) Token: 0x060264F9 RID: 156921 RVA: 0x009718D2 File Offset: 0x0096FAD2
		// (set) Token: 0x060264FA RID: 156922 RVA: 0x009718E2 File Offset: 0x0096FAE2
		public unsafe int TransSortNumber
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudPrefab_C.__PropertyOffset_31);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudPrefab_C.__PropertyOffset_31) = value;
			}
		}

		// Token: 0x1700519F RID: 20895
		// (get) Token: 0x060264FB RID: 156923 RVA: 0x009718F4 File Offset: 0x0096FAF4
		// (set) Token: 0x060264FC RID: 156924 RVA: 0x0097192D File Offset: 0x0096FB2D
		[Nullable(1)]
		public TArray<UStaticMeshComponent> MeshArray
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UStaticMeshComponent> result;
				if ((result = this._MeshArray) == null)
				{
					result = (this._MeshArray = new TArray<UStaticMeshComponent>(base.NativePtr + (IntPtr)BP_CloudPrefab_C.__PropertyOffset_32, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.MeshArray.CopyAssign(value);
			}
		}

		// Token: 0x170051A0 RID: 20896
		// (get) Token: 0x060264FD RID: 156925 RVA: 0x0097193C File Offset: 0x0096FB3C
		// (set) Token: 0x060264FE RID: 156926 RVA: 0x00971975 File Offset: 0x0096FB75
		[Nullable(1)]
		public TArray<UMaterialInstanceDynamic> DMIArray
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInstanceDynamic> result;
				if ((result = this._DMIArray) == null)
				{
					result = (this._DMIArray = new TArray<UMaterialInstanceDynamic>(base.NativePtr + (IntPtr)BP_CloudPrefab_C.__PropertyOffset_33, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.DMIArray.CopyAssign(value);
			}
		}

		// Token: 0x170051A1 RID: 20897
		// (get) Token: 0x060264FF RID: 156927 RVA: 0x00971983 File Offset: 0x0096FB83
		// (set) Token: 0x06026500 RID: 156928 RVA: 0x00971993 File Offset: 0x0096FB93
		public unsafe float Random
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudPrefab_C.__PropertyOffset_34);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudPrefab_C.__PropertyOffset_34) = value;
			}
		}

		// Token: 0x170051A2 RID: 20898
		// (get) Token: 0x06026501 RID: 156929 RVA: 0x009719A4 File Offset: 0x0096FBA4
		// (set) Token: 0x06026502 RID: 156930 RVA: 0x009719DD File Offset: 0x0096FBDD
		[Nullable(1)]
		public TArray<int> Trans
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._Trans) == null)
				{
					result = (this._Trans = new TArray<int>(base.NativePtr + (IntPtr)BP_CloudPrefab_C.__PropertyOffset_35, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Trans.CopyAssign(value);
			}
		}

		// Token: 0x170051A3 RID: 20899
		// (get) Token: 0x06026503 RID: 156931 RVA: 0x009719EB File Offset: 0x0096FBEB
		// (set) Token: 0x06026504 RID: 156932 RVA: 0x009719FB File Offset: 0x0096FBFB
		public unsafe float SDFTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudPrefab_C.__PropertyOffset_36);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudPrefab_C.__PropertyOffset_36) = value;
			}
		}

		// Token: 0x170051A4 RID: 20900
		// (get) Token: 0x06026505 RID: 156933 RVA: 0x00971A0C File Offset: 0x0096FC0C
		// (set) Token: 0x06026506 RID: 156934 RVA: 0x00971A1C File Offset: 0x0096FC1C
		public unsafe bool bFollowChar
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudPrefab_C.__PropertyOffset_37) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudPrefab_C.__PropertyOffset_37) = (value ? 1 : 0);
			}
		}

		// Token: 0x170051A5 RID: 20901
		// (get) Token: 0x06026507 RID: 156935 RVA: 0x00971A2D File Offset: 0x0096FC2D
		// (set) Token: 0x06026508 RID: 156936 RVA: 0x00971A3D File Offset: 0x0096FC3D
		public unsafe bool bFollowCamera
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudPrefab_C.__PropertyOffset_38) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudPrefab_C.__PropertyOffset_38) = (value ? 1 : 0);
			}
		}

		// Token: 0x170051A6 RID: 20902
		// (get) Token: 0x06026509 RID: 156937 RVA: 0x00971A4E File Offset: 0x0096FC4E
		// (set) Token: 0x0602650A RID: 156938 RVA: 0x00971A5E File Offset: 0x0096FC5E
		public unsafe float SmoothWidth_0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudPrefab_C.__PropertyOffset_39);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudPrefab_C.__PropertyOffset_39) = value;
			}
		}

		// Token: 0x170051A7 RID: 20903
		// (get) Token: 0x0602650B RID: 156939 RVA: 0x00971A6F File Offset: 0x0096FC6F
		// (set) Token: 0x0602650C RID: 156940 RVA: 0x00971A7F File Offset: 0x0096FC7F
		public unsafe bool bOverrideCloudOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudPrefab_C.__PropertyOffset_40) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudPrefab_C.__PropertyOffset_40) = (value ? 1 : 0);
			}
		}

		// Token: 0x170051A8 RID: 20904
		// (get) Token: 0x0602650D RID: 156941 RVA: 0x00971A90 File Offset: 0x0096FC90
		// (set) Token: 0x0602650E RID: 156942 RVA: 0x00971AA0 File Offset: 0x0096FCA0
		public unsafe float CloudSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudPrefab_C.__PropertyOffset_41);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudPrefab_C.__PropertyOffset_41) = value;
			}
		}

		// Token: 0x170051A9 RID: 20905
		// (get) Token: 0x0602650F RID: 156943 RVA: 0x00971AB1 File Offset: 0x0096FCB1
		// (set) Token: 0x06026510 RID: 156944 RVA: 0x00971AC1 File Offset: 0x0096FCC1
		public unsafe float CloudOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudPrefab_C.__PropertyOffset_42);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudPrefab_C.__PropertyOffset_42) = value;
			}
		}

		// Token: 0x170051AA RID: 20906
		// (get) Token: 0x06026511 RID: 156945 RVA: 0x00971AD2 File Offset: 0x0096FCD2
		// (set) Token: 0x06026512 RID: 156946 RVA: 0x00971AE2 File Offset: 0x0096FCE2
		public unsafe bool IsReversed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudPrefab_C.__PropertyOffset_43) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudPrefab_C.__PropertyOffset_43) = (value ? 1 : 0);
			}
		}

		// Token: 0x170051AB RID: 20907
		// (get) Token: 0x06026513 RID: 156947 RVA: 0x00971AF3 File Offset: 0x0096FCF3
		// (set) Token: 0x06026514 RID: 156948 RVA: 0x00971B03 File Offset: 0x0096FD03
		public unsafe bool IsReversedTemp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudPrefab_C.__PropertyOffset_44) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudPrefab_C.__PropertyOffset_44) = (value ? 1 : 0);
			}
		}

		// Token: 0x170051AC RID: 20908
		// (get) Token: 0x06026515 RID: 156949 RVA: 0x00971B14 File Offset: 0x0096FD14
		// (set) Token: 0x06026516 RID: 156950 RVA: 0x00971B24 File Offset: 0x0096FD24
		public unsafe float ReversedZHeightBias
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudPrefab_C.__PropertyOffset_45);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudPrefab_C.__PropertyOffset_45) = value;
			}
		}

		// Token: 0x170051AD RID: 20909
		// (get) Token: 0x06026517 RID: 156951 RVA: 0x00971B35 File Offset: 0x0096FD35
		// (set) Token: 0x06026518 RID: 156952 RVA: 0x00971B45 File Offset: 0x0096FD45
		public unsafe bool CoverNoiseParameters
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudPrefab_C.__PropertyOffset_46) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudPrefab_C.__PropertyOffset_46) = (value ? 1 : 0);
			}
		}

		// Token: 0x170051AE RID: 20910
		// (get) Token: 0x06026519 RID: 156953 RVA: 0x00971B56 File Offset: 0x0096FD56
		// (set) Token: 0x0602651A RID: 156954 RVA: 0x00971B66 File Offset: 0x0096FD66
		public unsafe float NoiseSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudPrefab_C.__PropertyOffset_47);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudPrefab_C.__PropertyOffset_47) = value;
			}
		}

		// Token: 0x170051AF RID: 20911
		// (get) Token: 0x0602651B RID: 156955 RVA: 0x00971B77 File Offset: 0x0096FD77
		// (set) Token: 0x0602651C RID: 156956 RVA: 0x00971B87 File Offset: 0x0096FD87
		public unsafe float NoiseTilling
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudPrefab_C.__PropertyOffset_48);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudPrefab_C.__PropertyOffset_48) = value;
			}
		}

		// Token: 0x170051B0 RID: 20912
		// (get) Token: 0x0602651D RID: 156957 RVA: 0x00971B98 File Offset: 0x0096FD98
		// (set) Token: 0x0602651E RID: 156958 RVA: 0x00971BA8 File Offset: 0x0096FDA8
		public unsafe float NoiseStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudPrefab_C.__PropertyOffset_49);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudPrefab_C.__PropertyOffset_49) = value;
			}
		}

		// Token: 0x170051B1 RID: 20913
		// (get) Token: 0x0602651F RID: 156959 RVA: 0x00971BB9 File Offset: 0x0096FDB9
		// (set) Token: 0x06026520 RID: 156960 RVA: 0x00971BC9 File Offset: 0x0096FDC9
		public unsafe float ChangeProgress
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudPrefab_C.__PropertyOffset_50);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudPrefab_C.__PropertyOffset_50) = value;
			}
		}

		// Token: 0x170051B2 RID: 20914
		// (get) Token: 0x06026521 RID: 156961 RVA: 0x00971BDA File Offset: 0x0096FDDA
		// (set) Token: 0x06026522 RID: 156962 RVA: 0x00971BEA File Offset: 0x0096FDEA
		public unsafe bool EnableSequence
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudPrefab_C.__PropertyOffset_51) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudPrefab_C.__PropertyOffset_51) = (value ? 1 : 0);
			}
		}

		// Token: 0x170051B3 RID: 20915
		// (get) Token: 0x06026523 RID: 156963 RVA: 0x00971BFB File Offset: 0x0096FDFB
		// (set) Token: 0x06026524 RID: 156964 RVA: 0x00971C0B File Offset: 0x0096FE0B
		public unsafe float CurveTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudPrefab_C.__PropertyOffset_52);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudPrefab_C.__PropertyOffset_52) = value;
			}
		}

		// Token: 0x170051B4 RID: 20916
		// (get) Token: 0x06026525 RID: 156965 RVA: 0x00971C1C File Offset: 0x0096FE1C
		// (set) Token: 0x06026526 RID: 156966 RVA: 0x00971C2C File Offset: 0x0096FE2C
		public unsafe bool CurveStart
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudPrefab_C.__PropertyOffset_53) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudPrefab_C.__PropertyOffset_53) = (value ? 1 : 0);
			}
		}

		// Token: 0x170051B5 RID: 20917
		// (get) Token: 0x06026527 RID: 156967 RVA: 0x00971C40 File Offset: 0x0096FE40
		// (set) Token: 0x06026528 RID: 156968 RVA: 0x00971C79 File Offset: 0x0096FE79
		[Nullable(1)]
		public FKuroCurveFloat ProgressCurve
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._ProgressCurve) == null)
				{
					result = (this._ProgressCurve = new FKuroCurveFloat(base.NativePtr + (IntPtr)BP_CloudPrefab_C.__PropertyOffset_54, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)BP_CloudPrefab_C.__PropertyOffset_54, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170051B6 RID: 20918
		// (get) Token: 0x06026529 RID: 156969 RVA: 0x00971C9A File Offset: 0x0096FE9A
		// (set) Token: 0x0602652A RID: 156970 RVA: 0x00971CAA File Offset: 0x0096FEAA
		public unsafe bool bInstantHide
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudPrefab_C.__PropertyOffset_55) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudPrefab_C.__PropertyOffset_55) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602652B RID: 156971 RVA: 0x00971CBC File Offset: 0x0096FEBC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OverrideMountainMeshAndMaterial(UMaterialInstance MaterialInstance, UStaticMesh Mesh)
		{
			BP_CloudPrefab_C.__OverrideMountainMeshAndMaterial_FunctionParams* ptr = stackalloc BP_CloudPrefab_C.__OverrideMountainMeshAndMaterial_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(BP_CloudPrefab_C.__OverrideMountainMeshAndMaterial_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CloudPrefab_C.__OverrideMountainMeshAndMaterial_NativeFunctionPtr, (void*)ptr, 1);
			ptr->MaterialInstance = ((MaterialInstance != null) ? MaterialInstance.NativePtr : IntPtr.Zero);
			ptr->Mesh = ((Mesh != null) ? Mesh.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CloudPrefab_C.__OverrideMountainMeshAndMaterial_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602652C RID: 156972 RVA: 0x00971D28 File Offset: 0x0096FF28
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void CurveProgress(ref bool stop)
		{
			BP_CloudPrefab_C.__CurveProgress_FunctionParams* ptr = stackalloc BP_CloudPrefab_C.__CurveProgress_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(BP_CloudPrefab_C.__CurveProgress_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CloudPrefab_C.__CurveProgress_NativeFunctionPtr, (void*)ptr, 1);
			ptr->stop = stop;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CloudPrefab_C.__CurveProgress_NativeFunctionPtr, (void*)ptr);
			stop = ptr->stop;
		}

		// Token: 0x0602652D RID: 156973 RVA: 0x00971D78 File Offset: 0x0096FF78
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OverrideCloudTopMaterial(UMaterialInstance MaterialInstance)
		{
			BP_CloudPrefab_C.__OverrideCloudTopMaterial_FunctionParams* ptr = stackalloc BP_CloudPrefab_C.__OverrideCloudTopMaterial_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_CloudPrefab_C.__OverrideCloudTopMaterial_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CloudPrefab_C.__OverrideCloudTopMaterial_NativeFunctionPtr, (void*)ptr, 1);
			ptr->MaterialInstance = ((MaterialInstance != null) ? MaterialInstance.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CloudPrefab_C.__OverrideCloudTopMaterial_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602652E RID: 156974 RVA: 0x00971DD0 File Offset: 0x0096FFD0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OverrideBigShapeMaterial(UMaterialInstance MaterialInstance)
		{
			BP_CloudPrefab_C.__OverrideBigShapeMaterial_FunctionParams* ptr = stackalloc BP_CloudPrefab_C.__OverrideBigShapeMaterial_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_CloudPrefab_C.__OverrideBigShapeMaterial_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CloudPrefab_C.__OverrideBigShapeMaterial_NativeFunctionPtr, (void*)ptr, 1);
			ptr->MaterialInstance = ((MaterialInstance != null) ? MaterialInstance.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CloudPrefab_C.__OverrideBigShapeMaterial_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602652F RID: 156975 RVA: 0x00971E28 File Offset: 0x00970028
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void ShouldCloudMove(FVectorDouble InLocation, ref bool bMove, ref FVectorDouble NewLocation)
		{
			BP_CloudPrefab_C.__ShouldCloudMove_FunctionParams* ptr = stackalloc BP_CloudPrefab_C.__ShouldCloudMove_FunctionParams[(UIntPtr)231] + 15L / (long)sizeof(BP_CloudPrefab_C.__ShouldCloudMove_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CloudPrefab_C.__ShouldCloudMove_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InLocation = InLocation;
			ptr->bMove = bMove;
			ptr->NewLocation = NewLocation;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CloudPrefab_C.__ShouldCloudMove_NativeFunctionPtr, (void*)ptr);
			bMove = ptr->bMove;
			NewLocation = ptr->NewLocation;
		}

		// Token: 0x06026530 RID: 156976 RVA: 0x00971E9C File Offset: 0x0097009C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Single_POICloud_Parameters_Initial(UMaterialInstanceDynamic DMI, UStaticMeshComponent Mesh, FPOICloudParameters CloudStructParameter, int TransSortNumber)
		{
			BP_CloudPrefab_C.__Single_POICloud_Parameters_Initial_FunctionParams* ptr = stackalloc BP_CloudPrefab_C.__Single_POICloud_Parameters_Initial_FunctionParams[(UIntPtr)303] + 15L / (long)sizeof(BP_CloudPrefab_C.__Single_POICloud_Parameters_Initial_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CloudPrefab_C.__Single_POICloud_Parameters_Initial_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DMI = ((DMI != null) ? DMI.NativePtr : IntPtr.Zero);
			ptr->Mesh = ((Mesh != null) ? Mesh.NativePtr : IntPtr.Zero);
			if (CloudStructParameter != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPOICloudParameters.StaticStruct(), &ptr->CloudStructParameter, CloudStructParameter.NativePtr, 1, false);
			}
			ptr->TransSortNumber = TransSortNumber;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CloudPrefab_C.__Single_POICloud_Parameters_Initial_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06026531 RID: 156977 RVA: 0x00971F34 File Offset: 0x00970134
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Single_Building_Parameters_Initial(UMaterialInstanceDynamic DMI, UStaticMeshComponent Mesh, FAnomaliesParameters CloudStructParameter, int TransSortNumber)
		{
			BP_CloudPrefab_C.__Single_Building_Parameters_Initial_FunctionParams* ptr = stackalloc BP_CloudPrefab_C.__Single_Building_Parameters_Initial_FunctionParams[(UIntPtr)271] + 15L / (long)sizeof(BP_CloudPrefab_C.__Single_Building_Parameters_Initial_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CloudPrefab_C.__Single_Building_Parameters_Initial_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DMI = ((DMI != null) ? DMI.NativePtr : IntPtr.Zero);
			ptr->Mesh = ((Mesh != null) ? Mesh.NativePtr : IntPtr.Zero);
			if (CloudStructParameter != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FAnomaliesParameters.StaticStruct(), &ptr->CloudStructParameter, CloudStructParameter.NativePtr, 1, false);
			}
			ptr->TransSortNumber = TransSortNumber;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CloudPrefab_C.__Single_Building_Parameters_Initial_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06026532 RID: 156978 RVA: 0x00971FCC File Offset: 0x009701CC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdatePerFourFrame()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CloudPrefab_C.__UpdatePerFourFrame_NativeFunctionPtr, null);
		}

		// Token: 0x06026533 RID: 156979 RVA: 0x00971FE0 File Offset: 0x009701E0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Single_Cloud_Parameters_Initial(UMaterialInstanceDynamic DMI, UStaticMeshComponent Mesh, FCloudParameters CloudStructParameter, int TransSortNumber)
		{
			BP_CloudPrefab_C.__Single_Cloud_Parameters_Initial_FunctionParams* ptr = stackalloc BP_CloudPrefab_C.__Single_Cloud_Parameters_Initial_FunctionParams[(UIntPtr)431] + 15L / (long)sizeof(BP_CloudPrefab_C.__Single_Cloud_Parameters_Initial_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CloudPrefab_C.__Single_Cloud_Parameters_Initial_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DMI = ((DMI != null) ? DMI.NativePtr : IntPtr.Zero);
			ptr->Mesh = ((Mesh != null) ? Mesh.NativePtr : IntPtr.Zero);
			if (CloudStructParameter != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FCloudParameters.StaticStruct(), &ptr->CloudStructParameter, CloudStructParameter.NativePtr, 1, false);
			}
			ptr->TransSortNumber = TransSortNumber;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CloudPrefab_C.__Single_Cloud_Parameters_Initial_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(BP_CloudPrefab_C.__Single_Cloud_Parameters_Initial_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06026534 RID: 156980 RVA: 0x00972089 File Offset: 0x00970289
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Cloud_Initial()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CloudPrefab_C.__Cloud_Initial_NativeFunctionPtr, null);
		}

		// Token: 0x06026535 RID: 156981 RVA: 0x009720A0 File Offset: 0x009702A0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Timer(bool Forward, float DeltaTime, float Speed, ref float time, ref bool Stop)
		{
			BP_CloudPrefab_C.__Timer_FunctionParams* ptr = stackalloc BP_CloudPrefab_C.__Timer_FunctionParams[(UIntPtr)51] + 15L / (long)sizeof(BP_CloudPrefab_C.__Timer_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CloudPrefab_C.__Timer_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Forward = Forward;
			ptr->DeltaTime = DeltaTime;
			ptr->Speed = Speed;
			ptr->time = time;
			ptr->Stop = Stop;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CloudPrefab_C.__Timer_NativeFunctionPtr, (void*)ptr);
			time = ptr->time;
			Stop = ptr->Stop;
		}

		// Token: 0x06026536 RID: 156982 RVA: 0x00972118 File Offset: 0x00970318
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void AddCloudRotation()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CloudPrefab_C.__AddCloudRotation_NativeFunctionPtr, null);
		}

		// Token: 0x06026537 RID: 156983 RVA: 0x0097212C File Offset: 0x0097032C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Hidden(bool InstantHide)
		{
			BP_CloudPrefab_C.__Hidden_FunctionParams* ptr = stackalloc BP_CloudPrefab_C.__Hidden_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_CloudPrefab_C.__Hidden_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CloudPrefab_C.__Hidden_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InstantHide = InstantHide;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CloudPrefab_C.__Hidden_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06026538 RID: 156984 RVA: 0x00972174 File Offset: 0x00970374
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Active(bool bInstantHide)
		{
			BP_CloudPrefab_C.__Active_FunctionParams* ptr = stackalloc BP_CloudPrefab_C.__Active_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_CloudPrefab_C.__Active_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CloudPrefab_C.__Active_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bInstantHide = bInstantHide;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CloudPrefab_C.__Active_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06026539 RID: 156985 RVA: 0x009721BA File Offset: 0x009703BA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CloudPrefab_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0602653A RID: 156986 RVA: 0x009721CE File Offset: 0x009703CE
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CloudPrefab_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602653B RID: 156987 RVA: 0x009721E4 File Offset: 0x009703E4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_CloudPrefab_C.__EditorTick_FunctionParams* ptr = stackalloc BP_CloudPrefab_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CloudPrefab_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CloudPrefab_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CloudPrefab_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602653C RID: 156988 RVA: 0x0097222C File Offset: 0x0097042C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_CloudPrefab_C.__EditorTick_FunctionParams* ptr = stackalloc BP_CloudPrefab_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CloudPrefab_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CloudPrefab_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CloudPrefab_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602653D RID: 156989 RVA: 0x00972274 File Offset: 0x00970474
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_CloudPrefab_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_CloudPrefab_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CloudPrefab_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CloudPrefab_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CloudPrefab_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602653E RID: 156990 RVA: 0x009722BC File Offset: 0x009704BC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_CloudPrefab_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_CloudPrefab_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CloudPrefab_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CloudPrefab_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CloudPrefab_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602653F RID: 156991 RVA: 0x00972303 File Offset: 0x00970503
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CloudPrefab_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06026540 RID: 156992 RVA: 0x00972317 File Offset: 0x00970517
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CloudPrefab_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06026541 RID: 156993 RVA: 0x0097232C File Offset: 0x0097052C
		protected BP_CloudPrefab_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040132F3 RID: 78579
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/GI/NewCloud/BP/BP_CloudPrefab.BP_CloudPrefab_C";

		// Token: 0x040132F4 RID: 78580
		private static IntPtr _ClassPtr;

		// Token: 0x040132F5 RID: 78581
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040132F6 RID: 78582
		internal static int __PropertyOffset_1;

		// Token: 0x040132F7 RID: 78583
		internal static int __PropertyOffset_2;

		// Token: 0x040132F8 RID: 78584
		internal static int __PropertyOffset_3;

		// Token: 0x040132F9 RID: 78585
		internal static int __PropertyOffset_4;

		// Token: 0x040132FA RID: 78586
		internal static int __PropertyOffset_5;

		// Token: 0x040132FB RID: 78587
		internal static int __PropertyOffset_6;

		// Token: 0x040132FC RID: 78588
		internal static int __PropertyOffset_7;

		// Token: 0x040132FD RID: 78589
		internal static int __PropertyOffset_8;

		// Token: 0x040132FE RID: 78590
		internal static int __PropertyOffset_9;

		// Token: 0x040132FF RID: 78591
		internal static int __PropertyOffset_10;

		// Token: 0x04013300 RID: 78592
		internal static int __PropertyOffset_11;

		// Token: 0x04013301 RID: 78593
		internal static int __PropertyOffset_12;

		// Token: 0x04013302 RID: 78594
		internal static int __PropertyOffset_13;

		// Token: 0x04013303 RID: 78595
		internal static int __PropertyOffset_14;

		// Token: 0x04013304 RID: 78596
		internal static int __PropertyOffset_15;

		// Token: 0x04013305 RID: 78597
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstanceDynamic> _DMI;

		// Token: 0x04013306 RID: 78598
		internal static int __PropertyOffset_16;

		// Token: 0x04013307 RID: 78599
		internal static int __PropertyOffset_17;

		// Token: 0x04013308 RID: 78600
		internal static int __PropertyOffset_18;

		// Token: 0x04013309 RID: 78601
		internal static int __PropertyOffset_19;

		// Token: 0x0401330A RID: 78602
		internal static int __PropertyOffset_20;

		// Token: 0x0401330B RID: 78603
		internal static int __PropertyOffset_21;

		// Token: 0x0401330C RID: 78604
		internal static int __PropertyOffset_22;

		// Token: 0x0401330D RID: 78605
		internal static int __PropertyOffset_23;

		// Token: 0x0401330E RID: 78606
		internal static int __PropertyOffset_24;

		// Token: 0x0401330F RID: 78607
		internal static int __PropertyOffset_25;

		// Token: 0x04013310 RID: 78608
		internal static int __PropertyOffset_26;

		// Token: 0x04013311 RID: 78609
		internal static int __PropertyOffset_27;

		// Token: 0x04013312 RID: 78610
		internal static int __PropertyOffset_28;

		// Token: 0x04013313 RID: 78611
		internal static int __PropertyOffset_29;

		// Token: 0x04013314 RID: 78612
		internal static int __PropertyOffset_30;

		// Token: 0x04013315 RID: 78613
		internal static int __PropertyOffset_31;

		// Token: 0x04013316 RID: 78614
		internal static int __PropertyOffset_32;

		// Token: 0x04013317 RID: 78615
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UStaticMeshComponent> _MeshArray;

		// Token: 0x04013318 RID: 78616
		internal static int __PropertyOffset_33;

		// Token: 0x04013319 RID: 78617
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstanceDynamic> _DMIArray;

		// Token: 0x0401331A RID: 78618
		internal static int __PropertyOffset_34;

		// Token: 0x0401331B RID: 78619
		internal static int __PropertyOffset_35;

		// Token: 0x0401331C RID: 78620
		private TArray<int> _Trans;

		// Token: 0x0401331D RID: 78621
		internal static int __PropertyOffset_36;

		// Token: 0x0401331E RID: 78622
		internal static int __PropertyOffset_37;

		// Token: 0x0401331F RID: 78623
		internal static int __PropertyOffset_38;

		// Token: 0x04013320 RID: 78624
		internal static int __PropertyOffset_39;

		// Token: 0x04013321 RID: 78625
		internal static int __PropertyOffset_40;

		// Token: 0x04013322 RID: 78626
		internal static int __PropertyOffset_41;

		// Token: 0x04013323 RID: 78627
		internal static int __PropertyOffset_42;

		// Token: 0x04013324 RID: 78628
		internal static int __PropertyOffset_43;

		// Token: 0x04013325 RID: 78629
		internal static int __PropertyOffset_44;

		// Token: 0x04013326 RID: 78630
		internal static int __PropertyOffset_45;

		// Token: 0x04013327 RID: 78631
		internal static int __PropertyOffset_46;

		// Token: 0x04013328 RID: 78632
		internal static int __PropertyOffset_47;

		// Token: 0x04013329 RID: 78633
		internal static int __PropertyOffset_48;

		// Token: 0x0401332A RID: 78634
		internal static int __PropertyOffset_49;

		// Token: 0x0401332B RID: 78635
		internal static int __PropertyOffset_50;

		// Token: 0x0401332C RID: 78636
		internal static int __PropertyOffset_51;

		// Token: 0x0401332D RID: 78637
		internal static int __PropertyOffset_52;

		// Token: 0x0401332E RID: 78638
		internal static int __PropertyOffset_53;

		// Token: 0x0401332F RID: 78639
		internal static int __PropertyOffset_54;

		// Token: 0x04013330 RID: 78640
		private FKuroCurveFloat _ProgressCurve;

		// Token: 0x04013331 RID: 78641
		internal static int __PropertyOffset_55;

		// Token: 0x04013332 RID: 78642
		private static IntPtr __OverrideMountainMeshAndMaterial_NativeFunctionPtr;

		// Token: 0x04013333 RID: 78643
		private static IntPtr __CurveProgress_NativeFunctionPtr;

		// Token: 0x04013334 RID: 78644
		private static IntPtr __OverrideCloudTopMaterial_NativeFunctionPtr;

		// Token: 0x04013335 RID: 78645
		private static IntPtr __OverrideBigShapeMaterial_NativeFunctionPtr;

		// Token: 0x04013336 RID: 78646
		private static IntPtr __ShouldCloudMove_NativeFunctionPtr;

		// Token: 0x04013337 RID: 78647
		private static IntPtr __Single_POICloud_Parameters_Initial_NativeFunctionPtr;

		// Token: 0x04013338 RID: 78648
		private static IntPtr __Single_Building_Parameters_Initial_NativeFunctionPtr;

		// Token: 0x04013339 RID: 78649
		private static IntPtr __UpdatePerFourFrame_NativeFunctionPtr;

		// Token: 0x0401333A RID: 78650
		private static IntPtr __Single_Cloud_Parameters_Initial_NativeFunctionPtr;

		// Token: 0x0401333B RID: 78651
		private static IntPtr __Cloud_Initial_NativeFunctionPtr;

		// Token: 0x0401333C RID: 78652
		private static IntPtr __Timer_NativeFunctionPtr;

		// Token: 0x0401333D RID: 78653
		private static IntPtr __AddCloudRotation_NativeFunctionPtr;

		// Token: 0x0401333E RID: 78654
		private static IntPtr __Hidden_NativeFunctionPtr;

		// Token: 0x0401333F RID: 78655
		private static IntPtr __Active_NativeFunctionPtr;

		// Token: 0x04013340 RID: 78656
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04013341 RID: 78657
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x04013342 RID: 78658
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04013343 RID: 78659
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0200A0E9 RID: 41193
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __OverrideMountainMeshAndMaterial_FunctionParams
		{
			// Token: 0x04031C15 RID: 203797
			[FieldOffset(0)]
			public IntPtr MaterialInstance;

			// Token: 0x04031C16 RID: 203798
			[FieldOffset(8)]
			public IntPtr Mesh;
		}

		// Token: 0x0200A0EA RID: 41194
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __CurveProgress_FunctionParams
		{
			// Token: 0x04031C17 RID: 203799
			[FieldOffset(0)]
			public bool stop;
		}

		// Token: 0x0200A0EB RID: 41195
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __OverrideCloudTopMaterial_FunctionParams
		{
			// Token: 0x04031C18 RID: 203800
			[FieldOffset(0)]
			public IntPtr MaterialInstance;
		}

		// Token: 0x0200A0EC RID: 41196
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __OverrideBigShapeMaterial_FunctionParams
		{
			// Token: 0x04031C19 RID: 203801
			[FieldOffset(0)]
			public IntPtr MaterialInstance;
		}

		// Token: 0x0200A0ED RID: 41197
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 216)]
		protected ref struct __ShouldCloudMove_FunctionParams
		{
			// Token: 0x04031C1A RID: 203802
			[FieldOffset(0)]
			public FVectorDouble InLocation;

			// Token: 0x04031C1B RID: 203803
			[FieldOffset(24)]
			public bool bMove;

			// Token: 0x04031C1C RID: 203804
			[FieldOffset(32)]
			public FVectorDouble NewLocation;
		}

		// Token: 0x0200A0EE RID: 41198
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 288)]
		protected ref struct __Single_POICloud_Parameters_Initial_FunctionParams
		{
			// Token: 0x04031C1D RID: 203805
			[FieldOffset(0)]
			public IntPtr DMI;

			// Token: 0x04031C1E RID: 203806
			[FieldOffset(8)]
			public IntPtr Mesh;

			// Token: 0x04031C1F RID: 203807
			[FieldOffset(16)]
			public byte CloudStructParameter;

			// Token: 0x04031C20 RID: 203808
			[FieldOffset(80)]
			public int TransSortNumber;
		}

		// Token: 0x0200A0EF RID: 41199
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 256)]
		protected ref struct __Single_Building_Parameters_Initial_FunctionParams
		{
			// Token: 0x04031C21 RID: 203809
			[FieldOffset(0)]
			public IntPtr DMI;

			// Token: 0x04031C22 RID: 203810
			[FieldOffset(8)]
			public IntPtr Mesh;

			// Token: 0x04031C23 RID: 203811
			[FieldOffset(16)]
			public byte CloudStructParameter;

			// Token: 0x04031C24 RID: 203812
			[FieldOffset(72)]
			public int TransSortNumber;
		}

		// Token: 0x0200A0F0 RID: 41200
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 416)]
		protected ref struct __Single_Cloud_Parameters_Initial_FunctionParams
		{
			// Token: 0x04031C25 RID: 203813
			[FieldOffset(0)]
			public IntPtr DMI;

			// Token: 0x04031C26 RID: 203814
			[FieldOffset(8)]
			public IntPtr Mesh;

			// Token: 0x04031C27 RID: 203815
			[FieldOffset(16)]
			public byte CloudStructParameter;

			// Token: 0x04031C28 RID: 203816
			[FieldOffset(216)]
			public int TransSortNumber;
		}

		// Token: 0x0200A0F1 RID: 41201
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 36)]
		protected ref struct __Timer_FunctionParams
		{
			// Token: 0x04031C29 RID: 203817
			[FieldOffset(0)]
			public bool Forward;

			// Token: 0x04031C2A RID: 203818
			[FieldOffset(4)]
			public float DeltaTime;

			// Token: 0x04031C2B RID: 203819
			[FieldOffset(8)]
			public float Speed;

			// Token: 0x04031C2C RID: 203820
			[FieldOffset(12)]
			public float time;

			// Token: 0x04031C2D RID: 203821
			[FieldOffset(16)]
			public bool Stop;
		}

		// Token: 0x0200A0F2 RID: 41202
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __Hidden_FunctionParams
		{
			// Token: 0x04031C2E RID: 203822
			[FieldOffset(0)]
			public bool InstantHide;
		}

		// Token: 0x0200A0F3 RID: 41203
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __Active_FunctionParams
		{
			// Token: 0x04031C2F RID: 203823
			[FieldOffset(0)]
			public bool bInstantHide;
		}

		// Token: 0x0200A0F4 RID: 41204
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x04031C30 RID: 203824
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x0200A0F5 RID: 41205
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031C31 RID: 203825
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}

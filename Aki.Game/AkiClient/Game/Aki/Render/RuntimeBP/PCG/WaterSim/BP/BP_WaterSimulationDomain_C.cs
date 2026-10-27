using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.WaterSim.BP
{
	// Token: 0x02003BD4 RID: 15316
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/WaterSim/BP/BP_WaterSimulationDomain.BP_WaterSimulationDomain_C")]
	[UnrealStructLayout(1768, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1768)]
	public class BP_WaterSimulationDomain_C : AKuroBPActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022606 RID: 140806 RVA: 0x00907439 File Offset: 0x00905639
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_WaterSimulationDomain_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/WaterSim/BP/BP_WaterSimulationDomain.BP_WaterSimulationDomain_C");
			}
			return BP_WaterSimulationDomain_C._ClassPtr;
		}

		// Token: 0x06022607 RID: 140807 RVA: 0x00907460 File Offset: 0x00905660
		public BP_WaterSimulationDomain_C() : this(BuiltinUtils.AllocNativeUObject(BP_WaterSimulationDomain_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022608 RID: 140808 RVA: 0x00907488 File Offset: 0x00905688
		[NullableContext(1)]
		public BP_WaterSimulationDomain_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_WaterSimulationDomain_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003B34 RID: 15156
		// (get) Token: 0x06022609 RID: 140809 RVA: 0x009074BB File Offset: 0x009056BB
		// (set) Token: 0x0602260A RID: 140810 RVA: 0x009074CF File Offset: 0x009056CF
		public unsafe UStaticMeshComponent WaterSource
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulationDomain_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulationDomain_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17003B35 RID: 15157
		// (get) Token: 0x0602260B RID: 140811 RVA: 0x009074E4 File Offset: 0x009056E4
		// (set) Token: 0x0602260C RID: 140812 RVA: 0x009074F8 File Offset: 0x009056F8
		public unsafe UStaticMeshComponent SM_Plane512x512
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulationDomain_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulationDomain_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17003B36 RID: 15158
		// (get) Token: 0x0602260D RID: 140813 RVA: 0x0090750D File Offset: 0x0090570D
		// (set) Token: 0x0602260E RID: 140814 RVA: 0x00907521 File Offset: 0x00905721
		public unsafe UBoxComponent Sim_Volume
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulationDomain_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulationDomain_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17003B37 RID: 15159
		// (get) Token: 0x0602260F RID: 140815 RVA: 0x00907536 File Offset: 0x00905736
		// (set) Token: 0x06022610 RID: 140816 RVA: 0x0090754A File Offset: 0x0090574A
		public unsafe USceneCaptureComponent2D SceneCaptureComponent2D
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneCaptureComponent2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulationDomain_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulationDomain_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17003B38 RID: 15160
		// (get) Token: 0x06022611 RID: 140817 RVA: 0x0090755F File Offset: 0x0090575F
		// (set) Token: 0x06022612 RID: 140818 RVA: 0x00907573 File Offset: 0x00905773
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulationDomain_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulationDomain_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17003B39 RID: 15161
		// (get) Token: 0x06022613 RID: 140819 RVA: 0x00907588 File Offset: 0x00905788
		// (set) Token: 0x06022614 RID: 140820 RVA: 0x00907598 File Offset: 0x00905798
		public unsafe bool Sim
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulationDomain_C.__PropertyOffset_6) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulationDomain_C.__PropertyOffset_6) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003B3A RID: 15162
		// (get) Token: 0x06022615 RID: 140821 RVA: 0x009075A9 File Offset: 0x009057A9
		// (set) Token: 0x06022616 RID: 140822 RVA: 0x009075B9 File Offset: 0x009057B9
		public unsafe int SimSize_M_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulationDomain_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulationDomain_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17003B3B RID: 15163
		// (get) Token: 0x06022617 RID: 140823 RVA: 0x009075CA File Offset: 0x009057CA
		// (set) Token: 0x06022618 RID: 140824 RVA: 0x009075DE File Offset: 0x009057DE
		public unsafe UMaterial M_Height
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulationDomain_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulationDomain_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x17003B3C RID: 15164
		// (get) Token: 0x06022619 RID: 140825 RVA: 0x009075F3 File Offset: 0x009057F3
		// (set) Token: 0x0602261A RID: 140826 RVA: 0x00907607 File Offset: 0x00905807
		public unsafe UMaterial M_Velocity
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulationDomain_C.__PropertyOffset_9);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulationDomain_C.__PropertyOffset_9, value);
			}
		}

		// Token: 0x17003B3D RID: 15165
		// (get) Token: 0x0602261B RID: 140827 RVA: 0x0090761C File Offset: 0x0090581C
		// (set) Token: 0x0602261C RID: 140828 RVA: 0x00907630 File Offset: 0x00905830
		public unsafe UMaterial M_Blur
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulationDomain_C.__PropertyOffset_10);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulationDomain_C.__PropertyOffset_10, value);
			}
		}

		// Token: 0x17003B3E RID: 15166
		// (get) Token: 0x0602261D RID: 140829 RVA: 0x00907645 File Offset: 0x00905845
		// (set) Token: 0x0602261E RID: 140830 RVA: 0x00907659 File Offset: 0x00905859
		public unsafe UMaterial M_PreView
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulationDomain_C.__PropertyOffset_11);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulationDomain_C.__PropertyOffset_11, value);
			}
		}

		// Token: 0x17003B3F RID: 15167
		// (get) Token: 0x0602261F RID: 140831 RVA: 0x0090766E File Offset: 0x0090586E
		// (set) Token: 0x06022620 RID: 140832 RVA: 0x00907682 File Offset: 0x00905882
		public unsafe UMaterial M_Water_Clear
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulationDomain_C.__PropertyOffset_12);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulationDomain_C.__PropertyOffset_12, value);
			}
		}

		// Token: 0x17003B40 RID: 15168
		// (get) Token: 0x06022621 RID: 140833 RVA: 0x00907697 File Offset: 0x00905897
		// (set) Token: 0x06022622 RID: 140834 RVA: 0x009076AB File Offset: 0x009058AB
		public unsafe UMaterialInstanceDynamic MI_Velocity
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulationDomain_C.__PropertyOffset_13);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulationDomain_C.__PropertyOffset_13, value);
			}
		}

		// Token: 0x17003B41 RID: 15169
		// (get) Token: 0x06022623 RID: 140835 RVA: 0x009076C0 File Offset: 0x009058C0
		// (set) Token: 0x06022624 RID: 140836 RVA: 0x009076D4 File Offset: 0x009058D4
		public unsafe UMaterialInstanceDynamic MI_Height
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulationDomain_C.__PropertyOffset_14);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulationDomain_C.__PropertyOffset_14, value);
			}
		}

		// Token: 0x17003B42 RID: 15170
		// (get) Token: 0x06022625 RID: 140837 RVA: 0x009076E9 File Offset: 0x009058E9
		// (set) Token: 0x06022626 RID: 140838 RVA: 0x009076FD File Offset: 0x009058FD
		public unsafe UMaterialInstanceDynamic MI_Blur
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulationDomain_C.__PropertyOffset_15);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulationDomain_C.__PropertyOffset_15, value);
			}
		}

		// Token: 0x17003B43 RID: 15171
		// (get) Token: 0x06022627 RID: 140839 RVA: 0x00907712 File Offset: 0x00905912
		// (set) Token: 0x06022628 RID: 140840 RVA: 0x00907726 File Offset: 0x00905926
		public unsafe UMaterialInstanceDynamic MI_PreView
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulationDomain_C.__PropertyOffset_16);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulationDomain_C.__PropertyOffset_16, value);
			}
		}

		// Token: 0x17003B44 RID: 15172
		// (get) Token: 0x06022629 RID: 140841 RVA: 0x0090773B File Offset: 0x0090593B
		// (set) Token: 0x0602262A RID: 140842 RVA: 0x0090774F File Offset: 0x0090594F
		public unsafe UTextureRenderTarget2D RT_HeightMap
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulationDomain_C.__PropertyOffset_17);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulationDomain_C.__PropertyOffset_17, value);
			}
		}

		// Token: 0x17003B45 RID: 15173
		// (get) Token: 0x0602262B RID: 140843 RVA: 0x00907764 File Offset: 0x00905964
		// (set) Token: 0x0602262C RID: 140844 RVA: 0x00907778 File Offset: 0x00905978
		public unsafe UTextureRenderTarget2D RT_Water_VelocityHeightFoam
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulationDomain_C.__PropertyOffset_18);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulationDomain_C.__PropertyOffset_18, value);
			}
		}

		// Token: 0x17003B46 RID: 15174
		// (get) Token: 0x0602262D RID: 140845 RVA: 0x0090778D File Offset: 0x0090598D
		// (set) Token: 0x0602262E RID: 140846 RVA: 0x009077A1 File Offset: 0x009059A1
		public unsafe UTextureRenderTarget2D RT_Water_VelocityHeightFoam_Temp
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulationDomain_C.__PropertyOffset_19);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulationDomain_C.__PropertyOffset_19, value);
			}
		}

		// Token: 0x17003B47 RID: 15175
		// (get) Token: 0x0602262F RID: 140847 RVA: 0x009077B6 File Offset: 0x009059B6
		// (set) Token: 0x06022630 RID: 140848 RVA: 0x009077CA File Offset: 0x009059CA
		public unsafe UTextureRenderTarget2D RT_Water_VelocityHeightFoam_Blur
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulationDomain_C.__PropertyOffset_20);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulationDomain_C.__PropertyOffset_20, value);
			}
		}

		// Token: 0x17003B48 RID: 15176
		// (get) Token: 0x06022631 RID: 140849 RVA: 0x009077DF File Offset: 0x009059DF
		// (set) Token: 0x06022632 RID: 140850 RVA: 0x009077F3 File Offset: 0x009059F3
		public unsafe AStaticMeshActor RenderActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AStaticMeshActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulationDomain_C.__PropertyOffset_21);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulationDomain_C.__PropertyOffset_21, value);
			}
		}

		// Token: 0x17003B49 RID: 15177
		// (get) Token: 0x06022633 RID: 140851 RVA: 0x00907808 File Offset: 0x00905A08
		// (set) Token: 0x06022634 RID: 140852 RVA: 0x0090781C File Offset: 0x00905A1C
		public unsafe UMaterialInterface M_Water_Render
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulationDomain_C.__PropertyOffset_22);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulationDomain_C.__PropertyOffset_22, value);
			}
		}

		// Token: 0x17003B4A RID: 15178
		// (get) Token: 0x06022635 RID: 140853 RVA: 0x00907831 File Offset: 0x00905A31
		// (set) Token: 0x06022636 RID: 140854 RVA: 0x00907845 File Offset: 0x00905A45
		public unsafe UMaterialInstanceDynamic MI_Water_Render
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulationDomain_C.__PropertyOffset_23);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulationDomain_C.__PropertyOffset_23, value);
			}
		}

		// Token: 0x17003B4B RID: 15179
		// (get) Token: 0x06022637 RID: 140855 RVA: 0x0090785A File Offset: 0x00905A5A
		// (set) Token: 0x06022638 RID: 140856 RVA: 0x0090786A File Offset: 0x00905A6A
		public unsafe float Timer
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulationDomain_C.__PropertyOffset_24);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulationDomain_C.__PropertyOffset_24) = value;
			}
		}

		// Token: 0x17003B4C RID: 15180
		// (get) Token: 0x06022639 RID: 140857 RVA: 0x0090787C File Offset: 0x00905A7C
		// (set) Token: 0x0602263A RID: 140858 RVA: 0x009078B5 File Offset: 0x00905AB5
		[Nullable(1)]
		public TArray<UMaterialInstanceDynamic> BasicInstances
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInstanceDynamic> result;
				if ((result = this._BasicInstances) == null)
				{
					result = (this._BasicInstances = new TArray<UMaterialInstanceDynamic>(base.NativePtr + (IntPtr)BP_WaterSimulationDomain_C.__PropertyOffset_25, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.BasicInstances.CopyAssign(value);
			}
		}

		// Token: 0x17003B4D RID: 15181
		// (get) Token: 0x0602263B RID: 140859 RVA: 0x009078C3 File Offset: 0x00905AC3
		// (set) Token: 0x0602263C RID: 140860 RVA: 0x009078D3 File Offset: 0x00905AD3
		public unsafe float SimulationDeltaTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulationDomain_C.__PropertyOffset_26);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulationDomain_C.__PropertyOffset_26) = value;
			}
		}

		// Token: 0x17003B4E RID: 15182
		// (get) Token: 0x0602263D RID: 140861 RVA: 0x009078E4 File Offset: 0x00905AE4
		// (set) Token: 0x0602263E RID: 140862 RVA: 0x009078F4 File Offset: 0x00905AF4
		public unsafe float CaptureOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulationDomain_C.__PropertyOffset_27);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulationDomain_C.__PropertyOffset_27) = value;
			}
		}

		// Token: 0x17003B4F RID: 15183
		// (get) Token: 0x0602263F RID: 140863 RVA: 0x00907905 File Offset: 0x00905B05
		// (set) Token: 0x06022640 RID: 140864 RVA: 0x00907919 File Offset: 0x00905B19
		public unsafe FLinearColor WorldToSimulationUV
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulationDomain_C.__PropertyOffset_28);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulationDomain_C.__PropertyOffset_28) = value;
			}
		}

		// Token: 0x17003B50 RID: 15184
		// (get) Token: 0x06022641 RID: 140865 RVA: 0x0090792E File Offset: 0x00905B2E
		// (set) Token: 0x06022642 RID: 140866 RVA: 0x0090793E File Offset: 0x00905B3E
		public unsafe float FoamFadeSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulationDomain_C.__PropertyOffset_29);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulationDomain_C.__PropertyOffset_29) = value;
			}
		}

		// Token: 0x17003B51 RID: 15185
		// (get) Token: 0x06022643 RID: 140867 RVA: 0x0090794F File Offset: 0x00905B4F
		// (set) Token: 0x06022644 RID: 140868 RVA: 0x0090795F File Offset: 0x00905B5F
		public unsafe float FoamShallowGenerate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulationDomain_C.__PropertyOffset_30);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulationDomain_C.__PropertyOffset_30) = value;
			}
		}

		// Token: 0x17003B52 RID: 15186
		// (get) Token: 0x06022645 RID: 140869 RVA: 0x00907970 File Offset: 0x00905B70
		// (set) Token: 0x06022646 RID: 140870 RVA: 0x00907980 File Offset: 0x00905B80
		public unsafe float FoamShallowDepth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulationDomain_C.__PropertyOffset_31);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulationDomain_C.__PropertyOffset_31) = value;
			}
		}

		// Token: 0x17003B53 RID: 15187
		// (get) Token: 0x06022647 RID: 140871 RVA: 0x00907991 File Offset: 0x00905B91
		// (set) Token: 0x06022648 RID: 140872 RVA: 0x009079A1 File Offset: 0x00905BA1
		public unsafe float FoamWaveGenerate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulationDomain_C.__PropertyOffset_32);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulationDomain_C.__PropertyOffset_32) = value;
			}
		}

		// Token: 0x17003B54 RID: 15188
		// (get) Token: 0x06022649 RID: 140873 RVA: 0x009079B2 File Offset: 0x00905BB2
		// (set) Token: 0x0602264A RID: 140874 RVA: 0x009079C2 File Offset: 0x00905BC2
		public unsafe float EvaporationHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulationDomain_C.__PropertyOffset_33);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulationDomain_C.__PropertyOffset_33) = value;
			}
		}

		// Token: 0x17003B55 RID: 15189
		// (get) Token: 0x0602264B RID: 140875 RVA: 0x009079D3 File Offset: 0x00905BD3
		// (set) Token: 0x0602264C RID: 140876 RVA: 0x009079E3 File Offset: 0x00905BE3
		public unsafe float FluidTransportLimit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulationDomain_C.__PropertyOffset_34);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulationDomain_C.__PropertyOffset_34) = value;
			}
		}

		// Token: 0x17003B56 RID: 15190
		// (get) Token: 0x0602264D RID: 140877 RVA: 0x009079F4 File Offset: 0x00905BF4
		// (set) Token: 0x0602264E RID: 140878 RVA: 0x00907A04 File Offset: 0x00905C04
		public unsafe float Gravity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulationDomain_C.__PropertyOffset_35);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulationDomain_C.__PropertyOffset_35) = value;
			}
		}

		// Token: 0x17003B57 RID: 15191
		// (get) Token: 0x0602264F RID: 140879 RVA: 0x00907A15 File Offset: 0x00905C15
		// (set) Token: 0x06022650 RID: 140880 RVA: 0x00907A25 File Offset: 0x00905C25
		public unsafe float VelocityLimit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulationDomain_C.__PropertyOffset_36);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulationDomain_C.__PropertyOffset_36) = value;
			}
		}

		// Token: 0x17003B58 RID: 15192
		// (get) Token: 0x06022651 RID: 140881 RVA: 0x00907A36 File Offset: 0x00905C36
		// (set) Token: 0x06022652 RID: 140882 RVA: 0x00907A46 File Offset: 0x00905C46
		public unsafe float AreaWorldPixelSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulationDomain_C.__PropertyOffset_37);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulationDomain_C.__PropertyOffset_37) = value;
			}
		}

		// Token: 0x17003B59 RID: 15193
		// (get) Token: 0x06022653 RID: 140883 RVA: 0x00907A57 File Offset: 0x00905C57
		// (set) Token: 0x06022654 RID: 140884 RVA: 0x00907A67 File Offset: 0x00905C67
		public unsafe float SlopeScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulationDomain_C.__PropertyOffset_38);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulationDomain_C.__PropertyOffset_38) = value;
			}
		}

		// Token: 0x17003B5A RID: 15194
		// (get) Token: 0x06022655 RID: 140885 RVA: 0x00907A78 File Offset: 0x00905C78
		// (set) Token: 0x06022656 RID: 140886 RVA: 0x00907A88 File Offset: 0x00905C88
		public unsafe float AreaWorldHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulationDomain_C.__PropertyOffset_39);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulationDomain_C.__PropertyOffset_39) = value;
			}
		}

		// Token: 0x17003B5B RID: 15195
		// (get) Token: 0x06022657 RID: 140887 RVA: 0x00907A99 File Offset: 0x00905C99
		// (set) Token: 0x06022658 RID: 140888 RVA: 0x00907AA9 File Offset: 0x00905CA9
		public unsafe float Friction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulationDomain_C.__PropertyOffset_40);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulationDomain_C.__PropertyOffset_40) = value;
			}
		}

		// Token: 0x17003B5C RID: 15196
		// (get) Token: 0x06022659 RID: 140889 RVA: 0x00907ABA File Offset: 0x00905CBA
		// (set) Token: 0x0602265A RID: 140890 RVA: 0x00907ACA File Offset: 0x00905CCA
		public unsafe float Damping
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulationDomain_C.__PropertyOffset_41);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulationDomain_C.__PropertyOffset_41) = value;
			}
		}

		// Token: 0x17003B5D RID: 15197
		// (get) Token: 0x0602265B RID: 140891 RVA: 0x00907ADB File Offset: 0x00905CDB
		// (set) Token: 0x0602265C RID: 140892 RVA: 0x00907AEB File Offset: 0x00905CEB
		public unsafe float AccelerationLimit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulationDomain_C.__PropertyOffset_42);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulationDomain_C.__PropertyOffset_42) = value;
			}
		}

		// Token: 0x17003B5E RID: 15198
		// (get) Token: 0x0602265D RID: 140893 RVA: 0x00907AFC File Offset: 0x00905CFC
		// (set) Token: 0x0602265E RID: 140894 RVA: 0x00907B0C File Offset: 0x00905D0C
		public unsafe float OvershootingBlend
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulationDomain_C.__PropertyOffset_43);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulationDomain_C.__PropertyOffset_43) = value;
			}
		}

		// Token: 0x17003B5F RID: 15199
		// (get) Token: 0x0602265F RID: 140895 RVA: 0x00907B1D File Offset: 0x00905D1D
		// (set) Token: 0x06022660 RID: 140896 RVA: 0x00907B31 File Offset: 0x00905D31
		public unsafe UMaterialInstanceDynamic IntegrateVelocityInstance
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulationDomain_C.__PropertyOffset_44);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulationDomain_C.__PropertyOffset_44, value);
			}
		}

		// Token: 0x17003B60 RID: 15200
		// (get) Token: 0x06022661 RID: 140897 RVA: 0x00907B46 File Offset: 0x00905D46
		// (set) Token: 0x06022662 RID: 140898 RVA: 0x00907B5A File Offset: 0x00905D5A
		public unsafe UMaterialInstanceDynamic IntegrateHeightInstance
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulationDomain_C.__PropertyOffset_45);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulationDomain_C.__PropertyOffset_45, value);
			}
		}

		// Token: 0x17003B61 RID: 15201
		// (get) Token: 0x06022663 RID: 140899 RVA: 0x00907B6F File Offset: 0x00905D6F
		// (set) Token: 0x06022664 RID: 140900 RVA: 0x00907B7F File Offset: 0x00905D7F
		public unsafe float OvershootingEdge
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulationDomain_C.__PropertyOffset_46);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulationDomain_C.__PropertyOffset_46) = value;
			}
		}

		// Token: 0x17003B62 RID: 15202
		// (get) Token: 0x06022665 RID: 140901 RVA: 0x00907B90 File Offset: 0x00905D90
		// (set) Token: 0x06022666 RID: 140902 RVA: 0x00907BA4 File Offset: 0x00905DA4
		public unsafe UCanvas Canvas
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCanvas>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulationDomain_C.__PropertyOffset_47);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulationDomain_C.__PropertyOffset_47, value);
			}
		}

		// Token: 0x06022667 RID: 140903 RVA: 0x00907BBC File Offset: 0x00905DBC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void UpdateTime(float RealDeltaTime)
		{
			BP_WaterSimulationDomain_C.__UpdateTime_FunctionParams* ptr = stackalloc BP_WaterSimulationDomain_C.__UpdateTime_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_WaterSimulationDomain_C.__UpdateTime_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WaterSimulationDomain_C.__UpdateTime_NativeFunctionPtr, (void*)ptr, 1);
			ptr->RealDeltaTime = RealDeltaTime;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterSimulationDomain_C.__UpdateTime_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022668 RID: 140904 RVA: 0x00907C02 File Offset: 0x00905E02
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void InitializeParameters()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterSimulationDomain_C.__InitializeParameters_NativeFunctionPtr, null);
		}

		// Token: 0x06022669 RID: 140905 RVA: 0x00907C16 File Offset: 0x00905E16
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void StopSim()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterSimulationDomain_C.__StopSim_NativeFunctionPtr, null);
		}

		// Token: 0x0602266A RID: 140906 RVA: 0x00907C2A File Offset: 0x00905E2A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void StartSim()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterSimulationDomain_C.__StartSim_NativeFunctionPtr, null);
		}

		// Token: 0x0602266B RID: 140907 RVA: 0x00907C3E File Offset: 0x00905E3E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void ClearWater()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterSimulationDomain_C.__ClearWater_NativeFunctionPtr, null);
		}

		// Token: 0x0602266C RID: 140908 RVA: 0x00907C54 File Offset: 0x00905E54
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetMaterialParameter(UMaterialInterface Material, UTexture VelocityHeightFoam, ref UMaterialInstanceDynamic MaterialInstance)
		{
			BP_WaterSimulationDomain_C.__SetMaterialParameter_FunctionParams* ptr = stackalloc BP_WaterSimulationDomain_C.__SetMaterialParameter_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(BP_WaterSimulationDomain_C.__SetMaterialParameter_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WaterSimulationDomain_C.__SetMaterialParameter_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Material = ((Material != null) ? Material.NativePtr : IntPtr.Zero);
			ptr->VelocityHeightFoam = ((VelocityHeightFoam != null) ? VelocityHeightFoam.NativePtr : IntPtr.Zero);
			ref BP_WaterSimulationDomain_C.__SetMaterialParameter_FunctionParams ptr2 = ref *ptr;
			UMaterialInstanceDynamic umaterialInstanceDynamic = MaterialInstance;
			ptr2.MaterialInstance = ((umaterialInstanceDynamic != null) ? umaterialInstanceDynamic.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterSimulationDomain_C.__SetMaterialParameter_NativeFunctionPtr, (void*)ptr);
			MaterialInstance = BuiltinUtils.GetOrCreateUObjectByNativePointer<UMaterialInstanceDynamic>(ptr->MaterialInstance);
		}

		// Token: 0x0602266D RID: 140909 RVA: 0x00907CE4 File Offset: 0x00905EE4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterSimulationDomain_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0602266E RID: 140910 RVA: 0x00907CF8 File Offset: 0x00905EF8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_WaterSimulationDomain_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602266F RID: 140911 RVA: 0x00907D0D File Offset: 0x00905F0D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void EditorTick()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterSimulationDomain_C.__EditorTick_NativeFunctionPtr, null);
		}

		// Token: 0x06022670 RID: 140912 RVA: 0x00907D24 File Offset: 0x00905F24
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_WaterSimulationDomain_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_WaterSimulationDomain_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_WaterSimulationDomain_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WaterSimulationDomain_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterSimulationDomain_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022671 RID: 140913 RVA: 0x00907D6C File Offset: 0x00905F6C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_WaterSimulationDomain_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_WaterSimulationDomain_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_WaterSimulationDomain_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WaterSimulationDomain_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_WaterSimulationDomain_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06022672 RID: 140914 RVA: 0x00907DB3 File Offset: 0x00905FB3
		protected BP_WaterSimulationDomain_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010DE7 RID: 69095
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/WaterSim/BP/BP_WaterSimulationDomain.BP_WaterSimulationDomain_C";

		// Token: 0x04010DE8 RID: 69096
		private static IntPtr _ClassPtr;

		// Token: 0x04010DE9 RID: 69097
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010DEA RID: 69098
		internal static int __PropertyOffset_1;

		// Token: 0x04010DEB RID: 69099
		internal static int __PropertyOffset_2;

		// Token: 0x04010DEC RID: 69100
		internal static int __PropertyOffset_3;

		// Token: 0x04010DED RID: 69101
		internal static int __PropertyOffset_4;

		// Token: 0x04010DEE RID: 69102
		internal static int __PropertyOffset_5;

		// Token: 0x04010DEF RID: 69103
		internal static int __PropertyOffset_6;

		// Token: 0x04010DF0 RID: 69104
		internal static int __PropertyOffset_7;

		// Token: 0x04010DF1 RID: 69105
		internal static int __PropertyOffset_8;

		// Token: 0x04010DF2 RID: 69106
		internal static int __PropertyOffset_9;

		// Token: 0x04010DF3 RID: 69107
		internal static int __PropertyOffset_10;

		// Token: 0x04010DF4 RID: 69108
		internal static int __PropertyOffset_11;

		// Token: 0x04010DF5 RID: 69109
		internal static int __PropertyOffset_12;

		// Token: 0x04010DF6 RID: 69110
		internal static int __PropertyOffset_13;

		// Token: 0x04010DF7 RID: 69111
		internal static int __PropertyOffset_14;

		// Token: 0x04010DF8 RID: 69112
		internal static int __PropertyOffset_15;

		// Token: 0x04010DF9 RID: 69113
		internal static int __PropertyOffset_16;

		// Token: 0x04010DFA RID: 69114
		internal static int __PropertyOffset_17;

		// Token: 0x04010DFB RID: 69115
		internal static int __PropertyOffset_18;

		// Token: 0x04010DFC RID: 69116
		internal static int __PropertyOffset_19;

		// Token: 0x04010DFD RID: 69117
		internal static int __PropertyOffset_20;

		// Token: 0x04010DFE RID: 69118
		internal static int __PropertyOffset_21;

		// Token: 0x04010DFF RID: 69119
		internal static int __PropertyOffset_22;

		// Token: 0x04010E00 RID: 69120
		internal static int __PropertyOffset_23;

		// Token: 0x04010E01 RID: 69121
		internal static int __PropertyOffset_24;

		// Token: 0x04010E02 RID: 69122
		internal static int __PropertyOffset_25;

		// Token: 0x04010E03 RID: 69123
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstanceDynamic> _BasicInstances;

		// Token: 0x04010E04 RID: 69124
		internal static int __PropertyOffset_26;

		// Token: 0x04010E05 RID: 69125
		internal static int __PropertyOffset_27;

		// Token: 0x04010E06 RID: 69126
		internal static int __PropertyOffset_28;

		// Token: 0x04010E07 RID: 69127
		internal static int __PropertyOffset_29;

		// Token: 0x04010E08 RID: 69128
		internal static int __PropertyOffset_30;

		// Token: 0x04010E09 RID: 69129
		internal static int __PropertyOffset_31;

		// Token: 0x04010E0A RID: 69130
		internal static int __PropertyOffset_32;

		// Token: 0x04010E0B RID: 69131
		internal static int __PropertyOffset_33;

		// Token: 0x04010E0C RID: 69132
		internal static int __PropertyOffset_34;

		// Token: 0x04010E0D RID: 69133
		internal static int __PropertyOffset_35;

		// Token: 0x04010E0E RID: 69134
		internal static int __PropertyOffset_36;

		// Token: 0x04010E0F RID: 69135
		internal static int __PropertyOffset_37;

		// Token: 0x04010E10 RID: 69136
		internal static int __PropertyOffset_38;

		// Token: 0x04010E11 RID: 69137
		internal static int __PropertyOffset_39;

		// Token: 0x04010E12 RID: 69138
		internal static int __PropertyOffset_40;

		// Token: 0x04010E13 RID: 69139
		internal static int __PropertyOffset_41;

		// Token: 0x04010E14 RID: 69140
		internal static int __PropertyOffset_42;

		// Token: 0x04010E15 RID: 69141
		internal static int __PropertyOffset_43;

		// Token: 0x04010E16 RID: 69142
		internal static int __PropertyOffset_44;

		// Token: 0x04010E17 RID: 69143
		internal static int __PropertyOffset_45;

		// Token: 0x04010E18 RID: 69144
		internal static int __PropertyOffset_46;

		// Token: 0x04010E19 RID: 69145
		internal static int __PropertyOffset_47;

		// Token: 0x04010E1A RID: 69146
		private static IntPtr __UpdateTime_NativeFunctionPtr;

		// Token: 0x04010E1B RID: 69147
		private static IntPtr __InitializeParameters_NativeFunctionPtr;

		// Token: 0x04010E1C RID: 69148
		private static IntPtr __StopSim_NativeFunctionPtr;

		// Token: 0x04010E1D RID: 69149
		private static IntPtr __StartSim_NativeFunctionPtr;

		// Token: 0x04010E1E RID: 69150
		private static IntPtr __ClearWater_NativeFunctionPtr;

		// Token: 0x04010E1F RID: 69151
		private static IntPtr __SetMaterialParameter_NativeFunctionPtr;

		// Token: 0x04010E20 RID: 69152
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04010E21 RID: 69153
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x04010E22 RID: 69154
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x02009D71 RID: 40305
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __UpdateTime_FunctionParams
		{
			// Token: 0x040314EF RID: 201967
			[FieldOffset(0)]
			public float RealDeltaTime;
		}

		// Token: 0x02009D72 RID: 40306
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 88)]
		protected ref struct __SetMaterialParameter_FunctionParams
		{
			// Token: 0x040314F0 RID: 201968
			[FieldOffset(0)]
			public IntPtr Material;

			// Token: 0x040314F1 RID: 201969
			[FieldOffset(8)]
			public IntPtr VelocityHeightFoam;

			// Token: 0x040314F2 RID: 201970
			[FieldOffset(16)]
			public IntPtr MaterialInstance;
		}

		// Token: 0x02009D73 RID: 40307
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040314F3 RID: 201971
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}

using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Light
{
	// Token: 0x02003B28 RID: 15144
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Light/BP_VolumetricLightTri.BP_VolumetricLightTri_C")]
	[UnrealStructLayout(1152, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1148)]
	public class BP_VolumetricLightTri_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060215C0 RID: 136640 RVA: 0x008EAC20 File Offset: 0x008E8E20
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_VolumetricLightTri_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_VolumetricLightTri.BP_VolumetricLightTri_C");
			}
			return BP_VolumetricLightTri_C._ClassPtr;
		}

		// Token: 0x060215C1 RID: 136641 RVA: 0x008EAC44 File Offset: 0x008E8E44
		public BP_VolumetricLightTri_C() : this(BuiltinUtils.AllocNativeUObject(BP_VolumetricLightTri_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060215C2 RID: 136642 RVA: 0x008EAC6C File Offset: 0x008E8E6C
		[NullableContext(1)]
		public BP_VolumetricLightTri_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_VolumetricLightTri_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003609 RID: 13833
		// (get) Token: 0x060215C3 RID: 136643 RVA: 0x008EAC9F File Offset: 0x008E8E9F
		// (set) Token: 0x060215C4 RID: 136644 RVA: 0x008EACB3 File Offset: 0x008E8EB3
		public unsafe UBillboardComponent Billboard
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBillboardComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricLightTri_C.__PropertyOffset_0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricLightTri_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x1700360A RID: 13834
		// (get) Token: 0x060215C5 RID: 136645 RVA: 0x008EACC8 File Offset: 0x008E8EC8
		// (set) Token: 0x060215C6 RID: 136646 RVA: 0x008EACDC File Offset: 0x008E8EDC
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricLightTri_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricLightTri_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x1700360B RID: 13835
		// (get) Token: 0x060215C7 RID: 136647 RVA: 0x008EACF1 File Offset: 0x008E8EF1
		// (set) Token: 0x060215C8 RID: 136648 RVA: 0x008EAD05 File Offset: 0x008E8F05
		public unsafe UStaticMesh StaticMeshTri
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricLightTri_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricLightTri_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x1700360C RID: 13836
		// (get) Token: 0x060215C9 RID: 136649 RVA: 0x008EAD1A File Offset: 0x008E8F1A
		// (set) Token: 0x060215CA RID: 136650 RVA: 0x008EAD2A File Offset: 0x008E8F2A
		public unsafe bool IsReverseCulling
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricLightTri_C.__PropertyOffset_3) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricLightTri_C.__PropertyOffset_3) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700360D RID: 13837
		// (get) Token: 0x060215CB RID: 136651 RVA: 0x008EAD3B File Offset: 0x008E8F3B
		// (set) Token: 0x060215CC RID: 136652 RVA: 0x008EAD4F File Offset: 0x008E8F4F
		public unsafe UMaterialInstance Material
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricLightTri_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricLightTri_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x1700360E RID: 13838
		// (get) Token: 0x060215CD RID: 136653 RVA: 0x008EAD64 File Offset: 0x008E8F64
		// (set) Token: 0x060215CE RID: 136654 RVA: 0x008EAD74 File Offset: 0x008E8F74
		public unsafe float FogInt
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricLightTri_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricLightTri_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x1700360F RID: 13839
		// (get) Token: 0x060215CF RID: 136655 RVA: 0x008EAD85 File Offset: 0x008E8F85
		// (set) Token: 0x060215D0 RID: 136656 RVA: 0x008EAD99 File Offset: 0x008E8F99
		public unsafe FLinearColor InsideColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricLightTri_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricLightTri_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17003610 RID: 13840
		// (get) Token: 0x060215D1 RID: 136657 RVA: 0x008EADAE File Offset: 0x008E8FAE
		// (set) Token: 0x060215D2 RID: 136658 RVA: 0x008EADC2 File Offset: 0x008E8FC2
		public unsafe FLinearColor OutsideColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricLightTri_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricLightTri_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17003611 RID: 13841
		// (get) Token: 0x060215D3 RID: 136659 RVA: 0x008EADD7 File Offset: 0x008E8FD7
		// (set) Token: 0x060215D4 RID: 136660 RVA: 0x008EADE7 File Offset: 0x008E8FE7
		public unsafe float LightStart
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricLightTri_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricLightTri_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17003612 RID: 13842
		// (get) Token: 0x060215D5 RID: 136661 RVA: 0x008EADF8 File Offset: 0x008E8FF8
		// (set) Token: 0x060215D6 RID: 136662 RVA: 0x008EAE08 File Offset: 0x008E9008
		public unsafe float NearFadeStart
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricLightTri_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricLightTri_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17003613 RID: 13843
		// (get) Token: 0x060215D7 RID: 136663 RVA: 0x008EAE19 File Offset: 0x008E9019
		// (set) Token: 0x060215D8 RID: 136664 RVA: 0x008EAE29 File Offset: 0x008E9029
		public unsafe float FarFadeLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricLightTri_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricLightTri_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17003614 RID: 13844
		// (get) Token: 0x060215D9 RID: 136665 RVA: 0x008EAE3A File Offset: 0x008E903A
		// (set) Token: 0x060215DA RID: 136666 RVA: 0x008EAE4A File Offset: 0x008E904A
		public unsafe float FullIntLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricLightTri_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricLightTri_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17003615 RID: 13845
		// (get) Token: 0x060215DB RID: 136667 RVA: 0x008EAE5B File Offset: 0x008E905B
		// (set) Token: 0x060215DC RID: 136668 RVA: 0x008EAE6B File Offset: 0x008E906B
		public unsafe float X
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricLightTri_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricLightTri_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17003616 RID: 13846
		// (get) Token: 0x060215DD RID: 136669 RVA: 0x008EAE7C File Offset: 0x008E907C
		// (set) Token: 0x060215DE RID: 136670 RVA: 0x008EAE8C File Offset: 0x008E908C
		public unsafe float Y
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricLightTri_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricLightTri_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17003617 RID: 13847
		// (get) Token: 0x060215DF RID: 136671 RVA: 0x008EAE9D File Offset: 0x008E909D
		// (set) Token: 0x060215E0 RID: 136672 RVA: 0x008EAEAD File Offset: 0x008E90AD
		public unsafe float Z
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricLightTri_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricLightTri_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17003618 RID: 13848
		// (get) Token: 0x060215E1 RID: 136673 RVA: 0x008EAEBE File Offset: 0x008E90BE
		// (set) Token: 0x060215E2 RID: 136674 RVA: 0x008EAECE File Offset: 0x008E90CE
		public unsafe float Clip
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricLightTri_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricLightTri_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x060215E3 RID: 136675 RVA: 0x008EAEDF File Offset: 0x008E90DF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VolumetricLightTri_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x060215E4 RID: 136676 RVA: 0x008EAEF3 File Offset: 0x008E90F3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_VolumetricLightTri_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060215E5 RID: 136677 RVA: 0x008EAF08 File Offset: 0x008E9108
		protected BP_VolumetricLightTri_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040103F4 RID: 66548
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_VolumetricLightTri.BP_VolumetricLightTri_C";

		// Token: 0x040103F5 RID: 66549
		private static IntPtr _ClassPtr;

		// Token: 0x040103F6 RID: 66550
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040103F7 RID: 66551
		internal static int __PropertyOffset_0;

		// Token: 0x040103F8 RID: 66552
		internal static int __PropertyOffset_1;

		// Token: 0x040103F9 RID: 66553
		internal static int __PropertyOffset_2;

		// Token: 0x040103FA RID: 66554
		internal static int __PropertyOffset_3;

		// Token: 0x040103FB RID: 66555
		internal static int __PropertyOffset_4;

		// Token: 0x040103FC RID: 66556
		internal static int __PropertyOffset_5;

		// Token: 0x040103FD RID: 66557
		internal static int __PropertyOffset_6;

		// Token: 0x040103FE RID: 66558
		internal static int __PropertyOffset_7;

		// Token: 0x040103FF RID: 66559
		internal static int __PropertyOffset_8;

		// Token: 0x04010400 RID: 66560
		internal static int __PropertyOffset_9;

		// Token: 0x04010401 RID: 66561
		internal static int __PropertyOffset_10;

		// Token: 0x04010402 RID: 66562
		internal static int __PropertyOffset_11;

		// Token: 0x04010403 RID: 66563
		internal static int __PropertyOffset_12;

		// Token: 0x04010404 RID: 66564
		internal static int __PropertyOffset_13;

		// Token: 0x04010405 RID: 66565
		internal static int __PropertyOffset_14;

		// Token: 0x04010406 RID: 66566
		internal static int __PropertyOffset_15;

		// Token: 0x04010407 RID: 66567
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;
	}
}

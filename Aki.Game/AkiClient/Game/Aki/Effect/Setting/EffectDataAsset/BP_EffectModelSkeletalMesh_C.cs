using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Effect.Setting.EffectDataAsset
{
	// Token: 0x02003E77 RID: 15991
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Effect/Setting/EffectDataAsset/BP_EffectModelSkeletalMesh.BP_EffectModelSkeletalMesh_C")]
	[UnrealStructLayout(1416, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1416)]
	public class BP_EffectModelSkeletalMesh_C : BP_EffectModelBase_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060284F5 RID: 165109 RVA: 0x009A9489 File Offset: 0x009A7689
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_EffectModelSkeletalMesh_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Effect/Setting/EffectDataAsset/BP_EffectModelSkeletalMesh.BP_EffectModelSkeletalMesh_C");
			}
			return BP_EffectModelSkeletalMesh_C._ClassPtr;
		}

		// Token: 0x060284F6 RID: 165110 RVA: 0x009A94B0 File Offset: 0x009A76B0
		public BP_EffectModelSkeletalMesh_C() : this(BuiltinUtils.AllocNativeUObject(BP_EffectModelSkeletalMesh_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060284F7 RID: 165111 RVA: 0x009A94D8 File Offset: 0x009A76D8
		public BP_EffectModelSkeletalMesh_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_EffectModelSkeletalMesh_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005D0F RID: 23823
		// (get) Token: 0x060284F8 RID: 165112 RVA: 0x009A950B File Offset: 0x009A770B
		// (set) Token: 0x060284F9 RID: 165113 RVA: 0x009A951B File Offset: 0x009A771B
		public unsafe bool Looping
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectModelSkeletalMesh_C.__PropertyOffset_0) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectModelSkeletalMesh_C.__PropertyOffset_0) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005D10 RID: 23824
		// (get) Token: 0x060284FA RID: 165114 RVA: 0x009A952C File Offset: 0x009A772C
		// (set) Token: 0x060284FB RID: 165115 RVA: 0x009A953C File Offset: 0x009A773C
		public unsafe bool Playing
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectModelSkeletalMesh_C.__PropertyOffset_1) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectModelSkeletalMesh_C.__PropertyOffset_1) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005D11 RID: 23825
		// (get) Token: 0x060284FC RID: 165116 RVA: 0x009A9550 File Offset: 0x009A7750
		// (set) Token: 0x060284FD RID: 165117 RVA: 0x009A9589 File Offset: 0x009A7789
		public FKuroCurveVector Location
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveVector result;
				if ((result = this._Location) == null)
				{
					result = (this._Location = new FKuroCurveVector(base.NativePtr + (IntPtr)BP_EffectModelSkeletalMesh_C.__PropertyOffset_2, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveVector.StaticStruct(), base.NativePtr + (IntPtr)BP_EffectModelSkeletalMesh_C.__PropertyOffset_2, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005D12 RID: 23826
		// (get) Token: 0x060284FE RID: 165118 RVA: 0x009A95AC File Offset: 0x009A77AC
		// (set) Token: 0x060284FF RID: 165119 RVA: 0x009A95E5 File Offset: 0x009A77E5
		public FKuroCurveVector Rotation
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveVector result;
				if ((result = this._Rotation) == null)
				{
					result = (this._Rotation = new FKuroCurveVector(base.NativePtr + (IntPtr)BP_EffectModelSkeletalMesh_C.__PropertyOffset_3, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveVector.StaticStruct(), base.NativePtr + (IntPtr)BP_EffectModelSkeletalMesh_C.__PropertyOffset_3, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005D13 RID: 23827
		// (get) Token: 0x06028500 RID: 165120 RVA: 0x009A9608 File Offset: 0x009A7808
		// (set) Token: 0x06028501 RID: 165121 RVA: 0x009A9641 File Offset: 0x009A7841
		public FKuroCurveVector Scale
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveVector result;
				if ((result = this._Scale) == null)
				{
					result = (this._Scale = new FKuroCurveVector(base.NativePtr + (IntPtr)BP_EffectModelSkeletalMesh_C.__PropertyOffset_4, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveVector.StaticStruct(), base.NativePtr + (IntPtr)BP_EffectModelSkeletalMesh_C.__PropertyOffset_4, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005D14 RID: 23828
		// (get) Token: 0x06028502 RID: 165122 RVA: 0x009A9662 File Offset: 0x009A7862
		// (set) Token: 0x06028503 RID: 165123 RVA: 0x009A9672 File Offset: 0x009A7872
		public unsafe bool EnableCollision
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectModelSkeletalMesh_C.__PropertyOffset_5) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectModelSkeletalMesh_C.__PropertyOffset_5) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005D15 RID: 23829
		// (get) Token: 0x06028504 RID: 165124 RVA: 0x009A9683 File Offset: 0x009A7883
		// (set) Token: 0x06028505 RID: 165125 RVA: 0x009A9697 File Offset: 0x009A7897
		[Nullable(2)]
		public unsafe USkeletalMesh SkeletalMeshRef
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMesh>(base.NativePtr / (IntPtr)sizeof(void*) + BP_EffectModelSkeletalMesh_C.__PropertyOffset_6);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_EffectModelSkeletalMesh_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x17005D16 RID: 23830
		// (get) Token: 0x06028506 RID: 165126 RVA: 0x009A96AC File Offset: 0x009A78AC
		// (set) Token: 0x06028507 RID: 165127 RVA: 0x009A96C0 File Offset: 0x009A78C0
		[Nullable(2)]
		public unsafe UAnimationAsset AnimationRef
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAnimationAsset>(base.NativePtr / (IntPtr)sizeof(void*) + BP_EffectModelSkeletalMesh_C.__PropertyOffset_7);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_EffectModelSkeletalMesh_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x06028508 RID: 165128 RVA: 0x009A96D5 File Offset: 0x009A78D5
		protected BP_EffectModelSkeletalMesh_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014892 RID: 84114
		public new const string __ObjectPath = "/Game/Aki/Effect/Setting/EffectDataAsset/BP_EffectModelSkeletalMesh.BP_EffectModelSkeletalMesh_C";

		// Token: 0x04014893 RID: 84115
		private static IntPtr _ClassPtr;

		// Token: 0x04014894 RID: 84116
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04014895 RID: 84117
		internal new static int __PropertyOffset_0;

		// Token: 0x04014896 RID: 84118
		internal new static int __PropertyOffset_1;

		// Token: 0x04014897 RID: 84119
		internal new static int __PropertyOffset_2;

		// Token: 0x04014898 RID: 84120
		[Nullable(2)]
		private FKuroCurveVector _Location;

		// Token: 0x04014899 RID: 84121
		internal new static int __PropertyOffset_3;

		// Token: 0x0401489A RID: 84122
		[Nullable(2)]
		private FKuroCurveVector _Rotation;

		// Token: 0x0401489B RID: 84123
		internal new static int __PropertyOffset_4;

		// Token: 0x0401489C RID: 84124
		[Nullable(2)]
		private FKuroCurveVector _Scale;

		// Token: 0x0401489D RID: 84125
		internal new static int __PropertyOffset_5;

		// Token: 0x0401489E RID: 84126
		internal new static int __PropertyOffset_6;

		// Token: 0x0401489F RID: 84127
		internal new static int __PropertyOffset_7;
	}
}

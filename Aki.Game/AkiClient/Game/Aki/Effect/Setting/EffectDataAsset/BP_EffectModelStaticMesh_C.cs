using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Effect.Setting.EffectDataAsset
{
	// Token: 0x02003E78 RID: 15992
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Effect/Setting/EffectDataAsset/BP_EffectModelStaticMesh.BP_EffectModelStaticMesh_C")]
	[UnrealStructLayout(1600, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1600)]
	public class BP_EffectModelStaticMesh_C : BP_EffectModelBase_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06028509 RID: 165129 RVA: 0x009A96DE File Offset: 0x009A78DE
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_EffectModelStaticMesh_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Effect/Setting/EffectDataAsset/BP_EffectModelStaticMesh.BP_EffectModelStaticMesh_C");
			}
			return BP_EffectModelStaticMesh_C._ClassPtr;
		}

		// Token: 0x0602850A RID: 165130 RVA: 0x009A9704 File Offset: 0x009A7904
		public BP_EffectModelStaticMesh_C() : this(BuiltinUtils.AllocNativeUObject(BP_EffectModelStaticMesh_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602850B RID: 165131 RVA: 0x009A972C File Offset: 0x009A792C
		public BP_EffectModelStaticMesh_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_EffectModelStaticMesh_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005D17 RID: 23831
		// (get) Token: 0x0602850C RID: 165132 RVA: 0x009A9760 File Offset: 0x009A7960
		// (set) Token: 0x0602850D RID: 165133 RVA: 0x009A9799 File Offset: 0x009A7999
		public FKuroCurveVector Location
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveVector result;
				if ((result = this._Location) == null)
				{
					result = (this._Location = new FKuroCurveVector(base.NativePtr + (IntPtr)BP_EffectModelStaticMesh_C.__PropertyOffset_0, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveVector.StaticStruct(), base.NativePtr + (IntPtr)BP_EffectModelStaticMesh_C.__PropertyOffset_0, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005D18 RID: 23832
		// (get) Token: 0x0602850E RID: 165134 RVA: 0x009A97BC File Offset: 0x009A79BC
		// (set) Token: 0x0602850F RID: 165135 RVA: 0x009A97F5 File Offset: 0x009A79F5
		public FKuroCurveVector Rotation
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveVector result;
				if ((result = this._Rotation) == null)
				{
					result = (this._Rotation = new FKuroCurveVector(base.NativePtr + (IntPtr)BP_EffectModelStaticMesh_C.__PropertyOffset_1, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveVector.StaticStruct(), base.NativePtr + (IntPtr)BP_EffectModelStaticMesh_C.__PropertyOffset_1, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005D19 RID: 23833
		// (get) Token: 0x06028510 RID: 165136 RVA: 0x009A9818 File Offset: 0x009A7A18
		// (set) Token: 0x06028511 RID: 165137 RVA: 0x009A9851 File Offset: 0x009A7A51
		public FKuroCurveVector Scale
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveVector result;
				if ((result = this._Scale) == null)
				{
					result = (this._Scale = new FKuroCurveVector(base.NativePtr + (IntPtr)BP_EffectModelStaticMesh_C.__PropertyOffset_2, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveVector.StaticStruct(), base.NativePtr + (IntPtr)BP_EffectModelStaticMesh_C.__PropertyOffset_2, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005D1A RID: 23834
		// (get) Token: 0x06028512 RID: 165138 RVA: 0x009A9874 File Offset: 0x009A7A74
		// (set) Token: 0x06028513 RID: 165139 RVA: 0x009A98AD File Offset: 0x009A7AAD
		public TMap<FName, FKuroCurveLinearColor> MaterialColorParameters
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FKuroCurveLinearColor> result;
				if ((result = this._MaterialColorParameters) == null)
				{
					result = (this._MaterialColorParameters = new TMap<FName, FKuroCurveLinearColor>(base.NativePtr + (IntPtr)BP_EffectModelStaticMesh_C.__PropertyOffset_3, this));
				}
				return result;
			}
			set
			{
				this.MaterialColorParameters.CopyAssign(value);
			}
		}

		// Token: 0x17005D1B RID: 23835
		// (get) Token: 0x06028514 RID: 165140 RVA: 0x009A98BC File Offset: 0x009A7ABC
		// (set) Token: 0x06028515 RID: 165141 RVA: 0x009A98F5 File Offset: 0x009A7AF5
		public TMap<FName, FKuroCurveFloat> MaterialFloatParameters
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FKuroCurveFloat> result;
				if ((result = this._MaterialFloatParameters) == null)
				{
					result = (this._MaterialFloatParameters = new TMap<FName, FKuroCurveFloat>(base.NativePtr + (IntPtr)BP_EffectModelStaticMesh_C.__PropertyOffset_4, this));
				}
				return result;
			}
			set
			{
				this.MaterialFloatParameters.CopyAssign(value);
			}
		}

		// Token: 0x17005D1C RID: 23836
		// (get) Token: 0x06028516 RID: 165142 RVA: 0x009A9903 File Offset: 0x009A7B03
		// (set) Token: 0x06028517 RID: 165143 RVA: 0x009A9913 File Offset: 0x009A7B13
		public unsafe bool ReceiveDecal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectModelStaticMesh_C.__PropertyOffset_5) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectModelStaticMesh_C.__PropertyOffset_5) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005D1D RID: 23837
		// (get) Token: 0x06028518 RID: 165144 RVA: 0x009A9924 File Offset: 0x009A7B24
		// (set) Token: 0x06028519 RID: 165145 RVA: 0x009A9934 File Offset: 0x009A7B34
		public unsafe bool EnableCollision
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectModelStaticMesh_C.__PropertyOffset_6) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectModelStaticMesh_C.__PropertyOffset_6) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005D1E RID: 23838
		// (get) Token: 0x0602851A RID: 165146 RVA: 0x009A9945 File Offset: 0x009A7B45
		// (set) Token: 0x0602851B RID: 165147 RVA: 0x009A9959 File Offset: 0x009A7B59
		[Nullable(2)]
		public unsafe UStaticMesh StaticMeshRef
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + BP_EffectModelStaticMesh_C.__PropertyOffset_7);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_EffectModelStaticMesh_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x17005D1F RID: 23839
		// (get) Token: 0x0602851C RID: 165148 RVA: 0x009A996E File Offset: 0x009A7B6E
		// (set) Token: 0x0602851D RID: 165149 RVA: 0x009A9982 File Offset: 0x009A7B82
		[Nullable(2)]
		public unsafe UMaterialInterface MaterialOverrideRef
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + BP_EffectModelStaticMesh_C.__PropertyOffset_8);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_EffectModelStaticMesh_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x17005D20 RID: 23840
		// (get) Token: 0x0602851E RID: 165150 RVA: 0x009A9997 File Offset: 0x009A7B97
		// (set) Token: 0x0602851F RID: 165151 RVA: 0x009A99A7 File Offset: 0x009A7BA7
		public unsafe bool UseMultipleMaterialSlots
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectModelStaticMesh_C.__PropertyOffset_9) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectModelStaticMesh_C.__PropertyOffset_9) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005D21 RID: 23841
		// (get) Token: 0x06028520 RID: 165152 RVA: 0x009A99B8 File Offset: 0x009A7BB8
		// (set) Token: 0x06028521 RID: 165153 RVA: 0x009A99F1 File Offset: 0x009A7BF1
		public TArray<UMaterialInterface> MaterialOverrideArrayRef
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInterface> result;
				if ((result = this._MaterialOverrideArrayRef) == null)
				{
					result = (this._MaterialOverrideArrayRef = new TArray<UMaterialInterface>(base.NativePtr + (IntPtr)BP_EffectModelStaticMesh_C.__PropertyOffset_10, this));
				}
				return result;
			}
			set
			{
				this.MaterialOverrideArrayRef.CopyAssign(value);
			}
		}

		// Token: 0x17005D22 RID: 23842
		// (get) Token: 0x06028522 RID: 165154 RVA: 0x009A99FF File Offset: 0x009A7BFF
		// (set) Token: 0x06028523 RID: 165155 RVA: 0x009A9A0F File Offset: 0x009A7C0F
		public unsafe bool CastShadow
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectModelStaticMesh_C.__PropertyOffset_11) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectModelStaticMesh_C.__PropertyOffset_11) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005D23 RID: 23843
		// (get) Token: 0x06028524 RID: 165156 RVA: 0x009A9A20 File Offset: 0x009A7C20
		// (set) Token: 0x06028525 RID: 165157 RVA: 0x009A9A30 File Offset: 0x009A7C30
		public unsafe float TranslucencySortPriority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectModelStaticMesh_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectModelStaticMesh_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x06028526 RID: 165158 RVA: 0x009A9A41 File Offset: 0x009A7C41
		protected BP_EffectModelStaticMesh_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040148A0 RID: 84128
		public new const string __ObjectPath = "/Game/Aki/Effect/Setting/EffectDataAsset/BP_EffectModelStaticMesh.BP_EffectModelStaticMesh_C";

		// Token: 0x040148A1 RID: 84129
		private static IntPtr _ClassPtr;

		// Token: 0x040148A2 RID: 84130
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040148A3 RID: 84131
		internal new static int __PropertyOffset_0;

		// Token: 0x040148A4 RID: 84132
		[Nullable(2)]
		private FKuroCurveVector _Location;

		// Token: 0x040148A5 RID: 84133
		internal new static int __PropertyOffset_1;

		// Token: 0x040148A6 RID: 84134
		[Nullable(2)]
		private FKuroCurveVector _Rotation;

		// Token: 0x040148A7 RID: 84135
		internal new static int __PropertyOffset_2;

		// Token: 0x040148A8 RID: 84136
		[Nullable(2)]
		private FKuroCurveVector _Scale;

		// Token: 0x040148A9 RID: 84137
		internal new static int __PropertyOffset_3;

		// Token: 0x040148AA RID: 84138
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, FKuroCurveLinearColor> _MaterialColorParameters;

		// Token: 0x040148AB RID: 84139
		internal new static int __PropertyOffset_4;

		// Token: 0x040148AC RID: 84140
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, FKuroCurveFloat> _MaterialFloatParameters;

		// Token: 0x040148AD RID: 84141
		internal new static int __PropertyOffset_5;

		// Token: 0x040148AE RID: 84142
		internal new static int __PropertyOffset_6;

		// Token: 0x040148AF RID: 84143
		internal new static int __PropertyOffset_7;

		// Token: 0x040148B0 RID: 84144
		internal new static int __PropertyOffset_8;

		// Token: 0x040148B1 RID: 84145
		internal new static int __PropertyOffset_9;

		// Token: 0x040148B2 RID: 84146
		internal new static int __PropertyOffset_10;

		// Token: 0x040148B3 RID: 84147
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInterface> _MaterialOverrideArrayRef;

		// Token: 0x040148B4 RID: 84148
		internal new static int __PropertyOffset_11;

		// Token: 0x040148B5 RID: 84149
		internal new static int __PropertyOffset_12;
	}
}

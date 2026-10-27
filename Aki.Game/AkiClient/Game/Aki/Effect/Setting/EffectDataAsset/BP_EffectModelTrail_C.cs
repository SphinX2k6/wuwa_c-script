using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Effect.Setting.EffectDataAsset
{
	// Token: 0x02003E79 RID: 15993
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Effect/Setting/EffectDataAsset/BP_EffectModelTrail.BP_EffectModelTrail_C")]
	[UnrealStructLayout(696, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 696)]
	public class BP_EffectModelTrail_C : BP_EffectModelBase_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06028527 RID: 165159 RVA: 0x009A9A4A File Offset: 0x009A7C4A
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_EffectModelTrail_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Effect/Setting/EffectDataAsset/BP_EffectModelTrail.BP_EffectModelTrail_C");
			}
			return BP_EffectModelTrail_C._ClassPtr;
		}

		// Token: 0x06028528 RID: 165160 RVA: 0x009A9A70 File Offset: 0x009A7C70
		public BP_EffectModelTrail_C() : this(BuiltinUtils.AllocNativeUObject(BP_EffectModelTrail_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06028529 RID: 165161 RVA: 0x009A9A98 File Offset: 0x009A7C98
		public BP_EffectModelTrail_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_EffectModelTrail_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005D24 RID: 23844
		// (get) Token: 0x0602852A RID: 165162 RVA: 0x009A9ACB File Offset: 0x009A7CCB
		// (set) Token: 0x0602852B RID: 165163 RVA: 0x009A9ADB File Offset: 0x009A7CDB
		public unsafe bool AttachToBones
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectModelTrail_C.__PropertyOffset_0) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectModelTrail_C.__PropertyOffset_0) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005D25 RID: 23845
		// (get) Token: 0x0602852C RID: 165164 RVA: 0x009A9AEC File Offset: 0x009A7CEC
		// (set) Token: 0x0602852D RID: 165165 RVA: 0x009A9B25 File Offset: 0x009A7D25
		public TArray<FName> AttachBoneNames
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._AttachBoneNames) == null)
				{
					result = (this._AttachBoneNames = new TArray<FName>(base.NativePtr + (IntPtr)BP_EffectModelTrail_C.__PropertyOffset_1, this));
				}
				return result;
			}
			set
			{
				this.AttachBoneNames.CopyAssign(value);
			}
		}

		// Token: 0x17005D26 RID: 23846
		// (get) Token: 0x0602852E RID: 165166 RVA: 0x009A9B34 File Offset: 0x009A7D34
		// (set) Token: 0x0602852F RID: 165167 RVA: 0x009A9B6D File Offset: 0x009A7D6D
		public TArray<FVector> RelativeLocations
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._RelativeLocations) == null)
				{
					result = (this._RelativeLocations = new TArray<FVector>(base.NativePtr + (IntPtr)BP_EffectModelTrail_C.__PropertyOffset_2, this));
				}
				return result;
			}
			set
			{
				this.RelativeLocations.CopyAssign(value);
			}
		}

		// Token: 0x17005D27 RID: 23847
		// (get) Token: 0x06028530 RID: 165168 RVA: 0x009A9B7B File Offset: 0x009A7D7B
		// (set) Token: 0x06028531 RID: 165169 RVA: 0x009A9B8F File Offset: 0x009A7D8F
		[Nullable(2)]
		public unsafe UMaterialInterface Material
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + BP_EffectModelTrail_C.__PropertyOffset_3);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_EffectModelTrail_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17005D28 RID: 23848
		// (get) Token: 0x06028532 RID: 165170 RVA: 0x009A9BA4 File Offset: 0x009A7DA4
		// (set) Token: 0x06028533 RID: 165171 RVA: 0x009A9BDD File Offset: 0x009A7DDD
		public FKuroCurveFloat DissipateSpeed
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._DissipateSpeed) == null)
				{
					result = (this._DissipateSpeed = new FKuroCurveFloat(base.NativePtr + (IntPtr)BP_EffectModelTrail_C.__PropertyOffset_4, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)BP_EffectModelTrail_C.__PropertyOffset_4, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005D29 RID: 23849
		// (get) Token: 0x06028534 RID: 165172 RVA: 0x009A9C00 File Offset: 0x009A7E00
		// (set) Token: 0x06028535 RID: 165173 RVA: 0x009A9C39 File Offset: 0x009A7E39
		public FKuroCurveFloat Alpha
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._Alpha) == null)
				{
					result = (this._Alpha = new FKuroCurveFloat(base.NativePtr + (IntPtr)BP_EffectModelTrail_C.__PropertyOffset_5, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)BP_EffectModelTrail_C.__PropertyOffset_5, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005D2A RID: 23850
		// (get) Token: 0x06028536 RID: 165174 RVA: 0x009A9C5C File Offset: 0x009A7E5C
		// (set) Token: 0x06028537 RID: 165175 RVA: 0x009A9C95 File Offset: 0x009A7E95
		public TMap<FName, FKuroCurveFloat> FloatParameters
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FKuroCurveFloat> result;
				if ((result = this._FloatParameters) == null)
				{
					result = (this._FloatParameters = new TMap<FName, FKuroCurveFloat>(base.NativePtr + (IntPtr)BP_EffectModelTrail_C.__PropertyOffset_6, this));
				}
				return result;
			}
			set
			{
				this.FloatParameters.CopyAssign(value);
			}
		}

		// Token: 0x17005D2B RID: 23851
		// (get) Token: 0x06028538 RID: 165176 RVA: 0x009A9CA4 File Offset: 0x009A7EA4
		// (set) Token: 0x06028539 RID: 165177 RVA: 0x009A9CDD File Offset: 0x009A7EDD
		public TMap<FName, FKuroCurveLinearColor> ColorParameters
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FKuroCurveLinearColor> result;
				if ((result = this._ColorParameters) == null)
				{
					result = (this._ColorParameters = new TMap<FName, FKuroCurveLinearColor>(base.NativePtr + (IntPtr)BP_EffectModelTrail_C.__PropertyOffset_7, this));
				}
				return result;
			}
			set
			{
				this.ColorParameters.CopyAssign(value);
			}
		}

		// Token: 0x17005D2C RID: 23852
		// (get) Token: 0x0602853A RID: 165178 RVA: 0x009A9CEB File Offset: 0x009A7EEB
		// (set) Token: 0x0602853B RID: 165179 RVA: 0x009A9CFB File Offset: 0x009A7EFB
		public unsafe bool DestroyAtOnce
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectModelTrail_C.__PropertyOffset_8) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectModelTrail_C.__PropertyOffset_8) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005D2D RID: 23853
		// (get) Token: 0x0602853C RID: 165180 RVA: 0x009A9D0C File Offset: 0x009A7F0C
		// (set) Token: 0x0602853D RID: 165181 RVA: 0x009A9D1C File Offset: 0x009A7F1C
		public unsafe float DissipateSpeedAfterDead
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectModelTrail_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectModelTrail_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17005D2E RID: 23854
		// (get) Token: 0x0602853E RID: 165182 RVA: 0x009A9D2D File Offset: 0x009A7F2D
		// (set) Token: 0x0602853F RID: 165183 RVA: 0x009A9D3D File Offset: 0x009A7F3D
		public unsafe float UnitLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectModelTrail_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectModelTrail_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17005D2F RID: 23855
		// (get) Token: 0x06028540 RID: 165184 RVA: 0x009A9D50 File Offset: 0x009A7F50
		// (set) Token: 0x06028541 RID: 165185 RVA: 0x009A9D89 File Offset: 0x009A7F89
		public TMap<int, FKuroCurveVector> LocationsCurve
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, FKuroCurveVector> result;
				if ((result = this._LocationsCurve) == null)
				{
					result = (this._LocationsCurve = new TMap<int, FKuroCurveVector>(base.NativePtr + (IntPtr)BP_EffectModelTrail_C.__PropertyOffset_11, this));
				}
				return result;
			}
			set
			{
				this.LocationsCurve.CopyAssign(value);
			}
		}

		// Token: 0x06028542 RID: 165186 RVA: 0x009A9D97 File Offset: 0x009A7F97
		protected BP_EffectModelTrail_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040148B6 RID: 84150
		public new const string __ObjectPath = "/Game/Aki/Effect/Setting/EffectDataAsset/BP_EffectModelTrail.BP_EffectModelTrail_C";

		// Token: 0x040148B7 RID: 84151
		private static IntPtr _ClassPtr;

		// Token: 0x040148B8 RID: 84152
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040148B9 RID: 84153
		internal new static int __PropertyOffset_0;

		// Token: 0x040148BA RID: 84154
		internal new static int __PropertyOffset_1;

		// Token: 0x040148BB RID: 84155
		[Nullable(2)]
		private TArray<FName> _AttachBoneNames;

		// Token: 0x040148BC RID: 84156
		internal new static int __PropertyOffset_2;

		// Token: 0x040148BD RID: 84157
		[Nullable(2)]
		private TArray<FVector> _RelativeLocations;

		// Token: 0x040148BE RID: 84158
		internal new static int __PropertyOffset_3;

		// Token: 0x040148BF RID: 84159
		internal new static int __PropertyOffset_4;

		// Token: 0x040148C0 RID: 84160
		[Nullable(2)]
		private FKuroCurveFloat _DissipateSpeed;

		// Token: 0x040148C1 RID: 84161
		internal new static int __PropertyOffset_5;

		// Token: 0x040148C2 RID: 84162
		[Nullable(2)]
		private FKuroCurveFloat _Alpha;

		// Token: 0x040148C3 RID: 84163
		internal new static int __PropertyOffset_6;

		// Token: 0x040148C4 RID: 84164
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, FKuroCurveFloat> _FloatParameters;

		// Token: 0x040148C5 RID: 84165
		internal new static int __PropertyOffset_7;

		// Token: 0x040148C6 RID: 84166
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, FKuroCurveLinearColor> _ColorParameters;

		// Token: 0x040148C7 RID: 84167
		internal new static int __PropertyOffset_8;

		// Token: 0x040148C8 RID: 84168
		internal new static int __PropertyOffset_9;

		// Token: 0x040148C9 RID: 84169
		internal new static int __PropertyOffset_10;

		// Token: 0x040148CA RID: 84170
		internal new static int __PropertyOffset_11;

		// Token: 0x040148CB RID: 84171
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<int, FKuroCurveVector> _LocationsCurve;
	}
}

using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Effect.Setting.EffectDataAsset
{
	// Token: 0x02003E70 RID: 15984
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Effect/Setting/EffectDataAsset/BP_EffectModelDecal.BP_EffectModelDecal_C")]
	[UnrealStructLayout(1552, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1552)]
	public class BP_EffectModelDecal_C : BP_EffectModelBase_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060283E9 RID: 164841 RVA: 0x009A75E6 File Offset: 0x009A57E6
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_EffectModelDecal_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Effect/Setting/EffectDataAsset/BP_EffectModelDecal.BP_EffectModelDecal_C");
			}
			return BP_EffectModelDecal_C._ClassPtr;
		}

		// Token: 0x060283EA RID: 164842 RVA: 0x009A760C File Offset: 0x009A580C
		public BP_EffectModelDecal_C() : this(BuiltinUtils.AllocNativeUObject(BP_EffectModelDecal_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060283EB RID: 164843 RVA: 0x009A7634 File Offset: 0x009A5834
		public BP_EffectModelDecal_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_EffectModelDecal_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005C97 RID: 23703
		// (get) Token: 0x060283EC RID: 164844 RVA: 0x009A7668 File Offset: 0x009A5868
		// (set) Token: 0x060283ED RID: 164845 RVA: 0x009A76A1 File Offset: 0x009A58A1
		public FKuroCurveVector Location
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveVector result;
				if ((result = this._Location) == null)
				{
					result = (this._Location = new FKuroCurveVector(base.NativePtr + (IntPtr)BP_EffectModelDecal_C.__PropertyOffset_0, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveVector.StaticStruct(), base.NativePtr + (IntPtr)BP_EffectModelDecal_C.__PropertyOffset_0, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005C98 RID: 23704
		// (get) Token: 0x060283EE RID: 164846 RVA: 0x009A76C4 File Offset: 0x009A58C4
		// (set) Token: 0x060283EF RID: 164847 RVA: 0x009A76FD File Offset: 0x009A58FD
		public FKuroCurveVector Rotation
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveVector result;
				if ((result = this._Rotation) == null)
				{
					result = (this._Rotation = new FKuroCurveVector(base.NativePtr + (IntPtr)BP_EffectModelDecal_C.__PropertyOffset_1, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveVector.StaticStruct(), base.NativePtr + (IntPtr)BP_EffectModelDecal_C.__PropertyOffset_1, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005C99 RID: 23705
		// (get) Token: 0x060283F0 RID: 164848 RVA: 0x009A7720 File Offset: 0x009A5920
		// (set) Token: 0x060283F1 RID: 164849 RVA: 0x009A7759 File Offset: 0x009A5959
		public FKuroCurveVector Scale
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveVector result;
				if ((result = this._Scale) == null)
				{
					result = (this._Scale = new FKuroCurveVector(base.NativePtr + (IntPtr)BP_EffectModelDecal_C.__PropertyOffset_2, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveVector.StaticStruct(), base.NativePtr + (IntPtr)BP_EffectModelDecal_C.__PropertyOffset_2, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005C9A RID: 23706
		// (get) Token: 0x060283F2 RID: 164850 RVA: 0x009A777C File Offset: 0x009A597C
		// (set) Token: 0x060283F3 RID: 164851 RVA: 0x009A77B5 File Offset: 0x009A59B5
		public TMap<FName, FKuroCurveFloat> MaterialFloatParameters
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FKuroCurveFloat> result;
				if ((result = this._MaterialFloatParameters) == null)
				{
					result = (this._MaterialFloatParameters = new TMap<FName, FKuroCurveFloat>(base.NativePtr + (IntPtr)BP_EffectModelDecal_C.__PropertyOffset_3, this));
				}
				return result;
			}
			set
			{
				this.MaterialFloatParameters.CopyAssign(value);
			}
		}

		// Token: 0x17005C9B RID: 23707
		// (get) Token: 0x060283F4 RID: 164852 RVA: 0x009A77C4 File Offset: 0x009A59C4
		// (set) Token: 0x060283F5 RID: 164853 RVA: 0x009A77FD File Offset: 0x009A59FD
		public TMap<FName, FKuroCurveLinearColor> MaterialColorParameters
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FKuroCurveLinearColor> result;
				if ((result = this._MaterialColorParameters) == null)
				{
					result = (this._MaterialColorParameters = new TMap<FName, FKuroCurveLinearColor>(base.NativePtr + (IntPtr)BP_EffectModelDecal_C.__PropertyOffset_4, this));
				}
				return result;
			}
			set
			{
				this.MaterialColorParameters.CopyAssign(value);
			}
		}

		// Token: 0x17005C9C RID: 23708
		// (get) Token: 0x060283F6 RID: 164854 RVA: 0x009A780B File Offset: 0x009A5A0B
		// (set) Token: 0x060283F7 RID: 164855 RVA: 0x009A781F File Offset: 0x009A5A1F
		[Nullable(2)]
		public unsafe UMaterialInterface DecalMaterialRef
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + BP_EffectModelDecal_C.__PropertyOffset_5);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_EffectModelDecal_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x060283F8 RID: 164856 RVA: 0x009A7834 File Offset: 0x009A5A34
		protected BP_EffectModelDecal_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040147D3 RID: 83923
		public new const string __ObjectPath = "/Game/Aki/Effect/Setting/EffectDataAsset/BP_EffectModelDecal.BP_EffectModelDecal_C";

		// Token: 0x040147D4 RID: 83924
		private static IntPtr _ClassPtr;

		// Token: 0x040147D5 RID: 83925
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040147D6 RID: 83926
		internal new static int __PropertyOffset_0;

		// Token: 0x040147D7 RID: 83927
		[Nullable(2)]
		private FKuroCurveVector _Location;

		// Token: 0x040147D8 RID: 83928
		internal new static int __PropertyOffset_1;

		// Token: 0x040147D9 RID: 83929
		[Nullable(2)]
		private FKuroCurveVector _Rotation;

		// Token: 0x040147DA RID: 83930
		internal new static int __PropertyOffset_2;

		// Token: 0x040147DB RID: 83931
		[Nullable(2)]
		private FKuroCurveVector _Scale;

		// Token: 0x040147DC RID: 83932
		internal new static int __PropertyOffset_3;

		// Token: 0x040147DD RID: 83933
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, FKuroCurveFloat> _MaterialFloatParameters;

		// Token: 0x040147DE RID: 83934
		internal new static int __PropertyOffset_4;

		// Token: 0x040147DF RID: 83935
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, FKuroCurveLinearColor> _MaterialColorParameters;

		// Token: 0x040147E0 RID: 83936
		internal new static int __PropertyOffset_5;
	}
}

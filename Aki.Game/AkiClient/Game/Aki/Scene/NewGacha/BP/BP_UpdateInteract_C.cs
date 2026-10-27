using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Scene.NewGacha.BP
{
	// Token: 0x02003A49 RID: 14921
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Scene/NewGacha/BP/BP_UpdateInteract.BP_UpdateInteract_C")]
	[UnrealStructLayout(2320, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2313)]
	public class BP_UpdateInteract_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F7AC RID: 128940 RVA: 0x008B97C5 File Offset: 0x008B79C5
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_UpdateInteract_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Scene/NewGacha/BP/BP_UpdateInteract.BP_UpdateInteract_C");
			}
			return BP_UpdateInteract_C._ClassPtr;
		}

		// Token: 0x0601F7AD RID: 128941 RVA: 0x008B97EC File Offset: 0x008B79EC
		public BP_UpdateInteract_C() : this(BuiltinUtils.AllocNativeUObject(BP_UpdateInteract_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F7AE RID: 128942 RVA: 0x008B9814 File Offset: 0x008B7A14
		public BP_UpdateInteract_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_UpdateInteract_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002BA0 RID: 11168
		// (get) Token: 0x0601F7AF RID: 128943 RVA: 0x008B9847 File Offset: 0x008B7A47
		// (set) Token: 0x0601F7B0 RID: 128944 RVA: 0x008B985B File Offset: 0x008B7A5B
		[Nullable(2)]
		public unsafe UKuroPostProcessComponent KuroPostProcess
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroPostProcessComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_UpdateInteract_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_UpdateInteract_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17002BA1 RID: 11169
		// (get) Token: 0x0601F7B1 RID: 128945 RVA: 0x008B9870 File Offset: 0x008B7A70
		// (set) Token: 0x0601F7B2 RID: 128946 RVA: 0x008B9884 File Offset: 0x008B7A84
		[Nullable(2)]
		public unsafe UBoxComponent Box
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_UpdateInteract_C.__PropertyOffset_2);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_UpdateInteract_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17002BA2 RID: 11170
		// (get) Token: 0x0601F7B3 RID: 128947 RVA: 0x008B9899 File Offset: 0x008B7A99
		// (set) Token: 0x0601F7B4 RID: 128948 RVA: 0x008B98AD File Offset: 0x008B7AAD
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_UpdateInteract_C.__PropertyOffset_3);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_UpdateInteract_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17002BA3 RID: 11171
		// (get) Token: 0x0601F7B5 RID: 128949 RVA: 0x008B98C2 File Offset: 0x008B7AC2
		// (set) Token: 0x0601F7B6 RID: 128950 RVA: 0x008B98D6 File Offset: 0x008B7AD6
		[Nullable(0)]
		public unsafe TEnumAsByte<E_GachaResultNew> GachaResults
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_4);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17002BA4 RID: 11172
		// (get) Token: 0x0601F7B7 RID: 128951 RVA: 0x008B98EB File Offset: 0x008B7AEB
		// (set) Token: 0x0601F7B8 RID: 128952 RVA: 0x008B98FF File Offset: 0x008B7AFF
		public unsafe FLinearColor NormalColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17002BA5 RID: 11173
		// (get) Token: 0x0601F7B9 RID: 128953 RVA: 0x008B9914 File Offset: 0x008B7B14
		// (set) Token: 0x0601F7BA RID: 128954 RVA: 0x008B9928 File Offset: 0x008B7B28
		public unsafe FLinearColor PurpleColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17002BA6 RID: 11174
		// (get) Token: 0x0601F7BB RID: 128955 RVA: 0x008B9940 File Offset: 0x008B7B40
		// (set) Token: 0x0601F7BC RID: 128956 RVA: 0x008B9979 File Offset: 0x008B7B79
		public TArray<ANiagaraActor> AwardParticles
		{
			get
			{
				base.FastCheckIsValid();
				TArray<ANiagaraActor> result;
				if ((result = this._AwardParticles) == null)
				{
					result = (this._AwardParticles = new TArray<ANiagaraActor>(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_7, this));
				}
				return result;
			}
			set
			{
				this.AwardParticles.CopyAssign(value);
			}
		}

		// Token: 0x17002BA7 RID: 11175
		// (get) Token: 0x0601F7BD RID: 128957 RVA: 0x008B9987 File Offset: 0x008B7B87
		// (set) Token: 0x0601F7BE RID: 128958 RVA: 0x008B999B File Offset: 0x008B7B9B
		public unsafe FLinearColor GoldColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17002BA8 RID: 11176
		// (get) Token: 0x0601F7BF RID: 128959 RVA: 0x008B99B0 File Offset: 0x008B7BB0
		// (set) Token: 0x0601F7C0 RID: 128960 RVA: 0x008B99E9 File Offset: 0x008B7BE9
		public ResultWeaponNormal ResultWeaponNormal
		{
			get
			{
				base.FastCheckIsValid();
				ResultWeaponNormal result;
				if ((result = this._ResultWeaponNormal) == null)
				{
					result = (this._ResultWeaponNormal = new ResultWeaponNormal(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_9, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_9, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17002BA9 RID: 11177
		// (get) Token: 0x0601F7C1 RID: 128961 RVA: 0x008B9A0C File Offset: 0x008B7C0C
		// (set) Token: 0x0601F7C2 RID: 128962 RVA: 0x008B9A45 File Offset: 0x008B7C45
		public ResultWeaponPurple ResultWeaponPurple
		{
			get
			{
				base.FastCheckIsValid();
				ResultWeaponPurple result;
				if ((result = this._ResultWeaponPurple) == null)
				{
					result = (this._ResultWeaponPurple = new ResultWeaponPurple(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_10, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_10, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17002BAA RID: 11178
		// (get) Token: 0x0601F7C3 RID: 128963 RVA: 0x008B9A68 File Offset: 0x008B7C68
		// (set) Token: 0x0601F7C4 RID: 128964 RVA: 0x008B9AA1 File Offset: 0x008B7CA1
		public ResultWeaponGolden ResultWeaponGolden
		{
			get
			{
				base.FastCheckIsValid();
				ResultWeaponGolden result;
				if ((result = this._ResultWeaponGolden) == null)
				{
					result = (this._ResultWeaponGolden = new ResultWeaponGolden(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_11, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_11, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17002BAB RID: 11179
		// (get) Token: 0x0601F7C5 RID: 128965 RVA: 0x008B9AC4 File Offset: 0x008B7CC4
		// (set) Token: 0x0601F7C6 RID: 128966 RVA: 0x008B9AFD File Offset: 0x008B7CFD
		public TMap<int, FLinearColor> ParticleColor
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, FLinearColor> result;
				if ((result = this._ParticleColor) == null)
				{
					result = (this._ParticleColor = new TMap<int, FLinearColor>(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_12, this));
				}
				return result;
			}
			set
			{
				this.ParticleColor.CopyAssign(value);
			}
		}

		// Token: 0x17002BAC RID: 11180
		// (get) Token: 0x0601F7C7 RID: 128967 RVA: 0x008B9B0C File Offset: 0x008B7D0C
		// (set) Token: 0x0601F7C8 RID: 128968 RVA: 0x008B9B45 File Offset: 0x008B7D45
		public TMap<int, UKuroWeatherDataAsset> DataAsset
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, UKuroWeatherDataAsset> result;
				if ((result = this._DataAsset) == null)
				{
					result = (this._DataAsset = new TMap<int, UKuroWeatherDataAsset>(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_13, this));
				}
				return result;
			}
			set
			{
				this.DataAsset.CopyAssign(value);
			}
		}

		// Token: 0x17002BAD RID: 11181
		// (get) Token: 0x0601F7C9 RID: 128969 RVA: 0x008B9B53 File Offset: 0x008B7D53
		// (set) Token: 0x0601F7CA RID: 128970 RVA: 0x008B9B67 File Offset: 0x008B7D67
		public unsafe FLinearColor ParticleColorFinal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17002BAE RID: 11182
		// (get) Token: 0x0601F7CB RID: 128971 RVA: 0x008B9B7C File Offset: 0x008B7D7C
		// (set) Token: 0x0601F7CC RID: 128972 RVA: 0x008B9B90 File Offset: 0x008B7D90
		[Nullable(0)]
		public unsafe TEnumAsByte<E_GachaResultFinal> GachaResultForShow
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_15);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17002BAF RID: 11183
		// (get) Token: 0x0601F7CD RID: 128973 RVA: 0x008B9BA8 File Offset: 0x008B7DA8
		// (set) Token: 0x0601F7CE RID: 128974 RVA: 0x008B9BE1 File Offset: 0x008B7DE1
		public ResultCharacterPurple ResultCharacterPurple
		{
			get
			{
				base.FastCheckIsValid();
				ResultCharacterPurple result;
				if ((result = this._ResultCharacterPurple) == null)
				{
					result = (this._ResultCharacterPurple = new ResultCharacterPurple(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_16, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_16, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17002BB0 RID: 11184
		// (get) Token: 0x0601F7CF RID: 128975 RVA: 0x008B9C04 File Offset: 0x008B7E04
		// (set) Token: 0x0601F7D0 RID: 128976 RVA: 0x008B9C3D File Offset: 0x008B7E3D
		public ResultCharacterGolden ResultCharacterGolden
		{
			get
			{
				base.FastCheckIsValid();
				ResultCharacterGolden result;
				if ((result = this._ResultCharacterGolden) == null)
				{
					result = (this._ResultCharacterGolden = new ResultCharacterGolden(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_17, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_17, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17002BB1 RID: 11185
		// (get) Token: 0x0601F7D1 RID: 128977 RVA: 0x008B9C60 File Offset: 0x008B7E60
		// (set) Token: 0x0601F7D2 RID: 128978 RVA: 0x008B9C99 File Offset: 0x008B7E99
		public ResultYinlin ResultYinlin
		{
			get
			{
				base.FastCheckIsValid();
				ResultYinlin result;
				if ((result = this._ResultYinlin) == null)
				{
					result = (this._ResultYinlin = new ResultYinlin(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_18, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_18, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17002BB2 RID: 11186
		// (get) Token: 0x0601F7D3 RID: 128979 RVA: 0x008B9CBC File Offset: 0x008B7EBC
		// (set) Token: 0x0601F7D4 RID: 128980 RVA: 0x008B9CF5 File Offset: 0x008B7EF5
		public ResultAnke ResultAnke
		{
			get
			{
				base.FastCheckIsValid();
				ResultAnke result;
				if ((result = this._ResultAnke) == null)
				{
					result = (this._ResultAnke = new ResultAnke(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_19, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_19, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17002BB3 RID: 11187
		// (get) Token: 0x0601F7D5 RID: 128981 RVA: 0x008B9D18 File Offset: 0x008B7F18
		// (set) Token: 0x0601F7D6 RID: 128982 RVA: 0x008B9D51 File Offset: 0x008B7F51
		public ResultAwu ResultAwu
		{
			get
			{
				base.FastCheckIsValid();
				ResultAwu result;
				if ((result = this._ResultAwu) == null)
				{
					result = (this._ResultAwu = new ResultAwu(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_20, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_20, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17002BB4 RID: 11188
		// (get) Token: 0x0601F7D7 RID: 128983 RVA: 0x008B9D74 File Offset: 0x008B7F74
		// (set) Token: 0x0601F7D8 RID: 128984 RVA: 0x008B9DAD File Offset: 0x008B7FAD
		public ResultKakaluo ResultKakaluo
		{
			get
			{
				base.FastCheckIsValid();
				ResultKakaluo result;
				if ((result = this._ResultKakaluo) == null)
				{
					result = (this._ResultKakaluo = new ResultKakaluo(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_21, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_21, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17002BB5 RID: 11189
		// (get) Token: 0x0601F7D9 RID: 128985 RVA: 0x008B9DD0 File Offset: 0x008B7FD0
		// (set) Token: 0x0601F7DA RID: 128986 RVA: 0x008B9E09 File Offset: 0x008B8009
		public ResultChun ResultChun
		{
			get
			{
				base.FastCheckIsValid();
				ResultChun result;
				if ((result = this._ResultChun) == null)
				{
					result = (this._ResultChun = new ResultChun(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_22, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_22, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17002BB6 RID: 11190
		// (get) Token: 0x0601F7DB RID: 128987 RVA: 0x008B9E2C File Offset: 0x008B802C
		// (set) Token: 0x0601F7DC RID: 128988 RVA: 0x008B9E65 File Offset: 0x008B8065
		public ResultJiyan ResultJiyan
		{
			get
			{
				base.FastCheckIsValid();
				ResultJiyan result;
				if ((result = this._ResultJiyan) == null)
				{
					result = (this._ResultJiyan = new ResultJiyan(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_23, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_23, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17002BB7 RID: 11191
		// (get) Token: 0x0601F7DD RID: 128989 RVA: 0x008B9E88 File Offset: 0x008B8088
		// (set) Token: 0x0601F7DE RID: 128990 RVA: 0x008B9EC1 File Offset: 0x008B80C1
		public ResultJueyuan ResultJueyuan
		{
			get
			{
				base.FastCheckIsValid();
				ResultJueyuan result;
				if ((result = this._ResultJueyuan) == null)
				{
					result = (this._ResultJueyuan = new ResultJueyuan(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_24, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_24, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17002BB8 RID: 11192
		// (get) Token: 0x0601F7DF RID: 128991 RVA: 0x008B9EE4 File Offset: 0x008B80E4
		// (set) Token: 0x0601F7E0 RID: 128992 RVA: 0x008B9F1D File Offset: 0x008B811D
		public TArray<AActor> ChangeHiddenObject
		{
			get
			{
				base.FastCheckIsValid();
				TArray<AActor> result;
				if ((result = this._ChangeHiddenObject) == null)
				{
					result = (this._ChangeHiddenObject = new TArray<AActor>(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_25, this));
				}
				return result;
			}
			set
			{
				this.ChangeHiddenObject.CopyAssign(value);
			}
		}

		// Token: 0x17002BB9 RID: 11193
		// (get) Token: 0x0601F7E1 RID: 128993 RVA: 0x008B9F2C File Offset: 0x008B812C
		// (set) Token: 0x0601F7E2 RID: 128994 RVA: 0x008B9F65 File Offset: 0x008B8165
		public TMap<int, bool> MeshHidden
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, bool> result;
				if ((result = this._MeshHidden) == null)
				{
					result = (this._MeshHidden = new TMap<int, bool>(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_26, this));
				}
				return result;
			}
			set
			{
				this.MeshHidden.CopyAssign(value);
			}
		}

		// Token: 0x17002BBA RID: 11194
		// (get) Token: 0x0601F7E3 RID: 128995 RVA: 0x008B9F73 File Offset: 0x008B8173
		// (set) Token: 0x0601F7E4 RID: 128996 RVA: 0x008B9F83 File Offset: 0x008B8183
		public unsafe bool SceneObjectVisibility
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_27) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_27) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002BBB RID: 11195
		// (get) Token: 0x0601F7E5 RID: 128997 RVA: 0x008B9F94 File Offset: 0x008B8194
		// (set) Token: 0x0601F7E6 RID: 128998 RVA: 0x008B9FCD File Offset: 0x008B81CD
		public TArray<ANiagaraActor> CharacterHiddenParticles
		{
			get
			{
				base.FastCheckIsValid();
				TArray<ANiagaraActor> result;
				if ((result = this._CharacterHiddenParticles) == null)
				{
					result = (this._CharacterHiddenParticles = new TArray<ANiagaraActor>(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_28, this));
				}
				return result;
			}
			set
			{
				this.CharacterHiddenParticles.CopyAssign(value);
			}
		}

		// Token: 0x17002BBC RID: 11196
		// (get) Token: 0x0601F7E7 RID: 128999 RVA: 0x008B9FDB File Offset: 0x008B81DB
		// (set) Token: 0x0601F7E8 RID: 129000 RVA: 0x008B9FEB File Offset: 0x008B81EB
		public unsafe bool IsCharacter_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_29) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_29) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002BBD RID: 11197
		// (get) Token: 0x0601F7E9 RID: 129001 RVA: 0x008B9FFC File Offset: 0x008B81FC
		// (set) Token: 0x0601F7EA RID: 129002 RVA: 0x008BA035 File Offset: 0x008B8235
		public TArray<ANiagaraActor> UpParticles
		{
			get
			{
				base.FastCheckIsValid();
				TArray<ANiagaraActor> result;
				if ((result = this._UpParticles) == null)
				{
					result = (this._UpParticles = new TArray<ANiagaraActor>(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_30, this));
				}
				return result;
			}
			set
			{
				this.UpParticles.CopyAssign(value);
			}
		}

		// Token: 0x17002BBE RID: 11198
		// (get) Token: 0x0601F7EB RID: 129003 RVA: 0x008BA044 File Offset: 0x008B8244
		// (set) Token: 0x0601F7EC RID: 129004 RVA: 0x008BA07D File Offset: 0x008B827D
		public TArray<ANiagaraActor> DownParticles
		{
			get
			{
				base.FastCheckIsValid();
				TArray<ANiagaraActor> result;
				if ((result = this._DownParticles) == null)
				{
					result = (this._DownParticles = new TArray<ANiagaraActor>(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_31, this));
				}
				return result;
			}
			set
			{
				this.DownParticles.CopyAssign(value);
			}
		}

		// Token: 0x17002BBF RID: 11199
		// (get) Token: 0x0601F7ED RID: 129005 RVA: 0x008BA08B File Offset: 0x008B828B
		// (set) Token: 0x0601F7EE RID: 129006 RVA: 0x008BA09B File Offset: 0x008B829B
		public unsafe bool IsEditor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_32) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_32) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002BC0 RID: 11200
		// (get) Token: 0x0601F7EF RID: 129007 RVA: 0x008BA0AC File Offset: 0x008B82AC
		// (set) Token: 0x0601F7F0 RID: 129008 RVA: 0x008BA0E5 File Offset: 0x008B82E5
		public ResultBaer ResultBaer
		{
			get
			{
				base.FastCheckIsValid();
				ResultBaer result;
				if ((result = this._ResultBaer) == null)
				{
					result = (this._ResultBaer = new ResultBaer(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_33, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_33, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17002BC1 RID: 11201
		// (get) Token: 0x0601F7F1 RID: 129009 RVA: 0x008BA108 File Offset: 0x008B8308
		// (set) Token: 0x0601F7F2 RID: 129010 RVA: 0x008BA141 File Offset: 0x008B8341
		public ResultBailian ResultBailian
		{
			get
			{
				base.FastCheckIsValid();
				ResultBailian result;
				if ((result = this._ResultBailian) == null)
				{
					result = (this._ResultBailian = new ResultBailian(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_34, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_34, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17002BC2 RID: 11202
		// (get) Token: 0x0601F7F3 RID: 129011 RVA: 0x008BA164 File Offset: 0x008B8364
		// (set) Token: 0x0601F7F4 RID: 129012 RVA: 0x008BA19D File Offset: 0x008B839D
		public ResultJianxin ResultJianxin
		{
			get
			{
				base.FastCheckIsValid();
				ResultJianxin result;
				if ((result = this._ResultJianxin) == null)
				{
					result = (this._ResultJianxin = new ResultJianxin(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_35, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_35, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17002BC3 RID: 11203
		// (get) Token: 0x0601F7F5 RID: 129013 RVA: 0x008BA1C0 File Offset: 0x008B83C0
		// (set) Token: 0x0601F7F6 RID: 129014 RVA: 0x008BA1F9 File Offset: 0x008B83F9
		public ResultMaxiaofang ResultMaxiaofang
		{
			get
			{
				base.FastCheckIsValid();
				ResultMaxiaofang result;
				if ((result = this._ResultMaxiaofang) == null)
				{
					result = (this._ResultMaxiaofang = new ResultMaxiaofang(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_36, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_36, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17002BC4 RID: 11204
		// (get) Token: 0x0601F7F7 RID: 129015 RVA: 0x008BA21C File Offset: 0x008B841C
		// (set) Token: 0x0601F7F8 RID: 129016 RVA: 0x008BA255 File Offset: 0x008B8455
		public ResultMicai ResultMicai
		{
			get
			{
				base.FastCheckIsValid();
				ResultMicai result;
				if ((result = this._ResultMicai) == null)
				{
					result = (this._ResultMicai = new ResultMicai(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_37, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_37, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17002BC5 RID: 11205
		// (get) Token: 0x0601F7F9 RID: 129017 RVA: 0x008BA278 File Offset: 0x008B8478
		// (set) Token: 0x0601F7FA RID: 129018 RVA: 0x008BA2B1 File Offset: 0x008B84B1
		public ResultQiushui ResultQiushui
		{
			get
			{
				base.FastCheckIsValid();
				ResultQiushui result;
				if ((result = this._ResultQiushui) == null)
				{
					result = (this._ResultQiushui = new ResultQiushui(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_38, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_38, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17002BC6 RID: 11206
		// (get) Token: 0x0601F7FB RID: 129019 RVA: 0x008BA2D4 File Offset: 0x008B84D4
		// (set) Token: 0x0601F7FC RID: 129020 RVA: 0x008BA30D File Offset: 0x008B850D
		public ResultSanhua ResultSanhua
		{
			get
			{
				base.FastCheckIsValid();
				ResultSanhua result;
				if ((result = this._ResultSanhua) == null)
				{
					result = (this._ResultSanhua = new ResultSanhua(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_39, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_39, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17002BC7 RID: 11207
		// (get) Token: 0x0601F7FD RID: 129021 RVA: 0x008BA330 File Offset: 0x008B8530
		// (set) Token: 0x0601F7FE RID: 129022 RVA: 0x008BA369 File Offset: 0x008B8569
		public ResultTaoqi ResultTaoqi
		{
			get
			{
				base.FastCheckIsValid();
				ResultTaoqi result;
				if ((result = this._ResultTaoqi) == null)
				{
					result = (this._ResultTaoqi = new ResultTaoqi(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_40, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_40, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17002BC8 RID: 11208
		// (get) Token: 0x0601F7FF RID: 129023 RVA: 0x008BA38C File Offset: 0x008B858C
		// (set) Token: 0x0601F800 RID: 129024 RVA: 0x008BA3C5 File Offset: 0x008B85C5
		public ResultYangyang ResultYangyang
		{
			get
			{
				base.FastCheckIsValid();
				ResultYangyang result;
				if ((result = this._ResultYangyang) == null)
				{
					result = (this._ResultYangyang = new ResultYangyang(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_41, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_41, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17002BC9 RID: 11209
		// (get) Token: 0x0601F801 RID: 129025 RVA: 0x008BA3E8 File Offset: 0x008B85E8
		// (set) Token: 0x0601F802 RID: 129026 RVA: 0x008BA421 File Offset: 0x008B8621
		public ResultYuanwu ResultYuanwu
		{
			get
			{
				base.FastCheckIsValid();
				ResultYuanwu result;
				if ((result = this._ResultYuanwu) == null)
				{
					result = (this._ResultYuanwu = new ResultYuanwu(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_42, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_42, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17002BCA RID: 11210
		// (get) Token: 0x0601F803 RID: 129027 RVA: 0x008BA442 File Offset: 0x008B8642
		// (set) Token: 0x0601F804 RID: 129028 RVA: 0x008BA452 File Offset: 0x008B8652
		public unsafe bool IsCallable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_43) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_43) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002BCB RID: 11211
		// (get) Token: 0x0601F805 RID: 129029 RVA: 0x008BA463 File Offset: 0x008B8663
		// (set) Token: 0x0601F806 RID: 129030 RVA: 0x008BA473 File Offset: 0x008B8673
		public unsafe float OriMotionBlur
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_44);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_44) = value;
			}
		}

		// Token: 0x17002BCC RID: 11212
		// (get) Token: 0x0601F807 RID: 129031 RVA: 0x008BA484 File Offset: 0x008B8684
		// (set) Token: 0x0601F808 RID: 129032 RVA: 0x008BA4BD File Offset: 0x008B86BD
		public ResultJinxi ResultJinxi
		{
			get
			{
				base.FastCheckIsValid();
				ResultJinxi result;
				if ((result = this._ResultJinxi) == null)
				{
					result = (this._ResultJinxi = new ResultJinxi(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_45, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_45, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17002BCD RID: 11213
		// (get) Token: 0x0601F809 RID: 129033 RVA: 0x008BA4E0 File Offset: 0x008B86E0
		// (set) Token: 0x0601F80A RID: 129034 RVA: 0x008BA519 File Offset: 0x008B8719
		public ResultChangli ResultChangli
		{
			get
			{
				base.FastCheckIsValid();
				ResultChangli result;
				if ((result = this._ResultChangli) == null)
				{
					result = (this._ResultChangli = new ResultChangli(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_46, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_46, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17002BCE RID: 11214
		// (get) Token: 0x0601F80B RID: 129035 RVA: 0x008BA53C File Offset: 0x008B873C
		// (set) Token: 0x0601F80C RID: 129036 RVA: 0x008BA575 File Offset: 0x008B8775
		public ResultMain ResultMain
		{
			get
			{
				base.FastCheckIsValid();
				ResultMain result;
				if ((result = this._ResultMain) == null)
				{
					result = (this._ResultMain = new ResultMain(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_47, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_47, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17002BCF RID: 11215
		// (get) Token: 0x0601F80D RID: 129037 RVA: 0x008BA596 File Offset: 0x008B8796
		// (set) Token: 0x0601F80E RID: 129038 RVA: 0x008BA5A6 File Offset: 0x008B87A6
		public unsafe bool OpenLerPerFrame
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_48) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_48) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601F80F RID: 129039 RVA: 0x008BA5B8 File Offset: 0x008B87B8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void QualityColorModification(E_GachaResultFinal GachaResult, int ID, bool IsCharacter)
		{
			BP_UpdateInteract_C.__QualityColorModification_FunctionParams* ptr = stackalloc BP_UpdateInteract_C.__QualityColorModification_FunctionParams[(UIntPtr)191] + 15L / (long)sizeof(BP_UpdateInteract_C.__QualityColorModification_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_UpdateInteract_C.__QualityColorModification_NativeFunctionPtr, (void*)ptr, 1);
			ptr->GachaResult = GachaResult;
			ptr->ID = ID;
			ptr->IsCharacter = IsCharacter;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_UpdateInteract_C.__QualityColorModification_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601F810 RID: 129040 RVA: 0x008BA614 File Offset: 0x008B8814
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void IsNewWorkFlow(ref bool IsNew)
		{
			BP_UpdateInteract_C.__IsNewWorkFlow_FunctionParams* ptr = stackalloc BP_UpdateInteract_C.__IsNewWorkFlow_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(BP_UpdateInteract_C.__IsNewWorkFlow_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_UpdateInteract_C.__IsNewWorkFlow_NativeFunctionPtr, (void*)ptr, 1);
			ptr->IsNew = IsNew;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_UpdateInteract_C.__IsNewWorkFlow_NativeFunctionPtr, (void*)ptr);
			IsNew = ptr->IsNew;
		}

		// Token: 0x0601F811 RID: 129041 RVA: 0x008BA664 File Offset: 0x008B8864
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void TSUpdateGachaResult_deprecated_(E_GachaResultNew GachaResults)
		{
			BP_UpdateInteract_C.__TSUpdateGachaResult_deprecated__FunctionParams* ptr = stackalloc BP_UpdateInteract_C.__TSUpdateGachaResult_deprecated__FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(BP_UpdateInteract_C.__TSUpdateGachaResult_deprecated__FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_UpdateInteract_C.__TSUpdateGachaResult_deprecated__NativeFunctionPtr, (void*)ptr, 1);
			ptr->GachaResults = GachaResults;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_UpdateInteract_C.__TSUpdateGachaResult_deprecated__NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601F812 RID: 129042 RVA: 0x008BA6AF File Offset: 0x008B88AF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_UpdateInteract_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601F813 RID: 129043 RVA: 0x008BA6C3 File Offset: 0x008B88C3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_UpdateInteract_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601F814 RID: 129044 RVA: 0x008BA6D8 File Offset: 0x008B88D8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Sanhua()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_UpdateInteract_C.__Sanhua_NativeFunctionPtr, null);
		}

		// Token: 0x0601F815 RID: 129045 RVA: 0x008BA6EC File Offset: 0x008B88EC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Taoqi()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_UpdateInteract_C.__Taoqi_NativeFunctionPtr, null);
		}

		// Token: 0x0601F816 RID: 129046 RVA: 0x008BA700 File Offset: 0x008B8900
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Yangyang()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_UpdateInteract_C.__Yangyang_NativeFunctionPtr, null);
		}

		// Token: 0x0601F817 RID: 129047 RVA: 0x008BA714 File Offset: 0x008B8914
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Yuanwu()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_UpdateInteract_C.__Yuanwu_NativeFunctionPtr, null);
		}

		// Token: 0x0601F818 RID: 129048 RVA: 0x008BA728 File Offset: 0x008B8928
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Kakaluo()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_UpdateInteract_C.__Kakaluo_NativeFunctionPtr, null);
		}

		// Token: 0x0601F819 RID: 129049 RVA: 0x008BA73C File Offset: 0x008B893C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Awu()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_UpdateInteract_C.__Awu_NativeFunctionPtr, null);
		}

		// Token: 0x0601F81A RID: 129050 RVA: 0x008BA750 File Offset: 0x008B8950
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Yinlin()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_UpdateInteract_C.__Yinlin_NativeFunctionPtr, null);
		}

		// Token: 0x0601F81B RID: 129051 RVA: 0x008BA764 File Offset: 0x008B8964
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Anke()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_UpdateInteract_C.__Anke_NativeFunctionPtr, null);
		}

		// Token: 0x0601F81C RID: 129052 RVA: 0x008BA778 File Offset: 0x008B8978
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void CharacterGolden()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_UpdateInteract_C.__CharacterGolden_NativeFunctionPtr, null);
		}

		// Token: 0x0601F81D RID: 129053 RVA: 0x008BA78C File Offset: 0x008B898C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void CharacterPurple()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_UpdateInteract_C.__CharacterPurple_NativeFunctionPtr, null);
		}

		// Token: 0x0601F81E RID: 129054 RVA: 0x008BA7A0 File Offset: 0x008B89A0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void WeaponGolden()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_UpdateInteract_C.__WeaponGolden_NativeFunctionPtr, null);
		}

		// Token: 0x0601F81F RID: 129055 RVA: 0x008BA7B4 File Offset: 0x008B89B4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void WeaponPurple()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_UpdateInteract_C.__WeaponPurple_NativeFunctionPtr, null);
		}

		// Token: 0x0601F820 RID: 129056 RVA: 0x008BA7C8 File Offset: 0x008B89C8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void WeaponNormal()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_UpdateInteract_C.__WeaponNormal_NativeFunctionPtr, null);
		}

		// Token: 0x0601F821 RID: 129057 RVA: 0x008BA7DC File Offset: 0x008B89DC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_UpdateInteract_C.__EditorTick_FunctionParams* ptr = stackalloc BP_UpdateInteract_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_UpdateInteract_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_UpdateInteract_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_UpdateInteract_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601F822 RID: 129058 RVA: 0x008BA824 File Offset: 0x008B8A24
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_UpdateInteract_C.__EditorTick_FunctionParams* ptr = stackalloc BP_UpdateInteract_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_UpdateInteract_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_UpdateInteract_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_UpdateInteract_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601F823 RID: 129059 RVA: 0x008BA86C File Offset: 0x008B8A6C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_UpdateInteract_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_UpdateInteract_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_UpdateInteract_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_UpdateInteract_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_UpdateInteract_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601F824 RID: 129060 RVA: 0x008BA8B4 File Offset: 0x008B8AB4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_UpdateInteract_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_UpdateInteract_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_UpdateInteract_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_UpdateInteract_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_UpdateInteract_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601F825 RID: 129061 RVA: 0x008BA8FB File Offset: 0x008B8AFB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_UpdateInteract_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601F826 RID: 129062 RVA: 0x008BA90F File Offset: 0x008B8B0F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_UpdateInteract_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601F827 RID: 129063 RVA: 0x008BA924 File Offset: 0x008B8B24
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Qiushui()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_UpdateInteract_C.__Qiushui_NativeFunctionPtr, null);
		}

		// Token: 0x0601F828 RID: 129064 RVA: 0x008BA938 File Offset: 0x008B8B38
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Micai()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_UpdateInteract_C.__Micai_NativeFunctionPtr, null);
		}

		// Token: 0x0601F829 RID: 129065 RVA: 0x008BA94C File Offset: 0x008B8B4C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Maxiaofang()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_UpdateInteract_C.__Maxiaofang_NativeFunctionPtr, null);
		}

		// Token: 0x0601F82A RID: 129066 RVA: 0x008BA960 File Offset: 0x008B8B60
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Jianxin()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_UpdateInteract_C.__Jianxin_NativeFunctionPtr, null);
		}

		// Token: 0x0601F82B RID: 129067 RVA: 0x008BA974 File Offset: 0x008B8B74
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Bailian()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_UpdateInteract_C.__Bailian_NativeFunctionPtr, null);
		}

		// Token: 0x0601F82C RID: 129068 RVA: 0x008BA988 File Offset: 0x008B8B88
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Baer()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_UpdateInteract_C.__Baer_NativeFunctionPtr, null);
		}

		// Token: 0x0601F82D RID: 129069 RVA: 0x008BA99C File Offset: 0x008B8B9C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void UpdateGachaShowItem(int ID, byte GachaResults)
		{
			BP_UpdateInteract_C.__UpdateGachaShowItem_FunctionParams* ptr = stackalloc BP_UpdateInteract_C.__UpdateGachaShowItem_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_UpdateInteract_C.__UpdateGachaShowItem_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_UpdateInteract_C.__UpdateGachaShowItem_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ID = ID;
			ptr->GachaResults = GachaResults;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_UpdateInteract_C.__UpdateGachaShowItem_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601F82E RID: 129070 RVA: 0x008BA9EC File Offset: 0x008B8BEC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void HiddenShowDownParticles(bool Show_)
		{
			BP_UpdateInteract_C.__HiddenShowDownParticles_FunctionParams* ptr = stackalloc BP_UpdateInteract_C.__HiddenShowDownParticles_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_UpdateInteract_C.__HiddenShowDownParticles_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_UpdateInteract_C.__HiddenShowDownParticles_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Show_ = Show_;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_UpdateInteract_C.__HiddenShowDownParticles_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601F82F RID: 129071 RVA: 0x008BAA34 File Offset: 0x008B8C34
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void HiddenShowUpParticles(bool Show_)
		{
			BP_UpdateInteract_C.__HiddenShowUpParticles_FunctionParams* ptr = stackalloc BP_UpdateInteract_C.__HiddenShowUpParticles_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_UpdateInteract_C.__HiddenShowUpParticles_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_UpdateInteract_C.__HiddenShowUpParticles_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Show_ = Show_;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_UpdateInteract_C.__HiddenShowUpParticles_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601F830 RID: 129072 RVA: 0x008BAA7A File Offset: 0x008B8C7A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void EndGachaScene()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_UpdateInteract_C.__EndGachaScene_NativeFunctionPtr, null);
		}

		// Token: 0x0601F831 RID: 129073 RVA: 0x008BAA8E File Offset: 0x008B8C8E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Jiyan()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_UpdateInteract_C.__Jiyan_NativeFunctionPtr, null);
		}

		// Token: 0x0601F832 RID: 129074 RVA: 0x008BAAA2 File Offset: 0x008B8CA2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Chun()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_UpdateInteract_C.__Chun_NativeFunctionPtr, null);
		}

		// Token: 0x0601F833 RID: 129075 RVA: 0x008BAAB6 File Offset: 0x008B8CB6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateGacha()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_UpdateInteract_C.__UpdateGacha_NativeFunctionPtr, null);
		}

		// Token: 0x0601F834 RID: 129076 RVA: 0x008BAACA File Offset: 0x008B8CCA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Jueyuan()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_UpdateInteract_C.__Jueyuan_NativeFunctionPtr, null);
		}

		// Token: 0x0601F835 RID: 129077 RVA: 0x008BAADE File Offset: 0x008B8CDE
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Jinxi()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_UpdateInteract_C.__Jinxi_NativeFunctionPtr, null);
		}

		// Token: 0x0601F836 RID: 129078 RVA: 0x008BAAF2 File Offset: 0x008B8CF2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Changli()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_UpdateInteract_C.__Changli_NativeFunctionPtr, null);
		}

		// Token: 0x0601F837 RID: 129079 RVA: 0x008BAB06 File Offset: 0x008B8D06
		protected BP_UpdateInteract_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F200 RID: 61952
		public new const string __ObjectPath = "/Game/Aki/Scene/NewGacha/BP/BP_UpdateInteract.BP_UpdateInteract_C";

		// Token: 0x0400F201 RID: 61953
		private static IntPtr _ClassPtr;

		// Token: 0x0400F202 RID: 61954
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F203 RID: 61955
		public static IntPtr __ResultMain__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400F204 RID: 61956
		public static IntPtr __ResultChangli__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400F205 RID: 61957
		public static IntPtr __ResultJinxi__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400F206 RID: 61958
		public static IntPtr __ResultYuanwu__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400F207 RID: 61959
		public static IntPtr __ResultYangyang__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400F208 RID: 61960
		public static IntPtr __ResultTaoqi__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400F209 RID: 61961
		public static IntPtr __ResultSanhua__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400F20A RID: 61962
		public static IntPtr __ResultQiushui__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400F20B RID: 61963
		public static IntPtr __ResultMicai__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400F20C RID: 61964
		public static IntPtr __ResultMaxiaofang__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400F20D RID: 61965
		public static IntPtr __ResultJianxin__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400F20E RID: 61966
		public static IntPtr __ResultBailian__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400F20F RID: 61967
		public static IntPtr __ResultBaer__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400F210 RID: 61968
		public static IntPtr __ResultJueyuan__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400F211 RID: 61969
		public static IntPtr __ResultJiyan__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400F212 RID: 61970
		public static IntPtr __ResultChun__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400F213 RID: 61971
		public static IntPtr __ResultKakaluo__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400F214 RID: 61972
		public static IntPtr __ResultAwu__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400F215 RID: 61973
		public static IntPtr __ResultAnke__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400F216 RID: 61974
		public static IntPtr __ResultYinlin__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400F217 RID: 61975
		public static IntPtr __ResultCharacterGolden__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400F218 RID: 61976
		public static IntPtr __ResultCharacterPurple__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400F219 RID: 61977
		public static IntPtr __ResultWeaponGolden__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400F21A RID: 61978
		public static IntPtr __ResultWeaponPurple__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400F21B RID: 61979
		public static IntPtr __ResultWeaponNormal__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400F21C RID: 61980
		internal static int __PropertyOffset_1;

		// Token: 0x0400F21D RID: 61981
		internal static int __PropertyOffset_2;

		// Token: 0x0400F21E RID: 61982
		internal static int __PropertyOffset_3;

		// Token: 0x0400F21F RID: 61983
		internal static int __PropertyOffset_4;

		// Token: 0x0400F220 RID: 61984
		internal static int __PropertyOffset_5;

		// Token: 0x0400F221 RID: 61985
		internal static int __PropertyOffset_6;

		// Token: 0x0400F222 RID: 61986
		internal static int __PropertyOffset_7;

		// Token: 0x0400F223 RID: 61987
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<ANiagaraActor> _AwardParticles;

		// Token: 0x0400F224 RID: 61988
		internal static int __PropertyOffset_8;

		// Token: 0x0400F225 RID: 61989
		internal static int __PropertyOffset_9;

		// Token: 0x0400F226 RID: 61990
		[Nullable(2)]
		private ResultWeaponNormal _ResultWeaponNormal;

		// Token: 0x0400F227 RID: 61991
		internal static int __PropertyOffset_10;

		// Token: 0x0400F228 RID: 61992
		[Nullable(2)]
		private ResultWeaponPurple _ResultWeaponPurple;

		// Token: 0x0400F229 RID: 61993
		internal static int __PropertyOffset_11;

		// Token: 0x0400F22A RID: 61994
		[Nullable(2)]
		private ResultWeaponGolden _ResultWeaponGolden;

		// Token: 0x0400F22B RID: 61995
		internal static int __PropertyOffset_12;

		// Token: 0x0400F22C RID: 61996
		[Nullable(2)]
		private TMap<int, FLinearColor> _ParticleColor;

		// Token: 0x0400F22D RID: 61997
		internal static int __PropertyOffset_13;

		// Token: 0x0400F22E RID: 61998
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<int, UKuroWeatherDataAsset> _DataAsset;

		// Token: 0x0400F22F RID: 61999
		internal static int __PropertyOffset_14;

		// Token: 0x0400F230 RID: 62000
		internal static int __PropertyOffset_15;

		// Token: 0x0400F231 RID: 62001
		internal static int __PropertyOffset_16;

		// Token: 0x0400F232 RID: 62002
		[Nullable(2)]
		private ResultCharacterPurple _ResultCharacterPurple;

		// Token: 0x0400F233 RID: 62003
		internal static int __PropertyOffset_17;

		// Token: 0x0400F234 RID: 62004
		[Nullable(2)]
		private ResultCharacterGolden _ResultCharacterGolden;

		// Token: 0x0400F235 RID: 62005
		internal static int __PropertyOffset_18;

		// Token: 0x0400F236 RID: 62006
		[Nullable(2)]
		private ResultYinlin _ResultYinlin;

		// Token: 0x0400F237 RID: 62007
		internal static int __PropertyOffset_19;

		// Token: 0x0400F238 RID: 62008
		[Nullable(2)]
		private ResultAnke _ResultAnke;

		// Token: 0x0400F239 RID: 62009
		internal static int __PropertyOffset_20;

		// Token: 0x0400F23A RID: 62010
		[Nullable(2)]
		private ResultAwu _ResultAwu;

		// Token: 0x0400F23B RID: 62011
		internal static int __PropertyOffset_21;

		// Token: 0x0400F23C RID: 62012
		[Nullable(2)]
		private ResultKakaluo _ResultKakaluo;

		// Token: 0x0400F23D RID: 62013
		internal static int __PropertyOffset_22;

		// Token: 0x0400F23E RID: 62014
		[Nullable(2)]
		private ResultChun _ResultChun;

		// Token: 0x0400F23F RID: 62015
		internal static int __PropertyOffset_23;

		// Token: 0x0400F240 RID: 62016
		[Nullable(2)]
		private ResultJiyan _ResultJiyan;

		// Token: 0x0400F241 RID: 62017
		internal static int __PropertyOffset_24;

		// Token: 0x0400F242 RID: 62018
		[Nullable(2)]
		private ResultJueyuan _ResultJueyuan;

		// Token: 0x0400F243 RID: 62019
		internal static int __PropertyOffset_25;

		// Token: 0x0400F244 RID: 62020
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AActor> _ChangeHiddenObject;

		// Token: 0x0400F245 RID: 62021
		internal static int __PropertyOffset_26;

		// Token: 0x0400F246 RID: 62022
		[Nullable(2)]
		private TMap<int, bool> _MeshHidden;

		// Token: 0x0400F247 RID: 62023
		internal static int __PropertyOffset_27;

		// Token: 0x0400F248 RID: 62024
		internal static int __PropertyOffset_28;

		// Token: 0x0400F249 RID: 62025
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<ANiagaraActor> _CharacterHiddenParticles;

		// Token: 0x0400F24A RID: 62026
		internal static int __PropertyOffset_29;

		// Token: 0x0400F24B RID: 62027
		internal static int __PropertyOffset_30;

		// Token: 0x0400F24C RID: 62028
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<ANiagaraActor> _UpParticles;

		// Token: 0x0400F24D RID: 62029
		internal static int __PropertyOffset_31;

		// Token: 0x0400F24E RID: 62030
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<ANiagaraActor> _DownParticles;

		// Token: 0x0400F24F RID: 62031
		internal static int __PropertyOffset_32;

		// Token: 0x0400F250 RID: 62032
		internal static int __PropertyOffset_33;

		// Token: 0x0400F251 RID: 62033
		[Nullable(2)]
		private ResultBaer _ResultBaer;

		// Token: 0x0400F252 RID: 62034
		internal static int __PropertyOffset_34;

		// Token: 0x0400F253 RID: 62035
		[Nullable(2)]
		private ResultBailian _ResultBailian;

		// Token: 0x0400F254 RID: 62036
		internal static int __PropertyOffset_35;

		// Token: 0x0400F255 RID: 62037
		[Nullable(2)]
		private ResultJianxin _ResultJianxin;

		// Token: 0x0400F256 RID: 62038
		internal static int __PropertyOffset_36;

		// Token: 0x0400F257 RID: 62039
		[Nullable(2)]
		private ResultMaxiaofang _ResultMaxiaofang;

		// Token: 0x0400F258 RID: 62040
		internal static int __PropertyOffset_37;

		// Token: 0x0400F259 RID: 62041
		[Nullable(2)]
		private ResultMicai _ResultMicai;

		// Token: 0x0400F25A RID: 62042
		internal static int __PropertyOffset_38;

		// Token: 0x0400F25B RID: 62043
		[Nullable(2)]
		private ResultQiushui _ResultQiushui;

		// Token: 0x0400F25C RID: 62044
		internal static int __PropertyOffset_39;

		// Token: 0x0400F25D RID: 62045
		[Nullable(2)]
		private ResultSanhua _ResultSanhua;

		// Token: 0x0400F25E RID: 62046
		internal static int __PropertyOffset_40;

		// Token: 0x0400F25F RID: 62047
		[Nullable(2)]
		private ResultTaoqi _ResultTaoqi;

		// Token: 0x0400F260 RID: 62048
		internal static int __PropertyOffset_41;

		// Token: 0x0400F261 RID: 62049
		[Nullable(2)]
		private ResultYangyang _ResultYangyang;

		// Token: 0x0400F262 RID: 62050
		internal static int __PropertyOffset_42;

		// Token: 0x0400F263 RID: 62051
		[Nullable(2)]
		private ResultYuanwu _ResultYuanwu;

		// Token: 0x0400F264 RID: 62052
		internal static int __PropertyOffset_43;

		// Token: 0x0400F265 RID: 62053
		internal static int __PropertyOffset_44;

		// Token: 0x0400F266 RID: 62054
		internal static int __PropertyOffset_45;

		// Token: 0x0400F267 RID: 62055
		[Nullable(2)]
		private ResultJinxi _ResultJinxi;

		// Token: 0x0400F268 RID: 62056
		internal static int __PropertyOffset_46;

		// Token: 0x0400F269 RID: 62057
		[Nullable(2)]
		private ResultChangli _ResultChangli;

		// Token: 0x0400F26A RID: 62058
		internal static int __PropertyOffset_47;

		// Token: 0x0400F26B RID: 62059
		[Nullable(2)]
		private ResultMain _ResultMain;

		// Token: 0x0400F26C RID: 62060
		internal static int __PropertyOffset_48;

		// Token: 0x0400F26D RID: 62061
		private static IntPtr __QualityColorModification_NativeFunctionPtr;

		// Token: 0x0400F26E RID: 62062
		private static IntPtr __IsNewWorkFlow_NativeFunctionPtr;

		// Token: 0x0400F26F RID: 62063
		private static IntPtr __TSUpdateGachaResult_deprecated__NativeFunctionPtr;

		// Token: 0x0400F270 RID: 62064
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0400F271 RID: 62065
		private static IntPtr __Sanhua_NativeFunctionPtr;

		// Token: 0x0400F272 RID: 62066
		private static IntPtr __Taoqi_NativeFunctionPtr;

		// Token: 0x0400F273 RID: 62067
		private static IntPtr __Yangyang_NativeFunctionPtr;

		// Token: 0x0400F274 RID: 62068
		private static IntPtr __Yuanwu_NativeFunctionPtr;

		// Token: 0x0400F275 RID: 62069
		private static IntPtr __Kakaluo_NativeFunctionPtr;

		// Token: 0x0400F276 RID: 62070
		private static IntPtr __Awu_NativeFunctionPtr;

		// Token: 0x0400F277 RID: 62071
		private static IntPtr __Yinlin_NativeFunctionPtr;

		// Token: 0x0400F278 RID: 62072
		private static IntPtr __Anke_NativeFunctionPtr;

		// Token: 0x0400F279 RID: 62073
		private static IntPtr __CharacterGolden_NativeFunctionPtr;

		// Token: 0x0400F27A RID: 62074
		private static IntPtr __CharacterPurple_NativeFunctionPtr;

		// Token: 0x0400F27B RID: 62075
		private static IntPtr __WeaponGolden_NativeFunctionPtr;

		// Token: 0x0400F27C RID: 62076
		private static IntPtr __WeaponPurple_NativeFunctionPtr;

		// Token: 0x0400F27D RID: 62077
		private static IntPtr __WeaponNormal_NativeFunctionPtr;

		// Token: 0x0400F27E RID: 62078
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x0400F27F RID: 62079
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0400F280 RID: 62080
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0400F281 RID: 62081
		private static IntPtr __Qiushui_NativeFunctionPtr;

		// Token: 0x0400F282 RID: 62082
		private static IntPtr __Micai_NativeFunctionPtr;

		// Token: 0x0400F283 RID: 62083
		private static IntPtr __Maxiaofang_NativeFunctionPtr;

		// Token: 0x0400F284 RID: 62084
		private static IntPtr __Jianxin_NativeFunctionPtr;

		// Token: 0x0400F285 RID: 62085
		private static IntPtr __Bailian_NativeFunctionPtr;

		// Token: 0x0400F286 RID: 62086
		private static IntPtr __Baer_NativeFunctionPtr;

		// Token: 0x0400F287 RID: 62087
		private static IntPtr __UpdateGachaShowItem_NativeFunctionPtr;

		// Token: 0x0400F288 RID: 62088
		private static IntPtr __HiddenShowDownParticles_NativeFunctionPtr;

		// Token: 0x0400F289 RID: 62089
		private static IntPtr __HiddenShowUpParticles_NativeFunctionPtr;

		// Token: 0x0400F28A RID: 62090
		private static IntPtr __EndGachaScene_NativeFunctionPtr;

		// Token: 0x0400F28B RID: 62091
		private static IntPtr __Jiyan_NativeFunctionPtr;

		// Token: 0x0400F28C RID: 62092
		private static IntPtr __Chun_NativeFunctionPtr;

		// Token: 0x0400F28D RID: 62093
		private static IntPtr __UpdateGacha_NativeFunctionPtr;

		// Token: 0x0400F28E RID: 62094
		private static IntPtr __Jueyuan_NativeFunctionPtr;

		// Token: 0x0400F28F RID: 62095
		private static IntPtr __Jinxi_NativeFunctionPtr;

		// Token: 0x0400F290 RID: 62096
		private static IntPtr __Changli_NativeFunctionPtr;

		// Token: 0x02009AEC RID: 39660
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 176)]
		protected ref struct __QualityColorModification_FunctionParams
		{
			// Token: 0x040310BC RID: 200892
			[FieldOffset(0)]
			public TEnumAsByte<E_GachaResultFinal> GachaResult;

			// Token: 0x040310BD RID: 200893
			[FieldOffset(4)]
			public int ID;

			// Token: 0x040310BE RID: 200894
			[FieldOffset(8)]
			public bool IsCharacter;
		}

		// Token: 0x02009AED RID: 39661
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __IsNewWorkFlow_FunctionParams
		{
			// Token: 0x040310BF RID: 200895
			[FieldOffset(0)]
			public bool IsNew;
		}

		// Token: 0x02009AEE RID: 39662
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __TSUpdateGachaResult_deprecated__FunctionParams
		{
			// Token: 0x040310C0 RID: 200896
			[FieldOffset(0)]
			public TEnumAsByte<E_GachaResultNew> GachaResults;
		}

		// Token: 0x02009AEF RID: 39663
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x040310C1 RID: 200897
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009AF0 RID: 39664
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040310C2 RID: 200898
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009AF1 RID: 39665
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __UpdateGachaShowItem_FunctionParams
		{
			// Token: 0x040310C3 RID: 200899
			[FieldOffset(0)]
			public int ID;

			// Token: 0x040310C4 RID: 200900
			[FieldOffset(4)]
			public byte GachaResults;
		}

		// Token: 0x02009AF2 RID: 39666
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __HiddenShowDownParticles_FunctionParams
		{
			// Token: 0x040310C5 RID: 200901
			[FieldOffset(0)]
			public bool Show_;
		}

		// Token: 0x02009AF3 RID: 39667
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __HiddenShowUpParticles_FunctionParams
		{
			// Token: 0x040310C6 RID: 200902
			[FieldOffset(0)]
			public bool Show_;
		}
	}
}

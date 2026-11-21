using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Scene.NewGacha.BP
{
	// Token: 0x02003087 RID: 12423
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Scene/NewGacha/BP/BP_UpdateInteract.BP_UpdateInteract_C")]
	[UnrealStructLayout(2320, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2313)]
	public class BP_UpdateInteract_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601DAA2 RID: 121506 RVA: 0x008FE3BC File Offset: 0x008FC5BC
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_UpdateInteract_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Scene/NewGacha/BP/BP_UpdateInteract.BP_UpdateInteract_C");
			}
			return BP_UpdateInteract_C._ClassPtr;
		}

		// Token: 0x0601DAA3 RID: 121507 RVA: 0x008FE3E0 File Offset: 0x008FC5E0
		public BP_UpdateInteract_C() : this(BuiltinUtils.AllocNativeUObject(BP_UpdateInteract_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601DAA4 RID: 121508 RVA: 0x008FE408 File Offset: 0x008FC608
		public BP_UpdateInteract_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_UpdateInteract_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003005 RID: 12293
		// (get) Token: 0x0601DAA5 RID: 121509 RVA: 0x008FE43B File Offset: 0x008FC63B
		// (set) Token: 0x0601DAA6 RID: 121510 RVA: 0x008FE44F File Offset: 0x008FC64F
		[Nullable(2)]
		public unsafe UKuroPostProcessComponent KuroPostProcess
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroPostProcessComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_UpdateInteract_C.__PropertyOffset_KuroPostProcess);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_UpdateInteract_C.__PropertyOffset_KuroPostProcess, value);
			}
		}

		// Token: 0x17003006 RID: 12294
		// (get) Token: 0x0601DAA7 RID: 121511 RVA: 0x008FE464 File Offset: 0x008FC664
		// (set) Token: 0x0601DAA8 RID: 121512 RVA: 0x008FE478 File Offset: 0x008FC678
		[Nullable(2)]
		public unsafe UBoxComponent Box
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_UpdateInteract_C.__PropertyOffset_Box);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_UpdateInteract_C.__PropertyOffset_Box, value);
			}
		}

		// Token: 0x17003007 RID: 12295
		// (get) Token: 0x0601DAA9 RID: 121513 RVA: 0x008FE48D File Offset: 0x008FC68D
		// (set) Token: 0x0601DAAA RID: 121514 RVA: 0x008FE4A1 File Offset: 0x008FC6A1
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_UpdateInteract_C.__PropertyOffset_DefaultSceneRoot);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_UpdateInteract_C.__PropertyOffset_DefaultSceneRoot, value);
			}
		}

		// Token: 0x17003008 RID: 12296
		// (get) Token: 0x0601DAAB RID: 121515 RVA: 0x008FE4B6 File Offset: 0x008FC6B6
		// (set) Token: 0x0601DAAC RID: 121516 RVA: 0x008FE4CA File Offset: 0x008FC6CA
		[Nullable(0)]
		public unsafe TEnumAsByte<E_GachaResultNew> GachaResults
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_GachaResults);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_GachaResults) = value;
			}
		}

		// Token: 0x17003009 RID: 12297
		// (get) Token: 0x0601DAAD RID: 121517 RVA: 0x008FE4DF File Offset: 0x008FC6DF
		// (set) Token: 0x0601DAAE RID: 121518 RVA: 0x008FE4F3 File Offset: 0x008FC6F3
		public unsafe FLinearColor NormalColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_NormalColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_NormalColor) = value;
			}
		}

		// Token: 0x1700300A RID: 12298
		// (get) Token: 0x0601DAAF RID: 121519 RVA: 0x008FE508 File Offset: 0x008FC708
		// (set) Token: 0x0601DAB0 RID: 121520 RVA: 0x008FE51C File Offset: 0x008FC71C
		public unsafe FLinearColor PurpleColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_PurpleColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_PurpleColor) = value;
			}
		}

		// Token: 0x1700300B RID: 12299
		// (get) Token: 0x0601DAB1 RID: 121521 RVA: 0x008FE534 File Offset: 0x008FC734
		// (set) Token: 0x0601DAB2 RID: 121522 RVA: 0x008FE56D File Offset: 0x008FC76D
		public TArray<ANiagaraActor> AwardParticles
		{
			get
			{
				base.FastCheckIsValid();
				TArray<ANiagaraActor> result;
				if ((result = this._AwardParticles) == null)
				{
					result = (this._AwardParticles = new TArray<ANiagaraActor>(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_AwardParticles, this));
				}
				return result;
			}
			set
			{
				this.AwardParticles.CopyAssign(value);
			}
		}

		// Token: 0x1700300C RID: 12300
		// (get) Token: 0x0601DAB3 RID: 121523 RVA: 0x008FE57B File Offset: 0x008FC77B
		// (set) Token: 0x0601DAB4 RID: 121524 RVA: 0x008FE58F File Offset: 0x008FC78F
		public unsafe FLinearColor GoldColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_GoldColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_GoldColor) = value;
			}
		}

		// Token: 0x1700300D RID: 12301
		// (get) Token: 0x0601DAB5 RID: 121525 RVA: 0x008FE5A4 File Offset: 0x008FC7A4
		// (set) Token: 0x0601DAB6 RID: 121526 RVA: 0x008FE5DD File Offset: 0x008FC7DD
		public ResultWeaponNormal ResultWeaponNormal
		{
			get
			{
				base.FastCheckIsValid();
				ResultWeaponNormal result;
				if ((result = this._ResultWeaponNormal) == null)
				{
					result = (this._ResultWeaponNormal = new ResultWeaponNormal(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_ResultWeaponNormal, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_ResultWeaponNormal, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700300E RID: 12302
		// (get) Token: 0x0601DAB7 RID: 121527 RVA: 0x008FE600 File Offset: 0x008FC800
		// (set) Token: 0x0601DAB8 RID: 121528 RVA: 0x008FE639 File Offset: 0x008FC839
		public ResultWeaponPurple ResultWeaponPurple
		{
			get
			{
				base.FastCheckIsValid();
				ResultWeaponPurple result;
				if ((result = this._ResultWeaponPurple) == null)
				{
					result = (this._ResultWeaponPurple = new ResultWeaponPurple(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_ResultWeaponPurple, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_ResultWeaponPurple, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700300F RID: 12303
		// (get) Token: 0x0601DAB9 RID: 121529 RVA: 0x008FE65C File Offset: 0x008FC85C
		// (set) Token: 0x0601DABA RID: 121530 RVA: 0x008FE695 File Offset: 0x008FC895
		public ResultWeaponGolden ResultWeaponGolden
		{
			get
			{
				base.FastCheckIsValid();
				ResultWeaponGolden result;
				if ((result = this._ResultWeaponGolden) == null)
				{
					result = (this._ResultWeaponGolden = new ResultWeaponGolden(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_ResultWeaponGolden, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_ResultWeaponGolden, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17003010 RID: 12304
		// (get) Token: 0x0601DABB RID: 121531 RVA: 0x008FE6B8 File Offset: 0x008FC8B8
		// (set) Token: 0x0601DABC RID: 121532 RVA: 0x008FE6F1 File Offset: 0x008FC8F1
		public TMap<int, FLinearColor> ParticleColor
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, FLinearColor> result;
				if ((result = this._ParticleColor) == null)
				{
					result = (this._ParticleColor = new TMap<int, FLinearColor>(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_ParticleColor, this));
				}
				return result;
			}
			set
			{
				this.ParticleColor.CopyAssign(value);
			}
		}

		// Token: 0x17003011 RID: 12305
		// (get) Token: 0x0601DABD RID: 121533 RVA: 0x008FE700 File Offset: 0x008FC900
		// (set) Token: 0x0601DABE RID: 121534 RVA: 0x008FE739 File Offset: 0x008FC939
		public TMap<int, UKuroWeatherDataAsset> DataAsset
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, UKuroWeatherDataAsset> result;
				if ((result = this._DataAsset) == null)
				{
					result = (this._DataAsset = new TMap<int, UKuroWeatherDataAsset>(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_DataAsset, this));
				}
				return result;
			}
			set
			{
				this.DataAsset.CopyAssign(value);
			}
		}

		// Token: 0x17003012 RID: 12306
		// (get) Token: 0x0601DABF RID: 121535 RVA: 0x008FE747 File Offset: 0x008FC947
		// (set) Token: 0x0601DAC0 RID: 121536 RVA: 0x008FE75B File Offset: 0x008FC95B
		public unsafe FLinearColor ParticleColorFinal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_ParticleColorFinal);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_ParticleColorFinal) = value;
			}
		}

		// Token: 0x17003013 RID: 12307
		// (get) Token: 0x0601DAC1 RID: 121537 RVA: 0x008FE770 File Offset: 0x008FC970
		// (set) Token: 0x0601DAC2 RID: 121538 RVA: 0x008FE784 File Offset: 0x008FC984
		[Nullable(0)]
		public unsafe TEnumAsByte<E_GachaResultFinal> GachaResultForShow
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_GachaResultForShow);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_GachaResultForShow) = value;
			}
		}

		// Token: 0x17003014 RID: 12308
		// (get) Token: 0x0601DAC3 RID: 121539 RVA: 0x008FE79C File Offset: 0x008FC99C
		// (set) Token: 0x0601DAC4 RID: 121540 RVA: 0x008FE7D5 File Offset: 0x008FC9D5
		public ResultCharacterPurple ResultCharacterPurple
		{
			get
			{
				base.FastCheckIsValid();
				ResultCharacterPurple result;
				if ((result = this._ResultCharacterPurple) == null)
				{
					result = (this._ResultCharacterPurple = new ResultCharacterPurple(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_ResultCharacterPurple, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_ResultCharacterPurple, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17003015 RID: 12309
		// (get) Token: 0x0601DAC5 RID: 121541 RVA: 0x008FE7F8 File Offset: 0x008FC9F8
		// (set) Token: 0x0601DAC6 RID: 121542 RVA: 0x008FE831 File Offset: 0x008FCA31
		public ResultCharacterGolden ResultCharacterGolden
		{
			get
			{
				base.FastCheckIsValid();
				ResultCharacterGolden result;
				if ((result = this._ResultCharacterGolden) == null)
				{
					result = (this._ResultCharacterGolden = new ResultCharacterGolden(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_ResultCharacterGolden, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_ResultCharacterGolden, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17003016 RID: 12310
		// (get) Token: 0x0601DAC7 RID: 121543 RVA: 0x008FE854 File Offset: 0x008FCA54
		// (set) Token: 0x0601DAC8 RID: 121544 RVA: 0x008FE88D File Offset: 0x008FCA8D
		public ResultYinlin ResultYinlin
		{
			get
			{
				base.FastCheckIsValid();
				ResultYinlin result;
				if ((result = this._ResultYinlin) == null)
				{
					result = (this._ResultYinlin = new ResultYinlin(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_ResultYinlin, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_ResultYinlin, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17003017 RID: 12311
		// (get) Token: 0x0601DAC9 RID: 121545 RVA: 0x008FE8B0 File Offset: 0x008FCAB0
		// (set) Token: 0x0601DACA RID: 121546 RVA: 0x008FE8E9 File Offset: 0x008FCAE9
		public ResultAnke ResultAnke
		{
			get
			{
				base.FastCheckIsValid();
				ResultAnke result;
				if ((result = this._ResultAnke) == null)
				{
					result = (this._ResultAnke = new ResultAnke(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_ResultAnke, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_ResultAnke, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17003018 RID: 12312
		// (get) Token: 0x0601DACB RID: 121547 RVA: 0x008FE90C File Offset: 0x008FCB0C
		// (set) Token: 0x0601DACC RID: 121548 RVA: 0x008FE945 File Offset: 0x008FCB45
		public ResultAwu ResultAwu
		{
			get
			{
				base.FastCheckIsValid();
				ResultAwu result;
				if ((result = this._ResultAwu) == null)
				{
					result = (this._ResultAwu = new ResultAwu(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_ResultAwu, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_ResultAwu, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17003019 RID: 12313
		// (get) Token: 0x0601DACD RID: 121549 RVA: 0x008FE968 File Offset: 0x008FCB68
		// (set) Token: 0x0601DACE RID: 121550 RVA: 0x008FE9A1 File Offset: 0x008FCBA1
		public ResultKakaluo ResultKakaluo
		{
			get
			{
				base.FastCheckIsValid();
				ResultKakaluo result;
				if ((result = this._ResultKakaluo) == null)
				{
					result = (this._ResultKakaluo = new ResultKakaluo(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_ResultKakaluo, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_ResultKakaluo, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700301A RID: 12314
		// (get) Token: 0x0601DACF RID: 121551 RVA: 0x008FE9C4 File Offset: 0x008FCBC4
		// (set) Token: 0x0601DAD0 RID: 121552 RVA: 0x008FE9FD File Offset: 0x008FCBFD
		public ResultChun ResultChun
		{
			get
			{
				base.FastCheckIsValid();
				ResultChun result;
				if ((result = this._ResultChun) == null)
				{
					result = (this._ResultChun = new ResultChun(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_ResultChun, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_ResultChun, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700301B RID: 12315
		// (get) Token: 0x0601DAD1 RID: 121553 RVA: 0x008FEA20 File Offset: 0x008FCC20
		// (set) Token: 0x0601DAD2 RID: 121554 RVA: 0x008FEA59 File Offset: 0x008FCC59
		public ResultJiyan ResultJiyan
		{
			get
			{
				base.FastCheckIsValid();
				ResultJiyan result;
				if ((result = this._ResultJiyan) == null)
				{
					result = (this._ResultJiyan = new ResultJiyan(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_ResultJiyan, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_ResultJiyan, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700301C RID: 12316
		// (get) Token: 0x0601DAD3 RID: 121555 RVA: 0x008FEA7C File Offset: 0x008FCC7C
		// (set) Token: 0x0601DAD4 RID: 121556 RVA: 0x008FEAB5 File Offset: 0x008FCCB5
		public ResultJueyuan ResultJueyuan
		{
			get
			{
				base.FastCheckIsValid();
				ResultJueyuan result;
				if ((result = this._ResultJueyuan) == null)
				{
					result = (this._ResultJueyuan = new ResultJueyuan(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_ResultJueyuan, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_ResultJueyuan, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700301D RID: 12317
		// (get) Token: 0x0601DAD5 RID: 121557 RVA: 0x008FEAD8 File Offset: 0x008FCCD8
		// (set) Token: 0x0601DAD6 RID: 121558 RVA: 0x008FEB11 File Offset: 0x008FCD11
		public TArray<AActor> ChangeHiddenObject
		{
			get
			{
				base.FastCheckIsValid();
				TArray<AActor> result;
				if ((result = this._ChangeHiddenObject) == null)
				{
					result = (this._ChangeHiddenObject = new TArray<AActor>(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_ChangeHiddenObject, this));
				}
				return result;
			}
			set
			{
				this.ChangeHiddenObject.CopyAssign(value);
			}
		}

		// Token: 0x1700301E RID: 12318
		// (get) Token: 0x0601DAD7 RID: 121559 RVA: 0x008FEB20 File Offset: 0x008FCD20
		// (set) Token: 0x0601DAD8 RID: 121560 RVA: 0x008FEB59 File Offset: 0x008FCD59
		public TMap<int, bool> MeshHidden
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, bool> result;
				if ((result = this._MeshHidden) == null)
				{
					result = (this._MeshHidden = new TMap<int, bool>(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_MeshHidden, this));
				}
				return result;
			}
			set
			{
				this.MeshHidden.CopyAssign(value);
			}
		}

		// Token: 0x1700301F RID: 12319
		// (get) Token: 0x0601DAD9 RID: 121561 RVA: 0x008FEB67 File Offset: 0x008FCD67
		// (set) Token: 0x0601DADA RID: 121562 RVA: 0x008FEB77 File Offset: 0x008FCD77
		public unsafe bool SceneObjectVisibility
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_SceneObjectVisibility) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_SceneObjectVisibility) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003020 RID: 12320
		// (get) Token: 0x0601DADB RID: 121563 RVA: 0x008FEB88 File Offset: 0x008FCD88
		// (set) Token: 0x0601DADC RID: 121564 RVA: 0x008FEBC1 File Offset: 0x008FCDC1
		public TArray<ANiagaraActor> CharacterHiddenParticles
		{
			get
			{
				base.FastCheckIsValid();
				TArray<ANiagaraActor> result;
				if ((result = this._CharacterHiddenParticles) == null)
				{
					result = (this._CharacterHiddenParticles = new TArray<ANiagaraActor>(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_CharacterHiddenParticles, this));
				}
				return result;
			}
			set
			{
				this.CharacterHiddenParticles.CopyAssign(value);
			}
		}

		// Token: 0x17003021 RID: 12321
		// (get) Token: 0x0601DADD RID: 121565 RVA: 0x008FEBCF File Offset: 0x008FCDCF
		// (set) Token: 0x0601DADE RID: 121566 RVA: 0x008FEBDF File Offset: 0x008FCDDF
		public unsafe bool IsCharacter_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_IsCharacter_) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_IsCharacter_) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003022 RID: 12322
		// (get) Token: 0x0601DADF RID: 121567 RVA: 0x008FEBF0 File Offset: 0x008FCDF0
		// (set) Token: 0x0601DAE0 RID: 121568 RVA: 0x008FEC29 File Offset: 0x008FCE29
		public TArray<ANiagaraActor> UpParticles
		{
			get
			{
				base.FastCheckIsValid();
				TArray<ANiagaraActor> result;
				if ((result = this._UpParticles) == null)
				{
					result = (this._UpParticles = new TArray<ANiagaraActor>(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_UpParticles, this));
				}
				return result;
			}
			set
			{
				this.UpParticles.CopyAssign(value);
			}
		}

		// Token: 0x17003023 RID: 12323
		// (get) Token: 0x0601DAE1 RID: 121569 RVA: 0x008FEC38 File Offset: 0x008FCE38
		// (set) Token: 0x0601DAE2 RID: 121570 RVA: 0x008FEC71 File Offset: 0x008FCE71
		public TArray<ANiagaraActor> DownParticles
		{
			get
			{
				base.FastCheckIsValid();
				TArray<ANiagaraActor> result;
				if ((result = this._DownParticles) == null)
				{
					result = (this._DownParticles = new TArray<ANiagaraActor>(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_DownParticles, this));
				}
				return result;
			}
			set
			{
				this.DownParticles.CopyAssign(value);
			}
		}

		// Token: 0x17003024 RID: 12324
		// (get) Token: 0x0601DAE3 RID: 121571 RVA: 0x008FEC7F File Offset: 0x008FCE7F
		// (set) Token: 0x0601DAE4 RID: 121572 RVA: 0x008FEC8F File Offset: 0x008FCE8F
		public unsafe bool IsEditor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_IsEditor) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_IsEditor) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003025 RID: 12325
		// (get) Token: 0x0601DAE5 RID: 121573 RVA: 0x008FECA0 File Offset: 0x008FCEA0
		// (set) Token: 0x0601DAE6 RID: 121574 RVA: 0x008FECD9 File Offset: 0x008FCED9
		public ResultBaer ResultBaer
		{
			get
			{
				base.FastCheckIsValid();
				ResultBaer result;
				if ((result = this._ResultBaer) == null)
				{
					result = (this._ResultBaer = new ResultBaer(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_ResultBaer, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_ResultBaer, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17003026 RID: 12326
		// (get) Token: 0x0601DAE7 RID: 121575 RVA: 0x008FECFC File Offset: 0x008FCEFC
		// (set) Token: 0x0601DAE8 RID: 121576 RVA: 0x008FED35 File Offset: 0x008FCF35
		public ResultBailian ResultBailian
		{
			get
			{
				base.FastCheckIsValid();
				ResultBailian result;
				if ((result = this._ResultBailian) == null)
				{
					result = (this._ResultBailian = new ResultBailian(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_ResultBailian, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_ResultBailian, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17003027 RID: 12327
		// (get) Token: 0x0601DAE9 RID: 121577 RVA: 0x008FED58 File Offset: 0x008FCF58
		// (set) Token: 0x0601DAEA RID: 121578 RVA: 0x008FED91 File Offset: 0x008FCF91
		public ResultJianxin ResultJianxin
		{
			get
			{
				base.FastCheckIsValid();
				ResultJianxin result;
				if ((result = this._ResultJianxin) == null)
				{
					result = (this._ResultJianxin = new ResultJianxin(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_ResultJianxin, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_ResultJianxin, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17003028 RID: 12328
		// (get) Token: 0x0601DAEB RID: 121579 RVA: 0x008FEDB4 File Offset: 0x008FCFB4
		// (set) Token: 0x0601DAEC RID: 121580 RVA: 0x008FEDED File Offset: 0x008FCFED
		public ResultMaxiaofang ResultMaxiaofang
		{
			get
			{
				base.FastCheckIsValid();
				ResultMaxiaofang result;
				if ((result = this._ResultMaxiaofang) == null)
				{
					result = (this._ResultMaxiaofang = new ResultMaxiaofang(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_ResultMaxiaofang, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_ResultMaxiaofang, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17003029 RID: 12329
		// (get) Token: 0x0601DAED RID: 121581 RVA: 0x008FEE10 File Offset: 0x008FD010
		// (set) Token: 0x0601DAEE RID: 121582 RVA: 0x008FEE49 File Offset: 0x008FD049
		public ResultMicai ResultMicai
		{
			get
			{
				base.FastCheckIsValid();
				ResultMicai result;
				if ((result = this._ResultMicai) == null)
				{
					result = (this._ResultMicai = new ResultMicai(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_ResultMicai, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_ResultMicai, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700302A RID: 12330
		// (get) Token: 0x0601DAEF RID: 121583 RVA: 0x008FEE6C File Offset: 0x008FD06C
		// (set) Token: 0x0601DAF0 RID: 121584 RVA: 0x008FEEA5 File Offset: 0x008FD0A5
		public ResultQiushui ResultQiushui
		{
			get
			{
				base.FastCheckIsValid();
				ResultQiushui result;
				if ((result = this._ResultQiushui) == null)
				{
					result = (this._ResultQiushui = new ResultQiushui(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_ResultQiushui, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_ResultQiushui, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700302B RID: 12331
		// (get) Token: 0x0601DAF1 RID: 121585 RVA: 0x008FEEC8 File Offset: 0x008FD0C8
		// (set) Token: 0x0601DAF2 RID: 121586 RVA: 0x008FEF01 File Offset: 0x008FD101
		public ResultSanhua ResultSanhua
		{
			get
			{
				base.FastCheckIsValid();
				ResultSanhua result;
				if ((result = this._ResultSanhua) == null)
				{
					result = (this._ResultSanhua = new ResultSanhua(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_ResultSanhua, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_ResultSanhua, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700302C RID: 12332
		// (get) Token: 0x0601DAF3 RID: 121587 RVA: 0x008FEF24 File Offset: 0x008FD124
		// (set) Token: 0x0601DAF4 RID: 121588 RVA: 0x008FEF5D File Offset: 0x008FD15D
		public ResultTaoqi ResultTaoqi
		{
			get
			{
				base.FastCheckIsValid();
				ResultTaoqi result;
				if ((result = this._ResultTaoqi) == null)
				{
					result = (this._ResultTaoqi = new ResultTaoqi(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_ResultTaoqi, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_ResultTaoqi, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700302D RID: 12333
		// (get) Token: 0x0601DAF5 RID: 121589 RVA: 0x008FEF80 File Offset: 0x008FD180
		// (set) Token: 0x0601DAF6 RID: 121590 RVA: 0x008FEFB9 File Offset: 0x008FD1B9
		public ResultYangyang ResultYangyang
		{
			get
			{
				base.FastCheckIsValid();
				ResultYangyang result;
				if ((result = this._ResultYangyang) == null)
				{
					result = (this._ResultYangyang = new ResultYangyang(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_ResultYangyang, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_ResultYangyang, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700302E RID: 12334
		// (get) Token: 0x0601DAF7 RID: 121591 RVA: 0x008FEFDC File Offset: 0x008FD1DC
		// (set) Token: 0x0601DAF8 RID: 121592 RVA: 0x008FF015 File Offset: 0x008FD215
		public ResultYuanwu ResultYuanwu
		{
			get
			{
				base.FastCheckIsValid();
				ResultYuanwu result;
				if ((result = this._ResultYuanwu) == null)
				{
					result = (this._ResultYuanwu = new ResultYuanwu(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_ResultYuanwu, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_ResultYuanwu, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700302F RID: 12335
		// (get) Token: 0x0601DAF9 RID: 121593 RVA: 0x008FF036 File Offset: 0x008FD236
		// (set) Token: 0x0601DAFA RID: 121594 RVA: 0x008FF046 File Offset: 0x008FD246
		public unsafe bool IsCallable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_IsCallable) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_IsCallable) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003030 RID: 12336
		// (get) Token: 0x0601DAFB RID: 121595 RVA: 0x008FF057 File Offset: 0x008FD257
		// (set) Token: 0x0601DAFC RID: 121596 RVA: 0x008FF067 File Offset: 0x008FD267
		public unsafe float OriMotionBlur
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_OriMotionBlur);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_OriMotionBlur) = value;
			}
		}

		// Token: 0x17003031 RID: 12337
		// (get) Token: 0x0601DAFD RID: 121597 RVA: 0x008FF078 File Offset: 0x008FD278
		// (set) Token: 0x0601DAFE RID: 121598 RVA: 0x008FF0B1 File Offset: 0x008FD2B1
		public ResultJinxi ResultJinxi
		{
			get
			{
				base.FastCheckIsValid();
				ResultJinxi result;
				if ((result = this._ResultJinxi) == null)
				{
					result = (this._ResultJinxi = new ResultJinxi(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_ResultJinxi, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_ResultJinxi, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17003032 RID: 12338
		// (get) Token: 0x0601DAFF RID: 121599 RVA: 0x008FF0D4 File Offset: 0x008FD2D4
		// (set) Token: 0x0601DB00 RID: 121600 RVA: 0x008FF10D File Offset: 0x008FD30D
		public ResultChangli ResultChangli
		{
			get
			{
				base.FastCheckIsValid();
				ResultChangli result;
				if ((result = this._ResultChangli) == null)
				{
					result = (this._ResultChangli = new ResultChangli(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_ResultChangli, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_ResultChangli, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17003033 RID: 12339
		// (get) Token: 0x0601DB01 RID: 121601 RVA: 0x008FF130 File Offset: 0x008FD330
		// (set) Token: 0x0601DB02 RID: 121602 RVA: 0x008FF169 File Offset: 0x008FD369
		public ResultMain ResultMain
		{
			get
			{
				base.FastCheckIsValid();
				ResultMain result;
				if ((result = this._ResultMain) == null)
				{
					result = (this._ResultMain = new ResultMain(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_ResultMain, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_ResultMain, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17003034 RID: 12340
		// (get) Token: 0x0601DB03 RID: 121603 RVA: 0x008FF18A File Offset: 0x008FD38A
		// (set) Token: 0x0601DB04 RID: 121604 RVA: 0x008FF19A File Offset: 0x008FD39A
		public unsafe bool OpenLerPerFrame
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_OpenLerPerFrame) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_UpdateInteract_C.__PropertyOffset_OpenLerPerFrame) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601DB05 RID: 121605 RVA: 0x008FF1AC File Offset: 0x008FD3AC
		[SkipLocalsInit]
		public unsafe virtual void QualityColorModification(E_GachaResultFinal GachaResult, int ID, bool IsCharacter)
		{
			BP_UpdateInteract_C.__QualityColorModification_FunctionParams* ptr = stackalloc BP_UpdateInteract_C.__QualityColorModification_FunctionParams[(UIntPtr)191] + 15L / (long)sizeof(BP_UpdateInteract_C.__QualityColorModification_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_UpdateInteract_C.__QualityColorModification_NativeFunctionPtr, (void*)ptr, 1);
			ptr->GachaResult = GachaResult;
			ptr->ID = ID;
			ptr->IsCharacter = IsCharacter;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_UpdateInteract_C.__QualityColorModification_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601DB06 RID: 121606 RVA: 0x008FF208 File Offset: 0x008FD408
		[SkipLocalsInit]
		public unsafe virtual void IsNewWorkFlow(ref bool IsNew)
		{
			BP_UpdateInteract_C.__IsNewWorkFlow_FunctionParams* ptr = stackalloc BP_UpdateInteract_C.__IsNewWorkFlow_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(BP_UpdateInteract_C.__IsNewWorkFlow_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_UpdateInteract_C.__IsNewWorkFlow_NativeFunctionPtr, (void*)ptr, 1);
			ptr->IsNew = IsNew;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_UpdateInteract_C.__IsNewWorkFlow_NativeFunctionPtr, (void*)ptr);
			IsNew = ptr->IsNew;
		}

		// Token: 0x0601DB07 RID: 121607 RVA: 0x008FF258 File Offset: 0x008FD458
		[SkipLocalsInit]
		public unsafe virtual void TSUpdateGachaResult_deprecated_(E_GachaResultNew GachaResults)
		{
			BP_UpdateInteract_C.__TSUpdateGachaResult_deprecated__FunctionParams* ptr = stackalloc BP_UpdateInteract_C.__TSUpdateGachaResult_deprecated__FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(BP_UpdateInteract_C.__TSUpdateGachaResult_deprecated__FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_UpdateInteract_C.__TSUpdateGachaResult_deprecated__NativeFunctionPtr, (void*)ptr, 1);
			ptr->GachaResults = GachaResults;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_UpdateInteract_C.__TSUpdateGachaResult_deprecated__NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601DB08 RID: 121608 RVA: 0x008FF2A3 File Offset: 0x008FD4A3
		[SkipLocalsInit]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_UpdateInteract_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601DB09 RID: 121609 RVA: 0x008FF2B7 File Offset: 0x008FD4B7
		[SkipLocalsInit]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_UpdateInteract_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601DB0A RID: 121610 RVA: 0x008FF2CB File Offset: 0x008FD4CB
		[SkipLocalsInit]
		public virtual void Sanhua()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_UpdateInteract_C.__Sanhua_NativeFunctionPtr, null);
		}

		// Token: 0x0601DB0B RID: 121611 RVA: 0x008FF2DF File Offset: 0x008FD4DF
		[SkipLocalsInit]
		public virtual void Taoqi()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_UpdateInteract_C.__Taoqi_NativeFunctionPtr, null);
		}

		// Token: 0x0601DB0C RID: 121612 RVA: 0x008FF2F3 File Offset: 0x008FD4F3
		[SkipLocalsInit]
		public virtual void Yangyang()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_UpdateInteract_C.__Yangyang_NativeFunctionPtr, null);
		}

		// Token: 0x0601DB0D RID: 121613 RVA: 0x008FF307 File Offset: 0x008FD507
		[SkipLocalsInit]
		public virtual void Yuanwu()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_UpdateInteract_C.__Yuanwu_NativeFunctionPtr, null);
		}

		// Token: 0x0601DB0E RID: 121614 RVA: 0x008FF31B File Offset: 0x008FD51B
		[SkipLocalsInit]
		public virtual void Kakaluo()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_UpdateInteract_C.__Kakaluo_NativeFunctionPtr, null);
		}

		// Token: 0x0601DB0F RID: 121615 RVA: 0x008FF32F File Offset: 0x008FD52F
		[SkipLocalsInit]
		public virtual void Awu()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_UpdateInteract_C.__Awu_NativeFunctionPtr, null);
		}

		// Token: 0x0601DB10 RID: 121616 RVA: 0x008FF343 File Offset: 0x008FD543
		[SkipLocalsInit]
		public virtual void Yinlin()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_UpdateInteract_C.__Yinlin_NativeFunctionPtr, null);
		}

		// Token: 0x0601DB11 RID: 121617 RVA: 0x008FF357 File Offset: 0x008FD557
		[SkipLocalsInit]
		public virtual void Anke()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_UpdateInteract_C.__Anke_NativeFunctionPtr, null);
		}

		// Token: 0x0601DB12 RID: 121618 RVA: 0x008FF36B File Offset: 0x008FD56B
		[SkipLocalsInit]
		public virtual void CharacterGolden()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_UpdateInteract_C.__CharacterGolden_NativeFunctionPtr, null);
		}

		// Token: 0x0601DB13 RID: 121619 RVA: 0x008FF37F File Offset: 0x008FD57F
		[SkipLocalsInit]
		public virtual void CharacterPurple()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_UpdateInteract_C.__CharacterPurple_NativeFunctionPtr, null);
		}

		// Token: 0x0601DB14 RID: 121620 RVA: 0x008FF393 File Offset: 0x008FD593
		[SkipLocalsInit]
		public virtual void WeaponGolden()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_UpdateInteract_C.__WeaponGolden_NativeFunctionPtr, null);
		}

		// Token: 0x0601DB15 RID: 121621 RVA: 0x008FF3A7 File Offset: 0x008FD5A7
		[SkipLocalsInit]
		public virtual void WeaponPurple()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_UpdateInteract_C.__WeaponPurple_NativeFunctionPtr, null);
		}

		// Token: 0x0601DB16 RID: 121622 RVA: 0x008FF3BB File Offset: 0x008FD5BB
		[SkipLocalsInit]
		public virtual void WeaponNormal()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_UpdateInteract_C.__WeaponNormal_NativeFunctionPtr, null);
		}

		// Token: 0x0601DB17 RID: 121623 RVA: 0x008FF3D0 File Offset: 0x008FD5D0
		[SkipLocalsInit]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_UpdateInteract_C.__EditorTick_FunctionParams* ptr = stackalloc BP_UpdateInteract_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_UpdateInteract_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_UpdateInteract_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_UpdateInteract_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601DB18 RID: 121624 RVA: 0x008FF418 File Offset: 0x008FD618
		[SkipLocalsInit]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_UpdateInteract_C.__EditorTick_FunctionParams* ptr = stackalloc BP_UpdateInteract_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_UpdateInteract_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_UpdateInteract_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_UpdateInteract_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601DB19 RID: 121625 RVA: 0x008FF460 File Offset: 0x008FD660
		[SkipLocalsInit]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_UpdateInteract_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_UpdateInteract_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_UpdateInteract_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_UpdateInteract_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_UpdateInteract_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601DB1A RID: 121626 RVA: 0x008FF4A8 File Offset: 0x008FD6A8
		[SkipLocalsInit]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_UpdateInteract_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_UpdateInteract_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_UpdateInteract_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_UpdateInteract_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_UpdateInteract_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601DB1B RID: 121627 RVA: 0x008FF4EE File Offset: 0x008FD6EE
		[SkipLocalsInit]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_UpdateInteract_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601DB1C RID: 121628 RVA: 0x008FF502 File Offset: 0x008FD702
		[SkipLocalsInit]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_UpdateInteract_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601DB1D RID: 121629 RVA: 0x008FF516 File Offset: 0x008FD716
		[SkipLocalsInit]
		public virtual void Qiushui()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_UpdateInteract_C.__Qiushui_NativeFunctionPtr, null);
		}

		// Token: 0x0601DB1E RID: 121630 RVA: 0x008FF52A File Offset: 0x008FD72A
		[SkipLocalsInit]
		public virtual void Micai()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_UpdateInteract_C.__Micai_NativeFunctionPtr, null);
		}

		// Token: 0x0601DB1F RID: 121631 RVA: 0x008FF53E File Offset: 0x008FD73E
		[SkipLocalsInit]
		public virtual void Maxiaofang()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_UpdateInteract_C.__Maxiaofang_NativeFunctionPtr, null);
		}

		// Token: 0x0601DB20 RID: 121632 RVA: 0x008FF552 File Offset: 0x008FD752
		[SkipLocalsInit]
		public virtual void Jianxin()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_UpdateInteract_C.__Jianxin_NativeFunctionPtr, null);
		}

		// Token: 0x0601DB21 RID: 121633 RVA: 0x008FF566 File Offset: 0x008FD766
		[SkipLocalsInit]
		public virtual void Bailian()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_UpdateInteract_C.__Bailian_NativeFunctionPtr, null);
		}

		// Token: 0x0601DB22 RID: 121634 RVA: 0x008FF57A File Offset: 0x008FD77A
		[SkipLocalsInit]
		public virtual void Baer()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_UpdateInteract_C.__Baer_NativeFunctionPtr, null);
		}

		// Token: 0x0601DB23 RID: 121635 RVA: 0x008FF590 File Offset: 0x008FD790
		[SkipLocalsInit]
		public unsafe virtual void UpdateGachaShowItem(int ID, byte GachaResults)
		{
			BP_UpdateInteract_C.__UpdateGachaShowItem_FunctionParams* ptr = stackalloc BP_UpdateInteract_C.__UpdateGachaShowItem_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_UpdateInteract_C.__UpdateGachaShowItem_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_UpdateInteract_C.__UpdateGachaShowItem_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ID = ID;
			ptr->GachaResults = GachaResults;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_UpdateInteract_C.__UpdateGachaShowItem_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601DB24 RID: 121636 RVA: 0x008FF5E0 File Offset: 0x008FD7E0
		[SkipLocalsInit]
		public unsafe virtual void HiddenShowDownParticles(bool Show_)
		{
			BP_UpdateInteract_C.__HiddenShowDownParticles_FunctionParams* ptr = stackalloc BP_UpdateInteract_C.__HiddenShowDownParticles_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_UpdateInteract_C.__HiddenShowDownParticles_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_UpdateInteract_C.__HiddenShowDownParticles_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Show_ = Show_;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_UpdateInteract_C.__HiddenShowDownParticles_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601DB25 RID: 121637 RVA: 0x008FF628 File Offset: 0x008FD828
		[SkipLocalsInit]
		public unsafe virtual void HiddenShowUpParticles(bool Show_)
		{
			BP_UpdateInteract_C.__HiddenShowUpParticles_FunctionParams* ptr = stackalloc BP_UpdateInteract_C.__HiddenShowUpParticles_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_UpdateInteract_C.__HiddenShowUpParticles_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_UpdateInteract_C.__HiddenShowUpParticles_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Show_ = Show_;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_UpdateInteract_C.__HiddenShowUpParticles_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601DB26 RID: 121638 RVA: 0x008FF66E File Offset: 0x008FD86E
		[SkipLocalsInit]
		public virtual void EndGachaScene()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_UpdateInteract_C.__EndGachaScene_NativeFunctionPtr, null);
		}

		// Token: 0x0601DB27 RID: 121639 RVA: 0x008FF682 File Offset: 0x008FD882
		[SkipLocalsInit]
		public virtual void Jiyan()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_UpdateInteract_C.__Jiyan_NativeFunctionPtr, null);
		}

		// Token: 0x0601DB28 RID: 121640 RVA: 0x008FF696 File Offset: 0x008FD896
		[SkipLocalsInit]
		public virtual void Chun()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_UpdateInteract_C.__Chun_NativeFunctionPtr, null);
		}

		// Token: 0x0601DB29 RID: 121641 RVA: 0x008FF6AA File Offset: 0x008FD8AA
		[SkipLocalsInit]
		public virtual void UpdateGacha()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_UpdateInteract_C.__UpdateGacha_NativeFunctionPtr, null);
		}

		// Token: 0x0601DB2A RID: 121642 RVA: 0x008FF6BE File Offset: 0x008FD8BE
		[SkipLocalsInit]
		public virtual void Jueyuan()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_UpdateInteract_C.__Jueyuan_NativeFunctionPtr, null);
		}

		// Token: 0x0601DB2B RID: 121643 RVA: 0x008FF6D2 File Offset: 0x008FD8D2
		[SkipLocalsInit]
		public virtual void Jinxi()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_UpdateInteract_C.__Jinxi_NativeFunctionPtr, null);
		}

		// Token: 0x0601DB2C RID: 121644 RVA: 0x008FF6E6 File Offset: 0x008FD8E6
		[SkipLocalsInit]
		public virtual void Changli()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_UpdateInteract_C.__Changli_NativeFunctionPtr, null);
		}

		// Token: 0x0601DB2D RID: 121645 RVA: 0x008FF6FA File Offset: 0x008FD8FA
		protected BP_UpdateInteract_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FA35 RID: 64053
		public new const string __ObjectPath = "/Game/Aki/Scene/NewGacha/BP/BP_UpdateInteract.BP_UpdateInteract_C";

		// Token: 0x0400FA36 RID: 64054
		private static IntPtr _ClassPtr;

		// Token: 0x0400FA37 RID: 64055
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FA38 RID: 64056
		public static IntPtr __ResultMain__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400FA39 RID: 64057
		public static IntPtr __ResultChangli__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400FA3A RID: 64058
		public static IntPtr __ResultJinxi__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400FA3B RID: 64059
		public static IntPtr __ResultYuanwu__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400FA3C RID: 64060
		public static IntPtr __ResultYangyang__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400FA3D RID: 64061
		public static IntPtr __ResultTaoqi__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400FA3E RID: 64062
		public static IntPtr __ResultSanhua__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400FA3F RID: 64063
		public static IntPtr __ResultQiushui__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400FA40 RID: 64064
		public static IntPtr __ResultMicai__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400FA41 RID: 64065
		public static IntPtr __ResultMaxiaofang__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400FA42 RID: 64066
		public static IntPtr __ResultJianxin__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400FA43 RID: 64067
		public static IntPtr __ResultBailian__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400FA44 RID: 64068
		public static IntPtr __ResultBaer__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400FA45 RID: 64069
		public static IntPtr __ResultJueyuan__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400FA46 RID: 64070
		public static IntPtr __ResultJiyan__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400FA47 RID: 64071
		public static IntPtr __ResultChun__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400FA48 RID: 64072
		public static IntPtr __ResultKakaluo__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400FA49 RID: 64073
		public static IntPtr __ResultAwu__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400FA4A RID: 64074
		public static IntPtr __ResultAnke__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400FA4B RID: 64075
		public static IntPtr __ResultYinlin__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400FA4C RID: 64076
		public static IntPtr __ResultCharacterGolden__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400FA4D RID: 64077
		public static IntPtr __ResultCharacterPurple__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400FA4E RID: 64078
		public static IntPtr __ResultWeaponGolden__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400FA4F RID: 64079
		public static IntPtr __ResultWeaponPurple__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400FA50 RID: 64080
		public static IntPtr __ResultWeaponNormal__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400FA51 RID: 64081
		internal static int __PropertyOffset_KuroPostProcess;

		// Token: 0x0400FA52 RID: 64082
		internal static int __PropertyOffset_Box;

		// Token: 0x0400FA53 RID: 64083
		internal static int __PropertyOffset_DefaultSceneRoot;

		// Token: 0x0400FA54 RID: 64084
		internal static int __PropertyOffset_GachaResults;

		// Token: 0x0400FA55 RID: 64085
		internal static int __PropertyOffset_NormalColor;

		// Token: 0x0400FA56 RID: 64086
		internal static int __PropertyOffset_PurpleColor;

		// Token: 0x0400FA57 RID: 64087
		internal static int __PropertyOffset_AwardParticles;

		// Token: 0x0400FA58 RID: 64088
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<ANiagaraActor> _AwardParticles;

		// Token: 0x0400FA59 RID: 64089
		internal static int __PropertyOffset_GoldColor;

		// Token: 0x0400FA5A RID: 64090
		internal static int __PropertyOffset_ResultWeaponNormal;

		// Token: 0x0400FA5B RID: 64091
		[Nullable(2)]
		private ResultWeaponNormal _ResultWeaponNormal;

		// Token: 0x0400FA5C RID: 64092
		internal static int __PropertyOffset_ResultWeaponPurple;

		// Token: 0x0400FA5D RID: 64093
		[Nullable(2)]
		private ResultWeaponPurple _ResultWeaponPurple;

		// Token: 0x0400FA5E RID: 64094
		internal static int __PropertyOffset_ResultWeaponGolden;

		// Token: 0x0400FA5F RID: 64095
		[Nullable(2)]
		private ResultWeaponGolden _ResultWeaponGolden;

		// Token: 0x0400FA60 RID: 64096
		internal static int __PropertyOffset_ParticleColor;

		// Token: 0x0400FA61 RID: 64097
		[Nullable(2)]
		private TMap<int, FLinearColor> _ParticleColor;

		// Token: 0x0400FA62 RID: 64098
		internal static int __PropertyOffset_DataAsset;

		// Token: 0x0400FA63 RID: 64099
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<int, UKuroWeatherDataAsset> _DataAsset;

		// Token: 0x0400FA64 RID: 64100
		internal static int __PropertyOffset_ParticleColorFinal;

		// Token: 0x0400FA65 RID: 64101
		internal static int __PropertyOffset_GachaResultForShow;

		// Token: 0x0400FA66 RID: 64102
		internal static int __PropertyOffset_ResultCharacterPurple;

		// Token: 0x0400FA67 RID: 64103
		[Nullable(2)]
		private ResultCharacterPurple _ResultCharacterPurple;

		// Token: 0x0400FA68 RID: 64104
		internal static int __PropertyOffset_ResultCharacterGolden;

		// Token: 0x0400FA69 RID: 64105
		[Nullable(2)]
		private ResultCharacterGolden _ResultCharacterGolden;

		// Token: 0x0400FA6A RID: 64106
		internal static int __PropertyOffset_ResultYinlin;

		// Token: 0x0400FA6B RID: 64107
		[Nullable(2)]
		private ResultYinlin _ResultYinlin;

		// Token: 0x0400FA6C RID: 64108
		internal static int __PropertyOffset_ResultAnke;

		// Token: 0x0400FA6D RID: 64109
		[Nullable(2)]
		private ResultAnke _ResultAnke;

		// Token: 0x0400FA6E RID: 64110
		internal static int __PropertyOffset_ResultAwu;

		// Token: 0x0400FA6F RID: 64111
		[Nullable(2)]
		private ResultAwu _ResultAwu;

		// Token: 0x0400FA70 RID: 64112
		internal static int __PropertyOffset_ResultKakaluo;

		// Token: 0x0400FA71 RID: 64113
		[Nullable(2)]
		private ResultKakaluo _ResultKakaluo;

		// Token: 0x0400FA72 RID: 64114
		internal static int __PropertyOffset_ResultChun;

		// Token: 0x0400FA73 RID: 64115
		[Nullable(2)]
		private ResultChun _ResultChun;

		// Token: 0x0400FA74 RID: 64116
		internal static int __PropertyOffset_ResultJiyan;

		// Token: 0x0400FA75 RID: 64117
		[Nullable(2)]
		private ResultJiyan _ResultJiyan;

		// Token: 0x0400FA76 RID: 64118
		internal static int __PropertyOffset_ResultJueyuan;

		// Token: 0x0400FA77 RID: 64119
		[Nullable(2)]
		private ResultJueyuan _ResultJueyuan;

		// Token: 0x0400FA78 RID: 64120
		internal static int __PropertyOffset_ChangeHiddenObject;

		// Token: 0x0400FA79 RID: 64121
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AActor> _ChangeHiddenObject;

		// Token: 0x0400FA7A RID: 64122
		internal static int __PropertyOffset_MeshHidden;

		// Token: 0x0400FA7B RID: 64123
		[Nullable(2)]
		private TMap<int, bool> _MeshHidden;

		// Token: 0x0400FA7C RID: 64124
		internal static int __PropertyOffset_SceneObjectVisibility;

		// Token: 0x0400FA7D RID: 64125
		internal static int __PropertyOffset_CharacterHiddenParticles;

		// Token: 0x0400FA7E RID: 64126
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<ANiagaraActor> _CharacterHiddenParticles;

		// Token: 0x0400FA7F RID: 64127
		internal static int __PropertyOffset_IsCharacter_;

		// Token: 0x0400FA80 RID: 64128
		internal static int __PropertyOffset_UpParticles;

		// Token: 0x0400FA81 RID: 64129
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<ANiagaraActor> _UpParticles;

		// Token: 0x0400FA82 RID: 64130
		internal static int __PropertyOffset_DownParticles;

		// Token: 0x0400FA83 RID: 64131
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<ANiagaraActor> _DownParticles;

		// Token: 0x0400FA84 RID: 64132
		internal static int __PropertyOffset_IsEditor;

		// Token: 0x0400FA85 RID: 64133
		internal static int __PropertyOffset_ResultBaer;

		// Token: 0x0400FA86 RID: 64134
		[Nullable(2)]
		private ResultBaer _ResultBaer;

		// Token: 0x0400FA87 RID: 64135
		internal static int __PropertyOffset_ResultBailian;

		// Token: 0x0400FA88 RID: 64136
		[Nullable(2)]
		private ResultBailian _ResultBailian;

		// Token: 0x0400FA89 RID: 64137
		internal static int __PropertyOffset_ResultJianxin;

		// Token: 0x0400FA8A RID: 64138
		[Nullable(2)]
		private ResultJianxin _ResultJianxin;

		// Token: 0x0400FA8B RID: 64139
		internal static int __PropertyOffset_ResultMaxiaofang;

		// Token: 0x0400FA8C RID: 64140
		[Nullable(2)]
		private ResultMaxiaofang _ResultMaxiaofang;

		// Token: 0x0400FA8D RID: 64141
		internal static int __PropertyOffset_ResultMicai;

		// Token: 0x0400FA8E RID: 64142
		[Nullable(2)]
		private ResultMicai _ResultMicai;

		// Token: 0x0400FA8F RID: 64143
		internal static int __PropertyOffset_ResultQiushui;

		// Token: 0x0400FA90 RID: 64144
		[Nullable(2)]
		private ResultQiushui _ResultQiushui;

		// Token: 0x0400FA91 RID: 64145
		internal static int __PropertyOffset_ResultSanhua;

		// Token: 0x0400FA92 RID: 64146
		[Nullable(2)]
		private ResultSanhua _ResultSanhua;

		// Token: 0x0400FA93 RID: 64147
		internal static int __PropertyOffset_ResultTaoqi;

		// Token: 0x0400FA94 RID: 64148
		[Nullable(2)]
		private ResultTaoqi _ResultTaoqi;

		// Token: 0x0400FA95 RID: 64149
		internal static int __PropertyOffset_ResultYangyang;

		// Token: 0x0400FA96 RID: 64150
		[Nullable(2)]
		private ResultYangyang _ResultYangyang;

		// Token: 0x0400FA97 RID: 64151
		internal static int __PropertyOffset_ResultYuanwu;

		// Token: 0x0400FA98 RID: 64152
		[Nullable(2)]
		private ResultYuanwu _ResultYuanwu;

		// Token: 0x0400FA99 RID: 64153
		internal static int __PropertyOffset_IsCallable;

		// Token: 0x0400FA9A RID: 64154
		internal static int __PropertyOffset_OriMotionBlur;

		// Token: 0x0400FA9B RID: 64155
		internal static int __PropertyOffset_ResultJinxi;

		// Token: 0x0400FA9C RID: 64156
		[Nullable(2)]
		private ResultJinxi _ResultJinxi;

		// Token: 0x0400FA9D RID: 64157
		internal static int __PropertyOffset_ResultChangli;

		// Token: 0x0400FA9E RID: 64158
		[Nullable(2)]
		private ResultChangli _ResultChangli;

		// Token: 0x0400FA9F RID: 64159
		internal static int __PropertyOffset_ResultMain;

		// Token: 0x0400FAA0 RID: 64160
		[Nullable(2)]
		private ResultMain _ResultMain;

		// Token: 0x0400FAA1 RID: 64161
		internal static int __PropertyOffset_OpenLerPerFrame;

		// Token: 0x0400FAA2 RID: 64162
		private static IntPtr __QualityColorModification_NativeFunctionPtr;

		// Token: 0x0400FAA3 RID: 64163
		private static IntPtr __IsNewWorkFlow_NativeFunctionPtr;

		// Token: 0x0400FAA4 RID: 64164
		private static IntPtr __TSUpdateGachaResult_deprecated__NativeFunctionPtr;

		// Token: 0x0400FAA5 RID: 64165
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0400FAA6 RID: 64166
		private static IntPtr __Sanhua_NativeFunctionPtr;

		// Token: 0x0400FAA7 RID: 64167
		private static IntPtr __Taoqi_NativeFunctionPtr;

		// Token: 0x0400FAA8 RID: 64168
		private static IntPtr __Yangyang_NativeFunctionPtr;

		// Token: 0x0400FAA9 RID: 64169
		private static IntPtr __Yuanwu_NativeFunctionPtr;

		// Token: 0x0400FAAA RID: 64170
		private static IntPtr __Kakaluo_NativeFunctionPtr;

		// Token: 0x0400FAAB RID: 64171
		private static IntPtr __Awu_NativeFunctionPtr;

		// Token: 0x0400FAAC RID: 64172
		private static IntPtr __Yinlin_NativeFunctionPtr;

		// Token: 0x0400FAAD RID: 64173
		private static IntPtr __Anke_NativeFunctionPtr;

		// Token: 0x0400FAAE RID: 64174
		private static IntPtr __CharacterGolden_NativeFunctionPtr;

		// Token: 0x0400FAAF RID: 64175
		private static IntPtr __CharacterPurple_NativeFunctionPtr;

		// Token: 0x0400FAB0 RID: 64176
		private static IntPtr __WeaponGolden_NativeFunctionPtr;

		// Token: 0x0400FAB1 RID: 64177
		private static IntPtr __WeaponPurple_NativeFunctionPtr;

		// Token: 0x0400FAB2 RID: 64178
		private static IntPtr __WeaponNormal_NativeFunctionPtr;

		// Token: 0x0400FAB3 RID: 64179
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x0400FAB4 RID: 64180
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0400FAB5 RID: 64181
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0400FAB6 RID: 64182
		private static IntPtr __Qiushui_NativeFunctionPtr;

		// Token: 0x0400FAB7 RID: 64183
		private static IntPtr __Micai_NativeFunctionPtr;

		// Token: 0x0400FAB8 RID: 64184
		private static IntPtr __Maxiaofang_NativeFunctionPtr;

		// Token: 0x0400FAB9 RID: 64185
		private static IntPtr __Jianxin_NativeFunctionPtr;

		// Token: 0x0400FABA RID: 64186
		private static IntPtr __Bailian_NativeFunctionPtr;

		// Token: 0x0400FABB RID: 64187
		private static IntPtr __Baer_NativeFunctionPtr;

		// Token: 0x0400FABC RID: 64188
		private static IntPtr __UpdateGachaShowItem_NativeFunctionPtr;

		// Token: 0x0400FABD RID: 64189
		private static IntPtr __HiddenShowDownParticles_NativeFunctionPtr;

		// Token: 0x0400FABE RID: 64190
		private static IntPtr __HiddenShowUpParticles_NativeFunctionPtr;

		// Token: 0x0400FABF RID: 64191
		private static IntPtr __EndGachaScene_NativeFunctionPtr;

		// Token: 0x0400FAC0 RID: 64192
		private static IntPtr __Jiyan_NativeFunctionPtr;

		// Token: 0x0400FAC1 RID: 64193
		private static IntPtr __Chun_NativeFunctionPtr;

		// Token: 0x0400FAC2 RID: 64194
		private static IntPtr __UpdateGacha_NativeFunctionPtr;

		// Token: 0x0400FAC3 RID: 64195
		private static IntPtr __Jueyuan_NativeFunctionPtr;

		// Token: 0x0400FAC4 RID: 64196
		private static IntPtr __Jinxi_NativeFunctionPtr;

		// Token: 0x0400FAC5 RID: 64197
		private static IntPtr __Changli_NativeFunctionPtr;

		// Token: 0x02008D7B RID: 36219
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 176)]
		protected ref struct __QualityColorModification_FunctionParams
		{
			// Token: 0x0402C92F RID: 182575
			[FieldOffset(0)]
			public TEnumAsByte<E_GachaResultFinal> GachaResult;

			// Token: 0x0402C930 RID: 182576
			[FieldOffset(4)]
			public int ID;

			// Token: 0x0402C931 RID: 182577
			[FieldOffset(8)]
			public bool IsCharacter;
		}

		// Token: 0x02008D7C RID: 36220
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __IsNewWorkFlow_FunctionParams
		{
			// Token: 0x0402C932 RID: 182578
			[FieldOffset(0)]
			public bool IsNew;
		}

		// Token: 0x02008D7D RID: 36221
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __TSUpdateGachaResult_deprecated__FunctionParams
		{
			// Token: 0x0402C933 RID: 182579
			[FieldOffset(0)]
			public TEnumAsByte<E_GachaResultNew> GachaResults;
		}

		// Token: 0x02008D7E RID: 36222
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x0402C934 RID: 182580
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02008D7F RID: 36223
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0402C935 RID: 182581
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02008D80 RID: 36224
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __UpdateGachaShowItem_FunctionParams
		{
			// Token: 0x0402C936 RID: 182582
			[FieldOffset(0)]
			public int ID;

			// Token: 0x0402C937 RID: 182583
			[FieldOffset(4)]
			public byte GachaResults;
		}

		// Token: 0x02008D81 RID: 36225
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __HiddenShowDownParticles_FunctionParams
		{
			// Token: 0x0402C938 RID: 182584
			[FieldOffset(0)]
			public bool Show_;
		}

		// Token: 0x02008D82 RID: 36226
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __HiddenShowUpParticles_FunctionParams
		{
			// Token: 0x0402C939 RID: 182585
			[FieldOffset(0)]
			public bool Show_;
		}
	}
}

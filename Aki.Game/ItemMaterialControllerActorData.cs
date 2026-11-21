using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020029FD RID: 10749
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/Render/Scene/Item/MaterialController/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Render/Scene/Item/MaterialController/ItemMaterialControllerActorData.ItemMaterialControllerActorData_C")]
public class ItemMaterialControllerActorData : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
{
	// Token: 0x17002BBF RID: 11199
	// (get) Token: 0x0601AF7F RID: 110463 RVA: 0x00846FA7 File Offset: 0x008451A7
	// (set) Token: 0x0601AF80 RID: 110464 RVA: 0x00846FB7 File Offset: 0x008451B7
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float StartTime
	{
		get
		{
			return *(base.NativePtr + (IntPtr)ItemMaterialControllerActorData.__PropertyOffset_StartTime);
		}
		set
		{
			*(base.NativePtr + (IntPtr)ItemMaterialControllerActorData.__PropertyOffset_StartTime) = value;
		}
	}

	// Token: 0x17002BC0 RID: 11200
	// (get) Token: 0x0601AF81 RID: 110465 RVA: 0x00846FC8 File Offset: 0x008451C8
	// (set) Token: 0x0601AF82 RID: 110466 RVA: 0x00846FD8 File Offset: 0x008451D8
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float LoopTime
	{
		get
		{
			return *(base.NativePtr + (IntPtr)ItemMaterialControllerActorData.__PropertyOffset_LoopTime);
		}
		set
		{
			*(base.NativePtr + (IntPtr)ItemMaterialControllerActorData.__PropertyOffset_LoopTime) = value;
		}
	}

	// Token: 0x17002BC1 RID: 11201
	// (get) Token: 0x0601AF83 RID: 110467 RVA: 0x00846FE9 File Offset: 0x008451E9
	// (set) Token: 0x0601AF84 RID: 110468 RVA: 0x00846FF9 File Offset: 0x008451F9
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float EndTime
	{
		get
		{
			return *(base.NativePtr + (IntPtr)ItemMaterialControllerActorData.__PropertyOffset_EndTime);
		}
		set
		{
			*(base.NativePtr + (IntPtr)ItemMaterialControllerActorData.__PropertyOffset_EndTime) = value;
		}
	}

	// Token: 0x17002BC2 RID: 11202
	// (get) Token: 0x0601AF85 RID: 110469 RVA: 0x0084700A File Offset: 0x0084520A
	// (set) Token: 0x0601AF86 RID: 110470 RVA: 0x0084701A File Offset: 0x0084521A
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool EnableBaseColorScale
	{
		get
		{
			return *(base.NativePtr + (IntPtr)ItemMaterialControllerActorData.__PropertyOffset_EnableBaseColorScale) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)ItemMaterialControllerActorData.__PropertyOffset_EnableBaseColorScale) = (value ? 1 : 0);
		}
	}

	// Token: 0x17002BC3 RID: 11203
	// (get) Token: 0x0601AF87 RID: 110471 RVA: 0x0084702C File Offset: 0x0084522C
	// (set) Token: 0x0601AF88 RID: 110472 RVA: 0x00847065 File Offset: 0x00845265
	[UProperty(EPropertyFlags.CPF_None)]
	public FKuroCurveFloat BaseColorScale
	{
		get
		{
			base.FastCheckIsValid();
			FKuroCurveFloat result;
			if ((result = this._BaseColorScale) == null)
			{
				result = (this._BaseColorScale = new FKuroCurveFloat(base.NativePtr + (IntPtr)ItemMaterialControllerActorData.__PropertyOffset_BaseColorScale, this));
			}
			return result;
		}
		set
		{
			UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)ItemMaterialControllerActorData.__PropertyOffset_BaseColorScale, (value != null) ? value.NativePtr : ((IntPtr)0), 1, false);
		}
	}

	// Token: 0x17002BC4 RID: 11204
	// (get) Token: 0x0601AF89 RID: 110473 RVA: 0x0084708D File Offset: 0x0084528D
	// (set) Token: 0x0601AF8A RID: 110474 RVA: 0x0084709D File Offset: 0x0084529D
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool EnableAddEmissionColor
	{
		get
		{
			return *(base.NativePtr + (IntPtr)ItemMaterialControllerActorData.__PropertyOffset_EnableAddEmissionColor) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)ItemMaterialControllerActorData.__PropertyOffset_EnableAddEmissionColor) = (value ? 1 : 0);
		}
	}

	// Token: 0x17002BC5 RID: 11205
	// (get) Token: 0x0601AF8B RID: 110475 RVA: 0x008470B0 File Offset: 0x008452B0
	// (set) Token: 0x0601AF8C RID: 110476 RVA: 0x008470E9 File Offset: 0x008452E9
	[UProperty(EPropertyFlags.CPF_None)]
	public FKuroCurveLinearColor AddEmissionColor
	{
		get
		{
			base.FastCheckIsValid();
			FKuroCurveLinearColor result;
			if ((result = this._AddEmissionColor) == null)
			{
				result = (this._AddEmissionColor = new FKuroCurveLinearColor(base.NativePtr + (IntPtr)ItemMaterialControllerActorData.__PropertyOffset_AddEmissionColor, this));
			}
			return result;
		}
		set
		{
			UnrealReflectionUtils.CopyNativeStruct(FKuroCurveLinearColor.StaticStruct(), base.NativePtr + (IntPtr)ItemMaterialControllerActorData.__PropertyOffset_AddEmissionColor, (value != null) ? value.NativePtr : ((IntPtr)0), 1, false);
		}
	}

	// Token: 0x17002BC6 RID: 11206
	// (get) Token: 0x0601AF8D RID: 110477 RVA: 0x00847111 File Offset: 0x00845311
	// (set) Token: 0x0601AF8E RID: 110478 RVA: 0x00847121 File Offset: 0x00845321
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool EnableEmissionChange
	{
		get
		{
			return *(base.NativePtr + (IntPtr)ItemMaterialControllerActorData.__PropertyOffset_EnableEmissionChange) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)ItemMaterialControllerActorData.__PropertyOffset_EnableEmissionChange) = (value ? 1 : 0);
		}
	}

	// Token: 0x17002BC7 RID: 11207
	// (get) Token: 0x0601AF8F RID: 110479 RVA: 0x00847134 File Offset: 0x00845334
	// (set) Token: 0x0601AF90 RID: 110480 RVA: 0x0084716D File Offset: 0x0084536D
	[UProperty(EPropertyFlags.CPF_None)]
	public FKuroCurveFloat EmissionLightColorChangeProgress
	{
		get
		{
			base.FastCheckIsValid();
			FKuroCurveFloat result;
			if ((result = this._EmissionLightColorChangeProgress) == null)
			{
				result = (this._EmissionLightColorChangeProgress = new FKuroCurveFloat(base.NativePtr + (IntPtr)ItemMaterialControllerActorData.__PropertyOffset_EmissionLightColorChangeProgress, this));
			}
			return result;
		}
		set
		{
			UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)ItemMaterialControllerActorData.__PropertyOffset_EmissionLightColorChangeProgress, (value != null) ? value.NativePtr : ((IntPtr)0), 1, false);
		}
	}

	// Token: 0x17002BC8 RID: 11208
	// (get) Token: 0x0601AF91 RID: 110481 RVA: 0x00847198 File Offset: 0x00845398
	// (set) Token: 0x0601AF92 RID: 110482 RVA: 0x008471D1 File Offset: 0x008453D1
	[UProperty(EPropertyFlags.CPF_None)]
	public FKuroCurveFloat EmissionLightColorChangeStrength
	{
		get
		{
			base.FastCheckIsValid();
			FKuroCurveFloat result;
			if ((result = this._EmissionLightColorChangeStrength) == null)
			{
				result = (this._EmissionLightColorChangeStrength = new FKuroCurveFloat(base.NativePtr + (IntPtr)ItemMaterialControllerActorData.__PropertyOffset_EmissionLightColorChangeStrength, this));
			}
			return result;
		}
		set
		{
			UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)ItemMaterialControllerActorData.__PropertyOffset_EmissionLightColorChangeStrength, (value != null) ? value.NativePtr : ((IntPtr)0), 1, false);
		}
	}

	// Token: 0x17002BC9 RID: 11209
	// (get) Token: 0x0601AF93 RID: 110483 RVA: 0x008471FC File Offset: 0x008453FC
	// (set) Token: 0x0601AF94 RID: 110484 RVA: 0x00847235 File Offset: 0x00845435
	[UProperty(EPropertyFlags.CPF_None)]
	public FKuroCurveLinearColor EmissionLightColorChangeColor
	{
		get
		{
			base.FastCheckIsValid();
			FKuroCurveLinearColor result;
			if ((result = this._EmissionLightColorChangeColor) == null)
			{
				result = (this._EmissionLightColorChangeColor = new FKuroCurveLinearColor(base.NativePtr + (IntPtr)ItemMaterialControllerActorData.__PropertyOffset_EmissionLightColorChangeColor, this));
			}
			return result;
		}
		set
		{
			UnrealReflectionUtils.CopyNativeStruct(FKuroCurveLinearColor.StaticStruct(), base.NativePtr + (IntPtr)ItemMaterialControllerActorData.__PropertyOffset_EmissionLightColorChangeColor, (value != null) ? value.NativePtr : ((IntPtr)0), 1, false);
		}
	}

	// Token: 0x17002BCA RID: 11210
	// (get) Token: 0x0601AF95 RID: 110485 RVA: 0x0084725D File Offset: 0x0084545D
	// (set) Token: 0x0601AF96 RID: 110486 RVA: 0x0084726D File Offset: 0x0084546D
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool EnableRimLight
	{
		get
		{
			return *(base.NativePtr + (IntPtr)ItemMaterialControllerActorData.__PropertyOffset_EnableRimLight) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)ItemMaterialControllerActorData.__PropertyOffset_EnableRimLight) = (value ? 1 : 0);
		}
	}

	// Token: 0x17002BCB RID: 11211
	// (get) Token: 0x0601AF97 RID: 110487 RVA: 0x00847280 File Offset: 0x00845480
	// (set) Token: 0x0601AF98 RID: 110488 RVA: 0x008472B9 File Offset: 0x008454B9
	[UProperty(EPropertyFlags.CPF_None)]
	public FKuroCurveLinearColor RimLightColor
	{
		get
		{
			base.FastCheckIsValid();
			FKuroCurveLinearColor result;
			if ((result = this._RimLightColor) == null)
			{
				result = (this._RimLightColor = new FKuroCurveLinearColor(base.NativePtr + (IntPtr)ItemMaterialControllerActorData.__PropertyOffset_RimLightColor, this));
			}
			return result;
		}
		set
		{
			UnrealReflectionUtils.CopyNativeStruct(FKuroCurveLinearColor.StaticStruct(), base.NativePtr + (IntPtr)ItemMaterialControllerActorData.__PropertyOffset_RimLightColor, (value != null) ? value.NativePtr : ((IntPtr)0), 1, false);
		}
	}

	// Token: 0x17002BCC RID: 11212
	// (get) Token: 0x0601AF99 RID: 110489 RVA: 0x008472E4 File Offset: 0x008454E4
	// (set) Token: 0x0601AF9A RID: 110490 RVA: 0x0084731D File Offset: 0x0084551D
	[UProperty(EPropertyFlags.CPF_None)]
	public FKuroCurveFloat RimPower
	{
		get
		{
			base.FastCheckIsValid();
			FKuroCurveFloat result;
			if ((result = this._RimPower) == null)
			{
				result = (this._RimPower = new FKuroCurveFloat(base.NativePtr + (IntPtr)ItemMaterialControllerActorData.__PropertyOffset_RimPower, this));
			}
			return result;
		}
		set
		{
			UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)ItemMaterialControllerActorData.__PropertyOffset_RimPower, (value != null) ? value.NativePtr : ((IntPtr)0), 1, false);
		}
	}

	// Token: 0x17002BCD RID: 11213
	// (get) Token: 0x0601AF9B RID: 110491 RVA: 0x00847345 File Offset: 0x00845545
	// (set) Token: 0x0601AF9C RID: 110492 RVA: 0x00847355 File Offset: 0x00845555
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool EnableDissolve
	{
		get
		{
			return *(base.NativePtr + (IntPtr)ItemMaterialControllerActorData.__PropertyOffset_EnableDissolve) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)ItemMaterialControllerActorData.__PropertyOffset_EnableDissolve) = (value ? 1 : 0);
		}
	}

	// Token: 0x17002BCE RID: 11214
	// (get) Token: 0x0601AF9D RID: 110493 RVA: 0x00847368 File Offset: 0x00845568
	// (set) Token: 0x0601AF9E RID: 110494 RVA: 0x008473A1 File Offset: 0x008455A1
	[UProperty(EPropertyFlags.CPF_None)]
	public FKuroCurveFloat DissolveProgress
	{
		get
		{
			base.FastCheckIsValid();
			FKuroCurveFloat result;
			if ((result = this._DissolveProgress) == null)
			{
				result = (this._DissolveProgress = new FKuroCurveFloat(base.NativePtr + (IntPtr)ItemMaterialControllerActorData.__PropertyOffset_DissolveProgress, this));
			}
			return result;
		}
		set
		{
			UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)ItemMaterialControllerActorData.__PropertyOffset_DissolveProgress, (value != null) ? value.NativePtr : ((IntPtr)0), 1, false);
		}
	}

	// Token: 0x17002BCF RID: 11215
	// (get) Token: 0x0601AF9F RID: 110495 RVA: 0x008473CC File Offset: 0x008455CC
	// (set) Token: 0x0601AFA0 RID: 110496 RVA: 0x00847405 File Offset: 0x00845605
	[UProperty(EPropertyFlags.CPF_None)]
	public FKuroCurveFloat DissolveAdjustment
	{
		get
		{
			base.FastCheckIsValid();
			FKuroCurveFloat result;
			if ((result = this._DissolveAdjustment) == null)
			{
				result = (this._DissolveAdjustment = new FKuroCurveFloat(base.NativePtr + (IntPtr)ItemMaterialControllerActorData.__PropertyOffset_DissolveAdjustment, this));
			}
			return result;
		}
		set
		{
			UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)ItemMaterialControllerActorData.__PropertyOffset_DissolveAdjustment, (value != null) ? value.NativePtr : ((IntPtr)0), 1, false);
		}
	}

	// Token: 0x17002BD0 RID: 11216
	// (get) Token: 0x0601AFA1 RID: 110497 RVA: 0x00847430 File Offset: 0x00845630
	// (set) Token: 0x0601AFA2 RID: 110498 RVA: 0x00847469 File Offset: 0x00845669
	[UProperty(EPropertyFlags.CPF_None)]
	public FKuroCurveFloat DissolveEdageWidth
	{
		get
		{
			base.FastCheckIsValid();
			FKuroCurveFloat result;
			if ((result = this._DissolveEdageWidth) == null)
			{
				result = (this._DissolveEdageWidth = new FKuroCurveFloat(base.NativePtr + (IntPtr)ItemMaterialControllerActorData.__PropertyOffset_DissolveEdageWidth, this));
			}
			return result;
		}
		set
		{
			UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)ItemMaterialControllerActorData.__PropertyOffset_DissolveEdageWidth, (value != null) ? value.NativePtr : ((IntPtr)0), 1, false);
		}
	}

	// Token: 0x17002BD1 RID: 11217
	// (get) Token: 0x0601AFA3 RID: 110499 RVA: 0x00847494 File Offset: 0x00845694
	// (set) Token: 0x0601AFA4 RID: 110500 RVA: 0x008474CD File Offset: 0x008456CD
	[UProperty(EPropertyFlags.CPF_None)]
	public FKuroCurveLinearColor DissolveEdageColor
	{
		get
		{
			base.FastCheckIsValid();
			FKuroCurveLinearColor result;
			if ((result = this._DissolveEdageColor) == null)
			{
				result = (this._DissolveEdageColor = new FKuroCurveLinearColor(base.NativePtr + (IntPtr)ItemMaterialControllerActorData.__PropertyOffset_DissolveEdageColor, this));
			}
			return result;
		}
		set
		{
			UnrealReflectionUtils.CopyNativeStruct(FKuroCurveLinearColor.StaticStruct(), base.NativePtr + (IntPtr)ItemMaterialControllerActorData.__PropertyOffset_DissolveEdageColor, (value != null) ? value.NativePtr : ((IntPtr)0), 1, false);
		}
	}

	// Token: 0x17002BD2 RID: 11218
	// (get) Token: 0x0601AFA5 RID: 110501 RVA: 0x008474F8 File Offset: 0x008456F8
	// (set) Token: 0x0601AFA6 RID: 110502 RVA: 0x00847531 File Offset: 0x00845731
	[UProperty(EPropertyFlags.CPF_None)]
	public FKuroCurveFloat DissolveEdageStrength
	{
		get
		{
			base.FastCheckIsValid();
			FKuroCurveFloat result;
			if ((result = this._DissolveEdageStrength) == null)
			{
				result = (this._DissolveEdageStrength = new FKuroCurveFloat(base.NativePtr + (IntPtr)ItemMaterialControllerActorData.__PropertyOffset_DissolveEdageStrength, this));
			}
			return result;
		}
		set
		{
			UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)ItemMaterialControllerActorData.__PropertyOffset_DissolveEdageStrength, (value != null) ? value.NativePtr : ((IntPtr)0), 1, false);
		}
	}

	// Token: 0x17002BD3 RID: 11219
	// (get) Token: 0x0601AFA7 RID: 110503 RVA: 0x0084755C File Offset: 0x0084575C
	// (set) Token: 0x0601AFA8 RID: 110504 RVA: 0x00847595 File Offset: 0x00845795
	[UProperty(EPropertyFlags.CPF_None)]
	public FKuroCurveLinearColor DissolveTexSpeed
	{
		get
		{
			base.FastCheckIsValid();
			FKuroCurveLinearColor result;
			if ((result = this._DissolveTexSpeed) == null)
			{
				result = (this._DissolveTexSpeed = new FKuroCurveLinearColor(base.NativePtr + (IntPtr)ItemMaterialControllerActorData.__PropertyOffset_DissolveTexSpeed, this));
			}
			return result;
		}
		set
		{
			UnrealReflectionUtils.CopyNativeStruct(FKuroCurveLinearColor.StaticStruct(), base.NativePtr + (IntPtr)ItemMaterialControllerActorData.__PropertyOffset_DissolveTexSpeed, (value != null) ? value.NativePtr : ((IntPtr)0), 1, false);
		}
	}

	// Token: 0x17002BD4 RID: 11220
	// (get) Token: 0x0601AFA9 RID: 110505 RVA: 0x008475BD File Offset: 0x008457BD
	// (set) Token: 0x0601AFAA RID: 110506 RVA: 0x008475CD File Offset: 0x008457CD
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe ECharacterControllerUVSwitch DissolveUv
	{
		get
		{
			return (ECharacterControllerUVSwitch)(*(base.NativePtr + (IntPtr)ItemMaterialControllerActorData.__PropertyOffset_DissolveUv));
		}
		set
		{
			*(base.NativePtr + (IntPtr)ItemMaterialControllerActorData.__PropertyOffset_DissolveUv) = (byte)value;
		}
	}

	// Token: 0x17002BD5 RID: 11221
	// (get) Token: 0x0601AFAB RID: 110507 RVA: 0x008475E0 File Offset: 0x008457E0
	// (set) Token: 0x0601AFAC RID: 110508 RVA: 0x00847619 File Offset: 0x00845819
	[UProperty(EPropertyFlags.CPF_None)]
	public FKuroCurveLinearColor DissolveTexScaleOffset
	{
		get
		{
			base.FastCheckIsValid();
			FKuroCurveLinearColor result;
			if ((result = this._DissolveTexScaleOffset) == null)
			{
				result = (this._DissolveTexScaleOffset = new FKuroCurveLinearColor(base.NativePtr + (IntPtr)ItemMaterialControllerActorData.__PropertyOffset_DissolveTexScaleOffset, this));
			}
			return result;
		}
		set
		{
			UnrealReflectionUtils.CopyNativeStruct(FKuroCurveLinearColor.StaticStruct(), base.NativePtr + (IntPtr)ItemMaterialControllerActorData.__PropertyOffset_DissolveTexScaleOffset, (value != null) ? value.NativePtr : ((IntPtr)0), 1, false);
		}
	}

	// Token: 0x17002BD6 RID: 11222
	// (get) Token: 0x0601AFAD RID: 110509 RVA: 0x00847641 File Offset: 0x00845841
	// (set) Token: 0x0601AFAE RID: 110510 RVA: 0x00847651 File Offset: 0x00845851
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool EnableScanning
	{
		get
		{
			return *(base.NativePtr + (IntPtr)ItemMaterialControllerActorData.__PropertyOffset_EnableScanning) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)ItemMaterialControllerActorData.__PropertyOffset_EnableScanning) = (value ? 1 : 0);
		}
	}

	// Token: 0x17002BD7 RID: 11223
	// (get) Token: 0x0601AFAF RID: 110511 RVA: 0x00847664 File Offset: 0x00845864
	// (set) Token: 0x0601AFB0 RID: 110512 RVA: 0x0084769D File Offset: 0x0084589D
	[UProperty(EPropertyFlags.CPF_None)]
	public FKuroCurveFloat ScanningOutlineMixNoiseStrength
	{
		get
		{
			base.FastCheckIsValid();
			FKuroCurveFloat result;
			if ((result = this._ScanningOutlineMixNoiseStrength) == null)
			{
				result = (this._ScanningOutlineMixNoiseStrength = new FKuroCurveFloat(base.NativePtr + (IntPtr)ItemMaterialControllerActorData.__PropertyOffset_ScanningOutlineMixNoiseStrength, this));
			}
			return result;
		}
		set
		{
			UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)ItemMaterialControllerActorData.__PropertyOffset_ScanningOutlineMixNoiseStrength, (value != null) ? value.NativePtr : ((IntPtr)0), 1, false);
		}
	}

	// Token: 0x17002BD8 RID: 11224
	// (get) Token: 0x0601AFB1 RID: 110513 RVA: 0x008476C8 File Offset: 0x008458C8
	// (set) Token: 0x0601AFB2 RID: 110514 RVA: 0x00847701 File Offset: 0x00845901
	[UProperty(EPropertyFlags.CPF_None)]
	public FKuroCurveFloat ScanningOutlineStrength
	{
		get
		{
			base.FastCheckIsValid();
			FKuroCurveFloat result;
			if ((result = this._ScanningOutlineStrength) == null)
			{
				result = (this._ScanningOutlineStrength = new FKuroCurveFloat(base.NativePtr + (IntPtr)ItemMaterialControllerActorData.__PropertyOffset_ScanningOutlineStrength, this));
			}
			return result;
		}
		set
		{
			UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)ItemMaterialControllerActorData.__PropertyOffset_ScanningOutlineStrength, (value != null) ? value.NativePtr : ((IntPtr)0), 1, false);
		}
	}

	// Token: 0x17002BD9 RID: 11225
	// (get) Token: 0x0601AFB3 RID: 110515 RVA: 0x0084772C File Offset: 0x0084592C
	// (set) Token: 0x0601AFB4 RID: 110516 RVA: 0x00847765 File Offset: 0x00845965
	[UProperty(EPropertyFlags.CPF_None)]
	public FKuroCurveLinearColor ScanningOutlineTexScaleOffset
	{
		get
		{
			base.FastCheckIsValid();
			FKuroCurveLinearColor result;
			if ((result = this._ScanningOutlineTexScaleOffset) == null)
			{
				result = (this._ScanningOutlineTexScaleOffset = new FKuroCurveLinearColor(base.NativePtr + (IntPtr)ItemMaterialControllerActorData.__PropertyOffset_ScanningOutlineTexScaleOffset, this));
			}
			return result;
		}
		set
		{
			UnrealReflectionUtils.CopyNativeStruct(FKuroCurveLinearColor.StaticStruct(), base.NativePtr + (IntPtr)ItemMaterialControllerActorData.__PropertyOffset_ScanningOutlineTexScaleOffset, (value != null) ? value.NativePtr : ((IntPtr)0), 1, false);
		}
	}

	// Token: 0x17002BDA RID: 11226
	// (get) Token: 0x0601AFB5 RID: 110517 RVA: 0x00847790 File Offset: 0x00845990
	// (set) Token: 0x0601AFB6 RID: 110518 RVA: 0x008477C9 File Offset: 0x008459C9
	[UProperty(EPropertyFlags.CPF_None)]
	public FKuroCurveLinearColor ScanningOutlineColor
	{
		get
		{
			base.FastCheckIsValid();
			FKuroCurveLinearColor result;
			if ((result = this._ScanningOutlineColor) == null)
			{
				result = (this._ScanningOutlineColor = new FKuroCurveLinearColor(base.NativePtr + (IntPtr)ItemMaterialControllerActorData.__PropertyOffset_ScanningOutlineColor, this));
			}
			return result;
		}
		set
		{
			UnrealReflectionUtils.CopyNativeStruct(FKuroCurveLinearColor.StaticStruct(), base.NativePtr + (IntPtr)ItemMaterialControllerActorData.__PropertyOffset_ScanningOutlineColor, (value != null) ? value.NativePtr : ((IntPtr)0), 1, false);
		}
	}

	// Token: 0x17002BDB RID: 11227
	// (get) Token: 0x0601AFB7 RID: 110519 RVA: 0x008477F4 File Offset: 0x008459F4
	// (set) Token: 0x0601AFB8 RID: 110520 RVA: 0x0084782D File Offset: 0x00845A2D
	[UProperty(EPropertyFlags.CPF_None)]
	public FKuroCurveFloat VertexAnimTimeDebug
	{
		get
		{
			base.FastCheckIsValid();
			FKuroCurveFloat result;
			if ((result = this._VertexAnimTimeDebug) == null)
			{
				result = (this._VertexAnimTimeDebug = new FKuroCurveFloat(base.NativePtr + (IntPtr)ItemMaterialControllerActorData.__PropertyOffset_VertexAnimTimeDebug, this));
			}
			return result;
		}
		set
		{
			UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)ItemMaterialControllerActorData.__PropertyOffset_VertexAnimTimeDebug, (value != null) ? value.NativePtr : ((IntPtr)0), 1, false);
		}
	}

	// Token: 0x17002BDC RID: 11228
	// (get) Token: 0x0601AFB9 RID: 110521 RVA: 0x00847858 File Offset: 0x00845A58
	// (set) Token: 0x0601AFBA RID: 110522 RVA: 0x00847891 File Offset: 0x00845A91
	[UProperty(EPropertyFlags.CPF_None)]
	public FKuroCurveFloat VertexAnimFrame
	{
		get
		{
			base.FastCheckIsValid();
			FKuroCurveFloat result;
			if ((result = this._VertexAnimFrame) == null)
			{
				result = (this._VertexAnimFrame = new FKuroCurveFloat(base.NativePtr + (IntPtr)ItemMaterialControllerActorData.__PropertyOffset_VertexAnimFrame, this));
			}
			return result;
		}
		set
		{
			UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)ItemMaterialControllerActorData.__PropertyOffset_VertexAnimFrame, (value != null) ? value.NativePtr : ((IntPtr)0), 1, false);
		}
	}

	// Token: 0x17002BDD RID: 11229
	// (get) Token: 0x0601AFBB RID: 110523 RVA: 0x008478BC File Offset: 0x00845ABC
	// (set) Token: 0x0601AFBC RID: 110524 RVA: 0x008478F5 File Offset: 0x00845AF5
	[UProperty(EPropertyFlags.CPF_None)]
	public FKuroCurveLinearColor PivotPainterTransform
	{
		get
		{
			base.FastCheckIsValid();
			FKuroCurveLinearColor result;
			if ((result = this._PivotPainterTransform) == null)
			{
				result = (this._PivotPainterTransform = new FKuroCurveLinearColor(base.NativePtr + (IntPtr)ItemMaterialControllerActorData.__PropertyOffset_PivotPainterTransform, this));
			}
			return result;
		}
		set
		{
			UnrealReflectionUtils.CopyNativeStruct(FKuroCurveLinearColor.StaticStruct(), base.NativePtr + (IntPtr)ItemMaterialControllerActorData.__PropertyOffset_PivotPainterTransform, (value != null) ? value.NativePtr : ((IntPtr)0), 1, false);
		}
	}

	// Token: 0x17002BDE RID: 11230
	// (get) Token: 0x0601AFBD RID: 110525 RVA: 0x00847920 File Offset: 0x00845B20
	// (set) Token: 0x0601AFBE RID: 110526 RVA: 0x00847959 File Offset: 0x00845B59
	[UProperty(EPropertyFlags.CPF_None)]
	public FKuroCurveFloat FloatingThreshold
	{
		get
		{
			base.FastCheckIsValid();
			FKuroCurveFloat result;
			if ((result = this._FloatingThreshold) == null)
			{
				result = (this._FloatingThreshold = new FKuroCurveFloat(base.NativePtr + (IntPtr)ItemMaterialControllerActorData.__PropertyOffset_FloatingThreshold, this));
			}
			return result;
		}
		set
		{
			UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)ItemMaterialControllerActorData.__PropertyOffset_FloatingThreshold, (value != null) ? value.NativePtr : ((IntPtr)0), 1, false);
		}
	}

	// Token: 0x17002BDF RID: 11231
	// (get) Token: 0x0601AFBF RID: 110527 RVA: 0x00847981 File Offset: 0x00845B81
	// (set) Token: 0x0601AFC0 RID: 110528 RVA: 0x00847991 File Offset: 0x00845B91
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool EnablePivotPainterWorldPositionOffset
	{
		get
		{
			return *(base.NativePtr + (IntPtr)ItemMaterialControllerActorData.__PropertyOffset_EnablePivotPainterWorldPositionOffset) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)ItemMaterialControllerActorData.__PropertyOffset_EnablePivotPainterWorldPositionOffset) = (value ? 1 : 0);
		}
	}

	// Token: 0x17002BE0 RID: 11232
	// (get) Token: 0x0601AFC1 RID: 110529 RVA: 0x008479A2 File Offset: 0x00845BA2
	// (set) Token: 0x0601AFC2 RID: 110530 RVA: 0x008479B2 File Offset: 0x00845BB2
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool EnableWorldPositionOffset
	{
		get
		{
			return *(base.NativePtr + (IntPtr)ItemMaterialControllerActorData.__PropertyOffset_EnableWorldPositionOffset) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)ItemMaterialControllerActorData.__PropertyOffset_EnableWorldPositionOffset) = (value ? 1 : 0);
		}
	}

	// Token: 0x17002BE1 RID: 11233
	// (get) Token: 0x0601AFC3 RID: 110531 RVA: 0x008479C3 File Offset: 0x00845BC3
	// (set) Token: 0x0601AFC4 RID: 110532 RVA: 0x008479D3 File Offset: 0x00845BD3
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool DisableFoliageEffect
	{
		get
		{
			return *(base.NativePtr + (IntPtr)ItemMaterialControllerActorData.__PropertyOffset_DisableFoliageEffect) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)ItemMaterialControllerActorData.__PropertyOffset_DisableFoliageEffect) = (value ? 1 : 0);
		}
	}

	// Token: 0x17002BE2 RID: 11234
	// (get) Token: 0x0601AFC5 RID: 110533 RVA: 0x008479E4 File Offset: 0x00845BE4
	// (set) Token: 0x0601AFC6 RID: 110534 RVA: 0x008479F4 File Offset: 0x00845BF4
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool EnableFoliageEffect
	{
		get
		{
			return *(base.NativePtr + (IntPtr)ItemMaterialControllerActorData.__PropertyOffset_EnableFoliageEffect) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)ItemMaterialControllerActorData.__PropertyOffset_EnableFoliageEffect) = (value ? 1 : 0);
		}
	}

	// Token: 0x17002BE3 RID: 11235
	// (get) Token: 0x0601AFC7 RID: 110535 RVA: 0x00847A08 File Offset: 0x00845C08
	// (set) Token: 0x0601AFC8 RID: 110536 RVA: 0x00847A41 File Offset: 0x00845C41
	[UProperty(EPropertyFlags.CPF_None)]
	public FKuroCurveLinearColor RimLightColorSpecil
	{
		get
		{
			base.FastCheckIsValid();
			FKuroCurveLinearColor result;
			if ((result = this._RimLightColorSpecil) == null)
			{
				result = (this._RimLightColorSpecil = new FKuroCurveLinearColor(base.NativePtr + (IntPtr)ItemMaterialControllerActorData.__PropertyOffset_RimLightColorSpecil, this));
			}
			return result;
		}
		set
		{
			UnrealReflectionUtils.CopyNativeStruct(FKuroCurveLinearColor.StaticStruct(), base.NativePtr + (IntPtr)ItemMaterialControllerActorData.__PropertyOffset_RimLightColorSpecil, (value != null) ? value.NativePtr : ((IntPtr)0), 1, false);
		}
	}

	// Token: 0x17002BE4 RID: 11236
	// (get) Token: 0x0601AFC9 RID: 110537 RVA: 0x00847A69 File Offset: 0x00845C69
	// (set) Token: 0x0601AFCA RID: 110538 RVA: 0x00847A79 File Offset: 0x00845C79
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool UseRimlightColorSpecil
	{
		get
		{
			return *(base.NativePtr + (IntPtr)ItemMaterialControllerActorData.__PropertyOffset_UseRimlightColorSpecil) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)ItemMaterialControllerActorData.__PropertyOffset_UseRimlightColorSpecil) = (value ? 1 : 0);
		}
	}

	// Token: 0x17002BE5 RID: 11237
	// (get) Token: 0x0601AFCB RID: 110539 RVA: 0x00847A8C File Offset: 0x00845C8C
	// (set) Token: 0x0601AFCC RID: 110540 RVA: 0x00847AC5 File Offset: 0x00845CC5
	[UProperty(EPropertyFlags.CPF_None)]
	public FKuroCurveFloat RimlightColorStrength
	{
		get
		{
			base.FastCheckIsValid();
			FKuroCurveFloat result;
			if ((result = this._RimlightColorStrength) == null)
			{
				result = (this._RimlightColorStrength = new FKuroCurveFloat(base.NativePtr + (IntPtr)ItemMaterialControllerActorData.__PropertyOffset_RimlightColorStrength, this));
			}
			return result;
		}
		set
		{
			UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)ItemMaterialControllerActorData.__PropertyOffset_RimlightColorStrength, (value != null) ? value.NativePtr : ((IntPtr)0), 1, false);
		}
	}

	// Token: 0x17002BE6 RID: 11238
	// (get) Token: 0x0601AFCD RID: 110541 RVA: 0x00847AED File Offset: 0x00845CED
	// (set) Token: 0x0601AFCE RID: 110542 RVA: 0x00847AFD File Offset: 0x00845CFD
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool UseEmissionTex
	{
		get
		{
			return *(base.NativePtr + (IntPtr)ItemMaterialControllerActorData.__PropertyOffset_UseEmissionTex) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)ItemMaterialControllerActorData.__PropertyOffset_UseEmissionTex) = (value ? 1 : 0);
		}
	}

	// Token: 0x17002BE7 RID: 11239
	// (get) Token: 0x0601AFCF RID: 110543 RVA: 0x00847B10 File Offset: 0x00845D10
	// (set) Token: 0x0601AFD0 RID: 110544 RVA: 0x00847B49 File Offset: 0x00845D49
	[UProperty(EPropertyFlags.CPF_None)]
	public FKuroCurveFloat EmissionTexStrength
	{
		get
		{
			base.FastCheckIsValid();
			FKuroCurveFloat result;
			if ((result = this._EmissionTexStrength) == null)
			{
				result = (this._EmissionTexStrength = new FKuroCurveFloat(base.NativePtr + (IntPtr)ItemMaterialControllerActorData.__PropertyOffset_EmissionTexStrength, this));
			}
			return result;
		}
		set
		{
			UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)ItemMaterialControllerActorData.__PropertyOffset_EmissionTexStrength, (value != null) ? value.NativePtr : ((IntPtr)0), 1, false);
		}
	}

	// Token: 0x17002BE8 RID: 11240
	// (get) Token: 0x0601AFD1 RID: 110545 RVA: 0x00847B74 File Offset: 0x00845D74
	// (set) Token: 0x0601AFD2 RID: 110546 RVA: 0x00847BAD File Offset: 0x00845DAD
	[UProperty(EPropertyFlags.CPF_None)]
	public FKuroCurveFloat WorldPositionOffsetNormal
	{
		get
		{
			base.FastCheckIsValid();
			FKuroCurveFloat result;
			if ((result = this._WorldPositionOffsetNormal) == null)
			{
				result = (this._WorldPositionOffsetNormal = new FKuroCurveFloat(base.NativePtr + (IntPtr)ItemMaterialControllerActorData.__PropertyOffset_WorldPositionOffsetNormal, this));
			}
			return result;
		}
		set
		{
			UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)ItemMaterialControllerActorData.__PropertyOffset_WorldPositionOffsetNormal, (value != null) ? value.NativePtr : ((IntPtr)0), 1, false);
		}
	}

	// Token: 0x17002BE9 RID: 11241
	// (get) Token: 0x0601AFD3 RID: 110547 RVA: 0x00847BD8 File Offset: 0x00845DD8
	// (set) Token: 0x0601AFD4 RID: 110548 RVA: 0x00847C11 File Offset: 0x00845E11
	[UProperty(EPropertyFlags.CPF_None)]
	public FKuroCurveLinearColor WorldPositionOffsetOffset
	{
		get
		{
			base.FastCheckIsValid();
			FKuroCurveLinearColor result;
			if ((result = this._WorldPositionOffsetOffset) == null)
			{
				result = (this._WorldPositionOffsetOffset = new FKuroCurveLinearColor(base.NativePtr + (IntPtr)ItemMaterialControllerActorData.__PropertyOffset_WorldPositionOffsetOffset, this));
			}
			return result;
		}
		set
		{
			UnrealReflectionUtils.CopyNativeStruct(FKuroCurveLinearColor.StaticStruct(), base.NativePtr + (IntPtr)ItemMaterialControllerActorData.__PropertyOffset_WorldPositionOffsetOffset, (value != null) ? value.NativePtr : ((IntPtr)0), 1, false);
		}
	}

	// Token: 0x17002BEA RID: 11242
	// (get) Token: 0x0601AFD5 RID: 110549 RVA: 0x00847C3C File Offset: 0x00845E3C
	// (set) Token: 0x0601AFD6 RID: 110550 RVA: 0x00847C75 File Offset: 0x00845E75
	[UProperty(EPropertyFlags.CPF_None)]
	public FKuroCurveFloat SimpleUspeed
	{
		get
		{
			base.FastCheckIsValid();
			FKuroCurveFloat result;
			if ((result = this._SimpleUspeed) == null)
			{
				result = (this._SimpleUspeed = new FKuroCurveFloat(base.NativePtr + (IntPtr)ItemMaterialControllerActorData.__PropertyOffset_SimpleUspeed, this));
			}
			return result;
		}
		set
		{
			UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)ItemMaterialControllerActorData.__PropertyOffset_SimpleUspeed, (value != null) ? value.NativePtr : ((IntPtr)0), 1, false);
		}
	}

	// Token: 0x17002BEB RID: 11243
	// (get) Token: 0x0601AFD7 RID: 110551 RVA: 0x00847CA0 File Offset: 0x00845EA0
	// (set) Token: 0x0601AFD8 RID: 110552 RVA: 0x00847CD9 File Offset: 0x00845ED9
	[UProperty(EPropertyFlags.CPF_None)]
	public FKuroCurveFloat SimpleVspeed
	{
		get
		{
			base.FastCheckIsValid();
			FKuroCurveFloat result;
			if ((result = this._SimpleVspeed) == null)
			{
				result = (this._SimpleVspeed = new FKuroCurveFloat(base.NativePtr + (IntPtr)ItemMaterialControllerActorData.__PropertyOffset_SimpleVspeed, this));
			}
			return result;
		}
		set
		{
			UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)ItemMaterialControllerActorData.__PropertyOffset_SimpleVspeed, (value != null) ? value.NativePtr : ((IntPtr)0), 1, false);
		}
	}

	// Token: 0x17002BEC RID: 11244
	// (get) Token: 0x0601AFD9 RID: 110553 RVA: 0x00847D04 File Offset: 0x00845F04
	// (set) Token: 0x0601AFDA RID: 110554 RVA: 0x00847D3D File Offset: 0x00845F3D
	[UProperty(EPropertyFlags.CPF_None)]
	public FKuroCurveFloat SimpleUseFlow
	{
		get
		{
			base.FastCheckIsValid();
			FKuroCurveFloat result;
			if ((result = this._SimpleUseFlow) == null)
			{
				result = (this._SimpleUseFlow = new FKuroCurveFloat(base.NativePtr + (IntPtr)ItemMaterialControllerActorData.__PropertyOffset_SimpleUseFlow, this));
			}
			return result;
		}
		set
		{
			UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)ItemMaterialControllerActorData.__PropertyOffset_SimpleUseFlow, (value != null) ? value.NativePtr : ((IntPtr)0), 1, false);
		}
	}

	// Token: 0x17002BED RID: 11245
	// (get) Token: 0x0601AFDB RID: 110555 RVA: 0x00847D65 File Offset: 0x00845F65
	// (set) Token: 0x0601AFDC RID: 110556 RVA: 0x00847D75 File Offset: 0x00845F75
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool EnableQuanXiPinTu
	{
		get
		{
			return *(base.NativePtr + (IntPtr)ItemMaterialControllerActorData.__PropertyOffset_EnableQuanXiPinTu) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)ItemMaterialControllerActorData.__PropertyOffset_EnableQuanXiPinTu) = (value ? 1 : 0);
		}
	}

	// Token: 0x17002BEE RID: 11246
	// (get) Token: 0x0601AFDD RID: 110557 RVA: 0x00847D88 File Offset: 0x00845F88
	// (set) Token: 0x0601AFDE RID: 110558 RVA: 0x00847DC1 File Offset: 0x00845FC1
	[UProperty(EPropertyFlags.CPF_None)]
	public FKuroCurveFloat TransparencyQuanXiPinTu
	{
		get
		{
			base.FastCheckIsValid();
			FKuroCurveFloat result;
			if ((result = this._TransparencyQuanXiPinTu) == null)
			{
				result = (this._TransparencyQuanXiPinTu = new FKuroCurveFloat(base.NativePtr + (IntPtr)ItemMaterialControllerActorData.__PropertyOffset_TransparencyQuanXiPinTu, this));
			}
			return result;
		}
		set
		{
			UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)ItemMaterialControllerActorData.__PropertyOffset_TransparencyQuanXiPinTu, (value != null) ? value.NativePtr : ((IntPtr)0), 1, false);
		}
	}

	// Token: 0x17002BEF RID: 11247
	// (get) Token: 0x0601AFDF RID: 110559 RVA: 0x00847DEC File Offset: 0x00845FEC
	// (set) Token: 0x0601AFE0 RID: 110560 RVA: 0x00847E25 File Offset: 0x00846025
	[UProperty(EPropertyFlags.CPF_None)]
	public FKuroCurveLinearColor TransparentColorQuanXiPinTu
	{
		get
		{
			base.FastCheckIsValid();
			FKuroCurveLinearColor result;
			if ((result = this._TransparentColorQuanXiPinTu) == null)
			{
				result = (this._TransparentColorQuanXiPinTu = new FKuroCurveLinearColor(base.NativePtr + (IntPtr)ItemMaterialControllerActorData.__PropertyOffset_TransparentColorQuanXiPinTu, this));
			}
			return result;
		}
		set
		{
			UnrealReflectionUtils.CopyNativeStruct(FKuroCurveLinearColor.StaticStruct(), base.NativePtr + (IntPtr)ItemMaterialControllerActorData.__PropertyOffset_TransparentColorQuanXiPinTu, (value != null) ? value.NativePtr : ((IntPtr)0), 1, false);
		}
	}

	// Token: 0x17002BF0 RID: 11248
	// (get) Token: 0x0601AFE1 RID: 110561 RVA: 0x00847E50 File Offset: 0x00846050
	// (set) Token: 0x0601AFE2 RID: 110562 RVA: 0x00847E89 File Offset: 0x00846089
	[UProperty(EPropertyFlags.CPF_None)]
	public FKuroCurveLinearColor OpaqueColorQuanXiPinTu
	{
		get
		{
			base.FastCheckIsValid();
			FKuroCurveLinearColor result;
			if ((result = this._OpaqueColorQuanXiPinTu) == null)
			{
				result = (this._OpaqueColorQuanXiPinTu = new FKuroCurveLinearColor(base.NativePtr + (IntPtr)ItemMaterialControllerActorData.__PropertyOffset_OpaqueColorQuanXiPinTu, this));
			}
			return result;
		}
		set
		{
			UnrealReflectionUtils.CopyNativeStruct(FKuroCurveLinearColor.StaticStruct(), base.NativePtr + (IntPtr)ItemMaterialControllerActorData.__PropertyOffset_OpaqueColorQuanXiPinTu, (value != null) ? value.NativePtr : ((IntPtr)0), 1, false);
		}
	}

	// Token: 0x17002BF1 RID: 11249
	// (get) Token: 0x0601AFE3 RID: 110563 RVA: 0x00847EB1 File Offset: 0x008460B1
	// (set) Token: 0x0601AFE4 RID: 110564 RVA: 0x00847EC1 File Offset: 0x008460C1
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool EnableQuanXiFengSuo
	{
		get
		{
			return *(base.NativePtr + (IntPtr)ItemMaterialControllerActorData.__PropertyOffset_EnableQuanXiFengSuo) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)ItemMaterialControllerActorData.__PropertyOffset_EnableQuanXiFengSuo) = (value ? 1 : 0);
		}
	}

	// Token: 0x17002BF2 RID: 11250
	// (get) Token: 0x0601AFE5 RID: 110565 RVA: 0x00847ED4 File Offset: 0x008460D4
	// (set) Token: 0x0601AFE6 RID: 110566 RVA: 0x00847F0D File Offset: 0x0084610D
	[UProperty(EPropertyFlags.CPF_None)]
	public FKuroCurveFloat TransparencyQuanXiFengSuo
	{
		get
		{
			base.FastCheckIsValid();
			FKuroCurveFloat result;
			if ((result = this._TransparencyQuanXiFengSuo) == null)
			{
				result = (this._TransparencyQuanXiFengSuo = new FKuroCurveFloat(base.NativePtr + (IntPtr)ItemMaterialControllerActorData.__PropertyOffset_TransparencyQuanXiFengSuo, this));
			}
			return result;
		}
		set
		{
			UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)ItemMaterialControllerActorData.__PropertyOffset_TransparencyQuanXiFengSuo, (value != null) ? value.NativePtr : ((IntPtr)0), 1, false);
		}
	}

	// Token: 0x17002BF3 RID: 11251
	// (get) Token: 0x0601AFE7 RID: 110567 RVA: 0x00847F38 File Offset: 0x00846138
	// (set) Token: 0x0601AFE8 RID: 110568 RVA: 0x00847F71 File Offset: 0x00846171
	[UProperty(EPropertyFlags.CPF_None)]
	public FKuroCurveLinearColor TransparentColorQuanXiFengSuo
	{
		get
		{
			base.FastCheckIsValid();
			FKuroCurveLinearColor result;
			if ((result = this._TransparentColorQuanXiFengSuo) == null)
			{
				result = (this._TransparentColorQuanXiFengSuo = new FKuroCurveLinearColor(base.NativePtr + (IntPtr)ItemMaterialControllerActorData.__PropertyOffset_TransparentColorQuanXiFengSuo, this));
			}
			return result;
		}
		set
		{
			UnrealReflectionUtils.CopyNativeStruct(FKuroCurveLinearColor.StaticStruct(), base.NativePtr + (IntPtr)ItemMaterialControllerActorData.__PropertyOffset_TransparentColorQuanXiFengSuo, (value != null) ? value.NativePtr : ((IntPtr)0), 1, false);
		}
	}

	// Token: 0x17002BF4 RID: 11252
	// (get) Token: 0x0601AFE9 RID: 110569 RVA: 0x00847F9C File Offset: 0x0084619C
	[UProperty(EPropertyFlags.CPF_None)]
	public TMap<FName, FKuroCurveFloat> CustomScalarParMap
	{
		get
		{
			base.FastCheckIsValid();
			TMap<FName, FKuroCurveFloat> result;
			if ((result = this._CustomScalarParMap) == null)
			{
				result = (this._CustomScalarParMap = new TMap<FName, FKuroCurveFloat>(base.NativePtr + (IntPtr)ItemMaterialControllerActorData.__PropertyOffset_CustomScalarParMap, this));
			}
			return result;
		}
	}

	// Token: 0x17002BF5 RID: 11253
	// (get) Token: 0x0601AFEA RID: 110570 RVA: 0x00847FD8 File Offset: 0x008461D8
	[UProperty(EPropertyFlags.CPF_None)]
	public TMap<FName, FKuroCurveLinearColor> CustomColorParMap
	{
		get
		{
			base.FastCheckIsValid();
			TMap<FName, FKuroCurveLinearColor> result;
			if ((result = this._CustomColorParMap) == null)
			{
				result = (this._CustomColorParMap = new TMap<FName, FKuroCurveLinearColor>(base.NativePtr + (IntPtr)ItemMaterialControllerActorData.__PropertyOffset_CustomColorParMap, this));
			}
			return result;
		}
	}

	// Token: 0x17002BF6 RID: 11254
	// (get) Token: 0x0601AFEB RID: 110571 RVA: 0x00848014 File Offset: 0x00846214
	[UProperty(EPropertyFlags.CPF_None)]
	public TMap<FName, UTexture> CustomTexParMap
	{
		get
		{
			base.FastCheckIsValid();
			TMap<FName, UTexture> result;
			if ((result = this._CustomTexParMap) == null)
			{
				result = (this._CustomTexParMap = new TMap<FName, UTexture>(base.NativePtr + (IntPtr)ItemMaterialControllerActorData.__PropertyOffset_CustomTexParMap, this));
			}
			return result;
		}
	}

	// Token: 0x17002BF7 RID: 11255
	// (get) Token: 0x0601AFEC RID: 110572 RVA: 0x0084804D File Offset: 0x0084624D
	// (set) Token: 0x0601AFED RID: 110573 RVA: 0x0084805D File Offset: 0x0084625D
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool RevertCustomTexParOnDestroy
	{
		get
		{
			return *(base.NativePtr + (IntPtr)ItemMaterialControllerActorData.__PropertyOffset_RevertCustomTexParOnDestroy) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)ItemMaterialControllerActorData.__PropertyOffset_RevertCustomTexParOnDestroy) = (value ? 1 : 0);
		}
	}

	// Token: 0x0601AFEE RID: 110574 RVA: 0x0084806E File Offset: 0x0084626E
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (ItemMaterialControllerActorData._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Render/Scene/Item/MaterialController/ItemMaterialControllerActorData.ItemMaterialControllerActorData_C");
		}
		return ItemMaterialControllerActorData._ClassPtr;
	}

	// Token: 0x0601AFEF RID: 110575 RVA: 0x00848094 File Offset: 0x00846294
	public ItemMaterialControllerActorData() : this(BuiltinUtils.AllocNativeUObject(ItemMaterialControllerActorData.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601AFF0 RID: 110576 RVA: 0x008480BC File Offset: 0x008462BC
	public ItemMaterialControllerActorData(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ItemMaterialControllerActorData.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601AFF1 RID: 110577 RVA: 0x008480EF File Offset: 0x008462EF
	protected ItemMaterialControllerActorData(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0400EA70 RID: 60016
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Render/Scene/Item/MaterialController/ItemMaterialControllerActorData.ItemMaterialControllerActorData_C";

	// Token: 0x0400EA71 RID: 60017
	private static IntPtr _ClassPtr;

	// Token: 0x0400EA72 RID: 60018
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400EA73 RID: 60019
	private static int __PropertyOffset_StartTime;

	// Token: 0x0400EA74 RID: 60020
	private static int __PropertyOffset_LoopTime;

	// Token: 0x0400EA75 RID: 60021
	private static int __PropertyOffset_EndTime;

	// Token: 0x0400EA76 RID: 60022
	private static int __PropertyOffset_EnableBaseColorScale;

	// Token: 0x0400EA77 RID: 60023
	private static int __PropertyOffset_BaseColorScale;

	// Token: 0x0400EA78 RID: 60024
	[Nullable(2)]
	private FKuroCurveFloat _BaseColorScale;

	// Token: 0x0400EA79 RID: 60025
	private static int __PropertyOffset_EnableAddEmissionColor;

	// Token: 0x0400EA7A RID: 60026
	private static int __PropertyOffset_AddEmissionColor;

	// Token: 0x0400EA7B RID: 60027
	[Nullable(2)]
	private FKuroCurveLinearColor _AddEmissionColor;

	// Token: 0x0400EA7C RID: 60028
	private static int __PropertyOffset_EnableEmissionChange;

	// Token: 0x0400EA7D RID: 60029
	private static int __PropertyOffset_EmissionLightColorChangeProgress;

	// Token: 0x0400EA7E RID: 60030
	[Nullable(2)]
	private FKuroCurveFloat _EmissionLightColorChangeProgress;

	// Token: 0x0400EA7F RID: 60031
	private static int __PropertyOffset_EmissionLightColorChangeStrength;

	// Token: 0x0400EA80 RID: 60032
	[Nullable(2)]
	private FKuroCurveFloat _EmissionLightColorChangeStrength;

	// Token: 0x0400EA81 RID: 60033
	private static int __PropertyOffset_EmissionLightColorChangeColor;

	// Token: 0x0400EA82 RID: 60034
	[Nullable(2)]
	private FKuroCurveLinearColor _EmissionLightColorChangeColor;

	// Token: 0x0400EA83 RID: 60035
	private static int __PropertyOffset_EnableRimLight;

	// Token: 0x0400EA84 RID: 60036
	private static int __PropertyOffset_RimLightColor;

	// Token: 0x0400EA85 RID: 60037
	[Nullable(2)]
	private FKuroCurveLinearColor _RimLightColor;

	// Token: 0x0400EA86 RID: 60038
	private static int __PropertyOffset_RimPower;

	// Token: 0x0400EA87 RID: 60039
	[Nullable(2)]
	private FKuroCurveFloat _RimPower;

	// Token: 0x0400EA88 RID: 60040
	private static int __PropertyOffset_EnableDissolve;

	// Token: 0x0400EA89 RID: 60041
	private static int __PropertyOffset_DissolveProgress;

	// Token: 0x0400EA8A RID: 60042
	[Nullable(2)]
	private FKuroCurveFloat _DissolveProgress;

	// Token: 0x0400EA8B RID: 60043
	private static int __PropertyOffset_DissolveAdjustment;

	// Token: 0x0400EA8C RID: 60044
	[Nullable(2)]
	private FKuroCurveFloat _DissolveAdjustment;

	// Token: 0x0400EA8D RID: 60045
	private static int __PropertyOffset_DissolveEdageWidth;

	// Token: 0x0400EA8E RID: 60046
	[Nullable(2)]
	private FKuroCurveFloat _DissolveEdageWidth;

	// Token: 0x0400EA8F RID: 60047
	private static int __PropertyOffset_DissolveEdageColor;

	// Token: 0x0400EA90 RID: 60048
	[Nullable(2)]
	private FKuroCurveLinearColor _DissolveEdageColor;

	// Token: 0x0400EA91 RID: 60049
	private static int __PropertyOffset_DissolveEdageStrength;

	// Token: 0x0400EA92 RID: 60050
	[Nullable(2)]
	private FKuroCurveFloat _DissolveEdageStrength;

	// Token: 0x0400EA93 RID: 60051
	private static int __PropertyOffset_DissolveTexSpeed;

	// Token: 0x0400EA94 RID: 60052
	[Nullable(2)]
	private FKuroCurveLinearColor _DissolveTexSpeed;

	// Token: 0x0400EA95 RID: 60053
	private static int __PropertyOffset_DissolveUv;

	// Token: 0x0400EA96 RID: 60054
	private static int __PropertyOffset_DissolveTexScaleOffset;

	// Token: 0x0400EA97 RID: 60055
	[Nullable(2)]
	private FKuroCurveLinearColor _DissolveTexScaleOffset;

	// Token: 0x0400EA98 RID: 60056
	private static int __PropertyOffset_EnableScanning;

	// Token: 0x0400EA99 RID: 60057
	private static int __PropertyOffset_ScanningOutlineMixNoiseStrength;

	// Token: 0x0400EA9A RID: 60058
	[Nullable(2)]
	private FKuroCurveFloat _ScanningOutlineMixNoiseStrength;

	// Token: 0x0400EA9B RID: 60059
	private static int __PropertyOffset_ScanningOutlineStrength;

	// Token: 0x0400EA9C RID: 60060
	[Nullable(2)]
	private FKuroCurveFloat _ScanningOutlineStrength;

	// Token: 0x0400EA9D RID: 60061
	private static int __PropertyOffset_ScanningOutlineTexScaleOffset;

	// Token: 0x0400EA9E RID: 60062
	[Nullable(2)]
	private FKuroCurveLinearColor _ScanningOutlineTexScaleOffset;

	// Token: 0x0400EA9F RID: 60063
	private static int __PropertyOffset_ScanningOutlineColor;

	// Token: 0x0400EAA0 RID: 60064
	[Nullable(2)]
	private FKuroCurveLinearColor _ScanningOutlineColor;

	// Token: 0x0400EAA1 RID: 60065
	private static int __PropertyOffset_VertexAnimTimeDebug;

	// Token: 0x0400EAA2 RID: 60066
	[Nullable(2)]
	private FKuroCurveFloat _VertexAnimTimeDebug;

	// Token: 0x0400EAA3 RID: 60067
	private static int __PropertyOffset_VertexAnimFrame;

	// Token: 0x0400EAA4 RID: 60068
	[Nullable(2)]
	private FKuroCurveFloat _VertexAnimFrame;

	// Token: 0x0400EAA5 RID: 60069
	private static int __PropertyOffset_PivotPainterTransform;

	// Token: 0x0400EAA6 RID: 60070
	[Nullable(2)]
	private FKuroCurveLinearColor _PivotPainterTransform;

	// Token: 0x0400EAA7 RID: 60071
	private static int __PropertyOffset_FloatingThreshold;

	// Token: 0x0400EAA8 RID: 60072
	[Nullable(2)]
	private FKuroCurveFloat _FloatingThreshold;

	// Token: 0x0400EAA9 RID: 60073
	private static int __PropertyOffset_EnablePivotPainterWorldPositionOffset;

	// Token: 0x0400EAAA RID: 60074
	private static int __PropertyOffset_EnableWorldPositionOffset;

	// Token: 0x0400EAAB RID: 60075
	private static int __PropertyOffset_DisableFoliageEffect;

	// Token: 0x0400EAAC RID: 60076
	private static int __PropertyOffset_EnableFoliageEffect;

	// Token: 0x0400EAAD RID: 60077
	private static int __PropertyOffset_RimLightColorSpecil;

	// Token: 0x0400EAAE RID: 60078
	[Nullable(2)]
	private FKuroCurveLinearColor _RimLightColorSpecil;

	// Token: 0x0400EAAF RID: 60079
	private static int __PropertyOffset_UseRimlightColorSpecil;

	// Token: 0x0400EAB0 RID: 60080
	private static int __PropertyOffset_RimlightColorStrength;

	// Token: 0x0400EAB1 RID: 60081
	[Nullable(2)]
	private FKuroCurveFloat _RimlightColorStrength;

	// Token: 0x0400EAB2 RID: 60082
	private static int __PropertyOffset_UseEmissionTex;

	// Token: 0x0400EAB3 RID: 60083
	private static int __PropertyOffset_EmissionTexStrength;

	// Token: 0x0400EAB4 RID: 60084
	[Nullable(2)]
	private FKuroCurveFloat _EmissionTexStrength;

	// Token: 0x0400EAB5 RID: 60085
	private static int __PropertyOffset_WorldPositionOffsetNormal;

	// Token: 0x0400EAB6 RID: 60086
	[Nullable(2)]
	private FKuroCurveFloat _WorldPositionOffsetNormal;

	// Token: 0x0400EAB7 RID: 60087
	private static int __PropertyOffset_WorldPositionOffsetOffset;

	// Token: 0x0400EAB8 RID: 60088
	[Nullable(2)]
	private FKuroCurveLinearColor _WorldPositionOffsetOffset;

	// Token: 0x0400EAB9 RID: 60089
	private static int __PropertyOffset_SimpleUspeed;

	// Token: 0x0400EABA RID: 60090
	[Nullable(2)]
	private FKuroCurveFloat _SimpleUspeed;

	// Token: 0x0400EABB RID: 60091
	private static int __PropertyOffset_SimpleVspeed;

	// Token: 0x0400EABC RID: 60092
	[Nullable(2)]
	private FKuroCurveFloat _SimpleVspeed;

	// Token: 0x0400EABD RID: 60093
	private static int __PropertyOffset_SimpleUseFlow;

	// Token: 0x0400EABE RID: 60094
	[Nullable(2)]
	private FKuroCurveFloat _SimpleUseFlow;

	// Token: 0x0400EABF RID: 60095
	private static int __PropertyOffset_EnableQuanXiPinTu;

	// Token: 0x0400EAC0 RID: 60096
	private static int __PropertyOffset_TransparencyQuanXiPinTu;

	// Token: 0x0400EAC1 RID: 60097
	[Nullable(2)]
	private FKuroCurveFloat _TransparencyQuanXiPinTu;

	// Token: 0x0400EAC2 RID: 60098
	private static int __PropertyOffset_TransparentColorQuanXiPinTu;

	// Token: 0x0400EAC3 RID: 60099
	[Nullable(2)]
	private FKuroCurveLinearColor _TransparentColorQuanXiPinTu;

	// Token: 0x0400EAC4 RID: 60100
	private static int __PropertyOffset_OpaqueColorQuanXiPinTu;

	// Token: 0x0400EAC5 RID: 60101
	[Nullable(2)]
	private FKuroCurveLinearColor _OpaqueColorQuanXiPinTu;

	// Token: 0x0400EAC6 RID: 60102
	private static int __PropertyOffset_EnableQuanXiFengSuo;

	// Token: 0x0400EAC7 RID: 60103
	private static int __PropertyOffset_TransparencyQuanXiFengSuo;

	// Token: 0x0400EAC8 RID: 60104
	[Nullable(2)]
	private FKuroCurveFloat _TransparencyQuanXiFengSuo;

	// Token: 0x0400EAC9 RID: 60105
	private static int __PropertyOffset_TransparentColorQuanXiFengSuo;

	// Token: 0x0400EACA RID: 60106
	[Nullable(2)]
	private FKuroCurveLinearColor _TransparentColorQuanXiFengSuo;

	// Token: 0x0400EACB RID: 60107
	private static int __PropertyOffset_CustomScalarParMap;

	// Token: 0x0400EACC RID: 60108
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TMap<FName, FKuroCurveFloat> _CustomScalarParMap;

	// Token: 0x0400EACD RID: 60109
	private static int __PropertyOffset_CustomColorParMap;

	// Token: 0x0400EACE RID: 60110
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TMap<FName, FKuroCurveLinearColor> _CustomColorParMap;

	// Token: 0x0400EACF RID: 60111
	private static int __PropertyOffset_CustomTexParMap;

	// Token: 0x0400EAD0 RID: 60112
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TMap<FName, UTexture> _CustomTexParMap;

	// Token: 0x0400EAD1 RID: 60113
	private static int __PropertyOffset_RevertCustomTexParOnDestroy;
}

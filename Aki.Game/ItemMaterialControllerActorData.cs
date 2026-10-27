using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02003489 RID: 13449
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/Render/Scene/Item/MaterialController/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Render/Scene/Item/MaterialController/ItemMaterialControllerActorData.ItemMaterialControllerActorData_C")]
public class ItemMaterialControllerActorData : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
{
	// Token: 0x17002821 RID: 10273
	// (get) Token: 0x0601D278 RID: 119416 RVA: 0x0081FC9B File Offset: 0x0081DE9B
	// (set) Token: 0x0601D279 RID: 119417 RVA: 0x0081FCAB File Offset: 0x0081DEAB
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

	// Token: 0x17002822 RID: 10274
	// (get) Token: 0x0601D27A RID: 119418 RVA: 0x0081FCBC File Offset: 0x0081DEBC
	// (set) Token: 0x0601D27B RID: 119419 RVA: 0x0081FCCC File Offset: 0x0081DECC
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

	// Token: 0x17002823 RID: 10275
	// (get) Token: 0x0601D27C RID: 119420 RVA: 0x0081FCDD File Offset: 0x0081DEDD
	// (set) Token: 0x0601D27D RID: 119421 RVA: 0x0081FCED File Offset: 0x0081DEED
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

	// Token: 0x17002824 RID: 10276
	// (get) Token: 0x0601D27E RID: 119422 RVA: 0x0081FCFE File Offset: 0x0081DEFE
	// (set) Token: 0x0601D27F RID: 119423 RVA: 0x0081FD0E File Offset: 0x0081DF0E
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

	// Token: 0x17002825 RID: 10277
	// (get) Token: 0x0601D280 RID: 119424 RVA: 0x0081FD20 File Offset: 0x0081DF20
	// (set) Token: 0x0601D281 RID: 119425 RVA: 0x0081FD59 File Offset: 0x0081DF59
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

	// Token: 0x17002826 RID: 10278
	// (get) Token: 0x0601D282 RID: 119426 RVA: 0x0081FD81 File Offset: 0x0081DF81
	// (set) Token: 0x0601D283 RID: 119427 RVA: 0x0081FD91 File Offset: 0x0081DF91
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

	// Token: 0x17002827 RID: 10279
	// (get) Token: 0x0601D284 RID: 119428 RVA: 0x0081FDA4 File Offset: 0x0081DFA4
	// (set) Token: 0x0601D285 RID: 119429 RVA: 0x0081FDDD File Offset: 0x0081DFDD
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

	// Token: 0x17002828 RID: 10280
	// (get) Token: 0x0601D286 RID: 119430 RVA: 0x0081FE05 File Offset: 0x0081E005
	// (set) Token: 0x0601D287 RID: 119431 RVA: 0x0081FE15 File Offset: 0x0081E015
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

	// Token: 0x17002829 RID: 10281
	// (get) Token: 0x0601D288 RID: 119432 RVA: 0x0081FE28 File Offset: 0x0081E028
	// (set) Token: 0x0601D289 RID: 119433 RVA: 0x0081FE61 File Offset: 0x0081E061
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

	// Token: 0x1700282A RID: 10282
	// (get) Token: 0x0601D28A RID: 119434 RVA: 0x0081FE8C File Offset: 0x0081E08C
	// (set) Token: 0x0601D28B RID: 119435 RVA: 0x0081FEC5 File Offset: 0x0081E0C5
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

	// Token: 0x1700282B RID: 10283
	// (get) Token: 0x0601D28C RID: 119436 RVA: 0x0081FEF0 File Offset: 0x0081E0F0
	// (set) Token: 0x0601D28D RID: 119437 RVA: 0x0081FF29 File Offset: 0x0081E129
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

	// Token: 0x1700282C RID: 10284
	// (get) Token: 0x0601D28E RID: 119438 RVA: 0x0081FF51 File Offset: 0x0081E151
	// (set) Token: 0x0601D28F RID: 119439 RVA: 0x0081FF61 File Offset: 0x0081E161
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

	// Token: 0x1700282D RID: 10285
	// (get) Token: 0x0601D290 RID: 119440 RVA: 0x0081FF74 File Offset: 0x0081E174
	// (set) Token: 0x0601D291 RID: 119441 RVA: 0x0081FFAD File Offset: 0x0081E1AD
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

	// Token: 0x1700282E RID: 10286
	// (get) Token: 0x0601D292 RID: 119442 RVA: 0x0081FFD8 File Offset: 0x0081E1D8
	// (set) Token: 0x0601D293 RID: 119443 RVA: 0x00820011 File Offset: 0x0081E211
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

	// Token: 0x1700282F RID: 10287
	// (get) Token: 0x0601D294 RID: 119444 RVA: 0x00820039 File Offset: 0x0081E239
	// (set) Token: 0x0601D295 RID: 119445 RVA: 0x00820049 File Offset: 0x0081E249
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

	// Token: 0x17002830 RID: 10288
	// (get) Token: 0x0601D296 RID: 119446 RVA: 0x0082005C File Offset: 0x0081E25C
	// (set) Token: 0x0601D297 RID: 119447 RVA: 0x00820095 File Offset: 0x0081E295
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

	// Token: 0x17002831 RID: 10289
	// (get) Token: 0x0601D298 RID: 119448 RVA: 0x008200C0 File Offset: 0x0081E2C0
	// (set) Token: 0x0601D299 RID: 119449 RVA: 0x008200F9 File Offset: 0x0081E2F9
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

	// Token: 0x17002832 RID: 10290
	// (get) Token: 0x0601D29A RID: 119450 RVA: 0x00820124 File Offset: 0x0081E324
	// (set) Token: 0x0601D29B RID: 119451 RVA: 0x0082015D File Offset: 0x0081E35D
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

	// Token: 0x17002833 RID: 10291
	// (get) Token: 0x0601D29C RID: 119452 RVA: 0x00820188 File Offset: 0x0081E388
	// (set) Token: 0x0601D29D RID: 119453 RVA: 0x008201C1 File Offset: 0x0081E3C1
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

	// Token: 0x17002834 RID: 10292
	// (get) Token: 0x0601D29E RID: 119454 RVA: 0x008201EC File Offset: 0x0081E3EC
	// (set) Token: 0x0601D29F RID: 119455 RVA: 0x00820225 File Offset: 0x0081E425
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

	// Token: 0x17002835 RID: 10293
	// (get) Token: 0x0601D2A0 RID: 119456 RVA: 0x00820250 File Offset: 0x0081E450
	// (set) Token: 0x0601D2A1 RID: 119457 RVA: 0x00820289 File Offset: 0x0081E489
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

	// Token: 0x17002836 RID: 10294
	// (get) Token: 0x0601D2A2 RID: 119458 RVA: 0x008202B1 File Offset: 0x0081E4B1
	// (set) Token: 0x0601D2A3 RID: 119459 RVA: 0x008202C1 File Offset: 0x0081E4C1
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

	// Token: 0x17002837 RID: 10295
	// (get) Token: 0x0601D2A4 RID: 119460 RVA: 0x008202D4 File Offset: 0x0081E4D4
	// (set) Token: 0x0601D2A5 RID: 119461 RVA: 0x0082030D File Offset: 0x0081E50D
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

	// Token: 0x17002838 RID: 10296
	// (get) Token: 0x0601D2A6 RID: 119462 RVA: 0x00820335 File Offset: 0x0081E535
	// (set) Token: 0x0601D2A7 RID: 119463 RVA: 0x00820345 File Offset: 0x0081E545
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

	// Token: 0x17002839 RID: 10297
	// (get) Token: 0x0601D2A8 RID: 119464 RVA: 0x00820358 File Offset: 0x0081E558
	// (set) Token: 0x0601D2A9 RID: 119465 RVA: 0x00820391 File Offset: 0x0081E591
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

	// Token: 0x1700283A RID: 10298
	// (get) Token: 0x0601D2AA RID: 119466 RVA: 0x008203BC File Offset: 0x0081E5BC
	// (set) Token: 0x0601D2AB RID: 119467 RVA: 0x008203F5 File Offset: 0x0081E5F5
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

	// Token: 0x1700283B RID: 10299
	// (get) Token: 0x0601D2AC RID: 119468 RVA: 0x00820420 File Offset: 0x0081E620
	// (set) Token: 0x0601D2AD RID: 119469 RVA: 0x00820459 File Offset: 0x0081E659
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

	// Token: 0x1700283C RID: 10300
	// (get) Token: 0x0601D2AE RID: 119470 RVA: 0x00820484 File Offset: 0x0081E684
	// (set) Token: 0x0601D2AF RID: 119471 RVA: 0x008204BD File Offset: 0x0081E6BD
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

	// Token: 0x1700283D RID: 10301
	// (get) Token: 0x0601D2B0 RID: 119472 RVA: 0x008204E8 File Offset: 0x0081E6E8
	// (set) Token: 0x0601D2B1 RID: 119473 RVA: 0x00820521 File Offset: 0x0081E721
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

	// Token: 0x1700283E RID: 10302
	// (get) Token: 0x0601D2B2 RID: 119474 RVA: 0x0082054C File Offset: 0x0081E74C
	// (set) Token: 0x0601D2B3 RID: 119475 RVA: 0x00820585 File Offset: 0x0081E785
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

	// Token: 0x1700283F RID: 10303
	// (get) Token: 0x0601D2B4 RID: 119476 RVA: 0x008205B0 File Offset: 0x0081E7B0
	// (set) Token: 0x0601D2B5 RID: 119477 RVA: 0x008205E9 File Offset: 0x0081E7E9
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

	// Token: 0x17002840 RID: 10304
	// (get) Token: 0x0601D2B6 RID: 119478 RVA: 0x00820614 File Offset: 0x0081E814
	// (set) Token: 0x0601D2B7 RID: 119479 RVA: 0x0082064D File Offset: 0x0081E84D
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

	// Token: 0x17002841 RID: 10305
	// (get) Token: 0x0601D2B8 RID: 119480 RVA: 0x00820675 File Offset: 0x0081E875
	// (set) Token: 0x0601D2B9 RID: 119481 RVA: 0x00820685 File Offset: 0x0081E885
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

	// Token: 0x17002842 RID: 10306
	// (get) Token: 0x0601D2BA RID: 119482 RVA: 0x00820696 File Offset: 0x0081E896
	// (set) Token: 0x0601D2BB RID: 119483 RVA: 0x008206A6 File Offset: 0x0081E8A6
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

	// Token: 0x17002843 RID: 10307
	// (get) Token: 0x0601D2BC RID: 119484 RVA: 0x008206B7 File Offset: 0x0081E8B7
	// (set) Token: 0x0601D2BD RID: 119485 RVA: 0x008206C7 File Offset: 0x0081E8C7
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

	// Token: 0x17002844 RID: 10308
	// (get) Token: 0x0601D2BE RID: 119486 RVA: 0x008206D8 File Offset: 0x0081E8D8
	// (set) Token: 0x0601D2BF RID: 119487 RVA: 0x008206E8 File Offset: 0x0081E8E8
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

	// Token: 0x17002845 RID: 10309
	// (get) Token: 0x0601D2C0 RID: 119488 RVA: 0x008206FC File Offset: 0x0081E8FC
	// (set) Token: 0x0601D2C1 RID: 119489 RVA: 0x00820735 File Offset: 0x0081E935
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

	// Token: 0x17002846 RID: 10310
	// (get) Token: 0x0601D2C2 RID: 119490 RVA: 0x0082075D File Offset: 0x0081E95D
	// (set) Token: 0x0601D2C3 RID: 119491 RVA: 0x0082076D File Offset: 0x0081E96D
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

	// Token: 0x17002847 RID: 10311
	// (get) Token: 0x0601D2C4 RID: 119492 RVA: 0x00820780 File Offset: 0x0081E980
	// (set) Token: 0x0601D2C5 RID: 119493 RVA: 0x008207B9 File Offset: 0x0081E9B9
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

	// Token: 0x17002848 RID: 10312
	// (get) Token: 0x0601D2C6 RID: 119494 RVA: 0x008207E1 File Offset: 0x0081E9E1
	// (set) Token: 0x0601D2C7 RID: 119495 RVA: 0x008207F1 File Offset: 0x0081E9F1
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

	// Token: 0x17002849 RID: 10313
	// (get) Token: 0x0601D2C8 RID: 119496 RVA: 0x00820804 File Offset: 0x0081EA04
	// (set) Token: 0x0601D2C9 RID: 119497 RVA: 0x0082083D File Offset: 0x0081EA3D
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

	// Token: 0x1700284A RID: 10314
	// (get) Token: 0x0601D2CA RID: 119498 RVA: 0x00820868 File Offset: 0x0081EA68
	// (set) Token: 0x0601D2CB RID: 119499 RVA: 0x008208A1 File Offset: 0x0081EAA1
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

	// Token: 0x1700284B RID: 10315
	// (get) Token: 0x0601D2CC RID: 119500 RVA: 0x008208CC File Offset: 0x0081EACC
	// (set) Token: 0x0601D2CD RID: 119501 RVA: 0x00820905 File Offset: 0x0081EB05
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

	// Token: 0x1700284C RID: 10316
	// (get) Token: 0x0601D2CE RID: 119502 RVA: 0x00820930 File Offset: 0x0081EB30
	// (set) Token: 0x0601D2CF RID: 119503 RVA: 0x00820969 File Offset: 0x0081EB69
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

	// Token: 0x1700284D RID: 10317
	// (get) Token: 0x0601D2D0 RID: 119504 RVA: 0x00820994 File Offset: 0x0081EB94
	// (set) Token: 0x0601D2D1 RID: 119505 RVA: 0x008209CD File Offset: 0x0081EBCD
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

	// Token: 0x1700284E RID: 10318
	// (get) Token: 0x0601D2D2 RID: 119506 RVA: 0x008209F8 File Offset: 0x0081EBF8
	// (set) Token: 0x0601D2D3 RID: 119507 RVA: 0x00820A31 File Offset: 0x0081EC31
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

	// Token: 0x1700284F RID: 10319
	// (get) Token: 0x0601D2D4 RID: 119508 RVA: 0x00820A59 File Offset: 0x0081EC59
	// (set) Token: 0x0601D2D5 RID: 119509 RVA: 0x00820A69 File Offset: 0x0081EC69
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

	// Token: 0x17002850 RID: 10320
	// (get) Token: 0x0601D2D6 RID: 119510 RVA: 0x00820A7C File Offset: 0x0081EC7C
	// (set) Token: 0x0601D2D7 RID: 119511 RVA: 0x00820AB5 File Offset: 0x0081ECB5
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

	// Token: 0x17002851 RID: 10321
	// (get) Token: 0x0601D2D8 RID: 119512 RVA: 0x00820AE0 File Offset: 0x0081ECE0
	// (set) Token: 0x0601D2D9 RID: 119513 RVA: 0x00820B19 File Offset: 0x0081ED19
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

	// Token: 0x17002852 RID: 10322
	// (get) Token: 0x0601D2DA RID: 119514 RVA: 0x00820B44 File Offset: 0x0081ED44
	// (set) Token: 0x0601D2DB RID: 119515 RVA: 0x00820B7D File Offset: 0x0081ED7D
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

	// Token: 0x17002853 RID: 10323
	// (get) Token: 0x0601D2DC RID: 119516 RVA: 0x00820BA5 File Offset: 0x0081EDA5
	// (set) Token: 0x0601D2DD RID: 119517 RVA: 0x00820BB5 File Offset: 0x0081EDB5
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

	// Token: 0x17002854 RID: 10324
	// (get) Token: 0x0601D2DE RID: 119518 RVA: 0x00820BC8 File Offset: 0x0081EDC8
	// (set) Token: 0x0601D2DF RID: 119519 RVA: 0x00820C01 File Offset: 0x0081EE01
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

	// Token: 0x17002855 RID: 10325
	// (get) Token: 0x0601D2E0 RID: 119520 RVA: 0x00820C2C File Offset: 0x0081EE2C
	// (set) Token: 0x0601D2E1 RID: 119521 RVA: 0x00820C65 File Offset: 0x0081EE65
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

	// Token: 0x17002856 RID: 10326
	// (get) Token: 0x0601D2E2 RID: 119522 RVA: 0x00820C90 File Offset: 0x0081EE90
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

	// Token: 0x17002857 RID: 10327
	// (get) Token: 0x0601D2E3 RID: 119523 RVA: 0x00820CCC File Offset: 0x0081EECC
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

	// Token: 0x17002858 RID: 10328
	// (get) Token: 0x0601D2E4 RID: 119524 RVA: 0x00820D08 File Offset: 0x0081EF08
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

	// Token: 0x17002859 RID: 10329
	// (get) Token: 0x0601D2E5 RID: 119525 RVA: 0x00820D41 File Offset: 0x0081EF41
	// (set) Token: 0x0601D2E6 RID: 119526 RVA: 0x00820D51 File Offset: 0x0081EF51
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

	// Token: 0x0601D2E7 RID: 119527 RVA: 0x00820D62 File Offset: 0x0081EF62
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (ItemMaterialControllerActorData._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Render/Scene/Item/MaterialController/ItemMaterialControllerActorData.ItemMaterialControllerActorData_C");
		}
		return ItemMaterialControllerActorData._ClassPtr;
	}

	// Token: 0x0601D2E8 RID: 119528 RVA: 0x00820D88 File Offset: 0x0081EF88
	public ItemMaterialControllerActorData() : this(BuiltinUtils.AllocNativeUObject(ItemMaterialControllerActorData.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601D2E9 RID: 119529 RVA: 0x00820DB0 File Offset: 0x0081EFB0
	public ItemMaterialControllerActorData(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ItemMaterialControllerActorData.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601D2EA RID: 119530 RVA: 0x00820DE3 File Offset: 0x0081EFE3
	protected ItemMaterialControllerActorData(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0400E5B9 RID: 58809
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Render/Scene/Item/MaterialController/ItemMaterialControllerActorData.ItemMaterialControllerActorData_C";

	// Token: 0x0400E5BA RID: 58810
	private static IntPtr _ClassPtr;

	// Token: 0x0400E5BB RID: 58811
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400E5BC RID: 58812
	private static int __PropertyOffset_StartTime;

	// Token: 0x0400E5BD RID: 58813
	private static int __PropertyOffset_LoopTime;

	// Token: 0x0400E5BE RID: 58814
	private static int __PropertyOffset_EndTime;

	// Token: 0x0400E5BF RID: 58815
	private static int __PropertyOffset_EnableBaseColorScale;

	// Token: 0x0400E5C0 RID: 58816
	private static int __PropertyOffset_BaseColorScale;

	// Token: 0x0400E5C1 RID: 58817
	[Nullable(2)]
	private FKuroCurveFloat _BaseColorScale;

	// Token: 0x0400E5C2 RID: 58818
	private static int __PropertyOffset_EnableAddEmissionColor;

	// Token: 0x0400E5C3 RID: 58819
	private static int __PropertyOffset_AddEmissionColor;

	// Token: 0x0400E5C4 RID: 58820
	[Nullable(2)]
	private FKuroCurveLinearColor _AddEmissionColor;

	// Token: 0x0400E5C5 RID: 58821
	private static int __PropertyOffset_EnableEmissionChange;

	// Token: 0x0400E5C6 RID: 58822
	private static int __PropertyOffset_EmissionLightColorChangeProgress;

	// Token: 0x0400E5C7 RID: 58823
	[Nullable(2)]
	private FKuroCurveFloat _EmissionLightColorChangeProgress;

	// Token: 0x0400E5C8 RID: 58824
	private static int __PropertyOffset_EmissionLightColorChangeStrength;

	// Token: 0x0400E5C9 RID: 58825
	[Nullable(2)]
	private FKuroCurveFloat _EmissionLightColorChangeStrength;

	// Token: 0x0400E5CA RID: 58826
	private static int __PropertyOffset_EmissionLightColorChangeColor;

	// Token: 0x0400E5CB RID: 58827
	[Nullable(2)]
	private FKuroCurveLinearColor _EmissionLightColorChangeColor;

	// Token: 0x0400E5CC RID: 58828
	private static int __PropertyOffset_EnableRimLight;

	// Token: 0x0400E5CD RID: 58829
	private static int __PropertyOffset_RimLightColor;

	// Token: 0x0400E5CE RID: 58830
	[Nullable(2)]
	private FKuroCurveLinearColor _RimLightColor;

	// Token: 0x0400E5CF RID: 58831
	private static int __PropertyOffset_RimPower;

	// Token: 0x0400E5D0 RID: 58832
	[Nullable(2)]
	private FKuroCurveFloat _RimPower;

	// Token: 0x0400E5D1 RID: 58833
	private static int __PropertyOffset_EnableDissolve;

	// Token: 0x0400E5D2 RID: 58834
	private static int __PropertyOffset_DissolveProgress;

	// Token: 0x0400E5D3 RID: 58835
	[Nullable(2)]
	private FKuroCurveFloat _DissolveProgress;

	// Token: 0x0400E5D4 RID: 58836
	private static int __PropertyOffset_DissolveAdjustment;

	// Token: 0x0400E5D5 RID: 58837
	[Nullable(2)]
	private FKuroCurveFloat _DissolveAdjustment;

	// Token: 0x0400E5D6 RID: 58838
	private static int __PropertyOffset_DissolveEdageWidth;

	// Token: 0x0400E5D7 RID: 58839
	[Nullable(2)]
	private FKuroCurveFloat _DissolveEdageWidth;

	// Token: 0x0400E5D8 RID: 58840
	private static int __PropertyOffset_DissolveEdageColor;

	// Token: 0x0400E5D9 RID: 58841
	[Nullable(2)]
	private FKuroCurveLinearColor _DissolveEdageColor;

	// Token: 0x0400E5DA RID: 58842
	private static int __PropertyOffset_DissolveEdageStrength;

	// Token: 0x0400E5DB RID: 58843
	[Nullable(2)]
	private FKuroCurveFloat _DissolveEdageStrength;

	// Token: 0x0400E5DC RID: 58844
	private static int __PropertyOffset_DissolveTexSpeed;

	// Token: 0x0400E5DD RID: 58845
	[Nullable(2)]
	private FKuroCurveLinearColor _DissolveTexSpeed;

	// Token: 0x0400E5DE RID: 58846
	private static int __PropertyOffset_DissolveUv;

	// Token: 0x0400E5DF RID: 58847
	private static int __PropertyOffset_DissolveTexScaleOffset;

	// Token: 0x0400E5E0 RID: 58848
	[Nullable(2)]
	private FKuroCurveLinearColor _DissolveTexScaleOffset;

	// Token: 0x0400E5E1 RID: 58849
	private static int __PropertyOffset_EnableScanning;

	// Token: 0x0400E5E2 RID: 58850
	private static int __PropertyOffset_ScanningOutlineMixNoiseStrength;

	// Token: 0x0400E5E3 RID: 58851
	[Nullable(2)]
	private FKuroCurveFloat _ScanningOutlineMixNoiseStrength;

	// Token: 0x0400E5E4 RID: 58852
	private static int __PropertyOffset_ScanningOutlineStrength;

	// Token: 0x0400E5E5 RID: 58853
	[Nullable(2)]
	private FKuroCurveFloat _ScanningOutlineStrength;

	// Token: 0x0400E5E6 RID: 58854
	private static int __PropertyOffset_ScanningOutlineTexScaleOffset;

	// Token: 0x0400E5E7 RID: 58855
	[Nullable(2)]
	private FKuroCurveLinearColor _ScanningOutlineTexScaleOffset;

	// Token: 0x0400E5E8 RID: 58856
	private static int __PropertyOffset_ScanningOutlineColor;

	// Token: 0x0400E5E9 RID: 58857
	[Nullable(2)]
	private FKuroCurveLinearColor _ScanningOutlineColor;

	// Token: 0x0400E5EA RID: 58858
	private static int __PropertyOffset_VertexAnimTimeDebug;

	// Token: 0x0400E5EB RID: 58859
	[Nullable(2)]
	private FKuroCurveFloat _VertexAnimTimeDebug;

	// Token: 0x0400E5EC RID: 58860
	private static int __PropertyOffset_VertexAnimFrame;

	// Token: 0x0400E5ED RID: 58861
	[Nullable(2)]
	private FKuroCurveFloat _VertexAnimFrame;

	// Token: 0x0400E5EE RID: 58862
	private static int __PropertyOffset_PivotPainterTransform;

	// Token: 0x0400E5EF RID: 58863
	[Nullable(2)]
	private FKuroCurveLinearColor _PivotPainterTransform;

	// Token: 0x0400E5F0 RID: 58864
	private static int __PropertyOffset_FloatingThreshold;

	// Token: 0x0400E5F1 RID: 58865
	[Nullable(2)]
	private FKuroCurveFloat _FloatingThreshold;

	// Token: 0x0400E5F2 RID: 58866
	private static int __PropertyOffset_EnablePivotPainterWorldPositionOffset;

	// Token: 0x0400E5F3 RID: 58867
	private static int __PropertyOffset_EnableWorldPositionOffset;

	// Token: 0x0400E5F4 RID: 58868
	private static int __PropertyOffset_DisableFoliageEffect;

	// Token: 0x0400E5F5 RID: 58869
	private static int __PropertyOffset_EnableFoliageEffect;

	// Token: 0x0400E5F6 RID: 58870
	private static int __PropertyOffset_RimLightColorSpecil;

	// Token: 0x0400E5F7 RID: 58871
	[Nullable(2)]
	private FKuroCurveLinearColor _RimLightColorSpecil;

	// Token: 0x0400E5F8 RID: 58872
	private static int __PropertyOffset_UseRimlightColorSpecil;

	// Token: 0x0400E5F9 RID: 58873
	private static int __PropertyOffset_RimlightColorStrength;

	// Token: 0x0400E5FA RID: 58874
	[Nullable(2)]
	private FKuroCurveFloat _RimlightColorStrength;

	// Token: 0x0400E5FB RID: 58875
	private static int __PropertyOffset_UseEmissionTex;

	// Token: 0x0400E5FC RID: 58876
	private static int __PropertyOffset_EmissionTexStrength;

	// Token: 0x0400E5FD RID: 58877
	[Nullable(2)]
	private FKuroCurveFloat _EmissionTexStrength;

	// Token: 0x0400E5FE RID: 58878
	private static int __PropertyOffset_WorldPositionOffsetNormal;

	// Token: 0x0400E5FF RID: 58879
	[Nullable(2)]
	private FKuroCurveFloat _WorldPositionOffsetNormal;

	// Token: 0x0400E600 RID: 58880
	private static int __PropertyOffset_WorldPositionOffsetOffset;

	// Token: 0x0400E601 RID: 58881
	[Nullable(2)]
	private FKuroCurveLinearColor _WorldPositionOffsetOffset;

	// Token: 0x0400E602 RID: 58882
	private static int __PropertyOffset_SimpleUspeed;

	// Token: 0x0400E603 RID: 58883
	[Nullable(2)]
	private FKuroCurveFloat _SimpleUspeed;

	// Token: 0x0400E604 RID: 58884
	private static int __PropertyOffset_SimpleVspeed;

	// Token: 0x0400E605 RID: 58885
	[Nullable(2)]
	private FKuroCurveFloat _SimpleVspeed;

	// Token: 0x0400E606 RID: 58886
	private static int __PropertyOffset_SimpleUseFlow;

	// Token: 0x0400E607 RID: 58887
	[Nullable(2)]
	private FKuroCurveFloat _SimpleUseFlow;

	// Token: 0x0400E608 RID: 58888
	private static int __PropertyOffset_EnableQuanXiPinTu;

	// Token: 0x0400E609 RID: 58889
	private static int __PropertyOffset_TransparencyQuanXiPinTu;

	// Token: 0x0400E60A RID: 58890
	[Nullable(2)]
	private FKuroCurveFloat _TransparencyQuanXiPinTu;

	// Token: 0x0400E60B RID: 58891
	private static int __PropertyOffset_TransparentColorQuanXiPinTu;

	// Token: 0x0400E60C RID: 58892
	[Nullable(2)]
	private FKuroCurveLinearColor _TransparentColorQuanXiPinTu;

	// Token: 0x0400E60D RID: 58893
	private static int __PropertyOffset_OpaqueColorQuanXiPinTu;

	// Token: 0x0400E60E RID: 58894
	[Nullable(2)]
	private FKuroCurveLinearColor _OpaqueColorQuanXiPinTu;

	// Token: 0x0400E60F RID: 58895
	private static int __PropertyOffset_EnableQuanXiFengSuo;

	// Token: 0x0400E610 RID: 58896
	private static int __PropertyOffset_TransparencyQuanXiFengSuo;

	// Token: 0x0400E611 RID: 58897
	[Nullable(2)]
	private FKuroCurveFloat _TransparencyQuanXiFengSuo;

	// Token: 0x0400E612 RID: 58898
	private static int __PropertyOffset_TransparentColorQuanXiFengSuo;

	// Token: 0x0400E613 RID: 58899
	[Nullable(2)]
	private FKuroCurveLinearColor _TransparentColorQuanXiFengSuo;

	// Token: 0x0400E614 RID: 58900
	private static int __PropertyOffset_CustomScalarParMap;

	// Token: 0x0400E615 RID: 58901
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TMap<FName, FKuroCurveFloat> _CustomScalarParMap;

	// Token: 0x0400E616 RID: 58902
	private static int __PropertyOffset_CustomColorParMap;

	// Token: 0x0400E617 RID: 58903
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TMap<FName, FKuroCurveLinearColor> _CustomColorParMap;

	// Token: 0x0400E618 RID: 58904
	private static int __PropertyOffset_CustomTexParMap;

	// Token: 0x0400E619 RID: 58905
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TMap<FName, UTexture> _CustomTexParMap;

	// Token: 0x0400E61A RID: 58906
	private static int __PropertyOffset_RevertCustomTexParOnDestroy;
}

using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200348A RID: 13450
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/Render/Scene/Item/MaterialController/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Render/Scene/Item/MaterialController/ItemMaterialControllerGlobalData.ItemMaterialControllerGlobalData_C")]
public class ItemMaterialControllerGlobalData : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700285A RID: 10330
	// (get) Token: 0x0601D2EB RID: 119531 RVA: 0x00820DEC File Offset: 0x0081EFEC
	// (set) Token: 0x0601D2EC RID: 119532 RVA: 0x00820DFC File Offset: 0x0081EFFC
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float StartTime
	{
		get
		{
			return *(base.NativePtr + (IntPtr)ItemMaterialControllerGlobalData.__PropertyOffset_StartTime);
		}
		set
		{
			*(base.NativePtr + (IntPtr)ItemMaterialControllerGlobalData.__PropertyOffset_StartTime) = value;
		}
	}

	// Token: 0x1700285B RID: 10331
	// (get) Token: 0x0601D2ED RID: 119533 RVA: 0x00820E0D File Offset: 0x0081F00D
	// (set) Token: 0x0601D2EE RID: 119534 RVA: 0x00820E1D File Offset: 0x0081F01D
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float LoopTime
	{
		get
		{
			return *(base.NativePtr + (IntPtr)ItemMaterialControllerGlobalData.__PropertyOffset_LoopTime);
		}
		set
		{
			*(base.NativePtr + (IntPtr)ItemMaterialControllerGlobalData.__PropertyOffset_LoopTime) = value;
		}
	}

	// Token: 0x1700285C RID: 10332
	// (get) Token: 0x0601D2EF RID: 119535 RVA: 0x00820E2E File Offset: 0x0081F02E
	// (set) Token: 0x0601D2F0 RID: 119536 RVA: 0x00820E3E File Offset: 0x0081F03E
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float EndTime
	{
		get
		{
			return *(base.NativePtr + (IntPtr)ItemMaterialControllerGlobalData.__PropertyOffset_EndTime);
		}
		set
		{
			*(base.NativePtr + (IntPtr)ItemMaterialControllerGlobalData.__PropertyOffset_EndTime) = value;
		}
	}

	// Token: 0x1700285D RID: 10333
	// (get) Token: 0x0601D2F1 RID: 119537 RVA: 0x00820E4F File Offset: 0x0081F04F
	// (set) Token: 0x0601D2F2 RID: 119538 RVA: 0x00820E5F File Offset: 0x0081F05F
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool EnableBaseColorScale
	{
		get
		{
			return *(base.NativePtr + (IntPtr)ItemMaterialControllerGlobalData.__PropertyOffset_EnableBaseColorScale) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)ItemMaterialControllerGlobalData.__PropertyOffset_EnableBaseColorScale) = (value ? 1 : 0);
		}
	}

	// Token: 0x1700285E RID: 10334
	// (get) Token: 0x0601D2F3 RID: 119539 RVA: 0x00820E70 File Offset: 0x0081F070
	// (set) Token: 0x0601D2F4 RID: 119540 RVA: 0x00820EA9 File Offset: 0x0081F0A9
	[UProperty(EPropertyFlags.CPF_None)]
	public FKuroCurveFloat BaseColorScale
	{
		get
		{
			base.FastCheckIsValid();
			FKuroCurveFloat result;
			if ((result = this._BaseColorScale) == null)
			{
				result = (this._BaseColorScale = new FKuroCurveFloat(base.NativePtr + (IntPtr)ItemMaterialControllerGlobalData.__PropertyOffset_BaseColorScale, this));
			}
			return result;
		}
		set
		{
			UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)ItemMaterialControllerGlobalData.__PropertyOffset_BaseColorScale, (value != null) ? value.NativePtr : ((IntPtr)0), 1, false);
		}
	}

	// Token: 0x1700285F RID: 10335
	// (get) Token: 0x0601D2F5 RID: 119541 RVA: 0x00820ED1 File Offset: 0x0081F0D1
	// (set) Token: 0x0601D2F6 RID: 119542 RVA: 0x00820EE1 File Offset: 0x0081F0E1
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool EnableAddEmissionColor
	{
		get
		{
			return *(base.NativePtr + (IntPtr)ItemMaterialControllerGlobalData.__PropertyOffset_EnableAddEmissionColor) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)ItemMaterialControllerGlobalData.__PropertyOffset_EnableAddEmissionColor) = (value ? 1 : 0);
		}
	}

	// Token: 0x17002860 RID: 10336
	// (get) Token: 0x0601D2F7 RID: 119543 RVA: 0x00820EF4 File Offset: 0x0081F0F4
	// (set) Token: 0x0601D2F8 RID: 119544 RVA: 0x00820F2D File Offset: 0x0081F12D
	[UProperty(EPropertyFlags.CPF_None)]
	public FKuroCurveLinearColor AddEmissionColor
	{
		get
		{
			base.FastCheckIsValid();
			FKuroCurveLinearColor result;
			if ((result = this._AddEmissionColor) == null)
			{
				result = (this._AddEmissionColor = new FKuroCurveLinearColor(base.NativePtr + (IntPtr)ItemMaterialControllerGlobalData.__PropertyOffset_AddEmissionColor, this));
			}
			return result;
		}
		set
		{
			UnrealReflectionUtils.CopyNativeStruct(FKuroCurveLinearColor.StaticStruct(), base.NativePtr + (IntPtr)ItemMaterialControllerGlobalData.__PropertyOffset_AddEmissionColor, (value != null) ? value.NativePtr : ((IntPtr)0), 1, false);
		}
	}

	// Token: 0x17002861 RID: 10337
	// (get) Token: 0x0601D2F9 RID: 119545 RVA: 0x00820F55 File Offset: 0x0081F155
	// (set) Token: 0x0601D2FA RID: 119546 RVA: 0x00820F65 File Offset: 0x0081F165
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool EnableRimLight
	{
		get
		{
			return *(base.NativePtr + (IntPtr)ItemMaterialControllerGlobalData.__PropertyOffset_EnableRimLight) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)ItemMaterialControllerGlobalData.__PropertyOffset_EnableRimLight) = (value ? 1 : 0);
		}
	}

	// Token: 0x17002862 RID: 10338
	// (get) Token: 0x0601D2FB RID: 119547 RVA: 0x00820F78 File Offset: 0x0081F178
	// (set) Token: 0x0601D2FC RID: 119548 RVA: 0x00820FB1 File Offset: 0x0081F1B1
	[UProperty(EPropertyFlags.CPF_None)]
	public FKuroCurveLinearColor AddRimLightColor
	{
		get
		{
			base.FastCheckIsValid();
			FKuroCurveLinearColor result;
			if ((result = this._AddRimLightColor) == null)
			{
				result = (this._AddRimLightColor = new FKuroCurveLinearColor(base.NativePtr + (IntPtr)ItemMaterialControllerGlobalData.__PropertyOffset_AddRimLightColor, this));
			}
			return result;
		}
		set
		{
			UnrealReflectionUtils.CopyNativeStruct(FKuroCurveLinearColor.StaticStruct(), base.NativePtr + (IntPtr)ItemMaterialControllerGlobalData.__PropertyOffset_AddRimLightColor, (value != null) ? value.NativePtr : ((IntPtr)0), 1, false);
		}
	}

	// Token: 0x17002863 RID: 10339
	// (get) Token: 0x0601D2FD RID: 119549 RVA: 0x00820FDC File Offset: 0x0081F1DC
	// (set) Token: 0x0601D2FE RID: 119550 RVA: 0x00821015 File Offset: 0x0081F215
	[UProperty(EPropertyFlags.CPF_None)]
	public FKuroCurveFloat RimWidth
	{
		get
		{
			base.FastCheckIsValid();
			FKuroCurveFloat result;
			if ((result = this._RimWidth) == null)
			{
				result = (this._RimWidth = new FKuroCurveFloat(base.NativePtr + (IntPtr)ItemMaterialControllerGlobalData.__PropertyOffset_RimWidth, this));
			}
			return result;
		}
		set
		{
			UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)ItemMaterialControllerGlobalData.__PropertyOffset_RimWidth, (value != null) ? value.NativePtr : ((IntPtr)0), 1, false);
		}
	}

	// Token: 0x17002864 RID: 10340
	// (get) Token: 0x0601D2FF RID: 119551 RVA: 0x00821040 File Offset: 0x0081F240
	// (set) Token: 0x0601D300 RID: 119552 RVA: 0x00821079 File Offset: 0x0081F279
	[UProperty(EPropertyFlags.CPF_None)]
	public FKuroCurveFloat RimPower
	{
		get
		{
			base.FastCheckIsValid();
			FKuroCurveFloat result;
			if ((result = this._RimPower) == null)
			{
				result = (this._RimPower = new FKuroCurveFloat(base.NativePtr + (IntPtr)ItemMaterialControllerGlobalData.__PropertyOffset_RimPower, this));
			}
			return result;
		}
		set
		{
			UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)ItemMaterialControllerGlobalData.__PropertyOffset_RimPower, (value != null) ? value.NativePtr : ((IntPtr)0), 1, false);
		}
	}

	// Token: 0x17002865 RID: 10341
	// (get) Token: 0x0601D301 RID: 119553 RVA: 0x008210A4 File Offset: 0x0081F2A4
	// (set) Token: 0x0601D302 RID: 119554 RVA: 0x008210DD File Offset: 0x0081F2DD
	[UProperty(EPropertyFlags.CPF_None)]
	public FKuroCurveFloat RimMix
	{
		get
		{
			base.FastCheckIsValid();
			FKuroCurveFloat result;
			if ((result = this._RimMix) == null)
			{
				result = (this._RimMix = new FKuroCurveFloat(base.NativePtr + (IntPtr)ItemMaterialControllerGlobalData.__PropertyOffset_RimMix, this));
			}
			return result;
		}
		set
		{
			UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)ItemMaterialControllerGlobalData.__PropertyOffset_RimMix, (value != null) ? value.NativePtr : ((IntPtr)0), 1, false);
		}
	}

	// Token: 0x17002866 RID: 10342
	// (get) Token: 0x0601D303 RID: 119555 RVA: 0x00821105 File Offset: 0x0081F305
	// (set) Token: 0x0601D304 RID: 119556 RVA: 0x00821115 File Offset: 0x0081F315
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool EnableScanningOutline
	{
		get
		{
			return *(base.NativePtr + (IntPtr)ItemMaterialControllerGlobalData.__PropertyOffset_EnableScanningOutline) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)ItemMaterialControllerGlobalData.__PropertyOffset_EnableScanningOutline) = (value ? 1 : 0);
		}
	}

	// Token: 0x17002867 RID: 10343
	// (get) Token: 0x0601D305 RID: 119557 RVA: 0x00821128 File Offset: 0x0081F328
	// (set) Token: 0x0601D306 RID: 119558 RVA: 0x00821161 File Offset: 0x0081F361
	[UProperty(EPropertyFlags.CPF_None)]
	public FKuroCurveLinearColor ScanningOutlineColor
	{
		get
		{
			base.FastCheckIsValid();
			FKuroCurveLinearColor result;
			if ((result = this._ScanningOutlineColor) == null)
			{
				result = (this._ScanningOutlineColor = new FKuroCurveLinearColor(base.NativePtr + (IntPtr)ItemMaterialControllerGlobalData.__PropertyOffset_ScanningOutlineColor, this));
			}
			return result;
		}
		set
		{
			UnrealReflectionUtils.CopyNativeStruct(FKuroCurveLinearColor.StaticStruct(), base.NativePtr + (IntPtr)ItemMaterialControllerGlobalData.__PropertyOffset_ScanningOutlineColor, (value != null) ? value.NativePtr : ((IntPtr)0), 1, false);
		}
	}

	// Token: 0x17002868 RID: 10344
	// (get) Token: 0x0601D307 RID: 119559 RVA: 0x0082118C File Offset: 0x0081F38C
	// (set) Token: 0x0601D308 RID: 119560 RVA: 0x008211C5 File Offset: 0x0081F3C5
	[UProperty(EPropertyFlags.CPF_None)]
	public FKuroCurveFloat ScanningOutlineWidth
	{
		get
		{
			base.FastCheckIsValid();
			FKuroCurveFloat result;
			if ((result = this._ScanningOutlineWidth) == null)
			{
				result = (this._ScanningOutlineWidth = new FKuroCurveFloat(base.NativePtr + (IntPtr)ItemMaterialControllerGlobalData.__PropertyOffset_ScanningOutlineWidth, this));
			}
			return result;
		}
		set
		{
			UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)ItemMaterialControllerGlobalData.__PropertyOffset_ScanningOutlineWidth, (value != null) ? value.NativePtr : ((IntPtr)0), 1, false);
		}
	}

	// Token: 0x17002869 RID: 10345
	// (get) Token: 0x0601D309 RID: 119561 RVA: 0x008211F0 File Offset: 0x0081F3F0
	// (set) Token: 0x0601D30A RID: 119562 RVA: 0x00821229 File Offset: 0x0081F429
	[UProperty(EPropertyFlags.CPF_None)]
	public FKuroCurveLinearColor ScanningOutlineTexScaleOffset
	{
		get
		{
			base.FastCheckIsValid();
			FKuroCurveLinearColor result;
			if ((result = this._ScanningOutlineTexScaleOffset) == null)
			{
				result = (this._ScanningOutlineTexScaleOffset = new FKuroCurveLinearColor(base.NativePtr + (IntPtr)ItemMaterialControllerGlobalData.__PropertyOffset_ScanningOutlineTexScaleOffset, this));
			}
			return result;
		}
		set
		{
			UnrealReflectionUtils.CopyNativeStruct(FKuroCurveLinearColor.StaticStruct(), base.NativePtr + (IntPtr)ItemMaterialControllerGlobalData.__PropertyOffset_ScanningOutlineTexScaleOffset, (value != null) ? value.NativePtr : ((IntPtr)0), 1, false);
		}
	}

	// Token: 0x1700286A RID: 10346
	// (get) Token: 0x0601D30B RID: 119563 RVA: 0x00821254 File Offset: 0x0081F454
	// (set) Token: 0x0601D30C RID: 119564 RVA: 0x0082128D File Offset: 0x0081F48D
	[UProperty(EPropertyFlags.CPF_None)]
	public FKuroCurveLinearColor ScanningBrokenTexScaleOffset
	{
		get
		{
			base.FastCheckIsValid();
			FKuroCurveLinearColor result;
			if ((result = this._ScanningBrokenTexScaleOffset) == null)
			{
				result = (this._ScanningBrokenTexScaleOffset = new FKuroCurveLinearColor(base.NativePtr + (IntPtr)ItemMaterialControllerGlobalData.__PropertyOffset_ScanningBrokenTexScaleOffset, this));
			}
			return result;
		}
		set
		{
			UnrealReflectionUtils.CopyNativeStruct(FKuroCurveLinearColor.StaticStruct(), base.NativePtr + (IntPtr)ItemMaterialControllerGlobalData.__PropertyOffset_ScanningBrokenTexScaleOffset, (value != null) ? value.NativePtr : ((IntPtr)0), 1, false);
		}
	}

	// Token: 0x0601D30D RID: 119565 RVA: 0x008212B5 File Offset: 0x0081F4B5
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (ItemMaterialControllerGlobalData._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Render/Scene/Item/MaterialController/ItemMaterialControllerGlobalData.ItemMaterialControllerGlobalData_C");
		}
		return ItemMaterialControllerGlobalData._ClassPtr;
	}

	// Token: 0x0601D30E RID: 119566 RVA: 0x008212DC File Offset: 0x0081F4DC
	public ItemMaterialControllerGlobalData() : this(BuiltinUtils.AllocNativeUObject(ItemMaterialControllerGlobalData.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601D30F RID: 119567 RVA: 0x00821304 File Offset: 0x0081F504
	public ItemMaterialControllerGlobalData(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ItemMaterialControllerGlobalData.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601D310 RID: 119568 RVA: 0x00821337 File Offset: 0x0081F537
	protected ItemMaterialControllerGlobalData(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0400E61B RID: 58907
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Render/Scene/Item/MaterialController/ItemMaterialControllerGlobalData.ItemMaterialControllerGlobalData_C";

	// Token: 0x0400E61C RID: 58908
	private static IntPtr _ClassPtr;

	// Token: 0x0400E61D RID: 58909
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400E61E RID: 58910
	private static int __PropertyOffset_StartTime;

	// Token: 0x0400E61F RID: 58911
	private static int __PropertyOffset_LoopTime;

	// Token: 0x0400E620 RID: 58912
	private static int __PropertyOffset_EndTime;

	// Token: 0x0400E621 RID: 58913
	private static int __PropertyOffset_EnableBaseColorScale;

	// Token: 0x0400E622 RID: 58914
	private static int __PropertyOffset_BaseColorScale;

	// Token: 0x0400E623 RID: 58915
	[Nullable(2)]
	private FKuroCurveFloat _BaseColorScale;

	// Token: 0x0400E624 RID: 58916
	private static int __PropertyOffset_EnableAddEmissionColor;

	// Token: 0x0400E625 RID: 58917
	private static int __PropertyOffset_AddEmissionColor;

	// Token: 0x0400E626 RID: 58918
	[Nullable(2)]
	private FKuroCurveLinearColor _AddEmissionColor;

	// Token: 0x0400E627 RID: 58919
	private static int __PropertyOffset_EnableRimLight;

	// Token: 0x0400E628 RID: 58920
	private static int __PropertyOffset_AddRimLightColor;

	// Token: 0x0400E629 RID: 58921
	[Nullable(2)]
	private FKuroCurveLinearColor _AddRimLightColor;

	// Token: 0x0400E62A RID: 58922
	private static int __PropertyOffset_RimWidth;

	// Token: 0x0400E62B RID: 58923
	[Nullable(2)]
	private FKuroCurveFloat _RimWidth;

	// Token: 0x0400E62C RID: 58924
	private static int __PropertyOffset_RimPower;

	// Token: 0x0400E62D RID: 58925
	[Nullable(2)]
	private FKuroCurveFloat _RimPower;

	// Token: 0x0400E62E RID: 58926
	private static int __PropertyOffset_RimMix;

	// Token: 0x0400E62F RID: 58927
	[Nullable(2)]
	private FKuroCurveFloat _RimMix;

	// Token: 0x0400E630 RID: 58928
	private static int __PropertyOffset_EnableScanningOutline;

	// Token: 0x0400E631 RID: 58929
	private static int __PropertyOffset_ScanningOutlineColor;

	// Token: 0x0400E632 RID: 58930
	[Nullable(2)]
	private FKuroCurveLinearColor _ScanningOutlineColor;

	// Token: 0x0400E633 RID: 58931
	private static int __PropertyOffset_ScanningOutlineWidth;

	// Token: 0x0400E634 RID: 58932
	[Nullable(2)]
	private FKuroCurveFloat _ScanningOutlineWidth;

	// Token: 0x0400E635 RID: 58933
	private static int __PropertyOffset_ScanningOutlineTexScaleOffset;

	// Token: 0x0400E636 RID: 58934
	[Nullable(2)]
	private FKuroCurveLinearColor _ScanningOutlineTexScaleOffset;

	// Token: 0x0400E637 RID: 58935
	private static int __PropertyOffset_ScanningBrokenTexScaleOffset;

	// Token: 0x0400E638 RID: 58936
	[Nullable(2)]
	private FKuroCurveLinearColor _ScanningBrokenTexScaleOffset;
}

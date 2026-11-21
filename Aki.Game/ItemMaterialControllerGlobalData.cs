using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020029FE RID: 10750
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/Render/Scene/Item/MaterialController/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Render/Scene/Item/MaterialController/ItemMaterialControllerGlobalData.ItemMaterialControllerGlobalData_C")]
public class ItemMaterialControllerGlobalData : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
{
	// Token: 0x17002BF8 RID: 11256
	// (get) Token: 0x0601AFF2 RID: 110578 RVA: 0x008480F8 File Offset: 0x008462F8
	// (set) Token: 0x0601AFF3 RID: 110579 RVA: 0x00848108 File Offset: 0x00846308
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

	// Token: 0x17002BF9 RID: 11257
	// (get) Token: 0x0601AFF4 RID: 110580 RVA: 0x00848119 File Offset: 0x00846319
	// (set) Token: 0x0601AFF5 RID: 110581 RVA: 0x00848129 File Offset: 0x00846329
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

	// Token: 0x17002BFA RID: 11258
	// (get) Token: 0x0601AFF6 RID: 110582 RVA: 0x0084813A File Offset: 0x0084633A
	// (set) Token: 0x0601AFF7 RID: 110583 RVA: 0x0084814A File Offset: 0x0084634A
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

	// Token: 0x17002BFB RID: 11259
	// (get) Token: 0x0601AFF8 RID: 110584 RVA: 0x0084815B File Offset: 0x0084635B
	// (set) Token: 0x0601AFF9 RID: 110585 RVA: 0x0084816B File Offset: 0x0084636B
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

	// Token: 0x17002BFC RID: 11260
	// (get) Token: 0x0601AFFA RID: 110586 RVA: 0x0084817C File Offset: 0x0084637C
	// (set) Token: 0x0601AFFB RID: 110587 RVA: 0x008481B5 File Offset: 0x008463B5
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

	// Token: 0x17002BFD RID: 11261
	// (get) Token: 0x0601AFFC RID: 110588 RVA: 0x008481DD File Offset: 0x008463DD
	// (set) Token: 0x0601AFFD RID: 110589 RVA: 0x008481ED File Offset: 0x008463ED
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

	// Token: 0x17002BFE RID: 11262
	// (get) Token: 0x0601AFFE RID: 110590 RVA: 0x00848200 File Offset: 0x00846400
	// (set) Token: 0x0601AFFF RID: 110591 RVA: 0x00848239 File Offset: 0x00846439
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

	// Token: 0x17002BFF RID: 11263
	// (get) Token: 0x0601B000 RID: 110592 RVA: 0x00848261 File Offset: 0x00846461
	// (set) Token: 0x0601B001 RID: 110593 RVA: 0x00848271 File Offset: 0x00846471
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

	// Token: 0x17002C00 RID: 11264
	// (get) Token: 0x0601B002 RID: 110594 RVA: 0x00848284 File Offset: 0x00846484
	// (set) Token: 0x0601B003 RID: 110595 RVA: 0x008482BD File Offset: 0x008464BD
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

	// Token: 0x17002C01 RID: 11265
	// (get) Token: 0x0601B004 RID: 110596 RVA: 0x008482E8 File Offset: 0x008464E8
	// (set) Token: 0x0601B005 RID: 110597 RVA: 0x00848321 File Offset: 0x00846521
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

	// Token: 0x17002C02 RID: 11266
	// (get) Token: 0x0601B006 RID: 110598 RVA: 0x0084834C File Offset: 0x0084654C
	// (set) Token: 0x0601B007 RID: 110599 RVA: 0x00848385 File Offset: 0x00846585
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

	// Token: 0x17002C03 RID: 11267
	// (get) Token: 0x0601B008 RID: 110600 RVA: 0x008483B0 File Offset: 0x008465B0
	// (set) Token: 0x0601B009 RID: 110601 RVA: 0x008483E9 File Offset: 0x008465E9
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

	// Token: 0x17002C04 RID: 11268
	// (get) Token: 0x0601B00A RID: 110602 RVA: 0x00848411 File Offset: 0x00846611
	// (set) Token: 0x0601B00B RID: 110603 RVA: 0x00848421 File Offset: 0x00846621
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

	// Token: 0x17002C05 RID: 11269
	// (get) Token: 0x0601B00C RID: 110604 RVA: 0x00848434 File Offset: 0x00846634
	// (set) Token: 0x0601B00D RID: 110605 RVA: 0x0084846D File Offset: 0x0084666D
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

	// Token: 0x17002C06 RID: 11270
	// (get) Token: 0x0601B00E RID: 110606 RVA: 0x00848498 File Offset: 0x00846698
	// (set) Token: 0x0601B00F RID: 110607 RVA: 0x008484D1 File Offset: 0x008466D1
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

	// Token: 0x17002C07 RID: 11271
	// (get) Token: 0x0601B010 RID: 110608 RVA: 0x008484FC File Offset: 0x008466FC
	// (set) Token: 0x0601B011 RID: 110609 RVA: 0x00848535 File Offset: 0x00846735
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

	// Token: 0x17002C08 RID: 11272
	// (get) Token: 0x0601B012 RID: 110610 RVA: 0x00848560 File Offset: 0x00846760
	// (set) Token: 0x0601B013 RID: 110611 RVA: 0x00848599 File Offset: 0x00846799
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

	// Token: 0x0601B014 RID: 110612 RVA: 0x008485C1 File Offset: 0x008467C1
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (ItemMaterialControllerGlobalData._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Render/Scene/Item/MaterialController/ItemMaterialControllerGlobalData.ItemMaterialControllerGlobalData_C");
		}
		return ItemMaterialControllerGlobalData._ClassPtr;
	}

	// Token: 0x0601B015 RID: 110613 RVA: 0x008485E8 File Offset: 0x008467E8
	public ItemMaterialControllerGlobalData() : this(BuiltinUtils.AllocNativeUObject(ItemMaterialControllerGlobalData.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601B016 RID: 110614 RVA: 0x00848610 File Offset: 0x00846810
	public ItemMaterialControllerGlobalData(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ItemMaterialControllerGlobalData.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601B017 RID: 110615 RVA: 0x00848643 File Offset: 0x00846843
	protected ItemMaterialControllerGlobalData(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0400EAD2 RID: 60114
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Render/Scene/Item/MaterialController/ItemMaterialControllerGlobalData.ItemMaterialControllerGlobalData_C";

	// Token: 0x0400EAD3 RID: 60115
	private static IntPtr _ClassPtr;

	// Token: 0x0400EAD4 RID: 60116
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400EAD5 RID: 60117
	private static int __PropertyOffset_StartTime;

	// Token: 0x0400EAD6 RID: 60118
	private static int __PropertyOffset_LoopTime;

	// Token: 0x0400EAD7 RID: 60119
	private static int __PropertyOffset_EndTime;

	// Token: 0x0400EAD8 RID: 60120
	private static int __PropertyOffset_EnableBaseColorScale;

	// Token: 0x0400EAD9 RID: 60121
	private static int __PropertyOffset_BaseColorScale;

	// Token: 0x0400EADA RID: 60122
	[Nullable(2)]
	private FKuroCurveFloat _BaseColorScale;

	// Token: 0x0400EADB RID: 60123
	private static int __PropertyOffset_EnableAddEmissionColor;

	// Token: 0x0400EADC RID: 60124
	private static int __PropertyOffset_AddEmissionColor;

	// Token: 0x0400EADD RID: 60125
	[Nullable(2)]
	private FKuroCurveLinearColor _AddEmissionColor;

	// Token: 0x0400EADE RID: 60126
	private static int __PropertyOffset_EnableRimLight;

	// Token: 0x0400EADF RID: 60127
	private static int __PropertyOffset_AddRimLightColor;

	// Token: 0x0400EAE0 RID: 60128
	[Nullable(2)]
	private FKuroCurveLinearColor _AddRimLightColor;

	// Token: 0x0400EAE1 RID: 60129
	private static int __PropertyOffset_RimWidth;

	// Token: 0x0400EAE2 RID: 60130
	[Nullable(2)]
	private FKuroCurveFloat _RimWidth;

	// Token: 0x0400EAE3 RID: 60131
	private static int __PropertyOffset_RimPower;

	// Token: 0x0400EAE4 RID: 60132
	[Nullable(2)]
	private FKuroCurveFloat _RimPower;

	// Token: 0x0400EAE5 RID: 60133
	private static int __PropertyOffset_RimMix;

	// Token: 0x0400EAE6 RID: 60134
	[Nullable(2)]
	private FKuroCurveFloat _RimMix;

	// Token: 0x0400EAE7 RID: 60135
	private static int __PropertyOffset_EnableScanningOutline;

	// Token: 0x0400EAE8 RID: 60136
	private static int __PropertyOffset_ScanningOutlineColor;

	// Token: 0x0400EAE9 RID: 60137
	[Nullable(2)]
	private FKuroCurveLinearColor _ScanningOutlineColor;

	// Token: 0x0400EAEA RID: 60138
	private static int __PropertyOffset_ScanningOutlineWidth;

	// Token: 0x0400EAEB RID: 60139
	[Nullable(2)]
	private FKuroCurveFloat _ScanningOutlineWidth;

	// Token: 0x0400EAEC RID: 60140
	private static int __PropertyOffset_ScanningOutlineTexScaleOffset;

	// Token: 0x0400EAED RID: 60141
	[Nullable(2)]
	private FKuroCurveLinearColor _ScanningOutlineTexScaleOffset;

	// Token: 0x0400EAEE RID: 60142
	private static int __PropertyOffset_ScanningBrokenTexScaleOffset;

	// Token: 0x0400EAEF RID: 60143
	[Nullable(2)]
	private FKuroCurveLinearColor _ScanningBrokenTexScaleOffset;
}

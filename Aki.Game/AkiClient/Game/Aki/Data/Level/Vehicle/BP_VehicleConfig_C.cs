using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Fight.UI;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Level.Vehicle
{
	// Token: 0x02003EFC RID: 16124
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Level/Vehicle/BP_VehicleConfig.BP_VehicleConfig_C")]
	[UnrealStructLayout(752, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 752)]
	public class BP_VehicleConfig_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06028DD8 RID: 167384 RVA: 0x009B63F6 File Offset: 0x009B45F6
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_VehicleConfig_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/Level/Vehicle/BP_VehicleConfig.BP_VehicleConfig_C");
			}
			return BP_VehicleConfig_C._ClassPtr;
		}

		// Token: 0x06028DD9 RID: 167385 RVA: 0x009B641C File Offset: 0x009B461C
		public BP_VehicleConfig_C() : this(BuiltinUtils.AllocNativeUObject(BP_VehicleConfig_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06028DDA RID: 167386 RVA: 0x009B6444 File Offset: 0x009B4644
		public BP_VehicleConfig_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_VehicleConfig_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700600B RID: 24587
		// (get) Token: 0x06028DDB RID: 167387 RVA: 0x009B6478 File Offset: 0x009B4678
		// (set) Token: 0x06028DDC RID: 167388 RVA: 0x009B64B1 File Offset: 0x009B46B1
		public FGameplayTagContainer 载具出生Tag
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._载具出生Tag) == null)
				{
					result = (this._载具出生Tag = new FGameplayTagContainer(base.NativePtr + (IntPtr)BP_VehicleConfig_C.__PropertyOffset_0, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)BP_VehicleConfig_C.__PropertyOffset_0, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700600C RID: 24588
		// (get) Token: 0x06028DDD RID: 167389 RVA: 0x009B64D4 File Offset: 0x009B46D4
		// (set) Token: 0x06028DDE RID: 167390 RVA: 0x009B650D File Offset: 0x009B470D
		public FGameplayTagContainer 载具乘坐期间Tag
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._载具乘坐期间Tag) == null)
				{
					result = (this._载具乘坐期间Tag = new FGameplayTagContainer(base.NativePtr + (IntPtr)BP_VehicleConfig_C.__PropertyOffset_1, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)BP_VehicleConfig_C.__PropertyOffset_1, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700600D RID: 24589
		// (get) Token: 0x06028DDF RID: 167391 RVA: 0x009B6530 File Offset: 0x009B4730
		// (set) Token: 0x06028DE0 RID: 167392 RVA: 0x009B6569 File Offset: 0x009B4769
		public FGameplayTagContainer 角色乘坐期间Tag
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._角色乘坐期间Tag) == null)
				{
					result = (this._角色乘坐期间Tag = new FGameplayTagContainer(base.NativePtr + (IntPtr)BP_VehicleConfig_C.__PropertyOffset_2, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)BP_VehicleConfig_C.__PropertyOffset_2, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700600E RID: 24590
		// (get) Token: 0x06028DE1 RID: 167393 RVA: 0x009B658A File Offset: 0x009B478A
		// (set) Token: 0x06028DE2 RID: 167394 RVA: 0x009B659A File Offset: 0x009B479A
		public unsafe float 弹射时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VehicleConfig_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VehicleConfig_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x1700600F RID: 24591
		// (get) Token: 0x06028DE3 RID: 167395 RVA: 0x009B65AB File Offset: 0x009B47AB
		// (set) Token: 0x06028DE4 RID: 167396 RVA: 0x009B65BB File Offset: 0x009B47BB
		public unsafe float 弹射高度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VehicleConfig_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VehicleConfig_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17006010 RID: 24592
		// (get) Token: 0x06028DE5 RID: 167397 RVA: 0x009B65CC File Offset: 0x009B47CC
		// (set) Token: 0x06028DE6 RID: 167398 RVA: 0x009B65DC File Offset: 0x009B47DC
		public unsafe float 打开滑翔伞延迟时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VehicleConfig_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VehicleConfig_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17006011 RID: 24593
		// (get) Token: 0x06028DE7 RID: 167399 RVA: 0x009B65ED File Offset: 0x009B47ED
		// (set) Token: 0x06028DE8 RID: 167400 RVA: 0x009B6602 File Offset: 0x009B4802
		public TSoftObjectPtr<UCurveFloat> 弹射时间路径曲线
		{
			get
			{
				return new TSoftObjectPtr<UCurveFloat>(base.NativePtr + (IntPtr)BP_VehicleConfig_C.__PropertyOffset_6, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_VehicleConfig_C.__PropertyOffset_6, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17006012 RID: 24594
		// (get) Token: 0x06028DE9 RID: 167401 RVA: 0x009B6627 File Offset: 0x009B4827
		// (set) Token: 0x06028DEA RID: 167402 RVA: 0x009B663C File Offset: 0x009B483C
		public TSoftObjectPtr<UEffectModelGroup> PreEnterEffect
		{
			get
			{
				return new TSoftObjectPtr<UEffectModelGroup>(base.NativePtr + (IntPtr)BP_VehicleConfig_C.__PropertyOffset_7, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_VehicleConfig_C.__PropertyOffset_7, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17006013 RID: 24595
		// (get) Token: 0x06028DEB RID: 167403 RVA: 0x009B6661 File Offset: 0x009B4861
		// (set) Token: 0x06028DEC RID: 167404 RVA: 0x009B6676 File Offset: 0x009B4876
		public TSoftObjectPtr<UEffectModelGroup> PostEnterEffect
		{
			get
			{
				return new TSoftObjectPtr<UEffectModelGroup>(base.NativePtr + (IntPtr)BP_VehicleConfig_C.__PropertyOffset_8, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_VehicleConfig_C.__PropertyOffset_8, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17006014 RID: 24596
		// (get) Token: 0x06028DED RID: 167405 RVA: 0x009B669B File Offset: 0x009B489B
		// (set) Token: 0x06028DEE RID: 167406 RVA: 0x009B66B0 File Offset: 0x009B48B0
		public TSoftObjectPtr<PD_CharacterControllerData_C> PreEnterMatEffect
		{
			get
			{
				return new TSoftObjectPtr<PD_CharacterControllerData_C>(base.NativePtr + (IntPtr)BP_VehicleConfig_C.__PropertyOffset_9, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_VehicleConfig_C.__PropertyOffset_9, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17006015 RID: 24597
		// (get) Token: 0x06028DEF RID: 167407 RVA: 0x009B66D5 File Offset: 0x009B48D5
		// (set) Token: 0x06028DF0 RID: 167408 RVA: 0x009B66EA File Offset: 0x009B48EA
		public TSoftObjectPtr<PD_CharacterControllerDataGroup_C> PostEnterMatEffect
		{
			get
			{
				return new TSoftObjectPtr<PD_CharacterControllerDataGroup_C>(base.NativePtr + (IntPtr)BP_VehicleConfig_C.__PropertyOffset_10, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_VehicleConfig_C.__PropertyOffset_10, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17006016 RID: 24598
		// (get) Token: 0x06028DF1 RID: 167409 RVA: 0x009B6710 File Offset: 0x009B4910
		// (set) Token: 0x06028DF2 RID: 167410 RVA: 0x009B6749 File Offset: 0x009B4949
		public TMap<FGameplayTag, SGameplayTagArray> 驾驶员同步Tag
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FGameplayTag, SGameplayTagArray> result;
				if ((result = this._驾驶员同步Tag) == null)
				{
					result = (this._驾驶员同步Tag = new TMap<FGameplayTag, SGameplayTagArray>(base.NativePtr + (IntPtr)BP_VehicleConfig_C.__PropertyOffset_11, this));
				}
				return result;
			}
			set
			{
				this.驾驶员同步Tag.CopyAssign(value);
			}
		}

		// Token: 0x17006017 RID: 24599
		// (get) Token: 0x06028DF3 RID: 167411 RVA: 0x009B6758 File Offset: 0x009B4958
		// (set) Token: 0x06028DF4 RID: 167412 RVA: 0x009B6791 File Offset: 0x009B4991
		public TMap<FGameplayTag, SInt64Array> 驾驶员同步Buff
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FGameplayTag, SInt64Array> result;
				if ((result = this._驾驶员同步Buff) == null)
				{
					result = (this._驾驶员同步Buff = new TMap<FGameplayTag, SInt64Array>(base.NativePtr + (IntPtr)BP_VehicleConfig_C.__PropertyOffset_12, this));
				}
				return result;
			}
			set
			{
				this.驾驶员同步Buff.CopyAssign(value);
			}
		}

		// Token: 0x17006018 RID: 24600
		// (get) Token: 0x06028DF5 RID: 167413 RVA: 0x009B679F File Offset: 0x009B499F
		// (set) Token: 0x06028DF6 RID: 167414 RVA: 0x009B67B3 File Offset: 0x009B49B3
		[Nullable(2)]
		public unsafe UCurveFloat 前后输入映射曲线
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleConfig_C.__PropertyOffset_13);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleConfig_C.__PropertyOffset_13, value);
			}
		}

		// Token: 0x17006019 RID: 24601
		// (get) Token: 0x06028DF7 RID: 167415 RVA: 0x009B67C8 File Offset: 0x009B49C8
		// (set) Token: 0x06028DF8 RID: 167416 RVA: 0x009B6801 File Offset: 0x009B4A01
		public TMap<FGameplayTag, SGameplayTagArray> 载具同步驾驶员Tag
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FGameplayTag, SGameplayTagArray> result;
				if ((result = this._载具同步驾驶员Tag) == null)
				{
					result = (this._载具同步驾驶员Tag = new TMap<FGameplayTag, SGameplayTagArray>(base.NativePtr + (IntPtr)BP_VehicleConfig_C.__PropertyOffset_14, this));
				}
				return result;
			}
			set
			{
				this.载具同步驾驶员Tag.CopyAssign(value);
			}
		}

		// Token: 0x1700601A RID: 24602
		// (get) Token: 0x06028DF9 RID: 167417 RVA: 0x009B6810 File Offset: 0x009B4A10
		// (set) Token: 0x06028DFA RID: 167418 RVA: 0x009B6849 File Offset: 0x009B4A49
		public TArray<SFloatThresholdAndCameraShake> 撞击震屏
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SFloatThresholdAndCameraShake> result;
				if ((result = this._撞击震屏) == null)
				{
					result = (this._撞击震屏 = new TArray<SFloatThresholdAndCameraShake>(base.NativePtr + (IntPtr)BP_VehicleConfig_C.__PropertyOffset_15, this));
				}
				return result;
			}
			set
			{
				this.撞击震屏.CopyAssign(value);
			}
		}

		// Token: 0x1700601B RID: 24603
		// (get) Token: 0x06028DFB RID: 167419 RVA: 0x009B6858 File Offset: 0x009B4A58
		// (set) Token: 0x06028DFC RID: 167420 RVA: 0x009B6891 File Offset: 0x009B4A91
		public TArray<SFloatThresholdAndCameraShake> 撞击震屏Z
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SFloatThresholdAndCameraShake> result;
				if ((result = this._撞击震屏Z) == null)
				{
					result = (this._撞击震屏Z = new TArray<SFloatThresholdAndCameraShake>(base.NativePtr + (IntPtr)BP_VehicleConfig_C.__PropertyOffset_16, this));
				}
				return result;
			}
			set
			{
				this.撞击震屏Z.CopyAssign(value);
			}
		}

		// Token: 0x1700601C RID: 24604
		// (get) Token: 0x06028DFD RID: 167421 RVA: 0x009B689F File Offset: 0x009B4A9F
		// (set) Token: 0x06028DFE RID: 167422 RVA: 0x009B68AF File Offset: 0x009B4AAF
		public unsafe float 震屏CD
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VehicleConfig_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VehicleConfig_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x1700601D RID: 24605
		// (get) Token: 0x06028DFF RID: 167423 RVA: 0x009B68C0 File Offset: 0x009B4AC0
		// (set) Token: 0x06028E00 RID: 167424 RVA: 0x009B68F9 File Offset: 0x009B4AF9
		public TArray<SFloatThresholdAndCameraShake> 撞击震屏_第一人称
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SFloatThresholdAndCameraShake> result;
				if ((result = this._撞击震屏_第一人称) == null)
				{
					result = (this._撞击震屏_第一人称 = new TArray<SFloatThresholdAndCameraShake>(base.NativePtr + (IntPtr)BP_VehicleConfig_C.__PropertyOffset_18, this));
				}
				return result;
			}
			set
			{
				this.撞击震屏_第一人称.CopyAssign(value);
			}
		}

		// Token: 0x1700601E RID: 24606
		// (get) Token: 0x06028E01 RID: 167425 RVA: 0x009B6908 File Offset: 0x009B4B08
		// (set) Token: 0x06028E02 RID: 167426 RVA: 0x009B6941 File Offset: 0x009B4B41
		public TArray<SFloatThresholdAndCameraShake> 撞击震屏Z_第一人称
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SFloatThresholdAndCameraShake> result;
				if ((result = this._撞击震屏Z_第一人称) == null)
				{
					result = (this._撞击震屏Z_第一人称 = new TArray<SFloatThresholdAndCameraShake>(base.NativePtr + (IntPtr)BP_VehicleConfig_C.__PropertyOffset_19, this));
				}
				return result;
			}
			set
			{
				this.撞击震屏Z_第一人称.CopyAssign(value);
			}
		}

		// Token: 0x06028E03 RID: 167427 RVA: 0x009B694F File Offset: 0x009B4B4F
		protected BP_VehicleConfig_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014E58 RID: 85592
		public new const string __ObjectPath = "/Game/Aki/Data/Level/Vehicle/BP_VehicleConfig.BP_VehicleConfig_C";

		// Token: 0x04014E59 RID: 85593
		private static IntPtr _ClassPtr;

		// Token: 0x04014E5A RID: 85594
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04014E5B RID: 85595
		internal static int __PropertyOffset_0;

		// Token: 0x04014E5C RID: 85596
		[Nullable(2)]
		private FGameplayTagContainer _载具出生Tag;

		// Token: 0x04014E5D RID: 85597
		internal static int __PropertyOffset_1;

		// Token: 0x04014E5E RID: 85598
		[Nullable(2)]
		private FGameplayTagContainer _载具乘坐期间Tag;

		// Token: 0x04014E5F RID: 85599
		internal static int __PropertyOffset_2;

		// Token: 0x04014E60 RID: 85600
		[Nullable(2)]
		private FGameplayTagContainer _角色乘坐期间Tag;

		// Token: 0x04014E61 RID: 85601
		internal static int __PropertyOffset_3;

		// Token: 0x04014E62 RID: 85602
		internal static int __PropertyOffset_4;

		// Token: 0x04014E63 RID: 85603
		internal static int __PropertyOffset_5;

		// Token: 0x04014E64 RID: 85604
		internal static int __PropertyOffset_6;

		// Token: 0x04014E65 RID: 85605
		internal static int __PropertyOffset_7;

		// Token: 0x04014E66 RID: 85606
		internal static int __PropertyOffset_8;

		// Token: 0x04014E67 RID: 85607
		internal static int __PropertyOffset_9;

		// Token: 0x04014E68 RID: 85608
		internal static int __PropertyOffset_10;

		// Token: 0x04014E69 RID: 85609
		internal static int __PropertyOffset_11;

		// Token: 0x04014E6A RID: 85610
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FGameplayTag, SGameplayTagArray> _驾驶员同步Tag;

		// Token: 0x04014E6B RID: 85611
		internal static int __PropertyOffset_12;

		// Token: 0x04014E6C RID: 85612
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FGameplayTag, SInt64Array> _驾驶员同步Buff;

		// Token: 0x04014E6D RID: 85613
		internal static int __PropertyOffset_13;

		// Token: 0x04014E6E RID: 85614
		internal static int __PropertyOffset_14;

		// Token: 0x04014E6F RID: 85615
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FGameplayTag, SGameplayTagArray> _载具同步驾驶员Tag;

		// Token: 0x04014E70 RID: 85616
		internal static int __PropertyOffset_15;

		// Token: 0x04014E71 RID: 85617
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SFloatThresholdAndCameraShake> _撞击震屏;

		// Token: 0x04014E72 RID: 85618
		internal static int __PropertyOffset_16;

		// Token: 0x04014E73 RID: 85619
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SFloatThresholdAndCameraShake> _撞击震屏Z;

		// Token: 0x04014E74 RID: 85620
		internal static int __PropertyOffset_17;

		// Token: 0x04014E75 RID: 85621
		internal static int __PropertyOffset_18;

		// Token: 0x04014E76 RID: 85622
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SFloatThresholdAndCameraShake> _撞击震屏_第一人称;

		// Token: 0x04014E77 RID: 85623
		internal static int __PropertyOffset_19;

		// Token: 0x04014E78 RID: 85624
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SFloatThresholdAndCameraShake> _撞击震屏Z_第一人称;
	}
}

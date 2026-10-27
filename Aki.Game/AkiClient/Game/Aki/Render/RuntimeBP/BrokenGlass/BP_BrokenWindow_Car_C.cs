using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Core.Fight;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.BrokenGlass
{
	// Token: 0x02003E37 RID: 15927
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/BrokenGlass/BP_BrokenWindow_Car.BP_BrokenWindow_Car_C")]
	[UnrealStructLayout(1816, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1816)]
	public class BP_BrokenWindow_Car_C : AKuroBPActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06028009 RID: 163849 RVA: 0x009A1A20 File Offset: 0x0099FC20
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_BrokenWindow_Car_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/BrokenGlass/BP_BrokenWindow_Car.BP_BrokenWindow_Car_C");
			}
			return BP_BrokenWindow_Car_C._ClassPtr;
		}

		// Token: 0x0602800A RID: 163850 RVA: 0x009A1A44 File Offset: 0x0099FC44
		public BP_BrokenWindow_Car_C() : this(BuiltinUtils.AllocNativeUObject(BP_BrokenWindow_Car_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602800B RID: 163851 RVA: 0x009A1A6C File Offset: 0x0099FC6C
		[NullableContext(1)]
		public BP_BrokenWindow_Car_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_BrokenWindow_Car_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005B3D RID: 23357
		// (get) Token: 0x0602800C RID: 163852 RVA: 0x009A1A9F File Offset: 0x0099FC9F
		// (set) Token: 0x0602800D RID: 163853 RVA: 0x009A1AB3 File Offset: 0x0099FCB3
		public unsafe UStaticMeshComponent WindowBack1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BrokenWindow_Car_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BrokenWindow_Car_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17005B3E RID: 23358
		// (get) Token: 0x0602800E RID: 163854 RVA: 0x009A1AC8 File Offset: 0x0099FCC8
		// (set) Token: 0x0602800F RID: 163855 RVA: 0x009A1ADC File Offset: 0x0099FCDC
		public unsafe UStaticMeshComponent WindowBack2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BrokenWindow_Car_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BrokenWindow_Car_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17005B3F RID: 23359
		// (get) Token: 0x06028010 RID: 163856 RVA: 0x009A1AF1 File Offset: 0x0099FCF1
		// (set) Token: 0x06028011 RID: 163857 RVA: 0x009A1B05 File Offset: 0x0099FD05
		public unsafe UStaticMeshComponent WindowRight
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BrokenWindow_Car_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BrokenWindow_Car_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17005B40 RID: 23360
		// (get) Token: 0x06028012 RID: 163858 RVA: 0x009A1B1A File Offset: 0x0099FD1A
		// (set) Token: 0x06028013 RID: 163859 RVA: 0x009A1B2E File Offset: 0x0099FD2E
		public unsafe UStaticMeshComponent WindowLeft
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BrokenWindow_Car_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BrokenWindow_Car_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17005B41 RID: 23361
		// (get) Token: 0x06028014 RID: 163860 RVA: 0x009A1B43 File Offset: 0x0099FD43
		// (set) Token: 0x06028015 RID: 163861 RVA: 0x009A1B57 File Offset: 0x0099FD57
		public unsafe UBoxComponent BackWindowColli2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BrokenWindow_Car_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BrokenWindow_Car_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17005B42 RID: 23362
		// (get) Token: 0x06028016 RID: 163862 RVA: 0x009A1B6C File Offset: 0x0099FD6C
		// (set) Token: 0x06028017 RID: 163863 RVA: 0x009A1B80 File Offset: 0x0099FD80
		public unsafe UBoxComponent BackWindowColli1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BrokenWindow_Car_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BrokenWindow_Car_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x17005B43 RID: 23363
		// (get) Token: 0x06028018 RID: 163864 RVA: 0x009A1B95 File Offset: 0x0099FD95
		// (set) Token: 0x06028019 RID: 163865 RVA: 0x009A1BA9 File Offset: 0x0099FDA9
		public unsafe UBoxComponent FrontWindowColli2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BrokenWindow_Car_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BrokenWindow_Car_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x17005B44 RID: 23364
		// (get) Token: 0x0602801A RID: 163866 RVA: 0x009A1BBE File Offset: 0x0099FDBE
		// (set) Token: 0x0602801B RID: 163867 RVA: 0x009A1BD2 File Offset: 0x0099FDD2
		public unsafe UBoxComponent FrontWindowColli1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BrokenWindow_Car_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BrokenWindow_Car_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x17005B45 RID: 23365
		// (get) Token: 0x0602801C RID: 163868 RVA: 0x009A1BE7 File Offset: 0x0099FDE7
		// (set) Token: 0x0602801D RID: 163869 RVA: 0x009A1BFB File Offset: 0x0099FDFB
		public unsafe UBoxComponent RightWindowColli
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BrokenWindow_Car_C.__PropertyOffset_9);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BrokenWindow_Car_C.__PropertyOffset_9, value);
			}
		}

		// Token: 0x17005B46 RID: 23366
		// (get) Token: 0x0602801E RID: 163870 RVA: 0x009A1C10 File Offset: 0x0099FE10
		// (set) Token: 0x0602801F RID: 163871 RVA: 0x009A1C24 File Offset: 0x0099FE24
		public unsafe UBoxComponent LeftWindowColli
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BrokenWindow_Car_C.__PropertyOffset_10);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BrokenWindow_Car_C.__PropertyOffset_10, value);
			}
		}

		// Token: 0x17005B47 RID: 23367
		// (get) Token: 0x06028020 RID: 163872 RVA: 0x009A1C39 File Offset: 0x0099FE39
		// (set) Token: 0x06028021 RID: 163873 RVA: 0x009A1C4D File Offset: 0x0099FE4D
		public unsafe UStaticMeshComponent SM_Com3_Car_05AL
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BrokenWindow_Car_C.__PropertyOffset_11);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BrokenWindow_Car_C.__PropertyOffset_11, value);
			}
		}

		// Token: 0x17005B48 RID: 23368
		// (get) Token: 0x06028022 RID: 163874 RVA: 0x009A1C62 File Offset: 0x0099FE62
		// (set) Token: 0x06028023 RID: 163875 RVA: 0x009A1C76 File Offset: 0x0099FE76
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BrokenWindow_Car_C.__PropertyOffset_12);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BrokenWindow_Car_C.__PropertyOffset_12, value);
			}
		}

		// Token: 0x17005B49 RID: 23369
		// (get) Token: 0x06028024 RID: 163876 RVA: 0x009A1C8B File Offset: 0x0099FE8B
		// (set) Token: 0x06028025 RID: 163877 RVA: 0x009A1C9F File Offset: 0x0099FE9F
		public unsafe FVector Size
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BrokenWindow_Car_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BrokenWindow_Car_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17005B4A RID: 23370
		// (get) Token: 0x06028026 RID: 163878 RVA: 0x009A1CB4 File Offset: 0x0099FEB4
		// (set) Token: 0x06028027 RID: 163879 RVA: 0x009A1CED File Offset: 0x0099FEED
		[Nullable(1)]
		public TArray<FVector> UVList
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._UVList) == null)
				{
					result = (this._UVList = new TArray<FVector>(base.NativePtr + (IntPtr)BP_BrokenWindow_Car_C.__PropertyOffset_14, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.UVList.CopyAssign(value);
			}
		}

		// Token: 0x17005B4B RID: 23371
		// (get) Token: 0x06028028 RID: 163880 RVA: 0x009A1CFB File Offset: 0x0099FEFB
		// (set) Token: 0x06028029 RID: 163881 RVA: 0x009A1D0B File Offset: 0x0099FF0B
		public unsafe int UVIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BrokenWindow_Car_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BrokenWindow_Car_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17005B4C RID: 23372
		// (get) Token: 0x0602802A RID: 163882 RVA: 0x009A1D1C File Offset: 0x0099FF1C
		// (set) Token: 0x0602802B RID: 163883 RVA: 0x009A1D2C File Offset: 0x0099FF2C
		public unsafe float HitTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BrokenWindow_Car_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BrokenWindow_Car_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x17005B4D RID: 23373
		// (get) Token: 0x0602802C RID: 163884 RVA: 0x009A1D3D File Offset: 0x0099FF3D
		// (set) Token: 0x0602802D RID: 163885 RVA: 0x009A1D4D File Offset: 0x0099FF4D
		public unsafe float TraceTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BrokenWindow_Car_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BrokenWindow_Car_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x17005B4E RID: 23374
		// (get) Token: 0x0602802E RID: 163886 RVA: 0x009A1D5E File Offset: 0x0099FF5E
		// (set) Token: 0x0602802F RID: 163887 RVA: 0x009A1D72 File Offset: 0x0099FF72
		public unsafe FVector LastWeaponPoint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BrokenWindow_Car_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BrokenWindow_Car_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x17005B4F RID: 23375
		// (get) Token: 0x06028030 RID: 163888 RVA: 0x009A1D87 File Offset: 0x0099FF87
		// (set) Token: 0x06028031 RID: 163889 RVA: 0x009A1D97 File Offset: 0x0099FF97
		public unsafe float CrackPointState
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BrokenWindow_Car_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BrokenWindow_Car_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x17005B50 RID: 23376
		// (get) Token: 0x06028032 RID: 163890 RVA: 0x009A1DA8 File Offset: 0x0099FFA8
		// (set) Token: 0x06028033 RID: 163891 RVA: 0x009A1DE1 File Offset: 0x0099FFE1
		[Nullable(1)]
		public TArray<int> BitMask
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._BitMask) == null)
				{
					result = (this._BitMask = new TArray<int>(base.NativePtr + (IntPtr)BP_BrokenWindow_Car_C.__PropertyOffset_20, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.BitMask.CopyAssign(value);
			}
		}

		// Token: 0x17005B51 RID: 23377
		// (get) Token: 0x06028034 RID: 163892 RVA: 0x009A1DEF File Offset: 0x0099FFEF
		// (set) Token: 0x06028035 RID: 163893 RVA: 0x009A1DFF File Offset: 0x0099FFFF
		public unsafe int FinalStateMask
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BrokenWindow_Car_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BrokenWindow_Car_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x17005B52 RID: 23378
		// (get) Token: 0x06028036 RID: 163894 RVA: 0x009A1E10 File Offset: 0x009A0010
		// (set) Token: 0x06028037 RID: 163895 RVA: 0x009A1E20 File Offset: 0x009A0020
		public unsafe float InteractRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BrokenWindow_Car_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BrokenWindow_Car_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x17005B53 RID: 23379
		// (get) Token: 0x06028038 RID: 163896 RVA: 0x009A1E31 File Offset: 0x009A0031
		// (set) Token: 0x06028039 RID: 163897 RVA: 0x009A1E41 File Offset: 0x009A0041
		public unsafe bool Debug
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BrokenWindow_Car_C.__PropertyOffset_23) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BrokenWindow_Car_C.__PropertyOffset_23) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005B54 RID: 23380
		// (get) Token: 0x0602803A RID: 163898 RVA: 0x009A1E52 File Offset: 0x009A0052
		// (set) Token: 0x0602803B RID: 163899 RVA: 0x009A1E62 File Offset: 0x009A0062
		public unsafe bool LastPointUseAble
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BrokenWindow_Car_C.__PropertyOffset_24) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BrokenWindow_Car_C.__PropertyOffset_24) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005B55 RID: 23381
		// (get) Token: 0x0602803C RID: 163900 RVA: 0x009A1E73 File Offset: 0x009A0073
		// (set) Token: 0x0602803D RID: 163901 RVA: 0x009A1E83 File Offset: 0x009A0083
		public unsafe bool Option_2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BrokenWindow_Car_C.__PropertyOffset_25) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BrokenWindow_Car_C.__PropertyOffset_25) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005B56 RID: 23382
		// (get) Token: 0x0602803E RID: 163902 RVA: 0x009A1E94 File Offset: 0x009A0094
		// (set) Token: 0x0602803F RID: 163903 RVA: 0x009A1EA4 File Offset: 0x009A00A4
		public unsafe bool LeftBroken
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BrokenWindow_Car_C.__PropertyOffset_26) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BrokenWindow_Car_C.__PropertyOffset_26) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005B57 RID: 23383
		// (get) Token: 0x06028040 RID: 163904 RVA: 0x009A1EB5 File Offset: 0x009A00B5
		// (set) Token: 0x06028041 RID: 163905 RVA: 0x009A1EC5 File Offset: 0x009A00C5
		public unsafe bool RightBroken
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BrokenWindow_Car_C.__PropertyOffset_27) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BrokenWindow_Car_C.__PropertyOffset_27) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005B58 RID: 23384
		// (get) Token: 0x06028042 RID: 163906 RVA: 0x009A1ED8 File Offset: 0x009A00D8
		// (set) Token: 0x06028043 RID: 163907 RVA: 0x009A1F11 File Offset: 0x009A0111
		[Nullable(1)]
		public TMap<FName, int> TagDict
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FName, int> result;
				if ((result = this._TagDict) == null)
				{
					result = (this._TagDict = new TMap<FName, int>(base.NativePtr + (IntPtr)BP_BrokenWindow_Car_C.__PropertyOffset_28, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.TagDict.CopyAssign(value);
			}
		}

		// Token: 0x17005B59 RID: 23385
		// (get) Token: 0x06028044 RID: 163908 RVA: 0x009A1F20 File Offset: 0x009A0120
		// (set) Token: 0x06028045 RID: 163909 RVA: 0x009A1F59 File Offset: 0x009A0159
		[Nullable(1)]
		public TMap<FName, int> TagIndex
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FName, int> result;
				if ((result = this._TagIndex) == null)
				{
					result = (this._TagIndex = new TMap<FName, int>(base.NativePtr + (IntPtr)BP_BrokenWindow_Car_C.__PropertyOffset_29, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.TagIndex.CopyAssign(value);
			}
		}

		// Token: 0x17005B5A RID: 23386
		// (get) Token: 0x06028046 RID: 163910 RVA: 0x009A1F68 File Offset: 0x009A0168
		// (set) Token: 0x06028047 RID: 163911 RVA: 0x009A1FA1 File Offset: 0x009A01A1
		[Nullable(1)]
		public TArray<float> CustomTime
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._CustomTime) == null)
				{
					result = (this._CustomTime = new TArray<float>(base.NativePtr + (IntPtr)BP_BrokenWindow_Car_C.__PropertyOffset_30, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.CustomTime.CopyAssign(value);
			}
		}

		// Token: 0x06028048 RID: 163912 RVA: 0x009A1FAF File Offset: 0x009A01AF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Reset()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BrokenWindow_Car_C.__Reset_NativeFunctionPtr, null);
		}

		// Token: 0x06028049 RID: 163913 RVA: 0x009A1FC3 File Offset: 0x009A01C3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BrokenWindow_Car_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0602804A RID: 163914 RVA: 0x009A1FD7 File Offset: 0x009A01D7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_BrokenWindow_Car_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602804B RID: 163915 RVA: 0x009A1FEC File Offset: 0x009A01EC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_BrokenWindow_Car_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_BrokenWindow_Car_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_BrokenWindow_Car_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BrokenWindow_Car_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BrokenWindow_Car_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602804C RID: 163916 RVA: 0x009A2034 File Offset: 0x009A0234
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_BrokenWindow_Car_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_BrokenWindow_Car_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_BrokenWindow_Car_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BrokenWindow_Car_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_BrokenWindow_Car_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602804D RID: 163917 RVA: 0x009A207C File Offset: 0x009A027C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OnWeaponInteraction(FVectorDouble OriginPoint, BP_SceneBattleInteract_C Config, int Id)
		{
			BP_BrokenWindow_Car_C.__OnWeaponInteraction_FunctionParams* ptr = stackalloc BP_BrokenWindow_Car_C.__OnWeaponInteraction_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(BP_BrokenWindow_Car_C.__OnWeaponInteraction_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BrokenWindow_Car_C.__OnWeaponInteraction_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OriginPoint = OriginPoint;
			ptr->Config = ((Config != null) ? Config.NativePtr : IntPtr.Zero);
			ptr->Id = Id;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BrokenWindow_Car_C.__OnWeaponInteraction_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602804E RID: 163918 RVA: 0x009A20DF File Offset: 0x009A02DF
		protected BP_BrokenWindow_Car_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040144F1 RID: 83185
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/BrokenGlass/BP_BrokenWindow_Car.BP_BrokenWindow_Car_C";

		// Token: 0x040144F2 RID: 83186
		private static IntPtr _ClassPtr;

		// Token: 0x040144F3 RID: 83187
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040144F4 RID: 83188
		internal static int __PropertyOffset_1;

		// Token: 0x040144F5 RID: 83189
		internal static int __PropertyOffset_2;

		// Token: 0x040144F6 RID: 83190
		internal static int __PropertyOffset_3;

		// Token: 0x040144F7 RID: 83191
		internal static int __PropertyOffset_4;

		// Token: 0x040144F8 RID: 83192
		internal static int __PropertyOffset_5;

		// Token: 0x040144F9 RID: 83193
		internal static int __PropertyOffset_6;

		// Token: 0x040144FA RID: 83194
		internal static int __PropertyOffset_7;

		// Token: 0x040144FB RID: 83195
		internal static int __PropertyOffset_8;

		// Token: 0x040144FC RID: 83196
		internal static int __PropertyOffset_9;

		// Token: 0x040144FD RID: 83197
		internal static int __PropertyOffset_10;

		// Token: 0x040144FE RID: 83198
		internal static int __PropertyOffset_11;

		// Token: 0x040144FF RID: 83199
		internal static int __PropertyOffset_12;

		// Token: 0x04014500 RID: 83200
		internal static int __PropertyOffset_13;

		// Token: 0x04014501 RID: 83201
		internal static int __PropertyOffset_14;

		// Token: 0x04014502 RID: 83202
		private TArray<FVector> _UVList;

		// Token: 0x04014503 RID: 83203
		internal static int __PropertyOffset_15;

		// Token: 0x04014504 RID: 83204
		internal static int __PropertyOffset_16;

		// Token: 0x04014505 RID: 83205
		internal static int __PropertyOffset_17;

		// Token: 0x04014506 RID: 83206
		internal static int __PropertyOffset_18;

		// Token: 0x04014507 RID: 83207
		internal static int __PropertyOffset_19;

		// Token: 0x04014508 RID: 83208
		internal static int __PropertyOffset_20;

		// Token: 0x04014509 RID: 83209
		private TArray<int> _BitMask;

		// Token: 0x0401450A RID: 83210
		internal static int __PropertyOffset_21;

		// Token: 0x0401450B RID: 83211
		internal static int __PropertyOffset_22;

		// Token: 0x0401450C RID: 83212
		internal static int __PropertyOffset_23;

		// Token: 0x0401450D RID: 83213
		internal static int __PropertyOffset_24;

		// Token: 0x0401450E RID: 83214
		internal static int __PropertyOffset_25;

		// Token: 0x0401450F RID: 83215
		internal static int __PropertyOffset_26;

		// Token: 0x04014510 RID: 83216
		internal static int __PropertyOffset_27;

		// Token: 0x04014511 RID: 83217
		internal static int __PropertyOffset_28;

		// Token: 0x04014512 RID: 83218
		private TMap<FName, int> _TagDict;

		// Token: 0x04014513 RID: 83219
		internal static int __PropertyOffset_29;

		// Token: 0x04014514 RID: 83220
		private TMap<FName, int> _TagIndex;

		// Token: 0x04014515 RID: 83221
		internal static int __PropertyOffset_30;

		// Token: 0x04014516 RID: 83222
		private TArray<float> _CustomTime;

		// Token: 0x04014517 RID: 83223
		private static IntPtr __Reset_NativeFunctionPtr;

		// Token: 0x04014518 RID: 83224
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04014519 RID: 83225
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0401451A RID: 83226
		private static IntPtr __OnWeaponInteraction_NativeFunctionPtr;

		// Token: 0x0200A2BC RID: 41660
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031FF7 RID: 204791
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x0200A2BD RID: 41661
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __OnWeaponInteraction_FunctionParams
		{
			// Token: 0x04031FF8 RID: 204792
			[FieldOffset(0)]
			public FVectorDouble OriginPoint;

			// Token: 0x04031FF9 RID: 204793
			[FieldOffset(24)]
			public IntPtr Config;

			// Token: 0x04031FFA RID: 204794
			[FieldOffset(32)]
			public int Id;
		}
	}
}

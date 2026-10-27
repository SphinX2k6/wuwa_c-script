using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.GI.NewCloud.BP
{
	// Token: 0x02003D5A RID: 15706
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/GI/NewCloud/BP/BP_Clouds.BP_Clouds_C")]
	[UnrealStructLayout(1624, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1622)]
	public class BP_Clouds_C : AKuroCloudsActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060265BB RID: 157115 RVA: 0x00973090 File Offset: 0x00971290
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_Clouds_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/GI/NewCloud/BP/BP_Clouds.BP_Clouds_C");
			}
			return BP_Clouds_C._ClassPtr;
		}

		// Token: 0x060265BC RID: 157116 RVA: 0x009730B4 File Offset: 0x009712B4
		public BP_Clouds_C() : this(BuiltinUtils.AllocNativeUObject(BP_Clouds_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060265BD RID: 157117 RVA: 0x009730DC File Offset: 0x009712DC
		[NullableContext(1)]
		public BP_Clouds_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_Clouds_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170051EA RID: 20970
		// (get) Token: 0x060265BE RID: 157118 RVA: 0x0097310F File Offset: 0x0097130F
		// (set) Token: 0x060265BF RID: 157119 RVA: 0x00973123 File Offset: 0x00971323
		public unsafe UChildActorComponent Cloud02
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Clouds_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Clouds_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170051EB RID: 20971
		// (get) Token: 0x060265C0 RID: 157120 RVA: 0x00973138 File Offset: 0x00971338
		// (set) Token: 0x060265C1 RID: 157121 RVA: 0x0097314C File Offset: 0x0097134C
		public unsafe UChildActorComponent Cloud01
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Clouds_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Clouds_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x170051EC RID: 20972
		// (get) Token: 0x060265C2 RID: 157122 RVA: 0x00973161 File Offset: 0x00971361
		// (set) Token: 0x060265C3 RID: 157123 RVA: 0x00973175 File Offset: 0x00971375
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Clouds_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Clouds_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x170051ED RID: 20973
		// (get) Token: 0x060265C4 RID: 157124 RVA: 0x0097318A File Offset: 0x0097138A
		// (set) Token: 0x060265C5 RID: 157125 RVA: 0x0097319E File Offset: 0x0097139E
		[Nullable(0)]
		public unsafe TEnumAsByte<E_Cloud_Presents> 当前云预设_不要改_
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Clouds_C.__PropertyOffset_4);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)BP_Clouds_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x170051EE RID: 20974
		// (get) Token: 0x060265C6 RID: 157126 RVA: 0x009731B3 File Offset: 0x009713B3
		// (set) Token: 0x060265C7 RID: 157127 RVA: 0x009731C7 File Offset: 0x009713C7
		public unsafe PD_CloudPreset_C CloudData
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<PD_CloudPreset_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Clouds_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Clouds_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x170051EF RID: 20975
		// (get) Token: 0x060265C8 RID: 157128 RVA: 0x009731DC File Offset: 0x009713DC
		// (set) Token: 0x060265C9 RID: 157129 RVA: 0x009731EC File Offset: 0x009713EC
		public unsafe bool Counting
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Clouds_C.__PropertyOffset_6) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Clouds_C.__PropertyOffset_6) = (value ? 1 : 0);
			}
		}

		// Token: 0x170051F0 RID: 20976
		// (get) Token: 0x060265CA RID: 157130 RVA: 0x009731FD File Offset: 0x009713FD
		// (set) Token: 0x060265CB RID: 157131 RVA: 0x00973211 File Offset: 0x00971411
		[Nullable(0)]
		public unsafe TEnumAsByte<E_Cloud_Presents> 默认进入云预设
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Clouds_C.__PropertyOffset_7);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)BP_Clouds_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x170051F1 RID: 20977
		// (get) Token: 0x060265CC RID: 157132 RVA: 0x00973226 File Offset: 0x00971426
		// (set) Token: 0x060265CD RID: 157133 RVA: 0x0097323B File Offset: 0x0097143B
		[Nullable(1)]
		public TSoftObjectPtr<PD_CloudPrefab_C> CloudAsset
		{
			[NullableContext(1)]
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)BP_Clouds_C.__PropertyOffset_8, this);
			}
			[NullableContext(1)]
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_Clouds_C.__PropertyOffset_8, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170051F2 RID: 20978
		// (get) Token: 0x060265CE RID: 157134 RVA: 0x00973260 File Offset: 0x00971460
		// (set) Token: 0x060265CF RID: 157135 RVA: 0x00973299 File Offset: 0x00971499
		[Nullable(1)]
		public TArray<int> SortNumber
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._SortNumber) == null)
				{
					result = (this._SortNumber = new TArray<int>(base.NativePtr + (IntPtr)BP_Clouds_C.__PropertyOffset_9, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.SortNumber.CopyAssign(value);
			}
		}

		// Token: 0x170051F3 RID: 20979
		// (get) Token: 0x060265D0 RID: 157136 RVA: 0x009732A7 File Offset: 0x009714A7
		// (set) Token: 0x060265D1 RID: 157137 RVA: 0x009732BB File Offset: 0x009714BB
		public unsafe PD_CloudPrefab_C As_PD_Cloud_Prefab
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<PD_CloudPrefab_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Clouds_C.__PropertyOffset_10);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Clouds_C.__PropertyOffset_10, value);
			}
		}

		// Token: 0x170051F4 RID: 20980
		// (get) Token: 0x060265D2 RID: 157138 RVA: 0x009732D0 File Offset: 0x009714D0
		// (set) Token: 0x060265D3 RID: 157139 RVA: 0x009732E4 File Offset: 0x009714E4
		public unsafe UAkAudioEvent CachedAudioEvent2D
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkAudioEvent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Clouds_C.__PropertyOffset_11);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Clouds_C.__PropertyOffset_11, value);
			}
		}

		// Token: 0x170051F5 RID: 20981
		// (get) Token: 0x060265D4 RID: 157140 RVA: 0x009732F9 File Offset: 0x009714F9
		// (set) Token: 0x060265D5 RID: 157141 RVA: 0x00973309 File Offset: 0x00971509
		public unsafe bool IsSkyOcean
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Clouds_C.__PropertyOffset_12) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Clouds_C.__PropertyOffset_12) = (value ? 1 : 0);
			}
		}

		// Token: 0x170051F6 RID: 20982
		// (get) Token: 0x060265D6 RID: 157142 RVA: 0x0097331A File Offset: 0x0097151A
		// (set) Token: 0x060265D7 RID: 157143 RVA: 0x0097332E File Offset: 0x0097152E
		public unsafe UAkAudioEvent SkyOceanAudio
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkAudioEvent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Clouds_C.__PropertyOffset_13);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Clouds_C.__PropertyOffset_13, value);
			}
		}

		// Token: 0x170051F7 RID: 20983
		// (get) Token: 0x060265D8 RID: 157144 RVA: 0x00973343 File Offset: 0x00971543
		// (set) Token: 0x060265D9 RID: 157145 RVA: 0x00973353 File Offset: 0x00971553
		public unsafe bool Override_Cloud_Rotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Clouds_C.__PropertyOffset_14) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Clouds_C.__PropertyOffset_14) = (value ? 1 : 0);
			}
		}

		// Token: 0x170051F8 RID: 20984
		// (get) Token: 0x060265DA RID: 157146 RVA: 0x00973364 File Offset: 0x00971564
		// (set) Token: 0x060265DB RID: 157147 RVA: 0x00973374 File Offset: 0x00971574
		public unsafe float Cloud_Speed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Clouds_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Clouds_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x170051F9 RID: 20985
		// (get) Token: 0x060265DC RID: 157148 RVA: 0x00973385 File Offset: 0x00971585
		// (set) Token: 0x060265DD RID: 157149 RVA: 0x00973395 File Offset: 0x00971595
		public unsafe float Cloud_Offset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Clouds_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Clouds_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x170051FA RID: 20986
		// (get) Token: 0x060265DE RID: 157150 RVA: 0x009733A6 File Offset: 0x009715A6
		// (set) Token: 0x060265DF RID: 157151 RVA: 0x009733B6 File Offset: 0x009715B6
		public unsafe bool IsReversed_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Clouds_C.__PropertyOffset_17) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Clouds_C.__PropertyOffset_17) = (value ? 1 : 0);
			}
		}

		// Token: 0x170051FB RID: 20987
		// (get) Token: 0x060265E0 RID: 157152 RVA: 0x009733C7 File Offset: 0x009715C7
		// (set) Token: 0x060265E1 RID: 157153 RVA: 0x009733D7 File Offset: 0x009715D7
		public unsafe float ReversedZHeightBias
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Clouds_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Clouds_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x170051FC RID: 20988
		// (get) Token: 0x060265E2 RID: 157154 RVA: 0x009733E8 File Offset: 0x009715E8
		// (set) Token: 0x060265E3 RID: 157155 RVA: 0x009733F8 File Offset: 0x009715F8
		public unsafe KuroFeatureLevel FeatureLevel
		{
			get
			{
				return (KuroFeatureLevel)(*(base.NativePtr + (IntPtr)BP_Clouds_C.__PropertyOffset_19));
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Clouds_C.__PropertyOffset_19) = (byte)value;
			}
		}

		// Token: 0x170051FD RID: 20989
		// (get) Token: 0x060265E4 RID: 157156 RVA: 0x00973409 File Offset: 0x00971609
		// (set) Token: 0x060265E5 RID: 157157 RVA: 0x00973419 File Offset: 0x00971619
		public unsafe bool IsHiddenClouds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Clouds_C.__PropertyOffset_20) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Clouds_C.__PropertyOffset_20) = (value ? 1 : 0);
			}
		}

		// Token: 0x060265E6 RID: 157158 RVA: 0x0097342A File Offset: 0x0097162A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _41_金匣冷调()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___41_金匣冷调_NativeFunctionPtr, null);
		}

		// Token: 0x060265E7 RID: 157159 RVA: 0x0097343E File Offset: 0x0097163E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _40_天演幻心二阶段()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___40_天演幻心二阶段_NativeFunctionPtr, null);
		}

		// Token: 0x060265E8 RID: 157160 RVA: 0x00973452 File Offset: 0x00971652
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _39_天演幻心()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___39_天演幻心_NativeFunctionPtr, null);
		}

		// Token: 0x060265E9 RID: 157161 RVA: 0x00973466 File Offset: 0x00971666
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _38_金匣()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___38_金匣_NativeFunctionPtr, null);
		}

		// Token: 0x060265EA RID: 157162 RVA: 0x0097347A File Offset: 0x0097167A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _37_水匣()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___37_水匣_NativeFunctionPtr, null);
		}

		// Token: 0x060265EB RID: 157163 RVA: 0x0097348E File Offset: 0x0097168E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _36_火匣()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___36_火匣_NativeFunctionPtr, null);
		}

		// Token: 0x060265EC RID: 157164 RVA: 0x009734A4 File Offset: 0x009716A4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SwitchCloudsSub(PD_CloudPrefab_C CloudPresents, float ChangeSpeed, bool InstantHide)
		{
			BP_Clouds_C.__SwitchCloudsSub_FunctionParams* ptr = stackalloc BP_Clouds_C.__SwitchCloudsSub_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(BP_Clouds_C.__SwitchCloudsSub_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Clouds_C.__SwitchCloudsSub_NativeFunctionPtr, (void*)ptr, 1);
			ptr->CloudPresents = ((CloudPresents != null) ? CloudPresents.NativePtr : IntPtr.Zero);
			ptr->ChangeSpeed = ChangeSpeed;
			ptr->InstantHide = InstantHide;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.__SwitchCloudsSub_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060265ED RID: 157165 RVA: 0x00973507 File Offset: 0x00971707
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _35_心湖()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___35_心湖_NativeFunctionPtr, null);
		}

		// Token: 0x060265EE RID: 157166 RVA: 0x0097351B File Offset: 0x0097171B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _34_天境()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___34_天境_NativeFunctionPtr, null);
		}

		// Token: 0x060265EF RID: 157167 RVA: 0x0097352F File Offset: 0x0097172F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _33_地境()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___33_地境_NativeFunctionPtr, null);
		}

		// Token: 0x060265F0 RID: 157168 RVA: 0x00973543 File Offset: 0x00971743
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _32_人境()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___32_人境_NativeFunctionPtr, null);
		}

		// Token: 0x060265F1 RID: 157169 RVA: 0x00973557 File Offset: 0x00971757
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _31_梦州特殊2()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___31_梦州特殊2_NativeFunctionPtr, null);
		}

		// Token: 0x060265F2 RID: 157170 RVA: 0x0097356B File Offset: 0x0097176B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _30_梦州特殊1()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___30_梦州特殊1_NativeFunctionPtr, null);
		}

		// Token: 0x060265F3 RID: 157171 RVA: 0x0097357F File Offset: 0x0097177F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _29_宅邸解谜后()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___29_宅邸解谜后_NativeFunctionPtr, null);
		}

		// Token: 0x060265F4 RID: 157172 RVA: 0x00973593 File Offset: 0x00971793
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _28_宅邸解谜前()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___28_宅邸解谜前_NativeFunctionPtr, null);
		}

		// Token: 0x060265F5 RID: 157173 RVA: 0x009735A7 File Offset: 0x009717A7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _27_梦州初见()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___27_梦州初见_NativeFunctionPtr, null);
		}

		// Token: 0x060265F6 RID: 157174 RVA: 0x009735BB File Offset: 0x009717BB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _26_梦州阴天()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___26_梦州阴天_NativeFunctionPtr, null);
		}

		// Token: 0x060265F7 RID: 157175 RVA: 0x009735CF File Offset: 0x009717CF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _25_梦州夜晚()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___25_梦州夜晚_NativeFunctionPtr, null);
		}

		// Token: 0x060265F8 RID: 157176 RVA: 0x009735E3 File Offset: 0x009717E3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _24_梦州白天()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___24_梦州白天_NativeFunctionPtr, null);
		}

		// Token: 0x060265F9 RID: 157177 RVA: 0x009735F7 File Offset: 0x009717F7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _23_高达Boss三阶()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___23_高达Boss三阶_NativeFunctionPtr, null);
		}

		// Token: 0x060265FA RID: 157178 RVA: 0x0097360B File Offset: 0x0097180B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _22_高达Boss一阶()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___22_高达Boss一阶_NativeFunctionPtr, null);
		}

		// Token: 0x060265FB RID: 157179 RVA: 0x0097361F File Offset: 0x0097181F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _21_日灵棺解密后()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___21_日灵棺解密后_NativeFunctionPtr, null);
		}

		// Token: 0x060265FC RID: 157180 RVA: 0x00973633 File Offset: 0x00971833
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _20_日灵棺解密前()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___20_日灵棺解密前_NativeFunctionPtr, null);
		}

		// Token: 0x060265FD RID: 157181 RVA: 0x00973647 File Offset: 0x00971847
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _19_拉海洛初见()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___19_拉海洛初见_NativeFunctionPtr, null);
		}

		// Token: 0x060265FE RID: 157182 RVA: 0x0097365B File Offset: 0x0097185B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _18_星海BOSS三阶()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___18_星海BOSS三阶_NativeFunctionPtr, null);
		}

		// Token: 0x060265FF RID: 157183 RVA: 0x0097366F File Offset: 0x0097186F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _17_星海BOSS一阶()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___17_星海BOSS一阶_NativeFunctionPtr, null);
		}

		// Token: 0x06026600 RID: 157184 RVA: 0x00973683 File Offset: 0x00971883
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _16_罗伊初见()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___16_罗伊初见_NativeFunctionPtr, null);
		}

		// Token: 0x06026601 RID: 157185 RVA: 0x00973697 File Offset: 0x00971897
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _15_罗伊极光()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___15_罗伊极光_NativeFunctionPtr, null);
		}

		// Token: 0x06026602 RID: 157186 RVA: 0x009736AB File Offset: 0x009718AB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _14_罗伊夜晚()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___14_罗伊夜晚_NativeFunctionPtr, null);
		}

		// Token: 0x06026603 RID: 157187 RVA: 0x009736BF File Offset: 0x009718BF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _13_罗伊白天()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___13_罗伊白天_NativeFunctionPtr, null);
		}

		// Token: 0x06026604 RID: 157188 RVA: 0x009736D3 File Offset: 0x009718D3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _24_不渲染BP_Cloud控制的云()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___24_不渲染BP_Cloud控制的云_NativeFunctionPtr, null);
		}

		// Token: 0x06026605 RID: 157189 RVA: 0x009736E7 File Offset: 0x009718E7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _12_梵高()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___12_梵高_NativeFunctionPtr, null);
		}

		// Token: 0x06026606 RID: 157190 RVA: 0x009736FB File Offset: 0x009718FB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _11_拉海洛阴天()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___11_拉海洛阴天_NativeFunctionPtr, null);
		}

		// Token: 0x06026607 RID: 157191 RVA: 0x0097370F File Offset: 0x0097190F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _10_浮光林夜晚()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___10_浮光林夜晚_NativeFunctionPtr, null);
		}

		// Token: 0x06026608 RID: 157192 RVA: 0x00973723 File Offset: 0x00971923
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _09_浮光林白天()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___09_浮光林白天_NativeFunctionPtr, null);
		}

		// Token: 0x06026609 RID: 157193 RVA: 0x00973737 File Offset: 0x00971937
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _08_炉芯领主()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___08_炉芯领主_NativeFunctionPtr, null);
		}

		// Token: 0x0602660A RID: 157194 RVA: 0x0097374B File Offset: 0x0097194B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _07_炉芯内部()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___07_炉芯内部_NativeFunctionPtr, null);
		}

		// Token: 0x0602660B RID: 157195 RVA: 0x0097375F File Offset: 0x0097195F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _06_坠落炉芯()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___06_坠落炉芯_NativeFunctionPtr, null);
		}

		// Token: 0x0602660C RID: 157196 RVA: 0x00973773 File Offset: 0x00971973
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _05_星门Boss()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___05_星门Boss_NativeFunctionPtr, null);
		}

		// Token: 0x0602660D RID: 157197 RVA: 0x00973787 File Offset: 0x00971987
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _04_磁暴后置()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___04_磁暴后置_NativeFunctionPtr, null);
		}

		// Token: 0x0602660E RID: 157198 RVA: 0x0097379B File Offset: 0x0097199B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _03_磁暴前置()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___03_磁暴前置_NativeFunctionPtr, null);
		}

		// Token: 0x0602660F RID: 157199 RVA: 0x009737AF File Offset: 0x009719AF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _02_拉海洛夜晚()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___02_拉海洛夜晚_NativeFunctionPtr, null);
		}

		// Token: 0x06026610 RID: 157200 RVA: 0x009737C3 File Offset: 0x009719C3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _01_拉海落白天()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___01_拉海落白天_NativeFunctionPtr, null);
		}

		// Token: 0x06026611 RID: 157201 RVA: 0x009737D7 File Offset: 0x009719D7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _23_安全点夜晚()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___23_安全点夜晚_NativeFunctionPtr, null);
		}

		// Token: 0x06026612 RID: 157202 RVA: 0x009737EB File Offset: 0x009719EB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _22_安全点白天()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___22_安全点白天_NativeFunctionPtr, null);
		}

		// Token: 0x06026613 RID: 157203 RVA: 0x009737FF File Offset: 0x009719FF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _23_穗波阴天()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___23_穗波阴天_NativeFunctionPtr, null);
		}

		// Token: 0x06026614 RID: 157204 RVA: 0x00973813 File Offset: 0x00971A13
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _22_穗波枯山水()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___22_穗波枯山水_NativeFunctionPtr, null);
		}

		// Token: 0x06026615 RID: 157205 RVA: 0x00973827 File Offset: 0x00971A27
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _21_穗波夜晚()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___21_穗波夜晚_NativeFunctionPtr, null);
		}

		// Token: 0x06026616 RID: 157206 RVA: 0x0097383B File Offset: 0x00971A3B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _20_穗波白天()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___20_穗波白天_NativeFunctionPtr, null);
		}

		// Token: 0x06026617 RID: 157207 RVA: 0x0097384F File Offset: 0x00971A4F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _21_总督日月同辉()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___21_总督日月同辉_NativeFunctionPtr, null);
		}

		// Token: 0x06026618 RID: 157208 RVA: 0x00973863 File Offset: 0x00971A63
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _21_烈阳天气()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___21_烈阳天气_NativeFunctionPtr, null);
		}

		// Token: 0x06026619 RID: 157209 RVA: 0x00973877 File Offset: 0x00971A77
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _20_黑潮风暴加强()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___20_黑潮风暴加强_NativeFunctionPtr, null);
		}

		// Token: 0x0602661A RID: 157210 RVA: 0x0097388B File Offset: 0x00971A8B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _19_黑潮风暴()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___19_黑潮风暴_NativeFunctionPtr, null);
		}

		// Token: 0x0602661B RID: 157211 RVA: 0x0097389F File Offset: 0x00971A9F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _18_失亡彼岸()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___18_失亡彼岸_NativeFunctionPtr, null);
		}

		// Token: 0x0602661C RID: 157212 RVA: 0x009738B3 File Offset: 0x00971AB3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _17_隐海试验场()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___17_隐海试验场_NativeFunctionPtr, null);
		}

		// Token: 0x0602661D RID: 157213 RVA: 0x009738C7 File Offset: 0x00971AC7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _16_巡游天国()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___16_巡游天国_NativeFunctionPtr, null);
		}

		// Token: 0x0602661E RID: 157214 RVA: 0x009738DB File Offset: 0x00971ADB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _15_光路幻境()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___15_光路幻境_NativeFunctionPtr, null);
		}

		// Token: 0x0602661F RID: 157215 RVA: 0x009738EF File Offset: 0x00971AEF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _14_黑潮内里世界()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___14_黑潮内里世界_NativeFunctionPtr, null);
		}

		// Token: 0x06026620 RID: 157216 RVA: 0x00973903 File Offset: 0x00971B03
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _13_黑潮内表世界()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___13_黑潮内表世界_NativeFunctionPtr, null);
		}

		// Token: 0x06026621 RID: 157217 RVA: 0x00973917 File Offset: 0x00971B17
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _12_黑潮侵蚀()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___12_黑潮侵蚀_NativeFunctionPtr, null);
		}

		// Token: 0x06026622 RID: 157218 RVA: 0x0097392B File Offset: 0x00971B2B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _19_狄斯台地月相()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___19_狄斯台地月相_NativeFunctionPtr, null);
		}

		// Token: 0x06026623 RID: 157219 RVA: 0x0097393F File Offset: 0x00971B3F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _18_狄斯台地受蚀地()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___18_狄斯台地受蚀地_NativeFunctionPtr, null);
		}

		// Token: 0x06026624 RID: 157220 RVA: 0x00973953 File Offset: 0x00971B53
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _17_狄斯台地烈日天空()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___17_狄斯台地烈日天空_NativeFunctionPtr, null);
		}

		// Token: 0x06026625 RID: 157221 RVA: 0x00973967 File Offset: 0x00971B67
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _16_狄斯台地日月同辉()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___16_狄斯台地日月同辉_NativeFunctionPtr, null);
		}

		// Token: 0x06026626 RID: 157222 RVA: 0x0097397B File Offset: 0x00971B7B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _15_狄斯台地夜晚()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___15_狄斯台地夜晚_NativeFunctionPtr, null);
		}

		// Token: 0x06026627 RID: 157223 RVA: 0x0097398F File Offset: 0x00971B8F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _14_狄斯台地白天()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___14_狄斯台地白天_NativeFunctionPtr, null);
		}

		// Token: 0x06026628 RID: 157224 RVA: 0x009739A3 File Offset: 0x00971BA3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _13_七丘夜晚()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___13_七丘夜晚_NativeFunctionPtr, null);
		}

		// Token: 0x06026629 RID: 157225 RVA: 0x009739B7 File Offset: 0x00971BB7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _12_观测塔()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___12_观测塔_NativeFunctionPtr, null);
		}

		// Token: 0x0602662A RID: 157226 RVA: 0x009739CB File Offset: 0x00971BCB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _11_尖刺山()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___11_尖刺山_NativeFunctionPtr, null);
		}

		// Token: 0x0602662B RID: 157227 RVA: 0x009739DF File Offset: 0x00971BDF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _10_残破竞技场()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___10_残破竞技场_NativeFunctionPtr, null);
		}

		// Token: 0x0602662C RID: 157228 RVA: 0x009739F3 File Offset: 0x00971BF3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _09_七丘阴天()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___09_七丘阴天_NativeFunctionPtr, null);
		}

		// Token: 0x0602662D RID: 157229 RVA: 0x00973A07 File Offset: 0x00971C07
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _08_初见七丘()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___08_初见七丘_NativeFunctionPtr, null);
		}

		// Token: 0x0602662E RID: 157230 RVA: 0x00973A1B File Offset: 0x00971C1B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _07_七丘()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___07_七丘_NativeFunctionPtr, null);
		}

		// Token: 0x0602662F RID: 157231 RVA: 0x00973A2F File Offset: 0x00971C2F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _11_颠倒塔流星()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___11_颠倒塔流星_NativeFunctionPtr, null);
		}

		// Token: 0x06026630 RID: 157232 RVA: 0x00973A43 File Offset: 0x00971C43
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _10_颠倒塔夜晚()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___10_颠倒塔夜晚_NativeFunctionPtr, null);
		}

		// Token: 0x06026631 RID: 157233 RVA: 0x00973A57 File Offset: 0x00971C57
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _09_颠倒塔白天()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___09_颠倒塔白天_NativeFunctionPtr, null);
		}

		// Token: 0x06026632 RID: 157234 RVA: 0x00973A6B File Offset: 0x00971C6B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _08_彩虹天气()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___08_彩虹天气_NativeFunctionPtr, null);
		}

		// Token: 0x06026633 RID: 157235 RVA: 0x00973A7F File Offset: 0x00971C7F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void CloudMainParamsUpdate()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.__CloudMainParamsUpdate_NativeFunctionPtr, null);
		}

		// Token: 0x06026634 RID: 157236 RVA: 0x00973A93 File Offset: 0x00971C93
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _07_费洛洛出场()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___07_费洛洛出场_NativeFunctionPtr, null);
		}

		// Token: 0x06026635 RID: 157237 RVA: 0x00973AA7 File Offset: 0x00971CA7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _06_金库上解密后()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___06_金库上解密后_NativeFunctionPtr, null);
		}

		// Token: 0x06026636 RID: 157238 RVA: 0x00973ABB File Offset: 0x00971CBB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _05_罗墓岛夜晚()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___05_罗墓岛夜晚_NativeFunctionPtr, null);
		}

		// Token: 0x06026637 RID: 157239 RVA: 0x00973ACF File Offset: 0x00971CCF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _06_黎娜夕塔阴()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___06_黎娜夕塔阴_NativeFunctionPtr, null);
		}

		// Token: 0x06026638 RID: 157240 RVA: 0x00973AE3 File Offset: 0x00971CE3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _04_云海区()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___04_云海区_NativeFunctionPtr, null);
		}

		// Token: 0x06026639 RID: 157241 RVA: 0x00973AF7 File Offset: 0x00971CF7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _03_槲生半岛解密后()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___03_槲生半岛解密后_NativeFunctionPtr, null);
		}

		// Token: 0x0602663A RID: 157242 RVA: 0x00973B0B File Offset: 0x00971D0B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _05_狂欢节()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___05_狂欢节_NativeFunctionPtr, null);
		}

		// Token: 0x0602663B RID: 157243 RVA: 0x00973B1F File Offset: 0x00971D1F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 显示云移动范围()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.__显示云移动范围_NativeFunctionPtr, null);
		}

		// Token: 0x0602663C RID: 157244 RVA: 0x00973B33 File Offset: 0x00971D33
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 关闭云跟随摄像机移动()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.__关闭云跟随摄像机移动_NativeFunctionPtr, null);
		}

		// Token: 0x0602663D RID: 157245 RVA: 0x00973B47 File Offset: 0x00971D47
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 开启云跟随摄像机移动()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.__开启云跟随摄像机移动_NativeFunctionPtr, null);
		}

		// Token: 0x0602663E RID: 157246 RVA: 0x00973B5B File Offset: 0x00971D5B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _04_金库上层()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___04_金库上层_NativeFunctionPtr, null);
		}

		// Token: 0x0602663F RID: 157247 RVA: 0x00973B6F File Offset: 0x00971D6F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _03_狄萨莱海脊永夜解密后()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___03_狄萨莱海脊永夜解密后_NativeFunctionPtr, null);
		}

		// Token: 0x06026640 RID: 157248 RVA: 0x00973B83 File Offset: 0x00971D83
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _02_狄萨莱海脊永夜解密前()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___02_狄萨莱海脊永夜解密前_NativeFunctionPtr, null);
		}

		// Token: 0x06026641 RID: 157249 RVA: 0x00973B97 File Offset: 0x00971D97
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _01_槲生半岛()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___01_槲生半岛_NativeFunctionPtr, null);
		}

		// Token: 0x06026642 RID: 157250 RVA: 0x00973BAB File Offset: 0x00971DAB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _02_帕尔米罗墓地()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___02_帕尔米罗墓地_NativeFunctionPtr, null);
		}

		// Token: 0x06026643 RID: 157251 RVA: 0x00973BBF File Offset: 0x00971DBF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _01_黎娜汐塔()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___01_黎娜汐塔_NativeFunctionPtr, null);
		}

		// Token: 0x06026644 RID: 157252 RVA: 0x00973BD3 File Offset: 0x00971DD3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _020黑海岸天气_阴()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___020黑海岸天气_阴_NativeFunctionPtr, null);
		}

		// Token: 0x06026645 RID: 157253 RVA: 0x00973BE7 File Offset: 0x00971DE7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _019肉鸽月亮05()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___019肉鸽月亮05_NativeFunctionPtr, null);
		}

		// Token: 0x06026646 RID: 157254 RVA: 0x00973BFB File Offset: 0x00971DFB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _018肉鸽月亮04()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___018肉鸽月亮04_NativeFunctionPtr, null);
		}

		// Token: 0x06026647 RID: 157255 RVA: 0x00973C0F File Offset: 0x00971E0F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _017肉鸽月亮03()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___017肉鸽月亮03_NativeFunctionPtr, null);
		}

		// Token: 0x06026648 RID: 157256 RVA: 0x00973C23 File Offset: 0x00971E23
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _016肉鸽月亮02()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___016肉鸽月亮02_NativeFunctionPtr, null);
		}

		// Token: 0x06026649 RID: 157257 RVA: 0x00973C37 File Offset: 0x00971E37
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _015肉鸽月亮01()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___015肉鸽月亮01_NativeFunctionPtr, null);
		}

		// Token: 0x0602664A RID: 157258 RVA: 0x00973C4B File Offset: 0x00971E4B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _014黑海岸夜晚()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___014黑海岸夜晚_NativeFunctionPtr, null);
		}

		// Token: 0x0602664B RID: 157259 RVA: 0x00973C5F File Offset: 0x00971E5F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _08黑海岸下层()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___08黑海岸下层_NativeFunctionPtr, null);
		}

		// Token: 0x0602664C RID: 157260 RVA: 0x00973C73 File Offset: 0x00971E73
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _07黑海岸上层()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___07黑海岸上层_NativeFunctionPtr, null);
		}

		// Token: 0x0602664D RID: 157261 RVA: 0x00973C88 File Offset: 0x00971E88
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Get_GIParams(float CurTime)
		{
			BP_Clouds_C.__Get_GIParams_FunctionParams* ptr = stackalloc BP_Clouds_C.__Get_GIParams_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Clouds_C.__Get_GIParams_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Clouds_C.__Get_GIParams_NativeFunctionPtr, (void*)ptr, 1);
			ptr->CurTime = CurTime;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.__Get_GIParams_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602664E RID: 157262 RVA: 0x00973CCE File Offset: 0x00971ECE
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _06乘宵山()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___06乘宵山_NativeFunctionPtr, null);
		}

		// Token: 0x0602664F RID: 157263 RVA: 0x00973CE2 File Offset: 0x00971EE2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _05怨鸟泽()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___05怨鸟泽_NativeFunctionPtr, null);
		}

		// Token: 0x06026650 RID: 157264 RVA: 0x00973CF6 File Offset: 0x00971EF6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _013乘宵山异象()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___013乘宵山异象_NativeFunctionPtr, null);
		}

		// Token: 0x06026651 RID: 157265 RVA: 0x00973D0A File Offset: 0x00971F0A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _012夜晚异象()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___012夜晚异象_NativeFunctionPtr, null);
		}

		// Token: 0x06026652 RID: 157266 RVA: 0x00973D1E File Offset: 0x00971F1E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _011黄昏异象()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___011黄昏异象_NativeFunctionPtr, null);
		}

		// Token: 0x06026653 RID: 157267 RVA: 0x00973D32 File Offset: 0x00971F32
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _010阴天异象()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___010阴天异象_NativeFunctionPtr, null);
		}

		// Token: 0x06026654 RID: 157268 RVA: 0x00973D46 File Offset: 0x00971F46
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _09鸣潮天气()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___09鸣潮天气_NativeFunctionPtr, null);
		}

		// Token: 0x06026655 RID: 157269 RVA: 0x00973D5A File Offset: 0x00971F5A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _08漩涡云01()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___08漩涡云01_NativeFunctionPtr, null);
		}

		// Token: 0x06026656 RID: 157270 RVA: 0x00973D6E File Offset: 0x00971F6E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _07无音区05()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___07无音区05_NativeFunctionPtr, null);
		}

		// Token: 0x06026657 RID: 157271 RVA: 0x00973D82 File Offset: 0x00971F82
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _06无音区04()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___06无音区04_NativeFunctionPtr, null);
		}

		// Token: 0x06026658 RID: 157272 RVA: 0x00973D96 File Offset: 0x00971F96
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _05无音区03()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___05无音区03_NativeFunctionPtr, null);
		}

		// Token: 0x06026659 RID: 157273 RVA: 0x00973DAA File Offset: 0x00971FAA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _04无音区02()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___04无音区02_NativeFunctionPtr, null);
		}

		// Token: 0x0602665A RID: 157274 RVA: 0x00973DBE File Offset: 0x00971FBE
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 原画测试用云()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.__原画测试用云_NativeFunctionPtr, null);
		}

		// Token: 0x0602665B RID: 157275 RVA: 0x00973DD4 File Offset: 0x00971FD4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetCloudParameters(PD_CloudPrefab_C CloudPrefeb, UChildActorComponent CloudActorComponent, float ChangeSpeed, int TransSortNumber, bool bInstantHide)
		{
			BP_Clouds_C.__SetCloudParameters_FunctionParams* ptr = stackalloc BP_Clouds_C.__SetCloudParameters_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(BP_Clouds_C.__SetCloudParameters_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Clouds_C.__SetCloudParameters_NativeFunctionPtr, (void*)ptr, 1);
			ptr->CloudPrefeb = ((CloudPrefeb != null) ? CloudPrefeb.NativePtr : IntPtr.Zero);
			ptr->CloudActorComponent = ((CloudActorComponent != null) ? CloudActorComponent.NativePtr : IntPtr.Zero);
			ptr->ChangeSpeed = ChangeSpeed;
			ptr->TransSortNumber = TransSortNumber;
			ptr->bInstantHide = bInstantHide;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.__SetCloudParameters_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602665C RID: 157276 RVA: 0x00973E56 File Offset: 0x00972056
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _04中曲台地()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___04中曲台地_NativeFunctionPtr, null);
		}

		// Token: 0x0602665D RID: 157277 RVA: 0x00973E6A File Offset: 0x0097206A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Hidden_Old()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.__Hidden_Old_NativeFunctionPtr, null);
		}

		// Token: 0x0602665E RID: 157278 RVA: 0x00973E7E File Offset: 0x0097207E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _03无音区01()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___03无音区01_NativeFunctionPtr, null);
		}

		// Token: 0x0602665F RID: 157279 RVA: 0x00973E92 File Offset: 0x00972092
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _02无音区沉寂态()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___02无音区沉寂态_NativeFunctionPtr, null);
		}

		// Token: 0x06026660 RID: 157280 RVA: 0x00973EA6 File Offset: 0x009720A6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _01登录界面()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___01登录界面_NativeFunctionPtr, null);
		}

		// Token: 0x06026661 RID: 157281 RVA: 0x00973EBA File Offset: 0x009720BA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _03无光之森()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___03无光之森_NativeFunctionPtr, null);
		}

		// Token: 0x06026662 RID: 157282 RVA: 0x00973ECE File Offset: 0x009720CE
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _02遗落原乡()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___02遗落原乡_NativeFunctionPtr, null);
		}

		// Token: 0x06026663 RID: 157283 RVA: 0x00973EE2 File Offset: 0x009720E2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _01天城()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___01天城_NativeFunctionPtr, null);
		}

		// Token: 0x06026664 RID: 157284 RVA: 0x00973EF6 File Offset: 0x009720F6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06026665 RID: 157285 RVA: 0x00973F0A File Offset: 0x0097210A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Clouds_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06026666 RID: 157286 RVA: 0x00973F20 File Offset: 0x00972120
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OnLoaded_63FE5E2B437AFAD504FBCAB26242EB8A(UObject Loaded)
		{
			BP_Clouds_C.__OnLoaded_63FE5E2B437AFAD504FBCAB26242EB8A_FunctionParams* ptr = stackalloc BP_Clouds_C.__OnLoaded_63FE5E2B437AFAD504FBCAB26242EB8A_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_Clouds_C.__OnLoaded_63FE5E2B437AFAD504FBCAB26242EB8A_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Clouds_C.__OnLoaded_63FE5E2B437AFAD504FBCAB26242EB8A_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Loaded = ((Loaded != null) ? Loaded.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.__OnLoaded_63FE5E2B437AFAD504FBCAB26242EB8A_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06026667 RID: 157287 RVA: 0x00973F75 File Offset: 0x00972175
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06026668 RID: 157288 RVA: 0x00973F89 File Offset: 0x00972189
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Clouds_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06026669 RID: 157289 RVA: 0x00973FA0 File Offset: 0x009721A0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_Clouds_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Clouds_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Clouds_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Clouds_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602666A RID: 157290 RVA: 0x00973FE8 File Offset: 0x009721E8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_Clouds_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Clouds_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Clouds_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Clouds_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Clouds_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602666B RID: 157291 RVA: 0x00974030 File Offset: 0x00972230
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_Clouds_C.__EditorTick_FunctionParams* ptr = stackalloc BP_Clouds_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Clouds_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Clouds_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602666C RID: 157292 RVA: 0x00974078 File Offset: 0x00972278
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_Clouds_C.__EditorTick_FunctionParams* ptr = stackalloc BP_Clouds_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Clouds_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Clouds_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Clouds_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602666D RID: 157293 RVA: 0x009740BF File Offset: 0x009722BF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void ChangeCloud()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.__ChangeCloud_NativeFunctionPtr, null);
		}

		// Token: 0x0602666E RID: 157294 RVA: 0x009740D4 File Offset: 0x009722D4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Switch_Clouds(E_Cloud_Presents CloudPresents, float ChangeSpeed, bool IsInEditor, bool bOverrideCloudRotation, float CloudSpeed, float CloudOffset, bool ControlSeqCloud, bool InstantHide)
		{
			BP_Clouds_C.__Switch_Clouds_FunctionParams* ptr = stackalloc BP_Clouds_C.__Switch_Clouds_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_Clouds_C.__Switch_Clouds_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Clouds_C.__Switch_Clouds_NativeFunctionPtr, (void*)ptr, 1);
			ptr->CloudPresents = CloudPresents;
			ptr->ChangeSpeed = ChangeSpeed;
			ptr->IsInEditor = IsInEditor;
			ptr->bOverrideCloudRotation = bOverrideCloudRotation;
			ptr->CloudSpeed = CloudSpeed;
			ptr->CloudOffset = CloudOffset;
			ptr->ControlSeqCloud = ControlSeqCloud;
			ptr->InstantHide = InstantHide;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.__Switch_Clouds_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602666F RID: 157295 RVA: 0x00974158 File Offset: 0x00972358
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void LoadAndSwitch(TSoftObjectPtr<UObject> Asset, float ChangeSpeed, bool IsInEditor, bool IsAudio, bool InstantHide)
		{
			BP_Clouds_C.__LoadAndSwitch_FunctionParams* ptr = stackalloc BP_Clouds_C.__LoadAndSwitch_FunctionParams[(UIntPtr)71] + 15L / (long)sizeof(BP_Clouds_C.__LoadAndSwitch_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Clouds_C.__LoadAndSwitch_NativeFunctionPtr, (void*)ptr, 1);
			if (Asset != null)
			{
				FSoftObjectPtr.NativeCopy(&ptr->Asset, Asset.NativePtr, 1);
			}
			ptr->ChangeSpeed = ChangeSpeed;
			ptr->IsInEditor = IsInEditor;
			ptr->IsAudio = IsAudio;
			ptr->InstantHide = InstantHide;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.__LoadAndSwitch_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(BP_Clouds_C.__LoadAndSwitch_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06026670 RID: 157296 RVA: 0x009741E2 File Offset: 0x009723E2
		protected BP_Clouds_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013388 RID: 78728
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/GI/NewCloud/BP/BP_Clouds.BP_Clouds_C";

		// Token: 0x04013389 RID: 78729
		private static IntPtr _ClassPtr;

		// Token: 0x0401338A RID: 78730
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401338B RID: 78731
		internal static int __PropertyOffset_1;

		// Token: 0x0401338C RID: 78732
		internal static int __PropertyOffset_2;

		// Token: 0x0401338D RID: 78733
		internal static int __PropertyOffset_3;

		// Token: 0x0401338E RID: 78734
		internal static int __PropertyOffset_4;

		// Token: 0x0401338F RID: 78735
		internal static int __PropertyOffset_5;

		// Token: 0x04013390 RID: 78736
		internal static int __PropertyOffset_6;

		// Token: 0x04013391 RID: 78737
		internal static int __PropertyOffset_7;

		// Token: 0x04013392 RID: 78738
		internal static int __PropertyOffset_8;

		// Token: 0x04013393 RID: 78739
		internal static int __PropertyOffset_9;

		// Token: 0x04013394 RID: 78740
		private TArray<int> _SortNumber;

		// Token: 0x04013395 RID: 78741
		internal static int __PropertyOffset_10;

		// Token: 0x04013396 RID: 78742
		internal static int __PropertyOffset_11;

		// Token: 0x04013397 RID: 78743
		internal static int __PropertyOffset_12;

		// Token: 0x04013398 RID: 78744
		internal static int __PropertyOffset_13;

		// Token: 0x04013399 RID: 78745
		internal static int __PropertyOffset_14;

		// Token: 0x0401339A RID: 78746
		internal static int __PropertyOffset_15;

		// Token: 0x0401339B RID: 78747
		internal static int __PropertyOffset_16;

		// Token: 0x0401339C RID: 78748
		internal static int __PropertyOffset_17;

		// Token: 0x0401339D RID: 78749
		internal static int __PropertyOffset_18;

		// Token: 0x0401339E RID: 78750
		internal static int __PropertyOffset_19;

		// Token: 0x0401339F RID: 78751
		internal static int __PropertyOffset_20;

		// Token: 0x040133A0 RID: 78752
		private static IntPtr ___41_金匣冷调_NativeFunctionPtr;

		// Token: 0x040133A1 RID: 78753
		private static IntPtr ___40_天演幻心二阶段_NativeFunctionPtr;

		// Token: 0x040133A2 RID: 78754
		private static IntPtr ___39_天演幻心_NativeFunctionPtr;

		// Token: 0x040133A3 RID: 78755
		private static IntPtr ___38_金匣_NativeFunctionPtr;

		// Token: 0x040133A4 RID: 78756
		private static IntPtr ___37_水匣_NativeFunctionPtr;

		// Token: 0x040133A5 RID: 78757
		private static IntPtr ___36_火匣_NativeFunctionPtr;

		// Token: 0x040133A6 RID: 78758
		private static IntPtr __SwitchCloudsSub_NativeFunctionPtr;

		// Token: 0x040133A7 RID: 78759
		private static IntPtr ___35_心湖_NativeFunctionPtr;

		// Token: 0x040133A8 RID: 78760
		private static IntPtr ___34_天境_NativeFunctionPtr;

		// Token: 0x040133A9 RID: 78761
		private static IntPtr ___33_地境_NativeFunctionPtr;

		// Token: 0x040133AA RID: 78762
		private static IntPtr ___32_人境_NativeFunctionPtr;

		// Token: 0x040133AB RID: 78763
		private static IntPtr ___31_梦州特殊2_NativeFunctionPtr;

		// Token: 0x040133AC RID: 78764
		private static IntPtr ___30_梦州特殊1_NativeFunctionPtr;

		// Token: 0x040133AD RID: 78765
		private static IntPtr ___29_宅邸解谜后_NativeFunctionPtr;

		// Token: 0x040133AE RID: 78766
		private static IntPtr ___28_宅邸解谜前_NativeFunctionPtr;

		// Token: 0x040133AF RID: 78767
		private static IntPtr ___27_梦州初见_NativeFunctionPtr;

		// Token: 0x040133B0 RID: 78768
		private static IntPtr ___26_梦州阴天_NativeFunctionPtr;

		// Token: 0x040133B1 RID: 78769
		private static IntPtr ___25_梦州夜晚_NativeFunctionPtr;

		// Token: 0x040133B2 RID: 78770
		private static IntPtr ___24_梦州白天_NativeFunctionPtr;

		// Token: 0x040133B3 RID: 78771
		private static IntPtr ___23_高达Boss三阶_NativeFunctionPtr;

		// Token: 0x040133B4 RID: 78772
		private static IntPtr ___22_高达Boss一阶_NativeFunctionPtr;

		// Token: 0x040133B5 RID: 78773
		private static IntPtr ___21_日灵棺解密后_NativeFunctionPtr;

		// Token: 0x040133B6 RID: 78774
		private static IntPtr ___20_日灵棺解密前_NativeFunctionPtr;

		// Token: 0x040133B7 RID: 78775
		private static IntPtr ___19_拉海洛初见_NativeFunctionPtr;

		// Token: 0x040133B8 RID: 78776
		private static IntPtr ___18_星海BOSS三阶_NativeFunctionPtr;

		// Token: 0x040133B9 RID: 78777
		private static IntPtr ___17_星海BOSS一阶_NativeFunctionPtr;

		// Token: 0x040133BA RID: 78778
		private static IntPtr ___16_罗伊初见_NativeFunctionPtr;

		// Token: 0x040133BB RID: 78779
		private static IntPtr ___15_罗伊极光_NativeFunctionPtr;

		// Token: 0x040133BC RID: 78780
		private static IntPtr ___14_罗伊夜晚_NativeFunctionPtr;

		// Token: 0x040133BD RID: 78781
		private static IntPtr ___13_罗伊白天_NativeFunctionPtr;

		// Token: 0x040133BE RID: 78782
		private static IntPtr ___24_不渲染BP_Cloud控制的云_NativeFunctionPtr;

		// Token: 0x040133BF RID: 78783
		private static IntPtr ___12_梵高_NativeFunctionPtr;

		// Token: 0x040133C0 RID: 78784
		private static IntPtr ___11_拉海洛阴天_NativeFunctionPtr;

		// Token: 0x040133C1 RID: 78785
		private static IntPtr ___10_浮光林夜晚_NativeFunctionPtr;

		// Token: 0x040133C2 RID: 78786
		private static IntPtr ___09_浮光林白天_NativeFunctionPtr;

		// Token: 0x040133C3 RID: 78787
		private static IntPtr ___08_炉芯领主_NativeFunctionPtr;

		// Token: 0x040133C4 RID: 78788
		private static IntPtr ___07_炉芯内部_NativeFunctionPtr;

		// Token: 0x040133C5 RID: 78789
		private static IntPtr ___06_坠落炉芯_NativeFunctionPtr;

		// Token: 0x040133C6 RID: 78790
		private static IntPtr ___05_星门Boss_NativeFunctionPtr;

		// Token: 0x040133C7 RID: 78791
		private static IntPtr ___04_磁暴后置_NativeFunctionPtr;

		// Token: 0x040133C8 RID: 78792
		private static IntPtr ___03_磁暴前置_NativeFunctionPtr;

		// Token: 0x040133C9 RID: 78793
		private static IntPtr ___02_拉海洛夜晚_NativeFunctionPtr;

		// Token: 0x040133CA RID: 78794
		private static IntPtr ___01_拉海落白天_NativeFunctionPtr;

		// Token: 0x040133CB RID: 78795
		private static IntPtr ___23_安全点夜晚_NativeFunctionPtr;

		// Token: 0x040133CC RID: 78796
		private static IntPtr ___22_安全点白天_NativeFunctionPtr;

		// Token: 0x040133CD RID: 78797
		private static IntPtr ___23_穗波阴天_NativeFunctionPtr;

		// Token: 0x040133CE RID: 78798
		private static IntPtr ___22_穗波枯山水_NativeFunctionPtr;

		// Token: 0x040133CF RID: 78799
		private static IntPtr ___21_穗波夜晚_NativeFunctionPtr;

		// Token: 0x040133D0 RID: 78800
		private static IntPtr ___20_穗波白天_NativeFunctionPtr;

		// Token: 0x040133D1 RID: 78801
		private static IntPtr ___21_总督日月同辉_NativeFunctionPtr;

		// Token: 0x040133D2 RID: 78802
		private static IntPtr ___21_烈阳天气_NativeFunctionPtr;

		// Token: 0x040133D3 RID: 78803
		private static IntPtr ___20_黑潮风暴加强_NativeFunctionPtr;

		// Token: 0x040133D4 RID: 78804
		private static IntPtr ___19_黑潮风暴_NativeFunctionPtr;

		// Token: 0x040133D5 RID: 78805
		private static IntPtr ___18_失亡彼岸_NativeFunctionPtr;

		// Token: 0x040133D6 RID: 78806
		private static IntPtr ___17_隐海试验场_NativeFunctionPtr;

		// Token: 0x040133D7 RID: 78807
		private static IntPtr ___16_巡游天国_NativeFunctionPtr;

		// Token: 0x040133D8 RID: 78808
		private static IntPtr ___15_光路幻境_NativeFunctionPtr;

		// Token: 0x040133D9 RID: 78809
		private static IntPtr ___14_黑潮内里世界_NativeFunctionPtr;

		// Token: 0x040133DA RID: 78810
		private static IntPtr ___13_黑潮内表世界_NativeFunctionPtr;

		// Token: 0x040133DB RID: 78811
		private static IntPtr ___12_黑潮侵蚀_NativeFunctionPtr;

		// Token: 0x040133DC RID: 78812
		private static IntPtr ___19_狄斯台地月相_NativeFunctionPtr;

		// Token: 0x040133DD RID: 78813
		private static IntPtr ___18_狄斯台地受蚀地_NativeFunctionPtr;

		// Token: 0x040133DE RID: 78814
		private static IntPtr ___17_狄斯台地烈日天空_NativeFunctionPtr;

		// Token: 0x040133DF RID: 78815
		private static IntPtr ___16_狄斯台地日月同辉_NativeFunctionPtr;

		// Token: 0x040133E0 RID: 78816
		private static IntPtr ___15_狄斯台地夜晚_NativeFunctionPtr;

		// Token: 0x040133E1 RID: 78817
		private static IntPtr ___14_狄斯台地白天_NativeFunctionPtr;

		// Token: 0x040133E2 RID: 78818
		private static IntPtr ___13_七丘夜晚_NativeFunctionPtr;

		// Token: 0x040133E3 RID: 78819
		private static IntPtr ___12_观测塔_NativeFunctionPtr;

		// Token: 0x040133E4 RID: 78820
		private static IntPtr ___11_尖刺山_NativeFunctionPtr;

		// Token: 0x040133E5 RID: 78821
		private static IntPtr ___10_残破竞技场_NativeFunctionPtr;

		// Token: 0x040133E6 RID: 78822
		private static IntPtr ___09_七丘阴天_NativeFunctionPtr;

		// Token: 0x040133E7 RID: 78823
		private static IntPtr ___08_初见七丘_NativeFunctionPtr;

		// Token: 0x040133E8 RID: 78824
		private static IntPtr ___07_七丘_NativeFunctionPtr;

		// Token: 0x040133E9 RID: 78825
		private static IntPtr ___11_颠倒塔流星_NativeFunctionPtr;

		// Token: 0x040133EA RID: 78826
		private static IntPtr ___10_颠倒塔夜晚_NativeFunctionPtr;

		// Token: 0x040133EB RID: 78827
		private static IntPtr ___09_颠倒塔白天_NativeFunctionPtr;

		// Token: 0x040133EC RID: 78828
		private static IntPtr ___08_彩虹天气_NativeFunctionPtr;

		// Token: 0x040133ED RID: 78829
		private static IntPtr __CloudMainParamsUpdate_NativeFunctionPtr;

		// Token: 0x040133EE RID: 78830
		private static IntPtr ___07_费洛洛出场_NativeFunctionPtr;

		// Token: 0x040133EF RID: 78831
		private static IntPtr ___06_金库上解密后_NativeFunctionPtr;

		// Token: 0x040133F0 RID: 78832
		private static IntPtr ___05_罗墓岛夜晚_NativeFunctionPtr;

		// Token: 0x040133F1 RID: 78833
		private static IntPtr ___06_黎娜夕塔阴_NativeFunctionPtr;

		// Token: 0x040133F2 RID: 78834
		private static IntPtr ___04_云海区_NativeFunctionPtr;

		// Token: 0x040133F3 RID: 78835
		private static IntPtr ___03_槲生半岛解密后_NativeFunctionPtr;

		// Token: 0x040133F4 RID: 78836
		private static IntPtr ___05_狂欢节_NativeFunctionPtr;

		// Token: 0x040133F5 RID: 78837
		private static IntPtr __显示云移动范围_NativeFunctionPtr;

		// Token: 0x040133F6 RID: 78838
		private static IntPtr __关闭云跟随摄像机移动_NativeFunctionPtr;

		// Token: 0x040133F7 RID: 78839
		private static IntPtr __开启云跟随摄像机移动_NativeFunctionPtr;

		// Token: 0x040133F8 RID: 78840
		private static IntPtr ___04_金库上层_NativeFunctionPtr;

		// Token: 0x040133F9 RID: 78841
		private static IntPtr ___03_狄萨莱海脊永夜解密后_NativeFunctionPtr;

		// Token: 0x040133FA RID: 78842
		private static IntPtr ___02_狄萨莱海脊永夜解密前_NativeFunctionPtr;

		// Token: 0x040133FB RID: 78843
		private static IntPtr ___01_槲生半岛_NativeFunctionPtr;

		// Token: 0x040133FC RID: 78844
		private static IntPtr ___02_帕尔米罗墓地_NativeFunctionPtr;

		// Token: 0x040133FD RID: 78845
		private static IntPtr ___01_黎娜汐塔_NativeFunctionPtr;

		// Token: 0x040133FE RID: 78846
		private static IntPtr ___020黑海岸天气_阴_NativeFunctionPtr;

		// Token: 0x040133FF RID: 78847
		private static IntPtr ___019肉鸽月亮05_NativeFunctionPtr;

		// Token: 0x04013400 RID: 78848
		private static IntPtr ___018肉鸽月亮04_NativeFunctionPtr;

		// Token: 0x04013401 RID: 78849
		private static IntPtr ___017肉鸽月亮03_NativeFunctionPtr;

		// Token: 0x04013402 RID: 78850
		private static IntPtr ___016肉鸽月亮02_NativeFunctionPtr;

		// Token: 0x04013403 RID: 78851
		private static IntPtr ___015肉鸽月亮01_NativeFunctionPtr;

		// Token: 0x04013404 RID: 78852
		private static IntPtr ___014黑海岸夜晚_NativeFunctionPtr;

		// Token: 0x04013405 RID: 78853
		private static IntPtr ___08黑海岸下层_NativeFunctionPtr;

		// Token: 0x04013406 RID: 78854
		private static IntPtr ___07黑海岸上层_NativeFunctionPtr;

		// Token: 0x04013407 RID: 78855
		private static IntPtr __Get_GIParams_NativeFunctionPtr;

		// Token: 0x04013408 RID: 78856
		private static IntPtr ___06乘宵山_NativeFunctionPtr;

		// Token: 0x04013409 RID: 78857
		private static IntPtr ___05怨鸟泽_NativeFunctionPtr;

		// Token: 0x0401340A RID: 78858
		private static IntPtr ___013乘宵山异象_NativeFunctionPtr;

		// Token: 0x0401340B RID: 78859
		private static IntPtr ___012夜晚异象_NativeFunctionPtr;

		// Token: 0x0401340C RID: 78860
		private static IntPtr ___011黄昏异象_NativeFunctionPtr;

		// Token: 0x0401340D RID: 78861
		private static IntPtr ___010阴天异象_NativeFunctionPtr;

		// Token: 0x0401340E RID: 78862
		private static IntPtr ___09鸣潮天气_NativeFunctionPtr;

		// Token: 0x0401340F RID: 78863
		private static IntPtr ___08漩涡云01_NativeFunctionPtr;

		// Token: 0x04013410 RID: 78864
		private static IntPtr ___07无音区05_NativeFunctionPtr;

		// Token: 0x04013411 RID: 78865
		private static IntPtr ___06无音区04_NativeFunctionPtr;

		// Token: 0x04013412 RID: 78866
		private static IntPtr ___05无音区03_NativeFunctionPtr;

		// Token: 0x04013413 RID: 78867
		private static IntPtr ___04无音区02_NativeFunctionPtr;

		// Token: 0x04013414 RID: 78868
		private static IntPtr __原画测试用云_NativeFunctionPtr;

		// Token: 0x04013415 RID: 78869
		private static IntPtr __SetCloudParameters_NativeFunctionPtr;

		// Token: 0x04013416 RID: 78870
		private static IntPtr ___04中曲台地_NativeFunctionPtr;

		// Token: 0x04013417 RID: 78871
		private static IntPtr __Hidden_Old_NativeFunctionPtr;

		// Token: 0x04013418 RID: 78872
		private static IntPtr ___03无音区01_NativeFunctionPtr;

		// Token: 0x04013419 RID: 78873
		private static IntPtr ___02无音区沉寂态_NativeFunctionPtr;

		// Token: 0x0401341A RID: 78874
		private static IntPtr ___01登录界面_NativeFunctionPtr;

		// Token: 0x0401341B RID: 78875
		private static IntPtr ___03无光之森_NativeFunctionPtr;

		// Token: 0x0401341C RID: 78876
		private static IntPtr ___02遗落原乡_NativeFunctionPtr;

		// Token: 0x0401341D RID: 78877
		private static IntPtr ___01天城_NativeFunctionPtr;

		// Token: 0x0401341E RID: 78878
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0401341F RID: 78879
		private static IntPtr __OnLoaded_63FE5E2B437AFAD504FBCAB26242EB8A_NativeFunctionPtr;

		// Token: 0x04013420 RID: 78880
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04013421 RID: 78881
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04013422 RID: 78882
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x04013423 RID: 78883
		private static IntPtr __ChangeCloud_NativeFunctionPtr;

		// Token: 0x04013424 RID: 78884
		private static IntPtr __Switch_Clouds_NativeFunctionPtr;

		// Token: 0x04013425 RID: 78885
		private static IntPtr __LoadAndSwitch_NativeFunctionPtr;

		// Token: 0x0200A0FE RID: 41214
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __SwitchCloudsSub_FunctionParams
		{
			// Token: 0x04031C57 RID: 203863
			[FieldOffset(0)]
			public IntPtr CloudPresents;

			// Token: 0x04031C58 RID: 203864
			[FieldOffset(8)]
			public float ChangeSpeed;

			// Token: 0x04031C59 RID: 203865
			[FieldOffset(12)]
			public bool InstantHide;
		}

		// Token: 0x0200A0FF RID: 41215
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __Get_GIParams_FunctionParams
		{
			// Token: 0x04031C5A RID: 203866
			[FieldOffset(0)]
			public float CurTime;
		}

		// Token: 0x0200A100 RID: 41216
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __SetCloudParameters_FunctionParams
		{
			// Token: 0x04031C5B RID: 203867
			[FieldOffset(0)]
			public IntPtr CloudPrefeb;

			// Token: 0x04031C5C RID: 203868
			[FieldOffset(8)]
			public IntPtr CloudActorComponent;

			// Token: 0x04031C5D RID: 203869
			[FieldOffset(16)]
			public float ChangeSpeed;

			// Token: 0x04031C5E RID: 203870
			[FieldOffset(20)]
			public int TransSortNumber;

			// Token: 0x04031C5F RID: 203871
			[FieldOffset(24)]
			public bool bInstantHide;
		}

		// Token: 0x0200A101 RID: 41217
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __OnLoaded_63FE5E2B437AFAD504FBCAB26242EB8A_FunctionParams
		{
			// Token: 0x04031C60 RID: 203872
			[FieldOffset(0)]
			public IntPtr Loaded;
		}

		// Token: 0x0200A102 RID: 41218
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031C61 RID: 203873
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x0200A103 RID: 41219
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x04031C62 RID: 203874
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x0200A104 RID: 41220
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __Switch_Clouds_FunctionParams
		{
			// Token: 0x04031C63 RID: 203875
			[FieldOffset(0)]
			public TEnumAsByte<E_Cloud_Presents> CloudPresents;

			// Token: 0x04031C64 RID: 203876
			[FieldOffset(4)]
			public float ChangeSpeed;

			// Token: 0x04031C65 RID: 203877
			[FieldOffset(8)]
			public bool IsInEditor;

			// Token: 0x04031C66 RID: 203878
			[FieldOffset(9)]
			public bool bOverrideCloudRotation;

			// Token: 0x04031C67 RID: 203879
			[FieldOffset(12)]
			public float CloudSpeed;

			// Token: 0x04031C68 RID: 203880
			[FieldOffset(16)]
			public float CloudOffset;

			// Token: 0x04031C69 RID: 203881
			[FieldOffset(20)]
			public bool ControlSeqCloud;

			// Token: 0x04031C6A RID: 203882
			[FieldOffset(21)]
			public bool InstantHide;
		}

		// Token: 0x0200A105 RID: 41221
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __LoadAndSwitch_FunctionParams
		{
			// Token: 0x04031C6B RID: 203883
			[FieldOffset(0)]
			public byte Asset;

			// Token: 0x04031C6C RID: 203884
			[FieldOffset(48)]
			public float ChangeSpeed;

			// Token: 0x04031C6D RID: 203885
			[FieldOffset(52)]
			public bool IsInEditor;

			// Token: 0x04031C6E RID: 203886
			[FieldOffset(53)]
			public bool IsAudio;

			// Token: 0x04031C6F RID: 203887
			[FieldOffset(54)]
			public bool InstantHide;
		}
	}
}

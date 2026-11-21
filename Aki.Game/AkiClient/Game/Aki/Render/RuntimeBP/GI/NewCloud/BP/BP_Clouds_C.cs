using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.GI.NewCloud.BP
{
	// Token: 0x020030FA RID: 12538
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/GI/NewCloud/BP/BP_Clouds.BP_Clouds_C")]
	[UnrealStructLayout(1624, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1622)]
	public class BP_Clouds_C : AKuroCloudsActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601E940 RID: 125248 RVA: 0x00917913 File Offset: 0x00915B13
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_Clouds_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/GI/NewCloud/BP/BP_Clouds.BP_Clouds_C");
			}
			return BP_Clouds_C._ClassPtr;
		}

		// Token: 0x0601E941 RID: 125249 RVA: 0x00917938 File Offset: 0x00915B38
		public BP_Clouds_C() : this(BuiltinUtils.AllocNativeUObject(BP_Clouds_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601E942 RID: 125250 RVA: 0x00917960 File Offset: 0x00915B60
		[NullableContext(1)]
		public BP_Clouds_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_Clouds_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700349C RID: 13468
		// (get) Token: 0x0601E943 RID: 125251 RVA: 0x00917993 File Offset: 0x00915B93
		// (set) Token: 0x0601E944 RID: 125252 RVA: 0x009179A7 File Offset: 0x00915BA7
		public unsafe UChildActorComponent Cloud02
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Clouds_C.__PropertyOffset_Cloud02);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Clouds_C.__PropertyOffset_Cloud02, value);
			}
		}

		// Token: 0x1700349D RID: 13469
		// (get) Token: 0x0601E945 RID: 125253 RVA: 0x009179BC File Offset: 0x00915BBC
		// (set) Token: 0x0601E946 RID: 125254 RVA: 0x009179D0 File Offset: 0x00915BD0
		public unsafe UChildActorComponent Cloud01
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Clouds_C.__PropertyOffset_Cloud01);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Clouds_C.__PropertyOffset_Cloud01, value);
			}
		}

		// Token: 0x1700349E RID: 13470
		// (get) Token: 0x0601E947 RID: 125255 RVA: 0x009179E5 File Offset: 0x00915BE5
		// (set) Token: 0x0601E948 RID: 125256 RVA: 0x009179F9 File Offset: 0x00915BF9
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Clouds_C.__PropertyOffset_DefaultSceneRoot);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Clouds_C.__PropertyOffset_DefaultSceneRoot, value);
			}
		}

		// Token: 0x1700349F RID: 13471
		// (get) Token: 0x0601E949 RID: 125257 RVA: 0x00917A0E File Offset: 0x00915C0E
		// (set) Token: 0x0601E94A RID: 125258 RVA: 0x00917A1E File Offset: 0x00915C1E
		public unsafe bool Counting
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Clouds_C.__PropertyOffset_Counting) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Clouds_C.__PropertyOffset_Counting) = (value ? 1 : 0);
			}
		}

		// Token: 0x170034A0 RID: 13472
		// (get) Token: 0x0601E94B RID: 125259 RVA: 0x00917A30 File Offset: 0x00915C30
		// (set) Token: 0x0601E94C RID: 125260 RVA: 0x00917A69 File Offset: 0x00915C69
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
					result = (this._SortNumber = new TArray<int>(base.NativePtr + (IntPtr)BP_Clouds_C.__PropertyOffset_SortNumber, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.SortNumber.CopyAssign(value);
			}
		}

		// Token: 0x170034A1 RID: 13473
		// (get) Token: 0x0601E94D RID: 125261 RVA: 0x00917A77 File Offset: 0x00915C77
		// (set) Token: 0x0601E94E RID: 125262 RVA: 0x00917A8B File Offset: 0x00915C8B
		public unsafe UAkAudioEvent CachedAudioEvent2D
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkAudioEvent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Clouds_C.__PropertyOffset_CachedAudioEvent2D);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Clouds_C.__PropertyOffset_CachedAudioEvent2D, value);
			}
		}

		// Token: 0x170034A2 RID: 13474
		// (get) Token: 0x0601E94F RID: 125263 RVA: 0x00917AA0 File Offset: 0x00915CA0
		// (set) Token: 0x0601E950 RID: 125264 RVA: 0x00917AB0 File Offset: 0x00915CB0
		public unsafe bool IsSkyOcean
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Clouds_C.__PropertyOffset_IsSkyOcean) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Clouds_C.__PropertyOffset_IsSkyOcean) = (value ? 1 : 0);
			}
		}

		// Token: 0x170034A3 RID: 13475
		// (get) Token: 0x0601E951 RID: 125265 RVA: 0x00917AC1 File Offset: 0x00915CC1
		// (set) Token: 0x0601E952 RID: 125266 RVA: 0x00917AD5 File Offset: 0x00915CD5
		public unsafe UAkAudioEvent SkyOceanAudio
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkAudioEvent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Clouds_C.__PropertyOffset_SkyOceanAudio);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Clouds_C.__PropertyOffset_SkyOceanAudio, value);
			}
		}

		// Token: 0x170034A4 RID: 13476
		// (get) Token: 0x0601E953 RID: 125267 RVA: 0x00917AEA File Offset: 0x00915CEA
		// (set) Token: 0x0601E954 RID: 125268 RVA: 0x00917AFA File Offset: 0x00915CFA
		public unsafe bool Override_Cloud_Rotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Clouds_C.__PropertyOffset_Override_Cloud_Rotation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Clouds_C.__PropertyOffset_Override_Cloud_Rotation) = (value ? 1 : 0);
			}
		}

		// Token: 0x170034A5 RID: 13477
		// (get) Token: 0x0601E955 RID: 125269 RVA: 0x00917B0B File Offset: 0x00915D0B
		// (set) Token: 0x0601E956 RID: 125270 RVA: 0x00917B1B File Offset: 0x00915D1B
		public unsafe float Cloud_Speed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Clouds_C.__PropertyOffset_Cloud_Speed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Clouds_C.__PropertyOffset_Cloud_Speed) = value;
			}
		}

		// Token: 0x170034A6 RID: 13478
		// (get) Token: 0x0601E957 RID: 125271 RVA: 0x00917B2C File Offset: 0x00915D2C
		// (set) Token: 0x0601E958 RID: 125272 RVA: 0x00917B3C File Offset: 0x00915D3C
		public unsafe float Cloud_Offset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Clouds_C.__PropertyOffset_Cloud_Offset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Clouds_C.__PropertyOffset_Cloud_Offset) = value;
			}
		}

		// Token: 0x170034A7 RID: 13479
		// (get) Token: 0x0601E959 RID: 125273 RVA: 0x00917B4D File Offset: 0x00915D4D
		// (set) Token: 0x0601E95A RID: 125274 RVA: 0x00917B5D File Offset: 0x00915D5D
		public unsafe bool IsReversed_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Clouds_C.__PropertyOffset_IsReversed_) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Clouds_C.__PropertyOffset_IsReversed_) = (value ? 1 : 0);
			}
		}

		// Token: 0x170034A8 RID: 13480
		// (get) Token: 0x0601E95B RID: 125275 RVA: 0x00917B6E File Offset: 0x00915D6E
		// (set) Token: 0x0601E95C RID: 125276 RVA: 0x00917B7E File Offset: 0x00915D7E
		public unsafe float ReversedZHeightBias
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Clouds_C.__PropertyOffset_ReversedZHeightBias);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Clouds_C.__PropertyOffset_ReversedZHeightBias) = value;
			}
		}

		// Token: 0x170034A9 RID: 13481
		// (get) Token: 0x0601E95D RID: 125277 RVA: 0x00917B8F File Offset: 0x00915D8F
		// (set) Token: 0x0601E95E RID: 125278 RVA: 0x00917B9F File Offset: 0x00915D9F
		public unsafe KuroFeatureLevel FeatureLevel
		{
			get
			{
				return (KuroFeatureLevel)(*(base.NativePtr + (IntPtr)BP_Clouds_C.__PropertyOffset_FeatureLevel));
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Clouds_C.__PropertyOffset_FeatureLevel) = (byte)value;
			}
		}

		// Token: 0x170034AA RID: 13482
		// (get) Token: 0x0601E95F RID: 125279 RVA: 0x00917BB0 File Offset: 0x00915DB0
		// (set) Token: 0x0601E960 RID: 125280 RVA: 0x00917BC0 File Offset: 0x00915DC0
		public unsafe bool IsHiddenClouds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Clouds_C.__PropertyOffset_IsHiddenClouds) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Clouds_C.__PropertyOffset_IsHiddenClouds) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601E961 RID: 125281 RVA: 0x00917BD1 File Offset: 0x00915DD1
		[SkipLocalsInit]
		public virtual void _11_水母天空()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___11_水母天空_NativeFunctionPtr, null);
		}

		// Token: 0x0601E962 RID: 125282 RVA: 0x00917BE5 File Offset: 0x00915DE5
		[SkipLocalsInit]
		public virtual void _10_裂缝天空()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___10_裂缝天空_NativeFunctionPtr, null);
		}

		// Token: 0x0601E963 RID: 125283 RVA: 0x00917BF9 File Offset: 0x00915DF9
		[SkipLocalsInit]
		public virtual void _09_新联邦阴天()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___09_新联邦阴天_NativeFunctionPtr, null);
		}

		// Token: 0x0601E964 RID: 125284 RVA: 0x00917C0D File Offset: 0x00915E0D
		[SkipLocalsInit]
		public virtual void _08_龙卷风()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___08_龙卷风_NativeFunctionPtr, null);
		}

		// Token: 0x0601E965 RID: 125285 RVA: 0x00917C21 File Offset: 0x00915E21
		[SkipLocalsInit]
		public virtual void _07_局部暴流()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___07_局部暴流_NativeFunctionPtr, null);
		}

		// Token: 0x0601E966 RID: 125286 RVA: 0x00917C35 File Offset: 0x00915E35
		[SkipLocalsInit]
		public virtual void _06_暴雨季夜晚()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___06_暴雨季夜晚_NativeFunctionPtr, null);
		}

		// Token: 0x0601E967 RID: 125287 RVA: 0x00917C49 File Offset: 0x00915E49
		[SkipLocalsInit]
		public virtual void _05_暴雨季白天()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___05_暴雨季白天_NativeFunctionPtr, null);
		}

		// Token: 0x0601E968 RID: 125288 RVA: 0x00917C5D File Offset: 0x00915E5D
		[SkipLocalsInit]
		public virtual void _04_丰水季夜晚()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___04_丰水季夜晚_NativeFunctionPtr, null);
		}

		// Token: 0x0601E969 RID: 125289 RVA: 0x00917C71 File Offset: 0x00915E71
		[SkipLocalsInit]
		public virtual void _03_丰水季白天()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___03_丰水季白天_NativeFunctionPtr, null);
		}

		// Token: 0x0601E96A RID: 125290 RVA: 0x00917C85 File Offset: 0x00915E85
		[SkipLocalsInit]
		public virtual void _02_枯水季夜晚()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___02_枯水季夜晚_NativeFunctionPtr, null);
		}

		// Token: 0x0601E96B RID: 125291 RVA: 0x00917C99 File Offset: 0x00915E99
		[SkipLocalsInit]
		public virtual void _01_枯水季白天()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___01_枯水季白天_NativeFunctionPtr, null);
		}

		// Token: 0x0601E96C RID: 125292 RVA: 0x00917CAD File Offset: 0x00915EAD
		[SkipLocalsInit]
		public virtual void _45_梦境列车星空云()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___45_梦境列车星空云_NativeFunctionPtr, null);
		}

		// Token: 0x0601E96D RID: 125293 RVA: 0x00917CC1 File Offset: 0x00915EC1
		[SkipLocalsInit]
		public virtual void _44_梦境列车星空()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___44_梦境列车星空_NativeFunctionPtr, null);
		}

		// Token: 0x0601E96E RID: 125294 RVA: 0x00917CD5 File Offset: 0x00915ED5
		[SkipLocalsInit]
		public virtual void _43_梦境列车阴天()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___43_梦境列车阴天_NativeFunctionPtr, null);
		}

		// Token: 0x0601E96F RID: 125295 RVA: 0x00917CE9 File Offset: 0x00915EE9
		[SkipLocalsInit]
		public virtual void _42_梦境列车晴天()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___42_梦境列车晴天_NativeFunctionPtr, null);
		}

		// Token: 0x0601E970 RID: 125296 RVA: 0x00917CFD File Offset: 0x00915EFD
		[SkipLocalsInit]
		public virtual void _41_金匣冷调()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___41_金匣冷调_NativeFunctionPtr, null);
		}

		// Token: 0x0601E971 RID: 125297 RVA: 0x00917D11 File Offset: 0x00915F11
		[SkipLocalsInit]
		public virtual void _40_天演幻心二阶段()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___40_天演幻心二阶段_NativeFunctionPtr, null);
		}

		// Token: 0x0601E972 RID: 125298 RVA: 0x00917D25 File Offset: 0x00915F25
		[SkipLocalsInit]
		public virtual void _39_天演幻心()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___39_天演幻心_NativeFunctionPtr, null);
		}

		// Token: 0x0601E973 RID: 125299 RVA: 0x00917D39 File Offset: 0x00915F39
		[SkipLocalsInit]
		public virtual void _38_金匣()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___38_金匣_NativeFunctionPtr, null);
		}

		// Token: 0x0601E974 RID: 125300 RVA: 0x00917D4D File Offset: 0x00915F4D
		[SkipLocalsInit]
		public virtual void _37_水匣()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___37_水匣_NativeFunctionPtr, null);
		}

		// Token: 0x0601E975 RID: 125301 RVA: 0x00917D61 File Offset: 0x00915F61
		[SkipLocalsInit]
		public virtual void _36_火匣()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___36_火匣_NativeFunctionPtr, null);
		}

		// Token: 0x0601E976 RID: 125302 RVA: 0x00917D75 File Offset: 0x00915F75
		[SkipLocalsInit]
		public virtual void _35_心湖()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___35_心湖_NativeFunctionPtr, null);
		}

		// Token: 0x0601E977 RID: 125303 RVA: 0x00917D89 File Offset: 0x00915F89
		[SkipLocalsInit]
		public virtual void _34_天境()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___34_天境_NativeFunctionPtr, null);
		}

		// Token: 0x0601E978 RID: 125304 RVA: 0x00917D9D File Offset: 0x00915F9D
		[SkipLocalsInit]
		public virtual void _33_地境()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___33_地境_NativeFunctionPtr, null);
		}

		// Token: 0x0601E979 RID: 125305 RVA: 0x00917DB1 File Offset: 0x00915FB1
		[SkipLocalsInit]
		public virtual void _32_人境()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___32_人境_NativeFunctionPtr, null);
		}

		// Token: 0x0601E97A RID: 125306 RVA: 0x00917DC5 File Offset: 0x00915FC5
		[SkipLocalsInit]
		public virtual void _31_梦州特殊2()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___31_梦州特殊2_NativeFunctionPtr, null);
		}

		// Token: 0x0601E97B RID: 125307 RVA: 0x00917DD9 File Offset: 0x00915FD9
		[SkipLocalsInit]
		public virtual void _30_梦州特殊1()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___30_梦州特殊1_NativeFunctionPtr, null);
		}

		// Token: 0x0601E97C RID: 125308 RVA: 0x00917DED File Offset: 0x00915FED
		[SkipLocalsInit]
		public virtual void _29_宅邸解谜后()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___29_宅邸解谜后_NativeFunctionPtr, null);
		}

		// Token: 0x0601E97D RID: 125309 RVA: 0x00917E01 File Offset: 0x00916001
		[SkipLocalsInit]
		public virtual void _28_宅邸解谜前()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___28_宅邸解谜前_NativeFunctionPtr, null);
		}

		// Token: 0x0601E97E RID: 125310 RVA: 0x00917E15 File Offset: 0x00916015
		[SkipLocalsInit]
		public virtual void _27_梦州初见()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___27_梦州初见_NativeFunctionPtr, null);
		}

		// Token: 0x0601E97F RID: 125311 RVA: 0x00917E29 File Offset: 0x00916029
		[SkipLocalsInit]
		public virtual void _26_梦州阴天()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___26_梦州阴天_NativeFunctionPtr, null);
		}

		// Token: 0x0601E980 RID: 125312 RVA: 0x00917E3D File Offset: 0x0091603D
		[SkipLocalsInit]
		public virtual void _25_梦州夜晚()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___25_梦州夜晚_NativeFunctionPtr, null);
		}

		// Token: 0x0601E981 RID: 125313 RVA: 0x00917E51 File Offset: 0x00916051
		[SkipLocalsInit]
		public virtual void _24_梦州白天()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___24_梦州白天_NativeFunctionPtr, null);
		}

		// Token: 0x0601E982 RID: 125314 RVA: 0x00917E65 File Offset: 0x00916065
		[SkipLocalsInit]
		public virtual void _23_高达Boss三阶()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___23_高达Boss三阶_NativeFunctionPtr, null);
		}

		// Token: 0x0601E983 RID: 125315 RVA: 0x00917E79 File Offset: 0x00916079
		[SkipLocalsInit]
		public virtual void _22_高达Boss一阶()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___22_高达Boss一阶_NativeFunctionPtr, null);
		}

		// Token: 0x0601E984 RID: 125316 RVA: 0x00917E8D File Offset: 0x0091608D
		[SkipLocalsInit]
		public virtual void _21_日灵棺解密后()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___21_日灵棺解密后_NativeFunctionPtr, null);
		}

		// Token: 0x0601E985 RID: 125317 RVA: 0x00917EA1 File Offset: 0x009160A1
		[SkipLocalsInit]
		public virtual void _20_日灵棺解密前()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___20_日灵棺解密前_NativeFunctionPtr, null);
		}

		// Token: 0x0601E986 RID: 125318 RVA: 0x00917EB5 File Offset: 0x009160B5
		[SkipLocalsInit]
		public virtual void _19_拉海洛初见()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___19_拉海洛初见_NativeFunctionPtr, null);
		}

		// Token: 0x0601E987 RID: 125319 RVA: 0x00917EC9 File Offset: 0x009160C9
		[SkipLocalsInit]
		public virtual void _18_星海BOSS三阶()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___18_星海BOSS三阶_NativeFunctionPtr, null);
		}

		// Token: 0x0601E988 RID: 125320 RVA: 0x00917EDD File Offset: 0x009160DD
		[SkipLocalsInit]
		public virtual void _17_星海BOSS一阶()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___17_星海BOSS一阶_NativeFunctionPtr, null);
		}

		// Token: 0x0601E989 RID: 125321 RVA: 0x00917EF1 File Offset: 0x009160F1
		[SkipLocalsInit]
		public virtual void _16_罗伊初见()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___16_罗伊初见_NativeFunctionPtr, null);
		}

		// Token: 0x0601E98A RID: 125322 RVA: 0x00917F05 File Offset: 0x00916105
		[SkipLocalsInit]
		public virtual void _15_罗伊极光()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___15_罗伊极光_NativeFunctionPtr, null);
		}

		// Token: 0x0601E98B RID: 125323 RVA: 0x00917F19 File Offset: 0x00916119
		[SkipLocalsInit]
		public virtual void _14_罗伊夜晚()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___14_罗伊夜晚_NativeFunctionPtr, null);
		}

		// Token: 0x0601E98C RID: 125324 RVA: 0x00917F2D File Offset: 0x0091612D
		[SkipLocalsInit]
		public virtual void _13_罗伊白天()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___13_罗伊白天_NativeFunctionPtr, null);
		}

		// Token: 0x0601E98D RID: 125325 RVA: 0x00917F41 File Offset: 0x00916141
		[SkipLocalsInit]
		public virtual void _24_不渲染BP_Cloud控制的云()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___24_不渲染BP_Cloud控制的云_NativeFunctionPtr, null);
		}

		// Token: 0x0601E98E RID: 125326 RVA: 0x00917F55 File Offset: 0x00916155
		[SkipLocalsInit]
		public virtual void _12_梵高()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___12_梵高_NativeFunctionPtr, null);
		}

		// Token: 0x0601E98F RID: 125327 RVA: 0x00917F69 File Offset: 0x00916169
		[SkipLocalsInit]
		public virtual void _11_拉海洛阴天()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___11_拉海洛阴天_NativeFunctionPtr, null);
		}

		// Token: 0x0601E990 RID: 125328 RVA: 0x00917F7D File Offset: 0x0091617D
		[SkipLocalsInit]
		public virtual void _10_浮光林夜晚()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___10_浮光林夜晚_NativeFunctionPtr, null);
		}

		// Token: 0x0601E991 RID: 125329 RVA: 0x00917F91 File Offset: 0x00916191
		[SkipLocalsInit]
		public virtual void _09_浮光林白天()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___09_浮光林白天_NativeFunctionPtr, null);
		}

		// Token: 0x0601E992 RID: 125330 RVA: 0x00917FA5 File Offset: 0x009161A5
		[SkipLocalsInit]
		public virtual void _08_炉芯领主()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___08_炉芯领主_NativeFunctionPtr, null);
		}

		// Token: 0x0601E993 RID: 125331 RVA: 0x00917FB9 File Offset: 0x009161B9
		[SkipLocalsInit]
		public virtual void _07_炉芯内部()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___07_炉芯内部_NativeFunctionPtr, null);
		}

		// Token: 0x0601E994 RID: 125332 RVA: 0x00917FCD File Offset: 0x009161CD
		[SkipLocalsInit]
		public virtual void _06_坠落炉芯()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___06_坠落炉芯_NativeFunctionPtr, null);
		}

		// Token: 0x0601E995 RID: 125333 RVA: 0x00917FE1 File Offset: 0x009161E1
		[SkipLocalsInit]
		public virtual void _05_星门Boss()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___05_星门Boss_NativeFunctionPtr, null);
		}

		// Token: 0x0601E996 RID: 125334 RVA: 0x00917FF5 File Offset: 0x009161F5
		[SkipLocalsInit]
		public virtual void _04_磁暴后置()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___04_磁暴后置_NativeFunctionPtr, null);
		}

		// Token: 0x0601E997 RID: 125335 RVA: 0x00918009 File Offset: 0x00916209
		[SkipLocalsInit]
		public virtual void _03_磁暴前置()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___03_磁暴前置_NativeFunctionPtr, null);
		}

		// Token: 0x0601E998 RID: 125336 RVA: 0x0091801D File Offset: 0x0091621D
		[SkipLocalsInit]
		public virtual void _02_拉海洛夜晚()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___02_拉海洛夜晚_NativeFunctionPtr, null);
		}

		// Token: 0x0601E999 RID: 125337 RVA: 0x00918031 File Offset: 0x00916231
		[SkipLocalsInit]
		public virtual void _01_拉海落白天()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___01_拉海落白天_NativeFunctionPtr, null);
		}

		// Token: 0x0601E99A RID: 125338 RVA: 0x00918045 File Offset: 0x00916245
		[SkipLocalsInit]
		public virtual void _23_安全点夜晚()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___23_安全点夜晚_NativeFunctionPtr, null);
		}

		// Token: 0x0601E99B RID: 125339 RVA: 0x00918059 File Offset: 0x00916259
		[SkipLocalsInit]
		public virtual void _22_安全点白天()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___22_安全点白天_NativeFunctionPtr, null);
		}

		// Token: 0x0601E99C RID: 125340 RVA: 0x0091806D File Offset: 0x0091626D
		[SkipLocalsInit]
		public virtual void _23_穗波阴天()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___23_穗波阴天_NativeFunctionPtr, null);
		}

		// Token: 0x0601E99D RID: 125341 RVA: 0x00918081 File Offset: 0x00916281
		[SkipLocalsInit]
		public virtual void _22_穗波枯山水()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___22_穗波枯山水_NativeFunctionPtr, null);
		}

		// Token: 0x0601E99E RID: 125342 RVA: 0x00918095 File Offset: 0x00916295
		[SkipLocalsInit]
		public virtual void _21_穗波夜晚()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___21_穗波夜晚_NativeFunctionPtr, null);
		}

		// Token: 0x0601E99F RID: 125343 RVA: 0x009180A9 File Offset: 0x009162A9
		[SkipLocalsInit]
		public virtual void _20_穗波白天()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___20_穗波白天_NativeFunctionPtr, null);
		}

		// Token: 0x0601E9A0 RID: 125344 RVA: 0x009180BD File Offset: 0x009162BD
		[SkipLocalsInit]
		public virtual void _21_总督日月同辉()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___21_总督日月同辉_NativeFunctionPtr, null);
		}

		// Token: 0x0601E9A1 RID: 125345 RVA: 0x009180D1 File Offset: 0x009162D1
		[SkipLocalsInit]
		public virtual void _21_烈阳天气()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___21_烈阳天气_NativeFunctionPtr, null);
		}

		// Token: 0x0601E9A2 RID: 125346 RVA: 0x009180E5 File Offset: 0x009162E5
		[SkipLocalsInit]
		public virtual void _20_黑潮风暴加强()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___20_黑潮风暴加强_NativeFunctionPtr, null);
		}

		// Token: 0x0601E9A3 RID: 125347 RVA: 0x009180F9 File Offset: 0x009162F9
		[SkipLocalsInit]
		public virtual void _19_黑潮风暴()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___19_黑潮风暴_NativeFunctionPtr, null);
		}

		// Token: 0x0601E9A4 RID: 125348 RVA: 0x0091810D File Offset: 0x0091630D
		[SkipLocalsInit]
		public virtual void _18_失亡彼岸()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___18_失亡彼岸_NativeFunctionPtr, null);
		}

		// Token: 0x0601E9A5 RID: 125349 RVA: 0x00918121 File Offset: 0x00916321
		[SkipLocalsInit]
		public virtual void _17_隐海试验场()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___17_隐海试验场_NativeFunctionPtr, null);
		}

		// Token: 0x0601E9A6 RID: 125350 RVA: 0x00918135 File Offset: 0x00916335
		[SkipLocalsInit]
		public virtual void _16_巡游天国()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___16_巡游天国_NativeFunctionPtr, null);
		}

		// Token: 0x0601E9A7 RID: 125351 RVA: 0x00918149 File Offset: 0x00916349
		[SkipLocalsInit]
		public virtual void _15_光路幻境()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___15_光路幻境_NativeFunctionPtr, null);
		}

		// Token: 0x0601E9A8 RID: 125352 RVA: 0x0091815D File Offset: 0x0091635D
		[SkipLocalsInit]
		public virtual void _14_黑潮内里世界()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___14_黑潮内里世界_NativeFunctionPtr, null);
		}

		// Token: 0x0601E9A9 RID: 125353 RVA: 0x00918171 File Offset: 0x00916371
		[SkipLocalsInit]
		public virtual void _13_黑潮内表世界()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___13_黑潮内表世界_NativeFunctionPtr, null);
		}

		// Token: 0x0601E9AA RID: 125354 RVA: 0x00918185 File Offset: 0x00916385
		[SkipLocalsInit]
		public virtual void _12_黑潮侵蚀()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___12_黑潮侵蚀_NativeFunctionPtr, null);
		}

		// Token: 0x0601E9AB RID: 125355 RVA: 0x00918199 File Offset: 0x00916399
		[SkipLocalsInit]
		public virtual void _19_狄斯台地月相()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___19_狄斯台地月相_NativeFunctionPtr, null);
		}

		// Token: 0x0601E9AC RID: 125356 RVA: 0x009181AD File Offset: 0x009163AD
		[SkipLocalsInit]
		public virtual void _18_狄斯台地受蚀地()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___18_狄斯台地受蚀地_NativeFunctionPtr, null);
		}

		// Token: 0x0601E9AD RID: 125357 RVA: 0x009181C1 File Offset: 0x009163C1
		[SkipLocalsInit]
		public virtual void _17_狄斯台地烈日天空()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___17_狄斯台地烈日天空_NativeFunctionPtr, null);
		}

		// Token: 0x0601E9AE RID: 125358 RVA: 0x009181D5 File Offset: 0x009163D5
		[SkipLocalsInit]
		public virtual void _16_狄斯台地日月同辉()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___16_狄斯台地日月同辉_NativeFunctionPtr, null);
		}

		// Token: 0x0601E9AF RID: 125359 RVA: 0x009181E9 File Offset: 0x009163E9
		[SkipLocalsInit]
		public virtual void _15_狄斯台地夜晚()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___15_狄斯台地夜晚_NativeFunctionPtr, null);
		}

		// Token: 0x0601E9B0 RID: 125360 RVA: 0x009181FD File Offset: 0x009163FD
		[SkipLocalsInit]
		public virtual void _14_狄斯台地白天()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___14_狄斯台地白天_NativeFunctionPtr, null);
		}

		// Token: 0x0601E9B1 RID: 125361 RVA: 0x00918211 File Offset: 0x00916411
		[SkipLocalsInit]
		public virtual void _13_七丘夜晚()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___13_七丘夜晚_NativeFunctionPtr, null);
		}

		// Token: 0x0601E9B2 RID: 125362 RVA: 0x00918225 File Offset: 0x00916425
		[SkipLocalsInit]
		public virtual void _12_观测塔()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___12_观测塔_NativeFunctionPtr, null);
		}

		// Token: 0x0601E9B3 RID: 125363 RVA: 0x00918239 File Offset: 0x00916439
		[SkipLocalsInit]
		public virtual void _11_尖刺山()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___11_尖刺山_NativeFunctionPtr, null);
		}

		// Token: 0x0601E9B4 RID: 125364 RVA: 0x0091824D File Offset: 0x0091644D
		[SkipLocalsInit]
		public virtual void _10_残破竞技场()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___10_残破竞技场_NativeFunctionPtr, null);
		}

		// Token: 0x0601E9B5 RID: 125365 RVA: 0x00918261 File Offset: 0x00916461
		[SkipLocalsInit]
		public virtual void _09_七丘阴天()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___09_七丘阴天_NativeFunctionPtr, null);
		}

		// Token: 0x0601E9B6 RID: 125366 RVA: 0x00918275 File Offset: 0x00916475
		[SkipLocalsInit]
		public virtual void _08_初见七丘()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___08_初见七丘_NativeFunctionPtr, null);
		}

		// Token: 0x0601E9B7 RID: 125367 RVA: 0x00918289 File Offset: 0x00916489
		[SkipLocalsInit]
		public virtual void _07_七丘()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___07_七丘_NativeFunctionPtr, null);
		}

		// Token: 0x0601E9B8 RID: 125368 RVA: 0x0091829D File Offset: 0x0091649D
		[SkipLocalsInit]
		public virtual void _11_颠倒塔流星()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___11_颠倒塔流星_NativeFunctionPtr, null);
		}

		// Token: 0x0601E9B9 RID: 125369 RVA: 0x009182B1 File Offset: 0x009164B1
		[SkipLocalsInit]
		public virtual void _10_颠倒塔夜晚()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___10_颠倒塔夜晚_NativeFunctionPtr, null);
		}

		// Token: 0x0601E9BA RID: 125370 RVA: 0x009182C5 File Offset: 0x009164C5
		[SkipLocalsInit]
		public virtual void _09_颠倒塔白天()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___09_颠倒塔白天_NativeFunctionPtr, null);
		}

		// Token: 0x0601E9BB RID: 125371 RVA: 0x009182D9 File Offset: 0x009164D9
		[SkipLocalsInit]
		public virtual void _08_彩虹天气()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___08_彩虹天气_NativeFunctionPtr, null);
		}

		// Token: 0x0601E9BC RID: 125372 RVA: 0x009182ED File Offset: 0x009164ED
		[SkipLocalsInit]
		public virtual void CloudMainParamsUpdate()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.__CloudMainParamsUpdate_NativeFunctionPtr, null);
		}

		// Token: 0x0601E9BD RID: 125373 RVA: 0x00918301 File Offset: 0x00916501
		[SkipLocalsInit]
		public virtual void _07_费洛洛出场()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___07_费洛洛出场_NativeFunctionPtr, null);
		}

		// Token: 0x0601E9BE RID: 125374 RVA: 0x00918315 File Offset: 0x00916515
		[SkipLocalsInit]
		public virtual void _06_金库上解密后()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___06_金库上解密后_NativeFunctionPtr, null);
		}

		// Token: 0x0601E9BF RID: 125375 RVA: 0x00918329 File Offset: 0x00916529
		[SkipLocalsInit]
		public virtual void _05_罗墓岛夜晚()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___05_罗墓岛夜晚_NativeFunctionPtr, null);
		}

		// Token: 0x0601E9C0 RID: 125376 RVA: 0x0091833D File Offset: 0x0091653D
		[SkipLocalsInit]
		public virtual void _06_黎娜夕塔阴()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___06_黎娜夕塔阴_NativeFunctionPtr, null);
		}

		// Token: 0x0601E9C1 RID: 125377 RVA: 0x00918351 File Offset: 0x00916551
		[SkipLocalsInit]
		public virtual void _04_云海区()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___04_云海区_NativeFunctionPtr, null);
		}

		// Token: 0x0601E9C2 RID: 125378 RVA: 0x00918365 File Offset: 0x00916565
		[SkipLocalsInit]
		public virtual void _03_槲生半岛解密后()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___03_槲生半岛解密后_NativeFunctionPtr, null);
		}

		// Token: 0x0601E9C3 RID: 125379 RVA: 0x00918379 File Offset: 0x00916579
		[SkipLocalsInit]
		public virtual void _05_狂欢节()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___05_狂欢节_NativeFunctionPtr, null);
		}

		// Token: 0x0601E9C4 RID: 125380 RVA: 0x0091838D File Offset: 0x0091658D
		[SkipLocalsInit]
		public virtual void 显示云移动范围()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.__显示云移动范围_NativeFunctionPtr, null);
		}

		// Token: 0x0601E9C5 RID: 125381 RVA: 0x009183A1 File Offset: 0x009165A1
		[SkipLocalsInit]
		public virtual void 关闭云跟随摄像机移动()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.__关闭云跟随摄像机移动_NativeFunctionPtr, null);
		}

		// Token: 0x0601E9C6 RID: 125382 RVA: 0x009183B5 File Offset: 0x009165B5
		[SkipLocalsInit]
		public virtual void 开启云跟随摄像机移动()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.__开启云跟随摄像机移动_NativeFunctionPtr, null);
		}

		// Token: 0x0601E9C7 RID: 125383 RVA: 0x009183C9 File Offset: 0x009165C9
		[SkipLocalsInit]
		public virtual void _04_金库上层()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___04_金库上层_NativeFunctionPtr, null);
		}

		// Token: 0x0601E9C8 RID: 125384 RVA: 0x009183DD File Offset: 0x009165DD
		[SkipLocalsInit]
		public virtual void _03_狄萨莱海脊永夜解密后()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___03_狄萨莱海脊永夜解密后_NativeFunctionPtr, null);
		}

		// Token: 0x0601E9C9 RID: 125385 RVA: 0x009183F1 File Offset: 0x009165F1
		[SkipLocalsInit]
		public virtual void _02_狄萨莱海脊永夜解密前()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___02_狄萨莱海脊永夜解密前_NativeFunctionPtr, null);
		}

		// Token: 0x0601E9CA RID: 125386 RVA: 0x00918405 File Offset: 0x00916605
		[SkipLocalsInit]
		public virtual void _01_槲生半岛()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___01_槲生半岛_NativeFunctionPtr, null);
		}

		// Token: 0x0601E9CB RID: 125387 RVA: 0x00918419 File Offset: 0x00916619
		[SkipLocalsInit]
		public virtual void _02_帕尔米罗墓地()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___02_帕尔米罗墓地_NativeFunctionPtr, null);
		}

		// Token: 0x0601E9CC RID: 125388 RVA: 0x0091842D File Offset: 0x0091662D
		[SkipLocalsInit]
		public virtual void _01_黎娜汐塔()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___01_黎娜汐塔_NativeFunctionPtr, null);
		}

		// Token: 0x0601E9CD RID: 125389 RVA: 0x00918441 File Offset: 0x00916641
		[SkipLocalsInit]
		public virtual void _020黑海岸天气_阴()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___020黑海岸天气_阴_NativeFunctionPtr, null);
		}

		// Token: 0x0601E9CE RID: 125390 RVA: 0x00918455 File Offset: 0x00916655
		[SkipLocalsInit]
		public virtual void _019肉鸽月亮05()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___019肉鸽月亮05_NativeFunctionPtr, null);
		}

		// Token: 0x0601E9CF RID: 125391 RVA: 0x00918469 File Offset: 0x00916669
		[SkipLocalsInit]
		public virtual void _018肉鸽月亮04()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___018肉鸽月亮04_NativeFunctionPtr, null);
		}

		// Token: 0x0601E9D0 RID: 125392 RVA: 0x0091847D File Offset: 0x0091667D
		[SkipLocalsInit]
		public virtual void _017肉鸽月亮03()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___017肉鸽月亮03_NativeFunctionPtr, null);
		}

		// Token: 0x0601E9D1 RID: 125393 RVA: 0x00918491 File Offset: 0x00916691
		[SkipLocalsInit]
		public virtual void _016肉鸽月亮02()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___016肉鸽月亮02_NativeFunctionPtr, null);
		}

		// Token: 0x0601E9D2 RID: 125394 RVA: 0x009184A5 File Offset: 0x009166A5
		[SkipLocalsInit]
		public virtual void _015肉鸽月亮01()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___015肉鸽月亮01_NativeFunctionPtr, null);
		}

		// Token: 0x0601E9D3 RID: 125395 RVA: 0x009184B9 File Offset: 0x009166B9
		[SkipLocalsInit]
		public virtual void _014黑海岸夜晚()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___014黑海岸夜晚_NativeFunctionPtr, null);
		}

		// Token: 0x0601E9D4 RID: 125396 RVA: 0x009184CD File Offset: 0x009166CD
		[SkipLocalsInit]
		public virtual void _08黑海岸下层()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___08黑海岸下层_NativeFunctionPtr, null);
		}

		// Token: 0x0601E9D5 RID: 125397 RVA: 0x009184E1 File Offset: 0x009166E1
		[SkipLocalsInit]
		public virtual void _07黑海岸上层()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___07黑海岸上层_NativeFunctionPtr, null);
		}

		// Token: 0x0601E9D6 RID: 125398 RVA: 0x009184F8 File Offset: 0x009166F8
		[SkipLocalsInit]
		public unsafe virtual void Get_GIParams(float CurTime)
		{
			BP_Clouds_C.__Get_GIParams_FunctionParams* ptr = stackalloc BP_Clouds_C.__Get_GIParams_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Clouds_C.__Get_GIParams_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Clouds_C.__Get_GIParams_NativeFunctionPtr, (void*)ptr, 1);
			ptr->CurTime = CurTime;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.__Get_GIParams_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E9D7 RID: 125399 RVA: 0x0091853E File Offset: 0x0091673E
		[SkipLocalsInit]
		public virtual void _06乘宵山()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___06乘宵山_NativeFunctionPtr, null);
		}

		// Token: 0x0601E9D8 RID: 125400 RVA: 0x00918552 File Offset: 0x00916752
		[SkipLocalsInit]
		public virtual void _05怨鸟泽()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___05怨鸟泽_NativeFunctionPtr, null);
		}

		// Token: 0x0601E9D9 RID: 125401 RVA: 0x00918566 File Offset: 0x00916766
		[SkipLocalsInit]
		public virtual void _013乘宵山异象()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___013乘宵山异象_NativeFunctionPtr, null);
		}

		// Token: 0x0601E9DA RID: 125402 RVA: 0x0091857A File Offset: 0x0091677A
		[SkipLocalsInit]
		public virtual void _012夜晚异象()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___012夜晚异象_NativeFunctionPtr, null);
		}

		// Token: 0x0601E9DB RID: 125403 RVA: 0x0091858E File Offset: 0x0091678E
		[SkipLocalsInit]
		public virtual void _011黄昏异象()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___011黄昏异象_NativeFunctionPtr, null);
		}

		// Token: 0x0601E9DC RID: 125404 RVA: 0x009185A2 File Offset: 0x009167A2
		[SkipLocalsInit]
		public virtual void _010阴天异象()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___010阴天异象_NativeFunctionPtr, null);
		}

		// Token: 0x0601E9DD RID: 125405 RVA: 0x009185B6 File Offset: 0x009167B6
		[SkipLocalsInit]
		public virtual void _09鸣潮天气()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___09鸣潮天气_NativeFunctionPtr, null);
		}

		// Token: 0x0601E9DE RID: 125406 RVA: 0x009185CA File Offset: 0x009167CA
		[SkipLocalsInit]
		public virtual void _08漩涡云01()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___08漩涡云01_NativeFunctionPtr, null);
		}

		// Token: 0x0601E9DF RID: 125407 RVA: 0x009185DE File Offset: 0x009167DE
		[SkipLocalsInit]
		public virtual void _07无音区05()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___07无音区05_NativeFunctionPtr, null);
		}

		// Token: 0x0601E9E0 RID: 125408 RVA: 0x009185F2 File Offset: 0x009167F2
		[SkipLocalsInit]
		public virtual void _06无音区04()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___06无音区04_NativeFunctionPtr, null);
		}

		// Token: 0x0601E9E1 RID: 125409 RVA: 0x00918606 File Offset: 0x00916806
		[SkipLocalsInit]
		public virtual void _05无音区03()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___05无音区03_NativeFunctionPtr, null);
		}

		// Token: 0x0601E9E2 RID: 125410 RVA: 0x0091861A File Offset: 0x0091681A
		[SkipLocalsInit]
		public virtual void _04无音区02()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___04无音区02_NativeFunctionPtr, null);
		}

		// Token: 0x0601E9E3 RID: 125411 RVA: 0x0091862E File Offset: 0x0091682E
		[SkipLocalsInit]
		public virtual void 原画测试用云()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.__原画测试用云_NativeFunctionPtr, null);
		}

		// Token: 0x0601E9E4 RID: 125412 RVA: 0x00918642 File Offset: 0x00916842
		[SkipLocalsInit]
		public virtual void _04中曲台地()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___04中曲台地_NativeFunctionPtr, null);
		}

		// Token: 0x0601E9E5 RID: 125413 RVA: 0x00918656 File Offset: 0x00916856
		[SkipLocalsInit]
		public virtual void Hidden_Old()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.__Hidden_Old_NativeFunctionPtr, null);
		}

		// Token: 0x0601E9E6 RID: 125414 RVA: 0x0091866A File Offset: 0x0091686A
		[SkipLocalsInit]
		public virtual void _03无音区01()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___03无音区01_NativeFunctionPtr, null);
		}

		// Token: 0x0601E9E7 RID: 125415 RVA: 0x0091867E File Offset: 0x0091687E
		[SkipLocalsInit]
		public virtual void _02无音区沉寂态()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___02无音区沉寂态_NativeFunctionPtr, null);
		}

		// Token: 0x0601E9E8 RID: 125416 RVA: 0x00918692 File Offset: 0x00916892
		[SkipLocalsInit]
		public virtual void _01登录界面()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___01登录界面_NativeFunctionPtr, null);
		}

		// Token: 0x0601E9E9 RID: 125417 RVA: 0x009186A6 File Offset: 0x009168A6
		[SkipLocalsInit]
		public virtual void _03无光之森()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___03无光之森_NativeFunctionPtr, null);
		}

		// Token: 0x0601E9EA RID: 125418 RVA: 0x009186BA File Offset: 0x009168BA
		[SkipLocalsInit]
		public virtual void _02遗落原乡()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___02遗落原乡_NativeFunctionPtr, null);
		}

		// Token: 0x0601E9EB RID: 125419 RVA: 0x009186CE File Offset: 0x009168CE
		[SkipLocalsInit]
		public virtual void _01天城()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.___01天城_NativeFunctionPtr, null);
		}

		// Token: 0x0601E9EC RID: 125420 RVA: 0x009186E2 File Offset: 0x009168E2
		[SkipLocalsInit]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601E9ED RID: 125421 RVA: 0x009186F6 File Offset: 0x009168F6
		[SkipLocalsInit]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Clouds_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601E9EE RID: 125422 RVA: 0x0091870C File Offset: 0x0091690C
		[SkipLocalsInit]
		public unsafe virtual void OnLoaded_63FE5E2B437AFAD504FBCAB26242EB8A(UObject Loaded)
		{
			BP_Clouds_C.__OnLoaded_63FE5E2B437AFAD504FBCAB26242EB8A_FunctionParams* ptr = stackalloc BP_Clouds_C.__OnLoaded_63FE5E2B437AFAD504FBCAB26242EB8A_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_Clouds_C.__OnLoaded_63FE5E2B437AFAD504FBCAB26242EB8A_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Clouds_C.__OnLoaded_63FE5E2B437AFAD504FBCAB26242EB8A_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Loaded = ((Loaded != null) ? Loaded.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.__OnLoaded_63FE5E2B437AFAD504FBCAB26242EB8A_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E9EF RID: 125423 RVA: 0x00918761 File Offset: 0x00916961
		[SkipLocalsInit]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601E9F0 RID: 125424 RVA: 0x00918775 File Offset: 0x00916975
		[SkipLocalsInit]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Clouds_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601E9F1 RID: 125425 RVA: 0x0091878C File Offset: 0x0091698C
		[SkipLocalsInit]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_Clouds_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Clouds_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Clouds_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Clouds_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E9F2 RID: 125426 RVA: 0x009187D4 File Offset: 0x009169D4
		[SkipLocalsInit]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_Clouds_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Clouds_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Clouds_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Clouds_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Clouds_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E9F3 RID: 125427 RVA: 0x0091881C File Offset: 0x00916A1C
		[SkipLocalsInit]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_Clouds_C.__EditorTick_FunctionParams* ptr = stackalloc BP_Clouds_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Clouds_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Clouds_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E9F4 RID: 125428 RVA: 0x00918864 File Offset: 0x00916A64
		[SkipLocalsInit]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_Clouds_C.__EditorTick_FunctionParams* ptr = stackalloc BP_Clouds_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Clouds_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Clouds_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Clouds_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E9F5 RID: 125429 RVA: 0x009188AA File Offset: 0x00916AAA
		[SkipLocalsInit]
		public virtual void ChangeCloud()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_C.__ChangeCloud_NativeFunctionPtr, null);
		}

		// Token: 0x0601E9F6 RID: 125430 RVA: 0x009188C0 File Offset: 0x00916AC0
		[NullableContext(1)]
		[SkipLocalsInit]
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

		// Token: 0x0601E9F7 RID: 125431 RVA: 0x0091894A File Offset: 0x00916B4A
		protected BP_Clouds_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401034B RID: 66379
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/GI/NewCloud/BP/BP_Clouds.BP_Clouds_C";

		// Token: 0x0401034C RID: 66380
		private static IntPtr _ClassPtr;

		// Token: 0x0401034D RID: 66381
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401034E RID: 66382
		internal static int __PropertyOffset_Cloud02;

		// Token: 0x0401034F RID: 66383
		internal static int __PropertyOffset_Cloud01;

		// Token: 0x04010350 RID: 66384
		internal static int __PropertyOffset_DefaultSceneRoot;

		// Token: 0x04010351 RID: 66385
		internal static int __PropertyOffset_Counting;

		// Token: 0x04010352 RID: 66386
		internal static int __PropertyOffset_SortNumber;

		// Token: 0x04010353 RID: 66387
		private TArray<int> _SortNumber;

		// Token: 0x04010354 RID: 66388
		internal static int __PropertyOffset_CachedAudioEvent2D;

		// Token: 0x04010355 RID: 66389
		internal static int __PropertyOffset_IsSkyOcean;

		// Token: 0x04010356 RID: 66390
		internal static int __PropertyOffset_SkyOceanAudio;

		// Token: 0x04010357 RID: 66391
		internal static int __PropertyOffset_Override_Cloud_Rotation;

		// Token: 0x04010358 RID: 66392
		internal static int __PropertyOffset_Cloud_Speed;

		// Token: 0x04010359 RID: 66393
		internal static int __PropertyOffset_Cloud_Offset;

		// Token: 0x0401035A RID: 66394
		internal static int __PropertyOffset_IsReversed_;

		// Token: 0x0401035B RID: 66395
		internal static int __PropertyOffset_ReversedZHeightBias;

		// Token: 0x0401035C RID: 66396
		internal static int __PropertyOffset_FeatureLevel;

		// Token: 0x0401035D RID: 66397
		internal static int __PropertyOffset_IsHiddenClouds;

		// Token: 0x0401035E RID: 66398
		private static IntPtr ___11_水母天空_NativeFunctionPtr;

		// Token: 0x0401035F RID: 66399
		private static IntPtr ___10_裂缝天空_NativeFunctionPtr;

		// Token: 0x04010360 RID: 66400
		private static IntPtr ___09_新联邦阴天_NativeFunctionPtr;

		// Token: 0x04010361 RID: 66401
		private static IntPtr ___08_龙卷风_NativeFunctionPtr;

		// Token: 0x04010362 RID: 66402
		private static IntPtr ___07_局部暴流_NativeFunctionPtr;

		// Token: 0x04010363 RID: 66403
		private static IntPtr ___06_暴雨季夜晚_NativeFunctionPtr;

		// Token: 0x04010364 RID: 66404
		private static IntPtr ___05_暴雨季白天_NativeFunctionPtr;

		// Token: 0x04010365 RID: 66405
		private static IntPtr ___04_丰水季夜晚_NativeFunctionPtr;

		// Token: 0x04010366 RID: 66406
		private static IntPtr ___03_丰水季白天_NativeFunctionPtr;

		// Token: 0x04010367 RID: 66407
		private static IntPtr ___02_枯水季夜晚_NativeFunctionPtr;

		// Token: 0x04010368 RID: 66408
		private static IntPtr ___01_枯水季白天_NativeFunctionPtr;

		// Token: 0x04010369 RID: 66409
		private static IntPtr ___45_梦境列车星空云_NativeFunctionPtr;

		// Token: 0x0401036A RID: 66410
		private static IntPtr ___44_梦境列车星空_NativeFunctionPtr;

		// Token: 0x0401036B RID: 66411
		private static IntPtr ___43_梦境列车阴天_NativeFunctionPtr;

		// Token: 0x0401036C RID: 66412
		private static IntPtr ___42_梦境列车晴天_NativeFunctionPtr;

		// Token: 0x0401036D RID: 66413
		private static IntPtr ___41_金匣冷调_NativeFunctionPtr;

		// Token: 0x0401036E RID: 66414
		private static IntPtr ___40_天演幻心二阶段_NativeFunctionPtr;

		// Token: 0x0401036F RID: 66415
		private static IntPtr ___39_天演幻心_NativeFunctionPtr;

		// Token: 0x04010370 RID: 66416
		private static IntPtr ___38_金匣_NativeFunctionPtr;

		// Token: 0x04010371 RID: 66417
		private static IntPtr ___37_水匣_NativeFunctionPtr;

		// Token: 0x04010372 RID: 66418
		private static IntPtr ___36_火匣_NativeFunctionPtr;

		// Token: 0x04010373 RID: 66419
		private static IntPtr ___35_心湖_NativeFunctionPtr;

		// Token: 0x04010374 RID: 66420
		private static IntPtr ___34_天境_NativeFunctionPtr;

		// Token: 0x04010375 RID: 66421
		private static IntPtr ___33_地境_NativeFunctionPtr;

		// Token: 0x04010376 RID: 66422
		private static IntPtr ___32_人境_NativeFunctionPtr;

		// Token: 0x04010377 RID: 66423
		private static IntPtr ___31_梦州特殊2_NativeFunctionPtr;

		// Token: 0x04010378 RID: 66424
		private static IntPtr ___30_梦州特殊1_NativeFunctionPtr;

		// Token: 0x04010379 RID: 66425
		private static IntPtr ___29_宅邸解谜后_NativeFunctionPtr;

		// Token: 0x0401037A RID: 66426
		private static IntPtr ___28_宅邸解谜前_NativeFunctionPtr;

		// Token: 0x0401037B RID: 66427
		private static IntPtr ___27_梦州初见_NativeFunctionPtr;

		// Token: 0x0401037C RID: 66428
		private static IntPtr ___26_梦州阴天_NativeFunctionPtr;

		// Token: 0x0401037D RID: 66429
		private static IntPtr ___25_梦州夜晚_NativeFunctionPtr;

		// Token: 0x0401037E RID: 66430
		private static IntPtr ___24_梦州白天_NativeFunctionPtr;

		// Token: 0x0401037F RID: 66431
		private static IntPtr ___23_高达Boss三阶_NativeFunctionPtr;

		// Token: 0x04010380 RID: 66432
		private static IntPtr ___22_高达Boss一阶_NativeFunctionPtr;

		// Token: 0x04010381 RID: 66433
		private static IntPtr ___21_日灵棺解密后_NativeFunctionPtr;

		// Token: 0x04010382 RID: 66434
		private static IntPtr ___20_日灵棺解密前_NativeFunctionPtr;

		// Token: 0x04010383 RID: 66435
		private static IntPtr ___19_拉海洛初见_NativeFunctionPtr;

		// Token: 0x04010384 RID: 66436
		private static IntPtr ___18_星海BOSS三阶_NativeFunctionPtr;

		// Token: 0x04010385 RID: 66437
		private static IntPtr ___17_星海BOSS一阶_NativeFunctionPtr;

		// Token: 0x04010386 RID: 66438
		private static IntPtr ___16_罗伊初见_NativeFunctionPtr;

		// Token: 0x04010387 RID: 66439
		private static IntPtr ___15_罗伊极光_NativeFunctionPtr;

		// Token: 0x04010388 RID: 66440
		private static IntPtr ___14_罗伊夜晚_NativeFunctionPtr;

		// Token: 0x04010389 RID: 66441
		private static IntPtr ___13_罗伊白天_NativeFunctionPtr;

		// Token: 0x0401038A RID: 66442
		private static IntPtr ___24_不渲染BP_Cloud控制的云_NativeFunctionPtr;

		// Token: 0x0401038B RID: 66443
		private static IntPtr ___12_梵高_NativeFunctionPtr;

		// Token: 0x0401038C RID: 66444
		private static IntPtr ___11_拉海洛阴天_NativeFunctionPtr;

		// Token: 0x0401038D RID: 66445
		private static IntPtr ___10_浮光林夜晚_NativeFunctionPtr;

		// Token: 0x0401038E RID: 66446
		private static IntPtr ___09_浮光林白天_NativeFunctionPtr;

		// Token: 0x0401038F RID: 66447
		private static IntPtr ___08_炉芯领主_NativeFunctionPtr;

		// Token: 0x04010390 RID: 66448
		private static IntPtr ___07_炉芯内部_NativeFunctionPtr;

		// Token: 0x04010391 RID: 66449
		private static IntPtr ___06_坠落炉芯_NativeFunctionPtr;

		// Token: 0x04010392 RID: 66450
		private static IntPtr ___05_星门Boss_NativeFunctionPtr;

		// Token: 0x04010393 RID: 66451
		private static IntPtr ___04_磁暴后置_NativeFunctionPtr;

		// Token: 0x04010394 RID: 66452
		private static IntPtr ___03_磁暴前置_NativeFunctionPtr;

		// Token: 0x04010395 RID: 66453
		private static IntPtr ___02_拉海洛夜晚_NativeFunctionPtr;

		// Token: 0x04010396 RID: 66454
		private static IntPtr ___01_拉海落白天_NativeFunctionPtr;

		// Token: 0x04010397 RID: 66455
		private static IntPtr ___23_安全点夜晚_NativeFunctionPtr;

		// Token: 0x04010398 RID: 66456
		private static IntPtr ___22_安全点白天_NativeFunctionPtr;

		// Token: 0x04010399 RID: 66457
		private static IntPtr ___23_穗波阴天_NativeFunctionPtr;

		// Token: 0x0401039A RID: 66458
		private static IntPtr ___22_穗波枯山水_NativeFunctionPtr;

		// Token: 0x0401039B RID: 66459
		private static IntPtr ___21_穗波夜晚_NativeFunctionPtr;

		// Token: 0x0401039C RID: 66460
		private static IntPtr ___20_穗波白天_NativeFunctionPtr;

		// Token: 0x0401039D RID: 66461
		private static IntPtr ___21_总督日月同辉_NativeFunctionPtr;

		// Token: 0x0401039E RID: 66462
		private static IntPtr ___21_烈阳天气_NativeFunctionPtr;

		// Token: 0x0401039F RID: 66463
		private static IntPtr ___20_黑潮风暴加强_NativeFunctionPtr;

		// Token: 0x040103A0 RID: 66464
		private static IntPtr ___19_黑潮风暴_NativeFunctionPtr;

		// Token: 0x040103A1 RID: 66465
		private static IntPtr ___18_失亡彼岸_NativeFunctionPtr;

		// Token: 0x040103A2 RID: 66466
		private static IntPtr ___17_隐海试验场_NativeFunctionPtr;

		// Token: 0x040103A3 RID: 66467
		private static IntPtr ___16_巡游天国_NativeFunctionPtr;

		// Token: 0x040103A4 RID: 66468
		private static IntPtr ___15_光路幻境_NativeFunctionPtr;

		// Token: 0x040103A5 RID: 66469
		private static IntPtr ___14_黑潮内里世界_NativeFunctionPtr;

		// Token: 0x040103A6 RID: 66470
		private static IntPtr ___13_黑潮内表世界_NativeFunctionPtr;

		// Token: 0x040103A7 RID: 66471
		private static IntPtr ___12_黑潮侵蚀_NativeFunctionPtr;

		// Token: 0x040103A8 RID: 66472
		private static IntPtr ___19_狄斯台地月相_NativeFunctionPtr;

		// Token: 0x040103A9 RID: 66473
		private static IntPtr ___18_狄斯台地受蚀地_NativeFunctionPtr;

		// Token: 0x040103AA RID: 66474
		private static IntPtr ___17_狄斯台地烈日天空_NativeFunctionPtr;

		// Token: 0x040103AB RID: 66475
		private static IntPtr ___16_狄斯台地日月同辉_NativeFunctionPtr;

		// Token: 0x040103AC RID: 66476
		private static IntPtr ___15_狄斯台地夜晚_NativeFunctionPtr;

		// Token: 0x040103AD RID: 66477
		private static IntPtr ___14_狄斯台地白天_NativeFunctionPtr;

		// Token: 0x040103AE RID: 66478
		private static IntPtr ___13_七丘夜晚_NativeFunctionPtr;

		// Token: 0x040103AF RID: 66479
		private static IntPtr ___12_观测塔_NativeFunctionPtr;

		// Token: 0x040103B0 RID: 66480
		private static IntPtr ___11_尖刺山_NativeFunctionPtr;

		// Token: 0x040103B1 RID: 66481
		private static IntPtr ___10_残破竞技场_NativeFunctionPtr;

		// Token: 0x040103B2 RID: 66482
		private static IntPtr ___09_七丘阴天_NativeFunctionPtr;

		// Token: 0x040103B3 RID: 66483
		private static IntPtr ___08_初见七丘_NativeFunctionPtr;

		// Token: 0x040103B4 RID: 66484
		private static IntPtr ___07_七丘_NativeFunctionPtr;

		// Token: 0x040103B5 RID: 66485
		private static IntPtr ___11_颠倒塔流星_NativeFunctionPtr;

		// Token: 0x040103B6 RID: 66486
		private static IntPtr ___10_颠倒塔夜晚_NativeFunctionPtr;

		// Token: 0x040103B7 RID: 66487
		private static IntPtr ___09_颠倒塔白天_NativeFunctionPtr;

		// Token: 0x040103B8 RID: 66488
		private static IntPtr ___08_彩虹天气_NativeFunctionPtr;

		// Token: 0x040103B9 RID: 66489
		private static IntPtr __CloudMainParamsUpdate_NativeFunctionPtr;

		// Token: 0x040103BA RID: 66490
		private static IntPtr ___07_费洛洛出场_NativeFunctionPtr;

		// Token: 0x040103BB RID: 66491
		private static IntPtr ___06_金库上解密后_NativeFunctionPtr;

		// Token: 0x040103BC RID: 66492
		private static IntPtr ___05_罗墓岛夜晚_NativeFunctionPtr;

		// Token: 0x040103BD RID: 66493
		private static IntPtr ___06_黎娜夕塔阴_NativeFunctionPtr;

		// Token: 0x040103BE RID: 66494
		private static IntPtr ___04_云海区_NativeFunctionPtr;

		// Token: 0x040103BF RID: 66495
		private static IntPtr ___03_槲生半岛解密后_NativeFunctionPtr;

		// Token: 0x040103C0 RID: 66496
		private static IntPtr ___05_狂欢节_NativeFunctionPtr;

		// Token: 0x040103C1 RID: 66497
		private static IntPtr __显示云移动范围_NativeFunctionPtr;

		// Token: 0x040103C2 RID: 66498
		private static IntPtr __关闭云跟随摄像机移动_NativeFunctionPtr;

		// Token: 0x040103C3 RID: 66499
		private static IntPtr __开启云跟随摄像机移动_NativeFunctionPtr;

		// Token: 0x040103C4 RID: 66500
		private static IntPtr ___04_金库上层_NativeFunctionPtr;

		// Token: 0x040103C5 RID: 66501
		private static IntPtr ___03_狄萨莱海脊永夜解密后_NativeFunctionPtr;

		// Token: 0x040103C6 RID: 66502
		private static IntPtr ___02_狄萨莱海脊永夜解密前_NativeFunctionPtr;

		// Token: 0x040103C7 RID: 66503
		private static IntPtr ___01_槲生半岛_NativeFunctionPtr;

		// Token: 0x040103C8 RID: 66504
		private static IntPtr ___02_帕尔米罗墓地_NativeFunctionPtr;

		// Token: 0x040103C9 RID: 66505
		private static IntPtr ___01_黎娜汐塔_NativeFunctionPtr;

		// Token: 0x040103CA RID: 66506
		private static IntPtr ___020黑海岸天气_阴_NativeFunctionPtr;

		// Token: 0x040103CB RID: 66507
		private static IntPtr ___019肉鸽月亮05_NativeFunctionPtr;

		// Token: 0x040103CC RID: 66508
		private static IntPtr ___018肉鸽月亮04_NativeFunctionPtr;

		// Token: 0x040103CD RID: 66509
		private static IntPtr ___017肉鸽月亮03_NativeFunctionPtr;

		// Token: 0x040103CE RID: 66510
		private static IntPtr ___016肉鸽月亮02_NativeFunctionPtr;

		// Token: 0x040103CF RID: 66511
		private static IntPtr ___015肉鸽月亮01_NativeFunctionPtr;

		// Token: 0x040103D0 RID: 66512
		private static IntPtr ___014黑海岸夜晚_NativeFunctionPtr;

		// Token: 0x040103D1 RID: 66513
		private static IntPtr ___08黑海岸下层_NativeFunctionPtr;

		// Token: 0x040103D2 RID: 66514
		private static IntPtr ___07黑海岸上层_NativeFunctionPtr;

		// Token: 0x040103D3 RID: 66515
		private static IntPtr __Get_GIParams_NativeFunctionPtr;

		// Token: 0x040103D4 RID: 66516
		private static IntPtr ___06乘宵山_NativeFunctionPtr;

		// Token: 0x040103D5 RID: 66517
		private static IntPtr ___05怨鸟泽_NativeFunctionPtr;

		// Token: 0x040103D6 RID: 66518
		private static IntPtr ___013乘宵山异象_NativeFunctionPtr;

		// Token: 0x040103D7 RID: 66519
		private static IntPtr ___012夜晚异象_NativeFunctionPtr;

		// Token: 0x040103D8 RID: 66520
		private static IntPtr ___011黄昏异象_NativeFunctionPtr;

		// Token: 0x040103D9 RID: 66521
		private static IntPtr ___010阴天异象_NativeFunctionPtr;

		// Token: 0x040103DA RID: 66522
		private static IntPtr ___09鸣潮天气_NativeFunctionPtr;

		// Token: 0x040103DB RID: 66523
		private static IntPtr ___08漩涡云01_NativeFunctionPtr;

		// Token: 0x040103DC RID: 66524
		private static IntPtr ___07无音区05_NativeFunctionPtr;

		// Token: 0x040103DD RID: 66525
		private static IntPtr ___06无音区04_NativeFunctionPtr;

		// Token: 0x040103DE RID: 66526
		private static IntPtr ___05无音区03_NativeFunctionPtr;

		// Token: 0x040103DF RID: 66527
		private static IntPtr ___04无音区02_NativeFunctionPtr;

		// Token: 0x040103E0 RID: 66528
		private static IntPtr __原画测试用云_NativeFunctionPtr;

		// Token: 0x040103E1 RID: 66529
		private static IntPtr ___04中曲台地_NativeFunctionPtr;

		// Token: 0x040103E2 RID: 66530
		private static IntPtr __Hidden_Old_NativeFunctionPtr;

		// Token: 0x040103E3 RID: 66531
		private static IntPtr ___03无音区01_NativeFunctionPtr;

		// Token: 0x040103E4 RID: 66532
		private static IntPtr ___02无音区沉寂态_NativeFunctionPtr;

		// Token: 0x040103E5 RID: 66533
		private static IntPtr ___01登录界面_NativeFunctionPtr;

		// Token: 0x040103E6 RID: 66534
		private static IntPtr ___03无光之森_NativeFunctionPtr;

		// Token: 0x040103E7 RID: 66535
		private static IntPtr ___02遗落原乡_NativeFunctionPtr;

		// Token: 0x040103E8 RID: 66536
		private static IntPtr ___01天城_NativeFunctionPtr;

		// Token: 0x040103E9 RID: 66537
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x040103EA RID: 66538
		private static IntPtr __OnLoaded_63FE5E2B437AFAD504FBCAB26242EB8A_NativeFunctionPtr;

		// Token: 0x040103EB RID: 66539
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x040103EC RID: 66540
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x040103ED RID: 66541
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x040103EE RID: 66542
		private static IntPtr __ChangeCloud_NativeFunctionPtr;

		// Token: 0x040103EF RID: 66543
		private static IntPtr __LoadAndSwitch_NativeFunctionPtr;

		// Token: 0x02008EA0 RID: 36512
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __Get_GIParams_FunctionParams
		{
			// Token: 0x0402CB2C RID: 183084
			[FieldOffset(0)]
			public float CurTime;
		}

		// Token: 0x02008EA1 RID: 36513
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __OnLoaded_63FE5E2B437AFAD504FBCAB26242EB8A_FunctionParams
		{
			// Token: 0x0402CB2D RID: 183085
			[FieldOffset(0)]
			public IntPtr Loaded;
		}

		// Token: 0x02008EA2 RID: 36514
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0402CB2E RID: 183086
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02008EA3 RID: 36515
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x0402CB2F RID: 183087
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02008EA4 RID: 36516
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __LoadAndSwitch_FunctionParams
		{
			// Token: 0x0402CB30 RID: 183088
			[FieldOffset(0)]
			public byte Asset;

			// Token: 0x0402CB31 RID: 183089
			[FieldOffset(48)]
			public float ChangeSpeed;

			// Token: 0x0402CB32 RID: 183090
			[FieldOffset(52)]
			public bool IsInEditor;

			// Token: 0x0402CB33 RID: 183091
			[FieldOffset(53)]
			public bool IsAudio;

			// Token: 0x0402CB34 RID: 183092
			[FieldOffset(54)]
			public bool InstantHide;
		}
	}
}

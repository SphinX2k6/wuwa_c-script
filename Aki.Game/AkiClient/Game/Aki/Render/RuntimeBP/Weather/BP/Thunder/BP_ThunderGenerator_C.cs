using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Weather.BP.Thunder
{
	// Token: 0x02003A80 RID: 14976
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Weather/BP/Thunder/BP_ThunderGenerator.BP_ThunderGenerator_C")]
	[UnrealStructLayout(2208, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2200)]
	public class BP_ThunderGenerator_C : AThunderGenerator, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601FC52 RID: 130130 RVA: 0x008C20C1 File Offset: 0x008C02C1
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_ThunderGenerator_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Weather/BP/Thunder/BP_ThunderGenerator.BP_ThunderGenerator_C");
			}
			return BP_ThunderGenerator_C._ClassPtr;
		}

		// Token: 0x0601FC53 RID: 130131 RVA: 0x008C20E8 File Offset: 0x008C02E8
		public BP_ThunderGenerator_C() : this(BuiltinUtils.AllocNativeUObject(BP_ThunderGenerator_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601FC54 RID: 130132 RVA: 0x008C2110 File Offset: 0x008C0310
		[NullableContext(1)]
		public BP_ThunderGenerator_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_ThunderGenerator_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002CCC RID: 11468
		// (get) Token: 0x0601FC55 RID: 130133 RVA: 0x008C2143 File Offset: 0x008C0343
		// (set) Token: 0x0601FC56 RID: 130134 RVA: 0x008C2157 File Offset: 0x008C0357
		public unsafe UKuroPostProcessComponent KuroPostProcess_Vignette
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroPostProcessComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ThunderGenerator_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ThunderGenerator_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17002CCD RID: 11469
		// (get) Token: 0x0601FC57 RID: 130135 RVA: 0x008C216C File Offset: 0x008C036C
		// (set) Token: 0x0601FC58 RID: 130136 RVA: 0x008C2180 File Offset: 0x008C0380
		public unsafe PDA_ThunderConfigMap_C ThunderConfigMap
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<PDA_ThunderConfigMap_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ThunderGenerator_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ThunderGenerator_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17002CCE RID: 11470
		// (get) Token: 0x0601FC59 RID: 130137 RVA: 0x008C2195 File Offset: 0x008C0395
		// (set) Token: 0x0601FC5A RID: 130138 RVA: 0x008C21A9 File Offset: 0x008C03A9
		public unsafe PDA_ThunderConfig_C ThunderConfig
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<PDA_ThunderConfig_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ThunderGenerator_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ThunderGenerator_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17002CCF RID: 11471
		// (get) Token: 0x0601FC5B RID: 130139 RVA: 0x008C21BE File Offset: 0x008C03BE
		// (set) Token: 0x0601FC5C RID: 130140 RVA: 0x008C21D2 File Offset: 0x008C03D2
		public unsafe UAkAudioEvent CachedAudioEvent2D
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkAudioEvent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ThunderGenerator_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ThunderGenerator_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17002CD0 RID: 11472
		// (get) Token: 0x0601FC5D RID: 130141 RVA: 0x008C21E7 File Offset: 0x008C03E7
		// (set) Token: 0x0601FC5E RID: 130142 RVA: 0x008C21F7 File Offset: 0x008C03F7
		public unsafe int CachedTransition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ThunderGenerator_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ThunderGenerator_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17002CD1 RID: 11473
		// (get) Token: 0x0601FC5F RID: 130143 RVA: 0x008C2208 File Offset: 0x008C0408
		// (set) Token: 0x0601FC60 RID: 130144 RVA: 0x008C2218 File Offset: 0x008C0418
		public unsafe bool PartialCloudFlash
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ThunderGenerator_C.__PropertyOffset_6) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ThunderGenerator_C.__PropertyOffset_6) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002CD2 RID: 11474
		// (get) Token: 0x0601FC61 RID: 130145 RVA: 0x008C2229 File Offset: 0x008C0429
		// (set) Token: 0x0601FC62 RID: 130146 RVA: 0x008C2239 File Offset: 0x008C0439
		public unsafe float CloudThunderHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ThunderGenerator_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ThunderGenerator_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17002CD3 RID: 11475
		// (get) Token: 0x0601FC63 RID: 130147 RVA: 0x008C224A File Offset: 0x008C044A
		// (set) Token: 0x0601FC64 RID: 130148 RVA: 0x008C225E File Offset: 0x008C045E
		public unsafe FTransform CachedCameraTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ThunderGenerator_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ThunderGenerator_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17002CD4 RID: 11476
		// (get) Token: 0x0601FC65 RID: 130149 RVA: 0x008C2273 File Offset: 0x008C0473
		// (set) Token: 0x0601FC66 RID: 130150 RVA: 0x008C2287 File Offset: 0x008C0487
		public unsafe PDA_CloudThunderData_C CloudThunderConfigData
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<PDA_CloudThunderData_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ThunderGenerator_C.__PropertyOffset_9);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ThunderGenerator_C.__PropertyOffset_9, value);
			}
		}

		// Token: 0x17002CD5 RID: 11477
		// (get) Token: 0x0601FC67 RID: 130151 RVA: 0x008C229C File Offset: 0x008C049C
		// (set) Token: 0x0601FC68 RID: 130152 RVA: 0x008C22AC File Offset: 0x008C04AC
		public unsafe int PartialThunderIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ThunderGenerator_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ThunderGenerator_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17002CD6 RID: 11478
		// (get) Token: 0x0601FC69 RID: 130153 RVA: 0x008C22BD File Offset: 0x008C04BD
		// (set) Token: 0x0601FC6A RID: 130154 RVA: 0x008C22CD File Offset: 0x008C04CD
		public unsafe float CachedPartialEmissionScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ThunderGenerator_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ThunderGenerator_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17002CD7 RID: 11479
		// (get) Token: 0x0601FC6B RID: 130155 RVA: 0x008C22DE File Offset: 0x008C04DE
		// (set) Token: 0x0601FC6C RID: 130156 RVA: 0x008C22EE File Offset: 0x008C04EE
		public unsafe float CachedThunderPlaySpeedScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ThunderGenerator_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ThunderGenerator_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17002CD8 RID: 11480
		// (get) Token: 0x0601FC6D RID: 130157 RVA: 0x008C22FF File Offset: 0x008C04FF
		// (set) Token: 0x0601FC6E RID: 130158 RVA: 0x008C230F File Offset: 0x008C050F
		public unsafe bool DebugPartitialThunder
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ThunderGenerator_C.__PropertyOffset_13) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ThunderGenerator_C.__PropertyOffset_13) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002CD9 RID: 11481
		// (get) Token: 0x0601FC6F RID: 130159 RVA: 0x008C2320 File Offset: 0x008C0520
		// (set) Token: 0x0601FC70 RID: 130160 RVA: 0x008C2330 File Offset: 0x008C0530
		public unsafe float DebugPartitialThunderDensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ThunderGenerator_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ThunderGenerator_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17002CDA RID: 11482
		// (get) Token: 0x0601FC71 RID: 130161 RVA: 0x008C2341 File Offset: 0x008C0541
		// (set) Token: 0x0601FC72 RID: 130162 RVA: 0x008C2355 File Offset: 0x008C0555
		public unsafe FVector ThunderVectorCameraSpace
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ThunderGenerator_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ThunderGenerator_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x0601FC73 RID: 130163 RVA: 0x008C236A File Offset: 0x008C056A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateCloudThunderParameter()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ThunderGenerator_C.__UpdateCloudThunderParameter_NativeFunctionPtr, null);
		}

		// Token: 0x0601FC74 RID: 130164 RVA: 0x008C2380 File Offset: 0x008C0580
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual bool CalculateThunderPosition_Cloud(in FTransform CameraTransform, bool bAttack, ref FVector OutPosition)
		{
			BP_ThunderGenerator_C.__CalculateThunderPosition_Cloud_FunctionParams* ptr = stackalloc BP_ThunderGenerator_C.__CalculateThunderPosition_Cloud_FunctionParams[(UIntPtr)223] + 15L / (long)sizeof(BP_ThunderGenerator_C.__CalculateThunderPosition_Cloud_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ThunderGenerator_C.__CalculateThunderPosition_Cloud_NativeFunctionPtr, (void*)ptr, 1);
			ptr->CameraTransform = CameraTransform;
			ptr->bAttack = bAttack;
			ptr->OutPosition = OutPosition;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ThunderGenerator_C.__CalculateThunderPosition_Cloud_NativeFunctionPtr, (void*)ptr);
			OutPosition = ptr->OutPosition;
			return ptr->__Result;
		}

		// Token: 0x0601FC75 RID: 130165 RVA: 0x008C23F3 File Offset: 0x008C05F3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void ForceUpdate()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ThunderGenerator_C.__ForceUpdate_NativeFunctionPtr, null);
		}

		// Token: 0x0601FC76 RID: 130166 RVA: 0x008C2408 File Offset: 0x008C0608
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual bool CalculateThunderPosition_Common(in FTransform CameraTransform, bool bAttack, ref FVector OutPosition)
		{
			BP_ThunderGenerator_C.__CalculateThunderPosition_Common_FunctionParams* ptr = stackalloc BP_ThunderGenerator_C.__CalculateThunderPosition_Common_FunctionParams[(UIntPtr)175] + 15L / (long)sizeof(BP_ThunderGenerator_C.__CalculateThunderPosition_Common_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ThunderGenerator_C.__CalculateThunderPosition_Common_NativeFunctionPtr, (void*)ptr, 1);
			ptr->CameraTransform = CameraTransform;
			ptr->bAttack = bAttack;
			ptr->OutPosition = OutPosition;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ThunderGenerator_C.__CalculateThunderPosition_Common_NativeFunctionPtr, (void*)ptr);
			OutPosition = ptr->OutPosition;
			return ptr->__Result;
		}

		// Token: 0x0601FC77 RID: 130167 RVA: 0x008C247C File Offset: 0x008C067C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override bool CalculateThunderPosition(in FTransform CameraTransform, ref FVector OutPosition, bool bAttack)
		{
			BP_ThunderGenerator_C.__CalculateThunderPosition_FunctionParams* ptr = stackalloc BP_ThunderGenerator_C.__CalculateThunderPosition_FunctionParams[(UIntPtr)111] + 15L / (long)sizeof(BP_ThunderGenerator_C.__CalculateThunderPosition_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ThunderGenerator_C.__CalculateThunderPosition_NativeFunctionPtr, (void*)ptr, 1);
			ptr->CameraTransform = CameraTransform;
			ptr->OutPosition = OutPosition;
			ptr->bAttack = bAttack;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ThunderGenerator_C.__CalculateThunderPosition_NativeFunctionPtr, (void*)ptr);
			OutPosition = ptr->OutPosition;
			return ptr->__Result;
		}

		// Token: 0x0601FC78 RID: 130168 RVA: 0x008C24EC File Offset: 0x008C06EC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override bool CalculateThunderPosition_Implementation(in FTransform CameraTransform, ref FVector OutPosition, bool bAttack)
		{
			BP_ThunderGenerator_C.__CalculateThunderPosition_FunctionParams* ptr = stackalloc BP_ThunderGenerator_C.__CalculateThunderPosition_FunctionParams[(UIntPtr)111] + 15L / (long)sizeof(BP_ThunderGenerator_C.__CalculateThunderPosition_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ThunderGenerator_C.__CalculateThunderPosition_NativeFunctionPtr, (void*)ptr, 1);
			ptr->CameraTransform = CameraTransform;
			ptr->OutPosition = OutPosition;
			ptr->bAttack = bAttack;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_ThunderGenerator_C.__CalculateThunderPosition_NativeFunctionPtr, (void*)ptr, 0);
			OutPosition = ptr->OutPosition;
			return ptr->__Result;
		}

		// Token: 0x0601FC79 RID: 130169 RVA: 0x008C255D File Offset: 0x008C075D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void ClearThunder()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ThunderGenerator_C.__ClearThunder_NativeFunctionPtr, null);
		}

		// Token: 0x0601FC7A RID: 130170 RVA: 0x008C2571 File Offset: 0x008C0771
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateAudio2D()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ThunderGenerator_C.__UpdateAudio2D_NativeFunctionPtr, null);
		}

		// Token: 0x0601FC7B RID: 130171 RVA: 0x008C2585 File Offset: 0x008C0785
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ThunderGenerator_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601FC7C RID: 130172 RVA: 0x008C2599 File Offset: 0x008C0799
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_ThunderGenerator_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601FC7D RID: 130173 RVA: 0x008C25B0 File Offset: 0x008C07B0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void OnReceiveThunderAttack(FVector Location, bool bAttack)
		{
			BP_ThunderGenerator_C.__OnReceiveThunderAttack_FunctionParams* ptr = stackalloc BP_ThunderGenerator_C.__OnReceiveThunderAttack_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(BP_ThunderGenerator_C.__OnReceiveThunderAttack_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ThunderGenerator_C.__OnReceiveThunderAttack_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Location = Location;
			ptr->bAttack = bAttack;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ThunderGenerator_C.__OnReceiveThunderAttack_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601FC7E RID: 130174 RVA: 0x008C2600 File Offset: 0x008C0800
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void OnReceiveThunderAttack_Implementation(FVector Location, bool bAttack)
		{
			BP_ThunderGenerator_C.__OnReceiveThunderAttack_FunctionParams* ptr = stackalloc BP_ThunderGenerator_C.__OnReceiveThunderAttack_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(BP_ThunderGenerator_C.__OnReceiveThunderAttack_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ThunderGenerator_C.__OnReceiveThunderAttack_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Location = Location;
			ptr->bAttack = bAttack;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_ThunderGenerator_C.__OnReceiveThunderAttack_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601FC7F RID: 130175 RVA: 0x008C2650 File Offset: 0x008C0850
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void OnUpdateThunderEffect(float DeltaSeconds)
		{
			BP_ThunderGenerator_C.__OnUpdateThunderEffect_FunctionParams* ptr = stackalloc BP_ThunderGenerator_C.__OnUpdateThunderEffect_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_ThunderGenerator_C.__OnUpdateThunderEffect_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ThunderGenerator_C.__OnUpdateThunderEffect_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ThunderGenerator_C.__OnUpdateThunderEffect_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601FC80 RID: 130176 RVA: 0x008C2698 File Offset: 0x008C0898
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void OnUpdateThunderEffect_Implementation(float DeltaSeconds)
		{
			BP_ThunderGenerator_C.__OnUpdateThunderEffect_FunctionParams* ptr = stackalloc BP_ThunderGenerator_C.__OnUpdateThunderEffect_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_ThunderGenerator_C.__OnUpdateThunderEffect_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ThunderGenerator_C.__OnUpdateThunderEffect_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_ThunderGenerator_C.__OnUpdateThunderEffect_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601FC81 RID: 130177 RVA: 0x008C26E0 File Offset: 0x008C08E0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
		{
			BP_ThunderGenerator_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_ThunderGenerator_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_ThunderGenerator_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ThunderGenerator_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ThunderGenerator_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601FC82 RID: 130178 RVA: 0x008C272C File Offset: 0x008C092C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
		{
			BP_ThunderGenerator_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_ThunderGenerator_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_ThunderGenerator_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ThunderGenerator_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_ThunderGenerator_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601FC83 RID: 130179 RVA: 0x008C2778 File Offset: 0x008C0978
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void OnReceiveThunderTrigger(AThunderTrigger Trigger, in FTransform CameraTransform)
		{
			BP_ThunderGenerator_C.__OnReceiveThunderTrigger_FunctionParams* ptr = stackalloc BP_ThunderGenerator_C.__OnReceiveThunderTrigger_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(BP_ThunderGenerator_C.__OnReceiveThunderTrigger_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ThunderGenerator_C.__OnReceiveThunderTrigger_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Trigger = ((Trigger != null) ? Trigger.NativePtr : IntPtr.Zero);
			ptr->CameraTransform = CameraTransform;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ThunderGenerator_C.__OnReceiveThunderTrigger_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601FC84 RID: 130180 RVA: 0x008C27DC File Offset: 0x008C09DC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void OnReceiveThunderTrigger_Implementation(AThunderTrigger Trigger, in FTransform CameraTransform)
		{
			BP_ThunderGenerator_C.__OnReceiveThunderTrigger_FunctionParams* ptr = stackalloc BP_ThunderGenerator_C.__OnReceiveThunderTrigger_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(BP_ThunderGenerator_C.__OnReceiveThunderTrigger_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ThunderGenerator_C.__OnReceiveThunderTrigger_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Trigger = ((Trigger != null) ? Trigger.NativePtr : IntPtr.Zero);
			ptr->CameraTransform = CameraTransform;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_ThunderGenerator_C.__OnReceiveThunderTrigger_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601FC85 RID: 130181 RVA: 0x008C283E File Offset: 0x008C0A3E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void OnThunderTypeChanged()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ThunderGenerator_C.__OnThunderTypeChanged_NativeFunctionPtr, null);
		}

		// Token: 0x0601FC86 RID: 130182 RVA: 0x008C2852 File Offset: 0x008C0A52
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void OnThunderTypeChanged_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_ThunderGenerator_C.__OnThunderTypeChanged_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601FC87 RID: 130183 RVA: 0x008C2867 File Offset: 0x008C0A67
		protected BP_ThunderGenerator_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F4ED RID: 62701
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Weather/BP/Thunder/BP_ThunderGenerator.BP_ThunderGenerator_C";

		// Token: 0x0400F4EE RID: 62702
		private static IntPtr _ClassPtr;

		// Token: 0x0400F4EF RID: 62703
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F4F0 RID: 62704
		internal static int __PropertyOffset_1;

		// Token: 0x0400F4F1 RID: 62705
		internal static int __PropertyOffset_2;

		// Token: 0x0400F4F2 RID: 62706
		internal static int __PropertyOffset_3;

		// Token: 0x0400F4F3 RID: 62707
		internal static int __PropertyOffset_4;

		// Token: 0x0400F4F4 RID: 62708
		internal static int __PropertyOffset_5;

		// Token: 0x0400F4F5 RID: 62709
		internal static int __PropertyOffset_6;

		// Token: 0x0400F4F6 RID: 62710
		internal static int __PropertyOffset_7;

		// Token: 0x0400F4F7 RID: 62711
		internal static int __PropertyOffset_8;

		// Token: 0x0400F4F8 RID: 62712
		internal static int __PropertyOffset_9;

		// Token: 0x0400F4F9 RID: 62713
		internal static int __PropertyOffset_10;

		// Token: 0x0400F4FA RID: 62714
		internal static int __PropertyOffset_11;

		// Token: 0x0400F4FB RID: 62715
		internal static int __PropertyOffset_12;

		// Token: 0x0400F4FC RID: 62716
		internal static int __PropertyOffset_13;

		// Token: 0x0400F4FD RID: 62717
		internal static int __PropertyOffset_14;

		// Token: 0x0400F4FE RID: 62718
		internal static int __PropertyOffset_15;

		// Token: 0x0400F4FF RID: 62719
		private static IntPtr __UpdateCloudThunderParameter_NativeFunctionPtr;

		// Token: 0x0400F500 RID: 62720
		private static IntPtr __CalculateThunderPosition_Cloud_NativeFunctionPtr;

		// Token: 0x0400F501 RID: 62721
		private static IntPtr __ForceUpdate_NativeFunctionPtr;

		// Token: 0x0400F502 RID: 62722
		private static IntPtr __CalculateThunderPosition_Common_NativeFunctionPtr;

		// Token: 0x0400F503 RID: 62723
		private static IntPtr __CalculateThunderPosition_NativeFunctionPtr;

		// Token: 0x0400F504 RID: 62724
		private static IntPtr __ClearThunder_NativeFunctionPtr;

		// Token: 0x0400F505 RID: 62725
		private static IntPtr __UpdateAudio2D_NativeFunctionPtr;

		// Token: 0x0400F506 RID: 62726
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0400F507 RID: 62727
		private static IntPtr __OnReceiveThunderAttack_NativeFunctionPtr;

		// Token: 0x0400F508 RID: 62728
		private static IntPtr __OnUpdateThunderEffect_NativeFunctionPtr;

		// Token: 0x0400F509 RID: 62729
		private static IntPtr __ReceiveEndPlay_NativeFunctionPtr;

		// Token: 0x0400F50A RID: 62730
		private static IntPtr __OnReceiveThunderTrigger_NativeFunctionPtr;

		// Token: 0x0400F50B RID: 62731
		private static IntPtr __OnThunderTypeChanged_NativeFunctionPtr;

		// Token: 0x02009B4C RID: 39756
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 208)]
		protected ref struct __CalculateThunderPosition_Cloud_FunctionParams
		{
			// Token: 0x04031165 RID: 201061
			[FieldOffset(0)]
			public FTransform CameraTransform;

			// Token: 0x04031166 RID: 201062
			[FieldOffset(48)]
			public bool bAttack;

			// Token: 0x04031167 RID: 201063
			[FieldOffset(52)]
			public FVector OutPosition;

			// Token: 0x04031168 RID: 201064
			[FieldOffset(64)]
			public bool __Result;
		}

		// Token: 0x02009B4D RID: 39757
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 160)]
		protected ref struct __CalculateThunderPosition_Common_FunctionParams
		{
			// Token: 0x04031169 RID: 201065
			[FieldOffset(0)]
			public FTransform CameraTransform;

			// Token: 0x0403116A RID: 201066
			[FieldOffset(48)]
			public bool bAttack;

			// Token: 0x0403116B RID: 201067
			[FieldOffset(52)]
			public FVector OutPosition;

			// Token: 0x0403116C RID: 201068
			[FieldOffset(64)]
			public bool __Result;
		}

		// Token: 0x02009B4E RID: 39758
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 96)]
		protected new ref struct __CalculateThunderPosition_FunctionParams
		{
			// Token: 0x0403116D RID: 201069
			[FieldOffset(0)]
			public FTransform CameraTransform;

			// Token: 0x0403116E RID: 201070
			[FieldOffset(48)]
			public FVector OutPosition;

			// Token: 0x0403116F RID: 201071
			[FieldOffset(60)]
			public bool bAttack;

			// Token: 0x04031170 RID: 201072
			[FieldOffset(61)]
			public bool __Result;
		}

		// Token: 0x02009B4F RID: 39759
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected new ref struct __OnReceiveThunderAttack_FunctionParams
		{
			// Token: 0x04031171 RID: 201073
			[FieldOffset(0)]
			public FVector Location;

			// Token: 0x04031172 RID: 201074
			[FieldOffset(12)]
			public bool bAttack;
		}

		// Token: 0x02009B50 RID: 39760
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __OnUpdateThunderEffect_FunctionParams
		{
			// Token: 0x04031173 RID: 201075
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009B51 RID: 39761
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __ReceiveEndPlay_FunctionParams
		{
			// Token: 0x04031174 RID: 201076
			[FieldOffset(0)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}

		// Token: 0x02009B52 RID: 39762
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected new ref struct __OnReceiveThunderTrigger_FunctionParams
		{
			// Token: 0x04031175 RID: 201077
			[FieldOffset(0)]
			public IntPtr Trigger;

			// Token: 0x04031176 RID: 201078
			[FieldOffset(16)]
			public FTransform CameraTransform;
		}
	}
}

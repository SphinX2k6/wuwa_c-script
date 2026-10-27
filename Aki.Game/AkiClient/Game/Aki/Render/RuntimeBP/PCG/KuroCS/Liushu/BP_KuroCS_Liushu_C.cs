using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.KuroCS.Liushu
{
	// Token: 0x02003C8A RID: 15498
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/KuroCS/Liushu/BP_KuroCS_Liushu.BP_KuroCS_Liushu_C")]
	[UnrealStructLayout(2024, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2018)]
	public class BP_KuroCS_Liushu_C : AKuroCS_liuShu, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060242F8 RID: 148216 RVA: 0x0093743C File Offset: 0x0093563C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_KuroCS_Liushu_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/KuroCS/Liushu/BP_KuroCS_Liushu.BP_KuroCS_Liushu_C");
			}
			return BP_KuroCS_Liushu_C._ClassPtr;
		}

		// Token: 0x060242F9 RID: 148217 RVA: 0x00937460 File Offset: 0x00935660
		public BP_KuroCS_Liushu_C() : this(BuiltinUtils.AllocNativeUObject(BP_KuroCS_Liushu_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060242FA RID: 148218 RVA: 0x00937488 File Offset: 0x00935688
		public BP_KuroCS_Liushu_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_KuroCS_Liushu_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170045B3 RID: 17843
		// (get) Token: 0x060242FB RID: 148219 RVA: 0x009374BB File Offset: 0x009356BB
		// (set) Token: 0x060242FC RID: 148220 RVA: 0x009374CF File Offset: 0x009356CF
		[Nullable(2)]
		public unsafe UStaticMeshComponent PlantMeshXZ
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCS_Liushu_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCS_Liushu_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170045B4 RID: 17844
		// (get) Token: 0x060242FD RID: 148221 RVA: 0x009374E4 File Offset: 0x009356E4
		// (set) Token: 0x060242FE RID: 148222 RVA: 0x009374F8 File Offset: 0x009356F8
		[Nullable(2)]
		public unsafe UBoxComponent ValidBox
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCS_Liushu_C.__PropertyOffset_2);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCS_Liushu_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x170045B5 RID: 17845
		// (get) Token: 0x060242FF RID: 148223 RVA: 0x0093750D File Offset: 0x0093570D
		// (set) Token: 0x06024300 RID: 148224 RVA: 0x00937521 File Offset: 0x00935721
		[Nullable(2)]
		public unsafe UDataTable dataTable
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UDataTable>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCS_Liushu_C.__PropertyOffset_3);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCS_Liushu_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x170045B6 RID: 17846
		// (get) Token: 0x06024301 RID: 148225 RVA: 0x00937536 File Offset: 0x00935736
		// (set) Token: 0x06024302 RID: 148226 RVA: 0x00937546 File Offset: 0x00935746
		public unsafe bool bEnable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCS_Liushu_C.__PropertyOffset_4) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCS_Liushu_C.__PropertyOffset_4) = (value ? 1 : 0);
			}
		}

		// Token: 0x170045B7 RID: 17847
		// (get) Token: 0x06024303 RID: 148227 RVA: 0x00937557 File Offset: 0x00935757
		// (set) Token: 0x06024304 RID: 148228 RVA: 0x00937567 File Offset: 0x00935767
		public unsafe bool bDrawDebug
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCS_Liushu_C.__PropertyOffset_5) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCS_Liushu_C.__PropertyOffset_5) = (value ? 1 : 0);
			}
		}

		// Token: 0x170045B8 RID: 17848
		// (get) Token: 0x06024305 RID: 148229 RVA: 0x00937578 File Offset: 0x00935778
		// (set) Token: 0x06024306 RID: 148230 RVA: 0x00937588 File Offset: 0x00935788
		public unsafe float WindForceMulti
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCS_Liushu_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCS_Liushu_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x170045B9 RID: 17849
		// (get) Token: 0x06024307 RID: 148231 RVA: 0x00937599 File Offset: 0x00935799
		// (set) Token: 0x06024308 RID: 148232 RVA: 0x009375A9 File Offset: 0x009357A9
		public unsafe bool InitOverlap
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCS_Liushu_C.__PropertyOffset_7) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCS_Liushu_C.__PropertyOffset_7) = (value ? 1 : 0);
			}
		}

		// Token: 0x170045BA RID: 17850
		// (get) Token: 0x06024309 RID: 148233 RVA: 0x009375BA File Offset: 0x009357BA
		// (set) Token: 0x0602430A RID: 148234 RVA: 0x009375CA File Offset: 0x009357CA
		public unsafe float FadeOut
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCS_Liushu_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCS_Liushu_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x170045BB RID: 17851
		// (get) Token: 0x0602430B RID: 148235 RVA: 0x009375DB File Offset: 0x009357DB
		// (set) Token: 0x0602430C RID: 148236 RVA: 0x009375EB File Offset: 0x009357EB
		public unsafe bool bFadeOut
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCS_Liushu_C.__PropertyOffset_9) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCS_Liushu_C.__PropertyOffset_9) = (value ? 1 : 0);
			}
		}

		// Token: 0x170045BC RID: 17852
		// (get) Token: 0x0602430D RID: 148237 RVA: 0x009375FC File Offset: 0x009357FC
		// (set) Token: 0x0602430E RID: 148238 RVA: 0x0093760C File Offset: 0x0093580C
		public unsafe bool bStopSim
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCS_Liushu_C.__PropertyOffset_10) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCS_Liushu_C.__PropertyOffset_10) = (value ? 1 : 0);
			}
		}

		// Token: 0x170045BD RID: 17853
		// (get) Token: 0x0602430F RID: 148239 RVA: 0x0093761D File Offset: 0x0093581D
		// (set) Token: 0x06024310 RID: 148240 RVA: 0x0093762D File Offset: 0x0093582D
		public unsafe bool bInit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCS_Liushu_C.__PropertyOffset_11) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCS_Liushu_C.__PropertyOffset_11) = (value ? 1 : 0);
			}
		}

		// Token: 0x170045BE RID: 17854
		// (get) Token: 0x06024311 RID: 148241 RVA: 0x00937640 File Offset: 0x00935840
		// (set) Token: 0x06024312 RID: 148242 RVA: 0x00937679 File Offset: 0x00935879
		public TMap<FName, float> Scalar_Parameters
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, float> result;
				if ((result = this._Scalar_Parameters) == null)
				{
					result = (this._Scalar_Parameters = new TMap<FName, float>(base.NativePtr + (IntPtr)BP_KuroCS_Liushu_C.__PropertyOffset_12, this));
				}
				return result;
			}
			set
			{
				this.Scalar_Parameters.CopyAssign(value);
			}
		}

		// Token: 0x170045BF RID: 17855
		// (get) Token: 0x06024313 RID: 148243 RVA: 0x00937688 File Offset: 0x00935888
		// (set) Token: 0x06024314 RID: 148244 RVA: 0x009376C1 File Offset: 0x009358C1
		public TArray<UMaterialInstanceDynamic> MDIMats
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInstanceDynamic> result;
				if ((result = this._MDIMats) == null)
				{
					result = (this._MDIMats = new TArray<UMaterialInstanceDynamic>(base.NativePtr + (IntPtr)BP_KuroCS_Liushu_C.__PropertyOffset_13, this));
				}
				return result;
			}
			set
			{
				this.MDIMats.CopyAssign(value);
			}
		}

		// Token: 0x170045C0 RID: 17856
		// (get) Token: 0x06024315 RID: 148245 RVA: 0x009376CF File Offset: 0x009358CF
		// (set) Token: 0x06024316 RID: 148246 RVA: 0x009376DF File Offset: 0x009358DF
		public unsafe float CollisionWolrd
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCS_Liushu_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCS_Liushu_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x170045C1 RID: 17857
		// (get) Token: 0x06024317 RID: 148247 RVA: 0x009376F0 File Offset: 0x009358F0
		// (set) Token: 0x06024318 RID: 148248 RVA: 0x00937729 File Offset: 0x00935929
		public TMap<FName, FLinearColor> Vector_Parameters
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FLinearColor> result;
				if ((result = this._Vector_Parameters) == null)
				{
					result = (this._Vector_Parameters = new TMap<FName, FLinearColor>(base.NativePtr + (IntPtr)BP_KuroCS_Liushu_C.__PropertyOffset_15, this));
				}
				return result;
			}
			set
			{
				this.Vector_Parameters.CopyAssign(value);
			}
		}

		// Token: 0x170045C2 RID: 17858
		// (get) Token: 0x06024319 RID: 148249 RVA: 0x00937738 File Offset: 0x00935938
		// (set) Token: 0x0602431A RID: 148250 RVA: 0x00937771 File Offset: 0x00935971
		public TMap<FName, UTexture> Texture_Parameters
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, UTexture> result;
				if ((result = this._Texture_Parameters) == null)
				{
					result = (this._Texture_Parameters = new TMap<FName, UTexture>(base.NativePtr + (IntPtr)BP_KuroCS_Liushu_C.__PropertyOffset_16, this));
				}
				return result;
			}
			set
			{
				this.Texture_Parameters.CopyAssign(value);
			}
		}

		// Token: 0x170045C3 RID: 17859
		// (get) Token: 0x0602431B RID: 148251 RVA: 0x00937780 File Offset: 0x00935980
		// (set) Token: 0x0602431C RID: 148252 RVA: 0x009377B9 File Offset: 0x009359B9
		public TMap<TSoftObjectPtr<UStaticMesh>, S_LiushuPreset> MeshPreset
		{
			get
			{
				base.FastCheckIsValid();
				TMap<TSoftObjectPtr<UStaticMesh>, S_LiushuPreset> result;
				if ((result = this._MeshPreset) == null)
				{
					result = (this._MeshPreset = new TMap<TSoftObjectPtr<UStaticMesh>, S_LiushuPreset>(base.NativePtr + (IntPtr)BP_KuroCS_Liushu_C.__PropertyOffset_17, this));
				}
				return result;
			}
			set
			{
				this.MeshPreset.CopyAssign(value);
			}
		}

		// Token: 0x170045C4 RID: 17860
		// (get) Token: 0x0602431D RID: 148253 RVA: 0x009377C8 File Offset: 0x009359C8
		// (set) Token: 0x0602431E RID: 148254 RVA: 0x00937801 File Offset: 0x00935A01
		public TArray<UMaterialInterface> MatCache
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInterface> result;
				if ((result = this._MatCache) == null)
				{
					result = (this._MatCache = new TArray<UMaterialInterface>(base.NativePtr + (IntPtr)BP_KuroCS_Liushu_C.__PropertyOffset_18, this));
				}
				return result;
			}
			set
			{
				this.MatCache.CopyAssign(value);
			}
		}

		// Token: 0x170045C5 RID: 17861
		// (get) Token: 0x0602431F RID: 148255 RVA: 0x0093780F File Offset: 0x00935A0F
		// (set) Token: 0x06024320 RID: 148256 RVA: 0x0093781F File Offset: 0x00935A1F
		public unsafe float FadeSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCS_Liushu_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCS_Liushu_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x170045C6 RID: 17862
		// (get) Token: 0x06024321 RID: 148257 RVA: 0x00937830 File Offset: 0x00935A30
		// (set) Token: 0x06024322 RID: 148258 RVA: 0x00937840 File Offset: 0x00935A40
		public unsafe float LastCustomDeltaTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCS_Liushu_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCS_Liushu_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x170045C7 RID: 17863
		// (get) Token: 0x06024323 RID: 148259 RVA: 0x00937851 File Offset: 0x00935A51
		// (set) Token: 0x06024324 RID: 148260 RVA: 0x00937861 File Offset: 0x00935A61
		public unsafe int NowQuality
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCS_Liushu_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCS_Liushu_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x170045C8 RID: 17864
		// (get) Token: 0x06024325 RID: 148261 RVA: 0x00937872 File Offset: 0x00935A72
		// (set) Token: 0x06024326 RID: 148262 RVA: 0x00937882 File Offset: 0x00935A82
		public unsafe float WorldScaleX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCS_Liushu_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCS_Liushu_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x170045C9 RID: 17865
		// (get) Token: 0x06024327 RID: 148263 RVA: 0x00937893 File Offset: 0x00935A93
		// (set) Token: 0x06024328 RID: 148264 RVA: 0x009378A3 File Offset: 0x00935AA3
		public unsafe bool bOnlyForHighQuality
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCS_Liushu_C.__PropertyOffset_23) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCS_Liushu_C.__PropertyOffset_23) = (value ? 1 : 0);
			}
		}

		// Token: 0x170045CA RID: 17866
		// (get) Token: 0x06024329 RID: 148265 RVA: 0x009378B4 File Offset: 0x00935AB4
		// (set) Token: 0x0602432A RID: 148266 RVA: 0x009378C4 File Offset: 0x00935AC4
		public unsafe bool bInMoto
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCS_Liushu_C.__PropertyOffset_24) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCS_Liushu_C.__PropertyOffset_24) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602432B RID: 148267 RVA: 0x009378D5 File Offset: 0x00935AD5
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void CenterBound()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCS_Liushu_C.__CenterBound_NativeFunctionPtr, null);
		}

		// Token: 0x0602432C RID: 148268 RVA: 0x009378E9 File Offset: 0x00935AE9
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void FillParticles()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCS_Liushu_C.__FillParticles_NativeFunctionPtr, null);
		}

		// Token: 0x0602432D RID: 148269 RVA: 0x00937900 File Offset: 0x00935B00
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void LoadPreset(ref bool NewParam)
		{
			BP_KuroCS_Liushu_C.__LoadPreset_FunctionParams* ptr = stackalloc BP_KuroCS_Liushu_C.__LoadPreset_FunctionParams[(UIntPtr)191] + 15L / (long)sizeof(BP_KuroCS_Liushu_C.__LoadPreset_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroCS_Liushu_C.__LoadPreset_NativeFunctionPtr, (void*)ptr, 1);
			ptr->NewParam = NewParam;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCS_Liushu_C.__LoadPreset_NativeFunctionPtr, (void*)ptr);
			NewParam = ptr->NewParam;
		}

		// Token: 0x0602432E RID: 148270 RVA: 0x00937952 File Offset: 0x00935B52
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void ApplyMDI()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCS_Liushu_C.__ApplyMDI_NativeFunctionPtr, null);
		}

		// Token: 0x0602432F RID: 148271 RVA: 0x00937966 File Offset: 0x00935B66
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void RevertMat()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCS_Liushu_C.__RevertMat_NativeFunctionPtr, null);
		}

		// Token: 0x06024330 RID: 148272 RVA: 0x0093797A File Offset: 0x00935B7A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void InitRT()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCS_Liushu_C.__InitRT_NativeFunctionPtr, null);
		}

		// Token: 0x06024331 RID: 148273 RVA: 0x0093798E File Offset: 0x00935B8E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void InitMats()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCS_Liushu_C.__InitMats_NativeFunctionPtr, null);
		}

		// Token: 0x06024332 RID: 148274 RVA: 0x009379A2 File Offset: 0x00935BA2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateMaterialParams()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCS_Liushu_C.__UpdateMaterialParams_NativeFunctionPtr, null);
		}

		// Token: 0x06024333 RID: 148275 RVA: 0x009379B6 File Offset: 0x00935BB6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCS_Liushu_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06024334 RID: 148276 RVA: 0x009379CA File Offset: 0x00935BCA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroCS_Liushu_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06024335 RID: 148277 RVA: 0x009379DF File Offset: 0x00935BDF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCS_Liushu_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06024336 RID: 148278 RVA: 0x009379F3 File Offset: 0x00935BF3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroCS_Liushu_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06024337 RID: 148279 RVA: 0x00937A08 File Offset: 0x00935C08
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_KuroCS_Liushu_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_KuroCS_Liushu_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_KuroCS_Liushu_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroCS_Liushu_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCS_Liushu_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06024338 RID: 148280 RVA: 0x00937A50 File Offset: 0x00935C50
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_KuroCS_Liushu_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_KuroCS_Liushu_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_KuroCS_Liushu_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroCS_Liushu_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroCS_Liushu_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06024339 RID: 148281 RVA: 0x00937A98 File Offset: 0x00935C98
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
		{
			BP_KuroCS_Liushu_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_KuroCS_Liushu_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_KuroCS_Liushu_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroCS_Liushu_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCS_Liushu_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602433A RID: 148282 RVA: 0x00937AE4 File Offset: 0x00935CE4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
		{
			BP_KuroCS_Liushu_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_KuroCS_Liushu_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_KuroCS_Liushu_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroCS_Liushu_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroCS_Liushu_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602433B RID: 148283 RVA: 0x00937B30 File Offset: 0x00935D30
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_KuroCSCloth_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, in FHitResult SweepResult)
		{
			BP_KuroCS_Liushu_C.__BndEvt__BP_KuroCSCloth_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_KuroCS_Liushu_C.__BndEvt__BP_KuroCSCloth_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(BP_KuroCS_Liushu_C.__BndEvt__BP_KuroCSCloth_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroCS_Liushu_C.__BndEvt__BP_KuroCSCloth_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			ptr->bFromSweep = bFromSweep;
			if (SweepResult != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->SweepResult, SweepResult.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCS_Liushu_C.__BndEvt__BP_KuroCSCloth_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602433C RID: 148284 RVA: 0x00937BEC File Offset: 0x00935DEC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_KuroCSCloth_ValidBox_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex)
		{
			BP_KuroCS_Liushu_C.__BndEvt__BP_KuroCSCloth_ValidBox_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_KuroCS_Liushu_C.__BndEvt__BP_KuroCSCloth_ValidBox_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_KuroCS_Liushu_C.__BndEvt__BP_KuroCSCloth_ValidBox_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroCS_Liushu_C.__BndEvt__BP_KuroCSCloth_ValidBox_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCS_Liushu_C.__BndEvt__BP_KuroCSCloth_ValidBox_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602433D RID: 148285 RVA: 0x00937C75 File Offset: 0x00935E75
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateQualitySwitch()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCS_Liushu_C.__UpdateQualitySwitch_NativeFunctionPtr, null);
		}

		// Token: 0x0602433E RID: 148286 RVA: 0x00937C89 File Offset: 0x00935E89
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void BeforeCookForMobile()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCS_Liushu_C.__BeforeCookForMobile_NativeFunctionPtr, null);
		}

		// Token: 0x0602433F RID: 148287 RVA: 0x00937C9D File Offset: 0x00935E9D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void BeforeCookForMobile_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroCS_Liushu_C.__BeforeCookForMobile_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06024340 RID: 148288 RVA: 0x00937CB2 File Offset: 0x00935EB2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void BeforeCookForPC()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCS_Liushu_C.__BeforeCookForPC_NativeFunctionPtr, null);
		}

		// Token: 0x06024341 RID: 148289 RVA: 0x00937CC6 File Offset: 0x00935EC6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void BeforeCookForPC_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroCS_Liushu_C.__BeforeCookForPC_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06024342 RID: 148290 RVA: 0x00937CDB File Offset: 0x00935EDB
		protected BP_KuroCS_Liushu_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011EC5 RID: 73413
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/KuroCS/Liushu/BP_KuroCS_Liushu.BP_KuroCS_Liushu_C";

		// Token: 0x04011EC6 RID: 73414
		private static IntPtr _ClassPtr;

		// Token: 0x04011EC7 RID: 73415
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011EC8 RID: 73416
		internal static int __PropertyOffset_1;

		// Token: 0x04011EC9 RID: 73417
		internal static int __PropertyOffset_2;

		// Token: 0x04011ECA RID: 73418
		internal static int __PropertyOffset_3;

		// Token: 0x04011ECB RID: 73419
		internal static int __PropertyOffset_4;

		// Token: 0x04011ECC RID: 73420
		internal static int __PropertyOffset_5;

		// Token: 0x04011ECD RID: 73421
		internal static int __PropertyOffset_6;

		// Token: 0x04011ECE RID: 73422
		internal static int __PropertyOffset_7;

		// Token: 0x04011ECF RID: 73423
		internal static int __PropertyOffset_8;

		// Token: 0x04011ED0 RID: 73424
		internal static int __PropertyOffset_9;

		// Token: 0x04011ED1 RID: 73425
		internal static int __PropertyOffset_10;

		// Token: 0x04011ED2 RID: 73426
		internal static int __PropertyOffset_11;

		// Token: 0x04011ED3 RID: 73427
		internal static int __PropertyOffset_12;

		// Token: 0x04011ED4 RID: 73428
		[Nullable(2)]
		private TMap<FName, float> _Scalar_Parameters;

		// Token: 0x04011ED5 RID: 73429
		internal static int __PropertyOffset_13;

		// Token: 0x04011ED6 RID: 73430
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstanceDynamic> _MDIMats;

		// Token: 0x04011ED7 RID: 73431
		internal static int __PropertyOffset_14;

		// Token: 0x04011ED8 RID: 73432
		internal static int __PropertyOffset_15;

		// Token: 0x04011ED9 RID: 73433
		[Nullable(2)]
		private TMap<FName, FLinearColor> _Vector_Parameters;

		// Token: 0x04011EDA RID: 73434
		internal static int __PropertyOffset_16;

		// Token: 0x04011EDB RID: 73435
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, UTexture> _Texture_Parameters;

		// Token: 0x04011EDC RID: 73436
		internal static int __PropertyOffset_17;

		// Token: 0x04011EDD RID: 73437
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		private TMap<TSoftObjectPtr<UStaticMesh>, S_LiushuPreset> _MeshPreset;

		// Token: 0x04011EDE RID: 73438
		internal static int __PropertyOffset_18;

		// Token: 0x04011EDF RID: 73439
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInterface> _MatCache;

		// Token: 0x04011EE0 RID: 73440
		internal static int __PropertyOffset_19;

		// Token: 0x04011EE1 RID: 73441
		internal static int __PropertyOffset_20;

		// Token: 0x04011EE2 RID: 73442
		internal static int __PropertyOffset_21;

		// Token: 0x04011EE3 RID: 73443
		internal static int __PropertyOffset_22;

		// Token: 0x04011EE4 RID: 73444
		internal static int __PropertyOffset_23;

		// Token: 0x04011EE5 RID: 73445
		internal static int __PropertyOffset_24;

		// Token: 0x04011EE6 RID: 73446
		private static IntPtr __CenterBound_NativeFunctionPtr;

		// Token: 0x04011EE7 RID: 73447
		private static IntPtr __FillParticles_NativeFunctionPtr;

		// Token: 0x04011EE8 RID: 73448
		private static IntPtr __LoadPreset_NativeFunctionPtr;

		// Token: 0x04011EE9 RID: 73449
		private static IntPtr __ApplyMDI_NativeFunctionPtr;

		// Token: 0x04011EEA RID: 73450
		private static IntPtr __RevertMat_NativeFunctionPtr;

		// Token: 0x04011EEB RID: 73451
		private static IntPtr __InitRT_NativeFunctionPtr;

		// Token: 0x04011EEC RID: 73452
		private static IntPtr __InitMats_NativeFunctionPtr;

		// Token: 0x04011EED RID: 73453
		private static IntPtr __UpdateMaterialParams_NativeFunctionPtr;

		// Token: 0x04011EEE RID: 73454
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04011EEF RID: 73455
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04011EF0 RID: 73456
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04011EF1 RID: 73457
		private static IntPtr __ReceiveEndPlay_NativeFunctionPtr;

		// Token: 0x04011EF2 RID: 73458
		private static IntPtr __BndEvt__BP_KuroCSCloth_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04011EF3 RID: 73459
		private static IntPtr __BndEvt__BP_KuroCSCloth_ValidBox_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04011EF4 RID: 73460
		private static IntPtr __UpdateQualitySwitch_NativeFunctionPtr;

		// Token: 0x04011EF5 RID: 73461
		private static IntPtr __BeforeCookForMobile_NativeFunctionPtr;

		// Token: 0x04011EF6 RID: 73462
		private static IntPtr __BeforeCookForPC_NativeFunctionPtr;

		// Token: 0x02009EE2 RID: 40674
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 176)]
		protected ref struct __LoadPreset_FunctionParams
		{
			// Token: 0x040317E0 RID: 202720
			[FieldOffset(0)]
			public bool NewParam;
		}

		// Token: 0x02009EE3 RID: 40675
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040317E1 RID: 202721
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009EE4 RID: 40676
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __ReceiveEndPlay_FunctionParams
		{
			// Token: 0x040317E2 RID: 202722
			[FieldOffset(0)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}

		// Token: 0x02009EE5 RID: 40677
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __BndEvt__BP_KuroCSCloth_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x040317E3 RID: 202723
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x040317E4 RID: 202724
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x040317E5 RID: 202725
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x040317E6 RID: 202726
			[FieldOffset(24)]
			public int OtherBodyIndex;

			// Token: 0x040317E7 RID: 202727
			[FieldOffset(28)]
			public bool bFromSweep;

			// Token: 0x040317E8 RID: 202728
			[FieldOffset(32)]
			public byte SweepResult;
		}

		// Token: 0x02009EE6 RID: 40678
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __BndEvt__BP_KuroCSCloth_ValidBox_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x040317E9 RID: 202729
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x040317EA RID: 202730
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x040317EB RID: 202731
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x040317EC RID: 202732
			[FieldOffset(24)]
			public int OtherBodyIndex;
		}
	}
}

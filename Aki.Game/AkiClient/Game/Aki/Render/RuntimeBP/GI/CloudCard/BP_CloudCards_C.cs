using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.GI.CloudCard
{
	// Token: 0x02003D80 RID: 15744
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/GI/CloudCard/BP_CloudCards.BP_CloudCards_C")]
	[UnrealStructLayout(1304, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1300)]
	public class BP_CloudCards_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06026A47 RID: 158279 RVA: 0x0097A5E3 File Offset: 0x009787E3
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_CloudCards_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/GI/CloudCard/BP_CloudCards.BP_CloudCards_C");
			}
			return BP_CloudCards_C._ClassPtr;
		}

		// Token: 0x06026A48 RID: 158280 RVA: 0x0097A608 File Offset: 0x00978808
		public BP_CloudCards_C() : this(BuiltinUtils.AllocNativeUObject(BP_CloudCards_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06026A49 RID: 158281 RVA: 0x0097A630 File Offset: 0x00978830
		public BP_CloudCards_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_CloudCards_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700535B RID: 21339
		// (get) Token: 0x06026A4A RID: 158282 RVA: 0x0097A663 File Offset: 0x00978863
		// (set) Token: 0x06026A4B RID: 158283 RVA: 0x0097A677 File Offset: 0x00978877
		[Nullable(2)]
		public unsafe UBillboardComponent Billboard
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBillboardComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudCards_C.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudCards_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x1700535C RID: 21340
		// (get) Token: 0x06026A4C RID: 158284 RVA: 0x0097A68C File Offset: 0x0097888C
		// (set) Token: 0x06026A4D RID: 158285 RVA: 0x0097A6A0 File Offset: 0x009788A0
		[Nullable(2)]
		public unsafe USceneComponent Root
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudCards_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudCards_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x1700535D RID: 21341
		// (get) Token: 0x06026A4E RID: 158286 RVA: 0x0097A6B5 File Offset: 0x009788B5
		// (set) Token: 0x06026A4F RID: 158287 RVA: 0x0097A6C9 File Offset: 0x009788C9
		[Nullable(2)]
		public unsafe UStaticMeshComponent Plane
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudCards_C.__PropertyOffset_2);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudCards_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x1700535E RID: 21342
		// (get) Token: 0x06026A50 RID: 158288 RVA: 0x0097A6DE File Offset: 0x009788DE
		// (set) Token: 0x06026A51 RID: 158289 RVA: 0x0097A6F2 File Offset: 0x009788F2
		public unsafe FRotator InitRot
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudCards_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudCards_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x1700535F RID: 21343
		// (get) Token: 0x06026A52 RID: 158290 RVA: 0x0097A707 File Offset: 0x00978907
		// (set) Token: 0x06026A53 RID: 158291 RVA: 0x0097A717 File Offset: 0x00978917
		public unsafe float Dist
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudCards_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudCards_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17005360 RID: 21344
		// (get) Token: 0x06026A54 RID: 158292 RVA: 0x0097A728 File Offset: 0x00978928
		// (set) Token: 0x06026A55 RID: 158293 RVA: 0x0097A738 File Offset: 0x00978938
		public unsafe float DistScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudCards_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudCards_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17005361 RID: 21345
		// (get) Token: 0x06026A56 RID: 158294 RVA: 0x0097A749 File Offset: 0x00978949
		// (set) Token: 0x06026A57 RID: 158295 RVA: 0x0097A75D File Offset: 0x0097895D
		public unsafe FVector2D ScaleXY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudCards_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudCards_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17005362 RID: 21346
		// (get) Token: 0x06026A58 RID: 158296 RVA: 0x0097A772 File Offset: 0x00978972
		// (set) Token: 0x06026A59 RID: 158297 RVA: 0x0097A782 File Offset: 0x00978982
		public unsafe float Height
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudCards_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudCards_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17005363 RID: 21347
		// (get) Token: 0x06026A5A RID: 158298 RVA: 0x0097A794 File Offset: 0x00978994
		// (set) Token: 0x06026A5B RID: 158299 RVA: 0x0097A7CD File Offset: 0x009789CD
		public TArray<UStaticMeshComponent> CloudCardMeshComps
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UStaticMeshComponent> result;
				if ((result = this._CloudCardMeshComps) == null)
				{
					result = (this._CloudCardMeshComps = new TArray<UStaticMeshComponent>(base.NativePtr + (IntPtr)BP_CloudCards_C.__PropertyOffset_8, this));
				}
				return result;
			}
			set
			{
				this.CloudCardMeshComps.CopyAssign(value);
			}
		}

		// Token: 0x17005364 RID: 21348
		// (get) Token: 0x06026A5C RID: 158300 RVA: 0x0097A7DB File Offset: 0x009789DB
		// (set) Token: 0x06026A5D RID: 158301 RVA: 0x0097A7EB File Offset: 0x009789EB
		public unsafe float InitAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudCards_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudCards_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17005365 RID: 21349
		// (get) Token: 0x06026A5E RID: 158302 RVA: 0x0097A7FC File Offset: 0x009789FC
		// (set) Token: 0x06026A5F RID: 158303 RVA: 0x0097A80C File Offset: 0x00978A0C
		public unsafe float AngleSpace
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudCards_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudCards_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17005366 RID: 21350
		// (get) Token: 0x06026A60 RID: 158304 RVA: 0x0097A81D File Offset: 0x00978A1D
		// (set) Token: 0x06026A61 RID: 158305 RVA: 0x0097A82D File Offset: 0x00978A2D
		public unsafe int RandomSeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudCards_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudCards_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17005367 RID: 21351
		// (get) Token: 0x06026A62 RID: 158306 RVA: 0x0097A840 File Offset: 0x00978A40
		// (set) Token: 0x06026A63 RID: 158307 RVA: 0x0097A879 File Offset: 0x00978A79
		public TArray<UMaterialInstanceDynamic> CloudMIDs
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInstanceDynamic> result;
				if ((result = this._CloudMIDs) == null)
				{
					result = (this._CloudMIDs = new TArray<UMaterialInstanceDynamic>(base.NativePtr + (IntPtr)BP_CloudCards_C.__PropertyOffset_12, this));
				}
				return result;
			}
			set
			{
				this.CloudMIDs.CopyAssign(value);
			}
		}

		// Token: 0x17005368 RID: 21352
		// (get) Token: 0x06026A64 RID: 158308 RVA: 0x0097A887 File Offset: 0x00978A87
		// (set) Token: 0x06026A65 RID: 158309 RVA: 0x0097A897 File Offset: 0x00978A97
		public unsafe float RotSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudCards_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudCards_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17005369 RID: 21353
		// (get) Token: 0x06026A66 RID: 158310 RVA: 0x0097A8A8 File Offset: 0x00978AA8
		// (set) Token: 0x06026A67 RID: 158311 RVA: 0x0097A8E1 File Offset: 0x00978AE1
		public FTimerHandle TimerHandle
		{
			get
			{
				base.FastCheckIsValid();
				FTimerHandle result;
				if ((result = this._TimerHandle) == null)
				{
					result = (this._TimerHandle = new FTimerHandle(base.NativePtr + (IntPtr)BP_CloudCards_C.__PropertyOffset_14, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FTimerHandle.StaticStruct(), base.NativePtr + (IntPtr)BP_CloudCards_C.__PropertyOffset_14, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700536A RID: 21354
		// (get) Token: 0x06026A68 RID: 158312 RVA: 0x0097A904 File Offset: 0x00978B04
		// (set) Token: 0x06026A69 RID: 158313 RVA: 0x0097A93D File Offset: 0x00978B3D
		public TArray<float> CloudAngles
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._CloudAngles) == null)
				{
					result = (this._CloudAngles = new TArray<float>(base.NativePtr + (IntPtr)BP_CloudCards_C.__PropertyOffset_15, this));
				}
				return result;
			}
			set
			{
				this.CloudAngles.CopyAssign(value);
			}
		}

		// Token: 0x1700536B RID: 21355
		// (get) Token: 0x06026A6A RID: 158314 RVA: 0x0097A94B File Offset: 0x00978B4B
		// (set) Token: 0x06026A6B RID: 158315 RVA: 0x0097A95F File Offset: 0x00978B5F
		[Nullable(2)]
		public unsafe UMaterialInterface CloudMat
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudCards_C.__PropertyOffset_16);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudCards_C.__PropertyOffset_16, value);
			}
		}

		// Token: 0x1700536C RID: 21356
		// (get) Token: 0x06026A6C RID: 158316 RVA: 0x0097A974 File Offset: 0x00978B74
		// (set) Token: 0x06026A6D RID: 158317 RVA: 0x0097A9AD File Offset: 0x00978BAD
		public TArray<UTexture2D> CloudTextures
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UTexture2D> result;
				if ((result = this._CloudTextures) == null)
				{
					result = (this._CloudTextures = new TArray<UTexture2D>(base.NativePtr + (IntPtr)BP_CloudCards_C.__PropertyOffset_17, this));
				}
				return result;
			}
			set
			{
				this.CloudTextures.CopyAssign(value);
			}
		}

		// Token: 0x1700536D RID: 21357
		// (get) Token: 0x06026A6E RID: 158318 RVA: 0x0097A9BB File Offset: 0x00978BBB
		// (set) Token: 0x06026A6F RID: 158319 RVA: 0x0097A9CB File Offset: 0x00978BCB
		public unsafe float CloudLit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudCards_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudCards_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x1700536E RID: 21358
		// (get) Token: 0x06026A70 RID: 158320 RVA: 0x0097A9DC File Offset: 0x00978BDC
		// (set) Token: 0x06026A71 RID: 158321 RVA: 0x0097A9EC File Offset: 0x00978BEC
		public unsafe float AtmoLightScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudCards_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudCards_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x1700536F RID: 21359
		// (get) Token: 0x06026A72 RID: 158322 RVA: 0x0097A9FD File Offset: 0x00978BFD
		// (set) Token: 0x06026A73 RID: 158323 RVA: 0x0097AA0D File Offset: 0x00978C0D
		public unsafe float GammaExp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudCards_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudCards_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x17005370 RID: 21360
		// (get) Token: 0x06026A74 RID: 158324 RVA: 0x0097AA1E File Offset: 0x00978C1E
		// (set) Token: 0x06026A75 RID: 158325 RVA: 0x0097AA2E File Offset: 0x00978C2E
		public unsafe float Contrast
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudCards_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudCards_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x17005371 RID: 21361
		// (get) Token: 0x06026A76 RID: 158326 RVA: 0x0097AA3F File Offset: 0x00978C3F
		// (set) Token: 0x06026A77 RID: 158327 RVA: 0x0097AA4F File Offset: 0x00978C4F
		public unsafe float Brightness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudCards_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudCards_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x17005372 RID: 21362
		// (get) Token: 0x06026A78 RID: 158328 RVA: 0x0097AA60 File Offset: 0x00978C60
		// (set) Token: 0x06026A79 RID: 158329 RVA: 0x0097AA70 File Offset: 0x00978C70
		public unsafe float Translucency
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudCards_C.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudCards_C.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x17005373 RID: 21363
		// (get) Token: 0x06026A7A RID: 158330 RVA: 0x0097AA81 File Offset: 0x00978C81
		// (set) Token: 0x06026A7B RID: 158331 RVA: 0x0097AA91 File Offset: 0x00978C91
		public unsafe float SkyBlend
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudCards_C.__PropertyOffset_24);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudCards_C.__PropertyOffset_24) = value;
			}
		}

		// Token: 0x17005374 RID: 21364
		// (get) Token: 0x06026A7C RID: 158332 RVA: 0x0097AAA2 File Offset: 0x00978CA2
		// (set) Token: 0x06026A7D RID: 158333 RVA: 0x0097AAB2 File Offset: 0x00978CB2
		public unsafe float Disortion
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudCards_C.__PropertyOffset_25);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudCards_C.__PropertyOffset_25) = value;
			}
		}

		// Token: 0x17005375 RID: 21365
		// (get) Token: 0x06026A7E RID: 158334 RVA: 0x0097AAC3 File Offset: 0x00978CC3
		// (set) Token: 0x06026A7F RID: 158335 RVA: 0x0097AAD3 File Offset: 0x00978CD3
		public unsafe float LitOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudCards_C.__PropertyOffset_26);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudCards_C.__PropertyOffset_26) = value;
			}
		}

		// Token: 0x17005376 RID: 21366
		// (get) Token: 0x06026A80 RID: 158336 RVA: 0x0097AAE4 File Offset: 0x00978CE4
		// (set) Token: 0x06026A81 RID: 158337 RVA: 0x0097AAF4 File Offset: 0x00978CF4
		public unsafe float HorizonFalloff
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudCards_C.__PropertyOffset_27);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudCards_C.__PropertyOffset_27) = value;
			}
		}

		// Token: 0x17005377 RID: 21367
		// (get) Token: 0x06026A82 RID: 158338 RVA: 0x0097AB05 File Offset: 0x00978D05
		// (set) Token: 0x06026A83 RID: 158339 RVA: 0x0097AB15 File Offset: 0x00978D15
		public unsafe float HorizonOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudCards_C.__PropertyOffset_28);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudCards_C.__PropertyOffset_28) = value;
			}
		}

		// Token: 0x17005378 RID: 21368
		// (get) Token: 0x06026A84 RID: 158340 RVA: 0x0097AB26 File Offset: 0x00978D26
		// (set) Token: 0x06026A85 RID: 158341 RVA: 0x0097AB3A File Offset: 0x00978D3A
		public unsafe FVector2D DisortionSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudCards_C.__PropertyOffset_29);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudCards_C.__PropertyOffset_29) = value;
			}
		}

		// Token: 0x17005379 RID: 21369
		// (get) Token: 0x06026A86 RID: 158342 RVA: 0x0097AB4F File Offset: 0x00978D4F
		// (set) Token: 0x06026A87 RID: 158343 RVA: 0x0097AB63 File Offset: 0x00978D63
		public unsafe FLinearColor LightColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudCards_C.__PropertyOffset_30);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudCards_C.__PropertyOffset_30) = value;
			}
		}

		// Token: 0x1700537A RID: 21370
		// (get) Token: 0x06026A88 RID: 158344 RVA: 0x0097AB78 File Offset: 0x00978D78
		// (set) Token: 0x06026A89 RID: 158345 RVA: 0x0097AB8C File Offset: 0x00978D8C
		public unsafe FLinearColor DarkColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudCards_C.__PropertyOffset_31);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudCards_C.__PropertyOffset_31) = value;
			}
		}

		// Token: 0x1700537B RID: 21371
		// (get) Token: 0x06026A8A RID: 158346 RVA: 0x0097ABA1 File Offset: 0x00978DA1
		// (set) Token: 0x06026A8B RID: 158347 RVA: 0x0097ABB5 File Offset: 0x00978DB5
		public unsafe FLinearColor BaseColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudCards_C.__PropertyOffset_32);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudCards_C.__PropertyOffset_32) = value;
			}
		}

		// Token: 0x06026A8C RID: 158348 RVA: 0x0097ABCC File Offset: 0x00978DCC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetupCloudMesh(UStaticMeshComponent MeshComp, UTexture2D CloudTex, float RotAngle, int RandSeed)
		{
			BP_CloudCards_C.__SetupCloudMesh_FunctionParams* ptr = stackalloc BP_CloudCards_C.__SetupCloudMesh_FunctionParams[(UIntPtr)511] + 15L / (long)sizeof(BP_CloudCards_C.__SetupCloudMesh_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CloudCards_C.__SetupCloudMesh_NativeFunctionPtr, (void*)ptr, 1);
			ptr->MeshComp = ((MeshComp != null) ? MeshComp.NativePtr : IntPtr.Zero);
			ptr->CloudTex = ((CloudTex != null) ? CloudTex.NativePtr : IntPtr.Zero);
			ptr->RotAngle = RotAngle;
			ptr->RandSeed = RandSeed;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CloudCards_C.__SetupCloudMesh_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06026A8D RID: 158349 RVA: 0x0097AC4C File Offset: 0x00978E4C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void UpdateCloudPos(float TimeOfDay, FVector SunDir)
		{
			BP_CloudCards_C.__UpdateCloudPos_FunctionParams* ptr = stackalloc BP_CloudCards_C.__UpdateCloudPos_FunctionParams[(UIntPtr)367] + 15L / (long)sizeof(BP_CloudCards_C.__UpdateCloudPos_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CloudCards_C.__UpdateCloudPos_NativeFunctionPtr, (void*)ptr, 1);
			ptr->TimeOfDay = TimeOfDay;
			ptr->SunDir = SunDir;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CloudCards_C.__UpdateCloudPos_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06026A8E RID: 158350 RVA: 0x0097AC9C File Offset: 0x00978E9C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CloudCards_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06026A8F RID: 158351 RVA: 0x0097ACB0 File Offset: 0x00978EB0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CloudCards_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06026A90 RID: 158352 RVA: 0x0097ACC5 File Offset: 0x00978EC5
		protected BP_CloudCards_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040136C5 RID: 79557
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/GI/CloudCard/BP_CloudCards.BP_CloudCards_C";

		// Token: 0x040136C6 RID: 79558
		private static IntPtr _ClassPtr;

		// Token: 0x040136C7 RID: 79559
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040136C8 RID: 79560
		internal static int __PropertyOffset_0;

		// Token: 0x040136C9 RID: 79561
		internal static int __PropertyOffset_1;

		// Token: 0x040136CA RID: 79562
		internal static int __PropertyOffset_2;

		// Token: 0x040136CB RID: 79563
		internal static int __PropertyOffset_3;

		// Token: 0x040136CC RID: 79564
		internal static int __PropertyOffset_4;

		// Token: 0x040136CD RID: 79565
		internal static int __PropertyOffset_5;

		// Token: 0x040136CE RID: 79566
		internal static int __PropertyOffset_6;

		// Token: 0x040136CF RID: 79567
		internal static int __PropertyOffset_7;

		// Token: 0x040136D0 RID: 79568
		internal static int __PropertyOffset_8;

		// Token: 0x040136D1 RID: 79569
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UStaticMeshComponent> _CloudCardMeshComps;

		// Token: 0x040136D2 RID: 79570
		internal static int __PropertyOffset_9;

		// Token: 0x040136D3 RID: 79571
		internal static int __PropertyOffset_10;

		// Token: 0x040136D4 RID: 79572
		internal static int __PropertyOffset_11;

		// Token: 0x040136D5 RID: 79573
		internal static int __PropertyOffset_12;

		// Token: 0x040136D6 RID: 79574
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstanceDynamic> _CloudMIDs;

		// Token: 0x040136D7 RID: 79575
		internal static int __PropertyOffset_13;

		// Token: 0x040136D8 RID: 79576
		internal static int __PropertyOffset_14;

		// Token: 0x040136D9 RID: 79577
		[Nullable(2)]
		private FTimerHandle _TimerHandle;

		// Token: 0x040136DA RID: 79578
		internal static int __PropertyOffset_15;

		// Token: 0x040136DB RID: 79579
		[Nullable(2)]
		private TArray<float> _CloudAngles;

		// Token: 0x040136DC RID: 79580
		internal static int __PropertyOffset_16;

		// Token: 0x040136DD RID: 79581
		internal static int __PropertyOffset_17;

		// Token: 0x040136DE RID: 79582
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UTexture2D> _CloudTextures;

		// Token: 0x040136DF RID: 79583
		internal static int __PropertyOffset_18;

		// Token: 0x040136E0 RID: 79584
		internal static int __PropertyOffset_19;

		// Token: 0x040136E1 RID: 79585
		internal static int __PropertyOffset_20;

		// Token: 0x040136E2 RID: 79586
		internal static int __PropertyOffset_21;

		// Token: 0x040136E3 RID: 79587
		internal static int __PropertyOffset_22;

		// Token: 0x040136E4 RID: 79588
		internal static int __PropertyOffset_23;

		// Token: 0x040136E5 RID: 79589
		internal static int __PropertyOffset_24;

		// Token: 0x040136E6 RID: 79590
		internal static int __PropertyOffset_25;

		// Token: 0x040136E7 RID: 79591
		internal static int __PropertyOffset_26;

		// Token: 0x040136E8 RID: 79592
		internal static int __PropertyOffset_27;

		// Token: 0x040136E9 RID: 79593
		internal static int __PropertyOffset_28;

		// Token: 0x040136EA RID: 79594
		internal static int __PropertyOffset_29;

		// Token: 0x040136EB RID: 79595
		internal static int __PropertyOffset_30;

		// Token: 0x040136EC RID: 79596
		internal static int __PropertyOffset_31;

		// Token: 0x040136ED RID: 79597
		internal static int __PropertyOffset_32;

		// Token: 0x040136EE RID: 79598
		private static IntPtr __SetupCloudMesh_NativeFunctionPtr;

		// Token: 0x040136EF RID: 79599
		private static IntPtr __UpdateCloudPos_NativeFunctionPtr;

		// Token: 0x040136F0 RID: 79600
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0200A123 RID: 41251
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 496)]
		protected ref struct __SetupCloudMesh_FunctionParams
		{
			// Token: 0x04031CA0 RID: 203936
			[FieldOffset(0)]
			public IntPtr MeshComp;

			// Token: 0x04031CA1 RID: 203937
			[FieldOffset(8)]
			public IntPtr CloudTex;

			// Token: 0x04031CA2 RID: 203938
			[FieldOffset(16)]
			public float RotAngle;

			// Token: 0x04031CA3 RID: 203939
			[FieldOffset(20)]
			public int RandSeed;
		}

		// Token: 0x0200A124 RID: 41252
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 352)]
		protected ref struct __UpdateCloudPos_FunctionParams
		{
			// Token: 0x04031CA4 RID: 203940
			[FieldOffset(0)]
			public float TimeOfDay;

			// Token: 0x04031CA5 RID: 203941
			[FieldOffset(4)]
			public FVector SunDir;
		}
	}
}

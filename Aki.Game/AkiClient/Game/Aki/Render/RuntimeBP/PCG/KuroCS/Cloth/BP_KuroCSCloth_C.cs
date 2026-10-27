using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.KuroCS.Cloth
{
	// Token: 0x02003C8F RID: 15503
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/KuroCS/Cloth/BP_KuroCSCloth.BP_KuroCSCloth_C")]
	[UnrealStructLayout(1592, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1590)]
	public class BP_KuroCSCloth_C : AKuroCSCloth, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06024397 RID: 148375 RVA: 0x009387F5 File Offset: 0x009369F5
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_KuroCSCloth_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/KuroCS/Cloth/BP_KuroCSCloth.BP_KuroCSCloth_C");
			}
			return BP_KuroCSCloth_C._ClassPtr;
		}

		// Token: 0x06024398 RID: 148376 RVA: 0x0093881C File Offset: 0x00936A1C
		public BP_KuroCSCloth_C() : this(BuiltinUtils.AllocNativeUObject(BP_KuroCSCloth_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06024399 RID: 148377 RVA: 0x00938844 File Offset: 0x00936A44
		[NullableContext(1)]
		public BP_KuroCSCloth_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_KuroCSCloth_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170045E0 RID: 17888
		// (get) Token: 0x0602439A RID: 148378 RVA: 0x00938877 File Offset: 0x00936A77
		// (set) Token: 0x0602439B RID: 148379 RVA: 0x0093888B File Offset: 0x00936A8B
		public unsafe UBoxComponent ValidBox
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCSCloth_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCSCloth_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170045E1 RID: 17889
		// (get) Token: 0x0602439C RID: 148380 RVA: 0x009388A0 File Offset: 0x00936AA0
		// (set) Token: 0x0602439D RID: 148381 RVA: 0x009388B4 File Offset: 0x00936AB4
		public unsafe UStaticMeshComponent ClothMeshXZ
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCSCloth_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCSCloth_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x170045E2 RID: 17890
		// (get) Token: 0x0602439E RID: 148382 RVA: 0x009388C9 File Offset: 0x00936AC9
		// (set) Token: 0x0602439F RID: 148383 RVA: 0x009388DD File Offset: 0x00936ADD
		public unsafe UTextureRenderTarget2D RT
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCSCloth_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCSCloth_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x170045E3 RID: 17891
		// (get) Token: 0x060243A0 RID: 148384 RVA: 0x009388F2 File Offset: 0x00936AF2
		// (set) Token: 0x060243A1 RID: 148385 RVA: 0x00938902 File Offset: 0x00936B02
		public unsafe bool bStopSim
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCSCloth_C.__PropertyOffset_4) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCSCloth_C.__PropertyOffset_4) = (value ? 1 : 0);
			}
		}

		// Token: 0x170045E4 RID: 17892
		// (get) Token: 0x060243A2 RID: 148386 RVA: 0x00938913 File Offset: 0x00936B13
		// (set) Token: 0x060243A3 RID: 148387 RVA: 0x00938923 File Offset: 0x00936B23
		public unsafe bool bEditorTick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCSCloth_C.__PropertyOffset_5) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCSCloth_C.__PropertyOffset_5) = (value ? 1 : 0);
			}
		}

		// Token: 0x170045E5 RID: 17893
		// (get) Token: 0x060243A4 RID: 148388 RVA: 0x00938934 File Offset: 0x00936B34
		// (set) Token: 0x060243A5 RID: 148389 RVA: 0x00938948 File Offset: 0x00936B48
		public unsafe FVector PosOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCSCloth_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCSCloth_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x170045E6 RID: 17894
		// (get) Token: 0x060243A6 RID: 148390 RVA: 0x0093895D File Offset: 0x00936B5D
		// (set) Token: 0x060243A7 RID: 148391 RVA: 0x0093896D File Offset: 0x00936B6D
		public unsafe float FadeOut
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCSCloth_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCSCloth_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x170045E7 RID: 17895
		// (get) Token: 0x060243A8 RID: 148392 RVA: 0x0093897E File Offset: 0x00936B7E
		// (set) Token: 0x060243A9 RID: 148393 RVA: 0x0093898E File Offset: 0x00936B8E
		public unsafe bool bFadeOut
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCSCloth_C.__PropertyOffset_8) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCSCloth_C.__PropertyOffset_8) = (value ? 1 : 0);
			}
		}

		// Token: 0x170045E8 RID: 17896
		// (get) Token: 0x060243AA RID: 148394 RVA: 0x009389A0 File Offset: 0x00936BA0
		// (set) Token: 0x060243AB RID: 148395 RVA: 0x009389D9 File Offset: 0x00936BD9
		[Nullable(1)]
		public TArray<UMaterialInstanceDynamic> Mats
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInstanceDynamic> result;
				if ((result = this._Mats) == null)
				{
					result = (this._Mats = new TArray<UMaterialInstanceDynamic>(base.NativePtr + (IntPtr)BP_KuroCSCloth_C.__PropertyOffset_9, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Mats.CopyAssign(value);
			}
		}

		// Token: 0x170045E9 RID: 17897
		// (get) Token: 0x060243AC RID: 148396 RVA: 0x009389E7 File Offset: 0x00936BE7
		// (set) Token: 0x060243AD RID: 148397 RVA: 0x009389F7 File Offset: 0x00936BF7
		public unsafe bool bInit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCSCloth_C.__PropertyOffset_10) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCSCloth_C.__PropertyOffset_10) = (value ? 1 : 0);
			}
		}

		// Token: 0x170045EA RID: 17898
		// (get) Token: 0x060243AE RID: 148398 RVA: 0x00938A08 File Offset: 0x00936C08
		// (set) Token: 0x060243AF RID: 148399 RVA: 0x00938A18 File Offset: 0x00936C18
		public unsafe bool bDrawDebug
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCSCloth_C.__PropertyOffset_11) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCSCloth_C.__PropertyOffset_11) = (value ? 1 : 0);
			}
		}

		// Token: 0x170045EB RID: 17899
		// (get) Token: 0x060243B0 RID: 148400 RVA: 0x00938A29 File Offset: 0x00936C29
		// (set) Token: 0x060243B1 RID: 148401 RVA: 0x00938A39 File Offset: 0x00936C39
		public unsafe bool InitOverlap
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCSCloth_C.__PropertyOffset_12) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCSCloth_C.__PropertyOffset_12) = (value ? 1 : 0);
			}
		}

		// Token: 0x170045EC RID: 17900
		// (get) Token: 0x060243B2 RID: 148402 RVA: 0x00938A4A File Offset: 0x00936C4A
		// (set) Token: 0x060243B3 RID: 148403 RVA: 0x00938A5A File Offset: 0x00936C5A
		public unsafe bool bEnable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCSCloth_C.__PropertyOffset_13) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCSCloth_C.__PropertyOffset_13) = (value ? 1 : 0);
			}
		}

		// Token: 0x170045ED RID: 17901
		// (get) Token: 0x060243B4 RID: 148404 RVA: 0x00938A6B File Offset: 0x00936C6B
		// (set) Token: 0x060243B5 RID: 148405 RVA: 0x00938A7B File Offset: 0x00936C7B
		public unsafe float CollisionWolrd
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCSCloth_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCSCloth_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x170045EE RID: 17902
		// (get) Token: 0x060243B6 RID: 148406 RVA: 0x00938A8C File Offset: 0x00936C8C
		// (set) Token: 0x060243B7 RID: 148407 RVA: 0x00938AA0 File Offset: 0x00936CA0
		public unsafe UChildActorComponent editorTicker
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCSCloth_C.__PropertyOffset_15);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCSCloth_C.__PropertyOffset_15, value);
			}
		}

		// Token: 0x170045EF RID: 17903
		// (get) Token: 0x060243B8 RID: 148408 RVA: 0x00938AB5 File Offset: 0x00936CB5
		// (set) Token: 0x060243B9 RID: 148409 RVA: 0x00938AC5 File Offset: 0x00936CC5
		public unsafe bool bReadFromDA
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCSCloth_C.__PropertyOffset_16) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCSCloth_C.__PropertyOffset_16) = (value ? 1 : 0);
			}
		}

		// Token: 0x170045F0 RID: 17904
		// (get) Token: 0x060243BA RID: 148410 RVA: 0x00938AD6 File Offset: 0x00936CD6
		// (set) Token: 0x060243BB RID: 148411 RVA: 0x00938AEA File Offset: 0x00936CEA
		public unsafe PD_MeshToClothData_C DA
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<PD_MeshToClothData_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCSCloth_C.__PropertyOffset_17);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCSCloth_C.__PropertyOffset_17, value);
			}
		}

		// Token: 0x170045F1 RID: 17905
		// (get) Token: 0x060243BC RID: 148412 RVA: 0x00938AFF File Offset: 0x00936CFF
		// (set) Token: 0x060243BD RID: 148413 RVA: 0x00938B13 File Offset: 0x00936D13
		public unsafe UTextureRenderTarget2D RT_N
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCSCloth_C.__PropertyOffset_18);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCSCloth_C.__PropertyOffset_18, value);
			}
		}

		// Token: 0x170045F2 RID: 17906
		// (get) Token: 0x060243BE RID: 148414 RVA: 0x00938B28 File Offset: 0x00936D28
		// (set) Token: 0x060243BF RID: 148415 RVA: 0x00938B38 File Offset: 0x00936D38
		public unsafe float Delta_Time
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCSCloth_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCSCloth_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x170045F3 RID: 17907
		// (get) Token: 0x060243C0 RID: 148416 RVA: 0x00938B4C File Offset: 0x00936D4C
		// (set) Token: 0x060243C1 RID: 148417 RVA: 0x00938B85 File Offset: 0x00936D85
		[Nullable(1)]
		public TMap<FName, float> Scalar_Parameters
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FName, float> result;
				if ((result = this._Scalar_Parameters) == null)
				{
					result = (this._Scalar_Parameters = new TMap<FName, float>(base.NativePtr + (IntPtr)BP_KuroCSCloth_C.__PropertyOffset_20, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Scalar_Parameters.CopyAssign(value);
			}
		}

		// Token: 0x170045F4 RID: 17908
		// (get) Token: 0x060243C2 RID: 148418 RVA: 0x00938B94 File Offset: 0x00936D94
		// (set) Token: 0x060243C3 RID: 148419 RVA: 0x00938BCD File Offset: 0x00936DCD
		[Nullable(1)]
		public TMap<FName, FLinearColor> Vector_Parameters
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FLinearColor> result;
				if ((result = this._Vector_Parameters) == null)
				{
					result = (this._Vector_Parameters = new TMap<FName, FLinearColor>(base.NativePtr + (IntPtr)BP_KuroCSCloth_C.__PropertyOffset_21, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Vector_Parameters.CopyAssign(value);
			}
		}

		// Token: 0x170045F5 RID: 17909
		// (get) Token: 0x060243C4 RID: 148420 RVA: 0x00938BDC File Offset: 0x00936DDC
		// (set) Token: 0x060243C5 RID: 148421 RVA: 0x00938C15 File Offset: 0x00936E15
		[Nullable(1)]
		public TMap<FName, UTexture> Texture_Parameters
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FName, UTexture> result;
				if ((result = this._Texture_Parameters) == null)
				{
					result = (this._Texture_Parameters = new TMap<FName, UTexture>(base.NativePtr + (IntPtr)BP_KuroCSCloth_C.__PropertyOffset_22, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Texture_Parameters.CopyAssign(value);
			}
		}

		// Token: 0x170045F6 RID: 17910
		// (get) Token: 0x060243C6 RID: 148422 RVA: 0x00938C23 File Offset: 0x00936E23
		// (set) Token: 0x060243C7 RID: 148423 RVA: 0x00938C33 File Offset: 0x00936E33
		public unsafe float LastCustomDeltaTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCSCloth_C.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCSCloth_C.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x170045F7 RID: 17911
		// (get) Token: 0x060243C8 RID: 148424 RVA: 0x00938C44 File Offset: 0x00936E44
		// (set) Token: 0x060243C9 RID: 148425 RVA: 0x00938C54 File Offset: 0x00936E54
		public unsafe bool bFlipNormal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCSCloth_C.__PropertyOffset_24) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCSCloth_C.__PropertyOffset_24) = (value ? 1 : 0);
			}
		}

		// Token: 0x170045F8 RID: 17912
		// (get) Token: 0x060243CA RID: 148426 RVA: 0x00938C65 File Offset: 0x00936E65
		// (set) Token: 0x060243CB RID: 148427 RVA: 0x00938C75 File Offset: 0x00936E75
		public unsafe bool bDisableBoxCollision
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCSCloth_C.__PropertyOffset_25) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCSCloth_C.__PropertyOffset_25) = (value ? 1 : 0);
			}
		}

		// Token: 0x060243CC RID: 148428 RVA: 0x00938C86 File Offset: 0x00936E86
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateMaterialParams()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCSCloth_C.__UpdateMaterialParams_NativeFunctionPtr, null);
		}

		// Token: 0x060243CD RID: 148429 RVA: 0x00938C9A File Offset: 0x00936E9A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void InitParams()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCSCloth_C.__InitParams_NativeFunctionPtr, null);
		}

		// Token: 0x060243CE RID: 148430 RVA: 0x00938CAE File Offset: 0x00936EAE
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void InitRT()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCSCloth_C.__InitRT_NativeFunctionPtr, null);
		}

		// Token: 0x060243CF RID: 148431 RVA: 0x00938CC2 File Offset: 0x00936EC2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void AutoXCenter()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCSCloth_C.__AutoXCenter_NativeFunctionPtr, null);
		}

		// Token: 0x060243D0 RID: 148432 RVA: 0x00938CD6 File Offset: 0x00936ED6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void InitMats()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCSCloth_C.__InitMats_NativeFunctionPtr, null);
		}

		// Token: 0x060243D1 RID: 148433 RVA: 0x00938CEA File Offset: 0x00936EEA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCSCloth_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x060243D2 RID: 148434 RVA: 0x00938CFE File Offset: 0x00936EFE
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroCSCloth_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060243D3 RID: 148435 RVA: 0x00938D13 File Offset: 0x00936F13
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void EditorTick()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCSCloth_C.__EditorTick_NativeFunctionPtr, null);
		}

		// Token: 0x060243D4 RID: 148436 RVA: 0x00938D28 File Offset: 0x00936F28
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_KuroCSCloth_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_KuroCSCloth_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_KuroCSCloth_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroCSCloth_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCSCloth_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060243D5 RID: 148437 RVA: 0x00938D70 File Offset: 0x00936F70
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_KuroCSCloth_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_KuroCSCloth_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_KuroCSCloth_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroCSCloth_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroCSCloth_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060243D6 RID: 148438 RVA: 0x00938DB7 File Offset: 0x00936FB7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCSCloth_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x060243D7 RID: 148439 RVA: 0x00938DCB File Offset: 0x00936FCB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroCSCloth_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060243D8 RID: 148440 RVA: 0x00938DE0 File Offset: 0x00936FE0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
		{
			BP_KuroCSCloth_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_KuroCSCloth_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_KuroCSCloth_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroCSCloth_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCSCloth_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060243D9 RID: 148441 RVA: 0x00938E2C File Offset: 0x0093702C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
		{
			BP_KuroCSCloth_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_KuroCSCloth_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_KuroCSCloth_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroCSCloth_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroCSCloth_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060243DA RID: 148442 RVA: 0x00938E78 File Offset: 0x00937078
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_KuroCSCloth_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, in FHitResult SweepResult)
		{
			BP_KuroCSCloth_C.__BndEvt__BP_KuroCSCloth_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_KuroCSCloth_C.__BndEvt__BP_KuroCSCloth_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(BP_KuroCSCloth_C.__BndEvt__BP_KuroCSCloth_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroCSCloth_C.__BndEvt__BP_KuroCSCloth_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			ptr->bFromSweep = bFromSweep;
			if (SweepResult != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->SweepResult, SweepResult.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCSCloth_C.__BndEvt__BP_KuroCSCloth_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060243DB RID: 148443 RVA: 0x00938F34 File Offset: 0x00937134
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_KuroCSCloth_ValidBox_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex)
		{
			BP_KuroCSCloth_C.__BndEvt__BP_KuroCSCloth_ValidBox_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_KuroCSCloth_C.__BndEvt__BP_KuroCSCloth_ValidBox_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_KuroCSCloth_C.__BndEvt__BP_KuroCSCloth_ValidBox_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroCSCloth_C.__BndEvt__BP_KuroCSCloth_ValidBox_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCSCloth_C.__BndEvt__BP_KuroCSCloth_ValidBox_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060243DC RID: 148444 RVA: 0x00938FBD File Offset: 0x009371BD
		protected BP_KuroCSCloth_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011F30 RID: 73520
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/KuroCS/Cloth/BP_KuroCSCloth.BP_KuroCSCloth_C";

		// Token: 0x04011F31 RID: 73521
		private static IntPtr _ClassPtr;

		// Token: 0x04011F32 RID: 73522
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011F33 RID: 73523
		internal static int __PropertyOffset_1;

		// Token: 0x04011F34 RID: 73524
		internal static int __PropertyOffset_2;

		// Token: 0x04011F35 RID: 73525
		internal static int __PropertyOffset_3;

		// Token: 0x04011F36 RID: 73526
		internal static int __PropertyOffset_4;

		// Token: 0x04011F37 RID: 73527
		internal static int __PropertyOffset_5;

		// Token: 0x04011F38 RID: 73528
		internal static int __PropertyOffset_6;

		// Token: 0x04011F39 RID: 73529
		internal static int __PropertyOffset_7;

		// Token: 0x04011F3A RID: 73530
		internal static int __PropertyOffset_8;

		// Token: 0x04011F3B RID: 73531
		internal static int __PropertyOffset_9;

		// Token: 0x04011F3C RID: 73532
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstanceDynamic> _Mats;

		// Token: 0x04011F3D RID: 73533
		internal static int __PropertyOffset_10;

		// Token: 0x04011F3E RID: 73534
		internal static int __PropertyOffset_11;

		// Token: 0x04011F3F RID: 73535
		internal static int __PropertyOffset_12;

		// Token: 0x04011F40 RID: 73536
		internal static int __PropertyOffset_13;

		// Token: 0x04011F41 RID: 73537
		internal static int __PropertyOffset_14;

		// Token: 0x04011F42 RID: 73538
		internal static int __PropertyOffset_15;

		// Token: 0x04011F43 RID: 73539
		internal static int __PropertyOffset_16;

		// Token: 0x04011F44 RID: 73540
		internal static int __PropertyOffset_17;

		// Token: 0x04011F45 RID: 73541
		internal static int __PropertyOffset_18;

		// Token: 0x04011F46 RID: 73542
		internal static int __PropertyOffset_19;

		// Token: 0x04011F47 RID: 73543
		internal static int __PropertyOffset_20;

		// Token: 0x04011F48 RID: 73544
		private TMap<FName, float> _Scalar_Parameters;

		// Token: 0x04011F49 RID: 73545
		internal static int __PropertyOffset_21;

		// Token: 0x04011F4A RID: 73546
		private TMap<FName, FLinearColor> _Vector_Parameters;

		// Token: 0x04011F4B RID: 73547
		internal static int __PropertyOffset_22;

		// Token: 0x04011F4C RID: 73548
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, UTexture> _Texture_Parameters;

		// Token: 0x04011F4D RID: 73549
		internal static int __PropertyOffset_23;

		// Token: 0x04011F4E RID: 73550
		internal static int __PropertyOffset_24;

		// Token: 0x04011F4F RID: 73551
		internal static int __PropertyOffset_25;

		// Token: 0x04011F50 RID: 73552
		private static IntPtr __UpdateMaterialParams_NativeFunctionPtr;

		// Token: 0x04011F51 RID: 73553
		private static IntPtr __InitParams_NativeFunctionPtr;

		// Token: 0x04011F52 RID: 73554
		private static IntPtr __InitRT_NativeFunctionPtr;

		// Token: 0x04011F53 RID: 73555
		private static IntPtr __AutoXCenter_NativeFunctionPtr;

		// Token: 0x04011F54 RID: 73556
		private static IntPtr __InitMats_NativeFunctionPtr;

		// Token: 0x04011F55 RID: 73557
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04011F56 RID: 73558
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x04011F57 RID: 73559
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04011F58 RID: 73560
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04011F59 RID: 73561
		private static IntPtr __ReceiveEndPlay_NativeFunctionPtr;

		// Token: 0x04011F5A RID: 73562
		private static IntPtr __BndEvt__BP_KuroCSCloth_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04011F5B RID: 73563
		private static IntPtr __BndEvt__BP_KuroCSCloth_ValidBox_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x02009EED RID: 40685
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040317FA RID: 202746
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009EEE RID: 40686
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __ReceiveEndPlay_FunctionParams
		{
			// Token: 0x040317FB RID: 202747
			[FieldOffset(0)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}

		// Token: 0x02009EEF RID: 40687
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __BndEvt__BP_KuroCSCloth_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x040317FC RID: 202748
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x040317FD RID: 202749
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x040317FE RID: 202750
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x040317FF RID: 202751
			[FieldOffset(24)]
			public int OtherBodyIndex;

			// Token: 0x04031800 RID: 202752
			[FieldOffset(28)]
			public bool bFromSweep;

			// Token: 0x04031801 RID: 202753
			[FieldOffset(32)]
			public byte SweepResult;
		}

		// Token: 0x02009EF0 RID: 40688
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __BndEvt__BP_KuroCSCloth_ValidBox_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x04031802 RID: 202754
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x04031803 RID: 202755
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x04031804 RID: 202756
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x04031805 RID: 202757
			[FieldOffset(24)]
			public int OtherBodyIndex;
		}
	}
}

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Scene.NewGacha.BP
{
	// Token: 0x02003086 RID: 12422
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Scene/NewGacha/BP/BP_GachaInteract.BP_GachaInteract_C")]
	[UnrealStructLayout(1712, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1705)]
	public class BP_GachaInteract_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject, IBPI_Gacha_C, IUnrealBlueprintInterface, IUnrealInterface
	{
		// Token: 0x0601DA45 RID: 121413 RVA: 0x008FD9C1 File Offset: 0x008FBBC1
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_GachaInteract_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Scene/NewGacha/BP/BP_GachaInteract.BP_GachaInteract_C");
			}
			return BP_GachaInteract_C._ClassPtr;
		}

		// Token: 0x0601DA46 RID: 121414 RVA: 0x008FD9E8 File Offset: 0x008FBBE8
		public BP_GachaInteract_C() : this(BuiltinUtils.AllocNativeUObject(BP_GachaInteract_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601DA47 RID: 121415 RVA: 0x008FDA10 File Offset: 0x008FBC10
		[NullableContext(1)]
		public BP_GachaInteract_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_GachaInteract_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002FEA RID: 12266
		// (get) Token: 0x0601DA48 RID: 121416 RVA: 0x008FDA43 File Offset: 0x008FBC43
		// (set) Token: 0x0601DA49 RID: 121417 RVA: 0x008FDA57 File Offset: 0x008FBC57
		public unsafe UChildActorComponent Sequence02
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GachaInteract_C.__PropertyOffset_Sequence02);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GachaInteract_C.__PropertyOffset_Sequence02, value);
			}
		}

		// Token: 0x17002FEB RID: 12267
		// (get) Token: 0x0601DA4A RID: 121418 RVA: 0x008FDA6C File Offset: 0x008FBC6C
		// (set) Token: 0x0601DA4B RID: 121419 RVA: 0x008FDA80 File Offset: 0x008FBC80
		public unsafe UStaticMeshComponent Plane
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GachaInteract_C.__PropertyOffset_Plane);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GachaInteract_C.__PropertyOffset_Plane, value);
			}
		}

		// Token: 0x17002FEC RID: 12268
		// (get) Token: 0x0601DA4C RID: 121420 RVA: 0x008FDA95 File Offset: 0x008FBC95
		// (set) Token: 0x0601DA4D RID: 121421 RVA: 0x008FDAA9 File Offset: 0x008FBCA9
		public unsafe UStaticMeshComponent Cube
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GachaInteract_C.__PropertyOffset_Cube);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GachaInteract_C.__PropertyOffset_Cube, value);
			}
		}

		// Token: 0x17002FED RID: 12269
		// (get) Token: 0x0601DA4E RID: 121422 RVA: 0x008FDABE File Offset: 0x008FBCBE
		// (set) Token: 0x0601DA4F RID: 121423 RVA: 0x008FDAD2 File Offset: 0x008FBCD2
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GachaInteract_C.__PropertyOffset_DefaultSceneRoot);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GachaInteract_C.__PropertyOffset_DefaultSceneRoot, value);
			}
		}

		// Token: 0x17002FEE RID: 12270
		// (get) Token: 0x0601DA50 RID: 121424 RVA: 0x008FDAE7 File Offset: 0x008FBCE7
		// (set) Token: 0x0601DA51 RID: 121425 RVA: 0x008FDAFB File Offset: 0x008FBCFB
		public unsafe UTimelineComponent Timeline_0
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTimelineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GachaInteract_C.__PropertyOffset_Timeline_0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GachaInteract_C.__PropertyOffset_Timeline_0, value);
			}
		}

		// Token: 0x17002FEF RID: 12271
		// (get) Token: 0x0601DA52 RID: 121426 RVA: 0x008FDB10 File Offset: 0x008FBD10
		// (set) Token: 0x0601DA53 RID: 121427 RVA: 0x008FDB24 File Offset: 0x008FBD24
		[Nullable(0)]
		public unsafe TEnumAsByte<E_GachaResultNew> Gacha_Result
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GachaInteract_C.__PropertyOffset_Gacha_Result);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)BP_GachaInteract_C.__PropertyOffset_Gacha_Result) = value;
			}
		}

		// Token: 0x17002FF0 RID: 12272
		// (get) Token: 0x0601DA54 RID: 121428 RVA: 0x008FDB39 File Offset: 0x008FBD39
		// (set) Token: 0x0601DA55 RID: 121429 RVA: 0x008FDB4D File Offset: 0x008FBD4D
		public unsafe ASpotLight SpotLightInteract
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ASpotLight>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GachaInteract_C.__PropertyOffset_SpotLightInteract);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GachaInteract_C.__PropertyOffset_SpotLightInteract, value);
			}
		}

		// Token: 0x17002FF1 RID: 12273
		// (get) Token: 0x0601DA56 RID: 121430 RVA: 0x008FDB62 File Offset: 0x008FBD62
		// (set) Token: 0x0601DA57 RID: 121431 RVA: 0x008FDB76 File Offset: 0x008FBD76
		public unsafe ACameraActor CameraShow
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ACameraActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GachaInteract_C.__PropertyOffset_CameraShow);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GachaInteract_C.__PropertyOffset_CameraShow, value);
			}
		}

		// Token: 0x17002FF2 RID: 12274
		// (get) Token: 0x0601DA58 RID: 121432 RVA: 0x008FDB8B File Offset: 0x008FBD8B
		// (set) Token: 0x0601DA59 RID: 121433 RVA: 0x008FDB9F File Offset: 0x008FBD9F
		public unsafe FLinearColor Purple
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GachaInteract_C.__PropertyOffset_Purple);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GachaInteract_C.__PropertyOffset_Purple) = value;
			}
		}

		// Token: 0x17002FF3 RID: 12275
		// (get) Token: 0x0601DA5A RID: 121434 RVA: 0x008FDBB4 File Offset: 0x008FBDB4
		// (set) Token: 0x0601DA5B RID: 121435 RVA: 0x008FDBC8 File Offset: 0x008FBDC8
		public unsafe FLinearColor Gold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GachaInteract_C.__PropertyOffset_Gold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GachaInteract_C.__PropertyOffset_Gold) = value;
			}
		}

		// Token: 0x17002FF4 RID: 12276
		// (get) Token: 0x0601DA5C RID: 121436 RVA: 0x008FDBDD File Offset: 0x008FBDDD
		// (set) Token: 0x0601DA5D RID: 121437 RVA: 0x008FDBF1 File Offset: 0x008FBDF1
		public unsafe FLinearColor Normal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GachaInteract_C.__PropertyOffset_Normal);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GachaInteract_C.__PropertyOffset_Normal) = value;
			}
		}

		// Token: 0x17002FF5 RID: 12277
		// (get) Token: 0x0601DA5E RID: 121438 RVA: 0x008FDC06 File Offset: 0x008FBE06
		// (set) Token: 0x0601DA5F RID: 121439 RVA: 0x008FDC1A File Offset: 0x008FBE1A
		public unsafe FLinearColor AwardColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GachaInteract_C.__PropertyOffset_AwardColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GachaInteract_C.__PropertyOffset_AwardColor) = value;
			}
		}

		// Token: 0x17002FF6 RID: 12278
		// (get) Token: 0x0601DA60 RID: 121440 RVA: 0x008FDC2F File Offset: 0x008FBE2F
		// (set) Token: 0x0601DA61 RID: 121441 RVA: 0x008FDC43 File Offset: 0x008FBE43
		public unsafe ASpotLight Spot_Light_Seq
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ASpotLight>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GachaInteract_C.__PropertyOffset_Spot_Light_Seq);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GachaInteract_C.__PropertyOffset_Spot_Light_Seq, value);
			}
		}

		// Token: 0x17002FF7 RID: 12279
		// (get) Token: 0x0601DA62 RID: 121442 RVA: 0x008FDC58 File Offset: 0x008FBE58
		// (set) Token: 0x0601DA63 RID: 121443 RVA: 0x008FDC6C File Offset: 0x008FBE6C
		public unsafe BP_UpdateInteract_C UpdateInteract
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_UpdateInteract_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GachaInteract_C.__PropertyOffset_UpdateInteract);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GachaInteract_C.__PropertyOffset_UpdateInteract, value);
			}
		}

		// Token: 0x17002FF8 RID: 12280
		// (get) Token: 0x0601DA64 RID: 121444 RVA: 0x008FDC81 File Offset: 0x008FBE81
		// (set) Token: 0x0601DA65 RID: 121445 RVA: 0x008FDC95 File Offset: 0x008FBE95
		public unsafe ACameraActor CameraShowRoom
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ACameraActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GachaInteract_C.__PropertyOffset_CameraShowRoom);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GachaInteract_C.__PropertyOffset_CameraShowRoom, value);
			}
		}

		// Token: 0x17002FF9 RID: 12281
		// (get) Token: 0x0601DA66 RID: 121446 RVA: 0x008FDCAA File Offset: 0x008FBEAA
		// (set) Token: 0x0601DA67 RID: 121447 RVA: 0x008FDCBA File Offset: 0x008FBEBA
		public unsafe float WhiteScreenWeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GachaInteract_C.__PropertyOffset_WhiteScreenWeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GachaInteract_C.__PropertyOffset_WhiteScreenWeight) = value;
			}
		}

		// Token: 0x17002FFA RID: 12282
		// (get) Token: 0x0601DA68 RID: 121448 RVA: 0x008FDCCB File Offset: 0x008FBECB
		// (set) Token: 0x0601DA69 RID: 121449 RVA: 0x008FDCDB File Offset: 0x008FBEDB
		public unsafe bool WhiteScreen
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GachaInteract_C.__PropertyOffset_WhiteScreen) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GachaInteract_C.__PropertyOffset_WhiteScreen) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002FFB RID: 12283
		// (get) Token: 0x0601DA6A RID: 121450 RVA: 0x008FDCEC File Offset: 0x008FBEEC
		// (set) Token: 0x0601DA6B RID: 121451 RVA: 0x008FDD00 File Offset: 0x008FBF00
		public unsafe ALevelSequenceActor LevelSequenceShow
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ALevelSequenceActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GachaInteract_C.__PropertyOffset_LevelSequenceShow);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GachaInteract_C.__PropertyOffset_LevelSequenceShow, value);
			}
		}

		// Token: 0x17002FFC RID: 12284
		// (get) Token: 0x0601DA6C RID: 121452 RVA: 0x008FDD15 File Offset: 0x008FBF15
		// (set) Token: 0x0601DA6D RID: 121453 RVA: 0x008FDD29 File Offset: 0x008FBF29
		public unsafe ALevelSequenceActor LevelSequenceInteract
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ALevelSequenceActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GachaInteract_C.__PropertyOffset_LevelSequenceInteract);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GachaInteract_C.__PropertyOffset_LevelSequenceInteract, value);
			}
		}

		// Token: 0x17002FFD RID: 12285
		// (get) Token: 0x0601DA6E RID: 121454 RVA: 0x008FDD40 File Offset: 0x008FBF40
		// (set) Token: 0x0601DA6F RID: 121455 RVA: 0x008FDD79 File Offset: 0x008FBF79
		[Nullable(1)]
		public TArray<ULevelSequence> LevelSeqAll
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<ULevelSequence> result;
				if ((result = this._LevelSeqAll) == null)
				{
					result = (this._LevelSeqAll = new TArray<ULevelSequence>(base.NativePtr + (IntPtr)BP_GachaInteract_C.__PropertyOffset_LevelSeqAll, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.LevelSeqAll.CopyAssign(value);
			}
		}

		// Token: 0x17002FFE RID: 12286
		// (get) Token: 0x0601DA70 RID: 121456 RVA: 0x008FDD87 File Offset: 0x008FBF87
		// (set) Token: 0x0601DA71 RID: 121457 RVA: 0x008FDD9B File Offset: 0x008FBF9B
		public unsafe AActor Root
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GachaInteract_C.__PropertyOffset_Root);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GachaInteract_C.__PropertyOffset_Root, value);
			}
		}

		// Token: 0x17002FFF RID: 12287
		// (get) Token: 0x0601DA72 RID: 121458 RVA: 0x008FDDB0 File Offset: 0x008FBFB0
		// (set) Token: 0x0601DA73 RID: 121459 RVA: 0x008FDDC0 File Offset: 0x008FBFC0
		public unsafe bool FinishedInitGachaResults
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GachaInteract_C.__PropertyOffset_FinishedInitGachaResults) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GachaInteract_C.__PropertyOffset_FinishedInitGachaResults) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003000 RID: 12288
		// (get) Token: 0x0601DA74 RID: 121460 RVA: 0x008FDDD1 File Offset: 0x008FBFD1
		// (set) Token: 0x0601DA75 RID: 121461 RVA: 0x008FDDE1 File Offset: 0x008FBFE1
		public unsafe bool ShowUpdaterOn
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GachaInteract_C.__PropertyOffset_ShowUpdaterOn) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GachaInteract_C.__PropertyOffset_ShowUpdaterOn) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003001 RID: 12289
		// (get) Token: 0x0601DA76 RID: 121462 RVA: 0x008FDDF2 File Offset: 0x008FBFF2
		// (set) Token: 0x0601DA77 RID: 121463 RVA: 0x008FDE02 File Offset: 0x008FC002
		public unsafe bool IsSkip
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GachaInteract_C.__PropertyOffset_IsSkip) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GachaInteract_C.__PropertyOffset_IsSkip) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003002 RID: 12290
		// (get) Token: 0x0601DA78 RID: 121464 RVA: 0x008FDE13 File Offset: 0x008FC013
		// (set) Token: 0x0601DA79 RID: 121465 RVA: 0x008FDE27 File Offset: 0x008FC027
		public unsafe AStaticMeshActor SkyBoxShow
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AStaticMeshActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GachaInteract_C.__PropertyOffset_SkyBoxShow);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GachaInteract_C.__PropertyOffset_SkyBoxShow, value);
			}
		}

		// Token: 0x17003003 RID: 12291
		// (get) Token: 0x0601DA7A RID: 121466 RVA: 0x008FDE3C File Offset: 0x008FC03C
		// (set) Token: 0x0601DA7B RID: 121467 RVA: 0x008FDE50 File Offset: 0x008FC050
		[Nullable(1)]
		public unsafe string _string
		{
			[NullableContext(1)]
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_GachaInteract_C.__PropertyOffset__string)));
			}
			[NullableContext(1)]
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_GachaInteract_C.__PropertyOffset__string)), value);
			}
		}

		// Token: 0x17003004 RID: 12292
		// (get) Token: 0x0601DA7C RID: 121468 RVA: 0x008FDE65 File Offset: 0x008FC065
		// (set) Token: 0x0601DA7D RID: 121469 RVA: 0x008FDE75 File Offset: 0x008FC075
		public unsafe bool tickable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GachaInteract_C.__PropertyOffset_tickable) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GachaInteract_C.__PropertyOffset_tickable) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601DA7E RID: 121470 RVA: 0x008FDE88 File Offset: 0x008FC088
		[SkipLocalsInit]
		public unsafe virtual void IntroStart(int Frame, float Subtime)
		{
			BP_GachaInteract_C.__IntroStart_FunctionParams* ptr = stackalloc BP_GachaInteract_C.__IntroStart_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_GachaInteract_C.__IntroStart_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GachaInteract_C.__IntroStart_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Frame = Frame;
			ptr->Subtime = Subtime;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GachaInteract_C.__IntroStart_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601DA7F RID: 121471 RVA: 0x008FDED5 File Offset: 0x008FC0D5
		[SkipLocalsInit]
		public virtual void TSGachaShowroomStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GachaInteract_C.__TSGachaShowroomStart_NativeFunctionPtr, null);
		}

		// Token: 0x0601DA80 RID: 121472 RVA: 0x008FDEEC File Offset: 0x008FC0EC
		[SkipLocalsInit]
		public unsafe virtual void IsNewWorkFlow(ref bool IsNew)
		{
			BP_GachaInteract_C.__IsNewWorkFlow_FunctionParams* ptr = stackalloc BP_GachaInteract_C.__IsNewWorkFlow_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_GachaInteract_C.__IsNewWorkFlow_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GachaInteract_C.__IsNewWorkFlow_NativeFunctionPtr, (void*)ptr, 1);
			ptr->IsNew = IsNew;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GachaInteract_C.__IsNewWorkFlow_NativeFunctionPtr, (void*)ptr);
			IsNew = ptr->IsNew;
		}

		// Token: 0x0601DA81 RID: 121473 RVA: 0x008FDF3C File Offset: 0x008FC13C
		[SkipLocalsInit]
		public unsafe virtual void SelectLevelSeq(int Num)
		{
			BP_GachaInteract_C.__SelectLevelSeq_FunctionParams* ptr = stackalloc BP_GachaInteract_C.__SelectLevelSeq_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_GachaInteract_C.__SelectLevelSeq_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GachaInteract_C.__SelectLevelSeq_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Num = Num;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GachaInteract_C.__SelectLevelSeq_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601DA82 RID: 121474 RVA: 0x008FDF82 File Offset: 0x008FC182
		[SkipLocalsInit]
		public virtual void _5SSTenShotGold()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GachaInteract_C.___5SSTenShotGold_NativeFunctionPtr, null);
		}

		// Token: 0x0601DA83 RID: 121475 RVA: 0x008FDF96 File Offset: 0x008FC196
		[SkipLocalsInit]
		public virtual void _4SSTenShotPurple()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GachaInteract_C.___4SSTenShotPurple_NativeFunctionPtr, null);
		}

		// Token: 0x0601DA84 RID: 121476 RVA: 0x008FDFAA File Offset: 0x008FC1AA
		[SkipLocalsInit]
		public virtual void _3SSOneShotGold()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GachaInteract_C.___3SSOneShotGold_NativeFunctionPtr, null);
		}

		// Token: 0x0601DA85 RID: 121477 RVA: 0x008FDFBE File Offset: 0x008FC1BE
		[SkipLocalsInit]
		public virtual void _2SSOneShotPurple()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GachaInteract_C.___2SSOneShotPurple_NativeFunctionPtr, null);
		}

		// Token: 0x0601DA86 RID: 121478 RVA: 0x008FDFD2 File Offset: 0x008FC1D2
		[SkipLocalsInit]
		public virtual void _1SSOneShotNormal()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GachaInteract_C.___1SSOneShotNormal_NativeFunctionPtr, null);
		}

		// Token: 0x0601DA87 RID: 121479 RVA: 0x008FDFE8 File Offset: 0x008FC1E8
		[SkipLocalsInit]
		public unsafe virtual void TSInitParameters(E_GachaResultNew GachaResult)
		{
			BP_GachaInteract_C.__TSInitParameters_FunctionParams* ptr = stackalloc BP_GachaInteract_C.__TSInitParameters_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_GachaInteract_C.__TSInitParameters_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GachaInteract_C.__TSInitParameters_NativeFunctionPtr, (void*)ptr, 1);
			ptr->GachaResult = GachaResult;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GachaInteract_C.__TSInitParameters_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601DA88 RID: 121480 RVA: 0x008FE033 File Offset: 0x008FC233
		[SkipLocalsInit]
		public virtual void Init_Award_Parameters()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GachaInteract_C.__Init_Award_Parameters_NativeFunctionPtr, null);
		}

		// Token: 0x0601DA89 RID: 121481 RVA: 0x008FE047 File Offset: 0x008FC247
		[SkipLocalsInit]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GachaInteract_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601DA8A RID: 121482 RVA: 0x008FE05B File Offset: 0x008FC25B
		[SkipLocalsInit]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_GachaInteract_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601DA8B RID: 121483 RVA: 0x008FE06F File Offset: 0x008FC26F
		[SkipLocalsInit]
		public virtual void Timeline_0__FinishedFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GachaInteract_C.__Timeline_0__FinishedFunc_NativeFunctionPtr, null);
		}

		// Token: 0x0601DA8C RID: 121484 RVA: 0x008FE083 File Offset: 0x008FC283
		[SkipLocalsInit]
		public virtual void Timeline_0__UpdateFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GachaInteract_C.__Timeline_0__UpdateFunc_NativeFunctionPtr, null);
		}

		// Token: 0x0601DA8D RID: 121485 RVA: 0x008FE098 File Offset: 0x008FC298
		[SkipLocalsInit]
		public unsafe virtual void InteractStart(int Frame, float Subtime)
		{
			BP_GachaInteract_C.__InteractStart_FunctionParams* ptr = stackalloc BP_GachaInteract_C.__InteractStart_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_GachaInteract_C.__InteractStart_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GachaInteract_C.__InteractStart_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Frame = Frame;
			ptr->Subtime = Subtime;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GachaInteract_C.__InteractStart_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601DA8E RID: 121486 RVA: 0x008FE0E8 File Offset: 0x008FC2E8
		[SkipLocalsInit]
		public unsafe virtual void OutroStart(int Frame, float Subtime)
		{
			BP_GachaInteract_C.__OutroStart_FunctionParams* ptr = stackalloc BP_GachaInteract_C.__OutroStart_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_GachaInteract_C.__OutroStart_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GachaInteract_C.__OutroStart_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Frame = Frame;
			ptr->Subtime = Subtime;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GachaInteract_C.__OutroStart_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601DA8F RID: 121487 RVA: 0x008FE138 File Offset: 0x008FC338
		[SkipLocalsInit]
		public unsafe virtual void ShowroomStart(int Frame, float Subtime)
		{
			BP_GachaInteract_C.__ShowroomStart_FunctionParams* ptr = stackalloc BP_GachaInteract_C.__ShowroomStart_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_GachaInteract_C.__ShowroomStart_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GachaInteract_C.__ShowroomStart_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Frame = Frame;
			ptr->Subtime = Subtime;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GachaInteract_C.__ShowroomStart_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601DA90 RID: 121488 RVA: 0x008FE185 File Offset: 0x008FC385
		[SkipLocalsInit]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GachaInteract_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601DA91 RID: 121489 RVA: 0x008FE199 File Offset: 0x008FC399
		[SkipLocalsInit]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_GachaInteract_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601DA92 RID: 121490 RVA: 0x008FE1B0 File Offset: 0x008FC3B0
		[SkipLocalsInit]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_GachaInteract_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_GachaInteract_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_GachaInteract_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GachaInteract_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GachaInteract_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601DA93 RID: 121491 RVA: 0x008FE1F8 File Offset: 0x008FC3F8
		[SkipLocalsInit]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_GachaInteract_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_GachaInteract_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_GachaInteract_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GachaInteract_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_GachaInteract_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601DA94 RID: 121492 RVA: 0x008FE23E File Offset: 0x008FC43E
		[SkipLocalsInit]
		public virtual void EndGachaSequence()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GachaInteract_C.__EndGachaSequence_NativeFunctionPtr, null);
		}

		// Token: 0x0601DA95 RID: 121493 RVA: 0x008FE252 File Offset: 0x008FC452
		[SkipLocalsInit]
		public virtual void InitGachaResults()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GachaInteract_C.__InitGachaResults_NativeFunctionPtr, null);
		}

		// Token: 0x0601DA96 RID: 121494 RVA: 0x008FE266 File Offset: 0x008FC466
		[SkipLocalsInit]
		public virtual void WhiteScreenStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GachaInteract_C.__WhiteScreenStart_NativeFunctionPtr, null);
		}

		// Token: 0x0601DA97 RID: 121495 RVA: 0x008FE27A File Offset: 0x008FC47A
		[SkipLocalsInit]
		public virtual void WhiteScreenOff()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GachaInteract_C.__WhiteScreenOff_NativeFunctionPtr, null);
		}

		// Token: 0x0601DA98 RID: 121496 RVA: 0x008FE28E File Offset: 0x008FC48E
		[SkipLocalsInit]
		public virtual void Sequence_finshed()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GachaInteract_C.__Sequence_finshed_NativeFunctionPtr, null);
		}

		// Token: 0x0601DA99 RID: 121497 RVA: 0x008FE2A2 File Offset: 0x008FC4A2
		[SkipLocalsInit]
		public virtual void New_Outro()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GachaInteract_C.__New_Outro_NativeFunctionPtr, null);
		}

		// Token: 0x0601DA9A RID: 121498 RVA: 0x008FE2B6 File Offset: 0x008FC4B6
		[SkipLocalsInit]
		public virtual void SetGachaShowSeq()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GachaInteract_C.__SetGachaShowSeq_NativeFunctionPtr, null);
		}

		// Token: 0x0601DA9B RID: 121499 RVA: 0x008FE2CA File Offset: 0x008FC4CA
		[SkipLocalsInit]
		public virtual void Updater()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GachaInteract_C.__Updater_NativeFunctionPtr, null);
		}

		// Token: 0x0601DA9C RID: 121500 RVA: 0x008FE2DE File Offset: 0x008FC4DE
		[SkipLocalsInit]
		public virtual void Finished()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GachaInteract_C.__Finished_NativeFunctionPtr, null);
		}

		// Token: 0x0601DA9D RID: 121501 RVA: 0x008FE2F2 File Offset: 0x008FC4F2
		[SkipLocalsInit]
		public override void ReceiveDestroyed()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GachaInteract_C.__ReceiveDestroyed_NativeFunctionPtr, null);
		}

		// Token: 0x0601DA9E RID: 121502 RVA: 0x008FE306 File Offset: 0x008FC506
		[SkipLocalsInit]
		protected virtual void ReceiveDestroyed_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_GachaInteract_C.__ReceiveDestroyed_NativeFunctionPtr, null);
		}

		// Token: 0x0601DA9F RID: 121503 RVA: 0x008FE31C File Offset: 0x008FC51C
		[SkipLocalsInit]
		public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
		{
			BP_GachaInteract_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_GachaInteract_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_GachaInteract_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GachaInteract_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GachaInteract_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601DAA0 RID: 121504 RVA: 0x008FE368 File Offset: 0x008FC568
		[SkipLocalsInit]
		protected unsafe virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
		{
			BP_GachaInteract_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_GachaInteract_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_GachaInteract_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GachaInteract_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_GachaInteract_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601DAA1 RID: 121505 RVA: 0x008FE3B3 File Offset: 0x008FC5B3
		protected BP_GachaInteract_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F9F8 RID: 63992
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Scene/NewGacha/BP/BP_GachaInteract.BP_GachaInteract_C";

		// Token: 0x0400F9F9 RID: 63993
		private static IntPtr _ClassPtr;

		// Token: 0x0400F9FA RID: 63994
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F9FB RID: 63995
		internal static int __PropertyOffset_Sequence02;

		// Token: 0x0400F9FC RID: 63996
		internal static int __PropertyOffset_Plane;

		// Token: 0x0400F9FD RID: 63997
		internal static int __PropertyOffset_Cube;

		// Token: 0x0400F9FE RID: 63998
		internal static int __PropertyOffset_DefaultSceneRoot;

		// Token: 0x0400F9FF RID: 63999
		internal static int __PropertyOffset_Timeline_0;

		// Token: 0x0400FA00 RID: 64000
		internal static int __PropertyOffset_Gacha_Result;

		// Token: 0x0400FA01 RID: 64001
		internal static int __PropertyOffset_SpotLightInteract;

		// Token: 0x0400FA02 RID: 64002
		internal static int __PropertyOffset_CameraShow;

		// Token: 0x0400FA03 RID: 64003
		internal static int __PropertyOffset_Purple;

		// Token: 0x0400FA04 RID: 64004
		internal static int __PropertyOffset_Gold;

		// Token: 0x0400FA05 RID: 64005
		internal static int __PropertyOffset_Normal;

		// Token: 0x0400FA06 RID: 64006
		internal static int __PropertyOffset_AwardColor;

		// Token: 0x0400FA07 RID: 64007
		internal static int __PropertyOffset_Spot_Light_Seq;

		// Token: 0x0400FA08 RID: 64008
		internal static int __PropertyOffset_UpdateInteract;

		// Token: 0x0400FA09 RID: 64009
		internal static int __PropertyOffset_CameraShowRoom;

		// Token: 0x0400FA0A RID: 64010
		internal static int __PropertyOffset_WhiteScreenWeight;

		// Token: 0x0400FA0B RID: 64011
		internal static int __PropertyOffset_WhiteScreen;

		// Token: 0x0400FA0C RID: 64012
		internal static int __PropertyOffset_LevelSequenceShow;

		// Token: 0x0400FA0D RID: 64013
		internal static int __PropertyOffset_LevelSequenceInteract;

		// Token: 0x0400FA0E RID: 64014
		internal static int __PropertyOffset_LevelSeqAll;

		// Token: 0x0400FA0F RID: 64015
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<ULevelSequence> _LevelSeqAll;

		// Token: 0x0400FA10 RID: 64016
		internal static int __PropertyOffset_Root;

		// Token: 0x0400FA11 RID: 64017
		internal static int __PropertyOffset_FinishedInitGachaResults;

		// Token: 0x0400FA12 RID: 64018
		internal static int __PropertyOffset_ShowUpdaterOn;

		// Token: 0x0400FA13 RID: 64019
		internal static int __PropertyOffset_IsSkip;

		// Token: 0x0400FA14 RID: 64020
		internal static int __PropertyOffset_SkyBoxShow;

		// Token: 0x0400FA15 RID: 64021
		internal static int __PropertyOffset__string;

		// Token: 0x0400FA16 RID: 64022
		internal static int __PropertyOffset_tickable;

		// Token: 0x0400FA17 RID: 64023
		private static IntPtr __IntroStart_NativeFunctionPtr;

		// Token: 0x0400FA18 RID: 64024
		private static IntPtr __TSGachaShowroomStart_NativeFunctionPtr;

		// Token: 0x0400FA19 RID: 64025
		private static IntPtr __IsNewWorkFlow_NativeFunctionPtr;

		// Token: 0x0400FA1A RID: 64026
		private static IntPtr __SelectLevelSeq_NativeFunctionPtr;

		// Token: 0x0400FA1B RID: 64027
		private static IntPtr ___5SSTenShotGold_NativeFunctionPtr;

		// Token: 0x0400FA1C RID: 64028
		private static IntPtr ___4SSTenShotPurple_NativeFunctionPtr;

		// Token: 0x0400FA1D RID: 64029
		private static IntPtr ___3SSOneShotGold_NativeFunctionPtr;

		// Token: 0x0400FA1E RID: 64030
		private static IntPtr ___2SSOneShotPurple_NativeFunctionPtr;

		// Token: 0x0400FA1F RID: 64031
		private static IntPtr ___1SSOneShotNormal_NativeFunctionPtr;

		// Token: 0x0400FA20 RID: 64032
		private static IntPtr __TSInitParameters_NativeFunctionPtr;

		// Token: 0x0400FA21 RID: 64033
		private static IntPtr __Init_Award_Parameters_NativeFunctionPtr;

		// Token: 0x0400FA22 RID: 64034
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0400FA23 RID: 64035
		private static IntPtr __Timeline_0__FinishedFunc_NativeFunctionPtr;

		// Token: 0x0400FA24 RID: 64036
		private static IntPtr __Timeline_0__UpdateFunc_NativeFunctionPtr;

		// Token: 0x0400FA25 RID: 64037
		private static IntPtr __InteractStart_NativeFunctionPtr;

		// Token: 0x0400FA26 RID: 64038
		private static IntPtr __OutroStart_NativeFunctionPtr;

		// Token: 0x0400FA27 RID: 64039
		private static IntPtr __ShowroomStart_NativeFunctionPtr;

		// Token: 0x0400FA28 RID: 64040
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0400FA29 RID: 64041
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0400FA2A RID: 64042
		private static IntPtr __EndGachaSequence_NativeFunctionPtr;

		// Token: 0x0400FA2B RID: 64043
		private static IntPtr __InitGachaResults_NativeFunctionPtr;

		// Token: 0x0400FA2C RID: 64044
		private static IntPtr __WhiteScreenStart_NativeFunctionPtr;

		// Token: 0x0400FA2D RID: 64045
		private static IntPtr __WhiteScreenOff_NativeFunctionPtr;

		// Token: 0x0400FA2E RID: 64046
		private static IntPtr __Sequence_finshed_NativeFunctionPtr;

		// Token: 0x0400FA2F RID: 64047
		private static IntPtr __New_Outro_NativeFunctionPtr;

		// Token: 0x0400FA30 RID: 64048
		private static IntPtr __SetGachaShowSeq_NativeFunctionPtr;

		// Token: 0x0400FA31 RID: 64049
		private static IntPtr __Updater_NativeFunctionPtr;

		// Token: 0x0400FA32 RID: 64050
		private static IntPtr __Finished_NativeFunctionPtr;

		// Token: 0x0400FA33 RID: 64051
		private static IntPtr __ReceiveDestroyed_NativeFunctionPtr;

		// Token: 0x0400FA34 RID: 64052
		private static IntPtr __ReceiveEndPlay_NativeFunctionPtr;

		// Token: 0x02008D72 RID: 36210
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __IntroStart_FunctionParams
		{
			// Token: 0x0402C922 RID: 182562
			[FieldOffset(0)]
			public int Frame;

			// Token: 0x0402C923 RID: 182563
			[FieldOffset(4)]
			public float Subtime;
		}

		// Token: 0x02008D73 RID: 36211
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsNewWorkFlow_FunctionParams
		{
			// Token: 0x0402C924 RID: 182564
			[FieldOffset(0)]
			public bool IsNew;
		}

		// Token: 0x02008D74 RID: 36212
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __SelectLevelSeq_FunctionParams
		{
			// Token: 0x0402C925 RID: 182565
			[FieldOffset(0)]
			public int Num;
		}

		// Token: 0x02008D75 RID: 36213
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __TSInitParameters_FunctionParams
		{
			// Token: 0x0402C926 RID: 182566
			[FieldOffset(0)]
			public TEnumAsByte<E_GachaResultNew> GachaResult;
		}

		// Token: 0x02008D76 RID: 36214
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __InteractStart_FunctionParams
		{
			// Token: 0x0402C927 RID: 182567
			[FieldOffset(0)]
			public int Frame;

			// Token: 0x0402C928 RID: 182568
			[FieldOffset(4)]
			public float Subtime;
		}

		// Token: 0x02008D77 RID: 36215
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __OutroStart_FunctionParams
		{
			// Token: 0x0402C929 RID: 182569
			[FieldOffset(0)]
			public int Frame;

			// Token: 0x0402C92A RID: 182570
			[FieldOffset(4)]
			public float Subtime;
		}

		// Token: 0x02008D78 RID: 36216
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __ShowroomStart_FunctionParams
		{
			// Token: 0x0402C92B RID: 182571
			[FieldOffset(0)]
			public int Frame;

			// Token: 0x0402C92C RID: 182572
			[FieldOffset(4)]
			public float Subtime;
		}

		// Token: 0x02008D79 RID: 36217
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0402C92D RID: 182573
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02008D7A RID: 36218
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __ReceiveEndPlay_FunctionParams
		{
			// Token: 0x0402C92E RID: 182574
			[FieldOffset(0)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}
	}
}

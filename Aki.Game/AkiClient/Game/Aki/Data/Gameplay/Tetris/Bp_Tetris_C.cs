using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Gameplay.Tetris
{
	// Token: 0x02003F2F RID: 16175
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Gameplay/Tetris/Bp_Tetris.Bp_Tetris_C")]
	[UnrealStructLayout(1128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1128)]
	public class Bp_Tetris_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060291B4 RID: 168372 RVA: 0x009BBFBE File Offset: 0x009BA1BE
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (Bp_Tetris_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/Gameplay/Tetris/Bp_Tetris.Bp_Tetris_C");
			}
			return Bp_Tetris_C._ClassPtr;
		}

		// Token: 0x060291B5 RID: 168373 RVA: 0x009BBFE4 File Offset: 0x009BA1E4
		public Bp_Tetris_C() : this(BuiltinUtils.AllocNativeUObject(Bp_Tetris_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060291B6 RID: 168374 RVA: 0x009BC00C File Offset: 0x009BA20C
		public Bp_Tetris_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(Bp_Tetris_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700617C RID: 24956
		// (get) Token: 0x060291B7 RID: 168375 RVA: 0x009BC03F File Offset: 0x009BA23F
		// (set) Token: 0x060291B8 RID: 168376 RVA: 0x009BC053 File Offset: 0x009BA253
		public unsafe FVector2D DefaultBoardSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Bp_Tetris_C.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Bp_Tetris_C.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x1700617D RID: 24957
		// (get) Token: 0x060291B9 RID: 168377 RVA: 0x009BC068 File Offset: 0x009BA268
		// (set) Token: 0x060291BA RID: 168378 RVA: 0x009BC078 File Offset: 0x009BA278
		public unsafe float CubeSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Bp_Tetris_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Bp_Tetris_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x1700617E RID: 24958
		// (get) Token: 0x060291BB RID: 168379 RVA: 0x009BC089 File Offset: 0x009BA289
		// (set) Token: 0x060291BC RID: 168380 RVA: 0x009BC099 File Offset: 0x009BA299
		public unsafe float CubeControlTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Bp_Tetris_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Bp_Tetris_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x1700617F RID: 24959
		// (get) Token: 0x060291BD RID: 168381 RVA: 0x009BC0AA File Offset: 0x009BA2AA
		// (set) Token: 0x060291BE RID: 168382 RVA: 0x009BC0BA File Offset: 0x009BA2BA
		public unsafe float EndlessModeSpeedUpInterval
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Bp_Tetris_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Bp_Tetris_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17006180 RID: 24960
		// (get) Token: 0x060291BF RID: 168383 RVA: 0x009BC0CB File Offset: 0x009BA2CB
		// (set) Token: 0x060291C0 RID: 168384 RVA: 0x009BC0DB File Offset: 0x009BA2DB
		public unsafe float SingleControlTimeReduce
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Bp_Tetris_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Bp_Tetris_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17006181 RID: 24961
		// (get) Token: 0x060291C1 RID: 168385 RVA: 0x009BC0EC File Offset: 0x009BA2EC
		// (set) Token: 0x060291C2 RID: 168386 RVA: 0x009BC0FC File Offset: 0x009BA2FC
		public unsafe float MinCubeControlTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Bp_Tetris_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Bp_Tetris_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17006182 RID: 24962
		// (get) Token: 0x060291C3 RID: 168387 RVA: 0x009BC10D File Offset: 0x009BA30D
		// (set) Token: 0x060291C4 RID: 168388 RVA: 0x009BC11D File Offset: 0x009BA31D
		public unsafe float SpawnNextTetrominoInterval
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Bp_Tetris_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Bp_Tetris_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17006183 RID: 24963
		// (get) Token: 0x060291C5 RID: 168389 RVA: 0x009BC12E File Offset: 0x009BA32E
		// (set) Token: 0x060291C6 RID: 168390 RVA: 0x009BC13E File Offset: 0x009BA33E
		public unsafe float PrepareAreaMinY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Bp_Tetris_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Bp_Tetris_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17006184 RID: 24964
		// (get) Token: 0x060291C7 RID: 168391 RVA: 0x009BC14F File Offset: 0x009BA34F
		// (set) Token: 0x060291C8 RID: 168392 RVA: 0x009BC15F File Offset: 0x009BA35F
		public unsafe float PrepareAreaMaxY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Bp_Tetris_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Bp_Tetris_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17006185 RID: 24965
		// (get) Token: 0x060291C9 RID: 168393 RVA: 0x009BC170 File Offset: 0x009BA370
		// (set) Token: 0x060291CA RID: 168394 RVA: 0x009BC1A9 File Offset: 0x009BA3A9
		public TMap<int, int> ScoreRule
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, int> result;
				if ((result = this._ScoreRule) == null)
				{
					result = (this._ScoreRule = new TMap<int, int>(base.NativePtr + (IntPtr)Bp_Tetris_C.__PropertyOffset_9, this));
				}
				return result;
			}
			set
			{
				this.ScoreRule.CopyAssign(value);
			}
		}

		// Token: 0x17006186 RID: 24966
		// (get) Token: 0x060291CB RID: 168395 RVA: 0x009BC1B7 File Offset: 0x009BA3B7
		// (set) Token: 0x060291CC RID: 168396 RVA: 0x009BC1CC File Offset: 0x009BA3CC
		public TSoftObjectPtr<EffectModelGroup> NormalModeLineClearEffect
		{
			get
			{
				return new TSoftObjectPtr<EffectModelGroup>(base.NativePtr + (IntPtr)Bp_Tetris_C.__PropertyOffset_10, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)Bp_Tetris_C.__PropertyOffset_10, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17006187 RID: 24967
		// (get) Token: 0x060291CD RID: 168397 RVA: 0x009BC1F1 File Offset: 0x009BA3F1
		// (set) Token: 0x060291CE RID: 168398 RVA: 0x009BC206 File Offset: 0x009BA406
		public TSoftObjectPtr<EffectModelGroup> NormalModeTetrominoLockEffect
		{
			get
			{
				return new TSoftObjectPtr<EffectModelGroup>(base.NativePtr + (IntPtr)Bp_Tetris_C.__PropertyOffset_11, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)Bp_Tetris_C.__PropertyOffset_11, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17006188 RID: 24968
		// (get) Token: 0x060291CF RID: 168399 RVA: 0x009BC22B File Offset: 0x009BA42B
		// (set) Token: 0x060291D0 RID: 168400 RVA: 0x009BC240 File Offset: 0x009BA440
		public TSoftObjectPtr<EffectModelGroup> NormalModeTetrominoSpawnEffect
		{
			get
			{
				return new TSoftObjectPtr<EffectModelGroup>(base.NativePtr + (IntPtr)Bp_Tetris_C.__PropertyOffset_12, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)Bp_Tetris_C.__PropertyOffset_12, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17006189 RID: 24969
		// (get) Token: 0x060291D1 RID: 168401 RVA: 0x009BC265 File Offset: 0x009BA465
		// (set) Token: 0x060291D2 RID: 168402 RVA: 0x009BC27A File Offset: 0x009BA47A
		public TSoftObjectPtr<EffectModelGroup> NormalModeTetrominoMoveTrailEffect
		{
			get
			{
				return new TSoftObjectPtr<EffectModelGroup>(base.NativePtr + (IntPtr)Bp_Tetris_C.__PropertyOffset_13, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)Bp_Tetris_C.__PropertyOffset_13, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x1700618A RID: 24970
		// (get) Token: 0x060291D3 RID: 168403 RVA: 0x009BC29F File Offset: 0x009BA49F
		// (set) Token: 0x060291D4 RID: 168404 RVA: 0x009BC2B4 File Offset: 0x009BA4B4
		public TSoftObjectPtr<EffectModelGroup> NormalModeAreaLoopEffect
		{
			get
			{
				return new TSoftObjectPtr<EffectModelGroup>(base.NativePtr + (IntPtr)Bp_Tetris_C.__PropertyOffset_14, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)Bp_Tetris_C.__PropertyOffset_14, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x1700618B RID: 24971
		// (get) Token: 0x060291D5 RID: 168405 RVA: 0x009BC2D9 File Offset: 0x009BA4D9
		// (set) Token: 0x060291D6 RID: 168406 RVA: 0x009BC2EE File Offset: 0x009BA4EE
		public TSoftObjectPtr<EffectModelGroup> NormalModeAreaLoopEffect2
		{
			get
			{
				return new TSoftObjectPtr<EffectModelGroup>(base.NativePtr + (IntPtr)Bp_Tetris_C.__PropertyOffset_15, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)Bp_Tetris_C.__PropertyOffset_15, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x1700618C RID: 24972
		// (get) Token: 0x060291D7 RID: 168407 RVA: 0x009BC313 File Offset: 0x009BA513
		// (set) Token: 0x060291D8 RID: 168408 RVA: 0x009BC328 File Offset: 0x009BA528
		public TSoftObjectPtr<ItemMaterialControllerActorData> NormalModeMinoDestroyEffect
		{
			get
			{
				return new TSoftObjectPtr<ItemMaterialControllerActorData>(base.NativePtr + (IntPtr)Bp_Tetris_C.__PropertyOffset_16, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)Bp_Tetris_C.__PropertyOffset_16, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x1700618D RID: 24973
		// (get) Token: 0x060291D9 RID: 168409 RVA: 0x009BC34D File Offset: 0x009BA54D
		// (set) Token: 0x060291DA RID: 168410 RVA: 0x009BC362 File Offset: 0x009BA562
		public TSoftObjectPtr<EffectModelGroup> MainLineModeTetrominoSpawnEffect
		{
			get
			{
				return new TSoftObjectPtr<EffectModelGroup>(base.NativePtr + (IntPtr)Bp_Tetris_C.__PropertyOffset_17, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)Bp_Tetris_C.__PropertyOffset_17, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x1700618E RID: 24974
		// (get) Token: 0x060291DB RID: 168411 RVA: 0x009BC387 File Offset: 0x009BA587
		// (set) Token: 0x060291DC RID: 168412 RVA: 0x009BC39C File Offset: 0x009BA59C
		public TSoftObjectPtr<EffectModelGroup> MainLineModeTetrominoMoveTrailEffect
		{
			get
			{
				return new TSoftObjectPtr<EffectModelGroup>(base.NativePtr + (IntPtr)Bp_Tetris_C.__PropertyOffset_18, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)Bp_Tetris_C.__PropertyOffset_18, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x1700618F RID: 24975
		// (get) Token: 0x060291DD RID: 168413 RVA: 0x009BC3C1 File Offset: 0x009BA5C1
		// (set) Token: 0x060291DE RID: 168414 RVA: 0x009BC3D6 File Offset: 0x009BA5D6
		public TSoftObjectPtr<EffectModelGroup> MainLineModeTetrominoLockEffect
		{
			get
			{
				return new TSoftObjectPtr<EffectModelGroup>(base.NativePtr + (IntPtr)Bp_Tetris_C.__PropertyOffset_19, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)Bp_Tetris_C.__PropertyOffset_19, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17006190 RID: 24976
		// (get) Token: 0x060291DF RID: 168415 RVA: 0x009BC3FB File Offset: 0x009BA5FB
		// (set) Token: 0x060291E0 RID: 168416 RVA: 0x009BC410 File Offset: 0x009BA610
		public TSoftObjectPtr<EffectModelGroup> MainLineModeLineClearEffect
		{
			get
			{
				return new TSoftObjectPtr<EffectModelGroup>(base.NativePtr + (IntPtr)Bp_Tetris_C.__PropertyOffset_20, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)Bp_Tetris_C.__PropertyOffset_20, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17006191 RID: 24977
		// (get) Token: 0x060291E1 RID: 168417 RVA: 0x009BC435 File Offset: 0x009BA635
		// (set) Token: 0x060291E2 RID: 168418 RVA: 0x009BC44A File Offset: 0x009BA64A
		public TSoftObjectPtr<ItemMaterialControllerActorData> MainLineModeMinoDestroyEffect
		{
			get
			{
				return new TSoftObjectPtr<ItemMaterialControllerActorData>(base.NativePtr + (IntPtr)Bp_Tetris_C.__PropertyOffset_21, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)Bp_Tetris_C.__PropertyOffset_21, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17006192 RID: 24978
		// (get) Token: 0x060291E3 RID: 168419 RVA: 0x009BC46F File Offset: 0x009BA66F
		// (set) Token: 0x060291E4 RID: 168420 RVA: 0x009BC484 File Offset: 0x009BA684
		public TSoftObjectPtr<EffectModelGroup> NormalModeFailEffect
		{
			get
			{
				return new TSoftObjectPtr<EffectModelGroup>(base.NativePtr + (IntPtr)Bp_Tetris_C.__PropertyOffset_22, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)Bp_Tetris_C.__PropertyOffset_22, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17006193 RID: 24979
		// (get) Token: 0x060291E5 RID: 168421 RVA: 0x009BC4A9 File Offset: 0x009BA6A9
		// (set) Token: 0x060291E6 RID: 168422 RVA: 0x009BC4BE File Offset: 0x009BA6BE
		public TSoftObjectPtr<EffectModelGroup> MainLineModeFailEffect
		{
			get
			{
				return new TSoftObjectPtr<EffectModelGroup>(base.NativePtr + (IntPtr)Bp_Tetris_C.__PropertyOffset_23, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)Bp_Tetris_C.__PropertyOffset_23, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17006194 RID: 24980
		// (get) Token: 0x060291E7 RID: 168423 RVA: 0x009BC4E3 File Offset: 0x009BA6E3
		// (set) Token: 0x060291E8 RID: 168424 RVA: 0x009BC4F8 File Offset: 0x009BA6F8
		public TSoftObjectPtr<PD_CharacterControllerData_C> NormalModePlayerOutlineEffect
		{
			get
			{
				return new TSoftObjectPtr<PD_CharacterControllerData_C>(base.NativePtr + (IntPtr)Bp_Tetris_C.__PropertyOffset_24, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)Bp_Tetris_C.__PropertyOffset_24, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17006195 RID: 24981
		// (get) Token: 0x060291E9 RID: 168425 RVA: 0x009BC51D File Offset: 0x009BA71D
		// (set) Token: 0x060291EA RID: 168426 RVA: 0x009BC532 File Offset: 0x009BA732
		public TSoftObjectPtr<PD_CharacterControllerData_C> MainLineModePlayerOutlineEffect
		{
			get
			{
				return new TSoftObjectPtr<PD_CharacterControllerData_C>(base.NativePtr + (IntPtr)Bp_Tetris_C.__PropertyOffset_25, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)Bp_Tetris_C.__PropertyOffset_25, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17006196 RID: 24982
		// (get) Token: 0x060291EB RID: 168427 RVA: 0x009BC557 File Offset: 0x009BA757
		// (set) Token: 0x060291EC RID: 168428 RVA: 0x009BC56C File Offset: 0x009BA76C
		public TSoftObjectPtr<PD_CharacterControllerData_C> NormalModePlayerDeadEffect
		{
			get
			{
				return new TSoftObjectPtr<PD_CharacterControllerData_C>(base.NativePtr + (IntPtr)Bp_Tetris_C.__PropertyOffset_26, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)Bp_Tetris_C.__PropertyOffset_26, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17006197 RID: 24983
		// (get) Token: 0x060291ED RID: 168429 RVA: 0x009BC591 File Offset: 0x009BA791
		// (set) Token: 0x060291EE RID: 168430 RVA: 0x009BC5A5 File Offset: 0x009BA7A5
		public unsafe string AudioGameSpeedUp
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)Bp_Tetris_C.__PropertyOffset_27)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)Bp_Tetris_C.__PropertyOffset_27)), value);
			}
		}

		// Token: 0x17006198 RID: 24984
		// (get) Token: 0x060291EF RID: 168431 RVA: 0x009BC5BA File Offset: 0x009BA7BA
		// (set) Token: 0x060291F0 RID: 168432 RVA: 0x009BC5CE File Offset: 0x009BA7CE
		public unsafe string AudioTetrominoStartFall
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)Bp_Tetris_C.__PropertyOffset_28)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)Bp_Tetris_C.__PropertyOffset_28)), value);
			}
		}

		// Token: 0x17006199 RID: 24985
		// (get) Token: 0x060291F1 RID: 168433 RVA: 0x009BC5E3 File Offset: 0x009BA7E3
		// (set) Token: 0x060291F2 RID: 168434 RVA: 0x009BC5F7 File Offset: 0x009BA7F7
		public unsafe string AudioGameFail
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)Bp_Tetris_C.__PropertyOffset_29)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)Bp_Tetris_C.__PropertyOffset_29)), value);
			}
		}

		// Token: 0x1700619A RID: 24986
		// (get) Token: 0x060291F3 RID: 168435 RVA: 0x009BC60C File Offset: 0x009BA80C
		// (set) Token: 0x060291F4 RID: 168436 RVA: 0x009BC620 File Offset: 0x009BA820
		public unsafe string AudioGameSuccess
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)Bp_Tetris_C.__PropertyOffset_30)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)Bp_Tetris_C.__PropertyOffset_30)), value);
			}
		}

		// Token: 0x1700619B RID: 24987
		// (get) Token: 0x060291F5 RID: 168437 RVA: 0x009BC635 File Offset: 0x009BA835
		// (set) Token: 0x060291F6 RID: 168438 RVA: 0x009BC649 File Offset: 0x009BA849
		public unsafe string AudioGameRestart
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)Bp_Tetris_C.__PropertyOffset_31)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)Bp_Tetris_C.__PropertyOffset_31)), value);
			}
		}

		// Token: 0x1700619C RID: 24988
		// (get) Token: 0x060291F7 RID: 168439 RVA: 0x009BC65E File Offset: 0x009BA85E
		// (set) Token: 0x060291F8 RID: 168440 RVA: 0x009BC672 File Offset: 0x009BA872
		public unsafe string AudioTetrominoRotate
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)Bp_Tetris_C.__PropertyOffset_32)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)Bp_Tetris_C.__PropertyOffset_32)), value);
			}
		}

		// Token: 0x1700619D RID: 24989
		// (get) Token: 0x060291F9 RID: 168441 RVA: 0x009BC687 File Offset: 0x009BA887
		// (set) Token: 0x060291FA RID: 168442 RVA: 0x009BC69B File Offset: 0x009BA89B
		public unsafe string AudioAimingMove
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)Bp_Tetris_C.__PropertyOffset_33)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)Bp_Tetris_C.__PropertyOffset_33)), value);
			}
		}

		// Token: 0x060291FB RID: 168443 RVA: 0x009BC6B0 File Offset: 0x009BA8B0
		protected Bp_Tetris_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040150BD RID: 86205
		public new const string __ObjectPath = "/Game/Aki/Data/Gameplay/Tetris/Bp_Tetris.Bp_Tetris_C";

		// Token: 0x040150BE RID: 86206
		private static IntPtr _ClassPtr;

		// Token: 0x040150BF RID: 86207
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040150C0 RID: 86208
		internal static int __PropertyOffset_0;

		// Token: 0x040150C1 RID: 86209
		internal static int __PropertyOffset_1;

		// Token: 0x040150C2 RID: 86210
		internal static int __PropertyOffset_2;

		// Token: 0x040150C3 RID: 86211
		internal static int __PropertyOffset_3;

		// Token: 0x040150C4 RID: 86212
		internal static int __PropertyOffset_4;

		// Token: 0x040150C5 RID: 86213
		internal static int __PropertyOffset_5;

		// Token: 0x040150C6 RID: 86214
		internal static int __PropertyOffset_6;

		// Token: 0x040150C7 RID: 86215
		internal static int __PropertyOffset_7;

		// Token: 0x040150C8 RID: 86216
		internal static int __PropertyOffset_8;

		// Token: 0x040150C9 RID: 86217
		internal static int __PropertyOffset_9;

		// Token: 0x040150CA RID: 86218
		[Nullable(2)]
		private TMap<int, int> _ScoreRule;

		// Token: 0x040150CB RID: 86219
		internal static int __PropertyOffset_10;

		// Token: 0x040150CC RID: 86220
		internal static int __PropertyOffset_11;

		// Token: 0x040150CD RID: 86221
		internal static int __PropertyOffset_12;

		// Token: 0x040150CE RID: 86222
		internal static int __PropertyOffset_13;

		// Token: 0x040150CF RID: 86223
		internal static int __PropertyOffset_14;

		// Token: 0x040150D0 RID: 86224
		internal static int __PropertyOffset_15;

		// Token: 0x040150D1 RID: 86225
		internal static int __PropertyOffset_16;

		// Token: 0x040150D2 RID: 86226
		internal static int __PropertyOffset_17;

		// Token: 0x040150D3 RID: 86227
		internal static int __PropertyOffset_18;

		// Token: 0x040150D4 RID: 86228
		internal static int __PropertyOffset_19;

		// Token: 0x040150D5 RID: 86229
		internal static int __PropertyOffset_20;

		// Token: 0x040150D6 RID: 86230
		internal static int __PropertyOffset_21;

		// Token: 0x040150D7 RID: 86231
		internal static int __PropertyOffset_22;

		// Token: 0x040150D8 RID: 86232
		internal static int __PropertyOffset_23;

		// Token: 0x040150D9 RID: 86233
		internal static int __PropertyOffset_24;

		// Token: 0x040150DA RID: 86234
		internal static int __PropertyOffset_25;

		// Token: 0x040150DB RID: 86235
		internal static int __PropertyOffset_26;

		// Token: 0x040150DC RID: 86236
		internal static int __PropertyOffset_27;

		// Token: 0x040150DD RID: 86237
		internal static int __PropertyOffset_28;

		// Token: 0x040150DE RID: 86238
		internal static int __PropertyOffset_29;

		// Token: 0x040150DF RID: 86239
		internal static int __PropertyOffset_30;

		// Token: 0x040150E0 RID: 86240
		internal static int __PropertyOffset_31;

		// Token: 0x040150E1 RID: 86241
		internal static int __PropertyOffset_32;

		// Token: 0x040150E2 RID: 86242
		internal static int __PropertyOffset_33;
	}
}

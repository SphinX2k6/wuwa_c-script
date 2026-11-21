using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Gameplay.Tetris
{
	// Token: 0x020031DB RID: 12763
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Gameplay/Tetris/Bp_Tetris.Bp_Tetris_C")]
	[UnrealStructLayout(1128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1128)]
	public class Bp_Tetris_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601FAC6 RID: 129734 RVA: 0x0093311D File Offset: 0x0093131D
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (Bp_Tetris_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/Gameplay/Tetris/Bp_Tetris.Bp_Tetris_C");
			}
			return Bp_Tetris_C._ClassPtr;
		}

		// Token: 0x0601FAC7 RID: 129735 RVA: 0x00933144 File Offset: 0x00931344
		public Bp_Tetris_C() : this(BuiltinUtils.AllocNativeUObject(Bp_Tetris_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601FAC8 RID: 129736 RVA: 0x0093316C File Offset: 0x0093136C
		public Bp_Tetris_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(Bp_Tetris_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003AC8 RID: 15048
		// (get) Token: 0x0601FAC9 RID: 129737 RVA: 0x0093319F File Offset: 0x0093139F
		// (set) Token: 0x0601FACA RID: 129738 RVA: 0x009331B3 File Offset: 0x009313B3
		public unsafe FVector2D DefaultBoardSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Bp_Tetris_C.__PropertyOffset_DefaultBoardSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Bp_Tetris_C.__PropertyOffset_DefaultBoardSize) = value;
			}
		}

		// Token: 0x17003AC9 RID: 15049
		// (get) Token: 0x0601FACB RID: 129739 RVA: 0x009331C8 File Offset: 0x009313C8
		// (set) Token: 0x0601FACC RID: 129740 RVA: 0x009331D8 File Offset: 0x009313D8
		public unsafe float CubeSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Bp_Tetris_C.__PropertyOffset_CubeSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Bp_Tetris_C.__PropertyOffset_CubeSize) = value;
			}
		}

		// Token: 0x17003ACA RID: 15050
		// (get) Token: 0x0601FACD RID: 129741 RVA: 0x009331E9 File Offset: 0x009313E9
		// (set) Token: 0x0601FACE RID: 129742 RVA: 0x009331F9 File Offset: 0x009313F9
		public unsafe float CubeControlTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Bp_Tetris_C.__PropertyOffset_CubeControlTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Bp_Tetris_C.__PropertyOffset_CubeControlTime) = value;
			}
		}

		// Token: 0x17003ACB RID: 15051
		// (get) Token: 0x0601FACF RID: 129743 RVA: 0x0093320A File Offset: 0x0093140A
		// (set) Token: 0x0601FAD0 RID: 129744 RVA: 0x0093321A File Offset: 0x0093141A
		public unsafe float EndlessModeSpeedUpInterval
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Bp_Tetris_C.__PropertyOffset_EndlessModeSpeedUpInterval);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Bp_Tetris_C.__PropertyOffset_EndlessModeSpeedUpInterval) = value;
			}
		}

		// Token: 0x17003ACC RID: 15052
		// (get) Token: 0x0601FAD1 RID: 129745 RVA: 0x0093322B File Offset: 0x0093142B
		// (set) Token: 0x0601FAD2 RID: 129746 RVA: 0x0093323B File Offset: 0x0093143B
		public unsafe float SingleControlTimeReduce
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Bp_Tetris_C.__PropertyOffset_SingleControlTimeReduce);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Bp_Tetris_C.__PropertyOffset_SingleControlTimeReduce) = value;
			}
		}

		// Token: 0x17003ACD RID: 15053
		// (get) Token: 0x0601FAD3 RID: 129747 RVA: 0x0093324C File Offset: 0x0093144C
		// (set) Token: 0x0601FAD4 RID: 129748 RVA: 0x0093325C File Offset: 0x0093145C
		public unsafe float MinCubeControlTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Bp_Tetris_C.__PropertyOffset_MinCubeControlTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Bp_Tetris_C.__PropertyOffset_MinCubeControlTime) = value;
			}
		}

		// Token: 0x17003ACE RID: 15054
		// (get) Token: 0x0601FAD5 RID: 129749 RVA: 0x0093326D File Offset: 0x0093146D
		// (set) Token: 0x0601FAD6 RID: 129750 RVA: 0x0093327D File Offset: 0x0093147D
		public unsafe float SpawnNextTetrominoInterval
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Bp_Tetris_C.__PropertyOffset_SpawnNextTetrominoInterval);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Bp_Tetris_C.__PropertyOffset_SpawnNextTetrominoInterval) = value;
			}
		}

		// Token: 0x17003ACF RID: 15055
		// (get) Token: 0x0601FAD7 RID: 129751 RVA: 0x0093328E File Offset: 0x0093148E
		// (set) Token: 0x0601FAD8 RID: 129752 RVA: 0x0093329E File Offset: 0x0093149E
		public unsafe float PrepareAreaMinY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Bp_Tetris_C.__PropertyOffset_PrepareAreaMinY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Bp_Tetris_C.__PropertyOffset_PrepareAreaMinY) = value;
			}
		}

		// Token: 0x17003AD0 RID: 15056
		// (get) Token: 0x0601FAD9 RID: 129753 RVA: 0x009332AF File Offset: 0x009314AF
		// (set) Token: 0x0601FADA RID: 129754 RVA: 0x009332BF File Offset: 0x009314BF
		public unsafe float PrepareAreaMaxY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Bp_Tetris_C.__PropertyOffset_PrepareAreaMaxY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Bp_Tetris_C.__PropertyOffset_PrepareAreaMaxY) = value;
			}
		}

		// Token: 0x17003AD1 RID: 15057
		// (get) Token: 0x0601FADB RID: 129755 RVA: 0x009332D0 File Offset: 0x009314D0
		// (set) Token: 0x0601FADC RID: 129756 RVA: 0x00933309 File Offset: 0x00931509
		public TMap<int, int> ScoreRule
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, int> result;
				if ((result = this._ScoreRule) == null)
				{
					result = (this._ScoreRule = new TMap<int, int>(base.NativePtr + (IntPtr)Bp_Tetris_C.__PropertyOffset_ScoreRule, this));
				}
				return result;
			}
			set
			{
				this.ScoreRule.CopyAssign(value);
			}
		}

		// Token: 0x17003AD2 RID: 15058
		// (get) Token: 0x0601FADD RID: 129757 RVA: 0x00933317 File Offset: 0x00931517
		// (set) Token: 0x0601FADE RID: 129758 RVA: 0x0093332C File Offset: 0x0093152C
		public TSoftObjectPtr<EffectModelGroup> NormalModeLineClearEffect
		{
			get
			{
				return new TSoftObjectPtr<EffectModelGroup>(base.NativePtr + (IntPtr)Bp_Tetris_C.__PropertyOffset_NormalModeLineClearEffect, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)Bp_Tetris_C.__PropertyOffset_NormalModeLineClearEffect, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003AD3 RID: 15059
		// (get) Token: 0x0601FADF RID: 129759 RVA: 0x00933351 File Offset: 0x00931551
		// (set) Token: 0x0601FAE0 RID: 129760 RVA: 0x00933366 File Offset: 0x00931566
		public TSoftObjectPtr<EffectModelGroup> NormalModeTetrominoLockEffect
		{
			get
			{
				return new TSoftObjectPtr<EffectModelGroup>(base.NativePtr + (IntPtr)Bp_Tetris_C.__PropertyOffset_NormalModeTetrominoLockEffect, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)Bp_Tetris_C.__PropertyOffset_NormalModeTetrominoLockEffect, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003AD4 RID: 15060
		// (get) Token: 0x0601FAE1 RID: 129761 RVA: 0x0093338B File Offset: 0x0093158B
		// (set) Token: 0x0601FAE2 RID: 129762 RVA: 0x009333A0 File Offset: 0x009315A0
		public TSoftObjectPtr<EffectModelGroup> NormalModeTetrominoSpawnEffect
		{
			get
			{
				return new TSoftObjectPtr<EffectModelGroup>(base.NativePtr + (IntPtr)Bp_Tetris_C.__PropertyOffset_NormalModeTetrominoSpawnEffect, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)Bp_Tetris_C.__PropertyOffset_NormalModeTetrominoSpawnEffect, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003AD5 RID: 15061
		// (get) Token: 0x0601FAE3 RID: 129763 RVA: 0x009333C5 File Offset: 0x009315C5
		// (set) Token: 0x0601FAE4 RID: 129764 RVA: 0x009333DA File Offset: 0x009315DA
		public TSoftObjectPtr<EffectModelGroup> NormalModeTetrominoMoveTrailEffect
		{
			get
			{
				return new TSoftObjectPtr<EffectModelGroup>(base.NativePtr + (IntPtr)Bp_Tetris_C.__PropertyOffset_NormalModeTetrominoMoveTrailEffect, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)Bp_Tetris_C.__PropertyOffset_NormalModeTetrominoMoveTrailEffect, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003AD6 RID: 15062
		// (get) Token: 0x0601FAE5 RID: 129765 RVA: 0x009333FF File Offset: 0x009315FF
		// (set) Token: 0x0601FAE6 RID: 129766 RVA: 0x00933414 File Offset: 0x00931614
		public TSoftObjectPtr<EffectModelGroup> NormalModeAreaLoopEffect
		{
			get
			{
				return new TSoftObjectPtr<EffectModelGroup>(base.NativePtr + (IntPtr)Bp_Tetris_C.__PropertyOffset_NormalModeAreaLoopEffect, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)Bp_Tetris_C.__PropertyOffset_NormalModeAreaLoopEffect, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003AD7 RID: 15063
		// (get) Token: 0x0601FAE7 RID: 129767 RVA: 0x00933439 File Offset: 0x00931639
		// (set) Token: 0x0601FAE8 RID: 129768 RVA: 0x0093344E File Offset: 0x0093164E
		public TSoftObjectPtr<EffectModelGroup> NormalModeAreaLoopEffect2
		{
			get
			{
				return new TSoftObjectPtr<EffectModelGroup>(base.NativePtr + (IntPtr)Bp_Tetris_C.__PropertyOffset_NormalModeAreaLoopEffect2, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)Bp_Tetris_C.__PropertyOffset_NormalModeAreaLoopEffect2, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003AD8 RID: 15064
		// (get) Token: 0x0601FAE9 RID: 129769 RVA: 0x00933473 File Offset: 0x00931673
		// (set) Token: 0x0601FAEA RID: 129770 RVA: 0x00933488 File Offset: 0x00931688
		public TSoftObjectPtr<ItemMaterialControllerActorData> NormalModeMinoDestroyEffect
		{
			get
			{
				return new TSoftObjectPtr<ItemMaterialControllerActorData>(base.NativePtr + (IntPtr)Bp_Tetris_C.__PropertyOffset_NormalModeMinoDestroyEffect, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)Bp_Tetris_C.__PropertyOffset_NormalModeMinoDestroyEffect, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003AD9 RID: 15065
		// (get) Token: 0x0601FAEB RID: 129771 RVA: 0x009334AD File Offset: 0x009316AD
		// (set) Token: 0x0601FAEC RID: 129772 RVA: 0x009334C2 File Offset: 0x009316C2
		public TSoftObjectPtr<EffectModelGroup> MainLineModeTetrominoSpawnEffect
		{
			get
			{
				return new TSoftObjectPtr<EffectModelGroup>(base.NativePtr + (IntPtr)Bp_Tetris_C.__PropertyOffset_MainLineModeTetrominoSpawnEffect, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)Bp_Tetris_C.__PropertyOffset_MainLineModeTetrominoSpawnEffect, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003ADA RID: 15066
		// (get) Token: 0x0601FAED RID: 129773 RVA: 0x009334E7 File Offset: 0x009316E7
		// (set) Token: 0x0601FAEE RID: 129774 RVA: 0x009334FC File Offset: 0x009316FC
		public TSoftObjectPtr<EffectModelGroup> MainLineModeTetrominoMoveTrailEffect
		{
			get
			{
				return new TSoftObjectPtr<EffectModelGroup>(base.NativePtr + (IntPtr)Bp_Tetris_C.__PropertyOffset_MainLineModeTetrominoMoveTrailEffect, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)Bp_Tetris_C.__PropertyOffset_MainLineModeTetrominoMoveTrailEffect, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003ADB RID: 15067
		// (get) Token: 0x0601FAEF RID: 129775 RVA: 0x00933521 File Offset: 0x00931721
		// (set) Token: 0x0601FAF0 RID: 129776 RVA: 0x00933536 File Offset: 0x00931736
		public TSoftObjectPtr<EffectModelGroup> MainLineModeTetrominoLockEffect
		{
			get
			{
				return new TSoftObjectPtr<EffectModelGroup>(base.NativePtr + (IntPtr)Bp_Tetris_C.__PropertyOffset_MainLineModeTetrominoLockEffect, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)Bp_Tetris_C.__PropertyOffset_MainLineModeTetrominoLockEffect, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003ADC RID: 15068
		// (get) Token: 0x0601FAF1 RID: 129777 RVA: 0x0093355B File Offset: 0x0093175B
		// (set) Token: 0x0601FAF2 RID: 129778 RVA: 0x00933570 File Offset: 0x00931770
		public TSoftObjectPtr<EffectModelGroup> MainLineModeLineClearEffect
		{
			get
			{
				return new TSoftObjectPtr<EffectModelGroup>(base.NativePtr + (IntPtr)Bp_Tetris_C.__PropertyOffset_MainLineModeLineClearEffect, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)Bp_Tetris_C.__PropertyOffset_MainLineModeLineClearEffect, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003ADD RID: 15069
		// (get) Token: 0x0601FAF3 RID: 129779 RVA: 0x00933595 File Offset: 0x00931795
		// (set) Token: 0x0601FAF4 RID: 129780 RVA: 0x009335AA File Offset: 0x009317AA
		public TSoftObjectPtr<ItemMaterialControllerActorData> MainLineModeMinoDestroyEffect
		{
			get
			{
				return new TSoftObjectPtr<ItemMaterialControllerActorData>(base.NativePtr + (IntPtr)Bp_Tetris_C.__PropertyOffset_MainLineModeMinoDestroyEffect, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)Bp_Tetris_C.__PropertyOffset_MainLineModeMinoDestroyEffect, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003ADE RID: 15070
		// (get) Token: 0x0601FAF5 RID: 129781 RVA: 0x009335CF File Offset: 0x009317CF
		// (set) Token: 0x0601FAF6 RID: 129782 RVA: 0x009335E4 File Offset: 0x009317E4
		public TSoftObjectPtr<EffectModelGroup> NormalModeFailEffect
		{
			get
			{
				return new TSoftObjectPtr<EffectModelGroup>(base.NativePtr + (IntPtr)Bp_Tetris_C.__PropertyOffset_NormalModeFailEffect, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)Bp_Tetris_C.__PropertyOffset_NormalModeFailEffect, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003ADF RID: 15071
		// (get) Token: 0x0601FAF7 RID: 129783 RVA: 0x00933609 File Offset: 0x00931809
		// (set) Token: 0x0601FAF8 RID: 129784 RVA: 0x0093361E File Offset: 0x0093181E
		public TSoftObjectPtr<EffectModelGroup> MainLineModeFailEffect
		{
			get
			{
				return new TSoftObjectPtr<EffectModelGroup>(base.NativePtr + (IntPtr)Bp_Tetris_C.__PropertyOffset_MainLineModeFailEffect, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)Bp_Tetris_C.__PropertyOffset_MainLineModeFailEffect, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003AE0 RID: 15072
		// (get) Token: 0x0601FAF9 RID: 129785 RVA: 0x00933643 File Offset: 0x00931843
		// (set) Token: 0x0601FAFA RID: 129786 RVA: 0x00933658 File Offset: 0x00931858
		public TSoftObjectPtr<PD_CharacterControllerData_C> NormalModePlayerOutlineEffect
		{
			get
			{
				return new TSoftObjectPtr<PD_CharacterControllerData_C>(base.NativePtr + (IntPtr)Bp_Tetris_C.__PropertyOffset_NormalModePlayerOutlineEffect, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)Bp_Tetris_C.__PropertyOffset_NormalModePlayerOutlineEffect, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003AE1 RID: 15073
		// (get) Token: 0x0601FAFB RID: 129787 RVA: 0x0093367D File Offset: 0x0093187D
		// (set) Token: 0x0601FAFC RID: 129788 RVA: 0x00933692 File Offset: 0x00931892
		public TSoftObjectPtr<PD_CharacterControllerData_C> MainLineModePlayerOutlineEffect
		{
			get
			{
				return new TSoftObjectPtr<PD_CharacterControllerData_C>(base.NativePtr + (IntPtr)Bp_Tetris_C.__PropertyOffset_MainLineModePlayerOutlineEffect, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)Bp_Tetris_C.__PropertyOffset_MainLineModePlayerOutlineEffect, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003AE2 RID: 15074
		// (get) Token: 0x0601FAFD RID: 129789 RVA: 0x009336B7 File Offset: 0x009318B7
		// (set) Token: 0x0601FAFE RID: 129790 RVA: 0x009336CC File Offset: 0x009318CC
		public TSoftObjectPtr<PD_CharacterControllerData_C> NormalModePlayerDeadEffect
		{
			get
			{
				return new TSoftObjectPtr<PD_CharacterControllerData_C>(base.NativePtr + (IntPtr)Bp_Tetris_C.__PropertyOffset_NormalModePlayerDeadEffect, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)Bp_Tetris_C.__PropertyOffset_NormalModePlayerDeadEffect, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003AE3 RID: 15075
		// (get) Token: 0x0601FAFF RID: 129791 RVA: 0x009336F1 File Offset: 0x009318F1
		// (set) Token: 0x0601FB00 RID: 129792 RVA: 0x00933705 File Offset: 0x00931905
		public unsafe string AudioGameSpeedUp
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)Bp_Tetris_C.__PropertyOffset_AudioGameSpeedUp)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)Bp_Tetris_C.__PropertyOffset_AudioGameSpeedUp)), value);
			}
		}

		// Token: 0x17003AE4 RID: 15076
		// (get) Token: 0x0601FB01 RID: 129793 RVA: 0x0093371A File Offset: 0x0093191A
		// (set) Token: 0x0601FB02 RID: 129794 RVA: 0x0093372E File Offset: 0x0093192E
		public unsafe string AudioTetrominoStartFall
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)Bp_Tetris_C.__PropertyOffset_AudioTetrominoStartFall)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)Bp_Tetris_C.__PropertyOffset_AudioTetrominoStartFall)), value);
			}
		}

		// Token: 0x17003AE5 RID: 15077
		// (get) Token: 0x0601FB03 RID: 129795 RVA: 0x00933743 File Offset: 0x00931943
		// (set) Token: 0x0601FB04 RID: 129796 RVA: 0x00933757 File Offset: 0x00931957
		public unsafe string AudioGameFail
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)Bp_Tetris_C.__PropertyOffset_AudioGameFail)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)Bp_Tetris_C.__PropertyOffset_AudioGameFail)), value);
			}
		}

		// Token: 0x17003AE6 RID: 15078
		// (get) Token: 0x0601FB05 RID: 129797 RVA: 0x0093376C File Offset: 0x0093196C
		// (set) Token: 0x0601FB06 RID: 129798 RVA: 0x00933780 File Offset: 0x00931980
		public unsafe string AudioGameSuccess
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)Bp_Tetris_C.__PropertyOffset_AudioGameSuccess)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)Bp_Tetris_C.__PropertyOffset_AudioGameSuccess)), value);
			}
		}

		// Token: 0x17003AE7 RID: 15079
		// (get) Token: 0x0601FB07 RID: 129799 RVA: 0x00933795 File Offset: 0x00931995
		// (set) Token: 0x0601FB08 RID: 129800 RVA: 0x009337A9 File Offset: 0x009319A9
		public unsafe string AudioGameRestart
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)Bp_Tetris_C.__PropertyOffset_AudioGameRestart)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)Bp_Tetris_C.__PropertyOffset_AudioGameRestart)), value);
			}
		}

		// Token: 0x17003AE8 RID: 15080
		// (get) Token: 0x0601FB09 RID: 129801 RVA: 0x009337BE File Offset: 0x009319BE
		// (set) Token: 0x0601FB0A RID: 129802 RVA: 0x009337D2 File Offset: 0x009319D2
		public unsafe string AudioTetrominoRotate
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)Bp_Tetris_C.__PropertyOffset_AudioTetrominoRotate)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)Bp_Tetris_C.__PropertyOffset_AudioTetrominoRotate)), value);
			}
		}

		// Token: 0x17003AE9 RID: 15081
		// (get) Token: 0x0601FB0B RID: 129803 RVA: 0x009337E7 File Offset: 0x009319E7
		// (set) Token: 0x0601FB0C RID: 129804 RVA: 0x009337FB File Offset: 0x009319FB
		public unsafe string AudioAimingMove
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)Bp_Tetris_C.__PropertyOffset_AudioAimingMove)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)Bp_Tetris_C.__PropertyOffset_AudioAimingMove)), value);
			}
		}

		// Token: 0x0601FB0D RID: 129805 RVA: 0x00933810 File Offset: 0x00931A10
		protected Bp_Tetris_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010FED RID: 69613
		public new const string __ObjectPath = "/Game/Aki/Data/Gameplay/Tetris/Bp_Tetris.Bp_Tetris_C";

		// Token: 0x04010FEE RID: 69614
		private static IntPtr _ClassPtr;

		// Token: 0x04010FEF RID: 69615
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010FF0 RID: 69616
		internal static int __PropertyOffset_DefaultBoardSize;

		// Token: 0x04010FF1 RID: 69617
		internal static int __PropertyOffset_CubeSize;

		// Token: 0x04010FF2 RID: 69618
		internal static int __PropertyOffset_CubeControlTime;

		// Token: 0x04010FF3 RID: 69619
		internal static int __PropertyOffset_EndlessModeSpeedUpInterval;

		// Token: 0x04010FF4 RID: 69620
		internal static int __PropertyOffset_SingleControlTimeReduce;

		// Token: 0x04010FF5 RID: 69621
		internal static int __PropertyOffset_MinCubeControlTime;

		// Token: 0x04010FF6 RID: 69622
		internal static int __PropertyOffset_SpawnNextTetrominoInterval;

		// Token: 0x04010FF7 RID: 69623
		internal static int __PropertyOffset_PrepareAreaMinY;

		// Token: 0x04010FF8 RID: 69624
		internal static int __PropertyOffset_PrepareAreaMaxY;

		// Token: 0x04010FF9 RID: 69625
		internal static int __PropertyOffset_ScoreRule;

		// Token: 0x04010FFA RID: 69626
		[Nullable(2)]
		private TMap<int, int> _ScoreRule;

		// Token: 0x04010FFB RID: 69627
		internal static int __PropertyOffset_NormalModeLineClearEffect;

		// Token: 0x04010FFC RID: 69628
		internal static int __PropertyOffset_NormalModeTetrominoLockEffect;

		// Token: 0x04010FFD RID: 69629
		internal static int __PropertyOffset_NormalModeTetrominoSpawnEffect;

		// Token: 0x04010FFE RID: 69630
		internal static int __PropertyOffset_NormalModeTetrominoMoveTrailEffect;

		// Token: 0x04010FFF RID: 69631
		internal static int __PropertyOffset_NormalModeAreaLoopEffect;

		// Token: 0x04011000 RID: 69632
		internal static int __PropertyOffset_NormalModeAreaLoopEffect2;

		// Token: 0x04011001 RID: 69633
		internal static int __PropertyOffset_NormalModeMinoDestroyEffect;

		// Token: 0x04011002 RID: 69634
		internal static int __PropertyOffset_MainLineModeTetrominoSpawnEffect;

		// Token: 0x04011003 RID: 69635
		internal static int __PropertyOffset_MainLineModeTetrominoMoveTrailEffect;

		// Token: 0x04011004 RID: 69636
		internal static int __PropertyOffset_MainLineModeTetrominoLockEffect;

		// Token: 0x04011005 RID: 69637
		internal static int __PropertyOffset_MainLineModeLineClearEffect;

		// Token: 0x04011006 RID: 69638
		internal static int __PropertyOffset_MainLineModeMinoDestroyEffect;

		// Token: 0x04011007 RID: 69639
		internal static int __PropertyOffset_NormalModeFailEffect;

		// Token: 0x04011008 RID: 69640
		internal static int __PropertyOffset_MainLineModeFailEffect;

		// Token: 0x04011009 RID: 69641
		internal static int __PropertyOffset_NormalModePlayerOutlineEffect;

		// Token: 0x0401100A RID: 69642
		internal static int __PropertyOffset_MainLineModePlayerOutlineEffect;

		// Token: 0x0401100B RID: 69643
		internal static int __PropertyOffset_NormalModePlayerDeadEffect;

		// Token: 0x0401100C RID: 69644
		internal static int __PropertyOffset_AudioGameSpeedUp;

		// Token: 0x0401100D RID: 69645
		internal static int __PropertyOffset_AudioTetrominoStartFall;

		// Token: 0x0401100E RID: 69646
		internal static int __PropertyOffset_AudioGameFail;

		// Token: 0x0401100F RID: 69647
		internal static int __PropertyOffset_AudioGameSuccess;

		// Token: 0x04011010 RID: 69648
		internal static int __PropertyOffset_AudioGameRestart;

		// Token: 0x04011011 RID: 69649
		internal static int __PropertyOffset_AudioTetrominoRotate;

		// Token: 0x04011012 RID: 69650
		internal static int __PropertyOffset_AudioAimingMove;
	}
}

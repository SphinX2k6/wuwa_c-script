using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Gameplay.WuWaGo
{
	// Token: 0x020031D5 RID: 12757
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Gameplay/WuWaGo/BP_WuWaGo.BP_WuWaGo_C")]
	[UnrealStructLayout(1952, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1948)]
	public class BP_WuWaGo_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601FA29 RID: 129577 RVA: 0x0093216D File Offset: 0x0093036D
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_WuWaGo_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/Gameplay/WuWaGo/BP_WuWaGo.BP_WuWaGo_C");
			}
			return BP_WuWaGo_C._ClassPtr;
		}

		// Token: 0x0601FA2A RID: 129578 RVA: 0x00932194 File Offset: 0x00930394
		public BP_WuWaGo_C() : this(BuiltinUtils.AllocNativeUObject(BP_WuWaGo_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601FA2B RID: 129579 RVA: 0x009321BC File Offset: 0x009303BC
		public BP_WuWaGo_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_WuWaGo_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003A86 RID: 14982
		// (get) Token: 0x0601FA2C RID: 129580 RVA: 0x009321EF File Offset: 0x009303EF
		// (set) Token: 0x0601FA2D RID: 129581 RVA: 0x00932204 File Offset: 0x00930404
		public TSoftClassPtr<TsBaseCharacter> MainControlClass
		{
			get
			{
				return new TSoftClassPtr<TsBaseCharacter>(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_MainControlClass, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_MainControlClass, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003A87 RID: 14983
		// (get) Token: 0x0601FA2E RID: 129582 RVA: 0x00932229 File Offset: 0x00930429
		// (set) Token: 0x0601FA2F RID: 129583 RVA: 0x0093223E File Offset: 0x0093043E
		public TSoftClassPtr<TsBaseCharacter> StaticMonsterClass
		{
			get
			{
				return new TSoftClassPtr<TsBaseCharacter>(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_StaticMonsterClass, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_StaticMonsterClass, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003A88 RID: 14984
		// (get) Token: 0x0601FA30 RID: 129584 RVA: 0x00932263 File Offset: 0x00930463
		// (set) Token: 0x0601FA31 RID: 129585 RVA: 0x00932278 File Offset: 0x00930478
		public TSoftClassPtr<TsBaseCharacter> MoveMonsterClass
		{
			get
			{
				return new TSoftClassPtr<TsBaseCharacter>(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_MoveMonsterClass, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_MoveMonsterClass, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003A89 RID: 14985
		// (get) Token: 0x0601FA32 RID: 129586 RVA: 0x0093229D File Offset: 0x0093049D
		// (set) Token: 0x0601FA33 RID: 129587 RVA: 0x009322AD File Offset: 0x009304AD
		public unsafe int SingleGridSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_SingleGridSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_SingleGridSize) = value;
			}
		}

		// Token: 0x17003A8A RID: 14986
		// (get) Token: 0x0601FA34 RID: 129588 RVA: 0x009322BE File Offset: 0x009304BE
		// (set) Token: 0x0601FA35 RID: 129589 RVA: 0x009322D3 File Offset: 0x009304D3
		public TSoftObjectPtr<UMaterialInstance> SingleLinkGridMaterial
		{
			get
			{
				return new TSoftObjectPtr<UMaterialInstance>(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_SingleLinkGridMaterial, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_SingleLinkGridMaterial, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003A8B RID: 14987
		// (get) Token: 0x0601FA36 RID: 129590 RVA: 0x009322F8 File Offset: 0x009304F8
		// (set) Token: 0x0601FA37 RID: 129591 RVA: 0x0093230D File Offset: 0x0093050D
		public TSoftObjectPtr<UMaterialInstance> RightAngleLinkGridMaterial
		{
			get
			{
				return new TSoftObjectPtr<UMaterialInstance>(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_RightAngleLinkGridMaterial, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_RightAngleLinkGridMaterial, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003A8C RID: 14988
		// (get) Token: 0x0601FA38 RID: 129592 RVA: 0x00932332 File Offset: 0x00930532
		// (set) Token: 0x0601FA39 RID: 129593 RVA: 0x00932347 File Offset: 0x00930547
		public TSoftObjectPtr<UMaterialInstance> StraightLinkGridMaterial
		{
			get
			{
				return new TSoftObjectPtr<UMaterialInstance>(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_StraightLinkGridMaterial, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_StraightLinkGridMaterial, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003A8D RID: 14989
		// (get) Token: 0x0601FA3A RID: 129594 RVA: 0x0093236C File Offset: 0x0093056C
		// (set) Token: 0x0601FA3B RID: 129595 RVA: 0x00932381 File Offset: 0x00930581
		public TSoftObjectPtr<UMaterialInstance> ThreeLinkGridMaterial
		{
			get
			{
				return new TSoftObjectPtr<UMaterialInstance>(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_ThreeLinkGridMaterial, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_ThreeLinkGridMaterial, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003A8E RID: 14990
		// (get) Token: 0x0601FA3C RID: 129596 RVA: 0x009323A6 File Offset: 0x009305A6
		// (set) Token: 0x0601FA3D RID: 129597 RVA: 0x009323BB File Offset: 0x009305BB
		public TSoftObjectPtr<UMaterialInstance> AllLinkGridMaterial
		{
			get
			{
				return new TSoftObjectPtr<UMaterialInstance>(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_AllLinkGridMaterial, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_AllLinkGridMaterial, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003A8F RID: 14991
		// (get) Token: 0x0601FA3E RID: 129598 RVA: 0x009323E0 File Offset: 0x009305E0
		// (set) Token: 0x0601FA3F RID: 129599 RVA: 0x00932419 File Offset: 0x00930619
		public SWuWaGoRoleAnim StaticMonsterAnim
		{
			get
			{
				base.FastCheckIsValid();
				SWuWaGoRoleAnim result;
				if ((result = this._StaticMonsterAnim) == null)
				{
					result = (this._StaticMonsterAnim = new SWuWaGoRoleAnim(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_StaticMonsterAnim, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SWuWaGoRoleAnim.StaticStruct(), base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_StaticMonsterAnim, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003A90 RID: 14992
		// (get) Token: 0x0601FA40 RID: 129600 RVA: 0x0093243A File Offset: 0x0093063A
		// (set) Token: 0x0601FA41 RID: 129601 RVA: 0x0093244F File Offset: 0x0093064F
		public TSoftClassPtr<UKuroAnimInstanceMonster> MoveMonsterAnimationBlueprint
		{
			get
			{
				return new TSoftClassPtr<UKuroAnimInstanceMonster>(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_MoveMonsterAnimationBlueprint, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_MoveMonsterAnimationBlueprint, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003A91 RID: 14993
		// (get) Token: 0x0601FA42 RID: 129602 RVA: 0x00932474 File Offset: 0x00930674
		// (set) Token: 0x0601FA43 RID: 129603 RVA: 0x009324AD File Offset: 0x009306AD
		public SWuWaGoRoleAnim MoveMonsterAnim
		{
			get
			{
				base.FastCheckIsValid();
				SWuWaGoRoleAnim result;
				if ((result = this._MoveMonsterAnim) == null)
				{
					result = (this._MoveMonsterAnim = new SWuWaGoRoleAnim(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_MoveMonsterAnim, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SWuWaGoRoleAnim.StaticStruct(), base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_MoveMonsterAnim, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003A92 RID: 14994
		// (get) Token: 0x0601FA44 RID: 129604 RVA: 0x009324CE File Offset: 0x009306CE
		// (set) Token: 0x0601FA45 RID: 129605 RVA: 0x009324E3 File Offset: 0x009306E3
		public TSoftClassPtr<UKuroAnimInstanceMonster> MainControlAnimationBlueprint
		{
			get
			{
				return new TSoftClassPtr<UKuroAnimInstanceMonster>(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_MainControlAnimationBlueprint, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_MainControlAnimationBlueprint, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003A93 RID: 14995
		// (get) Token: 0x0601FA46 RID: 129606 RVA: 0x00932508 File Offset: 0x00930708
		// (set) Token: 0x0601FA47 RID: 129607 RVA: 0x00932541 File Offset: 0x00930741
		public SWuWaGoRoleAnim MainControlAnim
		{
			get
			{
				base.FastCheckIsValid();
				SWuWaGoRoleAnim result;
				if ((result = this._MainControlAnim) == null)
				{
					result = (this._MainControlAnim = new SWuWaGoRoleAnim(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_MainControlAnim, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SWuWaGoRoleAnim.StaticStruct(), base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_MainControlAnim, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003A94 RID: 14996
		// (get) Token: 0x0601FA48 RID: 129608 RVA: 0x00932562 File Offset: 0x00930762
		// (set) Token: 0x0601FA49 RID: 129609 RVA: 0x00932577 File Offset: 0x00930777
		public TSoftObjectPtr<UEffectModelGroup> GridHoverRedArrowEffect
		{
			get
			{
				return new TSoftObjectPtr<UEffectModelGroup>(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_GridHoverRedArrowEffect, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_GridHoverRedArrowEffect, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003A95 RID: 14997
		// (get) Token: 0x0601FA4A RID: 129610 RVA: 0x0093259C File Offset: 0x0093079C
		// (set) Token: 0x0601FA4B RID: 129611 RVA: 0x009325B1 File Offset: 0x009307B1
		public TSoftObjectPtr<UEffectModelGroup> GridHoverEffect
		{
			get
			{
				return new TSoftObjectPtr<UEffectModelGroup>(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_GridHoverEffect, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_GridHoverEffect, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003A96 RID: 14998
		// (get) Token: 0x0601FA4C RID: 129612 RVA: 0x009325D6 File Offset: 0x009307D6
		// (set) Token: 0x0601FA4D RID: 129613 RVA: 0x009325EB File Offset: 0x009307EB
		public TSoftObjectPtr<UEffectModelGroup> StartPositionGridEffect
		{
			get
			{
				return new TSoftObjectPtr<UEffectModelGroup>(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_StartPositionGridEffect, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_StartPositionGridEffect, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003A97 RID: 14999
		// (get) Token: 0x0601FA4E RID: 129614 RVA: 0x00932610 File Offset: 0x00930810
		// (set) Token: 0x0601FA4F RID: 129615 RVA: 0x00932625 File Offset: 0x00930825
		public TSoftObjectPtr<UEffectModelGroup> EndPositionGridEffect
		{
			get
			{
				return new TSoftObjectPtr<UEffectModelGroup>(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_EndPositionGridEffect, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_EndPositionGridEffect, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003A98 RID: 15000
		// (get) Token: 0x0601FA50 RID: 129616 RVA: 0x0093264A File Offset: 0x0093084A
		// (set) Token: 0x0601FA51 RID: 129617 RVA: 0x0093265F File Offset: 0x0093085F
		public TSoftObjectPtr<UMaterialInstance> CanMoveGridTipsMaterial1
		{
			get
			{
				return new TSoftObjectPtr<UMaterialInstance>(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_CanMoveGridTipsMaterial1, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_CanMoveGridTipsMaterial1, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003A99 RID: 15001
		// (get) Token: 0x0601FA52 RID: 129618 RVA: 0x00932684 File Offset: 0x00930884
		// (set) Token: 0x0601FA53 RID: 129619 RVA: 0x00932699 File Offset: 0x00930899
		public TSoftObjectPtr<UMaterialInstance> CanMoveGridTipsMaterial2
		{
			get
			{
				return new TSoftObjectPtr<UMaterialInstance>(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_CanMoveGridTipsMaterial2, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_CanMoveGridTipsMaterial2, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003A9A RID: 15002
		// (get) Token: 0x0601FA54 RID: 129620 RVA: 0x009326BE File Offset: 0x009308BE
		// (set) Token: 0x0601FA55 RID: 129621 RVA: 0x009326D3 File Offset: 0x009308D3
		public TSoftObjectPtr<UMaterialInstance> CanMoveGridTipsMaterial3
		{
			get
			{
				return new TSoftObjectPtr<UMaterialInstance>(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_CanMoveGridTipsMaterial3, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_CanMoveGridTipsMaterial3, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003A9B RID: 15003
		// (get) Token: 0x0601FA56 RID: 129622 RVA: 0x009326F8 File Offset: 0x009308F8
		// (set) Token: 0x0601FA57 RID: 129623 RVA: 0x0093270D File Offset: 0x0093090D
		public TSoftObjectPtr<UEffectModelGroup> StaticMonsterAttackRangeEffect
		{
			get
			{
				return new TSoftObjectPtr<UEffectModelGroup>(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_StaticMonsterAttackRangeEffect, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_StaticMonsterAttackRangeEffect, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003A9C RID: 15004
		// (get) Token: 0x0601FA58 RID: 129624 RVA: 0x00932732 File Offset: 0x00930932
		// (set) Token: 0x0601FA59 RID: 129625 RVA: 0x00932747 File Offset: 0x00930947
		public TSoftObjectPtr<UEffectModelGroup> MoveMonsterAttackRangeEffect
		{
			get
			{
				return new TSoftObjectPtr<UEffectModelGroup>(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_MoveMonsterAttackRangeEffect, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_MoveMonsterAttackRangeEffect, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003A9D RID: 15005
		// (get) Token: 0x0601FA5A RID: 129626 RVA: 0x0093276C File Offset: 0x0093096C
		// (set) Token: 0x0601FA5B RID: 129627 RVA: 0x0093277C File Offset: 0x0093097C
		public unsafe int TipButtonShowDeadCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_TipButtonShowDeadCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_TipButtonShowDeadCount) = value;
			}
		}

		// Token: 0x17003A9E RID: 15006
		// (get) Token: 0x0601FA5C RID: 129628 RVA: 0x0093278D File Offset: 0x0093098D
		// (set) Token: 0x0601FA5D RID: 129629 RVA: 0x0093279D File Offset: 0x0093099D
		public unsafe int SwipeMinPixelDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_SwipeMinPixelDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_SwipeMinPixelDistance) = value;
			}
		}

		// Token: 0x17003A9F RID: 15007
		// (get) Token: 0x0601FA5E RID: 129630 RVA: 0x009327AE File Offset: 0x009309AE
		// (set) Token: 0x0601FA5F RID: 129631 RVA: 0x009327BE File Offset: 0x009309BE
		public unsafe int HoverMinPixel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_HoverMinPixel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_HoverMinPixel) = value;
			}
		}

		// Token: 0x17003AA0 RID: 15008
		// (get) Token: 0x0601FA60 RID: 129632 RVA: 0x009327CF File Offset: 0x009309CF
		// (set) Token: 0x0601FA61 RID: 129633 RVA: 0x009327E3 File Offset: 0x009309E3
		public unsafe string BottomTipsKeyTouch
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_WuWaGo_C.__PropertyOffset_BottomTipsKeyTouch)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_WuWaGo_C.__PropertyOffset_BottomTipsKeyTouch)), value);
			}
		}

		// Token: 0x17003AA1 RID: 15009
		// (get) Token: 0x0601FA62 RID: 129634 RVA: 0x009327F8 File Offset: 0x009309F8
		// (set) Token: 0x0601FA63 RID: 129635 RVA: 0x0093280C File Offset: 0x00930A0C
		public unsafe string BottomTipsKeyKeyBoard
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_WuWaGo_C.__PropertyOffset_BottomTipsKeyKeyBoard)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_WuWaGo_C.__PropertyOffset_BottomTipsKeyKeyBoard)), value);
			}
		}

		// Token: 0x17003AA2 RID: 15010
		// (get) Token: 0x0601FA64 RID: 129636 RVA: 0x00932821 File Offset: 0x00930A21
		// (set) Token: 0x0601FA65 RID: 129637 RVA: 0x00932835 File Offset: 0x00930A35
		public unsafe string BottomTipsKeyGamepad
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_WuWaGo_C.__PropertyOffset_BottomTipsKeyGamepad)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_WuWaGo_C.__PropertyOffset_BottomTipsKeyGamepad)), value);
			}
		}

		// Token: 0x17003AA3 RID: 15011
		// (get) Token: 0x0601FA66 RID: 129638 RVA: 0x0093284A File Offset: 0x00930A4A
		// (set) Token: 0x0601FA67 RID: 129639 RVA: 0x0093285F File Offset: 0x00930A5F
		public TSoftObjectPtr<UAnimMontage> MainControlPullRodOpenMontage
		{
			get
			{
				return new TSoftObjectPtr<UAnimMontage>(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_MainControlPullRodOpenMontage, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_MainControlPullRodOpenMontage, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003AA4 RID: 15012
		// (get) Token: 0x0601FA68 RID: 129640 RVA: 0x00932884 File Offset: 0x00930A84
		// (set) Token: 0x0601FA69 RID: 129641 RVA: 0x00932899 File Offset: 0x00930A99
		public TSoftObjectPtr<UAnimMontage> MainControlPullRodCloseMontage
		{
			get
			{
				return new TSoftObjectPtr<UAnimMontage>(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_MainControlPullRodCloseMontage, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_MainControlPullRodCloseMontage, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003AA5 RID: 15013
		// (get) Token: 0x0601FA6A RID: 129642 RVA: 0x009328BE File Offset: 0x00930ABE
		// (set) Token: 0x0601FA6B RID: 129643 RVA: 0x009328CE File Offset: 0x00930ACE
		public unsafe int HelpId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_HelpId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_HelpId) = value;
			}
		}

		// Token: 0x17003AA6 RID: 15014
		// (get) Token: 0x0601FA6C RID: 129644 RVA: 0x009328DF File Offset: 0x00930ADF
		// (set) Token: 0x0601FA6D RID: 129645 RVA: 0x009328F3 File Offset: 0x00930AF3
		public unsafe string PlayTipsBubbleText
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_WuWaGo_C.__PropertyOffset_PlayTipsBubbleText)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_WuWaGo_C.__PropertyOffset_PlayTipsBubbleText)), value);
			}
		}

		// Token: 0x17003AA7 RID: 15015
		// (get) Token: 0x0601FA6E RID: 129646 RVA: 0x00932908 File Offset: 0x00930B08
		// (set) Token: 0x0601FA6F RID: 129647 RVA: 0x00932918 File Offset: 0x00930B18
		public unsafe int MaxRollbackCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_MaxRollbackCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_MaxRollbackCount) = value;
			}
		}

		// Token: 0x17003AA8 RID: 15016
		// (get) Token: 0x0601FA70 RID: 129648 RVA: 0x00932929 File Offset: 0x00930B29
		// (set) Token: 0x0601FA71 RID: 129649 RVA: 0x00932939 File Offset: 0x00930B39
		public unsafe int MovableFloorMoveSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_MovableFloorMoveSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_MovableFloorMoveSpeed) = value;
			}
		}

		// Token: 0x17003AA9 RID: 15017
		// (get) Token: 0x0601FA72 RID: 129650 RVA: 0x0093294A File Offset: 0x00930B4A
		// (set) Token: 0x0601FA73 RID: 129651 RVA: 0x0093295A File Offset: 0x00930B5A
		public unsafe int GearMoveDurationMs
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_GearMoveDurationMs);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_GearMoveDurationMs) = value;
			}
		}

		// Token: 0x17003AAA RID: 15018
		// (get) Token: 0x0601FA74 RID: 129652 RVA: 0x0093296B File Offset: 0x00930B6B
		// (set) Token: 0x0601FA75 RID: 129653 RVA: 0x0093297B File Offset: 0x00930B7B
		public unsafe int ArrowNoHitWaitMs
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_ArrowNoHitWaitMs);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_ArrowNoHitWaitMs) = value;
			}
		}

		// Token: 0x17003AAB RID: 15019
		// (get) Token: 0x0601FA76 RID: 129654 RVA: 0x0093298C File Offset: 0x00930B8C
		// (set) Token: 0x0601FA77 RID: 129655 RVA: 0x0093299C File Offset: 0x00930B9C
		public unsafe int CharacterMoveSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_CharacterMoveSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_CharacterMoveSpeed) = value;
			}
		}

		// Token: 0x17003AAC RID: 15020
		// (get) Token: 0x0601FA78 RID: 129656 RVA: 0x009329AD File Offset: 0x00930BAD
		// (set) Token: 0x0601FA79 RID: 129657 RVA: 0x009329BD File Offset: 0x00930BBD
		public unsafe float MontagePlayRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_MontagePlayRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_MontagePlayRate) = value;
			}
		}

		// Token: 0x17003AAD RID: 15021
		// (get) Token: 0x0601FA7A RID: 129658 RVA: 0x009329CE File Offset: 0x00930BCE
		// (set) Token: 0x0601FA7B RID: 129659 RVA: 0x009329E3 File Offset: 0x00930BE3
		public TSoftObjectPtr<UAnimMontage> AlertMontage
		{
			get
			{
				return new TSoftObjectPtr<UAnimMontage>(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_AlertMontage, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_AlertMontage, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003AAE RID: 15022
		// (get) Token: 0x0601FA7C RID: 129660 RVA: 0x00932A08 File Offset: 0x00930C08
		// (set) Token: 0x0601FA7D RID: 129661 RVA: 0x00932A1D File Offset: 0x00930C1D
		public TSoftObjectPtr<UAnimMontage> BeHitFallMontage
		{
			get
			{
				return new TSoftObjectPtr<UAnimMontage>(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_BeHitFallMontage, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_BeHitFallMontage, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003AAF RID: 15023
		// (get) Token: 0x0601FA7E RID: 129662 RVA: 0x00932A42 File Offset: 0x00930C42
		// (set) Token: 0x0601FA7F RID: 129663 RVA: 0x00932A52 File Offset: 0x00930C52
		public unsafe int SpikeFallHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_SpikeFallHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_SpikeFallHeight) = value;
			}
		}

		// Token: 0x17003AB0 RID: 15024
		// (get) Token: 0x0601FA80 RID: 129664 RVA: 0x00932A63 File Offset: 0x00930C63
		// (set) Token: 0x0601FA81 RID: 129665 RVA: 0x00932A78 File Offset: 0x00930C78
		public TSoftObjectPtr<UAnimMontage> IdleMontage
		{
			get
			{
				return new TSoftObjectPtr<UAnimMontage>(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_IdleMontage, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_IdleMontage, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003AB1 RID: 15025
		// (get) Token: 0x0601FA82 RID: 129666 RVA: 0x00932A9D File Offset: 0x00930C9D
		// (set) Token: 0x0601FA83 RID: 129667 RVA: 0x00932AAD File Offset: 0x00930CAD
		public unsafe int BowDelayMs
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_BowDelayMs);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_BowDelayMs) = value;
			}
		}

		// Token: 0x17003AB2 RID: 15026
		// (get) Token: 0x0601FA84 RID: 129668 RVA: 0x00932ABE File Offset: 0x00930CBE
		// (set) Token: 0x0601FA85 RID: 129669 RVA: 0x00932ACE File Offset: 0x00930CCE
		public unsafe int BowFlySpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_BowFlySpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_BowFlySpeed) = value;
			}
		}

		// Token: 0x17003AB3 RID: 15027
		// (get) Token: 0x0601FA86 RID: 129670 RVA: 0x00932AE0 File Offset: 0x00930CE0
		// (set) Token: 0x0601FA87 RID: 129671 RVA: 0x00932B19 File Offset: 0x00930D19
		public TArray<string> AudioEvents
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._AudioEvents) == null)
				{
					result = (this._AudioEvents = new TArray<string>(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_AudioEvents, this));
				}
				return result;
			}
			set
			{
				this.AudioEvents.CopyAssign(value);
			}
		}

		// Token: 0x17003AB4 RID: 15028
		// (get) Token: 0x0601FA88 RID: 129672 RVA: 0x00932B27 File Offset: 0x00930D27
		// (set) Token: 0x0601FA89 RID: 129673 RVA: 0x00932B3C File Offset: 0x00930D3C
		public TSoftObjectPtr<UPrimaryDataAsset> BowHitFx
		{
			get
			{
				return new TSoftObjectPtr<UPrimaryDataAsset>(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_BowHitFx, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_BowHitFx, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003AB5 RID: 15029
		// (get) Token: 0x0601FA8A RID: 129674 RVA: 0x00932B61 File Offset: 0x00930D61
		// (set) Token: 0x0601FA8B RID: 129675 RVA: 0x00932B76 File Offset: 0x00930D76
		public TSoftObjectPtr<UAnimMontage> SpikeFallMontage
		{
			get
			{
				return new TSoftObjectPtr<UAnimMontage>(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_SpikeFallMontage, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_SpikeFallMontage, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003AB6 RID: 15030
		// (get) Token: 0x0601FA8C RID: 129676 RVA: 0x00932B9B File Offset: 0x00930D9B
		// (set) Token: 0x0601FA8D RID: 129677 RVA: 0x00932BAB File Offset: 0x00930DAB
		public unsafe float BeforeAttackMoveDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_BeforeAttackMoveDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_BeforeAttackMoveDistance) = value;
			}
		}

		// Token: 0x17003AB7 RID: 15031
		// (get) Token: 0x0601FA8E RID: 129678 RVA: 0x00932BBC File Offset: 0x00930DBC
		// (set) Token: 0x0601FA8F RID: 129679 RVA: 0x00932BD1 File Offset: 0x00930DD1
		public TSoftObjectPtr<UPrimaryDataAsset> MoveFloorFx
		{
			get
			{
				return new TSoftObjectPtr<UPrimaryDataAsset>(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_MoveFloorFx, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_MoveFloorFx, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003AB8 RID: 15032
		// (get) Token: 0x0601FA90 RID: 129680 RVA: 0x00932BF6 File Offset: 0x00930DF6
		// (set) Token: 0x0601FA91 RID: 129681 RVA: 0x00932C0A File Offset: 0x00930E0A
		[Nullable(2)]
		public unsafe PD_CharacterControllerData_C PetrifyEffect
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<PD_CharacterControllerData_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WuWaGo_C.__PropertyOffset_PetrifyEffect);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WuWaGo_C.__PropertyOffset_PetrifyEffect, value);
			}
		}

		// Token: 0x17003AB9 RID: 15033
		// (get) Token: 0x0601FA92 RID: 129682 RVA: 0x00932C1F File Offset: 0x00930E1F
		// (set) Token: 0x0601FA93 RID: 129683 RVA: 0x00932C33 File Offset: 0x00930E33
		[Nullable(2)]
		public unsafe PD_CharacterControllerData_C PetrifyDissolveEffect_0
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<PD_CharacterControllerData_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WuWaGo_C.__PropertyOffset_PetrifyDissolveEffect_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WuWaGo_C.__PropertyOffset_PetrifyDissolveEffect_0, value);
			}
		}

		// Token: 0x17003ABA RID: 15034
		// (get) Token: 0x0601FA94 RID: 129684 RVA: 0x00932C48 File Offset: 0x00930E48
		// (set) Token: 0x0601FA95 RID: 129685 RVA: 0x00932C5C File Offset: 0x00930E5C
		[Nullable(2)]
		public unsafe PD_CharacterControllerData_C PetrifyDissolveEffect_1
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<PD_CharacterControllerData_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WuWaGo_C.__PropertyOffset_PetrifyDissolveEffect_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WuWaGo_C.__PropertyOffset_PetrifyDissolveEffect_1, value);
			}
		}

		// Token: 0x17003ABB RID: 15035
		// (get) Token: 0x0601FA96 RID: 129686 RVA: 0x00932C71 File Offset: 0x00930E71
		// (set) Token: 0x0601FA97 RID: 129687 RVA: 0x00932C81 File Offset: 0x00930E81
		public unsafe int ConfirmBoxId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_ConfirmBoxId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_ConfirmBoxId) = value;
			}
		}

		// Token: 0x0601FA98 RID: 129688 RVA: 0x00932C92 File Offset: 0x00930E92
		protected BP_WuWaGo_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010F80 RID: 69504
		public new const string __ObjectPath = "/Game/Aki/Data/Gameplay/WuWaGo/BP_WuWaGo.BP_WuWaGo_C";

		// Token: 0x04010F81 RID: 69505
		private static IntPtr _ClassPtr;

		// Token: 0x04010F82 RID: 69506
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010F83 RID: 69507
		internal static int __PropertyOffset_MainControlClass;

		// Token: 0x04010F84 RID: 69508
		internal static int __PropertyOffset_StaticMonsterClass;

		// Token: 0x04010F85 RID: 69509
		internal static int __PropertyOffset_MoveMonsterClass;

		// Token: 0x04010F86 RID: 69510
		internal static int __PropertyOffset_SingleGridSize;

		// Token: 0x04010F87 RID: 69511
		internal static int __PropertyOffset_SingleLinkGridMaterial;

		// Token: 0x04010F88 RID: 69512
		internal static int __PropertyOffset_RightAngleLinkGridMaterial;

		// Token: 0x04010F89 RID: 69513
		internal static int __PropertyOffset_StraightLinkGridMaterial;

		// Token: 0x04010F8A RID: 69514
		internal static int __PropertyOffset_ThreeLinkGridMaterial;

		// Token: 0x04010F8B RID: 69515
		internal static int __PropertyOffset_AllLinkGridMaterial;

		// Token: 0x04010F8C RID: 69516
		internal static int __PropertyOffset_StaticMonsterAnim;

		// Token: 0x04010F8D RID: 69517
		[Nullable(2)]
		private SWuWaGoRoleAnim _StaticMonsterAnim;

		// Token: 0x04010F8E RID: 69518
		internal static int __PropertyOffset_MoveMonsterAnimationBlueprint;

		// Token: 0x04010F8F RID: 69519
		internal static int __PropertyOffset_MoveMonsterAnim;

		// Token: 0x04010F90 RID: 69520
		[Nullable(2)]
		private SWuWaGoRoleAnim _MoveMonsterAnim;

		// Token: 0x04010F91 RID: 69521
		internal static int __PropertyOffset_MainControlAnimationBlueprint;

		// Token: 0x04010F92 RID: 69522
		internal static int __PropertyOffset_MainControlAnim;

		// Token: 0x04010F93 RID: 69523
		[Nullable(2)]
		private SWuWaGoRoleAnim _MainControlAnim;

		// Token: 0x04010F94 RID: 69524
		internal static int __PropertyOffset_GridHoverRedArrowEffect;

		// Token: 0x04010F95 RID: 69525
		internal static int __PropertyOffset_GridHoverEffect;

		// Token: 0x04010F96 RID: 69526
		internal static int __PropertyOffset_StartPositionGridEffect;

		// Token: 0x04010F97 RID: 69527
		internal static int __PropertyOffset_EndPositionGridEffect;

		// Token: 0x04010F98 RID: 69528
		internal static int __PropertyOffset_CanMoveGridTipsMaterial1;

		// Token: 0x04010F99 RID: 69529
		internal static int __PropertyOffset_CanMoveGridTipsMaterial2;

		// Token: 0x04010F9A RID: 69530
		internal static int __PropertyOffset_CanMoveGridTipsMaterial3;

		// Token: 0x04010F9B RID: 69531
		internal static int __PropertyOffset_StaticMonsterAttackRangeEffect;

		// Token: 0x04010F9C RID: 69532
		internal static int __PropertyOffset_MoveMonsterAttackRangeEffect;

		// Token: 0x04010F9D RID: 69533
		internal static int __PropertyOffset_TipButtonShowDeadCount;

		// Token: 0x04010F9E RID: 69534
		internal static int __PropertyOffset_SwipeMinPixelDistance;

		// Token: 0x04010F9F RID: 69535
		internal static int __PropertyOffset_HoverMinPixel;

		// Token: 0x04010FA0 RID: 69536
		internal static int __PropertyOffset_BottomTipsKeyTouch;

		// Token: 0x04010FA1 RID: 69537
		internal static int __PropertyOffset_BottomTipsKeyKeyBoard;

		// Token: 0x04010FA2 RID: 69538
		internal static int __PropertyOffset_BottomTipsKeyGamepad;

		// Token: 0x04010FA3 RID: 69539
		internal static int __PropertyOffset_MainControlPullRodOpenMontage;

		// Token: 0x04010FA4 RID: 69540
		internal static int __PropertyOffset_MainControlPullRodCloseMontage;

		// Token: 0x04010FA5 RID: 69541
		internal static int __PropertyOffset_HelpId;

		// Token: 0x04010FA6 RID: 69542
		internal static int __PropertyOffset_PlayTipsBubbleText;

		// Token: 0x04010FA7 RID: 69543
		internal static int __PropertyOffset_MaxRollbackCount;

		// Token: 0x04010FA8 RID: 69544
		internal static int __PropertyOffset_MovableFloorMoveSpeed;

		// Token: 0x04010FA9 RID: 69545
		internal static int __PropertyOffset_GearMoveDurationMs;

		// Token: 0x04010FAA RID: 69546
		internal static int __PropertyOffset_ArrowNoHitWaitMs;

		// Token: 0x04010FAB RID: 69547
		internal static int __PropertyOffset_CharacterMoveSpeed;

		// Token: 0x04010FAC RID: 69548
		internal static int __PropertyOffset_MontagePlayRate;

		// Token: 0x04010FAD RID: 69549
		internal static int __PropertyOffset_AlertMontage;

		// Token: 0x04010FAE RID: 69550
		internal static int __PropertyOffset_BeHitFallMontage;

		// Token: 0x04010FAF RID: 69551
		internal static int __PropertyOffset_SpikeFallHeight;

		// Token: 0x04010FB0 RID: 69552
		internal static int __PropertyOffset_IdleMontage;

		// Token: 0x04010FB1 RID: 69553
		internal static int __PropertyOffset_BowDelayMs;

		// Token: 0x04010FB2 RID: 69554
		internal static int __PropertyOffset_BowFlySpeed;

		// Token: 0x04010FB3 RID: 69555
		internal static int __PropertyOffset_AudioEvents;

		// Token: 0x04010FB4 RID: 69556
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _AudioEvents;

		// Token: 0x04010FB5 RID: 69557
		internal static int __PropertyOffset_BowHitFx;

		// Token: 0x04010FB6 RID: 69558
		internal static int __PropertyOffset_SpikeFallMontage;

		// Token: 0x04010FB7 RID: 69559
		internal static int __PropertyOffset_BeforeAttackMoveDistance;

		// Token: 0x04010FB8 RID: 69560
		internal static int __PropertyOffset_MoveFloorFx;

		// Token: 0x04010FB9 RID: 69561
		internal static int __PropertyOffset_PetrifyEffect;

		// Token: 0x04010FBA RID: 69562
		internal static int __PropertyOffset_PetrifyDissolveEffect_0;

		// Token: 0x04010FBB RID: 69563
		internal static int __PropertyOffset_PetrifyDissolveEffect_1;

		// Token: 0x04010FBC RID: 69564
		internal static int __PropertyOffset_ConfirmBoxId;
	}
}

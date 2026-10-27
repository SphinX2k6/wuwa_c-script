using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Gameplay.WuWaGo
{
	// Token: 0x02003F29 RID: 16169
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Gameplay/WuWaGo/BP_WuWaGo.BP_WuWaGo_C")]
	[UnrealStructLayout(1952, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1948)]
	public class BP_WuWaGo_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06029116 RID: 168214 RVA: 0x009BAFEB File Offset: 0x009B91EB
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_WuWaGo_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/Gameplay/WuWaGo/BP_WuWaGo.BP_WuWaGo_C");
			}
			return BP_WuWaGo_C._ClassPtr;
		}

		// Token: 0x06029117 RID: 168215 RVA: 0x009BB010 File Offset: 0x009B9210
		public BP_WuWaGo_C() : this(BuiltinUtils.AllocNativeUObject(BP_WuWaGo_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06029118 RID: 168216 RVA: 0x009BB038 File Offset: 0x009B9238
		public BP_WuWaGo_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_WuWaGo_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700613A RID: 24890
		// (get) Token: 0x06029119 RID: 168217 RVA: 0x009BB06B File Offset: 0x009B926B
		// (set) Token: 0x0602911A RID: 168218 RVA: 0x009BB080 File Offset: 0x009B9280
		public TSoftClassPtr<TsBaseCharacter> MainControlClass
		{
			get
			{
				return new TSoftClassPtr<TsBaseCharacter>(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_0, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_0, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x1700613B RID: 24891
		// (get) Token: 0x0602911B RID: 168219 RVA: 0x009BB0A5 File Offset: 0x009B92A5
		// (set) Token: 0x0602911C RID: 168220 RVA: 0x009BB0BA File Offset: 0x009B92BA
		public TSoftClassPtr<TsBaseCharacter> StaticMonsterClass
		{
			get
			{
				return new TSoftClassPtr<TsBaseCharacter>(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_1, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_1, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x1700613C RID: 24892
		// (get) Token: 0x0602911D RID: 168221 RVA: 0x009BB0DF File Offset: 0x009B92DF
		// (set) Token: 0x0602911E RID: 168222 RVA: 0x009BB0F4 File Offset: 0x009B92F4
		public TSoftClassPtr<TsBaseCharacter> MoveMonsterClass
		{
			get
			{
				return new TSoftClassPtr<TsBaseCharacter>(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_2, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_2, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x1700613D RID: 24893
		// (get) Token: 0x0602911F RID: 168223 RVA: 0x009BB119 File Offset: 0x009B9319
		// (set) Token: 0x06029120 RID: 168224 RVA: 0x009BB129 File Offset: 0x009B9329
		public unsafe int SingleGridSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x1700613E RID: 24894
		// (get) Token: 0x06029121 RID: 168225 RVA: 0x009BB13A File Offset: 0x009B933A
		// (set) Token: 0x06029122 RID: 168226 RVA: 0x009BB14F File Offset: 0x009B934F
		public TSoftObjectPtr<UMaterialInstance> SingleLinkGridMaterial
		{
			get
			{
				return new TSoftObjectPtr<UMaterialInstance>(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_4, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_4, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x1700613F RID: 24895
		// (get) Token: 0x06029123 RID: 168227 RVA: 0x009BB174 File Offset: 0x009B9374
		// (set) Token: 0x06029124 RID: 168228 RVA: 0x009BB189 File Offset: 0x009B9389
		public TSoftObjectPtr<UMaterialInstance> RightAngleLinkGridMaterial
		{
			get
			{
				return new TSoftObjectPtr<UMaterialInstance>(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_5, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_5, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17006140 RID: 24896
		// (get) Token: 0x06029125 RID: 168229 RVA: 0x009BB1AE File Offset: 0x009B93AE
		// (set) Token: 0x06029126 RID: 168230 RVA: 0x009BB1C3 File Offset: 0x009B93C3
		public TSoftObjectPtr<UMaterialInstance> StraightLinkGridMaterial
		{
			get
			{
				return new TSoftObjectPtr<UMaterialInstance>(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_6, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_6, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17006141 RID: 24897
		// (get) Token: 0x06029127 RID: 168231 RVA: 0x009BB1E8 File Offset: 0x009B93E8
		// (set) Token: 0x06029128 RID: 168232 RVA: 0x009BB1FD File Offset: 0x009B93FD
		public TSoftObjectPtr<UMaterialInstance> ThreeLinkGridMaterial
		{
			get
			{
				return new TSoftObjectPtr<UMaterialInstance>(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_7, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_7, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17006142 RID: 24898
		// (get) Token: 0x06029129 RID: 168233 RVA: 0x009BB222 File Offset: 0x009B9422
		// (set) Token: 0x0602912A RID: 168234 RVA: 0x009BB237 File Offset: 0x009B9437
		public TSoftObjectPtr<UMaterialInstance> AllLinkGridMaterial
		{
			get
			{
				return new TSoftObjectPtr<UMaterialInstance>(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_8, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_8, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17006143 RID: 24899
		// (get) Token: 0x0602912B RID: 168235 RVA: 0x009BB25C File Offset: 0x009B945C
		// (set) Token: 0x0602912C RID: 168236 RVA: 0x009BB295 File Offset: 0x009B9495
		public SWuWaGoRoleAnim StaticMonsterAnim
		{
			get
			{
				base.FastCheckIsValid();
				SWuWaGoRoleAnim result;
				if ((result = this._StaticMonsterAnim) == null)
				{
					result = (this._StaticMonsterAnim = new SWuWaGoRoleAnim(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_9, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SWuWaGoRoleAnim.StaticStruct(), base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_9, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006144 RID: 24900
		// (get) Token: 0x0602912D RID: 168237 RVA: 0x009BB2B6 File Offset: 0x009B94B6
		// (set) Token: 0x0602912E RID: 168238 RVA: 0x009BB2CB File Offset: 0x009B94CB
		public TSoftClassPtr<UKuroAnimInstanceMonster> MoveMonsterAnimationBlueprint
		{
			get
			{
				return new TSoftClassPtr<UKuroAnimInstanceMonster>(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_10, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_10, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17006145 RID: 24901
		// (get) Token: 0x0602912F RID: 168239 RVA: 0x009BB2F0 File Offset: 0x009B94F0
		// (set) Token: 0x06029130 RID: 168240 RVA: 0x009BB329 File Offset: 0x009B9529
		public SWuWaGoRoleAnim MoveMonsterAnim
		{
			get
			{
				base.FastCheckIsValid();
				SWuWaGoRoleAnim result;
				if ((result = this._MoveMonsterAnim) == null)
				{
					result = (this._MoveMonsterAnim = new SWuWaGoRoleAnim(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_11, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SWuWaGoRoleAnim.StaticStruct(), base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_11, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006146 RID: 24902
		// (get) Token: 0x06029131 RID: 168241 RVA: 0x009BB34A File Offset: 0x009B954A
		// (set) Token: 0x06029132 RID: 168242 RVA: 0x009BB35F File Offset: 0x009B955F
		public TSoftClassPtr<UKuroAnimInstanceMonster> MainControlAnimationBlueprint
		{
			get
			{
				return new TSoftClassPtr<UKuroAnimInstanceMonster>(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_12, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_12, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17006147 RID: 24903
		// (get) Token: 0x06029133 RID: 168243 RVA: 0x009BB384 File Offset: 0x009B9584
		// (set) Token: 0x06029134 RID: 168244 RVA: 0x009BB3BD File Offset: 0x009B95BD
		public SWuWaGoRoleAnim MainControlAnim
		{
			get
			{
				base.FastCheckIsValid();
				SWuWaGoRoleAnim result;
				if ((result = this._MainControlAnim) == null)
				{
					result = (this._MainControlAnim = new SWuWaGoRoleAnim(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_13, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SWuWaGoRoleAnim.StaticStruct(), base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_13, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006148 RID: 24904
		// (get) Token: 0x06029135 RID: 168245 RVA: 0x009BB3DE File Offset: 0x009B95DE
		// (set) Token: 0x06029136 RID: 168246 RVA: 0x009BB3F3 File Offset: 0x009B95F3
		public TSoftObjectPtr<UEffectModelGroup> GridHoverRedArrowEffect
		{
			get
			{
				return new TSoftObjectPtr<UEffectModelGroup>(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_14, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_14, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17006149 RID: 24905
		// (get) Token: 0x06029137 RID: 168247 RVA: 0x009BB418 File Offset: 0x009B9618
		// (set) Token: 0x06029138 RID: 168248 RVA: 0x009BB42D File Offset: 0x009B962D
		public TSoftObjectPtr<UEffectModelGroup> GridHoverEffect
		{
			get
			{
				return new TSoftObjectPtr<UEffectModelGroup>(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_15, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_15, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x1700614A RID: 24906
		// (get) Token: 0x06029139 RID: 168249 RVA: 0x009BB452 File Offset: 0x009B9652
		// (set) Token: 0x0602913A RID: 168250 RVA: 0x009BB467 File Offset: 0x009B9667
		public TSoftObjectPtr<UEffectModelGroup> StartPositionGridEffect
		{
			get
			{
				return new TSoftObjectPtr<UEffectModelGroup>(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_16, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_16, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x1700614B RID: 24907
		// (get) Token: 0x0602913B RID: 168251 RVA: 0x009BB48C File Offset: 0x009B968C
		// (set) Token: 0x0602913C RID: 168252 RVA: 0x009BB4A1 File Offset: 0x009B96A1
		public TSoftObjectPtr<UEffectModelGroup> EndPositionGridEffect
		{
			get
			{
				return new TSoftObjectPtr<UEffectModelGroup>(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_17, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_17, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x1700614C RID: 24908
		// (get) Token: 0x0602913D RID: 168253 RVA: 0x009BB4C6 File Offset: 0x009B96C6
		// (set) Token: 0x0602913E RID: 168254 RVA: 0x009BB4DB File Offset: 0x009B96DB
		public TSoftObjectPtr<UMaterialInstance> CanMoveGridTipsMaterial1
		{
			get
			{
				return new TSoftObjectPtr<UMaterialInstance>(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_18, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_18, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x1700614D RID: 24909
		// (get) Token: 0x0602913F RID: 168255 RVA: 0x009BB500 File Offset: 0x009B9700
		// (set) Token: 0x06029140 RID: 168256 RVA: 0x009BB515 File Offset: 0x009B9715
		public TSoftObjectPtr<UMaterialInstance> CanMoveGridTipsMaterial2
		{
			get
			{
				return new TSoftObjectPtr<UMaterialInstance>(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_19, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_19, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x1700614E RID: 24910
		// (get) Token: 0x06029141 RID: 168257 RVA: 0x009BB53A File Offset: 0x009B973A
		// (set) Token: 0x06029142 RID: 168258 RVA: 0x009BB54F File Offset: 0x009B974F
		public TSoftObjectPtr<UMaterialInstance> CanMoveGridTipsMaterial3
		{
			get
			{
				return new TSoftObjectPtr<UMaterialInstance>(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_20, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_20, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x1700614F RID: 24911
		// (get) Token: 0x06029143 RID: 168259 RVA: 0x009BB574 File Offset: 0x009B9774
		// (set) Token: 0x06029144 RID: 168260 RVA: 0x009BB589 File Offset: 0x009B9789
		public TSoftObjectPtr<UEffectModelGroup> StaticMonsterAttackRangeEffect
		{
			get
			{
				return new TSoftObjectPtr<UEffectModelGroup>(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_21, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_21, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17006150 RID: 24912
		// (get) Token: 0x06029145 RID: 168261 RVA: 0x009BB5AE File Offset: 0x009B97AE
		// (set) Token: 0x06029146 RID: 168262 RVA: 0x009BB5C3 File Offset: 0x009B97C3
		public TSoftObjectPtr<UEffectModelGroup> MoveMonsterAttackRangeEffect
		{
			get
			{
				return new TSoftObjectPtr<UEffectModelGroup>(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_22, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_22, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17006151 RID: 24913
		// (get) Token: 0x06029147 RID: 168263 RVA: 0x009BB5E8 File Offset: 0x009B97E8
		// (set) Token: 0x06029148 RID: 168264 RVA: 0x009BB5F8 File Offset: 0x009B97F8
		public unsafe int TipButtonShowDeadCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x17006152 RID: 24914
		// (get) Token: 0x06029149 RID: 168265 RVA: 0x009BB609 File Offset: 0x009B9809
		// (set) Token: 0x0602914A RID: 168266 RVA: 0x009BB619 File Offset: 0x009B9819
		public unsafe int SwipeMinPixelDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_24);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_24) = value;
			}
		}

		// Token: 0x17006153 RID: 24915
		// (get) Token: 0x0602914B RID: 168267 RVA: 0x009BB62A File Offset: 0x009B982A
		// (set) Token: 0x0602914C RID: 168268 RVA: 0x009BB63A File Offset: 0x009B983A
		public unsafe int HoverMinPixel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_25);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_25) = value;
			}
		}

		// Token: 0x17006154 RID: 24916
		// (get) Token: 0x0602914D RID: 168269 RVA: 0x009BB64B File Offset: 0x009B984B
		// (set) Token: 0x0602914E RID: 168270 RVA: 0x009BB65F File Offset: 0x009B985F
		public unsafe string BottomTipsKeyTouch
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_WuWaGo_C.__PropertyOffset_26)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_WuWaGo_C.__PropertyOffset_26)), value);
			}
		}

		// Token: 0x17006155 RID: 24917
		// (get) Token: 0x0602914F RID: 168271 RVA: 0x009BB674 File Offset: 0x009B9874
		// (set) Token: 0x06029150 RID: 168272 RVA: 0x009BB688 File Offset: 0x009B9888
		public unsafe string BottomTipsKeyKeyBoard
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_WuWaGo_C.__PropertyOffset_27)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_WuWaGo_C.__PropertyOffset_27)), value);
			}
		}

		// Token: 0x17006156 RID: 24918
		// (get) Token: 0x06029151 RID: 168273 RVA: 0x009BB69D File Offset: 0x009B989D
		// (set) Token: 0x06029152 RID: 168274 RVA: 0x009BB6B1 File Offset: 0x009B98B1
		public unsafe string BottomTipsKeyGamepad
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_WuWaGo_C.__PropertyOffset_28)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_WuWaGo_C.__PropertyOffset_28)), value);
			}
		}

		// Token: 0x17006157 RID: 24919
		// (get) Token: 0x06029153 RID: 168275 RVA: 0x009BB6C6 File Offset: 0x009B98C6
		// (set) Token: 0x06029154 RID: 168276 RVA: 0x009BB6DB File Offset: 0x009B98DB
		public TSoftObjectPtr<UAnimMontage> MainControlPullRodOpenMontage
		{
			get
			{
				return new TSoftObjectPtr<UAnimMontage>(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_29, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_29, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17006158 RID: 24920
		// (get) Token: 0x06029155 RID: 168277 RVA: 0x009BB700 File Offset: 0x009B9900
		// (set) Token: 0x06029156 RID: 168278 RVA: 0x009BB715 File Offset: 0x009B9915
		public TSoftObjectPtr<UAnimMontage> MainControlPullRodCloseMontage
		{
			get
			{
				return new TSoftObjectPtr<UAnimMontage>(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_30, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_30, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17006159 RID: 24921
		// (get) Token: 0x06029157 RID: 168279 RVA: 0x009BB73A File Offset: 0x009B993A
		// (set) Token: 0x06029158 RID: 168280 RVA: 0x009BB74A File Offset: 0x009B994A
		public unsafe int HelpId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_31);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_31) = value;
			}
		}

		// Token: 0x1700615A RID: 24922
		// (get) Token: 0x06029159 RID: 168281 RVA: 0x009BB75B File Offset: 0x009B995B
		// (set) Token: 0x0602915A RID: 168282 RVA: 0x009BB76F File Offset: 0x009B996F
		public unsafe string PlayTipsBubbleText
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_WuWaGo_C.__PropertyOffset_32)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_WuWaGo_C.__PropertyOffset_32)), value);
			}
		}

		// Token: 0x1700615B RID: 24923
		// (get) Token: 0x0602915B RID: 168283 RVA: 0x009BB784 File Offset: 0x009B9984
		// (set) Token: 0x0602915C RID: 168284 RVA: 0x009BB794 File Offset: 0x009B9994
		public unsafe int MaxRollbackCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_33);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_33) = value;
			}
		}

		// Token: 0x1700615C RID: 24924
		// (get) Token: 0x0602915D RID: 168285 RVA: 0x009BB7A5 File Offset: 0x009B99A5
		// (set) Token: 0x0602915E RID: 168286 RVA: 0x009BB7B5 File Offset: 0x009B99B5
		public unsafe int MovableFloorMoveSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_34);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_34) = value;
			}
		}

		// Token: 0x1700615D RID: 24925
		// (get) Token: 0x0602915F RID: 168287 RVA: 0x009BB7C6 File Offset: 0x009B99C6
		// (set) Token: 0x06029160 RID: 168288 RVA: 0x009BB7D6 File Offset: 0x009B99D6
		public unsafe int GearMoveDurationMs
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_35);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_35) = value;
			}
		}

		// Token: 0x1700615E RID: 24926
		// (get) Token: 0x06029161 RID: 168289 RVA: 0x009BB7E7 File Offset: 0x009B99E7
		// (set) Token: 0x06029162 RID: 168290 RVA: 0x009BB7F7 File Offset: 0x009B99F7
		public unsafe int ArrowNoHitWaitMs
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_36);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_36) = value;
			}
		}

		// Token: 0x1700615F RID: 24927
		// (get) Token: 0x06029163 RID: 168291 RVA: 0x009BB808 File Offset: 0x009B9A08
		// (set) Token: 0x06029164 RID: 168292 RVA: 0x009BB818 File Offset: 0x009B9A18
		public unsafe int CharacterMoveSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_37);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_37) = value;
			}
		}

		// Token: 0x17006160 RID: 24928
		// (get) Token: 0x06029165 RID: 168293 RVA: 0x009BB829 File Offset: 0x009B9A29
		// (set) Token: 0x06029166 RID: 168294 RVA: 0x009BB839 File Offset: 0x009B9A39
		public unsafe float MontagePlayRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_38);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_38) = value;
			}
		}

		// Token: 0x17006161 RID: 24929
		// (get) Token: 0x06029167 RID: 168295 RVA: 0x009BB84A File Offset: 0x009B9A4A
		// (set) Token: 0x06029168 RID: 168296 RVA: 0x009BB85F File Offset: 0x009B9A5F
		public TSoftObjectPtr<UAnimMontage> AlertMontage
		{
			get
			{
				return new TSoftObjectPtr<UAnimMontage>(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_39, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_39, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17006162 RID: 24930
		// (get) Token: 0x06029169 RID: 168297 RVA: 0x009BB884 File Offset: 0x009B9A84
		// (set) Token: 0x0602916A RID: 168298 RVA: 0x009BB899 File Offset: 0x009B9A99
		public TSoftObjectPtr<UAnimMontage> BeHitFallMontage
		{
			get
			{
				return new TSoftObjectPtr<UAnimMontage>(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_40, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_40, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17006163 RID: 24931
		// (get) Token: 0x0602916B RID: 168299 RVA: 0x009BB8BE File Offset: 0x009B9ABE
		// (set) Token: 0x0602916C RID: 168300 RVA: 0x009BB8CE File Offset: 0x009B9ACE
		public unsafe int SpikeFallHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_41);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_41) = value;
			}
		}

		// Token: 0x17006164 RID: 24932
		// (get) Token: 0x0602916D RID: 168301 RVA: 0x009BB8DF File Offset: 0x009B9ADF
		// (set) Token: 0x0602916E RID: 168302 RVA: 0x009BB8F4 File Offset: 0x009B9AF4
		public TSoftObjectPtr<UAnimMontage> IdleMontage
		{
			get
			{
				return new TSoftObjectPtr<UAnimMontage>(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_42, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_42, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17006165 RID: 24933
		// (get) Token: 0x0602916F RID: 168303 RVA: 0x009BB919 File Offset: 0x009B9B19
		// (set) Token: 0x06029170 RID: 168304 RVA: 0x009BB929 File Offset: 0x009B9B29
		public unsafe int BowDelayMs
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_43);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_43) = value;
			}
		}

		// Token: 0x17006166 RID: 24934
		// (get) Token: 0x06029171 RID: 168305 RVA: 0x009BB93A File Offset: 0x009B9B3A
		// (set) Token: 0x06029172 RID: 168306 RVA: 0x009BB94A File Offset: 0x009B9B4A
		public unsafe int BowFlySpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_44);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_44) = value;
			}
		}

		// Token: 0x17006167 RID: 24935
		// (get) Token: 0x06029173 RID: 168307 RVA: 0x009BB95C File Offset: 0x009B9B5C
		// (set) Token: 0x06029174 RID: 168308 RVA: 0x009BB995 File Offset: 0x009B9B95
		public TArray<string> AudioEvents
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._AudioEvents) == null)
				{
					result = (this._AudioEvents = new TArray<string>(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_45, this));
				}
				return result;
			}
			set
			{
				this.AudioEvents.CopyAssign(value);
			}
		}

		// Token: 0x17006168 RID: 24936
		// (get) Token: 0x06029175 RID: 168309 RVA: 0x009BB9A3 File Offset: 0x009B9BA3
		// (set) Token: 0x06029176 RID: 168310 RVA: 0x009BB9B8 File Offset: 0x009B9BB8
		public TSoftObjectPtr<UPrimaryDataAsset> BowHitFx
		{
			get
			{
				return new TSoftObjectPtr<UPrimaryDataAsset>(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_46, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_46, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17006169 RID: 24937
		// (get) Token: 0x06029177 RID: 168311 RVA: 0x009BB9DD File Offset: 0x009B9BDD
		// (set) Token: 0x06029178 RID: 168312 RVA: 0x009BB9F2 File Offset: 0x009B9BF2
		public TSoftObjectPtr<UAnimMontage> SpikeFallMontage
		{
			get
			{
				return new TSoftObjectPtr<UAnimMontage>(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_47, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_47, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x1700616A RID: 24938
		// (get) Token: 0x06029179 RID: 168313 RVA: 0x009BBA17 File Offset: 0x009B9C17
		// (set) Token: 0x0602917A RID: 168314 RVA: 0x009BBA27 File Offset: 0x009B9C27
		public unsafe float BeforeAttackMoveDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_48);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_48) = value;
			}
		}

		// Token: 0x1700616B RID: 24939
		// (get) Token: 0x0602917B RID: 168315 RVA: 0x009BBA38 File Offset: 0x009B9C38
		// (set) Token: 0x0602917C RID: 168316 RVA: 0x009BBA4D File Offset: 0x009B9C4D
		public TSoftObjectPtr<UPrimaryDataAsset> MoveFloorFx
		{
			get
			{
				return new TSoftObjectPtr<UPrimaryDataAsset>(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_49, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_49, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x1700616C RID: 24940
		// (get) Token: 0x0602917D RID: 168317 RVA: 0x009BBA72 File Offset: 0x009B9C72
		// (set) Token: 0x0602917E RID: 168318 RVA: 0x009BBA86 File Offset: 0x009B9C86
		[Nullable(2)]
		public unsafe PD_CharacterControllerData_C PetrifyEffect
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<PD_CharacterControllerData_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WuWaGo_C.__PropertyOffset_50);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WuWaGo_C.__PropertyOffset_50, value);
			}
		}

		// Token: 0x1700616D RID: 24941
		// (get) Token: 0x0602917F RID: 168319 RVA: 0x009BBA9B File Offset: 0x009B9C9B
		// (set) Token: 0x06029180 RID: 168320 RVA: 0x009BBAAF File Offset: 0x009B9CAF
		[Nullable(2)]
		public unsafe PD_CharacterControllerData_C PetrifyDissolveEffect_0
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<PD_CharacterControllerData_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WuWaGo_C.__PropertyOffset_51);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WuWaGo_C.__PropertyOffset_51, value);
			}
		}

		// Token: 0x1700616E RID: 24942
		// (get) Token: 0x06029181 RID: 168321 RVA: 0x009BBAC4 File Offset: 0x009B9CC4
		// (set) Token: 0x06029182 RID: 168322 RVA: 0x009BBAD8 File Offset: 0x009B9CD8
		[Nullable(2)]
		public unsafe PD_CharacterControllerData_C PetrifyDissolveEffect_1
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<PD_CharacterControllerData_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WuWaGo_C.__PropertyOffset_52);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WuWaGo_C.__PropertyOffset_52, value);
			}
		}

		// Token: 0x1700616F RID: 24943
		// (get) Token: 0x06029183 RID: 168323 RVA: 0x009BBAED File Offset: 0x009B9CED
		// (set) Token: 0x06029184 RID: 168324 RVA: 0x009BBAFD File Offset: 0x009B9CFD
		public unsafe int ConfirmBoxId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_53);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WuWaGo_C.__PropertyOffset_53) = value;
			}
		}

		// Token: 0x06029185 RID: 168325 RVA: 0x009BBB0E File Offset: 0x009B9D0E
		protected BP_WuWaGo_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015050 RID: 86096
		public new const string __ObjectPath = "/Game/Aki/Data/Gameplay/WuWaGo/BP_WuWaGo.BP_WuWaGo_C";

		// Token: 0x04015051 RID: 86097
		private static IntPtr _ClassPtr;

		// Token: 0x04015052 RID: 86098
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015053 RID: 86099
		internal static int __PropertyOffset_0;

		// Token: 0x04015054 RID: 86100
		internal static int __PropertyOffset_1;

		// Token: 0x04015055 RID: 86101
		internal static int __PropertyOffset_2;

		// Token: 0x04015056 RID: 86102
		internal static int __PropertyOffset_3;

		// Token: 0x04015057 RID: 86103
		internal static int __PropertyOffset_4;

		// Token: 0x04015058 RID: 86104
		internal static int __PropertyOffset_5;

		// Token: 0x04015059 RID: 86105
		internal static int __PropertyOffset_6;

		// Token: 0x0401505A RID: 86106
		internal static int __PropertyOffset_7;

		// Token: 0x0401505B RID: 86107
		internal static int __PropertyOffset_8;

		// Token: 0x0401505C RID: 86108
		internal static int __PropertyOffset_9;

		// Token: 0x0401505D RID: 86109
		[Nullable(2)]
		private SWuWaGoRoleAnim _StaticMonsterAnim;

		// Token: 0x0401505E RID: 86110
		internal static int __PropertyOffset_10;

		// Token: 0x0401505F RID: 86111
		internal static int __PropertyOffset_11;

		// Token: 0x04015060 RID: 86112
		[Nullable(2)]
		private SWuWaGoRoleAnim _MoveMonsterAnim;

		// Token: 0x04015061 RID: 86113
		internal static int __PropertyOffset_12;

		// Token: 0x04015062 RID: 86114
		internal static int __PropertyOffset_13;

		// Token: 0x04015063 RID: 86115
		[Nullable(2)]
		private SWuWaGoRoleAnim _MainControlAnim;

		// Token: 0x04015064 RID: 86116
		internal static int __PropertyOffset_14;

		// Token: 0x04015065 RID: 86117
		internal static int __PropertyOffset_15;

		// Token: 0x04015066 RID: 86118
		internal static int __PropertyOffset_16;

		// Token: 0x04015067 RID: 86119
		internal static int __PropertyOffset_17;

		// Token: 0x04015068 RID: 86120
		internal static int __PropertyOffset_18;

		// Token: 0x04015069 RID: 86121
		internal static int __PropertyOffset_19;

		// Token: 0x0401506A RID: 86122
		internal static int __PropertyOffset_20;

		// Token: 0x0401506B RID: 86123
		internal static int __PropertyOffset_21;

		// Token: 0x0401506C RID: 86124
		internal static int __PropertyOffset_22;

		// Token: 0x0401506D RID: 86125
		internal static int __PropertyOffset_23;

		// Token: 0x0401506E RID: 86126
		internal static int __PropertyOffset_24;

		// Token: 0x0401506F RID: 86127
		internal static int __PropertyOffset_25;

		// Token: 0x04015070 RID: 86128
		internal static int __PropertyOffset_26;

		// Token: 0x04015071 RID: 86129
		internal static int __PropertyOffset_27;

		// Token: 0x04015072 RID: 86130
		internal static int __PropertyOffset_28;

		// Token: 0x04015073 RID: 86131
		internal static int __PropertyOffset_29;

		// Token: 0x04015074 RID: 86132
		internal static int __PropertyOffset_30;

		// Token: 0x04015075 RID: 86133
		internal static int __PropertyOffset_31;

		// Token: 0x04015076 RID: 86134
		internal static int __PropertyOffset_32;

		// Token: 0x04015077 RID: 86135
		internal static int __PropertyOffset_33;

		// Token: 0x04015078 RID: 86136
		internal static int __PropertyOffset_34;

		// Token: 0x04015079 RID: 86137
		internal static int __PropertyOffset_35;

		// Token: 0x0401507A RID: 86138
		internal static int __PropertyOffset_36;

		// Token: 0x0401507B RID: 86139
		internal static int __PropertyOffset_37;

		// Token: 0x0401507C RID: 86140
		internal static int __PropertyOffset_38;

		// Token: 0x0401507D RID: 86141
		internal static int __PropertyOffset_39;

		// Token: 0x0401507E RID: 86142
		internal static int __PropertyOffset_40;

		// Token: 0x0401507F RID: 86143
		internal static int __PropertyOffset_41;

		// Token: 0x04015080 RID: 86144
		internal static int __PropertyOffset_42;

		// Token: 0x04015081 RID: 86145
		internal static int __PropertyOffset_43;

		// Token: 0x04015082 RID: 86146
		internal static int __PropertyOffset_44;

		// Token: 0x04015083 RID: 86147
		internal static int __PropertyOffset_45;

		// Token: 0x04015084 RID: 86148
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _AudioEvents;

		// Token: 0x04015085 RID: 86149
		internal static int __PropertyOffset_46;

		// Token: 0x04015086 RID: 86150
		internal static int __PropertyOffset_47;

		// Token: 0x04015087 RID: 86151
		internal static int __PropertyOffset_48;

		// Token: 0x04015088 RID: 86152
		internal static int __PropertyOffset_49;

		// Token: 0x04015089 RID: 86153
		internal static int __PropertyOffset_50;

		// Token: 0x0401508A RID: 86154
		internal static int __PropertyOffset_51;

		// Token: 0x0401508B RID: 86155
		internal static int __PropertyOffset_52;

		// Token: 0x0401508C RID: 86156
		internal static int __PropertyOffset_53;
	}
}

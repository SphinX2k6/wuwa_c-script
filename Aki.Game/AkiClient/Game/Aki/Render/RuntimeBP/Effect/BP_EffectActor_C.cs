using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Data.Effect.Struct;
using AkiClient.Game.Aki.Render.RuntimeBP.Effect.Data;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Effect
{
	// Token: 0x02003DB5 RID: 15797
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Effect/BP_EffectActor.BP_EffectActor_C")]
	[UnrealStructLayout(1360, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1355)]
	public class BP_EffectActor_C : AKuroSceneEffectActor, IUnrealUObject, IUnrealObject, IBPI_EffectInterface_C, IUnrealBlueprintInterface, IUnrealInterface
	{
		// Token: 0x060273ED RID: 160749 RVA: 0x0098C1EF File Offset: 0x0098A3EF
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_EffectActor_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Effect/BP_EffectActor.BP_EffectActor_C");
			}
			return BP_EffectActor_C._ClassPtr;
		}

		// Token: 0x060273EE RID: 160750 RVA: 0x0098C214 File Offset: 0x0098A414
		public BP_EffectActor_C() : this(BuiltinUtils.AllocNativeUObject(BP_EffectActor_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060273EF RID: 160751 RVA: 0x0098C23C File Offset: 0x0098A43C
		public BP_EffectActor_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_EffectActor_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005707 RID: 22279
		// (get) Token: 0x060273F0 RID: 160752 RVA: 0x0098C26F File Offset: 0x0098A46F
		// (set) Token: 0x060273F1 RID: 160753 RVA: 0x0098C283 File Offset: 0x0098A483
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_EffectActor_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_EffectActor_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17005708 RID: 22280
		// (get) Token: 0x060273F2 RID: 160754 RVA: 0x0098C298 File Offset: 0x0098A498
		// (set) Token: 0x060273F3 RID: 160755 RVA: 0x0098C2D1 File Offset: 0x0098A4D1
		public FSoftObjectPath EffectData
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._EffectData) == null)
				{
					result = (this._EffectData = new FSoftObjectPath(base.NativePtr + (IntPtr)BP_EffectActor_C.__PropertyOffset_2, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)BP_EffectActor_C.__PropertyOffset_2, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005709 RID: 22281
		// (get) Token: 0x060273F4 RID: 160756 RVA: 0x0098C2F2 File Offset: 0x0098A4F2
		// (set) Token: 0x060273F5 RID: 160757 RVA: 0x0098C302 File Offset: 0x0098A502
		public unsafe bool DebugPrintOnConstruction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectActor_C.__PropertyOffset_3) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectActor_C.__PropertyOffset_3) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700570A RID: 22282
		// (get) Token: 0x060273F6 RID: 160758 RVA: 0x0098C313 File Offset: 0x0098A513
		// (set) Token: 0x060273F7 RID: 160759 RVA: 0x0098C323 File Offset: 0x0098A523
		public unsafe bool EditorTickWithoutSelected
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectActor_C.__PropertyOffset_4) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectActor_C.__PropertyOffset_4) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700570B RID: 22283
		// (get) Token: 0x060273F8 RID: 160760 RVA: 0x0098C334 File Offset: 0x0098A534
		// (set) Token: 0x060273F9 RID: 160761 RVA: 0x0098C344 File Offset: 0x0098A544
		public unsafe int EffectComponent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectActor_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectActor_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x1700570C RID: 22284
		// (get) Token: 0x060273FA RID: 160762 RVA: 0x0098C355 File Offset: 0x0098A555
		// (set) Token: 0x060273FB RID: 160763 RVA: 0x0098C369 File Offset: 0x0098A569
		[Nullable(0)]
		public unsafe TEnumAsByte<EEffectPlay> PlayType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectActor_C.__PropertyOffset_6);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectActor_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x1700570D RID: 22285
		// (get) Token: 0x060273FC RID: 160764 RVA: 0x0098C37E File Offset: 0x0098A57E
		// (set) Token: 0x060273FD RID: 160765 RVA: 0x0098C392 File Offset: 0x0098A592
		[Nullable(0)]
		public unsafe TEnumAsByte<AkiClient.Game.Aki.Data.Effect.Struct.EEffectType> EffectType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectActor_C.__PropertyOffset_7);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectActor_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x1700570E RID: 22286
		// (get) Token: 0x060273FE RID: 160766 RVA: 0x0098C3A7 File Offset: 0x0098A5A7
		// (set) Token: 0x060273FF RID: 160767 RVA: 0x0098C3B7 File Offset: 0x0098A5B7
		public unsafe bool FirstTick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectActor_C.__PropertyOffset_8) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectActor_C.__PropertyOffset_8) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700570F RID: 22287
		// (get) Token: 0x06027400 RID: 160768 RVA: 0x0098C3C8 File Offset: 0x0098A5C8
		// (set) Token: 0x06027401 RID: 160769 RVA: 0x0098C3D8 File Offset: 0x0098A5D8
		public unsafe bool 使用特效参数
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectActor_C.__PropertyOffset_9) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectActor_C.__PropertyOffset_9) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005710 RID: 22288
		// (get) Token: 0x06027402 RID: 160770 RVA: 0x0098C3E9 File Offset: 0x0098A5E9
		// (set) Token: 0x06027403 RID: 160771 RVA: 0x0098C3F9 File Offset: 0x0098A5F9
		public unsafe float 环境光影响强度覆盖
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectActor_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectActor_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17005711 RID: 22289
		// (get) Token: 0x06027404 RID: 160772 RVA: 0x0098C40C File Offset: 0x0098A60C
		// (set) Token: 0x06027405 RID: 160773 RVA: 0x0098C445 File Offset: 0x0098A645
		public TArray<SEffectFloatParameter> 用户参数Float
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SEffectFloatParameter> result;
				if ((result = this._用户参数Float) == null)
				{
					result = (this._用户参数Float = new TArray<SEffectFloatParameter>(base.NativePtr + (IntPtr)BP_EffectActor_C.__PropertyOffset_11, this));
				}
				return result;
			}
			set
			{
				this.用户参数Float.CopyAssign(value);
			}
		}

		// Token: 0x17005712 RID: 22290
		// (get) Token: 0x06027406 RID: 160774 RVA: 0x0098C454 File Offset: 0x0098A654
		// (set) Token: 0x06027407 RID: 160775 RVA: 0x0098C48D File Offset: 0x0098A68D
		public TArray<SEffectColorParameter> 用户参数Color
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SEffectColorParameter> result;
				if ((result = this._用户参数Color) == null)
				{
					result = (this._用户参数Color = new TArray<SEffectColorParameter>(base.NativePtr + (IntPtr)BP_EffectActor_C.__PropertyOffset_12, this));
				}
				return result;
			}
			set
			{
				this.用户参数Color.CopyAssign(value);
			}
		}

		// Token: 0x17005713 RID: 22291
		// (get) Token: 0x06027408 RID: 160776 RVA: 0x0098C49C File Offset: 0x0098A69C
		// (set) Token: 0x06027409 RID: 160777 RVA: 0x0098C4D5 File Offset: 0x0098A6D5
		public TArray<SEffectVectorParameter> 用户参数Vector
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SEffectVectorParameter> result;
				if ((result = this._用户参数Vector) == null)
				{
					result = (this._用户参数Vector = new TArray<SEffectVectorParameter>(base.NativePtr + (IntPtr)BP_EffectActor_C.__PropertyOffset_13, this));
				}
				return result;
			}
			set
			{
				this.用户参数Vector.CopyAssign(value);
			}
		}

		// Token: 0x17005714 RID: 22292
		// (get) Token: 0x0602740A RID: 160778 RVA: 0x0098C4E4 File Offset: 0x0098A6E4
		// (set) Token: 0x0602740B RID: 160779 RVA: 0x0098C51D File Offset: 0x0098A71D
		public TArray<SEffectFloatParameter> 材质参数Float
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SEffectFloatParameter> result;
				if ((result = this._材质参数Float) == null)
				{
					result = (this._材质参数Float = new TArray<SEffectFloatParameter>(base.NativePtr + (IntPtr)BP_EffectActor_C.__PropertyOffset_14, this));
				}
				return result;
			}
			set
			{
				this.材质参数Float.CopyAssign(value);
			}
		}

		// Token: 0x17005715 RID: 22293
		// (get) Token: 0x0602740C RID: 160780 RVA: 0x0098C52C File Offset: 0x0098A72C
		// (set) Token: 0x0602740D RID: 160781 RVA: 0x0098C565 File Offset: 0x0098A765
		public TArray<SEffectColorParameter> 材质参数Color
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SEffectColorParameter> result;
				if ((result = this._材质参数Color) == null)
				{
					result = (this._材质参数Color = new TArray<SEffectColorParameter>(base.NativePtr + (IntPtr)BP_EffectActor_C.__PropertyOffset_15, this));
				}
				return result;
			}
			set
			{
				this.材质参数Color.CopyAssign(value);
			}
		}

		// Token: 0x17005716 RID: 22294
		// (get) Token: 0x0602740E RID: 160782 RVA: 0x0098C574 File Offset: 0x0098A774
		// (set) Token: 0x0602740F RID: 160783 RVA: 0x0098C5AD File Offset: 0x0098A7AD
		public TArray<SEffectFloatParameter> 材质参数Float_Temp
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SEffectFloatParameter> result;
				if ((result = this._材质参数Float_Temp) == null)
				{
					result = (this._材质参数Float_Temp = new TArray<SEffectFloatParameter>(base.NativePtr + (IntPtr)BP_EffectActor_C.__PropertyOffset_16, this));
				}
				return result;
			}
			set
			{
				this.材质参数Float_Temp.CopyAssign(value);
			}
		}

		// Token: 0x17005717 RID: 22295
		// (get) Token: 0x06027410 RID: 160784 RVA: 0x0098C5BB File Offset: 0x0098A7BB
		// (set) Token: 0x06027411 RID: 160785 RVA: 0x0098C5CB File Offset: 0x0098A7CB
		public unsafe bool UsedInBossFight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectActor_C.__PropertyOffset_17) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectActor_C.__PropertyOffset_17) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005718 RID: 22296
		// (get) Token: 0x06027412 RID: 160786 RVA: 0x0098C5DC File Offset: 0x0098A7DC
		// (set) Token: 0x06027413 RID: 160787 RVA: 0x0098C5EC File Offset: 0x0098A7EC
		public unsafe bool ShouldBePlaying
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectActor_C.__PropertyOffset_18) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectActor_C.__PropertyOffset_18) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005719 RID: 22297
		// (get) Token: 0x06027414 RID: 160788 RVA: 0x0098C5FD File Offset: 0x0098A7FD
		// (set) Token: 0x06027415 RID: 160789 RVA: 0x0098C60D File Offset: 0x0098A80D
		public unsafe bool OpenVisibilityOptimize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectActor_C.__PropertyOffset_19) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectActor_C.__PropertyOffset_19) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700571A RID: 22298
		// (get) Token: 0x06027416 RID: 160790 RVA: 0x0098C61E File Offset: 0x0098A81E
		// (set) Token: 0x06027417 RID: 160791 RVA: 0x0098C62E File Offset: 0x0098A82E
		public unsafe bool ForceStoppingTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectActor_C.__PropertyOffset_20) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectActor_C.__PropertyOffset_20) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700571B RID: 22299
		// (get) Token: 0x06027418 RID: 160792 RVA: 0x0098C63F File Offset: 0x0098A83F
		// (set) Token: 0x06027419 RID: 160793 RVA: 0x0098C64F File Offset: 0x0098A84F
		public unsafe bool IgnoreStoppingTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectActor_C.__PropertyOffset_21) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectActor_C.__PropertyOffset_21) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700571C RID: 22300
		// (get) Token: 0x0602741A RID: 160794 RVA: 0x0098C660 File Offset: 0x0098A860
		// (set) Token: 0x0602741B RID: 160795 RVA: 0x0098C670 File Offset: 0x0098A870
		public unsafe bool MobileOnly
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectActor_C.__PropertyOffset_22) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectActor_C.__PropertyOffset_22) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700571D RID: 22301
		// (get) Token: 0x0602741C RID: 160796 RVA: 0x0098C681 File Offset: 0x0098A881
		// (set) Token: 0x0602741D RID: 160797 RVA: 0x0098C691 File Offset: 0x0098A891
		public unsafe float CustomProcess
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectActor_C.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectActor_C.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x1700571E RID: 22302
		// (get) Token: 0x0602741E RID: 160798 RVA: 0x0098C6A2 File Offset: 0x0098A8A2
		// (set) Token: 0x0602741F RID: 160799 RVA: 0x0098C6B2 File Offset: 0x0098A8B2
		public unsafe bool IsSimulateFromSequence
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectActor_C.__PropertyOffset_24) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectActor_C.__PropertyOffset_24) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700571F RID: 22303
		// (get) Token: 0x06027420 RID: 160800 RVA: 0x0098C6C3 File Offset: 0x0098A8C3
		// (set) Token: 0x06027421 RID: 160801 RVA: 0x0098C6D3 File Offset: 0x0098A8D3
		public unsafe bool IsPublicToSequence
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectActor_C.__PropertyOffset_25) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectActor_C.__PropertyOffset_25) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005720 RID: 22304
		// (get) Token: 0x06027422 RID: 160802 RVA: 0x0098C6E4 File Offset: 0x0098A8E4
		// (set) Token: 0x06027423 RID: 160803 RVA: 0x0098C6F4 File Offset: 0x0098A8F4
		public unsafe float FloatParameter0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectActor_C.__PropertyOffset_26);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectActor_C.__PropertyOffset_26) = value;
			}
		}

		// Token: 0x17005721 RID: 22305
		// (get) Token: 0x06027424 RID: 160804 RVA: 0x0098C705 File Offset: 0x0098A905
		// (set) Token: 0x06027425 RID: 160805 RVA: 0x0098C715 File Offset: 0x0098A915
		public unsafe float FloatParameter1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectActor_C.__PropertyOffset_27);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectActor_C.__PropertyOffset_27) = value;
			}
		}

		// Token: 0x17005722 RID: 22306
		// (get) Token: 0x06027426 RID: 160806 RVA: 0x0098C726 File Offset: 0x0098A926
		// (set) Token: 0x06027427 RID: 160807 RVA: 0x0098C736 File Offset: 0x0098A936
		public unsafe float FloatParameter2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectActor_C.__PropertyOffset_28);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectActor_C.__PropertyOffset_28) = value;
			}
		}

		// Token: 0x17005723 RID: 22307
		// (get) Token: 0x06027428 RID: 160808 RVA: 0x0098C747 File Offset: 0x0098A947
		// (set) Token: 0x06027429 RID: 160809 RVA: 0x0098C75B File Offset: 0x0098A95B
		public unsafe string FloatParameterName0
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_EffectActor_C.__PropertyOffset_29)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_EffectActor_C.__PropertyOffset_29)), value);
			}
		}

		// Token: 0x17005724 RID: 22308
		// (get) Token: 0x0602742A RID: 160810 RVA: 0x0098C770 File Offset: 0x0098A970
		// (set) Token: 0x0602742B RID: 160811 RVA: 0x0098C784 File Offset: 0x0098A984
		public unsafe string FloatParameterName1
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_EffectActor_C.__PropertyOffset_30)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_EffectActor_C.__PropertyOffset_30)), value);
			}
		}

		// Token: 0x17005725 RID: 22309
		// (get) Token: 0x0602742C RID: 160812 RVA: 0x0098C799 File Offset: 0x0098A999
		// (set) Token: 0x0602742D RID: 160813 RVA: 0x0098C7AD File Offset: 0x0098A9AD
		public unsafe string FloatParameterName2
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_EffectActor_C.__PropertyOffset_31)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_EffectActor_C.__PropertyOffset_31)), value);
			}
		}

		// Token: 0x17005726 RID: 22310
		// (get) Token: 0x0602742E RID: 160814 RVA: 0x0098C7C2 File Offset: 0x0098A9C2
		// (set) Token: 0x0602742F RID: 160815 RVA: 0x0098C7D6 File Offset: 0x0098A9D6
		[Nullable(0)]
		public unsafe TEnumAsByte<EEffectPlay> EditorPlayType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectActor_C.__PropertyOffset_32);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectActor_C.__PropertyOffset_32) = value;
			}
		}

		// Token: 0x17005727 RID: 22311
		// (get) Token: 0x06027430 RID: 160816 RVA: 0x0098C7EB File Offset: 0x0098A9EB
		// (set) Token: 0x06027431 RID: 160817 RVA: 0x0098C7FB File Offset: 0x0098A9FB
		public unsafe bool VisibleInRaytracing
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectActor_C.__PropertyOffset_33) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectActor_C.__PropertyOffset_33) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005728 RID: 22312
		// (get) Token: 0x06027432 RID: 160818 RVA: 0x0098C80C File Offset: 0x0098AA0C
		// (set) Token: 0x06027433 RID: 160819 RVA: 0x0098C81C File Offset: 0x0098AA1C
		public unsafe bool InUIScene
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectActor_C.__PropertyOffset_34) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectActor_C.__PropertyOffset_34) = (value ? 1 : 0);
			}
		}

		// Token: 0x06027434 RID: 160820 RVA: 0x0098C830 File Offset: 0x0098AA30
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetHandle(ref int Handle)
		{
			BP_EffectActor_C.__GetHandle_FunctionParams* ptr = stackalloc BP_EffectActor_C.__GetHandle_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_EffectActor_C.__GetHandle_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_EffectActor_C.__GetHandle_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Handle = Handle;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_EffectActor_C.__GetHandle_NativeFunctionPtr, (void*)ptr);
			Handle = ptr->Handle;
		}

		// Token: 0x06027435 RID: 160821 RVA: 0x0098C880 File Offset: 0x0098AA80
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void AfterSpawnEffect(int EffectHandle)
		{
			BP_EffectActor_C.__AfterSpawnEffect_FunctionParams* ptr = stackalloc BP_EffectActor_C.__AfterSpawnEffect_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_EffectActor_C.__AfterSpawnEffect_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_EffectActor_C.__AfterSpawnEffect_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EffectHandle = EffectHandle;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_EffectActor_C.__AfterSpawnEffect_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06027436 RID: 160822 RVA: 0x0098C8C8 File Offset: 0x0098AAC8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override FBox GetStreamingBoundsEx()
		{
			BP_EffectActor_C.__GetStreamingBoundsEx_FunctionParams* ptr = stackalloc BP_EffectActor_C.__GetStreamingBoundsEx_FunctionParams[(UIntPtr)207] + 15L / (long)sizeof(BP_EffectActor_C.__GetStreamingBoundsEx_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_EffectActor_C.__GetStreamingBoundsEx_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_EffectActor_C.__GetStreamingBoundsEx_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06027437 RID: 160823 RVA: 0x0098C910 File Offset: 0x0098AB10
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override FBox GetStreamingBoundsEx_Implementation()
		{
			BP_EffectActor_C.__GetStreamingBoundsEx_FunctionParams* ptr = stackalloc BP_EffectActor_C.__GetStreamingBoundsEx_FunctionParams[(UIntPtr)207] + 15L / (long)sizeof(BP_EffectActor_C.__GetStreamingBoundsEx_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_EffectActor_C.__GetStreamingBoundsEx_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_EffectActor_C.__GetStreamingBoundsEx_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06027438 RID: 160824 RVA: 0x0098C959 File Offset: 0x0098AB59
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void StopEffect()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_EffectActor_C.__StopEffect_NativeFunctionPtr, null);
		}

		// Token: 0x06027439 RID: 160825 RVA: 0x0098C96D File Offset: 0x0098AB6D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void PlayEffect()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_EffectActor_C.__PlayEffect_NativeFunctionPtr, null);
		}

		// Token: 0x0602743A RID: 160826 RVA: 0x0098C984 File Offset: 0x0098AB84
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Play(string Reason)
		{
			BP_EffectActor_C.__Play_FunctionParams* ptr = stackalloc BP_EffectActor_C.__Play_FunctionParams[(UIntPtr)191] + 15L / (long)sizeof(BP_EffectActor_C.__Play_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_EffectActor_C.__Play_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Reason), Reason);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_EffectActor_C.__Play_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(BP_EffectActor_C.__Play_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602743B RID: 160827 RVA: 0x0098C9E4 File Offset: 0x0098ABE4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual bool Stop(string Reason, bool Immediately)
		{
			BP_EffectActor_C.__Stop_FunctionParams* ptr = stackalloc BP_EffectActor_C.__Stop_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_EffectActor_C.__Stop_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_EffectActor_C.__Stop_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Reason), Reason);
			ptr->Immediately = Immediately;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_EffectActor_C.__Stop_NativeFunctionPtr, (void*)ptr);
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(BP_EffectActor_C.__Stop_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0602743C RID: 160828 RVA: 0x0098CA50 File Offset: 0x0098AC50
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void IsEditor(ref bool IsEditor)
		{
			BP_EffectActor_C.__IsEditor_FunctionParams* ptr = stackalloc BP_EffectActor_C.__IsEditor_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(BP_EffectActor_C.__IsEditor_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_EffectActor_C.__IsEditor_NativeFunctionPtr, (void*)ptr, 1);
			ptr->IsEditor = IsEditor;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_EffectActor_C.__IsEditor_NativeFunctionPtr, (void*)ptr);
			IsEditor = ptr->IsEditor;
		}

		// Token: 0x0602743D RID: 160829 RVA: 0x0098CA9F File Offset: 0x0098AC9F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void CalculateLifeTime()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_EffectActor_C.__CalculateLifeTime_NativeFunctionPtr, null);
		}

		// Token: 0x0602743E RID: 160830 RVA: 0x0098CAB3 File Offset: 0x0098ACB3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Refresh()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_EffectActor_C.__Refresh_NativeFunctionPtr, null);
		}

		// Token: 0x0602743F RID: 160831 RVA: 0x0098CAC7 File Offset: 0x0098ACC7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_EffectActor_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06027440 RID: 160832 RVA: 0x0098CADB File Offset: 0x0098ACDB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_EffectActor_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06027441 RID: 160833 RVA: 0x0098CAF0 File Offset: 0x0098ACF0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetHandle(int Handle)
		{
			BP_EffectActor_C.__SetHandle_FunctionParams* ptr = stackalloc BP_EffectActor_C.__SetHandle_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_EffectActor_C.__SetHandle_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_EffectActor_C.__SetHandle_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Handle = Handle;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_EffectActor_C.__SetHandle_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06027442 RID: 160834 RVA: 0x0098CB36 File Offset: 0x0098AD36
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void RemoveHandle()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_EffectActor_C.__RemoveHandle_NativeFunctionPtr, null);
		}

		// Token: 0x06027443 RID: 160835 RVA: 0x0098CB4A File Offset: 0x0098AD4A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_EffectActor_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06027444 RID: 160836 RVA: 0x0098CB5E File Offset: 0x0098AD5E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_EffectActor_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06027445 RID: 160837 RVA: 0x0098CB74 File Offset: 0x0098AD74
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
		{
			BP_EffectActor_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_EffectActor_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_EffectActor_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_EffectActor_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_EffectActor_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06027446 RID: 160838 RVA: 0x0098CBC0 File Offset: 0x0098ADC0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
		{
			BP_EffectActor_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_EffectActor_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_EffectActor_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_EffectActor_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_EffectActor_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06027447 RID: 160839 RVA: 0x0098CC0C File Offset: 0x0098AE0C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_EffectActor_C.__EditorTick_FunctionParams* ptr = stackalloc BP_EffectActor_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_EffectActor_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_EffectActor_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_EffectActor_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06027448 RID: 160840 RVA: 0x0098CC54 File Offset: 0x0098AE54
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_EffectActor_C.__EditorTick_FunctionParams* ptr = stackalloc BP_EffectActor_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_EffectActor_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_EffectActor_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_EffectActor_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06027449 RID: 160841 RVA: 0x0098CC9C File Offset: 0x0098AE9C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void DoHiddenInGame(bool bValue)
		{
			BP_EffectActor_C.__DoHiddenInGame_FunctionParams* ptr = stackalloc BP_EffectActor_C.__DoHiddenInGame_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_EffectActor_C.__DoHiddenInGame_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_EffectActor_C.__DoHiddenInGame_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bValue = bValue;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_EffectActor_C.__DoHiddenInGame_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602744A RID: 160842 RVA: 0x0098CCE4 File Offset: 0x0098AEE4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void DoHiddenInGame_Implementation(bool bValue)
		{
			BP_EffectActor_C.__DoHiddenInGame_FunctionParams* ptr = stackalloc BP_EffectActor_C.__DoHiddenInGame_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_EffectActor_C.__DoHiddenInGame_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_EffectActor_C.__DoHiddenInGame_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bValue = bValue;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_EffectActor_C.__DoHiddenInGame_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602744B RID: 160843 RVA: 0x0098CD2B File Offset: 0x0098AF2B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void OnReceiveHideSceneEffectActor()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_EffectActor_C.__OnReceiveHideSceneEffectActor_NativeFunctionPtr, null);
		}

		// Token: 0x0602744C RID: 160844 RVA: 0x0098CD3F File Offset: 0x0098AF3F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void OnReceiveHideSceneEffectActor_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_EffectActor_C.__OnReceiveHideSceneEffectActor_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602744D RID: 160845 RVA: 0x0098CD54 File Offset: 0x0098AF54
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void OnReceiveShowSceneEffectActor()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_EffectActor_C.__OnReceiveShowSceneEffectActor_NativeFunctionPtr, null);
		}

		// Token: 0x0602744E RID: 160846 RVA: 0x0098CD68 File Offset: 0x0098AF68
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void OnReceiveShowSceneEffectActor_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_EffectActor_C.__OnReceiveShowSceneEffectActor_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602744F RID: 160847 RVA: 0x0098CD7D File Offset: 0x0098AF7D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void EditorDestroy()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_EffectActor_C.__EditorDestroy_NativeFunctionPtr, null);
		}

		// Token: 0x06027450 RID: 160848 RVA: 0x0098CD91 File Offset: 0x0098AF91
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void EditorDestroy_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_EffectActor_C.__EditorDestroy_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06027451 RID: 160849 RVA: 0x0098CDA6 File Offset: 0x0098AFA6
		protected BP_EffectActor_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013CC6 RID: 81094
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Effect/BP_EffectActor.BP_EffectActor_C";

		// Token: 0x04013CC7 RID: 81095
		private static IntPtr _ClassPtr;

		// Token: 0x04013CC8 RID: 81096
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013CC9 RID: 81097
		internal static int __PropertyOffset_1;

		// Token: 0x04013CCA RID: 81098
		internal static int __PropertyOffset_2;

		// Token: 0x04013CCB RID: 81099
		[Nullable(2)]
		private FSoftObjectPath _EffectData;

		// Token: 0x04013CCC RID: 81100
		internal static int __PropertyOffset_3;

		// Token: 0x04013CCD RID: 81101
		internal static int __PropertyOffset_4;

		// Token: 0x04013CCE RID: 81102
		internal static int __PropertyOffset_5;

		// Token: 0x04013CCF RID: 81103
		internal static int __PropertyOffset_6;

		// Token: 0x04013CD0 RID: 81104
		internal static int __PropertyOffset_7;

		// Token: 0x04013CD1 RID: 81105
		internal static int __PropertyOffset_8;

		// Token: 0x04013CD2 RID: 81106
		internal static int __PropertyOffset_9;

		// Token: 0x04013CD3 RID: 81107
		internal static int __PropertyOffset_10;

		// Token: 0x04013CD4 RID: 81108
		internal static int __PropertyOffset_11;

		// Token: 0x04013CD5 RID: 81109
		[Nullable(2)]
		private TArray<SEffectFloatParameter> _用户参数Float;

		// Token: 0x04013CD6 RID: 81110
		internal static int __PropertyOffset_12;

		// Token: 0x04013CD7 RID: 81111
		[Nullable(2)]
		private TArray<SEffectColorParameter> _用户参数Color;

		// Token: 0x04013CD8 RID: 81112
		internal static int __PropertyOffset_13;

		// Token: 0x04013CD9 RID: 81113
		[Nullable(2)]
		private TArray<SEffectVectorParameter> _用户参数Vector;

		// Token: 0x04013CDA RID: 81114
		internal static int __PropertyOffset_14;

		// Token: 0x04013CDB RID: 81115
		[Nullable(2)]
		private TArray<SEffectFloatParameter> _材质参数Float;

		// Token: 0x04013CDC RID: 81116
		internal static int __PropertyOffset_15;

		// Token: 0x04013CDD RID: 81117
		[Nullable(2)]
		private TArray<SEffectColorParameter> _材质参数Color;

		// Token: 0x04013CDE RID: 81118
		internal static int __PropertyOffset_16;

		// Token: 0x04013CDF RID: 81119
		[Nullable(2)]
		private TArray<SEffectFloatParameter> _材质参数Float_Temp;

		// Token: 0x04013CE0 RID: 81120
		internal static int __PropertyOffset_17;

		// Token: 0x04013CE1 RID: 81121
		internal static int __PropertyOffset_18;

		// Token: 0x04013CE2 RID: 81122
		internal static int __PropertyOffset_19;

		// Token: 0x04013CE3 RID: 81123
		internal static int __PropertyOffset_20;

		// Token: 0x04013CE4 RID: 81124
		internal static int __PropertyOffset_21;

		// Token: 0x04013CE5 RID: 81125
		internal static int __PropertyOffset_22;

		// Token: 0x04013CE6 RID: 81126
		internal static int __PropertyOffset_23;

		// Token: 0x04013CE7 RID: 81127
		internal static int __PropertyOffset_24;

		// Token: 0x04013CE8 RID: 81128
		internal static int __PropertyOffset_25;

		// Token: 0x04013CE9 RID: 81129
		internal static int __PropertyOffset_26;

		// Token: 0x04013CEA RID: 81130
		internal static int __PropertyOffset_27;

		// Token: 0x04013CEB RID: 81131
		internal static int __PropertyOffset_28;

		// Token: 0x04013CEC RID: 81132
		internal static int __PropertyOffset_29;

		// Token: 0x04013CED RID: 81133
		internal static int __PropertyOffset_30;

		// Token: 0x04013CEE RID: 81134
		internal static int __PropertyOffset_31;

		// Token: 0x04013CEF RID: 81135
		internal static int __PropertyOffset_32;

		// Token: 0x04013CF0 RID: 81136
		internal static int __PropertyOffset_33;

		// Token: 0x04013CF1 RID: 81137
		internal static int __PropertyOffset_34;

		// Token: 0x04013CF2 RID: 81138
		private static IntPtr __GetHandle_NativeFunctionPtr;

		// Token: 0x04013CF3 RID: 81139
		private static IntPtr __AfterSpawnEffect_NativeFunctionPtr;

		// Token: 0x04013CF4 RID: 81140
		private static IntPtr __GetStreamingBoundsEx_NativeFunctionPtr;

		// Token: 0x04013CF5 RID: 81141
		private static IntPtr __StopEffect_NativeFunctionPtr;

		// Token: 0x04013CF6 RID: 81142
		private static IntPtr __PlayEffect_NativeFunctionPtr;

		// Token: 0x04013CF7 RID: 81143
		private static IntPtr __Play_NativeFunctionPtr;

		// Token: 0x04013CF8 RID: 81144
		private static IntPtr __Stop_NativeFunctionPtr;

		// Token: 0x04013CF9 RID: 81145
		private static IntPtr __IsEditor_NativeFunctionPtr;

		// Token: 0x04013CFA RID: 81146
		private static IntPtr __CalculateLifeTime_NativeFunctionPtr;

		// Token: 0x04013CFB RID: 81147
		private static IntPtr __Refresh_NativeFunctionPtr;

		// Token: 0x04013CFC RID: 81148
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04013CFD RID: 81149
		private static IntPtr __SetHandle_NativeFunctionPtr;

		// Token: 0x04013CFE RID: 81150
		private static IntPtr __RemoveHandle_NativeFunctionPtr;

		// Token: 0x04013CFF RID: 81151
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04013D00 RID: 81152
		private static IntPtr __ReceiveEndPlay_NativeFunctionPtr;

		// Token: 0x04013D01 RID: 81153
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x04013D02 RID: 81154
		private static IntPtr __DoHiddenInGame_NativeFunctionPtr;

		// Token: 0x04013D03 RID: 81155
		private static IntPtr __OnReceiveHideSceneEffectActor_NativeFunctionPtr;

		// Token: 0x04013D04 RID: 81156
		private static IntPtr __OnReceiveShowSceneEffectActor_NativeFunctionPtr;

		// Token: 0x04013D05 RID: 81157
		private static IntPtr __EditorDestroy_NativeFunctionPtr;

		// Token: 0x0200A20A RID: 41482
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetHandle_FunctionParams
		{
			// Token: 0x04031E72 RID: 204402
			[FieldOffset(0)]
			public int Handle;
		}

		// Token: 0x0200A20B RID: 41483
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __AfterSpawnEffect_FunctionParams
		{
			// Token: 0x04031E73 RID: 204403
			[FieldOffset(0)]
			public int EffectHandle;
		}

		// Token: 0x0200A20C RID: 41484
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 192)]
		protected new ref struct __GetStreamingBoundsEx_FunctionParams
		{
			// Token: 0x04031E74 RID: 204404
			[FieldOffset(0)]
			public FBox __Result;
		}

		// Token: 0x0200A20D RID: 41485
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 176)]
		protected ref struct __Play_FunctionParams
		{
			// Token: 0x04031E75 RID: 204405
			[FieldOffset(0)]
			public FString Reason;
		}

		// Token: 0x0200A20E RID: 41486
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __Stop_FunctionParams
		{
			// Token: 0x04031E76 RID: 204406
			[FieldOffset(0)]
			public FString Reason;

			// Token: 0x04031E77 RID: 204407
			[FieldOffset(16)]
			public bool Immediately;

			// Token: 0x04031E78 RID: 204408
			[FieldOffset(17)]
			public bool __Result;
		}

		// Token: 0x0200A20F RID: 41487
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __IsEditor_FunctionParams
		{
			// Token: 0x04031E79 RID: 204409
			[FieldOffset(0)]
			public bool IsEditor;
		}

		// Token: 0x0200A210 RID: 41488
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __SetHandle_FunctionParams
		{
			// Token: 0x04031E7A RID: 204410
			[FieldOffset(0)]
			public int Handle;
		}

		// Token: 0x0200A211 RID: 41489
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __ReceiveEndPlay_FunctionParams
		{
			// Token: 0x04031E7B RID: 204411
			[FieldOffset(0)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}

		// Token: 0x0200A212 RID: 41490
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x04031E7C RID: 204412
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x0200A213 RID: 41491
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __DoHiddenInGame_FunctionParams
		{
			// Token: 0x04031E7D RID: 204413
			[FieldOffset(0)]
			public bool bValue;
		}
	}
}

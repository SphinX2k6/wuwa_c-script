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
	// Token: 0x02003100 RID: 12544
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Effect/BP_EffectActor.BP_EffectActor_C")]
	[UnrealStructLayout(1360, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1355)]
	public class BP_EffectActor_C : AKuroSceneEffectActor, IUnrealUObject, IUnrealObject, IBPI_EffectInterface_C, IUnrealBlueprintInterface, IUnrealInterface
	{
		// Token: 0x0601EAD7 RID: 125655 RVA: 0x0091A247 File Offset: 0x00918447
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_EffectActor_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Effect/BP_EffectActor.BP_EffectActor_C");
			}
			return BP_EffectActor_C._ClassPtr;
		}

		// Token: 0x0601EAD8 RID: 125656 RVA: 0x0091A26C File Offset: 0x0091846C
		public BP_EffectActor_C() : this(BuiltinUtils.AllocNativeUObject(BP_EffectActor_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601EAD9 RID: 125657 RVA: 0x0091A294 File Offset: 0x00918494
		public BP_EffectActor_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_EffectActor_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170034FC RID: 13564
		// (get) Token: 0x0601EADA RID: 125658 RVA: 0x0091A2C7 File Offset: 0x009184C7
		// (set) Token: 0x0601EADB RID: 125659 RVA: 0x0091A2DB File Offset: 0x009184DB
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_EffectActor_C.__PropertyOffset_DefaultSceneRoot);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_EffectActor_C.__PropertyOffset_DefaultSceneRoot, value);
			}
		}

		// Token: 0x170034FD RID: 13565
		// (get) Token: 0x0601EADC RID: 125660 RVA: 0x0091A2F0 File Offset: 0x009184F0
		// (set) Token: 0x0601EADD RID: 125661 RVA: 0x0091A329 File Offset: 0x00918529
		public FSoftObjectPath EffectData
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._EffectData) == null)
				{
					result = (this._EffectData = new FSoftObjectPath(base.NativePtr + (IntPtr)BP_EffectActor_C.__PropertyOffset_EffectData, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)BP_EffectActor_C.__PropertyOffset_EffectData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170034FE RID: 13566
		// (get) Token: 0x0601EADE RID: 125662 RVA: 0x0091A34A File Offset: 0x0091854A
		// (set) Token: 0x0601EADF RID: 125663 RVA: 0x0091A35A File Offset: 0x0091855A
		public unsafe bool DebugPrintOnConstruction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectActor_C.__PropertyOffset_DebugPrintOnConstruction) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectActor_C.__PropertyOffset_DebugPrintOnConstruction) = (value ? 1 : 0);
			}
		}

		// Token: 0x170034FF RID: 13567
		// (get) Token: 0x0601EAE0 RID: 125664 RVA: 0x0091A36B File Offset: 0x0091856B
		// (set) Token: 0x0601EAE1 RID: 125665 RVA: 0x0091A37B File Offset: 0x0091857B
		public unsafe bool EditorTickWithoutSelected
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectActor_C.__PropertyOffset_EditorTickWithoutSelected) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectActor_C.__PropertyOffset_EditorTickWithoutSelected) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003500 RID: 13568
		// (get) Token: 0x0601EAE2 RID: 125666 RVA: 0x0091A38C File Offset: 0x0091858C
		// (set) Token: 0x0601EAE3 RID: 125667 RVA: 0x0091A39C File Offset: 0x0091859C
		public unsafe int EffectComponent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectActor_C.__PropertyOffset_EffectComponent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectActor_C.__PropertyOffset_EffectComponent) = value;
			}
		}

		// Token: 0x17003501 RID: 13569
		// (get) Token: 0x0601EAE4 RID: 125668 RVA: 0x0091A3AD File Offset: 0x009185AD
		// (set) Token: 0x0601EAE5 RID: 125669 RVA: 0x0091A3C1 File Offset: 0x009185C1
		[Nullable(0)]
		public unsafe TEnumAsByte<EEffectPlay> PlayType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectActor_C.__PropertyOffset_PlayType);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectActor_C.__PropertyOffset_PlayType) = value;
			}
		}

		// Token: 0x17003502 RID: 13570
		// (get) Token: 0x0601EAE6 RID: 125670 RVA: 0x0091A3D6 File Offset: 0x009185D6
		// (set) Token: 0x0601EAE7 RID: 125671 RVA: 0x0091A3EA File Offset: 0x009185EA
		[Nullable(0)]
		public unsafe TEnumAsByte<AkiClient.Game.Aki.Data.Effect.Struct.EEffectType> EffectType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectActor_C.__PropertyOffset_EffectType);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectActor_C.__PropertyOffset_EffectType) = value;
			}
		}

		// Token: 0x17003503 RID: 13571
		// (get) Token: 0x0601EAE8 RID: 125672 RVA: 0x0091A3FF File Offset: 0x009185FF
		// (set) Token: 0x0601EAE9 RID: 125673 RVA: 0x0091A40F File Offset: 0x0091860F
		public unsafe bool FirstTick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectActor_C.__PropertyOffset_FirstTick) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectActor_C.__PropertyOffset_FirstTick) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003504 RID: 13572
		// (get) Token: 0x0601EAEA RID: 125674 RVA: 0x0091A420 File Offset: 0x00918620
		// (set) Token: 0x0601EAEB RID: 125675 RVA: 0x0091A430 File Offset: 0x00918630
		public unsafe bool 使用特效参数
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectActor_C.__PropertyOffset_使用特效参数) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectActor_C.__PropertyOffset_使用特效参数) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003505 RID: 13573
		// (get) Token: 0x0601EAEC RID: 125676 RVA: 0x0091A441 File Offset: 0x00918641
		// (set) Token: 0x0601EAED RID: 125677 RVA: 0x0091A451 File Offset: 0x00918651
		public unsafe float 环境光影响强度覆盖
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectActor_C.__PropertyOffset_环境光影响强度覆盖);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectActor_C.__PropertyOffset_环境光影响强度覆盖) = value;
			}
		}

		// Token: 0x17003506 RID: 13574
		// (get) Token: 0x0601EAEE RID: 125678 RVA: 0x0091A464 File Offset: 0x00918664
		// (set) Token: 0x0601EAEF RID: 125679 RVA: 0x0091A49D File Offset: 0x0091869D
		public TArray<SEffectFloatParameter> 用户参数Float
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SEffectFloatParameter> result;
				if ((result = this._用户参数Float) == null)
				{
					result = (this._用户参数Float = new TArray<SEffectFloatParameter>(base.NativePtr + (IntPtr)BP_EffectActor_C.__PropertyOffset_用户参数Float, this));
				}
				return result;
			}
			set
			{
				this.用户参数Float.CopyAssign(value);
			}
		}

		// Token: 0x17003507 RID: 13575
		// (get) Token: 0x0601EAF0 RID: 125680 RVA: 0x0091A4AC File Offset: 0x009186AC
		// (set) Token: 0x0601EAF1 RID: 125681 RVA: 0x0091A4E5 File Offset: 0x009186E5
		public TArray<SEffectColorParameter> 用户参数Color
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SEffectColorParameter> result;
				if ((result = this._用户参数Color) == null)
				{
					result = (this._用户参数Color = new TArray<SEffectColorParameter>(base.NativePtr + (IntPtr)BP_EffectActor_C.__PropertyOffset_用户参数Color, this));
				}
				return result;
			}
			set
			{
				this.用户参数Color.CopyAssign(value);
			}
		}

		// Token: 0x17003508 RID: 13576
		// (get) Token: 0x0601EAF2 RID: 125682 RVA: 0x0091A4F4 File Offset: 0x009186F4
		// (set) Token: 0x0601EAF3 RID: 125683 RVA: 0x0091A52D File Offset: 0x0091872D
		public TArray<SEffectVectorParameter> 用户参数Vector
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SEffectVectorParameter> result;
				if ((result = this._用户参数Vector) == null)
				{
					result = (this._用户参数Vector = new TArray<SEffectVectorParameter>(base.NativePtr + (IntPtr)BP_EffectActor_C.__PropertyOffset_用户参数Vector, this));
				}
				return result;
			}
			set
			{
				this.用户参数Vector.CopyAssign(value);
			}
		}

		// Token: 0x17003509 RID: 13577
		// (get) Token: 0x0601EAF4 RID: 125684 RVA: 0x0091A53C File Offset: 0x0091873C
		// (set) Token: 0x0601EAF5 RID: 125685 RVA: 0x0091A575 File Offset: 0x00918775
		public TArray<SEffectFloatParameter> 材质参数Float
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SEffectFloatParameter> result;
				if ((result = this._材质参数Float) == null)
				{
					result = (this._材质参数Float = new TArray<SEffectFloatParameter>(base.NativePtr + (IntPtr)BP_EffectActor_C.__PropertyOffset_材质参数Float, this));
				}
				return result;
			}
			set
			{
				this.材质参数Float.CopyAssign(value);
			}
		}

		// Token: 0x1700350A RID: 13578
		// (get) Token: 0x0601EAF6 RID: 125686 RVA: 0x0091A584 File Offset: 0x00918784
		// (set) Token: 0x0601EAF7 RID: 125687 RVA: 0x0091A5BD File Offset: 0x009187BD
		public TArray<SEffectColorParameter> 材质参数Color
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SEffectColorParameter> result;
				if ((result = this._材质参数Color) == null)
				{
					result = (this._材质参数Color = new TArray<SEffectColorParameter>(base.NativePtr + (IntPtr)BP_EffectActor_C.__PropertyOffset_材质参数Color, this));
				}
				return result;
			}
			set
			{
				this.材质参数Color.CopyAssign(value);
			}
		}

		// Token: 0x1700350B RID: 13579
		// (get) Token: 0x0601EAF8 RID: 125688 RVA: 0x0091A5CC File Offset: 0x009187CC
		// (set) Token: 0x0601EAF9 RID: 125689 RVA: 0x0091A605 File Offset: 0x00918805
		public TArray<SEffectFloatParameter> 材质参数Float_Temp
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SEffectFloatParameter> result;
				if ((result = this._材质参数Float_Temp) == null)
				{
					result = (this._材质参数Float_Temp = new TArray<SEffectFloatParameter>(base.NativePtr + (IntPtr)BP_EffectActor_C.__PropertyOffset_材质参数Float_Temp, this));
				}
				return result;
			}
			set
			{
				this.材质参数Float_Temp.CopyAssign(value);
			}
		}

		// Token: 0x1700350C RID: 13580
		// (get) Token: 0x0601EAFA RID: 125690 RVA: 0x0091A613 File Offset: 0x00918813
		// (set) Token: 0x0601EAFB RID: 125691 RVA: 0x0091A623 File Offset: 0x00918823
		public unsafe bool UsedInBossFight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectActor_C.__PropertyOffset_UsedInBossFight) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectActor_C.__PropertyOffset_UsedInBossFight) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700350D RID: 13581
		// (get) Token: 0x0601EAFC RID: 125692 RVA: 0x0091A634 File Offset: 0x00918834
		// (set) Token: 0x0601EAFD RID: 125693 RVA: 0x0091A644 File Offset: 0x00918844
		public unsafe bool ShouldBePlaying
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectActor_C.__PropertyOffset_ShouldBePlaying) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectActor_C.__PropertyOffset_ShouldBePlaying) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700350E RID: 13582
		// (get) Token: 0x0601EAFE RID: 125694 RVA: 0x0091A655 File Offset: 0x00918855
		// (set) Token: 0x0601EAFF RID: 125695 RVA: 0x0091A665 File Offset: 0x00918865
		public unsafe bool OpenVisibilityOptimize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectActor_C.__PropertyOffset_OpenVisibilityOptimize) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectActor_C.__PropertyOffset_OpenVisibilityOptimize) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700350F RID: 13583
		// (get) Token: 0x0601EB00 RID: 125696 RVA: 0x0091A676 File Offset: 0x00918876
		// (set) Token: 0x0601EB01 RID: 125697 RVA: 0x0091A686 File Offset: 0x00918886
		public unsafe bool ForceStoppingTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectActor_C.__PropertyOffset_ForceStoppingTime) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectActor_C.__PropertyOffset_ForceStoppingTime) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003510 RID: 13584
		// (get) Token: 0x0601EB02 RID: 125698 RVA: 0x0091A697 File Offset: 0x00918897
		// (set) Token: 0x0601EB03 RID: 125699 RVA: 0x0091A6A7 File Offset: 0x009188A7
		public unsafe bool IgnoreStoppingTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectActor_C.__PropertyOffset_IgnoreStoppingTime) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectActor_C.__PropertyOffset_IgnoreStoppingTime) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003511 RID: 13585
		// (get) Token: 0x0601EB04 RID: 125700 RVA: 0x0091A6B8 File Offset: 0x009188B8
		// (set) Token: 0x0601EB05 RID: 125701 RVA: 0x0091A6C8 File Offset: 0x009188C8
		public unsafe bool MobileOnly
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectActor_C.__PropertyOffset_MobileOnly) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectActor_C.__PropertyOffset_MobileOnly) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003512 RID: 13586
		// (get) Token: 0x0601EB06 RID: 125702 RVA: 0x0091A6D9 File Offset: 0x009188D9
		// (set) Token: 0x0601EB07 RID: 125703 RVA: 0x0091A6E9 File Offset: 0x009188E9
		public unsafe float CustomProcess
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectActor_C.__PropertyOffset_CustomProcess);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectActor_C.__PropertyOffset_CustomProcess) = value;
			}
		}

		// Token: 0x17003513 RID: 13587
		// (get) Token: 0x0601EB08 RID: 125704 RVA: 0x0091A6FA File Offset: 0x009188FA
		// (set) Token: 0x0601EB09 RID: 125705 RVA: 0x0091A70A File Offset: 0x0091890A
		public unsafe bool IsSimulateFromSequence
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectActor_C.__PropertyOffset_IsSimulateFromSequence) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectActor_C.__PropertyOffset_IsSimulateFromSequence) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003514 RID: 13588
		// (get) Token: 0x0601EB0A RID: 125706 RVA: 0x0091A71B File Offset: 0x0091891B
		// (set) Token: 0x0601EB0B RID: 125707 RVA: 0x0091A72B File Offset: 0x0091892B
		public unsafe bool IsPublicToSequence
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectActor_C.__PropertyOffset_IsPublicToSequence) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectActor_C.__PropertyOffset_IsPublicToSequence) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003515 RID: 13589
		// (get) Token: 0x0601EB0C RID: 125708 RVA: 0x0091A73C File Offset: 0x0091893C
		// (set) Token: 0x0601EB0D RID: 125709 RVA: 0x0091A74C File Offset: 0x0091894C
		public unsafe float FloatParameter0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectActor_C.__PropertyOffset_FloatParameter0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectActor_C.__PropertyOffset_FloatParameter0) = value;
			}
		}

		// Token: 0x17003516 RID: 13590
		// (get) Token: 0x0601EB0E RID: 125710 RVA: 0x0091A75D File Offset: 0x0091895D
		// (set) Token: 0x0601EB0F RID: 125711 RVA: 0x0091A76D File Offset: 0x0091896D
		public unsafe float FloatParameter1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectActor_C.__PropertyOffset_FloatParameter1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectActor_C.__PropertyOffset_FloatParameter1) = value;
			}
		}

		// Token: 0x17003517 RID: 13591
		// (get) Token: 0x0601EB10 RID: 125712 RVA: 0x0091A77E File Offset: 0x0091897E
		// (set) Token: 0x0601EB11 RID: 125713 RVA: 0x0091A78E File Offset: 0x0091898E
		public unsafe float FloatParameter2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectActor_C.__PropertyOffset_FloatParameter2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectActor_C.__PropertyOffset_FloatParameter2) = value;
			}
		}

		// Token: 0x17003518 RID: 13592
		// (get) Token: 0x0601EB12 RID: 125714 RVA: 0x0091A79F File Offset: 0x0091899F
		// (set) Token: 0x0601EB13 RID: 125715 RVA: 0x0091A7B3 File Offset: 0x009189B3
		public unsafe string FloatParameterName0
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_EffectActor_C.__PropertyOffset_FloatParameterName0)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_EffectActor_C.__PropertyOffset_FloatParameterName0)), value);
			}
		}

		// Token: 0x17003519 RID: 13593
		// (get) Token: 0x0601EB14 RID: 125716 RVA: 0x0091A7C8 File Offset: 0x009189C8
		// (set) Token: 0x0601EB15 RID: 125717 RVA: 0x0091A7DC File Offset: 0x009189DC
		public unsafe string FloatParameterName1
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_EffectActor_C.__PropertyOffset_FloatParameterName1)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_EffectActor_C.__PropertyOffset_FloatParameterName1)), value);
			}
		}

		// Token: 0x1700351A RID: 13594
		// (get) Token: 0x0601EB16 RID: 125718 RVA: 0x0091A7F1 File Offset: 0x009189F1
		// (set) Token: 0x0601EB17 RID: 125719 RVA: 0x0091A805 File Offset: 0x00918A05
		public unsafe string FloatParameterName2
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_EffectActor_C.__PropertyOffset_FloatParameterName2)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_EffectActor_C.__PropertyOffset_FloatParameterName2)), value);
			}
		}

		// Token: 0x1700351B RID: 13595
		// (get) Token: 0x0601EB18 RID: 125720 RVA: 0x0091A81A File Offset: 0x00918A1A
		// (set) Token: 0x0601EB19 RID: 125721 RVA: 0x0091A82E File Offset: 0x00918A2E
		[Nullable(0)]
		public unsafe TEnumAsByte<EEffectPlay> EditorPlayType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectActor_C.__PropertyOffset_EditorPlayType);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectActor_C.__PropertyOffset_EditorPlayType) = value;
			}
		}

		// Token: 0x1700351C RID: 13596
		// (get) Token: 0x0601EB1A RID: 125722 RVA: 0x0091A843 File Offset: 0x00918A43
		// (set) Token: 0x0601EB1B RID: 125723 RVA: 0x0091A853 File Offset: 0x00918A53
		public unsafe bool VisibleInRaytracing
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectActor_C.__PropertyOffset_VisibleInRaytracing) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectActor_C.__PropertyOffset_VisibleInRaytracing) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700351D RID: 13597
		// (get) Token: 0x0601EB1C RID: 125724 RVA: 0x0091A864 File Offset: 0x00918A64
		// (set) Token: 0x0601EB1D RID: 125725 RVA: 0x0091A874 File Offset: 0x00918A74
		public unsafe bool InUIScene
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectActor_C.__PropertyOffset_InUIScene) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectActor_C.__PropertyOffset_InUIScene) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601EB1E RID: 125726 RVA: 0x0091A888 File Offset: 0x00918A88
		[SkipLocalsInit]
		public unsafe virtual void GetHandle(ref int Handle)
		{
			BP_EffectActor_C.__GetHandle_FunctionParams* ptr = stackalloc BP_EffectActor_C.__GetHandle_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_EffectActor_C.__GetHandle_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_EffectActor_C.__GetHandle_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Handle = Handle;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_EffectActor_C.__GetHandle_NativeFunctionPtr, (void*)ptr);
			Handle = ptr->Handle;
		}

		// Token: 0x0601EB1F RID: 125727 RVA: 0x0091A8D8 File Offset: 0x00918AD8
		[SkipLocalsInit]
		public unsafe virtual void AfterSpawnEffect(int EffectHandle)
		{
			BP_EffectActor_C.__AfterSpawnEffect_FunctionParams* ptr = stackalloc BP_EffectActor_C.__AfterSpawnEffect_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_EffectActor_C.__AfterSpawnEffect_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_EffectActor_C.__AfterSpawnEffect_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EffectHandle = EffectHandle;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_EffectActor_C.__AfterSpawnEffect_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601EB20 RID: 125728 RVA: 0x0091A920 File Offset: 0x00918B20
		[SkipLocalsInit]
		public unsafe override FBox GetStreamingBoundsEx()
		{
			BP_EffectActor_C.__GetStreamingBoundsEx_FunctionParams* ptr = stackalloc BP_EffectActor_C.__GetStreamingBoundsEx_FunctionParams[(UIntPtr)207] + 15L / (long)sizeof(BP_EffectActor_C.__GetStreamingBoundsEx_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_EffectActor_C.__GetStreamingBoundsEx_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_EffectActor_C.__GetStreamingBoundsEx_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0601EB21 RID: 125729 RVA: 0x0091A968 File Offset: 0x00918B68
		[SkipLocalsInit]
		protected unsafe override FBox GetStreamingBoundsEx_Implementation()
		{
			BP_EffectActor_C.__GetStreamingBoundsEx_FunctionParams* ptr = stackalloc BP_EffectActor_C.__GetStreamingBoundsEx_FunctionParams[(UIntPtr)207] + 15L / (long)sizeof(BP_EffectActor_C.__GetStreamingBoundsEx_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_EffectActor_C.__GetStreamingBoundsEx_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_EffectActor_C.__GetStreamingBoundsEx_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0601EB22 RID: 125730 RVA: 0x0091A9B0 File Offset: 0x00918BB0
		[SkipLocalsInit]
		public virtual void StopEffect()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_EffectActor_C.__StopEffect_NativeFunctionPtr, null);
		}

		// Token: 0x0601EB23 RID: 125731 RVA: 0x0091A9C4 File Offset: 0x00918BC4
		[SkipLocalsInit]
		public virtual void PlayEffect()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_EffectActor_C.__PlayEffect_NativeFunctionPtr, null);
		}

		// Token: 0x0601EB24 RID: 125732 RVA: 0x0091A9D8 File Offset: 0x00918BD8
		[SkipLocalsInit]
		public unsafe virtual void Play(string Reason)
		{
			BP_EffectActor_C.__Play_FunctionParams* ptr = stackalloc BP_EffectActor_C.__Play_FunctionParams[(UIntPtr)191] + 15L / (long)sizeof(BP_EffectActor_C.__Play_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_EffectActor_C.__Play_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Reason), Reason);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_EffectActor_C.__Play_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(BP_EffectActor_C.__Play_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601EB25 RID: 125733 RVA: 0x0091AA38 File Offset: 0x00918C38
		[SkipLocalsInit]
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

		// Token: 0x0601EB26 RID: 125734 RVA: 0x0091AAA4 File Offset: 0x00918CA4
		[SkipLocalsInit]
		public unsafe virtual void IsEditor(ref bool IsEditor)
		{
			BP_EffectActor_C.__IsEditor_FunctionParams* ptr = stackalloc BP_EffectActor_C.__IsEditor_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(BP_EffectActor_C.__IsEditor_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_EffectActor_C.__IsEditor_NativeFunctionPtr, (void*)ptr, 1);
			ptr->IsEditor = IsEditor;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_EffectActor_C.__IsEditor_NativeFunctionPtr, (void*)ptr);
			IsEditor = ptr->IsEditor;
		}

		// Token: 0x0601EB27 RID: 125735 RVA: 0x0091AAF3 File Offset: 0x00918CF3
		[SkipLocalsInit]
		public virtual void CalculateLifeTime()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_EffectActor_C.__CalculateLifeTime_NativeFunctionPtr, null);
		}

		// Token: 0x0601EB28 RID: 125736 RVA: 0x0091AB07 File Offset: 0x00918D07
		[SkipLocalsInit]
		public virtual void Refresh()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_EffectActor_C.__Refresh_NativeFunctionPtr, null);
		}

		// Token: 0x0601EB29 RID: 125737 RVA: 0x0091AB1B File Offset: 0x00918D1B
		[SkipLocalsInit]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_EffectActor_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601EB2A RID: 125738 RVA: 0x0091AB2F File Offset: 0x00918D2F
		[SkipLocalsInit]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_EffectActor_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601EB2B RID: 125739 RVA: 0x0091AB44 File Offset: 0x00918D44
		[SkipLocalsInit]
		public unsafe virtual void SetHandle(int Handle)
		{
			BP_EffectActor_C.__SetHandle_FunctionParams* ptr = stackalloc BP_EffectActor_C.__SetHandle_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_EffectActor_C.__SetHandle_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_EffectActor_C.__SetHandle_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Handle = Handle;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_EffectActor_C.__SetHandle_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601EB2C RID: 125740 RVA: 0x0091AB8A File Offset: 0x00918D8A
		[SkipLocalsInit]
		public virtual void RemoveHandle()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_EffectActor_C.__RemoveHandle_NativeFunctionPtr, null);
		}

		// Token: 0x0601EB2D RID: 125741 RVA: 0x0091AB9E File Offset: 0x00918D9E
		[SkipLocalsInit]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_EffectActor_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601EB2E RID: 125742 RVA: 0x0091ABB2 File Offset: 0x00918DB2
		[SkipLocalsInit]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_EffectActor_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601EB2F RID: 125743 RVA: 0x0091ABC8 File Offset: 0x00918DC8
		[SkipLocalsInit]
		public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
		{
			BP_EffectActor_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_EffectActor_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_EffectActor_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_EffectActor_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_EffectActor_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601EB30 RID: 125744 RVA: 0x0091AC14 File Offset: 0x00918E14
		[SkipLocalsInit]
		protected unsafe virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
		{
			BP_EffectActor_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_EffectActor_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_EffectActor_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_EffectActor_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_EffectActor_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601EB31 RID: 125745 RVA: 0x0091AC60 File Offset: 0x00918E60
		[SkipLocalsInit]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_EffectActor_C.__EditorTick_FunctionParams* ptr = stackalloc BP_EffectActor_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_EffectActor_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_EffectActor_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_EffectActor_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601EB32 RID: 125746 RVA: 0x0091ACA8 File Offset: 0x00918EA8
		[SkipLocalsInit]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_EffectActor_C.__EditorTick_FunctionParams* ptr = stackalloc BP_EffectActor_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_EffectActor_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_EffectActor_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_EffectActor_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601EB33 RID: 125747 RVA: 0x0091ACF0 File Offset: 0x00918EF0
		[SkipLocalsInit]
		public unsafe override void DoHiddenInGame(bool bValue)
		{
			BP_EffectActor_C.__DoHiddenInGame_FunctionParams* ptr = stackalloc BP_EffectActor_C.__DoHiddenInGame_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_EffectActor_C.__DoHiddenInGame_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_EffectActor_C.__DoHiddenInGame_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bValue = bValue;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_EffectActor_C.__DoHiddenInGame_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601EB34 RID: 125748 RVA: 0x0091AD38 File Offset: 0x00918F38
		[SkipLocalsInit]
		protected unsafe virtual void DoHiddenInGame_Implementation(bool bValue)
		{
			BP_EffectActor_C.__DoHiddenInGame_FunctionParams* ptr = stackalloc BP_EffectActor_C.__DoHiddenInGame_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_EffectActor_C.__DoHiddenInGame_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_EffectActor_C.__DoHiddenInGame_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bValue = bValue;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_EffectActor_C.__DoHiddenInGame_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601EB35 RID: 125749 RVA: 0x0091AD7E File Offset: 0x00918F7E
		[SkipLocalsInit]
		public override void OnReceiveHideSceneEffectActor()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_EffectActor_C.__OnReceiveHideSceneEffectActor_NativeFunctionPtr, null);
		}

		// Token: 0x0601EB36 RID: 125750 RVA: 0x0091AD92 File Offset: 0x00918F92
		[SkipLocalsInit]
		protected virtual void OnReceiveHideSceneEffectActor_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_EffectActor_C.__OnReceiveHideSceneEffectActor_NativeFunctionPtr, null);
		}

		// Token: 0x0601EB37 RID: 125751 RVA: 0x0091ADA6 File Offset: 0x00918FA6
		[SkipLocalsInit]
		public override void OnReceiveShowSceneEffectActor()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_EffectActor_C.__OnReceiveShowSceneEffectActor_NativeFunctionPtr, null);
		}

		// Token: 0x0601EB38 RID: 125752 RVA: 0x0091ADBA File Offset: 0x00918FBA
		[SkipLocalsInit]
		protected virtual void OnReceiveShowSceneEffectActor_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_EffectActor_C.__OnReceiveShowSceneEffectActor_NativeFunctionPtr, null);
		}

		// Token: 0x0601EB39 RID: 125753 RVA: 0x0091ADCE File Offset: 0x00918FCE
		[SkipLocalsInit]
		public override void EditorDestroy()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_EffectActor_C.__EditorDestroy_NativeFunctionPtr, null);
		}

		// Token: 0x0601EB3A RID: 125754 RVA: 0x0091ADE2 File Offset: 0x00918FE2
		[SkipLocalsInit]
		protected virtual void EditorDestroy_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_EffectActor_C.__EditorDestroy_NativeFunctionPtr, null);
		}

		// Token: 0x0601EB3B RID: 125755 RVA: 0x0091ADF6 File Offset: 0x00918FF6
		protected BP_EffectActor_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010474 RID: 66676
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Effect/BP_EffectActor.BP_EffectActor_C";

		// Token: 0x04010475 RID: 66677
		private static IntPtr _ClassPtr;

		// Token: 0x04010476 RID: 66678
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010477 RID: 66679
		internal static int __PropertyOffset_DefaultSceneRoot;

		// Token: 0x04010478 RID: 66680
		internal static int __PropertyOffset_EffectData;

		// Token: 0x04010479 RID: 66681
		[Nullable(2)]
		private FSoftObjectPath _EffectData;

		// Token: 0x0401047A RID: 66682
		internal static int __PropertyOffset_DebugPrintOnConstruction;

		// Token: 0x0401047B RID: 66683
		internal static int __PropertyOffset_EditorTickWithoutSelected;

		// Token: 0x0401047C RID: 66684
		internal static int __PropertyOffset_EffectComponent;

		// Token: 0x0401047D RID: 66685
		internal static int __PropertyOffset_PlayType;

		// Token: 0x0401047E RID: 66686
		internal static int __PropertyOffset_EffectType;

		// Token: 0x0401047F RID: 66687
		internal static int __PropertyOffset_FirstTick;

		// Token: 0x04010480 RID: 66688
		internal static int __PropertyOffset_使用特效参数;

		// Token: 0x04010481 RID: 66689
		internal static int __PropertyOffset_环境光影响强度覆盖;

		// Token: 0x04010482 RID: 66690
		internal static int __PropertyOffset_用户参数Float;

		// Token: 0x04010483 RID: 66691
		[Nullable(2)]
		private TArray<SEffectFloatParameter> _用户参数Float;

		// Token: 0x04010484 RID: 66692
		internal static int __PropertyOffset_用户参数Color;

		// Token: 0x04010485 RID: 66693
		[Nullable(2)]
		private TArray<SEffectColorParameter> _用户参数Color;

		// Token: 0x04010486 RID: 66694
		internal static int __PropertyOffset_用户参数Vector;

		// Token: 0x04010487 RID: 66695
		[Nullable(2)]
		private TArray<SEffectVectorParameter> _用户参数Vector;

		// Token: 0x04010488 RID: 66696
		internal static int __PropertyOffset_材质参数Float;

		// Token: 0x04010489 RID: 66697
		[Nullable(2)]
		private TArray<SEffectFloatParameter> _材质参数Float;

		// Token: 0x0401048A RID: 66698
		internal static int __PropertyOffset_材质参数Color;

		// Token: 0x0401048B RID: 66699
		[Nullable(2)]
		private TArray<SEffectColorParameter> _材质参数Color;

		// Token: 0x0401048C RID: 66700
		internal static int __PropertyOffset_材质参数Float_Temp;

		// Token: 0x0401048D RID: 66701
		[Nullable(2)]
		private TArray<SEffectFloatParameter> _材质参数Float_Temp;

		// Token: 0x0401048E RID: 66702
		internal static int __PropertyOffset_UsedInBossFight;

		// Token: 0x0401048F RID: 66703
		internal static int __PropertyOffset_ShouldBePlaying;

		// Token: 0x04010490 RID: 66704
		internal static int __PropertyOffset_OpenVisibilityOptimize;

		// Token: 0x04010491 RID: 66705
		internal static int __PropertyOffset_ForceStoppingTime;

		// Token: 0x04010492 RID: 66706
		internal static int __PropertyOffset_IgnoreStoppingTime;

		// Token: 0x04010493 RID: 66707
		internal static int __PropertyOffset_MobileOnly;

		// Token: 0x04010494 RID: 66708
		internal static int __PropertyOffset_CustomProcess;

		// Token: 0x04010495 RID: 66709
		internal static int __PropertyOffset_IsSimulateFromSequence;

		// Token: 0x04010496 RID: 66710
		internal static int __PropertyOffset_IsPublicToSequence;

		// Token: 0x04010497 RID: 66711
		internal static int __PropertyOffset_FloatParameter0;

		// Token: 0x04010498 RID: 66712
		internal static int __PropertyOffset_FloatParameter1;

		// Token: 0x04010499 RID: 66713
		internal static int __PropertyOffset_FloatParameter2;

		// Token: 0x0401049A RID: 66714
		internal static int __PropertyOffset_FloatParameterName0;

		// Token: 0x0401049B RID: 66715
		internal static int __PropertyOffset_FloatParameterName1;

		// Token: 0x0401049C RID: 66716
		internal static int __PropertyOffset_FloatParameterName2;

		// Token: 0x0401049D RID: 66717
		internal static int __PropertyOffset_EditorPlayType;

		// Token: 0x0401049E RID: 66718
		internal static int __PropertyOffset_VisibleInRaytracing;

		// Token: 0x0401049F RID: 66719
		internal static int __PropertyOffset_InUIScene;

		// Token: 0x040104A0 RID: 66720
		private static IntPtr __GetHandle_NativeFunctionPtr;

		// Token: 0x040104A1 RID: 66721
		private static IntPtr __AfterSpawnEffect_NativeFunctionPtr;

		// Token: 0x040104A2 RID: 66722
		private static IntPtr __GetStreamingBoundsEx_NativeFunctionPtr;

		// Token: 0x040104A3 RID: 66723
		private static IntPtr __StopEffect_NativeFunctionPtr;

		// Token: 0x040104A4 RID: 66724
		private static IntPtr __PlayEffect_NativeFunctionPtr;

		// Token: 0x040104A5 RID: 66725
		private static IntPtr __Play_NativeFunctionPtr;

		// Token: 0x040104A6 RID: 66726
		private static IntPtr __Stop_NativeFunctionPtr;

		// Token: 0x040104A7 RID: 66727
		private static IntPtr __IsEditor_NativeFunctionPtr;

		// Token: 0x040104A8 RID: 66728
		private static IntPtr __CalculateLifeTime_NativeFunctionPtr;

		// Token: 0x040104A9 RID: 66729
		private static IntPtr __Refresh_NativeFunctionPtr;

		// Token: 0x040104AA RID: 66730
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x040104AB RID: 66731
		private static IntPtr __SetHandle_NativeFunctionPtr;

		// Token: 0x040104AC RID: 66732
		private static IntPtr __RemoveHandle_NativeFunctionPtr;

		// Token: 0x040104AD RID: 66733
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x040104AE RID: 66734
		private static IntPtr __ReceiveEndPlay_NativeFunctionPtr;

		// Token: 0x040104AF RID: 66735
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x040104B0 RID: 66736
		private static IntPtr __DoHiddenInGame_NativeFunctionPtr;

		// Token: 0x040104B1 RID: 66737
		private static IntPtr __OnReceiveHideSceneEffectActor_NativeFunctionPtr;

		// Token: 0x040104B2 RID: 66738
		private static IntPtr __OnReceiveShowSceneEffectActor_NativeFunctionPtr;

		// Token: 0x040104B3 RID: 66739
		private static IntPtr __EditorDestroy_NativeFunctionPtr;

		// Token: 0x02008EB7 RID: 36535
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetHandle_FunctionParams
		{
			// Token: 0x0402CB54 RID: 183124
			[FieldOffset(0)]
			public int Handle;
		}

		// Token: 0x02008EB8 RID: 36536
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __AfterSpawnEffect_FunctionParams
		{
			// Token: 0x0402CB55 RID: 183125
			[FieldOffset(0)]
			public int EffectHandle;
		}

		// Token: 0x02008EB9 RID: 36537
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 192)]
		protected new ref struct __GetStreamingBoundsEx_FunctionParams
		{
			// Token: 0x0402CB56 RID: 183126
			[FieldOffset(0)]
			public FBox __Result;
		}

		// Token: 0x02008EBA RID: 36538
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 176)]
		protected ref struct __Play_FunctionParams
		{
			// Token: 0x0402CB57 RID: 183127
			[FieldOffset(0)]
			public FString Reason;
		}

		// Token: 0x02008EBB RID: 36539
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __Stop_FunctionParams
		{
			// Token: 0x0402CB58 RID: 183128
			[FieldOffset(0)]
			public FString Reason;

			// Token: 0x0402CB59 RID: 183129
			[FieldOffset(16)]
			public bool Immediately;

			// Token: 0x0402CB5A RID: 183130
			[FieldOffset(17)]
			public bool __Result;
		}

		// Token: 0x02008EBC RID: 36540
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __IsEditor_FunctionParams
		{
			// Token: 0x0402CB5B RID: 183131
			[FieldOffset(0)]
			public bool IsEditor;
		}

		// Token: 0x02008EBD RID: 36541
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __SetHandle_FunctionParams
		{
			// Token: 0x0402CB5C RID: 183132
			[FieldOffset(0)]
			public int Handle;
		}

		// Token: 0x02008EBE RID: 36542
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __ReceiveEndPlay_FunctionParams
		{
			// Token: 0x0402CB5D RID: 183133
			[FieldOffset(0)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}

		// Token: 0x02008EBF RID: 36543
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x0402CB5E RID: 183134
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02008EC0 RID: 36544
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __DoHiddenInGame_FunctionParams
		{
			// Token: 0x0402CB5F RID: 183135
			[FieldOffset(0)]
			public bool bValue;
		}
	}
}

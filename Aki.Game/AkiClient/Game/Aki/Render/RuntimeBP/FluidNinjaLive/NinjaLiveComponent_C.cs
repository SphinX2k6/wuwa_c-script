using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Render.RuntimeBP.FluidNinjaLive.Core;
using AkiClient.Game.Aki.Render.RuntimeBP.FluidNinjaLive.SimCache.BP;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.FluidNinjaLive
{
	// Token: 0x02003D8C RID: 15756
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/FluidNinjaLive/NinjaLiveComponent.NinjaLiveComponent_C")]
	[UnrealStructLayout(3336, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 3336)]
	public class NinjaLiveComponent_C : UKuroBPActorComponent, IUnrealUObject, IUnrealObject, INinjaLiveInterface_C, IUnrealBlueprintInterface, IUnrealInterface
	{
		// Token: 0x06026BC9 RID: 158665 RVA: 0x0097D64A File Offset: 0x0097B84A
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (NinjaLiveComponent_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/FluidNinjaLive/NinjaLiveComponent.NinjaLiveComponent_C");
			}
			return NinjaLiveComponent_C._ClassPtr;
		}

		// Token: 0x06026BCA RID: 158666 RVA: 0x0097D670 File Offset: 0x0097B870
		public NinjaLiveComponent_C() : this(BuiltinUtils.AllocNativeUObject(NinjaLiveComponent_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06026BCB RID: 158667 RVA: 0x0097D698 File Offset: 0x0097B898
		public NinjaLiveComponent_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(NinjaLiveComponent_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170053D4 RID: 21460
		// (get) Token: 0x06026BCC RID: 158668 RVA: 0x0097D6CB File Offset: 0x0097B8CB
		// (set) Token: 0x06026BCD RID: 158669 RVA: 0x0097D6DB File Offset: 0x0097B8DB
		public unsafe bool ComponentActivatedByPawnProximity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_1) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_1) = (value ? 1 : 0);
			}
		}

		// Token: 0x170053D5 RID: 21461
		// (get) Token: 0x06026BCE RID: 158670 RVA: 0x0097D6EC File Offset: 0x0097B8EC
		// (set) Token: 0x06026BCF RID: 158671 RVA: 0x0097D6FC File Offset: 0x0097B8FC
		public unsafe bool DisableComponent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_2) = (value ? 1 : 0);
			}
		}

		// Token: 0x170053D6 RID: 21462
		// (get) Token: 0x06026BD0 RID: 158672 RVA: 0x0097D70D File Offset: 0x0097B90D
		// (set) Token: 0x06026BD1 RID: 158673 RVA: 0x0097D71D File Offset: 0x0097B91D
		public unsafe bool BeginPlaySupressed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_3) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_3) = (value ? 1 : 0);
			}
		}

		// Token: 0x170053D7 RID: 21463
		// (get) Token: 0x06026BD2 RID: 158674 RVA: 0x0097D72E File Offset: 0x0097B92E
		// (set) Token: 0x06026BD3 RID: 158675 RVA: 0x0097D73E File Offset: 0x0097B93E
		public unsafe bool InitDone
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_4) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_4) = (value ? 1 : 0);
			}
		}

		// Token: 0x170053D8 RID: 21464
		// (get) Token: 0x06026BD4 RID: 158676 RVA: 0x0097D74F File Offset: 0x0097B94F
		// (set) Token: 0x06026BD5 RID: 158677 RVA: 0x0097D75F File Offset: 0x0097B95F
		public unsafe bool MaterialInstacesDone
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_5) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_5) = (value ? 1 : 0);
			}
		}

		// Token: 0x170053D9 RID: 21465
		// (get) Token: 0x06026BD6 RID: 158678 RVA: 0x0097D770 File Offset: 0x0097B970
		// (set) Token: 0x06026BD7 RID: 158679 RVA: 0x0097D780 File Offset: 0x0097B980
		public unsafe bool AutoConnectToMemoryPool_IF_Found
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_6) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_6) = (value ? 1 : 0);
			}
		}

		// Token: 0x170053DA RID: 21466
		// (get) Token: 0x06026BD8 RID: 158680 RVA: 0x0097D791 File Offset: 0x0097B991
		// (set) Token: 0x06026BD9 RID: 158681 RVA: 0x0097D7A1 File Offset: 0x0097B9A1
		public unsafe bool MemPoolManagerDetected
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_7) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_7) = (value ? 1 : 0);
			}
		}

		// Token: 0x170053DB RID: 21467
		// (get) Token: 0x06026BDA RID: 158682 RVA: 0x0097D7B2 File Offset: 0x0097B9B2
		// (set) Token: 0x06026BDB RID: 158683 RVA: 0x0097D7C2 File Offset: 0x0097B9C2
		public unsafe bool PoolManagerOverridesLocalSettings
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_8) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_8) = (value ? 1 : 0);
			}
		}

		// Token: 0x170053DC RID: 21468
		// (get) Token: 0x06026BDC RID: 158684 RVA: 0x0097D7D3 File Offset: 0x0097B9D3
		// (set) Token: 0x06026BDD RID: 158685 RVA: 0x0097D7E3 File Offset: 0x0097B9E3
		public unsafe int ResolutionX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x170053DD RID: 21469
		// (get) Token: 0x06026BDE RID: 158686 RVA: 0x0097D7F4 File Offset: 0x0097B9F4
		// (set) Token: 0x06026BDF RID: 158687 RVA: 0x0097D804 File Offset: 0x0097BA04
		public unsafe int ResolutionY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x170053DE RID: 21470
		// (get) Token: 0x06026BE0 RID: 158688 RVA: 0x0097D815 File Offset: 0x0097BA15
		// (set) Token: 0x06026BE1 RID: 158689 RVA: 0x0097D829 File Offset: 0x0097BA29
		public unsafe string PreferredTraceChannelName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)NinjaLiveComponent_C.__PropertyOffset_11)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)NinjaLiveComponent_C.__PropertyOffset_11)), value);
			}
		}

		// Token: 0x170053DF RID: 21471
		// (get) Token: 0x06026BE2 RID: 158690 RVA: 0x0097D83E File Offset: 0x0097BA3E
		// (set) Token: 0x06026BE3 RID: 158691 RVA: 0x0097D852 File Offset: 0x0097BA52
		[Nullable(0)]
		public unsafe TEnumAsByte<ETraceTypeQuery> TraceChannel
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_12);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x170053E0 RID: 21472
		// (get) Token: 0x06026BE4 RID: 158692 RVA: 0x0097D867 File Offset: 0x0097BA67
		// (set) Token: 0x06026BE5 RID: 158693 RVA: 0x0097D87B File Offset: 0x0097BA7B
		[Nullable(0)]
		public unsafe TEnumAsByte<ECollisionChannel> CollisionChannel
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_13);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x170053E1 RID: 21473
		// (get) Token: 0x06026BE6 RID: 158694 RVA: 0x0097D890 File Offset: 0x0097BA90
		// (set) Token: 0x06026BE7 RID: 158695 RVA: 0x0097D8A0 File Offset: 0x0097BAA0
		public unsafe bool TraceChannelsSet
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_14) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_14) = (value ? 1 : 0);
			}
		}

		// Token: 0x170053E2 RID: 21474
		// (get) Token: 0x06026BE8 RID: 158696 RVA: 0x0097D8B1 File Offset: 0x0097BAB1
		// (set) Token: 0x06026BE9 RID: 158697 RVA: 0x0097D8C5 File Offset: 0x0097BAC5
		[Nullable(0)]
		public unsafe TEnumAsByte<SimPrecision_Enum> SimPrecision
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_15);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x170053E3 RID: 21475
		// (get) Token: 0x06026BEA RID: 158698 RVA: 0x0097D8DA File Offset: 0x0097BADA
		// (set) Token: 0x06026BEB RID: 158699 RVA: 0x0097D8EA File Offset: 0x0097BAEA
		public unsafe bool UsePressureSolver1__DefaultIs2_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_16) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_16) = (value ? 1 : 0);
			}
		}

		// Token: 0x170053E4 RID: 21476
		// (get) Token: 0x06026BEC RID: 158700 RVA: 0x0097D8FB File Offset: 0x0097BAFB
		// (set) Token: 0x06026BED RID: 158701 RVA: 0x0097D90B File Offset: 0x0097BB0B
		public unsafe int PressureSolver1_MaxIterations
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x170053E5 RID: 21477
		// (get) Token: 0x06026BEE RID: 158702 RVA: 0x0097D91C File Offset: 0x0097BB1C
		// (set) Token: 0x06026BEF RID: 158703 RVA: 0x0097D92C File Offset: 0x0097BB2C
		public unsafe int PressureSolver2_MaxIterations
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x170053E6 RID: 21478
		// (get) Token: 0x06026BF0 RID: 158704 RVA: 0x0097D93D File Offset: 0x0097BB3D
		// (set) Token: 0x06026BF1 RID: 158705 RVA: 0x0097D94D File Offset: 0x0097BB4D
		public unsafe float PressureSolver2_KernelReduction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x170053E7 RID: 21479
		// (get) Token: 0x06026BF2 RID: 158706 RVA: 0x0097D95E File Offset: 0x0097BB5E
		// (set) Token: 0x06026BF3 RID: 158707 RVA: 0x0097D96E File Offset: 0x0097BB6E
		public unsafe int MaxSamplingFPS
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x170053E8 RID: 21480
		// (get) Token: 0x06026BF4 RID: 158708 RVA: 0x0097D97F File Offset: 0x0097BB7F
		// (set) Token: 0x06026BF5 RID: 158709 RVA: 0x0097D98F File Offset: 0x0097BB8F
		public unsafe int MinSamplingFPS
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x170053E9 RID: 21481
		// (get) Token: 0x06026BF6 RID: 158710 RVA: 0x0097D9A0 File Offset: 0x0097BBA0
		// (set) Token: 0x06026BF7 RID: 158711 RVA: 0x0097D9B0 File Offset: 0x0097BBB0
		public unsafe bool HalfResPressureAndDivergenceBuffers
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_22) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_22) = (value ? 1 : 0);
			}
		}

		// Token: 0x170053EA RID: 21482
		// (get) Token: 0x06026BF8 RID: 158712 RVA: 0x0097D9C1 File Offset: 0x0097BBC1
		// (set) Token: 0x06026BF9 RID: 158713 RVA: 0x0097D9D1 File Offset: 0x0097BBD1
		public unsafe bool ShowDebugMessages_TraceChannels
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_23) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_23) = (value ? 1 : 0);
			}
		}

		// Token: 0x170053EB RID: 21483
		// (get) Token: 0x06026BFA RID: 158714 RVA: 0x0097D9E2 File Offset: 0x0097BBE2
		// (set) Token: 0x06026BFB RID: 158715 RVA: 0x0097D9F2 File Offset: 0x0097BBF2
		public unsafe bool ShowDebugMessages_MemoryManagement
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_24) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_24) = (value ? 1 : 0);
			}
		}

		// Token: 0x170053EC RID: 21484
		// (get) Token: 0x06026BFC RID: 158716 RVA: 0x0097DA03 File Offset: 0x0097BC03
		// (set) Token: 0x06026BFD RID: 158717 RVA: 0x0097DA13 File Offset: 0x0097BC13
		public unsafe bool ShowDebugMessages_CollisionAndTracing
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_25) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_25) = (value ? 1 : 0);
			}
		}

		// Token: 0x170053ED RID: 21485
		// (get) Token: 0x06026BFE RID: 158718 RVA: 0x0097DA24 File Offset: 0x0097BC24
		// (set) Token: 0x06026BFF RID: 158719 RVA: 0x0097DA34 File Offset: 0x0097BC34
		public unsafe bool ShowDebugMessages_LODInitial
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_26) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_26) = (value ? 1 : 0);
			}
		}

		// Token: 0x170053EE RID: 21486
		// (get) Token: 0x06026C00 RID: 158720 RVA: 0x0097DA45 File Offset: 0x0097BC45
		// (set) Token: 0x06026C01 RID: 158721 RVA: 0x0097DA55 File Offset: 0x0097BC55
		public unsafe bool ShowDebugMessages_LODRuntime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_27) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_27) = (value ? 1 : 0);
			}
		}

		// Token: 0x170053EF RID: 21487
		// (get) Token: 0x06026C02 RID: 158722 RVA: 0x0097DA66 File Offset: 0x0097BC66
		// (set) Token: 0x06026C03 RID: 158723 RVA: 0x0097DA76 File Offset: 0x0097BC76
		public unsafe bool ShowDebugMessages_InterfaceControl
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_28) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_28) = (value ? 1 : 0);
			}
		}

		// Token: 0x170053F0 RID: 21488
		// (get) Token: 0x06026C04 RID: 158724 RVA: 0x0097DA87 File Offset: 0x0097BC87
		// (set) Token: 0x06026C05 RID: 158725 RVA: 0x0097DA97 File Offset: 0x0097BC97
		public unsafe bool ShowDebugMessages_RenderTargetExport
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_29) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_29) = (value ? 1 : 0);
			}
		}

		// Token: 0x170053F1 RID: 21489
		// (get) Token: 0x06026C06 RID: 158726 RVA: 0x0097DAA8 File Offset: 0x0097BCA8
		// (set) Token: 0x06026C07 RID: 158727 RVA: 0x0097DAB8 File Offset: 0x0097BCB8
		public unsafe bool ShowWarning_NumberOfBonesToTrack
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_30) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_30) = (value ? 1 : 0);
			}
		}

		// Token: 0x170053F2 RID: 21490
		// (get) Token: 0x06026C08 RID: 158728 RVA: 0x0097DAC9 File Offset: 0x0097BCC9
		// (set) Token: 0x06026C09 RID: 158729 RVA: 0x0097DAD9 File Offset: 0x0097BCD9
		public unsafe bool VisualizeCustomTraceSource
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_31) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_31) = (value ? 1 : 0);
			}
		}

		// Token: 0x170053F3 RID: 21491
		// (get) Token: 0x06026C0A RID: 158730 RVA: 0x0097DAEA File Offset: 0x0097BCEA
		// (set) Token: 0x06026C0B RID: 158731 RVA: 0x0097DAFA File Offset: 0x0097BCFA
		public unsafe bool SaveDebugMessagesToDefaultLog
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_32) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_32) = (value ? 1 : 0);
			}
		}

		// Token: 0x170053F4 RID: 21492
		// (get) Token: 0x06026C0C RID: 158732 RVA: 0x0097DB0B File Offset: 0x0097BD0B
		// (set) Token: 0x06026C0D RID: 158733 RVA: 0x0097DB1B File Offset: 0x0097BD1B
		public unsafe float DebugMessagesLifetime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_33);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_33) = value;
			}
		}

		// Token: 0x170053F5 RID: 21493
		// (get) Token: 0x06026C0E RID: 158734 RVA: 0x0097DB2C File Offset: 0x0097BD2C
		// (set) Token: 0x06026C0F RID: 158735 RVA: 0x0097DB40 File Offset: 0x0097BD40
		[Nullable(2)]
		public unsafe UStaticMeshComponent TraceMeshComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveComponent_C.__PropertyOffset_34);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveComponent_C.__PropertyOffset_34, value);
			}
		}

		// Token: 0x170053F6 RID: 21494
		// (get) Token: 0x06026C10 RID: 158736 RVA: 0x0097DB55 File Offset: 0x0097BD55
		// (set) Token: 0x06026C11 RID: 158737 RVA: 0x0097DB65 File Offset: 0x0097BD65
		public unsafe int SamplingFPS
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_35);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_35) = value;
			}
		}

		// Token: 0x170053F7 RID: 21495
		// (get) Token: 0x06026C12 RID: 158738 RVA: 0x0097DB76 File Offset: 0x0097BD76
		// (set) Token: 0x06026C13 RID: 158739 RVA: 0x0097DB86 File Offset: 0x0097BD86
		public unsafe float TickRateCustom
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_36);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_36) = value;
			}
		}

		// Token: 0x170053F8 RID: 21496
		// (get) Token: 0x06026C14 RID: 158740 RVA: 0x0097DB97 File Offset: 0x0097BD97
		// (set) Token: 0x06026C15 RID: 158741 RVA: 0x0097DBA7 File Offset: 0x0097BDA7
		public unsafe bool LOD1_ReduceSimQuality
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_37) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_37) = (value ? 1 : 0);
			}
		}

		// Token: 0x170053F9 RID: 21497
		// (get) Token: 0x06026C16 RID: 158742 RVA: 0x0097DBB8 File Offset: 0x0097BDB8
		// (set) Token: 0x06026C17 RID: 158743 RVA: 0x0097DBC8 File Offset: 0x0097BDC8
		public unsafe bool LOD2_ReduceSamplingFPS
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_38) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_38) = (value ? 1 : 0);
			}
		}

		// Token: 0x170053FA RID: 21498
		// (get) Token: 0x06026C18 RID: 158744 RVA: 0x0097DBD9 File Offset: 0x0097BDD9
		// (set) Token: 0x06026C19 RID: 158745 RVA: 0x0097DBE9 File Offset: 0x0097BDE9
		public unsafe float LOD_FarBound
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_39);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_39) = value;
			}
		}

		// Token: 0x170053FB RID: 21499
		// (get) Token: 0x06026C1A RID: 158746 RVA: 0x0097DBFA File Offset: 0x0097BDFA
		// (set) Token: 0x06026C1B RID: 158747 RVA: 0x0097DC0A File Offset: 0x0097BE0A
		public unsafe float LOD_NearBound
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_40);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_40) = value;
			}
		}

		// Token: 0x170053FC RID: 21500
		// (get) Token: 0x06026C1C RID: 158748 RVA: 0x0097DC1B File Offset: 0x0097BE1B
		// (set) Token: 0x06026C1D RID: 158749 RVA: 0x0097DC2B File Offset: 0x0097BE2B
		public unsafe int LOD_Steps
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_41);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_41) = value;
			}
		}

		// Token: 0x170053FD RID: 21501
		// (get) Token: 0x06026C1E RID: 158750 RVA: 0x0097DC3C File Offset: 0x0097BE3C
		// (set) Token: 0x06026C1F RID: 158751 RVA: 0x0097DC4C File Offset: 0x0097BE4C
		public unsafe float LOD_StepRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_42);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_42) = value;
			}
		}

		// Token: 0x170053FE RID: 21502
		// (get) Token: 0x06026C20 RID: 158752 RVA: 0x0097DC60 File Offset: 0x0097BE60
		// (set) Token: 0x06026C21 RID: 158753 RVA: 0x0097DC99 File Offset: 0x0097BE99
		public TArray<float> LOD_StepsArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._LOD_StepsArray) == null)
				{
					result = (this._LOD_StepsArray = new TArray<float>(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_43, this));
				}
				return result;
			}
			set
			{
				this.LOD_StepsArray.CopyAssign(value);
			}
		}

		// Token: 0x170053FF RID: 21503
		// (get) Token: 0x06026C22 RID: 158754 RVA: 0x0097DCA7 File Offset: 0x0097BEA7
		// (set) Token: 0x06026C23 RID: 158755 RVA: 0x0097DCB7 File Offset: 0x0097BEB7
		public unsafe int SimPrecisionIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_44);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_44) = value;
			}
		}

		// Token: 0x17005400 RID: 21504
		// (get) Token: 0x06026C24 RID: 158756 RVA: 0x0097DCC8 File Offset: 0x0097BEC8
		// (set) Token: 0x06026C25 RID: 158757 RVA: 0x0097DCD8 File Offset: 0x0097BED8
		public unsafe float MemConsumption
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_45);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_45) = value;
			}
		}

		// Token: 0x17005401 RID: 21505
		// (get) Token: 0x06026C26 RID: 158758 RVA: 0x0097DCE9 File Offset: 0x0097BEE9
		// (set) Token: 0x06026C27 RID: 158759 RVA: 0x0097DCF9 File Offset: 0x0097BEF9
		public unsafe int MapLengthTmp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_46);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_46) = value;
			}
		}

		// Token: 0x17005402 RID: 21506
		// (get) Token: 0x06026C28 RID: 158760 RVA: 0x0097DD0A File Offset: 0x0097BF0A
		// (set) Token: 0x06026C29 RID: 158761 RVA: 0x0097DD1E File Offset: 0x0097BF1E
		[Nullable(2)]
		public unsafe UMaterialInstance InactiveGrayMaterial
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveComponent_C.__PropertyOffset_47);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveComponent_C.__PropertyOffset_47, value);
			}
		}

		// Token: 0x17005403 RID: 21507
		// (get) Token: 0x06026C2A RID: 158762 RVA: 0x0097DD34 File Offset: 0x0097BF34
		// (set) Token: 0x06026C2B RID: 158763 RVA: 0x0097DD6D File Offset: 0x0097BF6D
		public ComponentRePlayEvent ComponentRePlayEvent
		{
			get
			{
				base.FastCheckIsValid();
				ComponentRePlayEvent result;
				if ((result = this._ComponentRePlayEvent) == null)
				{
					result = (this._ComponentRePlayEvent = new ComponentRePlayEvent(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_48, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_48, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17005404 RID: 21508
		// (get) Token: 0x06026C2C RID: 158764 RVA: 0x0097DD90 File Offset: 0x0097BF90
		// (set) Token: 0x06026C2D RID: 158765 RVA: 0x0097DDC9 File Offset: 0x0097BFC9
		public ComponentBroadcastMemConsumption ComponentBroadcastMemConsumption
		{
			get
			{
				base.FastCheckIsValid();
				ComponentBroadcastMemConsumption result;
				if ((result = this._ComponentBroadcastMemConsumption) == null)
				{
					result = (this._ComponentBroadcastMemConsumption = new ComponentBroadcastMemConsumption(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_49, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_49, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17005405 RID: 21509
		// (get) Token: 0x06026C2E RID: 158766 RVA: 0x0097DDEA File Offset: 0x0097BFEA
		// (set) Token: 0x06026C2F RID: 158767 RVA: 0x0097DDFA File Offset: 0x0097BFFA
		public unsafe bool PawnInsideActivationBounds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_50) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_50) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005406 RID: 21510
		// (get) Token: 0x06026C30 RID: 158768 RVA: 0x0097DE0B File Offset: 0x0097C00B
		// (set) Token: 0x06026C31 RID: 158769 RVA: 0x0097DE1F File Offset: 0x0097C01F
		[Nullable(2)]
		public unsafe UDataTable LoadedDataTable
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UDataTable>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveComponent_C.__PropertyOffset_51);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveComponent_C.__PropertyOffset_51, value);
			}
		}

		// Token: 0x17005407 RID: 21511
		// (get) Token: 0x06026C32 RID: 158770 RVA: 0x0097DE34 File Offset: 0x0097C034
		// (set) Token: 0x06026C33 RID: 158771 RVA: 0x0097DE48 File Offset: 0x0097C048
		public unsafe string LoadedDataTablePath
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)NinjaLiveComponent_C.__PropertyOffset_52)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)NinjaLiveComponent_C.__PropertyOffset_52)), value);
			}
		}

		// Token: 0x17005408 RID: 21512
		// (get) Token: 0x06026C34 RID: 158772 RVA: 0x0097DE60 File Offset: 0x0097C060
		// (set) Token: 0x06026C35 RID: 158773 RVA: 0x0097DE99 File Offset: 0x0097C099
		public TMap<string, float> PresetMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, float> result;
				if ((result = this._PresetMap) == null)
				{
					result = (this._PresetMap = new TMap<string, float>(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_53, this));
				}
				return result;
			}
			set
			{
				this.PresetMap.CopyAssign(value);
			}
		}

		// Token: 0x17005409 RID: 21513
		// (get) Token: 0x06026C36 RID: 158774 RVA: 0x0097DEA7 File Offset: 0x0097C0A7
		// (set) Token: 0x06026C37 RID: 158775 RVA: 0x0097DEBB File Offset: 0x0097C0BB
		public unsafe string ActualPreset
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)NinjaLiveComponent_C.__PropertyOffset_54)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)NinjaLiveComponent_C.__PropertyOffset_54)), value);
			}
		}

		// Token: 0x1700540A RID: 21514
		// (get) Token: 0x06026C38 RID: 158776 RVA: 0x0097DED0 File Offset: 0x0097C0D0
		// (set) Token: 0x06026C39 RID: 158777 RVA: 0x0097DEE4 File Offset: 0x0097C0E4
		[Nullable(2)]
		public unsafe UDataTable DefaultPreset
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UDataTable>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveComponent_C.__PropertyOffset_55);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveComponent_C.__PropertyOffset_55, value);
			}
		}

		// Token: 0x1700540B RID: 21515
		// (get) Token: 0x06026C3A RID: 158778 RVA: 0x0097DEFC File Offset: 0x0097C0FC
		// (set) Token: 0x06026C3B RID: 158779 RVA: 0x0097DF35 File Offset: 0x0097C135
		public TArray<FName> PresetSearchPaths
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._PresetSearchPaths) == null)
				{
					result = (this._PresetSearchPaths = new TArray<FName>(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_56, this));
				}
				return result;
			}
			set
			{
				this.PresetSearchPaths.CopyAssign(value);
			}
		}

		// Token: 0x1700540C RID: 21516
		// (get) Token: 0x06026C3C RID: 158780 RVA: 0x0097DF43 File Offset: 0x0097C143
		// (set) Token: 0x06026C3D RID: 158781 RVA: 0x0097DF57 File Offset: 0x0097C157
		public unsafe FName PresetNameFilterCriteria
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_57);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_57) = value;
			}
		}

		// Token: 0x1700540D RID: 21517
		// (get) Token: 0x06026C3E RID: 158782 RVA: 0x0097DF6C File Offset: 0x0097C16C
		// (set) Token: 0x06026C3F RID: 158783 RVA: 0x0097DF7C File Offset: 0x0097C17C
		public unsafe bool TraceMeshInvisible
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_58) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_58) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700540E RID: 21518
		// (get) Token: 0x06026C40 RID: 158784 RVA: 0x0097DF8D File Offset: 0x0097C18D
		// (set) Token: 0x06026C41 RID: 158785 RVA: 0x0097DF9D File Offset: 0x0097C19D
		public unsafe int OutputMaterialSelected
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_59);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_59) = value;
			}
		}

		// Token: 0x1700540F RID: 21519
		// (get) Token: 0x06026C42 RID: 158786 RVA: 0x0097DFB0 File Offset: 0x0097C1B0
		// (set) Token: 0x06026C43 RID: 158787 RVA: 0x0097DFE9 File Offset: 0x0097C1E9
		public TArray<UMaterialInterface> OutputMaterials
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInterface> result;
				if ((result = this._OutputMaterials) == null)
				{
					result = (this._OutputMaterials = new TArray<UMaterialInterface>(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_60, this));
				}
				return result;
			}
			set
			{
				this.OutputMaterials.CopyAssign(value);
			}
		}

		// Token: 0x17005410 RID: 21520
		// (get) Token: 0x06026C44 RID: 158788 RVA: 0x0097DFF7 File Offset: 0x0097C1F7
		// (set) Token: 0x06026C45 RID: 158789 RVA: 0x0097E007 File Offset: 0x0097C207
		public unsafe bool ForceAutoLoadPreset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_61) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_61) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005411 RID: 21521
		// (get) Token: 0x06026C46 RID: 158790 RVA: 0x0097E018 File Offset: 0x0097C218
		// (set) Token: 0x06026C47 RID: 158791 RVA: 0x0097E051 File Offset: 0x0097C251
		public TArray<string> RenderTargetsList
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._RenderTargetsList) == null)
				{
					result = (this._RenderTargetsList = new TArray<string>(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_62, this));
				}
				return result;
			}
			set
			{
				this.RenderTargetsList.CopyAssign(value);
			}
		}

		// Token: 0x17005412 RID: 21522
		// (get) Token: 0x06026C48 RID: 158792 RVA: 0x0097E060 File Offset: 0x0097C260
		// (set) Token: 0x06026C49 RID: 158793 RVA: 0x0097E099 File Offset: 0x0097C299
		public TMap<string, UTextureRenderTarget2D> RenderTargetsMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, UTextureRenderTarget2D> result;
				if ((result = this._RenderTargetsMap) == null)
				{
					result = (this._RenderTargetsMap = new TMap<string, UTextureRenderTarget2D>(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_63, this));
				}
				return result;
			}
			set
			{
				this.RenderTargetsMap.CopyAssign(value);
			}
		}

		// Token: 0x17005413 RID: 21523
		// (get) Token: 0x06026C4A RID: 158794 RVA: 0x0097E0A7 File Offset: 0x0097C2A7
		// (set) Token: 0x06026C4B RID: 158795 RVA: 0x0097E0BB File Offset: 0x0097C2BB
		[Nullable(2)]
		public unsafe UMaterialInstanceDynamic MI_Advection
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveComponent_C.__PropertyOffset_64);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveComponent_C.__PropertyOffset_64, value);
			}
		}

		// Token: 0x17005414 RID: 21524
		// (get) Token: 0x06026C4C RID: 158796 RVA: 0x0097E0D0 File Offset: 0x0097C2D0
		// (set) Token: 0x06026C4D RID: 158797 RVA: 0x0097E0E4 File Offset: 0x0097C2E4
		[Nullable(2)]
		public unsafe UMaterialInstanceDynamic MI_Divergence
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveComponent_C.__PropertyOffset_65);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveComponent_C.__PropertyOffset_65, value);
			}
		}

		// Token: 0x17005415 RID: 21525
		// (get) Token: 0x06026C4E RID: 158798 RVA: 0x0097E0F9 File Offset: 0x0097C2F9
		// (set) Token: 0x06026C4F RID: 158799 RVA: 0x0097E10D File Offset: 0x0097C30D
		[Nullable(2)]
		public unsafe UMaterialInstanceDynamic MI_PressureCycle1
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveComponent_C.__PropertyOffset_66);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveComponent_C.__PropertyOffset_66, value);
			}
		}

		// Token: 0x17005416 RID: 21526
		// (get) Token: 0x06026C50 RID: 158800 RVA: 0x0097E122 File Offset: 0x0097C322
		// (set) Token: 0x06026C51 RID: 158801 RVA: 0x0097E136 File Offset: 0x0097C336
		[Nullable(2)]
		public unsafe UMaterialInstanceDynamic MI_PressureCycle2
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveComponent_C.__PropertyOffset_67);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveComponent_C.__PropertyOffset_67, value);
			}
		}

		// Token: 0x17005417 RID: 21527
		// (get) Token: 0x06026C52 RID: 158802 RVA: 0x0097E14B File Offset: 0x0097C34B
		// (set) Token: 0x06026C53 RID: 158803 RVA: 0x0097E15B File Offset: 0x0097C35B
		public unsafe float VeloStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_68);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_68) = value;
			}
		}

		// Token: 0x17005418 RID: 21528
		// (get) Token: 0x06026C54 RID: 158804 RVA: 0x0097E16C File Offset: 0x0097C36C
		// (set) Token: 0x06026C55 RID: 158805 RVA: 0x0097E17C File Offset: 0x0097C37C
		public unsafe float VeloOffsetX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_69);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_69) = value;
			}
		}

		// Token: 0x17005419 RID: 21529
		// (get) Token: 0x06026C56 RID: 158806 RVA: 0x0097E18D File Offset: 0x0097C38D
		// (set) Token: 0x06026C57 RID: 158807 RVA: 0x0097E19D File Offset: 0x0097C39D
		public unsafe float VeloOffsetY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_70);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_70) = value;
			}
		}

		// Token: 0x1700541A RID: 21530
		// (get) Token: 0x06026C58 RID: 158808 RVA: 0x0097E1AE File Offset: 0x0097C3AE
		// (set) Token: 0x06026C59 RID: 158809 RVA: 0x0097E1BE File Offset: 0x0097C3BE
		public unsafe float VeloRotate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_71);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_71) = value;
			}
		}

		// Token: 0x1700541B RID: 21531
		// (get) Token: 0x06026C5A RID: 158810 RVA: 0x0097E1CF File Offset: 0x0097C3CF
		// (set) Token: 0x06026C5B RID: 158811 RVA: 0x0097E1DF File Offset: 0x0097C3DF
		public unsafe float VeloAmpNoise
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_72);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_72) = value;
			}
		}

		// Token: 0x1700541C RID: 21532
		// (get) Token: 0x06026C5C RID: 158812 RVA: 0x0097E1F0 File Offset: 0x0097C3F0
		// (set) Token: 0x06026C5D RID: 158813 RVA: 0x0097E200 File Offset: 0x0097C400
		public unsafe float VeloDirNoise
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_73);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_73) = value;
			}
		}

		// Token: 0x1700541D RID: 21533
		// (get) Token: 0x06026C5E RID: 158814 RVA: 0x0097E211 File Offset: 0x0097C411
		// (set) Token: 0x06026C5F RID: 158815 RVA: 0x0097E221 File Offset: 0x0097C421
		public unsafe float Speed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_74);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_74) = value;
			}
		}

		// Token: 0x1700541E RID: 21534
		// (get) Token: 0x06026C60 RID: 158816 RVA: 0x0097E232 File Offset: 0x0097C432
		// (set) Token: 0x06026C61 RID: 158817 RVA: 0x0097E246 File Offset: 0x0097C446
		public unsafe FName Apply1stOutMatToActorsWithTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_75);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_75) = value;
			}
		}

		// Token: 0x1700541F RID: 21535
		// (get) Token: 0x06026C62 RID: 158818 RVA: 0x0097E25B File Offset: 0x0097C45B
		// (set) Token: 0x06026C63 RID: 158819 RVA: 0x0097E26F File Offset: 0x0097C46F
		public unsafe FName Apply1stOutMatToComponentsWithTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_76);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_76) = value;
			}
		}

		// Token: 0x17005420 RID: 21536
		// (get) Token: 0x06026C64 RID: 158820 RVA: 0x0097E284 File Offset: 0x0097C484
		// (set) Token: 0x06026C65 RID: 158821 RVA: 0x0097E298 File Offset: 0x0097C498
		public unsafe FName FeedTaggedActorNiagaraComponent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_77);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_77) = value;
			}
		}

		// Token: 0x17005421 RID: 21537
		// (get) Token: 0x06026C66 RID: 158822 RVA: 0x0097E2AD File Offset: 0x0097C4AD
		// (set) Token: 0x06026C67 RID: 158823 RVA: 0x0097E2BD File Offset: 0x0097C4BD
		public unsafe bool Make1stOutputAvailableFor2ndOutput
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_78) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_78) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005422 RID: 21538
		// (get) Token: 0x06026C68 RID: 158824 RVA: 0x0097E2CE File Offset: 0x0097C4CE
		// (set) Token: 0x06026C69 RID: 158825 RVA: 0x0097E2DE File Offset: 0x0097C4DE
		public unsafe bool Make1stOutputAvailableForNiagara
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_79) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_79) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005423 RID: 21539
		// (get) Token: 0x06026C6A RID: 158826 RVA: 0x0097E2EF File Offset: 0x0097C4EF
		// (set) Token: 0x06026C6B RID: 158827 RVA: 0x0097E2FF File Offset: 0x0097C4FF
		public unsafe bool MakePressureAvailableForNiagara
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_80) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_80) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005424 RID: 21540
		// (get) Token: 0x06026C6C RID: 158828 RVA: 0x0097E310 File Offset: 0x0097C510
		// (set) Token: 0x06026C6D RID: 158829 RVA: 0x0097E320 File Offset: 0x0097C520
		public unsafe int SecondaryOutputMaterialSelected
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_81);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_81) = value;
			}
		}

		// Token: 0x17005425 RID: 21541
		// (get) Token: 0x06026C6E RID: 158830 RVA: 0x0097E334 File Offset: 0x0097C534
		// (set) Token: 0x06026C6F RID: 158831 RVA: 0x0097E36D File Offset: 0x0097C56D
		public TArray<UMaterialInterface> SecondaryOutputMaterials
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInterface> result;
				if ((result = this._SecondaryOutputMaterials) == null)
				{
					result = (this._SecondaryOutputMaterials = new TArray<UMaterialInterface>(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_82, this));
				}
				return result;
			}
			set
			{
				this.SecondaryOutputMaterials.CopyAssign(value);
			}
		}

		// Token: 0x17005426 RID: 21542
		// (get) Token: 0x06026C70 RID: 158832 RVA: 0x0097E37B File Offset: 0x0097C57B
		// (set) Token: 0x06026C71 RID: 158833 RVA: 0x0097E38F File Offset: 0x0097C58F
		public unsafe FName Apply2ndOutMatToActorsWithTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_83);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_83) = value;
			}
		}

		// Token: 0x17005427 RID: 21543
		// (get) Token: 0x06026C72 RID: 158834 RVA: 0x0097E3A4 File Offset: 0x0097C5A4
		// (set) Token: 0x06026C73 RID: 158835 RVA: 0x0097E3B8 File Offset: 0x0097C5B8
		public unsafe FName Apply2ndOutMatToComponentsWithTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_84);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_84) = value;
			}
		}

		// Token: 0x17005428 RID: 21544
		// (get) Token: 0x06026C74 RID: 158836 RVA: 0x0097E3CD File Offset: 0x0097C5CD
		// (set) Token: 0x06026C75 RID: 158837 RVA: 0x0097E3DD File Offset: 0x0097C5DD
		public unsafe bool UseRenderTargetAsInput
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_85) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_85) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005429 RID: 21545
		// (get) Token: 0x06026C76 RID: 158838 RVA: 0x0097E3EE File Offset: 0x0097C5EE
		// (set) Token: 0x06026C77 RID: 158839 RVA: 0x0097E402 File Offset: 0x0097C602
		[Nullable(2)]
		public unsafe UTextureRenderTarget InputRenderTarget
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveComponent_C.__PropertyOffset_86);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveComponent_C.__PropertyOffset_86, value);
			}
		}

		// Token: 0x1700542A RID: 21546
		// (get) Token: 0x06026C78 RID: 158840 RVA: 0x0097E417 File Offset: 0x0097C617
		// (set) Token: 0x06026C79 RID: 158841 RVA: 0x0097E427 File Offset: 0x0097C627
		public unsafe bool RGB_InputMaterial
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_87) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_87) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700542B RID: 21547
		// (get) Token: 0x06026C7A RID: 158842 RVA: 0x0097E438 File Offset: 0x0097C638
		// (set) Token: 0x06026C7B RID: 158843 RVA: 0x0097E448 File Offset: 0x0097C648
		public unsafe int InputMaterialSelected
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_88);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_88) = value;
			}
		}

		// Token: 0x1700542C RID: 21548
		// (get) Token: 0x06026C7C RID: 158844 RVA: 0x0097E45C File Offset: 0x0097C65C
		// (set) Token: 0x06026C7D RID: 158845 RVA: 0x0097E495 File Offset: 0x0097C695
		public TArray<UMaterialInterface> InputMaterials
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInterface> result;
				if ((result = this._InputMaterials) == null)
				{
					result = (this._InputMaterials = new TArray<UMaterialInterface>(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_89, this));
				}
				return result;
			}
			set
			{
				this.InputMaterials.CopyAssign(value);
			}
		}

		// Token: 0x1700542D RID: 21549
		// (get) Token: 0x06026C7E RID: 158846 RVA: 0x0097E4A3 File Offset: 0x0097C6A3
		// (set) Token: 0x06026C7F RID: 158847 RVA: 0x0097E4B3 File Offset: 0x0097C6B3
		public unsafe bool SimAreaClamp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_90) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_90) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700542E RID: 21550
		// (get) Token: 0x06026C80 RID: 158848 RVA: 0x0097E4C4 File Offset: 0x0097C6C4
		// (set) Token: 0x06026C81 RID: 158849 RVA: 0x0097E4D4 File Offset: 0x0097C6D4
		public unsafe bool ShowMouseCursor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_91) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_91) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700542F RID: 21551
		// (get) Token: 0x06026C82 RID: 158850 RVA: 0x0097E4E5 File Offset: 0x0097C6E5
		// (set) Token: 0x06026C83 RID: 158851 RVA: 0x0097E4F5 File Offset: 0x0097C6F5
		public unsafe float Divergence
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_92);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_92) = value;
			}
		}

		// Token: 0x17005430 RID: 21552
		// (get) Token: 0x06026C84 RID: 158852 RVA: 0x0097E506 File Offset: 0x0097C706
		// (set) Token: 0x06026C85 RID: 158853 RVA: 0x0097E516 File Offset: 0x0097C716
		public unsafe float InputFeedback
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_93);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_93) = value;
			}
		}

		// Token: 0x17005431 RID: 21553
		// (get) Token: 0x06026C86 RID: 158854 RVA: 0x0097E527 File Offset: 0x0097C727
		// (set) Token: 0x06026C87 RID: 158855 RVA: 0x0097E537 File Offset: 0x0097C737
		public unsafe float FlowFeedback
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_94);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_94) = value;
			}
		}

		// Token: 0x17005432 RID: 21554
		// (get) Token: 0x06026C88 RID: 158856 RVA: 0x0097E548 File Offset: 0x0097C748
		// (set) Token: 0x06026C89 RID: 158857 RVA: 0x0097E558 File Offset: 0x0097C758
		public unsafe float VeloFromSimAreaMotion
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_95);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_95) = value;
			}
		}

		// Token: 0x17005433 RID: 21555
		// (get) Token: 0x06026C8A RID: 158858 RVA: 0x0097E569 File Offset: 0x0097C769
		// (set) Token: 0x06026C8B RID: 158859 RVA: 0x0097E579 File Offset: 0x0097C779
		public unsafe float OffsetFromSimAreaMotion
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_96);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_96) = value;
			}
		}

		// Token: 0x17005434 RID: 21556
		// (get) Token: 0x06026C8C RID: 158860 RVA: 0x0097E58A File Offset: 0x0097C78A
		// (set) Token: 0x06026C8D RID: 158861 RVA: 0x0097E59A File Offset: 0x0097C79A
		public unsafe float VeloFromBrushMotion
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_97);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_97) = value;
			}
		}

		// Token: 0x17005435 RID: 21557
		// (get) Token: 0x06026C8E RID: 158862 RVA: 0x0097E5AB File Offset: 0x0097C7AB
		// (set) Token: 0x06026C8F RID: 158863 RVA: 0x0097E5BB File Offset: 0x0097C7BB
		public unsafe float BrushSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_98);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_98) = value;
			}
		}

		// Token: 0x17005436 RID: 21558
		// (get) Token: 0x06026C90 RID: 158864 RVA: 0x0097E5CC File Offset: 0x0097C7CC
		// (set) Token: 0x06026C91 RID: 158865 RVA: 0x0097E5DC File Offset: 0x0097C7DC
		public unsafe float BrushStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_99);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_99) = value;
			}
		}

		// Token: 0x17005437 RID: 21559
		// (get) Token: 0x06026C92 RID: 158866 RVA: 0x0097E5ED File Offset: 0x0097C7ED
		// (set) Token: 0x06026C93 RID: 158867 RVA: 0x0097E5FD File Offset: 0x0097C7FD
		public unsafe float BrushStrengthTemp1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_100);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_100) = value;
			}
		}

		// Token: 0x17005438 RID: 21560
		// (get) Token: 0x06026C94 RID: 158868 RVA: 0x0097E60E File Offset: 0x0097C80E
		// (set) Token: 0x06026C95 RID: 158869 RVA: 0x0097E61E File Offset: 0x0097C81E
		public unsafe bool EraserMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_101) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_101) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005439 RID: 21561
		// (get) Token: 0x06026C96 RID: 158870 RVA: 0x0097E62F File Offset: 0x0097C82F
		// (set) Token: 0x06026C97 RID: 158871 RVA: 0x0097E63F File Offset: 0x0097C83F
		public unsafe float BrushHardness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_102);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_102) = value;
			}
		}

		// Token: 0x1700543A RID: 21562
		// (get) Token: 0x06026C98 RID: 158872 RVA: 0x0097E650 File Offset: 0x0097C850
		// (set) Token: 0x06026C99 RID: 158873 RVA: 0x0097E664 File Offset: 0x0097C864
		public unsafe string ParticleTemplate
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)NinjaLiveComponent_C.__PropertyOffset_103)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)NinjaLiveComponent_C.__PropertyOffset_103)), value);
			}
		}

		// Token: 0x1700543B RID: 21563
		// (get) Token: 0x06026C9A RID: 158874 RVA: 0x0097E679 File Offset: 0x0097C879
		// (set) Token: 0x06026C9B RID: 158875 RVA: 0x0097E68D File Offset: 0x0097C88D
		public unsafe string DensityTemplate
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)NinjaLiveComponent_C.__PropertyOffset_104)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)NinjaLiveComponent_C.__PropertyOffset_104)), value);
			}
		}

		// Token: 0x1700543C RID: 21564
		// (get) Token: 0x06026C9C RID: 158876 RVA: 0x0097E6A2 File Offset: 0x0097C8A2
		// (set) Token: 0x06026C9D RID: 158877 RVA: 0x0097E6B6 File Offset: 0x0097C8B6
		public unsafe string VelocityTemplate
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)NinjaLiveComponent_C.__PropertyOffset_105)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)NinjaLiveComponent_C.__PropertyOffset_105)), value);
			}
		}

		// Token: 0x1700543D RID: 21565
		// (get) Token: 0x06026C9E RID: 158878 RVA: 0x0097E6CB File Offset: 0x0097C8CB
		// (set) Token: 0x06026C9F RID: 158879 RVA: 0x0097E6DF File Offset: 0x0097C8DF
		public unsafe string MetaData
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)NinjaLiveComponent_C.__PropertyOffset_106)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)NinjaLiveComponent_C.__PropertyOffset_106)), value);
			}
		}

		// Token: 0x1700543E RID: 21566
		// (get) Token: 0x06026CA0 RID: 158880 RVA: 0x0097E6F4 File Offset: 0x0097C8F4
		// (set) Token: 0x06026CA1 RID: 158881 RVA: 0x0097E704 File Offset: 0x0097C904
		public unsafe float BrushPuncture
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_107);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_107) = value;
			}
		}

		// Token: 0x1700543F RID: 21567
		// (get) Token: 0x06026CA2 RID: 158882 RVA: 0x0097E715 File Offset: 0x0097C915
		// (set) Token: 0x06026CA3 RID: 158883 RVA: 0x0097E729 File Offset: 0x0097C929
		[Nullable(2)]
		public unsafe UMaterialInstanceDynamic MI_CollisionPainterDot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveComponent_C.__PropertyOffset_108);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveComponent_C.__PropertyOffset_108, value);
			}
		}

		// Token: 0x17005440 RID: 21568
		// (get) Token: 0x06026CA4 RID: 158884 RVA: 0x0097E73E File Offset: 0x0097C93E
		// (set) Token: 0x06026CA5 RID: 158885 RVA: 0x0097E752 File Offset: 0x0097C952
		[Nullable(2)]
		public unsafe UMaterialInstanceDynamic MI_CollisionPainterLine
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveComponent_C.__PropertyOffset_109);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveComponent_C.__PropertyOffset_109, value);
			}
		}

		// Token: 0x17005441 RID: 21569
		// (get) Token: 0x06026CA6 RID: 158886 RVA: 0x0097E767 File Offset: 0x0097C967
		// (set) Token: 0x06026CA7 RID: 158887 RVA: 0x0097E77B File Offset: 0x0097C97B
		[Nullable(2)]
		public unsafe UMaterialInstanceDynamic MI_CollisionPainterOffset
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveComponent_C.__PropertyOffset_110);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveComponent_C.__PropertyOffset_110, value);
			}
		}

		// Token: 0x17005442 RID: 21570
		// (get) Token: 0x06026CA8 RID: 158888 RVA: 0x0097E790 File Offset: 0x0097C990
		// (set) Token: 0x06026CA9 RID: 158889 RVA: 0x0097E7A4 File Offset: 0x0097C9A4
		[Nullable(2)]
		public unsafe UMaterialInstanceDynamic MI_CompositeAndGradient
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveComponent_C.__PropertyOffset_111);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveComponent_C.__PropertyOffset_111, value);
			}
		}

		// Token: 0x17005443 RID: 21571
		// (get) Token: 0x06026CAA RID: 158890 RVA: 0x0097E7B9 File Offset: 0x0097C9B9
		// (set) Token: 0x06026CAB RID: 158891 RVA: 0x0097E7CD File Offset: 0x0097C9CD
		[Nullable(2)]
		public unsafe UMaterialInstanceDynamic MI_Output
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveComponent_C.__PropertyOffset_112);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveComponent_C.__PropertyOffset_112, value);
			}
		}

		// Token: 0x17005444 RID: 21572
		// (get) Token: 0x06026CAC RID: 158892 RVA: 0x0097E7E2 File Offset: 0x0097C9E2
		// (set) Token: 0x06026CAD RID: 158893 RVA: 0x0097E7F6 File Offset: 0x0097C9F6
		[Nullable(2)]
		public unsafe UMaterialInstanceDynamic MI_SecondaryOutput
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveComponent_C.__PropertyOffset_113);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveComponent_C.__PropertyOffset_113, value);
			}
		}

		// Token: 0x17005445 RID: 21573
		// (get) Token: 0x06026CAE RID: 158894 RVA: 0x0097E80B File Offset: 0x0097CA0B
		// (set) Token: 0x06026CAF RID: 158895 RVA: 0x0097E81F File Offset: 0x0097CA1F
		[Nullable(2)]
		public unsafe UMaterialInstanceDynamic MI_Null
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveComponent_C.__PropertyOffset_114);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveComponent_C.__PropertyOffset_114, value);
			}
		}

		// Token: 0x17005446 RID: 21574
		// (get) Token: 0x06026CB0 RID: 158896 RVA: 0x0097E834 File Offset: 0x0097CA34
		// (set) Token: 0x06026CB1 RID: 158897 RVA: 0x0097E848 File Offset: 0x0097CA48
		[Nullable(2)]
		public unsafe UMaterialInterface NullMaterial
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveComponent_C.__PropertyOffset_115);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveComponent_C.__PropertyOffset_115, value);
			}
		}

		// Token: 0x17005447 RID: 21575
		// (get) Token: 0x06026CB2 RID: 158898 RVA: 0x0097E85D File Offset: 0x0097CA5D
		// (set) Token: 0x06026CB3 RID: 158899 RVA: 0x0097E871 File Offset: 0x0097CA71
		public unsafe FName NullName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_116);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_116) = value;
			}
		}

		// Token: 0x17005448 RID: 21576
		// (get) Token: 0x06026CB4 RID: 158900 RVA: 0x0097E886 File Offset: 0x0097CA86
		// (set) Token: 0x06026CB5 RID: 158901 RVA: 0x0097E89A File Offset: 0x0097CA9A
		public unsafe string NullString
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)NinjaLiveComponent_C.__PropertyOffset_117)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)NinjaLiveComponent_C.__PropertyOffset_117)), value);
			}
		}

		// Token: 0x17005449 RID: 21577
		// (get) Token: 0x06026CB6 RID: 158902 RVA: 0x0097E8AF File Offset: 0x0097CAAF
		// (set) Token: 0x06026CB7 RID: 158903 RVA: 0x0097E8C3 File Offset: 0x0097CAC3
		[Nullable(2)]
		public unsafe UTexture2D VelocityInput
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveComponent_C.__PropertyOffset_118);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveComponent_C.__PropertyOffset_118, value);
			}
		}

		// Token: 0x1700544A RID: 21578
		// (get) Token: 0x06026CB8 RID: 158904 RVA: 0x0097E8D8 File Offset: 0x0097CAD8
		// (set) Token: 0x06026CB9 RID: 158905 RVA: 0x0097E8EC File Offset: 0x0097CAEC
		[Nullable(2)]
		public unsafe UTexture2D DensityInput
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveComponent_C.__PropertyOffset_119);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveComponent_C.__PropertyOffset_119, value);
			}
		}

		// Token: 0x1700544B RID: 21579
		// (get) Token: 0x06026CBA RID: 158906 RVA: 0x0097E901 File Offset: 0x0097CB01
		// (set) Token: 0x06026CBB RID: 158907 RVA: 0x0097E911 File Offset: 0x0097CB11
		public unsafe bool FlipRenderTargetsForMobile
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_120) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_120) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700544C RID: 21580
		// (get) Token: 0x06026CBC RID: 158908 RVA: 0x0097E922 File Offset: 0x0097CB22
		// (set) Token: 0x06026CBD RID: 158909 RVA: 0x0097E932 File Offset: 0x0097CB32
		public unsafe bool SelfService_IF_PoolEmpty
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_121) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_121) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700544D RID: 21581
		// (get) Token: 0x06026CBE RID: 158910 RVA: 0x0097E943 File Offset: 0x0097CB43
		// (set) Token: 0x06026CBF RID: 158911 RVA: 0x0097E957 File Offset: 0x0097CB57
		[Nullable(2)]
		public unsafe UBoxComponent ActivationVolume
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveComponent_C.__PropertyOffset_122);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveComponent_C.__PropertyOffset_122, value);
			}
		}

		// Token: 0x1700544E RID: 21582
		// (get) Token: 0x06026CC0 RID: 158912 RVA: 0x0097E96C File Offset: 0x0097CB6C
		// (set) Token: 0x06026CC1 RID: 158913 RVA: 0x0097E97C File Offset: 0x0097CB7C
		public unsafe bool AutonomousMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_123) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_123) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700544F RID: 21583
		// (get) Token: 0x06026CC2 RID: 158914 RVA: 0x0097E98D File Offset: 0x0097CB8D
		// (set) Token: 0x06026CC3 RID: 158915 RVA: 0x0097E99D File Offset: 0x0097CB9D
		public unsafe bool AbsPathForVelocityTemplate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_124) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_124) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005450 RID: 21584
		// (get) Token: 0x06026CC4 RID: 158916 RVA: 0x0097E9AE File Offset: 0x0097CBAE
		// (set) Token: 0x06026CC5 RID: 158917 RVA: 0x0097E9BE File Offset: 0x0097CBBE
		public unsafe bool AbsPathForDensityTemplate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_125) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_125) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005451 RID: 21585
		// (get) Token: 0x06026CC6 RID: 158918 RVA: 0x0097E9D0 File Offset: 0x0097CBD0
		// (set) Token: 0x06026CC7 RID: 158919 RVA: 0x0097EA09 File Offset: 0x0097CC09
		public TMap<int, UPrimitiveComponent> SkeletalMesh_TempArray_Pairs
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, UPrimitiveComponent> result;
				if ((result = this._SkeletalMesh_TempArray_Pairs) == null)
				{
					result = (this._SkeletalMesh_TempArray_Pairs = new TMap<int, UPrimitiveComponent>(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_126, this));
				}
				return result;
			}
			set
			{
				this.SkeletalMesh_TempArray_Pairs.CopyAssign(value);
			}
		}

		// Token: 0x17005452 RID: 21586
		// (get) Token: 0x06026CC8 RID: 158920 RVA: 0x0097EA18 File Offset: 0x0097CC18
		// (set) Token: 0x06026CC9 RID: 158921 RVA: 0x0097EA51 File Offset: 0x0097CC51
		public TArray<UPrimitiveComponent> OverlappingComponents
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UPrimitiveComponent> result;
				if ((result = this._OverlappingComponents) == null)
				{
					result = (this._OverlappingComponents = new TArray<UPrimitiveComponent>(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_127, this));
				}
				return result;
			}
			set
			{
				this.OverlappingComponents.CopyAssign(value);
			}
		}

		// Token: 0x17005453 RID: 21587
		// (get) Token: 0x06026CCA RID: 158922 RVA: 0x0097EA60 File Offset: 0x0097CC60
		// (set) Token: 0x06026CCB RID: 158923 RVA: 0x0097EA99 File Offset: 0x0097CC99
		public TArray<USkeletalMeshComponent> ContinuousInteractionSkeletalComponent
		{
			get
			{
				base.FastCheckIsValid();
				TArray<USkeletalMeshComponent> result;
				if ((result = this._ContinuousInteractionSkeletalComponent) == null)
				{
					result = (this._ContinuousInteractionSkeletalComponent = new TArray<USkeletalMeshComponent>(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_128, this));
				}
				return result;
			}
			set
			{
				this.ContinuousInteractionSkeletalComponent.CopyAssign(value);
			}
		}

		// Token: 0x17005454 RID: 21588
		// (get) Token: 0x06026CCC RID: 158924 RVA: 0x0097EAA8 File Offset: 0x0097CCA8
		// (set) Token: 0x06026CCD RID: 158925 RVA: 0x0097EAE1 File Offset: 0x0097CCE1
		public TArray<bool> ListOfAvailableTempArrays
		{
			get
			{
				base.FastCheckIsValid();
				TArray<bool> result;
				if ((result = this._ListOfAvailableTempArrays) == null)
				{
					result = (this._ListOfAvailableTempArrays = new TArray<bool>(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_129, this));
				}
				return result;
			}
			set
			{
				this.ListOfAvailableTempArrays.CopyAssign(value);
			}
		}

		// Token: 0x17005455 RID: 21589
		// (get) Token: 0x06026CCE RID: 158926 RVA: 0x0097EAEF File Offset: 0x0097CCEF
		// (set) Token: 0x06026CCF RID: 158927 RVA: 0x0097EB03 File Offset: 0x0097CD03
		[Nullable(2)]
		public unsafe UPrimitiveComponent OverlappingSkeletalMesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPrimitiveComponent>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveComponent_C.__PropertyOffset_130);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveComponent_C.__PropertyOffset_130, value);
			}
		}

		// Token: 0x17005456 RID: 21590
		// (get) Token: 0x06026CD0 RID: 158928 RVA: 0x0097EB18 File Offset: 0x0097CD18
		// (set) Token: 0x06026CD1 RID: 158929 RVA: 0x0097EB2C File Offset: 0x0097CD2C
		public unsafe FName OverlappingBone
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_131);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_131) = value;
			}
		}

		// Token: 0x17005457 RID: 21591
		// (get) Token: 0x06026CD2 RID: 158930 RVA: 0x0097EB41 File Offset: 0x0097CD41
		// (set) Token: 0x06026CD3 RID: 158931 RVA: 0x0097EB55 File Offset: 0x0097CD55
		public unsafe FVector Position1_3D
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_132);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_132) = value;
			}
		}

		// Token: 0x17005458 RID: 21592
		// (get) Token: 0x06026CD4 RID: 158932 RVA: 0x0097EB6A File Offset: 0x0097CD6A
		// (set) Token: 0x06026CD5 RID: 158933 RVA: 0x0097EB7E File Offset: 0x0097CD7E
		public unsafe FVector LastPosition1_3D
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_133);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_133) = value;
			}
		}

		// Token: 0x17005459 RID: 21593
		// (get) Token: 0x06026CD6 RID: 158934 RVA: 0x0097EB93 File Offset: 0x0097CD93
		// (set) Token: 0x06026CD7 RID: 158935 RVA: 0x0097EBA3 File Offset: 0x0097CDA3
		public unsafe float TraceMeshSizeCoeff
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_134);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_134) = value;
			}
		}

		// Token: 0x1700545A RID: 21594
		// (get) Token: 0x06026CD8 RID: 158936 RVA: 0x0097EBB4 File Offset: 0x0097CDB4
		// (set) Token: 0x06026CD9 RID: 158937 RVA: 0x0097EBC4 File Offset: 0x0097CDC4
		public unsafe float OverlappingMeshSizeCoeff
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_135);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_135) = value;
			}
		}

		// Token: 0x1700545B RID: 21595
		// (get) Token: 0x06026CDA RID: 158938 RVA: 0x0097EBD5 File Offset: 0x0097CDD5
		// (set) Token: 0x06026CDB RID: 158939 RVA: 0x0097EBE9 File Offset: 0x0097CDE9
		[Nullable(2)]
		public unsafe UPrimitiveComponent OverlappingComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPrimitiveComponent>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveComponent_C.__PropertyOffset_136);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveComponent_C.__PropertyOffset_136, value);
			}
		}

		// Token: 0x1700545C RID: 21596
		// (get) Token: 0x06026CDC RID: 158940 RVA: 0x0097EBFE File Offset: 0x0097CDFE
		// (set) Token: 0x06026CDD RID: 158941 RVA: 0x0097EC0E File Offset: 0x0097CE0E
		public unsafe int TouchLookupIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_137);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_137) = value;
			}
		}

		// Token: 0x1700545D RID: 21597
		// (get) Token: 0x06026CDE RID: 158942 RVA: 0x0097EC20 File Offset: 0x0097CE20
		// (set) Token: 0x06026CDF RID: 158943 RVA: 0x0097EC59 File Offset: 0x0097CE59
		public TArray<FLinearColor> LastPosition3_2D
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FLinearColor> result;
				if ((result = this._LastPosition3_2D) == null)
				{
					result = (this._LastPosition3_2D = new TArray<FLinearColor>(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_138, this));
				}
				return result;
			}
			set
			{
				this.LastPosition3_2D.CopyAssign(value);
			}
		}

		// Token: 0x1700545E RID: 21598
		// (get) Token: 0x06026CE0 RID: 158944 RVA: 0x0097EC67 File Offset: 0x0097CE67
		// (set) Token: 0x06026CE1 RID: 158945 RVA: 0x0097EC7B File Offset: 0x0097CE7B
		public unsafe FLinearColor LastPosition2_2D
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_139);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_139) = value;
			}
		}

		// Token: 0x1700545F RID: 21599
		// (get) Token: 0x06026CE2 RID: 158946 RVA: 0x0097EC90 File Offset: 0x0097CE90
		// (set) Token: 0x06026CE3 RID: 158947 RVA: 0x0097ECA0 File Offset: 0x0097CEA0
		public unsafe bool MousePass
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_140) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_140) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005460 RID: 21600
		// (get) Token: 0x06026CE4 RID: 158948 RVA: 0x0097ECB1 File Offset: 0x0097CEB1
		// (set) Token: 0x06026CE5 RID: 158949 RVA: 0x0097ECC5 File Offset: 0x0097CEC5
		public unsafe FLinearColor Position2_2D
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_141);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_141) = value;
			}
		}

		// Token: 0x17005461 RID: 21601
		// (get) Token: 0x06026CE6 RID: 158950 RVA: 0x0097ECDC File Offset: 0x0097CEDC
		// (set) Token: 0x06026CE7 RID: 158951 RVA: 0x0097ED15 File Offset: 0x0097CF15
		public TArray<FLinearColor> Position3_2D
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FLinearColor> result;
				if ((result = this._Position3_2D) == null)
				{
					result = (this._Position3_2D = new TArray<FLinearColor>(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_142, this));
				}
				return result;
			}
			set
			{
				this.Position3_2D.CopyAssign(value);
			}
		}

		// Token: 0x17005462 RID: 21602
		// (get) Token: 0x06026CE8 RID: 158952 RVA: 0x0097ED23 File Offset: 0x0097CF23
		// (set) Token: 0x06026CE9 RID: 158953 RVA: 0x0097ED33 File Offset: 0x0097CF33
		public unsafe int PosDataType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_143);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_143) = value;
			}
		}

		// Token: 0x17005463 RID: 21603
		// (get) Token: 0x06026CEA RID: 158954 RVA: 0x0097ED44 File Offset: 0x0097CF44
		// (set) Token: 0x06026CEB RID: 158955 RVA: 0x0097ED54 File Offset: 0x0097CF54
		public unsafe bool ShowVelocityDebugCone
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_144) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_144) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005464 RID: 21604
		// (get) Token: 0x06026CEC RID: 158956 RVA: 0x0097ED65 File Offset: 0x0097CF65
		// (set) Token: 0x06026CED RID: 158957 RVA: 0x0097ED75 File Offset: 0x0097CF75
		public unsafe bool IgnoreInterfaceCommands
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_145) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_145) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005465 RID: 21605
		// (get) Token: 0x06026CEE RID: 158958 RVA: 0x0097ED86 File Offset: 0x0097CF86
		// (set) Token: 0x06026CEF RID: 158959 RVA: 0x0097ED96 File Offset: 0x0097CF96
		public unsafe bool DisableAndNotTickBlock
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_146) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_146) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005466 RID: 21606
		// (get) Token: 0x06026CF0 RID: 158960 RVA: 0x0097EDA7 File Offset: 0x0097CFA7
		// (set) Token: 0x06026CF1 RID: 158961 RVA: 0x0097EDB7 File Offset: 0x0097CFB7
		public unsafe float InputFeedbackInterface
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_147);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_147) = value;
			}
		}

		// Token: 0x17005467 RID: 21607
		// (get) Token: 0x06026CF2 RID: 158962 RVA: 0x0097EDC8 File Offset: 0x0097CFC8
		// (set) Token: 0x06026CF3 RID: 158963 RVA: 0x0097EDD8 File Offset: 0x0097CFD8
		public unsafe float BrushStrengthTemp2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_148);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_148) = value;
			}
		}

		// Token: 0x17005468 RID: 21608
		// (get) Token: 0x06026CF4 RID: 158964 RVA: 0x0097EDE9 File Offset: 0x0097CFE9
		// (set) Token: 0x06026CF5 RID: 158965 RVA: 0x0097EDF9 File Offset: 0x0097CFF9
		public unsafe bool TickBlocker
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_149) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_149) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005469 RID: 21609
		// (get) Token: 0x06026CF6 RID: 158966 RVA: 0x0097EE0A File Offset: 0x0097D00A
		// (set) Token: 0x06026CF7 RID: 158967 RVA: 0x0097EE1A File Offset: 0x0097D01A
		public unsafe int FluidSolver1Iterations
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_150);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_150) = value;
			}
		}

		// Token: 0x1700546A RID: 21610
		// (get) Token: 0x06026CF8 RID: 158968 RVA: 0x0097EE2C File Offset: 0x0097D02C
		// (set) Token: 0x06026CF9 RID: 158969 RVA: 0x0097EE65 File Offset: 0x0097D065
		public TArray<AActor> NinjaLIVETraceExclude
		{
			get
			{
				base.FastCheckIsValid();
				TArray<AActor> result;
				if ((result = this._NinjaLIVETraceExclude) == null)
				{
					result = (this._NinjaLIVETraceExclude = new TArray<AActor>(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_151, this));
				}
				return result;
			}
			set
			{
				this.NinjaLIVETraceExclude.CopyAssign(value);
			}
		}

		// Token: 0x1700546B RID: 21611
		// (get) Token: 0x06026CFA RID: 158970 RVA: 0x0097EE73 File Offset: 0x0097D073
		// (set) Token: 0x06026CFB RID: 158971 RVA: 0x0097EE83 File Offset: 0x0097D083
		public unsafe float DeltaSeconds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_152);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_152) = value;
			}
		}

		// Token: 0x1700546C RID: 21612
		// (get) Token: 0x06026CFC RID: 158972 RVA: 0x0097EE94 File Offset: 0x0097D094
		// (set) Token: 0x06026CFD RID: 158973 RVA: 0x0097EEA4 File Offset: 0x0097D0A4
		public unsafe bool UseUnrealNativeEventTick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_153) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_153) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700546D RID: 21613
		// (get) Token: 0x06026CFE RID: 158974 RVA: 0x0097EEB5 File Offset: 0x0097D0B5
		// (set) Token: 0x06026CFF RID: 158975 RVA: 0x0097EEC5 File Offset: 0x0097D0C5
		public unsafe bool SingleInput
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_154) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_154) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700546E RID: 21614
		// (get) Token: 0x06026D00 RID: 158976 RVA: 0x0097EED6 File Offset: 0x0097D0D6
		// (set) Token: 0x06026D01 RID: 158977 RVA: 0x0097EEE6 File Offset: 0x0097D0E6
		public unsafe bool Touch
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_155) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_155) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700546F RID: 21615
		// (get) Token: 0x06026D02 RID: 158978 RVA: 0x0097EEF7 File Offset: 0x0097D0F7
		// (set) Token: 0x06026D03 RID: 158979 RVA: 0x0097EF07 File Offset: 0x0097D107
		public unsafe float LOD_CheckFrequency
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_156);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_156) = value;
			}
		}

		// Token: 0x17005470 RID: 21616
		// (get) Token: 0x06026D04 RID: 158980 RVA: 0x0097EF18 File Offset: 0x0097D118
		// (set) Token: 0x06026D05 RID: 158981 RVA: 0x0097EF28 File Offset: 0x0097D128
		public unsafe bool PauseSimWhenNotVisible
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_157) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_157) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005471 RID: 21617
		// (get) Token: 0x06026D06 RID: 158982 RVA: 0x0097EF39 File Offset: 0x0097D139
		// (set) Token: 0x06026D07 RID: 158983 RVA: 0x0097EF49 File Offset: 0x0097D149
		public unsafe float WaitBeforePause
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_158);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_158) = value;
			}
		}

		// Token: 0x17005472 RID: 21618
		// (get) Token: 0x06026D08 RID: 158984 RVA: 0x0097EF5A File Offset: 0x0097D15A
		// (set) Token: 0x06026D09 RID: 158985 RVA: 0x0097EF6A File Offset: 0x0097D16A
		public unsafe bool MousePressed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_159) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_159) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005473 RID: 21619
		// (get) Token: 0x06026D0A RID: 158986 RVA: 0x0097EF7B File Offset: 0x0097D17B
		// (set) Token: 0x06026D0B RID: 158987 RVA: 0x0097EF8B File Offset: 0x0097D18B
		public unsafe bool ContinuousInteractionWithOwnerActor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_160) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_160) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005474 RID: 21620
		// (get) Token: 0x06026D0C RID: 158988 RVA: 0x0097EF9C File Offset: 0x0097D19C
		// (set) Token: 0x06026D0D RID: 158989 RVA: 0x0097EFB0 File Offset: 0x0097D1B0
		public unsafe FLinearColor Position1_2D
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_161);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_161) = value;
			}
		}

		// Token: 0x17005475 RID: 21621
		// (get) Token: 0x06026D0E RID: 158990 RVA: 0x0097EFC5 File Offset: 0x0097D1C5
		// (set) Token: 0x06026D0F RID: 158991 RVA: 0x0097EFD5 File Offset: 0x0097D1D5
		public unsafe float TimeSinceLastClick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_162);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_162) = value;
			}
		}

		// Token: 0x17005476 RID: 21622
		// (get) Token: 0x06026D10 RID: 158992 RVA: 0x0097EFE6 File Offset: 0x0097D1E6
		// (set) Token: 0x06026D11 RID: 158993 RVA: 0x0097EFF6 File Offset: 0x0097D1F6
		public unsafe bool Position1_3D_Static
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_163) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_163) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005477 RID: 21623
		// (get) Token: 0x06026D12 RID: 158994 RVA: 0x0097F007 File Offset: 0x0097D207
		// (set) Token: 0x06026D13 RID: 158995 RVA: 0x0097F017 File Offset: 0x0097D217
		public unsafe float TimeSinceLastCollision
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_164);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_164) = value;
			}
		}

		// Token: 0x17005478 RID: 21624
		// (get) Token: 0x06026D14 RID: 158996 RVA: 0x0097F028 File Offset: 0x0097D228
		// (set) Token: 0x06026D15 RID: 158997 RVA: 0x0097F038 File Offset: 0x0097D238
		public unsafe float TimeCounter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_165);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_165) = value;
			}
		}

		// Token: 0x17005479 RID: 21625
		// (get) Token: 0x06026D16 RID: 158998 RVA: 0x0097F049 File Offset: 0x0097D249
		// (set) Token: 0x06026D17 RID: 158999 RVA: 0x0097F059 File Offset: 0x0097D259
		public unsafe bool Overlap1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_166) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_166) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700547A RID: 21626
		// (get) Token: 0x06026D18 RID: 159000 RVA: 0x0097F06C File Offset: 0x0097D26C
		// (set) Token: 0x06026D19 RID: 159001 RVA: 0x0097F0A5 File Offset: 0x0097D2A5
		public ComponentShutdownEvent ComponentShutdownEvent
		{
			get
			{
				base.FastCheckIsValid();
				ComponentShutdownEvent result;
				if ((result = this._ComponentShutdownEvent) == null)
				{
					result = (this._ComponentShutdownEvent = new ComponentShutdownEvent(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_167, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_167, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700547B RID: 21627
		// (get) Token: 0x06026D1A RID: 159002 RVA: 0x0097F0C8 File Offset: 0x0097D2C8
		// (set) Token: 0x06026D1B RID: 159003 RVA: 0x0097F101 File Offset: 0x0097D301
		[Nullable(new byte[]
		{
			1,
			0
		})]
		public TArray<TEnumAsByte<EObjectTypeQuery>> ContinuousInteractionInclusiveObjType
		{
			[return: Nullable(new byte[]
			{
				1,
				0
			})]
			get
			{
				base.FastCheckIsValid();
				TArray<TEnumAsByte<EObjectTypeQuery>> result;
				if ((result = this._ContinuousInteractionInclusiveObjType) == null)
				{
					result = (this._ContinuousInteractionInclusiveObjType = new TArray<TEnumAsByte<EObjectTypeQuery>>(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_168, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0
			})]
			set
			{
				this.ContinuousInteractionInclusiveObjType.CopyAssign(value);
			}
		}

		// Token: 0x1700547C RID: 21628
		// (get) Token: 0x06026D1C RID: 159004 RVA: 0x0097F110 File Offset: 0x0097D310
		// (set) Token: 0x06026D1D RID: 159005 RVA: 0x0097F149 File Offset: 0x0097D349
		public TArray<FName> ContinuousInteractionComponentNamesExact
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._ContinuousInteractionComponentNamesExact) == null)
				{
					result = (this._ContinuousInteractionComponentNamesExact = new TArray<FName>(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_169, this));
				}
				return result;
			}
			set
			{
				this.ContinuousInteractionComponentNamesExact.CopyAssign(value);
			}
		}

		// Token: 0x1700547D RID: 21629
		// (get) Token: 0x06026D1E RID: 159006 RVA: 0x0097F158 File Offset: 0x0097D358
		// (set) Token: 0x06026D1F RID: 159007 RVA: 0x0097F191 File Offset: 0x0097D391
		public TArray<FName> ContinuousInteractionBoneNamesExact
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._ContinuousInteractionBoneNamesExact) == null)
				{
					result = (this._ContinuousInteractionBoneNamesExact = new TArray<FName>(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_170, this));
				}
				return result;
			}
			set
			{
				this.ContinuousInteractionBoneNamesExact.CopyAssign(value);
			}
		}

		// Token: 0x1700547E RID: 21630
		// (get) Token: 0x06026D20 RID: 159008 RVA: 0x0097F19F File Offset: 0x0097D39F
		// (set) Token: 0x06026D21 RID: 159009 RVA: 0x0097F1AF File Offset: 0x0097D3AF
		public unsafe bool SingleTargetMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_171) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_171) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700547F RID: 21631
		// (get) Token: 0x06026D22 RID: 159010 RVA: 0x0097F1C0 File Offset: 0x0097D3C0
		// (set) Token: 0x06026D23 RID: 159011 RVA: 0x0097F1D4 File Offset: 0x0097D3D4
		[Nullable(0)]
		public unsafe TEnumAsByte<SingleObjectType_Enum> SingleTargetType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_172);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_172) = value;
			}
		}

		// Token: 0x17005480 RID: 21632
		// (get) Token: 0x06026D24 RID: 159012 RVA: 0x0097F1E9 File Offset: 0x0097D3E9
		// (set) Token: 0x06026D25 RID: 159013 RVA: 0x0097F1F9 File Offset: 0x0097D3F9
		public unsafe int SingleTargetModeSkeletalMeshIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_173);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_173) = value;
			}
		}

		// Token: 0x17005481 RID: 21633
		// (get) Token: 0x06026D26 RID: 159014 RVA: 0x0097F20A File Offset: 0x0097D40A
		// (set) Token: 0x06026D27 RID: 159015 RVA: 0x0097F21A File Offset: 0x0097D41A
		public unsafe bool SingleTargetMoveSetSimSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_174) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_174) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005482 RID: 21634
		// (get) Token: 0x06026D28 RID: 159016 RVA: 0x0097F22B File Offset: 0x0097D42B
		// (set) Token: 0x06026D29 RID: 159017 RVA: 0x0097F23B File Offset: 0x0097D43B
		public unsafe float SpeedInfluenceFactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_175);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_175) = value;
			}
		}

		// Token: 0x17005483 RID: 21635
		// (get) Token: 0x06026D2A RID: 159018 RVA: 0x0097F24C File Offset: 0x0097D44C
		// (set) Token: 0x06026D2B RID: 159019 RVA: 0x0097F25C File Offset: 0x0097D45C
		public unsafe float ClampMaxVelocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_176);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_176) = value;
			}
		}

		// Token: 0x17005484 RID: 21636
		// (get) Token: 0x06026D2C RID: 159020 RVA: 0x0097F26D File Offset: 0x0097D46D
		// (set) Token: 0x06026D2D RID: 159021 RVA: 0x0097F27D File Offset: 0x0097D47D
		public unsafe bool CameraFacingTraceMesh
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_177) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_177) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005485 RID: 21637
		// (get) Token: 0x06026D2E RID: 159022 RVA: 0x0097F28E File Offset: 0x0097D48E
		// (set) Token: 0x06026D2F RID: 159023 RVA: 0x0097F29E File Offset: 0x0097D49E
		public unsafe bool OverlapBasedInteraction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_178) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_178) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005486 RID: 21638
		// (get) Token: 0x06026D30 RID: 159024 RVA: 0x0097F2AF File Offset: 0x0097D4AF
		// (set) Token: 0x06026D31 RID: 159025 RVA: 0x0097F2C3 File Offset: 0x0097D4C3
		[Nullable(0)]
		public unsafe TEnumAsByte<UserInput_Enum> UserInputBasedInteraction
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_179);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_179) = value;
			}
		}

		// Token: 0x17005487 RID: 21639
		// (get) Token: 0x06026D32 RID: 159026 RVA: 0x0097F2D8 File Offset: 0x0097D4D8
		// (set) Token: 0x06026D33 RID: 159027 RVA: 0x0097F2E8 File Offset: 0x0097D4E8
		public unsafe bool BrushScaledInverselyByTraceMeshSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_180) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_180) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005488 RID: 21640
		// (get) Token: 0x06026D34 RID: 159028 RVA: 0x0097F2F9 File Offset: 0x0097D4F9
		// (set) Token: 0x06026D35 RID: 159029 RVA: 0x0097F309 File Offset: 0x0097D509
		public unsafe bool BrushScaledByInteractingObjSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_181) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_181) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005489 RID: 21641
		// (get) Token: 0x06026D36 RID: 159030 RVA: 0x0097F31A File Offset: 0x0097D51A
		// (set) Token: 0x06026D37 RID: 159031 RVA: 0x0097F32A File Offset: 0x0097D52A
		public unsafe bool BrushScaledByInteractingSkeletalSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_182) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_182) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700548A RID: 21642
		// (get) Token: 0x06026D38 RID: 159032 RVA: 0x0097F33B File Offset: 0x0097D53B
		// (set) Token: 0x06026D39 RID: 159033 RVA: 0x0097F34B File Offset: 0x0097D54B
		public unsafe bool UseObjBoundsInsteadOfSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_183) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_183) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700548B RID: 21643
		// (get) Token: 0x06026D3A RID: 159034 RVA: 0x0097F35C File Offset: 0x0097D55C
		// (set) Token: 0x06026D3B RID: 159035 RVA: 0x0097F36C File Offset: 0x0097D56C
		public unsafe float GlobalBrushScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_184);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_184) = value;
			}
		}

		// Token: 0x1700548C RID: 21644
		// (get) Token: 0x06026D3C RID: 159036 RVA: 0x0097F37D File Offset: 0x0097D57D
		// (set) Token: 0x06026D3D RID: 159037 RVA: 0x0097F38D File Offset: 0x0097D58D
		public unsafe float UserInputBrushScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_185);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_185) = value;
			}
		}

		// Token: 0x1700548D RID: 21645
		// (get) Token: 0x06026D3E RID: 159038 RVA: 0x0097F39E File Offset: 0x0097D59E
		// (set) Token: 0x06026D3F RID: 159039 RVA: 0x0097F3AE File Offset: 0x0097D5AE
		public unsafe float PrimitiveObjBrushScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_186);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_186) = value;
			}
		}

		// Token: 0x1700548E RID: 21646
		// (get) Token: 0x06026D40 RID: 159040 RVA: 0x0097F3BF File Offset: 0x0097D5BF
		// (set) Token: 0x06026D41 RID: 159041 RVA: 0x0097F3CF File Offset: 0x0097D5CF
		public unsafe float SkeletalMeshBrushScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_187);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_187) = value;
			}
		}

		// Token: 0x1700548F RID: 21647
		// (get) Token: 0x06026D42 RID: 159042 RVA: 0x0097F3E0 File Offset: 0x0097D5E0
		// (set) Token: 0x06026D43 RID: 159043 RVA: 0x0097F3F0 File Offset: 0x0097D5F0
		public unsafe bool CameraFacing_LockY_Axis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_188) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_188) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005490 RID: 21648
		// (get) Token: 0x06026D44 RID: 159044 RVA: 0x0097F401 File Offset: 0x0097D601
		// (set) Token: 0x06026D45 RID: 159045 RVA: 0x0097F411 File Offset: 0x0097D611
		public unsafe bool UseLegacyCameraFacing
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_189) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_189) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005491 RID: 21649
		// (get) Token: 0x06026D46 RID: 159046 RVA: 0x0097F422 File Offset: 0x0097D622
		// (set) Token: 0x06026D47 RID: 159047 RVA: 0x0097F432 File Offset: 0x0097D632
		public unsafe int TraceMeshTranslucentSortPrio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_190);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_190) = value;
			}
		}

		// Token: 0x17005492 RID: 21650
		// (get) Token: 0x06026D48 RID: 159048 RVA: 0x0097F443 File Offset: 0x0097D643
		// (set) Token: 0x06026D49 RID: 159049 RVA: 0x0097F453 File Offset: 0x0097D653
		public unsafe int TraceMeshQueryCounter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_191);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_191) = value;
			}
		}

		// Token: 0x17005493 RID: 21651
		// (get) Token: 0x06026D4A RID: 159050 RVA: 0x0097F464 File Offset: 0x0097D664
		// (set) Token: 0x06026D4B RID: 159051 RVA: 0x0097F474 File Offset: 0x0097D674
		public unsafe float LimitUnrealNativeEventTick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_192);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_192) = value;
			}
		}

		// Token: 0x17005494 RID: 21652
		// (get) Token: 0x06026D4C RID: 159052 RVA: 0x0097F485 File Offset: 0x0097D685
		// (set) Token: 0x06026D4D RID: 159053 RVA: 0x0097F495 File Offset: 0x0097D695
		public unsafe bool GlobalVeloTempCondition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_193) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_193) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005495 RID: 21653
		// (get) Token: 0x06026D4E RID: 159054 RVA: 0x0097F4A6 File Offset: 0x0097D6A6
		// (set) Token: 0x06026D4F RID: 159055 RVA: 0x0097F4BA File Offset: 0x0097D6BA
		public unsafe FVector TracePositionTemp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_194);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_194) = value;
			}
		}

		// Token: 0x17005496 RID: 21654
		// (get) Token: 0x06026D50 RID: 159056 RVA: 0x0097F4CF File Offset: 0x0097D6CF
		// (set) Token: 0x06026D51 RID: 159057 RVA: 0x0097F4E3 File Offset: 0x0097D6E3
		public unsafe FVector LastTracePositionTemp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_195);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_195) = value;
			}
		}

		// Token: 0x17005497 RID: 21655
		// (get) Token: 0x06026D52 RID: 159058 RVA: 0x0097F4F8 File Offset: 0x0097D6F8
		// (set) Token: 0x06026D53 RID: 159059 RVA: 0x0097F508 File Offset: 0x0097D708
		public unsafe float SimEdgeBouncyness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_196);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_196) = value;
			}
		}

		// Token: 0x17005498 RID: 21656
		// (get) Token: 0x06026D54 RID: 159060 RVA: 0x0097F519 File Offset: 0x0097D719
		// (set) Token: 0x06026D55 RID: 159061 RVA: 0x0097F529 File Offset: 0x0097D729
		public unsafe float FadeDensityAtSimEdge
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_197);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_197) = value;
			}
		}

		// Token: 0x17005499 RID: 21657
		// (get) Token: 0x06026D56 RID: 159062 RVA: 0x0097F53A File Offset: 0x0097D73A
		// (set) Token: 0x06026D57 RID: 159063 RVA: 0x0097F54A File Offset: 0x0097D74A
		public unsafe float EdgeMaskWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_198);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_198) = value;
			}
		}

		// Token: 0x1700549A RID: 21658
		// (get) Token: 0x06026D58 RID: 159064 RVA: 0x0097F55B File Offset: 0x0097D75B
		// (set) Token: 0x06026D59 RID: 159065 RVA: 0x0097F56B File Offset: 0x0097D76B
		public unsafe float VeloDirNoiseSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_199);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_199) = value;
			}
		}

		// Token: 0x1700549B RID: 21659
		// (get) Token: 0x06026D5A RID: 159066 RVA: 0x0097F57C File Offset: 0x0097D77C
		// (set) Token: 0x06026D5B RID: 159067 RVA: 0x0097F58C File Offset: 0x0097D78C
		public unsafe float VeloDirNoiseSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_200);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_200) = value;
			}
		}

		// Token: 0x1700549C RID: 21660
		// (get) Token: 0x06026D5C RID: 159068 RVA: 0x0097F59D File Offset: 0x0097D79D
		// (set) Token: 0x06026D5D RID: 159069 RVA: 0x0097F5AD File Offset: 0x0097D7AD
		public unsafe bool UseInputMaterials
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_201) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_201) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700549D RID: 21661
		// (get) Token: 0x06026D5E RID: 159070 RVA: 0x0097F5BE File Offset: 0x0097D7BE
		// (set) Token: 0x06026D5F RID: 159071 RVA: 0x0097F5CE File Offset: 0x0097D7CE
		public unsafe float DensityTxtScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_202);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_202) = value;
			}
		}

		// Token: 0x1700549E RID: 21662
		// (get) Token: 0x06026D60 RID: 159072 RVA: 0x0097F5DF File Offset: 0x0097D7DF
		// (set) Token: 0x06026D61 RID: 159073 RVA: 0x0097F5EF File Offset: 0x0097D7EF
		public unsafe float DensityTxtOffsetX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_203);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_203) = value;
			}
		}

		// Token: 0x1700549F RID: 21663
		// (get) Token: 0x06026D62 RID: 159074 RVA: 0x0097F600 File Offset: 0x0097D800
		// (set) Token: 0x06026D63 RID: 159075 RVA: 0x0097F610 File Offset: 0x0097D810
		public unsafe float DensityTxtOffsetY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_204);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_204) = value;
			}
		}

		// Token: 0x170054A0 RID: 21664
		// (get) Token: 0x06026D64 RID: 159076 RVA: 0x0097F621 File Offset: 0x0097D821
		// (set) Token: 0x06026D65 RID: 159077 RVA: 0x0097F631 File Offset: 0x0097D831
		public unsafe float BrushNoise
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_205);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_205) = value;
			}
		}

		// Token: 0x170054A1 RID: 21665
		// (get) Token: 0x06026D66 RID: 159078 RVA: 0x0097F642 File Offset: 0x0097D842
		// (set) Token: 0x06026D67 RID: 159079 RVA: 0x0097F652 File Offset: 0x0097D852
		public unsafe bool BrushNoiseInWorldSpace
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_206) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_206) = (value ? 1 : 0);
			}
		}

		// Token: 0x170054A2 RID: 21666
		// (get) Token: 0x06026D68 RID: 159080 RVA: 0x0097F663 File Offset: 0x0097D863
		// (set) Token: 0x06026D69 RID: 159081 RVA: 0x0097F673 File Offset: 0x0097D873
		public unsafe float BrushDensityNoiseScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_207);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_207) = value;
			}
		}

		// Token: 0x170054A3 RID: 21667
		// (get) Token: 0x06026D6A RID: 159082 RVA: 0x0097F684 File Offset: 0x0097D884
		// (set) Token: 0x06026D6B RID: 159083 RVA: 0x0097F694 File Offset: 0x0097D894
		public unsafe float BrushDensityNoiseFreq
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_208);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_208) = value;
			}
		}

		// Token: 0x170054A4 RID: 21668
		// (get) Token: 0x06026D6C RID: 159084 RVA: 0x0097F6A5 File Offset: 0x0097D8A5
		// (set) Token: 0x06026D6D RID: 159085 RVA: 0x0097F6B5 File Offset: 0x0097D8B5
		public unsafe float BrushVelocityNoiseScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_209);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_209) = value;
			}
		}

		// Token: 0x170054A5 RID: 21669
		// (get) Token: 0x06026D6E RID: 159086 RVA: 0x0097F6C6 File Offset: 0x0097D8C6
		// (set) Token: 0x06026D6F RID: 159087 RVA: 0x0097F6D6 File Offset: 0x0097D8D6
		public unsafe float BrushVelocityNoiseFreq
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_210);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_210) = value;
			}
		}

		// Token: 0x170054A6 RID: 21670
		// (get) Token: 0x06026D70 RID: 159088 RVA: 0x0097F6E7 File Offset: 0x0097D8E7
		// (set) Token: 0x06026D71 RID: 159089 RVA: 0x0097F6FB File Offset: 0x0097D8FB
		public unsafe FRotator TraceMeshInitialRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_211);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_211) = value;
			}
		}

		// Token: 0x170054A7 RID: 21671
		// (get) Token: 0x06026D72 RID: 159090 RVA: 0x0097F710 File Offset: 0x0097D910
		// (set) Token: 0x06026D73 RID: 159091 RVA: 0x0097F720 File Offset: 0x0097D920
		public unsafe float VeloInputTile
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_212);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_212) = value;
			}
		}

		// Token: 0x170054A8 RID: 21672
		// (get) Token: 0x06026D74 RID: 159092 RVA: 0x0097F731 File Offset: 0x0097D931
		// (set) Token: 0x06026D75 RID: 159093 RVA: 0x0097F741 File Offset: 0x0097D941
		public unsafe float VeloInputOffsetSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_213);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_213) = value;
			}
		}

		// Token: 0x170054A9 RID: 21673
		// (get) Token: 0x06026D76 RID: 159094 RVA: 0x0097F752 File Offset: 0x0097D952
		// (set) Token: 0x06026D77 RID: 159095 RVA: 0x0097F762 File Offset: 0x0097D962
		public unsafe float DensityTxtMult
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_214);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_214) = value;
			}
		}

		// Token: 0x170054AA RID: 21674
		// (get) Token: 0x06026D78 RID: 159096 RVA: 0x0097F773 File Offset: 0x0097D973
		// (set) Token: 0x06026D79 RID: 159097 RVA: 0x0097F783 File Offset: 0x0097D983
		public unsafe float DensityInputNoiseAmp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_215);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_215) = value;
			}
		}

		// Token: 0x170054AB RID: 21675
		// (get) Token: 0x06026D7A RID: 159098 RVA: 0x0097F794 File Offset: 0x0097D994
		// (set) Token: 0x06026D7B RID: 159099 RVA: 0x0097F7A4 File Offset: 0x0097D9A4
		public unsafe float DensityInputNoiseOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_216);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_216) = value;
			}
		}

		// Token: 0x170054AC RID: 21676
		// (get) Token: 0x06026D7C RID: 159100 RVA: 0x0097F7B5 File Offset: 0x0097D9B5
		// (set) Token: 0x06026D7D RID: 159101 RVA: 0x0097F7C5 File Offset: 0x0097D9C5
		public unsafe float DensityInputNoiseTile
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_217);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_217) = value;
			}
		}

		// Token: 0x170054AD RID: 21677
		// (get) Token: 0x06026D7E RID: 159102 RVA: 0x0097F7D6 File Offset: 0x0097D9D6
		// (set) Token: 0x06026D7F RID: 159103 RVA: 0x0097F7EA File Offset: 0x0097D9EA
		[Nullable(2)]
		public unsafe UMaterialParameterCollection SetInternalParamsToMaterialParamCollection
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialParameterCollection>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveComponent_C.__PropertyOffset_218);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveComponent_C.__PropertyOffset_218, value);
			}
		}

		// Token: 0x170054AE RID: 21678
		// (get) Token: 0x06026D80 RID: 159104 RVA: 0x0097F7FF File Offset: 0x0097D9FF
		// (set) Token: 0x06026D81 RID: 159105 RVA: 0x0097F80F File Offset: 0x0097DA0F
		public unsafe bool DrawInternalRenderTargetToExternal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_219) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_219) = (value ? 1 : 0);
			}
		}

		// Token: 0x170054AF RID: 21679
		// (get) Token: 0x06026D82 RID: 159106 RVA: 0x0097F820 File Offset: 0x0097DA20
		// (set) Token: 0x06026D83 RID: 159107 RVA: 0x0097F859 File Offset: 0x0097DA59
		[Nullable(new byte[]
		{
			1,
			0
		})]
		public TArray<TEnumAsByte<RenderTargetList>> InternalRenderTargetsToExport
		{
			[return: Nullable(new byte[]
			{
				1,
				0
			})]
			get
			{
				base.FastCheckIsValid();
				TArray<TEnumAsByte<RenderTargetList>> result;
				if ((result = this._InternalRenderTargetsToExport) == null)
				{
					result = (this._InternalRenderTargetsToExport = new TArray<TEnumAsByte<RenderTargetList>>(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_220, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0
			})]
			set
			{
				this.InternalRenderTargetsToExport.CopyAssign(value);
			}
		}

		// Token: 0x170054B0 RID: 21680
		// (get) Token: 0x06026D84 RID: 159108 RVA: 0x0097F868 File Offset: 0x0097DA68
		// (set) Token: 0x06026D85 RID: 159109 RVA: 0x0097F8A1 File Offset: 0x0097DAA1
		public TArray<UTextureRenderTarget2D> ExternalRenderTargets
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UTextureRenderTarget2D> result;
				if ((result = this._ExternalRenderTargets) == null)
				{
					result = (this._ExternalRenderTargets = new TArray<UTextureRenderTarget2D>(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_221, this));
				}
				return result;
			}
			set
			{
				this.ExternalRenderTargets.CopyAssign(value);
			}
		}

		// Token: 0x170054B1 RID: 21681
		// (get) Token: 0x06026D86 RID: 159110 RVA: 0x0097F8AF File Offset: 0x0097DAAF
		// (set) Token: 0x06026D87 RID: 159111 RVA: 0x0097F8C3 File Offset: 0x0097DAC3
		[Nullable(2)]
		public unsafe UTexture CollisionMask
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveComponent_C.__PropertyOffset_222);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveComponent_C.__PropertyOffset_222, value);
			}
		}

		// Token: 0x170054B2 RID: 21682
		// (get) Token: 0x06026D88 RID: 159112 RVA: 0x0097F8D8 File Offset: 0x0097DAD8
		// (set) Token: 0x06026D89 RID: 159113 RVA: 0x0097F8E8 File Offset: 0x0097DAE8
		public unsafe bool CollisionMaskIsNonDefault
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_223) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_223) = (value ? 1 : 0);
			}
		}

		// Token: 0x170054B3 RID: 21683
		// (get) Token: 0x06026D8A RID: 159114 RVA: 0x0097F8F9 File Offset: 0x0097DAF9
		// (set) Token: 0x06026D8B RID: 159115 RVA: 0x0097F90D File Offset: 0x0097DB0D
		[Nullable(2)]
		public unsafe ASceneCapture2D InputSceneCaptureCamera
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ASceneCapture2D>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveComponent_C.__PropertyOffset_224);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveComponent_C.__PropertyOffset_224, value);
			}
		}

		// Token: 0x170054B4 RID: 21684
		// (get) Token: 0x06026D8C RID: 159116 RVA: 0x0097F922 File Offset: 0x0097DB22
		// (set) Token: 0x06026D8D RID: 159117 RVA: 0x0097F936 File Offset: 0x0097DB36
		[Nullable(2)]
		public unsafe UMediaPlayer InputMediaPlayer
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMediaPlayer>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveComponent_C.__PropertyOffset_225);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveComponent_C.__PropertyOffset_225, value);
			}
		}

		// Token: 0x170054B5 RID: 21685
		// (get) Token: 0x06026D8E RID: 159118 RVA: 0x0097F94B File Offset: 0x0097DB4B
		// (set) Token: 0x06026D8F RID: 159119 RVA: 0x0097F95F File Offset: 0x0097DB5F
		[Nullable(2)]
		public unsafe UMediaTexture MediaTexture
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMediaTexture>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveComponent_C.__PropertyOffset_226);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveComponent_C.__PropertyOffset_226, value);
			}
		}

		// Token: 0x170054B6 RID: 21686
		// (get) Token: 0x06026D90 RID: 159120 RVA: 0x0097F974 File Offset: 0x0097DB74
		// (set) Token: 0x06026D91 RID: 159121 RVA: 0x0097F988 File Offset: 0x0097DB88
		[Nullable(2)]
		public unsafe UFileMediaSource InputMediaSource
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UFileMediaSource>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveComponent_C.__PropertyOffset_227);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveComponent_C.__PropertyOffset_227, value);
			}
		}

		// Token: 0x170054B7 RID: 21687
		// (get) Token: 0x06026D92 RID: 159122 RVA: 0x0097F99D File Offset: 0x0097DB9D
		// (set) Token: 0x06026D93 RID: 159123 RVA: 0x0097F9AD File Offset: 0x0097DBAD
		public unsafe float InputMediaLoopLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_228);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_228) = value;
			}
		}

		// Token: 0x170054B8 RID: 21688
		// (get) Token: 0x06026D94 RID: 159124 RVA: 0x0097F9BE File Offset: 0x0097DBBE
		// (set) Token: 0x06026D95 RID: 159125 RVA: 0x0097F9CE File Offset: 0x0097DBCE
		public unsafe bool RandomizeNoiseOffsets
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_229) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_229) = (value ? 1 : 0);
			}
		}

		// Token: 0x170054B9 RID: 21689
		// (get) Token: 0x06026D96 RID: 159126 RVA: 0x0097F9DF File Offset: 0x0097DBDF
		// (set) Token: 0x06026D97 RID: 159127 RVA: 0x0097F9EF File Offset: 0x0097DBEF
		public unsafe int OverlapCounter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_230);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_230) = value;
			}
		}

		// Token: 0x170054BA RID: 21690
		// (get) Token: 0x06026D98 RID: 159128 RVA: 0x0097FA00 File Offset: 0x0097DC00
		// (set) Token: 0x06026D99 RID: 159129 RVA: 0x0097FA10 File Offset: 0x0097DC10
		public unsafe bool RandomizeDensityTextureOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_231) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_231) = (value ? 1 : 0);
			}
		}

		// Token: 0x170054BB RID: 21691
		// (get) Token: 0x06026D9A RID: 159130 RVA: 0x0097FA21 File Offset: 0x0097DC21
		// (set) Token: 0x06026D9B RID: 159131 RVA: 0x0097FA35 File Offset: 0x0097DC35
		[Nullable(2)]
		public unsafe UTexture2D OverwritePresetDensityInput
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveComponent_C.__PropertyOffset_232);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveComponent_C.__PropertyOffset_232, value);
			}
		}

		// Token: 0x170054BC RID: 21692
		// (get) Token: 0x06026D9C RID: 159132 RVA: 0x0097FA4A File Offset: 0x0097DC4A
		// (set) Token: 0x06026D9D RID: 159133 RVA: 0x0097FA5E File Offset: 0x0097DC5E
		[Nullable(2)]
		public unsafe UTexture2D OverwritePresetVelocityInput
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveComponent_C.__PropertyOffset_233);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveComponent_C.__PropertyOffset_233, value);
			}
		}

		// Token: 0x170054BD RID: 21693
		// (get) Token: 0x06026D9E RID: 159134 RVA: 0x0097FA73 File Offset: 0x0097DC73
		// (set) Token: 0x06026D9F RID: 159135 RVA: 0x0097FA83 File Offset: 0x0097DC83
		public unsafe float BrushRnd
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_234);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_234) = value;
			}
		}

		// Token: 0x170054BE RID: 21694
		// (get) Token: 0x06026DA0 RID: 159136 RVA: 0x0097FA94 File Offset: 0x0097DC94
		// (set) Token: 0x06026DA1 RID: 159137 RVA: 0x0097FAA4 File Offset: 0x0097DCA4
		public unsafe float SimSpeedAdjustmentLatency
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_235);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_235) = value;
			}
		}

		// Token: 0x170054BF RID: 21695
		// (get) Token: 0x06026DA2 RID: 159138 RVA: 0x0097FAB5 File Offset: 0x0097DCB5
		// (set) Token: 0x06026DA3 RID: 159139 RVA: 0x0097FAC5 File Offset: 0x0097DCC5
		public unsafe float SpeedTemp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_236);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_236) = value;
			}
		}

		// Token: 0x170054C0 RID: 21696
		// (get) Token: 0x06026DA4 RID: 159140 RVA: 0x0097FAD6 File Offset: 0x0097DCD6
		// (set) Token: 0x06026DA5 RID: 159141 RVA: 0x0097FAE6 File Offset: 0x0097DCE6
		public unsafe bool StopUsingPainterCanvasWhenIdle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_237) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_237) = (value ? 1 : 0);
			}
		}

		// Token: 0x170054C1 RID: 21697
		// (get) Token: 0x06026DA6 RID: 159142 RVA: 0x0097FAF7 File Offset: 0x0097DCF7
		// (set) Token: 0x06026DA7 RID: 159143 RVA: 0x0097FB07 File Offset: 0x0097DD07
		public unsafe int Experimental_PSolver2KernelIndexOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_238);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_238) = value;
			}
		}

		// Token: 0x170054C2 RID: 21698
		// (get) Token: 0x06026DA8 RID: 159144 RVA: 0x0097FB18 File Offset: 0x0097DD18
		// (set) Token: 0x06026DA9 RID: 159145 RVA: 0x0097FB28 File Offset: 0x0097DD28
		public unsafe float Experimental_PressureFeedback
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_239);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_239) = value;
			}
		}

		// Token: 0x170054C3 RID: 21699
		// (get) Token: 0x06026DAA RID: 159146 RVA: 0x0097FB39 File Offset: 0x0097DD39
		// (set) Token: 0x06026DAB RID: 159147 RVA: 0x0097FB49 File Offset: 0x0097DD49
		public unsafe bool TraceMeshIsAlsoInteractionVolume
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_240) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_240) = (value ? 1 : 0);
			}
		}

		// Token: 0x170054C4 RID: 21700
		// (get) Token: 0x06026DAC RID: 159148 RVA: 0x0097FB5C File Offset: 0x0097DD5C
		// (set) Token: 0x06026DAD RID: 159149 RVA: 0x0097FB95 File Offset: 0x0097DD95
		public TArray<FName> TempArray0
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._TempArray0) == null)
				{
					result = (this._TempArray0 = new TArray<FName>(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_241, this));
				}
				return result;
			}
			set
			{
				this.TempArray0.CopyAssign(value);
			}
		}

		// Token: 0x170054C5 RID: 21701
		// (get) Token: 0x06026DAE RID: 159150 RVA: 0x0097FBA4 File Offset: 0x0097DDA4
		// (set) Token: 0x06026DAF RID: 159151 RVA: 0x0097FBDD File Offset: 0x0097DDDD
		public TArray<FName> TempArray1
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._TempArray1) == null)
				{
					result = (this._TempArray1 = new TArray<FName>(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_242, this));
				}
				return result;
			}
			set
			{
				this.TempArray1.CopyAssign(value);
			}
		}

		// Token: 0x170054C6 RID: 21702
		// (get) Token: 0x06026DB0 RID: 159152 RVA: 0x0097FBEC File Offset: 0x0097DDEC
		// (set) Token: 0x06026DB1 RID: 159153 RVA: 0x0097FC25 File Offset: 0x0097DE25
		public TArray<FName> TempArray2
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._TempArray2) == null)
				{
					result = (this._TempArray2 = new TArray<FName>(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_243, this));
				}
				return result;
			}
			set
			{
				this.TempArray2.CopyAssign(value);
			}
		}

		// Token: 0x170054C7 RID: 21703
		// (get) Token: 0x06026DB2 RID: 159154 RVA: 0x0097FC34 File Offset: 0x0097DE34
		// (set) Token: 0x06026DB3 RID: 159155 RVA: 0x0097FC6D File Offset: 0x0097DE6D
		public TArray<FName> TempArray3
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._TempArray3) == null)
				{
					result = (this._TempArray3 = new TArray<FName>(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_244, this));
				}
				return result;
			}
			set
			{
				this.TempArray3.CopyAssign(value);
			}
		}

		// Token: 0x170054C8 RID: 21704
		// (get) Token: 0x06026DB4 RID: 159156 RVA: 0x0097FC7C File Offset: 0x0097DE7C
		// (set) Token: 0x06026DB5 RID: 159157 RVA: 0x0097FCB5 File Offset: 0x0097DEB5
		public TArray<FName> TempArray4
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._TempArray4) == null)
				{
					result = (this._TempArray4 = new TArray<FName>(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_245, this));
				}
				return result;
			}
			set
			{
				this.TempArray4.CopyAssign(value);
			}
		}

		// Token: 0x170054C9 RID: 21705
		// (get) Token: 0x06026DB6 RID: 159158 RVA: 0x0097FCC4 File Offset: 0x0097DEC4
		// (set) Token: 0x06026DB7 RID: 159159 RVA: 0x0097FCFD File Offset: 0x0097DEFD
		public TArray<FName> TempArray5
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._TempArray5) == null)
				{
					result = (this._TempArray5 = new TArray<FName>(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_246, this));
				}
				return result;
			}
			set
			{
				this.TempArray5.CopyAssign(value);
			}
		}

		// Token: 0x170054CA RID: 21706
		// (get) Token: 0x06026DB8 RID: 159160 RVA: 0x0097FD0C File Offset: 0x0097DF0C
		// (set) Token: 0x06026DB9 RID: 159161 RVA: 0x0097FD45 File Offset: 0x0097DF45
		public TArray<FName> TempArray6
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._TempArray6) == null)
				{
					result = (this._TempArray6 = new TArray<FName>(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_247, this));
				}
				return result;
			}
			set
			{
				this.TempArray6.CopyAssign(value);
			}
		}

		// Token: 0x170054CB RID: 21707
		// (get) Token: 0x06026DBA RID: 159162 RVA: 0x0097FD54 File Offset: 0x0097DF54
		// (set) Token: 0x06026DBB RID: 159163 RVA: 0x0097FD8D File Offset: 0x0097DF8D
		public TArray<FName> TempArray7
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._TempArray7) == null)
				{
					result = (this._TempArray7 = new TArray<FName>(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_248, this));
				}
				return result;
			}
			set
			{
				this.TempArray7.CopyAssign(value);
			}
		}

		// Token: 0x170054CC RID: 21708
		// (get) Token: 0x06026DBC RID: 159164 RVA: 0x0097FD9C File Offset: 0x0097DF9C
		// (set) Token: 0x06026DBD RID: 159165 RVA: 0x0097FDD5 File Offset: 0x0097DFD5
		public TArray<FName> TempArray8
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._TempArray8) == null)
				{
					result = (this._TempArray8 = new TArray<FName>(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_249, this));
				}
				return result;
			}
			set
			{
				this.TempArray8.CopyAssign(value);
			}
		}

		// Token: 0x170054CD RID: 21709
		// (get) Token: 0x06026DBE RID: 159166 RVA: 0x0097FDE4 File Offset: 0x0097DFE4
		// (set) Token: 0x06026DBF RID: 159167 RVA: 0x0097FE1D File Offset: 0x0097E01D
		public TArray<FName> TempArray9
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._TempArray9) == null)
				{
					result = (this._TempArray9 = new TArray<FName>(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_250, this));
				}
				return result;
			}
			set
			{
				this.TempArray9.CopyAssign(value);
			}
		}

		// Token: 0x170054CE RID: 21710
		// (get) Token: 0x06026DC0 RID: 159168 RVA: 0x0097FE2C File Offset: 0x0097E02C
		// (set) Token: 0x06026DC1 RID: 159169 RVA: 0x0097FE65 File Offset: 0x0097E065
		public TArray<FName> TempArray10
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._TempArray10) == null)
				{
					result = (this._TempArray10 = new TArray<FName>(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_251, this));
				}
				return result;
			}
			set
			{
				this.TempArray10.CopyAssign(value);
			}
		}

		// Token: 0x170054CF RID: 21711
		// (get) Token: 0x06026DC2 RID: 159170 RVA: 0x0097FE74 File Offset: 0x0097E074
		// (set) Token: 0x06026DC3 RID: 159171 RVA: 0x0097FEAD File Offset: 0x0097E0AD
		public TArray<FName> TempArray11
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._TempArray11) == null)
				{
					result = (this._TempArray11 = new TArray<FName>(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_252, this));
				}
				return result;
			}
			set
			{
				this.TempArray11.CopyAssign(value);
			}
		}

		// Token: 0x170054D0 RID: 21712
		// (get) Token: 0x06026DC4 RID: 159172 RVA: 0x0097FEBC File Offset: 0x0097E0BC
		// (set) Token: 0x06026DC5 RID: 159173 RVA: 0x0097FEF5 File Offset: 0x0097E0F5
		public TArray<FName> TempArray12
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._TempArray12) == null)
				{
					result = (this._TempArray12 = new TArray<FName>(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_253, this));
				}
				return result;
			}
			set
			{
				this.TempArray12.CopyAssign(value);
			}
		}

		// Token: 0x170054D1 RID: 21713
		// (get) Token: 0x06026DC6 RID: 159174 RVA: 0x0097FF04 File Offset: 0x0097E104
		// (set) Token: 0x06026DC7 RID: 159175 RVA: 0x0097FF3D File Offset: 0x0097E13D
		public TArray<FName> TempArray13
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._TempArray13) == null)
				{
					result = (this._TempArray13 = new TArray<FName>(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_254, this));
				}
				return result;
			}
			set
			{
				this.TempArray13.CopyAssign(value);
			}
		}

		// Token: 0x170054D2 RID: 21714
		// (get) Token: 0x06026DC8 RID: 159176 RVA: 0x0097FF4C File Offset: 0x0097E14C
		// (set) Token: 0x06026DC9 RID: 159177 RVA: 0x0097FF85 File Offset: 0x0097E185
		public TArray<FName> TempArray14
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._TempArray14) == null)
				{
					result = (this._TempArray14 = new TArray<FName>(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_255, this));
				}
				return result;
			}
			set
			{
				this.TempArray14.CopyAssign(value);
			}
		}

		// Token: 0x170054D3 RID: 21715
		// (get) Token: 0x06026DCA RID: 159178 RVA: 0x0097FF94 File Offset: 0x0097E194
		// (set) Token: 0x06026DCB RID: 159179 RVA: 0x0097FFCD File Offset: 0x0097E1CD
		public TArray<FName> TempArray15
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._TempArray15) == null)
				{
					result = (this._TempArray15 = new TArray<FName>(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_256, this));
				}
				return result;
			}
			set
			{
				this.TempArray15.CopyAssign(value);
			}
		}

		// Token: 0x170054D4 RID: 21716
		// (get) Token: 0x06026DCC RID: 159180 RVA: 0x0097FFDC File Offset: 0x0097E1DC
		// (set) Token: 0x06026DCD RID: 159181 RVA: 0x00980015 File Offset: 0x0097E215
		public TArray<FName> TempArray16
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._TempArray16) == null)
				{
					result = (this._TempArray16 = new TArray<FName>(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_257, this));
				}
				return result;
			}
			set
			{
				this.TempArray16.CopyAssign(value);
			}
		}

		// Token: 0x170054D5 RID: 21717
		// (get) Token: 0x06026DCE RID: 159182 RVA: 0x00980024 File Offset: 0x0097E224
		// (set) Token: 0x06026DCF RID: 159183 RVA: 0x0098005D File Offset: 0x0097E25D
		public TArray<FName> TempArray17
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._TempArray17) == null)
				{
					result = (this._TempArray17 = new TArray<FName>(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_258, this));
				}
				return result;
			}
			set
			{
				this.TempArray17.CopyAssign(value);
			}
		}

		// Token: 0x170054D6 RID: 21718
		// (get) Token: 0x06026DD0 RID: 159184 RVA: 0x0098006C File Offset: 0x0097E26C
		// (set) Token: 0x06026DD1 RID: 159185 RVA: 0x009800A5 File Offset: 0x0097E2A5
		public TArray<FName> TempArray18
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._TempArray18) == null)
				{
					result = (this._TempArray18 = new TArray<FName>(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_259, this));
				}
				return result;
			}
			set
			{
				this.TempArray18.CopyAssign(value);
			}
		}

		// Token: 0x170054D7 RID: 21719
		// (get) Token: 0x06026DD2 RID: 159186 RVA: 0x009800B4 File Offset: 0x0097E2B4
		// (set) Token: 0x06026DD3 RID: 159187 RVA: 0x009800ED File Offset: 0x0097E2ED
		public TArray<FName> TempArray19
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._TempArray19) == null)
				{
					result = (this._TempArray19 = new TArray<FName>(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_260, this));
				}
				return result;
			}
			set
			{
				this.TempArray19.CopyAssign(value);
			}
		}

		// Token: 0x170054D8 RID: 21720
		// (get) Token: 0x06026DD4 RID: 159188 RVA: 0x009800FC File Offset: 0x0097E2FC
		// (set) Token: 0x06026DD5 RID: 159189 RVA: 0x00980135 File Offset: 0x0097E335
		public TArray<FName> TempArray20
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._TempArray20) == null)
				{
					result = (this._TempArray20 = new TArray<FName>(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_261, this));
				}
				return result;
			}
			set
			{
				this.TempArray20.CopyAssign(value);
			}
		}

		// Token: 0x170054D9 RID: 21721
		// (get) Token: 0x06026DD6 RID: 159190 RVA: 0x00980143 File Offset: 0x0097E343
		// (set) Token: 0x06026DD7 RID: 159191 RVA: 0x00980153 File Offset: 0x0097E353
		public unsafe bool UseCustomTraceSource
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_262) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_262) = (value ? 1 : 0);
			}
		}

		// Token: 0x170054DA RID: 21722
		// (get) Token: 0x06026DD8 RID: 159192 RVA: 0x00980164 File Offset: 0x0097E364
		// (set) Token: 0x06026DD9 RID: 159193 RVA: 0x00980178 File Offset: 0x0097E378
		public unsafe FVector CustomTraceSourcePosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_263);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_263) = value;
			}
		}

		// Token: 0x170054DB RID: 21723
		// (get) Token: 0x06026DDA RID: 159194 RVA: 0x00980190 File Offset: 0x0097E390
		// (set) Token: 0x06026DDB RID: 159195 RVA: 0x009801C9 File Offset: 0x0097E3C9
		public TArray<FName> TempArray21
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._TempArray21) == null)
				{
					result = (this._TempArray21 = new TArray<FName>(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_264, this));
				}
				return result;
			}
			set
			{
				this.TempArray21.CopyAssign(value);
			}
		}

		// Token: 0x170054DC RID: 21724
		// (get) Token: 0x06026DDC RID: 159196 RVA: 0x009801D8 File Offset: 0x0097E3D8
		// (set) Token: 0x06026DDD RID: 159197 RVA: 0x00980211 File Offset: 0x0097E411
		public TArray<FName> TempArray22
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._TempArray22) == null)
				{
					result = (this._TempArray22 = new TArray<FName>(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_265, this));
				}
				return result;
			}
			set
			{
				this.TempArray22.CopyAssign(value);
			}
		}

		// Token: 0x170054DD RID: 21725
		// (get) Token: 0x06026DDE RID: 159198 RVA: 0x00980220 File Offset: 0x0097E420
		// (set) Token: 0x06026DDF RID: 159199 RVA: 0x00980259 File Offset: 0x0097E459
		public TArray<FName> TempArray23
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._TempArray23) == null)
				{
					result = (this._TempArray23 = new TArray<FName>(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_266, this));
				}
				return result;
			}
			set
			{
				this.TempArray23.CopyAssign(value);
			}
		}

		// Token: 0x170054DE RID: 21726
		// (get) Token: 0x06026DE0 RID: 159200 RVA: 0x00980268 File Offset: 0x0097E468
		// (set) Token: 0x06026DE1 RID: 159201 RVA: 0x009802A1 File Offset: 0x0097E4A1
		public TArray<FName> TempArray24
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._TempArray24) == null)
				{
					result = (this._TempArray24 = new TArray<FName>(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_267, this));
				}
				return result;
			}
			set
			{
				this.TempArray24.CopyAssign(value);
			}
		}

		// Token: 0x170054DF RID: 21727
		// (get) Token: 0x06026DE2 RID: 159202 RVA: 0x009802B0 File Offset: 0x0097E4B0
		// (set) Token: 0x06026DE3 RID: 159203 RVA: 0x009802E9 File Offset: 0x0097E4E9
		public TArray<FName> TempArray25
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._TempArray25) == null)
				{
					result = (this._TempArray25 = new TArray<FName>(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_268, this));
				}
				return result;
			}
			set
			{
				this.TempArray25.CopyAssign(value);
			}
		}

		// Token: 0x170054E0 RID: 21728
		// (get) Token: 0x06026DE4 RID: 159204 RVA: 0x009802F8 File Offset: 0x0097E4F8
		// (set) Token: 0x06026DE5 RID: 159205 RVA: 0x00980331 File Offset: 0x0097E531
		public TArray<FName> TempArray26
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._TempArray26) == null)
				{
					result = (this._TempArray26 = new TArray<FName>(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_269, this));
				}
				return result;
			}
			set
			{
				this.TempArray26.CopyAssign(value);
			}
		}

		// Token: 0x170054E1 RID: 21729
		// (get) Token: 0x06026DE6 RID: 159206 RVA: 0x00980340 File Offset: 0x0097E540
		// (set) Token: 0x06026DE7 RID: 159207 RVA: 0x00980379 File Offset: 0x0097E579
		public TArray<FName> TempArray27
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._TempArray27) == null)
				{
					result = (this._TempArray27 = new TArray<FName>(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_270, this));
				}
				return result;
			}
			set
			{
				this.TempArray27.CopyAssign(value);
			}
		}

		// Token: 0x170054E2 RID: 21730
		// (get) Token: 0x06026DE8 RID: 159208 RVA: 0x00980388 File Offset: 0x0097E588
		// (set) Token: 0x06026DE9 RID: 159209 RVA: 0x009803C1 File Offset: 0x0097E5C1
		public TArray<FName> TempArray28
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._TempArray28) == null)
				{
					result = (this._TempArray28 = new TArray<FName>(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_271, this));
				}
				return result;
			}
			set
			{
				this.TempArray28.CopyAssign(value);
			}
		}

		// Token: 0x170054E3 RID: 21731
		// (get) Token: 0x06026DEA RID: 159210 RVA: 0x009803D0 File Offset: 0x0097E5D0
		// (set) Token: 0x06026DEB RID: 159211 RVA: 0x00980409 File Offset: 0x0097E609
		public TArray<FName> TempArray29
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._TempArray29) == null)
				{
					result = (this._TempArray29 = new TArray<FName>(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_272, this));
				}
				return result;
			}
			set
			{
				this.TempArray29.CopyAssign(value);
			}
		}

		// Token: 0x170054E4 RID: 21732
		// (get) Token: 0x06026DEC RID: 159212 RVA: 0x00980418 File Offset: 0x0097E618
		// (set) Token: 0x06026DED RID: 159213 RVA: 0x00980451 File Offset: 0x0097E651
		public TArray<FName> TempArray30
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._TempArray30) == null)
				{
					result = (this._TempArray30 = new TArray<FName>(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_273, this));
				}
				return result;
			}
			set
			{
				this.TempArray30.CopyAssign(value);
			}
		}

		// Token: 0x170054E5 RID: 21733
		// (get) Token: 0x06026DEE RID: 159214 RVA: 0x00980460 File Offset: 0x0097E660
		// (set) Token: 0x06026DEF RID: 159215 RVA: 0x00980499 File Offset: 0x0097E699
		public TArray<FName> TempArray31
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._TempArray31) == null)
				{
					result = (this._TempArray31 = new TArray<FName>(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_274, this));
				}
				return result;
			}
			set
			{
				this.TempArray31.CopyAssign(value);
			}
		}

		// Token: 0x170054E6 RID: 21734
		// (get) Token: 0x06026DF0 RID: 159216 RVA: 0x009804A8 File Offset: 0x0097E6A8
		// (set) Token: 0x06026DF1 RID: 159217 RVA: 0x009804E1 File Offset: 0x0097E6E1
		public TArray<FName> TempArray32
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._TempArray32) == null)
				{
					result = (this._TempArray32 = new TArray<FName>(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_275, this));
				}
				return result;
			}
			set
			{
				this.TempArray32.CopyAssign(value);
			}
		}

		// Token: 0x170054E7 RID: 21735
		// (get) Token: 0x06026DF2 RID: 159218 RVA: 0x009804F0 File Offset: 0x0097E6F0
		// (set) Token: 0x06026DF3 RID: 159219 RVA: 0x00980529 File Offset: 0x0097E729
		public TArray<FName> TempArray33
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._TempArray33) == null)
				{
					result = (this._TempArray33 = new TArray<FName>(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_276, this));
				}
				return result;
			}
			set
			{
				this.TempArray33.CopyAssign(value);
			}
		}

		// Token: 0x170054E8 RID: 21736
		// (get) Token: 0x06026DF4 RID: 159220 RVA: 0x00980538 File Offset: 0x0097E738
		// (set) Token: 0x06026DF5 RID: 159221 RVA: 0x00980571 File Offset: 0x0097E771
		public TArray<FName> TempArray34
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._TempArray34) == null)
				{
					result = (this._TempArray34 = new TArray<FName>(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_277, this));
				}
				return result;
			}
			set
			{
				this.TempArray34.CopyAssign(value);
			}
		}

		// Token: 0x170054E9 RID: 21737
		// (get) Token: 0x06026DF6 RID: 159222 RVA: 0x00980580 File Offset: 0x0097E780
		// (set) Token: 0x06026DF7 RID: 159223 RVA: 0x009805B9 File Offset: 0x0097E7B9
		public TArray<FName> TempArray35
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._TempArray35) == null)
				{
					result = (this._TempArray35 = new TArray<FName>(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_278, this));
				}
				return result;
			}
			set
			{
				this.TempArray35.CopyAssign(value);
			}
		}

		// Token: 0x170054EA RID: 21738
		// (get) Token: 0x06026DF8 RID: 159224 RVA: 0x009805C8 File Offset: 0x0097E7C8
		// (set) Token: 0x06026DF9 RID: 159225 RVA: 0x00980601 File Offset: 0x0097E801
		public TArray<FName> TempArray36
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._TempArray36) == null)
				{
					result = (this._TempArray36 = new TArray<FName>(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_279, this));
				}
				return result;
			}
			set
			{
				this.TempArray36.CopyAssign(value);
			}
		}

		// Token: 0x170054EB RID: 21739
		// (get) Token: 0x06026DFA RID: 159226 RVA: 0x00980610 File Offset: 0x0097E810
		// (set) Token: 0x06026DFB RID: 159227 RVA: 0x00980649 File Offset: 0x0097E849
		public TArray<FName> TempArray37
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._TempArray37) == null)
				{
					result = (this._TempArray37 = new TArray<FName>(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_280, this));
				}
				return result;
			}
			set
			{
				this.TempArray37.CopyAssign(value);
			}
		}

		// Token: 0x170054EC RID: 21740
		// (get) Token: 0x06026DFC RID: 159228 RVA: 0x00980658 File Offset: 0x0097E858
		// (set) Token: 0x06026DFD RID: 159229 RVA: 0x00980691 File Offset: 0x0097E891
		public TArray<FName> TempArray38
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._TempArray38) == null)
				{
					result = (this._TempArray38 = new TArray<FName>(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_281, this));
				}
				return result;
			}
			set
			{
				this.TempArray38.CopyAssign(value);
			}
		}

		// Token: 0x170054ED RID: 21741
		// (get) Token: 0x06026DFE RID: 159230 RVA: 0x009806A0 File Offset: 0x0097E8A0
		// (set) Token: 0x06026DFF RID: 159231 RVA: 0x009806D9 File Offset: 0x0097E8D9
		public TArray<FName> TempArray39
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._TempArray39) == null)
				{
					result = (this._TempArray39 = new TArray<FName>(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_282, this));
				}
				return result;
			}
			set
			{
				this.TempArray39.CopyAssign(value);
			}
		}

		// Token: 0x170054EE RID: 21742
		// (get) Token: 0x06026E00 RID: 159232 RVA: 0x009806E7 File Offset: 0x0097E8E7
		// (set) Token: 0x06026E01 RID: 159233 RVA: 0x009806F7 File Offset: 0x0097E8F7
		public unsafe float DampenBrushBelowThisVelocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_283);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_283) = value;
			}
		}

		// Token: 0x170054EF RID: 21743
		// (get) Token: 0x06026E02 RID: 159234 RVA: 0x00980708 File Offset: 0x0097E908
		// (set) Token: 0x06026E03 RID: 159235 RVA: 0x00980718 File Offset: 0x0097E918
		public unsafe bool DampenIgnoresStaticMeshes
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_284) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_284) = (value ? 1 : 0);
			}
		}

		// Token: 0x170054F0 RID: 21744
		// (get) Token: 0x06026E04 RID: 159236 RVA: 0x00980729 File Offset: 0x0097E929
		// (set) Token: 0x06026E05 RID: 159237 RVA: 0x00980739 File Offset: 0x0097E939
		public unsafe float DampenBrushFactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_285);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_285) = value;
			}
		}

		// Token: 0x170054F1 RID: 21745
		// (get) Token: 0x06026E06 RID: 159238 RVA: 0x0098074A File Offset: 0x0097E94A
		// (set) Token: 0x06026E07 RID: 159239 RVA: 0x0098075A File Offset: 0x0097E95A
		public unsafe float BrushVelocityPow
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_286);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_286) = value;
			}
		}

		// Token: 0x170054F2 RID: 21746
		// (get) Token: 0x06026E08 RID: 159240 RVA: 0x0098076B File Offset: 0x0097E96B
		// (set) Token: 0x06026E09 RID: 159241 RVA: 0x0098077B File Offset: 0x0097E97B
		public unsafe float SimAreaMotionEffectsBrushPuncture
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_287);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_287) = value;
			}
		}

		// Token: 0x170054F3 RID: 21747
		// (get) Token: 0x06026E0A RID: 159242 RVA: 0x0098078C File Offset: 0x0097E98C
		// (set) Token: 0x06026E0B RID: 159243 RVA: 0x0098079C File Offset: 0x0097E99C
		public unsafe int LODlevel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_288);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_288) = value;
			}
		}

		// Token: 0x170054F4 RID: 21748
		// (get) Token: 0x06026E0C RID: 159244 RVA: 0x009807AD File Offset: 0x0097E9AD
		// (set) Token: 0x06026E0D RID: 159245 RVA: 0x009807BD File Offset: 0x0097E9BD
		public unsafe bool AllowAbsoluteBlackDensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_289) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_289) = (value ? 1 : 0);
			}
		}

		// Token: 0x170054F5 RID: 21749
		// (get) Token: 0x06026E0E RID: 159246 RVA: 0x009807CE File Offset: 0x0097E9CE
		// (set) Token: 0x06026E0F RID: 159247 RVA: 0x009807E2 File Offset: 0x0097E9E2
		public unsafe FVector TraceMeshPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_290);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_290) = value;
			}
		}

		// Token: 0x170054F6 RID: 21750
		// (get) Token: 0x06026E10 RID: 159248 RVA: 0x009807F7 File Offset: 0x0097E9F7
		// (set) Token: 0x06026E11 RID: 159249 RVA: 0x0098080B File Offset: 0x0097EA0B
		public unsafe FVector TraceMeshLastPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_291);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_291) = value;
			}
		}

		// Token: 0x170054F7 RID: 21751
		// (get) Token: 0x06026E12 RID: 159250 RVA: 0x00980820 File Offset: 0x0097EA20
		// (set) Token: 0x06026E13 RID: 159251 RVA: 0x00980830 File Offset: 0x0097EA30
		public unsafe float PressureEdgeMasking
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_292);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_292) = value;
			}
		}

		// Token: 0x170054F8 RID: 21752
		// (get) Token: 0x06026E14 RID: 159252 RVA: 0x00980844 File Offset: 0x0097EA44
		// (set) Token: 0x06026E15 RID: 159253 RVA: 0x0098087D File Offset: 0x0097EA7D
		public TArray<UMaterialInterface> CoreSimMaterials
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInterface> result;
				if ((result = this._CoreSimMaterials) == null)
				{
					result = (this._CoreSimMaterials = new TArray<UMaterialInterface>(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_293, this));
				}
				return result;
			}
			set
			{
				this.CoreSimMaterials.CopyAssign(value);
			}
		}

		// Token: 0x170054F9 RID: 21753
		// (get) Token: 0x06026E16 RID: 159254 RVA: 0x0098088B File Offset: 0x0097EA8B
		// (set) Token: 0x06026E17 RID: 159255 RVA: 0x0098089F File Offset: 0x0097EA9F
		public unsafe FVector TraceMeshDeltaPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_294);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_294) = value;
			}
		}

		// Token: 0x170054FA RID: 21754
		// (get) Token: 0x06026E18 RID: 159256 RVA: 0x009808B4 File Offset: 0x0097EAB4
		// (set) Token: 0x06026E19 RID: 159257 RVA: 0x009808C8 File Offset: 0x0097EAC8
		public unsafe FVector NullVector
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_295);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_295) = value;
			}
		}

		// Token: 0x170054FB RID: 21755
		// (get) Token: 0x06026E1A RID: 159258 RVA: 0x009808DD File Offset: 0x0097EADD
		// (set) Token: 0x06026E1B RID: 159259 RVA: 0x009808F1 File Offset: 0x0097EAF1
		public unsafe FVector TraceMeshPosInitialLocal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_296);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_296) = value;
			}
		}

		// Token: 0x170054FC RID: 21756
		// (get) Token: 0x06026E1C RID: 159260 RVA: 0x00980906 File Offset: 0x0097EB06
		// (set) Token: 0x06026E1D RID: 159261 RVA: 0x0098091A File Offset: 0x0097EB1A
		public unsafe FVector TraceMeshPosInitialFractionalPart
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_297);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_297) = value;
			}
		}

		// Token: 0x170054FD RID: 21757
		// (get) Token: 0x06026E1E RID: 159262 RVA: 0x0098092F File Offset: 0x0097EB2F
		// (set) Token: 0x06026E1F RID: 159263 RVA: 0x00980943 File Offset: 0x0097EB43
		public unsafe FVector TraceMeshPosInitialWorld
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_298);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_298) = value;
			}
		}

		// Token: 0x170054FE RID: 21758
		// (get) Token: 0x06026E20 RID: 159264 RVA: 0x00980958 File Offset: 0x0097EB58
		// (set) Token: 0x06026E21 RID: 159265 RVA: 0x00980968 File Offset: 0x0097EB68
		public unsafe int QuantizerStepSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_299);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_299) = value;
			}
		}

		// Token: 0x170054FF RID: 21759
		// (get) Token: 0x06026E22 RID: 159266 RVA: 0x00980979 File Offset: 0x0097EB79
		// (set) Token: 0x06026E23 RID: 159267 RVA: 0x0098098D File Offset: 0x0097EB8D
		public unsafe FVector TraceMeshParentPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_300);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_300) = value;
			}
		}

		// Token: 0x17005500 RID: 21760
		// (get) Token: 0x06026E24 RID: 159268 RVA: 0x009809A2 File Offset: 0x0097EBA2
		// (set) Token: 0x06026E25 RID: 159269 RVA: 0x009809B6 File Offset: 0x0097EBB6
		public unsafe FVector TraceMeshParentLastPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_301);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_301) = value;
			}
		}

		// Token: 0x17005501 RID: 21761
		// (get) Token: 0x06026E26 RID: 159270 RVA: 0x009809CB File Offset: 0x0097EBCB
		// (set) Token: 0x06026E27 RID: 159271 RVA: 0x009809DF File Offset: 0x0097EBDF
		[Nullable(0)]
		public unsafe TEnumAsByte<QuantizerMode> TraceMeshMovingInWorldSpace
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_302);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_302) = value;
			}
		}

		// Token: 0x17005502 RID: 21762
		// (get) Token: 0x06026E28 RID: 159272 RVA: 0x009809F4 File Offset: 0x0097EBF4
		// (set) Token: 0x06026E29 RID: 159273 RVA: 0x00980A08 File Offset: 0x0097EC08
		[Nullable(0)]
		public unsafe TEnumAsByte<QuantizerAxisIgnore> MovementNotQuantizedToStepsOnAxis
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_303);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_303) = value;
			}
		}

		// Token: 0x17005503 RID: 21763
		// (get) Token: 0x06026E2A RID: 159274 RVA: 0x00980A1D File Offset: 0x0097EC1D
		// (set) Token: 0x06026E2B RID: 159275 RVA: 0x00980A2D File Offset: 0x0097EC2D
		public unsafe bool SecondaryMaterialsPresent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_304) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_304) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005504 RID: 21764
		// (get) Token: 0x06026E2C RID: 159276 RVA: 0x00980A3E File Offset: 0x0097EC3E
		// (set) Token: 0x06026E2D RID: 159277 RVA: 0x00980A52 File Offset: 0x0097EC52
		[Nullable(0)]
		public unsafe TEnumAsByte<QuantizerAxisIgnore> MovementIsLockedOnThisAxis
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_305);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_305) = value;
			}
		}

		// Token: 0x17005505 RID: 21765
		// (get) Token: 0x06026E2E RID: 159278 RVA: 0x00980A67 File Offset: 0x0097EC67
		// (set) Token: 0x06026E2F RID: 159279 RVA: 0x00980A77 File Offset: 0x0097EC77
		public unsafe bool ForceTraceMeshToCustomVerticalPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_306) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_306) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005506 RID: 21766
		// (get) Token: 0x06026E30 RID: 159280 RVA: 0x00980A88 File Offset: 0x0097EC88
		// (set) Token: 0x06026E31 RID: 159281 RVA: 0x00980A98 File Offset: 0x0097EC98
		public unsafe float ForceTraceMeshVerticalPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_307);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_307) = value;
			}
		}

		// Token: 0x17005507 RID: 21767
		// (get) Token: 0x06026E32 RID: 159282 RVA: 0x00980AA9 File Offset: 0x0097ECA9
		// (set) Token: 0x06026E33 RID: 159283 RVA: 0x00980AB9 File Offset: 0x0097ECB9
		public unsafe bool EnablePaintBufferOffsetInWorldSpace
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_308) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_308) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005508 RID: 21768
		// (get) Token: 0x06026E34 RID: 159284 RVA: 0x00980ACA File Offset: 0x0097ECCA
		// (set) Token: 0x06026E35 RID: 159285 RVA: 0x00980ADA File Offset: 0x0097ECDA
		public unsafe bool SimplePainterMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_309) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_309) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005509 RID: 21769
		// (get) Token: 0x06026E36 RID: 159286 RVA: 0x00980AEB File Offset: 0x0097ECEB
		// (set) Token: 0x06026E37 RID: 159287 RVA: 0x00980AFF File Offset: 0x0097ECFF
		[Nullable(2)]
		public unsafe UBoxComponent InteractionVolume
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveComponent_C.__PropertyOffset_310);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveComponent_C.__PropertyOffset_310, value);
			}
		}

		// Token: 0x1700550A RID: 21770
		// (get) Token: 0x06026E38 RID: 159288 RVA: 0x00980B14 File Offset: 0x0097ED14
		// (set) Token: 0x06026E39 RID: 159289 RVA: 0x00980B24 File Offset: 0x0097ED24
		public unsafe bool NiagaraSystemsPresent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_311) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_311) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700550B RID: 21771
		// (get) Token: 0x06026E3A RID: 159290 RVA: 0x00980B38 File Offset: 0x0097ED38
		// (set) Token: 0x06026E3B RID: 159291 RVA: 0x00980B71 File Offset: 0x0097ED71
		public TArray<UNiagaraComponent> NiagaraSystemsToDrive
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UNiagaraComponent> result;
				if ((result = this._NiagaraSystemsToDrive) == null)
				{
					result = (this._NiagaraSystemsToDrive = new TArray<UNiagaraComponent>(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_312, this));
				}
				return result;
			}
			set
			{
				this.NiagaraSystemsToDrive.CopyAssign(value);
			}
		}

		// Token: 0x1700550C RID: 21772
		// (get) Token: 0x06026E3C RID: 159292 RVA: 0x00980B7F File Offset: 0x0097ED7F
		// (set) Token: 0x06026E3D RID: 159293 RVA: 0x00980B8F File Offset: 0x0097ED8F
		public unsafe float Exp_PressureFeedbackComponent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_313);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_313) = value;
			}
		}

		// Token: 0x1700550D RID: 21773
		// (get) Token: 0x06026E3E RID: 159294 RVA: 0x00980BA0 File Offset: 0x0097EDA0
		// (set) Token: 0x06026E3F RID: 159295 RVA: 0x00980BB0 File Offset: 0x0097EDB0
		public unsafe float Exp_DivergenceFeedbackComponent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_314);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_314) = value;
			}
		}

		// Token: 0x1700550E RID: 21774
		// (get) Token: 0x06026E40 RID: 159296 RVA: 0x00980BC1 File Offset: 0x0097EDC1
		// (set) Token: 0x06026E41 RID: 159297 RVA: 0x00980BD1 File Offset: 0x0097EDD1
		public unsafe bool Force8bitSimplePainterBuffers
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_315) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_315) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700550F RID: 21775
		// (get) Token: 0x06026E42 RID: 159298 RVA: 0x00980BE2 File Offset: 0x0097EDE2
		// (set) Token: 0x06026E43 RID: 159299 RVA: 0x00980BF2 File Offset: 0x0097EDF2
		public unsafe bool Force8bitOutputBuffer
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_316) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_316) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005510 RID: 21776
		// (get) Token: 0x06026E44 RID: 159300 RVA: 0x00980C03 File Offset: 0x0097EE03
		// (set) Token: 0x06026E45 RID: 159301 RVA: 0x00980C17 File Offset: 0x0097EE17
		[Nullable(2)]
		public unsafe UPrimitiveComponent SingleTarget
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPrimitiveComponent>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveComponent_C.__PropertyOffset_317);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveComponent_C.__PropertyOffset_317, value);
			}
		}

		// Token: 0x17005511 RID: 21777
		// (get) Token: 0x06026E46 RID: 159302 RVA: 0x00980C2C File Offset: 0x0097EE2C
		// (set) Token: 0x06026E47 RID: 159303 RVA: 0x00980C3C File Offset: 0x0097EE3C
		public unsafe bool UE5EAFLAG
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_318) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_318) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005512 RID: 21778
		// (get) Token: 0x06026E48 RID: 159304 RVA: 0x00980C4D File Offset: 0x0097EE4D
		// (set) Token: 0x06026E49 RID: 159305 RVA: 0x00980C5D File Offset: 0x0097EE5D
		public unsafe bool Force2xResolutionOutputBuffer
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_319) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_319) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005513 RID: 21779
		// (get) Token: 0x06026E4A RID: 159306 RVA: 0x00980C6E File Offset: 0x0097EE6E
		// (set) Token: 0x06026E4B RID: 159307 RVA: 0x00980C7E File Offset: 0x0097EE7E
		public unsafe bool ForceMaxSamplingFPS_ToNiagara
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_320) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_320) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005514 RID: 21780
		// (get) Token: 0x06026E4C RID: 159308 RVA: 0x00980C8F File Offset: 0x0097EE8F
		// (set) Token: 0x06026E4D RID: 159309 RVA: 0x00980C9F File Offset: 0x0097EE9F
		public unsafe bool MaterialCollectionPresent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_321) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_321) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005515 RID: 21781
		// (get) Token: 0x06026E4E RID: 159310 RVA: 0x00980CB0 File Offset: 0x0097EEB0
		// (set) Token: 0x06026E4F RID: 159311 RVA: 0x00980CE9 File Offset: 0x0097EEE9
		public WorldSpaceOffset WorldSpaceOffset
		{
			get
			{
				base.FastCheckIsValid();
				WorldSpaceOffset result;
				if ((result = this._WorldSpaceOffset) == null)
				{
					result = (this._WorldSpaceOffset = new WorldSpaceOffset(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_322, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_322, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17005516 RID: 21782
		// (get) Token: 0x06026E50 RID: 159312 RVA: 0x00980D0A File Offset: 0x0097EF0A
		// (set) Token: 0x06026E51 RID: 159313 RVA: 0x00980D1A File Offset: 0x0097EF1A
		public unsafe bool BrushPosityBySwimChangeSkeletalPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_323) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_323) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005517 RID: 21783
		// (get) Token: 0x06026E52 RID: 159314 RVA: 0x00980D2B File Offset: 0x0097EF2B
		// (set) Token: 0x06026E53 RID: 159315 RVA: 0x00980D3F File Offset: 0x0097EF3F
		[Nullable(2)]
		public unsafe UPrimitiveComponent boundTraceMesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPrimitiveComponent>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveComponent_C.__PropertyOffset_324);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveComponent_C.__PropertyOffset_324, value);
			}
		}

		// Token: 0x17005518 RID: 21784
		// (get) Token: 0x06026E54 RID: 159316 RVA: 0x00980D54 File Offset: 0x0097EF54
		// (set) Token: 0x06026E55 RID: 159317 RVA: 0x00980D68 File Offset: 0x0097EF68
		public unsafe FLinearColor tmpHitUV
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_325);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_325) = value;
			}
		}

		// Token: 0x17005519 RID: 21785
		// (get) Token: 0x06026E56 RID: 159318 RVA: 0x00980D7D File Offset: 0x0097EF7D
		// (set) Token: 0x06026E57 RID: 159319 RVA: 0x00980D91 File Offset: 0x0097EF91
		public unsafe FVector tmpPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_326);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_326) = value;
			}
		}

		// Token: 0x1700551A RID: 21786
		// (get) Token: 0x06026E58 RID: 159320 RVA: 0x00980DA6 File Offset: 0x0097EFA6
		// (set) Token: 0x06026E59 RID: 159321 RVA: 0x00980DB6 File Offset: 0x0097EFB6
		public unsafe bool BatchRenderPoints
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_327) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_327) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700551B RID: 21787
		// (get) Token: 0x06026E5A RID: 159322 RVA: 0x00980DC7 File Offset: 0x0097EFC7
		// (set) Token: 0x06026E5B RID: 159323 RVA: 0x00980DD7 File Offset: 0x0097EFD7
		public unsafe int Object_Processor_Index
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_328);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_328) = value;
			}
		}

		// Token: 0x1700551C RID: 21788
		// (get) Token: 0x06026E5C RID: 159324 RVA: 0x00980DE8 File Offset: 0x0097EFE8
		// (set) Token: 0x06026E5D RID: 159325 RVA: 0x00980DFC File Offset: 0x0097EFFC
		public unsafe FVector CameraLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_329);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_329) = value;
			}
		}

		// Token: 0x1700551D RID: 21789
		// (get) Token: 0x06026E5E RID: 159326 RVA: 0x00980E11 File Offset: 0x0097F011
		// (set) Token: 0x06026E5F RID: 159327 RVA: 0x00980E25 File Offset: 0x0097F025
		[Nullable(2)]
		public unsafe PD_NinjaSimCache_C SimCacheDA
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<PD_NinjaSimCache_C>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveComponent_C.__PropertyOffset_330);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveComponent_C.__PropertyOffset_330, value);
			}
		}

		// Token: 0x1700551E RID: 21790
		// (get) Token: 0x06026E60 RID: 159328 RVA: 0x00980E3A File Offset: 0x0097F03A
		// (set) Token: 0x06026E61 RID: 159329 RVA: 0x00980E4E File Offset: 0x0097F04E
		[Nullable(2)]
		public unsafe UMaterialInstanceDynamic CopyMDI
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveComponent_C.__PropertyOffset_331);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveComponent_C.__PropertyOffset_331, value);
			}
		}

		// Token: 0x1700551F RID: 21791
		// (get) Token: 0x06026E62 RID: 159330 RVA: 0x00980E63 File Offset: 0x0097F063
		// (set) Token: 0x06026E63 RID: 159331 RVA: 0x00980E73 File Offset: 0x0097F073
		public unsafe bool bCached
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_332) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_332) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005520 RID: 21792
		// (get) Token: 0x06026E64 RID: 159332 RVA: 0x00980E84 File Offset: 0x0097F084
		// (set) Token: 0x06026E65 RID: 159333 RVA: 0x00980E98 File Offset: 0x0097F098
		[Nullable(2)]
		public unsafe UTextureRenderTarget2D OverwriteDensityRT
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveComponent_C.__PropertyOffset_333);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveComponent_C.__PropertyOffset_333, value);
			}
		}

		// Token: 0x17005521 RID: 21793
		// (get) Token: 0x06026E66 RID: 159334 RVA: 0x00980EAD File Offset: 0x0097F0AD
		// (set) Token: 0x06026E67 RID: 159335 RVA: 0x00980EBD File Offset: 0x0097F0BD
		public unsafe int NowQuality
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_334);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_334) = value;
			}
		}

		// Token: 0x17005522 RID: 21794
		// (get) Token: 0x06026E68 RID: 159336 RVA: 0x00980ECE File Offset: 0x0097F0CE
		// (set) Token: 0x06026E69 RID: 159337 RVA: 0x00980EDE File Offset: 0x0097F0DE
		public unsafe bool bQualitySwitch
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_335) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_335) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005523 RID: 21795
		// (get) Token: 0x06026E6A RID: 159338 RVA: 0x00980EEF File Offset: 0x0097F0EF
		// (set) Token: 0x06026E6B RID: 159339 RVA: 0x00980EFF File Offset: 0x0097F0FF
		public unsafe bool bBoundEventOnQuality
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_336) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_336) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005524 RID: 21796
		// (get) Token: 0x06026E6C RID: 159340 RVA: 0x00980F10 File Offset: 0x0097F110
		// (set) Token: 0x06026E6D RID: 159341 RVA: 0x00980F24 File Offset: 0x0097F124
		public unsafe FRotator TraceMeshRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_337);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_337) = value;
			}
		}

		// Token: 0x17005525 RID: 21797
		// (get) Token: 0x06026E6E RID: 159342 RVA: 0x00980F39 File Offset: 0x0097F139
		// (set) Token: 0x06026E6F RID: 159343 RVA: 0x00980F4D File Offset: 0x0097F14D
		public unsafe FVector TraceMeshScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_338);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_338) = value;
			}
		}

		// Token: 0x17005526 RID: 21798
		// (get) Token: 0x06026E70 RID: 159344 RVA: 0x00980F62 File Offset: 0x0097F162
		// (set) Token: 0x06026E71 RID: 159345 RVA: 0x00980F76 File Offset: 0x0097F176
		public unsafe FVectorDouble TraceMeshLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_339);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_339) = value;
			}
		}

		// Token: 0x17005527 RID: 21799
		// (get) Token: 0x06026E72 RID: 159346 RVA: 0x00980F8B File Offset: 0x0097F18B
		// (set) Token: 0x06026E73 RID: 159347 RVA: 0x00980F9B File Offset: 0x0097F19B
		public unsafe int RequiredQualityLevel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_340);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_340) = value;
			}
		}

		// Token: 0x17005528 RID: 21800
		// (get) Token: 0x06026E74 RID: 159348 RVA: 0x00980FAC File Offset: 0x0097F1AC
		// (set) Token: 0x06026E75 RID: 159349 RVA: 0x00980FC0 File Offset: 0x0097F1C0
		public unsafe FVector tmpCachedOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_341);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_341) = value;
			}
		}

		// Token: 0x17005529 RID: 21801
		// (get) Token: 0x06026E76 RID: 159350 RVA: 0x00980FD5 File Offset: 0x0097F1D5
		// (set) Token: 0x06026E77 RID: 159351 RVA: 0x00980FE5 File Offset: 0x0097F1E5
		public unsafe float tmpCachedOffsetX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_342);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_342) = value;
			}
		}

		// Token: 0x1700552A RID: 21802
		// (get) Token: 0x06026E78 RID: 159352 RVA: 0x00980FF6 File Offset: 0x0097F1F6
		// (set) Token: 0x06026E79 RID: 159353 RVA: 0x00981006 File Offset: 0x0097F206
		public unsafe float tmpCachedOffsetY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_343);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_343) = value;
			}
		}

		// Token: 0x1700552B RID: 21803
		// (get) Token: 0x06026E7A RID: 159354 RVA: 0x00981017 File Offset: 0x0097F217
		// (set) Token: 0x06026E7B RID: 159355 RVA: 0x00981027 File Offset: 0x0097F227
		public unsafe float tmpCachedOffsetZ
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_344);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_344) = value;
			}
		}

		// Token: 0x1700552C RID: 21804
		// (get) Token: 0x06026E7C RID: 159356 RVA: 0x00981038 File Offset: 0x0097F238
		// (set) Token: 0x06026E7D RID: 159357 RVA: 0x00981048 File Offset: 0x0097F248
		public unsafe bool bNoMovement
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_345) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_345) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700552D RID: 21805
		// (get) Token: 0x06026E7E RID: 159358 RVA: 0x00981059 File Offset: 0x0097F259
		// (set) Token: 0x06026E7F RID: 159359 RVA: 0x00981069 File Offset: 0x0097F269
		public unsafe bool bUseWeaponInteraction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_346) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_346) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700552E RID: 21806
		// (get) Token: 0x06026E80 RID: 159360 RVA: 0x0098107C File Offset: 0x0097F27C
		// (set) Token: 0x06026E81 RID: 159361 RVA: 0x009810B5 File Offset: 0x0097F2B5
		public TMap<string, FVector> boneCachePos
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, FVector> result;
				if ((result = this._boneCachePos) == null)
				{
					result = (this._boneCachePos = new TMap<string, FVector>(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_347, this));
				}
				return result;
			}
			set
			{
				this.boneCachePos.CopyAssign(value);
			}
		}

		// Token: 0x1700552F RID: 21807
		// (get) Token: 0x06026E82 RID: 159362 RVA: 0x009810C4 File Offset: 0x0097F2C4
		// (set) Token: 0x06026E83 RID: 159363 RVA: 0x009810FD File Offset: 0x0097F2FD
		public TMap<string, FVector> boneVelocity
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, FVector> result;
				if ((result = this._boneVelocity) == null)
				{
					result = (this._boneVelocity = new TMap<string, FVector>(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_348, this));
				}
				return result;
			}
			set
			{
				this.boneVelocity.CopyAssign(value);
			}
		}

		// Token: 0x17005530 RID: 21808
		// (get) Token: 0x06026E84 RID: 159364 RVA: 0x0098110B File Offset: 0x0097F30B
		// (set) Token: 0x06026E85 RID: 159365 RVA: 0x0098111F File Offset: 0x0097F31F
		public unsafe FVector tempBoneVelocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_349);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_349) = value;
			}
		}

		// Token: 0x17005531 RID: 21809
		// (get) Token: 0x06026E86 RID: 159366 RVA: 0x00981134 File Offset: 0x0097F334
		// (set) Token: 0x06026E87 RID: 159367 RVA: 0x00981144 File Offset: 0x0097F344
		public unsafe bool bCalcVeloctiyWithoutPhysic
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_350) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_350) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005532 RID: 21810
		// (get) Token: 0x06026E88 RID: 159368 RVA: 0x00981155 File Offset: 0x0097F355
		// (set) Token: 0x06026E89 RID: 159369 RVA: 0x00981165 File Offset: 0x0097F365
		public unsafe float CalcvelocityMulti
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_351);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_351) = value;
			}
		}

		// Token: 0x17005533 RID: 21811
		// (get) Token: 0x06026E8A RID: 159370 RVA: 0x00981178 File Offset: 0x0097F378
		// (set) Token: 0x06026E8B RID: 159371 RVA: 0x009811B1 File Offset: 0x0097F3B1
		public TMap<UPrimitiveComponent, FLinearColor> primitiveCachePos2D
		{
			get
			{
				base.FastCheckIsValid();
				TMap<UPrimitiveComponent, FLinearColor> result;
				if ((result = this._primitiveCachePos2D) == null)
				{
					result = (this._primitiveCachePos2D = new TMap<UPrimitiveComponent, FLinearColor>(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_352, this));
				}
				return result;
			}
			set
			{
				this.primitiveCachePos2D.CopyAssign(value);
			}
		}

		// Token: 0x17005534 RID: 21812
		// (get) Token: 0x06026E8C RID: 159372 RVA: 0x009811BF File Offset: 0x0097F3BF
		// (set) Token: 0x06026E8D RID: 159373 RVA: 0x009811CF File Offset: 0x0097F3CF
		public unsafe bool bUseLinePaint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_353) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_353) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005535 RID: 21813
		// (get) Token: 0x06026E8E RID: 159374 RVA: 0x009811E0 File Offset: 0x0097F3E0
		// (set) Token: 0x06026E8F RID: 159375 RVA: 0x009811F0 File Offset: 0x0097F3F0
		public unsafe bool bCommonFluid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_354) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_354) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005536 RID: 21814
		// (get) Token: 0x06026E90 RID: 159376 RVA: 0x00981201 File Offset: 0x0097F401
		// (set) Token: 0x06026E91 RID: 159377 RVA: 0x00981215 File Offset: 0x0097F415
		public unsafe FVector singleSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_355);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_355) = value;
			}
		}

		// Token: 0x17005537 RID: 21815
		// (get) Token: 0x06026E92 RID: 159378 RVA: 0x0098122A File Offset: 0x0097F42A
		// (set) Token: 0x06026E93 RID: 159379 RVA: 0x0098123E File Offset: 0x0097F43E
		public unsafe FVectorDouble lastSingelPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_356);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveComponent_C.__PropertyOffset_356) = value;
			}
		}

		// Token: 0x06026E94 RID: 159380 RVA: 0x00981254 File Offset: 0x0097F454
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetLinePaintEnable(bool enable)
		{
			NinjaLiveComponent_C.__SetLinePaintEnable_FunctionParams* ptr = stackalloc NinjaLiveComponent_C.__SetLinePaintEnable_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(NinjaLiveComponent_C.__SetLinePaintEnable_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLiveComponent_C.__SetLinePaintEnable_NativeFunctionPtr, (void*)ptr, 1);
			ptr->enable = enable;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLiveComponent_C.__SetLinePaintEnable_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06026E95 RID: 159381 RVA: 0x0098129C File Offset: 0x0097F49C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual FVector CalcBoneVelocity(UObject Skeletal)
		{
			NinjaLiveComponent_C.__CalcBoneVelocity_FunctionParams* ptr = stackalloc NinjaLiveComponent_C.__CalcBoneVelocity_FunctionParams[(UIntPtr)239] + 15L / (long)sizeof(NinjaLiveComponent_C.__CalcBoneVelocity_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLiveComponent_C.__CalcBoneVelocity_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Skeletal = ((Skeletal != null) ? Skeletal.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLiveComponent_C.__CalcBoneVelocity_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06026E96 RID: 159382 RVA: 0x009812FA File Offset: 0x0097F4FA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void ApplySimCache()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLiveComponent_C.__ApplySimCache_NativeFunctionPtr, null);
		}

		// Token: 0x06026E97 RID: 159383 RVA: 0x0098130E File Offset: 0x0097F50E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 从表格读取覆盖贴图()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLiveComponent_C.__从表格读取覆盖贴图_NativeFunctionPtr, null);
		}

		// Token: 0x06026E98 RID: 159384 RVA: 0x00981324 File Offset: 0x0097F524
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			NinjaLiveComponent_C.__ReceiveTick_FunctionParams* ptr = stackalloc NinjaLiveComponent_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(NinjaLiveComponent_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLiveComponent_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLiveComponent_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06026E99 RID: 159385 RVA: 0x0098136C File Offset: 0x0097F56C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			NinjaLiveComponent_C.__ReceiveTick_FunctionParams* ptr = stackalloc NinjaLiveComponent_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(NinjaLiveComponent_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLiveComponent_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, NinjaLiveComponent_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06026E9A RID: 159386 RVA: 0x009813B3 File Offset: 0x0097F5B3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void RePlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLiveComponent_C.__RePlay_NativeFunctionPtr, null);
		}

		// Token: 0x06026E9B RID: 159387 RVA: 0x009813C8 File Offset: 0x0097F5C8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void LiveActivation(FName ParamName, float FadeTimeOfBrush, float FadeTimeOfCanvas)
		{
			NinjaLiveComponent_C.__LiveActivation_FunctionParams* ptr = stackalloc NinjaLiveComponent_C.__LiveActivation_FunctionParams[(UIntPtr)35] + 15L / (long)sizeof(NinjaLiveComponent_C.__LiveActivation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLiveComponent_C.__LiveActivation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ParamName = ParamName;
			ptr->FadeTimeOfBrush = FadeTimeOfBrush;
			ptr->FadeTimeOfCanvas = FadeTimeOfCanvas;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLiveComponent_C.__LiveActivation_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06026E9C RID: 159388 RVA: 0x0098141C File Offset: 0x0097F61C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void LiveFluidParams(float BrushSize)
		{
			NinjaLiveComponent_C.__LiveFluidParams_FunctionParams* ptr = stackalloc NinjaLiveComponent_C.__LiveFluidParams_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(NinjaLiveComponent_C.__LiveFluidParams_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLiveComponent_C.__LiveFluidParams_NativeFunctionPtr, (void*)ptr, 1);
			ptr->BrushSize = BrushSize;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLiveComponent_C.__LiveFluidParams_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06026E9D RID: 159389 RVA: 0x00981462 File Offset: 0x0097F662
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLiveComponent_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06026E9E RID: 159390 RVA: 0x00981476 File Offset: 0x0097F676
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, NinjaLiveComponent_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06026E9F RID: 159391 RVA: 0x0098148B File Offset: 0x0097F68B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Shutdown()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLiveComponent_C.__Shutdown_NativeFunctionPtr, null);
		}

		// Token: 0x06026EA0 RID: 159392 RVA: 0x0098149F File Offset: 0x0097F69F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateQualitySwitch()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLiveComponent_C.__UpdateQualitySwitch_NativeFunctionPtr, null);
		}

		// Token: 0x06026EA1 RID: 159393 RVA: 0x009814B4 File Offset: 0x0097F6B4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
		{
			NinjaLiveComponent_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc NinjaLiveComponent_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(NinjaLiveComponent_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLiveComponent_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLiveComponent_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06026EA2 RID: 159394 RVA: 0x00981500 File Offset: 0x0097F700
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
		{
			NinjaLiveComponent_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc NinjaLiveComponent_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(NinjaLiveComponent_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLiveComponent_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, NinjaLiveComponent_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06026EA3 RID: 159395 RVA: 0x0098154C File Offset: 0x0097F74C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SelChanged(string SelectedMenuItem, string SelectedActorName)
		{
			NinjaLiveComponent_C.__SelChanged_FunctionParams* ptr = stackalloc NinjaLiveComponent_C.__SelChanged_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(NinjaLiveComponent_C.__SelChanged_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLiveComponent_C.__SelChanged_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->SelectedMenuItem), SelectedMenuItem);
			FString.CopyFrom((void*)(&ptr->SelectedActorName), SelectedActorName);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLiveComponent_C.__SelChanged_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(NinjaLiveComponent_C.__SelChanged_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06026EA4 RID: 159396 RVA: 0x009815B8 File Offset: 0x0097F7B8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void PresetSelectionChanged(string SelectedPreset, bool ForceAutoLoadPreset)
		{
			NinjaLiveComponent_C.__PresetSelectionChanged_FunctionParams* ptr = stackalloc NinjaLiveComponent_C.__PresetSelectionChanged_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(NinjaLiveComponent_C.__PresetSelectionChanged_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLiveComponent_C.__PresetSelectionChanged_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->SelectedPreset), SelectedPreset);
			ptr->ForceAutoLoadPreset = ForceAutoLoadPreset;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLiveComponent_C.__PresetSelectionChanged_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(NinjaLiveComponent_C.__PresetSelectionChanged_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06026EA5 RID: 159397 RVA: 0x0098161C File Offset: 0x0097F81C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void PresetSave(string SelectedProject, string SelectedPreset, bool OverWriteOrNot)
		{
			NinjaLiveComponent_C.__PresetSave_FunctionParams* ptr = stackalloc NinjaLiveComponent_C.__PresetSave_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(NinjaLiveComponent_C.__PresetSave_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLiveComponent_C.__PresetSave_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->SelectedProject), SelectedProject);
			FString.CopyFrom((void*)(&ptr->SelectedPreset), SelectedPreset);
			ptr->OverWriteOrNot = OverWriteOrNot;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLiveComponent_C.__PresetSave_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(NinjaLiveComponent_C.__PresetSave_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06026EA6 RID: 159398 RVA: 0x0098168D File Offset: 0x0097F88D
		protected NinjaLiveComponent_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040137AD RID: 79789
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/FluidNinjaLive/NinjaLiveComponent.NinjaLiveComponent_C";

		// Token: 0x040137AE RID: 79790
		private static IntPtr _ClassPtr;

		// Token: 0x040137AF RID: 79791
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040137B0 RID: 79792
		public static IntPtr __WorldSpaceOffset__DelegateSignature_NativeFunctionPtr;

		// Token: 0x040137B1 RID: 79793
		public static IntPtr __ComponentShutdownEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x040137B2 RID: 79794
		public static IntPtr __ComponentBroadcastMemConsumption__DelegateSignature_NativeFunctionPtr;

		// Token: 0x040137B3 RID: 79795
		public static IntPtr __ComponentRePlayEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x040137B4 RID: 79796
		internal static int __PropertyOffset_1;

		// Token: 0x040137B5 RID: 79797
		internal static int __PropertyOffset_2;

		// Token: 0x040137B6 RID: 79798
		internal static int __PropertyOffset_3;

		// Token: 0x040137B7 RID: 79799
		internal static int __PropertyOffset_4;

		// Token: 0x040137B8 RID: 79800
		internal static int __PropertyOffset_5;

		// Token: 0x040137B9 RID: 79801
		internal static int __PropertyOffset_6;

		// Token: 0x040137BA RID: 79802
		internal static int __PropertyOffset_7;

		// Token: 0x040137BB RID: 79803
		internal static int __PropertyOffset_8;

		// Token: 0x040137BC RID: 79804
		internal static int __PropertyOffset_9;

		// Token: 0x040137BD RID: 79805
		internal static int __PropertyOffset_10;

		// Token: 0x040137BE RID: 79806
		internal static int __PropertyOffset_11;

		// Token: 0x040137BF RID: 79807
		internal static int __PropertyOffset_12;

		// Token: 0x040137C0 RID: 79808
		internal static int __PropertyOffset_13;

		// Token: 0x040137C1 RID: 79809
		internal static int __PropertyOffset_14;

		// Token: 0x040137C2 RID: 79810
		internal static int __PropertyOffset_15;

		// Token: 0x040137C3 RID: 79811
		internal static int __PropertyOffset_16;

		// Token: 0x040137C4 RID: 79812
		internal static int __PropertyOffset_17;

		// Token: 0x040137C5 RID: 79813
		internal static int __PropertyOffset_18;

		// Token: 0x040137C6 RID: 79814
		internal static int __PropertyOffset_19;

		// Token: 0x040137C7 RID: 79815
		internal static int __PropertyOffset_20;

		// Token: 0x040137C8 RID: 79816
		internal static int __PropertyOffset_21;

		// Token: 0x040137C9 RID: 79817
		internal static int __PropertyOffset_22;

		// Token: 0x040137CA RID: 79818
		internal static int __PropertyOffset_23;

		// Token: 0x040137CB RID: 79819
		internal static int __PropertyOffset_24;

		// Token: 0x040137CC RID: 79820
		internal static int __PropertyOffset_25;

		// Token: 0x040137CD RID: 79821
		internal static int __PropertyOffset_26;

		// Token: 0x040137CE RID: 79822
		internal static int __PropertyOffset_27;

		// Token: 0x040137CF RID: 79823
		internal static int __PropertyOffset_28;

		// Token: 0x040137D0 RID: 79824
		internal static int __PropertyOffset_29;

		// Token: 0x040137D1 RID: 79825
		internal static int __PropertyOffset_30;

		// Token: 0x040137D2 RID: 79826
		internal static int __PropertyOffset_31;

		// Token: 0x040137D3 RID: 79827
		internal static int __PropertyOffset_32;

		// Token: 0x040137D4 RID: 79828
		internal static int __PropertyOffset_33;

		// Token: 0x040137D5 RID: 79829
		internal static int __PropertyOffset_34;

		// Token: 0x040137D6 RID: 79830
		internal static int __PropertyOffset_35;

		// Token: 0x040137D7 RID: 79831
		internal static int __PropertyOffset_36;

		// Token: 0x040137D8 RID: 79832
		internal static int __PropertyOffset_37;

		// Token: 0x040137D9 RID: 79833
		internal static int __PropertyOffset_38;

		// Token: 0x040137DA RID: 79834
		internal static int __PropertyOffset_39;

		// Token: 0x040137DB RID: 79835
		internal static int __PropertyOffset_40;

		// Token: 0x040137DC RID: 79836
		internal static int __PropertyOffset_41;

		// Token: 0x040137DD RID: 79837
		internal static int __PropertyOffset_42;

		// Token: 0x040137DE RID: 79838
		internal static int __PropertyOffset_43;

		// Token: 0x040137DF RID: 79839
		[Nullable(2)]
		private TArray<float> _LOD_StepsArray;

		// Token: 0x040137E0 RID: 79840
		internal static int __PropertyOffset_44;

		// Token: 0x040137E1 RID: 79841
		internal static int __PropertyOffset_45;

		// Token: 0x040137E2 RID: 79842
		internal static int __PropertyOffset_46;

		// Token: 0x040137E3 RID: 79843
		internal static int __PropertyOffset_47;

		// Token: 0x040137E4 RID: 79844
		internal static int __PropertyOffset_48;

		// Token: 0x040137E5 RID: 79845
		[Nullable(2)]
		private ComponentRePlayEvent _ComponentRePlayEvent;

		// Token: 0x040137E6 RID: 79846
		internal static int __PropertyOffset_49;

		// Token: 0x040137E7 RID: 79847
		[Nullable(2)]
		private ComponentBroadcastMemConsumption _ComponentBroadcastMemConsumption;

		// Token: 0x040137E8 RID: 79848
		internal static int __PropertyOffset_50;

		// Token: 0x040137E9 RID: 79849
		internal static int __PropertyOffset_51;

		// Token: 0x040137EA RID: 79850
		internal static int __PropertyOffset_52;

		// Token: 0x040137EB RID: 79851
		internal static int __PropertyOffset_53;

		// Token: 0x040137EC RID: 79852
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<string, float> _PresetMap;

		// Token: 0x040137ED RID: 79853
		internal static int __PropertyOffset_54;

		// Token: 0x040137EE RID: 79854
		internal static int __PropertyOffset_55;

		// Token: 0x040137EF RID: 79855
		internal static int __PropertyOffset_56;

		// Token: 0x040137F0 RID: 79856
		[Nullable(2)]
		private TArray<FName> _PresetSearchPaths;

		// Token: 0x040137F1 RID: 79857
		internal static int __PropertyOffset_57;

		// Token: 0x040137F2 RID: 79858
		internal static int __PropertyOffset_58;

		// Token: 0x040137F3 RID: 79859
		internal static int __PropertyOffset_59;

		// Token: 0x040137F4 RID: 79860
		internal static int __PropertyOffset_60;

		// Token: 0x040137F5 RID: 79861
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInterface> _OutputMaterials;

		// Token: 0x040137F6 RID: 79862
		internal static int __PropertyOffset_61;

		// Token: 0x040137F7 RID: 79863
		internal static int __PropertyOffset_62;

		// Token: 0x040137F8 RID: 79864
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _RenderTargetsList;

		// Token: 0x040137F9 RID: 79865
		internal static int __PropertyOffset_63;

		// Token: 0x040137FA RID: 79866
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<string, UTextureRenderTarget2D> _RenderTargetsMap;

		// Token: 0x040137FB RID: 79867
		internal static int __PropertyOffset_64;

		// Token: 0x040137FC RID: 79868
		internal static int __PropertyOffset_65;

		// Token: 0x040137FD RID: 79869
		internal static int __PropertyOffset_66;

		// Token: 0x040137FE RID: 79870
		internal static int __PropertyOffset_67;

		// Token: 0x040137FF RID: 79871
		internal static int __PropertyOffset_68;

		// Token: 0x04013800 RID: 79872
		internal static int __PropertyOffset_69;

		// Token: 0x04013801 RID: 79873
		internal static int __PropertyOffset_70;

		// Token: 0x04013802 RID: 79874
		internal static int __PropertyOffset_71;

		// Token: 0x04013803 RID: 79875
		internal static int __PropertyOffset_72;

		// Token: 0x04013804 RID: 79876
		internal static int __PropertyOffset_73;

		// Token: 0x04013805 RID: 79877
		internal static int __PropertyOffset_74;

		// Token: 0x04013806 RID: 79878
		internal static int __PropertyOffset_75;

		// Token: 0x04013807 RID: 79879
		internal static int __PropertyOffset_76;

		// Token: 0x04013808 RID: 79880
		internal static int __PropertyOffset_77;

		// Token: 0x04013809 RID: 79881
		internal static int __PropertyOffset_78;

		// Token: 0x0401380A RID: 79882
		internal static int __PropertyOffset_79;

		// Token: 0x0401380B RID: 79883
		internal static int __PropertyOffset_80;

		// Token: 0x0401380C RID: 79884
		internal static int __PropertyOffset_81;

		// Token: 0x0401380D RID: 79885
		internal static int __PropertyOffset_82;

		// Token: 0x0401380E RID: 79886
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInterface> _SecondaryOutputMaterials;

		// Token: 0x0401380F RID: 79887
		internal static int __PropertyOffset_83;

		// Token: 0x04013810 RID: 79888
		internal static int __PropertyOffset_84;

		// Token: 0x04013811 RID: 79889
		internal static int __PropertyOffset_85;

		// Token: 0x04013812 RID: 79890
		internal static int __PropertyOffset_86;

		// Token: 0x04013813 RID: 79891
		internal static int __PropertyOffset_87;

		// Token: 0x04013814 RID: 79892
		internal static int __PropertyOffset_88;

		// Token: 0x04013815 RID: 79893
		internal static int __PropertyOffset_89;

		// Token: 0x04013816 RID: 79894
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInterface> _InputMaterials;

		// Token: 0x04013817 RID: 79895
		internal static int __PropertyOffset_90;

		// Token: 0x04013818 RID: 79896
		internal static int __PropertyOffset_91;

		// Token: 0x04013819 RID: 79897
		internal static int __PropertyOffset_92;

		// Token: 0x0401381A RID: 79898
		internal static int __PropertyOffset_93;

		// Token: 0x0401381B RID: 79899
		internal static int __PropertyOffset_94;

		// Token: 0x0401381C RID: 79900
		internal static int __PropertyOffset_95;

		// Token: 0x0401381D RID: 79901
		internal static int __PropertyOffset_96;

		// Token: 0x0401381E RID: 79902
		internal static int __PropertyOffset_97;

		// Token: 0x0401381F RID: 79903
		internal static int __PropertyOffset_98;

		// Token: 0x04013820 RID: 79904
		internal static int __PropertyOffset_99;

		// Token: 0x04013821 RID: 79905
		internal static int __PropertyOffset_100;

		// Token: 0x04013822 RID: 79906
		internal static int __PropertyOffset_101;

		// Token: 0x04013823 RID: 79907
		internal static int __PropertyOffset_102;

		// Token: 0x04013824 RID: 79908
		internal static int __PropertyOffset_103;

		// Token: 0x04013825 RID: 79909
		internal static int __PropertyOffset_104;

		// Token: 0x04013826 RID: 79910
		internal static int __PropertyOffset_105;

		// Token: 0x04013827 RID: 79911
		internal static int __PropertyOffset_106;

		// Token: 0x04013828 RID: 79912
		internal static int __PropertyOffset_107;

		// Token: 0x04013829 RID: 79913
		internal static int __PropertyOffset_108;

		// Token: 0x0401382A RID: 79914
		internal static int __PropertyOffset_109;

		// Token: 0x0401382B RID: 79915
		internal static int __PropertyOffset_110;

		// Token: 0x0401382C RID: 79916
		internal static int __PropertyOffset_111;

		// Token: 0x0401382D RID: 79917
		internal static int __PropertyOffset_112;

		// Token: 0x0401382E RID: 79918
		internal static int __PropertyOffset_113;

		// Token: 0x0401382F RID: 79919
		internal static int __PropertyOffset_114;

		// Token: 0x04013830 RID: 79920
		internal static int __PropertyOffset_115;

		// Token: 0x04013831 RID: 79921
		internal static int __PropertyOffset_116;

		// Token: 0x04013832 RID: 79922
		internal static int __PropertyOffset_117;

		// Token: 0x04013833 RID: 79923
		internal static int __PropertyOffset_118;

		// Token: 0x04013834 RID: 79924
		internal static int __PropertyOffset_119;

		// Token: 0x04013835 RID: 79925
		internal static int __PropertyOffset_120;

		// Token: 0x04013836 RID: 79926
		internal static int __PropertyOffset_121;

		// Token: 0x04013837 RID: 79927
		internal static int __PropertyOffset_122;

		// Token: 0x04013838 RID: 79928
		internal static int __PropertyOffset_123;

		// Token: 0x04013839 RID: 79929
		internal static int __PropertyOffset_124;

		// Token: 0x0401383A RID: 79930
		internal static int __PropertyOffset_125;

		// Token: 0x0401383B RID: 79931
		internal static int __PropertyOffset_126;

		// Token: 0x0401383C RID: 79932
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<int, UPrimitiveComponent> _SkeletalMesh_TempArray_Pairs;

		// Token: 0x0401383D RID: 79933
		internal static int __PropertyOffset_127;

		// Token: 0x0401383E RID: 79934
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UPrimitiveComponent> _OverlappingComponents;

		// Token: 0x0401383F RID: 79935
		internal static int __PropertyOffset_128;

		// Token: 0x04013840 RID: 79936
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<USkeletalMeshComponent> _ContinuousInteractionSkeletalComponent;

		// Token: 0x04013841 RID: 79937
		internal static int __PropertyOffset_129;

		// Token: 0x04013842 RID: 79938
		[Nullable(2)]
		private TArray<bool> _ListOfAvailableTempArrays;

		// Token: 0x04013843 RID: 79939
		internal static int __PropertyOffset_130;

		// Token: 0x04013844 RID: 79940
		internal static int __PropertyOffset_131;

		// Token: 0x04013845 RID: 79941
		internal static int __PropertyOffset_132;

		// Token: 0x04013846 RID: 79942
		internal static int __PropertyOffset_133;

		// Token: 0x04013847 RID: 79943
		internal static int __PropertyOffset_134;

		// Token: 0x04013848 RID: 79944
		internal static int __PropertyOffset_135;

		// Token: 0x04013849 RID: 79945
		internal static int __PropertyOffset_136;

		// Token: 0x0401384A RID: 79946
		internal static int __PropertyOffset_137;

		// Token: 0x0401384B RID: 79947
		internal static int __PropertyOffset_138;

		// Token: 0x0401384C RID: 79948
		[Nullable(2)]
		private TArray<FLinearColor> _LastPosition3_2D;

		// Token: 0x0401384D RID: 79949
		internal static int __PropertyOffset_139;

		// Token: 0x0401384E RID: 79950
		internal static int __PropertyOffset_140;

		// Token: 0x0401384F RID: 79951
		internal static int __PropertyOffset_141;

		// Token: 0x04013850 RID: 79952
		internal static int __PropertyOffset_142;

		// Token: 0x04013851 RID: 79953
		[Nullable(2)]
		private TArray<FLinearColor> _Position3_2D;

		// Token: 0x04013852 RID: 79954
		internal static int __PropertyOffset_143;

		// Token: 0x04013853 RID: 79955
		internal static int __PropertyOffset_144;

		// Token: 0x04013854 RID: 79956
		internal static int __PropertyOffset_145;

		// Token: 0x04013855 RID: 79957
		internal static int __PropertyOffset_146;

		// Token: 0x04013856 RID: 79958
		internal static int __PropertyOffset_147;

		// Token: 0x04013857 RID: 79959
		internal static int __PropertyOffset_148;

		// Token: 0x04013858 RID: 79960
		internal static int __PropertyOffset_149;

		// Token: 0x04013859 RID: 79961
		internal static int __PropertyOffset_150;

		// Token: 0x0401385A RID: 79962
		internal static int __PropertyOffset_151;

		// Token: 0x0401385B RID: 79963
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AActor> _NinjaLIVETraceExclude;

		// Token: 0x0401385C RID: 79964
		internal static int __PropertyOffset_152;

		// Token: 0x0401385D RID: 79965
		internal static int __PropertyOffset_153;

		// Token: 0x0401385E RID: 79966
		internal static int __PropertyOffset_154;

		// Token: 0x0401385F RID: 79967
		internal static int __PropertyOffset_155;

		// Token: 0x04013860 RID: 79968
		internal static int __PropertyOffset_156;

		// Token: 0x04013861 RID: 79969
		internal static int __PropertyOffset_157;

		// Token: 0x04013862 RID: 79970
		internal static int __PropertyOffset_158;

		// Token: 0x04013863 RID: 79971
		internal static int __PropertyOffset_159;

		// Token: 0x04013864 RID: 79972
		internal static int __PropertyOffset_160;

		// Token: 0x04013865 RID: 79973
		internal static int __PropertyOffset_161;

		// Token: 0x04013866 RID: 79974
		internal static int __PropertyOffset_162;

		// Token: 0x04013867 RID: 79975
		internal static int __PropertyOffset_163;

		// Token: 0x04013868 RID: 79976
		internal static int __PropertyOffset_164;

		// Token: 0x04013869 RID: 79977
		internal static int __PropertyOffset_165;

		// Token: 0x0401386A RID: 79978
		internal static int __PropertyOffset_166;

		// Token: 0x0401386B RID: 79979
		internal static int __PropertyOffset_167;

		// Token: 0x0401386C RID: 79980
		[Nullable(2)]
		private ComponentShutdownEvent _ComponentShutdownEvent;

		// Token: 0x0401386D RID: 79981
		internal static int __PropertyOffset_168;

		// Token: 0x0401386E RID: 79982
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TArray<TEnumAsByte<EObjectTypeQuery>> _ContinuousInteractionInclusiveObjType;

		// Token: 0x0401386F RID: 79983
		internal static int __PropertyOffset_169;

		// Token: 0x04013870 RID: 79984
		[Nullable(2)]
		private TArray<FName> _ContinuousInteractionComponentNamesExact;

		// Token: 0x04013871 RID: 79985
		internal static int __PropertyOffset_170;

		// Token: 0x04013872 RID: 79986
		[Nullable(2)]
		private TArray<FName> _ContinuousInteractionBoneNamesExact;

		// Token: 0x04013873 RID: 79987
		internal static int __PropertyOffset_171;

		// Token: 0x04013874 RID: 79988
		internal static int __PropertyOffset_172;

		// Token: 0x04013875 RID: 79989
		internal static int __PropertyOffset_173;

		// Token: 0x04013876 RID: 79990
		internal static int __PropertyOffset_174;

		// Token: 0x04013877 RID: 79991
		internal static int __PropertyOffset_175;

		// Token: 0x04013878 RID: 79992
		internal static int __PropertyOffset_176;

		// Token: 0x04013879 RID: 79993
		internal static int __PropertyOffset_177;

		// Token: 0x0401387A RID: 79994
		internal static int __PropertyOffset_178;

		// Token: 0x0401387B RID: 79995
		internal static int __PropertyOffset_179;

		// Token: 0x0401387C RID: 79996
		internal static int __PropertyOffset_180;

		// Token: 0x0401387D RID: 79997
		internal static int __PropertyOffset_181;

		// Token: 0x0401387E RID: 79998
		internal static int __PropertyOffset_182;

		// Token: 0x0401387F RID: 79999
		internal static int __PropertyOffset_183;

		// Token: 0x04013880 RID: 80000
		internal static int __PropertyOffset_184;

		// Token: 0x04013881 RID: 80001
		internal static int __PropertyOffset_185;

		// Token: 0x04013882 RID: 80002
		internal static int __PropertyOffset_186;

		// Token: 0x04013883 RID: 80003
		internal static int __PropertyOffset_187;

		// Token: 0x04013884 RID: 80004
		internal static int __PropertyOffset_188;

		// Token: 0x04013885 RID: 80005
		internal static int __PropertyOffset_189;

		// Token: 0x04013886 RID: 80006
		internal static int __PropertyOffset_190;

		// Token: 0x04013887 RID: 80007
		internal static int __PropertyOffset_191;

		// Token: 0x04013888 RID: 80008
		internal static int __PropertyOffset_192;

		// Token: 0x04013889 RID: 80009
		internal static int __PropertyOffset_193;

		// Token: 0x0401388A RID: 80010
		internal static int __PropertyOffset_194;

		// Token: 0x0401388B RID: 80011
		internal static int __PropertyOffset_195;

		// Token: 0x0401388C RID: 80012
		internal static int __PropertyOffset_196;

		// Token: 0x0401388D RID: 80013
		internal static int __PropertyOffset_197;

		// Token: 0x0401388E RID: 80014
		internal static int __PropertyOffset_198;

		// Token: 0x0401388F RID: 80015
		internal static int __PropertyOffset_199;

		// Token: 0x04013890 RID: 80016
		internal static int __PropertyOffset_200;

		// Token: 0x04013891 RID: 80017
		internal static int __PropertyOffset_201;

		// Token: 0x04013892 RID: 80018
		internal static int __PropertyOffset_202;

		// Token: 0x04013893 RID: 80019
		internal static int __PropertyOffset_203;

		// Token: 0x04013894 RID: 80020
		internal static int __PropertyOffset_204;

		// Token: 0x04013895 RID: 80021
		internal static int __PropertyOffset_205;

		// Token: 0x04013896 RID: 80022
		internal static int __PropertyOffset_206;

		// Token: 0x04013897 RID: 80023
		internal static int __PropertyOffset_207;

		// Token: 0x04013898 RID: 80024
		internal static int __PropertyOffset_208;

		// Token: 0x04013899 RID: 80025
		internal static int __PropertyOffset_209;

		// Token: 0x0401389A RID: 80026
		internal static int __PropertyOffset_210;

		// Token: 0x0401389B RID: 80027
		internal static int __PropertyOffset_211;

		// Token: 0x0401389C RID: 80028
		internal static int __PropertyOffset_212;

		// Token: 0x0401389D RID: 80029
		internal static int __PropertyOffset_213;

		// Token: 0x0401389E RID: 80030
		internal static int __PropertyOffset_214;

		// Token: 0x0401389F RID: 80031
		internal static int __PropertyOffset_215;

		// Token: 0x040138A0 RID: 80032
		internal static int __PropertyOffset_216;

		// Token: 0x040138A1 RID: 80033
		internal static int __PropertyOffset_217;

		// Token: 0x040138A2 RID: 80034
		internal static int __PropertyOffset_218;

		// Token: 0x040138A3 RID: 80035
		internal static int __PropertyOffset_219;

		// Token: 0x040138A4 RID: 80036
		internal static int __PropertyOffset_220;

		// Token: 0x040138A5 RID: 80037
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TArray<TEnumAsByte<RenderTargetList>> _InternalRenderTargetsToExport;

		// Token: 0x040138A6 RID: 80038
		internal static int __PropertyOffset_221;

		// Token: 0x040138A7 RID: 80039
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UTextureRenderTarget2D> _ExternalRenderTargets;

		// Token: 0x040138A8 RID: 80040
		internal static int __PropertyOffset_222;

		// Token: 0x040138A9 RID: 80041
		internal static int __PropertyOffset_223;

		// Token: 0x040138AA RID: 80042
		internal static int __PropertyOffset_224;

		// Token: 0x040138AB RID: 80043
		internal static int __PropertyOffset_225;

		// Token: 0x040138AC RID: 80044
		internal static int __PropertyOffset_226;

		// Token: 0x040138AD RID: 80045
		internal static int __PropertyOffset_227;

		// Token: 0x040138AE RID: 80046
		internal static int __PropertyOffset_228;

		// Token: 0x040138AF RID: 80047
		internal static int __PropertyOffset_229;

		// Token: 0x040138B0 RID: 80048
		internal static int __PropertyOffset_230;

		// Token: 0x040138B1 RID: 80049
		internal static int __PropertyOffset_231;

		// Token: 0x040138B2 RID: 80050
		internal static int __PropertyOffset_232;

		// Token: 0x040138B3 RID: 80051
		internal static int __PropertyOffset_233;

		// Token: 0x040138B4 RID: 80052
		internal static int __PropertyOffset_234;

		// Token: 0x040138B5 RID: 80053
		internal static int __PropertyOffset_235;

		// Token: 0x040138B6 RID: 80054
		internal static int __PropertyOffset_236;

		// Token: 0x040138B7 RID: 80055
		internal static int __PropertyOffset_237;

		// Token: 0x040138B8 RID: 80056
		internal static int __PropertyOffset_238;

		// Token: 0x040138B9 RID: 80057
		internal static int __PropertyOffset_239;

		// Token: 0x040138BA RID: 80058
		internal static int __PropertyOffset_240;

		// Token: 0x040138BB RID: 80059
		internal static int __PropertyOffset_241;

		// Token: 0x040138BC RID: 80060
		[Nullable(2)]
		private TArray<FName> _TempArray0;

		// Token: 0x040138BD RID: 80061
		internal static int __PropertyOffset_242;

		// Token: 0x040138BE RID: 80062
		[Nullable(2)]
		private TArray<FName> _TempArray1;

		// Token: 0x040138BF RID: 80063
		internal static int __PropertyOffset_243;

		// Token: 0x040138C0 RID: 80064
		[Nullable(2)]
		private TArray<FName> _TempArray2;

		// Token: 0x040138C1 RID: 80065
		internal static int __PropertyOffset_244;

		// Token: 0x040138C2 RID: 80066
		[Nullable(2)]
		private TArray<FName> _TempArray3;

		// Token: 0x040138C3 RID: 80067
		internal static int __PropertyOffset_245;

		// Token: 0x040138C4 RID: 80068
		[Nullable(2)]
		private TArray<FName> _TempArray4;

		// Token: 0x040138C5 RID: 80069
		internal static int __PropertyOffset_246;

		// Token: 0x040138C6 RID: 80070
		[Nullable(2)]
		private TArray<FName> _TempArray5;

		// Token: 0x040138C7 RID: 80071
		internal static int __PropertyOffset_247;

		// Token: 0x040138C8 RID: 80072
		[Nullable(2)]
		private TArray<FName> _TempArray6;

		// Token: 0x040138C9 RID: 80073
		internal static int __PropertyOffset_248;

		// Token: 0x040138CA RID: 80074
		[Nullable(2)]
		private TArray<FName> _TempArray7;

		// Token: 0x040138CB RID: 80075
		internal static int __PropertyOffset_249;

		// Token: 0x040138CC RID: 80076
		[Nullable(2)]
		private TArray<FName> _TempArray8;

		// Token: 0x040138CD RID: 80077
		internal static int __PropertyOffset_250;

		// Token: 0x040138CE RID: 80078
		[Nullable(2)]
		private TArray<FName> _TempArray9;

		// Token: 0x040138CF RID: 80079
		internal static int __PropertyOffset_251;

		// Token: 0x040138D0 RID: 80080
		[Nullable(2)]
		private TArray<FName> _TempArray10;

		// Token: 0x040138D1 RID: 80081
		internal static int __PropertyOffset_252;

		// Token: 0x040138D2 RID: 80082
		[Nullable(2)]
		private TArray<FName> _TempArray11;

		// Token: 0x040138D3 RID: 80083
		internal static int __PropertyOffset_253;

		// Token: 0x040138D4 RID: 80084
		[Nullable(2)]
		private TArray<FName> _TempArray12;

		// Token: 0x040138D5 RID: 80085
		internal static int __PropertyOffset_254;

		// Token: 0x040138D6 RID: 80086
		[Nullable(2)]
		private TArray<FName> _TempArray13;

		// Token: 0x040138D7 RID: 80087
		internal static int __PropertyOffset_255;

		// Token: 0x040138D8 RID: 80088
		[Nullable(2)]
		private TArray<FName> _TempArray14;

		// Token: 0x040138D9 RID: 80089
		internal static int __PropertyOffset_256;

		// Token: 0x040138DA RID: 80090
		[Nullable(2)]
		private TArray<FName> _TempArray15;

		// Token: 0x040138DB RID: 80091
		internal static int __PropertyOffset_257;

		// Token: 0x040138DC RID: 80092
		[Nullable(2)]
		private TArray<FName> _TempArray16;

		// Token: 0x040138DD RID: 80093
		internal static int __PropertyOffset_258;

		// Token: 0x040138DE RID: 80094
		[Nullable(2)]
		private TArray<FName> _TempArray17;

		// Token: 0x040138DF RID: 80095
		internal static int __PropertyOffset_259;

		// Token: 0x040138E0 RID: 80096
		[Nullable(2)]
		private TArray<FName> _TempArray18;

		// Token: 0x040138E1 RID: 80097
		internal static int __PropertyOffset_260;

		// Token: 0x040138E2 RID: 80098
		[Nullable(2)]
		private TArray<FName> _TempArray19;

		// Token: 0x040138E3 RID: 80099
		internal static int __PropertyOffset_261;

		// Token: 0x040138E4 RID: 80100
		[Nullable(2)]
		private TArray<FName> _TempArray20;

		// Token: 0x040138E5 RID: 80101
		internal static int __PropertyOffset_262;

		// Token: 0x040138E6 RID: 80102
		internal static int __PropertyOffset_263;

		// Token: 0x040138E7 RID: 80103
		internal static int __PropertyOffset_264;

		// Token: 0x040138E8 RID: 80104
		[Nullable(2)]
		private TArray<FName> _TempArray21;

		// Token: 0x040138E9 RID: 80105
		internal static int __PropertyOffset_265;

		// Token: 0x040138EA RID: 80106
		[Nullable(2)]
		private TArray<FName> _TempArray22;

		// Token: 0x040138EB RID: 80107
		internal static int __PropertyOffset_266;

		// Token: 0x040138EC RID: 80108
		[Nullable(2)]
		private TArray<FName> _TempArray23;

		// Token: 0x040138ED RID: 80109
		internal static int __PropertyOffset_267;

		// Token: 0x040138EE RID: 80110
		[Nullable(2)]
		private TArray<FName> _TempArray24;

		// Token: 0x040138EF RID: 80111
		internal static int __PropertyOffset_268;

		// Token: 0x040138F0 RID: 80112
		[Nullable(2)]
		private TArray<FName> _TempArray25;

		// Token: 0x040138F1 RID: 80113
		internal static int __PropertyOffset_269;

		// Token: 0x040138F2 RID: 80114
		[Nullable(2)]
		private TArray<FName> _TempArray26;

		// Token: 0x040138F3 RID: 80115
		internal static int __PropertyOffset_270;

		// Token: 0x040138F4 RID: 80116
		[Nullable(2)]
		private TArray<FName> _TempArray27;

		// Token: 0x040138F5 RID: 80117
		internal static int __PropertyOffset_271;

		// Token: 0x040138F6 RID: 80118
		[Nullable(2)]
		private TArray<FName> _TempArray28;

		// Token: 0x040138F7 RID: 80119
		internal static int __PropertyOffset_272;

		// Token: 0x040138F8 RID: 80120
		[Nullable(2)]
		private TArray<FName> _TempArray29;

		// Token: 0x040138F9 RID: 80121
		internal static int __PropertyOffset_273;

		// Token: 0x040138FA RID: 80122
		[Nullable(2)]
		private TArray<FName> _TempArray30;

		// Token: 0x040138FB RID: 80123
		internal static int __PropertyOffset_274;

		// Token: 0x040138FC RID: 80124
		[Nullable(2)]
		private TArray<FName> _TempArray31;

		// Token: 0x040138FD RID: 80125
		internal static int __PropertyOffset_275;

		// Token: 0x040138FE RID: 80126
		[Nullable(2)]
		private TArray<FName> _TempArray32;

		// Token: 0x040138FF RID: 80127
		internal static int __PropertyOffset_276;

		// Token: 0x04013900 RID: 80128
		[Nullable(2)]
		private TArray<FName> _TempArray33;

		// Token: 0x04013901 RID: 80129
		internal static int __PropertyOffset_277;

		// Token: 0x04013902 RID: 80130
		[Nullable(2)]
		private TArray<FName> _TempArray34;

		// Token: 0x04013903 RID: 80131
		internal static int __PropertyOffset_278;

		// Token: 0x04013904 RID: 80132
		[Nullable(2)]
		private TArray<FName> _TempArray35;

		// Token: 0x04013905 RID: 80133
		internal static int __PropertyOffset_279;

		// Token: 0x04013906 RID: 80134
		[Nullable(2)]
		private TArray<FName> _TempArray36;

		// Token: 0x04013907 RID: 80135
		internal static int __PropertyOffset_280;

		// Token: 0x04013908 RID: 80136
		[Nullable(2)]
		private TArray<FName> _TempArray37;

		// Token: 0x04013909 RID: 80137
		internal static int __PropertyOffset_281;

		// Token: 0x0401390A RID: 80138
		[Nullable(2)]
		private TArray<FName> _TempArray38;

		// Token: 0x0401390B RID: 80139
		internal static int __PropertyOffset_282;

		// Token: 0x0401390C RID: 80140
		[Nullable(2)]
		private TArray<FName> _TempArray39;

		// Token: 0x0401390D RID: 80141
		internal static int __PropertyOffset_283;

		// Token: 0x0401390E RID: 80142
		internal static int __PropertyOffset_284;

		// Token: 0x0401390F RID: 80143
		internal static int __PropertyOffset_285;

		// Token: 0x04013910 RID: 80144
		internal static int __PropertyOffset_286;

		// Token: 0x04013911 RID: 80145
		internal static int __PropertyOffset_287;

		// Token: 0x04013912 RID: 80146
		internal static int __PropertyOffset_288;

		// Token: 0x04013913 RID: 80147
		internal static int __PropertyOffset_289;

		// Token: 0x04013914 RID: 80148
		internal static int __PropertyOffset_290;

		// Token: 0x04013915 RID: 80149
		internal static int __PropertyOffset_291;

		// Token: 0x04013916 RID: 80150
		internal static int __PropertyOffset_292;

		// Token: 0x04013917 RID: 80151
		internal static int __PropertyOffset_293;

		// Token: 0x04013918 RID: 80152
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInterface> _CoreSimMaterials;

		// Token: 0x04013919 RID: 80153
		internal static int __PropertyOffset_294;

		// Token: 0x0401391A RID: 80154
		internal static int __PropertyOffset_295;

		// Token: 0x0401391B RID: 80155
		internal static int __PropertyOffset_296;

		// Token: 0x0401391C RID: 80156
		internal static int __PropertyOffset_297;

		// Token: 0x0401391D RID: 80157
		internal static int __PropertyOffset_298;

		// Token: 0x0401391E RID: 80158
		internal static int __PropertyOffset_299;

		// Token: 0x0401391F RID: 80159
		internal static int __PropertyOffset_300;

		// Token: 0x04013920 RID: 80160
		internal static int __PropertyOffset_301;

		// Token: 0x04013921 RID: 80161
		internal static int __PropertyOffset_302;

		// Token: 0x04013922 RID: 80162
		internal static int __PropertyOffset_303;

		// Token: 0x04013923 RID: 80163
		internal static int __PropertyOffset_304;

		// Token: 0x04013924 RID: 80164
		internal static int __PropertyOffset_305;

		// Token: 0x04013925 RID: 80165
		internal static int __PropertyOffset_306;

		// Token: 0x04013926 RID: 80166
		internal static int __PropertyOffset_307;

		// Token: 0x04013927 RID: 80167
		internal static int __PropertyOffset_308;

		// Token: 0x04013928 RID: 80168
		internal static int __PropertyOffset_309;

		// Token: 0x04013929 RID: 80169
		internal static int __PropertyOffset_310;

		// Token: 0x0401392A RID: 80170
		internal static int __PropertyOffset_311;

		// Token: 0x0401392B RID: 80171
		internal static int __PropertyOffset_312;

		// Token: 0x0401392C RID: 80172
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UNiagaraComponent> _NiagaraSystemsToDrive;

		// Token: 0x0401392D RID: 80173
		internal static int __PropertyOffset_313;

		// Token: 0x0401392E RID: 80174
		internal static int __PropertyOffset_314;

		// Token: 0x0401392F RID: 80175
		internal static int __PropertyOffset_315;

		// Token: 0x04013930 RID: 80176
		internal static int __PropertyOffset_316;

		// Token: 0x04013931 RID: 80177
		internal static int __PropertyOffset_317;

		// Token: 0x04013932 RID: 80178
		internal static int __PropertyOffset_318;

		// Token: 0x04013933 RID: 80179
		internal static int __PropertyOffset_319;

		// Token: 0x04013934 RID: 80180
		internal static int __PropertyOffset_320;

		// Token: 0x04013935 RID: 80181
		internal static int __PropertyOffset_321;

		// Token: 0x04013936 RID: 80182
		internal static int __PropertyOffset_322;

		// Token: 0x04013937 RID: 80183
		[Nullable(2)]
		private WorldSpaceOffset _WorldSpaceOffset;

		// Token: 0x04013938 RID: 80184
		internal static int __PropertyOffset_323;

		// Token: 0x04013939 RID: 80185
		internal static int __PropertyOffset_324;

		// Token: 0x0401393A RID: 80186
		internal static int __PropertyOffset_325;

		// Token: 0x0401393B RID: 80187
		internal static int __PropertyOffset_326;

		// Token: 0x0401393C RID: 80188
		internal static int __PropertyOffset_327;

		// Token: 0x0401393D RID: 80189
		internal static int __PropertyOffset_328;

		// Token: 0x0401393E RID: 80190
		internal static int __PropertyOffset_329;

		// Token: 0x0401393F RID: 80191
		internal static int __PropertyOffset_330;

		// Token: 0x04013940 RID: 80192
		internal static int __PropertyOffset_331;

		// Token: 0x04013941 RID: 80193
		internal static int __PropertyOffset_332;

		// Token: 0x04013942 RID: 80194
		internal static int __PropertyOffset_333;

		// Token: 0x04013943 RID: 80195
		internal static int __PropertyOffset_334;

		// Token: 0x04013944 RID: 80196
		internal static int __PropertyOffset_335;

		// Token: 0x04013945 RID: 80197
		internal static int __PropertyOffset_336;

		// Token: 0x04013946 RID: 80198
		internal static int __PropertyOffset_337;

		// Token: 0x04013947 RID: 80199
		internal static int __PropertyOffset_338;

		// Token: 0x04013948 RID: 80200
		internal static int __PropertyOffset_339;

		// Token: 0x04013949 RID: 80201
		internal static int __PropertyOffset_340;

		// Token: 0x0401394A RID: 80202
		internal static int __PropertyOffset_341;

		// Token: 0x0401394B RID: 80203
		internal static int __PropertyOffset_342;

		// Token: 0x0401394C RID: 80204
		internal static int __PropertyOffset_343;

		// Token: 0x0401394D RID: 80205
		internal static int __PropertyOffset_344;

		// Token: 0x0401394E RID: 80206
		internal static int __PropertyOffset_345;

		// Token: 0x0401394F RID: 80207
		internal static int __PropertyOffset_346;

		// Token: 0x04013950 RID: 80208
		internal static int __PropertyOffset_347;

		// Token: 0x04013951 RID: 80209
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<string, FVector> _boneCachePos;

		// Token: 0x04013952 RID: 80210
		internal static int __PropertyOffset_348;

		// Token: 0x04013953 RID: 80211
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<string, FVector> _boneVelocity;

		// Token: 0x04013954 RID: 80212
		internal static int __PropertyOffset_349;

		// Token: 0x04013955 RID: 80213
		internal static int __PropertyOffset_350;

		// Token: 0x04013956 RID: 80214
		internal static int __PropertyOffset_351;

		// Token: 0x04013957 RID: 80215
		internal static int __PropertyOffset_352;

		// Token: 0x04013958 RID: 80216
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<UPrimitiveComponent, FLinearColor> _primitiveCachePos2D;

		// Token: 0x04013959 RID: 80217
		internal static int __PropertyOffset_353;

		// Token: 0x0401395A RID: 80218
		internal static int __PropertyOffset_354;

		// Token: 0x0401395B RID: 80219
		internal static int __PropertyOffset_355;

		// Token: 0x0401395C RID: 80220
		internal static int __PropertyOffset_356;

		// Token: 0x0401395D RID: 80221
		private static IntPtr __SetLinePaintEnable_NativeFunctionPtr;

		// Token: 0x0401395E RID: 80222
		private static IntPtr __CalcBoneVelocity_NativeFunctionPtr;

		// Token: 0x0401395F RID: 80223
		private static IntPtr __ApplySimCache_NativeFunctionPtr;

		// Token: 0x04013960 RID: 80224
		private static IntPtr __从表格读取覆盖贴图_NativeFunctionPtr;

		// Token: 0x04013961 RID: 80225
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04013962 RID: 80226
		private static IntPtr __RePlay_NativeFunctionPtr;

		// Token: 0x04013963 RID: 80227
		private static IntPtr __LiveActivation_NativeFunctionPtr;

		// Token: 0x04013964 RID: 80228
		private static IntPtr __LiveFluidParams_NativeFunctionPtr;

		// Token: 0x04013965 RID: 80229
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04013966 RID: 80230
		private static IntPtr __Shutdown_NativeFunctionPtr;

		// Token: 0x04013967 RID: 80231
		private static IntPtr __UpdateQualitySwitch_NativeFunctionPtr;

		// Token: 0x04013968 RID: 80232
		private static IntPtr __ReceiveEndPlay_NativeFunctionPtr;

		// Token: 0x04013969 RID: 80233
		private static IntPtr __SelChanged_NativeFunctionPtr;

		// Token: 0x0401396A RID: 80234
		private static IntPtr __PresetSelectionChanged_NativeFunctionPtr;

		// Token: 0x0401396B RID: 80235
		private static IntPtr __PresetSave_NativeFunctionPtr;

		// Token: 0x0200A153 RID: 41299
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __SetLinePaintEnable_FunctionParams
		{
			// Token: 0x04031CFC RID: 204028
			[FieldOffset(0)]
			public bool enable;
		}

		// Token: 0x0200A154 RID: 41300
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 224)]
		protected ref struct __CalcBoneVelocity_FunctionParams
		{
			// Token: 0x04031CFD RID: 204029
			[FieldOffset(0)]
			public IntPtr Skeletal;

			// Token: 0x04031CFE RID: 204030
			[FieldOffset(8)]
			public FVector __Result;
		}

		// Token: 0x0200A155 RID: 41301
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031CFF RID: 204031
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x0200A156 RID: 41302
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 20)]
		protected ref struct __LiveActivation_FunctionParams
		{
			// Token: 0x04031D00 RID: 204032
			[FieldOffset(0)]
			public FName ParamName;

			// Token: 0x04031D01 RID: 204033
			[FieldOffset(12)]
			public float FadeTimeOfBrush;

			// Token: 0x04031D02 RID: 204034
			[FieldOffset(16)]
			public float FadeTimeOfCanvas;
		}

		// Token: 0x0200A157 RID: 41303
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __LiveFluidParams_FunctionParams
		{
			// Token: 0x04031D03 RID: 204035
			[FieldOffset(0)]
			public float BrushSize;
		}

		// Token: 0x0200A158 RID: 41304
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __ReceiveEndPlay_FunctionParams
		{
			// Token: 0x04031D04 RID: 204036
			[FieldOffset(0)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}

		// Token: 0x0200A159 RID: 41305
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __SelChanged_FunctionParams
		{
			// Token: 0x04031D05 RID: 204037
			[FieldOffset(0)]
			public FString SelectedMenuItem;

			// Token: 0x04031D06 RID: 204038
			[FieldOffset(16)]
			public FString SelectedActorName;
		}

		// Token: 0x0200A15A RID: 41306
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __PresetSelectionChanged_FunctionParams
		{
			// Token: 0x04031D07 RID: 204039
			[FieldOffset(0)]
			public FString SelectedPreset;

			// Token: 0x04031D08 RID: 204040
			[FieldOffset(16)]
			public bool ForceAutoLoadPreset;
		}

		// Token: 0x0200A15B RID: 41307
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __PresetSave_FunctionParams
		{
			// Token: 0x04031D09 RID: 204041
			[FieldOffset(0)]
			public FString SelectedProject;

			// Token: 0x04031D0A RID: 204042
			[FieldOffset(16)]
			public FString SelectedPreset;

			// Token: 0x04031D0B RID: 204043
			[FieldOffset(32)]
			public bool OverWriteOrNot;
		}
	}
}

using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Qte
{
	// Token: 0x0200319F RID: 12703
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Data/Qte/SCommonQte_ContinuousClick.SCommonQte_ContinuousClick")]
	[UnrealStructLayout(232, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 228)]
	public class SCommonQte_ContinuousClick : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601F549 RID: 128329 RVA: 0x0092B7A8 File Offset: 0x009299A8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SCommonQte_ContinuousClick._ScriptStructPtr != 0) ? SCommonQte_ContinuousClick._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Qte/SCommonQte_ContinuousClick.SCommonQte_ContinuousClick", ref SCommonQte_ContinuousClick._ScriptStructPtr);
		}

		// Token: 0x170038AF RID: 14511
		// (get) Token: 0x0601F54A RID: 128330 RVA: 0x0092B7CC File Offset: 0x009299CC
		// (set) Token: 0x0601F54B RID: 128331 RVA: 0x0092B7E0 File Offset: 0x009299E0
		public unsafe TEnumAsByte<ECommonQteViewType_SingleButtonContinuousClick> ViewType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_ContinuousClick.__PropertyOffset_ViewType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_ContinuousClick.__PropertyOffset_ViewType) = value;
			}
		}

		// Token: 0x170038B0 RID: 14512
		// (get) Token: 0x0601F54C RID: 128332 RVA: 0x0092B7F8 File Offset: 0x009299F8
		// (set) Token: 0x0601F54D RID: 128333 RVA: 0x0092B83B File Offset: 0x00929A3B
		[Nullable(1)]
		public SCommonQteButton UIConfig
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				SCommonQteButton result;
				if ((result = this._UIConfig) == null)
				{
					result = (this._UIConfig = new SCommonQteButton(base.NativePtr + (IntPtr)SCommonQte_ContinuousClick.__PropertyOffset_UIConfig, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SCommonQteButton.StaticStruct(), base.NativePtr + (IntPtr)SCommonQte_ContinuousClick.__PropertyOffset_UIConfig, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170038B1 RID: 14513
		// (get) Token: 0x0601F54E RID: 128334 RVA: 0x0092B85C File Offset: 0x00929A5C
		// (set) Token: 0x0601F54F RID: 128335 RVA: 0x0092B870 File Offset: 0x00929A70
		public unsafe TEnumAsByte<ECommonQteInteractiveTiming> InteractiveTiming
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_ContinuousClick.__PropertyOffset_InteractiveTiming);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_ContinuousClick.__PropertyOffset_InteractiveTiming) = value;
			}
		}

		// Token: 0x170038B2 RID: 14514
		// (get) Token: 0x0601F550 RID: 128336 RVA: 0x0092B885 File Offset: 0x00929A85
		// (set) Token: 0x0601F551 RID: 128337 RVA: 0x0092B895 File Offset: 0x00929A95
		public unsafe bool IsShowBorder
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_ContinuousClick.__PropertyOffset_IsShowBorder) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_ContinuousClick.__PropertyOffset_IsShowBorder) = (value ? 1 : 0);
			}
		}

		// Token: 0x170038B3 RID: 14515
		// (get) Token: 0x0601F552 RID: 128338 RVA: 0x0092B8A6 File Offset: 0x00929AA6
		// (set) Token: 0x0601F553 RID: 128339 RVA: 0x0092B8B6 File Offset: 0x00929AB6
		public unsafe bool IsShowTip
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_ContinuousClick.__PropertyOffset_IsShowTip) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_ContinuousClick.__PropertyOffset_IsShowTip) = (value ? 1 : 0);
			}
		}

		// Token: 0x170038B4 RID: 14516
		// (get) Token: 0x0601F554 RID: 128340 RVA: 0x0092B8C7 File Offset: 0x00929AC7
		// (set) Token: 0x0601F555 RID: 128341 RVA: 0x0092B8DB File Offset: 0x00929ADB
		[Nullable(1)]
		public unsafe string TipTextId
		{
			[NullableContext(1)]
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SCommonQte_ContinuousClick.__PropertyOffset_TipTextId)));
			}
			[NullableContext(1)]
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SCommonQte_ContinuousClick.__PropertyOffset_TipTextId)), value);
			}
		}

		// Token: 0x170038B5 RID: 14517
		// (get) Token: 0x0601F556 RID: 128342 RVA: 0x0092B8F0 File Offset: 0x00929AF0
		// (set) Token: 0x0601F557 RID: 128343 RVA: 0x0092B900 File Offset: 0x00929B00
		public unsafe float InitialEnergyPercent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_ContinuousClick.__PropertyOffset_InitialEnergyPercent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_ContinuousClick.__PropertyOffset_InitialEnergyPercent) = value;
			}
		}

		// Token: 0x170038B6 RID: 14518
		// (get) Token: 0x0601F558 RID: 128344 RVA: 0x0092B911 File Offset: 0x00929B11
		// (set) Token: 0x0601F559 RID: 128345 RVA: 0x0092B921 File Offset: 0x00929B21
		public unsafe float TargetEnergyPercent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_ContinuousClick.__PropertyOffset_TargetEnergyPercent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_ContinuousClick.__PropertyOffset_TargetEnergyPercent) = value;
			}
		}

		// Token: 0x170038B7 RID: 14519
		// (get) Token: 0x0601F55A RID: 128346 RVA: 0x0092B932 File Offset: 0x00929B32
		// (set) Token: 0x0601F55B RID: 128347 RVA: 0x0092B942 File Offset: 0x00929B42
		public unsafe float DeltaEnergyPercentPerSecond
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_ContinuousClick.__PropertyOffset_DeltaEnergyPercentPerSecond);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_ContinuousClick.__PropertyOffset_DeltaEnergyPercentPerSecond) = value;
			}
		}

		// Token: 0x170038B8 RID: 14520
		// (get) Token: 0x0601F55C RID: 128348 RVA: 0x0092B953 File Offset: 0x00929B53
		// (set) Token: 0x0601F55D RID: 128349 RVA: 0x0092B963 File Offset: 0x00929B63
		public unsafe float DeltaEnergyPercentPerClick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_ContinuousClick.__PropertyOffset_DeltaEnergyPercentPerClick);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_ContinuousClick.__PropertyOffset_DeltaEnergyPercentPerClick) = value;
			}
		}

		// Token: 0x170038B9 RID: 14521
		// (get) Token: 0x0601F55E RID: 128350 RVA: 0x0092B974 File Offset: 0x00929B74
		// (set) Token: 0x0601F55F RID: 128351 RVA: 0x0092B984 File Offset: 0x00929B84
		public unsafe float PerformInterpSpeedForEnergyPercent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_ContinuousClick.__PropertyOffset_PerformInterpSpeedForEnergyPercent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_ContinuousClick.__PropertyOffset_PerformInterpSpeedForEnergyPercent) = value;
			}
		}

		// Token: 0x170038BA RID: 14522
		// (get) Token: 0x0601F560 RID: 128352 RVA: 0x0092B995 File Offset: 0x00929B95
		// (set) Token: 0x0601F561 RID: 128353 RVA: 0x0092B9A5 File Offset: 0x00929BA5
		public unsafe bool IsAttachToActor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_ContinuousClick.__PropertyOffset_IsAttachToActor) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_ContinuousClick.__PropertyOffset_IsAttachToActor) = (value ? 1 : 0);
			}
		}

		// Token: 0x170038BB RID: 14523
		// (get) Token: 0x0601F562 RID: 128354 RVA: 0x0092B9B6 File Offset: 0x00929BB6
		// (set) Token: 0x0601F563 RID: 128355 RVA: 0x0092B9CA File Offset: 0x00929BCA
		public unsafe SCommonQte_Attach AttachConfig
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_ContinuousClick.__PropertyOffset_AttachConfig);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_ContinuousClick.__PropertyOffset_AttachConfig) = value;
			}
		}

		// Token: 0x170038BC RID: 14524
		// (get) Token: 0x0601F564 RID: 128356 RVA: 0x0092B9DF File Offset: 0x00929BDF
		// (set) Token: 0x0601F565 RID: 128357 RVA: 0x0092B9EF File Offset: 0x00929BEF
		public unsafe bool HideProgressBar
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_ContinuousClick.__PropertyOffset_HideProgressBar) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_ContinuousClick.__PropertyOffset_HideProgressBar) = (value ? 1 : 0);
			}
		}

		// Token: 0x170038BD RID: 14525
		// (get) Token: 0x0601F566 RID: 128358 RVA: 0x0092BA00 File Offset: 0x00929C00
		// (set) Token: 0x0601F567 RID: 128359 RVA: 0x0092BA10 File Offset: 0x00929C10
		public unsafe bool ProgressOnBegin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_ContinuousClick.__PropertyOffset_ProgressOnBegin) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_ContinuousClick.__PropertyOffset_ProgressOnBegin) = (value ? 1 : 0);
			}
		}

		// Token: 0x170038BE RID: 14526
		// (get) Token: 0x0601F568 RID: 128360 RVA: 0x0092BA21 File Offset: 0x00929C21
		// (set) Token: 0x0601F569 RID: 128361 RVA: 0x0092BA31 File Offset: 0x00929C31
		public unsafe float MaxComboInterval
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_ContinuousClick.__PropertyOffset_MaxComboInterval);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_ContinuousClick.__PropertyOffset_MaxComboInterval) = value;
			}
		}

		// Token: 0x170038BF RID: 14527
		// (get) Token: 0x0601F56A RID: 128362 RVA: 0x0092BA42 File Offset: 0x00929C42
		// (set) Token: 0x0601F56B RID: 128363 RVA: 0x0092BA52 File Offset: 0x00929C52
		public unsafe float InterpSpeedForEnergyPercent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_ContinuousClick.__PropertyOffset_InterpSpeedForEnergyPercent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_ContinuousClick.__PropertyOffset_InterpSpeedForEnergyPercent) = value;
			}
		}

		// Token: 0x0601F56C RID: 128364 RVA: 0x0092BA63 File Offset: 0x00929C63
		public SCommonQte_ContinuousClick()
		{
		}

		// Token: 0x0601F56D RID: 128365 RVA: 0x0092BA6B File Offset: 0x00929C6B
		protected override IntPtr GetUStructPtr()
		{
			return SCommonQte_ContinuousClick.StaticStruct();
		}

		// Token: 0x0601F56E RID: 128366 RVA: 0x0092BA77 File Offset: 0x00929C77
		[NullableContext(2)]
		public SCommonQte_ContinuousClick(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F56F RID: 128367 RVA: 0x0092BA81 File Offset: 0x00929C81
		public SCommonQte_ContinuousClick(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F570 RID: 128368 RVA: 0x0092BA8C File Offset: 0x00929C8C
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SCommonQte_ContinuousClick(Pointer, false, true);
		}

		// Token: 0x0601F571 RID: 128369 RVA: 0x0092BA96 File Offset: 0x00929C96
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SCommonQte_ContinuousClick(Pointer, MemoryOwner);
		}

		// Token: 0x04010CB8 RID: 68792
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Data/Qte/SCommonQte_ContinuousClick.SCommonQte_ContinuousClick";

		// Token: 0x04010CB9 RID: 68793
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010CBA RID: 68794
		internal static int __PropertyOffset_ViewType;

		// Token: 0x04010CBB RID: 68795
		internal static int __PropertyOffset_UIConfig;

		// Token: 0x04010CBC RID: 68796
		[Nullable(2)]
		private SCommonQteButton _UIConfig;

		// Token: 0x04010CBD RID: 68797
		internal static int __PropertyOffset_InteractiveTiming;

		// Token: 0x04010CBE RID: 68798
		internal static int __PropertyOffset_IsShowBorder;

		// Token: 0x04010CBF RID: 68799
		internal static int __PropertyOffset_IsShowTip;

		// Token: 0x04010CC0 RID: 68800
		internal static int __PropertyOffset_TipTextId;

		// Token: 0x04010CC1 RID: 68801
		internal static int __PropertyOffset_InitialEnergyPercent;

		// Token: 0x04010CC2 RID: 68802
		internal static int __PropertyOffset_TargetEnergyPercent;

		// Token: 0x04010CC3 RID: 68803
		internal static int __PropertyOffset_DeltaEnergyPercentPerSecond;

		// Token: 0x04010CC4 RID: 68804
		internal static int __PropertyOffset_DeltaEnergyPercentPerClick;

		// Token: 0x04010CC5 RID: 68805
		internal static int __PropertyOffset_PerformInterpSpeedForEnergyPercent;

		// Token: 0x04010CC6 RID: 68806
		internal static int __PropertyOffset_IsAttachToActor;

		// Token: 0x04010CC7 RID: 68807
		internal static int __PropertyOffset_AttachConfig;

		// Token: 0x04010CC8 RID: 68808
		internal static int __PropertyOffset_HideProgressBar;

		// Token: 0x04010CC9 RID: 68809
		internal static int __PropertyOffset_ProgressOnBegin;

		// Token: 0x04010CCA RID: 68810
		internal static int __PropertyOffset_MaxComboInterval;

		// Token: 0x04010CCB RID: 68811
		internal static int __PropertyOffset_InterpSpeedForEnergyPercent;
	}
}

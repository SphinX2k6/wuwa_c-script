using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Qte
{
	// Token: 0x0200319E RID: 12702
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Data/Qte/SCommonQte_Base.SCommonQte_Base")]
	[UnrealStructLayout(976, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 976)]
	public class SCommonQte_Base : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601F530 RID: 128304 RVA: 0x0092B4C7 File Offset: 0x009296C7
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SCommonQte_Base._ScriptStructPtr != 0) ? SCommonQte_Base._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Qte/SCommonQte_Base.SCommonQte_Base", ref SCommonQte_Base._ScriptStructPtr);
		}

		// Token: 0x170038A6 RID: 14502
		// (get) Token: 0x0601F531 RID: 128305 RVA: 0x0092B4EB File Offset: 0x009296EB
		// (set) Token: 0x0601F532 RID: 128306 RVA: 0x0092B4FF File Offset: 0x009296FF
		[Nullable(0)]
		public unsafe TEnumAsByte<ECommonQteType> QteType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_Base.__PropertyOffset_QteType);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_Base.__PropertyOffset_QteType) = value;
			}
		}

		// Token: 0x170038A7 RID: 14503
		// (get) Token: 0x0601F533 RID: 128307 RVA: 0x0092B514 File Offset: 0x00929714
		// (set) Token: 0x0601F534 RID: 128308 RVA: 0x0092B524 File Offset: 0x00929724
		public unsafe float Duration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_Base.__PropertyOffset_Duration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_Base.__PropertyOffset_Duration) = value;
			}
		}

		// Token: 0x170038A8 RID: 14504
		// (get) Token: 0x0601F535 RID: 128309 RVA: 0x0092B535 File Offset: 0x00929735
		// (set) Token: 0x0601F536 RID: 128310 RVA: 0x0092B545 File Offset: 0x00929745
		public unsafe float LeastDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_Base.__PropertyOffset_LeastDuration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_Base.__PropertyOffset_LeastDuration) = value;
			}
		}

		// Token: 0x170038A9 RID: 14505
		// (get) Token: 0x0601F537 RID: 128311 RVA: 0x0092B556 File Offset: 0x00929756
		// (set) Token: 0x0601F538 RID: 128312 RVA: 0x0092B566 File Offset: 0x00929766
		public unsafe float TimeDilation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_Base.__PropertyOffset_TimeDilation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_Base.__PropertyOffset_TimeDilation) = value;
			}
		}

		// Token: 0x170038AA RID: 14506
		// (get) Token: 0x0601F539 RID: 128313 RVA: 0x0092B578 File Offset: 0x00929778
		// (set) Token: 0x0601F53A RID: 128314 RVA: 0x0092B5BB File Offset: 0x009297BB
		public SCommonQte_SingleClick SingleClickConfig
		{
			get
			{
				base.FastCheckIsValid();
				SCommonQte_SingleClick result;
				if ((result = this._SingleClickConfig) == null)
				{
					result = (this._SingleClickConfig = new SCommonQte_SingleClick(base.NativePtr + (IntPtr)SCommonQte_Base.__PropertyOffset_SingleClickConfig, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SCommonQte_SingleClick.StaticStruct(), base.NativePtr + (IntPtr)SCommonQte_Base.__PropertyOffset_SingleClickConfig, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170038AB RID: 14507
		// (get) Token: 0x0601F53B RID: 128315 RVA: 0x0092B5DC File Offset: 0x009297DC
		// (set) Token: 0x0601F53C RID: 128316 RVA: 0x0092B61F File Offset: 0x0092981F
		public SCommonQte_ContinuousClick ContinuousClickConfig
		{
			get
			{
				base.FastCheckIsValid();
				SCommonQte_ContinuousClick result;
				if ((result = this._ContinuousClickConfig) == null)
				{
					result = (this._ContinuousClickConfig = new SCommonQte_ContinuousClick(base.NativePtr + (IntPtr)SCommonQte_Base.__PropertyOffset_ContinuousClickConfig, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SCommonQte_ContinuousClick.StaticStruct(), base.NativePtr + (IntPtr)SCommonQte_Base.__PropertyOffset_ContinuousClickConfig, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170038AC RID: 14508
		// (get) Token: 0x0601F53D RID: 128317 RVA: 0x0092B640 File Offset: 0x00929840
		// (set) Token: 0x0601F53E RID: 128318 RVA: 0x0092B683 File Offset: 0x00929883
		public SCommonQte_Drag DragConfig
		{
			get
			{
				base.FastCheckIsValid();
				SCommonQte_Drag result;
				if ((result = this._DragConfig) == null)
				{
					result = (this._DragConfig = new SCommonQte_Drag(base.NativePtr + (IntPtr)SCommonQte_Base.__PropertyOffset_DragConfig, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SCommonQte_Drag.StaticStruct(), base.NativePtr + (IntPtr)SCommonQte_Base.__PropertyOffset_DragConfig, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170038AD RID: 14509
		// (get) Token: 0x0601F53F RID: 128319 RVA: 0x0092B6A4 File Offset: 0x009298A4
		// (set) Token: 0x0601F540 RID: 128320 RVA: 0x0092B6E7 File Offset: 0x009298E7
		public SCommonQte_LongPress LongPressConfig
		{
			get
			{
				base.FastCheckIsValid();
				SCommonQte_LongPress result;
				if ((result = this._LongPressConfig) == null)
				{
					result = (this._LongPressConfig = new SCommonQte_LongPress(base.NativePtr + (IntPtr)SCommonQte_Base.__PropertyOffset_LongPressConfig, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SCommonQte_LongPress.StaticStruct(), base.NativePtr + (IntPtr)SCommonQte_Base.__PropertyOffset_LongPressConfig, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170038AE RID: 14510
		// (get) Token: 0x0601F541 RID: 128321 RVA: 0x0092B708 File Offset: 0x00929908
		// (set) Token: 0x0601F542 RID: 128322 RVA: 0x0092B74B File Offset: 0x0092994B
		public SCommonQte_SelectOption SelectOptionConfig
		{
			get
			{
				base.FastCheckIsValid();
				SCommonQte_SelectOption result;
				if ((result = this._SelectOptionConfig) == null)
				{
					result = (this._SelectOptionConfig = new SCommonQte_SelectOption(base.NativePtr + (IntPtr)SCommonQte_Base.__PropertyOffset_SelectOptionConfig, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SCommonQte_SelectOption.StaticStruct(), base.NativePtr + (IntPtr)SCommonQte_Base.__PropertyOffset_SelectOptionConfig, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601F543 RID: 128323 RVA: 0x0092B76C File Offset: 0x0092996C
		public SCommonQte_Base()
		{
		}

		// Token: 0x0601F544 RID: 128324 RVA: 0x0092B774 File Offset: 0x00929974
		protected override IntPtr GetUStructPtr()
		{
			return SCommonQte_Base.StaticStruct();
		}

		// Token: 0x0601F545 RID: 128325 RVA: 0x0092B780 File Offset: 0x00929980
		[NullableContext(2)]
		public SCommonQte_Base(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F546 RID: 128326 RVA: 0x0092B78A File Offset: 0x0092998A
		public SCommonQte_Base(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F547 RID: 128327 RVA: 0x0092B795 File Offset: 0x00929995
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SCommonQte_Base(Pointer, false, true);
		}

		// Token: 0x0601F548 RID: 128328 RVA: 0x0092B79F File Offset: 0x0092999F
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SCommonQte_Base(Pointer, MemoryOwner);
		}

		// Token: 0x04010CA8 RID: 68776
		public const string __ObjectPath = "/Game/Aki/Data/Qte/SCommonQte_Base.SCommonQte_Base";

		// Token: 0x04010CA9 RID: 68777
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010CAA RID: 68778
		internal static int __PropertyOffset_QteType;

		// Token: 0x04010CAB RID: 68779
		internal static int __PropertyOffset_Duration;

		// Token: 0x04010CAC RID: 68780
		internal static int __PropertyOffset_LeastDuration;

		// Token: 0x04010CAD RID: 68781
		internal static int __PropertyOffset_TimeDilation;

		// Token: 0x04010CAE RID: 68782
		internal static int __PropertyOffset_SingleClickConfig;

		// Token: 0x04010CAF RID: 68783
		[Nullable(2)]
		private SCommonQte_SingleClick _SingleClickConfig;

		// Token: 0x04010CB0 RID: 68784
		internal static int __PropertyOffset_ContinuousClickConfig;

		// Token: 0x04010CB1 RID: 68785
		[Nullable(2)]
		private SCommonQte_ContinuousClick _ContinuousClickConfig;

		// Token: 0x04010CB2 RID: 68786
		internal static int __PropertyOffset_DragConfig;

		// Token: 0x04010CB3 RID: 68787
		[Nullable(2)]
		private SCommonQte_Drag _DragConfig;

		// Token: 0x04010CB4 RID: 68788
		internal static int __PropertyOffset_LongPressConfig;

		// Token: 0x04010CB5 RID: 68789
		[Nullable(2)]
		private SCommonQte_LongPress _LongPressConfig;

		// Token: 0x04010CB6 RID: 68790
		internal static int __PropertyOffset_SelectOptionConfig;

		// Token: 0x04010CB7 RID: 68791
		[Nullable(2)]
		private SCommonQte_SelectOption _SelectOptionConfig;
	}
}

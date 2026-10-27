using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.QuickTimeAction.Customization
{
	// Token: 0x02003EBF RID: 16063
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/QuickTimeAction/Customization/SQtaCustomization_LimitedHold.SQtaCustomization_LimitedHold")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class SQtaCustomization_LimitedHold : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060289F6 RID: 166390 RVA: 0x009B0AE2 File Offset: 0x009AECE2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SQtaCustomization_LimitedHold._ScriptStructPtr != 0) ? SQtaCustomization_LimitedHold._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/QuickTimeAction/Customization/SQtaCustomization_LimitedHold.SQtaCustomization_LimitedHold", ref SQtaCustomization_LimitedHold._ScriptStructPtr);
		}

		// Token: 0x17005EC0 RID: 24256
		// (get) Token: 0x060289F7 RID: 166391 RVA: 0x009B0B06 File Offset: 0x009AED06
		// (set) Token: 0x060289F8 RID: 166392 RVA: 0x009B0B16 File Offset: 0x009AED16
		public unsafe float TimeoutOnPress
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQtaCustomization_LimitedHold.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQtaCustomization_LimitedHold.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17005EC1 RID: 24257
		// (get) Token: 0x060289F9 RID: 166393 RVA: 0x009B0B27 File Offset: 0x009AED27
		// (set) Token: 0x060289FA RID: 166394 RVA: 0x009B0B37 File Offset: 0x009AED37
		public unsafe float TimeoutOnIdle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQtaCustomization_LimitedHold.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQtaCustomization_LimitedHold.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17005EC2 RID: 24258
		// (get) Token: 0x060289FB RID: 166395 RVA: 0x009B0B48 File Offset: 0x009AED48
		// (set) Token: 0x060289FC RID: 166396 RVA: 0x009B0B58 File Offset: 0x009AED58
		public unsafe int TimesLimit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQtaCustomization_LimitedHold.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQtaCustomization_LimitedHold.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17005EC3 RID: 24259
		// (get) Token: 0x060289FD RID: 166397 RVA: 0x009B0B69 File Offset: 0x009AED69
		// (set) Token: 0x060289FE RID: 166398 RVA: 0x009B0B7D File Offset: 0x009AED7D
		[Nullable(0)]
		public unsafe TEnumAsByte<EQtaCustomization_ProgressResetType> MainProgressResetType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SQtaCustomization_LimitedHold.__PropertyOffset_3);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SQtaCustomization_LimitedHold.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17005EC4 RID: 24260
		// (get) Token: 0x060289FF RID: 166399 RVA: 0x009B0B94 File Offset: 0x009AED94
		// (set) Token: 0x06028A00 RID: 166400 RVA: 0x009B0BD7 File Offset: 0x009AEDD7
		public SQtaCustomizationParam_Progress MainProgress
		{
			get
			{
				base.FastCheckIsValid();
				SQtaCustomizationParam_Progress result;
				if ((result = this._MainProgress) == null)
				{
					result = (this._MainProgress = new SQtaCustomizationParam_Progress(base.NativePtr + (IntPtr)SQtaCustomization_LimitedHold.__PropertyOffset_4, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SQtaCustomizationParam_Progress.StaticStruct(), base.NativePtr + (IntPtr)SQtaCustomization_LimitedHold.__PropertyOffset_4, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005EC5 RID: 24261
		// (get) Token: 0x06028A01 RID: 166401 RVA: 0x009B0BF8 File Offset: 0x009AEDF8
		// (set) Token: 0x06028A02 RID: 166402 RVA: 0x009B0C3B File Offset: 0x009AEE3B
		public TArray<SQtaCustomizationParam_BgBar> ProgressList
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SQtaCustomizationParam_BgBar> result;
				if ((result = this._ProgressList) == null)
				{
					result = (this._ProgressList = new TArray<SQtaCustomizationParam_BgBar>(base.NativePtr + (IntPtr)SQtaCustomization_LimitedHold.__PropertyOffset_5, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ProgressList.CopyAssign(value);
			}
		}

		// Token: 0x17005EC6 RID: 24262
		// (get) Token: 0x06028A03 RID: 166403 RVA: 0x009B0C4C File Offset: 0x009AEE4C
		// (set) Token: 0x06028A04 RID: 166404 RVA: 0x009B0C8F File Offset: 0x009AEE8F
		public TArray<SQtaCustomizationParam_Event> SpeedTriggerList
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SQtaCustomizationParam_Event> result;
				if ((result = this._SpeedTriggerList) == null)
				{
					result = (this._SpeedTriggerList = new TArray<SQtaCustomizationParam_Event>(base.NativePtr + (IntPtr)SQtaCustomization_LimitedHold.__PropertyOffset_6, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SpeedTriggerList.CopyAssign(value);
			}
		}

		// Token: 0x06028A05 RID: 166405 RVA: 0x009B0C9D File Offset: 0x009AEE9D
		public SQtaCustomization_LimitedHold()
		{
		}

		// Token: 0x06028A06 RID: 166406 RVA: 0x009B0CA5 File Offset: 0x009AEEA5
		public SQtaCustomization_LimitedHold(float TimeoutOnPress, float TimeoutOnIdle, int TimesLimit, [Nullable(0)] TEnumAsByte<EQtaCustomization_ProgressResetType> MainProgressResetType, SQtaCustomizationParam_Progress MainProgress, TArray<SQtaCustomizationParam_BgBar> ProgressList, TArray<SQtaCustomizationParam_Event> SpeedTriggerList)
		{
			this.TimeoutOnPress = TimeoutOnPress;
			this.TimeoutOnIdle = TimeoutOnIdle;
			this.TimesLimit = TimesLimit;
			this.MainProgressResetType = MainProgressResetType;
			this.MainProgress = MainProgress;
			this.ProgressList = ProgressList;
			this.SpeedTriggerList = SpeedTriggerList;
		}

		// Token: 0x06028A07 RID: 166407 RVA: 0x009B0CE2 File Offset: 0x009AEEE2
		protected override IntPtr GetUStructPtr()
		{
			return SQtaCustomization_LimitedHold.StaticStruct();
		}

		// Token: 0x06028A08 RID: 166408 RVA: 0x009B0CEE File Offset: 0x009AEEEE
		[NullableContext(2)]
		public SQtaCustomization_LimitedHold(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06028A09 RID: 166409 RVA: 0x009B0CF8 File Offset: 0x009AEEF8
		public SQtaCustomization_LimitedHold(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06028A0A RID: 166410 RVA: 0x009B0D03 File Offset: 0x009AEF03
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SQtaCustomization_LimitedHold(Pointer, false, true);
		}

		// Token: 0x06028A0B RID: 166411 RVA: 0x009B0D0D File Offset: 0x009AEF0D
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SQtaCustomization_LimitedHold(Pointer, MemoryOwner);
		}

		// Token: 0x04014BBD RID: 84925
		public const string __ObjectPath = "/Game/Aki/Data/QuickTimeAction/Customization/SQtaCustomization_LimitedHold.SQtaCustomization_LimitedHold";

		// Token: 0x04014BBE RID: 84926
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014BBF RID: 84927
		internal static int __PropertyOffset_0;

		// Token: 0x04014BC0 RID: 84928
		internal static int __PropertyOffset_1;

		// Token: 0x04014BC1 RID: 84929
		internal static int __PropertyOffset_2;

		// Token: 0x04014BC2 RID: 84930
		internal static int __PropertyOffset_3;

		// Token: 0x04014BC3 RID: 84931
		internal static int __PropertyOffset_4;

		// Token: 0x04014BC4 RID: 84932
		[Nullable(2)]
		private SQtaCustomizationParam_Progress _MainProgress;

		// Token: 0x04014BC5 RID: 84933
		internal static int __PropertyOffset_5;

		// Token: 0x04014BC6 RID: 84934
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SQtaCustomizationParam_BgBar> _ProgressList;

		// Token: 0x04014BC7 RID: 84935
		internal static int __PropertyOffset_6;

		// Token: 0x04014BC8 RID: 84936
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SQtaCustomizationParam_Event> _SpeedTriggerList;
	}
}

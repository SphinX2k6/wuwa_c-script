using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.QuickTimeAction.Customization
{
	// Token: 0x0200318B RID: 12683
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/QuickTimeAction/Customization/SQtaCustomization_LimitedHold.SQtaCustomization_LimitedHold")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class SQtaCustomization_LimitedHold : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601F48C RID: 128140 RVA: 0x0092A54B File Offset: 0x0092874B
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SQtaCustomization_LimitedHold._ScriptStructPtr != 0) ? SQtaCustomization_LimitedHold._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/QuickTimeAction/Customization/SQtaCustomization_LimitedHold.SQtaCustomization_LimitedHold", ref SQtaCustomization_LimitedHold._ScriptStructPtr);
		}

		// Token: 0x17003870 RID: 14448
		// (get) Token: 0x0601F48D RID: 128141 RVA: 0x0092A56F File Offset: 0x0092876F
		// (set) Token: 0x0601F48E RID: 128142 RVA: 0x0092A57F File Offset: 0x0092877F
		public unsafe float TimeoutOnPress
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQtaCustomization_LimitedHold.__PropertyOffset_TimeoutOnPress);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQtaCustomization_LimitedHold.__PropertyOffset_TimeoutOnPress) = value;
			}
		}

		// Token: 0x17003871 RID: 14449
		// (get) Token: 0x0601F48F RID: 128143 RVA: 0x0092A590 File Offset: 0x00928790
		// (set) Token: 0x0601F490 RID: 128144 RVA: 0x0092A5A0 File Offset: 0x009287A0
		public unsafe float TimeoutOnIdle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQtaCustomization_LimitedHold.__PropertyOffset_TimeoutOnIdle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQtaCustomization_LimitedHold.__PropertyOffset_TimeoutOnIdle) = value;
			}
		}

		// Token: 0x17003872 RID: 14450
		// (get) Token: 0x0601F491 RID: 128145 RVA: 0x0092A5B1 File Offset: 0x009287B1
		// (set) Token: 0x0601F492 RID: 128146 RVA: 0x0092A5C1 File Offset: 0x009287C1
		public unsafe int TimesLimit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQtaCustomization_LimitedHold.__PropertyOffset_TimesLimit);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQtaCustomization_LimitedHold.__PropertyOffset_TimesLimit) = value;
			}
		}

		// Token: 0x17003873 RID: 14451
		// (get) Token: 0x0601F493 RID: 128147 RVA: 0x0092A5D2 File Offset: 0x009287D2
		// (set) Token: 0x0601F494 RID: 128148 RVA: 0x0092A5E6 File Offset: 0x009287E6
		[Nullable(0)]
		public unsafe TEnumAsByte<EQtaCustomization_ProgressResetType> MainProgressResetType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SQtaCustomization_LimitedHold.__PropertyOffset_MainProgressResetType);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SQtaCustomization_LimitedHold.__PropertyOffset_MainProgressResetType) = value;
			}
		}

		// Token: 0x17003874 RID: 14452
		// (get) Token: 0x0601F495 RID: 128149 RVA: 0x0092A5FC File Offset: 0x009287FC
		// (set) Token: 0x0601F496 RID: 128150 RVA: 0x0092A63F File Offset: 0x0092883F
		public SQtaCustomizationParam_Progress MainProgress
		{
			get
			{
				base.FastCheckIsValid();
				SQtaCustomizationParam_Progress result;
				if ((result = this._MainProgress) == null)
				{
					result = (this._MainProgress = new SQtaCustomizationParam_Progress(base.NativePtr + (IntPtr)SQtaCustomization_LimitedHold.__PropertyOffset_MainProgress, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SQtaCustomizationParam_Progress.StaticStruct(), base.NativePtr + (IntPtr)SQtaCustomization_LimitedHold.__PropertyOffset_MainProgress, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003875 RID: 14453
		// (get) Token: 0x0601F497 RID: 128151 RVA: 0x0092A660 File Offset: 0x00928860
		// (set) Token: 0x0601F498 RID: 128152 RVA: 0x0092A6A3 File Offset: 0x009288A3
		public TArray<SQtaCustomizationParam_BgBar> ProgressList
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SQtaCustomizationParam_BgBar> result;
				if ((result = this._ProgressList) == null)
				{
					result = (this._ProgressList = new TArray<SQtaCustomizationParam_BgBar>(base.NativePtr + (IntPtr)SQtaCustomization_LimitedHold.__PropertyOffset_ProgressList, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ProgressList.CopyAssign(value);
			}
		}

		// Token: 0x17003876 RID: 14454
		// (get) Token: 0x0601F499 RID: 128153 RVA: 0x0092A6B4 File Offset: 0x009288B4
		// (set) Token: 0x0601F49A RID: 128154 RVA: 0x0092A6F7 File Offset: 0x009288F7
		public TArray<SQtaCustomizationParam_Event> SpeedTriggerList
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SQtaCustomizationParam_Event> result;
				if ((result = this._SpeedTriggerList) == null)
				{
					result = (this._SpeedTriggerList = new TArray<SQtaCustomizationParam_Event>(base.NativePtr + (IntPtr)SQtaCustomization_LimitedHold.__PropertyOffset_SpeedTriggerList, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SpeedTriggerList.CopyAssign(value);
			}
		}

		// Token: 0x0601F49B RID: 128155 RVA: 0x0092A705 File Offset: 0x00928905
		public SQtaCustomization_LimitedHold()
		{
		}

		// Token: 0x0601F49C RID: 128156 RVA: 0x0092A70D File Offset: 0x0092890D
		protected override IntPtr GetUStructPtr()
		{
			return SQtaCustomization_LimitedHold.StaticStruct();
		}

		// Token: 0x0601F49D RID: 128157 RVA: 0x0092A719 File Offset: 0x00928919
		[NullableContext(2)]
		public SQtaCustomization_LimitedHold(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F49E RID: 128158 RVA: 0x0092A723 File Offset: 0x00928923
		public SQtaCustomization_LimitedHold(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F49F RID: 128159 RVA: 0x0092A72E File Offset: 0x0092892E
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SQtaCustomization_LimitedHold(Pointer, false, true);
		}

		// Token: 0x0601F4A0 RID: 128160 RVA: 0x0092A738 File Offset: 0x00928938
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SQtaCustomization_LimitedHold(Pointer, MemoryOwner);
		}

		// Token: 0x04010BE2 RID: 68578
		public const string __ObjectPath = "/Game/Aki/Data/QuickTimeAction/Customization/SQtaCustomization_LimitedHold.SQtaCustomization_LimitedHold";

		// Token: 0x04010BE3 RID: 68579
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010BE4 RID: 68580
		internal static int __PropertyOffset_TimeoutOnPress;

		// Token: 0x04010BE5 RID: 68581
		internal static int __PropertyOffset_TimeoutOnIdle;

		// Token: 0x04010BE6 RID: 68582
		internal static int __PropertyOffset_TimesLimit;

		// Token: 0x04010BE7 RID: 68583
		internal static int __PropertyOffset_MainProgressResetType;

		// Token: 0x04010BE8 RID: 68584
		internal static int __PropertyOffset_MainProgress;

		// Token: 0x04010BE9 RID: 68585
		[Nullable(2)]
		private SQtaCustomizationParam_Progress _MainProgress;

		// Token: 0x04010BEA RID: 68586
		internal static int __PropertyOffset_ProgressList;

		// Token: 0x04010BEB RID: 68587
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SQtaCustomizationParam_BgBar> _ProgressList;

		// Token: 0x04010BEC RID: 68588
		internal static int __PropertyOffset_SpeedTriggerList;

		// Token: 0x04010BED RID: 68589
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SQtaCustomizationParam_Event> _SpeedTriggerList;
	}
}

using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;
using AkiClient.Game.Aki.Data.Qte;
using AkiClient.Game.Aki.Data.QuickTimeAction.Customization;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.QuickTimeAction
{
	// Token: 0x0200317C RID: 12668
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/QuickTimeAction/SQtaBase.SQtaBase")]
	[UnrealStructLayout(176, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 176)]
	public class SQtaBase : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601F3D3 RID: 127955 RVA: 0x009295AD File Offset: 0x009277AD
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SQtaBase._ScriptStructPtr != 0) ? SQtaBase._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/QuickTimeAction/SQtaBase.SQtaBase", ref SQtaBase._ScriptStructPtr);
		}

		// Token: 0x1700383E RID: 14398
		// (get) Token: 0x0601F3D4 RID: 127956 RVA: 0x009295D1 File Offset: 0x009277D1
		// (set) Token: 0x0601F3D5 RID: 127957 RVA: 0x009295E1 File Offset: 0x009277E1
		public unsafe bool IsBlockFightInput
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQtaBase.__PropertyOffset_IsBlockFightInput) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQtaBase.__PropertyOffset_IsBlockFightInput) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700383F RID: 14399
		// (get) Token: 0x0601F3D6 RID: 127958 RVA: 0x009295F2 File Offset: 0x009277F2
		// (set) Token: 0x0601F3D7 RID: 127959 RVA: 0x00929602 File Offset: 0x00927802
		public unsafe bool EnableInputDistributeFilter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQtaBase.__PropertyOffset_EnableInputDistributeFilter) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQtaBase.__PropertyOffset_EnableInputDistributeFilter) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003840 RID: 14400
		// (get) Token: 0x0601F3D8 RID: 127960 RVA: 0x00929614 File Offset: 0x00927814
		// (set) Token: 0x0601F3D9 RID: 127961 RVA: 0x00929657 File Offset: 0x00927857
		public SQtaInputDistribute InputDistributeFilterConfig
		{
			get
			{
				base.FastCheckIsValid();
				SQtaInputDistribute result;
				if ((result = this._InputDistributeFilterConfig) == null)
				{
					result = (this._InputDistributeFilterConfig = new SQtaInputDistribute(base.NativePtr + (IntPtr)SQtaBase.__PropertyOffset_InputDistributeFilterConfig, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SQtaInputDistribute.StaticStruct(), base.NativePtr + (IntPtr)SQtaBase.__PropertyOffset_InputDistributeFilterConfig, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003841 RID: 14401
		// (get) Token: 0x0601F3DA RID: 127962 RVA: 0x00929678 File Offset: 0x00927878
		// (set) Token: 0x0601F3DB RID: 127963 RVA: 0x00929688 File Offset: 0x00927888
		public unsafe bool HideAllBattleUi
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQtaBase.__PropertyOffset_HideAllBattleUi) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQtaBase.__PropertyOffset_HideAllBattleUi) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003842 RID: 14402
		// (get) Token: 0x0601F3DC RID: 127964 RVA: 0x00929699 File Offset: 0x00927899
		// (set) Token: 0x0601F3DD RID: 127965 RVA: 0x009296A9 File Offset: 0x009278A9
		public unsafe bool HideAllBattleUiInMobile
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQtaBase.__PropertyOffset_HideAllBattleUiInMobile) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQtaBase.__PropertyOffset_HideAllBattleUiInMobile) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003843 RID: 14403
		// (get) Token: 0x0601F3DE RID: 127966 RVA: 0x009296BC File Offset: 0x009278BC
		// (set) Token: 0x0601F3DF RID: 127967 RVA: 0x009296FF File Offset: 0x009278FF
		[Nullable(new byte[]
		{
			1,
			0
		})]
		public TArray<TEnumAsByte<EBattleUIChild>> HideUiElement
		{
			[return: Nullable(new byte[]
			{
				1,
				0
			})]
			get
			{
				base.FastCheckIsValid();
				TArray<TEnumAsByte<EBattleUIChild>> result;
				if ((result = this._HideUiElement) == null)
				{
					result = (this._HideUiElement = new TArray<TEnumAsByte<EBattleUIChild>>(base.NativePtr + (IntPtr)SQtaBase.__PropertyOffset_HideUiElement, base.MemoryOwner ?? this));
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
				this.HideUiElement.CopyAssign(value);
			}
		}

		// Token: 0x17003844 RID: 14404
		// (get) Token: 0x0601F3E0 RID: 127968 RVA: 0x00929710 File Offset: 0x00927910
		// (set) Token: 0x0601F3E1 RID: 127969 RVA: 0x00929753 File Offset: 0x00927953
		public TArray<SCommonQteButton> InputConfig
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SCommonQteButton> result;
				if ((result = this._InputConfig) == null)
				{
					result = (this._InputConfig = new TArray<SCommonQteButton>(base.NativePtr + (IntPtr)SQtaBase.__PropertyOffset_InputConfig, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.InputConfig.CopyAssign(value);
			}
		}

		// Token: 0x17003845 RID: 14405
		// (get) Token: 0x0601F3E2 RID: 127970 RVA: 0x00929761 File Offset: 0x00927961
		// (set) Token: 0x0601F3E3 RID: 127971 RVA: 0x00929771 File Offset: 0x00927971
		public unsafe float Duration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQtaBase.__PropertyOffset_Duration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQtaBase.__PropertyOffset_Duration) = value;
			}
		}

		// Token: 0x17003846 RID: 14406
		// (get) Token: 0x0601F3E4 RID: 127972 RVA: 0x00929782 File Offset: 0x00927982
		// (set) Token: 0x0601F3E5 RID: 127973 RVA: 0x00929792 File Offset: 0x00927992
		public unsafe float LeastDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQtaBase.__PropertyOffset_LeastDuration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQtaBase.__PropertyOffset_LeastDuration) = value;
			}
		}

		// Token: 0x17003847 RID: 14407
		// (get) Token: 0x0601F3E6 RID: 127974 RVA: 0x009297A3 File Offset: 0x009279A3
		// (set) Token: 0x0601F3E7 RID: 127975 RVA: 0x009297B3 File Offset: 0x009279B3
		public unsafe float TimeDilation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQtaBase.__PropertyOffset_TimeDilation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQtaBase.__PropertyOffset_TimeDilation) = value;
			}
		}

		// Token: 0x17003848 RID: 14408
		// (get) Token: 0x0601F3E8 RID: 127976 RVA: 0x009297C4 File Offset: 0x009279C4
		// (set) Token: 0x0601F3E9 RID: 127977 RVA: 0x00929807 File Offset: 0x00927A07
		public FGameplayTagContainer ActiveTags
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._ActiveTags) == null)
				{
					result = (this._ActiveTags = new FGameplayTagContainer(base.NativePtr + (IntPtr)SQtaBase.__PropertyOffset_ActiveTags, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)SQtaBase.__PropertyOffset_ActiveTags, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003849 RID: 14409
		// (get) Token: 0x0601F3EA RID: 127978 RVA: 0x00929828 File Offset: 0x00927A28
		// (set) Token: 0x0601F3EB RID: 127979 RVA: 0x0092983C File Offset: 0x00927A3C
		[Nullable(0)]
		public unsafe TEnumAsByte<EQtaType> QtaType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SQtaBase.__PropertyOffset_QtaType);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SQtaBase.__PropertyOffset_QtaType) = value;
			}
		}

		// Token: 0x1700384A RID: 14410
		// (get) Token: 0x0601F3EC RID: 127980 RVA: 0x00929854 File Offset: 0x00927A54
		// (set) Token: 0x0601F3ED RID: 127981 RVA: 0x00929897 File Offset: 0x00927A97
		public SQtaCustomization CustomizationConfig
		{
			get
			{
				base.FastCheckIsValid();
				SQtaCustomization result;
				if ((result = this._CustomizationConfig) == null)
				{
					result = (this._CustomizationConfig = new SQtaCustomization(base.NativePtr + (IntPtr)SQtaBase.__PropertyOffset_CustomizationConfig, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SQtaCustomization.StaticStruct(), base.NativePtr + (IntPtr)SQtaBase.__PropertyOffset_CustomizationConfig, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601F3EE RID: 127982 RVA: 0x009298B8 File Offset: 0x00927AB8
		public SQtaBase()
		{
		}

		// Token: 0x0601F3EF RID: 127983 RVA: 0x009298C0 File Offset: 0x00927AC0
		protected override IntPtr GetUStructPtr()
		{
			return SQtaBase.StaticStruct();
		}

		// Token: 0x0601F3F0 RID: 127984 RVA: 0x009298CC File Offset: 0x00927ACC
		[NullableContext(2)]
		public SQtaBase(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F3F1 RID: 127985 RVA: 0x009298D6 File Offset: 0x00927AD6
		public SQtaBase(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F3F2 RID: 127986 RVA: 0x009298E1 File Offset: 0x00927AE1
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SQtaBase(Pointer, false, true);
		}

		// Token: 0x0601F3F3 RID: 127987 RVA: 0x009298EB File Offset: 0x00927AEB
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SQtaBase(Pointer, MemoryOwner);
		}

		// Token: 0x04010B7C RID: 68476
		public const string __ObjectPath = "/Game/Aki/Data/QuickTimeAction/SQtaBase.SQtaBase";

		// Token: 0x04010B7D RID: 68477
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010B7E RID: 68478
		internal static int __PropertyOffset_IsBlockFightInput;

		// Token: 0x04010B7F RID: 68479
		internal static int __PropertyOffset_EnableInputDistributeFilter;

		// Token: 0x04010B80 RID: 68480
		internal static int __PropertyOffset_InputDistributeFilterConfig;

		// Token: 0x04010B81 RID: 68481
		[Nullable(2)]
		private SQtaInputDistribute _InputDistributeFilterConfig;

		// Token: 0x04010B82 RID: 68482
		internal static int __PropertyOffset_HideAllBattleUi;

		// Token: 0x04010B83 RID: 68483
		internal static int __PropertyOffset_HideAllBattleUiInMobile;

		// Token: 0x04010B84 RID: 68484
		internal static int __PropertyOffset_HideUiElement;

		// Token: 0x04010B85 RID: 68485
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TArray<TEnumAsByte<EBattleUIChild>> _HideUiElement;

		// Token: 0x04010B86 RID: 68486
		internal static int __PropertyOffset_InputConfig;

		// Token: 0x04010B87 RID: 68487
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SCommonQteButton> _InputConfig;

		// Token: 0x04010B88 RID: 68488
		internal static int __PropertyOffset_Duration;

		// Token: 0x04010B89 RID: 68489
		internal static int __PropertyOffset_LeastDuration;

		// Token: 0x04010B8A RID: 68490
		internal static int __PropertyOffset_TimeDilation;

		// Token: 0x04010B8B RID: 68491
		internal static int __PropertyOffset_ActiveTags;

		// Token: 0x04010B8C RID: 68492
		[Nullable(2)]
		private FGameplayTagContainer _ActiveTags;

		// Token: 0x04010B8D RID: 68493
		internal static int __PropertyOffset_QtaType;

		// Token: 0x04010B8E RID: 68494
		internal static int __PropertyOffset_CustomizationConfig;

		// Token: 0x04010B8F RID: 68495
		[Nullable(2)]
		private SQtaCustomization _CustomizationConfig;
	}
}

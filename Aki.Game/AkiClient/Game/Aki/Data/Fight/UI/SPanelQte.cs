using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Fight.UI
{
	// Token: 0x02003F56 RID: 16214
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Fight/UI/SPanelQte.SPanelQte")]
	[UnrealStructLayout(200, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 200)]
	public class SPanelQte : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06029486 RID: 169094 RVA: 0x009C044C File Offset: 0x009BE64C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SPanelQte._ScriptStructPtr != 0) ? SPanelQte._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Fight/UI/SPanelQte.SPanelQte", ref SPanelQte._ScriptStructPtr);
		}

		// Token: 0x1700626B RID: 25195
		// (get) Token: 0x06029487 RID: 169095 RVA: 0x009C0470 File Offset: 0x009BE670
		// (set) Token: 0x06029488 RID: 169096 RVA: 0x009C0484 File Offset: 0x009BE684
		[Nullable(0)]
		public unsafe TEnumAsByte<EPanelQteViewType> ViewType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SPanelQte.__PropertyOffset_0);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SPanelQte.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x1700626C RID: 25196
		// (get) Token: 0x06029489 RID: 169097 RVA: 0x009C0499 File Offset: 0x009BE699
		// (set) Token: 0x0602948A RID: 169098 RVA: 0x009C04A9 File Offset: 0x009BE6A9
		public unsafe float Duration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPanelQte.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPanelQte.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x1700626D RID: 25197
		// (get) Token: 0x0602948B RID: 169099 RVA: 0x009C04BA File Offset: 0x009BE6BA
		// (set) Token: 0x0602948C RID: 169100 RVA: 0x009C04CA File Offset: 0x009BE6CA
		public unsafe float WorldTimeDilation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPanelQte.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPanelQte.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x1700626E RID: 25198
		// (get) Token: 0x0602948D RID: 169101 RVA: 0x009C04DB File Offset: 0x009BE6DB
		// (set) Token: 0x0602948E RID: 169102 RVA: 0x009C04EB File Offset: 0x009BE6EB
		public unsafe int MinSuccessCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPanelQte.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPanelQte.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x1700626F RID: 25199
		// (get) Token: 0x0602948F RID: 169103 RVA: 0x009C04FC File Offset: 0x009BE6FC
		// (set) Token: 0x06029490 RID: 169104 RVA: 0x009C050C File Offset: 0x009BE70C
		public unsafe int MaxSuccessCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPanelQte.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPanelQte.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17006270 RID: 25200
		// (get) Token: 0x06029491 RID: 169105 RVA: 0x009C051D File Offset: 0x009BE71D
		// (set) Token: 0x06029492 RID: 169106 RVA: 0x009C052D File Offset: 0x009BE72D
		public unsafe bool HideAllBattleUi
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPanelQte.__PropertyOffset_5) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPanelQte.__PropertyOffset_5) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006271 RID: 25201
		// (get) Token: 0x06029493 RID: 169107 RVA: 0x009C0540 File Offset: 0x009BE740
		// (set) Token: 0x06029494 RID: 169108 RVA: 0x009C0583 File Offset: 0x009BE783
		[Nullable(new byte[]
		{
			1,
			0
		})]
		public TArray<TEnumAsByte<EBattleUIChild>> HideUIElement
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
				if ((result = this._HideUIElement) == null)
				{
					result = (this._HideUIElement = new TArray<TEnumAsByte<EBattleUIChild>>(base.NativePtr + (IntPtr)SPanelQte.__PropertyOffset_6, base.MemoryOwner ?? this));
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
				this.HideUIElement.CopyAssign(value);
			}
		}

		// Token: 0x17006272 RID: 25202
		// (get) Token: 0x06029495 RID: 169109 RVA: 0x009C0594 File Offset: 0x009BE794
		// (set) Token: 0x06029496 RID: 169110 RVA: 0x009C05D7 File Offset: 0x009BE7D7
		public TArray<SPanelQteAction> SuccessActions
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SPanelQteAction> result;
				if ((result = this._SuccessActions) == null)
				{
					result = (this._SuccessActions = new TArray<SPanelQteAction>(base.NativePtr + (IntPtr)SPanelQte.__PropertyOffset_7, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SuccessActions.CopyAssign(value);
			}
		}

		// Token: 0x17006273 RID: 25203
		// (get) Token: 0x06029497 RID: 169111 RVA: 0x009C05E8 File Offset: 0x009BE7E8
		// (set) Token: 0x06029498 RID: 169112 RVA: 0x009C062B File Offset: 0x009BE82B
		public TArray<SPanelQteAction> FailActions
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SPanelQteAction> result;
				if ((result = this._FailActions) == null)
				{
					result = (this._FailActions = new TArray<SPanelQteAction>(base.NativePtr + (IntPtr)SPanelQte.__PropertyOffset_8, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.FailActions.CopyAssign(value);
			}
		}

		// Token: 0x17006274 RID: 25204
		// (get) Token: 0x06029499 RID: 169113 RVA: 0x009C0639 File Offset: 0x009BE839
		// (set) Token: 0x0602949A RID: 169114 RVA: 0x009C0649 File Offset: 0x009BE849
		public unsafe long BuffOnInput
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPanelQte.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPanelQte.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17006275 RID: 25205
		// (get) Token: 0x0602949B RID: 169115 RVA: 0x009C065A File Offset: 0x009BE85A
		// (set) Token: 0x0602949C RID: 169116 RVA: 0x009C066A File Offset: 0x009BE86A
		public unsafe float BuffCd
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPanelQte.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPanelQte.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17006276 RID: 25206
		// (get) Token: 0x0602949D RID: 169117 RVA: 0x009C067B File Offset: 0x009BE87B
		// (set) Token: 0x0602949E RID: 169118 RVA: 0x009C068B File Offset: 0x009BE88B
		public unsafe bool CameraShakeOnInput
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPanelQte.__PropertyOffset_11) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPanelQte.__PropertyOffset_11) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006277 RID: 25207
		// (get) Token: 0x0602949F RID: 169119 RVA: 0x009C069C File Offset: 0x009BE89C
		// (set) Token: 0x060294A0 RID: 169120 RVA: 0x009C06BB File Offset: 0x009BE8BB
		public TSoftClassPtr<UMatineeCameraShake> CameraShakeType
		{
			get
			{
				return new TSoftClassPtr<UMatineeCameraShake>(base.NativePtr + (IntPtr)SPanelQte.__PropertyOffset_12, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SPanelQte.__PropertyOffset_12, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17006278 RID: 25208
		// (get) Token: 0x060294A1 RID: 169121 RVA: 0x009C06E0 File Offset: 0x009BE8E0
		// (set) Token: 0x060294A2 RID: 169122 RVA: 0x009C06F4 File Offset: 0x009BE8F4
		public unsafe string Action
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SPanelQte.__PropertyOffset_13)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SPanelQte.__PropertyOffset_13)), value);
			}
		}

		// Token: 0x17006279 RID: 25209
		// (get) Token: 0x060294A3 RID: 169123 RVA: 0x009C0709 File Offset: 0x009BE909
		// (set) Token: 0x060294A4 RID: 169124 RVA: 0x009C0728 File Offset: 0x009BE928
		public TSoftObjectPtr<ULGUITexturePackerSpriteData> Icon
		{
			get
			{
				return new TSoftObjectPtr<ULGUITexturePackerSpriteData>(base.NativePtr + (IntPtr)SPanelQte.__PropertyOffset_14, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SPanelQte.__PropertyOffset_14, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x060294A5 RID: 169125 RVA: 0x009C074D File Offset: 0x009BE94D
		public SPanelQte()
		{
		}

		// Token: 0x060294A6 RID: 169126 RVA: 0x009C0758 File Offset: 0x009BE958
		public SPanelQte([Nullable(0)] TEnumAsByte<EPanelQteViewType> ViewType, float Duration, float WorldTimeDilation, int MinSuccessCount, int MaxSuccessCount, bool HideAllBattleUi, [Nullable(new byte[]
		{
			1,
			0
		})] TArray<TEnumAsByte<EBattleUIChild>> HideUIElement, TArray<SPanelQteAction> SuccessActions, TArray<SPanelQteAction> FailActions, long BuffOnInput, float BuffCd, bool CameraShakeOnInput, TSoftClassPtr<UMatineeCameraShake> CameraShakeType, string Action, TSoftObjectPtr<ULGUITexturePackerSpriteData> Icon)
		{
			this.ViewType = ViewType;
			this.Duration = Duration;
			this.WorldTimeDilation = WorldTimeDilation;
			this.MinSuccessCount = MinSuccessCount;
			this.MaxSuccessCount = MaxSuccessCount;
			this.HideAllBattleUi = HideAllBattleUi;
			this.HideUIElement = HideUIElement;
			this.SuccessActions = SuccessActions;
			this.FailActions = FailActions;
			this.BuffOnInput = BuffOnInput;
			this.BuffCd = BuffCd;
			this.CameraShakeOnInput = CameraShakeOnInput;
			this.CameraShakeType = CameraShakeType;
			this.Action = Action;
			this.Icon = Icon;
		}

		// Token: 0x060294A7 RID: 169127 RVA: 0x009C07E0 File Offset: 0x009BE9E0
		protected override IntPtr GetUStructPtr()
		{
			return SPanelQte.StaticStruct();
		}

		// Token: 0x060294A8 RID: 169128 RVA: 0x009C07EC File Offset: 0x009BE9EC
		[NullableContext(2)]
		public SPanelQte(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060294A9 RID: 169129 RVA: 0x009C07F6 File Offset: 0x009BE9F6
		public SPanelQte(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060294AA RID: 169130 RVA: 0x009C0801 File Offset: 0x009BEA01
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SPanelQte(Pointer, false, true);
		}

		// Token: 0x060294AB RID: 169131 RVA: 0x009C080B File Offset: 0x009BEA0B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SPanelQte(Pointer, MemoryOwner);
		}

		// Token: 0x04015267 RID: 86631
		public const string __ObjectPath = "/Game/Aki/Data/Fight/UI/SPanelQte.SPanelQte";

		// Token: 0x04015268 RID: 86632
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04015269 RID: 86633
		internal static int __PropertyOffset_0;

		// Token: 0x0401526A RID: 86634
		internal static int __PropertyOffset_1;

		// Token: 0x0401526B RID: 86635
		internal static int __PropertyOffset_2;

		// Token: 0x0401526C RID: 86636
		internal static int __PropertyOffset_3;

		// Token: 0x0401526D RID: 86637
		internal static int __PropertyOffset_4;

		// Token: 0x0401526E RID: 86638
		internal static int __PropertyOffset_5;

		// Token: 0x0401526F RID: 86639
		internal static int __PropertyOffset_6;

		// Token: 0x04015270 RID: 86640
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TArray<TEnumAsByte<EBattleUIChild>> _HideUIElement;

		// Token: 0x04015271 RID: 86641
		internal static int __PropertyOffset_7;

		// Token: 0x04015272 RID: 86642
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SPanelQteAction> _SuccessActions;

		// Token: 0x04015273 RID: 86643
		internal static int __PropertyOffset_8;

		// Token: 0x04015274 RID: 86644
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SPanelQteAction> _FailActions;

		// Token: 0x04015275 RID: 86645
		internal static int __PropertyOffset_9;

		// Token: 0x04015276 RID: 86646
		internal static int __PropertyOffset_10;

		// Token: 0x04015277 RID: 86647
		internal static int __PropertyOffset_11;

		// Token: 0x04015278 RID: 86648
		internal static int __PropertyOffset_12;

		// Token: 0x04015279 RID: 86649
		internal static int __PropertyOffset_13;

		// Token: 0x0401527A RID: 86650
		internal static int __PropertyOffset_14;
	}
}

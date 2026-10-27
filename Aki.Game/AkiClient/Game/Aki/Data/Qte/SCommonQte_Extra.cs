using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;
using AkiClient.Game.Aki.Render.RuntimeBP.ScreenEffect.Data;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Qte
{
	// Token: 0x02003EDC RID: 16092
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Qte/SCommonQte_Extra.SCommonQte_Extra")]
	[UnrealStructLayout(264, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 264)]
	public class SCommonQte_Extra : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06028B75 RID: 166773 RVA: 0x009B2F38 File Offset: 0x009B1138
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SCommonQte_Extra._ScriptStructPtr != 0) ? SCommonQte_Extra._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Qte/SCommonQte_Extra.SCommonQte_Extra", ref SCommonQte_Extra._ScriptStructPtr);
		}

		// Token: 0x17005F48 RID: 24392
		// (get) Token: 0x06028B76 RID: 166774 RVA: 0x009B2F5C File Offset: 0x009B115C
		// (set) Token: 0x06028B77 RID: 166775 RVA: 0x009B2F6C File Offset: 0x009B116C
		public unsafe bool IsBlockFightInput
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_Extra.__PropertyOffset_0) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_Extra.__PropertyOffset_0) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005F49 RID: 24393
		// (get) Token: 0x06028B78 RID: 166776 RVA: 0x009B2F7D File Offset: 0x009B117D
		// (set) Token: 0x06028B79 RID: 166777 RVA: 0x009B2F8D File Offset: 0x009B118D
		public unsafe bool HideAllBattleUi
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_Extra.__PropertyOffset_1) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_Extra.__PropertyOffset_1) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005F4A RID: 24394
		// (get) Token: 0x06028B7A RID: 166778 RVA: 0x009B2F9E File Offset: 0x009B119E
		// (set) Token: 0x06028B7B RID: 166779 RVA: 0x009B2FAE File Offset: 0x009B11AE
		public unsafe bool ShowMouseCursor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_Extra.__PropertyOffset_2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_Extra.__PropertyOffset_2) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005F4B RID: 24395
		// (get) Token: 0x06028B7C RID: 166780 RVA: 0x009B2FC0 File Offset: 0x009B11C0
		// (set) Token: 0x06028B7D RID: 166781 RVA: 0x009B3003 File Offset: 0x009B1203
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
					result = (this._HideUIElement = new TArray<TEnumAsByte<EBattleUIChild>>(base.NativePtr + (IntPtr)SCommonQte_Extra.__PropertyOffset_3, base.MemoryOwner ?? this));
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

		// Token: 0x17005F4C RID: 24396
		// (get) Token: 0x06028B7E RID: 166782 RVA: 0x009B3011 File Offset: 0x009B1211
		// (set) Token: 0x06028B7F RID: 166783 RVA: 0x009B3030 File Offset: 0x009B1230
		public TSoftObjectPtr<EffectScreenPlayData_C> ScreenEffectType1
		{
			get
			{
				return new TSoftObjectPtr<EffectScreenPlayData_C>(base.NativePtr + (IntPtr)SCommonQte_Extra.__PropertyOffset_4, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SCommonQte_Extra.__PropertyOffset_4, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17005F4D RID: 24397
		// (get) Token: 0x06028B80 RID: 166784 RVA: 0x009B3055 File Offset: 0x009B1255
		// (set) Token: 0x06028B81 RID: 166785 RVA: 0x009B3074 File Offset: 0x009B1274
		public TSoftObjectPtr<EffectModelPostProcess> ScreenEffectType2
		{
			get
			{
				return new TSoftObjectPtr<EffectModelPostProcess>(base.NativePtr + (IntPtr)SCommonQte_Extra.__PropertyOffset_5, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SCommonQte_Extra.__PropertyOffset_5, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17005F4E RID: 24398
		// (get) Token: 0x06028B82 RID: 166786 RVA: 0x009B3099 File Offset: 0x009B1299
		// (set) Token: 0x06028B83 RID: 166787 RVA: 0x009B30B8 File Offset: 0x009B12B8
		public TSoftClassPtr<UMatineeCameraShake> CameraShake
		{
			get
			{
				return new TSoftClassPtr<UMatineeCameraShake>(base.NativePtr + (IntPtr)SCommonQte_Extra.__PropertyOffset_6, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SCommonQte_Extra.__PropertyOffset_6, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17005F4F RID: 24399
		// (get) Token: 0x06028B84 RID: 166788 RVA: 0x009B30DD File Offset: 0x009B12DD
		// (set) Token: 0x06028B85 RID: 166789 RVA: 0x009B30FC File Offset: 0x009B12FC
		public TSoftObjectPtr<UKuroForceFeedbackEffect> GamepadShake
		{
			get
			{
				return new TSoftObjectPtr<UKuroForceFeedbackEffect>(base.NativePtr + (IntPtr)SCommonQte_Extra.__PropertyOffset_7, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SCommonQte_Extra.__PropertyOffset_7, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17005F50 RID: 24400
		// (get) Token: 0x06028B86 RID: 166790 RVA: 0x009B3121 File Offset: 0x009B1321
		// (set) Token: 0x06028B87 RID: 166791 RVA: 0x009B3140 File Offset: 0x009B1340
		public TSoftObjectPtr<UCurveFloat> UiScaleCurve
		{
			get
			{
				return new TSoftObjectPtr<UCurveFloat>(base.NativePtr + (IntPtr)SCommonQte_Extra.__PropertyOffset_8, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SCommonQte_Extra.__PropertyOffset_8, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x06028B88 RID: 166792 RVA: 0x009B3165 File Offset: 0x009B1365
		public SCommonQte_Extra()
		{
		}

		// Token: 0x06028B89 RID: 166793 RVA: 0x009B3170 File Offset: 0x009B1370
		public SCommonQte_Extra(bool IsBlockFightInput, bool HideAllBattleUi, bool ShowMouseCursor, [Nullable(new byte[]
		{
			1,
			0
		})] TArray<TEnumAsByte<EBattleUIChild>> HideUIElement, TSoftObjectPtr<EffectScreenPlayData_C> ScreenEffectType1, TSoftObjectPtr<EffectModelPostProcess> ScreenEffectType2, TSoftClassPtr<UMatineeCameraShake> CameraShake, TSoftObjectPtr<UKuroForceFeedbackEffect> GamepadShake, TSoftObjectPtr<UCurveFloat> UiScaleCurve)
		{
			this.IsBlockFightInput = IsBlockFightInput;
			this.HideAllBattleUi = HideAllBattleUi;
			this.ShowMouseCursor = ShowMouseCursor;
			this.HideUIElement = HideUIElement;
			this.ScreenEffectType1 = ScreenEffectType1;
			this.ScreenEffectType2 = ScreenEffectType2;
			this.CameraShake = CameraShake;
			this.GamepadShake = GamepadShake;
			this.UiScaleCurve = UiScaleCurve;
		}

		// Token: 0x06028B8A RID: 166794 RVA: 0x009B31C8 File Offset: 0x009B13C8
		protected override IntPtr GetUStructPtr()
		{
			return SCommonQte_Extra.StaticStruct();
		}

		// Token: 0x06028B8B RID: 166795 RVA: 0x009B31D4 File Offset: 0x009B13D4
		[NullableContext(2)]
		public SCommonQte_Extra(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06028B8C RID: 166796 RVA: 0x009B31DE File Offset: 0x009B13DE
		public SCommonQte_Extra(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06028B8D RID: 166797 RVA: 0x009B31E9 File Offset: 0x009B13E9
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SCommonQte_Extra(Pointer, false, true);
		}

		// Token: 0x06028B8E RID: 166798 RVA: 0x009B31F3 File Offset: 0x009B13F3
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SCommonQte_Extra(Pointer, MemoryOwner);
		}

		// Token: 0x04014CFC RID: 85244
		public const string __ObjectPath = "/Game/Aki/Data/Qte/SCommonQte_Extra.SCommonQte_Extra";

		// Token: 0x04014CFD RID: 85245
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014CFE RID: 85246
		internal static int __PropertyOffset_0;

		// Token: 0x04014CFF RID: 85247
		internal static int __PropertyOffset_1;

		// Token: 0x04014D00 RID: 85248
		internal static int __PropertyOffset_2;

		// Token: 0x04014D01 RID: 85249
		internal static int __PropertyOffset_3;

		// Token: 0x04014D02 RID: 85250
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TArray<TEnumAsByte<EBattleUIChild>> _HideUIElement;

		// Token: 0x04014D03 RID: 85251
		internal static int __PropertyOffset_4;

		// Token: 0x04014D04 RID: 85252
		internal static int __PropertyOffset_5;

		// Token: 0x04014D05 RID: 85253
		internal static int __PropertyOffset_6;

		// Token: 0x04014D06 RID: 85254
		internal static int __PropertyOffset_7;

		// Token: 0x04014D07 RID: 85255
		internal static int __PropertyOffset_8;
	}
}

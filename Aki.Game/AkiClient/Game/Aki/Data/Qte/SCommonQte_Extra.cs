using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;
using AkiClient.Game.Aki.Render.RuntimeBP.ScreenEffect.Data;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Qte
{
	// Token: 0x020031A1 RID: 12705
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Qte/SCommonQte_Extra.SCommonQte_Extra")]
	[UnrealStructLayout(264, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 264)]
	public class SCommonQte_Extra : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601F5A1 RID: 128417 RVA: 0x0092BDF6 File Offset: 0x00929FF6
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SCommonQte_Extra._ScriptStructPtr != 0) ? SCommonQte_Extra._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Qte/SCommonQte_Extra.SCommonQte_Extra", ref SCommonQte_Extra._ScriptStructPtr);
		}

		// Token: 0x170038D4 RID: 14548
		// (get) Token: 0x0601F5A2 RID: 128418 RVA: 0x0092BE1A File Offset: 0x0092A01A
		// (set) Token: 0x0601F5A3 RID: 128419 RVA: 0x0092BE2A File Offset: 0x0092A02A
		public unsafe bool IsBlockFightInput
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_Extra.__PropertyOffset_IsBlockFightInput) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_Extra.__PropertyOffset_IsBlockFightInput) = (value ? 1 : 0);
			}
		}

		// Token: 0x170038D5 RID: 14549
		// (get) Token: 0x0601F5A4 RID: 128420 RVA: 0x0092BE3B File Offset: 0x0092A03B
		// (set) Token: 0x0601F5A5 RID: 128421 RVA: 0x0092BE4B File Offset: 0x0092A04B
		public unsafe bool HideAllBattleUi
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_Extra.__PropertyOffset_HideAllBattleUi) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_Extra.__PropertyOffset_HideAllBattleUi) = (value ? 1 : 0);
			}
		}

		// Token: 0x170038D6 RID: 14550
		// (get) Token: 0x0601F5A6 RID: 128422 RVA: 0x0092BE5C File Offset: 0x0092A05C
		// (set) Token: 0x0601F5A7 RID: 128423 RVA: 0x0092BE6C File Offset: 0x0092A06C
		public unsafe bool ShowMouseCursor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_Extra.__PropertyOffset_ShowMouseCursor) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_Extra.__PropertyOffset_ShowMouseCursor) = (value ? 1 : 0);
			}
		}

		// Token: 0x170038D7 RID: 14551
		// (get) Token: 0x0601F5A8 RID: 128424 RVA: 0x0092BE80 File Offset: 0x0092A080
		// (set) Token: 0x0601F5A9 RID: 128425 RVA: 0x0092BEC3 File Offset: 0x0092A0C3
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
					result = (this._HideUIElement = new TArray<TEnumAsByte<EBattleUIChild>>(base.NativePtr + (IntPtr)SCommonQte_Extra.__PropertyOffset_HideUIElement, base.MemoryOwner ?? this));
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

		// Token: 0x170038D8 RID: 14552
		// (get) Token: 0x0601F5AA RID: 128426 RVA: 0x0092BED1 File Offset: 0x0092A0D1
		// (set) Token: 0x0601F5AB RID: 128427 RVA: 0x0092BEF0 File Offset: 0x0092A0F0
		public TSoftObjectPtr<EffectScreenPlayData_C> ScreenEffectType1
		{
			get
			{
				return new TSoftObjectPtr<EffectScreenPlayData_C>(base.NativePtr + (IntPtr)SCommonQte_Extra.__PropertyOffset_ScreenEffectType1, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SCommonQte_Extra.__PropertyOffset_ScreenEffectType1, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170038D9 RID: 14553
		// (get) Token: 0x0601F5AC RID: 128428 RVA: 0x0092BF15 File Offset: 0x0092A115
		// (set) Token: 0x0601F5AD RID: 128429 RVA: 0x0092BF34 File Offset: 0x0092A134
		public TSoftObjectPtr<EffectModelPostProcess> ScreenEffectType2
		{
			get
			{
				return new TSoftObjectPtr<EffectModelPostProcess>(base.NativePtr + (IntPtr)SCommonQte_Extra.__PropertyOffset_ScreenEffectType2, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SCommonQte_Extra.__PropertyOffset_ScreenEffectType2, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170038DA RID: 14554
		// (get) Token: 0x0601F5AE RID: 128430 RVA: 0x0092BF59 File Offset: 0x0092A159
		// (set) Token: 0x0601F5AF RID: 128431 RVA: 0x0092BF78 File Offset: 0x0092A178
		public TSoftClassPtr<UMatineeCameraShake> CameraShake
		{
			get
			{
				return new TSoftClassPtr<UMatineeCameraShake>(base.NativePtr + (IntPtr)SCommonQte_Extra.__PropertyOffset_CameraShake, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SCommonQte_Extra.__PropertyOffset_CameraShake, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170038DB RID: 14555
		// (get) Token: 0x0601F5B0 RID: 128432 RVA: 0x0092BF9D File Offset: 0x0092A19D
		// (set) Token: 0x0601F5B1 RID: 128433 RVA: 0x0092BFBC File Offset: 0x0092A1BC
		public TSoftObjectPtr<UKuroForceFeedbackEffect> GamepadShake
		{
			get
			{
				return new TSoftObjectPtr<UKuroForceFeedbackEffect>(base.NativePtr + (IntPtr)SCommonQte_Extra.__PropertyOffset_GamepadShake, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SCommonQte_Extra.__PropertyOffset_GamepadShake, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170038DC RID: 14556
		// (get) Token: 0x0601F5B2 RID: 128434 RVA: 0x0092BFE1 File Offset: 0x0092A1E1
		// (set) Token: 0x0601F5B3 RID: 128435 RVA: 0x0092C000 File Offset: 0x0092A200
		public TSoftObjectPtr<UCurveFloat> UiScaleCurve
		{
			get
			{
				return new TSoftObjectPtr<UCurveFloat>(base.NativePtr + (IntPtr)SCommonQte_Extra.__PropertyOffset_UiScaleCurve, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SCommonQte_Extra.__PropertyOffset_UiScaleCurve, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x0601F5B4 RID: 128436 RVA: 0x0092C025 File Offset: 0x0092A225
		public SCommonQte_Extra()
		{
		}

		// Token: 0x0601F5B5 RID: 128437 RVA: 0x0092C02D File Offset: 0x0092A22D
		protected override IntPtr GetUStructPtr()
		{
			return SCommonQte_Extra.StaticStruct();
		}

		// Token: 0x0601F5B6 RID: 128438 RVA: 0x0092C039 File Offset: 0x0092A239
		[NullableContext(2)]
		public SCommonQte_Extra(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F5B7 RID: 128439 RVA: 0x0092C043 File Offset: 0x0092A243
		public SCommonQte_Extra(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F5B8 RID: 128440 RVA: 0x0092C04E File Offset: 0x0092A24E
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SCommonQte_Extra(Pointer, false, true);
		}

		// Token: 0x0601F5B9 RID: 128441 RVA: 0x0092C058 File Offset: 0x0092A258
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SCommonQte_Extra(Pointer, MemoryOwner);
		}

		// Token: 0x04010CE3 RID: 68835
		public const string __ObjectPath = "/Game/Aki/Data/Qte/SCommonQte_Extra.SCommonQte_Extra";

		// Token: 0x04010CE4 RID: 68836
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010CE5 RID: 68837
		internal static int __PropertyOffset_IsBlockFightInput;

		// Token: 0x04010CE6 RID: 68838
		internal static int __PropertyOffset_HideAllBattleUi;

		// Token: 0x04010CE7 RID: 68839
		internal static int __PropertyOffset_ShowMouseCursor;

		// Token: 0x04010CE8 RID: 68840
		internal static int __PropertyOffset_HideUIElement;

		// Token: 0x04010CE9 RID: 68841
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TArray<TEnumAsByte<EBattleUIChild>> _HideUIElement;

		// Token: 0x04010CEA RID: 68842
		internal static int __PropertyOffset_ScreenEffectType1;

		// Token: 0x04010CEB RID: 68843
		internal static int __PropertyOffset_ScreenEffectType2;

		// Token: 0x04010CEC RID: 68844
		internal static int __PropertyOffset_CameraShake;

		// Token: 0x04010CED RID: 68845
		internal static int __PropertyOffset_GamepadShake;

		// Token: 0x04010CEE RID: 68846
		internal static int __PropertyOffset_UiScaleCurve;
	}
}

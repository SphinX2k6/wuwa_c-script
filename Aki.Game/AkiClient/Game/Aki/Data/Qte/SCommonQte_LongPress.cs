using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Qte
{
	// Token: 0x020031A2 RID: 12706
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Data/Qte/SCommonQte_LongPress.SCommonQte_LongPress")]
	[UnrealStructLayout(208, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 201)]
	public class SCommonQte_LongPress : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601F5BA RID: 128442 RVA: 0x0092C061 File Offset: 0x0092A261
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SCommonQte_LongPress._ScriptStructPtr != 0) ? SCommonQte_LongPress._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Qte/SCommonQte_LongPress.SCommonQte_LongPress", ref SCommonQte_LongPress._ScriptStructPtr);
		}

		// Token: 0x170038DD RID: 14557
		// (get) Token: 0x0601F5BB RID: 128443 RVA: 0x0092C085 File Offset: 0x0092A285
		// (set) Token: 0x0601F5BC RID: 128444 RVA: 0x0092C099 File Offset: 0x0092A299
		public unsafe TEnumAsByte<ECommonQteViewType_SingleButtonLongPress> ViewType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_LongPress.__PropertyOffset_ViewType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_LongPress.__PropertyOffset_ViewType) = value;
			}
		}

		// Token: 0x170038DE RID: 14558
		// (get) Token: 0x0601F5BD RID: 128445 RVA: 0x0092C0B0 File Offset: 0x0092A2B0
		// (set) Token: 0x0601F5BE RID: 128446 RVA: 0x0092C0F3 File Offset: 0x0092A2F3
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
					result = (this._UIConfig = new SCommonQteButton(base.NativePtr + (IntPtr)SCommonQte_LongPress.__PropertyOffset_UIConfig, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SCommonQteButton.StaticStruct(), base.NativePtr + (IntPtr)SCommonQte_LongPress.__PropertyOffset_UIConfig, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170038DF RID: 14559
		// (get) Token: 0x0601F5BF RID: 128447 RVA: 0x0092C114 File Offset: 0x0092A314
		// (set) Token: 0x0601F5C0 RID: 128448 RVA: 0x0092C128 File Offset: 0x0092A328
		public unsafe TEnumAsByte<ECommonQteInteractiveTiming> InteractiveTiming
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_LongPress.__PropertyOffset_InteractiveTiming);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_LongPress.__PropertyOffset_InteractiveTiming) = value;
			}
		}

		// Token: 0x170038E0 RID: 14560
		// (get) Token: 0x0601F5C1 RID: 128449 RVA: 0x0092C13D File Offset: 0x0092A33D
		// (set) Token: 0x0601F5C2 RID: 128450 RVA: 0x0092C14D File Offset: 0x0092A34D
		public unsafe float InitProgress
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_LongPress.__PropertyOffset_InitProgress);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_LongPress.__PropertyOffset_InitProgress) = value;
			}
		}

		// Token: 0x170038E1 RID: 14561
		// (get) Token: 0x0601F5C3 RID: 128451 RVA: 0x0092C15E File Offset: 0x0092A35E
		// (set) Token: 0x0601F5C4 RID: 128452 RVA: 0x0092C16E File Offset: 0x0092A36E
		public unsafe float MaxProgress
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_LongPress.__PropertyOffset_MaxProgress);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_LongPress.__PropertyOffset_MaxProgress) = value;
			}
		}

		// Token: 0x170038E2 RID: 14562
		// (get) Token: 0x0601F5C5 RID: 128453 RVA: 0x0092C17F File Offset: 0x0092A37F
		// (set) Token: 0x0601F5C6 RID: 128454 RVA: 0x0092C18F File Offset: 0x0092A38F
		public unsafe float TargetProgress
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_LongPress.__PropertyOffset_TargetProgress);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_LongPress.__PropertyOffset_TargetProgress) = value;
			}
		}

		// Token: 0x170038E3 RID: 14563
		// (get) Token: 0x0601F5C7 RID: 128455 RVA: 0x0092C1A0 File Offset: 0x0092A3A0
		// (set) Token: 0x0601F5C8 RID: 128456 RVA: 0x0092C1B0 File Offset: 0x0092A3B0
		public unsafe float IncreaseSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_LongPress.__PropertyOffset_IncreaseSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_LongPress.__PropertyOffset_IncreaseSpeed) = value;
			}
		}

		// Token: 0x170038E4 RID: 14564
		// (get) Token: 0x0601F5C9 RID: 128457 RVA: 0x0092C1C1 File Offset: 0x0092A3C1
		// (set) Token: 0x0601F5CA RID: 128458 RVA: 0x0092C1D1 File Offset: 0x0092A3D1
		public unsafe float DecreaseSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_LongPress.__PropertyOffset_DecreaseSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_LongPress.__PropertyOffset_DecreaseSpeed) = value;
			}
		}

		// Token: 0x170038E5 RID: 14565
		// (get) Token: 0x0601F5CB RID: 128459 RVA: 0x0092C1E2 File Offset: 0x0092A3E2
		// (set) Token: 0x0601F5CC RID: 128460 RVA: 0x0092C1F2 File Offset: 0x0092A3F2
		public unsafe bool IsAttachToActor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_LongPress.__PropertyOffset_IsAttachToActor) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_LongPress.__PropertyOffset_IsAttachToActor) = (value ? 1 : 0);
			}
		}

		// Token: 0x170038E6 RID: 14566
		// (get) Token: 0x0601F5CD RID: 128461 RVA: 0x0092C203 File Offset: 0x0092A403
		// (set) Token: 0x0601F5CE RID: 128462 RVA: 0x0092C217 File Offset: 0x0092A417
		public unsafe SCommonQte_Attach AttachConfig
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_LongPress.__PropertyOffset_AttachConfig);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_LongPress.__PropertyOffset_AttachConfig) = value;
			}
		}

		// Token: 0x170038E7 RID: 14567
		// (get) Token: 0x0601F5CF RID: 128463 RVA: 0x0092C22C File Offset: 0x0092A42C
		// (set) Token: 0x0601F5D0 RID: 128464 RVA: 0x0092C23C File Offset: 0x0092A43C
		public unsafe bool IsCheckOnRelease
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_LongPress.__PropertyOffset_IsCheckOnRelease) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_LongPress.__PropertyOffset_IsCheckOnRelease) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601F5D1 RID: 128465 RVA: 0x0092C24D File Offset: 0x0092A44D
		public SCommonQte_LongPress()
		{
		}

		// Token: 0x0601F5D2 RID: 128466 RVA: 0x0092C255 File Offset: 0x0092A455
		protected override IntPtr GetUStructPtr()
		{
			return SCommonQte_LongPress.StaticStruct();
		}

		// Token: 0x0601F5D3 RID: 128467 RVA: 0x0092C261 File Offset: 0x0092A461
		[NullableContext(2)]
		public SCommonQte_LongPress(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F5D4 RID: 128468 RVA: 0x0092C26B File Offset: 0x0092A46B
		public SCommonQte_LongPress(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F5D5 RID: 128469 RVA: 0x0092C276 File Offset: 0x0092A476
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SCommonQte_LongPress(Pointer, false, true);
		}

		// Token: 0x0601F5D6 RID: 128470 RVA: 0x0092C280 File Offset: 0x0092A480
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SCommonQte_LongPress(Pointer, MemoryOwner);
		}

		// Token: 0x04010CEF RID: 68847
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Data/Qte/SCommonQte_LongPress.SCommonQte_LongPress";

		// Token: 0x04010CF0 RID: 68848
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010CF1 RID: 68849
		internal static int __PropertyOffset_ViewType;

		// Token: 0x04010CF2 RID: 68850
		internal static int __PropertyOffset_UIConfig;

		// Token: 0x04010CF3 RID: 68851
		[Nullable(2)]
		private SCommonQteButton _UIConfig;

		// Token: 0x04010CF4 RID: 68852
		internal static int __PropertyOffset_InteractiveTiming;

		// Token: 0x04010CF5 RID: 68853
		internal static int __PropertyOffset_InitProgress;

		// Token: 0x04010CF6 RID: 68854
		internal static int __PropertyOffset_MaxProgress;

		// Token: 0x04010CF7 RID: 68855
		internal static int __PropertyOffset_TargetProgress;

		// Token: 0x04010CF8 RID: 68856
		internal static int __PropertyOffset_IncreaseSpeed;

		// Token: 0x04010CF9 RID: 68857
		internal static int __PropertyOffset_DecreaseSpeed;

		// Token: 0x04010CFA RID: 68858
		internal static int __PropertyOffset_IsAttachToActor;

		// Token: 0x04010CFB RID: 68859
		internal static int __PropertyOffset_AttachConfig;

		// Token: 0x04010CFC RID: 68860
		internal static int __PropertyOffset_IsCheckOnRelease;
	}
}

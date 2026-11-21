using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Qte
{
	// Token: 0x020031A4 RID: 12708
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Data/Qte/SCommonQte_SingleClick.SCommonQte_SingleClick")]
	[UnrealStructLayout(200, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 196)]
	public class SCommonQte_SingleClick : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601F5E8 RID: 128488 RVA: 0x0092C3D0 File Offset: 0x0092A5D0
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SCommonQte_SingleClick._ScriptStructPtr != 0) ? SCommonQte_SingleClick._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Qte/SCommonQte_SingleClick.SCommonQte_SingleClick", ref SCommonQte_SingleClick._ScriptStructPtr);
		}

		// Token: 0x170038ED RID: 14573
		// (get) Token: 0x0601F5E9 RID: 128489 RVA: 0x0092C3F4 File Offset: 0x0092A5F4
		// (set) Token: 0x0601F5EA RID: 128490 RVA: 0x0092C408 File Offset: 0x0092A608
		public unsafe TEnumAsByte<ECommonQteViewType_SingleButton> ViewType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_SingleClick.__PropertyOffset_ViewType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_SingleClick.__PropertyOffset_ViewType) = value;
			}
		}

		// Token: 0x170038EE RID: 14574
		// (get) Token: 0x0601F5EB RID: 128491 RVA: 0x0092C420 File Offset: 0x0092A620
		// (set) Token: 0x0601F5EC RID: 128492 RVA: 0x0092C463 File Offset: 0x0092A663
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
					result = (this._UIConfig = new SCommonQteButton(base.NativePtr + (IntPtr)SCommonQte_SingleClick.__PropertyOffset_UIConfig, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SCommonQteButton.StaticStruct(), base.NativePtr + (IntPtr)SCommonQte_SingleClick.__PropertyOffset_UIConfig, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170038EF RID: 14575
		// (get) Token: 0x0601F5ED RID: 128493 RVA: 0x0092C484 File Offset: 0x0092A684
		// (set) Token: 0x0601F5EE RID: 128494 RVA: 0x0092C498 File Offset: 0x0092A698
		public unsafe TEnumAsByte<ECommonQteInteractiveTiming> InteractiveTiming
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_SingleClick.__PropertyOffset_InteractiveTiming);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_SingleClick.__PropertyOffset_InteractiveTiming) = value;
			}
		}

		// Token: 0x170038F0 RID: 14576
		// (get) Token: 0x0601F5EF RID: 128495 RVA: 0x0092C4AD File Offset: 0x0092A6AD
		// (set) Token: 0x0601F5F0 RID: 128496 RVA: 0x0092C4BD File Offset: 0x0092A6BD
		public unsafe bool IsShowBorder
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_SingleClick.__PropertyOffset_IsShowBorder) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_SingleClick.__PropertyOffset_IsShowBorder) = (value ? 1 : 0);
			}
		}

		// Token: 0x170038F1 RID: 14577
		// (get) Token: 0x0601F5F1 RID: 128497 RVA: 0x0092C4CE File Offset: 0x0092A6CE
		// (set) Token: 0x0601F5F2 RID: 128498 RVA: 0x0092C4DE File Offset: 0x0092A6DE
		public unsafe bool IsAttachToActor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_SingleClick.__PropertyOffset_IsAttachToActor) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_SingleClick.__PropertyOffset_IsAttachToActor) = (value ? 1 : 0);
			}
		}

		// Token: 0x170038F2 RID: 14578
		// (get) Token: 0x0601F5F3 RID: 128499 RVA: 0x0092C4EF File Offset: 0x0092A6EF
		// (set) Token: 0x0601F5F4 RID: 128500 RVA: 0x0092C503 File Offset: 0x0092A703
		public unsafe SCommonQte_Attach AttachConfig
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_SingleClick.__PropertyOffset_AttachConfig);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_SingleClick.__PropertyOffset_AttachConfig) = value;
			}
		}

		// Token: 0x170038F3 RID: 14579
		// (get) Token: 0x0601F5F5 RID: 128501 RVA: 0x0092C518 File Offset: 0x0092A718
		// (set) Token: 0x0601F5F6 RID: 128502 RVA: 0x0092C528 File Offset: 0x0092A728
		public unsafe UIAnchorHorizontalAlign ButtonAnchorHAlign
		{
			get
			{
				return (UIAnchorHorizontalAlign)(*(base.NativePtr + (IntPtr)SCommonQte_SingleClick.__PropertyOffset_ButtonAnchorHAlign));
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_SingleClick.__PropertyOffset_ButtonAnchorHAlign) = (byte)value;
			}
		}

		// Token: 0x170038F4 RID: 14580
		// (get) Token: 0x0601F5F7 RID: 128503 RVA: 0x0092C539 File Offset: 0x0092A739
		// (set) Token: 0x0601F5F8 RID: 128504 RVA: 0x0092C549 File Offset: 0x0092A749
		public unsafe UIAnchorVerticalAlign ButtonAnchorVAlign
		{
			get
			{
				return (UIAnchorVerticalAlign)(*(base.NativePtr + (IntPtr)SCommonQte_SingleClick.__PropertyOffset_ButtonAnchorVAlign));
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_SingleClick.__PropertyOffset_ButtonAnchorVAlign) = (byte)value;
			}
		}

		// Token: 0x170038F5 RID: 14581
		// (get) Token: 0x0601F5F9 RID: 128505 RVA: 0x0092C55A File Offset: 0x0092A75A
		// (set) Token: 0x0601F5FA RID: 128506 RVA: 0x0092C56E File Offset: 0x0092A76E
		public unsafe FVector2D ButtonOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_SingleClick.__PropertyOffset_ButtonOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_SingleClick.__PropertyOffset_ButtonOffset) = value;
			}
		}

		// Token: 0x170038F6 RID: 14582
		// (get) Token: 0x0601F5FB RID: 128507 RVA: 0x0092C583 File Offset: 0x0092A783
		// (set) Token: 0x0601F5FC RID: 128508 RVA: 0x0092C593 File Offset: 0x0092A793
		public unsafe float ProgressResponseStart
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_SingleClick.__PropertyOffset_ProgressResponseStart);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_SingleClick.__PropertyOffset_ProgressResponseStart) = value;
			}
		}

		// Token: 0x170038F7 RID: 14583
		// (get) Token: 0x0601F5FD RID: 128509 RVA: 0x0092C5A4 File Offset: 0x0092A7A4
		// (set) Token: 0x0601F5FE RID: 128510 RVA: 0x0092C5B4 File Offset: 0x0092A7B4
		public unsafe float ProgressResponseEnd
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_SingleClick.__PropertyOffset_ProgressResponseEnd);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_SingleClick.__PropertyOffset_ProgressResponseEnd) = value;
			}
		}

		// Token: 0x0601F5FF RID: 128511 RVA: 0x0092C5C5 File Offset: 0x0092A7C5
		public SCommonQte_SingleClick()
		{
		}

		// Token: 0x0601F600 RID: 128512 RVA: 0x0092C5CD File Offset: 0x0092A7CD
		protected override IntPtr GetUStructPtr()
		{
			return SCommonQte_SingleClick.StaticStruct();
		}

		// Token: 0x0601F601 RID: 128513 RVA: 0x0092C5D9 File Offset: 0x0092A7D9
		[NullableContext(2)]
		public SCommonQte_SingleClick(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F602 RID: 128514 RVA: 0x0092C5E3 File Offset: 0x0092A7E3
		public SCommonQte_SingleClick(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F603 RID: 128515 RVA: 0x0092C5EE File Offset: 0x0092A7EE
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SCommonQte_SingleClick(Pointer, false, true);
		}

		// Token: 0x0601F604 RID: 128516 RVA: 0x0092C5F8 File Offset: 0x0092A7F8
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SCommonQte_SingleClick(Pointer, MemoryOwner);
		}

		// Token: 0x04010D05 RID: 68869
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Data/Qte/SCommonQte_SingleClick.SCommonQte_SingleClick";

		// Token: 0x04010D06 RID: 68870
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010D07 RID: 68871
		internal static int __PropertyOffset_ViewType;

		// Token: 0x04010D08 RID: 68872
		internal static int __PropertyOffset_UIConfig;

		// Token: 0x04010D09 RID: 68873
		[Nullable(2)]
		private SCommonQteButton _UIConfig;

		// Token: 0x04010D0A RID: 68874
		internal static int __PropertyOffset_InteractiveTiming;

		// Token: 0x04010D0B RID: 68875
		internal static int __PropertyOffset_IsShowBorder;

		// Token: 0x04010D0C RID: 68876
		internal static int __PropertyOffset_IsAttachToActor;

		// Token: 0x04010D0D RID: 68877
		internal static int __PropertyOffset_AttachConfig;

		// Token: 0x04010D0E RID: 68878
		internal static int __PropertyOffset_ButtonAnchorHAlign;

		// Token: 0x04010D0F RID: 68879
		internal static int __PropertyOffset_ButtonAnchorVAlign;

		// Token: 0x04010D10 RID: 68880
		internal static int __PropertyOffset_ButtonOffset;

		// Token: 0x04010D11 RID: 68881
		internal static int __PropertyOffset_ProgressResponseStart;

		// Token: 0x04010D12 RID: 68882
		internal static int __PropertyOffset_ProgressResponseEnd;
	}
}

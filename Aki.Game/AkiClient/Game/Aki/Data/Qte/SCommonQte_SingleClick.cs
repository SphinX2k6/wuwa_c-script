using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Qte
{
	// Token: 0x02003EDF RID: 16095
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Data/Qte/SCommonQte_SingleClick.SCommonQte_SingleClick")]
	[UnrealStructLayout(200, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 196)]
	public class SCommonQte_SingleClick : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06028BBF RID: 166847 RVA: 0x009B3605 File Offset: 0x009B1805
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SCommonQte_SingleClick._ScriptStructPtr != 0) ? SCommonQte_SingleClick._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Qte/SCommonQte_SingleClick.SCommonQte_SingleClick", ref SCommonQte_SingleClick._ScriptStructPtr);
		}

		// Token: 0x17005F61 RID: 24417
		// (get) Token: 0x06028BC0 RID: 166848 RVA: 0x009B3629 File Offset: 0x009B1829
		// (set) Token: 0x06028BC1 RID: 166849 RVA: 0x009B363D File Offset: 0x009B183D
		public unsafe TEnumAsByte<ECommonQteViewType_SingleButton> ViewType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_SingleClick.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_SingleClick.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17005F62 RID: 24418
		// (get) Token: 0x06028BC2 RID: 166850 RVA: 0x009B3654 File Offset: 0x009B1854
		// (set) Token: 0x06028BC3 RID: 166851 RVA: 0x009B3697 File Offset: 0x009B1897
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
					result = (this._UIConfig = new SCommonQteButton(base.NativePtr + (IntPtr)SCommonQte_SingleClick.__PropertyOffset_1, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SCommonQteButton.StaticStruct(), base.NativePtr + (IntPtr)SCommonQte_SingleClick.__PropertyOffset_1, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005F63 RID: 24419
		// (get) Token: 0x06028BC4 RID: 166852 RVA: 0x009B36B8 File Offset: 0x009B18B8
		// (set) Token: 0x06028BC5 RID: 166853 RVA: 0x009B36CC File Offset: 0x009B18CC
		public unsafe TEnumAsByte<ECommonQteInteractiveTiming> InteractiveTiming
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_SingleClick.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_SingleClick.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17005F64 RID: 24420
		// (get) Token: 0x06028BC6 RID: 166854 RVA: 0x009B36E1 File Offset: 0x009B18E1
		// (set) Token: 0x06028BC7 RID: 166855 RVA: 0x009B36F1 File Offset: 0x009B18F1
		public unsafe bool IsShowBorder
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_SingleClick.__PropertyOffset_3) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_SingleClick.__PropertyOffset_3) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005F65 RID: 24421
		// (get) Token: 0x06028BC8 RID: 166856 RVA: 0x009B3702 File Offset: 0x009B1902
		// (set) Token: 0x06028BC9 RID: 166857 RVA: 0x009B3712 File Offset: 0x009B1912
		public unsafe bool IsAttachToActor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_SingleClick.__PropertyOffset_4) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_SingleClick.__PropertyOffset_4) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005F66 RID: 24422
		// (get) Token: 0x06028BCA RID: 166858 RVA: 0x009B3723 File Offset: 0x009B1923
		// (set) Token: 0x06028BCB RID: 166859 RVA: 0x009B3737 File Offset: 0x009B1937
		public unsafe SCommonQte_Attach AttachConfig
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_SingleClick.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_SingleClick.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17005F67 RID: 24423
		// (get) Token: 0x06028BCC RID: 166860 RVA: 0x009B374C File Offset: 0x009B194C
		// (set) Token: 0x06028BCD RID: 166861 RVA: 0x009B375C File Offset: 0x009B195C
		public unsafe UIAnchorHorizontalAlign ButtonAnchorHAlign
		{
			get
			{
				return (UIAnchorHorizontalAlign)(*(base.NativePtr + (IntPtr)SCommonQte_SingleClick.__PropertyOffset_6));
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_SingleClick.__PropertyOffset_6) = (byte)value;
			}
		}

		// Token: 0x17005F68 RID: 24424
		// (get) Token: 0x06028BCE RID: 166862 RVA: 0x009B376D File Offset: 0x009B196D
		// (set) Token: 0x06028BCF RID: 166863 RVA: 0x009B377D File Offset: 0x009B197D
		public unsafe UIAnchorVerticalAlign ButtonAnchorVAlign
		{
			get
			{
				return (UIAnchorVerticalAlign)(*(base.NativePtr + (IntPtr)SCommonQte_SingleClick.__PropertyOffset_7));
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_SingleClick.__PropertyOffset_7) = (byte)value;
			}
		}

		// Token: 0x17005F69 RID: 24425
		// (get) Token: 0x06028BD0 RID: 166864 RVA: 0x009B378E File Offset: 0x009B198E
		// (set) Token: 0x06028BD1 RID: 166865 RVA: 0x009B37A2 File Offset: 0x009B19A2
		public unsafe FVector2D ButtonOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_SingleClick.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_SingleClick.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17005F6A RID: 24426
		// (get) Token: 0x06028BD2 RID: 166866 RVA: 0x009B37B7 File Offset: 0x009B19B7
		// (set) Token: 0x06028BD3 RID: 166867 RVA: 0x009B37C7 File Offset: 0x009B19C7
		public unsafe float ProgressResponseStart
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_SingleClick.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_SingleClick.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17005F6B RID: 24427
		// (get) Token: 0x06028BD4 RID: 166868 RVA: 0x009B37D8 File Offset: 0x009B19D8
		// (set) Token: 0x06028BD5 RID: 166869 RVA: 0x009B37E8 File Offset: 0x009B19E8
		public unsafe float ProgressResponseEnd
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_SingleClick.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_SingleClick.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x06028BD6 RID: 166870 RVA: 0x009B37F9 File Offset: 0x009B19F9
		public SCommonQte_SingleClick()
		{
		}

		// Token: 0x06028BD7 RID: 166871 RVA: 0x009B3804 File Offset: 0x009B1A04
		public SCommonQte_SingleClick(TEnumAsByte<ECommonQteViewType_SingleButton> ViewType, [Nullable(1)] SCommonQteButton UIConfig, TEnumAsByte<ECommonQteInteractiveTiming> InteractiveTiming, bool IsShowBorder, bool IsAttachToActor, SCommonQte_Attach AttachConfig, UIAnchorHorizontalAlign ButtonAnchorHAlign, UIAnchorVerticalAlign ButtonAnchorVAlign, FVector2D ButtonOffset, float ProgressResponseStart, float ProgressResponseEnd)
		{
			this.ViewType = ViewType;
			this.UIConfig = UIConfig;
			this.InteractiveTiming = InteractiveTiming;
			this.IsShowBorder = IsShowBorder;
			this.IsAttachToActor = IsAttachToActor;
			this.AttachConfig = AttachConfig;
			this.ButtonAnchorHAlign = ButtonAnchorHAlign;
			this.ButtonAnchorVAlign = ButtonAnchorVAlign;
			this.ButtonOffset = ButtonOffset;
			this.ProgressResponseStart = ProgressResponseStart;
			this.ProgressResponseEnd = ProgressResponseEnd;
		}

		// Token: 0x06028BD8 RID: 166872 RVA: 0x009B386C File Offset: 0x009B1A6C
		protected override IntPtr GetUStructPtr()
		{
			return SCommonQte_SingleClick.StaticStruct();
		}

		// Token: 0x06028BD9 RID: 166873 RVA: 0x009B3878 File Offset: 0x009B1A78
		[NullableContext(2)]
		public SCommonQte_SingleClick(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06028BDA RID: 166874 RVA: 0x009B3882 File Offset: 0x009B1A82
		public SCommonQte_SingleClick(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06028BDB RID: 166875 RVA: 0x009B388D File Offset: 0x009B1A8D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SCommonQte_SingleClick(Pointer, false, true);
		}

		// Token: 0x06028BDC RID: 166876 RVA: 0x009B3897 File Offset: 0x009B1A97
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SCommonQte_SingleClick(Pointer, MemoryOwner);
		}

		// Token: 0x04014D1E RID: 85278
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Data/Qte/SCommonQte_SingleClick.SCommonQte_SingleClick";

		// Token: 0x04014D1F RID: 85279
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014D20 RID: 85280
		internal static int __PropertyOffset_0;

		// Token: 0x04014D21 RID: 85281
		internal static int __PropertyOffset_1;

		// Token: 0x04014D22 RID: 85282
		[Nullable(2)]
		private SCommonQteButton _UIConfig;

		// Token: 0x04014D23 RID: 85283
		internal static int __PropertyOffset_2;

		// Token: 0x04014D24 RID: 85284
		internal static int __PropertyOffset_3;

		// Token: 0x04014D25 RID: 85285
		internal static int __PropertyOffset_4;

		// Token: 0x04014D26 RID: 85286
		internal static int __PropertyOffset_5;

		// Token: 0x04014D27 RID: 85287
		internal static int __PropertyOffset_6;

		// Token: 0x04014D28 RID: 85288
		internal static int __PropertyOffset_7;

		// Token: 0x04014D29 RID: 85289
		internal static int __PropertyOffset_8;

		// Token: 0x04014D2A RID: 85290
		internal static int __PropertyOffset_9;

		// Token: 0x04014D2B RID: 85291
		internal static int __PropertyOffset_10;
	}
}

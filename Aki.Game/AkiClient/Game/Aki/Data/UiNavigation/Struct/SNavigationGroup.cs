using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.UiNavigation.Struct
{
	// Token: 0x02003E89 RID: 16009
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/UiNavigation/Struct/SNavigationGroup.SNavigationGroup")]
	[UnrealStructLayout(184, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 179)]
	public class SNavigationGroup : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060286AF RID: 165551 RVA: 0x009AC1A2 File Offset: 0x009AA3A2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SNavigationGroup._ScriptStructPtr != 0) ? SNavigationGroup._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/UiNavigation/Struct/SNavigationGroup.SNavigationGroup", ref SNavigationGroup._ScriptStructPtr);
		}

		// Token: 0x17005DA0 RID: 23968
		// (get) Token: 0x060286B0 RID: 165552 RVA: 0x009AC1C6 File Offset: 0x009AA3C6
		// (set) Token: 0x060286B1 RID: 165553 RVA: 0x009AC1DA File Offset: 0x009AA3DA
		public unsafe string GroupName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SNavigationGroup.__PropertyOffset_0)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SNavigationGroup.__PropertyOffset_0)), value);
			}
		}

		// Token: 0x17005DA1 RID: 23969
		// (get) Token: 0x060286B2 RID: 165554 RVA: 0x009AC1EF File Offset: 0x009AA3EF
		// (set) Token: 0x060286B3 RID: 165555 RVA: 0x009AC1FF File Offset: 0x009AA3FF
		public unsafe int GroupType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SNavigationGroup.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SNavigationGroup.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17005DA2 RID: 23970
		// (get) Token: 0x060286B4 RID: 165556 RVA: 0x009AC210 File Offset: 0x009AA410
		// (set) Token: 0x060286B5 RID: 165557 RVA: 0x009AC224 File Offset: 0x009AA424
		public unsafe string PrevGroupName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SNavigationGroup.__PropertyOffset_2)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SNavigationGroup.__PropertyOffset_2)), value);
			}
		}

		// Token: 0x17005DA3 RID: 23971
		// (get) Token: 0x060286B6 RID: 165558 RVA: 0x009AC239 File Offset: 0x009AA439
		// (set) Token: 0x060286B7 RID: 165559 RVA: 0x009AC24D File Offset: 0x009AA44D
		public unsafe string NextGroupName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SNavigationGroup.__PropertyOffset_3)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SNavigationGroup.__PropertyOffset_3)), value);
			}
		}

		// Token: 0x17005DA4 RID: 23972
		// (get) Token: 0x060286B8 RID: 165560 RVA: 0x009AC262 File Offset: 0x009AA462
		// (set) Token: 0x060286B9 RID: 165561 RVA: 0x009AC276 File Offset: 0x009AA476
		public unsafe string InsideGroupName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SNavigationGroup.__PropertyOffset_4)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SNavigationGroup.__PropertyOffset_4)), value);
			}
		}

		// Token: 0x17005DA5 RID: 23973
		// (get) Token: 0x060286BA RID: 165562 RVA: 0x009AC28C File Offset: 0x009AA48C
		// (set) Token: 0x060286BB RID: 165563 RVA: 0x009AC2CF File Offset: 0x009AA4CF
		public TArray<string> ExtraInsideGroupNameList
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._ExtraInsideGroupNameList) == null)
				{
					result = (this._ExtraInsideGroupNameList = new TArray<string>(base.NativePtr + (IntPtr)SNavigationGroup.__PropertyOffset_5, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ExtraInsideGroupNameList.CopyAssign(value);
			}
		}

		// Token: 0x17005DA6 RID: 23974
		// (get) Token: 0x060286BC RID: 165564 RVA: 0x009AC2E0 File Offset: 0x009AA4E0
		// (set) Token: 0x060286BD RID: 165565 RVA: 0x009AC323 File Offset: 0x009AA523
		public TMap<string, string> GroupNameMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, string> result;
				if ((result = this._GroupNameMap) == null)
				{
					result = (this._GroupNameMap = new TMap<string, string>(base.NativePtr + (IntPtr)SNavigationGroup.__PropertyOffset_6, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.GroupNameMap.CopyAssign(value);
			}
		}

		// Token: 0x17005DA7 RID: 23975
		// (get) Token: 0x060286BE RID: 165566 RVA: 0x009AC331 File Offset: 0x009AA531
		// (set) Token: 0x060286BF RID: 165567 RVA: 0x009AC341 File Offset: 0x009AA541
		public unsafe UINavigationWrapMode HorizontalWrapMode
		{
			get
			{
				return (UINavigationWrapMode)(*(base.NativePtr + (IntPtr)SNavigationGroup.__PropertyOffset_7));
			}
			set
			{
				*(base.NativePtr + (IntPtr)SNavigationGroup.__PropertyOffset_7) = (byte)value;
			}
		}

		// Token: 0x17005DA8 RID: 23976
		// (get) Token: 0x060286C0 RID: 165568 RVA: 0x009AC352 File Offset: 0x009AA552
		// (set) Token: 0x060286C1 RID: 165569 RVA: 0x009AC362 File Offset: 0x009AA562
		public unsafe UINavigationPriorityMode HorizontalPriorityMode
		{
			get
			{
				return (UINavigationPriorityMode)(*(base.NativePtr + (IntPtr)SNavigationGroup.__PropertyOffset_8));
			}
			set
			{
				*(base.NativePtr + (IntPtr)SNavigationGroup.__PropertyOffset_8) = (byte)value;
			}
		}

		// Token: 0x17005DA9 RID: 23977
		// (get) Token: 0x060286C2 RID: 165570 RVA: 0x009AC373 File Offset: 0x009AA573
		// (set) Token: 0x060286C3 RID: 165571 RVA: 0x009AC383 File Offset: 0x009AA583
		public unsafe UINavigationWrapMode VerticalWrapMode
		{
			get
			{
				return (UINavigationWrapMode)(*(base.NativePtr + (IntPtr)SNavigationGroup.__PropertyOffset_9));
			}
			set
			{
				*(base.NativePtr + (IntPtr)SNavigationGroup.__PropertyOffset_9) = (byte)value;
			}
		}

		// Token: 0x17005DAA RID: 23978
		// (get) Token: 0x060286C4 RID: 165572 RVA: 0x009AC394 File Offset: 0x009AA594
		// (set) Token: 0x060286C5 RID: 165573 RVA: 0x009AC3A4 File Offset: 0x009AA5A4
		public unsafe UINavigationPriorityMode VerticalPriorityMode
		{
			get
			{
				return (UINavigationPriorityMode)(*(base.NativePtr + (IntPtr)SNavigationGroup.__PropertyOffset_10));
			}
			set
			{
				*(base.NativePtr + (IntPtr)SNavigationGroup.__PropertyOffset_10) = (byte)value;
			}
		}

		// Token: 0x17005DAB RID: 23979
		// (get) Token: 0x060286C6 RID: 165574 RVA: 0x009AC3B5 File Offset: 0x009AA5B5
		// (set) Token: 0x060286C7 RID: 165575 RVA: 0x009AC3C5 File Offset: 0x009AA5C5
		public unsafe bool SelectableMemory
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SNavigationGroup.__PropertyOffset_11) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SNavigationGroup.__PropertyOffset_11) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005DAC RID: 23980
		// (get) Token: 0x060286C8 RID: 165576 RVA: 0x009AC3D6 File Offset: 0x009AA5D6
		// (set) Token: 0x060286C9 RID: 165577 RVA: 0x009AC3E6 File Offset: 0x009AA5E6
		public unsafe bool AllowNavigationInSelfDynamic
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SNavigationGroup.__PropertyOffset_12) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SNavigationGroup.__PropertyOffset_12) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005DAD RID: 23981
		// (get) Token: 0x060286CA RID: 165578 RVA: 0x009AC3F7 File Offset: 0x009AA5F7
		// (set) Token: 0x060286CB RID: 165579 RVA: 0x009AC407 File Offset: 0x009AA607
		public unsafe bool RefreshNavigation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SNavigationGroup.__PropertyOffset_13) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SNavigationGroup.__PropertyOffset_13) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005DAE RID: 23982
		// (get) Token: 0x060286CC RID: 165580 RVA: 0x009AC418 File Offset: 0x009AA618
		// (set) Token: 0x060286CD RID: 165581 RVA: 0x009AC428 File Offset: 0x009AA628
		public unsafe bool SuitableListenerByNoDynamic
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SNavigationGroup.__PropertyOffset_14) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SNavigationGroup.__PropertyOffset_14) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005DAF RID: 23983
		// (get) Token: 0x060286CE RID: 165582 RVA: 0x009AC439 File Offset: 0x009AA639
		// (set) Token: 0x060286CF RID: 165583 RVA: 0x009AC449 File Offset: 0x009AA649
		public unsafe bool SlideToLeftOrTop
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SNavigationGroup.__PropertyOffset_15) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SNavigationGroup.__PropertyOffset_15) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005DB0 RID: 23984
		// (get) Token: 0x060286D0 RID: 165584 RVA: 0x009AC45A File Offset: 0x009AA65A
		// (set) Token: 0x060286D1 RID: 165585 RVA: 0x009AC46A File Offset: 0x009AA66A
		public unsafe bool SlideToRightOrDown
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SNavigationGroup.__PropertyOffset_16) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SNavigationGroup.__PropertyOffset_16) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005DB1 RID: 23985
		// (get) Token: 0x060286D2 RID: 165586 RVA: 0x009AC47B File Offset: 0x009AA67B
		// (set) Token: 0x060286D3 RID: 165587 RVA: 0x009AC48B File Offset: 0x009AA68B
		public unsafe bool WaitScrollAnimation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SNavigationGroup.__PropertyOffset_17) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SNavigationGroup.__PropertyOffset_17) = (value ? 1 : 0);
			}
		}

		// Token: 0x060286D4 RID: 165588 RVA: 0x009AC49C File Offset: 0x009AA69C
		public SNavigationGroup()
		{
		}

		// Token: 0x060286D5 RID: 165589 RVA: 0x009AC4A4 File Offset: 0x009AA6A4
		public SNavigationGroup(string GroupName, int GroupType, string PrevGroupName, string NextGroupName, string InsideGroupName, TArray<string> ExtraInsideGroupNameList, TMap<string, string> GroupNameMap, UINavigationWrapMode HorizontalWrapMode, UINavigationPriorityMode HorizontalPriorityMode, UINavigationWrapMode VerticalWrapMode, UINavigationPriorityMode VerticalPriorityMode, bool SelectableMemory, bool AllowNavigationInSelfDynamic, bool RefreshNavigation, bool SuitableListenerByNoDynamic, bool SlideToLeftOrTop, bool SlideToRightOrDown, bool WaitScrollAnimation)
		{
			this.GroupName = GroupName;
			this.GroupType = GroupType;
			this.PrevGroupName = PrevGroupName;
			this.NextGroupName = NextGroupName;
			this.InsideGroupName = InsideGroupName;
			this.ExtraInsideGroupNameList = ExtraInsideGroupNameList;
			this.GroupNameMap = GroupNameMap;
			this.HorizontalWrapMode = HorizontalWrapMode;
			this.HorizontalPriorityMode = HorizontalPriorityMode;
			this.VerticalWrapMode = VerticalWrapMode;
			this.VerticalPriorityMode = VerticalPriorityMode;
			this.SelectableMemory = SelectableMemory;
			this.AllowNavigationInSelfDynamic = AllowNavigationInSelfDynamic;
			this.RefreshNavigation = RefreshNavigation;
			this.SuitableListenerByNoDynamic = SuitableListenerByNoDynamic;
			this.SlideToLeftOrTop = SlideToLeftOrTop;
			this.SlideToRightOrDown = SlideToRightOrDown;
			this.WaitScrollAnimation = WaitScrollAnimation;
		}

		// Token: 0x060286D6 RID: 165590 RVA: 0x009AC544 File Offset: 0x009AA744
		protected override IntPtr GetUStructPtr()
		{
			return SNavigationGroup.StaticStruct();
		}

		// Token: 0x060286D7 RID: 165591 RVA: 0x009AC550 File Offset: 0x009AA750
		[NullableContext(2)]
		public SNavigationGroup(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060286D8 RID: 165592 RVA: 0x009AC55A File Offset: 0x009AA75A
		public SNavigationGroup(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060286D9 RID: 165593 RVA: 0x009AC565 File Offset: 0x009AA765
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SNavigationGroup(Pointer, false, true);
		}

		// Token: 0x060286DA RID: 165594 RVA: 0x009AC56F File Offset: 0x009AA76F
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SNavigationGroup(Pointer, MemoryOwner);
		}

		// Token: 0x040149B4 RID: 84404
		public const string __ObjectPath = "/Game/Aki/Data/UiNavigation/Struct/SNavigationGroup.SNavigationGroup";

		// Token: 0x040149B5 RID: 84405
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040149B6 RID: 84406
		internal static int __PropertyOffset_0;

		// Token: 0x040149B7 RID: 84407
		internal static int __PropertyOffset_1;

		// Token: 0x040149B8 RID: 84408
		internal static int __PropertyOffset_2;

		// Token: 0x040149B9 RID: 84409
		internal static int __PropertyOffset_3;

		// Token: 0x040149BA RID: 84410
		internal static int __PropertyOffset_4;

		// Token: 0x040149BB RID: 84411
		internal static int __PropertyOffset_5;

		// Token: 0x040149BC RID: 84412
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _ExtraInsideGroupNameList;

		// Token: 0x040149BD RID: 84413
		internal static int __PropertyOffset_6;

		// Token: 0x040149BE RID: 84414
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<string, string> _GroupNameMap;

		// Token: 0x040149BF RID: 84415
		internal static int __PropertyOffset_7;

		// Token: 0x040149C0 RID: 84416
		internal static int __PropertyOffset_8;

		// Token: 0x040149C1 RID: 84417
		internal static int __PropertyOffset_9;

		// Token: 0x040149C2 RID: 84418
		internal static int __PropertyOffset_10;

		// Token: 0x040149C3 RID: 84419
		internal static int __PropertyOffset_11;

		// Token: 0x040149C4 RID: 84420
		internal static int __PropertyOffset_12;

		// Token: 0x040149C5 RID: 84421
		internal static int __PropertyOffset_13;

		// Token: 0x040149C6 RID: 84422
		internal static int __PropertyOffset_14;

		// Token: 0x040149C7 RID: 84423
		internal static int __PropertyOffset_15;

		// Token: 0x040149C8 RID: 84424
		internal static int __PropertyOffset_16;

		// Token: 0x040149C9 RID: 84425
		internal static int __PropertyOffset_17;
	}
}

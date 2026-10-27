using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Qte
{
	// Token: 0x02003ED5 RID: 16085
	[UnrealObjectPath("/Game/Aki/Data/Qte/SCommonQteButton.SCommonQteButton")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 104)]
	public class SCommonQteButton : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06028AAA RID: 166570 RVA: 0x009B1BE9 File Offset: 0x009AFDE9
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SCommonQteButton._ScriptStructPtr != 0) ? SCommonQteButton._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Qte/SCommonQteButton.SCommonQteButton", ref SCommonQteButton._ScriptStructPtr);
		}

		// Token: 0x17005EFE RID: 24318
		// (get) Token: 0x06028AAB RID: 166571 RVA: 0x009B1C0D File Offset: 0x009AFE0D
		// (set) Token: 0x06028AAC RID: 166572 RVA: 0x009B1C21 File Offset: 0x009AFE21
		public unsafe TEnumAsByte<ECommonQteActionType> ActionType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQteButton.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQteButton.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17005EFF RID: 24319
		// (get) Token: 0x06028AAD RID: 166573 RVA: 0x009B1C36 File Offset: 0x009AFE36
		// (set) Token: 0x06028AAE RID: 166574 RVA: 0x009B1C46 File Offset: 0x009AFE46
		public unsafe int ActionId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQteButton.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQteButton.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17005F00 RID: 24320
		// (get) Token: 0x06028AAF RID: 166575 RVA: 0x009B1C57 File Offset: 0x009AFE57
		// (set) Token: 0x06028AB0 RID: 166576 RVA: 0x009B1C6B File Offset: 0x009AFE6B
		public unsafe TEnumAsByte<ECommonQteInputAction> Action
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQteButton.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQteButton.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17005F01 RID: 24321
		// (get) Token: 0x06028AB1 RID: 166577 RVA: 0x009B1C80 File Offset: 0x009AFE80
		// (set) Token: 0x06028AB2 RID: 166578 RVA: 0x009B1C9F File Offset: 0x009AFE9F
		[Nullable(1)]
		public TSoftObjectPtr<ULGUITexturePackerSpriteData> Icon
		{
			[NullableContext(1)]
			get
			{
				return new TSoftObjectPtr<ULGUITexturePackerSpriteData>(base.NativePtr + (IntPtr)SCommonQteButton.__PropertyOffset_3, base.MemoryOwner ?? this);
			}
			[NullableContext(1)]
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SCommonQteButton.__PropertyOffset_3, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17005F02 RID: 24322
		// (get) Token: 0x06028AB3 RID: 166579 RVA: 0x009B1CC4 File Offset: 0x009AFEC4
		// (set) Token: 0x06028AB4 RID: 166580 RVA: 0x009B1CD4 File Offset: 0x009AFED4
		public unsafe UIAnchorHorizontalAlign AnchorHAlign
		{
			get
			{
				return (UIAnchorHorizontalAlign)(*(base.NativePtr + (IntPtr)SCommonQteButton.__PropertyOffset_4));
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQteButton.__PropertyOffset_4) = (byte)value;
			}
		}

		// Token: 0x17005F03 RID: 24323
		// (get) Token: 0x06028AB5 RID: 166581 RVA: 0x009B1CE5 File Offset: 0x009AFEE5
		// (set) Token: 0x06028AB6 RID: 166582 RVA: 0x009B1CF5 File Offset: 0x009AFEF5
		public unsafe UIAnchorVerticalAlign AnchorVAlign
		{
			get
			{
				return (UIAnchorVerticalAlign)(*(base.NativePtr + (IntPtr)SCommonQteButton.__PropertyOffset_5));
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQteButton.__PropertyOffset_5) = (byte)value;
			}
		}

		// Token: 0x17005F04 RID: 24324
		// (get) Token: 0x06028AB7 RID: 166583 RVA: 0x009B1D06 File Offset: 0x009AFF06
		// (set) Token: 0x06028AB8 RID: 166584 RVA: 0x009B1D1A File Offset: 0x009AFF1A
		public unsafe FVector2D AnchorOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQteButton.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQteButton.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17005F05 RID: 24325
		// (get) Token: 0x06028AB9 RID: 166585 RVA: 0x009B1D2F File Offset: 0x009AFF2F
		// (set) Token: 0x06028ABA RID: 166586 RVA: 0x009B1D43 File Offset: 0x009AFF43
		public unsafe FRotator AnchorRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQteButton.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQteButton.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17005F06 RID: 24326
		// (get) Token: 0x06028ABB RID: 166587 RVA: 0x009B1D58 File Offset: 0x009AFF58
		// (set) Token: 0x06028ABC RID: 166588 RVA: 0x009B1D6C File Offset: 0x009AFF6C
		[Nullable(1)]
		public unsafe string TextId
		{
			[NullableContext(1)]
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SCommonQteButton.__PropertyOffset_8)));
			}
			[NullableContext(1)]
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SCommonQteButton.__PropertyOffset_8)), value);
			}
		}

		// Token: 0x06028ABD RID: 166589 RVA: 0x009B1D81 File Offset: 0x009AFF81
		public SCommonQteButton()
		{
		}

		// Token: 0x06028ABE RID: 166590 RVA: 0x009B1D8C File Offset: 0x009AFF8C
		public SCommonQteButton(TEnumAsByte<ECommonQteActionType> ActionType, int ActionId, TEnumAsByte<ECommonQteInputAction> Action, [Nullable(1)] TSoftObjectPtr<ULGUITexturePackerSpriteData> Icon, UIAnchorHorizontalAlign AnchorHAlign, UIAnchorVerticalAlign AnchorVAlign, FVector2D AnchorOffset, FRotator AnchorRotation, [Nullable(1)] string TextId)
		{
			this.ActionType = ActionType;
			this.ActionId = ActionId;
			this.Action = Action;
			this.Icon = Icon;
			this.AnchorHAlign = AnchorHAlign;
			this.AnchorVAlign = AnchorVAlign;
			this.AnchorOffset = AnchorOffset;
			this.AnchorRotation = AnchorRotation;
			this.TextId = TextId;
		}

		// Token: 0x06028ABF RID: 166591 RVA: 0x009B1DE4 File Offset: 0x009AFFE4
		protected override IntPtr GetUStructPtr()
		{
			return SCommonQteButton.StaticStruct();
		}

		// Token: 0x06028AC0 RID: 166592 RVA: 0x009B1DF0 File Offset: 0x009AFFF0
		[NullableContext(2)]
		public SCommonQteButton(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06028AC1 RID: 166593 RVA: 0x009B1DFA File Offset: 0x009AFFFA
		public SCommonQteButton(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06028AC2 RID: 166594 RVA: 0x009B1E05 File Offset: 0x009B0005
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SCommonQteButton(Pointer, false, true);
		}

		// Token: 0x06028AC3 RID: 166595 RVA: 0x009B1E0F File Offset: 0x009B000F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SCommonQteButton(Pointer, MemoryOwner);
		}

		// Token: 0x04014C98 RID: 85144
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Data/Qte/SCommonQteButton.SCommonQteButton";

		// Token: 0x04014C99 RID: 85145
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014C9A RID: 85146
		internal static int __PropertyOffset_0;

		// Token: 0x04014C9B RID: 85147
		internal static int __PropertyOffset_1;

		// Token: 0x04014C9C RID: 85148
		internal static int __PropertyOffset_2;

		// Token: 0x04014C9D RID: 85149
		internal static int __PropertyOffset_3;

		// Token: 0x04014C9E RID: 85150
		internal static int __PropertyOffset_4;

		// Token: 0x04014C9F RID: 85151
		internal static int __PropertyOffset_5;

		// Token: 0x04014CA0 RID: 85152
		internal static int __PropertyOffset_6;

		// Token: 0x04014CA1 RID: 85153
		internal static int __PropertyOffset_7;

		// Token: 0x04014CA2 RID: 85154
		internal static int __PropertyOffset_8;
	}
}

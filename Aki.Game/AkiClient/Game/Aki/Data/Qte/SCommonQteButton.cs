using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Qte
{
	// Token: 0x0200319A RID: 12698
	[UnrealObjectPath("/Game/Aki/Data/Qte/SCommonQteButton.SCommonQteButton")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 104)]
	public class SCommonQteButton : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601F4DC RID: 128220 RVA: 0x0092AD54 File Offset: 0x00928F54
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SCommonQteButton._ScriptStructPtr != 0) ? SCommonQteButton._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Qte/SCommonQteButton.SCommonQteButton", ref SCommonQteButton._ScriptStructPtr);
		}

		// Token: 0x1700388A RID: 14474
		// (get) Token: 0x0601F4DD RID: 128221 RVA: 0x0092AD78 File Offset: 0x00928F78
		// (set) Token: 0x0601F4DE RID: 128222 RVA: 0x0092AD8C File Offset: 0x00928F8C
		public unsafe TEnumAsByte<ECommonQteActionType> ActionType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQteButton.__PropertyOffset_ActionType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQteButton.__PropertyOffset_ActionType) = value;
			}
		}

		// Token: 0x1700388B RID: 14475
		// (get) Token: 0x0601F4DF RID: 128223 RVA: 0x0092ADA1 File Offset: 0x00928FA1
		// (set) Token: 0x0601F4E0 RID: 128224 RVA: 0x0092ADB1 File Offset: 0x00928FB1
		public unsafe int ActionId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQteButton.__PropertyOffset_ActionId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQteButton.__PropertyOffset_ActionId) = value;
			}
		}

		// Token: 0x1700388C RID: 14476
		// (get) Token: 0x0601F4E1 RID: 128225 RVA: 0x0092ADC2 File Offset: 0x00928FC2
		// (set) Token: 0x0601F4E2 RID: 128226 RVA: 0x0092ADD6 File Offset: 0x00928FD6
		public unsafe TEnumAsByte<ECommonQteInputAction> Action
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQteButton.__PropertyOffset_Action);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQteButton.__PropertyOffset_Action) = value;
			}
		}

		// Token: 0x1700388D RID: 14477
		// (get) Token: 0x0601F4E3 RID: 128227 RVA: 0x0092ADEB File Offset: 0x00928FEB
		// (set) Token: 0x0601F4E4 RID: 128228 RVA: 0x0092AE0A File Offset: 0x0092900A
		[Nullable(1)]
		public TSoftObjectPtr<ULGUITexturePackerSpriteData> Icon
		{
			[NullableContext(1)]
			get
			{
				return new TSoftObjectPtr<ULGUITexturePackerSpriteData>(base.NativePtr + (IntPtr)SCommonQteButton.__PropertyOffset_Icon, base.MemoryOwner ?? this);
			}
			[NullableContext(1)]
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SCommonQteButton.__PropertyOffset_Icon, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x1700388E RID: 14478
		// (get) Token: 0x0601F4E5 RID: 128229 RVA: 0x0092AE2F File Offset: 0x0092902F
		// (set) Token: 0x0601F4E6 RID: 128230 RVA: 0x0092AE3F File Offset: 0x0092903F
		public unsafe UIAnchorHorizontalAlign AnchorHAlign
		{
			get
			{
				return (UIAnchorHorizontalAlign)(*(base.NativePtr + (IntPtr)SCommonQteButton.__PropertyOffset_AnchorHAlign));
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQteButton.__PropertyOffset_AnchorHAlign) = (byte)value;
			}
		}

		// Token: 0x1700388F RID: 14479
		// (get) Token: 0x0601F4E7 RID: 128231 RVA: 0x0092AE50 File Offset: 0x00929050
		// (set) Token: 0x0601F4E8 RID: 128232 RVA: 0x0092AE60 File Offset: 0x00929060
		public unsafe UIAnchorVerticalAlign AnchorVAlign
		{
			get
			{
				return (UIAnchorVerticalAlign)(*(base.NativePtr + (IntPtr)SCommonQteButton.__PropertyOffset_AnchorVAlign));
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQteButton.__PropertyOffset_AnchorVAlign) = (byte)value;
			}
		}

		// Token: 0x17003890 RID: 14480
		// (get) Token: 0x0601F4E9 RID: 128233 RVA: 0x0092AE71 File Offset: 0x00929071
		// (set) Token: 0x0601F4EA RID: 128234 RVA: 0x0092AE85 File Offset: 0x00929085
		public unsafe FVector2D AnchorOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQteButton.__PropertyOffset_AnchorOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQteButton.__PropertyOffset_AnchorOffset) = value;
			}
		}

		// Token: 0x17003891 RID: 14481
		// (get) Token: 0x0601F4EB RID: 128235 RVA: 0x0092AE9A File Offset: 0x0092909A
		// (set) Token: 0x0601F4EC RID: 128236 RVA: 0x0092AEAE File Offset: 0x009290AE
		public unsafe FRotator AnchorRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQteButton.__PropertyOffset_AnchorRotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQteButton.__PropertyOffset_AnchorRotation) = value;
			}
		}

		// Token: 0x17003892 RID: 14482
		// (get) Token: 0x0601F4ED RID: 128237 RVA: 0x0092AEC3 File Offset: 0x009290C3
		// (set) Token: 0x0601F4EE RID: 128238 RVA: 0x0092AED7 File Offset: 0x009290D7
		[Nullable(1)]
		public unsafe string TextId
		{
			[NullableContext(1)]
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SCommonQteButton.__PropertyOffset_TextId)));
			}
			[NullableContext(1)]
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SCommonQteButton.__PropertyOffset_TextId)), value);
			}
		}

		// Token: 0x0601F4EF RID: 128239 RVA: 0x0092AEEC File Offset: 0x009290EC
		public SCommonQteButton()
		{
		}

		// Token: 0x0601F4F0 RID: 128240 RVA: 0x0092AEF4 File Offset: 0x009290F4
		protected override IntPtr GetUStructPtr()
		{
			return SCommonQteButton.StaticStruct();
		}

		// Token: 0x0601F4F1 RID: 128241 RVA: 0x0092AF00 File Offset: 0x00929100
		[NullableContext(2)]
		public SCommonQteButton(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F4F2 RID: 128242 RVA: 0x0092AF0A File Offset: 0x0092910A
		public SCommonQteButton(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F4F3 RID: 128243 RVA: 0x0092AF15 File Offset: 0x00929115
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SCommonQteButton(Pointer, false, true);
		}

		// Token: 0x0601F4F4 RID: 128244 RVA: 0x0092AF1F File Offset: 0x0092911F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SCommonQteButton(Pointer, MemoryOwner);
		}

		// Token: 0x04010C7F RID: 68735
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Data/Qte/SCommonQteButton.SCommonQteButton";

		// Token: 0x04010C80 RID: 68736
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010C81 RID: 68737
		internal static int __PropertyOffset_ActionType;

		// Token: 0x04010C82 RID: 68738
		internal static int __PropertyOffset_ActionId;

		// Token: 0x04010C83 RID: 68739
		internal static int __PropertyOffset_Action;

		// Token: 0x04010C84 RID: 68740
		internal static int __PropertyOffset_Icon;

		// Token: 0x04010C85 RID: 68741
		internal static int __PropertyOffset_AnchorHAlign;

		// Token: 0x04010C86 RID: 68742
		internal static int __PropertyOffset_AnchorVAlign;

		// Token: 0x04010C87 RID: 68743
		internal static int __PropertyOffset_AnchorOffset;

		// Token: 0x04010C88 RID: 68744
		internal static int __PropertyOffset_AnchorRotation;

		// Token: 0x04010C89 RID: 68745
		internal static int __PropertyOffset_TextId;
	}
}

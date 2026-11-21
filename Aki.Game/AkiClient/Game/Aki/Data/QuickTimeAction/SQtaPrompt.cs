using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.QuickTimeAction
{
	// Token: 0x02003180 RID: 12672
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Data/QuickTimeAction/SQtaPrompt.SQtaPrompt")]
	[UnrealStructLayout(264, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 264)]
	public class SQtaPrompt : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601F423 RID: 128035 RVA: 0x00929C58 File Offset: 0x00927E58
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SQtaPrompt._ScriptStructPtr != 0) ? SQtaPrompt._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/QuickTimeAction/SQtaPrompt.SQtaPrompt", ref SQtaPrompt._ScriptStructPtr);
		}

		// Token: 0x17003858 RID: 14424
		// (get) Token: 0x0601F424 RID: 128036 RVA: 0x00929C7C File Offset: 0x00927E7C
		// (set) Token: 0x0601F425 RID: 128037 RVA: 0x00929C90 File Offset: 0x00927E90
		public unsafe TEnumAsByte<EQtaPromptType> PromptType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQtaPrompt.__PropertyOffset_PromptType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQtaPrompt.__PropertyOffset_PromptType) = value;
			}
		}

		// Token: 0x17003859 RID: 14425
		// (get) Token: 0x0601F426 RID: 128038 RVA: 0x00929CA8 File Offset: 0x00927EA8
		// (set) Token: 0x0601F427 RID: 128039 RVA: 0x00929CEB File Offset: 0x00927EEB
		[Nullable(1)]
		public SQtaPrompt_Content PromptContent
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				SQtaPrompt_Content result;
				if ((result = this._PromptContent) == null)
				{
					result = (this._PromptContent = new SQtaPrompt_Content(base.NativePtr + (IntPtr)SQtaPrompt.__PropertyOffset_PromptContent, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SQtaPrompt_Content.StaticStruct(), base.NativePtr + (IntPtr)SQtaPrompt.__PropertyOffset_PromptContent, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601F428 RID: 128040 RVA: 0x00929D0C File Offset: 0x00927F0C
		public SQtaPrompt()
		{
		}

		// Token: 0x0601F429 RID: 128041 RVA: 0x00929D14 File Offset: 0x00927F14
		protected override IntPtr GetUStructPtr()
		{
			return SQtaPrompt.StaticStruct();
		}

		// Token: 0x0601F42A RID: 128042 RVA: 0x00929D20 File Offset: 0x00927F20
		[NullableContext(2)]
		public SQtaPrompt(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F42B RID: 128043 RVA: 0x00929D2A File Offset: 0x00927F2A
		public SQtaPrompt(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F42C RID: 128044 RVA: 0x00929D35 File Offset: 0x00927F35
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SQtaPrompt(Pointer, false, true);
		}

		// Token: 0x0601F42D RID: 128045 RVA: 0x00929D3F File Offset: 0x00927F3F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SQtaPrompt(Pointer, MemoryOwner);
		}

		// Token: 0x04010BA5 RID: 68517
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Data/QuickTimeAction/SQtaPrompt.SQtaPrompt";

		// Token: 0x04010BA6 RID: 68518
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010BA7 RID: 68519
		internal static int __PropertyOffset_PromptType;

		// Token: 0x04010BA8 RID: 68520
		internal static int __PropertyOffset_PromptContent;

		// Token: 0x04010BA9 RID: 68521
		[Nullable(2)]
		private SQtaPrompt_Content _PromptContent;
	}
}

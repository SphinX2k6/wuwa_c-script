using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.QuickTimeAction
{
	// Token: 0x02003EB3 RID: 16051
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Data/QuickTimeAction/SQtaPrompt.SQtaPrompt")]
	[UnrealStructLayout(264, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 264)]
	public class SQtaPrompt : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06028982 RID: 166274 RVA: 0x009B008A File Offset: 0x009AE28A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SQtaPrompt._ScriptStructPtr != 0) ? SQtaPrompt._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/QuickTimeAction/SQtaPrompt.SQtaPrompt", ref SQtaPrompt._ScriptStructPtr);
		}

		// Token: 0x17005EA8 RID: 24232
		// (get) Token: 0x06028983 RID: 166275 RVA: 0x009B00AE File Offset: 0x009AE2AE
		// (set) Token: 0x06028984 RID: 166276 RVA: 0x009B00C2 File Offset: 0x009AE2C2
		public unsafe TEnumAsByte<EQtaPromptType> PromptType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQtaPrompt.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQtaPrompt.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17005EA9 RID: 24233
		// (get) Token: 0x06028985 RID: 166277 RVA: 0x009B00D8 File Offset: 0x009AE2D8
		// (set) Token: 0x06028986 RID: 166278 RVA: 0x009B011B File Offset: 0x009AE31B
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
					result = (this._PromptContent = new SQtaPrompt_Content(base.NativePtr + (IntPtr)SQtaPrompt.__PropertyOffset_1, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SQtaPrompt_Content.StaticStruct(), base.NativePtr + (IntPtr)SQtaPrompt.__PropertyOffset_1, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06028987 RID: 166279 RVA: 0x009B013C File Offset: 0x009AE33C
		public SQtaPrompt()
		{
		}

		// Token: 0x06028988 RID: 166280 RVA: 0x009B0144 File Offset: 0x009AE344
		public SQtaPrompt(TEnumAsByte<EQtaPromptType> PromptType, [Nullable(1)] SQtaPrompt_Content PromptContent)
		{
			this.PromptType = PromptType;
			this.PromptContent = PromptContent;
		}

		// Token: 0x06028989 RID: 166281 RVA: 0x009B015A File Offset: 0x009AE35A
		protected override IntPtr GetUStructPtr()
		{
			return SQtaPrompt.StaticStruct();
		}

		// Token: 0x0602898A RID: 166282 RVA: 0x009B0166 File Offset: 0x009AE366
		[NullableContext(2)]
		public SQtaPrompt(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602898B RID: 166283 RVA: 0x009B0170 File Offset: 0x009AE370
		public SQtaPrompt(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602898C RID: 166284 RVA: 0x009B017B File Offset: 0x009AE37B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SQtaPrompt(Pointer, false, true);
		}

		// Token: 0x0602898D RID: 166285 RVA: 0x009B0185 File Offset: 0x009AE385
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SQtaPrompt(Pointer, MemoryOwner);
		}

		// Token: 0x04014B7D RID: 84861
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Data/QuickTimeAction/SQtaPrompt.SQtaPrompt";

		// Token: 0x04014B7E RID: 84862
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014B7F RID: 84863
		internal static int __PropertyOffset_0;

		// Token: 0x04014B80 RID: 84864
		internal static int __PropertyOffset_1;

		// Token: 0x04014B81 RID: 84865
		[Nullable(2)]
		private SQtaPrompt_Content _PromptContent;
	}
}

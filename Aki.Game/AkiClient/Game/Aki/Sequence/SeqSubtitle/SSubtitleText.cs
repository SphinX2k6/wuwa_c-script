using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Sequence.SeqSubtitle
{
	// Token: 0x02003A27 RID: 14887
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Sequence/SeqSubtitle/SSubtitleText.SSubtitleText")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class SSubtitleText : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601F50D RID: 128269 RVA: 0x008B4DEC File Offset: 0x008B2FEC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SSubtitleText._ScriptStructPtr != 0) ? SSubtitleText._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Sequence/SeqSubtitle/SSubtitleText.SSubtitleText", ref SSubtitleText._ScriptStructPtr);
		}

		// Token: 0x17002AC2 RID: 10946
		// (get) Token: 0x0601F50E RID: 128270 RVA: 0x008B4E10 File Offset: 0x008B3010
		// (set) Token: 0x0601F50F RID: 128271 RVA: 0x008B4E53 File Offset: 0x008B3053
		public unsafe FText CharacterName
		{
			get
			{
				base.FastCheckIsValid();
				FText result;
				if ((result = this._CharacterName) == null)
				{
					result = (this._CharacterName = new FText(base.NativePtr + (IntPtr)SSubtitleText.__PropertyOffset_0, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				FText.NativeCopy((void*)(base.NativePtr + (byte*)((IntPtr)SSubtitleText.__PropertyOffset_0)), value.NativePtr, 1);
			}
		}

		// Token: 0x17002AC3 RID: 10947
		// (get) Token: 0x0601F510 RID: 128272 RVA: 0x008B4E6E File Offset: 0x008B306E
		// (set) Token: 0x0601F511 RID: 128273 RVA: 0x008B4E82 File Offset: 0x008B3082
		[Nullable(0)]
		public unsafe TEnumAsByte<ESubtitleType> SubtitleType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SSubtitleText.__PropertyOffset_1);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SSubtitleText.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17002AC4 RID: 10948
		// (get) Token: 0x0601F512 RID: 128274 RVA: 0x008B4E98 File Offset: 0x008B3098
		// (set) Token: 0x0601F513 RID: 128275 RVA: 0x008B4EDB File Offset: 0x008B30DB
		public TArray<FText> Subtitles
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FText> result;
				if ((result = this._Subtitles) == null)
				{
					result = (this._Subtitles = new TArray<FText>(base.NativePtr + (IntPtr)SSubtitleText.__PropertyOffset_2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Subtitles.CopyAssign(value);
			}
		}

		// Token: 0x0601F514 RID: 128276 RVA: 0x008B4EE9 File Offset: 0x008B30E9
		public SSubtitleText()
		{
		}

		// Token: 0x0601F515 RID: 128277 RVA: 0x008B4EF1 File Offset: 0x008B30F1
		public SSubtitleText(FText CharacterName, [Nullable(0)] TEnumAsByte<ESubtitleType> SubtitleType, TArray<FText> Subtitles)
		{
			this.CharacterName = CharacterName;
			this.SubtitleType = SubtitleType;
			this.Subtitles = Subtitles;
		}

		// Token: 0x0601F516 RID: 128278 RVA: 0x008B4F0E File Offset: 0x008B310E
		protected override IntPtr GetUStructPtr()
		{
			return SSubtitleText.StaticStruct();
		}

		// Token: 0x0601F517 RID: 128279 RVA: 0x008B4F1A File Offset: 0x008B311A
		[NullableContext(2)]
		public SSubtitleText(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F518 RID: 128280 RVA: 0x008B4F24 File Offset: 0x008B3124
		public SSubtitleText(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F519 RID: 128281 RVA: 0x008B4F2F File Offset: 0x008B312F
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SSubtitleText(Pointer, false, true);
		}

		// Token: 0x0601F51A RID: 128282 RVA: 0x008B4F39 File Offset: 0x008B3139
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SSubtitleText(Pointer, MemoryOwner);
		}

		// Token: 0x0400F064 RID: 61540
		public const string __ObjectPath = "/Game/Aki/Sequence/SeqSubtitle/SSubtitleText.SSubtitleText";

		// Token: 0x0400F065 RID: 61541
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400F066 RID: 61542
		internal static int __PropertyOffset_0;

		// Token: 0x0400F067 RID: 61543
		[Nullable(2)]
		private FText _CharacterName;

		// Token: 0x0400F068 RID: 61544
		internal static int __PropertyOffset_1;

		// Token: 0x0400F069 RID: 61545
		internal static int __PropertyOffset_2;

		// Token: 0x0400F06A RID: 61546
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FText> _Subtitles;
	}
}

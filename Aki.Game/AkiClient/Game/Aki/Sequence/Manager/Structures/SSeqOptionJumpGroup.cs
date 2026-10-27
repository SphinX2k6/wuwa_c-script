using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Sequence.Manager.Structures
{
	// Token: 0x02003A36 RID: 14902
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Sequence/Manager/Structures/SSeqOptionJumpGroup.SSeqOptionJumpGroup")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class SSeqOptionJumpGroup : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601F633 RID: 128563 RVA: 0x008B70B0 File Offset: 0x008B52B0
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SSeqOptionJumpGroup._ScriptStructPtr != 0) ? SSeqOptionJumpGroup._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Sequence/Manager/Structures/SSeqOptionJumpGroup.SSeqOptionJumpGroup", ref SSeqOptionJumpGroup._ScriptStructPtr);
		}

		// Token: 0x17002B1A RID: 11034
		// (get) Token: 0x0601F634 RID: 128564 RVA: 0x008B70D4 File Offset: 0x008B52D4
		// (set) Token: 0x0601F635 RID: 128565 RVA: 0x008B70E8 File Offset: 0x008B52E8
		public unsafe FName SubtitleID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSeqOptionJumpGroup.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSeqOptionJumpGroup.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17002B1B RID: 11035
		// (get) Token: 0x0601F636 RID: 128566 RVA: 0x008B7100 File Offset: 0x008B5300
		// (set) Token: 0x0601F637 RID: 128567 RVA: 0x008B7143 File Offset: 0x008B5343
		public TArray<SSeqJumpWithOption> JumpGroup
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SSeqJumpWithOption> result;
				if ((result = this._JumpGroup) == null)
				{
					result = (this._JumpGroup = new TArray<SSeqJumpWithOption>(base.NativePtr + (IntPtr)SSeqOptionJumpGroup.__PropertyOffset_1, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.JumpGroup.CopyAssign(value);
			}
		}

		// Token: 0x0601F638 RID: 128568 RVA: 0x008B7151 File Offset: 0x008B5351
		public SSeqOptionJumpGroup()
		{
		}

		// Token: 0x0601F639 RID: 128569 RVA: 0x008B7159 File Offset: 0x008B5359
		public SSeqOptionJumpGroup(FName SubtitleID, TArray<SSeqJumpWithOption> JumpGroup)
		{
			this.SubtitleID = SubtitleID;
			this.JumpGroup = JumpGroup;
		}

		// Token: 0x0601F63A RID: 128570 RVA: 0x008B716F File Offset: 0x008B536F
		protected override IntPtr GetUStructPtr()
		{
			return SSeqOptionJumpGroup.StaticStruct();
		}

		// Token: 0x0601F63B RID: 128571 RVA: 0x008B717B File Offset: 0x008B537B
		[NullableContext(2)]
		public SSeqOptionJumpGroup(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F63C RID: 128572 RVA: 0x008B7185 File Offset: 0x008B5385
		public SSeqOptionJumpGroup(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F63D RID: 128573 RVA: 0x008B7190 File Offset: 0x008B5390
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SSeqOptionJumpGroup(Pointer, false, true);
		}

		// Token: 0x0601F63E RID: 128574 RVA: 0x008B719A File Offset: 0x008B539A
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SSeqOptionJumpGroup(Pointer, MemoryOwner);
		}

		// Token: 0x0400F123 RID: 61731
		public const string __ObjectPath = "/Game/Aki/Sequence/Manager/Structures/SSeqOptionJumpGroup.SSeqOptionJumpGroup";

		// Token: 0x0400F124 RID: 61732
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400F125 RID: 61733
		internal static int __PropertyOffset_0;

		// Token: 0x0400F126 RID: 61734
		internal static int __PropertyOffset_1;

		// Token: 0x0400F127 RID: 61735
		[Nullable(2)]
		private TArray<SSeqJumpWithOption> _JumpGroup;
	}
}

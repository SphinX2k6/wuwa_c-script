using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Sequence.Manager.Structures
{
	// Token: 0x02003A34 RID: 14900
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Sequence/Manager/Structures/SSeqCharacterBlendGroup.SSeqCharacterBlendGroup")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class SSeqCharacterBlendGroup : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601F622 RID: 128546 RVA: 0x008B6F42 File Offset: 0x008B5142
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SSeqCharacterBlendGroup._ScriptStructPtr != 0) ? SSeqCharacterBlendGroup._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Sequence/Manager/Structures/SSeqCharacterBlendGroup.SSeqCharacterBlendGroup", ref SSeqCharacterBlendGroup._ScriptStructPtr);
		}

		// Token: 0x17002B19 RID: 11033
		// (get) Token: 0x0601F623 RID: 128547 RVA: 0x008B6F68 File Offset: 0x008B5168
		// (set) Token: 0x0601F624 RID: 128548 RVA: 0x008B6FAB File Offset: 0x008B51AB
		public TArray<SSeqCharacterBlend> BlendGroup
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SSeqCharacterBlend> result;
				if ((result = this._BlendGroup) == null)
				{
					result = (this._BlendGroup = new TArray<SSeqCharacterBlend>(base.NativePtr + (IntPtr)SSeqCharacterBlendGroup.__PropertyOffset_0, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.BlendGroup.CopyAssign(value);
			}
		}

		// Token: 0x0601F625 RID: 128549 RVA: 0x008B6FB9 File Offset: 0x008B51B9
		public SSeqCharacterBlendGroup()
		{
		}

		// Token: 0x0601F626 RID: 128550 RVA: 0x008B6FC1 File Offset: 0x008B51C1
		public SSeqCharacterBlendGroup(TArray<SSeqCharacterBlend> BlendGroup)
		{
			this.BlendGroup = BlendGroup;
		}

		// Token: 0x0601F627 RID: 128551 RVA: 0x008B6FD0 File Offset: 0x008B51D0
		protected override IntPtr GetUStructPtr()
		{
			return SSeqCharacterBlendGroup.StaticStruct();
		}

		// Token: 0x0601F628 RID: 128552 RVA: 0x008B6FDC File Offset: 0x008B51DC
		[NullableContext(2)]
		public SSeqCharacterBlendGroup(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F629 RID: 128553 RVA: 0x008B6FE6 File Offset: 0x008B51E6
		public SSeqCharacterBlendGroup(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F62A RID: 128554 RVA: 0x008B6FF1 File Offset: 0x008B51F1
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SSeqCharacterBlendGroup(Pointer, false, true);
		}

		// Token: 0x0601F62B RID: 128555 RVA: 0x008B6FFB File Offset: 0x008B51FB
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SSeqCharacterBlendGroup(Pointer, MemoryOwner);
		}

		// Token: 0x0400F11B RID: 61723
		public const string __ObjectPath = "/Game/Aki/Sequence/Manager/Structures/SSeqCharacterBlendGroup.SSeqCharacterBlendGroup";

		// Token: 0x0400F11C RID: 61724
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400F11D RID: 61725
		internal static int __PropertyOffset_0;

		// Token: 0x0400F11E RID: 61726
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SSeqCharacterBlend> _BlendGroup;
	}
}

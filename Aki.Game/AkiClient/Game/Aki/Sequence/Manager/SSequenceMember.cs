using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Sequence.Manager
{
	// Token: 0x02003A2F RID: 14895
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Sequence/Manager/SSequenceMember.SSequenceMember")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 88)]
	public class SSequenceMember : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601F5C0 RID: 128448 RVA: 0x008B65DE File Offset: 0x008B47DE
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SSequenceMember._ScriptStructPtr != 0) ? SSequenceMember._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Sequence/Manager/SSequenceMember.SSequenceMember", ref SSequenceMember._ScriptStructPtr);
		}

		// Token: 0x17002AFC RID: 11004
		// (get) Token: 0x0601F5C1 RID: 128449 RVA: 0x008B6602 File Offset: 0x008B4802
		// (set) Token: 0x0601F5C2 RID: 128450 RVA: 0x008B6612 File Offset: 0x008B4812
		public unsafe int SpeakerId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSequenceMember.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSequenceMember.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17002AFD RID: 11005
		// (get) Token: 0x0601F5C3 RID: 128451 RVA: 0x008B6624 File Offset: 0x008B4824
		// (set) Token: 0x0601F5C4 RID: 128452 RVA: 0x008B6667 File Offset: 0x008B4867
		public TMap<string, TSoftClassPtr<UObject>> Bp
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, TSoftClassPtr<UObject>> result;
				if ((result = this._Bp) == null)
				{
					result = (this._Bp = new TMap<string, TSoftClassPtr<UObject>>(base.NativePtr + (IntPtr)SSequenceMember.__PropertyOffset_1, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Bp.CopyAssign(value);
			}
		}

		// Token: 0x0601F5C5 RID: 128453 RVA: 0x008B6675 File Offset: 0x008B4875
		public SSequenceMember()
		{
		}

		// Token: 0x0601F5C6 RID: 128454 RVA: 0x008B667D File Offset: 0x008B487D
		public SSequenceMember(int SpeakerId, TMap<string, TSoftClassPtr<UObject>> Bp)
		{
			this.SpeakerId = SpeakerId;
			this.Bp = Bp;
		}

		// Token: 0x0601F5C7 RID: 128455 RVA: 0x008B6693 File Offset: 0x008B4893
		protected override IntPtr GetUStructPtr()
		{
			return SSequenceMember.StaticStruct();
		}

		// Token: 0x0601F5C8 RID: 128456 RVA: 0x008B669F File Offset: 0x008B489F
		[NullableContext(2)]
		public SSequenceMember(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F5C9 RID: 128457 RVA: 0x008B66A9 File Offset: 0x008B48A9
		public SSequenceMember(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F5CA RID: 128458 RVA: 0x008B66B4 File Offset: 0x008B48B4
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SSequenceMember(Pointer, false, true);
		}

		// Token: 0x0601F5CB RID: 128459 RVA: 0x008B66BE File Offset: 0x008B48BE
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SSequenceMember(Pointer, MemoryOwner);
		}

		// Token: 0x0400F0E8 RID: 61672
		public const string __ObjectPath = "/Game/Aki/Sequence/Manager/SSequenceMember.SSequenceMember";

		// Token: 0x0400F0E9 RID: 61673
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400F0EA RID: 61674
		internal static int __PropertyOffset_0;

		// Token: 0x0400F0EB RID: 61675
		internal static int __PropertyOffset_1;

		// Token: 0x0400F0EC RID: 61676
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		private TMap<string, TSoftClassPtr<UObject>> _Bp;
	}
}

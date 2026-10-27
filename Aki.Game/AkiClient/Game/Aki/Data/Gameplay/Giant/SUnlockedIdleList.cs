using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Gameplay.Giant
{
	// Token: 0x02003F4A RID: 16202
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Gameplay/Giant/SUnlockedIdleList.SUnlockedIdleList")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class SUnlockedIdleList : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060293E9 RID: 168937 RVA: 0x009BF4CF File Offset: 0x009BD6CF
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SUnlockedIdleList._ScriptStructPtr != 0) ? SUnlockedIdleList._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Gameplay/Giant/SUnlockedIdleList.SUnlockedIdleList", ref SUnlockedIdleList._ScriptStructPtr);
		}

		// Token: 0x17006241 RID: 25153
		// (get) Token: 0x060293EA RID: 168938 RVA: 0x009BF4F4 File Offset: 0x009BD6F4
		// (set) Token: 0x060293EB RID: 168939 RVA: 0x009BF537 File Offset: 0x009BD737
		public TArray<FName> IdleKeys
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._IdleKeys) == null)
				{
					result = (this._IdleKeys = new TArray<FName>(base.NativePtr + (IntPtr)SUnlockedIdleList.__PropertyOffset_0, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.IdleKeys.CopyAssign(value);
			}
		}

		// Token: 0x060293EC RID: 168940 RVA: 0x009BF545 File Offset: 0x009BD745
		public SUnlockedIdleList()
		{
		}

		// Token: 0x060293ED RID: 168941 RVA: 0x009BF54D File Offset: 0x009BD74D
		public SUnlockedIdleList(TArray<FName> IdleKeys)
		{
			this.IdleKeys = IdleKeys;
		}

		// Token: 0x060293EE RID: 168942 RVA: 0x009BF55C File Offset: 0x009BD75C
		protected override IntPtr GetUStructPtr()
		{
			return SUnlockedIdleList.StaticStruct();
		}

		// Token: 0x060293EF RID: 168943 RVA: 0x009BF568 File Offset: 0x009BD768
		[NullableContext(2)]
		public SUnlockedIdleList(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060293F0 RID: 168944 RVA: 0x009BF572 File Offset: 0x009BD772
		public SUnlockedIdleList(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060293F1 RID: 168945 RVA: 0x009BF57D File Offset: 0x009BD77D
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SUnlockedIdleList(Pointer, false, true);
		}

		// Token: 0x060293F2 RID: 168946 RVA: 0x009BF587 File Offset: 0x009BD787
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SUnlockedIdleList(Pointer, MemoryOwner);
		}

		// Token: 0x040151F9 RID: 86521
		public const string __ObjectPath = "/Game/Aki/Data/Gameplay/Giant/SUnlockedIdleList.SUnlockedIdleList";

		// Token: 0x040151FA RID: 86522
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040151FB RID: 86523
		internal static int __PropertyOffset_0;

		// Token: 0x040151FC RID: 86524
		[Nullable(2)]
		private TArray<FName> _IdleKeys;
	}
}

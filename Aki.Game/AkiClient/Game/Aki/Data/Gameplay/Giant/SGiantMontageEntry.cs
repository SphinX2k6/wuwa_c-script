using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Gameplay.Giant
{
	// Token: 0x02003F49 RID: 16201
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Data/Gameplay/Giant/SGiantMontageEntry.SGiantMontageEntry")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 49)]
	public class SGiantMontageEntry : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060293DD RID: 168925 RVA: 0x009BF3F4 File Offset: 0x009BD5F4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SGiantMontageEntry._ScriptStructPtr != 0) ? SGiantMontageEntry._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Gameplay/Giant/SGiantMontageEntry.SGiantMontageEntry", ref SGiantMontageEntry._ScriptStructPtr);
		}

		// Token: 0x1700623F RID: 25151
		// (get) Token: 0x060293DE RID: 168926 RVA: 0x009BF418 File Offset: 0x009BD618
		// (set) Token: 0x060293DF RID: 168927 RVA: 0x009BF437 File Offset: 0x009BD637
		public TSoftObjectPtr<UAnimMontage> AssetPath
		{
			get
			{
				return new TSoftObjectPtr<UAnimMontage>(base.NativePtr + (IntPtr)SGiantMontageEntry.__PropertyOffset_0, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SGiantMontageEntry.__PropertyOffset_0, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17006240 RID: 25152
		// (get) Token: 0x060293E0 RID: 168928 RVA: 0x009BF45C File Offset: 0x009BD65C
		// (set) Token: 0x060293E1 RID: 168929 RVA: 0x009BF46C File Offset: 0x009BD66C
		public unsafe bool CanBeInterrupt
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SGiantMontageEntry.__PropertyOffset_1) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SGiantMontageEntry.__PropertyOffset_1) = (value ? 1 : 0);
			}
		}

		// Token: 0x060293E2 RID: 168930 RVA: 0x009BF47D File Offset: 0x009BD67D
		public SGiantMontageEntry()
		{
		}

		// Token: 0x060293E3 RID: 168931 RVA: 0x009BF485 File Offset: 0x009BD685
		public SGiantMontageEntry(TSoftObjectPtr<UAnimMontage> AssetPath, bool CanBeInterrupt)
		{
			this.AssetPath = AssetPath;
			this.CanBeInterrupt = CanBeInterrupt;
		}

		// Token: 0x060293E4 RID: 168932 RVA: 0x009BF49B File Offset: 0x009BD69B
		protected override IntPtr GetUStructPtr()
		{
			return SGiantMontageEntry.StaticStruct();
		}

		// Token: 0x060293E5 RID: 168933 RVA: 0x009BF4A7 File Offset: 0x009BD6A7
		[NullableContext(2)]
		public SGiantMontageEntry(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060293E6 RID: 168934 RVA: 0x009BF4B1 File Offset: 0x009BD6B1
		public SGiantMontageEntry(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060293E7 RID: 168935 RVA: 0x009BF4BC File Offset: 0x009BD6BC
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SGiantMontageEntry(Pointer, false, true);
		}

		// Token: 0x060293E8 RID: 168936 RVA: 0x009BF4C6 File Offset: 0x009BD6C6
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SGiantMontageEntry(Pointer, MemoryOwner);
		}

		// Token: 0x040151F5 RID: 86517
		public const string __ObjectPath = "/Game/Aki/Data/Gameplay/Giant/SGiantMontageEntry.SGiantMontageEntry";

		// Token: 0x040151F6 RID: 86518
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040151F7 RID: 86519
		internal static int __PropertyOffset_0;

		// Token: 0x040151F8 RID: 86520
		internal static int __PropertyOffset_1;
	}
}

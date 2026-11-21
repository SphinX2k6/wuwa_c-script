using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Fight.Struct
{
	// Token: 0x02003201 RID: 12801
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Data/Fight/Struct/SAimPart.SAimPart")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class SAimPart : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601FDD6 RID: 130518 RVA: 0x00937BA5 File Offset: 0x00935DA5
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SAimPart._ScriptStructPtr != 0) ? SAimPart._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Fight/Struct/SAimPart.SAimPart", ref SAimPart._ScriptStructPtr);
		}

		// Token: 0x17003BE5 RID: 15333
		// (get) Token: 0x0601FDD7 RID: 130519 RVA: 0x00937BC9 File Offset: 0x00935DC9
		// (set) Token: 0x0601FDD8 RID: 130520 RVA: 0x00937BDD File Offset: 0x00935DDD
		public unsafe string BoneName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SAimPart.__PropertyOffset_BoneName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SAimPart.__PropertyOffset_BoneName)), value);
			}
		}

		// Token: 0x17003BE6 RID: 15334
		// (get) Token: 0x0601FDD9 RID: 130521 RVA: 0x00937BF2 File Offset: 0x00935DF2
		// (set) Token: 0x0601FDDA RID: 130522 RVA: 0x00937C06 File Offset: 0x00935E06
		public unsafe FVector Offset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SAimPart.__PropertyOffset_Offset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SAimPart.__PropertyOffset_Offset) = value;
			}
		}

		// Token: 0x17003BE7 RID: 15335
		// (get) Token: 0x0601FDDB RID: 130523 RVA: 0x00937C1B File Offset: 0x00935E1B
		// (set) Token: 0x0601FDDC RID: 130524 RVA: 0x00937C2B File Offset: 0x00935E2B
		public unsafe float RadiusIn
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SAimPart.__PropertyOffset_RadiusIn);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SAimPart.__PropertyOffset_RadiusIn) = value;
			}
		}

		// Token: 0x17003BE8 RID: 15336
		// (get) Token: 0x0601FDDD RID: 130525 RVA: 0x00937C3C File Offset: 0x00935E3C
		// (set) Token: 0x0601FDDE RID: 130526 RVA: 0x00937C4C File Offset: 0x00935E4C
		public unsafe float RadiusOut
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SAimPart.__PropertyOffset_RadiusOut);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SAimPart.__PropertyOffset_RadiusOut) = value;
			}
		}

		// Token: 0x17003BE9 RID: 15337
		// (get) Token: 0x0601FDDF RID: 130527 RVA: 0x00937C5D File Offset: 0x00935E5D
		// (set) Token: 0x0601FDE0 RID: 130528 RVA: 0x00937C6D File Offset: 0x00935E6D
		public unsafe float RadiusOutOnStart
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SAimPart.__PropertyOffset_RadiusOutOnStart);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SAimPart.__PropertyOffset_RadiusOutOnStart) = value;
			}
		}

		// Token: 0x17003BEA RID: 15338
		// (get) Token: 0x0601FDE1 RID: 130529 RVA: 0x00937C7E File Offset: 0x00935E7E
		// (set) Token: 0x0601FDE2 RID: 130530 RVA: 0x00937C8E File Offset: 0x00935E8E
		public unsafe float MobileCorrect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SAimPart.__PropertyOffset_MobileCorrect);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SAimPart.__PropertyOffset_MobileCorrect) = value;
			}
		}

		// Token: 0x17003BEB RID: 15339
		// (get) Token: 0x0601FDE3 RID: 130531 RVA: 0x00937C9F File Offset: 0x00935E9F
		// (set) Token: 0x0601FDE4 RID: 130532 RVA: 0x00937CAF File Offset: 0x00935EAF
		public unsafe float GamePadCorrect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SAimPart.__PropertyOffset_GamePadCorrect);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SAimPart.__PropertyOffset_GamePadCorrect) = value;
			}
		}

		// Token: 0x17003BEC RID: 15340
		// (get) Token: 0x0601FDE5 RID: 130533 RVA: 0x00937CC0 File Offset: 0x00935EC0
		// (set) Token: 0x0601FDE6 RID: 130534 RVA: 0x00937CD4 File Offset: 0x00935ED4
		public unsafe string 忽略的骨骼碰撞
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SAimPart.__PropertyOffset_忽略的骨骼碰撞)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SAimPart.__PropertyOffset_忽略的骨骼碰撞)), value);
			}
		}

		// Token: 0x0601FDE7 RID: 130535 RVA: 0x00937CE9 File Offset: 0x00935EE9
		public SAimPart()
		{
		}

		// Token: 0x0601FDE8 RID: 130536 RVA: 0x00937CF1 File Offset: 0x00935EF1
		protected override IntPtr GetUStructPtr()
		{
			return SAimPart.StaticStruct();
		}

		// Token: 0x0601FDE9 RID: 130537 RVA: 0x00937CFD File Offset: 0x00935EFD
		[NullableContext(2)]
		public SAimPart(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601FDEA RID: 130538 RVA: 0x00937D07 File Offset: 0x00935F07
		public SAimPart(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601FDEB RID: 130539 RVA: 0x00937D12 File Offset: 0x00935F12
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SAimPart(Pointer, false, true);
		}

		// Token: 0x0601FDEC RID: 130540 RVA: 0x00937D1C File Offset: 0x00935F1C
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SAimPart(Pointer, MemoryOwner);
		}

		// Token: 0x040111CD RID: 70093
		public const string __ObjectPath = "/Game/Aki/Data/Fight/Struct/SAimPart.SAimPart";

		// Token: 0x040111CE RID: 70094
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040111CF RID: 70095
		internal static int __PropertyOffset_BoneName;

		// Token: 0x040111D0 RID: 70096
		internal static int __PropertyOffset_Offset;

		// Token: 0x040111D1 RID: 70097
		internal static int __PropertyOffset_RadiusIn;

		// Token: 0x040111D2 RID: 70098
		internal static int __PropertyOffset_RadiusOut;

		// Token: 0x040111D3 RID: 70099
		internal static int __PropertyOffset_RadiusOutOnStart;

		// Token: 0x040111D4 RID: 70100
		internal static int __PropertyOffset_MobileCorrect;

		// Token: 0x040111D5 RID: 70101
		internal static int __PropertyOffset_GamePadCorrect;

		// Token: 0x040111D6 RID: 70102
		internal static int __PropertyOffset_忽略的骨骼碰撞;
	}
}

using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.PathLine
{
	// Token: 0x02003EE6 RID: 16102
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Data/PathLine/DTS_PathLine.DTS_PathLine")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class DTS_PathLine : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06028C4C RID: 166988 RVA: 0x009B4341 File Offset: 0x009B2541
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (DTS_PathLine._ScriptStructPtr != 0) ? DTS_PathLine._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/PathLine/DTS_PathLine.DTS_PathLine", ref DTS_PathLine._ScriptStructPtr);
		}

		// Token: 0x17005F87 RID: 24455
		// (get) Token: 0x06028C4D RID: 166989 RVA: 0x009B4365 File Offset: 0x009B2565
		// (set) Token: 0x06028C4E RID: 166990 RVA: 0x009B4379 File Offset: 0x009B2579
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<BP_BasePathLine_C> splinepath
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)DTS_PathLine.__PropertyOffset_0);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)DTS_PathLine.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17005F88 RID: 24456
		// (get) Token: 0x06028C4F RID: 166991 RVA: 0x009B438E File Offset: 0x009B258E
		// (set) Token: 0x06028C50 RID: 166992 RVA: 0x009B439E File Offset: 0x009B259E
		public unsafe bool AutoMove
		{
			get
			{
				return *(base.NativePtr + (IntPtr)DTS_PathLine.__PropertyOffset_1) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)DTS_PathLine.__PropertyOffset_1) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005F89 RID: 24457
		// (get) Token: 0x06028C51 RID: 166993 RVA: 0x009B43AF File Offset: 0x009B25AF
		// (set) Token: 0x06028C52 RID: 166994 RVA: 0x009B43BF File Offset: 0x009B25BF
		public unsafe bool NeedFollow
		{
			get
			{
				return *(base.NativePtr + (IntPtr)DTS_PathLine.__PropertyOffset_2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)DTS_PathLine.__PropertyOffset_2) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005F8A RID: 24458
		// (get) Token: 0x06028C53 RID: 166995 RVA: 0x009B43D0 File Offset: 0x009B25D0
		// (set) Token: 0x06028C54 RID: 166996 RVA: 0x009B43E0 File Offset: 0x009B25E0
		public unsafe bool Back
		{
			get
			{
				return *(base.NativePtr + (IntPtr)DTS_PathLine.__PropertyOffset_3) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)DTS_PathLine.__PropertyOffset_3) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005F8B RID: 24459
		// (get) Token: 0x06028C55 RID: 166997 RVA: 0x009B43F1 File Offset: 0x009B25F1
		// (set) Token: 0x06028C56 RID: 166998 RVA: 0x009B4401 File Offset: 0x009B2601
		public unsafe bool WaitForPlayer
		{
			get
			{
				return *(base.NativePtr + (IntPtr)DTS_PathLine.__PropertyOffset_4) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)DTS_PathLine.__PropertyOffset_4) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005F8C RID: 24460
		// (get) Token: 0x06028C57 RID: 166999 RVA: 0x009B4412 File Offset: 0x009B2612
		// (set) Token: 0x06028C58 RID: 167000 RVA: 0x009B4422 File Offset: 0x009B2622
		public unsafe float MoveSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)DTS_PathLine.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)DTS_PathLine.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17005F8D RID: 24461
		// (get) Token: 0x06028C59 RID: 167001 RVA: 0x009B4433 File Offset: 0x009B2633
		// (set) Token: 0x06028C5A RID: 167002 RVA: 0x009B4443 File Offset: 0x009B2643
		public unsafe int CurrentSlinePoint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)DTS_PathLine.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)DTS_PathLine.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17005F8E RID: 24462
		// (get) Token: 0x06028C5B RID: 167003 RVA: 0x009B4454 File Offset: 0x009B2654
		// (set) Token: 0x06028C5C RID: 167004 RVA: 0x009B4464 File Offset: 0x009B2664
		public unsafe float ActivateRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)DTS_PathLine.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)DTS_PathLine.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17005F8F RID: 24463
		// (get) Token: 0x06028C5D RID: 167005 RVA: 0x009B4475 File Offset: 0x009B2675
		// (set) Token: 0x06028C5E RID: 167006 RVA: 0x009B4489 File Offset: 0x009B2689
		public unsafe string 备注
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)DTS_PathLine.__PropertyOffset_8)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)DTS_PathLine.__PropertyOffset_8)), value);
			}
		}

		// Token: 0x06028C5F RID: 167007 RVA: 0x009B449E File Offset: 0x009B269E
		public DTS_PathLine()
		{
		}

		// Token: 0x06028C60 RID: 167008 RVA: 0x009B44A8 File Offset: 0x009B26A8
		public DTS_PathLine([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<BP_BasePathLine_C> splinepath, bool AutoMove, bool NeedFollow, bool Back, bool WaitForPlayer, float MoveSpeed, int CurrentSlinePoint, float ActivateRange, string 备注)
		{
			this.splinepath = splinepath;
			this.AutoMove = AutoMove;
			this.NeedFollow = NeedFollow;
			this.Back = Back;
			this.WaitForPlayer = WaitForPlayer;
			this.MoveSpeed = MoveSpeed;
			this.CurrentSlinePoint = CurrentSlinePoint;
			this.ActivateRange = ActivateRange;
			this.备注 = 备注;
		}

		// Token: 0x06028C61 RID: 167009 RVA: 0x009B4500 File Offset: 0x009B2700
		protected override IntPtr GetUStructPtr()
		{
			return DTS_PathLine.StaticStruct();
		}

		// Token: 0x06028C62 RID: 167010 RVA: 0x009B450C File Offset: 0x009B270C
		[NullableContext(2)]
		public DTS_PathLine(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06028C63 RID: 167011 RVA: 0x009B4516 File Offset: 0x009B2716
		public DTS_PathLine(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06028C64 RID: 167012 RVA: 0x009B4521 File Offset: 0x009B2721
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new DTS_PathLine(Pointer, false, true);
		}

		// Token: 0x06028C65 RID: 167013 RVA: 0x009B452B File Offset: 0x009B272B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new DTS_PathLine(Pointer, MemoryOwner);
		}

		// Token: 0x04014D6F RID: 85359
		public const string __ObjectPath = "/Game/Aki/Data/PathLine/DTS_PathLine.DTS_PathLine";

		// Token: 0x04014D70 RID: 85360
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014D71 RID: 85361
		internal static int __PropertyOffset_0;

		// Token: 0x04014D72 RID: 85362
		internal static int __PropertyOffset_1;

		// Token: 0x04014D73 RID: 85363
		internal static int __PropertyOffset_2;

		// Token: 0x04014D74 RID: 85364
		internal static int __PropertyOffset_3;

		// Token: 0x04014D75 RID: 85365
		internal static int __PropertyOffset_4;

		// Token: 0x04014D76 RID: 85366
		internal static int __PropertyOffset_5;

		// Token: 0x04014D77 RID: 85367
		internal static int __PropertyOffset_6;

		// Token: 0x04014D78 RID: 85368
		internal static int __PropertyOffset_7;

		// Token: 0x04014D79 RID: 85369
		internal static int __PropertyOffset_8;
	}
}

using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02003355 RID: 13141
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SHitWhirlpool.SHitWhirlpool")]
	[UnrealStructLayout(28, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 25)]
	public class SHitWhirlpool : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021463 RID: 136291 RVA: 0x0095CFE2 File Offset: 0x0095B1E2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SHitWhirlpool._ScriptStructPtr != 0) ? SHitWhirlpool._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SHitWhirlpool.SHitWhirlpool", ref SHitWhirlpool._ScriptStructPtr);
		}

		// Token: 0x17004380 RID: 17280
		// (get) Token: 0x06021464 RID: 136292 RVA: 0x0095D006 File Offset: 0x0095B206
		// (set) Token: 0x06021465 RID: 136293 RVA: 0x0095D01A File Offset: 0x0095B21A
		public unsafe FVector 滞空相对位置
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SHitWhirlpool.__PropertyOffset_滞空相对位置);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SHitWhirlpool.__PropertyOffset_滞空相对位置) = value;
			}
		}

		// Token: 0x17004381 RID: 17281
		// (get) Token: 0x06021466 RID: 136294 RVA: 0x0095D02F File Offset: 0x0095B22F
		// (set) Token: 0x06021467 RID: 136295 RVA: 0x0095D03F File Offset: 0x0095B23F
		public unsafe float 滞空时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SHitWhirlpool.__PropertyOffset_滞空时间);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SHitWhirlpool.__PropertyOffset_滞空时间) = value;
			}
		}

		// Token: 0x17004382 RID: 17282
		// (get) Token: 0x06021468 RID: 136296 RVA: 0x0095D050 File Offset: 0x0095B250
		// (set) Token: 0x06021469 RID: 136297 RVA: 0x0095D060 File Offset: 0x0095B260
		public unsafe float 到滞空点时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SHitWhirlpool.__PropertyOffset_到滞空点时间);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SHitWhirlpool.__PropertyOffset_到滞空点时间) = value;
			}
		}

		// Token: 0x17004383 RID: 17283
		// (get) Token: 0x0602146A RID: 136298 RVA: 0x0095D071 File Offset: 0x0095B271
		// (set) Token: 0x0602146B RID: 136299 RVA: 0x0095D081 File Offset: 0x0095B281
		public unsafe float 滞空高度限制
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SHitWhirlpool.__PropertyOffset_滞空高度限制);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SHitWhirlpool.__PropertyOffset_滞空高度限制) = value;
			}
		}

		// Token: 0x17004384 RID: 17284
		// (get) Token: 0x0602146C RID: 136300 RVA: 0x0095D092 File Offset: 0x0095B292
		// (set) Token: 0x0602146D RID: 136301 RVA: 0x0095D0A6 File Offset: 0x0095B2A6
		public unsafe TEnumAsByte<EVelocityCurveType> 到滞空点曲线
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SHitWhirlpool.__PropertyOffset_到滞空点曲线);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SHitWhirlpool.__PropertyOffset_到滞空点曲线) = value;
			}
		}

		// Token: 0x0602146E RID: 136302 RVA: 0x0095D0BB File Offset: 0x0095B2BB
		public SHitWhirlpool()
		{
		}

		// Token: 0x0602146F RID: 136303 RVA: 0x0095D0C3 File Offset: 0x0095B2C3
		protected override IntPtr GetUStructPtr()
		{
			return SHitWhirlpool.StaticStruct();
		}

		// Token: 0x06021470 RID: 136304 RVA: 0x0095D0CF File Offset: 0x0095B2CF
		[NullableContext(2)]
		public SHitWhirlpool(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021471 RID: 136305 RVA: 0x0095D0D9 File Offset: 0x0095B2D9
		public SHitWhirlpool(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021472 RID: 136306 RVA: 0x0095D0E4 File Offset: 0x0095B2E4
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SHitWhirlpool(Pointer, false, true);
		}

		// Token: 0x06021473 RID: 136307 RVA: 0x0095D0EE File Offset: 0x0095B2EE
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SHitWhirlpool(Pointer, MemoryOwner);
		}

		// Token: 0x04012304 RID: 74500
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SHitWhirlpool.SHitWhirlpool";

		// Token: 0x04012305 RID: 74501
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012306 RID: 74502
		internal static int __PropertyOffset_滞空相对位置;

		// Token: 0x04012307 RID: 74503
		internal static int __PropertyOffset_滞空时间;

		// Token: 0x04012308 RID: 74504
		internal static int __PropertyOffset_到滞空点时间;

		// Token: 0x04012309 RID: 74505
		internal static int __PropertyOffset_滞空高度限制;

		// Token: 0x0401230A RID: 74506
		internal static int __PropertyOffset_到滞空点曲线;
	}
}

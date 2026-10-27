using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.KuroCS.Cloth
{
	// Token: 0x02003C91 RID: 15505
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/KuroCS/Cloth/S_KuroCSClothPreset.S_KuroCSClothPreset")]
	[UnrealStructLayout(80, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 77)]
	public class S_KuroCSClothPreset : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060243E3 RID: 148451 RVA: 0x00939098 File Offset: 0x00937298
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (S_KuroCSClothPreset._ScriptStructPtr != 0) ? S_KuroCSClothPreset._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/PCG/KuroCS/Cloth/S_KuroCSClothPreset.S_KuroCSClothPreset", ref S_KuroCSClothPreset._ScriptStructPtr);
		}

		// Token: 0x170045FA RID: 17914
		// (get) Token: 0x060243E4 RID: 148452 RVA: 0x009390BC File Offset: 0x009372BC
		// (set) Token: 0x060243E5 RID: 148453 RVA: 0x009390CC File Offset: 0x009372CC
		public unsafe int XCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)S_KuroCSClothPreset.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)S_KuroCSClothPreset.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x170045FB RID: 17915
		// (get) Token: 0x060243E6 RID: 148454 RVA: 0x009390DD File Offset: 0x009372DD
		// (set) Token: 0x060243E7 RID: 148455 RVA: 0x009390ED File Offset: 0x009372ED
		public unsafe int YCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)S_KuroCSClothPreset.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)S_KuroCSClothPreset.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x170045FC RID: 17916
		// (get) Token: 0x060243E8 RID: 148456 RVA: 0x009390FE File Offset: 0x009372FE
		// (set) Token: 0x060243E9 RID: 148457 RVA: 0x0093910E File Offset: 0x0093730E
		public unsafe float DisStiffness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)S_KuroCSClothPreset.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)S_KuroCSClothPreset.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x170045FD RID: 17917
		// (get) Token: 0x060243EA RID: 148458 RVA: 0x0093911F File Offset: 0x0093731F
		// (set) Token: 0x060243EB RID: 148459 RVA: 0x0093912F File Offset: 0x0093732F
		public unsafe float BendStiffness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)S_KuroCSClothPreset.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)S_KuroCSClothPreset.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x170045FE RID: 17918
		// (get) Token: 0x060243EC RID: 148460 RVA: 0x00939140 File Offset: 0x00937340
		// (set) Token: 0x060243ED RID: 148461 RVA: 0x00939150 File Offset: 0x00937350
		public unsafe float CollisionR
		{
			get
			{
				return *(base.NativePtr + (IntPtr)S_KuroCSClothPreset.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)S_KuroCSClothPreset.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x170045FF RID: 17919
		// (get) Token: 0x060243EE RID: 148462 RVA: 0x00939161 File Offset: 0x00937361
		// (set) Token: 0x060243EF RID: 148463 RVA: 0x00939171 File Offset: 0x00937371
		public unsafe float LinkDis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)S_KuroCSClothPreset.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)S_KuroCSClothPreset.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17004600 RID: 17920
		// (get) Token: 0x060243F0 RID: 148464 RVA: 0x00939182 File Offset: 0x00937382
		// (set) Token: 0x060243F1 RID: 148465 RVA: 0x00939192 File Offset: 0x00937392
		public unsafe float LinkDisY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)S_KuroCSClothPreset.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)S_KuroCSClothPreset.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17004601 RID: 17921
		// (get) Token: 0x060243F2 RID: 148466 RVA: 0x009391A3 File Offset: 0x009373A3
		// (set) Token: 0x060243F3 RID: 148467 RVA: 0x009391B7 File Offset: 0x009373B7
		public unsafe FVector AccelExt
		{
			get
			{
				return *(base.NativePtr + (IntPtr)S_KuroCSClothPreset.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)S_KuroCSClothPreset.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17004602 RID: 17922
		// (get) Token: 0x060243F4 RID: 148468 RVA: 0x009391CC File Offset: 0x009373CC
		// (set) Token: 0x060243F5 RID: 148469 RVA: 0x009391E0 File Offset: 0x009373E0
		public unsafe FVector PosOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)S_KuroCSClothPreset.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)S_KuroCSClothPreset.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17004603 RID: 17923
		// (get) Token: 0x060243F6 RID: 148470 RVA: 0x009391F5 File Offset: 0x009373F5
		// (set) Token: 0x060243F7 RID: 148471 RVA: 0x00939205 File Offset: 0x00937405
		public unsafe int SubstepCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)S_KuroCSClothPreset.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)S_KuroCSClothPreset.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17004604 RID: 17924
		// (get) Token: 0x060243F8 RID: 148472 RVA: 0x00939216 File Offset: 0x00937416
		// (set) Token: 0x060243F9 RID: 148473 RVA: 0x00939226 File Offset: 0x00937426
		public unsafe bool bYZPlane
		{
			get
			{
				return *(base.NativePtr + (IntPtr)S_KuroCSClothPreset.__PropertyOffset_10) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)S_KuroCSClothPreset.__PropertyOffset_10) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004605 RID: 17925
		// (get) Token: 0x060243FA RID: 148474 RVA: 0x00939237 File Offset: 0x00937437
		// (set) Token: 0x060243FB RID: 148475 RVA: 0x00939247 File Offset: 0x00937447
		public unsafe bool bFlipNormal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)S_KuroCSClothPreset.__PropertyOffset_11) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)S_KuroCSClothPreset.__PropertyOffset_11) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004606 RID: 17926
		// (get) Token: 0x060243FC RID: 148476 RVA: 0x00939258 File Offset: 0x00937458
		// (set) Token: 0x060243FD RID: 148477 RVA: 0x00939268 File Offset: 0x00937468
		public unsafe float deltaTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)S_KuroCSClothPreset.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)S_KuroCSClothPreset.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17004607 RID: 17927
		// (get) Token: 0x060243FE RID: 148478 RVA: 0x00939279 File Offset: 0x00937479
		// (set) Token: 0x060243FF RID: 148479 RVA: 0x00939289 File Offset: 0x00937489
		public unsafe bool bHypotenuseConstraint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)S_KuroCSClothPreset.__PropertyOffset_13) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)S_KuroCSClothPreset.__PropertyOffset_13) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004608 RID: 17928
		// (get) Token: 0x06024400 RID: 148480 RVA: 0x0093929A File Offset: 0x0093749A
		// (set) Token: 0x06024401 RID: 148481 RVA: 0x009392AA File Offset: 0x009374AA
		public unsafe float gravityZeroDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)S_KuroCSClothPreset.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)S_KuroCSClothPreset.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17004609 RID: 17929
		// (get) Token: 0x06024402 RID: 148482 RVA: 0x009392BB File Offset: 0x009374BB
		// (set) Token: 0x06024403 RID: 148483 RVA: 0x009392CB File Offset: 0x009374CB
		public unsafe float collisionFriction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)S_KuroCSClothPreset.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)S_KuroCSClothPreset.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x1700460A RID: 17930
		// (get) Token: 0x06024404 RID: 148484 RVA: 0x009392DC File Offset: 0x009374DC
		// (set) Token: 0x06024405 RID: 148485 RVA: 0x009392EC File Offset: 0x009374EC
		public unsafe bool bDisableBoxCollision
		{
			get
			{
				return *(base.NativePtr + (IntPtr)S_KuroCSClothPreset.__PropertyOffset_16) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)S_KuroCSClothPreset.__PropertyOffset_16) = (value ? 1 : 0);
			}
		}

		// Token: 0x06024406 RID: 148486 RVA: 0x009392FD File Offset: 0x009374FD
		public S_KuroCSClothPreset()
		{
		}

		// Token: 0x06024407 RID: 148487 RVA: 0x00939308 File Offset: 0x00937508
		public S_KuroCSClothPreset(int XCount, int YCount, float DisStiffness, float BendStiffness, float CollisionR, float LinkDis, float LinkDisY, FVector AccelExt, FVector PosOffset, int SubstepCount, bool bYZPlane, bool bFlipNormal, float deltaTime, bool bHypotenuseConstraint, float gravityZeroDistance, float collisionFriction, bool bDisableBoxCollision)
		{
			this.XCount = XCount;
			this.YCount = YCount;
			this.DisStiffness = DisStiffness;
			this.BendStiffness = BendStiffness;
			this.CollisionR = CollisionR;
			this.LinkDis = LinkDis;
			this.LinkDisY = LinkDisY;
			this.AccelExt = AccelExt;
			this.PosOffset = PosOffset;
			this.SubstepCount = SubstepCount;
			this.bYZPlane = bYZPlane;
			this.bFlipNormal = bFlipNormal;
			this.deltaTime = deltaTime;
			this.bHypotenuseConstraint = bHypotenuseConstraint;
			this.gravityZeroDistance = gravityZeroDistance;
			this.collisionFriction = collisionFriction;
			this.bDisableBoxCollision = bDisableBoxCollision;
		}

		// Token: 0x06024408 RID: 148488 RVA: 0x009393A0 File Offset: 0x009375A0
		protected override IntPtr GetUStructPtr()
		{
			return S_KuroCSClothPreset.StaticStruct();
		}

		// Token: 0x06024409 RID: 148489 RVA: 0x009393AC File Offset: 0x009375AC
		[NullableContext(2)]
		public S_KuroCSClothPreset(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602440A RID: 148490 RVA: 0x009393B6 File Offset: 0x009375B6
		public S_KuroCSClothPreset(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602440B RID: 148491 RVA: 0x009393C1 File Offset: 0x009375C1
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new S_KuroCSClothPreset(Pointer, false, true);
		}

		// Token: 0x0602440C RID: 148492 RVA: 0x009393CB File Offset: 0x009375CB
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new S_KuroCSClothPreset(Pointer, MemoryOwner);
		}

		// Token: 0x04011F61 RID: 73569
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/KuroCS/Cloth/S_KuroCSClothPreset.S_KuroCSClothPreset";

		// Token: 0x04011F62 RID: 73570
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011F63 RID: 73571
		internal static int __PropertyOffset_0;

		// Token: 0x04011F64 RID: 73572
		internal static int __PropertyOffset_1;

		// Token: 0x04011F65 RID: 73573
		internal static int __PropertyOffset_2;

		// Token: 0x04011F66 RID: 73574
		internal static int __PropertyOffset_3;

		// Token: 0x04011F67 RID: 73575
		internal static int __PropertyOffset_4;

		// Token: 0x04011F68 RID: 73576
		internal static int __PropertyOffset_5;

		// Token: 0x04011F69 RID: 73577
		internal static int __PropertyOffset_6;

		// Token: 0x04011F6A RID: 73578
		internal static int __PropertyOffset_7;

		// Token: 0x04011F6B RID: 73579
		internal static int __PropertyOffset_8;

		// Token: 0x04011F6C RID: 73580
		internal static int __PropertyOffset_9;

		// Token: 0x04011F6D RID: 73581
		internal static int __PropertyOffset_10;

		// Token: 0x04011F6E RID: 73582
		internal static int __PropertyOffset_11;

		// Token: 0x04011F6F RID: 73583
		internal static int __PropertyOffset_12;

		// Token: 0x04011F70 RID: 73584
		internal static int __PropertyOffset_13;

		// Token: 0x04011F71 RID: 73585
		internal static int __PropertyOffset_14;

		// Token: 0x04011F72 RID: 73586
		internal static int __PropertyOffset_15;

		// Token: 0x04011F73 RID: 73587
		internal static int __PropertyOffset_16;
	}
}

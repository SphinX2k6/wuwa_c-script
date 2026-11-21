using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Qte
{
	// Token: 0x020031A0 RID: 12704
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Data/Qte/SCommonQte_Drag.SCommonQte_Drag")]
	[UnrealStructLayout(232, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 232)]
	public class SCommonQte_Drag : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601F572 RID: 128370 RVA: 0x0092BA9F File Offset: 0x00929C9F
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SCommonQte_Drag._ScriptStructPtr != 0) ? SCommonQte_Drag._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Qte/SCommonQte_Drag.SCommonQte_Drag", ref SCommonQte_Drag._ScriptStructPtr);
		}

		// Token: 0x170038C0 RID: 14528
		// (get) Token: 0x0601F573 RID: 128371 RVA: 0x0092BAC3 File Offset: 0x00929CC3
		// (set) Token: 0x0601F574 RID: 128372 RVA: 0x0092BAD7 File Offset: 0x00929CD7
		public unsafe TEnumAsByte<ECommonQteViewType_Drag> ViewType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_Drag.__PropertyOffset_ViewType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_Drag.__PropertyOffset_ViewType) = value;
			}
		}

		// Token: 0x170038C1 RID: 14529
		// (get) Token: 0x0601F575 RID: 128373 RVA: 0x0092BAEC File Offset: 0x00929CEC
		// (set) Token: 0x0601F576 RID: 128374 RVA: 0x0092BB00 File Offset: 0x00929D00
		public unsafe TEnumAsByte<ECommonQteInteractiveTiming> InteractiveTiming
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_Drag.__PropertyOffset_InteractiveTiming);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_Drag.__PropertyOffset_InteractiveTiming) = value;
			}
		}

		// Token: 0x170038C2 RID: 14530
		// (get) Token: 0x0601F577 RID: 128375 RVA: 0x0092BB15 File Offset: 0x00929D15
		// (set) Token: 0x0601F578 RID: 128376 RVA: 0x0092BB25 File Offset: 0x00929D25
		public unsafe int Direction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_Drag.__PropertyOffset_Direction);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_Drag.__PropertyOffset_Direction) = value;
			}
		}

		// Token: 0x170038C3 RID: 14531
		// (get) Token: 0x0601F579 RID: 128377 RVA: 0x0092BB36 File Offset: 0x00929D36
		// (set) Token: 0x0601F57A RID: 128378 RVA: 0x0092BB46 File Offset: 0x00929D46
		public unsafe float SlideLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_Drag.__PropertyOffset_SlideLength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_Drag.__PropertyOffset_SlideLength) = value;
			}
		}

		// Token: 0x170038C4 RID: 14532
		// (get) Token: 0x0601F57B RID: 128379 RVA: 0x0092BB57 File Offset: 0x00929D57
		// (set) Token: 0x0601F57C RID: 128380 RVA: 0x0092BB67 File Offset: 0x00929D67
		public unsafe float ToleranceAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_Drag.__PropertyOffset_ToleranceAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_Drag.__PropertyOffset_ToleranceAngle) = value;
			}
		}

		// Token: 0x170038C5 RID: 14533
		// (get) Token: 0x0601F57D RID: 128381 RVA: 0x0092BB78 File Offset: 0x00929D78
		// (set) Token: 0x0601F57E RID: 128382 RVA: 0x0092BB88 File Offset: 0x00929D88
		public unsafe float CompassSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_Drag.__PropertyOffset_CompassSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_Drag.__PropertyOffset_CompassSpeed) = value;
			}
		}

		// Token: 0x170038C6 RID: 14534
		// (get) Token: 0x0601F57F RID: 128383 RVA: 0x0092BB99 File Offset: 0x00929D99
		// (set) Token: 0x0601F580 RID: 128384 RVA: 0x0092BBA9 File Offset: 0x00929DA9
		public unsafe float DragBounds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_Drag.__PropertyOffset_DragBounds);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_Drag.__PropertyOffset_DragBounds) = value;
			}
		}

		// Token: 0x170038C7 RID: 14535
		// (get) Token: 0x0601F581 RID: 128385 RVA: 0x0092BBBA File Offset: 0x00929DBA
		// (set) Token: 0x0601F582 RID: 128386 RVA: 0x0092BBCA File Offset: 0x00929DCA
		public unsafe float DragLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_Drag.__PropertyOffset_DragLength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_Drag.__PropertyOffset_DragLength) = value;
			}
		}

		// Token: 0x170038C8 RID: 14536
		// (get) Token: 0x0601F583 RID: 128387 RVA: 0x0092BBDB File Offset: 0x00929DDB
		// (set) Token: 0x0601F584 RID: 128388 RVA: 0x0092BBEB File Offset: 0x00929DEB
		public unsafe float LerpSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_Drag.__PropertyOffset_LerpSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_Drag.__PropertyOffset_LerpSpeed) = value;
			}
		}

		// Token: 0x170038C9 RID: 14537
		// (get) Token: 0x0601F585 RID: 128389 RVA: 0x0092BBFC File Offset: 0x00929DFC
		// (set) Token: 0x0601F586 RID: 128390 RVA: 0x0092BC3F File Offset: 0x00929E3F
		[Nullable(1)]
		public SCommonQteButton UIConfig
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				SCommonQteButton result;
				if ((result = this._UIConfig) == null)
				{
					result = (this._UIConfig = new SCommonQteButton(base.NativePtr + (IntPtr)SCommonQte_Drag.__PropertyOffset_UIConfig, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SCommonQteButton.StaticStruct(), base.NativePtr + (IntPtr)SCommonQte_Drag.__PropertyOffset_UIConfig, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170038CA RID: 14538
		// (get) Token: 0x0601F587 RID: 128391 RVA: 0x0092BC60 File Offset: 0x00929E60
		// (set) Token: 0x0601F588 RID: 128392 RVA: 0x0092BC70 File Offset: 0x00929E70
		public unsafe bool IsAttachToActor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_Drag.__PropertyOffset_IsAttachToActor) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_Drag.__PropertyOffset_IsAttachToActor) = (value ? 1 : 0);
			}
		}

		// Token: 0x170038CB RID: 14539
		// (get) Token: 0x0601F589 RID: 128393 RVA: 0x0092BC81 File Offset: 0x00929E81
		// (set) Token: 0x0601F58A RID: 128394 RVA: 0x0092BC95 File Offset: 0x00929E95
		public unsafe SCommonQte_Attach AttachConfig
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_Drag.__PropertyOffset_AttachConfig);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_Drag.__PropertyOffset_AttachConfig) = value;
			}
		}

		// Token: 0x170038CC RID: 14540
		// (get) Token: 0x0601F58B RID: 128395 RVA: 0x0092BCAA File Offset: 0x00929EAA
		// (set) Token: 0x0601F58C RID: 128396 RVA: 0x0092BCBA File Offset: 0x00929EBA
		public unsafe bool CheckByRealTimeInput
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_Drag.__PropertyOffset_CheckByRealTimeInput) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_Drag.__PropertyOffset_CheckByRealTimeInput) = (value ? 1 : 0);
			}
		}

		// Token: 0x170038CD RID: 14541
		// (get) Token: 0x0601F58D RID: 128397 RVA: 0x0092BCCB File Offset: 0x00929ECB
		// (set) Token: 0x0601F58E RID: 128398 RVA: 0x0092BCDB File Offset: 0x00929EDB
		public unsafe float LeftSlideLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_Drag.__PropertyOffset_LeftSlideLength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_Drag.__PropertyOffset_LeftSlideLength) = value;
			}
		}

		// Token: 0x170038CE RID: 14542
		// (get) Token: 0x0601F58F RID: 128399 RVA: 0x0092BCEC File Offset: 0x00929EEC
		// (set) Token: 0x0601F590 RID: 128400 RVA: 0x0092BCFC File Offset: 0x00929EFC
		public unsafe float RightSlideLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_Drag.__PropertyOffset_RightSlideLength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_Drag.__PropertyOffset_RightSlideLength) = value;
			}
		}

		// Token: 0x170038CF RID: 14543
		// (get) Token: 0x0601F591 RID: 128401 RVA: 0x0092BD0D File Offset: 0x00929F0D
		// (set) Token: 0x0601F592 RID: 128402 RVA: 0x0092BD1D File Offset: 0x00929F1D
		public unsafe float SlideAngleTolerance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_Drag.__PropertyOffset_SlideAngleTolerance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_Drag.__PropertyOffset_SlideAngleTolerance) = value;
			}
		}

		// Token: 0x170038D0 RID: 14544
		// (get) Token: 0x0601F593 RID: 128403 RVA: 0x0092BD2E File Offset: 0x00929F2E
		// (set) Token: 0x0601F594 RID: 128404 RVA: 0x0092BD3E File Offset: 0x00929F3E
		public unsafe bool IsLeftSuccess
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_Drag.__PropertyOffset_IsLeftSuccess) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_Drag.__PropertyOffset_IsLeftSuccess) = (value ? 1 : 0);
			}
		}

		// Token: 0x170038D1 RID: 14545
		// (get) Token: 0x0601F595 RID: 128405 RVA: 0x0092BD4F File Offset: 0x00929F4F
		// (set) Token: 0x0601F596 RID: 128406 RVA: 0x0092BD5F File Offset: 0x00929F5F
		public unsafe bool BackwardWhenFail
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_Drag.__PropertyOffset_BackwardWhenFail) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_Drag.__PropertyOffset_BackwardWhenFail) = (value ? 1 : 0);
			}
		}

		// Token: 0x170038D2 RID: 14546
		// (get) Token: 0x0601F597 RID: 128407 RVA: 0x0092BD70 File Offset: 0x00929F70
		// (set) Token: 0x0601F598 RID: 128408 RVA: 0x0092BD80 File Offset: 0x00929F80
		public unsafe float RewardSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_Drag.__PropertyOffset_RewardSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_Drag.__PropertyOffset_RewardSpeed) = value;
			}
		}

		// Token: 0x170038D3 RID: 14547
		// (get) Token: 0x0601F599 RID: 128409 RVA: 0x0092BD91 File Offset: 0x00929F91
		// (set) Token: 0x0601F59A RID: 128410 RVA: 0x0092BDA5 File Offset: 0x00929FA5
		public unsafe FVector2D DragCenterPivot
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_Drag.__PropertyOffset_DragCenterPivot);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_Drag.__PropertyOffset_DragCenterPivot) = value;
			}
		}

		// Token: 0x0601F59B RID: 128411 RVA: 0x0092BDBA File Offset: 0x00929FBA
		public SCommonQte_Drag()
		{
		}

		// Token: 0x0601F59C RID: 128412 RVA: 0x0092BDC2 File Offset: 0x00929FC2
		protected override IntPtr GetUStructPtr()
		{
			return SCommonQte_Drag.StaticStruct();
		}

		// Token: 0x0601F59D RID: 128413 RVA: 0x0092BDCE File Offset: 0x00929FCE
		[NullableContext(2)]
		public SCommonQte_Drag(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F59E RID: 128414 RVA: 0x0092BDD8 File Offset: 0x00929FD8
		public SCommonQte_Drag(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F59F RID: 128415 RVA: 0x0092BDE3 File Offset: 0x00929FE3
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SCommonQte_Drag(Pointer, false, true);
		}

		// Token: 0x0601F5A0 RID: 128416 RVA: 0x0092BDED File Offset: 0x00929FED
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SCommonQte_Drag(Pointer, MemoryOwner);
		}

		// Token: 0x04010CCC RID: 68812
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Data/Qte/SCommonQte_Drag.SCommonQte_Drag";

		// Token: 0x04010CCD RID: 68813
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010CCE RID: 68814
		internal static int __PropertyOffset_ViewType;

		// Token: 0x04010CCF RID: 68815
		internal static int __PropertyOffset_InteractiveTiming;

		// Token: 0x04010CD0 RID: 68816
		internal static int __PropertyOffset_Direction;

		// Token: 0x04010CD1 RID: 68817
		internal static int __PropertyOffset_SlideLength;

		// Token: 0x04010CD2 RID: 68818
		internal static int __PropertyOffset_ToleranceAngle;

		// Token: 0x04010CD3 RID: 68819
		internal static int __PropertyOffset_CompassSpeed;

		// Token: 0x04010CD4 RID: 68820
		internal static int __PropertyOffset_DragBounds;

		// Token: 0x04010CD5 RID: 68821
		internal static int __PropertyOffset_DragLength;

		// Token: 0x04010CD6 RID: 68822
		internal static int __PropertyOffset_LerpSpeed;

		// Token: 0x04010CD7 RID: 68823
		internal static int __PropertyOffset_UIConfig;

		// Token: 0x04010CD8 RID: 68824
		[Nullable(2)]
		private SCommonQteButton _UIConfig;

		// Token: 0x04010CD9 RID: 68825
		internal static int __PropertyOffset_IsAttachToActor;

		// Token: 0x04010CDA RID: 68826
		internal static int __PropertyOffset_AttachConfig;

		// Token: 0x04010CDB RID: 68827
		internal static int __PropertyOffset_CheckByRealTimeInput;

		// Token: 0x04010CDC RID: 68828
		internal static int __PropertyOffset_LeftSlideLength;

		// Token: 0x04010CDD RID: 68829
		internal static int __PropertyOffset_RightSlideLength;

		// Token: 0x04010CDE RID: 68830
		internal static int __PropertyOffset_SlideAngleTolerance;

		// Token: 0x04010CDF RID: 68831
		internal static int __PropertyOffset_IsLeftSuccess;

		// Token: 0x04010CE0 RID: 68832
		internal static int __PropertyOffset_BackwardWhenFail;

		// Token: 0x04010CE1 RID: 68833
		internal static int __PropertyOffset_RewardSpeed;

		// Token: 0x04010CE2 RID: 68834
		internal static int __PropertyOffset_DragCenterPivot;
	}
}

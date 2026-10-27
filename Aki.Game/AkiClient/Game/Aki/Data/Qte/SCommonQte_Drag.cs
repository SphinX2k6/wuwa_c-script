using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Qte
{
	// Token: 0x02003EDB RID: 16091
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Data/Qte/SCommonQte_Drag.SCommonQte_Drag")]
	[UnrealStructLayout(232, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 232)]
	public class SCommonQte_Drag : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06028B45 RID: 166725 RVA: 0x009B2B2C File Offset: 0x009B0D2C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SCommonQte_Drag._ScriptStructPtr != 0) ? SCommonQte_Drag._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Qte/SCommonQte_Drag.SCommonQte_Drag", ref SCommonQte_Drag._ScriptStructPtr);
		}

		// Token: 0x17005F34 RID: 24372
		// (get) Token: 0x06028B46 RID: 166726 RVA: 0x009B2B50 File Offset: 0x009B0D50
		// (set) Token: 0x06028B47 RID: 166727 RVA: 0x009B2B64 File Offset: 0x009B0D64
		public unsafe TEnumAsByte<ECommonQteViewType_Drag> ViewType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_Drag.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_Drag.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17005F35 RID: 24373
		// (get) Token: 0x06028B48 RID: 166728 RVA: 0x009B2B79 File Offset: 0x009B0D79
		// (set) Token: 0x06028B49 RID: 166729 RVA: 0x009B2B8D File Offset: 0x009B0D8D
		public unsafe TEnumAsByte<ECommonQteInteractiveTiming> InteractiveTiming
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_Drag.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_Drag.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17005F36 RID: 24374
		// (get) Token: 0x06028B4A RID: 166730 RVA: 0x009B2BA2 File Offset: 0x009B0DA2
		// (set) Token: 0x06028B4B RID: 166731 RVA: 0x009B2BB2 File Offset: 0x009B0DB2
		public unsafe int Direction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_Drag.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_Drag.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17005F37 RID: 24375
		// (get) Token: 0x06028B4C RID: 166732 RVA: 0x009B2BC3 File Offset: 0x009B0DC3
		// (set) Token: 0x06028B4D RID: 166733 RVA: 0x009B2BD3 File Offset: 0x009B0DD3
		public unsafe float SlideLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_Drag.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_Drag.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17005F38 RID: 24376
		// (get) Token: 0x06028B4E RID: 166734 RVA: 0x009B2BE4 File Offset: 0x009B0DE4
		// (set) Token: 0x06028B4F RID: 166735 RVA: 0x009B2BF4 File Offset: 0x009B0DF4
		public unsafe float ToleranceAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_Drag.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_Drag.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17005F39 RID: 24377
		// (get) Token: 0x06028B50 RID: 166736 RVA: 0x009B2C05 File Offset: 0x009B0E05
		// (set) Token: 0x06028B51 RID: 166737 RVA: 0x009B2C15 File Offset: 0x009B0E15
		public unsafe float CompassSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_Drag.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_Drag.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17005F3A RID: 24378
		// (get) Token: 0x06028B52 RID: 166738 RVA: 0x009B2C26 File Offset: 0x009B0E26
		// (set) Token: 0x06028B53 RID: 166739 RVA: 0x009B2C36 File Offset: 0x009B0E36
		public unsafe float DragBounds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_Drag.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_Drag.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17005F3B RID: 24379
		// (get) Token: 0x06028B54 RID: 166740 RVA: 0x009B2C47 File Offset: 0x009B0E47
		// (set) Token: 0x06028B55 RID: 166741 RVA: 0x009B2C57 File Offset: 0x009B0E57
		public unsafe float DragLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_Drag.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_Drag.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17005F3C RID: 24380
		// (get) Token: 0x06028B56 RID: 166742 RVA: 0x009B2C68 File Offset: 0x009B0E68
		// (set) Token: 0x06028B57 RID: 166743 RVA: 0x009B2C78 File Offset: 0x009B0E78
		public unsafe float LerpSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_Drag.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_Drag.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17005F3D RID: 24381
		// (get) Token: 0x06028B58 RID: 166744 RVA: 0x009B2C8C File Offset: 0x009B0E8C
		// (set) Token: 0x06028B59 RID: 166745 RVA: 0x009B2CCF File Offset: 0x009B0ECF
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
					result = (this._UIConfig = new SCommonQteButton(base.NativePtr + (IntPtr)SCommonQte_Drag.__PropertyOffset_9, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SCommonQteButton.StaticStruct(), base.NativePtr + (IntPtr)SCommonQte_Drag.__PropertyOffset_9, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005F3E RID: 24382
		// (get) Token: 0x06028B5A RID: 166746 RVA: 0x009B2CF0 File Offset: 0x009B0EF0
		// (set) Token: 0x06028B5B RID: 166747 RVA: 0x009B2D00 File Offset: 0x009B0F00
		public unsafe bool IsAttachToActor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_Drag.__PropertyOffset_10) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_Drag.__PropertyOffset_10) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005F3F RID: 24383
		// (get) Token: 0x06028B5C RID: 166748 RVA: 0x009B2D11 File Offset: 0x009B0F11
		// (set) Token: 0x06028B5D RID: 166749 RVA: 0x009B2D25 File Offset: 0x009B0F25
		public unsafe SCommonQte_Attach AttachConfig
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_Drag.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_Drag.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17005F40 RID: 24384
		// (get) Token: 0x06028B5E RID: 166750 RVA: 0x009B2D3A File Offset: 0x009B0F3A
		// (set) Token: 0x06028B5F RID: 166751 RVA: 0x009B2D4A File Offset: 0x009B0F4A
		public unsafe bool CheckByRealTimeInput
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_Drag.__PropertyOffset_12) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_Drag.__PropertyOffset_12) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005F41 RID: 24385
		// (get) Token: 0x06028B60 RID: 166752 RVA: 0x009B2D5B File Offset: 0x009B0F5B
		// (set) Token: 0x06028B61 RID: 166753 RVA: 0x009B2D6B File Offset: 0x009B0F6B
		public unsafe float LeftSlideLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_Drag.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_Drag.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17005F42 RID: 24386
		// (get) Token: 0x06028B62 RID: 166754 RVA: 0x009B2D7C File Offset: 0x009B0F7C
		// (set) Token: 0x06028B63 RID: 166755 RVA: 0x009B2D8C File Offset: 0x009B0F8C
		public unsafe float RightSlideLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_Drag.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_Drag.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17005F43 RID: 24387
		// (get) Token: 0x06028B64 RID: 166756 RVA: 0x009B2D9D File Offset: 0x009B0F9D
		// (set) Token: 0x06028B65 RID: 166757 RVA: 0x009B2DAD File Offset: 0x009B0FAD
		public unsafe float SlideAngleTolerance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_Drag.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_Drag.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17005F44 RID: 24388
		// (get) Token: 0x06028B66 RID: 166758 RVA: 0x009B2DBE File Offset: 0x009B0FBE
		// (set) Token: 0x06028B67 RID: 166759 RVA: 0x009B2DCE File Offset: 0x009B0FCE
		public unsafe bool IsLeftSuccess
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_Drag.__PropertyOffset_16) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_Drag.__PropertyOffset_16) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005F45 RID: 24389
		// (get) Token: 0x06028B68 RID: 166760 RVA: 0x009B2DDF File Offset: 0x009B0FDF
		// (set) Token: 0x06028B69 RID: 166761 RVA: 0x009B2DEF File Offset: 0x009B0FEF
		public unsafe bool BackwardWhenFail
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_Drag.__PropertyOffset_17) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_Drag.__PropertyOffset_17) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005F46 RID: 24390
		// (get) Token: 0x06028B6A RID: 166762 RVA: 0x009B2E00 File Offset: 0x009B1000
		// (set) Token: 0x06028B6B RID: 166763 RVA: 0x009B2E10 File Offset: 0x009B1010
		public unsafe float RewardSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_Drag.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_Drag.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x17005F47 RID: 24391
		// (get) Token: 0x06028B6C RID: 166764 RVA: 0x009B2E21 File Offset: 0x009B1021
		// (set) Token: 0x06028B6D RID: 166765 RVA: 0x009B2E35 File Offset: 0x009B1035
		public unsafe FVector2D DragCenterPivot
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_Drag.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_Drag.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x06028B6E RID: 166766 RVA: 0x009B2E4A File Offset: 0x009B104A
		public SCommonQte_Drag()
		{
		}

		// Token: 0x06028B6F RID: 166767 RVA: 0x009B2E54 File Offset: 0x009B1054
		public SCommonQte_Drag(TEnumAsByte<ECommonQteViewType_Drag> ViewType, TEnumAsByte<ECommonQteInteractiveTiming> InteractiveTiming, int Direction, float SlideLength, float ToleranceAngle, float CompassSpeed, float DragBounds, float DragLength, float LerpSpeed, [Nullable(1)] SCommonQteButton UIConfig, bool IsAttachToActor, SCommonQte_Attach AttachConfig, bool CheckByRealTimeInput, float LeftSlideLength, float RightSlideLength, float SlideAngleTolerance, bool IsLeftSuccess, bool BackwardWhenFail, float RewardSpeed, FVector2D DragCenterPivot)
		{
			this.ViewType = ViewType;
			this.InteractiveTiming = InteractiveTiming;
			this.Direction = Direction;
			this.SlideLength = SlideLength;
			this.ToleranceAngle = ToleranceAngle;
			this.CompassSpeed = CompassSpeed;
			this.DragBounds = DragBounds;
			this.DragLength = DragLength;
			this.LerpSpeed = LerpSpeed;
			this.UIConfig = UIConfig;
			this.IsAttachToActor = IsAttachToActor;
			this.AttachConfig = AttachConfig;
			this.CheckByRealTimeInput = CheckByRealTimeInput;
			this.LeftSlideLength = LeftSlideLength;
			this.RightSlideLength = RightSlideLength;
			this.SlideAngleTolerance = SlideAngleTolerance;
			this.IsLeftSuccess = IsLeftSuccess;
			this.BackwardWhenFail = BackwardWhenFail;
			this.RewardSpeed = RewardSpeed;
			this.DragCenterPivot = DragCenterPivot;
		}

		// Token: 0x06028B70 RID: 166768 RVA: 0x009B2F04 File Offset: 0x009B1104
		protected override IntPtr GetUStructPtr()
		{
			return SCommonQte_Drag.StaticStruct();
		}

		// Token: 0x06028B71 RID: 166769 RVA: 0x009B2F10 File Offset: 0x009B1110
		[NullableContext(2)]
		public SCommonQte_Drag(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06028B72 RID: 166770 RVA: 0x009B2F1A File Offset: 0x009B111A
		public SCommonQte_Drag(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06028B73 RID: 166771 RVA: 0x009B2F25 File Offset: 0x009B1125
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SCommonQte_Drag(Pointer, false, true);
		}

		// Token: 0x06028B74 RID: 166772 RVA: 0x009B2F2F File Offset: 0x009B112F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SCommonQte_Drag(Pointer, MemoryOwner);
		}

		// Token: 0x04014CE5 RID: 85221
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Data/Qte/SCommonQte_Drag.SCommonQte_Drag";

		// Token: 0x04014CE6 RID: 85222
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014CE7 RID: 85223
		internal static int __PropertyOffset_0;

		// Token: 0x04014CE8 RID: 85224
		internal static int __PropertyOffset_1;

		// Token: 0x04014CE9 RID: 85225
		internal static int __PropertyOffset_2;

		// Token: 0x04014CEA RID: 85226
		internal static int __PropertyOffset_3;

		// Token: 0x04014CEB RID: 85227
		internal static int __PropertyOffset_4;

		// Token: 0x04014CEC RID: 85228
		internal static int __PropertyOffset_5;

		// Token: 0x04014CED RID: 85229
		internal static int __PropertyOffset_6;

		// Token: 0x04014CEE RID: 85230
		internal static int __PropertyOffset_7;

		// Token: 0x04014CEF RID: 85231
		internal static int __PropertyOffset_8;

		// Token: 0x04014CF0 RID: 85232
		internal static int __PropertyOffset_9;

		// Token: 0x04014CF1 RID: 85233
		[Nullable(2)]
		private SCommonQteButton _UIConfig;

		// Token: 0x04014CF2 RID: 85234
		internal static int __PropertyOffset_10;

		// Token: 0x04014CF3 RID: 85235
		internal static int __PropertyOffset_11;

		// Token: 0x04014CF4 RID: 85236
		internal static int __PropertyOffset_12;

		// Token: 0x04014CF5 RID: 85237
		internal static int __PropertyOffset_13;

		// Token: 0x04014CF6 RID: 85238
		internal static int __PropertyOffset_14;

		// Token: 0x04014CF7 RID: 85239
		internal static int __PropertyOffset_15;

		// Token: 0x04014CF8 RID: 85240
		internal static int __PropertyOffset_16;

		// Token: 0x04014CF9 RID: 85241
		internal static int __PropertyOffset_17;

		// Token: 0x04014CFA RID: 85242
		internal static int __PropertyOffset_18;

		// Token: 0x04014CFB RID: 85243
		internal static int __PropertyOffset_19;
	}
}

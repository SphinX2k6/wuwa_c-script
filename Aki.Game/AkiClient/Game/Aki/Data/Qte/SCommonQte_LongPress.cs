using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Qte
{
	// Token: 0x02003EDD RID: 16093
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Data/Qte/SCommonQte_LongPress.SCommonQte_LongPress")]
	[UnrealStructLayout(208, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 201)]
	public class SCommonQte_LongPress : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06028B8F RID: 166799 RVA: 0x009B31FC File Offset: 0x009B13FC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SCommonQte_LongPress._ScriptStructPtr != 0) ? SCommonQte_LongPress._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Qte/SCommonQte_LongPress.SCommonQte_LongPress", ref SCommonQte_LongPress._ScriptStructPtr);
		}

		// Token: 0x17005F51 RID: 24401
		// (get) Token: 0x06028B90 RID: 166800 RVA: 0x009B3220 File Offset: 0x009B1420
		// (set) Token: 0x06028B91 RID: 166801 RVA: 0x009B3234 File Offset: 0x009B1434
		public unsafe TEnumAsByte<ECommonQteViewType_SingleButtonLongPress> ViewType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_LongPress.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_LongPress.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17005F52 RID: 24402
		// (get) Token: 0x06028B92 RID: 166802 RVA: 0x009B324C File Offset: 0x009B144C
		// (set) Token: 0x06028B93 RID: 166803 RVA: 0x009B328F File Offset: 0x009B148F
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
					result = (this._UIConfig = new SCommonQteButton(base.NativePtr + (IntPtr)SCommonQte_LongPress.__PropertyOffset_1, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SCommonQteButton.StaticStruct(), base.NativePtr + (IntPtr)SCommonQte_LongPress.__PropertyOffset_1, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005F53 RID: 24403
		// (get) Token: 0x06028B94 RID: 166804 RVA: 0x009B32B0 File Offset: 0x009B14B0
		// (set) Token: 0x06028B95 RID: 166805 RVA: 0x009B32C4 File Offset: 0x009B14C4
		public unsafe TEnumAsByte<ECommonQteInteractiveTiming> InteractiveTiming
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_LongPress.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_LongPress.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17005F54 RID: 24404
		// (get) Token: 0x06028B96 RID: 166806 RVA: 0x009B32D9 File Offset: 0x009B14D9
		// (set) Token: 0x06028B97 RID: 166807 RVA: 0x009B32E9 File Offset: 0x009B14E9
		public unsafe float InitProgress
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_LongPress.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_LongPress.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17005F55 RID: 24405
		// (get) Token: 0x06028B98 RID: 166808 RVA: 0x009B32FA File Offset: 0x009B14FA
		// (set) Token: 0x06028B99 RID: 166809 RVA: 0x009B330A File Offset: 0x009B150A
		public unsafe float MaxProgress
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_LongPress.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_LongPress.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17005F56 RID: 24406
		// (get) Token: 0x06028B9A RID: 166810 RVA: 0x009B331B File Offset: 0x009B151B
		// (set) Token: 0x06028B9B RID: 166811 RVA: 0x009B332B File Offset: 0x009B152B
		public unsafe float TargetProgress
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_LongPress.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_LongPress.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17005F57 RID: 24407
		// (get) Token: 0x06028B9C RID: 166812 RVA: 0x009B333C File Offset: 0x009B153C
		// (set) Token: 0x06028B9D RID: 166813 RVA: 0x009B334C File Offset: 0x009B154C
		public unsafe float IncreaseSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_LongPress.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_LongPress.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17005F58 RID: 24408
		// (get) Token: 0x06028B9E RID: 166814 RVA: 0x009B335D File Offset: 0x009B155D
		// (set) Token: 0x06028B9F RID: 166815 RVA: 0x009B336D File Offset: 0x009B156D
		public unsafe float DecreaseSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_LongPress.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_LongPress.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17005F59 RID: 24409
		// (get) Token: 0x06028BA0 RID: 166816 RVA: 0x009B337E File Offset: 0x009B157E
		// (set) Token: 0x06028BA1 RID: 166817 RVA: 0x009B338E File Offset: 0x009B158E
		public unsafe bool IsAttachToActor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_LongPress.__PropertyOffset_8) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_LongPress.__PropertyOffset_8) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005F5A RID: 24410
		// (get) Token: 0x06028BA2 RID: 166818 RVA: 0x009B339F File Offset: 0x009B159F
		// (set) Token: 0x06028BA3 RID: 166819 RVA: 0x009B33B3 File Offset: 0x009B15B3
		public unsafe SCommonQte_Attach AttachConfig
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_LongPress.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_LongPress.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17005F5B RID: 24411
		// (get) Token: 0x06028BA4 RID: 166820 RVA: 0x009B33C8 File Offset: 0x009B15C8
		// (set) Token: 0x06028BA5 RID: 166821 RVA: 0x009B33D8 File Offset: 0x009B15D8
		public unsafe bool IsCheckOnRelease
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_LongPress.__PropertyOffset_10) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_LongPress.__PropertyOffset_10) = (value ? 1 : 0);
			}
		}

		// Token: 0x06028BA6 RID: 166822 RVA: 0x009B33E9 File Offset: 0x009B15E9
		public SCommonQte_LongPress()
		{
		}

		// Token: 0x06028BA7 RID: 166823 RVA: 0x009B33F4 File Offset: 0x009B15F4
		public SCommonQte_LongPress(TEnumAsByte<ECommonQteViewType_SingleButtonLongPress> ViewType, [Nullable(1)] SCommonQteButton UIConfig, TEnumAsByte<ECommonQteInteractiveTiming> InteractiveTiming, float InitProgress, float MaxProgress, float TargetProgress, float IncreaseSpeed, float DecreaseSpeed, bool IsAttachToActor, SCommonQte_Attach AttachConfig, bool IsCheckOnRelease)
		{
			this.ViewType = ViewType;
			this.UIConfig = UIConfig;
			this.InteractiveTiming = InteractiveTiming;
			this.InitProgress = InitProgress;
			this.MaxProgress = MaxProgress;
			this.TargetProgress = TargetProgress;
			this.IncreaseSpeed = IncreaseSpeed;
			this.DecreaseSpeed = DecreaseSpeed;
			this.IsAttachToActor = IsAttachToActor;
			this.AttachConfig = AttachConfig;
			this.IsCheckOnRelease = IsCheckOnRelease;
		}

		// Token: 0x06028BA8 RID: 166824 RVA: 0x009B345C File Offset: 0x009B165C
		protected override IntPtr GetUStructPtr()
		{
			return SCommonQte_LongPress.StaticStruct();
		}

		// Token: 0x06028BA9 RID: 166825 RVA: 0x009B3468 File Offset: 0x009B1668
		[NullableContext(2)]
		public SCommonQte_LongPress(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06028BAA RID: 166826 RVA: 0x009B3472 File Offset: 0x009B1672
		public SCommonQte_LongPress(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06028BAB RID: 166827 RVA: 0x009B347D File Offset: 0x009B167D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SCommonQte_LongPress(Pointer, false, true);
		}

		// Token: 0x06028BAC RID: 166828 RVA: 0x009B3487 File Offset: 0x009B1687
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SCommonQte_LongPress(Pointer, MemoryOwner);
		}

		// Token: 0x04014D08 RID: 85256
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Data/Qte/SCommonQte_LongPress.SCommonQte_LongPress";

		// Token: 0x04014D09 RID: 85257
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014D0A RID: 85258
		internal static int __PropertyOffset_0;

		// Token: 0x04014D0B RID: 85259
		internal static int __PropertyOffset_1;

		// Token: 0x04014D0C RID: 85260
		[Nullable(2)]
		private SCommonQteButton _UIConfig;

		// Token: 0x04014D0D RID: 85261
		internal static int __PropertyOffset_2;

		// Token: 0x04014D0E RID: 85262
		internal static int __PropertyOffset_3;

		// Token: 0x04014D0F RID: 85263
		internal static int __PropertyOffset_4;

		// Token: 0x04014D10 RID: 85264
		internal static int __PropertyOffset_5;

		// Token: 0x04014D11 RID: 85265
		internal static int __PropertyOffset_6;

		// Token: 0x04014D12 RID: 85266
		internal static int __PropertyOffset_7;

		// Token: 0x04014D13 RID: 85267
		internal static int __PropertyOffset_8;

		// Token: 0x04014D14 RID: 85268
		internal static int __PropertyOffset_9;

		// Token: 0x04014D15 RID: 85269
		internal static int __PropertyOffset_10;
	}
}

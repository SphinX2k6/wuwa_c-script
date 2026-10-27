using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Render.RuntimeBP.GI.Data.TOD
{
	// Token: 0x02003D6F RID: 15727
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/GI/Data/TOD/TimeOfDayData.TimeOfDayData")]
	[UnrealStructLayout(164, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 164)]
	public class TimeOfDayData : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602699B RID: 158107 RVA: 0x0097941C File Offset: 0x0097761C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (TimeOfDayData._ScriptStructPtr != 0) ? TimeOfDayData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/GI/Data/TOD/TimeOfDayData.TimeOfDayData", ref TimeOfDayData._ScriptStructPtr);
		}

		// Token: 0x1700532C RID: 21292
		// (get) Token: 0x0602699C RID: 158108 RVA: 0x00979440 File Offset: 0x00977640
		// (set) Token: 0x0602699D RID: 158109 RVA: 0x00979450 File Offset: 0x00977650
		public unsafe float PresetTimeOfDay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)TimeOfDayData.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)TimeOfDayData.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x1700532D RID: 21293
		// (get) Token: 0x0602699E RID: 158110 RVA: 0x00979461 File Offset: 0x00977661
		// (set) Token: 0x0602699F RID: 158111 RVA: 0x00979475 File Offset: 0x00977675
		public unsafe FLinearColor SkyUpperColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)TimeOfDayData.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)TimeOfDayData.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x1700532E RID: 21294
		// (get) Token: 0x060269A0 RID: 158112 RVA: 0x0097948A File Offset: 0x0097768A
		// (set) Token: 0x060269A1 RID: 158113 RVA: 0x0097949E File Offset: 0x0097769E
		public unsafe FLinearColor SkyLowerColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)TimeOfDayData.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)TimeOfDayData.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x1700532F RID: 21295
		// (get) Token: 0x060269A2 RID: 158114 RVA: 0x009794B3 File Offset: 0x009776B3
		// (set) Token: 0x060269A3 RID: 158115 RVA: 0x009794C7 File Offset: 0x009776C7
		public unsafe FLinearColor CloudsUpperColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)TimeOfDayData.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)TimeOfDayData.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17005330 RID: 21296
		// (get) Token: 0x060269A4 RID: 158116 RVA: 0x009794DC File Offset: 0x009776DC
		// (set) Token: 0x060269A5 RID: 158117 RVA: 0x009794F0 File Offset: 0x009776F0
		public unsafe FLinearColor CloudsLowerColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)TimeOfDayData.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)TimeOfDayData.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17005331 RID: 21297
		// (get) Token: 0x060269A6 RID: 158118 RVA: 0x00979505 File Offset: 0x00977705
		// (set) Token: 0x060269A7 RID: 158119 RVA: 0x00979519 File Offset: 0x00977719
		public unsafe FLinearColor CloudsSecondaryColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)TimeOfDayData.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)TimeOfDayData.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17005332 RID: 21298
		// (get) Token: 0x060269A8 RID: 158120 RVA: 0x0097952E File Offset: 0x0097772E
		// (set) Token: 0x060269A9 RID: 158121 RVA: 0x00979542 File Offset: 0x00977742
		public unsafe FLinearColor CloudsBackground
		{
			get
			{
				return *(base.NativePtr + (IntPtr)TimeOfDayData.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)TimeOfDayData.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17005333 RID: 21299
		// (get) Token: 0x060269AA RID: 158122 RVA: 0x00979557 File Offset: 0x00977757
		// (set) Token: 0x060269AB RID: 158123 RVA: 0x0097956B File Offset: 0x0097776B
		public unsafe FLinearColor SunColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)TimeOfDayData.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)TimeOfDayData.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17005334 RID: 21300
		// (get) Token: 0x060269AC RID: 158124 RVA: 0x00979580 File Offset: 0x00977780
		// (set) Token: 0x060269AD RID: 158125 RVA: 0x00979594 File Offset: 0x00977794
		public unsafe FLinearColor MoonColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)TimeOfDayData.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)TimeOfDayData.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17005335 RID: 21301
		// (get) Token: 0x060269AE RID: 158126 RVA: 0x009795A9 File Offset: 0x009777A9
		// (set) Token: 0x060269AF RID: 158127 RVA: 0x009795BD File Offset: 0x009777BD
		public unsafe FLinearColor StarsColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)TimeOfDayData.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)TimeOfDayData.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17005336 RID: 21302
		// (get) Token: 0x060269B0 RID: 158128 RVA: 0x009795D2 File Offset: 0x009777D2
		// (set) Token: 0x060269B1 RID: 158129 RVA: 0x009795E6 File Offset: 0x009777E6
		public unsafe FLinearColor FogColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)TimeOfDayData.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)TimeOfDayData.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x060269B2 RID: 158130 RVA: 0x009795FB File Offset: 0x009777FB
		public TimeOfDayData()
		{
		}

		// Token: 0x060269B3 RID: 158131 RVA: 0x00979604 File Offset: 0x00977804
		public TimeOfDayData(float PresetTimeOfDay, FLinearColor SkyUpperColor, FLinearColor SkyLowerColor, FLinearColor CloudsUpperColor, FLinearColor CloudsLowerColor, FLinearColor CloudsSecondaryColor, FLinearColor CloudsBackground, FLinearColor SunColor, FLinearColor MoonColor, FLinearColor StarsColor, FLinearColor FogColor)
		{
			this.PresetTimeOfDay = PresetTimeOfDay;
			this.SkyUpperColor = SkyUpperColor;
			this.SkyLowerColor = SkyLowerColor;
			this.CloudsUpperColor = CloudsUpperColor;
			this.CloudsLowerColor = CloudsLowerColor;
			this.CloudsSecondaryColor = CloudsSecondaryColor;
			this.CloudsBackground = CloudsBackground;
			this.SunColor = SunColor;
			this.MoonColor = MoonColor;
			this.StarsColor = StarsColor;
			this.FogColor = FogColor;
		}

		// Token: 0x060269B4 RID: 158132 RVA: 0x0097966C File Offset: 0x0097786C
		protected override IntPtr GetUStructPtr()
		{
			return TimeOfDayData.StaticStruct();
		}

		// Token: 0x060269B5 RID: 158133 RVA: 0x00979678 File Offset: 0x00977878
		[NullableContext(2)]
		public TimeOfDayData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060269B6 RID: 158134 RVA: 0x00979682 File Offset: 0x00977882
		public TimeOfDayData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060269B7 RID: 158135 RVA: 0x0097968D File Offset: 0x0097788D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new TimeOfDayData(Pointer, false, true);
		}

		// Token: 0x060269B8 RID: 158136 RVA: 0x00979697 File Offset: 0x00977897
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new TimeOfDayData(Pointer, MemoryOwner);
		}

		// Token: 0x04013661 RID: 79457
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/GI/Data/TOD/TimeOfDayData.TimeOfDayData";

		// Token: 0x04013662 RID: 79458
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013663 RID: 79459
		internal static int __PropertyOffset_0;

		// Token: 0x04013664 RID: 79460
		internal static int __PropertyOffset_1;

		// Token: 0x04013665 RID: 79461
		internal static int __PropertyOffset_2;

		// Token: 0x04013666 RID: 79462
		internal static int __PropertyOffset_3;

		// Token: 0x04013667 RID: 79463
		internal static int __PropertyOffset_4;

		// Token: 0x04013668 RID: 79464
		internal static int __PropertyOffset_5;

		// Token: 0x04013669 RID: 79465
		internal static int __PropertyOffset_6;

		// Token: 0x0401366A RID: 79466
		internal static int __PropertyOffset_7;

		// Token: 0x0401366B RID: 79467
		internal static int __PropertyOffset_8;

		// Token: 0x0401366C RID: 79468
		internal static int __PropertyOffset_9;

		// Token: 0x0401366D RID: 79469
		internal static int __PropertyOffset_10;
	}
}

using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Interaction
{
	// Token: 0x02003B43 RID: 15171
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Interaction/SFloatRangeWithCurve.SFloatRangeWithCurve")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class SFloatRangeWithCurve : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602192B RID: 137515 RVA: 0x008EFED8 File Offset: 0x008EE0D8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SFloatRangeWithCurve._ScriptStructPtr != 0) ? SFloatRangeWithCurve._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/Scene/Interaction/SFloatRangeWithCurve.SFloatRangeWithCurve", ref SFloatRangeWithCurve._ScriptStructPtr);
		}

		// Token: 0x17003746 RID: 14150
		// (get) Token: 0x0602192C RID: 137516 RVA: 0x008EFEFC File Offset: 0x008EE0FC
		// (set) Token: 0x0602192D RID: 137517 RVA: 0x008EFF0C File Offset: 0x008EE10C
		public unsafe float FromMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SFloatRangeWithCurve.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFloatRangeWithCurve.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17003747 RID: 14151
		// (get) Token: 0x0602192E RID: 137518 RVA: 0x008EFF1D File Offset: 0x008EE11D
		// (set) Token: 0x0602192F RID: 137519 RVA: 0x008EFF2D File Offset: 0x008EE12D
		public unsafe float FromMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SFloatRangeWithCurve.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFloatRangeWithCurve.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17003748 RID: 14152
		// (get) Token: 0x06021930 RID: 137520 RVA: 0x008EFF3E File Offset: 0x008EE13E
		// (set) Token: 0x06021931 RID: 137521 RVA: 0x008EFF4E File Offset: 0x008EE14E
		public unsafe float ToMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SFloatRangeWithCurve.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFloatRangeWithCurve.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17003749 RID: 14153
		// (get) Token: 0x06021932 RID: 137522 RVA: 0x008EFF5F File Offset: 0x008EE15F
		// (set) Token: 0x06021933 RID: 137523 RVA: 0x008EFF6F File Offset: 0x008EE16F
		public unsafe float ToMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SFloatRangeWithCurve.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFloatRangeWithCurve.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x1700374A RID: 14154
		// (get) Token: 0x06021934 RID: 137524 RVA: 0x008EFF80 File Offset: 0x008EE180
		// (set) Token: 0x06021935 RID: 137525 RVA: 0x008EFF90 File Offset: 0x008EE190
		public unsafe ECurveSourceType SourceType
		{
			get
			{
				return (ECurveSourceType)(*(base.NativePtr + (IntPtr)SFloatRangeWithCurve.__PropertyOffset_4));
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFloatRangeWithCurve.__PropertyOffset_4) = (byte)value;
			}
		}

		// Token: 0x1700374B RID: 14155
		// (get) Token: 0x06021936 RID: 137526 RVA: 0x008EFFA1 File Offset: 0x008EE1A1
		// (set) Token: 0x06021937 RID: 137527 RVA: 0x008EFFB1 File Offset: 0x008EE1B1
		public unsafe EEasingType EasingType
		{
			get
			{
				return (EEasingType)(*(base.NativePtr + (IntPtr)SFloatRangeWithCurve.__PropertyOffset_5));
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFloatRangeWithCurve.__PropertyOffset_5) = (byte)value;
			}
		}

		// Token: 0x1700374C RID: 14156
		// (get) Token: 0x06021938 RID: 137528 RVA: 0x008EFFC2 File Offset: 0x008EE1C2
		// (set) Token: 0x06021939 RID: 137529 RVA: 0x008EFFD6 File Offset: 0x008EE1D6
		[Nullable(2)]
		public unsafe UCurveFloat CurveFloat
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + SFloatRangeWithCurve.__PropertyOffset_6);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SFloatRangeWithCurve.__PropertyOffset_6, value);
			}
		}

		// Token: 0x0602193A RID: 137530 RVA: 0x008EFFEB File Offset: 0x008EE1EB
		public SFloatRangeWithCurve()
		{
		}

		// Token: 0x0602193B RID: 137531 RVA: 0x008EFFF3 File Offset: 0x008EE1F3
		[NullableContext(1)]
		public SFloatRangeWithCurve(float FromMin, float FromMax, float ToMin, float ToMax, ECurveSourceType SourceType, EEasingType EasingType, UCurveFloat CurveFloat)
		{
			this.FromMin = FromMin;
			this.FromMax = FromMax;
			this.ToMin = ToMin;
			this.ToMax = ToMax;
			this.SourceType = SourceType;
			this.EasingType = EasingType;
			this.CurveFloat = CurveFloat;
		}

		// Token: 0x0602193C RID: 137532 RVA: 0x008F0030 File Offset: 0x008EE230
		protected override IntPtr GetUStructPtr()
		{
			return SFloatRangeWithCurve.StaticStruct();
		}

		// Token: 0x0602193D RID: 137533 RVA: 0x008F003C File Offset: 0x008EE23C
		[NullableContext(2)]
		public SFloatRangeWithCurve(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602193E RID: 137534 RVA: 0x008F0046 File Offset: 0x008EE246
		public SFloatRangeWithCurve(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602193F RID: 137535 RVA: 0x008F0051 File Offset: 0x008EE251
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SFloatRangeWithCurve(Pointer, false, true);
		}

		// Token: 0x06021940 RID: 137536 RVA: 0x008F005B File Offset: 0x008EE25B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SFloatRangeWithCurve(Pointer, MemoryOwner);
		}

		// Token: 0x040105E3 RID: 67043
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Interaction/SFloatRangeWithCurve.SFloatRangeWithCurve";

		// Token: 0x040105E4 RID: 67044
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040105E5 RID: 67045
		internal static int __PropertyOffset_0;

		// Token: 0x040105E6 RID: 67046
		internal static int __PropertyOffset_1;

		// Token: 0x040105E7 RID: 67047
		internal static int __PropertyOffset_2;

		// Token: 0x040105E8 RID: 67048
		internal static int __PropertyOffset_3;

		// Token: 0x040105E9 RID: 67049
		internal static int __PropertyOffset_4;

		// Token: 0x040105EA RID: 67050
		internal static int __PropertyOffset_5;

		// Token: 0x040105EB RID: 67051
		internal static int __PropertyOffset_6;
	}
}

using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Interaction
{
	// Token: 0x020030BE RID: 12478
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Interaction/SFloatRangeWithCurve.SFloatRangeWithCurve")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class SFloatRangeWithCurve : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601DFEA RID: 122858 RVA: 0x0090809F File Offset: 0x0090629F
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SFloatRangeWithCurve._ScriptStructPtr != 0) ? SFloatRangeWithCurve._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/Scene/Interaction/SFloatRangeWithCurve.SFloatRangeWithCurve", ref SFloatRangeWithCurve._ScriptStructPtr);
		}

		// Token: 0x1700317A RID: 12666
		// (get) Token: 0x0601DFEB RID: 122859 RVA: 0x009080C3 File Offset: 0x009062C3
		// (set) Token: 0x0601DFEC RID: 122860 RVA: 0x009080D3 File Offset: 0x009062D3
		public unsafe float FromMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SFloatRangeWithCurve.__PropertyOffset_FromMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFloatRangeWithCurve.__PropertyOffset_FromMin) = value;
			}
		}

		// Token: 0x1700317B RID: 12667
		// (get) Token: 0x0601DFED RID: 122861 RVA: 0x009080E4 File Offset: 0x009062E4
		// (set) Token: 0x0601DFEE RID: 122862 RVA: 0x009080F4 File Offset: 0x009062F4
		public unsafe float FromMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SFloatRangeWithCurve.__PropertyOffset_FromMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFloatRangeWithCurve.__PropertyOffset_FromMax) = value;
			}
		}

		// Token: 0x1700317C RID: 12668
		// (get) Token: 0x0601DFEF RID: 122863 RVA: 0x00908105 File Offset: 0x00906305
		// (set) Token: 0x0601DFF0 RID: 122864 RVA: 0x00908115 File Offset: 0x00906315
		public unsafe float ToMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SFloatRangeWithCurve.__PropertyOffset_ToMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFloatRangeWithCurve.__PropertyOffset_ToMin) = value;
			}
		}

		// Token: 0x1700317D RID: 12669
		// (get) Token: 0x0601DFF1 RID: 122865 RVA: 0x00908126 File Offset: 0x00906326
		// (set) Token: 0x0601DFF2 RID: 122866 RVA: 0x00908136 File Offset: 0x00906336
		public unsafe float ToMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SFloatRangeWithCurve.__PropertyOffset_ToMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFloatRangeWithCurve.__PropertyOffset_ToMax) = value;
			}
		}

		// Token: 0x1700317E RID: 12670
		// (get) Token: 0x0601DFF3 RID: 122867 RVA: 0x00908147 File Offset: 0x00906347
		// (set) Token: 0x0601DFF4 RID: 122868 RVA: 0x00908157 File Offset: 0x00906357
		public unsafe ECurveSourceType SourceType
		{
			get
			{
				return (ECurveSourceType)(*(base.NativePtr + (IntPtr)SFloatRangeWithCurve.__PropertyOffset_SourceType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFloatRangeWithCurve.__PropertyOffset_SourceType) = (byte)value;
			}
		}

		// Token: 0x1700317F RID: 12671
		// (get) Token: 0x0601DFF5 RID: 122869 RVA: 0x00908168 File Offset: 0x00906368
		// (set) Token: 0x0601DFF6 RID: 122870 RVA: 0x00908178 File Offset: 0x00906378
		public unsafe EEasingType EasingType
		{
			get
			{
				return (EEasingType)(*(base.NativePtr + (IntPtr)SFloatRangeWithCurve.__PropertyOffset_EasingType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFloatRangeWithCurve.__PropertyOffset_EasingType) = (byte)value;
			}
		}

		// Token: 0x17003180 RID: 12672
		// (get) Token: 0x0601DFF7 RID: 122871 RVA: 0x00908189 File Offset: 0x00906389
		// (set) Token: 0x0601DFF8 RID: 122872 RVA: 0x0090819D File Offset: 0x0090639D
		[Nullable(2)]
		public unsafe UCurveFloat CurveFloat
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + SFloatRangeWithCurve.__PropertyOffset_CurveFloat);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SFloatRangeWithCurve.__PropertyOffset_CurveFloat, value);
			}
		}

		// Token: 0x0601DFF9 RID: 122873 RVA: 0x009081B2 File Offset: 0x009063B2
		public SFloatRangeWithCurve()
		{
		}

		// Token: 0x0601DFFA RID: 122874 RVA: 0x009081BA File Offset: 0x009063BA
		protected override IntPtr GetUStructPtr()
		{
			return SFloatRangeWithCurve.StaticStruct();
		}

		// Token: 0x0601DFFB RID: 122875 RVA: 0x009081C6 File Offset: 0x009063C6
		[NullableContext(2)]
		public SFloatRangeWithCurve(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601DFFC RID: 122876 RVA: 0x009081D0 File Offset: 0x009063D0
		public SFloatRangeWithCurve(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601DFFD RID: 122877 RVA: 0x009081DB File Offset: 0x009063DB
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SFloatRangeWithCurve(Pointer, false, true);
		}

		// Token: 0x0601DFFE RID: 122878 RVA: 0x009081E5 File Offset: 0x009063E5
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SFloatRangeWithCurve(Pointer, MemoryOwner);
		}

		// Token: 0x0400FD9C RID: 64924
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Interaction/SFloatRangeWithCurve.SFloatRangeWithCurve";

		// Token: 0x0400FD9D RID: 64925
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400FD9E RID: 64926
		internal static int __PropertyOffset_FromMin;

		// Token: 0x0400FD9F RID: 64927
		internal static int __PropertyOffset_FromMax;

		// Token: 0x0400FDA0 RID: 64928
		internal static int __PropertyOffset_ToMin;

		// Token: 0x0400FDA1 RID: 64929
		internal static int __PropertyOffset_ToMax;

		// Token: 0x0400FDA2 RID: 64930
		internal static int __PropertyOffset_SourceType;

		// Token: 0x0400FDA3 RID: 64931
		internal static int __PropertyOffset_EasingType;

		// Token: 0x0400FDA4 RID: 64932
		internal static int __PropertyOffset_CurveFloat;
	}
}

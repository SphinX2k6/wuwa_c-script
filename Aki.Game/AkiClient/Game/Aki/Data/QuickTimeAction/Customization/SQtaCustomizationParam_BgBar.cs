using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.QuickTimeAction.Customization
{
	// Token: 0x02003EBC RID: 16060
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Data/QuickTimeAction/Customization/SQtaCustomizationParam_BgBar.SQtaCustomizationParam_BgBar")]
	[UnrealStructLayout(36, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 36)]
	public class SQtaCustomizationParam_BgBar : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060289CA RID: 166346 RVA: 0x009B07C3 File Offset: 0x009AE9C3
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SQtaCustomizationParam_BgBar._ScriptStructPtr != 0) ? SQtaCustomizationParam_BgBar._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/QuickTimeAction/Customization/SQtaCustomizationParam_BgBar.SQtaCustomizationParam_BgBar", ref SQtaCustomizationParam_BgBar._ScriptStructPtr);
		}

		// Token: 0x17005EB6 RID: 24246
		// (get) Token: 0x060289CB RID: 166347 RVA: 0x009B07E7 File Offset: 0x009AE9E7
		// (set) Token: 0x060289CC RID: 166348 RVA: 0x009B07F7 File Offset: 0x009AE9F7
		public unsafe float Angle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQtaCustomizationParam_BgBar.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQtaCustomizationParam_BgBar.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17005EB7 RID: 24247
		// (get) Token: 0x060289CD RID: 166349 RVA: 0x009B0808 File Offset: 0x009AEA08
		// (set) Token: 0x060289CE RID: 166350 RVA: 0x009B081C File Offset: 0x009AEA1C
		public unsafe FLinearColor Anchor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQtaCustomizationParam_BgBar.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQtaCustomizationParam_BgBar.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17005EB8 RID: 24248
		// (get) Token: 0x060289CF RID: 166351 RVA: 0x009B0834 File Offset: 0x009AEA34
		// (set) Token: 0x060289D0 RID: 166352 RVA: 0x009B0877 File Offset: 0x009AEA77
		public SQtaCustomizationParam_Progress Progress
		{
			get
			{
				base.FastCheckIsValid();
				SQtaCustomizationParam_Progress result;
				if ((result = this._Progress) == null)
				{
					result = (this._Progress = new SQtaCustomizationParam_Progress(base.NativePtr + (IntPtr)SQtaCustomizationParam_BgBar.__PropertyOffset_2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SQtaCustomizationParam_Progress.StaticStruct(), base.NativePtr + (IntPtr)SQtaCustomizationParam_BgBar.__PropertyOffset_2, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060289D1 RID: 166353 RVA: 0x009B0898 File Offset: 0x009AEA98
		public SQtaCustomizationParam_BgBar()
		{
		}

		// Token: 0x060289D2 RID: 166354 RVA: 0x009B08A0 File Offset: 0x009AEAA0
		public SQtaCustomizationParam_BgBar(float Angle, FLinearColor Anchor, SQtaCustomizationParam_Progress Progress)
		{
			this.Angle = Angle;
			this.Anchor = Anchor;
			this.Progress = Progress;
		}

		// Token: 0x060289D3 RID: 166355 RVA: 0x009B08BD File Offset: 0x009AEABD
		protected override IntPtr GetUStructPtr()
		{
			return SQtaCustomizationParam_BgBar.StaticStruct();
		}

		// Token: 0x060289D4 RID: 166356 RVA: 0x009B08C9 File Offset: 0x009AEAC9
		[NullableContext(2)]
		public SQtaCustomizationParam_BgBar(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060289D5 RID: 166357 RVA: 0x009B08D3 File Offset: 0x009AEAD3
		public SQtaCustomizationParam_BgBar(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060289D6 RID: 166358 RVA: 0x009B08DE File Offset: 0x009AEADE
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SQtaCustomizationParam_BgBar(Pointer, false, true);
		}

		// Token: 0x060289D7 RID: 166359 RVA: 0x009B08E8 File Offset: 0x009AEAE8
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SQtaCustomizationParam_BgBar(Pointer, MemoryOwner);
		}

		// Token: 0x04014BAC RID: 84908
		public const string __ObjectPath = "/Game/Aki/Data/QuickTimeAction/Customization/SQtaCustomizationParam_BgBar.SQtaCustomizationParam_BgBar";

		// Token: 0x04014BAD RID: 84909
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014BAE RID: 84910
		internal static int __PropertyOffset_0;

		// Token: 0x04014BAF RID: 84911
		internal static int __PropertyOffset_1;

		// Token: 0x04014BB0 RID: 84912
		internal static int __PropertyOffset_2;

		// Token: 0x04014BB1 RID: 84913
		[Nullable(2)]
		private SQtaCustomizationParam_Progress _Progress;
	}
}

using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.StateMachineEffect
{
	// Token: 0x02003ACC RID: 15052
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/StateMachineEffect/SStateBasedEffectLinearColorCurveSection.SStateBasedEffectLinearColorCurveSection")]
	[UnrealStructLayout(1168, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 1168)]
	public class SStateBasedEffectLinearColorCurveSection : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060206D0 RID: 132816 RVA: 0x008D2667 File Offset: 0x008D0867
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SStateBasedEffectLinearColorCurveSection._ScriptStructPtr != 0) ? SStateBasedEffectLinearColorCurveSection._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/StateMachineEffect/SStateBasedEffectLinearColorCurveSection.SStateBasedEffectLinearColorCurveSection", ref SStateBasedEffectLinearColorCurveSection._ScriptStructPtr);
		}

		// Token: 0x170030B1 RID: 12465
		// (get) Token: 0x060206D1 RID: 132817 RVA: 0x008D268C File Offset: 0x008D088C
		// (set) Token: 0x060206D2 RID: 132818 RVA: 0x008D26CF File Offset: 0x008D08CF
		public SEffectStateLinearColorCurve DefaultCurveInfo
		{
			get
			{
				base.FastCheckIsValid();
				SEffectStateLinearColorCurve result;
				if ((result = this._DefaultCurveInfo) == null)
				{
					result = (this._DefaultCurveInfo = new SEffectStateLinearColorCurve(base.NativePtr + (IntPtr)SStateBasedEffectLinearColorCurveSection.__PropertyOffset_0, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SEffectStateLinearColorCurve.StaticStruct(), base.NativePtr + (IntPtr)SStateBasedEffectLinearColorCurveSection.__PropertyOffset_0, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170030B2 RID: 12466
		// (get) Token: 0x060206D3 RID: 132819 RVA: 0x008D26F0 File Offset: 0x008D08F0
		// (set) Token: 0x060206D4 RID: 132820 RVA: 0x008D2733 File Offset: 0x008D0933
		public TMap<int, SEffectStateLinearColorCurve> OverrideSectionCurveInfo
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, SEffectStateLinearColorCurve> result;
				if ((result = this._OverrideSectionCurveInfo) == null)
				{
					result = (this._OverrideSectionCurveInfo = new TMap<int, SEffectStateLinearColorCurve>(base.NativePtr + (IntPtr)SStateBasedEffectLinearColorCurveSection.__PropertyOffset_1, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.OverrideSectionCurveInfo.CopyAssign(value);
			}
		}

		// Token: 0x060206D5 RID: 132821 RVA: 0x008D2741 File Offset: 0x008D0941
		public SStateBasedEffectLinearColorCurveSection()
		{
		}

		// Token: 0x060206D6 RID: 132822 RVA: 0x008D2749 File Offset: 0x008D0949
		public SStateBasedEffectLinearColorCurveSection(SEffectStateLinearColorCurve DefaultCurveInfo, TMap<int, SEffectStateLinearColorCurve> OverrideSectionCurveInfo)
		{
			this.DefaultCurveInfo = DefaultCurveInfo;
			this.OverrideSectionCurveInfo = OverrideSectionCurveInfo;
		}

		// Token: 0x060206D7 RID: 132823 RVA: 0x008D275F File Offset: 0x008D095F
		protected override IntPtr GetUStructPtr()
		{
			return SStateBasedEffectLinearColorCurveSection.StaticStruct();
		}

		// Token: 0x060206D8 RID: 132824 RVA: 0x008D276B File Offset: 0x008D096B
		[NullableContext(2)]
		public SStateBasedEffectLinearColorCurveSection(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060206D9 RID: 132825 RVA: 0x008D2775 File Offset: 0x008D0975
		public SStateBasedEffectLinearColorCurveSection(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060206DA RID: 132826 RVA: 0x008D2780 File Offset: 0x008D0980
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SStateBasedEffectLinearColorCurveSection(Pointer, false, true);
		}

		// Token: 0x060206DB RID: 132827 RVA: 0x008D278A File Offset: 0x008D098A
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SStateBasedEffectLinearColorCurveSection(Pointer, MemoryOwner);
		}

		// Token: 0x0400FB3C RID: 64316
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/StateMachineEffect/SStateBasedEffectLinearColorCurveSection.SStateBasedEffectLinearColorCurveSection";

		// Token: 0x0400FB3D RID: 64317
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400FB3E RID: 64318
		internal static int __PropertyOffset_0;

		// Token: 0x0400FB3F RID: 64319
		[Nullable(2)]
		private SEffectStateLinearColorCurve _DefaultCurveInfo;

		// Token: 0x0400FB40 RID: 64320
		internal static int __PropertyOffset_1;

		// Token: 0x0400FB41 RID: 64321
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<int, SEffectStateLinearColorCurve> _OverrideSectionCurveInfo;
	}
}

using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Effect.WaterInteraction
{
	// Token: 0x02003106 RID: 12550
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Effect/WaterInteraction/SWaterEffectObject.SWaterEffectObject")]
	[UnrealStructLayout(176, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 172)]
	public class SWaterEffectObject : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601EB74 RID: 125812 RVA: 0x0091B3A6 File Offset: 0x009195A6
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SWaterEffectObject._ScriptStructPtr != 0) ? SWaterEffectObject._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/Effect/WaterInteraction/SWaterEffectObject.SWaterEffectObject", ref SWaterEffectObject._ScriptStructPtr);
		}

		// Token: 0x1700352D RID: 13613
		// (get) Token: 0x0601EB75 RID: 125813 RVA: 0x0091B3CA File Offset: 0x009195CA
		// (set) Token: 0x0601EB76 RID: 125814 RVA: 0x0091B3DA File Offset: 0x009195DA
		public unsafe float Radius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SWaterEffectObject.__PropertyOffset_Radius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SWaterEffectObject.__PropertyOffset_Radius) = value;
			}
		}

		// Token: 0x1700352E RID: 13614
		// (get) Token: 0x0601EB77 RID: 125815 RVA: 0x0091B3EB File Offset: 0x009195EB
		// (set) Token: 0x0601EB78 RID: 125816 RVA: 0x0091B3FF File Offset: 0x009195FF
		public unsafe FTransform Transform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SWaterEffectObject.__PropertyOffset_Transform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SWaterEffectObject.__PropertyOffset_Transform) = value;
			}
		}

		// Token: 0x1700352F RID: 13615
		// (get) Token: 0x0601EB79 RID: 125817 RVA: 0x0091B414 File Offset: 0x00919614
		// (set) Token: 0x0601EB7A RID: 125818 RVA: 0x0091B433 File Offset: 0x00919633
		public TSoftObjectPtr<UEffectModelBase> Effect
		{
			get
			{
				return new TSoftObjectPtr<UEffectModelBase>(base.NativePtr + (IntPtr)SWaterEffectObject.__PropertyOffset_Effect, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SWaterEffectObject.__PropertyOffset_Effect, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003530 RID: 13616
		// (get) Token: 0x0601EB7B RID: 125819 RVA: 0x0091B458 File Offset: 0x00919658
		// (set) Token: 0x0601EB7C RID: 125820 RVA: 0x0091B468 File Offset: 0x00919668
		public unsafe bool TriggerOnce
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SWaterEffectObject.__PropertyOffset_TriggerOnce) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SWaterEffectObject.__PropertyOffset_TriggerOnce) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003531 RID: 13617
		// (get) Token: 0x0601EB7D RID: 125821 RVA: 0x0091B479 File Offset: 0x00919679
		// (set) Token: 0x0601EB7E RID: 125822 RVA: 0x0091B489 File Offset: 0x00919689
		public unsafe bool EnableSurfaceEffect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SWaterEffectObject.__PropertyOffset_EnableSurfaceEffect) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SWaterEffectObject.__PropertyOffset_EnableSurfaceEffect) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003532 RID: 13618
		// (get) Token: 0x0601EB7F RID: 125823 RVA: 0x0091B49A File Offset: 0x0091969A
		// (set) Token: 0x0601EB80 RID: 125824 RVA: 0x0091B4B9 File Offset: 0x009196B9
		public TSoftObjectPtr<UEffectModelBase> WaterSurfaceEffect
		{
			get
			{
				return new TSoftObjectPtr<UEffectModelBase>(base.NativePtr + (IntPtr)SWaterEffectObject.__PropertyOffset_WaterSurfaceEffect, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SWaterEffectObject.__PropertyOffset_WaterSurfaceEffect, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003533 RID: 13619
		// (get) Token: 0x0601EB81 RID: 125825 RVA: 0x0091B4DE File Offset: 0x009196DE
		// (set) Token: 0x0601EB82 RID: 125826 RVA: 0x0091B4EE File Offset: 0x009196EE
		public unsafe float TimeAfterSurfaceEffectStop
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SWaterEffectObject.__PropertyOffset_TimeAfterSurfaceEffectStop);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SWaterEffectObject.__PropertyOffset_TimeAfterSurfaceEffectStop) = value;
			}
		}

		// Token: 0x0601EB83 RID: 125827 RVA: 0x0091B4FF File Offset: 0x009196FF
		public SWaterEffectObject()
		{
		}

		// Token: 0x0601EB84 RID: 125828 RVA: 0x0091B507 File Offset: 0x00919707
		protected override IntPtr GetUStructPtr()
		{
			return SWaterEffectObject.StaticStruct();
		}

		// Token: 0x0601EB85 RID: 125829 RVA: 0x0091B513 File Offset: 0x00919713
		[NullableContext(2)]
		public SWaterEffectObject(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601EB86 RID: 125830 RVA: 0x0091B51D File Offset: 0x0091971D
		public SWaterEffectObject(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601EB87 RID: 125831 RVA: 0x0091B528 File Offset: 0x00919728
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SWaterEffectObject(Pointer, false, true);
		}

		// Token: 0x0601EB88 RID: 125832 RVA: 0x0091B532 File Offset: 0x00919732
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SWaterEffectObject(Pointer, MemoryOwner);
		}

		// Token: 0x040104D5 RID: 66773
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Effect/WaterInteraction/SWaterEffectObject.SWaterEffectObject";

		// Token: 0x040104D6 RID: 66774
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040104D7 RID: 66775
		internal static int __PropertyOffset_Radius;

		// Token: 0x040104D8 RID: 66776
		internal static int __PropertyOffset_Transform;

		// Token: 0x040104D9 RID: 66777
		internal static int __PropertyOffset_Effect;

		// Token: 0x040104DA RID: 66778
		internal static int __PropertyOffset_TriggerOnce;

		// Token: 0x040104DB RID: 66779
		internal static int __PropertyOffset_EnableSurfaceEffect;

		// Token: 0x040104DC RID: 66780
		internal static int __PropertyOffset_WaterSurfaceEffect;

		// Token: 0x040104DD RID: 66781
		internal static int __PropertyOffset_TimeAfterSurfaceEffectStop;
	}
}

using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Effect.WaterInteraction
{
	// Token: 0x02003DBC RID: 15804
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Effect/WaterInteraction/SWaterEffectObject.SWaterEffectObject")]
	[UnrealStructLayout(176, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 172)]
	public class SWaterEffectObject : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06027490 RID: 160912 RVA: 0x0098D411 File Offset: 0x0098B611
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SWaterEffectObject._ScriptStructPtr != 0) ? SWaterEffectObject._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/Effect/WaterInteraction/SWaterEffectObject.SWaterEffectObject", ref SWaterEffectObject._ScriptStructPtr);
		}

		// Token: 0x17005738 RID: 22328
		// (get) Token: 0x06027491 RID: 160913 RVA: 0x0098D435 File Offset: 0x0098B635
		// (set) Token: 0x06027492 RID: 160914 RVA: 0x0098D445 File Offset: 0x0098B645
		public unsafe float Radius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SWaterEffectObject.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SWaterEffectObject.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17005739 RID: 22329
		// (get) Token: 0x06027493 RID: 160915 RVA: 0x0098D456 File Offset: 0x0098B656
		// (set) Token: 0x06027494 RID: 160916 RVA: 0x0098D46A File Offset: 0x0098B66A
		public unsafe FTransform Transform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SWaterEffectObject.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SWaterEffectObject.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x1700573A RID: 22330
		// (get) Token: 0x06027495 RID: 160917 RVA: 0x0098D47F File Offset: 0x0098B67F
		// (set) Token: 0x06027496 RID: 160918 RVA: 0x0098D49E File Offset: 0x0098B69E
		public TSoftObjectPtr<UEffectModelBase> Effect
		{
			get
			{
				return new TSoftObjectPtr<UEffectModelBase>(base.NativePtr + (IntPtr)SWaterEffectObject.__PropertyOffset_2, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SWaterEffectObject.__PropertyOffset_2, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x1700573B RID: 22331
		// (get) Token: 0x06027497 RID: 160919 RVA: 0x0098D4C3 File Offset: 0x0098B6C3
		// (set) Token: 0x06027498 RID: 160920 RVA: 0x0098D4D3 File Offset: 0x0098B6D3
		public unsafe bool TriggerOnce
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SWaterEffectObject.__PropertyOffset_3) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SWaterEffectObject.__PropertyOffset_3) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700573C RID: 22332
		// (get) Token: 0x06027499 RID: 160921 RVA: 0x0098D4E4 File Offset: 0x0098B6E4
		// (set) Token: 0x0602749A RID: 160922 RVA: 0x0098D4F4 File Offset: 0x0098B6F4
		public unsafe bool EnableSurfaceEffect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SWaterEffectObject.__PropertyOffset_4) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SWaterEffectObject.__PropertyOffset_4) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700573D RID: 22333
		// (get) Token: 0x0602749B RID: 160923 RVA: 0x0098D505 File Offset: 0x0098B705
		// (set) Token: 0x0602749C RID: 160924 RVA: 0x0098D524 File Offset: 0x0098B724
		public TSoftObjectPtr<UEffectModelBase> WaterSurfaceEffect
		{
			get
			{
				return new TSoftObjectPtr<UEffectModelBase>(base.NativePtr + (IntPtr)SWaterEffectObject.__PropertyOffset_5, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SWaterEffectObject.__PropertyOffset_5, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x1700573E RID: 22334
		// (get) Token: 0x0602749D RID: 160925 RVA: 0x0098D549 File Offset: 0x0098B749
		// (set) Token: 0x0602749E RID: 160926 RVA: 0x0098D559 File Offset: 0x0098B759
		public unsafe float TimeAfterSurfaceEffectStop
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SWaterEffectObject.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SWaterEffectObject.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x0602749F RID: 160927 RVA: 0x0098D56A File Offset: 0x0098B76A
		public SWaterEffectObject()
		{
		}

		// Token: 0x060274A0 RID: 160928 RVA: 0x0098D572 File Offset: 0x0098B772
		public SWaterEffectObject(float Radius, FTransform Transform, TSoftObjectPtr<UEffectModelBase> Effect, bool TriggerOnce, bool EnableSurfaceEffect, TSoftObjectPtr<UEffectModelBase> WaterSurfaceEffect, float TimeAfterSurfaceEffectStop)
		{
			this.Radius = Radius;
			this.Transform = Transform;
			this.Effect = Effect;
			this.TriggerOnce = TriggerOnce;
			this.EnableSurfaceEffect = EnableSurfaceEffect;
			this.WaterSurfaceEffect = WaterSurfaceEffect;
			this.TimeAfterSurfaceEffectStop = TimeAfterSurfaceEffectStop;
		}

		// Token: 0x060274A1 RID: 160929 RVA: 0x0098D5AF File Offset: 0x0098B7AF
		protected override IntPtr GetUStructPtr()
		{
			return SWaterEffectObject.StaticStruct();
		}

		// Token: 0x060274A2 RID: 160930 RVA: 0x0098D5BB File Offset: 0x0098B7BB
		[NullableContext(2)]
		public SWaterEffectObject(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060274A3 RID: 160931 RVA: 0x0098D5C5 File Offset: 0x0098B7C5
		public SWaterEffectObject(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060274A4 RID: 160932 RVA: 0x0098D5D0 File Offset: 0x0098B7D0
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SWaterEffectObject(Pointer, false, true);
		}

		// Token: 0x060274A5 RID: 160933 RVA: 0x0098D5DA File Offset: 0x0098B7DA
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SWaterEffectObject(Pointer, MemoryOwner);
		}

		// Token: 0x04013D2A RID: 81194
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Effect/WaterInteraction/SWaterEffectObject.SWaterEffectObject";

		// Token: 0x04013D2B RID: 81195
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013D2C RID: 81196
		internal static int __PropertyOffset_0;

		// Token: 0x04013D2D RID: 81197
		internal static int __PropertyOffset_1;

		// Token: 0x04013D2E RID: 81198
		internal static int __PropertyOffset_2;

		// Token: 0x04013D2F RID: 81199
		internal static int __PropertyOffset_3;

		// Token: 0x04013D30 RID: 81200
		internal static int __PropertyOffset_4;

		// Token: 0x04013D31 RID: 81201
		internal static int __PropertyOffset_5;

		// Token: 0x04013D32 RID: 81202
		internal static int __PropertyOffset_6;
	}
}

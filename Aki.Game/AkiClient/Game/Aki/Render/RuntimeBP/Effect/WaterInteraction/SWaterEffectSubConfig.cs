using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Effect.WaterInteraction
{
	// Token: 0x02003DBD RID: 15805
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Effect/WaterInteraction/SWaterEffectSubConfig.SWaterEffectSubConfig")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 128)]
	public class SWaterEffectSubConfig : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060274A6 RID: 160934 RVA: 0x0098D5E3 File Offset: 0x0098B7E3
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SWaterEffectSubConfig._ScriptStructPtr != 0) ? SWaterEffectSubConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/Effect/WaterInteraction/SWaterEffectSubConfig.SWaterEffectSubConfig", ref SWaterEffectSubConfig._ScriptStructPtr);
		}

		// Token: 0x1700573F RID: 22335
		// (get) Token: 0x060274A7 RID: 160935 RVA: 0x0098D608 File Offset: 0x0098B808
		// (set) Token: 0x060274A8 RID: 160936 RVA: 0x0098D64B File Offset: 0x0098B84B
		public TArray<SWaterEffectGroup> MoveEffects
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SWaterEffectGroup> result;
				if ((result = this._MoveEffects) == null)
				{
					result = (this._MoveEffects = new TArray<SWaterEffectGroup>(base.NativePtr + (IntPtr)SWaterEffectSubConfig.__PropertyOffset_0, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.MoveEffects.CopyAssign(value);
			}
		}

		// Token: 0x17005740 RID: 22336
		// (get) Token: 0x060274A9 RID: 160937 RVA: 0x0098D65C File Offset: 0x0098B85C
		// (set) Token: 0x060274AA RID: 160938 RVA: 0x0098D69F File Offset: 0x0098B89F
		public TArray<SWaterEffectGroup> ShallowMoveEffects
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SWaterEffectGroup> result;
				if ((result = this._ShallowMoveEffects) == null)
				{
					result = (this._ShallowMoveEffects = new TArray<SWaterEffectGroup>(base.NativePtr + (IntPtr)SWaterEffectSubConfig.__PropertyOffset_1, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ShallowMoveEffects.CopyAssign(value);
			}
		}

		// Token: 0x17005741 RID: 22337
		// (get) Token: 0x060274AB RID: 160939 RVA: 0x0098D6B0 File Offset: 0x0098B8B0
		// (set) Token: 0x060274AC RID: 160940 RVA: 0x0098D6F3 File Offset: 0x0098B8F3
		public TArray<SWaterEffectItem> FallEffects
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SWaterEffectItem> result;
				if ((result = this._FallEffects) == null)
				{
					result = (this._FallEffects = new TArray<SWaterEffectItem>(base.NativePtr + (IntPtr)SWaterEffectSubConfig.__PropertyOffset_2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.FallEffects.CopyAssign(value);
			}
		}

		// Token: 0x17005742 RID: 22338
		// (get) Token: 0x060274AD RID: 160941 RVA: 0x0098D704 File Offset: 0x0098B904
		// (set) Token: 0x060274AE RID: 160942 RVA: 0x0098D747 File Offset: 0x0098B947
		public TArray<SWaterEffectItem> JumpEffects
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SWaterEffectItem> result;
				if ((result = this._JumpEffects) == null)
				{
					result = (this._JumpEffects = new TArray<SWaterEffectItem>(base.NativePtr + (IntPtr)SWaterEffectSubConfig.__PropertyOffset_3, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.JumpEffects.CopyAssign(value);
			}
		}

		// Token: 0x17005743 RID: 22339
		// (get) Token: 0x060274AF RID: 160943 RVA: 0x0098D758 File Offset: 0x0098B958
		// (set) Token: 0x060274B0 RID: 160944 RVA: 0x0098D79B File Offset: 0x0098B99B
		public TArray<SWaterEffectItem> FlyEffects
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SWaterEffectItem> result;
				if ((result = this._FlyEffects) == null)
				{
					result = (this._FlyEffects = new TArray<SWaterEffectItem>(base.NativePtr + (IntPtr)SWaterEffectSubConfig.__PropertyOffset_4, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.FlyEffects.CopyAssign(value);
			}
		}

		// Token: 0x17005744 RID: 22340
		// (get) Token: 0x060274B1 RID: 160945 RVA: 0x0098D7A9 File Offset: 0x0098B9A9
		// (set) Token: 0x060274B2 RID: 160946 RVA: 0x0098D7B9 File Offset: 0x0098B9B9
		public unsafe float FallJumpDepthThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SWaterEffectSubConfig.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SWaterEffectSubConfig.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17005745 RID: 22341
		// (get) Token: 0x060274B3 RID: 160947 RVA: 0x0098D7CA File Offset: 0x0098B9CA
		// (set) Token: 0x060274B4 RID: 160948 RVA: 0x0098D7DA File Offset: 0x0098B9DA
		public unsafe bool TriggerInGrass
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SWaterEffectSubConfig.__PropertyOffset_6) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SWaterEffectSubConfig.__PropertyOffset_6) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005746 RID: 22342
		// (get) Token: 0x060274B5 RID: 160949 RVA: 0x0098D7EB File Offset: 0x0098B9EB
		// (set) Token: 0x060274B6 RID: 160950 RVA: 0x0098D7FB File Offset: 0x0098B9FB
		public unsafe float FlyEffectTriggerHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SWaterEffectSubConfig.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SWaterEffectSubConfig.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17005747 RID: 22343
		// (get) Token: 0x060274B7 RID: 160951 RVA: 0x0098D80C File Offset: 0x0098BA0C
		// (set) Token: 0x060274B8 RID: 160952 RVA: 0x0098D81C File Offset: 0x0098BA1C
		public unsafe float ShallowMoveDepthThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SWaterEffectSubConfig.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SWaterEffectSubConfig.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17005748 RID: 22344
		// (get) Token: 0x060274B9 RID: 160953 RVA: 0x0098D830 File Offset: 0x0098BA30
		// (set) Token: 0x060274BA RID: 160954 RVA: 0x0098D873 File Offset: 0x0098BA73
		public FGameplayTagContainer ShallowFallbackTag
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._ShallowFallbackTag) == null)
				{
					result = (this._ShallowFallbackTag = new FGameplayTagContainer(base.NativePtr + (IntPtr)SWaterEffectSubConfig.__PropertyOffset_9, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)SWaterEffectSubConfig.__PropertyOffset_9, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060274BB RID: 160955 RVA: 0x0098D894 File Offset: 0x0098BA94
		public SWaterEffectSubConfig()
		{
		}

		// Token: 0x060274BC RID: 160956 RVA: 0x0098D89C File Offset: 0x0098BA9C
		public SWaterEffectSubConfig(TArray<SWaterEffectGroup> MoveEffects, TArray<SWaterEffectGroup> ShallowMoveEffects, TArray<SWaterEffectItem> FallEffects, TArray<SWaterEffectItem> JumpEffects, TArray<SWaterEffectItem> FlyEffects, float FallJumpDepthThreshold, bool TriggerInGrass, float FlyEffectTriggerHeight, float ShallowMoveDepthThreshold, FGameplayTagContainer ShallowFallbackTag)
		{
			this.MoveEffects = MoveEffects;
			this.ShallowMoveEffects = ShallowMoveEffects;
			this.FallEffects = FallEffects;
			this.JumpEffects = JumpEffects;
			this.FlyEffects = FlyEffects;
			this.FallJumpDepthThreshold = FallJumpDepthThreshold;
			this.TriggerInGrass = TriggerInGrass;
			this.FlyEffectTriggerHeight = FlyEffectTriggerHeight;
			this.ShallowMoveDepthThreshold = ShallowMoveDepthThreshold;
			this.ShallowFallbackTag = ShallowFallbackTag;
		}

		// Token: 0x060274BD RID: 160957 RVA: 0x0098D8FC File Offset: 0x0098BAFC
		protected override IntPtr GetUStructPtr()
		{
			return SWaterEffectSubConfig.StaticStruct();
		}

		// Token: 0x060274BE RID: 160958 RVA: 0x0098D908 File Offset: 0x0098BB08
		[NullableContext(2)]
		public SWaterEffectSubConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060274BF RID: 160959 RVA: 0x0098D912 File Offset: 0x0098BB12
		public SWaterEffectSubConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060274C0 RID: 160960 RVA: 0x0098D91D File Offset: 0x0098BB1D
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SWaterEffectSubConfig(Pointer, false, true);
		}

		// Token: 0x060274C1 RID: 160961 RVA: 0x0098D927 File Offset: 0x0098BB27
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SWaterEffectSubConfig(Pointer, MemoryOwner);
		}

		// Token: 0x04013D33 RID: 81203
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Effect/WaterInteraction/SWaterEffectSubConfig.SWaterEffectSubConfig";

		// Token: 0x04013D34 RID: 81204
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013D35 RID: 81205
		internal static int __PropertyOffset_0;

		// Token: 0x04013D36 RID: 81206
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SWaterEffectGroup> _MoveEffects;

		// Token: 0x04013D37 RID: 81207
		internal static int __PropertyOffset_1;

		// Token: 0x04013D38 RID: 81208
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SWaterEffectGroup> _ShallowMoveEffects;

		// Token: 0x04013D39 RID: 81209
		internal static int __PropertyOffset_2;

		// Token: 0x04013D3A RID: 81210
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SWaterEffectItem> _FallEffects;

		// Token: 0x04013D3B RID: 81211
		internal static int __PropertyOffset_3;

		// Token: 0x04013D3C RID: 81212
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SWaterEffectItem> _JumpEffects;

		// Token: 0x04013D3D RID: 81213
		internal static int __PropertyOffset_4;

		// Token: 0x04013D3E RID: 81214
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SWaterEffectItem> _FlyEffects;

		// Token: 0x04013D3F RID: 81215
		internal static int __PropertyOffset_5;

		// Token: 0x04013D40 RID: 81216
		internal static int __PropertyOffset_6;

		// Token: 0x04013D41 RID: 81217
		internal static int __PropertyOffset_7;

		// Token: 0x04013D42 RID: 81218
		internal static int __PropertyOffset_8;

		// Token: 0x04013D43 RID: 81219
		internal static int __PropertyOffset_9;

		// Token: 0x04013D44 RID: 81220
		[Nullable(2)]
		private FGameplayTagContainer _ShallowFallbackTag;
	}
}

using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Effect.WaterInteraction
{
	// Token: 0x02003107 RID: 12551
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Effect/WaterInteraction/SWaterEffectSubConfig.SWaterEffectSubConfig")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 128)]
	public class SWaterEffectSubConfig : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601EB89 RID: 125833 RVA: 0x0091B53B File Offset: 0x0091973B
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SWaterEffectSubConfig._ScriptStructPtr != 0) ? SWaterEffectSubConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/Effect/WaterInteraction/SWaterEffectSubConfig.SWaterEffectSubConfig", ref SWaterEffectSubConfig._ScriptStructPtr);
		}

		// Token: 0x17003534 RID: 13620
		// (get) Token: 0x0601EB8A RID: 125834 RVA: 0x0091B560 File Offset: 0x00919760
		// (set) Token: 0x0601EB8B RID: 125835 RVA: 0x0091B5A3 File Offset: 0x009197A3
		public TArray<SWaterEffectGroup> MoveEffects
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SWaterEffectGroup> result;
				if ((result = this._MoveEffects) == null)
				{
					result = (this._MoveEffects = new TArray<SWaterEffectGroup>(base.NativePtr + (IntPtr)SWaterEffectSubConfig.__PropertyOffset_MoveEffects, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.MoveEffects.CopyAssign(value);
			}
		}

		// Token: 0x17003535 RID: 13621
		// (get) Token: 0x0601EB8C RID: 125836 RVA: 0x0091B5B4 File Offset: 0x009197B4
		// (set) Token: 0x0601EB8D RID: 125837 RVA: 0x0091B5F7 File Offset: 0x009197F7
		public TArray<SWaterEffectGroup> ShallowMoveEffects
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SWaterEffectGroup> result;
				if ((result = this._ShallowMoveEffects) == null)
				{
					result = (this._ShallowMoveEffects = new TArray<SWaterEffectGroup>(base.NativePtr + (IntPtr)SWaterEffectSubConfig.__PropertyOffset_ShallowMoveEffects, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ShallowMoveEffects.CopyAssign(value);
			}
		}

		// Token: 0x17003536 RID: 13622
		// (get) Token: 0x0601EB8E RID: 125838 RVA: 0x0091B608 File Offset: 0x00919808
		// (set) Token: 0x0601EB8F RID: 125839 RVA: 0x0091B64B File Offset: 0x0091984B
		public TArray<SWaterEffectItem> FallEffects
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SWaterEffectItem> result;
				if ((result = this._FallEffects) == null)
				{
					result = (this._FallEffects = new TArray<SWaterEffectItem>(base.NativePtr + (IntPtr)SWaterEffectSubConfig.__PropertyOffset_FallEffects, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.FallEffects.CopyAssign(value);
			}
		}

		// Token: 0x17003537 RID: 13623
		// (get) Token: 0x0601EB90 RID: 125840 RVA: 0x0091B65C File Offset: 0x0091985C
		// (set) Token: 0x0601EB91 RID: 125841 RVA: 0x0091B69F File Offset: 0x0091989F
		public TArray<SWaterEffectItem> JumpEffects
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SWaterEffectItem> result;
				if ((result = this._JumpEffects) == null)
				{
					result = (this._JumpEffects = new TArray<SWaterEffectItem>(base.NativePtr + (IntPtr)SWaterEffectSubConfig.__PropertyOffset_JumpEffects, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.JumpEffects.CopyAssign(value);
			}
		}

		// Token: 0x17003538 RID: 13624
		// (get) Token: 0x0601EB92 RID: 125842 RVA: 0x0091B6B0 File Offset: 0x009198B0
		// (set) Token: 0x0601EB93 RID: 125843 RVA: 0x0091B6F3 File Offset: 0x009198F3
		public TArray<SWaterEffectItem> FlyEffects
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SWaterEffectItem> result;
				if ((result = this._FlyEffects) == null)
				{
					result = (this._FlyEffects = new TArray<SWaterEffectItem>(base.NativePtr + (IntPtr)SWaterEffectSubConfig.__PropertyOffset_FlyEffects, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.FlyEffects.CopyAssign(value);
			}
		}

		// Token: 0x17003539 RID: 13625
		// (get) Token: 0x0601EB94 RID: 125844 RVA: 0x0091B701 File Offset: 0x00919901
		// (set) Token: 0x0601EB95 RID: 125845 RVA: 0x0091B711 File Offset: 0x00919911
		public unsafe float FallJumpDepthThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SWaterEffectSubConfig.__PropertyOffset_FallJumpDepthThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SWaterEffectSubConfig.__PropertyOffset_FallJumpDepthThreshold) = value;
			}
		}

		// Token: 0x1700353A RID: 13626
		// (get) Token: 0x0601EB96 RID: 125846 RVA: 0x0091B722 File Offset: 0x00919922
		// (set) Token: 0x0601EB97 RID: 125847 RVA: 0x0091B732 File Offset: 0x00919932
		public unsafe bool TriggerInGrass
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SWaterEffectSubConfig.__PropertyOffset_TriggerInGrass) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SWaterEffectSubConfig.__PropertyOffset_TriggerInGrass) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700353B RID: 13627
		// (get) Token: 0x0601EB98 RID: 125848 RVA: 0x0091B743 File Offset: 0x00919943
		// (set) Token: 0x0601EB99 RID: 125849 RVA: 0x0091B753 File Offset: 0x00919953
		public unsafe float FlyEffectTriggerHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SWaterEffectSubConfig.__PropertyOffset_FlyEffectTriggerHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SWaterEffectSubConfig.__PropertyOffset_FlyEffectTriggerHeight) = value;
			}
		}

		// Token: 0x1700353C RID: 13628
		// (get) Token: 0x0601EB9A RID: 125850 RVA: 0x0091B764 File Offset: 0x00919964
		// (set) Token: 0x0601EB9B RID: 125851 RVA: 0x0091B774 File Offset: 0x00919974
		public unsafe float ShallowMoveDepthThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SWaterEffectSubConfig.__PropertyOffset_ShallowMoveDepthThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SWaterEffectSubConfig.__PropertyOffset_ShallowMoveDepthThreshold) = value;
			}
		}

		// Token: 0x1700353D RID: 13629
		// (get) Token: 0x0601EB9C RID: 125852 RVA: 0x0091B788 File Offset: 0x00919988
		// (set) Token: 0x0601EB9D RID: 125853 RVA: 0x0091B7CB File Offset: 0x009199CB
		public FGameplayTagContainer ShallowFallbackTag
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._ShallowFallbackTag) == null)
				{
					result = (this._ShallowFallbackTag = new FGameplayTagContainer(base.NativePtr + (IntPtr)SWaterEffectSubConfig.__PropertyOffset_ShallowFallbackTag, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)SWaterEffectSubConfig.__PropertyOffset_ShallowFallbackTag, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601EB9E RID: 125854 RVA: 0x0091B7EC File Offset: 0x009199EC
		public SWaterEffectSubConfig()
		{
		}

		// Token: 0x0601EB9F RID: 125855 RVA: 0x0091B7F4 File Offset: 0x009199F4
		protected override IntPtr GetUStructPtr()
		{
			return SWaterEffectSubConfig.StaticStruct();
		}

		// Token: 0x0601EBA0 RID: 125856 RVA: 0x0091B800 File Offset: 0x00919A00
		[NullableContext(2)]
		public SWaterEffectSubConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601EBA1 RID: 125857 RVA: 0x0091B80A File Offset: 0x00919A0A
		public SWaterEffectSubConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601EBA2 RID: 125858 RVA: 0x0091B815 File Offset: 0x00919A15
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SWaterEffectSubConfig(Pointer, false, true);
		}

		// Token: 0x0601EBA3 RID: 125859 RVA: 0x0091B81F File Offset: 0x00919A1F
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SWaterEffectSubConfig(Pointer, MemoryOwner);
		}

		// Token: 0x040104DE RID: 66782
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Effect/WaterInteraction/SWaterEffectSubConfig.SWaterEffectSubConfig";

		// Token: 0x040104DF RID: 66783
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040104E0 RID: 66784
		internal static int __PropertyOffset_MoveEffects;

		// Token: 0x040104E1 RID: 66785
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SWaterEffectGroup> _MoveEffects;

		// Token: 0x040104E2 RID: 66786
		internal static int __PropertyOffset_ShallowMoveEffects;

		// Token: 0x040104E3 RID: 66787
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SWaterEffectGroup> _ShallowMoveEffects;

		// Token: 0x040104E4 RID: 66788
		internal static int __PropertyOffset_FallEffects;

		// Token: 0x040104E5 RID: 66789
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SWaterEffectItem> _FallEffects;

		// Token: 0x040104E6 RID: 66790
		internal static int __PropertyOffset_JumpEffects;

		// Token: 0x040104E7 RID: 66791
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SWaterEffectItem> _JumpEffects;

		// Token: 0x040104E8 RID: 66792
		internal static int __PropertyOffset_FlyEffects;

		// Token: 0x040104E9 RID: 66793
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SWaterEffectItem> _FlyEffects;

		// Token: 0x040104EA RID: 66794
		internal static int __PropertyOffset_FallJumpDepthThreshold;

		// Token: 0x040104EB RID: 66795
		internal static int __PropertyOffset_TriggerInGrass;

		// Token: 0x040104EC RID: 66796
		internal static int __PropertyOffset_FlyEffectTriggerHeight;

		// Token: 0x040104ED RID: 66797
		internal static int __PropertyOffset_ShallowMoveDepthThreshold;

		// Token: 0x040104EE RID: 66798
		internal static int __PropertyOffset_ShallowFallbackTag;

		// Token: 0x040104EF RID: 66799
		[Nullable(2)]
		private FGameplayTagContainer _ShallowFallbackTag;
	}
}

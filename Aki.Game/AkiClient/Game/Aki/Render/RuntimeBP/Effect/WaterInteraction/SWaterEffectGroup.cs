using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Effect.WaterInteraction
{
	// Token: 0x02003104 RID: 12548
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Effect/WaterInteraction/SWaterEffectGroup.SWaterEffectGroup")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class SWaterEffectGroup : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601EB5C RID: 125788 RVA: 0x0091B1C8 File Offset: 0x009193C8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SWaterEffectGroup._ScriptStructPtr != 0) ? SWaterEffectGroup._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/Effect/WaterInteraction/SWaterEffectGroup.SWaterEffectGroup", ref SWaterEffectGroup._ScriptStructPtr);
		}

		// Token: 0x17003528 RID: 13608
		// (get) Token: 0x0601EB5D RID: 125789 RVA: 0x0091B1EC File Offset: 0x009193EC
		// (set) Token: 0x0601EB5E RID: 125790 RVA: 0x0091B1FC File Offset: 0x009193FC
		public unsafe float WaterDepth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SWaterEffectGroup.__PropertyOffset_WaterDepth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SWaterEffectGroup.__PropertyOffset_WaterDepth) = value;
			}
		}

		// Token: 0x17003529 RID: 13609
		// (get) Token: 0x0601EB5F RID: 125791 RVA: 0x0091B210 File Offset: 0x00919410
		// (set) Token: 0x0601EB60 RID: 125792 RVA: 0x0091B253 File Offset: 0x00919453
		public TArray<SWaterEffectItem> EffectConfig
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SWaterEffectItem> result;
				if ((result = this._EffectConfig) == null)
				{
					result = (this._EffectConfig = new TArray<SWaterEffectItem>(base.NativePtr + (IntPtr)SWaterEffectGroup.__PropertyOffset_EffectConfig, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.EffectConfig.CopyAssign(value);
			}
		}

		// Token: 0x0601EB61 RID: 125793 RVA: 0x0091B261 File Offset: 0x00919461
		public SWaterEffectGroup()
		{
		}

		// Token: 0x0601EB62 RID: 125794 RVA: 0x0091B269 File Offset: 0x00919469
		protected override IntPtr GetUStructPtr()
		{
			return SWaterEffectGroup.StaticStruct();
		}

		// Token: 0x0601EB63 RID: 125795 RVA: 0x0091B275 File Offset: 0x00919475
		[NullableContext(2)]
		public SWaterEffectGroup(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601EB64 RID: 125796 RVA: 0x0091B27F File Offset: 0x0091947F
		public SWaterEffectGroup(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601EB65 RID: 125797 RVA: 0x0091B28A File Offset: 0x0091948A
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SWaterEffectGroup(Pointer, false, true);
		}

		// Token: 0x0601EB66 RID: 125798 RVA: 0x0091B294 File Offset: 0x00919494
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SWaterEffectGroup(Pointer, MemoryOwner);
		}

		// Token: 0x040104CB RID: 66763
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Effect/WaterInteraction/SWaterEffectGroup.SWaterEffectGroup";

		// Token: 0x040104CC RID: 66764
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040104CD RID: 66765
		internal static int __PropertyOffset_WaterDepth;

		// Token: 0x040104CE RID: 66766
		internal static int __PropertyOffset_EffectConfig;

		// Token: 0x040104CF RID: 66767
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SWaterEffectItem> _EffectConfig;
	}
}

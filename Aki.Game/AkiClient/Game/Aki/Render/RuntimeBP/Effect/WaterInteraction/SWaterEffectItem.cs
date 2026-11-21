using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Effect.WaterInteraction
{
	// Token: 0x02003105 RID: 12549
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Effect/WaterInteraction/SWaterEffectItem.SWaterEffectItem")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 104)]
	public class SWaterEffectItem : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601EB67 RID: 125799 RVA: 0x0091B29D File Offset: 0x0091949D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SWaterEffectItem._ScriptStructPtr != 0) ? SWaterEffectItem._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/Effect/WaterInteraction/SWaterEffectItem.SWaterEffectItem", ref SWaterEffectItem._ScriptStructPtr);
		}

		// Token: 0x1700352A RID: 13610
		// (get) Token: 0x0601EB68 RID: 125800 RVA: 0x0091B2C1 File Offset: 0x009194C1
		// (set) Token: 0x0601EB69 RID: 125801 RVA: 0x0091B2D1 File Offset: 0x009194D1
		public unsafe float Speed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SWaterEffectItem.__PropertyOffset_Speed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SWaterEffectItem.__PropertyOffset_Speed) = value;
			}
		}

		// Token: 0x1700352B RID: 13611
		// (get) Token: 0x0601EB6A RID: 125802 RVA: 0x0091B2E2 File Offset: 0x009194E2
		// (set) Token: 0x0601EB6B RID: 125803 RVA: 0x0091B301 File Offset: 0x00919501
		public TSoftObjectPtr<UEffectModelBase> EffectDataRef
		{
			get
			{
				return new TSoftObjectPtr<UEffectModelBase>(base.NativePtr + (IntPtr)SWaterEffectItem.__PropertyOffset_EffectDataRef, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SWaterEffectItem.__PropertyOffset_EffectDataRef, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x1700352C RID: 13612
		// (get) Token: 0x0601EB6C RID: 125804 RVA: 0x0091B326 File Offset: 0x00919526
		// (set) Token: 0x0601EB6D RID: 125805 RVA: 0x0091B345 File Offset: 0x00919545
		public TSoftObjectPtr<UEffectModelBase> AudioEffectDataRef
		{
			get
			{
				return new TSoftObjectPtr<UEffectModelBase>(base.NativePtr + (IntPtr)SWaterEffectItem.__PropertyOffset_AudioEffectDataRef, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SWaterEffectItem.__PropertyOffset_AudioEffectDataRef, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x0601EB6E RID: 125806 RVA: 0x0091B36A File Offset: 0x0091956A
		public SWaterEffectItem()
		{
		}

		// Token: 0x0601EB6F RID: 125807 RVA: 0x0091B372 File Offset: 0x00919572
		protected override IntPtr GetUStructPtr()
		{
			return SWaterEffectItem.StaticStruct();
		}

		// Token: 0x0601EB70 RID: 125808 RVA: 0x0091B37E File Offset: 0x0091957E
		[NullableContext(2)]
		public SWaterEffectItem(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601EB71 RID: 125809 RVA: 0x0091B388 File Offset: 0x00919588
		public SWaterEffectItem(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601EB72 RID: 125810 RVA: 0x0091B393 File Offset: 0x00919593
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SWaterEffectItem(Pointer, false, true);
		}

		// Token: 0x0601EB73 RID: 125811 RVA: 0x0091B39D File Offset: 0x0091959D
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SWaterEffectItem(Pointer, MemoryOwner);
		}

		// Token: 0x040104D0 RID: 66768
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Effect/WaterInteraction/SWaterEffectItem.SWaterEffectItem";

		// Token: 0x040104D1 RID: 66769
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040104D2 RID: 66770
		internal static int __PropertyOffset_Speed;

		// Token: 0x040104D3 RID: 66771
		internal static int __PropertyOffset_EffectDataRef;

		// Token: 0x040104D4 RID: 66772
		internal static int __PropertyOffset_AudioEffectDataRef;
	}
}

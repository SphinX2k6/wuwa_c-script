using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Effect.WaterInteraction
{
	// Token: 0x02003DBB RID: 15803
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Effect/WaterInteraction/SWaterEffectItem.SWaterEffectItem")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 104)]
	public class SWaterEffectItem : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06027482 RID: 160898 RVA: 0x0098D2EB File Offset: 0x0098B4EB
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SWaterEffectItem._ScriptStructPtr != 0) ? SWaterEffectItem._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/Effect/WaterInteraction/SWaterEffectItem.SWaterEffectItem", ref SWaterEffectItem._ScriptStructPtr);
		}

		// Token: 0x17005735 RID: 22325
		// (get) Token: 0x06027483 RID: 160899 RVA: 0x0098D30F File Offset: 0x0098B50F
		// (set) Token: 0x06027484 RID: 160900 RVA: 0x0098D31F File Offset: 0x0098B51F
		public unsafe float Speed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SWaterEffectItem.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SWaterEffectItem.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17005736 RID: 22326
		// (get) Token: 0x06027485 RID: 160901 RVA: 0x0098D330 File Offset: 0x0098B530
		// (set) Token: 0x06027486 RID: 160902 RVA: 0x0098D34F File Offset: 0x0098B54F
		public TSoftObjectPtr<UEffectModelBase> EffectDataRef
		{
			get
			{
				return new TSoftObjectPtr<UEffectModelBase>(base.NativePtr + (IntPtr)SWaterEffectItem.__PropertyOffset_1, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SWaterEffectItem.__PropertyOffset_1, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17005737 RID: 22327
		// (get) Token: 0x06027487 RID: 160903 RVA: 0x0098D374 File Offset: 0x0098B574
		// (set) Token: 0x06027488 RID: 160904 RVA: 0x0098D393 File Offset: 0x0098B593
		public TSoftObjectPtr<UEffectModelBase> AudioEffectDataRef
		{
			get
			{
				return new TSoftObjectPtr<UEffectModelBase>(base.NativePtr + (IntPtr)SWaterEffectItem.__PropertyOffset_2, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SWaterEffectItem.__PropertyOffset_2, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x06027489 RID: 160905 RVA: 0x0098D3B8 File Offset: 0x0098B5B8
		public SWaterEffectItem()
		{
		}

		// Token: 0x0602748A RID: 160906 RVA: 0x0098D3C0 File Offset: 0x0098B5C0
		public SWaterEffectItem(float Speed, TSoftObjectPtr<UEffectModelBase> EffectDataRef, TSoftObjectPtr<UEffectModelBase> AudioEffectDataRef)
		{
			this.Speed = Speed;
			this.EffectDataRef = EffectDataRef;
			this.AudioEffectDataRef = AudioEffectDataRef;
		}

		// Token: 0x0602748B RID: 160907 RVA: 0x0098D3DD File Offset: 0x0098B5DD
		protected override IntPtr GetUStructPtr()
		{
			return SWaterEffectItem.StaticStruct();
		}

		// Token: 0x0602748C RID: 160908 RVA: 0x0098D3E9 File Offset: 0x0098B5E9
		[NullableContext(2)]
		public SWaterEffectItem(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602748D RID: 160909 RVA: 0x0098D3F3 File Offset: 0x0098B5F3
		public SWaterEffectItem(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602748E RID: 160910 RVA: 0x0098D3FE File Offset: 0x0098B5FE
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SWaterEffectItem(Pointer, false, true);
		}

		// Token: 0x0602748F RID: 160911 RVA: 0x0098D408 File Offset: 0x0098B608
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SWaterEffectItem(Pointer, MemoryOwner);
		}

		// Token: 0x04013D25 RID: 81189
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Effect/WaterInteraction/SWaterEffectItem.SWaterEffectItem";

		// Token: 0x04013D26 RID: 81190
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013D27 RID: 81191
		internal static int __PropertyOffset_0;

		// Token: 0x04013D28 RID: 81192
		internal static int __PropertyOffset_1;

		// Token: 0x04013D29 RID: 81193
		internal static int __PropertyOffset_2;
	}
}

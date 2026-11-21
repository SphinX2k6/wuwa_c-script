using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter.GameplayABP
{
	// Token: 0x020033BB RID: 13243
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/GameplayABP/SGameplayABPConfig.SGameplayABPConfig")]
	[UnrealStructLayout(28, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 28)]
	public class SGameplayABPConfig : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021947 RID: 137543 RVA: 0x009645D8 File Offset: 0x009627D8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SGameplayABPConfig._ScriptStructPtr != 0) ? SGameplayABPConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/GameplayABP/SGameplayABPConfig.SGameplayABPConfig", ref SGameplayABPConfig._ScriptStructPtr);
		}

		// Token: 0x170044FD RID: 17661
		// (get) Token: 0x06021948 RID: 137544 RVA: 0x009645FC File Offset: 0x009627FC
		// (set) Token: 0x06021949 RID: 137545 RVA: 0x00964610 File Offset: 0x00962810
		public unsafe TEnumAsByte<EGameplayABPType> Type
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SGameplayABPConfig.__PropertyOffset_Type);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SGameplayABPConfig.__PropertyOffset_Type) = value;
			}
		}

		// Token: 0x170044FE RID: 17662
		// (get) Token: 0x0602194A RID: 137546 RVA: 0x00964625 File Offset: 0x00962825
		// (set) Token: 0x0602194B RID: 137547 RVA: 0x00964639 File Offset: 0x00962839
		public unsafe FGameplayTag PreloadTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SGameplayABPConfig.__PropertyOffset_PreloadTag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SGameplayABPConfig.__PropertyOffset_PreloadTag) = value;
			}
		}

		// Token: 0x170044FF RID: 17663
		// (get) Token: 0x0602194C RID: 137548 RVA: 0x0096464E File Offset: 0x0096284E
		// (set) Token: 0x0602194D RID: 137549 RVA: 0x00964662 File Offset: 0x00962862
		public unsafe FGameplayTag ActiveTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SGameplayABPConfig.__PropertyOffset_ActiveTag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SGameplayABPConfig.__PropertyOffset_ActiveTag) = value;
			}
		}

		// Token: 0x0602194E RID: 137550 RVA: 0x00964677 File Offset: 0x00962877
		public SGameplayABPConfig()
		{
		}

		// Token: 0x0602194F RID: 137551 RVA: 0x0096467F File Offset: 0x0096287F
		protected override IntPtr GetUStructPtr()
		{
			return SGameplayABPConfig.StaticStruct();
		}

		// Token: 0x06021950 RID: 137552 RVA: 0x0096468B File Offset: 0x0096288B
		[NullableContext(2)]
		public SGameplayABPConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021951 RID: 137553 RVA: 0x00964695 File Offset: 0x00962895
		public SGameplayABPConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021952 RID: 137554 RVA: 0x009646A0 File Offset: 0x009628A0
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SGameplayABPConfig(Pointer, false, true);
		}

		// Token: 0x06021953 RID: 137555 RVA: 0x009646AA File Offset: 0x009628AA
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SGameplayABPConfig(Pointer, MemoryOwner);
		}

		// Token: 0x040125EA RID: 75242
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/GameplayABP/SGameplayABPConfig.SGameplayABPConfig";

		// Token: 0x040125EB RID: 75243
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040125EC RID: 75244
		internal static int __PropertyOffset_Type;

		// Token: 0x040125ED RID: 75245
		internal static int __PropertyOffset_PreloadTag;

		// Token: 0x040125EE RID: 75246
		internal static int __PropertyOffset_ActiveTag;
	}
}

using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter.GameplayABP
{
	// Token: 0x020033BA RID: 13242
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/GameplayABP/SGameplayABPAssetConfig.SGameplayABPAssetConfig")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class SGameplayABPAssetConfig : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602193C RID: 137532 RVA: 0x0096450B File Offset: 0x0096270B
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SGameplayABPAssetConfig._ScriptStructPtr != 0) ? SGameplayABPAssetConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/GameplayABP/SGameplayABPAssetConfig.SGameplayABPAssetConfig", ref SGameplayABPAssetConfig._ScriptStructPtr);
		}

		// Token: 0x170044FB RID: 17659
		// (get) Token: 0x0602193D RID: 137533 RVA: 0x0096452F File Offset: 0x0096272F
		// (set) Token: 0x0602193E RID: 137534 RVA: 0x00964543 File Offset: 0x00962743
		public unsafe TEnumAsByte<EGameplayABPType> Type
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SGameplayABPAssetConfig.__PropertyOffset_Type);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SGameplayABPAssetConfig.__PropertyOffset_Type) = value;
			}
		}

		// Token: 0x170044FC RID: 17660
		// (get) Token: 0x0602193F RID: 137535 RVA: 0x00964558 File Offset: 0x00962758
		// (set) Token: 0x06021940 RID: 137536 RVA: 0x00964577 File Offset: 0x00962777
		[Nullable(1)]
		public TSoftClassPtr<UKuroAnimInstance> AnimInstance
		{
			[NullableContext(1)]
			get
			{
				return new TSoftClassPtr<UKuroAnimInstance>(base.NativePtr + (IntPtr)SGameplayABPAssetConfig.__PropertyOffset_AnimInstance, base.MemoryOwner ?? this);
			}
			[NullableContext(1)]
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SGameplayABPAssetConfig.__PropertyOffset_AnimInstance, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x06021941 RID: 137537 RVA: 0x0096459C File Offset: 0x0096279C
		public SGameplayABPAssetConfig()
		{
		}

		// Token: 0x06021942 RID: 137538 RVA: 0x009645A4 File Offset: 0x009627A4
		protected override IntPtr GetUStructPtr()
		{
			return SGameplayABPAssetConfig.StaticStruct();
		}

		// Token: 0x06021943 RID: 137539 RVA: 0x009645B0 File Offset: 0x009627B0
		[NullableContext(2)]
		public SGameplayABPAssetConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021944 RID: 137540 RVA: 0x009645BA File Offset: 0x009627BA
		public SGameplayABPAssetConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021945 RID: 137541 RVA: 0x009645C5 File Offset: 0x009627C5
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SGameplayABPAssetConfig(Pointer, false, true);
		}

		// Token: 0x06021946 RID: 137542 RVA: 0x009645CF File Offset: 0x009627CF
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SGameplayABPAssetConfig(Pointer, MemoryOwner);
		}

		// Token: 0x040125E6 RID: 75238
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/GameplayABP/SGameplayABPAssetConfig.SGameplayABPAssetConfig";

		// Token: 0x040125E7 RID: 75239
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040125E8 RID: 75240
		internal static int __PropertyOffset_Type;

		// Token: 0x040125E9 RID: 75241
		internal static int __PropertyOffset_AnimInstance;
	}
}

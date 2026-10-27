using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter.GameplayABP
{
	// Token: 0x0200439A RID: 17306
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/GameplayABP/SGameplayABPAssetConfig.SGameplayABPAssetConfig")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class SGameplayABPAssetConfig : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602CD26 RID: 183590 RVA: 0x00A297B3 File Offset: 0x00A279B3
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SGameplayABPAssetConfig._ScriptStructPtr != 0) ? SGameplayABPAssetConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/GameplayABP/SGameplayABPAssetConfig.SGameplayABPAssetConfig", ref SGameplayABPAssetConfig._ScriptStructPtr);
		}

		// Token: 0x170070FA RID: 28922
		// (get) Token: 0x0602CD27 RID: 183591 RVA: 0x00A297D7 File Offset: 0x00A279D7
		// (set) Token: 0x0602CD28 RID: 183592 RVA: 0x00A297EB File Offset: 0x00A279EB
		public unsafe TEnumAsByte<EGameplayABPType> Type
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SGameplayABPAssetConfig.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SGameplayABPAssetConfig.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x170070FB RID: 28923
		// (get) Token: 0x0602CD29 RID: 183593 RVA: 0x00A29800 File Offset: 0x00A27A00
		// (set) Token: 0x0602CD2A RID: 183594 RVA: 0x00A2981F File Offset: 0x00A27A1F
		[Nullable(1)]
		public TSoftClassPtr<UKuroAnimInstance> AnimInstance
		{
			[NullableContext(1)]
			get
			{
				return new TSoftClassPtr<UKuroAnimInstance>(base.NativePtr + (IntPtr)SGameplayABPAssetConfig.__PropertyOffset_1, base.MemoryOwner ?? this);
			}
			[NullableContext(1)]
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SGameplayABPAssetConfig.__PropertyOffset_1, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x0602CD2B RID: 183595 RVA: 0x00A29844 File Offset: 0x00A27A44
		public SGameplayABPAssetConfig()
		{
		}

		// Token: 0x0602CD2C RID: 183596 RVA: 0x00A2984C File Offset: 0x00A27A4C
		public SGameplayABPAssetConfig(TEnumAsByte<EGameplayABPType> Type, [Nullable(1)] TSoftClassPtr<UKuroAnimInstance> AnimInstance)
		{
			this.Type = Type;
			this.AnimInstance = AnimInstance;
		}

		// Token: 0x0602CD2D RID: 183597 RVA: 0x00A29862 File Offset: 0x00A27A62
		protected override IntPtr GetUStructPtr()
		{
			return SGameplayABPAssetConfig.StaticStruct();
		}

		// Token: 0x0602CD2E RID: 183598 RVA: 0x00A2986E File Offset: 0x00A27A6E
		[NullableContext(2)]
		public SGameplayABPAssetConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602CD2F RID: 183599 RVA: 0x00A29878 File Offset: 0x00A27A78
		public SGameplayABPAssetConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602CD30 RID: 183600 RVA: 0x00A29883 File Offset: 0x00A27A83
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SGameplayABPAssetConfig(Pointer, false, true);
		}

		// Token: 0x0602CD31 RID: 183601 RVA: 0x00A2988D File Offset: 0x00A27A8D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SGameplayABPAssetConfig(Pointer, MemoryOwner);
		}

		// Token: 0x04017A6B RID: 96875
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/GameplayABP/SGameplayABPAssetConfig.SGameplayABPAssetConfig";

		// Token: 0x04017A6C RID: 96876
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04017A6D RID: 96877
		internal static int __PropertyOffset_0;

		// Token: 0x04017A6E RID: 96878
		internal static int __PropertyOffset_1;
	}
}

using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter.GameplayABP
{
	// Token: 0x0200439B RID: 17307
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/GameplayABP/SGameplayABPConfig.SGameplayABPConfig")]
	[UnrealStructLayout(28, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 28)]
	public class SGameplayABPConfig : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602CD32 RID: 183602 RVA: 0x00A29896 File Offset: 0x00A27A96
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SGameplayABPConfig._ScriptStructPtr != 0) ? SGameplayABPConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/GameplayABP/SGameplayABPConfig.SGameplayABPConfig", ref SGameplayABPConfig._ScriptStructPtr);
		}

		// Token: 0x170070FC RID: 28924
		// (get) Token: 0x0602CD33 RID: 183603 RVA: 0x00A298BA File Offset: 0x00A27ABA
		// (set) Token: 0x0602CD34 RID: 183604 RVA: 0x00A298CE File Offset: 0x00A27ACE
		public unsafe TEnumAsByte<EGameplayABPType> Type
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SGameplayABPConfig.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SGameplayABPConfig.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x170070FD RID: 28925
		// (get) Token: 0x0602CD35 RID: 183605 RVA: 0x00A298E3 File Offset: 0x00A27AE3
		// (set) Token: 0x0602CD36 RID: 183606 RVA: 0x00A298F7 File Offset: 0x00A27AF7
		public unsafe FGameplayTag PreloadTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SGameplayABPConfig.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SGameplayABPConfig.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x170070FE RID: 28926
		// (get) Token: 0x0602CD37 RID: 183607 RVA: 0x00A2990C File Offset: 0x00A27B0C
		// (set) Token: 0x0602CD38 RID: 183608 RVA: 0x00A29920 File Offset: 0x00A27B20
		public unsafe FGameplayTag ActiveTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SGameplayABPConfig.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SGameplayABPConfig.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x0602CD39 RID: 183609 RVA: 0x00A29935 File Offset: 0x00A27B35
		public SGameplayABPConfig()
		{
		}

		// Token: 0x0602CD3A RID: 183610 RVA: 0x00A2993D File Offset: 0x00A27B3D
		public SGameplayABPConfig(TEnumAsByte<EGameplayABPType> Type, FGameplayTag PreloadTag, FGameplayTag ActiveTag)
		{
			this.Type = Type;
			this.PreloadTag = PreloadTag;
			this.ActiveTag = ActiveTag;
		}

		// Token: 0x0602CD3B RID: 183611 RVA: 0x00A2995A File Offset: 0x00A27B5A
		protected override IntPtr GetUStructPtr()
		{
			return SGameplayABPConfig.StaticStruct();
		}

		// Token: 0x0602CD3C RID: 183612 RVA: 0x00A29966 File Offset: 0x00A27B66
		[NullableContext(2)]
		public SGameplayABPConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602CD3D RID: 183613 RVA: 0x00A29970 File Offset: 0x00A27B70
		public SGameplayABPConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602CD3E RID: 183614 RVA: 0x00A2997B File Offset: 0x00A27B7B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SGameplayABPConfig(Pointer, false, true);
		}

		// Token: 0x0602CD3F RID: 183615 RVA: 0x00A29985 File Offset: 0x00A27B85
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SGameplayABPConfig(Pointer, MemoryOwner);
		}

		// Token: 0x04017A6F RID: 96879
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/GameplayABP/SGameplayABPConfig.SGameplayABPConfig";

		// Token: 0x04017A70 RID: 96880
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04017A71 RID: 96881
		internal static int __PropertyOffset_0;

		// Token: 0x04017A72 RID: 96882
		internal static int __PropertyOffset_1;

		// Token: 0x04017A73 RID: 96883
		internal static int __PropertyOffset_2;
	}
}

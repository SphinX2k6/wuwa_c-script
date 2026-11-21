using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02003351 RID: 13137
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SGameplayTagProbabilityCooldownInfo.SGameplayTagProbabilityCooldownInfo")]
	[UnrealStructLayout(20, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 20)]
	public class SGameplayTagProbabilityCooldownInfo : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060213EF RID: 136175 RVA: 0x0095C6FC File Offset: 0x0095A8FC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SGameplayTagProbabilityCooldownInfo._ScriptStructPtr != 0) ? SGameplayTagProbabilityCooldownInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SGameplayTagProbabilityCooldownInfo.SGameplayTagProbabilityCooldownInfo", ref SGameplayTagProbabilityCooldownInfo._ScriptStructPtr);
		}

		// Token: 0x17004354 RID: 17236
		// (get) Token: 0x060213F0 RID: 136176 RVA: 0x0095C720 File Offset: 0x0095A920
		// (set) Token: 0x060213F1 RID: 136177 RVA: 0x0095C734 File Offset: 0x0095A934
		public unsafe FGameplayTag GameplayTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SGameplayTagProbabilityCooldownInfo.__PropertyOffset_GameplayTag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SGameplayTagProbabilityCooldownInfo.__PropertyOffset_GameplayTag) = value;
			}
		}

		// Token: 0x17004355 RID: 17237
		// (get) Token: 0x060213F2 RID: 136178 RVA: 0x0095C749 File Offset: 0x0095A949
		// (set) Token: 0x060213F3 RID: 136179 RVA: 0x0095C759 File Offset: 0x0095A959
		public unsafe float Probability
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SGameplayTagProbabilityCooldownInfo.__PropertyOffset_Probability);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SGameplayTagProbabilityCooldownInfo.__PropertyOffset_Probability) = value;
			}
		}

		// Token: 0x17004356 RID: 17238
		// (get) Token: 0x060213F4 RID: 136180 RVA: 0x0095C76A File Offset: 0x0095A96A
		// (set) Token: 0x060213F5 RID: 136181 RVA: 0x0095C77A File Offset: 0x0095A97A
		public unsafe int CooldownTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SGameplayTagProbabilityCooldownInfo.__PropertyOffset_CooldownTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SGameplayTagProbabilityCooldownInfo.__PropertyOffset_CooldownTime) = value;
			}
		}

		// Token: 0x060213F6 RID: 136182 RVA: 0x0095C78B File Offset: 0x0095A98B
		public SGameplayTagProbabilityCooldownInfo()
		{
		}

		// Token: 0x060213F7 RID: 136183 RVA: 0x0095C793 File Offset: 0x0095A993
		protected override IntPtr GetUStructPtr()
		{
			return SGameplayTagProbabilityCooldownInfo.StaticStruct();
		}

		// Token: 0x060213F8 RID: 136184 RVA: 0x0095C79F File Offset: 0x0095A99F
		[NullableContext(2)]
		public SGameplayTagProbabilityCooldownInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060213F9 RID: 136185 RVA: 0x0095C7A9 File Offset: 0x0095A9A9
		public SGameplayTagProbabilityCooldownInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060213FA RID: 136186 RVA: 0x0095C7B4 File Offset: 0x0095A9B4
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SGameplayTagProbabilityCooldownInfo(Pointer, false, true);
		}

		// Token: 0x060213FB RID: 136187 RVA: 0x0095C7BE File Offset: 0x0095A9BE
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SGameplayTagProbabilityCooldownInfo(Pointer, MemoryOwner);
		}

		// Token: 0x040122CB RID: 74443
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SGameplayTagProbabilityCooldownInfo.SGameplayTagProbabilityCooldownInfo";

		// Token: 0x040122CC RID: 74444
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040122CD RID: 74445
		internal static int __PropertyOffset_GameplayTag;

		// Token: 0x040122CE RID: 74446
		internal static int __PropertyOffset_Probability;

		// Token: 0x040122CF RID: 74447
		internal static int __PropertyOffset_CooldownTime;
	}
}

using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02004318 RID: 17176
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SGameplayTagProbabilityCooldownInfo.SGameplayTagProbabilityCooldownInfo")]
	[UnrealStructLayout(20, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 20)]
	public class SGameplayTagProbabilityCooldownInfo : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602C704 RID: 182020 RVA: 0x00A1FC70 File Offset: 0x00A1DE70
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SGameplayTagProbabilityCooldownInfo._ScriptStructPtr != 0) ? SGameplayTagProbabilityCooldownInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SGameplayTagProbabilityCooldownInfo.SGameplayTagProbabilityCooldownInfo", ref SGameplayTagProbabilityCooldownInfo._ScriptStructPtr);
		}

		// Token: 0x17006F3D RID: 28477
		// (get) Token: 0x0602C705 RID: 182021 RVA: 0x00A1FC94 File Offset: 0x00A1DE94
		// (set) Token: 0x0602C706 RID: 182022 RVA: 0x00A1FCA8 File Offset: 0x00A1DEA8
		public unsafe FGameplayTag GameplayTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SGameplayTagProbabilityCooldownInfo.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SGameplayTagProbabilityCooldownInfo.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17006F3E RID: 28478
		// (get) Token: 0x0602C707 RID: 182023 RVA: 0x00A1FCBD File Offset: 0x00A1DEBD
		// (set) Token: 0x0602C708 RID: 182024 RVA: 0x00A1FCCD File Offset: 0x00A1DECD
		public unsafe float Probability
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SGameplayTagProbabilityCooldownInfo.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SGameplayTagProbabilityCooldownInfo.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17006F3F RID: 28479
		// (get) Token: 0x0602C709 RID: 182025 RVA: 0x00A1FCDE File Offset: 0x00A1DEDE
		// (set) Token: 0x0602C70A RID: 182026 RVA: 0x00A1FCEE File Offset: 0x00A1DEEE
		public unsafe int CooldownTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SGameplayTagProbabilityCooldownInfo.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SGameplayTagProbabilityCooldownInfo.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x0602C70B RID: 182027 RVA: 0x00A1FCFF File Offset: 0x00A1DEFF
		public SGameplayTagProbabilityCooldownInfo()
		{
		}

		// Token: 0x0602C70C RID: 182028 RVA: 0x00A1FD07 File Offset: 0x00A1DF07
		public SGameplayTagProbabilityCooldownInfo(FGameplayTag GameplayTag, float Probability, int CooldownTime)
		{
			this.GameplayTag = GameplayTag;
			this.Probability = Probability;
			this.CooldownTime = CooldownTime;
		}

		// Token: 0x0602C70D RID: 182029 RVA: 0x00A1FD24 File Offset: 0x00A1DF24
		protected override IntPtr GetUStructPtr()
		{
			return SGameplayTagProbabilityCooldownInfo.StaticStruct();
		}

		// Token: 0x0602C70E RID: 182030 RVA: 0x00A1FD30 File Offset: 0x00A1DF30
		[NullableContext(2)]
		public SGameplayTagProbabilityCooldownInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602C70F RID: 182031 RVA: 0x00A1FD3A File Offset: 0x00A1DF3A
		public SGameplayTagProbabilityCooldownInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602C710 RID: 182032 RVA: 0x00A1FD45 File Offset: 0x00A1DF45
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SGameplayTagProbabilityCooldownInfo(Pointer, false, true);
		}

		// Token: 0x0602C711 RID: 182033 RVA: 0x00A1FD4F File Offset: 0x00A1DF4F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SGameplayTagProbabilityCooldownInfo(Pointer, MemoryOwner);
		}

		// Token: 0x040176D9 RID: 95961
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SGameplayTagProbabilityCooldownInfo.SGameplayTagProbabilityCooldownInfo";

		// Token: 0x040176DA RID: 95962
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040176DB RID: 95963
		internal static int __PropertyOffset_0;

		// Token: 0x040176DC RID: 95964
		internal static int __PropertyOffset_1;

		// Token: 0x040176DD RID: 95965
		internal static int __PropertyOffset_2;
	}
}

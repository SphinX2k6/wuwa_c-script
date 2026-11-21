using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02003358 RID: 13144
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SInputBehavior.SInputBehavior")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class SInputBehavior : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602149C RID: 136348 RVA: 0x0095D3F2 File Offset: 0x0095B5F2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SInputBehavior._ScriptStructPtr != 0) ? SInputBehavior._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SInputBehavior.SInputBehavior", ref SInputBehavior._ScriptStructPtr);
		}

		// Token: 0x17004392 RID: 17298
		// (get) Token: 0x0602149D RID: 136349 RVA: 0x0095D418 File Offset: 0x0095B618
		// (set) Token: 0x0602149E RID: 136350 RVA: 0x0095D45B File Offset: 0x0095B65B
		public TArray<SInputBehaviorCondition> BehaviorConditionArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SInputBehaviorCondition> result;
				if ((result = this._BehaviorConditionArray) == null)
				{
					result = (this._BehaviorConditionArray = new TArray<SInputBehaviorCondition>(base.NativePtr + (IntPtr)SInputBehavior.__PropertyOffset_BehaviorConditionArray, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.BehaviorConditionArray.CopyAssign(value);
			}
		}

		// Token: 0x17004393 RID: 17299
		// (get) Token: 0x0602149F RID: 136351 RVA: 0x0095D469 File Offset: 0x0095B669
		// (set) Token: 0x060214A0 RID: 136352 RVA: 0x0095D47D File Offset: 0x0095B67D
		public unsafe string ConditionFormula
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SInputBehavior.__PropertyOffset_ConditionFormula)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SInputBehavior.__PropertyOffset_ConditionFormula)), value);
			}
		}

		// Token: 0x17004394 RID: 17300
		// (get) Token: 0x060214A1 RID: 136353 RVA: 0x0095D492 File Offset: 0x0095B692
		// (set) Token: 0x060214A2 RID: 136354 RVA: 0x0095D4A6 File Offset: 0x0095B6A6
		[Nullable(0)]
		public unsafe TEnumAsByte<EInputBehaviorActionTiming> BehaviorActionTiming
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SInputBehavior.__PropertyOffset_BehaviorActionTiming);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SInputBehavior.__PropertyOffset_BehaviorActionTiming) = value;
			}
		}

		// Token: 0x17004395 RID: 17301
		// (get) Token: 0x060214A3 RID: 136355 RVA: 0x0095D4BC File Offset: 0x0095B6BC
		// (set) Token: 0x060214A4 RID: 136356 RVA: 0x0095D4FF File Offset: 0x0095B6FF
		public TArray<SInputBehaviorAction> BehaviorActionArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SInputBehaviorAction> result;
				if ((result = this._BehaviorActionArray) == null)
				{
					result = (this._BehaviorActionArray = new TArray<SInputBehaviorAction>(base.NativePtr + (IntPtr)SInputBehavior.__PropertyOffset_BehaviorActionArray, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.BehaviorActionArray.CopyAssign(value);
			}
		}

		// Token: 0x060214A5 RID: 136357 RVA: 0x0095D50D File Offset: 0x0095B70D
		public SInputBehavior()
		{
		}

		// Token: 0x060214A6 RID: 136358 RVA: 0x0095D515 File Offset: 0x0095B715
		protected override IntPtr GetUStructPtr()
		{
			return SInputBehavior.StaticStruct();
		}

		// Token: 0x060214A7 RID: 136359 RVA: 0x0095D521 File Offset: 0x0095B721
		[NullableContext(2)]
		public SInputBehavior(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060214A8 RID: 136360 RVA: 0x0095D52B File Offset: 0x0095B72B
		public SInputBehavior(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060214A9 RID: 136361 RVA: 0x0095D536 File Offset: 0x0095B736
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SInputBehavior(Pointer, false, true);
		}

		// Token: 0x060214AA RID: 136362 RVA: 0x0095D540 File Offset: 0x0095B740
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SInputBehavior(Pointer, MemoryOwner);
		}

		// Token: 0x0401231E RID: 74526
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SInputBehavior.SInputBehavior";

		// Token: 0x0401231F RID: 74527
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012320 RID: 74528
		internal static int __PropertyOffset_BehaviorConditionArray;

		// Token: 0x04012321 RID: 74529
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SInputBehaviorCondition> _BehaviorConditionArray;

		// Token: 0x04012322 RID: 74530
		internal static int __PropertyOffset_ConditionFormula;

		// Token: 0x04012323 RID: 74531
		internal static int __PropertyOffset_BehaviorActionTiming;

		// Token: 0x04012324 RID: 74532
		internal static int __PropertyOffset_BehaviorActionArray;

		// Token: 0x04012325 RID: 74533
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SInputBehaviorAction> _BehaviorActionArray;
	}
}

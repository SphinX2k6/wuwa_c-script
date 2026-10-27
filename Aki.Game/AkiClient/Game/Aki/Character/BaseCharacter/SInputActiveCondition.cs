using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x0200431F RID: 17183
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SInputActiveCondition.SInputActiveCondition")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 66)]
	public class SInputActiveCondition : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602C7AA RID: 182186 RVA: 0x00A20AA0 File Offset: 0x00A1ECA0
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SInputActiveCondition._ScriptStructPtr != 0) ? SInputActiveCondition._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SInputActiveCondition.SInputActiveCondition", ref SInputActiveCondition._ScriptStructPtr);
		}

		// Token: 0x17006F74 RID: 28532
		// (get) Token: 0x0602C7AB RID: 182187 RVA: 0x00A20AC4 File Offset: 0x00A1ECC4
		// (set) Token: 0x0602C7AC RID: 182188 RVA: 0x00A20AD8 File Offset: 0x00A1ECD8
		public unsafe TEnumAsByte<EInputActiveConditionType> ConditionType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SInputActiveCondition.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SInputActiveCondition.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17006F75 RID: 28533
		// (get) Token: 0x0602C7AD RID: 182189 RVA: 0x00A20AED File Offset: 0x00A1ECED
		// (set) Token: 0x0602C7AE RID: 182190 RVA: 0x00A20B01 File Offset: 0x00A1ED01
		public unsafe TEnumAsByte<ESkillBehaviorComparisonLogic> ComparisonLogic
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SInputActiveCondition.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SInputActiveCondition.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17006F76 RID: 28534
		// (get) Token: 0x0602C7AF RID: 182191 RVA: 0x00A20B16 File Offset: 0x00A1ED16
		// (set) Token: 0x0602C7B0 RID: 182192 RVA: 0x00A20B26 File Offset: 0x00A1ED26
		public unsafe float Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SInputActiveCondition.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SInputActiveCondition.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17006F77 RID: 28535
		// (get) Token: 0x0602C7B1 RID: 182193 RVA: 0x00A20B37 File Offset: 0x00A1ED37
		// (set) Token: 0x0602C7B2 RID: 182194 RVA: 0x00A20B47 File Offset: 0x00A1ED47
		public unsafe float RangeL
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SInputActiveCondition.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SInputActiveCondition.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17006F78 RID: 28536
		// (get) Token: 0x0602C7B3 RID: 182195 RVA: 0x00A20B58 File Offset: 0x00A1ED58
		// (set) Token: 0x0602C7B4 RID: 182196 RVA: 0x00A20B68 File Offset: 0x00A1ED68
		public unsafe float RangeR
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SInputActiveCondition.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SInputActiveCondition.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17006F79 RID: 28537
		// (get) Token: 0x0602C7B5 RID: 182197 RVA: 0x00A20B79 File Offset: 0x00A1ED79
		// (set) Token: 0x0602C7B6 RID: 182198 RVA: 0x00A20B89 File Offset: 0x00A1ED89
		public unsafe int AttributeId1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SInputActiveCondition.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SInputActiveCondition.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17006F7A RID: 28538
		// (get) Token: 0x0602C7B7 RID: 182199 RVA: 0x00A20B9A File Offset: 0x00A1ED9A
		// (set) Token: 0x0602C7B8 RID: 182200 RVA: 0x00A20BAA File Offset: 0x00A1EDAA
		public unsafe int AttributeId2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SInputActiveCondition.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SInputActiveCondition.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17006F7B RID: 28539
		// (get) Token: 0x0602C7B9 RID: 182201 RVA: 0x00A20BBB File Offset: 0x00A1EDBB
		// (set) Token: 0x0602C7BA RID: 182202 RVA: 0x00A20BCB File Offset: 0x00A1EDCB
		public unsafe int AttributeRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SInputActiveCondition.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SInputActiveCondition.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17006F7C RID: 28540
		// (get) Token: 0x0602C7BB RID: 182203 RVA: 0x00A20BDC File Offset: 0x00A1EDDC
		// (set) Token: 0x0602C7BC RID: 182204 RVA: 0x00A20C1F File Offset: 0x00A1EE1F
		[Nullable(1)]
		public FGameplayTagContainer TagToCheck
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._TagToCheck) == null)
				{
					result = (this._TagToCheck = new FGameplayTagContainer(base.NativePtr + (IntPtr)SInputActiveCondition.__PropertyOffset_8, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)SInputActiveCondition.__PropertyOffset_8, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006F7D RID: 28541
		// (get) Token: 0x0602C7BD RID: 182205 RVA: 0x00A20C40 File Offset: 0x00A1EE40
		// (set) Token: 0x0602C7BE RID: 182206 RVA: 0x00A20C50 File Offset: 0x00A1EE50
		public unsafe bool AnyTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SInputActiveCondition.__PropertyOffset_9) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SInputActiveCondition.__PropertyOffset_9) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006F7E RID: 28542
		// (get) Token: 0x0602C7BF RID: 182207 RVA: 0x00A20C61 File Offset: 0x00A1EE61
		// (set) Token: 0x0602C7C0 RID: 182208 RVA: 0x00A20C71 File Offset: 0x00A1EE71
		public unsafe bool Reverse
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SInputActiveCondition.__PropertyOffset_10) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SInputActiveCondition.__PropertyOffset_10) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602C7C1 RID: 182209 RVA: 0x00A20C82 File Offset: 0x00A1EE82
		public SInputActiveCondition()
		{
		}

		// Token: 0x0602C7C2 RID: 182210 RVA: 0x00A20C8C File Offset: 0x00A1EE8C
		public SInputActiveCondition(TEnumAsByte<EInputActiveConditionType> ConditionType, TEnumAsByte<ESkillBehaviorComparisonLogic> ComparisonLogic, float Value, float RangeL, float RangeR, int AttributeId1, int AttributeId2, int AttributeRate, [Nullable(1)] FGameplayTagContainer TagToCheck, bool AnyTag, bool Reverse)
		{
			this.ConditionType = ConditionType;
			this.ComparisonLogic = ComparisonLogic;
			this.Value = Value;
			this.RangeL = RangeL;
			this.RangeR = RangeR;
			this.AttributeId1 = AttributeId1;
			this.AttributeId2 = AttributeId2;
			this.AttributeRate = AttributeRate;
			this.TagToCheck = TagToCheck;
			this.AnyTag = AnyTag;
			this.Reverse = Reverse;
		}

		// Token: 0x0602C7C3 RID: 182211 RVA: 0x00A20CF4 File Offset: 0x00A1EEF4
		protected override IntPtr GetUStructPtr()
		{
			return SInputActiveCondition.StaticStruct();
		}

		// Token: 0x0602C7C4 RID: 182212 RVA: 0x00A20D00 File Offset: 0x00A1EF00
		[NullableContext(2)]
		public SInputActiveCondition(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602C7C5 RID: 182213 RVA: 0x00A20D0A File Offset: 0x00A1EF0A
		public SInputActiveCondition(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602C7C6 RID: 182214 RVA: 0x00A20D15 File Offset: 0x00A1EF15
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SInputActiveCondition(Pointer, false, true);
		}

		// Token: 0x0602C7C7 RID: 182215 RVA: 0x00A20D1F File Offset: 0x00A1EF1F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SInputActiveCondition(Pointer, MemoryOwner);
		}

		// Token: 0x04017726 RID: 96038
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SInputActiveCondition.SInputActiveCondition";

		// Token: 0x04017727 RID: 96039
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04017728 RID: 96040
		internal static int __PropertyOffset_0;

		// Token: 0x04017729 RID: 96041
		internal static int __PropertyOffset_1;

		// Token: 0x0401772A RID: 96042
		internal static int __PropertyOffset_2;

		// Token: 0x0401772B RID: 96043
		internal static int __PropertyOffset_3;

		// Token: 0x0401772C RID: 96044
		internal static int __PropertyOffset_4;

		// Token: 0x0401772D RID: 96045
		internal static int __PropertyOffset_5;

		// Token: 0x0401772E RID: 96046
		internal static int __PropertyOffset_6;

		// Token: 0x0401772F RID: 96047
		internal static int __PropertyOffset_7;

		// Token: 0x04017730 RID: 96048
		internal static int __PropertyOffset_8;

		// Token: 0x04017731 RID: 96049
		[Nullable(2)]
		private FGameplayTagContainer _TagToCheck;

		// Token: 0x04017732 RID: 96050
		internal static int __PropertyOffset_9;

		// Token: 0x04017733 RID: 96051
		internal static int __PropertyOffset_10;
	}
}

using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02003367 RID: 13159
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SSkillBehaviorCondition.SSkillBehaviorCondition")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 66)]
	public class SSkillBehaviorCondition : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602161B RID: 136731 RVA: 0x0095F579 File Offset: 0x0095D779
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SSkillBehaviorCondition._ScriptStructPtr != 0) ? SSkillBehaviorCondition._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SSkillBehaviorCondition.SSkillBehaviorCondition", ref SSkillBehaviorCondition._ScriptStructPtr);
		}

		// Token: 0x1700441D RID: 17437
		// (get) Token: 0x0602161C RID: 136732 RVA: 0x0095F59D File Offset: 0x0095D79D
		// (set) Token: 0x0602161D RID: 136733 RVA: 0x0095F5B1 File Offset: 0x0095D7B1
		public unsafe TEnumAsByte<ESkillBehaviorConditionType> ConditionType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorCondition.__PropertyOffset_ConditionType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorCondition.__PropertyOffset_ConditionType) = value;
			}
		}

		// Token: 0x1700441E RID: 17438
		// (get) Token: 0x0602161E RID: 136734 RVA: 0x0095F5C6 File Offset: 0x0095D7C6
		// (set) Token: 0x0602161F RID: 136735 RVA: 0x0095F5D6 File Offset: 0x0095D7D6
		public unsafe bool IgnoreZ
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorCondition.__PropertyOffset_IgnoreZ) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorCondition.__PropertyOffset_IgnoreZ) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700441F RID: 17439
		// (get) Token: 0x06021620 RID: 136736 RVA: 0x0095F5E7 File Offset: 0x0095D7E7
		// (set) Token: 0x06021621 RID: 136737 RVA: 0x0095F5F7 File Offset: 0x0095D7F7
		public unsafe bool Sign
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorCondition.__PropertyOffset_Sign) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorCondition.__PropertyOffset_Sign) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004420 RID: 17440
		// (get) Token: 0x06021622 RID: 136738 RVA: 0x0095F608 File Offset: 0x0095D808
		// (set) Token: 0x06021623 RID: 136739 RVA: 0x0095F61C File Offset: 0x0095D81C
		public unsafe TEnumAsByte<ESkillBehaviorComparisonLogic> ComparisonLogic
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorCondition.__PropertyOffset_ComparisonLogic);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorCondition.__PropertyOffset_ComparisonLogic) = value;
			}
		}

		// Token: 0x17004421 RID: 17441
		// (get) Token: 0x06021624 RID: 136740 RVA: 0x0095F631 File Offset: 0x0095D831
		// (set) Token: 0x06021625 RID: 136741 RVA: 0x0095F641 File Offset: 0x0095D841
		public unsafe float Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorCondition.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorCondition.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x17004422 RID: 17442
		// (get) Token: 0x06021626 RID: 136742 RVA: 0x0095F652 File Offset: 0x0095D852
		// (set) Token: 0x06021627 RID: 136743 RVA: 0x0095F662 File Offset: 0x0095D862
		public unsafe float RangeL
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorCondition.__PropertyOffset_RangeL);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorCondition.__PropertyOffset_RangeL) = value;
			}
		}

		// Token: 0x17004423 RID: 17443
		// (get) Token: 0x06021628 RID: 136744 RVA: 0x0095F673 File Offset: 0x0095D873
		// (set) Token: 0x06021629 RID: 136745 RVA: 0x0095F683 File Offset: 0x0095D883
		public unsafe float RangeR
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorCondition.__PropertyOffset_RangeR);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorCondition.__PropertyOffset_RangeR) = value;
			}
		}

		// Token: 0x17004424 RID: 17444
		// (get) Token: 0x0602162A RID: 136746 RVA: 0x0095F694 File Offset: 0x0095D894
		// (set) Token: 0x0602162B RID: 136747 RVA: 0x0095F6A4 File Offset: 0x0095D8A4
		public unsafe int AttributeId1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorCondition.__PropertyOffset_AttributeId1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorCondition.__PropertyOffset_AttributeId1) = value;
			}
		}

		// Token: 0x17004425 RID: 17445
		// (get) Token: 0x0602162C RID: 136748 RVA: 0x0095F6B5 File Offset: 0x0095D8B5
		// (set) Token: 0x0602162D RID: 136749 RVA: 0x0095F6C5 File Offset: 0x0095D8C5
		public unsafe int AttributeId2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorCondition.__PropertyOffset_AttributeId2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorCondition.__PropertyOffset_AttributeId2) = value;
			}
		}

		// Token: 0x17004426 RID: 17446
		// (get) Token: 0x0602162E RID: 136750 RVA: 0x0095F6D6 File Offset: 0x0095D8D6
		// (set) Token: 0x0602162F RID: 136751 RVA: 0x0095F6E6 File Offset: 0x0095D8E6
		public unsafe int AttributeRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorCondition.__PropertyOffset_AttributeRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorCondition.__PropertyOffset_AttributeRate) = value;
			}
		}

		// Token: 0x17004427 RID: 17447
		// (get) Token: 0x06021630 RID: 136752 RVA: 0x0095F6F8 File Offset: 0x0095D8F8
		// (set) Token: 0x06021631 RID: 136753 RVA: 0x0095F73B File Offset: 0x0095D93B
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
					result = (this._TagToCheck = new FGameplayTagContainer(base.NativePtr + (IntPtr)SSkillBehaviorCondition.__PropertyOffset_TagToCheck, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)SSkillBehaviorCondition.__PropertyOffset_TagToCheck, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004428 RID: 17448
		// (get) Token: 0x06021632 RID: 136754 RVA: 0x0095F75C File Offset: 0x0095D95C
		// (set) Token: 0x06021633 RID: 136755 RVA: 0x0095F76C File Offset: 0x0095D96C
		public unsafe bool AnyTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorCondition.__PropertyOffset_AnyTag) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorCondition.__PropertyOffset_AnyTag) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004429 RID: 17449
		// (get) Token: 0x06021634 RID: 136756 RVA: 0x0095F77D File Offset: 0x0095D97D
		// (set) Token: 0x06021635 RID: 136757 RVA: 0x0095F78D File Offset: 0x0095D98D
		public unsafe bool Reverse
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorCondition.__PropertyOffset_Reverse) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorCondition.__PropertyOffset_Reverse) = (value ? 1 : 0);
			}
		}

		// Token: 0x06021636 RID: 136758 RVA: 0x0095F79E File Offset: 0x0095D99E
		public SSkillBehaviorCondition()
		{
		}

		// Token: 0x06021637 RID: 136759 RVA: 0x0095F7A6 File Offset: 0x0095D9A6
		protected override IntPtr GetUStructPtr()
		{
			return SSkillBehaviorCondition.StaticStruct();
		}

		// Token: 0x06021638 RID: 136760 RVA: 0x0095F7B2 File Offset: 0x0095D9B2
		[NullableContext(2)]
		public SSkillBehaviorCondition(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021639 RID: 136761 RVA: 0x0095F7BC File Offset: 0x0095D9BC
		public SSkillBehaviorCondition(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602163A RID: 136762 RVA: 0x0095F7C7 File Offset: 0x0095D9C7
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SSkillBehaviorCondition(Pointer, false, true);
		}

		// Token: 0x0602163B RID: 136763 RVA: 0x0095F7D1 File Offset: 0x0095D9D1
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SSkillBehaviorCondition(Pointer, MemoryOwner);
		}

		// Token: 0x040123E8 RID: 74728
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SSkillBehaviorCondition.SSkillBehaviorCondition";

		// Token: 0x040123E9 RID: 74729
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040123EA RID: 74730
		internal static int __PropertyOffset_ConditionType;

		// Token: 0x040123EB RID: 74731
		internal static int __PropertyOffset_IgnoreZ;

		// Token: 0x040123EC RID: 74732
		internal static int __PropertyOffset_Sign;

		// Token: 0x040123ED RID: 74733
		internal static int __PropertyOffset_ComparisonLogic;

		// Token: 0x040123EE RID: 74734
		internal static int __PropertyOffset_Value;

		// Token: 0x040123EF RID: 74735
		internal static int __PropertyOffset_RangeL;

		// Token: 0x040123F0 RID: 74736
		internal static int __PropertyOffset_RangeR;

		// Token: 0x040123F1 RID: 74737
		internal static int __PropertyOffset_AttributeId1;

		// Token: 0x040123F2 RID: 74738
		internal static int __PropertyOffset_AttributeId2;

		// Token: 0x040123F3 RID: 74739
		internal static int __PropertyOffset_AttributeRate;

		// Token: 0x040123F4 RID: 74740
		internal static int __PropertyOffset_TagToCheck;

		// Token: 0x040123F5 RID: 74741
		[Nullable(2)]
		private FGameplayTagContainer _TagToCheck;

		// Token: 0x040123F6 RID: 74742
		internal static int __PropertyOffset_AnyTag;

		// Token: 0x040123F7 RID: 74743
		internal static int __PropertyOffset_Reverse;
	}
}

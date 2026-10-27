using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x0200432F RID: 17199
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SSkillBehaviorCondition.SSkillBehaviorCondition")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 66)]
	public class SSkillBehaviorCondition : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602C91F RID: 182559 RVA: 0x00A22EF7 File Offset: 0x00A210F7
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SSkillBehaviorCondition._ScriptStructPtr != 0) ? SSkillBehaviorCondition._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SSkillBehaviorCondition.SSkillBehaviorCondition", ref SSkillBehaviorCondition._ScriptStructPtr);
		}

		// Token: 0x17006FF0 RID: 28656
		// (get) Token: 0x0602C920 RID: 182560 RVA: 0x00A22F1B File Offset: 0x00A2111B
		// (set) Token: 0x0602C921 RID: 182561 RVA: 0x00A22F2F File Offset: 0x00A2112F
		public unsafe TEnumAsByte<ESkillBehaviorConditionType> ConditionType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorCondition.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorCondition.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17006FF1 RID: 28657
		// (get) Token: 0x0602C922 RID: 182562 RVA: 0x00A22F44 File Offset: 0x00A21144
		// (set) Token: 0x0602C923 RID: 182563 RVA: 0x00A22F54 File Offset: 0x00A21154
		public unsafe bool IgnoreZ
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorCondition.__PropertyOffset_1) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorCondition.__PropertyOffset_1) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006FF2 RID: 28658
		// (get) Token: 0x0602C924 RID: 182564 RVA: 0x00A22F65 File Offset: 0x00A21165
		// (set) Token: 0x0602C925 RID: 182565 RVA: 0x00A22F75 File Offset: 0x00A21175
		public unsafe bool Sign
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorCondition.__PropertyOffset_2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorCondition.__PropertyOffset_2) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006FF3 RID: 28659
		// (get) Token: 0x0602C926 RID: 182566 RVA: 0x00A22F86 File Offset: 0x00A21186
		// (set) Token: 0x0602C927 RID: 182567 RVA: 0x00A22F9A File Offset: 0x00A2119A
		public unsafe TEnumAsByte<ESkillBehaviorComparisonLogic> ComparisonLogic
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorCondition.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorCondition.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17006FF4 RID: 28660
		// (get) Token: 0x0602C928 RID: 182568 RVA: 0x00A22FAF File Offset: 0x00A211AF
		// (set) Token: 0x0602C929 RID: 182569 RVA: 0x00A22FBF File Offset: 0x00A211BF
		public unsafe float Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorCondition.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorCondition.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17006FF5 RID: 28661
		// (get) Token: 0x0602C92A RID: 182570 RVA: 0x00A22FD0 File Offset: 0x00A211D0
		// (set) Token: 0x0602C92B RID: 182571 RVA: 0x00A22FE0 File Offset: 0x00A211E0
		public unsafe float RangeL
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorCondition.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorCondition.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17006FF6 RID: 28662
		// (get) Token: 0x0602C92C RID: 182572 RVA: 0x00A22FF1 File Offset: 0x00A211F1
		// (set) Token: 0x0602C92D RID: 182573 RVA: 0x00A23001 File Offset: 0x00A21201
		public unsafe float RangeR
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorCondition.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorCondition.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17006FF7 RID: 28663
		// (get) Token: 0x0602C92E RID: 182574 RVA: 0x00A23012 File Offset: 0x00A21212
		// (set) Token: 0x0602C92F RID: 182575 RVA: 0x00A23022 File Offset: 0x00A21222
		public unsafe int AttributeId1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorCondition.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorCondition.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17006FF8 RID: 28664
		// (get) Token: 0x0602C930 RID: 182576 RVA: 0x00A23033 File Offset: 0x00A21233
		// (set) Token: 0x0602C931 RID: 182577 RVA: 0x00A23043 File Offset: 0x00A21243
		public unsafe int AttributeId2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorCondition.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorCondition.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17006FF9 RID: 28665
		// (get) Token: 0x0602C932 RID: 182578 RVA: 0x00A23054 File Offset: 0x00A21254
		// (set) Token: 0x0602C933 RID: 182579 RVA: 0x00A23064 File Offset: 0x00A21264
		public unsafe int AttributeRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorCondition.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorCondition.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17006FFA RID: 28666
		// (get) Token: 0x0602C934 RID: 182580 RVA: 0x00A23078 File Offset: 0x00A21278
		// (set) Token: 0x0602C935 RID: 182581 RVA: 0x00A230BB File Offset: 0x00A212BB
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
					result = (this._TagToCheck = new FGameplayTagContainer(base.NativePtr + (IntPtr)SSkillBehaviorCondition.__PropertyOffset_10, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)SSkillBehaviorCondition.__PropertyOffset_10, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006FFB RID: 28667
		// (get) Token: 0x0602C936 RID: 182582 RVA: 0x00A230DC File Offset: 0x00A212DC
		// (set) Token: 0x0602C937 RID: 182583 RVA: 0x00A230EC File Offset: 0x00A212EC
		public unsafe bool AnyTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorCondition.__PropertyOffset_11) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorCondition.__PropertyOffset_11) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006FFC RID: 28668
		// (get) Token: 0x0602C938 RID: 182584 RVA: 0x00A230FD File Offset: 0x00A212FD
		// (set) Token: 0x0602C939 RID: 182585 RVA: 0x00A2310D File Offset: 0x00A2130D
		public unsafe bool Reverse
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorCondition.__PropertyOffset_12) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorCondition.__PropertyOffset_12) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602C93A RID: 182586 RVA: 0x00A2311E File Offset: 0x00A2131E
		public SSkillBehaviorCondition()
		{
		}

		// Token: 0x0602C93B RID: 182587 RVA: 0x00A23128 File Offset: 0x00A21328
		public SSkillBehaviorCondition(TEnumAsByte<ESkillBehaviorConditionType> ConditionType, bool IgnoreZ, bool Sign, TEnumAsByte<ESkillBehaviorComparisonLogic> ComparisonLogic, float Value, float RangeL, float RangeR, int AttributeId1, int AttributeId2, int AttributeRate, [Nullable(1)] FGameplayTagContainer TagToCheck, bool AnyTag, bool Reverse)
		{
			this.ConditionType = ConditionType;
			this.IgnoreZ = IgnoreZ;
			this.Sign = Sign;
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

		// Token: 0x0602C93C RID: 182588 RVA: 0x00A231A0 File Offset: 0x00A213A0
		protected override IntPtr GetUStructPtr()
		{
			return SSkillBehaviorCondition.StaticStruct();
		}

		// Token: 0x0602C93D RID: 182589 RVA: 0x00A231AC File Offset: 0x00A213AC
		[NullableContext(2)]
		public SSkillBehaviorCondition(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602C93E RID: 182590 RVA: 0x00A231B6 File Offset: 0x00A213B6
		public SSkillBehaviorCondition(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602C93F RID: 182591 RVA: 0x00A231C1 File Offset: 0x00A213C1
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SSkillBehaviorCondition(Pointer, false, true);
		}

		// Token: 0x0602C940 RID: 182592 RVA: 0x00A231CB File Offset: 0x00A213CB
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SSkillBehaviorCondition(Pointer, MemoryOwner);
		}

		// Token: 0x040177E7 RID: 96231
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SSkillBehaviorCondition.SSkillBehaviorCondition";

		// Token: 0x040177E8 RID: 96232
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040177E9 RID: 96233
		internal static int __PropertyOffset_0;

		// Token: 0x040177EA RID: 96234
		internal static int __PropertyOffset_1;

		// Token: 0x040177EB RID: 96235
		internal static int __PropertyOffset_2;

		// Token: 0x040177EC RID: 96236
		internal static int __PropertyOffset_3;

		// Token: 0x040177ED RID: 96237
		internal static int __PropertyOffset_4;

		// Token: 0x040177EE RID: 96238
		internal static int __PropertyOffset_5;

		// Token: 0x040177EF RID: 96239
		internal static int __PropertyOffset_6;

		// Token: 0x040177F0 RID: 96240
		internal static int __PropertyOffset_7;

		// Token: 0x040177F1 RID: 96241
		internal static int __PropertyOffset_8;

		// Token: 0x040177F2 RID: 96242
		internal static int __PropertyOffset_9;

		// Token: 0x040177F3 RID: 96243
		internal static int __PropertyOffset_10;

		// Token: 0x040177F4 RID: 96244
		[Nullable(2)]
		private FGameplayTagContainer _TagToCheck;

		// Token: 0x040177F5 RID: 96245
		internal static int __PropertyOffset_11;

		// Token: 0x040177F6 RID: 96246
		internal static int __PropertyOffset_12;
	}
}

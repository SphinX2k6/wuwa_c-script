using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x0200335A RID: 13146
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SInputBehaviorCondition.SInputBehaviorCondition")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 77)]
	public class SInputBehaviorCondition : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060214BE RID: 136382 RVA: 0x0095D6C5 File Offset: 0x0095B8C5
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SInputBehaviorCondition._ScriptStructPtr != 0) ? SInputBehaviorCondition._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SInputBehaviorCondition.SInputBehaviorCondition", ref SInputBehaviorCondition._ScriptStructPtr);
		}

		// Token: 0x1700439C RID: 17308
		// (get) Token: 0x060214BF RID: 136383 RVA: 0x0095D6E9 File Offset: 0x0095B8E9
		// (set) Token: 0x060214C0 RID: 136384 RVA: 0x0095D6FD File Offset: 0x0095B8FD
		public unsafe TEnumAsByte<EInputBehaviorConditionType> ConditionType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SInputBehaviorCondition.__PropertyOffset_ConditionType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SInputBehaviorCondition.__PropertyOffset_ConditionType) = value;
			}
		}

		// Token: 0x1700439D RID: 17309
		// (get) Token: 0x060214C1 RID: 136385 RVA: 0x0095D712 File Offset: 0x0095B912
		// (set) Token: 0x060214C2 RID: 136386 RVA: 0x0095D726 File Offset: 0x0095B926
		public unsafe TEnumAsByte<EInputBehaviorInputAction> InputType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SInputBehaviorCondition.__PropertyOffset_InputType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SInputBehaviorCondition.__PropertyOffset_InputType) = value;
			}
		}

		// Token: 0x1700439E RID: 17310
		// (get) Token: 0x060214C3 RID: 136387 RVA: 0x0095D73B File Offset: 0x0095B93B
		// (set) Token: 0x060214C4 RID: 136388 RVA: 0x0095D74B File Offset: 0x0095B94B
		public unsafe float MinReleaseTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SInputBehaviorCondition.__PropertyOffset_MinReleaseTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SInputBehaviorCondition.__PropertyOffset_MinReleaseTime) = value;
			}
		}

		// Token: 0x1700439F RID: 17311
		// (get) Token: 0x060214C5 RID: 136389 RVA: 0x0095D75C File Offset: 0x0095B95C
		// (set) Token: 0x060214C6 RID: 136390 RVA: 0x0095D76C File Offset: 0x0095B96C
		public unsafe float MaxReleaseTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SInputBehaviorCondition.__PropertyOffset_MaxReleaseTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SInputBehaviorCondition.__PropertyOffset_MaxReleaseTime) = value;
			}
		}

		// Token: 0x170043A0 RID: 17312
		// (get) Token: 0x060214C7 RID: 136391 RVA: 0x0095D77D File Offset: 0x0095B97D
		// (set) Token: 0x060214C8 RID: 136392 RVA: 0x0095D78D File Offset: 0x0095B98D
		public unsafe bool bRequirePressInNotify
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SInputBehaviorCondition.__PropertyOffset_bRequirePressInNotify) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SInputBehaviorCondition.__PropertyOffset_bRequirePressInNotify) = (value ? 1 : 0);
			}
		}

		// Token: 0x170043A1 RID: 17313
		// (get) Token: 0x060214C9 RID: 136393 RVA: 0x0095D79E File Offset: 0x0095B99E
		// (set) Token: 0x060214CA RID: 136394 RVA: 0x0095D7AE File Offset: 0x0095B9AE
		public unsafe float HoldDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SInputBehaviorCondition.__PropertyOffset_HoldDuration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SInputBehaviorCondition.__PropertyOffset_HoldDuration) = value;
			}
		}

		// Token: 0x170043A2 RID: 17314
		// (get) Token: 0x060214CB RID: 136395 RVA: 0x0095D7C0 File Offset: 0x0095B9C0
		// (set) Token: 0x060214CC RID: 136396 RVA: 0x0095D803 File Offset: 0x0095BA03
		[Nullable(1)]
		public FGameplayTagContainer TagsToCheck
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._TagsToCheck) == null)
				{
					result = (this._TagsToCheck = new FGameplayTagContainer(base.NativePtr + (IntPtr)SInputBehaviorCondition.__PropertyOffset_TagsToCheck, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)SInputBehaviorCondition.__PropertyOffset_TagsToCheck, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170043A3 RID: 17315
		// (get) Token: 0x060214CD RID: 136397 RVA: 0x0095D824 File Offset: 0x0095BA24
		// (set) Token: 0x060214CE RID: 136398 RVA: 0x0095D834 File Offset: 0x0095BA34
		public unsafe bool bAnyTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SInputBehaviorCondition.__PropertyOffset_bAnyTag) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SInputBehaviorCondition.__PropertyOffset_bAnyTag) = (value ? 1 : 0);
			}
		}

		// Token: 0x170043A4 RID: 17316
		// (get) Token: 0x060214CF RID: 136399 RVA: 0x0095D845 File Offset: 0x0095BA45
		// (set) Token: 0x060214D0 RID: 136400 RVA: 0x0095D859 File Offset: 0x0095BA59
		public unsafe TEnumAsByte<ESkillBehaviorComparisonLogic> ComparisonLogic
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SInputBehaviorCondition.__PropertyOffset_ComparisonLogic);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SInputBehaviorCondition.__PropertyOffset_ComparisonLogic) = value;
			}
		}

		// Token: 0x170043A5 RID: 17317
		// (get) Token: 0x060214D1 RID: 136401 RVA: 0x0095D86E File Offset: 0x0095BA6E
		// (set) Token: 0x060214D2 RID: 136402 RVA: 0x0095D87E File Offset: 0x0095BA7E
		public unsafe float ComparisonValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SInputBehaviorCondition.__PropertyOffset_ComparisonValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SInputBehaviorCondition.__PropertyOffset_ComparisonValue) = value;
			}
		}

		// Token: 0x170043A6 RID: 17318
		// (get) Token: 0x060214D3 RID: 136403 RVA: 0x0095D88F File Offset: 0x0095BA8F
		// (set) Token: 0x060214D4 RID: 136404 RVA: 0x0095D89F File Offset: 0x0095BA9F
		public unsafe int AttributeId1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SInputBehaviorCondition.__PropertyOffset_AttributeId1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SInputBehaviorCondition.__PropertyOffset_AttributeId1) = value;
			}
		}

		// Token: 0x170043A7 RID: 17319
		// (get) Token: 0x060214D5 RID: 136405 RVA: 0x0095D8B0 File Offset: 0x0095BAB0
		// (set) Token: 0x060214D6 RID: 136406 RVA: 0x0095D8C0 File Offset: 0x0095BAC0
		public unsafe int AttributeId2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SInputBehaviorCondition.__PropertyOffset_AttributeId2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SInputBehaviorCondition.__PropertyOffset_AttributeId2) = value;
			}
		}

		// Token: 0x170043A8 RID: 17320
		// (get) Token: 0x060214D7 RID: 136407 RVA: 0x0095D8D1 File Offset: 0x0095BAD1
		// (set) Token: 0x060214D8 RID: 136408 RVA: 0x0095D8E1 File Offset: 0x0095BAE1
		public unsafe int AttributeRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SInputBehaviorCondition.__PropertyOffset_AttributeRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SInputBehaviorCondition.__PropertyOffset_AttributeRate) = value;
			}
		}

		// Token: 0x170043A9 RID: 17321
		// (get) Token: 0x060214D9 RID: 136409 RVA: 0x0095D8F2 File Offset: 0x0095BAF2
		// (set) Token: 0x060214DA RID: 136410 RVA: 0x0095D902 File Offset: 0x0095BB02
		public unsafe bool bReverse
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SInputBehaviorCondition.__PropertyOffset_bReverse) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SInputBehaviorCondition.__PropertyOffset_bReverse) = (value ? 1 : 0);
			}
		}

		// Token: 0x060214DB RID: 136411 RVA: 0x0095D913 File Offset: 0x0095BB13
		public SInputBehaviorCondition()
		{
		}

		// Token: 0x060214DC RID: 136412 RVA: 0x0095D91B File Offset: 0x0095BB1B
		protected override IntPtr GetUStructPtr()
		{
			return SInputBehaviorCondition.StaticStruct();
		}

		// Token: 0x060214DD RID: 136413 RVA: 0x0095D927 File Offset: 0x0095BB27
		[NullableContext(2)]
		public SInputBehaviorCondition(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060214DE RID: 136414 RVA: 0x0095D931 File Offset: 0x0095BB31
		public SInputBehaviorCondition(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060214DF RID: 136415 RVA: 0x0095D93C File Offset: 0x0095BB3C
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SInputBehaviorCondition(Pointer, false, true);
		}

		// Token: 0x060214E0 RID: 136416 RVA: 0x0095D946 File Offset: 0x0095BB46
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SInputBehaviorCondition(Pointer, MemoryOwner);
		}

		// Token: 0x0401232F RID: 74543
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SInputBehaviorCondition.SInputBehaviorCondition";

		// Token: 0x04012330 RID: 74544
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012331 RID: 74545
		internal static int __PropertyOffset_ConditionType;

		// Token: 0x04012332 RID: 74546
		internal static int __PropertyOffset_InputType;

		// Token: 0x04012333 RID: 74547
		internal static int __PropertyOffset_MinReleaseTime;

		// Token: 0x04012334 RID: 74548
		internal static int __PropertyOffset_MaxReleaseTime;

		// Token: 0x04012335 RID: 74549
		internal static int __PropertyOffset_bRequirePressInNotify;

		// Token: 0x04012336 RID: 74550
		internal static int __PropertyOffset_HoldDuration;

		// Token: 0x04012337 RID: 74551
		internal static int __PropertyOffset_TagsToCheck;

		// Token: 0x04012338 RID: 74552
		[Nullable(2)]
		private FGameplayTagContainer _TagsToCheck;

		// Token: 0x04012339 RID: 74553
		internal static int __PropertyOffset_bAnyTag;

		// Token: 0x0401233A RID: 74554
		internal static int __PropertyOffset_ComparisonLogic;

		// Token: 0x0401233B RID: 74555
		internal static int __PropertyOffset_ComparisonValue;

		// Token: 0x0401233C RID: 74556
		internal static int __PropertyOffset_AttributeId1;

		// Token: 0x0401233D RID: 74557
		internal static int __PropertyOffset_AttributeId2;

		// Token: 0x0401233E RID: 74558
		internal static int __PropertyOffset_AttributeRate;

		// Token: 0x0401233F RID: 74559
		internal static int __PropertyOffset_bReverse;
	}
}

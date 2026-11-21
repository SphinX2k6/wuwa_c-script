using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02003357 RID: 13143
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SInputActiveCondition.SInputActiveCondition")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 66)]
	public class SInputActiveCondition : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602147F RID: 136319 RVA: 0x0095D1D2 File Offset: 0x0095B3D2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SInputActiveCondition._ScriptStructPtr != 0) ? SInputActiveCondition._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SInputActiveCondition.SInputActiveCondition", ref SInputActiveCondition._ScriptStructPtr);
		}

		// Token: 0x17004387 RID: 17287
		// (get) Token: 0x06021480 RID: 136320 RVA: 0x0095D1F6 File Offset: 0x0095B3F6
		// (set) Token: 0x06021481 RID: 136321 RVA: 0x0095D20A File Offset: 0x0095B40A
		public unsafe TEnumAsByte<EInputActiveConditionType> ConditionType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SInputActiveCondition.__PropertyOffset_ConditionType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SInputActiveCondition.__PropertyOffset_ConditionType) = value;
			}
		}

		// Token: 0x17004388 RID: 17288
		// (get) Token: 0x06021482 RID: 136322 RVA: 0x0095D21F File Offset: 0x0095B41F
		// (set) Token: 0x06021483 RID: 136323 RVA: 0x0095D233 File Offset: 0x0095B433
		public unsafe TEnumAsByte<ESkillBehaviorComparisonLogic> ComparisonLogic
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SInputActiveCondition.__PropertyOffset_ComparisonLogic);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SInputActiveCondition.__PropertyOffset_ComparisonLogic) = value;
			}
		}

		// Token: 0x17004389 RID: 17289
		// (get) Token: 0x06021484 RID: 136324 RVA: 0x0095D248 File Offset: 0x0095B448
		// (set) Token: 0x06021485 RID: 136325 RVA: 0x0095D258 File Offset: 0x0095B458
		public unsafe float Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SInputActiveCondition.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SInputActiveCondition.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x1700438A RID: 17290
		// (get) Token: 0x06021486 RID: 136326 RVA: 0x0095D269 File Offset: 0x0095B469
		// (set) Token: 0x06021487 RID: 136327 RVA: 0x0095D279 File Offset: 0x0095B479
		public unsafe float RangeL
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SInputActiveCondition.__PropertyOffset_RangeL);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SInputActiveCondition.__PropertyOffset_RangeL) = value;
			}
		}

		// Token: 0x1700438B RID: 17291
		// (get) Token: 0x06021488 RID: 136328 RVA: 0x0095D28A File Offset: 0x0095B48A
		// (set) Token: 0x06021489 RID: 136329 RVA: 0x0095D29A File Offset: 0x0095B49A
		public unsafe float RangeR
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SInputActiveCondition.__PropertyOffset_RangeR);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SInputActiveCondition.__PropertyOffset_RangeR) = value;
			}
		}

		// Token: 0x1700438C RID: 17292
		// (get) Token: 0x0602148A RID: 136330 RVA: 0x0095D2AB File Offset: 0x0095B4AB
		// (set) Token: 0x0602148B RID: 136331 RVA: 0x0095D2BB File Offset: 0x0095B4BB
		public unsafe int AttributeId1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SInputActiveCondition.__PropertyOffset_AttributeId1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SInputActiveCondition.__PropertyOffset_AttributeId1) = value;
			}
		}

		// Token: 0x1700438D RID: 17293
		// (get) Token: 0x0602148C RID: 136332 RVA: 0x0095D2CC File Offset: 0x0095B4CC
		// (set) Token: 0x0602148D RID: 136333 RVA: 0x0095D2DC File Offset: 0x0095B4DC
		public unsafe int AttributeId2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SInputActiveCondition.__PropertyOffset_AttributeId2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SInputActiveCondition.__PropertyOffset_AttributeId2) = value;
			}
		}

		// Token: 0x1700438E RID: 17294
		// (get) Token: 0x0602148E RID: 136334 RVA: 0x0095D2ED File Offset: 0x0095B4ED
		// (set) Token: 0x0602148F RID: 136335 RVA: 0x0095D2FD File Offset: 0x0095B4FD
		public unsafe int AttributeRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SInputActiveCondition.__PropertyOffset_AttributeRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SInputActiveCondition.__PropertyOffset_AttributeRate) = value;
			}
		}

		// Token: 0x1700438F RID: 17295
		// (get) Token: 0x06021490 RID: 136336 RVA: 0x0095D310 File Offset: 0x0095B510
		// (set) Token: 0x06021491 RID: 136337 RVA: 0x0095D353 File Offset: 0x0095B553
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
					result = (this._TagToCheck = new FGameplayTagContainer(base.NativePtr + (IntPtr)SInputActiveCondition.__PropertyOffset_TagToCheck, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)SInputActiveCondition.__PropertyOffset_TagToCheck, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004390 RID: 17296
		// (get) Token: 0x06021492 RID: 136338 RVA: 0x0095D374 File Offset: 0x0095B574
		// (set) Token: 0x06021493 RID: 136339 RVA: 0x0095D384 File Offset: 0x0095B584
		public unsafe bool AnyTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SInputActiveCondition.__PropertyOffset_AnyTag) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SInputActiveCondition.__PropertyOffset_AnyTag) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004391 RID: 17297
		// (get) Token: 0x06021494 RID: 136340 RVA: 0x0095D395 File Offset: 0x0095B595
		// (set) Token: 0x06021495 RID: 136341 RVA: 0x0095D3A5 File Offset: 0x0095B5A5
		public unsafe bool Reverse
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SInputActiveCondition.__PropertyOffset_Reverse) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SInputActiveCondition.__PropertyOffset_Reverse) = (value ? 1 : 0);
			}
		}

		// Token: 0x06021496 RID: 136342 RVA: 0x0095D3B6 File Offset: 0x0095B5B6
		public SInputActiveCondition()
		{
		}

		// Token: 0x06021497 RID: 136343 RVA: 0x0095D3BE File Offset: 0x0095B5BE
		protected override IntPtr GetUStructPtr()
		{
			return SInputActiveCondition.StaticStruct();
		}

		// Token: 0x06021498 RID: 136344 RVA: 0x0095D3CA File Offset: 0x0095B5CA
		[NullableContext(2)]
		public SInputActiveCondition(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021499 RID: 136345 RVA: 0x0095D3D4 File Offset: 0x0095B5D4
		public SInputActiveCondition(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602149A RID: 136346 RVA: 0x0095D3DF File Offset: 0x0095B5DF
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SInputActiveCondition(Pointer, false, true);
		}

		// Token: 0x0602149B RID: 136347 RVA: 0x0095D3E9 File Offset: 0x0095B5E9
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SInputActiveCondition(Pointer, MemoryOwner);
		}

		// Token: 0x04012310 RID: 74512
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SInputActiveCondition.SInputActiveCondition";

		// Token: 0x04012311 RID: 74513
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012312 RID: 74514
		internal static int __PropertyOffset_ConditionType;

		// Token: 0x04012313 RID: 74515
		internal static int __PropertyOffset_ComparisonLogic;

		// Token: 0x04012314 RID: 74516
		internal static int __PropertyOffset_Value;

		// Token: 0x04012315 RID: 74517
		internal static int __PropertyOffset_RangeL;

		// Token: 0x04012316 RID: 74518
		internal static int __PropertyOffset_RangeR;

		// Token: 0x04012317 RID: 74519
		internal static int __PropertyOffset_AttributeId1;

		// Token: 0x04012318 RID: 74520
		internal static int __PropertyOffset_AttributeId2;

		// Token: 0x04012319 RID: 74521
		internal static int __PropertyOffset_AttributeRate;

		// Token: 0x0401231A RID: 74522
		internal static int __PropertyOffset_TagToCheck;

		// Token: 0x0401231B RID: 74523
		[Nullable(2)]
		private FGameplayTagContainer _TagToCheck;

		// Token: 0x0401231C RID: 74524
		internal static int __PropertyOffset_AnyTag;

		// Token: 0x0401231D RID: 74525
		internal static int __PropertyOffset_Reverse;
	}
}

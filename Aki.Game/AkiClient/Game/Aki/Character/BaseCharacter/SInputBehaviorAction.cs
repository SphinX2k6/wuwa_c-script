using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02003359 RID: 13145
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SInputBehaviorAction.SInputBehaviorAction")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 65)]
	public class SInputBehaviorAction : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060214AB RID: 136363 RVA: 0x0095D549 File Offset: 0x0095B749
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SInputBehaviorAction._ScriptStructPtr != 0) ? SInputBehaviorAction._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SInputBehaviorAction.SInputBehaviorAction", ref SInputBehaviorAction._ScriptStructPtr);
		}

		// Token: 0x17004396 RID: 17302
		// (get) Token: 0x060214AC RID: 136364 RVA: 0x0095D56D File Offset: 0x0095B76D
		// (set) Token: 0x060214AD RID: 136365 RVA: 0x0095D581 File Offset: 0x0095B781
		[Nullable(0)]
		public unsafe TEnumAsByte<EInputBehaviorActionType> ActionType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SInputBehaviorAction.__PropertyOffset_ActionType);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SInputBehaviorAction.__PropertyOffset_ActionType) = value;
			}
		}

		// Token: 0x17004397 RID: 17303
		// (get) Token: 0x060214AE RID: 136366 RVA: 0x0095D596 File Offset: 0x0095B796
		// (set) Token: 0x060214AF RID: 136367 RVA: 0x0095D5A6 File Offset: 0x0095B7A6
		public unsafe int MontageIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SInputBehaviorAction.__PropertyOffset_MontageIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SInputBehaviorAction.__PropertyOffset_MontageIndex) = value;
			}
		}

		// Token: 0x17004398 RID: 17304
		// (get) Token: 0x060214B0 RID: 136368 RVA: 0x0095D5B7 File Offset: 0x0095B7B7
		// (set) Token: 0x060214B1 RID: 136369 RVA: 0x0095D5CB File Offset: 0x0095B7CB
		public unsafe string StartSection
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SInputBehaviorAction.__PropertyOffset_StartSection)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SInputBehaviorAction.__PropertyOffset_StartSection)), value);
			}
		}

		// Token: 0x17004399 RID: 17305
		// (get) Token: 0x060214B2 RID: 136370 RVA: 0x0095D5E0 File Offset: 0x0095B7E0
		// (set) Token: 0x060214B3 RID: 136371 RVA: 0x0095D5F0 File Offset: 0x0095B7F0
		public unsafe float StartTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SInputBehaviorAction.__PropertyOffset_StartTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SInputBehaviorAction.__PropertyOffset_StartTime) = value;
			}
		}

		// Token: 0x1700439A RID: 17306
		// (get) Token: 0x060214B4 RID: 136372 RVA: 0x0095D604 File Offset: 0x0095B804
		// (set) Token: 0x060214B5 RID: 136373 RVA: 0x0095D647 File Offset: 0x0095B847
		public FGameplayTagContainer Tags
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._Tags) == null)
				{
					result = (this._Tags = new FGameplayTagContainer(base.NativePtr + (IntPtr)SInputBehaviorAction.__PropertyOffset_Tags, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)SInputBehaviorAction.__PropertyOffset_Tags, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700439B RID: 17307
		// (get) Token: 0x060214B6 RID: 136374 RVA: 0x0095D668 File Offset: 0x0095B868
		// (set) Token: 0x060214B7 RID: 136375 RVA: 0x0095D678 File Offset: 0x0095B878
		public unsafe bool bAdd
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SInputBehaviorAction.__PropertyOffset_bAdd) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SInputBehaviorAction.__PropertyOffset_bAdd) = (value ? 1 : 0);
			}
		}

		// Token: 0x060214B8 RID: 136376 RVA: 0x0095D689 File Offset: 0x0095B889
		public SInputBehaviorAction()
		{
		}

		// Token: 0x060214B9 RID: 136377 RVA: 0x0095D691 File Offset: 0x0095B891
		protected override IntPtr GetUStructPtr()
		{
			return SInputBehaviorAction.StaticStruct();
		}

		// Token: 0x060214BA RID: 136378 RVA: 0x0095D69D File Offset: 0x0095B89D
		[NullableContext(2)]
		public SInputBehaviorAction(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060214BB RID: 136379 RVA: 0x0095D6A7 File Offset: 0x0095B8A7
		public SInputBehaviorAction(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060214BC RID: 136380 RVA: 0x0095D6B2 File Offset: 0x0095B8B2
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SInputBehaviorAction(Pointer, false, true);
		}

		// Token: 0x060214BD RID: 136381 RVA: 0x0095D6BC File Offset: 0x0095B8BC
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SInputBehaviorAction(Pointer, MemoryOwner);
		}

		// Token: 0x04012326 RID: 74534
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SInputBehaviorAction.SInputBehaviorAction";

		// Token: 0x04012327 RID: 74535
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012328 RID: 74536
		internal static int __PropertyOffset_ActionType;

		// Token: 0x04012329 RID: 74537
		internal static int __PropertyOffset_MontageIndex;

		// Token: 0x0401232A RID: 74538
		internal static int __PropertyOffset_StartSection;

		// Token: 0x0401232B RID: 74539
		internal static int __PropertyOffset_StartTime;

		// Token: 0x0401232C RID: 74540
		internal static int __PropertyOffset_Tags;

		// Token: 0x0401232D RID: 74541
		[Nullable(2)]
		private FGameplayTagContainer _Tags;

		// Token: 0x0401232E RID: 74542
		internal static int __PropertyOffset_bAdd;
	}
}

using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x0200333D RID: 13117
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SCaughtTriggerInfo.SCaughtTriggerInfo")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class SCaughtTriggerInfo : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021275 RID: 135797 RVA: 0x0095A6E8 File Offset: 0x009588E8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SCaughtTriggerInfo._ScriptStructPtr != 0) ? SCaughtTriggerInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SCaughtTriggerInfo.SCaughtTriggerInfo", ref SCaughtTriggerInfo._ScriptStructPtr);
		}

		// Token: 0x170042DD RID: 17117
		// (get) Token: 0x06021276 RID: 135798 RVA: 0x0095A70C File Offset: 0x0095890C
		// (set) Token: 0x06021277 RID: 135799 RVA: 0x0095A720 File Offset: 0x00958920
		public unsafe string BulletId
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SCaughtTriggerInfo.__PropertyOffset_BulletId)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SCaughtTriggerInfo.__PropertyOffset_BulletId)), value);
			}
		}

		// Token: 0x170042DE RID: 17118
		// (get) Token: 0x06021278 RID: 135800 RVA: 0x0095A735 File Offset: 0x00958935
		// (set) Token: 0x06021279 RID: 135801 RVA: 0x0095A745 File Offset: 0x00958945
		public unsafe int CaughtMxNumber
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCaughtTriggerInfo.__PropertyOffset_CaughtMxNumber);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCaughtTriggerInfo.__PropertyOffset_CaughtMxNumber) = value;
			}
		}

		// Token: 0x170042DF RID: 17119
		// (get) Token: 0x0602127A RID: 135802 RVA: 0x0095A756 File Offset: 0x00958956
		// (set) Token: 0x0602127B RID: 135803 RVA: 0x0095A766 File Offset: 0x00958966
		public unsafe int CaughtLevel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCaughtTriggerInfo.__PropertyOffset_CaughtLevel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCaughtTriggerInfo.__PropertyOffset_CaughtLevel) = value;
			}
		}

		// Token: 0x170042E0 RID: 17120
		// (get) Token: 0x0602127C RID: 135804 RVA: 0x0095A777 File Offset: 0x00958977
		// (set) Token: 0x0602127D RID: 135805 RVA: 0x0095A787 File Offset: 0x00958987
		public unsafe bool CaughtAimTarget
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCaughtTriggerInfo.__PropertyOffset_CaughtAimTarget) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCaughtTriggerInfo.__PropertyOffset_CaughtAimTarget) = (value ? 1 : 0);
			}
		}

		// Token: 0x170042E1 RID: 17121
		// (get) Token: 0x0602127E RID: 135806 RVA: 0x0095A798 File Offset: 0x00958998
		// (set) Token: 0x0602127F RID: 135807 RVA: 0x0095A7DB File Offset: 0x009589DB
		public TArray<FGameplayTag> CaughtTargetTag
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FGameplayTag> result;
				if ((result = this._CaughtTargetTag) == null)
				{
					result = (this._CaughtTargetTag = new TArray<FGameplayTag>(base.NativePtr + (IntPtr)SCaughtTriggerInfo.__PropertyOffset_CaughtTargetTag, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.CaughtTargetTag.CopyAssign(value);
			}
		}

		// Token: 0x06021280 RID: 135808 RVA: 0x0095A7E9 File Offset: 0x009589E9
		public SCaughtTriggerInfo()
		{
		}

		// Token: 0x06021281 RID: 135809 RVA: 0x0095A7F1 File Offset: 0x009589F1
		protected override IntPtr GetUStructPtr()
		{
			return SCaughtTriggerInfo.StaticStruct();
		}

		// Token: 0x06021282 RID: 135810 RVA: 0x0095A7FD File Offset: 0x009589FD
		[NullableContext(2)]
		public SCaughtTriggerInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021283 RID: 135811 RVA: 0x0095A807 File Offset: 0x00958A07
		public SCaughtTriggerInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021284 RID: 135812 RVA: 0x0095A812 File Offset: 0x00958A12
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SCaughtTriggerInfo(Pointer, false, true);
		}

		// Token: 0x06021285 RID: 135813 RVA: 0x0095A81C File Offset: 0x00958A1C
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SCaughtTriggerInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04012206 RID: 74246
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SCaughtTriggerInfo.SCaughtTriggerInfo";

		// Token: 0x04012207 RID: 74247
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012208 RID: 74248
		internal static int __PropertyOffset_BulletId;

		// Token: 0x04012209 RID: 74249
		internal static int __PropertyOffset_CaughtMxNumber;

		// Token: 0x0401220A RID: 74250
		internal static int __PropertyOffset_CaughtLevel;

		// Token: 0x0401220B RID: 74251
		internal static int __PropertyOffset_CaughtAimTarget;

		// Token: 0x0401220C RID: 74252
		internal static int __PropertyOffset_CaughtTargetTag;

		// Token: 0x0401220D RID: 74253
		[Nullable(2)]
		private TArray<FGameplayTag> _CaughtTargetTag;
	}
}

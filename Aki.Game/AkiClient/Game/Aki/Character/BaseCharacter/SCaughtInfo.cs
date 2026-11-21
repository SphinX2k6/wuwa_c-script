using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x0200333C RID: 13116
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SCaughtInfo.SCaughtInfo")]
	[UnrealStructLayout(240, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 240)]
	public class SCaughtInfo : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602126A RID: 135786 RVA: 0x0095A5BD File Offset: 0x009587BD
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SCaughtInfo._ScriptStructPtr != 0) ? SCaughtInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SCaughtInfo.SCaughtInfo", ref SCaughtInfo._ScriptStructPtr);
		}

		// Token: 0x170042DB RID: 17115
		// (get) Token: 0x0602126B RID: 135787 RVA: 0x0095A5E4 File Offset: 0x009587E4
		// (set) Token: 0x0602126C RID: 135788 RVA: 0x0095A627 File Offset: 0x00958827
		public SCaughtTriggerInfo TriggerInfo
		{
			get
			{
				base.FastCheckIsValid();
				SCaughtTriggerInfo result;
				if ((result = this._TriggerInfo) == null)
				{
					result = (this._TriggerInfo = new SCaughtTriggerInfo(base.NativePtr + (IntPtr)SCaughtInfo.__PropertyOffset_TriggerInfo, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SCaughtTriggerInfo.StaticStruct(), base.NativePtr + (IntPtr)SCaughtInfo.__PropertyOffset_TriggerInfo, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170042DC RID: 17116
		// (get) Token: 0x0602126D RID: 135789 RVA: 0x0095A648 File Offset: 0x00958848
		// (set) Token: 0x0602126E RID: 135790 RVA: 0x0095A68B File Offset: 0x0095888B
		public SCaughtBindingInfo BindingInfo
		{
			get
			{
				base.FastCheckIsValid();
				SCaughtBindingInfo result;
				if ((result = this._BindingInfo) == null)
				{
					result = (this._BindingInfo = new SCaughtBindingInfo(base.NativePtr + (IntPtr)SCaughtInfo.__PropertyOffset_BindingInfo, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SCaughtBindingInfo.StaticStruct(), base.NativePtr + (IntPtr)SCaughtInfo.__PropertyOffset_BindingInfo, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0602126F RID: 135791 RVA: 0x0095A6AC File Offset: 0x009588AC
		public SCaughtInfo()
		{
		}

		// Token: 0x06021270 RID: 135792 RVA: 0x0095A6B4 File Offset: 0x009588B4
		protected override IntPtr GetUStructPtr()
		{
			return SCaughtInfo.StaticStruct();
		}

		// Token: 0x06021271 RID: 135793 RVA: 0x0095A6C0 File Offset: 0x009588C0
		[NullableContext(2)]
		public SCaughtInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021272 RID: 135794 RVA: 0x0095A6CA File Offset: 0x009588CA
		public SCaughtInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021273 RID: 135795 RVA: 0x0095A6D5 File Offset: 0x009588D5
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SCaughtInfo(Pointer, false, true);
		}

		// Token: 0x06021274 RID: 135796 RVA: 0x0095A6DF File Offset: 0x009588DF
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SCaughtInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04012200 RID: 74240
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SCaughtInfo.SCaughtInfo";

		// Token: 0x04012201 RID: 74241
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012202 RID: 74242
		internal static int __PropertyOffset_TriggerInfo;

		// Token: 0x04012203 RID: 74243
		[Nullable(2)]
		private SCaughtTriggerInfo _TriggerInfo;

		// Token: 0x04012204 RID: 74244
		internal static int __PropertyOffset_BindingInfo;

		// Token: 0x04012205 RID: 74245
		[Nullable(2)]
		private SCaughtBindingInfo _BindingInfo;
	}
}

using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020042FF RID: 17151
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SCaughtInfo.SCaughtInfo")]
	[UnrealStructLayout(240, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 240)]
	public class SCaughtInfo : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602C54A RID: 181578 RVA: 0x00A1D41C File Offset: 0x00A1B61C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SCaughtInfo._ScriptStructPtr != 0) ? SCaughtInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SCaughtInfo.SCaughtInfo", ref SCaughtInfo._ScriptStructPtr);
		}

		// Token: 0x17006EC1 RID: 28353
		// (get) Token: 0x0602C54B RID: 181579 RVA: 0x00A1D440 File Offset: 0x00A1B640
		// (set) Token: 0x0602C54C RID: 181580 RVA: 0x00A1D483 File Offset: 0x00A1B683
		public SCaughtTriggerInfo TriggerInfo
		{
			get
			{
				base.FastCheckIsValid();
				SCaughtTriggerInfo result;
				if ((result = this._TriggerInfo) == null)
				{
					result = (this._TriggerInfo = new SCaughtTriggerInfo(base.NativePtr + (IntPtr)SCaughtInfo.__PropertyOffset_0, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SCaughtTriggerInfo.StaticStruct(), base.NativePtr + (IntPtr)SCaughtInfo.__PropertyOffset_0, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006EC2 RID: 28354
		// (get) Token: 0x0602C54D RID: 181581 RVA: 0x00A1D4A4 File Offset: 0x00A1B6A4
		// (set) Token: 0x0602C54E RID: 181582 RVA: 0x00A1D4E7 File Offset: 0x00A1B6E7
		public SCaughtBindingInfo BindingInfo
		{
			get
			{
				base.FastCheckIsValid();
				SCaughtBindingInfo result;
				if ((result = this._BindingInfo) == null)
				{
					result = (this._BindingInfo = new SCaughtBindingInfo(base.NativePtr + (IntPtr)SCaughtInfo.__PropertyOffset_1, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SCaughtBindingInfo.StaticStruct(), base.NativePtr + (IntPtr)SCaughtInfo.__PropertyOffset_1, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0602C54F RID: 181583 RVA: 0x00A1D508 File Offset: 0x00A1B708
		public SCaughtInfo()
		{
		}

		// Token: 0x0602C550 RID: 181584 RVA: 0x00A1D510 File Offset: 0x00A1B710
		public SCaughtInfo(SCaughtTriggerInfo TriggerInfo, SCaughtBindingInfo BindingInfo)
		{
			this.TriggerInfo = TriggerInfo;
			this.BindingInfo = BindingInfo;
		}

		// Token: 0x0602C551 RID: 181585 RVA: 0x00A1D526 File Offset: 0x00A1B726
		protected override IntPtr GetUStructPtr()
		{
			return SCaughtInfo.StaticStruct();
		}

		// Token: 0x0602C552 RID: 181586 RVA: 0x00A1D532 File Offset: 0x00A1B732
		[NullableContext(2)]
		public SCaughtInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602C553 RID: 181587 RVA: 0x00A1D53C File Offset: 0x00A1B73C
		public SCaughtInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602C554 RID: 181588 RVA: 0x00A1D547 File Offset: 0x00A1B747
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SCaughtInfo(Pointer, false, true);
		}

		// Token: 0x0602C555 RID: 181589 RVA: 0x00A1D551 File Offset: 0x00A1B751
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SCaughtInfo(Pointer, MemoryOwner);
		}

		// Token: 0x040175FE RID: 95742
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SCaughtInfo.SCaughtInfo";

		// Token: 0x040175FF RID: 95743
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04017600 RID: 95744
		internal static int __PropertyOffset_0;

		// Token: 0x04017601 RID: 95745
		[Nullable(2)]
		private SCaughtTriggerInfo _TriggerInfo;

		// Token: 0x04017602 RID: 95746
		internal static int __PropertyOffset_1;

		// Token: 0x04017603 RID: 95747
		[Nullable(2)]
		private SCaughtBindingInfo _BindingInfo;
	}
}

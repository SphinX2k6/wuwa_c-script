using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.Structure
{
	// Token: 0x020032A7 RID: 12967
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/Structure/SSpecialTagListenerInfo.SSpecialTagListenerInfo")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class SSpecialTagListenerInfo : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060209DA RID: 133594 RVA: 0x0094AFC7 File Offset: 0x009491C7
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SSpecialTagListenerInfo._ScriptStructPtr != 0) ? SSpecialTagListenerInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/Role/Common/Data/Structure/SSpecialTagListenerInfo.SSpecialTagListenerInfo", ref SSpecialTagListenerInfo._ScriptStructPtr);
		}

		// Token: 0x17004010 RID: 16400
		// (get) Token: 0x060209DB RID: 133595 RVA: 0x0094AFEB File Offset: 0x009491EB
		// (set) Token: 0x060209DC RID: 133596 RVA: 0x0094AFFF File Offset: 0x009491FF
		public unsafe FGameplayTag SpecialTagListener
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSpecialTagListenerInfo.__PropertyOffset_SpecialTagListener);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSpecialTagListenerInfo.__PropertyOffset_SpecialTagListener) = value;
			}
		}

		// Token: 0x17004011 RID: 16401
		// (get) Token: 0x060209DD RID: 133597 RVA: 0x0094B014 File Offset: 0x00949214
		// (set) Token: 0x060209DE RID: 133598 RVA: 0x0094B057 File Offset: 0x00949257
		public FGameplayTagContainer TargetTagList
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._TargetTagList) == null)
				{
					result = (this._TargetTagList = new FGameplayTagContainer(base.NativePtr + (IntPtr)SSpecialTagListenerInfo.__PropertyOffset_TargetTagList, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)SSpecialTagListenerInfo.__PropertyOffset_TargetTagList, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004012 RID: 16402
		// (get) Token: 0x060209DF RID: 133599 RVA: 0x0094B078 File Offset: 0x00949278
		// (set) Token: 0x060209E0 RID: 133600 RVA: 0x0094B0BB File Offset: 0x009492BB
		public FGameplayTagContainer ForbidTagList
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._ForbidTagList) == null)
				{
					result = (this._ForbidTagList = new FGameplayTagContainer(base.NativePtr + (IntPtr)SSpecialTagListenerInfo.__PropertyOffset_ForbidTagList, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)SSpecialTagListenerInfo.__PropertyOffset_ForbidTagList, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060209E1 RID: 133601 RVA: 0x0094B0DC File Offset: 0x009492DC
		public SSpecialTagListenerInfo()
		{
		}

		// Token: 0x060209E2 RID: 133602 RVA: 0x0094B0E4 File Offset: 0x009492E4
		protected override IntPtr GetUStructPtr()
		{
			return SSpecialTagListenerInfo.StaticStruct();
		}

		// Token: 0x060209E3 RID: 133603 RVA: 0x0094B0F0 File Offset: 0x009492F0
		[NullableContext(2)]
		public SSpecialTagListenerInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060209E4 RID: 133604 RVA: 0x0094B0FA File Offset: 0x009492FA
		public SSpecialTagListenerInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060209E5 RID: 133605 RVA: 0x0094B105 File Offset: 0x00949305
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SSpecialTagListenerInfo(Pointer, false, true);
		}

		// Token: 0x060209E6 RID: 133606 RVA: 0x0094B10F File Offset: 0x0094930F
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SSpecialTagListenerInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04011A12 RID: 72210
		public const string __ObjectPath = "/Game/Aki/Character/Role/Common/Data/Structure/SSpecialTagListenerInfo.SSpecialTagListenerInfo";

		// Token: 0x04011A13 RID: 72211
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011A14 RID: 72212
		internal static int __PropertyOffset_SpecialTagListener;

		// Token: 0x04011A15 RID: 72213
		internal static int __PropertyOffset_TargetTagList;

		// Token: 0x04011A16 RID: 72214
		[Nullable(2)]
		private FGameplayTagContainer _TargetTagList;

		// Token: 0x04011A17 RID: 72215
		internal static int __PropertyOffset_ForbidTagList;

		// Token: 0x04011A18 RID: 72216
		[Nullable(2)]
		private FGameplayTagContainer _ForbidTagList;
	}
}

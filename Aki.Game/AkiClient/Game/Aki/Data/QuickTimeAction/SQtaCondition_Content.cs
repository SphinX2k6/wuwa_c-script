using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.QuickTimeAction
{
	// Token: 0x0200317E RID: 12670
	[UnrealObjectPath("/Game/Aki/Data/QuickTimeAction/SQtaCondition_Content.SQtaCondition_Content")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 43)]
	public class SQtaCondition_Content : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601F3FF RID: 127999 RVA: 0x009299D1 File Offset: 0x00927BD1
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SQtaCondition_Content._ScriptStructPtr != 0) ? SQtaCondition_Content._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/QuickTimeAction/SQtaCondition_Content.SQtaCondition_Content", ref SQtaCondition_Content._ScriptStructPtr);
		}

		// Token: 0x1700384D RID: 14413
		// (get) Token: 0x0601F400 RID: 128000 RVA: 0x009299F5 File Offset: 0x00927BF5
		// (set) Token: 0x0601F401 RID: 128001 RVA: 0x00929A09 File Offset: 0x00927C09
		public unsafe TEnumAsByte<EQtaConditionType> ConditionType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQtaCondition_Content.__PropertyOffset_ConditionType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQtaCondition_Content.__PropertyOffset_ConditionType) = value;
			}
		}

		// Token: 0x1700384E RID: 14414
		// (get) Token: 0x0601F402 RID: 128002 RVA: 0x00929A1E File Offset: 0x00927C1E
		// (set) Token: 0x0601F403 RID: 128003 RVA: 0x00929A32 File Offset: 0x00927C32
		public unsafe TEnumAsByte<EQtaCondition_CheckInputType> InputMatchType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQtaCondition_Content.__PropertyOffset_InputMatchType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQtaCondition_Content.__PropertyOffset_InputMatchType) = value;
			}
		}

		// Token: 0x1700384F RID: 14415
		// (get) Token: 0x0601F404 RID: 128004 RVA: 0x00929A48 File Offset: 0x00927C48
		// (set) Token: 0x0601F405 RID: 128005 RVA: 0x00929A8B File Offset: 0x00927C8B
		[Nullable(1)]
		public FGameplayTagContainer Tags
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._Tags) == null)
				{
					result = (this._Tags = new FGameplayTagContainer(base.NativePtr + (IntPtr)SQtaCondition_Content.__PropertyOffset_Tags, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)SQtaCondition_Content.__PropertyOffset_Tags, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003850 RID: 14416
		// (get) Token: 0x0601F406 RID: 128006 RVA: 0x00929AAC File Offset: 0x00927CAC
		// (set) Token: 0x0601F407 RID: 128007 RVA: 0x00929ABC File Offset: 0x00927CBC
		public unsafe bool AnyTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQtaCondition_Content.__PropertyOffset_AnyTag) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQtaCondition_Content.__PropertyOffset_AnyTag) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003851 RID: 14417
		// (get) Token: 0x0601F408 RID: 128008 RVA: 0x00929ACD File Offset: 0x00927CCD
		// (set) Token: 0x0601F409 RID: 128009 RVA: 0x00929AE1 File Offset: 0x00927CE1
		public unsafe TEnumAsByte<EQtaCondition_EventName> EventName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQtaCondition_Content.__PropertyOffset_EventName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQtaCondition_Content.__PropertyOffset_EventName) = value;
			}
		}

		// Token: 0x17003852 RID: 14418
		// (get) Token: 0x0601F40A RID: 128010 RVA: 0x00929AF6 File Offset: 0x00927CF6
		// (set) Token: 0x0601F40B RID: 128011 RVA: 0x00929B06 File Offset: 0x00927D06
		public unsafe bool Reverse
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQtaCondition_Content.__PropertyOffset_Reverse) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQtaCondition_Content.__PropertyOffset_Reverse) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601F40C RID: 128012 RVA: 0x00929B17 File Offset: 0x00927D17
		public SQtaCondition_Content()
		{
		}

		// Token: 0x0601F40D RID: 128013 RVA: 0x00929B1F File Offset: 0x00927D1F
		protected override IntPtr GetUStructPtr()
		{
			return SQtaCondition_Content.StaticStruct();
		}

		// Token: 0x0601F40E RID: 128014 RVA: 0x00929B2B File Offset: 0x00927D2B
		[NullableContext(2)]
		public SQtaCondition_Content(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F40F RID: 128015 RVA: 0x00929B35 File Offset: 0x00927D35
		public SQtaCondition_Content(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F410 RID: 128016 RVA: 0x00929B40 File Offset: 0x00927D40
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SQtaCondition_Content(Pointer, false, true);
		}

		// Token: 0x0601F411 RID: 128017 RVA: 0x00929B4A File Offset: 0x00927D4A
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SQtaCondition_Content(Pointer, MemoryOwner);
		}

		// Token: 0x04010B95 RID: 68501
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Data/QuickTimeAction/SQtaCondition_Content.SQtaCondition_Content";

		// Token: 0x04010B96 RID: 68502
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010B97 RID: 68503
		internal static int __PropertyOffset_ConditionType;

		// Token: 0x04010B98 RID: 68504
		internal static int __PropertyOffset_InputMatchType;

		// Token: 0x04010B99 RID: 68505
		internal static int __PropertyOffset_Tags;

		// Token: 0x04010B9A RID: 68506
		[Nullable(2)]
		private FGameplayTagContainer _Tags;

		// Token: 0x04010B9B RID: 68507
		internal static int __PropertyOffset_AnyTag;

		// Token: 0x04010B9C RID: 68508
		internal static int __PropertyOffset_EventName;

		// Token: 0x04010B9D RID: 68509
		internal static int __PropertyOffset_Reverse;
	}
}

using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.QuickTimeAction
{
	// Token: 0x0200317D RID: 12669
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/QuickTimeAction/SQtaCondition.SQtaCondition")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class SQtaCondition : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601F3F4 RID: 127988 RVA: 0x009298F4 File Offset: 0x00927AF4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SQtaCondition._ScriptStructPtr != 0) ? SQtaCondition._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/QuickTimeAction/SQtaCondition.SQtaCondition", ref SQtaCondition._ScriptStructPtr);
		}

		// Token: 0x1700384B RID: 14411
		// (get) Token: 0x0601F3F5 RID: 127989 RVA: 0x00929918 File Offset: 0x00927B18
		// (set) Token: 0x0601F3F6 RID: 127990 RVA: 0x0092992C File Offset: 0x00927B2C
		public unsafe string Formula
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SQtaCondition.__PropertyOffset_Formula)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SQtaCondition.__PropertyOffset_Formula)), value);
			}
		}

		// Token: 0x1700384C RID: 14412
		// (get) Token: 0x0601F3F7 RID: 127991 RVA: 0x00929944 File Offset: 0x00927B44
		// (set) Token: 0x0601F3F8 RID: 127992 RVA: 0x00929987 File Offset: 0x00927B87
		public TArray<SQtaCondition_Content> Contents
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SQtaCondition_Content> result;
				if ((result = this._Contents) == null)
				{
					result = (this._Contents = new TArray<SQtaCondition_Content>(base.NativePtr + (IntPtr)SQtaCondition.__PropertyOffset_Contents, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Contents.CopyAssign(value);
			}
		}

		// Token: 0x0601F3F9 RID: 127993 RVA: 0x00929995 File Offset: 0x00927B95
		public SQtaCondition()
		{
		}

		// Token: 0x0601F3FA RID: 127994 RVA: 0x0092999D File Offset: 0x00927B9D
		protected override IntPtr GetUStructPtr()
		{
			return SQtaCondition.StaticStruct();
		}

		// Token: 0x0601F3FB RID: 127995 RVA: 0x009299A9 File Offset: 0x00927BA9
		[NullableContext(2)]
		public SQtaCondition(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F3FC RID: 127996 RVA: 0x009299B3 File Offset: 0x00927BB3
		public SQtaCondition(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F3FD RID: 127997 RVA: 0x009299BE File Offset: 0x00927BBE
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SQtaCondition(Pointer, false, true);
		}

		// Token: 0x0601F3FE RID: 127998 RVA: 0x009299C8 File Offset: 0x00927BC8
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SQtaCondition(Pointer, MemoryOwner);
		}

		// Token: 0x04010B90 RID: 68496
		public const string __ObjectPath = "/Game/Aki/Data/QuickTimeAction/SQtaCondition.SQtaCondition";

		// Token: 0x04010B91 RID: 68497
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010B92 RID: 68498
		internal static int __PropertyOffset_Formula;

		// Token: 0x04010B93 RID: 68499
		internal static int __PropertyOffset_Contents;

		// Token: 0x04010B94 RID: 68500
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SQtaCondition_Content> _Contents;
	}
}

using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.QuickTimeAction
{
	// Token: 0x02003EB0 RID: 16048
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/QuickTimeAction/SQtaCondition.SQtaCondition")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class SQtaCondition : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06028950 RID: 166224 RVA: 0x009AFCAC File Offset: 0x009ADEAC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SQtaCondition._ScriptStructPtr != 0) ? SQtaCondition._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/QuickTimeAction/SQtaCondition.SQtaCondition", ref SQtaCondition._ScriptStructPtr);
		}

		// Token: 0x17005E9B RID: 24219
		// (get) Token: 0x06028951 RID: 166225 RVA: 0x009AFCD0 File Offset: 0x009ADED0
		// (set) Token: 0x06028952 RID: 166226 RVA: 0x009AFCE4 File Offset: 0x009ADEE4
		public unsafe string Formula
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SQtaCondition.__PropertyOffset_0)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SQtaCondition.__PropertyOffset_0)), value);
			}
		}

		// Token: 0x17005E9C RID: 24220
		// (get) Token: 0x06028953 RID: 166227 RVA: 0x009AFCFC File Offset: 0x009ADEFC
		// (set) Token: 0x06028954 RID: 166228 RVA: 0x009AFD3F File Offset: 0x009ADF3F
		public TArray<SQtaCondition_Content> Contents
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SQtaCondition_Content> result;
				if ((result = this._Contents) == null)
				{
					result = (this._Contents = new TArray<SQtaCondition_Content>(base.NativePtr + (IntPtr)SQtaCondition.__PropertyOffset_1, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Contents.CopyAssign(value);
			}
		}

		// Token: 0x06028955 RID: 166229 RVA: 0x009AFD4D File Offset: 0x009ADF4D
		public SQtaCondition()
		{
		}

		// Token: 0x06028956 RID: 166230 RVA: 0x009AFD55 File Offset: 0x009ADF55
		public SQtaCondition(string Formula, TArray<SQtaCondition_Content> Contents)
		{
			this.Formula = Formula;
			this.Contents = Contents;
		}

		// Token: 0x06028957 RID: 166231 RVA: 0x009AFD6B File Offset: 0x009ADF6B
		protected override IntPtr GetUStructPtr()
		{
			return SQtaCondition.StaticStruct();
		}

		// Token: 0x06028958 RID: 166232 RVA: 0x009AFD77 File Offset: 0x009ADF77
		[NullableContext(2)]
		public SQtaCondition(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06028959 RID: 166233 RVA: 0x009AFD81 File Offset: 0x009ADF81
		public SQtaCondition(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602895A RID: 166234 RVA: 0x009AFD8C File Offset: 0x009ADF8C
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SQtaCondition(Pointer, false, true);
		}

		// Token: 0x0602895B RID: 166235 RVA: 0x009AFD96 File Offset: 0x009ADF96
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SQtaCondition(Pointer, MemoryOwner);
		}

		// Token: 0x04014B68 RID: 84840
		public const string __ObjectPath = "/Game/Aki/Data/QuickTimeAction/SQtaCondition.SQtaCondition";

		// Token: 0x04014B69 RID: 84841
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014B6A RID: 84842
		internal static int __PropertyOffset_0;

		// Token: 0x04014B6B RID: 84843
		internal static int __PropertyOffset_1;

		// Token: 0x04014B6C RID: 84844
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SQtaCondition_Content> _Contents;
	}
}

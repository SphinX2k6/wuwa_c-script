using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Condition.Struct
{
	// Token: 0x02003F9F RID: 16287
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Condition/Struct/SCondition.SCondition")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 120)]
	public class SCondition : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060299BA RID: 170426 RVA: 0x009C87F6 File Offset: 0x009C69F6
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SCondition._ScriptStructPtr != 0) ? SCondition._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Condition/Struct/SCondition.SCondition", ref SCondition._ScriptStructPtr);
		}

		// Token: 0x17006431 RID: 25649
		// (get) Token: 0x060299BB RID: 170427 RVA: 0x009C881A File Offset: 0x009C6A1A
		// (set) Token: 0x060299BC RID: 170428 RVA: 0x009C882E File Offset: 0x009C6A2E
		public unsafe FName 条件ID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCondition.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCondition.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17006432 RID: 25650
		// (get) Token: 0x060299BD RID: 170429 RVA: 0x009C8844 File Offset: 0x009C6A44
		// (set) Token: 0x060299BE RID: 170430 RVA: 0x009C8887 File Offset: 0x009C6A87
		public TMap<FName, string> 参数组
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, string> result;
				if ((result = this._参数组) == null)
				{
					result = (this._参数组 = new TMap<FName, string>(base.NativePtr + (IntPtr)SCondition.__PropertyOffset_1, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.参数组.CopyAssign(value);
			}
		}

		// Token: 0x17006433 RID: 25651
		// (get) Token: 0x060299BF RID: 170431 RVA: 0x009C8898 File Offset: 0x009C6A98
		// (set) Token: 0x060299C0 RID: 170432 RVA: 0x009C88DB File Offset: 0x009C6ADB
		public unsafe FText 描述
		{
			get
			{
				base.FastCheckIsValid();
				FText result;
				if ((result = this._描述) == null)
				{
					result = (this._描述 = new FText(base.NativePtr + (IntPtr)SCondition.__PropertyOffset_2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				FText.NativeCopy((void*)(base.NativePtr + (byte*)((IntPtr)SCondition.__PropertyOffset_2)), value.NativePtr, 1);
			}
		}

		// Token: 0x060299C1 RID: 170433 RVA: 0x009C88F6 File Offset: 0x009C6AF6
		public SCondition()
		{
		}

		// Token: 0x060299C2 RID: 170434 RVA: 0x009C88FE File Offset: 0x009C6AFE
		public SCondition(FName 条件ID, TMap<FName, string> 参数组, FText 描述)
		{
			this.条件ID = 条件ID;
			this.参数组 = 参数组;
			this.描述 = 描述;
		}

		// Token: 0x060299C3 RID: 170435 RVA: 0x009C891B File Offset: 0x009C6B1B
		protected override IntPtr GetUStructPtr()
		{
			return SCondition.StaticStruct();
		}

		// Token: 0x060299C4 RID: 170436 RVA: 0x009C8927 File Offset: 0x009C6B27
		[NullableContext(2)]
		public SCondition(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060299C5 RID: 170437 RVA: 0x009C8931 File Offset: 0x009C6B31
		public SCondition(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060299C6 RID: 170438 RVA: 0x009C893C File Offset: 0x009C6B3C
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SCondition(Pointer, false, true);
		}

		// Token: 0x060299C7 RID: 170439 RVA: 0x009C8946 File Offset: 0x009C6B46
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SCondition(Pointer, MemoryOwner);
		}

		// Token: 0x04015598 RID: 87448
		public const string __ObjectPath = "/Game/Aki/Data/Condition/Struct/SCondition.SCondition";

		// Token: 0x04015599 RID: 87449
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401559A RID: 87450
		internal static int __PropertyOffset_0;

		// Token: 0x0401559B RID: 87451
		internal static int __PropertyOffset_1;

		// Token: 0x0401559C RID: 87452
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, string> _参数组;

		// Token: 0x0401559D RID: 87453
		internal static int __PropertyOffset_2;

		// Token: 0x0401559E RID: 87454
		[Nullable(2)]
		private FText _描述;
	}
}

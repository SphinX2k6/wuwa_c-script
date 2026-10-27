using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.ConfigTable
{
	// Token: 0x02004027 RID: 16423
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/ConfigTable/ForBaseStruct.ForBaseStruct")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class ForBaseStruct : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602A202 RID: 172546 RVA: 0x009D6B70 File Offset: 0x009D4D70
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (ForBaseStruct._ScriptStructPtr != 0) ? ForBaseStruct._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/ConfigTable/ForBaseStruct.ForBaseStruct", ref ForBaseStruct._ScriptStructPtr);
		}

		// Token: 0x170066CE RID: 26318
		// (get) Token: 0x0602A203 RID: 172547 RVA: 0x009D6B94 File Offset: 0x009D4D94
		// (set) Token: 0x0602A204 RID: 172548 RVA: 0x009D6BA8 File Offset: 0x009D4DA8
		public unsafe FVector MemberVar_0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ForBaseStruct.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ForBaseStruct.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x170066CF RID: 26319
		// (get) Token: 0x0602A205 RID: 172549 RVA: 0x009D6BBD File Offset: 0x009D4DBD
		// (set) Token: 0x0602A206 RID: 172550 RVA: 0x009D6BD1 File Offset: 0x009D4DD1
		public unsafe FRotator MemberVar_2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ForBaseStruct.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ForBaseStruct.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x170066D0 RID: 26320
		// (get) Token: 0x0602A207 RID: 172551 RVA: 0x009D6BE8 File Offset: 0x009D4DE8
		// (set) Token: 0x0602A208 RID: 172552 RVA: 0x009D6C2B File Offset: 0x009D4E2B
		public FGameplayAttributeData MemberVar_4
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._MemberVar_4) == null)
				{
					result = (this._MemberVar_4 = new FGameplayAttributeData(base.NativePtr + (IntPtr)ForBaseStruct.__PropertyOffset_2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)ForBaseStruct.__PropertyOffset_2, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0602A209 RID: 172553 RVA: 0x009D6C4C File Offset: 0x009D4E4C
		public ForBaseStruct()
		{
		}

		// Token: 0x0602A20A RID: 172554 RVA: 0x009D6C54 File Offset: 0x009D4E54
		public ForBaseStruct(FVector MemberVar_0, FRotator MemberVar_2, FGameplayAttributeData MemberVar_4)
		{
			this.MemberVar_0 = MemberVar_0;
			this.MemberVar_2 = MemberVar_2;
			this.MemberVar_4 = MemberVar_4;
		}

		// Token: 0x0602A20B RID: 172555 RVA: 0x009D6C71 File Offset: 0x009D4E71
		protected override IntPtr GetUStructPtr()
		{
			return ForBaseStruct.StaticStruct();
		}

		// Token: 0x0602A20C RID: 172556 RVA: 0x009D6C7D File Offset: 0x009D4E7D
		[NullableContext(2)]
		public ForBaseStruct(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602A20D RID: 172557 RVA: 0x009D6C87 File Offset: 0x009D4E87
		public ForBaseStruct(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602A20E RID: 172558 RVA: 0x009D6C92 File Offset: 0x009D4E92
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new ForBaseStruct(Pointer, false, true);
		}

		// Token: 0x0602A20F RID: 172559 RVA: 0x009D6C9C File Offset: 0x009D4E9C
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new ForBaseStruct(Pointer, MemoryOwner);
		}

		// Token: 0x04015B29 RID: 88873
		public const string __ObjectPath = "/Game/Aki/ConfigTable/ForBaseStruct.ForBaseStruct";

		// Token: 0x04015B2A RID: 88874
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04015B2B RID: 88875
		internal static int __PropertyOffset_0;

		// Token: 0x04015B2C RID: 88876
		internal static int __PropertyOffset_1;

		// Token: 0x04015B2D RID: 88877
		internal static int __PropertyOffset_2;

		// Token: 0x04015B2E RID: 88878
		[Nullable(2)]
		private FGameplayAttributeData _MemberVar_4;
	}
}

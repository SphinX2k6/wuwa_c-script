using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Config
{
	// Token: 0x02004026 RID: 16422
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Config/FC_LoadingTipsText.FC_LoadingTipsText")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FC_LoadingTipsText : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602A1F0 RID: 172528 RVA: 0x009D6A2E File Offset: 0x009D4C2E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FC_LoadingTipsText._ScriptStructPtr != 0) ? FC_LoadingTipsText._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Config/FC_LoadingTipsText.FC_LoadingTipsText", ref FC_LoadingTipsText._ScriptStructPtr);
		}

		// Token: 0x170066C9 RID: 26313
		// (get) Token: 0x0602A1F1 RID: 172529 RVA: 0x009D6A52 File Offset: 0x009D4C52
		// (set) Token: 0x0602A1F2 RID: 172530 RVA: 0x009D6A62 File Offset: 0x009D4C62
		public unsafe int KuroRowId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FC_LoadingTipsText.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FC_LoadingTipsText.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x170066CA RID: 26314
		// (get) Token: 0x0602A1F3 RID: 172531 RVA: 0x009D6A73 File Offset: 0x009D4C73
		// (set) Token: 0x0602A1F4 RID: 172532 RVA: 0x009D6A83 File Offset: 0x009D4C83
		public unsafe int Id
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FC_LoadingTipsText.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FC_LoadingTipsText.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x170066CB RID: 26315
		// (get) Token: 0x0602A1F5 RID: 172533 RVA: 0x009D6A94 File Offset: 0x009D4C94
		// (set) Token: 0x0602A1F6 RID: 172534 RVA: 0x009D6AA4 File Offset: 0x009D4CA4
		public unsafe int Weight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FC_LoadingTipsText.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FC_LoadingTipsText.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x170066CC RID: 26316
		// (get) Token: 0x0602A1F7 RID: 172535 RVA: 0x009D6AB5 File Offset: 0x009D4CB5
		// (set) Token: 0x0602A1F8 RID: 172536 RVA: 0x009D6AC9 File Offset: 0x009D4CC9
		public unsafe string TipsText
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FC_LoadingTipsText.__PropertyOffset_3)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FC_LoadingTipsText.__PropertyOffset_3)), value);
			}
		}

		// Token: 0x170066CD RID: 26317
		// (get) Token: 0x0602A1F9 RID: 172537 RVA: 0x009D6ADE File Offset: 0x009D4CDE
		// (set) Token: 0x0602A1FA RID: 172538 RVA: 0x009D6AF2 File Offset: 0x009D4CF2
		public unsafe string Title
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FC_LoadingTipsText.__PropertyOffset_4)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FC_LoadingTipsText.__PropertyOffset_4)), value);
			}
		}

		// Token: 0x0602A1FB RID: 172539 RVA: 0x009D6B07 File Offset: 0x009D4D07
		public FC_LoadingTipsText()
		{
		}

		// Token: 0x0602A1FC RID: 172540 RVA: 0x009D6B0F File Offset: 0x009D4D0F
		public FC_LoadingTipsText(int KuroRowId, int Id, int Weight, string TipsText, string Title)
		{
			this.KuroRowId = KuroRowId;
			this.Id = Id;
			this.Weight = Weight;
			this.TipsText = TipsText;
			this.Title = Title;
		}

		// Token: 0x0602A1FD RID: 172541 RVA: 0x009D6B3C File Offset: 0x009D4D3C
		protected override IntPtr GetUStructPtr()
		{
			return FC_LoadingTipsText.StaticStruct();
		}

		// Token: 0x0602A1FE RID: 172542 RVA: 0x009D6B48 File Offset: 0x009D4D48
		[NullableContext(2)]
		public FC_LoadingTipsText(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602A1FF RID: 172543 RVA: 0x009D6B52 File Offset: 0x009D4D52
		public FC_LoadingTipsText(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602A200 RID: 172544 RVA: 0x009D6B5D File Offset: 0x009D4D5D
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FC_LoadingTipsText(Pointer, false, true);
		}

		// Token: 0x0602A201 RID: 172545 RVA: 0x009D6B67 File Offset: 0x009D4D67
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FC_LoadingTipsText(Pointer, MemoryOwner);
		}

		// Token: 0x04015B22 RID: 88866
		public const string __ObjectPath = "/Game/Aki/Config/FC_LoadingTipsText.FC_LoadingTipsText";

		// Token: 0x04015B23 RID: 88867
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04015B24 RID: 88868
		internal static int __PropertyOffset_0;

		// Token: 0x04015B25 RID: 88869
		internal static int __PropertyOffset_1;

		// Token: 0x04015B26 RID: 88870
		internal static int __PropertyOffset_2;

		// Token: 0x04015B27 RID: 88871
		internal static int __PropertyOffset_3;

		// Token: 0x04015B28 RID: 88872
		internal static int __PropertyOffset_4;
	}
}

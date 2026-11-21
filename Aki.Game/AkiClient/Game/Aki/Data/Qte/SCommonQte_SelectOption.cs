using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Qte
{
	// Token: 0x020031A3 RID: 12707
	[UnrealObjectPath("/Game/Aki/Data/Qte/SCommonQte_SelectOption.SCommonQte_SelectOption")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 88)]
	public class SCommonQte_SelectOption : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601F5D7 RID: 128471 RVA: 0x0092C289 File Offset: 0x0092A489
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SCommonQte_SelectOption._ScriptStructPtr != 0) ? SCommonQte_SelectOption._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Qte/SCommonQte_SelectOption.SCommonQte_SelectOption", ref SCommonQte_SelectOption._ScriptStructPtr);
		}

		// Token: 0x170038E8 RID: 14568
		// (get) Token: 0x0601F5D8 RID: 128472 RVA: 0x0092C2AD File Offset: 0x0092A4AD
		// (set) Token: 0x0601F5D9 RID: 128473 RVA: 0x0092C2C1 File Offset: 0x0092A4C1
		public unsafe TEnumAsByte<ECommonQteViewType_SelectOption> ViewType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_SelectOption.__PropertyOffset_ViewType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_SelectOption.__PropertyOffset_ViewType) = value;
			}
		}

		// Token: 0x170038E9 RID: 14569
		// (get) Token: 0x0601F5DA RID: 128474 RVA: 0x0092C2D8 File Offset: 0x0092A4D8
		// (set) Token: 0x0601F5DB RID: 128475 RVA: 0x0092C31B File Offset: 0x0092A51B
		[Nullable(1)]
		public TArray<SCommonQteButton> UIConfigList
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<SCommonQteButton> result;
				if ((result = this._UIConfigList) == null)
				{
					result = (this._UIConfigList = new TArray<SCommonQteButton>(base.NativePtr + (IntPtr)SCommonQte_SelectOption.__PropertyOffset_UIConfigList, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.UIConfigList.CopyAssign(value);
			}
		}

		// Token: 0x170038EA RID: 14570
		// (get) Token: 0x0601F5DC RID: 128476 RVA: 0x0092C329 File Offset: 0x0092A529
		// (set) Token: 0x0601F5DD RID: 128477 RVA: 0x0092C339 File Offset: 0x0092A539
		public unsafe int DefaultOption
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_SelectOption.__PropertyOffset_DefaultOption);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_SelectOption.__PropertyOffset_DefaultOption) = value;
			}
		}

		// Token: 0x170038EB RID: 14571
		// (get) Token: 0x0601F5DE RID: 128478 RVA: 0x0092C34A File Offset: 0x0092A54A
		// (set) Token: 0x0601F5DF RID: 128479 RVA: 0x0092C35A File Offset: 0x0092A55A
		public unsafe bool IsAttachToActor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_SelectOption.__PropertyOffset_IsAttachToActor) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_SelectOption.__PropertyOffset_IsAttachToActor) = (value ? 1 : 0);
			}
		}

		// Token: 0x170038EC RID: 14572
		// (get) Token: 0x0601F5E0 RID: 128480 RVA: 0x0092C36B File Offset: 0x0092A56B
		// (set) Token: 0x0601F5E1 RID: 128481 RVA: 0x0092C37F File Offset: 0x0092A57F
		public unsafe SCommonQte_Attach AttachConfig
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_SelectOption.__PropertyOffset_AttachConfig);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_SelectOption.__PropertyOffset_AttachConfig) = value;
			}
		}

		// Token: 0x0601F5E2 RID: 128482 RVA: 0x0092C394 File Offset: 0x0092A594
		public SCommonQte_SelectOption()
		{
		}

		// Token: 0x0601F5E3 RID: 128483 RVA: 0x0092C39C File Offset: 0x0092A59C
		protected override IntPtr GetUStructPtr()
		{
			return SCommonQte_SelectOption.StaticStruct();
		}

		// Token: 0x0601F5E4 RID: 128484 RVA: 0x0092C3A8 File Offset: 0x0092A5A8
		[NullableContext(2)]
		public SCommonQte_SelectOption(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F5E5 RID: 128485 RVA: 0x0092C3B2 File Offset: 0x0092A5B2
		public SCommonQte_SelectOption(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F5E6 RID: 128486 RVA: 0x0092C3BD File Offset: 0x0092A5BD
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SCommonQte_SelectOption(Pointer, false, true);
		}

		// Token: 0x0601F5E7 RID: 128487 RVA: 0x0092C3C7 File Offset: 0x0092A5C7
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SCommonQte_SelectOption(Pointer, MemoryOwner);
		}

		// Token: 0x04010CFD RID: 68861
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Data/Qte/SCommonQte_SelectOption.SCommonQte_SelectOption";

		// Token: 0x04010CFE RID: 68862
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010CFF RID: 68863
		internal static int __PropertyOffset_ViewType;

		// Token: 0x04010D00 RID: 68864
		internal static int __PropertyOffset_UIConfigList;

		// Token: 0x04010D01 RID: 68865
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SCommonQteButton> _UIConfigList;

		// Token: 0x04010D02 RID: 68866
		internal static int __PropertyOffset_DefaultOption;

		// Token: 0x04010D03 RID: 68867
		internal static int __PropertyOffset_IsAttachToActor;

		// Token: 0x04010D04 RID: 68868
		internal static int __PropertyOffset_AttachConfig;
	}
}

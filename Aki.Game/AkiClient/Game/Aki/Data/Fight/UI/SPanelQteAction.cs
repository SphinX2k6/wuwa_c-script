using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Fight.UI
{
	// Token: 0x02003F57 RID: 16215
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Fight/UI/SPanelQteAction.SPanelQteAction")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 72)]
	public class SPanelQteAction : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060294AC RID: 169132 RVA: 0x009C0814 File Offset: 0x009BEA14
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SPanelQteAction._ScriptStructPtr != 0) ? SPanelQteAction._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Fight/UI/SPanelQteAction.SPanelQteAction", ref SPanelQteAction._ScriptStructPtr);
		}

		// Token: 0x1700627A RID: 25210
		// (get) Token: 0x060294AD RID: 169133 RVA: 0x009C0838 File Offset: 0x009BEA38
		// (set) Token: 0x060294AE RID: 169134 RVA: 0x009C0848 File Offset: 0x009BEA48
		public unsafe int Target
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPanelQteAction.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPanelQteAction.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x1700627B RID: 25211
		// (get) Token: 0x060294AF RID: 169135 RVA: 0x009C085C File Offset: 0x009BEA5C
		// (set) Token: 0x060294B0 RID: 169136 RVA: 0x009C089F File Offset: 0x009BEA9F
		public TArray<FGameplayTag> AddTags
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FGameplayTag> result;
				if ((result = this._AddTags) == null)
				{
					result = (this._AddTags = new TArray<FGameplayTag>(base.NativePtr + (IntPtr)SPanelQteAction.__PropertyOffset_1, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.AddTags.CopyAssign(value);
			}
		}

		// Token: 0x1700627C RID: 25212
		// (get) Token: 0x060294B1 RID: 169137 RVA: 0x009C08B0 File Offset: 0x009BEAB0
		// (set) Token: 0x060294B2 RID: 169138 RVA: 0x009C08F3 File Offset: 0x009BEAF3
		public TArray<FGameplayTag> RemoveTags
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FGameplayTag> result;
				if ((result = this._RemoveTags) == null)
				{
					result = (this._RemoveTags = new TArray<FGameplayTag>(base.NativePtr + (IntPtr)SPanelQteAction.__PropertyOffset_2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.RemoveTags.CopyAssign(value);
			}
		}

		// Token: 0x1700627D RID: 25213
		// (get) Token: 0x060294B3 RID: 169139 RVA: 0x009C0904 File Offset: 0x009BEB04
		// (set) Token: 0x060294B4 RID: 169140 RVA: 0x009C0947 File Offset: 0x009BEB47
		public TArray<long> AddBuffs
		{
			get
			{
				base.FastCheckIsValid();
				TArray<long> result;
				if ((result = this._AddBuffs) == null)
				{
					result = (this._AddBuffs = new TArray<long>(base.NativePtr + (IntPtr)SPanelQteAction.__PropertyOffset_3, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.AddBuffs.CopyAssign(value);
			}
		}

		// Token: 0x1700627E RID: 25214
		// (get) Token: 0x060294B5 RID: 169141 RVA: 0x009C0958 File Offset: 0x009BEB58
		// (set) Token: 0x060294B6 RID: 169142 RVA: 0x009C099B File Offset: 0x009BEB9B
		[Nullable(new byte[]
		{
			1,
			0
		})]
		public TArray<TEnumAsByte<EPanelQteCustomAction>> CustomActions
		{
			[return: Nullable(new byte[]
			{
				1,
				0
			})]
			get
			{
				base.FastCheckIsValid();
				TArray<TEnumAsByte<EPanelQteCustomAction>> result;
				if ((result = this._CustomActions) == null)
				{
					result = (this._CustomActions = new TArray<TEnumAsByte<EPanelQteCustomAction>>(base.NativePtr + (IntPtr)SPanelQteAction.__PropertyOffset_4, base.MemoryOwner ?? this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0
			})]
			set
			{
				this.CustomActions.CopyAssign(value);
			}
		}

		// Token: 0x060294B7 RID: 169143 RVA: 0x009C09A9 File Offset: 0x009BEBA9
		public SPanelQteAction()
		{
		}

		// Token: 0x060294B8 RID: 169144 RVA: 0x009C09B1 File Offset: 0x009BEBB1
		public SPanelQteAction(int Target, TArray<FGameplayTag> AddTags, TArray<FGameplayTag> RemoveTags, TArray<long> AddBuffs, [Nullable(new byte[]
		{
			1,
			0
		})] TArray<TEnumAsByte<EPanelQteCustomAction>> CustomActions)
		{
			this.Target = Target;
			this.AddTags = AddTags;
			this.RemoveTags = RemoveTags;
			this.AddBuffs = AddBuffs;
			this.CustomActions = CustomActions;
		}

		// Token: 0x060294B9 RID: 169145 RVA: 0x009C09DE File Offset: 0x009BEBDE
		protected override IntPtr GetUStructPtr()
		{
			return SPanelQteAction.StaticStruct();
		}

		// Token: 0x060294BA RID: 169146 RVA: 0x009C09EA File Offset: 0x009BEBEA
		[NullableContext(2)]
		public SPanelQteAction(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060294BB RID: 169147 RVA: 0x009C09F4 File Offset: 0x009BEBF4
		public SPanelQteAction(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060294BC RID: 169148 RVA: 0x009C09FF File Offset: 0x009BEBFF
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SPanelQteAction(Pointer, false, true);
		}

		// Token: 0x060294BD RID: 169149 RVA: 0x009C0A09 File Offset: 0x009BEC09
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SPanelQteAction(Pointer, MemoryOwner);
		}

		// Token: 0x0401527B RID: 86651
		public const string __ObjectPath = "/Game/Aki/Data/Fight/UI/SPanelQteAction.SPanelQteAction";

		// Token: 0x0401527C RID: 86652
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401527D RID: 86653
		internal static int __PropertyOffset_0;

		// Token: 0x0401527E RID: 86654
		internal static int __PropertyOffset_1;

		// Token: 0x0401527F RID: 86655
		[Nullable(2)]
		private TArray<FGameplayTag> _AddTags;

		// Token: 0x04015280 RID: 86656
		internal static int __PropertyOffset_2;

		// Token: 0x04015281 RID: 86657
		[Nullable(2)]
		private TArray<FGameplayTag> _RemoveTags;

		// Token: 0x04015282 RID: 86658
		internal static int __PropertyOffset_3;

		// Token: 0x04015283 RID: 86659
		[Nullable(2)]
		private TArray<long> _AddBuffs;

		// Token: 0x04015284 RID: 86660
		internal static int __PropertyOffset_4;

		// Token: 0x04015285 RID: 86661
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TArray<TEnumAsByte<EPanelQteCustomAction>> _CustomActions;
	}
}

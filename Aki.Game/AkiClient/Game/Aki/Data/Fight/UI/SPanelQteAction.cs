using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Fight.UI
{
	// Token: 0x020031FC RID: 12796
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Fight/UI/SPanelQteAction.SPanelQteAction")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 72)]
	public class SPanelQteAction : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601FD76 RID: 130422 RVA: 0x009371B1 File Offset: 0x009353B1
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SPanelQteAction._ScriptStructPtr != 0) ? SPanelQteAction._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Fight/UI/SPanelQteAction.SPanelQteAction", ref SPanelQteAction._ScriptStructPtr);
		}

		// Token: 0x17003BC3 RID: 15299
		// (get) Token: 0x0601FD77 RID: 130423 RVA: 0x009371D5 File Offset: 0x009353D5
		// (set) Token: 0x0601FD78 RID: 130424 RVA: 0x009371E5 File Offset: 0x009353E5
		public unsafe int Target
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPanelQteAction.__PropertyOffset_Target);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPanelQteAction.__PropertyOffset_Target) = value;
			}
		}

		// Token: 0x17003BC4 RID: 15300
		// (get) Token: 0x0601FD79 RID: 130425 RVA: 0x009371F8 File Offset: 0x009353F8
		// (set) Token: 0x0601FD7A RID: 130426 RVA: 0x0093723B File Offset: 0x0093543B
		public TArray<FGameplayTag> AddTags
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FGameplayTag> result;
				if ((result = this._AddTags) == null)
				{
					result = (this._AddTags = new TArray<FGameplayTag>(base.NativePtr + (IntPtr)SPanelQteAction.__PropertyOffset_AddTags, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.AddTags.CopyAssign(value);
			}
		}

		// Token: 0x17003BC5 RID: 15301
		// (get) Token: 0x0601FD7B RID: 130427 RVA: 0x0093724C File Offset: 0x0093544C
		// (set) Token: 0x0601FD7C RID: 130428 RVA: 0x0093728F File Offset: 0x0093548F
		public TArray<FGameplayTag> RemoveTags
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FGameplayTag> result;
				if ((result = this._RemoveTags) == null)
				{
					result = (this._RemoveTags = new TArray<FGameplayTag>(base.NativePtr + (IntPtr)SPanelQteAction.__PropertyOffset_RemoveTags, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.RemoveTags.CopyAssign(value);
			}
		}

		// Token: 0x17003BC6 RID: 15302
		// (get) Token: 0x0601FD7D RID: 130429 RVA: 0x009372A0 File Offset: 0x009354A0
		// (set) Token: 0x0601FD7E RID: 130430 RVA: 0x009372E3 File Offset: 0x009354E3
		public TArray<long> AddBuffs
		{
			get
			{
				base.FastCheckIsValid();
				TArray<long> result;
				if ((result = this._AddBuffs) == null)
				{
					result = (this._AddBuffs = new TArray<long>(base.NativePtr + (IntPtr)SPanelQteAction.__PropertyOffset_AddBuffs, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.AddBuffs.CopyAssign(value);
			}
		}

		// Token: 0x17003BC7 RID: 15303
		// (get) Token: 0x0601FD7F RID: 130431 RVA: 0x009372F4 File Offset: 0x009354F4
		// (set) Token: 0x0601FD80 RID: 130432 RVA: 0x00937337 File Offset: 0x00935537
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
					result = (this._CustomActions = new TArray<TEnumAsByte<EPanelQteCustomAction>>(base.NativePtr + (IntPtr)SPanelQteAction.__PropertyOffset_CustomActions, base.MemoryOwner ?? this));
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

		// Token: 0x0601FD81 RID: 130433 RVA: 0x00937345 File Offset: 0x00935545
		public SPanelQteAction()
		{
		}

		// Token: 0x0601FD82 RID: 130434 RVA: 0x0093734D File Offset: 0x0093554D
		protected override IntPtr GetUStructPtr()
		{
			return SPanelQteAction.StaticStruct();
		}

		// Token: 0x0601FD83 RID: 130435 RVA: 0x00937359 File Offset: 0x00935559
		[NullableContext(2)]
		public SPanelQteAction(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601FD84 RID: 130436 RVA: 0x00937363 File Offset: 0x00935563
		public SPanelQteAction(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601FD85 RID: 130437 RVA: 0x0093736E File Offset: 0x0093556E
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SPanelQteAction(Pointer, false, true);
		}

		// Token: 0x0601FD86 RID: 130438 RVA: 0x00937378 File Offset: 0x00935578
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SPanelQteAction(Pointer, MemoryOwner);
		}

		// Token: 0x0401118F RID: 70031
		public const string __ObjectPath = "/Game/Aki/Data/Fight/UI/SPanelQteAction.SPanelQteAction";

		// Token: 0x04011190 RID: 70032
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011191 RID: 70033
		internal static int __PropertyOffset_Target;

		// Token: 0x04011192 RID: 70034
		internal static int __PropertyOffset_AddTags;

		// Token: 0x04011193 RID: 70035
		[Nullable(2)]
		private TArray<FGameplayTag> _AddTags;

		// Token: 0x04011194 RID: 70036
		internal static int __PropertyOffset_RemoveTags;

		// Token: 0x04011195 RID: 70037
		[Nullable(2)]
		private TArray<FGameplayTag> _RemoveTags;

		// Token: 0x04011196 RID: 70038
		internal static int __PropertyOffset_AddBuffs;

		// Token: 0x04011197 RID: 70039
		[Nullable(2)]
		private TArray<long> _AddBuffs;

		// Token: 0x04011198 RID: 70040
		internal static int __PropertyOffset_CustomActions;

		// Token: 0x04011199 RID: 70041
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TArray<TEnumAsByte<EPanelQteCustomAction>> _CustomActions;
	}
}

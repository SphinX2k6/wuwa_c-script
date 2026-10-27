using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001BFC RID: 7164
[NullableContext(1)]
[Nullable(0)]
public class Formation2D : FormationFlavorViewBase
{
	// Token: 0x0600D5BD RID: 54717 RVA: 0x00315604 File Offset: 0x00313804
	public Formation2D(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x1700119F RID: 4511
	// (get) Token: 0x0600D5BE RID: 54718 RVA: 0x00315681 File Offset: 0x00313881
	protected virtual SlotPresenter2D Presenter { [PreserveBaseOverrides] get; } = new SlotPresenter2D();

	// Token: 0x170011A0 RID: 4512
	// (get) Token: 0x0600D5BF RID: 54719 RVA: 0x00315689 File Offset: 0x00313889
	protected override FormationActionKeys FormationActionKeys { get; } = new FormationActionKeys
	{
		PresetForm = 14,
		EditFormName = 15
	};

	// Token: 0x170011A1 RID: 4513
	// (get) Token: 0x0600D5C0 RID: 54720 RVA: 0x00315691 File Offset: 0x00313891
	protected override FormationViewKeys Keys { get; } = new FormationViewKeys
	{
		Close = 7,
		Tab = 0,
		Confirm = 5,
		QuickSelect = 8,
		Loading = 9,
		ConfirmText = 6,
		DescToggleItem = new int?(16)
	};

	// Token: 0x0600D5C1 RID: 54721 RVA: 0x0031569C File Offset: 0x0031389C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 17;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIExtendToggle));
		this.ComponentRegisterInfos = list;
		num2 = 5;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(5, new Action(this.OnClickConfirm));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(7, new Action(this.OnClickClose));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(8, new Action(this.OnClickQuickSelect));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(14, new Action(base.OnClickPresetForm));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(15, new Action(base.OnClickEditFormName));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600D5C2 RID: 54722 RVA: 0x003159CC File Offset: 0x00313BCC
	protected override UniTask CreateAllSlotsAsync()
	{
		Formation2D.<CreateAllSlotsAsync>d__12 <CreateAllSlotsAsync>d__;
		<CreateAllSlotsAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateAllSlotsAsync>d__.<>4__this = this;
		<CreateAllSlotsAsync>d__.<>1__state = -1;
		<CreateAllSlotsAsync>d__.<>t__builder.Start<Formation2D.<CreateAllSlotsAsync>d__12>(ref <CreateAllSlotsAsync>d__);
		return <CreateAllSlotsAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600D5C3 RID: 54723 RVA: 0x00315A0F File Offset: 0x00313C0F
	protected override void OnBeforeShow()
	{
		base.OnBeforeShow();
		GameSettingsDeviceRender.Instance.TemporaryDisableFrameGeneration("Formation2D");
	}

	// Token: 0x0600D5C4 RID: 54724 RVA: 0x00315A26 File Offset: 0x00313C26
	protected override void OnAfterHide()
	{
		GameSettingsDeviceRender.Instance.CancelTemporaryDisableFrameGeneration("Formation2D");
		base.OnAfterHide();
	}

	// Token: 0x0600D5C5 RID: 54725 RVA: 0x00315A3D File Offset: 0x00313C3D
	protected override void OnAddEventListener()
	{
		if (GameModeModel.Instance.IsMulti)
		{
			EventSystem.Instance.Add(EEventName.OnRefreshPlayerPing, new Action<int, ENetPingState>(this.OnRefreshPlayerPing));
		}
	}

	// Token: 0x0600D5C6 RID: 54726 RVA: 0x00315A67 File Offset: 0x00313C67
	protected override void OnRemoveEventListener()
	{
		if (EventSystem.Instance.Has(EEventName.OnRefreshPlayerPing, new Action<int, ENetPingState>(this.OnRefreshPlayerPing)))
		{
			EventSystem.Instance.Remove(EEventName.OnRefreshPlayerPing, new Action<int, ENetPingState>(this.OnRefreshPlayerPing));
		}
	}

	// Token: 0x0600D5C7 RID: 54727 RVA: 0x00315AA2 File Offset: 0x00313CA2
	private void ExchangeRoleCallBack(int dropPosition, int fromPosition, int fromRoleId, int dropRoleId)
	{
		FormationModel instance = FormationModel.Instance;
		instance.SetEditingRoleId(this.EditFormationId, dropPosition, fromRoleId, true);
		instance.SetEditingRoleId(this.EditFormationId, fromPosition, dropRoleId, true);
		this.OnRefreshRoleView(new int[]
		{
			dropPosition,
			fromPosition
		});
	}

	// Token: 0x0600D5C8 RID: 54728 RVA: 0x00315AE0 File Offset: 0x00313CE0
	private void OnRefreshPlayerPing(int playerId, ENetPingState ping)
	{
		foreach (FormationRoleSlot formationRoleSlot in this.Presenter.RoleSlots)
		{
			int? player = formationRoleSlot.GetPlayer();
			if (player.GetValueOrDefault() == playerId & player != null)
			{
				formationRoleSlot.RefreshPing(ping);
			}
		}
	}

	// Token: 0x0600D5C9 RID: 54729 RVA: 0x00315B58 File Offset: 0x00313D58
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
	{
		int num = int.Parse(configParams[0]);
		if (num != 0)
		{
			FormationRoleSlot formationRoleSlot = this.Presenter.RoleSlots[num - 1];
			UUIItem uuiitem = (formationRoleSlot != null) ? formationRoleSlot.GetRootItem() : null;
			if (uuiitem != null)
			{
				return new UUIItem[]
				{
					uuiitem,
					uuiitem
				};
			}
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Guide;
		ELogAuthor author = ELogAuthor.SYB;
		string message = "[Formation2D] 聚焦引导 extraParam 项配置有误";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("configParams", configParams);
		instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		return null;
	}

	// Token: 0x0200819D RID: 33181
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x0402A4AA RID: 173226
		TabComponent,
		// Token: 0x0402A4AB RID: 173227
		TeamRoleContentItem,
		// Token: 0x0402A4AC RID: 173228
		TeamRoleSlot1,
		// Token: 0x0402A4AD RID: 173229
		TeamRoleSlot2,
		// Token: 0x0402A4AE RID: 173230
		TeamRoleSlot3,
		// Token: 0x0402A4AF RID: 173231
		ConfirmButton,
		// Token: 0x0402A4B0 RID: 173232
		ConfirmText,
		// Token: 0x0402A4B1 RID: 173233
		CloseButton,
		// Token: 0x0402A4B2 RID: 173234
		QuickSelectButton,
		// Token: 0x0402A4B3 RID: 173235
		LoadingItem,
		// Token: 0x0402A4B4 RID: 173236
		DisableClickMask,
		// Token: 0x0402A4B5 RID: 173237
		DragItem,
		// Token: 0x0402A4B6 RID: 173238
		DragRoleItem,
		// Token: 0x0402A4B7 RID: 173239
		TeamNameText,
		// Token: 0x0402A4B8 RID: 173240
		BtnPresetForm,
		// Token: 0x0402A4B9 RID: 173241
		BtnEditFormName,
		// Token: 0x0402A4BA RID: 173242
		DescToggleItem
	}
}

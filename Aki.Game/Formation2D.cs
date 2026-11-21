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

// Token: 0x020010BB RID: 4283
[NullableContext(1)]
[Nullable(0)]
public class Formation2D : FormationFlavorViewBase
{
	// Token: 0x0600A9D0 RID: 43472 RVA: 0x00320900 File Offset: 0x0031EB00
	public Formation2D(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x170011C4 RID: 4548
	// (get) Token: 0x0600A9D1 RID: 43473 RVA: 0x0032097D File Offset: 0x0031EB7D
	protected virtual SlotPresenter2D Presenter { [PreserveBaseOverrides] get; } = new SlotPresenter2D();

	// Token: 0x170011C5 RID: 4549
	// (get) Token: 0x0600A9D2 RID: 43474 RVA: 0x00320985 File Offset: 0x0031EB85
	protected override FormationActionKeys FormationActionKeys { get; } = new FormationActionKeys
	{
		PresetForm = 14,
		EditFormName = 15
	};

	// Token: 0x170011C6 RID: 4550
	// (get) Token: 0x0600A9D3 RID: 43475 RVA: 0x0032098D File Offset: 0x0031EB8D
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

	// Token: 0x0600A9D4 RID: 43476 RVA: 0x00320998 File Offset: 0x0031EB98
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

	// Token: 0x0600A9D5 RID: 43477 RVA: 0x00320CC8 File Offset: 0x0031EEC8
	protected override UniTask CreateAllSlotsAsync()
	{
		Formation2D.<CreateAllSlotsAsync>d__12 <CreateAllSlotsAsync>d__;
		<CreateAllSlotsAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateAllSlotsAsync>d__.<>4__this = this;
		<CreateAllSlotsAsync>d__.<>1__state = -1;
		<CreateAllSlotsAsync>d__.<>t__builder.Start<Formation2D.<CreateAllSlotsAsync>d__12>(ref <CreateAllSlotsAsync>d__);
		return <CreateAllSlotsAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600A9D6 RID: 43478 RVA: 0x00320D0B File Offset: 0x0031EF0B
	protected override void OnBeforeShow()
	{
		base.OnBeforeShow();
		GameSettingsDeviceRender.Instance.TemporaryDisableFrameGeneration("Formation2D");
	}

	// Token: 0x0600A9D7 RID: 43479 RVA: 0x00320D22 File Offset: 0x0031EF22
	protected override void OnAfterHide()
	{
		GameSettingsDeviceRender.Instance.CancelTemporaryDisableFrameGeneration("Formation2D");
		base.OnAfterHide();
	}

	// Token: 0x0600A9D8 RID: 43480 RVA: 0x00320D39 File Offset: 0x0031EF39
	protected override void OnAddEventListener()
	{
		if (GameModeModel.Instance.IsMulti)
		{
			EventSystem.Instance.Add(EEventName.OnRefreshPlayerPing, new Action<int, ENetPingState>(this.OnRefreshPlayerPing));
		}
	}

	// Token: 0x0600A9D9 RID: 43481 RVA: 0x00320D63 File Offset: 0x0031EF63
	protected override void OnRemoveEventListener()
	{
		if (EventSystem.Instance.Has(EEventName.OnRefreshPlayerPing, new Action<int, ENetPingState>(this.OnRefreshPlayerPing)))
		{
			EventSystem.Instance.Remove(EEventName.OnRefreshPlayerPing, new Action<int, ENetPingState>(this.OnRefreshPlayerPing));
		}
	}

	// Token: 0x0600A9DA RID: 43482 RVA: 0x00320D9E File Offset: 0x0031EF9E
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

	// Token: 0x0600A9DB RID: 43483 RVA: 0x00320DDC File Offset: 0x0031EFDC
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

	// Token: 0x0600A9DC RID: 43484 RVA: 0x00320E54 File Offset: 0x0031F054
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

	// Token: 0x02007329 RID: 29481
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x040257D8 RID: 153560
		TabComponent,
		// Token: 0x040257D9 RID: 153561
		TeamRoleContentItem,
		// Token: 0x040257DA RID: 153562
		TeamRoleSlot1,
		// Token: 0x040257DB RID: 153563
		TeamRoleSlot2,
		// Token: 0x040257DC RID: 153564
		TeamRoleSlot3,
		// Token: 0x040257DD RID: 153565
		ConfirmButton,
		// Token: 0x040257DE RID: 153566
		ConfirmText,
		// Token: 0x040257DF RID: 153567
		CloseButton,
		// Token: 0x040257E0 RID: 153568
		QuickSelectButton,
		// Token: 0x040257E1 RID: 153569
		LoadingItem,
		// Token: 0x040257E2 RID: 153570
		DisableClickMask,
		// Token: 0x040257E3 RID: 153571
		DragItem,
		// Token: 0x040257E4 RID: 153572
		DragRoleItem,
		// Token: 0x040257E5 RID: 153573
		TeamNameText,
		// Token: 0x040257E6 RID: 153574
		BtnPresetForm,
		// Token: 0x040257E7 RID: 153575
		BtnEditFormName,
		// Token: 0x040257E8 RID: 153576
		DescToggleItem
	}
}

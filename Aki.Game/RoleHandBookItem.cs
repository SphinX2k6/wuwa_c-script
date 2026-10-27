using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200277E RID: 10110
public class RoleHandBookItem : UiPanelBase
{
	// Token: 0x06014BE0 RID: 84960 RVA: 0x0053FAE0 File Offset: 0x0053DCE0
	[NullableContext(1)]
	public RoleHandBookItem(int roleId, UUIItem item)
	{
		this.RoleId = new int?(roleId);
		if (item != null)
		{
			base.CreateThenShowByActor(item.GetOwner(), null);
		}
	}

	// Token: 0x06014BE1 RID: 84961 RVA: 0x0053FB04 File Offset: 0x0053DD04
	protected unsafe override void OnRegisterComponent()
	{
		int num = 11;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIButtonComponent));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(10, new Action(this.OnClickItem));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06014BE2 RID: 84962 RVA: 0x0053FCD7 File Offset: 0x0053DED7
	public void PlaySequence()
	{
		ALevelSequenceActor showSequence = this.ShowSequence;
		if (showSequence == null)
		{
			return;
		}
		showSequence.SequencePlayer.Play();
	}

	// Token: 0x06014BE3 RID: 84963 RVA: 0x0053FCEE File Offset: 0x0053DEEE
	private void ConfirmClick(int _)
	{
		if (this.IsCanRoleActive())
		{
			RoleController.Instance.SendRoleActiveRequest(this.RoleId.Value);
			return;
		}
		UiManager.Instance.OpenView(EUiViewName.RoleHandBookRootView, EUiViewName.RoleHandBookSelectionView, null);
	}

	// Token: 0x06014BE4 RID: 84964 RVA: 0x0053FD28 File Offset: 0x0053DF28
	protected void AddEventListener()
	{
		EventSystem.Instance.Add<IReadOnlyList<IProto_NormalItem>>(EEventName.OnAddCommonItemList, new Action<IReadOnlyList<IProto_NormalItem>>(this.OnAddCommonItemList));
	}

	// Token: 0x06014BE5 RID: 84965 RVA: 0x0053FD46 File Offset: 0x0053DF46
	protected void RemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnAddCommonItemList, new Action<IReadOnlyList<IProto_NormalItem>>(this.OnAddCommonItemList));
	}

	// Token: 0x06014BE6 RID: 84966 RVA: 0x0053FD64 File Offset: 0x0053DF64
	[NullableContext(1)]
	private void OnAddCommonItemList(IReadOnlyList<IProto_NormalItem> _)
	{
		this.UpdateCostInfo();
	}

	// Token: 0x06014BE7 RID: 84967 RVA: 0x0053FD6C File Offset: 0x0053DF6C
	protected override void OnStart()
	{
		if (this.RoleId == null)
		{
			return;
		}
		this.ConfirmButton = new ButtonItem(base.GetItem(4));
		this.ConfirmButton.SetFunction(new Action<int>(this.ConfirmClick));
		this.UpdateComponent(this.RoleId.Value);
		this.AddEventListener();
	}

	// Token: 0x06014BE8 RID: 84968 RVA: 0x0053FDC8 File Offset: 0x0053DFC8
	public void UpdateComponent(int roleId)
	{
		this.RoleId = new int?(roleId);
		RoleInfo value = RoleConfig.Instance.GetRoleConfig(this.RoleId.Value).Value;
		RoleInstance roleInstanceById = RoleModel.Instance.GetRoleInstanceById(this.RoleId.Value);
		base.GetText(0).ShowTextNew(value.Name);
		this.ConfirmButton.UnBindRedDot();
		this.ConfirmButton.BindRedDot(ERedDotName.RoleHandBookActiveButton, this.RoleId.Value);
		UUIItem item = base.GetItem(7);
		UUIItem item2 = base.GetItem(8);
		UUIItem item3 = base.GetItem(9);
		if (this.IsRoleUnlock())
		{
			this.ConfirmButton.SetLocalText("Detail", Array.Empty<object>());
			LguiUtil.Instance.SetLocalText(base.GetText(5), "ActiveTime", Array.Empty<object>());
			base.GetText(6).SetText(TimeUtil.Instance.DateFormat4(new DateTime(1970, 1, 1).AddSeconds((double)roleInstanceById.GetRoleCreateTime()).AddMilliseconds((double)TimeUtil.Instance.InverseMillisecond)), true);
			item.SetUIActive(true);
			item2.SetUIActive(false);
			item3.SetUIActive(false);
		}
		else
		{
			if (this.IsCanRoleActive())
			{
				this.ConfirmButton.SetLocalText("Tuning", Array.Empty<object>());
			}
			else
			{
				this.ConfirmButton.SetLocalText("Detail", Array.Empty<object>());
			}
			this.UpdateCostInfo();
			item.SetUIActive(false);
			item2.SetUIActive(true);
			item3.SetUIActive(true);
		}
		if (this.ShowSequence != null)
		{
			ALevelSequenceActor tmp = this.ShowSequence;
			TimerSystem.GameplayTimeInstance.Next(delegate(float _)
			{
				ActorSystem.Instance.Put("RoleHandBookItem.UpdateComponent", tmp, null);
			}, null, null);
			this.ShowSequence = null;
		}
		GachaEffectConfig value2 = GachaConfig.Instance.GetGachaEffectConfigByTimesAndQuality(1, value.QualityId).Value;
		ResourceSystem.Instance.LoadAsync<ULevelSequence>(value2.FinalShowSequencePath, delegate(ULevelSequence levelSequenceObject, string _)
		{
			if (ObjectUtils.IsValid(levelSequenceObject))
			{
				FMovieSceneSequencePlaybackSettings fmovieSceneSequencePlaybackSettings = new FMovieSceneSequencePlaybackSettings();
				fmovieSceneSequencePlaybackSettings.bRestoreState = true;
				this.ShowSequence = (ActorSystem.Instance.Get(ALevelSequenceActor.StaticClass(), MathUtils.Instance.DefaultTransformDouble, null, false) as ALevelSequenceActor);
				this.ShowSequence.PlaybackSettings = fmovieSceneSequencePlaybackSettings;
				this.ShowSequence.SetSequence(levelSequenceObject);
			}
		}, 100, this.MemoryTag);
	}

	// Token: 0x06014BE9 RID: 84969 RVA: 0x0053FFD0 File Offset: 0x0053E1D0
	public void UpdateCostInfo()
	{
		if (this.RoleId == null)
		{
			return;
		}
		Dictionary<int, int> dictionary = RoleConfig.Instance.GetRoleConfig(this.RoleId.Value).Value.ExchangeConsume();
		ItemInfo? itemInfo = null;
		int? num = null;
		using (Dictionary<int, int>.Enumerator enumerator = dictionary.GetEnumerator())
		{
			if (enumerator.MoveNext())
			{
				KeyValuePair<int, int> keyValuePair = enumerator.Current;
				itemInfo = ItemConfig.Instance.GetConfig(keyValuePair.Key);
				num = new int?(keyValuePair.Value);
			}
		}
		base.SetTextureByPath(itemInfo.Value.Icon, base.GetTexture(1), null, null);
		LguiUtil.Instance.SetLocalText(base.GetText(2), "RoleFragment", Array.Empty<object>());
		int itemCountByConfigId = InventoryModel.Instance.GetItemCountByConfigId(itemInfo.Value.Id, 0);
		LguiUtil.Instance.SetLocalText(base.GetText(3), "RoleExp", new <>z__ReadOnlyArray<object>(new object[]
		{
			itemCountByConfigId,
			num
		}));
	}

	// Token: 0x06014BEA RID: 84970 RVA: 0x00540110 File Offset: 0x0053E310
	public bool IsRoleUnlock()
	{
		return RoleModel.Instance.GetRoleInstanceById(this.RoleId.Value) != null;
	}

	// Token: 0x06014BEB RID: 84971 RVA: 0x0054012C File Offset: 0x0053E32C
	public bool IsCanRoleActive()
	{
		RoleInfo value = RoleConfig.Instance.GetRoleConfig(this.RoleId.Value).Value;
		bool flag = this.IsRoleUnlock();
		Dictionary<int, int> dictionary = value.ExchangeConsume();
		ItemInfo? itemInfo = null;
		int? num = null;
		using (Dictionary<int, int>.Enumerator enumerator = dictionary.GetEnumerator())
		{
			if (enumerator.MoveNext())
			{
				KeyValuePair<int, int> keyValuePair = enumerator.Current;
				itemInfo = ItemConfig.Instance.GetConfig(keyValuePair.Key);
				num = new int?(keyValuePair.Value);
			}
		}
		int itemCountByConfigId = InventoryModel.Instance.GetItemCountByConfigId(itemInfo.Value.Id, 0);
		return !flag && itemCountByConfigId >= num.Value;
	}

	// Token: 0x06014BEC RID: 84972 RVA: 0x00540200 File Offset: 0x0053E400
	protected override void OnBeforeDestroy()
	{
		this.RemoveEventListener();
		this.ConfirmButton.UnBindRedDot();
		this.RoleId = null;
		if (this.ShowSequence != null)
		{
			ALevelSequenceActor tmp = this.ShowSequence;
			TimerSystem.GameplayTimeInstance.Next(delegate(float _)
			{
				ActorSystem.Instance.Put("RoleHandBookItem.OnBeforeDestroy", tmp, null);
			}, null, null);
			this.ShowSequence = null;
		}
	}

	// Token: 0x06014BED RID: 84973 RVA: 0x00540264 File Offset: 0x0053E464
	protected void OnClickItem()
	{
		Dictionary<int, int> dictionary = RoleConfig.Instance.GetRoleConfig(this.RoleId.Value).Value.ExchangeConsume();
		int? num = null;
		using (Dictionary<int, int>.KeyCollection.Enumerator enumerator = dictionary.Keys.GetEnumerator())
		{
			if (enumerator.MoveNext())
			{
				int value = enumerator.Current;
				num = new int?(value);
			}
		}
		ItemController.Instance.OpenItemTipsByItemId(num.Value, true, null);
	}

	// Token: 0x04009C04 RID: 39940
	[Nullable(2)]
	private ButtonItem ConfirmButton;

	// Token: 0x04009C05 RID: 39941
	private int? RoleId;

	// Token: 0x04009C06 RID: 39942
	[Nullable(2)]
	private ALevelSequenceActor ShowSequence;

	// Token: 0x02008DE7 RID: 36327
	private enum ERoleHandBookItemDefine
	{
		// Token: 0x0402E0A1 RID: 188577
		NameText,
		// Token: 0x0402E0A2 RID: 188578
		IconTexture,
		// Token: 0x0402E0A3 RID: 188579
		FragmentTitleText,
		// Token: 0x0402E0A4 RID: 188580
		FragmentCostText,
		// Token: 0x0402E0A5 RID: 188581
		ConfirmButton,
		// Token: 0x0402E0A6 RID: 188582
		ActiveTimeTitleText,
		// Token: 0x0402E0A7 RID: 188583
		ActiveTimeText,
		// Token: 0x0402E0A8 RID: 188584
		ActiveTimeItem,
		// Token: 0x0402E0A9 RID: 188585
		IconItem,
		// Token: 0x0402E0AA RID: 188586
		FragmentItem,
		// Token: 0x0402E0AB RID: 188587
		ItemTipsButton
	}
}

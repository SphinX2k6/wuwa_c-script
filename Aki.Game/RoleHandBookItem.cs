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

// Token: 0x02001C69 RID: 7273
public class RoleHandBookItem : UiPanelBase
{
	// Token: 0x060120C3 RID: 73923 RVA: 0x0054E96C File Offset: 0x0054CB6C
	[NullableContext(1)]
	public RoleHandBookItem(int roleId, UUIItem item)
	{
		this.RoleId = new int?(roleId);
		if (item != null)
		{
			base.CreateThenShowByActor(item.GetOwner(), null);
		}
	}

	// Token: 0x060120C4 RID: 73924 RVA: 0x0054E990 File Offset: 0x0054CB90
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

	// Token: 0x060120C5 RID: 73925 RVA: 0x0054EB63 File Offset: 0x0054CD63
	public void PlaySequence()
	{
		ALevelSequenceActor showSequence = this.ShowSequence;
		if (showSequence == null)
		{
			return;
		}
		showSequence.SequencePlayer.Play();
	}

	// Token: 0x060120C6 RID: 73926 RVA: 0x0054EB7A File Offset: 0x0054CD7A
	private void ConfirmClick(int _)
	{
		if (this.IsCanRoleActive())
		{
			RoleController.Instance.SendRoleActiveRequest(this.RoleId.Value);
			return;
		}
		UiManager.Instance.OpenView(EUiViewName.RoleHandBookRootView, EUiViewName.RoleHandBookSelectionView, null);
	}

	// Token: 0x060120C7 RID: 73927 RVA: 0x0054EBB4 File Offset: 0x0054CDB4
	protected void AddEventListener()
	{
		EventSystem.Instance.Add<IReadOnlyList<IProto_NormalItem>>(EEventName.OnAddCommonItemList, new Action<IReadOnlyList<IProto_NormalItem>>(this.OnAddCommonItemList));
	}

	// Token: 0x060120C8 RID: 73928 RVA: 0x0054EBD2 File Offset: 0x0054CDD2
	protected void RemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnAddCommonItemList, new Action<IReadOnlyList<IProto_NormalItem>>(this.OnAddCommonItemList));
	}

	// Token: 0x060120C9 RID: 73929 RVA: 0x0054EBF0 File Offset: 0x0054CDF0
	[NullableContext(1)]
	private void OnAddCommonItemList(IReadOnlyList<IProto_NormalItem> _)
	{
		this.UpdateCostInfo();
	}

	// Token: 0x060120CA RID: 73930 RVA: 0x0054EBF8 File Offset: 0x0054CDF8
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

	// Token: 0x060120CB RID: 73931 RVA: 0x0054EC54 File Offset: 0x0054CE54
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

	// Token: 0x060120CC RID: 73932 RVA: 0x0054EE5C File Offset: 0x0054D05C
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

	// Token: 0x060120CD RID: 73933 RVA: 0x0054EF9C File Offset: 0x0054D19C
	public bool IsRoleUnlock()
	{
		return RoleModel.Instance.GetRoleInstanceById(this.RoleId.Value) != null;
	}

	// Token: 0x060120CE RID: 73934 RVA: 0x0054EFB8 File Offset: 0x0054D1B8
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

	// Token: 0x060120CF RID: 73935 RVA: 0x0054F08C File Offset: 0x0054D28C
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

	// Token: 0x060120D0 RID: 73936 RVA: 0x0054F0F0 File Offset: 0x0054D2F0
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
		ItemController.Instance.OpenItemTipsByItemId(num.Value, true, null, false);
	}

	// Token: 0x04009D5C RID: 40284
	[Nullable(2)]
	private ButtonItem ConfirmButton;

	// Token: 0x04009D5D RID: 40285
	private int? RoleId;

	// Token: 0x04009D5E RID: 40286
	[Nullable(2)]
	private ALevelSequenceActor ShowSequence;

	// Token: 0x02007F6E RID: 32622
	private enum ERoleHandBookItemDefine
	{
		// Token: 0x040293B5 RID: 168885
		NameText,
		// Token: 0x040293B6 RID: 168886
		IconTexture,
		// Token: 0x040293B7 RID: 168887
		FragmentTitleText,
		// Token: 0x040293B8 RID: 168888
		FragmentCostText,
		// Token: 0x040293B9 RID: 168889
		ConfirmButton,
		// Token: 0x040293BA RID: 168890
		ActiveTimeTitleText,
		// Token: 0x040293BB RID: 168891
		ActiveTimeText,
		// Token: 0x040293BC RID: 168892
		ActiveTimeItem,
		// Token: 0x040293BD RID: 168893
		IconItem,
		// Token: 0x040293BE RID: 168894
		FragmentItem,
		// Token: 0x040293BF RID: 168895
		ItemTipsButton
	}
}

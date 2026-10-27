using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001B71 RID: 7025
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchRandomEventView : UiViewBase
{
	// Token: 0x0600D0F0 RID: 53488 RVA: 0x002FC48C File Offset: 0x002FA68C
	public FloroRanchRandomEventView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x0600D0F1 RID: 53489 RVA: 0x002FC4A0 File Offset: 0x002FA6A0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 12;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(USpineSkeletonAnimationComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIVerticalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 2;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(8, new Action(this.OnClickConfirmButton));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(9, new Action(this.OnClickHideButton));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600D0F2 RID: 53490 RVA: 0x002FC6B8 File Offset: 0x002FA8B8
	protected override UniTask OnBeforeStartAsync()
	{
		FloroRanchRandomEventView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FloroRanchRandomEventView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600D0F3 RID: 53491 RVA: 0x002FC6FC File Offset: 0x002FA8FC
	protected override void OnBeforeShow()
	{
		global::FloroRanchActivityData currentActivityData = FloroRanchGamePlayModel.Instance.GetCurrentActivityData();
		base.GetButton(8).SetSelfInteractive(this.SelectedChoiceId != 0);
		base.GetSpine(4).SetAnimation(0, "idle", true);
		this.ShowAllToy();
		this.UiBlur.SetEnableUiBlur(true);
		UUIInturnAnimController uuiinturnAnimController = base.GetVerticalLayout(6).GetOwner().GetComponentByClass(UUIInturnAnimController.StaticClass()) as UUIInturnAnimController;
		if (uuiinturnAnimController != null)
		{
			uuiinturnAnimController.Play("", -1, false);
		}
		if (currentActivityData != null)
		{
			FloroRanchAudioData floroRanchRandomAudioDataByType = FloroRanchModel.Instance.GetFloroRanchRandomAudioDataByType(EFloroRanchAudioType.Event, currentActivityData.GetVoiceCharacterType());
			string text = (floroRanchRandomAudioDataByType != null) ? floroRanchRandomAudioDataByType.GetAudioText() : null;
			string text2 = (floroRanchRandomAudioDataByType != null) ? floroRanchRandomAudioDataByType.GetAudioEvent() : null;
			if (string.IsNullOrEmpty(text))
			{
				UUIItem item = base.GetItem(2);
				if (item == null)
				{
					return;
				}
				item.SetUIActive(false);
				return;
			}
			else
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(3), text, Array.Empty<object>());
				if (!string.IsNullOrEmpty(text2))
				{
					this.EventHandle = AudioSystem.Instance.PostEvent(text2);
				}
				UUIItem item2 = base.GetItem(2);
				if (item2 == null)
				{
					return;
				}
				item2.SetUIActive(true);
			}
		}
	}

	// Token: 0x0600D0F4 RID: 53492 RVA: 0x002FC810 File Offset: 0x002FAA10
	protected override void OnBeforeHide()
	{
		this.UiBlur.SetEnableUiBlur(false);
		if (this.EventHandle != 0)
		{
			AudioSystem.Instance.ExecuteAction(this.EventHandle, EAudioActionType.Stop, null);
			this.EventHandle = 0;
		}
	}

	// Token: 0x0600D0F5 RID: 53493 RVA: 0x002FC852 File Offset: 0x002FAA52
	private void InitUiBlur()
	{
		this.UiBlur = UE.NewObject<TsUiBlur>(this.RootActor, null, EObjectFlags.RF_NoFlags);
		this.UiBlur.SetEnableUiBlur(false);
	}

	// Token: 0x0600D0F6 RID: 53494 RVA: 0x002FC874 File Offset: 0x002FAA74
	private UniTask CreateToyItem(int point)
	{
		FloroRanchRandomEventView.<CreateToyItem>d__14 <CreateToyItem>d__;
		<CreateToyItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateToyItem>d__.<>4__this = this;
		<CreateToyItem>d__.point = point;
		<CreateToyItem>d__.<>1__state = -1;
		<CreateToyItem>d__.<>t__builder.Start<FloroRanchRandomEventView.<CreateToyItem>d__14>(ref <CreateToyItem>d__);
		return <CreateToyItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600D0F7 RID: 53495 RVA: 0x002FC8C0 File Offset: 0x002FAAC0
	private void ShowAllToy()
	{
		int enableToyCount = FloroRanchGamePlayModel.Instance.EnableToyCount;
		for (int i = 0; i < enableToyCount; i++)
		{
			if (FloroRanchGamePlayModel.Instance.GetToyEntityByPoint(i) != null)
			{
				this.ShowToy(i);
			}
			else
			{
				this.HideToy(i);
			}
		}
	}

	// Token: 0x0600D0F8 RID: 53496 RVA: 0x002FC904 File Offset: 0x002FAB04
	private void ShowToy(int point)
	{
		FloroRanchToyGridItem floroRanchToyGridItem;
		if (this.ToyItemMap.TryGetValue(point, out floroRanchToyGridItem))
		{
			FloroRanchEntityBase toyEntityByPoint = FloroRanchGamePlayModel.Instance.GetToyEntityByPoint(point);
			floroRanchToyGridItem.PlayShowAnim(toyEntityByPoint);
		}
	}

	// Token: 0x0600D0F9 RID: 53497 RVA: 0x002FC934 File Offset: 0x002FAB34
	private void HideToy(int point)
	{
		FloroRanchToyGridItem floroRanchToyGridItem;
		if (this.ToyItemMap.TryGetValue(point, out floroRanchToyGridItem))
		{
			floroRanchToyGridItem.SetInfoPanelActive(false);
		}
	}

	// Token: 0x0600D0FA RID: 53498 RVA: 0x002FC958 File Offset: 0x002FAB58
	private void SetToyListActive(bool isActive)
	{
		base.GetItem(10).SetAlpha(isActive > false);
	}

	// Token: 0x0600D0FB RID: 53499 RVA: 0x002FC96C File Offset: 0x002FAB6C
	private void ToySellCallback(int point)
	{
		this.HideToy(point);
		this.ShowAllToy();
	}

	// Token: 0x0600D0FC RID: 53500 RVA: 0x002FC97C File Offset: 0x002FAB7C
	private void OnClickToyItem(int point)
	{
		if (point < 0)
		{
			return;
		}
		UiManager.Instance.OpenView(EUiViewName.FloroRanchShopTipView, new FloroRanchShopTipViewParam
		{
			ToyPoint = point,
			SellCallback = new Action<int>(this.ToySellCallback),
			ShowToyListCallback = new Action<bool>(this.SetToyListActive)
		}, null);
		FloroRanchToyGridItem floroRanchToyGridItem;
		if (this.ToyItemMap.TryGetValue(point, out floroRanchToyGridItem) && floroRanchToyGridItem != null)
		{
			floroRanchToyGridItem.SetSelectState(false);
		}
	}

	// Token: 0x0600D0FD RID: 53501 RVA: 0x002FC9F4 File Offset: 0x002FABF4
	private FloroRanchRandomEventItem InitEventItem()
	{
		FloroRanchRandomEventItem floroRanchRandomEventItem = new FloroRanchRandomEventItem();
		floroRanchRandomEventItem.BindClickCallback(new Action<int, int>(this.OnClickEventItem));
		return floroRanchRandomEventItem;
	}

	// Token: 0x0600D0FE RID: 53502 RVA: 0x002FCA10 File Offset: 0x002FAC10
	private void OnClickConfirmButton()
	{
		global::FloroRanchActivityData activityData = FloroRanchGamePlayModel.Instance.GetCurrentActivityData();
		if (activityData == null)
		{
			return;
		}
		FloroRanchWeeklyChoice? floroRanchWeeklyChoiceById = FloroRanchConfig.Instance.GetFloroRanchWeeklyChoiceById(this.SelectedChoiceId);
		if (floroRanchWeeklyChoiceById != null)
		{
			int needRemoveToyCount = floroRanchWeeklyChoiceById.Value.NeedRemoveToyCount;
			int needEmptyGridCount = floroRanchWeeklyChoiceById.Value.NeedEmptyGridCount;
			if (needRemoveToyCount > 0)
			{
				int toyRelateQuality = floroRanchWeeklyChoiceById.Value.ToyRelateQuality;
				List<FloroRanchEntityBase> showToyEntityList = FloroRanchGamePlayModel.Instance.GetShowToyEntityList();
				int num = 0;
				foreach (FloroRanchEntityBase floroRanchEntityBase in showToyEntityList)
				{
					FloroRanchToyDataComponent floroRanchToyDataComponent = floroRanchEntityBase.CheckGetComponent<FloroRanchToyDataComponent>();
					if (((floroRanchToyDataComponent != null) ? floroRanchToyDataComponent.ToyData : null) != null && floroRanchToyDataComponent.ToyData.CheckCanSell() && (toyRelateQuality <= 0 || floroRanchToyDataComponent.ToyData.GetToyQualityData().Id == toyRelateQuality))
					{
						num++;
					}
				}
				if (num < needRemoveToyCount)
				{
					ScrollingTipsController.Instance.ShowTipsByTextId("Farm_EventBlockTip", Array.Empty<object>());
					return;
				}
			}
			int num2 = needEmptyGridCount - needRemoveToyCount;
			if (num2 > 0 && FloroRanchGamePlayModel.Instance.EnableToyCount - FloroRanchGamePlayModel.Instance.GetCurToyCount() < num2)
			{
				ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.FloroRanchEventToyGridNotEnough);
				confirmBoxDataNew.FunctionMap[2] = delegate()
				{
					this.SendEventChoiceRequest(activityData);
				};
				ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
				return;
			}
			int getToyRelateQuality = floroRanchWeeklyChoiceById.Value.GetToyRelateQuality;
			if (getToyRelateQuality > 0)
			{
				List<int> races = FloroRanchGamePlayModel.Instance.Races;
				Dictionary<int, FloroRanchToyData> floroRanchToyDataMap = FloroRanchModel.Instance.GetFloroRanchToyDataMap();
				int num3 = 0;
				foreach (KeyValuePair<int, FloroRanchToyData> keyValuePair in floroRanchToyDataMap)
				{
					int num4;
					FloroRanchToyData floroRanchToyData;
					keyValuePair.Deconstruct(out num4, out floroRanchToyData);
					int id = num4;
					FloroRanchToyData floroRanchToyData2 = floroRanchToyData;
					if (floroRanchToyData2.GetRarity() == getToyRelateQuality && activityData.IsToyUnlocked(id))
					{
						int toyType = floroRanchToyData2.GetToyType();
						if (toyType == 1)
						{
							num3++;
						}
						else if (toyType == 2 && races.Contains(floroRanchToyData2.GetRace()))
						{
							num3++;
						}
					}
				}
				List<FloroRanchEntityBase> showToyEntityList2 = FloroRanchGamePlayModel.Instance.GetShowToyEntityList();
				int num5 = 0;
				foreach (FloroRanchEntityBase floroRanchEntityBase2 in showToyEntityList2)
				{
					FloroRanchToyDataComponent floroRanchToyDataComponent2 = floroRanchEntityBase2.CheckGetComponent<FloroRanchToyDataComponent>();
					bool flag;
					if (floroRanchToyDataComponent2 == null)
					{
						flag = false;
					}
					else
					{
						FloroRanchToyData toyData = floroRanchToyDataComponent2.ToyData;
						int? num6 = (toyData != null) ? new int?(toyData.GetToyQualityData().Id) : null;
						int num4 = getToyRelateQuality;
						flag = (num6.GetValueOrDefault() == num4 & num6 != null);
					}
					if (flag)
					{
						num5++;
					}
				}
				if (num3 - num5 < needEmptyGridCount)
				{
					ScrollingTipsController.Instance.ShowTipsByTextId("WeeklyFarm_SameToyTip", Array.Empty<object>());
					return;
				}
			}
		}
		this.SendEventChoiceRequest(activityData);
	}

	// Token: 0x0600D0FF RID: 53503 RVA: 0x002FCD1C File Offset: 0x002FAF1C
	private void OnClickEventItem(int gridIndex, int choiceId)
	{
		if (this.SelectedChoiceId == choiceId)
		{
			return;
		}
		this.SelectedChoiceId = choiceId;
		this.EventLayout.SelectGridProxy(gridIndex, false);
		base.GetButton(8).SetSelfInteractive(true);
	}

	// Token: 0x0600D100 RID: 53504 RVA: 0x002FCD4C File Offset: 0x002FAF4C
	private void SendEventChoiceRequest(global::FloroRanchActivityData activityData)
	{
		int id = activityData.Id;
		int subInstanceId = FloroRanchGamePlayModel.Instance.SubInstanceId;
		FloroRanchController.Instance.SendFloroRanchEventChoiceRequest(id, subInstanceId, this.EventData.IncId, this.SelectedChoiceId, delegate(FloroRanchEventChoiceResponse response)
		{
			base.CloseMe(null);
			Action closeCallback = this.CloseCallback;
			if (closeCallback == null)
			{
				return;
			}
			closeCallback();
		});
	}

	// Token: 0x0600D101 RID: 53505 RVA: 0x002FCD94 File Offset: 0x002FAF94
	private void OnClickHideButton()
	{
		FloroRanchGamePlayModel.Instance.HideRecordView();
	}

	// Token: 0x04005FE2 RID: 24546
	[Nullable(2)]
	private FloroRanchPlayEvent EventData;

	// Token: 0x04005FE3 RID: 24547
	[Nullable(2)]
	private Action CloseCallback;

	// Token: 0x04005FE4 RID: 24548
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<FloroRanchRandomEventItem, int> EventLayout;

	// Token: 0x04005FE5 RID: 24549
	private int SelectedChoiceId;

	// Token: 0x04005FE6 RID: 24550
	private readonly Dictionary<int, FloroRanchToyGridItem> ToyItemMap = new Dictionary<int, FloroRanchToyGridItem>();

	// Token: 0x04005FE7 RID: 24551
	[Nullable(2)]
	private TsUiBlur UiBlur;

	// Token: 0x04005FE8 RID: 24552
	private int EventHandle;

	// Token: 0x020080E6 RID: 32998
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x0402A0E8 RID: 172264
		public const int InfoPanel = 0;

		// Token: 0x0402A0E9 RID: 172265
		public const int EventTitle = 1;

		// Token: 0x0402A0EA RID: 172266
		public const int ChatPanel = 2;

		// Token: 0x0402A0EB RID: 172267
		public const int ChatText = 3;

		// Token: 0x0402A0EC RID: 172268
		public const int Spine = 4;

		// Token: 0x0402A0ED RID: 172269
		public const int BarItem = 5;

		// Token: 0x0402A0EE RID: 172270
		public const int EventLayout = 6;

		// Token: 0x0402A0EF RID: 172271
		public const int EventItem = 7;

		// Token: 0x0402A0F0 RID: 172272
		public const int ConfirmButton = 8;

		// Token: 0x0402A0F1 RID: 172273
		public const int HideButton = 9;

		// Token: 0x0402A0F2 RID: 172274
		public const int ToyLayout = 10;

		// Token: 0x0402A0F3 RID: 172275
		public const int ToyItemTemplate = 11;
	}
}

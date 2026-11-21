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

// Token: 0x02001030 RID: 4144
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchRandomEventView : UiViewBase
{
	// Token: 0x0600A501 RID: 42241 RVA: 0x00307564 File Offset: 0x00305764
	public FloroRanchRandomEventView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x0600A502 RID: 42242 RVA: 0x00307578 File Offset: 0x00305778
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

	// Token: 0x0600A503 RID: 42243 RVA: 0x00307790 File Offset: 0x00305990
	protected override UniTask OnBeforeStartAsync()
	{
		FloroRanchRandomEventView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FloroRanchRandomEventView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600A504 RID: 42244 RVA: 0x003077D4 File Offset: 0x003059D4
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

	// Token: 0x0600A505 RID: 42245 RVA: 0x003078E8 File Offset: 0x00305AE8
	protected override void OnBeforeHide()
	{
		this.UiBlur.SetEnableUiBlur(false);
		if (this.EventHandle != 0)
		{
			AudioSystem.Instance.ExecuteAction(this.EventHandle, EAudioActionType.Stop, null);
			this.EventHandle = 0;
		}
	}

	// Token: 0x0600A506 RID: 42246 RVA: 0x0030792A File Offset: 0x00305B2A
	private void InitUiBlur()
	{
		this.UiBlur = UE.NewObject<TsUiBlur>(this.RootActor, null, EObjectFlags.RF_NoFlags);
		this.UiBlur.SetEnableUiBlur(false);
	}

	// Token: 0x0600A507 RID: 42247 RVA: 0x0030794C File Offset: 0x00305B4C
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

	// Token: 0x0600A508 RID: 42248 RVA: 0x00307998 File Offset: 0x00305B98
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

	// Token: 0x0600A509 RID: 42249 RVA: 0x003079DC File Offset: 0x00305BDC
	private void ShowToy(int point)
	{
		FloroRanchToyGridItem floroRanchToyGridItem;
		if (this.ToyItemMap.TryGetValue(point, out floroRanchToyGridItem))
		{
			FloroRanchEntityBase toyEntityByPoint = FloroRanchGamePlayModel.Instance.GetToyEntityByPoint(point);
			floroRanchToyGridItem.PlayShowAnim(toyEntityByPoint);
		}
	}

	// Token: 0x0600A50A RID: 42250 RVA: 0x00307A0C File Offset: 0x00305C0C
	private void HideToy(int point)
	{
		FloroRanchToyGridItem floroRanchToyGridItem;
		if (this.ToyItemMap.TryGetValue(point, out floroRanchToyGridItem))
		{
			floroRanchToyGridItem.SetInfoPanelActive(false);
		}
	}

	// Token: 0x0600A50B RID: 42251 RVA: 0x00307A30 File Offset: 0x00305C30
	private void SetToyListActive(bool isActive)
	{
		base.GetItem(10).SetAlpha(isActive > false);
	}

	// Token: 0x0600A50C RID: 42252 RVA: 0x00307A44 File Offset: 0x00305C44
	private void ToySellCallback(int point)
	{
		this.HideToy(point);
		this.ShowAllToy();
	}

	// Token: 0x0600A50D RID: 42253 RVA: 0x00307A54 File Offset: 0x00305C54
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

	// Token: 0x0600A50E RID: 42254 RVA: 0x00307ACC File Offset: 0x00305CCC
	private FloroRanchRandomEventItem InitEventItem()
	{
		FloroRanchRandomEventItem floroRanchRandomEventItem = new FloroRanchRandomEventItem();
		floroRanchRandomEventItem.BindClickCallback(new Action<int, int>(this.OnClickEventItem));
		return floroRanchRandomEventItem;
	}

	// Token: 0x0600A50F RID: 42255 RVA: 0x00307AE8 File Offset: 0x00305CE8
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

	// Token: 0x0600A510 RID: 42256 RVA: 0x00307DF4 File Offset: 0x00305FF4
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

	// Token: 0x0600A511 RID: 42257 RVA: 0x00307E24 File Offset: 0x00306024
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

	// Token: 0x0600A512 RID: 42258 RVA: 0x00307E6C File Offset: 0x0030606C
	private void OnClickHideButton()
	{
		FloroRanchGamePlayModel.Instance.HideRecordView();
	}

	// Token: 0x040060B1 RID: 24753
	[Nullable(2)]
	private FloroRanchPlayEvent EventData;

	// Token: 0x040060B2 RID: 24754
	[Nullable(2)]
	private Action CloseCallback;

	// Token: 0x040060B3 RID: 24755
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<FloroRanchRandomEventItem, int> EventLayout;

	// Token: 0x040060B4 RID: 24756
	private int SelectedChoiceId;

	// Token: 0x040060B5 RID: 24757
	private readonly Dictionary<int, FloroRanchToyGridItem> ToyItemMap = new Dictionary<int, FloroRanchToyGridItem>();

	// Token: 0x040060B6 RID: 24758
	[Nullable(2)]
	private TsUiBlur UiBlur;

	// Token: 0x040060B7 RID: 24759
	private int EventHandle;

	// Token: 0x02007274 RID: 29300
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x0402541C RID: 152604
		public const int InfoPanel = 0;

		// Token: 0x0402541D RID: 152605
		public const int EventTitle = 1;

		// Token: 0x0402541E RID: 152606
		public const int ChatPanel = 2;

		// Token: 0x0402541F RID: 152607
		public const int ChatText = 3;

		// Token: 0x04025420 RID: 152608
		public const int Spine = 4;

		// Token: 0x04025421 RID: 152609
		public const int BarItem = 5;

		// Token: 0x04025422 RID: 152610
		public const int EventLayout = 6;

		// Token: 0x04025423 RID: 152611
		public const int EventItem = 7;

		// Token: 0x04025424 RID: 152612
		public const int ConfirmButton = 8;

		// Token: 0x04025425 RID: 152613
		public const int HideButton = 9;

		// Token: 0x04025426 RID: 152614
		public const int ToyLayout = 10;

		// Token: 0x04025427 RID: 152615
		public const int ToyItemTemplate = 11;
	}
}

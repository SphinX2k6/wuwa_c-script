using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.AdventureGuide;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Map;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.WorldMap;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000B49 RID: 2889
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class AdventureTargetItem : GridProxyAbstract<AdventureTaskRecord>
{
	// Token: 0x060078A3 RID: 30883 RVA: 0x002553E0 File Offset: 0x002535E0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 13;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIScrollViewWithScrollbarComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 2;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnRedirectBtnClick));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(9, new Action(this.OnClickGetButton));
		this.BtnBindInfo = list2;
	}

	// Token: 0x060078A4 RID: 30884 RVA: 0x0025561C File Offset: 0x0025381C
	protected override void OnStart()
	{
		this.Layout = new GenericLayout<CommonItemSmallItemGrid, TItem>(base.GetHorizontalLayout(3), new Func<CommonItemSmallItemGrid>(this.OnRewardLayoutUpdater), null, false, true);
		this.ExtendToggle = (base.GetItem(1).GetOwner().GetComponentByClass(UUIExtendToggle.StaticClass()) as UUIExtendToggle);
		this.ExtendToggle.OnPostAudioEvent.Bind(delegate(string eventPath)
		{
			if (!string.IsNullOrEmpty(eventPath))
			{
				base.PostClickAudioEvent(eventPath);
			}
		});
		this.ExtendToggle.OnPostAudioStateEvent.Bind(delegate(EToggleAudioTransitionState state, string eventPath)
		{
			if (!string.IsNullOrEmpty(eventPath))
			{
				base.PostClickAudioEvent(eventPath);
			}
		});
	}

	// Token: 0x060078A5 RID: 30885 RVA: 0x002556A8 File Offset: 0x002538A8
	private CommonItemSmallItemGrid OnRewardLayoutUpdater()
	{
		CommonItemSmallItemGrid commonItemSmallItemGrid = new CommonItemSmallItemGrid();
		commonItemSmallItemGrid.SetUseFixedAsync(true);
		commonItemSmallItemGrid.ShowReceivedCallBack = delegate(TItem _)
		{
			AdventureTaskRecord data = this.Data;
			return data != null && data.Status == AdventreTaskSate.Received;
		};
		return commonItemSmallItemGrid;
	}

	// Token: 0x060078A6 RID: 30886 RVA: 0x002556C8 File Offset: 0x002538C8
	protected override void OnBeforeDestroy()
	{
		this.ExtendToggle.OnPostAudioEvent.Unbind();
		this.ExtendToggle.OnPostAudioStateEvent.Unbind();
	}

	// Token: 0x060078A7 RID: 30887 RVA: 0x002556EC File Offset: 0x002538EC
	public override void Refresh(AdventureTaskRecord data, bool isSelected, int gridIndex)
	{
		this.Clicking = false;
		this.Data = data;
		AdventureTask adventureTaskBase = data.AdventureTaskBase;
		this.AdventureId = data.AdventureTaskBase.Id;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), adventureTaskBase.TaskText, Array.Empty<object>());
		base.GetItem(1).SetUIActive(false);
		int totalNum = data.GetTotalNum();
		int num = (Array.IndexOf<int>(AdventureGuideModel.Instance.GetRewardChaptersList(), data.AdventureTaskBase.ChapterId) >= 0) ? totalNum : data.Progress;
		UUIText text = base.GetText(5);
		if (totalNum != 0)
		{
			text.SetUIActive(true);
			LguiUtil.Instance.SetLocalTextNew(text, "Wandering_Log_Task_Prograss", new <>z__ReadOnlyArray<object>(new object[]
			{
				num,
				totalNum
			}));
		}
		else
		{
			text.SetUIActive(false);
		}
		List<TItem> list = new List<TItem>();
		Dictionary<int, int> dropShowInfo = AdventureGuideConfig.Instance.GetDropShowInfo(adventureTaskBase.DropIds);
		foreach (KeyValuePair<int, int> keyValuePair in dropShowInfo)
		{
			int key = keyValuePair.Key;
			InventoryDefine.GetItemData itemData = new InventoryDefine.GetItemData(key, 0);
			TItem item = new TItem(itemData, dropShowInfo[key]);
			list.Add(item);
		}
		this.Layout.RefreshByData(list, delegate
		{
			base.GetScrollViewWithScrollbar(6).ScrollTo(this.Layout.GetGrid(0), false);
		}, false);
		this.RootItem.SetUIActive(true);
		this.SetBtnStatusByTargetState(data.Status, this.Data.AdventureTaskBase.JumpToLength != 0);
		bool flag = data.Status == AdventreTaskSate.Received;
		base.GetItem(10).SetUIActive(!flag);
		base.GetItem(11).SetUIActive(flag);
		base.GetItem(12).SetAlpha(flag ? 0.5f : 1f);
	}

	// Token: 0x060078A8 RID: 30888 RVA: 0x002558D4 File Offset: 0x00253AD4
	public void SetClickGetButtonCb(Action<int> cb)
	{
		this.ClickGetButtonCb = cb;
	}

	// Token: 0x060078A9 RID: 30889 RVA: 0x002558DD File Offset: 0x00253ADD
	private void SetBtnStatusByTargetState(AdventreTaskSate status, bool showRedirect)
	{
		this.RefreshFinishItem(status);
		this.RefreshGetButton(status);
		this.RefreshRedirectButton(status, showRedirect);
		this.RefreshRedItem(status);
		this.RefreshDoingText(status, showRedirect);
	}

	// Token: 0x060078AA RID: 30890 RVA: 0x00255904 File Offset: 0x00253B04
	private void RefreshDoingText(AdventreTaskSate state, bool showRedirect)
	{
		base.GetItem(7).SetUIActive(state == AdventreTaskSate.UnFinish && !showRedirect);
	}

	// Token: 0x060078AB RID: 30891 RVA: 0x0025591C File Offset: 0x00253B1C
	private void RefreshFinishItem(AdventreTaskSate state)
	{
		base.GetItem(8).SetUIActive(state == AdventreTaskSate.Received);
	}

	// Token: 0x060078AC RID: 30892 RVA: 0x00255930 File Offset: 0x00253B30
	private void RefreshGetButton(AdventreTaskSate state)
	{
		base.GetButton(9).RootUIComp.Get().SetUIActive(state == AdventreTaskSate.Finish);
	}

	// Token: 0x060078AD RID: 30893 RVA: 0x0025595C File Offset: 0x00253B5C
	private void RefreshRedirectButton(AdventreTaskSate state, bool showRedirect)
	{
		base.GetButton(2).RootUIComp.Get().SetUIActive(state == AdventreTaskSate.UnFinish && showRedirect);
	}

	// Token: 0x060078AE RID: 30894 RVA: 0x00255988 File Offset: 0x00253B88
	private void RefreshRedItem(AdventreTaskSate state)
	{
		base.GetItem(4).SetUIActive(state == AdventreTaskSate.Finish);
	}

	// Token: 0x060078AF RID: 30895 RVA: 0x0025599A File Offset: 0x00253B9A
	private void OnClickGetButton()
	{
		if (this.Data.Status == AdventreTaskSate.Finish)
		{
			Action<int> clickGetButtonCb = this.ClickGetButtonCb;
			if (clickGetButtonCb == null)
			{
				return;
			}
			clickGetButtonCb(this.AdventureId);
		}
	}

	// Token: 0x060078B0 RID: 30896 RVA: 0x002559C0 File Offset: 0x00253BC0
	private void OnRedirectBtnClick()
	{
		if (!this.Clicking)
		{
			this.Clicking = true;
			if (this.Data.Status == AdventreTaskSate.UnFinish)
			{
				this.HandleJump();
				this.Clicking = false;
			}
		}
	}

	// Token: 0x060078B1 RID: 30897 RVA: 0x002559EC File Offset: 0x00253BEC
	private unsafe void HandleJump()
	{
		AdventureTaskRecord data = this.Data;
		if (((data != null) ? data.AdventureTaskBase.JumpTo() : null) == null)
		{
			return;
		}
		int? num = null;
		string text = null;
		foreach (KeyValuePair<int, string> keyValuePair in this.Data.AdventureTaskBase.JumpTo())
		{
			num = new int?(keyValuePair.Key);
			text = keyValuePair.Value;
		}
		if (num == null || string.IsNullOrEmpty(text))
		{
			return;
		}
		switch (num.Value)
		{
		case 1:
			UiManager.Instance.OpenView(EUiViewName.QuestView, int.Parse(text), null);
			return;
		case 2:
		{
			MapConfig instance = MapConfig.Instance;
			MapMark? mapMark = (instance != null) ? instance.GetConfigMark(int.Parse(text)) : null;
			if (mapMark == null)
			{
				Log instance2 = Log.Instance;
				ELogModule module = ELogModule.AdventureGuide;
				ELogAuthor author = ELogAuthor.LJQ;
				string message = "配置了错误的开拓任务跳转参数";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Id: ", this.Data.AdventureTaskBase.Id);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Parma: ", text);
				instance2.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			WorldMapViewOpenParams data2 = new WorldMapViewOpenParams
			{
				MarkType = (EMarkType)mapMark.Value.ObjectType,
				MarkId = new int?(mapMark.Value.MarkId),
				OpenFogId = new int?(0)
			};
			WorldMapController.Instance.OpenView(EOpenMapType.Mouse, false, data2, null);
			return;
		}
		case 3:
			if (text == EUiViewName.RoleRootView.ToString())
			{
				RoleController.Instance.OpenRoleMainView(ERoleAgentType.Normal, 0, null, null, null);
				return;
			}
			UiManager.Instance.OpenView((EUiViewName)text, null, null);
			return;
		case 4:
		{
			string value = text;
			RoleController.Instance.OpenRoleMainView(ERoleAgentType.Normal, 0, new List<int>(), new EUiTabViewName?((EUiTabViewName)value), null);
			return;
		}
		case 5:
		{
			CalabashRootViewData param = new CalabashRootViewData
			{
				TabViewName = (EUiTabViewName)text,
				Param = null
			};
			UiManager.Instance.OpenView(EUiViewName.CalabashRootView, param, null);
			return;
		}
		case 9:
			this.ProcessDisposableChallengeTabOpen(int.Parse(text));
			return;
		}
		Log instance3 = Log.Instance;
		ELogModule module2 = ELogModule.AdventureGuide;
		ELogAuthor author2 = ELogAuthor.LJQ;
		string message2 = "配置了错误的开拓任务跳转类型";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("Id: ", this.Data.AdventureTaskBase.Id);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("type: ", num);
		instance3.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
	}

	// Token: 0x060078B2 RID: 30898 RVA: 0x00255CE0 File Offset: 0x00253EE0
	private void ProcessDisposableChallengeTabOpen(int jumpParma)
	{
		if (AdventureGuideModel.Instance.CheckTargetDungeonTypeCanShow((EDungeonType)jumpParma))
		{
			AdventureGuideController.Instance.OpenGuideView(new EUiTabViewName?(EUiTabViewName.DisposableChallengeView), new int?(jumpParma), null, null);
			return;
		}
		AdventureGuideConfig instance = AdventureGuideConfig.Instance;
		SecondaryGuideData? secondaryGuideData;
		int valueOrDefault = ((instance != null) ? ((instance.GetSecondaryGuideDataConf(jumpParma) != null) ? new int?(secondaryGuideData.GetValueOrDefault().ConditionGroupId) : null) : null).GetValueOrDefault();
		if (valueOrDefault <= 0)
		{
			GenericPromptController.Instance.ShowPromptByCode("NotOpen", Array.Empty<object>());
			return;
		}
		ConditionGroup? config = ConfigConditionGroupById.GetConfig(valueOrDefault, true);
		string text = (config != null) ? config.GetValueOrDefault().HintText : null;
		if (text != null && !StringUtils.IsEmpty(text))
		{
			string text2 = ConfigMultiTextLang.GetLocalTextNew(text, null) ?? "";
			GenericPromptController.Instance.ShowPromptByCode("UnlockCondition", new object[]
			{
				text2
			});
			return;
		}
		GenericPromptController.Instance.ShowPromptByCode("NotOpen", Array.Empty<object>());
	}

	// Token: 0x04004B34 RID: 19252
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<CommonItemSmallItemGrid, TItem> Layout;

	// Token: 0x04004B35 RID: 19253
	public int AdventureId;

	// Token: 0x04004B36 RID: 19254
	[Nullable(2)]
	private AdventureTaskRecord Data;

	// Token: 0x04004B37 RID: 19255
	[Nullable(2)]
	private UUIExtendToggle ExtendToggle;

	// Token: 0x04004B38 RID: 19256
	[Nullable(2)]
	private Action<int> ClickGetButtonCb;

	// Token: 0x04004B39 RID: 19257
	private bool Clicking;

	// Token: 0x02006DF1 RID: 28145
	[NullableContext(0)]
	private enum EAdventureItemNode
	{
		// Token: 0x04024036 RID: 147510
		ItemText,
		// Token: 0x04024037 RID: 147511
		RewardItem,
		// Token: 0x04024038 RID: 147512
		RedirectBtn,
		// Token: 0x04024039 RID: 147513
		RewardLayout,
		// Token: 0x0402403A RID: 147514
		RedPointItem,
		// Token: 0x0402403B RID: 147515
		ProgressText,
		// Token: 0x0402403C RID: 147516
		RewardScroll,
		// Token: 0x0402403D RID: 147517
		DoingText,
		// Token: 0x0402403E RID: 147518
		FinishItem,
		// Token: 0x0402403F RID: 147519
		GetButton,
		// Token: 0x04024040 RID: 147520
		TextureActiveBg,
		// Token: 0x04024041 RID: 147521
		TextureDoneBg,
		// Token: 0x04024042 RID: 147522
		ContentItem
	}
}

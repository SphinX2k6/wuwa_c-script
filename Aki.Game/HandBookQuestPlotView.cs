using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Quest;
using Aki.TDConfigMgr.Quest.Fb;
using Aki.UniverseEditor.Interface.Fbs.Quest;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Plot.Flow;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.FlatBuffers;
using UnrealEngine;

// Token: 0x020012E8 RID: 4840
[NullableContext(1)]
[Nullable(0)]
public class HandBookQuestPlotView : UiViewBase
{
	// Token: 0x170012AF RID: 4783
	// (get) Token: 0x0600BE9D RID: 48797 RVA: 0x003838C8 File Offset: 0x00381AC8
	private CacheLru<int, Aki.TDConfigMgr.Quest.IPlotHandBookItem> PlotHandBookFbLru
	{
		get
		{
			CacheLru<int, Aki.TDConfigMgr.Quest.IPlotHandBookItem> result;
			if ((result = this.PlotHandBookFbLruInternal) == null)
			{
				result = (this.PlotHandBookFbLruInternal = new CacheLru<int, Aki.TDConfigMgr.Quest.IPlotHandBookItem>(50, new Func<int, Aki.TDConfigMgr.Quest.IPlotHandBookItem>(this.LoadPlotHandBookFromFb)));
			}
			return result;
		}
	}

	// Token: 0x0600BE9E RID: 48798 RVA: 0x003838FC File Offset: 0x00381AFC
	[NullableContext(2)]
	private Aki.TDConfigMgr.Quest.IPlotHandBookItem LoadPlotHandBookFromFb(int questId)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(52, 2);
		defaultInterpolatedStringHandler.AppendFormatted(UBlueprintPathsLibrary.ProjectContentDir());
		defaultInterpolatedStringHandler.AppendLiteral("Aki/Config/UniverseEditorConfig/PlotHandBooks/");
		defaultInterpolatedStringHandler.AppendFormatted<int>(questId);
		defaultInterpolatedStringHandler.AppendLiteral(".bytes");
		ByteBuffer byteBuffer = FbFileLoader.LoadBytes(defaultInterpolatedStringHandler.ToStringAndClear());
		if (byteBuffer == null)
		{
			return null;
		}
		return Aki.TDConfigMgr.Quest.IPlotHandBookItem.Create(Aki.TDConfigMgr.Quest.Fb.IPlotHandBookItem.Create(new Aki.UniverseEditor.Interface.Fbs.Quest.IPlotHandBookItem?(Aki.UniverseEditor.Interface.Fbs.Quest.IPlotHandBookItem.GetRootAsIPlotHandBookItem(byteBuffer))));
	}

	// Token: 0x0600BE9F RID: 48799 RVA: 0x00383968 File Offset: 0x00381B68
	public HandBookQuestPlotView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600BEA0 RID: 48800 RVA: 0x003839D4 File Offset: 0x00381BD4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIDynScrollViewComponent)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(6, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(7, typeof(UUIText)),
			new ValueTuple<int, Type>(8, typeof(UUIDynScrollViewComponent))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(5, new Action(this.OnClickLeftBtn)),
			new ValueTuple<int, Delegate>(6, new Action(this.OnClickRightBtn))
		};
	}

	// Token: 0x0600BEA1 RID: 48801 RVA: 0x00383AF0 File Offset: 0x00381CF0
	protected override UniTask OnBeforeStartAsync()
	{
		HandBookQuestPlotView.<OnBeforeStartAsync>d__24 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<HandBookQuestPlotView.<OnBeforeStartAsync>d__24>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600BEA2 RID: 48802 RVA: 0x00383B34 File Offset: 0x00381D34
	protected override void OnStart()
	{
		this.TalkTagString = (ConfigMultiTextLang.GetLocalTextNew("ColonTag", null) ?? "");
		this.TalkTagString += " ";
		this.PopupCaptionItem = new PopupCaptionItem(base.GetItem(0));
		this.PopupCaptionItem.SetCloseCallBack(new Action(this.OnBtnCloseClick));
		this.PopupCaptionItem.SetHelpBtnActive(false);
		HandBookQuestViewOpenParam handBookQuestViewOpenParam = this.OpenParam as HandBookQuestViewOpenParam;
		this.ConfigIdList = handBookQuestViewOpenParam.ConfigIdList;
		this.CurrentSelectIndex = handBookQuestViewOpenParam.Index;
		this.RefreshView();
	}

	// Token: 0x0600BEA3 RID: 48803 RVA: 0x00383BD0 File Offset: 0x00381DD0
	protected override void OnBeforeDestroy()
	{
		EventSystem.Instance.Emit<int>(EEventName.OnPhotoSelect, this.ConfigIdList[this.CurrentSelectIndex]);
		HandBookQuestPlotTalkAudioUtil.ClearCurPlayAudio();
	}

	// Token: 0x0600BEA4 RID: 48804 RVA: 0x00383BF4 File Offset: 0x00381DF4
	private void RefreshView()
	{
		int[] configIdList = this.ConfigIdList;
		int num = (configIdList != null) ? configIdList.Length : 0;
		if (this.CurrentSelectIndex >= num || this.CurrentSelectIndex < 0)
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.HandBook;
			ELogAuthor author = ELogAuthor.LJQ;
			string message = "HandBookPlot_剧情图鉴选择任务出错";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("index:", this.CurrentSelectIndex);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		UUIButtonComponent button = base.GetButton(5);
		if (button != null)
		{
			button.RootUIComp.Get().SetUIActive(this.CurrentSelectIndex > 0);
		}
		UUIButtonComponent button2 = base.GetButton(6);
		if (button2 != null)
		{
			button2.RootUIComp.Get().SetUIActive(this.CurrentSelectIndex + 1 < num);
		}
		int id = this.ConfigIdList[this.CurrentSelectIndex];
		PhotographHandBook? plotHandBookConfig = HandBookConfig.Instance.GetPlotHandBookConfig(id);
		if (plotHandBookConfig == null)
		{
			return;
		}
		HandBookEntry handBookInfo = HandBookModel.Instance.GetHandBookInfo((EHandBookTabType)plotHandBookConfig.Value.Type, id);
		if (handBookInfo == null || !handBookInfo.IsRead)
		{
			int type = plotHandBookConfig.Value.Type;
			PlotType? plotType;
			int? num2 = (HandBookConfig.Instance.GetPlotTypeConfig(type) != null) ? new int?(plotType.GetValueOrDefault().Type) : null;
			HandBookController.Instance.SendIllustratedReadRequest((EHandBookTabType)num2.Value, id);
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(7), plotHandBookConfig.Value.Descrtption, Array.Empty<object>());
		Aki.TDConfigMgr.Quest.IQuest questConfig = QuestNewModel.Instance.GetQuestConfig(plotHandBookConfig.Value.QuestId);
		string title = (!string.IsNullOrEmpty((questConfig != null) ? questConfig.TidName : null)) ? PublicUtil.Instance.GetConfigTextByKey(questConfig.TidName) : "";
		this.PopupCaptionItem.SetTitle(title);
		PlotType? plotTypeConfig = HandBookConfig.Instance.GetPlotTypeConfig(plotHandBookConfig.Value.Type);
		HandBookQuestTab? questTab = HandBookConfig.Instance.GetQuestTab(plotTypeConfig.Value.Type);
		this.PopupCaptionItem.SetTitleIcon(questTab.Value.Icon);
		List<Aki.TDConfigMgr.Quest.IPlotHandBookNode> list = new List<Aki.TDConfigMgr.Quest.IPlotHandBookNode>();
		foreach (int num3 in plotHandBookConfig.Value.ShowQuestList())
		{
			Aki.TDConfigMgr.Quest.IPlotHandBookItem plotHandBookItem = this.PlotHandBookFbLru.Get(num3);
			if (plotHandBookItem == null)
			{
				global::Log instance2 = global::Log.Instance;
				ELogModule module2 = ELogModule.HandBook;
				ELogAuthor author2 = ELogAuthor.LJQ;
				string message2 = "HandBookPlot_剧情图鉴获取任务对应剧情配置出错";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("questId:", num3);
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return;
			}
			if (plotHandBookItem.Nodes != null)
			{
				list.AddRange(plotHandBookItem.Nodes);
			}
		}
		this.NodeToTidMap.Clear();
		this.NodeTextList = new List<string>();
		string text = "";
		foreach (Aki.TDConfigMgr.Quest.IPlotHandBookNode plotHandBookNode in list)
		{
			string text2 = plotHandBookNode.IsHideUi ? "" : plotHandBookNode.TidTip;
			List<Aki.TDConfigMgr.Quest.IPlotHandBookNode> list5;
			if (text2 == "")
			{
				if (text == "")
				{
					string text3 = ((questConfig != null) ? questConfig.TidName : null) ?? "";
					List<Aki.TDConfigMgr.Quest.IPlotHandBookNode> list2;
					if (!this.NodeToTidMap.TryGetValue(text3, out list2))
					{
						list2 = new List<Aki.TDConfigMgr.Quest.IPlotHandBookNode>();
						list2.Add(plotHandBookNode);
						text = text3;
						this.NodeToTidMap[text3] = list2;
						continue;
					}
				}
				List<Aki.TDConfigMgr.Quest.IPlotHandBookNode> list3;
				if (this.NodeToTidMap.TryGetValue(text, out list3))
				{
					list3.Add(plotHandBookNode);
				}
			}
			else if (text != "" && text2 != "" && PublicUtil.Instance.GetConfigTextByKey(text) == PublicUtil.Instance.GetConfigTextByKey(text2))
			{
				List<Aki.TDConfigMgr.Quest.IPlotHandBookNode> list4;
				if (this.NodeToTidMap.TryGetValue(text, out list4))
				{
					list4.Add(plotHandBookNode);
				}
			}
			else if (!this.NodeToTidMap.TryGetValue(text2, out list5))
			{
				list5 = new List<Aki.TDConfigMgr.Quest.IPlotHandBookNode>();
				list5.Add(plotHandBookNode);
				text = text2;
				this.NodeToTidMap[text2] = list5;
			}
			else
			{
				list5.Add(plotHandBookNode);
			}
		}
		List<HandBookQuestDynamicData> list6 = new List<HandBookQuestDynamicData>();
		foreach (string text4 in this.NodeToTidMap.Keys)
		{
			list6.Add(new HandBookQuestDynamicData
			{
				TidText = text4
			});
			this.NodeTextList.Add(text4);
		}
		this.NodeScrollView.RefreshByData(list6.ToArray(), false, false);
		string tidText = list6[0].TidText;
		this.RefreshByTidText(false, tidText);
	}

	// Token: 0x0600BEA5 RID: 48805 RVA: 0x00384108 File Offset: 0x00382308
	private HandBookQuestPlotItem CreateNodeGrid(HandBookQuestDynamicData data, UUIItem uiItem, int index)
	{
		HandBookQuestPlotItem handBookQuestPlotItem = new HandBookQuestPlotItem();
		handBookQuestPlotItem.BindClickCallback(new TSelectedCallback(this.OnClickNodeItem));
		handBookQuestPlotItem.BindIsSelectFunction(new TSelectFunction(this.IsNodeSelect));
		return handBookQuestPlotItem;
	}

	// Token: 0x0600BEA6 RID: 48806 RVA: 0x00384133 File Offset: 0x00382333
	private HandBookQuestPlotList CreatePlotGrid(HandBookPlotDynamicData data, UUIItem uiItem, int index)
	{
		HandBookQuestPlotList handBookQuestPlotList = new HandBookQuestPlotList();
		handBookQuestPlotList.BindClickOptionToggleBack(new TSelectedOpenCallback(this.OnClickOption));
		handBookQuestPlotList.BindOnRefreshNode(new TRefreshNode(this.OnNodeSelectRefresh));
		return handBookQuestPlotList;
	}

	// Token: 0x0600BEA7 RID: 48807 RVA: 0x0038415E File Offset: 0x0038235E
	private void OnBtnCloseClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600BEA8 RID: 48808 RVA: 0x00384168 File Offset: 0x00382368
	private void OnClickNodeItem(string tidText, [Nullable(2)] UUIExtendToggle toggle = null)
	{
		if (this.IsClickNodeItemWaitScroll)
		{
			return;
		}
		int index = 0;
		int count = this.HandBookPlotDynamicDataList.Count;
		for (int i = 0; i < count; i++)
		{
			if (this.HandBookPlotDynamicDataList[i].NodeText == tidText)
			{
				index = i;
			}
		}
		this.OnNodeSelectRefresh(tidText);
		this.IsClickNodeItemWaitScroll = true;
		if (Info.Instance.IsInGamepad())
		{
			DynamicScrollView<HandBookQuestPlotList, HandBootPlotDynamicItem, HandBookPlotDynamicData> plotListScrollView = this.PlotListScrollView;
			if (plotListScrollView != null)
			{
				plotListScrollView.ScrollToItemIndexByOffset(index);
			}
		}
		else
		{
			DynamicScrollView<HandBookQuestPlotList, HandBootPlotDynamicItem, HandBookPlotDynamicData> plotListScrollView2 = this.PlotListScrollView;
			if (plotListScrollView2 != null)
			{
				plotListScrollView2.ScrollToItemIndex(index, true, false);
			}
		}
		DynamicScrollView<HandBookQuestPlotList, HandBootPlotDynamicItem, HandBookPlotDynamicData> plotListScrollView3 = this.PlotListScrollView;
		if (plotListScrollView3 == null)
		{
			return;
		}
		plotListScrollView3.BindLateUpdate(delegate(float deltaTime)
		{
			this.IsClickNodeItemWaitScroll = false;
			DynamicScrollView<HandBookQuestPlotList, HandBootPlotDynamicItem, HandBookPlotDynamicData> plotListScrollView4 = this.PlotListScrollView;
			if (plotListScrollView4 == null)
			{
				return;
			}
			plotListScrollView4.UnBindLateUpdate();
		});
	}

	// Token: 0x0600BEA9 RID: 48809 RVA: 0x00384214 File Offset: 0x00382414
	[NullableContext(2)]
	private void RefreshByTidText(bool keepPosition = true, string tidText = null)
	{
		this.HandBookPlotDynamicDataList = new List<HandBookPlotDynamicData>();
		this.HandlePlotList();
		DynamicScrollView<HandBookQuestPlotList, HandBootPlotDynamicItem, HandBookPlotDynamicData> plotListScrollView = this.PlotListScrollView;
		if (plotListScrollView != null)
		{
			plotListScrollView.RefreshByData(this.HandBookPlotDynamicDataList.ToArray(), keepPosition, false);
		}
		this.IsRefreshingView = true;
		DynamicScrollView<HandBookQuestPlotList, HandBootPlotDynamicItem, HandBookPlotDynamicData> plotListScrollView2 = this.PlotListScrollView;
		if (plotListScrollView2 == null)
		{
			return;
		}
		plotListScrollView2.BindLateUpdate(delegate(float deltaTime)
		{
			this.IsRefreshingView = false;
			if (!string.IsNullOrEmpty(tidText))
			{
				this.OnNodeSelectRefresh(tidText);
			}
			this.LateUpdate();
		});
	}

	// Token: 0x0600BEAA RID: 48810 RVA: 0x00384288 File Offset: 0x00382488
	private void HandlePlotList()
	{
		int num = 0;
		foreach (KeyValuePair<string, List<Aki.TDConfigMgr.Quest.IPlotHandBookNode>> keyValuePair in this.NodeToTidMap)
		{
			string key = keyValuePair.Key;
			List<Aki.TDConfigMgr.Quest.IPlotHandBookNode> value = keyValuePair.Value;
			HandBookPlotDynamicData handBookPlotDynamicData = new HandBookPlotDynamicData();
			handBookPlotDynamicData.NodeText = key;
			handBookPlotDynamicData.BelongToNode = key;
			this.HandBookPlotDynamicDataList.Add(handBookPlotDynamicData);
			foreach (Aki.TDConfigMgr.Quest.IPlotHandBookNode plotHandBookNode in value)
			{
				if (!string.IsNullOrEmpty(plotHandBookNode.Flow.FlowListName))
				{
					List<ActionInfo> flowStateActions = FlowConfig.Instance.GetFlowStateActions(plotHandBookNode.Flow.FlowListName, plotHandBookNode.Flow.FlowId, plotHandBookNode.Flow.StateId);
					if (flowStateActions != null)
					{
						this.HandlePlotActions(flowStateActions, num++, key);
					}
				}
			}
		}
	}

	// Token: 0x0600BEAB RID: 48811 RVA: 0x0038439C File Offset: 0x0038259C
	private void HandlePlotActions(List<ActionInfo> plotActions, int flowIndex, string tidText)
	{
		this.JumpToTalkId = 0;
		foreach (ActionInfo actionInfo in plotActions)
		{
			if (actionInfo.Name != EAction.PlayMovie && actionInfo.Name == EAction.ShowTalk)
			{
				List<ITalkItem> talkItems = ((ShowTalk)actionInfo.Params).TalkItems;
				int num = 0;
				this.TalkItemMap.Clear();
				foreach (ITalkItem talkItem in talkItems)
				{
					this.TalkItemMap[talkItem.Id] = num++;
					if (this.JumpToTalkId < 0)
					{
						return;
					}
					if (this.JumpToTalkId != 0)
					{
						int? num2 = null;
						int value;
						if (this.TalkItemMap.TryGetValue(this.JumpToTalkId, out value))
						{
							num2 = new int?(value);
						}
						int num3 = this.TalkItemMap[talkItem.Id];
						if (num2 == null)
						{
							continue;
						}
						int? num4 = num2;
						int num5 = num3;
						if (num4.GetValueOrDefault() > num5 & num4 != null)
						{
							continue;
						}
					}
					if (talkItem.Type.GetValueOrDefault() != ETalkItemType.QTE)
					{
						if (talkItem.Type.GetValueOrDefault() == ETalkItemType.NoTextItem)
						{
							if (talkItem.Actions != null && this.HandleChildAction(talkItem.Actions, talkItem.Id))
							{
								return;
							}
						}
						else
						{
							this.JumpToTalkId = 0;
							if (talkItem.WhoId == null)
							{
								goto IL_186;
							}
							int? num4 = talkItem.WhoId;
							int num5 = 0;
							if (num4.GetValueOrDefault() == num5 & num4 != null)
							{
								goto IL_186;
							}
							goto IL_197;
							IL_2DC:
							if (talkItem.Options != null && talkItem.Options.Count > 0)
							{
								int num6 = 0;
								Dictionary<int, int> dictionary;
								int num7;
								if (this.OptionChose.TryGetValue(flowIndex, out dictionary) && dictionary.TryGetValue(talkItem.Id, out num7))
								{
									num6 = num7;
								}
								ITalkOption talkOption = talkItem.Options[num6];
								this.HandleChildAction(talkOption.Actions, talkItem.Id);
								this.HandleOptions(talkItem.Options, num6, tidText, flowIndex, talkItem.Id);
							}
							if (talkItem.Actions != null && this.HandleChildAction(talkItem.Actions, talkItem.Id))
							{
								return;
							}
							continue;
							IL_197:
							if (talkItem.Type.GetValueOrDefault() != ETalkItemType.Option)
							{
								HandBookPlotDynamicData handBookPlotDynamicData = new HandBookPlotDynamicData();
								handBookPlotDynamicData.BelongToNode = tidText;
								Speaker? speaker = (talkItem.WhoId != null) ? ConfigSpeakerById.GetConfig(talkItem.WhoId.Value, true) : null;
								string text = "";
								if (speaker != null)
								{
									text = (PublicUtil.Instance.GetConfigTextByTable(ETableText.SpeakerName, new int?(speaker.Value.Id)) ?? "");
								}
								if (text != " " && text != "")
								{
									text += this.TalkTagString;
								}
								handBookPlotDynamicData.TalkOwnerName = text;
								if (talkItem.PlayVoice != null && talkItem.PlayVoice.Value)
								{
									PlotAudio? config = ConfigPlotAudioById.GetConfig(talkItem.TidTalk, true);
									handBookPlotDynamicData.PlotAudio = config;
								}
								string flowConfigLocalText = PublicUtil.Instance.GetFlowConfigLocalText(talkItem.TidTalk);
								handBookPlotDynamicData.TalkText = flowConfigLocalText;
								handBookPlotDynamicData.PlotId = flowIndex;
								handBookPlotDynamicData.TalkItemId = talkItem.Id;
								this.HandBookPlotDynamicDataList.Add(handBookPlotDynamicData);
								goto IL_2DC;
							}
							goto IL_2DC;
							IL_186:
							if (!string.IsNullOrEmpty(talkItem.TidTalk))
							{
								goto IL_197;
							}
							goto IL_2DC;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BEAC RID: 48812 RVA: 0x00384790 File Offset: 0x00382990
	private bool HandleChildAction([Nullable(new byte[]
	{
		2,
		1
	})] List<ActionInfo> actions, int talkItemId)
	{
		if (actions == null)
		{
			return false;
		}
		foreach (ActionInfo actionInfo in actions)
		{
			if (actionInfo.Name == EAction.FinishTalk || actionInfo.Name == EAction.FinishState)
			{
				return true;
			}
			if (actionInfo.Name == EAction.JumpTalk)
			{
				int talkId = ((JumpTalk)actionInfo.Params).TalkId;
				int? num = null;
				int value;
				if (this.TalkItemMap.TryGetValue(talkId, out value))
				{
					num = new int?(value);
				}
				int num2 = this.TalkItemMap[talkItemId];
				if (num != null && num.Value <= num2)
				{
					this.JumpToTalkId = -1;
					break;
				}
				this.JumpToTalkId = talkId;
			}
		}
		return false;
	}

	// Token: 0x0600BEAD RID: 48813 RVA: 0x00384870 File Offset: 0x00382A70
	private void HandleOptions(List<ITalkOption> options, int choseIndex, string tidText, int flowIndex, int talkItemId)
	{
		HandBookPlotDynamicData handBookPlotDynamicData = new HandBookPlotDynamicData();
		handBookPlotDynamicData.BelongToNode = tidText;
		handBookPlotDynamicData.OptionTalker = new bool?(true);
		this.HandBookPlotDynamicDataList.Add(handBookPlotDynamicData);
		for (int i = 0; i < options.Count; i++)
		{
			ITalkOption talkOption = options[i];
			HandBookPlotDynamicData handBookPlotDynamicData2 = new HandBookPlotDynamicData();
			handBookPlotDynamicData2.BelongToNode = tidText;
			handBookPlotDynamicData2.OptionIndex = new int?(i);
			handBookPlotDynamicData2.TalkOption = talkOption;
			handBookPlotDynamicData2.IsChoseOption = new bool?(choseIndex == i);
			handBookPlotDynamicData2.PlotId = flowIndex;
			handBookPlotDynamicData2.TalkItemId = talkItemId;
			this.HandBookPlotDynamicDataList.Add(handBookPlotDynamicData2);
		}
	}

	// Token: 0x0600BEAE RID: 48814 RVA: 0x00384908 File Offset: 0x00382B08
	private void LateUpdate()
	{
		if (this.NavigationFocusData.Count > 0)
		{
			DynamicScrollView<HandBookQuestPlotList, HandBootPlotDynamicItem, HandBookPlotDynamicData> plotListScrollView = this.PlotListScrollView;
			HandBookQuestPlotList[] array = (plotListScrollView != null) ? plotListScrollView.GetScrollItemItems() : null;
			if (array != null)
			{
				HandBookQuestPlotList[] array2 = array;
				for (int i = 0; i < array2.Length; i++)
				{
					HandBookQuestPlotList data = array2[i];
					HandBookPlotDynamicData optionData = data.OptionData;
					if (((optionData != null) ? optionData.TalkOption : null) != null)
					{
						HandBookPlotDynamicData optionData2 = data.OptionData;
						int? num = (optionData2 != null) ? new int?(optionData2.PlotId) : null;
						int num2 = this.NavigationFocusData[0];
						if (num.GetValueOrDefault() == num2 & num != null)
						{
							HandBookPlotDynamicData optionData3 = data.OptionData;
							num = ((optionData3 != null) ? new int?(optionData3.TalkItemId) : null);
							num2 = this.NavigationFocusData[1];
							if (num.GetValueOrDefault() == num2 & num != null)
							{
								HandBookPlotDynamicData optionData4 = data.OptionData;
								num = ((optionData4 != null) ? optionData4.OptionIndex : null);
								num2 = this.NavigationFocusData[2];
								if (num.GetValueOrDefault() == num2 & num != null)
								{
									TimerSystem.Instance.Next(delegate(float _)
									{
										UiNavigationNewController.Instance.SetNavigationFocusForView(data.GetOptionToggle().GetRootComponent(), false, false, false);
									}, null, null);
									this.NavigationFocusData = new List<int>();
									return;
								}
							}
						}
					}
				}
				return;
			}
		}
		else
		{
			DynamicScrollView<HandBookQuestPlotList, HandBootPlotDynamicItem, HandBookPlotDynamicData> plotListScrollView2 = this.PlotListScrollView;
			if (plotListScrollView2 == null)
			{
				return;
			}
			plotListScrollView2.UnBindLateUpdate();
		}
	}

	// Token: 0x0600BEAF RID: 48815 RVA: 0x00384A94 File Offset: 0x00382C94
	private void OnClickOption(int plotId, int talkItemId, int optionIndex, UUIExtendToggle toggle)
	{
		Dictionary<int, int> dictionary;
		if (!this.OptionChose.TryGetValue(plotId, out dictionary))
		{
			dictionary = new Dictionary<int, int>();
			dictionary[talkItemId] = optionIndex;
		}
		else
		{
			dictionary[talkItemId] = optionIndex;
		}
		this.OptionChose[plotId] = dictionary;
		this.NavigationFocusData = new List<int>
		{
			plotId,
			talkItemId,
			optionIndex
		};
		DynamicScrollView<HandBookQuestPlotList, HandBootPlotDynamicItem, HandBookPlotDynamicData> plotListScrollView = this.PlotListScrollView;
		this.NeedScrollIndex = ((plotListScrollView != null) ? plotListScrollView.GetDisplayGridStartIndex() : 0);
		this.RefreshByTidText(true, null);
		HandBookQuestPlotTalkAudioUtil.ClearCurPlayAudio();
	}

	// Token: 0x0600BEB0 RID: 48816 RVA: 0x00384B1B File Offset: 0x00382D1B
	private void OnClickLeftBtn()
	{
		HandBookQuestPlotTalkAudioUtil.ClearCurPlayAudio();
		this.CurrentSelectIndex--;
		this.OptionChose.Clear();
		this.RefreshView();
	}

	// Token: 0x0600BEB1 RID: 48817 RVA: 0x00384B41 File Offset: 0x00382D41
	private void OnClickRightBtn()
	{
		HandBookQuestPlotTalkAudioUtil.ClearCurPlayAudio();
		this.CurrentSelectIndex++;
		this.OptionChose.Clear();
		this.RefreshView();
	}

	// Token: 0x0600BEB2 RID: 48818 RVA: 0x00384B68 File Offset: 0x00382D68
	private void OnNodeSelectRefresh(string tidText)
	{
		if (this.IsClickNodeItemWaitScroll)
		{
			return;
		}
		if (this.SelectNodeText == tidText || this.IsRefreshingView)
		{
			return;
		}
		this.SelectNodeText = tidText;
		HandBookQuestPlotItem[] scrollItemItems = this.NodeScrollView.GetScrollItemItems();
		bool flag = false;
		foreach (HandBookQuestPlotItem handBookQuestPlotItem in scrollItemItems)
		{
			if (((handBookQuestPlotItem != null) ? handBookQuestPlotItem.GetTidText() : null) == tidText)
			{
				handBookQuestPlotItem.SetToggleState(EToggleState.ETT_Checked);
				UiNavigationNewController.Instance.SetNavigationFocusForViewSameGroup(handBookQuestPlotItem.GetToggleItem().GetRootComponent());
				flag = true;
			}
			else
			{
				handBookQuestPlotItem.SetToggleState(EToggleState.ETT_UnChecked);
			}
		}
		if (flag)
		{
			return;
		}
		int num = 0;
		using (Dictionary<string, List<Aki.TDConfigMgr.Quest.IPlotHandBookNode>>.KeyCollection.Enumerator enumerator = this.NodeToTidMap.Keys.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current == tidText)
				{
					break;
				}
				num++;
			}
		}
		DynamicScrollView<HandBookQuestPlotItem, HandBootQuestDynamicItem, HandBookQuestDynamicData> nodeScrollView = this.NodeScrollView;
		if (nodeScrollView == null)
		{
			return;
		}
		nodeScrollView.ScrollToItemIndex(num, true, false).ContinueWith(delegate()
		{
			DynamicScrollView<HandBookQuestPlotItem, HandBootQuestDynamicItem, HandBookQuestDynamicData> nodeScrollView2 = this.NodeScrollView;
			if (nodeScrollView2 == null)
			{
				return;
			}
			HandBookQuestPlotItem scrollItemFromIndex = nodeScrollView2.GetScrollItemFromIndex(0);
			if (scrollItemFromIndex == null)
			{
				return;
			}
			scrollItemFromIndex.SetToggleState(EToggleState.ETT_Checked);
		});
	}

	// Token: 0x0600BEB3 RID: 48819 RVA: 0x00384C7C File Offset: 0x00382E7C
	private bool IsNodeSelect(string tidText)
	{
		return this.SelectNodeText == tidText;
	}

	// Token: 0x04006DBB RID: 28091
	[Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})]
	protected DynamicScrollView<HandBookQuestPlotItem, HandBootQuestDynamicItem, HandBookQuestDynamicData> NodeScrollView;

	// Token: 0x04006DBC RID: 28092
	[Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})]
	protected DynamicScrollView<HandBookQuestPlotList, HandBootPlotDynamicItem, HandBookPlotDynamicData> PlotListScrollView;

	// Token: 0x04006DBD RID: 28093
	[Nullable(2)]
	private PopupCaptionItem PopupCaptionItem;

	// Token: 0x04006DBE RID: 28094
	[Nullable(2)]
	private HandBootQuestDynamicItem HandBookQuestBaseItem;

	// Token: 0x04006DBF RID: 28095
	[Nullable(2)]
	private HandBootPlotDynamicItem HandBookPlotBaseItem;

	// Token: 0x04006DC0 RID: 28096
	private List<HandBookPlotDynamicData> HandBookPlotDynamicDataList = new List<HandBookPlotDynamicData>();

	// Token: 0x04006DC1 RID: 28097
	private readonly Dictionary<int, Dictionary<int, int>> OptionChose = new Dictionary<int, Dictionary<int, int>>();

	// Token: 0x04006DC2 RID: 28098
	[Nullable(2)]
	private int[] ConfigIdList;

	// Token: 0x04006DC3 RID: 28099
	private int CurrentSelectIndex;

	// Token: 0x04006DC4 RID: 28100
	public int NeedScrollIndex;

	// Token: 0x04006DC5 RID: 28101
	private int JumpToTalkId;

	// Token: 0x04006DC6 RID: 28102
	private bool IsClickNodeItemWaitScroll;

	// Token: 0x04006DC7 RID: 28103
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private CacheLru<int, Aki.TDConfigMgr.Quest.IPlotHandBookItem> PlotHandBookFbLruInternal;

	// Token: 0x04006DC8 RID: 28104
	private string SelectNodeText = "";

	// Token: 0x04006DC9 RID: 28105
	private bool IsRefreshingView;

	// Token: 0x04006DCA RID: 28106
	private string TalkTagString = "";

	// Token: 0x04006DCB RID: 28107
	private readonly Dictionary<string, List<Aki.TDConfigMgr.Quest.IPlotHandBookNode>> NodeToTidMap = new Dictionary<string, List<Aki.TDConfigMgr.Quest.IPlotHandBookNode>>();

	// Token: 0x04006DCC RID: 28108
	private List<string> NodeTextList = new List<string>();

	// Token: 0x04006DCD RID: 28109
	private readonly Dictionary<int, int> TalkItemMap = new Dictionary<int, int>();

	// Token: 0x04006DCE RID: 28110
	private List<int> NavigationFocusData = new List<int>();

	// Token: 0x02007558 RID: 30040
	[NullableContext(0)]
	private class EChildType
	{
		// Token: 0x040261CF RID: 156111
		public const int TitleItem = 0;

		// Token: 0x040261D0 RID: 156112
		public const int NodeScrollView = 1;

		// Token: 0x040261D1 RID: 156113
		public const int ScrollViewItem = 2;

		// Token: 0x040261D2 RID: 156114
		public const int PlotContent = 3;

		// Token: 0x040261D3 RID: 156115
		public const int PlotItem = 4;

		// Token: 0x040261D4 RID: 156116
		public const int LeftBtn = 5;

		// Token: 0x040261D5 RID: 156117
		public const int RightBtn = 6;

		// Token: 0x040261D6 RID: 156118
		public const int PlotNameText = 7;

		// Token: 0x040261D7 RID: 156119
		public const int PlotScrollView = 8;
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001E1A RID: 7706
[NullableContext(2)]
[Nullable(0)]
public class HandBookQuestPlotList : UiPanelBase, IDynamicScrollItem<HandBookPlotDynamicData>
{
	// Token: 0x0600EA4A RID: 59978 RVA: 0x003770B8 File Offset: 0x003752B8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem))
		};
	}

	// Token: 0x0600EA4B RID: 59979 RVA: 0x00377128 File Offset: 0x00375328
	[NullableContext(1)]
	public UniTask Init(UUIItem actor)
	{
		HandBookQuestPlotList.<Init>d__8 <Init>d__;
		<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Init>d__.<>4__this = this;
		<Init>d__.actor = actor;
		<Init>d__.<>1__state = -1;
		<Init>d__.<>t__builder.Start<HandBookQuestPlotList.<Init>d__8>(ref <Init>d__);
		return <Init>d__.<>t__builder.Task;
	}

	// Token: 0x0600EA4C RID: 59980 RVA: 0x00377174 File Offset: 0x00375374
	private UniTask InitChildItem()
	{
		HandBookQuestPlotList.<InitChildItem>d__9 <InitChildItem>d__;
		<InitChildItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitChildItem>d__.<>4__this = this;
		<InitChildItem>d__.<>1__state = -1;
		<InitChildItem>d__.<>t__builder.Start<HandBookQuestPlotList.<InitChildItem>d__9>(ref <InitChildItem>d__);
		return <InitChildItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600EA4D RID: 59981 RVA: 0x003771B8 File Offset: 0x003753B8
	[NullableContext(1)]
	[return: Nullable(2)]
	public AUIBaseActor GetUsingItem(HandBookPlotDynamicData data)
	{
		if (data.TalkOption != null)
		{
			return base.GetItem(1).GetOwner() as AUIBaseActor;
		}
		if (data.OptionTalker.GetValueOrDefault())
		{
			return base.GetItem(3).GetOwner() as AUIBaseActor;
		}
		if (!string.IsNullOrEmpty(data.NodeText))
		{
			return base.GetItem(2).GetOwner() as AUIBaseActor;
		}
		return base.GetItem(0).GetOwner() as AUIBaseActor;
	}

	// Token: 0x0600EA4E RID: 59982 RVA: 0x00377230 File Offset: 0x00375430
	[NullableContext(1)]
	public void Update(HandBookPlotDynamicData data, int index)
	{
		this.OptionData = data;
		HandBookQuestPlotTalkItem handBookQuestPlotTalkItem = this.HandBookQuestPlotTalkItem;
		if (handBookQuestPlotTalkItem != null)
		{
			handBookQuestPlotTalkItem.SetUiActive(false);
		}
		HandBookQuestPlotOption handBookQuestPlotOption = this.HandBookQuestPlotOption;
		if (handBookQuestPlotOption != null)
		{
			handBookQuestPlotOption.SetUiActive(false);
		}
		HandBookQuestPlotNode handBookQuestPlotNode = this.HandBookQuestPlotNode;
		if (handBookQuestPlotNode != null)
		{
			handBookQuestPlotNode.SetUiActive(false);
		}
		HandBookQuestPlotOptionTalker handBookQuestPlotOptionTalker = this.HandBookQuestPlotOptionTalker;
		if (handBookQuestPlotOptionTalker != null)
		{
			handBookQuestPlotOptionTalker.SetUiActive(false);
		}
		if (!string.IsNullOrEmpty(data.NodeText))
		{
			HandBookQuestPlotNode handBookQuestPlotNode2 = this.HandBookQuestPlotNode;
			if (handBookQuestPlotNode2 != null)
			{
				handBookQuestPlotNode2.SetUiActive(true);
			}
			HandBookQuestPlotNode handBookQuestPlotNode3 = this.HandBookQuestPlotNode;
			if (handBookQuestPlotNode3 != null)
			{
				handBookQuestPlotNode3.RefreshByNodeText(data.NodeText);
			}
		}
		else if (data.TalkOption != null)
		{
			HandBookQuestPlotOption handBookQuestPlotOption2 = this.HandBookQuestPlotOption;
			if (handBookQuestPlotOption2 != null)
			{
				handBookQuestPlotOption2.SetUiActive(true);
			}
			this.HandBookQuestPlotOption.RefreshByOption(data.TalkOption, data.PlotId, data.TalkItemId, data.OptionIndex.GetValueOrDefault(), data.IsChoseOption.GetValueOrDefault());
		}
		else if (data.OptionTalker.GetValueOrDefault())
		{
			HandBookQuestPlotOptionTalker handBookQuestPlotOptionTalker2 = this.HandBookQuestPlotOptionTalker;
			if (handBookQuestPlotOptionTalker2 != null)
			{
				handBookQuestPlotOptionTalker2.SetUiActive(true);
			}
			string playerName = FunctionModel.Instance.GetPlayerName();
			string str = ConfigMultiTextLang.GetLocalTextNew("ColonTag", null) ?? "";
			string title = (playerName != "") ? (playerName + str + " ") : "";
			HandBookQuestPlotOptionTalker handBookQuestPlotOptionTalker3 = this.HandBookQuestPlotOptionTalker;
			if (handBookQuestPlotOptionTalker3 != null)
			{
				handBookQuestPlotOptionTalker3.RefreshByText(title);
			}
		}
		else
		{
			HandBookQuestPlotTalkItem handBookQuestPlotTalkItem2 = this.HandBookQuestPlotTalkItem;
			if (handBookQuestPlotTalkItem2 != null)
			{
				handBookQuestPlotTalkItem2.SetUiActive(true);
			}
			this.HandBookQuestPlotTalkItem.Refresh(data.TalkOwnerName, data.TalkText, data.PlotAudio);
		}
		if (this.OnRefreshNode != null)
		{
			this.OnRefreshNode(data.BelongToNode);
		}
	}

	// Token: 0x0600EA4F RID: 59983 RVA: 0x003773D8 File Offset: 0x003755D8
	public void ClearItem()
	{
		base.Destroy(null);
	}

	// Token: 0x0600EA50 RID: 59984 RVA: 0x003773E1 File Offset: 0x003755E1
	[NullableContext(1)]
	public void BindClickOptionToggleBack(TSelectedOpenCallback onClickToggle)
	{
		this.OnClickOptionToggleBack = onClickToggle;
	}

	// Token: 0x0600EA51 RID: 59985 RVA: 0x003773EA File Offset: 0x003755EA
	[NullableContext(1)]
	public void BindOnRefreshNode(TRefreshNode func)
	{
		this.OnRefreshNode = func;
	}

	// Token: 0x0600EA52 RID: 59986 RVA: 0x003773F3 File Offset: 0x003755F3
	public UUIExtendToggle GetOptionToggle()
	{
		HandBookQuestPlotOption handBookQuestPlotOption = this.HandBookQuestPlotOption;
		if (handBookQuestPlotOption == null)
		{
			return null;
		}
		return handBookQuestPlotOption.Toggle;
	}

	// Token: 0x04006CB8 RID: 27832
	private HandBookQuestPlotTalkItem HandBookQuestPlotTalkItem;

	// Token: 0x04006CB9 RID: 27833
	private HandBookQuestPlotOption HandBookQuestPlotOption;

	// Token: 0x04006CBA RID: 27834
	private HandBookQuestPlotNode HandBookQuestPlotNode;

	// Token: 0x04006CBB RID: 27835
	private HandBookQuestPlotOptionTalker HandBookQuestPlotOptionTalker;

	// Token: 0x04006CBC RID: 27836
	private TSelectedOpenCallback OnClickOptionToggleBack;

	// Token: 0x04006CBD RID: 27837
	private TRefreshNode OnRefreshNode;

	// Token: 0x04006CBE RID: 27838
	public HandBookPlotDynamicData OptionData;
}

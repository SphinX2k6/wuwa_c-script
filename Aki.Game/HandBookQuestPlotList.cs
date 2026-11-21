using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020012DC RID: 4828
[NullableContext(2)]
[Nullable(0)]
public class HandBookQuestPlotList : UiPanelBase, IDynamicScrollItem<HandBookPlotDynamicData>
{
	// Token: 0x0600BE69 RID: 48745 RVA: 0x00382DC0 File Offset: 0x00380FC0
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

	// Token: 0x0600BE6A RID: 48746 RVA: 0x00382E30 File Offset: 0x00381030
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

	// Token: 0x0600BE6B RID: 48747 RVA: 0x00382E7C File Offset: 0x0038107C
	private UniTask InitChildItem()
	{
		HandBookQuestPlotList.<InitChildItem>d__9 <InitChildItem>d__;
		<InitChildItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitChildItem>d__.<>4__this = this;
		<InitChildItem>d__.<>1__state = -1;
		<InitChildItem>d__.<>t__builder.Start<HandBookQuestPlotList.<InitChildItem>d__9>(ref <InitChildItem>d__);
		return <InitChildItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600BE6C RID: 48748 RVA: 0x00382EC0 File Offset: 0x003810C0
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

	// Token: 0x0600BE6D RID: 48749 RVA: 0x00382F38 File Offset: 0x00381138
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

	// Token: 0x0600BE6E RID: 48750 RVA: 0x003830E0 File Offset: 0x003812E0
	public void ClearItem()
	{
		base.Destroy(null);
	}

	// Token: 0x0600BE6F RID: 48751 RVA: 0x003830E9 File Offset: 0x003812E9
	[NullableContext(1)]
	public void BindClickOptionToggleBack(TSelectedOpenCallback onClickToggle)
	{
		this.OnClickOptionToggleBack = onClickToggle;
	}

	// Token: 0x0600BE70 RID: 48752 RVA: 0x003830F2 File Offset: 0x003812F2
	[NullableContext(1)]
	public void BindOnRefreshNode(TRefreshNode func)
	{
		this.OnRefreshNode = func;
	}

	// Token: 0x0600BE71 RID: 48753 RVA: 0x003830FB File Offset: 0x003812FB
	public UUIExtendToggle GetOptionToggle()
	{
		HandBookQuestPlotOption handBookQuestPlotOption = this.HandBookQuestPlotOption;
		if (handBookQuestPlotOption == null)
		{
			return null;
		}
		return handBookQuestPlotOption.Toggle;
	}

	// Token: 0x04006D99 RID: 28057
	private HandBookQuestPlotTalkItem HandBookQuestPlotTalkItem;

	// Token: 0x04006D9A RID: 28058
	private HandBookQuestPlotOption HandBookQuestPlotOption;

	// Token: 0x04006D9B RID: 28059
	private HandBookQuestPlotNode HandBookQuestPlotNode;

	// Token: 0x04006D9C RID: 28060
	private HandBookQuestPlotOptionTalker HandBookQuestPlotOptionTalker;

	// Token: 0x04006D9D RID: 28061
	private TSelectedOpenCallback OnClickOptionToggleBack;

	// Token: 0x04006D9E RID: 28062
	private TRefreshNode OnRefreshNode;

	// Token: 0x04006D9F RID: 28063
	public HandBookPlotDynamicData OptionData;
}

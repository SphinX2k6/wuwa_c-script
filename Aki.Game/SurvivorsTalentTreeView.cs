using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002B54 RID: 11092
[NullableContext(2)]
[Nullable(0)]
public class SurvivorsTalentTreeView : UiViewBase
{
	// Token: 0x06017010 RID: 94224 RVA: 0x005D73E7 File Offset: 0x005D55E7
	[NullableContext(1)]
	public SurvivorsTalentTreeView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06017011 RID: 94225 RVA: 0x005D73F0 File Offset: 0x005D55F0
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem))
		};
	}

	// Token: 0x06017012 RID: 94226 RVA: 0x005D7478 File Offset: 0x005D5678
	protected override UniTask OnBeforeStartAsync()
	{
		SurvivorsTalentTreeView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<SurvivorsTalentTreeView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06017013 RID: 94227 RVA: 0x005D74BB File Offset: 0x005D56BB
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.SurvivorsRogueTalentNodeUpdate, new Action<int>(this.OnTalentNodeUpdate));
	}

	// Token: 0x06017014 RID: 94228 RVA: 0x005D74D9 File Offset: 0x005D56D9
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.SurvivorsRogueTalentNodeUpdate, new Action<int>(this.OnTalentNodeUpdate));
	}

	// Token: 0x06017015 RID: 94229 RVA: 0x005D74F8 File Offset: 0x005D56F8
	private void OnTalentNodeUpdate(int selectNodeId)
	{
		SurvivorsTalentTreeView.<>c__DisplayClass13_0 CS$<>8__locals1 = new SurvivorsTalentTreeView.<>c__DisplayClass13_0();
		CS$<>8__locals1.<>4__this = this;
		CS$<>8__locals1.selectNodeId = selectNodeId;
		new UiAsyncTask("TalentNodeUpdate", delegate()
		{
			SurvivorsTalentTreeView.<>c__DisplayClass13_0.<<OnTalentNodeUpdate>b__0>d <<OnTalentNodeUpdate>b__0>d;
			<<OnTalentNodeUpdate>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<<OnTalentNodeUpdate>b__0>d.<>4__this = CS$<>8__locals1;
			<<OnTalentNodeUpdate>b__0>d.<>1__state = -1;
			<<OnTalentNodeUpdate>b__0>d.<>t__builder.Start<SurvivorsTalentTreeView.<>c__DisplayClass13_0.<<OnTalentNodeUpdate>b__0>d>(ref <<OnTalentNodeUpdate>b__0>d);
			return <<OnTalentNodeUpdate>b__0>d.<>t__builder.Task;
		}, null).Run();
	}

	// Token: 0x06017016 RID: 94230 RVA: 0x005D7538 File Offset: 0x005D5738
	private UniTask OnNodeUpdateAsync(int selectNodeId)
	{
		SurvivorsTalentTreeView.<OnNodeUpdateAsync>d__14 <OnNodeUpdateAsync>d__;
		<OnNodeUpdateAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnNodeUpdateAsync>d__.<>4__this = this;
		<OnNodeUpdateAsync>d__.selectNodeId = selectNodeId;
		<OnNodeUpdateAsync>d__.<>1__state = -1;
		<OnNodeUpdateAsync>d__.<>t__builder.Start<SurvivorsTalentTreeView.<OnNodeUpdateAsync>d__14>(ref <OnNodeUpdateAsync>d__);
		return <OnNodeUpdateAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06017017 RID: 94231 RVA: 0x005D7583 File Offset: 0x005D5783
	protected override void OnBeforeShow()
	{
		SurvivorsActivityController.Instance.CheckIsActivityClose();
	}

	// Token: 0x06017018 RID: 94232 RVA: 0x005D7590 File Offset: 0x005D5790
	private void OnAfterRefreshOneNode(SurvivorsTalentTreeSkillNodeItem nodeItem)
	{
		SurvivorsActivityData activityData = SurvivorsRogueModel.Instance.ActivityData;
		if (activityData == null)
		{
			return;
		}
		if (nodeItem == null || nodeItem.Node == null)
		{
			return;
		}
		nodeItem.OnClickToggleBack = new Action<SurvivorsTalentNode, UUIExtendToggle>(this.OnClickNode);
		if (activityData.CurrentSelectNode.NodeId == this.FirstNodeItem.Node.NodeId && this.CurSelectNodeItem == null)
		{
			this.CurSelectNodeItem = this.FirstNodeItem;
			this.CurSelectNodeItem.SelectNode();
			return;
		}
		if (activityData.CurrentSelectNode.NodeId == nodeItem.Node.NodeId)
		{
			UUIItem itemByIndex = this.AreaScroll.GetItemByIndex(nodeItem.Node.AreaId - 1);
			if (itemByIndex != null)
			{
				this.AreaScroll.LateScrollTo(itemByIndex, null, false);
			}
			this.CurSelectNodeItem = nodeItem;
			this.CurSelectNodeItem.SelectNode();
		}
	}

	// Token: 0x06017019 RID: 94233 RVA: 0x005D765C File Offset: 0x005D585C
	[NullableContext(1)]
	private void OnClickNode(SurvivorsTalentNode node, UUIExtendToggle toggle)
	{
		SurvivorsTalentTreeView.<>c__DisplayClass17_0 CS$<>8__locals1 = new SurvivorsTalentTreeView.<>c__DisplayClass17_0();
		CS$<>8__locals1.<>4__this = this;
		CS$<>8__locals1.node = node;
		if (this.CurrentSelectToggle != null)
		{
			this.CurrentSelectToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}
		this.CurrentSelectToggle = toggle;
		this.CurrentSelectToggle.SetToggleState(EToggleState.ETT_Checked, false, false, false);
		UiNavigationNewController.Instance.SetNavigationFocusForView(this.CurrentSelectToggle.RootUIComp, false, false, false);
		this.SeqPlayer.StopSequenceByKey("Switch", false, false);
		this.SeqPlayer.PlayLevelSequenceByName("Switch", false, null, false);
		new UiAsyncTask("RefreshSkillInfo", delegate()
		{
			SurvivorsTalentTreeView.<>c__DisplayClass17_0.<<OnClickNode>b__0>d <<OnClickNode>b__0>d;
			<<OnClickNode>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<<OnClickNode>b__0>d.<>4__this = CS$<>8__locals1;
			<<OnClickNode>b__0>d.<>1__state = -1;
			<<OnClickNode>b__0>d.<>t__builder.Start<SurvivorsTalentTreeView.<>c__DisplayClass17_0.<<OnClickNode>b__0>d>(ref <<OnClickNode>b__0>d);
			return <<OnClickNode>b__0>d.<>t__builder.Task;
		}, null).Run();
	}

	// Token: 0x0601701A RID: 94234 RVA: 0x005D7714 File Offset: 0x005D5914
	[NullableContext(1)]
	private SurvivorsTalentTreeAreaItem InitAreaItem()
	{
		return new SurvivorsTalentTreeAreaItem
		{
			OnAfterRefreshOneNode = new Action<SurvivorsTalentTreeSkillNodeItem>(this.OnAfterRefreshOneNode)
		};
	}

	// Token: 0x0601701B RID: 94235 RVA: 0x005D7730 File Offset: 0x005D5930
	private void OnClickHelpBtn()
	{
		int helpId = SurvivorsRogueModel.Instance.GetRogueActivityConfig().Value.HelpId;
		HelpController.Instance.OpenHelpById(helpId);
	}

	// Token: 0x0601701C RID: 94236 RVA: 0x005D7763 File Offset: 0x005D5963
	private void OnClickCloseBtn()
	{
		base.CloseMe(null);
	}

	// Token: 0x0400ABC6 RID: 43974
	private const int TALENT_TREE_COST_ITEM_ID = 80400003;

	// Token: 0x0400ABC7 RID: 43975
	private SurvivorsTalentTreeSkillNodeItem CurSelectNodeItem;

	// Token: 0x0400ABC8 RID: 43976
	private SurvivorsTalentTreeSkillNodeItem FirstNodeItem;

	// Token: 0x0400ABC9 RID: 43977
	[Nullable(1)]
	private GenericScrollViewNew<SurvivorsTalentTreeAreaItem, SurvivorsTalentAreaData> AreaScroll;

	// Token: 0x0400ABCA RID: 43978
	private PopupCaptionItem CaptionItem;

	// Token: 0x0400ABCB RID: 43979
	private SurvivorsTalentTreeSkillInfoPanel SkillInfoPanel;

	// Token: 0x0400ABCC RID: 43980
	private UUIExtendToggle CurrentSelectToggle;

	// Token: 0x0400ABCD RID: 43981
	[Nullable(1)]
	private LevelSequencePlayer SeqPlayer;
}

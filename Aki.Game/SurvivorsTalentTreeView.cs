using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020020D0 RID: 8400
[NullableContext(2)]
[Nullable(0)]
public class SurvivorsTalentTreeView : UiViewBase
{
	// Token: 0x06014A41 RID: 84545 RVA: 0x00603F53 File Offset: 0x00602153
	[NullableContext(1)]
	public SurvivorsTalentTreeView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06014A42 RID: 84546 RVA: 0x00603F5C File Offset: 0x0060215C
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

	// Token: 0x06014A43 RID: 84547 RVA: 0x00603FE4 File Offset: 0x006021E4
	protected override UniTask OnBeforeStartAsync()
	{
		SurvivorsTalentTreeView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<SurvivorsTalentTreeView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06014A44 RID: 84548 RVA: 0x00604027 File Offset: 0x00602227
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.SurvivorsRogueTalentNodeUpdate, new Action<int>(this.OnTalentNodeUpdate));
	}

	// Token: 0x06014A45 RID: 84549 RVA: 0x00604045 File Offset: 0x00602245
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.SurvivorsRogueTalentNodeUpdate, new Action<int>(this.OnTalentNodeUpdate));
	}

	// Token: 0x06014A46 RID: 84550 RVA: 0x00604064 File Offset: 0x00602264
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

	// Token: 0x06014A47 RID: 84551 RVA: 0x006040A4 File Offset: 0x006022A4
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

	// Token: 0x06014A48 RID: 84552 RVA: 0x006040EF File Offset: 0x006022EF
	protected override void OnBeforeShow()
	{
		SurvivorsActivityController.Instance.CheckIsActivityClose();
	}

	// Token: 0x06014A49 RID: 84553 RVA: 0x006040FC File Offset: 0x006022FC
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

	// Token: 0x06014A4A RID: 84554 RVA: 0x006041C8 File Offset: 0x006023C8
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

	// Token: 0x06014A4B RID: 84555 RVA: 0x00604280 File Offset: 0x00602480
	[NullableContext(1)]
	private SurvivorsTalentTreeAreaItem InitAreaItem()
	{
		return new SurvivorsTalentTreeAreaItem
		{
			OnAfterRefreshOneNode = new Action<SurvivorsTalentTreeSkillNodeItem>(this.OnAfterRefreshOneNode)
		};
	}

	// Token: 0x06014A4C RID: 84556 RVA: 0x0060429C File Offset: 0x0060249C
	private void OnClickHelpBtn()
	{
		int helpId = SurvivorsRogueModel.Instance.GetRogueActivityConfig().Value.HelpId;
		HelpController.Instance.OpenHelpById(helpId);
	}

	// Token: 0x06014A4D RID: 84557 RVA: 0x006042CF File Offset: 0x006024CF
	private void OnClickCloseBtn()
	{
		base.CloseMe(null);
	}

	// Token: 0x0400AFCC RID: 45004
	private const int TALENT_TREE_COST_ITEM_ID = 80400003;

	// Token: 0x0400AFCD RID: 45005
	private SurvivorsTalentTreeSkillNodeItem CurSelectNodeItem;

	// Token: 0x0400AFCE RID: 45006
	private SurvivorsTalentTreeSkillNodeItem FirstNodeItem;

	// Token: 0x0400AFCF RID: 45007
	[Nullable(1)]
	private GenericScrollViewNew<SurvivorsTalentTreeAreaItem, SurvivorsTalentAreaData> AreaScroll;

	// Token: 0x0400AFD0 RID: 45008
	private PopupCaptionItem CaptionItem;

	// Token: 0x0400AFD1 RID: 45009
	private SurvivorsTalentTreeSkillInfoPanel SkillInfoPanel;

	// Token: 0x0400AFD2 RID: 45010
	private UUIExtendToggle CurrentSelectToggle;

	// Token: 0x0400AFD3 RID: 45011
	[Nullable(1)]
	private LevelSequencePlayer SeqPlayer;
}

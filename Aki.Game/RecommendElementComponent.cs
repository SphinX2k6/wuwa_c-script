using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Module.InstanceDungeon;
using UnrealEngine;

// Token: 0x02001BF9 RID: 7161
[NullableContext(1)]
[Nullable(0)]
public class RecommendElementComponent
{
	// Token: 0x0600D5B0 RID: 54704 RVA: 0x00314E61 File Offset: 0x00313061
	public RecommendElementComponent(UUIItem recommendItem, UUIItem elementContent, UUIItem elementItem, UUIItem lowLevelItem)
	{
		this.RecommendItem = recommendItem;
		this.ElementContent = elementContent;
		this.ElementItem = elementItem;
		this.LowLevelItem = lowLevelItem;
	}

	// Token: 0x0600D5B1 RID: 54705 RVA: 0x00314E94 File Offset: 0x00313094
	[NullableContext(2)]
	public void RefreshElements(int[] elementList)
	{
		if (elementList == null || elementList.Length == 0)
		{
			this.RecommendItem.SetUIActive(false);
			return;
		}
		this.RecommendItem.SetUIActive(true);
		foreach (int elementId in elementList)
		{
			UUIItem uuiitem = LguiUtil.Instance.CopyItem(this.ElementItem, this.ElementContent);
			this.Elements.Add(new MiniElementItem(elementId, uuiitem, uuiitem.GetOwner()));
		}
		this.ElementItem.SetUIActive(false);
	}

	// Token: 0x0600D5B2 RID: 54706 RVA: 0x00314F10 File Offset: 0x00313110
	public void UpdateRecommendLevel(bool canShowLowLevelTips)
	{
		BattleTeamModel instance = BattleTeamModel.Instance;
		int instanceId = InstanceDungeonEntranceModel.Instance.InstanceId;
		if (instanceId == 0 || TowerModel.Instance.CurrentSelectFloor != -1 || instance.Context.IsMultiInstanceDungeon)
		{
			this.LowLevelItem.SetUIActive(false);
			return;
		}
		bool flag = InstanceDungeonModel.Instance.CheckPrewarFormationAverageLowLevel(instanceId);
		this.LowLevelItem.SetUIActive(flag && canShowLowLevelTips);
	}

	// Token: 0x0600D5B3 RID: 54707 RVA: 0x00314F74 File Offset: 0x00313174
	public void Destroy()
	{
		foreach (MiniElementItem miniElementItem in this.Elements)
		{
			miniElementItem.Destroy(null);
		}
		this.Elements.Clear();
	}

	// Token: 0x040061C8 RID: 25032
	private readonly List<MiniElementItem> Elements = new List<MiniElementItem>();

	// Token: 0x040061C9 RID: 25033
	private readonly UUIItem RecommendItem;

	// Token: 0x040061CA RID: 25034
	private readonly UUIItem ElementContent;

	// Token: 0x040061CB RID: 25035
	private readonly UUIItem ElementItem;

	// Token: 0x040061CC RID: 25036
	private readonly UUIItem LowLevelItem;
}

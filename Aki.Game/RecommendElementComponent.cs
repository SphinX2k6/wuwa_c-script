using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Module.InstanceDungeon;
using UnrealEngine;

// Token: 0x020010B8 RID: 4280
[NullableContext(1)]
[Nullable(0)]
public class RecommendElementComponent
{
	// Token: 0x0600A9C3 RID: 43459 RVA: 0x0032015D File Offset: 0x0031E35D
	public RecommendElementComponent(UUIItem recommendItem, UUIItem elementContent, UUIItem elementItem, UUIItem lowLevelItem)
	{
		this.RecommendItem = recommendItem;
		this.ElementContent = elementContent;
		this.ElementItem = elementItem;
		this.LowLevelItem = lowLevelItem;
	}

	// Token: 0x0600A9C4 RID: 43460 RVA: 0x00320190 File Offset: 0x0031E390
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

	// Token: 0x0600A9C5 RID: 43461 RVA: 0x0032020C File Offset: 0x0031E40C
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

	// Token: 0x0600A9C6 RID: 43462 RVA: 0x00320270 File Offset: 0x0031E470
	public void Destroy()
	{
		foreach (MiniElementItem miniElementItem in this.Elements)
		{
			miniElementItem.Destroy(null);
		}
		this.Elements.Clear();
	}

	// Token: 0x0400629A RID: 25242
	private readonly List<MiniElementItem> Elements = new List<MiniElementItem>();

	// Token: 0x0400629B RID: 25243
	private readonly UUIItem RecommendItem;

	// Token: 0x0400629C RID: 25244
	private readonly UUIItem ElementContent;

	// Token: 0x0400629D RID: 25245
	private readonly UUIItem ElementItem;

	// Token: 0x0400629E RID: 25246
	private readonly UUIItem LowLevelItem;
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020020C9 RID: 8393
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class SurvivorsTalentTreeAreaItem : GridProxyAbstract<SurvivorsTalentAreaData>
{
	// Token: 0x06014A2C RID: 84524 RVA: 0x006037D4 File Offset: 0x006019D4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIItem))
		};
	}

	// Token: 0x06014A2D RID: 84525 RVA: 0x0060389C File Offset: 0x00601A9C
	protected override void OnStart()
	{
		this.NodeItemMap = new Dictionary<SurvivorsTalentNode, SurvivorsTalentTreeSkillNodeItem>();
	}

	// Token: 0x06014A2E RID: 84526 RVA: 0x006038AC File Offset: 0x00601AAC
	public override void Refresh(SurvivorsTalentAreaData areaData, bool isSelected, int gridIndex)
	{
		List<int> nodeIds = areaData.NodeIds;
		string resourceId = "SurvivorTreeNum_" + (gridIndex + 1).ToString();
		string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
		this.SetSpriteByPath(resourcePath, base.GetSprite(0), true, null, null);
		List<int> list = new List<int>();
		List<SurvivorsTalentNode> list2 = new List<SurvivorsTalentNode>();
		foreach (int nodeId in nodeIds)
		{
			SurvivorsTalentNode talentNodeById = SurvivorsRogueModel.Instance.ActivityData.GetTalentNodeById(nodeId);
			if (talentNodeById != null)
			{
				list.Add(talentNodeById.IndexId);
				list2.Add(talentNodeById);
			}
		}
		for (int i = 1; i <= 7; i++)
		{
			base.GetItem(i).SetUIActive(list.Contains(i));
		}
		this.RefreshArea(list2);
	}

	// Token: 0x06014A2F RID: 84527 RVA: 0x0060399C File Offset: 0x00601B9C
	public void RefreshArea(IReadOnlyList<SurvivorsTalentNode> nodeDataList)
	{
		SurvivorsTalentTreeAreaItem.<>c__DisplayClass5_0 CS$<>8__locals1 = new SurvivorsTalentTreeAreaItem.<>c__DisplayClass5_0();
		CS$<>8__locals1.<>4__this = this;
		CS$<>8__locals1.nodeDataList = nodeDataList;
		new UiAsyncTask("RefreshArea", delegate()
		{
			SurvivorsTalentTreeAreaItem.<>c__DisplayClass5_0.<<RefreshArea>b__0>d <<RefreshArea>b__0>d;
			<<RefreshArea>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<<RefreshArea>b__0>d.<>4__this = CS$<>8__locals1;
			<<RefreshArea>b__0>d.<>1__state = -1;
			<<RefreshArea>b__0>d.<>t__builder.Start<SurvivorsTalentTreeAreaItem.<>c__DisplayClass5_0.<<RefreshArea>b__0>d>(ref <<RefreshArea>b__0>d);
			return <<RefreshArea>b__0>d.<>t__builder.Task;
		}, null).Run();
	}

	// Token: 0x06014A30 RID: 84528 RVA: 0x006039DC File Offset: 0x00601BDC
	public UniTask RefreshAreaItemAsync(IReadOnlyList<SurvivorsTalentNode> nodeDataList)
	{
		SurvivorsTalentTreeAreaItem.<RefreshAreaItemAsync>d__6 <RefreshAreaItemAsync>d__;
		<RefreshAreaItemAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshAreaItemAsync>d__.<>4__this = this;
		<RefreshAreaItemAsync>d__.nodeDataList = nodeDataList;
		<RefreshAreaItemAsync>d__.<>1__state = -1;
		<RefreshAreaItemAsync>d__.<>t__builder.Start<SurvivorsTalentTreeAreaItem.<RefreshAreaItemAsync>d__6>(ref <RefreshAreaItemAsync>d__);
		return <RefreshAreaItemAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0400AFA4 RID: 44964
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	public Dictionary<SurvivorsTalentNode, SurvivorsTalentTreeSkillNodeItem> NodeItemMap;

	// Token: 0x0400AFA5 RID: 44965
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<SurvivorsTalentTreeSkillNodeItem> OnAfterRefreshOneNode;
}

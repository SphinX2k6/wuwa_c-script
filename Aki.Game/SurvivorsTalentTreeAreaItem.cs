using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002B4D RID: 11085
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class SurvivorsTalentTreeAreaItem : GridProxyAbstract<SurvivorsTalentAreaData>
{
	// Token: 0x06016FFB RID: 94203 RVA: 0x005D6C68 File Offset: 0x005D4E68
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

	// Token: 0x06016FFC RID: 94204 RVA: 0x005D6D30 File Offset: 0x005D4F30
	protected override void OnStart()
	{
		this.NodeItemMap = new Dictionary<SurvivorsTalentNode, SurvivorsTalentTreeSkillNodeItem>();
	}

	// Token: 0x06016FFD RID: 94205 RVA: 0x005D6D40 File Offset: 0x005D4F40
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

	// Token: 0x06016FFE RID: 94206 RVA: 0x005D6E30 File Offset: 0x005D5030
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

	// Token: 0x06016FFF RID: 94207 RVA: 0x005D6E70 File Offset: 0x005D5070
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

	// Token: 0x0400AB9E RID: 43934
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	public Dictionary<SurvivorsTalentNode, SurvivorsTalentTreeSkillNodeItem> NodeItemMap;

	// Token: 0x0400AB9F RID: 43935
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<SurvivorsTalentTreeSkillNodeItem> OnAfterRefreshOneNode;
}

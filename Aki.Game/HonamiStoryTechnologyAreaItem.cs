using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001F03 RID: 7939
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class HonamiStoryTechnologyAreaItem : GridProxyAbstract<HonamiStoryTechAreaData>
{
	// Token: 0x17001314 RID: 4884
	// (get) Token: 0x0600F473 RID: 62579 RVA: 0x003AF836 File Offset: 0x003ADA36
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Dictionary<int, HonamiStoryTechnologyNodeItem> GetNodeItemMap
	{
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		get
		{
			return this.NodeItemMap;
		}
	}

	// Token: 0x0600F474 RID: 62580 RVA: 0x003AF840 File Offset: 0x003ADA40
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(14, typeof(UUISprite)),
			new ValueTuple<int, Type>(10, typeof(UUIItem))
		};
	}

	// Token: 0x0600F475 RID: 62581 RVA: 0x003AF920 File Offset: 0x003ADB20
	protected override void OnStart()
	{
		this.NodeItemMap = new Dictionary<int, HonamiStoryTechnologyNodeItem>();
	}

	// Token: 0x0600F476 RID: 62582 RVA: 0x003AF92D File Offset: 0x003ADB2D
	protected override void OnBeforeDestroy()
	{
		this.NodeItemMap = null;
	}

	// Token: 0x0600F477 RID: 62583 RVA: 0x003AF938 File Offset: 0x003ADB38
	public override void Refresh(HonamiStoryTechAreaData areaData, bool isSelected, int gridIndex)
	{
		List<int> nodeIds = areaData.NodeIds;
		string text = (gridIndex + 1).ToString();
		UUISprite sprite = base.GetSprite(14);
		string path = StringUtils.Format("/Game/Aki/UI/UIResources/Common/Atlas/SP_ComRomeText_0{0}.SP_ComRomeText_0{1}", new string[]
		{
			text,
			text
		});
		this.SetSpriteByPath(path, sprite, true, null, null);
		List<int> list = new List<int>();
		List<HonamiStoryTechNodeData> list2 = new List<HonamiStoryTechNodeData>();
		foreach (int id in nodeIds)
		{
			HonamiStoryTechNodeData techNodeData = HonamiStoryModel.Instance.GetTechNodeData(id);
			if (techNodeData != null)
			{
				list.Add(techNodeData.GetConfig.IndexId);
				list2.Add(techNodeData);
			}
		}
		for (int i = 0; i <= 6; i++)
		{
			bool uiactive = list.Contains(i + 1);
			base.GetItem(i).SetUIActive(uiactive);
		}
		this.RefreshArea(list2);
	}

	// Token: 0x0600F478 RID: 62584 RVA: 0x003AFA40 File Offset: 0x003ADC40
	public void RefreshArea(List<HonamiStoryTechNodeData> nodeDataList)
	{
		HonamiStoryTechnologyAreaItem.<>c__DisplayClass10_0 CS$<>8__locals1 = new HonamiStoryTechnologyAreaItem.<>c__DisplayClass10_0();
		CS$<>8__locals1.<>4__this = this;
		CS$<>8__locals1.nodeDataList = nodeDataList;
		UiAsyncTask task = new UiAsyncTask("RefreshArea", delegate()
		{
			HonamiStoryTechnologyAreaItem.<>c__DisplayClass10_0.<<RefreshArea>b__0>d <<RefreshArea>b__0>d;
			<<RefreshArea>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<<RefreshArea>b__0>d.<>4__this = CS$<>8__locals1;
			<<RefreshArea>b__0>d.<>1__state = -1;
			<<RefreshArea>b__0>d.<>t__builder.Start<HonamiStoryTechnologyAreaItem.<>c__DisplayClass10_0.<<RefreshArea>b__0>d>(ref <<RefreshArea>b__0>d);
			return <<RefreshArea>b__0>d.<>t__builder.Task;
		}, null);
		base.RunAsyncTask(task);
	}

	// Token: 0x0600F479 RID: 62585 RVA: 0x003AFA84 File Offset: 0x003ADC84
	private UniTask RefreshAreaItemAsync(List<HonamiStoryTechNodeData> nodeDataList)
	{
		HonamiStoryTechnologyAreaItem.<RefreshAreaItemAsync>d__11 <RefreshAreaItemAsync>d__;
		<RefreshAreaItemAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshAreaItemAsync>d__.<>4__this = this;
		<RefreshAreaItemAsync>d__.nodeDataList = nodeDataList;
		<RefreshAreaItemAsync>d__.<>1__state = -1;
		<RefreshAreaItemAsync>d__.<>t__builder.Start<HonamiStoryTechnologyAreaItem.<RefreshAreaItemAsync>d__11>(ref <RefreshAreaItemAsync>d__);
		return <RefreshAreaItemAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600F47A RID: 62586 RVA: 0x003AFACF File Offset: 0x003ADCCF
	public void CloseLineRight()
	{
		base.GetItem(10).SetUIActive(false);
	}

	// Token: 0x0400711E RID: 28958
	private const string ROME_ICON_PATH = "/Game/Aki/UI/UIResources/Common/Atlas/SP_ComRomeText_0{0}.SP_ComRomeText_0{1}";

	// Token: 0x0400711F RID: 28959
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<int, HonamiStoryTechnologyNodeItem> NodeItemMap;

	// Token: 0x04007120 RID: 28960
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<HonamiStoryTechnologyNodeItem> OnAfterRefreshOneNode;

	// Token: 0x02008505 RID: 34053
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402B49C RID: 177308
		LeftSkillItem,
		// Token: 0x0402B49D RID: 177309
		TopSkillItem,
		// Token: 0x0402B49E RID: 177310
		MiddleSkillItem,
		// Token: 0x0402B49F RID: 177311
		BottomSkillItem,
		// Token: 0x0402B4A0 RID: 177312
		ExtraSkillItemA,
		// Token: 0x0402B4A1 RID: 177313
		ExtraSkillItemB,
		// Token: 0x0402B4A2 RID: 177314
		ExtraSkillItemC,
		// Token: 0x0402B4A3 RID: 177315
		line1,
		// Token: 0x0402B4A4 RID: 177316
		line2,
		// Token: 0x0402B4A5 RID: 177317
		line3,
		// Token: 0x0402B4A6 RID: 177318
		lineRight,
		// Token: 0x0402B4A7 RID: 177319
		line5,
		// Token: 0x0402B4A8 RID: 177320
		line6,
		// Token: 0x0402B4A9 RID: 177321
		line7,
		// Token: 0x0402B4AA RID: 177322
		SprTopNum
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020013C5 RID: 5061
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class HonamiStoryTechnologyAreaItem : GridProxyAbstract<HonamiStoryTechAreaData>
{
	// Token: 0x1700133E RID: 4926
	// (get) Token: 0x0600C892 RID: 51346 RVA: 0x003BB32A File Offset: 0x003B952A
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

	// Token: 0x0600C893 RID: 51347 RVA: 0x003BB334 File Offset: 0x003B9534
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

	// Token: 0x0600C894 RID: 51348 RVA: 0x003BB414 File Offset: 0x003B9614
	protected override void OnStart()
	{
		this.NodeItemMap = new Dictionary<int, HonamiStoryTechnologyNodeItem>();
	}

	// Token: 0x0600C895 RID: 51349 RVA: 0x003BB421 File Offset: 0x003B9621
	protected override void OnBeforeDestroy()
	{
		this.NodeItemMap = null;
	}

	// Token: 0x0600C896 RID: 51350 RVA: 0x003BB42C File Offset: 0x003B962C
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

	// Token: 0x0600C897 RID: 51351 RVA: 0x003BB534 File Offset: 0x003B9734
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

	// Token: 0x0600C898 RID: 51352 RVA: 0x003BB578 File Offset: 0x003B9778
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

	// Token: 0x0600C899 RID: 51353 RVA: 0x003BB5C3 File Offset: 0x003B97C3
	public void CloseLineRight()
	{
		base.GetItem(10).SetUIActive(false);
	}

	// Token: 0x040071FF RID: 29183
	private const string ROME_ICON_PATH = "/Game/Aki/UI/UIResources/Common/Atlas/SP_ComRomeText_0{0}.SP_ComRomeText_0{1}";

	// Token: 0x04007200 RID: 29184
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<int, HonamiStoryTechnologyNodeItem> NodeItemMap;

	// Token: 0x04007201 RID: 29185
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<HonamiStoryTechnologyNodeItem> OnAfterRefreshOneNode;

	// Token: 0x0200768A RID: 30346
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x040267C0 RID: 157632
		LeftSkillItem,
		// Token: 0x040267C1 RID: 157633
		TopSkillItem,
		// Token: 0x040267C2 RID: 157634
		MiddleSkillItem,
		// Token: 0x040267C3 RID: 157635
		BottomSkillItem,
		// Token: 0x040267C4 RID: 157636
		ExtraSkillItemA,
		// Token: 0x040267C5 RID: 157637
		ExtraSkillItemB,
		// Token: 0x040267C6 RID: 157638
		ExtraSkillItemC,
		// Token: 0x040267C7 RID: 157639
		line1,
		// Token: 0x040267C8 RID: 157640
		line2,
		// Token: 0x040267C9 RID: 157641
		line3,
		// Token: 0x040267CA RID: 157642
		lineRight,
		// Token: 0x040267CB RID: 157643
		line5,
		// Token: 0x040267CC RID: 157644
		line6,
		// Token: 0x040267CD RID: 157645
		line7,
		// Token: 0x040267CE RID: 157646
		SprTopNum
	}
}

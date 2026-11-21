using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001D85 RID: 7557
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class RoleDevPhantomSuitItem : GridProxyAbstract<RoleDevPhantomSuitItemData>
{
	// Token: 0x06012A85 RID: 76421 RVA: 0x0057E00C File Offset: 0x0057C20C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUILayoutBase))
		};
	}

	// Token: 0x06012A86 RID: 76422 RVA: 0x0057E07C File Offset: 0x0057C27C
	protected override UniTask OnBeforeStartAsync()
	{
		RoleDevPhantomSuitItem.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RoleDevPhantomSuitItem.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06012A87 RID: 76423 RVA: 0x0057E0C0 File Offset: 0x0057C2C0
	private UniTask InitItems()
	{
		RoleDevPhantomSuitItem.<InitItems>d__6 <InitItems>d__;
		<InitItems>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitItems>d__.<>4__this = this;
		<InitItems>d__.<>1__state = -1;
		<InitItems>d__.<>t__builder.Start<RoleDevPhantomSuitItem.<InitItems>d__6>(ref <InitItems>d__);
		return <InitItems>d__.<>t__builder.Task;
	}

	// Token: 0x06012A88 RID: 76424 RVA: 0x0057E104 File Offset: 0x0057C304
	public override void Refresh(RoleDevPhantomSuitItemData data, bool isSelected, int gridIndex)
	{
		this.CurrentRoleId = data.RoleId;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), data.SuitName, Array.Empty<object>());
		if (data.UseRate > 0)
		{
			base.GetText(2).SetUIActive(true);
			base.GetText(2).SetText(data.UseRateText, true);
		}
		else
		{
			base.GetText(2).SetUIActive(false);
		}
		this.RefreshElementIcon(data);
		this.RefreshVisionSuitItems(data);
	}

	// Token: 0x06012A89 RID: 76425 RVA: 0x0057E180 File Offset: 0x0057C380
	private void RefreshElementIcon(RoleDevPhantomSuitItemData data)
	{
		UUIItem item = base.GetItem(0);
		if (item != null && this.ElementSuitItem != null)
		{
			item.SetUIActive(data.HasElementIcon);
			if (data.HasElementIcon && data.FetterGroupConfig != null)
			{
				this.ElementSuitItem.Update(data.FetterGroupConfig);
				this.ElementSuitItem.SetUiActive(true);
			}
		}
	}

	// Token: 0x06012A8A RID: 76426 RVA: 0x0057E1E4 File Offset: 0x0057C3E4
	private void RefreshVisionSuitItems(RoleDevPhantomSuitItemData data)
	{
		List<RoleDevPhantomVisionSuitItemData> list = new List<RoleDevPhantomVisionSuitItemData>();
		RoleDevPhantomFetterGroupData roleDevPhantomFetterGroupData = new RoleDevPhantomFetterGroupData();
		roleDevPhantomFetterGroupData.InitByFetterGroup(data.SuitId, this.CurrentRoleId, data.RecommendGroupIds);
		list.Add(roleDevPhantomFetterGroupData);
		foreach (int dungeonId in data.DungeonIdList)
		{
			RoleDevPhantomDungeonData roleDevPhantomDungeonData = new RoleDevPhantomDungeonData();
			roleDevPhantomDungeonData.InitByDungeon(dungeonId);
			list.Add(roleDevPhantomDungeonData);
		}
		GenericLayout<RoleDevPhantomVisionSuitItem, RoleDevPhantomVisionSuitItemData> visionSuitItemLayout = this.VisionSuitItemLayout;
		if (visionSuitItemLayout == null)
		{
			return;
		}
		visionSuitItemLayout.RefreshByData(list, null, false);
	}

	// Token: 0x06012A8B RID: 76427 RVA: 0x0057E288 File Offset: 0x0057C488
	public override object GetKey(RoleDevPhantomSuitItemData data, int gridIndex)
	{
		return data.SuitId;
	}

	// Token: 0x06012A8C RID: 76428 RVA: 0x0057E295 File Offset: 0x0057C495
	private RoleDevPhantomVisionSuitItem CreateVisionSuitItem()
	{
		return new RoleDevPhantomVisionSuitItem();
	}

	// Token: 0x0400A203 RID: 41475
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<RoleDevPhantomVisionSuitItem, RoleDevPhantomVisionSuitItemData> VisionSuitItemLayout;

	// Token: 0x0400A204 RID: 41476
	[Nullable(2)]
	private VisionFetterSuitItem ElementSuitItem;

	// Token: 0x0400A205 RID: 41477
	private int CurrentRoleId;

	// Token: 0x02008095 RID: 32917
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402998C RID: 170380
		PanelElementIcon,
		// Token: 0x0402998D RID: 170381
		TxtSuitName,
		// Token: 0x0402998E RID: 170382
		TxtUseRate,
		// Token: 0x0402998F RID: 170383
		PanelVisionSuitLayout
	}
}

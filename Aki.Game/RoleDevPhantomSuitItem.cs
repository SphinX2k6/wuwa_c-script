using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200280A RID: 10250
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class RoleDevPhantomSuitItem : GridProxyAbstract<RoleDevPhantomSuitItemData>
{
	// Token: 0x06015085 RID: 86149 RVA: 0x00553238 File Offset: 0x00551438
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

	// Token: 0x06015086 RID: 86150 RVA: 0x005532A8 File Offset: 0x005514A8
	protected override UniTask OnBeforeStartAsync()
	{
		RoleDevPhantomSuitItem.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RoleDevPhantomSuitItem.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06015087 RID: 86151 RVA: 0x005532EC File Offset: 0x005514EC
	private UniTask InitItems()
	{
		RoleDevPhantomSuitItem.<InitItems>d__6 <InitItems>d__;
		<InitItems>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitItems>d__.<>4__this = this;
		<InitItems>d__.<>1__state = -1;
		<InitItems>d__.<>t__builder.Start<RoleDevPhantomSuitItem.<InitItems>d__6>(ref <InitItems>d__);
		return <InitItems>d__.<>t__builder.Task;
	}

	// Token: 0x06015088 RID: 86152 RVA: 0x00553330 File Offset: 0x00551530
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

	// Token: 0x06015089 RID: 86153 RVA: 0x005533AC File Offset: 0x005515AC
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

	// Token: 0x0601508A RID: 86154 RVA: 0x00553410 File Offset: 0x00551610
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

	// Token: 0x0601508B RID: 86155 RVA: 0x005534B4 File Offset: 0x005516B4
	public override object GetKey(RoleDevPhantomSuitItemData data, int gridIndex)
	{
		return data.SuitId;
	}

	// Token: 0x0601508C RID: 86156 RVA: 0x005534C1 File Offset: 0x005516C1
	private RoleDevPhantomVisionSuitItem CreateVisionSuitItem()
	{
		return new RoleDevPhantomVisionSuitItem();
	}

	// Token: 0x04009E1A RID: 40474
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<RoleDevPhantomVisionSuitItem, RoleDevPhantomVisionSuitItemData> VisionSuitItemLayout;

	// Token: 0x04009E1B RID: 40475
	[Nullable(2)]
	private VisionFetterSuitItem ElementSuitItem;

	// Token: 0x04009E1C RID: 40476
	private int CurrentRoleId;

	// Token: 0x02008E4D RID: 36429
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402E290 RID: 189072
		PanelElementIcon,
		// Token: 0x0402E291 RID: 189073
		TxtSuitName,
		// Token: 0x0402E292 RID: 189074
		TxtUseRate,
		// Token: 0x0402E293 RID: 189075
		PanelVisionSuitLayout
	}
}

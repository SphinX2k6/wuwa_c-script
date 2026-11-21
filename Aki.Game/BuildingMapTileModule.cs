using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020007A5 RID: 1957
[NullableContext(1)]
[Nullable(0)]
public class BuildingMapTileModule : UiPanelBase
{
	// Token: 0x060059AF RID: 22959 RVA: 0x001D20C6 File Offset: 0x001D02C6
	public BuildingMapTileModule(bool needLoadingFixRole, bool needLoadingShowRoleItem)
	{
		this.NeedLoadingFixRole = needLoadingFixRole;
		this.NeedLoadingShowRoleItem = needLoadingShowRoleItem;
	}

	// Token: 0x17000B9C RID: 2972
	// (get) Token: 0x060059B0 RID: 22960 RVA: 0x001D20FD File Offset: 0x001D02FD
	public bool NeedLoadingFixRole { get; }

	// Token: 0x17000B9D RID: 2973
	// (get) Token: 0x060059B1 RID: 22961 RVA: 0x001D2105 File Offset: 0x001D0305
	public bool NeedLoadingShowRoleItem { get; }

	// Token: 0x060059B2 RID: 22962 RVA: 0x001D2110 File Offset: 0x001D0310
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUILayoutBase)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIItem)),
			new ValueTuple<int, Type>(10, typeof(UUIItem)),
			new ValueTuple<int, Type>(11, typeof(UUIItem)),
			new ValueTuple<int, Type>(12, typeof(UUIItem)),
			new ValueTuple<int, Type>(13, typeof(UUIItem))
		};
	}

	// Token: 0x060059B3 RID: 22963 RVA: 0x001D2264 File Offset: 0x001D0464
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
	{
		if (configParams.Length < 2)
		{
			return null;
		}
		int key;
		if (configParams[1] == "CanLevelUp")
		{
			key = MoonChasingBuildingModel.Instance.GetFirstCanLevelUpBuildingId().GetValueOrDefault();
		}
		else
		{
			key = int.Parse(configParams[1]);
		}
		BuildingItem buildingItem;
		if (!this.BuildingItemMap.TryGetValue(key, out buildingItem))
		{
			return null;
		}
		return buildingItem.GetGuideUiItemAndUiItemForShowEx(configParams);
	}

	// Token: 0x060059B4 RID: 22964 RVA: 0x001D22C0 File Offset: 0x001D04C0
	private UniTask InitMapLayout()
	{
		BuildingMapTileModule.<InitMapLayout>d__17 <InitMapLayout>d__;
		<InitMapLayout>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitMapLayout>d__.<>4__this = this;
		<InitMapLayout>d__.<>1__state = -1;
		<InitMapLayout>d__.<>t__builder.Start<BuildingMapTileModule.<InitMapLayout>d__17>(ref <InitMapLayout>d__);
		return <InitMapLayout>d__.<>t__builder.Task;
	}

	// Token: 0x060059B5 RID: 22965 RVA: 0x001D2304 File Offset: 0x001D0504
	private UniTask LoadMapTexture()
	{
		BuildingMapTileModule.<LoadMapTexture>d__18 <LoadMapTexture>d__;
		<LoadMapTexture>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<LoadMapTexture>d__.<>4__this = this;
		<LoadMapTexture>d__.<>1__state = -1;
		<LoadMapTexture>d__.<>t__builder.Start<BuildingMapTileModule.<LoadMapTexture>d__18>(ref <LoadMapTexture>d__);
		return <LoadMapTexture>d__.<>t__builder.Task;
	}

	// Token: 0x060059B6 RID: 22966 RVA: 0x001D2348 File Offset: 0x001D0548
	private List<UUIItem> GetBuildingItemList()
	{
		return new List<UUIItem>
		{
			base.GetItem(3),
			base.GetItem(4),
			base.GetItem(5),
			base.GetItem(6),
			base.GetItem(7),
			base.GetItem(8),
			base.GetItem(9),
			base.GetItem(10),
			base.GetItem(11),
			base.GetItem(12)
		};
	}

	// Token: 0x060059B7 RID: 22967 RVA: 0x001D23E0 File Offset: 0x001D05E0
	private UniTask InitBuild()
	{
		BuildingMapTileModule.<InitBuild>d__20 <InitBuild>d__;
		<InitBuild>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitBuild>d__.<>4__this = this;
		<InitBuild>d__.<>1__state = -1;
		<InitBuild>d__.<>t__builder.Start<BuildingMapTileModule.<InitBuild>d__20>(ref <InitBuild>d__);
		return <InitBuild>d__.<>t__builder.Task;
	}

	// Token: 0x060059B8 RID: 22968 RVA: 0x001D2424 File Offset: 0x001D0624
	private UniTask CreateRoleItem(UUIItem parentItem, int roleId)
	{
		BuildingMapTileModule.<CreateRoleItem>d__21 <CreateRoleItem>d__;
		<CreateRoleItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateRoleItem>d__.<>4__this = this;
		<CreateRoleItem>d__.parentItem = parentItem;
		<CreateRoleItem>d__.roleId = roleId;
		<CreateRoleItem>d__.<>1__state = -1;
		<CreateRoleItem>d__.<>t__builder.Start<BuildingMapTileModule.<CreateRoleItem>d__21>(ref <CreateRoleItem>d__);
		return <CreateRoleItem>d__.<>t__builder.Task;
	}

	// Token: 0x060059B9 RID: 22969 RVA: 0x001D2478 File Offset: 0x001D0678
	private List<int> GetRandomNumberList(int count, int endIndex)
	{
		HashSet<int> hashSet = new HashSet<int>();
		List<int> list = new List<int>();
		Random random = new Random();
		for (int i = 1; i <= count; i++)
		{
			int item = random.Next(endIndex);
			while (hashSet.Contains(item))
			{
				item = random.Next(endIndex);
			}
			hashSet.Add(item);
			list.Add(item);
		}
		return list;
	}

	// Token: 0x060059BA RID: 22970 RVA: 0x001D24D4 File Offset: 0x001D06D4
	private UniTask InitRole()
	{
		BuildingMapTileModule.<InitRole>d__23 <InitRole>d__;
		<InitRole>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitRole>d__.<>4__this = this;
		<InitRole>d__.<>1__state = -1;
		<InitRole>d__.<>t__builder.Start<BuildingMapTileModule.<InitRole>d__23>(ref <InitRole>d__);
		return <InitRole>d__.<>t__builder.Task;
	}

	// Token: 0x060059BB RID: 22971 RVA: 0x001D2518 File Offset: 0x001D0718
	private UniTask InitShowRole()
	{
		BuildingMapTileModule.<InitShowRole>d__24 <InitShowRole>d__;
		<InitShowRole>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitShowRole>d__.<>4__this = this;
		<InitShowRole>d__.<>1__state = -1;
		<InitShowRole>d__.<>t__builder.Start<BuildingMapTileModule.<InitShowRole>d__24>(ref <InitShowRole>d__);
		return <InitShowRole>d__.<>t__builder.Task;
	}

	// Token: 0x060059BC RID: 22972 RVA: 0x001D255C File Offset: 0x001D075C
	protected override UniTask OnBeforeStartAsync()
	{
		BuildingMapTileModule.<OnBeforeStartAsync>d__25 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<BuildingMapTileModule.<OnBeforeStartAsync>d__25>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060059BD RID: 22973 RVA: 0x001D259F File Offset: 0x001D079F
	public void RefreshRole()
	{
		this.InitRole().Forget();
	}

	// Token: 0x060059BE RID: 22974 RVA: 0x001D25AC File Offset: 0x001D07AC
	private BuildingMapTileModule.TileItem InitTileItem()
	{
		return new BuildingMapTileModule.TileItem(this.TileMgr);
	}

	// Token: 0x060059BF RID: 22975 RVA: 0x001D25BC File Offset: 0x001D07BC
	public void SetAllBuildingExhibitionMode(bool bShowOnly)
	{
		foreach (BuildingItem buildingItem in this.BuildingItemMap.Values)
		{
			buildingItem.SetExhibitionMode(bShowOnly);
			buildingItem.SetInteractive(!bShowOnly);
		}
	}

	// Token: 0x060059C0 RID: 22976 RVA: 0x001D261C File Offset: 0x001D081C
	public void SetBuildingItemActive(bool value)
	{
		foreach (BuildingItem buildingItem in this.BuildingItemMap.Values)
		{
			buildingItem.SetBuildingItemActive(value);
		}
	}

	// Token: 0x060059C1 RID: 22977 RVA: 0x001D2674 File Offset: 0x001D0874
	public void RefreshBuildingItem(int buildingId)
	{
		this.BuildingItemMap[buildingId].Refresh();
	}

	// Token: 0x04003CA9 RID: 15529
	private readonly BuildingMapTileMgr TileMgr = new BuildingMapTileMgr();

	// Token: 0x04003CAA RID: 15530
	protected GenericLayout<BuildingMapTileModule.TileItem, string> MapLayout;

	// Token: 0x04003CAB RID: 15531
	private readonly Dictionary<int, BuildingItem> BuildingItemMap = new Dictionary<int, BuildingItem>();

	// Token: 0x04003CAC RID: 15532
	private readonly List<BuildingRoleItem> RoleItemList = new List<BuildingRoleItem>();

	// Token: 0x04003CAD RID: 15533
	private BuildingMapShowRoleModule ShowRoleItem;

	// Token: 0x02006AA0 RID: 27296
	[NullableContext(0)]
	private static class ETileItem
	{
		// Token: 0x04023172 RID: 143730
		public const int Texture = 0;
	}

	// Token: 0x02006AA1 RID: 27297
	[Nullable(new byte[]
	{
		0,
		1
	})]
	protected class TileItem : GridProxyAbstract<string>
	{
		// Token: 0x0603F6CD RID: 259789 RVA: 0x012869A2 File Offset: 0x01284BA2
		public TileItem(BuildingMapTileMgr tileMgr)
		{
			this.TileMgr = tileMgr;
		}

		// Token: 0x170077C9 RID: 30665
		// (get) Token: 0x0603F6CE RID: 259790 RVA: 0x012869B1 File Offset: 0x01284BB1
		public BuildingMapTileMgr TileMgr { get; }

		// Token: 0x0603F6CF RID: 259791 RVA: 0x012869B9 File Offset: 0x01284BB9
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUITexture))
			};
		}

		// Token: 0x0603F6D0 RID: 259792 RVA: 0x012869DC File Offset: 0x01284BDC
		public override void Refresh(string data, bool isSelected, int gridIndex)
		{
		}

		// Token: 0x0603F6D1 RID: 259793 RVA: 0x012869E0 File Offset: 0x01284BE0
		public override UniTask RefreshAsync(string data, bool isSelected, int gridIndex)
		{
			BuildingMapTileModule.TileItem.<RefreshAsync>d__6 <RefreshAsync>d__;
			<RefreshAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshAsync>d__.<>4__this = this;
			<RefreshAsync>d__.data = data;
			<RefreshAsync>d__.<>1__state = -1;
			<RefreshAsync>d__.<>t__builder.Start<BuildingMapTileModule.TileItem.<RefreshAsync>d__6>(ref <RefreshAsync>d__);
			return <RefreshAsync>d__.<>t__builder.Task;
		}
	}

	// Token: 0x02006AA2 RID: 27298
	[NullableContext(0)]
	private static class EComponentDefine
	{
		// Token: 0x04023174 RID: 143732
		public const int TileRootItem = 0;

		// Token: 0x04023175 RID: 143733
		public const int TileItem = 1;

		// Token: 0x04023176 RID: 143734
		public const int RoleRootItem = 2;

		// Token: 0x04023177 RID: 143735
		public const int BuildingItem1 = 3;

		// Token: 0x04023178 RID: 143736
		public const int BuildingItem2 = 4;

		// Token: 0x04023179 RID: 143737
		public const int BuildingItem3 = 5;

		// Token: 0x0402317A RID: 143738
		public const int BuildingItem4 = 6;

		// Token: 0x0402317B RID: 143739
		public const int BuildingItem5 = 7;

		// Token: 0x0402317C RID: 143740
		public const int BuildingItem6 = 8;

		// Token: 0x0402317D RID: 143741
		public const int BuildingItem7 = 9;

		// Token: 0x0402317E RID: 143742
		public const int BuildingItem8 = 10;

		// Token: 0x0402317F RID: 143743
		public const int BuildingItem9 = 11;

		// Token: 0x04023180 RID: 143744
		public const int BuildingItem10 = 12;

		// Token: 0x04023181 RID: 143745
		public const int ShowRoleRootItem = 13;
	}
}

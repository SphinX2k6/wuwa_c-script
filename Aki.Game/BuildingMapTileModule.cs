using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020012F1 RID: 4849
[NullableContext(1)]
[Nullable(0)]
public class BuildingMapTileModule : UiPanelBase
{
	// Token: 0x06008614 RID: 34324 RVA: 0x001C925A File Offset: 0x001C745A
	public BuildingMapTileModule(bool needLoadingFixRole, bool needLoadingShowRoleItem)
	{
		this.NeedLoadingFixRole = needLoadingFixRole;
		this.NeedLoadingShowRoleItem = needLoadingShowRoleItem;
	}

	// Token: 0x17000B7C RID: 2940
	// (get) Token: 0x06008615 RID: 34325 RVA: 0x001C9291 File Offset: 0x001C7491
	public bool NeedLoadingFixRole { get; }

	// Token: 0x17000B7D RID: 2941
	// (get) Token: 0x06008616 RID: 34326 RVA: 0x001C9299 File Offset: 0x001C7499
	public bool NeedLoadingShowRoleItem { get; }

	// Token: 0x06008617 RID: 34327 RVA: 0x001C92A4 File Offset: 0x001C74A4
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

	// Token: 0x06008618 RID: 34328 RVA: 0x001C93F8 File Offset: 0x001C75F8
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

	// Token: 0x06008619 RID: 34329 RVA: 0x001C9454 File Offset: 0x001C7654
	private UniTask InitMapLayout()
	{
		BuildingMapTileModule.<InitMapLayout>d__17 <InitMapLayout>d__;
		<InitMapLayout>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitMapLayout>d__.<>4__this = this;
		<InitMapLayout>d__.<>1__state = -1;
		<InitMapLayout>d__.<>t__builder.Start<BuildingMapTileModule.<InitMapLayout>d__17>(ref <InitMapLayout>d__);
		return <InitMapLayout>d__.<>t__builder.Task;
	}

	// Token: 0x0600861A RID: 34330 RVA: 0x001C9498 File Offset: 0x001C7698
	private UniTask LoadMapTexture()
	{
		BuildingMapTileModule.<LoadMapTexture>d__18 <LoadMapTexture>d__;
		<LoadMapTexture>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<LoadMapTexture>d__.<>4__this = this;
		<LoadMapTexture>d__.<>1__state = -1;
		<LoadMapTexture>d__.<>t__builder.Start<BuildingMapTileModule.<LoadMapTexture>d__18>(ref <LoadMapTexture>d__);
		return <LoadMapTexture>d__.<>t__builder.Task;
	}

	// Token: 0x0600861B RID: 34331 RVA: 0x001C94DC File Offset: 0x001C76DC
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

	// Token: 0x0600861C RID: 34332 RVA: 0x001C9574 File Offset: 0x001C7774
	private UniTask InitBuild()
	{
		BuildingMapTileModule.<InitBuild>d__20 <InitBuild>d__;
		<InitBuild>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitBuild>d__.<>4__this = this;
		<InitBuild>d__.<>1__state = -1;
		<InitBuild>d__.<>t__builder.Start<BuildingMapTileModule.<InitBuild>d__20>(ref <InitBuild>d__);
		return <InitBuild>d__.<>t__builder.Task;
	}

	// Token: 0x0600861D RID: 34333 RVA: 0x001C95B8 File Offset: 0x001C77B8
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

	// Token: 0x0600861E RID: 34334 RVA: 0x001C960C File Offset: 0x001C780C
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

	// Token: 0x0600861F RID: 34335 RVA: 0x001C9668 File Offset: 0x001C7868
	private UniTask InitRole()
	{
		BuildingMapTileModule.<InitRole>d__23 <InitRole>d__;
		<InitRole>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitRole>d__.<>4__this = this;
		<InitRole>d__.<>1__state = -1;
		<InitRole>d__.<>t__builder.Start<BuildingMapTileModule.<InitRole>d__23>(ref <InitRole>d__);
		return <InitRole>d__.<>t__builder.Task;
	}

	// Token: 0x06008620 RID: 34336 RVA: 0x001C96AC File Offset: 0x001C78AC
	private UniTask InitShowRole()
	{
		BuildingMapTileModule.<InitShowRole>d__24 <InitShowRole>d__;
		<InitShowRole>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitShowRole>d__.<>4__this = this;
		<InitShowRole>d__.<>1__state = -1;
		<InitShowRole>d__.<>t__builder.Start<BuildingMapTileModule.<InitShowRole>d__24>(ref <InitShowRole>d__);
		return <InitShowRole>d__.<>t__builder.Task;
	}

	// Token: 0x06008621 RID: 34337 RVA: 0x001C96F0 File Offset: 0x001C78F0
	protected override UniTask OnBeforeStartAsync()
	{
		BuildingMapTileModule.<OnBeforeStartAsync>d__25 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<BuildingMapTileModule.<OnBeforeStartAsync>d__25>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06008622 RID: 34338 RVA: 0x001C9733 File Offset: 0x001C7933
	public void RefreshRole()
	{
		this.InitRole().Forget();
	}

	// Token: 0x06008623 RID: 34339 RVA: 0x001C9740 File Offset: 0x001C7940
	private BuildingMapTileModule.TileItem InitTileItem()
	{
		return new BuildingMapTileModule.TileItem(this.TileMgr);
	}

	// Token: 0x06008624 RID: 34340 RVA: 0x001C9750 File Offset: 0x001C7950
	public void SetAllBuildingExhibitionMode(bool bShowOnly)
	{
		foreach (BuildingItem buildingItem in this.BuildingItemMap.Values)
		{
			buildingItem.SetExhibitionMode(bShowOnly);
			buildingItem.SetInteractive(!bShowOnly);
		}
	}

	// Token: 0x06008625 RID: 34341 RVA: 0x001C97B0 File Offset: 0x001C79B0
	public void SetBuildingItemActive(bool value)
	{
		foreach (BuildingItem buildingItem in this.BuildingItemMap.Values)
		{
			buildingItem.SetBuildingItemActive(value);
		}
	}

	// Token: 0x06008626 RID: 34342 RVA: 0x001C9808 File Offset: 0x001C7A08
	public void RefreshBuildingItem(int buildingId)
	{
		this.BuildingItemMap[buildingId].Refresh();
	}

	// Token: 0x04003C11 RID: 15377
	private readonly BuildingMapTileMgr TileMgr = new BuildingMapTileMgr();

	// Token: 0x04003C12 RID: 15378
	protected GenericLayout<BuildingMapTileModule.TileItem, string> MapLayout;

	// Token: 0x04003C13 RID: 15379
	private readonly Dictionary<int, BuildingItem> BuildingItemMap = new Dictionary<int, BuildingItem>();

	// Token: 0x04003C14 RID: 15380
	private readonly List<BuildingRoleItem> RoleItemList = new List<BuildingRoleItem>();

	// Token: 0x04003C15 RID: 15381
	private BuildingMapShowRoleModule ShowRoleItem;

	// Token: 0x02007916 RID: 30998
	[NullableContext(0)]
	private static class ETileItem
	{
		// Token: 0x04027E45 RID: 163397
		public const int Texture = 0;
	}

	// Token: 0x02007917 RID: 30999
	[Nullable(new byte[]
	{
		0,
		1
	})]
	protected class TileItem : GridProxyAbstract<string>
	{
		// Token: 0x06049299 RID: 299673 RVA: 0x012E37A6 File Offset: 0x012E19A6
		public TileItem(BuildingMapTileMgr tileMgr)
		{
			this.TileMgr = tileMgr;
		}

		// Token: 0x1700A02B RID: 41003
		// (get) Token: 0x0604929A RID: 299674 RVA: 0x012E37B5 File Offset: 0x012E19B5
		public BuildingMapTileMgr TileMgr { get; }

		// Token: 0x0604929B RID: 299675 RVA: 0x012E37BD File Offset: 0x012E19BD
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUITexture))
			};
		}

		// Token: 0x0604929C RID: 299676 RVA: 0x012E37E0 File Offset: 0x012E19E0
		public override void Refresh(string data, bool isSelected, int gridIndex)
		{
		}

		// Token: 0x0604929D RID: 299677 RVA: 0x012E37E4 File Offset: 0x012E19E4
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

	// Token: 0x02007918 RID: 31000
	[NullableContext(0)]
	private static class EComponentDefine
	{
		// Token: 0x04027E47 RID: 163399
		public const int TileRootItem = 0;

		// Token: 0x04027E48 RID: 163400
		public const int TileItem = 1;

		// Token: 0x04027E49 RID: 163401
		public const int RoleRootItem = 2;

		// Token: 0x04027E4A RID: 163402
		public const int BuildingItem1 = 3;

		// Token: 0x04027E4B RID: 163403
		public const int BuildingItem2 = 4;

		// Token: 0x04027E4C RID: 163404
		public const int BuildingItem3 = 5;

		// Token: 0x04027E4D RID: 163405
		public const int BuildingItem4 = 6;

		// Token: 0x04027E4E RID: 163406
		public const int BuildingItem5 = 7;

		// Token: 0x04027E4F RID: 163407
		public const int BuildingItem6 = 8;

		// Token: 0x04027E50 RID: 163408
		public const int BuildingItem7 = 9;

		// Token: 0x04027E51 RID: 163409
		public const int BuildingItem8 = 10;

		// Token: 0x04027E52 RID: 163410
		public const int BuildingItem9 = 11;

		// Token: 0x04027E53 RID: 163411
		public const int BuildingItem10 = 12;

		// Token: 0x04027E54 RID: 163412
		public const int ShowRoleRootItem = 13;
	}
}

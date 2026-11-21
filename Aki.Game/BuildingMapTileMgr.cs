using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020007A4 RID: 1956
[NullableContext(1)]
[Nullable(0)]
public class BuildingMapTileMgr
{
	// Token: 0x060059AB RID: 22955 RVA: 0x001D1FB4 File Offset: 0x001D01B4
	[return: Nullable(new byte[]
	{
		0,
		2
	})]
	private UniTask<UUITexture> LoadTileAssetAsync(string tag, string path)
	{
		BuildingMapTileMgr.<LoadTileAssetAsync>d__4 <LoadTileAssetAsync>d__;
		<LoadTileAssetAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<UUITexture>.Create();
		<LoadTileAssetAsync>d__.<>4__this = this;
		<LoadTileAssetAsync>d__.tag = tag;
		<LoadTileAssetAsync>d__.path = path;
		<LoadTileAssetAsync>d__.<>1__state = -1;
		<LoadTileAssetAsync>d__.<>t__builder.Start<BuildingMapTileMgr.<LoadTileAssetAsync>d__4>(ref <LoadTileAssetAsync>d__);
		return <LoadTileAssetAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060059AC RID: 22956 RVA: 0x001D2008 File Offset: 0x001D0208
	public List<string> CreateTilesPathList()
	{
		List<string> list = new List<string>();
		for (int i = 1; i <= 4; i++)
		{
			for (int j = 1; j <= 8; j++)
			{
				string resourceId = StringUtils.Format("ChasingMoonMap_{0}_{1}", new string[]
				{
					i.ToString(),
					j.ToString()
				});
				string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
				list.Add(resourcePath);
			}
		}
		return list;
	}

	// Token: 0x060059AD RID: 22957 RVA: 0x001D2070 File Offset: 0x001D0270
	public UniTask LoadMapTiles()
	{
		BuildingMapTileMgr.<LoadMapTiles>d__6 <LoadMapTiles>d__;
		<LoadMapTiles>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<LoadMapTiles>d__.<>4__this = this;
		<LoadMapTiles>d__.<>1__state = -1;
		<LoadMapTiles>d__.<>t__builder.Start<BuildingMapTileMgr.<LoadMapTiles>d__6>(ref <LoadMapTiles>d__);
		return <LoadMapTiles>d__.<>t__builder.Task;
	}

	// Token: 0x04003CA5 RID: 15525
	private const int COLUMNS_NUM = 8;

	// Token: 0x04003CA6 RID: 15526
	private const int ROW_NUM = 4;

	// Token: 0x04003CA7 RID: 15527
	private const string MAPTILE_NAME_TEMPLATE = "ChasingMoonMap_{0}_{1}";

	// Token: 0x04003CA8 RID: 15528
	private readonly Dictionary<string, UTexture> MapTilesMap = new Dictionary<string, UTexture>();
}

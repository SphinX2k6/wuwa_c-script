using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020012F0 RID: 4848
[NullableContext(1)]
[Nullable(0)]
public class BuildingMapTileMgr
{
	// Token: 0x06008610 RID: 34320 RVA: 0x001C9148 File Offset: 0x001C7348
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

	// Token: 0x06008611 RID: 34321 RVA: 0x001C919C File Offset: 0x001C739C
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

	// Token: 0x06008612 RID: 34322 RVA: 0x001C9204 File Offset: 0x001C7404
	public UniTask LoadMapTiles()
	{
		BuildingMapTileMgr.<LoadMapTiles>d__6 <LoadMapTiles>d__;
		<LoadMapTiles>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<LoadMapTiles>d__.<>4__this = this;
		<LoadMapTiles>d__.<>1__state = -1;
		<LoadMapTiles>d__.<>t__builder.Start<BuildingMapTileMgr.<LoadMapTiles>d__6>(ref <LoadMapTiles>d__);
		return <LoadMapTiles>d__.<>t__builder.Task;
	}

	// Token: 0x04003C0D RID: 15373
	private const int COLUMNS_NUM = 8;

	// Token: 0x04003C0E RID: 15374
	private const int ROW_NUM = 4;

	// Token: 0x04003C0F RID: 15375
	private const string MAPTILE_NAME_TEMPLATE = "ChasingMoonMap_{0}_{1}";

	// Token: 0x04003C10 RID: 15376
	private readonly Dictionary<string, UTexture> MapTilesMap = new Dictionary<string, UTexture>();
}

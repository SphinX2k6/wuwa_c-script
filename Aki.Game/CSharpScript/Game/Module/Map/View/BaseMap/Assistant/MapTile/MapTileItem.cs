using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.WorldMap.ViewComponent.SteamingLoad;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.View.BaseMap.Assistant.MapTile
{
	// Token: 0x02004482 RID: 17538
	[NullableContext(1)]
	[Nullable(0)]
	public class MapTileItem : IWorldMapStreamingObject
	{
		// Token: 0x17005876 RID: 22646
		// (get) Token: 0x0602C514 RID: 181524 RVA: 0x00C768E2 File Offset: 0x00C74AE2
		// (set) Token: 0x0602C515 RID: 181525 RVA: 0x00C768EA File Offset: 0x00C74AEA
		public bool IsStreaming { get; set; } = true;

		// Token: 0x17005877 RID: 22647
		// (get) Token: 0x0602C516 RID: 181526 RVA: 0x00C768F3 File Offset: 0x00C74AF3
		// (set) Token: 0x0602C517 RID: 181527 RVA: 0x00C768FB File Offset: 0x00C74AFB
		public bool IsVisible { get; set; }

		// Token: 0x0602C518 RID: 181528 RVA: 0x00C76904 File Offset: 0x00C74B04
		public MapTileItem(IMapTileCreateParam param)
		{
			this.MapTileCreateParam = param;
			this.UiPosition = Vector.Create(param.AnchorOffset.X, param.AnchorOffset.Y, 0.0);
			UUITextureBase mapTile = param.MapTile;
			this.PreloadThreshold = Vector2D.Create((double)(mapTile.GetWidth() * 2f), (double)(mapTile.GetHeight() * 2f));
		}

		// Token: 0x0602C519 RID: 181529 RVA: 0x00C76984 File Offset: 0x00C74B84
		public unsafe void OnLoad()
		{
			Dictionary<string, string> assetData = this.MapTileCreateParam.AssetData;
			EMapType mapType = this.MapTileCreateParam.MapType;
			int x = this.MapTileCreateParam.TileX;
			int y = this.MapTileCreateParam.TileY;
			UUITextureBase mapTile = this.MapTileCreateParam.MapTile;
			FColor fogDefaultColor = this.MapTileCreateParam.FogDefaultColor;
			int mapId = this.MapTileCreateParam.MapId;
			if (!string.IsNullOrEmpty(assetData["MapTilePath"]))
			{
				this.LoadHandle = ResourceSystem.Instance.LoadAsync<UTexture>(assetData["MapTilePath"], new Action<UTexture, string>(this.OnLoadEnd), 102, "Ui.MapUi");
				if (Info.Instance.IsPcOrGamepadPlatform() && !string.IsNullOrEmpty(assetData["HdMapTilePath"]) && mapType == EMapType.WorldMap)
				{
					Action<UTexture, string> callback = delegate([Nullable(2)] UTexture textureObject, string assetPath)
					{
						if (textureObject == null)
						{
							Log instance2 = Log.Instance;
							ELogModule module2 = ELogModule.Map;
							ELogAuthor author2 = ELogAuthor.LYX;
							string message2 = "[地图系统]->loadHdCallback 高清切块贴图为空";
							<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray4<ValueTuple<string, object>>);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("MapId", mapId);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("TileX", x);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("TileY", y);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 3) = new ValueTuple<string, object>("assetData", assetData);
							instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 4));
						}
						mapTile.SetCustomMaterialScalarParameter(MapTileItem.HD_SCALAR_NAME, 1f);
						mapTile.SetCustomMaterialTextureParameter(MapTileItem.HD_TEXTURE_NAME, textureObject);
					};
					this.LoadHandle = ResourceSystem.Instance.LoadAsync<UTexture>(assetData["HdMapTilePath"], callback, 102, "Ui.MapUi");
					return;
				}
			}
			else
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Map;
				ELogAuthor author = ELogAuthor.LRX;
				string message = "[地图系统]->切块贴图为空";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("MapId", mapId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("TileX", x);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("TileY", y);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				mapTile.SetTexture(null);
				mapTile.SetColor(fogDefaultColor);
			}
		}

		// Token: 0x0602C51A RID: 181530 RVA: 0x00C76B5C File Offset: 0x00C74D5C
		public void OnUnload()
		{
			UUITextureBase mapTile = this.MapTileCreateParam.MapTile;
			FColor fogDefaultColor = this.MapTileCreateParam.FogDefaultColor;
			mapTile.SetTexture(null);
			mapTile.SetColor(fogDefaultColor);
		}

		// Token: 0x0602C51B RID: 181531 RVA: 0x00C76B8D File Offset: 0x00C74D8D
		public Vector2D GetPreloadThreshold()
		{
			return this.PreloadThreshold;
		}

		// Token: 0x0602C51C RID: 181532 RVA: 0x00C76B95 File Offset: 0x00C74D95
		public Vector GetUiPosition()
		{
			return this.UiPosition;
		}

		// Token: 0x0602C51D RID: 181533 RVA: 0x00C76B9D File Offset: 0x00C74D9D
		public void ReleaseLoadHandle()
		{
			if (this.LoadHandle != -1)
			{
				ResourceSystem.Instance.CancelAsyncLoad(this.LoadHandle);
				this.LoadHandle = -1;
			}
		}

		// Token: 0x0602C51E RID: 181534 RVA: 0x00C76BBF File Offset: 0x00C74DBF
		private void OnLoadEnd(UTexture textureObject, string assetPath)
		{
			this.LoadHandle = -1;
			Action<UTexture> loadMapTileCallBack = this.MapTileCreateParam.LoadMapTileCallBack;
			if (loadMapTileCallBack == null)
			{
				return;
			}
			loadMapTileCallBack(textureObject);
		}

		// Token: 0x04017D43 RID: 97603
		private readonly IMapTileCreateParam MapTileCreateParam;

		// Token: 0x04017D44 RID: 97604
		private readonly Vector UiPosition;

		// Token: 0x04017D45 RID: 97605
		private readonly Vector2D PreloadThreshold;

		// Token: 0x04017D46 RID: 97606
		private int LoadHandle = -1;

		// Token: 0x04017D47 RID: 97607
		public static readonly FName HD_TEXTURE_NAME = new FName("HDTexture");

		// Token: 0x04017D48 RID: 97608
		public static readonly FName HD_SCALAR_NAME = new FName("UseHDPicture");
	}
}

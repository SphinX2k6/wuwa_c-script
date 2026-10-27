using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.WorldMap.ViewComponent.SteamingLoad;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.View.BaseMap.Assistant.MapTile
{
	// Token: 0x0200549F RID: 21663
	[NullableContext(1)]
	[Nullable(0)]
	public class MapTileItem : IWorldMapStreamingObject
	{
		// Token: 0x170084AA RID: 33962
		// (get) Token: 0x060375C0 RID: 226752 RVA: 0x00D26C8B File Offset: 0x00D24E8B
		// (set) Token: 0x060375C1 RID: 226753 RVA: 0x00D26C93 File Offset: 0x00D24E93
		public bool IsStreaming { get; set; } = true;

		// Token: 0x170084AB RID: 33963
		// (get) Token: 0x060375C2 RID: 226754 RVA: 0x00D26C9C File Offset: 0x00D24E9C
		// (set) Token: 0x060375C3 RID: 226755 RVA: 0x00D26CA4 File Offset: 0x00D24EA4
		public bool IsVisible { get; set; }

		// Token: 0x060375C4 RID: 226756 RVA: 0x00D26CB0 File Offset: 0x00D24EB0
		public MapTileItem(IMapTileCreateParam param)
		{
			this.MapTileCreateParam = param;
			this.UiPosition = Vector.Create(param.AnchorOffset.X, param.AnchorOffset.Y, 0.0);
			UUITextureBase mapTile = param.MapTile;
			this.PreloadThreshold = Vector2D.Create((double)(mapTile.GetWidth() * 2f), (double)(mapTile.GetHeight() * 2f));
		}

		// Token: 0x060375C5 RID: 226757 RVA: 0x00D26D30 File Offset: 0x00D24F30
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

		// Token: 0x060375C6 RID: 226758 RVA: 0x00D26F08 File Offset: 0x00D25108
		public void OnUnload()
		{
			UUITextureBase mapTile = this.MapTileCreateParam.MapTile;
			FColor fogDefaultColor = this.MapTileCreateParam.FogDefaultColor;
			mapTile.SetTexture(null);
			mapTile.SetColor(fogDefaultColor);
		}

		// Token: 0x060375C7 RID: 226759 RVA: 0x00D26F39 File Offset: 0x00D25139
		public Vector2D GetPreloadThreshold()
		{
			return this.PreloadThreshold;
		}

		// Token: 0x060375C8 RID: 226760 RVA: 0x00D26F41 File Offset: 0x00D25141
		public Vector GetUiPosition()
		{
			return this.UiPosition;
		}

		// Token: 0x060375C9 RID: 226761 RVA: 0x00D26F49 File Offset: 0x00D25149
		public void ReleaseLoadHandle()
		{
			if (this.LoadHandle != -1)
			{
				ResourceSystem.Instance.CancelAsyncLoad(this.LoadHandle);
				this.LoadHandle = -1;
			}
		}

		// Token: 0x060375CA RID: 226762 RVA: 0x00D26F6B File Offset: 0x00D2516B
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

		// Token: 0x0401D2A7 RID: 119463
		private readonly IMapTileCreateParam MapTileCreateParam;

		// Token: 0x0401D2A8 RID: 119464
		private readonly Vector UiPosition;

		// Token: 0x0401D2A9 RID: 119465
		private readonly Vector2D PreloadThreshold;

		// Token: 0x0401D2AA RID: 119466
		private int LoadHandle = -1;

		// Token: 0x0401D2AB RID: 119467
		public static readonly FName HD_TEXTURE_NAME = new FName("HDTexture");

		// Token: 0x0401D2AC RID: 119468
		public static readonly FName HD_SCALAR_NAME = new FName("UseHDPicture");
	}
}

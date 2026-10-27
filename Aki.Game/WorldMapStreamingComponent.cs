using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.Base;
using CSharpScript.Game.Module.WorldMap;
using CSharpScript.Game.Module.WorldMap.ViewComponent;
using CSharpScript.Game.Module.WorldMap.ViewComponent.SteamingLoad;

// Token: 0x02002D78 RID: 11640
[NullableContext(1)]
[Nullable(0)]
public class WorldMapStreamingComponent : MapComponent
{
	// Token: 0x06018796 RID: 100246 RVA: 0x0063A5A8 File Offset: 0x006387A8
	public WorldMapStreamingComponent([Nullable(new byte[]
	{
		0,
		1,
		1,
		1
	})] OneOf<MapComponent, MapComponentContainer, MapEntity> parent) : base(parent)
	{
	}

	// Token: 0x17002115 RID: 8469
	// (get) Token: 0x06018797 RID: 100247 RVA: 0x0063A5FE File Offset: 0x006387FE
	public override EMapComponent ComponentType
	{
		get
		{
			return EMapComponent.WorldMapStreaming;
		}
	}

	// Token: 0x17002116 RID: 8470
	// (get) Token: 0x06018798 RID: 100248 RVA: 0x0063A604 File Offset: 0x00638804
	[Nullable(2)]
	private WorldMapUiEntity WorldMapUiComponent
	{
		[NullableContext(2)]
		get
		{
			WorldMapUiEntity worldMapUiEntity = base.Parent.AsT3 as WorldMapUiEntity;
			if (worldMapUiEntity == null)
			{
				base.LogError(ELogAuthor.LRX, "[地图系统]->二级界面组件没有附加到容器下！", default(ReadOnlySpan<ValueTuple<string, object>>));
				return null;
			}
			return worldMapUiEntity;
		}
	}

	// Token: 0x06018799 RID: 100249 RVA: 0x0063A644 File Offset: 0x00638844
	protected override void OnUpdate()
	{
		this.RefreshViewportCache();
		foreach (IWorldMapStreamingObject obj in this.StreamingObjectSet)
		{
			this.HandleStreamingUpdate(obj);
		}
	}

	// Token: 0x0601879A RID: 100250 RVA: 0x0063A6A0 File Offset: 0x006388A0
	public void RefreshViewportCache()
	{
		WorldMapUiEntity worldMapUiComponent = this.WorldMapUiComponent;
		Vector2D mapUiPosition = worldMapUiComponent.MoveComponent.MapUiPosition;
		Vector2D outOfViewPortSize = worldMapUiComponent.OutOfViewPortSize;
		this.MapUiPositionCache.Set(mapUiPosition.X, mapUiPosition.Y);
		this.OutOfViewPortSizeCache.Set(outOfViewPortSize.X, outOfViewPortSize.Y);
		this.MapScaleCache = WorldMapModel.Instance.MapScale;
	}

	// Token: 0x0601879B RID: 100251 RVA: 0x0063A703 File Offset: 0x00638903
	protected override void OnRemove()
	{
		this.StreamingObjectSet.Clear();
		this.StreamingStateMap.Clear();
	}

	// Token: 0x0601879C RID: 100252 RVA: 0x0063A71B File Offset: 0x0063891B
	public void Bind(IWorldMapStreamingObject obj)
	{
		this.StreamingObjectSet.Add(obj);
	}

	// Token: 0x0601879D RID: 100253 RVA: 0x0063A72A File Offset: 0x0063892A
	public void Unbind(IWorldMapStreamingObject obj)
	{
		this.StreamingObjectSet.Remove(obj);
		this.StreamingStateMap.Remove(obj);
	}

	// Token: 0x0601879E RID: 100254 RVA: 0x0063A748 File Offset: 0x00638948
	public void BindAll(IReadOnlyList<IWorldMapStreamingObject> objList)
	{
		foreach (IWorldMapStreamingObject obj in objList)
		{
			this.Bind(obj);
		}
	}

	// Token: 0x0601879F RID: 100255 RVA: 0x0063A790 File Offset: 0x00638990
	public bool HandleStreamingUpdate(IWorldMapStreamingObject obj)
	{
		bool flag = this.IsInStreamingRange(obj);
		bool value;
		bool? flag2 = this.StreamingStateMap.TryGetValue(obj, out value) ? new bool?(value) : null;
		if (flag2 == null || flag != flag2.Value)
		{
			this.StreamingStateMap[obj] = flag;
			obj.IsVisible = flag;
			if (flag)
			{
				obj.OnLoad();
			}
			else
			{
				obj.OnUnload();
			}
		}
		return flag;
	}

	// Token: 0x060187A0 RID: 100256 RVA: 0x0063A800 File Offset: 0x00638A00
	public bool IsInStreamingRange(IWorldMapStreamingObject obj)
	{
		if (!obj.IsStreaming)
		{
			return true;
		}
		Vector uiPosition = obj.GetUiPosition();
		this.ObjectPositionInMapViewportTemp.Set(uiPosition.X * (double)this.MapScaleCache + this.MapUiPositionCache.X, uiPosition.Y * (double)this.MapScaleCache + this.MapUiPositionCache.Y);
		Vector2D preloadThreshold = obj.GetPreloadThreshold();
		return Math.Abs(this.ObjectPositionInMapViewportTemp.X) <= this.OutOfViewPortSizeCache.X + preloadThreshold.X && Math.Abs(this.ObjectPositionInMapViewportTemp.Y) <= this.OutOfViewPortSizeCache.Y + preloadThreshold.Y;
	}

	// Token: 0x0400B568 RID: 46440
	private readonly HashSet<IWorldMapStreamingObject> StreamingObjectSet = new HashSet<IWorldMapStreamingObject>();

	// Token: 0x0400B569 RID: 46441
	private readonly Dictionary<IWorldMapStreamingObject, bool> StreamingStateMap = new Dictionary<IWorldMapStreamingObject, bool>();

	// Token: 0x0400B56A RID: 46442
	private readonly Vector2D ObjectPositionInMapViewportTemp = Vector2D.Create();

	// Token: 0x0400B56B RID: 46443
	private readonly Vector2D MapUiPositionCache = Vector2D.Create();

	// Token: 0x0400B56C RID: 46444
	private readonly Vector2D OutOfViewPortSizeCache = Vector2D.Create();

	// Token: 0x0400B56D RID: 46445
	private float MapScaleCache = 1f;
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.Base;
using CSharpScript.Game.Module.WorldMap;
using CSharpScript.Game.Module.WorldMap.ViewComponent;
using CSharpScript.Game.Module.WorldMap.ViewComponent.SteamingLoad;

// Token: 0x020022D2 RID: 8914
[NullableContext(1)]
[Nullable(0)]
public class WorldMapStreamingComponent : MapComponent
{
	// Token: 0x06016038 RID: 90168 RVA: 0x006605C0 File Offset: 0x0065E7C0
	public WorldMapStreamingComponent([Nullable(new byte[]
	{
		0,
		1,
		1,
		1
	})] OneOf<MapComponent, MapComponentContainer, MapEntity> parent) : base(parent)
	{
	}

	// Token: 0x17002170 RID: 8560
	// (get) Token: 0x06016039 RID: 90169 RVA: 0x00660616 File Offset: 0x0065E816
	public override EMapComponent ComponentType
	{
		get
		{
			return EMapComponent.WorldMapStreaming;
		}
	}

	// Token: 0x17002171 RID: 8561
	// (get) Token: 0x0601603A RID: 90170 RVA: 0x0066061C File Offset: 0x0065E81C
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

	// Token: 0x0601603B RID: 90171 RVA: 0x0066065C File Offset: 0x0065E85C
	protected override void OnUpdate()
	{
		this.RefreshViewportCache();
		foreach (IWorldMapStreamingObject obj in this.StreamingObjectSet)
		{
			this.HandleStreamingUpdate(obj);
		}
	}

	// Token: 0x0601603C RID: 90172 RVA: 0x006606B8 File Offset: 0x0065E8B8
	public void RefreshViewportCache()
	{
		WorldMapUiEntity worldMapUiComponent = this.WorldMapUiComponent;
		Vector2D mapUiPosition = worldMapUiComponent.MoveComponent.MapUiPosition;
		Vector2D outOfViewPortSize = worldMapUiComponent.OutOfViewPortSize;
		this.MapUiPositionCache.Set(mapUiPosition.X, mapUiPosition.Y);
		this.OutOfViewPortSizeCache.Set(outOfViewPortSize.X, outOfViewPortSize.Y);
		this.MapScaleCache = WorldMapModel.Instance.MapScale;
	}

	// Token: 0x0601603D RID: 90173 RVA: 0x0066071B File Offset: 0x0065E91B
	protected override void OnRemove()
	{
		this.StreamingObjectSet.Clear();
		this.StreamingStateMap.Clear();
	}

	// Token: 0x0601603E RID: 90174 RVA: 0x00660733 File Offset: 0x0065E933
	public void Bind(IWorldMapStreamingObject obj)
	{
		this.StreamingObjectSet.Add(obj);
	}

	// Token: 0x0601603F RID: 90175 RVA: 0x00660742 File Offset: 0x0065E942
	public void Unbind(IWorldMapStreamingObject obj)
	{
		this.StreamingObjectSet.Remove(obj);
		this.StreamingStateMap.Remove(obj);
	}

	// Token: 0x06016040 RID: 90176 RVA: 0x00660760 File Offset: 0x0065E960
	public void BindAll(IReadOnlyList<IWorldMapStreamingObject> objList)
	{
		foreach (IWorldMapStreamingObject obj in objList)
		{
			this.Bind(obj);
		}
	}

	// Token: 0x06016041 RID: 90177 RVA: 0x006607A8 File Offset: 0x0065E9A8
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

	// Token: 0x06016042 RID: 90178 RVA: 0x00660818 File Offset: 0x0065EA18
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

	// Token: 0x0400B8DD RID: 47325
	private readonly HashSet<IWorldMapStreamingObject> StreamingObjectSet = new HashSet<IWorldMapStreamingObject>();

	// Token: 0x0400B8DE RID: 47326
	private readonly Dictionary<IWorldMapStreamingObject, bool> StreamingStateMap = new Dictionary<IWorldMapStreamingObject, bool>();

	// Token: 0x0400B8DF RID: 47327
	private readonly Vector2D ObjectPositionInMapViewportTemp = Vector2D.Create();

	// Token: 0x0400B8E0 RID: 47328
	private readonly Vector2D MapUiPositionCache = Vector2D.Create();

	// Token: 0x0400B8E1 RID: 47329
	private readonly Vector2D OutOfViewPortSizeCache = Vector2D.Create();

	// Token: 0x0400B8E2 RID: 47330
	private float MapScaleCache = 1f;
}

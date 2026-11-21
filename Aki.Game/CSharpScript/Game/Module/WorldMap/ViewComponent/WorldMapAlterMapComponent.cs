using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Map.Base;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.View.BaseMap;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.ViewComponent
{
	// Token: 0x020036DE RID: 14046
	[NullableContext(2)]
	[Nullable(0)]
	public class WorldMapAlterMapComponent : MapComponent
	{
		// Token: 0x0602483C RID: 149564 RVA: 0x00A509B1 File Offset: 0x00A4EBB1
		public WorldMapAlterMapComponent([Nullable(new byte[]
		{
			0,
			1,
			1,
			1
		})] OneOf<MapComponent, MapComponentContainer, MapEntity> parent) : base(parent)
		{
		}

		// Token: 0x17004AF1 RID: 19185
		// (get) Token: 0x0602483D RID: 149565 RVA: 0x00A509BA File Offset: 0x00A4EBBA
		public override EMapComponent ComponentType
		{
			get
			{
				return EMapComponent.WorldMapAlterMap;
			}
		}

		// Token: 0x17004AF2 RID: 19186
		// (get) Token: 0x0602483E RID: 149566 RVA: 0x00A509C0 File Offset: 0x00A4EBC0
		private WorldMapUiEntity WorldMapUiComponent
		{
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

		// Token: 0x0602483F RID: 149567 RVA: 0x00A509FD File Offset: 0x00A4EBFD
		protected override void OnEnable()
		{
			EventSystem.Instance.Add(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
		}

		// Token: 0x06024840 RID: 149568 RVA: 0x00A50A1B File Offset: 0x00A4EC1B
		protected override void OnDisable()
		{
			this.CancelWaitSequence();
			EventSystem.Instance.Remove(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
		}

		// Token: 0x06024841 RID: 149569 RVA: 0x00A50A3F File Offset: 0x00A4EC3F
		private void CancelWaitSequence()
		{
			CustomPromise<bool> waitSequencePromise = this.WaitSequencePromise;
			if (waitSequencePromise != null)
			{
				waitSequencePromise.SetResult(false);
			}
			this.WaitSequencePromise = null;
		}

		// Token: 0x06024842 RID: 149570 RVA: 0x00A50A5C File Offset: 0x00A4EC5C
		public UniTask ChangeMapAsync(int mapId, EMapGravityDirection? gravity = null, int navigateAreaId = 0)
		{
			WorldMapAlterMapComponent.<ChangeMapAsync>d__11 <ChangeMapAsync>d__;
			<ChangeMapAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ChangeMapAsync>d__.<>4__this = this;
			<ChangeMapAsync>d__.mapId = mapId;
			<ChangeMapAsync>d__.gravity = gravity;
			<ChangeMapAsync>d__.navigateAreaId = navigateAreaId;
			<ChangeMapAsync>d__.<>1__state = -1;
			<ChangeMapAsync>d__.<>t__builder.Start<WorldMapAlterMapComponent.<ChangeMapAsync>d__11>(ref <ChangeMapAsync>d__);
			return <ChangeMapAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06024843 RID: 149571 RVA: 0x00A50AB7 File Offset: 0x00A4ECB7
		[NullableContext(1)]
		private void OnActivitySequenceEmitEvent(string param)
		{
			if (param == "Invert")
			{
				CustomPromise<bool> waitSequencePromise = this.WaitSequencePromise;
				if (waitSequencePromise != null)
				{
					waitSequencePromise.SetResult(true);
				}
				this.WaitSequencePromise = null;
			}
		}

		// Token: 0x06024844 RID: 149572 RVA: 0x00A50AE0 File Offset: 0x00A4ECE0
		private UniTask ResolveChangeMap(int mapId, EMapGravityDirection? gravity, int navigateAreaId)
		{
			WorldMapAlterMapComponent.<ResolveChangeMap>d__13 <ResolveChangeMap>d__;
			<ResolveChangeMap>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ResolveChangeMap>d__.<>4__this = this;
			<ResolveChangeMap>d__.mapId = mapId;
			<ResolveChangeMap>d__.gravity = gravity;
			<ResolveChangeMap>d__.navigateAreaId = navigateAreaId;
			<ResolveChangeMap>d__.<>1__state = -1;
			<ResolveChangeMap>d__.<>t__builder.Start<WorldMapAlterMapComponent.<ResolveChangeMap>d__13>(ref <ResolveChangeMap>d__);
			return <ResolveChangeMap>d__.<>t__builder.Task;
		}

		// Token: 0x06024845 RID: 149573 RVA: 0x00A50B3C File Offset: 0x00A4ED3C
		public void ChangeMapGravity()
		{
			EMapGravityDirection worldMapGravity = WorldMapModel.Instance.WorldMapGravity;
			EMapGravityDirection value;
			if (worldMapGravity != EMapGravityDirection.Down)
			{
				if (worldMapGravity != EMapGravityDirection.Up)
				{
					return;
				}
				value = EMapGravityDirection.Down;
			}
			else
			{
				value = EMapGravityDirection.Up;
			}
			WorldMapModel.Instance.WorldMapSelectGravity = new EMapGravityDirection?(value);
			BaseMap map = this.WorldMapUiComponent.Map;
			this.ChangeMapAsync(map.MapId, new EMapGravityDirection?(WorldMapModel.Instance.WorldMapGravity), 0).Forget();
		}

		// Token: 0x17004AF3 RID: 19187
		// (get) Token: 0x06024846 RID: 149574 RVA: 0x00A50BA4 File Offset: 0x00A4EDA4
		public bool CanChangeMapGravity
		{
			get
			{
				int mapId = this.WorldMapUiComponent.Map.MapId;
				return WorldMapModel.Instance.IsGravityMap(mapId);
			}
		}

		// Token: 0x06024847 RID: 149575 RVA: 0x00A50BD0 File Offset: 0x00A4EDD0
		protected override void OnRemove()
		{
			WorldMapModel.Instance.WorldMapSelectGravity = null;
		}

		// Token: 0x0401452E RID: 83246
		public TWorldMapPlaySequenceFunction WorldMapViewPlaySequenceFunction;

		// Token: 0x0401452F RID: 83247
		public UUIItem InverseTowerCtrlRoot;

		// Token: 0x04014530 RID: 83248
		private CustomPromise<bool> WaitSequencePromise;
	}
}

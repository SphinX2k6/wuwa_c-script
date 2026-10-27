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
	// Token: 0x020047AD RID: 18349
	[NullableContext(2)]
	[Nullable(0)]
	public class WorldMapAlterMapComponent : MapComponent
	{
		// Token: 0x0603006D RID: 196717 RVA: 0x00B20A65 File Offset: 0x00B1EC65
		public WorldMapAlterMapComponent([Nullable(new byte[]
		{
			0,
			1,
			1,
			1
		})] OneOf<MapComponent, MapComponentContainer, MapEntity> parent) : base(parent)
		{
		}

		// Token: 0x17007835 RID: 30773
		// (get) Token: 0x0603006E RID: 196718 RVA: 0x00B20A6E File Offset: 0x00B1EC6E
		public override EMapComponent ComponentType
		{
			get
			{
				return EMapComponent.WorldMapAlterMap;
			}
		}

		// Token: 0x17007836 RID: 30774
		// (get) Token: 0x0603006F RID: 196719 RVA: 0x00B20A74 File Offset: 0x00B1EC74
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

		// Token: 0x06030070 RID: 196720 RVA: 0x00B20AB1 File Offset: 0x00B1ECB1
		protected override void OnEnable()
		{
			EventSystem.Instance.Add(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
		}

		// Token: 0x06030071 RID: 196721 RVA: 0x00B20ACF File Offset: 0x00B1ECCF
		protected override void OnDisable()
		{
			this.CancelWaitSequence();
			EventSystem.Instance.Remove(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
		}

		// Token: 0x06030072 RID: 196722 RVA: 0x00B20AF3 File Offset: 0x00B1ECF3
		private void CancelWaitSequence()
		{
			CustomPromise<bool> waitSequencePromise = this.WaitSequencePromise;
			if (waitSequencePromise != null)
			{
				waitSequencePromise.SetResult(false);
			}
			this.WaitSequencePromise = null;
		}

		// Token: 0x06030073 RID: 196723 RVA: 0x00B20B10 File Offset: 0x00B1ED10
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

		// Token: 0x06030074 RID: 196724 RVA: 0x00B20B6B File Offset: 0x00B1ED6B
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

		// Token: 0x06030075 RID: 196725 RVA: 0x00B20B94 File Offset: 0x00B1ED94
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

		// Token: 0x06030076 RID: 196726 RVA: 0x00B20BF0 File Offset: 0x00B1EDF0
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

		// Token: 0x17007837 RID: 30775
		// (get) Token: 0x06030077 RID: 196727 RVA: 0x00B20C58 File Offset: 0x00B1EE58
		public bool CanChangeMapGravity
		{
			get
			{
				int mapId = this.WorldMapUiComponent.Map.MapId;
				return WorldMapModel.Instance.IsGravityMap(mapId);
			}
		}

		// Token: 0x06030078 RID: 196728 RVA: 0x00B20C84 File Offset: 0x00B1EE84
		protected override void OnRemove()
		{
			WorldMapModel.Instance.WorldMapSelectGravity = null;
		}

		// Token: 0x04019E7E RID: 106110
		public TWorldMapPlaySequenceFunction WorldMapViewPlaySequenceFunction;

		// Token: 0x04019E7F RID: 106111
		public UUIItem InverseTowerCtrlRoot;

		// Token: 0x04019E80 RID: 106112
		private CustomPromise<bool> WaitSequencePromise;
	}
}

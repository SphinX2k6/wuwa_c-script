using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Mark;
using CSharpScript.Game.Module.Map.Marks.MarkItemView.Components;
using CSharpScript.Game.Module.Map.View.BaseMap;
using CSharpScript.Game.Module.WorldMap;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.View.SubView
{
	// Token: 0x0200548B RID: 21643
	[NullableContext(2)]
	[Nullable(0)]
	public class MapRangePanel
	{
		// Token: 0x1700847E RID: 33918
		// (get) Token: 0x0603745C RID: 226396 RVA: 0x00D1DAD6 File Offset: 0x00D1BCD6
		[Nullable(new byte[]
		{
			0,
			1,
			1
		})]
		public OneOf<BaseMap, MiniMap> Map { [return: Nullable(new byte[]
		{
			0,
			1,
			1
		})] get; }

		// Token: 0x0603745D RID: 226397 RVA: 0x00D1DADE File Offset: 0x00D1BCDE
		public MapRangePanel([Nullable(new byte[]
		{
			0,
			1,
			1
		})] OneOf<BaseMap, MiniMap> map)
		{
			this.Map = map;
			EventSystem.Instance.Add(EEventName.HideNavigateMarkRange, new Action(this.EventHideNavigateMarkRange));
		}

		// Token: 0x0603745E RID: 226398 RVA: 0x00D1DB0C File Offset: 0x00D1BD0C
		private UUIItem GetRootItem()
		{
			if (this.Map.IsT1)
			{
				return this.Map.AsT1.GetRootItem();
			}
			if (this.Map.IsT2)
			{
				return this.Map.AsT2.GetRootItem();
			}
			return null;
		}

		// Token: 0x1700847F RID: 33919
		// (get) Token: 0x0603745F RID: 226399 RVA: 0x00D1DB64 File Offset: 0x00D1BD64
		private int? MapId
		{
			get
			{
				if (this.Map.IsT1)
				{
					return new int?(this.Map.AsT1.MapId);
				}
				if (this.Map.IsT2)
				{
					return new int?(this.Map.AsT2.MapId);
				}
				return null;
			}
		}

		// Token: 0x17008480 RID: 33920
		// (get) Token: 0x06037460 RID: 226400 RVA: 0x00D1DBCC File Offset: 0x00D1BDCC
		private EMapGravityDirection? MapGravity
		{
			get
			{
				if (this.Map.IsT1)
				{
					return new EMapGravityDirection?(this.Map.AsT1.MapGravity);
				}
				if (this.Map.IsT2)
				{
					return new EMapGravityDirection?(this.Map.AsT2.MapGravity);
				}
				return null;
			}
		}

		// Token: 0x06037461 RID: 226401 RVA: 0x00D1DC34 File Offset: 0x00D1BE34
		private UniTask InitRangeComponentAsync()
		{
			MapRangePanel.<InitRangeComponentAsync>d__14 <InitRangeComponentAsync>d__;
			<InitRangeComponentAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitRangeComponentAsync>d__.<>4__this = this;
			<InitRangeComponentAsync>d__.<>1__state = -1;
			<InitRangeComponentAsync>d__.<>t__builder.Start<MapRangePanel.<InitRangeComponentAsync>d__14>(ref <InitRangeComponentAsync>d__);
			return <InitRangeComponentAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06037462 RID: 226402 RVA: 0x00D1DC78 File Offset: 0x00D1BE78
		[NullableContext(1)]
		public UniTask SetRangeComponentShow(Vector2D pos, float? width = null, float? height = null)
		{
			MapRangePanel.<SetRangeComponentShow>d__15 <SetRangeComponentShow>d__;
			<SetRangeComponentShow>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SetRangeComponentShow>d__.<>4__this = this;
			<SetRangeComponentShow>d__.pos = pos;
			<SetRangeComponentShow>d__.width = width;
			<SetRangeComponentShow>d__.height = height;
			<SetRangeComponentShow>d__.<>1__state = -1;
			<SetRangeComponentShow>d__.<>t__builder.Start<MapRangePanel.<SetRangeComponentShow>d__15>(ref <SetRangeComponentShow>d__);
			return <SetRangeComponentShow>d__.<>t__builder.Task;
		}

		// Token: 0x06037463 RID: 226403 RVA: 0x00D1DCD4 File Offset: 0x00D1BED4
		public UniTask SetRangeComponentHide(bool isClearInfo = true)
		{
			MapRangePanel.<SetRangeComponentHide>d__16 <SetRangeComponentHide>d__;
			<SetRangeComponentHide>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SetRangeComponentHide>d__.<>4__this = this;
			<SetRangeComponentHide>d__.isClearInfo = isClearInfo;
			<SetRangeComponentHide>d__.<>1__state = -1;
			<SetRangeComponentHide>d__.<>t__builder.Start<MapRangePanel.<SetRangeComponentHide>d__16>(ref <SetRangeComponentHide>d__);
			return <SetRangeComponentHide>d__.<>t__builder.Task;
		}

		// Token: 0x06037464 RID: 226404 RVA: 0x00D1DD20 File Offset: 0x00D1BF20
		private UniTask WaitRangeComponent()
		{
			MapRangePanel.<WaitRangeComponent>d__17 <WaitRangeComponent>d__;
			<WaitRangeComponent>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<WaitRangeComponent>d__.<>4__this = this;
			<WaitRangeComponent>d__.<>1__state = -1;
			<WaitRangeComponent>d__.<>t__builder.Start<MapRangePanel.<WaitRangeComponent>d__17>(ref <WaitRangeComponent>d__);
			return <WaitRangeComponent>d__.<>t__builder.Task;
		}

		// Token: 0x06037465 RID: 226405 RVA: 0x00D1DD64 File Offset: 0x00D1BF64
		public void CheckExploreMarkRangeInfo()
		{
			IMapMarkRangeInfo mapRangeInfo = WorldMapModel.Instance.MapRangeInfo;
			if (mapRangeInfo != null)
			{
				int? mapId = mapRangeInfo.MapId;
				int? mapId2 = this.MapId;
				if (mapId.GetValueOrDefault() == mapId2.GetValueOrDefault() & mapId != null == (mapId2 != null))
				{
					EMapGravityDirection? gravity = mapRangeInfo.Gravity;
					EMapGravityDirection? mapGravity = this.MapGravity;
					if (gravity.GetValueOrDefault() == mapGravity.GetValueOrDefault() & gravity != null == (mapGravity != null))
					{
						if (this.CheckShowRangeMarkIsDiscover())
						{
							this.SetRangeComponentHide(true).Forget();
							return;
						}
						if (!WorldMapModel.Instance.IsMapRangeVisible)
						{
							this.SetRangeComponentHide(false).Forget();
							return;
						}
						this.SetRangeComponentShow(mapRangeInfo.Position, mapRangeInfo.Width, mapRangeInfo.Height).Forget();
						return;
					}
				}
			}
		}

		// Token: 0x06037466 RID: 226406 RVA: 0x00D1DE30 File Offset: 0x00D1C030
		public void MiniMapUpdate()
		{
			IMapMarkRangeInfo mapRangeInfo = WorldMapModel.Instance.MapRangeInfo;
			if (mapRangeInfo != null)
			{
				int? mapId = mapRangeInfo.MapId;
				int? num = this.MapId;
				if (mapId.GetValueOrDefault() == num.GetValueOrDefault() & mapId != null == (num != null))
				{
					EMapGravityDirection? gravity = mapRangeInfo.Gravity;
					EMapGravityDirection? emapGravityDirection = this.MapGravity;
					if (gravity.GetValueOrDefault() == emapGravityDirection.GetValueOrDefault() & gravity != null == (emapGravityDirection != null))
					{
						if (this.CacheRangePosition != null && Math.Abs(this.CacheRangePosition.X - mapRangeInfo.Position.X) <= 9.99999993922529E-09 && Math.Abs(this.CacheRangePosition.Y - mapRangeInfo.Position.Y) <= 9.99999993922529E-09)
						{
							emapGravityDirection = this.CacheGravity;
							gravity = mapRangeInfo.Gravity;
							if (emapGravityDirection.GetValueOrDefault() == gravity.GetValueOrDefault() & emapGravityDirection != null == (gravity != null))
							{
								num = this.CacheMapId;
								mapId = mapRangeInfo.MapId;
								if ((num.GetValueOrDefault() == mapId.GetValueOrDefault() & num != null == (mapId != null)) && !this.CheckShowRangeMarkIsDiscover())
								{
									return;
								}
							}
						}
						this.CheckExploreMarkRangeInfo();
						this.CacheRangePosition = Vector2D.Create(mapRangeInfo.Position.X, mapRangeInfo.Position.Y);
						this.CacheGravity = mapRangeInfo.Gravity;
						this.CacheMapId = mapRangeInfo.MapId;
						return;
					}
				}
			}
			this.SetRangeComponentHide(true).Forget();
		}

		// Token: 0x06037467 RID: 226407 RVA: 0x00D1DFC4 File Offset: 0x00D1C1C4
		private bool CheckShowRangeMarkIsDiscover()
		{
			NavigateMarkShowRange navigateMarkShowRangeInfo = WorldMapModel.Instance.NavigateMarkShowRangeInfo;
			if (navigateMarkShowRangeInfo == null)
			{
				return false;
			}
			if (navigateMarkShowRangeInfo.IsDiscover.GetValueOrDefault())
			{
				return true;
			}
			MapMark? configMark = MapConfig.Instance.GetConfigMark(navigateMarkShowRangeInfo.MarkId);
			if (configMark == null)
			{
				return false;
			}
			int relativeDungeonId = configMark.Value.RelativeDungeonId;
			int relativeId = configMark.Value.RelativeId;
			return LevelPlayReportModel.Instance.IsCommonLevelPlayDiscover(relativeDungeonId, relativeId);
		}

		// Token: 0x06037468 RID: 226408 RVA: 0x00D1E03C File Offset: 0x00D1C23C
		public void Destroy()
		{
			if (this.RangeComponent != null)
			{
				this.RangeComponent.SkipDestroyActor = false;
				this.RangeComponent.Destroy(null);
				this.RangeComponent = null;
			}
			EventSystem.Instance.Remove(EEventName.HideNavigateMarkRange, new Action(this.EventHideNavigateMarkRange));
		}

		// Token: 0x06037469 RID: 226409 RVA: 0x00D1E08C File Offset: 0x00D1C28C
		private void EventHideNavigateMarkRange()
		{
			this.SetRangeComponentHide(true).Forget();
		}

		// Token: 0x0401D203 RID: 119299
		private MarkRangeImageComponent RangeComponent;

		// Token: 0x0401D204 RID: 119300
		private UniTaskCompletionSource RangeComponentPromise;

		// Token: 0x0401D205 RID: 119301
		private Vector2D CacheRangePosition;

		// Token: 0x0401D206 RID: 119302
		private int? CacheMapId;

		// Token: 0x0401D207 RID: 119303
		private EMapGravityDirection? CacheGravity;
	}
}

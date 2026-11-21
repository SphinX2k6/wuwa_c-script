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
	// Token: 0x0200446E RID: 17518
	[NullableContext(2)]
	[Nullable(0)]
	public class MapRangePanel
	{
		// Token: 0x1700584A RID: 22602
		// (get) Token: 0x0602C3A6 RID: 181158 RVA: 0x00C6D1CA File Offset: 0x00C6B3CA
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

		// Token: 0x0602C3A7 RID: 181159 RVA: 0x00C6D1D2 File Offset: 0x00C6B3D2
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

		// Token: 0x0602C3A8 RID: 181160 RVA: 0x00C6D200 File Offset: 0x00C6B400
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

		// Token: 0x1700584B RID: 22603
		// (get) Token: 0x0602C3A9 RID: 181161 RVA: 0x00C6D258 File Offset: 0x00C6B458
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

		// Token: 0x1700584C RID: 22604
		// (get) Token: 0x0602C3AA RID: 181162 RVA: 0x00C6D2C0 File Offset: 0x00C6B4C0
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

		// Token: 0x0602C3AB RID: 181163 RVA: 0x00C6D328 File Offset: 0x00C6B528
		private UniTask InitRangeComponentAsync()
		{
			MapRangePanel.<InitRangeComponentAsync>d__14 <InitRangeComponentAsync>d__;
			<InitRangeComponentAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitRangeComponentAsync>d__.<>4__this = this;
			<InitRangeComponentAsync>d__.<>1__state = -1;
			<InitRangeComponentAsync>d__.<>t__builder.Start<MapRangePanel.<InitRangeComponentAsync>d__14>(ref <InitRangeComponentAsync>d__);
			return <InitRangeComponentAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602C3AC RID: 181164 RVA: 0x00C6D36C File Offset: 0x00C6B56C
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

		// Token: 0x0602C3AD RID: 181165 RVA: 0x00C6D3C8 File Offset: 0x00C6B5C8
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

		// Token: 0x0602C3AE RID: 181166 RVA: 0x00C6D414 File Offset: 0x00C6B614
		private UniTask WaitRangeComponent()
		{
			MapRangePanel.<WaitRangeComponent>d__17 <WaitRangeComponent>d__;
			<WaitRangeComponent>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<WaitRangeComponent>d__.<>4__this = this;
			<WaitRangeComponent>d__.<>1__state = -1;
			<WaitRangeComponent>d__.<>t__builder.Start<MapRangePanel.<WaitRangeComponent>d__17>(ref <WaitRangeComponent>d__);
			return <WaitRangeComponent>d__.<>t__builder.Task;
		}

		// Token: 0x0602C3AF RID: 181167 RVA: 0x00C6D458 File Offset: 0x00C6B658
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

		// Token: 0x0602C3B0 RID: 181168 RVA: 0x00C6D524 File Offset: 0x00C6B724
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

		// Token: 0x0602C3B1 RID: 181169 RVA: 0x00C6D6B8 File Offset: 0x00C6B8B8
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

		// Token: 0x0602C3B2 RID: 181170 RVA: 0x00C6D72E File Offset: 0x00C6B92E
		public void Destroy()
		{
			if (this.RangeComponent != null)
			{
				this.RangeComponent.Destroy(null);
				this.RangeComponent = null;
			}
			EventSystem.Instance.Remove(EEventName.HideNavigateMarkRange, new Action(this.EventHideNavigateMarkRange));
		}

		// Token: 0x0602C3B3 RID: 181171 RVA: 0x00C6D767 File Offset: 0x00C6B967
		private void EventHideNavigateMarkRange()
		{
			this.SetRangeComponentHide(true).Forget();
		}

		// Token: 0x04017C9C RID: 97436
		private MarkRangeImageComponent RangeComponent;

		// Token: 0x04017C9D RID: 97437
		private UniTaskCompletionSource RangeComponentPromise;

		// Token: 0x04017C9E RID: 97438
		private Vector2D CacheRangePosition;

		// Token: 0x04017C9F RID: 97439
		private int? CacheMapId;

		// Token: 0x04017CA0 RID: 97440
		private EMapGravityDirection? CacheGravity;
	}
}

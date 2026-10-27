using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Mark;
using CSharpScript.Game.Module.Map.Mark.Component;
using CSharpScript.Game.Module.Map.Marks.MarkItemView;
using CSharpScript.Game.Module.WorldMap;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItem
{
	// Token: 0x020054F2 RID: 21746
	[NullableContext(1)]
	[Nullable(0)]
	public class PlayerMarkItem : MarkItem
	{
		// Token: 0x17008570 RID: 34160
		// (get) Token: 0x060378BA RID: 227514 RVA: 0x00D301C1 File Offset: 0x00D2E3C1
		// (set) Token: 0x060378BB RID: 227515 RVA: 0x00D301C9 File Offset: 0x00D2E3C9
		public override int MarkId
		{
			get
			{
				return this.PlayerId;
			}
			set
			{
				this.PlayerId = value;
			}
		}

		// Token: 0x17008571 RID: 34161
		// (get) Token: 0x060378BC RID: 227516 RVA: 0x00D301D2 File Offset: 0x00D2E3D2
		public override EMarkType MarkType
		{
			get
			{
				return EMarkType.OtherPlayers;
			}
		}

		// Token: 0x17008572 RID: 34162
		// (get) Token: 0x060378BD RID: 227517 RVA: 0x00D301D6 File Offset: 0x00D2E3D6
		public override int MapId
		{
			get
			{
				return this.PlayerInfo.MapId;
			}
		}

		// Token: 0x17008573 RID: 34163
		// (get) Token: 0x060378BE RID: 227518 RVA: 0x00D301E3 File Offset: 0x00D2E3E3
		public override int? TrackAreaId
		{
			get
			{
				return MapModel.Instance.GetPlayerMarkAreaId(this.PlayerId);
			}
		}

		// Token: 0x060378BF RID: 227519 RVA: 0x00D301F8 File Offset: 0x00D2E3F8
		public PlayerMarkItem(UUIItem parent, PlayerMarkCreateInfo playerInfo, EMapType mapType, float markScale, ETrackSource trackSource = ETrackSource.MapMark) : base(parent, mapType, markScale, trackSource)
		{
			this.PlayerId = playerInfo.PlayerId;
			this.PlayerIndex = playerInfo.PlayerIndex;
			this.PlayerStartPosition = global::Vector.Create(playerInfo.Position);
			this.PlayerInfo = playerInfo;
		}

		// Token: 0x060378C0 RID: 227520 RVA: 0x00D30250 File Offset: 0x00D2E450
		protected override void OnInitialize()
		{
			if (base.MapType == EMapType.MiniMap)
			{
				float configScale = 0.8f;
				base.SetConfigScale(configScale);
			}
			string resourceId = WorldMapDefine.OnlinePlayerIconPathList[this.PlayerIndex - 1];
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
			this.IconPath = resourcePath;
			this.BindEvent();
			base.SetTrackData(this.PlayerStartPosition);
			this.UpdatePlayerGravity();
			this.UpdateVisibleRelativeState();
			this.IsHide = false;
		}

		// Token: 0x060378C1 RID: 227521 RVA: 0x00D302BF File Offset: 0x00D2E4BF
		public override void Destroy(bool recycleToPoolImmediately = true)
		{
			this.UnBindEvent();
			base.Destroy(recycleToPoolImmediately);
		}

		// Token: 0x060378C2 RID: 227522 RVA: 0x00D302CE File Offset: 0x00D2E4CE
		protected override EMarkItemViewType GetMarkItemViewType()
		{
			return EMarkItemViewType.PlayerMarkItemView;
		}

		// Token: 0x060378C3 RID: 227523 RVA: 0x00D302D2 File Offset: 0x00D2E4D2
		[PreserveBaseOverrides]
		protected new virtual PlayerMarkItemView CreateView()
		{
			return new PlayerMarkItemView(this);
		}

		// Token: 0x060378C4 RID: 227524 RVA: 0x00D302DC File Offset: 0x00D2E4DC
		protected override void UpdateVisibleRelativeState()
		{
			MarkItemEntity markItemEntity = base.MarkItemEntity;
			MarkViewLifeCircleComponent viewLifeCircle = markItemEntity.ViewLifeCircle;
			bool flag = !base.IsInConsistentDistrict(false);
			bool flag2 = base.CheckCanShowInGravityLayer(this.IsTracking());
			flag = (flag && flag2);
			base.IsCanShowView = (flag && this.CheckCanShowView() && this.CheckCanShowInBoxArea() && !this.IsHide);
			viewLifeCircle.SetChildViewVisibility(EMarkViewComponentType.GravityReverse, markItemEntity.GamePlay.CanShowGravityChildIcon);
			viewLifeCircle.SetChildViewVisibility(EMarkViewComponentType.MarkView, base.IsCanShowView);
		}

		// Token: 0x060378C5 RID: 227525 RVA: 0x00D30356 File Offset: 0x00D2E556
		private void BindEvent()
		{
			EventSystem.Instance.Add<int, global::Vector>(EEventName.ScenePlayerLocationChanged, new Action<int, global::Vector>(this.OnPositionChanged));
			EventSystem.Instance.Add<int, bool>(EEventName.ScenePlayerMarkItemStateChange, new Action<int, bool>(this.OnMarkItemStateChange));
		}

		// Token: 0x060378C6 RID: 227526 RVA: 0x00D30390 File Offset: 0x00D2E590
		private void UnBindEvent()
		{
			if (EventSystem.Instance.Has<int, global::Vector>(EEventName.ScenePlayerLocationChanged, new Action<int, global::Vector>(this.OnPositionChanged)))
			{
				EventSystem.Instance.Remove<int, global::Vector>(EEventName.ScenePlayerLocationChanged, new Action<int, global::Vector>(this.OnPositionChanged));
			}
			if (EventSystem.Instance.Has<int, bool>(EEventName.ScenePlayerMarkItemStateChange, new Action<int, bool>(this.OnMarkItemStateChange)))
			{
				EventSystem.Instance.Remove<int, bool>(EEventName.ScenePlayerMarkItemStateChange, new Action<int, bool>(this.OnMarkItemStateChange));
			}
		}

		// Token: 0x060378C7 RID: 227527 RVA: 0x00D3040F File Offset: 0x00D2E60F
		private void OnMarkItemStateChange(int playerId, bool isShow)
		{
			if (this.PlayerId == playerId)
			{
				this.IsHide = true;
			}
		}

		// Token: 0x060378C8 RID: 227528 RVA: 0x00D30421 File Offset: 0x00D2E621
		private void OnPositionChanged(int playerId, global::Vector location)
		{
			if (this.PlayerId == playerId)
			{
				base.SetTrackData(location);
				this.UpdatePlayerGravity();
				if (this.IsHide)
				{
					this.IsHide = false;
				}
			}
		}

		// Token: 0x060378C9 RID: 227529 RVA: 0x00D30450 File Offset: 0x00D2E650
		private void UpdatePlayerGravity()
		{
			SceneTeamPlayer teamPlayerData = SceneTeamModel.Instance.GetTeamPlayerData(this.PlayerId);
			long? num;
			if (teamPlayerData == null)
			{
				num = null;
			}
			else
			{
				SceneTeamGroup currentGroup = teamPlayerData.GetCurrentGroup();
				if (currentGroup == null)
				{
					num = null;
				}
				else
				{
					SceneTeamRole currentRole = currentGroup.GetCurrentRole();
					num = ((currentRole != null) ? new long?(currentRole.CreatureDataId) : null);
				}
			}
			long? num2 = num;
			if (num2 == null)
			{
				bool flag = WorldMapModel.Instance.IsGravityMap(this.MapId);
				base.MarkItemEntity.GamePlay.Gravity = (flag ? EMapGravityDirection.Down : EMapGravityDirection.All);
				return;
			}
			EntityHandle entity = CreatureModel.Instance.GetEntity(num2.Value);
			bool? flag2;
			if (entity == null)
			{
				flag2 = null;
			}
			else
			{
				WorldEntity entity2 = entity.Entity;
				if (entity2 == null)
				{
					flag2 = null;
				}
				else
				{
					BaseMoveComponent component = entity2.GetComponent<BaseMoveComponent>();
					flag2 = ((component != null) ? new bool?(component.IsStandardGravity) : null);
				}
			}
			bool? flag3 = flag2;
			base.MarkItemEntity.GamePlay.Gravity = (flag3.GetValueOrDefault() ? EMapGravityDirection.Down : EMapGravityDirection.Up);
		}

		// Token: 0x060378CA RID: 227530 RVA: 0x00D30554 File Offset: 0x00D2E754
		public override bool CheckCanShowView()
		{
			return true;
		}

		// Token: 0x060378CB RID: 227531 RVA: 0x00D30557 File Offset: 0x00D2E757
		public override bool GetInteractiveFlag()
		{
			return false;
		}

		// Token: 0x060378CC RID: 227532 RVA: 0x00D3055C File Offset: 0x00D2E75C
		public override void SetTitleText(UUIText uiText)
		{
			WorldTeamPlayerFightInfo worldTeamPlayerFightInfo = OnlineModel.Instance.GetWorldTeamPlayerFightInfo(this.PlayerId);
			string newText = ((worldTeamPlayerFightInfo != null) ? worldTeamPlayerFightInfo.Name : null) ?? this.PlayerId.ToString();
			uiText.SetText(newText, true);
		}

		// Token: 0x060378CD RID: 227533 RVA: 0x00D3059D File Offset: 0x00D2E79D
		public override bool IsMultiMap()
		{
			return this.GetMultiMapId() != 0;
		}

		// Token: 0x060378CE RID: 227534 RVA: 0x00D305A8 File Offset: 0x00D2E7A8
		public override int GetMultiMapId()
		{
			ScenePlayerData scenePlayerData = CreatureModel.Instance.GetScenePlayerData(this.PlayerId);
			if (scenePlayerData != null)
			{
				MultiMap? subMapConfigByAreaId = MapConfig.Instance.GetSubMapConfigByAreaId(scenePlayerData.GetAreaId());
				if (subMapConfigByAreaId == null)
				{
					return 0;
				}
				return subMapConfigByAreaId.GetValueOrDefault().Id;
			}
			else
			{
				OtherScenePlayerData otherScenePlayerDataByPlayerId = OnlineModel.Instance.GetOtherScenePlayerDataByPlayerId(this.PlayerId);
				if (otherScenePlayerDataByPlayerId == null)
				{
					return 0;
				}
				MultiMap? subMapConfigByAreaId2 = MapConfig.Instance.GetSubMapConfigByAreaId(otherScenePlayerDataByPlayerId.Area);
				if (subMapConfigByAreaId2 == null)
				{
					return 0;
				}
				return subMapConfigByAreaId2.GetValueOrDefault().Id;
			}
		}

		// Token: 0x060378CF RID: 227535 RVA: 0x00D30637 File Offset: 0x00D2E837
		public override bool LocateInGround()
		{
			return this.GetMultiMapId() == 0;
		}

		// Token: 0x0401D3C9 RID: 119753
		public int PlayerId;

		// Token: 0x0401D3CA RID: 119754
		public int PlayerIndex;

		// Token: 0x0401D3CB RID: 119755
		[Nullable(2)]
		public global::Vector PlayerStartPosition;

		// Token: 0x0401D3CC RID: 119756
		public bool IsHide = true;

		// Token: 0x0401D3CD RID: 119757
		[Nullable(2)]
		private readonly PlayerMarkCreateInfo PlayerInfo;
	}
}

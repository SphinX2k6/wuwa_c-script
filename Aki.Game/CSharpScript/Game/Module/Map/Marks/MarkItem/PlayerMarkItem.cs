using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Mark;
using CSharpScript.Game.Module.Map.Marks.MarkItemView;
using CSharpScript.Game.Module.WorldMap;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItem
{
	// Token: 0x020044C5 RID: 17605
	[NullableContext(1)]
	[Nullable(0)]
	public class PlayerMarkItem : MarkItem
	{
		// Token: 0x17005909 RID: 22793
		// (get) Token: 0x0602C785 RID: 182149 RVA: 0x00C7E143 File Offset: 0x00C7C343
		// (set) Token: 0x0602C786 RID: 182150 RVA: 0x00C7E14B File Offset: 0x00C7C34B
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

		// Token: 0x1700590A RID: 22794
		// (get) Token: 0x0602C787 RID: 182151 RVA: 0x00C7E154 File Offset: 0x00C7C354
		public override EMarkType MarkType
		{
			get
			{
				return EMarkType.OtherPlayers;
			}
		}

		// Token: 0x1700590B RID: 22795
		// (get) Token: 0x0602C788 RID: 182152 RVA: 0x00C7E158 File Offset: 0x00C7C358
		public override int MapId
		{
			get
			{
				return this.PlayerInfo.MapId;
			}
		}

		// Token: 0x1700590C RID: 22796
		// (get) Token: 0x0602C789 RID: 182153 RVA: 0x00C7E165 File Offset: 0x00C7C365
		public override EMapGravityDirection Gravity
		{
			get
			{
				return this._gravityInner;
			}
		}

		// Token: 0x1700590D RID: 22797
		// (get) Token: 0x0602C78A RID: 182154 RVA: 0x00C7E16D File Offset: 0x00C7C36D
		public override int? TrackAreaId
		{
			get
			{
				return MapModel.Instance.GetPlayerMarkAreaId(this.PlayerId);
			}
		}

		// Token: 0x0602C78B RID: 182155 RVA: 0x00C7E180 File Offset: 0x00C7C380
		public PlayerMarkItem(UUIItem parent, PlayerMarkCreateInfo playerInfo, EMapType mapType, float markScale, ETrackSource trackSource = ETrackSource.MapMark) : base(parent, mapType, markScale, trackSource)
		{
			this.PlayerId = playerInfo.PlayerId;
			this.PlayerIndex = playerInfo.PlayerIndex;
			this.PlayerStartPosition = global::Vector.Create(playerInfo.Position);
			this.PlayerInfo = playerInfo;
		}

		// Token: 0x0602C78C RID: 182156 RVA: 0x00C7E1D8 File Offset: 0x00C7C3D8
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

		// Token: 0x0602C78D RID: 182157 RVA: 0x00C7E247 File Offset: 0x00C7C447
		public override void Destroy(bool recycleToPoolImmediately = true)
		{
			this.UnBindEvent();
			base.Destroy(recycleToPoolImmediately);
		}

		// Token: 0x0602C78E RID: 182158 RVA: 0x00C7E256 File Offset: 0x00C7C456
		protected override EMarkItemViewType GetMarkItemViewType()
		{
			return EMarkItemViewType.PlayerMarkItemView;
		}

		// Token: 0x0602C78F RID: 182159 RVA: 0x00C7E25A File Offset: 0x00C7C45A
		[PreserveBaseOverrides]
		protected new virtual PlayerMarkItemView CreateView()
		{
			return new PlayerMarkItemView(this);
		}

		// Token: 0x0602C790 RID: 182160 RVA: 0x00C7E264 File Offset: 0x00C7C464
		protected override void UpdateVisibleRelativeState()
		{
			bool flag = !base.IsInConsistentDistrict(false);
			bool flag2 = base.CheckCanShowInGravityLayer(this.IsTracking());
			flag = (flag && flag2);
			base.IsCanShowView = (flag && this.CheckCanShowView() && this.CheckCanShowInBoxArea() && !this.IsHide);
			base.SetShowMarkView(base.IsCanShowView);
		}

		// Token: 0x0602C791 RID: 182161 RVA: 0x00C7E2BE File Offset: 0x00C7C4BE
		private void BindEvent()
		{
			EventSystem.Instance.Add<int, global::Vector>(EEventName.ScenePlayerLocationChanged, new Action<int, global::Vector>(this.OnPositionChanged));
			EventSystem.Instance.Add<int, bool>(EEventName.ScenePlayerMarkItemStateChange, new Action<int, bool>(this.OnMarkItemStateChange));
		}

		// Token: 0x0602C792 RID: 182162 RVA: 0x00C7E2F8 File Offset: 0x00C7C4F8
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

		// Token: 0x0602C793 RID: 182163 RVA: 0x00C7E377 File Offset: 0x00C7C577
		private void OnMarkItemStateChange(int playerId, bool isShow)
		{
			if (this.PlayerId == playerId)
			{
				this.IsHide = true;
			}
		}

		// Token: 0x0602C794 RID: 182164 RVA: 0x00C7E389 File Offset: 0x00C7C589
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

		// Token: 0x0602C795 RID: 182165 RVA: 0x00C7E3B8 File Offset: 0x00C7C5B8
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
				this._gravityInner = (WorldMapModel.Instance.IsGravityMap(this.MapId) ? EMapGravityDirection.Down : EMapGravityDirection.All);
				return;
			}
			EntityHandle entity = CreatureModel.Instance.GetEntity(num2.Value);
			bool? flag;
			if (entity == null)
			{
				flag = null;
			}
			else
			{
				WorldEntity entity2 = entity.Entity;
				if (entity2 == null)
				{
					flag = null;
				}
				else
				{
					BaseMoveComponent component = entity2.GetComponent<BaseMoveComponent>();
					flag = ((component != null) ? new bool?(component.IsStandardGravity) : null);
				}
			}
			bool? flag2 = flag;
			this._gravityInner = (flag2.GetValueOrDefault() ? EMapGravityDirection.Down : EMapGravityDirection.Up);
		}

		// Token: 0x0602C796 RID: 182166 RVA: 0x00C7E4A8 File Offset: 0x00C7C6A8
		public override bool CheckCanShowView()
		{
			return true;
		}

		// Token: 0x0602C797 RID: 182167 RVA: 0x00C7E4AB File Offset: 0x00C7C6AB
		public override bool GetInteractiveFlag()
		{
			return false;
		}

		// Token: 0x0602C798 RID: 182168 RVA: 0x00C7E4B0 File Offset: 0x00C7C6B0
		public override void SetTitleText(UUIText uiText)
		{
			WorldTeamPlayerFightInfo worldTeamPlayerFightInfo = OnlineModel.Instance.GetWorldTeamPlayerFightInfo(this.PlayerId);
			string newText = ((worldTeamPlayerFightInfo != null) ? worldTeamPlayerFightInfo.Name : null) ?? this.PlayerId.ToString();
			uiText.SetText(newText, true);
		}

		// Token: 0x0602C799 RID: 182169 RVA: 0x00C7E4F1 File Offset: 0x00C7C6F1
		public override bool IsMultiMap()
		{
			return this.GetMultiMapId() != 0;
		}

		// Token: 0x0602C79A RID: 182170 RVA: 0x00C7E4FC File Offset: 0x00C7C6FC
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

		// Token: 0x0602C79B RID: 182171 RVA: 0x00C7E58B File Offset: 0x00C7C78B
		public override bool LocateInGround()
		{
			return this.GetMultiMapId() == 0;
		}

		// Token: 0x04017E51 RID: 97873
		public int PlayerId;

		// Token: 0x04017E52 RID: 97874
		public int PlayerIndex;

		// Token: 0x04017E53 RID: 97875
		[Nullable(2)]
		public global::Vector PlayerStartPosition;

		// Token: 0x04017E54 RID: 97876
		public bool IsHide = true;

		// Token: 0x04017E55 RID: 97877
		[Nullable(2)]
		private readonly PlayerMarkCreateInfo PlayerInfo;

		// Token: 0x04017E56 RID: 97878
		private EMapGravityDirection _gravityInner;
	}
}

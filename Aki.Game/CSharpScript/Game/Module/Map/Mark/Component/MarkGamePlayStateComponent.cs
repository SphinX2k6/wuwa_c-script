using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Map.Base;

namespace CSharpScript.Game.Module.Map.Mark.Component
{
	// Token: 0x020054CD RID: 21709
	public class MarkGamePlayStateComponent : MapComponent
	{
		// Token: 0x060376CD RID: 227021 RVA: 0x00D2A089 File Offset: 0x00D28289
		public MarkGamePlayStateComponent([Nullable(new byte[]
		{
			0,
			1,
			1,
			1
		})] OneOf<MapComponent, MapComponentContainer, MapEntity> parent) : base(parent)
		{
		}

		// Token: 0x17008500 RID: 34048
		// (get) Token: 0x060376CE RID: 227022 RVA: 0x00D2A092 File Offset: 0x00D28292
		public override EMapComponent ComponentType
		{
			get
			{
				return EMapComponent.MarkGamePlayState;
			}
		}

		// Token: 0x060376CF RID: 227023 RVA: 0x00D2A096 File Offset: 0x00D28296
		protected override void OnInit()
		{
			this.UpdateLevelPlayState();
		}

		// Token: 0x060376D0 RID: 227024 RVA: 0x00D2A09E File Offset: 0x00D2829E
		protected override void OnAdd()
		{
			EventSystem.Instance.Add<int, ELevelPlayState>(EEventName.OnLevelPlayStateChange, new Action<int, ELevelPlayState>(this.EventUpdateLevelPlayState));
		}

		// Token: 0x060376D1 RID: 227025 RVA: 0x00D2A0BC File Offset: 0x00D282BC
		protected override void OnRemove()
		{
			EventSystem.Instance.Remove(EEventName.OnLevelPlayStateChange, new Action<int, ELevelPlayState>(this.EventUpdateLevelPlayState));
		}

		// Token: 0x060376D2 RID: 227026 RVA: 0x00D2A0DC File Offset: 0x00D282DC
		private int? GetRelativeId()
		{
			MapEntity parentEntity = base.ParentEntity;
			MarkConfigComponent markConfigComponent = (parentEntity != null) ? parentEntity.GetComponent<MarkConfigComponent>(EMapComponent.MarkConfig) : null;
			OneOf<MapMark, DynamicMapMark, TreasureBoxDetectorMark>? oneOf = (markConfigComponent != null) ? new OneOf<MapMark, DynamicMapMark, TreasureBoxDetectorMark>?(markConfigComponent.Config) : null;
			if (oneOf == null)
			{
				return null;
			}
			if (oneOf.Value.IsT1)
			{
				return new int?(oneOf.Value.AsT1.RelativeId);
			}
			if (oneOf.Value.IsT2)
			{
				return new int?(oneOf.Value.AsT2.RelativeId);
			}
			return null;
		}

		// Token: 0x060376D3 RID: 227027 RVA: 0x00D2A194 File Offset: 0x00D28394
		private void EventUpdateLevelPlayState(int id, ELevelPlayState eLevelPlayState)
		{
			int? relativeId = this.GetRelativeId();
			if (relativeId.GetValueOrDefault() == id & relativeId != null)
			{
				this.UpdateLevelPlayState();
			}
		}

		// Token: 0x060376D4 RID: 227028 RVA: 0x00D2A1C4 File Offset: 0x00D283C4
		public void UpdateLevelPlayState()
		{
			int? relativeId = this.GetRelativeId();
			if (relativeId == null)
			{
				return;
			}
			LevelPlayInfo levelPlayInfo = LevelPlayModel.Instance.GetLevelPlayInfo(relativeId.Value);
			if (levelPlayInfo == null)
			{
				return;
			}
			EMarkGamePlayState emarkGamePlayState = EMarkGamePlayState.Lock;
			switch (levelPlayInfo.PlayState)
			{
			case ELevelPlayState.Close:
			case ELevelPlayState.Wait:
				emarkGamePlayState = EMarkGamePlayState.Lock;
				break;
			case ELevelPlayState.Open:
				emarkGamePlayState = EMarkGamePlayState.Processing;
				break;
			case ELevelPlayState.Finish:
			case ELevelPlayState.AllPlayerGetReward:
				emarkGamePlayState = EMarkGamePlayState.Finish;
				break;
			}
			MapEntity parentEntity = base.ParentEntity;
			MarkGamePlayComponent markGamePlayComponent = (parentEntity != null) ? parentEntity.GetComponent<MarkGamePlayComponent>(EMapComponent.MarkGamePlay) : null;
			if (markGamePlayComponent != null && markGamePlayComponent.GamePlayState != emarkGamePlayState)
			{
				markGamePlayComponent.GamePlayState = emarkGamePlayState;
				MapEntity parentEntity2 = base.ParentEntity;
				MarkConfigComponent markConfigComponent = (parentEntity2 != null) ? parentEntity2.GetComponent<MarkConfigComponent>(EMapComponent.MarkConfig) : null;
				OneOf<MapMark, DynamicMapMark, TreasureBoxDetectorMark>? oneOf = (markConfigComponent != null) ? new OneOf<MapMark, DynamicMapMark, TreasureBoxDetectorMark>?(markConfigComponent.Config) : null;
				if (oneOf != null && oneOf.Value.IsT1)
				{
					int markId = oneOf.Value.AsT1.MarkId;
					if (markId != 0)
					{
						EventSystem.Instance.Emit<int>(EEventName.LevelPlayMarkGamePlayStateUpdate, markId);
					}
				}
				if (oneOf != null && oneOf.Value.IsT2)
				{
					int markId2 = oneOf.Value.AsT2.MarkId;
					if (markId2 != 0)
					{
						EventSystem.Instance.Emit<int>(EEventName.LevelPlayMarkGamePlayStateUpdate, markId2);
					}
				}
			}
		}
	}
}

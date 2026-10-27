using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Map.Base;
using CSharpScript.Game.Module.Map.Marks;

namespace CSharpScript.Game.Module.Map.Mark.Component
{
	// Token: 0x020054C7 RID: 21703
	public class MarkCommonGamePlayStateComponent : MapComponent
	{
		// Token: 0x06037686 RID: 226950 RVA: 0x00D28B36 File Offset: 0x00D26D36
		public MarkCommonGamePlayStateComponent([Nullable(new byte[]
		{
			0,
			1,
			1,
			1
		})] OneOf<MapComponent, MapComponentContainer, MapEntity> parent) : base(parent)
		{
		}

		// Token: 0x170084DF RID: 34015
		// (get) Token: 0x06037687 RID: 226951 RVA: 0x00D28B3F File Offset: 0x00D26D3F
		public override EMapComponent ComponentType
		{
			get
			{
				return EMapComponent.MarkCommonGamePlayState;
			}
		}

		// Token: 0x170084E0 RID: 34016
		// (get) Token: 0x06037688 RID: 226952 RVA: 0x00D28B43 File Offset: 0x00D26D43
		// (set) Token: 0x06037689 RID: 226953 RVA: 0x00D28B4B File Offset: 0x00D26D4B
		public bool HasRequestGamePlay { get; set; }

		// Token: 0x0603768A RID: 226954 RVA: 0x00D28B54 File Offset: 0x00D26D54
		protected override void OnInit()
		{
			this.UpdateLevelPlayState();
		}

		// Token: 0x0603768B RID: 226955 RVA: 0x00D28B5C File Offset: 0x00D26D5C
		protected override void OnAdd()
		{
			EventSystem.Instance.Add(EEventName.LevelPlayStateDetailUpdate, new Action(this.OnLevelPlayStateUpdate));
			EventSystem.Instance.Add<int, ELevelPlayState>(EEventName.OnLevelPlayStateChange, new Action<int, ELevelPlayState>(this.EventUpdateLevelPlayState));
			EventSystem.Instance.Add(EEventName.LevelPlayRewardDetailUpdate, new Action(this.OnLevelPlayStateUpdate));
		}

		// Token: 0x0603768C RID: 226956 RVA: 0x00D28BC0 File Offset: 0x00D26DC0
		protected override void OnRemove()
		{
			EventSystem.Instance.Remove(EEventName.LevelPlayStateDetailUpdate, new Action(this.OnLevelPlayStateUpdate));
			EventSystem.Instance.Remove(EEventName.OnLevelPlayStateChange, new Action<int, ELevelPlayState>(this.EventUpdateLevelPlayState));
			EventSystem.Instance.Remove(EEventName.LevelPlayRewardDetailUpdate, new Action(this.OnLevelPlayStateUpdate));
		}

		// Token: 0x0603768D RID: 226957 RVA: 0x00D28C21 File Offset: 0x00D26E21
		private void OnLevelPlayStateUpdate()
		{
			this.UpdateLevelPlayState();
		}

		// Token: 0x0603768E RID: 226958 RVA: 0x00D28C2C File Offset: 0x00D26E2C
		private void EventUpdateLevelPlayState(int id, ELevelPlayState eLevelPlayState)
		{
			int? relativeId = this.GetRelativeId();
			int? relativeDungeonId = this.GetRelativeDungeonId();
			int? num = relativeId;
			if (!(num.GetValueOrDefault() == id & num != null) || relativeDungeonId == null)
			{
				return;
			}
			LevelPlayReportController.Instance.RequestSingleLevelPlayStateListAsync(relativeDungeonId.Value, relativeId.Value);
			this.UpdateLevelPlayState();
		}

		// Token: 0x0603768F RID: 226959 RVA: 0x00D28C88 File Offset: 0x00D26E88
		private void UpdateLevelPlayState()
		{
			int? relativeId = this.GetRelativeId();
			int? relativeDungeonId = this.GetRelativeDungeonId();
			if (relativeId == null || relativeDungeonId == null)
			{
				return;
			}
			bool flag = LevelPlayReportModel.Instance.IsCommonLevelPlayHide(relativeDungeonId.Value, relativeId.Value);
			EMarkGamePlayState emarkGamePlayState = EMarkGamePlayState.Lock;
			MapEntity parentEntity = base.ParentEntity;
			MarkConfigComponent markConfigComponent = (parentEntity != null) ? parentEntity.GetComponent<MarkConfigComponent>(EMapComponent.MarkConfig) : null;
			OneOf<MapMark, DynamicMapMark, TreasureBoxDetectorMark>? oneOf = (markConfigComponent != null) ? new OneOf<MapMark, DynamicMapMark, TreasureBoxDetectorMark>?(markConfigComponent.Config) : null;
			int? num = null;
			if (oneOf != null)
			{
				if (oneOf.Value.IsT1)
				{
					num = new int?(oneOf.Value.AsT1.MarkId);
				}
				else if (oneOf.Value.IsT2)
				{
					num = new int?(oneOf.Value.AsT2.MarkId);
				}
			}
			if (flag)
			{
				emarkGamePlayState = EMarkGamePlayState.Hide;
			}
			else if (num != null && MarkItemDataUtil.IsCommonGamePlayMarkComplete(num.Value))
			{
				emarkGamePlayState = EMarkGamePlayState.Finish;
			}
			MapEntity parentEntity2 = base.ParentEntity;
			MarkGamePlayComponent markGamePlayComponent = (parentEntity2 != null) ? parentEntity2.GetComponent<MarkGamePlayComponent>(EMapComponent.MarkGamePlay) : null;
			if (markGamePlayComponent != null && markGamePlayComponent.GamePlayState != emarkGamePlayState)
			{
				markGamePlayComponent.GamePlayState = emarkGamePlayState;
				if (num != null)
				{
					EventSystem.Instance.Emit<int>(EEventName.CommonPlayMarkGamePlayStateUpdate, num.Value);
				}
			}
		}

		// Token: 0x06037690 RID: 226960 RVA: 0x00D28DE4 File Offset: 0x00D26FE4
		public int? GetRelativeId()
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

		// Token: 0x06037691 RID: 226961 RVA: 0x00D28E9C File Offset: 0x00D2709C
		public int? GetRelativeDungeonId()
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
				return new int?(oneOf.Value.AsT1.RelativeDungeonId);
			}
			if (oneOf.Value.IsT2)
			{
				return new int?(oneOf.Value.AsT2.RelativeDungeonId);
			}
			return null;
		}

		// Token: 0x06037692 RID: 226962 RVA: 0x00D28F54 File Offset: 0x00D27154
		public bool NeedRequestGamePlayState()
		{
			return !this.HasRequestGamePlay && this.GetRelativeId().GetValueOrDefault() != 0;
		}
	}
}

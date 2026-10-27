using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Map.Base;

namespace CSharpScript.Game.Module.Map.Mark.Component
{
	// Token: 0x020054CA RID: 21706
	public class MarkEntityComponent : MapComponent
	{
		// Token: 0x0603769D RID: 226973 RVA: 0x00D2939F File Offset: 0x00D2759F
		public MarkEntityComponent([Nullable(new byte[]
		{
			0,
			1,
			1,
			1
		})] OneOf<MapComponent, MapComponentContainer, MapEntity> parent) : base(parent)
		{
		}

		// Token: 0x170084E8 RID: 34024
		// (get) Token: 0x0603769E RID: 226974 RVA: 0x00D293A8 File Offset: 0x00D275A8
		// (set) Token: 0x0603769F RID: 226975 RVA: 0x00D293B0 File Offset: 0x00D275B0
		public int? EntityId { get; set; }

		// Token: 0x170084E9 RID: 34025
		// (get) Token: 0x060376A0 RID: 226976 RVA: 0x00D293B9 File Offset: 0x00D275B9
		public override EMapComponent ComponentType
		{
			get
			{
				return EMapComponent.MarkEntity;
			}
		}

		// Token: 0x060376A1 RID: 226977 RVA: 0x00D293C0 File Offset: 0x00D275C0
		protected override void OnInit()
		{
			MapEntity parentEntity = base.ParentEntity;
			MarkGamePlayComponent markGamePlayComponent = (parentEntity != null) ? parentEntity.GetComponent<MarkGamePlayComponent>(EMapComponent.MarkGamePlay) : null;
			if (markGamePlayComponent != null)
			{
				int markId = markGamePlayComponent.MarkId;
				this.UpdateHideState(markId);
			}
		}

		// Token: 0x060376A2 RID: 226978 RVA: 0x00D293F3 File Offset: 0x00D275F3
		protected override void OnAdd()
		{
			EventSystem.Instance.Add(EEventName.MarkHideState, new Action<int>(this.UpdateHideState));
		}

		// Token: 0x060376A3 RID: 226979 RVA: 0x00D29411 File Offset: 0x00D27611
		protected override void OnRemove()
		{
			EventSystem.Instance.Remove(EEventName.MarkHideState, new Action<int>(this.UpdateHideState));
		}

		// Token: 0x060376A4 RID: 226980 RVA: 0x00D29430 File Offset: 0x00D27630
		private void UpdateHideState(int markId)
		{
			MapEntity parentEntity = base.ParentEntity;
			MarkGamePlayComponent markGamePlayComponent = (parentEntity != null) ? parentEntity.GetComponent<MarkGamePlayComponent>(EMapComponent.MarkGamePlay) : null;
			if (markGamePlayComponent != null && markGamePlayComponent.MarkId == markId && this.EntityId != null && MapModel.Instance.IsMarkHideByServer(markGamePlayComponent.MapId, this.EntityId.Value))
			{
				markGamePlayComponent.GamePlayState = EMarkGamePlayState.Hide;
			}
		}
	}
}

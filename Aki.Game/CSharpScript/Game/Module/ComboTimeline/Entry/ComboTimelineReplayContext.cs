using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ComboTimeline.Entry
{
	// Token: 0x02005B9B RID: 23451
	public class ComboTimelineReplayContext : IComboTimelineReplayContext
	{
		// Token: 0x0603B516 RID: 242966 RVA: 0x00E22C74 File Offset: 0x00E20E74
		public int? GetMainControlEntityId()
		{
			SceneTeamModel instance = SceneTeamModel.Instance;
			if (instance == null)
			{
				return null;
			}
			EntityHandle getCurrentEntity = instance.GetCurrentEntity;
			if (getCurrentEntity == null)
			{
				return null;
			}
			WorldEntity entity = getCurrentEntity.Entity;
			if (entity == null)
			{
				return null;
			}
			return new int?(entity.Id);
		}

		// Token: 0x0603B517 RID: 242967 RVA: 0x00E22CC4 File Offset: 0x00E20EC4
		[NullableContext(2)]
		public Entity GetMainControlEntity()
		{
			SceneTeamModel instance = SceneTeamModel.Instance;
			if (instance == null)
			{
				return null;
			}
			EntityHandle getCurrentEntity = instance.GetCurrentEntity;
			if (getCurrentEntity == null)
			{
				return null;
			}
			return getCurrentEntity.Entity;
		}

		// Token: 0x0603B518 RID: 242968 RVA: 0x00E22CE1 File Offset: 0x00E20EE1
		public int GetCurrentFrame()
		{
			return this.CurrentFrameValue;
		}

		// Token: 0x0603B519 RID: 242969 RVA: 0x00E22CE9 File Offset: 0x00E20EE9
		public void SetCurrentFrame(int frame)
		{
			this.CurrentFrameValue = frame;
		}

		// Token: 0x0401EEAF RID: 126639
		private int CurrentFrameValue;
	}
}

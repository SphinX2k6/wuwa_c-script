using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ComboTimeline.Entry
{
	// Token: 0x02004B7B RID: 19323
	public class ComboTimelineReplayContext : IComboTimelineReplayContext
	{
		// Token: 0x06030463 RID: 197731 RVA: 0x00D731C4 File Offset: 0x00D713C4
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

		// Token: 0x06030464 RID: 197732 RVA: 0x00D73214 File Offset: 0x00D71414
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

		// Token: 0x06030465 RID: 197733 RVA: 0x00D73231 File Offset: 0x00D71431
		public int GetCurrentFrame()
		{
			return this.CurrentFrameValue;
		}

		// Token: 0x06030466 RID: 197734 RVA: 0x00D73239 File Offset: 0x00D71439
		public void SetCurrentFrame(int frame)
		{
			this.CurrentFrameValue = frame;
		}

		// Token: 0x04019960 RID: 104800
		private int CurrentFrameValue;
	}
}

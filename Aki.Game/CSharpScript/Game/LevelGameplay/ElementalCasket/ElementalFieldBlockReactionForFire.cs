using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.ElementalCasket
{
	// Token: 0x02006002 RID: 24578
	[NullableContext(1)]
	[Nullable(0)]
	public class ElementalFieldBlockReactionForFire : IElementalFieldReaction
	{
		// Token: 0x0603B0CB RID: 241867 RVA: 0x010B2DCC File Offset: 0x010B0FCC
		private bool CanAffect(EntityHandle detector, EntityHandle target)
		{
			if (!target.Valid)
			{
				return false;
			}
			int playerId = CreatureModel.Instance.GetPlayerId();
			return FormationDataController.Instance.GetPlayerEntity(playerId) == target.Entity;
		}

		// Token: 0x0603B0CC RID: 241868 RVA: 0x010B2E01 File Offset: 0x010B1001
		public void ExecuteEnter(EntityHandle detector, EntityHandle target)
		{
			if (this.RequestedTargets.Contains(target.Id) || !this.CanAffect(detector, target))
			{
				return;
			}
			ElementalCasketModel.Instance.RequestFireFieldBlock();
			this.RequestedTargets.Add(target.Id);
		}

		// Token: 0x0603B0CD RID: 241869 RVA: 0x010B2E3D File Offset: 0x010B103D
		public void ExecuteLeave(EntityHandle detector, EntityHandle target)
		{
			if (!this.RequestedTargets.Contains(target.Id))
			{
				return;
			}
			ElementalCasketModel.Instance.ReleaseFireFieldBlock();
			this.RequestedTargets.Remove(target.Id);
		}

		// Token: 0x0401F114 RID: 127252
		private readonly HashSet<int> RequestedTargets = new HashSet<int>();
	}
}

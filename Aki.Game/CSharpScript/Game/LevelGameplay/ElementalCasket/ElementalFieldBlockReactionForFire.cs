using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.ElementalCasket
{
	// Token: 0x02006E81 RID: 28289
	[NullableContext(1)]
	[Nullable(0)]
	public class ElementalFieldBlockReactionForFire : IElementalFieldReaction
	{
		// Token: 0x06044F1B RID: 282395 RVA: 0x01108864 File Offset: 0x01106A64
		private bool CanAffect(EntityHandle detector, EntityHandle target)
		{
			if (!target.Valid)
			{
				return false;
			}
			int playerId = CreatureModel.Instance.GetPlayerId();
			return FormationDataController.Instance.GetPlayerEntity(playerId) == target.Entity;
		}

		// Token: 0x06044F1C RID: 282396 RVA: 0x01108899 File Offset: 0x01106A99
		public void ExecuteEnter(EntityHandle detector, EntityHandle target)
		{
			if (this.RequestedTargets.Contains(target.Id) || !this.CanAffect(detector, target))
			{
				return;
			}
			ElementalCasketModel.Instance.RequestFireFieldBlock();
			this.RequestedTargets.Add(target.Id);
		}

		// Token: 0x06044F1D RID: 282397 RVA: 0x011088D5 File Offset: 0x01106AD5
		public void ExecuteLeave(EntityHandle detector, EntityHandle target)
		{
			if (!this.RequestedTargets.Contains(target.Id))
			{
				return;
			}
			ElementalCasketModel.Instance.ReleaseFireFieldBlock();
			this.RequestedTargets.Remove(target.Id);
		}

		// Token: 0x04023E5C RID: 147036
		private readonly HashSet<int> RequestedTargets = new HashSet<int>();
	}
}

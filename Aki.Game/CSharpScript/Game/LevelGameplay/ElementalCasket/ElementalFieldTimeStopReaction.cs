using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.Pawn.Component;

namespace CSharpScript.Game.LevelGamePlay.ElementalCasket
{
	// Token: 0x02006E86 RID: 28294
	[NullableContext(1)]
	[Nullable(0)]
	public class ElementalFieldTimeStopReaction : IElementalFieldReaction
	{
		// Token: 0x06044F3C RID: 282428 RVA: 0x01109A9C File Offset: 0x01107C9C
		public void ExecuteEnter(EntityHandle detector, EntityHandle target)
		{
			int id = target.Id;
			if (this.TimeScaleHandleMap.ContainsKey(id))
			{
				return;
			}
			WorldEntity entity = target.Entity;
			BaseElementalDetectableComponent component = entity.GetComponent<BaseElementalDetectableComponent>();
			if (component != null && component.IsImmuneTimeStop())
			{
				return;
			}
			PawnTimeScaleComponent component2 = entity.GetComponent<PawnTimeScaleComponent>();
			int? num = (component2 != null) ? new int?(component2.SetForeverTimeScale(ETimeScaleSourceType.ElementalField, 0f, 0, false)) : null;
			if (num != null)
			{
				this.TimeScaleHandleMap[id] = num.Value;
			}
		}

		// Token: 0x06044F3D RID: 282429 RVA: 0x01109B20 File Offset: 0x01107D20
		public void ExecuteLeave(EntityHandle detector, EntityHandle target)
		{
			int id = target.Id;
			int id2;
			if (!this.TimeScaleHandleMap.TryGetValue(id, out id2))
			{
				return;
			}
			PawnTimeScaleComponent component = target.Entity.GetComponent<PawnTimeScaleComponent>();
			if (component != null)
			{
				component.RemoveForeverTimeScale(id2, false);
			}
			this.TimeScaleHandleMap.Remove(id);
		}

		// Token: 0x04023E6A RID: 147050
		private readonly Dictionary<int, int> TimeScaleHandleMap = new Dictionary<int, int>();
	}
}

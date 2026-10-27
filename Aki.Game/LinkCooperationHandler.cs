using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Battle;

// Token: 0x020016FF RID: 5887
public class LinkCooperationHandler : ICooperationHandler
{
	// Token: 0x0600A8D7 RID: 43223 RVA: 0x0025FFF0 File Offset: 0x0025E1F0
	[NullableContext(1)]
	public bool Trigger(SceneTeamItem goDownRole, SceneTeamItem goBattleRole)
	{
		if (!goBattleRole.IsAutoRole())
		{
			return false;
		}
		WorldEntity entity = goBattleRole.EntityHandle.Entity;
		if (entity == null)
		{
			return false;
		}
		if (!BattleLinkModel.Instance.CanUseLinkSkill(new int?(entity.Id)))
		{
			return false;
		}
		long num;
		if (this.TriggerCd.TryGetValue(entity.Id, out num) && (float)(DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() - num) < 200f)
		{
			return false;
		}
		this.TriggerCd[entity.Id] = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
		BattleLinkController.Instance.UseLinkSkill(entity);
		return true;
	}

	// Token: 0x0600A8D8 RID: 43224 RVA: 0x00260089 File Offset: 0x0025E289
	public void Clear()
	{
		this.TriggerCd.Clear();
	}

	// Token: 0x04004D0A RID: 19722
	[Nullable(1)]
	private readonly Dictionary<int, long> TriggerCd = new Dictionary<int, long>();
}

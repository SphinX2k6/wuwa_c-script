using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Battle;

// Token: 0x02000BB7 RID: 2999
public class LinkCooperationHandler : ICooperationHandler
{
	// Token: 0x06007CB7 RID: 31927 RVA: 0x0026A40C File Offset: 0x0026860C
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

	// Token: 0x06007CB8 RID: 31928 RVA: 0x0026A4A5 File Offset: 0x002686A5
	public void Clear()
	{
		this.TriggerCd.Clear();
	}

	// Token: 0x04004DB1 RID: 19889
	[Nullable(1)]
	private readonly Dictionary<int, long> TriggerCd = new Dictionary<int, long>();
}

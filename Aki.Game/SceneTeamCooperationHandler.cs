using System;
using System.Runtime.CompilerServices;

// Token: 0x02001701 RID: 5889
public class SceneTeamCooperationHandler : ICooperationHandler
{
	// Token: 0x0600A8DD RID: 43229 RVA: 0x002601E4 File Offset: 0x0025E3E4
	[NullableContext(1)]
	public bool Trigger(SceneTeamItem goDownRole, SceneTeamItem goBattleRole)
	{
		EntityHandle entityHandle = goBattleRole.EntityHandle;
		bool isInQte = entityHandle.Entity.GetComponent<RoleQteComponent>().IsInQte;
		bool flag = entityHandle.Entity.CheckGetComponent<RoleTeamComponent>().IsChangeRoleCoolDown();
		if (!isInQte)
		{
			if (flag)
			{
				ScrollingTipsController.Instance.ShowTipsById("EditBattleTeamInCD", Array.Empty<object>());
				return false;
			}
			BaseTagComponent component = goDownRole.EntityHandle.Entity.GetComponent<BaseTagComponent>();
			if (component.HasTag(GameplayTagDefine.EGameplayTagId["功能.功能制作.被击硬直时间"]) && component.HasAnyTag(SceneTeamDefine.beHitTagList))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SceneTeam;
				ELogAuthor author = ELogAuthor.LYY;
				string message = "被击硬直时间无法换人";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("roleId", goDownRole.GetConfigId);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
		}
		SceneTeamController.Instance.RequestChangeRole(goBattleRole.GetCreatureDataId(), new RequestChangeRoleParams
		{
			FilterSameRole = new bool?(true),
			GoDownWaitSkillEnd = new bool?(true),
			ForceInheritTransform = new bool?(false)
		});
		return true;
	}

	// Token: 0x0600A8DE RID: 43230 RVA: 0x002602D9 File Offset: 0x0025E4D9
	public void Clear()
	{
	}
}

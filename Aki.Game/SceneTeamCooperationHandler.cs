using System;
using System.Runtime.CompilerServices;

// Token: 0x02000BB9 RID: 3001
public class SceneTeamCooperationHandler : ICooperationHandler
{
	// Token: 0x06007CBD RID: 31933 RVA: 0x0026A600 File Offset: 0x00268800
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

	// Token: 0x06007CBE RID: 31934 RVA: 0x0026A6F5 File Offset: 0x002688F5
	public void Clear()
	{
	}
}

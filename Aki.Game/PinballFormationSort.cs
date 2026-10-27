using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.Pinball;
using CSharpScript.Game.Module.RoleUi;

// Token: 0x0200188F RID: 6287
public class PinballFormationSort : CommonSort<EPinballFormation>
{
	// Token: 0x0600B848 RID: 47176 RVA: 0x0029CAA4 File Offset: 0x0029ACA4
	[NullableContext(1)]
	private int SortQuality(object a, object b, bool isAscending, params object[] parameters)
	{
		int num = (int)a;
		int num2 = (int)b;
		int selectRoleFormationNumber = PinballModel.Instance.GetSelectRoleFormationNumber(num);
		int selectRoleFormationNumber2 = PinballModel.Instance.GetSelectRoleFormationNumber(num2);
		bool flag = selectRoleFormationNumber != 0;
		bool flag2 = selectRoleFormationNumber2 != 0;
		if (flag || flag2)
		{
			if (flag != flag2)
			{
				int num3 = (flag > false) ? 1 : 0;
				return ((flag2 > false) ? 1 : 0) - num3;
			}
			return selectRoleFormationNumber - selectRoleFormationNumber2;
		}
		else
		{
			int num4 = (PinballModel.Instance.IsRecommendRole(num) > false) ? 1 : 0;
			int num5 = (PinballModel.Instance.IsRecommendRole(num2) > false) ? 1 : 0;
			if (num4 != num5)
			{
				return (num4 - num5) * (isAscending ? 1 : -1);
			}
			int roleId = PinballConfig.Instance.GetPinballRoleConfigById(num).Value.RoleId;
			int qualityId = RoleConfig.Instance.GetRoleConfig(roleId).Value.QualityId;
			int roleId2 = PinballConfig.Instance.GetPinballRoleConfigById(num2).Value.RoleId;
			int qualityId2 = RoleConfig.Instance.GetRoleConfig(roleId2).Value.QualityId;
			if (qualityId != qualityId2)
			{
				return (qualityId - qualityId2) * (isAscending ? 1 : -1);
			}
			int roleLevel = PinballModel.Instance.GetRoleLevel(num);
			int roleLevel2 = PinballModel.Instance.GetRoleLevel(num2);
			if (roleLevel != roleLevel2)
			{
				return (roleLevel2 - roleLevel) * (isAscending ? 1 : -1);
			}
			return (num - num2) * (isAscending ? 1 : -1);
		}
	}

	// Token: 0x0600B849 RID: 47177 RVA: 0x0029CC03 File Offset: 0x0029AE03
	protected override void OnInitSortMap()
	{
		this.SortMap[EPinballFormation.Quality] = new TSortResult(this.SortQuality);
	}
}

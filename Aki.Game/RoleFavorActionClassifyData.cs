using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02002841 RID: 10305
[NullableContext(1)]
[Nullable(0)]
public class RoleFavorActionClassifyData : RoleFavorClassifyDataBase
{
	// Token: 0x06015409 RID: 87049 RVA: 0x0055EFE4 File Offset: 0x0055D1E4
	public RoleFavorActionClassifyData(string titleTableId, int roleId, EFavorActionType typeParam) : base(titleTableId, roleId)
	{
		this.TypeParam = typeParam;
	}

	// Token: 0x0601540A RID: 87050 RVA: 0x0055EFFC File Offset: 0x0055D1FC
	protected override EFavorTabType GetFavorTabType()
	{
		return EFavorTabType.Action;
	}

	// Token: 0x0601540B RID: 87051 RVA: 0x0055F000 File Offset: 0x0055D200
	protected override void InitContentDataList()
	{
		this.ContentDataList.Clear();
		RoleInstance roleInstanceById = RoleModel.Instance.GetRoleInstanceById(this.RoleId);
		if (roleInstanceById == null)
		{
			return;
		}
		int roleSkinId = roleInstanceById.GetRoleSkinId();
		IReadOnlyList<Motion> roleMotionByRoleSkinId = MotionConfig.Instance.GetRoleMotionByRoleSkinId(roleSkinId);
		if (roleMotionByRoleSkinId == null || roleMotionByRoleSkinId.Count == 0)
		{
			return;
		}
		List<Motion> list = new List<Motion>(roleMotionByRoleSkinId);
		list.Sort(delegate(Motion a, Motion b)
		{
			if (a.Sort != b.Sort)
			{
				return a.Sort.CompareTo(b.Sort);
			}
			return a.Id.CompareTo(b.Id);
		});
		foreach (Motion config in list)
		{
			this.ContentDataList.Add(this.CreateActionContentData(config));
		}
	}

	// Token: 0x0601540C RID: 87052 RVA: 0x0055F0C4 File Offset: 0x0055D2C4
	private RoleFavorActionContentData CreateActionContentData(Motion config)
	{
		return new RoleFavorActionContentData(this.RoleId, this.TypeParam, config);
	}

	// Token: 0x04009EC2 RID: 40642
	public EFavorActionType TypeParam = EFavorActionType.IdleAction;
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001DBC RID: 7612
[NullableContext(1)]
[Nullable(0)]
public class RoleFavorActionClassifyData : RoleFavorClassifyDataBase
{
	// Token: 0x06012E07 RID: 77319 RVA: 0x00589D40 File Offset: 0x00587F40
	public RoleFavorActionClassifyData(string titleTableId, int roleId, EFavorActionType typeParam) : base(titleTableId, roleId)
	{
		this.TypeParam = typeParam;
	}

	// Token: 0x06012E08 RID: 77320 RVA: 0x00589D58 File Offset: 0x00587F58
	protected override EFavorTabType GetFavorTabType()
	{
		return EFavorTabType.Action;
	}

	// Token: 0x06012E09 RID: 77321 RVA: 0x00589D5C File Offset: 0x00587F5C
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

	// Token: 0x06012E0A RID: 77322 RVA: 0x00589E20 File Offset: 0x00588020
	private RoleFavorActionContentData CreateActionContentData(Motion config)
	{
		return new RoleFavorActionContentData(this.RoleId, this.TypeParam, config);
	}

	// Token: 0x0400A2AB RID: 41643
	public EFavorActionType TypeParam = EFavorActionType.IdleAction;
}

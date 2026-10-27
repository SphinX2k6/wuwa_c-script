using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004E1F RID: 19999
	[NullableContext(1)]
	[Nullable(0)]
	public class RoguelikeSelectRoleData
	{
		// Token: 0x06033951 RID: 211281 RVA: 0x00C0FD30 File Offset: 0x00C0DF30
		public RoguelikeSelectRoleData(ERoguelikeSelectRoleType roleType, List<RoleDataBase> roleIdList, int addRoleLevel, int addWeaponLevel, int maxLevel, List<int> limitRoleList = null, List<int> recommendedRoleList = null)
		{
			this.Type = roleType;
			this.RoleIdList = roleIdList;
			this.AddRoleLevel = addRoleLevel;
			this.AddWeaponLevel = addWeaponLevel;
			this.MaxLevel = maxLevel;
			if (limitRoleList != null)
			{
				this.LimitRoleList = limitRoleList;
			}
			if (recommendedRoleList != null)
			{
				this.RecommendedRoleList = recommendedRoleList;
			}
		}

		// Token: 0x0401B5C0 RID: 112064
		public ERoguelikeSelectRoleType Type = ERoguelikeSelectRoleType.Open;

		// Token: 0x0401B5C1 RID: 112065
		public List<RoleDataBase> RoleIdList = new List<RoleDataBase>();

		// Token: 0x0401B5C2 RID: 112066
		public List<int> LimitRoleList = new List<int>();

		// Token: 0x0401B5C3 RID: 112067
		public List<int> RecommendedRoleList = new List<int>();

		// Token: 0x0401B5C4 RID: 112068
		public int AddRoleLevel;

		// Token: 0x0401B5C5 RID: 112069
		public int AddWeaponLevel;

		// Token: 0x0401B5C6 RID: 112070
		public int MaxLevel;
	}
}

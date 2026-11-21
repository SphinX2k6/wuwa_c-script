using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003DE8 RID: 15848
	[NullableContext(1)]
	[Nullable(0)]
	public class RoguelikeSelectRoleData
	{
		// Token: 0x060287BC RID: 165820 RVA: 0x00B59268 File Offset: 0x00B57468
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

		// Token: 0x04015F93 RID: 90003
		public ERoguelikeSelectRoleType Type = ERoguelikeSelectRoleType.Open;

		// Token: 0x04015F94 RID: 90004
		public List<RoleDataBase> RoleIdList = new List<RoleDataBase>();

		// Token: 0x04015F95 RID: 90005
		public List<int> LimitRoleList = new List<int>();

		// Token: 0x04015F96 RID: 90006
		public List<int> RecommendedRoleList = new List<int>();

		// Token: 0x04015F97 RID: 90007
		public int AddRoleLevel;

		// Token: 0x04015F98 RID: 90008
		public int AddWeaponLevel;

		// Token: 0x04015F99 RID: 90009
		public int MaxLevel;
	}
}

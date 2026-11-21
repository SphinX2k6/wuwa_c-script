using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop.Data
{
	// Token: 0x02003D28 RID: 15656
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class RoleDevelopRoleBaseData
	{
		// Token: 0x06028189 RID: 164233 RVA: 0x00B3A52B File Offset: 0x00B3872B
		public RoleDevelopRoleBaseData(int id)
		{
			this.Id = id;
		}

		// Token: 0x0602818A RID: 164234 RVA: 0x00B3A53A File Offset: 0x00B3873A
		public int GetId()
		{
			return this.Id;
		}

		// Token: 0x0602818B RID: 164235
		public abstract ERoleDevelopRoleType GetRoleType();

		// Token: 0x0602818C RID: 164236
		public abstract string GetName();

		// Token: 0x0602818D RID: 164237
		public abstract int GetElementId();

		// Token: 0x0602818E RID: 164238
		public abstract string GetRoleIllustrationPath();

		// Token: 0x0602818F RID: 164239
		public abstract string GetRoleIconPath();

		// Token: 0x06028190 RID: 164240
		public abstract string GetRoleCircleIconPath();

		// Token: 0x06028191 RID: 164241
		public abstract string GetRoleSmallIconPath();

		// Token: 0x06028192 RID: 164242
		public abstract int GetKeyProperty();

		// Token: 0x06028193 RID: 164243
		public abstract int GetRoleLevel();

		// Token: 0x06028194 RID: 164244
		public abstract int GetRoleBreachLevel();

		// Token: 0x06028195 RID: 164245
		public abstract int GetRoleExp();

		// Token: 0x06028196 RID: 164246
		public abstract bool IsRoleMaxLevel();

		// Token: 0x06028197 RID: 164247
		public abstract bool IsRoleNeedBreakUp();

		// Token: 0x06028198 RID: 164248
		public abstract int GetRoleTargetLevel();

		// Token: 0x06028199 RID: 164249
		public abstract int GetRoleTargetBreachLevel();

		// Token: 0x0602819A RID: 164250
		public abstract int GetWeaponType();

		// Token: 0x0602819B RID: 164251
		public abstract WeaponInstance GetWeaponInstance();

		// Token: 0x0602819C RID: 164252
		public abstract string GetWeaponName();

		// Token: 0x0602819D RID: 164253
		public abstract int GetWeaponLevel();

		// Token: 0x0602819E RID: 164254
		public abstract int GetWeaponBreachLevel();

		// Token: 0x0602819F RID: 164255
		public abstract int GetWeaponExp();

		// Token: 0x060281A0 RID: 164256
		public abstract int GetWeaponTargetLevel();

		// Token: 0x060281A1 RID: 164257
		public abstract int GetWeaponTargetBreachLevel();

		// Token: 0x060281A2 RID: 164258
		public abstract bool IsWeaponMaxLevel();

		// Token: 0x060281A3 RID: 164259
		public abstract bool IsWeaponNeedBreakUp();

		// Token: 0x060281A4 RID: 164260
		public abstract bool CanDevelopPhantom();

		// Token: 0x060281A5 RID: 164261
		public abstract List<int> GetPhantomIdList();

		// Token: 0x060281A6 RID: 164262
		public abstract List<RoleDevelopPhantomSuitData> GetRecommendPhantomSuits(int? planId = null, int? firstVisionMonsterId = null);

		// Token: 0x060281A7 RID: 164263
		public abstract int GetRecommendPlanId();

		// Token: 0x060281A8 RID: 164264
		public abstract int GetRecommendFirstVisionMonsterId();

		// Token: 0x04015CDD RID: 89309
		protected readonly int Id;
	}
}

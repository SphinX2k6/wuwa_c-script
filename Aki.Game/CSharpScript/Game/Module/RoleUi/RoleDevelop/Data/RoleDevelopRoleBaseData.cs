using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop.Data
{
	// Token: 0x02004D5F RID: 19807
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class RoleDevelopRoleBaseData
	{
		// Token: 0x0603331C RID: 209692 RVA: 0x00BF1370 File Offset: 0x00BEF570
		public RoleDevelopRoleBaseData(int id)
		{
			this.Id = id;
		}

		// Token: 0x0603331D RID: 209693 RVA: 0x00BF137F File Offset: 0x00BEF57F
		public int GetId()
		{
			return this.Id;
		}

		// Token: 0x0603331E RID: 209694
		public abstract ERoleDevelopRoleType GetRoleType();

		// Token: 0x0603331F RID: 209695
		public abstract string GetName();

		// Token: 0x06033320 RID: 209696
		public abstract int GetElementId();

		// Token: 0x06033321 RID: 209697
		public abstract string GetRoleIllustrationPath();

		// Token: 0x06033322 RID: 209698
		public abstract string GetRoleIconPath();

		// Token: 0x06033323 RID: 209699
		public abstract string GetRoleCircleIconPath();

		// Token: 0x06033324 RID: 209700
		public abstract string GetRoleSmallIconPath();

		// Token: 0x06033325 RID: 209701
		public abstract int GetKeyProperty();

		// Token: 0x06033326 RID: 209702
		public abstract int GetRoleLevel();

		// Token: 0x06033327 RID: 209703
		public abstract int GetRoleBreachLevel();

		// Token: 0x06033328 RID: 209704
		public abstract int GetRoleExp();

		// Token: 0x06033329 RID: 209705
		public abstract bool IsRoleMaxLevel();

		// Token: 0x0603332A RID: 209706
		public abstract bool IsRoleNeedBreakUp();

		// Token: 0x0603332B RID: 209707
		public abstract int GetRoleTargetLevel();

		// Token: 0x0603332C RID: 209708
		public abstract int GetRoleTargetBreachLevel();

		// Token: 0x0603332D RID: 209709
		public abstract int GetWeaponType();

		// Token: 0x0603332E RID: 209710
		public abstract WeaponInstance GetWeaponInstance();

		// Token: 0x0603332F RID: 209711
		public abstract string GetWeaponName();

		// Token: 0x06033330 RID: 209712
		public abstract int GetWeaponLevel();

		// Token: 0x06033331 RID: 209713
		public abstract int GetWeaponBreachLevel();

		// Token: 0x06033332 RID: 209714
		public abstract int GetWeaponExp();

		// Token: 0x06033333 RID: 209715
		public abstract int GetWeaponTargetLevel();

		// Token: 0x06033334 RID: 209716
		public abstract int GetWeaponTargetBreachLevel();

		// Token: 0x06033335 RID: 209717
		public abstract bool IsWeaponMaxLevel();

		// Token: 0x06033336 RID: 209718
		public abstract bool IsWeaponNeedBreakUp();

		// Token: 0x06033337 RID: 209719
		public abstract bool CanDevelopPhantom();

		// Token: 0x06033338 RID: 209720
		public abstract List<int> GetPhantomIdList();

		// Token: 0x06033339 RID: 209721
		public abstract List<RoleDevelopPhantomSuitData> GetRecommendPhantomSuits(int? planId = null, int? firstVisionMonsterId = null);

		// Token: 0x0603333A RID: 209722
		public abstract int GetRecommendPlanId();

		// Token: 0x0603333B RID: 209723
		public abstract int GetRecommendFirstVisionMonsterId();

		// Token: 0x0401B30C RID: 111372
		protected readonly int Id;
	}
}

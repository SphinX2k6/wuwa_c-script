using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Personal
{
	// Token: 0x020052E9 RID: 21225
	[NullableContext(1)]
	[Nullable(0)]
	public class PlayerHeadData
	{
		// Token: 0x060364A6 RID: 222374 RVA: 0x00CD7960 File Offset: 0x00CD5B60
		public PlayerHeadData(PlayerHeadRe config)
		{
			this.Id = config.Id;
			this.Config = config;
			if (config.RoleSkinId > 0)
			{
				this.RoleSkinData = RoleSkinModel.Instance.GetRoleSkinData(config.RoleSkinId);
			}
		}

		// Token: 0x1700830B RID: 33547
		// (get) Token: 0x060364A7 RID: 222375 RVA: 0x00CD79AF File Offset: 0x00CD5BAF
		// (set) Token: 0x060364A8 RID: 222376 RVA: 0x00CD79B7 File Offset: 0x00CD5BB7
		public bool Lock
		{
			get
			{
				return this.LockInternal;
			}
			set
			{
				this.LockInternal = value;
			}
		}

		// Token: 0x060364A9 RID: 222377 RVA: 0x00CD79C0 File Offset: 0x00CD5BC0
		public string GetName()
		{
			if (this.RoleSkinData != null)
			{
				return this.RoleSkinData.GetRoleSkinConfig().Name;
			}
			return this.Config.Name;
		}

		// Token: 0x060364AA RID: 222378 RVA: 0x00CD79F8 File Offset: 0x00CD5BF8
		public string GetRoleHeadIconLarge()
		{
			if (this.RoleSkinData != null)
			{
				return this.RoleSkinData.GetRoleSkinConfig().RoleHeadIconLarge;
			}
			return this.Config.RoleHeadIconLarge;
		}

		// Token: 0x060364AB RID: 222379 RVA: 0x00CD7A30 File Offset: 0x00CD5C30
		public string GetRoleHeadIcon()
		{
			if (this.RoleSkinData != null)
			{
				return this.RoleSkinData.GetRoleSkinConfig().RoleHeadIcon;
			}
			return this.Config.RoleHeadIcon;
		}

		// Token: 0x060364AC RID: 222380 RVA: 0x00CD7A68 File Offset: 0x00CD5C68
		public string GetRoleCardHeadIcon()
		{
			if (this.RoleSkinData != null)
			{
				return this.RoleSkinData.GetRoleSkinConfig().Card;
			}
			return this.Config.Card;
		}

		// Token: 0x060364AD RID: 222381 RVA: 0x00CD7AA0 File Offset: 0x00CD5CA0
		public string GetRoleHeadIconCircle()
		{
			if (this.RoleSkinData != null)
			{
				return this.RoleSkinData.GetRoleSkinConfig().RoleHeadIconCircle;
			}
			return this.Config.RoleHeadIconCircle;
		}

		// Token: 0x0401CB15 RID: 117525
		public readonly int Id;

		// Token: 0x0401CB16 RID: 117526
		public readonly PlayerHeadRe Config;

		// Token: 0x0401CB17 RID: 117527
		private bool LockInternal = true;

		// Token: 0x0401CB18 RID: 117528
		[Nullable(2)]
		private readonly RoleSkinData RoleSkinData;
	}
}

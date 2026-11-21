using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Personal
{
	// Token: 0x020042B9 RID: 17081
	[NullableContext(1)]
	[Nullable(0)]
	public class PlayerHeadData
	{
		// Token: 0x0602B3A1 RID: 177057 RVA: 0x00C25084 File Offset: 0x00C23284
		public PlayerHeadData(PlayerHeadRe config)
		{
			this.Id = config.Id;
			this.Config = config;
			if (config.RoleSkinId > 0)
			{
				this.RoleSkinData = RoleSkinModel.Instance.GetRoleSkinData(config.RoleSkinId);
			}
		}

		// Token: 0x170056CB RID: 22219
		// (get) Token: 0x0602B3A2 RID: 177058 RVA: 0x00C250D3 File Offset: 0x00C232D3
		// (set) Token: 0x0602B3A3 RID: 177059 RVA: 0x00C250DB File Offset: 0x00C232DB
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

		// Token: 0x0602B3A4 RID: 177060 RVA: 0x00C250E4 File Offset: 0x00C232E4
		public string GetName()
		{
			if (this.RoleSkinData != null)
			{
				return this.RoleSkinData.GetRoleSkinConfig().Name;
			}
			return this.Config.Name;
		}

		// Token: 0x0602B3A5 RID: 177061 RVA: 0x00C2511C File Offset: 0x00C2331C
		public string GetRoleHeadIconLarge()
		{
			if (this.RoleSkinData != null)
			{
				return this.RoleSkinData.GetRoleSkinConfig().RoleHeadIconLarge;
			}
			return this.Config.RoleHeadIconLarge;
		}

		// Token: 0x0602B3A6 RID: 177062 RVA: 0x00C25154 File Offset: 0x00C23354
		public string GetRoleHeadIcon()
		{
			if (this.RoleSkinData != null)
			{
				return this.RoleSkinData.GetRoleSkinConfig().RoleHeadIcon;
			}
			return this.Config.RoleHeadIcon;
		}

		// Token: 0x0602B3A7 RID: 177063 RVA: 0x00C2518C File Offset: 0x00C2338C
		public string GetRoleCardHeadIcon()
		{
			if (this.RoleSkinData != null)
			{
				return this.RoleSkinData.GetRoleSkinConfig().Card;
			}
			return this.Config.Card;
		}

		// Token: 0x0602B3A8 RID: 177064 RVA: 0x00C251C4 File Offset: 0x00C233C4
		public string GetRoleHeadIconCircle()
		{
			if (this.RoleSkinData != null)
			{
				return this.RoleSkinData.GetRoleSkinConfig().RoleHeadIconCircle;
			}
			return this.Config.RoleHeadIconCircle;
		}

		// Token: 0x0401754A RID: 95562
		public readonly int Id;

		// Token: 0x0401754B RID: 95563
		public readonly PlayerHeadRe Config;

		// Token: 0x0401754C RID: 95564
		private bool LockInternal = true;

		// Token: 0x0401754D RID: 95565
		[Nullable(2)]
		private readonly RoleSkinData RoleSkinData;
	}
}

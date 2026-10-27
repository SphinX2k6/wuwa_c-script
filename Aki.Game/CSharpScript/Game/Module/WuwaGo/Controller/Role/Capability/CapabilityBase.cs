using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.Module.WuwaGo.Model.Role;

namespace CSharpScript.Game.Module.WuwaGo.Controller.Role.Capability
{
	// Token: 0x02004762 RID: 18274
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class CapabilityBase
	{
		// Token: 0x0602FC59 RID: 195673 RVA: 0x00B111CD File Offset: 0x00B0F3CD
		protected CapabilityBase(WuWaGoRole role)
		{
		}

		// Token: 0x17007755 RID: 30549
		// (get) Token: 0x0602FC5A RID: 195674 RVA: 0x00B111DC File Offset: 0x00B0F3DC
		protected EWuWaGoRoleType RoleType
		{
			get
			{
				return this.Role.Type;
			}
		}

		// Token: 0x04019C59 RID: 105561
		protected readonly WuWaGoRole Role = role;
	}
}

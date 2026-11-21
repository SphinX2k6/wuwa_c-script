using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.Module.WuwaGo.Model.Role;

namespace CSharpScript.Game.Module.WuwaGo.Controller.Role.Capability
{
	// Token: 0x02003693 RID: 13971
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class CapabilityBase
	{
		// Token: 0x06024423 RID: 148515 RVA: 0x00A4118D File Offset: 0x00A3F38D
		protected CapabilityBase(WuWaGoRole role)
		{
		}

		// Token: 0x17004A11 RID: 18961
		// (get) Token: 0x06024424 RID: 148516 RVA: 0x00A4119C File Offset: 0x00A3F39C
		protected EWuWaGoRoleType RoleType
		{
			get
			{
				return this.Role.Type;
			}
		}

		// Token: 0x04014309 RID: 82697
		protected readonly WuWaGoRole Role = role;
	}
}

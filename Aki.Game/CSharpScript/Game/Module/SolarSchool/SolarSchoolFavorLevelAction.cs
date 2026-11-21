using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.ActivityAction;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020058B6 RID: 22710
	public class SolarSchoolFavorLevelAction : SolarSchoolActionBase
	{
		// Token: 0x06037EFA RID: 229114 RVA: 0x00FA2A10 File Offset: 0x00FA0C10
		[NullableContext(1)]
		protected override void OnParse(IReadOnlyDictionary<string, string> parameters)
		{
			this.RoleId = ActivityActionBase.GetParamInt(parameters, "SolarSchoolRoleId", this.RoleId);
		}

		// Token: 0x06037EFB RID: 229115 RVA: 0x00FA2A29 File Offset: 0x00FA0C29
		protected override void OnStart()
		{
			SolarSchoolGamePlayModel instance = SolarSchoolGamePlayModel.Instance;
			instance.UnlockRole(this.RoleId);
			instance.TryLevelUpFavor(this.RoleId);
			base.MarkDone();
		}

		// Token: 0x0401D817 RID: 120855
		private int RoleId;
	}
}

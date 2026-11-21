using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020058CE RID: 22734
	public readonly struct SolarSchoolRoleTalkInfo
	{
		// Token: 0x06037FB6 RID: 229302 RVA: 0x00FA5EC8 File Offset: 0x00FA40C8
		public SolarSchoolRoleTalkInfo(SolarSchoolRoleSpine spine, int specialBehaviorId)
		{
			this.TextKey = (spine.TextKey ?? string.Empty);
			this.AudioId = spine.AudioId;
			this.AnimationId = spine.AnimationId;
			this.RoleSpineId = spine.Id;
			this.SpecialBehaviorId = specialBehaviorId;
		}

		// Token: 0x0401D86E RID: 120942
		[Nullable(1)]
		public readonly string TextKey;

		// Token: 0x0401D86F RID: 120943
		[Nullable(2)]
		public readonly string AudioId;

		// Token: 0x0401D870 RID: 120944
		public readonly int AnimationId;

		// Token: 0x0401D871 RID: 120945
		public readonly int RoleSpineId;

		// Token: 0x0401D872 RID: 120946
		public readonly int SpecialBehaviorId;
	}
}

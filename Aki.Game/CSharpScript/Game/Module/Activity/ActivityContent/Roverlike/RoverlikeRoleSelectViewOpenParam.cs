using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x020050FD RID: 20733
	public class RoverlikeRoleSelectViewOpenParam
	{
		// Token: 0x0401B776 RID: 112502
		public int DefaultRoleTypeId;

		// Token: 0x0401B777 RID: 112503
		public int InstId;

		// Token: 0x0401B778 RID: 112504
		[Nullable(2)]
		public Action<int> OnConfirm;
	}
}

using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x0200617F RID: 24959
	public class RoverlikeRoleSelectViewOpenParam
	{
		// Token: 0x04020E49 RID: 134729
		public int DefaultRoleTypeId;

		// Token: 0x04020E4A RID: 134730
		public int InstId;

		// Token: 0x04020E4B RID: 134731
		[Nullable(2)]
		public Action<int> OnConfirm;
	}
}

using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.MapRogue;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020035D1 RID: 13777
	public class ViewHotKeyHandleRoleRootView : ViewHotKeyHandle
	{
		// Token: 0x0602312E RID: 143662 RVA: 0x009F997D File Offset: 0x009F7B7D
		[NullableContext(1)]
		public ViewHotKeyHandleRoleRootView(IOpenAndCloseViewHotKey parameters) : base(parameters)
		{
		}

		// Token: 0x0602312F RID: 143663 RVA: 0x009F9986 File Offset: 0x009F7B86
		protected override bool SpecialConditionCheck()
		{
			return !MapRogueController.Instance.CheckInMapRogueInstance();
		}
	}
}

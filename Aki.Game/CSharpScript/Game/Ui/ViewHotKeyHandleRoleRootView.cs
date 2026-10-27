using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.MapRogue;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020046A0 RID: 18080
	public class ViewHotKeyHandleRoleRootView : ViewHotKeyHandle
	{
		// Token: 0x0602E9E2 RID: 190946 RVA: 0x00ACB0A9 File Offset: 0x00AC92A9
		[NullableContext(1)]
		public ViewHotKeyHandleRoleRootView(IOpenAndCloseViewHotKey parameters) : base(parameters)
		{
		}

		// Token: 0x0602E9E3 RID: 190947 RVA: 0x00ACB0B2 File Offset: 0x00AC92B2
		protected override bool SpecialConditionCheck()
		{
			return !MapRogueController.Instance.CheckInMapRogueInstance();
		}
	}
}

using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020035CD RID: 13773
	public class ViewHotKeyHandleFormation : ViewHotKeyHandle
	{
		// Token: 0x06023123 RID: 143651 RVA: 0x009F9847 File Offset: 0x009F7A47
		[NullableContext(1)]
		public ViewHotKeyHandleFormation(IOpenAndCloseViewHotKey parameters) : base(parameters)
		{
		}

		// Token: 0x170048F0 RID: 18672
		// (get) Token: 0x06023124 RID: 143652 RVA: 0x009F9850 File Offset: 0x009F7A50
		public override EUiViewName? ViewName
		{
			get
			{
				return new EUiViewName?(FormationController.Instance.GetUseFormation3DView() ? EUiViewName.Formation3DView : EUiViewName.Formation2DView);
			}
		}

		// Token: 0x06023125 RID: 143653 RVA: 0x009F986F File Offset: 0x009F7A6F
		protected override void OnOpenViewImplement()
		{
			FormationController.Instance.OpenFormationView((this.ViewParam.Length != 0) ? this.ViewParam : null, null);
		}
	}
}

using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x0200469C RID: 18076
	public class ViewHotKeyHandleFormation : ViewHotKeyHandle
	{
		// Token: 0x0602E9D7 RID: 190935 RVA: 0x00ACAF73 File Offset: 0x00AC9173
		[NullableContext(1)]
		public ViewHotKeyHandleFormation(IOpenAndCloseViewHotKey parameters) : base(parameters)
		{
		}

		// Token: 0x17007634 RID: 30260
		// (get) Token: 0x0602E9D8 RID: 190936 RVA: 0x00ACAF7C File Offset: 0x00AC917C
		public override EUiViewName? ViewName
		{
			get
			{
				return new EUiViewName?(FormationController.Instance.GetUseFormation3DView() ? EUiViewName.Formation3DView : EUiViewName.Formation2DView);
			}
		}

		// Token: 0x0602E9D9 RID: 190937 RVA: 0x00ACAF9B File Offset: 0x00AC919B
		protected override void OnOpenViewImplement()
		{
			FormationController.Instance.OpenFormationView((this.ViewParam.Length != 0) ? this.ViewParam : null, null);
		}
	}
}

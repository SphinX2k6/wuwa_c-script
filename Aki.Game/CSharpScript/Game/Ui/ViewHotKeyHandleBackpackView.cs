using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Functional;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02004699 RID: 18073
	public class ViewHotKeyHandleBackpackView : ViewHotKeyHandle
	{
		// Token: 0x0602E9C9 RID: 190921 RVA: 0x00ACAC80 File Offset: 0x00AC8E80
		[NullableContext(1)]
		public ViewHotKeyHandleBackpackView(IOpenAndCloseViewHotKey parameters) : base(parameters)
		{
		}

		// Token: 0x17007633 RID: 30259
		// (get) Token: 0x0602E9CA RID: 190922 RVA: 0x00ACAC89 File Offset: 0x00AC8E89
		public override EUiViewName? ViewName
		{
			get
			{
				if (HonamiStoryUtil.CheckInHonamiStoryDungeon())
				{
					return new EUiViewName?(EUiViewName.HonamiStoryBackpackView);
				}
				return this.DefaultViewName;
			}
		}

		// Token: 0x0602E9CB RID: 190923 RVA: 0x00ACACA3 File Offset: 0x00AC8EA3
		protected override void OnOpenViewImplement()
		{
			if (HonamiStoryUtil.CheckInHonamiStoryDungeon())
			{
				if (FunctionModel.Instance.IsOpen(10102))
				{
					FunctionController.Instance.OpenFunctionRelateView(EFunctionType.HonamiStoryBackpack);
				}
				return;
			}
			base.OnOpenViewImplement();
		}
	}
}

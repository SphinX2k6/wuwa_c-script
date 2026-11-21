using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Functional;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020035CA RID: 13770
	public class ViewHotKeyHandleBackpackView : ViewHotKeyHandle
	{
		// Token: 0x06023115 RID: 143637 RVA: 0x009F9554 File Offset: 0x009F7754
		[NullableContext(1)]
		public ViewHotKeyHandleBackpackView(IOpenAndCloseViewHotKey parameters) : base(parameters)
		{
		}

		// Token: 0x170048EF RID: 18671
		// (get) Token: 0x06023116 RID: 143638 RVA: 0x009F955D File Offset: 0x009F775D
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

		// Token: 0x06023117 RID: 143639 RVA: 0x009F9577 File Offset: 0x009F7777
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

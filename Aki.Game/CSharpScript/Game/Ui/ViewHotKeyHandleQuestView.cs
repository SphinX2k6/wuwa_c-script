using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020035D0 RID: 13776
	public class ViewHotKeyHandleQuestView : ViewHotKeyHandle
	{
		// Token: 0x0602312B RID: 143659 RVA: 0x009F9939 File Offset: 0x009F7B39
		[NullableContext(1)]
		public ViewHotKeyHandleQuestView(IOpenAndCloseViewHotKey parameters) : base(parameters)
		{
		}

		// Token: 0x170048F1 RID: 18673
		// (get) Token: 0x0602312C RID: 143660 RVA: 0x009F9942 File Offset: 0x009F7B42
		public override EUiViewName? ViewName
		{
			get
			{
				if (HonamiStoryUtil.CheckHonamiQuestOpen())
				{
					return new EUiViewName?(EUiViewName.HonamiStoryQuestView);
				}
				return this.DefaultViewName;
			}
		}

		// Token: 0x0602312D RID: 143661 RVA: 0x009F995C File Offset: 0x009F7B5C
		protected override void OnOpenViewImplement()
		{
			if (HonamiStoryUtil.CheckHonamiQuestOpen())
			{
				UiManager.Instance.OpenView(EUiViewName.HonamiStoryQuestView, null, null);
				return;
			}
			base.OnOpenViewImplement();
		}
	}
}

using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x0200469F RID: 18079
	public class ViewHotKeyHandleQuestView : ViewHotKeyHandle
	{
		// Token: 0x0602E9DF RID: 190943 RVA: 0x00ACB065 File Offset: 0x00AC9265
		[NullableContext(1)]
		public ViewHotKeyHandleQuestView(IOpenAndCloseViewHotKey parameters) : base(parameters)
		{
		}

		// Token: 0x17007635 RID: 30261
		// (get) Token: 0x0602E9E0 RID: 190944 RVA: 0x00ACB06E File Offset: 0x00AC926E
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

		// Token: 0x0602E9E1 RID: 190945 RVA: 0x00ACB088 File Offset: 0x00AC9288
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

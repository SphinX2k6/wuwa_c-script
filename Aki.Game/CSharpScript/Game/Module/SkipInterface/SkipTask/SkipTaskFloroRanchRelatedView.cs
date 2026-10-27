using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.SkipInterface.SkipTask
{
	// Token: 0x02004BAC RID: 19372
	public class SkipTaskFloroRanchRelatedView : SkipTask
	{
		// Token: 0x060322E2 RID: 205538 RVA: 0x00BA8DE5 File Offset: 0x00BA6FE5
		public SkipTaskFloroRanchRelatedView()
		{
			this.OpenView = delegate(EUiViewName viewName)
			{
				if (this.CheckViewExistAndReset(viewName))
				{
					return;
				}
				UiManager.Instance.OpenView(viewName, null, null);
			};
		}

		// Token: 0x060322E3 RID: 205539 RVA: 0x00BA8E00 File Offset: 0x00BA7000
		protected override void OnRun([Nullable(new byte[]
		{
			1,
			2
		})] params object[] data)
		{
			string s = (string)data[0];
			string text = (string)data[1];
			string text2 = (string)data[2];
			FloroRanchActivityData activityData = FloroRanchModel.Instance.GetActivityData(EFloroRanchActivityDataType.Normal, true);
			if (activityData == null || !activityData.IsUnLock())
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("Farm_ActivityLock", Array.Empty<object>());
				return;
			}
			switch (int.Parse(s))
			{
			case 1:
				this.OpenView(EUiViewName.FloroRanchMainView);
				break;
			case 2:
				this.OpenView(EUiViewName.FloroRanchMainView);
				this.OpenView(EUiViewName.FloroRanchTechnologyView);
				break;
			case 3:
				this.OpenView(EUiViewName.FloroRanchMainView);
				this.OpenView(EUiViewName.FloroRanchDungeonSelectView);
				break;
			case 4:
				this.OpenView(EUiViewName.FloroRanchMainView);
				this.OpenView(EUiViewName.FloroRanchHandBookView);
				break;
			}
			base.Finish();
		}

		// Token: 0x060322E4 RID: 205540 RVA: 0x00BA8EF2 File Offset: 0x00BA70F2
		private bool CheckViewExistAndReset(EUiViewName viewName)
		{
			if (UiManager.Instance.IsViewOpen(viewName))
			{
				return true;
			}
			if (UiManager.Instance.GetViewByName(viewName) != null)
			{
				UiManager.Instance.NormalResetToView(viewName, null, true);
				return true;
			}
			return false;
		}

		// Token: 0x0401AB8B RID: 109451
		[Nullable(1)]
		private readonly Action<EUiViewName> OpenView;

		// Token: 0x0200ADD0 RID: 44496
		private enum EFloroRanchViewDefine
		{
			// Token: 0x04034CA6 RID: 216230
			MainView = 1,
			// Token: 0x04034CA7 RID: 216231
			TechView,
			// Token: 0x04034CA8 RID: 216232
			SelectDungeon,
			// Token: 0x04034CA9 RID: 216233
			HandBook
		}
	}
}

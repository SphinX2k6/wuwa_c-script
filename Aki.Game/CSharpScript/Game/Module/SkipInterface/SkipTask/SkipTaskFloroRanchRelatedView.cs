using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.SkipInterface.SkipTask
{
	// Token: 0x02003B56 RID: 15190
	public class SkipTaskFloroRanchRelatedView : SkipTask
	{
		// Token: 0x06027073 RID: 159859 RVA: 0x00AED059 File Offset: 0x00AEB259
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

		// Token: 0x06027074 RID: 159860 RVA: 0x00AED074 File Offset: 0x00AEB274
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

		// Token: 0x06027075 RID: 159861 RVA: 0x00AED166 File Offset: 0x00AEB366
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

		// Token: 0x040154E0 RID: 87264
		[Nullable(1)]
		private readonly Action<EUiViewName> OpenView;

		// Token: 0x020097EF RID: 38895
		private enum EFloroRanchViewDefine
		{
			// Token: 0x0402F64D RID: 194125
			MainView = 1,
			// Token: 0x0402F64E RID: 194126
			TechView,
			// Token: 0x0402F64F RID: 194127
			SelectDungeon,
			// Token: 0x0402F650 RID: 194128
			HandBook
		}
	}
}

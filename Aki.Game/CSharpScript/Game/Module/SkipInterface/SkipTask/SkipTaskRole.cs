using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.SkipInterface.SkipTask
{
	// Token: 0x02003B61 RID: 15201
	public class SkipTaskRole : SkipTask
	{
		// Token: 0x0602708D RID: 159885 RVA: 0x00AED8A8 File Offset: 0x00AEBAA8
		protected override void OnRun([Nullable(new byte[]
		{
			1,
			2
		})] params object[] data)
		{
			string text = (string)data[0];
			EUiTabViewName? openTabView = null;
			if (text != "0")
			{
				openTabView = new EUiTabViewName?(new EUiTabViewName(text));
			}
			RoleController.Instance.OpenRoleMainView(ERoleAgentType.Normal, 0, new List<int>(), openTabView, null);
			base.Finish();
		}

		// Token: 0x040154E3 RID: 87267
		[Nullable(1)]
		private const string DEFAULT_PARAM = "0";
	}
}

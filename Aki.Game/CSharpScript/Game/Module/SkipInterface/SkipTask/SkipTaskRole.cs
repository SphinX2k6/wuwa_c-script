using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.SkipInterface.SkipTask
{
	// Token: 0x02004BB7 RID: 19383
	public class SkipTaskRole : SkipTask
	{
		// Token: 0x060322FC RID: 205564 RVA: 0x00BA95FC File Offset: 0x00BA77FC
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

		// Token: 0x0401AB8E RID: 109454
		[Nullable(1)]
		private const string DEFAULT_PARAM = "0";
	}
}

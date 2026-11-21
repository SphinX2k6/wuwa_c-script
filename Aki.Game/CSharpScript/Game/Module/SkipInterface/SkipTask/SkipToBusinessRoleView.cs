using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.SkipInterface.SkipTask
{
	// Token: 0x02003B6B RID: 15211
	public class SkipToBusinessRoleView : SkipToMoonChasingBase
	{
		// Token: 0x060270A2 RID: 159906 RVA: 0x00AEDEE4 File Offset: 0x00AEC0E4
		protected override void OnRun([Nullable(new byte[]
		{
			1,
			2
		})] params object[] data)
		{
			string s = (string)data[0];
			if (!base.CheckMainViewOpen())
			{
				base.SkipToMap(int.Parse(s));
				return;
			}
			MoonChasingController.Instance.OpenHelperView();
		}
	}
}

using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.SkipInterface.SkipTask
{
	// Token: 0x02004BC1 RID: 19393
	public class SkipToBusinessRoleView : SkipToMoonChasingBase
	{
		// Token: 0x06032311 RID: 205585 RVA: 0x00BA9C38 File Offset: 0x00BA7E38
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

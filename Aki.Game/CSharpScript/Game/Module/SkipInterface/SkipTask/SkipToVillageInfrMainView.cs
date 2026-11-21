using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.VillageInfr;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.SkipInterface.SkipTask
{
	// Token: 0x02003B86 RID: 15238
	public class SkipToVillageInfrMainView : SkipTask
	{
		// Token: 0x060270DA RID: 159962 RVA: 0x00AEECD4 File Offset: 0x00AECED4
		protected override void OnRun([Nullable(new byte[]
		{
			1,
			2
		})] params object[] data)
		{
			string textId = (string)data[0];
			if (!FunctionModel.Instance.IsOpen(10150))
			{
				ScrollingTipsController.Instance.ShowTipsByTextId(textId, Array.Empty<object>());
			}
			else
			{
				VillageInfrController.Instance.OpenVillageInfrMainView(null).Forget<int?>();
			}
			base.Finish();
		}
	}
}

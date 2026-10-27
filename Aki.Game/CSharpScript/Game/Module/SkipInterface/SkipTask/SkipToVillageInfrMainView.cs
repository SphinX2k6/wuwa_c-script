using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.VillageInfr;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.SkipInterface.SkipTask
{
	// Token: 0x02004BDC RID: 19420
	public class SkipToVillageInfrMainView : SkipTask
	{
		// Token: 0x06032349 RID: 205641 RVA: 0x00BAAA1C File Offset: 0x00BA8C1C
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

using System;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.InstanceDungeon.Define
{
	// Token: 0x020048AD RID: 18605
	public class InstanceDungeonEntranceFlowAdamSmasher : InstanceDungeonEntranceFlowBase
	{
		// Token: 0x0602EBBF RID: 191423 RVA: 0x00D0944C File Offset: 0x00D0764C
		protected override void OnCreate()
		{
			base.AddStep(delegate
			{
				UiManager.Instance.OpenView(EUiViewName.AdamSmasherSelectView, null, null);
			});
		}
	}
}

using System;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.InstanceDungeon.Define
{
	// Token: 0x020058D5 RID: 22741
	public class InstanceDungeonEntranceFlowAdamSmasher : InstanceDungeonEntranceFlowBase
	{
		// Token: 0x06039C9C RID: 236700 RVA: 0x00DBA534 File Offset: 0x00DB8734
		protected override void OnCreate()
		{
			base.AddStep(delegate
			{
				UiManager.Instance.OpenView(EUiViewName.AdamSmasherSelectView, null, null);
			});
		}
	}
}

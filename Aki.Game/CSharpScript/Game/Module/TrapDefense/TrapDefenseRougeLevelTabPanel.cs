using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02003A61 RID: 14945
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class TrapDefenseRougeLevelTabPanel : TrapDefenseLevelTabPanel<TrapDefenseRougeModeData>
	{
		// Token: 0x0602668F RID: 157327 RVA: 0x00AC23CF File Offset: 0x00AC05CF
		public TrapDefenseRougeLevelTabPanel()
		{
			this.ModeData = TrapDefenseModel.Instance.RougeModeData;
		}

		// Token: 0x06026690 RID: 157328 RVA: 0x00AC23E7 File Offset: 0x00AC05E7
		protected override void OnStart()
		{
			this.PanelDifficultyChange.SetActive(false);
		}

		// Token: 0x06026691 RID: 157329 RVA: 0x00AC23F5 File Offset: 0x00AC05F5
		public override void UpdateModeData()
		{
			base.UpdateLevelDataList(this.ModeData.LevelDataList.ToArray());
			base.UpdateBdSumProgress();
		}
	}
}

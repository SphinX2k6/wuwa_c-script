using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004AB9 RID: 19129
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class TrapDefenseRougeLevelTabPanel : TrapDefenseLevelTabPanel<TrapDefenseRougeModeData>
	{
		// Token: 0x060318FF RID: 203007 RVA: 0x00B7E41B File Offset: 0x00B7C61B
		public TrapDefenseRougeLevelTabPanel()
		{
			this.ModeData = TrapDefenseModel.Instance.RougeModeData;
		}

		// Token: 0x06031900 RID: 203008 RVA: 0x00B7E433 File Offset: 0x00B7C633
		protected override void OnStart()
		{
			this.PanelDifficultyChange.SetActive(false);
		}

		// Token: 0x06031901 RID: 203009 RVA: 0x00B7E441 File Offset: 0x00B7C641
		public override void UpdateModeData()
		{
			base.UpdateLevelDataList(this.ModeData.LevelDataList.ToArray());
			base.UpdateBdSumProgress();
		}
	}
}

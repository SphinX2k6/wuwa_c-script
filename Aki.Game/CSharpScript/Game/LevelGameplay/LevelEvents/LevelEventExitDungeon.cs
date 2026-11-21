using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.InstanceDungeon;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02005C9E RID: 23710
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelEventExitDungeon : LevelEventBase
	{
		// Token: 0x0603A24B RID: 238155 RVA: 0x01065943 File Offset: 0x01063B43
		public LevelEventExitDungeon(int id) : base(id)
		{
		}

		// Token: 0x0603A24C RID: 238156 RVA: 0x0106594C File Offset: 0x01063B4C
		protected override void ExecuteInGm(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			base.FinishExecute(true, false, true);
		}

		// Token: 0x0603A24D RID: 238157 RVA: 0x01065958 File Offset: 0x01063B58
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			SundryModel instance = SundryModel.Instance;
			if (instance != null && instance.IsBlockTpDungeon())
			{
				ScrollingTipsController.Instance.ShowTipsByText("ExitDungeon被GM屏蔽，跳过执行");
				base.FinishExecute(true, false, true);
				return;
			}
			base.FinishExecute(true, false, true);
			ExitDungeon exitDungeon = inParams as ExitDungeon;
			if (exitDungeon == null || !exitDungeon.IsNeedSecondaryConfirmation.GetValueOrDefault())
			{
				return;
			}
			InstanceDungeonController.Instance.OnClickInstanceDungeonExitButton(null, null, false);
		}
	}
}

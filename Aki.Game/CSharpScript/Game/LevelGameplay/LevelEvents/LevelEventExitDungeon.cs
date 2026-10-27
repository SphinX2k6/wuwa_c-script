using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.InstanceDungeon;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006B26 RID: 27430
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelEventExitDungeon : LevelEventBase
	{
		// Token: 0x060440F9 RID: 278777 RVA: 0x010BC0B7 File Offset: 0x010BA2B7
		public LevelEventExitDungeon(int id) : base(id)
		{
		}

		// Token: 0x060440FA RID: 278778 RVA: 0x010BC0C0 File Offset: 0x010BA2C0
		protected override void ExecuteInGm(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			base.FinishExecute(true, false, true);
		}

		// Token: 0x060440FB RID: 278779 RVA: 0x010BC0CC File Offset: 0x010BA2CC
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

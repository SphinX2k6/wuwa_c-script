using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.World.Controller;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006B7D RID: 27517
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelEventSetSubLevelsVisible : LevelEventBase
	{
		// Token: 0x0604425E RID: 279134 RVA: 0x010CA32A File Offset: 0x010C852A
		public LevelEventSetSubLevelsVisible(int id) : base(id)
		{
		}

		// Token: 0x0604425F RID: 279135 RVA: 0x010CA334 File Offset: 0x010C8534
		protected override void ExecuteInGm(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			this.ExecuteNew(inParams, context, null);
		}

		// Token: 0x06044260 RID: 279136 RVA: 0x010CA354 File Offset: 0x010C8554
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			if (inParams == null)
			{
				return;
			}
			ClientPreEnableSubLevels clientPreEnableSubLevels = inParams as ClientPreEnableSubLevels;
			if (clientPreEnableSubLevels == null)
			{
				global::Log.Instance.Error(ELogModule.LevelEvent, ELogAuthor.YSQ, "执行行为.LevelEventSetSubLevelsVisible 参数不正确", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			SubLevelController.Instance.SetSubLevelVisible(new SetSubLevelVisibleParams
			{
				ActionParams = clientPreEnableSubLevels,
				Context = context,
				ActionId = base.Id,
				GroupId = this.GroupId,
				FinishCallback = delegate(bool _)
				{
					base.FinishExecute(true, false, true);
				}
			});
		}
	}
}

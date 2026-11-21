using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.World.Controller;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02005CF5 RID: 23797
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelEventSetSubLevelsVisible : LevelEventBase
	{
		// Token: 0x0603A3B0 RID: 238512 RVA: 0x01073F9E File Offset: 0x0107219E
		public LevelEventSetSubLevelsVisible(int id) : base(id)
		{
		}

		// Token: 0x0603A3B1 RID: 238513 RVA: 0x01073FA8 File Offset: 0x010721A8
		protected override void ExecuteInGm(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			this.ExecuteNew(inParams, context, null);
		}

		// Token: 0x0603A3B2 RID: 238514 RVA: 0x01073FC8 File Offset: 0x010721C8
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

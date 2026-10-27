using System;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.LevelAi.Tasks
{
	// Token: 0x02006DBD RID: 28093
	public class LevelAiTaskLog : LevelAiTask
	{
		// Token: 0x060448B8 RID: 280760 RVA: 0x010E75B8 File Offset: 0x010E57B8
		protected override ELevelAiNodeResult ExecuteTask()
		{
			Aki.TDConfigMgr.Action.Log log = this.Params as Aki.TDConfigMgr.Action.Log;
			if (log == null)
			{
				return ELevelAiNodeResult.Succeeded;
			}
			string level = log.Level;
			if (!(level == "Warn"))
			{
				if (!(level == "Info"))
				{
					if (level == "Error")
					{
						global::Log.Instance.Error(ELogModule.LevelAi, ELogAuthor.CJH, log.Content, default(ReadOnlySpan<ValueTuple<string, object>>));
					}
				}
				else
				{
					global::Log.Instance.Info(ELogModule.LevelAi, ELogAuthor.CJH, log.Content, default(ReadOnlySpan<ValueTuple<string, object>>));
				}
			}
			else
			{
				global::Log.Instance.Warn(ELogModule.LevelAi, ELogAuthor.CJH, log.Content, default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			return ELevelAiNodeResult.Succeeded;
		}
	}
}

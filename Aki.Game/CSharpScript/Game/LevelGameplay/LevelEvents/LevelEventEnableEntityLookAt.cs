using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006B15 RID: 27413
	public class LevelEventEnableEntityLookAt : LevelEventBase
	{
		// Token: 0x060440A1 RID: 278689 RVA: 0x010B94DC File Offset: 0x010B76DC
		public LevelEventEnableEntityLookAt(int id) : base(id)
		{
		}

		// Token: 0x060440A2 RID: 278690 RVA: 0x010B94E8 File Offset: 0x010B76E8
		[NullableContext(1)]
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			if (inParams == null)
			{
				global::Log.Instance.Error(ELogModule.Event, ELogAuthor.CWZ, "LevelEventEnableEntityLookAt 参数配置错误", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			EnableEntityLookAt param = inParams as EnableEntityLookAt;
			AiModel instance = AiModel.Instance;
			if (instance == null)
			{
				return;
			}
			instance.EnableEntityLookAt(param);
		}
	}
}

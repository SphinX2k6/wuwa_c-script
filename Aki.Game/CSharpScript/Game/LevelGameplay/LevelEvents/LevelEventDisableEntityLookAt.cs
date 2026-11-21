using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02005C89 RID: 23689
	public class LevelEventDisableEntityLookAt : LevelEventBase
	{
		// Token: 0x0603A1DE RID: 238046 RVA: 0x01062362 File Offset: 0x01060562
		public LevelEventDisableEntityLookAt(int id) : base(id)
		{
		}

		// Token: 0x0603A1DF RID: 238047 RVA: 0x0106236C File Offset: 0x0106056C
		[NullableContext(1)]
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			if (inParams == null)
			{
				global::Log.Instance.Error(ELogModule.Event, ELogAuthor.CWZ, "LevelEventDisableEntityLookAt 参数配置错误", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			DisableEntityLookAt disableEntityLookAt = inParams as DisableEntityLookAt;
			AiModel instance = AiModel.Instance;
			if (instance == null)
			{
				return;
			}
			instance.DisableEntityLookAt(disableEntityLookAt.Key);
		}
	}
}

using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Core.Common;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.DemoInteract
{
	// Token: 0x02006C36 RID: 27702
	public class LevelEventSetDemoActorVar : LevelEventBase
	{
		// Token: 0x060444C0 RID: 279744 RVA: 0x010D37A4 File Offset: 0x010D19A4
		public LevelEventSetDemoActorVar(int id) : base(id)
		{
		}

		// Token: 0x060444C1 RID: 279745 RVA: 0x010D37B0 File Offset: 0x010D19B0
		[NullableContext(1)]
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			if (!Info.Instance.IsPlayInEditor)
			{
				return;
			}
			SetActorVar setActorVar = inParams as SetActorVar;
			string[] array = setActorVar.ActorRef.PathName.Split('.', StringSplitOptions.None);
			array[1] + "." + array[2];
			string varLeft = setActorVar.VarLeft;
			if (LevelGamePlayUtils.GetVarValue(setActorVar.VarRight, context) == null)
			{
				global::Log.Instance.Error(ELogModule.LevelEvent, ELogAuthor.ZYL, "[LevelEventSetDemoActorVar] 获取目标变量值失败", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
		}
	}
}

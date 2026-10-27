using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006B12 RID: 27410
	public class LevelEventDrinksRollRoleRequirement : LevelEventBase
	{
		// Token: 0x0604408E RID: 278670 RVA: 0x010B8B29 File Offset: 0x010B6D29
		public LevelEventDrinksRollRoleRequirement(int id) : base(id)
		{
		}

		// Token: 0x0604408F RID: 278671 RVA: 0x010B8B34 File Offset: 0x010B6D34
		[NullableContext(1)]
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			if (inParams == null)
			{
				global::Log.Instance.Error(ELogModule.Event, ELogAuthor.CWZ, "LevelEventDrinksRollRoleRequirement 参数配置错误", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			DrinksRollRoleRequirement drinksRollRoleRequirement = inParams as DrinksRollRoleRequirement;
			DrinksController.Instance.SelectRoleAndPlaySeq(drinksRollRoleRequirement.RoleId, EDrinksGameplayOpenWay.FromEntityNPC, drinksRollRoleRequirement.RequirementId);
		}
	}
}

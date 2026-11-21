using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02005C8A RID: 23690
	public class LevelEventDrinksRollRoleRequirement : LevelEventBase
	{
		// Token: 0x0603A1E0 RID: 238048 RVA: 0x010623B5 File Offset: 0x010605B5
		public LevelEventDrinksRollRoleRequirement(int id) : base(id)
		{
		}

		// Token: 0x0603A1E1 RID: 238049 RVA: 0x010623C0 File Offset: 0x010605C0
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

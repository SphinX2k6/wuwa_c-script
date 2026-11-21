using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.LevelAi.Tasks
{
	// Token: 0x02005F3B RID: 24379
	public class LevelAiTaskLeisureInteract : LevelAiTask
	{
		// Token: 0x0603AA19 RID: 240153 RVA: 0x01091638 File Offset: 0x0108F838
		[NullableContext(1)]
		public unsafe override void MakePlanExpansions(PlanningContext context, LevelAiWorldState worldState)
		{
			string reason = "Leisure Interact Task Make Plan Expansions";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("LevelIndex", context.CurrentLevelIndex);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("StepIndex", context.CurrentStepIndex);
			base.PrintDescription(reason, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			if (!this.IsInit)
			{
				this.Init();
			}
			this.CreatePlanSteps(context, worldState.MakeCopy());
		}

		// Token: 0x0603AA1A RID: 240154 RVA: 0x010916C0 File Offset: 0x0108F8C0
		public void Init()
		{
			if (this.IsInit)
			{
				return;
			}
			NpcLeisureInteract npcLeisureInteract = this.Params as NpcLeisureInteract;
			if (npcLeisureInteract == null)
			{
				return;
			}
			LevelAiTask levelAiTask = null;
			ENpcLeisureInteract type = npcLeisureInteract.Option.Type;
			if (type <= ENpcLeisureInteract.SwingGetUp)
			{
				levelAiTask = new LevelAiTaskSitDown();
				levelAiTask.Serialize(base.CharacterPlanComponent, base.CreatureDataComponent, this.Description + " SitDownTask", npcLeisureInteract);
			}
			else
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.LevelAi;
				ELogAuthor author = ELogAuthor.YJX;
				string message = "[LevelAiTaskLeisureInteract] 未配置正确的行为类型";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("PbDataId", base.CreatureDataComponent.GetPbDataId());
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			if (levelAiTask != null)
			{
				if (this.NextNodes.Count > 0)
				{
					foreach (LevelAiStandaloneNode item in this.NextNodes)
					{
						levelAiTask.NextNodes.Add(item);
					}
					this.NextNodes.Clear();
				}
				this.NextNodes.Add(levelAiTask);
			}
			this.IsInit = true;
		}

		// Token: 0x0401ECF2 RID: 126194
		public bool CanRecordPlanProgress;

		// Token: 0x0401ECF3 RID: 126195
		public int Cost;

		// Token: 0x0401ECF4 RID: 126196
		private bool IsInit;
	}
}

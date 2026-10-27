using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.LevelAi.Tasks
{
	// Token: 0x02006DBC RID: 28092
	public class LevelAiTaskLeisureInteract : LevelAiTask
	{
		// Token: 0x060448B5 RID: 280757 RVA: 0x010E7410 File Offset: 0x010E5610
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

		// Token: 0x060448B6 RID: 280758 RVA: 0x010E7498 File Offset: 0x010E5698
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

		// Token: 0x04023A50 RID: 146000
		public bool CanRecordPlanProgress;

		// Token: 0x04023A51 RID: 146001
		public int Cost;

		// Token: 0x04023A52 RID: 146002
		private bool IsInit;
	}
}

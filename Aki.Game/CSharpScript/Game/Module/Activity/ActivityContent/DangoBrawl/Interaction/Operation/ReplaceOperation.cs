using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Interaction.Commit;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Touch;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Interaction.Operation
{
	// Token: 0x02006874 RID: 26740
	[NullableContext(2)]
	[Nullable(0)]
	public sealed class ReplaceOperation : IInteractionOperation
	{
		// Token: 0x1700979A RID: 38810
		// (get) Token: 0x06042C42 RID: 273474 RVA: 0x0103FE32 File Offset: 0x0103E032
		public EDangoBrawlOptionType Type
		{
			get
			{
				return EDangoBrawlOptionType.Confim;
			}
		}

		// Token: 0x1700979B RID: 38811
		// (get) Token: 0x06042C43 RID: 273475 RVA: 0x0103FE35 File Offset: 0x0103E035
		private static DangoBrawlTouchController Touch
		{
			get
			{
				return DangoBrawlModel.Instance.GetTouchController();
			}
		}

		// Token: 0x1700979C RID: 38812
		// (get) Token: 0x06042C44 RID: 273476 RVA: 0x0103FE41 File Offset: 0x0103E041
		private static DragContext Context
		{
			get
			{
				DangoBrawlTouchController touchController = DangoBrawlModel.Instance.GetTouchController();
				if (touchController == null)
				{
					return null;
				}
				return touchController.GetContext();
			}
		}

		// Token: 0x1700979D RID: 38813
		// (get) Token: 0x06042C45 RID: 273477 RVA: 0x0103FE58 File Offset: 0x0103E058
		private static InteractionStateMachine Fsm
		{
			get
			{
				DangoBrawlTouchController touchController = DangoBrawlModel.Instance.GetTouchController();
				if (touchController == null)
				{
					return null;
				}
				return touchController.GetInteractionFsm();
			}
		}

		// Token: 0x1700979E RID: 38814
		// (get) Token: 0x06042C46 RID: 273478 RVA: 0x0103FE6F File Offset: 0x0103E06F
		private static DangoBrawlRollbackController Rollback
		{
			get
			{
				return DangoBrawlModel.Instance.GetRollbackController();
			}
		}

		// Token: 0x06042C47 RID: 273479 RVA: 0x0103FE7B File Offset: 0x0103E07B
		[NullableContext(0)]
		public UniTask<bool> Execute(in OperationContext ctx)
		{
			return ReplaceOperation.ExecuteAsync();
		}

		// Token: 0x06042C48 RID: 273480 RVA: 0x0103FE84 File Offset: 0x0103E084
		public bool CanExecute(in OperationContext ctx)
		{
			bool context = ReplaceOperation.Context != null;
			InteractionStateMachine fsm = ReplaceOperation.Fsm;
			if (!context || fsm == null)
			{
				return false;
			}
			InteractionPayload payLoad = fsm.GetPayLoad();
			if (payLoad == null || !ReplaceOperation.IsBagTarget(payLoad))
			{
				return false;
			}
			DangoBrawlTouchController touch = ReplaceOperation.Touch;
			DangoBrawlBackpackData dangoBrawlBackpackData = (touch != null) ? touch.Data.BagpackData : null;
			DangoBrawlTouchController touch2 = ReplaceOperation.Touch;
			DangoBrawlBenchData dangoBrawlBenchData = (touch2 != null) ? touch2.Data.BenchData : null;
			if (dangoBrawlBackpackData == null || dangoBrawlBenchData == null)
			{
				return false;
			}
			DragTargetBag value = payLoad.LastTarget.Bag.Value;
			return DangoBrawlPlaceUtil.EvaluatePrimaryMode(dangoBrawlBackpackData, payLoad.Visual, value.LeftTopPos, value.Rotate) != EDangoBrawlPlaceMode.Cannot;
		}

		// Token: 0x06042C49 RID: 273481 RVA: 0x0103FF20 File Offset: 0x0103E120
		[NullableContext(0)]
		private static UniTask<bool> ExecuteAsync()
		{
			ReplaceOperation.<ExecuteAsync>d__12 <ExecuteAsync>d__;
			<ExecuteAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteAsync>d__.<>1__state = -1;
			<ExecuteAsync>d__.<>t__builder.Start<ReplaceOperation.<ExecuteAsync>d__12>(ref <ExecuteAsync>d__);
			return <ExecuteAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06042C4A RID: 273482 RVA: 0x0103FF5C File Offset: 0x0103E15C
		[NullableContext(1)]
		private static bool IsBagTarget(InteractionPayload entry)
		{
			DragTarget lastTarget = entry.LastTarget;
			return lastTarget != null && lastTarget.Kind == EDragTargetKind.Bag && lastTarget.Bag != null;
		}

		// Token: 0x06042C4B RID: 273483 RVA: 0x0103FF8C File Offset: 0x0103E18C
		[NullableContext(1)]
		[return: Nullable(2)]
		private static ReplacePlan TryBuildPlan(InteractionPayload entry, DangoBrawlBackpackData bag, DangoBrawlBenchData bench, bool interactive)
		{
			DragTargetBag value = entry.LastTarget.Bag.Value;
			IDragVisual visual = entry.Visual;
			DangoBrawlPlacementResult dangoBrawlPlacementResult = DangoBrawlPlaceUtil.EvaluatePlan(bag, visual, value.LeftTopPos, value.Rotate, false, true);
			if (dangoBrawlPlacementResult.Mode == EDangoBrawlPlaceMode.Cannot)
			{
				if (interactive)
				{
					ScrollingTipsController.Instance.ShowTipsByText("越界，无法替换");
				}
				return null;
			}
			DangoBrawlTouchController touch = ReplaceOperation.Touch;
			bool flag = touch != null && touch.IsLayerMode;
			List<DangoBrawlBackpackItemData> list = new List<DangoBrawlBackpackItemData>(dangoBrawlPlacementResult.ItemsToReplace.Length);
			foreach (DangoBrawlReplacedItem dangoBrawlReplacedItem in dangoBrawlPlacementResult.ItemsToReplace)
			{
				if (!flag || dangoBrawlReplacedItem.Item.MyTemplateType == EDangoBrawlTemplateType.Bag)
				{
					list.Add(dangoBrawlReplacedItem.Item);
				}
			}
			if (interactive && !bench.HasCapacityFor(list.Count + visual.Followers.Length))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.DangoBrawl;
				ELogAuthor author = ELogAuthor.LSH;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(59, 2);
				defaultInterpolatedStringHandler.AppendLiteral("[Replace] 备战席容量预估不足（主物品驱逐 ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(list.Count);
				defaultInterpolatedStringHandler.AppendLiteral(" + follower 最坏 ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(visual.Followers.Length);
				defaultInterpolatedStringHandler.AppendLiteral(" 个），将由 Sticky 手持兜底");
				instance.Warn(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			return new ReplacePlan
			{
				AllItemsToMove = list,
				DraggingPos = dangoBrawlPlacementResult.PrimaryDraggingPos,
				LeftTopPos = value.LeftTopPos,
				PrimaryExclude = ((visual.Source == EDragSourceKind.Bag || visual.Source == EDragSourceKind.Bench) ? visual.SourceUid : -1)
			};
		}

		// Token: 0x06042C4C RID: 273484 RVA: 0x0104011C File Offset: 0x0103E31C
		[NullableContext(1)]
		[return: Nullable(0)]
		private static UniTask<bool> ReplaceLayered(InteractionStateMachine fsm, InteractionPayload entry, DangoBrawlBackpackData bag, ReplacePlan plan)
		{
			ReplaceOperation.<ReplaceLayered>d__15 <ReplaceLayered>d__;
			<ReplaceLayered>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ReplaceLayered>d__.fsm = fsm;
			<ReplaceLayered>d__.entry = entry;
			<ReplaceLayered>d__.bag = bag;
			<ReplaceLayered>d__.plan = plan;
			<ReplaceLayered>d__.<>1__state = -1;
			<ReplaceLayered>d__.<>t__builder.Start<ReplaceOperation.<ReplaceLayered>d__15>(ref <ReplaceLayered>d__);
			return <ReplaceLayered>d__.<>t__builder.Task;
		}

		// Token: 0x06042C4D RID: 273485 RVA: 0x01040178 File Offset: 0x0103E378
		[NullableContext(1)]
		[return: Nullable(0)]
		private static UniTask<bool> ExecuteReplacement(DangoBrawlTouchController touch, InteractionStateMachine fsm, InteractionPayload entry, DangoBrawlBackpackData bag, ReplacePlan plan)
		{
			ReplaceOperation.<ExecuteReplacement>d__16 <ExecuteReplacement>d__;
			<ExecuteReplacement>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteReplacement>d__.touch = touch;
			<ExecuteReplacement>d__.fsm = fsm;
			<ExecuteReplacement>d__.entry = entry;
			<ExecuteReplacement>d__.bag = bag;
			<ExecuteReplacement>d__.plan = plan;
			<ExecuteReplacement>d__.<>1__state = -1;
			<ExecuteReplacement>d__.<>t__builder.Start<ReplaceOperation.<ExecuteReplacement>d__16>(ref <ExecuteReplacement>d__);
			return <ExecuteReplacement>d__.<>t__builder.Task;
		}

		// Token: 0x06042C4E RID: 273486 RVA: 0x010401DC File Offset: 0x0103E3DC
		[NullableContext(1)]
		private static DangoBrawlBagOpInfo[] BuildReplacedToBenchOps(List<DangoBrawlBackpackItemData> items)
		{
			List<DangoBrawlBagOpInfo> list = new List<DangoBrawlBagOpInfo>(items.Count);
			foreach (DangoBrawlBackpackItemData dangoBrawlBackpackItemData in items)
			{
				DangoBrawlBagOpInfo dangoBrawlBagOpInfo = DangoBrawlBagOpInfo.Create();
				dangoBrawlBagOpInfo.FromUid = dangoBrawlBackpackItemData.MyUid;
				dangoBrawlBagOpInfo.OpType = DangoBrawlBagOpType.ToBench;
				list.Add(dangoBrawlBagOpInfo);
			}
			return list.ToArray();
		}

		// Token: 0x06042C50 RID: 273488 RVA: 0x01040260 File Offset: 0x0103E460
		bool IInteractionOperation.CanExecute(in OperationContext ctx)
		{
			return this.CanExecute(ctx);
		}

		// Token: 0x06042C51 RID: 273489 RVA: 0x01040269 File Offset: 0x0103E469
		[return: Nullable(0)]
		UniTask<bool> IInteractionOperation.Execute(in OperationContext ctx)
		{
			return this.Execute(ctx);
		}
	}
}

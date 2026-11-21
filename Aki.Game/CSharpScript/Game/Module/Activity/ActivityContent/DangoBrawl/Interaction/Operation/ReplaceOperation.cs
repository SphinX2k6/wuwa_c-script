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
	// Token: 0x020057C4 RID: 22468
	[NullableContext(2)]
	[Nullable(0)]
	public sealed class ReplaceOperation : IInteractionOperation
	{
		// Token: 0x17006ADB RID: 27355
		// (get) Token: 0x06037799 RID: 227225 RVA: 0x00F81312 File Offset: 0x00F7F512
		public EDangoBrawlOptionType Type
		{
			get
			{
				return EDangoBrawlOptionType.Confim;
			}
		}

		// Token: 0x17006ADC RID: 27356
		// (get) Token: 0x0603779A RID: 227226 RVA: 0x00F81315 File Offset: 0x00F7F515
		private static DangoBrawlTouchController Touch
		{
			get
			{
				return DangoBrawlModel.Instance.GetTouchController();
			}
		}

		// Token: 0x17006ADD RID: 27357
		// (get) Token: 0x0603779B RID: 227227 RVA: 0x00F81321 File Offset: 0x00F7F521
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

		// Token: 0x17006ADE RID: 27358
		// (get) Token: 0x0603779C RID: 227228 RVA: 0x00F81338 File Offset: 0x00F7F538
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

		// Token: 0x17006ADF RID: 27359
		// (get) Token: 0x0603779D RID: 227229 RVA: 0x00F8134F File Offset: 0x00F7F54F
		private static DangoBrawlRollbackController Rollback
		{
			get
			{
				return DangoBrawlModel.Instance.GetRollbackController();
			}
		}

		// Token: 0x0603779E RID: 227230 RVA: 0x00F8135B File Offset: 0x00F7F55B
		[NullableContext(0)]
		public UniTask<bool> Execute(in OperationContext ctx)
		{
			return ReplaceOperation.ExecuteAsync();
		}

		// Token: 0x0603779F RID: 227231 RVA: 0x00F81364 File Offset: 0x00F7F564
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

		// Token: 0x060377A0 RID: 227232 RVA: 0x00F81400 File Offset: 0x00F7F600
		[NullableContext(0)]
		private static UniTask<bool> ExecuteAsync()
		{
			ReplaceOperation.<ExecuteAsync>d__12 <ExecuteAsync>d__;
			<ExecuteAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteAsync>d__.<>1__state = -1;
			<ExecuteAsync>d__.<>t__builder.Start<ReplaceOperation.<ExecuteAsync>d__12>(ref <ExecuteAsync>d__);
			return <ExecuteAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060377A1 RID: 227233 RVA: 0x00F8143C File Offset: 0x00F7F63C
		[NullableContext(1)]
		private static bool IsBagTarget(InteractionPayload entry)
		{
			DragTarget lastTarget = entry.LastTarget;
			return lastTarget != null && lastTarget.Kind == EDragTargetKind.Bag && lastTarget.Bag != null;
		}

		// Token: 0x060377A2 RID: 227234 RVA: 0x00F8146C File Offset: 0x00F7F66C
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

		// Token: 0x060377A3 RID: 227235 RVA: 0x00F815FC File Offset: 0x00F7F7FC
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

		// Token: 0x060377A4 RID: 227236 RVA: 0x00F81658 File Offset: 0x00F7F858
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

		// Token: 0x060377A5 RID: 227237 RVA: 0x00F816BC File Offset: 0x00F7F8BC
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

		// Token: 0x060377A7 RID: 227239 RVA: 0x00F81740 File Offset: 0x00F7F940
		bool IInteractionOperation.CanExecute(in OperationContext ctx)
		{
			return this.CanExecute(ctx);
		}

		// Token: 0x060377A8 RID: 227240 RVA: 0x00F81749 File Offset: 0x00F7F949
		[return: Nullable(0)]
		UniTask<bool> IInteractionOperation.Execute(in OperationContext ctx)
		{
			return this.Execute(ctx);
		}
	}
}
